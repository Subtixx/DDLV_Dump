using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Rpc.Core;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Actions;
using Meta.Collections;
using Meta.Customization;
using Meta.Duties;
using Meta.Grids;
using Meta.Missions;
using Meta.Social;
using Meta.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000972")]
	[DebuggerDisplay("{DebugDisplay,nq}")]
	public sealed class Profile : IMessage<Profile>, IMessage, IEquatable<Profile>, IDeepCloneable<Profile>, IMessageFieldAccessor, IRewardRecipient, IProfile, IGridDataUpdateInvalidItemHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000973")]
		public class HangoutSystemState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002770")]
			private Profile profile;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002771")]
			private ProfileEventDispatcher dispatcher;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4002772")]
			private ITransactionContext context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4002773")]
			private HangoutSettingsData _settings;

			[Cpp2IlInjected.Token(Token = "0x17000E78")]
			public Character HangingOutWithCharacter
			{
				[Cpp2IlInjected.Token(Token = "0x6005375")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CHangingOutWithCharacter_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6005376")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003CHangingOutWithCharacter_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000E79")]
			public HangoutSettingsData Settings
			{
				[Cpp2IlInjected.Token(Token = "0x6005377")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				get
				{
					return _settings;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000E7A")]
			private DateTime DateToday
			{
				[Cpp2IlInjected.Token(Token = "0x6005378")]
				[Cpp2IlInjected.Address(RVA = "0x10D30C0", Offset = "0x10D1AC0", VA = "0x1810D30C0")]
				get
				{
					//Discarded unreachable code: IL_0009
					ITransactionContext transactionContext = context;
					DateTime result = default(DateTime);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005379")]
			[Cpp2IlInjected.Address(RVA = "0x10D1CF0", Offset = "0x10D06F0", VA = "0x1810D1CF0")]
			public void Initialize(Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
			{
				//Discarded unreachable code: IL_005a
				this.profile = profile;
				this.dispatcher = dispatcher;
				this.context = context;
				if ((long)_settings == 0)
				{
					ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				}
				ProfileEventDispatcher profileEventDispatcher = this.dispatcher;
				ProfileEventDispatcher.PictureTaken pictureTaken = OnPictureTaken;
				ProfileEventDispatcher profileEventDispatcher2 = this.dispatcher;
				ProfileEventDispatcher.HangoutGatherReward value = OnHangoutGatherReward;
				profileEventDispatcher2.OnHangoutGatherReward += value;
			}

			[Cpp2IlInjected.Token(Token = "0x600537A")]
			[Cpp2IlInjected.Address(RVA = "0x10D2050", Offset = "0x10D0A50", VA = "0x1810D2050")]
			private void OnPictureTaken(PhotoModeType photoMode, List<int> itemIds, List<int> gardenItemIds, SceneType _)
			{
				//Discarded unreachable code: IL_00fc, IL_0102, IL_0108, IL_010e, IL_0114, IL_011a, IL_0120, IL_0126, IL_012c, IL_0132, IL_0138
				HangoutSettingsData settings;
				Func<Item, bool> func = default(Func<Item, bool>);
				bool flag = default(bool);
				bool flag2 = default(bool);
				DateTime dateTime = default(DateTime);
				do
				{
					IL_0000:
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					settings = _settings;
					Func<int, Item> _003C_003E9__13_ = _003C_003Ec._003C_003E9__13_0;
					if (_003C_003E9__13_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int itemId) => default(Item));
					}
					IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)itemIds, (Func<, >)(object)_003C_003E9__13_);
					if (_003C_003Ec._003C_003E9__13_1 == null)
					{
						func = (Func<Item, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item item) => default(bool)));
					}
					IEnumerable<Item> enumerable2 = (IEnumerable<Item>)Enumerable.Where<Item>((IEnumerable<>)enumerable, (Func<, >)(object)func);
					if (enumerable2 != null)
					{
						ProfileWorld world_ = this.profile.world_;
						while (!flag)
						{
						}
						Profile profile = this.profile;
						HangoutSettingsData settings2 = _settings;
						DateTime dateToday = DateToday;
						while (!flag2)
						{
						}
						if ((settings2.selfieRequiresHangout_ && (IntPtr)profile.HangoutState.HangingOutWithCharacter != (IntPtr)num) || (num != 0 && dateTime >= dateToday))
						{
							goto IL_0000;
						}
						ProfileWorld world_2 = this.profile.world_;
						ITransactionContext transactionContext = context;
						int num4 = 0;
						Timestamp timestamp = DateToday.ToProto();
					}
					if (enumerable2 != null)
					{
					}
				}
				while (settings != null);
			}

			[Cpp2IlInjected.Token(Token = "0x600537B")]
			[Cpp2IlInjected.Address(RVA = "0x10D1EE0", Offset = "0x10D08E0", VA = "0x1810D1EE0")]
			private static bool IsAllowedToRewardSelfie(Profile profile, HangoutSettingsData settings, Character character, DateTime now)
			{
				if (character.IsUnlocked && (!settings.selfieRequiresHangout_ || profile.HangoutState.HangingOutWithCharacter == character))
				{
					Timestamp lastSelfieDate_ = character.lastSelfieDate_;
					if (lastSelfieDate_ == null || !(lastSelfieDate_.ToDateTime() >= now))
					{
						return true;
					}
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600537C")]
			[Cpp2IlInjected.Address(RVA = "0x10D2AB0", Offset = "0x10D14B0", VA = "0x1810D2AB0")]
			public bool TryApplyHangoutActivityFriendship(HangoutActivityType activityType, bool wasSuccess = true)
			{
				//IL_0013: Expected O, but got I4
				//IL_0055: Expected O, but got I4
				SceneItemData sceneItemData = default(SceneItemData);
				AddedFriendshipSummary addedFriendshipSummary = default(AddedFriendshipSummary);
				while (((MapField<TKey, TValue>)(object)_settings.activityData_).ContainsKey((TKey)activityType) && (long)HangingOutWithCharacter != 0)
				{
					Item _003CCurrentScene_003Ek__BackingField = this.profile.player_.CurrentScene;
					if (sceneItemData.sceneType_ == SceneType.DisneyWorld)
					{
						break;
					}
					HangoutSettingsData.Types.ActivityFriendshipData activityFriendshipData = (HangoutSettingsData.Types.ActivityFriendshipData)((MapField<TKey, TValue>)(object)_settings.activityData_)[(TKey)activityType];
					Character character = HangingOutWithCharacter;
					if (character != null)
					{
						ProfessionItemData profession = character.Profession;
						if (profession != null)
						{
							RepeatedField<HangoutActivityType> hangoutPreferredActivities_ = profession.hangoutPreferredActivities_;
							if (0 == 0)
							{
								goto IL_0085;
							}
							if (!wasSuccess)
							{
							}
						}
					}
					int num = 0;
					goto IL_0085;
					IL_0085:
					if (wasSuccess)
					{
					}
					if (activityFriendshipData.activityFailureAmount_ <= 0)
					{
						break;
					}
					Profile profile = this.profile;
					Character character2 = HangingOutWithCharacter;
					ProfileWorld world_ = profile.world_;
					int iD = character2.Data.ID;
					ITransactionContext transactionContext = context;
					if (addedFriendshipSummary != null)
					{
						return addedFriendshipSummary.FriendshipGained > 0;
					}
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600537D")]
			[Cpp2IlInjected.Address(RVA = "0x10D1CA0", Offset = "0x10D06A0", VA = "0x1810D1CA0")]
			internal void HangoutWith(Character character)
			{
				//Discarded unreachable code: IL_0014
				HangingOutWithCharacter = character;
				dispatcher.RaiseHangoutChanged(character);
			}

			[Cpp2IlInjected.Token(Token = "0x600537E")]
			[Cpp2IlInjected.Address(RVA = "0x10D25C0", Offset = "0x10D0FC0", VA = "0x1810D25C0")]
			internal bool StopHangout()
			{
				//IL_0010: Expected O, but got I4
				ProfileEventDispatcher profileEventDispatcher = dispatcher;
				int num = 0;
				profileEventDispatcher.RaiseHangoutChanged((Character)num);
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600537F")]
			[Cpp2IlInjected.Address(RVA = "0x10D1B70", Offset = "0x10D0570", VA = "0x1810D1B70")]
			private HangoutActivityType? GetActivityTypeFromGardenItem(Item gardenItem)
			{
				//IL_0014: Expected O, but got I4
				int itemID = gardenItem.ItemID;
				_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
				CS_0024_003C_003E8__locals0.gardenItem = (Item)itemID;
				RepeatedField<HangoutSettingsData.Types.ActivityGardenData> gardenToActivityType_ = _settings.gardenToActivityType_;
				Func<HangoutSettingsData.Types.ActivityGardenData, bool> func = (Func<HangoutSettingsData.Types.ActivityGardenData, bool>)(object)(Func<T, TResult>)((HangoutSettingsData.Types.ActivityGardenData x) => default(bool));
				HangoutSettingsData.Types.ActivityGardenData activityGardenData = Enumerable.FirstOrDefault<HangoutSettingsData.Types.ActivityGardenData>((IEnumerable<>)(object)gardenToActivityType_, (Func<, >)(object)func);
				if (activityGardenData != null)
				{
					HangoutActivityType activity_ = activityGardenData.activity_;
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6005380")]
			[Cpp2IlInjected.Address(RVA = "0x10D2DC0", Offset = "0x10D17C0", VA = "0x1810D2DC0")]
			public bool TryApplyHangoutActivityHarvestFriendship(Item gardenItem)
			{
				//IL_0014: Expected O, but got I4
				int itemID = gardenItem.ItemID;
				_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
				CS_0024_003C_003E8__locals0.gardenItem = (Item)itemID;
				RepeatedField<HangoutSettingsData.Types.ActivityGardenData> gardenToActivityType_ = _settings.gardenToActivityType_;
				Func<HangoutSettingsData.Types.ActivityGardenData, bool> func = (Func<HangoutSettingsData.Types.ActivityGardenData, bool>)(object)(Func<T, TResult>)((HangoutSettingsData.Types.ActivityGardenData x) => default(bool));
				HangoutSettingsData.Types.ActivityGardenData activityGardenData = Enumerable.FirstOrDefault<HangoutSettingsData.Types.ActivityGardenData>((IEnumerable<>)(object)gardenToActivityType_, (Func<, >)(object)func);
				int num = 0;
				if (activityGardenData != null)
				{
					HangoutActivityType activity_ = activityGardenData.activity_;
				}
				if (num == 0)
				{
					int num2 = 0;
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6005381")]
			[Cpp2IlInjected.Address(RVA = "0x10D1FC0", Offset = "0x10D09C0", VA = "0x1810D1FC0")]
			private void OnHangoutGatherReward(ItemReward[] rewardItems)
			{
				//Discarded unreachable code: IL_0028
				Character character = HangingOutWithCharacter;
				if (character != null)
				{
					((RepeatedField<T>)(object)character.pendingHangoutGatherRewards_).Clear();
					((RepeatedField<T>)(object)HangingOutWithCharacter.pendingHangoutGatherRewards_).AddRange((IEnumerable<>)(object)rewardItems);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005382")]
			[Cpp2IlInjected.Address(RVA = "0x10D2610", Offset = "0x10D1010", VA = "0x1810D2610")]
			public bool TryAddGatherRewards(BuffType buffType, Random random, ItemWithState reward)
			{
				//IL_003e: Expected I4, but got I8
				//IL_00f3: Expected I4, but got I8
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = reward.Item;
				IItemData itemData = default(IItemData);
				if (!itemData.IsMissionItem())
				{
					ProfilePlayer player_ = profile.player_;
					ulong num = num + num;
					long num2 = (long)num * -1000L;
					int num3 = (int)(num3 + num2);
					uint maxValue = default(uint);
					int num4 = random.Next((int)maxValue);
					if (num3 > 0 && num4 < num3)
					{
						num++;
					}
					if ((long)num > 0L && (long)HangingOutWithCharacter != 0)
					{
						ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
						Item _003CCurrentScene_003Ek__BackingField = profile.player_.CurrentScene;
						if (_003CInstance_003Ek__BackingField2.GetItemData<SceneItemData>(_003CCurrentScene_003Ek__BackingField).sceneType_ != SceneType.DisneyWorld)
						{
							Item item2 = reward.Item;
						}
					}
					if (false)
					{
						RepeatedField<ItemType> restrictedGatherItemRewardTypes_ = _settings.restrictedGatherItemRewardTypes_;
						Item item3 = reward.Item;
						bool flag;
						if (flag)
						{
							ItemReward itemReward = _settings.replacementGatherItemReward_.Clone();
						}
						ItemReward itemReward2 = new ItemReward();
						int num5 = (itemReward2.id_ = reward.itemID_);
						itemReward2.amount_ = (int)num;
						ItemState itemState = (itemReward2.state_ = reward.state_);
						((RepeatedField<T>)(object)HangingOutWithCharacter.pendingHangoutGatherRewards_).Add((T)itemReward2);
						ItemReward[] rewardItems = new ItemReward[((RepeatedField<T>)(object)HangingOutWithCharacter.pendingHangoutGatherRewards_).Count];
						RepeatedField<ItemReward> pendingHangoutGatherRewards_ = HangingOutWithCharacter.pendingHangoutGatherRewards_;
						dispatcher.RaiseHangoutGatherReward(rewardItems);
					}
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6005383")]
			[Cpp2IlInjected.Address(RVA = "0x10D1A60", Offset = "0x10D0460", VA = "0x1810D1A60")]
			private ItemReward CreateRewardFromItemState(ItemWithState reward, int amount)
			{
				RepeatedField<ItemType> restrictedGatherItemRewardTypes_ = _settings.restrictedGatherItemRewardTypes_;
				Item item = reward.Item;
				bool flag = default(bool);
				if (flag)
				{
					return _settings.replacementGatherItemReward_.Clone();
				}
				ItemReward itemReward = new ItemReward();
				int num = (itemReward.id_ = reward.itemID_);
				itemReward.amount_ = amount;
				ItemState itemState = (itemReward.state_ = reward.state_);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6005384")]
			[Cpp2IlInjected.Address(RVA = "0x10D2F40", Offset = "0x10D1940", VA = "0x1810D2F40")]
			private bool ValidateAddRewards(ItemWithState reward)
			{
				if ((long)HangingOutWithCharacter != 0)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item _003CCurrentScene_003Ek__BackingField = profile.player_.CurrentScene;
					if (_003CInstance_003Ek__BackingField.GetItemData<SceneItemData>(_003CCurrentScene_003Ek__BackingField).sceneType_ != SceneType.DisneyWorld && reward != null && (object)reward.Item == null)
					{
						return true;
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6005385")]
			[Cpp2IlInjected.Address(RVA = "0x10D1960", Offset = "0x10D0360", VA = "0x1810D1960")]
			private bool AddGatherRewards(ItemReward rewardItem)
			{
				//Discarded unreachable code: IL_0041
				((RepeatedField<T>)(object)HangingOutWithCharacter.pendingHangoutGatherRewards_).Add((T)rewardItem);
				ItemReward[] rewardItems = new ItemReward[((RepeatedField<T>)(object)HangingOutWithCharacter.pendingHangoutGatherRewards_).Count];
				RepeatedField<ItemReward> pendingHangoutGatherRewards_ = HangingOutWithCharacter.pendingHangoutGatherRewards_;
				dispatcher.RaiseHangoutGatherReward(rewardItems);
				return true;
			}

			[Cpp2IlInjected.Token(Token = "0x6005386")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public HangoutSystemState()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000976")]
		public class ItemCollectMinigame
		{
			[Cpp2IlInjected.Token(Token = "0x2000977")]
			public enum MinigameState
			{
				[Cpp2IlInjected.Token(Token = "0x400277F")]
				NotStarted,
				[Cpp2IlInjected.Token(Token = "0x4002780")]
				Pending,
				[Cpp2IlInjected.Token(Token = "0x4002781")]
				Started
			}

			[Cpp2IlInjected.Token(Token = "0x4002778")]
			private const string RandomSeedName = "ItemCollectMinigame";

			[Cpp2IlInjected.Token(Token = "0x17000E7B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002779")]
			public int ID
			{
				[Cpp2IlInjected.Token(Token = "0x600538D")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600538E")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000E7C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x400277A")]
			public MinigameState State
			{
				[Cpp2IlInjected.Token(Token = "0x600538F")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6005390")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000E7D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400277B")]
			public DateTime EndTime
			{
				[Cpp2IlInjected.Token(Token = "0x6005391")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6005392")]
				[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000E7E")]
			public ItemCollectMinigameData MinigameData
			{
				[Cpp2IlInjected.Token(Token = "0x6005393")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CMinigameData_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6005394")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				internal set
				{
					_003CMinigameData_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000E7F")]
			public List<MultiItemInstance> ItemsToCollect
			{
				[Cpp2IlInjected.Token(Token = "0x6005395")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CItemsToCollect_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6005396")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				internal set
				{
					_003CItemsToCollect_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005397")]
			[Cpp2IlInjected.Address(RVA = "0x10D3C60", Offset = "0x10D2660", VA = "0x1810D3C60")]
			public bool IsMinigameOver(ITransactionContext context)
			{
				//Discarded unreachable code: IL_005d
				if (State != MinigameState.Started)
				{
					int num = 0;
				}
				ItemCollectMinigameData itemCollectMinigameData = MinigameData;
				DateTime dateTime = EndTime;
				Duration anticipationDuration_ = itemCollectMinigameData.anticipationDuration_;
				if (anticipationDuration_ != null)
				{
					TimeSpan timeSpan = anticipationDuration_.ToTimeSpan();
				}
				TimeSpan zero = TimeSpan.Zero;
				DateTime dateTime2 = dateTime + zero;
				TimeSpan timeSpan2 = MinigameData.gracePeriod_.ToTimeSpan();
				DateTime dateTime3 = dateTime2 + timeSpan2;
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6005398")]
			[Cpp2IlInjected.Address(RVA = "0x10D3120", Offset = "0x10D1B20", VA = "0x1810D3120")]
			internal CollectMinigameItem.Types.Result CollectItem(int itemIndex, in Player player, in World world, ITransactionContext context)
			{
				//Discarded unreachable code: IL_019e, IL_01a4, IL_01aa, IL_01b0, IL_01b6, IL_01c2
				//IL_016d: Expected I4, but got O
				//IL_0176: Expected I4, but got O
				bool flag = default(bool);
				bool flag2 = default(bool);
				IBackpackItem backpackItem = default(IBackpackItem);
				ContainerInventory.CanAddResult canAddResult = default(ContainerInventory.CanAddResult);
				bool flag3 = default(bool);
				uint num6 = default(uint);
				bool flag4 = default(bool);
				bool flag5 = default(bool);
				bool flag6 = default(bool);
				ProfileWorld profileWorld = default(ProfileWorld);
				bool flag7 = default(bool);
				IEnumerable<GridPosition> cpp2il__autoParamName__idx_ = default(IEnumerable<GridPosition>);
				ProfilePlayer profilePlayer = default(ProfilePlayer);
				ProfilePlayer profilePlayer2 = default(ProfilePlayer);
				while (true)
				{
					int num = 0;
					int num2 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					int num3 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					if (flag)
					{
						if (flag2)
						{
							while (backpackItem == null)
							{
							}
							if (num == 0)
							{
								ContainerInventory containerInventory = player.Section.Backpack.Clone();
							}
							while (canAddResult == ContainerInventory.CanAddResult.Success)
							{
							}
							num++;
						}
						num++;
					}
					num++;
					int num4 = 0;
					if (num != 0)
					{
						break;
					}
					if (num != 0)
					{
					}
					if (flag3)
					{
					}
					int num5 = 0;
					if (num != 0)
					{
						continue;
					}
					if (num5 < (int)num6)
					{
						num5 += num5;
						num5++;
					}
					if (flag4)
					{
						if (_003C_003Ec._003C_003E9__23_0 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MultiItemInstance x) => default(bool));
						}
						if (flag5)
						{
							_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
							if (flag6)
							{
								GridCollection gridCollection_ = profileWorld.gridCollection_;
								if (flag7)
								{
									IGrid grid = CS_0024_003C_003E8__locals0.grid;
									Func<GridPosition, bool> func = (Func<GridPosition, bool>)(object)(Func<T, TResult>)((GridPosition position) => default(bool));
									GridPosition[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<GridPosition>();
									if (array.Length != 0)
									{
										int randomSeed = profilePlayer.GetRandomSeed("ItemCollectMinigame");
										Random random = new Random(randomSeed);
										int length = array.Length;
										int num7 = random.Next(length);
										randomSeed = num7;
										length += length;
										num7 += 776;
										GridPosition gridPosition = array[randomSeed];
										profilePlayer2.AdvanceRandomSeed("ItemCollectMinigame");
										PlaceOnGrid.Types.Response response = new PlaceOnGrid.Types.Response();
										PlaceOnGrid.Types.Request request = new PlaceOnGrid.Types.Request();
										request.gridID_ = (uint)num;
										request.itemID_ = num5;
										request.posX_ = (int)gridPosition;
										request.posY_ = (int)gridPosition;
										request.orientation_ = (GridOrientation)num5;
										request.automaticSpawning_ = true;
										request.IgnoreLimits = true;
										response.request_ = request;
									}
								}
							}
						}
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6005399")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ItemCollectMinigame()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200097A")]
		public enum Location
		{
			[Cpp2IlInjected.Token(Token = "0x4002787")]
			Unknown,
			[Cpp2IlInjected.Token(Token = "0x4002788")]
			Client,
			[Cpp2IlInjected.Token(Token = "0x4002789")]
			SimulatorClient
		}

		[Cpp2IlInjected.Token(Token = "0x200097B")]
		public struct TemporaryOverrideScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400278A")]
			private readonly Action end;

			[Cpp2IlInjected.Token(Token = "0x400278B")]
			public static readonly TemporaryOverrideScope Invalid;

			[Cpp2IlInjected.Token(Token = "0x17000E80")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x600539F")]
				[Cpp2IlInjected.Address(RVA = "0x10D44B0", Offset = "0x10D2EB0", VA = "0x1810D44B0")]
				get
				{
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60053A0")]
			[Cpp2IlInjected.Address(RVA = "0x10D4470", Offset = "0x10D2E70", VA = "0x1810D4470")]
			internal TemporaryOverrideScope(Action begin, Action end)
			{
				begin?.Invoke();
				this.end = end;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60053A1")]
			[Cpp2IlInjected.Address(RVA = "0x10D4460", Offset = "0x10D2E60", VA = "0x1810D4460", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001


			[Cpp2IlInjected.Token(Token = "0x60053A2")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
			static TemporaryOverrideScope()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002736")]
		private static readonly MessageParser<Profile> _parser = (MessageParser<Profile>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new Profile()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002737")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002738")]
		public const int GameInfoFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002739")]
		private ProfileGameInfo gameInfo_;

		[Cpp2IlInjected.Token(Token = "0x400273A")]
		public const int SettingsFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400273B")]
		private ProfileSettings settings_;

		[Cpp2IlInjected.Token(Token = "0x400273C")]
		public const int PlayerFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400273D")]
		private ProfilePlayer player_;

		[Cpp2IlInjected.Token(Token = "0x400273E")]
		public const int WorldFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400273F")]
		private ProfileWorld world_;

		[Cpp2IlInjected.Token(Token = "0x4002740")]
		public const int FreeTimersFieldNumber = 23;

		[Cpp2IlInjected.Token(Token = "0x4002741")]
		private static readonly FieldCodec<TimerType> _repeated_freeTimers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002742")]
		private readonly RepeatedField<TimerType> freeTimers_;

		[Cpp2IlInjected.Token(Token = "0x4002743")]
		public const int WeedControllerFieldNumber = 29;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002744")]
		private WeedController weedController_;

		[Cpp2IlInjected.Token(Token = "0x4002745")]
		public const int CriticalSuccessFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002746")]
		private CriticalSuccess criticalSuccess_;

		[Cpp2IlInjected.Token(Token = "0x4002747")]
		public const int UsedPreferredItemIDsFieldNumber = 32;

		[Cpp2IlInjected.Token(Token = "0x4002748")]
		private static readonly FieldCodec<int> _repeated_usedPreferredItemIDs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002749")]
		private readonly RepeatedField<int> usedPreferredItemIDs_;

		[Cpp2IlInjected.Token(Token = "0x400274A")]
		public const int UsedUniquePreferredItemIDsFieldNumber = 33;

		[Cpp2IlInjected.Token(Token = "0x400274B")]
		private static readonly FieldCodec<int> _repeated_usedUniquePreferredItemIDs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400274C")]
		private readonly RepeatedField<int> usedUniquePreferredItemIDs_;

		[Cpp2IlInjected.Token(Token = "0x400274D")]
		public const int LastDailyResetFieldNumber = 43;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400274E")]
		private Timestamp lastDailyReset_;

		[Cpp2IlInjected.Token(Token = "0x400274F")]
		public const int TrackedMissionsFieldNumber = 44;

		[Cpp2IlInjected.Token(Token = "0x4002750")]
		private static readonly FieldCodec<int> _repeated_trackedMissions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002751")]
		private readonly RepeatedField<int> trackedMissions_;

		[Cpp2IlInjected.Token(Token = "0x4002752")]
		public const int ConditionalEventHistoryFieldNumber = 45;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002753")]
		private ConditionalEventHistoryData conditionalEventHistory_;

		[Cpp2IlInjected.Token(Token = "0x4002754")]
		public const int SeenCraftingRecipesFieldNumber = 46;

		[Cpp2IlInjected.Token(Token = "0x4002755")]
		private static readonly FieldCodec<int> _repeated_seenCraftingRecipes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002756")]
		private readonly RepeatedField<int> seenCraftingRecipes_;

		[Cpp2IlInjected.Token(Token = "0x4002757")]
		public const int LastResponseFieldNumber = 10000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002758")]
		private WrappedResponse lastResponse_;

		[Cpp2IlInjected.Token(Token = "0x4002759")]
		public const int LastRequestTimestampFieldNumber = 10001;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400275A")]
		private Timestamp lastRequestTimestamp_;

		[Cpp2IlInjected.Token(Token = "0x400275B")]
		public const int IsSaneFieldNumber = 20000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400275C")]
		private bool isSane_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400275D")]
		public HangoutSystemState HangoutState;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400275E")]
		private readonly List<ItemCollectMinigame> itemCollectMinigames;

		[Cpp2IlInjected.Token(Token = "0x400275F")]
		public static readonly int CurrentVersion;

		[Cpp2IlInjected.Token(Token = "0x4002769")]
		private static int _overrideSaveWithoutUpdatingContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400276A")]
		public int LastKnownAvatarGridId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400276B")]
		public GridPosition LastKnownAvatarGridPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400276C")]
		public GridPosition LastKnownAvatarDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400276D")]
		public bool LastKnownAvatarPositionUpToDate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400276E")]
		private readonly Dictionary<(uint gridID, GridPosition gridPosition), DateTime> lastDigs;

		[Cpp2IlInjected.Token(Token = "0x17000E43")]
		[DebuggerNonUserCode]
		public static MessageParser<Profile> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60052D6")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF80", Offset = "0x7D9980", VA = "0x1807DAF80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E44")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60052D7")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC90", Offset = "0x7D9690", VA = "0x1807DAC90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E45")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60052D8")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2F0", Offset = "0x7D9CF0", VA = "0x1807DB2F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E46")]
		[DebuggerNonUserCode]
		public ProfileGameInfo GameInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60052DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gameInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				gameInfo_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E47")]
		[DebuggerNonUserCode]
		public ProfileSettings Settings
		{
			[Cpp2IlInjected.Token(Token = "0x60052DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return settings_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052E0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				settings_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E48")]
		[DebuggerNonUserCode]
		public ProfilePlayer Player
		{
			[Cpp2IlInjected.Token(Token = "0x60052E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return player_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052E2")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				player_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E49")]
		[DebuggerNonUserCode]
		public ProfileWorld World
		{
			[Cpp2IlInjected.Token(Token = "0x60052E3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return world_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052E4")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				world_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4A")]
		[DebuggerNonUserCode]
		public RepeatedField<TimerType> FreeTimers
		{
			[Cpp2IlInjected.Token(Token = "0x60052E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return freeTimers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4B")]
		[DebuggerNonUserCode]
		public WeedController WeedController
		{
			[Cpp2IlInjected.Token(Token = "0x60052E6")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return weedController_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052E7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				weedController_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4C")]
		[DebuggerNonUserCode]
		public CriticalSuccess CriticalSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x60052E8")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return criticalSuccess_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052E9")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				criticalSuccess_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4D")]
		[DebuggerNonUserCode]
		public RepeatedField<int> UsedPreferredItemIDs
		{
			[Cpp2IlInjected.Token(Token = "0x60052EA")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return usedPreferredItemIDs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4E")]
		[DebuggerNonUserCode]
		public RepeatedField<int> UsedUniquePreferredItemIDs
		{
			[Cpp2IlInjected.Token(Token = "0x60052EB")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return usedUniquePreferredItemIDs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4F")]
		[DebuggerNonUserCode]
		public Timestamp LastDailyReset
		{
			[Cpp2IlInjected.Token(Token = "0x60052EC")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return lastDailyReset_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052ED")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				lastDailyReset_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E50")]
		[DebuggerNonUserCode]
		public RepeatedField<int> TrackedMissions
		{
			[Cpp2IlInjected.Token(Token = "0x60052EE")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return trackedMissions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E51")]
		[DebuggerNonUserCode]
		public ConditionalEventHistoryData ConditionalEventHistory
		{
			[Cpp2IlInjected.Token(Token = "0x60052EF")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return conditionalEventHistory_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052F0")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				conditionalEventHistory_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E52")]
		[DebuggerNonUserCode]
		public RepeatedField<int> SeenCraftingRecipes
		{
			[Cpp2IlInjected.Token(Token = "0x60052F1")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return seenCraftingRecipes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E53")]
		[DebuggerNonUserCode]
		public WrappedResponse LastResponse
		{
			[Cpp2IlInjected.Token(Token = "0x60052F2")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return lastResponse_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052F3")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E54")]
		[DebuggerNonUserCode]
		public Timestamp LastRequestTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60052F4")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return lastRequestTimestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052F5")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			set
			{
				lastRequestTimestamp_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E55")]
		[DebuggerNonUserCode]
		public bool IsSane
		{
			[Cpp2IlInjected.Token(Token = "0x60052F6")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEA0", Offset = "0x7D98A0", VA = "0x1807DAEA0")]
			get
			{
				return isSane_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052F7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB470", Offset = "0x7D9E70", VA = "0x1807DB470")]
			set
			{
				isSane_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E56")]
		public Item HangingOutWithCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6005303")]
			[Cpp2IlInjected.Address(RVA = "0x7DAD80", Offset = "0x7D9780", VA = "0x1807DAD80", Slot = "21")]
			get
			{
				//Discarded unreachable code: IL_0022
				Character _003CHangingOutWithCharacter_003Ek__BackingField = HangoutState.HangingOutWithCharacter;
				if (_003CHangingOutWithCharacter_003Ek__BackingField != null)
				{
					int iD = _003CHangingOutWithCharacter_003Ek__BackingField.Data.ID;
				}
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E57")]
		public IProfilePlayer ProfilePlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600530C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				ProfilePlayer profilePlayer = player_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E58")]
		public IProfileWorld ProfileWorld
		{
			[Cpp2IlInjected.Token(Token = "0x600530D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				ProfileWorld profileWorld = world_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E59")]
		public string Country
		{
			[Cpp2IlInjected.Token(Token = "0x600530E")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB50", Offset = "0x7D9550", VA = "0x1807DAB50", Slot = "19")]
			get
			{
				//Discarded unreachable code: IL_000c
				return settings_.country_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5A")]
		public DeviceInfo DeviceInfo
		{
			[Cpp2IlInjected.Token(Token = "0x600530F")]
			[Cpp2IlInjected.Address(RVA = "0x7DAD60", Offset = "0x7D9760", VA = "0x1807DAD60", Slot = "20")]
			get
			{
				//Discarded unreachable code: IL_000c
				return gameInfo_.DeviceInfo;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5B")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6005311")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB70", Offset = "0x7D9570", VA = "0x1807DAB70")]
			get
			{
				//IL_001e: Expected O, but got I8
				//IL_001e: Expected O, but got I4
				Location location = ProfileLocation;
				if (gameInfo_ != null)
				{
				}
				int num = 0;
				ulong num2 = default(ulong);
				return $"{location} revision: {num2}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5C")]
		public bool IsSimulatorClient
		{
			[Cpp2IlInjected.Token(Token = "0x6005312")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEC0", Offset = "0x7D98C0", VA = "0x1807DAEC0")]
			get
			{
				return ProfileLocation == Location.SimulatorClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA8"), Cpp2IlInjected.Token(Token = "0x4002760")]
		public bool IsSaveRequested
		{
			[Cpp2IlInjected.Token(Token = "0x6005313")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEB0", Offset = "0x7D98B0", VA = "0x1807DAEB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005314")]
			[Cpp2IlInjected.Address(RVA = "0x7DB480", Offset = "0x7D9E80", VA = "0x1807DB480")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA9"), Cpp2IlInjected.Token(Token = "0x4002761")]
		public bool HasAnyUpdateApplied
		{
			[Cpp2IlInjected.Token(Token = "0x6005315")]
			[Cpp2IlInjected.Address(RVA = "0x7DAE20", Offset = "0x7D9820", VA = "0x1807DAE20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005316")]
			[Cpp2IlInjected.Address(RVA = "0x7DB460", Offset = "0x7D9E60", VA = "0x1807DB460")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5F")]
		public OnlineProfile OnlineProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6005317")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			[CompilerGenerated]
			get
			{
				return _003COnlineProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6005318")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			[CompilerGenerated]
			set
			{
				_003COnlineProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E60")]
		public Village Village
		{
			[Cpp2IlInjected.Token(Token = "0x6005319")]
			[Cpp2IlInjected.Address(RVA = "0x7DB280", Offset = "0x7D9C80", VA = "0x1807DB280")]
			get
			{
				//Discarded unreachable code: IL_000c
				return world_.village_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E61")]
		public ContainerInventory Backpack
		{
			[Cpp2IlInjected.Token(Token = "0x600531A")]
			[Cpp2IlInjected.Address(RVA = "0x7DA9F0", Offset = "0x7D93F0", VA = "0x1807DA9F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Backpack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E62")]
		public ContainerInventory HomeStorage
		{
			[Cpp2IlInjected.Token(Token = "0x600531B")]
			[Cpp2IlInjected.Address(RVA = "0x7DAE80", Offset = "0x7D9880", VA = "0x1807DAE80")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.HomeStorage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E63")]
		public ListInventory Catalog
		{
			[Cpp2IlInjected.Token(Token = "0x600531C")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB30", Offset = "0x7D9530", VA = "0x1807DAB30")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Catalog;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E64")]
		public ListInventory Wardrobe
		{
			[Cpp2IlInjected.Token(Token = "0x600531D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2A0", Offset = "0x7D9CA0", VA = "0x1807DB2A0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Wardrobe;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E65")]
		public ListInventory Pantry
		{
			[Cpp2IlInjected.Token(Token = "0x600531E")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF60", Offset = "0x7D9960", VA = "0x1807DAF60")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Pantry;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E66")]
		public ListInventory Makeup
		{
			[Cpp2IlInjected.Token(Token = "0x600531F")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF30", Offset = "0x7D9930", VA = "0x1807DAF30")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Makeup;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E67")]
		public ListInventory Trimming
		{
			[Cpp2IlInjected.Token(Token = "0x6005320")]
			[Cpp2IlInjected.Address(RVA = "0x7DB0D0", Offset = "0x7D9AD0", VA = "0x1807DB0D0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Trimming;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E68")]
		public ListInventory Buildings
		{
			[Cpp2IlInjected.Token(Token = "0x6005321")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB10", Offset = "0x7D9510", VA = "0x1807DAB10")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Buildings;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E69")]
		public ListInventory Decals
		{
			[Cpp2IlInjected.Token(Token = "0x6005322")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC70", Offset = "0x7D9670", VA = "0x1807DAC70")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Decals;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6A")]
		public ListInventory Skins
		{
			[Cpp2IlInjected.Token(Token = "0x6005323")]
			[Cpp2IlInjected.Address(RVA = "0x7DAFF0", Offset = "0x7D99F0", VA = "0x1807DAFF0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return player_.Skins;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB8"), Cpp2IlInjected.Token(Token = "0x4002763")]
		public Item? DebugForceFishItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005324")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005325")]
			[Cpp2IlInjected.Address(RVA = "0x7DB400", Offset = "0x7D9E00", VA = "0x1807DB400")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC0"), Cpp2IlInjected.Token(Token = "0x4002764")]
		public FishRarity? DebugForceFishRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6005326")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005327")]
			[Cpp2IlInjected.Address(RVA = "0x7DB410", Offset = "0x7D9E10", VA = "0x1807DB410")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC8"), Cpp2IlInjected.Token(Token = "0x4002765")]
		public Item? DebugForceMiningDataItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005328")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005329")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7D9E20", VA = "0x1807DB420")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6E")]
		public (Item Item, int Type)? DebugForceStoreFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600532A")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC40", Offset = "0x7D9640", VA = "0x1807DAC40")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600532B")]
			[Cpp2IlInjected.Address(RVA = "0x7DB430", Offset = "0x7D9E30", VA = "0x1807DB430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xDC"), Cpp2IlInjected.Token(Token = "0x4002767")]
		public bool DebugShowAllCraftingRecipes
		{
			[Cpp2IlInjected.Token(Token = "0x600532C")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC60", Offset = "0x7D9660", VA = "0x1807DAC60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600532D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB450", Offset = "0x7D9E50", VA = "0x1807DB450")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E70")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xE0"), Cpp2IlInjected.Token(Token = "0x4002768")]
		public Location ProfileLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6005330")]
			[Cpp2IlInjected.Address(RVA = "0x7DAFE0", Offset = "0x7D99E0", VA = "0x1807DAFE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005331")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4C0", Offset = "0x7D9EC0", VA = "0x1807DB4C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E71")]
		public static bool IsUpdatingSaveContext
		{
			[Cpp2IlInjected.Token(Token = "0x6005332")]
			[Cpp2IlInjected.Address(RVA = "0x7DAED0", Offset = "0x7D98D0", VA = "0x1807DAED0")]
			get
			{
				return (long)"{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x34}" == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E72")]
		public bool HasTrackedMission
		{
			[Cpp2IlInjected.Token(Token = "0x6005348")]
			[Cpp2IlInjected.Address(RVA = "0x7DAE30", Offset = "0x7D9830", VA = "0x1807DAE30")]
			get
			{
				//Discarded unreachable code: IL_000f
				return ((RepeatedField<T>)(object)trackedMissions_).Count > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E73")]
		public int TrackedMission
		{
			[Cpp2IlInjected.Token(Token = "0x6005349")]
			[Cpp2IlInjected.Address(RVA = "0x7DB090", Offset = "0x7D9A90", VA = "0x1807DB090")]
			get
			{
				return Enumerable.LastOrDefault<int>((IEnumerable<>)(object)trackedMissions_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E74")]
		public Item TrackedMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600534A")]
			[Cpp2IlInjected.Address(RVA = "0x7DB010", Offset = "0x7D9A10", VA = "0x1807DB010")]
			get
			{
				long num = Convert.ToInt64((uint)Enumerable.LastOrDefault<int>((IEnumerable<>)(object)trackedMissions_));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E75")]
		public List<VillageAreaType> VillageAreaMapMarker
		{
			[Cpp2IlInjected.Token(Token = "0x600534B")]
			[Cpp2IlInjected.Address(RVA = "0x7DB0F0", Offset = "0x7D9AF0", VA = "0x1807DB0F0")]
			get
			{
				//Discarded unreachable code: IL_003f
				ProfileWorld profileWorld = world_;
				Item trackedMissionItem = TrackedMissionItem;
				Func<MissionObjective, IEnumerable<VillageAreaType>> _003C_003E9__228_ = _003C_003Ec._003C_003E9__228_0;
				if (_003C_003E9__228_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
					{
						MissionObjectiveData _003CData_003Ek__BackingField = x.Data;
						int num = 0;
						IVillageAreaMapMarker getIVillageAreaMapMarker = _003CData_003Ek__BackingField.GetIVillageAreaMapMarker;
						if (getIVillageAreaMapMarker != null)
						{
							int num2 = 0;
							uint num3 = default(uint);
							if (num2 < (int)num3)
							{
								num2 += num2;
								num2++;
							}
							if (getIVillageAreaMapMarker != null)
							{
							}
						}
						num += num;
						throw new NullReferenceException();
					};
				}
				IEnumerable<MissionObjective> enumerable = default(IEnumerable<MissionObjective>);
				return (List<VillageAreaType>)(object)Enumerable.ToList<VillageAreaType>(Enumerable.Distinct<VillageAreaType>(Enumerable.SelectMany<MissionObjective, VillageAreaType>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__228_)));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E76")]
		public List<Item> BuildingMapMarkers
		{
			[Cpp2IlInjected.Token(Token = "0x600534C")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA10", Offset = "0x7D9410", VA = "0x1807DAA10")]
			get
			{
				//Discarded unreachable code: IL_002d
				ProfileWorld profileWorld = world_;
				Item trackedMissionItem = TrackedMissionItem;
				Func<MissionObjective, IEnumerable<Item>> func = (Func<MissionObjective, IEnumerable<Item>>)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					int num = 0;
					MissionObjectiveData _003CData_003Ek__BackingField = x.Data;
					int num2 = 0;
					if (_003CData_003Ek__BackingField.GetIBuildingMapMarker != null)
					{
						MissionItemData data = x.MissionSlot.Data;
						int num3 = 0;
						uint num4 = default(uint);
						if (num3 < (int)num4)
						{
							num3 += num3;
							num3++;
						}
						if (data != null)
						{
						}
					}
					num2 += num2;
					throw new NullReferenceException();
				};
				IEnumerable<MissionObjective> enumerable = default(IEnumerable<MissionObjective>);
				return (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Distinct<Item>(Enumerable.SelectMany<MissionObjective, Item>((IEnumerable<>)enumerable, (Func<, >)(object)func)));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E77")]
		int IGridDataUpdateInvalidItemHandler.MaxNumberOfTries
		{
			[Cpp2IlInjected.Token(Token = "0x600536A")]
			[Cpp2IlInjected.Address(RVA = "0x7D4F00", Offset = "0x7D3900", VA = "0x1807D4F00", Slot = "24")]
			get
			{
				return 5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60052D9")]
		[Cpp2IlInjected.Address(RVA = "0x7DA620", Offset = "0x7D9020", VA = "0x1807DA620")]
		[DebuggerNonUserCode]
		public Profile()
		{
			//IL_0080: Expected I4, but got I8
			freeTimers_ = (RepeatedField<TimerType>)(object)new RepeatedField<T>();
			usedPreferredItemIDs_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			usedUniquePreferredItemIDs_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			trackedMissions_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			seenCraftingRecipes_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			HangoutState = new HangoutSystemState();
			itemCollectMinigames = (List<ItemCollectMinigame>)(object)new List<T>();
			OnlineProfile = new OnlineProfile();
			LastKnownAvatarGridId = -1;
			lastDigs = (Dictionary<(uint gridID, GridPosition gridPosition), DateTime>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
			ProfileGameInfo profileGameInfo = (gameInfo_ = new ProfileGameInfo());
			ProfileSettings profileSettings = (settings_ = new ProfileSettings());
			ProfilePlayer profilePlayer = (player_ = new ProfilePlayer());
			ProfileWorld profileWorld = (world_ = new ProfileWorld());
			ConditionalEventHistoryData conditionalEventHistoryData = (conditionalEventHistory_ = new ConditionalEventHistoryData());
			WeedController weedController = (weedController_ = new WeedController());
			CriticalSuccess criticalSuccess = (criticalSuccess_ = new CriticalSuccess());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60052DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D4F10", Offset = "0x7D3910", VA = "0x1807D4F10")]
		private void OnConstruction()
		{
			ProfileGameInfo profileGameInfo = (gameInfo_ = new ProfileGameInfo());
			ProfileSettings profileSettings = (settings_ = new ProfileSettings());
			ProfilePlayer profilePlayer = (player_ = new ProfilePlayer());
			ProfileWorld profileWorld = (world_ = new ProfileWorld());
			ConditionalEventHistoryData conditionalEventHistoryData = (conditionalEventHistory_ = new ConditionalEventHistoryData());
			WeedController weedController = (weedController_ = new WeedController());
			CriticalSuccess criticalSuccess = (criticalSuccess_ = new CriticalSuccess());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60052DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DA340", Offset = "0x7D8D40", VA = "0x1807DA340")]
		[DebuggerNonUserCode]
		public Profile(Profile other)
		{
			//IL_001b: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_0105: Expected O, but got I4
			//IL_0137: Expected O, but got I4
			//IL_0169: Expected O, but got I4
			ProfileGameInfo profileGameInfo = other.gameInfo_;
			int num = 0;
			if (profileGameInfo != null)
			{
				ProfileGameInfo profileGameInfo2 = profileGameInfo.Clone();
			}
			gameInfo_ = (ProfileGameInfo)num;
			ProfileSettings profileSettings = other.settings_;
			if (profileSettings != null)
			{
				ProfileSettings profileSettings2 = profileSettings.Clone();
			}
			settings_ = (ProfileSettings)num;
			ProfilePlayer profilePlayer = other.player_;
			if (profilePlayer != null)
			{
				ProfilePlayer profilePlayer2 = profilePlayer.Clone();
			}
			player_ = (ProfilePlayer)num;
			ProfileWorld profileWorld = other.world_;
			if (profileWorld != null)
			{
				ProfileWorld profileWorld2 = profileWorld.Clone();
			}
			world_ = (ProfileWorld)num;
			RepeatedField<TimerType> repeatedField = (freeTimers_ = (RepeatedField<TimerType>)(object)((RepeatedField<T>)(object)other.freeTimers_).Clone());
			WeedController weedController = other.weedController_;
			if (weedController != null)
			{
				WeedController weedController2 = weedController.Clone();
			}
			weedController_ = (WeedController)num;
			CriticalSuccess criticalSuccess = other.criticalSuccess_;
			if (criticalSuccess != null)
			{
				CriticalSuccess criticalSuccess2 = criticalSuccess.Clone();
			}
			criticalSuccess_ = (CriticalSuccess)num;
			RepeatedField<int> repeatedField2 = (usedPreferredItemIDs_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.usedPreferredItemIDs_).Clone());
			RepeatedField<int> repeatedField3 = (usedUniquePreferredItemIDs_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.usedUniquePreferredItemIDs_).Clone());
			Timestamp timestamp = other.lastDailyReset_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			lastDailyReset_ = (Timestamp)num;
			RepeatedField<int> repeatedField4 = (trackedMissions_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.trackedMissions_).Clone());
			ConditionalEventHistoryData conditionalEventHistoryData = other.conditionalEventHistory_;
			if (conditionalEventHistoryData != null)
			{
				ConditionalEventHistoryData conditionalEventHistoryData2 = conditionalEventHistoryData.Clone();
			}
			conditionalEventHistory_ = (ConditionalEventHistoryData)num;
			RepeatedField<int> repeatedField5 = (seenCraftingRecipes_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.seenCraftingRecipes_).Clone());
			WrappedResponse wrappedResponse = other.lastResponse_;
			if (wrappedResponse != null)
			{
				WrappedResponse wrappedResponse2 = wrappedResponse.Clone();
			}
			lastResponse_ = (WrappedResponse)num;
			Timestamp timestamp3 = other.lastRequestTimestamp_;
			Timestamp timestamp4 = default(Timestamp);
			if (timestamp3 != null)
			{
				timestamp4 = timestamp3.Clone();
			}
			lastRequestTimestamp_ = timestamp4;
			bool flag = (isSane_ = other.isSane_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60052DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CD590", Offset = "0x7CBF90", VA = "0x1807CD590", Slot = "10")]
		[DebuggerNonUserCode]
		public Profile Clone()
		{
			return new Profile(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60052F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D06C0", Offset = "0x7CF0C0", VA = "0x1807D06C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((Profile)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60052F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D0480", Offset = "0x7CEE80", VA = "0x1807D0480", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Profile other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ProfileGameInfo objB = other.gameInfo_;
				if (object.Equals(gameInfo_, objB))
				{
					ProfileSettings objB2 = other.settings_;
					if (object.Equals(settings_, objB2))
					{
						ProfilePlayer objB3 = other.player_;
						if (object.Equals(player_, objB3))
						{
							ProfileWorld objB4 = other.world_;
							if (object.Equals(world_, objB4))
							{
								RepeatedField<TimerType> repeatedField = freeTimers_;
								RepeatedField<TimerType> repeatedField2 = other.freeTimers_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									WeedController objB5 = other.weedController_;
									if (object.Equals(weedController_, objB5))
									{
										CriticalSuccess objB6 = other.criticalSuccess_;
										if (object.Equals(criticalSuccess_, objB6))
										{
											RepeatedField<int> repeatedField3 = usedPreferredItemIDs_;
											RepeatedField<int> repeatedField4 = other.usedPreferredItemIDs_;
											if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
											{
												RepeatedField<int> repeatedField5 = usedUniquePreferredItemIDs_;
												RepeatedField<int> repeatedField6 = other.usedUniquePreferredItemIDs_;
												if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
												{
													Timestamp objB7 = other.lastDailyReset_;
													if (object.Equals(lastDailyReset_, objB7))
													{
														RepeatedField<int> repeatedField7 = trackedMissions_;
														RepeatedField<int> repeatedField8 = other.trackedMissions_;
														if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
														{
															ConditionalEventHistoryData objB8 = other.conditionalEventHistory_;
															if (object.Equals(conditionalEventHistory_, objB8))
															{
																RepeatedField<int> repeatedField9 = seenCraftingRecipes_;
																RepeatedField<int> repeatedField10 = other.seenCraftingRecipes_;
																if (((RepeatedField<T>)(object)repeatedField9).Equals((RepeatedField<>)(object)repeatedField10))
																{
																	WrappedResponse objB9 = other.lastResponse_;
																	if (object.Equals(lastResponse_, objB9))
																	{
																		Timestamp objB10 = other.lastRequestTimestamp_;
																		if (object.Equals(lastRequestTimestamp_, objB10))
																		{
																			bool flag = other.isSane_;
																			if (isSane_ == flag)
																			{
																				UnknownFieldSet unknownFields = other._unknownFields;
																				return object.Equals(_unknownFields, unknownFields);
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60052FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D0E20", Offset = "0x7CF820", VA = "0x1807D0E20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_013c
			ProfileGameInfo profileGameInfo = gameInfo_;
			if (profileGameInfo != null)
			{
				int hashCode = profileGameInfo.GetHashCode();
			}
			ProfileSettings profileSettings = settings_;
			if (profileSettings != null)
			{
				int hashCode2 = profileSettings.GetHashCode();
			}
			ProfilePlayer profilePlayer = player_;
			if (profilePlayer != null)
			{
				int hashCode3 = profilePlayer.GetHashCode();
			}
			ProfileWorld profileWorld = world_;
			if (profileWorld != null)
			{
				int hashCode4 = profileWorld.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)freeTimers_).GetHashCode();
			WeedController weedController = weedController_;
			if (weedController != null)
			{
				int hashCode6 = weedController.GetHashCode();
			}
			CriticalSuccess criticalSuccess = criticalSuccess_;
			if (criticalSuccess != null)
			{
				int hashCode7 = criticalSuccess.GetHashCode();
			}
			int hashCode8 = ((RepeatedField<T>)(object)usedPreferredItemIDs_).GetHashCode();
			int hashCode9 = ((RepeatedField<T>)(object)usedUniquePreferredItemIDs_).GetHashCode();
			Timestamp timestamp = lastDailyReset_;
			if (timestamp != null)
			{
				int hashCode10 = timestamp.GetHashCode();
			}
			int hashCode11 = ((RepeatedField<T>)(object)trackedMissions_).GetHashCode();
			ConditionalEventHistoryData conditionalEventHistoryData = conditionalEventHistory_;
			if (conditionalEventHistoryData != null)
			{
				int hashCode12 = conditionalEventHistoryData.GetHashCode();
			}
			int hashCode13 = ((RepeatedField<T>)(object)seenCraftingRecipes_).GetHashCode();
			WrappedResponse wrappedResponse = lastResponse_;
			if (wrappedResponse != null)
			{
				int hashCode14 = wrappedResponse.GetHashCode();
			}
			Timestamp timestamp2 = lastRequestTimestamp_;
			if (timestamp2 != null)
			{
				int hashCode15 = timestamp2.GetHashCode();
			}
			if (isSane_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode16 = unknownFields.GetHashCode();
			}
			return hashCode9;
		}

		[Cpp2IlInjected.Token(Token = "0x60052FB")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C00", Offset = "0x7D6600", VA = "0x1807D7C00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60052FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C60", Offset = "0x7D8660", VA = "0x1807D9C60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01b4
			if ((long)gameInfo_ != 0)
			{
				ProfileGameInfo value = gameInfo_;
				output.WriteMessage(value);
			}
			if ((long)_repeated_trackedMissions_codec != 0)
			{
				ProfileSettings value2 = settings_;
				output.WriteMessage(value2);
			}
			if ((long)player_ != 0)
			{
				ProfilePlayer value3 = player_;
				output.WriteMessage(value3);
			}
			if ((long)world_ != 0)
			{
				ProfileWorld value4 = world_;
				output.WriteMessage(value4);
			}
			RepeatedField<TimerType> repeatedField = freeTimers_;
			FieldCodec<TimerType> repeated_freeTimers_codec = _repeated_freeTimers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_freeTimers_codec);
			if ((long)weedController_ != 0)
			{
				WeedController value5 = weedController_;
				output.WriteMessage(value5);
			}
			if ((long)criticalSuccess_ != 0)
			{
				CriticalSuccess value6 = criticalSuccess_;
				output.WriteMessage(value6);
			}
			RepeatedField<int> repeatedField2 = usedPreferredItemIDs_;
			FieldCodec<int> repeated_usedPreferredItemIDs_codec = _repeated_usedPreferredItemIDs_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_usedPreferredItemIDs_codec);
			RepeatedField<int> repeatedField3 = usedUniquePreferredItemIDs_;
			FieldCodec<int> repeated_usedUniquePreferredItemIDs_codec = _repeated_usedUniquePreferredItemIDs_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_usedUniquePreferredItemIDs_codec);
			if ((long)lastDailyReset_ != 0)
			{
				Timestamp value7 = lastDailyReset_;
				output.WriteMessage(value7);
			}
			RepeatedField<int> repeatedField4 = trackedMissions_;
			FieldCodec<int> repeated_trackedMissions_codec = _repeated_trackedMissions_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_trackedMissions_codec);
			if ((long)conditionalEventHistory_ != 0)
			{
				ConditionalEventHistoryData value8 = conditionalEventHistory_;
				output.WriteMessage(value8);
			}
			RepeatedField<int> repeatedField5 = seenCraftingRecipes_;
			FieldCodec<int> repeated_seenCraftingRecipes_codec = _repeated_seenCraftingRecipes_codec;
			((RepeatedField<T>)(object)repeatedField5).WriteTo(output, (FieldCodec<>)(object)repeated_seenCraftingRecipes_codec);
			int num = 0;
			if ((IntPtr)lastResponse_ != (IntPtr)num)
			{
				WrappedResponse value9 = lastResponse_;
				output.WriteMessage(value9);
			}
			if ((IntPtr)lastRequestTimestamp_ != (IntPtr)num)
			{
				Timestamp value10 = lastRequestTimestamp_;
				output.WriteMessage(value10);
			}
			if ((isSane_ ? 1 : 0) != num)
			{
				bool value11 = isSane_;
				output.WriteBool(value11);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60052FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7B0", Offset = "0x7CA1B0", VA = "0x1807CB7B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01e8
			ProfileGameInfo profileGameInfo = gameInfo_;
			int num = 0;
			if (profileGameInfo != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(profileGameInfo);
			}
			ProfileSettings profileSettings = settings_;
			if (profileSettings != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(profileSettings);
				num3++;
				num += num3;
			}
			ProfilePlayer profilePlayer = player_;
			if (profilePlayer != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(profilePlayer);
				num4++;
				num += num4;
			}
			ProfileWorld profileWorld = world_;
			if (profileWorld != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(profileWorld);
				num5++;
				num += num5;
			}
			RepeatedField<TimerType> repeatedField = freeTimers_;
			FieldCodec<TimerType> repeated_freeTimers_codec = _repeated_freeTimers_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_freeTimers_codec);
			WeedController weedController = weedController_;
			num += num6;
			if (weedController != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(weedController);
				num7 += 2;
				num += num7;
			}
			CriticalSuccess criticalSuccess = criticalSuccess_;
			if (criticalSuccess != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(criticalSuccess);
				num8 += 2;
				num += num8;
			}
			RepeatedField<int> repeatedField2 = usedPreferredItemIDs_;
			FieldCodec<int> repeated_usedPreferredItemIDs_codec = _repeated_usedPreferredItemIDs_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_usedPreferredItemIDs_codec);
			RepeatedField<int> repeatedField3 = usedUniquePreferredItemIDs_;
			FieldCodec<int> repeated_usedUniquePreferredItemIDs_codec = _repeated_usedUniquePreferredItemIDs_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_usedUniquePreferredItemIDs_codec);
			Timestamp timestamp = lastDailyReset_;
			if (timestamp != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(timestamp);
				num11 += 2;
				num += num11;
			}
			RepeatedField<int> repeatedField4 = trackedMissions_;
			FieldCodec<int> repeated_trackedMissions_codec = _repeated_trackedMissions_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_trackedMissions_codec);
			ConditionalEventHistoryData conditionalEventHistoryData = conditionalEventHistory_;
			num += num12;
			if (conditionalEventHistoryData != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(conditionalEventHistoryData);
				num13 += 2;
				num += num13;
			}
			RepeatedField<int> repeatedField5 = seenCraftingRecipes_;
			FieldCodec<int> repeated_seenCraftingRecipes_codec = _repeated_seenCraftingRecipes_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField5).CalculateSize((FieldCodec<>)(object)repeated_seenCraftingRecipes_codec);
			WrappedResponse wrappedResponse = lastResponse_;
			num += num14;
			if (wrappedResponse != null)
			{
				int num15 = CodedOutputStream.ComputeMessageSize(wrappedResponse);
				num15 += 3;
				num += num15;
			}
			Timestamp timestamp2 = lastRequestTimestamp_;
			if (timestamp2 != null)
			{
				int num16 = CodedOutputStream.ComputeMessageSize(timestamp2);
				num16 += 3;
				num += num16;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num17 = unknownFields.CalculateSize();
				num += num17;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60052FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F50", Offset = "0x7D2950", VA = "0x1807D3F50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Profile other)
		{
			//Discarded unreachable code: IL_030d
			if (other == null)
			{
				return;
			}
			if ((long)other.gameInfo_ != 0)
			{
				ProfileGameInfo profileGameInfo = gameInfo_;
				if (profileGameInfo == null)
				{
					ProfileGameInfo profileGameInfo2 = (gameInfo_ = new ProfileGameInfo());
					ProfileGameInfo profileGameInfo3 = gameInfo_;
				}
				ProfileGameInfo other2 = other.gameInfo_;
				profileGameInfo.MergeFrom(other2);
			}
			if ((long)_repeated_trackedMissions_codec != 0)
			{
				ProfileSettings profileSettings2 = default(ProfileSettings);
				if (settings_ == null)
				{
					ProfileSettings profileSettings = (settings_ = new ProfileSettings());
					profileSettings2 = settings_;
				}
				ProfileSettings other3 = other.settings_;
				profileSettings2.MergeFrom(other3);
			}
			if ((long)other.player_ != 0)
			{
				ProfilePlayer profilePlayer2 = default(ProfilePlayer);
				if (player_ == null)
				{
					ProfilePlayer profilePlayer = (player_ = new ProfilePlayer());
					profilePlayer2 = player_;
				}
				ProfilePlayer other4 = other.player_;
				profilePlayer2.MergeFrom(other4);
			}
			if ((long)other.world_ != 0)
			{
				ProfileWorld profileWorld2 = default(ProfileWorld);
				if (world_ == null)
				{
					ProfileWorld profileWorld = (world_ = new ProfileWorld());
					profileWorld2 = world_;
				}
				ProfileWorld other5 = other.world_;
				profileWorld2.MergeFrom(other5);
			}
			RepeatedField<TimerType> repeatedField = freeTimers_;
			RepeatedField<TimerType> repeatedField2 = other.freeTimers_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.weedController_ != 0)
			{
				WeedController weedController2 = default(WeedController);
				if (weedController_ == null)
				{
					WeedController weedController = (weedController_ = new WeedController());
					weedController2 = weedController_;
				}
				WeedController other6 = other.weedController_;
				weedController2.MergeFrom(other6);
			}
			if ((long)other.criticalSuccess_ != 0)
			{
				CriticalSuccess criticalSuccess2 = default(CriticalSuccess);
				if (criticalSuccess_ == null)
				{
					CriticalSuccess criticalSuccess = (criticalSuccess_ = new CriticalSuccess());
					criticalSuccess2 = criticalSuccess_;
				}
				CriticalSuccess other7 = other.criticalSuccess_;
				criticalSuccess2.MergeFrom(other7);
			}
			RepeatedField<int> repeatedField3 = usedPreferredItemIDs_;
			RepeatedField<int> repeatedField4 = other.usedPreferredItemIDs_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			RepeatedField<int> repeatedField5 = usedUniquePreferredItemIDs_;
			RepeatedField<int> repeatedField6 = other.usedUniquePreferredItemIDs_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			if ((long)other.lastDailyReset_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastDailyReset_ == null)
				{
					Timestamp timestamp = (lastDailyReset_ = new Timestamp());
					timestamp2 = lastDailyReset_;
				}
				Timestamp other8 = other.lastDailyReset_;
				timestamp2.MergeFrom(other8);
			}
			RepeatedField<int> repeatedField7 = trackedMissions_;
			RepeatedField<int> repeatedField8 = other.trackedMissions_;
			((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
			if ((long)other.conditionalEventHistory_ != 0)
			{
				ConditionalEventHistoryData conditionalEventHistoryData2 = default(ConditionalEventHistoryData);
				if (conditionalEventHistory_ == null)
				{
					ConditionalEventHistoryData conditionalEventHistoryData = (conditionalEventHistory_ = new ConditionalEventHistoryData());
					conditionalEventHistoryData2 = conditionalEventHistory_;
				}
				ConditionalEventHistoryData other9 = other.conditionalEventHistory_;
				conditionalEventHistoryData2.MergeFrom(other9);
			}
			RepeatedField<int> repeatedField9 = seenCraftingRecipes_;
			RepeatedField<int> repeatedField10 = other.seenCraftingRecipes_;
			((RepeatedField<T>)(object)repeatedField9).Add((IEnumerable<>)(object)repeatedField10);
			if ((long)other.lastResponse_ != 0)
			{
				WrappedResponse wrappedResponse2 = default(WrappedResponse);
				if (lastResponse_ == null)
				{
					WrappedResponse wrappedResponse = (lastResponse_ = new WrappedResponse());
					wrappedResponse2 = lastResponse_;
				}
				WrappedResponse other10 = other.lastResponse_;
				wrappedResponse2.MergeFrom(other10);
			}
			if ((long)other.lastRequestTimestamp_ != 0)
			{
				Timestamp timestamp4 = default(Timestamp);
				if (lastRequestTimestamp_ == null)
				{
					Timestamp timestamp3 = (lastRequestTimestamp_ = new Timestamp());
					timestamp4 = lastRequestTimestamp_;
				}
				Timestamp other11 = other.lastRequestTimestamp_;
				timestamp4.MergeFrom(other11);
			}
			bool flag = other.isSane_;
			if (flag)
			{
				isSane_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60052FF")]
		[Cpp2IlInjected.Address(RVA = "0x7D3890", Offset = "0x7D2290", VA = "0x1807D3890", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_034d
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 258)
			{
				if ((int)num > 354)
				{
					if ((int)num > 370)
					{
						if (num == 80002)
						{
							WrappedResponse wrappedResponse = lastResponse_;
							if (wrappedResponse == null)
							{
								WrappedResponse wrappedResponse2 = (lastResponse_ = new WrappedResponse());
							}
							input.ReadMessage(wrappedResponse);
						}
						Timestamp timestamp = default(Timestamp);
						if (num == 80010)
						{
							Timestamp builder = default(Timestamp);
							if (lastRequestTimestamp_ == null)
							{
								timestamp = (lastRequestTimestamp_ = new Timestamp());
								builder = lastRequestTimestamp_;
							}
							input.ReadMessage(builder);
						}
						if ((long)timestamp != 160000)
						{
							goto IL_0336;
						}
						bool flag = (isSane_ = input.ReadBool());
					}
					ConditionalEventHistoryData conditionalEventHistoryData = default(ConditionalEventHistoryData);
					if (num == 362)
					{
						ConditionalEventHistoryData builder2 = default(ConditionalEventHistoryData);
						if (conditionalEventHistory_ == null)
						{
							conditionalEventHistoryData = (conditionalEventHistory_ = new ConditionalEventHistoryData());
							builder2 = conditionalEventHistory_;
						}
						input.ReadMessage(builder2);
					}
					if ((long)conditionalEventHistoryData != 4294967293L)
					{
						goto IL_0336;
					}
					RepeatedField<int> repeatedField = seenCraftingRecipes_;
					FieldCodec<int> repeated_seenCraftingRecipes_codec = _repeated_seenCraftingRecipes_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_seenCraftingRecipes_codec);
				}
				Timestamp timestamp2 = default(Timestamp);
				if ((int)num > 266)
				{
					if (num == 346)
					{
						Timestamp builder3 = default(Timestamp);
						if (lastDailyReset_ == null)
						{
							timestamp2 = (lastDailyReset_ = new Timestamp());
							builder3 = lastDailyReset_;
						}
						input.ReadMessage(builder3);
					}
					if ((long)timestamp2 != 4294967293L)
					{
						goto IL_0336;
					}
					RepeatedField<int> repeatedField2 = trackedMissions_;
					FieldCodec<int> repeated_trackedMissions_codec = _repeated_trackedMissions_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_trackedMissions_codec);
				}
				if ((long)timestamp2 != 4294967293L)
				{
					goto IL_0336;
				}
				RepeatedField<int> repeatedField3 = usedUniquePreferredItemIDs_;
				FieldCodec<int> repeated_usedUniquePreferredItemIDs_codec = _repeated_usedUniquePreferredItemIDs_codec;
				((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_usedUniquePreferredItemIDs_codec);
			}
			WeedController weedController = default(WeedController);
			if ((int)num > 184)
			{
				CriticalSuccess criticalSuccess = default(CriticalSuccess);
				if ((int)num > 234)
				{
					if (num == 250)
					{
						CriticalSuccess builder4 = default(CriticalSuccess);
						if (criticalSuccess_ == null)
						{
							criticalSuccess = (criticalSuccess_ = new CriticalSuccess());
							builder4 = criticalSuccess_;
						}
						input.ReadMessage(builder4);
					}
					if ((long)criticalSuccess != 4294967293L)
					{
						goto IL_0336;
					}
					RepeatedField<int> repeatedField4 = usedPreferredItemIDs_;
					FieldCodec<int> repeated_usedPreferredItemIDs_codec = _repeated_usedPreferredItemIDs_codec;
					((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_usedPreferredItemIDs_codec);
				}
				if ((long)criticalSuccess == 186)
				{
					goto IL_02bd;
				}
				if ((long)criticalSuccess != 234)
				{
					goto IL_0336;
				}
				WeedController builder5 = default(WeedController);
				if (weedController_ == null)
				{
					weedController = (weedController_ = new WeedController());
					builder5 = weedController_;
				}
				input.ReadMessage(builder5);
			}
			if ((long)weedController <= 18)
			{
				goto IL_02d6;
			}
			ProfilePlayer profilePlayer = default(ProfilePlayer);
			if ((long)weedController == 26)
			{
				ProfilePlayer builder6 = default(ProfilePlayer);
				if (player_ == null)
				{
					profilePlayer = (player_ = new ProfilePlayer());
					builder6 = player_;
				}
				input.ReadMessage(builder6);
			}
			ProfileWorld profileWorld = default(ProfileWorld);
			if ((long)profilePlayer == 34)
			{
				ProfileWorld builder7 = default(ProfileWorld);
				if (world_ == null)
				{
					profileWorld = (world_ = new ProfileWorld());
					builder7 = world_;
				}
				input.ReadMessage(builder7);
			}
			if ((long)profileWorld == 184)
			{
				goto IL_02bd;
			}
			goto IL_0336;
			IL_02bd:
			RepeatedField<TimerType> repeatedField5 = freeTimers_;
			FieldCodec<TimerType> repeated_freeTimers_codec = _repeated_freeTimers_codec;
			((RepeatedField<T>)(object)repeatedField5).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_freeTimers_codec);
			goto IL_02d6;
			IL_0336:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_02d6:
			ProfileGameInfo profileGameInfo = default(ProfileGameInfo);
			if ((long)profileWorld == 10)
			{
				ProfileGameInfo builder8 = default(ProfileGameInfo);
				if (gameInfo_ == null)
				{
					profileGameInfo = (gameInfo_ = new ProfileGameInfo());
					builder8 = gameInfo_;
				}
				input.ReadMessage(builder8);
			}
			if ((long)profileGameInfo == 18)
			{
				ProfileSettings builder9 = default(ProfileSettings);
				if (settings_ == null)
				{
					ProfileSettings profileSettings = (settings_ = new ProfileSettings());
					builder9 = settings_;
				}
				input.ReadMessage(builder9);
			}
			goto IL_0336;
		}

		[Cpp2IlInjected.Token(Token = "0x6005300")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF5F0", VA = "0x1807D0BF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 33)
			{
				if (fieldNumber > 10000)
				{
					if (fieldNumber == 10001)
					{
						Timestamp timestamp = lastRequestTimestamp_;
					}
					if (fieldNumber != 20000)
					{
						goto IL_0094;
					}
					bool flag = isSane_;
				}
				if ((object)typeof(bool).TypeHandle != null && (object)typeof(bool).TypeHandle != null && (object)typeof(bool).TypeHandle != null && (long)typeof(bool).TypeHandle != 1)
				{
					if (fieldNumber != 10000)
					{
						goto IL_0094;
					}
					WrappedResponse wrappedResponse = lastResponse_;
				}
			}
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 1)
			{
				if (fieldNumber == 23)
				{
					RepeatedField<TimerType> repeatedField = freeTimers_;
				}
				if (num != 0 && num != 0 && num != 0)
				{
					switch (num)
					{
					}
				}
			}
			goto IL_0094;
			IL_0094:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005301")]
		[Cpp2IlInjected.Address(RVA = "0x7D72F0", Offset = "0x7D5CF0", VA = "0x1807D72F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_002c: Expected O, but got I4
			//IL_003c: Expected I4, but got O
			object obj = default(object);
			while (true)
			{
				if (fieldNumber > 33)
				{
					if (fieldNumber > 10000)
					{
						if (fieldNumber == 10001)
						{
							int num = 0;
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							lastRequestTimestamp_ = (Timestamp)num;
						}
						else
						{
							while (fieldNumber != 20000)
							{
							}
							isSane_ = (byte)(int)obj != 0;
						}
						return;
					}
					if ((object)typeof(WrappedResponse).TypeHandle != null)
					{
						if ((object)typeof(WrappedResponse).TypeHandle == null)
						{
							continue;
						}
						if ((object)typeof(WrappedResponse).TypeHandle != null)
						{
							if ((long)typeof(WrappedResponse).TypeHandle != 1)
							{
								while (fieldNumber != 10000)
								{
								}
								if (value == null || value != null)
								{
									goto IL_0075;
								}
							}
							InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
							break;
						}
						goto IL_0075;
					}
					goto IL_0080;
				}
				goto IL_008b;
				IL_0075:
				if (value != null && value == null)
				{
					break;
				}
				goto IL_0080;
				IL_008b:
				int num2 = fieldNumber - 1;
				if (num2 != 0)
				{
					if (num2 != 0)
					{
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								if (fieldNumber == 23)
								{
									continue;
								}
								if (num2 != 0)
								{
									while (num2 == 0)
									{
									}
									if ((num2 != 0 && (num2 == 0 || num2 == 1)) || (value != null && value == null))
									{
										continue;
									}
								}
								if (value != null && value == null)
								{
									continue;
								}
							}
							if (value != null && value == null)
							{
								continue;
							}
						}
						if (value != null && value == null)
						{
							continue;
						}
					}
					if (value != null && value == null)
					{
						continue;
					}
				}
				if (value == null || value != null)
				{
				}
				throw new InvalidCastException();
				IL_0080:
				if (value != null && value == null)
				{
					continue;
				}
				goto IL_008b;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005302")]
		[Cpp2IlInjected.Address(RVA = "0x7CD420", Offset = "0x7CBE20", VA = "0x1807CD420", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0087
			if (fieldNumber > 33)
			{
				if (fieldNumber > 10000)
				{
					if (fieldNumber == 10001)
					{
					}
					if (fieldNumber == 20000)
					{
						isSane_ = false;
					}
					return;
				}
				if ((object)typeof(IList).TypeHandle != null && (object)typeof(IList).TypeHandle != null && (object)typeof(IList).TypeHandle != null && (long)typeof(IList).TypeHandle != 1 && fieldNumber != 10000)
				{
					return;
				}
			}
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 0 || num == 1)
			{
				return;
			}
			if (fieldNumber == 23)
			{
				RepeatedField<TimerType> repeatedField = freeTimers_;
			}
			if (num != 0 && num != 0 && num != 0)
			{
				switch (num)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005304")]
		[Cpp2IlInjected.Address(RVA = "0x7D37F0", Offset = "0x7D21F0", VA = "0x1807D37F0", Slot = "22")]
		public bool IsHangingOutWith(Item item)
		{
			Character _003CHangingOutWithCharacter_003Ek__BackingField = HangoutState.HangingOutWithCharacter;
			if (_003CHangingOutWithCharacter_003Ek__BackingField != null)
			{
				int iD = _003CHangingOutWithCharacter_003Ek__BackingField.Data.ID;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005305")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6E0", Offset = "0x7C90E0", VA = "0x1807CA6E0")]
		internal int AddItemCollectMinigame(DateTime startTime, ItemCollectMinigameData minigameData, IPlayerEventDispatcher dispatcher, bool delayedStart = false, [Optional] List<MultiItemInstance> itemsToCollect)
		{
			//Discarded unreachable code: IL_00c2
			//IL_000d: Expected O, but got I4
			List<MultiItemInstance> itemsToCollect2 = (List<MultiItemInstance>)0;
			List<MultiItemInstance> list = itemsToCollect2;
			if (list == null)
			{
				ItemCollectMinigameData itemCollectMinigameData = minigameData;
				int num = default(int);
				IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Range(0, num);
				Func<int, MultiItemInstance> func = (Func<int, MultiItemInstance>)(object)(Func<T, TResult>)((int x) => minigameData.rewardsPerItem_.Clone());
				itemsToCollect2 = (List<MultiItemInstance>)(object)Enumerable.ToList<MultiItemInstance>(Enumerable.Select<int, MultiItemInstance>((IEnumerable<>)enumerable, (Func<, >)(object)func));
				if (list == null)
				{
					ArgumentException ex = new ArgumentException("A minigame must give rewards");
					/*Error: Unexpected end of block*/;
				}
			}
			ApplySoftCurrencyMultiplier();
			ItemCollectMinigame itemCollectMinigame = new ItemCollectMinigame();
			int num2 = (itemCollectMinigame.ID = ((List<>)(object)itemCollectMinigames)._size);
			itemCollectMinigame.State = ItemCollectMinigame.MinigameState.NotStarted;
			ItemCollectMinigameData itemCollectMinigameData2 = (itemCollectMinigame.MinigameData = minigameData);
			List<MultiItemInstance> list2 = (itemCollectMinigame.ItemsToCollect = itemsToCollect2);
			((List<T>)(object)itemCollectMinigames).Add((T)itemCollectMinigame);
			return itemCollectMinigame.ID;
			[Cpp2IlInjected.Token(Token = "0x60053A4")]
			[Cpp2IlInjected.Address(RVA = "0x10E0A10", Offset = "0x10DF410", VA = "0x1810E0A10")]
			unsafe void ApplySoftCurrencyMultiplier()
			{
				//Discarded unreachable code: IL_003b, IL_0041, IL_0047, IL_004d, IL_0053
				bool flag = default(bool);
				bool flag2 = default(bool);
				Item item = default(Item);
				while (true)
				{
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					List<MultiItemInstance> list3 = itemsToCollect2;
					if (!flag || !flag2)
					{
						break;
					}
					int num6 = 0;
					Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
					if (*(Item*)item == *(Item*)softCurrencyItem)
					{
						ProfilePlayer profilePlayer = player_;
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005306")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940")]
		internal bool StartItemCollectMinigame(int minigameID, ITransactionContext context)
		{
			//IL_003f: Expected I4, but got I8
			List<ItemCollectMinigame> list = itemCollectMinigames;
			Func<ItemCollectMinigame, bool> func = (Func<ItemCollectMinigame, bool>)(object)(Func<T, TResult>)delegate(ItemCollectMinigame x)
			{
				//Discarded unreachable code: IL_0011
				int num = minigameID;
				return x.ID == num;
			};
			ItemCollectMinigame itemCollectMinigame = Enumerable.FirstOrDefault<ItemCollectMinigame>((IEnumerable<>)list, (Func<, >)(object)func);
			if (itemCollectMinigame != null && itemCollectMinigame.State != ItemCollectMinigame.MinigameState.Started)
			{
				itemCollectMinigame.State = ItemCollectMinigame.MinigameState.Started;
				TimeSpan timeSpan = itemCollectMinigame.MinigameData.duration_.ToTimeSpan();
				DateTime _003CEndTime_003Ek__BackingField = default(DateTime);
				itemCollectMinigame.EndTime = _003CEndTime_003Ek__BackingField;
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005307")]
		[Cpp2IlInjected.Address(RVA = "0x7CD5F0", Offset = "0x7CBFF0", VA = "0x1807CD5F0")]
		internal CollectMinigameItem.Types.Result CollectMinigameItem(int minigameID, int itemIndex, in Player player, in World world, ITransactionContext context)
		{
			List<ItemCollectMinigame> list = itemCollectMinigames;
			Func<ItemCollectMinigame, bool> func = (Func<ItemCollectMinigame, bool>)(object)(Func<T, TResult>)delegate(ItemCollectMinigame x)
			{
				//Discarded unreachable code: IL_0011
				int num = minigameID;
				return x.ID == num;
			};
			bool flag = default(bool);
			CollectMinigameItem.Types.Result result = default(CollectMinigameItem.Types.Result);
			if (Enumerable.FirstOrDefault<ItemCollectMinigame>((IEnumerable<>)list, (Func<, >)(object)func) != null && !flag)
			{
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005308")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AD0", Offset = "0x7D64D0", VA = "0x1807D7AD0")]
		internal bool StopItemCollectMinigame(int minigameID, in Player player, ITransactionContext context)
		{
			List<ItemCollectMinigame> list = itemCollectMinigames;
			Func<ItemCollectMinigame, bool> func = (Func<ItemCollectMinigame, bool>)(object)(Func<T, TResult>)delegate(ItemCollectMinigame x)
			{
				//Discarded unreachable code: IL_0011
				int num = minigameID;
				return x.ID == num;
			};
			ItemCollectMinigame itemCollectMinigame = Enumerable.FirstOrDefault<ItemCollectMinigame>((IEnumerable<>)list, (Func<, >)(object)func);
			if (itemCollectMinigame != null && itemCollectMinigame.State == ItemCollectMinigame.MinigameState.Started)
			{
				IPlayerEventDispatcher dispatcher = player.dispatcher;
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005309")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CE9A0", VA = "0x1807CFFA0", Slot = "16")]
		void IRewardRecipient.AddCharacterFriendship(Item item, int amount, FriendshipSource source, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001c
			if ((object)item == null)
			{
			}
			int num = 0;
			if (amount != 0)
			{
			}
			int num2 = 0;
			if ((object)typeof(ProfileEventDispatcher).TypeHandle != null)
			{
			}
			ProfileWorld profileWorld = world_;
		}

		[Cpp2IlInjected.Token(Token = "0x600530A")]
		[Cpp2IlInjected.Address(RVA = "0x7D02D0", Offset = "0x7CECD0", VA = "0x1807D02D0", Slot = "14")]
		bool IRewardRecipient.CanAddItem(Item item, int amount, ItemState state)
		{
			//IL_000c: Expected O, but got I4
			int num = 0;
			return CanAddItem(item, amount, state, (InventoryFullResolution)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600530B")]
		[Cpp2IlInjected.Address(RVA = "0x7D0170", Offset = "0x7CEB70", VA = "0x1807D0170", Slot = "15")]
		void IRewardRecipient.AddItem(Item item, int amount, IProfileEventDispatcher dispatcher, ITransactionContext context, Item? characterItem, ItemState state, bool canSendToInbox)
		{
			int num = 0;
			if (dispatcher == null)
			{
			}
			int num2 = 0;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005310")]
		[Cpp2IlInjected.Address(RVA = "0x7D1670", Offset = "0x7D0070", VA = "0x1807D1670")]
		public MiniProfile GetMiniProfile()
		{
			//Discarded unreachable code: IL_00c5
			MiniProfile miniProfile = new MiniProfile();
			ProfileGameInfo profileGameInfo = (miniProfile.gameInfo_ = gameInfo_);
			ProfilePlayer profilePlayer = player_;
			int num = 0;
			if (profilePlayer != null)
			{
			}
			miniProfile.playerLevel_ = num;
			if (player_ != null)
			{
			}
			miniProfile.playerXp_ = num;
			ProfilePlayer profilePlayer2 = player_;
			if (profilePlayer2 == null || profilePlayer2.name_ == null)
			{
			}
			miniProfile.PlayerName = "";
			if (player_ != null)
			{
			}
			miniProfile.timePlayedInMinutes_ = num;
			if (player_ != null)
			{
				int num2 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			}
			miniProfile.softCurrency_ = num;
			if (player_ != null)
			{
				int num3 = 0;
				Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			}
			int hardCurrency_ = default(int);
			miniProfile.hardCurrency_ = hardCurrency_;
			if (player_ != null)
			{
				MapField<int, int> platformSpecificHardCurrencies_ = miniProfile.platformSpecificHardCurrencies_;
				int num4 = 0;
				Item hardCurrencyItem2 = CurrencyItem.HardCurrencyItem;
				Dictionary<int, int> dictionary = default(Dictionary<int, int>);
				((MapField<TKey, TValue>)(object)platformSpecificHardCurrencies_).Add((IDictionary<, >)dictionary);
			}
			return miniProfile;
		}

		[Cpp2IlInjected.Token(Token = "0x600532E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2C0", Offset = "0x7D9CC0", VA = "0x1807DB2C0")]
		public static implicit operator PlayerProfile(Profile profile)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600532F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2C0", Offset = "0x7D9CC0", VA = "0x1807DB2C0")]
		public static implicit operator WorldProfile(Profile profile)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005333")]
		[Cpp2IlInjected.Address(RVA = "0x7D50B0", Offset = "0x7D3AB0", VA = "0x1807D50B0")]
		public unsafe static TemporaryOverrideScope OverrideSaveWithoutUpdatingContext()
		{
			//IL_0029: Expected O, but got I4
			if (_003C_003Ec._003C_003E9__196_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action)delegate
				{
					int num2 = 0;
					BeginOverrideNoSaveContext();
				};
			}
			int num = default(int);
			Action action = new Action(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<void>*/)(&EndOverrideNoSaveContext));
			num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005334")]
		[Cpp2IlInjected.Address(RVA = "0x7CB700", Offset = "0x7CA100", VA = "0x1807CB700")]
		public static void BeginOverrideNoSaveContext()
		{
			int val = _overrideSaveWithoutUpdatingContext + 1;
			_overrideSaveWithoutUpdatingContext = Math.Max(0, val);
		}

		[Cpp2IlInjected.Token(Token = "0x6005335")]
		[Cpp2IlInjected.Address(RVA = "0x7D03D0", Offset = "0x7CEDD0", VA = "0x1807D03D0")]
		public static void EndOverrideNoSaveContext()
		{
			int val = _overrideSaveWithoutUpdatingContext - 1;
			_overrideSaveWithoutUpdatingContext = Math.Max(0, val);
		}

		[Cpp2IlInjected.Token(Token = "0x6005336")]
		[Cpp2IlInjected.Address(RVA = "0x7CD790", Offset = "0x7CC190", VA = "0x1807CD790")]
		public unsafe void Create(ITransactionContext context)
		{
			//Discarded unreachable code: IL_027c, IL_028f, IL_06c7, IL_06cd, IL_06d3
			//IL_00ff: Expected O, but got I4
			//IL_00ff: Expected O, but got I4
			//IL_01c3: Expected O, but got I4
			//IL_0250: Expected O, but got I4
			//IL_02a7: Expected O, but got I4
			//IL_0383: Expected O, but got I4
			//IL_039b: Expected O, but got I4
			//IL_03ba: Expected O, but got I4
			//IL_03d9: Expected O, but got I4
			//IL_03f8: Expected O, but got I4
			//IL_0417: Expected O, but got I4
			//IL_0436: Expected O, but got I4
			//IL_0455: Expected O, but got I4
			//IL_0474: Expected O, but got I4
			//IL_0493: Expected O, but got I4
			//IL_04d0: Expected O, but got I4
			//IL_051e: Expected I8, but got O
			//IL_0519: Expected native int or pointer, but got O
			//IL_0536: Expected I4, but got I8
			//IL_0573: Expected I4, but got I8
			//IL_05b0: Expected I4, but got I8
			//IL_05ed: Expected I4, but got I8
			//IL_062b: Expected I4, but got I8
			//IL_0669: Expected I4, but got I8
			//IL_0699: Expected O, but got I4
			//IL_06aa: Expected I4, but got O
			//IL_06ba: Expected I4, but got O
			//IL_06c6: Expected O, but got I4
			int num;
			Timestamp created_ = default(Timestamp);
			bool flag = default(bool);
			string path = default(string);
			Func<FishSpawningInVillageRecurringEventItemData, bool> func = default(Func<FishSpawningInVillageRecurringEventItemData, bool>);
			IEnumerable<> enumerable = default(IEnumerable<>);
			Func<FishSpawningInVillageRecurringEventItemData, VillageAreaType> func2 = default(Func<FishSpawningInVillageRecurringEventItemData, VillageAreaType>);
			Func<FishSpawningInVillageRecurringEventItemData, FishSpawningInVillageRecurringEventItemData> func3 = default(Func<FishSpawningInVillageRecurringEventItemData, FishSpawningInVillageRecurringEventItemData>);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			int num12 = default(int);
			byte[] array = default(byte[]);
			IEnumerable<House.Types.Floor> enumerable3 = default(IEnumerable<House.Types.Floor>);
			uint num13 = default(uint);
			NullReferenceException ex = default(NullReferenceException);
			IEnumerable<IGrid> cpp2il__autoParamName__idx_ = default(IEnumerable<IGrid>);
			uint num17 = default(uint);
			bool flag6 = default(bool);
			BuildingItemType buildingItemType = default(BuildingItemType);
			int num19 = default(int);
			bool flag7 = default(bool);
			ContainerInventory containerInventory = default(ContainerInventory);
			ContainerInventory containerInventory2 = default(ContainerInventory);
			ContainerInventory containerInventory3 = default(ContainerInventory);
			ContainerInventory containerInventory4 = default(ContainerInventory);
			ListInventory listInventory = default(ListInventory);
			ListInventory listInventory2 = default(ListInventory);
			ListInventory listInventory3 = default(ListInventory);
			ListInventory listInventory4 = default(ListInventory);
			ListInventory listInventory5 = default(ListInventory);
			ListInventory listInventory6 = default(ListInventory);
			ListInventory listInventory7 = default(ListInventory);
			ListInventory listInventory8 = default(ListInventory);
			ListInventory listInventory9 = default(ListInventory);
			ListInventory listInventory10 = default(ListInventory);
			ListInventory listInventory11 = default(ListInventory);
			ListInventory listInventory12 = default(ListInventory);
			ListInventory listInventory13 = default(ListInventory);
			ListInventory listInventory14 = default(ListInventory);
			ListInventory listInventory15 = default(ListInventory);
			ListInventory listInventory16 = default(ListInventory);
			ListInventory listInventory17 = default(ListInventory);
			ListInventory listInventory18 = default(ListInventory);
			ListInventory listInventory19 = default(ListInventory);
			ListInventory listInventory20 = default(ListInventory);
			ListInventory listInventory21 = default(ListInventory);
			ListInventory listInventory22 = default(ListInventory);
			ListInventory listInventory23 = default(ListInventory);
			ListInventory listInventory24 = default(ListInventory);
			IEnumerable<> enumerable4 = default(IEnumerable<>);
			uint num30 = default(uint);
			MealItemData mealItemData = default(MealItemData);
			int num31 = default(int);
			int num32;
			do
			{
				IL_0000:
				num = 0;
				int num2 = 0;
				gameInfo_.created_ = created_;
				Random random = new Random();
				ProfilePlayer profilePlayer = player_;
				int num3 = (profilePlayer.randomMasterSeed_ = random.Next());
				int num4 = 0;
				DebugSettings settings = DebugSettings.Settings;
				string defaultVillageDataPath_ = settings.defaultVillageDataPath_;
				if (settings != null)
				{
					int num5 = 0;
					CustomOptions customOptions = DebugSettings.Descriptor.FindFieldByName("DefaultVillageDataPath").CustomOptions;
					if (flag)
					{
						int num6 = 0;
					}
				}
				if (settings == null)
				{
					DefaultVillageData defaultVillageData = ProtoParser.Parse<DefaultVillageData>(FileSystem.Data.ReadAllBytes(defaultVillageDataPath_));
					Village village_ = world_.village_;
					Village defaultVillage_ = defaultVillageData.defaultVillage_;
					village_.MergeFrom(defaultVillage_);
					ICollection<Village.Types.VillageArea> values = (ICollection<Village.Types.VillageArea>)((MapField<TKey, TValue>)(object)world_.village_.areas_).get_Values();
					if (values != null)
					{
						IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
						RepeatedField<string> gridLayoutPaths_ = defaultVillageData.gridLayoutPaths_;
						GridCollection gridCollection = ProtoParser.Parse<GridCollection>(_003CData_003Ek__BackingField.ReadAllBytes(path));
						GridCollection gridCollection_ = world_.gridCollection_;
						int num7 = 0;
						int num8 = 0;
						uint num9 = gridCollection_.MergeGridCollection(gridCollection, (uint)num8, (List<>)num7, (Action<, >)num);
					}
					int num10 = 0;
					if (values != null)
					{
					}
					if (num != 0)
					{
						goto IL_0000;
					}
					if (_003C_003Ec._003C_003E9__199_0 == null)
					{
						func = (Func<FishSpawningInVillageRecurringEventItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FishSpawningInVillageRecurringEventItemData x) => x.location_.useField_));
					}
					IEnumerable<FishSpawningInVillageRecurringEventItemData> enumerable2 = (IEnumerable<FishSpawningInVillageRecurringEventItemData>)Enumerable.Where<FishSpawningInVillageRecurringEventItemData>(enumerable, (Func<, >)(object)func);
					if (_003C_003Ec._003C_003E9__199_1 == null)
					{
						func2 = (Func<FishSpawningInVillageRecurringEventItemData, VillageAreaType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FishSpawningInVillageRecurringEventItemData x) => x.location_.VillageArea));
					}
					if (_003C_003Ec._003C_003E9__199_2 == null)
					{
						func3 = (Func<FishSpawningInVillageRecurringEventItemData, FishSpawningInVillageRecurringEventItemData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FishSpawningInVillageRecurringEventItemData x) => x));
					}
					Dictionary<FishSpawningInVillageRecurringEventItemData, VillageAreaType> dictionary = (Dictionary<FishSpawningInVillageRecurringEventItemData, VillageAreaType>)(object)Enumerable.ToDictionary<FishSpawningInVillageRecurringEventItemData, VillageAreaType, FishSpawningInVillageRecurringEventItemData>((IEnumerable<>)enumerable2, (Func<, >)(object)func2, (Func<, >)(object)func3);
					int num11 = 0;
					if (flag2)
					{
						Dictionary<, >.Entry[] entries = (Dictionary<, >.Entry[])(object)((Dictionary<, >)(object)dictionary).entries;
						if (flag3)
						{
							Func<VillageAreaData.Types.Data, bool> func4 = (Func<VillageAreaData.Types.Data, bool>)(object)new Func<T, TResult>(new _003C_003Ec__DisplayClass199_0()._003CCreate_003Eb__3);
							while (!flag4)
							{
							}
							while (!flag5)
							{
							}
							RecurringEvent recurringEvent = RecurringEvent.Create((IRecurringEventData)num);
						}
						num12 = 0;
						if (num != 0)
						{
							goto IL_0000;
						}
					}
				}
				IFileSystem _003CData_003Ek__BackingField2 = FileSystem.Data;
				DefaultPlayerHouseData defaultPlayerHouseData = ProtoParser.Parse<DefaultPlayerHouseData>(array);
				House defaultHouse_ = defaultPlayerHouseData.defaultHouse_;
				Dictionary<uint, Action<uint>> setterByGridID = (Dictionary<uint, Action<uint>>)(object)new Dictionary<TKey, TValue>();
				if (_003C_003Ec._003C_003E9__199_5 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(House.Types.Floor x)
					{
						ICollection<House.Types.Room> values2 = (ICollection<House.Types.Room>)((MapField<TKey, TValue>)(object)x.rooms_).get_Values();
						throw new NullReferenceException();
					};
				}
				if (enumerable3 != null)
				{
					if (num12 < (int)num13)
					{
						num12 += num12;
						if (num12 == (int)num13)
						{
							if (num != 0)
							{
								goto IL_0000;
							}
							goto IL_02cc;
						}
						num12++;
					}
					House.Types.Room room = (House.Types.Room)num12;
					Dictionary<uint, Action<uint>> dictionary2 = setterByGridID;
					uint floorGridID_ = room.floorGridID_;
					Action<uint> action = (Action<uint>)(object)(Action<T>)delegate(uint newGridID)
					{
						//Discarded unreachable code: IL_000d
						room.floorGridID_ = newGridID;
					};
					throw new NullReferenceException();
				}
				goto IL_02cc;
				IL_02cc:
				int num14 = 0;
				if (enumerable3 != null)
				{
				}
				if (num != 0)
				{
					goto IL_0000;
				}
				string helpURL = ((Exception)ex)._helpURL;
				GridCollection defaultGridCollection_ = defaultPlayerHouseData.defaultGridCollection_;
				Action<uint, uint> action2 = (Action<uint, uint>)(object)new Action<T1, T2>(ReattributeGridIDCallback);
				int num15 = 0;
				int num16 = 0;
				IGrid[] array2 = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<IGrid>();
				if (num14 < array2.Length)
				{
					IGrid grid = array2[num14];
					if (num14 < (int)num17)
					{
						num14 += num14;
						num14++;
					}
					if (num14 != 0)
					{
						while (!flag6)
						{
						}
						while (buildingItemType != BuildingItemType.PlayerHouse)
						{
						}
						int num18 = (int)buildingItemType;
						num18 += num18;
					}
					num19 = 0;
					if (num14 != 0)
					{
					}
					if (num != 0)
					{
						goto IL_0000;
					}
					num14++;
				}
				if (flag7)
				{
					((RepeatedField<T>)(object)containerInventory.inventory_).Clear();
					int num20 = 0;
					containerInventory2.MergeFrom((ContainerInventory)num20);
					((RepeatedField<T>)(object)containerInventory3.inventory_).Clear();
					int num21 = 0;
					containerInventory4.MergeFrom((ContainerInventory)num21);
					((MapField<TKey, TValue>)(object)listInventory.inventory_).Clear();
					listInventory2.ClearSubTypeRestrictions();
					int num22 = 0;
					listInventory3.MergeFrom((ListInventory)num22);
					((MapField<TKey, TValue>)(object)listInventory4.inventory_).Clear();
					listInventory5.ClearSubTypeRestrictions();
					int num23 = 0;
					listInventory6.MergeFrom((ListInventory)num23);
					((MapField<TKey, TValue>)(object)listInventory7.inventory_).Clear();
					listInventory8.ClearSubTypeRestrictions();
					int num24 = 0;
					listInventory9.MergeFrom((ListInventory)num24);
					((MapField<TKey, TValue>)(object)listInventory10.inventory_).Clear();
					listInventory11.ClearSubTypeRestrictions();
					int num25 = 0;
					listInventory12.MergeFrom((ListInventory)num25);
					((MapField<TKey, TValue>)(object)listInventory13.inventory_).Clear();
					listInventory14.ClearSubTypeRestrictions();
					int num26 = 0;
					listInventory15.MergeFrom((ListInventory)num26);
					((MapField<TKey, TValue>)(object)listInventory16.inventory_).Clear();
					listInventory17.ClearSubTypeRestrictions();
					int num27 = 0;
					listInventory18.MergeFrom((ListInventory)num27);
					((MapField<TKey, TValue>)(object)listInventory19.inventory_).Clear();
					listInventory20.ClearSubTypeRestrictions();
					int num28 = 0;
					listInventory21.MergeFrom((ListInventory)num28);
					((MapField<TKey, TValue>)(object)listInventory22.inventory_).Clear();
					listInventory23.ClearSubTypeRestrictions();
					int num29 = 0;
					listInventory24.MergeFrom((ListInventory)num29);
				}
				if (enumerable4 != null)
				{
					if (num19 < (int)num30)
					{
						num19 += num19;
						if (num19 == (int)num30)
						{
							goto IL_04d2;
						}
						num19++;
					}
					while (mealItemData == null)
					{
					}
					while (!mealItemData.canBeUsedAsIngredient_)
					{
					}
					uint glotID_ = mealItemData.glotID_;
					num31 = ((glPlayFab.Disney.BattlePassReward)num19).Price;
					goto IL_04d2;
				}
				goto IL_04d9;
				IL_04d2:
				num31 += num31;
				goto IL_04d9;
				IL_04d9:
				num32 = 0;
				if (enumerable4 != null)
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60053C2")]
				[Cpp2IlInjected.Address(RVA = "0x10E0CF0", Offset = "0x10DF6F0", VA = "0x1810E0CF0")]
				void ReattributeGridIDCallback(uint oldID, uint newID)
				{
					//Discarded unreachable code: IL_000c
					Dictionary<uint, Action<uint>> dictionary3 = setterByGridID;
					bool flag9 = default(bool);
					if (!flag9)
					{
					}
				}
			}
			while (num != 0);
			if (_003C_003Ec._003C_003E9__199_8 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			if (num != 0)
			{
				int num33 = 0;
				DateTime dateTime = default(DateTime);
				Timestamp timestamp = dateTime.ToProto();
				((DateTime*)(IntPtr)dateTime)->dateData = (ulong)(long)timestamp;
			}
			ProfileLimits profileLimits = new ProfileLimits();
			LimitedAction limitedAction = new LimitedAction();
			limitedAction.maxCount_ = 5;
			AnyFatigue anyFatigue = new AnyFatigue();
			int num34 = 0;
			FrequencyFatigue frequencyFatigue = (FrequencyFatigue)(anyFatigue.Fatigue = FrequencyFatigue.CreateDefault);
			limitedAction.fatigue_ = anyFatigue;
			limitedAction.fatigue_ = (AnyFatigue)(object)limitedAction;
			LimitedAction limitedAction2 = new LimitedAction();
			limitedAction2.maxCount_ = 5;
			AnyFatigue anyFatigue2 = new AnyFatigue();
			int num35 = 0;
			FrequencyFatigue frequencyFatigue2 = (FrequencyFatigue)(anyFatigue2.Fatigue = FrequencyFatigue.CreateDefault);
			limitedAction2.fatigue_ = anyFatigue2;
			limitedAction2.fatigue_ = (AnyFatigue)(object)limitedAction2;
			LimitedAction limitedAction3 = new LimitedAction();
			limitedAction3.maxCount_ = 5;
			AnyFatigue anyFatigue3 = new AnyFatigue();
			int num36 = 0;
			FrequencyFatigue frequencyFatigue3 = (FrequencyFatigue)(anyFatigue3.Fatigue = FrequencyFatigue.CreateDefault);
			limitedAction3.fatigue_ = anyFatigue3;
			limitedAction3.fatigue_ = (AnyFatigue)(object)limitedAction3;
			LimitedAction limitedAction4 = new LimitedAction();
			limitedAction4.maxCount_ = 5;
			AnyFatigue anyFatigue4 = new AnyFatigue();
			int num37 = 0;
			FrequencyFatigue frequencyFatigue4 = (FrequencyFatigue)(anyFatigue4.Fatigue = FrequencyFatigue.CreateDefault);
			limitedAction4.fatigue_ = anyFatigue4;
			limitedAction4.fatigue_ = (AnyFatigue)(object)limitedAction4;
			LimitedAction limitedAction5 = new LimitedAction();
			limitedAction5.maxCount_ = 10;
			AnyFatigue anyFatigue5 = new AnyFatigue();
			int num38 = 0;
			FrequencyFatigue frequencyFatigue5 = (FrequencyFatigue)(anyFatigue5.Fatigue = FrequencyFatigue.CreateDefault);
			limitedAction5.fatigue_ = anyFatigue5;
			limitedAction5.fatigue_ = (AnyFatigue)(object)limitedAction5;
			LimitedAction limitedAction6 = new LimitedAction();
			limitedAction6.maxCount_ = 25;
			bool flag8 = default(bool);
			if (!flag8)
			{
				AnyFatigue anyFatigue6 = new AnyFatigue();
				int num39 = 0;
				FrequencyFatigue frequencyFatigue6 = (FrequencyFatigue)(anyFatigue6.Fatigue = FrequencyFatigue.CreateDefault);
				limitedAction6.fatigue_ = anyFatigue6;
			}
			limitedAction6.fatigue_ = (AnyFatigue)num;
			IFatigue fatigue = default(IFatigue);
			int num40 = default(int);
			if (fatigue != null)
			{
				num40 = 0;
				limitedAction6.maxCount_ = (int)fatigue;
			}
			num40 += 64;
			((int*)num40)->m_value = (int)limitedAction6;
			int num41 = 0;
			Avatar avatar = default(Avatar);
			avatar.clothingCustomization_ = (MapField<int, int>)num32;
		}

		[Cpp2IlInjected.Token(Token = "0x6005337")]
		[Cpp2IlInjected.Address(RVA = "0x7C8760", Offset = "0x7C7160", VA = "0x1807C8760")]
		public void Actualize(ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0380, IL_0386, IL_038c, IL_0392, IL_039e, IL_03a4, IL_03aa, IL_03b0, IL_03b6, IL_03bc, IL_03c2, IL_03c8, IL_03ce, IL_03d4, IL_03da, IL_03e0, IL_03e6, IL_03ec, IL_03f2, IL_03f8, IL_0404, IL_0410, IL_0416, IL_041c, IL_0422, IL_0428, IL_042e, IL_0434, IL_043a, IL_0440, IL_0446, IL_044c, IL_0452, IL_0458, IL_045e, IL_0464, IL_046a, IL_0470, IL_0476, IL_047c, IL_0488, IL_049a, IL_04a0, IL_04a6, IL_04ac, IL_04b2, IL_04b8, IL_04be, IL_04c4, IL_04ca, IL_04d0, IL_04d6, IL_04dc, IL_04e2, IL_04e8, IL_04ee, IL_04f4, IL_04fa, IL_0500, IL_0506
			//IL_027f: Expected O, but got I4
			//IL_02b4: Expected I4, but got O
			//IL_02be: Expected I4, but got I8
			//IL_02f9: Expected I4, but got O
			//IL_032d: Expected I4, but got O
			//IL_0337: Expected I4, but got I8
			//IL_0341: Expected I4, but got I8
			IEnumerable<> enumerable = default(IEnumerable<>);
			MapField<uint, RecurringEvent> recurringEvents_ = default(MapField<uint, RecurringEvent>);
			Func<KeyValuePair<uint, RecurringEvent>, bool> func = default(Func<KeyValuePair<uint, RecurringEvent>, bool>);
			ChooseVillageArea chooseVillageArea = default(ChooseVillageArea);
			Func<KeyValuePair<uint, RecurringEvent>, uint> func2 = default(Func<KeyValuePair<uint, RecurringEvent>, uint>);
			RecurringEvent recurringEvent = default(RecurringEvent);
			IRecurringEventData recurringEventData = default(IRecurringEventData);
			bool flag2 = default(bool);
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			int num6 = default(int);
			IEnumerable<KeyValuePair<int, Village.Types.VillageArea>> enumerable2 = default(IEnumerable<KeyValuePair<int, Village.Types.VillageArea>>);
			int num9 = default(int);
			Buff buff = default(Buff);
			Buff buff2 = default(Buff);
			bool flag3 = default(bool);
			IEnumerable<IItemData> enumerable3 = default(IEnumerable<IItemData>);
			bool flag4 = default(bool);
			SecretCharacterRecurringConditionData secretCharacterRecurringConditionData = default(SecretCharacterRecurringConditionData);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			ICollection<> collection = default(ICollection<>);
			uint num12 = default(uint);
			bool flag7 = default(bool);
			Item item = default(Item);
			uint num15 = default(uint);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				bool flag = TryToExecuteDailyReset(dispatcher, context);
				UpdatePendingFishes.Types.Response response = new UpdatePendingFishes.Types.Response();
				UpdatePendingFishes.Types.Request request = (response.request_ = new UpdatePendingFishes.Types.Request());
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (enumerable != null)
				{
					_003C_003Ec__DisplayClass200_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass200_0();
					CS_0024_003C_003E8__locals0.recurringEventData = (IRecurringEventData)(object)CS_0024_003C_003E8__locals0;
					while (CS_0024_003C_003E8__locals0 == null)
					{
					}
					recurringEvents_ = world_.recurringEvents_;
					Func<KeyValuePair<uint, RecurringEvent>, bool> cpp2il__autoParamName__idx_ = (Func<KeyValuePair<uint, RecurringEvent>, bool>)(object)(Func<T, TResult>)delegate
					{
						IRecurringEventData recurringEventData2 = CS_0024_003C_003E8__locals0.recurringEventData;
						throw new NullReferenceException();
					};
					if (((IEnumerable<>)(object)recurringEvents_).Any<KeyValuePair<uint, RecurringEvent>>((Func<, >)(object)cpp2il__autoParamName__idx_))
					{
						continue;
					}
				}
				int num5 = 0;
				if (enumerable != null)
				{
				}
				if (recurringEvents_ == null)
				{
					if (_003C_003Ec._003C_003E9__200_1 == null)
					{
						func = (Func<KeyValuePair<uint, RecurringEvent>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<uint, RecurringEvent> x) => chooseVillageArea != null));
					}
					IOrderedEnumerable<KeyValuePair<uint, RecurringEvent>> orderedEnumerable = (IOrderedEnumerable<KeyValuePair<uint, RecurringEvent>>)Enumerable.OrderByDescending<KeyValuePair<uint, RecurringEvent>, bool>(enumerable, (Func<, >)(object)func);
					if (_003C_003Ec._003C_003E9__200_2 == null)
					{
						func2 = (Func<KeyValuePair<uint, RecurringEvent>, uint>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						});
					}
					uint[] array = Enumerable.Select<KeyValuePair<uint, RecurringEvent>, uint>((IEnumerable<>)orderedEnumerable, (Func<, >)(object)func2).ToArray<uint>();
					if (num5 < array.Length)
					{
						uint recurringEventID_ = array[num5];
						IRecurringEvent @event = recurringEvent.Event;
						if (recurringEventData != null)
						{
							IRecurringEvent event2 = recurringEvent.Event;
							IRecurringEvent event3 = recurringEvent.Event;
							if (flag2)
							{
								IRecurringEvent event4 = recurringEvent.Event;
								Timestamp timestamp = dateTime.ToProto();
							}
							if (recurringEvent.Event.IsEventOver())
							{
								goto IL_018b;
							}
							if (!recurringEvent.Event.IsEventOver())
							{
								IRecurringEvent event5 = recurringEvent.Event;
								if (dateTime2 < dateTime2)
								{
									ExecuteRecurringEvent.Types.Response response2 = new ExecuteRecurringEvent.Types.Response();
									ExecuteRecurringEvent.Types.Request request2 = new ExecuteRecurringEvent.Types.Request();
									request2.recurringEventID_ = recurringEventID_;
									response2.request_ = request2;
									num5++;
									goto IL_018b;
								}
							}
						}
						goto IL_0191;
					}
					goto IL_0197;
				}
				throw new IndexOutOfRangeException();
				IL_018b:
				num5++;
				goto IL_0191;
				IL_0223:
				num6 += num6;
				goto IL_022a;
				IL_0191:
				num5++;
				goto IL_0197;
				IL_022a:
				int num7 = 0;
				if (enumerable2 != null)
				{
					int num8 = 0;
				}
				if (num5 == 0)
				{
					int num10 = num9 - 1;
					if (buff.EndTime != null)
					{
						int num11 = 0;
						DateTime dateTime3 = buff2.EndTime.ToDateTime();
						if (!flag3)
						{
						}
					}
					if (enumerable3 != null)
					{
						if (enumerable3 != null && enumerable3 == null)
						{
							throw new InvalidCastException();
						}
						int price = ((glPlayFab.Disney.BattlePassReward)num7).Price;
						while (flag4)
						{
						}
						if (flag4)
						{
							if (flag4)
							{
								while (!flag4)
								{
								}
								while ((long)enumerable2 != 1)
								{
								}
								Character character = new Character();
								character.base_.id_ = (int)character;
								character.status_ = Character.Types.CharacterStatus.Secret;
								character.friendshipLevel_ = num7;
								secretCharacterRecurringConditionData = (character.secretCharacterData_ = new SecretCharacterRecurringConditionData());
							}
							Character character2 = new Character();
							BaseItem base_ = character2.base_;
							SecretCharacterRecurringConditionData.Types.CountersData counters_ = secretCharacterRecurringConditionData.counters_;
							base_.id_ = (int)counters_;
							character2.status_ = (Character.Types.CharacterStatus)num7;
							character2.friendshipLevel_ = num7;
						}
						Character character3 = new Character();
						BaseItem base_2 = character3.base_;
						SecretCharacterRecurringConditionData.Types.CountersData counters_2 = secretCharacterRecurringConditionData.counters_;
						base_2.id_ = (int)counters_2;
						character3.status_ = Character.Types.CharacterStatus.InVillage;
						character3.friendshipLevel_ = 1;
					}
					if (enumerable3 != null)
					{
					}
					if (num5 == 0)
					{
						if (flag5)
						{
							while (!flag6)
							{
							}
						}
						if (num5 != 0)
						{
							break;
						}
						UpdateCharacterSchedules.Types.Response response3 = new UpdateCharacterSchedules.Types.Response();
						UpdateCharacterSchedules.Types.Request request3 = (response3.request_ = new UpdateCharacterSchedules.Types.Request());
						if (num5 == 0)
						{
							return;
						}
						continue;
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
				IL_0197:
				if (collection != null)
				{
					if (num5 < (int)num12)
					{
						num5 += num5;
						if (num5 == (int)num12)
						{
							goto IL_01c1;
						}
						num5++;
					}
					while (!flag7)
					{
					}
					item = Item.Invalid;
					goto IL_01c1;
				}
				goto IL_01d2;
				IL_01c1:
				item = (Item)((object)item + (object)item);
				num5 += 312;
				goto IL_01d2;
				IL_01d2:
				int num13 = 0;
				if (collection != null)
				{
					int num14 = 0;
				}
				if (num5 == 0)
				{
					if (_003C_003Ec._003C_003E9__200_3 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new NullReferenceException();
						};
					}
					if (enumerable2 != null)
					{
						if (num13 < (int)num15)
						{
							num13 += num13;
							if (num13 == (int)num15)
							{
								goto IL_0223;
							}
							num13++;
						}
						num6 = 0;
						goto IL_0223;
					}
					goto IL_022a;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005338")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B60", Offset = "0x7D4560", VA = "0x1807D5B60")]
		private void ProfileUpdaterAfterActualize()
		{
			int num = 0;
			long num2 = Convert.ToInt64(2070000688u);
			ProfileWorld profileWorld = world_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			MissionStep missionStep = default(MissionStep);
			MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>(missionStep.get_AllObjectives());
			if (missionObjective == null || missionObjective.Data != null)
			{
			}
			if ("Possess01" != null && missionObjective.status_ == MissionStepStatus.Ongoing)
			{
				ProfilePlayer profilePlayer = player_;
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				if (flag2 || flag3)
				{
					throw new NullReferenceException();
				}
				bool flag4 = default(bool);
				if (flag4)
				{
					bool flag5 = ActionsHelper.LogSuccess("FallingWater_Merl070", "Progression fixed by giving FallingWater item");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005339")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFF0", Offset = "0x7CA9F0", VA = "0x1807CBFF0")]
		private void CheckCollectionsForUnlockedItems(ProfilePlayer player)
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6, IL_00ac, IL_00b2, IL_00b8, IL_00be, IL_00c4, IL_00ca
			bool flag = default(bool);
			int num5 = default(int);
			bool flag2 = default(bool);
			int num6 = default(int);
			CollectionGroup collectionGroup = default(CollectionGroup);
			bool flag3 = default(bool);
			CollectionSetGroup collectionSetGroup = default(CollectionSetGroup);
			bool flag4 = default(bool);
			Character character = default(Character);
			CollectionSetGroup collectionSetGroup2 = default(CollectionSetGroup);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				RepeatedField<CollectionSet> collectionSets_ = player.collectionSets_;
				if (flag)
				{
					while (num5 == 0)
					{
					}
					while (!flag2)
					{
					}
					while (num6 == 0)
					{
					}
					int num7 = 0;
					RepeatedField<CollectionItemType> collectionsByType_ = collectionGroup.collectionsByType_;
					if (flag3)
					{
						int num8 = 0;
						MapField<int, bool> groupsCollectionItems_ = collectionSetGroup.groupsCollectionItems_;
						if (flag4)
						{
							ProfileWorld profileWorld = world_;
							while (character == null)
							{
							}
							if (character.IsUnlocked)
							{
								int num9 = 0;
								MapField<int, bool> groupsCollectionItems_2 = collectionSetGroup2.groupsCollectionItems_;
								break;
							}
							continue;
						}
						break;
					}
					break;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600533A")]
		[Cpp2IlInjected.Address(RVA = "0x7D2180", Offset = "0x7D0B80", VA = "0x1807D2180")]
		public void Initialize(ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//IL_001c: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			uint num6 = default(uint);
			uint num8 = default(uint);
			IEnumerable<> enumerable = default(IEnumerable<>);
			uint num9 = default(uint);
			bool flag = default(bool);
			bool flag2 = default(bool);
			IEnumerable<MissionSlot> enumerable3 = default(IEnumerable<MissionSlot>);
			uint num13 = default(uint);
			uint num14 = default(uint);
			bool flag3 = default(bool);
			int num15 = default(int);
			ICollection<> collection = default(ICollection<>);
			uint num19 = default(uint);
			ICollection<> collection2 = default(ICollection<>);
			uint num20 = default(uint);
			uint num23 = default(uint);
			uint num24 = default(uint);
			uint num25 = default(uint);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			int num29 = default(int);
			bool flag4 = default(bool);
			ICollection<> collection3 = default(ICollection<>);
			uint num31 = default(uint);
			uint num33 = default(uint);
			uint num34 = default(uint);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				ProfileWorld profileWorld = world_;
				int num5 = 0;
				IEnumerable<MissionSlot> allMissionSlot = (IEnumerable<MissionSlot>)profileWorld.GetAllMissionSlot((Func<, >)num5);
				if (allMissionSlot != null && num3 < (int)num6)
				{
					num3 += num3;
					if (num3 != (int)num6)
					{
						num3++;
					}
				}
				int num7 = 0;
				if (allMissionSlot != null)
				{
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (num7 < (int)num8)
				{
					num7 += num7;
					num7++;
				}
				if (enumerable != null)
				{
					if (num7 < (int)num9)
					{
						num7 += num7;
						if (num7 == (int)num9)
						{
							goto IL_0098;
						}
						num7++;
					}
					int price = ((glPlayFab.Disney.BattlePassReward)num7).Price;
					while (flag)
					{
					}
					int price2 = ((glPlayFab.Disney.BattlePassReward)num7).Price;
					while (flag2)
					{
					}
					num7 += num7;
					goto IL_0098;
				}
				goto IL_009f;
				IL_0117:
				int num10 = 0;
				IEnumerable<> enumerable2;
				if (enumerable2 != null)
				{
					int num11 = 0;
				}
				int num12 = 0;
				if (enumerable3 != null)
				{
					if (num10 < (int)num13)
					{
						num10 += num10;
						if (num10 == (int)num13)
						{
							goto IL_015e;
						}
						num10++;
					}
					if (num10 < (int)num14)
					{
						num10 += num10;
						num10++;
					}
					num15 = 0;
					if (!flag3)
					{
						goto IL_015e;
					}
				}
				goto IL_016c;
				IL_0228:
				int num16 = num16 + 312;
				goto IL_0232;
				IL_015e:
				num15 += num15;
				num15 += num15;
				goto IL_016c;
				IL_01d8:
				int num17 = num17 + 312;
				goto IL_01e2;
				IL_01e2:
				num16 = 0;
				if (collection != null)
				{
					int num18 = 0;
				}
				if (num16 < (int)num19)
				{
					num16 += num16;
					num16++;
				}
				if (collection2 != null)
				{
					if (num16 < (int)num20)
					{
						num16 += num16;
						if (num16 == (int)num20)
						{
							goto IL_0228;
						}
						num16++;
					}
					num16 += 312;
					goto IL_0228;
				}
				goto IL_0232;
				IL_009f:
				int num21 = 0;
				if (enumerable != null)
				{
					int num22 = 0;
				}
				enumerable2 = ProtoDatabase.Instance.EnumerateWithId<IActivityLockCondition>();
				if (num21 < (int)num23)
				{
					num21 += num21;
					num21++;
				}
				if (enumerable2 != null)
				{
					if (num21 < (int)num24)
					{
						num21 += num21;
						if (num21 == (int)num24)
						{
							goto IL_0109;
						}
						num21++;
					}
					if (num21 < (int)num25)
					{
						num21 += num21;
						num21++;
					}
					while (!flag4)
					{
					}
					int num26 = 0;
					flag4 = (byte)((flag4 ? 1u : 0u) + (flag4 ? 1u : 0u)) != 0;
					goto IL_0109;
				}
				goto IL_0117;
				IL_0098:
				num7 += num7;
				goto IL_009f;
				IL_0232:
				int num27 = 0;
				if (collection2 != null)
				{
				}
				if (flag5)
				{
				}
				int num28 = 0;
				if (flag6)
				{
				}
				if (num28 > num29)
				{
					/*Error: Could not find block for branch target IL_0250*/;
				}
				continue;
				IL_0109:
				flag4 = (byte)((flag4 ? 1u : 0u) + (flag4 ? 1u : 0u)) != 0;
				flag4 = (byte)((flag4 ? 1u : 0u) + (flag4 ? 1u : 0u)) != 0;
				goto IL_0117;
				IL_016c:
				int num30 = 0;
				if (enumerable3 != null)
				{
				}
				if (collection3 != null && num30 < (int)num31)
				{
					num30 += num30;
					if (num30 != (int)num31)
					{
						num30++;
					}
				}
				num17 = 0;
				if (collection3 != null)
				{
					int num32 = 0;
				}
				if (num17 < (int)num33)
				{
					num17 += num17;
					num17++;
				}
				if (collection != null)
				{
					if (num17 < (int)num34)
					{
						num17 += num17;
						if (num17 == (int)num34)
						{
							goto IL_01d8;
						}
						num17++;
					}
					num17 += 312;
					goto IL_01d8;
				}
				goto IL_01e2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600533B")]
		[Cpp2IlInjected.Address(RVA = "0x7D1EF0", Offset = "0x7D08F0", VA = "0x1807D1EF0")]
		internal InitProfileResult InitAndActualize(ITransactionContext transactionContext, ProfileEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0021, IL_0032, IL_0046
			//IL_001f: Expected I4, but got I8
			//IL_0030: Expected I4, but got I8
			//IL_0043: Expected I4, but got I8
			Initialize(dispatcher, transactionContext);
			Actualize(dispatcher, transactionContext);
			InitProfileResult initProfileResult = new InitProfileResult();
			initProfileResult.result_ = InitProfileResult.Types.ErrorCode.Success;
			return initProfileResult;
		}

		[Cpp2IlInjected.Token(Token = "0x600533C")]
		[Cpp2IlInjected.Address(RVA = "0x7D70E0", Offset = "0x7D5AE0", VA = "0x1807D70E0")]
		public byte[] Serialize()
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			MemoryStream memoryStream = new MemoryStream();
			CodedOutputStream codedOutputStream = new CodedOutputStream(memoryStream);
			WriteTo(codedOutputStream);
			if (codedOutputStream != null)
			{
			}
			byte[] result = memoryStream.ToArray();
			if (memoryStream != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600533D")]
		[Cpp2IlInjected.Address(RVA = "0x7D02F0", Offset = "0x7CECF0", VA = "0x1807D02F0")]
		public static Profile Deserialize(byte[] bytes)
		{
			//Discarded unreachable code: IL_0014
			Profile profile = (Profile)((MessageParser<T>)(object)_parser).ParseFrom(bytes);
			profile.InitAfterDeserialize();
			return profile;
		}

		[Cpp2IlInjected.Token(Token = "0x600533E")]
		[Cpp2IlInjected.Address(RVA = "0x7D0720", Offset = "0x7CF120", VA = "0x1807D0720")]
		public static Profile FromJson(string s)
		{
			//Discarded unreachable code: IL_000a, IL_0010
			int num = 0;
			Profile profile = default(Profile);
			profile.InitAfterDeserialize();
			return profile;
		}

		[Cpp2IlInjected.Token(Token = "0x600533F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D90", Offset = "0x7D0790", VA = "0x1807D1D90")]
		public void InitAfterDeserialize()
		{
			bool flag = gameInfo_.TryAddProfileUID();
			string profileUID_ = gameInfo_.profileUID_;
			string dataComparedStr = GetMiniProfile().DataComparedStr;
			string text = "[AL] InitAfterDeserialize ProfileUID=" + profileUID_ + " " + dataComparedStr;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005340")]
		[Cpp2IlInjected.Address(RVA = "0x7D7810", Offset = "0x7D6210", VA = "0x1807D7810")]
		public unsafe void SetLastKnownAvatarPosition(string avatarPosition)
		{
			//IL_0024: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			int num = 0;
			if (!TryParseAvatarPosition(avatarPosition, out *(int*)num, out *(GridPosition*)num, out *(GridPosition*)num))
			{
				LastKnownAvatarPositionUpToDate = (byte)num != 0;
				return;
			}
			LastKnownAvatarGridId = num;
			LastKnownAvatarGridPosition = (GridPosition)num;
			LastKnownAvatarDirection = (GridPosition)num;
			LastKnownAvatarPositionUpToDate = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005341")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C60", Offset = "0x7D6660", VA = "0x1807D7C60")]
		public bool TryGetLastKnownAvatarPosition(out uint lastKnownAvatarGridId, out GridPosition lastKnownAvatarGridPosition, bool allowOutdatedPosition = true)
		{
			//IL_0029: Expected I4, but got O
			int lastKnownAvatarGridId2 = LastKnownAvatarGridId;
			if (lastKnownAvatarGridId2 == -1)
			{
				int num = (lastKnownAvatarGridPosition.X = 0);
			}
			lastKnownAvatarGridId.m_value = (uint)lastKnownAvatarGridId2;
			GridPosition lastKnownAvatarGridPosition2 = LastKnownAvatarGridPosition;
			lastKnownAvatarGridPosition.X = (int)lastKnownAvatarGridPosition2;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005342")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C90", Offset = "0x7D6690", VA = "0x1807D7C90")]
		public bool TryGetLastKnownAvatarPosition(out uint lastKnownAvatarGridId, out GridPosition lastKnownAvatarGridPosition, out GridPosition lastKnownAvatarDirection, bool allowOutdatedPosition = true)
		{
			//IL_0024: Expected I4, but got O
			//IL_0032: Expected I4, but got O
			int lastKnownAvatarGridId2 = LastKnownAvatarGridId;
			if (lastKnownAvatarGridId2 != -1 && lastKnownAvatarGridId2 != -1)
			{
				lastKnownAvatarGridId.m_value = (uint)lastKnownAvatarGridId2;
				GridPosition lastKnownAvatarGridPosition2 = LastKnownAvatarGridPosition;
				lastKnownAvatarGridPosition.X = (int)lastKnownAvatarGridPosition2;
				GridPosition lastKnownAvatarDirection2 = LastKnownAvatarDirection;
				lastKnownAvatarDirection.X = (int)lastKnownAvatarDirection2;
				return true;
			}
			lastKnownAvatarDirection.X = (lastKnownAvatarGridPosition.X = 0);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005343")]
		[Cpp2IlInjected.Address(RVA = "0x7D7EE0", Offset = "0x7D68E0", VA = "0x1807D7EE0")]
		public static bool TryParseAvatarPosition(string avatarPosition, out int gridId, out GridPosition gridPosition)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005344")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CE0", Offset = "0x7D66E0", VA = "0x1807D7CE0")]
		public unsafe static bool TryParseAvatarPosition(string avatarPosition, out int gridId, out GridPosition gridPosition, out GridPosition avatarDirection)
		{
			int num = 0;
			if (avatarPosition != null)
			{
				char[] array = new char[0];
				array[0] = '|';
				string[] array2 = avatarPosition.Split(array);
				if (array2 != null && array2.Length == 5 && int.TryParse(array2[0], out gridId) && int.TryParse(array2[1], out *(int*)num) && int.TryParse(array2[2], out *(int*)num) && int.TryParse(array2[3], out *(int*)num) && int.TryParse(array2[4], out *(int*)num))
				{
					gridPosition.X = num;
					avatarDirection.X = num;
				}
			}
			int x = 0;
			gridId.m_value = num;
			gridPosition.X = x;
			avatarDirection.X = x;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005345")]
		[Cpp2IlInjected.Address(RVA = "0x7D5EE0", Offset = "0x7D48E0", VA = "0x1807D5EE0")]
		internal void PushTrackedMission(Item missionItem, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_002d
			Item trackedMissionItem = TrackedMissionItem;
			if ((object)trackedMissionItem == null)
			{
				if ((object)trackedMissionItem == null)
				{
					RepeatedField<int> repeatedField = trackedMissions_;
				}
				((RepeatedField<T>)(object)trackedMissions_).Clear();
				if (dispatcher != null)
				{
					Item trackedMissionItem2 = TrackedMissionItem;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005346")]
		[Cpp2IlInjected.Address(RVA = "0x7D6AC0", Offset = "0x7D54C0", VA = "0x1807D6AC0")]
		private void RemoveTrackedMission(Item missionItem)
		{
			//Discarded unreachable code: IL_0025
			//IL_0013: Expected O, but got I4
			int itemID = missionItem.ItemID;
			int num = ((RepeatedField<T>)(object)trackedMissions_).IndexOf((T)itemID);
			RepeatedField<int> repeatedField = trackedMissions_;
			itemID = num;
			((RepeatedField<T>)(object)repeatedField).RemoveAt(itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x6005347")]
		[Cpp2IlInjected.Address(RVA = "0x7D6960", Offset = "0x7D5360", VA = "0x1807D6960")]
		internal void RemoveTrackedMission(Item missionItem, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0038
			if ((object)typeof(Item).TypeHandle != null)
			{
				return;
			}
			Item trackedMissionItem = TrackedMissionItem;
			bool flag = default(bool);
			if (!flag)
			{
				RepeatedField<int> repeatedField = trackedMissions_;
				int index = ((RepeatedField<T>)(object)repeatedField).Count - 1;
				((RepeatedField<T>)(object)repeatedField).RemoveAt(index);
				if (dispatcher != null)
				{
					Item trackedMissionItem2 = TrackedMissionItem;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600534D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8360", Offset = "0x7D6D60", VA = "0x1807D8360")]
		internal bool TryToExecuteDailyReset(IWorldEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00fe, IL_0104, IL_010a, IL_0110, IL_0116, IL_011c, IL_0122, IL_0128, IL_0134, IL_013a
			//IL_0014: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			GridObject[] array = default(GridObject[]);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				bool flag = DailyResetUtil.MustReset(lastDailyReset_, (DateTime)num4);
				if (!flag)
				{
					return flag;
				}
				Timestamp timestamp = (lastDailyReset_ = DailyResetUtil.LastDailyReset((DateTime)num4).ToProto());
				int randomSeed = player_.GetRandomSeed("DailyReset");
				Random random = new Random(randomSeed);
				MapField<int, Village.Types.VillageArea> areas_ = world_.village_.areas_;
				if (flag2)
				{
					while ((long)"{il2cpp array field local25->}" == 0)
					{
					}
					GridCollection gridCollection_ = world_.gridCollection_;
					while (!flag3)
					{
					}
					while (num >= array.Length)
					{
					}
					GridObject gridObject = array[num];
					GridState state_ = gridObject.state_;
					if (state_ != null)
					{
						IGridStateData stateData = state_.StateData;
					}
					if (num != 0)
					{
						randomSeed = gridObject.ItemID;
						if (dispatcher != null)
						{
							int num5 = 0;
						}
					}
					num++;
					if (dispatcher == null)
					{
					}
					int num6 = 0;
					num++;
				}
				if (random == null)
				{
					if (flag4)
					{
					}
					int num7 = 0;
					if (random != null)
					{
						break;
					}
					PreferredItemSlot.PreferredItemCache preferredItemCache = new PreferredItemSlot.PreferredItemCache();
					int num8 = 0;
					if (flag5)
					{
					}
					if (random == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600534E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA680", Offset = "0x7C9080", VA = "0x1807CA680")]
		public void AddFreeTimer(TimerType timerType)
		{
			//Discarded unreachable code: IL_0008
			RepeatedField<TimerType> repeatedField = freeTimers_;
		}

		[Cpp2IlInjected.Token(Token = "0x600534F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D30", Offset = "0x7D0730", VA = "0x1807D1D30")]
		public bool HasFreeTimer(TimerType timerType)
		{
			//Discarded unreachable code: IL_0009
			RepeatedField<TimerType> repeatedField = freeTimers_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005350")]
		[Cpp2IlInjected.Address(RVA = "0x7CD730", Offset = "0x7CC130", VA = "0x1807CD730")]
		public bool ConsumeFreeTimer(TimerType timerType)
		{
			//Discarded unreachable code: IL_0009
			RepeatedField<TimerType> repeatedField = freeTimers_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005351")]
		[Cpp2IlInjected.Address(RVA = "0x7CB440", Offset = "0x7C9E40", VA = "0x1807CB440")]
		internal static uint AddRecurringEvent(RecurringEvent recurringEvent, IRecurringEventData recurringEventData, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_007f
			//IL_0026: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			if (recurringEvent.Event == null)
			{
				IRecurringEvent @event = recurringEvent.Event;
				Timestamp timestamp = default(Timestamp);
				if (timestamp == null)
				{
					RecurringEvent.EventDataOneofCase eventDataCase_ = recurringEvent.eventDataCase_;
					string text = $"RecurringEvent_{eventDataCase_}";
					int seed = default(int);
					Random random = new Random(seed);
					recurringEvent.Event.Reschedule(recurringEventData, in world, context, random);
				}
			}
			ProfileWorld section = world.Section;
			uint nextRecurringEventID_ = section.nextRecurringEventID_;
			uint num = (section.nextRecurringEventID_ = nextRecurringEventID_ + 1);
			((MapField<TKey, TValue>)(object)world.Section.recurringEvents_).Add((TKey)nextRecurringEventID_, (TValue)recurringEvent);
			if (world.dispatcher != null)
			{
			}
			return nextRecurringEventID_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005352")]
		[Cpp2IlInjected.Address(RVA = "0x7D68C0", Offset = "0x7D52C0", VA = "0x1807D68C0")]
		internal static void RemoveRecurringEvent(uint recurringEventID, in World world)
		{
			//Discarded unreachable code: IL_001c
			//IL_0011: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)world.Section.recurringEvents_).Remove((TKey)recurringEventID))
			{
				IWorldEventDispatcher dispatcher = world.dispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005353")]
		[Cpp2IlInjected.Address(RVA = "0x7D3770", Offset = "0x7D2170", VA = "0x1807D3770")]
		public bool IsCraftingRecipeSeen(Item craftingRecipeItem)
		{
			int itemID = craftingRecipeItem.ItemID;
			int num = ProtoExtensions.BinarySearch<int>((RepeatedField<>)(object)seenCraftingRecipes_, itemID);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005354")]
		[Cpp2IlInjected.Address(RVA = "0x7D7220", Offset = "0x7D5C20", VA = "0x1807D7220")]
		internal bool SetCraftingRecipeAsSeen(Item craftingRecipeItem)
		{
			//Discarded unreachable code: IL_0027
			//IL_0025: Expected O, but got I4
			int itemID = craftingRecipeItem.ItemID;
			int num = ProtoExtensions.BinarySearch<int>((RepeatedField<>)(object)seenCraftingRecipes_, itemID);
			RepeatedField<int> repeatedField = seenCraftingRecipes_;
			itemID = num;
			((RepeatedField<T>)(object)repeatedField).Insert(itemID, (T)itemID);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005355")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A10", Offset = "0x7D8410", VA = "0x1807D9A10")]
		public bool WasDugRecently(uint gridID, GridPosition gridPosition, ITransactionContext context)
		{
			Dictionary<(uint, GridPosition), DateTime> dictionary = lastDigs;
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				TimeSpan timeSpan = ProtoDatabase.Instance.Get<DiggingData>("Digging").samePositionCooldown_.ToTimeSpan();
				TimeSpan timeSpan2 = default(TimeSpan);
				return timeSpan2 < timeSpan;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005356")]
		[Cpp2IlInjected.Address(RVA = "0x7CA650", Offset = "0x7C9050", VA = "0x1807CA650")]
		internal bool AddDig(uint gridID, GridPosition gridPosition, ITransactionContext context)
		{
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005357")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F50", Offset = "0x7C8950", VA = "0x1807C9F50")]
		private unsafe bool AddDig(uint gridID, GridPosition gridPosition, ITransactionContext context, out Item lootTableItem)
		{
			//Discarded unreachable code: IL_006b, IL_0071, IL_0077, IL_007d, IL_0083
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			TimeSpan timeSpan = default(TimeSpan);
			TimeSpan timeSpan2 = default(TimeSpan);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				bool flag = ProtoDatabase.Instance.TryGet("Digging", out *(DiggingData*)num);
				if (!world_.village_.TryGetAreaType(gridID, out *(VillageAreaType*)num) || !flag2)
				{
					break;
				}
				Dictionary<(uint, GridPosition), DateTime> dictionary = lastDigs;
				if (flag3 && timeSpan > timeSpan2 && num == 0)
				{
					if (new List<T>() == null || flag4)
					{
					}
					int num3 = 0;
					if (flag5)
					{
						break;
					}
					int num4 = 0;
					return true;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005358")]
		[Cpp2IlInjected.Address(RVA = "0x7D51F0", Offset = "0x7D3BF0", VA = "0x1807D51F0")]
		internal unsafe static void PerformDigging(IGrid grid, GridPosition gridPosition, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00e1, IL_00e7, IL_00ed, IL_00f3, IL_00f9, IL_00ff, IL_0105
			//IL_002d: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			bool flag = default(bool);
			bool flag3 = default(bool);
			int seed = default(int);
			MultiReward multiReward = default(MultiReward);
			bool flag4 = default(bool);
			ItemReward itemReward = default(ItemReward);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				if (flag)
				{
					bool flag2 = ProtoDatabase.Instance.TryGet("Digging", out *(DiggingData*)num);
					LootTableItemData itemData = ItemDatabase.Instance.GetItemData<LootTableItemData>((Item)num);
					new RewardGenerationParameters().RewardAppearanceCondition = (RewardAppearanceCondition?)(object)num;
					IPlayerEventDispatcher dispatcher = player.dispatcher;
					if (flag3)
					{
					}
					int num5 = 0;
					int x = gridPosition.X;
					GridPosition gridPosition2 = *(GridPosition*)num5 * x;
					GridPosition gridPosition3 = *(GridPosition*)gridPosition + *(GridPosition*)gridPosition2;
					int num6 = new Random(seed).Next(1000);
					LootTable rewards_ = itemData.rewards_;
					int num7 = 0;
					RepeatedField<AnyReward> rewards_2 = multiReward.rewards_;
					if (flag4)
					{
						int itemID = itemReward.Item.ItemID;
						ItemWithState itemWithState = new ItemWithState();
						int num8 = (itemWithState.ItemID = itemReward.Item.ItemID);
						ItemState itemState = (itemWithState.state_ = itemReward.state_);
						int num9 = 0;
					}
					if (num == 0)
					{
						num++;
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005359")]
		[Cpp2IlInjected.Address(RVA = "0x7D0990", Offset = "0x7CF390", VA = "0x1807D0990")]
		public List<CraftingRecipeItemData> GetAvailableCraftingRecipes(ITransactionContext context)
		{
			//Discarded unreachable code: IL_003f
			ProfilePlayer profilePlayer = player_;
			ulong num = default(ulong);
			if (num == 0)
			{
			}
			int num2 = 0;
			Func<(CraftingRecipeItemData, int), CraftingRecipeItemData> func = default(Func<(CraftingRecipeItemData, int), CraftingRecipeItemData>);
			if (_003C_003Ec._003C_003E9__244_0 == null)
			{
				func = (Func<(CraftingRecipeItemData, int), CraftingRecipeItemData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			List<(CraftingRecipeItemData, int)> list = default(List<(CraftingRecipeItemData, int)>);
			return (List<CraftingRecipeItemData>)(object)Enumerable.ToList<CraftingRecipeItemData>(Enumerable.Select<(CraftingRecipeItemData, int), CraftingRecipeItemData>((IEnumerable<>)list, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x600535A")]
		[Cpp2IlInjected.Address(RVA = "0x7D0850", Offset = "0x7CF250", VA = "0x1807D0850")]
		public List<(CraftingRecipeItemData, int)> GetAvailableCraftingRecipesInfo(ITransactionContext context)
		{
			//Discarded unreachable code: IL_0012
			ProfilePlayer profilePlayer = player_;
			ulong num = default(ulong);
			if (num == 0)
			{
			}
			int num2 = 0;
			List<(CraftingRecipeItemData, int)> result = default(List<(CraftingRecipeItemData, int)>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600535B")]
		[Cpp2IlInjected.Address(RVA = "0x7D9760", Offset = "0x7D8160", VA = "0x1807D9760")]
		internal void UnlockCharacter(Item item, IWorldEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_006d
			//IL_004a: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			if (dispatcher == null)
			{
			}
			int num = 0;
			int num2 = 0;
			ProfileWorld profileWorld = world_;
			Character character = default(Character);
			if (character.IsUnlocked)
			{
				return;
			}
			CharacterItemData data = character.Data;
			int num3 = 0;
			int house = data.House;
			if (dispatcher == null)
			{
			}
			int num4 = 0;
			if (character.secretCharacterData_ != null)
			{
				if (dispatcher == null)
				{
				}
				int num5 = 0;
				character.secretCharacterData_ = (SecretCharacterRecurringConditionData)num2;
			}
			int num6 = 0;
			character.GeneratePreferredItems(this, context, (PreferredItemSlot.PreferredItemCache)num6);
			Character.Types.CharacterStatus status_ = character.status_;
			uint num7 = default(uint);
			if (num2 < (int)num7)
			{
				num2 += num2;
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600535C")]
		[Cpp2IlInjected.Address(RVA = "0x7D5DA0", Offset = "0x7D47A0", VA = "0x1807D5DA0")]
		internal void PurchaseCharacter(Item item, in World world, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0016
			ProfileWorld profileWorld = world_;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			CharacterItemData characterItemData = default(CharacterItemData);
			int house = characterItemData.House;
		}

		[Cpp2IlInjected.Token(Token = "0x600535D")]
		[Cpp2IlInjected.Address(RVA = "0x7D1950", Offset = "0x7D0350", VA = "0x1807D1950")]
		internal bool GiveBuilding(Item item, bool freeUnlock, IWorldEventDispatcher dispatcher)
		{
			//IL_007b: Expected O, but got I4
			//IL_00a2: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Building)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
				if (gridPlaceableItemData != null)
				{
					ProfileWorld profileWorld = world_;
					bool flag = default(bool);
					if (!flag)
					{
						ListInventory buildings = player_.Buildings;
						bool flag2 = default(bool);
						if (!flag2)
						{
							ListInventory buildings2 = player_.Buildings;
							if (dispatcher == null)
							{
							}
							int num2 = 0;
							int num3 = 0;
						}
						bool flag3 = default(bool);
						if (freeUnlock && flag3)
						{
							ProfileWorld profileWorld2 = world_;
							bool flag4 = default(bool);
							if (!flag4)
							{
								((RepeatedField<T>)(object)world_.unlockedBuildings_).Add((T)itemID);
							}
						}
					}
					bool flag5 = default(bool);
					if (freeUnlock && flag5)
					{
						ProfileWorld profileWorld3 = world_;
						bool flag6 = default(bool);
						if (!flag6)
						{
							((RepeatedField<T>)(object)world_.unlockedBuildings_).Add((T)itemID);
							if (dispatcher != null)
							{
								int num4 = 0;
								uint num5 = default(uint);
								if (num4 < (int)num5)
								{
									num4 += num4;
									num4++;
								}
							}
						}
					}
				}
			}
			int num6 = 0;
			num += num;
			num6 += 328;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600535E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBBD0", Offset = "0x7CA5D0", VA = "0x1807CBBD0")]
		public bool CanAddItem(Item item, int amount, [Optional] ItemState itemState, [Optional] InventoryFullResolution inventoryFullResolution)
		{
			//Discarded unreachable code: IL_0038
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (itemData == null)
			{
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Character)
				{
					ProfileWorld profileWorld = world_;
				}
				bool flag = default(bool);
				ActivityDataItemType activityDataItemType = default(ActivityDataItemType);
				if (itemType == ItemType.ActivityData && flag && activityDataItemType == ActivityDataItemType.CraftingRecipe)
				{
					ProfilePlayer profilePlayer = player_;
					bool flag2 = default(bool);
					return !flag2;
				}
				ProfilePlayer profilePlayer2 = player_;
			}
			ContainerInventory backpack = player_.Backpack;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600535F")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F70", Offset = "0x7D6970", VA = "0x1807D7F70")]
		public bool TryToAddItems(MultiItemInstance items, in Player player, in World world, ITransactionContext context, [Optional] ContainerInventory backpack, [Optional] Item? characterItem, [Optional] string missionName, InvActionType reason = InvActionType.None)
		{
			//Discarded unreachable code: IL_0095
			ContainerInventory backpack2 = player_.Backpack;
			ContainerInventory backpack3 = player_.Backpack;
			int num = 0;
			int count = ((RepeatedField<T>)(object)items.items_).Count;
			if (num < count)
			{
				ItemInstance itemInstance = (ItemInstance)((RepeatedField<T>)(object)items.items_)[num];
				Item item = itemInstance.Item;
				IItemData itemData = default(IItemData);
				if (itemData == null)
				{
					Item item2 = itemInstance.Item;
					int num2 = 0;
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_007d;
					}
					bool flag2 = default(bool);
					if (flag2)
					{
						goto IL_0090;
					}
					Item item3 = itemInstance.Item;
					ItemState state_ = itemInstance.state_;
					int num3 = 0;
					int num4 = 0;
				}
				int num5 = 0;
				ContainerInventory.CanAddResult canAddResult = default(ContainerInventory.CanAddResult);
				if (canAddResult != 0)
				{
					goto IL_007d;
				}
				goto IL_0081;
			}
			goto IL_0090;
			IL_0090:
			return num == 0;
			IL_007d:
			num++;
			goto IL_0081;
			IL_0081:
			AddDetail addDetail = default(AddDetail);
			Item? characterItem2 = addDetail.characterItem;
			int num6 = 0;
			int num7 = 0;
			goto IL_0090;
		}

		[Cpp2IlInjected.Token(Token = "0x6005360")]
		[Cpp2IlInjected.Address(RVA = "0x7CA990", Offset = "0x7C9390", VA = "0x1807CA990")]
		internal AddRemoveItemResult AddItem(Item item, int amount, IPlayerEventDispatcher playerDispatcher, IWorldEventDispatcher worldDispatcher, ITransactionContext context, [Optional] ItemState itemState, bool canSendToInbox = false, [Optional] AddDetail detail)
		{
			//Discarded unreachable code: IL_0177, IL_017d
			//IL_00e3: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			int itemID = default(int);
			if (itemData != null)
			{
				if (itemData != null)
				{
					goto IL_013c;
				}
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Character)
				{
					ProfileWorld profileWorld = world_;
					Character character = default(Character);
					if (character != null)
					{
						int num4 = 0;
						ProfileWorld profileWorld2 = world_;
						ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
						CharacterItemData characterItemData = default(CharacterItemData);
						int house = characterItemData.House;
						MapField<uint, ListInventory> listInventories_ = player_.listInventories_;
						bool flag = default(bool);
						if (!flag)
						{
							goto IL_0134;
						}
						bool flag2 = default(bool);
						while (!flag2)
						{
						}
						num3++;
					}
				}
				if (itemType > (ItemType)9)
				{
					goto IL_010d;
				}
				ProfilePlayer profilePlayer = player_;
				AddRemoveItemResult addRemoveItemResult = default(AddRemoveItemResult);
				int num5 = (int)addRemoveItemResult;
				ProfilePlayer profilePlayer2 = player_;
				if (playerDispatcher == null)
				{
				}
				int num6 = 0;
				bool flag3 = default(bool);
				if (!flag3)
				{
					ProfilePlayer profilePlayer3 = player_;
				}
				int num7 = 0;
				CompanionItemType companionItemType = default(CompanionItemType);
				while (companionItemType != 0)
				{
				}
				ProfilePlayer profilePlayer4 = player_;
				ProfilePlayer profilePlayer5 = player_;
				if (itemData != null)
				{
					ContainerInventory backpack = player_.Backpack;
					if ((long)backpack.size_ < (long)(IntPtr)backpack)
					{
						ContainerInventory backpack2 = player_.Backpack;
						backpack2.size_ = (int)backpack2;
					}
				}
				if (itemData != null)
				{
					ProfilePlayer profilePlayer6 = player_;
					Item item2 = default(Item);
					itemID = item2.ItemID;
					bool flag4 = default(bool);
					if (flag4)
					{
						MapField<uint, ContainerInventory> containerInventories_ = profilePlayer6.containerInventories_;
						goto IL_010d;
					}
				}
			}
			goto IL_0171;
			IL_0134:
			if (num3 + 1 == 0)
			{
			}
			goto IL_013c;
			IL_010d:
			ListInventory listInventory = default(ListInventory);
			while ((long)listInventory != 205)
			{
			}
			if (itemID == 0)
			{
				while (itemID == 0)
				{
				}
				ItemType compatibleItemType_ = listInventory.compatibleItemType_;
			}
			ItemType compatibleItemType_2 = listInventory.compatibleItemType_;
			goto IL_0134;
			IL_0171:
			throw new NullReferenceException();
			IL_013c:
			ContainerInventory backpack3 = player_.Backpack;
			ContainerInventory.CanAddResult canAddResult = default(ContainerInventory.CanAddResult);
			while (canAddResult == ContainerInventory.CanAddResult.Success)
			{
			}
			if (canAddResult != 0 && canAddResult != 0 && canAddResult == ContainerInventory.CanAddResult.InvalidInventory)
			{
				ProfilePlayer profilePlayer7 = player_;
				if (playerDispatcher == null)
				{
				}
				int num8 = 0;
				bool flag5 = default(bool);
				while (flag5)
				{
				}
			}
			goto IL_0171;
		}

		[Cpp2IlInjected.Token(Token = "0x6005361")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B60", Offset = "0x7D7560", VA = "0x1807D8B60")]
		internal bool TryToRemoveItems(MultiItemInstance items, in Player player, in World world, ITransactionContext context, InvActionType reason = InvActionType.None)
		{
			//Discarded unreachable code: IL_0063
			int num = 0;
			int num2 = 0;
			int count = ((RepeatedField<T>)(object)items.items_).Count;
			if (num2 < count)
			{
				ItemInstance itemInstance = (ItemInstance)((RepeatedField<T>)(object)items.items_)[num];
				Item item = itemInstance.Item;
				Item item2 = itemInstance.ItemAmount.Item;
				ItemAmount itemAmount = itemInstance.ItemAmount;
				IWorldEventDispatcher dispatcher = world.dispatcher;
				int num3 = 0;
				AddRemoveItemResult addRemoveItemResult = default(AddRemoveItemResult);
				if (addRemoveItemResult != 0)
				{
					num++;
				}
				((RepeatedField<T>)(object)items.items_).RemoveAt(num);
			}
			return num == 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005362")]
		[Cpp2IlInjected.Address(RVA = "0x7D6030", Offset = "0x7D4A30", VA = "0x1807D6030")]
		internal AddRemoveItemResult RemoveItem(Item item, int amount, IPlayerEventDispatcher playerDispatcher, in World world, IWorldEventDispatcher worldDispatcher, ITransactionContext context, [Optional] ItemState itemState, bool canSendToInbox = false, [Optional] AddDetail detail)
		{
			//Discarded unreachable code: IL_00d4, IL_00da, IL_00e0, IL_00ec
			IItemData itemData = default(IItemData);
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			uint num3 = default(uint);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			ICollection<> collection = default(ICollection<>);
			int num6 = default(int);
			ItemType itemType2 = default(ItemType);
			AddRemoveItemResult addRemoveItemResult = default(AddRemoveItemResult);
			AddRemoveItemResult addRemoveItemResult2 = default(AddRemoveItemResult);
			ItemType itemType3 = default(ItemType);
			bool flag4 = default(bool);
			AddRemoveItemResult addRemoveItemResult3 = default(AddRemoveItemResult);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				ICollection<ListInventory> values;
				if (itemData != null)
				{
					ProfilePlayer profilePlayer = player_;
					if (itemType == ItemType.Currency)
					{
					}
					if (itemType != ItemType.Companion || flag)
					{
						values = (ICollection<ListInventory>)((MapField<TKey, TValue>)(object)profilePlayer.listInventories_).get_Values();
						if (values != null)
						{
							if (num < (int)num3)
							{
								num += num;
								if (num == (int)num3)
								{
									goto IL_005b;
								}
								num++;
							}
							while (!flag2)
							{
							}
							while (!flag3)
							{
							}
							goto IL_005b;
						}
						goto IL_0067;
					}
				}
				goto IL_00ce;
				IL_005b:
				num += 312;
				num -= amount;
				goto IL_0067;
				IL_00ce:
				throw new NullReferenceException();
				IL_0067:
				int num4 = 0;
				if (values != null)
				{
					int num5 = 0;
				}
				if (num == 0)
				{
					if (collection != null)
					{
						while (num6 <= 0)
						{
						}
						num4 -= num6;
					}
					int num7 = 0;
					if (collection != null)
					{
					}
					if (num != 0)
					{
						break;
					}
					if (itemType2 == ItemType.Clothing)
					{
					}
					if (addRemoveItemResult == (AddRemoveItemResult)14)
					{
					}
					if (addRemoveItemResult2 == (AddRemoveItemResult)16)
					{
					}
					while (num4 <= 0)
					{
					}
					while (itemType3 != ItemType.Furniture)
					{
					}
					while (num7 >= num4)
					{
					}
					if (flag4)
					{
						while (addRemoveItemResult3 == AddRemoveItemResult.Success)
						{
						}
					}
					if (num != 0)
					{
						continue;
					}
					num7++;
					goto IL_00ce;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005363")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEB0", Offset = "0x7CA8B0", VA = "0x1807CBEB0")]
		public bool CanBuyItem(Item item, int amount, [Optional] ItemState itemState)
		{
			//Discarded unreachable code: IL_001b
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Character)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				CharacterItemData characterItemData = default(CharacterItemData);
				if (characterItemData.unlockCondition_ != 0)
				{
					int num = 0;
				}
			}
			int num2 = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005364")]
		[Cpp2IlInjected.Address(RVA = "0x7CC570", Offset = "0x7CAF70", VA = "0x1807CC570")]
		internal unsafe static bool CheckWeatherUpdate(in Player player, in World world, ITransactionContext context, [Optional] string forcedWeather)
		{
			//Discarded unreachable code: IL_0275, IL_027b, IL_0287, IL_028d, IL_0293, IL_0299, IL_029f, IL_02a5, IL_02ab, IL_02b1, IL_02b7, IL_02bd, IL_02c3, IL_02c9, IL_02d5, IL_02db, IL_02e1, IL_02e7, IL_02ed
			int seed = default(int);
			bool flag = default(bool);
			Func<Weather.Types.NextWeather, int> func = default(Func<Weather.Types.NextWeather, int>);
			uint num3 = default(uint);
			uint maxValue2 = default(uint);
			ulong num5 = default(ulong);
			ProfileWorld profileWorld = default(ProfileWorld);
			DateTime dateTime2 = default(DateTime);
			ICollection<Village.Types.VillageArea> values = default(ICollection<Village.Types.VillageArea>);
			ProfileWorld profileWorld2 = default(ProfileWorld);
			ProfileWorld profileWorld3 = default(ProfileWorld);
			SaplingGrowthData sapling = default(SaplingGrowthData);
			FlowerData flowerData = default(FlowerData);
			FlowerData flowerData2 = default(FlowerData);
			ProfileWorld profileWorld4 = default(ProfileWorld);
			uint num7 = default(uint);
			int num6 = default(int);
			while (true)
			{
				int num = 0;
				string currentWeather_ = world.Section.currentWeather_;
				Weather weather = ProtoDatabase.Instance.Get<Weather>(currentWeather_);
				Random random = new Random(seed);
				if (random != null && world.Section.uncursedLightLockedTimer_ < num)
				{
					DateTime dateTime = world.Section.nextWeatherCheck_.ToDateTime();
					if (flag)
					{
						RepeatedField<Weather.Types.NextWeather> nextWeathers_ = weather.nextWeathers_;
						Func<Weather.Types.NextWeather, int> _003C_003E9__255_ = _003C_003Ec._003C_003E9__255_0;
						if (_003C_003E9__255_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Weather.Types.NextWeather x) => x.weight_);
						}
						int maxValue = Enumerable.Sum<Weather.Types.NextWeather>((IEnumerable<>)(object)nextWeathers_, (Func<, >)(object)_003C_003E9__255_);
						int minValue = 0;
						int num2 = random.Next(minValue, maxValue);
						RepeatedField<Weather.Types.NextWeather> nextWeathers_2 = weather.nextWeathers_;
						if (_003C_003Ec._003C_003E9__255_1 == null)
						{
							func = (Func<Weather.Types.NextWeather, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Weather.Types.NextWeather x) => x.weight_));
						}
						IOrderedEnumerable<Weather.Types.NextWeather> orderedEnumerable = (IOrderedEnumerable<Weather.Types.NextWeather>)Enumerable.OrderBy<Weather.Types.NextWeather, int>((IEnumerable<>)(object)nextWeathers_2, (Func<, >)(object)func);
						if (orderedEnumerable != null && num < (int)num3)
						{
							num += num;
							if (num != (int)num3)
							{
								num++;
							}
						}
						if (orderedEnumerable != null)
						{
						}
						if (num != 0)
						{
							throw new NullReferenceException();
						}
					}
				}
				Weather weather2 = ProtoDatabase.Instance.Get<Weather>(forcedWeather);
				TimeSpan timeSpan = weather2.minDuration_.ToTimeSpan();
				TimeSpan timeSpan2 = weather2.maxDuration_.ToTimeSpan();
				TimeSpan timeSpan3 = weather2.minDuration_.ToTimeSpan();
				TimeSpan timeSpan4 = timeSpan2 - timeSpan3;
				int minValue2 = 0;
				int num4 = random.Next(minValue2, (int)maxValue2);
				num5 += num5;
				Timestamp timestamp = (profileWorld.nextWeatherCheck_ = dateTime2.ToProto());
				bool flag2 = forcedWeather != currentWeather_;
				if (!flag2)
				{
					return flag2;
				}
				if (weather.waterPlants_ != weather2.waterPlants_)
				{
					values = (ICollection<Village.Types.VillageArea>)((MapField<TKey, TValue>)(object)profileWorld2.village_.areas_).get_Values();
					if (values != null)
					{
						int gridID = 0;
						bool flag3 = profileWorld3.gridCollection_.TryGetGrid((uint)gridID, out *(IGrid*)num);
						while (!flag3)
						{
						}
						if (flag3)
						{
							GardenData gardenData;
							if (false && gardenData != null)
							{
								GardenData gardenData2;
								int count = ((RepeatedField<T>)(object)gardenData2.slots_).Count;
								while (num >= count)
								{
								}
								GardenData gardenData3;
								GardenData.Types.GardeningSlot gardeningSlot = (GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gardenData3.slots_)[num];
								Item plantedSeedItem = gardeningSlot.PlantedSeedItem;
								bool flag4;
								if (flag4)
								{
									sapling = gardeningSlot.Sapling;
									if (sapling == null)
									{
									}
								}
								num++;
							}
							while (sapling == null)
							{
							}
							while (flowerData == null)
							{
							}
							while (!flowerData2.dry_)
							{
							}
						}
						if (flag3)
						{
						}
						if (num != 0)
						{
							break;
						}
					}
					num6 = 0;
					if (values != null)
					{
					}
					if (num != 0)
					{
						continue;
					}
				}
				profileWorld4.CurrentWeather = forcedWeather;
				if (values != null && num6 < (int)num7)
				{
					num6 += num6;
					num6++;
				}
				UpdatePendingFishes.Types.Response response = new UpdatePendingFishes.Types.Response();
				UpdatePendingFishes.Types.Request request = (response.request_ = new UpdatePendingFishes.Types.Request());
				response = (UpdatePendingFishes.Types.Response)(object)((object)response + (object)response);
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005365")]
		[Cpp2IlInjected.Address(RVA = "0x7D78E0", Offset = "0x7D62E0", VA = "0x1807D78E0")]
		internal bool SpendMana(ManaData.Types.ManaSpendingActionType manaSpendingActionType, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0011
			(int, int) manaCost = ((int, int))this.GetManaCost(manaSpendingActionType);
			ProfilePlayer profilePlayer = player_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005366")]
		[Cpp2IlInjected.Address(RVA = "0x7D1050", Offset = "0x7CFA50", VA = "0x1807D1050")]
		private (int, int) GetManaCost(ManaData.Types.ManaSpendingActionType manaSpendingActionType)
		{
			//IL_0156: Expected I4, but got I8
			int num;
			BuildingItemData buildingItemData = default(BuildingItemData);
			HouseData houseData = default(HouseData);
			HouseData houseData2 = default(HouseData);
			StallBuildingItemData stallBuildingItemData = default(StallBuildingItemData);
			FishingStallData fishingStallData = default(FishingStallData);
			FishingStallData fishingStallData2 = default(FishingStallData);
			while (true)
			{
				num = 0;
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				int num2 = 0;
				if (manaSpendingActionType != 0)
				{
					if (manaSpendingActionType != 0)
					{
						if (manaSpendingActionType != 0 && manaSpendingActionType != 0)
						{
							if (manaSpendingActionType != ManaData.Types.ManaSpendingActionType.Fish)
							{
								break;
							}
							(int, int) tuple = ((int, int))this._003CGetManaCost_003Eg__GetGardeningPercentageReduction_007C257_0();
						}
						int num3 = 0;
						GridCollection gridCollection_ = world_.gridCollection_;
						int iD = buildingItemData.ID;
						if (gridCollection_ == null)
						{
							break;
						}
						if (gridCollection_.dispatcher == null)
						{
							continue;
						}
						while (houseData == null)
						{
						}
						if ((IntPtr)houseData.upgradeState_ == (IntPtr)num)
						{
							break;
						}
						ProfileEventDispatcher dispatcher = gridCollection_.dispatcher;
						int level_ = houseData2.upgradeState_.level_;
						int useLowerLast = 0;
						UpgradeData upgradeData = buildingItemData.GetUpgradeData(level_, (byte)useLowerLast != 0);
						if (upgradeData == null)
						{
							break;
						}
						BenefitsRestaurantData restaurant = upgradeData.Restaurant;
					}
					int num4 = 0;
					GridCollection gridCollection_2 = world_.gridCollection_;
					int iD2 = stallBuildingItemData.ID;
					if (gridCollection_2 == null)
					{
						break;
					}
					if (gridCollection_2.dispatcher == null)
					{
						continue;
					}
					while (fishingStallData == null)
					{
					}
					if ((IntPtr)fishingStallData.upgradeState_ == (IntPtr)num)
					{
						break;
					}
					ProfileEventDispatcher dispatcher2 = gridCollection_2.dispatcher;
					int level_2 = fishingStallData2.upgradeState_.level_;
					int useLowerLast2 = 0;
					UpgradeData upgradeData2 = stallBuildingItemData.GetUpgradeData(level_2, (byte)useLowerLast2 != 0);
					if (upgradeData2 == null)
					{
						break;
					}
					BenefitsFishingData fishing = upgradeData2.Fishing;
				}
				(int, int) tuple2 = ((int, int))this._003CGetManaCost_003Eg__GetGardeningPercentageReduction_007C257_0();
				break;
			}
			if (manaSpendingActionType <= ManaData.Types.ManaSpendingActionType.Mine)
			{
				ProfilePlayer profilePlayer = player_;
				ProfilePlayer profilePlayer2 = player_;
				ProfilePlayer profilePlayer3 = player_;
				ProfilePlayer profilePlayer4 = player_;
			}
			int num5 = default(int);
			int num6 = num5 * num;
			ulong num7 = num7 + num7;
			num5 = (int)((long)num5 - (long)num7);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005367")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D00", Offset = "0x7D0700", VA = "0x1807D1D00")]
		public unsafe bool HasEnoughMana(ManaData.Types.ManaSpendingActionType manaSpendingActionType)
		{
			//Discarded unreachable code: IL_001e
			//IL_0016: Expected I4, but got O
			(int, int) manaCost = ((int, int))this.GetManaCost(manaSpendingActionType);
			ProfilePlayer profilePlayer = player_;
			int amount = (int)((ValueTuple<, >*)(&manaCost))->Item1;
			return profilePlayer.HasEnoughMana(amount);
		}

		[Cpp2IlInjected.Token(Token = "0x6005368")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B40", Offset = "0x7D5540", VA = "0x1807D6B40")]
		private void ResumeDutiesAchievements(ProfileEventDispatcher dispatcher, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0098, IL_009e, IL_00a4, IL_00aa, IL_00b0, IL_00b6
			//IL_0080: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			UpdateRoyalDutySlots.Types.Response response = new UpdateRoyalDutySlots.Types.Response();
			UpdateRoyalDutySlots.Types.Request request = (response.request_ = new UpdateRoyalDutySlots.Types.Request());
			DutyList dutyList = default(DutyList);
			DutyList royalDuties = dutyList;
			List<DutySlot> list = (List<DutySlot>)(object)new List<T>();
			RepeatedField<DutySlot> slots_ = royalDuties.slots_;
			bool flag = default(bool);
			RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
			if (!flag || royalDutyItemData == null)
			{
			}
			Action<DutySlot> action = (Action<DutySlot>)(object)(Action<T>)delegate(DutySlot x)
			{
				//Discarded unreachable code: IL_0013
				bool flag4 = ((RepeatedField<T>)(object)royalDuties.slots_).Remove((T)x);
			};
			((List<T>)(object)list).ForEach((Action<>)(object)action);
			List<AchievementData> list2 = (List<AchievementData>)(object)new List<T>();
			bool flag2 = default(bool);
			AchievementItemData achievementItemData = default(AchievementItemData);
			if (flag2 && achievementItemData == null)
			{
				((List<T>)(object)list2).Add((T)num2);
			}
			Action<AchievementData> action2 = (Action<AchievementData>)(object)(Action<T>)delegate(AchievementData x)
			{
				//Discarded unreachable code: IL_0018
				bool flag3 = ((RepeatedField<T>)(object)player_.achievementsData_).Remove((T)x);
			};
			((List<T>)(object)list2).ForEach((Action<>)(object)action2);
		}

		[Cpp2IlInjected.Token(Token = "0x6005369")]
		[Cpp2IlInjected.Address(RVA = "0x7D1860", Offset = "0x7D0260", VA = "0x1807D1860", Slot = "23")]
		public TimeSpan GetTimer(ProfileTimerType profileTimerType)
		{
			switch (profileTimerType)
			{
			case ProfileTimerType.Played:
			{
				ProfilePlayer profilePlayer = player_;
				TimeSpan result = default(TimeSpan);
				return result;
			}
			case ProfileTimerType.Uncursed:
			{
				ProfileWorld profileWorld = world_;
				break;
			}
			}
			ArgumentException ex = new ArgumentException("Invalid timer type", "profileTimerType");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600536B")]
		[Cpp2IlInjected.Address(RVA = "0x7D4440", Offset = "0x7D2E40", VA = "0x1807D4440", Slot = "25")]
		bool IGridDataUpdateInvalidItemHandler.CanMoveInvalidObject(Item item, GridState gridState)
		{
			ItemType itemType = default(ItemType);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			while (itemType != ItemType.Furniture || furnitureItemType > FurnitureItemType.GroundAlteration)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600536C")]
		[Cpp2IlInjected.Address(RVA = "0x7D44B0", Offset = "0x7D2EB0", VA = "0x1807D44B0", Slot = "26")]
		int IGridDataUpdateInvalidItemHandler.GetTryForObjectRemoval(Item item, GridState gridState, ITransactionContext context)
		{
			//Discarded unreachable code: IL_006e, IL_0073, IL_0077, IL_007c, IL_0081, IL_0086, IL_008e, IL_0093, IL_0098, IL_009e
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			ItemType itemType = default(ItemType);
			if (!itemData.IsMissionItem() && itemType <= (ItemType)6 && itemType != 0 && gridState != null)
			{
				GardenData gardenData = gridState.GardenData;
				if (gardenData != null)
				{
					RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
					Func<GardenData.Types.GardeningSlot, bool> _003C_003E9__264_ = _003C_003Ec._003C_003E9__264_0;
					if (_003C_003E9__264_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GardenData.Types.GardeningSlot x)
						{
							Item plantedSeedItem = x.PlantedSeedItem;
							throw new NullReferenceException();
						};
					}
					bool flag = ((IEnumerable<>)(object)slots_).All<GardenData.Types.GardeningSlot>((Func<, >)(object)_003C_003E9__264_);
					int num = 0;
					return 0;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600536D")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D60", Offset = "0x7D3760", VA = "0x1807D4D60", Slot = "27")]
		void IGridDataUpdateInvalidItemHandler.Remove(Item item, GridState gridState, int tryNumber)
		{
			ItemType itemType = default(ItemType);
			ListInventory catalog2 = default(ListInventory);
			switch (itemType)
			{
			case ItemType.ActivityItem:
				return;
			case ItemType.Furniture:
			{
				ListInventory catalog = player_.Catalog;
				bool flag = default(bool);
				if (flag)
				{
					catalog2 = player_.Catalog;
					int num = 0;
				}
				return;
			}
			}
			while ((long)catalog2 != 8)
			{
			}
			int num2 = 0;
			if (gridState == null || gridState.ItemAmountState != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600536E")]
		[Cpp2IlInjected.Address(RVA = "0x7D4970", Offset = "0x7D3370", VA = "0x1807D4970", Slot = "28")]
		void IGridDataUpdateInvalidItemHandler.PostUpdateValidation(Grid grid, Dictionary<GridPosition, List<GridObject>> checkGridCells, List<GridObject> removedObjects)
		{
			//Discarded unreachable code: IL_0058, IL_005e, IL_0064, IL_006a, IL_0070, IL_0076, IL_007c
			//IL_0053: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			while (furnitureItemType != FurnitureItemType.Fence)
			{
			}
			bool flag3 = default(bool);
			while (flag3)
			{
			}
			GridOrientation[] fenceDirections = FenceModeUtility.FenceDirections;
			while (num >= fenceDirections.Length)
			{
			}
			GridOrientation gridOrientation = fenceDirections[num];
			bool flag4 = default(bool);
			if (flag4)
			{
				int num3 = 0;
				bool flag5 = default(bool);
				if (!flag5)
				{
					ListInventory catalog = player_.Catalog;
					GridCells.RemoveFromGridCells((Dictionary<, >)(object)checkGridCells, (GridObject)num);
				}
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x600536F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA070", Offset = "0x7D8A70", VA = "0x1807DA070")]
		static Profile()
		{
			Func<TimerType, int> func = (Func<TimerType, int>)(object)(Func<T, TResult>)((TimerType x) => (int)x);
			Func<int, TimerType> func2 = (Func<int, TimerType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<Profile>)(object)FieldCodec.ForEnum<TimerType>(num, (Func<, >)(object)func, (Func<, >)(object)func2);
			uint num2 = default(uint);
			_parser = (MessageParser<Profile>)(object)FieldCodec.ForInt32(num2);
			uint num3 = default(uint);
			_parser = (MessageParser<Profile>)(object)FieldCodec.ForInt32(num3);
			uint num4 = default(uint);
			_parser = (MessageParser<Profile>)(object)FieldCodec.ForInt32(num4);
			uint num5 = default(uint);
			_parser = (MessageParser<Profile>)(object)FieldCodec.ForInt32(num5);
		}
	}
}
