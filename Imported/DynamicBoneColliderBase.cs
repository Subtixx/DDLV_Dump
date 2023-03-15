using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum Direction
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Z
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum Bound
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Outside,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Inside
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Tooltip("The axis of the capsule's height.")]
	public Direction m_Direction = Direction.Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Tooltip("The center of the sphere or capsule, in the object's local space.")]
	public Vector3 m_Center;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Tooltip("Constrain bones to outside bound or inside bound.")]
	public Bound m_Bound;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "4")]
	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		int num = 0;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B7A0", Offset = "0x2F0A1A0", VA = "0x182F0B7A0")]
	public unsafe DynamicBoneColliderBase()
	{
		//IL_0009: Expected I4, but got I8
		//IL_001b: Expected native int or pointer, but got O
		float z = Vector3.zero.z;
		((Vector3*)(IntPtr)m_Center)->z = z;
		base._002Ector();
	}
}
