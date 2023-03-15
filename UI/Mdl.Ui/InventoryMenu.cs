using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005D6")]
	public class InventoryMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002074")]
		[SerializeField]
		private GameObject _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002075")]
		[SerializeField]
		public BackpackContent BackpackContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002076")]
		public InventoryNavBar InventoryNavBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002077")]
		[SerializeField]
		private ManaBar _manaBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002078")]
		[SerializeField]
		private GameObject _backpackBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002079")]
		[SerializeField]
		private SimpleSlide _barSlide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400207A")]
		[SerializeField]
		private AK.Wwise.Event _gainManaStartedSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400207B")]
		[SerializeField]
		private AK.Wwise.Event _gainManaStoppedSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400207C")]
		public XpBar XpBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400207D")]
		private bool _popped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400207E")]
		private EventSystem _eventSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400207F")]
		public bool GotNavBar = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x129")]
		[Cpp2IlInjected.Token(Token = "0x4002080")]
		private bool _navOnHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002081")]
		private Coroutine _waitForFocusCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002082")]
		private FocusNavigationElement _lastFocusedElement;

		[Cpp2IlInjected.Token(Token = "0x6002648")]
		[Cpp2IlInjected.Address(RVA = "0xD2DF50", Offset = "0xD2C950", VA = "0x180D2DF50", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0106
			//IL_0029: Expected O, but got I4
			int num = 0;
			KeepVisible = true;
			_popped = false;
			InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
			int num2 = 0;
			bool flag = menu != (UnityEngine.Object)num2;
			InventoryNavBar inventoryNavBar = InventoryNavBar;
			if (!flag)
			{
				GotNavBar = true;
				GameObject gameObject = inventoryNavBar.gameObject;
			}
			GotNavBar = false;
			GameObject gameObject2 = inventoryNavBar.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
			base.OnPush(stack, param);
			XpBar.Refresh();
			EventSystem eventSystem = (_eventSystem = UnityEngine.Object.FindObjectOfType<EventSystem>());
			BackpackContent backpackContent = BackpackContent;
			CancellationToken cancellationToken = (backpackContent.CancellationToken = base.CancellationToken);
			BackpackContent backpackContent2 = BackpackContent;
			GridEditMode gridEditMode = (backpackContent2.GridEditModeSystem = SystemRoot.Instance.GetSystem<GridEditMode>());
			SystemRoot.Instance.GetSystem<PlayerNavigation>().CancelAllTasks();
			CountedBool.RefState refState = SystemRoot.Instance.GetSystem<CameraCollisionSystem>().FocusPlayerAvatar.AddReference();
			CameraCollisionSystem system2 = SystemRoot.Instance.GetSystem<CameraCollisionSystem>();
			Transform transform = SystemRoot.Instance._playerCamera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002649")]
		[Cpp2IlInjected.Address(RVA = "0xD2D950", Offset = "0xD2C350", VA = "0x180D2D950")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_002e
			//IL_0010: Expected O, but got I4
			InventoryNavBar inventoryNavBar = InventoryNavBar;
			int num = 0;
			if (inventoryNavBar != (UnityEngine.Object)num && GotNavBar)
			{
				InventoryNavBar.SetSelectedTab(RedirectionType.MenuInventory);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600264A")]
		[Cpp2IlInjected.Address(RVA = "0xD2EC00", Offset = "0xD2D600", VA = "0x180D2EC00")]
		private void Update()
		{
			//Discarded unreachable code: IL_0029
			if (!_navOnHold)
			{
				GameObject backpackBlocker = _backpackBlocker;
				if ((object)backpackBlocker != null)
				{
					bool hasOngoingInventoryAction = BackpackContent.HasOngoingInventoryAction;
					backpackBlocker.SetActive(hasOngoingInventoryAction);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600264B")]
		[Cpp2IlInjected.Address(RVA = "0xD2DB20", Offset = "0xD2C520", VA = "0x180D2DB20", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_009a
			_navOnHold = false;
			base.MenuNavigation.FocusNavigation.enabled = true;
			GameObject backpackBlocker = _backpackBlocker;
			int active = 0;
			backpackBlocker.SetActive((byte)active != 0);
			base.OnFocusIn();
			int num = 0;
			UiRoot.Instance._worldCanvas.RemoveNotEnoughMana();
			if (GotNavBar)
			{
				InventoryNavBar.SetSelectedTab(RedirectionType.MenuInventory);
			}
			BackpackContent.SlidingPanel.Show(andOpen: true);
			base.IsDataUpToDate = true;
			_manaBar.gameObject.SetActive(value: true);
			_content.SetActive(value: true);
			_barSlide.DoSlideIn();
		}

		[Cpp2IlInjected.Token(Token = "0x600264C")]
		[Cpp2IlInjected.Address(RVA = "0xD2DC60", Offset = "0xD2C660", VA = "0x180D2DC60", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			StopNavigation(mustStop: true);
			base.OnFocusOut(popAfterFocusOut, animate);
		}

		[Cpp2IlInjected.Token(Token = "0x600264D")]
		[Cpp2IlInjected.Address(RVA = "0xD2DDF0", Offset = "0xD2C7F0", VA = "0x180D2DDF0", Slot = "26")]
		public override void OnPop()
		{
			if (!_popped)
			{
				Coroutine waitForFocusCoroutine = _waitForFocusCoroutine;
				_popped = true;
				if (waitForFocusCoroutine != null)
				{
					StopCoroutine(waitForFocusCoroutine);
				}
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600264E")]
		[Cpp2IlInjected.Address(RVA = "0xD2E3F0", Offset = "0xD2CDF0", VA = "0x180D2E3F0")]
		[AsyncStateMachine(typeof(_003CPopTask_003Ed__21))]
		private Task PopTask()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600264F")]
		[Cpp2IlInjected.Address(RVA = "0xD2E4E0", Offset = "0xD2CEE0", VA = "0x180D2E4E0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_008d
			((object)this)._002Ector();
			int num = 0;
			UnityEvent onSomethingConsumed = UiRoot.Instance.Dispatcher.OnSomethingConsumed;
			UnityAction call = OnSomethingConsumed;
			onSomethingConsumed.AddListener(call);
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChanged;
			focusNavigation.OnFocusChanged += value;
			ManaBar manaBar = _manaBar;
			ManaBar.AnimationStarted value2 = OnManaAnimationStarted;
			manaBar.OnAnimationStarted += value2;
			ManaBar manaBar2 = _manaBar;
			ManaBar.AnimationStopped value3 = OnManaAnimationStopped;
			manaBar2.OnAnimationStopped += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002650")]
		[Cpp2IlInjected.Address(RVA = "0xD2E9D0", Offset = "0xD2D3D0", VA = "0x180D2E9D0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_008d
			base.UnregisterFocusedListeners();
			int num = 0;
			UnityEvent onSomethingConsumed = UiRoot.Instance.Dispatcher.OnSomethingConsumed;
			UnityAction call = OnSomethingConsumed;
			onSomethingConsumed.RemoveListener(call);
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChanged;
			focusNavigation.OnFocusChanged -= value;
			ManaBar manaBar = _manaBar;
			ManaBar.AnimationStarted value2 = OnManaAnimationStarted;
			manaBar.OnAnimationStarted -= value2;
			ManaBar manaBar2 = _manaBar;
			ManaBar.AnimationStopped value3 = OnManaAnimationStopped;
			manaBar2.OnAnimationStopped -= value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002651")]
		[Cpp2IlInjected.Address(RVA = "0xD2DCB0", Offset = "0xD2C6B0", VA = "0x180D2DCB0")]
		private void OnManaAnimationStarted(float changes)
		{
			//Discarded unreachable code: IL_0010
			//IL_0004: Invalid comparison between F4 and I4
			int num = 0;
			if (!(changes <= (float)num) && _gainManaStartedSfx == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002652")]
		[Cpp2IlInjected.Address(RVA = "0xD2DD50", Offset = "0xD2C750", VA = "0x180D2DD50")]
		private void OnManaAnimationStopped(float changes)
		{
			//Discarded unreachable code: IL_0010
			//IL_0004: Invalid comparison between F4 and I4
			int num = 0;
			if (!(changes <= (float)num) && _gainManaStoppedSfx == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002653")]
		[Cpp2IlInjected.Address(RVA = "0xD2E8C0", Offset = "0xD2D2C0", VA = "0x180D2E8C0")]
		private void StopNavigation(bool mustStop)
		{
			//Discarded unreachable code: IL_005a
			_navOnHold = mustStop;
			base.MenuNavigation.FocusNavigation.enabled = mustStop;
			_backpackBlocker.SetActive(mustStop);
			if (mustStop)
			{
				Coroutine waitForFocusCoroutine = _waitForFocusCoroutine;
				if (waitForFocusCoroutine != null)
				{
					StopCoroutine(waitForFocusCoroutine);
				}
				int _003C_003E1__state = default(int);
				_003CWaitForFocus_003Ed__27 _003CWaitForFocus_003Ed__ = new _003CWaitForFocus_003Ed__27(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CWaitForFocus_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (_waitForFocusCoroutine = StartCoroutine(_003CWaitForFocus_003Ed__));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002654")]
		[Cpp2IlInjected.Address(RVA = "0xD2EC60", Offset = "0xD2D660", VA = "0x180D2EC60")]
		[IteratorStateMachine(typeof(_003CWaitForFocus_003Ed__27))]
		private IEnumerator WaitForFocus()
		{
			int _003C_003E1__state = default(int);
			_003CWaitForFocus_003Ed__27 _003CWaitForFocus_003Ed__ = new _003CWaitForFocus_003Ed__27(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForFocus_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002655")]
		[Cpp2IlInjected.Address(RVA = "0xD2E3E0", Offset = "0xD2CDE0", VA = "0x180D2E3E0")]
		private void OnSomethingConsumed()
		{
			StopNavigation(mustStop: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002656")]
		[Cpp2IlInjected.Address(RVA = "0xD2D670", Offset = "0xD2C070", VA = "0x180D2D670", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0075
			//IL_005f: Expected O, but got I4
			if (redirectionType == RedirectionType.InventoryToHud)
			{
				int num = 0;
				KeepVisible = false;
				RedirectionManager redirection = UiRoot.Instance.Redirection;
				int num2 = 0;
				return;
			}
			if (redirectionType != RedirectionType.MenuNavGoBackward)
			{
				while (redirectionType != RedirectionType.GamePopCurrentMenu)
				{
				}
			}
			if (!BackpackContent.HasOngoingInventoryAction)
			{
				int num3 = 0;
				InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
				int num4 = 0;
				if (!(menu != (UnityEngine.Object)num4))
				{
					IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
				}
				else
				{
					menu.ShouldPop = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002657")]
		[Cpp2IlInjected.Address(RVA = "0xD2D800", Offset = "0xD2C200", VA = "0x180D2D800", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_00a6
			//IL_001d: Expected I4, but got I8
			//IL_0036: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			base.OnControllerChanged();
			BackpackContent backpackContent = BackpackContent;
			((InventoryContent)backpackContent)._selectedSlotId = -1;
			int ignoreSelected = 0;
			backpackContent.RefreshAllSelectedState((byte)ignoreSelected != 0);
			BackpackContent backpackContent2 = BackpackContent;
			int num = 0;
			((InventoryContent)backpackContent2).FocusedElement = (FocusNavigationElement)num;
			LoopScrollRect list = ((InventoryContent)backpackContent2)._list;
			int num2 = (list.SelectedIndex = LoopScrollRect.INVALID_INDEX);
			int ignoreSelected2 = 0;
			backpackContent2.RefreshAllSelectedState((byte)ignoreSelected2 != 0);
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num3 = 0;
			focusNavigation.SetFocus((FocusNavigationElement)num3);
			EventSystem eventSystem = _eventSystem;
			int num4 = 0;
			eventSystem.SetSelectedGameObject((GameObject)num4);
			int num5 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002658")]
		[Cpp2IlInjected.Address(RVA = "0xD2E7E0", Offset = "0xD2D1E0", VA = "0x180D2E7E0")]
		public void SetFocus()
		{
			//IL_0010: Expected O, but got I4
			//IL_003e: Expected O, but got I8
			FocusNavigationElement lastFocusedElement = _lastFocusedElement;
			int num = 0;
			if (!(lastFocusedElement != (UnityEngine.Object)num))
			{
				BackpackContent.SetFocus();
				return;
			}
			FocusNavigation focusNavigation = base.FocusNavigation;
			FocusNavigationElement lastFocusedElement2 = _lastFocusedElement;
			focusNavigation.SetFocus(lastFocusedElement2);
			_lastFocusedElement = (FocusNavigationElement)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002659")]
		[Cpp2IlInjected.Address(RVA = "0xD2EBB0", Offset = "0xD2D5B0", VA = "0x180D2EBB0")]
		private void UpdateBlocker()
		{
			//Discarded unreachable code: IL_0020
			GameObject backpackBlocker = _backpackBlocker;
			if ((object)backpackBlocker != null)
			{
				bool hasOngoingInventoryAction = BackpackContent.HasOngoingInventoryAction;
				backpackBlocker.SetActive(hasOngoingInventoryAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600265A")]
		[Cpp2IlInjected.Address(RVA = "0xD2E6C0", Offset = "0xD2D0C0", VA = "0x180D2E6C0")]
		public void SendFocusToInventoryTabs(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_0046
			//IL_001f: Expected O, but got I4
			if (direction == FocusDirection.Left)
			{
				int num = 0;
				InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
				int num2 = 0;
				if (menu != (UnityEngine.Object)num2)
				{
					_lastFocusedElement = currentElement;
					FocusNavigation focusNavigation = base.FocusNavigation;
					FocusNavigationElement component = menu.CurrentSelection.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600265B")]
		[Cpp2IlInjected.Address(RVA = "0xD2D9F0", Offset = "0xD2C3F0", VA = "0x180D2D9F0")]
		private void OnFocusChanged(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_0036
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Transform parent = base.transform;
				Transform transform = default(Transform);
				if (transform.IsChildOf(parent))
				{
					_lastFocusedElement = (FocusNavigationElement)focusedElement;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600265C")]
		[Cpp2IlInjected.Address(RVA = "0xD2ECD0", Offset = "0xD2D6D0", VA = "0x180D2ECD0")]
		public InventoryMenu()
		{
		}
	}
}
