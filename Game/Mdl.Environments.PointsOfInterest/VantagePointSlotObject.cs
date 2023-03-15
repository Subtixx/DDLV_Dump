using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006F7")]
	public class VantagePointSlotObject : MonoBehaviour, IVantagePointSlotPosition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028D7")]
		public float radius = 1f;

		[Cpp2IlInjected.Token(Token = "0x6001EF8")]
		[Cpp2IlInjected.Address(RVA = "0xD42FE0", Offset = "0xD419E0", VA = "0x180D42FE0", Slot = "4")]
		public Vector3 PickPosition(GameObject agent)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF9")]
		[Cpp2IlInjected.Address(RVA = "0xA82C20", Offset = "0xA81620", VA = "0x180A82C20", Slot = "5")]
		public Vector3 LookAtTarget(GameObject agent)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EFA")]
		[Cpp2IlInjected.Address(RVA = "0x83A300", Offset = "0x838D00", VA = "0x18083A300")]
		public VantagePointSlotObject()
		{
		}
	}
}
