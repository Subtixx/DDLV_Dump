using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000057")]
public class CurseEmitter : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public Vector3 center;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[HideInInspector]
	public Vector2 cachedPos;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static List<CurseEmitter> emitters = (List<CurseEmitter>)(object)new List<T>();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x110AD00", Offset = "0x1109700", VA = "0x18110AD00")]
	private unsafe void OnEnable()
	{
		//Discarded unreachable code: IL_0032
		//IL_0021: Expected native int or pointer, but got O
		Transform transform = base.transform;
		float z = center.z;
		Vector3 vector = default(Vector3);
		float z2 = vector.z;
		((Vector2*)(IntPtr)cachedPos)->y = z2;
		((List<T>)(object)emitters).Add((T)this);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x110AC70", Offset = "0x1109670", VA = "0x18110AC70")]
	private void OnDisable()
	{
		//Discarded unreachable code: IL_000d
		bool flag = ((List<T>)(object)emitters).Remove((T)this);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public CurseEmitter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x110ADE0", Offset = "0x11097E0", VA = "0x18110ADE0")]
	static CurseEmitter()
	{
		/*Error: Unexpected end of block*/;
	}
}
