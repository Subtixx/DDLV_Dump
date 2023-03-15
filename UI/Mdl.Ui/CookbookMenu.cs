using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Graphic;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000370")]
	[RequiredAllNotNull]
	public class CookbookMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40010B3")]
		[SerializeField]
		private LoopVerticalScrollRect _listCookbook;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40010B4")]
		public SlidingPanel Slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40010B5")]
		private Cookbook _cookbook;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40010B6")]
		private RecipeItemData[] _allRecipes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40010B7")]
		private RecipeItemData[] _currentRecipes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40010B8")]
		[SerializeField]
		private ButtonTmPro _btnMeals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40010B9")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40010BA")]
		[SerializeField]
		private TextBase _tfCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40010BB")]
		[SerializeField]
		private CurrencyContent _mcCurrencyContent;

		[Cpp2IlInjected.Token(Token = "0x60015F8")]
		[Cpp2IlInjected.Address(RVA = "0x14A5210", Offset = "0x14A3C10", VA = "0x1814A5210", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_00b8
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listCookbook).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnCookbookItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listCookbook).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnCookbookItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemDeselect = ((LoopScrollRect)_listCookbook).m_OnItemDeselect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnCookbookItemSelectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).AddListener((UnityAction<>)(object)unityAction3);
			Button.ButtonClickedEvent onClick = _btnMeals.ButtonComponent.m_OnClick;
			UnityAction call = OnMealClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnClose.m_OnClick;
			UnityAction call2 = OnCloseClickHandler;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x60015F9")]
		[Cpp2IlInjected.Address(RVA = "0x14A5540", Offset = "0x14A3F40", VA = "0x1814A5540", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_00b8
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listCookbook).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnCookbookItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listCookbook).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnCookbookItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemDeselect = ((LoopScrollRect)_listCookbook).m_OnItemDeselect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnCookbookItemSelectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).RemoveListener((UnityAction<>)(object)unityAction3);
			Button.ButtonClickedEvent onClick = _btnMeals.ButtonComponent.m_OnClick;
			UnityAction call = OnMealClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnClose.m_OnClick;
			UnityAction call2 = OnCloseClickHandler;
			onClick2.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x60015FA")]
		[Cpp2IlInjected.Address(RVA = "0x14A4EC0", Offset = "0x14A38C0", VA = "0x1814A4EC0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_001a
			base.OnPush(stack, param);
			int num = 0;
			UiRoot.Instance._worldCanvas.Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x60015FB")]
		[Cpp2IlInjected.Address(RVA = "0x14A4E40", Offset = "0x14A3840", VA = "0x1814A4E40", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0023
			base.OnPop();
			PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
			int num = 0;
			UiRoot.Instance._worldCanvas.Show();
		}

		[Cpp2IlInjected.Token(Token = "0x60015FC")]
		[Cpp2IlInjected.Address(RVA = "0x14A49A0", Offset = "0x14A33A0", VA = "0x1814A49A0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_00db
			//IL_0071: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			base.OnFocusIn();
			_mcCurrencyContent.Show();
			Slider.Show(andOpen: true);
			TextBase tfCounter = _tfCounter;
			int count = ((RepeatedField<T>)(object)SystemRoot.Instance.MetaClient.profile.player_.cookbook_.recipes_).Count;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int subItemEnumType = 0;
			int num = Enumerable.Count<RecipeItemData>(_003CInstance_003Ek__BackingField.GetAllByType<RecipeItemData, ActivityDataItemType>(ItemType.ActivityData, (ActivityDataItemType)subItemEnumType));
			string text2 = (tfCounter.Text = $"{count}/{num}");
			updateInfo();
			ButtonTmPro btnMeals = _btnMeals;
			int num2 = ((btnMeals.IsActive = false) ? 1 : 0);
			TextMeshProUGUI textComponent = _btnMeals.Label.TextComponent;
			int num3 = 0;
			RefreshDisplay();
			PostProcessManager.Instance.SetDof(DOFDistance.FAR);
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015FD")]
		[Cpp2IlInjected.Address(RVA = "0x14A4F30", Offset = "0x14A3930", VA = "0x1814A4F30", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__14))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__14 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__14(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015FE")]
		[Cpp2IlInjected.Address(RVA = "0x14A48D0", Offset = "0x14A32D0", VA = "0x1814A48D0")]
		private void OnCookbookItemSelectHandler(ListEventData arg)
		{
			//Discarded unreachable code: IL_003e
			//IL_0015: Expected O, but got I4
			CookbookItem component = arg.DisplayObject.GetComponent<CookbookItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				LoopVerticalScrollRect listCookbook = _listCookbook;
				int itemIndex = arg.ItemIndex;
				int selectedIndex = listCookbook.SelectedIndex;
				bool flag = (component.IsSelected = itemIndex == selectedIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015FF")]
		[Cpp2IlInjected.Address(RVA = "0x14A47C0", Offset = "0x14A31C0", VA = "0x1814A47C0")]
		private void OnCookbookItemDataHandler(ListEventData arg)
		{
			//Discarded unreachable code: IL_0067
			//IL_0015: Expected O, but got I4
			CookbookItem component = arg.DisplayObject.GetComponent<CookbookItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				RecipeItemData[] currentRecipes = _currentRecipes;
				int itemIndex = arg.ItemIndex;
				RecipeItemData recipeItemData = (component.RecipeItemData = currentRecipes[itemIndex]);
				component.RefreshDisplay();
				LoopVerticalScrollRect listCookbook = _listCookbook;
				int itemIndex2 = arg.ItemIndex;
				int selectedIndex = listCookbook.SelectedIndex;
				bool flag = (component.IsSelected = itemIndex2 == selectedIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001600")]
		[Cpp2IlInjected.Address(RVA = "0x14A4D60", Offset = "0x14A3760", VA = "0x1814A4D60")]
		private void OnMealClickHandler()
		{
			//Discarded unreachable code: IL_002a
			ButtonTmPro btnMeals = _btnMeals;
			int num = ((btnMeals.IsActive = false) ? 1 : 0);
			TextMeshProUGUI textComponent = _btnMeals.Label.TextComponent;
			int num2 = 0;
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001601")]
		[Cpp2IlInjected.Address(RVA = "0x14A4FB0", Offset = "0x14A39B0", VA = "0x1814A4FB0")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0093
			ButtonTmPro btnMeals = _btnMeals;
			RecipeItemData[] allRecipes = _allRecipes;
			Func<RecipeItemData, bool> func2 = default(Func<RecipeItemData, bool>);
			if (_003C_003Ec._003C_003E9__18_1 == null)
			{
				Func<RecipeItemData, bool> func = (Func<RecipeItemData, bool>)(object)(Func<T, TResult>)delegate(RecipeItemData x)
				{
					//Discarded unreachable code: IL_0017
					ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
					int resultItemID2 = x.ResultItemID;
					MealItemData mealItemData2 = default(MealItemData);
					return !mealItemData2.canBeUsedAsIngredient_;
				};
				if (_003C_003Ec._003C_003E9__18_0 == null)
				{
					func2 = (Func<RecipeItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(RecipeItemData x)
					{
						//Discarded unreachable code: IL_0014
						ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
						int resultItemID = x.ResultItemID;
						MealItemData mealItemData = default(MealItemData);
						return mealItemData.canBeUsedAsIngredient_;
					});
				}
			}
			RecipeItemData[] array = (_currentRecipes = Enumerable.Where<RecipeItemData>((IEnumerable<>)(object)allRecipes, (Func<, >)(object)func2).ToArray<RecipeItemData>());
			RecipeItemData[] currentRecipes = _currentRecipes;
			LoopVerticalScrollRect listCookbook = _listCookbook;
			int num = (listCookbook.totalCount = currentRecipes.Length);
			LoopVerticalScrollRect listCookbook2 = _listCookbook;
			int offset = 0;
			listCookbook2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6001602")]
		[Cpp2IlInjected.Address(RVA = "0x14A57A0", Offset = "0x14A41A0", VA = "0x1814A57A0")]
		private void updateInfo()
		{
			Cookbook cookbook = (_cookbook = SystemRoot.Instance.Client.Profile.player_.cookbook_);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<RecipeItemData, bool> _003C_003E9__19_ = _003C_003Ec._003C_003E9__19_0;
			if (_003C_003E9__19_ == null)
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
			RecipeItemData[] array = (_allRecipes = ((IEnumerable<>)Enumerable.OrderByDescending<RecipeItemData, bool>(enumerable, (Func<, >)(object)_003C_003E9__19_)).ToArray<RecipeItemData>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001603")]
		[Cpp2IlInjected.Address(RVA = "0x14A4700", Offset = "0x14A3100", VA = "0x1814A4700")]
		private void OnCloseClickHandler()
		{
			//Discarded unreachable code: IL_0013
			PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001604")]
		[Cpp2IlInjected.Address(RVA = "0x14A4F00", Offset = "0x14A3900", VA = "0x1814A4F00")]
		private void OnRefreshRequested()
		{
			//Discarded unreachable code: IL_000c
			_listCookbook.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6001605")]
		[Cpp2IlInjected.Address(RVA = "0x14A4770", Offset = "0x14A3170", VA = "0x1814A4770", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0022
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001606")]
		[Cpp2IlInjected.Address(RVA = "0x14A5470", Offset = "0x14A3E70", VA = "0x1814A5470")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_0047
			if (((LoopScrollRect)_listCookbook).m_Content.childCount > 0)
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				LoopVerticalScrollRect listCookbook = _listCookbook;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				int firstVisibleItemIndex = listCookbook.GetFirstVisibleItemIndex();
				Transform itemByDataIndex = listCookbook.GetItemByDataIndex(firstVisibleItemIndex);
				if ((object)itemByDataIndex != null)
				{
					FocusNavigationElement component = itemByDataIndex.GetComponent<FocusNavigationElement>();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001607")]
		[Cpp2IlInjected.Address(RVA = "0x14A4680", Offset = "0x14A3080", VA = "0x1814A4680", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0024
			if (redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.GamePopCurrentMenu)
			{
				PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001608")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public CookbookMenu()
		{
		}
	}
}
