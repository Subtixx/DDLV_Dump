using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007DF")]
	internal class CircleGenerator : EnvironmentQuery.Generator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C23")]
		public float Radius = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002C24")]
		public int Points = 10;

		[Cpp2IlInjected.Token(Token = "0x60022E6")]
		[Cpp2IlInjected.Address(RVA = "0xA80E10", Offset = "0xA7F810", VA = "0x180A80E10", Slot = "4")]
		protected override int Generate(EnvironmentQuery.QueryPositionList positionList, GameObject queryObject, Vector3 queryPosition)
		{
			//Discarded unreachable code: IL_002e
			Vector3[] array = new Vector3[Points];
			int points = Points;
			int num = 0;
			if (points > 0)
			{
				float z = queryPosition.z;
				int points2 = Points;
				num++;
			}
			return points;
		}

		[Cpp2IlInjected.Token(Token = "0x60022E7")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7F9D0", VA = "0x180A80FD0")]
		public CircleGenerator()
		{
		}//IL_0015: Expected I4, but got I8

	}
}
