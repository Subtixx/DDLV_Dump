using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000699")]
	public class CopyTextMeshpro : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024F5")]
		public Text LabelTocopy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024F6")]
		public bool withcollor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024F7")]
		public TextBase MPgui;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024F8")]
		public TextMeshProUGUI TextMP;

		[Cpp2IlInjected.Token(Token = "0x6002A89")]
		[Cpp2IlInjected.Address(RVA = "0x14B2080", Offset = "0x14B0A80", VA = "0x1814B2080")]
		private void Start()
		{
			TextBase textBase = (MPgui = GetComponent<TextBase>());
			TextMeshProUGUI textMeshProUGUI = (TextMP = GetComponent<TextMeshProUGUI>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A8A")]
		[Cpp2IlInjected.Address(RVA = "0x14B2100", Offset = "0x14B0B00", VA = "0x1814B2100")]
		private void Update()
		{
			//Discarded unreachable code: IL_004b
			//IL_0010: Expected O, but got I4
			TextBase mPgui = MPgui;
			int num = 0;
			if (mPgui != (Object)num)
			{
				Text labelTocopy = LabelTocopy;
				TextBase mPgui2 = MPgui;
				string text2 = (mPgui2.Text = labelTocopy.text);
				if (withcollor)
				{
					Text labelTocopy2 = LabelTocopy;
					TextMeshProUGUI textMP = TextMP;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A8B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CopyTextMeshpro()
		{
		}
	}
}
