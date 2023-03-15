using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C21")]
	public class DistanceBasedBoundary : ICameraBoundary
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004396")]
		private Vector3 Origin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4004397")]
		private float Radius = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004398")]
		private float RadiusSquared = 25f;

		[Cpp2IlInjected.Token(Token = "0x17000759")]
		public bool IsConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6003733")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "6")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075A")]
		public string DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x6003734")]
			[Cpp2IlInjected.Address(RVA = "0x19CAC00", Offset = "0x19C9600", VA = "0x1819CAC00", Slot = "7")]
			get
			{
				return "DistanceBased";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003735")]
		[Cpp2IlInjected.Address(RVA = "0x19CABA0", Offset = "0x19C95A0", VA = "0x1819CABA0")]
		public unsafe DistanceBasedBoundary(Vector3 origin, float radius)
		{
			//IL_0031: Expected native int or pointer, but got O
			float z = origin.z;
			Radius = radius;
			((Vector3*)(IntPtr)Origin)->z = z;
			RadiusSquared = radius;
		}

		[Cpp2IlInjected.Token(Token = "0x6003736")]
		[Cpp2IlInjected.Address(RVA = "0x19CA890", Offset = "0x19C9290", VA = "0x1819CA890", Slot = "5")]
		public Vector3 ClosestPoint(Vector3 point)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z4 = vector3.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003737")]
		[Cpp2IlInjected.Address(RVA = "0x19CAAC0", Offset = "0x19C94C0", VA = "0x1819CAAC0", Slot = "4")]
		public bool IsIn(Vector3 point)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = point.z;
			/*Error: Unexpected end of block*/;
		}
	}
}
