using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Ui;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[Cpp2IlInjected.Token(Token = "0x2000050")]
public class SettingsGameGuide : SettingsMenuPanel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum GameGuideState
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Category,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Slides
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private enum Context
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		PC,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Switch,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Ps4,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		Ps5
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[SerializeField]
	private bool _lockAccordingToFTUEProgress = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[SerializeField]
	private GameObject _catergoryContent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[SerializeField]
	private GameObject _slidesContent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[SerializeField]
	private Transform _slidesScrollRectContent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[SerializeField]
	private VerticalLayoutGroup _contentLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[SerializeField]
	private SetSizeBasedOnChild _sizeBasedOnChild;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[SerializeField]
	private SettingsGameGuideConfig _settingsGameGuideConfig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	[SerializeField]
	private ListBase _categoryList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[SerializeField]
	private GameObject _backToCategoriesButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private int _selectedIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private FocusNavigationElement _currentFocusNavElement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private MenuNavigation menuNavigation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private SettingsMenu _settingsMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private Coroutine _destroyChildCoroutine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private Coroutine _populateCoroutine;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public GameGuideState CurrentState;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public FocusNavigationElement CurrentFocusNavElement
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
		get
		{
			return _currentFocusNavElement;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
		set
		{
			_currentFocusNavElement = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public override FocusNavigationElement FirstFocusNavigationElement
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1263F90", Offset = "0x1262990", VA = "0x181263F90", Slot = "4")]
		get
		{
			if (_categoryList.m_Content.childCount > 0)
			{
				RectTransform content = _categoryList.m_Content;
				int index = 0;
				return content.GetChild(index).GetComponent<FocusNavigationElement>();
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1262850", Offset = "0x1261250", VA = "0x181262850")]
	public void Awake()
	{
		//Discarded unreachable code: IL_0068
		ListBase.ListEvents onItemData = _categoryList.m_OnItemData;
		UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategoryData);
		((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		ListBase.ListEvents onItemTap = _categoryList.m_OnItemTap;
		UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategoryTap);
		((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
		List<SettingsGameGuideConfig.SlideCategory> slideCategories = _settingsGameGuideConfig.SlideCategories;
		ListBase categoryList = _categoryList;
		int num = (categoryList.TotalCount = ((List<>)(object)slideCategories)._size);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1263230", Offset = "0x1261C30", VA = "0x181263230")]
	public void OnDestroy()
	{
		//Discarded unreachable code: IL_0041
		ListBase.ListEvents onItemData = _categoryList.m_OnItemData;
		UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategoryData);
		((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		ListBase.ListEvents onItemTap = _categoryList.m_OnItemTap;
		UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategoryTap);
		((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1262FB0", Offset = "0x12619B0", VA = "0x181262FB0")]
	private void OnCategoryData(ListBase.ListEventData args)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x1263060", Offset = "0x1261A60", VA = "0x181263060")]
	private void OnCategoryTap(ListBase.ListEventData args)
	{
		//IL_0026: Expected O, but got I4
		int num = 0;
		UiRoot instance = UiRoot.Instance;
		int useKeyboardAsController = 0;
		if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
		{
			MenuNavigation menuNavigation = this.menuNavigation;
			int num2 = 0;
			if (menuNavigation != (UnityEngine.Object)num2)
			{
				ISupportsFocusNavigation focusedElement = this.menuNavigation.FocusNavigation._focusedElement;
				int num3 = 0;
				GameObject gameObject = default(GameObject);
				if (gameObject.transform.GetSiblingIndex() != args.ItemIndex)
				{
					GameObject gameObject2 = default(GameObject);
					int num4 = (_selectedIndex = gameObject2.transform.GetSiblingIndex());
					RefreshState(GameGuideState.Slides);
					return;
				}
			}
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x12635A0", Offset = "0x1261FA0", VA = "0x1812635A0")]
	private void PopuplateCategories()
	{
		//Discarded unreachable code: IL_0022
		List<SettingsGameGuideConfig.SlideCategory> slideCategories = _settingsGameGuideConfig.SlideCategories;
		ListBase categoryList = _categoryList;
		int num = (categoryList.TotalCount = ((List<>)(object)slideCategories)._size);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x1263AC0", Offset = "0x12624C0", VA = "0x181263AC0")]
	private void SetupUnlockGuide()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x12633A0", Offset = "0x1261DA0", VA = "0x1812633A0")]
	private void OnEnable()
	{
		//Discarded unreachable code: IL_008d
		//IL_0029: Expected O, but got I4
		//IL_0063: Expected O, but got I4
		int num = 0;
		SettingsMenu settingsMenu = (_settingsMenu = UiRoot.Instance._menuStack.GetMenu<SettingsMenu>());
		SettingsMenu settingsMenu2 = _settingsMenu;
		int num2 = 0;
		if (!(settingsMenu2 != (UnityEngine.Object)num2))
		{
			return;
		}
		int num3 = 0;
		MenuStack menuStack = UiRoot.Instance._menuStack;
		SettingsMenu settingsMenu3 = _settingsMenu;
		if (menuStack.IsOnTop(settingsMenu3))
		{
			MenuNavigation menuNavigation = this.menuNavigation;
			int num4 = 0;
			if (menuNavigation == (UnityEngine.Object)num4)
			{
				MenuNavigation menuNavigation2 = (this.menuNavigation = _settingsMenu.MenuNavigation);
			}
			SetupUnlockGuide();
			int state = 0;
			RefreshState((GameGuideState)state);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x1263340", Offset = "0x1261D40", VA = "0x181263340")]
	private void OnDisable()
	{
		//IL_0009: Expected O, but got I8
		_currentFocusNavElement = (FocusNavigationElement)0;
		Coroutine destroyChildCoroutine = _destroyChildCoroutine;
		if (destroyChildCoroutine != null)
		{
			StopCoroutine(destroyChildCoroutine);
		}
		Coroutine populateCoroutine = _populateCoroutine;
		if (populateCoroutine != null)
		{
			StopCoroutine(populateCoroutine);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x1263600", Offset = "0x1262000", VA = "0x181263600")]
	public void RefreshState(GameGuideState state)
	{
		//IL_001c: Expected I4, but got I8
		//IL_0054: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_021c: Expected O, but got I4
		int num = (int)(CurrentState = state);
		if (num == 0)
		{
			ulong num2 = default(ulong);
			_catergoryContent.SetActive((byte)num2 != 0);
			GameObject slidesContent = _slidesContent;
			int active = 0;
			slidesContent.SetActive((byte)active != 0);
			GameObject backToCategoriesButton = _backToCategoriesButton;
			int active2 = 0;
			backToCategoriesButton.SetActive((byte)active2 != 0);
			FocusNavigationElement currentFocusNavElement = _currentFocusNavElement;
			int num3 = 0;
			if (currentFocusNavElement != (UnityEngine.Object)num3)
			{
				int num4 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				FocusNavigationElement currentFocusNavElement2 = _currentFocusNavElement;
				if (!flag)
				{
					currentFocusNavElement2.BaseButton.OnHighlightExit();
					int num5 = 0;
					_currentFocusNavElement = (FocusNavigationElement)num5;
				}
				currentFocusNavElement2.SetFocus();
				MenuNavigation menuNavigation = this.menuNavigation;
				int num6 = 0;
				if (menuNavigation != (UnityEngine.Object)num6)
				{
					FocusNavigation focusNavigation = this.menuNavigation.FocusNavigation;
					FocusNavigationElement currentFocusNavElement3 = _currentFocusNavElement;
					focusNavigation.SetFocus(currentFocusNavElement3);
				}
				SettingsMenu settingsMenu = _settingsMenu;
				int num7 = 0;
				if (settingsMenu != (UnityEngine.Object)num7)
				{
					SettingsMenu settingsMenu2 = _settingsMenu;
					FocusNavigationElement focusNavigationElement = (settingsMenu2._currentFocusedElement = _currentFocusNavElement);
				}
			}
			MenuNavigation menuNavigation2 = this.menuNavigation;
			int num8 = 0;
			if (menuNavigation2 != (UnityEngine.Object)num8)
			{
				this.menuNavigation.FocusNavigation.IsPaused = false;
			}
			if (_slidesScrollRectContent.childCount != 0)
			{
				Coroutine destroyChildCoroutine = _destroyChildCoroutine;
				if (destroyChildCoroutine != null)
				{
					StopCoroutine(destroyChildCoroutine);
				}
				int _003C_003E1__state = default(int);
				_003CDestroyChild_003Ed__35 _003CDestroyChild_003Ed__ = new _003CDestroyChild_003Ed__35(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CDestroyChild_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (_destroyChildCoroutine = StartCoroutine(_003CDestroyChild_003Ed__));
			}
			return;
		}
		while (num != 1)
		{
		}
		GameObject catergoryContent = _catergoryContent;
		int active3 = 0;
		catergoryContent.SetActive((byte)active3 != 0);
		_slidesContent.SetActive((byte)num != 0);
		GameObject backToCategoriesButton2 = _backToCategoriesButton;
		int num9 = 0;
		UiRoot instance2 = UiRoot.Instance;
		int useKeyboardAsController2 = 0;
		bool active4 = !instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0);
		backToCategoriesButton2.SetActive(active4);
		Transform transform = _catergoryContent.transform;
		int index = 0;
		Transform child = transform.GetChild(index);
		int selectedIndex = _selectedIndex;
		Transform child2 = child.GetChild(selectedIndex);
		FocusNavigationElement component = default(FocusNavigationElement);
		if ((object)child2 != null)
		{
			component = child2.GetComponent<FocusNavigationElement>();
		}
		_currentFocusNavElement = component;
		MenuNavigation menuNavigation3 = this.menuNavigation;
		int num10 = 0;
		if (menuNavigation3 != (UnityEngine.Object)num10)
		{
			this.menuNavigation.FocusNavigation.IsPaused = true;
		}
		Coroutine populateCoroutine = _populateCoroutine;
		if (populateCoroutine != null)
		{
			StopCoroutine(populateCoroutine);
		}
		int _003C_003E1__state2 = default(int);
		_003CPopulateSlides_003Ed__34 _003CPopulateSlides_003Ed__ = new _003CPopulateSlides_003Ed__34(_003C_003E1__state2);
		_003C_003E1__state2 = 0;
		_003CPopulateSlides_003Ed__._003C_003E4__this = this;
		Coroutine coroutine2 = (_populateCoroutine = StartCoroutine(_003CPopulateSlides_003Ed__));
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x12629B0", Offset = "0x12613B0", VA = "0x1812629B0")]
	public void BackToCategories()
	{
		int state = 0;
		RefreshState((GameGuideState)state);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
	public override void LoadGameSettings()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1263530", Offset = "0x1261F30", VA = "0x181263530")]
	[IteratorStateMachine(typeof(_003CPopulateSlides_003Ed__34))]
	private IEnumerator PopulateSlides()
	{
		int _003C_003E1__state = default(int);
		_003CPopulateSlides_003Ed__34 _003CPopulateSlides_003Ed__ = new _003CPopulateSlides_003Ed__34(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CPopulateSlides_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x12629C0", Offset = "0x12613C0", VA = "0x1812629C0")]
	[IteratorStateMachine(typeof(_003CDestroyChild_003Ed__35))]
	private IEnumerator DestroyChild()
	{
		int _003C_003E1__state = default(int);
		_003CDestroyChild_003Ed__35 _003CDestroyChild_003Ed__ = new _003CDestroyChild_003Ed__35(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CDestroyChild_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1262DC0", Offset = "0x12617C0", VA = "0x181262DC0")]
	private TutorialPopupContent GetContent(List<SettingsGameGuideConfig.SlideEntry> slideList)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x1262A30", Offset = "0x1261430", VA = "0x181262A30")]
	private TutorialPopupContent GetContentResult(List<SettingsGameGuideConfig.SlideEntry> slideList, SettingsGameGuideConfig.TutoPlatform tutoPlatform)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1263F80", Offset = "0x1262980", VA = "0x181263F80")]
	public SettingsGameGuide()
	{
		((AutoMobileShaderSwitch)(object)this)._002Ector();
	}
}
