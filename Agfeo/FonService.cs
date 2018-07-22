using System;
using System.Linq;
using System.Net.NetworkInformation;
using JulMar.Atapi;

namespace Agfeo
{
	public class FonService : IDisposable
	{
		#region public events

		public event EventHandler<IncomingCallEventArgs> SomeoneIsCalling;

		public event EventHandler OnLineOpened;

		#endregion public events

		#region members

		TapiManager myTapiManager;
		TapiLine myLine;
		TapiAddress myAddress;

		#endregion members

		#region public properties

		/// <summary>
		/// Returns true if we have registered event handlers for
		/// our SomeoneIsCalling event.
		/// </summary>
		public bool IsListening => (SomeoneIsCalling != null);

		/// <summary>
		///
		/// </summary>
		public TapiManager TapiManager => this.myTapiManager;

		public bool Initialized { get; private set; }

		/// <summary>
		/// Gibt FALSE zurück, wenn die Telefonanlage nicht erreichbar ist.
		/// </summary>
		public bool Connected { get; set; }

		#endregion public properties

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the FonService class.
		/// </summary>
		public FonService()
		{
			this.myTapiManager = new TapiManager("Catalist");
		}

		#endregion ### .ctor ###

		#region public procedures

		/// <summary>
		/// Returns TRUE, if the phone server is reachable.
		/// </summary>
		/// <returns></returns>
		public bool ServerReachable()
		{
			try
			{
				var reply = new Ping().Send("192.168.0.101", 2000);
				if (reply.Status == IPStatus.Success)
				{
					return true;
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public void MakeCall(string number)
		{
			if (this.myLine.IsOpen && this.myAddress.Status.CanMakeCall)
			{
				this.myAddress.MakeCall(NormalizedFonNumber(number));
			}
		}

		/// <summary>
		/// Shutdown of the TapiManager Instance.
		/// </summary>
		public void Shutdown()
		{
			if (this.Initialized)
			{
				this.myTapiManager.Shutdown();
			}
		}

		#endregion public procedures

		#region private procedures

		public void InitTapi(bool justMe, string myLine)
		{
			try
			{
				this.Initialized = this.myTapiManager.Initialize();
				if (this.Initialized)
				{
					this.Connected = true;
					if (justMe)
					{
						this.myLine = this.myTapiManager.GetLineByName(myLine, true);
						if (this.myLine != null && this.myLine.Addresses.Count() > 0)
						{
							this.myAddress = this.myLine.Addresses[0];
						}
						this.myLine.Open(MediaModes.All);
						this.myLine.NewCall += line_NewCall;
						if (this.myLine.IsOpen)
						{
							OnLineOpened?.Invoke(this, new EventArgs());
							Connected = true;
						}
					}
				}
				else Connected = false;
			}
			catch
			{
			}
		}

		void line_NewCall(object sender, NewCallEventArgs e)
		{
			if (SomeoneIsCalling != null && e.Call.CallOrigin == CallOrigins.External && e.Call.BearerMode == BearerModes.Voice)
			{
				SomeoneIsCalling(sender, new IncomingCallEventArgs(e.Call.CallerId));
			}
		}

		private string NormalizedFonNumber(string input) => input.Replace("+", "00").Replace("/", "");

		#endregion private procedures

		#region event handler

		void line_CallInfoChanged(object sender, CallInfoChangeEventArgs e)
		{
			SomeoneIsCalling?.Invoke(sender, new IncomingCallEventArgs(e.Call.Address.Address));
		}

		#endregion event handler

		#region IDisposable Support

		private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					this.myTapiManager.Shutdown();
				}
				disposedValue = true;
			}
		}

		// Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
		public void Dispose()
		{
			Dispose(true);
		}

		#endregion IDisposable Support
	}

	#region classes

	public class IncomingCallEventArgs : EventArgs
	{
		#region members

		readonly string phoneNumber;

		#endregion members

		#region ### .ctor ###

		public IncomingCallEventArgs(string incomingNumber)
		{
			phoneNumber = incomingNumber;
		}

		#endregion ### .ctor ###

		#region public properties

		public string CallerNumber => this.phoneNumber;

		#endregion public properties
	}

	#endregion classes
}