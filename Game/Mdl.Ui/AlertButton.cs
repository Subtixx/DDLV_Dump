using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000221")]
	public class AlertButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40012D9")]
		public AlertButtonStyle Style;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40012DA")]
		public string Label = "menu.button_common_okay";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40012DB")]
		public IItemData CostCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40012DC")]
		public int CostAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40012DD")]
		public bool IsDefaultGamepadFocus;

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1B0", Offset = "0xA3BBB0", VA = "0x180A3D1B0")]
		public unsafe AlertButton(AlertButtonStyle style, [Optional] string label, bool isDefaultGamepadFocus = false)
		{
			//IL_0018: Expected O, but got I4
			int num = 0;
			base.FieldGetter((string)num, label, ref *(isDefaultGamepadFocus ? ((object*)1) : ((object*)null)));
			Style = style;
			if ("menu.button_common_cancel" != null)
			{
				if (style != AlertButtonStyle.Cancel)
				{
					goto IL_003d;
				}
				Label = "menu.button_common_cancel";
			}
			Label = label;
			goto IL_003d;
			IL_003d:
			IsDefaultGamepadFocus = isDefaultGamepadFocus;
		}
	}
}
