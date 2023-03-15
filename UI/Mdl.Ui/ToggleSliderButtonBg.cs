using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200076B")]
	public class ToggleSliderButtonBg : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B51")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.Token(Token = "0x6002F82")]
		[Cpp2IlInjected.Address(RVA = "0x17F1C50", Offset = "0x17F0650", VA = "0x1817F1C50")]
		private void Update()
		{
			//Discarded unreachable code: IL_0043
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			Button button = _button;
			if (!flag)
			{
				if (!button.enabled)
				{
					_button.enabled = true;
				}
			}
			else
			{
				int num2 = ((button.enabled = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F83")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ToggleSliderButtonBg()
		{
		}
	}
}
