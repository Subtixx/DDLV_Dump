using System;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ByteStringConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x38D9DB0", Offset = "0x38D87B0", VA = "0x1838D9DB0")]
		public static ByteString FromStringUtf8(string value)
		{
			return ByteString.CopyFromUtf8(value);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x38D9E10", Offset = "0x38D8810", VA = "0x1838D9E10")]
		public static bool ToBoolean(this ByteString value)
		{
			//Discarded unreachable code: IL_0011
			byte[] value2 = value.ToByteArray();
			int startIndex = 0;
			return BitConverter.ToBoolean(value2, startIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x38D9BD0", Offset = "0x38D85D0", VA = "0x1838D9BD0")]
		public static ByteString FromBoolean(bool value)
		{
			return ByteString.CopyFrom(BitConverter.GetBytes(value));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x38D9F40", Offset = "0x38D8940", VA = "0x1838D9F40")]
		public static int ToInt(this ByteString value)
		{
			//Discarded unreachable code: IL_0011
			byte[] value2 = value.ToByteArray();
			int startIndex = 0;
			return BitConverter.ToInt32(value2, startIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x38D9C90", Offset = "0x38D8690", VA = "0x1838D9C90")]
		public static ByteString FromInt(int value)
		{
			return ByteString.CopyFrom(BitConverter.GetBytes(value));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x38D9FB0", Offset = "0x38D89B0", VA = "0x1838D9FB0")]
		public static long ToLong(this ByteString value)
		{
			//Discarded unreachable code: IL_0011
			byte[] value2 = value.ToByteArray();
			int startIndex = 0;
			return BitConverter.ToInt64(value2, startIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x38D9D20", Offset = "0x38D8720", VA = "0x1838D9D20")]
		public static ByteString FromLong(long value)
		{
			return ByteString.CopyFrom(BitConverter.GetBytes(value));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x38D9E80", Offset = "0x38D8880", VA = "0x1838D9E80")]
		public static DateTime ToDateTime(this ByteString value)
		{
			//Discarded unreachable code: IL_0016
			byte[] value2 = value.ToByteArray();
			int startIndex = 0;
			return DateTime.FromBinary(BitConverter.ToInt64(value2, startIndex));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x38D9C60", Offset = "0x38D8660", VA = "0x1838D9C60")]
		public static ByteString FromDateTime(DateTime value)
		{
			long value2 = default(long);
			return FromLong(value2);
		}
	}
}
