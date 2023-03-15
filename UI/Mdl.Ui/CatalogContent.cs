using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002D1")]
	public class CatalogContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000CFF")]
		private GridEditMode _gridEditModeSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000D00")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000D03")]
		[SerializeField]
		private GameObject _emptyMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000D04")]
		[SerializeField]
		private LoopVerticalScrollRect _listItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000D05")]
		[SerializeField]
		private ListBase _listSelectedFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000D06")]
		[SerializeField]
		private RectTransform _mcItemContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000D07")]
		[SerializeField]
		private RectTransform _mcCategoriesContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000D08")]
		[SerializeField]
		private RectTransform _mcFilterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000D09")]
		[SerializeField]
		private ButtonTmProIcon _btnFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000D0A")]
		[SerializeField]
		private BaseButton _backBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000D0B")]
		[SerializeField]
		private TextBase _tfSelectedCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000D0C")]
		[SerializeField]
		private List<FilterItemSelector> _filterSelectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000D0D")]
		[SerializeField]
		private FilterItemSelector _mcCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000D0E")]
		[SerializeField]
		private FilterItemSelector _landscapingCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000D0F")]
		[SerializeField]
		private QuestFilterSelector _questSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000D10")]
		[SerializeField]
		private GameObject _mcFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000D11")]
		[SerializeField]
		private GameObject _filterIco;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000D12")]
		[SerializeField]
		private HorizontalLayoutGroup _btnFiltersLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000D13")]
		[SerializeField]
		private TextBase _tfFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000D14")]
		[SerializeField]
		private Button _btnFilterReset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000D15")]
		[SerializeField]
		private Sprite _spriteAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000D16")]
		[SerializeField]
		private Sprite _spriteHouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000D17")]
		[SerializeField]
		private FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000D18")]
		[SerializeField]
		private TextBase _headerLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000D19")]
		[SerializeField]
		private GameObject _filterList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000D1A")]
		[SerializeField]
		private ScrollRect _filterContentList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000D1B")]
		public AK.Wwise.Event _sfxToggleTabEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000D1C")]
		public AK.Wwise.Event _sfxFilterTabEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000D1D")]
		public AK.Wwise.Event _sfxBackEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000D1E")]
		[SerializeField]
		private SetSizeBasedOnChild _filterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000D1F")]
		[SerializeField]
		private SetSizeBasedOnChild _filterContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000D20")]
		[SerializeField]
		private FilterHelper _filterHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000D21")]
		public SlidingPanel slidingPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000D22")]
		public Transform BackgroundCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000D23")]
		public RectTransform CloseButtonHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000D24")]
		public Action<Item, bool> OnDragItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000D25")]
		private IItemData _selectedFurniture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000D26")]
		private IItemData[] _allTrimmings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000D27")]
		private IItemData[] _allFurniture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000D28")]
		private IItemData[] _furnitures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000D29")]
		private ListInventory _inventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000D2A")]
		private List<Filter> _currentFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000D2B")]
		public UnityEvent OnFiltersActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000D2C")]
		public UnityEvent OnFiltersDeactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000D2D")]
		public UnityEvent OnPhaseChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000D2E")]
		private bool _firsTimeOpen = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x4000D2F")]
		private bool _isDataUpToDate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x4000D30")]
		private StoreMenu.CatalogStorePhase _currentState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000D31")]
		private bool _needAutoScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000D32")]
		private InventoryItem _currentItemSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000D33")]
		[SerializeField]
		[StringId(true)]
		private string _deactivatedIndoorOnlyStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000D34")]
		[SerializeField]
		[StringId(true)]
		private string _deactivatedOutdoorOnlyStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000D35")]
		[SerializeField]
		[StringId(true)]
		private string _deactivatedNotPlaceableStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000D36")]
		public Action OnStateChange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000D37")]
		private InventoryItem _selectedInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000D38")]
		private int _selectedItemIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000D39")]
		private FocusNavigationElement _navigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000D3A")]
		private InputAction resetFilterActionPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000D3B")]
		private InputAction resetFilterActionRelease;

		[Cpp2IlInjected.Token(Token = "0x4000D3C")]
		private const int sortFactorLevel = 1;

		[Cpp2IlInjected.Token(Token = "0x4000D3D")]
		private const int sortFactorUnlocked = 100;

		[Cpp2IlInjected.Token(Token = "0x4000D3E")]
		private const int sortFactorOwned = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000D3F")]
		private const int sortFactorFurnitureType = 100000000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000D40")]
		private bool isDraging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4000D41")]
		private int DragTargetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000D42")]
		private AsyncAtlassedIcon DragTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000D43")]
		private Vector2 startPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000D44")]
		private bool _firstTime = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000D45")]
		private ProfileWorld.FilterInfo _missionFilter;

		[Cpp2IlInjected.Token(Token = "0x1700031B")]
		public GridEditMode GridEditModeSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60011B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _gridEditModeSystem;
			}
			[Cpp2IlInjected.Token(Token = "0x60011B3")]
			[Cpp2IlInjected.Address(RVA = "0xA781E0", Offset = "0xA76BE0", VA = "0x180A781E0")]
			set
			{
				//Discarded unreachable code: IL_0023
				_gridEditModeSystem = value;
				GridEditMode gridEditModeSystem = _gridEditModeSystem;
				EventHandler value2 = InventoryChanged;
				gridEditModeSystem.CommandStackChangedEvent += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031C")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x60011B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CCancellationToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60011B6")]
			[Cpp2IlInjected.Address(RVA = "0xA781C0", Offset = "0xA76BC0", VA = "0x180A781C0")]
			[CompilerGenerated]
			internal set
			{
				_003CCancellationToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031D")]
		public ItemFilterData CatalogItemFilters
		{
			[Cpp2IlInjected.Token(Token = "0x60011B7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CCatalogItemFilters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60011B8")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CCatalogItemFilters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031E")]
		public FilterItemSelector CategorySelector
		{
			[Cpp2IlInjected.Token(Token = "0x60011B9")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return _mcCategorySelector;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031F")]
		public bool IsInCategoryMode
		{
			[Cpp2IlInjected.Token(Token = "0x60011BA")]
			[Cpp2IlInjected.Address(RVA = "0xA78160", Offset = "0xA76B60", VA = "0x180A78160")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _mcCategoriesContent.gameObject.activeSelf;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000320")]
		public bool IsInFilterMode
		{
			[Cpp2IlInjected.Token(Token = "0x60011BB")]
			[Cpp2IlInjected.Address(RVA = "0xA78190", Offset = "0xA76B90", VA = "0x180A78190")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _mcFilterContent.gameObject.activeSelf;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000321")]
		public StoreMenu.CatalogStorePhase CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x60011BC")]
			[Cpp2IlInjected.Address(RVA = "0xA78130", Offset = "0xA76B30", VA = "0x180A78130")]
			get
			{
				return _currentState;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000322")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x218"), Cpp2IlInjected.Token(Token = "0x4000D46")]
		public bool ForceRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60011E0")]
			[Cpp2IlInjected.Address(RVA = "0xA78140", Offset = "0xA76B40", VA = "0x180A78140")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60011E1")]
			[Cpp2IlInjected.Address(RVA = "0xA781D0", Offset = "0xA76BD0", VA = "0x180A781D0")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x17000323")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x219"), Cpp2IlInjected.Token(Token = "0x4000D47")]
		public bool IsFilteringLocked
		{
			[Cpp2IlInjected.Token(Token = "0x60011E2")]
			[Cpp2IlInjected.Address(RVA = "0xA78150", Offset = "0xA76B50", VA = "0x180A78150")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60011E3")]
			[Cpp2IlInjected.Address(RVA = "0xA78280", Offset = "0xA76C80", VA = "0x180A78280")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60011B4")]
		[Cpp2IlInjected.Address(RVA = "0xA75450", Offset = "0xA73E50", VA = "0x180A75450")]
		private void RegisterEditModeListener()
		{
			//Discarded unreachable code: IL_001c
			GridEditMode gridEditModeSystem = _gridEditModeSystem;
			EventHandler value = InventoryChanged;
			gridEditModeSystem.CommandStackChangedEvent += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60011BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D360", VA = "0x180A6E960")]
		private unsafe void Awake()
		{
			//Discarded unreachable code: IL_03c0
			//IL_0019: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_02d4: Expected O, but got I4
			//IL_030c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num4 = default(int);
			InputActionBool inputActionBool = new InputActionBool("[Back]", trigger, (InputProvider)num4);
			num4 = 0;
			resetFilterActionPress = inputActionBool;
			InputTriggerReleased trigger2 = new InputTriggerReleased();
			int num5 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("[Back]", trigger2, (InputProvider)num5);
			num5 = 0;
			resetFilterActionRelease = inputActionBool2;
			InputAction inputAction = resetFilterActionPress;
			EventHandler value = OnResetPressHandler;
			inputAction.OnTriggered += value;
			InputAction inputAction2 = resetFilterActionRelease;
			EventHandler value2 = OnResetReleaseHandler;
			inputAction2.OnTriggered += value2;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ListInventory catalog = SystemRoot.Instance.MetaClient.profile.Catalog;
			IItemData[] array = (_allFurniture = _003CInstance_003Ek__BackingField.GetOwnedFurnitures<IItemData>(catalog).ToArray<IItemData>());
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			ListInventory trimming = SystemRoot.Instance.MetaClient.profile.Trimming;
			TrimmingItemData[] array2 = (TrimmingItemData[])(_allTrimmings = ItemDatabaseExtensions.GetOwnedTrimmings(_003CInstance_003Ek__BackingField2, trimming).ToArray<TrimmingItemData>());
			SlidingPanel slidingPanel = this.slidingPanel;
			SlidingPanel.SlidingPanelEvent value3 = OnInventoryOpen;
			slidingPanel.OnActivateOpenContent += value3;
			SlidingPanel slidingPanel2 = this.slidingPanel;
			SlidingPanel.SlidingPanelEvent value4 = SlidingPanel_OnActivateOpenContent;
			slidingPanel2.OnActivateOpenContent += value4;
			SlidingPanel slidingPanel3 = this.slidingPanel;
			SlidingPanel.SlidingPanelEvent value5 = SlidingPanel_OnActivateCloseContent;
			slidingPanel3.OnActivateCloseContent += value5;
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			EventHandler value6 = CurrentMovementRestrictionChangedEvent;
			system.CurrentMovementRestrictionChangedEvent += value6;
			Button.ButtonClickedEvent onClick = _backBtn.ButtonComponent.m_OnClick;
			UnityAction call = OnHandleBack;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnFilters.ButtonComponent.m_OnClick;
			UnityAction call2 = OnFilterClickHandler;
			onClick2.AddListener(call2);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			Scrollbar.ScrollEvent onValueChanged = ((LoopScrollRect)_listItems).m_VerticalScrollbar.m_OnValueChanged;
			UnityAction<float> unityAction3 = (UnityAction<float>)(object)new UnityAction<T0>(OnVerticalScrollbarValuedChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction3);
			FilterItemSelector mcCategorySelector = _mcCategorySelector;
			FilterSelector.FilterSelectedByUser value7 = UpdateFilters;
			mcCategorySelector.OnFilterSelectedByUser += value7;
			FilterItemSelector landscapingCategorySelector = _landscapingCategorySelector;
			FilterSelector.FilterSelectedByUser value8 = UpdateFilters;
			landscapingCategorySelector.OnFilterSelectedByUser += value8;
			ListBase.ListEvents onItemData2 = _listSelectedFilters.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnSelectedFilterItemData);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction4);
			QuestFilterSelector questSelector = _questSelector;
			Action<ProfileWorld.FilterInfo> _003COnQuestSelected_003Ek__BackingField = questSelector.OnQuestSelected;
			Action<ProfileWorld.FilterInfo> b = (Action<ProfileWorld.FilterInfo>)(object)new Action<T>(OnQuestFilterSelected);
			Delegate @delegate = Delegate.Combine(_003COnQuestSelected_003Ek__BackingField, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				questSelector.OnQuestSelected = (Action<ProfileWorld.FilterInfo>)num3;
				FocusNavigation focusNavigation = _focusNavigation;
				FocusNavigation.FocusChanged value9 = FocusChange;
				focusNavigation.OnFocusChanged += value9;
				ButtonTmPro component = _btnFilterReset.GetComponent<ButtonTmPro>();
				int num6 = 0;
				if (!(component != (UnityEngine.Object)num6))
				{
					goto IL_0376;
				}
				BaseButton.OnBaseButtonPress b2 = new BaseButton.OnBaseButtonPress(this, (IntPtr)__ldftn(CatalogContent.OnResetPressHandler));
				BaseButton.OnBaseButtonPress onPress = ((BaseButton)component).OnPress;
				Delegate delegate2 = Delegate.Combine(onPress, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onPress)
					{
					}
					BaseButton.OnBaseButtonRelease b3 = new BaseButton.OnBaseButtonRelease(this, (IntPtr)__ldftn(CatalogContent.OnResetReleaseHandler));
					BaseButton.OnBaseButtonRelease onRelease = ((BaseButton)component).OnRelease;
					Delegate delegate3 = Delegate.Combine(onRelease, b3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						while ((object)delegate3 != onRelease)
						{
						}
						goto IL_0376;
					}
				}
			}
			throw new InvalidCastException();
			IL_0376:
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (flag)
			{
			}
			if (!system.ShouldCatalogShowTrimmingItems)
			{
				GridScript initialSelectedGridObjectGridScript = ((GridObjectGizmoSystem)system)._initialSelectedGridObjectGridScript;
			}
			bool active = Enumerable.Any<ProfileWorld.FilterInfo>(SystemRoot.Instance.Client.Profile.world_.GetFiltersCatalogInfo());
			GameObject gameObject = default(GameObject);
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x60011BE")]
		[Cpp2IlInjected.Address(RVA = "0xA701E0", Offset = "0xA6EBE0", VA = "0x180A701E0")]
		private void FocusChange(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_0092, IL_0098, IL_009e, IL_00a4, IL_00aa, IL_00b0, IL_00b6, IL_00c2
			GameObject gameObject = default(GameObject);
			FilterItemSelector filterItemSelector = default(FilterItemSelector);
			int num5 = default(int);
			while (true)
			{
				int num = 0;
				if ((IntPtr)_focusNavigation._focusedElement == (IntPtr)num)
				{
					return;
				}
				IEnumerator enumerator = _mcCategoriesContent.GetComponent<ScrollRect>().m_Content.GetEnumerator();
				if (enumerator != null)
				{
					if (enumerator == null)
					{
					}
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					ISupportsFocusNavigation focusedElement = _focusNavigation._focusedElement;
					int num3 = 0;
					int num4 = 0;
					Transform parent = gameObject.transform.parent;
					RectTransform filtersAnchor = filterItemSelector.filtersAnchor;
					if (!(parent == filtersAnchor))
					{
						continue;
					}
					ISupportsFocusNavigation focusedElement2 = _focusNavigation._focusedElement;
					if (focusedElement2 == null)
					{
					}
					num5 = 0;
					_navigationElement = (FocusNavigationElement)focusedElement2;
				}
				if (num5 == 0)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011BF")]
		[Cpp2IlInjected.Address(RVA = "0xA770F0", Offset = "0xA75AF0", VA = "0x180A770F0")]
		public void Toggle()
		{
			//Discarded unreachable code: IL_0050
			AK.Wwise.Event sfxToggleTabEvent = _sfxToggleTabEvent;
			GameObject gameObject = default(GameObject);
			if (sfxToggleTabEvent != null)
			{
				OpenCloseSlidingPanel panelButtons = slidingPanel.PanelButtons;
				if ((object)panelButtons != null)
				{
					Button toggleButton = panelButtons.toggleButton;
					if ((object)toggleButton != null && (object)toggleButton.gameObject != null)
					{
						goto IL_0036;
					}
				}
				gameObject = base.gameObject;
				goto IL_0036;
			}
			goto IL_003f;
			IL_003f:
			slidingPanel.GetComponent<OpenCloseSlidingPanel>().TogglePanel();
			return;
			IL_0036:
			uint num = sfxToggleTabEvent.Post(gameObject);
			goto IL_003f;
		}

		[Cpp2IlInjected.Token(Token = "0x60011C0")]
		[Cpp2IlInjected.Address(RVA = "0xA76C50", Offset = "0xA75650", VA = "0x180A76C50")]
		private void SlidingPanel_OnActivateOpenContent()
		{
			//Discarded unreachable code: IL_0011
			((GridObjectGizmoSystem)SystemRoot.Instance.GetSystem<GridEditMode>()).AllowNonTouchControls = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60011C1")]
		[Cpp2IlInjected.Address(RVA = "0xA76B80", Offset = "0xA75580", VA = "0x180A76B80")]
		private void SlidingPanel_OnActivateCloseContent()
		{
			//Discarded unreachable code: IL_0011
			((GridObjectGizmoSystem)SystemRoot.Instance.GetSystem<GridEditMode>()).AllowNonTouchControls = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60011C2")]
		[Cpp2IlInjected.Address(RVA = "0xA70F30", Offset = "0xA6F930", VA = "0x180A70F30")]
		private unsafe void OnDestroy()
		{
			//Discarded unreachable code: IL_02d1
			//IL_0069: Expected O, but got I4
			//IL_0228: Expected O, but got I4
			SlidingPanel slidingPanel = this.slidingPanel;
			SlidingPanel.SlidingPanelEvent value = SlidingPanel_OnActivateOpenContent;
			slidingPanel.OnActivateOpenContent -= value;
			SlidingPanel slidingPanel2 = this.slidingPanel;
			SlidingPanel.SlidingPanelEvent value2 = SlidingPanel_OnActivateCloseContent;
			slidingPanel2.OnActivateCloseContent -= value2;
			SlidingPanel slidingPanel3 = this.slidingPanel;
			SlidingPanel.SlidingPanelEvent value3 = OnInventoryOpen;
			slidingPanel3.OnActivateOpenContent -= value3;
			GridEditMode gridEditModeSystem = _gridEditModeSystem;
			int num = 0;
			if (gridEditModeSystem != (UnityEngine.Object)num)
			{
				GridEditMode gridEditModeSystem2 = _gridEditModeSystem;
				EventHandler value4 = InventoryChanged;
				gridEditModeSystem2.CommandStackChangedEvent -= value4;
			}
			Button.ButtonClickedEvent onClick = _backBtn.ButtonComponent.m_OnClick;
			UnityAction call = OnHandleBack;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnFilters.ButtonComponent.m_OnClick;
			UnityAction call2 = OnFilterClickHandler;
			onClick2.RemoveListener(call2);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
			Scrollbar.ScrollEvent onValueChanged = ((LoopScrollRect)_listItems).m_VerticalScrollbar.m_OnValueChanged;
			UnityAction<float> unityAction3 = (UnityAction<float>)(object)new UnityAction<T0>(OnVerticalScrollbarValuedChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction3);
			FilterItemSelector mcCategorySelector = _mcCategorySelector;
			FilterSelector.FilterSelectedByUser value5 = UpdateFilters;
			mcCategorySelector.OnFilterSelectedByUser -= value5;
			FilterItemSelector landscapingCategorySelector = _landscapingCategorySelector;
			FilterSelector.FilterSelectedByUser value6 = UpdateFilters;
			landscapingCategorySelector.OnFilterSelectedByUser -= value6;
			ListBase.ListEvents onItemData2 = _listSelectedFilters.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnSelectedFilterItemData);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction4);
			QuestFilterSelector questSelector = _questSelector;
			Action<ProfileWorld.FilterInfo> _003COnQuestSelected_003Ek__BackingField = questSelector.OnQuestSelected;
			Action<ProfileWorld.FilterInfo> value7 = (Action<ProfileWorld.FilterInfo>)(object)new Action<T>(OnQuestFilterSelected);
			Delegate @delegate = Delegate.Remove(_003COnQuestSelected_003Ek__BackingField, value7);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				questSelector.OnQuestSelected = (Action<ProfileWorld.FilterInfo>)@delegate;
				FocusNavigation focusNavigation = _focusNavigation;
				FocusNavigation.FocusChanged value8 = FocusChange;
				focusNavigation.OnFocusChanged -= value8;
				ButtonTmPro component = _btnFilterReset.GetComponent<ButtonTmPro>();
				int num2 = 0;
				if (!(component != (UnityEngine.Object)num2))
				{
					goto IL_0292;
				}
				BaseButton.OnBaseButtonPress value9 = new BaseButton.OnBaseButtonPress(this, (IntPtr)__ldftn(CatalogContent.OnResetPressHandler));
				BaseButton.OnBaseButtonPress onPress = ((BaseButton)component).OnPress;
				Delegate delegate2 = Delegate.Remove(onPress, value9);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onPress)
					{
					}
					BaseButton.OnBaseButtonRelease value10 = new BaseButton.OnBaseButtonRelease(this, (IntPtr)__ldftn(CatalogContent.OnResetReleaseHandler));
					BaseButton.OnBaseButtonRelease onRelease = ((BaseButton)component).OnRelease;
					Delegate delegate3 = Delegate.Remove(onRelease, value10);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						while ((object)delegate3 != onRelease)
						{
						}
						goto IL_0292;
					}
				}
			}
			throw new InvalidCastException();
			IL_0292:
			InputAction inputAction = resetFilterActionPress;
			EventHandler value11 = OnResetPressHandler;
			inputAction.OnTriggered -= value11;
			InputAction inputAction2 = resetFilterActionRelease;
			EventHandler value12 = OnResetReleaseHandler;
			inputAction2.OnTriggered -= value12;
		}

		[Cpp2IlInjected.Token(Token = "0x60011C3")]
		[Cpp2IlInjected.Address(RVA = "0xA77690", Offset = "0xA76090", VA = "0x180A77690")]
		private void UpdateContext()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011C4")]
		[Cpp2IlInjected.Address(RVA = "0xA770E0", Offset = "0xA75AE0", VA = "0x180A770E0")]
		private void Start()
		{
			UpdateContext();
		}

		[Cpp2IlInjected.Token(Token = "0x60011C5")]
		[Cpp2IlInjected.Address(RVA = "0xA70B00", Offset = "0xA6F500", VA = "0x180A70B00")]
		private void InventoryChanged(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_00bb
			GridEditMode gridEditModeSystem = _gridEditModeSystem;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			if (gridEditModeSystem.isActiveAndEnabled)
			{
				GridEditMode gridEditModeSystem2 = _gridEditModeSystem;
			}
			ListInventory catalog = SystemRoot.Instance.MetaClient.profile.Catalog;
			IItemData[] array = (_allFurniture = _003CInstance_003Ek__BackingField.GetOwnedFurnitures<IItemData>(catalog).ToArray<IItemData>());
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			ListInventory trimming = SystemRoot.Instance.MetaClient.profile.Trimming;
			TrimmingItemData[] array2 = (TrimmingItemData[])(_allTrimmings = ItemDatabaseExtensions.GetOwnedTrimmings(_003CInstance_003Ek__BackingField2, trimming).ToArray<TrimmingItemData>());
			ProfileWorld.FilterInfo missionFilter = _missionFilter;
			if (missionFilter != null || CatalogItemFilters != null)
			{
				ItemFilterData itemFilterData = missionFilter.ItemFilterData;
				SetDefaultFilters(itemFilterData);
			}
			if (!slidingPanel.isOpened)
			{
				ForceRefresh = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011C6")]
		[Cpp2IlInjected.Address(RVA = "0xA71970", Offset = "0xA70370", VA = "0x180A71970")]
		private void OnInventoryOpen()
		{
			//Discarded unreachable code: IL_0106
			//IL_0026: Expected I4, but got O
			//IL_004d: Expected I4, but got I8
			//IL_008c: Expected O, but got I8
			//IL_0105: Expected O, but got I8
			ItemFilterData itemFilterData = CatalogItemFilters;
			if (itemFilterData != null)
			{
				SetDefaultFilters(itemFilterData);
			}
			if (itemFilterData == null && (IntPtr)(_firsTimeOpen ? 1 : 0) != (IntPtr)itemFilterData)
			{
				_firsTimeOpen = (byte)(int)itemFilterData != 0;
				if ((IntPtr)(IsFilteringLocked ? 1 : 0) == (IntPtr)itemFilterData)
				{
					if (!_backBtn._isActive)
					{
						goto IL_0083;
					}
					RefreshContent(StoreMenu.CatalogStorePhase.Category);
				}
				_currentState = StoreMenu.CatalogStorePhase.Selection;
			}
			if (ForceRefresh)
			{
				ForceRefresh = false;
				LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
				UpdateContext();
				StoreMenu.CatalogStorePhase currentState = _currentState;
				RefreshContent(currentState);
			}
			_firsTimeOpen = false;
			goto IL_0083;
			IL_0083:
			CatalogItemFilters = (ItemFilterData)0;
			IEnumerable<ProfileWorld.FilterInfo> filtersCatalogInfo = (IEnumerable<ProfileWorld.FilterInfo>)SystemRoot.Instance.Client.Profile.world_.GetFiltersCatalogInfo();
			GameObject gameObject = _questSelector.gameObject;
			bool active = Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)filtersCatalogInfo);
			gameObject.SetActive(active);
			_questSelector.Init((IEnumerable<>)filtersCatalogInfo);
			int _003C_003E1__state = default(int);
			_003CRefreshScroll_003Ed__89 _003CRefreshScroll_003Ed__ = new _003CRefreshScroll_003Ed__89(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshScroll_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CRefreshScroll_003Ed__);
			if (IsFilteringLocked)
			{
				RefreshContent(StoreMenu.CatalogStorePhase.Selection);
				CatalogItemFilters = (ItemFilterData)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011C7")]
		[Cpp2IlInjected.Address(RVA = "0xA75040", Offset = "0xA73A40", VA = "0x180A75040")]
		[IteratorStateMachine(typeof(_003CRefreshScroll_003Ed__89))]
		private IEnumerator RefreshScroll()
		{
			int _003C_003E1__state = default(int);
			_003CRefreshScroll_003Ed__89 _003CRefreshScroll_003Ed__ = new _003CRefreshScroll_003Ed__89(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshScroll_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011C8")]
		[Cpp2IlInjected.Address(RVA = "0xA70EF0", Offset = "0xA6F8F0", VA = "0x180A70EF0")]
		public void OnCategoryClickHandler()
		{
			//Discarded unreachable code: IL_0017
			if (_backBtn._isActive)
			{
				RefreshContent(StoreMenu.CatalogStorePhase.Category);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011C9")]
		[Cpp2IlInjected.Address(RVA = "0xA71800", Offset = "0xA70200", VA = "0x180A71800")]
		public void OnFilterClickHandler()
		{
			//Discarded unreachable code: IL_000f, IL_0010
			ButtonTmProIcon btnFilters = _btnFilters;
			RefreshContent(StoreMenu.CatalogStorePhase.Filter);
		}

		[Cpp2IlInjected.Token(Token = "0x60011CA")]
		[Cpp2IlInjected.Address(RVA = "0xA73970", Offset = "0xA72370", VA = "0x180A73970")]
		[IteratorStateMachine(typeof(_003CRefreshLayout_003Ed__92))]
		private IEnumerator RefreshLayout()
		{
			int _003C_003E1__state = default(int);
			_003CRefreshLayout_003Ed__92 _003CRefreshLayout_003Ed__ = new _003CRefreshLayout_003Ed__92(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshLayout_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011CB")]
		[Cpp2IlInjected.Address(RVA = "0xA71C70", Offset = "0xA70670", VA = "0x180A71C70")]
		private void OnItemDataHandler(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011CC")]
		[Cpp2IlInjected.Address(RVA = "0xA70590", Offset = "0xA6EF90", VA = "0x180A70590")]
		private string GetDeactivationMessageForItem(InventoryItem inventoryItem)
		{
			//Discarded unreachable code: IL_003b
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = inventoryItem.ItemData;
			IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
			bool flag = default(bool);
			if (gridPlaceableItemData != null && gridPlaceableItemData != null && flag)
			{
				bool flag2 = default(bool);
				if (!flag2)
				{
					flag = flag2;
					bool flag3 = default(bool);
					if (!flag3)
					{
						return _deactivatedOutdoorOnlyStringID;
					}
				}
				return _deactivatedIndoorOnlyStringID;
			}
			return _deactivatedNotPlaceableStringID;
		}

		[Cpp2IlInjected.Token(Token = "0x60011CD")]
		[Cpp2IlInjected.Address(RVA = "0xA725D0", Offset = "0xA70FD0", VA = "0x180A725D0")]
		private void OnItemTapHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_0131
			//IL_005d: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			int num = 0;
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			InventoryItem component = args.DisplayObject.GetComponent<InventoryItem>();
			SlidingPanel slidingPanel = this.slidingPanel;
			if ((slidingPanel.IsClosing ? 1 : 0) != num || slidingPanel.IsClosed || (this.slidingPanel.isOpened ? 1 : 0) == num)
			{
				return;
			}
			GridObjectScript selectedGridObject = ((GridObjectGizmoSystem)system)._selectedGridObject;
			int num2 = 0;
			if (selectedGridObject != (UnityEngine.Object)num2)
			{
				return;
			}
			IItemData itemData = component.ItemData;
			bool flag = default(bool);
			if (!flag)
			{
				int num3 = 0;
				if (component == (UnityEngine.Object)num3 || !_gridEditModeSystem.CanStartEditMode || OnDragItem == null)
				{
					goto IL_00bd;
				}
				IItemData itemData2 = component.ItemData;
			}
			GridEditMode system2 = SystemRoot.Instance.GetSystem<GridEditMode>();
			IItemData itemData3 = component.ItemData;
			TrimmingItemType trimmingItemType = default(TrimmingItemType);
			if (trimmingItemType != 0)
			{
			}
			RefreshSelectedItem(component);
			goto IL_00bd;
			IL_00bd:
			bool flag2 = default(bool);
			if (_selectedItemIndex == -1)
			{
				flag2 = args.ItemIndex != -1;
			}
			_selectedInventoryItem = component;
			int num4 = (_selectedItemIndex = args.ItemIndex);
			if (flag2 && this.slidingPanel.IsOpenOrOpening)
			{
				int num5 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					FocusNavigation focusNavigation = _focusNavigation;
					FocusNavigationElement component2 = component.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011CE")]
		[Cpp2IlInjected.Address(RVA = "0xA72CB0", Offset = "0xA716B0", VA = "0x180A72CB0")]
		private void OnTrimmingSelect(TrimmingItem trimmingItem, InventoryItem item)
		{
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			IItemData itemData = item.ItemData;
			TrimmingItemType trimmingItemType = default(TrimmingItemType);
			if (trimmingItemType != 0)
			{
				RefreshSelectedItem(item);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011CF")]
		[Cpp2IlInjected.Address(RVA = "0xA724F0", Offset = "0xA70EF0", VA = "0x180A724F0")]
		public void OnItemSelect(InventoryItem item)
		{
			//Discarded unreachable code: IL_002b
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(item == (UnityEngine.Object)num) && _gridEditModeSystem.CanStartEditMode && OnDragItem != null)
			{
				IItemData itemData = item.ItemData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011D0")]
		[Cpp2IlInjected.Address(RVA = "0xA72AD0", Offset = "0xA714D0", VA = "0x180A72AD0")]
		private void OnResetPressHandler(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_001d
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.ShowHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D1")]
		[Cpp2IlInjected.Address(RVA = "0xA72AD0", Offset = "0xA714D0", VA = "0x180A72AD0")]
		private void OnResetPressHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_001d
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.ShowHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D2")]
		[Cpp2IlInjected.Address(RVA = "0xA72B40", Offset = "0xA71540", VA = "0x180A72B40")]
		private void OnResetReleaseHandler(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0023
			ResetFilters();
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.RemoveHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D3")]
		[Cpp2IlInjected.Address(RVA = "0xA72B40", Offset = "0xA71540", VA = "0x180A72B40")]
		private void OnResetReleaseHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_0023
			ResetFilters();
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.RemoveHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D4")]
		[Cpp2IlInjected.Address(RVA = "0xA754E0", Offset = "0xA73EE0", VA = "0x180A754E0")]
		private void ResetFilters()
		{
			//Discarded unreachable code: IL_000c
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011D5")]
		[Cpp2IlInjected.Address(RVA = "0xA70EE0", Offset = "0xA6F8E0", VA = "0x180A70EE0")]
		private void OnApplyClickHandler()
		{
			RefreshContent(StoreMenu.CatalogStorePhase.Selection);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D6")]
		[Cpp2IlInjected.Address(RVA = "0xA70EE0", Offset = "0xA6F8E0", VA = "0x180A70EE0")]
		private void UpdateFilters()
		{
			RefreshContent(StoreMenu.CatalogStorePhase.Selection);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D7")]
		[Cpp2IlInjected.Address(RVA = "0xA72AA0", Offset = "0xA714A0", VA = "0x180A72AA0")]
		private void OnQuestFilterSelected(ProfileWorld.FilterInfo filter)
		{
			_missionFilter = filter;
			RefreshContent(StoreMenu.CatalogStorePhase.Quest);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D8")]
		[Cpp2IlInjected.Address(RVA = "0xA72E30", Offset = "0xA71830", VA = "0x180A72E30")]
		private void RefreshContent(StoreMenu.CatalogStorePhase state)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011D9")]
		[Cpp2IlInjected.Address(RVA = "0xA739E0", Offset = "0xA723E0", VA = "0x180A739E0")]
		public void RefreshList()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011DA")]
		[Cpp2IlInjected.Address(RVA = "0xA752A0", Offset = "0xA73CA0", VA = "0x180A752A0")]
		private void RefreshSpecificItem()
		{
			//Discarded unreachable code: IL_00a2
			//IL_001f: Expected O, but got I4
			//IL_00a1: Expected I4, but got I8
			LoopVerticalScrollRect listItems = _listItems;
			int selectedItemIndex = _selectedItemIndex;
			Transform itemByDataIndex = listItems.GetItemByDataIndex(selectedItemIndex);
			int num = 0;
			LoopVerticalScrollRect listItems3 = default(LoopVerticalScrollRect);
			if (!(itemByDataIndex == (UnityEngine.Object)num))
			{
				InventoryItem component = itemByDataIndex.GetComponent<InventoryItem>();
				IItemData itemData = _selectedInventoryItem.ItemData;
				LoopVerticalScrollRect listItems2 = _listItems;
				if (component.ItemData != itemData)
				{
					int selectedItemIndex2 = _selectedItemIndex;
					int num2 = 0;
					listItems2.RefreshAt(selectedItemIndex2);
					listItems3 = _listItems;
					selectedItemIndex2++;
				}
				Transform child = default(Transform);
				int indexOf = listItems3.GetIndexOf(child);
			}
			int selectedItemIndex3 = _selectedItemIndex;
			if ((object)listItems3 != null)
			{
				_listItems.RefreshAt(selectedItemIndex3);
				_selectedItemIndex = -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011DB")]
		[Cpp2IlInjected.Address(RVA = "0xA76750", Offset = "0xA75150", VA = "0x180A76750")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			//IL_001b: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			LoopVerticalScrollRect listItems = default(LoopVerticalScrollRect);
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			GameObject gameObject2 = default(GameObject);
			while (true)
			{
				int num = 0;
				PositionHandler componentInChildren = UiRoot.Instance._worldCanvas.GetComponentInChildren<PositionHandler>();
				int num2 = 0;
				if (!(componentInChildren == (UnityEngine.Object)num2))
				{
					return;
				}
				if (_mcFilterContent.gameObject.activeSelf)
				{
					break;
				}
				if (!_mcCategoriesContent.gameObject.activeSelf)
				{
					if (!_mcItemContent.gameObject.activeSelf || ((LoopScrollRect)_listItems).m_Content.childCount <= 0)
					{
						return;
					}
					if (_selectedItemIndex > 0)
					{
						InventoryItem selectedInventoryItem = _selectedInventoryItem;
						int num3 = 0;
						if (selectedInventoryItem != (UnityEngine.Object)num3)
						{
							FocusNavigationElement component = _selectedInventoryItem.GetComponent<FocusNavigationElement>();
							focusNavigation.SetFocus(component);
							return;
						}
					}
					listItems = _listItems;
					int firstVisibleItemIndex = listItems.GetFirstVisibleItemIndex();
					Transform itemByDataIndex = listItems.GetItemByDataIndex(firstVisibleItemIndex);
				}
				int num4 = 0;
				if (componentInChildren != (UnityEngine.Object)num4)
				{
					bool reverseDirection = listItems.reverseDirection;
					if ((object)componentInChildren == null)
					{
					}
					int num5 = 0;
					if (!flag)
					{
					}
				}
				LoopScrollRect.ScrollRectEvent onValueChanged = ((LoopScrollRect)listItems).m_OnValueChanged;
				if (!gameObject.activeSelf)
				{
					LoopScrollRect.ScrollbarVisibility horizontalScrollbarVisibility = ((LoopScrollRect)listItems).m_HorizontalScrollbarVisibility;
					if (!gameObject2.activeSelf)
					{
						continue;
					}
					LoopScrollRect.ScrollbarVisibility horizontalScrollbarVisibility2 = ((LoopScrollRect)listItems).m_HorizontalScrollbarVisibility;
				}
				LoopScrollRect.ScrollRectEvent onValueChanged2 = ((LoopScrollRect)listItems).m_OnValueChanged;
				break;
			}
			Scrollbar verticalScrollbar = ((LoopScrollRect)listItems).m_VerticalScrollbar;
			int num6 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			IntPtr cachedPtr = ((UnityEngine.Object)verticalScrollbar).m_CachedPtr;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011DC")]
		[Cpp2IlInjected.Address(RVA = "0xA76740", Offset = "0xA75140", VA = "0x180A76740")]
		public void SetFocusElement(FocusNavigationElement element)
		{
			_navigationElement = element;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60011DD")]
		[Cpp2IlInjected.Address(RVA = "0xA70820", Offset = "0xA6F220", VA = "0x180A70820")]
		private int GetPriority(IItemData itemData)
		{
			int num = 0;
			ItemType itemType = default(ItemType);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			if (itemType != ItemType.Furniture || furnitureItemType == FurnitureItemType.Default)
			{
			}
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			IHasUnlockConditions unlockConditions = itemData.GetUnlockConditions();
			uint num2 = default(uint);
			if (unlockConditions == null)
			{
				int maxLevel = profile.player_.GetMaxLevel();
				num2 += 100;
				num2 += (uint)maxLevel;
			}
			bool flag = default(bool);
			if (flag)
			{
				num2 += 100;
			}
			int maxLevel2 = profile.player_.GetMaxLevel();
			uint num3 = default(uint);
			if (num < (int)num3)
			{
				num += num;
				num++;
			}
			num2 += (uint)maxLevel2;
			unlockConditions = (IHasUnlockConditions)(object)((object)unlockConditions + (object)unlockConditions);
			num2 += 312;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011DE")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9A0", Offset = "0xA6E3A0", VA = "0x180A6F9A0")]
		private HashSet<Filter> CurrentFilters()
		{
			//Discarded unreachable code: IL_0082, IL_0088, IL_008e
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__116_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Filter x)
					{
						if ((object)x == null)
						{
							return 0 == 0;
						}
						int num3 = 0;
						return (object)x == null;
					};
				}
				IEnumerable<Filter> enumerable = default(IEnumerable<Filter>);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable);
			}
			if (_003C_003Ec._003C_003E9__116_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Filter x)
				{
					if ((object)x == null)
					{
						return 0 == 0;
					}
					int num2 = 0;
					return (object)x == null;
				};
			}
			IEnumerable<Filter> enumerable2 = default(IEnumerable<Filter>);
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable2);
			if (_003C_003Ec._003C_003E9__116_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Filter x)
				{
					if ((object)x == null)
					{
						return 0 == 0;
					}
					int num = 0;
					return (object)x == null;
				};
			}
			IEnumerable<Filter> enumerable3 = default(IEnumerable<Filter>);
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable3);
			return hashSet;
		}

		[Cpp2IlInjected.Token(Token = "0x60011DF")]
		[Cpp2IlInjected.Address(RVA = "0xA724E0", Offset = "0xA70EE0", VA = "0x180A724E0")]
		private void OnItemPurchasedHandler([System.Runtime.InteropServices.Optional] IItemData itemData, bool refreshNodes = false)
		{
			//IL_000c: Expected O, but got I4
			//IL_000c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			InventoryChanged(num2, (EventArgs)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60011E4")]
		[Cpp2IlInjected.Address(RVA = "0xA76D20", Offset = "0xA75720", VA = "0x180A76D20")]
		private unsafe void StartDrag(AsyncAtlassedIcon image)
		{
			//Discarded unreachable code: IL_00c6
			//IL_0022: Expected F4, but got I4
			//IL_001d: Expected native int or pointer, but got O
			//IL_0036: Expected O, but got I4
			int num = 0;
			isDraging = true;
			Vector2 vector = (startPosition = Vector2.zero);
			((Vector2*)(IntPtr)startPosition)->y = 0f;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				GameObject obj = default(GameObject);
				UnityEngine.Object.Destroy(obj);
				DragTarget = (AsyncAtlassedIcon)num2;
			}
			Transform parent = base.transform;
			AsyncAtlassedIcon asyncAtlassedIcon = (DragTarget = UnityEngine.Object.Instantiate(image, parent));
			string _003CKey_003Ek__BackingField = image.Key;
			Transform transform = default(Transform);
			Transform transform2 = transform.transform;
			Transform transform3 = image.transform;
			Vector3 vector2 = default(Vector3);
			float z = vector2.z;
			Transform transform4 = transform2.transform;
			float z2 = Vector3.zero.z;
			Transform transform5 = transform4.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			RawImage rawImage = default(RawImage);
			int num3 = ((rawImage.raycastTarget = false) ? 1 : 0);
			RectTransform component = rawImage.GetComponent<RectTransform>();
			LoopVerticalScrollRect listItems = _listItems;
			int num4 = ((listItems.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60011E5")]
		[Cpp2IlInjected.Address(RVA = "0xA77AC0", Offset = "0xA764C0", VA = "0x180A77AC0")]
		private unsafe void Update()
		{
			//IL_00ae: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_0101: Expected O, but got I4
			//IL_015c: Expected O, but got I4
			//IL_019b: Expected O, but got I8
			//IL_01a8: Expected F4, but got I4
			//IL_01a3: Expected native int or pointer, but got O
			float deltaTime;
			InputAction[] array;
			InputAction inputAction2;
			while (true)
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[2];
				InputAction inputAction = resetFilterActionPress;
				if (inputAction == null || array != null)
				{
					array[0] = inputAction;
					inputAction2 = resetFilterActionRelease;
					if (inputAction2 == null || array != null)
					{
						break;
					}
				}
			}
			array[1] = inputAction2;
			InputAction.UpdateAll(deltaTime, array);
			int num2 = 0;
			if ((isDraging ? 1 : 0) != num2)
			{
				int num3 = 0;
				float y = startPosition.y;
				Vector2 zero = Vector2.zero;
				int num4 = 0;
				int num5 = 0;
				float num6 = default(float);
				if (!(num6 > 40f))
				{
					bool mouseButton = Input.GetMouseButton(0);
					AsyncAtlassedIcon dragTarget = DragTarget;
					LoopVerticalScrollRect listItems = default(LoopVerticalScrollRect);
					if (!mouseButton)
					{
						isDraging = (byte)num2 != 0;
						UnityEngine.Object.Destroy(dragTarget.gameObject);
						DragTarget = (AsyncAtlassedIcon)num2;
						listItems = _listItems;
						listItems.enabled = true;
					}
					int num7 = 0;
					Transform transform = listItems.transform;
					int num8 = 0;
					Vector2 mousePosition = Input.mousePosition;
					transform.position = (Vector3)num7;
				}
				AsyncAtlassedIcon dragTarget2 = DragTarget;
				isDraging = (byte)num2 != 0;
				UnityEngine.Object.Destroy(dragTarget2.gameObject);
				DragTarget = (AsyncAtlassedIcon)num2;
				_listItems.enabled = true;
				if (OnDragItem != null)
				{
					IItemData selectedFurniture = _selectedFurniture;
				}
			}
			int num9 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				ScrollRect component = _listSelectedFilters.gameObject.GetComponent<ScrollRect>();
				if ((_needAutoScroll ? 1 : 0) != num2)
				{
					RectTransform content = component.m_Content;
					RectTransform viewport = component.m_Viewport;
					RectTransform content2 = component.m_Content;
					RectTransform content3 = component.m_Content;
					RectTransform content4 = component.m_Content;
					component.m_Velocity = (Vector2)3248488448L;
					((Vector2*)(IntPtr)component.m_Velocity)->y = 0f;
					throw new NullReferenceException();
				}
				component.m_Velocity = (Vector2)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011E6")]
		[Cpp2IlInjected.Address(RVA = "0xA70EA0", Offset = "0xA6F8A0", VA = "0x180A70EA0")]
		private bool IsMouseMovedWhenDraged(Vector2 mousePosition)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011E7")]
		[Cpp2IlInjected.Address(RVA = "0xA6FE10", Offset = "0xA6E810", VA = "0x180A6FE10")]
		private void CurrentMovementRestrictionChangedEvent(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0010
			int num = 0;
			int num2 = 0;
			slidingPanel.Close();
		}

		[Cpp2IlInjected.Token(Token = "0x60011E8")]
		[Cpp2IlInjected.Address(RVA = "0xA71840", Offset = "0xA70240", VA = "0x180A71840")]
		public void OnHandleBack()
		{
			//Discarded unreachable code: IL_0032, IL_0037, IL_0038
			if (_currentState == StoreMenu.CatalogStorePhase.Category)
			{
				AK.Wwise.Event sfxBackEvent = _sfxBackEvent;
				if (sfxBackEvent != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = sfxBackEvent.Post(gameObject);
				}
				if (!_backBtn._isActive)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011E9")]
		[Cpp2IlInjected.Address(RVA = "0xA70540", Offset = "0xA6EF40", VA = "0x180A70540")]
		public void ForceUpdateList()
		{
			//Discarded unreachable code: IL_001b
			if (_listItems.gameObject.activeInHierarchy)
			{
				RefreshList();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011EA")]
		[Cpp2IlInjected.Address(RVA = "0xA724E0", Offset = "0xA70EE0", VA = "0x180A724E0")]
		public void RefreshNodes()
		{
			//IL_000c: Expected O, but got I4
			//IL_000c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			InventoryChanged(num2, (EventArgs)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60011EB")]
		[Cpp2IlInjected.Address(RVA = "0xA755E0", Offset = "0xA73FE0", VA = "0x180A755E0")]
		public unsafe void SetDefaultFilters(ItemFilterData itemFilters)
		{
			//Discarded unreachable code: IL_036f, IL_0375, IL_037b, IL_0381, IL_0387, IL_038d, IL_0393, IL_0399, IL_039f, IL_03a5, IL_03ab, IL_03b1, IL_03b7, IL_03bd, IL_03c3, IL_03c9, IL_03cf, IL_03d5
			//IL_01de: Expected O, but got I4
			//IL_020b: Expected O, but got I4
			//IL_0257: Expected O, but got I4
			//IL_02a3: Expected O, but got I4
			//IL_02ef: Expected O, but got I4
			//IL_033d: Expected O, but got I4
			//IL_036e: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ResetFilters();
			int item_ = itemFilters.item_;
			bool flag = default(bool);
			if (!flag)
			{
				if (!Enumerable.Any<int>((IEnumerable<>)(object)itemFilters.itemList_))
				{
					goto IL_0175;
				}
				IItemData[] allFurniture = _allFurniture;
				Func<IItemData, bool> func = (Func<IItemData, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_000e
					RepeatedField<int> itemList_ = itemFilters.itemList_;
					bool result = default(bool);
					return result;
				};
				IItemData[] array = (_allFurniture = Enumerable.Where<IItemData>((IEnumerable<>)(object)allFurniture, (Func<, >)(object)func).ToArray<IItemData>());
			}
			IItemData[] allFurniture2 = _allFurniture;
			Func<IItemData, bool> func2 = (Func<IItemData, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0015
				ItemFilterData itemFilterData3 = itemFilters;
				return (IntPtr)typeof(IItemData).TypeHandle == (IntPtr)itemFilterData3.item_;
			};
			IItemData[] array2 = (_allFurniture = Enumerable.Where<IItemData>((IEnumerable<>)(object)allFurniture2, (Func<, >)(object)func2).ToArray<IItemData>());
			int item_2 = itemFilters.item_;
			FilterItemSelector mcCategorySelector = _mcCategorySelector;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Building)
			{
				List<Filter> extraFilters = mcCategorySelector.extraFilters;
				Func<Filter, bool> _003C_003E9__139_ = _003C_003Ec._003C_003E9__139_5;
				if (_003C_003E9__139_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Filter x) => string.Equals(x.Name, "All"));
				}
				if (!(*(Filter*)Enumerable.FirstOrDefault<Filter>((IEnumerable<>)extraFilters, (Func<, >)(object)_003C_003E9__139_) != *(Filter*)num))
				{
					goto IL_0175;
				}
				((List<T>)(object)_mcCategorySelector.selectedFilters).Clear();
				List<Filter> selectedFilters = _mcCategorySelector.selectedFilters;
			}
			List<Filter> extraFilters2 = mcCategorySelector.extraFilters;
			Func<Filter, bool> _003C_003E9__139_2 = _003C_003Ec._003C_003E9__139_4;
			if (_003C_003E9__139_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Filter x) => string.Equals(x.Name, "House"));
			}
			Filter filter = Enumerable.FirstOrDefault<Filter>((IEnumerable<>)extraFilters2, (Func<, >)(object)_003C_003E9__139_2);
			if (*(Filter*)filter != *(Filter*)num)
			{
				((List<T>)(object)_mcCategorySelector.selectedFilters).Clear();
				((List<T>)(object)_mcCategorySelector.selectedFilters).Add((T)filter);
			}
			goto IL_0175;
			IL_0175:
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			RepeatedField<int> tags_ = itemFilters.tags_;
			bool flag2 = default(bool);
			Filter item = default(Filter);
			if (flag2 && !((List<T>)(object)_mcCategorySelector.allFilters).Contains((T)item))
			{
				List<FilterItemSelector> filterSelectors = _filterSelectors;
				bool flag3 = default(bool);
				if (flag3)
				{
					bool flag4 = default(bool);
					while (!flag4)
					{
					}
				}
			}
			if (_003C_003Ec._003C_003E9__139_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((FilterItemSelector x) => x.filterType == FilterItemSelector.FilterType.Trait);
			}
			int num4 = 0;
			FilterItemSelector filterItemSelector = default(FilterItemSelector);
			if (filterItemSelector != (UnityEngine.Object)num4)
			{
				OptionalField complexity_ = itemFilters.complexity_;
				if (complexity_.useField_)
				{
					Complexity complexity = complexity_.Complexity;
					string text = ((Enum)complexity).ToString();
					Complexity complexity2 = complexity;
					Filter item2 = default(Filter);
					if (((List<T>)(object)filterItemSelector.allFilters).Contains((T)item2))
					{
						((List<T>)(object)filterItemSelector.selectedFilters).Add((T)item2);
					}
				}
				OptionalField mood_ = itemFilters.mood_;
				if (mood_.useField_)
				{
					Mood mood = mood_.Mood;
					string text2 = ((Enum)mood).ToString();
					Mood mood2 = mood;
					Filter item3 = default(Filter);
					if (((List<T>)(object)filterItemSelector.allFilters).Contains((T)item3))
					{
						((List<T>)(object)filterItemSelector.selectedFilters).Add((T)item3);
					}
				}
				OptionalField normality_ = itemFilters.normality_;
				if (normality_.useField_)
				{
					Normality normality = normality_.Normality;
					string text3 = ((Enum)normality).ToString();
					Normality normality2 = normality;
					Filter item4 = default(Filter);
					if (((List<T>)(object)filterItemSelector.allFilters).Contains((T)item4))
					{
						((List<T>)(object)filterItemSelector.selectedFilters).Add((T)item4);
					}
				}
				OptionalField sturdiness_ = itemFilters.sturdiness_;
				if (sturdiness_.useField_)
				{
					Sturdiness sturdiness = sturdiness_.Sturdiness;
					string text4 = ((Enum)sturdiness).ToString();
					Sturdiness sturdiness2 = sturdiness;
					Filter item5 = default(Filter);
					if (((List<T>)(object)filterItemSelector.allFilters).Contains((T)item5))
					{
						((List<T>)(object)filterItemSelector.selectedFilters).Add((T)item5);
					}
				}
			}
			if (_003C_003Ec._003C_003E9__139_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((FilterItemSelector x) => x.filterType == FilterItemSelector.FilterType.Tier);
			}
			int num5 = 0;
			FilterItemSelector filterItemSelector2 = default(FilterItemSelector);
			if (filterItemSelector2 != (UnityEngine.Object)num5)
			{
				List<Filter> allFilters = filterItemSelector2.allFilters;
				bool flag5 = default(bool);
				if (flag5)
				{
					int num6 = 0;
					ItemFilterData itemFilterData = itemFilters;
					ItemFilterData itemFilterData2 = itemFilters;
					((List<T>)(object)filterItemSelector2.selectedFilters).Add((T)num3);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011EC")]
		[Cpp2IlInjected.Address(RVA = "0xA72BC0", Offset = "0xA715C0", VA = "0x180A72BC0")]
		private void OnSelectedFilterItemData(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011ED")]
		[Cpp2IlInjected.Address(RVA = "0xA76B40", Offset = "0xA75540", VA = "0x180A76B40")]
		private void SetSizeForFilterContent()
		{
			//Discarded unreachable code: IL_0017
			_filterContainer.DoAdjustment();
			_filterContent.DoAdjustment();
		}

		[Cpp2IlInjected.Token(Token = "0x60011EE")]
		[Cpp2IlInjected.Address(RVA = "0xA6FEE0", Offset = "0xA6E8E0", VA = "0x180A6FEE0")]
		private void FindSelectedFloor()
		{
			//Discarded unreachable code: IL_00b3
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			Item trimmingItem = gameObject.GetComponent<PlayerHouseEnvironment>().ActiveRoom.GetComponentInChildren<FlooringSetter>().TrimmingItem;
			int num = 0;
			int itemID = trimmingItem.ItemID;
			int childCount = ((LoopScrollRect)_listItems).m_Content.childCount;
			if (num < childCount)
			{
				InventoryItem component = ((LoopScrollRect)_listItems).m_Content.GetChild(num).GetComponent<InventoryItem>();
				IItemData itemData = component.ItemData;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if ((IntPtr)itemID == (IntPtr)component)
				{
					RefreshSelectedItem(component);
				}
				LoopVerticalScrollRect listItems = _listItems;
				num++;
				component = (InventoryItem)(object)((object)component + (object)component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011EF")]
		[Cpp2IlInjected.Address(RVA = "0xA750B0", Offset = "0xA73AB0", VA = "0x180A750B0")]
		private void RefreshSelectedItem(InventoryItem item)
		{
			//Discarded unreachable code: IL_0051
			//IL_0010: Expected O, but got I4
			InventoryItem currentItemSelected = _currentItemSelected;
			int num = 0;
			if (currentItemSelected != (UnityEngine.Object)num)
			{
				InventoryItem currentItemSelected2 = _currentItemSelected;
				IItemData itemData = currentItemSelected2.ItemData;
				IItemData itemData2 = item.ItemData;
				if ((object)currentItemSelected2 != null)
				{
					InventoryItem currentItemSelected3 = _currentItemSelected;
					int isSelected = 0;
					UpdateSelected(currentItemSelected3, (byte)isSelected != 0);
				}
			}
			_currentItemSelected = item;
			UpdateSelected(item, isSelected: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60011F0")]
		[Cpp2IlInjected.Address(RVA = "0xA751E0", Offset = "0xA73BE0", VA = "0x180A751E0")]
		private void RefreshSelected()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60011F1")]
		[Cpp2IlInjected.Address(RVA = "0xA72E20", Offset = "0xA71820", VA = "0x180A72E20")]
		private void OnVerticalScrollbarValuedChanged(float _)
		{
			RefreshSelected();
		}

		[Cpp2IlInjected.Token(Token = "0x60011F2")]
		[Cpp2IlInjected.Address(RVA = "0xA779F0", Offset = "0xA763F0", VA = "0x180A779F0")]
		private void UpdateSelected(InventoryItem current, bool isSelected)
		{
			//Discarded unreachable code: IL_0041
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(current == (UnityEngine.Object)num))
			{
				((BaseWardrobeItem)current)._isSelected = isSelected;
				current.RefreshSelected();
				current.RefreshDisplay();
				current.LockedLabelAsset.Text = "";
				current.HideLocked();
				((BaseWardrobeItem)current)._oY = -128f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011F3")]
		[Cpp2IlInjected.Address(RVA = "0xA78100", Offset = "0xA76B00", VA = "0x180A78100")]
		public CatalogContent()
		{
		}//IL_0017: Expected I4, but got I8

	}
}
