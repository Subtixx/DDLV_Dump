using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x2000323")]
	public class InvalidNativeShopItemImpl : NativeShopItemBase
	{
		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000D98")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000D99")]
			[Cpp2IlInjected.Address(RVA = "0x11BB9D0", Offset = "0x11BA3D0", VA = "0x1811BB9D0", Slot = "5")]
			get
			{
				return "InvalidNativeShopItemImpl.Name";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public override string FormattedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9A")]
			[Cpp2IlInjected.Address(RVA = "0x11BB9A0", Offset = "0x11BA3A0", VA = "0x1811BB9A0", Slot = "6")]
			get
			{
				return "InvalidNativeShopItemImpl.Price";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override string NativeItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9B")]
			[Cpp2IlInjected.Address(RVA = "0x11BBA00", Offset = "0x11BA400", VA = "0x1811BBA00", Slot = "7")]
			get
			{
				return "InvalidNativeShopItemImpl.NativeItemID";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9C")]
			[Cpp2IlInjected.Address(RVA = "0x11BB970", Offset = "0x11BA370", VA = "0x1811BB970", Slot = "8")]
			get
			{
				return "InvalidNativeShopItemImpl.Description";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9D")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public InvalidNativeShopItemImpl()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
