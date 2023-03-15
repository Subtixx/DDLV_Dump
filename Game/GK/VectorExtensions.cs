using Cpp2IlInjected;
using UnityEngine;

namespace GK
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public static class VectorExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xD45D50", Offset = "0xD44750", VA = "0x180D45D50")]
		public static bool IsReal(this float f)
		{
			if (float.IsInfinity(f))
			{
				int num = 0;
			}
			return !float.IsNaN(f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xD45C50", Offset = "0xD44650", VA = "0x180D45C50")]
		public static bool IsReal(this Vector2 v2)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			if (!flag && !flag2 && !flag3)
			{
				return !flag4;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xD45CB0", Offset = "0xD446B0", VA = "0x180D45CB0")]
		public static bool IsReal(this Vector3 v3)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag && !flag2)
			{
				float z = v3.z;
				bool flag3 = default(bool);
				bool flag4 = default(bool);
				if (!flag3 && !flag4)
				{
					float z2 = v3.z;
					if (!float.IsInfinity(z2))
					{
						return !float.IsNaN(z2);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
