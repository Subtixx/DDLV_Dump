using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab;
using glPlayFab.Disney;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public class GetBundles
	{
		[Cpp2IlInjected.Token(Token = "0x2000157")]
		public class Request : GetLiveopsDataRequest
		{
			[Cpp2IlInjected.Token(Token = "0x170000D8")]
			public override ServerDataType ServerDataType
			{
				[Cpp2IlInjected.Token(Token = "0x6000463")]
				[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "12")]
				get
				{
					return ServerDataType.Bundles;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D9")]
			public override string OnlineFlagKey
			{
				[Cpp2IlInjected.Token(Token = "0x6000464")]
				[Cpp2IlInjected.Address(RVA = "0x392F540", Offset = "0x392DF40", VA = "0x18392F540", Slot = "13")]
				get
				{
					return "IsDevShop";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public Request()
			{
				((PlayfabEconomyExt._003C_003Ec__DisplayClass33_1)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			Unchanged,
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			Updated
		}

		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			PlayFabError,
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x200015A")]
		public class Result : GetLiveopsDataResult<BundleConfig>
		{
			[Cpp2IlInjected.Token(Token = "0x170000DA")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400064B")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000466")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000467")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000DB")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x6000468")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000469")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x392F5D0", Offset = "0x392DFD0", VA = "0x18392F5D0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x392F990", Offset = "0x392E390", VA = "0x18392F990")]
			public Result WithPlayFabError(PlayFabError playFabError)
			{
				//IL_0009: Expected I4, but got I8
				Error = Error.PlayFabError;
				PlayFabError = playFabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x392FD20", Offset = "0x392E720", VA = "0x18392FD20")]
			public Result()
			{
				((GetLiveopsDataResult<T>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GetBundles()
		{
		}
	}
}
