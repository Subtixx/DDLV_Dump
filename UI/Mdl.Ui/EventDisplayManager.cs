using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200047C")]
	public class EventDisplayManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40016C5")]
		[SerializeField]
		private BattlePassUIGameColors _gameColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016C6")]
		[SerializeField]
		private RectTransform _eventDescriptionContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40016C7")]
		[SerializeField]
		private TextBase _eventDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40016C8")]
		[SerializeField]
		private TextBase _eventTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40016C9")]
		[SerializeField]
		public EventRewardItem _mainReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40016CA")]
		[SerializeField]
		private RectTransform _eventDescriptionHeader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40016CB")]
		[SerializeField]
		private EventTasks _eventTasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40016CC")]
		[SerializeField]
		private EventReward _eventReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40016CD")]
		[SerializeField]
		private RectTransform _rewardListTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40016CE")]
		[SerializeField]
		private RectTransform _header;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40016CF")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40016D0")]
		[SerializeField]
		private TextBase _timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40016D1")]
		[SerializeField]
		private CurrencyContent _currencyContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40016D2")]
		[SerializeField]
		private TextBase _eventCurrencyAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40016D3")]
		[SerializeField]
		private TextBase _eventCurrencyAmountForLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40016D4")]
		[SerializeField]
		private AsyncAtlassedIcon _eventCurrencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40016D5")]
		[SerializeField]
		private AsyncAtlassedIcon _logo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40016D6")]
		[SerializeField]
		private AsyncAtlassedIcon _banner;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40016D7")]
		[SerializeField]
		private CustomButton _btnUnlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40016D8")]
		[SerializeField]
		private CanvasGroup _unlockButtonCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40016D9")]
		[SerializeField]
		private AsyncAtlassedIcon _unlockButtonIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40016DA")]
		[SerializeField]
		private TextBase _unlockButtonAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40016DB")]
		[SerializeField]
		private RectTransform _unlockButtonContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40016DC")]
		[SerializeField]
		private RectTransform _offlineWarningContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40016DD")]
		[SerializeField]
		private TextBase _offlineTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40016DE")]
		[SerializeField]
		private BaseButton _btnConnect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40016DF")]
		[SerializeField]
		private AsyncMenu _getCurrenciesPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40016E0")]
		[SerializeField]
		private AsyncMenu _unlockPremiumPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40016E1")]
		[ItemID]
		[SerializeField]
		private int _defaultCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40016E2")]
		[SerializeField]
		private GameObject _gemGainInfoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40016E3")]
		[SerializeField]
		private GameObject _eventCurrencyGainInfoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40016E4")]
		[SerializeField]
		[Proto("Definitions.BattlePassSeasonData, Meta.Definitions")]
		private string _eventIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40016E5")]
		[SerializeField]
		[Header("EventAsset")]
		private AssetReferenceTexture _eventCurrencyIconRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40016E6")]
		[SerializeField]
		private AssetReferenceTexture _eventCurrencyBuyIconRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40016E7")]
		[SerializeField]
		private AssetReferenceTexture _eventCurrencyGlowRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40016E8")]
		[SerializeField]
		private TMP_SpriteAsset _eventCurrencyTextSpriteRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40016E9")]
		[SerializeField]
		private AssetReferenceTexture _eventPremiumBannerRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40016EA")]
		[SerializeField]
		private AssetReferenceTexture _selectedEventBgRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40016EB")]
		private bool isPremiumUnlocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x149")]
		[Cpp2IlInjected.Token(Token = "0x40016EC")]
		private bool isPremiumBundleBought;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x40016ED")]
		private Item _currencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40016EE")]
		private string _eventCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40016EF")]
		private EventItem _currentEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40016F0")]
		private EventItemSubCategory.SubCategoryType _currentSub;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40016F1")]
		private CancellationToken _ct;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40016F2")]
		private List<bool> _taskCollectedStatus = (List<bool>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40016F3")]
		private List<bool> _rewardCollectedStatus = (List<bool>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40016F4")]
		private int interval = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x40016F5")]
		private float nextTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40016F6")]
		private bool forceUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x189")]
		[Cpp2IlInjected.Token(Token = "0x40016F7")]
		private bool isDisplayingFinishedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40016FA")]
		private int eventCurrencyOwnedDisplayed;

		[Cpp2IlInjected.Token(Token = "0x170004C8")]
		public RectTransform OfflineWarningContainer
		{
			[Cpp2IlInjected.Token(Token = "0x6001D05")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			get
			{
				return _offlineWarningContainer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C9")]
		public BaseButton BtnConnect
		{
			[Cpp2IlInjected.Token(Token = "0x6001D06")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get
			{
				return _btnConnect;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CA")]
		public string EventIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6001D07")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			get
			{
				return _eventIdentifier;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CB")]
		public AssetReferenceTexture SelectedEventBgRef
		{
			[Cpp2IlInjected.Token(Token = "0x6001D08")]
			[Cpp2IlInjected.Address(RVA = "0x975DE0", Offset = "0x9747E0", VA = "0x180975DE0")]
			get
			{
				return _selectedEventBgRef;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CC")]
		public bool IsPremiumUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001D09")]
			[Cpp2IlInjected.Address(RVA = "0xF2CB70", Offset = "0xF2B570", VA = "0x180F2CB70")]
			get
			{
				return isPremiumUnlocked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CD")]
		public BattlePassUIGameColors GameColors
		{
			[Cpp2IlInjected.Token(Token = "0x6001D0A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _gameColors;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CE")]
		public CurrencyContent CurrencyContainer
		{
			[Cpp2IlInjected.Token(Token = "0x6001D0B")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return _currencyContainer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CF")]
		public EventItem CurrentEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001D0C")]
			[Cpp2IlInjected.Address(RVA = "0x738A00", Offset = "0x737400", VA = "0x180738A00")]
			get
			{
				return _currentEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18C"), Cpp2IlInjected.Token(Token = "0x40016F8")]
		public int EventCurrencyOwned
		{
			[Cpp2IlInjected.Token(Token = "0x6001D0D")]
			[Cpp2IlInjected.Address(RVA = "0xF2CB60", Offset = "0xF2B560", VA = "0x180F2CB60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001D0E")]
			[Cpp2IlInjected.Address(RVA = "0xF2CC40", Offset = "0xF2B640", VA = "0x180F2CC40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004D1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x190"), Cpp2IlInjected.Token(Token = "0x40016F9")]
		public bool PendingEventCurrencyAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x6001D0F")]
			[Cpp2IlInjected.Address(RVA = "0xF2CB80", Offset = "0xF2B580", VA = "0x180F2CB80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001D10")]
			[Cpp2IlInjected.Address(RVA = "0xF2CC50", Offset = "0xF2B650", VA = "0x180F2CC50")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004D2")]
		public int EventCurrencyOwnedDisplayed
		{
			[Cpp2IlInjected.Token(Token = "0x6001D11")]
			[Cpp2IlInjected.Address(RVA = "0xA78130", Offset = "0xA76B30", VA = "0x180A78130")]
			get
			{
				return eventCurrencyOwnedDisplayed;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D12")]
			[Cpp2IlInjected.Address(RVA = "0xF2CB90", Offset = "0xF2B590", VA = "0x180F2CB90")]
			set
			{
				//Discarded unreachable code: IL_001e
				eventCurrencyOwnedDisplayed = value;
				TextBase eventCurrencyAmount = _eventCurrencyAmount;
				int num = 0;
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				string text = default(string);
				eventCurrencyAmount.Text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D3")]
		public CustomButton UnlockButton
		{
			[Cpp2IlInjected.Token(Token = "0x6001D13")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return _btnUnlock;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D14")]
		[Cpp2IlInjected.Address(RVA = "0xF2B910", Offset = "0xF2A310", VA = "0x180F2B910")]
		private void Start()
		{
			//Discarded unreachable code: IL_015f
			TextMeshProUGUI textComponent = _eventTitle.TextComponent;
			TextMeshProUGUI textComponent2 = _eventDescription.TextComponent;
			BattlePassUIGameColors gameColors = _gameColors;
			TextMeshProUGUI textComponent3 = _timer.TextComponent;
			BattlePassUIGameColors gameColors2 = _gameColors;
			UnityEvent onClicked = _btnUnlock.OnClicked;
			UnityAction call = OnUnlockClicked;
			onClicked.AddListener(call);
			UnityEvent onHighlighted = _btnUnlock.OnHighlighted;
			UnityAction call2 = OnUnlockHighlighted;
			onHighlighted.AddListener(call2);
			UnityEvent onDehighlighted = _btnUnlock.OnDehighlighted;
			UnityAction call3 = OnUnlockDehighlighted;
			onDehighlighted.AddListener(call3);
			Button.ButtonClickedEvent onClick = _btnConnect.ButtonComponent.m_OnClick;
			UnityAction call4 = OnConnectClicked;
			onClick.AddListener(call4);
			EventReward eventReward = _eventReward;
			EventReward.RewardCollected value = OnRewardCollected;
			eventReward.OnRewardCollected += value;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BattlePassTaskUpdate value2 = OnBattlePassTaskUpdate;
					_003CDispatcher_003Ek__BackingField.OnBattlePassTaskUpdate += value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BattlePassCurrencyChanged value3 = UpdateEventCurrency;
					_003CDispatcher_003Ek__BackingField2.OnBattlePassCurrencyChanged += value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D15")]
		[Cpp2IlInjected.Address(RVA = "0xF29220", Offset = "0xF27C20", VA = "0x180F29220")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0123
			UnityEvent onClicked = _btnUnlock.OnClicked;
			UnityAction call = OnUnlockClicked;
			onClicked.RemoveListener(call);
			UnityEvent onHighlighted = _btnUnlock.OnHighlighted;
			UnityAction call2 = OnUnlockHighlighted;
			onHighlighted.RemoveListener(call2);
			UnityEvent onDehighlighted = _btnUnlock.OnDehighlighted;
			UnityAction call3 = OnUnlockDehighlighted;
			onDehighlighted.RemoveListener(call3);
			Button.ButtonClickedEvent onClick = _btnConnect.ButtonComponent.m_OnClick;
			UnityAction call4 = OnConnectClicked;
			onClick.RemoveListener(call4);
			EventReward eventReward = _eventReward;
			EventReward.RewardCollected value = OnRewardCollected;
			eventReward.OnRewardCollected -= value;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BattlePassTaskUpdate value2 = OnBattlePassTaskUpdate;
					_003CDispatcher_003Ek__BackingField.OnBattlePassTaskUpdate -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BattlePassCurrencyChanged value3 = UpdateEventCurrency;
					_003CDispatcher_003Ek__BackingField2.OnBattlePassCurrencyChanged -= value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D16")]
		[Cpp2IlInjected.Address(RVA = "0xF28F20", Offset = "0xF27920", VA = "0x180F28F20")]
		private void OnBattlePassTaskUpdate(string battlePassOnlineId, BattlePassTaskProgress taskProgress)
		{
			//Discarded unreachable code: IL_00a7
			//IL_002d: Expected O, but got I4
			EventItem currentEvent = _currentEvent;
			int num = 0;
			EventItemSubCategory.SubCategoryType currentSub = _currentSub;
			if ((object)currentEvent != null)
			{
				bool flag = (isDisplayingFinishedEvent = currentEvent.IsFinished());
			}
			int num2 = 0;
			if (currentEvent != (UnityEngine.Object)num2)
			{
				_currentEvent.UpdateRedDotState(EventItemSubCategory.SubCategoryType.Duties);
			}
			if (taskProgress.IsClaimed)
			{
				RetrieveEventCurrencyStatus();
			}
			if (!taskProgress.IsOnGoing)
			{
				return;
			}
			_eventTasks.Reorder();
			int num3 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num4 = 0;
			IMenu top = menuStack.Top;
			if (top == null)
			{
				return;
			}
			int num5 = 0;
			if (top != null)
			{
				int num6 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					int num7 = 0;
					int num8 = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D17")]
		[Cpp2IlInjected.Address(RVA = "0xF28750", Offset = "0xF27150", VA = "0x180F28750")]
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

		[Cpp2IlInjected.Token(Token = "0x6001D18")]
		[Cpp2IlInjected.Address(RVA = "0xF2AA90", Offset = "0xF29490", VA = "0x180F2AA90")]
		public unsafe void RefreshUnlockButton()
		{
			//Discarded unreachable code: IL_0192
			//IL_0012: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			int num = 0;
			EventItem currentEvent = _currentEvent;
			int num2 = 0;
			if (currentEvent == (UnityEngine.Object)num2)
			{
				return;
			}
			Transform transform = _btnUnlock.transform;
			Transform transform2 = _btnUnlock.transform;
			if ((object)transform != null)
			{
			}
			if (_currentSub != EventItemSubCategory.SubCategoryType.Duties || (object)transform != null)
			{
			}
			if (_currentSub == EventItemSubCategory.SubCategoryType.Duties)
			{
			}
			Vector2 v = default(Vector2);
			Vector2 vector = v.WithY(25f);
			ButtonViewDefault view = _btnUnlock.View;
			int num3 = 0;
			if (view != (UnityEngine.Object)num3)
			{
				ButtonViewDefault view2 = _btnUnlock.View;
				if ((object)view2 != null)
				{
					GameObject gameObject = view2.StaticIcon.gameObject;
					bool active = isPremiumUnlocked;
					gameObject.SetActive(active);
				}
				ButtonViewDefault view3 = _btnUnlock.View;
				string stringID = "menu.starpath_unlock_premium";
				if (isPremiumUnlocked)
				{
					stringID = "menu.starpath_get_tokens";
				}
				view3.Label.StringID = stringID;
				TextBase label = _btnUnlock.View.Label;
				if (isPremiumUnlocked)
				{
				}
				label.RectTransform.SetRight(188f);
			}
			GameObject gameObject2 = _unlockButtonContainer.gameObject;
			bool active2 = !isPremiumUnlocked;
			gameObject2.SetActive(active2);
			if (isPremiumUnlocked)
			{
				return;
			}
			EventItem currentEvent2 = _currentEvent;
			TextBase unlockButtonAmount = _unlockButtonAmount;
			int amount_ = currentEvent2.battlePassData.premiumPassPrice_.amount_;
			int num4 = 0;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text = default(string);
			unlockButtonAmount.Text = text;
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item currencyItem = _currencyItem;
				if (_003CInstance_003Ek__BackingField.TryGetItemData(currencyItem, out *(IItemData*)num))
				{
					AsyncAtlassedIcon unlockButtonIcon = _unlockButtonIcon;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D19")]
		[Cpp2IlInjected.Address(RVA = "0xF283B0", Offset = "0xF26DB0", VA = "0x180F283B0")]
		public static string CalculateCountdown(DateTime start, DateTime finished)
		{
			//IL_00b1: Expected O, but got I4
			int num = default(int);
			TimeSpan timeSpan = default(TimeSpan);
			string text = default(string);
			string text2 = default(string);
			string text3 = default(string);
			while (num < 2)
			{
				TimeSpan zero = TimeSpan.Zero;
				if (!(timeSpan > zero))
				{
					return "00:00:00";
				}
				string[] array = new string[5];
				int num2 = 0;
				if (text != null && text == null)
				{
					continue;
				}
				array[0] = text;
				if (":" != null && ":" == null)
				{
					continue;
				}
				array[1] = ":";
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[2] = text2;
				if (":" == null || ":" != null)
				{
					array[3] = ":";
					if (text3 == null || text3 != null)
					{
						array[4] = text3;
						return string.Concat(array);
					}
				}
			}
			int num3 = 0;
			string arg = default(string);
			return string.Format(LocalizationManager.FromStringID("menu.common_time_days", (IResolver)num3), arg);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1A")]
		[Cpp2IlInjected.Address(RVA = "0xF2C680", Offset = "0xF2B080", VA = "0x180F2C680")]
		[IteratorStateMachine(typeof(_003CUpdateEventCurrencyDisplay_003Ed__87))]
		public IEnumerator UpdateEventCurrencyDisplay(float delay = 0f, bool animated = true)
		{
			int _003C_003E1__state = default(int);
			_003CUpdateEventCurrencyDisplay_003Ed__87 _003CUpdateEventCurrencyDisplay_003Ed__ = new _003CUpdateEventCurrencyDisplay_003Ed__87(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateEventCurrencyDisplay_003Ed__._003C_003E4__this = this;
			_003CUpdateEventCurrencyDisplay_003Ed__.delay = delay;
			_003CUpdateEventCurrencyDisplay_003Ed__.animated = animated;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1B")]
		[Cpp2IlInjected.Address(RVA = "0xF29E40", Offset = "0xF28840", VA = "0x180F29E40")]
		private void PlayCurrencyAnimation(bool isEventCurrency = false, int amount = -1, CurrencyType currencyType = CurrencyType.Hard, [System.Runtime.InteropServices.Optional] Action callback)
		{
			//Discarded unreachable code: IL_00e3
			//IL_000f: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			Action callback2 = (Action)0;
			if (base.gameObject.activeInHierarchy)
			{
				_003C_003Ec__DisplayClass88_0 _003C_003Ec__DisplayClass88_;
				GameObject eventCurrencyGainInfoPrefab = default(GameObject);
				if (_003C_003Ec__DisplayClass88_ != null || _003C_003Ec__DisplayClass88_ != null)
				{
					eventCurrencyGainInfoPrefab = _eventCurrencyGainInfoPrefab;
				}
				Transform parent = base.transform;
				GameObject coinGainInfo = UnityEngine.Object.Instantiate(eventCurrencyGainInfoPrefab, parent);
				CurrencyGainInfo component = coinGainInfo.GetComponent<CurrencyGainInfo>();
				UpdateCoinIcons(component);
				Action<object> action = (Action<object>)(object)(Action<T>)delegate
				{
					//Discarded unreachable code: IL_0028
					UnityEngine.Object.Destroy(coinGainInfo.gameObject);
					callback2?.Invoke();
				};
				Action<object> action2 = (Action<object>)(object)new Action<T>(((_003C_003Ec__DisplayClass88_0)(object)eventCurrencyGainInfoPrefab)._003CPlayCurrencyAnimation_003Eb__1);
				RectTransform rectTransform = _eventCurrencyIcon.RawImage.rectTransform;
				int num = 0;
				CurrencyContent currencyContainer = _currencyContainer;
				component.Init(CurrencyGainCurrencyType.SoftCurrency, CurrencyGainAnimationType.PickupAnimation, (Action<>)(object)action, (Action<>)(object)action2, (RectTransform)num, amount, currencyContainer);
				if ((long)currencyContainer.CurrencyItems != 0)
				{
					PendingEventCurrencyAnimation = false;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1C")]
		[Cpp2IlInjected.Address(RVA = "0xF2B6F0", Offset = "0xF2A0F0", VA = "0x180F2B6F0")]
		public void SetFocus(FocusNavigation focusNav)
		{
			//Discarded unreachable code: IL_0095
			//IL_003b: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			if (!_offlineWarningContainer.gameObject.activeInHierarchy)
			{
				EventItemSubCategory.SubCategoryType currentSub = _currentSub;
				if (currentSub != 0)
				{
					switch (currentSub)
					{
					case EventItemSubCategory.SubCategoryType.Duties:
					{
						FocusNavigationElement componentInChildren2 = _eventReward.GetComponentInChildren<FocusNavigationElement>();
						int num2 = 0;
						if (componentInChildren2 != (UnityEngine.Object)num2)
						{
							_eventReward.SetFocus(focusNav);
							return;
						}
						break;
					}
					default:
						return;
					case EventItemSubCategory.SubCategoryType.Description:
					{
						FocusNavigationElement componentInChildren = _eventTasks.GetComponentInChildren<FocusNavigationElement>();
						int num = 0;
						if (componentInChildren != (UnityEngine.Object)num)
						{
							_eventTasks.SetFocus(focusNav);
							return;
						}
						break;
					}
					}
				}
				_currentEvent.SetFocus(focusNav);
			}
			else
			{
				FocusNavigationElement component = _btnConnect.GetComponent<FocusNavigationElement>();
				focusNav.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1D")]
		[Cpp2IlInjected.Address(RVA = "0xF2C7D0", Offset = "0xF2B1D0", VA = "0x180F2C7D0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0121
			//IL_0010: Expected O, but got I4
			//IL_00a5: Expected O, but got I4
			EventItem currentEvent = _currentEvent;
			int num = 0;
			if (!(currentEvent != (UnityEngine.Object)num))
			{
				return;
			}
			int num2 = 0;
			float time = Time.time;
			_timer.Text = "";
			Client client = default(Client);
			DateTime serverTime = client.ServerTime;
			if (!_currentEvent.IsFinished())
			{
				EventItem currentEvent2 = _currentEvent;
				int checkScheduledEvents = 0;
				bool flag = currentEvent2.IsStarted((byte)checkScheduledEvents != 0);
				EventItem currentEvent3 = _currentEvent;
				if (flag)
				{
					DateTime finished = currentEvent3.battlePassData.finishDate_.date_.ToDateTime();
					string text = CalculateCountdown(serverTime, finished);
					TextBase timer = _timer;
					int num3 = 0;
					string text3 = (timer.Text = LocalizationManager.FromStringID("menu.common_timer_ends_in", (IResolver)num3) + text);
				}
				DateTime finished2 = currentEvent3.battlePassData.startDate_.date_.ToDateTime();
				string text4 = CalculateCountdown(serverTime, finished2);
			}
			_timer.StringID = "menu.starpath_event_ended_label";
			if (!isDisplayingFinishedEvent)
			{
				EventItemSubCategory.SubCategoryType currentSub = _currentSub;
				int refreshCurrencyStatus = 0;
				EventItem currentEvent4 = _currentEvent;
				RefreshTask(currentEvent4, currentSub, (byte)refreshCurrencyStatus != 0);
				isDisplayingFinishedEvent = true;
			}
			nextTime = time;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1E")]
		[Cpp2IlInjected.Address(RVA = "0xF29690", Offset = "0xF28090", VA = "0x180F29690")]
		private unsafe void OnRewardCollected(IItemData itemData, int amount)
		{
			//Discarded unreachable code: IL_0074
			//IL_0073: Expected I4, but got I8
			//IL_0073: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Currency && (IntPtr)(void*)(int)itemType == (IntPtr)_currencyItem)
			{
				int num2 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				Action action = delegate
				{
					//Discarded unreachable code: IL_0013
					RefreshEventMenu();
					_currencyContainer.RefreshAllCurrencies();
				};
			}
			RefreshEventMenu();
			NewItemPopUp.NewItemPopupParam newItemPopupParam = new NewItemPopUp.NewItemPopupParam();
			NewItemPopUp.NewItem item = default(NewItemPopUp.NewItem);
			((List<T>)(object)newItemPopupParam.Items).Add((T)item);
			int num3 = 0;
			newItemPopupParam.UsePopupStack = true;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuNewItem, newItemPopupParam, (PlayerTaskCollider)num4, (ItemFilterData)num, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num != 0, (byte)num5 != 0);
			[Cpp2IlInjected.Token(Token = "0x6001D39")]
			[Cpp2IlInjected.Address(RVA = "0xF2BF90", Offset = "0xF2A990", VA = "0x180F2BF90")]
			void RefreshEventMenu()
			{
				//Discarded unreachable code: IL_0067
				RetrieveEventCurrencyStatus();
				EventItem currentEvent = _currentEvent;
				EventReward eventReward = _eventReward;
				BattlePassSeasonData battlePassData = currentEvent.battlePassData;
				eventReward.Refresh(battlePassData);
				int num6 = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				int num7 = 0;
				IMenu top = menuStack.Top;
				if (top != null)
				{
					int num8 = 0;
					if (top != null)
					{
						int num9 = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
						{
							int num10 = 0;
						}
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1F")]
		[Cpp2IlInjected.Address(RVA = "0xF29930", Offset = "0xF28330", VA = "0x180F29930")]
		private void OnRewardItemCollected(IItemData itemData, int amount)
		{
			//Discarded unreachable code: IL_004a
			//IL_0049: Expected I4, but got I8
			//IL_0049: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			NewItemPopUp.NewItemPopupParam newItemPopupParam = new NewItemPopUp.NewItemPopupParam();
			NewItemPopUp.NewItem item = default(NewItemPopUp.NewItem);
			((List<T>)(object)newItemPopupParam.Items).Add((T)item);
			int num = 0;
			newItemPopupParam.UsePopupStack = true;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuNewItem, newItemPopupParam, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D20")]
		[Cpp2IlInjected.Address(RVA = "0xF2A3D0", Offset = "0xF28DD0", VA = "0x180F2A3D0")]
		private void RefreshEventCurrencyDisplay()
		{
			//Discarded unreachable code: IL_0017
			TextBase eventCurrencyAmount = _eventCurrencyAmount;
			int num = 0;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text = default(string);
			eventCurrencyAmount.Text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D21")]
		[Cpp2IlInjected.Address(RVA = "0xF29A90", Offset = "0xF28490", VA = "0x180F29A90")]
		private void OnTaskCollected()
		{
			//Discarded unreachable code: IL_004d
			_eventTasks.Reorder();
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top == null)
			{
				return;
			}
			int num3 = 0;
			if (top != null)
			{
				int num4 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					int num5 = 0;
					int num6 = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D22")]
		[Cpp2IlInjected.Address(RVA = "0xF2B000", Offset = "0xF29A00", VA = "0x180F2B000")]
		internal void RetrieveEventCurrencyStatus()
		{
			//Discarded unreachable code: IL_00b3
			//IL_0010: Expected O, but got I4
			EventItem currentEvent = _currentEvent;
			int num = 0;
			if (currentEvent == (UnityEngine.Object)num)
			{
				return;
			}
			BattlePassStatesData battlePassStates_ = SystemRoot.Instance.MetaClient.profile.player_.battlePassStates_;
			BattlePassSeasonData battlePassData = _currentEvent.battlePassData;
			MapField<string, BattlePassProgress> progress_ = battlePassStates_.progress_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			EventCurrencyOwned = (flag ? 1 : 0);
			isPremiumUnlocked = flag;
			List<bool> rewardCollectedStatus = _rewardCollectedStatus;
			isPremiumBundleBought = flag;
			((List<T>)(object)rewardCollectedStatus).Clear();
			((List<T>)(object)_taskCollectedStatus).Clear();
			List<bool> rewardCollectedStatus2 = _rewardCollectedStatus;
			List<bool> taskCollectedStatus = _taskCollectedStatus;
			if (_003C_003Ec._003C_003E9__95_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassTaskProgress x) => x.IsClaimed);
			}
			IEnumerable<BattlePassTaskProgress> enumerable = default(IEnumerable<BattlePassTaskProgress>);
			((List<T>)(object)taskCollectedStatus).AddRange((IEnumerable<>)enumerable);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D23")]
		[Cpp2IlInjected.Address(RVA = "0xF2C720", Offset = "0xF2B120", VA = "0x180F2C720")]
		public void UpdateEventCurrency(int gained, InvActionType reason, BattlePassActionType action)
		{
			//Discarded unreachable code: IL_0022, IL_0032
			//IL_0018: Expected I4, but got I8
			//IL_0018: Expected F4, but got I4
			if (base.gameObject.activeInHierarchy)
			{
				int num = 0;
				ulong num2 = default(ulong);
				IEnumerator routine = UpdateEventCurrencyDisplay(num, (byte)num2 != 0);
				Coroutine coroutine = StartCoroutine(routine);
			}
			else
			{
				while (gained <= 0)
				{
				}
				PendingEventCurrencyAnimation = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D24")]
		[Cpp2IlInjected.Address(RVA = "0xF28D90", Offset = "0xF27790", VA = "0x180F28D90")]
		public bool GetRewardCollectedStatus(int pageIndex, int rewardIndex)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001D25")]
		[Cpp2IlInjected.Address(RVA = "0xF28E50", Offset = "0xF27850", VA = "0x180F28E50")]
		public bool GetTaskCollectedStatus(BattlePassTask task)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001D26")]
		[Cpp2IlInjected.Address(RVA = "0xF2B8D0", Offset = "0xF2A2D0", VA = "0x180F2B8D0")]
		public static void SetupPlayfabString(TextBase text, string stringID)
		{
			//Discarded unreachable code: IL_0012
			//IL_0009: Expected O, but got I4
			int num = 0;
			string text3 = (text.Text = LocalizationManager.FromStringID(stringID, (IResolver)num));
		}

		[Cpp2IlInjected.Token(Token = "0x6001D27")]
		[Cpp2IlInjected.Address(RVA = "0xF2C470", Offset = "0xF2AE70", VA = "0x180F2C470")]
		private unsafe void UpdateCoinIcons(CurrencyGainInfo currencyGainInfo)
		{
			//Discarded unreachable code: IL_0067
			//IL_0051: Expected O, but got I4
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item currencyItem = _currencyItem;
			if (!_003CInstance_003Ek__BackingField.TryGetItemData(currencyItem, out *(IItemData*)num))
			{
				return;
			}
			RectTransform[] coins = currencyGainInfo._coins;
			int length = coins.Length;
			if (num < length)
			{
				RectTransform rectTransform = coins[num];
				AsyncAtlassedIcon component = rectTransform.gameObject.GetComponent<AsyncAtlassedIcon>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					AsyncAtlassedIcon component2 = rectTransform.gameObject.GetComponent<AsyncAtlassedIcon>();
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D28")]
		[Cpp2IlInjected.Address(RVA = "0xF2B380", Offset = "0xF29D80", VA = "0x180F2B380")]
		private void RetrieveEventData()
		{
			//Discarded unreachable code: IL_0150
			//IL_0010: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_00c7: Expected O, but got I8
			//IL_00e1: Expected O, but got I8
			//IL_014f: Expected I4, but got I8
			//IL_014f: Expected I4, but got I8
			//IL_014f: Expected I4, but got I8
			//IL_014f: Expected I4, but got I8
			//IL_014f: Expected I4, but got I8
			//IL_014f: Expected I4, but got I8
			EventItem currentEvent = _currentEvent;
			int num = 0;
			if (!(currentEvent == (UnityEngine.Object)num))
			{
				string description_ = _currentEvent.battlePassData.description_;
				TextBase eventDescription = _eventDescription;
				int num2 = 0;
				string text2 = (eventDescription.Text = LocalizationManager.FromStringID(description_, (IResolver)num2));
				string title_ = _currentEvent.battlePassData.title_;
				TextBase eventTitle = _eventTitle;
				int num3 = 0;
				string text4 = (eventTitle.Text = LocalizationManager.FromStringID(title_, (IResolver)num3));
				_eventDescription.RectTransform.parent.RebuildLayout();
				string text5 = (_eventCurrency = _currentEvent.battlePassData.currencyName_);
				long num4 = Convert.ToInt64((uint)_currentEvent.battlePassData.premiumPassPrice_.id_);
				_currencyItem = (Item)num4;
				ItemType itemType = default(ItemType);
				if (itemType != ItemType.Currency)
				{
					long num5 = Convert.ToInt64((uint)_defaultCurrency);
					_currencyItem = (Item)num5;
				}
				CurrencyContent currencyContainer = _currencyContainer;
				int[] array = (currencyContainer.CurrencyItems = (int[])(object)new List<T>().ToArray());
				_currencyContainer.AutomaticRefresh = false;
				RetrieveEventCurrencyStatus();
				BattlePassReward mainReward = _currentEvent.battlePassData.GetMainReward();
				if (mainReward != null)
				{
					EventRewardItem mainReward2 = _mainReward;
					BattlePassUIGameColors gameColors = _gameColors;
					ulong num6 = default(ulong);
					ulong num7 = default(ulong);
					ulong num8 = default(ulong);
					ulong num9 = default(ulong);
					ulong num10 = default(ulong);
					ulong num11 = default(ulong);
					mainReward2.Init(-1, mainReward, gameColors, (byte)num6 != 0, (byte)num7 != 0, (byte)num8 != 0, (byte)num9 != 0, (byte)num10 != 0, (int)num11);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D29")]
		[Cpp2IlInjected.Address(RVA = "0xF2AF70", Offset = "0xF29970", VA = "0x180F2AF70")]
		public void Refresh(EventItem eventItem, EventItemSubCategory.SubCategoryType type, bool refreshCurrencyStatus = false)
		{
			if ((object)eventItem != null)
			{
				bool flag = (isDisplayingFinishedEvent = eventItem.IsFinished());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2A")]
		[Cpp2IlInjected.Address(RVA = "0xF2A350", Offset = "0xF28D50", VA = "0x180F2A350")]
		public void RefreshCurrencies(bool animated = true)
		{
			//Discarded unreachable code: IL_0036
			//IL_001c: Expected F4, but got I4
			_currencyContainer.RefreshAllCurrencies(animated);
			RetrieveEventCurrencyStatus();
			int num = 0;
			IEnumerator routine = UpdateEventCurrencyDisplay(num, animated);
			Coroutine coroutine = StartCoroutine(routine);
			_currencyContainer.transform.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2B")]
		[Cpp2IlInjected.Address(RVA = "0xF2A490", Offset = "0xF28E90", VA = "0x180F2A490")]
		public void RefreshTask(EventItem eventItem, EventItemSubCategory.SubCategoryType type, bool refreshCurrencyStatus = false)
		{
			//Discarded unreachable code: IL_0291
			//IL_004e: Expected I4, but got I8
			//IL_014c: Expected I4, but got I8
			//IL_0177: Expected I4, but got I8
			//IL_01b7: Expected I4, but got I8
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag && !flag2 && forceUpdate == flag2)
			{
				if (!refreshCurrencyStatus)
				{
					goto IL_002a;
				}
				RetrieveEventCurrencyStatus();
			}
			_currentEvent = eventItem;
			RetrieveEventData();
			goto IL_002a;
			IL_0230:
			bool flag3 = default(bool);
			if (!flag3)
			{
				GameObject gameObject = _btnUnlock.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			FocusNavigationElement component = _btnUnlock.gameObject.GetComponent<FocusNavigationElement>();
			bool flag4 = (component.IgnoreThis = !_btnUnlock.gameObject.activeInHierarchy);
			int num;
			forceUpdate = (byte)num != 0;
			if ((PendingEventCurrencyAnimation ? 1 : 0) == num)
			{
			}
			return;
			IL_002a:
			if (!_header.gameObject.activeSelf)
			{
				ulong num2 = default(ulong);
				_header.gameObject.SetActive((byte)num2 != 0);
			}
			CurrencyContent currencyContainer = _currencyContainer;
			Item currencyItem = _currencyItem;
			int num3 = Enumerable.FirstOrDefault<int>((IEnumerable<>)(object)currencyContainer.CurrencyItems);
			if ((IntPtr)currencyItem == (IntPtr)num3)
			{
				CurrencyContent currencyContainer2 = _currencyContainer;
				int num4 = 0;
				if ((currencyContainer2.IsVisible ? 1 : 0) != num4)
				{
					currencyContainer2.RefreshDisplay();
				}
				currencyContainer2.Show();
			}
			_currentSub = type;
			RefreshUnlockButton();
			num = 0;
			if (type != 0)
			{
				if (type != 0)
				{
					if (type != EventItemSubCategory.SubCategoryType.Duties)
					{
						goto IL_0230;
					}
					GameObject gameObject2 = _eventDescriptionContainer.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
					GameObject gameObject3 = _eventTasks.gameObject;
					int active3 = 0;
					gameObject3.SetActive((byte)active3 != 0);
					_eventReward.gameObject.SetActive((byte)type != 0);
					_logo.gameObject.SetActive((byte)type != 0);
					EventReward eventReward = _eventReward;
					GameObject gameObject4 = _btnUnlock.gameObject;
				}
				GameObject gameObject5 = _eventDescriptionContainer.gameObject;
				int active4 = 0;
				gameObject5.SetActive((byte)active4 != 0);
				ulong num5 = default(ulong);
				_eventTasks.gameObject.SetActive((byte)num5 != 0);
				GameObject gameObject6 = _eventReward.gameObject;
				int active5 = 0;
				gameObject6.SetActive((byte)active5 != 0);
				ulong num6 = default(ulong);
				_logo.gameObject.SetActive((byte)num6 != 0);
				EventTasks eventTasks = _eventTasks;
				GameObject gameObject7 = _btnUnlock.gameObject;
				if ((isPremiumUnlocked ? 1 : 0) == num && (_eventTasks.isAllTaskFinished ? 1 : 0) != num)
				{
				}
			}
			ulong num7 = default(ulong);
			_eventDescriptionContainer.gameObject.SetActive((byte)num7 != 0);
			_eventDescription.RectTransform.parent.RebuildLayout();
			GameObject gameObject8 = _eventTasks.gameObject;
			int active6 = 0;
			gameObject8.SetActive((byte)active6 != 0);
			GameObject gameObject9 = _eventReward.gameObject;
			int active7 = 0;
			gameObject9.SetActive((byte)active7 != 0);
			GameObject gameObject10 = _logo.gameObject;
			int active8 = 0;
			gameObject10.SetActive((byte)active8 != 0);
			GameObject gameObject11 = _btnUnlock.gameObject;
			int active9 = 0;
			gameObject11.SetActive((byte)active9 != 0);
			goto IL_0230;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2C")]
		[Cpp2IlInjected.Address(RVA = "0xF29DB0", Offset = "0xF287B0", VA = "0x180F29DB0")]
		private void OnUnlockDehighlighted()
		{
			//Discarded unreachable code: IL_0028
			_btnUnlock.View?.Background?.SetAlpha(1f);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2D")]
		[Cpp2IlInjected.Address(RVA = "0xF29E00", Offset = "0xF28800", VA = "0x180F29E00")]
		private void OnUnlockHighlighted()
		{
			//Discarded unreachable code: IL_0026
			//IL_0024: Expected F4, but got I4
			ButtonViewDefault view = _btnUnlock.View;
			if ((object)view != null)
			{
				ImageHelper background = view.Background;
				if ((object)background != null)
				{
					int num = 0;
					background.SetAlpha(num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2E")]
		[Cpp2IlInjected.Address(RVA = "0xF29B70", Offset = "0xF28570", VA = "0x180F29B70")]
		private void OnUnlockClicked()
		{
			if (!isPremiumUnlocked)
			{
				int num = 0;
			}
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2F")]
		[Cpp2IlInjected.Address(RVA = "0xF29100", Offset = "0xF27B00", VA = "0x180F29100")]
		private void OnConnectClicked()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D30")]
		[Cpp2IlInjected.Address(RVA = "0xF2A150", Offset = "0xF28B50", VA = "0x180F2A150")]
		internal void RefreshConnection(OnlineClient.OnlineStatus currentOnlineStatus)
		{
			//Discarded unreachable code: IL_00ac
			//IL_0016: Expected F4, but got I4
			//IL_009a: Expected O, but got I4
			CanvasGroup canvasGroup = _canvasGroup;
			bool flag = default(bool);
			if (flag)
			{
			}
			int num = 0;
			canvasGroup.alpha = num;
			CanvasGroup canvasGroup2 = _canvasGroup;
			canvasGroup2.blocksRaycasts = flag;
			canvasGroup2.interactable = flag;
			CanvasGroup unlockButtonCanvasGroup = _unlockButtonCanvasGroup;
			unlockButtonCanvasGroup.blocksRaycasts = flag;
			unlockButtonCanvasGroup.interactable = flag;
			GameObject gameObject = _offlineWarningContainer.gameObject;
			bool active = !flag;
			gameObject.SetActive(active);
			TextBase offlineTitle = _offlineTitle;
			string onlineStatusSourceNameForLoc = SystemRoot.Instance.MetaOnlineClient.GetOnlineStatusSourceNameForLoc();
			string stringID = "menu.starpath_offline_" + onlineStatusSourceNameForLoc + "_title";
			int num2 = 0;
			string text2 = (offlineTitle.Text = LocalizationManager.FromStringID(stringID, (IResolver)num2));
			RetrieveEventCurrencyStatus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D31")]
		[Cpp2IlInjected.Address(RVA = "0xF28920", Offset = "0xF27320", VA = "0x180F28920")]
		public void CustomEventsFindNext(FocusDirection direction, int input, FocusNavigationElement element, ISupportsFocusNavigation supportFocusNav)
		{
			//Discarded unreachable code: IL_0037
			//IL_0033: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num2 = 0;
				EventsMenu menu = UiRoot.Instance._menuStack.GetMenu<EventsMenu>();
				int num3 = 0;
				if (!(menu != (UnityEngine.Object)num3))
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D32")]
		[Cpp2IlInjected.Address(RVA = "0xF28C70", Offset = "0xF27670", VA = "0x180F28C70")]
		[AsyncStateMachine(typeof(_003CGetCurrenciesTask_003Ed__111))]
		private Task GetCurrenciesTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D33")]
		[Cpp2IlInjected.Address(RVA = "0xF28A20", Offset = "0xF27420", VA = "0x180F28A20")]
		private Task<int> GetCurrenciesPopupTask(CancellationToken ct)
		{
			//Discarded unreachable code: IL_010e
			TaskCompletionSource<int> tcs = (TaskCompletionSource<int>)(object)new TaskCompletionSource<TResult>();
			GetCurrenciesPopup.GetCurrenciesParam getCurrenciesParam = new GetCurrenciesPopup.GetCurrenciesParam();
			BattlePassSeasonData battlePassSeasonData = (getCurrenciesParam.BattlePassData = _currentEvent.battlePassData);
			int num = (getCurrenciesParam.CurrentEventCurrencyAmount = EventCurrencyOwned);
			bool flag = (getCurrenciesParam.ShouldDisplayBundle = !isPremiumBundleBought);
			Item item = (getCurrenciesParam.CurrencyToUse = _currencyItem);
			string text = (getCurrenciesParam.EventCurrency = _eventCurrency);
			getCurrenciesParam.IsEventCurrencyPopup = true;
			BattlePassUIGameColors battlePassUIGameColors = (getCurrenciesParam.ColorConfig = _gameColors);
			bool flag2 = (getCurrenciesParam.IsNewestEvent = _currentEvent._isNewestEvent);
			AssetReferenceTexture assetReferenceTexture = (getCurrenciesParam.BuyIconRef = _eventCurrencyBuyIconRef);
			AssetReferenceTexture assetReferenceTexture2 = (getCurrenciesParam.IconRef = _eventCurrencyIconRef);
			AssetReferenceTexture assetReferenceTexture3 = (getCurrenciesParam.GlowRef = _eventCurrencyGlowRef);
			Action<int> action = (getCurrenciesParam.AnswerAction = (Action<int>)(object)(Action<T>)delegate(int answer)
			{
				//Discarded unreachable code: IL_000e
				//IL_000c: Expected O, but got I4
				bool flag3 = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)answer);
			});
			int num2 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			AsyncMenu getCurrenciesPopup = _getCurrenciesPopup;
			popupStack.Push(getCurrenciesPopup, getCurrenciesParam);
			return (Task<int>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D34")]
		[Cpp2IlInjected.Address(RVA = "0xF2C350", Offset = "0xF2AD50", VA = "0x180F2C350")]
		[AsyncStateMachine(typeof(_003CUnlockPremiumTask_003Ed__113))]
		private Task UnlockPremiumTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D35")]
		[Cpp2IlInjected.Address(RVA = "0xF2C090", Offset = "0xF2AA90", VA = "0x180F2C090")]
		private Task<int> UnlockPremiumPopupTask(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0131
			//IL_00ee: Expected I4, but got I8
			TaskCompletionSource<int> tcs = (TaskCompletionSource<int>)(object)new TaskCompletionSource<TResult>();
			UnlockPremiumContent.UnlockPremiumParam unlockPremiumParam = new UnlockPremiumContent.UnlockPremiumParam();
			BattlePassSeasonData battlePassData = _currentEvent.battlePassData;
			BattlePassSeasonData.Types.Price premiumPassPrice_ = battlePassData.premiumPassPrice_;
			int num = (unlockPremiumParam.UnlockPlusPrice = battlePassData.currencyBundlePrice_.amount_);
			int num2 = (unlockPremiumParam.UnlockPrice = _currentEvent.battlePassData.premiumPassPrice_.amount_);
			int num3 = (unlockPremiumParam.Offer = _currentEvent.battlePassData.currencyBundleAmount_);
			Item item = (unlockPremiumParam.Currency = _currencyItem);
			string text = (unlockPremiumParam.EventCurrency = _eventCurrency);
			BattlePassSeasonData battlePassSeasonData = (unlockPremiumParam.BattlePassData = _currentEvent.battlePassData);
			bool flag = (unlockPremiumParam.IsNewestEvent = _currentEvent._isNewestEvent);
			AssetReferenceTexture assetReferenceTexture = (unlockPremiumParam.BannerRef = _eventPremiumBannerRef);
			TMP_SpriteAsset tMP_SpriteAsset = (unlockPremiumParam.CurrencyIconTextRef = _eventCurrencyTextSpriteRef);
			unlockPremiumParam.DisplayState = UnlockPremiumContent.UnlockPremiumParam.UnlockPremiumDisplayState.UnlockPremiumPopup;
			Action<int> action = (unlockPremiumParam.AnswerAction = (Action<int>)(object)(Action<T>)delegate(int answer)
			{
				//Discarded unreachable code: IL_000e
				//IL_000c: Expected O, but got I4
				bool flag2 = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)answer);
			});
			int num4 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			AsyncMenu unlockPremiumPopup = _unlockPremiumPopup;
			popupStack.Push(unlockPremiumPopup, unlockPremiumParam);
			return (Task<int>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D36")]
		[Cpp2IlInjected.Address(RVA = "0xF2AFE0", Offset = "0xF299E0", VA = "0x180F2AFE0")]
		public void ReorderTask()
		{
			//Discarded unreachable code: IL_000c
			_eventTasks.Reorder();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D37")]
		[Cpp2IlInjected.Address(RVA = "0xF2A470", Offset = "0xF28E70", VA = "0x180F2A470")]
		public void RefreshRewardPreview()
		{
			//Discarded unreachable code: IL_000c
			_eventReward.RefreshRewardPreview();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D38")]
		[Cpp2IlInjected.Address(RVA = "0xF2CAA0", Offset = "0xF2B4A0", VA = "0x180F2CAA0")]
		public EventDisplayManager()
		{
		}//IL_0023: Expected I4, but got I8

	}
}
