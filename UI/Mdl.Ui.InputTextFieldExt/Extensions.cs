using Cpp2IlInjected;
using TMPro;

namespace Mdl.Ui.InputTextFieldExt
{
	[Cpp2IlInjected.Token(Token = "0x20009D2")]
	public static class Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6003D7C")]
		[Cpp2IlInjected.Address(RVA = "0x1521560", Offset = "0x151FF60", VA = "0x181521560")]
		public static void ActivateVirtualKeyboard(this TMP_InputField self)
		{
			InputTextBase.ShowNativeKeyboard(self);
		}
	}
}
