using System;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Text;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class Compression
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x102B580", Offset = "0x1029F80", VA = "0x18102B580")]
		public static byte[] Deflate(this byte[] data)
		{
			return Compress(data);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x102B590", Offset = "0x1029F90", VA = "0x18102B590")]
		public static byte[] Inflate(this byte[] data)
		{
			return Decompress(data);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x102AD10", Offset = "0x1029710", VA = "0x18102AD10")]
		public static byte[] Compress(byte[] data, CompressionLevel compressionLevel = CompressionLevel.Fastest)
		{
			//Discarded unreachable code: IL_002f, IL_0035, IL_003b
			int num = 0;
			MemoryStream memoryStream = new MemoryStream();
			int length = data.Length;
			int offset = 0;
			DeflateStream deflateStream = default(DeflateStream);
			deflateStream.Write(data, offset, length);
			if (deflateStream != null)
			{
			}
			byte[] result = memoryStream.ToArray();
			if (memoryStream != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x102B350", Offset = "0x1029D50", VA = "0x18102B350")]
		public static byte[] Decompress(byte[] data)
		{
			//Discarded unreachable code: IL_004c, IL_0052
			int num = 0;
			MemoryStream memoryStream = new MemoryStream(data);
			MemoryStream memoryStream2 = new MemoryStream();
			int mode = default(int);
			DeflateStream deflateStream = new DeflateStream(memoryStream, (CompressionMode)mode);
			mode = 0;
			deflateStream.CopyTo(memoryStream2);
			if (deflateStream != null)
			{
			}
			uint num2 = default(uint);
			if (num2 != 0)
			{
			}
			byte[] result = memoryStream2.ToArray();
			num2++;
			if (memoryStream2 != null)
			{
			}
			if (num2 != 0)
			{
			}
			if (memoryStream != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x102A940", Offset = "0x1029340", VA = "0x18102A940")]
		public static string CompressAndEncode(string s, CompressionLevel level = CompressionLevel.Fastest)
		{
			//Discarded unreachable code: IL_0015
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] inArray = default(byte[]);
			return Convert.ToBase64String(inArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x102AEA0", Offset = "0x10298A0", VA = "0x18102AEA0")]
		public static string DecompressAndDecode(byte[] bytes)
		{
			int num = 0;
			byte[] array = Decompress(Convert.FromBase64String(Encoding.ASCII.GetString(bytes)));
			int num2 = 0;
			Encoding uTF = Encoding.UTF8;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x102AF60", Offset = "0x1029960", VA = "0x18102AF60")]
		public static string DecompressAndDecode(string ascii)
		{
			byte[] array = Decompress(Convert.FromBase64String(ascii));
			int num = 0;
			Encoding uTF = Encoding.UTF8;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x102A9E0", Offset = "0x10293E0", VA = "0x18102A9E0")]
		public static byte[] CompressZip(string data, string zipentryname, CompressionLevel compressionLevel = CompressionLevel.Fastest)
		{
			//Discarded unreachable code: IL_0010
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(data);
			byte[] result = default(byte[]);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x102AA50", Offset = "0x1029450", VA = "0x18102AA50")]
		public static byte[] CompressZip(byte[] data, string zipentryname, CompressionLevel compressionLevel = CompressionLevel.Fastest)
		{
			//Discarded unreachable code: IL_0054, IL_005a, IL_0060, IL_0066
			int num = 0;
			MemoryStream memoryStream = new MemoryStream();
			ZipArchive zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, leaveOpen: true);
			ZipArchiveEntry zipArchiveEntry = default(ZipArchiveEntry);
			Stream stream = zipArchiveEntry.Open();
			MemoryStream memoryStream2 = new MemoryStream(data);
			memoryStream2.CopyTo(stream);
			if (memoryStream2 != null)
			{
			}
			uint num2 = default(uint);
			if (num2 != 0)
			{
			}
			if (stream != null)
			{
			}
			if (num2 != 0)
			{
			}
			if (zipArchive != null)
			{
			}
			byte[] result = memoryStream.ToArray();
			if (memoryStream != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x102AFF0", Offset = "0x10299F0", VA = "0x18102AFF0")]
		public static byte[] DecompressZip(byte[] data)
		{
			//Discarded unreachable code: IL_0091, IL_0097, IL_009d, IL_00a3, IL_00a9
			int num = 0;
			MemoryStream memoryStream = new MemoryStream(data);
			ZipArchive zipArchive = new ZipArchive(memoryStream);
			if (((ReadOnlyCollection<T>)(object)zipArchive.get_Entries()).Count == 1)
			{
				ReadOnlyCollection<ZipArchiveEntry> entries = (ReadOnlyCollection<ZipArchiveEntry>)(object)zipArchive.get_Entries();
				int index = 0;
				Stream stream = ((ZipArchiveEntry)((ReadOnlyCollection<T>)(object)entries)[index]).Open();
				MemoryStream memoryStream2 = new MemoryStream();
				stream.CopyTo(memoryStream2);
				byte[] array = memoryStream2.ToArray();
				if (memoryStream2 != null)
				{
				}
				uint num2 = default(uint);
				if (num2 != 0)
				{
				}
				if (stream != null)
				{
				}
				if (num2 == 0)
				{
				}
			}
			num++;
			if (zipArchive != null)
			{
			}
			if (num != 0)
			{
				if (-1L == 113L)
				{
				}
				if (-1L != 111L)
				{
				}
			}
			if (memoryStream != null)
			{
			}
			if (num != 0)
			{
			}
			int num3 = 0;
			throw new NullReferenceException();
		}
	}
}
