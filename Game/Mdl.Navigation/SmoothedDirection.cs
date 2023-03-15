using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C93")]
	internal class SmoothedDirection
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004656")]
		private Vector3[] previousVelocities = new Vector3[5];

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004657")]
		private int previousVelocityNextIndex;

		[Cpp2IlInjected.Token(Token = "0x6003A1B")]
		[Cpp2IlInjected.Address(RVA = "0xF55AB0", Offset = "0xF544B0", VA = "0x180F55AB0")]
		public void AddDirection(Vector3 v)
		{
			//Discarded unreachable code: IL_0045
			//IL_001d: Expected O, but got F4
			//IL_0044: Expected I4, but got I8
			Vector3[] array = previousVelocities;
			int num = previousVelocityNextIndex;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			array[1] = (Vector3)z;
			int num2 = previousVelocityNextIndex;
			Vector3[] array2 = previousVelocities;
			num2 = (previousVelocityNextIndex = num2 + 1);
			previousVelocityNextIndex = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1C")]
		[Cpp2IlInjected.Address(RVA = "0xF55C70", Offset = "0xF54670", VA = "0x180F55C70")]
		public void Reset(Vector3 v)
		{
			//Discarded unreachable code: IL_0025
			Vector3[] array = previousVelocities;
			int num = 0;
			if (num < array.Length)
			{
				num++;
				float z = v.z;
				Vector3[] array2 = previousVelocities;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1D")]
		[Cpp2IlInjected.Address(RVA = "0xF55B40", Offset = "0xF54540", VA = "0x180F55B40")]
		public Vector3 GetFacing()
		{
			int num = 0;
			int num2 = 0;
			Vector3 zero = Vector3.zero;
			int num3 = 0;
			float z = zero.z;
			if (num3 < num2)
			{
				num3++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1E")]
		[Cpp2IlInjected.Address(RVA = "0xF55CF0", Offset = "0xF546F0", VA = "0x180F55CF0")]
		public SmoothedDirection()
		{
		}
	}
}
