using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200067F")]
	public class QuestLogDetails : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002468")]
		[SerializeField]
		private MenuNavigation _menuNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002469")]
		[SerializeField]
		private TextBase _characterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400246A")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400246B")]
		[SerializeField]
		private AsyncAtlassedIcon _characterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400246C")]
		[SerializeField]
		private TextBase _description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400246D")]
		[SerializeField]
		private RectTransform _taskListTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400246E")]
		[SerializeField]
		private QuestLogTask _taskPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400246F")]
		[SerializeField]
		private GameObject _rewardTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002470")]
		[SerializeField]
		private RectTransform _rewardListTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002471")]
		[SerializeField]
		private QuestLogReward _rewardPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002472")]
		[SerializeField]
		private RectTransform _hitbox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002473")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002474")]
		[SerializeField]
		private VerticalLayoutGroup _scrollContentLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002475")]
		[SerializeField]
		private RectTransform _footerTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002476")]
		[SerializeField]
		private Button _trackButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002477")]
		[SerializeField]
		private Image _trackButtonIcoUnTrack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002478")]
		[SerializeField]
		private Image _trackButtonIcoTrack;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002479")]
		[SerializeField]
		private Image _characterBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400247A")]
		[SerializeField]
		private AK.Wwise.Event _untrackSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400247B")]
		[SerializeField]
		private AK.Wwise.Event _trackSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400247C")]
		[SerializeField]
		private ShortcutIndicator _gamepadShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400247D")]
		[SerializeField]
		private ShortcutIndicator _keyboardShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400247E")]
		[SerializeField]
		private GameObject _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400247F")]
		public UnityEvent CurrentSelectedMissionChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002480")]
		private Dictionary<DescriptionInfo, List<DescriptionInfo>> _conditionObjectives;

		[Cpp2IlInjected.Token(Token = "0x4002481")]
		private static DescriptionInfo _categoryCharacterUnlockDesc;

		[Cpp2IlInjected.Token(Token = "0x4002482")]
		private static DescriptionInfo _categoryCharacterFriendshipDesc;

		[Cpp2IlInjected.Token(Token = "0x4002483")]
		private static DescriptionInfo _categoryMissionProgressionDesc;

		[Cpp2IlInjected.Token(Token = "0x4002484")]
		private static DescriptionInfo _categoryUnlockBuildingDesc;

		[Cpp2IlInjected.Token(Token = "0x4002485")]
		private static DescriptionInfo _categoryUnlockAreaDesc;

		[Cpp2IlInjected.Token(Token = "0x4002486")]
		private static DescriptionInfo _categoryUnlockToolDesc;

		[Cpp2IlInjected.Token(Token = "0x4002487")]
		private static DescriptionInfo _categoryPlayerLevelDesc;

		[Cpp2IlInjected.Token(Token = "0x4002488")]
		private static DescriptionInfo _categoryHiddenDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002489")]
		private MissionSlot _mission;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400248A")]
		private MissionItemData _missionItemData;

		[Cpp2IlInjected.Token(Token = "0x17000632")]
		public MissionSlot Mission
		{
			[Cpp2IlInjected.Token(Token = "0x60029EB")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get
			{
				return _mission;
			}
			[Cpp2IlInjected.Token(Token = "0x60029EC")]
			[Cpp2IlInjected.Address(RVA = "0xE2AC30", Offset = "0xE29630", VA = "0x180E2AC30")]
			private set
			{
				_mission = value;
				CurrentSelectedMissionChanged?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000633")]
		public MissionItemData MissionItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60029ED")]
			[Cpp2IlInjected.Address(RVA = "0xE2ABD0", Offset = "0xE295D0", VA = "0x180E2ABD0")]
			get
			{
				MissionSlot mission = _mission;
				if (mission == null)
				{
					return _missionItemData;
				}
				return mission.Data;
			}
			[Cpp2IlInjected.Token(Token = "0x60029EE")]
			[Cpp2IlInjected.Address(RVA = "0xE2ABF0", Offset = "0xE295F0", VA = "0x180E2ABF0")]
			private set
			{
				_missionItemData = value;
				CurrentSelectedMissionChanged?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029EF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void ApplySettings(RectOffset padding)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60029F0")]
		[Cpp2IlInjected.Address(RVA = "0xE26D50", Offset = "0xE25750", VA = "0x180E26D50")]
		private void Awake()
		{
			//IL_000d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_010b: Expected O, but got I4
			//IL_0117: Expected O, but got I4
			//IL_0117: Expected O, but got I4
			//IL_0117: Expected O, but got I4
			//IL_0135: Expected O, but got I4
			//IL_0141: Expected O, but got I4
			//IL_0141: Expected O, but got I4
			//IL_0141: Expected O, but got I4
			int num = 0;
			string text = LocalizationManager.FromStringID("menu.character_unlock", (IResolver)num);
			int num2 = 0;
			int num4 = default(int);
			int num3 = default(int);
			DescriptionInfo categoryCharacterUnlockDesc = new DescriptionInfo(text, (byte)num3 != 0, num4, (MissionObjective)num2, (Nullable<>)num2, (Nullable<>)num2);
			num4 = 0;
			num3 = 0;
			_categoryCharacterUnlockDesc = categoryCharacterUnlockDesc;
			int num5 = 0;
			int num7 = default(int);
			int num6 = default(int);
			DescriptionInfo categoryCharacterUnlockDesc2 = new DescriptionInfo(LocalizationManager.FromStringID("menu.levelup_friendships", (IResolver)num5), (byte)num6 != 0, num7, (MissionObjective)num2, (Nullable<>)num2, (Nullable<>)num2);
			num7 = 0;
			num6 = 0;
			_categoryCharacterUnlockDesc = categoryCharacterUnlockDesc2;
			int num8 = 0;
			int num10 = default(int);
			int num9 = default(int);
			DescriptionInfo categoryCharacterUnlockDesc3 = new DescriptionInfo(LocalizationManager.FromStringID("menu.progress_further", (IResolver)num8), (byte)num9 != 0, num10, (MissionObjective)num2, (Nullable<>)num2, (Nullable<>)num2);
			num10 = 0;
			num9 = 0;
			_categoryCharacterUnlockDesc = categoryCharacterUnlockDesc3;
			int num11 = 0;
			int num13 = default(int);
			int num12 = default(int);
			DescriptionInfo categoryCharacterUnlockDesc4 = new DescriptionInfo(LocalizationManager.FromStringID("menu.unlock_building_title", (IResolver)num11), (byte)num12 != 0, num13, (MissionObjective)num2, (Nullable<>)num2, (Nullable<>)num2);
			num13 = 0;
			num12 = 0;
			_categoryCharacterUnlockDesc = categoryCharacterUnlockDesc4;
			int num14 = 0;
			int num16 = default(int);
			int num15 = default(int);
			DescriptionInfo categoryCharacterUnlockDesc5 = new DescriptionInfo(LocalizationManager.FromStringID("menu.unlock_village_area", (IResolver)num14), (byte)num15 != 0, num16, (MissionObjective)num2, (Nullable<>)num2, (Nullable<>)num2);
			num16 = 0;
			num15 = 0;
			_categoryCharacterUnlockDesc = categoryCharacterUnlockDesc5;
			int num17 = 0;
			int num19 = default(int);
			int num18 = default(int);
			DescriptionInfo categoryCharacterUnlockDesc6 = new DescriptionInfo(LocalizationManager.FromStringID("menu.common_unlock", (IResolver)num17), (byte)num18 != 0, num19, (MissionObjective)num2, (Nullable<>)num2, (Nullable<>)num2);
			num19 = 0;
			num18 = 0;
			_categoryCharacterUnlockDesc = categoryCharacterUnlockDesc6;
			int num20 = 0;
			int num22 = default(int);
			int num21 = default(int);
			DescriptionInfo categoryCharacterUnlockDesc7 = new DescriptionInfo(LocalizationManager.FromStringID("menu.building_required_player_level", (IResolver)num20), (byte)num21 != 0, num22, (MissionObjective)num2, (Nullable<>)num2, (Nullable<>)num2);
			num22 = 0;
			num21 = 0;
			_categoryCharacterUnlockDesc = categoryCharacterUnlockDesc7;
			int num23 = 0;
			int num25 = default(int);
			int num24 = default(int);
			DescriptionInfo categoryCharacterUnlockDesc8 = new DescriptionInfo(LocalizationManager.FromStringID("menu.hidden_criteria", (IResolver)num23), (byte)num24 != 0, num25, (MissionObjective)num2, (Nullable<>)num2, (Nullable<>)num2);
			num25 = 0;
			num24 = 0;
			_categoryCharacterUnlockDesc = categoryCharacterUnlockDesc8;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60029F1")]
		[Cpp2IlInjected.Address(RVA = "0xE28650", Offset = "0xE27050", VA = "0x180E28650")]
		public void Refresh(MissionSlot mission, bool tracked)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60029F2")]
		[Cpp2IlInjected.Address(RVA = "0xE27900", Offset = "0xE26300", VA = "0x180E27900")]
		[IteratorStateMachine(typeof(_003CRebuildLayoutCoroutine_003Ed__44))]
		private IEnumerator RebuildLayoutCoroutine(RectTransform rect)
		{
			int _003C_003E1__state = default(int);
			_003CRebuildLayoutCoroutine_003Ed__44 _003CRebuildLayoutCoroutine_003Ed__ = new _003CRebuildLayoutCoroutine_003Ed__44(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRebuildLayoutCoroutine_003Ed__.rect = rect;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029F3")]
		[Cpp2IlInjected.Address(RVA = "0xE27970", Offset = "0xE26370", VA = "0x180E27970")]
		public void Refresh(MissionItemData mission, bool tracked)
		{
			//Discarded unreachable code: IL_00f9, IL_0136, IL_0143, IL_0150, IL_0169, IL_0194, IL_01a1, IL_01ae, IL_01bb, IL_01c8, IL_01d5, IL_01e2, IL_01ef, IL_0204, IL_022c, IL_0254, IL_0259, IL_0274, IL_0279, IL_0298, IL_02a9, IL_02ae, IL_02bd, IL_02d0, IL_02d6, IL_02dc, IL_02e2
			//IL_0019: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			int num = 0;
			if (mission == null)
			{
				return;
			}
			if ((IntPtr)_mission != (IntPtr)num)
			{
				_mission = (MissionSlot)num;
				CurrentSelectedMissionChanged?.Invoke();
			}
			if (_missionItemData != mission)
			{
				_missionItemData = mission;
				CurrentSelectedMissionChanged?.Invoke();
			}
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			int num2 = default(int);
			if (!mission.unlockConditions_.Evaluate(profile, _003CTransactionContext_003Ek__BackingField))
			{
				num2 = 0;
			}
			bool flag = mission.availableConditions_.Evaluate(profile, (ITransactionContext)num2);
			TextBase title = _title;
			int num3 = 0;
			if (!flag)
			{
			}
			string text2 = (title.Text = LocalizationManager.FromStringID("menu.next_mission_not_available", (IResolver)num3));
			if (flag)
			{
				int ownerCharacter = mission.OwnerCharacter;
				text2 = "menu.next_mission_available_desc_male";
				CharacterItemData characterItemData = default(CharacterItemData);
				if ((characterItemData.isFemale_ ? 1 : 0) != num)
				{
					text2 = "menu.next_mission_available_desc_female";
				}
			}
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int ownerCharacter2 = mission.OwnerCharacter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029F4")]
		[Cpp2IlInjected.Address(RVA = "0xE29130", Offset = "0xE27B30", VA = "0x180E29130")]
		private void ResolveConditions(RepeatedField<ConditionOneOf> conditions)
		{
			//Discarded unreachable code: IL_0097, IL_00b4, IL_00e0, IL_00e5, IL_00ee, IL_00f6, IL_0103, IL_0111, IL_0116, IL_011b, IL_0124, IL_0129, IL_0139, IL_013e, IL_0143, IL_015c, IL_018c, IL_019b, IL_01de, IL_01e7, IL_01f2, IL_021e, IL_0226
			//IL_024f: Expected O, but got I4
			bool flag = default(bool);
			do
			{
				int num = 0;
				int num2 = 0;
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
				Client metaClient = SystemRoot.Instance.MetaClient;
			}
			while (!flag);
			Item invalid = Item.Invalid;
			ConditionMissionStepCompleted conditionMissionStepCompleted = default(ConditionMissionStepCompleted);
			Item missionItem = conditionMissionStepCompleted.MissionItem;
			MissionItemData missionItemData = default(MissionItemData);
			int ownerCharacter_ = missionItemData.ownerCharacter_;
			ConditionMissionObjectiveCompleted conditionMissionObjectiveCompleted = default(ConditionMissionObjectiveCompleted);
			Item missionItem2 = conditionMissionObjectiveCompleted.MissionItem;
			MissionItemData missionItemData2 = default(MissionItemData);
			int ownerCharacter_2 = missionItemData2.ownerCharacter_;
			ConditionMissionObjectiveStatus conditionMissionObjectiveStatus = default(ConditionMissionObjectiveStatus);
			Item missionItem3 = conditionMissionObjectiveStatus.MissionItem;
			MissionItemData missionItemData3 = default(MissionItemData);
			int ownerCharacter_3 = missionItemData3.ownerCharacter_;
			Dictionary<DescriptionInfo, List<DescriptionInfo>> conditionObjectives = _conditionObjectives;
			List<DescriptionInfo> list = (List<DescriptionInfo>)(object)new List<T>();
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			ConditionPlayerLevel conditionPlayerLevel = default(ConditionPlayerLevel);
			int playerLevel_ = conditionPlayerLevel.playerLevel_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029F5")]
		[Cpp2IlInjected.Address(RVA = "0xE27240", Offset = "0xE25C40", VA = "0x180E27240")]
		private void ClearList(RectTransform list)
		{
			//Discarded unreachable code: IL_0022, IL_0034
			IEnumerator enumerator = list.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			if ((object)gameObject == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029F6")]
		[Cpp2IlInjected.Address(RVA = "0xE27410", Offset = "0xE25E10", VA = "0x180E27410")]
		public void OnClick()
		{
			//Discarded unreachable code: IL_00d8
			int num = 0;
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int num3 = 0;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && _menuNavigation.FocusNavigation._focusedElement != null)
			{
				int num4 = 0;
				int num5 = 0;
				bool flag = default(bool);
				if (flag)
				{
					return;
				}
			}
			MissionSlot mission = _mission;
			if (mission != null)
			{
				int missionId_ = mission.missionId_;
				if (SystemRoot.Instance.MetaClient.profile.TrackedMission == missionId_)
				{
				}
				AK.Wwise.Event trackSfx = _trackSfx;
				if (trackSfx != null)
				{
					GameObject gameObject = _trackButton.gameObject;
					uint num6 = trackSfx.Post(gameObject);
				}
				if (SystemRoot.Instance.MetaClient.profile.TrackedMission != missionId_)
				{
				}
				int num7 = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				int num8 = 0;
				IMenu top = menuStack.Top;
				int num9 = 0;
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029F7")]
		[Cpp2IlInjected.Address(RVA = "0xE27120", Offset = "0xE25B20", VA = "0x180E27120")]
		[AsyncStateMachine(typeof(_003CChangeTrackingMissionTask_003Ed__49))]
		private Task ChangeTrackingMissionTask(MissionSlot mission, CancellationToken cancellationToken)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029F8")]
		[Cpp2IlInjected.Address(RVA = "0xE2AB40", Offset = "0xE29540", VA = "0x180E2AB40")]
		private void UpdateNavigation(bool trackEnabled)
		{
			//Discarded unreachable code: IL_0017
			Button trackButton = _trackButton;
			bool flag = default(bool);
			if (flag)
			{
			}
			_menuNavigation.UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x60029F9")]
		[Cpp2IlInjected.Address(RVA = "0xE2A9E0", Offset = "0xE293E0", VA = "0x180E2A9E0")]
		public void UpdateButtonLabel(bool tracked)
		{
			//Discarded unreachable code: IL_0063
			_trackButtonIcoTrack.gameObject.SetActive(tracked);
			_trackButtonIcoUnTrack.gameObject.SetActive(tracked);
			Button trackButton = _trackButton;
			if (tracked)
			{
				trackButton.gameObject.GetComponent<ButtonTmProIcon>().Label.StringID = "menu.quest_untrack";
			}
			else
			{
				trackButton.gameObject.GetComponent<ButtonTmProIcon>().Label.StringID = "menu.quest_track";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029FA")]
		[Cpp2IlInjected.Address(RVA = "0xE2A960", Offset = "0xE29360", VA = "0x180E2A960")]
		internal void Show(bool visible)
		{
			//Discarded unreachable code: IL_002f
			_content.SetActive(visible);
			_scrollRect.gameObject.SetActive(visible);
			_footerTransform.gameObject.SetActive(visible);
		}

		[Cpp2IlInjected.Token(Token = "0x60029FB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public QuestLogDetails()
		{
		}
	}
}
