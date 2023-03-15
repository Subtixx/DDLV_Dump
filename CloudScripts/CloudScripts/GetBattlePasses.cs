using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab.Disney;
using PlayFab;
using PlayFab.EconomyModels;
using Polly;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class GetBattlePasses
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public class Request : GetLiveopsDataRequest
		{
			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public override ServerDataType ServerDataType
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "12")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public override string OnlineFlagKey
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x392F570", Offset = "0x392DF70", VA = "0x18392F570", Slot = "13")]
				get
				{
					return "IsDevBattlePass";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public Request()
			{
				((AsyncRetrySyntax._003C_003Ec__DisplayClass45_0)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Unchanged,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			Updated
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class BattlePassInfo : GetLiveopsDataResult<BattlePassConfigV2>.ConfigInfo
		{
			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public CatalogItem CurrencyItem
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CCurrencyItem_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CCurrencyItem_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x392E3A0", Offset = "0x392CDA0", VA = "0x18392E3A0")]
			public BattlePassInfo()
			{
				((GetLiveopsDataResult<T>.ConfigInfo)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			SearchFailed,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			PlayFabError,
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			CurrencyNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			SearchTaskFailed,
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class Result : GetLiveopsDataResult<BattlePassConfigV2>
		{
			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400005B")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x392F5D0", Offset = "0x392DFD0", VA = "0x18392F5D0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x392FA30", Offset = "0x392E430", VA = "0x18392FA30")]
			public Result WithPlayFabError(PlayFabError playFabError)
			{
				//IL_0009: Expected I4, but got I8
				Error = Error.PlayFabError;
				PlayFabError = playFabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x392FF00", Offset = "0x392E900", VA = "0x18392FF00")]
			public Result()
			{
				((GetLiveopsDataResult<T>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GetBattlePasses()
		{
		}
	}
}
