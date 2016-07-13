using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic;

namespace Products.Common
{
	public class SortableBindingList<T> : BindingList<T>
	{

		#region events


		#endregion

		readonly Dictionary<Type, PropertyComparer<T>> comparers;
		//IEnumerable<ListSortDescription> myListSortDescriptors;
		bool myIsSorted;
		ListSortDirection listSortDirection;
		PropertyDescriptor propertyDescriptor;
		//List<T> myOriginalData = null;
		//string myFilter = "";

		[DebuggerStepThrough]
		public SortableBindingList()
			: base(new List<T>())
		{
			this.comparers = new Dictionary<Type, PropertyComparer<T>>();
		}

		[DebuggerStepThrough]
		public SortableBindingList(IEnumerable<T> enumeration)
			: base(new List<T>(enumeration))
		{
			this.comparers = new Dictionary<Type, PropertyComparer<T>>();
		}

		protected override bool SupportsSortingCore
		{
			get { return true; }
		}

		protected override bool IsSortedCore
		{
			get { return this.myIsSorted; }
		}

		protected override PropertyDescriptor SortPropertyCore
		{
			get { return this.propertyDescriptor; }
		}

		protected override ListSortDirection SortDirectionCore
		{
			get { return this.listSortDirection; }
		}

		protected override bool SupportsSearchingCore
		{
			get { return true; }
		}

		protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
		{
			List<T> itemsList = (List<T>)this.Items;

			Type propertyType = property.PropertyType;
			PropertyComparer<T> comparer;
			if (!this.comparers.TryGetValue(propertyType, out comparer))
			{
				comparer = new PropertyComparer<T>(property, direction);
				this.comparers.Add(propertyType, comparer);
			}
			comparer.SetPropertyAndDirection(property, direction);
			itemsList.Sort(comparer);

			this.propertyDescriptor = property;
			this.listSortDirection = direction;
			this.myIsSorted = true;

			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		protected override void RemoveSortCore()
		{
			this.myIsSorted = false;
			this.propertyDescriptor = base.SortPropertyCore;
			this.listSortDirection = base.SortDirectionCore;

			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		protected override int FindCore(PropertyDescriptor property, object key)
		{
			int count = this.Count;
			for (int i = 0; i < count; ++i)
			{
				T element = this[i];
				if (property.GetValue(element).Equals(key))
				{
					return i;
				}
			}

			return -1;
		}

		/// <summary>
		/// Sortiert nach der angegebenen Eigenschaft in der angegebenen Sortierreihenfolge.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="direction"></param>
		public SortableBindingList<T> Sort(string propertyName, ListSortDirection direction = ListSortDirection.Ascending)
		{
			if (this.Count > 0)
			{
				System.ComponentModel.PropertyDescriptorCollection props = System.ComponentModel.TypeDescriptor.GetProperties(Items[0]);
				PropertyDescriptor prop = props[propertyName];
				if (prop == null)
				{
					string msg = string.Format("Fehler bei der Sortierung. {0}\nDie Liste enthält keine '{1}' Eigenschaft.", this.GetType().Name, propertyName);
					throw new Exception(msg);
				}
				this.ApplySortCore(prop, direction);
			}
			return this;
		}

	}
}