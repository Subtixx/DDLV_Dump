using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ExtensionMethods
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2F10A00", Offset = "0x2F0F400", VA = "0x182F10A00")]
	public unsafe static Color ToHex(this Color color, string Hex)
	{
		//IL_0009: Expected F4, but got I4
		//IL_0004: Expected native int or pointer, but got O
		int num = 0;
		((Color*)(IntPtr)color)->r = num;
		return color;
	}
}
