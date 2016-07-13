using System;

namespace Products.Common
{
	public static class SequentialGuid
	{

		#region API

		[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
		private struct GUIDDATA
		{
			public int Data1;
			public short Data2;
			public short Data3;

			[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] Data4;
		}

		[System.Runtime.InteropServices.DllImport("rpcrt4.dll")]
		static extern int UuidCreateSequential(out GUIDDATA Uuid);

		#endregion

		//---------------------------------------------------------------------
		/// <summary>
		/// Erstellt eine GUID
		/// </summary>
		/// <returns>
		/// GUID
		/// </returns>
		public static Guid NewID()
		{
			return Guid.NewGuid();
		}
		//---------------------------------------------------------------------
		/// <summary>
		/// Erstellt eine GUID die größer ist als alle bisher auf dieser 
		/// Maschine erstellten GUIDs
		/// </summary>
		/// <returns>
		/// GUID
		/// </returns>
		public static Guid NewSequentialGuid()
		{
			GUIDDATA guiddata;

			if ((UuidCreateSequential(out guiddata) & 0x80000000) != 0) // FAILED(hr)  
				throw new InvalidOperationException();

			return new System.Guid(
				guiddata.Data1,
				guiddata.Data2,
				guiddata.Data3,
				guiddata.Data4);
		}

	}

}
