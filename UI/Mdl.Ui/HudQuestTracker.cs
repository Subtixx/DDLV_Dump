using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using DG.Tweening;
using Gameloft.Common;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;
using Mdl.Missions;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000564")]
	public class HudQuestTracker : MonoBehaviour, IHasSFX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D56")]
		public float NewQuestExposureDuration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D57")]
		private MissionSlot _missionSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D58")]
		private List<DescriptionInfo> _currentAllObjectives;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D59")]
		private Queue<(List<DescriptionInfo>, List<DescriptionInfo>)> _animQueue = (Queue<(List<DescriptionInfo>, List<DescriptionInfo>)>)(object)new Queue<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D5A")]
		[SerializeField]
		private QuestBanner _questBanner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001D5B")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001D5C")]
		[SerializeField]
		private RectTransform _bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001D5D")]
		[SerializeField]
		private RectTransform _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001D5E")]
		[SerializeField]
		private RectTransform _secondaryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001D5F")]
		[SerializeField]
		private CustomElement _currentQuest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001D60")]
		[SerializeField]
		private CustomElement _newQuest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001D61")]
		[SerializeField]
		private TextBase _newQuestLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001D62")]
		[SerializeField]
		private RectTransform _newQuestDeco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001D63")]
		[SerializeField]
		private RectTransform _questProgressDeco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001D64")]
		[SerializeField]
		private Image _newQuestPortraitBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001D65")]
		[SerializeField]
		private Image _newQuestLabelBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001D66")]
		[SerializeField]
		private RectTransform _sparkleContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001D67")]
		[SerializeField]
		private float _sparkleContainerOriginalSize = 306f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001D68")]
		[SerializeField]
		private RectTransform _newLabelContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001D69")]
		[SerializeField]
		private AK.Wwise.Event _newLabelSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001D6A")]
		private (List<DescriptionInfo>, List<DescriptionInfo>) _currentPair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001D6B")]
		private HashSet<DescriptionInfo> _completedObjectives = (HashSet<DescriptionInfo>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001D6C")]
		private bool _isPlayingAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4001D6D")]
		private bool _shouldCheckIfObjectiveComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD2")]
		[Cpp2IlInjected.Token(Token = "0x4001D6E")]
		private bool _isPlayingSwitchObjectiveAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001D6F")]
		private Coroutine _animationCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001D70")]
		private Coroutine _switchAnimationCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001D71")]
		private Coroutine _refreshBgCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001D72")]
		private Coroutine _hideNewQuestCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001D73")]
		private Coroutine _newQuestShowCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001D74")]
		private int _currentMissionStepIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4001D75")]
		[SerializeField]
		[Header("Fill the field below to adjust size for Switch")]
		private int _switchFontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001D76")]
		[Space]
		public AK.Wwise.Event[] SFXS;

		[Cpp2IlInjected.Token(Token = "0x17000571")]
		private MissionManager _missionManager
		{
			[Cpp2IlInjected.Token(Token = "0x6002333")]
			[Cpp2IlInjected.Address(RVA = "0x130F6D0", Offset = "0x130E0D0", VA = "0x18130F6D0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					return _003CInstance_003Ek__BackingField.GetSystem<MissionManager>();
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000572")]
		public bool IsPlayingAnim
		{
			[Cpp2IlInjected.Token(Token = "0x6002334")]
			[Cpp2IlInjected.Address(RVA = "0xAFC360", Offset = "0xAFAD60", VA = "0x180AFC360")]
			get
			{
				return _isPlayingAnim;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000573")]
		[HideInInspector]
		public bool AdjustForSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6002335")]
			[Cpp2IlInjected.Address(RVA = "0x130F6B0", Offset = "0x130E0B0", VA = "0x18130F6B0")]
			get
			{
				return _switchFontSize != -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000574")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x110"), Cpp2IlInjected.Token(Token = "0x4001D77")]
		public bool IsMuted
		{
			[Cpp2IlInjected.Token(Token = "0x6002336")]
			[Cpp2IlInjected.Address(RVA = "0x130F6C0", Offset = "0x130E0C0", VA = "0x18130F6C0", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002337")]
			[Cpp2IlInjected.Address(RVA = "0x130F790", Offset = "0x130E190", VA = "0x18130F790", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002338")]
		[Cpp2IlInjected.Address(RVA = "0x130ED90", Offset = "0x130D790", VA = "0x18130ED90")]
		public void Show()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002339")]
		[Cpp2IlInjected.Address(RVA = "0x130B930", Offset = "0x130A330", VA = "0x18130B930")]
		private void OnEnable()
		{
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			if ((long)_missionSlot == 0)
			{
				ProfileWorld world_ = profile.world_;
				Item trackedMissionItem = profile.TrackedMissionItem;
				MissionSlot missionSlot = default(MissionSlot);
				_missionSlot = missionSlot;
			}
			if (profile.player_.HasHudApparition(2u) && SystemRoot.Instance.GetSystem<MissionManager>()._isInit)
			{
				MissionSlot missionSlot2 = _missionSlot;
				if (missionSlot2 != null)
				{
					int num = (_currentMissionStepIndex = missionSlot2.currentStepIndex_);
					List<DescriptionInfo> currentAllObjectives = default(List<DescriptionInfo>);
					_currentAllObjectives = currentAllObjectives;
					SetCurrentQuestTitleAndImage();
				}
				_content.gameObject.SetActive(value: true);
				Show();
				if (_newQuest.gameObject.activeInHierarchy)
				{
					CustomeElementModel _003CModel_003Ek__BackingField = _newQuest.Model;
					if (_003CModel_003Ek__BackingField != null)
					{
						int num2 = 0;
						if (_003CModel_003Ek__BackingField == null)
						{
						}
					}
				}
			}
			int _003C_003E1__state = default(int);
			_003CRefreshBgAfterFrame_003Ed__64 _003CRefreshBgAfterFrame_003Ed__ = new _003CRefreshBgAfterFrame_003Ed__64(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshBgAfterFrame_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_refreshBgCoroutine = StartCoroutine(_003CRefreshBgAfterFrame_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600233A")]
		[Cpp2IlInjected.Address(RVA = "0x130B3F0", Offset = "0x1309DF0", VA = "0x18130B3F0")]
		public void OnDisable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600233B")]
		[Cpp2IlInjected.Address(RVA = "0x130ACE0", Offset = "0x13096E0", VA = "0x18130ACE0")]
		private void KillAllAnimation()
		{
			//Discarded unreachable code: IL_0088
			//IL_0046: Expected O, but got I4
			RectTransform sparkleContainer = _sparkleContainer;
			int complete = 0;
			int num = DOTween.Kill(sparkleContainer, (byte)complete != 0);
			RectTransform bg = _bg;
			int complete2 = 0;
			int num2 = DOTween.Kill(bg, (byte)complete2 != 0);
			Transform transform = _newLabelContainer.transform;
			int num3 = 0;
			if ((object)transform != null)
			{
			}
			int complete3 = 0;
			int num4 = DOTween.Kill(num3, (byte)complete3 != 0);
			Coroutine switchAnimationCoroutine = _switchAnimationCoroutine;
			if (switchAnimationCoroutine != null)
			{
				StopCoroutine(switchAnimationCoroutine);
			}
			Coroutine animationCoroutine = _animationCoroutine;
			if (animationCoroutine != null)
			{
				StopCoroutine(animationCoroutine);
			}
			Coroutine refreshBgCoroutine = _refreshBgCoroutine;
			if (refreshBgCoroutine != null)
			{
				StopCoroutine(refreshBgCoroutine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600233C")]
		[Cpp2IlInjected.Address(RVA = "0x130EED0", Offset = "0x130D8D0", VA = "0x18130EED0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0140
			//IL_0030: Expected O, but got I4
			QuestBanner questBanner = _questBanner;
			Action<MissionSlot> action = (Action<MissionSlot>)(object)new Action<T>(HandleQuestStartedBannerAnimEnd);
			Delegate @delegate = Delegate.Combine(action, action);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				questBanner.OnQuestStartedAnim = (Action<MissionSlot>)num;
				QuestBanner questBanner2 = _questBanner;
				Action<MissionSlot> onQuestTrack = questBanner2.OnQuestTrack;
				Action<MissionSlot> b = (Action<MissionSlot>)(object)new Action<T>(HandleQuestTrack);
				Delegate delegate2 = Delegate.Combine(onQuestTrack, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					questBanner2.OnQuestTrack = (Action<MissionSlot>)delegate2;
					SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
					if ((object)_003CInstance_003Ek__BackingField != null)
					{
						Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
						if (metaClient != null && (long)metaClient.Dispatcher != 0)
						{
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
							ProfileEventDispatcher.MissionStepProgress value = OnMissionStepProgress;
							_003CDispatcher_003Ek__BackingField.OnMissionStepProgress += value;
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
							ProfileEventDispatcher.MissionStepStatusChanged value2 = OnMissionStepStatusChanged;
							_003CDispatcher_003Ek__BackingField2.OnMissionStepStatusChanged += value2;
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
							ProfileEventDispatcher.MissionSlotUpdated value3 = OnMissionSlotUpdated;
							_003CDispatcher_003Ek__BackingField3.OnMissionSlotUpdated += value3;
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
							ProfileEventDispatcher.TrackedMissionChanged value4 = OnTrackedMissionChanged;
							_003CDispatcher_003Ek__BackingField4.OnTrackedMissionChanged += value4;
						}
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600233D")]
		[Cpp2IlInjected.Address(RVA = "0x130AEA0", Offset = "0x13098A0", VA = "0x18130AEA0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0140
			//IL_0030: Expected O, but got I4
			QuestBanner questBanner = _questBanner;
			Action<MissionSlot> action = (Action<MissionSlot>)(object)new Action<T>(HandleQuestStartedBannerAnimEnd);
			Delegate @delegate = Delegate.Remove(action, action);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				questBanner.OnQuestStartedAnim = (Action<MissionSlot>)num;
				QuestBanner questBanner2 = _questBanner;
				Action<MissionSlot> onQuestTrack = questBanner2.OnQuestTrack;
				Action<MissionSlot> value = (Action<MissionSlot>)(object)new Action<T>(HandleQuestTrack);
				Delegate delegate2 = Delegate.Remove(onQuestTrack, value);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					questBanner2.OnQuestTrack = (Action<MissionSlot>)delegate2;
					SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
					if ((object)_003CInstance_003Ek__BackingField != null)
					{
						Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
						if (metaClient != null && (long)metaClient.Dispatcher != 0)
						{
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
							ProfileEventDispatcher.MissionStepProgress value2 = OnMissionStepProgress;
							_003CDispatcher_003Ek__BackingField.OnMissionStepProgress -= value2;
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
							ProfileEventDispatcher.MissionStepStatusChanged value3 = OnMissionStepStatusChanged;
							_003CDispatcher_003Ek__BackingField2.OnMissionStepStatusChanged -= value3;
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
							ProfileEventDispatcher.MissionSlotUpdated value4 = OnMissionSlotUpdated;
							_003CDispatcher_003Ek__BackingField3.OnMissionSlotUpdated -= value4;
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
							ProfileEventDispatcher.TrackedMissionChanged value5 = OnTrackedMissionChanged;
							_003CDispatcher_003Ek__BackingField4.OnTrackedMissionChanged -= value5;
						}
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600233E")]
		[Cpp2IlInjected.Address(RVA = "0x130ACA0", Offset = "0x13096A0", VA = "0x18130ACA0")]
		private void HandleQuestStartedBannerAnimEnd(MissionSlot missionSlot)
		{
			ShowNewQuestDisplay(missionSlot, isNewMission: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600233F")]
		[Cpp2IlInjected.Address(RVA = "0x130ACB0", Offset = "0x13096B0", VA = "0x18130ACB0")]
		private void HandleQuestTrack(MissionSlot missionSlot)
		{
			ShowNewQuestDisplay(missionSlot, isNewMission: true);
			OnTrackClicked();
		}

		[Cpp2IlInjected.Token(Token = "0x6002340")]
		[Cpp2IlInjected.Address(RVA = "0x130C880", Offset = "0x130B280", VA = "0x18130C880")]
		private void OnMissionStepProgress(MissionSlotClass slotClass, int slotId)
		{
			int isNewMission = 0;
			OnMissionChanged(slotClass, slotId, (byte)isNewMission != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002341")]
		[Cpp2IlInjected.Address(RVA = "0x130C8A0", Offset = "0x130B2A0", VA = "0x18130C8A0")]
		private void OnMissionStepStatusChanged(MissionSlotClass slotClass, int slotId, int stepIndex, MissionStepStatus previousStatus, MissionStepStatus newStatus)
		{
			//Discarded unreachable code: IL_000c, IL_000d
			int isNewMission = 0;
			OnMissionChanged(slotClass, slotId, (byte)isNewMission != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002342")]
		[Cpp2IlInjected.Address(RVA = "0x130C7B0", Offset = "0x130B1B0", VA = "0x18130C7B0")]
		private void OnMissionSlotUpdated(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason, [Optional] List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_0008
			QuestBanner questBanner = _questBanner;
		}

		[Cpp2IlInjected.Token(Token = "0x6002343")]
		[Cpp2IlInjected.Address(RVA = "0x130BD10", Offset = "0x130A710", VA = "0x18130BD10")]
		private void OnMissionChanged(MissionSlotClass slotClass, int slotId, bool isNewMission = false)
		{
			//IL_0176: Expected O, but got I4
			//IL_0232: Expected O, but got I4
			//IL_0232: Expected O, but got I4
			Client client = default(Client);
			MissionSlot missionSlot = default(MissionSlot);
			Client client2 = default(Client);
			Func<MissionSlot, bool> func = default(Func<MissionSlot, bool>);
			List<DescriptionInfo> currentAllObjectives = default(List<DescriptionInfo>);
			bool flag3 = default(bool);
			int num9 = default(int);
			IMenu top2 = default(IMenu);
			int _003C_003E1__state = default(int);
			List<DescriptionInfo> list2 = default(List<DescriptionInfo>);
			int _003C_003E1__state2 = default(int);
			while (base.gameObject.activeInHierarchy)
			{
				int num = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				int num2 = 0;
				IMenu top = menuStack.Top;
				if (top == null)
				{
					break;
				}
				int num3 = 0;
				int num4 = 0;
				if (top == null)
				{
					break;
				}
				if ((_isPlayingAnim ? 1 : 0) != num4)
				{
					return;
				}
				ProfileWorld world_ = client.profile.world_;
				if (missionSlot != null)
				{
					int slotId_ = missionSlot.slotId_;
				}
				MissionSlot missionSlot2 = _missionSlot;
				if (missionSlot2 != null)
				{
					int slotId_2 = missionSlot2.slotId_;
				}
				bool flag = num4 == num4;
				if (num4 == num4 == flag)
				{
				}
				if (missionSlot != null)
				{
					MissionSlotClass class_ = missionSlot.class_;
				}
				MissionSlot missionSlot3 = _missionSlot;
				if (missionSlot3 != null)
				{
					MissionSlotClass class_2 = missionSlot3.class_;
				}
				bool flag2 = num4 == num4;
				MissionSlot missionSlot4 = _missionSlot;
				if (missionSlot4 == null)
				{
				}
				if (missionSlot != null != flag2)
				{
					int num5 = 0;
					if (missionSlot4 != null)
					{
						MissionSlotState state_ = missionSlot4.state_;
						if (state_ > MissionSlotState.Available && state_ <= MissionSlotState.Completed)
						{
							continue;
						}
						ProfileWorld world_2 = client2.profile.world_;
						if (_003C_003Ec._003C_003E9__54_0 == null)
						{
							func = (Func<MissionSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot x) => x.IsMissionStarted));
						}
						MissionSlot missionSlot5 = (_missionSlot = Enumerable.FirstOrDefault<MissionSlot>(world_2.GetValidMissionSlot((Func<, >)(object)func)));
						if ((IntPtr)_missionSlot != (IntPtr)num4)
						{
							int num6 = 0;
							SetCurrentQuestTitleAndImage();
							MissionSlot missionSlot6 = _missionSlot;
							int num7 = (_currentMissionStepIndex = missionSlot6.currentStepIndex_);
							int num8 = 0;
							List<DescriptionInfo> list = (_currentAllObjectives = (List<DescriptionInfo>)(object)missionSlot6.GetCurrentDescriptions((Localizator)num6, (byte)num8 != 0));
							currentAllObjectives = _currentAllObjectives;
						}
						((HashSet<T>)(object)_completedObjectives).Clear();
						((Queue<T>)(object)_animQueue).Clear();
						if (_missionSlot != null)
						{
							if (currentAllObjectives != null)
							{
								int childCount = _items.childCount;
								if (num4 < childCount)
								{
									HudQuestObjective component = _items.GetChild(num4).GetComponent<HudQuestObjective>();
									_isPlayingAnim = true;
									if (component.state == HudQuestObjective.State.PlayingAnim || (component.HasObjective ? 1 : 0) == num4)
									{
										goto IL_0237;
									}
									HashSet<DescriptionInfo> completedObjectives = _completedObjectives;
									if (!flag3)
									{
										HashSet<DescriptionInfo> completedObjectives2 = _completedObjectives;
									}
									component.PlayCompleteAnimation();
									num4++;
								}
								int childCount2 = _items.childCount;
								Debug.LogError($"HudQuestTracker: Was expecting more child (i={num9}, ChildCount={childCount2})");
							}
							goto IL_0237;
						}
					}
					goto IL_02a0;
				}
				goto IL_02b0;
				IL_0237:
				num4++;
				if (base.gameObject.activeInHierarchy)
				{
					int num10 = 0;
					MenuStack menuStack2 = UiRoot.Instance._menuStack;
					int num11 = 0;
					top2 = menuStack2.Top;
					if (top2 != null)
					{
						int num12 = 0;
						if (top2 != null)
						{
							_003CRefreshDelay_003Ed__57 _003CRefreshDelay_003Ed__ = new _003CRefreshDelay_003Ed__57(_003C_003E1__state);
							_003C_003E1__state = 0;
							_003CRefreshDelay_003Ed__._003C_003E4__this = this;
							Coroutine coroutine = (_animationCoroutine = StartCoroutine(_003CRefreshDelay_003Ed__));
						}
					}
				}
				_shouldCheckIfObjectiveComplete = true;
				goto IL_02a0;
				IL_02a0:
				if ((IntPtr)(_isPlayingSwitchObjectiveAnim ? 1 : 0) == (IntPtr)top2)
				{
					Show();
				}
				goto IL_02b0;
				IL_02b0:
				if (missionSlot != null && !flag2 && missionSlot.state_ > MissionSlotState.Available && Enumerable.Any<DescriptionInfo>((IEnumerable<>)list2))
				{
					Coroutine newQuestShowCoroutine = _newQuestShowCoroutine;
					if (newQuestShowCoroutine != null)
					{
						StopCoroutine(newQuestShowCoroutine);
					}
					_003CTryShowNewQuestDisplay_003Ed__55 _003CTryShowNewQuestDisplay_003Ed__ = new _003CTryShowNewQuestDisplay_003Ed__55(_003C_003E1__state2);
					_003C_003E1__state2 = 0;
					_003CTryShowNewQuestDisplay_003Ed__._003C_003E4__this = this;
					_003CTryShowNewQuestDisplay_003Ed__.missionSlot = missionSlot;
					_003CTryShowNewQuestDisplay_003Ed__.isNewMission = false;
					Coroutine coroutine2 = (_newQuestShowCoroutine = StartCoroutine(_003CTryShowNewQuestDisplay_003Ed__));
				}
				return;
			}
			_shouldCheckIfObjectiveComplete = true;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002344")]
		[Cpp2IlInjected.Address(RVA = "0x130F500", Offset = "0x130DF00", VA = "0x18130F500")]
		[IteratorStateMachine(typeof(_003CTryShowNewQuestDisplay_003Ed__55))]
		private IEnumerator TryShowNewQuestDisplay(MissionSlot missionSlot, bool isNewMission)
		{
			int _003C_003E1__state = default(int);
			_003CTryShowNewQuestDisplay_003Ed__55 _003CTryShowNewQuestDisplay_003Ed__ = new _003CTryShowNewQuestDisplay_003Ed__55(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTryShowNewQuestDisplay_003Ed__._003C_003E4__this = this;
			_003CTryShowNewQuestDisplay_003Ed__.missionSlot = missionSlot;
			_003CTryShowNewQuestDisplay_003Ed__.isNewMission = isNewMission;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002345")]
		[Cpp2IlInjected.Address(RVA = "0x130EB80", Offset = "0x130D580", VA = "0x18130EB80")]
		public void ShowNewQuestDisplay(MissionSlot missionSlot, bool isNewMission)
		{
			int num = 0;
			if (missionSlot != null)
			{
				int slotId_ = missionSlot.slotId_;
			}
			MissionSlot missionSlot2 = _missionSlot;
			if (missionSlot2 != null)
			{
				int slotId_2 = missionSlot2.slotId_;
			}
			bool flag = num == num;
			if (num == num != flag)
			{
				if (missionSlot != null)
				{
					MissionSlotClass class_ = missionSlot.class_;
				}
				MissionSlot missionSlot3 = _missionSlot;
				if (missionSlot3 != null)
				{
					MissionSlotClass class_2 = missionSlot3.class_;
				}
				if (num != 0)
				{
					return;
				}
			}
			RefreshNewQuestDisplay(missionSlot, isNewMission);
			Coroutine hideNewQuestCoroutine = _hideNewQuestCoroutine;
			if (hideNewQuestCoroutine != null)
			{
				Coroutines.Stop(hideNewQuestCoroutine);
			}
			Action action = delegate
			{
				//Discarded unreachable code: IL_0016
				GameObject gameObject = _newQuest.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			};
			float newQuestExposureDuration = NewQuestExposureDuration;
			Coroutine coroutine = (_hideNewQuestCoroutine = Coroutines.Delay(action, newQuestExposureDuration));
		}

		[Cpp2IlInjected.Token(Token = "0x6002346")]
		[Cpp2IlInjected.Address(RVA = "0x130DCF0", Offset = "0x130C6F0", VA = "0x18130DCF0")]
		[IteratorStateMachine(typeof(_003CRefreshDelay_003Ed__57))]
		private IEnumerator RefreshDelay()
		{
			int _003C_003E1__state = default(int);
			_003CRefreshDelay_003Ed__57 _003CRefreshDelay_003Ed__ = new _003CRefreshDelay_003Ed__57(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002347")]
		[Cpp2IlInjected.Address(RVA = "0x130ABD0", Offset = "0x13095D0", VA = "0x18130ABD0")]
		private Task ChangeTrackingMissionTask(MissionSlot missionSlot)
		{
			//IL_001c: Expected O, but got I4
			Client metaClient = SystemRoot.Instance.MetaClient;
			int missionId_ = missionSlot.missionId_;
			int num = 0;
			Task<TrackMission.Types.Response> task = (Task<TrackMission.Types.Response>)(object)metaClient.TrackMissionAsync(missionId_, (CancellationToken)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002348")]
		[Cpp2IlInjected.Address(RVA = "0x130D060", Offset = "0x130BA60", VA = "0x18130D060")]
		public void RefreshCurrentQuestDisplay(bool justTracked = false)
		{
			//Discarded unreachable code: IL_03cf, IL_03d5, IL_03db, IL_03e1, IL_03e7, IL_03ed, IL_03f3, IL_03f9, IL_03ff, IL_0405, IL_040b, IL_0411, IL_0417
			//IL_00ca: Expected O, but got I4
			//IL_015c: Expected O, but got I4
			//IL_0318: Expected I4, but got I8
			//IL_0351: Expected I4, but got I8
			//IL_0368: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			MissionSlot missionSlot = _missionSlot;
			if (missionSlot != null)
			{
				MissionSlotState state_ = missionSlot.state_;
				if (state_ <= MissionSlotState.Available || state_ > MissionSlotState.Completed)
				{
					QuestBanner questBanner = _questBanner;
					MissionItemData data = missionSlot.Data;
					questBanner.SetupAndShowQuestCompleted(data);
					ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
					Func<MissionSlot, bool> _003C_003E9__59_ = _003C_003Ec._003C_003E9__59_0;
					if (_003C_003E9__59_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot x) => x.IsMissionStarted);
					}
					MissionSlot missionSlot2 = (_missionSlot = Enumerable.FirstOrDefault<MissionSlot>(world_.GetValidMissionSlot((Func<, >)(object)_003C_003E9__59_)));
					if ((IntPtr)_missionSlot != (IntPtr)num3)
					{
						int num4 = 0;
						SetCurrentQuestTitleAndImage();
						MissionSlot missionSlot3 = _missionSlot;
						int num5 = (_currentMissionStepIndex = missionSlot3.currentStepIndex_);
						int num6 = 0;
						List<DescriptionInfo> list = (_currentAllObjectives = (List<DescriptionInfo>)(object)missionSlot3.GetCurrentDescriptions((Localizator)num4, (byte)num6 != 0));
					}
					((HashSet<T>)(object)_completedObjectives).Clear();
					((Queue<T>)(object)_animQueue).Clear();
				}
			}
			HudQuestObjective component3 = default(HudQuestObjective);
			if (missionSlot != null && missionSlot.IsValid)
			{
				int num7 = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				int num8 = 0;
				IMenu top = menuStack.Top;
				if (top != null)
				{
					int num9 = 0;
					if (top != null)
					{
						MissionSlot missionSlot4 = _missionSlot;
						int num10 = 0;
						if (!missionSlot4.OwnerInactive)
						{
							MissionSlot missionSlot5 = _missionSlot;
							int num11 = 0;
							if (Enumerable.Any<DescriptionInfo>((IEnumerable<>)missionSlot5.GetCurrentDescriptions((Localizator)num10, (byte)num11 != 0)))
							{
								MissionSlot missionSlot6 = _missionSlot;
								List<DescriptionInfo> list2 = default(List<DescriptionInfo>);
								if (!justTracked && (IntPtr)_currentAllObjectives != (IntPtr)num3)
								{
									int size = ((List<>)(object)list2)._size;
									if (num3 < size)
									{
										int num12 = 0;
										System.ThrowHelper.ThrowArgumentOutOfRangeException();
										num3++;
										uint num13 = num13 + 8;
										if (_currentMissionStepIndex == -1)
										{
										}
										MissionSlot missionSlot7 = _missionSlot;
									}
								}
								SetCurrentQuestTitleAndImage();
								if (_newQuest.gameObject.activeSelf)
								{
									CustomElement newQuest = _newQuest;
									CustomeElementModel _003CModel_003Ek__BackingField = newQuest.Model;
									if (_003CModel_003Ek__BackingField != null)
									{
										int num14 = 0;
										if (_003CModel_003Ek__BackingField != null && _003CModel_003Ek__BackingField == _missionSlot)
										{
											GameObject gameObject = newQuest.gameObject;
											int active = 0;
											gameObject.SetActive((byte)active != 0);
										}
									}
								}
								uint num15 = default(uint);
								if (num15 == 0)
								{
									_currentAllObjectives = list2;
									int childCount = _items.childCount;
									if (_secondaryList.childCount > 0)
									{
										RectTransform secondaryList = _secondaryList;
										int index = secondaryList.childCount - 1;
										HudQuestObjective component = secondaryList.GetChild(index).GetComponent<HudQuestObjective>();
										component.UndoShrink();
										int num16 = 0;
										RecycleBin miscRecycleBin = UiRoot.Instance._miscRecycleBin;
										GameObject trash = component.gameObject;
										miscRecycleBin.SendToBin(trash);
										RectTransform secondaryList2 = _secondaryList;
									}
									RectTransform items = _items;
									int index2 = items.childCount - 1;
									HudQuestObjective component2 = items.GetChild(index2).GetComponent<HudQuestObjective>();
									component2.UndoShrink();
									int num17 = 0;
									RecycleBin miscRecycleBin2 = UiRoot.Instance._miscRecycleBin;
									GameObject trash2 = component2.gameObject;
									miscRecycleBin2.SendToBin(trash2);
									bool flag = default(bool);
									if (!flag)
									{
										return;
									}
									int childCount2 = _items.childCount;
									int num18 = 0;
									RecycleBin miscRecycleBin3 = UiRoot.Instance._miscRecycleBin;
									Type typeFromHandle = typeof(HudQuestObjective);
									RectTransform items2 = _items;
									ulong num19 = default(ulong);
									miscRecycleBin3.FindReusableOrNew(typeFromHandle, items2).SetActive((byte)num19 != 0);
									RectTransform items3 = _items;
									bool flag2 = default(bool);
									if (!flag2)
									{
										component3 = items3.GetChild(num3).GetComponent<HudQuestObjective>();
										if (!component3.gameObject.activeSelf)
										{
											ulong num20 = default(ulong);
											component3.gameObject.SetActive((byte)num20 != 0);
										}
										int switchFontSize = _switchFontSize;
										int forceNoComplete = 0;
										component3.SetData((DescriptionInfo)num2, (byte)forceNoComplete != 0, switchFontSize);
										num3++;
									}
									Transform transform = default(Transform);
									GameObject gameObject2 = transform.gameObject;
									int active2 = 0;
									gameObject2.SetActive((byte)active2 != 0);
									num3++;
									return;
								}
								int num21 = 0;
								MenuStack menuStack2 = UiRoot.Instance._menuStack;
								int num22 = 0;
								IMenu top2 = menuStack2.Top;
								if (top2 != null)
								{
									int num23 = 0;
									if (top2 != null)
									{
										int num24 = 0;
									}
								}
								int num25 = 0;
							}
						}
					}
				}
			}
			GameObject gameObject3 = component3.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002349")]
		[Cpp2IlInjected.Address(RVA = "0x130E840", Offset = "0x130D240", VA = "0x18130E840")]
		private void SetCurrentQuestTitleAndImage()
		{
			//Discarded unreachable code: IL_0067, IL_00ac, IL_00bb, IL_00c0, IL_00cf, IL_00d4, IL_00e3, IL_00f8
			//IL_005f: Expected O, but got I4
			MissionSlot missionSlot = _missionSlot;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int ownerCharacter = missionSlot.Data.OwnerCharacter;
			_currentQuest.gameObject.SetActive(value: true);
			CustomElement currentQuest = _currentQuest;
			MissionSlot missionSlot2 = _missionSlot;
			Dictionary<TextType, string> _003CTexts_003Ek__BackingField = currentQuest.Texts;
			string displayName_ = missionSlot2.Data.displayName_;
			int num = 0;
			string text = missionSlot2.ResolveString(displayName_, (IResolver)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600234A")]
		[Cpp2IlInjected.Address(RVA = "0x130E2E0", Offset = "0x130CCE0", VA = "0x18130E2E0")]
		private void RefreshNewQuestDisplay(MissionSlot missionSlot, bool isNewMission)
		{
			//Discarded unreachable code: IL_004a, IL_0079, IL_008c, IL_00c3, IL_00d2, IL_00db, IL_00ea, IL_00f1, IL_0100, IL_016f, IL_0178, IL_018f
			//IL_0042: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int ownerCharacter = missionSlot.Data.OwnerCharacter;
			_newQuest.gameObject.SetActive(value: true);
			Dictionary<TextType, string> _003CTexts_003Ek__BackingField = _newQuest.Texts;
			int num = 0;
			if (!isNewMission)
			{
			}
			string text = LocalizationManager.FromStringID("menu.label_new_quest", (IResolver)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600234B")]
		[Cpp2IlInjected.Address(RVA = "0x130CC30", Offset = "0x130B630", VA = "0x18130CC30")]
		private void OnTrackedMissionChanged(Item missionItem)
		{
			//Discarded unreachable code: IL_007b
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			MissionSlot missionSlot = default(MissionSlot);
			_missionSlot = missionSlot;
			MissionSlot missionSlot2 = _missionSlot;
			if (missionSlot2 != null)
			{
				int num = (_currentMissionStepIndex = missionSlot2.currentStepIndex_);
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				int num2 = 0;
				List<DescriptionInfo> list = (_currentAllObjectives = (List<DescriptionInfo>)(object)missionSlot2.GetCurrentDescriptions(_003CLocalizator_003Ek__BackingField, (byte)num2 != 0));
				((Queue<T>)(object)_animQueue).Clear();
				((HashSet<T>)(object)_completedObjectives).Clear();
				RefreshCurrentQuestDisplay(justTracked: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600234C")]
		[Cpp2IlInjected.Address(RVA = "0x130C8E0", Offset = "0x130B2E0", VA = "0x18130C8E0")]
		public void OnTrackClicked()
		{
			//Discarded unreachable code: IL_00d3
			//IL_00cd: Expected O, but got I4
			if (_newQuest.gameObject.activeSelf)
			{
				GameObject gameObject = _newQuest.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				CustomeElementModel _003CModel_003Ek__BackingField = _newQuest.Model;
				int num = 0;
				int num2 = 0;
				_missionSlot = (MissionSlot)(object)_003CModel_003Ek__BackingField;
				MissionSlot missionSlot = _missionSlot;
				int num3 = (_currentMissionStepIndex = missionSlot.currentStepIndex_);
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				int num4 = 0;
				List<DescriptionInfo> list = (_currentAllObjectives = (List<DescriptionInfo>)(object)missionSlot.GetCurrentDescriptions(_003CLocalizator_003Ek__BackingField, (byte)num4 != 0));
				((HashSet<T>)(object)_completedObjectives).Clear();
				((Queue<T>)(object)_animQueue).Clear();
				RefreshCurrentQuestDisplay(justTracked: true);
				MissionSlot missionSlot2 = _missionSlot;
				Client metaClient = SystemRoot.Instance.MetaClient;
				int missionId_ = missionSlot2.missionId_;
				int num5 = 0;
				metaClient.TrackMissionAsync(missionId_, (CancellationToken)num5).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600234D")]
		[Cpp2IlInjected.Address(RVA = "0x130CF00", Offset = "0x130B900", VA = "0x18130CF00")]
		[IteratorStateMachine(typeof(_003CRefreshBgAfterFrame_003Ed__64))]
		private IEnumerator RefreshBgAfterFrame()
		{
			int _003C_003E1__state = default(int);
			_003CRefreshBgAfterFrame_003Ed__64 _003CRefreshBgAfterFrame_003Ed__ = new _003CRefreshBgAfterFrame_003Ed__64(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshBgAfterFrame_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600234E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public void PostSfx(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600234F")]
		[Cpp2IlInjected.Address(RVA = "0x130DD60", Offset = "0x130C760", VA = "0x18130DD60")]
		private void RefreshFrom(List<DescriptionInfo> fromList)
		{
			//Discarded unreachable code: IL_012d, IL_0133, IL_0139, IL_013f, IL_0145, IL_014b, IL_0151, IL_0157, IL_015d, IL_0163, IL_0169, IL_016f, IL_0175, IL_017b, IL_0181
			//IL_00a9: Expected I4, but got I8
			//IL_00ec: Expected I4, but got I8
			//IL_00f8: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = _items.childCount - 1;
			RectTransform items = _items;
			int index = items.childCount - 1;
			HudQuestObjective component = items.GetChild(index).GetComponent<HudQuestObjective>();
			component.UndoShrink();
			int num5 = 0;
			RecycleBin miscRecycleBin = UiRoot.Instance._miscRecycleBin;
			GameObject trash = component.gameObject;
			miscRecycleBin.SendToBin(trash);
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			int childCount = _items.childCount;
			int num6 = 0;
			RecycleBin miscRecycleBin2 = UiRoot.Instance._miscRecycleBin;
			Type typeFromHandle = typeof(HudQuestObjective);
			RectTransform items2 = _items;
			ulong num7 = default(ulong);
			miscRecycleBin2.FindReusableOrNew(typeFromHandle, items2).SetActive((byte)num7 != 0);
			RectTransform items3 = _items;
			bool flag2 = default(bool);
			if (!flag2)
			{
				HudQuestObjective component2 = items3.GetChild(num3).GetComponent<HudQuestObjective>();
				if ((IntPtr)component2.DescriptionInfo == (IntPtr)num2)
				{
					goto IL_0128;
				}
				if (!component2.gameObject.activeSelf)
				{
					ulong num8 = default(ulong);
					component2.gameObject.SetActive((byte)num8 != 0);
				}
				bool forceNoComplete = !((HashSet<T>)(object)_completedObjectives).Contains((T)num2);
				uint switchFontSize = default(uint);
				component2.SetData((DescriptionInfo)num2, forceNoComplete, (int)switchFontSize);
				num3++;
			}
			GameObject gameObject = items3.GetChild(num3).gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			goto IL_0128;
			IL_0128:
			num3++;
		}

		[Cpp2IlInjected.Token(Token = "0x6002350")]
		[Cpp2IlInjected.Address(RVA = "0x130CE50", Offset = "0x130B850", VA = "0x18130CE50")]
		[IteratorStateMachine(typeof(_003CPlayObjectiveSwitchAnim_003Ed__67))]
		private IEnumerator PlayObjectiveSwitchAnim(List<DescriptionInfo> fromList, List<DescriptionInfo> toList)
		{
			int _003C_003E1__state = default(int);
			_003CPlayObjectiveSwitchAnim_003Ed__67 _003CPlayObjectiveSwitchAnim_003Ed__ = new _003CPlayObjectiveSwitchAnim_003Ed__67(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPlayObjectiveSwitchAnim_003Ed__._003C_003E4__this = this;
			_003CPlayObjectiveSwitchAnim_003Ed__.fromList = fromList;
			_003CPlayObjectiveSwitchAnim_003Ed__.toList = toList;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002351")]
		[Cpp2IlInjected.Address(RVA = "0x130F490", Offset = "0x130DE90", VA = "0x18130F490")]
		[IteratorStateMachine(typeof(_003CSwitchObjectiveDone_003Ed__68))]
		private IEnumerator SwitchObjectiveDone()
		{
			int _003C_003E1__state = default(int);
			_003CSwitchObjectiveDone_003Ed__68 _003CSwitchObjectiveDone_003Ed__ = new _003CSwitchObjectiveDone_003Ed__68(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSwitchObjectiveDone_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002352")]
		[Cpp2IlInjected.Address(RVA = "0x130CF70", Offset = "0x130B970", VA = "0x18130CF70")]
		private void RefreshBgSize()
		{
			//Discarded unreachable code: IL_003b
			//IL_003a: Expected O, but got I4
			RectTransform bg = _bg;
			int complete = 0;
			int num = DOTween.Kill(bg, (byte)complete != 0);
			Transform transform = _currentQuest.transform;
			RectTransform bg2 = _bg;
			int num2 = 0;
			Vector2 sizeDelta = bg2.sizeDelta;
			bg2.sizeDelta = (Vector2)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002353")]
		[Cpp2IlInjected.Address(RVA = "0x130E1C0", Offset = "0x130CBC0", VA = "0x18130E1C0")]
		private void RefreshLayout()
		{
			//Discarded unreachable code: IL_004e
			//IL_0018: Expected O, but got I4
			Transform transform = _newLabelContainer.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			((RectTransform)num).RebuildLayout();
			_newLabelContainer.transform.parent.RebuildLayout();
			_newLabelContainer.transform.parent.parent.RebuildLayout();
			RefreshBgSize();
		}

		[Cpp2IlInjected.Token(Token = "0x6002354")]
		[Cpp2IlInjected.Address(RVA = "0x130F420", Offset = "0x130DE20", VA = "0x18130F420")]
		[IteratorStateMachine(typeof(_003CSwitchAnimPart2_003Ed__71))]
		private IEnumerator SwitchAnimPart2()
		{
			int _003C_003E1__state = default(int);
			_003CSwitchAnimPart2_003Ed__71 _003CSwitchAnimPart2_003Ed__ = new _003CSwitchAnimPart2_003Ed__71(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSwitchAnimPart2_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002355")]
		[Cpp2IlInjected.Address(RVA = "0x130ADE0", Offset = "0x13097E0", VA = "0x18130ADE0")]
		private void KillAnimation()
		{
			//Discarded unreachable code: IL_0049
			//IL_0046: Expected O, but got I4
			RectTransform sparkleContainer = _sparkleContainer;
			int complete = 0;
			int num = DOTween.Kill(sparkleContainer, (byte)complete != 0);
			RectTransform bg = _bg;
			int complete2 = 0;
			int num2 = DOTween.Kill(bg, (byte)complete2 != 0);
			Transform transform = _newLabelContainer.transform;
			int num3 = 0;
			if ((object)transform != null)
			{
			}
			int complete3 = 0;
			int num4 = DOTween.Kill(num3, (byte)complete3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002356")]
		[Cpp2IlInjected.Address(RVA = "0x130F5D0", Offset = "0x130DFD0", VA = "0x18130F5D0")]
		public HudQuestTracker()
		{
		}//IL_0039: Expected I4, but got I8

	}
}
