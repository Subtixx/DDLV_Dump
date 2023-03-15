using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Buildings;
using Mdl.Ftue;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000392")]
	[RequiredAllNotNull]
	public class CookingMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001137")]
		[SerializeField]
		private UiTutorialPointer _mcTutorialPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001138")]
		[SerializeField]
		private RectTransform _mcPotArrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001139")]
		[SerializeField]
		private CookingCategorySelector _mcCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400113A")]
		[SerializeField]
		private CookingIngredientsContent _mcIngredientsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400113B")]
		[SerializeField]
		private CookingStation _mcCookingStation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400113C")]
		[SerializeField]
		private CurrencyContent _mcCurrencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400113D")]
		[SerializeField]
		private RecipeContent _recipeContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400113E")]
		[SerializeField]
		private SlidingPanel _mcCookingRecipeSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400113F")]
		[SerializeField]
		private SlidingPanel _mcIngredientSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001140")]
		[SerializeField]
		private CanvasGroup _mcIngredientContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001141")]
		[SerializeField]
		private RectTransform _mcShortcutHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001142")]
		private CookingStall cookingStall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001143")]
		private bool _isTutorialActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001145")]
		private EventSystem _eventSystem;

		[Cpp2IlInjected.Token(Token = "0x170003DB")]
		public CookingStation CookingStation
		{
			[Cpp2IlInjected.Token(Token = "0x600169D")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
			get
			{
				return _mcCookingStation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DC")]
		public RecipeItemData PreSelectedRecipeItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600169E")]
			[Cpp2IlInjected.Address(RVA = "0x975DD0", Offset = "0x9747D0", VA = "0x180975DD0")]
			[CompilerGenerated]
			get
			{
				return _003CPreSelectedRecipeItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600169F")]
			[Cpp2IlInjected.Address(RVA = "0x9765A0", Offset = "0x974FA0", VA = "0x1809765A0")]
			[CompilerGenerated]
			set
			{
				_003CPreSelectedRecipeItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016A0")]
		[Cpp2IlInjected.Address(RVA = "0x14AE1B0", Offset = "0x14ACBB0", VA = "0x1814AE1B0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0104
			((object)this)._002Ector();
			CookingStall cookingStall = this.cookingStall;
			EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(ChangeCookingMenuVisibilityEvent);
			cookingStall.add_ChangeCookingMenuVisibilityEvent((EventHandler<>)(object)eventHandler);
			CookingStation mcCookingStation = _mcCookingStation;
			EventHandler<bool> b = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(ChangeCookingMenuVisibilityEvent);
			EventHandler<bool> changeCookingMenuVisibilityEvent = mcCookingStation.ChangeCookingMenuVisibilityEvent;
			Delegate @delegate = Delegate.Combine(changeCookingMenuVisibilityEvent, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != changeCookingMenuVisibilityEvent)
				{
				}
				CookingStation mcCookingStation2 = _mcCookingStation;
				Action b2 = OnHistoryShown;
				Delegate delegate2 = Delegate.Combine(changeCookingMenuVisibilityEvent, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					mcCookingStation2.OnHistoryShown = (Action)delegate2;
					RecipeContent recipeContent = _recipeContent;
					EventHandler eventHandler2 = OnListChangeState;
					recipeContent.OnListChangeState += eventHandler2;
					CookingIngredientsContent mcIngredientsContent = _mcIngredientsContent;
					CookingIngredientsContent.OnSelectedIngredientsChangedDelegate b3 = OnSelectedIngredientsChanged;
					Delegate delegate3 = Delegate.Combine(eventHandler2, b3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						mcIngredientsContent.OnSelectedIngredientsChanged = (CookingIngredientsContent.OnSelectedIngredientsChangedDelegate)delegate3;
						CookingCategorySelector mcCategorySelector = _mcCategorySelector;
						FilterSelector.FilterSelectedByUser value = OnCategorySelected;
						mcCategorySelector.OnFilterSelectedByUser += value;
						return;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016A1")]
		[Cpp2IlInjected.Address(RVA = "0x14AEB80", Offset = "0x14AD580", VA = "0x1814AEB80", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0104
			((object)this)._002Ector();
			CookingStall cookingStall = this.cookingStall;
			EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(ChangeCookingMenuVisibilityEvent);
			cookingStall.remove_ChangeCookingMenuVisibilityEvent((EventHandler<>)(object)eventHandler);
			CookingStation mcCookingStation = _mcCookingStation;
			EventHandler<bool> value = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(ChangeCookingMenuVisibilityEvent);
			EventHandler<bool> changeCookingMenuVisibilityEvent = mcCookingStation.ChangeCookingMenuVisibilityEvent;
			Delegate @delegate = Delegate.Remove(changeCookingMenuVisibilityEvent, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != changeCookingMenuVisibilityEvent)
				{
				}
				CookingStation mcCookingStation2 = _mcCookingStation;
				Action value2 = OnHistoryShown;
				Delegate delegate2 = Delegate.Remove(changeCookingMenuVisibilityEvent, value2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					mcCookingStation2.OnHistoryShown = (Action)delegate2;
					RecipeContent recipeContent = _recipeContent;
					EventHandler eventHandler2 = OnListChangeState;
					recipeContent.OnListChangeState -= eventHandler2;
					CookingIngredientsContent mcIngredientsContent = _mcIngredientsContent;
					CookingIngredientsContent.OnSelectedIngredientsChangedDelegate value3 = OnSelectedIngredientsChanged;
					Delegate delegate3 = Delegate.Remove(eventHandler2, value3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						mcIngredientsContent.OnSelectedIngredientsChanged = (CookingIngredientsContent.OnSelectedIngredientsChangedDelegate)delegate3;
						CookingCategorySelector mcCategorySelector = _mcCategorySelector;
						FilterSelector.FilterSelectedByUser value4 = OnCategorySelected;
						mcCategorySelector.OnFilterSelectedByUser -= value4;
						return;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016A2")]
		[Cpp2IlInjected.Address(RVA = "0x14AD8D0", Offset = "0x14AC2D0", VA = "0x1814AD8D0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0051
			//IL_003e: Expected O, but got I4
			EventSystem eventSystem = (_eventSystem = UnityEngine.Object.FindObjectOfType<EventSystem>());
			object obj = param.Params[0];
			if (obj == null)
			{
			}
			int num = 0;
			cookingStall = (CookingStall)obj;
			FtueStep currentTutorialStep = cookingStall._currentTutorialStep;
			int num2 = 0;
			bool flag = (_isTutorialActive = currentTutorialStep != (UnityEngine.Object)num2);
			base.OnPush(stack, param);
		}

		[Cpp2IlInjected.Token(Token = "0x60016A3")]
		[Cpp2IlInjected.Address(RVA = "0x14AD890", Offset = "0x14AC290", VA = "0x1814AD890", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016A4")]
		[Cpp2IlInjected.Address(RVA = "0x14AD520", Offset = "0x14ABF20", VA = "0x1814AD520", Slot = "27")]
		public override void OnFocusIn()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016A5")]
		[Cpp2IlInjected.Address(RVA = "0x14ADF60", Offset = "0x14AC960", VA = "0x1814ADF60", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__25))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__25 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__25(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016A6")]
		[Cpp2IlInjected.Address(RVA = "0x14AD4A0", Offset = "0x14ABEA0", VA = "0x1814AD4A0")]
		private void OnCategorySelected()
		{
			RefreshIngredients();
		}

		[Cpp2IlInjected.Token(Token = "0x60016A7")]
		[Cpp2IlInjected.Address(RVA = "0x14ADFE0", Offset = "0x14AC9E0", VA = "0x1814ADFE0")]
		private void RefreshIngredients()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016A8")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnExitClickHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60016A9")]
		[Cpp2IlInjected.Address(RVA = "0x14AD0A0", Offset = "0x14ABAA0", VA = "0x1814AD0A0")]
		private void ChangeCookingMenuVisibilityEvent(object sender, bool e)
		{
			while (!e)
			{
			}
			Show();
		}

		[Cpp2IlInjected.Token(Token = "0x60016AA")]
		[Cpp2IlInjected.Address(RVA = "0x14AE800", Offset = "0x14AD200", VA = "0x1814AE800")]
		public void Show()
		{
			//Discarded unreachable code: IL_0146
			//IL_00a3: Expected O, but got I4
			int _003C_003E1__state = default(int);
			bool flag = default(bool);
			UiRoot instance2;
			int useKeyboardAsController2;
			do
			{
				_recipeContent.gameObject.SetActive(value: true);
				_mcShortcutHolder.gameObject.SetActive(value: true);
				_mcIngredientSlider.Show(andOpen: true);
				_mcCookingRecipeSlider.Show(andOpen: true);
				_mcIngredientsContent.CanvasGroup.interactable = true;
				_recipeContent.RefreshRecipeButton();
				CookingStation mcCookingStation = _mcCookingStation;
				bool canStartCooking = mcCookingStation.CookingStall.CanStartCooking;
				mcCookingStation.RefreshCookingButton(canStartCooking);
				CookingStation mcCookingStation2 = _mcCookingStation;
				Item _003CSelectedRecipe_003Ek__BackingField = mcCookingStation2.CookingStall.SelectedRecipe;
				mcCookingStation2.RefreshAutofillButton(_003CSelectedRecipe_003Ek__BackingField);
				FtueStep currentTutorialStep = cookingStall._currentTutorialStep;
				int num = 0;
				if (currentTutorialStep != (UnityEngine.Object)num)
				{
					_003CShowPointer_003Ed__31 _003CShowPointer_003Ed__ = new _003CShowPointer_003Ed__31(_003C_003E1__state);
					_003C_003E1__state = 0;
					_003CShowPointer_003Ed__._003C_003E4__this = this;
					Coroutine coroutine = StartCoroutine(_003CShowPointer_003Ed__);
				}
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && (long)base.MenuNavigation.FocusNavigation._focusedElement != 0)
				{
					if (base.MenuNavigation.FocusNavigation._focusedElement == null)
					{
						int num3 = 0;
					}
					int num4 = 0;
					if (flag)
					{
						ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
						return;
					}
				}
				int num5 = 0;
				instance2 = UiRoot.Instance;
				useKeyboardAsController2 = 0;
			}
			while (!instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0));
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60016AB")]
		[Cpp2IlInjected.Address(RVA = "0x14AE650", Offset = "0x14AD050", VA = "0x1814AE650")]
		[IteratorStateMachine(typeof(_003CShowPointer_003Ed__31))]
		private IEnumerator ShowPointer()
		{
			int _003C_003E1__state = default(int);
			_003CShowPointer_003Ed__31 _003CShowPointer_003Ed__ = new _003CShowPointer_003Ed__31(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowPointer_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016AC")]
		[Cpp2IlInjected.Address(RVA = "0x14AD340", Offset = "0x14ABD40", VA = "0x1814AD340")]
		public void Hide()
		{
			//Discarded unreachable code: IL_00bd
			RecipeContent recipeContent;
			do
			{
				CurrencyContent mcCurrencyContent = _mcCurrencyContent;
				if (!mcCurrencyContent.Slider.isHidden)
				{
					mcCurrencyContent.Hide();
				}
				_mcIngredientSlider.Hide();
				CanvasGroup canvasGroup = _mcIngredientsContent.CanvasGroup;
				int num = ((canvasGroup.interactable = false) ? 1 : 0);
				_mcCookingRecipeSlider.Hide();
				_mcTutorialPointer.Hide();
				recipeContent = _recipeContent;
			}
			while (!recipeContent._isListOpen);
			recipeContent.OnToggleButton();
			if (_recipeContent._mcHistoryContent.gameObject.activeSelf)
			{
				_recipeContent.OnHistoryCloseHandler();
			}
			GameObject gameObject = _recipeContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _mcShortcutHolder.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60016AD")]
		[Cpp2IlInjected.Address(RVA = "0x14AE6C0", Offset = "0x14AD0C0", VA = "0x1814AE6C0")]
		private void ShowTutorialPointer()
		{
			//Discarded unreachable code: IL_0065
			//IL_0015: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			RectTransform nextIngredientForTutorial;
			int num2;
			do
			{
				FtueStep currentTutorialStep = cookingStall._currentTutorialStep;
				int num = 0;
				if (!(currentTutorialStep != (UnityEngine.Object)num))
				{
					_mcTutorialPointer.Hide();
					return;
				}
				nextIngredientForTutorial = _mcIngredientsContent.GetNextIngredientForTutorial();
				num2 = 0;
			}
			while (nextIngredientForTutorial == (UnityEngine.Object)num2);
			UiTutorialPointer mcTutorialPointer = _mcTutorialPointer;
			Transform from = nextIngredientForTutorial.transform;
			Transform to = _mcPotArrow.transform;
			mcTutorialPointer.ShowDrag(from, to);
		}

		[Cpp2IlInjected.Token(Token = "0x60016AE")]
		[Cpp2IlInjected.Address(RVA = "0x14AD820", Offset = "0x14AC220", VA = "0x1814AD820")]
		private void OnListChangeState(object sender, EventArgs arg)
		{
			//Discarded unreachable code: IL_0037
			RecipeContent recipeContent = _recipeContent;
			CanvasGroup mcIngredientContainer = _mcIngredientContainer;
			if (!recipeContent._isListOpen)
			{
				GameObject gameObject = mcIngredientContainer.gameObject;
			}
			GameObject gameObject2 = mcIngredientContainer.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60016AF")]
		[Cpp2IlInjected.Address(RVA = "0x14ADA30", Offset = "0x14AC430", VA = "0x1814ADA30")]
		private unsafe void OnSelectedIngredientsChanged(IItemData item)
		{
			//Discarded unreachable code: IL_013b
			int num = 0;
			if (item == null || !_recipeContent._mcSelectedRecipeContent.gameObject.activeSelf)
			{
				return;
			}
			_recipeContent._mcSelectedRecipeContent.RefreshCheckmarks();
			int count = ((RepeatedField<T>)(object)_recipeContent._mcSelectedRecipeContent.RecipeItemData.ingredients_).Count;
			if (num >= count)
			{
				return;
			}
			RecipeItemData.Types.Ingredient ingredient;
			RecipeItemData.Types.Ingredient ingredient2 = (ingredient = (RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)_recipeContent._mcSelectedRecipeContent.RecipeItemData.ingredients_)[num]);
			if ((long)ingredient2 != 1)
			{
				Item item2 = default(Item);
				if ((long)ingredient2 != 2 || ingredient2 == null || !(*(Item*)item2 == *(Item*)item2))
				{
					goto IL_012e;
				}
				IEnumerable<Item> selectedIngredientList = (IEnumerable<Item>)_mcIngredientsContent.SelectedIngredientContent.get_SelectedIngredientList();
				Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					IItemData itemData2 = default(IItemData);
					if (itemData2 != null)
					{
						int num6 = 0;
					}
					int num7 = 0;
					Item? anyItem = (Item?)ingredient.get_AnyItem();
					Item item3 = default(Item);
					if (num7 != 0)
					{
						return *(Item*)num7 == *(Item*)item3;
					}
					int num8 = 0;
					throw new NullReferenceException();
				};
				int num2 = Enumerable.Count<Item>(Enumerable.Where<Item>((IEnumerable<>)selectedIngredientList, (Func<, >)(object)func));
				RecipeContent recipeContent = _recipeContent;
				int num3 = 0;
			}
			int num4 = default(int);
			if (num4 == 0)
			{
				IEnumerable<Item> selectedIngredientList2 = (IEnumerable<Item>)_mcIngredientsContent.SelectedIngredientContent.get_SelectedIngredientList();
				Func<Item, bool> func2 = (Func<Item, bool>)(object)(Func<T, TResult>)delegate(Item x)
				{
					//Discarded unreachable code: IL_001a
					RecipeItemData.Types.Ingredient ingredient3 = ingredient;
					int itemID = x.ItemID;
					int itemID2 = ingredient3.ItemID;
					return itemID == itemID2;
				};
				int added = Enumerable.Count<Item>(Enumerable.Where<Item>((IEnumerable<>)selectedIngredientList2, (Func<, >)(object)func2));
				SelectedRecipeContent mcSelectedRecipeContent = _recipeContent._mcSelectedRecipeContent;
				int num5 = 0;
				IItemData itemData = default(IItemData);
				mcSelectedRecipeContent.RefreshCounter(itemData, added);
			}
			goto IL_012e;
			IL_012e:
			RecipeContent recipeContent2 = _recipeContent;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60016B0")]
		[Cpp2IlInjected.Address(RVA = "0x14AD4B0", Offset = "0x14ABEB0", VA = "0x1814AD4B0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0038
			//IL_0016: Expected O, but got I4
			base.OnControllerChanged();
			EventSystem eventSystem = _eventSystem;
			int num = 0;
			eventSystem.SetSelectedGameObject((GameObject)num);
			SetFocus();
			_recipeContent.RefreshBtnOpenGamepadIndicator();
			_mcIngredientsContent.SelectedIngredientContent.RefreshIngredientsDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x60016B1")]
		[Cpp2IlInjected.Address(RVA = "0x14AE500", Offset = "0x14ACF00", VA = "0x1814AE500")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_006f
			//IL_0039: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !_recipeContent._isListOpen)
			{
				RectTransform categories = _mcCategorySelector._categories;
				int num2 = 0;
				if (categories != (UnityEngine.Object)num2 && categories.childCount > 0)
				{
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					int index = 0;
					FocusNavigationElement component = categories.GetChild(index).GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016B2")]
		[Cpp2IlInjected.Address(RVA = "0x14AD7E0", Offset = "0x14AC1E0", VA = "0x1814AD7E0")]
		private void OnHistoryShown()
		{
			//Discarded unreachable code: IL_001c
			//IL_0015: Expected O, but got I4
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num = 0;
			focusNavigation.SetFocus((FocusNavigationElement)num);
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60016B3")]
		[Cpp2IlInjected.Address(RVA = "0x14AD0C0", Offset = "0x14ABAC0", VA = "0x1814AD0C0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_014f
			//IL_0136: Expected I4, but got I8
			if (redirectionType != RedirectionType.MenuNavGoBackward && redirectionType != RedirectionType.MenuNavClose)
			{
				return;
			}
			CookingStation mcCookingStation = _mcCookingStation;
			if (mcCookingStation.IsInCookingAnimation)
			{
				return;
			}
			if (!_recipeContent._isListOpen)
			{
				if (!mcCookingStation._mcHistoryContent.gameObject.activeSelf)
				{
					if (_mcIngredientsContent.SelectedIngredientContent.GetAddedIngredientsCount() > 0)
					{
						int num = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
						{
							_mcIngredientsContent.SelectedIngredientContent.RemoveLastIngredient();
							return;
						}
					}
					IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
					return;
				}
				CookingStation mcCookingStation2 = _mcCookingStation;
				bool activeSelf = mcCookingStation2._mcHistoryContent.gameObject.activeSelf;
				CookingHistoryContent mcHistoryContent = mcCookingStation2._mcHistoryContent;
				CookingHistoryContent mcHistoryContent2 = default(CookingHistoryContent);
				if (!activeSelf)
				{
					mcHistoryContent.gameObject.SetActive(value: true);
					mcHistoryContent2 = mcCookingStation2._mcHistoryContent;
					mcHistoryContent2.Init();
				}
				GameObject gameObject = mcHistoryContent2.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				Action onHistoryShown = mcCookingStation2.OnHistoryShown;
				if (onHistoryShown != null)
				{
					onHistoryShown();
					SetFocus();
					return;
				}
			}
			else
			{
				int num2 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
					RecipesListContent mcRecipesListContent = _recipeContent._mcRecipesListContent;
					if (mcRecipesListContent._currentFocusArea == RecipesListContent.FocusArea.RecipeList)
					{
						mcRecipesListContent._currentFocusArea = RecipesListContent.FocusArea.CategoryList;
						SetFocus();
						return;
					}
				}
				_recipeContent.OnToggleButton();
			}
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60016B4")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public CookingMenu()
		{
		}
	}
}
