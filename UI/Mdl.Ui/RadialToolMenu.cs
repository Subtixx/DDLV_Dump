using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Navigation;
using Mdl.Systems;
using Meta.Util;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000590")]
	public class RadialToolMenu : RadialMenuNavigation, IHasSFX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001E99")]
		public RadialToolButton SelectedTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001E9A")]
		[SerializeField]
		private GameObject _gamepadHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001E9B")]
		[SerializeField]
		private ImageHelper _toolIconImageHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001E9C")]
		[Space]
		public AK.Wwise.Event[] SFXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4001E9E")]
		private Vector2 _startPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4001E9F")]
		private float _minimumDragEvalDistance = 40f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001EA0")]
		private double _currentAngle = -4.616189618054758E+18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001EA1")]
		private Toolbox.ToolType _previousTool;

		[Cpp2IlInjected.Token(Token = "0x170005A1")]
		private Toolbox _toolbox
		{
			[Cpp2IlInjected.Token(Token = "0x6002468")]
			[Cpp2IlInjected.Address(RVA = "0xF352F0", Offset = "0xF33CF0", VA = "0x180F352F0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance._avatar.Toolbox;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x80"), Cpp2IlInjected.Token(Token = "0x4001E9D")]
		public bool IsMuted
		{
			[Cpp2IlInjected.Token(Token = "0x6002469")]
			[Cpp2IlInjected.Address(RVA = "0x725070", Offset = "0x723A70", VA = "0x180725070", Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600246A")]
			[Cpp2IlInjected.Address(RVA = "0x725360", Offset = "0x723D60", VA = "0x180725360", Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600246B")]
		[Cpp2IlInjected.Address(RVA = "0xF33EA0", Offset = "0xF328A0", VA = "0x180F33EA0", Slot = "4")]
		protected unsafe override void OnEnable()
		{
			//Discarded unreachable code: IL_0115, IL_011b, IL_0121, IL_0133
			//IL_0034: Expected F4, but got I4
			//IL_002f: Expected native int or pointer, but got O
			//IL_006d: Expected I4, but got I8
			//IL_0074: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_00f6: Expected I4, but got I8
			//IL_0114: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num3 = 0;
				Vector2 vector = (_startPos = Input.mousePosition);
				((Vector2*)(IntPtr)_startPos)->y = 0f;
				GameObject gamepadHint = _gamepadHint;
			}
			StopAllCoroutines();
			int _003C_003E1__state = default(int);
			RadialMenuNavigation._003COnRefresh_003Ed__22 _003COnRefresh_003Ed__ = new RadialMenuNavigation._003COnRefresh_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRefresh_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003COnRefresh_003Ed__);
			ulong num4 = default(ulong);
			_gamepadHint.SetActive((byte)num4 != 0);
			SelectedTool = (RadialToolButton)num;
			base.SelectedItem = (RadialMenuNavItem)num;
			Toolbox.ToolType currentToolType = _toolbox._currentToolType;
			IEnumerator enumerator = Container.GetEnumerator();
			ShortcutDefinition shortcutDefinition = default(ShortcutDefinition);
			if (enumerator != null)
			{
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					num++;
				}
				int num6 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num7 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				RadialToolButton radialToolButton = default(RadialToolButton);
				int num8 = ((radialToolButton.IsSelected = false) ? 1 : 0);
				while (currentToolType != radialToolButton.ToolType)
				{
				}
				shortcutDefinition = radialToolButton.ShortcutDefinition;
				if ((object)shortcutDefinition != null)
				{
					while (shortcutDefinition.RedirectionType == RedirectionType.MenuPhoto)
					{
					}
				}
				ulong num9 = default(ulong);
				radialToolButton.IsSelected = (byte)num9 != 0;
				SelectedTool = radialToolButton;
				base.SelectedItem = radialToolButton;
			}
			if ((object)shortcutDefinition != null)
			{
			}
			Toolbox toolbox = default(Toolbox);
			ulong num10 = default(ulong);
			toolbox.IsSelectingTool = (byte)num10 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600246C")]
		[Cpp2IlInjected.Address(RVA = "0xF34280", Offset = "0xF32C80", VA = "0x180F34280")]
		public void OnToolButtonClicked(RadialToolButton button)
		{
			//IL_0009: Expected O, but got I4
			//IL_0059: Expected O, but got I8
			//IL_0087: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			bool flag3 = default(bool);
			Toolbox toolbox2 = default(Toolbox);
			while (true)
			{
				int num = 0;
				if (button != (UnityEngine.Object)num)
				{
				}
				PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
				if (system.ControlsOverridden || system.AllOverridden)
				{
					return;
				}
				RadialToolButton selectedTool = SelectedTool;
				bool flag = button != selectedTool;
				RadialToolButton selectedTool2 = SelectedTool;
				if (!flag)
				{
					int num2 = ((selectedTool2.IsSelected = false) ? 1 : 0);
					SelectedTool = (RadialToolButton)0;
					Toolbox toolbox = _toolbox;
					int num3 = (int)(toolbox.CurrentToolType = Toolbox.ToolType.None);
					Hide();
					return;
				}
				if (flag3)
				{
					int num4 = 0;
				}
				int num5 = 0;
				if (!(button == (UnityEngine.Object)num5) && !SystemRoot.Instance.GetSystem<CurseSystem>().isLimboActive)
				{
					int num6 = 0;
					if (toolbox2 != (UnityEngine.Object)num6)
					{
						break;
					}
				}
			}
			Toolbox toolbox3 = default(Toolbox);
			int num7 = (int)(toolbox3.CurrentToolType = Toolbox.ToolType.None);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600246D")]
		[Cpp2IlInjected.Address(RVA = "0xF34740", Offset = "0xF33140", VA = "0x180F34740")]
		private void ProcessSelectedTool()
		{
			//Discarded unreachable code: IL_0057
			//IL_0010: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			RadialToolButton selectedTool = SelectedTool;
			int num = 0;
			if (!(selectedTool == (UnityEngine.Object)num) && !SystemRoot.Instance.GetSystem<CurseSystem>().isLimboActive)
			{
				Toolbox toolbox = _toolbox;
				int num2 = 0;
				if (toolbox != (UnityEngine.Object)num2)
				{
					Toolbox toolbox2 = _toolbox;
					Toolbox.ToolType toolType2 = (toolbox2.CurrentToolType = SelectedTool.ToolType);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600246E")]
		[Cpp2IlInjected.Address(RVA = "0xF348D0", Offset = "0xF332D0", VA = "0x180F348D0", Slot = "7")]
		public override void Show()
		{
			//Discarded unreachable code: IL_004d
			//IL_004c: Expected O, but got I4
			base.IsVisible = true;
			bool flag = default(bool);
			if (!flag)
			{
				PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (OverrideAllScope = SystemRoot.Instance.GetSystem<PlayerNavigation>().OverrideAllScope());
			}
			base.gameObject.SetActive(value: true);
			int num = 0;
			((UnityEvent<T0>)(object)UiRoot.Instance.Dispatcher.OnToolMenuChanged)?.Invoke((T0)1);
		}

		[Cpp2IlInjected.Token(Token = "0x600246F")]
		[Cpp2IlInjected.Address(RVA = "0xF33D40", Offset = "0xF32740", VA = "0x180F33D40", Slot = "8")]
		public override void Hide()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002470")]
		[Cpp2IlInjected.Address(RVA = "0xF34A40", Offset = "0xF33440", VA = "0x180F34A40")]
		public void Toggle(bool resetToolOnHide = false)
		{
			//Discarded unreachable code: IL_002c, IL_0030, IL_003e, IL_0046
			CurseSystem curseSystem = default(CurseSystem);
			if (!_toolbox.IsChangingTool && !_toolbox.IsUsingTool && !curseSystem.isLimboActive)
			{
				Show();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002471")]
		[Cpp2IlInjected.Address(RVA = "0xF33E80", Offset = "0xF32880", VA = "0x180F33E80")]
		internal void OnControllerChanged(ControlType controlType)
		{
			//Discarded unreachable code: IL_0008
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6002472")]
		[Cpp2IlInjected.Address(RVA = "0xF34680", Offset = "0xF33080", VA = "0x180F34680", Slot = "11")]
		public void PostSfx(int index)
		{
			//Discarded unreachable code: IL_0045
			if (!IsMuted)
			{
				AK.Wwise.Event[] sFXS = SFXS;
				if (sFXS.Length > index && sFXS[index].IsValid())
				{
					AK.Wwise.Event @event = SFXS[index];
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002473")]
		[Cpp2IlInjected.Address(RVA = "0xF34C70", Offset = "0xF33670", VA = "0x180F34C70")]
		private void Update()
		{
			//Discarded unreachable code: IL_0154, IL_015a, IL_016c
			//IL_0060: Expected F8, but got I8
			//IL_006d: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_007e: Invalid comparison between I4 and F4
			//IL_0088: Expected F8, but got I8
			//IL_00bd: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00d8: Expected O, but got I4
			//IL_00d8: Expected O, but got I4
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			int num = 0;
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int num3 = 0;
			int num4 = 0;
			if (instance.IsControllerConnected((byte)num4 != 0))
			{
				float axis = Input.GetAxis(RewiredAxisX);
				int num5 = 0;
				float axis2 = Input.GetAxis(RewiredAxisY);
				float axis3 = Input.GetAxis(RewiredAxisXAlt);
				int rewiredAxisYAlt = RewiredAxisYAlt;
				int num6 = 0;
				float axis4 = Input.GetAxis(rewiredAxisYAlt);
				ulong num7 = default(ulong);
				_currentAngle = (long)num7;
				axis4 = axis3;
				double num8 = AngleBetweenVectors((Vector2)num6, (Vector2)num3);
				double num9 = AngleBetweenVectors((Vector2)num6, (Vector2)num3);
				if ((float)num5 <= axis)
				{
				}
			}
			ulong num10 = default(ulong);
			_currentAngle = (long)num10;
			float y = _startPos.y;
			int num11 = 0;
			Vector2 zero = Vector2.zero;
			int num12 = 0;
			Vector2 mousePosition = Input.mousePosition;
			int num13 = 0;
			Vector2 startPos = _startPos;
			Vector2 startPos2 = default(Vector2);
			if (!(Vector2.Distance((Vector2)num12, (Vector2)num4) <= _minimumDragEvalDistance))
			{
				int num14 = 0;
				Vector2 mousePosition2 = Input.mousePosition;
				double num15 = AngleBetweenVectors((Vector2)num, (Vector2)num13);
				startPos2 = _startPos;
			}
			int num16 = 0;
			if ((object)startPos2 == (object)mousePosition)
			{
				return;
			}
			IEnumerator enumerator = Container.GetEnumerator();
			if (enumerator != null)
			{
				uint num17 = default(uint);
				if (num < (int)num17)
				{
					num += num;
					num++;
				}
				int num18 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num19 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				RadialMenuNavItem radialMenuNavItem = default(RadialMenuNavItem);
				if (radialMenuNavItem._isAvailable)
				{
					int angleRangeMin = radialMenuNavItem.AngleRangeMin;
					if ((long)num16 > (long)(IntPtr)startPos)
					{
						enumerator = (IEnumerator)(enumerator - angleRangeMin);
					}
				}
				int num20 = ((radialMenuNavItem.IsSelected = false) ? 1 : 0);
				base.SelectedItem = radialMenuNavItem;
			}
			if (enumerator == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002474")]
		[Cpp2IlInjected.Address(RVA = "0xF33C90", Offset = "0xF32690", VA = "0x180F33C90")]
		private double AngleBetweenVectors(Vector2 a, Vector2 b)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002475")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void RefreshDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002476")]
		[Cpp2IlInjected.Address(RVA = "0xF352B0", Offset = "0xF33CB0", VA = "0x180F352B0")]
		public RadialToolMenu()
		{
			//IL_001b: Expected F8, but got I8
			//IL_0028: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			//IL_003e: Expected I4, but got I8
			RewiredAxisX = 144;
			RewiredAxisY = 145;
			RewiredAxisXAlt = -1;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
