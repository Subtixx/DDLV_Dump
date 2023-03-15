using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005D1")]
	public abstract class InventoryContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002052")]
		public SlidingPanel SlidingPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002053")]
		[SerializeField]
		[Nulllable]
		protected InventoryDragAndDrop _inventoryDragAndDrop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002054")]
		[SerializeField]
		protected GridLayoutGroup _gridLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002055")]
		[SerializeField]
		[FormerlySerializedAs("_menuNavigation")]
		public MenuNavigation MenuNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002056")]
		[SerializeField]
		[FormerlySerializedAs("_listBackpack")]
		[FormerlySerializedAs("_listStorage")]
		protected LoopScrollRect _list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002057")]
		[SerializeField]
		protected BackpackItemInfo _itemInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002058")]
		public BackpackActionList ItemActionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002059")]
		public ItemAmountSelector ItemAmountSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400205A")]
		public InventorySortPanel InventorySortPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400205C")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400205D")]
		public Func<int, Task> TransferItemSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400205E")]
		protected Storage _storage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400205F")]
		protected Task activeTransfer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002060")]
		protected int _focusedSlotId = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002061")]
		protected FocusNavigationElement _focusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002062")]
		private int _selectedSlotId = -1;

		[Cpp2IlInjected.Token(Token = "0x170005D4")]
		public bool HasOngoingInventoryAction
		{
			[Cpp2IlInjected.Token(Token = "0x6002608")]
			[Cpp2IlInjected.Address(RVA = "0xD29FB0", Offset = "0xD289B0", VA = "0x180D29FB0")]
			get
			{
				//Discarded unreachable code: IL_004b
				//IL_0036: Expected O, but got I4
				if (!ItemActionList.gameObject.activeSelf && !ItemAmountSelector.gameObject.activeSelf)
				{
					InventorySortPanel inventorySortPanel = InventorySortPanel;
					int num = 0;
					bool flag = inventorySortPanel != (UnityEngine.Object)num;
					if (!flag)
					{
						return flag;
					}
					return InventorySortPanel.IsOpen;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D5")]
		public bool StorageOrBackpackHaveOngoingInventoryAction
		{
			[Cpp2IlInjected.Token(Token = "0x6002609")]
			[Cpp2IlInjected.Address(RVA = "0xD2A090", Offset = "0xD28A90", VA = "0x180D2A090")]
			get
			{
				//Discarded unreachable code: IL_003e
				//IL_001b: Expected O, but got I4
				int num = 0;
				StorageMenu menu = UiRoot.Instance._menuStack.GetMenu<StorageMenu>();
				int num2 = 0;
				if (!(menu != (UnityEngine.Object)num2))
				{
					return HasOngoingInventoryAction;
				}
				BackpackContent backpackContent = menu.BackpackContent;
				if (backpackContent.HasOngoingInventoryAction)
				{
					return true;
				}
				return backpackContent.HasOngoingInventoryAction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D6")]
		public ProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x600260A")]
			[Cpp2IlInjected.Address(RVA = "0xD29EF0", Offset = "0xD288F0", VA = "0x180D29EF0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
					if (metaClient != null)
					{
						return metaClient.Dispatcher;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x400205B")]
		public bool DoneWithSlotInstance
		{
			[Cpp2IlInjected.Token(Token = "0x600260B")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600260C")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			protected set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005D8")]
		protected FocusNavigationElement FocusedElement
		{
			[Cpp2IlInjected.Token(Token = "0x600260F")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return _focusedElement;
			}
			[Cpp2IlInjected.Token(Token = "0x6002610")]
			[Cpp2IlInjected.Address(RVA = "0xD2A190", Offset = "0xD28B90", VA = "0x180D2A190")]
			set
			{
				//Discarded unreachable code: IL_0075
				//IL_0033: Expected O, but got I4
				//IL_004a: Expected O, but got I4
				//IL_0069: Expected O, but got I4
				//IL_0069: Expected O, but got I4
				//IL_0074: Expected O, but got I4
				FocusNavigationElement focusedElement = _focusedElement;
				if (!(value != focusedElement))
				{
					return;
				}
				_focusedElement = value;
				int num = 0;
				StorageMenu menu = UiRoot.Instance._menuStack.GetMenu<StorageMenu>();
				int num2 = 0;
				if (menu != (UnityEngine.Object)num2)
				{
					FocusNavigationElement focusedElement2 = _focusedElement;
					int num3 = 0;
					if (focusedElement2 != (UnityEngine.Object)num3)
					{
						InventoryContent componentInParent = _focusedElement.GetComponentInParent<InventoryContent>();
					}
					int num4 = 0;
					int num5 = 0;
					if ((UnityEngine.Object)num4 != (UnityEngine.Object)num5)
					{
						menu.InventoryContentWithFocusedElement = (InventoryContent)num4;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D9")]
		public int SelectedSlotId
		{
			[Cpp2IlInjected.Token(Token = "0x6002618")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get
			{
				return _selectedSlotId;
			}
			[Cpp2IlInjected.Token(Token = "0x6002619")]
			[Cpp2IlInjected.Address(RVA = "0xD2A340", Offset = "0xD28D40", VA = "0x180D2A340")]
			set
			{
				_selectedSlotId = value;
				int ignoreSelected = 0;
				RefreshAllSelectedState((byte)ignoreSelected != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600260D")]
		[Cpp2IlInjected.Address(RVA = "0xD27F00", Offset = "0xD26900", VA = "0x180D27F00", Slot = "4")]
		protected virtual void Awake()
		{
			//Discarded unreachable code: IL_011d
			//IL_00b3: Expected O, but got I4
			//IL_00dc: Expected O, but got I4
			UnityAction<ListEventData> unityAction = default(UnityAction<ListEventData>);
			((UnityEvent<T0>)(object)_list.m_OnItemData).AddListener((UnityAction<>)(object)unityAction);
			UnityAction<ListEventData> unityAction2 = default(UnityAction<ListEventData>);
			((UnityEvent<T0>)(object)_list.m_OnItemTap).AddListener((UnityAction<>)(object)unityAction2);
			UnityAction<ListEventData> unityAction3 = default(UnityAction<ListEventData>);
			((UnityEvent<T0>)(object)_list.m_OnItemRightClick).AddListener((UnityAction<>)(object)unityAction3);
			UnityAction call = default(UnityAction);
			ItemActionList.OnListActionDisabled.AddListener(call);
			ProfileEventDispatcher.ItemAdded value = default(ProfileEventDispatcher.ItemAdded);
			Dispatcher.OnItemAdded += value;
			ProfileEventDispatcher.ItemRemoved value2 = default(ProfileEventDispatcher.ItemRemoved);
			Dispatcher.OnItemRemoved += value2;
			ProfileEventDispatcher.ItemMoved value3 = default(ProfileEventDispatcher.ItemMoved);
			Dispatcher.OnItemMoved += value3;
			ProfileEventDispatcher.InventorySorted value4 = default(ProfileEventDispatcher.InventorySorted);
			Dispatcher.OnInventorySorted += value4;
			ProfileEventDispatcher.KeyholeItemAdded value5 = default(ProfileEventDispatcher.KeyholeItemAdded);
			Dispatcher.OnKeyholeItemAdded += value5;
			ProfileEventDispatcher.KeyholeItemRemoved value6 = default(ProfileEventDispatcher.KeyholeItemRemoved);
			Dispatcher.OnKeyholeItemRemoved += value6;
			ProfileEventDispatcher.KeyholeItemMoved value7 = default(ProfileEventDispatcher.KeyholeItemMoved);
			Dispatcher.OnKeyholeItemMoved += value7;
			MenuNavigation menuNavigation = MenuNavigation;
			int num = 0;
			if (menuNavigation != (UnityEngine.Object)num)
			{
				FocusNavigation.FocusChanged value8 = default(FocusNavigation.FocusChanged);
				MenuNavigation.FocusNavigation.OnFocusChanged += value8;
			}
			InventorySortPanel inventorySortPanel = InventorySortPanel;
			int num2 = 0;
			if (inventorySortPanel != (UnityEngine.Object)num2)
			{
				InventorySortPanel inventorySortPanel2 = InventorySortPanel;
				Action onClosed = inventorySortPanel2.OnClosed;
				Action b = OnCloseSortPanel;
				Delegate @delegate = Delegate.Combine(onClosed, b);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				inventorySortPanel2.OnClosed = (Action)@delegate;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600260E")]
		[Cpp2IlInjected.Address(RVA = "0xD28980", Offset = "0xD27380", VA = "0x180D28980", Slot = "5")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_012f
			//IL_0010: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			MenuNavigation menuNavigation = MenuNavigation;
			int num = 0;
			if (menuNavigation != (UnityEngine.Object)num)
			{
				FocusNavigation.FocusChanged value = default(FocusNavigation.FocusChanged);
				MenuNavigation.FocusNavigation.OnFocusChanged -= value;
			}
			UnityAction<ListEventData> unityAction = default(UnityAction<ListEventData>);
			((UnityEvent<T0>)(object)_list.m_OnItemData).RemoveListener((UnityAction<>)(object)unityAction);
			UnityAction<ListEventData> unityAction2 = default(UnityAction<ListEventData>);
			((UnityEvent<T0>)(object)_list.m_OnItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
			UnityAction<ListEventData> unityAction3 = default(UnityAction<ListEventData>);
			((UnityEvent<T0>)(object)_list.m_OnItemRightClick).RemoveListener((UnityAction<>)(object)unityAction3);
			UnityAction call = default(UnityAction);
			ItemActionList.OnListActionDisabled.RemoveListener(call);
			if (Dispatcher != null)
			{
				ProfileEventDispatcher.ItemAdded value2 = default(ProfileEventDispatcher.ItemAdded);
				Dispatcher.OnItemAdded -= value2;
				ProfileEventDispatcher.ItemRemoved value3 = default(ProfileEventDispatcher.ItemRemoved);
				Dispatcher.OnItemRemoved -= value3;
				ProfileEventDispatcher.ItemMoved value4 = default(ProfileEventDispatcher.ItemMoved);
				Dispatcher.OnItemMoved -= value4;
				ProfileEventDispatcher.KeyholeItemAdded value5 = default(ProfileEventDispatcher.KeyholeItemAdded);
				Dispatcher.OnKeyholeItemAdded -= value5;
				ProfileEventDispatcher.KeyholeItemRemoved value6 = default(ProfileEventDispatcher.KeyholeItemRemoved);
				Dispatcher.OnKeyholeItemRemoved -= value6;
				ProfileEventDispatcher.KeyholeItemMoved value7 = default(ProfileEventDispatcher.KeyholeItemMoved);
				Dispatcher.OnKeyholeItemMoved -= value7;
				ProfileEventDispatcher.InventorySorted value8 = default(ProfileEventDispatcher.InventorySorted);
				Dispatcher.OnInventorySorted -= value8;
			}
			InventorySortPanel inventorySortPanel = InventorySortPanel;
			int num2 = 0;
			if (inventorySortPanel != (UnityEngine.Object)num2)
			{
				InventorySortPanel inventorySortPanel2 = InventorySortPanel;
				Action onClosed = inventorySortPanel2.OnClosed;
				Action value9 = OnCloseSortPanel;
				Delegate @delegate = Delegate.Remove(onClosed, value9);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				inventorySortPanel2.OnClosed = (Action)@delegate;
			}
			_list.ClearCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6002611")]
		[Cpp2IlInjected.Address(RVA = "0xD28F40", Offset = "0xD27940", VA = "0x180D28F40", Slot = "6")]
		protected virtual void OnFocusChanged(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_0083
			//IL_004c: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			ISupportsFocusNavigation focusedElement = MenuNavigation.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
				return;
			}
			int num = 0;
			bool flag = default(bool);
			if (focusedElement == null || !flag)
			{
				return;
			}
			Transform transform = default(Transform);
			Transform parent = transform.parent;
			RectTransform content = _list.m_Content;
			if (!(parent == content))
			{
				return;
			}
			int num2 = 0;
			BackpackSlotInventoryItem backpackSlotInventoryItem = default(BackpackSlotInventoryItem);
			if (backpackSlotInventoryItem != (UnityEngine.Object)num2)
			{
				BackpackItemInfo itemInfo = _itemInfo;
				int num3 = 0;
				if (itemInfo != (UnityEngine.Object)num3)
				{
					_itemInfo.Hide();
				}
				int num4 = (_focusedSlotId = ((BackpackInventoryItem)backpackSlotInventoryItem).ItemIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002612")]
		[Cpp2IlInjected.Address(RVA = "0xD29B70", Offset = "0xD28570", VA = "0x180D29B70")]
		public void SetFocus(bool checkStorageMenu = true)
		{
			//Discarded unreachable code: IL_003a
			//IL_001f: Expected O, but got I4
			InventoryContent focusedInventoryContent = default(InventoryContent);
			if (checkStorageMenu)
			{
				int num = 0;
				StorageMenu menu = UiRoot.Instance._menuStack.GetMenu<StorageMenu>();
				int num2 = 0;
				if (menu != (UnityEngine.Object)num2)
				{
					focusedInventoryContent = menu.FocusedInventoryContent;
					if (!(focusedInventoryContent != this))
					{
					}
				}
			}
			focusedInventoryContent.DoSetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6002613")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void DoSetFocus();

		[Cpp2IlInjected.Token(Token = "0x6002614")]
		[Cpp2IlInjected.Address(RVA = "0xD29970", Offset = "0xD28370", VA = "0x180D29970")]
		protected void RefreshFocusedItem([System.Runtime.InteropServices.Optional] FocusNavigationElement focusElement)
		{
			//Discarded unreachable code: IL_00ad
			//IL_0036: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			int num2 = 0;
			StorageMenu menu = UiRoot.Instance._menuStack.GetMenu<StorageMenu>();
			int num3 = 0;
			if (menu != (UnityEngine.Object)num3 && menu.InventoryContentWithFocusedElement != this)
			{
				InventoryContent inventoryContentWithFocusedElement = menu.InventoryContentWithFocusedElement;
				int num4 = 0;
				if (inventoryContentWithFocusedElement != (UnityEngine.Object)num4)
				{
					return;
				}
			}
			int num5 = 0;
			FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
			if (focusElement == (UnityEngine.Object)num5)
			{
				focusNavigationElement = FindBestFocusElement();
			}
			int num6 = 0;
			if (focusNavigationElement != (UnityEngine.Object)num6)
			{
				FocusedElement = focusNavigationElement;
				FocusNavigation focusNavigation = MenuNavigation.FocusNavigation;
				FocusNavigationElement focusedElement = _focusedElement;
				focusNavigation.SetFocus(focusedElement);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002615")]
		[Cpp2IlInjected.Address(RVA = "0xD29DF0", Offset = "0xD287F0", VA = "0x180D29DF0")]
		protected bool SlotBelongsToThis(FocusNavigationElement focusElement)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (focusElement != (UnityEngine.Object)num)
			{
				Transform parent = focusElement.transform.parent;
				RectTransform content = _list.m_Content;
				return parent == content;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002616")]
		[Cpp2IlInjected.Address(RVA = "0xD28530", Offset = "0xD26F30", VA = "0x180D28530")]
		protected FocusNavigationElement FindBestFocusElement()
		{
			//Discarded unreachable code: IL_0121
			//IL_0012: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_00d2: Expected O, but got I4
			//IL_0114: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			FocusNavigationElement component = default(FocusNavigationElement);
			FocusNavigationElement component2 = default(FocusNavigationElement);
			while (true)
			{
				int num = 0;
				FocusNavigationElement focusedElement = _focusedElement;
				int num2 = 0;
				if (!(focusedElement != (UnityEngine.Object)num2) || _focusedElement.isActiveAndEnabled)
				{
				}
				MenuNavigation menuNavigation = MenuNavigation;
				int num3 = 0;
				if (menuNavigation != (UnityEngine.Object)num3)
				{
					FocusNavigation focusNavigation = MenuNavigation.FocusNavigation;
					int num4 = 0;
					if (focusNavigation != (UnityEngine.Object)num4)
					{
						if (MenuNavigation.FocusNavigation._focusedElement == null)
						{
						}
						int num5 = 0;
						if (flag && !flag2)
						{
						}
					}
				}
				if (!flag3 || !flag4)
				{
					int focusedSlotId = _focusedSlotId;
					int childCount = _list.m_Content.childCount;
					if (focusedSlotId < childCount)
					{
						RectTransform content = _list.m_Content;
						int focusedSlotId2 = _focusedSlotId;
						component = content.GetChild(focusedSlotId2).GetComponent<FocusNavigationElement>();
					}
					int num6 = 0;
					if (component == (UnityEngine.Object)num6 && _list.m_Content.childCount > 0)
					{
						RectTransform content2 = _list.m_Content;
						int index = 0;
						component2 = content2.GetChild(index).GetComponent<FocusNavigationElement>();
					}
					int num7 = 0;
					if (component2 == (UnityEngine.Object)num7)
					{
						break;
					}
				}
			}
			return GetComponentInChildren<FocusNavigationElement>();
		}

		[Cpp2IlInjected.Token(Token = "0x6002617")]
		[Cpp2IlInjected.Address(RVA = "0xD28490", Offset = "0xD26E90", VA = "0x180D28490")]
		public void ClearFocusedElement()
		{
			//Discarded unreachable code: IL_0027
			//IL_0009: Expected O, but got I4
			int num = 0;
			FocusedElement = (FocusNavigationElement)num;
			LoopScrollRect list = _list;
			int num2 = (list.SelectedIndex = LoopScrollRect.INVALID_INDEX);
			int ignoreSelected = 0;
			RefreshAllSelectedState((byte)ignoreSelected != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600261A")]
		[Cpp2IlInjected.Address(RVA = "0xD29700", Offset = "0xD28100", VA = "0x180D29700")]
		public void RefreshAllSelectedState(bool ignoreSelected = false)
		{
			//Discarded unreachable code: IL_00ef
			//IL_0021: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			if (_selectedSlotId == -1)
			{
				return;
			}
			RectTransform content = _list.m_Content;
			int num = 0;
			if (!(content != (UnityEngine.Object)num) || _list.m_Content.childCount <= 0)
			{
				return;
			}
			LoopScrollRect list = _list;
			int num2 = 0;
			int num3 = 0;
			if (num3 >= list.totalCount)
			{
				return;
			}
			num3 = num2;
			Transform itemByDataIndex = list.GetItemByDataIndex(num2);
			int num4 = 0;
			if (!(itemByDataIndex == (UnityEngine.Object)num4))
			{
				BackpackSlotInventoryItem component = itemByDataIndex.GetComponent<BackpackSlotInventoryItem>();
				int num5 = 0;
				if (component != (UnityEngine.Object)num5)
				{
					if (num2 == _selectedSlotId && !ignoreSelected)
					{
						bool isEmpty = component.IsEmpty;
					}
					int num6 = 0;
					num3 = num6;
					component.SetSelectedOutline((byte)num6 != 0);
					BaseButton component2 = component.GetComponent<BaseButton>();
					int num7 = 0;
					if (component2 != (UnityEngine.Object)num7)
					{
						component2.IgnoreHighlightExit = false;
					}
					if (num2 != _selectedSlotId)
					{
						component.RemoveHighlight();
					}
				}
			}
			LoopScrollRect list2 = _list;
			num2++;
			num3 = num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600261B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void OnItemDataHandler(ListEventData arg);

		[Cpp2IlInjected.Token(Token = "0x600261C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void OnItemTapHandler(ListEventData arg);

		[Cpp2IlInjected.Token(Token = "0x600261D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void OnItemRightClickHandler(ListEventData arg);

		[Cpp2IlInjected.Token(Token = "0x600261E")]
		[Cpp2IlInjected.Address(RVA = "0xD29210", Offset = "0xD27C10", VA = "0x180D29210", Slot = "11")]
		protected virtual void OnListActionDisabled()
		{
			//Discarded unreachable code: IL_005b
			//IL_004b: Expected O, but got I4
			ItemActionList.ResetButtonClickedOn();
			if (!ItemAmountSelector.gameObject.activeSelf)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				BackpackItemInfo itemInfo = _itemInfo;
				int num2 = 0;
				if (itemInfo != (UnityEngine.Object)num2)
				{
					_itemInfo.Hide();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600261F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OnKeyholeChanged(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount);

		[Cpp2IlInjected.Token(Token = "0x6002620")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract void OnKeyholeItemMoved(Keyhole keyhole);

		[Cpp2IlInjected.Token(Token = "0x6002621")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail);

		[Cpp2IlInjected.Token(Token = "0x6002622")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract void OnItemRemoved(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason = InvActionType.None);

		[Cpp2IlInjected.Token(Token = "0x6002623")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract void OnItemMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action);

		[Cpp2IlInjected.Token(Token = "0x6002624")]
		[Cpp2IlInjected.Address(RVA = "0xD29180", Offset = "0xD27B80", VA = "0x180D29180", Slot = "17")]
		protected virtual void OnInventorySorted(ContainerInventory containerInventory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002625")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract void OnInventoryChanged(IInventory inventory, Item item, int amount, bool moved = false, [System.Runtime.InteropServices.Optional] int[] indexes);

		[Cpp2IlInjected.Token(Token = "0x6002626")]
		[Cpp2IlInjected.Address(RVA = "0xD28930", Offset = "0xD27330", VA = "0x180D28930")]
		public void OnCloseSortPanel()
		{
			//Discarded unreachable code: IL_001d
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002627")]
		[Cpp2IlInjected.Address(RVA = "0xD29300", Offset = "0xD27D00", VA = "0x180D29300")]
		public void OnShowSortPanel()
		{
			//IL_0010: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			uint iD_2 = default(uint);
			Client client = default(Client);
			while (true)
			{
				InventorySortPanel inventorySortPanel = InventorySortPanel;
				int num = 0;
				if (inventorySortPanel != (UnityEngine.Object)num)
				{
					InventorySortPanel inventorySortPanel2 = InventorySortPanel;
					if (inventorySortPanel2.IsOpen)
					{
						inventorySortPanel2.Close();
						return;
					}
				}
				int num2 = 0;
				StorageMenu menu = UiRoot.Instance._menuStack.GetMenu<StorageMenu>();
				int num3 = 0;
				if (!(menu != (UnityEngine.Object)num3))
				{
				}
				if (menu.BackpackContent.HasOngoingInventoryAction || menu.StorageContent.HasOngoingInventoryAction)
				{
					continue;
				}
				Storage storage = _storage;
				int num4 = 0;
				if ((object)storage != null)
				{
					ContainerInventory containerInventory = storage._containerInventory;
					if (containerInventory != null)
					{
						uint iD_ = containerInventory.iD_;
					}
				}
				if (num4 == 0)
				{
					iD_2 = client.profile.player_.Backpack.iD_;
				}
				InventorySortPanel inventorySortPanel3 = InventorySortPanel;
				int num5 = 0;
				if (inventorySortPanel3 != (UnityEngine.Object)num5)
				{
					InventorySortPanel inventorySortPanel4 = InventorySortPanel;
					if (inventorySortPanel4.enabled && !inventorySortPanel4.IsOpen)
					{
						inventorySortPanel4.gameObject.SetActive(value: true);
						inventorySortPanel4._storageID = iD_2;
					}
				}
				if (MenuNavigation.FocusNavigation._focusedElement != null)
				{
					int num6 = 0;
				}
				int num7 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					break;
				}
			}
			SetFocus();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002628")]
		[Cpp2IlInjected.Address(RVA = "0xD29680", Offset = "0xD28080", VA = "0x180D29680")]
		public void OnStartDrag()
		{
			//Discarded unreachable code: IL_001c
			_list.RefreshCells();
			LoopScrollRect list = _list;
			int num = ((list.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002629")]
		[Cpp2IlInjected.Address(RVA = "0xD296C0", Offset = "0xD280C0", VA = "0x180D296C0")]
		public void OnStopDrag()
		{
			//Discarded unreachable code: IL_0018
			_list.enabled = true;
			_list.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x600262A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "19")]
		public virtual void OnDropFailed()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600262B")]
		[Cpp2IlInjected.Address(RVA = "0xD288B0", Offset = "0xD272B0", VA = "0x180D288B0")]
		public Transform GetFirstSlot()
		{
			//IL_0018: Expected F4, but got I4
			int firstVisibleItemIndex = _list.GetFirstVisibleItemIndex();
			Vector2 vector = _list.GetVector((float)firstVisibleItemIndex);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600262C")]
		[Cpp2IlInjected.Address(RVA = "0xD288F0", Offset = "0xD272F0", VA = "0x180D288F0")]
		public int GetIndexOf(BackpackSlotInventoryItem slot)
		{
			//Discarded unreachable code: IL_0016
			LoopScrollRect list = _list;
			Transform child = slot.transform;
			return list.GetIndexOf(child);
		}

		[Cpp2IlInjected.Token(Token = "0x600262D")]
		[Cpp2IlInjected.Address(RVA = "0xD29C90", Offset = "0xD28690", VA = "0x180D29C90", Slot = "20")]
		protected virtual void SetupSlotNavigationElement()
		{
			//Discarded unreachable code: IL_006c
			//IL_0063: Expected I4, but got I8
			RectTransform component = MenuNavigation.GetComponent<RectTransform>();
			LoopScrollRect list = _list;
			int num = 0;
			if (num < list.totalCount)
			{
				FocusNavigationElement component2 = list.GetItemByDataIndex(num).GetComponent<FocusNavigationElement>();
				GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)(component2.LayoutGroup = _gridLayout);
				component2.FreeContainer = component;
				BackpackSlotInventoryItem component3 = _list.GetItemByDataIndex(num).GetComponent<BackpackSlotInventoryItem>();
				num++;
				component3.AssociatedMenu = BackpackSlotInventoryItem.AssociatedMenuEnum.Storage;
				LoopScrollRect list2 = _list;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600262E")]
		[Cpp2IlInjected.Address(RVA = "0xD29ED0", Offset = "0xD288D0", VA = "0x180D29ED0")]
		protected InventoryContent()
		{
		}//IL_0010: Expected I4, but got I8
		//IL_0020: Expected I4, but got I8

	}
}
