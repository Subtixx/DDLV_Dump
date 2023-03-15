using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Scene;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using Meta.Duties;
using Meta.Missions;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000867")]
	public class RedDotHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000868")]
		private class BattlePassInfo
		{
			[Cpp2IlInjected.Token(Token = "0x17000784")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003157")]
			public bool IsNew
			{
				[Cpp2IlInjected.Token(Token = "0x6003550")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6003551")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000785")]
			public List<int> CompletedTaskIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x6003552")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCompletedTaskIndexes_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6003553")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				private set
				{
					_003CCompletedTaskIndexes_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (List<int>)(object)new List<T>();


			[Cpp2IlInjected.Token(Token = "0x6003554")]
			[Cpp2IlInjected.Address(RVA = "0x157EA20", Offset = "0x157D420", VA = "0x18157EA20")]
			public BattlePassInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000869")]
		private class StoreInfo
		{
			[Cpp2IlInjected.Token(Token = "0x17000786")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003159")]
			public bool IsNew
			{
				[Cpp2IlInjected.Token(Token = "0x6003555")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6003556")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6003557")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public StoreInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003152")]
		private Dictionary<RedDotDataType, bool> _dictRedDotStates = (Dictionary<RedDotDataType, bool>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003153")]
		private Dictionary<Item, RedDotDataType> _dictItems = (Dictionary<Item, RedDotDataType>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003154")]
		private Dictionary<string, BattlePassInfo> _dictBattlePasses = (Dictionary<string, BattlePassInfo>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003155")]
		private Dictionary<string, StoreInfo> _dictStores = (Dictionary<string, StoreInfo>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003156")]
		private List<RedDot> _redDotsForRealTimeUpdate = (List<RedDot>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003521")]
		[Cpp2IlInjected.Address(RVA = "0xF45EE0", Offset = "0xF448E0", VA = "0x180F45EE0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0037, IL_00de, IL_00e4, IL_00ea, IL_00f0, IL_00f6
			int num = 0;
			IEnumerator enumerator = Enum.GetValues(typeof(RedDotDataType)).GetEnumerator();
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
				IEnumerator enumerator2 = enumerator;
				throw new NullReferenceException();
			}
			NullReferenceException ex = default(NullReferenceException);
			if (ex != null)
			{
			}
			ProfileEventDispatcher.MissionSlotUpdated value = default(ProfileEventDispatcher.MissionSlotUpdated);
			SystemRoot.Instance.MetaClient.Dispatcher.OnMissionSlotUpdated += value;
			ProfileEventDispatcher.VillageAreaUnlocked value2 = default(ProfileEventDispatcher.VillageAreaUnlocked);
			SystemRoot.Instance.MetaClient.Dispatcher.OnVillageAreaUnlocked += value2;
			ProfileEventDispatcher.CollectionSetUpdated value3 = default(ProfileEventDispatcher.CollectionSetUpdated);
			SystemRoot.Instance.MetaClient.Dispatcher.OnCollectionSetUpdated += value3;
			ProfileEventDispatcher.DutySlotUpdated value4 = default(ProfileEventDispatcher.DutySlotUpdated);
			SystemRoot.Instance.MetaClient.Dispatcher.OnDutySlotUpdated += value4;
			ProfileEventDispatcher.BattlePassTasksUpdate value5 = default(ProfileEventDispatcher.BattlePassTasksUpdate);
			SystemRoot.Instance.MetaClient.Dispatcher.OnBattlePassTasksUpdate += value5;
			ProfileEventDispatcher.BattlePassTaskUpdate value6 = default(ProfileEventDispatcher.BattlePassTaskUpdate);
			SystemRoot.Instance.MetaClient.Dispatcher.OnBattlePassTaskUpdate += value6;
			ProfileEventDispatcher.OnlineStoresUpdate value7 = default(ProfileEventDispatcher.OnlineStoresUpdate);
			SystemRoot.Instance.MetaClient.Dispatcher.OnOnlineStoresUpdate += value7;
		}

		[Cpp2IlInjected.Token(Token = "0x6003522")]
		[Cpp2IlInjected.Address(RVA = "0xF44730", Offset = "0xF43130", VA = "0x180F44730")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_013e
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.MissionSlotUpdated value = OnMissionSlotUpdated;
					_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.VillageAreaUnlocked value2 = OnVillageAreaUnlocked;
					_003CDispatcher_003Ek__BackingField2.OnVillageAreaUnlocked -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.CollectionSetUpdated value3 = OnCollectionSetUpdated;
					_003CDispatcher_003Ek__BackingField3.OnCollectionSetUpdated -= value3;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.DutySlotUpdated value4 = OnDutySlotUpdated;
					_003CDispatcher_003Ek__BackingField4.OnDutySlotUpdated -= value4;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BattlePassTasksUpdate value5 = OnBattlePassTasksUpdate;
					_003CDispatcher_003Ek__BackingField5.OnBattlePassTasksUpdate -= value5;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BattlePassTaskUpdate value6 = OnBattlePassTaskUpdate;
					_003CDispatcher_003Ek__BackingField6.OnBattlePassTaskUpdate -= value6;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField7 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.OnlineStoresUpdate value7 = OnOnlineStoresUpdate;
					_003CDispatcher_003Ek__BackingField7.OnOnlineStoresUpdate -= value7;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003523")]
		[Cpp2IlInjected.Address(RVA = "0xF429C0", Offset = "0xF413C0", VA = "0x180F429C0")]
		public void AddRealTimeTarget(RedDot redDot)
		{
			//Discarded unreachable code: IL_001c
			if (!((List<T>)(object)_redDotsForRealTimeUpdate).Contains((T)redDot))
			{
				((List<T>)(object)_redDotsForRealTimeUpdate).Add((T)redDot);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003524")]
		[Cpp2IlInjected.Address(RVA = "0xF45D00", Offset = "0xF44700", VA = "0x180F45D00")]
		public void RemoveRealTimeTarget(RedDot redDot)
		{
			//Discarded unreachable code: IL_001d
			if (((List<T>)(object)_redDotsForRealTimeUpdate).Contains((T)redDot))
			{
				bool flag = ((List<T>)(object)_redDotsForRealTimeUpdate).Remove((T)redDot);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003525")]
		[Cpp2IlInjected.Address(RVA = "0xF45770", Offset = "0xF44170", VA = "0x180F45770")]
		public unsafe void RemoveAll(RedDotDataType dataType)
		{
			//Discarded unreachable code: IL_0074, IL_007d, IL_0083
			int num = 0;
			Dictionary<Item, RedDotDataType> dictItems = _dictItems;
			Func<KeyValuePair<Item, RedDotDataType>, bool> func = (Func<KeyValuePair<Item, RedDotDataType>, bool>)(object)(Func<T, TResult>)delegate
			{
				RedDotDataType redDotDataType = dataType;
				bool result = default(bool);
				return result;
			};
			IEnumerable<KeyValuePair<Item, RedDotDataType>> enumerable = (IEnumerable<KeyValuePair<Item, RedDotDataType>>)Enumerable.Where<KeyValuePair<Item, RedDotDataType>>((IEnumerable<>)dictItems, (Func<, >)(object)func);
			Func<KeyValuePair<Item, RedDotDataType>, Item> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_1;
			if (_003C_003E9__11_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<Item, RedDotDataType> x) => (Item)((KeyValuePair<, >*)(&x))->key);
			}
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<KeyValuePair<Item, RedDotDataType>, Item>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__11_));
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<Item, RedDotDataType> dictItems2 = _dictItems;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003526")]
		[Cpp2IlInjected.Address(RVA = "0xF43650", Offset = "0xF42050", VA = "0x180F43650")]
		public bool Check(Item item, RedDotDataType dataType = RedDotDataType.None)
		{
			//Discarded unreachable code: IL_006d, IL_0072, IL_00a9, IL_00d1
			//IL_0016: Expected O, but got I4
			int itemID = item.ItemID;
			_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
			CS_0024_003C_003E8__locals0.item = (Item)itemID;
			if ((long)CS_0024_003C_003E8__locals0 <= 8)
			{
				RepeatedField<AchievementData> achievementsData_ = SystemRoot.Instance.MetaClient.profile.player_.achievementsData_;
				Func<AchievementData, bool> func = (Func<AchievementData, bool>)(object)(Func<T, TResult>)delegate(AchievementData x)
				{
					AchievementItemData itemData = x.ItemData;
					int num = default(int);
					bool result = default(bool);
					if (num != 0 && x.GetRewardsToClaim() != null)
					{
						return result;
					}
					int num2 = 0;
					throw new NullReferenceException();
				};
				if (MoreLinq.FindIndex<AchievementData>((IEnumerable<>)(object)achievementsData_, (Func<, >)(object)func) <= -1)
				{
					goto IL_00b7;
				}
				Dictionary<Item, RedDotDataType> dictItems = _dictItems;
			}
			if (dataType == RedDotDataType.RoyalDutyReward)
			{
				Dictionary<Item, RedDotDataType> dictItems2 = _dictItems;
				throw new NullReferenceException();
			}
			goto IL_00b7;
			IL_00b7:
			Dictionary<Item, RedDotDataType> dictItems3 = _dictItems;
			Item item2 = CS_0024_003C_003E8__locals0.item;
			return ((Dictionary<TKey, TValue>)(object)dictItems3).ContainsKey((TKey)item2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003527")]
		[Cpp2IlInjected.Address(RVA = "0xF42B00", Offset = "0xF41500", VA = "0x180F42B00")]
		public bool Check(List<RedDotDataType> dataTypes, bool refresh = false)
		{
			//Discarded unreachable code: IL_0307, IL_030d, IL_0313, IL_0319, IL_031f, IL_0325, IL_032b, IL_0331, IL_0337, IL_033d, IL_0343, IL_0349, IL_034f, IL_0355, IL_035b, IL_0361, IL_0367, IL_036d, IL_0373, IL_0379, IL_037f, IL_0385, IL_038b, IL_0391, IL_0397, IL_039d
			//IL_023a: Expected O, but got I4
			//IL_0291: Expected O, but got I4
			Profile profile;
			bool flag = default(bool);
			uint phases = default(uint);
			Func<AchievementData, bool> func = default(Func<AchievementData, bool>);
			CancellationToken ct = default(CancellationToken);
			Func<MissionSlot, bool> func3 = default(Func<MissionSlot, bool>);
			Func<MissionSlot, bool> cpp2il__autoParamName__idx_2 = default(Func<MissionSlot, bool>);
			do
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				profile = SystemRoot.Instance.MetaClient.profile;
				if (!refresh)
				{
					break;
				}
				if (!flag)
				{
					continue;
				}
				_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				if (num2 > 1552)
				{
					if (num2 > 2080)
					{
						if (num2 == 2320)
						{
							UpdateBattlePassDutiesState();
						}
						if (num2 == 2336)
						{
							UpdateBattlePassNewEventState();
						}
						while (num2 != 4112)
						{
						}
						if (Enumerable.Count<KeyValuePair<string, StoreInfo>>((IEnumerable<>)_dictStores) > 0)
						{
							UpdateNewStoreState();
						}
						Task task = InitStoreDict();
					}
					bool flag2;
					switch (num2)
					{
					case 1808:
					{
						if (profile.player_.HasHudApparition(phases))
						{
							DutyList royalDutiesList = profile.player_.GetRoyalDutiesList();
							Dictionary<RedDotDataType, bool> dictRedDotStates2 = _dictRedDotStates;
							RepeatedField<DutySlot> slots_ = royalDutiesList.slots_;
							Func<DutySlot, bool> _003C_003E9__13_ = _003C_003Ec._003C_003E9__13_5;
							if (_003C_003E9__13_ == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DutySlot x) => x.state_ == DutySlotState.Completed);
							}
							bool flag3 = ((IEnumerable<>)(object)slots_).Any<DutySlot>((Func<, >)(object)_003C_003E9__13_);
							throw new NullReferenceException();
						}
						Dictionary<RedDotDataType, bool> dictRedDotStates3 = _dictRedDotStates;
						throw new NullReferenceException();
					}
					case 2064:
					{
						Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
						int num4 = 0;
						flag2 = FakeData.Instance.HasAnyFreeDailyReward();
						throw new NullReferenceException();
					}
					}
					while (num2 != 2080)
					{
					}
					Dictionary<RedDotDataType, bool> dictRedDotStates4 = _dictRedDotStates;
					int num5 = 0;
					flag2 = FakeData.Instance.HasAnyFreeGacha();
					throw new NullReferenceException();
				}
				if (num2 > 554)
				{
					if (num2 == 1040)
					{
						Dictionary<RedDotDataType, bool> dictRedDotStates5 = _dictRedDotStates;
						RepeatedField<AchievementData> achievementsData_ = profile.player_.achievementsData_;
						if (_003C_003Ec._003C_003E9__13_3 == null)
						{
							func = (Func<AchievementData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(AchievementData x)
							{
								bool result2 = default(bool);
								if (x.GetRewardsToClaim() != null)
								{
									return result2;
								}
								throw new NullReferenceException();
							});
						}
						int num6 = MoreLinq.FindIndex<AchievementData>((IEnumerable<>)(object)achievementsData_, (Func<, >)(object)func);
						throw new NullReferenceException();
					}
					if (-1041L <= 7L)
					{
						Dictionary<RedDotDataType, bool> dictRedDotStates6 = _dictRedDotStates;
						RepeatedField<AchievementData> achievementsData_2 = profile.player_.achievementsData_;
						Func<AchievementData, bool> func2 = (Func<AchievementData, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass13_0)(object)func)._003CCheck_003Eb__4);
						int num7 = MoreLinq.FindIndex<AchievementData>((IEnumerable<>)(object)achievementsData_2, (Func<, >)(object)func2);
						throw new NullReferenceException();
					}
					while (num2 != 1552)
					{
					}
					int num8 = 0;
					MenuStack menuStack = UiRoot.Instance._menuStack;
					int num9 = 0;
					IMenu bottom = menuStack.Bottom;
					int num10 = 0;
					int num11 = 0;
					FetchPhoneRewardsTask(ct).FireAndForgetTask();
				}
				if (num2 == 272)
				{
					Dictionary<RedDotDataType, bool> dictRedDotStates7 = _dictRedDotStates;
					ProfileWorld world_ = profile.world_;
					int num12 = 0;
					int num13 = 0;
					IEnumerable<MissionSlot> validMissionSlot = (IEnumerable<MissionSlot>)world_.GetValidMissionSlot((MissionSlotClass)num13, (Func<, >)num12);
					ProfileWorld world_2 = profile.world_;
					if (_003C_003Ec._003C_003E9__13_1 == null)
					{
						func3 = (Func<MissionSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot x) => x.MissionAccepted || x.IsMissionStarted));
					}
					IEnumerable<MissionSlot> validMissionSlot2 = (IEnumerable<MissionSlot>)world_2.GetValidMissionSlot(MissionSlotClass.Secret, (Func<, >)(object)func3);
					IEnumerable<MissionSlot> enumerable = (IEnumerable<MissionSlot>)Enumerable.Concat<MissionSlot>((IEnumerable<>)validMissionSlot, (IEnumerable<>)validMissionSlot2);
					ProfileWorld world_3 = profile.world_;
					int num14 = 0;
					IEnumerable<MissionSlot> validMissionSlot3 = (IEnumerable<MissionSlot>)world_3.GetValidMissionSlot(MissionSlotClass.Village, (Func<, >)num14);
					IEnumerable<MissionSlot> cpp2il__autoParamName__idx_ = (IEnumerable<MissionSlot>)Enumerable.Concat<MissionSlot>((IEnumerable<>)enumerable, (IEnumerable<>)validMissionSlot3);
					if (_003C_003Ec._003C_003E9__13_2 == null)
					{
						cpp2il__autoParamName__idx_2 = (Func<MissionSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot x) => x.state_ == MissionSlotState.Completed));
					}
					bool flag4 = ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<MissionSlot>((Func<, >)(object)cpp2il__autoParamName__idx_2);
					throw new NullReferenceException();
				}
				if (num2 != 512)
				{
					while (-544L > 10L)
					{
					}
				}
				UpdateCollectionItemNewState();
			}
			while (profile != null);
			Predicate<RedDotDataType> predicate = (Predicate<RedDotDataType>)(object)(Predicate<T>)delegate
			{
				//Discarded unreachable code: IL_0009
				Dictionary<RedDotDataType, bool> dictRedDotStates8 = _dictRedDotStates;
				bool result = default(bool);
				return result;
			};
			return ((List<T>)(object)dataTypes).Exists((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6003528")]
		[Cpp2IlInjected.Address(RVA = "0xF43E90", Offset = "0xF42890", VA = "0x180F43E90")]
		public bool IsNewStore(string onlineId)
		{
			Dictionary<string, StoreInfo> dictStores = _dictStores;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003529")]
		[Cpp2IlInjected.Address(RVA = "0xF43E10", Offset = "0xF42810", VA = "0x180F43E10")]
		public bool IsNewBattlePass(string battlePassOnlineId)
		{
			Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600352A")]
		[Cpp2IlInjected.Address(RVA = "0xF45AC0", Offset = "0xF444C0", VA = "0x180F45AC0")]
		[AsyncStateMachine(typeof(_003CRemoveBattlePassIsNew_003Ed__16))]
		public Task<bool> RemoveBattlePassIsNew(BattlePassSeasonData battlePassData, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600352B")]
		[Cpp2IlInjected.Address(RVA = "0xF45D80", Offset = "0xF44780", VA = "0x180F45D80")]
		[AsyncStateMachine(typeof(_003CRemoveStoresIsNew_003Ed__17))]
		public Task<bool> RemoveStoresIsNew(OnlineStoreData storeData, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600352C")]
		[Cpp2IlInjected.Address(RVA = "0xF42A40", Offset = "0xF41440", VA = "0x180F42A40")]
		public bool CheckBattlePassDuty(string battlePassOnlineId, int taskIndex)
		{
			//Discarded unreachable code: IL_000f
			Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600352D")]
		[Cpp2IlInjected.Address(RVA = "0xF43C70", Offset = "0xF42670", VA = "0x180F43C70")]
		public bool HasBattlePassDutiesToClaim(string battlePassOnlineId)
		{
			//Discarded unreachable code: IL_000f
			Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600352E")]
		[Cpp2IlInjected.Address(RVA = "0xF46780", Offset = "0xF45180", VA = "0x180F46780")]
		private void UpdateBattlePassDutiesState()
		{
			//Discarded unreachable code: IL_0046
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
			Func<KeyValuePair<string, BattlePassInfo>, bool> _003C_003E9__20_ = _003C_003Ec._003C_003E9__20_0;
			if (_003C_003E9__20_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			if (!((IEnumerable<>)dictBattlePasses).Any<KeyValuePair<string, BattlePassInfo>>((Func<, >)(object)_003C_003E9__20_))
			{
			}
			int num = 0;
			bool flag = UiRoot.Instance.IsBattlePassUnlocked();
		}

		[Cpp2IlInjected.Token(Token = "0x600352F")]
		[Cpp2IlInjected.Address(RVA = "0xF46950", Offset = "0xF45350", VA = "0x180F46950")]
		private void UpdateBattlePassNewEventState()
		{
			//Discarded unreachable code: IL_0046
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
			Func<KeyValuePair<string, BattlePassInfo>, bool> _003C_003E9__21_ = _003C_003Ec._003C_003E9__21_0;
			if (_003C_003E9__21_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			if (!((IEnumerable<>)dictBattlePasses).Any<KeyValuePair<string, BattlePassInfo>>((Func<, >)(object)_003C_003E9__21_))
			{
			}
			int num = 0;
			bool flag = UiRoot.Instance.IsBattlePassUnlocked();
		}

		[Cpp2IlInjected.Token(Token = "0x6003530")]
		[Cpp2IlInjected.Address(RVA = "0xF43D10", Offset = "0xF42710", VA = "0x180F43D10")]
		[AsyncStateMachine(typeof(_003CInitStoreDict_003Ed__22))]
		private Task InitStoreDict()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003531")]
		[Cpp2IlInjected.Address(RVA = "0xF471C0", Offset = "0xF45BC0", VA = "0x180F471C0")]
		private void UpdateNewStoreState()
		{
			//Discarded unreachable code: IL_0036
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			Dictionary<string, StoreInfo> dictStores = _dictStores;
			Func<KeyValuePair<string, StoreInfo>, bool> _003C_003E9__23_ = _003C_003Ec._003C_003E9__23_0;
			if (_003C_003E9__23_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			bool flag = ((IEnumerable<>)dictStores).Any<KeyValuePair<string, StoreInfo>>((Func<, >)(object)_003C_003E9__23_);
		}

		[Cpp2IlInjected.Token(Token = "0x6003532")]
		[Cpp2IlInjected.Address(RVA = "0xF46BF0", Offset = "0xF455F0", VA = "0x180F46BF0")]
		private void UpdateCollectionItemNewState()
		{
			//Discarded unreachable code: IL_00f9
			//IL_0013: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			//IL_00d6: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			//IL_00eb: Expected I4, but got O
			//IL_00f8: Expected O, but got I4
			//IL_00f8: Expected O, but got I4
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			if (((Dictionary<TKey, TValue>)(object)dictRedDotStates)[(TKey)544] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)545] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)546] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)547] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)548] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)549] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)550] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)551] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)552] == null && ((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)553] == null)
			{
				bool flag = (byte)(int)((Dictionary<TKey, TValue>)(object)_dictRedDotStates)[(TKey)554] != 0;
			}
			((Dictionary<TKey, TValue>)(object)dictRedDotStates)[(TKey)512] = (TValue)1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003533")]
		[Cpp2IlInjected.Address(RVA = "0xF46F40", Offset = "0xF45940", VA = "0x180F46F40")]
		public bool UpdateHistory(List<RedDotDataType> dataTypes, bool force = false)
		{
			//Discarded unreachable code: IL_0026, IL_005a, IL_0060
			if (!force)
			{
				bool flag = default(bool);
				if (flag)
				{
					if ((flag ? 1 : 0) > (true ? 1 : 0))
					{
						Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
						throw new NullReferenceException();
					}
					Dictionary<RedDotDataType, bool> dictRedDotStates2 = _dictRedDotStates;
					throw new NullReferenceException();
				}
				bool result = default(bool);
				return result;
			}
			Action<RedDotDataType> action = (Action<RedDotDataType>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Dictionary<RedDotDataType, bool> dictRedDotStates3 = _dictRedDotStates;
			};
			((List<T>)(object)dataTypes).ForEach((Action<>)(object)action);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003534")]
		[Cpp2IlInjected.Address(RVA = "0xF45620", Offset = "0xF44020", VA = "0x180F45620")]
		internal void OnRoyalDutyRewardClaimed(Item dutyItem)
		{
			//Discarded unreachable code: IL_0040
			//IL_0012: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			List<RedDotDataType> list = (List<RedDotDataType>)(object)new List<T>();
			((List<T>)(object)list).Add((T)1040);
			((List<T>)(object)list).Add((T)1808);
			bool flag = this.Check((List<>)(object)list, true);
			UpdateRedDotsInRealTime(RedDotDataType.RoyalDutyReward);
			UpdateRedDotsInRealTime(RedDotDataType.AchievementReward);
		}

		[Cpp2IlInjected.Token(Token = "0x6003535")]
		[Cpp2IlInjected.Address(RVA = "0xF46DE0", Offset = "0xF457E0", VA = "0x180F46DE0")]
		public bool UpdateHistory(Item item, RedDotDataType dataType = RedDotDataType.None)
		{
			//Discarded unreachable code: IL_003f
			Dictionary<Item, RedDotDataType> dictItems = _dictItems;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<Item, RedDotDataType> dictItems2 = _dictItems;
				if (dataType != 0)
				{
					Dictionary<Item, RedDotDataType> dictItems3 = _dictItems;
					bool flag2 = default(bool);
					if (!flag2)
					{
						List<RedDotDataType> list = (List<RedDotDataType>)(object)new List<T>();
						int num = 0;
						bool flag3 = this.UpdateHistory((List<>)(object)list, (byte)num != 0);
					}
				}
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003536")]
		[Cpp2IlInjected.Address(RVA = "0xF47330", Offset = "0xF45D30", VA = "0x180F47330")]
		private void UpdateRedDotsInRealTime(RedDotDataType type)
		{
			//Discarded unreachable code: IL_0032
			List<RedDot> redDotsForRealTimeUpdate = _redDotsForRealTimeUpdate;
			Func<RedDotDataType, bool> func = default(Func<RedDotDataType, bool>);
			Action<RedDot> action = (Action<RedDot>)(object)(Action<T>)delegate(RedDot x)
			{
				//Discarded unreachable code: IL_006f
				//IL_0010: Expected O, but got I4
				//IL_0028: Expected O, but got I4
				GameObject gameObject = x.gameObject;
				int num = 0;
				if (gameObject != (UnityEngine.Object)num)
				{
					List<RedDotDataType> dataTypes = x.DataTypes;
					RedDotDataType redDotDataType = type;
					if (((List<T>)(object)dataTypes).Contains((T)redDotDataType))
					{
						Func<RedDotDataType, bool> func2 = func;
						List<RedDotDataType> dataTypes2 = x.DataTypes;
						if (func2 == null)
						{
							func = (Func<RedDotDataType, bool>)(object)(Func<T, TResult>)delegate
							{
								//Discarded unreachable code: IL_000e
								Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
								bool result = default(bool);
								return result;
							};
						}
						bool active = ((IEnumerable<>)dataTypes2).Any<RedDotDataType>((Func<, >)(object)func2);
						x.gameObject.SetActive(active);
					}
				}
			};
			((List<T>)(object)redDotsForRealTimeUpdate).ForEach((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6003537")]
		[Cpp2IlInjected.Address(RVA = "0xF45160", Offset = "0xF43B60", VA = "0x180F45160")]
		private void OnMissionSlotUpdated(MissionSlotClass SlotClass, int SlotId, MissionItemData missionData, SlotUpdatedReason reason, List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_0038, IL_0045
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			int num = 0;
			MissionSlot missionSlot = default(MissionSlot);
			if (missionSlot != null)
			{
				MissionSlotState state_ = missionSlot.state_;
			}
			if (num != 0 && num == 1)
			{
				Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003538")]
		[Cpp2IlInjected.Address(RVA = "0xF45710", Offset = "0xF44110", VA = "0x180F45710")]
		private void OnVillageAreaUnlocked(VillageAreaType areaType, [Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_000d, IL_001a
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003539")]
		[Cpp2IlInjected.Address(RVA = "0xF44580", Offset = "0xF42F80", VA = "0x180F44580")]
		private void OnCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromCooking)
		{
			//Discarded unreachable code: IL_001a, IL_0028, IL_002d, IL_003b, IL_0049, IL_004a
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			CollectionSetItemData collectionSetItemData = default(CollectionSetItemData);
			CollectionSubMenu submenu_ = collectionSetItemData.submenu_;
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600353A")]
		[Cpp2IlInjected.Address(RVA = "0xF44D80", Offset = "0xF43780", VA = "0x180F44D80")]
		private void OnDutySlotUpdated(int slotID, bool generated)
		{
			//Discarded unreachable code: IL_00a9, IL_00b6
			//IL_0087: Expected O, but got I4
			DutyList royalDutiesList = SystemRoot.Instance.MetaClient.profile.player_.GetRoyalDutiesList();
			if (royalDutiesList == null)
			{
				return;
			}
			RepeatedField<DutySlot> slots_ = royalDutiesList.slots_;
			if (slots_ != null && ((RepeatedField<T>)(object)slots_).Count != 0)
			{
				RepeatedField<DutySlot> slots_2 = royalDutiesList.slots_;
				Func<DutySlot, bool> func = (Func<DutySlot, bool>)(object)(Func<T, TResult>)delegate(DutySlot x)
				{
					//Discarded unreachable code: IL_0011
					int num = slotID;
					return x.slotId_ == num;
				};
				DutySlot dutySlot = Enumerable.First<DutySlot>((IEnumerable<>)(object)slots_2, (Func<, >)(object)func);
				if (dutySlot != null && dutySlot.state_ == DutySlotState.Completed)
				{
					List<RedDotDataType> list = (List<RedDotDataType>)(object)new List<T>();
					((List<T>)(object)list).Add((T)1808);
					bool flag = this.Check((List<>)(object)list, true);
					Dictionary<Item, RedDotDataType> dictItems = _dictItems;
					int dutyId_ = dutySlot.dutyId_;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600353B")]
		[Cpp2IlInjected.Address(RVA = "0xF452F0", Offset = "0xF43CF0", VA = "0x180F452F0")]
		public void OnNewShopProductAdded()
		{
			//Discarded unreachable code: IL_000d, IL_001a
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600353C")]
		[Cpp2IlInjected.Address(RVA = "0xF450E0", Offset = "0xF43AE0", VA = "0x180F450E0")]
		public void OnFreeGachaClaimed()
		{
			//Discarded unreachable code: IL_001a, IL_0027
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			int num = 0;
			bool flag = FakeData.Instance.HasAnyFreeGacha();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600353D")]
		[Cpp2IlInjected.Address(RVA = "0xF45060", Offset = "0xF43A60", VA = "0x180F45060")]
		public void OnFreeDailyRewardClaimed()
		{
			//Discarded unreachable code: IL_001a, IL_0027
			Dictionary<RedDotDataType, bool> dictRedDotStates = _dictRedDotStates;
			int num = 0;
			bool flag = FakeData.Instance.HasAnyFreeDailyReward();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600353E")]
		[Cpp2IlInjected.Address(RVA = "0xF455C0", Offset = "0xF43FC0", VA = "0x180F455C0")]
		public void OnRefreshBattlePassNewState()
		{
			UpdateBattlePassNewEventState();
			UpdateRedDotsInRealTime(RedDotDataType.BattlePassNewEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600353F")]
		[Cpp2IlInjected.Address(RVA = "0xF455F0", Offset = "0xF43FF0", VA = "0x180F455F0")]
		public void OnRefreshNewStoreState()
		{
			UpdateNewStoreState();
			UpdateRedDotsInRealTime(RedDotDataType.InGameShopNewStore);
		}

		[Cpp2IlInjected.Token(Token = "0x6003540")]
		[Cpp2IlInjected.Address(RVA = "0xF45350", Offset = "0xF43D50", VA = "0x180F45350")]
		private unsafe void OnOnlineStoresUpdate(Dictionary<string, OnlineStoreData> store)
		{
			//Discarded unreachable code: IL_0036, IL_003c, IL_0042, IL_0048, IL_004e, IL_0054, IL_005a, IL_0060
			//IL_0022: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Client client = default(Client);
				if (!((MapField<TKey, TValue>)(object)client.profile.player_.onlineShopStates_.stores_).TryGetValue((TKey)num, out *(TValue*)num))
				{
					UpdateStoreIsNew((string)num, isNew: true);
				}
				UpdateStoreIsNew((string)num, (byte)num != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003541")]
		[Cpp2IlInjected.Address(RVA = "0xF44170", Offset = "0xF42B70", VA = "0x180F44170")]
		private unsafe void OnBattlePassTasksUpdate(Dictionary<string, BattlePassSeasonData> battlePassSeasons)
		{
			//Discarded unreachable code: IL_004e, IL_0054, IL_005a, IL_0060, IL_0066, IL_006c, IL_0072, IL_0078, IL_007e, IL_0084, IL_008a
			//IL_0028: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			Client client = default(Client);
			if (((MapField<TKey, TValue>)(object)client.profile.player_.battlePassStates_.progress_).TryGetValue((TKey)num, out *(TValue*)num))
			{
				UpdateBattlePassIsNew((string)num, (byte)num != 0);
				bool flag2 = default(bool);
				if (flag2)
				{
					while (!flag2)
					{
					}
				}
				num++;
				if (num == 0)
				{
				}
			}
			UpdateBattlePassIsNew((string)num, isNew: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6003542")]
		[Cpp2IlInjected.Address(RVA = "0xF44040", Offset = "0xF42A40", VA = "0x180F44040")]
		private void OnBattlePassTaskUpdate(string battlePassOnlineId, BattlePassTaskProgress taskProgress)
		{
			//Discarded unreachable code: IL_0049
			BattlePassTaskState taskState_ = taskProgress.taskState_;
			if (taskState_ == BattlePassTaskState.Completed)
			{
				goto IL_0025;
			}
			if (taskState_ == BattlePassTaskState.CurrencyClaimed)
			{
				int _003CIndex_003Ek__BackingField = taskProgress.Index;
				Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
				bool flag = default(bool);
				if (flag)
				{
					int num = default(int);
					_003CIndex_003Ek__BackingField = num;
					goto IL_0025;
				}
			}
			goto IL_0036;
			IL_0036:
			UpdateBattlePassDutiesState();
			UpdateRedDotsInRealTime(RedDotDataType.BattlePassDuties);
			return;
			IL_0025:
			int _003CIndex_003Ek__BackingField2 = taskProgress.Index;
			AddBattlePassTaskIndex(battlePassOnlineId, _003CIndex_003Ek__BackingField2);
			goto IL_0036;
		}

		[Cpp2IlInjected.Token(Token = "0x6003543")]
		[Cpp2IlInjected.Address(RVA = "0xF46900", Offset = "0xF45300", VA = "0x180F46900")]
		private void UpdateBattlePassIsNew(string battlePassOnlineId, bool isNew)
		{
			//Discarded unreachable code: IL_0020
			GetOrAddBattlePassInfo(battlePassOnlineId).IsNew = isNew;
			UpdateBattlePassNewEventState();
			UpdateRedDotsInRealTime(RedDotDataType.BattlePassNewEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x6003544")]
		[Cpp2IlInjected.Address(RVA = "0xF47420", Offset = "0xF45E20", VA = "0x180F47420")]
		private void UpdateStoreIsNew(string onlineId, bool isNew)
		{
			//Discarded unreachable code: IL_0032
			Dictionary<string, StoreInfo> dictStores = _dictStores;
			bool flag = default(bool);
			if (!flag)
			{
				StoreInfo storeInfo = new StoreInfo();
				Dictionary<string, StoreInfo> dictStores2 = _dictStores;
				throw new NullReferenceException();
			}
			UpdateNewStoreState();
			UpdateRedDotsInRealTime(RedDotDataType.InGameShopNewStore);
		}

		[Cpp2IlInjected.Token(Token = "0x6003545")]
		[Cpp2IlInjected.Address(RVA = "0xF46AD0", Offset = "0xF454D0", VA = "0x180F46AD0")]
		private void UpdateBattlePassTask(string battlePassOnlineId, BattlePassTaskProgress taskProgress)
		{
			//Discarded unreachable code: IL_0038
			switch (taskProgress.taskState_)
			{
			case BattlePassTaskState.CurrencyClaimed:
			{
				int _003CIndex_003Ek__BackingField2 = taskProgress.Index;
				Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
				bool flag = default(bool);
				if (flag)
				{
					int num = default(int);
					_003CIndex_003Ek__BackingField2 = num;
				}
				break;
			}
			case BattlePassTaskState.Completed:
			{
				int _003CIndex_003Ek__BackingField = taskProgress.Index;
				AddBattlePassTaskIndex(battlePassOnlineId, _003CIndex_003Ek__BackingField);
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003546")]
		[Cpp2IlInjected.Address(RVA = "0xF43AD0", Offset = "0xF424D0", VA = "0x180F43AD0")]
		private BattlePassInfo GetOrAddBattlePassInfo(string battlePassOnlineId)
		{
			Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
			bool flag = default(bool);
			if (!flag)
			{
				BattlePassInfo battlePassInfo = new BattlePassInfo();
				Dictionary<string, BattlePassInfo> dictBattlePasses2 = _dictBattlePasses;
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003547")]
		[Cpp2IlInjected.Address(RVA = "0xF43BA0", Offset = "0xF425A0", VA = "0x180F43BA0")]
		private StoreInfo GetOrAddStoresInfo(string onlineId)
		{
			Dictionary<string, StoreInfo> dictStores = _dictStores;
			bool flag = default(bool);
			if (!flag)
			{
				StoreInfo storeInfo = new StoreInfo();
				Dictionary<string, StoreInfo> dictStores2 = _dictStores;
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003548")]
		[Cpp2IlInjected.Address(RVA = "0xF42920", Offset = "0xF41320", VA = "0x180F42920")]
		private void AddBattlePassTaskIndex(string battlePassOnlineId, int taskIndex)
		{
			//Discarded unreachable code: IL_0024
			//IL_0014: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			BattlePassInfo orAddBattlePassInfo = GetOrAddBattlePassInfo(battlePassOnlineId);
			if (!((List<T>)(object)orAddBattlePassInfo.CompletedTaskIndexes).Contains((T)taskIndex))
			{
				((List<T>)(object)orAddBattlePassInfo.CompletedTaskIndexes).Add((T)taskIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003549")]
		[Cpp2IlInjected.Address(RVA = "0xF45C20", Offset = "0xF44620", VA = "0x180F45C20")]
		private void RemoveBattlePassTaskIndex(string battlePassOnlineId, int taskIndex)
		{
			//Discarded unreachable code: IL_000c
			Dictionary<string, BattlePassInfo> dictBattlePasses = _dictBattlePasses;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600354A")]
		[Cpp2IlInjected.Address(RVA = "0xF43F10", Offset = "0xF42910", VA = "0x180F43F10")]
		public void OnAchievementRewardClaimed(AchievementItemData achievementItemData)
		{
			//Discarded unreachable code: IL_0042
			//IL_0019: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			AchievementType type_ = achievementItemData.type_;
			List<RedDotDataType> list = (List<RedDotDataType>)(object)new List<T>();
			((List<T>)(object)list).Add((T)1040);
			((List<T>)(object)list).Add((T)1808);
			bool flag = this.Check((List<>)(object)list, true);
			int iD = achievementItemData.ID;
			UpdateRedDotsInRealTime(RedDotDataType.AchievementReward);
		}

		[Cpp2IlInjected.Token(Token = "0x600354B")]
		[Cpp2IlInjected.Address(RVA = "0xF439B0", Offset = "0xF423B0", VA = "0x180F439B0")]
		[AsyncStateMachine(typeof(_003CFetchPhoneRewardsTask_003Ed__49))]
		private Task FetchPhoneRewardsTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600354C")]
		[Cpp2IlInjected.Address(RVA = "0xF47530", Offset = "0xF45F30", VA = "0x180F47530")]
		public RedDotHelper()
		{
		}
	}
}
