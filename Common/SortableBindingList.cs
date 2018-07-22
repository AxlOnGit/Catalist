using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Products.Common
{
	public class SortableBindingList<T> : BindingList<T>
	{
		private readonly Dictionary<Type, PropertyComparer<T>> comparers;

		//IEnumerable<ListSortDescription> myListSortDescriptors;
		private bool myIsSorted;

		private ListSortDirection listSortDirection;
		private PropertyDescriptor propertyDescriptor;
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

		protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			this.SortPropertyName = prop.Name;
			this.SortDirection = direction;
			var itemsList = (List<T>)this.Items;

			Type propertyType = prop.PropertyType;
			PropertyComparer<T> comparer;
			if (!this.comparers.TryGetValue(propertyType, out comparer))
			{
				comparer = new PropertyComparer<T>(prop, direction);
				this.comparers.Add(propertyType, comparer);
			}
			comparer.SetPropertyAndDirection(prop, direction);
			itemsList.Sort(comparer);

			this.propertyDescriptor = prop;
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

		protected override int FindCore(PropertyDescriptor prop, object key)
		{
			int count = this.Count;
			for (int i = 0; i < count; ++i)
			{
				T element = this[i];
				if (prop.GetValue(element).Equals(key))
				{
					return i;
				}
			}

			return -1;
		}

		public void AddRange(IEnumerable<T> colRange)
		{
			foreach (var item in colRange)
			{
				Items.Add(item);
			}
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
				var props = TypeDescriptor.GetProperties(Items[0]);
				PropertyDescriptor prop = props[propertyName];
				if (prop == null)
				{
					var msg = string.Format("Fehler bei der Sortierung. {0}\nDie Liste enthält keine '{1}' Eigenschaft.", this.GetType().Name, propertyName);
					throw new Exception(msg);
				}
				this.ApplySortCore(prop, direction);
			}
			return this;
		}

		public string SortPropertyName { get; private set; }

		public ListSortDirection SortDirection { get; private set; }
	}
}