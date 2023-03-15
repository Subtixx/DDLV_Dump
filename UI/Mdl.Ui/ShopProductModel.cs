using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Meta.Online.CRM;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006C8")]
	public class ShopProductModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000658")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002641")]
		public ShopMenu.ShopMenuTabs Tab
		{
			[Cpp2IlInjected.Token(Token = "0x6002B9D")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002B9E")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000659")]
		public GameConfig.StoreBundle RawData
		{
			[Cpp2IlInjected.Token(Token = "0x6002B9F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CRawData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA0")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CRawData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700065A")]
		public Price Price
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CPrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CPrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700065B")]
		public Price ReplacedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CReplacedPrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA4")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CReplacedPrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700065C")]
		public List<Item> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CItems_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BA6")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CItems_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ShopProductModel()
		{
		}
	}
}
