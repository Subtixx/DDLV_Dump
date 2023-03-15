using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.InputSystem;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005F0")]
	public class StorageMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40020F5")]
		[SerializeField]
		public BackpackContent BackpackContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40020F6")]
		[SerializeField]
		public StorageContent StorageContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40020F7")]
		[SerializeField]
		private Storage _storage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40020F8")]
		[SerializeField]
		private GameObject _storageBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40020F9")]
		[SerializeField]
		private GameObject _backpackBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40020FA")]
		private InputAction _inputActionLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40020FB")]
		private InputAction _inputActionRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40020FC")]
		private FocusNavigationElement _backpackFirstSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40020FD")]
		private FocusNavigationElement _storageFirstSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40020FE")]
		private EventSystem _eventSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40020FF")]
		public InventoryContent InventoryContentWithFocusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002100")]
		private Coroutine _waitForSlotInstance;

		[Cpp2IlInjected.Token(Token = "0x170005EB")]
		public InventoryContent FocusedInventoryContent
		{
			[Cpp2IlInjected.Token(Token = "0x60026FC")]
			[Cpp2IlInjected.Address(RVA = "0x8696B0", Offset = "0x8680B0", VA = "0x1808696B0")]
			get
			{
				//IL_002c: Expected O, but got I4
				if (!StorageContent.HasOngoingInventoryAction)
				{
					if (!BackpackContent.HasOngoingInventoryAction)
					{
						InventoryContent inventoryContentWithFocusedElement = InventoryContentWithFocusedElement;
						int num = 0;
						if (inventoryContentWithFocusedElement != (UnityEngine.Object)num)
						{
							return InventoryContentWithFocusedElement;
						}
					}
					BackpackContent backpackContent = BackpackContent;
				}
				StorageContent storageContent = StorageContent;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60026FD")]
		[Cpp2IlInjected.Address(RVA = "0x868690", Offset = "0x867090", VA = "0x180868690", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//IL_014f: Expected I4, but got I8
			//IL_01b2: Expected I4, but got I8
			//IL_01ff: Expected O, but got I4
			//IL_0221: Expected O, but got I4
			base.OnPush(stack, param);
			int num = 0;
			UiRoot.Instance.UpdateCursorBehaviorForUI();
			if (param != null)
			{
				object[] @params = param.Params;
				if (@params != null)
				{
					if (@params.Length != 0)
					{
						object obj = @params[0];
						if (obj != null && obj != null)
						{
							_storage._containerInventory = (ContainerInventory)obj;
						}
					}
					if (@params != null && @params.Length != 0)
					{
						object obj2 = @params[0];
						if (obj2 != null && obj2 != null)
						{
							_storage._keyhole = (Keyhole)obj2;
							Client client = default(Client);
							ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
							ProfileEventDispatcher.KeyholeLevelCompleted value = OnKeyholeLevelCompleted;
							_003CDispatcher_003Ek__BackingField.OnKeyholeLevelCompleted += value;
						}
					}
				}
			}
			Storage storage = _storage;
			ContainerInventory containerInventory = (storage._containerInventory = SystemRoot.Instance.MetaClient.profile.HomeStorage);
			if (param != null)
			{
				object[] params2 = param.Params;
				if (params2 != null && params2.Length > 1)
				{
					object obj3 = params2[1];
					if (obj3 != null && obj3 != null && (object)typeof(string).TypeHandle == null)
					{
						TextBase title = StorageContent._title;
					}
				}
				object[] params3 = param.Params;
				if (params3 != null && params3.Length > 2)
				{
					object obj4 = params3[2];
					if (obj4 != null && obj4 != null)
					{
						BackpackContent.TransferItemFilter = (ItemFilterData)obj4;
					}
				}
			}
			ulong num2 = default(ulong);
			BackpackContent.SlidingPanel.Show((byte)num2 != 0);
			BackpackContent backpackContent = BackpackContent;
			Func<int, Task> func = (backpackContent.TransferItemSlot = (Func<int, Task>)(object)(Func<T, TResult>)delegate
			{
				Storage storage4 = _storage;
				ContainerInventory backpack2 = SystemRoot.Instance.MetaClient.profile.Backpack;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers2 = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)storage4).get_ElementIdentifiers();
				throw new NullReferenceException();
			});
			BackpackContent backpackContent2 = BackpackContent;
			CancellationToken cancellationToken = (backpackContent2.CancellationToken = base.CancellationToken);
			StorageContent storageContent = StorageContent;
			Storage storage2 = _storage;
			storageContent.Init(storage2);
			ulong num3 = default(ulong);
			StorageContent.SlidingPanel.Show((byte)num3 != 0);
			StorageContent storageContent2 = StorageContent;
			Func<int, Task> func2 = (storageContent2.TransferItemSlot = (Func<int, Task>)(object)(Func<T, TResult>)delegate
			{
				Storage storage3 = _storage;
				ContainerInventory backpack = SystemRoot.Instance.MetaClient.profile.Backpack;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)storage3).get_ElementIdentifiers();
				throw new NullReferenceException();
			});
			StorageContent storageContent3 = StorageContent;
			CancellationToken cancellationToken2 = (storageContent3.CancellationToken = base.CancellationToken);
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num4 = default(int);
			InputActionBool inputActionLB = new InputActionBool("[LB]", trigger, (InputProvider)num4);
			num4 = 0;
			_inputActionLB = inputActionLB;
			InputTriggerPressed trigger2 = new InputTriggerPressed();
			int num5 = default(int);
			InputActionBool inputActionRB = new InputActionBool("[RB]", trigger2, (InputProvider)num5);
			num5 = 0;
			_inputActionRB = inputActionRB;
			int _003C_003E1__state = default(int);
			_003CWaitForSlotInstance_003Ed__26 _003CWaitForSlotInstance_003Ed__ = new _003CWaitForSlotInstance_003Ed__26(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForSlotInstance_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_waitForSlotInstance = StartCoroutine(_003CWaitForSlotInstance_003Ed__));
			EventSystem eventSystem = (_eventSystem = UnityEngine.Object.FindObjectOfType<EventSystem>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026FE")]
		[Cpp2IlInjected.Address(RVA = "0x869490", Offset = "0x867E90", VA = "0x180869490")]
		private void Update()
		{
			float deltaTime;
			InputAction[] array;
			InputAction inputActionRB;
			while (true)
			{
				UpdateBlocker();
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[2];
				InputAction inputActionLB = _inputActionLB;
				if (inputActionLB == null || array != null)
				{
					array[0] = inputActionLB;
					inputActionRB = _inputActionRB;
					if (inputActionRB == null || array != null)
					{
						break;
					}
				}
			}
			array[1] = inputActionRB;
			InputAction.UpdateAll(deltaTime, array);
			if (!_inputActionLB.IsTriggered)
			{
				if (_inputActionRB.IsTriggered)
				{
					OnRBPress();
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026FF")]
		[Cpp2IlInjected.Address(RVA = "0x8684B0", Offset = "0x866EB0", VA = "0x1808684B0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_005f
			Coroutine waitForSlotInstance = _waitForSlotInstance;
			if (waitForSlotInstance != null)
			{
				StopCoroutine(waitForSlotInstance);
			}
			base.OnPop();
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.KeyholeLevelCompleted value = OnKeyholeLevelCompleted;
					_003CDispatcher_003Ek__BackingField.OnKeyholeLevelCompleted -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002700")]
		[Cpp2IlInjected.Address(RVA = "0x868180", Offset = "0x866B80", VA = "0x180868180", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0022
			base.OnFocusIn();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002701")]
		[Cpp2IlInjected.Address(RVA = "0x868F30", Offset = "0x867930", VA = "0x180868F30", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__18))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__18 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002702")]
		[Cpp2IlInjected.Address(RVA = "0x8680C0", Offset = "0x866AC0", VA = "0x1808680C0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0061
			//IL_0060: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			BackpackContent.SelectedSlotId = -1;
			BackpackContent.ClearFocusedElement();
			StorageContent.SelectedSlotId = -1;
			StorageContent.ClearFocusedElement();
			EventSystem eventSystem = _eventSystem;
			int num2 = 0;
			eventSystem.SetSelectedGameObject((GameObject)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002703")]
		[Cpp2IlInjected.Address(RVA = "0x868FB0", Offset = "0x8679B0", VA = "0x180868FB0")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_0040
			//IL_002c: Expected O, but got I4
			if (!StorageContent.HasOngoingInventoryAction && !BackpackContent.HasOngoingInventoryAction)
			{
				InventoryContent inventoryContentWithFocusedElement = InventoryContentWithFocusedElement;
				int num = 0;
				if (inventoryContentWithFocusedElement != (UnityEngine.Object)num)
				{
				}
			}
			StorageContent storageContent = StorageContent;
			int focus = 0;
			storageContent.SetFocus((byte)focus != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002704")]
		[Cpp2IlInjected.Address(RVA = "0x868010", Offset = "0x866A10", VA = "0x180868010", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0055
			if (redirectionType != RedirectionType.MenuNavGoBackward && redirectionType != RedirectionType.MenuNavClose && redirectionType != RedirectionType.GamePopCurrentMenu)
			{
				return;
			}
			if (!BackpackContent.HasOngoingInventoryAction)
			{
				if (!StorageContent.HasOngoingInventoryAction)
				{
					IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
				}
				else
				{
					StorageContent.OnCloseShortcutTriggered();
				}
			}
			else
			{
				BackpackContent.OnCloseShortcutTriggered();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002705")]
		[Cpp2IlInjected.Address(RVA = "0x8681D0", Offset = "0x866BD0", VA = "0x1808681D0")]
		private void OnKeyholeLevelCompleted(Keyhole keyhole, int levelCompleted)
		{
			//Discarded unreachable code: IL_002c
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.KeyholeLevelCompleted value = OnKeyholeLevelCompleted;
			_003CDispatcher_003Ek__BackingField.OnKeyholeLevelCompleted -= value;
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002706")]
		[Cpp2IlInjected.Address(RVA = "0x868310", Offset = "0x866D10", VA = "0x180868310")]
		private void OnLBPress()
		{
			//Discarded unreachable code: IL_0065
			//IL_003e: Expected O, but got I4
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
			}
			int num = 0;
			if (focusedElement != null)
			{
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag)
				{
					BackpackSlotInventoryItem backpackSlotInventoryItem = default(BackpackSlotInventoryItem);
					flag2 = backpackSlotInventoryItem.AssociatedMenu == BackpackSlotInventoryItem.AssociatedMenuEnum.Backpack;
				}
				FocusNavigationElement backpackFirstSlot = _backpackFirstSlot;
				int num2 = 0;
				if (backpackFirstSlot != (UnityEngine.Object)num2 && !flag2)
				{
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					FocusNavigationElement backpackFirstSlot2 = _backpackFirstSlot;
					focusNavigation.SetFocus(backpackFirstSlot2);
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002707")]
		[Cpp2IlInjected.Address(RVA = "0x868D90", Offset = "0x867790", VA = "0x180868D90")]
		private void OnRBPress()
		{
			//Discarded unreachable code: IL_0065
			//IL_003e: Expected O, but got I4
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
			}
			int num = 0;
			if (focusedElement != null)
			{
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag)
				{
					BackpackSlotInventoryItem backpackSlotInventoryItem = default(BackpackSlotInventoryItem);
					flag2 = backpackSlotInventoryItem.AssociatedMenu == BackpackSlotInventoryItem.AssociatedMenuEnum.Storage;
				}
				FocusNavigationElement storageFirstSlot = _storageFirstSlot;
				int num2 = 0;
				if (storageFirstSlot != (UnityEngine.Object)num2 && !flag2)
				{
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					FocusNavigationElement storageFirstSlot2 = _storageFirstSlot;
					focusNavigation.SetFocus(storageFirstSlot2);
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002708")]
		[Cpp2IlInjected.Address(RVA = "0x869290", Offset = "0x867C90", VA = "0x180869290")]
		private void UpdateBlocker()
		{
			//Discarded unreachable code: IL_00c4
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			GameObject storageBlocker = _storageBlocker;
			int num = 0;
			if (!(storageBlocker != (UnityEngine.Object)num))
			{
				return;
			}
			GameObject backpackBlocker = _backpackBlocker;
			int num2 = 0;
			if (backpackBlocker != (UnityEngine.Object)num2)
			{
				if (!StorageContent.ItemActionList.gameObject.activeInHierarchy && !StorageContent.ItemAmountSelector.gameObject.activeInHierarchy && !BackpackContent.ItemActionList.gameObject.activeInHierarchy && !BackpackContent.ItemAmountSelector.gameObject.activeInHierarchy)
				{
					GameObject storageBlocker2 = _storageBlocker;
					int active = 0;
					storageBlocker2.SetActive((byte)active != 0);
					GameObject backpackBlocker2 = _backpackBlocker;
					int active2 = 0;
					backpackBlocker2.SetActive((byte)active2 != 0);
				}
				else
				{
					storageBlocker.SetActive(value: true);
					storageBlocker.SetActive(value: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002709")]
		[Cpp2IlInjected.Address(RVA = "0x869640", Offset = "0x868040", VA = "0x180869640")]
		[IteratorStateMachine(typeof(_003CWaitForSlotInstance_003Ed__26))]
		private IEnumerator WaitForSlotInstance()
		{
			int _003C_003E1__state = default(int);
			_003CWaitForSlotInstance_003Ed__26 _003CWaitForSlotInstance_003Ed__ = new _003CWaitForSlotInstance_003Ed__26(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForSlotInstance_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600270A")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public StorageMenu()
		{
		}
	}
}
