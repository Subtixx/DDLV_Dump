using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Platform;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Util;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200025D")]
	[RequiredAllNotNull]
	public class MainMenuBar : MenuBarBase, IHasLayout, IHasShortcutIndicators
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A9F")]
		[SerializeField]
		private GameObject _mapButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000AA0")]
		[SerializeField]
		private GameObject _eventButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000AA1")]
		[SerializeField]
		private RectTransform _tabsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000AA2")]
		public RectTransform Footer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000AA3")]
		public CanvasGroup FooterCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000AA4")]
		public MainMenuShortcutBar ShortcutBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000AA5")]
		private MenuLayoutTemplate _oldLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000AA6")]
		[SerializeField]
		private List<MenuLayoutTemplate> LayoutTemplates = (List<MenuLayoutTemplate>)(object)new List<T>
		{
			(T)new MenuLayoutTemplate
			{
				Platform = RuntimePlatform.WindowsPlayer,
				IsLandscape = true,
				CanvasScaleFactor = 0.25f
			},
			(T)new MenuLayoutTemplate
			{
				Platform = RuntimePlatform.WindowsEditor,
				IsLandscape = true,
				CanvasScaleFactor = 0.25f
			}
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000AA7")]
		[SerializeField]
		private List<ShortcutIndicatorSetTemplate> GamepadKeySetTemplates = (List<ShortcutIndicatorSetTemplate>)(object)new List<T>
		{
			(T)new ShortcutIndicatorSetTemplate
			{
				GamepadType = ControlType.None,
				Platform = RuntimePlatform.WindowsEditor
			},
			(T)new ShortcutIndicatorSetTemplate
			{
				GamepadType = ControlType.Xbox360,
				Platform = RuntimePlatform.WindowsPlayer
			}
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000AA8")]
		private int _lastMovedFrame;

		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		public List<MenuLayoutTemplate> Layouts
		{
			[Cpp2IlInjected.Token(Token = "0x6000F10")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "8")]
			get
			{
				return LayoutTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DC")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000F11")]
			[Cpp2IlInjected.Address(RVA = "0xD227E0", Offset = "0xD211E0", VA = "0x180D227E0", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		public List<ShortcutIndicatorSetTemplate> ShortcutIndicatorSets
		{
			[Cpp2IlInjected.Token(Token = "0x6000F12")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "10")]
			get
			{
				return GamepadKeySetTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DE")]
		private MainMenuTabButton[] _tabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000F13")]
			[Cpp2IlInjected.Address(RVA = "0xFA5060", Offset = "0xFA3A60", VA = "0x180FA5060")]
			get
			{
				//Discarded unreachable code: IL_0011
				RectTransform tabsHolder = _tabsHolder;
				int includeInactive = 0;
				return tabsHolder.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F14")]
		[Cpp2IlInjected.Address(RVA = "0xFA31D0", Offset = "0xFA1BD0", VA = "0x180FA31D0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0041
			int num = 0;
			RectTransform tabsHolder = _tabsHolder;
			int includeInactive = 0;
			MainMenuTabButton[] componentsInChildren = tabsHolder.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive != 0);
			if (num < componentsInChildren.Length)
			{
				RectTransform tabsHolder2 = _tabsHolder;
				int includeInactive2 = 0;
				((TemplateButton)tabsHolder2.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive2 != 0)[num]).UseHighlightWhenSelected = false;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F15")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void RefreshDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000F16")]
		[Cpp2IlInjected.Address(RVA = "0xFA4040", Offset = "0xFA2A40", VA = "0x180FA4040")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0046
			RectTransform tabsHolder = _tabsHolder;
			int includeInactive = 0;
			MainMenuTabButton[] componentsInChildren = tabsHolder.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive != 0);
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				MainMenuTabButton mainMenuTabButton = componentsInChildren[num];
				int num2 = ((mainMenuTabButton.IsHighlighted = false) ? 1 : 0);
				int num3 = ((mainMenuTabButton.IsSelected = false) ? 1 : 0);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F17")]
		[Cpp2IlInjected.Address(RVA = "0xFA40F0", Offset = "0xFA2AF0", VA = "0x180FA40F0")]
		internal void OnLayoutChange()
		{
			//Discarded unreachable code: IL_0066
			//IL_005f: Expected O, but got I4
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				RuntimePlatform runtimePlatform2 = PlatformUtils.GetRuntimePlatform();
				RuntimePlatform runtimePlatform = RuntimePlatform.WindowsPlayer;
				List<MenuLayoutTemplate> layoutTemplates = LayoutTemplates;
				Predicate<MenuLayoutTemplate> predicate = (Predicate<MenuLayoutTemplate>)(object)(Predicate<T>)delegate(MenuLayoutTemplate x)
				{
					//Discarded unreachable code: IL_002f
					int num5 = 0;
					CanvasHelper instanceMain = CanvasHelper.InstanceMain;
					if ((object)instanceMain == null || !instanceMain.IsLandscape)
					{
					}
					RuntimePlatform runtimePlatform3 = runtimePlatform;
					return x.IsLandscape = x.Platform == runtimePlatform3;
				};
				MenuLayoutTemplate menuLayoutTemplate = (MenuLayoutTemplate)((List<T>)(object)layoutTemplates).Find((Predicate<>)(object)predicate);
				if (menuLayoutTemplate != null)
				{
					_oldLayout = menuLayoutTemplate;
					List<GameObjectTemplate> templates = (List<GameObjectTemplate>)(object)menuLayoutTemplate.GetTemplates();
					if (flag)
					{
						int num3 = 0;
						if (this != (UnityEngine.Object)num3)
						{
							int num4 = 0;
							break;
						}
						continue;
					}
					break;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F18")]
		[Cpp2IlInjected.Address(RVA = "0xFA48E0", Offset = "0xFA32E0", VA = "0x180FA48E0", Slot = "5")]
		public override void SetSelectedTab(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_0150
			//IL_00bf: Expected O, but got I4
			//IL_0106: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			GameObject mapButton = _mapButton;
			bool active = (long)"{il2cpp field on {'constant30' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 1;
			mapButton.SetActive(active);
			GameObject eventButton = _eventButton;
			int num = 0;
			bool active2 = UiRoot.Instance.IsBattlePassUnlocked();
			eventButton.SetActive(active2);
			RectTransform tabsHolder = _tabsHolder;
			int includeInactive = 0;
			MainMenuTabButton[] componentsInChildren = tabsHolder.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive != 0);
			Func<MainMenuTabButton, bool> func = (Func<MainMenuTabButton, bool>)(object)(Func<T, TResult>)delegate(MainMenuTabButton x)
			{
				//Discarded unreachable code: IL_0018
				ShortcutDefinition shortcutDefinition = x.ShortcutDefinition;
				RedirectionType redirectionType2 = redirectionType;
				return shortcutDefinition.RedirectionType == redirectionType2;
			};
			int num2 = MoreLinq.FindIndex<MainMenuTabButton>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
			if (num2 > -1)
			{
				RectTransform tabsHolder2 = _tabsHolder;
				int includeInactive2 = 0;
				MainMenuTabButton selectedTab = tabsHolder2.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive2 != 0)[num2];
				MainMenuTabButton selectedTab2 = SelectedTab;
				int num3 = 0;
				if (selectedTab2 != (UnityEngine.Object)num3)
				{
					MainMenuTabButton selectedTab3 = SelectedTab;
					int num4 = ((selectedTab3.IsHighlighted = false) ? 1 : 0);
					MainMenuTabButton selectedTab4 = SelectedTab;
					int num5 = ((selectedTab4.IsSelected = false) ? 1 : 0);
				}
				SelectedTab = selectedTab;
				MainMenuTabButton selectedTab5 = SelectedTab;
				int num6 = 0;
				if (selectedTab5 != (UnityEngine.Object)num6)
				{
					SelectedTab.IsSelected = true;
					SelectedTab.RefreshDisplay();
				}
				RectTransform tabsHolder3 = _tabsHolder;
				int includeInactive3 = 0;
				MainMenuTabButton mainMenuTabButton = tabsHolder3.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive3 != 0)[num2];
				int num7 = ((mainMenuTabButton.IsHighlighted = false) ? 1 : 0);
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F19")]
		[Cpp2IlInjected.Address(RVA = "0xFA4CF0", Offset = "0xFA36F0", VA = "0x180FA4CF0")]
		private void SetSelectedTab(MainMenuTabButton tab)
		{
			//Discarded unreachable code: IL_006d
			//IL_0010: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			MainMenuTabButton selectedTab = SelectedTab;
			int num = 0;
			if (selectedTab != (UnityEngine.Object)num)
			{
				MainMenuTabButton selectedTab2 = SelectedTab;
				int num2 = ((selectedTab2.IsHighlighted = false) ? 1 : 0);
				MainMenuTabButton selectedTab3 = SelectedTab;
				int num3 = ((selectedTab3.IsSelected = false) ? 1 : 0);
			}
			SelectedTab = tab;
			MainMenuTabButton selectedTab4 = SelectedTab;
			int num4 = 0;
			if (selectedTab4 != (UnityEngine.Object)num4)
			{
				SelectedTab.IsSelected = true;
				SelectedTab.RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1A")]
		[Cpp2IlInjected.Address(RVA = "0xFA3A10", Offset = "0xFA2410", VA = "0x180FA3A10")]
		public void GoRight()
		{
			//Discarded unreachable code: IL_00bd
			//IL_0093: Expected O, but got I4
			if (base.gameObject.activeSelf)
			{
				int num = 0;
				int frameCount = Time.frameCount;
				if (_lastMovedFrame != frameCount)
				{
					_lastMovedFrame = frameCount;
					RectTransform tabsHolder = _tabsHolder;
					int includeInactive = 0;
					MainMenuTabButton[] componentsInChildren = tabsHolder.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive != 0);
					MainMenuTabButton selectedTab = SelectedTab;
					int num2 = MoreLinq.IndexOf<MainMenuTabButton>((IEnumerable<>)(object)componentsInChildren, selectedTab) + 1;
					RectTransform tabsHolder2 = _tabsHolder;
					int includeInactive2 = 0;
					MainMenuTabButton[] componentsInChildren2 = tabsHolder2.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive2 != 0);
					RectTransform tabsHolder3 = _tabsHolder;
					int includeInactive3 = 0;
					MainMenuTabButton tabButton = tabsHolder3.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive3 != 0)[num2];
					int num3 = 0;
					Redirect(tabButton, (MenuParam)num3);
					RectTransform tabsHolder4 = _tabsHolder;
					int includeInactive4 = 0;
					MainMenuTabButton mainMenuTabButton = tabsHolder4.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive4 != 0)[num2];
					int index = 0;
					mainMenuTabButton.PostSfx(index);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0xFA3820", Offset = "0xFA2220", VA = "0x180FA3820")]
		public void GoLeft()
		{
			//Discarded unreachable code: IL_00c0
			//IL_0096: Expected O, but got I4
			if (base.gameObject.activeSelf)
			{
				int num = 0;
				int frameCount = Time.frameCount;
				if (_lastMovedFrame != frameCount)
				{
					_lastMovedFrame = frameCount;
					RectTransform tabsHolder = _tabsHolder;
					int includeInactive = 0;
					MainMenuTabButton[] componentsInChildren = tabsHolder.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive != 0);
					MainMenuTabButton selectedTab = SelectedTab;
					int num2 = MoreLinq.IndexOf<MainMenuTabButton>((IEnumerable<>)(object)componentsInChildren, selectedTab);
					RectTransform tabsHolder2 = _tabsHolder;
					int includeInactive2 = 0;
					int length = tabsHolder2.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive2 != 0).Length;
					RectTransform tabsHolder3 = _tabsHolder;
					int includeInactive3 = 0;
					MainMenuTabButton tabButton = tabsHolder3.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive3 != 0)[length];
					int num3 = 0;
					Redirect(tabButton, (MenuParam)num3);
					RectTransform tabsHolder4 = _tabsHolder;
					int includeInactive4 = 0;
					MainMenuTabButton mainMenuTabButton = tabsHolder4.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive4 != 0)[length];
					int index = 0;
					mainMenuTabButton.PostSfx(index);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1C")]
		[Cpp2IlInjected.Address(RVA = "0xFA32A0", Offset = "0xFA1CA0", VA = "0x180FA32A0")]
		private MenuLayoutTemplate GetCurrentLayout()
		{
			//Discarded unreachable code: IL_0034
			int num = 0;
			RuntimePlatform runtimePlatform2 = PlatformUtils.GetRuntimePlatform();
			RuntimePlatform runtimePlatform = RuntimePlatform.WindowsPlayer;
			List<MenuLayoutTemplate> layoutTemplates = LayoutTemplates;
			Predicate<MenuLayoutTemplate> predicate = (Predicate<MenuLayoutTemplate>)(object)(Predicate<T>)delegate(MenuLayoutTemplate x)
			{
				//Discarded unreachable code: IL_002f
				int num2 = 0;
				CanvasHelper instanceMain = CanvasHelper.InstanceMain;
				if ((object)instanceMain == null || !instanceMain.IsLandscape)
				{
				}
				RuntimePlatform runtimePlatform3 = runtimePlatform;
				return x.IsLandscape = x.Platform == runtimePlatform3;
			};
			return (MenuLayoutTemplate)((List<T>)(object)layoutTemplates).Find((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1D")]
		[Cpp2IlInjected.Address(RVA = "0xFA3CB0", Offset = "0xFA26B0", VA = "0x180FA3CB0")]
		internal void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0053, IL_0059, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077, IL_007d
			int num = 0;
			int num2 = 0;
			ShortcutIndicatorSetTemplate currentShortcutIndicatorSet = GetCurrentShortcutIndicatorSet();
			List<ShortcutIndicatorTemplate> indicatorTemplates = (List<ShortcutIndicatorTemplate>)(object)currentShortcutIndicatorSet.GetIndicatorTemplates();
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				bool flag3 = default(bool);
				ShortcutDefinition shortcutDefinition = default(ShortcutDefinition);
				if (flag3 && shortcutDefinition.IndicatorVisualType != 0 && currentShortcutIndicatorSet.GamepadType != 0)
				{
					int num3 = 0;
					int num4 = 0;
				}
			}
			List<GameObjectTemplate> gameObjectTemplates = (List<GameObjectTemplate>)(object)currentShortcutIndicatorSet.GetGameObjectTemplates();
			bool flag4 = default(bool);
			if (flag4)
			{
				int num5 = 0;
				bool flag5 = default(bool);
				while (!flag5)
				{
				}
				int num6 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1E")]
		[Cpp2IlInjected.Address(RVA = "0xFA3390", Offset = "0xFA1D90", VA = "0x180FA3390", Slot = "11")]
		public ShortcutIndicatorSetTemplate GetCurrentShortcutIndicatorSet()
		{
			//Discarded unreachable code: IL_0167
			//IL_00d2: Expected I4, but got I8
			//IL_00dc: Expected I4, but got I8
			int num = 0;
			RuntimePlatform runtimePlatform2 = PlatformUtils.GetRuntimePlatform();
			int num2 = 0;
			RuntimePlatform runtimePlatform = runtimePlatform2;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			int num3 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			ControlType gamepadType = instance2.GetCurrentController((byte)useKeyboardAsController2 != 0);
			List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates = GamepadKeySetTemplates;
			if (!flag)
			{
				Predicate<ShortcutIndicatorSetTemplate> predicate = (Predicate<ShortcutIndicatorSetTemplate>)(object)(Predicate<T>)delegate(ShortcutIndicatorSetTemplate x)
				{
					//Discarded unreachable code: IL_0011
					ControlType controlType = gamepadType;
					return x.GamepadType == controlType;
				};
			}
			Predicate<ShortcutIndicatorSetTemplate> predicate2 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(Predicate<T>)delegate(ShortcutIndicatorSetTemplate x)
			{
				//Discarded unreachable code: IL_0011
				RuntimePlatform runtimePlatform3 = runtimePlatform;
				return x.Platform == runtimePlatform3;
			};
			ShortcutIndicatorSetTemplate shortcutIndicatorSetTemplate3 = default(ShortcutIndicatorSetTemplate);
			if (((List<T>)(object)gamepadKeySetTemplates).Find((Predicate<>)(object)predicate2) == null)
			{
				List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates2 = GamepadKeySetTemplates;
				Predicate<ShortcutIndicatorSetTemplate> predicate3 = default(Predicate<ShortcutIndicatorSetTemplate>);
				if (_003C_003Ec._003C_003E9__28_1 == null)
				{
					predicate3 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ShortcutIndicatorSetTemplate x) => x.GamepadType == ControlType.Xbox360));
				}
				if (((List<T>)(object)gamepadKeySetTemplates2).Find((Predicate<>)(object)predicate3) == null)
				{
					if (!flag)
					{
						ShortcutIndicatorSetTemplate shortcutIndicatorSetTemplate = new ShortcutIndicatorSetTemplate();
						shortcutIndicatorSetTemplate.GamepadType = ControlType.None;
						shortcutIndicatorSetTemplate.Platform = RuntimePlatform.WindowsEditor;
					}
					List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates3 = GamepadKeySetTemplates;
					Predicate<ShortcutIndicatorSetTemplate> predicate4 = default(Predicate<ShortcutIndicatorSetTemplate>);
					if (_003C_003Ec._003C_003E9__28_3 == null)
					{
						predicate4 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ShortcutIndicatorSetTemplate x) => x.GamepadType == ControlType.Xbox360));
					}
					ShortcutIndicatorSetTemplate shortcutIndicatorSetTemplate2 = (ShortcutIndicatorSetTemplate)((List<T>)(object)gamepadKeySetTemplates3).Find((Predicate<>)(object)predicate4);
					if (gamepadType == ControlType.Keyboard)
					{
						shortcutIndicatorSetTemplate3 = shortcutIndicatorSetTemplate2.Clone();
						List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates4 = GamepadKeySetTemplates;
						Predicate<ShortcutIndicatorSetTemplate> predicate5 = default(Predicate<ShortcutIndicatorSetTemplate>);
						if (_003C_003Ec._003C_003E9__28_4 == null)
						{
							predicate5 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ShortcutIndicatorSetTemplate x) => x.GamepadType == ControlType.None));
						}
						List<GameObjectTemplate> list = (shortcutIndicatorSetTemplate3.GameObjectTemplates = ((ShortcutIndicatorSetTemplate)((List<T>)(object)gamepadKeySetTemplates4).Find((Predicate<>)(object)predicate5)).GameObjectTemplates);
					}
				}
			}
			return shortcutIndicatorSetTemplate3;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1F")]
		[Cpp2IlInjected.Address(RVA = "0xFA48D0", Offset = "0xFA32D0", VA = "0x180FA48D0")]
		public void Redirect(MainMenuTabButton tabButton)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			Redirect(tabButton, (MenuParam)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F20")]
		[Cpp2IlInjected.Address(RVA = "0xFA4620", Offset = "0xFA3020", VA = "0x180FA4620")]
		public void Redirect(MainMenuTabButton tabButton, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0039
			if (!(SelectedTab == tabButton))
			{
				int num = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				int num2 = 0;
				IMenu bottom = menuStack.Bottom;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F21")]
		[Cpp2IlInjected.Address(RVA = "0xFA44D0", Offset = "0xFA2ED0", VA = "0x180FA44D0")]
		[AsyncStateMachine(typeof(_003CRedirectTask_003Ed__31))]
		private Task RedirectTask(MainMenuTabButton tabButton, CancellationToken ct, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F22")]
		[Cpp2IlInjected.Address(RVA = "0xFA4340", Offset = "0xFA2D40", VA = "0x180FA4340")]
		public void RedirectFromType(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0066
			RectTransform tabsHolder = _tabsHolder;
			int includeInactive = 0;
			MainMenuTabButton[] componentsInChildren = tabsHolder.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive != 0);
			Func<MainMenuTabButton, bool> func = (Func<MainMenuTabButton, bool>)(object)(Func<T, TResult>)delegate(MainMenuTabButton x)
			{
				//Discarded unreachable code: IL_0018
				ShortcutDefinition shortcutDefinition = x.ShortcutDefinition;
				RedirectionType redirectionType2 = redirectionType;
				return shortcutDefinition.RedirectionType == redirectionType2;
			};
			int num = MoreLinq.FindIndex<MainMenuTabButton>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
			if (num > -1)
			{
				RectTransform tabsHolder2 = _tabsHolder;
				int includeInactive2 = 0;
				MainMenuTabButton tabButton = tabsHolder2.GetComponentsInChildren<MainMenuTabButton>((byte)includeInactive2 != 0)[num];
				Redirect(tabButton, param);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F23")]
		[Cpp2IlInjected.Address(RVA = "0xFA3C00", Offset = "0xFA2600", VA = "0x180FA3C00")]
		public void OnClickExit()
		{
			//Discarded unreachable code: IL_0035
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num3 = 0;
				if (top == null)
				{
					int num4 = 0;
					UiRoot.Instance._menuStack.Pop();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F24")]
		[Cpp2IlInjected.Address(RVA = "0xFA4E10", Offset = "0xFA3810", VA = "0x180FA4E10")]
		public void SetVisibility(bool value)
		{
			//Discarded unreachable code: IL_0015
			//IL_0014: Expected F4, but got I4
			CanvasGroup canvasGroup = CanvasGroup;
			if (value)
			{
			}
			int num = 0;
			canvasGroup.alpha = num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F25")]
		[Cpp2IlInjected.Address(RVA = "0xFA4E40", Offset = "0xFA3840", VA = "0x180FA4E40")]
		public MainMenuBar()
		{
		}//Discarded unreachable code: IL_00b7
		//IL_0015: Expected I4, but got I8
		//IL_003d: Expected I4, but got I8
		//IL_0074: Expected I4, but got I8
		//IL_007e: Expected I4, but got I8
		//IL_0097: Expected I4, but got I8
		//IL_00a1: Expected I4, but got I8

	}
}
