
using Products.Data.Datasets;
namespace Products.Model.Entities
{
	public class Software
	{

		#region members

		private dsSoftware.SoftwareRow myBase;

		#endregion

		#region public properties

		public string UID
		{
			get
			{
				return myBase.UID;
			}
		}

		public string Softwarename
		{
			get
			{
				return this.myBase.IsSoftwareNameNull() ? null : this.myBase.SoftwareName;
			}
			set
			{
				if (value == null)
				{
					myBase.SetSoftwareNameNull();
				}
				else myBase.SoftwareName = value;
			}
		}

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der Software Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Software(dsSoftware.SoftwareRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

	}
}
