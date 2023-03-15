using Cpp2IlInjected;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FCE")]
	public class RedeemData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400410B")]
		public string MarketName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400410C")]
		public object MarketData;

		[Cpp2IlInjected.Token(Token = "0x6007F95")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RedeemData()
		{
		}
	}
}
