using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Shops;
using Meta.Social;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009B4")]
	internal interface IPlayerEventDispatcher
	{
		[Cpp2IlInjected.Token(Token = "0x6005485")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RaiseCurrencyChanged(Item currencyItem, int gained, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x6005486")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RaisePlayerXpGained(int gained, int oldLevel, int newLevel, FriendshipSource friendshipSource);

		[Cpp2IlInjected.Token(Token = "0x6005487")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RaisePlayerLevelGained(int gainedLevels);

		[Cpp2IlInjected.Token(Token = "0x6005488")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RaiseManaChanged(int oldValue, int newValue, bool refill, [Optional] ProfileEventDispatcher.ManaSpentData spendActionData);

		[Cpp2IlInjected.Token(Token = "0x6005489")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RaiseManaHasAlreadyMissedChanged();

		[Cpp2IlInjected.Token(Token = "0x600548A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RaisePlayerBuffAdded(BuffOrigin buffOrigin, BuffType buffType, int percentageEffect);

		[Cpp2IlInjected.Token(Token = "0x600548B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RaisePlayerBuffRemoved(BuffOrigin buffOrigin, BuffType buffType);

		[Cpp2IlInjected.Token(Token = "0x600548C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RaisePlayerBuffUpdated(BuffOrigin buffOrigin, BuffType buffType);

		[Cpp2IlInjected.Token(Token = "0x600548D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RaiseToolAdded(Item toolItem);

		[Cpp2IlInjected.Token(Token = "0x600548E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RaiseToolUpgraded(Item toolItem, Item upgradeItem);

		[Cpp2IlInjected.Token(Token = "0x600548F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RaiseItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x6005490")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void RaiseItemRemoved(IInventory inventory, Item item, int amount, [Optional] ItemState state, InvActionType reason = InvActionType.None);

		[Cpp2IlInjected.Token(Token = "0x6005491")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void RaiseItemConsumed(Item consumedItem, MultiItemInstance generatedItems);

		[Cpp2IlInjected.Token(Token = "0x6005492")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void RaiseItemMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action);

		[Cpp2IlInjected.Token(Token = "0x6005493")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void RaiseInventorySorted(ContainerInventory containerInventory);

		[Cpp2IlInjected.Token(Token = "0x6005494")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void RaiseMemoryShardAdded(Item memoryShardItem, int memoryShardIndex, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x6005495")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RaiseRecipeAdded(Item recipeItem, InvActionType reason = InvActionType.None);

		[Cpp2IlInjected.Token(Token = "0x6005496")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void RaisePetUnlocked(Item petItem, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x6005497")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void RaiseCurrentPetChanged(Item previousPet, Item newPet);

		[Cpp2IlInjected.Token(Token = "0x6005498")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void RaiseFishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, [Optional] int? criticalSuccessMinigameID);

		[Cpp2IlInjected.Token(Token = "0x6005499")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void RaiseFishCollected(List<AnyReward> rewards);

		[Cpp2IlInjected.Token(Token = "0x600549A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void RaiseMealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene);

		[Cpp2IlInjected.Token(Token = "0x600549B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void RaiseCraftingCompleted(Item craftingRecipeItem, int amountOfCraftingDone);

		[Cpp2IlInjected.Token(Token = "0x600549C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void RaiseDutySlotUpdated(int slotID, bool generated = false);

		[Cpp2IlInjected.Token(Token = "0x600549D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void RaiseCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromConsumable = false);

		[Cpp2IlInjected.Token(Token = "0x600549E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void RaiseDutyAchRewardCollected(List<AnyReward> rewards, DutyAchItemType dutyAchtype, Item achievementItem);

		[Cpp2IlInjected.Token(Token = "0x600549F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void RaiseAchievementSetUpdated(Item achievementItem, bool milestonePassed = false);

		[Cpp2IlInjected.Token(Token = "0x60054A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void RaiseItemCollectMinigameAdded(Profile.ItemCollectMinigame minigame);

		[Cpp2IlInjected.Token(Token = "0x60054A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void RaiseItemCollectMinigameEnded(Profile.ItemCollectMinigame minigame);

		[Cpp2IlInjected.Token(Token = "0x60054A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void RaiseMinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items);

		[Cpp2IlInjected.Token(Token = "0x60054A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void RaiseCurrentSceneChanged(Item previousScene, Item currentScene);

		[Cpp2IlInjected.Token(Token = "0x60054A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void RaiseCurrentSceneChangedAfterLoading(Item previousScene, Item currentScene);

		[Cpp2IlInjected.Token(Token = "0x60054A5")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void RaiseShopItemBought(string shopName, Item item, int amount, CurrencyCost cost, bool isDelivery = false);

		[Cpp2IlInjected.Token(Token = "0x60054A6")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void RaiseShopItemsSold(string shopName, IInventory inventory, IEnumerable<ItemInstance> items, IEnumerable<CurrencyCost> costs);

		[Cpp2IlInjected.Token(Token = "0x60054A7")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void RaiseItemSold(string shopName, Item item, int amount, CurrencyCost cost);

		[Cpp2IlInjected.Token(Token = "0x60054A8")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void RaiseOfflineBought(BuyOffline.Types.Request request, CRMBuyResult result);

		[Cpp2IlInjected.Token(Token = "0x60054A9")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void RaiseLootPresentConsumed(MultiItemInstance rewards, int boxIndex);

		[Cpp2IlInjected.Token(Token = "0x60054AA")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void RaiseLootPresentCollected();

		[Cpp2IlInjected.Token(Token = "0x60054AB")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void RaiseIAPBought(BuyIAP.Types.Request request, CRMBuyResult result);

		[Cpp2IlInjected.Token(Token = "0x60054AC")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void RaiseCritterFed(Critter critter, FeedCritterDetails details);

		[Cpp2IlInjected.Token(Token = "0x60054AD")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void RaiseCritterUnlocked(Critter critter);

		[Cpp2IlInjected.Token(Token = "0x60054AE")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void RaiseCompanionPetted(Item companionItem);

		[Cpp2IlInjected.Token(Token = "0x60054AF")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void RaiseTrackedMissionChanged(Item missionItem);

		[Cpp2IlInjected.Token(Token = "0x60054B0")]
		[Cpp2IlInjected.Address(Slot = "43")]
		void RaiseFtueEventStart(Item ftueItem);

		[Cpp2IlInjected.Token(Token = "0x60054B1")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void RaiseFtueEventComplete(Item ftueItem);

		[Cpp2IlInjected.Token(Token = "0x60054B2")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void RaisePictureTaken(PhotoModeType photoMode, List<int> itemIds, List<int> gardenItemIds, SceneType sceneType);

		[Cpp2IlInjected.Token(Token = "0x60054B3")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void RaiseItemInteraction(Item item);

		[Cpp2IlInjected.Token(Token = "0x60054B4")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void RaiseFewMinuteHavePass(ProfileTimerType timerType, int minutesPassed);

		[Cpp2IlInjected.Token(Token = "0x60054B5")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void RaiseDebugSkippedTimeChanged(TimeSpan skippedTime);

		[Cpp2IlInjected.Token(Token = "0x60054B6")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void RaiseAvatarCustomizationChanged(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures);

		[Cpp2IlInjected.Token(Token = "0x60054B7")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void RaiseClothingDesignSaved(Item clothingItem, int nbChanges);

		[Cpp2IlInjected.Token(Token = "0x60054B8")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void RaiseMiniEventStarted(bool start, string name, DateTime endDate);

		[Cpp2IlInjected.Token(Token = "0x60054B9")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void RaiseMiniEventStopped(string name);

		[Cpp2IlInjected.Token(Token = "0x60054BA")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void RaiseItemsSentToInbox(List<InboxItemReward> items, ItemsSentToInboxReason reason);

		[Cpp2IlInjected.Token(Token = "0x60054BB")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void RaiseBattlePassTasksUpdate(Dictionary<string, BattlePassSeasonData> battlePassSeasons);

		[Cpp2IlInjected.Token(Token = "0x60054BC")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void RaiseBattlePassTaskUpdate(string battlePassOnlineId, BattlePassTaskProgress taskProgress);

		[Cpp2IlInjected.Token(Token = "0x60054BD")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void RaiseBattlePassCurrencyChanged(int gained, InvActionType reason, BattlePassActionType action);

		[Cpp2IlInjected.Token(Token = "0x60054BE")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void RaiseFoundersPackClaimed(string foundersPackName);

		[Cpp2IlInjected.Token(Token = "0x60054BF")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void RaiseOnlineBundlesUpdate(Dictionary<string, OnlineBundleData> bundles);

		[Cpp2IlInjected.Token(Token = "0x60054C0")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void RaiseOnlineStoresUpdate(Dictionary<string, OnlineStoreData> stores);
	}
}
