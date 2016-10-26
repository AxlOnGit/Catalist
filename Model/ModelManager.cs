using Products.Common;
using Products.Model.Services;

namespace Products.Model
{
	public static class ModelManager
	{

		#region members

		static AppointmentService myAppointmentSvc;
		static CatalogService myCatalogSvc;
		static ContactService myContactSvc;
		static CustomerService myCustomerSvc;
		static DavidService myDavidSvc;
		static FileLinkService myFileLinkSvc;
		static FileSystemService myFileSystemSvc;
		static MachineService myMachineSvc;
		static ModelService myModelSvc;
		static NotesService myNotesSvc;
		static OfferService myOfferSvc;
		static OrderService myOrderSvc;
		static PostOffice myPostSvc;
		static ProductService myProductSvc;
		static ProspectService myProspectSvc;
		static ReminderService myReminderSvc;
		static SalesService mySalesSvc;
		static SalesForceService mySalesForceSvc;
		static Scheduler myScheduler;
		static SharedItemsService mySharedItemsSvc;
		static SoftwareService mySoftwareSvc;
		static SupplierService mySupplierSvc;
		static TaskService myTaskSvc;
		static TechnikService myTechnikSvc;
		static UserService myUserSvc;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den Primärschlüssel des derzeit angemeldeten Users zurück oder legt ihn fest.
		/// </summary>
		internal static string CurrentUserPK { get; set; }

		/// <summary>
		/// Gibt den statischen singleton AppointmentService des Systems zurück.
		/// </summary>
		public static AppointmentService AppointmentService
		{
			get
			{
				if (myAppointmentSvc == null)
				{
					myAppointmentSvc = new AppointmentService(CurrentUserPK);
				}
				return myAppointmentSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton CatalogService des Systems zurück.
		/// </summary>
		public static CatalogService CatalogService
		{
			get
			{
				if (myCatalogSvc == null)
				{
					myCatalogSvc = new CatalogService();
				}
				return myCatalogSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton ContactService des Systems zurück.
		/// </summary>
		public static ContactService ContactService
		{
			get
			{
				if (myContactSvc == null)
				{
					myContactSvc = new ContactService();
				}
				return myContactSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton Customerservice des Systems zurück.
		/// </summary>
		public static CustomerService CustomerService
		{
			get
			{
				if (myCustomerSvc == null)
				{
					myCustomerSvc = new CustomerService();
				}
				return myCustomerSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton DavidService des Systems zurück.
		/// </summary>
		public static DavidService DavidService
		{
			get
			{
				if (myDavidSvc == null)
				{
					myDavidSvc = new DavidService();
				}
				return myDavidSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singeleton FileLinkService des Systems zurück.
		/// </summary>
		public static FileLinkService FileLinkService
		{
			get
			{
				if (myFileLinkSvc == null)
				{
					myFileLinkSvc = new FileLinkService();
				}
				return myFileLinkSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton FileSystemService des Systems zurück.
		/// </summary>
		public static FileSystemService FileSystemService
		{
			get
			{
				if (myFileSystemSvc == null)
				{
					myFileSystemSvc = new FileSystemService();
				}
				return myFileSystemSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton MachineService des Systems zurück.
		/// </summary>
		public static MachineService MachineService
		{
			get
			{
				if (myMachineSvc == null)
				{
					myMachineSvc = new MachineService();
				}
				return myMachineSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton ModelService des Systems zurück.
		/// </summary>
		public static ModelService ModelService
		{
			get
			{
				if (myModelSvc == null)
				{
					myModelSvc = new ModelService();
				}
				return myModelSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singelton NotesService des Systems zurück.
		/// </summary>
		public static NotesService NotesService
		{
			get
			{
				if (myNotesSvc == null)
				{
					myNotesSvc = new NotesService(CurrentUserPK);
				}
				return myNotesSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton OfferService des Systems zurück.
		/// </summary>
		public static OfferService OfferService
		{
			get
			{
				if (myOfferSvc == null)
				{
					myOfferSvc = new OfferService();
				}
				return myOfferSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton OrderService des Systems zurück.
		/// </summary>
		public static OrderService OrderService
		{
			get
			{
				if (myOrderSvc == null)
				{
					myOrderSvc = new OrderService();
				}
				return myOrderSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton Postbüdel des Systems zurück.
		/// </summary>
		public static Common.PostOffice PostBuedel
		{
			get
			{
				if (myPostSvc == null)
				{
					myPostSvc = new Common.PostOffice(UserService.CurrentUser.LoginWindows, Global.SenderPW, UserService.CurrentUser.EmailWork);
				}
				return myPostSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton ProductService des Systems zurück.
		/// </summary>
		public static ProductService ProductService
		{
			get
			{
				if (myProductSvc == null)
				{
					myProductSvc = new ProductService();
				}
				return myProductSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton ProspectService des Systems zurück.
		/// </summary>
		public static ProspectService ProspectService
		{
			get
			{
				if (myProspectSvc == null)
				{
					myProspectSvc = new ProspectService();
				}
				return myProspectSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton ReminderService das Systems zurück.
		/// </summary>
		public static ReminderService ReminderService
		{
			get
			{
				if (myReminderSvc == null)
				{
					myReminderSvc = new ReminderService();
				}
				return myReminderSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SalesService des Systems zurück.
		/// </summary>
		public static SalesForceService SalesForceService
		{
			get
			{
				if (mySalesForceSvc == null)
				{
					mySalesForceSvc = new SalesForceService();
				}
				return mySalesForceSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SalesService des Systems zurück.
		/// </summary>
		public static SalesService SalesService
		{
			get
			{
				if (mySalesSvc == null)
				{
					mySalesSvc = new SalesService();
				}
				return mySalesSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton Scheduler des Systems zurück.
		/// </summary>
		public static Scheduler SchedulerService
		{
			get
			{
				if (myScheduler == null)
				{
					myScheduler = new Scheduler(10);
				}
				return myScheduler;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SharedItemsService des Systems zurück.
		/// </summary>
		public static SharedItemsService SharedItemsService
		{
			get
			{
				if (mySharedItemsSvc == null)
				{
					mySharedItemsSvc = new SharedItemsService();
				}
				return mySharedItemsSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SoftwareService des Systems zurück.
		/// </summary>
		public static SoftwareService SoftwareService
		{
			get
			{
				if (mySoftwareSvc == null)
				{
					mySoftwareSvc = new SoftwareService();
				}
				return mySoftwareSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton SupplierService des Systems zurück.
		/// </summary>
		public static SupplierService SupplierService
		{
			get
			{
				if (mySupplierSvc == null)
				{
					mySupplierSvc = new SupplierService();
				}
				return mySupplierSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton TaskService des Systems zurück.
		/// </summary>
		public static TaskService TaskService
		{
			get
			{
				if (myTaskSvc == null)
				{
					myTaskSvc = new TaskService(ModelManager.UserService.CurrentUser.UID);
				}
				return myTaskSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton TechnikService des Systems zurück.
		/// </summary>
		public static TechnikService TechnikService
		{
			get
			{
				if (myTechnikSvc == null)
				{
					myTechnikSvc = new TechnikService();
				}
				return myTechnikSvc;
			}
		}

		/// <summary>
		/// Gibt den statischen singleton UserService des Systems zurück.
		/// </summary>
		public static UserService UserService
		{
			get
			{
				if (myUserSvc == null)
				{
					myUserSvc = new UserService();
				}
				return myUserSvc;
			}
		}

		#endregion

	}
}
