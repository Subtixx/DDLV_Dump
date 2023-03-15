using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.CameraFeedback
{
	[Cpp2IlInjected.Token(Token = "0x2000942")]
	public class CameraFeedbackRotation : CameraFeedbackExtension
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003358")]
		[SerializeField]
		private float lerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003359")]
		private Vector3 modification;

		[Cpp2IlInjected.Token(Token = "0x6002A9B")]
		[Cpp2IlInjected.Address(RVA = "0x164C570", Offset = "0x164AF70", VA = "0x18164C570", Slot = "6")]
		public unsafe override void OnFeedback(ref CameraFeedbackSystem.Modification modification)
		{
			//IL_0042: Expected native int or pointer, but got O
			float z = this.modification.z;
			Quaternion rotation = modification.rotation;
			float z2 = this.modification.z;
			Vector3 zero = Vector3.zero;
			int num = 0;
			float z3 = zero.z;
			float deltaTime = Time.deltaTime;
			((Vector3*)(IntPtr)this.modification)->z = z3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9C")]
		[Cpp2IlInjected.Address(RVA = "0x164C690", Offset = "0x164B090", VA = "0x18164C690", Slot = "7")]
		public unsafe override void OnReset()
		{
			//IL_0012: Expected native int or pointer, but got O
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)modification)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9D")]
		[Cpp2IlInjected.Address(RVA = "0xBA18D0", Offset = "0xBA02D0", VA = "0x180BA18D0")]
		public unsafe void SetModification(Vector3 value)
		{
			//IL_000e: Expected native int or pointer, but got O
			float z = value.z;
			((Vector3*)(IntPtr)modification)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraFeedbackRotation()
		{
		}
	}
}
