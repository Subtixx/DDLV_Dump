using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Systems;
using Meta.Util;
using Rewired;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200026D")]
	public class MenuNavigation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000AEC")]
		private bool _isInTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000AED")]
		private PlayerNavigation _playerNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000AEE")]
		private Throbber.ThrobberTransactionScope _throbberTransactionScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000AEF")]
		private Menu _currentMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000AF0")]
		private UiRoot _uiRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000AF1")]
		private GameObject _tutorialPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000AF2")]
		private GameObject _tutorialBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000AF3")]
		private List<ShortcutDefinition> _platformShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000AF4")]
		private ShortcutSetDefinition _gamepadShortcutSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000AF5")]
		private List<ShortcutDefinition> _gamepadShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000AF6")]
		private List<ShortcutIndicatorTemplate> _gamepadKeyIndicators;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000AF7")]
		private bool _isControllerConnected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000AF8")]
		private ControlType _controlType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000AF9")]
		private List<Action<InputActionEventData>> _actionCallbacks = (List<Action<InputActionEventData>>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000AFA")]
		private Dictionary<ShortcutIndicatorTemplate, Action<InputActionEventData>> _dictActionCallbacks = (Dictionary<ShortcutIndicatorTemplate, Action<InputActionEventData>>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000AFB")]
		public FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000AFC")]
		public UnityEvent OnControllerChanged;

		[Cpp2IlInjected.Token(Token = "0x6000F6E")]
		[Cpp2IlInjected.Address(RVA = "0x1190C90", Offset = "0x118F690", VA = "0x181190C90")]
		private void Awake()
		{
			//IL_0010: Expected O, but got I4
			FocusNavigation focusNavigation = FocusNavigation;
			int num = 0;
			if (focusNavigation == (UnityEngine.Object)num)
			{
				FocusNavigation focusNavigation2 = (FocusNavigation = GetComponent<FocusNavigation>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6F")]
		[Cpp2IlInjected.Address(RVA = "0x1191530", Offset = "0x118FF30", VA = "0x181191530")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0106
			//IL_0010: Expected O, but got I4
			//IL_009d: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			UiRoot uiRoot = _uiRoot;
			int num = 0;
			if (uiRoot == (UnityEngine.Object)num)
			{
				int num2 = 0;
				UiRoot uiRoot2 = (_uiRoot = UiRoot.Instance);
				PlayerNavigation playerNavigation = (_playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>());
				GameObject gameObject = (_tutorialBlocker = _uiRoot.TutorialView._blocker);
				GameObject gameObject2 = (_tutorialPanel = _uiRoot.TutorialView._tutorialPanel);
			}
			PlayerNavigation playerNavigation2 = _playerNavigation;
			PlayerNavigation.ControlChanged value = OnControlChanged;
			playerNavigation2.OnControlChanged += value;
			Menu currentMenu = _currentMenu;
			int num3 = 0;
			if (currentMenu == (UnityEngine.Object)num3)
			{
				Menu menu = (_currentMenu = GetComponentInParent<Menu>());
			}
			Menu currentMenu2 = _currentMenu;
			int num4 = default(int);
			if ((object)currentMenu2 != null)
			{
				MenuLayoutTemplate currentLayout = currentMenu2.GetCurrentLayout();
				if (currentLayout == null || (object)currentLayout.ShortcutSet != null)
				{
				}
				num4 = 0;
			}
			_platformShortcuts = (List<ShortcutDefinition>)num4;
			UiRoot uiRoot3 = _uiRoot;
			EventHandler value2 = OnNewInputReceived;
			uiRoot3.OnNewInputReceived += value2;
			RegisterEventListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F70")]
		[Cpp2IlInjected.Address(RVA = "0x1191D30", Offset = "0x1190730", VA = "0x181191D30")]
		internal void RegisterEventListeners()
		{
			//Discarded unreachable code: IL_0095
			//IL_0016: Expected O, but got I4
			UnregisterEventListeners();
			Menu currentMenu = _currentMenu;
			int num = 0;
			if (currentMenu != (UnityEngine.Object)num && _currentMenu.IsInMenuStack)
			{
				UnityEvent<bool> onGenericAlertOnOff = _uiRoot.Dispatcher.OnGenericAlertOnOff;
				UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnGenericAlertOnOffHandler);
				((UnityEvent<T0>)(object)onGenericAlertOnOff).AddListener((UnityAction<>)(object)unityAction);
				MenuStack popupStack = _uiRoot._popupStack;
				MenuStack.CurrentMenuChanged value = OnPopupStackChanged;
				popupStack.OnCurrentMenuChanged += value;
				MenuStack systemPromptStack = _uiRoot._systemPromptStack;
				MenuStack.CurrentMenuChanged value2 = OnSystemPromptStackChanged;
				systemPromptStack.OnCurrentMenuChanged += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F71")]
		[Cpp2IlInjected.Address(RVA = "0x11923B0", Offset = "0x1190DB0", VA = "0x1811923B0")]
		internal void UnregisterEventListeners()
		{
			//Discarded unreachable code: IL_008f
			//IL_0010: Expected O, but got I4
			Menu currentMenu = _currentMenu;
			int num = 0;
			if (currentMenu != (UnityEngine.Object)num && _currentMenu.IsInMenuStack)
			{
				UnityEvent<bool> onGenericAlertOnOff = _uiRoot.Dispatcher.OnGenericAlertOnOff;
				UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnGenericAlertOnOffHandler);
				((UnityEvent<T0>)(object)onGenericAlertOnOff).RemoveListener((UnityAction<>)(object)unityAction);
				MenuStack popupStack = _uiRoot._popupStack;
				MenuStack.CurrentMenuChanged value = OnPopupStackChanged;
				popupStack.OnCurrentMenuChanged -= value;
				MenuStack systemPromptStack = _uiRoot._systemPromptStack;
				MenuStack.CurrentMenuChanged value2 = OnSystemPromptStackChanged;
				systemPromptStack.OnCurrentMenuChanged -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F72")]
		[Cpp2IlInjected.Address(RVA = "0x1191230", Offset = "0x118FC30", VA = "0x181191230")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_00cb
			//IL_0062: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			PlayerNavigation playerNavigation = _playerNavigation;
			PlayerNavigation.ControlChanged value = OnControlChanged;
			playerNavigation.OnControlChanged -= value;
			UiRoot uiRoot = _uiRoot;
			EventHandler value2 = OnNewInputReceived;
			uiRoot.OnNewInputReceived -= value2;
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			ShortcutSetDefinition gamepadShortcutSet = _gamepadShortcutSet;
			int num2 = 0;
			if (gamepadShortcutSet != (UnityEngine.Object)num2)
			{
				int num3 = 0;
				InputProvider inputProvider = DefaultInputProvider.Get();
				int[] array = new int[1];
				int num4 = (array[0] = _gamepadShortcutSet.RewiredMapCategoryId);
				inputProvider.DisableMaps(array);
			}
			RemoveActionCallbacks();
			UnregisterEventListeners();
			int num5 = 0;
			Throbber.ThrobberTransactionScope throbberTransactionScope = _throbberTransactionScope;
			Throbber.ThrobberTransactionScope throbberTransactionScope2 = (_throbberTransactionScope = throbberTransactionScope);
			if ((object)throbberTransactionScope == null)
			{
				int num6 = 0;
				_throbberTransactionScope = (Throbber.ThrobberTransactionScope)num6;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F73")]
		[Cpp2IlInjected.Address(RVA = "0x1190F10", Offset = "0x118F910", VA = "0x181190F10")]
		[AsyncStateMachine(typeof(_003CIsAvailableToRedirect_003Ed__22))]
		private Task<bool> IsAvailableToRedirect(ShortcutDefinition shortcut, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F74")]
		[Cpp2IlInjected.Address(RVA = "0x1191BB0", Offset = "0x11905B0", VA = "0x181191BB0")]
		private void OnNewInputReceived(object sender, EventArgs e)
		{
			int forcelyUpdate = 0;
			RefreshAll((byte)forcelyUpdate != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F75")]
		[Cpp2IlInjected.Address(RVA = "0x1191BC0", Offset = "0x11905C0", VA = "0x181191BC0")]
		internal void RefreshAll(bool forcelyUpdate = false)
		{
			//Discarded unreachable code: IL_0089
			int num = 0;
			if (_isControllerConnected)
			{
			}
			Menu currentMenu = _currentMenu;
			UiRoot uiRoot = _uiRoot;
			if ((object)currentMenu != null)
			{
			}
			bool useKeyboardAsController = num != 0;
			bool flag = uiRoot.IsControllerConnected(useKeyboardAsController);
			UiRoot uiRoot2 = _uiRoot;
			bool flag2 = flag;
			if ((object)_currentMenu != null)
			{
			}
			bool useKeyboardAsController2 = num != 0;
			ControlType currentController = uiRoot2.GetCurrentController(useKeyboardAsController2);
			if (_isControllerConnected != flag2)
			{
			}
			_controlType = currentController;
			_isControllerConnected = flag2;
			if (_controlType != currentController)
			{
				UpdateControllerPhase();
			}
			UpdateCursor();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0x11928E0", Offset = "0x11912E0", VA = "0x1811928E0")]
		internal void UpdateCursor()
		{
			Menu currentMenu = _currentMenu;
			int num = 0;
			UiRoot uiRoot = _uiRoot;
			if ((object)currentMenu != null)
			{
			}
			bool useKeyboardAsController = num != 0;
			bool flag = uiRoot.IsControllerConnected(useKeyboardAsController);
			Menu currentMenu2 = _currentMenu;
			UiRoot uiRoot2 = _uiRoot;
			if ((object)currentMenu2 != null)
			{
			}
			bool useKeyboardAsController2 = num != 0;
			ControlType currentController = uiRoot2.GetCurrentController(useKeyboardAsController2);
			int num2 = 0;
			bool isMobilePlatform = Application.isMobilePlatform;
			if (isMobilePlatform)
			{
				return;
			}
			int num3 = 0;
			if ((isMobilePlatform ? 1 : 0) - 1 > 1 && !isMobilePlatform)
			{
				return;
			}
			if (_currentMenu.IsInMenuStack)
			{
				int count = _uiRoot._popupStack.Count;
				if (_uiRoot._genericAlert.gameObject.activeSelf)
				{
					goto IL_0100;
				}
			}
			Menu currentMenu3 = _currentMenu;
			if ((object)currentMenu3 != null)
			{
				int num4 = 0;
				if ((object)currentMenu3 != null)
				{
					goto IL_00d9;
				}
				if ((object)currentMenu3 != null)
				{
					int num5 = 0;
					if ((object)currentMenu3 != null)
					{
						goto IL_00d9;
					}
					if ((object)currentMenu3 != null)
					{
					}
				}
			}
			int num6 = 0;
			if ((object)currentMenu3 != null)
			{
				goto IL_00d9;
			}
			goto IL_0100;
			IL_00d9:
			if ((object)currentMenu3 != null)
			{
				int num7 = 0;
				bool flag2 = default(bool);
				if ((object)currentMenu3 != null && flag2)
				{
					goto IL_0100;
				}
			}
			Menu currentMenu4 = _currentMenu;
			if ((object)currentMenu4 != null)
			{
				int num8 = 0;
				if ((object)currentMenu4 == null)
				{
				}
			}
			goto IL_0100;
			IL_0100:
			if (_playerNavigation.ControlScheme != null)
			{
			}
			if (!_uiRoot.IsCutsceneInPlaying)
			{
				Menu currentMenu5 = _currentMenu;
				if ((object)currentMenu5 != null)
				{
					int num9 = 0;
					if ((object)currentMenu5 != null)
					{
						bool visible = default(bool);
						CursorWrapper.Visible = visible;
						return;
					}
				}
				_uiRoot.UpdateCursorBehaviorForGameplay();
				_uiRoot.UpdateCursorBehaviorForUI();
			}
			int num10 = 0;
			bool flag3 = (DebugSettings.Settings.rdpHack_ ? 1 : 0) == num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F77")]
		[Cpp2IlInjected.Address(RVA = "0x1192EA0", Offset = "0x11918A0", VA = "0x181192EA0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0023
			UiRoot uiRoot = _uiRoot;
			Menu currentMenu = _currentMenu;
			int ignoreThrobber = 0;
			if (uiRoot.IsOnTop(currentMenu, (byte)ignoreThrobber != 0))
			{
				UpdateCursor();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F78")]
		[Cpp2IlInjected.Address(RVA = "0x1192600", Offset = "0x1191000", VA = "0x181192600")]
		private void UpdateControllerPhase()
		{
			//Discarded unreachable code: IL_00fe
			//IL_0016: Expected O, but got I4
			//IL_00d9: Expected O, but got I4
			RemoveActionCallbacks();
			Menu currentMenu = _currentMenu;
			int num = 0;
			if (currentMenu != (UnityEngine.Object)num)
			{
				_currentMenu.OnControllerChanged();
				Menu currentMenu2 = _currentMenu;
				int num2 = 0;
				if ((object)currentMenu2 != null)
				{
					int num3 = 0;
					UiRoot.Instance.MainMenuBar.OnControllerChanged();
				}
				int num4 = 0;
				MenuStack popupStack = UiRoot.Instance._popupStack;
				MenuStack stack = currentMenu2._stack;
				if (!(popupStack == stack))
				{
					GameObject gameObject = _currentMenu.gameObject;
					GameObject gameObject2 = _uiRoot._genericAlert.gameObject;
					if (!(gameObject == gameObject2) && (_uiRoot._popupStack.Count != 0 || _uiRoot._genericAlert.gameObject.activeSelf))
					{
						goto IL_00c5;
					}
				}
				AddActionCallbacks();
				goto IL_00c5;
			}
			goto IL_00e9;
			IL_00e9:
			OnControllerChanged?.Invoke();
			return;
			IL_00c5:
			FocusNavigation focusNavigation = FocusNavigation;
			int num5 = 0;
			if (focusNavigation != (UnityEngine.Object)num5)
			{
				bool flag = FocusNavigation.RestoreFocus();
			}
			goto IL_00e9;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F79")]
		[Cpp2IlInjected.Address(RVA = "0x1192D30", Offset = "0x1191730", VA = "0x181192D30")]
		public void UpdateVisuals()
		{
			//Discarded unreachable code: IL_0082
			//IL_0035: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			ShortcutIndicator[] componentsInChildren = base.gameObject.GetComponentsInChildren<ShortcutIndicator>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num >= length)
			{
				return;
			}
			ShortcutIndicator shortcutIndicator = componentsInChildren[num];
			BaseButton baseButton = shortcutIndicator.BaseButton;
			int num2 = 0;
			if (!(baseButton != (UnityEngine.Object)num2))
			{
				TemplateButton templateButton = shortcutIndicator.TemplateButton;
				int num3 = 0;
				if (!(templateButton != (UnityEngine.Object)num3))
				{
					goto IL_007d;
				}
				bool flag = (shortcutIndicator.enabled = shortcutIndicator.TemplateButton._isActivated);
				num++;
			}
			bool flag2 = (shortcutIndicator.enabled = shortcutIndicator.BaseButton._isActive);
			goto IL_007d;
			IL_007d:
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7A")]
		[Cpp2IlInjected.Address(RVA = "0x1190510", Offset = "0x118EF10", VA = "0x181190510")]
		public void AddActionCallbacks()
		{
			//IL_0065: Expected O, but got I4
			//IL_00d0: Expected O, but got I4
			//IL_00e4: Expected O, but got I4
			//IL_0166: Expected O, but got I4
			Menu currentMenu = _currentMenu;
			int num = 0;
			UiRoot uiRoot = _uiRoot;
			if ((object)currentMenu != null)
			{
			}
			bool useKeyboardAsController = num != 0;
			ControlType currentController = uiRoot.GetCurrentController(useKeyboardAsController);
			List<ShortcutDefinition> platformShortcuts = _platformShortcuts;
			int num2 = (int)currentController;
			this.AddActionCallbacks((IEnumerable<>)platformShortcuts);
			int num3 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			ShortcutSetDefinition gamepadShortcutSet = _gamepadShortcutSet;
			int num4 = 0;
			if (gamepadShortcutSet != (UnityEngine.Object)num4)
			{
				int num5 = 0;
				InputProvider inputProvider = DefaultInputProvider.Get();
				int[] array = new int[1];
				int num6 = (array[0] = _gamepadShortcutSet.RewiredMapCategoryId);
				inputProvider.DisableMaps(array);
			}
			Menu currentMenu3 = default(Menu);
			if (num2 != 0)
			{
				ShortcutIndicatorSetTemplate currentShortcutIndicatorSet = _currentMenu.GetCurrentShortcutIndicatorSet();
				ShortcutSetDefinition shortcutSetDefinition = (_gamepadShortcutSet = currentShortcutIndicatorSet.ShortcutSet);
				if ((object)_gamepadShortcutSet != null)
				{
				}
				_gamepadShortcuts = (List<ShortcutDefinition>)num;
				ShortcutSetDefinition gamepadShortcutSet2 = _gamepadShortcutSet;
				int num7 = 0;
				if (gamepadShortcutSet2 != (UnityEngine.Object)num7)
				{
					int num8 = 0;
					InputProvider inputProvider2 = DefaultInputProvider.Get();
					int[] array2 = new int[1];
					int num9 = (array2[0] = _gamepadShortcutSet.RewiredMapCategoryId);
					inputProvider2.EnableMaps(array2);
				}
				List<ShortcutDefinition> gamepadShortcuts = _gamepadShortcuts;
				this.AddActionCallbacks((IEnumerable<>)gamepadShortcuts);
				List<ShortcutIndicatorTemplate> list = (_gamepadKeyIndicators = (List<ShortcutIndicatorTemplate>)(object)new List<T>());
				List<ShortcutIndicatorTemplate> gamepadKeyIndicators = _gamepadKeyIndicators;
				List<ShortcutIndicatorTemplate> gamepadKeyIndicators2 = currentShortcutIndicatorSet.GamepadKeyIndicators;
				((List<T>)(object)gamepadKeyIndicators).AddRange((IEnumerable<>)gamepadKeyIndicators2);
				Menu currentMenu2 = _currentMenu;
				int num10 = 0;
				if (currentMenu2 != (UnityEngine.Object)num10 && _currentMenu.IsInMenuStack)
				{
					currentMenu3 = _currentMenu;
					if ((object)currentMenu3 != null)
					{
						int num11 = 0;
						if ((object)currentMenu3 != null)
						{
							List<ShortcutIndicatorTemplate> gamepadKeyIndicators3 = _gamepadKeyIndicators;
							int num12 = 0;
							List<ShortcutIndicatorTemplate> gamepadKeyIndicators4 = UiRoot.Instance.MainMenuBar.GetCurrentShortcutIndicatorSet().GamepadKeyIndicators;
							((List<T>)(object)gamepadKeyIndicators3).AddRange((IEnumerable<>)gamepadKeyIndicators4);
						}
					}
				}
				List<ShortcutIndicatorTemplate> gamepadKeyIndicators5 = _gamepadKeyIndicators;
				this.AddActionCallbacks((IEnumerable<>)gamepadKeyIndicators5);
				_uiRoot.UpdateCursorBehaviorForGameplay();
				return;
			}
			_uiRoot.UpdateCursorBehaviorForUI();
			_gamepadKeyIndicators = (List<ShortcutIndicatorTemplate>)(object)currentMenu3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7B")]
		[Cpp2IlInjected.Address(RVA = "0x1191F20", Offset = "0x1190920", VA = "0x181191F20")]
		private void RemoveActionCallbacks()
		{
			//Discarded unreachable code: IL_0033, IL_0039
			//IL_0032: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			List<Action<InputActionEventData>> actionCallbacks = _actionCallbacks;
			bool flag = default(bool);
			if (flag)
			{
				player.RemoveInputEventDelegate((Action<>)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7C")]
		[Cpp2IlInjected.Address(RVA = "0x11902D0", Offset = "0x118ECD0", VA = "0x1811902D0")]
		private void AddActionCallbacks(IEnumerable<ShortcutDefinition> shortcuts)
		{
			//Discarded unreachable code: IL_006b, IL_0071, IL_0077
			//IL_0061: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			int num = 0;
			if (shortcuts == null)
			{
				return;
			}
			int num2 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			UiRoot uiRoot = _uiRoot;
			if ((object)_currentMenu != null)
			{
			}
			bool useKeyboardAsController = num != 0;
			bool flag = uiRoot.IsControllerConnected(useKeyboardAsController);
			if (flag)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0061;
					}
					num++;
				}
				AddActionCallback((ShortcutDefinition)num, player, flag, (ShortcutIndicator)num);
				goto IL_0061;
			}
			goto IL_0065;
			IL_0065:
			if (!flag)
			{
			}
			return;
			IL_0061:
			num += num;
			goto IL_0065;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7D")]
		[Cpp2IlInjected.Address(RVA = "0x1190970", Offset = "0x118F370", VA = "0x181190970")]
		private void AddActionCallbacks(IEnumerable<ShortcutIndicatorTemplate> shortcutIndicators)
		{
			//Discarded unreachable code: IL_0084, IL_008a, IL_0090, IL_0096, IL_009c, IL_00a2
			int num = 0;
			if (shortcutIndicators == null)
			{
				return;
			}
			int num2 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			UiRoot uiRoot = _uiRoot;
			if ((object)_currentMenu != null)
			{
			}
			bool useKeyboardAsController = num != 0;
			bool flag = uiRoot.IsControllerConnected(useKeyboardAsController);
			int num4 = default(int);
			if (flag)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0077;
					}
					num++;
				}
				bool flag2 = default(bool);
				ShortcutDefinition shortcutDefinition = default(ShortcutDefinition);
				if (!flag2 || shortcutDefinition.RewiredActionId < 0)
				{
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
				}
				if ((object)typeof(UnityEngine.Object).TypeHandle != null)
				{
					num4 = 0;
					goto IL_0077;
				}
			}
			goto IL_007e;
			IL_007e:
			if (!flag)
			{
			}
			return;
			IL_0077:
			num4 += num4;
			goto IL_007e;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7E")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		private bool IsInDebugMenus()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7F")]
		[Cpp2IlInjected.Address(RVA = "0x118FEA0", Offset = "0x118E8A0", VA = "0x18118FEA0")]
		private void AddActionCallback(ShortcutDefinition shortcutDefinition, Player defaultPlayer, bool isControllerConnected, [Optional] ShortcutIndicator shortcutIndicator)
		{
			//Discarded unreachable code: IL_00c7
			//IL_001b: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			ShortcutIndicator shortcutIndicator2 = (ShortcutIndicator)0;
			Action<InputActionEventData> item = (Action<InputActionEventData>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_0302
				//IL_00a0: Expected O, but got I4
				//IL_013e: Expected O, but got I4
				//IL_015a: Expected O, but got I4
				//IL_018c: Expected O, but got I4
				//IL_01a8: Expected O, but got I4
				//IL_01f5: Expected O, but got I4
				//IL_0214: Expected O, but got I4
				//IL_025d: Expected O, but got I4
				//IL_02ee: Expected O, but got I4
				ShortcutDefinition shortcutDefinition4 = shortcutDefinition;
				if ((object)shortcutDefinition4 == null || shortcutDefinition4.RedirectionType != RedirectionType.MenuNavGoBackward || (_uiRoot._fadeEffect.IsInTransition && !_uiRoot._genericAlert.gameObject.activeSelf) || (!isControllerConnected && (_tutorialPanel.activeSelf || _tutorialBlocker.activeSelf)))
				{
					return;
				}
				Menu currentMenu = _currentMenu;
				int num4 = 0;
				if (currentMenu != (UnityEngine.Object)num4)
				{
					Menu currentMenu2 = _currentMenu;
					if (!currentMenu2._isFocused || currentMenu2._isInFocusOutAnimation || (currentMenu2.IsInPopUpStack && _uiRoot._genericAlert.gameObject.activeSelf) || (!_currentMenu.IsInSystemPromptStack && _uiRoot.ShouldBlockShortcuts))
					{
						return;
					}
				}
				if (IsInDebugMenus())
				{
					return;
				}
				ShortcutDefinition shortcutDefinition5 = shortcutDefinition;
				int num5 = 0;
				if (shortcutDefinition5 != (UnityEngine.Object)num5)
				{
					ShortcutDefinition self = shortcutDefinition.Self;
					int num6 = 0;
					if (self != (UnityEngine.Object)num6)
					{
						ShortcutDefinition self2 = shortcutDefinition.Self;
						int num7 = 0;
					}
				}
				int num8 = 0;
				ShortcutIndicator shortcutIndicator3 = shortcutIndicator2;
				if (num8 == 0)
				{
					int num9 = 0;
					if (shortcutIndicator3 != (UnityEngine.Object)num9)
					{
						TemplateButton templateButton = shortcutIndicator2.TemplateButton;
						int num10 = 0;
						if (templateButton != (UnityEngine.Object)num10)
						{
							ShortcutIndicator shortcutIndicator4 = shortcutIndicator2;
							TemplateButton templateButton2 = shortcutIndicator4.TemplateButton;
							if (shortcutIndicator4.CanTriggerTemplateButton)
							{
								UnityEvent onClicked = templateButton2.OnClicked;
								if (onClicked != null)
								{
									onClicked.Invoke();
									goto IL_01e1;
								}
							}
							goto IL_02da;
						}
					}
					goto IL_01e1;
				}
				goto IL_0251;
				IL_02da:
				ShortcutIndicator shortcutIndicator5 = shortcutIndicator2;
				int num11 = 0;
				if (shortcutIndicator5 != (UnityEngine.Object)num11)
				{
					shortcutIndicator2.OnTriggered.Invoke();
				}
				return;
				IL_01e1:
				ShortcutIndicator shortcutIndicator6 = shortcutIndicator2;
				int num12 = 0;
				if (shortcutIndicator6 != (UnityEngine.Object)num12)
				{
					BaseButton baseButton = shortcutIndicator2.BaseButton;
					int num13 = 0;
					if (baseButton != (UnityEngine.Object)num13 && shortcutIndicator2.CanTriggerBaseButton)
					{
						Button buttonComponent = shortcutIndicator2.BaseButton.ButtonComponent;
						if ((object)buttonComponent != null)
						{
							buttonComponent.m_OnClick.Invoke();
							goto IL_0251;
						}
					}
				}
				goto IL_02da;
				IL_0251:
				int num14 = 0;
				if (shortcutIndicator3 != (UnityEngine.Object)num14 && !shortcutIndicator2.CanTriggerRedirection)
				{
					return;
				}
				int count = _uiRoot._menuStack.Count;
				MenuNavigation menuNavigation = this;
				ShortcutDefinition self3 = shortcutDefinition.Self;
				CancellationToken cancellationToken = _currentMenu.CancellationToken;
				MenuStack menuStack = _uiRoot._menuStack;
				int num15 = 0;
				IMenu bottom = menuStack.Bottom;
				int num16 = 0;
				int num17 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				goto IL_02da;
			};
			bool flag = default(bool);
			if (flag)
			{
				goto IL_0068;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				int num = 0;
				if (num < (flag2 ? 1 : 0))
				{
					((List<T>)(object)_actionCallbacks).Add((T)item);
					num++;
				}
				if (num < (flag2 ? 1 : 0))
				{
					((List<T>)(object)_actionCallbacks).Add((T)item);
					num++;
					goto IL_0068;
				}
			}
			goto IL_00a9;
			IL_0068:
			ShortcutDefinition shortcutDefinition2 = default(ShortcutDefinition);
			InputActionEventType[] rewiredActionEventTypes = shortcutDefinition2.RewiredActionEventTypes;
			int num2 = 0;
			int length = rewiredActionEventTypes.Length;
			if (num2 < length)
			{
				InputActionEventType inputActionEventType = rewiredActionEventTypes[num2];
				ShortcutDefinition shortcutDefinition3 = default(ShortcutDefinition);
				int rewiredActionId = shortcutDefinition3.RewiredActionId;
				((List<T>)(object)_actionCallbacks).Add((T)item);
				num2++;
			}
			goto IL_00a9;
			IL_00a9:
			int num3 = 0;
			if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
			{
				Dictionary<ShortcutIndicatorTemplate, Action<InputActionEventData>> dictActionCallbacks = _dictActionCallbacks;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F80")]
		[Cpp2IlInjected.Address(RVA = "0x11918A0", Offset = "0x11902A0", VA = "0x1811918A0")]
		public void OnNavButtonClicked(ShortcutDefinition shortcut)
		{
			Menu currentMenu = _currentMenu;
			if (currentMenu._isFocused && !currentMenu._isInFocusOutAnimation)
			{
				if (_isInTask)
				{
					int _003C_003E1__state = default(int);
					_003CDoShortcutTaskNextFrame_003Ed__36 _003CDoShortcutTaskNextFrame_003Ed__ = new _003CDoShortcutTaskNextFrame_003Ed__36(_003C_003E1__state);
					_003C_003E1__state = 0;
					_003CDoShortcutTaskNextFrame_003Ed__._003C_003E4__this = this;
					_003CDoShortcutTaskNextFrame_003Ed__.shortcut = shortcut;
					Coroutine coroutine = StartCoroutine(_003CDoShortcutTaskNextFrame_003Ed__);
					throw new NullReferenceException();
				}
				MenuStack menuStack = _uiRoot._menuStack;
				int num = 0;
				IMenu bottom = menuStack.Bottom;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F81")]
		[Cpp2IlInjected.Address(RVA = "0x1190DE0", Offset = "0x118F7E0", VA = "0x181190DE0")]
		[IteratorStateMachine(typeof(_003CDoShortcutTaskNextFrame_003Ed__36))]
		private IEnumerator DoShortcutTaskNextFrame(ShortcutDefinition shortcut)
		{
			int _003C_003E1__state = default(int);
			_003CDoShortcutTaskNextFrame_003Ed__36 _003CDoShortcutTaskNextFrame_003Ed__ = new _003CDoShortcutTaskNextFrame_003Ed__36(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDoShortcutTaskNextFrame_003Ed__._003C_003E4__this = this;
			_003CDoShortcutTaskNextFrame_003Ed__.shortcut = shortcut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F82")]
		[Cpp2IlInjected.Address(RVA = "0x1192140", Offset = "0x1190B40", VA = "0x181192140")]
		[AsyncStateMachine(typeof(_003CShortcutTask_003Ed__37))]
		public Task ShortcutTask(ShortcutDefinition shortcut, CancellationToken ct, [Optional] ItemFilterData filter, [Optional] MenuParam param)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F83")]
		[Cpp2IlInjected.Address(RVA = "0x1191820", Offset = "0x1190220", VA = "0x181191820")]
		private void OnPopupStackChanged(IMenu menu)
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CUpdateActionCallbacks_003Ed__41 _003CUpdateActionCallbacks_003Ed__ = new _003CUpdateActionCallbacks_003Ed__41(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateActionCallbacks_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CUpdateActionCallbacks_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F84")]
		[Cpp2IlInjected.Address(RVA = "0x1191820", Offset = "0x1190220", VA = "0x181191820")]
		private void OnSystemPromptStackChanged(IMenu menu)
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CUpdateActionCallbacks_003Ed__41 _003CUpdateActionCallbacks_003Ed__ = new _003CUpdateActionCallbacks_003Ed__41(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateActionCallbacks_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CUpdateActionCallbacks_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F85")]
		[Cpp2IlInjected.Address(RVA = "0x1191820", Offset = "0x1190220", VA = "0x181191820")]
		private void OnGenericAlertOnOffHandler(bool isOpened)
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CUpdateActionCallbacks_003Ed__41 _003CUpdateActionCallbacks_003Ed__ = new _003CUpdateActionCallbacks_003Ed__41(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateActionCallbacks_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CUpdateActionCallbacks_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F86")]
		[Cpp2IlInjected.Address(RVA = "0x1192590", Offset = "0x1190F90", VA = "0x181192590")]
		[IteratorStateMachine(typeof(_003CUpdateActionCallbacks_003Ed__41))]
		private IEnumerator UpdateActionCallbacks()
		{
			int _003C_003E1__state = default(int);
			_003CUpdateActionCallbacks_003Ed__41 _003CUpdateActionCallbacks_003Ed__ = new _003CUpdateActionCallbacks_003Ed__41(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateActionCallbacks_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F87")]
		[Cpp2IlInjected.Address(RVA = "0x1191060", Offset = "0x118FA60", VA = "0x181191060")]
		private void OnControlChanged(bool overridden)
		{
			//Discarded unreachable code: IL_0035
			//IL_0028: Expected O, but got I4
			if (!_playerNavigation.AllOverridden)
			{
				ShortcutDefinition pendingShortcut = _uiRoot._menuStack.PendingShortcut;
				int num = 0;
				if (pendingShortcut != (UnityEngine.Object)num)
				{
					int num2 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F88")]
		[Cpp2IlInjected.Address(RVA = "0x11922B0", Offset = "0x1190CB0", VA = "0x1811922B0")]
		[AsyncStateMachine(typeof(_003CTryShortcutTask_003Ed__43))]
		private Task TryShortcutTask()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F89")]
		[Cpp2IlInjected.Address(RVA = "0x1190E70", Offset = "0x118F870", VA = "0x181190E70")]
		public FocusNavigationElement GetFocusElement()
		{
			if (FocusNavigation._focusedElement == null)
			{
				int num = 0;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F8A")]
		[Cpp2IlInjected.Address(RVA = "0x1190D40", Offset = "0x118F740", VA = "0x181190D40")]
		[Conditional("DEBUG_LOG")]
		private void DebugLog(object message, UnityEngine.Object context)
		{
			string fullPath = this.GetFullPath();
			UnityEngine.Debug.Log($"[UI][{fullPath}] MenuNavigation#{message}", context);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F8B")]
		[Cpp2IlInjected.Address(RVA = "0x1192EE0", Offset = "0x11918E0", VA = "0x181192EE0")]
		public MenuNavigation()
		{
		}
	}
}
