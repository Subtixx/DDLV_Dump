using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	public abstract class StoreDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		public enum StoreType
		{
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			Offer,
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			Rotation,
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			InAppPurchase,
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			GameUpgrade
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public abstract StoreType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected StoreDefinition()
		{
		}
	}
}
