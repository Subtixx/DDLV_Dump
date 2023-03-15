using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityEngine
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public static class MathExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private const float kindaSmallNumber = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private const float kindaSmallNumberSquared = 9.999999E-09f;

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xBBF160", Offset = "0xBBDB60", VA = "0x180BBF160")]
		public static float DistanceSq(in Vector2 a, in Vector2 b)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xBBF0E0", Offset = "0xBBDAE0", VA = "0x180BBF0E0")]
		public static float DistanceSq(in Vector3 a, in Vector3 b)
		{
			float z = a.z;
			float z2 = b.z;
			float z3 = a.z;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xBBF320", Offset = "0xBBDD20", VA = "0x180BBF320")]
		public static bool InRadius(this in Vector2 a, in Vector2 b, in float radius)
		{
			int num = 0;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xBBF270", Offset = "0xBBDC70", VA = "0x180BBF270")]
		public static bool InRadius(this in Vector3 a, in Vector3 b, in float radius)
		{
			int num = 0;
			int num2 = 0;
			float z = a.z;
			float z2 = b.z;
			float z3 = a.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xBBF210", Offset = "0xBBDC10", VA = "0x180BBF210")]
		public static bool InHorizontalRadius(this in Vector3 a, in Vector3 b, in float radius)
		{
			int num = 0;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xBBF1E0", Offset = "0xBBDBE0", VA = "0x180BBF1E0")]
		public static float HorizontalDistance(in Vector3 a, in Vector3 b)
		{
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xBBF1B0", Offset = "0xBBDBB0", VA = "0x180BBF1B0")]
		public static float HorizontalDistanceSq(in Vector3 a, in Vector3 b)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xBBFD50", Offset = "0xBBE750", VA = "0x180BBFD50")]
		public unsafe static Rect Union(this in Rect rect, in Rect other)
		{
			//Discarded unreachable code: IL_000e
			//IL_000e: Expected O, but got Ref
			int length = new Rect[2].Length;
			return (Rect)System.Runtime.CompilerServices.Unsafe.AsPointer(ref rect);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xBBF970", Offset = "0xBBE370", VA = "0x180BBF970")]
		public unsafe static Rect Union(params Rect[] rectangles)
		{
			//IL_007f: Expected F4, but got I4
			//IL_007a: Expected native int or pointer, but got O
			if (_003C_003Ec._003C_003E9__8_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Rect x) => ((Rect*)x)->x);
			}
			if (_003C_003Ec._003C_003E9__8_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Rect x) => ((Rect*)x)->xMax);
			}
			if (_003C_003Ec._003C_003E9__8_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Rect x) => ((Rect*)x)->y);
			}
			if (_003C_003Ec._003C_003E9__8_3 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Rect x) => ((Rect*)x)->yMax);
			}
			int num = 0;
			((Rect*)(IntPtr)rectangles)->m_XMin = num;
			return (Rect)rectangles;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xBBF3A0", Offset = "0xBBDDA0", VA = "0x180BBF3A0")]
		public static bool IntersectsWithLine(this Rect rect, Vector2 start, Vector2 end, out Vector2 position1, out Vector2 position2)
		{
			//IL_0005: Invalid comparison between I4 and F4
			//IL_001d: Expected F4, but got O
			//IL_0024: Expected F4, but got I4
			//IL_0075: Expected F4, but got O
			int num = 0;
			float num2 = default(float);
			if (!(0f > num2))
			{
				num++;
				int num3 = 0;
				Vector2 positiveInfinity = Vector2.positiveInfinity;
				position1.x = (float)positiveInfinity;
				position1.y = 0f;
				int num4 = 0;
				Vector2 positiveInfinity2 = Vector2.positiveInfinity;
				int num5 = 0;
				Vector2 positiveInfinity3 = Vector2.positiveInfinity;
				int num6 = 0;
				Vector2 positiveInfinity4 = Vector2.positiveInfinity;
				int num7 = 0;
				Vector2 positiveInfinity5 = Vector2.positiveInfinity;
				int num8 = 0;
				Vector2 positiveInfinity6 = Vector2.positiveInfinity;
				int num9 = 0;
				Vector2 positiveInfinity7 = Vector2.positiveInfinity;
			}
			int num10 = 0;
			Vector2 zero = Vector2.zero;
			int num11 = 0;
			position1.x = (float)zero;
			Vector2 zero2 = Vector2.zero;
			int num12 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xBBF7C0", Offset = "0xBBE1C0", VA = "0x180BBF7C0")]
		private unsafe static bool IntersectsWithLine(this Rect rect, Vector2 start, Vector2 end, out float tmin, out float tmax)
		{
			//IL_0016: Invalid comparison between I4 and F4
			int num = 0;
			int num2 = 0;
			Vector2 min = ((Rect*)rect)->min;
			Vector2 max = ((Rect*)rect)->max;
			float num3 = default(float);
			if (!((float)num2 > num3))
			{
				num++;
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xBBFFA0", Offset = "0xBBE9A0", VA = "0x180BBFFA0")]
		public unsafe static bool isNearZero(this Vector3 v)
		{
			float sqrMagnitude = ((Vector3*)v)->sqrMagnitude;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xBBFFC0", Offset = "0xBBE9C0", VA = "0x180BBFFC0")]
		public static bool isNearZero(this Vector2 v)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xBBFEC0", Offset = "0xBBE8C0", VA = "0x180BBFEC0")]
		public static bool areNearlyEqual(Vector3 a, Vector3 b)
		{
			float z = a.z;
			float z2 = b.z;
			float z3 = a.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xBBFF50", Offset = "0xBBE950", VA = "0x180BBFF50")]
		public static bool areNearlyEqual(Quaternion a, Quaternion b)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xBBFE30", Offset = "0xBBE830", VA = "0x180BBFE30")]
		public static Vector2 WithX(this Vector2 v, float x)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xBBFE80", Offset = "0xBBE880", VA = "0x180BBFE80")]
		public static Vector2 WithY(this Vector2 v, float y)
		{
			return v;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xBBFE10", Offset = "0xBBE810", VA = "0x180BBFE10")]
		public static Vector3 WithX(this Vector3 v, float x)
		{
			return v;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xBBFE50", Offset = "0xBBE850", VA = "0x180BBFE50")]
		public static Vector3 WithY(this Vector3 v, float y)
		{
			return v;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xBBFEA0", Offset = "0xBBE8A0", VA = "0x180BBFEA0")]
		public static Vector3 WithZ(this Vector3 v, float z)
		{
			return v;
		}
	}
}
