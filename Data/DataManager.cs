﻿using Products.Data.Services;

namespace Products.Data
{
	public static class DataManager
	{

		#region members

		private static AppointmentDataService myAppointmentDataSvc = null;
		private static CatalogDataService myCatalogDataSvc = null;
		private static ContactDataService myContactDataSvc = null;
		private static CustomerDataService myCustomerDataSvc = null;
		private static DataService myDataSvc = null;
		private static FileLinkDataService myFileLinkDataSvc = null;
		private static MachineDataService myMachineDataSvc = null;
		private static NotesDataService myNotesDataSvc = null;
		private static OfferDataService myOfferDataSvc = null;
		private static OrderDataService myOrderDataSvc = null;
		private static ProductDataService myProductDataSvc = null;
		private static ProspectDataService myProspectDataSvc = null;
		private static SalesDataService mySalesDataSvc = null;
		private static SalesForceDataService mySalesForceDataSvc = null;
		private static SharedDataService mySharedDataSvc = null;
		private static SoftwareDataService mySoftwareDataSvc = null;
		private static SupplierDataService mySupplierDataSvc = null;
		private static TaskDataService myTaskDataSvc = null;
		private static UserDataService myUserSvc = null;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den Primärschlüssel des aktuell am System angemeldeten Benutzers zurück oder legt ihn fest.
		/// </summary>
		public static string CurrentUserPK { get; set; }

		/// <summary>
		/// Gibt den statischen singleton DataService des Systems zurück.
		/// </summary>
		public static DataService AllDataService
		{
			get
			{
				if (myDataSvc == null)
				{
					myDataSvc = new DataService();
				}
				return myDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton AppointmentDataService des Systems zurück.
		/// </summary>
		public static AppointmentDataService AppointmentDataService
		{
			get
			{
				if (myAppointmentDataSvc == null)
				{
					myAppointmentDataSvc = new AppointmentDataService(CurrentUserPK);
				}
				return myAppointmentDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton CatalogDataService des Systems zurück.
		/// </summary>
		public static CatalogDataService CatalogDataService
		{
			get
			{
				if (myCatalogDataSvc == null)
				{
					myCatalogDataSvc = new CatalogDataService(CurrentUserPK);

				}
				return myCatalogDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton ContactDataService des Systems zurück.
		/// </summary>
		public static ContactDataService ContactDataService
		{
			get
			{
				if (myContactDataSvc == null)
				{
					myContactDataSvc = new ContactDataService(CurrentUserPK);
				}
				return myContactDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton CustomerDataService des Systems zurück.
		/// </summary>
		public static CustomerDataService CustomerDataService
		{
			get
			{
				if (myCustomerDataSvc == null)
				{
					myCustomerDataSvc = new CustomerDataService(CurrentUserPK);
				}
				return myCustomerDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton FileLinkDataService des Systems zurück.
		/// </summary>
		public static FileLinkDataService FileLinkDataService
		{
			get
			{
				if (myFileLinkDataSvc == null)
				{
					myFileLinkDataSvc = new FileLinkDataService(CurrentUserPK);
				}
				return myFileLinkDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton MachineDataService des Systems zurück.
		/// </summary>
		public static MachineDataService MachineDataService
		{
			get
			{
				if (myMachineDataSvc == null)
				{
					myMachineDataSvc = new MachineDataService(CurrentUserPK);
				}
				return myMachineDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton NotesDataService des Systems zurück.
		/// </summary>
		public static NotesDataService NotesDataService
		{
			get
			{
				if (myNotesDataSvc == null)
				{
					myNotesDataSvc = new NotesDataService(CurrentUserPK);
				}
				return myNotesDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton OfferDataService des Systems zurück.
		/// </summary>
		public static OfferDataService OfferDataService
		{
			get
			{
				if (myOfferDataSvc == null)
				{
					myOfferDataSvc = new OfferDataService(CurrentUserPK);
				}
				return myOfferDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton OrderDataService des Systems zurück.
		/// </summary>
		public static OrderDataService OrderDataService
		{
			get
			{
				if (myOrderDataSvc == null)
				{
					myOrderDataSvc = new OrderDataService(CurrentUserPK);
				}
				return myOrderDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton ProductDataService des Systems zurück.
		/// </summary>
		public static ProductDataService ProductDataService
		{
			get
			{
				if (myProductDataSvc == null)
				{
					myProductDataSvc = new ProductDataService(CurrentUserPK);
				}
				return myProductDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton ProspectDataService des Systems zurück.
		/// </summary>
		public static ProspectDataService ProspectDataService
		{
			get
			{
				if (myProspectDataSvc == null)
				{
					myProspectDataSvc = new ProspectDataService(CurrentUserPK);
				}
				return myProspectDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SalesDataService des Systems zurück.
		/// </summary>
		public static SalesDataService SalesDataService
		{
			get
			{
				if (mySalesDataSvc == null)
				{
					mySalesDataSvc = new SalesDataService(CurrentUserPK);
				}
				return mySalesDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SalesDataService des Systems zurück.
		/// </summary>
		public static SalesForceDataService SalesForceDataService
		{
			get
			{
				if (mySalesForceDataSvc == null)
				{
					mySalesForceDataSvc = new SalesForceDataService(CurrentUserPK);
				}
				return mySalesForceDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SharedDataService des Systems zurück.
		/// </summary>
		public static SharedDataService SharedDataService
		{
			get
			{
				if (mySharedDataSvc == null)
				{
					mySharedDataSvc = new SharedDataService(CurrentUserPK);
				}
				return mySharedDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SoftwareDataService des Systems zurück.
		/// </summary>
		public static SoftwareDataService SoftwareDataService
		{
			get
			{
				if (mySoftwareDataSvc == null)
				{
					mySoftwareDataSvc = new SoftwareDataService(CurrentUserPK);
				}
				return mySoftwareDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SupplierDataService des Systems zurück.
		/// </summary>
		public static SupplierDataService SupplierDataService
		{
			get
			{
				if (mySupplierDataSvc == null)
				{
					mySupplierDataSvc = new SupplierDataService(CurrentUserPK);
				}
				return mySupplierDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton TaskDataService des Systems zurück.
		/// </summary>
		public static TaskDataService TaskDataService
		{
			get
			{
				if (myTaskDataSvc == null)
				{
					myTaskDataSvc = new TaskDataService(CurrentUserPK);
				}
				return myTaskDataSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton UserDataService das Systems zurück.
		/// </summary>
		public static UserDataService UserDataService
		{
			get
			{
				if (myUserSvc == null)
				{
					myUserSvc = new UserDataService();
				}
				return myUserSvc;
			}
		}
	
		#endregion

	}
}