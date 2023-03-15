using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Streaming
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200080A")]
	public class TransformData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002CD1")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002CD2")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002CD3")]
		public Vector3 localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002CD4")]
		public bool IsValid;

		[Cpp2IlInjected.Token(Token = "0x60023F9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60023FA")]
		[Cpp2IlInjected.Address(RVA = "0x13DEC10", Offset = "0x13DD610", VA = "0x1813DEC10")]
		public unsafe TransformData(Transform transform)
		{
			//Discarded unreachable code: IL_0036
			//IL_0014: Expected native int or pointer, but got O
			//IL_0029: Expected native int or pointer, but got O
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)position)->z = z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			((Vector3*)(IntPtr)localScale)->z = z2;
			IsValid = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60023FB")]
		[Cpp2IlInjected.Address(RVA = "0x13DEB80", Offset = "0x13DD580", VA = "0x1813DEB80")]
		public void ApplyTo(Transform transform)
		{
			//Discarded unreachable code: IL_0027
			float z = position.z;
			Quaternion quaternion2 = (transform.rotation = rotation);
			float z2 = localScale.z;
		}
	}
}
