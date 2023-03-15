using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A93")]
	public class TrackingVirtualCurrency
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400295C")]
		public int virtualCurrencyAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400295D")]
		public string virtualCurrencyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400295E")]
		public string virtualCurrencyType;

		[Cpp2IlInjected.Token(Token = "0x6005B86")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TrackingVirtualCurrency()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B87")]
		[Cpp2IlInjected.Address(RVA = "0x79F8A0", Offset = "0x79E2A0", VA = "0x18079F8A0")]
		public unsafe TrackingVirtualCurrency(int virtualCurrencyAmount, string virtualCurrencyName, string virtualCurrencyType)
		{
			//IL_000b: Expected O, but got I4
			int num = 0;
			base.FieldGetter((string)num, virtualCurrencyName, ref *(object*)virtualCurrencyType);
			this.virtualCurrencyName = virtualCurrencyName;
			this.virtualCurrencyAmount = virtualCurrencyAmount;
			this.virtualCurrencyType = virtualCurrencyType;
			/*Error: Unexpected end of block*/;
		}
	}
}
