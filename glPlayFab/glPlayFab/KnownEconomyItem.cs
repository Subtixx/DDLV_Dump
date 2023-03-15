using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public class KnownEconomyItem
	{
		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400053B")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public KnownEconomyItem()
		{
		}
	}
}
