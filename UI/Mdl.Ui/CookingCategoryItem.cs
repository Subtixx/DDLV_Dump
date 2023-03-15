using Cpp2IlInjected;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000375")]
	[RequiredAllNotNull]
	public class CookingCategoryItem : FilterItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40010C9")]
		[SerializeField]
		private AsyncAtlassedIcon icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40010CA")]
		[SerializeField]
		private Color NormalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40010CB")]
		[SerializeField]
		private Color HighlightedColor;

		[Cpp2IlInjected.Token(Token = "0x600161A")]
		[Cpp2IlInjected.Address(RVA = "0x14A5F30", Offset = "0x14A4930", VA = "0x1814A5F30", Slot = "4")]
		public override void Init(Filter filter, bool showText)
		{
			//Discarded unreachable code: IL_0043
			base.Filter = filter;
			if ((object)filter != null)
			{
				int num = 0;
				if ((object)filter != null && (object)typeof(IngredientTypeFilter).TypeHandle != null)
				{
					AsyncAtlassedIcon asyncAtlassedIcon = icon;
				}
			}
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = base.Click;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x600161B")]
		[Cpp2IlInjected.Address(RVA = "0x14A5ED0", Offset = "0x14A48D0", VA = "0x1814A5ED0", Slot = "6")]
		public override void AddHighlight()
		{
			//Discarded unreachable code: IL_0021
			base.AddHighlight();
			RawImage rawImage = icon.RawImage;
			Color color = (rawImage.color = HighlightedColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600161C")]
		[Cpp2IlInjected.Address(RVA = "0x14A6050", Offset = "0x14A4A50", VA = "0x1814A6050", Slot = "7")]
		public override void RemoveHighlight()
		{
			//Discarded unreachable code: IL_0021
			base.RemoveHighlight();
			RawImage rawImage = icon.RawImage;
			Color color = (rawImage.color = NormalColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600161D")]
		[Cpp2IlInjected.Address(RVA = "0xE26030", Offset = "0xE24A30", VA = "0x180E26030")]
		public CookingCategoryItem()
		{
		}
	}
}
