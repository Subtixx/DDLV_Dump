using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x200084A")]
	public class CharacterState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002E44")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002E45")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002E46")]
		public bool isTalkingToRequestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4002E47")]
		public bool isMovingToTargetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002E48")]
		public Vector3 targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002E49")]
		public float moveToKeepDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002E4A")]
		public bool runToMoveToTarget;

		[Cpp2IlInjected.Token(Token = "0x60025B4")]
		[Cpp2IlInjected.Address(RVA = "0x12E8EB0", Offset = "0x12E78B0", VA = "0x1812E8EB0")]
		public unsafe CharacterState(Transform transform)
		{
			//Discarded unreachable code: IL_001a
			//IL_0014: Expected native int or pointer, but got O
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)position)->z = z;
		}
	}
}
