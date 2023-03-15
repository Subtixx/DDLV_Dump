using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public class ConsumeScheduledItems
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public List<string> ItemIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CItemIds_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CItemIds_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			ConsumeFailed
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000082")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40004F7")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ConsumeScheduledItems()
		{
		}
	}
}
