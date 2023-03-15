using System;
using Cpp2IlInjected;
using PlayFab.AuthenticationModels;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000894")]
	public class TextBaseTemplate : BehaviourTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032BD")]
		public bool AutoSizing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40032BE")]
		public float CharacterSpacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032BF")]
		public float LineSpacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40032C0")]
		public float WordSpacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032C1")]
		public float FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40032C2")]
		public float FontSizeMin = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032C3")]
		public float FontSizeMax = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40032C4")]
		public uint ColorValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40032C5")]
		public TextAlignmentOptions Alignment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40032C6")]
		public TMP_FontAsset Font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40032C7")]
		public Material FontMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40032C8")]
		public string StringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40032C9")]
		public string Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40032CA")]
		public TextBase.CustomXmlOption XmlOpt;

		[Cpp2IlInjected.Token(Token = "0x600361A")]
		[Cpp2IlInjected.Address(RVA = "0x17E9800", Offset = "0x17E8200", VA = "0x1817E9800")]
		public void Load(TextBase textBase)
		{
			//Discarded unreachable code: IL_0155
			//IL_0067: Invalid comparison between F4 and I4
			//IL_007d: Invalid comparison between F4 and I4
			//IL_009b: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			//IL_0143: Expected O, but got I4
			Load((Behaviour)textBase);
			TextMeshProUGUI textComponent = textBase.TextComponent;
			float num = (textComponent.characterSpacing = CharacterSpacing);
			float num2 = (textComponent.lineSpacing = LineSpacing);
			float num3 = (textComponent.wordSpacing = WordSpacing);
			TextAlignmentOptions textAlignmentOptions = (textComponent.alignment = Alignment);
			float num4 = (textComponent.fontSize = FontSize);
			float fontSizeMin = FontSizeMin;
			int num5 = 0;
			if (!(fontSizeMin <= (float)num5))
			{
				textComponent.fontSizeMin = fontSizeMin;
			}
			float fontSizeMax = FontSizeMax;
			if (!(fontSizeMax <= (float)num5))
			{
				textComponent.fontSizeMax = fontSizeMax;
			}
			TMP_FontAsset font = Font;
			int num6 = 0;
			if (font != (UnityEngine.Object)num6)
			{
				TMP_FontAsset tMP_FontAsset = (textComponent.font = Font);
			}
			Material fontMaterial = FontMaterial;
			int num7 = 0;
			if (fontMaterial != (UnityEngine.Object)num7)
			{
				Material material = (textComponent.fontMaterial = FontMaterial);
			}
			TextBase.CustomXmlOption customXmlOption = (textBase._parseCustomXml = XmlOpt);
			int num8 = 0;
			uint colorValue = ColorValue;
			uint colorValue2 = ColorValue;
			bool flag = (textComponent.enableAutoSizing = AutoSizing);
			string stringID = StringID;
			Color color = default(Color);
			int num9 = default(int);
			if ((object)color == null)
			{
				string stringID2 = StringID;
				string stringID3 = textBase._stringID;
				if ((object)color != null)
				{
					goto IL_0143;
				}
				textBase._stringID = stringID2;
				num9 = 0;
				textBase.RefreshText();
			}
			textBase.Text = (string)num9;
			goto IL_0143;
			IL_0143:
			textBase.RefreshText();
			LayoutRebuilder.MarkLayoutForRebuild(textBase.RectTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600361B")]
		[Cpp2IlInjected.Address(RVA = "0x17E9A90", Offset = "0x17E8490", VA = "0x1817E9A90")]
		public void Save(TextBase textBase)
		{
			//Discarded unreachable code: IL_00ea
			Save((Behaviour)textBase);
			TextMeshProUGUI textComponent = textBase.TextComponent;
			float num = (CharacterSpacing = ((TMP_Text)textComponent).m_characterSpacing);
			float num2 = (LineSpacing = ((TMP_Text)textComponent).m_lineSpacing);
			float num3 = (WordSpacing = ((TMP_Text)textComponent).m_wordSpacing);
			TextAlignmentOptions textAlignmentOptions = (Alignment = textComponent.alignment);
			float num4 = (FontSize = ((TMP_Text)textComponent).m_fontSize);
			float num5 = (FontSizeMin = ((TMP_Text)textComponent).m_fontSizeMin);
			float num6 = (FontSizeMax = ((TMP_Text)textComponent).m_fontSizeMax);
			TMP_FontAsset tMP_FontAsset = (Font = ((TMP_Text)textComponent).m_fontAsset);
			Material material = (FontMaterial = textComponent.materialForRendering);
			string text = (Text = textBase._text);
			string text2 = (StringID = textBase._stringID);
			bool flag = (AutoSizing = ((TMP_Text)textComponent).m_enableAutoSizing);
			TextBase.CustomXmlOption customXmlOption = (XmlOpt = textBase._parseCustomXml);
			Color32 color = default(Color32);
			int num7 = (int)(ColorValue = (uint)color.rgba);
		}

		[Cpp2IlInjected.Token(Token = "0x600361C")]
		[Cpp2IlInjected.Address(RVA = "0x17E9BF0", Offset = "0x17E85F0", VA = "0x1817E9BF0")]
		public TextBaseTemplate()
		{
			((GetAPIKeysResponse)(object)this)._002Ector();
		}
	}
}
