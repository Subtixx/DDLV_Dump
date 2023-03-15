using Cpp2IlInjected;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x2000322")]
	public abstract class NativeShopItemBase
	{
		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public abstract bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000D92")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public abstract string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000D93")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public abstract string FormattedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000D94")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public abstract string NativeItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6000D95")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public abstract string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000D96")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D97")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected NativeShopItemBase()
		{
		}
	}
}
