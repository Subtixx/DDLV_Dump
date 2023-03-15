using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GK
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public class Geom : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8CA670", Offset = "0x8C9070", VA = "0x1808CA670")]
		public static bool AreCoincident(Vector2 a, Vector2 b)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8CB1D0", Offset = "0x8C9BD0", VA = "0x1808CB1D0")]
		public static bool ToTheLeft(Vector2 p, Vector2 l0, Vector2 l1)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8CB230", Offset = "0x8C9C30", VA = "0x1808CB230")]
		public static bool ToTheRight(Vector2 p, Vector2 l0, Vector2 l1)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEE0", Offset = "0x8C98E0", VA = "0x1808CAEE0")]
		public static bool PointInTriangle(Vector2 p, Vector2 c0, Vector2 c1, Vector2 c2)
		{
			int num = 0;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8CA930", Offset = "0x8C9330", VA = "0x1808CA930")]
		public static bool InsideCircumcircle(Vector2 p, Vector2 c0, Vector2 c1, Vector2 c2)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8CB1A0", Offset = "0x8C9BA0", VA = "0x1808CB1A0")]
		public static Vector2 RotateRightAngle(Vector2 v)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8CAC70", Offset = "0x8C9670", VA = "0x1808CAC70")]
		public static bool LineLineIntersection(Vector2 p0, Vector2 v0, Vector2 p1, Vector2 v1, out float m0, out float m1)
		{
			//Discarded unreachable code: IL_0002, IL_0004
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8CABD0", Offset = "0x8C95D0", VA = "0x1808CABD0")]
		public static Vector2 LineLineIntersection(Vector2 p0, Vector2 v0, Vector2 p1, Vector2 v1)
		{
			bool flag = default(bool);
			while (true)
			{
				if (!flag)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD90", Offset = "0x8C9790", VA = "0x1808CAD90")]
		public static bool LineSegmentIntersection(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, out Vector2 i)
		{
			int num = 0;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x8CAFE0", Offset = "0x8C99E0", VA = "0x1808CAFE0")]
		public static float PointLineIntersection(Vector2 pt, Vector2 p1, Vector2 p2, out Vector2 closest)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x8CAA50", Offset = "0x8C9450", VA = "0x1808CAA50")]
		public static bool IsPointInPolygon(Vector2 point, Vector2[] poly)
		{
			//Discarded unreachable code: IL_001b
			int num = 0;
			int length = poly.Length;
			int num2 = 0;
			if (num < length)
			{
				num++;
			}
			return num != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x8CA7D0", Offset = "0x8C91D0", VA = "0x1808CA7D0")]
		public static Vector2 CircumcircleCenter(Vector2 c0, Vector2 c1, Vector2 c2)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x8CB290", Offset = "0x8C9C90", VA = "0x1808CB290")]
		public static Vector2 TriangleCentroid(Vector2 c0, Vector2 c1, Vector2 c2)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8CA6C0", Offset = "0x8C90C0", VA = "0x1808CA6C0")]
		public static float Area(IList<Vector2> polygon)
		{
			//Discarded unreachable code: IL_0014
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected F4, but got Unknown
			int num = 0;
			int num2 = 0;
			if ((long)(IntPtr)typeof(IList<Vector2>).TypeHandle > 0L)
			{
			}
			return num * 0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Geom()
		{
		}
	}
}
