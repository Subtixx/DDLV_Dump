using System;
using System.IO;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Serialization.Binary
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class NetworkByteOrderBinaryWriter : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Stream stream;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28C3790", Offset = "0x28C2190", VA = "0x1828C3790")]
		public NetworkByteOrderBinaryWriter(Stream stream)
		{
			Dispose();
			if (stream != null)
			{
				this.stream = stream;
			}
			ArgumentNullException ex = new ArgumentNullException("stream");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28C3010", Offset = "0x28C1A10", VA = "0x1828C3010")]
		public void WriteBytes(byte[] value)
		{
			//Discarded unreachable code: IL_001a
			Stream stream = this.stream;
			int offset = 0;
			int length = value.Length;
			stream.Write(value, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28688A0", Offset = "0x28672A0", VA = "0x1828688A0")]
		public void WriteByte(byte value)
		{
			//Discarded unreachable code: IL_000d
			bool canRead = stream.CanRead;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28C3400", Offset = "0x28C1E00", VA = "0x1828C3400")]
		public void WriteShort(short value)
		{
			//Discarded unreachable code: IL_0027
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse((Array)bytes);
			Stream stream = this.stream;
			int offset = 0;
			int length = bytes.Length;
			stream.Write(bytes, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28C36F0", Offset = "0x28C20F0", VA = "0x1828C36F0")]
		public void WriteUShort(ushort value)
		{
			//Discarded unreachable code: IL_0027
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse((Array)bytes);
			Stream stream = this.stream;
			int offset = 0;
			int length = bytes.Length;
			stream.Write(bytes, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28C3100", Offset = "0x28C1B00", VA = "0x1828C3100")]
		public void WriteFloat(float value)
		{
			//Discarded unreachable code: IL_0027
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse((Array)bytes);
			Stream stream = this.stream;
			int offset = 0;
			int length = bytes.Length;
			stream.Write(bytes, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28C3050", Offset = "0x28C1A50", VA = "0x1828C3050")]
		public void WriteDouble(double value)
		{
			//Discarded unreachable code: IL_0027
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse((Array)bytes);
			Stream stream = this.stream;
			int offset = 0;
			int length = bytes.Length;
			stream.Write(bytes, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x28C31B0", Offset = "0x28C1BB0", VA = "0x1828C31B0")]
		public void WriteInt32(int value)
		{
			if (value != 0)
			{
				if (value != int.MinValue)
				{
					if (value > 0)
					{
						Stream stream = this.stream;
						if (1L == 0L)
						{
						}
						stream.WriteByte((byte)value);
						int num = 0;
						while (value != 0)
						{
						}
					}
				}
				else
				{
					Stream stream2 = this.stream;
				}
				return;
			}
			Stream stream3 = this.stream;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x28C35B0", Offset = "0x28C1FB0", VA = "0x1828C35B0")]
		public void WriteUInt32(uint value)
		{
			//Discarded unreachable code: IL_0024
			if (value != 0)
			{
				stream.WriteByte((byte)value);
				while (value != 0)
				{
				}
			}
			else
			{
				bool canRead = stream.CanRead;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28C32D0", Offset = "0x28C1CD0", VA = "0x1828C32D0")]
		public void WriteInt64(long value)
		{
			//Discarded unreachable code: IL_0017, IL_001f
			//IL_0014: Expected I4, but got I8
			Stream stream = this.stream;
			if (1L == 0L)
			{
			}
			stream.WriteByte((byte)value);
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x28C3650", Offset = "0x28C2050", VA = "0x1828C3650")]
		public void WriteUInt64(ulong value)
		{
			//Discarded unreachable code: IL_0026
			//IL_0012: Expected I4, but got I8
			if (value != 0)
			{
				stream.WriteByte((byte)value);
				while (value != 0)
				{
				}
			}
			else
			{
				bool canRead = stream.CanRead;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28C34A0", Offset = "0x28C1EA0", VA = "0x1828C34A0")]
		public void WriteString(string value)
		{
			//Discarded unreachable code: IL_0008
			Stream stream = this.stream;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public void Dispose()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
