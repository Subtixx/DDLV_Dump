using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GK
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public class VoronoiCalculator
	{
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		private struct PointTriangle
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public readonly int Point;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public readonly int Triangle;

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xF87D00", Offset = "0xF86700", VA = "0x180F87D00")]
			public PointTriangle(int point, int triangle)
			{
				Point = point;
				Triangle = triangle;
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0xF87C70", Offset = "0xF86670", VA = "0x180F87C70", Slot = "3")]
			public override string ToString()
			{
				int triangle = Triangle;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		private class PTComparer : IComparer<PointTriangle>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public List<Vector2> verts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public List<int> tris;

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xF87A90", Offset = "0xF86490", VA = "0x180F87A90", Slot = "4")]
			public int Compare(PointTriangle pt0, PointTriangle pt1)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xF87920", Offset = "0xF86320", VA = "0x180F87920")]
			private int CompareAngles(PointTriangle pt0, PointTriangle pt1)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xF877B0", Offset = "0xF861B0", VA = "0x180F877B0")]
			private Vector2 Centroid(PointTriangle pt)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PTComparer()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private DelaunayCalculator delCalc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private PTComparer cmp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private List<PointTriangle> pts;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xD4BD60", Offset = "0xD4A760", VA = "0x180D4BD60")]
		public VoronoiCalculator()
		{
			List<PointTriangle> list = (pts = (List<PointTriangle>)(object)new List<T>());
			DelaunayCalculator delaunayCalculator = (delCalc = new DelaunayCalculator());
			PTComparer pTComparer = (cmp = new PTComparer());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xD4AAB0", Offset = "0xD494B0", VA = "0x180D4AAB0")]
		public VoronoiDiagram CalculateDiagram(IList<Vector2> inputVertices)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xD4AAE0", Offset = "0xD494E0", VA = "0x180D4AAE0")]
		public void CalculateDiagram(IList<Vector2> inputVertices, ref VoronoiDiagram result)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xD4BAC0", Offset = "0xD4A4C0", VA = "0x180D4BAC0")]
		private static int NonSharedPoint(List<int> tris, int ti0, int ti1)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC10", Offset = "0xD4A610", VA = "0x180D4BC10")]
		private static bool SharesEdge(List<int> tris, int ti0, int ti1)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
