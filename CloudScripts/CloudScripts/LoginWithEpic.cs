using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.ClientModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public class LoginWithEpic
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public string AccountId
			{
				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CAccountId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CAccountId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public string ClientId
			{
				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CClientId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CClientId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public string AccessToken
			{
				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CAccessToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CAccessToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public GetPlayerCombinedInfoRequestParams InfoRequestParameters
			{
				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CInfoRequestParameters_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CInfoRequestParameters_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000483")]
			public bool CreateAccount
			{
				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			VerifyTokenError,
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			LoginToPlayFabError,
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000489")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x400048A")]
			public PlayFabErrorCode PlayFabErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public VerifyEpicTokenError VerifyTokenError
			{
				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CVerifyTokenError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CVerifyTokenError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public LoginResult LoginResult
			{
				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CLoginResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CLoginResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x392F9C0", Offset = "0x392E3C0", VA = "0x18392F9C0")]
			public Result WithVerifyError(VerifyEpicTokenError verifyError)
			{
				//IL_0009: Expected I4, but got I8
				Error = Error.VerifyTokenError;
				VerifyTokenError = verifyError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1170AF0", Offset = "0x116F4F0", VA = "0x181170AF0")]
			public Result WithPlayFabError(Error error, PlayFabErrorCode playfabError)
			{
				Error = error;
				PlayFabErrorCode = playfabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LoginWithEpic()
		{
		}
	}
}
