using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003B5")]
	[RequiredAllNotNull]
	public class RecipesListContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003B6")]
		public enum FocusArea
		{
			[Cpp2IlInjected.Token(Token = "0x4001247")]
			CategoryList,
			[Cpp2IlInjected.Token(Token = "0x4001248")]
			RecipeList
		}

		[Cpp2IlInjected.Token(Token = "0x20003B7")]
		public delegate void OnCloseDelegate();

		[Cpp2IlInjected.Token(Token = "0x20003B8")]
		public delegate void OnSelectRecipesListDelegate(RecipeItemData itemdata);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001231")]
		public OnCloseDelegate OnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001232")]
		public OnSelectRecipesListDelegate OnSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001233")]
		[SerializeField]
		public CanvasGroup CanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001234")]
		[SerializeField]
		private LoopVerticalScrollRect _listRecipes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001235")]
		[SerializeField]
		private ListBase _listRecipeCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001236")]
		[Nulllable]
		[SerializeField]
		private RecipeContent _recipeContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001237")]
		[SerializeField]
		private AssetReference _iconAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001238")]
		[SerializeField]
		[Nulllable]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001239")]
		private Cookbook _cookbook;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400123A")]
		private RecipeItemData[] _allRecipes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400123B")]
		private IEnumerable<ProfileWorld.FilterInfo> _mealQuests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400123C")]
		private RecipeItemData[] _currentRecipes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400123D")]
		private CookingRecipeList _cookingRecipeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400123E")]
		private List<MealTypeTagItemData> _mealTypeTagItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400123F")]
		private int _selectedIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4001240")]
		private int _selectedRecipeIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001241")]
		private int _focusedRecipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001242")]
		private RecipeItemData _selectedRecipeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001243")]
		public bool _forceUpdate = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4001244")]
		private bool _forceFocusToSelectedRecipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4001245")]
		private FocusArea _currentFocusArea;

		[Cpp2IlInjected.Token(Token = "0x170003F9")]
		public LoopVerticalScrollRect ListRecipes
		{
			[Cpp2IlInjected.Token(Token = "0x6001793")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _listRecipes;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FA")]
		public FocusArea CurrentFocusArea
		{
			[Cpp2IlInjected.Token(Token = "0x6001794")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7C0", Offset = "0xF391C0", VA = "0x180F3A7C0")]
			get
			{
				return _currentFocusArea;
			}
			[Cpp2IlInjected.Token(Token = "0x6001795")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7D0", Offset = "0xF391D0", VA = "0x180F3A7D0")]
			set
			{
				_currentFocusArea = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001796")]
		[Cpp2IlInjected.Address(RVA = "0xF37B80", Offset = "0xF36580", VA = "0x180F37B80")]
		private void Awake()
		{
			//Discarded unreachable code: IL_00d0
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listRecipes).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnRecipeItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listRecipes).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnRecipeItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.RecipeAdded value = OnRecipeAdded;
			_003CDispatcher_003Ek__BackingField.OnRecipeAdded += value;
			ListBase.ListEvents onItemTap2 = _listRecipeCategories.m_OnItemTap;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRecipeCatTabItemTap);
			((UnityEvent<T0>)(object)onItemTap2).AddListener((UnityAction<>)(object)unityAction3);
			FocusNavigation focusNavigation = _focusNavigation;
			FocusNavigation.FocusChanged value2 = OnFocusChanged;
			focusNavigation.OnFocusChanged += value2;
			ListBase.ListEvents onItemData2 = _listRecipeCategories.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRecipeCatTabData);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction4);
		}

		[Cpp2IlInjected.Token(Token = "0x6001797")]
		[Cpp2IlInjected.Address(RVA = "0xF38430", Offset = "0xF36E30", VA = "0x180F38430")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00dd
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listRecipes).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnRecipeItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listRecipes).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnRecipeItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemTap2 = _listRecipeCategories.m_OnItemTap;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRecipeCatTabItemTap);
			((UnityEvent<T0>)(object)onItemTap2).RemoveListener((UnityAction<>)(object)unityAction3);
			FocusNavigation focusNavigation = _focusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChanged;
			focusNavigation.OnFocusChanged -= value;
			ListBase.ListEvents onItemData2 = _listRecipeCategories.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRecipeCatTabData);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction4);
			if (SystemRoot.Instance.MetaClient != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.RecipeAdded value2 = OnRecipeAdded;
				_003CDispatcher_003Ek__BackingField.OnRecipeAdded -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001798")]
		[Cpp2IlInjected.Address(RVA = "0xF38810", Offset = "0xF37210", VA = "0x180F38810")]
		private void OnFocusChanged(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_005e
			//IL_002d: Expected O, but got I4
			//IL_0042: Expected I4, but got I8
			//IL_005d: Expected I4, but got I8
			if (!_recipeContent._isListOpen)
			{
				return;
			}
			ISupportsFocusNavigation focusedElement = _focusNavigation._focusedElement;
			if (focusedElement == null)
			{
				return;
			}
			int num = 0;
			if (focusedElement != null)
			{
				int num2 = 0;
				CookingRecipeListItem cookingRecipeListItem = default(CookingRecipeListItem);
				if (!(cookingRecipeListItem != (UnityEngine.Object)num2))
				{
					GameObject obj = default(GameObject);
					SelectTab(obj, fromFocusChange: true);
					_currentFocusArea = FocusArea.CategoryList;
				}
				else
				{
					Transform transform = default(Transform);
					int num3 = (_focusedRecipe = transform.GetSiblingIndex());
					_currentFocusArea = FocusArea.RecipeList;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001799")]
		[Cpp2IlInjected.Address(RVA = "0xF38AD0", Offset = "0xF374D0", VA = "0x180F38AD0")]
		private void OnRecipeCatTabItemTap(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_005d
			//IL_0010: Expected I4, but got I8
			LoopVerticalScrollRect listRecipes = _listRecipes;
			_currentFocusArea = FocusArea.RecipeList;
			int selectedIndex = _selectedIndex;
			int siblingIndex = arg.DisplayObject.transform.GetSiblingIndex();
			if (selectedIndex != siblingIndex)
			{
				MainMenuTabButton component = arg.DisplayObject.GetComponent<MainMenuTabButton>();
				if ((object)component != null)
				{
					int index = 0;
					component.PostSfx(index);
				}
			}
			GameObject displayObject = arg.DisplayObject;
			int fromFocusChange = 0;
			SelectTab(displayObject, (byte)fromFocusChange != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600179A")]
		[Cpp2IlInjected.Address(RVA = "0xF39A20", Offset = "0xF38420", VA = "0x180F39A20")]
		private void SelectTab(GameObject obj, bool fromFocusChange = false)
		{
			//Discarded unreachable code: IL_0088
			//IL_0049: Expected I4, but got I8
			//IL_007d: Expected I4, but got I8
			MainMenuTabButton component = obj.GetComponent<MainMenuTabButton>();
			int selectedIndex = _selectedIndex;
			if (selectedIndex != (_selectedIndex = obj.transform.GetSiblingIndex()))
			{
				DeselectAll();
				component.IsSelected = true;
				LoopVerticalScrollRect listRecipes = _listRecipes;
				_selectedRecipeIndex = -1;
				listRecipes.ResetVerticalValue();
				RefreshDisplay(fromFocusChange);
				ChecksIfHasRecipeSelected();
				_listRecipes.RefreshCells();
				RefreshScrollbarVisibility();
				_focusedRecipe = -1;
			}
			if (!fromFocusChange)
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600179B")]
		[Cpp2IlInjected.Address(RVA = "0xF38150", Offset = "0xF36B50", VA = "0x180F38150")]
		private void DeselectAll()
		{
			//Discarded unreachable code: IL_004c, IL_0052, IL_0064
			int num = 0;
			MainMenuTabButton mainMenuTabButton = default(MainMenuTabButton);
			if (_listRecipeCategories.m_Content.transform.GetEnumerator() != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num += 328;
				int num3 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				int num5 = ((mainMenuTabButton.IsSelected = false) ? 1 : 0);
			}
			if ((object)mainMenuTabButton == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600179C")]
		[Cpp2IlInjected.Address(RVA = "0xF37ED0", Offset = "0xF368D0", VA = "0x180F37ED0")]
		private void ChecksIfHasRecipeSelected()
		{
			//Discarded unreachable code: IL_0069
			//IL_0056: Expected I4, but got I8
			int num = Enumerable.Count<RecipeItemData>((IEnumerable<>)(object)_currentRecipes);
			int num2 = 0;
			if (Enumerable.Count<RecipeItemData>((IEnumerable<>)(object)_currentRecipes) <= 0)
			{
				return;
			}
			RecipeItemData selectedRecipeData = _selectedRecipeData;
			if (selectedRecipeData != null)
			{
				RecipeItemData recipeItemData = _currentRecipes[num2];
				int iD_ = selectedRecipeData.iD_;
				if (recipeItemData.iD_ == iD_)
				{
					return;
				}
			}
			_selectedRecipeIndex = -1;
			num2++;
			int num3 = Enumerable.Count<RecipeItemData>((IEnumerable<>)(object)_currentRecipes);
		}

		[Cpp2IlInjected.Token(Token = "0x600179D")]
		[Cpp2IlInjected.Address(RVA = "0xF38990", Offset = "0xF37390", VA = "0x180F38990")]
		private void OnRecipeCatTabData(ListBase.ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600179E")]
		[Cpp2IlInjected.Address(RVA = "0xF3A430", Offset = "0xF38E30", VA = "0x180F3A430")]
		public void UpdateSelected()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600179F")]
		[Cpp2IlInjected.Address(RVA = "0xF383F0", Offset = "0xF36DF0", VA = "0x180F383F0")]
		public void Init()
		{
			int num = (int)(_currentFocusArea = (FocusArea)(_selectedIndex = 0));
			if ((_forceUpdate ? 1 : 0) != num)
			{
				UpdateInfo();
				_forceUpdate = false;
			}
			UpdateSelected();
		}

		[Cpp2IlInjected.Token(Token = "0x60017A0")]
		[Cpp2IlInjected.Address(RVA = "0xF38390", Offset = "0xF36D90", VA = "0x180F38390")]
		public void ForceUpdate()
		{
			//Discarded unreachable code: IL_0026
			if (!base.gameObject.activeSelf)
			{
				_forceUpdate = true;
				return;
			}
			UpdateInfo();
			int fromFocusChange = 0;
			RefreshDisplay((byte)fromFocusChange != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60017A1")]
		[Cpp2IlInjected.Address(RVA = "0xF3A120", Offset = "0xF38B20", VA = "0x180F3A120")]
		private void UpdateInfo()
		{
			//Discarded unreachable code: IL_007d
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Cookbook cookbook = (_cookbook = profile.player_.cookbook_);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<RecipeItemData, bool> _003C_003E9__40_ = _003C_003Ec._003C_003E9__40_0;
			if (_003C_003E9__40_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(RecipeItemData x)
				{
					//Discarded unreachable code: IL_0023
					Cookbook cookbook_ = SystemRoot.Instance.MetaClient.profile.player_.cookbook_;
					int iD = x.ID;
					bool result = default(bool);
					return result;
				};
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			RecipeItemData[] array = (_allRecipes = ((IEnumerable<>)Enumerable.OrderByDescending<RecipeItemData, bool>(enumerable, (Func<, >)(object)_003C_003E9__40_)).ToArray<RecipeItemData>());
			IEnumerable<ProfileWorld.FilterInfo> enumerable2 = (_mealQuests = (IEnumerable<ProfileWorld.FilterInfo>)profile.world_.GetFiltersMealInfo());
			RefreshTabs();
		}

		[Cpp2IlInjected.Token(Token = "0x60017A2")]
		[Cpp2IlInjected.Address(RVA = "0xF39670", Offset = "0xF38070", VA = "0x180F39670")]
		private void RefreshTabs()
		{
			//Discarded unreachable code: IL_00d7
			//IL_00d6: Expected I4, but got I8
			if ((long)_mealTypeTagItems != 0)
			{
				return;
			}
			MealTypeTagItemData mealTypeTagItemData = new MealTypeTagItemData();
			mealTypeTagItemData.Name = "All";
			string text = (mealTypeTagItemData.IconAddress = _iconAll.AssetGUID);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<MealTypeTagItemData, int> _003C_003E9__41_ = _003C_003Ec._003C_003E9__41_0;
			if (_003C_003E9__41_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MealTypeTagItemData x) => x.sortPriority_);
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			List<MealTypeTagItemData> list = (_mealTypeTagItems = (List<MealTypeTagItemData>)(object)Enumerable.ToList<MealTypeTagItemData>((IEnumerable<>)Enumerable.OrderBy<MealTypeTagItemData, int>(enumerable, (Func<, >)(object)_003C_003E9__41_)));
			List<MealTypeTagItemData> mealTypeTagItems = _mealTypeTagItems;
			int index = 0;
			((List<T>)(object)mealTypeTagItems).Insert(index, (T)mealTypeTagItemData);
			List<MealTypeTagItemData> mealTypeTagItems2 = _mealTypeTagItems;
			ListBase listRecipeCategories = _listRecipeCategories;
			int num = (listRecipeCategories.TotalCount = ((List<>)(object)mealTypeTagItems2)._size);
			Transform transform = _listRecipeCategories.m_Content.transform;
			int selectedIndex = _selectedIndex;
			ulong num2 = default(ulong);
			transform.GetChild(selectedIndex).GetComponent<MainMenuTabButton>().IsSelected = (byte)num2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60017A3")]
		[Cpp2IlInjected.Address(RVA = "0xF38DC0", Offset = "0xF377C0", VA = "0x180F38DC0")]
		public void RefreshDisplay(bool fromFocusChange = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017A4")]
		[Cpp2IlInjected.Address(RVA = "0xF38BB0", Offset = "0xF375B0", VA = "0x180F38BB0")]
		private void OnRecipeItemDataHandler(ListEventData arg)
		{
			//Discarded unreachable code: IL_0064
			//IL_0015: Expected O, but got I4
			CookingRecipeListItem component = arg.DisplayObject.GetComponent<CookingRecipeListItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				RecipeItemData[] currentRecipes = _currentRecipes;
				int itemIndex = arg.ItemIndex;
				RecipeItemData recipeItemData = (component.RecipeItemData = currentRecipes[itemIndex]);
				IEnumerable<ProfileWorld.FilterInfo> mealQuests = _mealQuests;
				component.refreshDisplay((IEnumerable<>)mealQuests);
				int itemIndex2 = arg.ItemIndex;
				bool flag2 = (component.IsSelected = _selectedRecipeIndex == itemIndex2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017A5")]
		[Cpp2IlInjected.Address(RVA = "0xF38CC0", Offset = "0xF376C0", VA = "0x180F38CC0")]
		private void OnRecipeItemTapHandler(ListEventData arg)
		{
			//Discarded unreachable code: IL_005e
			//IL_0015: Expected O, but got I4
			CookingRecipeListItem component = arg.DisplayObject.GetComponent<CookingRecipeListItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				int num2 = (_selectedRecipeIndex = arg.ItemIndex);
				RecipeItemData recipeItemData = (_selectedRecipeData = component.RecipeItemData);
				_listRecipes.RefreshCells();
				OnSelectRecipesListDelegate onSelect = OnSelect;
				if (onSelect != null)
				{
					RecipeItemData _003CRecipeItemData_003Ek__BackingField = component.RecipeItemData;
					onSelect(_003CRecipeItemData_003Ek__BackingField);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017A6")]
		[Cpp2IlInjected.Address(RVA = "0xF399E0", Offset = "0xF383E0", VA = "0x180F399E0")]
		public void ResetSelections()
		{
			//IL_0010: Expected I4, but got I8
			_selectedRecipeIndex = -1;
			int fromFocusChange = 0;
			RefreshDisplay((byte)fromFocusChange != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60017A7")]
		[Cpp2IlInjected.Address(RVA = "0xF39B50", Offset = "0xF38550", VA = "0x180F39B50")]
		internal void SetFocus()
		{
			//Discarded unreachable code: IL_01d1
			//IL_003a: Expected O, but got I4
			//IL_011d: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || !base.gameObject.activeSelf)
			{
				return;
			}
			FocusNavigation focusNavigation = _focusNavigation;
			int num2 = 0;
			if (!(focusNavigation != (UnityEngine.Object)num2))
			{
				return;
			}
			if (_currentFocusArea == FocusArea.CategoryList && _listRecipeCategories.m_Content.childCount > 0)
			{
				RectTransform content = _listRecipeCategories.m_Content;
			}
			if (_currentFocusArea == FocusArea.RecipeList && ((LoopScrollRect)_listRecipes).m_Content.childCount > 0)
			{
				if (!_forceFocusToSelectedRecipe)
				{
					int focusedRecipe = _focusedRecipe;
					if (focusedRecipe != -1)
					{
						int childCount = ((LoopScrollRect)_listRecipes).m_Content.childCount;
						if (focusedRecipe < childCount)
						{
							RectTransform content2 = ((LoopScrollRect)_listRecipes).m_Content;
						}
					}
					LoopVerticalScrollRect listRecipes = _listRecipes;
				}
				LoopVerticalScrollRect listRecipes2 = _listRecipes;
				int num3 = 0;
				_forceFocusToSelectedRecipe = false;
				int childCount2 = ((LoopScrollRect)listRecipes2).m_Content.childCount;
				LoopVerticalScrollRect listRecipes3 = _listRecipes;
				if (num3 < childCount2)
				{
					CookingRecipeListItem component = ((LoopScrollRect)listRecipes3).m_Content.GetChild(num3).GetComponent<CookingRecipeListItem>();
					int num4 = 0;
					if (component != (UnityEngine.Object)num4)
					{
						RecipeItemData selectedRecipeData = _selectedRecipeData;
						if (selectedRecipeData != null)
						{
							int iD_ = selectedRecipeData.iD_;
							RecipeItemData _003CRecipeItemData_003Ek__BackingField = ((LoopScrollRect)_listRecipes).m_Content.GetChild(num3).GetComponent<CookingRecipeListItem>().RecipeItemData;
						}
					}
					LoopVerticalScrollRect listRecipes4 = _listRecipes;
					num3++;
				}
				FocusNavigation focusNavigation2 = _focusNavigation;
				FocusNavigationElement component2 = ((LoopScrollRect)listRecipes3).m_Content.GetChild(num3).GetComponent<FocusNavigationElement>();
				focusNavigation2.SetFocus(component2);
			}
			if (_listRecipeCategories.m_Content.childCount > 0)
			{
				ListBase listRecipeCategories = _listRecipeCategories;
				FocusNavigation focusNavigation3 = _focusNavigation;
				RectTransform content3 = listRecipeCategories.m_Content;
				int index = 0;
				FocusNavigationElement component3 = content3.GetChild(index).GetComponent<FocusNavigationElement>();
				focusNavigation3.SetFocus(component3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017A8")]
		[Cpp2IlInjected.Address(RVA = "0x998E10", Offset = "0x997810", VA = "0x180998E10")]
		private void OnCloseClickHandler()
		{
			OnClose?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60017A9")]
		[Cpp2IlInjected.Address(RVA = "0xF38390", Offset = "0xF36D90", VA = "0x180F38390")]
		private void OnRecipeAdded(Item recipeItem, InvActionType reason)
		{
			//Discarded unreachable code: IL_0026
			if (!base.gameObject.activeSelf)
			{
				_forceUpdate = true;
				return;
			}
			UpdateInfo();
			int fromFocusChange = 0;
			RefreshDisplay((byte)fromFocusChange != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60017AA")]
		[Cpp2IlInjected.Address(RVA = "0xF39440", Offset = "0xF37E40", VA = "0x180F39440")]
		private void RefreshScrollbarVisibility()
		{
			//Discarded unreachable code: IL_0070
			//IL_0022: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			Scrollbar verticalScrollbar = ((LoopScrollRect)_listRecipes).m_VerticalScrollbar;
			if ((object)verticalScrollbar != null)
			{
				CanvasGroup component = verticalScrollbar.GetComponent<CanvasGroup>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate(((LoopScrollRect)_listRecipes).m_Content);
				RectTransform content = ((LoopScrollRect)_listRecipes).m_Content;
				RectTransform viewport = ((LoopScrollRect)_listRecipes).m_Viewport;
				int num3 = 0;
				RectTransform content2 = ((LoopScrollRect)_listRecipes).m_Content;
				RectTransform viewport2 = ((LoopScrollRect)_listRecipes).m_Viewport;
				int num4 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017AB")]
		[Cpp2IlInjected.Address(RVA = "0xF37FB0", Offset = "0xF369B0", VA = "0x180F37FB0")]
		public void CustomFindNextRecipeItem(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_0037
			if (direction == FocusDirection.Left)
			{
				ListBase listRecipeCategories = _listRecipeCategories;
				FocusNavigation focusNavigation = _focusNavigation;
				RectTransform content = listRecipeCategories.m_Content;
				int selectedIndex = _selectedIndex;
				FocusNavigationElement component = content.GetChild(selectedIndex).GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017AC")]
		[Cpp2IlInjected.Address(RVA = "0xF38040", Offset = "0xF36A40", VA = "0x180F38040")]
		public void CustomFindNextTab(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_0077
			if (direction != FocusDirection.Right || ((LoopScrollRect)_listRecipes).m_Content.childCount <= 0)
			{
				return;
			}
			int focusedRecipe = _focusedRecipe;
			if (focusedRecipe != -1)
			{
				int childCount = ((LoopScrollRect)_listRecipes).m_Content.childCount;
				if (focusedRecipe < childCount)
				{
					RectTransform content = ((LoopScrollRect)_listRecipes).m_Content;
				}
			}
			LoopVerticalScrollRect listRecipes = _listRecipes;
			FocusNavigation focusNavigation = _focusNavigation;
			RectTransform content2 = ((LoopScrollRect)listRecipes).m_Content;
			int index = 0;
			FocusNavigationElement component = content2.GetChild(index).GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60017AD")]
		[Cpp2IlInjected.Address(RVA = "0xF3A7A0", Offset = "0xF391A0", VA = "0x180F3A7A0")]
		public RecipesListContent()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
