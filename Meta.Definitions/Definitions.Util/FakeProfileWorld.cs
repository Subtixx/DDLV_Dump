using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Scene;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public class FakeProfileWorld : IProfileWorld
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public IGridProvider GridProvider;

		[Cpp2IlInjected.Token(Token = "0x17000335")]
		public string CurrentWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6000D60")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2E30", Offset = "0x2CA1830", VA = "0x182CA2E30", Slot = "7")]
			get
			{
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000336")]
		public Timestamp NextWeatherCheck
		{
			[Cpp2IlInjected.Token(Token = "0x6000D61")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "8")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000337")]
		public IEnumerable<Item> MissionsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000D70")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2E90", Offset = "0x2CA1890", VA = "0x182CA2E90", Slot = "22")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000338")]
		public IEnumerable<Item> MissionsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000D71")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2E60", Offset = "0x2CA1860", VA = "0x182CA2E60", Slot = "23")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000339")]
		public Item PlayerHouseItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7F")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2EC0", Offset = "0x2CA18C0", VA = "0x182CA2EC0", Slot = "37")]
			get
			{
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5D")]
		[Cpp2IlInjected.Address(RVA = "0x91C340", Offset = "0x91AD40", VA = "0x18091C340", Slot = "4")]
		public DateTime GetClientLocalTime(DateTime serverTime)
		{
			return serverTime;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "5")]
		public IGridProvider GetGridProvider()
		{
			return GridProvider;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
		public IKeyholesProvider GetKeyholesProvider()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
		public int GetFriendshipLevel(Item characterItem)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2D80", Offset = "0x2CA1780", VA = "0x182CA2D80")]
		public unsafe ScheduleType OverrideCharacterSchedule(CharacterItemData characterItemData, ScheduleType? scheduleType, DateTime localTime, bool canOverride, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_000b: Expected I4, but got O
			if ((object)scheduleType != null)
			{
				return (ScheduleType)((Nullable<>*)(&scheduleType))->value;
			}
			ScheduleType result = default(ScheduleType);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "11")]
		public bool HasEnoughCharactersToDiscuss(int minAmount)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D65")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "12")]
		public bool HasEnoughCrittersToFeed(int minAmount, ITransactionContext context)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D66")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "13")]
		public bool HasEnoughDriedFlowers(int minAmount)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D67")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "14")]
		public bool HasEnoughNightThorns(int minAmount)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D68")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "15")]
		public bool HasEnoughRestaurantOrders(int minAmount, ITransactionContext context)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public bool HasUnlockedDesignChallenges()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6A")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "16")]
		public bool IsCharacterLockedInVillage(Item characterItem)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6B")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "17")]
		public bool IsRealmUnlocked(Item universeTagItem)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6C")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "18")]
		public bool AnyRealmUnlocked()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6D")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "19")]
		public bool IsItemInVillage(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6E")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
		public bool IsCharacterUnlocked(Item characterItem)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2DD0", Offset = "0x2CA17D0", VA = "0x182CA2DD0", Slot = "21")]
		public Item GetCharacterProfession(Item characterItem)
		{
			return Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D72")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "24")]
		public bool IsMissionCompleted(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D73")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "25")]
		public bool IsMissionStarted(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D74")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "26")]
		public bool IsMissionAvailable(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D75")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "27")]
		public bool IsMissionStepCompleted(Item item, int stepID)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D76")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "28")]
		public MissionSlotState GetActiveMissionState(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D77")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "29")]
		public MissionStepStatus GetMissionStepStatus(Item item, int stepID)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D78")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "30")]
		public bool IsMissionObjectiveCompleted(Item item, int stepID, int subStepID, int objectiveID)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D79")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "31")]
		public MissionStepStatus GetMissionObjectiveStatus(Item item, int stepID, int subStepID, int objectiveID)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7A")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "32")]
		public bool IsBuildingUnlocked(Item buildingItem)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7B")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "33")]
		public bool IsBuildingUnlocked(IBuildingUnlockable buildingUnlockable)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7C")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "34")]
		public bool IsDialogueFlagOn(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7D")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "35")]
		public bool IsVillageAreaUnlocked(VillageAreaType villageArea)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7E")]
		[Cpp2IlInjected.Address(RVA = "0x1068830", Offset = "0x1067230", VA = "0x181068830", Slot = "36")]
		public int GetKeyholeCurrentLevel(string guid)
		{
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D80")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FakeProfileWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D81")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2D80", Offset = "0x2CA1780", VA = "0x182CA2D80", Slot = "10")]
		unsafe ScheduleType IProfileWorld.OverrideCharacterSchedule(CharacterItemData characterItemData, ScheduleType? scheduleType, DateTime localTime, bool canOverride, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_000b: Expected I4, but got O
			if ((object)scheduleType != null)
			{
				return (ScheduleType)((Nullable<>*)(&scheduleType))->value;
			}
			ScheduleType result = default(ScheduleType);
			return result;
		}
	}
}
