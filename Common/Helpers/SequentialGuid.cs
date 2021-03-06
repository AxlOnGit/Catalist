﻿using System;
using static Products.Common.NativeMethods;

namespace Products.Common
{
	public static class SequentialGuid
	{

		//---------------------------------------------------------------------
		/// <summary>
		/// Erstellt eine GUID
		/// </summary>
		/// <returns>GUID</returns>
		public static Guid NewID() => Guid.NewGuid();

		//---------------------------------------------------------------------
		/// <summary>
		/// Erstellt eine GUID die größer ist als alle bisher auf dieser Maschine erstellten GUIDs
		/// </summary>
		/// <returns>GUID</returns>
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

	internal static class NativeMethods
	{
		#region API

		[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
		internal struct GUIDDATA
		{
			internal int Data1;
			internal short Data2;
			internal short Data3;

			[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] Data4;
		}

		[System.Runtime.InteropServices.DllImport("rpcrt4.dll")]
		internal static extern int UuidCreateSequential(out GUIDDATA Uuid);

		#endregion API

	}

}