using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Definitions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Systems;
using Meta.Online;
using Meta.Util;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200070C")]
	public class StartMenu : Menu, IHasRedirectionHandler
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200070D")]
		public class PhaseEvents
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40028B1")]
			public UnityEvent OnIntro;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40028B2")]
			public UnityEvent OnIntroEnd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40028B3")]
			public UnityEvent OnMain;

			[Cpp2IlInjected.Token(Token = "0x6002D0A")]
			[Cpp2IlInjected.Address(RVA = "0x10E7710", Offset = "0x10E6110", VA = "0x1810E7710")]
			public void Init(Dictionary<Phase, UnityEvent> dictPhase)
			{
				//Discarded unreachable code: IL_0006, IL_000c, IL_001d
				//IL_001c: Expected O, but got I4
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6002D0B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PhaseEvents()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200070E")]
		public enum Phase
		{
			[Cpp2IlInjected.Token(Token = "0x40028B5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40028B6")]
			Start,
			[Cpp2IlInjected.Token(Token = "0x40028B7")]
			Intro,
			[Cpp2IlInjected.Token(Token = "0x40028B8")]
			PressAnyButton,
			[Cpp2IlInjected.Token(Token = "0x40028B9")]
			IntroEnd,
			[Cpp2IlInjected.Token(Token = "0x40028BA")]
			Main
		}

		[Cpp2IlInjected.Token(Token = "0x4002886")]
		private const int PlatformUsernameMaxLength = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002887")]
		public GameObject _start;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002888")]
		public GameObject _mainMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002889")]
		[SerializeField]
		private GameObject _blackScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400288A")]
		[SerializeField]
		private TextMeshProUGUI _pressAnyButtonLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400288B")]
		[SerializeField]
		private StartTabButton _newGameButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400288C")]
		[SerializeField]
		private StartTabButton _continueGameButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400288D")]
		[SerializeField]
		private StartTabButton _linkAccountGameButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400288E")]
		[SerializeField]
		private StartTabButton _downloadableContentButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400288F")]
		[SerializeField]
		private StartTabButton _roadmapButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002890")]
		[SerializeField]
		private StartTabButton _exitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002891")]
		[SerializeField]
		private GameObject _backShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002892")]
		[SerializeField]
		private ShortcutIndicator _platformUserShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002893")]
		[SerializeField]
		private TextBase _platformUsernameLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002894")]
		[SerializeField]
		private AK.Wwise.Event _onPressedAnyKeySfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002895")]
		[SerializeField]
		private CanvasGroup _platformUserCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002896")]
		[SerializeField]
		[Header("Delay before the cutscene start - in second")]
		private float _cutsceneDelay = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4002897")]
		[SerializeField]
		[Header("Delay to prevent false input when coming back from the cutscene - in second")]
		private float _returnDelay = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002898")]
		private Coroutine _cutsceneCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002899")]
		private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400289A")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400289B")]
		private StartTabButton _selectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400289C")]
		[SerializeField]
		private Phase _currentPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400289D")]
		public Dictionary<Phase, UnityEvent> _dictPhase = (Dictionary<Phase, UnityEvent>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400289E")]
		[SerializeField]
		public PhaseEvents _phaseEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400289F")]
		[SerializeField]
		private AK.Wwise.Event _newGameSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40028A0")]
		[SerializeField]
		private AK.Wwise.Event _continueGameSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40028A1")]
		[SerializeField]
		private GameObject _copyrightObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40028A2")]
		[SerializeField]
		private CanvasGroup _copyrightContentCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40028A3")]
		[SerializeField]
		private float _intervalSeconds = 1.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40028A4")]
		[SerializeField]
		private float _fadeSeconds = 1.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40028A5")]
		[SerializeField]
		[Header("Title icons")]
		private Sprite _defaultTitleSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40028A6")]
		[SerializeField]
		private Sprite _jpTitleSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40028A7")]
		[SerializeField]
		private Sprite _chTitleSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40028A8")]
		[SerializeField]
		private Image[] _titleImages;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40028A9")]
		[SerializeField]
		private RectTransform _titleTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40028AA")]
		[SerializeField]
		private float _jpSubTopOffset = 100f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40028AB")]
		[SerializeField]
		private float _chSubTopOffset = 80f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40028AC")]
		private bool _isInCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E1")]
		[Cpp2IlInjected.Token(Token = "0x40028AD")]
		private bool _doneInitialShow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E2")]
		[Cpp2IlInjected.Token(Token = "0x40028AE")]
		private bool _inReturnDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E3")]
		[Cpp2IlInjected.Token(Token = "0x40028AF")]
		private bool _isSignInPopupShowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40028B0")]
		private Coroutine _startingCoroutine;

		[Cpp2IlInjected.Token(Token = "0x1700067C")]
		public static StartMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD6")]
			[Cpp2IlInjected.Address(RVA = "0x862DA0", Offset = "0x8617A0", VA = "0x180862DA0")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CD7")]
			[Cpp2IlInjected.Address(RVA = "0x862EF0", Offset = "0x8618F0", VA = "0x180862EF0")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067D")]
		public new CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD8")]
			[Cpp2IlInjected.Address(RVA = "0x862D70", Offset = "0x861770", VA = "0x180862D70")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067E")]
		public new FocusNavigation FocusNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD9")]
			[Cpp2IlInjected.Address(RVA = "0x738EC0", Offset = "0x7378C0", VA = "0x180738EC0")]
			get
			{
				return _focusNavigation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067F")]
		public StartTabButton SelectedTab
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDA")]
			[Cpp2IlInjected.Address(RVA = "0x738C10", Offset = "0x737610", VA = "0x180738C10")]
			get
			{
				return _selectedTab;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000680")]
		private static Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDB")]
			[Cpp2IlInjected.Address(RVA = "0x862DE0", Offset = "0x8617E0", VA = "0x180862DE0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000681")]
		private ProfileConflictResolver MetaProfileConflictResolver
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDC")]
			[Cpp2IlInjected.Address(RVA = "0x862E90", Offset = "0x861890", VA = "0x180862E90")]
			get
			{
				int num = 0;
				Client metaClient = MetaClient;
				if (metaClient != null)
				{
					OnlineClient _003COnlineClient_003Ek__BackingField = metaClient.OnlineClient;
					if (_003COnlineClient_003Ek__BackingField != null)
					{
						return _003COnlineClient_003Ek__BackingField.profileConflictResolver;
					}
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000682")]
		private static ProfileConflictUIHandler ProfileConflictUIHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDD")]
			[Cpp2IlInjected.Address(RVA = "0x862EC0", Offset = "0x8618C0", VA = "0x180862EC0")]
			get
			{
				UiRoot instance;
				do
				{
					int num = 0;
					instance = UiRoot.Instance;
				}
				while ((object)instance == null);
				return instance._profileConflictUIHandler;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CDE")]
		[Cpp2IlInjected.Address(RVA = "0x8600B0", Offset = "0x85EAB0", VA = "0x1808600B0")]
		public void Awake()
		{
			Instance = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CDF")]
		[Cpp2IlInjected.Address(RVA = "0x862920", Offset = "0x861320", VA = "0x180862920")]
		private void Update()
		{
			if (_currentPhase == Phase.PressAnyButton || _isInCutscene)
			{
				int num = 0;
				if (Input.anyKeyDown)
				{
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE0")]
		[Cpp2IlInjected.Address(RVA = "0x861540", Offset = "0x85FF40", VA = "0x180861540", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0033
			PhaseEvents phaseEvents = _phaseEvents;
			Dictionary<Phase, UnityEvent> dictPhase = _dictPhase;
			phaseEvents.Init((Dictionary<, >)(object)dictPhase);
			SetPhase(Phase.Start);
			RefreshGameTitle();
			base.OnPush(stack, param);
			int num = 0;
			bool flag = UILocalStorage.Load();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE1")]
		[Cpp2IlInjected.Address(RVA = "0x861220", Offset = "0x85FC20", VA = "0x180861220")]
		private void OnPopupChange(IMenu menu)
		{
			//Discarded unreachable code: IL_0119
			//IL_00db: Expected O, but got I4
			if (menu == null)
			{
				if ((IntPtr)(_isInCutscene ? 1 : 0) != (IntPtr)menu)
				{
					_isInCutscene = false;
					if (_currentPhase == Phase.Start)
					{
					}
					int num = 0;
					if (UiRoot.Instance.CutSceneSkipper.gameObject.activeInHierarchy)
					{
						int num2 = 0;
						GameObject gameObject = UiRoot.Instance.CutSceneSkipper.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
					}
					if (!_inReturnDelay)
					{
						_inReturnDelay = true;
						int _003C_003E1__state = default(int);
						_003CReturnDelay_003Ed__100 _003CReturnDelay_003Ed__ = new _003CReturnDelay_003Ed__100(_003C_003E1__state);
						_003C_003E1__state = 0;
						_003CReturnDelay_003Ed__._003C_003E4__this = this;
						Coroutine coroutine = StartCoroutine(_003CReturnDelay_003Ed__);
					}
					int _003C_003E1__state2 = default(int);
					_003CCutsceneDelay_003Ed__99 _003CCutsceneDelay_003Ed__ = new _003CCutsceneDelay_003Ed__99(_003C_003E1__state2);
					_003C_003E1__state2 = 0;
					_003CCutsceneDelay_003Ed__._003C_003E4__this = this;
					Coroutine coroutine2 = (_cutsceneCoroutine = StartCoroutine(_003CCutsceneDelay_003Ed__));
					int num3 = 0;
					if (coroutine2 == null)
					{
						int defaultValue = 0;
						if (!UILocalStorage.Get("DisclaimerAgreed", (byte)defaultValue != 0))
						{
							int num4 = 0;
							UiRoot instance = UiRoot.Instance;
							int num5 = 0;
							instance.ShowDisclaimerPrompt((Action)num5);
						}
					}
					if (_blackScreen.activeSelf)
					{
						GameObject blackScreen = _blackScreen;
						int active2 = 0;
						blackScreen.SetActive((byte)active2 != 0);
					}
					return;
				}
				if (menu == null)
				{
					goto IL_0111;
				}
			}
			int num6 = 0;
			if (menu != null)
			{
				_isInCutscene = true;
				return;
			}
			goto IL_0111;
			IL_0111:
			bool flag = default(bool);
			bool flag2 = !flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE2")]
		[Cpp2IlInjected.Address(RVA = "0x861150", Offset = "0x85FB50", VA = "0x180861150", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0045
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value = OnPopupChange;
			popupStack.OnCurrentMenuChanged -= value;
			base.OnPop();
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num2 = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE3")]
		[Cpp2IlInjected.Address(RVA = "0x861B80", Offset = "0x860580", VA = "0x180861B80", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0077
			OnDownloadableContentPressed();
			int num = 0;
			Client metaClient = MetaClient;
			if (metaClient == null || metaClient.OnlineClient != null)
			{
			}
			int num2 = 0;
			ProfileConflictResolver.ConflictResolved conflictResolved = OnProfileConflictResolved;
			int num3 = 0;
			LocalProfileHolder _003CLocalProfileHolder_003Ek__BackingField = MetaClient.LocalProfileHolder;
			LocalProfileHolder.LocalProfileDeleted value = UpdateNewGameOrContinueLabel;
			_003CLocalProfileHolder_003Ek__BackingField.OnLocalProfileDeleted += value;
			int num4 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value2 = OnPopupChange;
			popupStack.OnCurrentMenuChanged += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE4")]
		[Cpp2IlInjected.Address(RVA = "0x8626A0", Offset = "0x8610A0", VA = "0x1808626A0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0077
			OnDownloadableContentPressed();
			int num = 0;
			Client metaClient = MetaClient;
			if (metaClient == null || metaClient.OnlineClient != null)
			{
			}
			int num2 = 0;
			ProfileConflictResolver.ConflictResolved conflictResolved = OnProfileConflictResolved;
			int num3 = 0;
			LocalProfileHolder _003CLocalProfileHolder_003Ek__BackingField = MetaClient.LocalProfileHolder;
			LocalProfileHolder.LocalProfileDeleted value = UpdateNewGameOrContinueLabel;
			_003CLocalProfileHolder_003Ek__BackingField.OnLocalProfileDeleted -= value;
			int num4 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value2 = OnPopupChange;
			popupStack.OnCurrentMenuChanged -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE5")]
		[Cpp2IlInjected.Address(RVA = "0x8609E0", Offset = "0x85F3E0", VA = "0x1808609E0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0034
			//IL_0032: Expected F4, but got I4
			base.OnFocusIn();
			GameObject backShortcutIndicator = _backShortcutIndicator;
			int active = 0;
			backShortcutIndicator.SetActive((byte)active != 0);
			int num = 0;
			if (!InputDetectionHelper.IsConsole())
			{
				CanvasGroup platformUserCanvasGroup = _platformUserCanvasGroup;
				int num2 = 0;
				platformUserCanvasGroup.alpha = num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE6")]
		[Cpp2IlInjected.Address(RVA = "0x861530", Offset = "0x85FF30", VA = "0x180861530")]
		private void OnProfileConflictResolved(ProfileConflictResolutionResult result)
		{
			UpdateNewGameOrContinueLabel();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE7")]
		[Cpp2IlInjected.Address(RVA = "0x8603C0", Offset = "0x85EDC0", VA = "0x1808603C0")]
		private void Init()
		{
			int num = 0;
			bool flag = UILocalStorage.Load();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE8")]
		[Cpp2IlInjected.Address(RVA = "0x8617D0", Offset = "0x8601D0", VA = "0x1808617D0")]
		private void RefreshGameTitleListener(object sender, EventArgs args)
		{
			RefreshGameTitle();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE9")]
		[Cpp2IlInjected.Address(RVA = "0x8617E0", Offset = "0x8601E0", VA = "0x1808617E0")]
		public void RefreshGameTitle()
		{
			//Discarded unreachable code: IL_00df
			//IL_00de: Expected O, but got I4
			string culture = SystemRoot.Instance._localizationManager.Culture;
			string culture2 = LocalizationUtil.GetCulture(Definitions.Locale.JapaneseJp);
			bool flag = string.Equals(culture, culture2);
			string culture3 = SystemRoot.Instance._localizationManager.Culture;
			string culture4 = LocalizationUtil.GetCulture(Definitions.Locale.ChineseSimplified);
			if (string.Equals(culture3, culture4))
			{
			}
			string culture5 = SystemRoot.Instance._localizationManager.Culture;
			string culture6 = LocalizationUtil.GetCulture(Definitions.Locale.ChineseTraditional);
			bool flag2 = string.Equals(culture5, culture6);
			Sprite jpTitleSprite = default(Sprite);
			if (flag || flag2)
			{
				jpTitleSprite = _jpTitleSprite;
			}
			Image[] titleImages = _titleImages;
			int num = 0;
			int length = titleImages.Length;
			if (num < length)
			{
				titleImages[num].sprite = jpTitleSprite;
				num++;
			}
			if (flag)
			{
			}
			RectTransform titleTransform = _titleTransform;
			Vector2 offsetMax = titleTransform.offsetMax;
			int num2 = default(int);
			if ((object)titleTransform == null)
			{
				RectTransform titleTransform2 = _titleTransform;
				num2 = 0;
				Vector2 offsetMax2 = titleTransform2.offsetMax;
			}
			titleTransform.offsetMax = (Vector2)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CEA")]
		[Cpp2IlInjected.Address(RVA = "0x862260", Offset = "0x860C60", VA = "0x180862260")]
		private void Start()
		{
			//Discarded unreachable code: IL_00c4
			//IL_007a: Expected F4, but got I4
			_copyrightObj.SetActive(value: true);
			int num = 0;
			Sequence s = DOTween.Sequence();
			float intervalSeconds = _intervalSeconds;
			Sequence s2 = s.AppendInterval(intervalSeconds);
			float fadeSeconds = _fadeSeconds;
			TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_copyrightContentCanvasGroup, 1f, fadeSeconds);
			Sequence s3 = s2.Append(t);
			float intervalSeconds2 = _intervalSeconds;
			Sequence s4 = s3.AppendInterval(intervalSeconds2);
			float fadeSeconds2 = _fadeSeconds;
			CanvasGroup copyrightContentCanvasGroup = _copyrightContentCanvasGroup;
			int num2 = 0;
			TweenerCore<float, float, FloatOptions> t2 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(copyrightContentCanvasGroup, (float)num2, fadeSeconds2);
			Sequence t3 = s4.Append(t2);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_0028
				GameObject copyrightObj = _copyrightObj;
				int active = 0;
				copyrightObj.SetActive((byte)active != 0);
				VerifyForCutScene();
				base.MenuNavigation.FocusNavigation.IsPaused = false;
			};
			Sequence sequence = t3.OnComplete(action);
			Mdl.LocalizationManager localizationManager = SystemRoot.Instance._localizationManager;
			EventHandler value = RefreshGameTitleListener;
			localizationManager.OnLanguageChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CEB")]
		[Cpp2IlInjected.Address(RVA = "0x860A80", Offset = "0x85F480", VA = "0x180860A80")]
		public void OnIntroAnimationCompleted()
		{
			TextMeshProUGUI pressAnyButtonLabel = _pressAnyButtonLabel;
			SetPhase(Phase.PressAnyButton);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CEC")]
		[Cpp2IlInjected.Address(RVA = "0x860AF0", Offset = "0x85F4F0", VA = "0x180860AF0")]
		public void OnIntroAnimationEndCompleted()
		{
			//Discarded unreachable code: IL_00cc
			_mainMenu.SetActive(value: true);
			GameObject start = _start;
			int active = 0;
			start.SetActive((byte)active != 0);
			if ((bool)_downloadableContentButton)
			{
				StartTabButton downloadableContentButton = _downloadableContentButton;
				int num = ((downloadableContentButton.IsActivated = false) ? 1 : 0);
				StartTabButton downloadableContentButton2 = _downloadableContentButton;
				int num2 = ((downloadableContentButton2.IsInteractable = false) ? 1 : 0);
				_downloadableContentButton.GetComponent<FocusNavigationElement>().IgnoreThis = true;
			}
			if ((bool)_roadmapButton)
			{
				StartTabButton roadmapButton = _roadmapButton;
				int num3 = ((roadmapButton.IsActivated = false) ? 1 : 0);
				StartTabButton roadmapButton2 = _roadmapButton;
				int num4 = ((roadmapButton2.IsInteractable = false) ? 1 : 0);
				_roadmapButton.GetComponent<FocusNavigationElement>().IgnoreThis = true;
			}
			SetPhase(Phase.Main);
			int _003C_003E1__state = default(int);
			_003CEnableFocus_003Ed__81 _003CEnableFocus_003Ed__ = new _003CEnableFocus_003Ed__81(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CEnableFocus_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CEnableFocus_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CED")]
		[Cpp2IlInjected.Address(RVA = "0x860600", Offset = "0x85F000", VA = "0x180860600", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0047
			base.OnControllerChanged();
			if (_currentPhase == Phase.Main && _mainMenu.activeInHierarchy)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int ignoreThrobber = 0;
				if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
				{
					FocusNavigationElement componentInChildren = GetComponentInChildren<FocusNavigationElement>();
					_focusNavigation.SetFocus(componentInChildren);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CEE")]
		[Cpp2IlInjected.Address(RVA = "0x860410", Offset = "0x85EE10", VA = "0x180860410")]
		public static bool IsNewGame()
		{
			//Discarded unreachable code: IL_003e
			int num = 0;
			if (!DebugSettings.Settings.DoResetProfile)
			{
				int num2 = 0;
				Client metaClient = MetaClient;
				if (metaClient != null)
				{
					LocalProfileHolder _003CLocalProfileHolder_003Ek__BackingField = metaClient.LocalProfileHolder;
					if (_003CLocalProfileHolder_003Ek__BackingField != null)
					{
						bool flag = _003CLocalProfileHolder_003Ek__BackingField.HasLocalProfile();
						int num3 = 0;
						bool flag2 = !flag;
					}
				}
				if (0 == 0)
				{
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CEF")]
		[Cpp2IlInjected.Address(RVA = "0x862820", Offset = "0x861220", VA = "0x180862820")]
		private void UpdateNewGameOrContinueLabel()
		{
			//Discarded unreachable code: IL_0064
			//IL_0045: Expected O, but got I4
			int num = 0;
			bool flag = IsNewGame();
			_newGameButton.gameObject.SetActive(flag);
			GameObject gameObject = _continueGameButton.gameObject;
			bool active = !flag;
			gameObject.SetActive(active);
			FocusNavigation focusNavigation = _focusNavigation;
			int num2 = 0;
			focusNavigation.FocusedElement = (ISupportsFocusNavigation)num2;
			int _003C_003E1__state = default(int);
			_003CEnableFocus_003Ed__81 _003CEnableFocus_003Ed__ = new _003CEnableFocus_003Ed__81(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CEnableFocus_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CEnableFocus_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF0")]
		[Cpp2IlInjected.Address(RVA = "0x860500", Offset = "0x85EF00", VA = "0x180860500")]
		[AsyncStateMachine(typeof(_003COnAnyButtonAtStartPressed_003Ed__79))]
		public Task OnAnyButtonAtStartPressed()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF1")]
		[Cpp2IlInjected.Address(RVA = "0x862190", Offset = "0x860B90", VA = "0x180862190")]
		private void ShowMenu()
		{
			//Discarded unreachable code: IL_004f
			SetPhase(Phase.IntroEnd);
			AK.Wwise.Event onPressedAnyKeySfx = _onPressedAnyKeySfx;
			if (onPressedAnyKeySfx != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = onPressedAnyKeySfx.Post(gameObject);
			}
			UpdateNewGameOrContinueLabel();
			int num2 = 0;
			UiRoot.Instance._profileConflictUIHandler.StartHandlingProfileConflict();
			TextMeshProUGUI pressAnyButtonLabel = _pressAnyButtonLabel;
			int complete = 0;
			int num3 = DOTween.Kill(pressAnyButtonLabel, (byte)complete != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF2")]
		[Cpp2IlInjected.Address(RVA = "0x860170", Offset = "0x85EB70", VA = "0x180860170")]
		[IteratorStateMachine(typeof(_003CEnableFocus_003Ed__81))]
		private IEnumerator EnableFocus()
		{
			int _003C_003E1__state = default(int);
			_003CEnableFocus_003Ed__81 _003CEnableFocus_003Ed__ = new _003CEnableFocus_003Ed__81(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CEnableFocus_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF3")]
		[Cpp2IlInjected.Address(RVA = "0x860FB0", Offset = "0x85F9B0", VA = "0x180860FB0")]
		public void OnNewOrContinueGame()
		{
			//Discarded unreachable code: IL_0053
			if (_currentPhase == Phase.Main && (bool)Startup.Instance)
			{
				int num = 0;
				if (!IsNewGame())
				{
				}
				AK.Wwise.Event newGameSfx = _newGameSfx;
				if (newGameSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num2 = newGameSfx.Post(gameObject);
				}
				int num3 = 0;
				UiRoot.Instance._popupStack.PopAll();
				PopSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF4")]
		[Cpp2IlInjected.Address(RVA = "0x860DD0", Offset = "0x85F7D0", VA = "0x180860DD0")]
		public void OnNewGame()
		{
			//Discarded unreachable code: IL_0046
			base.MenuNavigation.FocusNavigation.IsPaused = true;
			if (_currentPhase == Phase.Main)
			{
				int num = 0;
				if (!IsNewGame())
				{
					CancellationToken token = _cancellationTokenSource.Token;
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				else
				{
					OnNewOrContinueGame();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF5")]
		[Cpp2IlInjected.Address(RVA = "0x861D00", Offset = "0x860700", VA = "0x180861D00")]
		[AsyncStateMachine(typeof(_003CResetGameProgressionTask_003Ed__84))]
		private Task ResetGameProgressionTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF6")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F700", VA = "0x180860D00")]
		public void OnLinkAccountMenuPressed()
		{
			//Discarded unreachable code: IL_003d
			if (_currentPhase == Phase.Main)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int num2 = 0;
				if (!instance.IsOnTop<StartMenuLinkAccount>((byte)num2 != 0))
				{
					int num3 = 0;
					UiRoot instance2 = UiRoot.Instance;
					instance2._popupStack.PopAll();
					IDesignerHost activeDesigner = ((IDesignerEventService)instance2).ActiveDesigner;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void OnDownloadableContentPressed()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF8")]
		[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860000", VA = "0x180861600")]
		public void OnRoadmapMenuPressed()
		{
			//Discarded unreachable code: IL_0027
			if (_currentPhase == Phase.Main)
			{
				int num = 0;
				UiRoot.Instance._popupStack.PopAll();
				IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF9")]
		[Cpp2IlInjected.Address(RVA = "0x861700", Offset = "0x860100", VA = "0x180861700")]
		public void OnSettingsMenuPressed()
		{
			//Discarded unreachable code: IL_003d
			if (_currentPhase == Phase.Main)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int num2 = 0;
				if (!instance.IsOnTop<StartMenuSettings>((byte)num2 != 0))
				{
					int num3 = 0;
					UiRoot instance2 = UiRoot.Instance;
					instance2._popupStack.PopAll();
					IDesignerHost activeDesigner = ((IDesignerEventService)instance2).ActiveDesigner;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFA")]
		[Cpp2IlInjected.Address(RVA = "0x8606B0", Offset = "0x85F0B0", VA = "0x1808606B0")]
		public void OnCreditsMenuPressed()
		{
			//Discarded unreachable code: IL_0027
			if (_currentPhase == Phase.Main)
			{
				int num = 0;
				UiRoot.Instance._popupStack.PopAll();
				IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFB")]
		[Cpp2IlInjected.Address(RVA = "0x860920", Offset = "0x85F320", VA = "0x180860920")]
		public void OnExitMenuPressed()
		{
			//Discarded unreachable code: IL_003f
			if (_currentPhase == Phase.Main)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				CancellationTokenSource cancellationTokenSource = _cancellationTokenSource;
				RedirectionManager redirection = instance.Redirection;
				CancellationToken token = cancellationTokenSource.Token;
				int saveProfile = 0;
				int skipConfirmation = 0;
				redirection.QuitGameTask(token, (byte)skipConfirmation != 0, (byte)saveProfile != 0).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFC")]
		[Cpp2IlInjected.Address(RVA = "0x8601E0", Offset = "0x85EBE0", VA = "0x1808601E0")]
		private void FadeInFadeOutAnyButtonLabel()
		{
			TextMeshProUGUI pressAnyButtonLabel = _pressAnyButtonLabel;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFD")]
		[Cpp2IlInjected.Address(RVA = "0x861E90", Offset = "0x860890", VA = "0x180861E90")]
		public void SelectTab(StartTabButton tab)
		{
			//Discarded unreachable code: IL_0035
			//IL_0023: Expected O, but got I4
			if (_currentPhase != Phase.Main)
			{
				return;
			}
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
					int num = 0;
				}
				_selectedTab = tab;
			}
			int num2 = 0;
			if (tab != (UnityEngine.Object)num2)
			{
				tab.IsSelected = true;
				SetPhase(Phase.Start);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFE")]
		[Cpp2IlInjected.Address(RVA = "0x861FE0", Offset = "0x8609E0", VA = "0x180861FE0")]
		private void SetPhase(Phase phase)
		{
			//Discarded unreachable code: IL_0061
			if (_currentPhase != phase)
			{
				Debug.Log(string.Format("[UI] StartMenu#SetPhase Changing phase to: {0}", "[UI] StartMenu#SetPhase Changing phase to: {0}"), this);
				FocusNavigation focusNavigation = _focusNavigation;
				bool flag = (focusNavigation.IsPaused = phase != Phase.Main);
				Dictionary<Phase, UnityEvent> dictPhase = _dictPhase;
				_currentPhase = phase;
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
			}
			else
			{
				Debug.LogWarning(string.Format("[UI] StartMenu#SetPhase Setting the same phase again, no events will be executed: {0}", "[UI] StartMenu#SetPhase Changing phase to: {0}"), this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFF")]
		[Cpp2IlInjected.Address(RVA = "0x8607B0", Offset = "0x85F1B0", VA = "0x1808607B0", Slot = "24")]
		protected override void OnDestroy()
		{
			Coroutine startingCoroutine = _startingCoroutine;
			if (startingCoroutine != null)
			{
				StopCoroutine(startingCoroutine);
			}
			Mdl.LocalizationManager localizationManager = SystemRoot.Instance._localizationManager;
			EventHandler value = RefreshGameTitleListener;
			localizationManager.OnLanguageChanged -= value;
			base.OnDestroy();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D00")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002D01")]
		[Cpp2IlInjected.Address(RVA = "0x860250", Offset = "0x85EC50", VA = "0x180860250")]
		private void HandleCopyrightDisplay()
		{
			//Discarded unreachable code: IL_00a1
			//IL_007a: Expected F4, but got I4
			_copyrightObj.SetActive(value: true);
			int num = 0;
			Sequence s = DOTween.Sequence();
			float intervalSeconds = _intervalSeconds;
			Sequence s2 = s.AppendInterval(intervalSeconds);
			float fadeSeconds = _fadeSeconds;
			TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_copyrightContentCanvasGroup, 1f, fadeSeconds);
			Sequence s3 = s2.Append(t);
			float intervalSeconds2 = _intervalSeconds;
			Sequence s4 = s3.AppendInterval(intervalSeconds2);
			float fadeSeconds2 = _fadeSeconds;
			CanvasGroup copyrightContentCanvasGroup = _copyrightContentCanvasGroup;
			int num2 = 0;
			TweenerCore<float, float, FloatOptions> t2 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(copyrightContentCanvasGroup, (float)num2, fadeSeconds2);
			Sequence t3 = s4.Append(t2);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_0028
				GameObject copyrightObj = _copyrightObj;
				int active = 0;
				copyrightObj.SetActive((byte)active != 0);
				VerifyForCutScene();
				base.MenuNavigation.FocusNavigation.IsPaused = false;
			};
			Sequence sequence = t3.OnComplete(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D02")]
		[Cpp2IlInjected.Address(RVA = "0x862A80", Offset = "0x861480", VA = "0x180862A80")]
		private void VerifyForCutScene()
		{
			//IL_0074: Expected I4, but got I8
			int num = 0;
			bool flag = UILocalStorage.Load();
			if (UILocalStorage.HasKey("DidStartCutscene"))
			{
				int defaultValue = 0;
				if (UILocalStorage.Get("DidStartCutscene", (byte)defaultValue != 0))
				{
					goto IL_0037;
				}
			}
			JToken value = true;
			UILocalStorage.Set("DidStartCutscene", value);
			goto IL_0037;
			IL_0037:
			int num2 = 0;
			bool flag2 = UILocalStorage.Save();
			Coroutine startingCoroutine = _startingCoroutine;
			if (startingCoroutine != null)
			{
				StopCoroutine(startingCoroutine);
			}
			int _003C_003E1__state = default(int);
			_003CStarting_003Ed__98 _003CStarting_003Ed__ = new _003CStarting_003Ed__98(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CStarting_003Ed__._003C_003E4__this = this;
			_003CStarting_003Ed__.doCutscene = true;
			Coroutine coroutine = (_startingCoroutine = StartCoroutine(_003CStarting_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D03")]
		[Cpp2IlInjected.Address(RVA = "0x8624B0", Offset = "0x860EB0", VA = "0x1808624B0")]
		[IteratorStateMachine(typeof(_003CStarting_003Ed__98))]
		private IEnumerator Starting(bool doCutscene)
		{
			int _003C_003E1__state = default(int);
			_003CStarting_003Ed__98 _003CStarting_003Ed__ = new _003CStarting_003Ed__98(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CStarting_003Ed__._003C_003E4__this = this;
			_003CStarting_003Ed__.doCutscene = doCutscene;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D04")]
		[Cpp2IlInjected.Address(RVA = "0x860100", Offset = "0x85EB00", VA = "0x180860100")]
		[IteratorStateMachine(typeof(_003CCutsceneDelay_003Ed__99))]
		private IEnumerator CutsceneDelay()
		{
			int _003C_003E1__state = default(int);
			_003CCutsceneDelay_003Ed__99 _003CCutsceneDelay_003Ed__ = new _003CCutsceneDelay_003Ed__99(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCutsceneDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D05")]
		[Cpp2IlInjected.Address(RVA = "0x861E20", Offset = "0x860820", VA = "0x180861E20")]
		[IteratorStateMachine(typeof(_003CReturnDelay_003Ed__100))]
		private IEnumerator ReturnDelay()
		{
			int _003C_003E1__state = default(int);
			_003CReturnDelay_003Ed__100 _003CReturnDelay_003Ed__ = new _003CReturnDelay_003Ed__100(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CReturnDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D06")]
		[Cpp2IlInjected.Address(RVA = "0x862C80", Offset = "0x861680", VA = "0x180862C80")]
		public StartMenu()
		{
		}
	}
}
