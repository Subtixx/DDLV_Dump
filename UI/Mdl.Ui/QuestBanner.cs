using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using DG.Tweening;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000583")]
	public class QuestBanner : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000584")]
		private enum NotifType
		{
			[Cpp2IlInjected.Token(Token = "0x4001E77")]
			Received,
			[Cpp2IlInjected.Token(Token = "0x4001E78")]
			Completed,
			[Cpp2IlInjected.Token(Token = "0x4001E79")]
			None
		}

		[Cpp2IlInjected.Token(Token = "0x2000585")]
		private struct QuestInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001E7A")]
			public NotifType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001E7B")]
			public MissionItemData MissionData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001E7C")]
			public MissionSlot NewMissionSlot;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000586")]
		public class QuestTutorialException
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001E7D")]
			[ItemID]
			public int MissionID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4001E7E")]
			[ItemID]
			public int TutorialID;

			[Cpp2IlInjected.Token(Token = "0x17000595")]
			public Item MissionItem
			{
				[Cpp2IlInjected.Token(Token = "0x6002433")]
				[Cpp2IlInjected.Address(RVA = "0x157F0E0", Offset = "0x157DAE0", VA = "0x18157F0E0")]
				get
				{
					long num = Convert.ToInt64((uint)MissionID);
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000596")]
			public Item TutorialItem
			{
				[Cpp2IlInjected.Token(Token = "0x6002434")]
				[Cpp2IlInjected.Address(RVA = "0x157F140", Offset = "0x157DB40", VA = "0x18157F140")]
				get
				{
					long num = Convert.ToInt64((uint)TutorialID);
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002435")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public QuestTutorialException()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E28")]
		public Action<MissionSlot> OnQuestStartedAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E29")]
		public Action<MissionSlot> OnQuestTrack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E2A")]
		public Action OnQuestCompleteAnimStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E2B")]
		public Action OnQuestCompleteAnimEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E2C")]
		[SerializeField]
		[Header("Offsets")]
		private float _decoStartPosOffset = 250f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001E2D")]
		[SerializeField]
		private float _questCompletedIconDecoOffset = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E2E")]
		[SerializeField]
		[Header("Animation Timing")]
		private float _animIconTime = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001E2F")]
		[SerializeField]
		private float _animBgTime = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E30")]
		[SerializeField]
		private float _animDecoTime = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001E31")]
		[SerializeField]
		private float _delayBeforeClose = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E32")]
		[SerializeField]
		[Header("Quest Received")]
		private GameObject _questReceived;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E33")]
		[SerializeField]
		private RectTransform _questReceivedLeftDeco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001E34")]
		[SerializeField]
		private RectTransform _questReceivedRightDeco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001E35")]
		[SerializeField]
		private RectTransform _questReceivedTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001E36")]
		[SerializeField]
		private RectTransform _questReceivedStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001E37")]
		[SerializeField]
		private TextBase _questReceivedTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001E38")]
		[SerializeField]
		private RectTransform _questReceivedBgRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001E39")]
		[SerializeField]
		private RectTransform[] _questReceivedBgHorizontalLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001E3A")]
		[SerializeField]
		private RectTransform[] _questReceivedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001E3B")]
		[SerializeField]
		private AsyncAtlassedIcon _questReceivedCharacterIconLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001E3C")]
		[SerializeField]
		private AsyncAtlassedIcon _questReceivedCharacterIconRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001E3D")]
		[SerializeField]
		private GameObject _questReceivedShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001E3E")]
		[SerializeField]
		private AK.Wwise.Event _questStartSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001E3F")]
		[SerializeField]
		[Header("Quest Completed")]
		private GameObject _questCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001E40")]
		[SerializeField]
		private RectTransform _questCompletedLeftDeco;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001E41")]
		[SerializeField]
		private RectTransform _questCompletedRightDeco;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001E42")]
		[SerializeField]
		private RectTransform _questCompletedTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001E43")]
		[SerializeField]
		private TextBase _questCompletedTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001E44")]
		[SerializeField]
		private RectTransform _questCompletedBgRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001E45")]
		[SerializeField]
		private RectTransform[] _questCompletedBgHorizontalLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001E46")]
		[SerializeField]
		private RectTransform[] _questCompletedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001E47")]
		[SerializeField]
		private RectTransform _questCompletedIconDecoLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001E48")]
		[SerializeField]
		private RectTransform _questCompletedIconDecoRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001E49")]
		[SerializeField]
		private RectTransform _questCompletedStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001E4A")]
		[SerializeField]
		private AsyncAtlassedIcon _questCompletedCharacterIconLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001E4B")]
		[SerializeField]
		private AsyncAtlassedIcon _questCompletedCharacterIconRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001E4C")]
		[SerializeField]
		private RectTransform _questCompletedStatusBgLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001E4D")]
		[SerializeField]
		private RectTransform _questCompletedStatusBgRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001E4E")]
		[SerializeField]
		private CanvasGroup _questCompletedStatusText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001E4F")]
		[SerializeField]
		private RectTransform _questCompletedStatusBgRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001E50")]
		[SerializeField]
		private AK.Wwise.Event _questCompleteSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001E51")]
		[SerializeField]
		private AK.Wwise.Event _questCompleteJingle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001E52")]
		public HudQuestTracker _hudQuestTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001E53")]
		[SerializeField]
		[Header("Delay Buffer")]
		private float _bufferTime = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001E54")]
		[SerializeField]
		[Header("Quest that generate Tutorial popup")]
		private QuestTutorialException[] _questReceivedLinkToTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001E55")]
		[SerializeField]
		private QuestTutorialException[] _questCompletedLinkToTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001E56")]
		private Sequence _tween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001E57")]
		private Queue<QuestInfo> _pendingNotifQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001E58")]
		private Coroutine _showCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001E59")]
		private Coroutine _hideCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001E5A")]
		private Coroutine _bufferCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001E5B")]
		private bool _isInCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x4001E5C")]
		private bool _isShowing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19A")]
		[Cpp2IlInjected.Token(Token = "0x4001E5D")]
		private bool _isInBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19B")]
		[Cpp2IlInjected.Token(Token = "0x4001E5E")]
		private bool _mustWaitForTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4001E5F")]
		private float _questReceivedInitialTopY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001E60")]
		private float _questReceivedInitialStatusPosY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4001E61")]
		private float _questReceivedInitialBgRootY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001E62")]
		private float _questReceivedInitialBgHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4001E63")]
		private float _questReceivedInitialBgLayoutHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001E64")]
		private float _questReceivedInitialLeftDecoX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4001E65")]
		private float _questReceivedInitialRightDecoX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001E66")]
		private float _questCompletedInitialTopY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4001E67")]
		private float _questCompletedInitialStatusPosY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001E68")]
		private float _questCompletedInitialBgRootY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4001E69")]
		private float _questCompletedInitialBgHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4001E6A")]
		private float _questCompletedInitialBgLayoutHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4001E6B")]
		private float _questCompletedInitialLeftDecoX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4001E6C")]
		private float _questCompletedInitialRightDecoX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x4001E6D")]
		private float _questCompletedInitialIconDecoLeftX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4001E6E")]
		private float _questCompletedInitialIconDecoRightX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x4001E6F")]
		private float _questCompletedInitialStatusBgHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4001E70")]
		private float _questCompletedInitialStatusBgY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x4001E71")]
		private float _questCompletedInitialStatusBgRootY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4001E72")]
		private QuestInfo _currentNotif;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4001E73")]
		private Profile _profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4001E74")]
		private HashSet<string> _exposedNotifications = (HashSet<string>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4001E75")]
		private MissionSlot _newMissionSlot;

		[Cpp2IlInjected.Token(Token = "0x6002412")]
		[Cpp2IlInjected.Address(RVA = "0xE25060", Offset = "0xE23A60", VA = "0x180E25060")]
		private void Start()
		{
			//Discarded unreachable code: IL_01f0
			//IL_0153: Expected F4, but got I4
			//IL_016b: Expected F4, but got I4
			//IL_0183: Expected F4, but got I4
			//IL_01a1: Expected F4, but got I4
			//IL_01bf: Expected F4, but got I4
			//IL_01d8: Expected F4, but got O
			//IL_01e9: Expected F4, but got O
			Profile profile = (_profile = SystemRoot.Instance.MetaClient.profile);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.MissionSlotUpdated value = OnSlotUpdate;
					_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.MissionSlotUpdated value2 = OnSlotUpdate;
					_003CDispatcher_003Ek__BackingField2.OnMissionSlotUpdated += value2;
				}
			}
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			MenuStack.CurrentMenuChanged value3 = OnMenuChanged;
			menuStack.OnCurrentMenuChanged -= value3;
			int num2 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value4 = OnPopupChanged;
			popupStack.OnCurrentMenuChanged -= value4;
			int num3 = 0;
			MenuStack menuStack2 = UiRoot.Instance._menuStack;
			MenuStack.CurrentMenuChanged value5 = OnMenuChanged;
			menuStack2.OnCurrentMenuChanged += value5;
			int num4 = 0;
			MenuStack popupStack2 = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value6 = OnPopupChanged;
			popupStack2.OnCurrentMenuChanged += value6;
			Queue<QuestInfo> queue = (_pendingNotifQueue = (Queue<QuestInfo>)(object)new Queue<T>());
			RectTransform questReceivedTop = _questReceivedTop;
			_isInCoroutine = false;
			Vector2 anchoredPosition = questReceivedTop.anchoredPosition;
			RectTransform questReceivedStatus = _questReceivedStatus;
			_questReceivedInitialTopY = 0f;
			Vector2 anchoredPosition2 = questReceivedStatus.anchoredPosition;
			RectTransform questReceivedBgRoot = _questReceivedBgRoot;
			_questReceivedInitialStatusPosY = 0f;
			Vector2 anchoredPosition3 = questReceivedBgRoot.anchoredPosition;
			RectTransform[] questReceivedBg = _questReceivedBg;
			_questReceivedInitialBgRootY = 0f;
			Vector2 sizeDelta = questReceivedBg[0].sizeDelta;
			RectTransform[] questReceivedBgHorizontalLayout = _questReceivedBgHorizontalLayout;
			_questReceivedInitialBgHeight = 0f;
			Vector2 sizeDelta2 = questReceivedBgHorizontalLayout[0].sizeDelta;
			RectTransform questReceivedLeftDeco = _questReceivedLeftDeco;
			_questReceivedInitialBgLayoutHeight = 0f;
			Vector2 anchoredPosition4 = questReceivedLeftDeco.anchoredPosition;
			RectTransform questReceivedRightDeco = _questReceivedRightDeco;
			_questReceivedInitialLeftDecoX = (float)anchoredPosition4;
			Vector2 anchoredPosition5 = questReceivedRightDeco.anchoredPosition;
			_questReceivedInitialRightDecoX = (float)anchoredPosition5;
			InitValuesForQuestCompleted();
		}

		[Cpp2IlInjected.Token(Token = "0x6002413")]
		[Cpp2IlInjected.Address(RVA = "0xE23A10", Offset = "0xE22410", VA = "0x180E23A10")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0091
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.MissionSlotUpdated value = OnSlotUpdate;
					_003CDispatcher_003Ek__BackingField.OnMissionSlotUpdated -= value;
				}
			}
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			MenuStack.CurrentMenuChanged value2 = OnMenuChanged;
			menuStack.OnCurrentMenuChanged -= value2;
			int num2 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value3 = OnPopupChanged;
			popupStack.OnCurrentMenuChanged -= value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002414")]
		[Cpp2IlInjected.Address(RVA = "0xE23C90", Offset = "0xE22690", VA = "0x180E23C90")]
		private void OnDisable()
		{
			//IL_002c: Expected O, but got I8
			if ((_isShowing || _isInBuffer) && (long)_currentNotif != 2)
			{
				KeepCurrentNotif();
				_currentNotif = (QuestInfo)2;
			}
			ResetAll();
		}

		[Cpp2IlInjected.Token(Token = "0x6002415")]
		[Cpp2IlInjected.Address(RVA = "0xE25A10", Offset = "0xE24410", VA = "0x180E25A10")]
		private void Update()
		{
			//Discarded unreachable code: IL_0058
			if (!_isInCoroutine && !_isInBuffer && !_mustWaitForTutorial)
			{
				int num = 0;
				HudMenu menu = UiRoot.Instance._menuStack.GetMenu<HudMenu>();
				Queue<QuestInfo> pendingNotifQueue = _pendingNotifQueue;
				int _003C_003E1__state = default(int);
				_003CDoBuffer_003Ed__106 _003CDoBuffer_003Ed__ = new _003CDoBuffer_003Ed__106(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CDoBuffer_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (_bufferCoroutine = StartCoroutine(_003CDoBuffer_003Ed__));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002416")]
		[Cpp2IlInjected.Address(RVA = "0xE23CE0", Offset = "0xE226E0", VA = "0x180E23CE0")]
		private void OnMenuChanged(IMenu menu)
		{
			DoCheckToKeepNotif(menu);
			if (menu == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (flag && _mustWaitForTutorial)
			{
				_mustWaitForTutorial = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002417")]
		[Cpp2IlInjected.Address(RVA = "0xE23DB0", Offset = "0xE227B0", VA = "0x180E23DB0")]
		private void OnPopupChanged(IMenu menu)
		{
			DoCheckToKeepNotif(menu);
		}

		[Cpp2IlInjected.Token(Token = "0x6002418")]
		[Cpp2IlInjected.Address(RVA = "0xE22CE0", Offset = "0xE216E0", VA = "0x180E22CE0")]
		private void DoCheckToKeepNotif(IMenu menu)
		{
			//Discarded unreachable code: IL_0049
			//IL_0042: Expected O, but got I8
			int num = 0;
			HudMenu menu2 = UiRoot.Instance._menuStack.GetMenu<HudMenu>();
			if (menu != menu2 && (_isShowing || _isInBuffer))
			{
				if ((long)_currentNotif != 2)
				{
					KeepCurrentNotif();
					_currentNotif = (QuestInfo)2;
				}
				ResetAll();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002419")]
		[Cpp2IlInjected.Address(RVA = "0xE23600", Offset = "0xE22000", VA = "0x180E23600")]
		private void KeepCurrentNotif()
		{
			//IL_0017: Expected I4, but got O
			QuestInfo currentNotif = _currentNotif;
			int index = 0;
			List<QuestInfo> list = default(List<QuestInfo>);
			((List<T>)(object)list).Insert(index, (T)currentNotif);
			Queue<QuestInfo> queue = (_pendingNotifQueue = (Queue<QuestInfo>)(object)new Queue<T>((int)list));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600241A")]
		[Cpp2IlInjected.Address(RVA = "0xE242C0", Offset = "0xE22CC0", VA = "0x180E242C0")]
		private void ResetAll()
		{
			Sequence tween = _tween;
			if (tween != null)
			{
				int complete = 0;
				tween.Kill((byte)complete != 0);
			}
			Coroutine showCoroutine = _showCoroutine;
			if (showCoroutine != null)
			{
				StopCoroutine(showCoroutine);
			}
			Coroutine hideCoroutine = _hideCoroutine;
			if (hideCoroutine != null)
			{
				StopCoroutine(hideCoroutine);
			}
			Coroutine bufferCoroutine = _bufferCoroutine;
			if (bufferCoroutine != null)
			{
				StopCoroutine(bufferCoroutine);
			}
			ResetQuestReceived();
			ResetQuestCompleted();
			_isInCoroutine = false;
			_isInBuffer = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600241B")]
		[Cpp2IlInjected.Address(RVA = "0xE231F0", Offset = "0xE21BF0", VA = "0x180E231F0")]
		private void InitValuesForQuestReceived()
		{
			//Discarded unreachable code: IL_00ad
			//IL_001a: Expected F4, but got I4
			//IL_002f: Expected F4, but got I4
			//IL_0046: Expected F4, but got I4
			//IL_0064: Expected F4, but got I4
			//IL_0082: Expected F4, but got I4
			//IL_009b: Expected F4, but got O
			//IL_00ac: Expected F4, but got O
			Vector2 anchoredPosition = _questReceivedTop.anchoredPosition;
			RectTransform questReceivedStatus = _questReceivedStatus;
			_questReceivedInitialTopY = 0f;
			Vector2 anchoredPosition2 = questReceivedStatus.anchoredPosition;
			RectTransform questReceivedBgRoot = _questReceivedBgRoot;
			_questReceivedInitialStatusPosY = 0f;
			Vector2 anchoredPosition3 = questReceivedBgRoot.anchoredPosition;
			RectTransform[] questReceivedBg = _questReceivedBg;
			_questReceivedInitialBgRootY = 0f;
			Vector2 sizeDelta = questReceivedBg[0].sizeDelta;
			RectTransform[] questReceivedBgHorizontalLayout = _questReceivedBgHorizontalLayout;
			_questReceivedInitialBgHeight = 0f;
			Vector2 sizeDelta2 = questReceivedBgHorizontalLayout[0].sizeDelta;
			RectTransform questReceivedLeftDeco = _questReceivedLeftDeco;
			_questReceivedInitialBgLayoutHeight = 0f;
			Vector2 anchoredPosition4 = questReceivedLeftDeco.anchoredPosition;
			RectTransform questReceivedRightDeco = _questReceivedRightDeco;
			_questReceivedInitialLeftDecoX = (float)anchoredPosition4;
			Vector2 anchoredPosition5 = questReceivedRightDeco.anchoredPosition;
			_questReceivedInitialRightDecoX = (float)anchoredPosition5;
		}

		[Cpp2IlInjected.Token(Token = "0x600241C")]
		[Cpp2IlInjected.Address(RVA = "0xE22FA0", Offset = "0xE219A0", VA = "0x180E22FA0")]
		private void InitValuesForQuestCompleted()
		{
			//Discarded unreachable code: IL_0127
			//IL_001a: Expected F4, but got I4
			//IL_002f: Expected F4, but got I4
			//IL_0046: Expected F4, but got I4
			//IL_0064: Expected F4, but got I4
			//IL_0082: Expected F4, but got I4
			//IL_009b: Expected F4, but got O
			//IL_00b4: Expected F4, but got O
			//IL_00cd: Expected F4, but got O
			//IL_00e6: Expected F4, but got O
			//IL_00fe: Expected F4, but got I4
			//IL_0116: Expected F4, but got I4
			//IL_0126: Expected F4, but got I4
			Vector2 anchoredPosition = _questCompletedTop.anchoredPosition;
			RectTransform questCompletedStatus = _questCompletedStatus;
			_questCompletedInitialTopY = 0f;
			Vector2 anchoredPosition2 = questCompletedStatus.anchoredPosition;
			RectTransform questCompletedBgRoot = _questCompletedBgRoot;
			_questCompletedInitialStatusPosY = 0f;
			Vector2 anchoredPosition3 = questCompletedBgRoot.anchoredPosition;
			RectTransform[] questCompletedBg = _questCompletedBg;
			_questCompletedInitialBgRootY = 0f;
			Vector2 sizeDelta = questCompletedBg[0].sizeDelta;
			RectTransform[] questCompletedBgHorizontalLayout = _questCompletedBgHorizontalLayout;
			_questCompletedInitialBgHeight = 0f;
			Vector2 sizeDelta2 = questCompletedBgHorizontalLayout[0].sizeDelta;
			RectTransform questCompletedLeftDeco = _questCompletedLeftDeco;
			_questCompletedInitialBgLayoutHeight = 0f;
			Vector2 anchoredPosition4 = questCompletedLeftDeco.anchoredPosition;
			RectTransform questCompletedRightDeco = _questCompletedRightDeco;
			_questCompletedInitialLeftDecoX = (float)anchoredPosition4;
			Vector2 anchoredPosition5 = questCompletedRightDeco.anchoredPosition;
			RectTransform questCompletedIconDecoLeft = _questCompletedIconDecoLeft;
			_questCompletedInitialRightDecoX = (float)anchoredPosition5;
			Vector2 anchoredPosition6 = questCompletedIconDecoLeft.anchoredPosition;
			RectTransform questCompletedIconDecoRight = _questCompletedIconDecoRight;
			_questCompletedInitialIconDecoLeftX = (float)anchoredPosition6;
			Vector2 anchoredPosition7 = questCompletedIconDecoRight.anchoredPosition;
			RectTransform questCompletedStatusBgLeft = _questCompletedStatusBgLeft;
			_questCompletedInitialIconDecoRightX = (float)anchoredPosition7;
			Vector2 sizeDelta3 = questCompletedStatusBgLeft.sizeDelta;
			RectTransform questCompletedStatusBgLeft2 = _questCompletedStatusBgLeft;
			_questCompletedInitialStatusBgHeight = 0f;
			Vector2 anchoredPosition8 = questCompletedStatusBgLeft2.anchoredPosition;
			RectTransform questCompletedStatusBgRoot = _questCompletedStatusBgRoot;
			_questCompletedInitialStatusBgY = 0f;
			Vector2 anchoredPosition9 = questCompletedStatusBgRoot.anchoredPosition;
			_questCompletedInitialStatusBgRootY = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x600241D")]
		[Cpp2IlInjected.Address(RVA = "0xE23EF0", Offset = "0xE228F0", VA = "0x180E23EF0")]
		private void OnSlotUpdate(MissionSlotClass slotClass, int slotId, MissionItemData missionData, SlotUpdatedReason reason, List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_00a1
			//IL_0023: Expected O, but got I4
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			int num = 0;
			((Queue<T>)(object)_pendingNotifQueue).Enqueue((T)num);
			Queue<QuestInfo> queue = (_pendingNotifQueue = (Queue<QuestInfo>)(object)this.ReorganizeQueue());
			if (_mustWaitForTutorial)
			{
			}
			int iD_ = missionData.iD_;
			bool flag = (_mustWaitForTutorial = MustWaitForTutorialOnReceived(iD_));
			if (!_isInCoroutine)
			{
				int num2 = 0;
				HudMenu menu = UiRoot.Instance._menuStack.GetMenu<HudMenu>();
				if (_mustWaitForTutorial && _isInBuffer)
				{
					KeepCurrentNotif();
					Coroutine bufferCoroutine = _bufferCoroutine;
					StopCoroutine(bufferCoroutine);
					_isInBuffer = false;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600241E")]
		[Cpp2IlInjected.Address(RVA = "0xE22E80", Offset = "0xE21880", VA = "0x180E22E80")]
		private string GetQuestName(MissionItemData missionData)
		{
			//Discarded unreachable code: IL_0016
			//IL_0010: Expected O, but got I4
			string displayName_ = missionData.displayName_;
			int num = 0;
			return LocalizationManager.FromStringID(displayName_, (IResolver)num).ToUpper();
		}

		[Cpp2IlInjected.Token(Token = "0x600241F")]
		[Cpp2IlInjected.Address(RVA = "0xE22D80", Offset = "0xE21780", VA = "0x180E22D80")]
		private string GetQuestCharacterIcon(MissionItemData missionData)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int ownerCharacter = missionData.OwnerCharacter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002420")]
		[Cpp2IlInjected.Address(RVA = "0xE24E00", Offset = "0xE23800", VA = "0x180E24E00")]
		private void SetupAndShowQuestReceived(MissionItemData missionData)
		{
			//IL_0010: Expected O, but got I4
			string displayName_ = missionData.displayName_;
			int num = 0;
			string questName = LocalizationManager.FromStringID(displayName_, (IResolver)num).ToUpper();
			string questCharacterIcon = GetQuestCharacterIcon(missionData);
			int _003C_003E1__state = default(int);
			_003CShowQuestStarted_003Ed__99 _003CShowQuestStarted_003Ed__ = new _003CShowQuestStarted_003Ed__99(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowQuestStarted_003Ed__._003C_003E4__this = this;
			_003CShowQuestStarted_003Ed__.questName = questName;
			_003CShowQuestStarted_003Ed__.characterIconAddress = questCharacterIcon;
			Coroutine coroutine = (_showCoroutine = StartCoroutine(_003CShowQuestStarted_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002421")]
		[Cpp2IlInjected.Address(RVA = "0xE24CF0", Offset = "0xE236F0", VA = "0x180E24CF0")]
		public void SetupAndShowQuestCompleted(MissionItemData missionData)
		{
			//IL_0021: Expected O, but got I4
			OnQuestCompleteAnimStart?.Invoke();
			string displayName_ = missionData.displayName_;
			int num = 0;
			string questName = LocalizationManager.FromStringID(displayName_, (IResolver)num).ToUpper();
			string questCharacterIcon = GetQuestCharacterIcon(missionData);
			int _003C_003E1__state = default(int);
			_003CShowQuestCompleted_003Ed__101 _003CShowQuestCompleted_003Ed__ = new _003CShowQuestCompleted_003Ed__101(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowQuestCompleted_003Ed__._003C_003E4__this = this;
			_003CShowQuestCompleted_003Ed__.questName = questName;
			_003CShowQuestCompleted_003Ed__.characterIconAddress = questCharacterIcon;
			Coroutine coroutine = (_showCoroutine = StartCoroutine(_003CShowQuestCompleted_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002422")]
		[Cpp2IlInjected.Address(RVA = "0xE24910", Offset = "0xE23310", VA = "0x180E24910")]
		private void ResetQuestReceived()
		{
			//Discarded unreachable code: IL_016f
			//IL_0017: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			//IL_00fd: Expected O, but got I4
			//IL_0120: Expected O, but got I4
			//IL_013d: Expected O, but got I4
			//IL_015a: Expected O, but got I4
			RectTransform questReceivedTop = _questReceivedTop;
			int num = 0;
			Vector2 anchoredPosition = questReceivedTop.anchoredPosition;
			questReceivedTop.anchoredPosition = (Vector2)num;
			RectTransform questReceivedStatus = _questReceivedStatus;
			int num2 = 0;
			Vector2 anchoredPosition2 = questReceivedStatus.anchoredPosition;
			questReceivedStatus.anchoredPosition = (Vector2)num2;
			RectTransform questReceivedBgRoot = _questReceivedBgRoot;
			int num3 = 0;
			Vector2 anchoredPosition3 = questReceivedBgRoot.anchoredPosition;
			questReceivedBgRoot.anchoredPosition = (Vector2)num3;
			RectTransform rectTransform = _questReceivedBg[0];
			int num4 = 0;
			Vector2 sizeDelta = rectTransform.sizeDelta;
			rectTransform.sizeDelta = (Vector2)num4;
			RectTransform rectTransform2 = _questReceivedBg[1];
			int num5 = 0;
			Vector2 sizeDelta2 = rectTransform2.sizeDelta;
			rectTransform2.sizeDelta = (Vector2)num5;
			RectTransform rectTransform3 = _questReceivedBg[2];
			int num6 = 0;
			Vector2 sizeDelta3 = rectTransform3.sizeDelta;
			rectTransform3.sizeDelta = (Vector2)num6;
			RectTransform rectTransform4 = _questReceivedBg[3];
			int num7 = 0;
			Vector2 sizeDelta4 = rectTransform4.sizeDelta;
			rectTransform4.sizeDelta = (Vector2)num7;
			RectTransform rectTransform5 = _questReceivedBgHorizontalLayout[0];
			int num8 = 0;
			Vector2 sizeDelta5 = rectTransform5.sizeDelta;
			rectTransform5.sizeDelta = (Vector2)num8;
			RectTransform rectTransform6 = _questReceivedBgHorizontalLayout[1];
			int num9 = 0;
			Vector2 sizeDelta6 = rectTransform6.sizeDelta;
			rectTransform6.sizeDelta = (Vector2)num9;
			RectTransform questReceivedLeftDeco = _questReceivedLeftDeco;
			int num10 = 0;
			Vector2 anchoredPosition4 = questReceivedLeftDeco.anchoredPosition;
			questReceivedLeftDeco.anchoredPosition = (Vector2)num10;
			RectTransform questReceivedRightDeco = _questReceivedRightDeco;
			int num11 = 0;
			Vector2 anchoredPosition5 = questReceivedRightDeco.anchoredPosition;
			questReceivedRightDeco.anchoredPosition = (Vector2)num11;
			GameObject questReceived = _questReceived;
			int active = 0;
			questReceived.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002423")]
		[Cpp2IlInjected.Address(RVA = "0xE24350", Offset = "0xE22D50", VA = "0x180E24350")]
		private void ResetQuestCompleted()
		{
			//Discarded unreachable code: IL_024e
			//IL_0017: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			//IL_00fd: Expected O, but got I4
			//IL_0120: Expected O, but got I4
			//IL_013d: Expected O, but got I4
			//IL_015a: Expected O, but got I4
			//IL_0177: Expected O, but got I4
			//IL_0194: Expected O, but got I4
			//IL_01b1: Expected O, but got I4
			//IL_01ce: Expected O, but got I4
			//IL_01eb: Expected O, but got I4
			//IL_0208: Expected O, but got I4
			//IL_0225: Expected O, but got I4
			RectTransform questCompletedTop = _questCompletedTop;
			int num = 0;
			Vector2 anchoredPosition = questCompletedTop.anchoredPosition;
			questCompletedTop.anchoredPosition = (Vector2)num;
			RectTransform questCompletedStatus = _questCompletedStatus;
			int num2 = 0;
			Vector2 anchoredPosition2 = questCompletedStatus.anchoredPosition;
			questCompletedStatus.anchoredPosition = (Vector2)num2;
			RectTransform questCompletedBgRoot = _questCompletedBgRoot;
			int num3 = 0;
			Vector2 anchoredPosition3 = questCompletedBgRoot.anchoredPosition;
			questCompletedBgRoot.anchoredPosition = (Vector2)num3;
			RectTransform rectTransform = _questCompletedBg[0];
			int num4 = 0;
			Vector2 sizeDelta = rectTransform.sizeDelta;
			rectTransform.sizeDelta = (Vector2)num4;
			RectTransform rectTransform2 = _questCompletedBg[1];
			int num5 = 0;
			Vector2 sizeDelta2 = rectTransform2.sizeDelta;
			rectTransform2.sizeDelta = (Vector2)num5;
			RectTransform rectTransform3 = _questCompletedBg[2];
			int num6 = 0;
			Vector2 sizeDelta3 = rectTransform3.sizeDelta;
			rectTransform3.sizeDelta = (Vector2)num6;
			RectTransform rectTransform4 = _questCompletedBg[3];
			int num7 = 0;
			Vector2 sizeDelta4 = rectTransform4.sizeDelta;
			rectTransform4.sizeDelta = (Vector2)num7;
			RectTransform rectTransform5 = _questCompletedBgHorizontalLayout[0];
			int num8 = 0;
			Vector2 sizeDelta5 = rectTransform5.sizeDelta;
			rectTransform5.sizeDelta = (Vector2)num8;
			RectTransform rectTransform6 = _questCompletedBgHorizontalLayout[1];
			int num9 = 0;
			Vector2 sizeDelta6 = rectTransform6.sizeDelta;
			rectTransform6.sizeDelta = (Vector2)num9;
			RectTransform questCompletedLeftDeco = _questCompletedLeftDeco;
			int num10 = 0;
			Vector2 anchoredPosition4 = questCompletedLeftDeco.anchoredPosition;
			questCompletedLeftDeco.anchoredPosition = (Vector2)num10;
			RectTransform questCompletedRightDeco = _questCompletedRightDeco;
			int num11 = 0;
			Vector2 anchoredPosition5 = questCompletedRightDeco.anchoredPosition;
			questCompletedRightDeco.anchoredPosition = (Vector2)num11;
			RectTransform questCompletedIconDecoLeft = _questCompletedIconDecoLeft;
			int num12 = 0;
			Vector2 anchoredPosition6 = questCompletedIconDecoLeft.anchoredPosition;
			questCompletedIconDecoLeft.anchoredPosition = (Vector2)num12;
			RectTransform questCompletedIconDecoRight = _questCompletedIconDecoRight;
			int num13 = 0;
			Vector2 anchoredPosition7 = questCompletedIconDecoRight.anchoredPosition;
			questCompletedIconDecoRight.anchoredPosition = (Vector2)num13;
			RectTransform questCompletedStatusBgLeft = _questCompletedStatusBgLeft;
			int num14 = 0;
			Vector2 sizeDelta7 = questCompletedStatusBgLeft.sizeDelta;
			questCompletedStatusBgLeft.sizeDelta = (Vector2)num14;
			RectTransform questCompletedStatusBgLeft2 = _questCompletedStatusBgLeft;
			int num15 = 0;
			Vector2 anchoredPosition8 = questCompletedStatusBgLeft2.anchoredPosition;
			questCompletedStatusBgLeft2.anchoredPosition = (Vector2)num15;
			RectTransform questCompletedStatusBgRight = _questCompletedStatusBgRight;
			int num16 = 0;
			Vector2 sizeDelta8 = questCompletedStatusBgRight.sizeDelta;
			questCompletedStatusBgRight.sizeDelta = (Vector2)num16;
			RectTransform questCompletedStatusBgRight2 = _questCompletedStatusBgRight;
			int num17 = 0;
			Vector2 anchoredPosition9 = questCompletedStatusBgRight2.anchoredPosition;
			questCompletedStatusBgRight2.anchoredPosition = (Vector2)num17;
			RectTransform questCompletedStatusBgRoot = _questCompletedStatusBgRoot;
			int num18 = 0;
			Vector2 anchoredPosition10 = questCompletedStatusBgRoot.anchoredPosition;
			questCompletedStatusBgRoot.anchoredPosition = (Vector2)num18;
			GameObject questCompleted = _questCompleted;
			int active = 0;
			questCompleted.SetActive((byte)active != 0);
			OnQuestCompleteAnimEnd?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002424")]
		[Cpp2IlInjected.Address(RVA = "0xE24FB0", Offset = "0xE239B0", VA = "0x180E24FB0")]
		[IteratorStateMachine(typeof(_003CShowQuestStarted_003Ed__99))]
		private IEnumerator ShowQuestStarted(string questName = "", string characterIconAddress = "")
		{
			int _003C_003E1__state = default(int);
			_003CShowQuestStarted_003Ed__99 _003CShowQuestStarted_003Ed__ = new _003CShowQuestStarted_003Ed__99(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowQuestStarted_003Ed__._003C_003E4__this = this;
			_003CShowQuestStarted_003Ed__.questName = questName;
			_003CShowQuestStarted_003Ed__.characterIconAddress = characterIconAddress;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002425")]
		[Cpp2IlInjected.Address(RVA = "0xE22F30", Offset = "0xE21930", VA = "0x180E22F30")]
		[IteratorStateMachine(typeof(_003CHideQuestStarted_003Ed__100))]
		private IEnumerator HideQuestStarted()
		{
			int _003C_003E1__state = default(int);
			_003CHideQuestStarted_003Ed__100 _003CHideQuestStarted_003Ed__ = new _003CHideQuestStarted_003Ed__100(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CHideQuestStarted_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002426")]
		[Cpp2IlInjected.Address(RVA = "0xE24F00", Offset = "0xE23900", VA = "0x180E24F00")]
		[IteratorStateMachine(typeof(_003CShowQuestCompleted_003Ed__101))]
		private IEnumerator ShowQuestCompleted(string questName = "", string characterIconAddress = "")
		{
			int _003C_003E1__state = default(int);
			_003CShowQuestCompleted_003Ed__101 _003CShowQuestCompleted_003Ed__ = new _003CShowQuestCompleted_003Ed__101(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowQuestCompleted_003Ed__._003C_003E4__this = this;
			_003CShowQuestCompleted_003Ed__.questName = questName;
			_003CShowQuestCompleted_003Ed__.characterIconAddress = characterIconAddress;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002427")]
		[Cpp2IlInjected.Address(RVA = "0xE22EC0", Offset = "0xE218C0", VA = "0x180E22EC0")]
		[IteratorStateMachine(typeof(_003CHideQuestCompleted_003Ed__102))]
		private IEnumerator HideQuestCompleted()
		{
			int _003C_003E1__state = default(int);
			_003CHideQuestCompleted_003Ed__102 _003CHideQuestCompleted_003Ed__ = new _003CHideQuestCompleted_003Ed__102(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CHideQuestCompleted_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002428")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE21E40", VA = "0x180E23440")]
		public bool IsInQueue(MissionSlot missionSlot)
		{
			//Discarded unreachable code: IL_0031
			Queue<QuestInfo> pendingNotifQueue = _pendingNotifQueue;
			Func<QuestInfo, bool> func = (Func<QuestInfo, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_000e
				MissionItemData data = missionSlot.Data;
				bool result = default(bool);
				return result;
			};
			return Enumerable.Count<QuestInfo>(Enumerable.Where<QuestInfo>((IEnumerable<>)pendingNotifQueue, (Func<, >)(object)func)) > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002429")]
		[Cpp2IlInjected.Address(RVA = "0xE25670", Offset = "0xE24070", VA = "0x180E25670")]
		public void TriggerQuestCompleted(MissionSlotClass slotClass, int slotId, MissionItemData missionData)
		{
			//Discarded unreachable code: IL_009a
			//IL_0055: Expected O, but got I4
			object[] array;
			NotifType notifType = default(NotifType);
			while (true)
			{
				int num = 0;
				array = new object[0];
				int iD_ = missionData.iD_;
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				if (array != null && array == null)
				{
					continue;
				}
				array[1] = array;
				if (array == null || array != null)
				{
					array[2] = array;
					if (notifType == NotifType.Received || notifType != 0)
					{
						break;
					}
				}
			}
			array[3] = notifType;
			string item = string.Format("notif_{0}_{1}_{2}_{3}", array);
			if (!((HashSet<T>)(object)_exposedNotifications).Contains((T)item))
			{
				bool flag = ((HashSet<T>)(object)_exposedNotifications).Add((T)item);
				Queue<QuestInfo> pendingNotifQueue = _pendingNotifQueue;
				Queue<QuestInfo> queue = (_pendingNotifQueue = (Queue<QuestInfo>)(object)this.ReorganizeQueue());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600242A")]
		[Cpp2IlInjected.Address(RVA = "0xE24150", Offset = "0xE22B50", VA = "0x180E24150")]
		private Queue<QuestInfo> ReorganizeQueue()
		{
			//IL_0032: Expected I4, but got O
			Queue<QuestInfo> pendingNotifQueue = _pendingNotifQueue;
			Func<QuestInfo, int> _003C_003E9__105_ = _003C_003Ec._003C_003E9__105_0;
			if (_003C_003E9__105_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			return (Queue<QuestInfo>)(object)new Queue<T>((int)Enumerable.OrderBy<QuestInfo, int>((IEnumerable<>)pendingNotifQueue, (Func<, >)(object)_003C_003E9__105_));
		}

		[Cpp2IlInjected.Token(Token = "0x600242B")]
		[Cpp2IlInjected.Address(RVA = "0xE22C70", Offset = "0xE21670", VA = "0x180E22C70")]
		[IteratorStateMachine(typeof(_003CDoBuffer_003Ed__106))]
		private IEnumerator DoBuffer()
		{
			int _003C_003E1__state = default(int);
			_003CDoBuffer_003Ed__106 _003CDoBuffer_003Ed__ = new _003CDoBuffer_003Ed__106(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDoBuffer_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600242C")]
		[Cpp2IlInjected.Address(RVA = "0xE23550", Offset = "0xE21F50", VA = "0x180E23550")]
		private bool IsNewNotif(string key, bool checkDontAdd = false)
		{
			//Discarded unreachable code: IL_0024
			if (((HashSet<T>)(object)_exposedNotifications).Contains((T)key))
			{
				int num = 0;
			}
			if (!checkDontAdd)
			{
				bool flag = ((HashSet<T>)(object)_exposedNotifications).Add((T)key);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600242D")]
		[Cpp2IlInjected.Address(RVA = "0xE23880", Offset = "0xE22280", VA = "0x180E23880")]
		private bool MustWaitForTutorialOnReceived(int questID)
		{
			//IL_0069: Expected O, but got I4
			QuestTutorialException[] questReceivedLinkToTutorial = _questReceivedLinkToTutorial;
			int num = 0;
			if (questReceivedLinkToTutorial != null)
			{
				int num2 = 0;
				if (num2 < questReceivedLinkToTutorial.Length)
				{
					Item missionItem = questReceivedLinkToTutorial[num2].MissionItem;
					if ((IntPtr)questID != (IntPtr)missionItem)
					{
						QuestTutorialException[] questReceivedLinkToTutorial2 = _questReceivedLinkToTutorial;
						num2++;
					}
					Client client = default(Client);
					RepeatedField<int> completedFtueEvents_ = client.profile.player_.completedFtueEvents_;
					int itemID = _questReceivedLinkToTutorial[num2].TutorialItem.ItemID;
					bool flag = ((RepeatedField<T>)(object)completedFtueEvents_).Contains((T)itemID);
				}
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x600242E")]
		[Cpp2IlInjected.Address(RVA = "0xE236F0", Offset = "0xE220F0", VA = "0x180E236F0")]
		private bool MustWaitForTutorialOnCompleted(int questID)
		{
			//IL_0069: Expected O, but got I4
			QuestTutorialException[] questCompletedLinkToTutorial = _questCompletedLinkToTutorial;
			int num = 0;
			if (questCompletedLinkToTutorial != null)
			{
				int num2 = 0;
				if (num2 < questCompletedLinkToTutorial.Length)
				{
					Item missionItem = questCompletedLinkToTutorial[num2].MissionItem;
					if ((IntPtr)questID != (IntPtr)missionItem)
					{
						QuestTutorialException[] questCompletedLinkToTutorial2 = _questCompletedLinkToTutorial;
						num2++;
					}
					Client client = default(Client);
					RepeatedField<int> completedFtueEvents_ = client.profile.player_.completedFtueEvents_;
					int itemID = _questCompletedLinkToTutorial[num2].TutorialItem.ItemID;
					bool flag = ((RepeatedField<T>)(object)completedFtueEvents_).Contains((T)itemID);
				}
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x600242F")]
		[Cpp2IlInjected.Address(RVA = "0xE23DC0", Offset = "0xE227C0", VA = "0x180E23DC0")]
		public void OnQuestTrackClicked()
		{
			//Discarded unreachable code: IL_008c
			if (!_questReceived.activeSelf)
			{
				return;
			}
			MissionSlot newMissionSlot = _currentNotif.NewMissionSlot;
			if (newMissionSlot != null && newMissionSlot.IsMissionActive)
			{
				Action<MissionSlot> onQuestTrack = OnQuestTrack;
				if (onQuestTrack != null)
				{
					MissionSlot newMissionSlot2 = _currentNotif.NewMissionSlot;
					onQuestTrack((T)newMissionSlot2);
				}
			}
			if ((long)_hideCoroutine == 0)
			{
				Coroutine showCoroutine = _showCoroutine;
				if (showCoroutine != null)
				{
					StopCoroutine(showCoroutine);
				}
				int _003C_003E1__state = default(int);
				_003CHideQuestStarted_003Ed__100 _003CHideQuestStarted_003Ed__ = new _003CHideQuestStarted_003Ed__100(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CHideQuestStarted_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (_hideCoroutine = StartCoroutine(_003CHideQuestStarted_003Ed__));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002430")]
		[Cpp2IlInjected.Address(RVA = "0xE23360", Offset = "0xE21D60", VA = "0x180E23360")]
		private void InvokeQuestStartedAnim()
		{
			MissionSlot newMissionSlot = _currentNotif.NewMissionSlot;
			if (newMissionSlot != null && newMissionSlot.IsMissionActive)
			{
				Action<MissionSlot> onQuestStartedAnim = OnQuestStartedAnim;
				if (onQuestStartedAnim != null)
				{
					MissionSlot newMissionSlot2 = _currentNotif.NewMissionSlot;
					onQuestStartedAnim((T)newMissionSlot2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002431")]
		[Cpp2IlInjected.Address(RVA = "0xE233D0", Offset = "0xE21DD0", VA = "0x180E233D0")]
		private void InvokeQuestTrackClicked()
		{
			MissionSlot newMissionSlot = _currentNotif.NewMissionSlot;
			if (newMissionSlot != null && newMissionSlot.IsMissionActive)
			{
				Action<MissionSlot> onQuestTrack = OnQuestTrack;
				if (onQuestTrack != null)
				{
					MissionSlot newMissionSlot2 = _currentNotif.NewMissionSlot;
					onQuestTrack((T)newMissionSlot2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002432")]
		[Cpp2IlInjected.Address(RVA = "0xE25B40", Offset = "0xE24540", VA = "0x180E25B40")]
		public QuestBanner()
		{
		}
	}
}
