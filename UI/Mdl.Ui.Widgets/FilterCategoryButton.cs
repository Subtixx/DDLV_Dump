using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000996")]
	public class FilterCategoryButton : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000997")]
		public delegate void Clicked(FilterCategoryButton button);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003890")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003891")]
		public Image bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003892")]
		public TextMeshProUGUI text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003893")]
		public Clicked OnClicked;

		[Cpp2IlInjected.Token(Token = "0x17000854")]
		public List<Filter> Filters
		{
			[Cpp2IlInjected.Token(Token = "0x6003C47")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CFilters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C48")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CFilters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<Filter>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x6003C49")]
		[Cpp2IlInjected.Address(RVA = "0x1532D40", Offset = "0x1531740", VA = "0x181532D40")]
		public void Init(string label, Color color, List<Filter> filters)
		{
			//Discarded unreachable code: IL_004b
			Filters = filters;
			Image image = bg;
			text.text = label;
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = Click;
			onClick.AddListener(call);
			LayoutRebuilder.ForceRebuildLayoutImmediate(text.GetComponent<RectTransform>());
		}

		[Cpp2IlInjected.Token(Token = "0x6003C4A")]
		[Cpp2IlInjected.Address(RVA = "0x1532B90", Offset = "0x1531590", VA = "0x181532B90")]
		private void Click()
		{
			OnClicked?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C4B")]
		[Cpp2IlInjected.Address(RVA = "0x1532EA0", Offset = "0x15318A0", VA = "0x181532EA0")]
		public FilterCategoryButton()
		{
		}
	}
}
