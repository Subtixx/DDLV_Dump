using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000994")]
	public class FilterButton : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000995")]
		public delegate void Clicked(FilterButton button);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400388B")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400388C")]
		public Image bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400388D")]
		public TextMeshProUGUI text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400388E")]
		public Clicked OnClicked;

		[Cpp2IlInjected.Token(Token = "0x17000853")]
		public Filter Filter
		{
			[Cpp2IlInjected.Token(Token = "0x6003C3E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CFilter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C3F")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CFilter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C40")]
		[Cpp2IlInjected.Address(RVA = "0x1532BB0", Offset = "0x15315B0", VA = "0x181532BB0")]
		public void Init(Filter filter)
		{
			//Discarded unreachable code: IL_0058
			Filter = filter;
			Image image = bg;
			TextMeshProUGUI textMeshProUGUI = this.text;
			string text = (textMeshProUGUI.text = filter.DisplayName);
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = Click;
			onClick.AddListener(call);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.text.GetComponent<RectTransform>());
		}

		[Cpp2IlInjected.Token(Token = "0x6003C41")]
		[Cpp2IlInjected.Address(RVA = "0x1532B90", Offset = "0x1531590", VA = "0x181532B90")]
		private void Click()
		{
			OnClicked?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C42")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FilterButton()
		{
		}
	}
}
