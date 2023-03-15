using System;
using System.IO;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Serialization.Binary
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class NetworkByteOrderBinaryReader : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Stream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x28C2F50", Offset = "0x28C1950", VA = "0x1828C2F50")]
		public NetworkByteOrderBinaryReader(Stream stream)
		{
			Dispose();
			if (stream != null)
			{
				this.stream = stream;
				byte[] array = (buffer = new byte[16]);
			}
			ArgumentNullException ex = new ArgumentNullException("stream");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28C2CD0", Offset = "0x28C16D0", VA = "0x1828C2CD0")]
		private void ReadToCacheBuffer(int numBytes)
		{
			//Discarded unreachable code: IL_002c
			int num2;
			int num;
			do
			{
				if (buffer != null)
				{
				}
				num = 0;
				Stream stream = this.stream;
				byte[] array = buffer;
				num2 = stream.Read(array, num, numBytes);
			}
			while (num2 == 0);
			num += num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28C27C0", Offset = "0x28C11C0", VA = "0x1828C27C0")]
		public byte ReadByte()
		{
			//Discarded unreachable code: IL_0014
			ReadToCacheBuffer(1);
			return buffer[0];
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28C2AD0", Offset = "0x28C14D0", VA = "0x1828C2AD0")]
		public short ReadShort()
		{
			ReadToCacheBuffer(2);
			byte[] array = buffer;
			int length = array.Length;
			byte b = array[0];
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28C2AD0", Offset = "0x28C14D0", VA = "0x1828C2AD0")]
		public ushort ReadUShort()
		{
			ReadToCacheBuffer(2);
			byte[] array = buffer;
			int length = array.Length;
			byte b = array[0];
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28C2890", Offset = "0x28C1290", VA = "0x1828C2890")]
		public float ReadFloat()
		{
			ReadToCacheBuffer(4);
			byte[] array = buffer;
			int index = 0;
			Array.Reverse((Array)array, index, 4);
			byte[] value = buffer;
			int startIndex = 0;
			return BitConverter.ToSingle(value, startIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28C2810", Offset = "0x28C1210", VA = "0x1828C2810")]
		public double ReadDouble()
		{
			ReadToCacheBuffer(8);
			byte[] array = buffer;
			int index = 0;
			Array.Reverse((Array)array, index, 8);
			byte[] value = buffer;
			int startIndex = 0;
			return BitConverter.ToDouble(value, startIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28C2910", Offset = "0x28C1310", VA = "0x1828C2910")]
		public int ReadInt32()
		{
			int num = 0;
			int num2 = 0;
			ReadToCacheBuffer(1);
			byte b = buffer[0];
			ulong num3 = default(ulong);
			if (num3 == 0)
			{
				num += 7;
			}
			num += 6;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28C2E30", Offset = "0x28C1830", VA = "0x1828C2E30")]
		public uint ReadUInt32()
		{
			int num = 0;
			ReadToCacheBuffer(1);
			byte b = buffer[0];
			num += 7;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28C29F0", Offset = "0x28C13F0", VA = "0x1828C29F0")]
		public long ReadInt64()
		{
			int num = 0;
			int num2 = 0;
			ReadToCacheBuffer(1);
			byte b = buffer[0];
			ulong num3 = default(ulong);
			if (num3 == 0)
			{
				num += 7;
			}
			num += 6;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28C2EC0", Offset = "0x28C18C0", VA = "0x1828C2EC0")]
		public ulong ReadUInt64()
		{
			int num = 0;
			ReadToCacheBuffer(1);
			byte b = buffer[0];
			num += 7;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28C2B40", Offset = "0x28C1540", VA = "0x1828C2B40")]
		public string ReadString()
		{
			uint num = ReadUInt32();
			int num2 = 0;
			byte[] array = new byte[num];
			Stream stream = this.stream;
			num -= (uint)num2;
			int num3 = stream.Read(array, num2, (int)num);
			if (num3 != 0)
			{
				num2 += num3;
				throw new NullReferenceException();
			}
			EndOfStreamException ex = new EndOfStreamException("Attempted to read past the end of the stream");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public void Dispose()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
