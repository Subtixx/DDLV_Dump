using System.Xml;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009AE")]
	public class TraitFilterItem : FilterItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003902")]
		public Color ColorHighligth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003903")]
		public Color ColorNormal;

		[Cpp2IlInjected.Token(Token = "0x6003CB7")]
		[Cpp2IlInjected.Address(RVA = "0x17F2EC0", Offset = "0x17F18C0", VA = "0x1817F2EC0", Slot = "4")]
		public override void Init(Filter filter, bool showText)
		{
			//Discarded unreachable code: IL_0015
			base.Init(filter, showText);
			Image image = bg.Image;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB8")]
		[Cpp2IlInjected.Address(RVA = "0x17F2F40", Offset = "0x17F1940", VA = "0x1817F2F40")]
		public void RefreshSize()
		{
			//Discarded unreachable code: IL_0028
			RectTransform component = text.GetComponent<RectTransform>();
			LayoutRebuilder.ForceRebuildLayoutImmediate(component);
			LayoutElement component2 = GetComponent<LayoutElement>();
			Vector2 sizeDelta = component.sizeDelta;
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)component2).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB9")]
		[Cpp2IlInjected.Address(RVA = "0x17F2E60", Offset = "0x17F1860", VA = "0x1817F2E60", Slot = "6")]
		public override void AddHighlight()
		{
			//Discarded unreachable code: IL_0021
			base.AddHighlight();
			TextMeshProUGUI textComponent = text.TextComponent;
			Color color = (textComponent.color = ColorHighligth);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CBA")]
		[Cpp2IlInjected.Address(RVA = "0x17F3030", Offset = "0x17F1A30", VA = "0x1817F3030", Slot = "7")]
		public override void RemoveHighlight()
		{
			//Discarded unreachable code: IL_0021
			base.RemoveHighlight();
			TextMeshProUGUI textComponent = text.TextComponent;
			Color color = (textComponent.color = ColorNormal);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CBB")]
		[Cpp2IlInjected.Address(RVA = "0xE26030", Offset = "0xE24A30", VA = "0x180E26030")]
		public TraitFilterItem()
		{
		}
	}
}
