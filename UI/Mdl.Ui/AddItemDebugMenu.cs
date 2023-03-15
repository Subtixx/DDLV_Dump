using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003DA")]
	public class AddItemDebugMenu : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40012F5")]
		[SerializeField]
		private LoopVerticalScrollRect _listItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40012F6")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40012F7")]
		private IItemData[] _allItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40012F8")]
		[SerializeField]
		private Dropdown _mcFilterDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40012F9")]
		[SerializeField]
		private Slider _mcAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40012FA")]
		[SerializeField]
		private Text _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40012FB")]
		[SerializeField]
		private ButtonTmPro _btnTransfer;

		[Cpp2IlInjected.Token(Token = "0x6001884")]
		[Cpp2IlInjected.Address(RVA = "0x87C270", Offset = "0x87AC70", VA = "0x18087C270", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_00dc
			((object)this)._002Ector();
			LoopScrollRect.ListEvents listEvents = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(onItemData);
			((UnityEvent<T0>)(object)listEvents).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents listEvents2 = ((LoopScrollRect)_listItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(onItemTap);
			((UnityEvent<T0>)(object)listEvents2).AddListener((UnityAction<>)(object)unityAction2);
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = onCloseHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnTransfer.ButtonComponent.m_OnClick;
			UnityAction call2 = OnTransferAllClickedHandler;
			onClick2.AddListener(call2);
			Slider.SliderEvent onValueChanged = _mcAmount.m_OnValueChanged;
			UnityAction<float> unityAction3 = (UnityAction<float>)(object)new UnityAction<T0>(OnAmountValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction3);
			Dropdown.DropdownEvent onValueChanged2 = _mcFilterDD.m_OnValueChanged;
			UnityAction<int> unityAction4 = (UnityAction<int>)(object)new UnityAction<T0>(OnFilterValueChanged);
			((UnityEvent<T0>)(object)onValueChanged2).AddListener((UnityAction<>)(object)unityAction4);
		}

		[Cpp2IlInjected.Token(Token = "0x6001885")]
		[Cpp2IlInjected.Address(RVA = "0x87C590", Offset = "0x87AF90", VA = "0x18087C590", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_00dc
			base.UnregisterFocusedListeners();
			LoopScrollRect.ListEvents listEvents = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(onItemData);
			((UnityEvent<T0>)(object)listEvents).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents listEvents2 = ((LoopScrollRect)_listItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(onItemTap);
			((UnityEvent<T0>)(object)listEvents2).RemoveListener((UnityAction<>)(object)unityAction2);
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = onCloseHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnTransfer.ButtonComponent.m_OnClick;
			UnityAction call2 = OnTransferAllClickedHandler;
			onClick2.RemoveListener(call2);
			Slider.SliderEvent onValueChanged = _mcAmount.m_OnValueChanged;
			UnityAction<float> unityAction3 = (UnityAction<float>)(object)new UnityAction<T0>(OnAmountValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction3);
			Dropdown.DropdownEvent onValueChanged2 = _mcFilterDD.m_OnValueChanged;
			UnityAction<int> unityAction4 = (UnityAction<int>)(object)new UnityAction<T0>(OnFilterValueChanged);
			((UnityEvent<T0>)(object)onValueChanged2).RemoveListener((UnityAction<>)(object)unityAction4);
		}

		[Cpp2IlInjected.Token(Token = "0x6001886")]
		[Cpp2IlInjected.Address(RVA = "0x87BCD0", Offset = "0x87A6D0", VA = "0x18087BCD0")]
		private void OnAmountValueChangedHandler(float value)
		{
			//Discarded unreachable code: IL_000d
			string text = default(string);
			_tfAmount.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6001887")]
		[Cpp2IlInjected.Address(RVA = "0x87C020", Offset = "0x87AA20", VA = "0x18087C020")]
		private void OnTransferAllClickedHandler()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001888")]
		[Cpp2IlInjected.Address(RVA = "0x87C170", Offset = "0x87AB70", VA = "0x18087C170")]
		[AsyncStateMachine(typeof(_003COnTransferAllTask_003Ed__11))]
		private Task OnTransferAllTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001889")]
		[Cpp2IlInjected.Address(RVA = "0x87BD20", Offset = "0x87A720", VA = "0x18087BD20")]
		private void OnFilterValueChanged(int val)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600188A")]
		[Cpp2IlInjected.Address(RVA = "0x87CD50", Offset = "0x87B750", VA = "0x18087CD50")]
		private void onItemTap(ListEventData arg0)
		{
			//Discarded unreachable code: IL_001f
			int itemIndex = arg0.ItemIndex;
			IItemData[] allItems = _allItems;
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600188B")]
		[Cpp2IlInjected.Address(RVA = "0x87BBA0", Offset = "0x87A5A0", VA = "0x18087BBA0")]
		[AsyncStateMachine(typeof(_003CAddItemTask_003Ed__14))]
		private Task AddItemTask(IItemData item, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600188C")]
		[Cpp2IlInjected.Address(RVA = "0x87BF10", Offset = "0x87A910", VA = "0x18087BF10", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_003c
			base.OnFocusIn();
			List<string> list = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)(object)Enum.GetNames(typeof(ActivityItemType)));
			_mcFilterDD.ClearOptions();
			_mcFilterDD.AddOptions((List<>)(object)list);
			int val = 0;
			OnFilterValueChanged(val);
		}

		[Cpp2IlInjected.Token(Token = "0x600188D")]
		[Cpp2IlInjected.Address(RVA = "0x87C8B0", Offset = "0x87B2B0", VA = "0x18087C8B0")]
		private void onCloseHandler()
		{
			//Discarded unreachable code: IL_0012
			int num = 0;
			UiRoot.Instance._menuStack.Pop();
		}

		[Cpp2IlInjected.Token(Token = "0x600188E")]
		[Cpp2IlInjected.Address(RVA = "0x87C8E0", Offset = "0x87B2E0", VA = "0x18087C8E0")]
		private void onItemData(ListEventData arg)
		{
			//Discarded unreachable code: IL_00cf
			//IL_001b: Expected O, but got I4
			//IL_0091: Expected O, but got I4
			BackpackItem component = arg.DisplayObject.GetComponent<BackpackItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				IItemData[] allItems = _allItems;
				int itemIndex = arg.ItemIndex;
				IItemData item = allItems[itemIndex];
				RepeatedField<ContainerInventory.Types.Slot> inventory_ = SystemRoot.Instance.Client.Profile.Backpack.inventory_;
				Predicate<ContainerInventory.Types.Slot> predicate = (Predicate<ContainerInventory.Types.Slot>)(object)(Predicate<T>)delegate(ContainerInventory.Types.Slot x)
				{
					int itemID = x.ItemID;
					IItemData itemData2 = item;
					throw new NullReferenceException();
				};
				ContainerInventory.Types.Slot slot = ((RepeatedField<>)(object)inventory_).Find<ContainerInventory.Types.Slot>((Predicate<>)(object)predicate);
				int num2 = 0;
				bool flag = default(bool);
				if (!flag)
				{
					component.ItemName = (string)(component.InventoryCount = 0);
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (slot != null)
				{
				}
				int num3 = (component.InventoryCount = 0);
				IItemData itemData = default(IItemData);
				component.ItemName = (string)(object)itemData;
				component.IconTexture = (string)(object)itemData;
				int num4 = (component.ItemIndex = arg.ItemIndex);
				component.Refresh();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600188F")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public AddItemDebugMenu()
		{
		}
	}
}
