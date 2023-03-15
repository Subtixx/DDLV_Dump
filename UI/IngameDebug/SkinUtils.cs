using System.Xml;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public static class SkinUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x15F4A90", Offset = "0x15F3490", VA = "0x1815F4A90")]
		public static void SetSkinText(this Text text, UISkin skin)
		{
			//Discarded unreachable code: IL_002b
			Color color = (text.color = skin.m_textColor);
			Font font2 = (text.font = skin.m_font);
			int num = (text.fontSize = skin.m_fontSize);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x15F4A20", Offset = "0x15F3420", VA = "0x1815F4A20")]
		public static void SetSkinInputFieldText(this Text text, UISkin skin)
		{
			//Discarded unreachable code: IL_002b
			Color color = (text.color = skin.m_inputFieldTextColor);
			Font font2 = (text.font = skin.m_font);
			int num = (text.fontSize = skin.m_fontSize);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x15F48D0", Offset = "0x15F32D0", VA = "0x1815F48D0")]
		public static void SetSkinButtonText(this Text text, UISkin skin)
		{
			//Discarded unreachable code: IL_002b
			Color color = (text.color = skin.m_buttonTextColor);
			Font font2 = (text.font = skin.m_font);
			int num = (text.fontSize = skin.m_fontSize);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x15F4940", Offset = "0x15F3340", VA = "0x1815F4940")]
		public static void SetSkinButton(this Button button, UISkin skin)
		{
			//Discarded unreachable code: IL_004b
			Graphic targetGraphic = ((Selectable)button).m_TargetGraphic;
			Color color = (targetGraphic.color = skin.m_buttonBackgroundColor);
			Text componentInChildren = button.GetComponentInChildren<Text>();
			Color color2 = (componentInChildren.color = skin.m_buttonTextColor);
			Font font2 = (componentInChildren.font = skin.m_font);
			int num = (componentInChildren.fontSize = skin.m_fontSize);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x15F4B00", Offset = "0x15F3500", VA = "0x1815F4B00")]
		public static void SetWidth(this LayoutElement layoutElement, float width)
		{
			//Discarded unreachable code: IL_000f
			layoutElement.minWidth = width;
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)layoutElement).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x15F4880", Offset = "0x15F3280", VA = "0x1815F4880")]
		public static void SetHeight(this LayoutElement layoutElement, float height)
		{
			//Discarded unreachable code: IL_000f
			layoutElement.minHeight = height;
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)layoutElement).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x15F47E0", Offset = "0x15F31E0", VA = "0x1815F47E0")]
		public static void SetAnchorMinMaxInputField(this RectTransform inputField, RectTransform label, Vector2 anchorMin, Vector2 anchorMax)
		{
		}//Discarded unreachable code: IL_0001

	}
}
