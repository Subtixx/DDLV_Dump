using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Shops;
using Gameloft.Rpc.Core.Client;
using Meta.Grids;
using Meta.Missions;
using Meta.Social;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009B6")]
	public class ProfileEventDispatcher : IPlayerEventDispatcher, IWorldEventDispatcher, IProfileEventDispatcher, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20009B7")]
		private class TransactionScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40028BC")]
			private readonly ProfileEventDispatcher dispatcher;

			[Cpp2IlInjected.Token(Token = "0x6005697")]
			[Cpp2IlInjected.Address(RVA = "0xEA7CE0", Offset = "0xEA66E0", VA = "0x180EA7CE0")]
			public TransactionScope(ProfileEventDispatcher dispatcher)
			{
				//Discarded unreachable code: IL_0014
				this.dispatcher = dispatcher;
				dispatcher.TransactionStart();
			}

			[Cpp2IlInjected.Token(Token = "0x6005698")]
			[Cpp2IlInjected.Address(RVA = "0xEA7CC0", Offset = "0xEA66C0", VA = "0x180EA7CC0", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_000c
				dispatcher.TransactionEnd();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20009B8")]
		public delegate void TransactionStateChanged(bool isActive);

		[Cpp2IlInjected.Token(Token = "0x20009B9")]
		public delegate void AnyConditionChanged(ConditionListener conditionListener);

		[Cpp2IlInjected.Token(Token = "0x20009BA")]
		public delegate void FewMinutesHavePass(ProfileTimerType timerType, int minutesPassed);

		[Cpp2IlInjected.Token(Token = "0x20009BB")]
		public delegate void ItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x20009BC")]
		public delegate void ItemRemoved(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason);

		[Cpp2IlInjected.Token(Token = "0x20009BD")]
		public delegate void ItemMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action);

		[Cpp2IlInjected.Token(Token = "0x20009BE")]
		public delegate void InventorySorted(ContainerInventory containerInventory);

		[Cpp2IlInjected.Token(Token = "0x20009BF")]
		public delegate void MissionStepProgress(MissionSlotClass slotClass, int slotId);

		[Cpp2IlInjected.Token(Token = "0x20009C0")]
		public delegate void MissionItemAdded(string missionName, Dictionary<Item, int> items);

		[Cpp2IlInjected.Token(Token = "0x20009C1")]
		public delegate void MissionItemGiven(Item missionItem, Dictionary<(Item item, ItemState state), int> items, [Optional] Item? characterItem, bool keepitems = false);

		[Cpp2IlInjected.Token(Token = "0x20009C2")]
		public delegate void ItemConsumed(Item consumedItem, MultiItemInstance generatedItems);

		[Cpp2IlInjected.Token(Token = "0x20009C3")]
		public delegate void GridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions addObjectOptions);

		[Cpp2IlInjected.Token(Token = "0x20009C4")]
		public delegate void AvatarRemoveBlocker(IGrid grid, GridObject gridObject);

		[Cpp2IlInjected.Token(Token = "0x20009C5")]
		public delegate void CharacterPreferredItemDiscover(Character character, int preferredIndex, PreferredItemStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x20009C6")]
		public delegate void CharacterFriendshipChanged(Character character, int friendshipChange, int oldLevel, int newLevel, FriendshipSource friendshipSource);

		[Cpp2IlInjected.Token(Token = "0x20009C7")]
		public delegate void CharacterFriendshipLevelChanged(Item characterItem, int levelsGained);

		[Cpp2IlInjected.Token(Token = "0x20009C8")]
		public delegate void CharacterProfessionChanged(Item characterItem);

		[Cpp2IlInjected.Token(Token = "0x20009C9")]
		public delegate void CurrencyChanged(Item currencyItem, int gained, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x20009CA")]
		public delegate void CurrentSceneChanged(Item previousScene, Item currentScene);

		[Cpp2IlInjected.Token(Token = "0x20009CB")]
		public delegate void DiscussionEnded(Item characterItem);

		[Cpp2IlInjected.Token(Token = "0x20009CC")]
		public class ManaSpentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40028BD")]
			public int ManaCost;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40028BE")]
			public int UnmodifiedManaCost;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40028BF")]
			public ManaData.Types.ManaSpendingActionType Type;

			[Cpp2IlInjected.Token(Token = "0x60056E9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ManaSpentData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20009CD")]
		public delegate void ManaChanged(int oldValue, int newValue, bool refill, ManaSpentData spendActionData);

		[Cpp2IlInjected.Token(Token = "0x20009CE")]
		public delegate void ManaHasAlreadyMissedChanged();

		[Cpp2IlInjected.Token(Token = "0x20009CF")]
		public delegate void PlayerXpGained(int gained, int oldLevel, int newLevel, FriendshipSource friendshipSource);

		[Cpp2IlInjected.Token(Token = "0x20009D0")]
		public delegate void PlayerLevelGained(int gained);

		[Cpp2IlInjected.Token(Token = "0x20009D1")]
		public delegate void FriendshipAdded(AddedFriendshipSummary addedFriendshipSummary);

		[Cpp2IlInjected.Token(Token = "0x20009D2")]
		public delegate void CharacterUnlocked(Item item);

		[Cpp2IlInjected.Token(Token = "0x20009D3")]
		public delegate void CharacterStateChange(Item item, Character.Types.CharacterStatus status, CharacterChangeStatusReason reason);

		[Cpp2IlInjected.Token(Token = "0x20009D4")]
		public delegate void CharacterSkinChanged(Item characterItem, Item skinItem, bool automatic);

		[Cpp2IlInjected.Token(Token = "0x20009D5")]
		public delegate void MegaEventStarted(bool start, DateTime startTime, DateTime endTime, string name);

		[Cpp2IlInjected.Token(Token = "0x20009D6")]
		public delegate void MiniEventStarted(bool start, string name, DateTime endDate);

		[Cpp2IlInjected.Token(Token = "0x20009D7")]
		public delegate void MiniEventStopped(string name);

		[Cpp2IlInjected.Token(Token = "0x20009D8")]
		public delegate void EventStarted(List<Item> characters);

		[Cpp2IlInjected.Token(Token = "0x20009D9")]
		public delegate void EventEnded(List<Item> characters);

		[Cpp2IlInjected.Token(Token = "0x20009DA")]
		public delegate void RaiseBringItemPreGifted(MissionSubStep subStep);

		[Cpp2IlInjected.Token(Token = "0x20009DB")]
		public delegate void ItemsGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool alreadyGifted = false);

		[Cpp2IlInjected.Token(Token = "0x20009DC")]
		public delegate void GardeningEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail);

		[Cpp2IlInjected.Token(Token = "0x20009DD")]
		public delegate void FlowerEvent(IGrid grid, GridObject gridObject, FlowerOperation operation, bool automatic, bool wasDry);

		[Cpp2IlInjected.Token(Token = "0x20009DE")]
		public delegate void MissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason, [Optional] List<AnyReward> rewards);

		[Cpp2IlInjected.Token(Token = "0x20009DF")]
		public delegate void MissionCurrentStepChanged(MissionSlotClass slotClass, int slotId, int previousStepIndex, int currentStepIndex);

		[Cpp2IlInjected.Token(Token = "0x20009E0")]
		public delegate void MissionStepStatusChanged(MissionSlotClass slotClass, int slotId, int stepIndex, MissionStepStatus previousStatus, MissionStepStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x20009E1")]
		public delegate void MissionObjectiveStatusChanged(MissionObjective obj, MissionStepStatus previousStatus, MissionStepStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x20009E2")]
		public delegate void TrackedMissionChanged(Item missionItem);

		[Cpp2IlInjected.Token(Token = "0x20009E3")]
		public delegate void PendingFishAdded(uint pendingFishID, PendingFish pendingFish);

		[Cpp2IlInjected.Token(Token = "0x20009E4")]
		public delegate void PendingFishRemoved(uint pendingFishID);

		[Cpp2IlInjected.Token(Token = "0x20009E5")]
		public delegate void FishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, int? criticalSuccessMinigameID);

		[Cpp2IlInjected.Token(Token = "0x20009E6")]
		public delegate void RecurringEventRescheduled(uint recurringEventID);

		[Cpp2IlInjected.Token(Token = "0x20009E7")]
		public delegate void ShopItemsRefreshed(string shopName, Item item, [Optional] CurrencyCost refreshCost, bool isFreeRefresh = false);

		[Cpp2IlInjected.Token(Token = "0x20009E8")]
		public delegate void StoreRefreshed(Item buildingItem, bool isFullRefresh);

		[Cpp2IlInjected.Token(Token = "0x20009E9")]
		public delegate void StoreItemBought(Item building, Item item, int displayIdx);

		[Cpp2IlInjected.Token(Token = "0x20009EA")]
		public delegate void ShopItemBought(string shopName, Item item, int amount, CurrencyCost cost, bool isDelivery);

		[Cpp2IlInjected.Token(Token = "0x20009EB")]
		public delegate void ItemsSold(string shopName, Item item, int amount, CurrencyCost cost);

		[Cpp2IlInjected.Token(Token = "0x20009EC")]
		public delegate void ShopItemsSold(string shopName, IInventory inventory, IEnumerable<ItemInstance> items, IEnumerable<CurrencyCost> costs);

		[Cpp2IlInjected.Token(Token = "0x20009ED")]
		public delegate void BuildingUnlocked(Item item, [Optional] List<CurrencyCost> costs);

		[Cpp2IlInjected.Token(Token = "0x20009EE")]
		public delegate void BuildingBuilt(Item item);

		[Cpp2IlInjected.Token(Token = "0x20009EF")]
		public delegate void MealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene);

		[Cpp2IlInjected.Token(Token = "0x20009F0")]
		public delegate void RecipeAdded(Item recipeItem, InvActionType reason = InvActionType.None);

		[Cpp2IlInjected.Token(Token = "0x20009F1")]
		public delegate void RestaurantOrderFulfilled(CharacterRestaurantOrder order, ItemWithState mealServed);

		[Cpp2IlInjected.Token(Token = "0x20009F2")]
		public delegate void PlayerBuffAdded(BuffOrigin buffOrigin, BuffType buffType, int percentageEffect);

		[Cpp2IlInjected.Token(Token = "0x20009F3")]
		public delegate void PlayerBuffUpdated(BuffOrigin buffOrigin, BuffType buffType);

		[Cpp2IlInjected.Token(Token = "0x20009F4")]
		public delegate void PlayerBuffRemoved(BuffOrigin buffOrigin, BuffType buffType);

		[Cpp2IlInjected.Token(Token = "0x20009F5")]
		public delegate void WeatherChanged(string oldWeather, string newWeather);

		[Cpp2IlInjected.Token(Token = "0x20009F6")]
		public delegate void VillageAreaUnlocked(VillageAreaType areaType, [Optional] List<CurrencyCost> costs);

		[Cpp2IlInjected.Token(Token = "0x20009F7")]
		public delegate void ProfileConflicted(CallContext context, bool beforeRpc, Profile clientProfile, Profile serverProfile);

		[Cpp2IlInjected.Token(Token = "0x20009F8")]
		public delegate void TutorialTriggered(List<int> tutorialIds);

		[Cpp2IlInjected.Token(Token = "0x20009F9")]
		public delegate void TutorialEnded(bool skipped);

		[Cpp2IlInjected.Token(Token = "0x20009FA")]
		public delegate void BundleTriggered(List<string> bundleIds);

		[Cpp2IlInjected.Token(Token = "0x20009FB")]
		public delegate void DebugSkippedTimeChanged(TimeSpan skippedTime);

		[Cpp2IlInjected.Token(Token = "0x20009FC")]
		public delegate void AvatarCustomizationChanged(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures);

		[Cpp2IlInjected.Token(Token = "0x20009FD")]
		public delegate void ClothingDesignSaved(Item clothingItem, int nbChanges);

		[Cpp2IlInjected.Token(Token = "0x20009FE")]
		public delegate Task<CRMBuyResult> IAPBuy(string productId, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x20009FF")]
		public delegate void IAPBought(BuyIAP.Types.Request request, CRMBuyResult result);

		[Cpp2IlInjected.Token(Token = "0x2000A00")]
		public delegate void OfflineBought(BuyOffline.Types.Request request, CRMBuyResult result);

		[Cpp2IlInjected.Token(Token = "0x2000A01")]
		public delegate void CrmRefreshed(string crmData);

		[Cpp2IlInjected.Token(Token = "0x2000A02")]
		public delegate void SemRefreshed(string semData);

		[Cpp2IlInjected.Token(Token = "0x2000A03")]
		public delegate void FtueEventComplete(Item ftueItem);

		[Cpp2IlInjected.Token(Token = "0x2000A04")]
		public delegate void LootPresentConsumed(MultiItemInstance rewards, int boxIndex);

		[Cpp2IlInjected.Token(Token = "0x2000A05")]
		public delegate void LootPresentCollected();

		[Cpp2IlInjected.Token(Token = "0x2000A06")]
		public delegate void PictureTaken(PhotoModeType photoMode, List<int> itemIds, List<int> gardenItemIds, SceneType sceneType);

		[Cpp2IlInjected.Token(Token = "0x2000A07")]
		public delegate void ItemInteraction(Item item);

		[Cpp2IlInjected.Token(Token = "0x2000A08")]
		public delegate void CritterFed(Critter critter, FeedCritterDetails details);

		[Cpp2IlInjected.Token(Token = "0x2000A09")]
		public delegate void CompanionPetted(Item companionItem);

		[Cpp2IlInjected.Token(Token = "0x2000A0A")]
		public delegate void CritterUpdated(Critter critter);

		[Cpp2IlInjected.Token(Token = "0x2000A0B")]
		public delegate void MemoryShardAdded(Item memoryShardItem, int memoryShardIndex, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x2000A0C")]
		public delegate void PetUnlocked(Item petItem, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x2000A0D")]
		public delegate void CurrentPetChanged(Item previousPet, Item newPet);

		[Cpp2IlInjected.Token(Token = "0x2000A0E")]
		public delegate void BurningStateUpdated(BurningState.IBurningState burningState);

		[Cpp2IlInjected.Token(Token = "0x2000A0F")]
		public delegate void CollectBurningState(BurningState.IBurningState burningState, ItemInstance item);

		[Cpp2IlInjected.Token(Token = "0x2000A10")]
		public delegate void MinigameEventHandler(Profile.ItemCollectMinigame minigame);

		[Cpp2IlInjected.Token(Token = "0x2000A11")]
		public delegate void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items);

		[Cpp2IlInjected.Token(Token = "0x2000A12")]
		public delegate void WeedPulled(WeedPullEvent pullweedEvent);

		[Cpp2IlInjected.Token(Token = "0x2000A13")]
		public delegate void PlayerHouseFloorAdded([Optional] CurrencyCost cost);

		[Cpp2IlInjected.Token(Token = "0x2000A14")]
		public delegate void PlayerHouseRoomExpanded(int sizeX, int sizeY, int floorIndex, House.Types.RoomSlot roomSlot, [Optional] List<CurrencyCost> cost);

		[Cpp2IlInjected.Token(Token = "0x2000A15")]
		public delegate void PlayerHouseRoomAdded(int floorIndex, House.Types.RoomSlot roomSlot, [Optional] List<CurrencyCost> cost);

		[Cpp2IlInjected.Token(Token = "0x2000A16")]
		public delegate void PlayerHouseRoomFlooringChanged(int floorIndex, House.Types.RoomSlot roomSlot, Item flooringItem);

		[Cpp2IlInjected.Token(Token = "0x2000A17")]
		public delegate void PlayerHouseRoomWallpaperChanged(int floorIndex, House.Types.RoomSlot roomSlot, House.Types.WallPosition? wallPosition, Item wallpaperItem);

		[Cpp2IlInjected.Token(Token = "0x2000A18")]
		public delegate void DialogueFlagChange(Item flagItem, bool active);

		[Cpp2IlInjected.Token(Token = "0x2000A19")]
		public delegate void SecretCharacterVisitStarted(Character character);

		[Cpp2IlInjected.Token(Token = "0x2000A1A")]
		public delegate void DutySlotUpdated(int slotID, bool generated = false);

		[Cpp2IlInjected.Token(Token = "0x2000A1B")]
		public delegate void CollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromConsumable = false);

		[Cpp2IlInjected.Token(Token = "0x2000A1C")]
		public delegate void FtueEventStart(Item ftueItem);

		[Cpp2IlInjected.Token(Token = "0x2000A1D")]
		public delegate void AchievementSetUpdated(Item achievementItem, bool milestonePassed);

		[Cpp2IlInjected.Token(Token = "0x2000A1E")]
		public delegate void DutyAchRewardCollected(List<AnyReward> rewards, DutyAchItemType dutyAchtype, Item achievementItem);

		[Cpp2IlInjected.Token(Token = "0x2000A1F")]
		public delegate void CollectionRewardCollected(CurrencyCost reward, string collectionName);

		[Cpp2IlInjected.Token(Token = "0x2000A20")]
		public delegate void BuidingUpgraded(GridObject gridObj, UpgradeData upData);

		[Cpp2IlInjected.Token(Token = "0x2000A21")]
		public delegate void RealmUnlocked(string realmID, bool unlockedByFlag);

		[Cpp2IlInjected.Token(Token = "0x2000A22")]
		public delegate void FishCollected(List<AnyReward> rewards);

		[Cpp2IlInjected.Token(Token = "0x2000A23")]
		public delegate void RewardSpawnOnGrid();

		[Cpp2IlInjected.Token(Token = "0x2000A24")]
		public delegate void DailyResetExecuted();

		[Cpp2IlInjected.Token(Token = "0x2000A25")]
		public delegate void MiningRockStateChanged(ActivityDataLocationFilter location, int index, MiningRock.StateOneofCase state);

		[Cpp2IlInjected.Token(Token = "0x2000A26")]
		public delegate void MiningRockEmptied(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, int? criticalSuccessMinigameID);

		[Cpp2IlInjected.Token(Token = "0x2000A27")]
		public delegate void MiningRockDamaged();

		[Cpp2IlInjected.Token(Token = "0x2000A28")]
		public delegate void CraftingCompleted(Item craftingRecipeItem, int amountOfCraftingDone);

		[Cpp2IlInjected.Token(Token = "0x2000A29")]
		public delegate void ToolAdded(Item toolItem);

		[Cpp2IlInjected.Token(Token = "0x2000A2A")]
		public delegate void ToolUpgraded(Item toolItem, Item upgradeItem);

		[Cpp2IlInjected.Token(Token = "0x2000A2B")]
		public delegate void KeyholeItemAdded(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount);

		[Cpp2IlInjected.Token(Token = "0x2000A2C")]
		public delegate void KeyholeItemRemoved(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount);

		[Cpp2IlInjected.Token(Token = "0x2000A2D")]
		public delegate void KeyholeItemMoved(Keyhole keyhole);

		[Cpp2IlInjected.Token(Token = "0x2000A2E")]
		public delegate void KeyholeLevelCompleted(Keyhole keyhole, int levelCompleted);

		[Cpp2IlInjected.Token(Token = "0x2000A2F")]
		public delegate void HangoutGatherReward(ItemReward[] rewardItems);

		[Cpp2IlInjected.Token(Token = "0x2000A30")]
		public delegate void HangoutChanged(Character hangoutCharacter);

		[Cpp2IlInjected.Token(Token = "0x2000A31")]
		public delegate void ItemsSentToInbox(List<InboxItemReward> items, ItemsSentToInboxReason reason);

		[Cpp2IlInjected.Token(Token = "0x2000A32")]
		public delegate void BattlePassTasksUpdate(Dictionary<string, BattlePassSeasonData> battlePassSeasons);

		[Cpp2IlInjected.Token(Token = "0x2000A33")]
		public delegate void BattlePassTaskUpdate(string battlePassOnlineId, BattlePassTaskProgress taskProgress);

		[Cpp2IlInjected.Token(Token = "0x2000A34")]
		public delegate void BattlePassCurrencyChanged(int gained, InvActionType reason, BattlePassActionType action);

		[Cpp2IlInjected.Token(Token = "0x2000A35")]
		public delegate void FoundersPackClaimed(string foundersPackName);

		[Cpp2IlInjected.Token(Token = "0x2000A36")]
		public delegate void OnlineBundlesUpdate(Dictionary<string, OnlineBundleData> bundles);

		[Cpp2IlInjected.Token(Token = "0x2000A37")]
		public delegate void OnlineStoresUpdate(Dictionary<string, OnlineStoreData> stores);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002834")]
		private ConditionEventHandler ConditionHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002835")]
		private int TransactionCounter;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event TransactionStateChanged OnTransactionStateChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005505")]
			[Cpp2IlInjected.Address(RVA = "0x958440", Offset = "0x956E40", VA = "0x180958440")]
			[CompilerGenerated]
			add
			{
				TransactionStateChanged onTransactionStateChanged = this.OnTransactionStateChanged;
				Delegate @delegate = Delegate.Combine(onTransactionStateChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTransactionStateChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005506")]
			[Cpp2IlInjected.Address(RVA = "0x95D800", Offset = "0x95C200", VA = "0x18095D800")]
			[CompilerGenerated]
			remove
			{
				TransactionStateChanged onTransactionStateChanged = this.OnTransactionStateChanged;
				Delegate @delegate = Delegate.Remove(onTransactionStateChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTransactionStateChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event AnyConditionChanged OnAnyConditionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005508")]
			[Cpp2IlInjected.Address(RVA = "0x9534E0", Offset = "0x951EE0", VA = "0x1809534E0")]
			[CompilerGenerated]
			add
			{
				AnyConditionChanged onAnyConditionChanged = this.OnAnyConditionChanged;
				Delegate @delegate = Delegate.Combine(onAnyConditionChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAnyConditionChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005509")]
			[Cpp2IlInjected.Address(RVA = "0x9588A0", Offset = "0x9572A0", VA = "0x1809588A0")]
			[CompilerGenerated]
			remove
			{
				AnyConditionChanged onAnyConditionChanged = this.OnAnyConditionChanged;
				Delegate @delegate = Delegate.Remove(onAnyConditionChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAnyConditionChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event FewMinutesHavePass OnFewMinutesHavePass
		{
			[Cpp2IlInjected.Token(Token = "0x600550B")]
			[Cpp2IlInjected.Address(RVA = "0x954DE0", Offset = "0x9537E0", VA = "0x180954DE0")]
			[CompilerGenerated]
			add
			{
				FewMinutesHavePass onFewMinutesHavePass = this.OnFewMinutesHavePass;
				Delegate @delegate = Delegate.Combine(onFewMinutesHavePass, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFewMinutesHavePass)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600550C")]
			[Cpp2IlInjected.Address(RVA = "0x95A1A0", Offset = "0x958BA0", VA = "0x18095A1A0")]
			[CompilerGenerated]
			remove
			{
				FewMinutesHavePass onFewMinutesHavePass = this.OnFewMinutesHavePass;
				Delegate @delegate = Delegate.Remove(onFewMinutesHavePass, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFewMinutesHavePass)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ItemAdded OnItemAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600550E")]
			[Cpp2IlInjected.Address(RVA = "0x955740", Offset = "0x954140", VA = "0x180955740")]
			[CompilerGenerated]
			add
			{
				ItemAdded onItemAdded = this.OnItemAdded;
				Delegate @delegate = Delegate.Combine(onItemAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600550F")]
			[Cpp2IlInjected.Address(RVA = "0x95AB00", Offset = "0x959500", VA = "0x18095AB00")]
			[CompilerGenerated]
			remove
			{
				ItemAdded onItemAdded = this.OnItemAdded;
				Delegate @delegate = Delegate.Remove(onItemAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ItemRemoved OnItemRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x6005511")]
			[Cpp2IlInjected.Address(RVA = "0x955B00", Offset = "0x954500", VA = "0x180955B00")]
			[CompilerGenerated]
			add
			{
				ItemRemoved onItemRemoved = this.OnItemRemoved;
				Delegate @delegate = Delegate.Combine(onItemRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005512")]
			[Cpp2IlInjected.Address(RVA = "0x95AEC0", Offset = "0x9598C0", VA = "0x18095AEC0")]
			[CompilerGenerated]
			remove
			{
				ItemRemoved onItemRemoved = this.OnItemRemoved;
				Delegate @delegate = Delegate.Remove(onItemRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ItemMoved OnItemMoved
		{
			[Cpp2IlInjected.Token(Token = "0x6005514")]
			[Cpp2IlInjected.Address(RVA = "0x955A60", Offset = "0x954460", VA = "0x180955A60")]
			[CompilerGenerated]
			add
			{
				ItemMoved onItemMoved = this.OnItemMoved;
				Delegate @delegate = Delegate.Combine(onItemMoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemMoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005515")]
			[Cpp2IlInjected.Address(RVA = "0x95AE20", Offset = "0x959820", VA = "0x18095AE20")]
			[CompilerGenerated]
			remove
			{
				ItemMoved onItemMoved = this.OnItemMoved;
				Delegate @delegate = Delegate.Remove(onItemMoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemMoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event InventorySorted OnInventorySorted
		{
			[Cpp2IlInjected.Token(Token = "0x6005517")]
			[Cpp2IlInjected.Address(RVA = "0x9556A0", Offset = "0x9540A0", VA = "0x1809556A0")]
			[CompilerGenerated]
			add
			{
				InventorySorted onInventorySorted = this.OnInventorySorted;
				Delegate @delegate = Delegate.Combine(onInventorySorted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInventorySorted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005518")]
			[Cpp2IlInjected.Address(RVA = "0x95AA60", Offset = "0x959460", VA = "0x18095AA60")]
			[CompilerGenerated]
			remove
			{
				InventorySorted onInventorySorted = this.OnInventorySorted;
				Delegate @delegate = Delegate.Remove(onInventorySorted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInventorySorted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event MissionStepProgress OnMissionStepProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600551A")]
			[Cpp2IlInjected.Address(RVA = "0x956D20", Offset = "0x955720", VA = "0x180956D20")]
			[CompilerGenerated]
			add
			{
				MissionStepProgress onMissionStepProgress = this.OnMissionStepProgress;
				Delegate @delegate = Delegate.Combine(onMissionStepProgress, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMissionStepProgress)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600551B")]
			[Cpp2IlInjected.Address(RVA = "0x95C0E0", Offset = "0x95AAE0", VA = "0x18095C0E0")]
			[CompilerGenerated]
			remove
			{
				MissionStepProgress onMissionStepProgress = this.OnMissionStepProgress;
				Delegate @delegate = Delegate.Remove(onMissionStepProgress, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMissionStepProgress)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event MissionItemAdded OnMissionItemAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600551D")]
			[Cpp2IlInjected.Address(RVA = "0x956AA0", Offset = "0x9554A0", VA = "0x180956AA0")]
			[CompilerGenerated]
			add
			{
				MissionItemAdded onMissionItemAdded = this.OnMissionItemAdded;
				Delegate @delegate = Delegate.Combine(onMissionItemAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMissionItemAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600551E")]
			[Cpp2IlInjected.Address(RVA = "0x95BE60", Offset = "0x95A860", VA = "0x18095BE60")]
			[CompilerGenerated]
			remove
			{
				MissionItemAdded onMissionItemAdded = this.OnMissionItemAdded;
				Delegate @delegate = Delegate.Remove(onMissionItemAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMissionItemAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event MissionItemGiven OnMissionItemGiven
		{
			[Cpp2IlInjected.Token(Token = "0x6005520")]
			[Cpp2IlInjected.Address(RVA = "0x956B40", Offset = "0x955540", VA = "0x180956B40")]
			[CompilerGenerated]
			add
			{
				MissionItemGiven onMissionItemGiven = this.OnMissionItemGiven;
				Delegate @delegate = Delegate.Combine(onMissionItemGiven, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMissionItemGiven)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005521")]
			[Cpp2IlInjected.Address(RVA = "0x95BF00", Offset = "0x95A900", VA = "0x18095BF00")]
			[CompilerGenerated]
			remove
			{
				MissionItemGiven onMissionItemGiven = this.OnMissionItemGiven;
				Delegate @delegate = Delegate.Remove(onMissionItemGiven, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMissionItemGiven)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event ItemConsumed OnItemConsumed
		{
			[Cpp2IlInjected.Token(Token = "0x6005523")]
			[Cpp2IlInjected.Address(RVA = "0x955920", Offset = "0x954320", VA = "0x180955920")]
			[CompilerGenerated]
			add
			{
				ItemConsumed onItemConsumed = this.OnItemConsumed;
				Delegate @delegate = Delegate.Combine(onItemConsumed, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemConsumed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005524")]
			[Cpp2IlInjected.Address(RVA = "0x95ACE0", Offset = "0x9596E0", VA = "0x18095ACE0")]
			[CompilerGenerated]
			remove
			{
				ItemConsumed onItemConsumed = this.OnItemConsumed;
				Delegate @delegate = Delegate.Remove(onItemConsumed, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemConsumed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event GridChanged OnGridChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005526")]
			[Cpp2IlInjected.Address(RVA = "0x955380", Offset = "0x953D80", VA = "0x180955380")]
			[CompilerGenerated]
			add
			{
				GridChanged onGridChanged = this.OnGridChanged;
				Delegate @delegate = Delegate.Combine(onGridChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onGridChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005527")]
			[Cpp2IlInjected.Address(RVA = "0x95A740", Offset = "0x959140", VA = "0x18095A740")]
			[CompilerGenerated]
			remove
			{
				GridChanged onGridChanged = this.OnGridChanged;
				Delegate @delegate = Delegate.Remove(onGridChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onGridChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event AvatarRemoveBlocker OnAvatarRemoveBlocker
		{
			[Cpp2IlInjected.Token(Token = "0x6005529")]
			[Cpp2IlInjected.Address(RVA = "0x953620", Offset = "0x952020", VA = "0x180953620")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600552A")]
			[Cpp2IlInjected.Address(RVA = "0x9589E0", Offset = "0x9573E0", VA = "0x1809589E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event CharacterPreferredItemDiscover OnCharacterPreferredItemDiscover
		{
			[Cpp2IlInjected.Token(Token = "0x600552C")]
			[Cpp2IlInjected.Address(RVA = "0x953E40", Offset = "0x952840", VA = "0x180953E40")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600552D")]
			[Cpp2IlInjected.Address(RVA = "0x959200", Offset = "0x957C00", VA = "0x180959200")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event CharacterFriendshipChanged OnCharacterFriendshipChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600552F")]
			[Cpp2IlInjected.Address(RVA = "0x953D00", Offset = "0x952700", VA = "0x180953D00")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005530")]
			[Cpp2IlInjected.Address(RVA = "0x9590C0", Offset = "0x957AC0", VA = "0x1809590C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event CharacterFriendshipLevelChanged OnCharacterFriendshipLevelChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005532")]
			[Cpp2IlInjected.Address(RVA = "0x953DA0", Offset = "0x9527A0", VA = "0x180953DA0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005533")]
			[Cpp2IlInjected.Address(RVA = "0x959160", Offset = "0x957B60", VA = "0x180959160")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event CharacterProfessionChanged OnCharacterProfessionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005535")]
			[Cpp2IlInjected.Address(RVA = "0x953EE0", Offset = "0x9528E0", VA = "0x180953EE0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005536")]
			[Cpp2IlInjected.Address(RVA = "0x9592A0", Offset = "0x957CA0", VA = "0x1809592A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event CurrencyChanged OnCurrencyChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005538")]
			[Cpp2IlInjected.Address(RVA = "0x954660", Offset = "0x953060", VA = "0x180954660")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005539")]
			[Cpp2IlInjected.Address(RVA = "0x959A20", Offset = "0x958420", VA = "0x180959A20")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event CurrentSceneChanged OnCurrentSceneChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600553B")]
			[Cpp2IlInjected.Address(RVA = "0x954840", Offset = "0x953240", VA = "0x180954840")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600553C")]
			[Cpp2IlInjected.Address(RVA = "0x959C00", Offset = "0x958600", VA = "0x180959C00")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event CurrentSceneChanged OnCurrentSceneChangedAfterLoading
		{
			[Cpp2IlInjected.Token(Token = "0x600553E")]
			[Cpp2IlInjected.Address(RVA = "0x9547A0", Offset = "0x9531A0", VA = "0x1809547A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600553F")]
			[Cpp2IlInjected.Address(RVA = "0x959B60", Offset = "0x958560", VA = "0x180959B60")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event DiscussionEnded OnDiscussionEnded
		{
			[Cpp2IlInjected.Token(Token = "0x6005541")]
			[Cpp2IlInjected.Address(RVA = "0x954AC0", Offset = "0x9534C0", VA = "0x180954AC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005542")]
			[Cpp2IlInjected.Address(RVA = "0x959E80", Offset = "0x958880", VA = "0x180959E80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event ManaChanged OnManaChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005544")]
			[Cpp2IlInjected.Address(RVA = "0x956140", Offset = "0x954B40", VA = "0x180956140")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005545")]
			[Cpp2IlInjected.Address(RVA = "0x95B500", Offset = "0x959F00", VA = "0x18095B500")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event ManaHasAlreadyMissedChanged OnManaHasAlreadyMissedChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005547")]
			[Cpp2IlInjected.Address(RVA = "0x9561E0", Offset = "0x954BE0", VA = "0x1809561E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005548")]
			[Cpp2IlInjected.Address(RVA = "0x95B5A0", Offset = "0x959FA0", VA = "0x18095B5A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event PlayerXpGained OnPlayerXpGained
		{
			[Cpp2IlInjected.Token(Token = "0x600554A")]
			[Cpp2IlInjected.Address(RVA = "0x957860", Offset = "0x956260", VA = "0x180957860")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600554B")]
			[Cpp2IlInjected.Address(RVA = "0x95CC20", Offset = "0x95B620", VA = "0x18095CC20")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event PlayerLevelGained OnPlayerLevelGained
		{
			[Cpp2IlInjected.Token(Token = "0x600554D")]
			[Cpp2IlInjected.Address(RVA = "0x9577C0", Offset = "0x9561C0", VA = "0x1809577C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600554E")]
			[Cpp2IlInjected.Address(RVA = "0x95CB80", Offset = "0x95B580", VA = "0x18095CB80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event FriendshipAdded OnFriendshipAdded
		{
			[Cpp2IlInjected.Token(Token = "0x6005550")]
			[Cpp2IlInjected.Address(RVA = "0x955100", Offset = "0x953B00", VA = "0x180955100")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005551")]
			[Cpp2IlInjected.Address(RVA = "0x95A4C0", Offset = "0x958EC0", VA = "0x18095A4C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event CharacterUnlocked OnCharacterUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6005553")]
			[Cpp2IlInjected.Address(RVA = "0x9540C0", Offset = "0x952AC0", VA = "0x1809540C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005554")]
			[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957E80", VA = "0x180959480")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event CharacterStateChange OnCharacterStateChange
		{
			[Cpp2IlInjected.Token(Token = "0x6005556")]
			[Cpp2IlInjected.Address(RVA = "0x954020", Offset = "0x952A20", VA = "0x180954020")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005557")]
			[Cpp2IlInjected.Address(RVA = "0x9593E0", Offset = "0x957DE0", VA = "0x1809593E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event CharacterSkinChanged OnCharacterSkinChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005559")]
			[Cpp2IlInjected.Address(RVA = "0x953F80", Offset = "0x952980", VA = "0x180953F80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600555A")]
			[Cpp2IlInjected.Address(RVA = "0x959340", Offset = "0x957D40", VA = "0x180959340")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event MegaEventStarted OnMegaEventStarted
		{
			[Cpp2IlInjected.Token(Token = "0x600555C")]
			[Cpp2IlInjected.Address(RVA = "0x956460", Offset = "0x954E60", VA = "0x180956460")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600555D")]
			[Cpp2IlInjected.Address(RVA = "0x95B820", Offset = "0x95A220", VA = "0x18095B820")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action OnMegaEventReady
		{
			[Cpp2IlInjected.Token(Token = "0x600555F")]
			[Cpp2IlInjected.Address(RVA = "0x9563C0", Offset = "0x954DC0", VA = "0x1809563C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005560")]
			[Cpp2IlInjected.Address(RVA = "0x95B780", Offset = "0x95A180", VA = "0x18095B780")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action OnMegaEventStopped
		{
			[Cpp2IlInjected.Token(Token = "0x6005562")]
			[Cpp2IlInjected.Address(RVA = "0x956500", Offset = "0x954F00", VA = "0x180956500")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005563")]
			[Cpp2IlInjected.Address(RVA = "0x95B8C0", Offset = "0x95A2C0", VA = "0x18095B8C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action OnMegaEventOver
		{
			[Cpp2IlInjected.Token(Token = "0x6005565")]
			[Cpp2IlInjected.Address(RVA = "0x956320", Offset = "0x954D20", VA = "0x180956320")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005566")]
			[Cpp2IlInjected.Address(RVA = "0x95B6E0", Offset = "0x95A0E0", VA = "0x18095B6E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event MiniEventStarted OnMiniEventStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6005568")]
			[Cpp2IlInjected.Address(RVA = "0x956640", Offset = "0x955040", VA = "0x180956640")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005569")]
			[Cpp2IlInjected.Address(RVA = "0x95BA00", Offset = "0x95A400", VA = "0x18095BA00")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event MiniEventStopped OnMiniEventStopped
		{
			[Cpp2IlInjected.Token(Token = "0x600556B")]
			[Cpp2IlInjected.Address(RVA = "0x9566E0", Offset = "0x9550E0", VA = "0x1809566E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600556C")]
			[Cpp2IlInjected.Address(RVA = "0x95BAA0", Offset = "0x95A4A0", VA = "0x18095BAA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event EventStarted OnEventStarted
		{
			[Cpp2IlInjected.Token(Token = "0x600556E")]
			[Cpp2IlInjected.Address(RVA = "0x954D40", Offset = "0x953740", VA = "0x180954D40")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600556F")]
			[Cpp2IlInjected.Address(RVA = "0x95A100", Offset = "0x958B00", VA = "0x18095A100")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event EventEnded OnEventEnded
		{
			[Cpp2IlInjected.Token(Token = "0x6005571")]
			[Cpp2IlInjected.Address(RVA = "0x954CA0", Offset = "0x9536A0", VA = "0x180954CA0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005572")]
			[Cpp2IlInjected.Address(RVA = "0x95A060", Offset = "0x958A60", VA = "0x18095A060")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event RaiseBringItemPreGifted OnRaiseBringItemPreGifted
		{
			[Cpp2IlInjected.Token(Token = "0x6005574")]
			[Cpp2IlInjected.Address(RVA = "0x9579A0", Offset = "0x9563A0", VA = "0x1809579A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005575")]
			[Cpp2IlInjected.Address(RVA = "0x95CD60", Offset = "0x95B760", VA = "0x18095CD60")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event ItemsGivenToCharacter OnItemsGivenToCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6005577")]
			[Cpp2IlInjected.Address(RVA = "0x955BA0", Offset = "0x9545A0", VA = "0x180955BA0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005578")]
			[Cpp2IlInjected.Address(RVA = "0x95AF60", Offset = "0x959960", VA = "0x18095AF60")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event GardeningEvent OnGardeningEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600557A")]
			[Cpp2IlInjected.Address(RVA = "0x9552E0", Offset = "0x953CE0", VA = "0x1809552E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600557B")]
			[Cpp2IlInjected.Address(RVA = "0x95A6A0", Offset = "0x9590A0", VA = "0x18095A6A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event FlowerEvent OnFlowerEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600557D")]
			[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9539C0", VA = "0x180954FC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600557E")]
			[Cpp2IlInjected.Address(RVA = "0x95A380", Offset = "0x958D80", VA = "0x18095A380")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event MissionSlotUpdated OnMissionSlotUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6005580")]
			[Cpp2IlInjected.Address(RVA = "0x956C80", Offset = "0x955680", VA = "0x180956C80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005581")]
			[Cpp2IlInjected.Address(RVA = "0x95C040", Offset = "0x95AA40", VA = "0x18095C040")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event MissionCurrentStepChanged OnMissionCurrentStepChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005583")]
			[Cpp2IlInjected.Address(RVA = "0x956A00", Offset = "0x955400", VA = "0x180956A00")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005584")]
			[Cpp2IlInjected.Address(RVA = "0x95BDC0", Offset = "0x95A7C0", VA = "0x18095BDC0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002E")]
		public event MissionStepStatusChanged OnMissionStepStatusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005586")]
			[Cpp2IlInjected.Address(RVA = "0x956DC0", Offset = "0x9557C0", VA = "0x180956DC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005587")]
			[Cpp2IlInjected.Address(RVA = "0x95C180", Offset = "0x95AB80", VA = "0x18095C180")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002F")]
		public event MissionObjectiveStatusChanged OnMissionObjectiveStatusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005589")]
			[Cpp2IlInjected.Address(RVA = "0x956BE0", Offset = "0x9555E0", VA = "0x180956BE0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600558A")]
			[Cpp2IlInjected.Address(RVA = "0x95BFA0", Offset = "0x95A9A0", VA = "0x18095BFA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000030")]
		public event TrackedMissionChanged OnTrackedMissionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600558C")]
			[Cpp2IlInjected.Address(RVA = "0x9583A0", Offset = "0x956DA0", VA = "0x1809583A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600558D")]
			[Cpp2IlInjected.Address(RVA = "0x95D760", Offset = "0x95C160", VA = "0x18095D760")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000031")]
		public event PendingFishAdded OnPendingFishAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600558F")]
			[Cpp2IlInjected.Address(RVA = "0x957040", Offset = "0x955A40", VA = "0x180957040")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005590")]
			[Cpp2IlInjected.Address(RVA = "0x95C400", Offset = "0x95AE00", VA = "0x18095C400")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000032")]
		public event PendingFishRemoved OnPendingFishRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x6005592")]
			[Cpp2IlInjected.Address(RVA = "0x9570E0", Offset = "0x955AE0", VA = "0x1809570E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005593")]
			[Cpp2IlInjected.Address(RVA = "0x95C4A0", Offset = "0x95AEA0", VA = "0x18095C4A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000033")]
		public event FishingResultReceived OnFishingResultReceived
		{
			[Cpp2IlInjected.Token(Token = "0x6005595")]
			[Cpp2IlInjected.Address(RVA = "0x954F20", Offset = "0x953920", VA = "0x180954F20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005596")]
			[Cpp2IlInjected.Address(RVA = "0x95A2E0", Offset = "0x958CE0", VA = "0x18095A2E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000034")]
		public event RecurringEventRescheduled OnRecurringEventRescheduled
		{
			[Cpp2IlInjected.Token(Token = "0x6005598")]
			[Cpp2IlInjected.Address(RVA = "0x957C20", Offset = "0x956620", VA = "0x180957C20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005599")]
			[Cpp2IlInjected.Address(RVA = "0x95CFE0", Offset = "0x95B9E0", VA = "0x18095CFE0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000035")]
		public event RecurringEventRescheduled OnRecurringEventRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x600559B")]
			[Cpp2IlInjected.Address(RVA = "0x957B80", Offset = "0x956580", VA = "0x180957B80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600559C")]
			[Cpp2IlInjected.Address(RVA = "0x95CF40", Offset = "0x95B940", VA = "0x18095CF40")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000036")]
		public event ShopItemsRefreshed OnShopItemsRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x600559E")]
			[Cpp2IlInjected.Address(RVA = "0x957FE0", Offset = "0x9569E0", VA = "0x180957FE0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600559F")]
			[Cpp2IlInjected.Address(RVA = "0x95D3A0", Offset = "0x95BDA0", VA = "0x18095D3A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000037")]
		public event StoreRefreshed OnStoreRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x60055A1")]
			[Cpp2IlInjected.Address(RVA = "0x9581C0", Offset = "0x956BC0", VA = "0x1809581C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055A2")]
			[Cpp2IlInjected.Address(RVA = "0x95D580", Offset = "0x95BF80", VA = "0x18095D580")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000038")]
		public event StoreItemBought OnStoreItemBought
		{
			[Cpp2IlInjected.Token(Token = "0x60055A4")]
			[Cpp2IlInjected.Address(RVA = "0x958120", Offset = "0x956B20", VA = "0x180958120")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055A5")]
			[Cpp2IlInjected.Address(RVA = "0x95D4E0", Offset = "0x95BEE0", VA = "0x18095D4E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000039")]
		public event ShopItemBought OnShopItemBought
		{
			[Cpp2IlInjected.Token(Token = "0x60055A7")]
			[Cpp2IlInjected.Address(RVA = "0x957F40", Offset = "0x956940", VA = "0x180957F40")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055A8")]
			[Cpp2IlInjected.Address(RVA = "0x95D300", Offset = "0x95BD00", VA = "0x18095D300")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003A")]
		public event ItemsSold OnItemsSold
		{
			[Cpp2IlInjected.Token(Token = "0x60055AA")]
			[Cpp2IlInjected.Address(RVA = "0x955CE0", Offset = "0x9546E0", VA = "0x180955CE0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055AB")]
			[Cpp2IlInjected.Address(RVA = "0x95B0A0", Offset = "0x959AA0", VA = "0x18095B0A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003B")]
		public event ShopItemsSold OnShopItemsSold
		{
			[Cpp2IlInjected.Token(Token = "0x60055AD")]
			[Cpp2IlInjected.Address(RVA = "0x958080", Offset = "0x956A80", VA = "0x180958080")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055AE")]
			[Cpp2IlInjected.Address(RVA = "0x95D440", Offset = "0x95BE40", VA = "0x18095D440")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003C")]
		public event BuildingUnlocked OnBuildingUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60055B0")]
			[Cpp2IlInjected.Address(RVA = "0x9539E0", Offset = "0x9523E0", VA = "0x1809539E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055B1")]
			[Cpp2IlInjected.Address(RVA = "0x958DA0", Offset = "0x9577A0", VA = "0x180958DA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003D")]
		public event BuildingBuilt OnBuildingBuilt
		{
			[Cpp2IlInjected.Token(Token = "0x60055B3")]
			[Cpp2IlInjected.Address(RVA = "0x953940", Offset = "0x952340", VA = "0x180953940")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055B4")]
			[Cpp2IlInjected.Address(RVA = "0x958D00", Offset = "0x957700", VA = "0x180958D00")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003E")]
		public event MealCooked OnMealCooked
		{
			[Cpp2IlInjected.Token(Token = "0x60055B6")]
			[Cpp2IlInjected.Address(RVA = "0x956280", Offset = "0x954C80", VA = "0x180956280")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055B7")]
			[Cpp2IlInjected.Address(RVA = "0x95B640", Offset = "0x95A040", VA = "0x18095B640")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003F")]
		public event RecipeAdded OnRecipeAdded
		{
			[Cpp2IlInjected.Token(Token = "0x60055B9")]
			[Cpp2IlInjected.Address(RVA = "0x957AE0", Offset = "0x9564E0", VA = "0x180957AE0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055BA")]
			[Cpp2IlInjected.Address(RVA = "0x95CEA0", Offset = "0x95B8A0", VA = "0x18095CEA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000040")]
		public event RestaurantOrderFulfilled OnRestaurantOrderFulfilled
		{
			[Cpp2IlInjected.Token(Token = "0x60055BC")]
			[Cpp2IlInjected.Address(RVA = "0x957CC0", Offset = "0x9566C0", VA = "0x180957CC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055BD")]
			[Cpp2IlInjected.Address(RVA = "0x95D080", Offset = "0x95BA80", VA = "0x18095D080")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000041")]
		public event PlayerBuffAdded OnPlayerBuffAdded
		{
			[Cpp2IlInjected.Token(Token = "0x60055BF")]
			[Cpp2IlInjected.Address(RVA = "0x9572C0", Offset = "0x955CC0", VA = "0x1809572C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C0")]
			[Cpp2IlInjected.Address(RVA = "0x95C680", Offset = "0x95B080", VA = "0x18095C680")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000042")]
		public event PlayerBuffUpdated OnPlayerBuffUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60055C2")]
			[Cpp2IlInjected.Address(RVA = "0x957400", Offset = "0x955E00", VA = "0x180957400")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C3")]
			[Cpp2IlInjected.Address(RVA = "0x95C7C0", Offset = "0x95B1C0", VA = "0x18095C7C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000043")]
		public event PlayerBuffRemoved OnPlayerBuffRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60055C5")]
			[Cpp2IlInjected.Address(RVA = "0x957360", Offset = "0x955D60", VA = "0x180957360")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C6")]
			[Cpp2IlInjected.Address(RVA = "0x95C720", Offset = "0x95B120", VA = "0x18095C720")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000044")]
		public event WeatherChanged OnWeatherChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60055C8")]
			[Cpp2IlInjected.Address(RVA = "0x9586C0", Offset = "0x9570C0", VA = "0x1809586C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C9")]
			[Cpp2IlInjected.Address(RVA = "0x95DA80", Offset = "0x95C480", VA = "0x18095DA80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000045")]
		public event VillageAreaUnlocked OnVillageAreaUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60055CB")]
			[Cpp2IlInjected.Address(RVA = "0x958620", Offset = "0x957020", VA = "0x180958620")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055CC")]
			[Cpp2IlInjected.Address(RVA = "0x95D9E0", Offset = "0x95C3E0", VA = "0x18095D9E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000046")]
		public event ProfileConflicted OnProfileConflicted
		{
			[Cpp2IlInjected.Token(Token = "0x60055CE")]
			[Cpp2IlInjected.Address(RVA = "0x957900", Offset = "0x956300", VA = "0x180957900")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055CF")]
			[Cpp2IlInjected.Address(RVA = "0x95CCC0", Offset = "0x95B6C0", VA = "0x18095CCC0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000047")]
		public event TutorialTriggered OnTutorialTriggered
		{
			[Cpp2IlInjected.Token(Token = "0x60055D1")]
			[Cpp2IlInjected.Address(RVA = "0x958580", Offset = "0x956F80", VA = "0x180958580")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055D2")]
			[Cpp2IlInjected.Address(RVA = "0x95D940", Offset = "0x95C340", VA = "0x18095D940")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000048")]
		public event TutorialEnded OnTutorialEnded
		{
			[Cpp2IlInjected.Token(Token = "0x60055D4")]
			[Cpp2IlInjected.Address(RVA = "0x9584E0", Offset = "0x956EE0", VA = "0x1809584E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055D5")]
			[Cpp2IlInjected.Address(RVA = "0x95D8A0", Offset = "0x95C2A0", VA = "0x18095D8A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000049")]
		public event BundleTriggered OnBundleTriggered
		{
			[Cpp2IlInjected.Token(Token = "0x60055D7")]
			[Cpp2IlInjected.Address(RVA = "0x953A80", Offset = "0x952480", VA = "0x180953A80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055D8")]
			[Cpp2IlInjected.Address(RVA = "0x958E40", Offset = "0x957840", VA = "0x180958E40")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004A")]
		public event DebugSkippedTimeChanged OnDebugSkippedTimeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60055DA")]
			[Cpp2IlInjected.Address(RVA = "0x954980", Offset = "0x953380", VA = "0x180954980")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055DB")]
			[Cpp2IlInjected.Address(RVA = "0x959D40", Offset = "0x958740", VA = "0x180959D40")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004B")]
		public event AvatarCustomizationChanged OnAvatarCustomizationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60055DD")]
			[Cpp2IlInjected.Address(RVA = "0x953580", Offset = "0x951F80", VA = "0x180953580")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055DE")]
			[Cpp2IlInjected.Address(RVA = "0x958940", Offset = "0x957340", VA = "0x180958940")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004C")]
		public event ClothingDesignSaved OnClothingDesignSaved
		{
			[Cpp2IlInjected.Token(Token = "0x60055E0")]
			[Cpp2IlInjected.Address(RVA = "0x954160", Offset = "0x952B60", VA = "0x180954160")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055E1")]
			[Cpp2IlInjected.Address(RVA = "0x959520", Offset = "0x957F20", VA = "0x180959520")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004D")]
		public event IAPBuy OnIAPBuy
		{
			[Cpp2IlInjected.Token(Token = "0x60055E3")]
			[Cpp2IlInjected.Address(RVA = "0x955600", Offset = "0x954000", VA = "0x180955600")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055E4")]
			[Cpp2IlInjected.Address(RVA = "0x95A9C0", Offset = "0x9593C0", VA = "0x18095A9C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004E")]
		public event IAPBought OnIAPBought
		{
			[Cpp2IlInjected.Token(Token = "0x60055E6")]
			[Cpp2IlInjected.Address(RVA = "0x955560", Offset = "0x953F60", VA = "0x180955560")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055E7")]
			[Cpp2IlInjected.Address(RVA = "0x95A920", Offset = "0x959320", VA = "0x18095A920")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004F")]
		public event OfflineBought OnOfflineBought
		{
			[Cpp2IlInjected.Token(Token = "0x60055E9")]
			[Cpp2IlInjected.Address(RVA = "0x956E60", Offset = "0x955860", VA = "0x180956E60")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055EA")]
			[Cpp2IlInjected.Address(RVA = "0x95C220", Offset = "0x95AC20", VA = "0x18095C220")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000050")]
		public event CrmRefreshed OnCrmRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x60055EC")]
			[Cpp2IlInjected.Address(RVA = "0x9545C0", Offset = "0x952FC0", VA = "0x1809545C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055ED")]
			[Cpp2IlInjected.Address(RVA = "0x959980", Offset = "0x958380", VA = "0x180959980")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000051")]
		public event SemRefreshed OnSemRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x60055EF")]
			[Cpp2IlInjected.Address(RVA = "0x957EA0", Offset = "0x9568A0", VA = "0x180957EA0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055F0")]
			[Cpp2IlInjected.Address(RVA = "0x95D260", Offset = "0x95BC60", VA = "0x18095D260")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000052")]
		public event FtueEventComplete OnFtueEventComplete
		{
			[Cpp2IlInjected.Token(Token = "0x60055F2")]
			[Cpp2IlInjected.Address(RVA = "0x9551A0", Offset = "0x953BA0", VA = "0x1809551A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055F3")]
			[Cpp2IlInjected.Address(RVA = "0x95A560", Offset = "0x958F60", VA = "0x18095A560")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000053")]
		public event LootPresentConsumed OnLootPresentConsumed
		{
			[Cpp2IlInjected.Token(Token = "0x60055F5")]
			[Cpp2IlInjected.Address(RVA = "0x9560A0", Offset = "0x954AA0", VA = "0x1809560A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055F6")]
			[Cpp2IlInjected.Address(RVA = "0x95B460", Offset = "0x959E60", VA = "0x18095B460")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000054")]
		public event LootPresentCollected OnLootPresentCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60055F8")]
			[Cpp2IlInjected.Address(RVA = "0x956000", Offset = "0x954A00", VA = "0x180956000")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055F9")]
			[Cpp2IlInjected.Address(RVA = "0x95B3C0", Offset = "0x959DC0", VA = "0x18095B3C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000055")]
		public event PictureTaken OnPictureTaken
		{
			[Cpp2IlInjected.Token(Token = "0x60055FB")]
			[Cpp2IlInjected.Address(RVA = "0x957220", Offset = "0x955C20", VA = "0x180957220")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055FC")]
			[Cpp2IlInjected.Address(RVA = "0x95C5E0", Offset = "0x95AFE0", VA = "0x18095C5E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000056")]
		public event ItemInteraction OnItemInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x60055FE")]
			[Cpp2IlInjected.Address(RVA = "0x9559C0", Offset = "0x9543C0", VA = "0x1809559C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055FF")]
			[Cpp2IlInjected.Address(RVA = "0x95AD80", Offset = "0x959780", VA = "0x18095AD80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000057")]
		public event CritterFed OnCritterFed
		{
			[Cpp2IlInjected.Token(Token = "0x6005601")]
			[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952E80", VA = "0x180954480")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005602")]
			[Cpp2IlInjected.Address(RVA = "0x959840", Offset = "0x958240", VA = "0x180959840")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000058")]
		public event CompanionPetted OnCompanionPetted
		{
			[Cpp2IlInjected.Token(Token = "0x6005604")]
			[Cpp2IlInjected.Address(RVA = "0x954340", Offset = "0x952D40", VA = "0x180954340")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005605")]
			[Cpp2IlInjected.Address(RVA = "0x959700", Offset = "0x958100", VA = "0x180959700")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000059")]
		public event CritterUpdated OnCritterUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6005607")]
			[Cpp2IlInjected.Address(RVA = "0x954520", Offset = "0x952F20", VA = "0x180954520")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005608")]
			[Cpp2IlInjected.Address(RVA = "0x9598E0", Offset = "0x9582E0", VA = "0x1809598E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005A")]
		public event MemoryShardAdded OnMemoryShardAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600560A")]
			[Cpp2IlInjected.Address(RVA = "0x9565A0", Offset = "0x954FA0", VA = "0x1809565A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600560B")]
			[Cpp2IlInjected.Address(RVA = "0x95B960", Offset = "0x95A360", VA = "0x18095B960")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005B")]
		public event PetUnlocked OnPetUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600560D")]
			[Cpp2IlInjected.Address(RVA = "0x957180", Offset = "0x955B80", VA = "0x180957180")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600560E")]
			[Cpp2IlInjected.Address(RVA = "0x95C540", Offset = "0x95AF40", VA = "0x18095C540")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005C")]
		public event CurrentPetChanged OnCurrentPetChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005610")]
			[Cpp2IlInjected.Address(RVA = "0x954700", Offset = "0x953100", VA = "0x180954700")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005611")]
			[Cpp2IlInjected.Address(RVA = "0x959AC0", Offset = "0x9584C0", VA = "0x180959AC0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005D")]
		public event BurningStateUpdated OnBurningStateStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6005613")]
			[Cpp2IlInjected.Address(RVA = "0x953C60", Offset = "0x952660", VA = "0x180953C60")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005614")]
			[Cpp2IlInjected.Address(RVA = "0x959020", Offset = "0x957A20", VA = "0x180959020")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005E")]
		public event CollectBurningState OnBurningStateCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6005616")]
			[Cpp2IlInjected.Address(RVA = "0x953B20", Offset = "0x952520", VA = "0x180953B20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005617")]
			[Cpp2IlInjected.Address(RVA = "0x958EE0", Offset = "0x9578E0", VA = "0x180958EE0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005F")]
		public event BurningStateUpdated OnBurningStateEnded
		{
			[Cpp2IlInjected.Token(Token = "0x6005619")]
			[Cpp2IlInjected.Address(RVA = "0x953BC0", Offset = "0x9525C0", VA = "0x180953BC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600561A")]
			[Cpp2IlInjected.Address(RVA = "0x958F80", Offset = "0x957980", VA = "0x180958F80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000060")]
		public event MinigameEventHandler OnItemCollectMinigameAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600561C")]
			[Cpp2IlInjected.Address(RVA = "0x9557E0", Offset = "0x9541E0", VA = "0x1809557E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600561D")]
			[Cpp2IlInjected.Address(RVA = "0x95ABA0", Offset = "0x9595A0", VA = "0x18095ABA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000061")]
		public event MinigameEventHandler OnItemCollectMinigameEnded
		{
			[Cpp2IlInjected.Token(Token = "0x600561F")]
			[Cpp2IlInjected.Address(RVA = "0x955880", Offset = "0x954280", VA = "0x180955880")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005620")]
			[Cpp2IlInjected.Address(RVA = "0x95AC40", Offset = "0x959640", VA = "0x18095AC40")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000062")]
		public event MinigameItemsCollected OnMinigameItemsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6005622")]
			[Cpp2IlInjected.Address(RVA = "0x956780", Offset = "0x955180", VA = "0x180956780")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005623")]
			[Cpp2IlInjected.Address(RVA = "0x95BB40", Offset = "0x95A540", VA = "0x18095BB40")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000063")]
		public event WeedPulled OnWeedPulled
		{
			[Cpp2IlInjected.Token(Token = "0x6005625")]
			[Cpp2IlInjected.Address(RVA = "0x958760", Offset = "0x957160", VA = "0x180958760")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005626")]
			[Cpp2IlInjected.Address(RVA = "0x95DB20", Offset = "0x95C520", VA = "0x18095DB20")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000064")]
		public event PlayerHouseFloorAdded OnPlayerHouseFloorAdded
		{
			[Cpp2IlInjected.Token(Token = "0x6005628")]
			[Cpp2IlInjected.Address(RVA = "0x9574A0", Offset = "0x955EA0", VA = "0x1809574A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005629")]
			[Cpp2IlInjected.Address(RVA = "0x95C860", Offset = "0x95B260", VA = "0x18095C860")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000065")]
		public event PlayerHouseRoomExpanded OnPlayerHouseRoomExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x600562B")]
			[Cpp2IlInjected.Address(RVA = "0x9575E0", Offset = "0x955FE0", VA = "0x1809575E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600562C")]
			[Cpp2IlInjected.Address(RVA = "0x95C9A0", Offset = "0x95B3A0", VA = "0x18095C9A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000066")]
		public event PlayerHouseRoomAdded OnPlayerHouseRoomAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600562E")]
			[Cpp2IlInjected.Address(RVA = "0x957540", Offset = "0x955F40", VA = "0x180957540")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600562F")]
			[Cpp2IlInjected.Address(RVA = "0x95C900", Offset = "0x95B300", VA = "0x18095C900")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000067")]
		public event PlayerHouseRoomFlooringChanged OnPlayerHouseRoomFlooringChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005631")]
			[Cpp2IlInjected.Address(RVA = "0x957680", Offset = "0x956080", VA = "0x180957680")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005632")]
			[Cpp2IlInjected.Address(RVA = "0x95CA40", Offset = "0x95B440", VA = "0x18095CA40")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000068")]
		public event PlayerHouseRoomWallpaperChanged OnPlayerHouseRoomWallpaperChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6005634")]
			[Cpp2IlInjected.Address(RVA = "0x957720", Offset = "0x956120", VA = "0x180957720")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005635")]
			[Cpp2IlInjected.Address(RVA = "0x95CAE0", Offset = "0x95B4E0", VA = "0x18095CAE0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000069")]
		public event DialogueFlagChange OnDialogueFlagChange
		{
			[Cpp2IlInjected.Token(Token = "0x6005637")]
			[Cpp2IlInjected.Address(RVA = "0x954A20", Offset = "0x953420", VA = "0x180954A20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005638")]
			[Cpp2IlInjected.Address(RVA = "0x959DE0", Offset = "0x9587E0", VA = "0x180959DE0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006A")]
		public event SecretCharacterVisitStarted OnSecretCharacterVisitStarted
		{
			[Cpp2IlInjected.Token(Token = "0x600563A")]
			[Cpp2IlInjected.Address(RVA = "0x957E00", Offset = "0x956800", VA = "0x180957E00")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600563B")]
			[Cpp2IlInjected.Address(RVA = "0x95D1C0", Offset = "0x95BBC0", VA = "0x18095D1C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006B")]
		public event DutySlotUpdated OnDutySlotUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x600563D")]
			[Cpp2IlInjected.Address(RVA = "0x954C00", Offset = "0x953600", VA = "0x180954C00")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600563E")]
			[Cpp2IlInjected.Address(RVA = "0x959FC0", Offset = "0x9589C0", VA = "0x180959FC0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006C")]
		public event CollectionSetUpdated OnCollectionSetUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6005640")]
			[Cpp2IlInjected.Address(RVA = "0x9542A0", Offset = "0x952CA0", VA = "0x1809542A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005641")]
			[Cpp2IlInjected.Address(RVA = "0x959660", Offset = "0x958060", VA = "0x180959660")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006D")]
		public event FtueEventStart OnFtueEventStart
		{
			[Cpp2IlInjected.Token(Token = "0x6005643")]
			[Cpp2IlInjected.Address(RVA = "0x955240", Offset = "0x953C40", VA = "0x180955240")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005644")]
			[Cpp2IlInjected.Address(RVA = "0x95A600", Offset = "0x959000", VA = "0x18095A600")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006E")]
		public event AchievementSetUpdated OnAchievementSetUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6005646")]
			[Cpp2IlInjected.Address(RVA = "0x953440", Offset = "0x951E40", VA = "0x180953440")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005647")]
			[Cpp2IlInjected.Address(RVA = "0x958800", Offset = "0x957200", VA = "0x180958800")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006F")]
		public event DutyAchRewardCollected OnDutyAchRewardCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6005649")]
			[Cpp2IlInjected.Address(RVA = "0x954B60", Offset = "0x953560", VA = "0x180954B60")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600564A")]
			[Cpp2IlInjected.Address(RVA = "0x959F20", Offset = "0x958920", VA = "0x180959F20")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000070")]
		public event CollectionRewardCollected OnCollectionRewardCollected
		{
			[Cpp2IlInjected.Token(Token = "0x600564C")]
			[Cpp2IlInjected.Address(RVA = "0x954200", Offset = "0x952C00", VA = "0x180954200")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600564D")]
			[Cpp2IlInjected.Address(RVA = "0x9595C0", Offset = "0x957FC0", VA = "0x1809595C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000071")]
		public event BuidingUpgraded OnBuidingUpgraded
		{
			[Cpp2IlInjected.Token(Token = "0x600564F")]
			[Cpp2IlInjected.Address(RVA = "0x9538A0", Offset = "0x9522A0", VA = "0x1809538A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005650")]
			[Cpp2IlInjected.Address(RVA = "0x958C60", Offset = "0x957660", VA = "0x180958C60")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000072")]
		public event RealmUnlocked OnRealmUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6005652")]
			[Cpp2IlInjected.Address(RVA = "0x957A40", Offset = "0x956440", VA = "0x180957A40")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005653")]
			[Cpp2IlInjected.Address(RVA = "0x95CE00", Offset = "0x95B800", VA = "0x18095CE00")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000073")]
		public event FishCollected OnFishCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6005655")]
			[Cpp2IlInjected.Address(RVA = "0x954E80", Offset = "0x953880", VA = "0x180954E80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005656")]
			[Cpp2IlInjected.Address(RVA = "0x95A240", Offset = "0x958C40", VA = "0x18095A240")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000074")]
		public event RewardSpawnOnGrid OnRewardSpawnOnGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6005658")]
			[Cpp2IlInjected.Address(RVA = "0x957D60", Offset = "0x956760", VA = "0x180957D60")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005659")]
			[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BB20", VA = "0x18095D120")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000075")]
		public event DailyResetExecuted OnDailyResetExecuted
		{
			[Cpp2IlInjected.Token(Token = "0x600565B")]
			[Cpp2IlInjected.Address(RVA = "0x9548E0", Offset = "0x9532E0", VA = "0x1809548E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600565C")]
			[Cpp2IlInjected.Address(RVA = "0x959CA0", Offset = "0x9586A0", VA = "0x180959CA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000076")]
		public event MiningRockStateChanged OnMiningRockStateChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600565E")]
			[Cpp2IlInjected.Address(RVA = "0x956960", Offset = "0x955360", VA = "0x180956960")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600565F")]
			[Cpp2IlInjected.Address(RVA = "0x95BD20", Offset = "0x95A720", VA = "0x18095BD20")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000077")]
		public event MiningRockEmptied OnMiningRockEmptied
		{
			[Cpp2IlInjected.Token(Token = "0x6005661")]
			[Cpp2IlInjected.Address(RVA = "0x9568C0", Offset = "0x9552C0", VA = "0x1809568C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005662")]
			[Cpp2IlInjected.Address(RVA = "0x95BC80", Offset = "0x95A680", VA = "0x18095BC80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000078")]
		public event MiningRockDamaged OnMiningRockDamaged
		{
			[Cpp2IlInjected.Token(Token = "0x6005664")]
			[Cpp2IlInjected.Address(RVA = "0x956820", Offset = "0x955220", VA = "0x180956820")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005665")]
			[Cpp2IlInjected.Address(RVA = "0x95BBE0", Offset = "0x95A5E0", VA = "0x18095BBE0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000079")]
		public event CraftingCompleted OnCraftingCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6005667")]
			[Cpp2IlInjected.Address(RVA = "0x9543E0", Offset = "0x952DE0", VA = "0x1809543E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005668")]
			[Cpp2IlInjected.Address(RVA = "0x9597A0", Offset = "0x9581A0", VA = "0x1809597A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007A")]
		public event ToolAdded OnToolAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600566A")]
			[Cpp2IlInjected.Address(RVA = "0x958260", Offset = "0x956C60", VA = "0x180958260")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600566B")]
			[Cpp2IlInjected.Address(RVA = "0x95D620", Offset = "0x95C020", VA = "0x18095D620")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007B")]
		public event ToolUpgraded OnToolUpgraded
		{
			[Cpp2IlInjected.Token(Token = "0x600566D")]
			[Cpp2IlInjected.Address(RVA = "0x958300", Offset = "0x956D00", VA = "0x180958300")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600566E")]
			[Cpp2IlInjected.Address(RVA = "0x95D6C0", Offset = "0x95C0C0", VA = "0x18095D6C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007C")]
		public event KeyholeItemAdded OnKeyholeItemAdded
		{
			[Cpp2IlInjected.Token(Token = "0x6005670")]
			[Cpp2IlInjected.Address(RVA = "0x955D80", Offset = "0x954780", VA = "0x180955D80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005671")]
			[Cpp2IlInjected.Address(RVA = "0x95B140", Offset = "0x959B40", VA = "0x18095B140")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007D")]
		public event KeyholeItemRemoved OnKeyholeItemRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x6005673")]
			[Cpp2IlInjected.Address(RVA = "0x955EC0", Offset = "0x9548C0", VA = "0x180955EC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005674")]
			[Cpp2IlInjected.Address(RVA = "0x95B280", Offset = "0x959C80", VA = "0x18095B280")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007E")]
		public event KeyholeItemMoved OnKeyholeItemMoved
		{
			[Cpp2IlInjected.Token(Token = "0x6005676")]
			[Cpp2IlInjected.Address(RVA = "0x955E20", Offset = "0x954820", VA = "0x180955E20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005677")]
			[Cpp2IlInjected.Address(RVA = "0x95B1E0", Offset = "0x959BE0", VA = "0x18095B1E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007F")]
		public event KeyholeLevelCompleted OnKeyholeLevelCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6005679")]
			[Cpp2IlInjected.Address(RVA = "0x955F60", Offset = "0x954960", VA = "0x180955F60")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600567A")]
			[Cpp2IlInjected.Address(RVA = "0x95B320", Offset = "0x959D20", VA = "0x18095B320")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000080")]
		public event HangoutGatherReward OnHangoutGatherReward
		{
			[Cpp2IlInjected.Token(Token = "0x600567C")]
			[Cpp2IlInjected.Address(RVA = "0x9554C0", Offset = "0x953EC0", VA = "0x1809554C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600567D")]
			[Cpp2IlInjected.Address(RVA = "0x95A880", Offset = "0x959280", VA = "0x18095A880")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000081")]
		public event HangoutChanged OnHangoutChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600567F")]
			[Cpp2IlInjected.Address(RVA = "0x955420", Offset = "0x953E20", VA = "0x180955420")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005680")]
			[Cpp2IlInjected.Address(RVA = "0x95A7E0", Offset = "0x9591E0", VA = "0x18095A7E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000082")]
		public event ItemsSentToInbox OnItemsSentToInbox
		{
			[Cpp2IlInjected.Token(Token = "0x6005682")]
			[Cpp2IlInjected.Address(RVA = "0x955C40", Offset = "0x954640", VA = "0x180955C40")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005683")]
			[Cpp2IlInjected.Address(RVA = "0x95B000", Offset = "0x959A00", VA = "0x18095B000")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000083")]
		public event BattlePassTasksUpdate OnBattlePassTasksUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6005685")]
			[Cpp2IlInjected.Address(RVA = "0x953800", Offset = "0x952200", VA = "0x180953800")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005686")]
			[Cpp2IlInjected.Address(RVA = "0x958BC0", Offset = "0x9575C0", VA = "0x180958BC0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000084")]
		public event BattlePassTaskUpdate OnBattlePassTaskUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6005688")]
			[Cpp2IlInjected.Address(RVA = "0x953760", Offset = "0x952160", VA = "0x180953760")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005689")]
			[Cpp2IlInjected.Address(RVA = "0x958B20", Offset = "0x957520", VA = "0x180958B20")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000085")]
		public event BattlePassCurrencyChanged OnBattlePassCurrencyChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600568B")]
			[Cpp2IlInjected.Address(RVA = "0x9536C0", Offset = "0x9520C0", VA = "0x1809536C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600568C")]
			[Cpp2IlInjected.Address(RVA = "0x958A80", Offset = "0x957480", VA = "0x180958A80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000086")]
		public event FoundersPackClaimed OnFoundersPackClaimed
		{
			[Cpp2IlInjected.Token(Token = "0x600568E")]
			[Cpp2IlInjected.Address(RVA = "0x955060", Offset = "0x953A60", VA = "0x180955060")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600568F")]
			[Cpp2IlInjected.Address(RVA = "0x95A420", Offset = "0x958E20", VA = "0x18095A420")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000087")]
		public event OnlineBundlesUpdate OnOnlineBundlesUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6005691")]
			[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955900", VA = "0x180956F00")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005692")]
			[Cpp2IlInjected.Address(RVA = "0x95C2C0", Offset = "0x95ACC0", VA = "0x18095C2C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000088")]
		public event OnlineStoresUpdate OnOnlineStoresUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6005694")]
			[Cpp2IlInjected.Address(RVA = "0x956FA0", Offset = "0x9559A0", VA = "0x180956FA0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005695")]
			[Cpp2IlInjected.Address(RVA = "0x95C360", Offset = "0x95AD60", VA = "0x18095C360")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054FF")]
		[Cpp2IlInjected.Address(RVA = "0x953340", Offset = "0x951D40", VA = "0x180953340")]
		public ConditionEventHandler RegisterToAnyConditionChanged(ConditionListener mask, AnyConditionChanged callback)
		{
			return ConditionEventHandler.Register(this, mask, callback);
		}

		[Cpp2IlInjected.Token(Token = "0x6005500")]
		[Cpp2IlInjected.Address(RVA = "0x9533B0", Offset = "0x951DB0", VA = "0x1809533B0")]
		public ProfileEventDispatcher()
		{
			AnyConditionChanged callback = RaiseAnyConditionChanged;
			ConditionEventHandler conditionEventHandler = (ConditionHandler = ConditionEventHandler.Register(this, ConditionListener.All, callback));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005501")]
		[Cpp2IlInjected.Address(RVA = "0x951F00", Offset = "0x950900", VA = "0x180951F00", Slot = "126")]
		public void Dispose()
		{
			ConditionEventHandler conditionHandler;
			do
			{
				conditionHandler = ConditionHandler;
			}
			while (conditionHandler == null);
			conditionHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005502")]
		[Cpp2IlInjected.Address(RVA = "0x951EA0", Offset = "0x9508A0", VA = "0x180951EA0")]
		public IDisposable CreateTransactionScope()
		{
			TransactionScope transactionScope = new TransactionScope(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005503")]
		[Cpp2IlInjected.Address(RVA = "0x953380", Offset = "0x951D80", VA = "0x180953380")]
		private void TransactionStart()
		{
			int transactionCounter = TransactionCounter;
			int num = (TransactionCounter = transactionCounter + 1);
			if (transactionCounter == 0)
			{
				this.OnTransactionStateChanged?.Invoke(isActive: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005504")]
		[Cpp2IlInjected.Address(RVA = "0x953350", Offset = "0x951D50", VA = "0x180953350")]
		private void TransactionEnd()
		{
			int transactionCounter = TransactionCounter;
			if (transactionCounter <= 0)
			{
				return;
			}
			TransactionCounter = transactionCounter;
			if (transactionCounter == 0)
			{
				TransactionStateChanged onTransactionStateChanged = this.OnTransactionStateChanged;
				if (onTransactionStateChanged != null)
				{
					int isActive = 0;
					onTransactionStateChanged((byte)isActive != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005507")]
		[Cpp2IlInjected.Address(RVA = "0x9532E0", Offset = "0x951CE0", VA = "0x1809532E0")]
		internal void RaiseTransactionStateChanged(bool isActive)
		{
			this.OnTransactionStateChanged?.Invoke(isActive);
		}

		[Cpp2IlInjected.Token(Token = "0x600550A")]
		[Cpp2IlInjected.Address(RVA = "0x953080", Offset = "0x951A80", VA = "0x180953080")]
		internal void RaiseAnyConditionChanged(ConditionListener conditionListener)
		{
			this.OnAnyConditionChanged?.Invoke(conditionListener);
		}

		[Cpp2IlInjected.Token(Token = "0x600550D")]
		[Cpp2IlInjected.Address(RVA = "0x952310", Offset = "0x950D10", VA = "0x180952310", Slot = "51")]
		void IPlayerEventDispatcher.RaiseFewMinuteHavePass(ProfileTimerType timerType, int minutesPassed)
		{
			this.OnFewMinutesHavePass?.Invoke(timerType, minutesPassed);
		}

		[Cpp2IlInjected.Token(Token = "0x6005510")]
		[Cpp2IlInjected.Address(RVA = "0x952410", Offset = "0x950E10", VA = "0x180952410", Slot = "14")]
		void IPlayerEventDispatcher.RaiseItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			if (this.OnItemAdded == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005513")]
		[Cpp2IlInjected.Address(RVA = "0x9524D0", Offset = "0x950ED0", VA = "0x1809524D0", Slot = "15")]
		void IPlayerEventDispatcher.RaiseItemRemoved(IInventory inventory, Item item, int amount, [Optional] ItemState state, InvActionType reason = InvActionType.None)
		{
			if (this.OnItemRemoved == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005516")]
		[Cpp2IlInjected.Address(RVA = "0x9524B0", Offset = "0x950EB0", VA = "0x1809524B0", Slot = "17")]
		void IPlayerEventDispatcher.RaiseItemMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action)
		{
			if (this.OnItemMoved == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005519")]
		[Cpp2IlInjected.Address(RVA = "0x9523F0", Offset = "0x950DF0", VA = "0x1809523F0", Slot = "18")]
		void IPlayerEventDispatcher.RaiseInventorySorted(ContainerInventory containerInventory)
		{
			this.OnInventorySorted?.Invoke(containerInventory);
		}

		[Cpp2IlInjected.Token(Token = "0x600551C")]
		[Cpp2IlInjected.Address(RVA = "0x952DB0", Offset = "0x9517B0", VA = "0x180952DB0", Slot = "113")]
		void IWorldEventDispatcher.RaiseMissionStepProgress(MissionSlotClass slotClass, int slotId)
		{
			this.OnMissionStepProgress?.Invoke(slotClass, slotId);
		}

		[Cpp2IlInjected.Token(Token = "0x600551F")]
		[Cpp2IlInjected.Address(RVA = "0x952D20", Offset = "0x951720", VA = "0x180952D20", Slot = "118")]
		void IWorldEventDispatcher.RaiseMissionItemAdded(string missionName, Dictionary<Item, int> items)
		{
			this.OnMissionItemAdded?.Invoke(missionName, (Dictionary<, >)(object)items);
		}

		[Cpp2IlInjected.Token(Token = "0x6005522")]
		[Cpp2IlInjected.Address(RVA = "0x952D40", Offset = "0x951740", VA = "0x180952D40", Slot = "119")]
		void IWorldEventDispatcher.RaiseMissionItemGiven(Item missionItem, Dictionary<(Item item, ItemState state), int> items, [Optional] Item? characterItem, bool keepitems = false)
		{
			if (this.OnMissionItemGiven == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005525")]
		[Cpp2IlInjected.Address(RVA = "0x952470", Offset = "0x950E70", VA = "0x180952470", Slot = "16")]
		void IPlayerEventDispatcher.RaiseItemConsumed(Item consumedItem, MultiItemInstance generatedItems)
		{
			this.OnItemConsumed?.Invoke(consumedItem, generatedItems);
		}

		[Cpp2IlInjected.Token(Token = "0x6005528")]
		[Cpp2IlInjected.Address(RVA = "0x952B40", Offset = "0x951540", VA = "0x180952B40", Slot = "64")]
		void IWorldEventDispatcher.RaiseGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic = false, [Optional] GridAddObjectOptions addObjectOptions)
		{
			if (this.OnGridChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600552B")]
		[Cpp2IlInjected.Address(RVA = "0x952870", Offset = "0x951270", VA = "0x180952870", Slot = "86")]
		void IWorldEventDispatcher.RaiseAvatarRemoveBlocker(IGrid grid, GridObject gridObject)
		{
			this.OnAvatarRemoveBlocker?.Invoke(grid, gridObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600552E")]
		[Cpp2IlInjected.Address(RVA = "0x952970", Offset = "0x951370", VA = "0x180952970", Slot = "107")]
		void IWorldEventDispatcher.RaiseCharacterPreferredItemDiscover(Character character, int preferredIndex, PreferredItemStatus newStatus)
		{
			this.OnCharacterPreferredItemDiscover?.Invoke(character, preferredIndex, newStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x6005531")]
		[Cpp2IlInjected.Address(RVA = "0x952930", Offset = "0x951330", VA = "0x180952930", Slot = "89")]
		void IWorldEventDispatcher.RaiseCharacterFriendshipChanged(Character character, int friendshipChange, int oldLevel, int newLevel, FriendshipSource friendshipSource)
		{
			if (this.OnCharacterFriendshipChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005534")]
		[Cpp2IlInjected.Address(RVA = "0x952950", Offset = "0x951350", VA = "0x180952950", Slot = "90")]
		void IWorldEventDispatcher.RaiseCharacterFriendshipLevelChanged(Item characterItem, int levelsGained)
		{
			this.OnCharacterFriendshipLevelChanged?.Invoke(characterItem, levelsGained);
		}

		[Cpp2IlInjected.Token(Token = "0x6005537")]
		[Cpp2IlInjected.Address(RVA = "0x952990", Offset = "0x951390", VA = "0x180952990", Slot = "76")]
		void IWorldEventDispatcher.RaiseCharacterProfessionChanged(Item characterItem)
		{
			this.OnCharacterProfessionChanged?.Invoke(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x600553A")]
		[Cpp2IlInjected.Address(RVA = "0x9520A0", Offset = "0x950AA0", VA = "0x1809520A0", Slot = "4")]
		void IPlayerEventDispatcher.RaiseCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_002d
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Currency)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				StoreFrontSpecificCurrencyItemData storeFrontSpecificCurrencyItemData = default(StoreFrontSpecificCurrencyItemData);
				if (storeFrontSpecificCurrencyItemData != null)
				{
					Item emulatedCurrencyItem = storeFrontSpecificCurrencyItemData.EmulatedCurrencyItem;
					bool flag = default(bool);
					if (flag)
					{
						Item emulatedCurrencyItem2 = storeFrontSpecificCurrencyItemData.EmulatedCurrencyItem;
					}
				}
			}
			if (this.OnCurrencyChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600553D")]
		[Cpp2IlInjected.Address(RVA = "0x952290", Offset = "0x950C90", VA = "0x180952290", Slot = "34")]
		void IPlayerEventDispatcher.RaiseCurrentSceneChanged(Item previousScene, Item currentScene)
		{
			this.OnCurrentSceneChanged?.Invoke(previousScene, currentScene);
		}

		[Cpp2IlInjected.Token(Token = "0x6005540")]
		[Cpp2IlInjected.Address(RVA = "0x952270", Offset = "0x950C70", VA = "0x180952270", Slot = "35")]
		void IPlayerEventDispatcher.RaiseCurrentSceneChangedAfterLoading(Item previousScene, Item currentScene)
		{
			this.OnCurrentSceneChangedAfterLoading?.Invoke(previousScene, currentScene);
		}

		[Cpp2IlInjected.Token(Token = "0x6005543")]
		[Cpp2IlInjected.Address(RVA = "0x952A70", Offset = "0x951470", VA = "0x180952A70", Slot = "104")]
		void IWorldEventDispatcher.RaiseDiscussionEnded(Item characterItem)
		{
			this.OnDiscussionEnded?.Invoke(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6005546")]
		[Cpp2IlInjected.Address(RVA = "0x952570", Offset = "0x950F70", VA = "0x180952570", Slot = "7")]
		void IPlayerEventDispatcher.RaiseManaChanged(int oldValue, int newValue, bool refill, [Optional] ManaSpentData spendActionData)
		{
			if (this.OnManaChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005549")]
		[Cpp2IlInjected.Address(RVA = "0x952590", Offset = "0x950F90", VA = "0x180952590", Slot = "8")]
		void IPlayerEventDispatcher.RaiseManaHasAlreadyMissedChanged()
		{
			this.OnManaHasAlreadyMissedChanged?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600554C")]
		[Cpp2IlInjected.Address(RVA = "0x952780", Offset = "0x951180", VA = "0x180952780", Slot = "5")]
		void IPlayerEventDispatcher.RaisePlayerXpGained(int gained, int oldLevel, int newLevel, FriendshipSource friendshipSource)
		{
			if (this.OnPlayerXpGained == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600554F")]
		[Cpp2IlInjected.Address(RVA = "0x952760", Offset = "0x951160", VA = "0x180952760", Slot = "6")]
		void IPlayerEventDispatcher.RaisePlayerLevelGained(int gainedLevels)
		{
			this.OnPlayerLevelGained?.Invoke(gainedLevels);
		}

		[Cpp2IlInjected.Token(Token = "0x6005552")]
		[Cpp2IlInjected.Address(RVA = "0x952B00", Offset = "0x951500", VA = "0x180952B00", Slot = "91")]
		void IWorldEventDispatcher.RaiseFriendshipAdded(AddedFriendshipSummary addedFriendshipSummary)
		{
			this.OnFriendshipAdded?.Invoke(addedFriendshipSummary);
		}

		[Cpp2IlInjected.Token(Token = "0x6005555")]
		[Cpp2IlInjected.Address(RVA = "0x9529F0", Offset = "0x9513F0", VA = "0x1809529F0", Slot = "73")]
		void IWorldEventDispatcher.RaiseCharacterUnlock(Item item)
		{
			this.OnCharacterUnlocked?.Invoke(item);
		}

		[Cpp2IlInjected.Token(Token = "0x6005558")]
		[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x9513D0", VA = "0x1809529D0", Slot = "74")]
		void IWorldEventDispatcher.RaiseCharacterStateChange(Item item, Character.Types.CharacterStatus status, CharacterChangeStatusReason reason)
		{
			this.OnCharacterStateChange?.Invoke(item, status, reason);
		}

		[Cpp2IlInjected.Token(Token = "0x600555B")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x9513B0", VA = "0x1809529B0", Slot = "75")]
		void IWorldEventDispatcher.RaiseCharacterSkinChanged(Item characterItem, Item skinItem, bool automatic)
		{
			this.OnCharacterSkinChanged?.Invoke(characterItem, skinItem, automatic);
		}

		[Cpp2IlInjected.Token(Token = "0x600555E")]
		[Cpp2IlInjected.Address(RVA = "0x952C60", Offset = "0x951660", VA = "0x180952C60", Slot = "122")]
		void IWorldEventDispatcher.RaiseMegaEventStarted(bool start, DateTime startTime, DateTime endTime, string name)
		{
			if (this.OnMegaEventStarted == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005561")]
		[Cpp2IlInjected.Address(RVA = "0x952C40", Offset = "0x951640", VA = "0x180952C40", Slot = "123")]
		void IWorldEventDispatcher.RaiseMegaEventReady()
		{
			this.OnMegaEventReady?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6005564")]
		[Cpp2IlInjected.Address(RVA = "0x952C80", Offset = "0x951680", VA = "0x180952C80", Slot = "124")]
		void IWorldEventDispatcher.RaiseMegaEventStopped()
		{
			this.OnMegaEventStopped?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6005567")]
		[Cpp2IlInjected.Address(RVA = "0x952C20", Offset = "0x951620", VA = "0x180952C20", Slot = "125")]
		void IWorldEventDispatcher.RaiseMegaEventOver()
		{
			this.OnMegaEventOver?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600556A")]
		[Cpp2IlInjected.Address(RVA = "0x952600", Offset = "0x951000", VA = "0x180952600", Slot = "55")]
		void IPlayerEventDispatcher.RaiseMiniEventStarted(bool start, string name, DateTime endDate)
		{
			this.OnMiniEventStarted?.Invoke(start, name, endDate);
		}

		[Cpp2IlInjected.Token(Token = "0x600556D")]
		[Cpp2IlInjected.Address(RVA = "0x952620", Offset = "0x951020", VA = "0x180952620", Slot = "56")]
		void IPlayerEventDispatcher.RaiseMiniEventStopped(string name)
		{
			this.OnMiniEventStopped?.Invoke(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6005570")]
		[Cpp2IlInjected.Address(RVA = "0x952AB0", Offset = "0x9514B0", VA = "0x180952AB0", Slot = "120")]
		void IWorldEventDispatcher.RaiseEventStarted(List<Item> characters)
		{
			this.OnEventStarted?.Invoke((List<>)(object)characters);
		}

		[Cpp2IlInjected.Token(Token = "0x6005573")]
		[Cpp2IlInjected.Address(RVA = "0x952A90", Offset = "0x951490", VA = "0x180952A90", Slot = "121")]
		void IWorldEventDispatcher.RaiseEventEnded(List<Item> characters)
		{
			this.OnEventEnded?.Invoke((List<>)(object)characters);
		}

		[Cpp2IlInjected.Token(Token = "0x6005576")]
		[Cpp2IlInjected.Address(RVA = "0x952ED0", Offset = "0x9518D0", VA = "0x180952ED0", Slot = "105")]
		void IWorldEventDispatcher.RaiseRaiseBringItemPreGifted(MissionSubStep subStep)
		{
			this.OnRaiseBringItemPreGifted?.Invoke(subStep);
		}

		[Cpp2IlInjected.Token(Token = "0x6005579")]
		[Cpp2IlInjected.Address(RVA = "0x952B70", Offset = "0x951570", VA = "0x180952B70", Slot = "106")]
		void IWorldEventDispatcher.RaiseItemsGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool alreadyGifted = false)
		{
			if (this.OnItemsGivenToCharacter == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600557C")]
		[Cpp2IlInjected.Address(RVA = "0x952B20", Offset = "0x951520", VA = "0x180952B20", Slot = "79")]
		void IWorldEventDispatcher.RaiseGardeningEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			if (this.OnGardeningEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600557F")]
		[Cpp2IlInjected.Address(RVA = "0x952AD0", Offset = "0x9514D0", VA = "0x180952AD0", Slot = "84")]
		void IWorldEventDispatcher.RaiseFlowerEvent(IGrid grid, GridObject gridObject, FlowerOperation operation, bool automatic, bool wasDry)
		{
			if (this.OnFlowerEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005582")]
		[Cpp2IlInjected.Address(RVA = "0x952D90", Offset = "0x951790", VA = "0x180952D90", Slot = "116")]
		void IWorldEventDispatcher.RaiseMissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason = SlotUpdatedReason.AnyChanges, [Optional] List<AnyReward> rewards)
		{
			if (this.OnMissionSlotUpdated == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005585")]
		[Cpp2IlInjected.Address(RVA = "0x952D00", Offset = "0x951700", VA = "0x180952D00", Slot = "114")]
		void IWorldEventDispatcher.RaiseMissionCurrentStepChanged(MissionSlotClass slotClass, int slotId, int previousStepIndex, int currentStepIndex)
		{
			if (this.OnMissionCurrentStepChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005588")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9517D0", VA = "0x180952DD0", Slot = "115")]
		void IWorldEventDispatcher.RaiseMissionStepStatusChanged(MissionSlotClass slotClass, int slotId, int stepIndex, MissionStepStatus previousStatus, MissionStepStatus newStatus)
		{
			if (this.OnMissionStepStatusChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600558B")]
		[Cpp2IlInjected.Address(RVA = "0x952D70", Offset = "0x951770", VA = "0x180952D70", Slot = "117")]
		void IWorldEventDispatcher.RaiseMissionObjectiveStatusChanged(MissionObjective obj, MissionStepStatus previousStatus, MissionStepStatus newStatus)
		{
			this.OnMissionObjectiveStatusChanged?.Invoke(obj, previousStatus, newStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x600558E")]
		[Cpp2IlInjected.Address(RVA = "0x952850", Offset = "0x951250", VA = "0x180952850", Slot = "46")]
		void IPlayerEventDispatcher.RaiseTrackedMissionChanged(Item missionItem)
		{
			this.OnTrackedMissionChanged?.Invoke(missionItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6005591")]
		[Cpp2IlInjected.Address(RVA = "0x952DF0", Offset = "0x9517F0", VA = "0x180952DF0", Slot = "87")]
		void IWorldEventDispatcher.RaisePendingFishAdded(uint pendingFishID, PendingFish pendingFish)
		{
			this.OnPendingFishAdded?.Invoke(pendingFishID, pendingFish);
		}

		[Cpp2IlInjected.Token(Token = "0x6005594")]
		[Cpp2IlInjected.Address(RVA = "0x952E10", Offset = "0x951810", VA = "0x180952E10", Slot = "88")]
		void IWorldEventDispatcher.RaisePendingFishRemoved(uint pendingFishID)
		{
			this.OnPendingFishRemoved?.Invoke(pendingFishID);
		}

		[Cpp2IlInjected.Token(Token = "0x6005597")]
		[Cpp2IlInjected.Address(RVA = "0x952350", Offset = "0x950D50", VA = "0x180952350", Slot = "23")]
		void IPlayerEventDispatcher.RaiseFishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, [Optional] int? criticalSuccessMinigameID)
		{
			if (this.OnFishingResultReceived == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600559A")]
		[Cpp2IlInjected.Address(RVA = "0x952F30", Offset = "0x951930", VA = "0x180952F30", Slot = "100")]
		void IWorldEventDispatcher.RaiseRecurringEventRescheduled(uint recurringEventID)
		{
			this.OnRecurringEventRescheduled?.Invoke(recurringEventID);
		}

		[Cpp2IlInjected.Token(Token = "0x600559D")]
		[Cpp2IlInjected.Address(RVA = "0x952F10", Offset = "0x951910", VA = "0x180952F10", Slot = "101")]
		void IWorldEventDispatcher.RaiseRecurringEventRemoved(uint recurringEventID)
		{
			this.OnRecurringEventRemoved?.Invoke(recurringEventID);
		}

		[Cpp2IlInjected.Token(Token = "0x60055A0")]
		[Cpp2IlInjected.Address(RVA = "0x952FB0", Offset = "0x9519B0", VA = "0x180952FB0", Slot = "97")]
		void IWorldEventDispatcher.RaiseShopItemsRefreshed(string shopName, Item item, [Optional] CurrencyCost refreshCost, bool isFreeRefresh = false)
		{
			if (this.OnShopItemsRefreshed == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60055A3")]
		[Cpp2IlInjected.Address(RVA = "0x953000", Offset = "0x951A00", VA = "0x180953000", Slot = "98")]
		void IWorldEventDispatcher.RaiseStoreRefreshed(Item buildingItem, bool isFullRefresh)
		{
			this.OnStoreRefreshed?.Invoke(buildingItem, isFullRefresh);
		}

		[Cpp2IlInjected.Token(Token = "0x60055A6")]
		[Cpp2IlInjected.Address(RVA = "0x952FE0", Offset = "0x9519E0", VA = "0x180952FE0", Slot = "99")]
		void IWorldEventDispatcher.RaiseStoreItemBought(Item building, Item item, int displayIdx)
		{
			this.OnStoreItemBought?.Invoke(building, item, displayIdx);
		}

		[Cpp2IlInjected.Token(Token = "0x60055A9")]
		[Cpp2IlInjected.Address(RVA = "0x9527C0", Offset = "0x9511C0", VA = "0x1809527C0", Slot = "36")]
		void IPlayerEventDispatcher.RaiseShopItemBought(string shopName, Item item, int amount, CurrencyCost cost, bool isDelivery = false)
		{
			if (this.OnShopItemBought == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60055AC")]
		[Cpp2IlInjected.Address(RVA = "0x9524F0", Offset = "0x950EF0", VA = "0x1809524F0", Slot = "38")]
		void IPlayerEventDispatcher.RaiseItemSold(string shopName, Item item, int amount, CurrencyCost cost)
		{
			if (this.OnItemsSold == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60055AF")]
		[Cpp2IlInjected.Address(RVA = "0x9527F0", Offset = "0x9511F0", VA = "0x1809527F0", Slot = "37")]
		void IPlayerEventDispatcher.RaiseShopItemsSold(string shopName, IInventory inventory, IEnumerable<ItemInstance> items, IEnumerable<CurrencyCost> costs)
		{
			if (this.OnShopItemsSold == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60055B2")]
		[Cpp2IlInjected.Address(RVA = "0x9528B0", Offset = "0x9512B0", VA = "0x1809528B0", Slot = "65")]
		void IWorldEventDispatcher.RaiseBuildingUnlocked(Item item, [Optional] List<CurrencyCost> costs)
		{
			this.OnBuildingUnlocked?.Invoke(item, (List<>)(object)costs);
		}

		[Cpp2IlInjected.Token(Token = "0x60055B5")]
		[Cpp2IlInjected.Address(RVA = "0x952890", Offset = "0x951290", VA = "0x180952890", Slot = "66")]
		void IWorldEventDispatcher.RaiseBuildingBuilt(Item item)
		{
			this.OnBuildingBuilt?.Invoke(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60055B8")]
		[Cpp2IlInjected.Address(RVA = "0x9525B0", Offset = "0x950FB0", VA = "0x1809525B0", Slot = "25")]
		void IPlayerEventDispatcher.RaiseMealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene)
		{
			if (this.OnMealCooked == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60055BB")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x9511A0", VA = "0x1809527A0", Slot = "20")]
		void IPlayerEventDispatcher.RaiseRecipeAdded(Item recipeItem, InvActionType reason = InvActionType.None)
		{
			this.OnRecipeAdded?.Invoke(recipeItem, reason);
		}

		[Cpp2IlInjected.Token(Token = "0x60055BE")]
		[Cpp2IlInjected.Address(RVA = "0x952F50", Offset = "0x951950", VA = "0x180952F50", Slot = "92")]
		void IWorldEventDispatcher.RaiseRestaurantOrderFulfilled(CharacterRestaurantOrder order, ItemWithState mealServed)
		{
			this.OnRestaurantOrderFulfilled?.Invoke(order, mealServed);
		}

		[Cpp2IlInjected.Token(Token = "0x60055C1")]
		[Cpp2IlInjected.Address(RVA = "0x952700", Offset = "0x951100", VA = "0x180952700", Slot = "9")]
		void IPlayerEventDispatcher.RaisePlayerBuffAdded(BuffOrigin buffOrigin, BuffType buffType, int percentageEffect)
		{
			this.OnPlayerBuffAdded?.Invoke(buffOrigin, buffType, percentageEffect);
		}

		[Cpp2IlInjected.Token(Token = "0x60055C4")]
		[Cpp2IlInjected.Address(RVA = "0x952740", Offset = "0x951140", VA = "0x180952740", Slot = "11")]
		void IPlayerEventDispatcher.RaisePlayerBuffUpdated(BuffOrigin buffOrigin, BuffType buffType)
		{
			this.OnPlayerBuffUpdated?.Invoke(buffOrigin, buffType);
		}

		[Cpp2IlInjected.Token(Token = "0x60055C7")]
		[Cpp2IlInjected.Address(RVA = "0x952720", Offset = "0x951120", VA = "0x180952720", Slot = "10")]
		void IPlayerEventDispatcher.RaisePlayerBuffRemoved(BuffOrigin buffOrigin, BuffType buffType)
		{
			this.OnPlayerBuffRemoved?.Invoke(buffOrigin, buffType);
		}

		[Cpp2IlInjected.Token(Token = "0x60055CA")]
		[Cpp2IlInjected.Address(RVA = "0x953040", Offset = "0x951A40", VA = "0x180953040", Slot = "85")]
		void IWorldEventDispatcher.RaiseWeatherChanged(string oldWeather, string newWeather)
		{
			this.OnWeatherChanged?.Invoke(oldWeather, newWeather);
		}

		[Cpp2IlInjected.Token(Token = "0x60055CD")]
		[Cpp2IlInjected.Address(RVA = "0x953020", Offset = "0x951A20", VA = "0x180953020", Slot = "102")]
		void IWorldEventDispatcher.RaiseVillageAreaUnlocked(VillageAreaType areaType, [Optional] List<CurrencyCost> costs)
		{
			this.OnVillageAreaUnlocked?.Invoke(areaType, (List<>)(object)costs);
		}

		[Cpp2IlInjected.Token(Token = "0x60055D0")]
		[Cpp2IlInjected.Address(RVA = "0x9532A0", Offset = "0x951CA0", VA = "0x1809532A0")]
		internal void RaiseProfileConflicted(CallContext context, bool beforeRpc, Profile clientProfile, Profile serverProfile)
		{
			if (this.OnProfileConflicted == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60055D3")]
		[Cpp2IlInjected.Address(RVA = "0x953320", Offset = "0x951D20", VA = "0x180953320")]
		internal void RaiseTutorialTriggered(List<int> tutorialIds)
		{
			this.OnTutorialTriggered?.Invoke((List<>)(object)tutorialIds);
		}

		[Cpp2IlInjected.Token(Token = "0x60055D6")]
		[Cpp2IlInjected.Address(RVA = "0x953300", Offset = "0x951D00", VA = "0x180953300")]
		internal void RaiseTutorialEnded(bool skipped)
		{
			this.OnTutorialEnded?.Invoke(skipped);
		}

		[Cpp2IlInjected.Token(Token = "0x60055D9")]
		[Cpp2IlInjected.Address(RVA = "0x9530A0", Offset = "0x951AA0", VA = "0x1809530A0")]
		internal void RaiseBundleTriggered(List<string> bundleIds)
		{
			this.OnBundleTriggered?.Invoke((List<>)(object)bundleIds);
		}

		[Cpp2IlInjected.Token(Token = "0x60055DC")]
		[Cpp2IlInjected.Address(RVA = "0x9522B0", Offset = "0x950CB0", VA = "0x1809522B0", Slot = "52")]
		void IPlayerEventDispatcher.RaiseDebugSkippedTimeChanged(TimeSpan skippedTime)
		{
			this.OnDebugSkippedTimeChanged?.Invoke(skippedTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60055DF")]
		[Cpp2IlInjected.Address(RVA = "0x951F50", Offset = "0x950950", VA = "0x180951F50", Slot = "53")]
		void IPlayerEventDispatcher.RaiseAvatarCustomizationChanged(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures)
		{
			this.OnAvatarCustomizationChanged?.Invoke(success, (List<>)(object)newEquippedClothes, (List<>)(object)newEquippedFeatures);
		}

		[Cpp2IlInjected.Token(Token = "0x60055E2")]
		[Cpp2IlInjected.Address(RVA = "0x951FD0", Offset = "0x9509D0", VA = "0x180951FD0", Slot = "54")]
		void IPlayerEventDispatcher.RaiseClothingDesignSaved(Item clothingItem, int nbChanges)
		{
			this.OnClothingDesignSaved?.Invoke(clothingItem, nbChanges);
		}

		[Cpp2IlInjected.Token(Token = "0x60055E5")]
		[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951B40", VA = "0x180953140")]
		[AsyncStateMachine(typeof(_003CRaiseIAPBuy_003Ed__379))]
		internal Task<CRMBuyResult> RaiseIAPBuy(string productId, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CRMBuyResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60055E8")]
		[Cpp2IlInjected.Address(RVA = "0x9523D0", Offset = "0x950DD0", VA = "0x1809523D0", Slot = "42")]
		void IPlayerEventDispatcher.RaiseIAPBought(BuyIAP.Types.Request request, CRMBuyResult result)
		{
			this.OnIAPBought?.Invoke(request, result);
		}

		[Cpp2IlInjected.Token(Token = "0x60055EB")]
		[Cpp2IlInjected.Address(RVA = "0x952660", Offset = "0x951060", VA = "0x180952660", Slot = "39")]
		void IPlayerEventDispatcher.RaiseOfflineBought(BuyOffline.Types.Request request, CRMBuyResult result)
		{
			this.OnOfflineBought?.Invoke(request, result);
		}

		[Cpp2IlInjected.Token(Token = "0x60055EE")]
		[Cpp2IlInjected.Address(RVA = "0x9530E0", Offset = "0x951AE0", VA = "0x1809530E0")]
		internal void RaiseCrmRefreshed(string crmData)
		{
			this.OnCrmRefreshed?.Invoke(crmData);
		}

		[Cpp2IlInjected.Token(Token = "0x60055F1")]
		[Cpp2IlInjected.Address(RVA = "0x9532C0", Offset = "0x951CC0", VA = "0x1809532C0")]
		internal void RaiseSemRefreshed(string semData)
		{
			this.OnSemRefreshed?.Invoke(semData);
		}

		[Cpp2IlInjected.Token(Token = "0x60055F4")]
		[Cpp2IlInjected.Address(RVA = "0x952390", Offset = "0x950D90", VA = "0x180952390", Slot = "48")]
		void IPlayerEventDispatcher.RaiseFtueEventComplete(Item ftueItem)
		{
			this.OnFtueEventComplete?.Invoke(ftueItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60055F7")]
		[Cpp2IlInjected.Address(RVA = "0x952550", Offset = "0x950F50", VA = "0x180952550", Slot = "40")]
		void IPlayerEventDispatcher.RaiseLootPresentConsumed(MultiItemInstance rewards, int boxIndex)
		{
			this.OnLootPresentConsumed?.Invoke(rewards, boxIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60055FA")]
		[Cpp2IlInjected.Address(RVA = "0x952530", Offset = "0x950F30", VA = "0x180952530", Slot = "41")]
		void IPlayerEventDispatcher.RaiseLootPresentCollected()
		{
			this.OnLootPresentCollected?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60055FD")]
		[Cpp2IlInjected.Address(RVA = "0x9526E0", Offset = "0x9510E0", VA = "0x1809526E0", Slot = "49")]
		void IPlayerEventDispatcher.RaisePictureTaken(PhotoModeType photoMode, List<int> itemIds, List<int> gardenItemIds, SceneType sceneType)
		{
			if (this.OnPictureTaken == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005600")]
		[Cpp2IlInjected.Address(RVA = "0x952490", Offset = "0x950E90", VA = "0x180952490", Slot = "50")]
		void IPlayerEventDispatcher.RaiseItemInteraction(Item item)
		{
			this.OnItemInteraction?.Invoke(item);
		}

		[Cpp2IlInjected.Token(Token = "0x6005603")]
		[Cpp2IlInjected.Address(RVA = "0x952060", Offset = "0x950A60", VA = "0x180952060", Slot = "43")]
		void IPlayerEventDispatcher.RaiseCritterFed(Critter critter, FeedCritterDetails details)
		{
			this.OnCritterFed?.Invoke(critter, details);
		}

		[Cpp2IlInjected.Token(Token = "0x6005606")]
		[Cpp2IlInjected.Address(RVA = "0x952020", Offset = "0x950A20", VA = "0x180952020", Slot = "45")]
		void IPlayerEventDispatcher.RaiseCompanionPetted(Item companionItem)
		{
			this.OnCompanionPetted?.Invoke(companionItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6005609")]
		[Cpp2IlInjected.Address(RVA = "0x952080", Offset = "0x950A80", VA = "0x180952080", Slot = "44")]
		void IPlayerEventDispatcher.RaiseCritterUnlocked(Critter critter)
		{
			this.OnCritterUnlocked?.Invoke(critter);
		}

		[Cpp2IlInjected.Token(Token = "0x600560C")]
		[Cpp2IlInjected.Address(RVA = "0x9525E0", Offset = "0x950FE0", VA = "0x1809525E0", Slot = "19")]
		void IPlayerEventDispatcher.RaiseMemoryShardAdded(Item memoryShardItem, int memoryShardIndex, AddDetail detail)
		{
			this.OnMemoryShardAdded?.Invoke(memoryShardItem, memoryShardIndex, detail);
		}

		[Cpp2IlInjected.Token(Token = "0x600560F")]
		[Cpp2IlInjected.Address(RVA = "0x9526C0", Offset = "0x9510C0", VA = "0x1809526C0", Slot = "21")]
		void IPlayerEventDispatcher.RaisePetUnlocked(Item petItem, AddDetail detail)
		{
			this.OnPetUnlocked?.Invoke(petItem, detail);
		}

		[Cpp2IlInjected.Token(Token = "0x6005612")]
		[Cpp2IlInjected.Address(RVA = "0x952250", Offset = "0x950C50", VA = "0x180952250", Slot = "22")]
		void IPlayerEventDispatcher.RaiseCurrentPetChanged(Item previousPet, Item newPet)
		{
			this.OnCurrentPetChanged?.Invoke(previousPet, newPet);
		}

		[Cpp2IlInjected.Token(Token = "0x6005615")]
		[Cpp2IlInjected.Address(RVA = "0x952910", Offset = "0x951310", VA = "0x180952910", Slot = "82")]
		void IWorldEventDispatcher.RaiseBurningStateStarted(BurningState.IBurningState burningState)
		{
			this.OnBurningStateStarted?.Invoke(burningState);
		}

		[Cpp2IlInjected.Token(Token = "0x6005618")]
		[Cpp2IlInjected.Address(RVA = "0x952A10", Offset = "0x951410", VA = "0x180952A10", Slot = "81")]
		void IWorldEventDispatcher.RaiseCollectBurningState(BurningState.IBurningState burningState, ItemInstance item)
		{
			this.OnBurningStateCollected?.Invoke(burningState, item);
		}

		[Cpp2IlInjected.Token(Token = "0x600561B")]
		[Cpp2IlInjected.Address(RVA = "0x9528F0", Offset = "0x9512F0", VA = "0x1809528F0", Slot = "83")]
		void IWorldEventDispatcher.RaiseBurningStateEnded(BurningState.IBurningState burningState)
		{
			this.OnBurningStateEnded?.Invoke(burningState);
		}

		[Cpp2IlInjected.Token(Token = "0x600561E")]
		[Cpp2IlInjected.Address(RVA = "0x952430", Offset = "0x950E30", VA = "0x180952430", Slot = "31")]
		void IPlayerEventDispatcher.RaiseItemCollectMinigameAdded(Profile.ItemCollectMinigame minigame)
		{
			this.OnItemCollectMinigameAdded?.Invoke(minigame);
		}

		[Cpp2IlInjected.Token(Token = "0x6005621")]
		[Cpp2IlInjected.Address(RVA = "0x952450", Offset = "0x950E50", VA = "0x180952450", Slot = "32")]
		void IPlayerEventDispatcher.RaiseItemCollectMinigameEnded(Profile.ItemCollectMinigame minigame)
		{
			this.OnItemCollectMinigameEnded?.Invoke(minigame);
		}

		[Cpp2IlInjected.Token(Token = "0x6005624")]
		[Cpp2IlInjected.Address(RVA = "0x952640", Offset = "0x951040", VA = "0x180952640", Slot = "33")]
		void IPlayerEventDispatcher.RaiseMinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
		{
			this.OnMinigameItemsCollected?.Invoke(minigame, items);
		}

		[Cpp2IlInjected.Token(Token = "0x6005627")]
		[Cpp2IlInjected.Address(RVA = "0x953060", Offset = "0x951A60", VA = "0x180953060", Slot = "80")]
		void IWorldEventDispatcher.RaiseWeedPulled(WeedPullEvent pullweedEvent)
		{
			this.OnWeedPulled?.Invoke(pullweedEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600562A")]
		[Cpp2IlInjected.Address(RVA = "0x952E30", Offset = "0x951830", VA = "0x180952E30", Slot = "70")]
		void IWorldEventDispatcher.RaisePlayerHouseFloorAdded([Optional] CurrencyCost cost)
		{
			this.OnPlayerHouseFloorAdded?.Invoke(cost);
		}

		[Cpp2IlInjected.Token(Token = "0x600562D")]
		[Cpp2IlInjected.Address(RVA = "0x952E70", Offset = "0x951870", VA = "0x180952E70", Slot = "69")]
		void IWorldEventDispatcher.RaisePlayerHouseRoomExpanded(int sizeX, int sizeY, int floorIndex, House.Types.RoomSlot roomSlot, [Optional] List<CurrencyCost> cost)
		{
			if (this.OnPlayerHouseRoomExpanded == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005630")]
		[Cpp2IlInjected.Address(RVA = "0x952E50", Offset = "0x951850", VA = "0x180952E50", Slot = "68")]
		void IWorldEventDispatcher.RaisePlayerHouseRoomAdded(int floorIndex, House.Types.RoomSlot roomSlot, [Optional] List<CurrencyCost> cost)
		{
			this.OnPlayerHouseRoomAdded?.Invoke(floorIndex, roomSlot, (List<>)(object)cost);
		}

		[Cpp2IlInjected.Token(Token = "0x6005633")]
		[Cpp2IlInjected.Address(RVA = "0x952E90", Offset = "0x951890", VA = "0x180952E90", Slot = "71")]
		void IWorldEventDispatcher.RaisePlayerHouseRoomFlooringChanged(int floorIndex, House.Types.RoomSlot roomSlot, Item flooringItem)
		{
			this.OnPlayerHouseRoomFlooringChanged?.Invoke(floorIndex, roomSlot, flooringItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6005636")]
		[Cpp2IlInjected.Address(RVA = "0x952EB0", Offset = "0x9518B0", VA = "0x180952EB0", Slot = "72")]
		void IWorldEventDispatcher.RaisePlayerHouseRoomWallpaperChanged(int floorIndex, House.Types.RoomSlot roomSlot, House.Types.WallPosition? wallPosition, Item wallpaperItem)
		{
			if (this.OnPlayerHouseRoomWallpaperChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005639")]
		[Cpp2IlInjected.Address(RVA = "0x952A50", Offset = "0x951450", VA = "0x180952A50", Slot = "112")]
		void IWorldEventDispatcher.RaiseDialogueFlagChange(Item flagItem, bool active)
		{
			this.OnDialogueFlagChange?.Invoke(flagItem, active);
		}

		[Cpp2IlInjected.Token(Token = "0x600563C")]
		[Cpp2IlInjected.Address(RVA = "0x952F90", Offset = "0x951990", VA = "0x180952F90", Slot = "77")]
		void IWorldEventDispatcher.RaiseSecretCharacterVisitStarted(Character character)
		{
			this.OnSecretCharacterVisitStarted?.Invoke(character);
		}

		[Cpp2IlInjected.Token(Token = "0x600563F")]
		[Cpp2IlInjected.Address(RVA = "0x9522F0", Offset = "0x950CF0", VA = "0x1809522F0", Slot = "27")]
		void IPlayerEventDispatcher.RaiseDutySlotUpdated(int slotID, bool generated = false)
		{
			this.OnDutySlotUpdated?.Invoke(slotID, generated);
		}

		[Cpp2IlInjected.Token(Token = "0x6005642")]
		[Cpp2IlInjected.Address(RVA = "0x951FF0", Offset = "0x9509F0", VA = "0x180951FF0", Slot = "28")]
		void IPlayerEventDispatcher.RaiseCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromConsumable = false)
		{
			if (this.OnCollectionSetUpdated == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005645")]
		[Cpp2IlInjected.Address(RVA = "0x9523B0", Offset = "0x950DB0", VA = "0x1809523B0", Slot = "47")]
		void IPlayerEventDispatcher.RaiseFtueEventStart(Item ftueItem)
		{
			this.OnFtueEventStart?.Invoke(ftueItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6005648")]
		[Cpp2IlInjected.Address(RVA = "0x951F30", Offset = "0x950930", VA = "0x180951F30", Slot = "30")]
		void IPlayerEventDispatcher.RaiseAchievementSetUpdated(Item achievementItem, bool milestonePassed = false)
		{
			this.OnAchievementSetUpdated?.Invoke(achievementItem, milestonePassed);
		}

		[Cpp2IlInjected.Token(Token = "0x600564B")]
		[Cpp2IlInjected.Address(RVA = "0x9522D0", Offset = "0x950CD0", VA = "0x1809522D0", Slot = "29")]
		void IPlayerEventDispatcher.RaiseDutyAchRewardCollected(List<AnyReward> rewards, DutyAchItemType dutyAchtype, Item achievementItem)
		{
			this.OnDutyAchRewardCollected?.Invoke((List<>)(object)rewards, dutyAchtype, achievementItem);
		}

		[Cpp2IlInjected.Token(Token = "0x600564E")]
		[Cpp2IlInjected.Address(RVA = "0x9530C0", Offset = "0x951AC0", VA = "0x1809530C0")]
		internal void RaiseCollectionRewardCollected(CurrencyCost reward, string collectionName)
		{
			this.OnCollectionRewardCollected?.Invoke(reward, collectionName);
		}

		[Cpp2IlInjected.Token(Token = "0x6005651")]
		[Cpp2IlInjected.Address(RVA = "0x9528D0", Offset = "0x9512D0", VA = "0x1809528D0", Slot = "67")]
		void IWorldEventDispatcher.RaiseBuildingUpgraded(GridObject gridObj, UpgradeData upData)
		{
			this.OnBuidingUpgraded?.Invoke(gridObj, upData);
		}

		[Cpp2IlInjected.Token(Token = "0x6005654")]
		[Cpp2IlInjected.Address(RVA = "0x952EF0", Offset = "0x9518F0", VA = "0x180952EF0", Slot = "103")]
		void IWorldEventDispatcher.RaiseRealmUnlocked(string realmID, bool unlockedByFlag)
		{
			this.OnRealmUnlocked?.Invoke(realmID, unlockedByFlag);
		}

		[Cpp2IlInjected.Token(Token = "0x6005657")]
		[Cpp2IlInjected.Address(RVA = "0x952330", Offset = "0x950D30", VA = "0x180952330", Slot = "24")]
		void IPlayerEventDispatcher.RaiseFishCollected(List<AnyReward> rewards)
		{
			this.OnFishCollected?.Invoke((List<>)(object)rewards);
		}

		[Cpp2IlInjected.Token(Token = "0x600565A")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x951970", VA = "0x180952F70", Slot = "78")]
		void IWorldEventDispatcher.RaiseRewardSpawnOnGrid()
		{
			this.OnRewardSpawnOnGrid?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600565D")]
		[Cpp2IlInjected.Address(RVA = "0x952A30", Offset = "0x951430", VA = "0x180952A30", Slot = "96")]
		void IWorldEventDispatcher.RaiseDailyResetExecuted()
		{
			this.OnDailyResetExecuted?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6005660")]
		[Cpp2IlInjected.Address(RVA = "0x952CE0", Offset = "0x9516E0", VA = "0x180952CE0", Slot = "93")]
		void IWorldEventDispatcher.RaiseMiningRockStateChanged(ActivityDataLocationFilter location, int index, MiningRock.StateOneofCase state)
		{
			this.OnMiningRockStateChanged?.Invoke(location, index, state);
		}

		[Cpp2IlInjected.Token(Token = "0x6005663")]
		[Cpp2IlInjected.Address(RVA = "0x952CC0", Offset = "0x9516C0", VA = "0x180952CC0", Slot = "94")]
		void IWorldEventDispatcher.RaiseMiningRockEmptied(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, [Optional] int? criticalSuccessMinigameID)
		{
			if (this.OnMiningRockEmptied == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005666")]
		[Cpp2IlInjected.Address(RVA = "0x952CA0", Offset = "0x9516A0", VA = "0x180952CA0", Slot = "95")]
		void IWorldEventDispatcher.RaiseMiningRockDamaged()
		{
			this.OnMiningRockDamaged?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6005669")]
		[Cpp2IlInjected.Address(RVA = "0x952040", Offset = "0x950A40", VA = "0x180952040", Slot = "26")]
		void IPlayerEventDispatcher.RaiseCraftingCompleted(Item craftingRecipeItem, int amountOfCraftingDone)
		{
			this.OnCraftingCompleted?.Invoke(craftingRecipeItem, amountOfCraftingDone);
		}

		[Cpp2IlInjected.Token(Token = "0x600566C")]
		[Cpp2IlInjected.Address(RVA = "0x952810", Offset = "0x951210", VA = "0x180952810", Slot = "12")]
		void IPlayerEventDispatcher.RaiseToolAdded(Item toolItem)
		{
			this.OnToolAdded?.Invoke(toolItem);
		}

		[Cpp2IlInjected.Token(Token = "0x600566F")]
		[Cpp2IlInjected.Address(RVA = "0x952830", Offset = "0x951230", VA = "0x180952830", Slot = "13")]
		void IPlayerEventDispatcher.RaiseToolUpgraded(Item toolItem, Item upgradeItem)
		{
			this.OnToolUpgraded?.Invoke(toolItem, upgradeItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6005672")]
		[Cpp2IlInjected.Address(RVA = "0x952BA0", Offset = "0x9515A0", VA = "0x180952BA0", Slot = "108")]
		void IWorldEventDispatcher.RaiseKeyholeItemAdded(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
			if (this.OnKeyholeItemAdded == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005675")]
		[Cpp2IlInjected.Address(RVA = "0x952BE0", Offset = "0x9515E0", VA = "0x180952BE0", Slot = "109")]
		void IWorldEventDispatcher.RaiseKeyholeItemRemoved(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
			if (this.OnKeyholeItemRemoved == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005678")]
		[Cpp2IlInjected.Address(RVA = "0x952BC0", Offset = "0x9515C0", VA = "0x180952BC0", Slot = "110")]
		void IWorldEventDispatcher.RaiseKeyholeItemMoved(Keyhole keyhole)
		{
			this.OnKeyholeItemMoved?.Invoke(keyhole);
		}

		[Cpp2IlInjected.Token(Token = "0x600567B")]
		[Cpp2IlInjected.Address(RVA = "0x952C00", Offset = "0x951600", VA = "0x180952C00", Slot = "111")]
		void IWorldEventDispatcher.RaiseKeyholeLevelCompleted(Keyhole keyhole, int levelCompleted)
		{
			this.OnKeyholeLevelCompleted?.Invoke(keyhole, levelCompleted);
		}

		[Cpp2IlInjected.Token(Token = "0x600567E")]
		[Cpp2IlInjected.Address(RVA = "0x953120", Offset = "0x951B20", VA = "0x180953120")]
		internal void RaiseHangoutGatherReward(ItemReward[] rewardItems)
		{
			this.OnHangoutGatherReward?.Invoke(rewardItems);
		}

		[Cpp2IlInjected.Token(Token = "0x6005681")]
		[Cpp2IlInjected.Address(RVA = "0x953100", Offset = "0x951B00", VA = "0x180953100")]
		internal void RaiseHangoutChanged(Character hangoutCharacter)
		{
			this.OnHangoutChanged?.Invoke(hangoutCharacter);
		}

		[Cpp2IlInjected.Token(Token = "0x6005684")]
		[Cpp2IlInjected.Address(RVA = "0x952510", Offset = "0x950F10", VA = "0x180952510", Slot = "57")]
		void IPlayerEventDispatcher.RaiseItemsSentToInbox(List<InboxItemReward> items, ItemsSentToInboxReason reason)
		{
			this.OnItemsSentToInbox?.Invoke((List<>)(object)items, reason);
		}

		[Cpp2IlInjected.Token(Token = "0x6005687")]
		[Cpp2IlInjected.Address(RVA = "0x951FB0", Offset = "0x9509B0", VA = "0x180951FB0", Slot = "58")]
		void IPlayerEventDispatcher.RaiseBattlePassTasksUpdate(Dictionary<string, BattlePassSeasonData> battlePassSeasons)
		{
			this.OnBattlePassTasksUpdate?.Invoke((Dictionary<, >)(object)battlePassSeasons);
		}

		[Cpp2IlInjected.Token(Token = "0x600568A")]
		[Cpp2IlInjected.Address(RVA = "0x951F90", Offset = "0x950990", VA = "0x180951F90", Slot = "59")]
		void IPlayerEventDispatcher.RaiseBattlePassTaskUpdate(string battlePassOnlineId, BattlePassTaskProgress taskProgress)
		{
			this.OnBattlePassTaskUpdate?.Invoke(battlePassOnlineId, taskProgress);
		}

		[Cpp2IlInjected.Token(Token = "0x600568D")]
		[Cpp2IlInjected.Address(RVA = "0x951F70", Offset = "0x950970", VA = "0x180951F70", Slot = "60")]
		void IPlayerEventDispatcher.RaiseBattlePassCurrencyChanged(int gained, InvActionType reason, BattlePassActionType action)
		{
			this.OnBattlePassCurrencyChanged?.Invoke(gained, reason, action);
		}

		[Cpp2IlInjected.Token(Token = "0x6005690")]
		[Cpp2IlInjected.Address(RVA = "0x952370", Offset = "0x950D70", VA = "0x180952370", Slot = "61")]
		void IPlayerEventDispatcher.RaiseFoundersPackClaimed(string foundersPackName)
		{
			this.OnFoundersPackClaimed?.Invoke(foundersPackName);
		}

		[Cpp2IlInjected.Token(Token = "0x6005693")]
		[Cpp2IlInjected.Address(RVA = "0x952680", Offset = "0x951080", VA = "0x180952680", Slot = "62")]
		void IPlayerEventDispatcher.RaiseOnlineBundlesUpdate(Dictionary<string, OnlineBundleData> bundles)
		{
			this.OnOnlineBundlesUpdate?.Invoke((Dictionary<, >)(object)bundles);
		}

		[Cpp2IlInjected.Token(Token = "0x6005696")]
		[Cpp2IlInjected.Address(RVA = "0x9526A0", Offset = "0x9510A0", VA = "0x1809526A0", Slot = "63")]
		void IPlayerEventDispatcher.RaiseOnlineStoresUpdate(Dictionary<string, OnlineStoreData> stores)
		{
			this.OnOnlineStoresUpdate?.Invoke((Dictionary<, >)(object)stores);
		}
	}
}
