using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200073B")]
	public class CubicBezier
	{
		[Cpp2IlInjected.Token(Token = "0x40029FA")]
		private const float Epsilon = 1E-05f;

		[Cpp2IlInjected.Token(Token = "0x1700048F")]
		public Vector2 P0
		{
			[Cpp2IlInjected.Token(Token = "0x6002019")]
			[Cpp2IlInjected.Address(RVA = "0x1106750", Offset = "0x1105150", VA = "0x181106750")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600201A")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AB0", Offset = "0x6E44B0", VA = "0x1806E5AB0")]
			[CompilerGenerated]
			set
			{
				_003CP0_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000490")]
		public Vector2 P1
		{
			[Cpp2IlInjected.Token(Token = "0x600201B")]
			[Cpp2IlInjected.Address(RVA = "0x1106770", Offset = "0x1105170", VA = "0x181106770")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600201C")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			[CompilerGenerated]
			set
			{
				_003CP1_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000491")]
		public Vector2 P2
		{
			[Cpp2IlInjected.Token(Token = "0x600201D")]
			[Cpp2IlInjected.Address(RVA = "0x1106790", Offset = "0x1105190", VA = "0x181106790")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600201E")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			[CompilerGenerated]
			set
			{
				_003CP2_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000492")]
		public Vector2 P3
		{
			[Cpp2IlInjected.Token(Token = "0x600201F")]
			[Cpp2IlInjected.Address(RVA = "0x11067B0", Offset = "0x11051B0", VA = "0x1811067B0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6002020")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			[CompilerGenerated]
			set
			{
				_003CP3_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600200E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CubicBezier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600200F")]
		[Cpp2IlInjected.Address(RVA = "0x11066E0", Offset = "0x11050E0", VA = "0x1811066E0")]
		public CubicBezier(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002010")]
		[Cpp2IlInjected.Address(RVA = "0x1105DF0", Offset = "0x11047F0", VA = "0x181105DF0")]
		public Vector2 GetValue(float t)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002011")]
		[Cpp2IlInjected.Address(RVA = "0x1105D00", Offset = "0x1104700", VA = "0x181105D00")]
		public Vector2 GetTangentValue(float t)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002012")]
		[Cpp2IlInjected.Address(RVA = "0x1105F00", Offset = "0x1104900", VA = "0x181105F00")]
		public float GetY(float x)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected F4, but got Unknown
			//IL_0020: Expected O, but got F4
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected F4, but got Unknown
			Vector2 vector = P0;
			Vector2 vector2 = P1;
			float num = (float)(vector * -3f);
			float num2 = default(float);
			num = num2;
			float y = ((CubicBezier)num2).P1.y;
			float result = /*Error near IL_0026: Stack underflow*/* y;
			float num3 = num;
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002013")]
		[Cpp2IlInjected.Address(RVA = "0x1106020", Offset = "0x1104A20", VA = "0x181106020")]
		private static float SolveCubic(float a, float b, float c, float d)
		{
			//IL_000b: Expected F4, but got I4
			//IL_0017: Expected F4, but got I4
			//IL_0024: Invalid comparison between F4 and I4
			//IL_0031: Expected F4, but got I4
			//IL_0037: Invalid comparison between I4 and F4
			//IL_005b: Expected F4, but got I4
			//IL_0063: Expected F4, but got I4
			//IL_006b: Invalid comparison between I4 and F4
			int num2;
			while (true)
			{
				int num = 0;
				num2 = 0;
				if (!FPEqual(a, num))
				{
					int num3 = 0;
					if (!FPEqual(a, num3))
					{
						break;
					}
				}
			}
			float num4 = d * -27f;
			float num6 = default(float);
			if (!(num4 > (float)num2))
			{
				int num5 = 0;
				if (!FPEqual(a, num5))
				{
				}
				if (!((float)num2 <= num6))
				{
					float num7 = CubicRoot(a);
				}
				float num8 = CubicRoot(a);
				num8 = c;
			}
			int num9 = 0;
			if (num2 > num9)
			{
				num4 = CubicRoot(num9);
			}
			float num10 = CubicRoot(num9);
			num4 = num10;
			float num11;
			if (!((float)num2 <= num6))
			{
				num10 = num6;
				num11 = CubicRoot(num10);
			}
			num11 = num6;
			float num12 = CubicRoot(num11);
			float num13 = default(float);
			num12 = num13;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002014")]
		[Cpp2IlInjected.Address(RVA = "0x1106580", Offset = "0x1104F80", VA = "0x181106580")]
		private static float SolveQuadratic(float a, float b, float c)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002015")]
		[Cpp2IlInjected.Address(RVA = "0x11066D0", Offset = "0x11050D0", VA = "0x1811066D0")]
		private static float Squared(float f)
		{
			return f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002016")]
		[Cpp2IlInjected.Address(RVA = "0x1105BD0", Offset = "0x11045D0", VA = "0x181105BD0")]
		private static float Cubed(float f)
		{
			return f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002017")]
		[Cpp2IlInjected.Address(RVA = "0x1105BE0", Offset = "0x11045E0", VA = "0x181105BE0")]
		private static float CubicRoot(float f)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002018")]
		[Cpp2IlInjected.Address(RVA = "0x1105C50", Offset = "0x1104650", VA = "0x181105C50")]
		private static bool FPEqual(float a, float b)
		{
			//IL_0020: Expected I4, but got O
			float num = Mathf.Max(a, b);
			float num2 = Mathf.Max(1f, b) * 1E-05f;
			return (byte)(int)typeof(Math).TypeHandle != 0;
		}
	}
}
