using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Mdl.RewiredConsts;
using Rewired;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000248")]
	public class FocusNavigation : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000249")]
		public delegate void FocusChanged(ISupportsFocusNavigation menu);

		[Cpp2IlInjected.Token(Token = "0x200024A")]
		public delegate void HandlingFocusChanged(bool isFocused);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A2C")]
		[Tooltip("Send focus to the initial focused element or any other element when this component is enabled")]
		[Header("Focus Handling")]
		public bool SetFocusOnEnable = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000A2D")]
		[Tooltip("Start navigation from the top when no element is selected")]
		public bool RestoreFocusWhenLost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A2E")]
		[Tooltip("Set focus to this element initially and when changing to controller if nothing is focused, when unset will use the first active FocusNavigationElement")]
		public FocusNavigationElement InitialFocusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000A2F")]
		[Header("Input Configuration")]
		public bool IsKeyboardAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000A30")]
		public bool IsAxisYAltInverted = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000A31")]
		public bool SupportInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000A32")]
		public float DefaultInterval = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A33")]
		public float MinInterval = 0.05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000A34")]
		public float StickInputThreshold = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000A35")]
		[Header("Keyboard Input Definitions")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int KeyboardLeft = 188;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000A36")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int KeyboardRight = 189;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000A37")]
		public ShortcutDefinition KeyboardClickFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000A38")]
		private List<int> supportedKeyInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000A39")]
		[Header("Gamepad Input Definitions")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisX = 144;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000A3A")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisY = 145;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000A3B")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisXAlt = 148;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000A3C")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisYAlt = 149;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000A3D")]
		public ShortcutDefinition GamepadClickFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000A3E")]
		private List<int> supportedAxisInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000A3F")]
		[Header("Runtime")]
		public bool IsPaused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4000A40")]
		public bool IsMovementPaused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000A41")]
		public bool IgnoreThrobber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000A44")]
		private ISupportsFocusNavigation _focusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000A45")]
		private ISupportsFocusNavigation _lastFocusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000A46")]
		private Menu _currentMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000A47")]
		private UiRoot _uiRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000A48")]
		private Rewired.Player _player;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000A49")]
		private float _waitTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000A4A")]
		private int _currentInput = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000A4B")]
		private FocusDirection _currentDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000A4C")]
		private bool _processedOnFocusUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBD")]
		[Cpp2IlInjected.Token(Token = "0x4000A4D")]
		private bool _isAnyKeyOnHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBE")]
		[Cpp2IlInjected.Token(Token = "0x4000A4E")]
		private bool _ignoreClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBF")]
		[Cpp2IlInjected.Token(Token = "0x4000A4F")]
		private bool _isHandlingFocus;

		[Cpp2IlInjected.Token(Token = "0x170002CB")]
		public ISupportsFocusNavigation FocusedElement
		{
			[Cpp2IlInjected.Token(Token = "0x6000E6F")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return _focusedElement;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E70")]
			[Cpp2IlInjected.Address(RVA = "0x166BFF0", Offset = "0x166A9F0", VA = "0x18166BFF0")]
			set
			{
				//Discarded unreachable code: IL_0059
				ISupportsFocusNavigation focusedElement = _focusedElement;
				if (focusedElement != null)
				{
					int num = 0;
					if (focusedElement != null)
					{
						EventHandler value2 = CurrentFocusedElementDestroyed;
						DestroyEventProvider destroyEventProvider = default(DestroyEventProvider);
						destroyEventProvider.DestroyEvent -= value2;
					}
				}
				_focusedElement = value;
				ISupportsFocusNavigation focusedElement2 = _focusedElement;
				if (focusedElement2 != null)
				{
					int num2 = 0;
					if (focusedElement2 != null)
					{
						EventHandler value3 = CurrentFocusedElementDestroyed;
						DestroyEventProvider destroyEventProvider2 = default(DestroyEventProvider);
						destroyEventProvider2.DestroyEvent += value3;
					}
				}
				[Cpp2IlInjected.Token(Token = "0x6000E90")]
				[Cpp2IlInjected.Address(RVA = "0x166B7A0", Offset = "0x166A1A0", VA = "0x18166B7A0")]
				void CurrentFocusedElementDestroyed(object sender, EventArgs e)
				{
					//IL_0009: Expected O, but got I4
					int num3 = 0;
					FocusedElement = (ISupportsFocusNavigation)num3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CC")]
		private bool CanInteract
		{
			[Cpp2IlInjected.Token(Token = "0x6000E71")]
			[Cpp2IlInjected.Address(RVA = "0x166BC30", Offset = "0x166A630", VA = "0x18166BC30")]
			get
			{
				//IL_0033: Expected O, but got I4
				if (base.gameObject.activeInHierarchy && !IsPaused && !IsMovementPaused)
				{
					Menu currentMenu = _currentMenu;
					int num = 0;
					if (currentMenu != (UnityEngine.Object)num)
					{
						Menu currentMenu2 = _currentMenu;
						if (currentMenu2._isFocused && !currentMenu2._isInFocusOutAnimation && !_uiRoot._throbber.Visible)
						{
							UiRoot uiRoot = _uiRoot;
							Menu currentMenu3 = _currentMenu;
							int ignoreThrobber = 0;
							return uiRoot.IsOnTop(currentMenu3, (byte)ignoreThrobber != 0);
						}
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CD")]
		public bool IsOpenDropdown
		{
			[Cpp2IlInjected.Token(Token = "0x6000E72")]
			[Cpp2IlInjected.Address(RVA = "0x166BDE0", Offset = "0x166A7E0", VA = "0x18166BDE0")]
			get
			{
				//IL_001e: Expected O, but got I4
				ISupportsFocusNavigation focusedElement = _focusedElement;
				if (focusedElement == null)
				{
					int num = 0;
				}
				int num2 = 0;
				if (focusedElement != null)
				{
				}
				int num3 = 0;
				DropDownMenuItem dropDownMenuItem = default(DropDownMenuItem);
				return dropDownMenuItem != (UnityEngine.Object)num3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CE")]
		public bool IsHandlingFocus
		{
			[Cpp2IlInjected.Token(Token = "0x6000E79")]
			[Cpp2IlInjected.Address(RVA = "0x166BDD0", Offset = "0x166A7D0", VA = "0x18166BDD0")]
			get
			{
				return _isHandlingFocus;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E7A")]
			[Cpp2IlInjected.Address(RVA = "0x166C1C0", Offset = "0x166ABC0", VA = "0x18166C1C0")]
			set
			{
				//IL_0041: Expected O, but got I4
				if (value == _isHandlingFocus)
				{
					return;
				}
				_isHandlingFocus = value;
				if (!value)
				{
					ISupportsFocusNavigation supportsFocusNavigation = (_lastFocusedElement = _focusedElement);
					ISupportsFocusNavigation focusedElement = _focusedElement;
					ISupportsFocusNavigation focusedElement2 = _focusedElement;
					if (focusedElement2 == null || focusedElement2 != focusedElement)
					{
						goto IL_0049;
					}
					int num = 0;
					FocusedElement = (ISupportsFocusNavigation)num;
				}
				bool flag = RestoreFocus();
				goto IL_0049;
				IL_0049:
				HandlingFocusChanged onHandlingFocusChanged = this.OnHandlingFocusChanged;
				if (onHandlingFocusChanged != null)
				{
					bool isHandlingFocus = _isHandlingFocus;
					onHandlingFocusChanged(isHandlingFocus);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event FocusChanged OnFocusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000E6B")]
			[Cpp2IlInjected.Address(RVA = "0x166BAF0", Offset = "0x166A4F0", VA = "0x18166BAF0")]
			[CompilerGenerated]
			add
			{
				FocusChanged onFocusChanged = this.OnFocusChanged;
				Delegate @delegate = Delegate.Combine(onFocusChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFocusChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000E6C")]
			[Cpp2IlInjected.Address(RVA = "0x166BEB0", Offset = "0x166A8B0", VA = "0x18166BEB0")]
			[CompilerGenerated]
			remove
			{
				FocusChanged onFocusChanged = this.OnFocusChanged;
				Delegate @delegate = Delegate.Remove(onFocusChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFocusChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event HandlingFocusChanged OnHandlingFocusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000E6D")]
			[Cpp2IlInjected.Address(RVA = "0x166BB90", Offset = "0x166A590", VA = "0x18166BB90")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000E6E")]
			[Cpp2IlInjected.Address(RVA = "0x166BF50", Offset = "0x166A950", VA = "0x18166BF50")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E73")]
		[Cpp2IlInjected.Address(RVA = "0x1669130", Offset = "0x1667B30", VA = "0x181669130")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0111
			//IL_0098: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00cb: Expected O, but got I4
			//IL_00f7: Expected O, but got I4
			//IL_0108: Expected O, but got I4
			int num = 0;
			UiRoot uiRoot = (_uiRoot = UiRoot.Instance);
			int num2 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Rewired.Player player = (_player = players.GetPlayer(playerId));
			if ((long)_currentMenu == 0)
			{
				Menu menu = (_currentMenu = GetComponentInParent<Menu>());
			}
			if (!GetComponent<Menu>())
			{
				string fullPath = this.GetFullPath();
				Debug.LogWarning("[UI][" + fullPath + "] This FocusNavigation is not set on a Menu, which can lead to duplicated movement.", this);
			}
			if ((long)supportedAxisInputs == 0)
			{
				List<int> list = (List<int>)(object)new List<T>(4);
				int rewiredAxisX = RewiredAxisX;
				((List<T>)(object)list).Add((T)rewiredAxisX);
				int rewiredAxisY = RewiredAxisY;
				((List<T>)(object)list).Add((T)rewiredAxisY);
				int rewiredAxisXAlt = RewiredAxisXAlt;
				((List<T>)(object)list).Add((T)rewiredAxisXAlt);
				int rewiredAxisYAlt = RewiredAxisYAlt;
				((List<T>)(object)list).Add((T)rewiredAxisYAlt);
				supportedAxisInputs = list;
			}
			if ((long)supportedKeyInputs == 0)
			{
				List<int> list2 = (List<int>)(object)new List<T>(2);
				int keyboardLeft = KeyboardLeft;
				((List<T>)(object)list2).Add((T)keyboardLeft);
				int keyboardRight = KeyboardRight;
				((List<T>)(object)list2).Add((T)keyboardRight);
				supportedKeyInputs = list2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E74")]
		[Cpp2IlInjected.Address(RVA = "0x166B620", Offset = "0x166A020", VA = "0x18166B620")]
		private void Start()
		{
			int num = 0;
			if (Input.anyKey)
			{
				_isAnyKeyOnHold = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E75")]
		[Cpp2IlInjected.Address(RVA = "0x1669A00", Offset = "0x1668400", VA = "0x181669A00")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00c3
			UnityEvent<bool> onGenericAlertOnOff = _uiRoot.Dispatcher.OnGenericAlertOnOff;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnGenericAlertOnOff);
			((UnityEvent<T0>)(object)onGenericAlertOnOff).AddListener((UnityAction<>)(object)unityAction);
			Throbber throbber = _uiRoot._throbber;
			Throbber.VisibilityChanged value = OnThrobberVisibilityChanged;
			throbber.OnVisibilityChanged += value;
			MenuStack menuStack = _uiRoot._menuStack;
			MenuStack.CurrentMenuChanged value2 = OnAnyMenuChanged;
			menuStack.OnCurrentMenuChanged += value2;
			MenuStack popupStack = _uiRoot._popupStack;
			MenuStack.CurrentMenuChanged value3 = OnAnyMenuChanged;
			popupStack.OnCurrentMenuChanged += value3;
			MenuStack systemPromptStack = _uiRoot._systemPromptStack;
			MenuStack.CurrentMenuChanged value4 = OnAnyMenuChanged;
			systemPromptStack.OnCurrentMenuChanged += value4;
			if (SetFocusOnEnable)
			{
				bool flag = RestoreFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E76")]
		[Cpp2IlInjected.Address(RVA = "0x16697A0", Offset = "0x16681A0", VA = "0x1816697A0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_00bb
			UnityEvent<bool> onGenericAlertOnOff = _uiRoot.Dispatcher.OnGenericAlertOnOff;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnGenericAlertOnOff);
			((UnityEvent<T0>)(object)onGenericAlertOnOff).RemoveListener((UnityAction<>)(object)unityAction);
			Throbber throbber = _uiRoot._throbber;
			Throbber.VisibilityChanged value = OnThrobberVisibilityChanged;
			throbber.OnVisibilityChanged -= value;
			MenuStack menuStack = _uiRoot._menuStack;
			MenuStack.CurrentMenuChanged value2 = OnAnyMenuChanged;
			menuStack.OnCurrentMenuChanged -= value2;
			MenuStack popupStack = _uiRoot._popupStack;
			MenuStack.CurrentMenuChanged value3 = OnAnyMenuChanged;
			popupStack.OnCurrentMenuChanged -= value3;
			MenuStack systemPromptStack = _uiRoot._systemPromptStack;
			MenuStack.CurrentMenuChanged value4 = OnAnyMenuChanged;
			systemPromptStack.OnCurrentMenuChanged -= value4;
			if (_focusedElement == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E77")]
		[Cpp2IlInjected.Address(RVA = "0x166B9E0", Offset = "0x166A3E0", VA = "0x18166B9E0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0049
			//IL_0048: Expected I4, but got I8
			if (CanInteract)
			{
				bool flag = ProcessOnFocusUpdate();
				UpdateClick();
				return;
			}
			if (_currentInput > 0)
			{
				int num = 0;
				EventSystem.current.m_sendNavigationEvents = true;
			}
			_waitTime = 0f;
			_currentInput = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E78")]
		[Cpp2IlInjected.Address(RVA = "0x16695B0", Offset = "0x1667FB0", VA = "0x1816695B0")]
		private void LateUpdate()
		{
			_processedOnFocusUpdate = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7B")]
		[Cpp2IlInjected.Address(RVA = "0x1669C50", Offset = "0x1668650", VA = "0x181669C50")]
		private void OnGenericAlertOnOff(bool visible)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			OnAnyMenuChanged((IMenu)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7C")]
		[Cpp2IlInjected.Address(RVA = "0x1669C50", Offset = "0x1668650", VA = "0x181669C50")]
		private void OnThrobberVisibilityChanged()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			OnAnyMenuChanged((IMenu)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7D")]
		[Cpp2IlInjected.Address(RVA = "0x1669670", Offset = "0x1668070", VA = "0x181669670")]
		private void OnAnyMenuChanged([Optional] IMenu menu)
		{
			//Discarded unreachable code: IL_0090
			//IL_0068: Expected O, but got I4
			UiRoot uiRoot = _uiRoot;
			bool ignoreThrobber = IgnoreThrobber;
			Menu currentMenu = _currentMenu;
			bool flag = uiRoot.IsOnTop(currentMenu, ignoreThrobber);
			if (flag == _isHandlingFocus)
			{
				return;
			}
			_isHandlingFocus = flag;
			if (!flag)
			{
				ISupportsFocusNavigation supportsFocusNavigation = (_lastFocusedElement = _focusedElement);
				ISupportsFocusNavigation focusedElement = _focusedElement;
				ISupportsFocusNavigation focusedElement2 = _focusedElement;
				if (focusedElement2 == null || focusedElement2 != focusedElement)
				{
					goto IL_0070;
				}
				int num = 0;
				FocusedElement = (ISupportsFocusNavigation)num;
			}
			bool flag2 = RestoreFocus();
			goto IL_0070;
			IL_0070:
			HandlingFocusChanged onHandlingFocusChanged = this.OnHandlingFocusChanged;
			if (onHandlingFocusChanged != null)
			{
				bool isHandlingFocus = _isHandlingFocus;
				onHandlingFocusChanged(isHandlingFocus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7E")]
		[Cpp2IlInjected.Address(RVA = "0x166A620", Offset = "0x1669020", VA = "0x18166A620")]
		public bool RestoreFocus()
		{
			//IL_001e: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			ISupportsFocusNavigation focusedElement = _focusedElement;
			if (focusedElement != null)
			{
				int num = 0;
				if (focusedElement != null)
				{
				}
				int num2 = 0;
				int num3 = 0;
				if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
				{
					ISupportsFocusNavigation focusedElement2 = _focusedElement;
					if (focusedElement2 != null)
					{
						int num4 = 0;
						if (focusedElement2 != null)
						{
							DropDownMenu dropDownMenu = default(DropDownMenu);
							dropDownMenu?.CloseDropDown();
						}
					}
				}
			}
			Menu currentMenu = _currentMenu;
			int num5 = 0;
			if (currentMenu != (UnityEngine.Object)num5)
			{
				UiRoot uiRoot = _uiRoot;
				Menu currentMenu2 = _currentMenu;
				int ignoreThrobber = 0;
				if (!uiRoot.IsOnTop(currentMenu2, (byte)ignoreThrobber != 0))
				{
					goto IL_00f1;
				}
			}
			if ((object)_currentMenu != null)
			{
			}
			int num7 = default(int);
			if (!InputDetectionHelper.IsKeyboard(0 != 0))
			{
				if (_focusedElement == null && _lastFocusedElement == null)
				{
					FocusNavigationElement initialFocusedElement = InitialFocusedElement;
					if ((object)initialFocusedElement == null)
					{
						if ((IntPtr)(RestoreFocusWhenLost ? 1 : 0) != (IntPtr)initialFocusedElement)
						{
							FocusNavigationElement componentInChildren = GetComponentInChildren<FocusNavigationElement>();
						}
						if (0 == 0)
						{
							string fullPath = this.GetFullPath();
							Debug.LogWarning("[UI] FocusNavigation#RestoreFocus [" + fullPath + "] Asked to restore focus but no element that can be focused was found", this);
							int num6 = 0;
						}
					}
				}
				num7 = 0;
				return true;
			}
			goto IL_00f1;
			IL_00f1:
			if (num7 != 0 && num7 == 0)
			{
				int num8 = 0;
			}
			int num9 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7F")]
		[Cpp2IlInjected.Address(RVA = "0x166A9E0", Offset = "0x16693E0", VA = "0x18166A9E0")]
		public void SaveAndRemoveFocus()
		{
			//IL_002d: Expected O, but got I4
			ISupportsFocusNavigation supportsFocusNavigation = (_lastFocusedElement = _focusedElement);
			ISupportsFocusNavigation focusedElement = _focusedElement;
			ISupportsFocusNavigation focusedElement2 = _focusedElement;
			if (focusedElement2 != null && focusedElement2 == focusedElement)
			{
				int num = 0;
				FocusedElement = (ISupportsFocusNavigation)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E80")]
		[Cpp2IlInjected.Address(RVA = "0x1669C60", Offset = "0x1668660", VA = "0x181669C60")]
		public unsafe bool ProcessOnFocusUpdate()
		{
			//IL_002c: Invalid comparison between F4 and I4
			//IL_003e: Expected F4, but got I4
			//IL_0071: Expected F4, but got I4
			//IL_0078: Invalid comparison between F4 and I4
			//IL_0272: Expected I4, but got O
			//IL_027a: Expected I4, but got O
			int num = 0;
			if (!CanInteract || (_processedOnFocusUpdate ? 1 : 0) != num)
			{
				goto IL_00be;
			}
			float waitTime = _waitTime;
			int num2 = 0;
			_processedOnFocusUpdate = true;
			if (!(waitTime <= (float)num2))
			{
				int num3 = 0;
				float deltaTime = Time.deltaTime;
				float waitTime2 = Mathf.Max(0f, waitTime);
				int currentInput = _currentInput;
				_waitTime = waitTime2;
				if (currentInput > 0 && !(_player.GetAxis(currentInput) > StickInputThreshold))
				{
					_waitTime = num;
				}
				if (_waitTime <= (float)num2)
				{
				}
			}
			int num4 = 0;
			EventSystem.current.m_sendNavigationEvents = true;
			List<int> list = supportedAxisInputs;
			uint num5 = default(uint);
			_currentInput = (int)num5;
			if (!this.HasValidInput((IEnumerable<>)list))
			{
				List<int> list2 = supportedKeyInputs;
				if (!this.HasValidInput((IEnumerable<>)list2))
				{
					_currentDirection = (FocusDirection)num5;
					goto IL_00be;
				}
			}
			goto IL_00c1;
			IL_0137:
			int rewiredAxisX = RewiredAxisX;
			throw new NullReferenceException();
			IL_00be:
			int num6 = 0;
			goto IL_00c1;
			IL_00c1:
			int num7 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Rewired.Player player = (_player = players.GetPlayer(playerId));
			ISupportsFocusNavigation focusedElement = _focusedElement;
			if (focusedElement != null)
			{
				int num8 = 0;
				if (focusedElement == null)
				{
				}
			}
			Dictionary<FocusDirection, (int, float)> dictionary = (Dictionary<FocusDirection, (int, float)>)(object)new Dictionary<TKey, TValue>();
			int rewiredAxisX2 = RewiredAxisX;
			float num9 = default(float);
			if (!(num9 > StickInputThreshold))
			{
				ulong num10 = default(ulong);
				if (num10 != 0)
				{
					int rewiredAxisXAlt = RewiredAxisXAlt;
					int num11 = 0;
					float num12 = default(float);
					num9 = num12;
					if (!(num9 <= StickInputThreshold))
					{
						int rewiredAxisXAlt2 = RewiredAxisXAlt;
						goto IL_0137;
					}
				}
				int rewiredAxisY = RewiredAxisY;
				float num13 = default(float);
				num9 = num13;
				if (!(num9 > StickInputThreshold))
				{
					if (num10 == 0)
					{
						if ((IsKeyboardAllowed ? 1 : 0) != num)
						{
							int keyboardLeft = KeyboardLeft;
							int num14 = 0;
							bool flag = default(bool);
							if (flag)
							{
								int keyboardLeft2 = KeyboardLeft;
								throw new NullReferenceException();
							}
							int keyboardRight = KeyboardRight;
							int num15 = 0;
							bool flag2 = default(bool);
							if (flag2)
							{
								int keyboardRight2 = KeyboardRight;
								throw new NullReferenceException();
							}
						}
						_003C_003Ec _003C_003E = default(_003C_003Ec);
						Func<KeyValuePair<FocusDirection, (int, float)>, float> func = default(Func<KeyValuePair<FocusDirection, (int, float)>, float>);
						if (_003C_003Ec._003C_003E9__63_0 == null)
						{
							_003C_003E = _003C_003Ec._003C_003E9;
							func = (Func<KeyValuePair<FocusDirection, (int, float)>, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)new Func<T, TResult>(_003C_003E._003CProcessOnFocusUpdate_003Eb__63_0));
						}
						uint num16 = default(uint);
						if (_focusedElement != null && num < (int)num16)
						{
							num += num;
							num++;
						}
						FocusNavigationElement componentInChildren = default(FocusNavigationElement);
						if (num == 0)
						{
							while ((IntPtr)_focusedElement != (IntPtr)num)
							{
							}
							while ((RestoreFocusWhenLost ? 1 : 0) == num)
							{
							}
							componentInChildren = GetComponentInChildren<FocusNavigationElement>();
							while ((object)componentInChildren == null)
							{
							}
						}
						SetFocus((ISupportsFocusNavigation)componentInChildren);
						int num17 = 0;
						EventSystem.current.m_sendNavigationEvents = false;
						if (SupportInterval && (IntPtr)(void*)(int)_currentDirection == (IntPtr)func)
						{
							num17 += num17;
						}
						float num18 = (_waitTime = DefaultInterval);
						_currentInput = (int)_003C_003E;
						_currentDirection = (FocusDirection)func;
						throw new NullReferenceException();
					}
					int rewiredAxisYAlt = RewiredAxisYAlt;
					int num19 = 0;
					int rewiredAxisYAlt2 = RewiredAxisYAlt;
					num += 2;
				}
				int rewiredAxisY2 = RewiredAxisY;
				throw new NullReferenceException();
			}
			goto IL_0137;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E81")]
		[Cpp2IlInjected.Address(RVA = "0x16695C0", Offset = "0x1667FC0", VA = "0x1816695C0")]
		public void MarkFocusNavigationHandled(FocusDirection focusDirection, int input)
		{
			//Discarded unreachable code: IL_003e
			int num = 0;
			EventSystem.current.m_sendNavigationEvents = false;
			if (!SupportInterval || _currentDirection == focusDirection)
			{
			}
			float num2 = (_waitTime = DefaultInterval);
			_currentInput = input;
			_currentDirection = focusDirection;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E82")]
		[Cpp2IlInjected.Address(RVA = "0x166B680", Offset = "0x166A080", VA = "0x18166B680")]
		private bool TryMoveFocus(FocusDirection direction, int input)
		{
			ISupportsFocusNavigation focusedElement = _focusedElement;
			int num = 0;
			uint num2 = default(uint);
			if (focusedElement != null && num < (int)num2)
			{
				num += num;
				num++;
			}
			FocusNavigationElement componentInChildren = default(FocusNavigationElement);
			if (num == 0)
			{
				if ((IntPtr)_focusedElement == (IntPtr)num && (RestoreFocusWhenLost ? 1 : 0) != num)
				{
					componentInChildren = GetComponentInChildren<FocusNavigationElement>();
					if ((object)componentInChildren != null)
					{
						goto IL_0047;
					}
				}
				int num3 = 0;
				num3 += 376;
			}
			goto IL_0047;
			IL_0047:
			SetFocus((ISupportsFocusNavigation)componentInChildren);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E83")]
		[Cpp2IlInjected.Address(RVA = "0x166ACE0", Offset = "0x16696E0", VA = "0x18166ACE0")]
		public void SetNavGrid(List<List<FocusNavigationElement>> grid, bool focusFirst = true)
		{
			//Discarded unreachable code: IL_0100
			//IL_000b: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			SetFocus((ISupportsFocusNavigation)num);
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			bool flag8 = default(bool);
			bool flag4 = default(bool);
			if ((UnityEngine.Object)num3 != (UnityEngine.Object)num6)
			{
				if (focusFirst)
				{
					int num7 = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						SetFocus((ISupportsFocusNavigation)num3);
					}
				}
				bool flag = default(bool);
				if (-1 > 0 && flag)
				{
					while (-1L >= 1L)
					{
					}
				}
				bool flag2 = default(bool);
				if (-1L == -1L || !flag2)
				{
					int size = ((List<>)(object)grid)._size;
					bool flag3 = default(bool);
					if (size > 0 && flag3)
					{
						while (size >= 1)
						{
						}
					}
				}
				if (flag4)
				{
				}
				bool flag5 = default(bool);
				if (flag5)
				{
				}
				bool flag6 = default(bool);
				if (!flag6)
				{
					flag4 = flag6;
					bool flag7 = default(bool);
					if (!flag7)
					{
					}
				}
				if (flag8)
				{
				}
				bool flag9 = default(bool);
				if (-1 > 0 && flag9)
				{
					while (-1L >= 1L)
					{
					}
				}
				bool flag10 = default(bool);
				if (-1L != -1L)
				{
					flag8 = flag9;
					if (flag10)
					{
						goto IL_00ce;
					}
				}
				if (-1 > 0)
				{
					flag8 = flag10;
					bool flag11 = default(bool);
					if (flag11)
					{
						while (-1L >= 1L)
						{
						}
					}
				}
				goto IL_00ce;
			}
			goto IL_00f3;
			IL_00ce:
			bool flag12 = default(bool);
			if (flag12)
			{
			}
			flag4 = flag12;
			bool flag13 = default(bool);
			if (flag13)
			{
			}
			flag8 = flag13;
			bool flag14 = default(bool);
			if (flag14)
			{
			}
			flag4 = flag14;
			bool flag15 = default(bool);
			if (flag15)
			{
			}
			bool flag16 = default(bool);
			if (!flag16)
			{
			}
			goto IL_00f3;
			IL_00f3:
			num5++;
			num4++;
			num3 = num4;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E84")]
		[Cpp2IlInjected.Address(RVA = "0x166B7B0", Offset = "0x166A1B0", VA = "0x18166B7B0")]
		private void UpdateClick()
		{
			//Discarded unreachable code: IL_0106
			//IL_0019: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			if (IsKeyboardAllowed)
			{
				ShortcutDefinition keyboardClickFocused = KeyboardClickFocused;
				int num = 0;
				if (keyboardClickFocused != (UnityEngine.Object)num)
				{
					ShortcutDefinition keyboardClickFocused2 = KeyboardClickFocused;
					Rewired.Player player = _player;
					int rewiredActionId = keyboardClickFocused2.Self.RewiredActionId;
					if (player.GetButtonDown(rewiredActionId))
					{
						ShortcutDefinition self = KeyboardClickFocused.Self;
						Click(self);
					}
				}
			}
			if (_currentMenu._isGamepadHoldAllowed)
			{
				ShortcutDefinition gamepadClickFocused = GamepadClickFocused;
				int num2 = 0;
				if (gamepadClickFocused != (UnityEngine.Object)num2)
				{
					ShortcutDefinition gamepadClickFocused2 = GamepadClickFocused;
					Rewired.Player player2 = _player;
					int rewiredActionId2 = gamepadClickFocused2.Self.RewiredActionId;
					if (player2.GetButtonDown(rewiredActionId2))
					{
						ShortcutDefinition self2 = GamepadClickFocused.Self;
						Click(self2);
					}
				}
			}
			if (_isAnyKeyOnHold)
			{
				int num3 = 0;
				bool anyKey = Input.anyKey;
				if (!anyKey)
				{
					_isAnyKeyOnHold = anyKey;
					return;
				}
			}
			while (!_ignoreClick)
			{
			}
			while (_isAnyKeyOnHold)
			{
			}
			int num4 = 0;
			bool anyKey2 = Input.anyKey;
			while (anyKey2)
			{
			}
			_ignoreClick = anyKey2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E85")]
		[Cpp2IlInjected.Address(RVA = "0x166A450", Offset = "0x1668E50", VA = "0x18166A450")]
		internal void ReleaseClickBlocking()
		{
			if (_isAnyKeyOnHold)
			{
				int num = 0;
				bool anyKey = Input.anyKey;
				if (!anyKey)
				{
					_isAnyKeyOnHold = anyKey;
					return;
				}
			}
			if (_ignoreClick && !_isAnyKeyOnHold)
			{
				int num2 = 0;
				bool anyKey2 = Input.anyKey;
				if (!anyKey2)
				{
					_ignoreClick = anyKey2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E86")]
		[Cpp2IlInjected.Address(RVA = "0x1669400", Offset = "0x1667E00", VA = "0x181669400")]
		public void Click(ShortcutDefinition shortcut)
		{
			if (!IsPaused && !_ignoreClick && _focusedElement != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E87")]
		[Cpp2IlInjected.Address(RVA = "0x166AB00", Offset = "0x1669500", VA = "0x18166AB00")]
		public void SetFocus(ISupportsFocusNavigation target)
		{
			//Discarded unreachable code: IL_0074
			//IL_0045: Expected O, but got I4
			if (target != null)
			{
				int num = 0;
				GameObject gameObject = default(GameObject);
				if (target != null && !gameObject.activeInHierarchy)
				{
					string text = default(string);
					string text2 = "[UI] FocusNavigation#SetFocus Sending focus to a disabled object: " + text;
				}
			}
			ISupportsFocusNavigation focusedElement = _focusedElement;
			ISupportsFocusNavigation focusedElement2 = _focusedElement;
			if (focusedElement2 != null && focusedElement2 == focusedElement)
			{
				int num2 = 0;
				FocusedElement = (ISupportsFocusNavigation)num2;
			}
			FocusedElement = target;
			if (_focusedElement != null)
			{
			}
			FocusChanged onFocusChanged = this.OnFocusChanged;
			if (onFocusChanged != null)
			{
				ISupportsFocusNavigation focusedElement3 = _focusedElement;
				onFocusChanged(focusedElement3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E88")]
		[Cpp2IlInjected.Address(RVA = "0x166AAF0", Offset = "0x16694F0", VA = "0x18166AAF0")]
		public void SetFocus(FocusNavigationElement target)
		{
			SetFocus((ISupportsFocusNavigation)target);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E89")]
		[Cpp2IlInjected.Address(RVA = "0x166AAA0", Offset = "0x16694A0", VA = "0x18166AAA0")]
		public void SetFocusSafely(FocusNavigationElement target)
		{
			//Discarded unreachable code: IL_0016
			if (base.gameObject.activeInHierarchy)
			{
				SetFocus((ISupportsFocusNavigation)target);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8A")]
		[Cpp2IlInjected.Address(RVA = "0x166A5A0", Offset = "0x1668FA0", VA = "0x18166A5A0")]
		public void RemoveFocus([Optional] ISupportsFocusNavigation target)
		{
			//IL_001c: Expected O, but got I4
			if (target == null)
			{
			}
			ISupportsFocusNavigation focusedElement = _focusedElement;
			if (focusedElement != null && focusedElement == target)
			{
				int num = 0;
				FocusedElement = (ISupportsFocusNavigation)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8B")]
		[Cpp2IlInjected.Address(RVA = "0x166A5A0", Offset = "0x1668FA0", VA = "0x18166A5A0")]
		public void RemoveFocus(FocusNavigationElement target)
		{
			//IL_001c: Expected O, but got I4
			if ((object)target == null)
			{
			}
			ISupportsFocusNavigation focusedElement = _focusedElement;
			if (focusedElement != null && focusedElement == target)
			{
				int num = 0;
				FocusedElement = (ISupportsFocusNavigation)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8C")]
		[Cpp2IlInjected.Address(RVA = "0x166A500", Offset = "0x1668F00", VA = "0x18166A500")]
		public void RemoveFocusSafely(FocusNavigationElement target)
		{
			//Discarded unreachable code: IL_002b
			//IL_002a: Expected O, but got I4
			if (base.gameObject.activeInHierarchy)
			{
				if ((object)target == null)
				{
				}
				ISupportsFocusNavigation focusedElement = _focusedElement;
				if (focusedElement != null && focusedElement == target)
				{
					int num = 0;
					FocusedElement = (ISupportsFocusNavigation)num;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8D")]
		[Cpp2IlInjected.Address(RVA = "0x1669570", Offset = "0x1667F70", VA = "0x181669570")]
		private bool IsInputValid(int actionId)
		{
			float axis = _player.GetAxis(actionId);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8E")]
		[Cpp2IlInjected.Address(RVA = "0x16694D0", Offset = "0x1667ED0", VA = "0x1816694D0")]
		private bool HasValidInput(IEnumerable<int> actionIds)
		{
			Func<int, bool> cpp2il__autoParamName__idx_ = (Func<int, bool>)(object)new Func<T, TResult>(IsInputValid);
			return ((IEnumerable<>)actionIds).Any<int>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8F")]
		[Cpp2IlInjected.Address(RVA = "0x166BA90", Offset = "0x166A490", VA = "0x18166BA90")]
		public FocusNavigation()
		{
		}//IL_003c: Expected I4, but got I8
		//IL_0049: Expected I4, but got I8
		//IL_0056: Expected I4, but got I8
		//IL_0063: Expected I4, but got I8
		//IL_0070: Expected I4, but got I8
		//IL_007d: Expected I4, but got I8
		//IL_0086: Expected I4, but got I8

	}
}
