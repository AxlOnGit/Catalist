using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common.Collections;
using Products.Common.Interfaces;
using Products.Data;
using Products.Data.Datasets;
using Products.Model;
using Products.Model.Entities;
using Products.Model.Services;

namespace Products.Model.Entities
{
	public class Interessent : ILinkedItem
	{

		#region members

		readonly dsProspects.InteressentRow myBase;
		User myAcquiredBy;
		//private SBList<Notiz> notizen = null;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps.
		/// </summary>
		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Interessent").UID; }
		}

		/// <summary>
		/// Bezeichnung der ILinkedItem Instanz.
		/// </summary>
		public string ItemName
		{
			get { return this.Firmenname; }
		}

		/// <summary>
		/// Bezeichnung des LinkedItemTyps.
		/// </summary>
		public string LinkTypBezeichnung
		{
			get { return "Interessent"; }
		}

		#endregion

		#region skalare

		/// <summary>
		/// Gibt den Primärschlüssel (GUID) dieses Interessenten zurück.
		/// </summary>
		public string UID { get { return myBase.UID; } }

		/// <summary>
		/// Gibt das Kennzeichen zurück, ob dieser Interessent aktiv oder inaktiv ist.
		/// </summary>
		public bool InaktivFlag
		{
			get
			{
				return myBase.InaktivFlag != 0;
			}
			set
			{
				myBase.InaktivFlag = (value == false ? 0 : 1);
			}
		}

		public string Firmenname { get { return myBase.Firmenname; } set { myBase.Firmenname = value; } }

		public string Firmenzusatz { get { return myBase.Firmenzusatz; } set { myBase.Firmenzusatz = value; } }

		public string Strasse { get { return myBase.Strasse; } set { myBase.Strasse = value; } }

		public string Adresszusatz { get { return myBase.Adresszusatz; } set { myBase.Adresszusatz = value; } }

		public string Plz { get { return myBase.Plz; } set { myBase.Plz = value; } }

		public string Ort { get { return myBase.Ort; } set { myBase.Ort = value; } }

		public string Kontaktperson { get { return myBase.Kontaktperson; } set { myBase.Kontaktperson = value; } }

		public string Telefon { get { return myBase.Telefon; } set { myBase.Telefon = value; } }

		public string Fax { get { return myBase.Fax; } set { myBase.Fax = value; } }

		public string Mobil { get { return myBase.Mobil; } set { myBase.Mobil = value; } }

		public string Email { get { return myBase.Email; } set { myBase.Email = value; } }

		public string Website { get { return myBase.Website; } set { myBase.Website = value; } }

		public string Herkunft { get { return myBase.Herkunft; } set { myBase.Herkunft = value; } }

		public DateTime AkquiseAm { get { return myBase.AkquiseAm; } set { myBase.AkquiseAm = value; } }

		public string AkquiseDurch { get { return myBase.AkquiseDurch; } set { myBase.AkquiseDurch = value; } }

		public string AkquiseDurchName { get { return this.Akquirierer.NameFull; } }

		public string Anmerkungen { get { return myBase.Anmerkungen; } set { myBase.Anmerkungen = value; } }

		//////////public SBList<Notiz> Notizliste
		//////////{
		//////////  get
		//////////  {

		//////////    if (notizen == null)
		//////////    {
		//////////      notizen = ModelManager.NotesService.GetNotesList(this.UID, ModelManager.SharedItemsService.GetLinkTypeByName("Interessent").UID);
		//////////    }
		//////////    return notizen;
		//////////  }
		//////////}

		#endregion

		#region entities

		/// <summary>
		/// Gibt die Instanz des Mitarbeiters (Users) zurück, durch den dieser Interessent akquiriert wurde.
		/// </summary>
		public User Akquirierer
		{
			get 
			{
				if (this.myAcquiredBy == null && !string.IsNullOrEmpty(myBase.AkquiseDurch))
				{
					this.myAcquiredBy = ModelManager.UserService.FindUser(myBase.AkquiseDurch, UserService.UserSearchParamType.PrimaryKey);
				}
				return this.myAcquiredBy;
			}
			set
			{
				this.myAcquiredBy = value;
				myBase.AkquiseDurch = value.UID;
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der Interessent Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Interessent(dsProspects.InteressentRow baseRow)
		{
			myBase = baseRow;

		}

		#endregion

		#region public procedures

		/// <summary>
		/// Aktualisiert die Tabelle Interessenten.
		/// </summary>
		public void Update()
		{
			ModelManager.ProspectService.UpdateInteressenten();
		}

		#endregion

		#region private procedures

		#endregion

	}
}
