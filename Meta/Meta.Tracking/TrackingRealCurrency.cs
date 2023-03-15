using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A92")]
	public class TrackingRealCurrency
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400295A")]
		public int realCurrencyAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400295B")]
		public string realCurrencyType;

		[Cpp2IlInjected.Token(Token = "0x6005B84")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TrackingRealCurrency()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B85")]
		[Cpp2IlInjected.Address(RVA = "0x79F7E0", Offset = "0x79E1E0", VA = "0x18079F7E0")]
		public TrackingRealCurrency(int realCurrencyAmount, string realCurrencyType)
		{
			this.realCurrencyType = realCurrencyType;
			this.realCurrencyAmount = realCurrencyAmount;
			/*Error: Unexpected end of block*/;
		}
	}
}
