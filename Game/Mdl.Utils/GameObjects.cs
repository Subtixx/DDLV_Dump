using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000750")]
	public static class GameObjects
	{
		[Cpp2IlInjected.Token(Token = "0x600208A")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6B90", Offset = "0x1BB5590", VA = "0x181BB6B90")]
		public static (T, float) GetClosestItemFrom<T>(List<T> items, Vector3 position) where T : Component
		{
			int num = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			num++;
			int num2 = 0;
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600208B")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6B00", Offset = "0x1BB5500", VA = "0x181BB6B00")]
		public static (T, float) GetClosestItemFrom<T>(List<T> items, GameObject obj) where T : Component
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}
	}
}
