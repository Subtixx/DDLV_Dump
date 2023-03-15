using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000676")]
	public class PromptButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400242C")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400242D")]
		[SerializeField]
		private TextBase _label;

		[Cpp2IlInjected.Token(Token = "0x17000630")]
		public Button Button
		{
			[Cpp2IlInjected.Token(Token = "0x60029C0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _button;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000631")]
		public TextBase Label
		{
			[Cpp2IlInjected.Token(Token = "0x60029C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _label;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029C2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PromptButton()
		{
		}
	}
}
