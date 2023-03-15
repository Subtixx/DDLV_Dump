using System;
using Cpp2IlInjected;
using Mdl.Ui;
using TMPro;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class UITextTemplate : UIChildTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public float CharacterSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public float LineSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public float WordSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public float FontSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public TextAlignmentOptions Alignment;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public TMP_FontAsset Font;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public Material FontMaterial;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xC9A4F0", Offset = "0xC98EF0", VA = "0x180C9A4F0", Slot = "4")]
	public override void Load(GameObject gameObject)
	{
		//Discarded unreachable code: IL_00d1
		//IL_0017: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		base.Load(gameObject);
		TextBase component = gameObject.GetComponent<TextBase>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			TextMeshProUGUI textComponent = component.TextComponent;
			float num2 = (textComponent.characterSpacing = CharacterSpacing);
			float num3 = (textComponent.lineSpacing = LineSpacing);
			float num4 = (textComponent.wordSpacing = WordSpacing);
			TextAlignmentOptions textAlignmentOptions = (textComponent.alignment = Alignment);
			float num5 = (textComponent.fontSize = FontSize);
			Color color2 = (textComponent.color = Color);
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
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xC9A370", Offset = "0xC98D70", VA = "0x180C9A370")]
	private void Load(TextBase textBase)
	{
		//Discarded unreachable code: IL_00b0
		//IL_0075: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		TextMeshProUGUI textComponent = textBase.TextComponent;
		float num = (textComponent.characterSpacing = CharacterSpacing);
		float num2 = (textComponent.lineSpacing = LineSpacing);
		float num3 = (textComponent.wordSpacing = WordSpacing);
		TextAlignmentOptions textAlignmentOptions = (textComponent.alignment = Alignment);
		float num4 = (textComponent.fontSize = FontSize);
		Color color2 = (textComponent.color = Color);
		TMP_FontAsset font = Font;
		int num5 = 0;
		if (font != (UnityEngine.Object)num5)
		{
			TMP_FontAsset tMP_FontAsset = (textComponent.font = Font);
		}
		Material fontMaterial = FontMaterial;
		int num6 = 0;
		if (fontMaterial != (UnityEngine.Object)num6)
		{
			Material material = (textComponent.fontMaterial = FontMaterial);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xC9A7D0", Offset = "0xC991D0", VA = "0x180C9A7D0", Slot = "5")]
	public override void Save(GameObject gameObject)
	{
		//Discarded unreachable code: IL_0090
		//IL_0017: Expected O, but got I4
		base.Save(gameObject);
		TextBase component = gameObject.GetComponent<TextBase>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			TextMeshProUGUI textComponent = component.TextComponent;
			float num2 = (CharacterSpacing = ((TMP_Text)textComponent).m_characterSpacing);
			float num3 = (LineSpacing = ((TMP_Text)textComponent).m_lineSpacing);
			float num4 = (WordSpacing = ((TMP_Text)textComponent).m_wordSpacing);
			TextAlignmentOptions textAlignmentOptions = (Alignment = textComponent.alignment);
			float num5 = (FontSize = ((TMP_Text)textComponent).m_fontSize);
			TMP_FontAsset tMP_FontAsset = (Font = ((TMP_Text)textComponent).m_fontAsset);
			Material material = (FontMaterial = textComponent.materialForRendering);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xC9A6F0", Offset = "0xC990F0", VA = "0x180C9A6F0")]
	private void Save(TextBase textBase)
	{
		TextMeshProUGUI textComponent = textBase.TextComponent;
		float num = (CharacterSpacing = ((TMP_Text)textComponent).m_characterSpacing);
		float num2 = (LineSpacing = ((TMP_Text)textComponent).m_lineSpacing);
		float num3 = (WordSpacing = ((TMP_Text)textComponent).m_wordSpacing);
		TextAlignmentOptions textAlignmentOptions = (Alignment = textComponent.alignment);
		float num4 = (FontSize = ((TMP_Text)textComponent).m_fontSize);
		TMP_FontAsset tMP_FontAsset = (Font = ((TMP_Text)textComponent).m_fontAsset);
		Material material = (FontMaterial = textComponent.materialForRendering);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xC955C0", Offset = "0xC93FC0", VA = "0x180C955C0")]
	public UITextTemplate()
	{
	}
}
