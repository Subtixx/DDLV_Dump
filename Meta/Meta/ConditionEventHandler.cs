using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000999")]
	public class ConditionEventHandler : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027BF")]
		private readonly ProfileEventDispatcher Dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027C0")]
		private readonly ConditionListener Mask;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event ProfileEventDispatcher.AnyConditionChanged OnConditionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600542B")]
			[Cpp2IlInjected.Address(RVA = "0x1681C30", Offset = "0x1680630", VA = "0x181681C30")]
			[CompilerGenerated]
			add
			{
				ProfileEventDispatcher.AnyConditionChanged onConditionChanged = this.OnConditionChanged;
				Delegate @delegate = Delegate.Combine(onConditionChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConditionChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600542C")]
			[Cpp2IlInjected.Address(RVA = "0x1681CD0", Offset = "0x16806D0", VA = "0x181681CD0")]
			[CompilerGenerated]
			remove
			{
				ProfileEventDispatcher.AnyConditionChanged onConditionChanged = this.OnConditionChanged;
				Delegate @delegate = Delegate.Remove(onConditionChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConditionChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005428")]
		[Cpp2IlInjected.Address(RVA = "0x1680590", Offset = "0x167EF90", VA = "0x181680590")]
		public static ConditionEventHandler Register(ProfileEventDispatcher dispatcher, ConditionListener mask, ProfileEventDispatcher.AnyConditionChanged callback)
		{
			if (mask != 0 && callback != null)
			{
				ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
				conditionEventHandler.Dispatcher = dispatcher;
				ProfileEventDispatcher.AnyConditionChanged onConditionChanged = conditionEventHandler.OnConditionChanged;
				Delegate @delegate = Delegate.Combine(onConditionChanged, callback);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConditionChanged)
					{
					}
					conditionEventHandler.Mask = mask;
					conditionEventHandler.Register();
					return conditionEventHandler;
				}
			}
			else
			{
				int num = 0;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005429")]
		[Cpp2IlInjected.Address(RVA = "0x1681B50", Offset = "0x1680550", VA = "0x181681B50")]
		private ConditionEventHandler(ProfileEventDispatcher dispatcher, ConditionListener mask, ProfileEventDispatcher.AnyConditionChanged callback)
		{
			Dispatcher = dispatcher;
			ProfileEventDispatcher.AnyConditionChanged onConditionChanged = this.OnConditionChanged;
			Delegate @delegate = Delegate.Combine(onConditionChanged, callback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onConditionChanged)
				{
				}
				Mask = mask;
				Register();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600542A")]
		[Cpp2IlInjected.Address(RVA = "0x1680050", Offset = "0x167EA50", VA = "0x181680050", Slot = "4")]
		public void Dispose()
		{
			Unregister();
		}

		[Cpp2IlInjected.Token(Token = "0x600542D")]
		[Cpp2IlInjected.Address(RVA = "0x1680540", Offset = "0x167EF40", VA = "0x181680540")]
		private void Raise(ConditionListener conditionListener, bool checkMask = false)
		{
			if (checkMask)
			{
				ConditionListener mask = Mask;
			}
			if (this.OnConditionChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600542E")]
		[Cpp2IlInjected.Address(RVA = "0x16806B0", Offset = "0x167F0B0", VA = "0x1816806B0")]
		private void Register()
		{
			//Discarded unreachable code: IL_0503
			if (Mask.IsAffectedBy(ConditionListener.PlayerLevel))
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value = OnPlayerLevelGained;
				dispatcher.OnPlayerLevelGained += value;
			}
			if (Mask.IsAffectedBy(ConditionListener.CurrencyAmount))
			{
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
				dispatcher2.OnCurrencyChanged += value2;
			}
			if (Mask.IsAffectedBy(ConditionListener.ItemAmount))
			{
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value3 = OnItemAdded;
				dispatcher3.OnItemAdded += value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.ItemRemoved value4 = OnItemRemoved;
				dispatcher4.OnItemRemoved += value4;
			}
			if (Mask.IsAffectedBy(ConditionListener.MissionCompleted | ConditionListener.MissionOngoing | ConditionListener.MissionAvailable))
			{
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.MissionSlotUpdated value5 = OnMissionSlotUpdated;
				dispatcher5.OnMissionSlotUpdated += value5;
			}
			if (Mask.IsAffectedBy(ConditionListener.MissionStepChanged))
			{
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.MissionCurrentStepChanged value6 = OnMissionCurrentStepChanged;
				dispatcher6.OnMissionCurrentStepChanged += value6;
			}
			if (Mask.IsAffectedBy(ConditionListener.MissionObjectiveCompleted | ConditionListener.MissionObjectiveChanged | ConditionListener.CraftingRecipeVisibility))
			{
				ProfileEventDispatcher dispatcher7 = Dispatcher;
				ProfileEventDispatcher.MissionObjectiveStatusChanged value7 = OnMissionObjectiveStatusChanged;
				dispatcher7.OnMissionObjectiveStatusChanged += value7;
			}
			if (Mask.IsAffectedBy(ConditionListener.FriendshipLevel))
			{
				ProfileEventDispatcher dispatcher8 = Dispatcher;
				ProfileEventDispatcher.CharacterFriendshipLevelChanged value8 = OnCharacterFriendshipLevelChanged;
				dispatcher8.OnCharacterFriendshipLevelChanged += value8;
			}
			if (Mask.IsAffectedBy(ConditionListener.Character))
			{
				ProfileEventDispatcher dispatcher9 = Dispatcher;
				ProfileEventDispatcher.CharacterStateChange value9 = OnCharacterStateChange;
				dispatcher9.OnCharacterStateChange += value9;
			}
			if (Mask.IsAffectedBy(ConditionListener.DialogueFlag))
			{
				ProfileEventDispatcher dispatcher10 = Dispatcher;
				ProfileEventDispatcher.DialogueFlagChange value10 = OnDialogueFlagChange;
				dispatcher10.OnDialogueFlagChange += value10;
			}
			if (Mask.IsAffectedBy(ConditionListener.MemoryShard))
			{
				ProfileEventDispatcher dispatcher11 = Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value11 = OnMemoryShardAdded;
				dispatcher11.OnMemoryShardAdded += value11;
			}
			if (Mask.IsAffectedBy(ConditionListener.Realm))
			{
				ProfileEventDispatcher dispatcher12 = Dispatcher;
				ProfileEventDispatcher.RealmUnlocked value12 = OnRealmUnlocked;
				dispatcher12.OnRealmUnlocked += value12;
			}
			if (Mask.IsAffectedBy(ConditionListener.Area))
			{
				ProfileEventDispatcher dispatcher13 = Dispatcher;
				ProfileEventDispatcher.VillageAreaUnlocked value13 = OnVillageAreaUnlocked;
				dispatcher13.OnVillageAreaUnlocked += value13;
			}
			if (Mask.IsAffectedBy(ConditionListener.AvatarCustomization))
			{
				ProfileEventDispatcher dispatcher14 = Dispatcher;
				ProfileEventDispatcher.AvatarCustomizationChanged value14 = OnAvatarCustomizationChanged;
				dispatcher14.OnAvatarCustomizationChanged += value14;
			}
			if (Mask.IsAffectedBy(ConditionListener.ToolUnlocked))
			{
				ProfileEventDispatcher dispatcher15 = Dispatcher;
				ProfileEventDispatcher.ToolAdded value15 = OnToolAdded;
				dispatcher15.OnToolAdded += value15;
			}
			if (Mask.IsAffectedBy(ConditionListener.Scene))
			{
				ProfileEventDispatcher dispatcher16 = Dispatcher;
				ProfileEventDispatcher.CurrentSceneChanged value16 = OnCurrentSceneChanged;
				dispatcher16.OnCurrentSceneChanged += value16;
			}
			if (Mask.IsAffectedBy(ConditionListener.ManaAlreadyMissed))
			{
				ProfileEventDispatcher dispatcher17 = Dispatcher;
				ProfileEventDispatcher.ManaHasAlreadyMissedChanged value17 = OnManaHasAlreadyMissedChanged;
				dispatcher17.OnManaHasAlreadyMissedChanged += value17;
			}
			if (Mask.IsAffectedBy(ConditionListener.Hangout))
			{
				ProfileEventDispatcher dispatcher18 = Dispatcher;
				ProfileEventDispatcher.HangoutChanged value18 = OnHangoutChanged;
				dispatcher18.OnHangoutChanged += value18;
			}
			if (Mask.IsAffectedBy(ConditionListener.Time))
			{
				ProfileEventDispatcher dispatcher19 = Dispatcher;
				ProfileEventDispatcher.FewMinutesHavePass value19 = OnFewMinutesHavePass;
				dispatcher19.OnFewMinutesHavePass += value19;
			}
			if (Mask.IsAffectedBy(ConditionListener.CraftingRecipeVisibility))
			{
				ProfileEventDispatcher dispatcher20 = Dispatcher;
				ProfileEventDispatcher.CollectionSetUpdated value20 = OnCollectionSetUpdated;
				dispatcher20.OnCollectionSetUpdated += value20;
			}
			if (Mask.IsAffectedBy(ConditionListener.CookingRecipeVisibility))
			{
				ProfileEventDispatcher dispatcher21 = Dispatcher;
				ProfileEventDispatcher.RecipeAdded value21 = OnRecipeAdded;
				dispatcher21.OnRecipeAdded += value21;
			}
			if (Mask.IsAffectedBy(ConditionListener.Keyhole))
			{
				ProfileEventDispatcher dispatcher22 = Dispatcher;
				ProfileEventDispatcher.KeyholeItemAdded value22 = OnKeyholeAddedOrRemoved;
				dispatcher22.OnKeyholeItemAdded += value22;
				ProfileEventDispatcher dispatcher23 = Dispatcher;
				ProfileEventDispatcher.KeyholeItemRemoved value23 = OnKeyholeAddedOrRemoved;
				dispatcher23.OnKeyholeItemRemoved += value23;
				ProfileEventDispatcher dispatcher24 = Dispatcher;
				ProfileEventDispatcher.KeyholeLevelCompleted value24 = OnKeyholeLevelUp;
				dispatcher24.OnKeyholeLevelCompleted += value24;
			}
			if (Mask.IsAffectedBy(ConditionListener.FTUEEvent))
			{
				ProfileEventDispatcher dispatcher25 = Dispatcher;
				ProfileEventDispatcher.FtueEventComplete value25 = OnFtueEventComplete;
				dispatcher25.OnFtueEventComplete += value25;
			}
			if (Mask.IsAffectedBy(ConditionListener.Weather))
			{
				ProfileEventDispatcher dispatcher26 = Dispatcher;
				ProfileEventDispatcher.WeatherChanged value26 = OnWeatherChanged;
				dispatcher26.OnWeatherChanged += value26;
			}
			if (Mask.IsAffectedBy(ConditionListener.ToolUpgraded))
			{
				ProfileEventDispatcher dispatcher27 = Dispatcher;
				ProfileEventDispatcher.ToolUpgraded value27 = OnToolUpgraded;
				dispatcher27.OnToolUpgraded += value27;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600542F")]
		[Cpp2IlInjected.Address(RVA = "0x16811F0", Offset = "0x167FBF0", VA = "0x1816811F0")]
		private void Unregister()
		{
			//Discarded unreachable code: IL_0345
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.PlayerLevelGained value = OnPlayerLevelGained;
				dispatcher.OnPlayerLevelGained -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
				dispatcher2.OnCurrencyChanged -= value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value3 = OnItemAdded;
				dispatcher3.OnItemAdded -= value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.ItemRemoved value4 = OnItemRemoved;
				dispatcher4.OnItemRemoved -= value4;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.MissionSlotUpdated value5 = OnMissionSlotUpdated;
				dispatcher5.OnMissionSlotUpdated -= value5;
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.MissionCurrentStepChanged value6 = OnMissionCurrentStepChanged;
				dispatcher6.OnMissionCurrentStepChanged -= value6;
				ProfileEventDispatcher dispatcher7 = Dispatcher;
				ProfileEventDispatcher.MissionObjectiveStatusChanged value7 = OnMissionObjectiveStatusChanged;
				dispatcher7.OnMissionObjectiveStatusChanged -= value7;
				ProfileEventDispatcher dispatcher8 = Dispatcher;
				ProfileEventDispatcher.CharacterFriendshipLevelChanged value8 = OnCharacterFriendshipLevelChanged;
				dispatcher8.OnCharacterFriendshipLevelChanged -= value8;
				ProfileEventDispatcher dispatcher9 = Dispatcher;
				ProfileEventDispatcher.CharacterStateChange value9 = OnCharacterStateChange;
				dispatcher9.OnCharacterStateChange -= value9;
				ProfileEventDispatcher dispatcher10 = Dispatcher;
				ProfileEventDispatcher.DialogueFlagChange value10 = OnDialogueFlagChange;
				dispatcher10.OnDialogueFlagChange -= value10;
				ProfileEventDispatcher dispatcher11 = Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value11 = OnMemoryShardAdded;
				dispatcher11.OnMemoryShardAdded -= value11;
				ProfileEventDispatcher dispatcher12 = Dispatcher;
				ProfileEventDispatcher.RealmUnlocked value12 = OnRealmUnlocked;
				dispatcher12.OnRealmUnlocked -= value12;
				ProfileEventDispatcher dispatcher13 = Dispatcher;
				ProfileEventDispatcher.VillageAreaUnlocked value13 = OnVillageAreaUnlocked;
				dispatcher13.OnVillageAreaUnlocked -= value13;
				ProfileEventDispatcher dispatcher14 = Dispatcher;
				ProfileEventDispatcher.AvatarCustomizationChanged value14 = OnAvatarCustomizationChanged;
				dispatcher14.OnAvatarCustomizationChanged -= value14;
				ProfileEventDispatcher dispatcher15 = Dispatcher;
				ProfileEventDispatcher.ToolAdded value15 = OnToolAdded;
				dispatcher15.OnToolAdded -= value15;
				ProfileEventDispatcher dispatcher16 = Dispatcher;
				ProfileEventDispatcher.CurrentSceneChanged value16 = OnCurrentSceneChanged;
				dispatcher16.OnCurrentSceneChanged -= value16;
				ProfileEventDispatcher dispatcher17 = Dispatcher;
				ProfileEventDispatcher.ManaHasAlreadyMissedChanged value17 = OnManaHasAlreadyMissedChanged;
				dispatcher17.OnManaHasAlreadyMissedChanged -= value17;
				ProfileEventDispatcher dispatcher18 = Dispatcher;
				ProfileEventDispatcher.HangoutChanged value18 = OnHangoutChanged;
				dispatcher18.OnHangoutChanged -= value18;
				ProfileEventDispatcher dispatcher19 = Dispatcher;
				ProfileEventDispatcher.FewMinutesHavePass value19 = OnFewMinutesHavePass;
				dispatcher19.OnFewMinutesHavePass -= value19;
				ProfileEventDispatcher dispatcher20 = Dispatcher;
				ProfileEventDispatcher.CollectionSetUpdated value20 = OnCollectionSetUpdated;
				dispatcher20.OnCollectionSetUpdated -= value20;
				ProfileEventDispatcher dispatcher21 = Dispatcher;
				ProfileEventDispatcher.RecipeAdded value21 = OnRecipeAdded;
				dispatcher21.OnRecipeAdded -= value21;
				ProfileEventDispatcher dispatcher22 = Dispatcher;
				ProfileEventDispatcher.KeyholeItemAdded value22 = OnKeyholeAddedOrRemoved;
				dispatcher22.OnKeyholeItemAdded -= value22;
				ProfileEventDispatcher dispatcher23 = Dispatcher;
				ProfileEventDispatcher.KeyholeItemRemoved value23 = OnKeyholeAddedOrRemoved;
				dispatcher23.OnKeyholeItemRemoved -= value23;
				ProfileEventDispatcher dispatcher24 = Dispatcher;
				ProfileEventDispatcher.KeyholeLevelCompleted value24 = OnKeyholeLevelUp;
				dispatcher24.OnKeyholeLevelCompleted -= value24;
				ProfileEventDispatcher dispatcher25 = Dispatcher;
				ProfileEventDispatcher.FtueEventComplete value25 = OnFtueEventComplete;
				dispatcher25.OnFtueEventComplete -= value25;
				ProfileEventDispatcher dispatcher26 = Dispatcher;
				ProfileEventDispatcher.WeatherChanged value26 = OnWeatherChanged;
				dispatcher26.OnWeatherChanged -= value26;
				ProfileEventDispatcher dispatcher27 = Dispatcher;
				ProfileEventDispatcher.ToolUpgraded value27 = OnToolUpgraded;
				dispatcher27.OnToolUpgraded -= value27;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005430")]
		[Cpp2IlInjected.Address(RVA = "0x1680460", Offset = "0x167EE60", VA = "0x181680460")]
		private void OnPlayerLevelGained(int gained)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.PlayerLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6005431")]
		[Cpp2IlInjected.Address(RVA = "0x16800F0", Offset = "0x167EAF0", VA = "0x1816800F0")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.CurrencyAmount);
		}

		[Cpp2IlInjected.Token(Token = "0x6005432")]
		[Cpp2IlInjected.Address(RVA = "0x16801B0", Offset = "0x167EBB0", VA = "0x1816801B0")]
		private void OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.ItemAmount);
		}

		[Cpp2IlInjected.Token(Token = "0x6005433")]
		[Cpp2IlInjected.Address(RVA = "0x16801B0", Offset = "0x167EBB0", VA = "0x1816801B0")]
		private void OnItemRemoved(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.ItemAmount);
		}

		[Cpp2IlInjected.Token(Token = "0x6005434")]
		[Cpp2IlInjected.Address(RVA = "0x1680340", Offset = "0x167ED40", VA = "0x181680340")]
		private void OnMissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason, [Optional] List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_0022, IL_0034, IL_0040, IL_0055, IL_0063, IL_0078, IL_0085, IL_009a
			ConditionListener mask = Mask;
			this.OnConditionChanged?.Invoke(ConditionListener.MissionAvailable);
		}

		[Cpp2IlInjected.Token(Token = "0x6005435")]
		[Cpp2IlInjected.Address(RVA = "0x1680230", Offset = "0x167EC30", VA = "0x181680230")]
		private void OnMissionCurrentStepChanged(MissionSlotClass slotClass, int slotId, int previousStepIndex, int currentStepIndex)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.MissionStepChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x6005436")]
		[Cpp2IlInjected.Address(RVA = "0x1680250", Offset = "0x167EC50", VA = "0x181680250")]
		private void OnMissionObjectiveStatusChanged(MissionObjective obj, MissionStepStatus previousStatus, MissionStepStatus newStatus)
		{
			ConditionListener mask = Mask;
			this.OnConditionChanged?.Invoke(ConditionListener.MissionObjectiveChanged);
			if ((previousStatus < MissionStepStatus.Completed && newStatus >= MissionStepStatus.Completed) || newStatus < MissionStepStatus.Completed)
			{
				ConditionListener mask2 = Mask;
				this.OnConditionChanged?.Invoke(ConditionListener.MissionObjectiveCompleted);
			}
			if (obj == null)
			{
				return;
			}
			MissionObjectiveData _003CData_003Ek__BackingField = obj.Data;
			if (_003CData_003Ek__BackingField == null)
			{
				return;
			}
			CustomStepCraftItem craftItem = _003CData_003Ek__BackingField.CraftItem;
			if (craftItem != null && previousStatus == MissionStepStatus.Ongoing && newStatus == previousStatus)
			{
				ConditionListener mask3 = Mask;
				if (craftItem != null)
				{
					this.OnConditionChanged?.Invoke(ConditionListener.CraftingRecipeVisibility);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005437")]
		[Cpp2IlInjected.Address(RVA = "0x1680080", Offset = "0x167EA80", VA = "0x181680080")]
		private void OnCharacterFriendshipLevelChanged(Item characterItem, int levelsGained)
		{
			if (levelsGained > 0)
			{
				this.OnConditionChanged?.Invoke(ConditionListener.FriendshipLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005438")]
		[Cpp2IlInjected.Address(RVA = "0x16800B0", Offset = "0x167EAB0", VA = "0x1816800B0")]
		private void OnCharacterStateChange(Item item, Character.Types.CharacterStatus status, CharacterChangeStatusReason reason)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Character);
		}

		[Cpp2IlInjected.Token(Token = "0x6005439")]
		[Cpp2IlInjected.Address(RVA = "0x1680130", Offset = "0x167EB30", VA = "0x181680130")]
		private void OnDialogueFlagChange(Item flagItem, bool active)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.DialogueFlag);
		}

		[Cpp2IlInjected.Token(Token = "0x600543A")]
		[Cpp2IlInjected.Address(RVA = "0x1680210", Offset = "0x167EC10", VA = "0x181680210")]
		private void OnMemoryShardAdded(Item memoryShardItem, int memoryShardIndex, AddDetail detail)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.MemoryShard);
		}

		[Cpp2IlInjected.Token(Token = "0x600543B")]
		[Cpp2IlInjected.Address(RVA = "0x1680480", Offset = "0x167EE80", VA = "0x181680480")]
		private void OnRealmUnlocked(string realmID, bool unlockedByFlag)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Realm);
		}

		[Cpp2IlInjected.Token(Token = "0x600543C")]
		[Cpp2IlInjected.Address(RVA = "0x1680500", Offset = "0x167EF00", VA = "0x181680500")]
		private void OnVillageAreaUnlocked(VillageAreaType areaType, [Optional] List<CurrencyCost> costs)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Area);
		}

		[Cpp2IlInjected.Token(Token = "0x600543D")]
		[Cpp2IlInjected.Address(RVA = "0x1680060", Offset = "0x167EA60", VA = "0x181680060")]
		private void OnAvatarCustomizationChanged(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.AvatarCustomization);
		}

		[Cpp2IlInjected.Token(Token = "0x600543E")]
		[Cpp2IlInjected.Address(RVA = "0x16804C0", Offset = "0x167EEC0", VA = "0x1816804C0")]
		private void OnToolAdded(Item toolItem)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.ToolUnlocked);
		}

		[Cpp2IlInjected.Token(Token = "0x600543F")]
		[Cpp2IlInjected.Address(RVA = "0x1680110", Offset = "0x167EB10", VA = "0x181680110")]
		private void OnCurrentSceneChanged(Item previousScene, Item currentScene)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Scene);
		}

		[Cpp2IlInjected.Token(Token = "0x6005440")]
		[Cpp2IlInjected.Address(RVA = "0x16801F0", Offset = "0x167EBF0", VA = "0x1816801F0")]
		private void OnManaHasAlreadyMissedChanged()
		{
			this.OnConditionChanged?.Invoke(ConditionListener.ManaAlreadyMissed);
		}

		[Cpp2IlInjected.Token(Token = "0x6005441")]
		[Cpp2IlInjected.Address(RVA = "0x1680190", Offset = "0x167EB90", VA = "0x181680190")]
		private void OnHangoutChanged(Character character)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Hangout);
		}

		[Cpp2IlInjected.Token(Token = "0x6005442")]
		[Cpp2IlInjected.Address(RVA = "0x1680150", Offset = "0x167EB50", VA = "0x181680150")]
		private void OnFewMinutesHavePass(ProfileTimerType timerType, int minutesPassed)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Time);
		}

		[Cpp2IlInjected.Token(Token = "0x6005443")]
		[Cpp2IlInjected.Address(RVA = "0x16800D0", Offset = "0x167EAD0", VA = "0x1816800D0")]
		private void OnCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromCooking)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.CraftingRecipeVisibility);
		}

		[Cpp2IlInjected.Token(Token = "0x6005444")]
		[Cpp2IlInjected.Address(RVA = "0x16804A0", Offset = "0x167EEA0", VA = "0x1816804A0")]
		private void OnRecipeAdded(Item recipeItem, InvActionType reason)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.CookingRecipeVisibility);
		}

		[Cpp2IlInjected.Token(Token = "0x6005445")]
		[Cpp2IlInjected.Address(RVA = "0x16801D0", Offset = "0x167EBD0", VA = "0x1816801D0")]
		private void OnKeyholeAddedOrRemoved(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Keyhole);
		}

		[Cpp2IlInjected.Token(Token = "0x6005446")]
		[Cpp2IlInjected.Address(RVA = "0x16801D0", Offset = "0x167EBD0", VA = "0x1816801D0")]
		private void OnKeyholeLevelUp(Keyhole keyhole, int levelCompleted)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Keyhole);
		}

		[Cpp2IlInjected.Token(Token = "0x6005447")]
		[Cpp2IlInjected.Address(RVA = "0x1680170", Offset = "0x167EB70", VA = "0x181680170")]
		private void OnFtueEventComplete(Item ftueItem)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.FTUEEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6005448")]
		[Cpp2IlInjected.Address(RVA = "0x1680520", Offset = "0x167EF20", VA = "0x181680520")]
		private void OnWeatherChanged(string oldWeather, string newWeather)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.Weather);
		}

		[Cpp2IlInjected.Token(Token = "0x6005449")]
		[Cpp2IlInjected.Address(RVA = "0x16804E0", Offset = "0x167EEE0", VA = "0x1816804E0")]
		private void OnToolUpgraded(Item toolItem, Item upgradeItem)
		{
			this.OnConditionChanged?.Invoke(ConditionListener.ToolUpgraded);
		}
	}
}
