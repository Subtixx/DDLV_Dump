using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003A9")]
	[RequiredAllNotNull]
	public class PantryMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40011D2")]
		[SerializeField]
		private SlidingPanel _slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40011D3")]
		[SerializeField]
		private Button _btnExit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40011D4")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40011D5")]
		private List<int> _listTransferIndexes = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40011D6")]
		[SerializeField]
		private ButtonTmPro _btnTransfer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40011D7")]
		[SerializeField]
		private ButtonTmPro _btnCancelTransfer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40011D8")]
		[SerializeField]
		private RectTransform _mcBackpackContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40011D9")]
		[SerializeField]
		private LoopVerticalScrollRect _listBackpack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40011DA")]
		[SerializeField]
		private TextBase _tfEmptyBackpack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40011DB")]
		private Dictionary<int, int> _transferSelectedIndexesAndAmount = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40011DC")]
		[SerializeField]
		private RectTransform _mcPantryContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40011DD")]
		[SerializeField]
		private LoopVerticalScrollRect _listPantry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40011DE")]
		[SerializeField]
		private Button _btnAddIngeredient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40011DF")]
		[SerializeField]
		private TextBase _tfEmptyPantry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40011E0")]
		private List<ICookingIngredient> _activePantry = (List<ICookingIngredient>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40011E1")]
		private ListInventory _pantry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40011E2")]
		private List<ICookingIngredient> _allIngredientItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40011E3")]
		[SerializeField]
		private Button _btnFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40011E4")]
		[SerializeField]
		private RectTransform _mcFilterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40011E5")]
		[SerializeField]
		private DynamicFilterSelector _mcCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40011E6")]
		private Item _currentCategory = Item.Invalid;

		[Cpp2IlInjected.Token(Token = "0x600172C")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E40", Offset = "0x9B2840", VA = "0x1809B3E40", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_016c
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listPantry).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPantryItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listBackpack).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemSelectedHandler);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemDeselect = ((LoopScrollRect)_listBackpack).m_OnItemDeselect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDeselectedHandler);
			((UnityEvent<T0>)(object)onItemDeselect).AddListener((UnityAction<>)(object)unityAction3);
			LoopScrollRect.ListEvents onItemData2 = ((LoopScrollRect)_listBackpack).m_OnItemData;
			UnityAction<ListEventData> unityAction4 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnBackpackItemDataHandler);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction4);
			Button.ButtonClickedEvent onClick = _btnFilter.m_OnClick;
			UnityAction call = OnCategoryClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnAddIngeredient.m_OnClick;
			UnityAction call2 = OnAddIngeredientClickHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnExit.m_OnClick;
			UnityAction call3 = OnExitClickHandler;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnTransfer.ButtonComponent.m_OnClick;
			UnityAction call4 = OnTransferClickHandler;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnCancelTransfer.ButtonComponent.m_OnClick;
			UnityAction call5 = OnCancelTransferClickHandler;
			onClick5.AddListener(call5);
			DynamicFilterSelector mcCategorySelector = _mcCategorySelector;
			FilterSelector.FilterSelectedByUser value = OnCategorySelectHandler;
			mcCategorySelector.OnFilterSelectedByUser += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600172D")]
		[Cpp2IlInjected.Address(RVA = "0x9B48D0", Offset = "0x9B32D0", VA = "0x1809B48D0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_016c
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listPantry).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPantryItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listBackpack).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemSelectedHandler);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemDeselect = ((LoopScrollRect)_listBackpack).m_OnItemDeselect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDeselectedHandler);
			((UnityEvent<T0>)(object)onItemDeselect).RemoveListener((UnityAction<>)(object)unityAction3);
			LoopScrollRect.ListEvents onItemData2 = ((LoopScrollRect)_listBackpack).m_OnItemData;
			UnityAction<ListEventData> unityAction4 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnBackpackItemDataHandler);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction4);
			Button.ButtonClickedEvent onClick = _btnFilter.m_OnClick;
			UnityAction call = OnCategoryClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnAddIngeredient.m_OnClick;
			UnityAction call2 = OnAddIngeredientClickHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnExit.m_OnClick;
			UnityAction call3 = OnExitClickHandler;
			onClick3.RemoveListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnTransfer.ButtonComponent.m_OnClick;
			UnityAction call4 = OnTransferClickHandler;
			onClick4.RemoveListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnCancelTransfer.ButtonComponent.m_OnClick;
			UnityAction call5 = OnCancelTransferClickHandler;
			onClick5.RemoveListener(call5);
			DynamicFilterSelector mcCategorySelector = _mcCategorySelector;
			FilterSelector.FilterSelectedByUser value = OnCategorySelectHandler;
			mcCategorySelector.OnFilterSelectedByUser -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x600172E")]
		[Cpp2IlInjected.Address(RVA = "0x9B32D0", Offset = "0x9B1CD0", VA = "0x1809B32D0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			base.OnPush(stack, param);
		}

		[Cpp2IlInjected.Token(Token = "0x600172F")]
		[Cpp2IlInjected.Address(RVA = "0x85C740", Offset = "0x85B140", VA = "0x18085C740", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001730")]
		[Cpp2IlInjected.Address(RVA = "0x9B2640", Offset = "0x9B1040", VA = "0x1809B2640", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_00db
			//IL_00d4: Expected I4, but got I8
			base.OnFocusIn();
			ListInventory listInventory = (_pantry = SystemRoot.Instance.Client.Profile.Pantry);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<ICookingIngredient, bool> _003C_003E9__25_ = _003C_003Ec._003C_003E9__25_0;
			if (_003C_003E9__25_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			IEnumerable<ICookingIngredient> enumerable2 = (IEnumerable<ICookingIngredient>)Enumerable.Where<ICookingIngredient>(enumerable, (Func<, >)(object)_003C_003E9__25_);
			Func<ICookingIngredient, Item> func = default(Func<ICookingIngredient, Item>);
			if (_003C_003Ec._003C_003E9__25_1 == null)
			{
				func = (Func<ICookingIngredient, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			IOrderedEnumerable<ICookingIngredient> orderedEnumerable = (IOrderedEnumerable<ICookingIngredient>)Enumerable.OrderBy<ICookingIngredient, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func);
			Func<ICookingIngredient, string> func2 = default(Func<ICookingIngredient, string>);
			if (_003C_003Ec._003C_003E9__25_2 == null)
			{
				func2 = (Func<ICookingIngredient, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0012
					string result = default(string);
					if ((object)typeof(IItemData).TypeHandle != null && (object)typeof(IItemData).TypeHandle != null)
					{
						return result;
					}
					throw new InvalidCastException();
				});
			}
			List<ICookingIngredient> list = (_allIngredientItems = (List<ICookingIngredient>)(object)Enumerable.ToList<ICookingIngredient>((IEnumerable<>)Enumerable.ThenBy<ICookingIngredient, string>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func2)));
			_mcCategorySelector.Init();
			base.IsDataUpToDate = true;
			ulong num = default(ulong);
			_slider.Show((byte)num != 0);
			OnCategorySelectHandler();
		}

		[Cpp2IlInjected.Token(Token = "0x6001731")]
		[Cpp2IlInjected.Address(RVA = "0x9B3460", Offset = "0x9B1E60", VA = "0x1809B3460", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__26))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__26 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__26(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001732")]
		[Cpp2IlInjected.Address(RVA = "0x9B2F80", Offset = "0x9B1980", VA = "0x1809B2F80")]
		private void OnPantryItemDataHandler(ListEventData arg0)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001733")]
		[Cpp2IlInjected.Address(RVA = "0x9B3B40", Offset = "0x9B2540", VA = "0x1809B3B40")]
		public void RefreshPantry()
		{
			//Discarded unreachable code: IL_006a
			_btnFilter.gameObject.SetActive(value: true);
			RefreshActivePantry();
			List<ICookingIngredient> activePantry = _activePantry;
			LoopVerticalScrollRect listPantry = _listPantry;
			int num = (listPantry.totalCount = ((List<>)(object)activePantry)._size);
			LoopVerticalScrollRect listPantry2 = _listPantry;
			int offset = 0;
			listPantry2.RefillCells(offset);
			GameObject gameObject = _tfEmptyPantry.gameObject;
			List<ICookingIngredient> activePantry2 = _activePantry;
			bool active = default(bool);
			gameObject.SetActive(active);
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001734")]
		[Cpp2IlInjected.Address(RVA = "0x9B34E0", Offset = "0x9B1EE0", VA = "0x1809B34E0")]
		private void RefreshActivePantry()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001735")]
		[Cpp2IlInjected.Address(RVA = "0x9B21F0", Offset = "0x9B0BF0", VA = "0x1809B21F0")]
		private void OnCategoryClickHandler()
		{
			//Discarded unreachable code: IL_007b
			GameObject gameObject = _btnFilter.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_tfTitle.StringID = "menu.inventory_categories";
			_mcFilterContent.gameObject.SetActive(value: true);
			GameObject gameObject2 = _mcPantryContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _mcBackpackContent.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			SetFocus();
			((List<T>)(object)_mcCategorySelector.selectedFilters).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6001736")]
		[Cpp2IlInjected.Address(RVA = "0x9B1BC0", Offset = "0x9B05C0", VA = "0x1809B1BC0")]
		private void OnAddIngeredientClickHandler()
		{
			//Discarded unreachable code: IL_006b
			GameObject gameObject = _btnFilter.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_tfTitle.StringID = "menu.backpack_title";
			GameObject gameObject2 = _mcFilterContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _mcPantryContent.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			_mcBackpackContent.gameObject.SetActive(value: true);
			RefreshBackPack();
		}

		[Cpp2IlInjected.Token(Token = "0x6001737")]
		[Cpp2IlInjected.Address(RVA = "0x9B3710", Offset = "0x9B2110", VA = "0x1809B3710")]
		private void RefreshBackPack()
		{
			//Discarded unreachable code: IL_00ef
			//IL_007c: Expected O, but got I4
			((List<T>)(object)_listTransferIndexes).Clear();
			int num = 0;
			int count = ((RepeatedField<T>)(object)SystemRoot.Instance.Client.Profile.Backpack.inventory_).Count;
			if (num < count)
			{
				Client client = default(Client);
				if (((ContainerInventory.Types.Slot)((RepeatedField<T>)(object)client.Profile.Backpack.inventory_)[num]).amount_ != 0)
				{
					Client client2 = default(Client);
					ContainerInventory.Types.Slot slot = (ContainerInventory.Types.Slot)((RepeatedField<T>)(object)client2.Profile.Backpack.inventory_)[num];
					ICookingIngredient cookingIngredient = default(ICookingIngredient);
					if (cookingIngredient != null && cookingIngredient != null)
					{
						((List<T>)(object)_listTransferIndexes).Add((T)num);
					}
				}
				num++;
			}
			List<int> listTransferIndexes = _listTransferIndexes;
			LoopVerticalScrollRect listBackpack = _listBackpack;
			int num2 = (listBackpack.totalCount = ((List<>)(object)listTransferIndexes)._size);
			LoopVerticalScrollRect listBackpack2 = _listBackpack;
			int offset = 0;
			listBackpack2.RefillCells(offset);
			List<int> list = (List<int>)(object)Enumerable.ToList<int>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)_transferSelectedIndexesAndAmount).get_Keys());
			LoopVerticalScrollRect listBackpack3 = _listBackpack;
			int[] array2 = (listBackpack3.SelectedIndexes = (int[])(object)((List<T>)(object)list).ToArray());
			RefreshTransferButtonLabel();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001738")]
		[Cpp2IlInjected.Address(RVA = "0x9B2320", Offset = "0x9B0D20", VA = "0x1809B2320")]
		private void OnCategorySelectHandler()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001739")]
		[Cpp2IlInjected.Address(RVA = "0x9B2ED0", Offset = "0x9B18D0", VA = "0x1809B2ED0")]
		private void OnItemSelectedHandler(ListEventData arg0)
		{
			//Discarded unreachable code: IL_002a
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			GameObject displayObject = arg0.DisplayObject;
			if ((object)displayObject != null)
			{
				InventorySellItem component = displayObject.GetComponent<InventorySellItem>();
			}
			int num = 0;
			int num2 = 0;
			if (!((UnityEngine.Object)num == (UnityEngine.Object)num2))
			{
				bool autoSkip = ((IFluxStatement)num).AutoSkip;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600173A")]
		[Cpp2IlInjected.Address(RVA = "0x9B3C20", Offset = "0x9B2620", VA = "0x1809B3C20")]
		private void RefreshTransferButtonLabel()
		{
			//Discarded unreachable code: IL_0095
			GameObject gameObject = _tfEmptyBackpack.gameObject;
			List<int> listTransferIndexes = _listTransferIndexes;
			bool active = default(bool);
			gameObject.SetActive(active);
			Button buttonComponent = _btnTransfer.ButtonComponent;
			List<int> listTransferIndexes2 = _listTransferIndexes;
			bool interactable = default(bool);
			buttonComponent.interactable = interactable;
			Dictionary<int, int> transferSelectedIndexesAndAmount = _transferSelectedIndexesAndAmount;
			Func<KeyValuePair<int, int>, int> _003C_003E9__35_ = _003C_003Ec._003C_003E9__35_0;
			if (_003C_003E9__35_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			int num = Enumerable.Sum<KeyValuePair<int, int>>((IEnumerable<>)transferSelectedIndexesAndAmount, (Func<, >)(object)_003C_003E9__35_);
			TextBase label = _btnTransfer.Label;
			string stringID = "cooking.pantry_transfer_all";
			if (num > 0)
			{
				stringID = "cooking.pantry_transfer";
			}
			label.StringID = stringID;
		}

		[Cpp2IlInjected.Token(Token = "0x600173B")]
		[Cpp2IlInjected.Address(RVA = "0x9B2E20", Offset = "0x9B1820", VA = "0x1809B2E20")]
		private void OnItemDeselectedHandler(ListEventData arg0)
		{
			//Discarded unreachable code: IL_002a
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			GameObject displayObject = arg0.DisplayObject;
			if ((object)displayObject != null)
			{
				InventorySellItem component = displayObject.GetComponent<InventorySellItem>();
			}
			int num = 0;
			int num2 = 0;
			if (!((UnityEngine.Object)num == (UnityEngine.Object)num2))
			{
				bool autoSkip = ((IFluxStatement)num).AutoSkip;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600173C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1CC0", Offset = "0x9B06C0", VA = "0x1809B1CC0")]
		private void OnBackpackItemDataHandler(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600173D")]
		[Cpp2IlInjected.Address(RVA = "0x9B2D30", Offset = "0x9B1730", VA = "0x1809B2D30")]
		private void OnItemDeselectHandler(int index)
		{
			//Discarded unreachable code: IL_002f
			//IL_0010: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			List<int> list = (List<int>)(object)new List<T>((int)_listBackpack.SelectedIndexes);
			bool flag = ((List<T>)(object)list).Remove((T)index);
			LoopVerticalScrollRect listBackpack = _listBackpack;
			int[] array2 = (listBackpack.SelectedIndexes = (int[])(object)((List<T>)(object)list).ToArray());
		}

		[Cpp2IlInjected.Token(Token = "0x600173E")]
		[Cpp2IlInjected.Address(RVA = "0x9B2B50", Offset = "0x9B1550", VA = "0x1809B2B50")]
		private void OnItemAmountChangeHandler(InventorySellItem item, int amount)
		{
			//Discarded unreachable code: IL_008d
			//IL_0062: Expected O, but got I4
			Dictionary<int, int> transferSelectedIndexesAndAmount = _transferSelectedIndexesAndAmount;
			if (amount != 0)
			{
				Func<KeyValuePair<int, int>, bool> cpp2il__autoParamName__idx_ = (Func<KeyValuePair<int, int>, bool>)(object)(Func<T, TResult>)delegate(KeyValuePair<int, int> x)
				{
					//Discarded unreachable code: IL_0011
					InventorySellItem inventorySellItem3 = item;
					return (IntPtr)x == (IntPtr)inventorySellItem3.InventoryIndex;
				};
				bool flag = ((IEnumerable<>)transferSelectedIndexesAndAmount).Any<KeyValuePair<int, int>>((Func<, >)(object)cpp2il__autoParamName__idx_);
				Dictionary<int, int> transferSelectedIndexesAndAmount2 = _transferSelectedIndexesAndAmount;
				InventorySellItem inventorySellItem = item;
				if (!flag)
				{
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			int _003CInventoryIndex_003Ek__BackingField = item.InventoryIndex;
			bool flag2 = ((Dictionary<TKey, TValue>)(object)transferSelectedIndexesAndAmount).Remove((TKey)_003CInventoryIndex_003Ek__BackingField);
			InventorySellItem inventorySellItem2 = item;
			LoopVerticalScrollRect listBackpack = _listBackpack;
			int _003CItemIndex_003Ek__BackingField = inventorySellItem2.ItemIndex;
			listBackpack.DeselectIndex(_003CItemIndex_003Ek__BackingField);
			RefreshTransferButtonLabel();
		}

		[Cpp2IlInjected.Token(Token = "0x600173F")]
		[Cpp2IlInjected.Address(RVA = "0x9B21E0", Offset = "0x9B0BE0", VA = "0x1809B21E0")]
		private void OnCancelTransferClickHandler()
		{
			OnCategorySelectHandler();
		}

		[Cpp2IlInjected.Token(Token = "0x6001740")]
		[Cpp2IlInjected.Address(RVA = "0x9B32E0", Offset = "0x9B1CE0", VA = "0x1809B32E0")]
		private void OnTransferClickHandler()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001741")]
		[Cpp2IlInjected.Address(RVA = "0x9B2620", Offset = "0x9B1020", VA = "0x1809B2620", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001742")]
		[Cpp2IlInjected.Address(RVA = "0x9B42A0", Offset = "0x9B2CA0", VA = "0x1809B42A0")]
		private unsafe void SetFocus()
		{
			//Discarded unreachable code: IL_014a, IL_0150, IL_0162
			bool flag = default(bool);
			FilterItem filterItem = default(FilterItem);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					return;
				}
				if (!_mcBackpackContent.gameObject.activeSelf)
				{
					if (!_mcPantryContent.gameObject.activeSelf)
					{
						Filter filter = Enumerable.FirstOrDefault<Filter>((IEnumerable<>)_mcCategorySelector.selectedFilters);
						if (*(Filter*)filter != *(Filter*)num)
						{
							IEnumerator enumerator = _mcCategorySelector.filtersAnchor.GetEnumerator();
							if (enumerator != null)
							{
								int num3 = 0;
								if (enumerator == null)
								{
									break;
								}
								int num4 = 0;
								if (enumerator == null)
								{
									throw new InvalidCastException();
								}
								flag = *(Filter*)filterItem.Filter == *(Filter*)filter;
								if (!flag)
								{
									num++;
								}
							}
							if (!flag)
							{
							}
						}
						if (_mcCategorySelector.filtersAnchor.childCount <= 0)
						{
							return;
						}
						MenuNavigation menuNavigation = base.MenuNavigation;
						Transform child = _mcCategorySelector.filtersAnchor.GetChild(num);
					}
					if (((LoopScrollRect)_listPantry).m_Content.childCount > 0)
					{
						FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
						LoopVerticalScrollRect listPantry = _listPantry;
						int firstVisibleItemIndex = listPantry.GetFirstVisibleItemIndex();
						FocusNavigationElement component = listPantry.GetItemByDataIndex(firstVisibleItemIndex).GetComponent<FocusNavigationElement>();
						focusNavigation.SetFocus(component);
					}
					return;
				}
				if (((LoopScrollRect)_listBackpack).m_Content.childCount > 0)
				{
					MenuNavigation menuNavigation2 = base.MenuNavigation;
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001743")]
		[Cpp2IlInjected.Address(RVA = "0x9B4700", Offset = "0x9B3100", VA = "0x1809B4700")]
		[AsyncStateMachine(typeof(_003CTransferTask_003Ed__44))]
		private Task TransferTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001744")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnExitClickHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001745")]
		[Cpp2IlInjected.Address(RVA = "0x9B1630", Offset = "0x9B0030", VA = "0x1809B1630", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0223
			//IL_005c: Expected O, but got I4
			//IL_0103: Expected O, but got I4
			switch (redirectionType)
			{
			case RedirectionType.GameClickButtonPlus:
			{
				if ((long)base.MenuNavigation.FocusNavigation._focusedElement == 0)
				{
					break;
				}
				ISupportsFocusNavigation focusedElement2 = base.MenuNavigation.FocusNavigation._focusedElement;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				InventorySellItem inventorySellItem2 = default(InventorySellItem);
				if (inventorySellItem2 != (UnityEngine.Object)num6)
				{
					BaseButton btnAdd = inventorySellItem2._btnAdd;
					if (btnAdd._isActive)
					{
						Button buttonComponent2 = btnAdd.ButtonComponent;
						inventorySellItem2._btnAdd?.ButtonComponent.m_OnClick?.Invoke();
					}
				}
				break;
			}
			case RedirectionType.GameClickButtonMinus:
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				if ((object)focusNavigation == null || (long)focusNavigation._focusedElement == 0)
				{
					break;
				}
				ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				InventorySellItem inventorySellItem = default(InventorySellItem);
				if (inventorySellItem != (UnityEngine.Object)num3)
				{
					BaseButton btnSubtract = inventorySellItem._btnSubtract;
					if (btnSubtract._isActive)
					{
						Button buttonComponent = btnSubtract.ButtonComponent;
						inventorySellItem._btnSubtract?.ButtonComponent.m_OnClick?.Invoke();
					}
				}
				break;
			}
			case RedirectionType.MenuNavGoBackward:
			case RedirectionType.GamePromptGoBackward:
				if (!_mcBackpackContent.gameObject.activeSelf && _mcPantryContent.gameObject.activeSelf)
				{
					GameObject gameObject = _btnFilter.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					_tfTitle.StringID = "menu.inventory_categories";
					_mcFilterContent.gameObject.SetActive(value: true);
					GameObject gameObject2 = _mcPantryContent.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
					GameObject gameObject3 = _mcBackpackContent.gameObject;
					int active3 = 0;
					gameObject3.SetActive((byte)active3 != 0);
					SetFocus();
					((List<T>)(object)_mcCategorySelector.selectedFilters).Clear();
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001746")]
		[Cpp2IlInjected.Address(RVA = "0x9B4D30", Offset = "0x9B3730", VA = "0x1809B4D30")]
		public PantryMenu()
		{
		}
	}
}
