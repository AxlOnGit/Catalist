﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Products.Common
{
	public class File_CRC32
	{
		long[] pTable = new long[256];

		//Für Standard CRC32:
		//(Wert kann verändert werden)
		long Poly = 0xEDB88320;

		public File_CRC32()
		{
			long CRC;
			int i, j;

			for (i = 0; i < 256; i++)
			{
				CRC = i;

				for (j = 0; j < 8; j++)
				{
					if ((CRC & 0x1) == 1)
					{
						CRC = (CRC >> 1) ^ Poly;
					}
					else
					{
						CRC = (CRC >> 1);
					}
				}
				pTable[i] = CRC;
			}

		}

		public uint GetCRC32(string FileName)
		{
			long StreamLength, CRC;
			int BufferSize;
			byte[] Buffer;

			//4KB Buffer
			BufferSize = 0x1000;

			try
			{
				FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
				StreamLength = fs.Length;

				CRC = 0xFFFFFFFF;
				while (StreamLength > 0)
				{
					if (StreamLength < BufferSize)
					{
						BufferSize = (int)StreamLength;
					}
					Buffer = new byte[BufferSize];

					fs.Read(Buffer, 0, BufferSize);

					for (int i = 0; i < BufferSize; i++)
					{
						CRC = ((CRC & 0xFFFFFF00) / 0x100) & 0xFFFFFF ^ pTable[Buffer[i] ^ CRC & 0xFF];
					}

					StreamLength = StreamLength - BufferSize;

				}

				fs.Close();
				CRC = (-(CRC)) - 1; // !(CRC)

				return (uint)CRC;
			}
			catch (Exception)
			{
				return 0;
			}
		}

	}
}