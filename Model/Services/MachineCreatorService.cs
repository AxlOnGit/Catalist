using System;
using Products.Data;
using Products.Model.Entities;

namespace Products.Model.Services
{
	/// <summary>
	/// Klasse zum Erstellen neuer Kundenmaschinen.
	/// </summary>
	public class MachineCreatorService
	{
		#region EVENTS

		public event EventHandler<KundenmaschineCreatedEventArgs> KundenmaschineCreatedEvent;

		#endregion EVENTS

		#region PUBLIC PROCEDURES

		public Kundenmaschine CreateKundenmaschine(Kunde kunde, Maschinenmodell maschinenmodell, User creatingUser, string seriennummer)
		{
			// DataRows für die Maschine und KundeMaschineXref erstellen
			var machineCreationParams = DataManager.MachineDataService.NewKundenmaschineRows(kunde.CustomerId, maschinenmodell.UID, creatingUser.UID, seriennummer);
			var neueMaschine = new Kundenmaschine(machineCreationParams.KundenMaschineRow);

			// Ereignis auslösen, dass über die Erstellung der neuen Kundenmaschine informiert.
			KundenmaschineCreatedEvent(this, new KundenmaschineCreatedEventArgs(neueMaschine));
			return neueMaschine;
		}

		#endregion PUBLIC PROCEDURES

		#region SUBCLASSES

		public class KundenmaschineCreatedEventArgs : EventArgs
		{
			#region PUBLIC PROPERTIES

			public Kundenmaschine CreatedMachine { get; private set; }

			#endregion PUBLIC PROPERTIES

			#region ### .ctor ###

			/// <summary>
			/// Erzeugt eine neue Instanz der
			/// <seealso cref="KundenmaschineCreatedEventArgs"/> Klasse.
			/// </summary>
			/// <param name="kundenmaschine"></param>
			public KundenmaschineCreatedEventArgs(Kundenmaschine kundenmaschine)
			{
				this.CreatedMachine = kundenmaschine;
			}

			#endregion ### .ctor ###
		}

		#endregion SUBCLASSES
	}
}