using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Products.Model;
using Products.Model.Entities;
using Products.Model.Services;
using Products.Data.Datasets;
using Products.Data;

namespace Products.Model.Builder
{
	public class NotizBuilder
	{

		#region members

		private NotizParentType parentType = NotizParentType.Kunde;
		private Kunde myKunde = null;
		private string myKundennummer = "1000000000";
		private string myKontaktnummer = "00001";
		private string prospectId = "00000000-0000-0000-0000-000000000000";
		private Linktyp myLinkType = null;
		private string myLinkTypId = "00000000-0000-0000-0000-000000000000";
		private string myLinkId = string.Empty;
		private string erfasserId = "00000000-0000-0000-0000-000000000000";
		private string delegiertenId = "00000000-0000-0000-0000-000000000000";
		private DateTime? delegationsDatum = null;

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der NotizBuilder Klasse.
		/// </summary>
		public NotizBuilder(User erfasser, Kunde kunde)
		{
			this.myKunde = kunde;
			this.myKundennummer = kunde.CustomerId;
			this.myKontaktnummer = kunde.Hauptkontakt.Nummer;
			this.erfasserId = erfasser.UID;
			this.myLinkType = ModelManager.SharedItemsService.GetLinkTypeByName("Unbekannt");
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Legt fest, für welchen Elemententyp die Notiz erstellt wird.
		/// </summary>
		/// <param name="parentType"></param>
		/// <returns></returns>
		public NotizBuilder SetParentType(NotizParentType parentType)
		{
			this.parentType = parentType;
			return this;
		}

		/// <summary>
		/// Legt die Kundennummer fest.
		/// </summary>
		/// <param name="kundenNr"></param>
		/// <returns></returns>
		public NotizBuilder SetKundennummer(string kundenNr)
		{
			this.myKundennummer = kundenNr;
			return this;
		}

		/// <summary>
		/// Legt die Nummer des Ansprechpartners fest.
		/// </summary>
		/// <param name="kontaktNr"></param>
		/// <returns></returns>
		public NotizBuilder SetKontaktnummer(string kontaktNr)
		{
			this.myKontaktnummer = kontaktNr;
			return this;
		}

		/// <summary>
		/// Legt den Primärschlüssel des Interessenten fest.
		/// </summary>
		/// <param name="prospectId"></param>
		/// <returns></returns>
		public NotizBuilder SetInteressentenId(string prospectId)
		{
			this.prospectId = prospectId;
			return this;
		}

		/// <summary>
		/// Legt fest, welchen Typ das verknüpfte Element hat.
		/// </summary>
		/// <param name="linkType">Auflistung <seealso cref="Products.Model.LinkTyp"/></param>
		/// <returns></returns>
		public NotizBuilder SetLinkType(Linktyp linkType)
		{
			this.myLinkType = linkType;
			this.myLinkTypId = linkType.UID;

			return this;
		}

		/// <summary>
		/// Legt den Primärschlüssel des verknüpften Elements fest.
		/// </summary>
		/// <param name="linkId"></param>
		/// <returns></returns>
		public NotizBuilder SetLinkId(string linkId)
		{
			this.myLinkId = linkId;
			return this;
		}

		/// <summary>
		/// Legt den Primärschlüssel des Mitarbeiters fest, der für diese Notiz zuständig ist oder werden soll.
		/// </summary>
		/// <param name="delegiertenId">Primärschlüssel eines <seealso cref="Model.Entities.User"/> Objekts.</param>
		/// <returns></returns>
		public NotizBuilder SetDelegiertenId(string delegiertenId)
		{
			this.delegiertenId = delegiertenId;
			return this;
		}

		/// <summary>
		/// Legt das Datum fest, an dem die Notiz delegiert wurde.
		/// </summary>
		/// <param name="delegationsDatum"></param>
		/// <returns></returns>
		public NotizBuilder SetDelegationsdatum(DateTime delegationsDatum)
		{
			this.delegationsDatum = delegationsDatum;
			return this;
		}

		public Notiz Build()
		{
			dsNotes.NotizXrefRow xRefRowKunde = null;
			dsNotes.NotizXrefRow xRefRowKontakt = null;
			dsNotes.NotizXrefRow xRefRowOther = null;

			Notiz newNotiz = new Notiz(DataManager.NotesDataService.AddNotizRow(ModelManager.UserService.CurrentUser.UID, this.myKunde.CustomerId), this.myKunde);

			// XRef Rows erstellen.
			if (newNotiz != null)
			{
				string currentUserPK = ModelManager.UserService.CurrentUser.UID;

				// Für den Kunden und den Hauptkontakt wird immer eine Verknüpfung erstellt.

				xRefRowKunde = DataManager.NotesDataService.AddNotizXrefRow(
					newNotiz.UID,
					this.myKunde.CustomerId,
					ModelManager.SharedItemsService.GetLinkTypeByName("Kunde").UID,
					currentUserPK);

				xRefRowKontakt = DataManager.NotesDataService.AddNotizXrefRow(
					newNotiz.UID,
					string.Format("{0}{1}", this.myKunde.CustomerId, this.myKontaktnummer),
					ModelManager.SharedItemsService.GetLinkTypeByName("Kundenkontakt").UID,
					currentUserPK);

				if (this.myLinkType != ModelManager.SharedItemsService.GetLinkTypeByName("Kunde") && this.myLinkType != ModelManager.SharedItemsService.GetLinkTypeByName("Kundenkontakt"))
				{
					xRefRowOther = DataManager.NotesDataService.AddNotizXrefRow(
						newNotiz.UID,
						this.myLinkId,
						this.myLinkTypId,
						currentUserPK);
				}

				if (this.myLinkType.Bezeichnung == "Kunde")
				{
					newNotiz.SetXrefBase(xRefRowKunde);
					newNotiz.SetContactXrefBase(xRefRowKontakt);
				}
				else if (this.myLinkType.Bezeichnung == "Kundenkontakt")
				{
					newNotiz.SetXrefBase(xRefRowKontakt);
					newNotiz.SetContactXrefBase(xRefRowKontakt);
				}
				else
				{
					newNotiz.SetXrefBase(xRefRowOther);
					newNotiz.SetContactXrefBase(xRefRowKontakt);
				}
				return newNotiz;
			}

			return null;
		}

		#endregion

	}
}
