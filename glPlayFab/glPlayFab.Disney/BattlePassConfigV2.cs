using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	public class BattlePassConfigV2 : IOnlineLiveopsConfig, IServerDataConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public string MainReward;

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return _003COnlineId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500", Slot = "5")]
			[CompilerGenerated]
			set
			{
				_003COnlineId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40005CA")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40005CB")]
		public DateTime StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590", Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40005CC")]
		public DateTime FinishDate
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public DateTime? EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x1024660", Offset = "0x1023060", VA = "0x181024660", Slot = "10")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x10247E0", Offset = "0x10231E0", VA = "0x1810247E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40005CE")]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006FF")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40", Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return _003CMinGameVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60", Slot = "15")]
			[CompilerGenerated]
			set
			{
				_003CMinGameVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public DateTime? LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x1024680", Offset = "0x1023080", VA = "0x181024680")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x1024800", Offset = "0x1023200", VA = "0x181024800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public ServerLoc TitleLoc
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CTitleLoc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CTitleLoc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public ServerLoc DescLoc
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003CDescLoc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			set
			{
				_003CDescLoc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public ServerLoc CurrencyLoc
		{
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CCurrencyLoc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			set
			{
				_003CCurrencyLoc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public Price PremiumPassPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CPremiumPassPrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			set
			{
				_003CPremiumPassPrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x80"), Cpp2IlInjected.Token(Token = "0x40005D5")]
		public int EventCurrencyIncrement
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public Price EventCurrencyIncrementPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			[CompilerGenerated]
			get
			{
				return _003CEventCurrencyIncrementPrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			[CompilerGenerated]
			set
			{
				_003CEventCurrencyIncrementPrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x90"), Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int CurrencyBundleAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x725190", Offset = "0x723B90", VA = "0x180725190")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x725370", Offset = "0x723D70", VA = "0x180725370")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public Price CurrencyBundlePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			[CompilerGenerated]
			get
			{
				return _003CCurrencyBundlePrice_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			[CompilerGenerated]
			set
			{
				_003CCurrencyBundlePrice_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public BattlePassTaskConfigV2 TaskConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			[CompilerGenerated]
			get
			{
				return _003CTaskConfig_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			[CompilerGenerated]
			set
			{
				_003CTaskConfig_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA8"), Cpp2IlInjected.Token(Token = "0x40005DA")]
		public int FreeActiveTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x9D1840", Offset = "0x9D0240", VA = "0x1809D1840")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xF64F60", Offset = "0xF63960", VA = "0x180F64F60")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xAC"), Cpp2IlInjected.Token(Token = "0x40005DB")]
		public int PremiumActiveTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x1024770", Offset = "0x1023170", VA = "0x181024770")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x1024810", Offset = "0x1023210", VA = "0x181024810")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public List<BattlePassRewardsPage> RewardsPages
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			[CompilerGenerated]
			get
			{
				return _003CRewardsPages_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			[CompilerGenerated]
			set
			{
				_003CRewardsPages_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		[JsonIgnore]
		public int TotalRewardsNum
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x1024780", Offset = "0x1023180", VA = "0x181024780")]
			get
			{
				//Discarded unreachable code: IL_0015
				int size = ((List<>)(object)RewardsPages)._size;
				return NumRewardsPerPage * size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		[JsonIgnore]
		public int NumPages
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x1024690", Offset = "0x1023090", VA = "0x181024690")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)RewardsPages)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		[JsonIgnore]
		public int NumRewardsPerPage
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x10246D0", Offset = "0x10230D0", VA = "0x1810246D0")]
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

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		[JsonIgnore]
		public string CurrencyOnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x1024620", Offset = "0x1023020", VA = "0x181024620")]
			get
			{
				return OnlineId + "_OnlineCurrency";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BattlePassConfigV2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x1024430", Offset = "0x1022E30", VA = "0x181024430")]
		public BattlePassConfigV2(BattlePassConfigV2 other)
		{
			string text = (OnlineId = other.OnlineId);
			int num = (Version = other.Version);
			DateTime dateTime = (StartDate = other.StartDate);
			DateTime dateTime2 = (FinishDate = other.FinishDate);
			DateTime? dateTime3 = (EndDate = other.EndDate);
			bool flag = (IsHidden = other.IsHidden);
			string text2 = (MinGameVersion = other.MinGameVersion);
			DateTime? dateTime4 = (LastUpdateTimestamp = other.LastUpdateTimestamp);
			ServerLoc serverLoc = (TitleLoc = new ServerLoc(other.TitleLoc));
			ServerLoc serverLoc2 = (DescLoc = new ServerLoc(other.DescLoc));
			ServerLoc serverLoc3 = (CurrencyLoc = new ServerLoc(other.CurrencyLoc));
			Price price = (PremiumPassPrice = other.PremiumPassPrice);
			int num2 = (EventCurrencyIncrement = other.EventCurrencyIncrement);
			Price price2 = (EventCurrencyIncrementPrice = other.EventCurrencyIncrementPrice);
			int num3 = (CurrencyBundleAmount = other.CurrencyBundleAmount);
			Price price3 = (CurrencyBundlePrice = other.CurrencyBundlePrice);
			BattlePassTaskConfigV2 battlePassTaskConfigV = (TaskConfig = other.TaskConfig);
			int num4 = (FreeActiveTaskCount = other.FreeActiveTaskCount);
			int num5 = (PremiumActiveTaskCount = other.PremiumActiveTaskCount);
			List<BattlePassRewardsPage> list = (RewardsPages = other.RewardsPages);
			string text3 = (MainReward = other.MainReward);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x10242E0", Offset = "0x1022CE0", VA = "0x1810242E0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x10241A0", Offset = "0x1022BA0", VA = "0x1810241A0")]
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
					if (num < Version)
					{
						int num2 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						string text = OnlineId;
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x10243B0", Offset = "0x1022DB0", VA = "0x1810243B0")]
		public void SetLoc(string language)
		{
			ServerLoc serverLoc = (TitleLoc = ServerLoc.CreateSingleLocFrom(TitleLoc, language));
			ServerLoc serverLoc2 = (DescLoc = ServerLoc.CreateSingleLocFrom(DescLoc, language));
			ServerLoc serverLoc3 = (CurrencyLoc = ServerLoc.CreateSingleLocFrom(CurrencyLoc, language));
			/*Error: Unexpected end of block*/;
		}
	}
}
