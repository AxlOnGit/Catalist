using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common.Collections;
using Products.Data.Datasets;
using Products.Data.Datasets.dsOrdersTableAdapters;

namespace Products.Data.Services
{
	public class OrderDataService
	{

		#region members

		readonly string myCurrentUserPK;

		readonly taOrder myOrderAdapter = new taOrder();
		readonly taOrderDetail myOrderDetailAdapter = new taOrderDetail();

		readonly Dictionary<string, dsOrders.OrderDataTable> myOrderDictionary = new Dictionary<string, dsOrders.OrderDataTable>();
		readonly Dictionary<string, dsOrders.OrderDetailDataTable> myOrderDetailDictionary = new Dictionary<string, dsOrders.OrderDetailDataTable>();

		#endregion

		#region public properties
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der OrderDataService Klasse.
		/// </summary>
		/// <param name="currentUserPK">Primärschlüssel des derzeit am System angemeldeten Benutzers.</param>
		public OrderDataService(string currentUserPK)
		{
			this.myCurrentUserPK = currentUserPK;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Gibt die OrderDataTable mit den Aufträgen des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer.</param>
		/// <returns></returns>
		public IEnumerable<dsOrders.OrderRow> GetOrderRows(string customerPK)
		{
			if (!this.myOrderDictionary.ContainsKey(customerPK))
			{
				var oTable = this.myOrderAdapter.GetData(customerPK);
				this.myOrderDictionary.Add(customerPK, oTable);
			}
			return this.myOrderDictionary[customerPK].Where(o => o.Vorgang.ToLower() == "a");
		}

		/// <summary>
		/// Gibt alle OrderDetailRows für den angegebenen Kunden zurück.
		/// </summary>
		/// <param name="customerPK">Kundennummer.</param>
		/// <returns></returns>
		public IEnumerable<dsOrders.OrderDetailRow> GetOrderDetailRows(string customerPK)
		{
			if (!this.myOrderDetailDictionary.ContainsKey(customerPK))
			{
				var dTable = this.myOrderDetailAdapter.GetData(customerPK);
				this.myOrderDetailDictionary.Add(customerPK, dTable);
			}
			return this.myOrderDetailDictionary[customerPK].Where(d => d.Vorgang.ToLower() == "a");
		}

		public IEnumerable<dsOrders.OrderRow> GetInvoiceRows(string customerPK)
		{
			if (!this.myOrderDictionary.ContainsKey(customerPK))
			{
				var oTable = this.myOrderAdapter.GetData(customerPK);
				this.myOrderDictionary.Add(customerPK, oTable);
			}
			return this.myOrderDictionary[customerPK].Where(o => o.Vorgang.ToLower() == "d" | o.Vorgang.ToLower() == "r");
		}

		public IEnumerable<dsOrders.OrderDetailRow> GetInvoiceDetailRows(string customerPK)
		{
			if (!this.myOrderDetailDictionary.ContainsKey(customerPK))
			{
				var dTable = this.myOrderDetailAdapter.GetData(customerPK);
				this.myOrderDetailDictionary.Add(customerPK, dTable);
			}
			return this.myOrderDetailDictionary[customerPK].Where(d => d.Vorgang.ToLower() == "d" | d.Vorgang.ToLower() == "r");
		}

		#endregion

		#region private procedures
		#endregion

	}
}
