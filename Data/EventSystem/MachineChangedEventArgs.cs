using System;

namespace Products.Data.EventSystem
{
	public class MachineChangedEventArgs : EventArgs
	{

		#region public properties

		public string MachineUID { get; private set; }
		public string OldCustomerId { get; private set; }
		public string NewCustomerId { get; private set; }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Klasse der MachineChangedEventArgs Klasse.
		/// </summary>
		/// <param name="machineUID">Der Primärschlüssel (GUID) der geänderten Maschine.</param>
		/// <param name="oldCustomerId">Die Kundennummer des Kunden, dem die Maschine bisher zugeordnet war.</param>
		/// <param name="newCustomerId">Die Kundennummer des Kunden, dem die Maschine jetzt zugeordnet wurde.</param>
		public MachineChangedEventArgs(string machineUID, string oldCustomerId, string newCustomerId)
		{
			this.MachineUID = machineUID;
			this.OldCustomerId = oldCustomerId;
			this.NewCustomerId = newCustomerId;
		}

		#endregion

	}
}
