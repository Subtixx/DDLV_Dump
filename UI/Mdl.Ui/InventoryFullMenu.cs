using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.InputSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005D3")]
	public class InventoryFullMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002066")]
		[SerializeField]
		private BackpackContent _backpackContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002067")]
		[SerializeField]
		private ListBase _newItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002068")]
		[SerializeField]
		private AK.Wwise.Event dropOnClickSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002069")]
		private List<ItemInstance> _allItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400206A")]
		private InputAction ActionPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400206B")]
		private InputAction BackPress;

		[Cpp2IlInjected.Token(Token = "0x6002630")]
		[Cpp2IlInjected.Address(RVA = "0xD2C010", Offset = "0xD2AA10", VA = "0x180D2C010", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			ListBase.ListEvents onItemData = _newItemList.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6002631")]
		[Cpp2IlInjected.Address(RVA = "0xD2C340", Offset = "0xD2AD40", VA = "0x180D2C340", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			ListBase.ListEvents onItemData = _newItemList.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemData);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6002632")]
		[Cpp2IlInjected.Address(RVA = "0xD2BD50", Offset = "0xD2A750", VA = "0x180D2BD50", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00a7
			//IL_0072: Expected I4, but got I8
			base.OnPush(stack, param);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			instance.UpdateCursorBehaviorForUI();
			if (param != null)
			{
				int num2 = 0;
				if (param != null && (object)instance != null)
				{
					List<ItemInstance> allItems = default(List<ItemInstance>);
					_allItems = allItems;
					((List<T>)(object)_allItems).Reverse();
					BackpackContent backpackContent = _backpackContent;
					List<ItemInstance> allItems2 = _allItems;
					ListBase newItemList = _newItemList;
					int num3 = (newItemList.TotalCount = ((List<>)(object)allItems2)._size);
				}
			}
			ulong num4 = default(ulong);
			_backpackContent.SlidingPanel.Show((byte)num4 != 0);
			BackpackContent backpackContent2 = _backpackContent;
			CancellationToken cancellationToken = (backpackContent2.CancellationToken = base.CancellationToken);
			Dictionary<BackpackContent.ActionType, Action> customActions = _backpackContent.CustomActions;
			Action action = OnDropItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6002633")]
		[Cpp2IlInjected.Address(RVA = "0xD2B820", Offset = "0xD2A220", VA = "0x180D2B820", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_00c9
			//IL_0018: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			base.OnFocusIn();
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num = default(int);
			InputActionBool actionPress = new InputActionBool("[ A ]", trigger, (InputProvider)num);
			num = 0;
			ActionPress = actionPress;
			int num2 = 0;
			DialogueMenu menu = UiRoot.Instance._menuStack.GetMenu<DialogueMenu>();
			int num3 = 0;
			if (menu != (UnityEngine.Object)num3)
			{
				InputAction actionPress2 = ActionPress;
				EventHandler value = TriggerGamepadInput;
				actionPress2.OnTriggered += value;
			}
			InputTriggerPressed trigger2 = new InputTriggerPressed();
			int num4 = default(int);
			InputActionBool backPress = new InputActionBool("[ B ]", trigger2, (InputProvider)num4);
			num4 = 0;
			BackPress = backPress;
			int num5 = 0;
			DialogueMenu menu2 = UiRoot.Instance._menuStack.GetMenu<DialogueMenu>();
			int num6 = 0;
			if (menu2 != (UnityEngine.Object)num6)
			{
				InputAction backPress2 = BackPress;
				EventHandler value2 = TriggerDrop;
				backPress2.OnTriggered += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002634")]
		[Cpp2IlInjected.Address(RVA = "0xD2BAD0", Offset = "0xD2A4D0", VA = "0x180D2BAD0", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0086
			//IL_0023: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			base.OnFocusOut(popAfterFocusOut, animate);
			int num = 0;
			DialogueMenu menu = UiRoot.Instance._menuStack.GetMenu<DialogueMenu>();
			int num2 = 0;
			if (menu != (UnityEngine.Object)num2)
			{
				InputAction actionPress = ActionPress;
				EventHandler value = TriggerGamepadInput;
				actionPress.OnTriggered -= value;
			}
			int num3 = 0;
			DialogueMenu menu2 = UiRoot.Instance._menuStack.GetMenu<DialogueMenu>();
			int num4 = 0;
			if (menu2 != (UnityEngine.Object)num4)
			{
				InputAction backPress = BackPress;
				EventHandler value2 = TriggerDrop;
				backPress.OnTriggered -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002635")]
		[Cpp2IlInjected.Address(RVA = "0xD2C200", Offset = "0xD2AC00", VA = "0x180D2C200")]
		private void TriggerGamepadInput(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0038
			//IL_002a: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			int num = 0;
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
					_backpackContent.TriggerActionList((BackpackActionItem)num);
				}
			}
			else
			{
				_backpackContent.TriggerItemTap((BackpackSlotInventoryItem)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002636")]
		[Cpp2IlInjected.Address(RVA = "0xD2C0E0", Offset = "0xD2AAE0", VA = "0x180D2C0E0")]
		private void TriggerDrop(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0067
			_backpackContent.TriggerDrop();
			BackpackContent backpackContent = _backpackContent;
			int selectedSlotId = ((InventoryContent)backpackContent)._selectedSlotId;
			backpackContent.SimulateDropItem(selectedSlotId).FireAndForgetTask();
			BackpackContent backpackContent2 = _backpackContent;
			int selectedSlotId2 = ((InventoryContent)backpackContent2)._selectedSlotId;
			backpackContent2.ShowEmpty(selectedSlotId2);
			List<ItemInstance> allItems = _allItems;
			if (allItems != null)
			{
				List<int> showEmptyIndexes = _backpackContent.ShowEmptyIndexes;
				int size = ((List<>)(object)allItems)._size;
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002637")]
		[Cpp2IlInjected.Address(RVA = "0xD2C410", Offset = "0xD2AE10", VA = "0x180D2C410")]
		private void Update()
		{
			//Discarded unreachable code: IL_0048
			float deltaTime;
			InputAction[] array;
			InputAction backPress;
			while (true)
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[2];
				InputAction actionPress = ActionPress;
				if (actionPress == null || array != null)
				{
					array[0] = actionPress;
					backPress = BackPress;
					if (backPress == null || array != null)
					{
						break;
					}
				}
			}
			array[1] = backPress;
			InputAction.UpdateAll(deltaTime, array);
		}

		[Cpp2IlInjected.Token(Token = "0x6002638")]
		[Cpp2IlInjected.Address(RVA = "0xD2BCA0", Offset = "0xD2A6A0", VA = "0x180D2BCA0")]
		public void OnItemData(ListBase.ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002639")]
		[Cpp2IlInjected.Address(RVA = "0xD2B720", Offset = "0xD2A120", VA = "0x180D2B720")]
		private void OnDropItem()
		{
			//Discarded unreachable code: IL_005c
			BackpackContent backpackContent = _backpackContent;
			int selectedSlotId = ((InventoryContent)backpackContent)._selectedSlotId;
			backpackContent.SimulateDropItem(selectedSlotId).FireAndForgetTask();
			BackpackContent backpackContent2 = _backpackContent;
			int selectedSlotId2 = ((InventoryContent)backpackContent2)._selectedSlotId;
			backpackContent2.ShowEmpty(selectedSlotId2);
			List<ItemInstance> allItems = _allItems;
			if (allItems != null)
			{
				List<int> showEmptyIndexes = _backpackContent.ShowEmptyIndexes;
				int size = ((List<>)(object)allItems)._size;
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600263A")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		public void OnBackpackUpgradeSuccess()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x600263B")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF90", Offset = "0xD2A990", VA = "0x180D2BF90", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__17))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__17 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__17(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600263C")]
		[Cpp2IlInjected.Address(RVA = "0xD2B6C0", Offset = "0xD2A0C0", VA = "0x180D2B6C0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0028
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				_backpackContent.SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600263D")]
		[Cpp2IlInjected.Address(RVA = "0xD2B650", Offset = "0xD2A050", VA = "0x180D2B650", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0033
			if (redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.GamePopCurrentMenu)
			{
				if (!_backpackContent.HasOngoingInventoryAction)
				{
					IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
				}
				else
				{
					_backpackContent.OnCloseShortcutTriggered();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600263E")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public InventoryFullMenu()
		{
		}
	}
}
