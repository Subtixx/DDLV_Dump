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
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface IProfileWorld
	{
		[Cpp2IlInjected.Token(Token = "0x17000328")]
		string CurrentWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6000D24")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000329")]
		Timestamp NextWeatherCheck
		{
			[Cpp2IlInjected.Token(Token = "0x6000D25")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032A")]
		IEnumerable<Item> MissionsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000D33")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032B")]
		IEnumerable<Item> MissionsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000D34")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032C")]
		Item PlayerHouseItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000D42")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DateTime GetClientLocalTime(DateTime serverTime);

		[Cpp2IlInjected.Token(Token = "0x6000D22")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IGridProvider GetGridProvider();

		[Cpp2IlInjected.Token(Token = "0x6000D23")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IKeyholesProvider GetKeyholesProvider();

		[Cpp2IlInjected.Token(Token = "0x6000D26")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int GetFriendshipLevel(Item characterItem);

		[Cpp2IlInjected.Token(Token = "0x6000D27")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ScheduleType OverrideCharacterSchedule(CharacterItemData characterItemData, ScheduleType? scheduleType, DateTime localTime, bool canOverride, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context);

		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool HasEnoughCharactersToDiscuss(int minAmount);

		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool HasEnoughCrittersToFeed(int minAmount, ITransactionContext context);

		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HasEnoughDriedFlowers(int minAmount);

		[Cpp2IlInjected.Token(Token = "0x6000D2B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HasEnoughNightThorns(int minAmount);

		[Cpp2IlInjected.Token(Token = "0x6000D2C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool HasEnoughRestaurantOrders(int minAmount, ITransactionContext context);

		[Cpp2IlInjected.Token(Token = "0x6000D2D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool IsCharacterLockedInVillage(Item characterItem);

		[Cpp2IlInjected.Token(Token = "0x6000D2E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool IsRealmUnlocked(Item universeTagItem);

		[Cpp2IlInjected.Token(Token = "0x6000D2F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool AnyRealmUnlocked();

		[Cpp2IlInjected.Token(Token = "0x6000D30")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool IsItemInVillage(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D31")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool IsCharacterUnlocked(Item characterItem);

		[Cpp2IlInjected.Token(Token = "0x6000D32")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Item GetCharacterProfession(Item characterItem);

		[Cpp2IlInjected.Token(Token = "0x6000D35")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool IsMissionCompleted(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D36")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool IsMissionStarted(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D37")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool IsMissionAvailable(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D38")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool IsMissionStepCompleted(Item item, int stepID);

		[Cpp2IlInjected.Token(Token = "0x6000D39")]
		[Cpp2IlInjected.Address(Slot = "24")]
		MissionSlotState GetActiveMissionState(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D3A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		MissionStepStatus GetMissionStepStatus(Item item, int stepID);

		[Cpp2IlInjected.Token(Token = "0x6000D3B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool IsMissionObjectiveCompleted(Item item, int stepID, int subStepID, int objectiveID);

		[Cpp2IlInjected.Token(Token = "0x6000D3C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		MissionStepStatus GetMissionObjectiveStatus(Item item, int stepID, int subStepID, int objectiveID);

		[Cpp2IlInjected.Token(Token = "0x6000D3D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool IsBuildingUnlocked(Item buildingItem);

		[Cpp2IlInjected.Token(Token = "0x6000D3E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool IsBuildingUnlocked(IBuildingUnlockable buildingUnlockable);

		[Cpp2IlInjected.Token(Token = "0x6000D3F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool IsDialogueFlagOn(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D40")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool IsVillageAreaUnlocked(VillageAreaType villageArea);

		[Cpp2IlInjected.Token(Token = "0x6000D41")]
		[Cpp2IlInjected.Address(Slot = "32")]
		int GetKeyholeCurrentLevel(string guid);
	}
}
