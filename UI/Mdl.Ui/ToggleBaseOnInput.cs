using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200089D")]
	public class ToggleBaseOnInput : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032E2")]
		[SerializeField]
		private GameObject _objForKeyboardMouseClickMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032E3")]
		[SerializeField]
		private GameObject _objForKeyboardMouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032E4")]
		[SerializeField]
		private GameObject _objForGamepad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032E5")]
		private bool _isClickToMoveEnabled;

		[Cpp2IlInjected.Token(Token = "0x17000794")]
		protected GameSettingsSystem Settings
		{
			[Cpp2IlInjected.Token(Token = "0x6003632")]
			[Cpp2IlInjected.Address(RVA = "0x17F0910", Offset = "0x17EF310", VA = "0x1817F0910")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<GameSettingsSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003633")]
		[Cpp2IlInjected.Address(RVA = "0x17F06C0", Offset = "0x17EF0C0", VA = "0x1817F06C0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0057
			//IL_001a: Expected O, but got I4
			int num = 0;
			if (InputDetectionHelper.IsConsole())
			{
				GameObject objForKeyboardMouseClickMove = _objForKeyboardMouseClickMove;
				int num2 = 0;
				if (objForKeyboardMouseClickMove != (Object)num2)
				{
					GameObject objForKeyboardMouseClickMove2 = _objForKeyboardMouseClickMove;
					int active = 0;
					objForKeyboardMouseClickMove2.SetActive((byte)active != 0);
				}
				GameObject objForKeyboardMouse = _objForKeyboardMouse;
				int active2 = 0;
				objForKeyboardMouse.SetActive((byte)active2 != 0);
				_objForGamepad.SetActive(value: true);
				Object.Destroy(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003634")]
		[Cpp2IlInjected.Address(RVA = "0x17F05E0", Offset = "0x17EEFE0", VA = "0x1817F05E0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0018
			bool flag = (_isClickToMoveEnabled = SystemRoot.Instance.GetSystem<GameSettingsSystem>().ClickToMove);
		}

		[Cpp2IlInjected.Token(Token = "0x6003635")]
		[Cpp2IlInjected.Address(RVA = "0x17F07D0", Offset = "0x17EF1D0", VA = "0x1817F07D0")]
		private void Update()
		{
			//Discarded unreachable code: IL_009d
			//IL_0010: Expected O, but got I4
			GameObject objForKeyboardMouseClickMove = _objForKeyboardMouseClickMove;
			int num = 0;
			bool flag = objForKeyboardMouseClickMove == (Object)num;
			int num2 = 0;
			if (!flag)
			{
				GameObject objForKeyboardMouseClickMove2 = _objForKeyboardMouseClickMove;
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
				}
				bool active = num2 != 0;
				objForKeyboardMouseClickMove2.SetActive(active);
			}
			GameObject objForKeyboardMouse = _objForKeyboardMouse;
			int num4 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			if (!instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
			{
			}
			objForKeyboardMouse.SetActive(value: true);
			GameObject objForGamepad = _objForGamepad;
			int num5 = 0;
			UiRoot instance3 = UiRoot.Instance;
			int useKeyboardAsController3 = 0;
			bool active2 = instance3.IsControllerConnected((byte)useKeyboardAsController3 != 0);
			objForGamepad.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003636")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ToggleBaseOnInput()
		{
		}
	}
}
