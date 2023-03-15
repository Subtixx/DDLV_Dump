using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001F4")]
	public class InputTextBase : TMP_InputField
	{
		[Cpp2IlInjected.Token(Token = "0x20001F5")]
		public enum SwitchNativeVirualKeyboardType
		{
			[Cpp2IlInjected.Token(Token = "0x400088B")]
			TextMeshProDefault,
			[Cpp2IlInjected.Token(Token = "0x400088C")]
			NativeDefault
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000889")]
		[SerializeField]
		public SwitchNativeVirualKeyboardType NintendoSwitchKeyboardType;

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0xD23740", Offset = "0xD22140", VA = "0x180D23740")]
		public void ActivateVirtualKeyboard()
		{
			//Discarded unreachable code: IL_0007
			ActivateInputField();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0xD23740", Offset = "0xD22140", VA = "0x180D23740")]
		public static void ShowNativeKeyboard(TMP_InputField inputField)
		{
			//Discarded unreachable code: IL_0007
			inputField.ActivateInputField();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0xD23740", Offset = "0xD22140", VA = "0x180D23740")]
		public static void ShowNativeKeyboard(TMP_InputField inputField, SwitchNativeVirualKeyboardType nxKeyboardType)
		{
			//Discarded unreachable code: IL_0007
			inputField.ActivateInputField();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0xD23760", Offset = "0xD22160", VA = "0x180D23760")]
		public InputTextBase()
		{
		}
	}
}
