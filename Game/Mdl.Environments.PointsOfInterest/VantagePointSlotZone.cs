using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006F8")]
	public class VantagePointSlotZone : MonoBehaviour, IVantagePointSlotPosition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028D8")]
		public float sizeX = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40028D9")]
		public float sizeZ = 1f;

		[Cpp2IlInjected.Token(Token = "0x6001EFB")]
		[Cpp2IlInjected.Address(RVA = "0xD43CD0", Offset = "0xD426D0", VA = "0x180D43CD0", Slot = "4")]
		public Vector3 PickPosition(GameObject agent)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EFC")]
		[Cpp2IlInjected.Address(RVA = "0xD43130", Offset = "0xD41B30", VA = "0x180D43130", Slot = "5")]
		public Vector3 LookAtTarget(GameObject agent)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EFD")]
		[Cpp2IlInjected.Address(RVA = "0xD43210", Offset = "0xD41C10", VA = "0x180D43210")]
		private void OnDrawGizmos()
		{
			//Discarded unreachable code: IL_011c
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			Transform transform5 = base.transform;
			Transform transform6 = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform7 = base.transform;
			Transform transform8 = base.transform;
			Transform transform9 = base.transform;
			Transform transform10 = base.transform;
			Transform transform11 = base.transform;
			Transform transform12 = base.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform transform13 = base.transform;
			Transform transform14 = base.transform;
			Transform transform15 = base.transform;
			Transform transform16 = base.transform;
			Transform transform17 = base.transform;
			Transform transform18 = base.transform;
			float num = sizeZ;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Transform transform19 = base.transform;
			Transform transform20 = base.transform;
			float num2 = sizeX;
			Transform transform21 = base.transform;
			float num3 = sizeZ;
			Transform transform22 = base.transform;
			Transform transform23 = base.transform;
			Transform transform24 = base.transform;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			Transform transform25 = base.transform;
			Transform transform26 = base.transform;
			Transform transform27 = base.transform;
			Vector3 vector5 = default(Vector3);
			float z5 = vector5.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EFE")]
		[Cpp2IlInjected.Address(RVA = "0xD43E90", Offset = "0xD42890", VA = "0x180D43E90")]
		public VantagePointSlotZone()
		{
		}
	}
}
