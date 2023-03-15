using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Serilog;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PurchaseBPReward
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public class Request : CloudscriptRequestWithCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public string BattlePassOnlineId
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CBattlePassOnlineId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CBattlePassOnlineId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000013")]
			public int RewardIdx
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public Request()
			{
				((LoggerConfiguration._003C_003Ec__DisplayClass32_0)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			ConfigNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			InvalidStartOrEndDate,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			InvalidConfig,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			InvalidRewardIndex,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			EventEnded,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			SearchCurrencyError,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			GetInventoryProgressError,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			ProgressionNotFound,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			NotEnoughCurrency,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			PremiumPassInactive,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			AlreadyPurchased,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			TaskRequirementFailed,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			RewardRequirementFailed,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			RewardItemNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			PurchaseRewardFailed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000025")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000026")]
			public int GameItemId
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000027")]
			public int ChangedAmount
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4000028")]
			public int Amount
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000029")]
			public int CurrencyBalance
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PurchaseBPReward()
		{
		}
	}
}
