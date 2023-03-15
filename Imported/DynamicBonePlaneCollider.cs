using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200000A")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Plane Collider")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void OnValidate()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C910", Offset = "0x2F0B310", VA = "0x182F0C910", Slot = "4")]
	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		//IL_004c: Invalid comparison between F4 and I4
		//IL_0061: Invalid comparison between I4 and F4
		float num2 = default(float);
		do
		{
			Vector3 up = Vector3.up;
			Direction direction = m_Direction;
			if (direction != 0)
			{
				if (direction != 0)
				{
					if (direction != Direction.Y)
					{
						goto IL_0030;
					}
					Transform transform = base.transform;
				}
				Transform transform2 = base.transform;
			}
			Transform transform3 = base.transform;
			goto IL_0030;
			IL_0030:
			Transform transform4 = base.transform;
			float z = m_Center.z;
			int num = 0;
			if (num2 <= (float)num)
			{
				break;
			}
			float num3 = (particlePosition.z = particlePosition.z);
		}
		while (0f > num2);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CAF0", Offset = "0x2F0B4F0", VA = "0x182F0CAF0")]
	private void OnDrawGizmosSelected()
	{
		//Discarded unreachable code: IL_006b
		if (!base.enabled)
		{
			return;
		}
		int num = 0;
		Color magenta = Color.magenta;
		Color yellow = Color.yellow;
		Vector3 up = Vector3.up;
		Direction direction = m_Direction;
		if (direction != 0)
		{
			if (direction != 0)
			{
				if (direction != Direction.Y)
				{
					goto IL_004c;
				}
				Transform transform = base.transform;
			}
			Transform transform2 = base.transform;
		}
		Transform transform3 = base.transform;
		goto IL_004c;
		IL_004c:
		Transform transform4 = base.transform;
		float z = m_Center.z;
		Vector3 vector = default(Vector3);
		float z2 = vector.z;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B7A0", Offset = "0x2F0A1A0", VA = "0x182F0B7A0")]
	public unsafe DynamicBonePlaneCollider()
	{
		//IL_0009: Expected I4, but got I8
		//IL_001b: Expected native int or pointer, but got O
		m_Direction = Direction.Y;
		float z = Vector3.zero.z;
		((Vector3*)(IntPtr)m_Center)->z = z;
		((MonoBehaviour)this)._002Ector();
	}
}
