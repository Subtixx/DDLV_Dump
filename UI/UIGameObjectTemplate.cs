using System;
using Cpp2IlInjected;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class UIGameObjectTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public int ID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Vector3 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public Vector3 Position3D;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Vector3 Rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public Vector3 Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public Vector2 SizeDelta;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xC96460", Offset = "0xC94E60", VA = "0x180C96460")]
	public unsafe UIGameObjectTemplate()
	{
		//IL_0012: Expected native int or pointer, but got O
		//IL_002d: Expected native int or pointer, but got O
		//IL_004d: Expected F4, but got I4
		//IL_0048: Expected native int or pointer, but got O
		float z = Vector3.zero.z;
		((Vector3*)(IntPtr)Rotation)->z = z;
		Vector3 one = Vector3.one;
		int num = 0;
		float z2 = one.z;
		((Vector3*)(IntPtr)Scale)->z = z2;
		SizeDelta = Vector2.zero;
		((Vector2*)(IntPtr)SizeDelta)->y = 0f;
		base._002Ector();
	}
}
