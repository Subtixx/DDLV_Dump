using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005E1")]
	public class StorageContent : InventoryContent
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40020B6")]
		[SerializeField]
		private string _axisNameX = "Left Stick X";

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40020B7")]
		[SerializeField]
		private string _axisNameY = "Left Stick Y";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40020B8")]
		[SerializeField]
		[NotNull]
		private ShortcutDefinition _shortcutHoldKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40020B9")]
		[SerializeField]
		private RectTransform _upgradeHouseMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40020BA")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40020BB")]
		[Header("Audio")]
		public AK.Wwise.Event splitOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40020BC")]
		public AK.Wwise.Event transferOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40020BD")]
		public AK.Wwise.Event itemOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40020BE")]
		private List<(Item item, ItemState state, int amount, bool canSell)> _storageItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40020BF")]
		private Coroutine waitFrame;

		[Cpp2IlInjected.Token(Token = "0x170005E6")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60026AD")]
			[Cpp2IlInjected.Address(RVA = "0x867330", Offset = "0x865D30", VA = "0x180867330")]
			set
			{
				//Discarded unreachable code: IL_000d
				_title.StringID = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026AE")]
		[Cpp2IlInjected.Address(RVA = "0x864A80", Offset = "0x863480", VA = "0x180864A80", Slot = "5")]
		protected override void OnDestroy()
		{
			base.OnDestroy();
			Coroutine coroutine = waitFrame;
			if (coroutine != null)
			{
				StopCoroutine(coroutine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026AF")]
		[Cpp2IlInjected.Address(RVA = "0x866150", Offset = "0x864B50", VA = "0x180866150", Slot = "12")]
		protected override void OnKeyholeChanged(Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60026B0")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x864BA0", VA = "0x1808661A0", Slot = "13")]
		protected override void OnKeyholeItemMoved(Keyhole keyhole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60026B1")]
		[Cpp2IlInjected.Address(RVA = "0x865060", Offset = "0x863A60", VA = "0x180865060", Slot = "14")]
		protected override void OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60026B2")]
		[Cpp2IlInjected.Address(RVA = "0x865060", Offset = "0x863A60", VA = "0x180865060", Slot = "15")]
		protected override void OnItemRemoved(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60026B3")]
		[Cpp2IlInjected.Address(RVA = "0x8659B0", Offset = "0x8643B0", VA = "0x1808659B0", Slot = "16")]
		protected override void OnItemMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action)
		{
			ContainerInventory containerInventory = _storage._containerInventory;
			int num = 0;
			bool flag = source == containerInventory;
			if (destination == containerInventory != flag)
			{
				OnInventoryChanged(containerInventory, moved: true, sourcePosition);
				Storage storage = _storage;
			}
			if (source != containerInventory)
			{
				if (destination == containerInventory)
				{
					ContainerInventory containerInventory2 = _storage._containerInventory;
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026B4")]
		[Cpp2IlInjected.Address(RVA = "0x864AC0", Offset = "0x8634C0", VA = "0x180864AC0")]
		private void OnInventoryChanged(IInventory inventory, bool moved = false, int index = -1)
		{
			//Discarded unreachable code: IL_0016
			if (moved && index != -1)
			{
				(new int[1])[0] = index;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026B5")]
		[Cpp2IlInjected.Address(RVA = "0x864FB0", Offset = "0x8639B0", VA = "0x180864FB0")]
		private void OnInventoryChanged(IInventory inventory, bool moved, int[] indexes)
		{
			int amount = 0;
			Item invalid = Item.Invalid;
			OnInventoryChanged(inventory, invalid, amount, moved, indexes);
		}

		[Cpp2IlInjected.Token(Token = "0x60026B6")]
		[Cpp2IlInjected.Address(RVA = "0x864B70", Offset = "0x863570", VA = "0x180864B70", Slot = "18")]
		protected override void OnInventoryChanged(IInventory inventory, Item item, int amount, bool moved = false, [System.Runtime.InteropServices.Optional] int[] indexes)
		{
			//Discarded unreachable code: IL_0111
			//IL_0110: Expected O, but got I4
			if (inventory != null)
			{
				Storage storage = _storage;
				if (inventory != storage._containerInventory)
				{
					return;
				}
			}
			List<(Item, ItemState, int, bool)> list = (_storageItems = (List<(Item item, ItemState state, int amount, bool canSell)>)(object)Enumerable.ToList<(Item, ItemState, int, bool)>(_storage.GetItemsToDisplay()));
			List<(Item, ItemState, int, bool)> storageItems = _storageItems;
			int index = default(int);
			int homeStorageSize_ = default(int);
			if ((long)_storage._keyhole == 0)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item houseItem = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.HouseItem;
				BuildingItemData buildingItemData = default(BuildingItemData);
				List<UpgradeData> list2 = (List<UpgradeData>)(object)Enumerable.ToList<UpgradeData>((IEnumerable<>)(object)buildingItemData.upgradeInfo_);
				Func<UpgradeData, int> func = default(Func<UpgradeData, int>);
				if (_003C_003Ec._003C_003E9__20_0 == null)
				{
					func = (Func<UpgradeData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.House.homeStorageSize_));
				}
				UpgradeData upgradeData = Enumerable.FirstOrDefault<UpgradeData>((IEnumerable<>)Enumerable.OrderByDescending<UpgradeData, int>((IEnumerable<>)list2, (Func<, >)(object)func));
				if (upgradeData != null)
				{
					index = 0;
					homeStorageSize_ = upgradeData.House.homeStorageSize_;
				}
			}
			LoopScrollRect list3 = _list;
			list3.totalCount = homeStorageSize_;
			int num = 0;
			if ((long)num < (long)(IntPtr)list3)
			{
				_list.RefreshAt(index);
				num++;
				LoopScrollRect list4 = _list;
				int offset = 0;
				list4.RefillCells(offset);
			}
			int num2 = 0;
			RefreshFocusedItem((FocusNavigationElement)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x60026B7")]
		[Cpp2IlInjected.Address(RVA = "0x864900", Offset = "0x863300", VA = "0x180864900")]
		public void OnCloseShortcutTriggered()
		{
			//Discarded unreachable code: IL_003d, IL_00b1
			//IL_0023: Expected O, but got I4
			while (true)
			{
				if (!ItemActionList.gameObject.activeSelf)
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
					if (ItemAmountSelector.gameObject.activeSelf)
					{
						GameObject gameObject = ItemAmountSelector.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						return;
					}
				}
				else
				{
					GameObject gameObject2 = ItemActionList.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
					ItemActionList.ResetButtonClickedOn();
					int num2 = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						break;
					}
				}
			}
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60026B8")]
		[Cpp2IlInjected.Address(RVA = "0x864490", Offset = "0x862E90", VA = "0x180864490")]
		public void Init(Storage storage)
		{
			//Discarded unreachable code: IL_0101
			_storage = storage;
			List<(Item, ItemState, int, bool)> list = (_storageItems = (List<(Item item, ItemState state, int amount, bool canSell)>)(object)Enumerable.ToList<(Item, ItemState, int, bool)>(storage.GetItemsToDisplay()));
			int size = ((List<>)(object)_storageItems)._size;
			if ((long)_storage._keyhole == 0)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item houseItem = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.HouseItem;
				BuildingItemData buildingItemData = default(BuildingItemData);
				List<UpgradeData> list2 = (List<UpgradeData>)(object)Enumerable.ToList<UpgradeData>((IEnumerable<>)(object)buildingItemData.upgradeInfo_);
				Func<UpgradeData, int> _003C_003E9__22_ = _003C_003Ec._003C_003E9__22_0;
				if (_003C_003E9__22_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.House.homeStorageSize_);
				}
				UpgradeData upgradeData = Enumerable.FirstOrDefault<UpgradeData>((IEnumerable<>)Enumerable.OrderByDescending<UpgradeData, int>((IEnumerable<>)list2, (Func<, >)(object)_003C_003E9__22_));
				if (upgradeData != null)
				{
					BenefitsHouseData house = upgradeData.House;
				}
			}
			LoopScrollRect list3 = _list;
			int num = 0;
			PoolManager poolManager = (list3.ExternalPool = UiRoot.Instance.InventorySlotPool);
			_list.totalCount = size;
			int _003C_003E1__state = default(int);
			_003CWaitThenRefill_003Ed__23 _003CWaitThenRefill_003Ed__ = new _003CWaitThenRefill_003Ed__23(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitThenRefill_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (waitFrame = StartCoroutine(_003CWaitThenRefill_003Ed__));
			InitUpgradeHouseMessage();
		}

		[Cpp2IlInjected.Token(Token = "0x60026B9")]
		[Cpp2IlInjected.Address(RVA = "0x867250", Offset = "0x865C50", VA = "0x180867250")]
		[IteratorStateMachine(typeof(_003CWaitThenRefill_003Ed__23))]
		private IEnumerator WaitThenRefill()
		{
			int _003C_003E1__state = default(int);
			_003CWaitThenRefill_003Ed__23 _003CWaitThenRefill_003Ed__ = new _003CWaitThenRefill_003Ed__23(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitThenRefill_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026BA")]
		[Cpp2IlInjected.Address(RVA = "0x864090", Offset = "0x862A90", VA = "0x180864090")]
		private void InitUpgradeHouseMessage()
		{
			//Discarded unreachable code: IL_00bc
			GameObject gameObject = _upgradeHouseMessage.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			ContainerInventory containerInventory = _storage._containerInventory;
			if (containerInventory == null)
			{
				return;
			}
			ContainerInventory homeStorage = SystemRoot.Instance.MetaClient.profile.HomeStorage;
			if (containerInventory == homeStorage)
			{
				Item houseItem = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.HouseItem;
				GridCollection gridCollection_ = SystemRoot.Instance.MetaClient.profile.world_.gridCollection_;
				HouseData houseData = default(HouseData);
				int level_ = houseData.upgradeState_.level_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				BuildingItemData buildingItemData = default(BuildingItemData);
				UpgradeData upgradeData = ((IEnumerable<>)(object)buildingItemData.upgradeInfo_).Last<UpgradeData>();
				if (level_ < upgradeData.level_)
				{
					_upgradeHouseMessage.gameObject.SetActive(value: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026BB")]
		[Cpp2IlInjected.Address(RVA = "0x8650B0", Offset = "0x863AB0", VA = "0x1808650B0", Slot = "8")]
		protected override void OnItemDataHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026BC")]
		[Cpp2IlInjected.Address(RVA = "0x865BD0", Offset = "0x8645D0", VA = "0x180865BD0", Slot = "9")]
		protected override void OnItemTapHandler(ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026BD")]
		[Cpp2IlInjected.Address(RVA = "0x865AB0", Offset = "0x8644B0", VA = "0x180865AB0", Slot = "10")]
		protected override void OnItemRightClickHandler(ListEventData data)
		{
			//Discarded unreachable code: IL_0046
			//IL_0043: Expected O, but got I4
			int size = ((List<>)(object)_storageItems)._size;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			AK.Wwise.Event @event = transferOnClickSfx;
			GameObject gameObject = base.gameObject;
			uint num2 = @event.Post(gameObject);
			Func<int, Task> transferItemSlot = TransferItemSlot;
			int itemIndex = data.ItemIndex;
			Task task = (Task)transferItemSlot((T)itemIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60026BE")]
		[Cpp2IlInjected.Address(RVA = "0x8661F0", Offset = "0x864BF0", VA = "0x1808661F0")]
		public void OnSmartTransfer()
		{
			//Discarded unreachable code: IL_0082
			//IL_0019: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			if (!base.StorageOrBackpackHaveOngoingInventoryAction)
			{
				Storage storage = _storage;
				int num = 0;
				if (!(storage == (UnityEngine.Object)num) && _storage._containerInventory.iD_ != 0)
				{
					SmartInventoryTransfer.Types.Request request = new SmartInventoryTransfer.Types.Request();
					Client client = default(Client);
					uint num2 = (request.sourceInventoryID_ = client.profile.player_.Backpack.iD_);
					uint num3 = (request.destinationInventoryID_ = _storage._containerInventory.iD_);
					int num4 = 0;
					Client client2 = default(Client);
					client2.SmartInventoryTransfer(request, (CancellationToken)num4).FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026BF")]
		[Cpp2IlInjected.Address(RVA = "0x863F80", Offset = "0x862980", VA = "0x180863F80")]
		[AsyncStateMachine(typeof(_003CExecuteTransfer_003Ed__29))]
		private Task ExecuteTransfer(int itemIndex)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C0")]
		[Cpp2IlInjected.Address(RVA = "0x866600", Offset = "0x865000", VA = "0x180866600")]
		[AsyncStateMachine(typeof(_003CSplitStack_003Ed__30))]
		private Task SplitStack(BackpackSlotInventoryItem inventoryItem, int initialPosition, Item item, int amount, ItemState state)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C1")]
		[Cpp2IlInjected.Address(RVA = "0x8663D0", Offset = "0x864DD0", VA = "0x1808663D0")]
		private Task<int?> ShowAmountSelector(BackpackSlotInventoryItem item, int amount)
		{
			//Discarded unreachable code: IL_006c
			TaskCompletionSource<int?> taskCompletionSource = (TaskCompletionSource<int?>)(object)new TaskCompletionSource<TResult>();
			ItemAmountSelector itemAmountSelector = ItemAmountSelector;
			Action<int?> action = (Action<int?>)(object)(Action<T>)delegate(int? result)
			{
				//Discarded unreachable code: IL_002e
				bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)result);
				int num2 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
					SetFocus();
				}
			};
			ItemAmountSelector.gameObject.SetActive(value: true);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			return (Task<int?>)(object)((TaskCompletionSource<>)(object)taskCompletionSource).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C2")]
		[Cpp2IlInjected.Address(RVA = "0x865B60", Offset = "0x864560", VA = "0x180865B60")]
		private void OnItemSelect((Item item, ItemState state, int amount, bool canSell) item, bool select, int stars)
		{
			//Discarded unreachable code: IL_0008
			BackpackItemInfo itemInfo = _itemInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x60026C3")]
		[Cpp2IlInjected.Address(RVA = "0x863C90", Offset = "0x862690", VA = "0x180863C90", Slot = "7")]
		protected override void DoSetFocus()
		{
			//Discarded unreachable code: IL_00c3
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0087: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			MenuNavigation menuNavigation = MenuNavigation;
			int num = 0;
			if (menuNavigation == (UnityEngine.Object)num)
			{
				return;
			}
			FocusNavigation focusNavigation = MenuNavigation.FocusNavigation;
			int num2 = 0;
			if (focusNavigation == (UnityEngine.Object)num2 || ItemAmountSelector.gameObject.activeSelf)
			{
				return;
			}
			if (ItemActionList.gameObject.activeSelf)
			{
				BackpackActionList itemActionList = ItemActionList;
				List<BackpackActionList.ActionItemData> actions = itemActionList._actions;
				FocusNavigation focusNavigation2 = MenuNavigation.FocusNavigation;
				itemActionList.SetFocus(focusNavigation2);
				return;
			}
			int num3 = 0;
			if (menuNavigation != (UnityEngine.Object)num3)
			{
				return;
			}
			int num4 = 0;
			int num5 = default(int);
			while (num5 <= 0)
			{
			}
			int num6 = 0;
			if (menuNavigation != (UnityEngine.Object)num6)
			{
				BackpackSlotInventoryItem component = menuNavigation.GetComponent<BackpackSlotInventoryItem>();
				int num7 = 0;
				if (component != (UnityEngine.Object)num7)
				{
					int _003CItemIndex_003Ek__BackingField = ((BackpackInventoryItem)component).ItemIndex;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026C4")]
		[Cpp2IlInjected.Address(RVA = "0x866730", Offset = "0x865130", VA = "0x180866730")]
		private void Update()
		{
			//Discarded unreachable code: IL_02cb, IL_02d1, IL_02d7, IL_02dd, IL_02e3, IL_02e9, IL_02f5
			//IL_0088: Expected O, but got I4
			//IL_0175: Expected O, but got I4
			//IL_0212: Expected O, but got I4
			//IL_0247: Expected O, but got I4
			Vector3 vector = default(Vector3);
			bool flag = default(bool);
			Vector3 vector2 = default(Vector3);
			bool flag2 = default(bool);
			Vector3 vector3 = default(Vector3);
			bool flag3 = default(bool);
			BackpackSlotInventoryItem backpackSlotInventoryItem = default(BackpackSlotInventoryItem);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (ItemActionList.gameObject.activeSelf && Input.GetMouseButtonDown(0))
				{
					RectTransform background = ItemActionList._background;
					int num3 = 0;
					Vector2 mousePosition = Input.mousePosition;
					float z = vector.z;
					RectTransform background2 = ItemActionList._background;
					if (!flag)
					{
						GameObject gameObject = ItemActionList.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						ItemActionList.ResetButtonClickedOn();
					}
				}
				InventorySortPanel inventorySortPanel = InventorySortPanel;
				int num4 = 0;
				if (inventorySortPanel != (UnityEngine.Object)num4 && (InventorySortPanel.IsOpen ? 1 : 0) != num2 && Input.GetMouseButtonDown(0))
				{
					RectTransform rectTransform = InventorySortPanel._rectTransform;
					int num5 = 0;
					Vector2 mousePosition2 = Input.mousePosition;
					float z2 = vector2.z;
					RectTransform rectTransform2 = InventorySortPanel._rectTransform;
					if (!flag2)
					{
						InventorySortPanel.Close();
					}
				}
				if (ItemAmountSelector.gameObject.activeSelf && Input.GetMouseButtonDown(0))
				{
					if ((object)ItemAmountSelector.transform != null)
					{
					}
					int num6 = 0;
					Vector2 mousePosition3 = Input.mousePosition;
					float z3 = vector3.z;
					if (!flag3)
					{
						GameObject gameObject2 = ItemAmountSelector.gameObject;
						int active2 = 0;
						gameObject2.SetActive((byte)active2 != 0);
					}
				}
				if ((_inventoryDragAndDrop.IsDragging ? 1 : 0) == num2 && !ItemActionList.gameObject.activeSelf)
				{
					InventorySortPanel inventorySortPanel2 = InventorySortPanel;
					int num7 = 0;
					if ((!(inventorySortPanel2 != (UnityEngine.Object)num7) || (InventorySortPanel.IsOpen ? 1 : 0) == num2) && !ItemAmountSelector.gameObject.activeSelf && (IntPtr)MenuNavigation.FocusNavigation._focusedElement != (IntPtr)num2 && Input.GetButton(_shortcutHoldKey.Self.RewiredActionId) && (Input.GetAxis(_axisNameX) > 0.1f || !(Input.GetAxis(_axisNameY) <= 0.1f)))
					{
						ISupportsFocusNavigation focusedElement = MenuNavigation.FocusNavigation._focusedElement;
						int num8 = 0;
						int num9 = 0;
						int num10 = 0;
						if (backpackSlotInventoryItem != (UnityEngine.Object)num10)
						{
							backpackSlotInventoryItem.OnBeginDrag();
						}
						return;
					}
				}
				if (_inventoryDragAndDrop.IsJoystickDragging)
				{
					RectTransform dragTarget = _inventoryDragAndDrop.DragTarget;
					int num11 = 0;
					if (dragTarget != (UnityEngine.Object)num11)
					{
						break;
					}
				}
			}
			IEnumerator enumerator = _list.m_Content.GetEnumerator();
			FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
			if (enumerator != null)
			{
				if (enumerator == null)
				{
				}
				int num12 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				RectTransform dragTarget2 = _inventoryDragAndDrop.DragTarget;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				Vector3 vector5 = default(Vector3);
				float z5 = vector5.z;
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				if (MenuNavigation.FocusNavigation._focusedElement != null)
				{
					int num13 = 0;
				}
				bool flag5 = default(bool);
				bool flag6 = default(bool);
				if (flag5 || flag6)
				{
					RefreshFocusedItem(focusNavigationElement);
				}
			}
			if ((object)focusNavigationElement != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026C5")]
		[Cpp2IlInjected.Address(RVA = "0x8672C0", Offset = "0x865CC0", VA = "0x1808672C0")]
		public StorageContent()
		{
		}
	}
}
