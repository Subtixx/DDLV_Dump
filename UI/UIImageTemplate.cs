using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class UIImageTemplate : UIChildTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public Color Color;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xC965F0", Offset = "0xC94FF0", VA = "0x180C965F0", Slot = "4")]
	public override void Load(GameObject gameObject)
	{
		//Discarded unreachable code: IL_0029
		//IL_0017: Expected O, but got I4
		base.Load(gameObject);
		Image component = gameObject.GetComponent<Image>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			Color color2 = (component.color = Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0xC966C0", Offset = "0xC950C0", VA = "0x180C966C0", Slot = "5")]
	public override void Save(GameObject gameObject)
	{
		//Discarded unreachable code: IL_001b
		//IL_0017: Expected O, but got I4
		base.Save(gameObject);
		Image component = gameObject.GetComponent<Image>();
		int num = 0;
		if (!(component != (UnityEngine.Object)num))
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xC955C0", Offset = "0xC93FC0", VA = "0x180C955C0")]
	public UIImageTemplate()
	{
	}
}
