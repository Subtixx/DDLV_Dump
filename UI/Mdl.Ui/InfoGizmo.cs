using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.InputSystem;
using Mdl.Platform;
using Meta.Util;
using Rewired;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007AE")]
	public class InfoGizmo : MonoBehaviour, IHasLayout, IHasShortcutIndicators
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D1C")]
		protected MenuLayoutTemplate _oldLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D1D")]
		protected ControlType _controlType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D1E")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002D1F")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002D20")]
		protected CancellationToken? _cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002D21")]
		public Action FinishTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002D22")]
		protected bool _followTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002D23")]
		protected GameObject _targetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002D24")]
		[SerializeField]
		protected BubbleAnimation _bubbleAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002D25")]
		protected bool _showAnimationDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4002D26")]
		public bool UseKeyboardShortcutIndicators;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x4002D27")]
		[SerializeField]
		private bool _shouldBlockShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002D28")]
		protected Action onAnimationComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002D29")]
		private Vector3 hidePosition;

		[Cpp2IlInjected.Token(Token = "0x170006E9")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003118")]
			[Cpp2IlInjected.Address(RVA = "0xD227E0", Offset = "0xD211E0", VA = "0x180D227E0", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006EA")]
		public List<MenuLayoutTemplate> Layouts
		{
			[Cpp2IlInjected.Token(Token = "0x6003119")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "5")]
			get
			{
				return LayoutTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006EB")]
		public List<ShortcutIndicatorSetTemplate> ShortcutIndicatorSets
		{
			[Cpp2IlInjected.Token(Token = "0x600311A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "7")]
			get
			{
				return GamepadKeySetTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006EC")]
		protected BubbleAnimation bubbleAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x600311B")]
			[Cpp2IlInjected.Address(RVA = "0xD22810", Offset = "0xD21210", VA = "0x180D22810")]
			get
			{
				BubbleAnimation bubbleAnimation = _bubbleAnimation;
				if ((object)bubbleAnimation == null)
				{
					BubbleAnimation bubbleAnimation2 = (_bubbleAnimation = GetComponent<BubbleAnimation>());
				}
				return bubbleAnimation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600311C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "9")]
		protected virtual void Start()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600311D")]
		[Cpp2IlInjected.Address(RVA = "0xD217C0", Offset = "0xD201C0", VA = "0x180D217C0", Slot = "10")]
		public virtual void Init(GameObject target, IInfoGizmoArgs args, bool followTarget = false, [Optional] CancellationToken? ct)
		{
			//Discarded unreachable code: IL_0061
			MenuLayoutTemplate oldLayout = _oldLayout;
			MenuLayoutTemplate currentLayout = GetCurrentLayout();
			if (oldLayout != currentLayout)
			{
				OnLayoutChange();
			}
			int num = 0;
			ControlType currentController = UiRoot.Instance.GetCurrentController(useKeyboardAsController: true);
			if (_controlType != currentController)
			{
				_controlType = currentController;
				OnControllerChanged();
			}
			_targetObject = target;
			_followTarget = followTarget;
			CancellationToken? cancellationToken = _cancellationToken;
			bool flag = default(bool);
			if (!flag)
			{
				Hide();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600311E")]
		[Cpp2IlInjected.Address(RVA = "0xD21730", Offset = "0xD20130", VA = "0x180D21730", Slot = "11")]
		public virtual void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600311F")]
		[Cpp2IlInjected.Address(RVA = "0xD216D0", Offset = "0xD200D0", VA = "0x180D216D0", Slot = "12")]
		protected virtual IInfoGizmoArgs InitArgs(params object[] parameters)
		{
			if (parameters.Length != 1 || (object)typeof(IInfoGizmoArgs).TypeHandle == null)
			{
				int num = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003120")]
		[Cpp2IlInjected.Address(RVA = "0xD22530", Offset = "0xD20F30", VA = "0x180D22530", Slot = "13")]
		protected virtual void Update()
		{
			//Discarded unreachable code: IL_002c
			int num = 0;
			ControlType currentController = UiRoot.Instance.GetCurrentController(useKeyboardAsController: true);
			if (_controlType != currentController)
			{
				_controlType = currentController;
				OnControllerChanged();
			}
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003121")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0")]
		private void OnDestroy()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6003122")]
		[Cpp2IlInjected.Address(RVA = "0xD22060", Offset = "0xD20A60", VA = "0x180D22060", Slot = "14")]
		public virtual Task Show(CancellationToken ct)
		{
			//Discarded unreachable code: IL_00ad
			//IL_002e: Expected O, but got I4
			base.gameObject.SetActive(value: true);
			BubbleAnimation bubbleAnimation = _bubbleAnimation;
			if ((object)bubbleAnimation == null)
			{
				BubbleAnimation bubbleAnimation2 = (_bubbleAnimation = GetComponent<BubbleAnimation>());
			}
			int num = 0;
			if (bubbleAnimation != (UnityEngine.Object)num)
			{
				if (!_shouldBlockShortcuts)
				{
					BubbleAnimation bubbleAnimation3 = this.bubbleAnimation;
					Action action = delegate
					{
						_showAnimationDone = true;
						onAnimationComplete?.Invoke();
					};
				}
				int num2 = 0;
				BaseUiRoot.Scope menuNavigationBlocker = UiRoot.Instance.BlockShortcuts();
				BubbleAnimation bubbleAnimation4 = this.bubbleAnimation;
				Action onComplete = delegate
				{
					_showAnimationDone = true;
					onAnimationComplete?.Invoke();
				};
				Action onKill = delegate
				{
				};
				bubbleAnimation4.Show(onComplete, onKill);
			}
			UpdatePosition();
			int num3 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6003123")]
		[Cpp2IlInjected.Address(RVA = "0xD22040", Offset = "0xD20A40", VA = "0x180D22040")]
		protected void OnShowAnimationDone()
		{
			_showAnimationDone = true;
			onAnimationComplete?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6003124")]
		[Cpp2IlInjected.Address(RVA = "0xD21500", Offset = "0xD1FF00", VA = "0x180D21500")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0087
			//IL_004c: Expected O, but got I4
			FinishTask?.Invoke();
			HideImpl();
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			MenuLayoutTemplate oldLayout = _oldLayout;
			if (oldLayout != null)
			{
				ShortcutSetDefinition shortcutSet = oldLayout.ShortcutSet;
				int num2 = 0;
				if (shortcutSet != (UnityEngine.Object)num2)
				{
					int num3 = 0;
					InputProvider inputProvider = DefaultInputProvider.Get();
					int[] array = new int[1];
					int num4 = (array[0] = _oldLayout.ShortcutSet.RewiredMapCategoryId);
					inputProvider.DisableMaps(array);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003125")]
		[Cpp2IlInjected.Address(RVA = "0xD218E0", Offset = "0xD202E0", VA = "0x180D218E0", Slot = "15")]
		public virtual void Kill()
		{
			Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x6003126")]
		[Cpp2IlInjected.Address(RVA = "0xD20D80", Offset = "0xD1F780", VA = "0x180D20D80")]
		public void DestroyInfoGizmo()
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003127")]
		[Cpp2IlInjected.Address(RVA = "0xD213B0", Offset = "0xD1FDB0", VA = "0x180D213B0", Slot = "16")]
		protected virtual void HideImpl()
		{
			//Discarded unreachable code: IL_0053
			//IL_0022: Expected O, but got I4
			BubbleAnimation bubbleAnimation = _bubbleAnimation;
			if ((object)bubbleAnimation == null)
			{
				BubbleAnimation bubbleAnimation2 = (_bubbleAnimation = GetComponent<BubbleAnimation>());
			}
			int num = 0;
			if (bubbleAnimation != (UnityEngine.Object)num)
			{
				BubbleAnimation bubbleAnimation3 = default(BubbleAnimation);
				if ((object)_bubbleAnimation == null)
				{
					bubbleAnimation3 = (_bubbleAnimation = GetComponent<BubbleAnimation>());
				}
				Action onComplete = DestroyInfoGizmo;
				bubbleAnimation3.Hide(onComplete);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003128")]
		[Cpp2IlInjected.Address(RVA = "0xD222E0", Offset = "0xD20CE0", VA = "0x180D222E0", Slot = "17")]
		protected virtual void UpdatePosition()
		{
			//Discarded unreachable code: IL_005a, IL_0069
			//IL_0010: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			GameObject targetObject = _targetObject;
			int num = 0;
			if (targetObject != (UnityEngine.Object)num && _followTarget)
			{
				int num2 = 0;
				Camera main = Camera.main;
				int num3 = 0;
				if (main != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					Camera main2 = Camera.main;
					Transform transform = _targetObject.transform;
					int num5 = 0;
					base.transform.position = (Vector3)num5;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003129")]
		[Cpp2IlInjected.Address(RVA = "0xD21C80", Offset = "0xD20680", VA = "0x180D21C80", Slot = "18")]
		internal virtual void OnLayoutChange()
		{
			//Discarded unreachable code: IL_00eb
			//IL_0040: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			int num = 0;
			MenuLayoutTemplate currentLayout = GetCurrentLayout();
			int num2 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			MenuLayoutTemplate oldLayout = _oldLayout;
			if (oldLayout != null)
			{
				ShortcutSetDefinition shortcutSet = oldLayout.ShortcutSet;
				int num3 = 0;
				if (shortcutSet != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					InputProvider inputProvider = DefaultInputProvider.Get();
					int[] array = new int[1];
					int num5 = (array[0] = _oldLayout.ShortcutSet.RewiredMapCategoryId);
					inputProvider.DisableMaps(array);
				}
			}
			if (currentLayout == null)
			{
				return;
			}
			ShortcutSetDefinition shortcutSet2 = currentLayout.ShortcutSet;
			int num6 = 0;
			if (shortcutSet2 != (UnityEngine.Object)num6)
			{
				int num7 = 0;
				InputProvider inputProvider2 = DefaultInputProvider.Get();
				int[] array2 = new int[1];
				int num8 = (array2[0] = currentLayout.ShortcutSet.RewiredMapCategoryId);
				inputProvider2.EnableMaps(array2);
			}
			if (currentLayout == null)
			{
				return;
			}
			_oldLayout = currentLayout;
			List<GameObjectTemplate> templates = (List<GameObjectTemplate>)(object)currentLayout.GetTemplates();
			bool flag = default(bool);
			if (flag)
			{
				int num9 = 0;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				int num10 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600312A")]
		[Cpp2IlInjected.Address(RVA = "0xD20DE0", Offset = "0xD1F7E0", VA = "0x180D20DE0")]
		internal MenuLayoutTemplate GetCurrentLayout()
		{
			//Discarded unreachable code: IL_005c
			//IL_003c: Expected I4, but got I8
			int num = 0;
			RuntimePlatform runtimePlatform2 = PlatformUtils.GetRuntimePlatform();
			int num2 = 0;
			RuntimePlatform runtimePlatform = runtimePlatform2;
			if (Application.platform != 0)
			{
				int num3 = 0;
				if (Application.platform != RuntimePlatform.OSXPlayer)
				{
					goto IL_003c;
				}
			}
			if (runtimePlatform == RuntimePlatform.OSXPlayer)
			{
				runtimePlatform = RuntimePlatform.WindowsPlayer;
			}
			goto IL_003c;
			IL_003c:
			List<MenuLayoutTemplate> layoutTemplates = LayoutTemplates;
			Predicate<MenuLayoutTemplate> predicate = (Predicate<MenuLayoutTemplate>)(object)(Predicate<T>)delegate(MenuLayoutTemplate x)
			{
				//Discarded unreachable code: IL_0029
				int num4 = 0;
				if (!CanvasHelper.InstanceMain.IsLandscape)
				{
				}
				RuntimePlatform runtimePlatform3 = runtimePlatform;
				return x.IsLandscape = x.Platform == runtimePlatform3;
			};
			return (MenuLayoutTemplate)((List<T>)(object)layoutTemplates).Find((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x600312B")]
		[Cpp2IlInjected.Address(RVA = "0xD218F0", Offset = "0xD202F0", VA = "0x180D218F0", Slot = "19")]
		internal virtual void OnControllerChanged()
		{
			//Discarded unreachable code: IL_004a, IL_0050, IL_0056, IL_005c, IL_0062, IL_0068, IL_006e, IL_0074
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
				if (flag3 && shortcutDefinition.IndicatorVisualType != 0)
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

		[Cpp2IlInjected.Token(Token = "0x600312C")]
		[Cpp2IlInjected.Address(RVA = "0xD20EF0", Offset = "0xD1F8F0", VA = "0x180D20EF0", Slot = "8")]
		public ShortcutIndicatorSetTemplate GetCurrentShortcutIndicatorSet()
		{
			//Discarded unreachable code: IL_0171
			//IL_00dc: Expected I4, but got I8
			//IL_00e6: Expected I4, but got I8
			int num = 0;
			RuntimePlatform runtimePlatform2 = PlatformUtils.GetRuntimePlatform();
			int num2 = 0;
			RuntimePlatform runtimePlatform = runtimePlatform2;
			UiRoot instance = UiRoot.Instance;
			bool useKeyboardShortcutIndicators = UseKeyboardShortcutIndicators;
			bool flag = instance.IsControllerConnected(useKeyboardShortcutIndicators);
			int num3 = 0;
			UiRoot instance2 = UiRoot.Instance;
			bool useKeyboardShortcutIndicators2 = UseKeyboardShortcutIndicators;
			ControlType gamepadType = instance2.GetCurrentController(useKeyboardShortcutIndicators2);
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
				if (_003C_003Ec._003C_003E9__38_1 == null)
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
					if (_003C_003Ec._003C_003E9__38_3 == null)
					{
						predicate4 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ShortcutIndicatorSetTemplate x) => x.GamepadType == ControlType.Xbox360));
					}
					ShortcutIndicatorSetTemplate shortcutIndicatorSetTemplate2 = (ShortcutIndicatorSetTemplate)((List<T>)(object)gamepadKeySetTemplates3).Find((Predicate<>)(object)predicate4);
					if (gamepadType == ControlType.Keyboard)
					{
						shortcutIndicatorSetTemplate3 = shortcutIndicatorSetTemplate2.Clone();
						List<ShortcutIndicatorSetTemplate> gamepadKeySetTemplates4 = GamepadKeySetTemplates;
						Predicate<ShortcutIndicatorSetTemplate> predicate5 = default(Predicate<ShortcutIndicatorSetTemplate>);
						if (_003C_003Ec._003C_003E9__38_4 == null)
						{
							predicate5 = (Predicate<ShortcutIndicatorSetTemplate>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ShortcutIndicatorSetTemplate x) => x.GamepadType == ControlType.None));
						}
						List<GameObjectTemplate> list = (shortcutIndicatorSetTemplate3.GameObjectTemplates = ((ShortcutIndicatorSetTemplate)((List<T>)(object)gamepadKeySetTemplates4).Find((Predicate<>)(object)predicate5)).GameObjectTemplates);
					}
				}
			}
			return shortcutIndicatorSetTemplate3;
		}

		[Cpp2IlInjected.Token(Token = "0x600312D")]
		[Cpp2IlInjected.Address(RVA = "0xD21390", Offset = "0xD1FD90", VA = "0x180D21390")]
		public int GetTargetInstanceID()
		{
			//Discarded unreachable code: IL_000c
			return _targetObject.GetInstanceID();
		}

		[Cpp2IlInjected.Token(Token = "0x600312E")]
		[Cpp2IlInjected.Address(RVA = "0xD22590", Offset = "0xD20F90", VA = "0x180D22590")]
		public unsafe InfoGizmo()
		{
			//Discarded unreachable code: IL_00ce
			//IL_0015: Expected I4, but got I8
			//IL_003d: Expected I4, but got I8
			//IL_0074: Expected I4, but got I8
			//IL_007e: Expected I4, but got I8
			//IL_0097: Expected I4, but got I8
			//IL_00a1: Expected I4, but got I8
			//IL_00c0: Expected F4, but got I4
			//IL_00bb: Expected native int or pointer, but got O
			((Vector3*)(IntPtr)hidePosition)->z = 0f;
			_followTarget = true;
			base._002Ector();
		}
	}
}
