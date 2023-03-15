using System;
using Cpp2IlInjected;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class UIElementTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public int ID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector2 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector3 Rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector3 Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Vector2 SizeDelta;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xC955D0", Offset = "0xC93FD0", VA = "0x180C955D0")]
	public unsafe UIElementTemplate()
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
