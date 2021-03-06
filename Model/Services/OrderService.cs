﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Common;
using Products.Common.Collections;
using Products.Data;
using Products.Model.Entities;

namespace Products.Model.Services
{
	public class OrderService
	{
		#region members

		readonly Dictionary<string, SortableBindingList<Order>> myOrderDictionary = new Dictionary<string, SortableBindingList<Order>>();
		readonly Dictionary<string, SBList<OrderDetail>> myOrderDetailDictionary = new Dictionary<string, SBList<OrderDetail>>();
		readonly Dictionary<string, SortableBindingList<Order>> myInvoiceDictionary = new Dictionary<string, SortableBindingList<Order>>();
		readonly Dictionary<string, SortableBindingList<OrderDetail>> myInvoiceDetailDictionary = new Dictionary<string, SortableBindingList<OrderDetail>>();

		#endregion members

		#region public procedures

		/// <summary>
		/// Gibt eine sortierbare Liste aller Aufträge des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde">Kundennummer.</param>
		/// <returns></returns>
		public SortableBindingList<Order> GetOrderList(Kunde kunde)
		{
			if (!this.myOrderDictionary.ContainsKey(kunde.CustomerId))
			{
				var list = new SortableBindingList<Order>();
				foreach (var oRow in DataManager.OrderDataService.GetOrderRows(kunde.CustomerId))
				{
					list.Add(new Order(oRow));
				}
				this.myOrderDictionary.Add(kunde.CustomerId, list);
			}
			return this.myOrderDictionary[kunde.CustomerId].Sort("Datum", System.ComponentModel.ListSortDirection.Descending);
		}

		public SortableBindingList<Order> GetFilteredOrderList(Kunde kunde, string filter)
		{
			var searchStrings = filter.Split();
			var query = from orders in this.GetOrderList(kunde)
									join details in this.GetOrderDetailList(kunde.CustomerId)
									on orders.Nummer equals details.Nummer
									where details.Vorgang == "A" && (details.Artikelnummer.ToLower().Contains(filter.ToLower())
									| details.Bezeichnung1.ToLower().Contains(filter.ToLower()))
									select orders;
			return new SortableBindingList<Order>(query.Distinct()).Sort("Datum", System.ComponentModel.ListSortDirection.Descending);
		}

		public SBList<OrderDetail> GetOrderDetailList(string customerPK)
		{
			if (!this.myOrderDetailDictionary.ContainsKey(customerPK))
			{
				var list = new SBList<OrderDetail>();
				foreach (var dRow in DataManager.OrderDataService.GetOrderDetailRows(customerPK))
				{
					list.Add(new OrderDetail(dRow));
				}
				this.myOrderDetailDictionary.Add(customerPK, list);
			}
			return this.myOrderDetailDictionary[customerPK];
		}

		public SBList<OrderDetail> GetOrderDetailList(Order order)
			=> new SBList<OrderDetail>(this.GetOrderDetailList(order.Kundennummer).Where(d => d.Nummer == order.Nummer));

		/// <summary>
		/// Gibt eine sortierbare Liste aller Rechnungen und Direktrechnungen des angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde">Kunde</param>
		/// <returns></returns>
		public SortableBindingList<Order> GetInvoiceList(Kunde kunde)
		{
			if (!this.myInvoiceDictionary.ContainsKey(kunde.CustomerId))
			{
				var list = new SortableBindingList<Order>();
				foreach (var iRow in DataManager.OrderDataService.GetInvoiceRows(kunde.CustomerId))
				{
					list.Add(new Order(iRow));
				}
				this.myInvoiceDictionary.Add(kunde.CustomerId, list);
			}
			return this.myInvoiceDictionary[kunde.CustomerId].Sort("Datum", System.ComponentModel.ListSortDirection.Descending);
		}

		public SortableBindingList<Order> GetInvoiceList(Order order)
			=> new SortableBindingList<Order>(this.GetInvoiceList(order.Kunde).Where(i => i.ParentOrder == order.Nummer));

		/// <summary>
		/// Gibt eine sortierbare Liste aller Rechnungs- und Direktrechnungspositionen des
		/// angegebenen Kunden zurück.
		/// </summary>
		/// <param name="kunde">Kunde</param>
		/// <returns></returns>
		public SortableBindingList<OrderDetail> GetInvoiceDetailList(Kunde kunde)
		{
			if (!this.myInvoiceDetailDictionary.ContainsKey(kunde.CustomerId))
			{
				var list = new SortableBindingList<OrderDetail>();
				foreach (var dRow in DataManager.OrderDataService.GetInvoiceDetailRows(kunde.CustomerId))
				{
					list.Add(new OrderDetail(dRow));
				}
				this.myInvoiceDetailDictionary.Add(kunde.CustomerId, list);
			}
			return this.myInvoiceDetailDictionary[kunde.CustomerId];
		}

		/// <summary>
		/// Gibt die Rechnungspositionen der angegebenen Rechnung oder Direktrechnung zurück.
		/// </summary>
		/// <param name="invoice">Rechnung.</param>
		/// <returns></returns>
		public SortableBindingList<OrderDetail> GetInvoiceDetailList(Order invoice)
			=> new SortableBindingList<OrderDetail>(this.GetInvoiceDetailList(invoice.Kunde).Where(d => d.Nummer == invoice.Nummer));

		public string GetOrderInfoBySerialNumber(string seriennummer, string kundePK)
		{
			var sb = new StringBuilder();
			var vorgangsListe = DataManager.OrderDataService.GetOrderDataBySN(seriennummer, kundePK);
			if (vorgangsListe == null && vorgangsListe.Count() == 0) return $"Für die Seriennummer '{seriennummer}' gibt es keinen Auftrag.";

			foreach (var row in vorgangsListe.OrderBy(o => o.Vorgang))
			{
				switch (row.Vorgang)
				{
					case "A":
					sb.AppendLine($@"Auftrag: {row.Nummer} vom {row.Datum:d}");
					break;

					case "D":
					sb.AppendLine($@"Direktrechnung: {row.Nummer} vom {row.Datum:d} (Auftrag: {row.Auftrag})");
					break;

					case "R":
					sb.AppendLine($@"Rechnung: {row.Nummer} vom {row.Datum:d} (Auftrag: { row.Auftrag})");
					break;

					case "L":
					sb.AppendLine($@"Lieferung: {row.Nummer} vom {row.Datum:d} (Auftrag: {row.Auftrag})");
					break;

					default:
					sb.AppendLine($@"{row.Vorgang}: {row.Nummer} vom {row.Datum:d} (Auftrag: {row.Auftrag})");
					break;
				}
			}

			return sb.ToString();
		}

		#endregion public procedures
	}
}