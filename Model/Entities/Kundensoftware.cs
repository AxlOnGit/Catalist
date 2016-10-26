using System;
using Products.Data;
using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Kundensoftware
	{
		#region members

		readonly dsSoftware.KundenSoftwareRow myBase;
		readonly Kunde myCustomer;
		private Kundenmaschine myMachine;
		readonly DateTime noDate = new DateTime(100, 1, 1, 0, 0, 0);

		#endregion members

		#region private properties

		public string UID { get { return myBase.UID; } }

		public string Kundennummer
		{
			get { return myBase.Kundennummer; }
			set
			{
				if (this.myBase.Kundennummer.Equals(value)) return;
				myBase.Kundennummer = value;
			}
		}

		public string KundenmaschineId
		{
			get
			{
				if (myBase.IsKundenMaschineIdNull())
				{
					return null;
				}
				return myBase.KundenMaschineId;
			}
			set
			{
				if (value == null) myBase.SetKundenMaschineIdNull();
				else myBase.KundenMaschineId = value;
			}
		}

		public string SoftwareId
		{
			get
			{
				if (myBase.IsSoftwareIdNull())
				{
					return null;
				}
				else return myBase.SoftwareId;
			}
			set
			{
				if (value == null)
				{
					myBase.SetSoftwareIdNull();
				}
				else myBase.SoftwareId = value;
			}
		}

		public string Softwarename
		{
			get
			{
				if (this.SoftwareId == null) return string.Empty;
				return ModelManager.SoftwareService.GetSoftware(this.SoftwareId).Softwarename;
			}
		}

		public string Lizenzschluessel
		{
			get
			{
				if (myBase.IsLizenzschluesselNull())
				{
					return null;
				}
				else return myBase.Lizenzschluessel;
			}
			set
			{
				if (value == null)
				{
					myBase.SetLizenzschluesselNull();
				}
				else myBase.Lizenzschluessel = value;
			}
		}

		public string Anmerkungen
		{
			get
			{
				if (myBase.IsAnmerkungenNull())
				{
					return null;
				}
				return myBase.Anmerkungen;
			}
			set
			{
				if (value == null)
				{
					myBase.SetAnmerkungenNull();
				}
				else myBase.Anmerkungen = value;
			}
		}

		public DateTime? Installationsdatum
		{
			get
			{
				if (!myBase.Installationsdatum.Equals(noDate))
				{
					return myBase.Installationsdatum;
				}
				else return null;
			}
			set
			{
				if (value.HasValue)
				{
					myBase.Installationsdatum = value.Value;
				}
				else myBase.Installationsdatum = noDate;
			}
		}

		public string Computer
		{
			get
			{
				if (myBase.IsComputerNull())
				{
					return null;
				}
				else return myBase.Computer;
			}
			set
			{
				if (value == null)
				{
					myBase.SetComputerNull();
				}
				else myBase.Computer = value;
			}
		}

		public string Hauptbenutzer
		{
			get
			{
				if (myBase.IsHauptbenutzerNull())
				{
					return null;
				}
				return myBase.Hauptbenutzer;
			}
			set
			{
				if (value == null)
				{
					myBase.SetHauptbenutzerNull();
				}
				else myBase.Hauptbenutzer = value;
			}
		}

		public Kunde Kunde { get { return ModelManager.CustomerService.GetKunde(this.Kundennummer, false); } }

		public Kundenmaschine Maschine { get { return myMachine; } }

		#endregion private properties

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der KundenSoftware Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Kundensoftware(dsSoftware.KundenSoftwareRow baseRow, Kunde customer, Kundenmaschine machine = null)
		{
			myBase = baseRow;
			myCustomer = customer;
			myMachine = machine;
		}

		#endregion ### .ctor ###

		#region public procedures

		public bool GetCanDelete()
		{
			return true;
		}

		/// <summary>
		/// Speichert Änderungen an dieser Kundensoftware.
		/// </summary>
		//public void Update()
		//{
		//  ModelManager.SoftwareService.Update();
		//}

		#endregion public procedures
	}
}