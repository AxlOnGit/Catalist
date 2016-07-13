using System;

namespace Products.Model.EventSystem
{
	public class MachineDeletedEventArgs : EventArgs
	{

		#region public properties

		/// <summary>
		/// Die Instanz der gelöschten Maschine.
		/// </summary>
		public Model.Entities.Kundenmaschine Maschine { get; private set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der MachineDeletedEventArgs Klasse.
		/// </summary>
		/// <param name="maschine"></param>
		public MachineDeletedEventArgs(Model.Entities.Kundenmaschine maschine)
		{
			Maschine = maschine;
		}

		#endregion

	}
}
