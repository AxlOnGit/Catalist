using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic;

namespace Products.Common.Collections
{
	public class SBList<T> : BindingList<T>, IBindingListView
	{

		#region members

		bool myIsSorted;
		string myFilter = "";
		IEnumerable<ListSortDescription> myListSortDescriptors;
		readonly List<T> myOriginalData;

		#endregion

		#region public properties

		public ListSortDescriptionCollection SortDescriptions => new ListSortDescriptionCollection(this.myListSortDescriptors.ToArray());

		public bool SupportsAdvancedSorting => true;

		public bool SupportsFiltering => true;

		public void ApplySort(ListSortDescriptionCollection sorts)
		{
			ApplySortCore(sorts.Cast<ListSortDescription>());
		}

		public string Filter
		{
			get
			{
				return this.myFilter;
			}
			set
			{
				if (string.Compare(this.myFilter, value, StringComparison.InvariantCultureIgnoreCase) == 0) return;
				this.myFilter = value;
				this.UpdateFilter();
			}
		}

		#endregion

		#region ### .ctor ###

		public SBList() : base(new List<T>())
		{
			this.myOriginalData = new List<T>(); // base.Items.ToList();		//as List<T>

		}

		/// <summary>
		/// Erzeugt eine neue <seealso cref="SBList{T}"/> Instanz und füllt sie mit den 
		/// Elementen der angegebenen Liste.
		/// </summary>
		/// <param name="list"></param>
		public SBList(IEnumerable<T> list) : base(list.ToList())
		{
			this.myOriginalData = new List<T>(list);
		}

		#endregion

		#region override

		protected override bool SupportsSearchingCore => true;

		protected override bool SupportsSortingCore => true;

		protected override bool IsSortedCore => this.myIsSorted;

		protected override PropertyDescriptor SortPropertyCore
		{
			get
			{
				if (this.myListSortDescriptors == null || this.myListSortDescriptors.Count() == 0)
				{
					return (PropertyDescriptor)null;
				}
				return this.myListSortDescriptors.ElementAtOrDefault(0).PropertyDescriptor;
			}
		}

		protected override ListSortDirection SortDirectionCore
		{
			get
			{
				if (this.myListSortDescriptors == null || this.myListSortDescriptors.Count() == 0)
					return ListSortDirection.Ascending;
				return this.myListSortDescriptors.ElementAtOrDefault(0).SortDirection;
			}
		}

		protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			var interfaceType = prop.PropertyType.GetInterface("IComparable");

			if (interfaceType == null)
			{
				if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
				{
					Type tType = prop.PropertyType.GetGenericArguments()[0];
					interfaceType = tType.GetInterface("IComparable");
				}
			}
			if (interfaceType != null)
			{
				this.myListSortDescriptors = new List<ListSortDescription> { new ListSortDescription(prop, direction) };

				// Die Liste per LINQ OrderBy sortieren ...
				var tempList = new List<T>();
				if (direction == ListSortDirection.Ascending)
				{
					tempList = Items.OrderBy(x => prop.GetValue(x)).ToList();
				}
				else
				{
					tempList = Items.OrderByDescending(x => prop.GetValue(x)).ToList();
				}
				// ... und die sortierten Elemente wieder in die Liste kopieren
				Items.Clear();
				foreach (var item in tempList)
				{
					Items.Add(item);
				}
				this.myIsSorted = true;
				OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
			else
			{
				// Fehler auslösen, falls die Eigenschaft nach der sortiert werden soll, die IComparable Schnittstelle nicht unterstützt.
				var errMsg = string.Format("Nach '{0}' kann nicht sortiert werden. {1} unterstützt die IComparable Schnittstelle nicht.", prop.Name, prop.PropertyType);
				throw new NotSupportedException(errMsg);
			}
		}

		protected void ApplySortCore(IEnumerable<ListSortDescription> sorts, bool informListeners = true)
		{
			try
			{
				IOrderedEnumerable<T> orderedList = null;
				bool isFirstOrder = true;
				foreach (var item in sorts)
				{
					PropertyDescriptor prop = item.PropertyDescriptor;
					var interfaceType = prop.PropertyType.GetInterface("IComparable");

					if (interfaceType == null)
					{
						// Testen ob es sich um ein 
						if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable))
						{
							Type tType = prop.PropertyType.GetGenericArguments()[0];
							interfaceType = tType.GetInterface("IComparable");
						}
					}

					if (interfaceType == null)
					{
						var errMsg = string.Format("Nach '{0}' kann nicht sortiert werden. {1} unterstützt die IComparable Schnittstelle nicht.", prop.Name, prop.PropertyType);
						throw new NotSupportedException(errMsg);
					}
					// Die Liste per LINQ OrderBy/ThenBy sortieren. Dabei beachten, ob es die erste Sortierung (OrderBy) oder nicht (ThenBy) handelt.
					if (isFirstOrder)
					{
						isFirstOrder = false;
						if (item.SortDirection == ListSortDirection.Ascending)
						{
							orderedList = Items.OrderBy(x => prop.GetValue(x));
						}
						else
						{
							orderedList = Items.OrderByDescending(x => prop.GetValue(x));
						}
					}
					else
					{
						if (item.SortDirection == ListSortDirection.Ascending)
						{
							orderedList = orderedList.ThenBy(x => prop.GetValue(x));
						}
						else
						{
							orderedList = orderedList.ThenByDescending(x => prop.GetValue(x));
						}
					}
					var result = orderedList.ToList();
					Items.Clear();
					foreach (var tItem in result)
					{
						Items.Add(tItem);
					}
					this.myIsSorted = true;
					this.myListSortDescriptors = sorts;

					if (informListeners)
					{
						OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
					}
				}
			}
			catch (Exception)
			{
				Items.Clear();
				foreach (var oItem in this.myOriginalData)
				{
					Items.Add(oItem);
				}
				throw;
			}
		}

		public override void EndNew(int itemIndex)
		{
			try
			{
				if (this.myIsSorted & itemIndex == Count - 1)
				{
					ApplySortCore(this.myListSortDescriptors, false);
				}

				if (Filter != "")
				{
					UpdateFilter();
				}
			}
			finally
			{
				base.EndNew(itemIndex);
			}
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Fügt ein neues Element am Ende der Auflistung hinzu.
		/// </summary>
		/// <param name="item"></param>
		public new void Add(T item)
		{
			Items.Add(item);
			this.myOriginalData.Add(item);
		}

		public void AddRange(IEnumerable<T> colRange)
		{
			foreach (var item in colRange)
			{
				Items.Add(item);
			}
			this.myOriginalData.AddRange(colRange);
		}

		public void RemoveFilter()
		{
			this.myFilter = "";
			Filter = "";
		}

		public void RemoveSort()
		{
			RemoveSortCore();
		}

		public int Find<TKey>(string property, TKey key)
		{
			var properties = TypeDescriptor.GetProperties(typeof(T));
			var prop = properties.Find(property, true);

			if (prop == null) return -1;
			return FindCore(prop, key);
		}

		protected override int FindCore(PropertyDescriptor prop, object key)
		{
			var propInfo = typeof(T).GetProperty(prop.Name);
			T tItem;

			if (key == null)
			{
				for (int i = 0; i < Count - 1; i++)
				{
					tItem = Items[i];
					if (propInfo.GetValue(tItem, null).Equals(key)) return i;
				}
			}
			return -1;
		}

		/// <summary>
		/// Sortiert nach der angegebenen Eigenschaft in der angegebenen Sortierreihenfolge.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="direction"></param>
		public SBList<T> Sort(string propertyName, ListSortDirection direction = ListSortDirection.Ascending)
		{
			if (Count > 0)
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

		#endregion

		#region protected procedures

		protected void UpdateFilter()
		{
			this.myIsSorted = false;
			try
			{
				var filtered = this.myOriginalData.AsQueryable();
				if (!string.IsNullOrEmpty(this.myFilter))
				{
					filtered = filtered.Where(this.myFilter);
					var filteredResult = filtered.ToList();
					Items.Clear();

					if (filteredResult != null && filteredResult.Count > 0)
					{
						foreach (T item in filteredResult)
						{
							Items.Add(item);
						}
					}
				}
				else
				{
					Items.Clear();
					foreach (var item in this.myOriginalData)
					{
						Items.Add(item);
					}
				}
				if (this.myListSortDescriptors != null && this.myListSortDescriptors.Count() > 0)
				{
					this.ApplySortCore(this.myListSortDescriptors, false);
				}
			}
			catch (Exception)
			{
				Items.Clear();
				foreach (T item in this.myOriginalData)
				{
					Items.Add(item);
				}
				throw;
			}
			finally
			{
				OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
		}

		#endregion

	}
}
