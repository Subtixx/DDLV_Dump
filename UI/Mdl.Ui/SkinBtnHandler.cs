using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000344")]
	public class SkinBtnHandler : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F59")]
		[SerializeField]
		private TextBase _skinText;

		[Cpp2IlInjected.Token(Token = "0x6001490")]
		[Cpp2IlInjected.Address(RVA = "0x15F2B00", Offset = "0x15F1500", VA = "0x1815F2B00")]
		public void SetText(int unlockAmount, int total)
		{
			//Discarded unreachable code: IL_0041
			//IL_0010: Expected O, but got I4
			TextBase skinText = _skinText;
			int num = 0;
			if (skinText == (Object)num)
			{
				TextBase textBase = (_skinText = GetComponentInChildren<TextBase>());
			}
			TextBase skinText2 = _skinText;
			string text = default(string);
			string text2 = default(string);
			string text4 = (skinText2.Text = text + "/" + text2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001491")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SkinBtnHandler()
		{
		}
	}
}
