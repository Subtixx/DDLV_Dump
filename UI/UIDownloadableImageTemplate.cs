using System;
using Cpp2IlInjected;
using Mdl.Ui;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class UIDownloadableImageTemplate : UIChildTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public string URI;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xC953F0", Offset = "0xC93DF0", VA = "0x180C953F0", Slot = "4")]
	public override void Load(GameObject gameObject)
	{
		//Discarded unreachable code: IL_0029
		//IL_0017: Expected O, but got I4
		base.Load(gameObject);
		SpriteAtlasImage component = gameObject.GetComponent<SpriteAtlasImage>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			string uRI = URI;
			component.SetTarget(uRI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xC954B0", Offset = "0xC93EB0", VA = "0x180C954B0", Slot = "5")]
	public override void Save(GameObject gameObject)
	{
		//Discarded unreachable code: IL_0043
		//IL_0017: Expected O, but got I4
		//IL_002a: Expected O, but got I4
		base.Save(gameObject);
		SpriteAtlasImage component = gameObject.GetComponent<SpriteAtlasImage>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			Sprite sprite = component.Sprite;
			int num2 = 0;
			if (sprite != (UnityEngine.Object)num2)
			{
				string text = (URI = component.Sprite.name);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xC955C0", Offset = "0xC93FC0", VA = "0x180C955C0")]
	public UIDownloadableImageTemplate()
	{
	}
}
