using Cpp2IlInjected;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AB4")]
	public static class Crc32Ext
	{
		[Cpp2IlInjected.Token(Token = "0x6005D00")]
		[Cpp2IlInjected.Address(RVA = "0x18BC9B0", Offset = "0x18BB3B0", VA = "0x1818BC9B0")]
		public static int ComputeCrc32(this byte[] self)
		{
			uint num = Crc32.ComputeChecksum(self);
			/*Error: Unexpected end of block*/;
		}
	}
}
