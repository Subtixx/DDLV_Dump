using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007CF")]
	public static class Trigo
	{
		[Cpp2IlInjected.Token(Token = "0x60022B0")]
		[Cpp2IlInjected.Address(RVA = "0x13DFF40", Offset = "0x13DE940", VA = "0x1813DFF40")]
		public static Vector2 PosOnCircle(Vector2 center, float xRadius, float yRadius, Angle angle)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022B1")]
		[Cpp2IlInjected.Address(RVA = "0x13DFE30", Offset = "0x13DE830", VA = "0x1813DFE30")]
		public static Angle MirrorVertical(Angle angle)
		{
			//IL_001b: Expected F4, but got I4
			//IL_0036: Invalid comparison between I4 and F4
			int num = 0;
			uint num2 = default(uint);
			if (num2 != 0 && num2 != 0 && num2 == 0)
			{
				Angle angle2 = Angle.FromRadians(1.092013E+09f);
				if (num > 1092013028)
				{
					goto IL_0038;
				}
			}
			Angle angle3 = Angle.FromRadians((float)Math.PI);
			if ((float)num > (float)Math.PI)
			{
			}
			goto IL_0038;
			IL_0038:
			return Angle.FromRadians((float)Math.PI);
		}

		[Cpp2IlInjected.Token(Token = "0x60022B2")]
		[Cpp2IlInjected.Address(RVA = "0x13DFCE0", Offset = "0x13DE6E0", VA = "0x1813DFCE0")]
		public static Quadrant AngleQuadrant(Angle angle)
		{
			//Discarded unreachable code: IL_000b
			//IL_0006: Expected F4, but got I4
			Angle angle2 = Angle.FromRadians(0f);
			int num = 0;
			return Quadrant.LowerLeft;
		}

		[Cpp2IlInjected.Token(Token = "0x60022B3")]
		[Cpp2IlInjected.Address(RVA = "0x13DFFC0", Offset = "0x13DE9C0", VA = "0x1813DFFC0")]
		public static Angle PositionToAngle(Vector2 pos)
		{
			int num = 0;
			Angle result = default(Angle);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60022B4")]
		[Cpp2IlInjected.Address(RVA = "0x13DFDF0", Offset = "0x13DE7F0", VA = "0x1813DFDF0")]
		public static Angle ClampAngle(Angle angle)
		{
			//IL_0013: Expected F4, but got I4
			int num = 0;
			Angle angle2 = Angle.FromRadians((float)Math.PI * 2f);
			return Angle.FromRadians(num);
		}

		[Cpp2IlInjected.Token(Token = "0x60022B5")]
		[Cpp2IlInjected.Address(RVA = "0x13DFDC0", Offset = "0x13DE7C0", VA = "0x1813DFDC0")]
		public static float ClampAngleRadians(float radians)
		{
			//IL_0002: Invalid comparison between I4 and F4
			if (!(0f > radians) && !(radians <= (float)Math.PI * 2f))
			{
				return radians;
			}
			return radians;
		}

		[Cpp2IlInjected.Token(Token = "0x60022B6")]
		[Cpp2IlInjected.Address(RVA = "0x13DFD90", Offset = "0x13DE790", VA = "0x1813DFD90")]
		public static float ClampAngleDegrees(float degrees)
		{
			//IL_0002: Invalid comparison between I4 and F4
			if (!(0f > degrees) && !(degrees <= 180f))
			{
				return degrees;
			}
			return degrees;
		}

		[Cpp2IlInjected.Token(Token = "0x60022B7")]
		[Cpp2IlInjected.Address(RVA = "0x13DFD60", Offset = "0x13DE760", VA = "0x1813DFD60")]
		public static float ClampAngleDegrees180(float degrees)
		{
			if (!(degrees <= 180f))
			{
				return degrees;
			}
			return degrees;
		}

		[Cpp2IlInjected.Token(Token = "0x60022B8")]
		[Cpp2IlInjected.Address(RVA = "0x13DFBF0", Offset = "0x13DE5F0", VA = "0x1813DFBF0")]
		public static Angle AngleBetween(Angle origin, Angle target)
		{
			//IL_0004: Invalid comparison between F4 and I4
			int num = 0;
			float num2 = default(float);
			if (!(num2 >= (float)num) && !(num2 > -180f))
			{
				return Angle.FromDegrees(num2);
			}
			Angle result = default(Angle);
			return result;
		}
	}
}
