using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Missions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Mdl.Audio;
using Mdl.Characters;
using Mdl.Missions;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000687")]
	public class QuestLogMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40024BC")]
		[SerializeField]
		private ShowCompletedToggleButton _showCompletedToggleButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40024BD")]
		[SerializeField]
		private LoopVerticalScrollRect _missionScrollList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40024BE")]
		[SerializeField]
		private QuestLogDetails _questDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40024BF")]
		[SerializeField]
		private VerticalLayoutGroup _detailsPaddingSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40024C0")]
		[SerializeField]
		private GameObject _noQuests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40024C1")]
		[SerializeField]
		[Header("Fill the field below to adjust size for Switch")]
		private int _switchFontMin = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x40024C2")]
		[SerializeField]
		private int _switchFontMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40024C3")]
		private List<QuestLogListItemData> _allMissionData = (List<QuestLogListItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40024C4")]
		private List<QuestLogListItemData.CategoryType> _hiddenCategories = (List<QuestLogListItemData.CategoryType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40024C5")]
		private bool _controllerConnected;

		[Cpp2IlInjected.Token(Token = "0x17000638")]
		[HideInInspector]
		public bool AdjustForSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6002A17")]
			[Cpp2IlInjected.Address(RVA = "0xF31BD0", Offset = "0xF305D0", VA = "0x180F31BD0")]
			get
			{
				if (_switchFontMin == -1)
				{
					int num = 0;
				}
				return _switchFontMax != -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000639")]
		private Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6002A18")]
			[Cpp2IlInjected.Address(RVA = "0xF31BF0", Offset = "0xF305F0", VA = "0x180F31BF0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance.MetaClient.profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A19")]
		[Cpp2IlInjected.Address(RVA = "0xF31160", Offset = "0xF2FB60", VA = "0x180F31160", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_006b
			int isOn = 0;
			OnShowCompletedValueChanged((byte)isOn != 0);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_missionScrollList).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnQuestListItemData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_missionScrollList).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnQuestListItemSelect);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
			ShowCompletedToggleButton showCompletedToggleButton = _showCompletedToggleButton;
			ToggleButton.OnValueChangedDelegate value = OnShowCompletedValueChanged;
			showCompletedToggleButton.OnValueChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1A")]
		[Cpp2IlInjected.Address(RVA = "0xF31840", Offset = "0xF30240", VA = "0x180F31840", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_006b
			int isOn = 0;
			OnShowCompletedValueChanged((byte)isOn != 0);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_missionScrollList).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnQuestListItemData);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_missionScrollList).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnQuestListItemSelect);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			ShowCompletedToggleButton showCompletedToggleButton = _showCompletedToggleButton;
			ToggleButton.OnValueChangedDelegate value = OnShowCompletedValueChanged;
			showCompletedToggleButton.OnValueChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1B")]
		[Cpp2IlInjected.Address(RVA = "0xF312F0", Offset = "0xF2FCF0", VA = "0x180F312F0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_002e
			int isOn = 0;
			OnShowCompletedValueChanged((byte)isOn != 0);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.TrackedMissionChanged value = OnTrackedMissionChanged;
			_003CDispatcher_003Ek__BackingField.OnTrackedMissionChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1C")]
		[Cpp2IlInjected.Address(RVA = "0xF319D0", Offset = "0xF303D0", VA = "0x180F319D0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_002b
			base.UnregisterFocusedListeners();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.TrackedMissionChanged value = OnTrackedMissionChanged;
			_003CDispatcher_003Ek__BackingField.OnTrackedMissionChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1D")]
		[Cpp2IlInjected.Address(RVA = "0xF2F560", Offset = "0xF2DF60", VA = "0x180F2F560", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_002e
			base.OnPush(stack, param);
			SystemRoot.Instance.GetSystem<AudioManager>().PushGameState(AudioManager.GameState.MainMenu);
			base.Background.GetComponent<MainMenuBackground>().SetLeftWidth(520f);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1E")]
		[Cpp2IlInjected.Address(RVA = "0xE1A830", Offset = "0xE19230", VA = "0x180E1A830", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1F")]
		[Cpp2IlInjected.Address(RVA = "0xF2FEB0", Offset = "0xF2E8B0", VA = "0x180F2FEB0")]
		private unsafe void RefreshData()
		{
			//Discarded unreachable code: IL_03e1, IL_03e7, IL_03ed, IL_03f3, IL_03f9, IL_03ff, IL_0405, IL_040b, IL_0411, IL_0417, IL_041d, IL_0423, IL_0429, IL_042f, IL_0435, IL_043b, IL_0441, IL_0447, IL_044d, IL_0453, IL_0459, IL_045f, IL_046b, IL_0471, IL_0477
			//IL_0099: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_031e: Expected O, but got I4
			//IL_0381: Expected O, but got I4
			Predicate<MissionSlot> predicate = default(Predicate<MissionSlot>);
			Func<MissionSlot, bool> func4 = default(Func<MissionSlot, bool>);
			bool flag = default(bool);
			bool flag2 = default(bool);
			Client client = default(Client);
			bool flag3 = default(bool);
			Func<MissionSlot, bool> cpp2il__autoParamName__idx_ = default(Func<MissionSlot, bool>);
			IEnumerable<MissionSlot> cpp2il__autoParamName__idx_2 = default(IEnumerable<MissionSlot>);
			bool flag4 = default(bool);
			Func<Item, bool> func7 = default(Func<Item, bool>);
			Func<Item, bool> func8 = default(Func<Item, bool>);
			IEnumerable<Item> enumerable2 = default(IEnumerable<Item>);
			bool flag5 = default(bool);
			IEnumerable<MissionSlot> enumerable3 = default(IEnumerable<MissionSlot>);
			MissionItemData missionItemData = default(MissionItemData);
			MissionItemData missionItemData2 = default(MissionItemData);
			MissionItemData item2 = default(MissionItemData);
			Func<MissionItemData, string> func11 = default(Func<MissionItemData, string>);
			while (true)
			{
				int num = 0;
				((List<T>)(object)_allMissionData).Clear();
				bool allowDebugMissions = Profile.settings_.isDev_;
				ProfileWorld world_ = Profile.world_;
				Func<MissionSlot, bool> func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
				{
					DateTime localTime3 = SystemRoot.Instance.MetaClient.LocalTime;
					bool flag8 = x.IsMissionExpired(localTime3);
					if (!flag8 && (allowDebugMissions != flag8 || x.Data.status_ != 0) && x.state_ > MissionSlotState.Available)
					{
						return !x.OwnerInactive;
					}
					int num16 = 0;
					throw new NullReferenceException();
				};
				int num2 = 0;
				List<MissionSlot> list = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>(world_.GetValidMissionSlot((MissionSlotClass)num2, (Func<, >)(object)func));
				Func<MissionSlot, bool> _003C_003E9__20_ = _003C_003Ec._003C_003E9__20_1;
				if (_003C_003E9__20_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot x) => x.Data.type_ == MissionType.Realm);
				}
				IEnumerable<MissionSlot> enumerable = (IEnumerable<MissionSlot>)Enumerable.Where<MissionSlot>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__20_);
				Func<MissionSlot, string> func2 = (Func<MissionSlot, string>)(object)new Func<T, TResult>(SlotOwnerDisplayName);
				int num3 = 0;
				List<MissionSlot> list2 = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>((IEnumerable<>)Enumerable.OrderBy<MissionSlot, string>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
				int num4 = 0;
				this.AddToMissionData((List<>)(object)list2, (QuestLogListItemData.CategoryType)num4);
				if (_003C_003Ec._003C_003E9__20_2 == null)
				{
					predicate = (Predicate<MissionSlot>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((MissionSlot x) => x.Data.type_ == MissionType.Realm));
				}
				int num5 = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
				Func<MissionSlot, string> func3 = (Func<MissionSlot, string>)(object)new Func<T, TResult>(SlotOwnerDisplayName);
				int num6 = 0;
				List<MissionSlot> list3 = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>((IEnumerable<>)Enumerable.OrderBy<MissionSlot, string>((IEnumerable<>)list, (Func<, >)(object)func3));
				this.AddToMissionData((List<>)(object)list3, QuestLogListItemData.CategoryType.Story);
				MegaEventProgress megaEventProgress_ = SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_;
				if (megaEventProgress_.IsActive)
				{
					int num7 = 0;
					MegaEventData megaEventData = FakeData.Instance.MegaEventData;
					DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
					DateTime _003CEndTime_003Ek__BackingField = megaEventProgress_.EndTime;
					DateTime _003CStartTime_003Ek__BackingField = megaEventProgress_.StartTime;
					if (megaEventData.GetState(serverTime, _003CStartTime_003Ek__BackingField, _003CEndTime_003Ek__BackingField) == MegaEventState.InProgress)
					{
						ProfileWorld world_2 = Profile.world_;
						if (_003C_003Ec._003C_003E9__20_8 == null)
						{
							func4 = (Func<MissionSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot x) => !x.OwnerInactive));
						}
						List<MissionSlot> list4 = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>(world_2.GetValidMissionSlot(MissionSlotClass.TimeLimitedEvent, (Func<, >)(object)func4));
						this.AddToMissionData((List<>)(object)list4, QuestLogListItemData.CategoryType.Event);
					}
				}
				CharacterManager characterManager = SystemRoot.Instance.GetSystem<CharacterManager>();
				MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
				ProfileWorld world_3 = Profile.world_;
				Func<MissionSlot, bool> func5 = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
				{
					//IL_0029: Expected O, but got I4
					if (x.MissionAccepted || x.IsMissionStarted)
					{
						CharacterManager characterManager2 = characterManager;
						Item characterItem2 = x.CharacterItem;
						int num14 = 0;
						Mdl.Characters.Character character = default(Mdl.Characters.Character);
						if (character != (UnityEngine.Object)num14 && (allowDebugMissions || x.Data.status_ != 0) && !x.OwnerInactive)
						{
							Client client2 = default(Client);
							DateTime localTime2 = client2.LocalTime;
							return !x.IsMissionExpired(localTime2);
						}
					}
					int num15 = 0;
					throw new NullReferenceException();
				};
				List<MissionSlot> list5 = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>(world_3.GetValidMissionSlot(MissionSlotClass.Secret, (Func<, >)(object)func5));
				ProfileWorld world_4 = Profile.world_;
				Func<MissionSlot, bool> func6 = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
				{
					DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
					if (!x.IsMissionExpired(localTime))
					{
						bool ownerInactive = x.OwnerInactive;
						if (!ownerInactive && x.state_ > MissionSlotState.Available && (allowDebugMissions != ownerInactive || x.Data.status_ != 0))
						{
							return x.state_ <= MissionSlotState.Completed;
						}
					}
					int num13 = 0;
					throw new NullReferenceException();
				};
				List<MissionSlot> list6 = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>(world_4.GetValidMissionSlot(MissionSlotClass.Village, (Func<, >)(object)func6));
				List<MissionItemData> list7 = (List<MissionItemData>)(object)new List<T>();
				RepeatedField<Meta.Character> characters_ = Profile.world_.characters_;
				if (flag)
				{
					if (flag2)
					{
						Profile profile = Profile;
						Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client.TransactionContext;
						if (flag3)
						{
							if (_003C_003Ec._003C_003E9__20_9 == null)
							{
								cpp2il__autoParamName__idx_ = (Func<MissionSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionSlot x)
								{
									MissionItemData data = x.Data;
									if (data != null)
									{
										return data.type_ == MissionType.Village;
									}
									throw new NullReferenceException();
								});
							}
							if (!((IEnumerable<>)cpp2il__autoParamName__idx_2).Any<MissionSlot>((Func<, >)(object)cpp2il__autoParamName__idx_))
							{
								QuestInformation questInfo_ = Profile.world_.questInfo_;
								if (flag4)
								{
									QuestInformation questInfo_2 = Profile.world_.questInfo_;
									if (func7 == null)
									{
										func8 = (func7 = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
										{
											//Discarded unreachable code: IL_003a
											if (!Profile.settings_.isDev_)
											{
												ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
												MissionItemData missionItemData3 = default(MissionItemData);
												if (missionItemData3.status_ == MissionItemData.Types.MissionStatus.Debug)
												{
													int num12 = 0;
												}
											}
											ItemDatabase _003CInstance_003Ek__BackingField4 = ItemDatabase.Instance;
											MissionItemData missionItemData4 = default(MissionItemData);
											return missionItemData4.type_ == MissionType.Village;
										});
									}
									Item item = Enumerable.FirstOrDefault<Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func8);
									while (!flag5)
									{
									}
									if (!ItemDatabase.Instance.TryGetItemData(item, out *(MissionItemData*)num))
									{
										continue;
									}
									((List<T>)(object)list7).Add((T)num);
								}
							}
						}
					}
					if (enumerable3 != null)
					{
						while (missionItemData == null)
						{
						}
						while (missionItemData.type_ != MissionType.Village)
						{
						}
						if (!Profile.settings_.isDev_)
						{
							while (missionItemData2.status_ == MissionItemData.Types.MissionStatus.Debug)
							{
							}
						}
						((List<T>)(object)list7).Add((T)item2);
					}
					if (enumerable3 != null)
					{
					}
					if (num != 0)
					{
						break;
					}
				}
				if (num != 0)
				{
					continue;
				}
				((List<T>)(object)list5).AddRange((IEnumerable<>)list6);
				Func<MissionSlot, string> func9 = (Func<MissionSlot, string>)(object)new Func<T, TResult>(SlotOwnerDisplayName);
				int num8 = 0;
				List<MissionSlot> list8 = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>((IEnumerable<>)Enumerable.OrderBy<MissionSlot, string>((IEnumerable<>)list5, (Func<, >)(object)func9));
				Func<MissionItemData, bool> func10 = (Func<MissionItemData, bool>)(object)(Func<T, TResult>)delegate(MissionItemData x)
				{
					QuestLogMenu questLogMenu = this;
					ConditionsList unlockConditions_ = x.unlockConditions_;
					Profile profile2 = questLogMenu.Profile;
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.TransactionContext;
					bool flag6 = unlockConditions_.Evaluate(profile2, _003CTransactionContext_003Ek__BackingField2);
					if (!flag6)
					{
						return flag6;
					}
					QuestLogMenu questLogMenu2 = this;
					ConditionsList availableConditions_ = x.availableConditions_;
					Profile profile3 = questLogMenu2.Profile;
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.TransactionContext;
					bool flag7 = availableConditions_.Evaluate(profile3, _003CTransactionContext_003Ek__BackingField3);
					throw new NullReferenceException();
				};
				IOrderedEnumerable<MissionItemData> orderedEnumerable = (IOrderedEnumerable<MissionItemData>)Enumerable.OrderByDescending<MissionItemData, bool>((IEnumerable<>)list7, (Func<, >)(object)func10);
				if (_003C_003Ec._003C_003E9__20_6 == null)
				{
					func11 = (Func<MissionItemData, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionItemData y)
					{
						//Discarded unreachable code: IL_0022
						ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
						int ownerCharacter = y.OwnerCharacter;
						int num9 = 0;
						uint num10 = default(uint);
						if (num9 < (int)num10)
						{
							num9 += num9;
							num9++;
						}
						int num11 = 0;
						string result2 = default(string);
						return result2;
					});
				}
				List<MissionItemData> list9 = (List<MissionItemData>)(object)Enumerable.ToList<MissionItemData>((IEnumerable<>)Enumerable.ThenBy<MissionItemData, string>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func11));
				return;
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6002A33")]
			[Cpp2IlInjected.Address(RVA = "0xF31730", Offset = "0xF30130", VA = "0x180F31730")]
			static string SlotOwnerDisplayName(MissionSlot slot)
			{
				//Discarded unreachable code: IL_000f
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item characterItem = slot.CharacterItem;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A20")]
		[Cpp2IlInjected.Address(RVA = "0xF2DE10", Offset = "0xF2C810", VA = "0x180F2DE10")]
		private void AddToMissionData(List<MissionSlot> missions, QuestLogListItemData.CategoryType category)
		{
			//Discarded unreachable code: IL_00c0
			//IL_0093: Expected O, but got I4
			Func<MissionSlot, bool> _003C_003E9__21_ = _003C_003Ec._003C_003E9__21_0;
			if (_003C_003E9__21_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot mission) => mission.Data != null);
			}
			IEnumerable<MissionSlot> enumerable = (IEnumerable<MissionSlot>)Enumerable.Where<MissionSlot>((IEnumerable<>)missions, (Func<, >)(object)_003C_003E9__21_);
			if (!Enumerable.Any<MissionSlot>((IEnumerable<>)enumerable))
			{
				return;
			}
			List<QuestLogListItemData> allMissionData = _allMissionData;
			Func<QuestLogListItemData, bool> func = (Func<QuestLogListItemData, bool>)(object)(Func<T, TResult>)delegate
			{
				QuestLogListItemData.CategoryType categoryType3 = category;
				bool result = default(bool);
				return result;
			};
			if (((IEnumerable<>)allMissionData).All<QuestLogListItemData>((Func<, >)(object)func))
			{
				List<QuestLogListItemData> allMissionData2 = _allMissionData;
				int num = 0;
				int num2 = 0;
				QuestLogListItemData.CategoryType categoryType = category;
			}
			List<QuestLogListItemData.CategoryType> hiddenCategories = _hiddenCategories;
			QuestLogListItemData.CategoryType categoryType2 = category;
			if (!((List<T>)(object)hiddenCategories).Contains((T)categoryType2))
			{
				List<QuestLogListItemData> allMissionData3 = _allMissionData;
				Func<MissionSlot, QuestLogListItemData> func2 = (Func<MissionSlot, QuestLogListItemData>)(object)(Func<T, TResult>)delegate(MissionSlot mission)
				{
					category = QuestLogListItemData.CategoryType.Realm;
					UnknownFieldSet unknownFields = mission._unknownFields;
					/*Error: Unexpected end of block*/;
				};
				IEnumerable<MissionSlot> enumerable2 = (IEnumerable<MissionSlot>)Enumerable.Select<MissionSlot, QuestLogListItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
				((List<T>)(object)allMissionData3).AddRange((IEnumerable<>)enumerable2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A21")]
		[Cpp2IlInjected.Address(RVA = "0xF2E140", Offset = "0xF2CB40", VA = "0x180F2E140")]
		private void AddToMissionData(List<MissionItemData> missionsData, QuestLogListItemData.CategoryType category)
		{
			//Discarded unreachable code: IL_00c0
			//IL_0093: Expected O, but got I4
			Func<MissionItemData, bool> _003C_003E9__22_ = _003C_003Ec._003C_003E9__22_0;
			if (_003C_003E9__22_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionItemData missionsData) => missionsData != null);
			}
			IEnumerable<MissionItemData> enumerable = (IEnumerable<MissionItemData>)Enumerable.Where<MissionItemData>((IEnumerable<>)missionsData, (Func<, >)(object)_003C_003E9__22_);
			if (!Enumerable.Any<MissionItemData>((IEnumerable<>)enumerable))
			{
				return;
			}
			List<QuestLogListItemData> allMissionData = _allMissionData;
			Func<QuestLogListItemData, bool> func = (Func<QuestLogListItemData, bool>)(object)(Func<T, TResult>)delegate
			{
				QuestLogListItemData.CategoryType categoryType3 = category;
				bool result = default(bool);
				return result;
			};
			if (((IEnumerable<>)allMissionData).All<QuestLogListItemData>((Func<, >)(object)func))
			{
				List<QuestLogListItemData> allMissionData2 = _allMissionData;
				int num = 0;
				int num2 = 0;
				QuestLogListItemData.CategoryType categoryType = category;
			}
			List<QuestLogListItemData.CategoryType> hiddenCategories = _hiddenCategories;
			QuestLogListItemData.CategoryType categoryType2 = category;
			if (!((List<T>)(object)hiddenCategories).Contains((T)categoryType2))
			{
				List<QuestLogListItemData> allMissionData3 = _allMissionData;
				Func<MissionItemData, QuestLogListItemData> func2 = (Func<MissionItemData, QuestLogListItemData>)(object)(Func<T, TResult>)delegate(MissionItemData missionsData)
				{
					int num3 = 0;
					UnknownFieldSet unknownFields = missionsData._unknownFields;
					/*Error: Unexpected end of block*/;
				};
				IEnumerable<MissionItemData> enumerable2 = (IEnumerable<MissionItemData>)Enumerable.Select<MissionItemData, QuestLogListItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
				((List<T>)(object)allMissionData3).AddRange((IEnumerable<>)enumerable2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A22")]
		[Cpp2IlInjected.Address(RVA = "0xF2E4E0", Offset = "0xF2CEE0", VA = "0x180F2E4E0")]
		private QuestLogListItemData? GetCurrentSelectedItemData()
		{
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			int num2 = 0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A23")]
		[Cpp2IlInjected.Address(RVA = "0xF2E640", Offset = "0xF2D040", VA = "0x180F2E640")]
		private int GetMissionIndex(QuestLogListItemData? data)
		{
			//Discarded unreachable code: IL_0022
			List<QuestLogListItemData> allMissionData = _allMissionData;
			QuestLogListItemData? data2 = default(QuestLogListItemData?);
			Predicate<QuestLogListItemData> predicate = (Predicate<QuestLogListItemData>)(object)(Predicate<T>)delegate
			{
				int num = 0;
				QuestLogListItemData? questLogListItemData = data2;
				bool flag = default(bool);
				if (num == (flag ? 1 : 0))
				{
					int num2 = 0;
					/*Error: Unexpected end of block*/;
				}
				if (flag)
				{
				}
				if (flag)
				{
				}
				bool result = default(bool);
				return result;
			};
			return ((List<T>)(object)allMissionData).FindIndex((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A24")]
		[Cpp2IlInjected.Address(RVA = "0xF2F6A0", Offset = "0xF2E0A0", VA = "0x180F2F6A0")]
		public void OnQuestListItemData(ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A25")]
		[Cpp2IlInjected.Address(RVA = "0xF2F500", Offset = "0xF2DF00", VA = "0x180F2F500")]
		private void OnListItemHighlighted()
		{
			//Discarded unreachable code: IL_002a
			if (_controllerConnected)
			{
				LoopVerticalScrollRect missionScrollList = _missionScrollList;
				int selectedIndex = missionScrollList.SelectedIndex;
				missionScrollList.DeselectIndex(selectedIndex);
			}
			_missionScrollList.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A26")]
		[Cpp2IlInjected.Address(RVA = "0xF2F130", Offset = "0xF2DB30", VA = "0x180F2F130")]
		private void OnListItemClicked(QuestLogListItemData item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A27")]
		[Cpp2IlInjected.Address(RVA = "0xF2FAA0", Offset = "0xF2E4A0", VA = "0x180F2FAA0")]
		private void OnQuestListItemSelect(ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A28")]
		[Cpp2IlInjected.Address(RVA = "0xF2FCD0", Offset = "0xF2E6D0", VA = "0x180F2FCD0")]
		private void OnTrackedMissionChanged(Item missionItem)
		{
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			int trackedMission = Profile.TrackedMission;
			int num = 0;
			MissionSlot missionSlot = default(MissionSlot);
			if (missionSlot != null)
			{
				int missionId_ = missionSlot.missionId_;
			}
			LoopVerticalScrollRect missionScrollList = _missionScrollList;
			bool flag = trackedMission == num;
			if (num == (flag ? 1 : 0))
			{
				missionScrollList.RefreshCells();
				QuestLogDetails questDetails = _questDetails;
				int tracked = 0;
				questDetails.UpdateButtonLabel((byte)tracked != 0);
				return;
			}
			missionScrollList.RefreshCells();
			QuestLogDetails questDetails2 = _questDetails;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A29")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnShowCompletedValueChanged(bool isOn)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2A")]
		[Cpp2IlInjected.Address(RVA = "0xF2E890", Offset = "0xF2D290", VA = "0x180F2E890", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_003c
			base.OnControllerChanged();
			bool controllerConnected = _controllerConnected;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (_controllerConnected = instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				bool focus = !controllerConnected;
				SetFocus(focus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2B")]
		[Cpp2IlInjected.Address(RVA = "0xF31420", Offset = "0xF2FE20", VA = "0x180F31420")]
		private void SetFocus(bool onDataRefresh = false)
		{
			//Discarded unreachable code: IL_00d6
			//IL_0068: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_00aa: Expected O, but got I4
			//IL_00aa: Expected O, but got I4
			if (!onDataRefresh && (long)base.MenuNavigation.FocusNavigation._focusedElement != 0)
			{
				return;
			}
			int selectedIndex = _missionScrollList.SelectedIndex;
			LoopVerticalScrollRect missionScrollList = _missionScrollList;
			int selectedIndex2 = missionScrollList.SelectedIndex;
			int firstVisibleItemIndex = missionScrollList.GetFirstVisibleItemIndex();
			Transform itemByDataIndex = _missionScrollList.GetItemByDataIndex(firstVisibleItemIndex);
			if ((object)itemByDataIndex != null)
			{
				QuestLogListItem component = itemByDataIndex.GetComponent<QuestLogListItem>();
			}
			int num = 0;
			int num2 = 0;
			GameObject gameObject = default(GameObject);
			int num3 = default(int);
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2 && !gameObject.activeSelf)
			{
				LoopVerticalScrollRect missionScrollList2 = _missionScrollList;
				int index = firstVisibleItemIndex + 1;
				Transform itemByDataIndex2 = missionScrollList2.GetItemByDataIndex(index);
				if ((object)itemByDataIndex2 != null)
				{
					QuestLogListItem component2 = itemByDataIndex2.GetComponent<QuestLogListItem>();
				}
				num3 = 0;
			}
			int num4 = 0;
			GameObject gameObject2 = default(GameObject);
			if ((UnityEngine.Object)num3 != (UnityEngine.Object)num4 && gameObject2.activeSelf)
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				FocusNavigationElement component3 = GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2C")]
		[Cpp2IlInjected.Address(RVA = "0xF2E810", Offset = "0xF2D210", VA = "0x180F2E810")]
		private QuestLogListItemData.CategoryType MissionSlotClassToCategory(MissionSlotClass slotClass, MissionType missionType)
		{
			if (slotClass == MissionSlotClass.Story)
			{
				bool flag = missionType != MissionType.Realm;
			}
			if (slotClass == MissionSlotClass.Village)
			{
			}
			bool flag2 = slotClass == MissionSlotClass.Secret;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2D")]
		[Cpp2IlInjected.Address(RVA = "0xF2E8F0", Offset = "0xF2D2F0", VA = "0x180F2E8F0", Slot = "27")]
		public override void OnFocusIn()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2E")]
		[Cpp2IlInjected.Address(RVA = "0xF2E470", Offset = "0xF2CE70", VA = "0x180F2E470")]
		[IteratorStateMachine(typeof(_003CAdjustForSwitchAfterFrame_003Ed__35))]
		private IEnumerator AdjustForSwitchAfterFrame()
		{
			int _003C_003E1__state = default(int);
			_003CAdjustForSwitchAfterFrame_003Ed__35 _003CAdjustForSwitchAfterFrame_003Ed__ = new _003CAdjustForSwitchAfterFrame_003Ed__35(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAdjustForSwitchAfterFrame_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2F")]
		[Cpp2IlInjected.Address(RVA = "0xF2F020", Offset = "0xF2DA20", VA = "0x180F2F020", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0025
			_missionScrollList.ForceStopDrag();
			SystemRoot.Instance.GetSystem<AudioManager>().PopGameState();
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A30")]
		[Cpp2IlInjected.Address(RVA = "0xF2E740", Offset = "0xF2D140", VA = "0x180F2E740", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_003d
			if (redirectionType > RedirectionType.MainMenuGoToMap)
			{
				if (redirectionType == RedirectionType.GamePopCurrentMenu)
				{
					AK.Wwise.Event @event = closeSFX;
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
					PopSelf();
				}
			}
			else
			{
				while (redirectionType == RedirectionType.MenuQuestLogToggle)
				{
				}
				HandleMainMenuRedirection(redirectionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A31")]
		[Cpp2IlInjected.Address(RVA = "0xF2E840", Offset = "0xF2D240", VA = "0x180F2E840")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_001e
			AK.Wwise.Event @event = closeSFX;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A32")]
		[Cpp2IlInjected.Address(RVA = "0xF31B00", Offset = "0xF30500", VA = "0x180F31B00")]
		public QuestLogMenu()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
