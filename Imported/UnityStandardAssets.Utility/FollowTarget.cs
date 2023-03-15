using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class FollowTarget : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Vector3 offset;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2F116B0", Offset = "0x2F100B0", VA = "0x182F116B0")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_0023
			Transform transform = base.transform;
			Transform transform2 = target;
			float z = offset.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2F11790", Offset = "0x2F10190", VA = "0x182F11790")]
		public unsafe FollowTarget()
		{
			//IL_000c: Expected F4, but got I8
			//IL_0007: Expected native int or pointer, but got O
			ulong num = default(ulong);
			((Vector3*)(IntPtr)offset)->z = (long)num;
			base._002Ector();
		}
	}
}
