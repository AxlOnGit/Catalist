using Products.Model.Repos;

namespace Products.Model
{
	public static class RepoManager
	{
		#region MEMBERS

		static KundenmaschinenRepo myKundenmaschinenRepo;
		static MaschinenauftragRepo myMaschinenauftragRepo;

		#endregion MEMBERS

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Gibt das statische singleton <seealso cref="KundenmaschinenRepo"/> des Systems zurück.
		/// </summary>
		public static KundenmaschinenRepo KundenmaschinenRepository
		{
			get
			{
				if (myKundenmaschinenRepo == null) myKundenmaschinenRepo = new KundenmaschinenRepo();
				return myKundenmaschinenRepo;
			}
		}

		/// <summary>
		/// Gibt das statische singleton <seealso cref="MaschinenauftragRepo"/> des Systems zurück.
		/// </summary>
		public static MaschinenauftragRepo MaschinenauftragRepository
		{
			get
			{
				if (myMaschinenauftragRepo == null) myMaschinenauftragRepo = new MaschinenauftragRepo();
				return myMaschinenauftragRepo;
			}
		}

		#endregion PUBLIC PROPERTIES
	}
}