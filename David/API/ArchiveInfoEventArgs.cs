using System;
using DvApi32;

namespace David.API
{
	public class ArchiveInfoEventArgs : EventArgs
	{
		#region PUBLIC PROPERTIES

		public Archive Archive { get; }

		#endregion PUBLIC PROPERTIES

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="ArchiveInfoEventArgs"/> EventArgs-Klasse.
		/// </summary>
		/// <param name="archive">Ein <seealso cref="Archive"/></param>.
		public ArchiveInfoEventArgs(Archive archive)
		{
			this.Archive = archive;
		}

		#endregion ### .ctor ###
	}
}