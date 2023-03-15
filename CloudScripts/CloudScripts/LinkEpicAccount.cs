using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class LinkEpicAccount
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public PlayFabAuthenticationContext AuthContext
			{
				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthContext_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CAuthContext_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40004CA")]
			public bool ForceLink
			{
				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public string PlayFabID
			{
				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabID_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabID_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public string AccountId
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CAccountId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CAccountId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public string ClientId
			{
				[Cpp2IlInjected.Token(Token = "0x60002F0")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CClientId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002F1")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CClientId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public string AccessToken
			{
				[Cpp2IlInjected.Token(Token = "0x60002F2")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003CAccessToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002F3")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				set
				{
					_003CAccessToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			VerifyTokenError,
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			PlayFabLinkError,
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000070")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40004D4")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40004D5")]
			public PlayFabErrorCode PlayFabErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public VerifyEpicTokenError VerifyTokenError
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CVerifyTokenError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CVerifyTokenError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x392F9C0", Offset = "0x392E3C0", VA = "0x18392F9C0")]
			public Result WithVerifyError(VerifyEpicTokenError verifyError)
			{
				//IL_0009: Expected I4, but got I8
				Error = Error.VerifyTokenError;
				VerifyTokenError = verifyError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x1170AF0", Offset = "0x116F4F0", VA = "0x181170AF0")]
			public Result WithPlayFabError(Error error, PlayFabErrorCode playfabError)
			{
				Error = error;
				PlayFabErrorCode = playfabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LinkEpicAccount()
		{
		}
	}
}
