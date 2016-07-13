using Products.Data.Datasets;

namespace Products.Model.Entities
{
	public class Linktyp
	{

		#region members

		dsShared.LinkTypRow myBase;
	
		#endregion

		#region public properties

		/// <summary>
		/// Der Primärschlüssel dieses Verknüpfungstyps.
		/// </summary>
		public string UID
		{
			get { return myBase.UID; }
		}

		/// <summary>
		/// Der Name des Verknüpfungstyps.
		/// </summary>
		public string Bezeichnung
		{
			get { return myBase.LinktypBezeichnung; }
			set { myBase.LinktypBezeichnung = value; }
		}

		/// <summary>
		/// Gibt den Namen der Anwendung zurück, in der dieser
		/// Verknüpfungstyp seinen Ursprung hat.
		/// <remarks>
		/// Das sind derzeit Sage NCL, David und Catalist.
		/// </remarks>
		/// </summary>
		public string Herkunft
		{
			get { return myBase.Herkunft; }
			set { myBase.Herkunft = value; }
		}
	
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der Linktyp Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Linktyp(dsShared.LinkTypRow baseRow)
		{
			myBase = baseRow;
		}
	
		#endregion

	}
}
