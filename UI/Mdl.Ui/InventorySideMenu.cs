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
using Mdl.Avatar;
using Mdl.Cameras;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005D9")]
	public class InventorySideMenu : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002089")]
		[SerializeField]
		private InventoryNavBar _inventoryNavBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400208A")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400208B")]
		[SerializeField]
		private GameObject _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400208C")]
		public MainMenuTabButton BackpackTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400208D")]
		public MainMenuTabButton WardrobeTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400208E")]
		public MainMenuTabButton FurnitureTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400208F")]
		public MainMenuTabButton PhoneTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002090")]
		public List<MainMenuTabButton> _listOfActiveButton = (List<MainMenuTabButton>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002091")]
		[SerializeField]
		private ManaBar _manaBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002092")]
		[SerializeField]
		private XpBar _xpBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002093")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002094")]
		public bool ShouldPop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x129")]
		[Cpp2IlInjected.Token(Token = "0x4002095")]
		private bool _isFirstFocus = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002096")]
		private MenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002097")]
		private CancellationTokenSource cameraMovementCTS = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002098")]
		private Task cameraTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002099")]
		private RedirectionType _redirectionFromPush;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400209B")]
		private Task redirectTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400209C")]
		private Task popTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400209D")]
		internal Toolbox.TemporarySwitchToolScope switchToolScope;

		[Cpp2IlInjected.Token(Token = "0x170005DE")]
		public MainMenuTabButton CurrentSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6002666")]
			[Cpp2IlInjected.Address(RVA = "0x975C80", Offset = "0x974680", VA = "0x180975C80")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentSelection_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002667")]
			[Cpp2IlInjected.Address(RVA = "0x976520", Offset = "0x974F20", VA = "0x180976520")]
			[CompilerGenerated]
			set
			{
				_003CCurrentSelection_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002668")]
		[Cpp2IlInjected.Address(RVA = "0xD30260", Offset = "0xD2EC60", VA = "0x180D30260")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0022
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			MenuStack.CurrentMenuChanged value = OnMenuChanged;
			menuStack.OnCurrentMenuChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002669")]
		[Cpp2IlInjected.Address(RVA = "0xD301C0", Offset = "0xD2EBC0", VA = "0x180D301C0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0022
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			MenuStack.CurrentMenuChanged value = OnMenuChanged;
			menuStack.OnCurrentMenuChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x600266A")]
		[Cpp2IlInjected.Address(RVA = "0xD305A0", Offset = "0xD2EFA0", VA = "0x180D305A0")]
		private void OnMenuChanged(IMenu menu)
		{
			//Discarded unreachable code: IL_0075
			//IL_0029: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			//IL_0067: Expected F4, but got I4
			if (menu == this)
			{
				return;
			}
			if (menu != null)
			{
				int num = 0;
				if (menu != null)
				{
					return;
				}
			}
			int num2 = 0;
			DecalMenu menu2 = UiRoot.Instance._menuStack.GetMenu<DecalMenu>();
			int num3 = 0;
			if (!(menu2 == (UnityEngine.Object)num3))
			{
			}
			int num4 = 0;
			PresentPopUp menu3 = UiRoot.Instance._menuStack.GetMenu<PresentPopUp>();
			int num5 = 0;
			bool flag = menu3 == (UnityEngine.Object)num5;
			CanvasGroup canvasGroup = _canvasGroup;
			if (flag)
			{
			}
			int num6 = 0;
			canvasGroup.alpha = num6;
			_canvasGroup.interactable = flag;
		}

		[Cpp2IlInjected.Token(Token = "0x600266B")]
		[Cpp2IlInjected.Address(RVA = "0xD31660", Offset = "0xD30060", VA = "0x180D31660")]
		private void Update()
		{
			//Discarded unreachable code: IL_004e
			if (!ShouldPop)
			{
				InventoryNavBar inventoryNavBar = _inventoryNavBar;
				MainMenuTabButton mainMenuTabButton = CurrentSelection;
				MainMenuTabButton selectedTab = inventoryNavBar.SelectedTab;
				if (!(mainMenuTabButton != selectedTab))
				{
					return;
				}
			}
			bool flag = default(bool);
			if (flag && redirectTask.IsCompleted)
			{
				CancellationToken cancellationToken = base.CancellationToken;
				int num = 0;
				Task task = default(Task);
				popTask = task;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600266C")]
		[Cpp2IlInjected.Address(RVA = "0xD30EC0", Offset = "0xD2F8C0", VA = "0x180D30EC0")]
		[AsyncStateMachine(typeof(_003CPopTabAsync_003Ed__28))]
		private Task PopTabAsync(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600266D")]
		[Cpp2IlInjected.Address(RVA = "0xD30870", Offset = "0xD2F270", VA = "0x180D30870", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//IL_0058: Expected I4, but got O
			//IL_0092: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			base.OnPush(stack, param);
			TemporaryCameraTransition component = SystemRoot.Instance._playerCamera.GetComponent<TemporaryCameraTransition>();
			if ((object)component != null)
			{
				int force = 0;
				component.StartTransition((byte)force != 0);
			}
			if (param == null)
			{
				_param = param;
			}
			_param = param;
			object[] @params = param.Params;
			int num = @params.Length - 1;
			object obj = @params[num];
			_redirectionFromPush = (RedirectionType)obj;
			base.gameObject.SetActive(value: true);
			_focusNavigation.IsPaused = false;
			XpBar xpBar = _xpBar;
			KeepVisible = true;
			ShouldPop = false;
			int num2 = 0;
			if (xpBar != (UnityEngine.Object)num2)
			{
				GameObject gameObject = _xpBar.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			ManaBar manaBar = _manaBar;
			int num3 = 0;
			if (manaBar != (UnityEngine.Object)num3)
			{
				GameObject gameObject2 = _manaBar.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
			}
			SystemRoot.Instance.GetSystem<PlayerNavigation>().CancelAllTasks();
			List<MainMenuTabButton> listOfActiveButton = _listOfActiveButton;
			_isFirstFocus = true;
			((List<T>)(object)listOfActiveButton).Clear();
			if (BackpackTabButton.gameObject.activeInHierarchy)
			{
				List<MainMenuTabButton> listOfActiveButton2 = _listOfActiveButton;
				MainMenuTabButton backpackTabButton = BackpackTabButton;
				((List<T>)(object)listOfActiveButton2).Add((T)backpackTabButton);
			}
			if (FurnitureTabButton.gameObject.activeInHierarchy)
			{
				List<MainMenuTabButton> listOfActiveButton3 = _listOfActiveButton;
				MainMenuTabButton furnitureTabButton = FurnitureTabButton;
				((List<T>)(object)listOfActiveButton3).Add((T)furnitureTabButton);
			}
			if (WardrobeTabButton.gameObject.activeInHierarchy)
			{
				List<MainMenuTabButton> listOfActiveButton4 = _listOfActiveButton;
				MainMenuTabButton wardrobeTabButton = WardrobeTabButton;
				((List<T>)(object)listOfActiveButton4).Add((T)wardrobeTabButton);
			}
			int num4 = 0;
			UiRoot.Instance._menuStack.GetMenu<HudMenu>().ClearHudItemNotif();
			Toolbox _003CToolbox_003Ek__BackingField = SystemRoot.Instance._avatar.Toolbox;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600266E")]
		[Cpp2IlInjected.Address(RVA = "0xD30300", Offset = "0xD2ED00", VA = "0x180D30300", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0119
			//IL_002a: Expected I4, but got I8
			//IL_003a: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_010c: Expected F4, but got I4
			if (ShouldPop)
			{
				KeepVisible = false;
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
				return;
			}
			base.OnFocusIn();
			ulong num = default(ulong);
			_focusNavigation.enabled = (byte)num != 0;
			MainMenuTabButton backpackTabButton = BackpackTabButton;
			int num2 = 0;
			if (backpackTabButton != (UnityEngine.Object)num2)
			{
				MainMenuTabButton wardrobeTabButton = WardrobeTabButton;
				int num3 = 0;
				if (wardrobeTabButton != (UnityEngine.Object)num3)
				{
					MainMenuTabButton furnitureTabButton = FurnitureTabButton;
					int num4 = 0;
					if (furnitureTabButton != (UnityEngine.Object)num4)
					{
						MainMenuTabButton phoneTabButton = PhoneTabButton;
						int num5 = 0;
						if (phoneTabButton != (UnityEngine.Object)num5)
						{
							((TemplateButton)BackpackTabButton).UseHighlightWhenSelected = false;
							((TemplateButton)WardrobeTabButton).UseHighlightWhenSelected = false;
							((TemplateButton)FurnitureTabButton).UseHighlightWhenSelected = false;
						}
					}
				}
			}
			if (!_isFirstFocus)
			{
				int num6 = 0;
				RefreshSelectedAndHighlight((ItemFilterData)num6);
			}
			InventoryNavBar inventoryNavBar = _inventoryNavBar;
			_isFirstFocus = false;
			RedirectionType redirectionFromPush = _redirectionFromPush;
			InventoryNavBar inventoryNavBar2 = _inventoryNavBar;
			if (redirectionFromPush == RedirectionType.MenuCatalog)
			{
			}
			if (redirectionFromPush != RedirectionType.MenuWardrobe)
			{
			}
			MainMenuTabButton mainMenuTabButton = (CurrentSelection = inventoryNavBar2.WardrobeButton);
			int num7 = 0;
			Invoke("RefreshSelectedAndHighlightFromRedirect", num7);
			_focusNavigation.IsPaused = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600266F")]
		[Cpp2IlInjected.Address(RVA = "0xD30570", Offset = "0xD2EF70", VA = "0x180D30570", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0015
			base.OnFocusOut(popAfterFocusOut, animate);
			_focusNavigation.IsPaused = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002670")]
		[Cpp2IlInjected.Address(RVA = "0xD30750", Offset = "0xD2F150", VA = "0x180D30750", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0033
			//IL_0032: Expected O, but got I4
			SystemRoot.Instance._playerCamera.GetComponent<TemporaryCameraTransition>()?.EndTransition(1f);
			base.OnPop();
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				switchToolScope = (Toolbox.TemporarySwitchToolScope)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002671")]
		[Cpp2IlInjected.Address(RVA = "0xD2FE70", Offset = "0xD2E870", VA = "0x180D2FE70")]
		private ItemFilterData GetPushRedirectionFilter()
		{
			while (true)
			{
				MenuParam param = _param;
				if (param == null)
				{
					break;
				}
				int num = 0;
				if (param == null || param == null)
				{
					if (param == null)
					{
						break;
					}
					int num2 = 0;
					if (param == null || num2 == 0)
					{
						break;
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002672")]
		[Cpp2IlInjected.Address(RVA = "0xD30040", Offset = "0xD2EA40", VA = "0x180D30040", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0038, IL_0051, IL_0068, IL_0071, IL_0093, IL_00a0, IL_00ad
			//IL_0037: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			base.OnControllerChanged();
			MainMenuTabButton mainMenuTabButton = CurrentSelection;
			FocusNavigation focusNavigation = _focusNavigation;
			FocusNavigationElement focusNavigationElement = (FocusNavigationElement)(focusNavigation.FocusedElement = mainMenuTabButton.GetComponent<FocusNavigationElement>());
			CurrentSelection.IsSelected = true;
			int num = 0;
			RefreshSelectedAndHighlight((ItemFilterData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002673")]
		[Cpp2IlInjected.Address(RVA = "0xD2FD60", Offset = "0xD2E760", VA = "0x180D2FD60")]
		public void ClearSelectedAndHighlight()
		{
			//Discarded unreachable code: IL_0071
			MainMenuTabButton backpackTabButton = BackpackTabButton;
			int num = ((backpackTabButton.IsSelected = false) ? 1 : 0);
			MainMenuTabButton furnitureTabButton = FurnitureTabButton;
			int num2 = ((furnitureTabButton.IsSelected = false) ? 1 : 0);
			MainMenuTabButton wardrobeTabButton = WardrobeTabButton;
			int num3 = ((wardrobeTabButton.IsSelected = false) ? 1 : 0);
			MainMenuTabButton backpackTabButton2 = BackpackTabButton;
			int num4 = ((backpackTabButton2.IsHighlighted = false) ? 1 : 0);
			MainMenuTabButton furnitureTabButton2 = FurnitureTabButton;
			int num5 = ((furnitureTabButton2.IsHighlighted = false) ? 1 : 0);
			MainMenuTabButton wardrobeTabButton2 = WardrobeTabButton;
			int num6 = ((wardrobeTabButton2.IsHighlighted = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002674")]
		[Cpp2IlInjected.Address(RVA = "0xD30FC0", Offset = "0xD2F9C0", VA = "0x180D30FC0")]
		private void RefreshSelectedAndHighlightFromRedirect()
		{
			//IL_002c: Expected O, but got I4
			MenuParam param = _param;
			if (param != null)
			{
				int num = 0;
				if (param != null && param != null)
				{
					goto IL_0025;
				}
				if (param != null)
				{
					int num2 = 0;
					if (param != null && param != null)
					{
						goto IL_0025;
					}
				}
			}
			int num3 = 0;
			goto IL_0025;
			IL_0025:
			RefreshSelectedAndHighlight((ItemFilterData)num3);
		}

		[Cpp2IlInjected.Token(Token = "0x6002675")]
		[Cpp2IlInjected.Address(RVA = "0xD310A0", Offset = "0xD2FAA0", VA = "0x180D310A0")]
		public void RefreshSelectedAndHighlight([Optional] ItemFilterData filter)
		{
			//Discarded unreachable code: IL_0190
			//IL_00d9: Expected O, but got I4
			MainMenuTabButton backpackTabButton = BackpackTabButton;
			int num = ((backpackTabButton.IsSelected = false) ? 1 : 0);
			MainMenuTabButton furnitureTabButton = FurnitureTabButton;
			int num2 = ((furnitureTabButton.IsSelected = false) ? 1 : 0);
			MainMenuTabButton wardrobeTabButton = WardrobeTabButton;
			int num3 = ((wardrobeTabButton.IsSelected = false) ? 1 : 0);
			MainMenuTabButton backpackTabButton2 = BackpackTabButton;
			int num4 = ((backpackTabButton2.IsHighlighted = false) ? 1 : 0);
			MainMenuTabButton furnitureTabButton2 = FurnitureTabButton;
			int num5 = ((furnitureTabButton2.IsHighlighted = false) ? 1 : 0);
			MainMenuTabButton wardrobeTabButton2 = WardrobeTabButton;
			int num6 = ((wardrobeTabButton2.IsHighlighted = false) ? 1 : 0);
			int num7 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num8 = 0;
				if (UiRoot.Instance._menuStack.Top == this)
				{
					MainMenuTabButton mainMenuTabButton = CurrentSelection;
					FocusNavigation focusNavigation = _focusNavigation;
					FocusNavigationElement _003CFocusNavigationElement_003Ek__BackingField = ((TemplateButton)mainMenuTabButton).FocusNavigationElement;
					focusNavigation.SetFocus(_003CFocusNavigationElement_003Ek__BackingField);
				}
			}
			ShortcutDefinition shortcutDefinition = CurrentSelection.ShortcutDefinition;
			int num9 = 0;
			if (shortcutDefinition != (UnityEngine.Object)num9)
			{
				InventoryNavBar inventoryNavBar = _inventoryNavBar;
				int num10 = 0;
				MainMenuTabButton navTabButton = CurrentSelection;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				int num11 = 0;
				IMenu bottom = menuStack.Bottom;
				int num12 = 0;
				int num13 = 0;
				int num14 = 0;
				CancellationToken ct = default(CancellationToken);
				Task task = (redirectTask = inventoryNavBar.RedirectTask(navTabButton, ct, filter));
				MenuParam param = _param;
				if (param != null)
				{
					int num15 = 0;
					if (param != null && num15 != 0)
					{
						Task task2 = redirectTask;
						int _003C_003E1__state = default(int);
						_003CCollectionRedirectionCoroutine_003Ed__38 _003CCollectionRedirectionCoroutine_003Ed__ = new _003CCollectionRedirectionCoroutine_003Ed__38(_003C_003E1__state);
						_003C_003E1__state = 0;
						_003CCollectionRedirectionCoroutine_003Ed__.redirectTask = task2;
						Coroutine coroutine = StartCoroutine(_003CCollectionRedirectionCoroutine_003Ed__);
					}
				}
			}
			CurrentSelection.IsSelected = true;
			GameObject gameObject = PhoneTabButton.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002676")]
		[Cpp2IlInjected.Address(RVA = "0xD2FE00", Offset = "0xD2E800", VA = "0x180D2FE00")]
		[IteratorStateMachine(typeof(_003CCollectionRedirectionCoroutine_003Ed__38))]
		private IEnumerator CollectionRedirectionCoroutine(Task redirectTask)
		{
			int _003C_003E1__state = default(int);
			_003CCollectionRedirectionCoroutine_003Ed__38 _003CCollectionRedirectionCoroutine_003Ed__ = new _003CCollectionRedirectionCoroutine_003Ed__38(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCollectionRedirectionCoroutine_003Ed__.redirectTask = redirectTask;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002677")]
		[Cpp2IlInjected.Address(RVA = "0xD2FF50", Offset = "0xD2E950", VA = "0x180D2FF50")]
		public FocusNavigationElement GetSelectedTab()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002678")]
		[Cpp2IlInjected.Address(RVA = "0xD31480", Offset = "0xD2FE80", VA = "0x180D31480")]
		public void SendFocusBakToContent(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_004a
			if (direction != FocusDirection.Right)
			{
				return;
			}
			int num = 0;
			IMenu top = UiRoot.Instance._menuStack.Top;
			if (top != null)
			{
				int num2 = 0;
				if (top == null)
				{
					int num3 = 0;
					if (top == null)
					{
						int num4 = 0;
						if (top == null)
						{
							goto IL_0036;
						}
					}
				}
				FocusNavigation focusNavigation = default(FocusNavigation);
				focusNavigation.MarkFocusNavigationHandled(FocusDirection.Right, input);
			}
			goto IL_0036;
			IL_0036:
			CurrentSelection.IsSelected = true;
			currentElement.CustomFocusHandled = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002679")]
		[Cpp2IlInjected.Address(RVA = "0xD31850", Offset = "0xD30250", VA = "0x180D31850")]
		public InventorySideMenu()
		{
			int num = 0;
			redirectTask = Task.CompletedTask;
			int num2 = 0;
			popTask = Task.CompletedTask;
			base._002Ector();
		}
	}
}
