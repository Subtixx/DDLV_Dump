using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public class UnlinkEpicAccount
	{
		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public PlayFabAuthenticationContext AuthContext
			{
				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthContext_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CAuthContext_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public string PlayFabID
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabID_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabID_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public string AccountId
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CAccountId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CAccountId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public string ClientId
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CClientId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CClientId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			PlayFabUnlinkError,
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000077")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40004DF")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public string ErrorMessage
			{
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CErrorMessage_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CErrorMessage_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40004E1")]
			public PlayFabErrorCode PlayFabErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x392F9F0", Offset = "0x392E3F0", VA = "0x18392F9F0")]
			public Result WithPlayFabError(Error error, PlayFabErrorCode playfabError, string errorMessage)
			{
				Error = error;
				PlayFabErrorCode = playfabError;
				ErrorMessage = errorMessage;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UnlinkEpicAccount()
		{
		}
	}
}
