using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab;
using glPlayFab.Disney;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public class GetStores
	{
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		public class Request : GetLiveopsDataRequest
		{
			[Cpp2IlInjected.Token(Token = "0x170000DC")]
			public override ServerDataType ServerDataType
			{
				[Cpp2IlInjected.Token(Token = "0x600046E")]
				[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "12")]
				get
				{
					return ServerDataType.Stores;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DD")]
			public override string OnlineFlagKey
			{
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0x392F510", Offset = "0x392DF10", VA = "0x18392F510", Slot = "13")]
				get
				{
					return "IsDevShop";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public Request()
			{
				((PlayfabEconomyExt.InventoryItemWithMetadataResult)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015D")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			PlayFabError,
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x200015E")]
		public class Result : GetLiveopsDataResult<StoreConfig>
		{
			[Cpp2IlInjected.Token(Token = "0x170000DE")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000651")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000DF")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x392F5D0", Offset = "0x392DFD0", VA = "0x18392F5D0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x392F990", Offset = "0x392E390", VA = "0x18392F990")]
			public Result WithPlayFabError(PlayFabError playFabError)
			{
				//IL_0009: Expected I4, but got I8
				Error = Error.PlayFabError;
				PlayFabError = playFabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x392FF40", Offset = "0x392E940", VA = "0x18392FF40")]
			public Result()
			{
				((GetLiveopsDataResult<T>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GetStores()
		{
		}
	}
}
