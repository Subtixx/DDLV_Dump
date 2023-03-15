using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.InputSystem;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000410")]
	[RequiredAllNotNull]
	public class DecalLibraryContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000411")]
		public delegate void SelectDecal(DecalBaseItem decal);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001445")]
		private List<DecalItemData> _allDecals = (List<DecalItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001446")]
		private List<DecalItemData> _currentDecals = (List<DecalItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001447")]
		private DecalLibraryItem _current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001448")]
		private List<Filter> _currentFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001449")]
		private IItemData _lastClothesSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400144A")]
		[SerializeField]
		[Nulllable]
		private FocusNavigation _focusNav;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400144B")]
		[SerializeField]
		private LoopVerticalScrollRect _listItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400144C")]
		[SerializeField]
		private LayoutGroup _listCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400144D")]
		[SerializeField]
		private List<FilterItemSelector> _filterSelectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400144E")]
		[SerializeField]
		private GameObject _mcFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400144F")]
		[SerializeField]
		private TextBase _tfFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001450")]
		[SerializeField]
		private Button _btnFilterReset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001451")]
		[SerializeField]
		private Button _btnBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001452")]
		[SerializeField]
		private ListBase _listSelectedFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001453")]
		[SerializeField]
		private RectTransform _mcItemContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001454")]
		[SerializeField]
		private RectTransform _mcFilterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001455")]
		[SerializeField]
		private RectTransform _mcCategoryContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001456")]
		[SerializeField]
		private FilterItemSelector _categorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001457")]
		[SerializeField]
		private FilterItemSelector _colorizableSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001458")]
		[SerializeField]
		private Sprite _spriteAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001459")]
		[SerializeField]
		private ButtonTmProIcon _btnFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400145A")]
		[SerializeField]
		private TextBase _headerText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400145B")]
		[SerializeField]
		private HorizontalLayoutGroup _btnFiltersLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400145C")]
		[SerializeField]
		private GameObject _filterIco;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400145D")]
		[SerializeField]
		private FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400145E")]
		[SerializeField]
		private Color _colorizableFilterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400145F")]
		[SerializeField]
		private SetSizeBasedOnChild _filterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001460")]
		[SerializeField]
		private SetSizeBasedOnChild _filterContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001461")]
		[SerializeField]
		private FilterHelper _filterHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001462")]
		public bool isShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001463")]
		private InputAction resetFilterActionPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001464")]
		private InputAction resetFilterActionRelease;

		[Cpp2IlInjected.Token(Token = "0x1700044B")]
		public RectTransform FilterContent
		{
			[Cpp2IlInjected.Token(Token = "0x6001A50")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return _mcFilterContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000035")]
		public event SelectDecal OnDecalSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6001A4E")]
			[Cpp2IlInjected.Address(RVA = "0x12B4F50", Offset = "0x12B3950", VA = "0x1812B4F50")]
			[CompilerGenerated]
			add
			{
				SelectDecal onDecalSelected = this.OnDecalSelected;
				Delegate @delegate = Delegate.Combine(onDecalSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDecalSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001A4F")]
			[Cpp2IlInjected.Address(RVA = "0x12B4FF0", Offset = "0x12B39F0", VA = "0x1812B4FF0")]
			[CompilerGenerated]
			remove
			{
				SelectDecal onDecalSelected = this.OnDecalSelected;
				Delegate @delegate = Delegate.Remove(onDecalSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDecalSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A51")]
		[Cpp2IlInjected.Address(RVA = "0x12B15F0", Offset = "0x12AFFF0", VA = "0x1812B15F0")]
		private void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A52")]
		[Cpp2IlInjected.Address(RVA = "0x12B4D30", Offset = "0x12B3730", VA = "0x1812B4D30")]
		private void Update()
		{
			//Discarded unreachable code: IL_0048
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
		}

		[Cpp2IlInjected.Token(Token = "0x6001A53")]
		[Cpp2IlInjected.Address(RVA = "0x12B26A0", Offset = "0x12B10A0", VA = "0x1812B26A0")]
		private unsafe void OnDestroy()
		{
			//Discarded unreachable code: IL_017d
			//IL_010d: Expected O, but got I4
			Button.ButtonClickedEvent onClick = _btnFilters.ButtonComponent.m_OnClick;
			UnityAction call = OnFilterClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnBack.m_OnClick;
			UnityAction call2 = OnBackHandler;
			onClick2.RemoveListener(call2);
			FilterItemSelector categorySelector = _categorySelector;
			FilterSelector.FilterSelectedByUser value = OnCategorySelected;
			categorySelector.OnFilterSelectedByUser -= value;
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listItems).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemDeselect = ((LoopScrollRect)_listItems).m_OnItemDeselect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDeselectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).RemoveListener((UnityAction<>)(object)unityAction3);
			ListBase.ListEvents onItemData2 = _listSelectedFilters.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnSelectedFilterItemData);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction4);
			ButtonTmPro component = _btnFilterReset.GetComponent<ButtonTmPro>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				BaseButton.OnBaseButtonPress value2 = new BaseButton.OnBaseButtonPress(this, (IntPtr)__ldftn(DecalLibraryContent.OnResetPressHandler));
				component.OnPress -= value2;
				BaseButton.OnBaseButtonRelease value3 = new BaseButton.OnBaseButtonRelease(this, (IntPtr)__ldftn(DecalLibraryContent.OnResetReleaseHandler));
				component.OnRelease -= value3;
			}
			InputAction inputAction = resetFilterActionPress;
			EventHandler value4 = OnResetPressHandler;
			inputAction.OnTriggered -= value4;
			InputAction inputAction2 = resetFilterActionRelease;
			EventHandler value5 = OnResetReleaseHandler;
			inputAction2.OnTriggered -= value5;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A54")]
		[Cpp2IlInjected.Address(RVA = "0x12B2D40", Offset = "0x12B1740", VA = "0x1812B2D40")]
		private void OnItemDataHandler(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A55")]
		[Cpp2IlInjected.Address(RVA = "0x12B2F30", Offset = "0x12B1930", VA = "0x1812B2F30")]
		private void OnItemSelectHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_0074
			//IL_0015: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			DecalLibraryItem component = args.DisplayObject.GetComponent<DecalLibraryItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				DecalLibraryItem current = _current;
				if ((object)current != null)
				{
					int selected = 0;
					current.SetSelected((byte)selected != 0);
				}
				bool flag = current == component;
				int num2 = 0;
				_current = (DecalLibraryItem)num2;
				_current?.SetSelected(selected: true);
				SelectDecal onDecalSelected = this.OnDecalSelected;
				if (onDecalSelected != null)
				{
					DecalLibraryItem current2 = _current;
					onDecalSelected(current2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A56")]
		[Cpp2IlInjected.Address(RVA = "0x12B2E90", Offset = "0x12B1890", VA = "0x1812B2E90")]
		private void OnItemDeselectHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_0023
			//IL_0015: Expected O, but got I4
			InventoryItem component = args.DisplayObject.GetComponent<InventoryItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				int num2 = ((component.IsSelected = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A57")]
		[Cpp2IlInjected.Address(RVA = "0x12B25B0", Offset = "0x12B0FB0", VA = "0x1812B25B0")]
		private void OnBackHandler()
		{
			//Discarded unreachable code: IL_0056
			if (!_mcFilterContent.gameObject.activeInHierarchy)
			{
				if (!_mcItemContent.gameObject.activeInHierarchy)
				{
					goto IL_0032;
				}
				RefreshCategoryDisplay();
			}
			RefreshContentDisplay();
			goto IL_0032;
			IL_0032:
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNav = _focusNav;
				SetFocus(focusNav);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A58")]
		[Cpp2IlInjected.Address(RVA = "0x12B24C0", Offset = "0x12B0EC0", VA = "0x1812B24C0")]
		public bool HandleRedirection(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_0066
			if (redirectionType != RedirectionType.ToFilter)
			{
				if (!_mcFilterContent.gameObject.activeInHierarchy)
				{
					if (!_mcItemContent.gameObject.activeInHierarchy)
					{
						goto IL_003a;
					}
					RefreshCategoryDisplay();
				}
				RefreshContentDisplay();
				goto IL_003a;
			}
			OnFilterClickHandler();
			return true;
			IL_003a:
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNav = _focusNav;
				SetFocus(focusNav);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A59")]
		[Cpp2IlInjected.Address(RVA = "0x12B2660", Offset = "0x12B1060", VA = "0x1812B2660")]
		private void OnCategorySelected()
		{
			//Discarded unreachable code: IL_0012
			_btnFilters.RefreshLayout();
			RefreshContentDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5A")]
		[Cpp2IlInjected.Address(RVA = "0x12B3080", Offset = "0x12B1A80", VA = "0x1812B3080")]
		private void OnResetPressHandler(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_001d
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.ShowHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5B")]
		[Cpp2IlInjected.Address(RVA = "0x12B3080", Offset = "0x12B1A80", VA = "0x1812B3080")]
		private void OnResetPressHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_001d
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.ShowHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5C")]
		[Cpp2IlInjected.Address(RVA = "0x12B30F0", Offset = "0x12B1AF0", VA = "0x1812B30F0")]
		private void OnResetReleaseHandler(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0023
			ResetFilters();
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.RemoveHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5D")]
		[Cpp2IlInjected.Address(RVA = "0x12B30F0", Offset = "0x12B1AF0", VA = "0x1812B30F0")]
		private void OnResetReleaseHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_0023
			ResetFilters();
			Button btnFilterReset = _btnFilterReset;
			FilterHelper filterHelper = _filterHelper;
			ButtonTmPro component = btnFilterReset.GetComponent<ButtonTmPro>();
			filterHelper.RemoveHighlight(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5E")]
		[Cpp2IlInjected.Address(RVA = "0x12B2B90", Offset = "0x12B1590", VA = "0x1812B2B90")]
		private void OnFilterClickHandler()
		{
			//Discarded unreachable code: IL_009f
			GameObject gameObject = _btnFilters.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_btnBack.gameObject.SetActive(value: true);
			GameObject gameObject2 = _mcItemContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_mcFilterContent.gameObject.SetActive(value: true);
			_headerText.StringID = "menu.filter_filters";
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			int num2 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num3 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num4 = 0;
				if (top == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5F")]
		[Cpp2IlInjected.Address(RVA = "0x12B25A0", Offset = "0x12B0FA0", VA = "0x1812B25A0")]
		private void OnApplyClickHandler()
		{
			RefreshContentDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A60")]
		[Cpp2IlInjected.Address(RVA = "0x12B3170", Offset = "0x12B1B70", VA = "0x1812B3170")]
		private void OnSelectedFilterItemData(ListBase.ListEventData args)
		{
			//Discarded unreachable code: IL_0032
			//IL_0015: Expected O, but got I4
			SelectedFilterItem component = args.DisplayObject.GetComponent<SelectedFilterItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int itemIndex = args.ItemIndex;
				string displayName = Enumerable.ElementAt<Filter>((IEnumerable<>)_currentFilters, itemIndex).DisplayName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A61")]
		[Cpp2IlInjected.Address(RVA = "0x12B3070", Offset = "0x12B1A70", VA = "0x1812B3070")]
		internal void OnPanelActivate()
		{
			RefreshCategoryDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A62")]
		[Cpp2IlInjected.Address(RVA = "0x12B41F0", Offset = "0x12B2BF0", VA = "0x1812B41F0")]
		private void RefreshScrollbarVisibility()
		{
			//Discarded unreachable code: IL_0070
			//IL_0022: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			Scrollbar verticalScrollbar = ((LoopScrollRect)_listItems).m_VerticalScrollbar;
			if ((object)verticalScrollbar != null)
			{
				CanvasGroup component = verticalScrollbar.GetComponent<CanvasGroup>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				((LoopScrollRect)_listItems).m_Content.RebuildLayout();
				RectTransform content = ((LoopScrollRect)_listItems).m_Content;
				RectTransform viewport = ((LoopScrollRect)_listItems).m_Viewport;
				int num3 = 0;
				RectTransform content2 = ((LoopScrollRect)_listItems).m_Content;
				RectTransform viewport2 = ((LoopScrollRect)_listItems).m_Viewport;
				int num4 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A63")]
		[Cpp2IlInjected.Address(RVA = "0x12B3440", Offset = "0x12B1E40", VA = "0x1812B3440")]
		private void RefreshContentDisplay()
		{
			//Discarded unreachable code: IL_00e9
			_btnFilters.gameObject.SetActive(value: true);
			_btnBack.gameObject.SetActive(value: true);
			_mcItemContent.gameObject.SetActive(value: true);
			_listItems.gameObject.SetActive(value: true);
			GameObject gameObject = _mcFilterContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _mcCategoryContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_headerText.StringID = "menu.motif_customize";
			RefreshList();
			RefreshScrollbarVisibility();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				LoopVerticalScrollRect listItems = _listItems;
				int num2 = 0;
				listItems.GetItemByDataIndex(num2)?.GetComponent<BaseButton>().OnHighlightExit();
				LoopVerticalScrollRect listItems2 = _listItems;
				num2++;
			}
			FocusNavigation focusNav = _focusNav;
			SetFocus(focusNav);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A64")]
		[Cpp2IlInjected.Address(RVA = "0x12B3290", Offset = "0x12B1C90", VA = "0x1812B3290")]
		internal void RefreshCategoryDisplay()
		{
			//Discarded unreachable code: IL_00ca
			_categorySelector.ClearAllSelected();
			ResetFilters();
			GameObject gameObject = _btnFilters.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _btnBack.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _mcItemContent.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			_listItems.gameObject.SetActive(value: true);
			GameObject gameObject4 = _mcFilterContent.gameObject;
			int active4 = 0;
			gameObject4.SetActive((byte)active4 != 0);
			_mcCategoryContent.gameObject.SetActive(value: true);
			_headerText.StringID = "menu.motif_category";
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNav = _focusNav;
				SetFocus(focusNav);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A65")]
		[Cpp2IlInjected.Address(RVA = "0x12B3660", Offset = "0x12B2060", VA = "0x1812B3660")]
		public void RefreshList()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A66")]
		[Cpp2IlInjected.Address(RVA = "0x12B4880", Offset = "0x12B3280", VA = "0x1812B4880")]
		private void ResetFilters()
		{
			//Discarded unreachable code: IL_000c, IL_0012
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A67")]
		[Cpp2IlInjected.Address(RVA = "0x12B49A0", Offset = "0x12B33A0", VA = "0x1812B49A0")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_00ac
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(focusNavigation == (UnityEngine.Object)num))
			{
				if (_listCategory.gameObject.activeInHierarchy && _listCategory.transform.childCount > 0)
				{
					Transform transform = _listCategory.transform;
					int index = 0;
					FocusNavigationElement component = transform.GetChild(index).GetComponent<FocusNavigationElement>();
				}
				if (_listItems.gameObject.activeInHierarchy && ((LoopScrollRect)_listItems).m_Content.childCount > 0)
				{
					RectTransform content = ((LoopScrollRect)_listItems).m_Content;
				}
				if (_mcFilterContent.gameObject.activeInHierarchy)
				{
					FocusNavigationElement componentInChildren = _mcFilterContent.GetComponentInChildren<FocusNavigationElement>();
					focusNavigation.SetFocus(componentInChildren);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A68")]
		[Cpp2IlInjected.Address(RVA = "0x12B1FD0", Offset = "0x12B09D0", VA = "0x1812B1FD0")]
		private HashSet<Filter> CurrentFilters()
		{
			//Discarded unreachable code: IL_0082, IL_0088, IL_008e
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			List<FilterItemSelector> filterSelectors = _filterSelectors;
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__61_2 == null)
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
			if (_003C_003Ec._003C_003E9__61_0 == null)
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
			if (_003C_003Ec._003C_003E9__61_1 == null)
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

		[Cpp2IlInjected.Token(Token = "0x6001A69")]
		[Cpp2IlInjected.Address(RVA = "0x12B2430", Offset = "0x12B0E30", VA = "0x1812B2430")]
		public void DeselectAll()
		{
			LoopVerticalScrollRect listItems = _listItems;
			int num = (listItems.SelectedIndex = ListBase.INVALID_INDEX);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A6A")]
		[Cpp2IlInjected.Address(RVA = "0x12B1F70", Offset = "0x12B0970", VA = "0x1812B1F70")]
		public void Clear()
		{
			//Discarded unreachable code: IL_003c
			//IL_000e: Expected I4, but got I8
			_listItems.totalCount = 0;
			LoopVerticalScrollRect listItems = _listItems;
			int offset = 0;
			listItems.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)_listItems).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A6B")]
		[Cpp2IlInjected.Address(RVA = "0x12B43E0", Offset = "0x12B2DE0", VA = "0x1812B43E0")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_00b2, IL_00b8, IL_00be, IL_00c4
			int num = 0;
			_listItems.totalCount = num;
			LoopVerticalScrollRect listItems = _listItems;
			int offset = 0;
			listItems.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)_listItems).m_Content;
			int num2 = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
			((List<T>)(object)_allDecals).Clear();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ListInventory decals = SystemRoot.Instance.MetaClient.profile.player_.Decals;
			IEnumerable<> enumerable = default(IEnumerable<>);
			if (enumerable != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0088;
					}
					num++;
				}
				List<DecalItemData> allDecals = _allDecals;
				goto IL_0088;
			}
			goto IL_008f;
			IL_008f:
			if (enumerable != null)
			{
			}
			if (_003C_003Ec._003C_003E9__64_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DecalItemData x) => x.iD_);
			}
			return;
			IL_0088:
			enumerable = (IEnumerable<>)(object)((object)enumerable + (object)enumerable);
			goto IL_008f;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A6C")]
		[Cpp2IlInjected.Address(RVA = "0x12B4B80", Offset = "0x12B3580", VA = "0x1812B4B80")]
		private void SetSizeForFilterContent()
		{
			//Discarded unreachable code: IL_0017
			_filterContainer.DoAdjustment();
			_filterContent.DoAdjustment();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A6D")]
		[Cpp2IlInjected.Address(RVA = "0x12B4EA0", Offset = "0x12B38A0", VA = "0x1812B4EA0")]
		public DecalLibraryContent()
		{
		}
	}
}
