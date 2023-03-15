using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	public class BattlePassConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public string MainReward;

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public JObject FinishDate
		{
			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CFinishDate_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CFinishDate_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public Price PremiumPassPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CPremiumPassPrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CPremiumPassPrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400062A")]
		public int EventCurrencyIncrement
		{
			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public Price EventCurrencyIncrementPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CEventCurrencyIncrementPrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CEventCurrencyIncrementPrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x400062C")]
		public int CurrencyBundleAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public Price CurrencyBundlePrice
		{
			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CCurrencyBundlePrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CCurrencyBundlePrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x400062E")]
		public int FreeActiveTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x44"), Cpp2IlInjected.Token(Token = "0x400062F")]
		public int PremiumActiveTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public List<BattlePassRewardsPage> RewardsPages
		{
			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CRewardsPages_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CRewardsPages_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		[JsonIgnore]
		public int TotalRewardsNum
		{
			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x1024B00", Offset = "0x1023500", VA = "0x181024B00")]
			get
			{
				//Discarded unreachable code: IL_0015
				int size = ((List<>)(object)RewardsPages)._size;
				return NumRewardsPerPage * size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		[JsonIgnore]
		public int NumPages
		{
			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x1024A20", Offset = "0x1023420", VA = "0x181024A20")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)RewardsPages)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		[JsonIgnore]
		public int NumRewardsPerPage
		{
			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0x1024A60", Offset = "0x1023460", VA = "0x181024A60")]
			get
			{
				BattlePassRewardsPage battlePassRewardsPage = Enumerable.FirstOrDefault<BattlePassRewardsPage>((IEnumerable<>)RewardsPages);
				if (battlePassRewardsPage != null)
				{
					List<BattlePassReward> _003CRewards_003Ek__BackingField = battlePassRewardsPage.Rewards;
					if (_003CRewards_003Ek__BackingField != null)
					{
						int size = ((List<>)(object)_003CRewards_003Ek__BackingField)._size;
					}
				}
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x1024950", Offset = "0x1023350", VA = "0x181024950")]
		public BattlePassRewardsPage GetRewardsPage(int rewardIdx)
		{
			int numRewardsPerPage = NumRewardsPerPage;
			int size = ((List<>)(object)RewardsPages)._size;
			if (size > 0 && numRewardsPerPage > 0)
			{
				numRewardsPerPage = rewardIdx;
				if (numRewardsPerPage >= size)
				{
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x1024820", Offset = "0x1023220", VA = "0x181024820")]
		public BattlePassReward GetReward(int rewardIdx)
		{
			int numRewardsPerPage = NumRewardsPerPage;
			int size = ((List<>)(object)RewardsPages)._size;
			if (size > 0 && numRewardsPerPage > 0)
			{
				numRewardsPerPage = rewardIdx;
				if (numRewardsPerPage < size && numRewardsPerPage != 0)
				{
					int num = 0;
					int numRewardsPerPage2 = NumRewardsPerPage;
					numRewardsPerPage2 = rewardIdx;
					if ((long)num < (long)(IntPtr)PremiumPassPrice)
					{
						int num2 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						JObject jObject = FinishDate;
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BattlePassConfig()
		{
		}
	}
}
