using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Keyholes;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Meta.Duties;
using Meta.Grids;
using Meta.Missions;
using PlayFab.EconomyModels;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A83")]
	public class TrackingManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000A84")]
		private enum EarnedSource
		{
			[Cpp2IlInjected.Token(Token = "0x4002938")]
			RedeemMoonstonePack = 426349,
			[Cpp2IlInjected.Token(Token = "0x4002939")]
			Reward = 441587
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002930")]
		private Character HangingOutWithCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002931")]
		private int UI_INTERACTION_INTERVAL = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002933")]
		private List<TrackingConsumer> consumers = (List<TrackingConsumer>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002934")]
		private DateTime lastUIInteraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002935")]
		private Dictionary<string, UIInteractionData> uiInteractions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002936")]
		private ClientData clientData = new ClientData();

		[Cpp2IlInjected.Token(Token = "0x17000FA5")]
		public static TrackingManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6005B53")]
			[Cpp2IlInjected.Address(RVA = "0x79F6D0", Offset = "0x79E0D0", VA = "0x18079F6D0")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B54")]
			[Cpp2IlInjected.Address(RVA = "0x79F710", Offset = "0x79E110", VA = "0x18079F710")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF2")]
		[Cpp2IlInjected.Address(RVA = "0x79C7C0", Offset = "0x79B1C0", VA = "0x18079C7C0")]
		private void TrackGainXP(int xpGained, int oldLevel, int newLevel, FriendshipSource friendshipSource)
		{
			//Discarded unreachable code: IL_00aa, IL_00b6, IL_00bc, IL_00c2, IL_00c8
			//IL_004c: Expected I4, but got I8
			//IL_0055: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			if (oldLevel != newLevel)
			{
				TrackingRewards trackingRewards = new TrackingRewards();
				trackingRewards.rewardName = "PlayerLevelUpRewards";
				TrackingItem[] array = new TrackingItem[1];
				TrackingItem trackingItem = default(TrackingItem);
				trackingItem.itemAmount = xpGained;
				trackingItem.itemName = "XP";
				trackingItem.itemType = "XP";
				trackingItem.itemRarity = -1;
				int num = 0;
				trackingItem.ItemTraits = (Dictionary<string, string>)num;
				trackingItem.ItemTags = (Dictionary<TagItemType, string>)num;
				if (trackingItem == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[0] = trackingItem;
				trackingRewards.items = array;
				LevelUpEvent levelUpEvent = default(LevelUpEvent);
				levelUpEvent.ObjectName = "avatar";
				levelUpEvent.UserLevelBefore = oldLevel;
				levelUpEvent.UserLevelAfter = oldLevel;
				string sourceOfXP = levelUpEvent.ToString();
				LevelUpEvent levelUpEvent2 = levelUpEvent;
				levelUpEvent.SourceOfXP = sourceOfXP;
				levelUpEvent.Reward = trackingRewards;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF3")]
		[Cpp2IlInjected.Address(RVA = "0x79CDE0", Offset = "0x79B7E0", VA = "0x18079CDE0")]
		private void TrackLevelUpRewards(AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_0087
			//IL_0038: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			if (addedFriendshipSummary == null)
			{
				return;
			}
			MultiReward _003CPlayerLevelUpRewards_003Ek__BackingField = addedFriendshipSummary.PlayerLevelUpRewards;
			if (_003CPlayerLevelUpRewards_003Ek__BackingField != null)
			{
				RepeatedField<AnyReward> rewards_ = _003CPlayerLevelUpRewards_003Ek__BackingField.rewards_;
				if (rewards_ != null)
				{
					List<AnyReward> list = (List<AnyReward>)(object)Enumerable.ToList<AnyReward>((IEnumerable<>)(object)rewards_);
					int num = 0;
					this.TrackReceivedRewards((List<>)(object)list, "TrackLevelUpRewards", "player level up reward", (Nullable<>)num);
				}
			}
			int num2 = 0;
			MultiReward _003CCharacterLevelUpRewards_003Ek__BackingField = addedFriendshipSummary.CharacterLevelUpRewards;
			if (_003CCharacterLevelUpRewards_003Ek__BackingField != null)
			{
				RepeatedField<AnyReward> rewards_2 = _003CCharacterLevelUpRewards_003Ek__BackingField.rewards_;
				if (rewards_2 != null)
				{
					List<AnyReward> list2 = (List<AnyReward>)(object)Enumerable.ToList<AnyReward>((IEnumerable<>)(object)rewards_2);
					Item _003CCharacterItem_003Ek__BackingField = addedFriendshipSummary.CharacterItem;
					string text = $"{list2} level up reward";
					this.TrackReceivedRewards((List<>)(object)list2, "TrackFrienshipLevelUpRewards", text, (Nullable<>)num2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF4")]
		[Cpp2IlInjected.Address(RVA = "0x7952C0", Offset = "0x793CC0", VA = "0x1807952C0")]
		private void OnMissionItemAdded(string missionName, Dictionary<Item, int> items)
		{
			//Discarded unreachable code: IL_000d
			//IL_000c: Expected O, but got I4
			int num = 0;
			string text = default(string);
			this.TrackReceiveCollectQuestItem(missionName, (Dictionary<, >)(object)items, (Nullable<>)num, text);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF5")]
		[Cpp2IlInjected.Address(RVA = "0x79D370", Offset = "0x79BD70", VA = "0x18079D370")]
		private void TrackReceiveCollectQuestItem(string missionName, Item item, int amount, [Optional] Item? characterItem, [Optional] string source)
		{
			//Discarded unreachable code: IL_000c, IL_000d
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF6")]
		[Cpp2IlInjected.Address(RVA = "0x79D450", Offset = "0x79BE50", VA = "0x18079D450")]
		private void TrackReceiveCollectQuestItem(string missionName, Dictionary<Item, int> items, [Optional] Item? characterItem, [Optional] string source)
		{
			//Discarded unreachable code: IL_001b, IL_0021, IL_0027, IL_002d
			int num = 0;
			int num2 = 0;
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			bool flag = default(bool);
			if (flag)
			{
				RequestItemData requestItemData = default(RequestItemData);
				while (requestItemData == null)
				{
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF7")]
		[Cpp2IlInjected.Address(RVA = "0x79CB10", Offset = "0x79B510", VA = "0x18079CB10")]
		private void TrackGiveQuestItem(Item missionItem, Dictionary<(Item item, ItemState state), int> items, [Optional] Item? characterItem, bool keepitems = false)
		{
			//Discarded unreachable code: IL_001c, IL_0022, IL_0028
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			MissionItemData missionItemData = default(MissionItemData);
			string name_ = missionItemData.name_;
			this.TrackSpentItems(name_, (Dictionary<, >)(object)items, "TrackGiveQuestItem", (Nullable<>)characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF8")]
		[Cpp2IlInjected.Address(RVA = "0x7953D0", Offset = "0x793DD0", VA = "0x1807953D0")]
		private void OnMissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason, [Optional] List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_018b, IL_0191, IL_0197, IL_019d, IL_01a3, IL_01a9, IL_01af, IL_01b5, IL_01bb, IL_01c1, IL_01c7, IL_01cd
			//IL_001b: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_0115: Expected O, but got I4
			int num = 0;
			int ownerCharacter_ = missionData.ownerCharacter_;
			this.TrackReceivedRewards((List<>)num, "TrackReceiveQuestRewards", "mission reward", (Nullable<>)num);
			ProfileWorld world_ = clientData.profile.world_;
			MissionSlot missionSlot = default(MissionSlot);
			if (missionSlot == null)
			{
				return;
			}
			QuestsEvent questsEvent = new QuestsEvent(clientData);
			int ownerCharacter = missionData.OwnerCharacter;
			string questIssuerName = default(string);
			questsEvent.QuestIssuerName = questIssuerName;
			string text = (questsEvent.MissionName = missionData.name_);
			int num2 = ((questsEvent.IsTutorial = false) ? 1 : 0);
			int iD_ = missionData.iD_;
			string missionID = default(string);
			questsEvent.MissionID = missionID;
			MissionType type_ = missionData.type_;
			string missionType = ((Enum)type_).ToString();
			MissionType missionType2 = type_;
			questsEvent.MissionType = missionType;
			int num4 = (questsEvent.MissionIndexQuest = 0);
			int num5 = (questsEvent.MissionIndex = missionSlot.slotId_);
			string missionStatus = default(string);
			questsEvent.MissionStatus = missionStatus;
			MissionStep currentStep = missionSlot.CurrentStep;
			if (currentStep != null && (long)currentStep.Data != 0)
			{
				MissionStepData _003CData_003Ek__BackingField = missionSlot.CurrentStep.Data;
				int num6 = (questsEvent.StepId = _003CData_003Ek__BackingField.stepID_);
				MissionStepStatus status = missionSlot.CurrentStep.Status;
				string stepStatus = ((Enum)status).ToString();
				MissionStepStatus missionStepStatus = status;
				questsEvent.StepStatus = stepStatus;
				string text2 = (questsEvent.StepName = _003CData_003Ek__BackingField.stepName_);
				IEnumerable<MissionObjectiveData> allObjectives = (IEnumerable<MissionObjectiveData>)_003CData_003Ek__BackingField.get_AllObjectives();
				Func<MissionObjectiveData, MissionObjectiveData.CustomStepOneofCase> func = default(Func<MissionObjectiveData, MissionObjectiveData.CustomStepOneofCase>);
				if (_003C_003Ec._003C_003E9__6_0 == null)
				{
					func = (Func<MissionObjectiveData, MissionObjectiveData.CustomStepOneofCase>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjectiveData x) => x.customStepCase_));
				}
				IEnumerable<MissionObjectiveData> enumerable = (IEnumerable<MissionObjectiveData>)Enumerable.Select<MissionObjectiveData, MissionObjectiveData.CustomStepOneofCase>((IEnumerable<>)allObjectives, (Func<, >)(object)func);
				string text4 = (questsEvent.StepType = string.Join<MissionObjectiveData.CustomStepOneofCase>("; ", (IEnumerable<>)enumerable));
			}
			TrackEvent(questsEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF9")]
		[Cpp2IlInjected.Address(RVA = "0x791EB0", Offset = "0x7908B0", VA = "0x180791EB0")]
		private void OnDutyAchRewardsCollected(List<AnyReward> rewards, DutyAchItemType dutyAchType, Item achievementItem)
		{
			//Discarded unreachable code: IL_0019, IL_001f
			//IL_0018: Expected O, but got I4
			if (dutyAchType == DutyAchItemType.Achievement)
			{
			}
			int num = 0;
			this.TrackReceivedRewards((List<>)(object)rewards, "TrackDutyRewards", "Duty Reward", (Nullable<>)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AFA")]
		[Cpp2IlInjected.Address(RVA = "0x791280", Offset = "0x78FC80", VA = "0x180791280")]
		private void OnCollectionRewardCollected(CurrencyCost reward, string collectionName)
		{
			//Discarded unreachable code: IL_00e4, IL_00ea, IL_00f0, IL_00f6, IL_00fc
			//IL_008c: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			if (reward != null)
			{
				List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
				int amount_ = reward.amount_;
				ItemDatabase itemDatabase = ItemDatabase.Instance;
				Item item = reward.Item;
				TrackingVirtualCurrency trackingVirtualCurrency = new TrackingVirtualCurrency();
				trackingVirtualCurrency.virtualCurrencyAmount = amount_;
				IItemData virtualCurrencyName = default(IItemData);
				trackingVirtualCurrency.virtualCurrencyName = (string)(object)virtualCurrencyName;
				trackingVirtualCurrency.virtualCurrencyType = "GRIND";
				((List<T>)(object)list).Add((T)trackingVirtualCurrency);
				ClientData clientData = this.clientData;
				Character hangingOutWithCharacter = HangingOutWithCharacter;
				string transactionLocation = default(string);
				int addToItemsInBP = default(int);
				TransactionEvent transactionEvent = new TransactionEvent("CollectionRewardCollected", clientData, hangingOutWithCharacter, addToItemsInBP, transactionLocation);
				addToItemsInBP = 0;
				TrackingVirtualCurrency[] virtualCurrencies = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
				TrackingProducts trackingProducts = new TrackingProducts();
				trackingProducts.items = (TrackingItem[])addToItemsInBP;
				trackingProducts.realCurrency = (TrackingRealCurrency)addToItemsInBP;
				trackingProducts.virtualCurrencies = virtualCurrencies;
				((TrackingEventBase)transactionEvent).AddComplexParameter<object>((object)trackingProducts, "ProductsReceived");
				((TrackingEventBase)transactionEvent).AddParameter<string>(collectionName, "ObjectName");
				((TrackingEventBase)transactionEvent).AddParameter<string>("collections", "TransactionType");
				((TrackingEventBase)transactionEvent).AddParameter<string>("Collection Reward", "EarningSource");
				TrackEvent(transactionEvent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AFB")]
		[Cpp2IlInjected.Address(RVA = "0x792600", Offset = "0x791000", VA = "0x180792600")]
		private void OnFlowerEvent(IGrid grid, GridObject gridObject, FlowerOperation operation, bool automatic, bool wasDry)
		{
			//Discarded unreachable code: IL_002f
			//IL_000a: Expected O, but got I4
			if (operation == FlowerOperation.Water)
			{
				GardeningOperation gardeningOperation = default(GardeningOperation);
				string text = ((Enum)gardeningOperation).ToString();
				GardeningOperation gardeningOperation2 = gardeningOperation;
				string name = text + "_Flower";
				string result = default(string);
				TrackActivity(name, "", "Gardening", result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AFC")]
		[Cpp2IlInjected.Address(RVA = "0x796310", Offset = "0x794D10", VA = "0x180796310")]
		private void OnPickupCurrency(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_012e, IL_0134, IL_013a, IL_0140, IL_0146, IL_014c
			//IL_00e8: Expected I4, but got I8
			int itemID = currencyItem.ItemID;
			if (detail != null)
			{
			}
			uint num = default(uint);
			if (gained == 0 || num == 18)
			{
				return;
			}
			string text = "CurrencySpent";
			if (gained > 0)
			{
				text = "CurrencyCollected";
			}
			string empty = string.Empty;
			string transactionNameOverride = detail.transactionNameOverride;
			string transactionNameOverride2 = default(string);
			if ((object)typeof(string).TypeHandle == null)
			{
				transactionNameOverride2 = detail.transactionNameOverride;
			}
			string source = detail.source;
			if (transactionNameOverride2 == null)
			{
				string source2 = detail.source;
			}
			if (num == 4)
			{
			}
			string transactionType = default(string);
			if (source == null || source == null || source == null || (source != null && (long)source == 1))
			{
				transactionType = "purchase";
				if (gained > 0)
				{
					transactionType = "trading";
				}
			}
			List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
			TrackingVirtualCurrency trackingVirtualCurrency = new TrackingVirtualCurrency();
			trackingVirtualCurrency.virtualCurrencyAmount = gained;
			IItemData virtualCurrencyName = default(IItemData);
			trackingVirtualCurrency.virtualCurrencyName = (string)(object)virtualCurrencyName;
			string virtualCurrencyType = default(string);
			trackingVirtualCurrency.virtualCurrencyType = virtualCurrencyType;
			((List<T>)(object)list).Add((T)trackingVirtualCurrency);
			int num2 = 0;
			TransactionEvent transactionEvent = default(TransactionEvent);
			transactionEvent.TransactionType = transactionType;
			string earningSource = default(string);
			transactionEvent.EarningSource = earningSource;
			if (num == 13)
			{
				ulong num3 = default(ulong);
				transactionEvent.StarpathActive = (byte)num3 != 0;
			}
			TrackingVirtualCurrency[] array = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
			TrackingProducts productsSpent = default(TrackingProducts);
			transactionEvent.ProductsSpent = productsSpent;
			TrackingProducts productsReceived = default(TrackingProducts);
			transactionEvent.ProductsReceived = productsReceived;
			string characterID = default(string);
			transactionEvent.CharacterID = characterID;
			if (num == 15 || num == 14)
			{
				string text2 = "ClaimFoundersPack";
				if (num != 15)
				{
					text2 = "ClaimInGameShop";
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AFD")]
		[Cpp2IlInjected.Address(RVA = "0x78FC80", Offset = "0x78E680", VA = "0x18078FC80")]
		private void OnBattlePassTaskUpdate(string battlePassOnlineId, BattlePassTaskProgress taskProgress)
		{
			//Discarded unreachable code: IL_00a0, IL_00a6, IL_00ac, IL_00b2, IL_00b8, IL_00be, IL_00c4
			//IL_002b: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			//IL_009d: Expected O, but got I4
			if (taskProgress.taskState_ == BattlePassTaskState.CurrencyClaimed)
			{
				RoyalDutiesEvent royalDutiesEvent = new RoyalDutiesEvent(clientData);
				int _003CIndex_003Ek__BackingField = taskProgress.Index;
				string text2 = (royalDutiesEvent.DutyName = $"{battlePassOnlineId}:{_003CIndex_003Ek__BackingField}");
				ObjectiveData.ObjectiveOneofCase objectiveCase_ = taskProgress.Data.objective_.objectiveCase_;
				string dutyType = ((Enum)objectiveCase_).ToString();
				ObjectiveData.ObjectiveOneofCase objectiveOneofCase = objectiveCase_;
				royalDutiesEvent.DutyType = dutyType;
				int num = (royalDutiesEvent.DutyItemAmount = taskProgress.objective_.targetAmount_);
				int num2 = (royalDutiesEvent.DutyDustReward = taskProgress.Data.currencyReward_);
				royalDutiesEvent.StarpathActive = true;
				TrackEvent(royalDutiesEvent);
				string text3 = $"[Tracking] OnBattlePassTaskUpdate exception: {_003CIndex_003Ek__BackingField}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AFE")]
		[Cpp2IlInjected.Address(RVA = "0x78F7C0", Offset = "0x78E1C0", VA = "0x18078F7C0")]
		private void OnBattlePassCurrencyChanged(int gained, InvActionType reason, BattlePassActionType action)
		{
			//Discarded unreachable code: IL_00af, IL_00b5, IL_00bb
			//IL_0086: Expected I4, but got I8
			if (gained != 0 && reason != InvActionType.None)
			{
				int num = (int)(action - 1);
				if (num == 0 || num == 0 || num == 0 || num == 1 || action == BattlePassActionType.BuyReward)
				{
				}
				List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
				TrackingVirtualCurrency trackingVirtualCurrency = new TrackingVirtualCurrency();
				trackingVirtualCurrency.virtualCurrencyAmount = gained;
				string text = default(string);
				trackingVirtualCurrency.virtualCurrencyName = text;
				trackingVirtualCurrency.virtualCurrencyType = "GRIND";
				((List<T>)(object)list).Add((T)trackingVirtualCurrency);
				int num2 = 0;
				TransactionEvent transactionEvent = default(TransactionEvent);
				transactionEvent.TransactionType = "duties";
				transactionEvent.EarningSource = "cheat";
				ulong num3 = default(ulong);
				((TrackingEventBase)transactionEvent).AddParameter<bool>((byte)num3 != 0, "StarpathActive");
				TrackingVirtualCurrency[] array = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
				TrackingProducts productsSpent = default(TrackingProducts);
				transactionEvent.ProductsSpent = productsSpent;
				TrackingProducts productsReceived = default(TrackingProducts);
				transactionEvent.ProductsReceived = productsReceived;
				string text2 = $"[Tracking] OnBattlePassCurrencyChanged exception: {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AFF")]
		[Cpp2IlInjected.Address(RVA = "0x79D8F0", Offset = "0x79C2F0", VA = "0x18079D8F0")]
		private void TrackReceiveQuestRewards(List<AnyReward> rewards, [Optional] int? characterId)
		{
			this.TrackReceivedRewards((List<>)(object)rewards, "TrackReceiveQuestRewards", "mission reward", (Nullable<>)characterId);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B00")]
		[Cpp2IlInjected.Address(RVA = "0x79EB60", Offset = "0x79D560", VA = "0x18079EB60")]
		private unsafe void TrackUnlockCharacter(Item item)
		{
			//Discarded unreachable code: IL_014e, IL_015a, IL_0160, IL_0166, IL_016c, IL_0172, IL_0178, IL_017e, IL_0184
			//IL_0016: Expected O, but got I4
			//IL_002e: Expected I4, but got I8
			//IL_0058: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			//IL_014b: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			Item item2 = (Item)itemID;
			TrackingProducts trackingProducts = new TrackingProducts();
			TrackingItem[] array = new TrackingItem[1];
			TrackingItem trackingItem = default(TrackingItem);
			trackingItem.itemAmount = 1;
			string itemName = default(string);
			trackingItem.itemName = itemName;
			trackingItem.itemType = "Character";
			trackingItem.itemRarity = -1;
			int num2 = 0;
			trackingItem.ItemTraits = (Dictionary<string, string>)num2;
			trackingItem.ItemTags = (Dictionary<TagItemType, string>)num2;
			if (trackingItem != null)
			{
				array[0] = trackingItem;
				trackingProducts.items = array;
				ClientData clientData = this.clientData;
				Character hangingOutWithCharacter = HangingOutWithCharacter;
				string transactionLocation = default(string);
				int addToItemsInBP = default(int);
				TransactionEvent transactionEvent = new TransactionEvent("TrackUnlockCharacter", clientData, hangingOutWithCharacter, addToItemsInBP, transactionLocation);
				addToItemsInBP = 0;
				((TrackingEventBase)transactionEvent).AddComplexParameter<object>((object)trackingProducts, "ProductsReceived");
				ItemDatabase itemDatabase = ItemDatabase.Instance;
				CharacterItemData characterItemData = default(CharacterItemData);
				if (characterItemData != null)
				{
				}
				int num3 = default(int);
				string t = $"{num3}";
				((TrackingEventBase)transactionEvent).AddParameter<string>(t, "CharacterID");
				if (characterItemData == null || characterItemData.displayName_ == null)
				{
				}
				((TrackingEventBase)transactionEvent).AddParameter<string>("None", "ObjectName");
				RepeatedField<Character> characters_ = this.clientData.profile.world_.characters_;
				Predicate<Character> predicate = (Predicate<Character>)(object)(Predicate<T>)delegate(Character x)
				{
					Item item3 = x.base_.Item;
					throw new NullReferenceException();
				};
				if (ProtoExtensions.TryFindValue<Character>((RepeatedField<>)(object)characters_, (Predicate<>)(object)predicate, ref *(Character*)num))
				{
					string t2 = default(string);
					((TrackingEventBase)transactionEvent).AddParameter<string>(t2, "ObjectLevel");
				}
				TrackEvent(transactionEvent);
				uint num4 = default(uint);
				string text = $"[Tracking] TrackUnlockCharacter exception: {num4}";
				return;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B01")]
		[Cpp2IlInjected.Address(RVA = "0x790B70", Offset = "0x78F570", VA = "0x180790B70")]
		private void OnCharacterFriendshipChanged(Character character, int friendshipChange, int oldLevel, int newLevel, FriendshipSource friendshipSource)
		{
			//Discarded unreachable code: IL_00ba, IL_00c6, IL_00cc, IL_00d2, IL_00d8, IL_00de, IL_00e4
			//IL_0045: Expected I4, but got I8
			//IL_004e: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			TrackingRewards trackingRewards = new TrackingRewards();
			trackingRewards.rewardName = "FriendshipLevelUpRewards";
			TrackingItem[] array = new TrackingItem[1];
			TrackingItem trackingItem = default(TrackingItem);
			trackingItem.itemAmount = friendshipChange;
			trackingItem.itemName = "XP";
			trackingItem.itemType = "XP";
			trackingItem.itemRarity = -1;
			int num = 0;
			trackingItem.ItemTraits = (Dictionary<string, string>)num;
			trackingItem.ItemTags = (Dictionary<TagItemType, string>)num;
			if (trackingItem != null)
			{
				array[0] = trackingItem;
				trackingRewards.items = array;
				LevelUpEvent levelUpEvent = default(LevelUpEvent);
				levelUpEvent.ObjectName = "character";
				CharacterItemData data = character.Data;
				string text = (levelUpEvent.CharacterName = data.name_);
				string sourceOfXP = data.ToString();
				CharacterItemData characterItemData = data;
				levelUpEvent.SourceOfXP = sourceOfXP;
				levelUpEvent.Reward = trackingRewards;
				string text2 = $"[Tracking] OnCharacterFriendshipChanged exception: {oldLevel}";
				return;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B02")]
		[Cpp2IlInjected.Address(RVA = "0x790F00", Offset = "0x78F900", VA = "0x180790F00")]
		private void OnCharacterFriendshipLevelChanged(Item characterItem, int levelsGained)
		{
			OnCharacterEvent(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B03")]
		[Cpp2IlInjected.Address(RVA = "0x7975E0", Offset = "0x795FE0", VA = "0x1807975E0")]
		private void OnSecretCharacterVisitStarted(Character character)
		{
			//Discarded unreachable code: IL_000d
			Item item = character.base_.Item;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B04")]
		[Cpp2IlInjected.Address(RVA = "0x7905B0", Offset = "0x78EFB0", VA = "0x1807905B0")]
		private unsafe void OnCharacterEvent(Item item)
		{
			//Discarded unreachable code: IL_00fc, IL_0102, IL_0108, IL_010e, IL_0114, IL_011a, IL_0120, IL_0126, IL_012c, IL_0132, IL_0138, IL_013e, IL_0144, IL_014a
			//IL_0016: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			//IL_00c5: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			Item item2 = (Item)itemID;
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			Item item3 = item2;
			CharacterItemData itemData = itemDatabase.GetItemData<CharacterItemData>(item3);
			CharactersEvent charactersEvent = new CharactersEvent(clientData);
			Item item4 = item2;
			string characterID = default(string);
			charactersEvent.CharacterID = characterID;
			string text = (charactersEvent.CharacterName = itemData.displayName_);
			if (ProtoDatabase.Instance.TryGet("Worlds", out *(WorldData*)num))
			{
				Predicate<WorldData.Types.World> predicate = (Predicate<WorldData.Types.World>)(object)(Predicate<T>)delegate(WorldData.Types.World x)
				{
					//Discarded unreachable code: IL_0009
					RepeatedField<int> characters_2 = x.characters_;
					bool result = default(bool);
					return result;
				};
				bool flag = default(bool);
				if (flag)
				{
					charactersEvent.CharacterRealm = (string)num;
				}
			}
			RepeatedField<Character> characters_ = clientData.profile.world_.characters_;
			Predicate<Character> predicate2 = (Predicate<Character>)(object)(Predicate<T>)delegate(Character x)
			{
				Item item5 = x.base_.Item;
				throw new NullReferenceException();
			};
			if (ProtoExtensions.TryFindValue<Character>((RepeatedField<>)(object)characters_, (Predicate<>)(object)predicate2, ref *(Character*)num))
			{
				Character.Types.CharacterStatus characterStatus = default(Character.Types.CharacterStatus);
				string characterState = ((Enum)characterStatus).ToString();
				Character.Types.CharacterStatus characterStatus2 = characterStatus;
				charactersEvent.CharacterState = characterState;
				ProfessionItemData professionItemData = default(ProfessionItemData);
				string empty = default(string);
				if (professionItemData == null || professionItemData.displayName_ == null)
				{
					empty = string.Empty;
				}
				charactersEvent.CharacterProfession = empty;
			}
			TrackEvent(charactersEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B05")]
		[Cpp2IlInjected.Address(RVA = "0x795BE0", Offset = "0x7945E0", VA = "0x180795BE0")]
		private void OnPetUnlocked(Item petItem, AddDetail detail)
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B06")]
		[Cpp2IlInjected.Address(RVA = "0x793620", Offset = "0x792020", VA = "0x180793620")]
		private void OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_005b, IL_0061, IL_0067, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085, IL_008b, IL_0091
			//IL_0044: Expected O, but got I4
			int num = 0;
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			int itemID = gridObject.ItemID;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Furniture)
			{
				Village village = clientData.profile.Village;
			}
			if (operation == GridChangedOperation.Remove)
			{
				int itemID2 = gridObject.ItemID;
				bool flag = default(bool);
				if (flag)
				{
					string name = "IngredientPickedup:" + (string)num;
					string result = default(string);
					TrackActivity(name, "", "Gathering", result);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B07")]
		[Cpp2IlInjected.Address(RVA = "0x799800", Offset = "0x798200", VA = "0x180799800")]
		private void OnUpdateBuilding(GridObject gridObj, UpgradeData upData)
		{
			//Discarded unreachable code: IL_023a, IL_0240, IL_0246, IL_024c, IL_0252, IL_0258, IL_025e, IL_0264, IL_026a, IL_0270, IL_0276, IL_027c, IL_0282, IL_0288, IL_028e, IL_0294, IL_029a, IL_02a0, IL_02a6, IL_02ac, IL_02b2, IL_02b8, IL_02be, IL_02c4, IL_02ca, IL_02d0
			//IL_007b: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_01a3: Expected O, but got I4
			//IL_0204: Expected O, but got I4
			//IL_0204: Expected O, but got I4
			string transactionLocation = default(string);
			string objectLevel = default(string);
			TrackingVirtualCurrency item2 = default(TrackingVirtualCurrency);
			TrackingProducts productsSpent = default(TrackingProducts);
			BenefitsGardeningData gardening = default(BenefitsGardeningData);
			string text5 = default(string);
			FishingStallData fishingStallData = default(FishingStallData);
			FishingStallData fishingStallData2 = default(FishingStallData);
			FishingStallData fishingStallData3 = default(FishingStallData);
			while (true)
			{
				int addToItemsInBP = 0;
				if (upData == null || upData.level_ <= 1 || gridObj == null)
				{
					break;
				}
				GridState state_ = gridObj.state_;
				if (state_ == null)
				{
					break;
				}
				switch (state_.stateCase_)
				{
				}
				ClientData clientData = this.clientData;
				Character hangingOutWithCharacter = HangingOutWithCharacter;
				TransactionEvent transactionEvent = new TransactionEvent("UpgradeBuilding", clientData, hangingOutWithCharacter, addToItemsInBP, transactionLocation);
				transactionEvent.TransactionType = "upgrade";
				int itemID = gridObj.ItemID;
				string text2 = (transactionEvent.ObjectName = $"{itemID}");
				int level_ = upData.level_;
				transactionEvent.ObjectLevel = objectLevel;
				if ((long)upData.cost_ != 0)
				{
					List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
					CurrencyCost cost_ = upData.cost_;
					Item item = upData.cost_.Item;
					((List<T>)(object)list).Add((T)item2);
					TrackingVirtualCurrency[] array = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
					int num = 0;
					transactionEvent.ProductsSpent = productsSpent;
				}
				GridState state_2 = gridObj.state_;
				if (state_2.stateCase_ == GridState.StateOneofCase.StallData)
				{
					StallData stallData = state_2.StallData;
					if (stallData != null && (long)stallData.upgradeState_ != 0)
					{
						if (gridObj.state_.StallData.upgradeState_.level_ == 1)
						{
							goto IL_01b8;
						}
						int itemID2 = gridObj.ItemID;
						int level_2 = gridObj.state_.StallData.upgradeState_.level_;
						string text3 = $"{itemID2}_Level_{level_2}";
						if (upData.Gardening != null)
						{
							itemID2 = upData.Gardening.numberOfSlots_;
							gardening = upData.Gardening;
							int refreshCost_ = gardening.refreshCost_;
							BenefitsGardeningData gardening2 = upData.Gardening;
							int sellCap_ = gardening2.sellCap_;
							string text4 = $"_Slots_{itemID2}_RefreshCost_{gardening}_SellCap_{gardening2}";
							text5 = text3 + text4;
						}
					}
					TrackEvent(transactionEvent);
				}
				goto IL_01b8;
				IL_01b8:
				while ((long)text5 != 7)
				{
				}
				while (fishingStallData == null)
				{
				}
				while ((long)fishingStallData.upgradeState_ == 0)
				{
				}
				if (fishingStallData2.upgradeState_.level_ != 1)
				{
					int itemID2 = gardening.RefreshCost;
					int level_3 = fishingStallData3.upgradeState_.level_;
					string text6 = $"{itemID2}_Level_{level_3}";
					if (upData.Fishing != null)
					{
						itemID2 = upData.Fishing.fishCap_;
						int fishPerHour_ = upData.Fishing.fishPerHour_;
						int fishingManaReductionPercentage_ = upData.Fishing.fishingManaReductionPercentage_;
						return;
					}
					continue;
				}
				return;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B08")]
		[Cpp2IlInjected.Address(RVA = "0x78EB10", Offset = "0x78D510", VA = "0x18078EB10")]
		private unsafe void OnAchievementSetUpdated(Item achievementItem, bool milestonePassed)
		{
			//Discarded unreachable code: IL_0101, IL_0107, IL_010d, IL_0113, IL_0119, IL_011f, IL_0125, IL_012b, IL_0131, IL_0137, IL_013d, IL_0143, IL_0149
			//IL_001c: Expected O, but got I4
			//IL_00a2: Expected O, but got I4
			//IL_00c1: Expected O, but got I4
			int itemID = achievementItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
			CS_0024_003C_003E8__locals0.achievementItem = (Item)itemID;
			ClientData clientData = this.clientData;
			if (clientData == null)
			{
				return;
			}
			Profile profile = clientData.profile;
			if (profile == null || (IntPtr)profile.player_.achievementsData_ == (IntPtr)num || !milestonePassed)
			{
				return;
			}
			RepeatedField<AchievementData> achievementsData_ = this.clientData.profile.player_.achievementsData_;
			Predicate<AchievementData> predicate = (Predicate<AchievementData>)(object)(Predicate<T>)delegate(AchievementData x)
			{
				//Discarded unreachable code: IL_0011
				Item achievementItem2 = CS_0024_003C_003E8__locals0.achievementItem;
				return (IntPtr)x.achievementID_ == (IntPtr)achievementItem2;
			};
			AchievementItemData achievementItemData = default(AchievementItemData);
			if (ProtoExtensions.TryFindValue<AchievementData>((RepeatedField<>)(object)achievementsData_, (Predicate<>)(object)predicate, ref *(AchievementData*)num) && achievementItemData != null)
			{
				AchievementsEvent achievementsEvent = new AchievementsEvent(this.clientData);
				AchievementState achievementState = default(AchievementState);
				string achievementState2 = ((Enum)achievementState).ToString();
				AchievementState achievementState3 = achievementState;
				achievementsEvent.AchievementState = achievementState2;
				AchievementType type_ = achievementItemData.type_;
				string achievementType = ((Enum)type_).ToString();
				AchievementType achievementType2 = type_;
				achievementsEvent.AchievementType = achievementType;
				RepeatedField<AchievementMilestone> milestones_ = achievementItemData.milestones_;
				bool flag = default(bool);
				if (flag)
				{
					num++;
				}
				achievementsEvent.EarnedDreamlight = num;
				achievementsEvent.AchievementStep = num;
			}
			string text = $"[Tracking] OnAchievementSetUpdated exception: {CS_0024_003C_003E8__locals0}";
		}

		[Cpp2IlInjected.Token(Token = "0x6005B09")]
		[Cpp2IlInjected.Address(RVA = "0x792000", Offset = "0x790A00", VA = "0x180792000")]
		private void OnDutyGenerated(int slotID, bool generated = false)
		{
			//Discarded unreachable code: IL_0173, IL_0179, IL_017f, IL_0185, IL_018b, IL_0191, IL_0197, IL_019d, IL_01a3, IL_01a9, IL_01af
			//IL_00bf: Expected O, but got I4
			int dutyItemAmount = 0;
			if (!generated)
			{
				return;
			}
			DutyList royalDutiesList = clientData.profile.player_.GetRoyalDutiesList();
			if (royalDutiesList == null)
			{
				return;
			}
			RepeatedField<DutySlot> slots_ = royalDutiesList.slots_;
			if (slots_ == null || ((RepeatedField<T>)(object)slots_).Count == 0)
			{
				return;
			}
			RepeatedField<DutySlot> slots_2 = royalDutiesList.slots_;
			Func<DutySlot, bool> func = (Func<DutySlot, bool>)(object)(Func<T, TResult>)delegate(DutySlot x)
			{
				//Discarded unreachable code: IL_0011
				int num2 = slotID;
				return x.slotId_ == num2;
			};
			DutySlot dutySlot = Enumerable.First<DutySlot>((IEnumerable<>)(object)slots_2, (Func<, >)(object)func);
			RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
			if (dutySlot == null || royalDutyItemData == null)
			{
				return;
			}
			RoyalDutiesEvent royalDutiesEvent = new RoyalDutiesEvent(clientData);
			int iD_ = royalDutyItemData.iD_;
			string dutyID = default(string);
			royalDutiesEvent.DutyID = dutyID;
			string text = (royalDutiesEvent.DutyName = royalDutyItemData.name_);
			DutyType type_ = royalDutyItemData.type_;
			string dutyType = ((Enum)type_).ToString();
			DutyType dutyType2 = type_;
			royalDutiesEvent.DutyType = dutyType;
			int difficultyLayer_ = dutySlot.difficultyLayer_;
			string dutyDifficulty = default(string);
			royalDutiesEvent.DutyDifficulty = dutyDifficulty;
			if (dutySlot.stepData_ != null)
			{
			}
			royalDutiesEvent.DutyItemAmount = dutyItemAmount;
			royalDutiesEvent.DutyItemName = "ItemFilter/NoItem";
			DutyStepData stepData_ = dutySlot.stepData_;
			if (stepData_ != null)
			{
				Meta.Missions.ItemFilter itemFilter_ = stepData_.itemFilter_;
				if (itemFilter_ != null)
				{
					int itemID = itemFilter_.ItemID;
					int itemID2 = dutySlot.stepData_.itemFilter_.ItemID;
					string dutyItemName = default(string);
					royalDutiesEvent.DutyItemName = dutyItemName;
				}
			}
			RepeatedField<DutyStepDifficulty> stepDifficultyLayers_ = royalDutyItemData.stepDifficultyLayers_;
			int difficultyLayer_2 = dutySlot.difficultyLayer_;
			int num = (royalDutiesEvent.DutyDustReward = ((DutyStepDifficulty)((RepeatedField<T>)(object)stepDifficultyLayers_)[difficultyLayer_2]).dustReward_);
			TrackEvent(royalDutiesEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0A")]
		[Cpp2IlInjected.Address(RVA = "0x7988E0", Offset = "0x7972E0", VA = "0x1807988E0")]
		public unsafe void OnStorageFull(StorageType storageType, uint storageID = 0u)
		{
			//Discarded unreachable code: IL_006d, IL_0073, IL_0079, IL_007f, IL_0085, IL_008b, IL_0091, IL_0097, IL_009d, IL_00a3, IL_00a9
			//IL_0020: Expected O, but got I4
			int num = 0;
			ClientData clientData = this.clientData;
			int size_ = default(int);
			if (((MapField<TKey, TValue>)(object)clientData.profile.player_.containerInventories_).TryGetValue((TKey)storageID, out *(TValue*)num))
			{
				size_ = clientData.profile.Backpack.size_;
			}
			StorageFullEvent storageFullEvent = new StorageFullEvent(this.clientData);
			storageFullEvent.StorageCapacity = size_;
			string storageId = storageFullEvent.ToString();
			StorageFullEvent storageFullEvent2 = storageFullEvent;
			storageFullEvent.StorageId = storageId;
			storageFullEvent.Redirection = "NONE";
			TrackEvent(storageFullEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0B")]
		[Cpp2IlInjected.Address(RVA = "0x792480", Offset = "0x790E80", VA = "0x180792480")]
		public void OnExitGame()
		{
			//Discarded unreachable code: IL_001a
			FlushAllUIInteractions();
			GameEndedEvent trackingEvent = new GameEndedEvent(clientData);
			TrackEvent(trackingEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0C")]
		[Cpp2IlInjected.Address(RVA = "0x796D90", Offset = "0x795790", VA = "0x180796D90")]
		private unsafe void OnRealmUnlocked(string realmID, bool unlockedByFlag)
		{
			//Discarded unreachable code: IL_00db, IL_00e1, IL_00e7, IL_00ed, IL_00f3, IL_00f9, IL_00ff, IL_0105, IL_010b, IL_0111
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			string realmID2 = realmID;
			if (ProtoDatabase.Instance.TryGet("Worlds", out *(WorldData*)num))
			{
				Func<WorldData.Types.World, bool> func = (Func<WorldData.Types.World, bool>)(object)(Func<T, TResult>)delegate(WorldData.Types.World x)
				{
					//Discarded unreachable code: IL_0014
					string b = realmID2;
					return string.Equals(x.worldName_, b);
				};
				WorldData.Types.World world = default(WorldData.Types.World);
				if (world != null)
				{
					ClientData clientData = this.clientData;
					Character hangingOutWithCharacter = HangingOutWithCharacter;
					string transactionLocation = default(string);
					TransactionEvent transactionEvent = new TransactionEvent("RealmUnlocked", clientData, hangingOutWithCharacter, num, transactionLocation);
					((TrackingEventBase)transactionEvent).AddParameter<string>("unlock", "TransactionType");
					string worldName_ = world.worldName_;
					((TrackingEventBase)transactionEvent).AddParameter<string>(worldName_, "ObjectName");
					if (!unlockedByFlag)
					{
						List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
						RepeatedField<CurrencyCost> unlockCost_ = world.unlockCost_;
						bool flag = default(bool);
						if (flag)
						{
							while ((unlockedByFlag ? 1 : 0) <= (false ? 1 : 0))
							{
							}
							TrackingVirtualCurrency item = default(TrackingVirtualCurrency);
							((List<T>)(object)list).Add((T)item);
						}
						int num4 = 0;
						TrackingVirtualCurrency[] array = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
						TrackingProducts productsSpent = default(TrackingProducts);
						transactionEvent.ProductsSpent = productsSpent;
					}
					TrackEvent(transactionEvent);
				}
			}
			string text = $"[Tracking] OnRealmUnlocked exception: {realmID}";
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0D")]
		[Cpp2IlInjected.Address(RVA = "0x792590", Offset = "0x790F90", VA = "0x180792590")]
		private void OnFishCollected(List<AnyReward> rewards)
		{
			//IL_0014: Expected O, but got I4
			int num = 0;
			this.TrackReceivedRewards((List<>)(object)rewards, "FishCollectedFromStall", "fishing", (Nullable<>)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0E")]
		[Cpp2IlInjected.Address(RVA = "0x797410", Offset = "0x795E10", VA = "0x180797410")]
		private void OnRestItemGiven(CharacterRestaurantOrder order, ItemWithState mealServed)
		{
			//Discarded unreachable code: IL_0013, IL_0048, IL_004e, IL_0054
			//IL_003a: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			Item mealItem = order.MealItem;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0F")]
		[Cpp2IlInjected.Address(RVA = "0x7945D0", Offset = "0x792FD0", VA = "0x1807945D0")]
		private void OnItemsGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool alreadyGifted = false)
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001e
			int itemID = missionItem.ItemID;
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			MissionItemData missionItemData = default(MissionItemData);
			if (missionItemData == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B10")]
		[Cpp2IlInjected.Address(RVA = "0x795180", Offset = "0x793B80", VA = "0x180795180")]
		private void OnMiningRock(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_001b, IL_0021
			if (!success)
			{
			}
			string result = default(string);
			TrackActivity("Mining", "Finished", "Mining", result);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B11")]
		[Cpp2IlInjected.Address(RVA = "0x78F6A0", Offset = "0x78E0A0", VA = "0x18078F6A0")]
		private void OnAvatarRemoveBlocker(IGrid grid, GridObject gridObject)
		{
			//Discarded unreachable code: IL_0017
			string result = default(string);
			TrackActivity("RemoveBlocker", "Finished", "RemoveBlocker", result);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B12")]
		[Cpp2IlInjected.Address(RVA = "0x794120", Offset = "0x792B20", VA = "0x180794120")]
		private void OnItemMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action)
		{
			//Discarded unreachable code: IL_004f
			ClientData clientData = this.clientData;
			uint iD_ = destination.iD_;
			ContainerInventory backpack = clientData.profile.Backpack;
			int num = 0;
			if (iD_ == backpack.iD_)
			{
			}
			ClientData clientData2 = this.clientData;
			uint iD_2 = source.iD_;
			ContainerInventory backpack2 = clientData2.profile.Backpack;
			if (iD_2 != backpack2.iD_)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B13")]
		[Cpp2IlInjected.Address(RVA = "0x791740", Offset = "0x790140", VA = "0x180791740")]
		private void OnCraftingCompleted(Item craftingRecipeItem, int amountOfCraftingDone)
		{
			//Discarded unreachable code: IL_007b, IL_0097, IL_009d, IL_00a3, IL_00a9, IL_00af, IL_00b5, IL_00bb, IL_00c1, IL_00c7, IL_00cd, IL_00d3, IL_00d9, IL_00df
			//IL_0024: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			int itemID = craftingRecipeItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				string text = "Craft " + (string)num;
				string result = default(string);
				TrackActivity(text, "Done", text, result);
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				bool flag2 = default(bool);
				if (flag2)
				{
					throw new NullReferenceException();
				}
				int num4 = 0;
				TransactionEvent transactionEvent = default(TransactionEvent);
				((TrackingEventBase)transactionEvent).AddParameter<string>("Crafting", "TransactionType");
				TrackingProducts t = default(TrackingProducts);
				((TrackingEventBase)transactionEvent).AddComplexParameter<object>((object)t, "ProductsSpent");
				Dictionary<Item, int> dictionary2 = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				int num5 = 0;
				throw new NullReferenceException();
			}
			string text2 = $"[Tracking] OnCraftingCompleted exception: {itemID}";
		}

		[Cpp2IlInjected.Token(Token = "0x6005B14")]
		[Cpp2IlInjected.Address(RVA = "0x7939B0", Offset = "0x7923B0", VA = "0x1807939B0")]
		private void OnHangoutActivity(Item characterItem, HangoutEvent hangoutEvent)
		{
			//Discarded unreachable code: IL_000f
			//IL_000d: Expected O, but got I4
			string text = $"{hangoutEvent}Hangout";
		}

		[Cpp2IlInjected.Token(Token = "0x6005B15")]
		[Cpp2IlInjected.Address(RVA = "0x794810", Offset = "0x793210", VA = "0x180794810")]
		private void OnKeyholeItemAdded(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
			//Discarded unreachable code: IL_000c, IL_0022, IL_0028
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B16")]
		[Cpp2IlInjected.Address(RVA = "0x7949A0", Offset = "0x7933A0", VA = "0x1807949A0")]
		private void OnKeyholeItemRemoved(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
			//Discarded unreachable code: IL_000c, IL_0021, IL_0027
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B17")]
		[Cpp2IlInjected.Address(RVA = "0x794B30", Offset = "0x793530", VA = "0x180794B30")]
		private void OnKeyholeLevelCompleted(Keyhole keyhole, int levelCompleted)
		{
			//Discarded unreachable code: IL_006d, IL_0073, IL_0079, IL_007f
			//IL_004b: Expected O, but got I4
			IEnumerable<ProtoDatabase.ProtoDesc> enumerable = (IEnumerable<ProtoDatabase.ProtoDesc>)ProtoDatabase.Instance.EnumerateAll();
			Func<ProtoDatabase.ProtoDesc, bool> func = (Func<ProtoDatabase.ProtoDesc, bool>)(object)(Func<T, TResult>)delegate(ProtoDatabase.ProtoDesc x)
			{
				IMessage _003CMessage_003Ek__BackingField = x.Message;
				if (_003CMessage_003Ek__BackingField != null && _003CMessage_003Ek__BackingField != null)
				{
					KeyholeConfig config = keyhole.Config;
					return _003CMessage_003Ek__BackingField == config;
				}
				int num2 = 0;
				throw new NullReferenceException();
			};
			if (Enumerable.FirstOrDefault<ProtoDatabase.ProtoDesc>((IEnumerable<>)enumerable, (Func<, >)(object)func) != null)
			{
			}
			int num = 0;
			LevelUpEvent levelUpEvent = new LevelUpEvent(clientData);
			string text2 = (levelUpEvent.LevelUpName = $"Keyhole:{num}_NewLevel:{levelUpEvent}");
			TrackEvent(levelUpEvent);
			string text3 = $"[Tracking] OnKeyholeLevelCompleted exception: {levelUpEvent}";
		}

		[Cpp2IlInjected.Token(Token = "0x6005B18")]
		[Cpp2IlInjected.Address(RVA = "0x795150", Offset = "0x793B50", VA = "0x180795150")]
		private void OnMemoryShardAdded(Item memoryShardItem, int memoryShardIndex, AddDetail detail)
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B19")]
		[Cpp2IlInjected.Address(RVA = "0x798B60", Offset = "0x797560", VA = "0x180798B60")]
		private void OnToolAdded(Item toolItem)
		{
			//Discarded unreachable code: IL_000c, IL_0021
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B1A")]
		[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
		private void OnHangoutChanged(Character hangoutCharacter)
		{
			HangingOutWithCharacter = hangoutCharacter;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B1B")]
		[Cpp2IlInjected.Address(RVA = "0x78F030", Offset = "0x78DA30", VA = "0x18078F030")]
		private void OnAgeGatePassed(int usersAge)
		{
			//Discarded unreachable code: IL_001b, IL_0021
			AgeGateEvent ageGateEvent = new AgeGateEvent(clientData);
			ageGateEvent.User_age = usersAge;
			TrackEvent(ageGateEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B1C")]
		[Cpp2IlInjected.Address(RVA = "0x792710", Offset = "0x791110", VA = "0x180792710")]
		private void OnFoundersPackClaimedRedeemed(string foundersPackName)
		{
			//Discarded unreachable code: IL_002e, IL_0034, IL_003a
			FoundersPackEvent foundersPackEvent = new FoundersPackEvent(clientData);
			foundersPackEvent.Founder_pack_type = foundersPackName;
			string text = (foundersPackEvent.Playfab_id = clientData.playfabUserId);
			TrackEvent(foundersPackEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B1D")]
		[Cpp2IlInjected.Address(RVA = "0x79C560", Offset = "0x79AF60", VA = "0x18079C560")]
		private void TrackCurrencyRedeemed(string moonstonePackName, Item currencyItem, int amount)
		{
			int itemID = currencyItem.ItemID;
			CurrencyEarned trackingEvent = default(CurrencyEarned);
			TrackEvent(trackingEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B1E")]
		[Cpp2IlInjected.Address(RVA = "0x78E760", Offset = "0x78D160", VA = "0x18078E760")]
		private string GetTransactionName(InvActionType reason)
		{
			string result = "ClaimFoundersPack";
			if (reason != InvActionType.Mailbox)
			{
				result = "ClaimInGameShop";
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B1F")]
		[Cpp2IlInjected.Address(RVA = "0x79C470", Offset = "0x79AE70", VA = "0x18079C470")]
		private void TrackCurrencyEarned(string moonstonePackName, Item currencyItem, int amount, InvActionType reason)
		{
			int itemID = currencyItem.ItemID;
			CurrencyEarned trackingEvent = default(CurrencyEarned);
			TrackEvent(trackingEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B20")]
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B700", VA = "0x18079CD00")]
		private void TrackItemEarned(Item item, int amount, InvActionType reason)
		{
			int itemID = item.ItemID;
			string text = "ClaimFoundersPack";
			if (reason != InvActionType.Mailbox)
			{
				text = "ClaimInGameShop";
			}
			ItemEarned trackingEvent = default(ItemEarned);
			TrackEvent(trackingEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B21")]
		[Cpp2IlInjected.Address(RVA = "0x792BA0", Offset = "0x7915A0", VA = "0x180792BA0")]
		private void OnFurnitureChanged(IItemData itemData, GridChangedOperation operation)
		{
			//Discarded unreachable code: IL_005c, IL_0062, IL_0068, IL_006e
			if (operation == GridChangedOperation.Add)
			{
				CustomizationEvent customizationEvent = new CustomizationEvent(clientData);
				customizationEvent.ObjectName = "Furniture";
				customizationEvent.NbChanges = 1;
				List<TrackingItem> list = (List<TrackingItem>)(object)new List<T>();
				TrackingItem item = TrackingEventsUtil.BuildItemProduct(itemData, 1);
				((List<T>)(object)list).Add((T)item);
				TrackingProducts trackingProducts = new TrackingProducts();
				TrackingItem[] array = (trackingProducts.items = (TrackingItem[])(object)((List<T>)(object)list).ToArray());
				customizationEvent.ProductsSpent = trackingProducts;
				TrackEvent(customizationEvent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B22")]
		[Cpp2IlInjected.Address(RVA = "0x79CFC0", Offset = "0x79B9C0", VA = "0x18079CFC0")]
		private void TrackPlaceFurniture(IItemData itemData, GridObject gridObject, GridChangedOperation operation, bool inVillage)
		{
			//Discarded unreachable code: IL_001a, IL_003c, IL_005a, IL_0060, IL_0066, IL_006c, IL_0072
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			switch (operation)
			{
			case GridChangedOperation.Remove:
			{
				Dictionary<Item, int> dictionary2 = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			case GridChangedOperation.Add:
			{
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B23")]
		[Cpp2IlInjected.Address(RVA = "0x792DF0", Offset = "0x7917F0", VA = "0x180792DF0")]
		private void OnGardeningEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_014a, IL_0191
			//IL_0123: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0168: Expected O, but got I4
			int num = 0;
			GridState state_ = gridObject.state_;
			if (state_ == null)
			{
				return;
			}
			GardenData gardenData = state_.GardenData;
			if (gardenData == null || (IntPtr)gardenData.slots_ == (IntPtr)num)
			{
				return;
			}
			GridState state_2 = gridObject.state_;
			if (state_2 != null)
			{
				GardenData gardenData2 = state_2.GardenData;
				if (gardenData2 != null)
				{
					int count = ((RepeatedField<T>)(object)gardenData2.slots_).Count;
				}
			}
			bool flag = slotIndex >= num;
			if (num != (flag ? 1 : 0))
			{
				return;
			}
			GridState state_3 = gridObject.state_;
			if (state_3 != null)
			{
				GardenData gardenData3 = state_3.GardenData;
				if (gardenData3 != null)
				{
					int itemID = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gardenData3.slots_)[slotIndex]).PlantedSeedItem.ItemID;
				}
			}
			if (num == 0)
			{
				Item invalid = Item.Invalid;
			}
			SeedItemData seedItemData = default(SeedItemData);
			if (seedItemData != null)
			{
				if (seedItemData.producesItem_)
				{
					Item producedItem = seedItemData.ProducedItem;
					bool flag2 = default(bool);
					if (flag2)
					{
						Item producedItem2 = seedItemData.ProducedItem;
						ItemType itemType = default(ItemType);
						if (itemType == ItemType.ActivityItem)
						{
							Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
							throw new NullReferenceException();
						}
					}
				}
				Item producedItem3 = seedItemData.ProducedItem;
				Item producedItem4 = seedItemData.ProducedItem;
				bool flag3 = default(bool);
				ActivityItemType activityItemType = default(ActivityItemType);
				if (flag3 && activityItemType == ActivityItemType.Crop)
				{
					Item producedItem5 = seedItemData.ProducedItem;
					bool flag4 = default(bool);
					if (flag4)
					{
						string result = default(string);
						TrackActivity("Fruit Collected", "", "Fruits", result);
					}
				}
			}
			GardeningOperation gardeningOperation = default(GardeningOperation);
			string name = ((Enum)gardeningOperation).ToString();
			GardeningOperation gardeningOperation2 = gardeningOperation;
			string result2 = default(string);
			TrackActivity(name, "", "Gardening", result2);
			Dictionary<Item, int> dictionary2 = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B24")]
		[Cpp2IlInjected.Address(RVA = "0x79D280", Offset = "0x79BC80", VA = "0x18079D280")]
		private void TrackPlantCropOrTree(Item item)
		{
			//Discarded unreachable code: IL_000c, IL_0022
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B25")]
		[Cpp2IlInjected.Address(RVA = "0x79F450", Offset = "0x79DE50", VA = "0x18079F450")]
		private void TrackWaterCropOrTree(Item item)
		{
			//Discarded unreachable code: IL_0037, IL_003d
			ClientData clientData = this.clientData;
			Character hangingOutWithCharacter = HangingOutWithCharacter;
			string transactionLocation = default(string);
			int addToItemsInBP = default(int);
			TransactionEvent transactionEvent = new TransactionEvent("TrackWaterCropOrTree", clientData, hangingOutWithCharacter, addToItemsInBP, transactionLocation);
			addToItemsInBP = 0;
			string t = default(string);
			((TrackingEventBase)transactionEvent).AddParameter<string>(t, "ObjectName");
			TrackEvent(transactionEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B26")]
		[Cpp2IlInjected.Address(RVA = "0x79BDD0", Offset = "0x79A7D0", VA = "0x18079BDD0")]
		private void TrackCollectCropOrFruit(Item item, int producedAmount, bool burningState)
		{
			//Discarded unreachable code: IL_0010, IL_0027
			//IL_0026: Expected O, but got I4
			//IL_0026: Expected I4, but got I8
			//IL_0026: Expected O, but got I4
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.ActivityItem)
			{
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B27")]
		[Cpp2IlInjected.Address(RVA = "0x79BBA0", Offset = "0x79A5A0", VA = "0x18079BBA0")]
		private void TrackCatchFish(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter areaType, Item spectator, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_0010, IL_003f, IL_0045, IL_004b
			//IL_0024: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			if (success)
			{
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			int num = 0;
			string result = default(string);
			TrackActivity("Fishing", "Finished", "Fishing", result);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B28")]
		[Cpp2IlInjected.Address(RVA = "0x79F1C0", Offset = "0x79DBC0", VA = "0x18079F1C0")]
		private void TrackUseItemsInCooking(Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed)
		{
			//Discarded unreachable code: IL_0022
			//IL_0008: Expected I4, but got O
			int num = 0;
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>((int)ingredients);
			if (ingredients != null)
			{
			}
			if (fuelUsed != null)
			{
				bool flag = default(bool);
				if (flag)
				{
					throw new NullReferenceException();
				}
				int num2 = 0;
			}
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B29")]
		[Cpp2IlInjected.Address(RVA = "0x79D7A0", Offset = "0x79C1A0", VA = "0x18079D7A0")]
		private void TrackReceiveItemFromCooking(Item cookedItem)
		{
			//Discarded unreachable code: IL_000c, IL_0038
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2A")]
		[Cpp2IlInjected.Address(RVA = "0x793AD0", Offset = "0x7924D0", VA = "0x180793AD0")]
		private void OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			//Discarded unreachable code: IL_005b, IL_0084, IL_008b, IL_0099, IL_00a0, IL_00c2, IL_00ec, IL_00f2, IL_00f8, IL_00fe, IL_0104, IL_010a, IL_0110, IL_0116, IL_011c
			//IL_007d: Expected O, but got I4
			//IL_007d: Expected I4, but got I8
			//IL_007d: Expected I4, but got I8
			//IL_007d: Expected O, but got I4
			int num = 0;
			if ("trading" != null)
			{
				ItemType itemType = default(ItemType);
				Dictionary<Item, int> dictionary = default(Dictionary<Item, int>);
				if ((IntPtr)(((long)"trading" == 1) ? 1 : 0) != (IntPtr)"trading" && itemType == ItemType.ActivityItem)
				{
					dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
					throw new NullReferenceException();
				}
				if ((long)dictionary != 18)
				{
					string text = "item";
					if ((long)dictionary == 13)
					{
						text = "trading";
					}
					Dictionary<Item, int> dictionary2 = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
					throw new NullReferenceException();
				}
				ItemEarned arg = default(ItemEarned);
				string text2 = $"[Tracking] OnItemAdded exception: {arg}";
				return;
			}
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			RequestItemData requestItemData = default(RequestItemData);
			if (requestItemData == null)
			{
				Dictionary<Item, int> dictionary3 = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			Dictionary<Item, int> dictionary4 = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2B")]
		[Cpp2IlInjected.Address(RVA = "0x794280", Offset = "0x792C80", VA = "0x180794280")]
		private void OnItemRemoved(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason)
		{
			//Discarded unreachable code: IL_0039, IL_005c, IL_0062, IL_0068, IL_006e
			//IL_005b: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			int num = 0;
			if (amount != 0)
			{
				bool flag = default(bool);
				if (flag)
				{
				}
				ItemType itemType = default(ItemType);
				bool flag2 = default(bool);
				ActivityItemType activityItemType = default(ActivityItemType);
				BuffElixirItemData buffElixirItemData = default(BuffElixirItemData);
				if (itemType == ItemType.ActivityItem && flag2 && activityItemType == ActivityItemType.BuffElixir && buffElixirItemData.endConditionCase_ == BuffElixirItemData.EndConditionOneofCase.NumberOfUses)
				{
					int numberOfUses = buffElixirItemData.NumberOfUses;
				}
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2C")]
		[Cpp2IlInjected.Address(RVA = "0x79BF00", Offset = "0x79A900", VA = "0x18079BF00")]
		private void TrackCollectFlowerClamEtcInVillage(Item item, int amount, string source)
		{
			//Discarded unreachable code: IL_000c, IL_0021
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2D")]
		[Cpp2IlInjected.Address(RVA = "0x79C010", Offset = "0x79AA10", VA = "0x18079C010")]
		private void TrackConsumeChestInInventory(MultiItemInstance rewards, int boxIndex)
		{
			//Discarded unreachable code: IL_003d, IL_0042, IL_0048, IL_0080, IL_0086, IL_008c, IL_0092
			int num = 0;
			int num2 = 0;
			if (rewards == null)
			{
				return;
			}
			RepeatedField<ItemInstance> items_ = rewards.items_;
			if (items_ == null || ((RepeatedField<T>)(object)items_).Count == 0)
			{
				return;
			}
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			RepeatedField<ItemInstance> items_2 = rewards.items_;
			bool flag = default(bool);
			if (flag)
			{
				while (num2 == 0)
				{
				}
				throw new NullReferenceException();
			}
			TransactionEvent transactionEvent = default(TransactionEvent);
			TrackingProducts t = default(TrackingProducts);
			((TrackingEventBase)transactionEvent).AddComplexParameter<object>((object)t, "ProductsReceived");
			((TrackingEventBase)transactionEvent).AddParameter<string>("pickup", "TransactionType");
			string arg = default(string);
			string text = string.Format("[Tracking] {0} exception: {1}", arg, "pickup");
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2E")]
		[Cpp2IlInjected.Address(RVA = "0x794E10", Offset = "0x793810", VA = "0x180794E10")]
		private void OnMealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene)
		{
			//Discarded unreachable code: IL_0013, IL_004e, IL_0055, IL_0079, IL_007f
			//IL_0028: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			int itemID = mealItem.ItemID;
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B2F")]
		[Cpp2IlInjected.Address(RVA = "0x7980A0", Offset = "0x796AA0", VA = "0x1807980A0")]
		private void OnShopItemsSold(string shopName, IInventory inventory, IEnumerable<ItemInstance> items, IEnumerable<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106, IL_010c, IL_0112, IL_0118, IL_011e, IL_0124
			uint num2 = default(uint);
			uint num3 = default(uint);
			List<CurrencyCost> list = default(List<CurrencyCost>);
			uint num4 = default(uint);
			Item item = default(Item);
			IItemData itemData = default(IItemData);
			TrackingVirtualCurrency item3 = default(TrackingVirtualCurrency);
			TrackingProducts productsSpent = default(TrackingProducts);
			TrackingProducts trackingProducts = default(TrackingProducts);
			TransactionEvent transactionEvent = default(TransactionEvent);
			string arg = default(string);
			while (true)
			{
				int num = 0;
				if (items == null || Enumerable.Count<ItemInstance>((IEnumerable<>)items) == 0)
				{
					break;
				}
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_00b8;
					}
					num++;
				}
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (list != null)
				{
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_00c6;
						}
						num++;
					}
					num++;
					List<TrackingItem> list2 = (List<TrackingItem>)(object)new List<T>();
					List<TrackingVirtualCurrency> list3 = (List<TrackingVirtualCurrency>)(object)new List<T>();
					int itemID = item.ItemID;
					TrackingItem item2 = TrackingEventsUtil.BuildItemProduct(itemData, itemID);
					((List<T>)(object)list2).Add((T)item2);
					((List<T>)(object)list3).Add((T)item3);
					TrackingItem[] array = (TrackingItem[])(object)((List<T>)(object)list2).ToArray();
					transactionEvent.ProductsSpent = productsSpent;
					TrackingVirtualCurrency[] array2 = (TrackingVirtualCurrency[])(object)((List<T>)(object)list3).ToArray();
					transactionEvent.ProductsReceived = trackingProducts;
					transactionEvent.TransactionType = "trading";
					goto IL_00b8;
				}
				goto IL_00cd;
				IL_00b8:
				transactionEvent = (TransactionEvent)(object)((object)transactionEvent + (object)transactionEvent);
				transactionEvent = (TransactionEvent)(object)((object)transactionEvent + (object)transactionEvent);
				goto IL_00c6;
				IL_00cd:
				if (list != null)
				{
				}
				if (num == 0)
				{
					string text = $"[Tracking] {arg} exception: {trackingProducts}";
					break;
				}
				continue;
				IL_00c6:
				transactionEvent = (TransactionEvent)(object)((object)transactionEvent + (object)transactionEvent);
				goto IL_00cd;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B30")]
		[Cpp2IlInjected.Address(RVA = "0x797620", Offset = "0x796020", VA = "0x180797620")]
		private void OnShopItemBought(string shopName, Item item, int amount, CurrencyCost cost, bool isDelivery)
		{
			//Discarded unreachable code: IL_010b, IL_0111, IL_0117, IL_011d, IL_0123, IL_0129, IL_012f
			//IL_0032: Expected O, but got I4
			//IL_0065: Expected I4, but got O
			//IL_009f: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00dc: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			if (amount == 0)
			{
				return;
			}
			string text = "ItemBoughtType" + shopName;
			string arg = default(string);
			if (text != null || text != null || text != null)
			{
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Clothing)
				{
				}
				ItemType itemType2 = default(ItemType);
				if (itemType2 == ItemType.Furniture)
				{
				}
				ItemType itemType3 = default(ItemType);
				arg = $"ItemBoughtItemType{itemType3}";
			}
			List<TrackingItem> list = (List<TrackingItem>)(object)new List<T>();
			IItemData itemData = default(IItemData);
			TrackingItem item2 = TrackingEventsUtil.BuildItemProduct(itemData, amount);
			((List<T>)(object)list).Add((T)item2);
			List<TrackingVirtualCurrency> list2 = (List<TrackingVirtualCurrency>)(object)new List<T>();
			TrackingVirtualCurrency trackingVirtualCurrency = new TrackingVirtualCurrency();
			trackingVirtualCurrency.virtualCurrencyAmount = (int)list2;
			IItemData virtualCurrencyName = default(IItemData);
			trackingVirtualCurrency.virtualCurrencyName = (string)(object)virtualCurrencyName;
			trackingVirtualCurrency.virtualCurrencyType = "GRIND";
			((List<T>)(object)list2).Add((T)trackingVirtualCurrency);
			int num = 0;
			TrackingVirtualCurrency[] virtualCurrencies = (TrackingVirtualCurrency[])(object)((List<T>)(object)list2).ToArray();
			TrackingProducts trackingProducts = new TrackingProducts();
			trackingProducts.items = (TrackingItem[])num;
			trackingProducts.realCurrency = (TrackingRealCurrency)num;
			trackingProducts.virtualCurrencies = virtualCurrencies;
			TransactionEvent transactionEvent = default(TransactionEvent);
			transactionEvent.ProductsSpent = trackingProducts;
			TrackingItem[] items = (TrackingItem[])(object)((List<T>)(object)list).ToArray();
			TrackingProducts trackingProducts2 = new TrackingProducts();
			trackingProducts2.items = items;
			trackingProducts2.realCurrency = (TrackingRealCurrency)num;
			trackingProducts2.virtualCurrencies = (TrackingVirtualCurrency[])num;
			transactionEvent.ProductsReceived = trackingProducts2;
			transactionEvent.TransactionType = "trading";
			string text2 = $"[Tracking] {arg} exception: {list2}";
		}

		[Cpp2IlInjected.Token(Token = "0x6005B31")]
		[Cpp2IlInjected.Address(RVA = "0x799FD0", Offset = "0x7989D0", VA = "0x180799FD0")]
		private void OnVillageAreaUnlocked(VillageAreaType areaType, [Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_0076, IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			string t = string.Format("{0}", "");
			TransactionEvent transactionEvent = default(TransactionEvent);
			((TrackingEventBase)transactionEvent).AddParameter<string>(t, "ObjectName");
			((TrackingEventBase)transactionEvent).AddParameter<string>("unlock", "TransactionType");
			if (costs != null)
			{
				List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
				bool flag = default(bool);
				if (flag)
				{
					TrackingVirtualCurrency item = default(TrackingVirtualCurrency);
					((List<T>)(object)list).Add((T)item);
				}
				int num4 = 0;
				TrackingVirtualCurrency[] array = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
				TrackingProducts productsSpent = default(TrackingProducts);
				transactionEvent.ProductsSpent = productsSpent;
			}
			string arg = default(string);
			string text = $"[Tracking] {arg} exception: {costs}";
		}

		[Cpp2IlInjected.Token(Token = "0x6005B32")]
		[Cpp2IlInjected.Address(RVA = "0x796B10", Offset = "0x795510", VA = "0x180796B10")]
		private void OnPlayerHouseRoomExpanded(int sizeX, int sizeY, int floorIndex, House.Types.RoomSlot roomSlot, List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_0044
			object[] array;
			while (true)
			{
				array = new object[4];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				if (array == null || array != null)
				{
					array[1] = array;
					if (array == null || array != null)
					{
						break;
					}
				}
			}
			array[2] = array;
			string text = string.Format("RoomExpanded NewSize:({0}x{1}) FloorIndex:{2} RoomSlot:{3}", array);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B33")]
		[Cpp2IlInjected.Address(RVA = "0x796A60", Offset = "0x795460", VA = "0x180796A60")]
		private void OnPlayerHouseRoomAdded(int floorIndex, House.Types.RoomSlot roomSlot, List<CurrencyCost> cost)
		{
			string text = string.Format("AddRoom FloorIndex:{0} RoomSlot:{1}", "AddRoom FloorIndex:{0} RoomSlot:{1}", "AddRoom FloorIndex:{0} RoomSlot:{1}");
			this.PlayerHouseExpansion(text, (List<>)(object)cost);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B34")]
		[Cpp2IlInjected.Address(RVA = "0x796930", Offset = "0x795330", VA = "0x180796930")]
		private void OnPlayerHouseFloorAdded([Optional] CurrencyCost cost)
		{
			//Discarded unreachable code: IL_0042
			//IL_0038: Expected O, but got I4
			List<CurrencyCost> list = (List<CurrencyCost>)(object)new List<T>();
			((List<T>)(object)list).Add((T)cost);
			int count = ((RepeatedField<T>)(object)clientData.profile.world_.playerHouse_.floors_).Count;
			string text = $"AddFloor TotalFloors:{count}";
			this.PlayerHouseExpansion(text, (List<>)(object)list);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B35")]
		[Cpp2IlInjected.Address(RVA = "0x78FEF0", Offset = "0x78E8F0", VA = "0x18078FEF0")]
		private void OnBuildingUnlocked(Item item, [Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_00bb, IL_00c1, IL_00c7, IL_00cd, IL_00d3, IL_00d9, IL_00df, IL_00e5, IL_00eb
			int num = 0;
			int num2 = 0;
			int addToItemsInBP = 0;
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (itemData != null)
			{
				if (itemData != null)
				{
					string type = default(string);
					string result = default(string);
					TrackActivity("UnlockActivityFeatures", "", type, result);
				}
				bool flag = default(bool);
				if (flag)
				{
				}
				ClientData clientData = this.clientData;
				Character hangingOutWithCharacter = HangingOutWithCharacter;
				string transactionLocation = default(string);
				TransactionEvent transactionEvent = new TransactionEvent("UnlockTeleport", clientData, hangingOutWithCharacter, addToItemsInBP, transactionLocation);
				string t = default(string);
				((TrackingEventBase)transactionEvent).AddParameter<string>(t, "ObjectName");
				((TrackingEventBase)transactionEvent).AddParameter<string>("unlock", "TransactionType");
				if (costs != null)
				{
					List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
					bool flag2 = default(bool);
					if (flag2)
					{
						while ((long)(IntPtr)hangingOutWithCharacter <= 0L)
						{
						}
						TrackingVirtualCurrency item2 = default(TrackingVirtualCurrency);
						((List<T>)(object)list).Add((T)item2);
					}
					int num3 = 0;
					TrackingVirtualCurrency[] array = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
					TrackingProducts productsSpent = default(TrackingProducts);
					transactionEvent.ProductsSpent = productsSpent;
				}
			}
			string arg = default(string);
			string text = string.Format("[Tracking] {0} exception: {1}", arg, "UnlockBuilding");
		}

		[Cpp2IlInjected.Token(Token = "0x6005B36")]
		[Cpp2IlInjected.Address(RVA = "0x797C00", Offset = "0x796600", VA = "0x180797C00")]
		private void OnShopItemsRefreshed(string shopName, Item item, CurrencyCost refreshCost, bool isFreeRefresh)
		{
			//Discarded unreachable code: IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100
			//IL_00bb: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			if (1 == 0)
			{
				ClientData clientData = this.clientData;
				Character hangingOutWithCharacter = HangingOutWithCharacter;
				int addToItemsInBP = default(int);
				TransactionEvent transactionEvent = new TransactionEvent("RefreshShop", clientData, hangingOutWithCharacter, addToItemsInBP, shopName);
				addToItemsInBP = 0;
				string t = "ShotType:" + shopName;
				((TrackingEventBase)transactionEvent).AddParameter<string>(t, "ObjectName");
				((TrackingEventBase)transactionEvent).AddParameter<string>("trading", "TransactionType");
				List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
				int amount_ = refreshCost.amount_;
				ItemDatabase itemDatabase = ItemDatabase.Instance;
				Item item2 = refreshCost.Item;
				TrackingVirtualCurrency trackingVirtualCurrency = new TrackingVirtualCurrency();
				trackingVirtualCurrency.virtualCurrencyAmount = amount_;
				IItemData virtualCurrencyName = default(IItemData);
				trackingVirtualCurrency.virtualCurrencyName = (string)(object)virtualCurrencyName;
				trackingVirtualCurrency.virtualCurrencyType = "GRIND";
				((List<T>)(object)list).Add((T)trackingVirtualCurrency);
				TrackingVirtualCurrency[] virtualCurrencies = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
				TrackingProducts trackingProducts = new TrackingProducts();
				int num = 0;
				trackingProducts.items = (TrackingItem[])num;
				trackingProducts.realCurrency = (TrackingRealCurrency)num;
				trackingProducts.virtualCurrencies = virtualCurrencies;
				((TrackingEventBase)transactionEvent).AddComplexParameter<object>((object)trackingProducts, "ProductsSpent");
				TrackEvent(transactionEvent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B37")]
		[Cpp2IlInjected.Address(RVA = "0x78F160", Offset = "0x78DB60", VA = "0x18078F160")]
		private void OnAvatarCustomizationChanged(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures)
		{
			//Discarded unreachable code: IL_00b6, IL_00bc, IL_00c2, IL_00ce, IL_00da, IL_00e0, IL_00e6, IL_00ec
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (success)
			{
				CustomizationEvent customizationEvent = new CustomizationEvent(clientData);
				customizationEvent.ObjectName = "Avatar";
				int num4 = ((customizationEvent.Touchofmagic = false) ? 1 : 0);
				int size = ((List<>)(object)newEquippedClothes)._size;
				int size2 = ((List<>)(object)newEquippedFeatures)._size;
				size2 = (customizationEvent.NbChanges = size2 + size);
				List<TrackingItem> list = (List<TrackingItem>)(object)new List<T>();
				bool flag2 = default(bool);
				if (flag2)
				{
					IItemData itemData = default(IItemData);
					TrackingItem item = TrackingEventsUtil.BuildItemProduct(itemData, 1);
					((List<T>)(object)list).Add((T)item);
				}
				if (newEquippedFeatures != null)
				{
					throw new NullReferenceException();
				}
				bool flag3 = default(bool);
				if (flag3)
				{
					IItemData itemData2 = default(IItemData);
					TrackingItem item2 = TrackingEventsUtil.BuildItemProduct(itemData2, 1);
					((List<T>)(object)list).Add((T)item2);
				}
				if (newEquippedFeatures != null)
				{
					throw new NullReferenceException();
				}
				TrackingProducts trackingProducts = default(TrackingProducts);
				TrackingItem[] array = (trackingProducts.items = (TrackingItem[])(object)((List<T>)(object)list).ToArray());
				customizationEvent.ProductsSpent = trackingProducts;
				string text = $"[Tracking] OnAvatarCustomizationChanged exception: {list}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B38")]
		[Cpp2IlInjected.Address(RVA = "0x790F10", Offset = "0x78F910", VA = "0x180790F10")]
		private void OnClothingDesignSaved(Item clothingItem, int nbChanges)
		{
			//Discarded unreachable code: IL_00b5, IL_00bb, IL_00c1, IL_00c7, IL_00cd, IL_00d3, IL_00d9, IL_00df, IL_00e5, IL_00eb, IL_00f1
			CustomizationEvent customizationEvent = new CustomizationEvent(clientData);
			customizationEvent.ObjectName = "Avatar";
			customizationEvent.Touchofmagic = true;
			customizationEvent.NbChanges = nbChanges;
			int num = (customizationEvent.Touchofmagicmax = clientData.profile.player_.clothingDesignLimitReachedCount_);
			ProfilePlayer player_ = clientData.profile.player_;
			bool avatarIsMale_ = player_.avatarIsMale_;
			int num2 = (customizationEvent.Touchofmagicdesigns = player_.GetDesignCount(avatarIsMale_));
			List<TrackingItem> list = (List<TrackingItem>)(object)new List<T>();
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			TrackingItem item = TrackingEventsUtil.BuildItemProduct(itemData, 1);
			((List<T>)(object)list).Add((T)item);
			TrackingProducts trackingProducts = new TrackingProducts();
			TrackingItem[] array = (trackingProducts.items = (TrackingItem[])(object)((List<T>)(object)list).ToArray());
			customizationEvent.ProductsSpent = trackingProducts;
			TrackEvent(customizationEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B39")]
		[Cpp2IlInjected.Address(RVA = "0x792870", Offset = "0x791270", VA = "0x180792870")]
		private void OnFtueEventComplete(Item ftueItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B3A")]
		[Cpp2IlInjected.Address(RVA = "0x7928C0", Offset = "0x7912C0", VA = "0x1807928C0")]
		private void OnFtueEventStart(Item ftueItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B3B")]
		[Cpp2IlInjected.Address(RVA = "0x7987A0", Offset = "0x7971A0", VA = "0x1807987A0")]
		private void OnStartEndActivity(string ActivityName, bool ended = false)
		{
			//Discarded unreachable code: IL_001c, IL_0022
			string status = "Started";
			if (ended)
			{
				status = "Ending";
			}
			string result = default(string);
			TrackActivity(ActivityName, status, ActivityName, result);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B3C")]
		[Cpp2IlInjected.Address(RVA = "0x7993C0", Offset = "0x797DC0", VA = "0x1807993C0")]
		private void OnUIEvent(string uiAction, string uiName, string uiLocation)
		{
			//Discarded unreachable code: IL_0150, IL_0156, IL_015c, IL_0162
			if (uiName.ToLower().Contains("popup") || uiName.Contains("Dreamlight") || uiName.Contains("Collection") || uiName.Contains("Map") || uiName.Contains("Gardening") || uiName.Contains("QuestLog") || uiName.Contains("Achievement") || uiName.Contains("Settings") || uiName.Contains("StarPath") || uiName.Contains("Events") || uiName.Contains("Shop") || uiName.Contains("Catalog") || uiName.Contains("Wardrobe") || uiName.Contains("Dialogue") || uiName.Contains("HouseExpansion") || uiName.Contains("Fishing") || uiName.Contains("Cooking") || uiName.Contains("WindowArt") || uiName.Contains("Wall") || uiName.Contains("RealmDoor"))
			{
				TrackUIInteraction(uiAction, uiLocation, "popup", uiName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B3D")]
		[Cpp2IlInjected.Address(RVA = "0x7959A0", Offset = "0x7943A0", VA = "0x1807959A0")]
		private void OnNPCInteractionEvent(Item characterItem, string interactionType)
		{
			//Discarded unreachable code: IL_0046, IL_004c, IL_0052, IL_0058, IL_005e, IL_0064
			int num = 0;
			NPCInteractionEvent nPCInteractionEvent = new NPCInteractionEvent(clientData);
			string text = default(string);
			nPCInteractionEvent.CharacterID = text;
			if (text != null)
			{
			}
			string characterName = default(string);
			nPCInteractionEvent.CharacterName = characterName;
			nPCInteractionEvent.InteractionType = interactionType;
			ProfileWorld world_ = clientData.profile.world_;
			bool flag = default(bool);
			if (flag)
			{
			}
			TrackEvent(nPCInteractionEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B3E")]
		[Cpp2IlInjected.Address(RVA = "0x791D10", Offset = "0x790710", VA = "0x180791D10")]
		private void OnCritterFed(Critter critter, FeedCritterDetails details)
		{
			//Discarded unreachable code: IL_000c, IL_0022, IL_0028, IL_002e
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B3F")]
		[Cpp2IlInjected.Address(RVA = "0x79E8B0", Offset = "0x79D2B0", VA = "0x18079E8B0")]
		private unsafe void TrackUIInteraction(string uiAction, string uiLocation, string uiType, string uiName)
		{
			//Discarded unreachable code: IL_0074, IL_007a, IL_0080, IL_0086, IL_008c, IL_0092, IL_0098, IL_009e
			//IL_001a: Expected O, but got I4
			//IL_003b: Expected I4, but got O
			//IL_0047: Expected I4, but got O
			//IL_0053: Expected I4, but got O
			int num = 0;
			Dictionary<string, UIInteractionData> dictionary = uiInteractions;
			bool flag = default(bool);
			if (!flag)
			{
				UIInteractionData uIInteractionData = new UIInteractionData();
				uIInteractionData.UiName = (string)0;
				uIInteractionData.CountAction = num;
				Dictionary<string, UIInteractionData> dictionary2 = uiInteractions;
				throw new NullReferenceException();
			}
			num += 24;
			((int*)num)->m_value = (int)uiAction;
			num += 32;
			((int*)num)->m_value = (int)uiLocation;
			num += 40;
			((int*)num)->m_value = (int)uiType;
			int num2 = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = lastUIInteraction;
			lastUIInteraction = utcNow;
			FlushAllUIInteractions();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B40")]
		[Cpp2IlInjected.Address(RVA = "0x78D6B0", Offset = "0x78C0B0", VA = "0x18078D6B0")]
		private void FlushAllUIInteractions()
		{
			//Discarded unreachable code: IL_001f, IL_0025
			Dictionary<string, UIInteractionData> dictionary = uiInteractions;
			bool flag = default(bool);
			if (flag)
			{
				UIInteractionEvent trackingEvent = new UIInteractionEvent(clientData);
				TrackEvent(trackingEvent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B41")]
		[Cpp2IlInjected.Address(RVA = "0x792910", Offset = "0x791310", VA = "0x180792910")]
		private void OnFtueEventUpdate(Item ftueItem, string status)
		{
			//Discarded unreachable code: IL_0072, IL_0078, IL_007e, IL_0084
			int itemID = ftueItem.ItemID;
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			QuestsEvent questsEvent = new QuestsEvent(clientData);
			FtueItemData ftueItemData = default(FtueItemData);
			if (ftueItemData == null || ftueItemData.displayName_ == null)
			{
			}
			questsEvent.QuestIssuerName = "None";
			string text = (questsEvent.MissionName = ftueItemData.name_);
			questsEvent.IsTutorial = true;
			string missionID = default(string);
			questsEvent.MissionID = missionID;
			questsEvent.MissionType = "FTUEEvent";
			questsEvent.MissionStatus = status;
			TrackEvent(questsEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B42")]
		[Cpp2IlInjected.Address(RVA = "0x79D970", Offset = "0x79C370", VA = "0x18079D970")]
		private void TrackReceivedItems(Dictionary<Item, int> items, string transactionName, [Optional] Item? characterItem, bool burningState = false, bool addItemsAmount = false, string transactionType = "", [Optional] string missionName, [Optional] string source)
		{
			//Discarded unreachable code: IL_0055, IL_005b, IL_0061, IL_0067, IL_006d, IL_0073
			int num = 0;
			int num2 = 0;
			if (items != null && ((Dictionary<TKey, TValue>)(object)items).Count != 0)
			{
				List<TrackingItem> list = (List<TrackingItem>)(object)new List<T>();
				bool flag = default(bool);
				if (flag)
				{
					TrackingItem item = default(TrackingItem);
					((List<T>)(object)list).Add((T)item);
				}
				int num3 = 0;
				TrackingProducts trackingProducts = default(TrackingProducts);
				TrackingItem[] array = (trackingProducts.items = (TrackingItem[])(object)((List<T>)(object)list).ToArray());
				TransactionEvent transactionEvent = default(TransactionEvent);
				transactionEvent.ProductsReceived = trackingProducts;
				if (array == null)
				{
				}
				if (array == null)
				{
				}
				string characterID = default(string);
				transactionEvent.CharacterID = characterID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B43")]
		[Cpp2IlInjected.Address(RVA = "0x79E0E0", Offset = "0x79CAE0", VA = "0x18079E0E0")]
		private void TrackSpentItems(string missionName, Dictionary<(Item item, ItemState state), int> items, string transactionName, [Optional] Item? characterItem)
		{
			//Discarded unreachable code: IL_0010, IL_0014, IL_001a, IL_0021, IL_0027
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			bool flag = default(bool);
			if (flag)
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B44")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79CD60", VA = "0x18079E360")]
		private void TrackSpentItems(string missionName, Dictionary<Item, int> items, string transactionName, [Optional] Item? characterItem, [Optional] int? staminaGained, [Optional] int? gainedBuff, string location = "")
		{
			//Discarded unreachable code: IL_0070, IL_0076, IL_007c, IL_0082, IL_0088, IL_008e
			int num = 0;
			int num2 = 0;
			if (items != null && ((Dictionary<TKey, TValue>)(object)items).Count != 0)
			{
				List<TrackingItem> list = (List<TrackingItem>)(object)new List<T>();
				bool flag = default(bool);
				if (flag)
				{
					TrackingItem item = default(TrackingItem);
					((List<T>)(object)list).Add((T)item);
				}
				int num3 = 0;
				TrackingProducts trackingProducts = default(TrackingProducts);
				TrackingItem[] array = (trackingProducts.items = (TrackingItem[])(object)((List<T>)(object)list).ToArray());
				TransactionEvent transactionEvent = default(TransactionEvent);
				transactionEvent.ProductsSpent = trackingProducts;
				if (array == null)
				{
				}
				string characterID = default(string);
				transactionEvent.CharacterID = characterID;
				int t = default(int);
				((TrackingEventBase)transactionEvent).AddParameter<int>(t, "StaminaGained");
				int num4 = default(int);
				t = num4;
				((TrackingEventBase)transactionEvent).AddParameter<int>(t, "GainedBuff");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B45")]
		[Cpp2IlInjected.Address(RVA = "0x79DE60", Offset = "0x79C860", VA = "0x18079DE60")]
		private void TrackReceivedRewards(List<AnyReward> rewards, string transactionName, [Optional] string source, [Optional] int? characterId)
		{
			//Discarded unreachable code: IL_0065, IL_006b, IL_0071
			if (rewards == null)
			{
				return;
			}
			Dictionary<Item, int> rewardsAsDictionary = (Dictionary<Item, int>)(object)this.GetRewardsAsDictionary((List<>)(object)rewards);
			if (((Dictionary<TKey, TValue>)(object)rewardsAsDictionary).Count != 0)
			{
				ClientData clientData = this.clientData;
				Character hangingOutWithCharacter = HangingOutWithCharacter;
				string transactionLocation = default(string);
				int addToItemsInBP = default(int);
				TransactionEvent transactionEvent = new TransactionEvent(transactionName, clientData, hangingOutWithCharacter, addToItemsInBP, transactionLocation);
				addToItemsInBP = 0;
				TrackingProducts trackingProducts = (TrackingProducts)(transactionEvent.ProductsReceived = this.GetProductsObject((Dictionary<, >)(object)rewardsAsDictionary));
				string characterID = default(string);
				transactionEvent.CharacterID = characterID;
				if (trackingProducts == null)
				{
					transactionEvent.EarningSource = source;
				}
				TrackEvent(transactionEvent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B46")]
		[Cpp2IlInjected.Address(RVA = "0x78E080", Offset = "0x78CA80", VA = "0x18078E080")]
		private Dictionary<Item, int> GetRewardsAsDictionary(List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_0033, IL_0038, IL_0057, IL_0068, IL_006e, IL_0074, IL_007a, IL_0080, IL_0086, IL_008c, IL_0092
			Dictionary<Item, int> result = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			bool flag = default(bool);
			if (rewards != null && flag)
			{
				ItemReward itemReward = default(ItemReward);
				while (itemReward == null)
				{
				}
				Item item = itemReward.Item;
				ItemReward itemReward2 = default(ItemReward);
				while (itemReward2.amount_ <= 0)
				{
				}
				ItemReward itemReward3 = default(ItemReward);
				Item item2 = itemReward3.Item;
				throw new NullReferenceException();
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B47")]
		[Cpp2IlInjected.Address(RVA = "0x78DF80", Offset = "0x78C980", VA = "0x18078DF80")]
		private TrackingProducts GetProductsObject(Dictionary<Item, int> items)
		{
			//IL_0014: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			TrackingProducts trackingProducts = new TrackingProducts();
			trackingProducts.items = (TrackingItem[])num;
			trackingProducts.virtualCurrencies = (TrackingVirtualCurrency[])num2;
			return trackingProducts;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B48")]
		[Cpp2IlInjected.Address(RVA = "0x78E330", Offset = "0x78CD30", VA = "0x18078E330")]
		private TrackingRewards GetRewardsObject(string rewardName, Dictionary<Item, int> rewards)
		{
			//IL_001c: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			TrackingRewards trackingRewards = new TrackingRewards();
			trackingRewards.rewardName = rewardName;
			trackingRewards.items = (TrackingItem[])num;
			trackingRewards.virtualCurrencies = (TrackingVirtualCurrency[])num2;
			return trackingRewards;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B49")]
		[Cpp2IlInjected.Address(RVA = "0x78DBE0", Offset = "0x78C5E0", VA = "0x18078DBE0")]
		private (List<TrackingItem>, List<TrackingVirtualCurrency>) GetProductsAndVirtualCurrency(Dictionary<Item, int> items)
		{
			//Discarded unreachable code: IL_003b, IL_0041, IL_0047, IL_004d
			int num = 0;
			int num2 = default(int);
			if (num2 != 0)
			{
				List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
				List<TrackingItem> list2 = (List<TrackingItem>)(object)new List<T>();
				bool flag = default(bool);
				if (flag)
				{
					ItemType itemType = default(ItemType);
					if (itemType != ItemType.Currency)
					{
						TrackingItem item = default(TrackingItem);
						((List<T>)(object)list2).Add((T)item);
					}
					TrackingVirtualCurrency item2 = default(TrackingVirtualCurrency);
					((List<T>)(object)list).Add((T)item2);
				}
			}
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4A")]
		[Cpp2IlInjected.Address(RVA = "0x79A4F0", Offset = "0x798EF0", VA = "0x18079A4F0")]
		private void PlayerHouseExpansion(string expansionInfo, [Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_0061, IL_0067, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			TransactionEvent transactionEvent = default(TransactionEvent);
			((TrackingEventBase)transactionEvent).AddParameter<string>(expansionInfo, "ObjectName");
			((TrackingEventBase)transactionEvent).AddParameter<string>("upgrade", "TransactionType");
			List<TrackingVirtualCurrency> list = (List<TrackingVirtualCurrency>)(object)new List<T>();
			if (costs != null)
			{
				bool flag = default(bool);
				if (flag)
				{
					TrackingVirtualCurrency item = default(TrackingVirtualCurrency);
					((List<T>)(object)list).Add((T)item);
				}
				int num4 = 0;
				TrackingVirtualCurrency[] array = (TrackingVirtualCurrency[])(object)((List<T>)(object)list).ToArray();
				TrackingProducts productsSpent = default(TrackingProducts);
				transactionEvent.ProductsSpent = productsSpent;
			}
			string arg = default(string);
			string text = $"[Tracking] {arg} exception: {costs}";
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4B")]
		[Cpp2IlInjected.Address(RVA = "0x79B9E0", Offset = "0x79A3E0", VA = "0x18079B9E0")]
		private void TrackActivity(string name, string status, string type, string result)
		{
			//Discarded unreachable code: IL_0061, IL_0067, IL_006d, IL_0073
			ActivitiesEvent activitiesEvent = new ActivitiesEvent(clientData);
			activitiesEvent.ActivityName = name;
			activitiesEvent.ActivityType = type;
			Character hangingOutWithCharacter = HangingOutWithCharacter;
			if (hangingOutWithCharacter != null)
			{
				string text = (activitiesEvent.CharacterName = hangingOutWithCharacter.Data.name_);
				ProfessionItemData profession = HangingOutWithCharacter.Profession;
				string empty = default(string);
				if (profession == null || profession.name_ == null)
				{
					empty = string.Empty;
				}
				activitiesEvent.CharacterProfession = empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4C")]
		[Cpp2IlInjected.Address(RVA = "0x798C50", Offset = "0x797650", VA = "0x180798C50")]
		private void OnTrackClientInfo(ClientData clientData)
		{
			//Discarded unreachable code: IL_0039, IL_003f, IL_0045
			ClientInfoEvent clientInfoEvent = new ClientInfoEvent(clientData);
			string text = (clientInfoEvent.buildFullName = clientData.buildFullName);
			string text2 = (clientInfoEvent.PlayfabEntityId = clientData.playfabEntityId);
			string text3 = (clientInfoEvent.ClientStore = clientData.clientStore);
			TrackEvent(clientInfoEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4D")]
		[Cpp2IlInjected.Address(RVA = "0x799280", Offset = "0x797C80", VA = "0x180799280")]
		private void OnTrackSNSUserInfo()
		{
			//Discarded unreachable code: IL_000e, IL_0014
			PlatformIDManagerEvent trackingEvent = new PlatformIDManagerEvent();
			TrackEvent(trackingEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4E")]
		[Cpp2IlInjected.Address(RVA = "0x78E450", Offset = "0x78CE50", VA = "0x18078E450")]
		private (string, int) GetSNUserInfo()
		{
			//IL_002e: Expected O, but got I4
			App.RuntimePlatform _003CCurrentPlatform_003Ek__BackingField = App.CurrentPlatform;
			IUserInfo _003CUserInfo_003Ek__BackingField = App.UserInfo;
			if (_003CCurrentPlatform_003Ek__BackingField != App.RuntimePlatform.PS4)
			{
				if (_003CCurrentPlatform_003Ek__BackingField > (App.RuntimePlatform)6)
				{
					goto IL_001d;
				}
				int num = (int)_003CCurrentPlatform_003Ek__BackingField;
			}
			IUserInfo _003CUserInfo_003Ek__BackingField2 = App.UserInfo;
			goto IL_001d;
			IL_001d:
			int num2 = default(int);
			string text = string.Format("[Tracking] UserID {0}, PlatformType {1}", "N/A", num2);
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4F")]
		[Cpp2IlInjected.Address(RVA = "0x795C10", Offset = "0x794610", VA = "0x180795C10")]
		private void OnPhotoEvent(string photoId, string photoType, string animationType, string animationName, string frameName, string orientationState, string backgroundName, string characterName, string filterName, string avatarState, bool DDVLogo, string pictureState, List<Item> equipedItems, Dictionary<string, int> appearanceConfig, int galleryMax, int photoCountGallery)
		{
			//Discarded unreachable code: IL_0078, IL_007e, IL_0084, IL_008a, IL_0090, IL_0096, IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			PhotoEvent photoEvent = new PhotoEvent(clientData);
			photoEvent.PhotoID = photoId;
			photoEvent.PhotoType = photoType;
			photoEvent.AnimationType = animationType;
			List<TrackingItem> list = (List<TrackingItem>)(object)new List<T>();
			bool flag = default(bool);
			if (flag)
			{
				IItemData itemData = default(IItemData);
				TrackingItem item = TrackingEventsUtil.BuildItemProduct(itemData, 1);
				((List<T>)(object)list).Add((T)item);
			}
			TrackingProducts trackingProducts = default(TrackingProducts);
			TrackingItem[] array = (trackingProducts.items = (TrackingItem[])(object)((List<T>)(object)list).ToArray());
			photoEvent.ProductsSpent = trackingProducts;
			string text = trackingProducts.ToString();
			string text2 = "[Tracking] OnPhotoEvent exception: " + text;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B50")]
		[Cpp2IlInjected.Address(RVA = "0x798DF0", Offset = "0x7977F0", VA = "0x180798DF0")]
		public void OnTrackRedeem(RedeemMarketplaceAssetsResult redeemResult)
		{
			//Discarded unreachable code: IL_00c8, IL_00ce, IL_00d4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (redeemResult.Succeeded != null && flag)
			{
				IAPData iAPData = default(IAPData);
				while (iAPData == null)
				{
				}
				IAPType iapType_ = iAPData.iapType_;
				string uniqueName_ = default(string);
				if (iapType_ != 0)
				{
					while (iapType_ != IAPType.MoonstonePack)
					{
					}
					RepeatedField<ItemAmount> rewards_ = iAPData.rewards_;
					Func<ItemAmount, bool> func = default(Func<ItemAmount, bool>);
					if (_003C_003Ec._003C_003E9__97_0 == null)
					{
						func = (Func<ItemAmount, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemAmount x)
						{
							//Discarded unreachable code: IL_000e
							int itemID = x.Item.ItemID;
							bool result = default(bool);
							return result;
						});
					}
					IEnumerable<ItemAmount> enumerable = (IEnumerable<ItemAmount>)Enumerable.Where<ItemAmount>((IEnumerable<>)(object)rewards_, (Func<, >)(object)func);
					Func<ItemAmount, int> func2 = default(Func<ItemAmount, int>);
					if (_003C_003Ec._003C_003E9__97_1 == null)
					{
						func2 = (Func<ItemAmount, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemAmount x) => x.amount_));
					}
					int num4 = Enumerable.Sum<ItemAmount>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
					uniqueName_ = iAPData.uniqueName_;
					int num5 = 0;
					Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
				}
				OnFoundersPackClaimedRedeemed(uniqueName_);
			}
			string text = redeemResult.ToString();
			string text2 = "[Tracking] TrackRedeem exception: " + text;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B51")]
		[Cpp2IlInjected.Address(RVA = "0x78D9D0", Offset = "0x78C3D0", VA = "0x18078D9D0")]
		public static int GetGlotID(Item item)
		{
			//Discarded unreachable code: IL_0017
			int itemID = item.ItemID;
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			IHasGlotID hasGlotID = default(IHasGlotID);
			if (hasGlotID == null || hasGlotID != null)
			{
			}
			return itemID;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B52")]
		[Cpp2IlInjected.Address(RVA = "0x78D870", Offset = "0x78C270", VA = "0x18078D870")]
		public static (int, int) GetCurrencyGlotIDs(Item item)
		{
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			IHasCurrencyGlotIDs hasCurrencyGlotIDs = default(IHasCurrencyGlotIDs);
			if (hasCurrencyGlotIDs == null)
			{
				int num = 0;
				int num2 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B55")]
		[Cpp2IlInjected.Address(RVA = "0x78E7B0", Offset = "0x78D1B0", VA = "0x18078E7B0")]
		public static void Init()
		{
			//Discarded unreachable code: IL_0067
			//IL_0010: Expected I4, but got I8
			TrackingManager trackingManager = new TrackingManager();
			trackingManager.UI_INTERACTION_INTERVAL = 10;
			List<TrackingConsumer> list = (trackingManager.consumers = (List<TrackingConsumer>)(object)new List<T>());
			ClientData clientData = (trackingManager.clientData = new ClientData());
			Instance = trackingManager;
			TrackingManager trackingManager2 = Instance;
			int num = 0;
			DateTime now = DateTime.Now;
			DateTime dateTime = default(DateTime);
			trackingManager2.lastUIInteraction = dateTime;
			Dictionary<string, UIInteractionData> dictionary = (trackingManager2.uiInteractions = (Dictionary<string, UIInteractionData>)(object)new Dictionary<TKey, TValue>());
			((List<T>)(object)Instance.consumers).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B56")]
		[Cpp2IlInjected.Address(RVA = "0x78EA40", Offset = "0x78D440", VA = "0x18078EA40")]
		public void Initialize()
		{
			int num = 0;
			DateTime now = DateTime.Now;
			DateTime dateTime = default(DateTime);
			lastUIInteraction = dateTime;
			Dictionary<string, UIInteractionData> dictionary = (uiInteractions = (Dictionary<string, UIInteractionData>)(object)new Dictionary<TKey, TValue>());
		}

		[Cpp2IlInjected.Token(Token = "0x6005B57")]
		[Cpp2IlInjected.Address(RVA = "0x79A9D0", Offset = "0x7993D0", VA = "0x18079A9D0")]
		public void RegisterListeners(ProfileEventDispatcher dispatcher, Profile profile)
		{
			//Discarded unreachable code: IL_04a9
			if (!profile.IsSimulatorClient)
			{
				ProfileEventDispatcher.PlayerXpGained value = TrackGainXP;
				dispatcher.OnPlayerXpGained += value;
				ProfileEventDispatcher.FriendshipAdded value2 = TrackLevelUpRewards;
				dispatcher.OnFriendshipAdded += value2;
				ProfileEventDispatcher.MealCooked value3 = OnMealCooked;
				dispatcher.OnMealCooked += value3;
				ProfileEventDispatcher.FishingResultReceived value4 = TrackCatchFish;
				dispatcher.OnFishingResultReceived += value4;
				ProfileEventDispatcher.LootPresentConsumed value5 = TrackConsumeChestInInventory;
				dispatcher.OnLootPresentConsumed += value5;
				ProfileEventDispatcher.ItemAdded value6 = OnItemAdded;
				dispatcher.OnItemAdded += value6;
				ProfileEventDispatcher.ItemRemoved value7 = OnItemRemoved;
				dispatcher.OnItemRemoved += value7;
				ProfileEventDispatcher.MissionItemAdded value8 = OnMissionItemAdded;
				dispatcher.OnMissionItemAdded += value8;
				ProfileEventDispatcher.MissionItemGiven value9 = TrackGiveQuestItem;
				dispatcher.OnMissionItemGiven += value9;
				ProfileEventDispatcher.GardeningEvent value10 = OnGardeningEvent;
				dispatcher.OnGardeningEvent += value10;
				ProfileEventDispatcher.GridChanged value11 = OnGridChanged;
				dispatcher.OnGridChanged += value11;
				ProfileEventDispatcher.MissionSlotUpdated value12 = OnMissionSlotUpdated;
				dispatcher.OnMissionSlotUpdated += value12;
				ProfileEventDispatcher.CharacterUnlocked value13 = TrackUnlockCharacter;
				dispatcher.OnCharacterUnlocked += value13;
				ProfileEventDispatcher.CharacterFriendshipChanged value14 = OnCharacterFriendshipChanged;
				dispatcher.OnCharacterFriendshipChanged += value14;
				ProfileEventDispatcher.CharacterFriendshipLevelChanged value15 = OnCharacterFriendshipLevelChanged;
				dispatcher.OnCharacterFriendshipLevelChanged += value15;
				ProfileEventDispatcher.SecretCharacterVisitStarted value16 = OnSecretCharacterVisitStarted;
				dispatcher.OnSecretCharacterVisitStarted += value16;
				ProfileEventDispatcher.PetUnlocked value17 = OnPetUnlocked;
				dispatcher.OnPetUnlocked += value17;
				ProfileEventDispatcher.ShopItemBought value18 = OnShopItemBought;
				dispatcher.OnShopItemBought += value18;
				ProfileEventDispatcher.ShopItemsSold value19 = OnShopItemsSold;
				dispatcher.OnShopItemsSold += value19;
				ProfileEventDispatcher.VillageAreaUnlocked value20 = OnVillageAreaUnlocked;
				dispatcher.OnVillageAreaUnlocked += value20;
				ProfileEventDispatcher.PlayerHouseFloorAdded value21 = OnPlayerHouseFloorAdded;
				dispatcher.OnPlayerHouseFloorAdded += value21;
				ProfileEventDispatcher.PlayerHouseRoomAdded value22 = OnPlayerHouseRoomAdded;
				dispatcher.OnPlayerHouseRoomAdded += value22;
				ProfileEventDispatcher.PlayerHouseRoomExpanded value23 = OnPlayerHouseRoomExpanded;
				dispatcher.OnPlayerHouseRoomExpanded += value23;
				ProfileEventDispatcher.BuildingUnlocked value24 = OnBuildingUnlocked;
				dispatcher.OnBuildingUnlocked += value24;
				ProfileEventDispatcher.ShopItemsRefreshed value25 = OnShopItemsRefreshed;
				dispatcher.OnShopItemsRefreshed += value25;
				ProfileEventDispatcher.AvatarCustomizationChanged value26 = OnAvatarCustomizationChanged;
				dispatcher.OnAvatarCustomizationChanged += value26;
				ProfileEventDispatcher.ClothingDesignSaved value27 = OnClothingDesignSaved;
				dispatcher.OnClothingDesignSaved += value27;
				ProfileEventDispatcher.FtueEventStart value28 = OnFtueEventStart;
				dispatcher.OnFtueEventStart += value28;
				ProfileEventDispatcher.FtueEventComplete value29 = OnFtueEventComplete;
				dispatcher.OnFtueEventComplete += value29;
				ProfileEventDispatcher.CritterFed value30 = OnCritterFed;
				dispatcher.OnCritterFed += value30;
				ProfileEventDispatcher.DutyAchRewardCollected value31 = OnDutyAchRewardsCollected;
				dispatcher.OnDutyAchRewardCollected += value31;
				ProfileEventDispatcher.BuidingUpgraded value32 = OnUpdateBuilding;
				dispatcher.OnBuidingUpgraded += value32;
				ProfileEventDispatcher.DutySlotUpdated value33 = OnDutyGenerated;
				dispatcher.OnDutySlotUpdated += value33;
				ProfileEventDispatcher.AchievementSetUpdated value34 = OnAchievementSetUpdated;
				dispatcher.OnAchievementSetUpdated += value34;
				ProfileEventDispatcher.RealmUnlocked value35 = OnRealmUnlocked;
				dispatcher.OnRealmUnlocked += value35;
				ProfileEventDispatcher.FishCollected value36 = OnFishCollected;
				dispatcher.OnFishCollected += value36;
				ProfileEventDispatcher.ItemsGivenToCharacter value37 = OnItemsGivenToCharacter;
				dispatcher.OnItemsGivenToCharacter += value37;
				ProfileEventDispatcher.RestaurantOrderFulfilled value38 = OnRestItemGiven;
				dispatcher.OnRestaurantOrderFulfilled += value38;
				ProfileEventDispatcher.CollectionRewardCollected value39 = OnCollectionRewardCollected;
				dispatcher.OnCollectionRewardCollected += value39;
				ProfileEventDispatcher.FlowerEvent value40 = OnFlowerEvent;
				dispatcher.OnFlowerEvent += value40;
				ProfileEventDispatcher.CurrencyChanged value41 = OnPickupCurrency;
				dispatcher.OnCurrencyChanged += value41;
				ProfileEventDispatcher.BattlePassTaskUpdate value42 = OnBattlePassTaskUpdate;
				dispatcher.OnBattlePassTaskUpdate += value42;
				ProfileEventDispatcher.BattlePassCurrencyChanged value43 = OnBattlePassCurrencyChanged;
				dispatcher.OnBattlePassCurrencyChanged += value43;
				ProfileEventDispatcher.MiningRockEmptied value44 = OnMiningRock;
				dispatcher.OnMiningRockEmptied += value44;
				ProfileEventDispatcher.AvatarRemoveBlocker value45 = OnAvatarRemoveBlocker;
				dispatcher.OnAvatarRemoveBlocker += value45;
				ProfileEventDispatcher.ItemMoved value46 = OnItemMoved;
				dispatcher.OnItemMoved += value46;
				ProfileEventDispatcher.CraftingCompleted value47 = OnCraftingCompleted;
				dispatcher.OnCraftingCompleted += value47;
				ProfileEventDispatcher.KeyholeItemAdded value48 = OnKeyholeItemAdded;
				dispatcher.OnKeyholeItemAdded += value48;
				ProfileEventDispatcher.KeyholeItemRemoved value49 = OnKeyholeItemRemoved;
				dispatcher.OnKeyholeItemRemoved += value49;
				ProfileEventDispatcher.KeyholeLevelCompleted value50 = OnKeyholeLevelCompleted;
				dispatcher.OnKeyholeLevelCompleted += value50;
				ProfileEventDispatcher.MemoryShardAdded value51 = OnMemoryShardAdded;
				dispatcher.OnMemoryShardAdded += value51;
				ProfileEventDispatcher.ToolAdded value52 = OnToolAdded;
				dispatcher.OnToolAdded += value52;
				ProfileEventDispatcher.HangoutChanged value53 = OnHangoutChanged;
				dispatcher.OnHangoutChanged += value53;
				ProfileEventDispatcher.FoundersPackClaimed value54 = OnFoundersPackClaimedRedeemed;
				dispatcher.OnFoundersPackClaimed += value54;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B58")]
		[Cpp2IlInjected.Address(RVA = "0x78D640", Offset = "0x78C040", VA = "0x18078D640")]
		public void AddConsumer(TrackingConsumer consumer, bool isMain)
		{
			//Discarded unreachable code: IL_0014
			consumer.IsMain = isMain;
			((List<T>)(object)consumers).Add((T)consumer);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B59")]
		[Cpp2IlInjected.Address(RVA = "0x79C610", Offset = "0x79B010", VA = "0x18079C610")]
		public void TrackEvent(TrackingEventBase trackingEvent)
		{
			//Discarded unreachable code: IL_002d, IL_0033, IL_0039, IL_003f
			List<TrackingConsumer> list = consumers;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (trackingEvent.EventDispatchMode == TrackingEventBase.DispatchMode.MainOnly)
			{
			}
			if (trackingEvent.EventDispatchMode != TrackingEventBase.DispatchMode.All)
			{
				TrackingEventBase.DispatchMode eventDispatchMode = trackingEvent.EventDispatchMode;
				while (eventDispatchMode != TrackingEventBase.DispatchMode.WhenShouldTrack)
				{
				}
				while (eventDispatchMode == TrackingEventBase.DispatchMode.MainOnly)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B5A")]
		[Cpp2IlInjected.Address(RVA = "0x78D510", Offset = "0x78BF10", VA = "0x18078D510")]
		public void AddClientInfo(Profile profile, string clientVersion, string clientStore, string buildFullName, string entityId, string playfabId, ILocation locationObj)
		{
			//Discarded unreachable code: IL_0072
			//IL_0039: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			if (!profile.IsSimulatorClient)
			{
				this.clientData.profile = profile;
				this.clientData.clientVersion = clientVersion;
				this.clientData.clientStore = clientStore;
				this.clientData.buildFullName = (string)0;
				this.clientData.playfabEntityId = (string)0;
				this.clientData.playfabUserId = (string)0;
				this.clientData.location = (ILocation)0;
				ClientData clientData = this.clientData;
				OnTrackClientInfo(clientData);
				OnTrackSNSUserInfo();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B5B")]
		[Cpp2IlInjected.Address(RVA = "0x79E8A0", Offset = "0x79D2A0", VA = "0x18079E8A0")]
		public void TrackUIEvent(string uiAction, string uiName, string uiLocation)
		{
			OnUIEvent(uiAction, uiName, uiLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B5C")]
		[Cpp2IlInjected.Address(RVA = "0x79CCF0", Offset = "0x79B6F0", VA = "0x18079CCF0")]
		public void TrackHangoutActivity(Item characterItem, HangoutEvent hangoutEvent)
		{
			OnHangoutActivity(characterItem, hangoutEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B5D")]
		[Cpp2IlInjected.Address(RVA = "0x79E890", Offset = "0x79D290", VA = "0x18079E890")]
		public void TrackStartEndActivity(string ActivityName, bool ended = false)
		{
			OnStartEndActivity(ActivityName, ended);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B5E")]
		[Cpp2IlInjected.Address(RVA = "0x79E0D0", Offset = "0x79CAD0", VA = "0x18079E0D0")]
		public void TrackRedeem(RedeemMarketplaceAssetsResult redeemResult)
		{
			OnTrackRedeem(redeemResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B5F")]
		[Cpp2IlInjected.Address(RVA = "0x79F760", Offset = "0x79E160", VA = "0x18079F760")]
		public void trackAgeGateEvent(int userAge)
		{
			OnAgeGatePassed(userAge);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B60")]
		[Cpp2IlInjected.Address(RVA = "0x79F610", Offset = "0x79E010", VA = "0x18079F610")]
		public TrackingManager()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
