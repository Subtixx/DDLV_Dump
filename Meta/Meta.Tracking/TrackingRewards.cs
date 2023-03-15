using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A95")]
	public class TrackingRewards
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002962")]
		public string rewardName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002963")]
		public TrackingItem[] items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002964")]
		public TrackingRealCurrency realCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002965")]
		public TrackingVirtualCurrency[] virtualCurrencies;

		[Cpp2IlInjected.Token(Token = "0x6005B8A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TrackingRewards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B8B")]
		[Cpp2IlInjected.Address(RVA = "0x79F820", Offset = "0x79E220", VA = "0x18079F820")]
		public TrackingRewards(string rewardName, [Optional] TrackingItem[] items, [Optional] TrackingRealCurrency realCurrency, [Optional] TrackingVirtualCurrency[] virtualCurrencies)
		{
			//IL_0022: Expected O, but got I4
			this.rewardName = rewardName;
			this.items = items;
			this.realCurrency = realCurrency;
			this.virtualCurrencies = (TrackingVirtualCurrency[])0;
			/*Error: Unexpected end of block*/;
		}
	}
}
