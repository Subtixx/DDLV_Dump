using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Systems;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000727")]
	[RequireComponent(typeof(FocusNavigation))]
	public class StartMenuSettings : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400294A")]
		[SerializeField]
		private TMP_Text _versionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400294B")]
		[SerializeField]
		[Header("Tabs")]
		private NavigationBarButton _graphicsTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400294C")]
		[SerializeField]
		private NavigationBarButton _soundsTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400294D")]
		[SerializeField]
		private NavigationBarButton _controlsTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400294E")]
		[SerializeField]
		private NavigationBarButton _generalTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400294F")]
		[SerializeField]
		[Header("Panels")]
		private SettingsGraphics _settingsGraphicsContentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002950")]
		[SerializeField]
		private SettingsSounds _settingsSoundsContentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002951")]
		[SerializeField]
		private SettingsControls _settingsControlsContentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002952")]
		[SerializeField]
		private SettingsGeneral _settingsGeneralContentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002953")]
		[SerializeField]
		private AK.Wwise.Event _resetDefaultSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002954")]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002955")]
		private Dictionary<SettingsMenuTab, GameObject> _settingsPanels = (Dictionary<SettingsMenuTab, GameObject>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002956")]
		private SettingsMenuTab _currentTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002957")]
		private SettingsMenuPanel _currentPanel;

		[Cpp2IlInjected.Token(Token = "0x6002D74")]
		[Cpp2IlInjected.Address(RVA = "0x85EAE0", Offset = "0x85D4E0", VA = "0x18085EAE0")]
		public void Awake()
		{
			//Discarded unreachable code: IL_0029, IL_0048, IL_0067, IL_0086, IL_009d, IL_00ac, IL_00b4, IL_00c1, IL_00c2
			//IL_009a: Expected O, but got I4
			FocusNavigation focusNavigation = (_focusNavigation = GetComponent<FocusNavigation>());
			SettingsGraphics settingsGraphicsContentPanel = _settingsGraphicsContentPanel;
			Dictionary<SettingsMenuTab, GameObject> settingsPanels = _settingsPanels;
			GameObject gameObject = settingsGraphicsContentPanel.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D75")]
		[Cpp2IlInjected.Address(RVA = "0x85F850", Offset = "0x85E250", VA = "0x18085F850", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_009a
			((object)this)._002Ector();
			int tab = 0;
			SelectTab((SettingsMenuTab)tab);
			UnityEvent onSelected = _graphicsTabButton.OnSelected;
			UnityAction call = OnGraphicsSelected;
			onSelected.AddListener(call);
			UnityEvent onSelected2 = _soundsTabButton.OnSelected;
			UnityAction call2 = OnSoundsSelected;
			onSelected2.AddListener(call2);
			UnityEvent onSelected3 = _controlsTabButton.OnSelected;
			UnityAction call3 = OnControlsSelected;
			onSelected3.AddListener(call3);
			UnityEvent onSelected4 = _generalTabButton.OnSelected;
			UnityAction call4 = OnGeneralSelected;
			onSelected4.AddListener(call4);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D76")]
		[Cpp2IlInjected.Address(RVA = "0x85FE00", Offset = "0x85E800", VA = "0x18085FE00", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0098
			int num = 0;
			GameSettingsSystem.SaveAppliedSettings();
			UnityEvent onSelected = _graphicsTabButton.OnSelected;
			UnityAction call = OnGraphicsSelected;
			onSelected.RemoveListener(call);
			UnityEvent onSelected2 = _soundsTabButton.OnSelected;
			UnityAction call2 = OnSoundsSelected;
			onSelected2.RemoveListener(call2);
			UnityEvent onSelected3 = _controlsTabButton.OnSelected;
			UnityAction call3 = OnControlsSelected;
			onSelected3.RemoveListener(call3);
			UnityEvent onSelected4 = _generalTabButton.OnSelected;
			UnityAction call4 = OnGeneralSelected;
			onSelected4.RemoveListener(call4);
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D77")]
		[Cpp2IlInjected.Address(RVA = "0x85F7B0", Offset = "0x85E1B0", VA = "0x18085F7B0")]
		private void OnGraphicsSelected()
		{
			int tab = 0;
			SelectTab((SettingsMenuTab)tab);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D78")]
		[Cpp2IlInjected.Address(RVA = "0x85F840", Offset = "0x85E240", VA = "0x18085F840")]
		private void OnSoundsSelected()
		{
			SelectTab(SettingsMenuTab.Sounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D79")]
		[Cpp2IlInjected.Address(RVA = "0x85F600", Offset = "0x85E000", VA = "0x18085F600")]
		private void OnControlsSelected()
		{
			SelectTab(SettingsMenuTab.Controls);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7A")]
		[Cpp2IlInjected.Address(RVA = "0x85F7A0", Offset = "0x85E1A0", VA = "0x18085F7A0")]
		private void OnGeneralSelected()
		{
			SelectTab(SettingsMenuTab.General);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7B")]
		[Cpp2IlInjected.Address(RVA = "0x85FBC0", Offset = "0x85E5C0", VA = "0x18085FBC0")]
		private void SelectTab(SettingsMenuTab tab)
		{
			//Discarded unreachable code: IL_0134
			Dictionary<SettingsMenuTab, GameObject> settingsPanels = _settingsPanels;
			_currentTab = tab;
			GameObject gameObject = default(GameObject);
			SettingsMenuPanel settingsMenuPanel = (_currentPanel = gameObject.GetComponent<SettingsMenuPanel>());
			GameObject gameObject2 = _settingsGraphicsContentPanel.gameObject;
			bool active = _currentTab == SettingsMenuTab.Graphics;
			gameObject2.SetActive(active);
			GameObject gameObject3 = _settingsSoundsContentPanel.gameObject;
			bool active2 = _currentTab == SettingsMenuTab.Sounds;
			gameObject3.SetActive(active2);
			GameObject gameObject4 = _settingsControlsContentPanel.gameObject;
			bool active3 = _currentTab == SettingsMenuTab.Controls;
			gameObject4.SetActive(active3);
			GameObject gameObject5 = _settingsGeneralContentPanel.gameObject;
			bool active4 = _currentTab == SettingsMenuTab.General;
			gameObject5.SetActive(active4);
			NavigationBarButton graphicsTabButton = _graphicsTabButton;
			bool flag2 = (graphicsTabButton.IsSelected = _currentTab == SettingsMenuTab.Graphics);
			NavigationBarButton soundsTabButton = _soundsTabButton;
			bool flag4 = (soundsTabButton.IsSelected = _currentTab == SettingsMenuTab.Sounds);
			NavigationBarButton controlsTabButton = _controlsTabButton;
			bool flag6 = (controlsTabButton.IsSelected = _currentTab == SettingsMenuTab.Controls);
			NavigationBarButton generalTabButton = _generalTabButton;
			bool flag8 = (generalTabButton.IsSelected = _currentTab == SettingsMenuTab.General);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation = _focusNavigation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7C")]
		[Cpp2IlInjected.Address(RVA = "0x85F3A0", Offset = "0x85DDA0", VA = "0x18085F3A0")]
		private void OnClose()
		{
			//Discarded unreachable code: IL_0084
			//IL_0051: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation = StartMenu.Instance._focusNavigation;
				if (1L == 0L)
				{
				}
				FocusNavigationElement component = StartMenu.Instance._selectedTab.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
			StartMenu _003CInstance_003Ek__BackingField = StartMenu.Instance;
			int num2 = 0;
			_003CInstance_003Ek__BackingField.SelectTab((StartTabButton)num2);
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num3 = @event.Post(gameObject);
			}
			int num4 = 0;
			UiRoot.Instance._popupStack.Pop();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7D")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C0", Offset = "0x85E1C0", VA = "0x18085F7C0")]
		private void OnNextTab()
		{
			SettingsMenuTab currentTab = _currentTab;
			if (currentTab != 0)
			{
				switch (currentTab)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7E")]
		[Cpp2IlInjected.Address(RVA = "0x85F800", Offset = "0x85E200", VA = "0x18085F800")]
		private void OnPreviousTab()
		{
			//Discarded unreachable code: IL_000a, IL_000b
			if (_currentTab != SettingsMenuTab.Sounds)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7F")]
		[Cpp2IlInjected.Address(RVA = "0x85F610", Offset = "0x85E010", VA = "0x18085F610")]
		private void OnDefaultSettings()
		{
			AK.Wwise.Event resetDefaultSFX = _resetDefaultSFX;
			if (resetDefaultSFX != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = resetDefaultSFX.Post(gameObject);
			}
			CancellationToken cancellationToken = base.CancellationToken;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D80")]
		[Cpp2IlInjected.Address(RVA = "0x85EE00", Offset = "0x85D800", VA = "0x18085EE00")]
		[AsyncStateMachine(typeof(_003CDefaultSettingsTask_003Ed__26))]
		private Task DefaultSettingsTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D81")]
		[Cpp2IlInjected.Address(RVA = "0x85FA80", Offset = "0x85E480", VA = "0x18085FA80")]
		private void ResetDefaultSettings()
		{
			//Discarded unreachable code: IL_0028
			SystemRoot.Instance.GetSystem<GameSettingsSystem>().ResetToDefaults();
			int _003C_003E1__state = default(int);
			_003CResetDefaultSettingsLater_003Ed__28 _003CResetDefaultSettingsLater_003Ed__ = new _003CResetDefaultSettingsLater_003Ed__28(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetDefaultSettingsLater_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CResetDefaultSettingsLater_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D82")]
		[Cpp2IlInjected.Address(RVA = "0x85FA10", Offset = "0x85E410", VA = "0x18085FA10")]
		[IteratorStateMachine(typeof(_003CResetDefaultSettingsLater_003Ed__28))]
		private IEnumerator ResetDefaultSettingsLater()
		{
			int _003C_003E1__state = default(int);
			_003CResetDefaultSettingsLater_003Ed__28 _003CResetDefaultSettingsLater_003Ed__ = new _003CResetDefaultSettingsLater_003Ed__28(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetDefaultSettingsLater_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D83")]
		[Cpp2IlInjected.Address(RVA = "0x85EFF0", Offset = "0x85D9F0", VA = "0x18085EFF0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_012d
			//IL_00c5: Expected O, but got I4
			if (redirectionType > RedirectionType.GameTabLeft)
			{
				if (redirectionType == RedirectionType.GameTabRight)
				{
					SettingsMenuTab currentTab = _currentTab;
					if (currentTab != 0)
					{
						if (currentTab == SettingsMenuTab.Graphics)
						{
							goto IL_0121;
						}
						if (currentTab != SettingsMenuTab.Sounds)
						{
							return;
						}
					}
				}
				if (redirectionType == RedirectionType.GameRestoreDefault)
				{
					AK.Wwise.Event resetDefaultSFX = _resetDefaultSFX;
					if (resetDefaultSFX != null)
					{
						GameObject gameObject = base.gameObject;
						uint num = resetDefaultSFX.Post(gameObject);
					}
					CancellationToken cancellationToken = base.CancellationToken;
					int num2 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				return;
			}
			int num8 = default(int);
			if (redirectionType == RedirectionType.MenuNavGoBackward)
			{
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					FocusNavigation focusNavigation = StartMenu.Instance._focusNavigation;
					ulong num4 = default(ulong);
					if (num4 == 0)
					{
					}
					FocusNavigationElement component = StartMenu.Instance._selectedTab.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
				StartMenu _003CInstance_003Ek__BackingField = StartMenu.Instance;
				int num5 = 0;
				_003CInstance_003Ek__BackingField.SelectTab((StartTabButton)num5);
				AK.Wwise.Event @event = closeSFX;
				if (@event != null)
				{
					GameObject gameObject2 = base.gameObject;
					uint num6 = @event.Post(gameObject2);
				}
				int num7 = 0;
				MenuStack popupStack = UiRoot.Instance._popupStack;
				num8 = 0;
				popupStack.Pop();
				return;
			}
			if (num8 != 917765)
			{
				return;
			}
			if (num8 != 917765)
			{
				while (num8 == 917765)
				{
				}
				MenuStack popupStack = default(MenuStack);
				if ((long)popupStack != 1)
				{
					return;
				}
			}
			goto IL_0121;
			IL_0121:
			int tab = 0;
			SelectTab((SettingsMenuTab)tab);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D84")]
		[Cpp2IlInjected.Address(RVA = "0x85F520", Offset = "0x85DF20", VA = "0x18085F520", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_005d
			//IL_0030: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation = StartMenu.Instance._focusNavigation;
				int num2 = 0;
				focusNavigation.SetFocus((FocusNavigationElement)num2);
				FocusNavigation focusNavigation2 = _focusNavigation;
				ISupportsFocusNavigation focusedElement = focusNavigation2._focusedElement;
				if (focusedElement == null)
				{
					FocusNavigationElement firstFocusNavigationElement = _currentPanel.FirstFocusNavigationElement;
				}
				focusNavigation2.SetFocus(focusedElement);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D85")]
		[Cpp2IlInjected.Address(RVA = "0x85EF20", Offset = "0x85D920", VA = "0x18085EF20")]
		private void DisableNavigation()
		{
			//Discarded unreachable code: IL_0028
			//IL_0026: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation = _focusNavigation;
				int num2 = 0;
				focusNavigation.SetFocus((FocusNavigationElement)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D86")]
		[Cpp2IlInjected.Address(RVA = "0x85EF70", Offset = "0x85D970", VA = "0x18085EF70")]
		private void EnableNavigation()
		{
			//Discarded unreachable code: IL_0035
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SettingsMenuPanel currentPanel = _currentPanel;
				FocusNavigation focusNavigation = _focusNavigation;
				FocusNavigationElement firstFocusNavigationElement = currentPanel.FirstFocusNavigationElement;
				focusNavigation.SetFocus(firstFocusNavigationElement);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D87")]
		[Cpp2IlInjected.Address(RVA = "0x85FFC0", Offset = "0x85E9C0", VA = "0x18085FFC0")]
		public StartMenuSettings()
		{
		}
	}
}
