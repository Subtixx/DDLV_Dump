using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace PlayFab.Plugins.CloudScript
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TitleAuthenticationContext
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string EntityToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CEntityToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CEntityToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TitleAuthenticationContext()
		{
		}
	}
}
