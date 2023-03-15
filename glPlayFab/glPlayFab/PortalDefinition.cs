using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public class PortalDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x17000118")]
		public string UserUrl
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CUserUrl_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CUserUrl_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public string TesterUrl
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CTesterUrl_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CTesterUrl_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PortalDefinition()
		{
		}
	}
}
