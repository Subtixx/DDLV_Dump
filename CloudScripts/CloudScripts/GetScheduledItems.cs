using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.EconomyModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public class GetScheduledItems
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public List<string> ItemIds
			{
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CItemIds_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CItemIds_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40004F1")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public List<CatalogItem> CatalogItems
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCatalogItems_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CCatalogItems_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GetScheduledItems()
		{
		}
	}
}
