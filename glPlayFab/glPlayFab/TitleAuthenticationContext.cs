using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class TitleAuthenticationContext
	{
		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public string EntityToken
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CEntityToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CEntityToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TitleAuthenticationContext()
		{
		}
	}
}
