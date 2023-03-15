using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007E0")]
	internal class DonutGenerator : EnvironmentQuery.Generator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C25")]
		public float InnerRadius = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002C26")]
		public float OuterRadius = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002C27")]
		public int Points = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002C28")]
		public int Rings = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002C29")]
		public bool Twist = true;

		[Cpp2IlInjected.Token(Token = "0x60022E8")]
		[Cpp2IlInjected.Address(RVA = "0x19CFE40", Offset = "0x19CE840", VA = "0x1819CFE40", Slot = "4")]
		protected override int Generate(EnvironmentQuery.QueryPositionList positionList, GameObject queryObject, Vector3 queryPosition)
		{
			//Discarded unreachable code: IL_0057
			Vector3[] array = new Vector3[Points];
			int rings = Rings;
			int num = 0;
			if (rings > 0)
			{
				int points = Points;
				int num2 = 0;
				int num3 = 0;
				if (points > 0)
				{
					float z = queryPosition.z;
					if (Twist)
					{
					}
					int points2 = Points;
					num2++;
				}
				int rings2 = Rings;
				num++;
			}
			return rings;
		}

		[Cpp2IlInjected.Token(Token = "0x60022E9")]
		[Cpp2IlInjected.Address(RVA = "0x19D00A0", Offset = "0x19CEAA0", VA = "0x1819D00A0")]
		public DonutGenerator()
		{
		}//IL_0020: Expected I4, but got I8
		//IL_0029: Expected I4, but got I8

	}
}
