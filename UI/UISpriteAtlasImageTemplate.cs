using System;
using Cpp2IlInjected;
using Mdl.Ui;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class UISpriteAtlasImageTemplate : UIChildTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public string URI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public Sprite Sprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public Color Color;

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xC9A080", Offset = "0xC98A80", VA = "0x180C9A080", Slot = "4")]
	public override void Load(GameObject gameObject)
	{
		//Discarded unreachable code: IL_005f
		//IL_0017: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		base.Load(gameObject);
		SpriteAtlasImage component = gameObject.GetComponent<SpriteAtlasImage>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			Sprite sprite = (component.Sprite = Sprite);
			string uRI = URI;
			component.SetTarget(uRI);
		}
		Image component2 = gameObject.GetComponent<Image>();
		int num2 = 0;
		if (component2 != (UnityEngine.Object)num2)
		{
			Color color2 = (component2.color = Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xC9A1D0", Offset = "0xC98BD0", VA = "0x180C9A1D0", Slot = "5")]
	public override void Save(GameObject gameObject)
	{
		//Discarded unreachable code: IL_006a
		//IL_0017: Expected O, but got I4
		//IL_002a: Expected O, but got I4
		//IL_0066: Expected O, but got I4
		base.Save(gameObject);
		SpriteAtlasImage component = gameObject.GetComponent<SpriteAtlasImage>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			Sprite sprite = component.Sprite;
			int num2 = 0;
			if (sprite != (UnityEngine.Object)num2)
			{
				Sprite sprite2 = (Sprite = component.Sprite);
				string text = (URI = component.Sprite.name);
			}
		}
		Image component2 = gameObject.GetComponent<Image>();
		int num3 = 0;
		if (!(component2 != (UnityEngine.Object)num3))
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xC955C0", Offset = "0xC93FC0", VA = "0x180C955C0")]
	public UISpriteAtlasImageTemplate()
	{
	}
}
