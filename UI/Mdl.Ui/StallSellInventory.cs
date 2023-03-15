using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Buildings;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002C6")]
	[RequiredAllNotNull]
	public class StallSellInventory : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000CC5")]
		public SlidingPanel Slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000CC6")]
		[SerializeField]
		private ButtonTmProIcon _btnSell;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000CC7")]
		private List<(Item item, ItemState state, int amount, bool canSell)> listBackpack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000CC8")]
		[SerializeField]
		private LoopVerticalScrollRect _listBackpack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000CC9")]
		[SerializeField]
		private BackpackItemInfo _itemInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000CCA")]
		[SerializeField]
		private ItemAmountSelector _amountSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000CCB")]
		[SerializeField]
		private BackpackActionList _actionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000CCC")]
		[SerializeField]
		private AK.Wwise.Event _sellSuccessSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000CCD")]
		[SerializeField]
		internal AK.Wwise.Event _openSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000CCE")]
		[SerializeField]
		internal GridLayoutGroup _layoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000CCF")]
		[Nulllable]
		public CurrencyContent _currencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000CD0")]
		private Dictionary<int, int> _sellSelectedIndexesAndAmount = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000CD1")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000CD2")]
		private int? _sellCap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000CD3")]
		private ShoppingStall _stall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000CD4")]
		private FocusNavigationElement _focusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000CD5")]
		public Action OnSellComplete;

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		public bool HasOngoingInventoryAction
		{
			[Cpp2IlInjected.Token(Token = "0x600117E")]
			[Cpp2IlInjected.Address(RVA = "0x16030F0", Offset = "0x1601AF0", VA = "0x1816030F0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _amountSelector.gameObject.activeSelf;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA0"), Cpp2IlInjected.Token(Token = "0x4000CD6")]
		public bool IsSelling
		{
			[Cpp2IlInjected.Token(Token = "0x600117F")]
			[Cpp2IlInjected.Address(RVA = "0x1603120", Offset = "0x1601B20", VA = "0x181603120")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001180")]
			[Cpp2IlInjected.Address(RVA = "0x1552740", Offset = "0x1551140", VA = "0x181552740")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001181")]
		[Cpp2IlInjected.Address(RVA = "0x15FFC80", Offset = "0x15FE680", VA = "0x1815FFC80")]
		private void Awake()
		{
			//Discarded unreachable code: IL_008e
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listBackpack).m_OnItemTap;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTapAndHold = ((LoopScrollRect)_listBackpack).m_OnItemTapAndHold;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapAndHoldHandler);
			((UnityEvent<T0>)(object)onItemTapAndHold).AddListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listBackpack).m_OnItemData;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction3);
			Button.ButtonClickedEvent onClick = _btnSell.ButtonComponent.m_OnClick;
			UnityAction call = onSellClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001182")]
		[Cpp2IlInjected.Address(RVA = "0x1600590", Offset = "0x15FEF90", VA = "0x181600590")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_008e
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listBackpack).m_OnItemTap;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTapAndHold = ((LoopScrollRect)_listBackpack).m_OnItemTapAndHold;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapAndHoldHandler);
			((UnityEvent<T0>)(object)onItemTapAndHold).RemoveListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listBackpack).m_OnItemData;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction3);
			Button.ButtonClickedEvent onClick = _btnSell.ButtonComponent.m_OnClick;
			UnityAction call = onSellClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001183")]
		[Cpp2IlInjected.Address(RVA = "0x15FFE70", Offset = "0x15FE870", VA = "0x1815FFE70")]
		public void Init(int? sellCap)
		{
			//Discarded unreachable code: IL_018a
			//IL_0014: Expected O, but got I4
			//IL_017b: Expected O, but got I4
			_sellCap = sellCap;
			if ((object)sellCap != null)
			{
				int num = 0;
				_sellCap = (int?)(object)num;
			}
			Stall _003CCurrentStall_003Ek__BackingField = SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall;
			if ((object)_003CCurrentStall_003Ek__BackingField == null)
			{
			}
			int num2 = 0;
			_stall = (ShoppingStall)_003CCurrentStall_003Ek__BackingField;
			((Dictionary<TKey, TValue>)(object)_sellSelectedIndexesAndAmount).Clear();
			int num3 = 0;
			LoopVerticalScrollRect loopVerticalScrollRect = _listBackpack;
			int[] array2 = (loopVerticalScrollRect.SelectedIndexes = new int[num3]);
			List<(Item, ItemState, int, bool)> list = (listBackpack = (List<(Item item, ItemState state, int amount, bool canSell)>)(object)Enumerable.ToList<(Item, ItemState, int, bool)>(ContainerInventoryExtension.GetItemsToDisplay(SystemRoot.Instance.Client.Profile.Backpack)));
			int num4 = ((List<>)(object)listBackpack)._size;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<UpgradeBackpackItemData, int> func = default(Func<UpgradeBackpackItemData, int>);
			if (_003C_003Ec._003C_003E9__25_0 == null)
			{
				func = (Func<UpgradeBackpackItemData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeBackpackItemData x) => x.backpackExpansionSize_));
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			UpgradeBackpackItemData upgradeBackpackItemData = Enumerable.FirstOrDefault<UpgradeBackpackItemData>((IEnumerable<>)Enumerable.OrderByDescending<UpgradeBackpackItemData, int>(enumerable, (Func<, >)(object)func));
			if (upgradeBackpackItemData != null)
			{
				int backpackExpansionSize_ = upgradeBackpackItemData.backpackExpansionSize_;
				if (backpackExpansionSize_ > num4)
				{
					num4 = backpackExpansionSize_;
				}
			}
			_listBackpack.totalCount = num4;
			LoopVerticalScrollRect loopVerticalScrollRect2 = _listBackpack;
			int offset = 0;
			loopVerticalScrollRect2.RefillCells(offset);
			int num5 = 0;
			Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			AsyncAtlassedIcon currencyIcon = _btnSell._currencyIcon;
			RefreshPrice();
			int num6 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			_itemInfo.Hide();
			GameObject gameObject = _amountSelector.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			CurrencyContent currencyContent = _currencyContent;
			int num7 = 0;
			if (currencyContent != (UnityEngine.Object)num7)
			{
				_currencyContent.Show();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001184")]
		[Cpp2IlInjected.Address(RVA = "0x1603130", Offset = "0x1601B30", VA = "0x181603130")]
		private void onSellClickHandler()
		{
			//Discarded unreachable code: IL_004e
			ButtonTmProIcon btnSell = _btnSell;
			if (IsSelling)
			{
				return;
			}
			Dictionary<int, int> sellSelectedIndexesAndAmount = _sellSelectedIndexesAndAmount;
			Func<KeyValuePair<int, int>, Meta.BackpackItem> _003C_003E9__26_ = _003C_003Ec._003C_003E9__26_0;
			if (_003C_003E9__26_ == null)
			{
				Meta.BackpackItem result = default(Meta.BackpackItem);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, int> x) => result);
			}
			List<Meta.BackpackItem> list = (List<Meta.BackpackItem>)(object)Enumerable.ToList<Meta.BackpackItem>(Enumerable.Select<KeyValuePair<int, int>, Meta.BackpackItem>((IEnumerable<>)sellSelectedIndexesAndAmount, (Func<, >)(object)_003C_003E9__26_));
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001185")]
		[Cpp2IlInjected.Address(RVA = "0x1601BA0", Offset = "0x16005A0", VA = "0x181601BA0")]
		[AsyncStateMachine(typeof(_003CSellTask_003Ed__27))]
		private Task SellTask(List<Meta.BackpackItem> items, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001186")]
		[Cpp2IlInjected.Address(RVA = "0x1601270", Offset = "0x15FFC70", VA = "0x181601270")]
		private void OnItemTapHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001187")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnItemTapAndHoldHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001188")]
		[Cpp2IlInjected.Address(RVA = "0x1601F00", Offset = "0x1600900", VA = "0x181601F00")]
		private void ShowActionList(BackpackSlotInventoryItem inventoryItem)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001189")]
		[Cpp2IlInjected.Address(RVA = "0x1602920", Offset = "0x1601320", VA = "0x181602920")]
		[AsyncStateMachine(typeof(_003CSplitStack_003Ed__31))]
		private Task SplitStack(BackpackSlotInventoryItem inventoryItem, int initialPosition, Item item, int amount, ItemState state, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600118A")]
		[Cpp2IlInjected.Address(RVA = "0x16027E0", Offset = "0x16011E0", VA = "0x1816027E0")]
		[AsyncStateMachine(typeof(_003CSplitSellStack_003Ed__32))]
		private Task SplitSellStack(BackpackSlotInventoryItem inventoryItem, int initialPosition, Item item, int amount, ItemState state, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600118B")]
		[Cpp2IlInjected.Address(RVA = "0x1602390", Offset = "0x1600D90", VA = "0x181602390")]
		private Task<int?> ShowAmountSelector(BackpackSlotInventoryItem item, int amount)
		{
			//Discarded unreachable code: IL_00a8
			//IL_004e: Expected I4, but got I8
			//IL_004e: Expected I4, but got I8
			//IL_004e: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			TaskCompletionSource<int?> taskCompletionSource = (TaskCompletionSource<int?>)(object)new TaskCompletionSource<TResult>();
			ItemAmountSelector amountSelector = _amountSelector;
			string _003CIconTexture_003Ek__BackingField = ((BackpackInventoryItem)item).IconTexture;
			int num = 0;
			Action<int?> action = (Action<int?>)(object)(Action<T>)delegate(int? result)
			{
				//Discarded unreachable code: IL_0039
				bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)result);
				ToogleSellItemsInteractable(interactable: true);
				int num7 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
					SetFocus();
				}
			};
			int num2 = 0;
			ulong num3 = default(ulong);
			ulong num4 = default(ulong);
			amountSelector.Init(_003CIconTexture_003Ek__BackingField, amount, num2, (Nullable<>)num, (Action<>)(object)action, (byte)num3 != 0, (byte)num4 != 0);
			_amountSelector.gameObject.SetActive(value: true);
			int num5 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				if (GetComponentInParent<MenuNavigation>().FocusNavigation._focusedElement != null)
				{
					int num6 = 0;
				}
				_focusedElement = (FocusNavigationElement)num;
				SetFocus();
			}
			return (Task<int?>)(object)((TaskCompletionSource<>)(object)taskCompletionSource).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x600118C")]
		[Cpp2IlInjected.Address(RVA = "0x1600780", Offset = "0x15FF180", VA = "0x181600780")]
		private void OnItemDataHandler(ListEventData arg0)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600118D")]
		[Cpp2IlInjected.Address(RVA = "0x1601160", Offset = "0x15FFB60", VA = "0x181601160")]
		private void OnItemSelect((Item item, ItemState state, int amount, bool canSell) backpackItem, bool select, int stars)
		{
			if (!_amountSelector.gameObject.activeSelf && !_actionList.gameObject.activeSelf)
			{
				if (select)
				{
					BackpackItemInfo itemInfo = _itemInfo;
					throw new NullReferenceException();
				}
				ShowSelectedItemInfo();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600118E")]
		[Cpp2IlInjected.Address(RVA = "0x1602650", Offset = "0x1601050", VA = "0x181602650")]
		private unsafe void ShowSelectedItemInfo()
		{
			//Discarded unreachable code: IL_006f
			//IL_003d: Expected I4, but got O
			//IL_0063: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			_itemInfo.Hide();
			if (Enumerable.Any<KeyValuePair<int, int>>((IEnumerable<>)_sellSelectedIndexesAndAmount))
			{
				KeyValuePair<int, int> keyValuePair = ((IEnumerable<>)_sellSelectedIndexesAndAmount).Last<KeyValuePair<int, int>>();
				Transform transform = ((LoopScrollRect)_listBackpack).m_Content.transform;
				int index = (int)((KeyValuePair<, >*)(&keyValuePair))->key;
				Transform child = transform.GetChild(index);
				if ((object)child != null)
				{
					BackpackSlotInventoryItem component = child.GetComponent<BackpackSlotInventoryItem>();
				}
				int num = 0;
				int num2 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
				{
					BackpackItemInfo itemInfo = _itemInfo;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600118F")]
		[Cpp2IlInjected.Address(RVA = "0x1601770", Offset = "0x1600170", VA = "0x181601770")]
		private void RefreshPrice()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001190")]
		[Cpp2IlInjected.Address(RVA = "0x1601CD0", Offset = "0x16006D0", VA = "0x181601CD0")]
		internal void SetFocus()
		{
			//Discarded unreachable code: IL_00a2
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			MenuNavigation componentInParent = GetComponentInParent<MenuNavigation>();
			int num = 0;
			if (componentInParent == (UnityEngine.Object)num)
			{
				return;
			}
			FocusNavigation focusNavigation = componentInParent.FocusNavigation;
			int num2 = 0;
			if (focusNavigation == (UnityEngine.Object)num2)
			{
				return;
			}
			if (!_amountSelector.gameObject.activeSelf)
			{
				LoopVerticalScrollRect loopVerticalScrollRect = _listBackpack;
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					bool flag = default(bool);
					if (flag)
					{
					}
					LoopVerticalScrollRect loopVerticalScrollRect2 = _listBackpack;
					int firstVisibleItemIndex = loopVerticalScrollRect2.GetFirstVisibleItemIndex();
					FocusNavigationElement focus = (_focusedElement = loopVerticalScrollRect2.GetItemByDataIndex(firstVisibleItemIndex).GetComponent<FocusNavigationElement>());
					componentInParent.FocusNavigation.SetFocus(focus);
				}
			}
			else
			{
				FocusNavigation focusNavigation2 = componentInParent.FocusNavigation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001191")]
		[Cpp2IlInjected.Address(RVA = "0x1600530", Offset = "0x15FEF30", VA = "0x181600530")]
		public void OnCloseAmountSelector()
		{
			//Discarded unreachable code: IL_0029
			ToogleSellItemsInteractable(interactable: true);
			GameObject gameObject = _amountSelector.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			ShowSelectedItemInfo();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001192")]
		[Cpp2IlInjected.Address(RVA = "0x1602A60", Offset = "0x1601460", VA = "0x181602A60")]
		private void ToogleSellItemsInteractable(bool interactable)
		{
			//Discarded unreachable code: IL_00cc
			//IL_008d: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			List<(Item, ItemState, int, bool)> list = listBackpack;
			int num = 0;
			int num2 = 0;
			Transform child = ((LoopScrollRect)_listBackpack).m_Content.transform.GetChild(num);
			if ((object)child != null)
			{
				ButtonWithHold component = child.GetComponent<ButtonWithHold>();
			}
			int num3 = 0;
			Transform child2 = ((LoopScrollRect)_listBackpack).m_Content.transform.GetChild(num);
			if ((object)child2 != null)
			{
				BaseButton component2 = child2.GetComponent<BaseButton>();
			}
			int num4 = 0;
			Transform child3 = ((LoopScrollRect)_listBackpack).m_Content.transform.GetChild(num);
			if ((object)child3 != null)
			{
				BackpackSlotInventoryItem component3 = child3.GetComponent<BackpackSlotInventoryItem>();
			}
			int num5 = 0;
			num2 = num5;
			if ((bool)(UnityEngine.Object)num5)
			{
				if (interactable)
				{
					int num6 = 0;
				}
				num2 = num5;
				num2 = num5;
			}
			num2 = num3;
			if ((bool)(UnityEngine.Object)num3)
			{
				num2 = num3;
			}
			num2 = num4;
			if ((bool)(UnityEngine.Object)num4)
			{
				num2 = num4;
			}
			List<(Item, ItemState, int, bool)> list2 = listBackpack;
			num++;
			num2 = num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001193")]
		[Cpp2IlInjected.Address(RVA = "0x1602D80", Offset = "0x1601780", VA = "0x181602D80")]
		private void Update()
		{
			//Discarded unreachable code: IL_008d
			if (_amountSelector.gameObject.activeSelf && Input.GetMouseButtonDown(0))
			{
				Transform transform = _amountSelector.transform;
				int num = 0;
				if ((object)transform != null)
				{
				}
				int num2 = 0;
				Vector2 mousePosition = Input.mousePosition;
				bool flag = default(bool);
				if (!flag)
				{
					ShowSelectedItemInfo();
				}
			}
			if (_actionList.gameObject.activeSelf && Input.GetMouseButtonDown(0))
			{
				RectTransform background = _actionList._background;
				int num3 = 0;
				Vector2 mousePosition2 = Input.mousePosition;
				RectTransform background2 = _actionList._background;
				bool flag2 = default(bool);
				if (!flag2)
				{
					ShowSelectedItemInfo();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001194")]
		[Cpp2IlInjected.Address(RVA = "0x1603070", Offset = "0x1601A70", VA = "0x181603070")]
		public StallSellInventory()
		{
		}
	}
}
