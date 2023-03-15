using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A94")]
	public class TrackingProducts
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400295F")]
		public TrackingItem[] items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002960")]
		public TrackingRealCurrency realCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002961")]
		public TrackingVirtualCurrency[] virtualCurrencies;

		[Cpp2IlInjected.Token(Token = "0x6005B88")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TrackingProducts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B89")]
		[Cpp2IlInjected.Address(RVA = "0x79F770", Offset = "0x79E170", VA = "0x18079F770")]
		public TrackingProducts([Optional] TrackingItem[] items, [Optional] TrackingRealCurrency realCurrency, [Optional] TrackingVirtualCurrency[] virtualCurrencies)
		{
			this.items = items;
			this.realCurrency = realCurrency;
			this.virtualCurrencies = virtualCurrencies;
			/*Error: Unexpected end of block*/;
		}
	}
}
