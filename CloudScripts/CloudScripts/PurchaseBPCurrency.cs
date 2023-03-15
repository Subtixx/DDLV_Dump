using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class PurchaseBPCurrency
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class Request : CloudscriptRequestWithCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public string BattlePassOnlineId
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CBattlePassOnlineId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CBattlePassOnlineId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400003D")]
			public int AmountToBuy
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x400003E")]
			public bool UseBundlePromo
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public string StoreFrontGroupUniqueName
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CStoreFrontGroupUniqueName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CStoreFrontGroupUniqueName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public Request()
			{
				((Collision2D)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			ConfigNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			InvalidStartOrEndDate,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			InvalidConfig,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			EventEnded,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			SearchCurrencyError,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			PriceItemNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			GetInventoryProgressError,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			PremiumPassInactive,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			BundleAlreadyPurchased,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			NotEnoughCurrency,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			PurchaseCurrencyFailed
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000016")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400004D")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x400004E")]
			public int CurrencyBalance
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public DisneyCloudScript.SpendOnlineCurrency.Result CurrencySpendResult
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCurrencySpendResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CCurrencySpendResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = new DisneyCloudScript.SpendOnlineCurrency.Result();


			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x392FD60", Offset = "0x392E760", VA = "0x18392FD60")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PurchaseBPCurrency()
		{
		}
	}
}
