using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	public class StoreInAppPurchase : StoreDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public override StoreType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "4")]
			get
			{
				return StoreType.InAppPurchase;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public StoreInAppPurchase()
		{
		}
	}
}
