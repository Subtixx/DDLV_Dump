using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000006")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Tooltip("The radius of the sphere or capsule.")]
	public float m_Radius = 0.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[Tooltip("The height of the capsule.")]
	public float m_Height;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C380", Offset = "0x2F0AD80", VA = "0x182F0C380")]
	private void OnValidate()
	{
		//IL_0010: Expected F4, but got I4
		//IL_002a: Expected F4, but got I4
		float radius = m_Radius;
		int num = 0;
		float num2 = (m_Radius = Mathf.Max(radius, num));
		float height = m_Height;
		int num3 = 0;
		float num4 = (m_Height = Mathf.Max(height, num3));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B7E0", Offset = "0x2F0A1E0", VA = "0x182F0B7E0", Slot = "4")]
	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		//Discarded unreachable code: IL_0047
		//IL_0018: Invalid comparison between I4 and F4
		//IL_0097: Invalid comparison between F4 and I4
		Transform transform = base.transform;
		float num = m_Height * 0.5f;
		int num2 = 0;
		if (!((float)num2 >= num))
		{
			Direction direction = m_Direction;
			if (direction != 0)
			{
				switch (direction)
				{
				}
			}
			int num3 = 0;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			bool result = default(bool);
			return result;
		}
		int num4 = 0;
		Transform transform4 = base.transform;
		float z = m_Center.z;
		Vector3 vector = default(Vector3);
		float z2 = vector.z;
		particlePosition.x = particleRadius;
		particlePosition.y = particleRadius;
		float z3 = m_Center.z;
		Vector3 vector2 = default(Vector3);
		float z4 = vector2.z;
		float num5 = default(float);
		if (!(num5 <= (float)num2))
		{
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C780", Offset = "0x2F0B180", VA = "0x182F0C780")]
	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		//IL_000b: Invalid comparison between F4 and I4
		float sqrMagnitude = particlePosition.sqrMagnitude;
		int num = 0;
		if (!(sqrMagnitude <= (float)num) && !(particleRadius <= sqrMagnitude))
		{
			if (!(particleRadius > sqrMagnitude))
			{
			}
			float num2 = (particlePosition.z = sphereCenter.z);
		}
		int num3 = 0;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C010", Offset = "0x2F0AA10", VA = "0x182F0C010")]
	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		float sqrMagnitude = particlePosition.sqrMagnitude;
		if (!(particleRadius > particleRadius))
		{
		}
		if (!(particleRadius > particleRadius))
		{
		}
		float num = (particlePosition.z = sphereCenter.z);
		return true;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C3C0", Offset = "0x2F0ADC0", VA = "0x182F0C3C0")]
	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		//IL_0004: Invalid comparison between I4 and F4
		//IL_0013: Invalid comparison between F4 and I4
		//IL_001e: Invalid comparison between F4 and I4
		//IL_0041: Invalid comparison between F4 and I4
		//IL_0068: Invalid comparison between F4 and I4
		int num = 0;
		if ((float)num >= particleRadius)
		{
			goto IL_005d;
		}
		float sqrMagnitude = particlePosition.sqrMagnitude;
		if (particleRadius >= sqrMagnitude)
		{
			goto IL_0036;
		}
		if (!(sqrMagnitude <= (float)num))
		{
			float sqrMagnitude2 = particlePosition.sqrMagnitude;
			if (!(sqrMagnitude2 <= (float)num) && !(particleRadius <= sqrMagnitude2))
			{
				if (!(particleRadius > sqrMagnitude2))
				{
				}
				float num2 = (particlePosition.z = particlePosition.z);
				goto IL_0036;
			}
		}
		goto IL_0074;
		IL_0036:
		float sqrMagnitude3 = particlePosition.sqrMagnitude;
		if (!(sqrMagnitude3 <= (float)num) && !(particleRadius <= sqrMagnitude3))
		{
			if (!(particleRadius > sqrMagnitude3))
			{
			}
			float num3 = (particlePosition.z = capsuleP1.z);
			goto IL_005d;
		}
		goto IL_0074;
		IL_0074:
		int num4 = 0;
		/*Error: Unexpected end of block*/;
		IL_005d:
		float sqrMagnitude4 = particlePosition.sqrMagnitude;
		if (!(sqrMagnitude4 <= (float)num) && !(particleRadius <= sqrMagnitude4) && particleRadius > sqrMagnitude4)
		{
		}
		goto IL_0074;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BC80", Offset = "0x2F0A680", VA = "0x182F0BC80")]
	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		//IL_0004: Invalid comparison between I4 and F4
		//IL_0013: Invalid comparison between F4 and I4
		int num = 0;
		if (!((float)num >= particleRadius))
		{
			float sqrMagnitude = particlePosition.sqrMagnitude;
			if (!(particleRadius >= sqrMagnitude))
			{
				if (sqrMagnitude <= (float)num)
				{
					goto IL_002b;
				}
				float sqrMagnitude2 = particlePosition.sqrMagnitude;
			}
			float sqrMagnitude3 = particlePosition.sqrMagnitude;
		}
		float sqrMagnitude4 = particlePosition.sqrMagnitude;
		goto IL_002b;
		IL_002b:
		float num2 = (particlePosition.z = capsuleP0.z);
		return true;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C150", Offset = "0x2F0AB50", VA = "0x182F0C150")]
	private void OnDrawGizmosSelected()
	{
		//Discarded unreachable code: IL_0076
		//IL_0037: Invalid comparison between I4 and F4
		if (!base.enabled)
		{
			return;
		}
		int num = 0;
		Color magenta = Color.magenta;
		Color yellow = Color.yellow;
		Transform transform = base.transform;
		float height = m_Height;
		int num2 = 0;
		float num3 = height * 0.5f;
		if (!((float)num2 >= num3))
		{
			Direction direction = m_Direction;
			if (direction != 0)
			{
				switch (direction)
				{
				}
			}
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
		}
		Transform transform4 = base.transform;
		float z = m_Center.z;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C8C0", Offset = "0x2F0B2C0", VA = "0x182F0C8C0")]
	public unsafe DynamicBoneCollider()
	{
		//IL_0014: Expected I4, but got I8
		//IL_0026: Expected native int or pointer, but got O
		m_Direction = Direction.Y;
		float z = Vector3.zero.z;
		((Vector3*)(IntPtr)m_Center)->z = z;
		((MonoBehaviour)this)._002Ector();
	}
}
