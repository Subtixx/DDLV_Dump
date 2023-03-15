using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mono.Security.X509;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class PurchaseBPPremiumPass
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public class Request : CloudscriptRequestWithCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public string BattlePassOnlineId
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CBattlePassOnlineId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CBattlePassOnlineId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400002B")]
			public bool PurchaseBundle
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public string StoreFrontGroupUniqueName
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CStoreFrontGroupUniqueName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CStoreFrontGroupUniqueName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public Request()
			{
				((PKCS12.DeriveBytes)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			ConfigNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			InvalidStartOrEndDate,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			InvalidConfig,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			EventEnded,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			SearchCurrencyError,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			PriceItemNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			GetInventoryProgressError,
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			AlreadyPurchased,
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			NotEnoughCurrency,
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			PurchasePremiumPassFailed
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000039")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x400003A")]
			public int CurrencyBalance
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public DisneyCloudScript.SpendOnlineCurrency.Result CurrencySpendResult
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCurrencySpendResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CCurrencySpendResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = new DisneyCloudScript.SpendOnlineCurrency.Result();


			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x392FE90", Offset = "0x392E890", VA = "0x18392FE90")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PurchaseBPPremiumPass()
		{
		}
	}
}
