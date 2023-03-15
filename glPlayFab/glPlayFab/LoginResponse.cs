using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.ClientModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class LoginResponse
	{
		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public ClientSession Session
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CSession_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CSession_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public PlayFabResult<LoginResult> Response
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CResponse_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CResponse_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LoginResponse()
		{
		}
	}
}
