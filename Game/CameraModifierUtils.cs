using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CameraModifierUtils
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x16CA830", Offset = "0x16C9230", VA = "0x1816CA830")]
	public static CameraModifierCollection StartModifier<T>(this Camera camera, [Optional] GameObject targetObject) where T : CameraModifier
	{
		CameraModifier[] array;
		do
		{
			array = new CameraModifier[1];
		}
		while (array != null && array == null);
		array[0] = (CameraModifier)(object)array;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x16CA930", Offset = "0x16C9330", VA = "0x1816CA930")]
	public static CameraModifierCollection StartModifiers<T, U>(this Camera P_0, GameObject P_1) where T : CameraModifier where U : CameraModifier
	{
		CameraModifier[] array;
		while (true)
		{
			array = new CameraModifier[2];
			if (array == null || array != null)
			{
				array[0] = (CameraModifier)(object)array;
				if (array == null || array != null)
				{
					break;
				}
			}
		}
		array[1] = (CameraModifier)(object)array;
		throw new NullReferenceException();
	}
}
