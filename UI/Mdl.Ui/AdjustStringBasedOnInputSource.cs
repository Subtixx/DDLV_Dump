using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200070B")]
	public class AdjustStringBasedOnInputSource : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002882")]
		[SerializeField]
		private TextBase _textBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002883")]
		[SerializeField]
		private string _stringIDGamepad = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002884")]
		[SerializeField]
		private string _stringIDKeyboard = "";

		[Cpp2IlInjected.Token(Token = "0x6002CD4")]
		[Cpp2IlInjected.Address(RVA = "0x87D280", Offset = "0x87BC80", VA = "0x18087D280")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0042
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			TextBase textBase = _textBase;
			if (!flag)
			{
				string text = (textBase.StringID = _stringIDKeyboard);
			}
			else
			{
				string text2 = (textBase.StringID = _stringIDGamepad);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD5")]
		[Cpp2IlInjected.Address(RVA = "0x87D2F0", Offset = "0x87BCF0", VA = "0x18087D2F0")]
		public AdjustStringBasedOnInputSource()
		{
		}
	}
}
