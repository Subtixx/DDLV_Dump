using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000264")]
	public class MainMenuShortcutBar : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000AB9")]
		[SerializeField]
		private ShortcutIndicator _keyboardGoBackwardShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000ABA")]
		[SerializeField]
		private ShortcutIndicator _keyboardCloseMenuShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000ABB")]
		[SerializeField]
		private ShortcutIndicator _keyboardResetSettingsShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000ABC")]
		[SerializeField]
		private ShortcutIndicator _gamepadGoBackwardShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000ABD")]
		[SerializeField]
		private ShortcutIndicator _gamepadCloseMenuShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000ABE")]
		[SerializeField]
		private ShortcutIndicator _gamepadResetSettingsShortcut;

		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		public ShortcutIndicator ResetSettingsShortcut
		{
			[Cpp2IlInjected.Token(Token = "0x6000F36")]
			[Cpp2IlInjected.Address(RVA = "0xFA52D0", Offset = "0xFA3CD0", VA = "0x180FA52D0")]
			get
			{
				//Discarded unreachable code: IL_0022
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					return _gamepadResetSettingsShortcut;
				}
				return _keyboardResetSettingsShortcut;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		public ShortcutIndicator CloseMenuShortcut
		{
			[Cpp2IlInjected.Token(Token = "0x6000F37")]
			[Cpp2IlInjected.Address(RVA = "0xFA5250", Offset = "0xFA3C50", VA = "0x180FA5250")]
			get
			{
				//Discarded unreachable code: IL_0022
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					return _gamepadCloseMenuShortcut;
				}
				return _keyboardCloseMenuShortcut;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		public ShortcutIndicator GoBackwardShortcut
		{
			[Cpp2IlInjected.Token(Token = "0x6000F38")]
			[Cpp2IlInjected.Address(RVA = "0xFA5290", Offset = "0xFA3C90", VA = "0x180FA5290")]
			get
			{
				//Discarded unreachable code: IL_0022
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					return _gamepadGoBackwardShortcut;
				}
				return _keyboardGoBackwardShortcut;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F39")]
		[Cpp2IlInjected.Address(RVA = "0xFA50B0", Offset = "0xFA3AB0", VA = "0x180FA50B0")]
		private void Start()
		{
			//Discarded unreachable code: IL_002b
			GameObject gameObject = _keyboardCloseMenuShortcut.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _gamepadCloseMenuShortcut.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3A")]
		[Cpp2IlInjected.Address(RVA = "0xFA51B0", Offset = "0xFA3BB0", VA = "0x180FA51B0")]
		public void ToggleResetDefautShortcutIndicator(bool toggle)
		{
			//Discarded unreachable code: IL_004d
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
			_keyboardResetSettingsShortcut.gameObject.SetActive(toggle);
			if (toggle)
			{
				int num2 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
				}
				_keyboardResetSettingsShortcut.TransformToPreset();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3B")]
		[Cpp2IlInjected.Address(RVA = "0xFA5110", Offset = "0xFA3B10", VA = "0x180FA5110")]
		public void ToggleCloseMenuShortcutIndicator(bool toggle)
		{
			//Discarded unreachable code: IL_004d
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
			_keyboardCloseMenuShortcut.gameObject.SetActive(toggle);
			if (toggle)
			{
				int num2 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
				}
				_keyboardCloseMenuShortcut.TransformToPreset();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MainMenuShortcutBar()
		{
		}
	}
}
