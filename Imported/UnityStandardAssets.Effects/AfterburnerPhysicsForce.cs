using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float effectAngle = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public float effectWidth = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public float effectDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public float force = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private Collider[] m_Cols;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private SphereCollider m_Sphere;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2F05ED0", Offset = "0x2F048D0", VA = "0x182F05ED0")]
		private void OnEnable()
		{
			//IL_0014: Expected O, but got I4
			Collider component = GetComponent<Collider>();
			if ((object)component == null)
			{
				int num = 0;
				m_Sphere = (SphereCollider)num;
			}
			int num2 = 0;
			m_Sphere = (SphereCollider)component;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2F04FE0", Offset = "0x2F039E0", VA = "0x182F04FE0")]
		private void FixedUpdate()
		{
			//Discarded unreachable code: IL_0130
			//IL_006e: Expected O, but got I4
			//IL_00a4: Expected F4, but got I4
			//IL_0121: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			int num = 0;
			Transform transform = base.transform;
			SphereCollider sphere = m_Sphere;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			float radius = m_Sphere.radius;
			Collider[] cols = default(Collider[]);
			m_Cols = cols;
			Collider[] cols2 = m_Cols;
			int num2 = 0;
			int num3 = 0;
			if (num2 < cols2.Length)
			{
				Rigidbody attachedRigidbody = cols2[num2].attachedRigidbody;
				int num4 = 0;
				if (attachedRigidbody != (Object)num4)
				{
					Transform transform2 = base.transform;
					Transform transform3 = m_Cols[num2].transform;
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					float num5 = default(float);
					float num6 = Mathf.InverseLerp(num5, num3, num5);
					Transform transform4 = m_Cols[num2].transform;
					Vector3 vector4 = default(Vector3);
					float z4 = vector4.z;
					Transform transform5 = base.transform;
					Rigidbody attachedRigidbody2 = m_Cols[num2].attachedRigidbody;
					Transform transform6 = m_Cols[num2].transform;
					int num7 = 0;
					Vector3 vector5 = default(Vector3);
					float z5 = vector5.z;
					Transform transform7 = base.transform;
					int num8 = 0;
					float num9 = Mathf.Clamp01(0.1f);
					attachedRigidbody2.AddForceAtPosition((Vector3)num8, (Vector3)num7);
				}
				Collider[] cols3 = m_Cols;
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F056F0", Offset = "0x2F040F0", VA = "0x182F056F0")]
		private void OnDrawGizmosSelected()
		{
			//Discarded unreachable code: IL_017e
			//IL_0010: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_007e: Expected O, but got F4
			//IL_0098: Expected O, but got F4
			//IL_00ae: Expected O, but got F4
			//IL_00c8: Expected O, but got F4
			//IL_00ea: Expected O, but got F4
			//IL_0100: Expected O, but got F4
			//IL_0116: Expected O, but got F4
			//IL_0133: Expected O, but got F4
			SphereCollider sphere = m_Sphere;
			int num = 0;
			bool flag = sphere == (Object)num;
			int num2 = 0;
			if (flag)
			{
				Collider component = GetComponent<Collider>();
				if ((object)component == null)
				{
				}
				int num3 = 0;
				m_Sphere = (SphereCollider)component;
			}
			SphereCollider sphere2 = m_Sphere;
			float num5 = (sphere2.radius = effectDistance);
			SphereCollider sphere3 = m_Sphere;
			float num6 = effectDistance;
			sphere3.center = (Vector3)num2;
			Vector3[] array = new Vector3[4];
			float z = Vector3.up.z;
			array[1] = (Vector3)z;
			float z2 = Vector3.up.z;
			num6 = num5;
			array[2] = (Vector3)z2;
			float z3 = Vector3.right.z;
			array[4] = (Vector3)z3;
			float z4 = Vector3.right.z;
			z2 = num5;
			array[5] = (Vector3)z4;
			Vector3[] array2 = new Vector3[4];
			float z5 = Vector3.right.z;
			z4 = num5;
			array2[1] = (Vector3)z5;
			float z6 = Vector3.right.z;
			array2[2] = (Vector3)z6;
			float z7 = Vector3.up.z;
			array2[4] = (Vector3)z7;
			float z8 = Vector3.up.z;
			z5 = num5;
			int num7 = 0;
			array2[5] = (Vector3)z8;
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z9 = vector.z;
			Transform transform2 = base.transform;
			Vector3 vector2 = default(Vector3);
			float z10 = vector2.z;
			Transform transform3 = base.transform;
			float num8 = effectAngle;
			Vector3 forward = Vector3.forward;
			float radius = m_Sphere.radius;
			num2++;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2F05F80", Offset = "0x2F04980", VA = "0x182F05F80")]
		public AfterburnerPhysicsForce()
		{
		}
	}
}
