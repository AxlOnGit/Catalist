using Products.Data.dsSageTableAdapters;
using Products.Data.Datasets;

namespace Products.Data
{
	public class CustomerData
	{

		#region members

		readonly string myCustomerId;
		dsCustomer.CustomerRow myCustomerRow;
		dsSage myDS;
		taCustomer taCustomer = new taCustomer();
		taCustomizedPrice taCustomizedPrice = new taCustomizedPrice();
	
		#endregion

		#region public properties

		internal string CustomerId { get { return myCustomerId; } }
			
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the CustomerData class.
		/// </summary>
		/// <param name="customerId"></param>
		public CustomerData(string customerId)
		{
			this.myCustomerId = customerId;
			Initialize();
		}

		#endregion

		#region public procedures

		public void Reset()
		{

		}
	
		#endregion

		#region private procedures

		private void Initialize()
		{
			myDS = new dsSage();
			taCustomer.FillByNumber(myDS.Customer, myCustomerId);
			if (myDS.Customer.Count == 1)
			{
				myCustomerRow = myDS.Customer[0];
			}
			taCustomizedPrice.Fill(myDS.CustomizedPrice, myCustomerId);
		}
	
		#endregion

	}
}
