using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x200052F")]
	public class FollowObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002048")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60016BB")]
		[Cpp2IlInjected.Address(RVA = "0x14615C0", Offset = "0x145FFC0", VA = "0x1814615C0")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_0016
			Transform transform = base.transform;
			Transform transform2 = target;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60016BC")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FollowObject()
		{
		}
	}
}
