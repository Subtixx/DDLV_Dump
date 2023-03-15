using System;
using Cpp2IlInjected;
using Mdl.Ui;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class UIThreeNineSlicesTemplate : UIChildTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public float Ratio;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xC9A930", Offset = "0xC99330", VA = "0x180C9A930", Slot = "4")]
	public override void Load(GameObject gameObject)
	{
		//Discarded unreachable code: IL_002f
		//IL_0017: Expected O, but got I4
		base.Load(gameObject);
		ThreeNineSlices component = gameObject.GetComponent<ThreeNineSlices>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			float num2 = (component.Ratio = Ratio);
			component.RefreshDisplay();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xC9A9F0", Offset = "0xC993F0", VA = "0x180C9A9F0", Slot = "5")]
	public override void Save(GameObject gameObject)
	{
		//Discarded unreachable code: IL_0029
		//IL_0017: Expected O, but got I4
		base.Save(gameObject);
		ThreeNineSlices component = gameObject.GetComponent<ThreeNineSlices>();
		int num = 0;
		if (component != (UnityEngine.Object)num)
		{
			float num2 = (Ratio = component.Ratio);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xC955C0", Offset = "0xC93FC0", VA = "0x180C955C0")]
	public UIThreeNineSlicesTemplate()
	{
	}
}
