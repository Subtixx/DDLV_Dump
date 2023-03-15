using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200076C")]
	public class UpdateSliderText : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B52")]
		[SerializeField]
		private TMP_Text _text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B53")]
		[SerializeField]
		private Slider _slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B54")]
		[SerializeField]
		private string _textSuffix = "%";

		[Cpp2IlInjected.Token(Token = "0x6002F84")]
		[Cpp2IlInjected.Address(RVA = "0xCAC220", Offset = "0xCAAC20", VA = "0x180CAC220")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_002c
			float value = _slider.value;
			string textSuffix = _textSuffix;
			TMP_Text text = _text;
			string text2 = default(string);
			string text4 = (text.text = text2 + textSuffix);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F85")]
		[Cpp2IlInjected.Address(RVA = "0xCAC220", Offset = "0xCAAC20", VA = "0x180CAC220")]
		public void UpdateText()
		{
			//Discarded unreachable code: IL_002c
			float value = _slider.value;
			string textSuffix = _textSuffix;
			TMP_Text text = _text;
			string text2 = default(string);
			string text4 = (text.text = text2 + textSuffix);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F86")]
		[Cpp2IlInjected.Address(RVA = "0xCAC2A0", Offset = "0xCAACA0", VA = "0x180CAC2A0")]
		public UpdateSliderText()
		{
		}
	}
}
