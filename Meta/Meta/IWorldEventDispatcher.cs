using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Meta.Grids;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009B5")]
	internal interface IWorldEventDispatcher
	{
		[Cpp2IlInjected.Token(Token = "0x60054C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RaiseGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic = false, [Optional] GridAddObjectOptions addObjectOptions);

		[Cpp2IlInjected.Token(Token = "0x60054C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RaiseBuildingUnlocked(Item item, [Optional] List<CurrencyCost> costs);

		[Cpp2IlInjected.Token(Token = "0x60054C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RaiseBuildingBuilt(Item item);

		[Cpp2IlInjected.Token(Token = "0x60054C4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RaiseBuildingUpgraded(GridObject gridObj, UpgradeData upData);

		[Cpp2IlInjected.Token(Token = "0x60054C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RaisePlayerHouseRoomAdded(int floorIndex, House.Types.RoomSlot roomSlot, [Optional] List<CurrencyCost> cost);

		[Cpp2IlInjected.Token(Token = "0x60054C6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RaisePlayerHouseRoomExpanded(int sizeX, int sizeY, int floorIndex, House.Types.RoomSlot roomSlot, [Optional] List<CurrencyCost> cost);

		[Cpp2IlInjected.Token(Token = "0x60054C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RaisePlayerHouseFloorAdded([Optional] CurrencyCost cost);

		[Cpp2IlInjected.Token(Token = "0x60054C8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RaisePlayerHouseRoomFlooringChanged(int floorIndex, House.Types.RoomSlot roomSlot, Item flooringItem);

		[Cpp2IlInjected.Token(Token = "0x60054C9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RaisePlayerHouseRoomWallpaperChanged(int floorIndex, House.Types.RoomSlot roomSlot, House.Types.WallPosition? wallPosition, Item wallpaperItem);

		[Cpp2IlInjected.Token(Token = "0x60054CA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RaiseCharacterUnlock(Item item);

		[Cpp2IlInjected.Token(Token = "0x60054CB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RaiseCharacterStateChange(Item item, Character.Types.CharacterStatus status, CharacterChangeStatusReason reason);

		[Cpp2IlInjected.Token(Token = "0x60054CC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void RaiseCharacterSkinChanged(Item characterItem, Item skinItem, bool automatic);

		[Cpp2IlInjected.Token(Token = "0x60054CD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void RaiseCharacterProfessionChanged(Item characterItem);

		[Cpp2IlInjected.Token(Token = "0x60054CE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void RaiseSecretCharacterVisitStarted(Character character);

		[Cpp2IlInjected.Token(Token = "0x60054CF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void RaiseRewardSpawnOnGrid();

		[Cpp2IlInjected.Token(Token = "0x60054D0")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void RaiseGardeningEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail);

		[Cpp2IlInjected.Token(Token = "0x60054D1")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RaiseWeedPulled(WeedPullEvent pullweedEvent);

		[Cpp2IlInjected.Token(Token = "0x60054D2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void RaiseCollectBurningState(BurningState.IBurningState burningState, ItemInstance item);

		[Cpp2IlInjected.Token(Token = "0x60054D3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void RaiseBurningStateStarted(BurningState.IBurningState burningState);

		[Cpp2IlInjected.Token(Token = "0x60054D4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void RaiseBurningStateEnded(BurningState.IBurningState burningState);

		[Cpp2IlInjected.Token(Token = "0x60054D5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void RaiseFlowerEvent(IGrid grid, GridObject gridObject, FlowerOperation operation, bool automatic, bool wasDry);

		[Cpp2IlInjected.Token(Token = "0x60054D6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void RaiseWeatherChanged(string oldWeather, string newWeather);

		[Cpp2IlInjected.Token(Token = "0x60054D7")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void RaiseAvatarRemoveBlocker(IGrid grid, GridObject gridObject);

		[Cpp2IlInjected.Token(Token = "0x60054D8")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void RaisePendingFishAdded(uint pendingFishID, PendingFish pendingFish);

		[Cpp2IlInjected.Token(Token = "0x60054D9")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void RaisePendingFishRemoved(uint pendingFishID);

		[Cpp2IlInjected.Token(Token = "0x60054DA")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void RaiseCharacterFriendshipChanged(Character character, int friendshipChange, int oldLevel, int newLevel, FriendshipSource friendshipSource);

		[Cpp2IlInjected.Token(Token = "0x60054DB")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void RaiseCharacterFriendshipLevelChanged(Item characterItem, int levelsGained);

		[Cpp2IlInjected.Token(Token = "0x60054DC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void RaiseFriendshipAdded(AddedFriendshipSummary addedFriendshipSummary);

		[Cpp2IlInjected.Token(Token = "0x60054DD")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void RaiseRestaurantOrderFulfilled(CharacterRestaurantOrder order, ItemWithState mealServed);

		[Cpp2IlInjected.Token(Token = "0x60054DE")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void RaiseMiningRockStateChanged(ActivityDataLocationFilter location, int index, MiningRock.StateOneofCase state);

		[Cpp2IlInjected.Token(Token = "0x60054DF")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void RaiseMiningRockEmptied(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, [Optional] int? criticalSuccessMinigameID);

		[Cpp2IlInjected.Token(Token = "0x60054E0")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void RaiseMiningRockDamaged();

		[Cpp2IlInjected.Token(Token = "0x60054E1")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void RaiseDailyResetExecuted();

		[Cpp2IlInjected.Token(Token = "0x60054E2")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void RaiseShopItemsRefreshed(string shopName, Item item, [Optional] CurrencyCost refreshCost, bool isFreeRefresh = false);

		[Cpp2IlInjected.Token(Token = "0x60054E3")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void RaiseStoreRefreshed(Item buildingItem, bool isFullRefresh);

		[Cpp2IlInjected.Token(Token = "0x60054E4")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void RaiseStoreItemBought(Item building, Item item, int displayIdx);

		[Cpp2IlInjected.Token(Token = "0x60054E5")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void RaiseRecurringEventRescheduled(uint recurringEventID);

		[Cpp2IlInjected.Token(Token = "0x60054E6")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void RaiseRecurringEventRemoved(uint recurringEventID);

		[Cpp2IlInjected.Token(Token = "0x60054E7")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void RaiseVillageAreaUnlocked(VillageAreaType areaType, [Optional] List<CurrencyCost> costs);

		[Cpp2IlInjected.Token(Token = "0x60054E8")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void RaiseRealmUnlocked(string realmID, bool unlockedByFlag);

		[Cpp2IlInjected.Token(Token = "0x60054E9")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void RaiseDiscussionEnded(Item characterItem);

		[Cpp2IlInjected.Token(Token = "0x60054EA")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void RaiseRaiseBringItemPreGifted(MissionSubStep subStep);

		[Cpp2IlInjected.Token(Token = "0x60054EB")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void RaiseItemsGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool alreadyGifted = false);

		[Cpp2IlInjected.Token(Token = "0x60054EC")]
		[Cpp2IlInjected.Address(Slot = "43")]
		void RaiseCharacterPreferredItemDiscover(Character character, int preferredIndex, PreferredItemStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x60054ED")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void RaiseKeyholeItemAdded(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount);

		[Cpp2IlInjected.Token(Token = "0x60054EE")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void RaiseKeyholeItemRemoved(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount);

		[Cpp2IlInjected.Token(Token = "0x60054EF")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void RaiseKeyholeItemMoved(Keyhole keyhole);

		[Cpp2IlInjected.Token(Token = "0x60054F0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void RaiseKeyholeLevelCompleted(Keyhole keyhole, int levelCompleted);

		[Cpp2IlInjected.Token(Token = "0x60054F1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void RaiseDialogueFlagChange(Item flagItem, bool active);

		[Cpp2IlInjected.Token(Token = "0x60054F2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void RaiseMissionStepProgress(MissionSlotClass slotClass, int slotId);

		[Cpp2IlInjected.Token(Token = "0x60054F3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void RaiseMissionCurrentStepChanged(MissionSlotClass slotClass, int slotId, int previousStepIndex, int currentStepIndex);

		[Cpp2IlInjected.Token(Token = "0x60054F4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void RaiseMissionStepStatusChanged(MissionSlotClass slotClass, int slotId, int stepIndex, MissionStepStatus previousStatus, MissionStepStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x60054F5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void RaiseMissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason = SlotUpdatedReason.AnyChanges, [Optional] List<AnyReward> rewards);

		[Cpp2IlInjected.Token(Token = "0x60054F6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void RaiseMissionObjectiveStatusChanged(MissionObjective obj, MissionStepStatus previousStatus, MissionStepStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x60054F7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void RaiseMissionItemAdded(string missionName, Dictionary<Item, int> items);

		[Cpp2IlInjected.Token(Token = "0x60054F8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void RaiseMissionItemGiven(Item missionItem, Dictionary<(Item item, ItemState state), int> items, [Optional] Item? characterItem, bool keepitems = false);

		[Cpp2IlInjected.Token(Token = "0x60054F9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void RaiseEventStarted(List<Item> characters);

		[Cpp2IlInjected.Token(Token = "0x60054FA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void RaiseEventEnded(List<Item> characters);

		[Cpp2IlInjected.Token(Token = "0x60054FB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void RaiseMegaEventStarted(bool start, DateTime startTime, DateTime endTime, string name);

		[Cpp2IlInjected.Token(Token = "0x60054FC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void RaiseMegaEventReady();

		[Cpp2IlInjected.Token(Token = "0x60054FD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void RaiseMegaEventStopped();

		[Cpp2IlInjected.Token(Token = "0x60054FE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void RaiseMegaEventOver();
	}
}
