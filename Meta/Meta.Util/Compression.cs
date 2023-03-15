using System;
using Cpp2IlInjected;
using glPlayFab;
using Google.Protobuf;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AB2")]
	public static class Compression
	{
		[Cpp2IlInjected.Token(Token = "0x6005CF9")]
		[Cpp2IlInjected.Address(RVA = "0x167FFD0", Offset = "0x167E9D0", VA = "0x18167FFD0")]
		public static string ToCompressedBase64(this ByteString self)
		{
			//Discarded unreachable code: IL_0012
			return Convert.ToBase64String(glPlayFab.Compression.Compress(self.ToByteArray()));
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFA")]
		[Cpp2IlInjected.Address(RVA = "0x167FF30", Offset = "0x167E930", VA = "0x18167FF30")]
		public static ByteString FromCompressedBase64(this string s)
		{
			return ByteString.CopyFrom(glPlayFab.Compression.Decompress(Convert.FromBase64String(s)));
		}
	}
}
