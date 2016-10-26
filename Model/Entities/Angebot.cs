using System;
using Products.Common;
using Products.Common.Interfaces;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	/// <summary>
	/// Repräsentiert ein Sage Angebot.
	/// </summary>
	public class Angebot : ILinkedItem
	{

		#region members

		readonly dsSales.AngebotSageRow myBase;

		#endregion

		#region public properties

		#region ILinkedItem

		public string ItemName
		{
			get
			{
				return string.Format("Angebot {0}", this.myBase.Nummer);
			}
		}

		public string Key
		{
			get
			{
				return this.myBase.Nummer;
			}
		}

		public string LinkTypBezeichnung
		{
			get
			{
				return "Angebot";
			}
		}

		public string LinkTypeId
		{
			get
			{
				return "bd12ef61-e7ec-43ec-b95b-340c4198d9e7";
			}
		}

		#endregion

		#region SCALAR

		//Nummer
		public string Nummer { get { return this.myBase.Nummer; } }

		//Datum
		public DateTime Datum { get { return this.myBase.Datum; } }

		//Kundennummer
		public string Kundennummer { get { return this.myBase.Kundennummer; } }

		public Kunde Kunde { get { return ModelManager.CustomerService.GetKunde(this.Kundennummer, false); } }

		/// <summary>
		/// Gibt den Kunden-Matchcode zurück.
		/// </summary>
		public string Matchcode { get { if (this.Kunde != null) return this.Kunde.Matchcode; return string.Empty; } }

		//Vertreter1
		public string Vertreter { get { return this.myBase.Vertreter1; } }

		//Rechnungskunde
		public string Rechnungskundennummer { get { return this.myBase.Rechnungskunde; } }

		public Kunde Rechnungskunde { get { return ModelManager.CustomerService.GetKunde(this.Rechnungskundennummer, false); } }

		//SummeZKD1_USt_1
		public decimal Nettobetrag1 { get { return this.myBase.SummeZKD1_USt_1; } }

		//SummeZKD2_USt_1
		public decimal Nettobetrag2 { get { return this.myBase.SummeZKD2_USt_1; } }

		//Bruttosumme
		public decimal Bruttosumme { get { return this.myBase.Bruttosumme; } }

		//Roherloes
		public decimal Roherloes { get { return this.myBase.Roherloes; } }

		//Gesamtrabatt
		public decimal Gesamtrabatt { get { return this.myBase.Gesamtrabatt; } }

		//Ansprechpartnernummer
		public string Kontaktnummer { get { return this.myBase.Ansprechpartnernummer; } }

		public Kundenkontakt Kontakt
		{
			get
			{
				var list = ModelManager.ContactService.GetContactListForCustomer(this.Kunde.CustomerId);
				foreach (var contact in list)
				{
					if (contact.Nummer.Equals(this.Kontaktnummer, StringComparison.CurrentCultureIgnoreCase)) return contact;
				}
				return null;
			}
		}

		//SteuersatzSumme1
		public decimal Steuersatz { get { return this.myBase.SteuersatzSumme1; } }

		//Timestamp_Datum
		DateTime Timestamp_Datum { get { return this.myBase.Timestamp_Datum; } }

		//Timestamp_Zeit
		TimeSpan Timestamp_Zeit { get { return this.myBase.Timestamp_Zeit; } }

		/// <summary>
		/// Gibt Datum und Uhrzeit des Timestamps zurück.
		/// </summary>
		public DateTime Timestamp
		{
			get
			{
				var year = this.Timestamp_Datum.Year;
				var month = this.Timestamp_Datum.Month;
				var day = this.Timestamp_Datum.Day;
				var hours = this.Timestamp_Zeit.Hours;
				var minutes = this.Timestamp_Zeit.Minutes;
				var datum = new DateTime(year, month, day, hours, minutes, 0);
				return datum;
			}
		}

		#endregion

		#region ENTITIES

		public SortableBindingList<AngebotsDetail> AngebotsDetails
		{
			get
			{
				return ModelManager.SalesService.GetAngebotsDetails(this);
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="Angebot"/> Klasse. Sie repräsentiert ein Angebot, das in SAGE erstellt wurde.
		/// </summary>
		/// <param name="baseRow"></param>
		public Angebot(dsSales.AngebotSageRow baseRow)
		{
			this.myBase = baseRow;
		}

		#endregion

	}
}
