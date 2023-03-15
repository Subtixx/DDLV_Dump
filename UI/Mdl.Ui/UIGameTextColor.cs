using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008BD")]
	public class UIGameTextColor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003455")]
		[SerializeField]
		private TextMeshProUGUI _text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003456")]
		public UIGameColors.GameColorName ColorToApply;

		[Cpp2IlInjected.Token(Token = "0x6003722")]
		[Cpp2IlInjected.Address(RVA = "0xC964D0", Offset = "0xC94ED0", VA = "0x180C964D0")]
		private void Awake()
		{
			//IL_0010: Expected O, but got I4
			TextMeshProUGUI text = _text;
			int num = 0;
			if (text == (Object)num)
			{
				TextMeshProUGUI textMeshProUGUI = (_text = GetComponent<TextMeshProUGUI>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003723")]
		[Cpp2IlInjected.Address(RVA = "0xC96570", Offset = "0xC94F70", VA = "0x180C96570")]
		private void Start()
		{
			//Discarded unreachable code: IL_0015
			TextMeshProUGUI text = _text;
			int num = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
		}

		[Cpp2IlInjected.Token(Token = "0x6003724")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UIGameTextColor()
		{
		}
	}
}
