using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GK
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class VoronoiDiagram
	{
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		public enum EdgeType
		{
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			Line,
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			RayCCW,
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			RayCW,
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			Segment
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public struct Edge
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public readonly EdgeType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public readonly int Site;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public readonly int Vert0;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public readonly int Vert1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public Vector2 Direction;

			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xF872F0", Offset = "0xF85CF0", VA = "0x180F872F0")]
			public Edge(EdgeType type, int site, int vert0, int vert1, Vector2 direction)
			{
				Type = type;
				Site = site;
				Vert0 = vert0;
				Vert1 = 0;
			}

			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xF86FE0", Offset = "0xF859E0", VA = "0x180F86FE0", Slot = "3")]
			public override string ToString()
			{
				//Discarded unreachable code: IL_0075
				//IL_0035: Expected O, but got I4
				//IL_004c: Expected O, but got I4
				//IL_0069: Expected O, but got I4
				//IL_009d: Expected O, but got I4
				//IL_009d: Expected O, but got I4
				//IL_009d: Expected O, but got I4
				object[] array;
				int vert;
				while (true)
				{
					array = new object[4];
					int site = Site;
					if (array != null && array == null)
					{
						continue;
					}
					array[0] = array;
					vert = Vert0;
					if (vert != 0 && vert == 0)
					{
						continue;
					}
					array[1] = vert;
					Vector2 direction = Direction;
					if (vert == 0 || vert != 0)
					{
						array[2] = vert;
						float y = Direction.y;
						if (vert == 0 || vert != 0)
						{
							break;
						}
					}
				}
				array[3] = vert;
				return string.Format("VoronoiEdge(Ray, {0}, {1}, ({2}, {3}))", array);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public readonly DelaunayTriangulation Triangulation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public readonly List<Vector2> Sites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public readonly List<Vector2> Vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public readonly List<Edge> Edges;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public readonly List<int> FirstEdgeBySite;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xD4C620", Offset = "0xD4B020", VA = "0x180D4C620")]
		internal VoronoiDiagram()
		{
			DelaunayTriangulation delaunayTriangulation = (Triangulation = new DelaunayTriangulation());
			List<Vector2> list = (Sites = Triangulation.Vertices);
			List<Vector2> list2 = (Vertices = (List<Vector2>)(object)new List<T>());
			List<Edge> list3 = (Edges = (List<Edge>)(object)new List<T>());
			List<int> list4 = (FirstEdgeBySite = (List<int>)(object)new List<T>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xD4C570", Offset = "0xD4AF70", VA = "0x180D4C570")]
		internal void Clear()
		{
			//Discarded unreachable code: IL_0038
			Triangulation.Clear();
			((List<T>)(object)Sites).Clear();
			((List<T>)(object)Vertices).Clear();
			((List<T>)(object)Edges).Clear();
			((List<T>)(object)FirstEdgeBySite).Clear();
		}
	}
}
