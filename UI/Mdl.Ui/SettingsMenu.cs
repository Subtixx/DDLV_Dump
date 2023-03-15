using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006B1")]
	[RequiredAllNotNull]
	public class SettingsMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40025DB")]
		[SerializeField]
		private TMP_Text _versionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40025DC")]
		[SerializeField]
		private DreamlightTabButton[] _tabs;

		[Cpp2IlInjected.Token(Token = "0x40025DD")]
		private static readonly int GameGuideTabIndex;

		[Cpp2IlInjected.Token(Token = "0x40025DE")]
		private static readonly int AccesibilityTabIndex;

		[Cpp2IlInjected.Token(Token = "0x40025DF")]
		private static readonly int ReturnToMainMenuTabIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40025E0")]
		[SerializeField]
		private GameObject[] _settingsPanels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40025E1")]
		[SerializeField]
		private AK.Wwise.Event _resetDefaultSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40025E2")]
		private DreamlightTabButton _selectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40025E3")]
		private GameObject _selectedPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40025E4")]
		private FocusNavigationElement _defaultFocusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40025E5")]
		private FocusNavigationElement _currentFocusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40025E6")]
		private ShortcutIndicator _resetDefaultShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40025E7")]
		private CancellationTokenSource cts = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40025E8")]
		private bool _sameFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40025E9")]
		[SerializeField]
		private TextBase _platformUsernameLabel;

		[Cpp2IlInjected.Token(Token = "0x40025EA")]
		private const int PlatformUsernameMaxLength = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40025EB")]
		[SerializeField]
		private AK.Wwise.Event _backSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40025EC")]
		[SerializeField]
		private DreamlightTabButton _saveGameButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40025ED")]
		private IEnumerator updateSavedAtLabelCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40025EE")]
		[SerializeField]
		[Header("Fill the field below to adjust size for Switch")]
		private int _switchFontMin = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40025EF")]
		[SerializeField]
		private int _switchFontMax;

		[Cpp2IlInjected.Token(Token = "0x17000647")]
		public GameObject SelectedPanel
		{
			[Cpp2IlInjected.Token(Token = "0x6002B22")]
			[Cpp2IlInjected.Address(RVA = "0x738EC0", Offset = "0x7378C0", VA = "0x180738EC0")]
			get
			{
				return _selectedPanel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000648")]
		public FocusNavigationElement CurrentFocusedElement
		{
			[Cpp2IlInjected.Token(Token = "0x6002B23")]
			[Cpp2IlInjected.Address(RVA = "0x739220", Offset = "0x737C20", VA = "0x180739220")]
			get
			{
				return _currentFocusedElement;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B24")]
			[Cpp2IlInjected.Address(RVA = "0x73A350", Offset = "0x738D50", VA = "0x18073A350")]
			set
			{
				_currentFocusedElement = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000649")]
		public bool IsGameGuideTabFocus
		{
			[Cpp2IlInjected.Token(Token = "0x6002B25")]
			[Cpp2IlInjected.Address(RVA = "0x126E1E0", Offset = "0x126CBE0", VA = "0x18126E1E0")]
			get
			{
				//Discarded unreachable code: IL_003e
				DreamlightTabButton selectedTab = _selectedTab;
				DreamlightTabButton[] tabs = _tabs;
				int gameGuideTabIndex = GameGuideTabIndex;
				DreamlightTabButton dreamlightTabButton = tabs[gameGuideTabIndex];
				bool flag = selectedTab == dreamlightTabButton;
				if (!flag)
				{
					return flag;
				}
				return _selectedTab.GetComponent<FocusNavigationElement>().IsInFocus;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064A")]
		[HideInInspector]
		public bool AdjustForSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6002B26")]
			[Cpp2IlInjected.Address(RVA = "0x126E1C0", Offset = "0x126CBC0", VA = "0x18126E1C0")]
			get
			{
				if (_switchFontMin == -1)
				{
					int num = 0;
				}
				return _switchFontMax != -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B27")]
		[Cpp2IlInjected.Address(RVA = "0x126CD40", Offset = "0x126B740", VA = "0x18126CD40", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//IL_0082: Expected I4, but got I8
			//IL_00da: Expected I4, but got I8
			base.OnPush(stack, param);
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			base.Background.GetComponent<MainMenuBackground>().SetLeftWidth(470f);
			DreamlightTabButton[] tabs = _tabs;
			int accesibilityTabIndex = AccesibilityTabIndex;
			DreamlightTabButton dreamlightTabButton = tabs[accesibilityTabIndex];
			int isButtonSupported = 0;
			uint num = default(uint);
			dreamlightTabButton.SetIsSupported((byte)isButtonSupported != 0, (byte)num != 0);
			DreamlightTabButton[] tabs2 = _tabs;
			int returnToMainMenuTabIndex = ReturnToMainMenuTabIndex;
			DreamlightTabButton dreamlightTabButton2 = tabs2[returnToMainMenuTabIndex];
			if ((object)GraphicSettings.CurrentGraphicSettingsData != null)
			{
			}
			bool isButtonSupported2 = num != 0;
			ulong num2 = default(ulong);
			dreamlightTabButton2.SetIsSupported(isButtonSupported2, (byte)num2 != 0);
			DreamlightTabButton[] tabs3 = _tabs;
			Func<DreamlightTabButton, bool> func = default(Func<DreamlightTabButton, bool>);
			if (_003C_003Ec._003C_003E9__30_0 == null)
			{
				func = (Func<DreamlightTabButton, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(DreamlightTabButton x)
				{
					if (x.gameObject.activeSelf)
					{
						return ((TemplateButton)x)._interactable;
					}
					int num5 = 0;
					throw new NullReferenceException();
				});
			}
			int num3 = MoreLinq.FindIndex<DreamlightTabButton>((IEnumerable<>)(object)tabs3, (Func<, >)(object)func);
			DreamlightTabButton dreamlightTabButton3 = (_selectedTab = _tabs[num3]);
			ulong num4 = default(ulong);
			_selectedTab.IsSelected = (byte)num4 != 0;
			GameObject panel = _settingsPanels[num3];
			int fromMove = 0;
			SelectPanel(panel, (byte)fromMove != 0);
			FocusNavigationElement focusNavigationElement = (_defaultFocusedElement = _tabs[num3].gameObject.GetComponentInChildren<FocusNavigationElement>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B28")]
		[Cpp2IlInjected.Address(RVA = "0x126C840", Offset = "0x126B240", VA = "0x18126C840", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0140
			//IL_0068: Expected O, but got I4
			int num = 0;
			base.OnFocusIn();
			DreamlightTabButton[] tabs = _tabs;
			int num2 = 0;
			int length = tabs.Length;
			if (num2 < length)
			{
				DreamlightTabButton dreamlightTabButton = tabs[num2];
				if (AdjustForSwitch)
				{
					int switchFontMax = _switchFontMax;
					int switchFontMin = _switchFontMin;
					dreamlightTabButton.SetSwitchFont(switchFontMin, switchFontMax);
				}
				dreamlightTabButton.UpdateDisplay();
				num2++;
			}
			TMP_Text versionText = _versionText;
			int num3 = 0;
			if (versionText != (UnityEngine.Object)num3)
			{
				int num4 = 0;
				if (!Debug.isDebugBuild)
				{
					int num5 = 0;
					if (!Application.webSecurityEnabled)
					{
						SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
						Gameloft.Common.Version _003CVersion_003Ek__BackingField = _003CInstance_003Ek__BackingField.Version;
						int build = _003CInstance_003Ek__BackingField.Version.version.build;
						string buildType = _003CInstance_003Ek__BackingField.Version.buildType;
					}
				}
				TMP_Text versionText2 = _versionText;
				Client client = SystemRoot.Instance.Client;
				int withPlayfabId = 0;
				string text = (versionText2.text = client.GetBuildSessionIdentifier((byte)withPlayfabId != 0));
			}
			int num6 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			IEnumerator enumerator = updateSavedAtLabelCoroutine;
			if (enumerator != null)
			{
				StopCoroutine(enumerator);
			}
			int _003C_003E1__state = default(int);
			_003CUpdateSavedAtLabel_003Ed__32 _003CUpdateSavedAtLabel_003Ed__ = new _003CUpdateSavedAtLabel_003Ed__32(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateSavedAtLabel_003Ed__._003C_003E4__this = this;
			updateSavedAtLabelCoroutine = _003CUpdateSavedAtLabel_003Ed__;
			IEnumerator routine = updateSavedAtLabelCoroutine;
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B29")]
		[Cpp2IlInjected.Address(RVA = "0x126DFF0", Offset = "0x126C9F0", VA = "0x18126DFF0")]
		[IteratorStateMachine(typeof(_003CUpdateSavedAtLabel_003Ed__32))]
		private IEnumerator UpdateSavedAtLabel()
		{
			int _003C_003E1__state = default(int);
			_003CUpdateSavedAtLabel_003Ed__32 _003CUpdateSavedAtLabel_003Ed__ = new _003CUpdateSavedAtLabel_003Ed__32(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateSavedAtLabel_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B2A")]
		[Cpp2IlInjected.Address(RVA = "0x126DE50", Offset = "0x126C850", VA = "0x18126DE50")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_002c
			//IL_0010: Expected O, but got I4
			FocusNavigationElement currentFocusedElement = _currentFocusedElement;
			int num = 0;
			if (currentFocusedElement != (UnityEngine.Object)num)
			{
			}
			FocusNavigationElement defaultFocusedElement = _defaultFocusedElement;
			base.MenuNavigation.FocusNavigation.SetFocus(defaultFocusedElement);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B2B")]
		[Cpp2IlInjected.Address(RVA = "0x126D210", Offset = "0x126BC10", VA = "0x18126D210", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChanged;
			focusNavigation.OnFocusChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B2C")]
		[Cpp2IlInjected.Address(RVA = "0x126DF40", Offset = "0x126C940", VA = "0x18126DF40", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_002e
			int num = 0;
			GameSettingsSystem.SaveAppliedSettings();
			((object)this)._002Ector();
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChanged;
			focusNavigation.OnFocusChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B2D")]
		[Cpp2IlInjected.Address(RVA = "0x126CC00", Offset = "0x126B600", VA = "0x18126CC00", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_005e
			SystemRoot.Instance.GetSystem<AudioManager>().PopGameState();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			if ((object)instance != null)
			{
				MainMenuBar _003CMainMenuBar_003Ek__BackingField = instance.MainMenuBar;
				if ((object)_003CMainMenuBar_003Ek__BackingField != null)
				{
					MainMenuShortcutBar shortcutBar = _003CMainMenuBar_003Ek__BackingField.ShortcutBar;
					if ((object)shortcutBar != null)
					{
						int toggle = 0;
						shortcutBar.ToggleResetDefautShortcutIndicator((byte)toggle != 0);
					}
				}
			}
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
			IEnumerator enumerator = updateSavedAtLabelCoroutine;
			if (enumerator != null)
			{
				StopCoroutine(enumerator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B2E")]
		[Cpp2IlInjected.Address(RVA = "0xF2E840", Offset = "0xF2D240", VA = "0x180F2E840")]
		private void OnClose()
		{
			//Discarded unreachable code: IL_001e
			AK.Wwise.Event @event = closeSFX;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B2F")]
		[Cpp2IlInjected.Address(RVA = "0x126C1E0", Offset = "0x126ABE0", VA = "0x18126C1E0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_00bd
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				ClearTabHighlight();
				DreamlightTabButton selectedTab = _selectedTab;
				DreamlightTabButton[] tabs = _tabs;
				int gameGuideTabIndex = GameGuideTabIndex;
				DreamlightTabButton dreamlightTabButton = tabs[gameGuideTabIndex];
				if (selectedTab == dreamlightTabButton)
				{
					SettingsGameGuide componentInChildren = _selectedPanel.GetComponentInChildren<SettingsGameGuide>();
				}
				return;
			}
			ClearTabHighlight();
			DreamlightTabButton selectedTab2 = _selectedTab;
			DreamlightTabButton[] tabs2 = _tabs;
			int gameGuideTabIndex2 = GameGuideTabIndex;
			DreamlightTabButton dreamlightTabButton2 = tabs2[gameGuideTabIndex2];
			if (selectedTab2 == dreamlightTabButton2)
			{
				SettingsGameGuide componentInChildren2 = _selectedPanel.GetComponentInChildren<SettingsGameGuide>();
				while (componentInChildren2.CurrentState == SettingsGameGuide.GameGuideState.Slides)
				{
				}
				FocusNavigationElement focusNavigationElement = (_currentFocusedElement = componentInChildren2._currentFocusNavElement);
			}
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B30")]
		[Cpp2IlInjected.Address(RVA = "0x126B610", Offset = "0x126A010", VA = "0x18126B610")]
		private void ClearTabHighlight()
		{
			//Discarded unreachable code: IL_002c
			DreamlightTabButton[] tabs = _tabs;
			int num = 0;
			int length = tabs.Length;
			if (num < length)
			{
				DreamlightTabButton dreamlightTabButton = tabs[num];
				int num2 = ((dreamlightTabButton.IsHighlighted = false) ? 1 : 0);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B31")]
		[Cpp2IlInjected.Address(RVA = "0x126BB70", Offset = "0x126A570", VA = "0x18126BB70", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			int _003C_003E1__state = default(int);
			int _003C_003E1__state2 = default(int);
			GameObject selectedPanel;
			do
			{
				if (redirectionType > RedirectionType.MainMenuGoToAchievement)
				{
					switch (redirectionType)
					{
					default:
						return;
					case RedirectionType.GamePopCurrentMenu:
						break;
					case RedirectionType.GameRestoreDefault:
						goto IL_0180;
					}
				}
				else if (redirectionType != RedirectionType.MenuNavGoBackward)
				{
					goto IL_0178;
				}
				DreamlightTabButton selectedTab = _selectedTab;
				DreamlightTabButton[] tabs = _tabs;
				int gameGuideTabIndex = GameGuideTabIndex;
				DreamlightTabButton dreamlightTabButton = tabs[gameGuideTabIndex];
				if (selectedTab == dreamlightTabButton)
				{
					while (_sameFrame)
					{
					}
					SettingsGameGuide componentInChildren = _selectedPanel.GetComponentInChildren<SettingsGameGuide>();
					if (componentInChildren.CurrentState == SettingsGameGuide.GameGuideState.Slides)
					{
						int num = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && (long)base.MenuNavigation.FocusNavigation._focusedElement != 0)
						{
							FocusNavigationElement focusNavigationElement = (_currentFocusedElement = componentInChildren._currentFocusNavElement);
						}
						_sameFrame = true;
						_003CWaitFrame_003Ed__41 _003CWaitFrame_003Ed__ = new _003CWaitFrame_003Ed__41(_003C_003E1__state);
						_003C_003E1__state = 0;
						_003CWaitFrame_003Ed__._003C_003E4__this = this;
						Coroutine coroutine = StartCoroutine(_003CWaitFrame_003Ed__);
						AK.Wwise.Event backSfx = _backSfx;
						if (backSfx != null)
						{
							GameObject gameObject = base.gameObject;
							uint num2 = backSfx.Post(gameObject);
						}
						int state = 0;
						componentInChildren.RefreshState((SettingsGameGuide.GameGuideState)state);
					}
				}
				int num3 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0) && (long)base.MenuNavigation.FocusNavigation._focusedElement != 0)
				{
					ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
					if (focusedElement != null)
					{
						int num4 = 0;
						if (focusedElement != null)
						{
							goto IL_0172;
						}
					}
					_003COnCloseTabUsingGamepad_003Ed__45 _003COnCloseTabUsingGamepad_003Ed__ = new _003COnCloseTabUsingGamepad_003Ed__45(_003C_003E1__state2);
					_003C_003E1__state2 = 0;
					_003COnCloseTabUsingGamepad_003Ed__._003C_003E4__this = this;
					Coroutine coroutine2 = StartCoroutine(_003COnCloseTabUsingGamepad_003Ed__);
				}
				goto IL_0172;
				IL_0172:
				OnClose();
				goto IL_0178;
				IL_0180:
				selectedPanel = _selectedPanel;
				continue;
				IL_0178:
				while (redirectionType != RedirectionType.MainMenuGoToAchievement)
				{
				}
				goto IL_0180;
			}
			while (!IsSettingsPanel(selectedPanel));
			AK.Wwise.Event resetDefaultSFX = _resetDefaultSFX;
			if (resetDefaultSFX != null)
			{
				GameObject gameObject2 = base.gameObject;
				uint num5 = resetDefaultSFX.Post(gameObject2);
			}
			CancellationToken token = cts.Token;
			int num6 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B32")]
		[Cpp2IlInjected.Address(RVA = "0x126E060", Offset = "0x126CA60", VA = "0x18126E060")]
		[IteratorStateMachine(typeof(_003CWaitFrame_003Ed__41))]
		private IEnumerator WaitFrame()
		{
			int _003C_003E1__state = default(int);
			_003CWaitFrame_003Ed__41 _003CWaitFrame_003Ed__ = new _003CWaitFrame_003Ed__41(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitFrame_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B33")]
		[Cpp2IlInjected.Address(RVA = "0x126D780", Offset = "0x126C180", VA = "0x18126D780")]
		public void SelectTab(DreamlightTabButton tab)
		{
			int fromMove = 0;
			SelectTab(tab, (byte)fromMove != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B34")]
		[Cpp2IlInjected.Address(RVA = "0x126D790", Offset = "0x126C190", VA = "0x18126D790")]
		public void SelectTab(DreamlightTabButton tab, bool fromMove = false)
		{
			//IL_0071: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			//IL_00cd: Expected I4, but got I8
			//IL_00fa: Expected O, but got I4
			DreamlightTabButton tab2 = tab;
			if (tab != tab)
			{
				DreamlightTabButton[] tabs = _tabs;
				Func<DreamlightTabButton, bool> func = (Func<DreamlightTabButton, bool>)(object)(Func<T, TResult>)delegate(DreamlightTabButton x)
				{
					DreamlightTabButton dreamlightTabButton = tab2;
					return x != dreamlightTabButton;
				};
				IEnumerable<DreamlightTabButton> enumerable = (IEnumerable<DreamlightTabButton>)Enumerable.Where<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Func<, >)(object)func);
				Action<DreamlightTabButton> _003C_003E9__43_ = _003C_003Ec._003C_003E9__43_2;
				if (_003C_003E9__43_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(DreamlightTabButton x)
					{
						//Discarded unreachable code: IL_000a
						int num9 = ((x.IsSelected = false) ? 1 : 0);
					};
				}
				MoreLinq.ForEach<DreamlightTabButton>((IEnumerable<>)enumerable, (Action<>)(object)_003C_003E9__43_);
				bool flag = default(bool);
				int num = default(int);
				if (flag)
				{
					num = 0;
				}
				_selectedTab = (DreamlightTabButton)num;
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					RecycleBin miscRecycleBin = instance._miscRecycleBin;
				}
				GameObject selectedPanel = _selectedPanel;
				int num3 = 0;
				if (selectedPanel != (UnityEngine.Object)num3)
				{
					GameObject selectedPanel2 = _selectedPanel;
					bool flag2 = default(bool);
					if (!flag2)
					{
					}
				}
			}
			int num4 = 0;
			if (tab != (UnityEngine.Object)num4)
			{
				ulong num5 = default(ulong);
				tab.IsSelected = (byte)num5 != 0;
			}
			DreamlightTabButton[] tabs2 = _tabs;
			int gameGuideTabIndex = GameGuideTabIndex;
			bool flag3 = default(bool);
			SettingsGameGuide componentInChildren = default(SettingsGameGuide);
			if (flag3)
			{
				componentInChildren = _selectedPanel.GetComponentInChildren<SettingsGameGuide>();
				int num6 = 0;
				if (componentInChildren != (UnityEngine.Object)num6 && componentInChildren.CurrentState == SettingsGameGuide.GameGuideState.Slides)
				{
					AK.Wwise.Event backSfx = _backSfx;
					if (backSfx != null)
					{
						GameObject gameObject = base.gameObject;
						uint num7 = backSfx.Post(gameObject);
					}
					int state = 0;
					componentInChildren.RefreshState((SettingsGameGuide.GameGuideState)state);
				}
			}
			FocusNavigationElement focusNavigationElement = (_currentFocusedElement = componentInChildren.gameObject.GetComponent<FocusNavigationElement>());
			DreamlightTabButton[] tabs3 = _tabs;
			GameObject[] settingsPanels = _settingsPanels;
			int length = settingsPanels.Length;
			int num8 = default(int);
			if (num8 < length)
			{
				GameObject panel = settingsPanels[num8];
				SelectPanel(panel, fromMove);
				return;
			}
			GameObject[] settingsPanels2 = _settingsPanels;
			Action<GameObject> action = default(Action<GameObject>);
			if (_003C_003Ec._003C_003E9__43_0 == null)
			{
				action = (Action<GameObject>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(GameObject x)
				{
					//Discarded unreachable code: IL_000a
					int active = 0;
					x.SetActive((byte)active != 0);
				});
			}
			MoreLinq.ForEach<GameObject>((IEnumerable<>)(object)settingsPanels2, (Action<>)(object)action);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B35")]
		[Cpp2IlInjected.Address(RVA = "0x126D470", Offset = "0x126BE70", VA = "0x18126D470")]
		public void SelectPanel(GameObject panel, bool fromMove = false)
		{
			//Discarded unreachable code: IL_00e3
			//IL_0066: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			GameObject[] settingsPanels = _settingsPanels;
			Action<GameObject> action = (Action<GameObject>)(object)(Action<T>)delegate(GameObject x)
			{
				//Discarded unreachable code: IL_0017
				GameObject gameObject = panel;
				bool active = x == gameObject;
				x.SetActive(active);
			};
			MoreLinq.ForEach<GameObject>((IEnumerable<>)(object)settingsPanels, (Action<>)(object)action);
			_selectedPanel = (GameObject)(object)action;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !fromMove)
			{
				SettingsMenuPanel settingsMenuPanel = default(SettingsMenuPanel);
				if ((object)settingsMenuPanel == null || (object)settingsMenuPanel.FirstFocusNavigationElement == null)
				{
				}
				int num2 = 0;
				FocusNavigationElement lastFocusedChild2 = default(FocusNavigationElement);
				if (settingsMenuPanel != (UnityEngine.Object)num2)
				{
					FocusNavigationElement lastFocusedChild = settingsMenuPanel.LastFocusedChild;
					int num3 = 0;
					if (lastFocusedChild != (UnityEngine.Object)num3)
					{
						lastFocusedChild2 = settingsMenuPanel.LastFocusedChild;
					}
				}
				base.MenuNavigation.FocusNavigation.SetFocus(lastFocusedChild2);
			}
			int num4 = 0;
			SettingsMenuPanel settingsMenuPanel2 = default(SettingsMenuPanel);
			int toggle = default(int);
			if (!(settingsMenuPanel2 != (UnityEngine.Object)num4))
			{
				toggle = 0;
			}
			int num5 = 0;
			UiRoot.Instance?.MainMenuBar?.ShortcutBar?.ToggleResetDefautShortcutIndicator((byte)toggle != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B36")]
		[Cpp2IlInjected.Address(RVA = "0x126C170", Offset = "0x126AB70", VA = "0x18126C170")]
		[IteratorStateMachine(typeof(_003COnCloseTabUsingGamepad_003Ed__45))]
		private IEnumerator OnCloseTabUsingGamepad()
		{
			int _003C_003E1__state = default(int);
			_003COnCloseTabUsingGamepad_003Ed__45 _003COnCloseTabUsingGamepad_003Ed__ = new _003COnCloseTabUsingGamepad_003Ed__45(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnCloseTabUsingGamepad_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B37")]
		[Cpp2IlInjected.Address(RVA = "0x126B9C0", Offset = "0x126A3C0", VA = "0x18126B9C0")]
		private void FocusSelectedTab()
		{
			//Discarded unreachable code: IL_005e
			DreamlightTabButton[] tabs = _tabs;
			Func<DreamlightTabButton, bool> _003C_003E9__46_ = _003C_003Ec._003C_003E9__46_0;
			if (_003C_003E9__46_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DreamlightTabButton x) => ((TemplateButton)x)._isSelected);
			}
			int num = MoreLinq.FindIndex<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Func<, >)(object)_003C_003E9__46_);
			MenuNavigation menuNavigation = base.MenuNavigation;
			DreamlightTabButton[] tabs2 = _tabs;
			FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
			FocusNavigationElement component = tabs2[num].GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B38")]
		[Cpp2IlInjected.Address(RVA = "0x126B680", Offset = "0x126A080", VA = "0x18126B680")]
		public void CustomFindNext(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_006e
			if (direction != 0)
			{
				return;
			}
			if ((object)currentElement != null)
			{
				int num = 0;
				if ((object)currentElement != null)
				{
					return;
				}
			}
			DreamlightTabButton[] tabs = _tabs;
			Func<DreamlightTabButton, bool> func = default(Func<DreamlightTabButton, bool>);
			if (_003C_003Ec._003C_003E9__46_0 == null)
			{
				func = (Func<DreamlightTabButton, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DreamlightTabButton x) => ((TemplateButton)x)._isSelected));
			}
			int num2 = MoreLinq.FindIndex<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Func<, >)(object)func);
			MenuNavigation menuNavigation = base.MenuNavigation;
			DreamlightTabButton[] tabs2 = _tabs;
			FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
			FocusNavigationElement component = tabs2[num2].GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B39")]
		[Cpp2IlInjected.Address(RVA = "0x126DF00", Offset = "0x126C900", VA = "0x18126DF00")]
		private void ToggleResetDefautShortcutIndicator(bool toggle)
		{
			int num = 0;
			UiRoot.Instance?.MainMenuBar?.ShortcutBar?.ToggleResetDefautShortcutIndicator(toggle);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3A")]
		[Cpp2IlInjected.Address(RVA = "0x126C440", Offset = "0x126AE40", VA = "0x18126C440")]
		private void OnDefaultSettings()
		{
			//Discarded unreachable code: IL_0031
			AK.Wwise.Event resetDefaultSFX = _resetDefaultSFX;
			if (resetDefaultSFX != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = resetDefaultSFX.Post(gameObject);
			}
			CancellationToken token = cts.Token;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3B")]
		[Cpp2IlInjected.Address(RVA = "0x126B8A0", Offset = "0x126A2A0", VA = "0x18126B8A0")]
		[AsyncStateMachine(typeof(_003CDefaultSettingsTask_003Ed__50))]
		private Task DefaultSettingsTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3C")]
		[Cpp2IlInjected.Address(RVA = "0x126D330", Offset = "0x126BD30", VA = "0x18126D330")]
		private void ResetDefaultSettings()
		{
			//Discarded unreachable code: IL_0028
			SystemRoot.Instance.GetSystem<GameSettingsSystem>().ResetToDefaults();
			int _003C_003E1__state = default(int);
			_003CResetDefaultSettingsLater_003Ed__52 _003CResetDefaultSettingsLater_003Ed__ = new _003CResetDefaultSettingsLater_003Ed__52(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetDefaultSettingsLater_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CResetDefaultSettingsLater_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3D")]
		[Cpp2IlInjected.Address(RVA = "0x126D2C0", Offset = "0x126BCC0", VA = "0x18126D2C0")]
		[IteratorStateMachine(typeof(_003CResetDefaultSettingsLater_003Ed__52))]
		private IEnumerator ResetDefaultSettingsLater()
		{
			int _003C_003E1__state = default(int);
			_003CResetDefaultSettingsLater_003Ed__52 _003CResetDefaultSettingsLater_003Ed__ = new _003CResetDefaultSettingsLater_003Ed__52(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetDefaultSettingsLater_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3E")]
		[Cpp2IlInjected.Address(RVA = "0x126C0D0", Offset = "0x126AAD0", VA = "0x18126C0D0")]
		private bool IsSettingsPanel(GameObject panel)
		{
			//IL_0010: Expected O, but got I4
			SettingsMenuPanel componentInChildren = panel.GetComponentInChildren<SettingsMenuPanel>();
			int num = 0;
			bool flag = componentInChildren != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			SettingsPanel settingsPanel = componentInChildren._settingsPanel;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3F")]
		[Cpp2IlInjected.Address(RVA = "0x126C5F0", Offset = "0x126AFF0", VA = "0x18126C5F0")]
		private void OnFocusChanged(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_009e
			//IL_003d: Expected O, but got I4
			//IL_0091: Expected O, but got I4
			DreamlightTabButton selectedTab = _selectedTab;
			DreamlightTabButton[] tabs = _tabs;
			int gameGuideTabIndex = GameGuideTabIndex;
			DreamlightTabButton dreamlightTabButton = tabs[gameGuideTabIndex];
			if (selectedTab == dreamlightTabButton)
			{
				return;
			}
			GameObject selectedPanel = _selectedPanel;
			int num = 0;
			if (!(selectedPanel != (UnityEngine.Object)num))
			{
				return;
			}
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
				return;
			}
			int num2 = 0;
			if (focusedElement == null)
			{
				return;
			}
			Transform parent = _selectedPanel.transform;
			Transform transform = default(Transform);
			if (transform.IsChildOf(parent))
			{
				SettingsMenuPanel componentInChildren = _selectedPanel.GetComponentInChildren<SettingsMenuPanel>();
				int num3 = 0;
				if (componentInChildren != (UnityEngine.Object)num3)
				{
					componentInChildren.LastFocusedChild = (FocusNavigationElement)focusedElement;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B40")]
		[Cpp2IlInjected.Address(RVA = "0x126E140", Offset = "0x126CB40", VA = "0x18126E140")]
		public SettingsMenu()
		{
		}//IL_0016: Expected I4, but got I8

	}
}
