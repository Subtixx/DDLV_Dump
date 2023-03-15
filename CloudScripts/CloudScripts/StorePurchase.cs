using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab.Disney;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public class StorePurchase
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x170000E0")]
			public string StoreId
			{
				[Cpp2IlInjected.Token(Token = "0x6000479")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CStoreId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CStoreId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E1")]
			public string ContentId
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CContentId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CContentId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E2")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000655")]
			public int PriceAmount
			{
				[Cpp2IlInjected.Token(Token = "0x600047D")]
				[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E3")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x4000656")]
			public int CurrencyGameId
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E4")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000657")]
			public int ContentVersion
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000482")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E5")]
			public string StoreFrontGroupUniqueName
			{
				[Cpp2IlInjected.Token(Token = "0x6000483")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CStoreFrontGroupUniqueName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000484")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CStoreFrontGroupUniqueName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000161")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			PlayFabError,
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			StoreConfigNotFound,
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			StoreExpired,
			[Cpp2IlInjected.Token(Token = "0x400065E")]
			ContentConfigNotFound,
			[Cpp2IlInjected.Token(Token = "0x400065F")]
			BundleConfigNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000660")]
			VersionMismatch,
			[Cpp2IlInjected.Token(Token = "0x4000661")]
			BundleExpired,
			[Cpp2IlInjected.Token(Token = "0x4000662")]
			SaleNotStarted,
			[Cpp2IlInjected.Token(Token = "0x4000663")]
			SaleExpired,
			[Cpp2IlInjected.Token(Token = "0x4000664")]
			PriceMismatch,
			[Cpp2IlInjected.Token(Token = "0x4000665")]
			InvalidRewardGameId,
			[Cpp2IlInjected.Token(Token = "0x4000666")]
			RewardCountMismatch,
			[Cpp2IlInjected.Token(Token = "0x4000667")]
			GetInventoryError,
			[Cpp2IlInjected.Token(Token = "0x4000668")]
			NotEnoughCurrency,
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			PriceItemNotFound,
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			AlreadyPurchased,
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			PurchaseTransactionFailed,
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x2000162")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x170000E6")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400066D")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E7")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E8")]
			public List<Content> Rewards
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CRewards_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CRewards_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E9")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000670")]
			public int CurrencyBalance
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EA")]
			public DisneyCloudScript.SpendOnlineCurrency.Result CurrencySpendResult
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CCurrencySpendResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CCurrencySpendResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = new DisneyCloudScript.SpendOnlineCurrency.Result();


			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x392F9C0", Offset = "0x392E3C0", VA = "0x18392F9C0")]
			public Result WithPlayFabError(PlayFabError playFabError)
			{
				//IL_0009: Expected I4, but got I8
				Error = Error.PlayFabError;
				PlayFabError = playFabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x392FCB0", Offset = "0x392E6B0", VA = "0x18392FCB0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public StorePurchase()
		{
		}
	}
}
