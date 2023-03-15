using System;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CameraModifierCollection : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private CameraModifier[] cameraModifiers;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x164D850", Offset = "0x164C250", VA = "0x18164D850")]
	public CameraModifierCollection(GameObject targetObject, params CameraModifier[] cameraModifiers)
	{
		//Discarded unreachable code: IL_0048
		//IL_0025: Expected O, but got I4
		this.cameraModifiers = cameraModifiers;
		int num = 0;
		int length = cameraModifiers.Length;
		if (num < length)
		{
			CameraModifier cameraModifier = cameraModifiers[num];
			int num2 = 0;
			if (targetObject != (UnityEngine.Object)num2)
			{
				cameraModifier.targetObject = targetObject;
			}
			if (cameraModifier.shouldBeActive.AddReference() == CountedBool.RefState.FirstReference)
			{
				cameraModifier.OnStartModifier();
			}
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x164D790", Offset = "0x164C190", VA = "0x18164D790", Slot = "4")]
	public void Dispose()
	{
		//Discarded unreachable code: IL_000f
		int num = 0;
		int num2 = 0;
		CountedBool.RefState refState = default(CountedBool.RefState);
		if (refState == CountedBool.RefState.LastReference)
		{
			int num3 = 0;
		}
		num++;
	}
}
