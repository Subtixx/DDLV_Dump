using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GK
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public class DelaunayCalculator
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		private struct TriangleNode
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public int P0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public int P1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public int P2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public int C0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public int C1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int C2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int A0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public int A1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public int A2;

			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public bool IsLeaf
			{
				[Cpp2IlInjected.Token(Token = "0x600046A")]
				[Cpp2IlInjected.Address(RVA = "0x1197A40", Offset = "0x1196440", VA = "0x181197A40")]
				get
				{
					if (C0 < 0 && C1 < 0)
					{
						int c = C2;
					}
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public bool IsInner
			{
				[Cpp2IlInjected.Token(Token = "0x600046B")]
				[Cpp2IlInjected.Address(RVA = "0x1197A20", Offset = "0x1196420", VA = "0x181197A20")]
				get
				{
					int p = P2;
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x11979F0", Offset = "0x11963F0", VA = "0x1811979F0")]
			public TriangleNode(int P0, int P1, int P2)
			{
				//IL_001e: Expected I4, but got I8
				//IL_0027: Expected I4, but got I8
				//IL_0030: Expected I4, but got I8
				this.P0 = P0;
				this.P1 = P1;
				this.P2 = P2;
				C0 = -1;
				C2 = -1;
				A1 = -1;
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x11973D0", Offset = "0x1195DD0", VA = "0x1811973D0")]
			public bool HasEdge(int e0, int e1)
			{
				//Discarded unreachable code: IL_001d, IL_0026, IL_0028
				int p = P1;
				if (e0 != p)
				{
					if (e0 != P2)
					{
						int num = 0;
					}
					return e1 == p;
				}
				return true;
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x1197490", Offset = "0x1195E90", VA = "0x181197490")]
			public int OtherPoint(int p0, int p1)
			{
				int p2 = P1;
				if (p0 == p2)
				{
					goto IL_0018;
				}
				if (p0 == P2)
				{
					if (p1 == p2)
					{
						goto IL_0018;
					}
				}
				else
				{
					ArgumentException ex = new ArgumentException("p0 and p1 not on triangle");
				}
				ArgumentException ex2 = new ArgumentException("p0 and p1 not on triangle");
				goto IL_004b;
				IL_0018:
				if (p1 != P2)
				{
					goto IL_004b;
				}
				if (p1 == p2 || p1 == P2)
				{
					return P2;
				}
				goto IL_0056;
				IL_004b:
				ArgumentException ex3 = new ArgumentException("p0 and p1 not on triangle");
				goto IL_0056;
				IL_0056:
				ArgumentException ex4 = new ArgumentException("p0 and p1 not on triangle");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x1197410", Offset = "0x1195E10", VA = "0x181197410")]
			public int Opposite(int p)
			{
				//Discarded unreachable code: IL_0020
				if (p != P1)
				{
					if (p == P2)
					{
						return A2;
					}
					ArgumentException ex = new ArgumentException("p not in triangle");
					/*Error: Unexpected end of block*/;
				}
				return A1;
			}

			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x1197610", Offset = "0x1196010", VA = "0x181197610", Slot = "3")]
			public override string ToString()
			{
				//Discarded unreachable code: IL_00f9
				//IL_0063: Expected O, but got I4
				//IL_0083: Expected O, but got I4
				//IL_00a6: Expected O, but got I4
				//IL_00c9: Expected O, but got I4
				//IL_00ec: Expected O, but got I4
				string result = default(string);
				object[] array;
				int p3;
				while (true)
				{
					if (C0 < 0 && C1 < 0 && C2 != 0)
					{
						int p = P1;
						int p2 = P2;
						return result;
					}
					array = new object[6];
					if (array != null && array == null)
					{
						continue;
					}
					array[0] = array;
					p3 = P1;
					if (p3 != 0 && p3 == 0)
					{
						continue;
					}
					array[1] = p3;
					int p4 = P2;
					p3 = p4;
					if (p4 != 0 && p4 == 0)
					{
						continue;
					}
					array[2] = p3;
					int c = C0;
					p3 = c;
					if (c != 0 && c == 0)
					{
						continue;
					}
					array[3] = p3;
					int c2 = C1;
					p3 = c2;
					if (c2 == 0 || c2 != 0)
					{
						array[4] = p3;
						int c3 = C2;
						p3 = c3;
						if (c3 == 0 || c3 != 0)
						{
							break;
						}
					}
				}
				array[5] = p3;
				return string.Format("TriangleNode({0}, {1}, {2}, {3}, {4}, {5})", array);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private int highest = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private IList<Vector2> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private List<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private List<TriangleNode> triangles;

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1623C50", Offset = "0x1622650", VA = "0x181623C50")]
		public DelaunayCalculator()
		{
			//IL_0010: Expected I4, but got I8
			List<TriangleNode> list = (triangles = (List<TriangleNode>)(object)new List<T>());
			List<int> list2 = (indices = (List<int>)(object)new List<T>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1621FA0", Offset = "0x16209A0", VA = "0x181621FA0")]
		public DelaunayTriangulation CalculateTriangulation(IList<Vector2> verts)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1621FD0", Offset = "0x16209D0", VA = "0x181621FD0")]
		public void CalculateTriangulation(IList<Vector2> verts, ref DelaunayTriangulation result)
		{
			//IL_0070: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			int num;
			int num3 = default(int);
			if (verts != null)
			{
				((List<T>)(object)triangles).Clear();
				this.verts = verts;
				num = (highest = 0);
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0057;
					}
					num++;
				}
				num3 = highest;
				if ((long)num < (long)(IntPtr)typeof(ICollection<Vector2>).TypeHandle)
				{
					if (Higher(num3, num))
					{
						highest = num;
					}
					num++;
					goto IL_0057;
				}
				goto IL_005b;
			}
			ArgumentNullException ex = new ArgumentNullException("points");
			/*Error: Unexpected end of block*/;
			IL_005b:
			List<TriangleNode> list = triangles;
			int num4 = 0;
			int num5 = 0;
			((List<T>)(object)list).Add((T)num5);
			RunBowyerWatson();
			GenerateResult(ref result);
			this.verts = (IList<Vector2>)num;
			return;
			IL_0057:
			num3 += num3;
			goto IL_005b;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1622870", Offset = "0x1621270", VA = "0x181622870")]
		private bool Higher(int pi0, int pi1)
		{
			//IL_0026: Expected I4, but got O
			if (pi0 != -2)
			{
				if (pi0 == -1 || pi1 == -2)
				{
					return true;
				}
				if (pi1 != -1)
				{
					IList<Vector2> list = verts;
					IList<Vector2> list2 = verts;
					return (byte)(int)typeof(IList<Vector2>).TypeHandle != 0;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x1623390", Offset = "0x1621D90", VA = "0x181623390")]
		private void RunBowyerWatson()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x1622420", Offset = "0x1620E20", VA = "0x181622420")]
		private void GenerateResult(ref DelaunayTriangulation result)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1623780", Offset = "0x1622180", VA = "0x181623780")]
		private void ShuffleIndices()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1622970", Offset = "0x1621370", VA = "0x181622970")]
		private int LeafWithEdge(int ti, int e0, int e1)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1622C30", Offset = "0x1621630", VA = "0x181622C30")]
		private bool LegalEdge(int k, int l, int i, int j)
		{
			//Discarded unreachable code: IL_0029
			IList<Vector2> list = verts;
			IList<Vector2> list2 = verts;
			IList<Vector2> list3 = verts;
			IList<Vector2> list4 = verts;
			int num = 0;
			bool flag = default(bool);
			return !flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1622E70", Offset = "0x1621870", VA = "0x181622E70")]
		private void LegalizeEdge(int ti0, int ti1, int pi, int li0, int li1)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1622290", Offset = "0x1620C90", VA = "0x181622290")]
		private int FindTriangleNode(int pi)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x16232A0", Offset = "0x1621CA0", VA = "0x1816232A0")]
		private bool PointInTriangle(int pi, int ti)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1623B00", Offset = "0x1622500", VA = "0x181623B00")]
		private bool ToTheLeft(int pi, int li0, int li1)
		{
			if (li0 != -2)
			{
				if (li0 != -1)
				{
					switch (li1)
					{
					default:
					{
						IList<Vector2> list = verts;
						IList<Vector2> list2 = verts;
						IList<Vector2> list3 = verts;
						int num = 0;
						bool result = default(bool);
						return result;
					}
					case -1:
					{
						bool flag = Higher(pi, li0);
						break;
					}
					case -2:
						break;
					}
					bool flag2 = Higher(pi, li0);
				}
				bool flag3 = Higher(pi, li0);
			}
			bool flag4 = Higher(pi, li0);
			throw new NullReferenceException();
		}
	}
}
