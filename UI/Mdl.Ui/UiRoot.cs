using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using glPlayFab;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Cache;
using Mdl.Characters;
using Mdl.Characters.Critters;
using Mdl.Dialogues;
using Mdl.Environments;
using Mdl.Ftue.Cutscenes;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Motion;
using Mdl.Navigation;
using Mdl.Navigation.ControlSchemes;
using Mdl.Platform;
using Mdl.Systems;
using mdl.UI;
using Mdl.Ui.Cache;
using Mdl.Ui.Navigation;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using Meta.Tracking;
using Meta.Util;
using PlayFab;
using Rewired;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007F9")]
	public class UiRoot : BaseUiRoot
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002EDE")]
		[SerializeField]
		private RecycleBin _menuRecycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002EDF")]
		[SerializeField]
		private RecycleBin _itemRecycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002EE0")]
		[SerializeField]
		private RecycleBin _miscRecycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002EE1")]
		public RectTransform DefaultBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002EE2")]
		public RectTransform DefaultBackgroundHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002EE3")]
		[Space]
		[SerializeField]
		private ShortcutDefinition _skipCutsceneKeyboard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002EE4")]
		[SerializeField]
		private ShortcutDefinition _skipCutsceneGamepad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002EE5")]
		[Space]
		[SerializeField]
		private MenuStack _menuStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002EE6")]
		[SerializeField]
		private MenuStack _popupStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002EE7")]
		[SerializeField]
		private MenuStack _systemPromptStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002EE8")]
		[SerializeField]
		private Menu _insaneProfilePrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002EE9")]
		[SerializeField]
		private Menu _debugPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002EEA")]
		[SerializeField]
		private GenericAlert _systemAlert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002EEB")]
		[SerializeField]
		private GenericAlert _genericAlert;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002EEC")]
		[SerializeField]
		private GenericMessage _genericMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002EED")]
		[SerializeField]
		private Throbber _throbber;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002EEE")]
		[SerializeField]
		private WorldUI _worldCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002EEF")]
		[SerializeField]
		private Canvas _worldCanvas3D;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002EF0")]
		[SerializeField]
		private FadeEffect _fadeEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002EF1")]
		[SerializeField]
		private SpriteCache _spriteCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002EF2")]
		[SerializeField]
		private IconAtlasCache _iconAtlasCacheTiny;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002EF3")]
		[SerializeField]
		private IconAtlasCache _iconAtlasCacheSmall;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002EF4")]
		[SerializeField]
		private IconAtlasCache _iconAtlasCacheBig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002EF5")]
		[SerializeField]
		private UIErrorMessage _uiMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002EF6")]
		[SerializeField]
		private AsyncMenu _mainMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002EF7")]
		[SerializeField]
		private AsyncMenu _mainMenuSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002EF8")]
		[SerializeField]
		private AsyncMenu _mainMenuRoadmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002EF9")]
		[SerializeField]
		private AsyncMenu _mainMenuLinkAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002EFA")]
		[SerializeField]
		private AsyncMenu _mainMenuCredits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002EFB")]
		[SerializeField]
		private AsyncMenu _hud;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002EFC")]
		[SerializeField]
		private AsyncMenu _DialogueMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002EFD")]
		[SerializeField]
		private AsyncMenu _lockedVillageAreaPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002EFE")]
		[SerializeField]
		private AsyncMenu _ageGateDisclaimerPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002EFF")]
		[SerializeField]
		private AsyncMenu _disclaimerPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002F00")]
		[SerializeField]
		private AsyncMenu _touchOfMagicDisclaimerPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002F01")]
		[SerializeField]
		private AsyncMenu _MailboxMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002F02")]
		[SerializeField]
		private CanvasHelper _menuStackSafeArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002F03")]
		[SerializeField]
		private RectTransform _mainMenuBarHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002F04")]
		[SerializeField]
		[NotNull]
		private ShortcutIndicatorTemplates _shortcutIndicatorTemplates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002F05")]
		[SerializeField]
		private AssetReference _mainMenuBarRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002F06")]
		[SerializeField]
		private List<AssetReference> _staticMenusRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002F07")]
		[SerializeField]
		private AsyncMenu _notEnoughCurrencyPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4002F08")]
		[SerializeField]
		private ItemPreview _itemPreview;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002F09")]
		[SerializeField]
		private string _notEnoughManaLocId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002F0A")]
		[SerializeField]
		private ImageReferenceHolder _imageReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4002F0B")]
		[SerializeField]
		private HudCraftingNotif _hudCraftingNotif;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4002F0C")]
		[SerializeField]
		private AssetReference _stallMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4002F0D")]
		[SerializeField]
		public Color NavyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4002F0E")]
		[SerializeField]
		public Color PaleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4002F0F")]
		[SerializeField]
		private UIGameColors _gameColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4002F10")]
		[SerializeField]
		public CutSceneSkipper CutSceneSkipper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4002F11")]
		[SerializeField]
		public PoolManager InventorySlotPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4002F12")]
		[ItemID]
		[SerializeField]
		private int _battlePassIntro;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4002F13")]
		[NotNull]
		[SerializeField]
		private ProfileConflictUIHandler _profileConflictUIHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4002F14")]
		[SerializeField]
		private GameObject _disconnectGamepadMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4002F15")]
		public TutorialView TutorialView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4002F16")]
		public GenericPrompt genericPromptPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4002F17")]
		public Menu shareSNSPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4002F18")]
		public QRPrompt shareQRPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4002F1A")]
		public FocusCursor FocusCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4002F1B")]
		[HideInInspector]
		public InputDetectionHelper.InputController CurrentControlType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x4002F1C")]
		private ControlType _rewiredControlType = ControlType.Keyboard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4002F1D")]
		private RewiredControllerManager _rewiredControllerManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4002F1E")]
		private UIExclusiveWaiter _exclusiveWaiter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4002F1F")]
		private int _blockShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4002F20")]
		private PlayerNavigation.TemporaryOverrideScope OverrideAllScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4002F24")]
		public bool ShouldShowNewItem;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
		[Cpp2IlInjected.Token(Token = "0x4002F25")]
		public bool ShouldShowNewCritter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26A")]
		[Cpp2IlInjected.Token(Token = "0x4002F26")]
		public bool GenericAlertOnTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4002F28")]
		private CountedBool ForceAllowShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4002F29")]
		public RedirectionManager Redirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4002F2A")]
		public RedDotHelper RedDotHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4002F2B")]
		public VirtualJoystick joystick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4002F2C")]
		public Texture2D TexMouseCursorSoftware;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4002F2D")]
		public Texture2D TexMouseCursorHardware;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4002F2E")]
		private Canvas[] _allCanvases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4002F2F")]
		private GridEditMode gridEditModeSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4002F30")]
		public UnityEvent CutSceneOnGoingEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4002F31")]
		public UnityEvent CutSceneOverEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4002F32")]
		private List<AddedFriendshipSummary> postponedFriendshipAdded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4002F33")]
		private bool mustPostponeFriendshipAdded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4002F34")]
		private TaskCompletionSource<bool> _levelUpAnimationTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4002F35")]
		private TaskCompletionSource<bool> friendshipAddedAnimationBlockerTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4002F36")]
		private TaskCompletionSource<bool> rewardAnimationBlockerTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4002F38")]
		private Texture2D scaledCursor;

		[Cpp2IlInjected.Token(Token = "0x17000723")]
		public ProfileConflictUIHandler ProfileConflictUIHandler
		{
			[Cpp2IlInjected.Token(Token = "0x60032C0")]
			[Cpp2IlInjected.Address(RVA = "0xCA8F90", Offset = "0xCA7990", VA = "0x180CA8F90")]
			get
			{
				return _profileConflictUIHandler;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000724")]
		public override bool AreShortcutsBlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60032C3")]
			[Cpp2IlInjected.Address(RVA = "0xCA8B00", Offset = "0xCA7500", VA = "0x180CA8B00", Slot = "30")]
			get
			{
				int num = 0;
				return !ForceAllowShortcut;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000725")]
		public bool ShouldBlockShortcuts
		{
			[Cpp2IlInjected.Token(Token = "0x60032C4")]
			[Cpp2IlInjected.Address(RVA = "0xCA9020", Offset = "0xCA7A20", VA = "0x180CA9020")]
			get
			{
				//Discarded unreachable code: IL_0033
				if (Cutscenes != null)
				{
				}
				if (!AreShortcutsBlocked && !_throbber.ShouldBlockInput)
				{
					return TutorialView._blocker.activeSelf;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000726")]
		public List<ShortcutIndicatorTemplate> DefaultShortcutIndicatorTemplates
		{
			[Cpp2IlInjected.Token(Token = "0x60032C5")]
			[Cpp2IlInjected.Address(RVA = "0xCA8BD0", Offset = "0xCA75D0", VA = "0x180CA8BD0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _shortcutIndicatorTemplates.DefaultShortcutIndicatorTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000727")]
		public bool IsCutsceneInPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x60032C6")]
			[Cpp2IlInjected.Address(RVA = "0xCA8E10", Offset = "0xCA7810", VA = "0x180CA8E10")]
			get
			{
				if (Cutscenes == null)
				{
				}
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000728")]
		public Cutscene CurrentCutscene
		{
			[Cpp2IlInjected.Token(Token = "0x60032C7")]
			[Cpp2IlInjected.Address(RVA = "0xCA8B40", Offset = "0xCA7540", VA = "0x180CA8B40")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000729")]
		public MainMenuBar MainMenuBar
		{
			[Cpp2IlInjected.Token(Token = "0x60032C8")]
			[Cpp2IlInjected.Address(RVA = "0xCA8F30", Offset = "0xCA7930", VA = "0x180CA8F30")]
			[CompilerGenerated]
			get
			{
				return _003CMainMenuBar_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60032C9")]
			[Cpp2IlInjected.Address(RVA = "0xCA91A0", Offset = "0xCA7BA0", VA = "0x180CA91A0")]
			[CompilerGenerated]
			private set
			{
				_003CMainMenuBar_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072A")]
		public RecycleBin MenuRecycleBin
		{
			[Cpp2IlInjected.Token(Token = "0x60032CA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _menuRecycleBin;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072B")]
		public RecycleBin ItemRecycleBin
		{
			[Cpp2IlInjected.Token(Token = "0x60032CB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _itemRecycleBin;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072C")]
		public RecycleBin MiscRecycleBin
		{
			[Cpp2IlInjected.Token(Token = "0x60032CC")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _miscRecycleBin;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072D")]
		public MenuStack MenuStack
		{
			[Cpp2IlInjected.Token(Token = "0x60032CD")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _menuStack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072E")]
		public UIErrorMessage UIMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60032CE")]
			[Cpp2IlInjected.Address(RVA = "0x7393C0", Offset = "0x737DC0", VA = "0x1807393C0")]
			get
			{
				return _uiMessage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072F")]
		public MenuStack PopupStack
		{
			[Cpp2IlInjected.Token(Token = "0x60032CF")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return _popupStack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000730")]
		public MenuStack SystemPromptStack
		{
			[Cpp2IlInjected.Token(Token = "0x60032D0")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return _systemPromptStack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000731")]
		public WorldUI WorldCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x60032D1")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return _worldCanvas;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000732")]
		public Canvas World3DCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x60032D2")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return _worldCanvas3D;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000733")]
		public GenericAlert GenericAlert
		{
			[Cpp2IlInjected.Token(Token = "0x60032D3")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return _genericAlert;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000734")]
		public GenericAlert SystemAlert
		{
			[Cpp2IlInjected.Token(Token = "0x60032D4")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return _systemAlert;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000735")]
		public GenericMessage GenericMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60032D5")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return _genericMessage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000736")]
		public Throbber Throbber
		{
			[Cpp2IlInjected.Token(Token = "0x60032D6")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return _throbber;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000737")]
		public FadeEffect FadeEffect
		{
			[Cpp2IlInjected.Token(Token = "0x60032D7")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return _fadeEffect;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000738")]
		public SpriteCache SpriteCache
		{
			[Cpp2IlInjected.Token(Token = "0x60032D8")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get
			{
				return _spriteCache;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000739")]
		public IconAtlasCache IconAtlasCacheTiny
		{
			[Cpp2IlInjected.Token(Token = "0x60032D9")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			get
			{
				return _iconAtlasCacheTiny;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073A")]
		public IconAtlasCache IconAtlasCacheSmall
		{
			[Cpp2IlInjected.Token(Token = "0x60032DA")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			get
			{
				return _iconAtlasCacheSmall;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073B")]
		public IconAtlasCache IconAtlasCacheBig
		{
			[Cpp2IlInjected.Token(Token = "0x60032DB")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get
			{
				return _iconAtlasCacheBig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073C")]
		public ImageReferenceHolder ImageReference
		{
			[Cpp2IlInjected.Token(Token = "0x60032DC")]
			[Cpp2IlInjected.Address(RVA = "0x738EB0", Offset = "0x7378B0", VA = "0x180738EB0")]
			get
			{
				return _imageReference;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073D")]
		public UIEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x60032DD")]
			[Cpp2IlInjected.Address(RVA = "0xCA8BF0", Offset = "0xCA75F0", VA = "0x180CA8BF0")]
			[CompilerGenerated]
			get
			{
				return _003CDispatcher_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60032DE")]
			[Cpp2IlInjected.Address(RVA = "0xCA9190", Offset = "0xCA7B90", VA = "0x180CA9190")]
			[CompilerGenerated]
			private set
			{
				_003CDispatcher_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new UIEventDispatcher
		{
			OnToolMenuChanged = (UnityEvent<bool>)(object)new UnityEvent<T0>(),
			OnItemSelectorOnOff = (UnityEvent<bool>)(object)new UnityEvent<T0>(),
			OnGenericAlertOnOff = (UnityEvent<bool>)(object)new UnityEvent<T0>(),
			OnNotEnoughMana = new UnityEvent(),
			OnSomethingConsumed = new UnityEvent(),
			OnFriendshipAdded = (UnityEvent<AddedFriendshipSummary>)(object)new UnityEvent<T0>()
		};


		[Cpp2IlInjected.Token(Token = "0x1700073E")]
		internal List<Cutscene> Cutscenes
		{
			[Cpp2IlInjected.Token(Token = "0x60032DF")]
			[Cpp2IlInjected.Address(RVA = "0xCA8BC0", Offset = "0xCA75C0", VA = "0x180CA8BC0")]
			[CompilerGenerated]
			get
			{
				return _003CCutscenes_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60032E0")]
			[Cpp2IlInjected.Address(RVA = "0xCA9180", Offset = "0xCA7B80", VA = "0x180CA9180")]
			[CompilerGenerated]
			private set
			{
				_003CCutscenes_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<Cutscene>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x1700073F")]
		public UIGameColors GameColors
		{
			[Cpp2IlInjected.Token(Token = "0x60032E1")]
			[Cpp2IlInjected.Address(RVA = "0xCA8C80", Offset = "0xCA7680", VA = "0x180CA8C80")]
			get
			{
				return _gameColors;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000740")]
		public ItemPreview ItemPreview
		{
			[Cpp2IlInjected.Token(Token = "0x60032E2")]
			[Cpp2IlInjected.Address(RVA = "0x738AD0", Offset = "0x7374D0", VA = "0x180738AD0")]
			get
			{
				return _itemPreview;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000741")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x26B"), Cpp2IlInjected.Token(Token = "0x4002F27")]
		public bool CheatRemoveDevConsole
		{
			[Cpp2IlInjected.Token(Token = "0x60032E3")]
			[Cpp2IlInjected.Address(RVA = "0xCA8B30", Offset = "0xCA7530", VA = "0x180CA8B30")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60032E4")]
			[Cpp2IlInjected.Address(RVA = "0xCA9170", Offset = "0xCA7B70", VA = "0x180CA9170")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000742")]
		public bool IsLastInputFromJoystick
		{
			[Cpp2IlInjected.Token(Token = "0x60032E5")]
			[Cpp2IlInjected.Address(RVA = "0xCA8E60", Offset = "0xCA7860", VA = "0x180CA8E60")]
			get
			{
				int num = 0;
				return InputDetectionHelper.GetLastControllerType() == ControllerType.Joystick;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000743")]
		public new static UiRoot Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60032E7")]
			[Cpp2IlInjected.Address(RVA = "0xCA8C90", Offset = "0xCA7690", VA = "0x180CA8C90")]
			get
			{
				if ((object)BaseUiRoot.Instance == null)
				{
					int num = 0;
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000744")]
		public IMenu MenuOnTop
		{
			[Cpp2IlInjected.Token(Token = "0x600331C")]
			[Cpp2IlInjected.Address(RVA = "0xCA8F40", Offset = "0xCA7940", VA = "0x180CA8F40")]
			get
			{
				//Discarded unreachable code: IL_001a
				if (_popupStack.IsEmpty)
				{
				}
				return _popupStack.Top;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000745")]
		public bool IsAnyAlertVisible
		{
			[Cpp2IlInjected.Token(Token = "0x600331F")]
			[Cpp2IlInjected.Address(RVA = "0xCA8D90", Offset = "0xCA7790", VA = "0x180CA8D90")]
			get
			{
				//Discarded unreachable code: IL_0034
				if (_systemPromptStack.IsEmpty && !_systemAlert.gameObject.activeInHierarchy)
				{
					return _genericAlert.gameObject.activeInHierarchy;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000746")]
		public bool MustPostponeFriendshipAdded
		{
			[Cpp2IlInjected.Token(Token = "0x6003345")]
			[Cpp2IlInjected.Address(RVA = "0xCA8F80", Offset = "0xCA7980", VA = "0x180CA8F80")]
			get
			{
				return mustPostponeFriendshipAdded;
			}
			[Cpp2IlInjected.Token(Token = "0x6003346")]
			[Cpp2IlInjected.Address(RVA = "0xCA91B0", Offset = "0xCA7BB0", VA = "0x180CA91B0")]
			set
			{
				//Discarded unreachable code: IL_004c
				if (mustPostponeFriendshipAdded != value)
				{
					mustPostponeFriendshipAdded = value;
					if (!value)
					{
						List<AddedFriendshipSummary> list = postponedFriendshipAdded;
						Debug.LogError("postponedFriendshipAdded.Count > 1: Is badly supported");
						List<AddedFriendshipSummary> list2 = postponedFriendshipAdded;
						Action<AddedFriendshipSummary> action = (Action<AddedFriendshipSummary>)(object)new Action<T>(OnFriendshipAdded);
						((List<T>)(object)list2).ForEach((Action<>)(object)action);
						((List<T>)(object)postponedFriendshipAdded).Clear();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000747")]
		public override Task LevelUpAnimationTask
		{
			[Cpp2IlInjected.Token(Token = "0x6003351")]
			[Cpp2IlInjected.Address(RVA = "0xCA8EB0", Offset = "0xCA78B0", VA = "0x180CA8EB0", Slot = "17")]
			get
			{
				TaskCompletionSource<bool> levelUpAnimationTCS = _levelUpAnimationTCS;
				if (levelUpAnimationTCS == null || ((TaskCompletionSource<>)(object)levelUpAnimationTCS).m_task == null)
				{
					int num = 0;
					return Task.CompletedTask;
				}
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000748")]
		public override Task FriendshipAddedAnimationBlockerTask
		{
			[Cpp2IlInjected.Token(Token = "0x6003357")]
			[Cpp2IlInjected.Address(RVA = "0xCA8C00", Offset = "0xCA7600", VA = "0x180CA8C00", Slot = "22")]
			get
			{
				TaskCompletionSource<bool> taskCompletionSource = friendshipAddedAnimationBlockerTCS;
				if (taskCompletionSource == null || ((TaskCompletionSource<>)(object)taskCompletionSource).m_task == null)
				{
					int num = 0;
					return Task.CompletedTask;
				}
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000749")]
		public override Task RewardAnimationBlockerTask
		{
			[Cpp2IlInjected.Token(Token = "0x600335A")]
			[Cpp2IlInjected.Address(RVA = "0xCA8FA0", Offset = "0xCA79A0", VA = "0x180CA8FA0", Slot = "25")]
			get
			{
				TaskCompletionSource<bool> taskCompletionSource = rewardAnimationBlockerTCS;
				if (taskCompletionSource == null || ((TaskCompletionSource<>)(object)taskCompletionSource).m_task == null)
				{
					int num = 0;
					return Task.CompletedTask;
				}
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2E8"), Cpp2IlInjected.Token(Token = "0x4002F37")]
		public bool AddToBackpackAnimationBlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6003363")]
			[Cpp2IlInjected.Address(RVA = "0xCA8AF0", Offset = "0xCA74F0", VA = "0x180CA8AF0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003364")]
			[Cpp2IlInjected.Address(RVA = "0xCA9160", Offset = "0xCA7B60", VA = "0x180CA9160")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000053")]
		public event EventHandler OnNewInputReceived
		{
			[Cpp2IlInjected.Token(Token = "0x60032C1")]
			[Cpp2IlInjected.Address(RVA = "0xCA8A50", Offset = "0xCA7450", VA = "0x180CA8A50")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60032C2")]
			[Cpp2IlInjected.Address(RVA = "0xCA90C0", Offset = "0xCA7AC0", VA = "0x180CA90C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032B9")]
		[Cpp2IlInjected.Address(RVA = "0xCA5370", Offset = "0xCA3D70", VA = "0x180CA5370")]
		private void ShowRemoteTransactionErrorPrompt(string error, UserChoice<RemoteTransactionErrorOption> userChoice)
		{
			//Discarded unreachable code: IL_00fe
			//IL_0028: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			PromptData promptData = new PromptData();
			string key = error + "_title";
			int num = 0;
			string text = (promptData.title = TextUtilities.GetLocalizedText(key, (IResolver)num));
			string key2 = error + "_subtitle";
			int num2 = 0;
			string text2 = (promptData.subtitle = TextUtilities.GetLocalizedText(key2, (IResolver)num2));
			string key3 = error + "_message";
			int num3 = 0;
			string text3 = (promptData.message = TextUtilities.GetLocalizedText(key3, (IResolver)num3));
			promptData.allowClose = false;
			int num4 = 0;
			string localizedText = TextUtilities.GetLocalizedText("menu.button_common_cancel", (IResolver)num4);
			Action action = delegate
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				((UserChoice<EnumT>)(object)userChoice).SelectOption((EnumT)2);
			};
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			string localizedText2 = TextUtilities.GetLocalizedText("menu.retry_button", (IResolver)num7);
			Action action2 = delegate
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				((UserChoice<EnumT>)(object)userChoice).SelectOption((EnumT)1);
			};
			List<PromptButtonData> buttons = promptData.buttons;
			List<PromptButtonData> buttons2 = promptData.buttons;
			MenuStack systemPromptStack = _systemPromptStack;
			GenericPrompt menu = genericPromptPrefab;
			PromptParams promptParams = new PromptParams();
			promptParams.data = promptData;
			systemPromptStack.Push(menu, promptParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60032BA")]
		[Cpp2IlInjected.Address(RVA = "0xCA4630", Offset = "0xCA3030", VA = "0x180CA4630")]
		private void ShowInsaneProfileErrorPrompt(string error)
		{
			//Discarded unreachable code: IL_00d1
			//IL_001b: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			PromptData promptData = new PromptData();
			string key = error + "_title";
			int num = 0;
			string text = (promptData.title = TextUtilities.GetLocalizedText(key, (IResolver)num));
			string key2 = error + "_subtitle";
			int num2 = 0;
			string text2 = (promptData.subtitle = TextUtilities.GetLocalizedText(key2, (IResolver)num2));
			string key3 = error + "_message";
			int num3 = 0;
			string text3 = (promptData.message = TextUtilities.GetLocalizedText(key3, (IResolver)num3));
			promptData.allowClose = false;
			int num4 = 0;
			string localizedText = TextUtilities.GetLocalizedText("menu.button_common_accept", (IResolver)num4);
			if (_003C_003Ec._003C_003E9__1_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action)delegate
				{
					int num5 = 0;
					Application.Quit();
				};
			}
			List<PromptButtonData> buttons = promptData.buttons;
			MenuStack systemPromptStack = _systemPromptStack;
			Menu insaneProfilePrompt = _insaneProfilePrompt;
			PromptParams promptParams = new PromptParams();
			promptParams.data = promptData;
			systemPromptStack.Push(insaneProfilePrompt, promptParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60032BB")]
		[Cpp2IlInjected.Address(RVA = "0xCA3C70", Offset = "0xCA2670", VA = "0x180CA3C70")]
		private void ShowDebugErrorPrompt(string errorMessage, UserChoice<DebugErrorOption> userChoice)
		{
			//Discarded unreachable code: IL_007e
			Debug.Log(errorMessage);
			PromptData promptData = new PromptData();
			promptData.message = errorMessage;
			promptData.allowClose = false;
			Action action = delegate
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				((UserChoice<EnumT>)(object)userChoice).SelectOption((EnumT)2);
			};
			Action action2 = delegate
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				((UserChoice<EnumT>)(object)userChoice).SelectOption((EnumT)1);
			};
			List<PromptButtonData> buttons = promptData.buttons;
			List<PromptButtonData> buttons2 = promptData.buttons;
			MenuStack systemPromptStack = _systemPromptStack;
			Menu debugPrompt = _debugPrompt;
			PromptParams promptParams = new PromptParams();
			promptParams.data = promptData;
			systemPromptStack.Push(debugPrompt, promptParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60032BC")]
		[Cpp2IlInjected.Address(RVA = "0xCA4610", Offset = "0xCA3010", VA = "0x180CA4610")]
		private void ShowInfoMessage(string message)
		{
			IDesignerHost activeDesigner = ((IDesignerEventService)this).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x60032BD")]
		[Cpp2IlInjected.Address(RVA = "0xCA3F90", Offset = "0xCA2990", VA = "0x180CA3F90")]
		private void ShowDebugMessage(string title, string message, Exception e, bool allowClose, IEnumerable<OptionWithCallback> options)
		{
			if (_003C_003Ec._003C_003E9__4_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((OptionWithCallback x) => x.Option == "{il2cpp field on {'constant20' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x8}");
			}
			OptionWithCallback optionWithCallback = default(OptionWithCallback);
			OptionWithCallback optionWithCallback2 = default(OptionWithCallback);
			if (optionWithCallback != null || optionWithCallback2 != null)
			{
				optionWithCallback2.Select();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032BE")]
		[Cpp2IlInjected.Address(RVA = "0xCA40E0", Offset = "0xCA2AE0", VA = "0x180CA40E0")]
		private void ShowDebugPrompt(string title, string subtitle, string message, bool allowClose, IEnumerable<OptionWithCallback> options)
		{
			//Discarded unreachable code: IL_0076
			PromptData promptData = new PromptData();
			promptData.title = title;
			promptData.subtitle = subtitle;
			promptData.message = message;
			promptData.allowClose = false;
			if (_003C_003Ec._003C_003E9__5_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					OptionWithCallback o2 = default(OptionWithCallback);
					string _003CLabel_003Ek__BackingField = o2.Option.Label;
					Action action = delegate
					{
						//Discarded unreachable code: IL_000c
						o2.Select();
					};
					throw new NullReferenceException();
				};
			}
			IEnumerable<OptionWithCallback> enumerable = default(IEnumerable<OptionWithCallback>);
			List<PromptButtonData> list = (promptData.buttons = (List<PromptButtonData>)(object)Enumerable.ToList<PromptButtonData>((IEnumerable<>)enumerable));
			MenuStack systemPromptStack = _systemPromptStack;
			Menu debugPrompt = _debugPrompt;
			PromptParams promptParams = new PromptParams();
			promptParams.data = promptData;
			systemPromptStack.Push(debugPrompt, promptParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60032BF")]
		[Cpp2IlInjected.Address(RVA = "0xCA3A30", Offset = "0xCA2430", VA = "0x180CA3A30")]
		[AsyncStateMachine(typeof(_003CShowAlertMessage_003Ed__6))]
		private Task ShowAlertMessage(string title, string subtitle, string message, bool isSystem, Exception e, bool allowClose, IEnumerable<OptionWithCallback> options)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60032E6")]
		[Cpp2IlInjected.Address(RVA = "0xC9E1D0", Offset = "0xC9CBD0", VA = "0x180C9E1D0")]
		public bool IsControllerConnected(bool useKeyboardAsController = false)
		{
			int num = 0;
			ControllerType lastControllerType = InputDetectionHelper.GetLastControllerType();
			int num2 = 0;
			int num3 = 0;
			if (!DebugSettings.Settings.forceNoGamepad_)
			{
				if (useKeyboardAsController)
				{
					if (2L > 1L)
					{
						return 2L == 2L;
					}
				}
				else if (2L != 2L)
				{
					int num4 = 0;
					return InputDetectionHelper.IsConsole();
				}
				return true;
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032E8")]
		[Cpp2IlInjected.Address(RVA = "0xCA5CC0", Offset = "0xCA46C0", VA = "0x180CA5CC0")]
		private void Start()
		{
			//IL_0058: Expected O, but got I4
			GameObject prefab = InventorySlotPool.prefabSource.prefab;
			DialogueSystem system = SystemRoot.Instance.GetSystem<DialogueSystem>();
			AsyncEventHandler<DialogueInstance> asyncEventHandler = (AsyncEventHandler<DialogueInstance>)(object)new AsyncEventHandler<T>(NewDialogueStartedEvent);
			system.add_NewDialogueStartedEvent((AsyncEventHandler<>)(object)asyncEventHandler);
			GridEditMode gridEditMode = (gridEditModeSystem = SystemRoot.Instance.GetSystem<GridEditMode>());
			GridEditMode gridEditMode2 = gridEditModeSystem;
			int num = 0;
			if (gridEditMode2 != (UnityEngine.Object)num)
			{
				GridEditMode gridEditMode3 = gridEditModeSystem;
				GridObjectGizmoSystem.SelectedObjectChangedDelegate value = EditModeSelectedObjectChanged;
				gridEditMode3.SelectedObjectChangedEvent += value;
			}
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.DebugMessage value2 = ShowDebugMessage;
			metaClient.OnDebugMessage += value2;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			Client.DebugPrompt value3 = ShowDebugPrompt;
			metaClient2.OnDebugPrompt += value3;
			Client metaClient3 = SystemRoot.Instance.MetaClient;
			Client.GenericMessage value4 = ShowAlertMessage;
			metaClient3.OnGenericMessage += value4;
			Client metaClient4 = SystemRoot.Instance.MetaClient;
			Client.InfoMessage value5 = ShowInfoMessage;
			metaClient4.OnInfoMessage += value5;
			Client metaClient5 = SystemRoot.Instance.MetaClient;
			Client.RemoteTransactionError value6 = ShowRemoteTransactionErrorPrompt;
			metaClient5.OnRemoteTransactionError += value6;
			Client metaClient6 = SystemRoot.Instance.MetaClient;
			Client.DebugError value7 = ShowDebugErrorPrompt;
			metaClient6.OnDebugError += value7;
			Client metaClient7 = SystemRoot.Instance.MetaClient;
			Client.OnlineValidationFailure value8 = OnlineValidationFailure;
			metaClient7.OnOnlineValidationFailure += value8;
			Client metaClient8 = SystemRoot.Instance.MetaClient;
			Client.GameInitializationErrorDetected value9 = GameInitializationErrorDetected;
			metaClient8.OnGameInitializationError += value9;
			Client.SoftReset value10 = default(Client.SoftReset);
			SystemRoot.Instance.MetaClient.OnSoftReset += value10;
			Client.SoftReset value11 = default(Client.SoftReset);
			SystemRoot.Instance.MetaClient.OnForceQuit += value11;
			ProfileEventDispatcher profileEventDispatcher = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.LootPresentConsumed value12 = OnLootPresentConsumed;
			profileEventDispatcher.OnLootPresentConsumed += value12;
			ProfileEventDispatcher profileEventDispatcher2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.MissionSlotUpdated value13 = OnMissionSlotUpdated;
			profileEventDispatcher2.OnMissionSlotUpdated += value13;
			ProfileEventDispatcher profileEventDispatcher3 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.RestaurantOrderFulfilled value14 = OnRestaurantOrderFulfilled;
			profileEventDispatcher3.OnRestaurantOrderFulfilled += value14;
			ProfileEventDispatcher profileEventDispatcher4 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CollectionSetUpdated value15 = OnCollectionSetUpdated;
			profileEventDispatcher4.OnCollectionSetUpdated += value15;
			ProfileEventDispatcher profileEventDispatcher5 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.FriendshipAdded value16 = OnFriendshipAdded;
			profileEventDispatcher5.OnFriendshipAdded += value16;
			ProfileEventDispatcher profileEventDispatcher6 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterFriendshipLevelChanged value17 = OnFriendshipLevelChanged;
			profileEventDispatcher6.OnCharacterFriendshipLevelChanged += value17;
			ProfileEventDispatcher profileEventDispatcher7 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterFriendshipChanged value18 = OnCharacterFriendshipChanged;
			profileEventDispatcher7.OnCharacterFriendshipChanged += value18;
			ProfileEventDispatcher profileEventDispatcher8 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ManaChanged value19 = OnManaChanged;
			profileEventDispatcher8.OnManaChanged += value19;
			ProfileEventDispatcher profileEventDispatcher9 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.MemoryShardAdded value20 = OnMemoryShardAddedHandler;
			profileEventDispatcher9.OnMemoryShardAdded += value20;
			Mdl.LocalizationManager localizationManager = SystemRoot.Instance._localizationManager;
			EventHandler value21 = OnLanguageChanged;
			localizationManager.OnLanguageChanged += value21;
			ProfileEventDispatcher profileEventDispatcher10 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ItemsSentToInbox value22 = OnItemsSentToInbox;
			profileEventDispatcher10.OnItemsSentToInbox += value22;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032E9")]
		[Cpp2IlInjected.Address(RVA = "0xCA81F0", Offset = "0xCA6BF0", VA = "0x180CA81F0")]
		private void UpdateAlertStatus(bool value)
		{
			GenericAlertOnTop = value;
		}

		[Cpp2IlInjected.Token(Token = "0x60032EA")]
		[Cpp2IlInjected.Address(RVA = "0xC9EEA0", Offset = "0xC9D8A0", VA = "0x180C9EEA0")]
		private void OnCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromConsumable = false)
		{
			//Discarded unreachable code: IL_004b
			//IL_001e: Expected O, but got I4
			//IL_0027: Expected I4, but got I8
			//IL_004a: Expected I4, but got I8
			//IL_004a: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			ItemDatabase itemDatabase = ItemDatabase.Instance;
			int num = 0;
			CollectionMenu.CollectionMenuParam collectionMenuParam = new CollectionMenu.CollectionMenuParam();
			MealItemData mealItemData = default(MealItemData);
			int iD = mealItemData.ID;
			collectionMenuParam.Item = (Item)iD;
			collectionMenuParam.SelectedTab = CollectionSubMenu.Meals;
			RedirectionManager redirection = Redirection;
			int num2 = 0;
			ulong num3 = default(ulong);
			redirection.Redirect(RedirectionType.MenuCollection, collectionMenuParam, (PlayerTaskCollider)num2, (ItemFilterData)num, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num != 0, (byte)num3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60032EB")]
		[Cpp2IlInjected.Address(RVA = "0xC9F530", Offset = "0xC9DF30", VA = "0x180C9F530")]
		private void OnDestroy()
		{
			//IL_0023: Expected O, but got I8
			//IL_002c: Expected O, but got I8
			//IL_003d: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_02cb: Expected O, but got I4
			//IL_0314: Expected O, but got I4
			//IL_03e0: Expected O, but got I4
			int num = 0;
			bool flag = UILocalStorage.Save();
			UIExclusiveWaiter exclusiveWaiter = _exclusiveWaiter;
			exclusiveWaiter._semaphore.Dispose();
			exclusiveWaiter._semaphore = (SemaphoreSlim)0;
			_exclusiveWaiter = (UIExclusiveWaiter)0;
			SystemRoot systemRoot = SystemRoot.Instance;
			int num2 = 0;
			if (systemRoot != (UnityEngine.Object)num2)
			{
				DialogueSystem system = SystemRoot.Instance.GetSystem<DialogueSystem>();
				int num3 = 0;
				if (system != (UnityEngine.Object)num3)
				{
					AsyncEventHandler<DialogueInstance> asyncEventHandler = (AsyncEventHandler<DialogueInstance>)(object)new AsyncEventHandler<T>(NewDialogueStartedEvent);
					DialogueSystem dialogueSystem = default(DialogueSystem);
					dialogueSystem.remove_NewDialogueStartedEvent((AsyncEventHandler<>)(object)asyncEventHandler);
				}
				GridEditMode gridEditMode = gridEditModeSystem;
				int num4 = 0;
				if (gridEditMode != (UnityEngine.Object)num4)
				{
					GridEditMode gridEditMode2 = gridEditModeSystem;
					GridObjectGizmoSystem.SelectedObjectChangedDelegate value = EditModeSelectedObjectChanged;
					gridEditMode2.SelectedObjectChangedEvent -= value;
				}
				if (SystemRoot.Instance.MetaClient != null)
				{
					Client.DebugMessage value2 = ShowDebugMessage;
					Client client = default(Client);
					client.OnDebugMessage -= value2;
					Client.DebugPrompt value3 = ShowDebugPrompt;
					Client client2 = default(Client);
					client2.OnDebugPrompt -= value3;
					Client.GenericMessage value4 = ShowAlertMessage;
					Client client3 = default(Client);
					client3.OnGenericMessage -= value4;
					Client.InfoMessage value5 = ShowInfoMessage;
					Client client4 = default(Client);
					client4.OnInfoMessage -= value5;
					Client.RemoteTransactionError value6 = ShowRemoteTransactionErrorPrompt;
					Client client5 = default(Client);
					client5.OnRemoteTransactionError -= value6;
					Client.DebugError value7 = ShowDebugErrorPrompt;
					Client client6 = default(Client);
					client6.OnDebugError -= value7;
					Client.OnlineValidationFailure value8 = OnlineValidationFailure;
					Client client7 = default(Client);
					client7.OnOnlineValidationFailure -= value8;
					Client.GameInitializationErrorDetected value9 = GameInitializationErrorDetected;
					Client client8 = default(Client);
					client8.OnGameInitializationError -= value9;
					Client client9 = default(Client);
					ProfileEventDispatcher profileEventDispatcher = client9.Dispatcher;
					ProfileEventDispatcher.LootPresentConsumed value10 = OnLootPresentConsumed;
					profileEventDispatcher.OnLootPresentConsumed -= value10;
					Client client10 = default(Client);
					ProfileEventDispatcher profileEventDispatcher2 = client10.Dispatcher;
					ProfileEventDispatcher.MissionSlotUpdated value11 = OnMissionSlotUpdated;
					profileEventDispatcher2.OnMissionSlotUpdated -= value11;
					Client client11 = default(Client);
					ProfileEventDispatcher profileEventDispatcher3 = client11.Dispatcher;
					ProfileEventDispatcher.RestaurantOrderFulfilled value12 = OnRestaurantOrderFulfilled;
					profileEventDispatcher3.OnRestaurantOrderFulfilled -= value12;
					Client client12 = default(Client);
					ProfileEventDispatcher profileEventDispatcher4 = client12.Dispatcher;
					ProfileEventDispatcher.CollectionSetUpdated value13 = OnCollectionSetUpdated;
					profileEventDispatcher4.OnCollectionSetUpdated -= value13;
					Client client13 = default(Client);
					ProfileEventDispatcher profileEventDispatcher5 = client13.Dispatcher;
					ProfileEventDispatcher.FriendshipAdded value14 = OnFriendshipAdded;
					profileEventDispatcher5.OnFriendshipAdded -= value14;
					Client client14 = default(Client);
					ProfileEventDispatcher profileEventDispatcher6 = client14.Dispatcher;
					ProfileEventDispatcher.CharacterFriendshipLevelChanged value15 = OnFriendshipLevelChanged;
					profileEventDispatcher6.OnCharacterFriendshipLevelChanged -= value15;
					Client client15 = default(Client);
					ProfileEventDispatcher profileEventDispatcher7 = client15.Dispatcher;
					ProfileEventDispatcher.CharacterFriendshipChanged value16 = OnCharacterFriendshipChanged;
					profileEventDispatcher7.OnCharacterFriendshipChanged -= value16;
					Client client16 = default(Client);
					ProfileEventDispatcher profileEventDispatcher8 = client16.Dispatcher;
					ProfileEventDispatcher.ManaChanged value17 = OnManaChanged;
					profileEventDispatcher8.OnManaChanged -= value17;
					Client client17 = default(Client);
					ProfileEventDispatcher profileEventDispatcher9 = client17.Dispatcher;
					ProfileEventDispatcher.MemoryShardAdded value18 = OnMemoryShardAddedHandler;
					profileEventDispatcher9.OnMemoryShardAdded -= value18;
					Client client18 = default(Client);
					ProfileEventDispatcher profileEventDispatcher10 = client18.Dispatcher;
					ProfileEventDispatcher.ItemsSentToInbox value19 = OnItemsSentToInbox;
					profileEventDispatcher10.OnItemsSentToInbox -= value19;
				}
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				int num5 = 0;
				if (avatar != (UnityEngine.Object)num5)
				{
					Action action = LowManaEvent;
					avatar.LowManaEvent -= action;
					IntPtr method = ((Delegate)action).method;
					Action action2 = NotEnoughManaEvent;
				}
				Mdl.LocalizationManager localizationManager = SystemRoot.Instance._localizationManager;
				int num6 = 0;
				if (localizationManager != (UnityEngine.Object)num6)
				{
					EventHandler value20 = OnLanguageChanged;
					localizationManager.OnLanguageChanged -= value20;
				}
			}
			Cutscene.OnStartedPlaying -= OnCutsceneStarted;
			Cutscene.OnFinishedPlaying -= OnCutsceneFinished;
			MenuStack menuStack = _menuStack;
			MenuStack.CurrentMenuChanged value21 = CurrentMenuChanged;
			menuStack.OnCurrentMenuChanged -= value21;
			MenuStack popupStack = _popupStack;
			MenuStack.CurrentMenuChanged value22 = CurrentPopupChanged;
			popupStack.OnCurrentMenuChanged -= value22;
			MenuStack systemPromptStack = _systemPromptStack;
			MenuStack.CurrentMenuChanged value23 = CurrentPromptChanged;
			systemPromptStack.OnCurrentMenuChanged -= value23;
			Throbber throbber = _throbber;
			Throbber.VisibilityChanged value24 = OnThrobberKeyStackChanged;
			throbber.OnVisibilityChanged -= value24;
			VirtualJoystick virtualJoystick = joystick;
			int num7 = 0;
			if (virtualJoystick != (UnityEngine.Object)num7)
			{
				VirtualJoystick virtualJoystick2 = joystick;
				VirtualJoystick.OnJoystickChangeStateDelegate value25 = OnJoystickChangeHander;
				virtualJoystick2.OnJoystickChangeState -= value25;
			}
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= OnEnvironmentEntered;
			PlayFabSysHttp.RequestPlayFabReloginCB -= RequestPlayFabReloginCB;
			PlayFabSysHttp.OnPlayFabErrorCB -= OnPlayFabErrorCB;
			ReInput.remove_ControllerDisconnectedEvent((Action<>)(object)new Action<T>(OnControllerDisconnected));
			UnityEvent<bool> onGenericAlertOnOff = Dispatcher.OnGenericAlertOnOff;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(UpdateAlertStatus);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032EC")]
		[Cpp2IlInjected.Address(RVA = "0xC9E660", Offset = "0xC9D060", VA = "0x180C9E660")]
		private void LateUpdate()
		{
			//IL_0009: Expected O, but got I4
			//IL_0009: Expected O, but got I4
			int num = 0;
			TweenMax.UpdateAll(0, (EventArgs)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60032ED")]
		[Cpp2IlInjected.Address(RVA = "0xC9C070", Offset = "0xC9AA70", VA = "0x180C9C070")]
		private void CurrentMenuChanged(IMenu menu)
		{
			//Discarded unreachable code: IL_002f
			MenuStack menuStack = _menuStack;
			CanvasScaler canvasScaler = menuStack._canvasScaler;
			if (menu == null || (object)menuStack != null)
			{
			}
			if (menu == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			string menuName = default(string);
			RaiseMenuChanged(menuName);
			CurrentUIChanged();
		}

		[Cpp2IlInjected.Token(Token = "0x60032EE")]
		[Cpp2IlInjected.Address(RVA = "0xC9C1E0", Offset = "0xC9ABE0", VA = "0x180C9C1E0")]
		private void CurrentPopupChanged(IMenu menu)
		{
			//Discarded unreachable code: IL_002f
			MenuStack popupStack = _popupStack;
			CanvasScaler canvasScaler = popupStack._canvasScaler;
			if (menu == null || (object)popupStack != null)
			{
			}
			if (menu == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			string popupName = default(string);
			RaisePopupChanged(popupName);
			CurrentUIChanged();
		}

		[Cpp2IlInjected.Token(Token = "0x60032EF")]
		[Cpp2IlInjected.Address(RVA = "0xC9C350", Offset = "0xC9AD50", VA = "0x180C9C350")]
		private void CurrentPromptChanged(IMenu menu)
		{
			CurrentUIChanged();
		}

		[Cpp2IlInjected.Token(Token = "0x60032F0")]
		[Cpp2IlInjected.Address(RVA = "0xC9C360", Offset = "0xC9AD60", VA = "0x180C9C360")]
		private void CurrentUIChanged()
		{
			//Discarded unreachable code: IL_005d
			joystick.Release();
			IconAtlasCache iconAtlasCacheBig = _iconAtlasCacheBig;
			int maxInCache = 0;
			bool flag = ((AssetCache<Key, AssetType>)(object)iconAtlasCacheBig).CleanupCache(maxInCache);
			IconAtlasCache iconAtlasCacheSmall = _iconAtlasCacheSmall;
			int maxInCache2 = 0;
			bool flag2 = ((AssetCache<Key, AssetType>)(object)iconAtlasCacheSmall).CleanupCache(maxInCache2);
			IconAtlasCache iconAtlasCacheTiny = _iconAtlasCacheTiny;
			int maxInCache3 = 0;
			bool flag3 = ((AssetCache<Key, AssetType>)(object)iconAtlasCacheTiny).CleanupCache(maxInCache3);
			SpriteCache spriteCache = _spriteCache;
			int maxInCache4 = 0;
			bool flag4 = ((AssetCache<Key, AssetType>)(object)spriteCache).CleanupCache(maxInCache4);
		}

		[Cpp2IlInjected.Token(Token = "0x60032F1")]
		[Cpp2IlInjected.Address(RVA = "0xC9E8E0", Offset = "0xC9D2E0", VA = "0x180C9E8E0")]
		public void MenuSectionChange(string menuSectionName)
		{
			IDesignerHost activeDesigner = ((IDesignerEventService)this).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x60032F2")]
		[Cpp2IlInjected.Address(RVA = "0xC9F410", Offset = "0xC9DE10", VA = "0x180C9F410")]
		private void OnCutsceneStarted(Cutscene cutscene)
		{
			//Discarded unreachable code: IL_004e
			bool flag = ((List<T>)(object)Cutscenes).Contains((T)cutscene);
			if (!flag)
			{
				((List<T>)(object)Cutscenes).Add((T)cutscene);
				Func<int> func = (cutscene.SkipKeyCodeFetcher = (Func<int>)(object)(Func<TResult>)delegate
				{
					//Discarded unreachable code: IL_0024
					int useKeyboardAsController = 0;
					if (!IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						ShortcutDefinition self = _skipCutsceneKeyboard.Self;
					}
					return _skipCutsceneGamepad.RewiredActionId;
				});
			}
			SetUIForCutscene();
			int num = 0;
			if (!flag)
			{
				int num2 = 0;
				if (!PlatformUtils.IsPCPlayer())
				{
					return;
				}
			}
			CursorWrapper.Visible = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60032F3")]
		[Cpp2IlInjected.Address(RVA = "0xC9F310", Offset = "0xC9DD10", VA = "0x180C9F310")]
		private void OnCutsceneFinished(Cutscene cutscene)
		{
			//Discarded unreachable code: IL_0039
			if (((List<T>)(object)Cutscenes).Contains((T)cutscene))
			{
				bool flag = ((List<T>)(object)Cutscenes).Remove((T)cutscene);
			}
			Action action = RestorUIFromCutscene;
			float _003CFadeOutDuration_003Ek__BackingField = cutscene.FadeOutDuration;
			Coroutine coroutine = Coroutines.Delay(action, _003CFadeOutDuration_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x60032F4")]
		[Cpp2IlInjected.Address(RVA = "0xCA0ED0", Offset = "0xC9F8D0", VA = "0x180CA0ED0")]
		private void OnThrobberKeyStackChanged()
		{
			//Discarded unreachable code: IL_0043
			//IL_002f: Expected O, but got I4
			SystemRoot systemRoot = SystemRoot.Instance;
			if ((object)systemRoot != null)
			{
				PlayerNavigation system = systemRoot.GetSystem<PlayerNavigation>();
			}
			if (!_throbber.ShouldBlockInput)
			{
				PlayerNavigation.TemporaryOverrideScope overrideAllScope = OverrideAllScope;
				int num = 0;
				OverrideAllScope = (PlayerNavigation.TemporaryOverrideScope)num;
			}
			else
			{
				bool flag = default(bool);
				while (flag)
				{
				}
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				PlayerNavigation.TemporaryOverrideScope overrideAllScope2 = default(PlayerNavigation.TemporaryOverrideScope);
				OverrideAllScope = overrideAllScope2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032F5")]
		[Cpp2IlInjected.Address(RVA = "0xCA3450", Offset = "0xCA1E50", VA = "0x180CA3450")]
		public void SetUIForCutscene()
		{
			//Discarded unreachable code: IL_00cf
			//IL_0081: Expected O, but got I4
			//IL_00b6: Expected O, but got I4
			Canvas[] array = (_allCanvases = GetComponentsInChildren<Canvas>());
			Canvas[] allCanvases = _allCanvases;
			int num = 0;
			int length = allCanvases.Length;
			if (num < length)
			{
				Canvas canvas = allCanvases[num];
				if (!string.Equals(canvas.gameObject.name, "FadeEffect") && !string.Equals(canvas.gameObject.name, "CutsceneSkipVisual"))
				{
					int num2 = ((canvas.enabled = false) ? 1 : 0);
					GraphicRaycaster component = canvas.GetComponent<GraphicRaycaster>();
					int num3 = 0;
					if (component != (UnityEngine.Object)num3)
					{
						GraphicRaycaster component2 = canvas.GetComponent<GraphicRaycaster>();
						int num4 = ((component2.enabled = false) ? 1 : 0);
					}
				}
				num++;
			}
			HudMenu menu = _menuStack.GetMenu<HudMenu>();
			int num5 = 0;
			if (menu != (UnityEngine.Object)num5)
			{
				RadialToolMenu radialToolMenu = menu._radialToolMenu;
				int resetToolOnHide = 0;
				radialToolMenu.Toggle((byte)resetToolOnHide != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032F6")]
		[Cpp2IlInjected.Address(RVA = "0xCA2BE0", Offset = "0xCA15E0", VA = "0x180CA2BE0")]
		public void RestorUIFromCutscene()
		{
			//Discarded unreachable code: IL_00f6
			//IL_0015: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			DialogueMenu menu = _menuStack.GetMenu<DialogueMenu>();
			int num = 0;
			if (menu == (UnityEngine.Object)num)
			{
				RefreshQuestMarkers();
			}
			Canvas[] allCanvases = _allCanvases;
			if (allCanvases == null)
			{
				return;
			}
			int num2 = 0;
			int length = allCanvases.Length;
			if (num2 < length)
			{
				Canvas canvas = allCanvases[num2];
				int num3 = 0;
				if (!(canvas == (UnityEngine.Object)num3) && !string.Equals(canvas.gameObject.name, "FadeEffect") && !string.Equals(canvas.gameObject.name, "CutsceneSkipVisual"))
				{
					GameObject gameObject = canvas.gameObject;
					int num4 = 0;
					if (gameObject != (UnityEngine.Object)num4)
					{
						canvas.enabled = true;
						GraphicRaycaster component = canvas.GetComponent<GraphicRaycaster>();
						int num5 = 0;
						if (component != (UnityEngine.Object)num5)
						{
							canvas.GetComponent<GraphicRaycaster>().enabled = true;
						}
					}
				}
				num2++;
			}
			MenuStack menuStack = _menuStack;
			int num6 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num7 = 0;
				if (top == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032F7")]
		[Cpp2IlInjected.Address(RVA = "0xC9B7D0", Offset = "0xC9A1D0", VA = "0x180C9B7D0")]
		public void ApplySafeAreaToMenuStack(bool hasSafeArea)
		{
			//Discarded unreachable code: IL_000d
			_menuStackSafeArea.UseSafeArea(hasSafeArea);
		}

		[Cpp2IlInjected.Token(Token = "0x60032F8")]
		[Cpp2IlInjected.Address(RVA = "0xC9E880", Offset = "0xC9D280", VA = "0x180C9E880", Slot = "47")]
		public override void LoadMainMenu()
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected O, but got I4
			MenuStack menuStack = _menuStack;
			AsyncMenu mainMenu = _mainMenu;
			int num = 0;
			menuStack.Push(mainMenu, (MenuParam)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60032F9")]
		[Cpp2IlInjected.Address(RVA = "0xC9E850", Offset = "0xC9D250", VA = "0x180C9E850", Slot = "48")]
		public override void LoadMainMenuSettings()
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected O, but got I4
			MenuStack popupStack = _popupStack;
			AsyncMenu mainMenuSettings = _mainMenuSettings;
			int num = 0;
			popupStack.Push(mainMenuSettings, (MenuParam)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60032FA")]
		[Cpp2IlInjected.Address(RVA = "0xC9E820", Offset = "0xC9D220", VA = "0x180C9E820", Slot = "49")]
		public override void LoadMainMenuRoadmap()
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected O, but got I4
			MenuStack popupStack = _popupStack;
			AsyncMenu mainMenuRoadmap = _mainMenuRoadmap;
			int num = 0;
			popupStack.Push(mainMenuRoadmap, (MenuParam)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60032FB")]
		[Cpp2IlInjected.Address(RVA = "0xC9E7F0", Offset = "0xC9D1F0", VA = "0x180C9E7F0", Slot = "50")]
		public override void LoadMainMenuLinkAccount()
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected O, but got I4
			MenuStack popupStack = _popupStack;
			AsyncMenu mainMenuLinkAccount = _mainMenuLinkAccount;
			int num = 0;
			popupStack.Push(mainMenuLinkAccount, (MenuParam)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60032FC")]
		[Cpp2IlInjected.Address(RVA = "0xC9E7C0", Offset = "0xC9D1C0", VA = "0x180C9E7C0", Slot = "52")]
		public override void LoadMainMenuCredits()
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected O, but got I4
			MenuStack popupStack = _popupStack;
			AsyncMenu mainMenuCredits = _mainMenuCredits;
			int num = 0;
			popupStack.Push(mainMenuCredits, (MenuParam)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60032FD")]
		[Cpp2IlInjected.Address(RVA = "0xC9E900", Offset = "0xC9D300", VA = "0x180C9E900")]
		[AsyncStateMachine(typeof(_003CNewDialogueStartedEvent_003Ed__185))]
		private Task NewDialogueStartedEvent(object sender, DialogueInstance e)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60032FE")]
		[Cpp2IlInjected.Address(RVA = "0xC9E6B0", Offset = "0xC9D0B0", VA = "0x180C9E6B0", Slot = "56")]
		[AsyncStateMachine(typeof(_003CLoadHud_003Ed__186))]
		public override Task LoadHud()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60032FF")]
		[Cpp2IlInjected.Address(RVA = "0xCA2680", Offset = "0xCA1080", VA = "0x180CA2680", Slot = "5")]
		public override Task PlayCharacterSummon(Mdl.Characters.Character character, GameObject summonEffect)
		{
			//Discarded unreachable code: IL_0018
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!(character != (UnityEngine.Object)num) || flag)
			{
			}
			int num2 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6003300")]
		[Cpp2IlInjected.Address(RVA = "0xC9CA00", Offset = "0xC9B400", VA = "0x180C9CA00", Slot = "4")]
		public override Task Fade(float duration, Color startColor, Color endColor, EasingFunction easing, LoadingLogoAction logoAction = LoadingLogoAction.None, bool preventSameColorTransition = true, bool isIconMiddle = false)
		{
			LoadingLogoAction logoAction2 = LoadingLogoAction.None;
			bool isIconMiddle2 = false;
			TaskCompletionSource<bool> tcs;
			TaskCompletionSource<bool> taskCompletionSource = (tcs = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
			LoadingLogoAction loadingLogoAction = logoAction2;
			if ((long)taskCompletionSource == 4294967293L)
			{
				FadeEffect fadeEffect = _fadeEffect;
				float duration2 = duration;
				bool isVisible = loadingLogoAction == LoadingLogoAction.ShowAtStart;
				if (loadingLogoAction != LoadingLogoAction.ShowAtStart)
				{
				}
				bool isMiddle = isIconMiddle2;
				fadeEffect.SetLogoVisibility(isVisible, duration2, isMiddle);
			}
			FadeEffect fadeEffect2 = _fadeEffect;
			Tween<Color>.FinishEventHandler finishEventHandler = (Tween<Color>.FinishEventHandler)(object)(Tween<T>.FinishEventHandler)delegate
			{
				//Discarded unreachable code: IL_0048
				//IL_0045: Expected O, but got I4
				LoadingLogoAction loadingLogoAction2 = logoAction2;
				UiRoot uiRoot = this;
				bool isVisible2 = loadingLogoAction2 == LoadingLogoAction.ShowAtEnd;
				FadeEffect fadeEffect3 = uiRoot._fadeEffect;
				float duration3 = duration;
				if (loadingLogoAction2 != LoadingLogoAction.ShowAtEnd)
				{
				}
				bool isMiddle2 = isIconMiddle2;
				fadeEffect3.SetLogoVisibility(isVisible2, duration3, isMiddle2);
				bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)1);
			};
			Task<> task = (Task<>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003301")]
		[Cpp2IlInjected.Address(RVA = "0xC9DDA0", Offset = "0xC9C7A0", VA = "0x180C9DDA0")]
		[AsyncStateMachine(typeof(_003CInstantiateAsync_003Ed__189))]
		public Task<GameObject> InstantiateAsync(object assetKey, Transform parent)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003302")]
		[Cpp2IlInjected.Address(RVA = "0xC9C8D0", Offset = "0xC9B2D0", VA = "0x180C9C8D0")]
		private void EditModeSelectedObjectChanged(GridObjectScript previous, GridObjectScript current)
		{
			//Discarded unreachable code: IL_0056
			//IL_0015: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			GameObject selectedGameObject = gridEditModeSystem.SelectedGameObject;
			int num = 0;
			if (selectedGameObject == (UnityEngine.Object)num)
			{
				int num2 = 0;
				PositionHandler positionHandler = Instance._worldCanvas._positionHandler;
				int num3 = 0;
				if (positionHandler != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					UnityEngine.Object.Destroy(Instance._worldCanvas._positionHandler.gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003303")]
		[Cpp2IlInjected.Address(RVA = "0xCA2780", Offset = "0xCA1180", VA = "0x180CA2780", Slot = "6")]
		[AsyncStateMachine(typeof(_003CPlayerTaskChoiceDialog_003Ed__191))]
		public override Task<int> PlayerTaskChoiceDialog(List<PlayerTaskDefinition> playerTasks, GameObject target, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<int>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003304")]
		[Cpp2IlInjected.Address(RVA = "0xCA3B80", Offset = "0xCA2580", VA = "0x180CA3B80", Slot = "12")]
		public override void ShowCollectionReminder(CollectionSubMenu collectionSubMenu, string stringID)
		{
			//Discarded unreachable code: IL_0023
			_menuStack.GetMenu<HudMenu>()._collectionReminder._reminderStringID = stringID;
			HudMenu menu = _menuStack.GetMenu<HudMenu>();
		}

		[Cpp2IlInjected.Token(Token = "0x6003305")]
		[Cpp2IlInjected.Address(RVA = "0xCA1BD0", Offset = "0xCA05D0", VA = "0x180CA1BD0", Slot = "7")]
		[AsyncStateMachine(typeof(_003COpenMenu_003Ed__193))]
		public override Task OpenMenu(AssetReference menuAssetReference, bool isPopup = false, bool waitUntilExit = true, params object[] parameters)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003306")]
		[Cpp2IlInjected.Address(RVA = "0xCA2530", Offset = "0xCA0F30", VA = "0x180CA2530", Slot = "8")]
		public override Task OpenSystemMenu(AssetReference menuAssetReference, params object[] parameters)
		{
			MenuStack systemPromptStack = _systemPromptStack;
			return OpenMenu(menuAssetReference, systemPromptStack, waitUntilExit: true, parameters);
		}

		[Cpp2IlInjected.Token(Token = "0x6003307")]
		[Cpp2IlInjected.Address(RVA = "0xCA1D20", Offset = "0xCA0720", VA = "0x180CA1D20")]
		private Task OpenMenu(AssetReference menuAssetReference, MenuStack stack, bool waitUntilExit, params object[] parameters)
		{
			//IL_0038: Expected O, but got I4
			TaskCompletionSource<bool> tcs = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>();
			MenuParam menuParam = new MenuParam();
			Action onPopAction = delegate
			{
				//Discarded unreachable code: IL_000e
				//IL_000c: Expected O, but got I4
				bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)1);
			};
			if (!waitUntilExit)
			{
			}
			menuParam.OnPopAction = onPopAction;
			menuParam.Params = (object[])0;
			if (Redirection.GetRedirectionType(menuAssetReference) == RedirectionType.None)
			{
				AsyncMenu asyncMenu = ScriptableObject.CreateInstance<AsyncMenu>();
				asyncMenu.assetRef = menuAssetReference;
				stack.Push(asyncMenu, menuParam);
			}
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			RedirectionManager redirection = Redirection;
			CancellationToken token = cancellationTokenSource.Token;
			int num = 0;
			Task task = default(Task);
			task.FireAndForgetTask();
			int taskId = task.m_taskId;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003308")]
		[Cpp2IlInjected.Address(RVA = "0xCA1A60", Offset = "0xCA0460", VA = "0x180CA1A60", Slot = "9")]
		[AsyncStateMachine(typeof(_003COpenMenuWithAnswer_003Ed__196))]
		public override Task<int> OpenMenuWithAnswer(AssetReference menuAssetReference, bool isPopup = false, params object[] parameters)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<int>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003309")]
		[Cpp2IlInjected.Address(RVA = "0xC9C720", Offset = "0xC9B120", VA = "0x180C9C720", Slot = "38")]
		[AsyncStateMachine(typeof(_003CDisplayInfoGizmo_003Ed__197))]
		public override Task DisplayInfoGizmo(GameObject target, GameObject infoGizmoPrefab, CancellationToken ct, params object[] parameters)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600330A")]
		[Cpp2IlInjected.Address(RVA = "0xC9C5C0", Offset = "0xC9AFC0", VA = "0x180C9C5C0", Slot = "39")]
		[AsyncStateMachine(typeof(_003CDisplayInfoGizmo_003Ed__198))]
		public override Task DisplayInfoGizmo(GameObject target, AssetReferenceGameObject infoGizmoPrefab, CancellationToken ct, params object[] parameters)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600330B")]
		[Cpp2IlInjected.Address(RVA = "0xCA51E0", Offset = "0xCA3BE0", VA = "0x180CA51E0", Slot = "41")]
		public override void ShowQuestMarkers()
		{
			//Discarded unreachable code: IL_000c
			_worldCanvas.ShowQuestMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x600330C")]
		[Cpp2IlInjected.Address(RVA = "0xC9DCC0", Offset = "0xC9C6C0", VA = "0x180C9DCC0", Slot = "42")]
		public override bool HideQuestMarkers()
		{
			//Discarded unreachable code: IL_000c
			return _worldCanvas.HideQuestMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x600330D")]
		[Cpp2IlInjected.Address(RVA = "0xCA4C20", Offset = "0xCA3620", VA = "0x180CA4C20", Slot = "43")]
		public override void ShowLootOfflineMarkers()
		{
			//Discarded unreachable code: IL_000c
			_worldCanvas.ShowLootOfflineMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x600330E")]
		[Cpp2IlInjected.Address(RVA = "0xC9DC60", Offset = "0xC9C660", VA = "0x180C9DC60", Slot = "44")]
		public override void HideLootOfflineMarkers()
		{
			//Discarded unreachable code: IL_0015
			int active = 0;
			OnJoystickChangeHander((byte)active != 0);
			_worldCanvas.HideLootOfflineMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x600330F")]
		[Cpp2IlInjected.Address(RVA = "0xCA4C50", Offset = "0xCA3650", VA = "0x180CA4C50", Slot = "45")]
		public override void ShowMailboxMarkers()
		{
			//Discarded unreachable code: IL_000c
			_worldCanvas.ShowMailboxMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003310")]
		[Cpp2IlInjected.Address(RVA = "0xC9DC90", Offset = "0xC9C690", VA = "0x180C9DC90", Slot = "46")]
		public override void HideMailboxMarkers()
		{
			//Discarded unreachable code: IL_0015
			int active = 0;
			OnJoystickChangeHander((byte)active != 0);
			_worldCanvas.HideMailboxMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003311")]
		[Cpp2IlInjected.Address(RVA = "0xCA83E0", Offset = "0xCA6DE0", VA = "0x180CA83E0", Slot = "57")]
		[AsyncStateMachine(typeof(_003CWaitForHUD_003Ed__205))]
		public override Task WaitForHUD(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003312")]
		[Cpp2IlInjected.Address(RVA = "0xCA8510", Offset = "0xCA6F10", VA = "0x180CA8510")]
		[AsyncStateMachine(typeof(_003CWaitForInfoGizmo_003Ed__206))]
		private static Task WaitForInfoGizmo(InfoGizmo infoGizmo, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003313")]
		[Cpp2IlInjected.Address(RVA = "0xCA09C0", Offset = "0xC9F3C0", VA = "0x180CA09C0", Slot = "40")]
		public override void RefreshQuestMarkers()
		{
			//Discarded unreachable code: IL_000c
			_worldCanvas.RefreshQuestMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003314")]
		[Cpp2IlInjected.Address(RVA = "0xCA44B0", Offset = "0xCA2EB0", VA = "0x180CA44B0", Slot = "53")]
		public override void ShowHud()
		{
			//Discarded unreachable code: IL_0042
			//IL_001b: Expected O, but got I4
			int num = 0;
			HudMenu menu = Instance._menuStack.GetMenu<HudMenu>();
			int num2 = 0;
			if (!(menu == (UnityEngine.Object)num2))
			{
				int num3 = 0;
				if (Instance._menuStack.Top == null)
				{
				}
				int num4 = 0;
				bool flag = default(bool);
				if (!flag)
				{
					menu.Show();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003315")]
		[Cpp2IlInjected.Address(RVA = "0xC9DB00", Offset = "0xC9C500", VA = "0x180C9DB00", Slot = "54")]
		public override void HideHud()
		{
			//Discarded unreachable code: IL_0042
			//IL_001b: Expected O, but got I4
			int num = 0;
			HudMenu menu = Instance._menuStack.GetMenu<HudMenu>();
			int num2 = 0;
			if (!(menu == (UnityEngine.Object)num2))
			{
				int num3 = 0;
				if (Instance._menuStack.Top == null)
				{
				}
				int num4 = 0;
				bool flag = default(bool);
				if (!flag)
				{
					menu.Hide();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003316")]
		[Cpp2IlInjected.Address(RVA = "0xC9BE70", Offset = "0xC9A870", VA = "0x180C9BE70", Slot = "55")]
		public override void ClearHud()
		{
			//Discarded unreachable code: IL_0048
			//IL_001b: Expected O, but got I4
			int num = 0;
			HudMenu menu = Instance._menuStack.GetMenu<HudMenu>();
			int num2 = 0;
			if (!(menu == (UnityEngine.Object)num2))
			{
				int num3 = 0;
				if (Instance._menuStack.Top == null)
				{
				}
				int num4 = 0;
				bool flag = default(bool);
				if (!flag)
				{
					menu.HideBuffTip();
					menu.HideCollectionReminder();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003317")]
		[Cpp2IlInjected.Address(RVA = "0xCA32A0", Offset = "0xCA1CA0", VA = "0x180CA32A0", Slot = "58")]
		public override void SetHudCritterQueueNotif(bool enable)
		{
			//Discarded unreachable code: IL_0032
			//IL_001b: Expected O, but got I4
			int num = 0;
			HudMenu menu = Instance._menuStack.GetMenu<HudMenu>();
			int num2 = 0;
			if (menu != (UnityEngine.Object)num2)
			{
				int num3 = 0;
				if (IsOnTop<HudMenu>((byte)num3 != 0))
				{
					menu.SetCritterQueueNotif(enable);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003318")]
		[Cpp2IlInjected.Address(RVA = "0xCA5210", Offset = "0xCA3C10", VA = "0x180CA5210", Slot = "59")]
		public override void ShowQueuedCritterNotifs()
		{
			//Discarded unreachable code: IL_0042
			//IL_001b: Expected O, but got I4
			int num = 0;
			HudMenu menu = Instance._menuStack.GetMenu<HudMenu>();
			int num2 = 0;
			if (!(menu == (UnityEngine.Object)num2))
			{
				int num3 = 0;
				if (Instance._menuStack.Top == null)
				{
				}
				int num4 = 0;
				bool flag = default(bool);
				if (!flag)
				{
					menu.ShowQueuedCritterNotifs();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003319")]
		[Cpp2IlInjected.Address(RVA = "0xCA28F0", Offset = "0xCA12F0", VA = "0x180CA28F0", Slot = "60")]
		public override void PopAllFromPopupStack()
		{
			//Discarded unreachable code: IL_000c
			_popupStack.PopAll();
		}

		[Cpp2IlInjected.Token(Token = "0x600331A")]
		[Cpp2IlInjected.Address(RVA = "0xCA2910", Offset = "0xCA1310", VA = "0x180CA2910", Slot = "61")]
		public override void PopMenuStack()
		{
			//Discarded unreachable code: IL_000c
			_menuStack.Pop();
		}

		[Cpp2IlInjected.Token(Token = "0x600331B")]
		[Cpp2IlInjected.Address(RVA = "0xC9D990", Offset = "0xC9C390", VA = "0x180C9D990", Slot = "62")]
		public override void GoBackToHudMenu()
		{
			//Discarded unreachable code: IL_0057
			int num = 0;
			if (Instance._menuStack.Count <= 0)
			{
				return;
			}
			int num2 = 0;
			MenuStack menuStack = Instance._menuStack;
			int num3 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num4 = 0;
				if (top != null)
				{
					return;
				}
			}
			MenuStack menuStack2 = _menuStack;
			Type typeFromHandle = typeof(HudMenu);
			menuStack2.PopAllAbove(typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600331D")]
		[Cpp2IlInjected.Address(RVA = "0x35C3070", Offset = "0x35C1A70", VA = "0x1835C3070")]
		public bool IsOnTop<T>(bool P_0)
		{
			bool isAnyAlertVisible = IsAnyAlertVisible;
			if (!isAnyAlertVisible && (P_0 || !_throbber.Visible))
			{
				MenuStack popupStack = _popupStack;
				if (isAnyAlertVisible)
				{
					return true;
				}
				if (popupStack.IsEmpty)
				{
					IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)popupStack).get_ElementIdentifiers();
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600331E")]
		[Cpp2IlInjected.Address(RVA = "0xC9E310", Offset = "0xC9CD10", VA = "0x180C9E310")]
		public bool IsOnTop(Menu menu, bool ignoreThrobber = false)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(menu == (UnityEngine.Object)num) && menu.gameObject.activeInHierarchy)
			{
				int num2 = 0;
				if ((object)menu != null)
				{
					goto IL_0099;
				}
				if (_systemPromptStack.IsEmpty && !_systemAlert.gameObject.activeInHierarchy && !_genericAlert.gameObject.activeInHierarchy && (ignoreThrobber || !_throbber.Visible))
				{
					if (_popupStack.IsOnTop(menu))
					{
						goto IL_0099;
					}
					if (_popupStack.IsEmpty)
					{
						return _menuStack.IsOnTop(menu);
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
			IL_0099:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003320")]
		[Cpp2IlInjected.Address(RVA = "0xCA7D70", Offset = "0xCA6770", VA = "0x180CA7D70", Slot = "63")]
		[AsyncStateMachine(typeof(_003CUIAlert_003Ed__222))]
		public override Task<GenericAlertAction> UIAlert(string message, string title = "", string confirmLabel = "menu.button_common_okay", string cancelLabel = "menu.button_common_cancel", bool showCancelButton = false, bool showCloseButton = true, [System.Runtime.InteropServices.Optional] string iconPath, bool showConfirmButton = true, bool dismissAfter = true, bool isHandoverCodePopup = false, bool showPurchaseButton = false, [System.Runtime.InteropServices.Optional] IItemData costCurrency, int costAmount = 0, string purchaseLabel = "Shop.btn_free", [System.Runtime.InteropServices.Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<GenericAlertAction>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003321")]
		[Cpp2IlInjected.Address(RVA = "0xCA7F60", Offset = "0xCA6960", VA = "0x180CA7F60", Slot = "64")]
		[AsyncStateMachine(typeof(_003CUIAlert_003Ed__223))]
		public override Task<AlertButton> UIAlert(IEnumerable<string> messages, IEnumerable<AlertButton> buttons, string title = "", bool showCloseButton = true, string popupSfx = "", [System.Runtime.InteropServices.Optional] AK.Wwise.Event confirmSfx, [System.Runtime.InteropServices.Optional] AK.Wwise.Event cancelSfx, [System.Runtime.InteropServices.Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AlertButton>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003322")]
		[Cpp2IlInjected.Address(RVA = "0xCA7B90", Offset = "0xCA6590", VA = "0x180CA7B90", Slot = "65")]
		[AsyncStateMachine(typeof(_003CUIAlert_003Ed__224))]
		public override Task<AlertButton> UIAlert(string message, IEnumerable<AlertButton> buttons, string title = "", bool showCloseButton = true, string popupSfx = "", [System.Runtime.InteropServices.Optional] AK.Wwise.Event confirmSfx, [System.Runtime.InteropServices.Optional] AK.Wwise.Event cancelSfx, [System.Runtime.InteropServices.Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AlertButton>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003323")]
		[Cpp2IlInjected.Address(RVA = "0xCA7910", Offset = "0xCA6310", VA = "0x180CA7910", Slot = "66")]
		[AsyncStateMachine(typeof(_003CSystemAlertAsync_003Ed__225))]
		public override Task<AlertButton> SystemAlertAsync(string message, [System.Runtime.InteropServices.Optional] IEnumerable<AlertButton> buttons, string title = "", string devNote = "", [System.Runtime.InteropServices.Optional] Exception exception, bool allowClose = true, [System.Runtime.InteropServices.Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AlertButton>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003324")]
		[Cpp2IlInjected.Address(RVA = "0xCA43B0", Offset = "0xCA2DB0", VA = "0x180CA43B0", Slot = "69")]
		public override void ShowDisconnectedControllerPrompt(PromptData promptData)
		{
			//Discarded unreachable code: IL_001e
			_disconnectGamepadMessage.SetActive(value: true);
			_disconnectGamepadMessage.GetComponent<DisconnectedControllerPrompt>().Init(promptData);
		}

		[Cpp2IlInjected.Token(Token = "0x6003325")]
		[Cpp2IlInjected.Address(RVA = "0xCA4430", Offset = "0xCA2E30", VA = "0x180CA4430", Slot = "67")]
		public override IDisposable ShowGenericMessage(string message)
		{
			GenericMessage genericMessage = _genericMessage;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003326")]
		[Cpp2IlInjected.Address(RVA = "0xCA5720", Offset = "0xCA4120", VA = "0x180CA5720", Slot = "68")]
		public override void ShowSharePrompt(PromptData promptData, int type)
		{
			//Discarded unreachable code: IL_0043
			if (type == 0)
			{
				int num = 0;
				UiRoot instance = Instance;
			}
			if (type == 1)
			{
				int num2 = 0;
				UiRoot instance2 = Instance;
				QRPrompt menu = shareQRPrefab;
				MenuStack popupStack = instance2._popupStack;
				PromptParams promptParams = new PromptParams();
				promptParams.data = promptData;
				popupStack.Push(menu, promptParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003327")]
		[Cpp2IlInjected.Address(RVA = "0xCA4E20", Offset = "0xCA3820", VA = "0x180CA4E20", Slot = "71")]
		public override void ShowNotEnoughCurrencyPopUp(IItemData itemData, int requiredAmount, [System.Runtime.InteropServices.Optional] Item? productItem)
		{
			//Discarded unreachable code: IL_0042
			NotEnoughCurrencyArgs notEnoughCurrencyArgs = new NotEnoughCurrencyArgs();
			notEnoughCurrencyArgs.CurrencyItemData = itemData;
			notEnoughCurrencyArgs.CurrencyAmount = requiredAmount;
			List<Item> list = (notEnoughCurrencyArgs.ProductItems = (List<Item>)(object)new List<T>());
			int num = 0;
			MenuStack popupStack = Instance._popupStack;
			AsyncMenu notEnoughCurrencyPopUp = _notEnoughCurrencyPopUp;
			popupStack.Push(notEnoughCurrencyPopUp, notEnoughCurrencyArgs);
		}

		[Cpp2IlInjected.Token(Token = "0x6003328")]
		[Cpp2IlInjected.Address(RVA = "0xCA5890", Offset = "0xCA4290", VA = "0x180CA5890")]
		public IDisposable ShowThrobber(string key, Throbber.Display display)
		{
			Throbber throbber = _throbber;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003329")]
		[Cpp2IlInjected.Address(RVA = "0xCA57F0", Offset = "0xCA41F0", VA = "0x180CA57F0", Slot = "13")]
		public override IDisposable ShowThrobber(string key, bool showLogo = true, bool freezeRendering = false)
		{
			Throbber throbber = _throbber;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600332A")]
		[Cpp2IlInjected.Address(RVA = "0xC9DCF0", Offset = "0xC9C6F0", VA = "0x180C9DCF0", Slot = "14")]
		public override IDisposable HideThrobber(string key)
		{
			Throbber throbber = _throbber;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600332B")]
		[Cpp2IlInjected.Address(RVA = "0xCA8170", Offset = "0xCA6B70", VA = "0x180CA8170")]
		public void UnknownError([System.Runtime.InteropServices.Optional] string msg)
		{
			//Discarded unreachable code: IL_0018
			//IL_0017: Expected I4, but got I8
			GenericAlert genericAlert = _genericAlert;
			int showCloseButton = 0;
			ulong num = default(ulong);
			genericAlert.Alert(msg, "Error", (byte)showCloseButton != 0, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600332C")]
		[Cpp2IlInjected.Address(RVA = "0xCA8140", Offset = "0xCA6B40", VA = "0x180CA8140", Slot = "70")]
		public override void UiErrorMessage(string msg, float duration = 2f)
		{
			//Discarded unreachable code: IL_0013
			UIErrorMessage uiMessage = _uiMessage;
			int showDuplicates = 0;
			uiMessage.ShowMessage(msg, duration, (byte)showDuplicates != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600332D")]
		[Cpp2IlInjected.Address(RVA = "0xC9C450", Offset = "0xC9AE50", VA = "0x180C9C450", Slot = "72")]
		[AsyncStateMachine(typeof(_003CDisplayGiveUI_003Ed__235))]
		public override Task<List<GiveItemsToCharacter.Types.ItemGiven>> DisplayGiveUI(CancellationToken ct, int maximumAmount = 1, [System.Runtime.InteropServices.Optional] ItemFilterData itemFilter, bool missionGift = false, [System.Runtime.InteropServices.Optional] Meta.Character character, [System.Runtime.InteropServices.Optional] Mdl.Characters.Critters.Critter critter)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<List<GiveItemsToCharacter.Types.ItemGiven>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600332E")]
		[Cpp2IlInjected.Address(RVA = "0xCA1480", Offset = "0xC9FE80", VA = "0x180CA1480", Slot = "73")]
		public override void OpenCatalog(ItemFilterData itemFilterData)
		{
			//Discarded unreachable code: IL_0024
			//IL_0023: Expected I4, but got I8
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			RedirectionManager redirection = Redirection;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuCatalog, (MenuParam)num3, (PlayerTaskCollider)num2, itemFilterData, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600332F")]
		[Cpp2IlInjected.Address(RVA = "0xCA2620", Offset = "0xCA1020", VA = "0x180CA2620", Slot = "74")]
		public override void OpenWardrobe(ItemFilterData itemFilterData)
		{
			//Discarded unreachable code: IL_0024
			//IL_0023: Expected I4, but got I8
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			RedirectionManager redirection = Redirection;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuWardrobe, (MenuParam)num3, (PlayerTaskCollider)num2, itemFilterData, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003330")]
		[Cpp2IlInjected.Address(RVA = "0xCA20B0", Offset = "0xCA0AB0", VA = "0x180CA20B0", Slot = "76")]
		public override void OpenPhone(int tabIndex)
		{
			//Discarded unreachable code: IL_002f
			//IL_002e: Expected I4, but got I8
			//IL_002e: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			RedirectionManager redirection = Redirection;
			PhoneMenu.PhoneMenuParam phoneMenuParam = new PhoneMenu.PhoneMenuParam();
			phoneMenuParam.DefaultTab = tabIndex;
			int num = 0;
			int num2 = 0;
			ulong num3 = default(ulong);
			redirection.Redirect(RedirectionType.MenuPhone, phoneMenuParam, (PlayerTaskCollider)num2, (ItemFilterData)num, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num != 0, (byte)num3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003331")]
		[Cpp2IlInjected.Address(RVA = "0xCA2350", Offset = "0xCA0D50", VA = "0x180CA2350", Slot = "77")]
		public override void OpenRoyalDuties()
		{
			//Discarded unreachable code: IL_001e
			//IL_0019: Expected O, but got I4
			//IL_0019: Expected O, but got I4
			if (_menuStack.Top == null)
			{
				int num = 0;
				int num2 = 0;
				bool flag = (UnityEngine.Object)num != (UnityEngine.Object)num2;
			}
			else
			{
				int num3 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003332")]
		[Cpp2IlInjected.Address(RVA = "0xCA2610", Offset = "0xCA1010", VA = "0x180CA2610")]
		private void OpenURL(string URL)
		{
			Application.OpenURL(URL);
		}

		[Cpp2IlInjected.Token(Token = "0x6003333")]
		[Cpp2IlInjected.Address(RVA = "0xCA2560", Offset = "0xCA0F60", VA = "0x180CA2560")]
		public void OpenTermOfUse([System.Runtime.InteropServices.Optional] Action onAcceptButton)
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected I4, but got I8
			DisclaimerPrompt.DisclaimerPromptParam disclaimerPromptParam = new DisclaimerPrompt.DisclaimerPromptParam();
			if (onAcceptButton != null)
			{
				disclaimerPromptParam.OnAcceptButton = onAcceptButton;
			}
			disclaimerPromptParam.ContentOnly = true;
			disclaimerPromptParam.MenuState = DisclaimerState.TOU;
			MenuStack popupStack = _popupStack;
			AsyncMenu disclaimerPrompt = _disclaimerPrompt;
			popupStack.Push(disclaimerPrompt, disclaimerPromptParam);
		}

		[Cpp2IlInjected.Token(Token = "0x6003334")]
		[Cpp2IlInjected.Address(RVA = "0xCA19B0", Offset = "0xCA03B0", VA = "0x180CA19B0")]
		public void OpenEula([System.Runtime.InteropServices.Optional] Action onAcceptButton)
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected I4, but got I8
			DisclaimerPrompt.DisclaimerPromptParam disclaimerPromptParam = new DisclaimerPrompt.DisclaimerPromptParam();
			if (onAcceptButton != null)
			{
				disclaimerPromptParam.OnAcceptButton = onAcceptButton;
			}
			disclaimerPromptParam.ContentOnly = true;
			disclaimerPromptParam.MenuState = DisclaimerState.EULA;
			MenuStack popupStack = _popupStack;
			AsyncMenu disclaimerPrompt = _disclaimerPrompt;
			popupStack.Push(disclaimerPrompt, disclaimerPromptParam);
		}

		[Cpp2IlInjected.Token(Token = "0x6003335")]
		[Cpp2IlInjected.Address(RVA = "0xCA22A0", Offset = "0xCA0CA0", VA = "0x180CA22A0")]
		public void OpenPrivacyPolicy([System.Runtime.InteropServices.Optional] Action onAcceptButton)
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected I4, but got I8
			DisclaimerPrompt.DisclaimerPromptParam disclaimerPromptParam = new DisclaimerPrompt.DisclaimerPromptParam();
			if (onAcceptButton != null)
			{
				disclaimerPromptParam.OnAcceptButton = onAcceptButton;
			}
			disclaimerPromptParam.ContentOnly = true;
			disclaimerPromptParam.MenuState = DisclaimerState.PRIVACY_POLICY;
			MenuStack popupStack = _popupStack;
			AsyncMenu disclaimerPrompt = _disclaimerPrompt;
			popupStack.Push(disclaimerPrompt, disclaimerPromptParam);
		}

		[Cpp2IlInjected.Token(Token = "0x6003336")]
		[Cpp2IlInjected.Address(RVA = "0xCA14E0", Offset = "0xC9FEE0", VA = "0x180CA14E0")]
		public void OpenCookiesPolicy([System.Runtime.InteropServices.Optional] Action onAcceptButton)
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected I4, but got I8
			DisclaimerPrompt.DisclaimerPromptParam disclaimerPromptParam = new DisclaimerPrompt.DisclaimerPromptParam();
			if (onAcceptButton != null)
			{
				disclaimerPromptParam.OnAcceptButton = onAcceptButton;
			}
			disclaimerPromptParam.ContentOnly = true;
			disclaimerPromptParam.MenuState = DisclaimerState.COOKIES;
			MenuStack popupStack = _popupStack;
			AsyncMenu disclaimerPrompt = _disclaimerPrompt;
			popupStack.Push(disclaimerPrompt, disclaimerPromptParam);
		}

		[Cpp2IlInjected.Token(Token = "0x6003337")]
		[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0A00", VA = "0x180CA2000")]
		public void OpenParentalInfo([System.Runtime.InteropServices.Optional] Action onAcceptButton)
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected I4, but got I8
			DisclaimerPrompt.DisclaimerPromptParam disclaimerPromptParam = new DisclaimerPrompt.DisclaimerPromptParam();
			if (onAcceptButton != null)
			{
				disclaimerPromptParam.OnAcceptButton = onAcceptButton;
			}
			disclaimerPromptParam.ContentOnly = true;
			disclaimerPromptParam.MenuState = DisclaimerState.PARENTAL_INFO;
			MenuStack popupStack = _popupStack;
			AsyncMenu disclaimerPrompt = _disclaimerPrompt;
			popupStack.Push(disclaimerPrompt, disclaimerPromptParam);
		}

		[Cpp2IlInjected.Token(Token = "0x6003338")]
		[Cpp2IlInjected.Address(RVA = "0xCA17A0", Offset = "0xCA01A0", VA = "0x180CA17A0")]
		public void OpenDiscord()
		{
			//Discarded unreachable code: IL_0030
			if (TrackingManager.Instance != null)
			{
				string text = "Discord: " + "http://www.discord.com/";
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				int num = 0;
			}
			Application.OpenURL("http://www.discord.com/");
		}

		[Cpp2IlInjected.Token(Token = "0x6003339")]
		[Cpp2IlInjected.Address(RVA = "0xCA1590", Offset = "0xC9FF90", VA = "0x180CA1590")]
		public void OpenCustomerCare()
		{
			//Discarded unreachable code: IL_0030
			if (TrackingManager.Instance != null)
			{
				string text = "CustomerCare: " + "https://gameloft.helpshift.com/a/disney-dreamlight-valley/?p=web";
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				int num = 0;
			}
			Application.OpenURL("https://gameloft.helpshift.com/a/disney-dreamlight-valley/?p=web");
		}

		[Cpp2IlInjected.Token(Token = "0x600333A")]
		[Cpp2IlInjected.Address(RVA = "0xC9C890", Offset = "0xC9B290", VA = "0x180C9C890", Slot = "10")]
		public override Task DoPostCharacterUnlockFlow(Item characterItem, bool skipPhotoMode, CancellationToken ct, bool fastFade = false)
		{
			//Discarded unreachable code: IL_0009
			RedirectionManager redirection = Redirection;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600333B")]
		[Cpp2IlInjected.Address(RVA = "0xCA2160", Offset = "0xCA0B60", VA = "0x180CA2160", Slot = "11")]
		[AsyncStateMachine(typeof(_003COpenPhotoMenu_003Ed__249))]
		public override Task OpenPhotoMenu(PhotoModeType photoMode, CancellationToken ct, [System.Runtime.InteropServices.Optional] Transform freeCamStartTransform)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600333C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnJoystickChangeHander(bool active)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600333D")]
		[Cpp2IlInjected.Address(RVA = "0xCA5920", Offset = "0xCA4320", VA = "0x180CA5920", Slot = "98")]
		public override void ShowTutorialBlocker()
		{
			//Discarded unreachable code: IL_001d
			TutorialView._blocker.SetActive(value: true);
			joystick.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x600333E")]
		[Cpp2IlInjected.Address(RVA = "0xC9DD70", Offset = "0xC9C770", VA = "0x180C9DD70", Slot = "99")]
		public override void HideTutorialBlocker()
		{
			//Discarded unreachable code: IL_0016
			GameObject blocker = TutorialView._blocker;
			int active = 0;
			blocker.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600333F")]
		[Cpp2IlInjected.Address(RVA = "0xCA3380", Offset = "0xCA1D80", VA = "0x180CA3380", Slot = "100")]
		public override void SetItemPreview(GameObject target)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = target != (UnityEngine.Object)num;
			ItemPreview itemPreview = _itemPreview;
			if (!flag)
			{
				if ((object)itemPreview != null)
				{
					itemPreview.ResetTarget();
					ItemPreview itemPreview2 = _itemPreview;
					if ((object)itemPreview2 != null)
					{
						IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)itemPreview2).get_ElementIdentifiers();
					}
				}
			}
			else if ((object)itemPreview != null)
			{
				itemPreview.SetTargetByGO(target, cloneRequired: true);
				_itemPreview?.Show();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003340")]
		[Cpp2IlInjected.Address(RVA = "0x35C2F90", Offset = "0x35C1990", VA = "0x1835C2F90", Slot = "101")]
		public override T GetDebugProperty<T>(string propertyName)
		{
			object obj = ((ICloneable)propertyName).Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003341")]
		[Cpp2IlInjected.Address(RVA = "0x35C3140", Offset = "0x35C1B40", VA = "0x1835C3140", Slot = "102")]
		public override void SetDebugProperty<T>(string propertyName, T newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003342")]
		[Cpp2IlInjected.Address(RVA = "0xCA0A70", Offset = "0xC9F470", VA = "0x180CA0A70")]
		private void OnLootPresentConsumed(MultiItemInstance rewards, int boxIndex)
		{
			//Discarded unreachable code: IL_007a
			//IL_0079: Expected I4, but got I8
			//IL_0079: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			PresentPopUpParam presentPopUpParam2 = new PresentPopUpParam();
			List<ItemReward> list = (presentPopUpParam2.Rewards = (List<ItemReward>)(object)new List<T>());
			presentPopUpParam2.BoxIndex = boxIndex;
			PresentPopUpParam presentPopUpParam = presentPopUpParam2;
			RepeatedField<ItemInstance> items_ = rewards.items_;
			Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
			{
				//Discarded unreachable code: IL_0020
				List<ItemReward> _003CRewards_003Ek__BackingField = presentPopUpParam.Rewards;
				int itemID = x.Item.ItemID;
				ItemReward item = default(ItemReward);
				((List<T>)(object)_003CRewards_003Ek__BackingField).Add((T)item);
			};
			ListExt.ForEach<ItemInstance>((IReadOnlyList<>)(object)items_, (Action<>)(object)action);
			RedirectionManager redirection = Redirection;
			PresentPopUpParam menuParam = presentPopUpParam;
			int num = 0;
			int num2 = 0;
			ulong num3 = default(ulong);
			redirection.Redirect(RedirectionType.MenuPresent, menuParam, (PlayerTaskCollider)num2, (ItemFilterData)num, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num != 0, (byte)num3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003343")]
		[Cpp2IlInjected.Address(RVA = "0xCA09C0", Offset = "0xC9F3C0", VA = "0x180CA09C0")]
		private void OnMissionSlotUpdated(MissionSlotClass SlotClass, int SlotId, MissionItemData missionData, SlotUpdatedReason reason, [System.Runtime.InteropServices.Optional] List<AnyReward> rewards)
		{
			//Discarded unreachable code: IL_000c
			_worldCanvas.RefreshQuestMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003344")]
		[Cpp2IlInjected.Address(RVA = "0xCA09C0", Offset = "0xC9F3C0", VA = "0x180CA09C0")]
		private void OnRestaurantOrderFulfilled(CharacterRestaurantOrder order, ItemWithState mealServed)
		{
			//Discarded unreachable code: IL_000c
			_worldCanvas.RefreshQuestMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003347")]
		[Cpp2IlInjected.Address(RVA = "0xCA0920", Offset = "0xC9F320", VA = "0x180CA0920")]
		private void OnFriendshipAdded(AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_002e
			if (!mustPostponeFriendshipAdded)
			{
				((UnityEvent<T0>)(object)Dispatcher.OnFriendshipAdded)?.Invoke((T0)addedFriendshipSummary);
			}
			else
			{
				((List<T>)(object)postponedFriendshipAdded).Add((T)addedFriendshipSummary);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003348")]
		[Cpp2IlInjected.Address(RVA = "0xCA09C0", Offset = "0xC9F3C0", VA = "0x180CA09C0")]
		private void OnFriendshipLevelChanged(Item characterItem, int levelsGained)
		{
			//Discarded unreachable code: IL_000c
			_worldCanvas.RefreshQuestMarkers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003349")]
		[Cpp2IlInjected.Address(RVA = "0xC9ED30", Offset = "0xC9D730", VA = "0x180C9ED30")]
		private void OnCharacterFriendshipChanged(Meta.Character character, int friendshipChange, int oldLevel, int newLevel, FriendshipSource friendshipSource)
		{
			//Discarded unreachable code: IL_006a
			//IL_0031: Expected O, but got I4
			//IL_0069: Expected I4, but got I8
			int num = 0;
			UiRoot instance = Instance;
			uint num2 = num2 + 20;
			num2 += num2;
			if ((object)instance != null)
			{
				if (character != null)
				{
					string displayName_ = character.Data.displayName_;
					int num3 = 0;
					string text = LocalizationManager.FromStringID(displayName_, (IResolver)num3);
				}
				int num4 = 0;
				UiRoot instance2 = Instance;
				UIErrorMessage uiMessage = instance2._uiMessage;
				string message = string.Format("{0} gained {1} friendship", "", instance2);
				ulong num5 = default(ulong);
				uiMessage.ShowMessage(message, 0.7f, (byte)num5 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600334A")]
		[Cpp2IlInjected.Address(RVA = "0xCA08E0", Offset = "0xC9F2E0", VA = "0x180CA08E0")]
		private void OnEnvironmentEntered(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0017
			_worldCanvas.RefreshQuestMarkers();
			_worldCanvas.RemoveNotEnoughMana();
		}

		[Cpp2IlInjected.Token(Token = "0x600334B")]
		[Cpp2IlInjected.Address(RVA = "0xCA0C30", Offset = "0xC9F630", VA = "0x180CA0C30")]
		private void OnManaChanged(int oldValue, int newValue, bool refill, ProfileEventDispatcher.ManaSpentData _)
		{
			//Discarded unreachable code: IL_001f
			_worldCanvas.RemoveNotEnoughMana();
			if (refill && newValue > oldValue)
			{
				_worldCanvas.ShowManaRefillGizmo();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600334C")]
		[Cpp2IlInjected.Address(RVA = "0xCA0CA0", Offset = "0xC9F6A0", VA = "0x180CA0CA0")]
		private void OnMemoryShardAddedHandler(Item memoryShardItem, int memoryShardIndex, AddDetail detail)
		{
			//Discarded unreachable code: IL_0070
			//IL_001b: Expected O, but got I4
			//IL_0024: Expected I4, but got I8
			//IL_0039: Expected O, but got I4
			//IL_006f: Expected I4, but got I8
			//IL_006f: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			int itemID = memoryShardItem.ItemID;
			CollectionMenu.CollectionMenuParam collectionMenuParam = new CollectionMenu.CollectionMenuParam();
			collectionMenuParam.CurrentIndex = memoryShardIndex;
			collectionMenuParam.Item = (Item)itemID;
			collectionMenuParam.SelectedTab = CollectionSubMenu.Memories;
			InventoryMenu menu = _menuStack.GetMenu<InventoryMenu>();
			int num = 0;
			if (menu != (UnityEngine.Object)num)
			{
				collectionMenuParam.OnlyShardPopup = true;
			}
			RedirectionManager redirection = Redirection;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuCollection, collectionMenuParam, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600334D")]
		[Cpp2IlInjected.Address(RVA = "0xCA09F0", Offset = "0xC9F3F0", VA = "0x180CA09F0")]
		private void OnItemsSentToInbox(List<InboxItemReward> items, ItemsSentToInboxReason reason)
		{
			string text = "menu.inbox_items_sent_generic";
			if (reason == ItemsSentToInboxReason.InventoryFull)
			{
				text = "menu.inbox_items_sent_inventory_full";
			}
			IDesignerHost activeDesigner = ((IDesignerEventService)this).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x600334E")]
		[Cpp2IlInjected.Address(RVA = "0xCA0A60", Offset = "0xC9F460", VA = "0x180CA0A60")]
		private void OnLanguageChanged(object sender, EventArgs args)
		{
			int num = 0;
			TextBase.RefreshAllLocalizedText();
		}

		[Cpp2IlInjected.Token(Token = "0x600334F")]
		[Cpp2IlInjected.Address(RVA = "0xCA5BE0", Offset = "0xCA45E0", VA = "0x180CA5BE0", Slot = "15")]
		public override void StartLevelUpAnimationBlocker()
		{
			TaskCompletionSource<bool> taskCompletionSource = (_levelUpAnimationTCS = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003350")]
		[Cpp2IlInjected.Address(RVA = "0xCA7830", Offset = "0xCA6230", VA = "0x180CA7830", Slot = "16")]
		public override void StopLevelUpAnimationBlocker()
		{
			//IL_0012: Expected O, but got I4
			//IL_001c: Expected O, but got I8
			TaskCompletionSource<bool> levelUpAnimationTCS = _levelUpAnimationTCS;
			if (levelUpAnimationTCS != null)
			{
				bool flag = ((TaskCompletionSource<TResult>)(object)levelUpAnimationTCS).TrySetResult((TResult)1);
				_levelUpAnimationTCS = (TaskCompletionSource<bool>)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003352")]
		[Cpp2IlInjected.Address(RVA = "0xCA5B50", Offset = "0xCA4550", VA = "0x180CA5B50", Slot = "20")]
		public override void StartFriendshipAddedBlocker()
		{
			if (!mustPostponeFriendshipAdded)
			{
				mustPostponeFriendshipAdded = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003353")]
		[Cpp2IlInjected.Address(RVA = "0xCA7820", Offset = "0xCA6220", VA = "0x180CA7820", Slot = "21")]
		public override void StopFriendshipAddedBlocker()
		{
			int num = ((MustPostponeFriendshipAdded = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003354")]
		[Cpp2IlInjected.Address(RVA = "0xCA8640", Offset = "0xCA7040", VA = "0x180CA8640", Slot = "104")]
		public override Task<IDisposable> WaitingExclusive()
		{
			//Discarded unreachable code: IL_0012
			UIExclusiveWaiter exclusiveWaiter = _exclusiveWaiter;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IDisposable>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003355")]
		[Cpp2IlInjected.Address(RVA = "0xCA5AE0", Offset = "0xCA44E0", VA = "0x180CA5AE0")]
		public void StartFriendshipAddedAnimationBlocker()
		{
			TaskCompletionSource<bool> taskCompletionSource = (friendshipAddedAnimationBlockerTCS = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003356")]
		[Cpp2IlInjected.Address(RVA = "0xCA77B0", Offset = "0xCA61B0", VA = "0x180CA77B0")]
		public void StopFriendshipAddedAnimationBlocker()
		{
			//IL_0012: Expected O, but got I4
			//IL_001c: Expected O, but got I8
			TaskCompletionSource<bool> taskCompletionSource = friendshipAddedAnimationBlockerTCS;
			if (taskCompletionSource != null)
			{
				bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)1);
				friendshipAddedAnimationBlockerTCS = (TaskCompletionSource<bool>)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003358")]
		[Cpp2IlInjected.Address(RVA = "0xCA5C50", Offset = "0xCA4650", VA = "0x180CA5C50", Slot = "23")]
		public override void StartRewardAnimationBlocker()
		{
			TaskCompletionSource<bool> taskCompletionSource = (rewardAnimationBlockerTCS = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003359")]
		[Cpp2IlInjected.Address(RVA = "0xCA78A0", Offset = "0xCA62A0", VA = "0x180CA78A0", Slot = "24")]
		public override void StopRewardAnimationBlocker()
		{
			//IL_0012: Expected O, but got I4
			//IL_001c: Expected O, but got I8
			TaskCompletionSource<bool> taskCompletionSource = rewardAnimationBlockerTCS;
			if (taskCompletionSource != null)
			{
				bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)1);
				rewardAnimationBlockerTCS = (TaskCompletionSource<bool>)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600335B")]
		[Cpp2IlInjected.Address(RVA = "0xCA4A50", Offset = "0xCA3450", VA = "0x180CA4A50", Slot = "78")]
		public override Task<int> ShowLockedRegionPopup(int requiredLevel, int requiredCharacterUnlocked, CurrencyCost cost, Item unlockCharacter, string title = "", bool isRealm = false, int requiredMana = 0)
		{
			//Discarded unreachable code: IL_0084
			//IL_0028: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			LockedVillageAreaPopup.LockedVillageAreaParam lockedVillageAreaParam = new LockedVillageAreaPopup.LockedVillageAreaParam();
			lockedVillageAreaParam.UnlockCost = cost;
			lockedVillageAreaParam.RequiredLevel = requiredLevel;
			lockedVillageAreaParam.CharacterRequired = requiredCharacterUnlocked;
			lockedVillageAreaParam.UnlockedCharacterRequired = (Item)0;
			lockedVillageAreaParam.Title = (string)0;
			lockedVillageAreaParam.IsRealm = false;
			lockedVillageAreaParam.RequiredMana = 0;
			TaskCompletionSource<int> tcs = (TaskCompletionSource<int>)(object)new TaskCompletionSource<TResult>();
			Action<int> action = (lockedVillageAreaParam.AnswerAction = (Action<int>)(object)(Action<T>)delegate(int answer)
			{
				//Discarded unreachable code: IL_000e
				//IL_000c: Expected O, but got I4
				bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)answer);
			});
			MenuStack popupStack = _popupStack;
			AsyncMenu lockedVillageAreaPopup = _lockedVillageAreaPopup;
			popupStack.Push(lockedVillageAreaPopup, lockedVillageAreaParam);
			return (Task<int>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x600335C")]
		[Cpp2IlInjected.Address(RVA = "0xCA38F0", Offset = "0xCA22F0", VA = "0x180CA38F0", Slot = "79")]
		[AsyncStateMachine(typeof(_003CShowAgeGateDisclaimerPrompt_003Ed__291))]
		public override Task<bool> ShowAgeGateDisclaimerPrompt([System.Runtime.InteropServices.Optional] Action onAcceptButton)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600335D")]
		[Cpp2IlInjected.Address(RVA = "0xC9B950", Offset = "0xC9A350", VA = "0x180C9B950")]
		private void CheckAgeGateResult()
		{
			//Discarded unreachable code: IL_0056
			int num = 0;
			bool flag = UIAgeGateStorage.Load();
			if (int.Parse(UIAgeGateStorage.Get("UserAge", "0")) > 15)
			{
				int num2 = 0;
				if (Application.platform != 0)
				{
					int num3 = 0;
					if (Application.platform != RuntimePlatform.OSXPlayer)
					{
						goto IL_004e;
					}
				}
				SystemRoot.Instance.initPlatformMacOS();
			}
			SystemRoot.Instance.Client.SetForceOfflineReason(ForceOfflineReasonFlag.AgeGate);
			goto IL_004e;
			IL_004e:
			bool flag2 = BaseUiRoot.isAgeGatePassed;
		}

		[Cpp2IlInjected.Token(Token = "0x600335E")]
		[Cpp2IlInjected.Address(RVA = "0xCA4310", Offset = "0xCA2D10", VA = "0x180CA4310", Slot = "80")]
		public override void ShowDisclaimerPrompt([System.Runtime.InteropServices.Optional] Action onAcceptButton)
		{
			//Discarded unreachable code: IL_0028
			DisclaimerPrompt.DisclaimerPromptParam disclaimerPromptParam = new DisclaimerPrompt.DisclaimerPromptParam();
			if (onAcceptButton != null)
			{
				disclaimerPromptParam.OnAcceptButton = onAcceptButton;
			}
			MenuStack popupStack = _popupStack;
			AsyncMenu disclaimerPrompt = _disclaimerPrompt;
			popupStack.Push(disclaimerPrompt, disclaimerPromptParam);
		}

		[Cpp2IlInjected.Token(Token = "0x600335F")]
		[Cpp2IlInjected.Address(RVA = "0xCA4910", Offset = "0xCA3310", VA = "0x180CA4910", Slot = "82")]
		[AsyncStateMachine(typeof(_003CShowLevelUpMenu_003Ed__294))]
		public override Task ShowLevelUpMenu(object menuParams, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003360")]
		[Cpp2IlInjected.Address(RVA = "0xCA50A0", Offset = "0xCA3AA0", VA = "0x180CA50A0", Slot = "83")]
		[AsyncStateMachine(typeof(_003CShowProfessionSelectionMenu_003Ed__295))]
		public override Task ShowProfessionSelectionMenu(Item characterItem, CancellationToken ct)
		{
			int itemID = characterItem.ItemID;
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003361")]
		[Cpp2IlInjected.Address(RVA = "0xCA4F70", Offset = "0xCA3970", VA = "0x180CA4F70", Slot = "84")]
		[AsyncStateMachine(typeof(_003CShowProfessionChangedMenu_003Ed__296))]
		public override Task ShowProfessionChangedMenu(Item characterItem, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003362")]
		[Cpp2IlInjected.Address(RVA = "0xCA4C80", Offset = "0xCA3680", VA = "0x180CA4C80", Slot = "81")]
		public override void ShowMailboxMenu()
		{
			//Discarded unreachable code: IL_001d
			MailboxMenu.MailboxMenuParam param = new MailboxMenu.MailboxMenuParam();
			MenuStack popupStack = _popupStack;
			AsyncMenu mailboxMenu = _MailboxMenu;
			popupStack.Push(mailboxMenu, param);
		}

		[Cpp2IlInjected.Token(Token = "0x6003365")]
		[Cpp2IlInjected.Address(RVA = "0xCA5970", Offset = "0xCA4370", VA = "0x180CA5970", Slot = "26")]
		public override void StartAddToBackpackAnimationBlocker()
		{
			AddToBackpackAnimationBlocked = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003366")]
		[Cpp2IlInjected.Address(RVA = "0xCA7610", Offset = "0xCA6010", VA = "0x180CA7610", Slot = "27")]
		public override void StopAddToBackpackAnimationBlocker()
		{
			AddToBackpackAnimationBlocked = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003367")]
		[Cpp2IlInjected.Address(RVA = "0xCA5980", Offset = "0xCA4380", VA = "0x180CA5980", Slot = "33")]
		public override void StartBlockShortCuts()
		{
			int blockShortcuts = _blockShortcuts;
			blockShortcuts++;
			int num = (_blockShortcuts = Mathf.Max(0, blockShortcuts));
		}

		[Cpp2IlInjected.Token(Token = "0x6003368")]
		[Cpp2IlInjected.Address(RVA = "0xCA7620", Offset = "0xCA6020", VA = "0x180CA7620", Slot = "34")]
		public override void StopBlockShortcuts()
		{
			int blockShortcuts = _blockShortcuts;
			int num = (_blockShortcuts = Mathf.Max(0, blockShortcuts));
		}

		[Cpp2IlInjected.Token(Token = "0x6003369")]
		[Cpp2IlInjected.Address(RVA = "0xCA11C0", Offset = "0xC9FBC0", VA = "0x180CA11C0", Slot = "75")]
		public override Task<List<int>> OpenBackpackFullMenu(IEnumerable<ItemInstance> itemsToAdd, [System.Runtime.InteropServices.Optional] IEnumerable<int> unavailablePositions)
		{
			//IL_007e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			TaskCompletionSource<List<int>> tcs = (TaskCompletionSource<List<int>>)(object)new TaskCompletionSource<TResult>();
			InventoryFullMenuParam inventoryFullMenuParam = new InventoryFullMenuParam();
			inventoryFullMenuParam.ItemList = itemsToAdd;
			inventoryFullMenuParam.UnavailablePositions = unavailablePositions;
			Action<List<int>> action = (inventoryFullMenuParam.OnDropAction = (Action<List<int>>)(object)(Action<T>)delegate(List<int> slotIds)
			{
				//Discarded unreachable code: IL_000e
				bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)slotIds);
			});
			MenuStack menuStack = _menuStack;
			RedirectionManager redirection = Redirection;
			int num = 0;
			IMenu top = menuStack.Top;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			CancellationToken ct = default(CancellationToken);
			Task task = redirection.RedirectTask(ct, RedirectionType.MenuInventoryFull, inventoryFullMenuParam, (PlayerTaskCollider)num3, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0);
			task.FireAndForgetTask();
			int taskId = task.m_taskId;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600336A")]
		[Cpp2IlInjected.Address(RVA = "0xC9E2E0", Offset = "0xC9CCE0", VA = "0x180C9E2E0")]
		public bool IsCursorSupported()
		{
			//Discarded unreachable code: IL_0004
			int num = 0;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600336B")]
		[Cpp2IlInjected.Address(RVA = "0xC9CF10", Offset = "0xC9B910", VA = "0x180C9CF10")]
		public ControlType GetCurrentController(bool useKeyboardAsController = false)
		{
			//Discarded unreachable code: IL_01a0, IL_01a6
			int num13 = default(int);
			uint num15 = default(uint);
			Guid empty = default(Guid);
			string text = default(string);
			uint num17 = default(uint);
			uint num18 = default(uint);
			uint num19 = default(uint);
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				if (DebugSettings.Settings.overrideGamepadControlType_ == (ControlType)num4)
				{
					int num6 = 0;
					if ((DebugSettings.Settings.forceNoGamepad_ ? 1 : 0) == num4)
					{
						int num7 = 0;
						ControllerType lastControllerType = InputDetectionHelper.GetLastControllerType();
						if ((lastControllerType == ControllerType.Keyboard || lastControllerType == ControllerType.Mouse) && !useKeyboardAsController)
						{
							goto IL_0194;
						}
					}
				}
				int num8 = 0;
				Rewired.Player player;
				if ((DebugSettings.Settings.forceNoGamepad_ ? 1 : 0) == num4)
				{
					int num9 = 0;
					if (DebugSettings.Settings.overrideGamepadControlType_ == (ControlType)num4)
					{
						int num10 = 0;
						ReInput.PlayerHelper players = ReInput.players;
						int playerId = 0;
						player = players.GetPlayer(playerId);
						if (player.controllers.get_Joysticks() == null)
						{
							goto IL_0194;
						}
						int num11 = 0;
						if (!PlatformUtils.IsSteamDeck())
						{
							int num12 = 0;
							RuntimePlatform platform = Application.platform;
							if (platform > RuntimePlatform.XBOX360)
							{
								if (num12 <= 1)
								{
									goto IL_00ca;
								}
								if (platform == RuntimePlatform.XboxOne)
								{
									goto IL_018a;
								}
								if (platform > (RuntimePlatform)6)
								{
									goto IL_00d1;
								}
							}
							if (platform != RuntimePlatform.PS3)
							{
							}
							goto IL_00ca;
						}
					}
					goto IL_018a;
				}
				goto IL_0194;
				IL_014f:
				num13++;
				int num14 = 0;
				if (num4 != 0 && num14 < (int)num15)
				{
					num14 += num14;
					num14++;
				}
				if ((object)empty != null)
				{
					continue;
				}
				num4 += num4;
				num14 += 312;
				while (num13 == 0)
				{
				}
				goto IL_018a;
				IL_0124:
				text += text;
				num4 += 312;
				goto IL_0133;
				IL_018a:
				int num16 = 0;
				DebugSettings settings = DebugSettings.Settings;
				goto IL_0194;
				IL_0133:
				text += text;
				num4 += 312;
				goto IL_0142;
				IL_0194:
				throw new NullReferenceException();
				IL_00ca:
				if (num17 != 10)
				{
				}
				goto IL_00d1;
				IL_00d1:
				IList<Joystick> joysticks = (IList<Joystick>)player.controllers.get_Joysticks();
				if (num4 < (int)num18)
				{
					num4 += num4;
					if (num4 == (int)num18)
					{
						goto IL_0124;
					}
					num4++;
				}
				if (num4 != 0)
				{
					if (num4 < (int)num19)
					{
						num4 += num4;
						if (num4 == (int)num19)
						{
							goto IL_0133;
						}
						num4++;
					}
					empty = Guid.Empty;
					while (!flag)
					{
					}
					int num20 = 0;
					if (flag2)
					{
						while (!flag2)
						{
						}
						num4++;
						goto IL_0124;
					}
					goto IL_0142;
				}
				goto IL_014f;
				IL_0142:
				num4++;
				if ((object)empty != null)
				{
					break;
				}
				while (num4 == 0)
				{
				}
				goto IL_014f;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600336C")]
		[Cpp2IlInjected.Address(RVA = "0xC9E510", Offset = "0xC9CF10", VA = "0x180C9E510")]
		public bool IsPs5Controller()
		{
			//Discarded unreachable code: IL_0040
			//IL_001c: Expected O, but got I4
			int num = 0;
			string[] joystickNames = Input.GetJoystickNames();
			int num2 = 0;
			ControlType currentController = Instance.GetCurrentController(useKeyboardAsController: true);
			string text = ((Enum)currentController).ToString();
			ControlType controlType = currentController;
			if (joystickNames == null || joystickNames.Length != 0)
			{
			}
			return text.ToLower().Contains("dualsense");
		}

		[Cpp2IlInjected.Token(Token = "0x600336D")]
		[Cpp2IlInjected.Address(RVA = "0xC9D700", Offset = "0xC9C100", VA = "0x180C9D700")]
		public string GetJoystickName()
		{
			//Discarded unreachable code: IL_0031
			//IL_001c: Expected O, but got I4
			int num = 0;
			string[] joystickNames = Input.GetJoystickNames();
			int num2 = 0;
			ControlType currentController = Instance.GetCurrentController(useKeyboardAsController: true);
			string result = ((Enum)currentController).ToString();
			ControlType controlType = currentController;
			if (joystickNames == null || joystickNames.Length != 0)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600336E")]
		[Cpp2IlInjected.Address(RVA = "0xC9E000", Offset = "0xC9CA00", VA = "0x180C9E000")]
		public bool IsBattlePassUnlocked()
		{
			//Discarded unreachable code: IL_004f
			//IL_0035: Expected O, but got I8
			long num = Convert.ToInt64((uint)_battlePassIntro);
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				Client client = default(Client);
				Client client2 = default(Client);
				if (!DebugSettings.Settings.disableAllFtue_ && !((RepeatedField<T>)(object)client.profile.player_.completedFtueEvents_).Contains((T)num))
				{
					return client2.profile.player_.currentFtueEvent_ == num;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600336F")]
		[Cpp2IlInjected.Address(RVA = "0xC9EC50", Offset = "0xC9D650", VA = "0x180C9EC50")]
		private unsafe void OnActionTriggered(InputActionEventData inputActionEventData)
		{
			//Discarded unreachable code: IL_002d
			if ((long)(IntPtr)((InputActionEventData*)inputActionEventData)->GetCurrentInputSources() <= 0L)
			{
				return;
			}
			ControlType currentController = GetCurrentController(useKeyboardAsController: true);
			if (_rewiredControlType != currentController)
			{
				EventHandler onNewInputReceived = this.OnNewInputReceived;
				_rewiredControlType = currentController;
				if (onNewInputReceived == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003370")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void UpdateCursor(bool isHovering)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003371")]
		[Cpp2IlInjected.Address(RVA = "0xCA2EE0", Offset = "0xCA18E0", VA = "0x180CA2EE0")]
		public void SetCursor()
		{
			//Discarded unreachable code: IL_00ab
			//IL_0094: Expected O, but got I4
			int num = 0;
			if (PlatformUtils.IsPCPlayer())
			{
				CanvasScaler component = _menuStack.GetComponent<CanvasScaler>();
				int width = TexMouseCursorHardware.width;
				int refreshRate = Screen.currentResolution.m_RefreshRate;
				int height = TexMouseCursorHardware.height;
				int refreshRate2 = Screen.currentResolution.m_RefreshRate;
				bool flag = default(bool);
				if (flag)
				{
				}
				Texture2D texMouseCursorHardware = TexMouseCursorHardware;
				RenderTexture renderTexture = default(RenderTexture);
				renderTexture.name = "UIRoot::Resize";
				RenderTexture.SetActive(renderTexture);
				Graphics.Blit(texMouseCursorHardware, renderTexture);
				Texture2D texture2D = default(Texture2D);
				texture2D.name = "Scaled Cursor";
				int num2 = 0;
				int destY = 0;
				int destX = 0;
				texture2D.ReadPixels((Rect)num2, destX, destY);
				texture2D.Apply();
				RenderTexture.ReleaseTemporary(renderTexture);
				scaledCursor = texture2D;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003372")]
		[Cpp2IlInjected.Address(RVA = "0xC9D8C0", Offset = "0xC9C2C0", VA = "0x180C9D8C0")]
		public float GetScaleDifference()
		{
			//Discarded unreachable code: IL_0020
			CanvasScaler component = _menuStack.GetComponent<CanvasScaler>();
			int num = 0;
			int width = Screen.width;
			int num2 = 0;
			int height = Screen.height;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003373")]
		[Cpp2IlInjected.Address(RVA = "0xCA2A30", Offset = "0xCA1430", VA = "0x180CA2A30")]
		private Texture2D Resize(Texture2D texture2D, int targetX, int targetY)
		{
			//Discarded unreachable code: IL_005d
			//IL_002e: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			//IL_004f: Expected O, but got I4
			RenderTexture temporary = RenderTexture.GetTemporary(targetX, targetY, 24);
			temporary.name = "UIRoot::Resize";
			RenderTexture.SetActive(temporary);
			Graphics.Blit(texture2D, temporary);
			ulong num = default(ulong);
			ulong num2 = default(ulong);
			Texture2D texture2D2 = new Texture2D(targetX, targetY, TextureFormat.RGBA32, (byte)num != 0, (byte)num2 != 0);
			texture2D2.name = "Scaled Cursor";
			int num3 = 0;
			int destY = 0;
			int destX = 0;
			texture2D2.ReadPixels((Rect)num3, destX, destY);
			texture2D2.Apply();
			RenderTexture.ReleaseTemporary(temporary);
			return texture2D2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003374")]
		[Cpp2IlInjected.Address(RVA = "0xCA82C0", Offset = "0xCA6CC0", VA = "0x180CA82C0")]
		public void UpdateCursorBehaviorForUI()
		{
			int num = 0;
			int num2 = 0;
			if (!PlatformUtils.IsPCPlayer())
			{
				CursorWrapper.LockState = CursorLockMode.Locked;
				return;
			}
			CursorWrapper.LockState = CursorLockMode.None;
			CursorWrapper.Visible = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003375")]
		[Cpp2IlInjected.Address(RVA = "0xCA36B0", Offset = "0xCA20B0", VA = "0x180CA36B0")]
		protected bool ShouldDisplayGameplayCursor()
		{
			//Discarded unreachable code: IL_0053
			//IL_0026: Expected O, but got I4
			if (!SystemRoot.Instance.GetSystem<GameSettingsSystem>().ClickToMove)
			{
				PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
				int num = 0;
				if (system != (UnityEngine.Object)num && (long)system.ControlScheme != 0 && !system.IsPaused)
				{
					IControlScheme _003CControlScheme_003Ek__BackingField = system.ControlScheme;
				}
				int useKeyboardAsController = 0;
				return !IsControllerConnected((byte)useKeyboardAsController != 0);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003376")]
		[Cpp2IlInjected.Address(RVA = "0xCA8200", Offset = "0xCA6C00", VA = "0x180CA8200")]
		public void UpdateCursorBehaviorForGameplay()
		{
			//Discarded unreachable code: IL_004f
			int num = 0;
			if ((long)typeof(DebugSettings).TypeHandle != 7)
			{
				int num2 = 0;
				if (!PlatformUtils.IsPCPlayer())
				{
					return;
				}
			}
			if (!ShouldDisplayGameplayCursor())
			{
				CursorWrapper.LockState = CursorLockMode.Locked;
				int num3 = 0;
				if (DebugSettings.Settings.rdpHack_)
				{
					CursorWrapper.LockState = CursorLockMode.None;
				}
				CursorWrapper.Visible = false;
			}
			else
			{
				CursorWrapper.LockState = CursorLockMode.None;
				CursorWrapper.Visible = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003377")]
		[Cpp2IlInjected.Address(RVA = "0xCA59B0", Offset = "0xCA43B0", VA = "0x180CA59B0", Slot = "28")]
		public override void StartConsummableHighlight()
		{
			//Discarded unreachable code: IL_0025
			ProfileEventDispatcher profileEventDispatcher = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ItemAdded value = OnConsumableItemAddedHandler;
			profileEventDispatcher.OnItemAdded += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6003378")]
		[Cpp2IlInjected.Address(RVA = "0xCA7650", Offset = "0xCA6050", VA = "0x180CA7650", Slot = "29")]
		public override void StopConsummableHighlight()
		{
			//Discarded unreachable code: IL_0025
			ProfileEventDispatcher profileEventDispatcher = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ItemAdded value = OnConsumableItemAddedHandler;
			profileEventDispatcher.OnItemAdded -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6003379")]
		[Cpp2IlInjected.Address(RVA = "0xC9F030", Offset = "0xC9DA30", VA = "0x180C9F030")]
		private void OnConsumableItemAddedHandler(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			//Discarded unreachable code: IL_0043
			//IL_0042: Expected I4, but got I8
			//IL_0042: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			NewItemPopUp.NewItemPopupParam newItemPopupParam = new NewItemPopUp.NewItemPopupParam();
			NewItemPopUp.NewItem item2 = default(NewItemPopUp.NewItem);
			((List<T>)(object)newItemPopupParam.Items).Add((T)item2);
			int num = 0;
			RedirectionManager redirection = Instance.Redirection;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuNewItem, newItemPopupParam, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600337A")]
		[Cpp2IlInjected.Address(RVA = "0xCA4CF0", Offset = "0xCA36F0", VA = "0x180CA4CF0", Slot = "86")]
		public override void ShowNewItemPopup(Item item, int amount)
		{
			//Discarded unreachable code: IL_004a
			//IL_0049: Expected I4, but got I8
			//IL_0049: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			NewItemPopUp.NewItemPopupParam newItemPopupParam = new NewItemPopUp.NewItemPopupParam();
			NewItemPopUp.NewItem item2 = default(NewItemPopUp.NewItem);
			((List<T>)(object)newItemPopupParam.Items).Add((T)item2);
			int num = 0;
			newItemPopupParam.UsePopupStack = true;
			RedirectionManager redirection = Instance.Redirection;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuNewItem, newItemPopupParam, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600337B")]
		[Cpp2IlInjected.Address(RVA = "0xC9E8B0", Offset = "0xC9D2B0", VA = "0x180C9E8B0")]
		private void LowManaEvent()
		{
			//Discarded unreachable code: IL_0011
			WorldUI worldCanvas = _worldCanvas;
			int notEnough = 0;
			worldCanvas.ShowLowManaGizmo((byte)notEnough != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600337C")]
		[Cpp2IlInjected.Address(RVA = "0xC9EA20", Offset = "0xC9D420", VA = "0x180C9EA20")]
		private void NotEnoughManaEvent()
		{
			//Discarded unreachable code: IL_007e
			//IL_0043: Expected F4, but got I4
			//IL_0077: Expected O, but got I4
			Dispatcher.OnNotEnoughMana?.Invoke();
			WorldUI worldCanvas = _worldCanvas;
			int num = 0;
			worldCanvas.ShowLowManaGizmo(notEnough: true);
			if (!string.IsNullOrEmpty(_notEnoughManaLocId))
			{
				string notEnoughManaLocId = _notEnoughManaLocId;
				UiErrorMessage(notEnoughManaLocId, num);
			}
			if (!SystemRoot.Instance.MetaClient.profile.player_.manaHasAlreadyMissed_)
			{
				Client metaClient = SystemRoot.Instance.MetaClient;
				int num2 = 0;
				metaClient.SetManaHasAlreadyMissed((CancellationToken)num2).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600337D")]
		[Cpp2IlInjected.Address(RVA = "0xC9C020", Offset = "0xC9AA20", VA = "0x180C9C020", Slot = "87")]
		public override void CoinGainStore(Transform source, [System.Runtime.InteropServices.Optional] RectTransform lastPos)
		{
			//Discarded unreachable code: IL_0013
			//IL_0012: Expected I4, but got I8
			ulong num = default(ulong);
			_worldCanvas.ShowCurrencyGain(CurrencyGainCurrencyType.SoftCurrency, CurrencyGainAnimationType.StoreAnimation, source, lastPos, (int)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600337E")]
		[Cpp2IlInjected.Address(RVA = "0xC9BFE0", Offset = "0xC9A9E0", VA = "0x180C9BFE0", Slot = "88")]
		public override void CoinGainPickup([System.Runtime.InteropServices.Optional] RectTransform lastPos, int amount = -1)
		{
			//Discarded unreachable code: IL_0015
			//IL_0014: Expected O, but got I4
			WorldUI worldCanvas = _worldCanvas;
			int num = 0;
			worldCanvas.ShowCurrencyGain(CurrencyGainCurrencyType.SoftCurrency, CurrencyGainAnimationType.PickupAnimation, (Transform)num, lastPos, amount);
		}

		[Cpp2IlInjected.Token(Token = "0x600337F")]
		[Cpp2IlInjected.Address(RVA = "0xC9CEC0", Offset = "0xC9B8C0", VA = "0x180C9CEC0", Slot = "89")]
		public override void GemGainStore(Transform source, [System.Runtime.InteropServices.Optional] RectTransform lastPos)
		{
			//Discarded unreachable code: IL_0008
			WorldUI worldCanvas = _worldCanvas;
		}

		[Cpp2IlInjected.Token(Token = "0x6003380")]
		[Cpp2IlInjected.Address(RVA = "0xC9CE80", Offset = "0xC9B880", VA = "0x180C9CE80", Slot = "90")]
		public override void GemGainPickup([System.Runtime.InteropServices.Optional] RectTransform lastPos, int amount = -1)
		{
			//Discarded unreachable code: IL_0017
			//IL_0016: Expected O, but got I4
			WorldUI worldCanvas = _worldCanvas;
			int num = 0;
			worldCanvas.ShowCurrencyGain(CurrencyGainCurrencyType.HardCurrency, CurrencyGainAnimationType.PickupAnimation, (Transform)num, lastPos, amount);
		}

		[Cpp2IlInjected.Token(Token = "0x6003381")]
		[Cpp2IlInjected.Address(RVA = "0xC9DF10", Offset = "0xC9C910", VA = "0x180C9DF10", Slot = "91")]
		public override void InteractionPreview(GameObject gameObject, InteractPreviewData interactionMessage, params object[] args)
		{
			//Discarded unreachable code: IL_0028
			WorldUI worldCanvas;
			InteractPreviewData[] array;
			do
			{
				worldCanvas = _worldCanvas;
				array = new InteractPreviewData[1];
			}
			while ((object)interactionMessage != null && array == null);
			array[0] = interactionMessage;
			worldCanvas.ShowInteractionPreview(gameObject, array, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6003382")]
		[Cpp2IlInjected.Address(RVA = "0xC9DEE0", Offset = "0xC9C8E0", VA = "0x180C9DEE0", Slot = "92")]
		public override void InteractionPreview(GameObject gameObject, InteractPreviewData[] interactionMessages, params object[] args)
		{
			//Discarded unreachable code: IL_000f
			_worldCanvas.ShowInteractionPreview(gameObject, interactionMessages, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6003383")]
		[Cpp2IlInjected.Address(RVA = "0xC9C420", Offset = "0xC9AE20", VA = "0x180C9C420", Slot = "93")]
		public override void DestroyInteractionPreview()
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected O, but got I4
			WorldUI worldCanvas = _worldCanvas;
			int num = 0;
			worldCanvas.DestroyInteractionPreview((GameObject)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003384")]
		[Cpp2IlInjected.Address(RVA = "0xC9B800", Offset = "0xC9A200", VA = "0x180C9B800", Slot = "94")]
		public override void BackpackFull()
		{
			//Discarded unreachable code: IL_001b
			UIErrorMessage uiMessage = _uiMessage;
			int showDuplicates = 0;
			uiMessage.ShowMessage("menu.error_backpack_full_message", 0.7f, (byte)showDuplicates != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003385")]
		[Cpp2IlInjected.Address(RVA = "0xCA1060", Offset = "0xC9FA60", VA = "0x180CA1060")]
		[AsyncStateMachine(typeof(_003COnlineValidationFailure_003Ed__335))]
		private Task OnlineValidationFailure(Action selectionCallback, ClientSession.ValidationResult validationResult, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003386")]
		[Cpp2IlInjected.Address(RVA = "0xCA2930", Offset = "0xCA1330", VA = "0x180CA2930")]
		private void RequestPlayFabReloginCB(Action<LoginResponse> newLoginResponseCB, LoginResponse previousValidLoginResponse)
		{
			//Discarded unreachable code: IL_0022
			Action<LoginResponse> newLoginResponseCB2 = newLoginResponseCB;
			SendOrPostCallback sendOrPostCallback = delegate
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			};
			object obj = ((ICloneable)newLoginResponseCB).Clone();
		}

		[Cpp2IlInjected.Token(Token = "0x6003387")]
		[Cpp2IlInjected.Address(RVA = "0xCA0DD0", Offset = "0xC9F7D0", VA = "0x180CA0DD0")]
		private void OnPlayFabErrorCB(PlayFabError playFabError)
		{
			//Discarded unreachable code: IL_0021
			PlayFabError playFabError2 = playFabError;
			SendOrPostCallback sendOrPostCallback = delegate
			{
				//Discarded unreachable code: IL_0091, IL_00be, IL_00d4, IL_00f1, IL_00ff, IL_010d, IL_0120, IL_012e, IL_013e, IL_0147, IL_0154
				//IL_00a9: Expected O, but got I4
				//IL_00e5: Expected O, but got I4
				do
				{
					PlayFabError playFabError3 = playFabError2;
					PlayFabErrorCode error = playFabError3.Error;
					if (error > PlayFabErrorCode.InvalidPSNAuthCode)
					{
						if ((error <= PlayFabErrorCode.PSNInaccessible || ((long)"PlayFabAPIError" > 1 && (long)"PlayFabAPIError" > 1)) && error != PlayFabErrorCode.InvalidSessionTicket && (long)"PlayFabAPIError" > 1)
						{
							return;
						}
					}
					else
					{
						if ((long)"PlayFabAPIError" <= 51)
						{
						}
						while (error != PlayFabErrorCode.InvalidSteamTicket)
						{
						}
					}
					string text = playFabError3.ToGameLog();
					string text2 = "Reporting PlayFabAPIError => " + text;
				}
				while (SystemRoot.ErrorReporter == null);
				Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
				string playFabId = SystemRoot.Instance.MetaOnlineClient.PlayFabId;
				throw new NullReferenceException();
			};
			((ISupportInitialize)playFabError).BeginInit();
		}

		[Cpp2IlInjected.Token(Token = "0x6003388")]
		[Cpp2IlInjected.Address(RVA = "0xC9CE20", Offset = "0xC9B820", VA = "0x180C9CE20", Slot = "18")]
		public override bool GameReset()
		{
			//Discarded unreachable code: IL_0025
			//IL_0023: Expected I4, but got I8
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			RedirectionManager redirection = Redirection;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.GameReset, (MenuParam)num3, (PlayerTaskCollider)num2, (ItemFilterData)num, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num4 != 0, (byte)num != 0);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003389")]
		[Cpp2IlInjected.Address(RVA = "0xC9CC50", Offset = "0xC9B650", VA = "0x180C9CC50", Slot = "19")]
		public override bool GameForceQuit()
		{
			//Discarded unreachable code: IL_0026
			//IL_0024: Expected I4, but got I8
			//IL_0024: Expected I4, but got I8
			//IL_0024: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			RedirectionManager redirection = Redirection;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.GameForceQuit, (MenuParam)num3, (PlayerTaskCollider)num2, (ItemFilterData)num, (string)num, (Action)num, (byte)num != 0, (byte)num4 != 0, (byte)num != 0, (byte)num5 != 0);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600338A")]
		[Cpp2IlInjected.Address(RVA = "0xC9CCB0", Offset = "0xC9B6B0", VA = "0x180C9CCB0")]
		[AsyncStateMachine(typeof(_003CGameInitializationErrorDetected_003Ed__340))]
		private Task GameInitializationErrorDetected(Action selectionCallback, Client.GameInitializationError profileLoadingError, string debugMessage, Exception e, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600338B")]
		[Cpp2IlInjected.Address(RVA = "0xCA2420", Offset = "0xCA0E20", VA = "0x180CA2420", Slot = "97")]
		[AsyncStateMachine(typeof(_003COpenStallMenu_003Ed__341))]
		public override Task OpenStallMenu(bool IsSell)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600338C")]
		[Cpp2IlInjected.Address(RVA = "0xCA3C30", Offset = "0xCA2630", VA = "0x180CA3C30", Slot = "95")]
		public override void ShowCutsceneSkipper(Action callback)
		{
			//Discarded unreachable code: IL_0018
			CutSceneSkipper.Show(callback);
			CutSceneOnGoingEvent.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600338D")]
		[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0", Slot = "96")]
		public override void HideCutsceneSkipper()
		{
			//Discarded unreachable code: IL_0017
			CutSceneSkipper.Hide();
			CutSceneOverEvent.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600338E")]
		[Cpp2IlInjected.Address(RVA = "0xC9BCE0", Offset = "0xC9A6E0", VA = "0x180C9BCE0")]
		public void ClearHudCraftingNotif()
		{
			//Discarded unreachable code: IL_007e
			//IL_0010: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			HudCraftingNotif hudCraftingNotif = _hudCraftingNotif;
			int num = 0;
			if (!(hudCraftingNotif != (UnityEngine.Object)num))
			{
				return;
			}
			Transform transform = _hudCraftingNotif.transform;
			int index = 0;
			Transform child = transform.GetChild(index);
			int num2 = 0;
			if (child != (UnityEngine.Object)num2 && child.gameObject.name.Contains("Content"))
			{
				int num3 = 0;
				int childCount = child.childCount;
				if (num3 < childCount)
				{
					UnityEngine.Object.Destroy(child.GetChild(num3).gameObject);
					num3++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600338F")]
		[Cpp2IlInjected.Address(RVA = "0xCA8300", Offset = "0xCA6D00", VA = "0x180CA8300")]
		[AsyncStateMachine(typeof(_003CWaitForCinematicToEnd_003Ed__345))]
		private Task WaitForCinematicToEnd()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003390")]
		[Cpp2IlInjected.Address(RVA = "0xC9CC20", Offset = "0xC9B620", VA = "0x180C9CC20", Slot = "31")]
		public override void ForceAllowShortCuts()
		{
			//Discarded unreachable code: IL_000d
			CountedBool.RefState refState = ForceAllowShortcut.AddReference();
		}

		[Cpp2IlInjected.Token(Token = "0x6003391")]
		[Cpp2IlInjected.Address(RVA = "0xCA7780", Offset = "0xCA6180", VA = "0x180CA7780", Slot = "32")]
		public override void StopForceAllowShortcuts()
		{
			//Discarded unreachable code: IL_000d
			CountedBool.RefState refState = ForceAllowShortcut.ReleaseReference();
		}

		[Cpp2IlInjected.Token(Token = "0x6003392")]
		[Cpp2IlInjected.Address(RVA = "0xC9B860", Offset = "0xC9A260", VA = "0x180C9B860", Slot = "103")]
		public override Scope BlockShortcutsAndIgnoreForceAllow()
		{
			if ((bool)ForceAllowShortcut)
			{
				Action action = delegate
				{
					StopForceAllowShortcuts();
					IDesignerHost activeDesigner2 = ((IDesignerEventService)this).ActiveDesigner;
				};
				Action action2 = delegate
				{
					StopBlockShortcuts();
					IDesignerHost activeDesigner = ((IDesignerEventService)this).ActiveDesigner;
				};
			}
			return BlockShortcuts();
		}

		[Cpp2IlInjected.Token(Token = "0x6003393")]
		[Cpp2IlInjected.Address(RVA = "0xC9F160", Offset = "0xC9DB60", VA = "0x180C9F160")]
		public void OnControllerConnected(ControllerStatusChangedEventArgs controller)
		{
			//Discarded unreachable code: IL_0042
			GetRewiredManager().OnControllerConnected(controller);
			GameObject disconnectGamepadMessage = _disconnectGamepadMessage;
			int active = 0;
			disconnectGamepadMessage.SetActive((byte)active != 0);
			if (_popupStack.IsEmpty)
			{
			}
			MenuStack popupStack = _popupStack;
			int num = 0;
			IMenu top = popupStack.Top;
			int num2 = 0;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003394")]
		[Cpp2IlInjected.Address(RVA = "0xC9F280", Offset = "0xC9DC80", VA = "0x180C9F280")]
		private void OnControllerDisconnected(ControllerStatusChangedEventArgs controller)
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			if (InputDetectionHelper.IsConsole())
			{
				GetRewiredManager().OnControllerDisconnected(controller);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003395")]
		[Cpp2IlInjected.Address(RVA = "0xC9D800", Offset = "0xC9C200", VA = "0x180C9D800")]
		private RewiredControllerManager GetRewiredManager()
		{
			//IL_0010: Expected O, but got I4
			RewiredControllerManager rewiredControllerManager = _rewiredControllerManager;
			int num = 0;
			if (rewiredControllerManager == (UnityEngine.Object)num)
			{
				RewiredControllerManager rewiredControllerManager2 = (_rewiredControllerManager = UnityEngine.Object.FindObjectOfType<RewiredControllerManager>());
			}
			return _rewiredControllerManager;
		}

		[Cpp2IlInjected.Token(Token = "0x6003396")]
		[Cpp2IlInjected.Address(RVA = "0xCA8770", Offset = "0xCA7170", VA = "0x180CA8770")]
		public UiRoot()
		{
			//IL_0009: Expected I4, but got I8
			int debug = default(int);
			CountedBool forceAllowShortcut = new CountedBool("ForceAllowShortcut", (byte)debug != 0);
			debug = 0;
			ForceAllowShortcut = forceAllowShortcut;
			postponedFriendshipAdded = (List<AddedFriendshipSummary>)(object)new List<T>();
			base._002Ector();
		}
	}
}
