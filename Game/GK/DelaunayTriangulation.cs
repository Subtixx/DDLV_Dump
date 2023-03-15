using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GK
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public class DelaunayTriangulation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public readonly List<Vector2> Vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public readonly List<int> Triangles;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1624000", Offset = "0x1622A00", VA = "0x181624000")]
		internal DelaunayTriangulation()
		{
			List<Vector2> list = (Vertices = (List<Vector2>)(object)new List<T>());
			List<int> list2 = (Triangles = (List<int>)(object)new List<T>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1623D20", Offset = "0x1622720", VA = "0x181623D20")]
		internal void Clear()
		{
			//Discarded unreachable code: IL_0017
			((List<T>)(object)Vertices).Clear();
			((List<T>)(object)Triangles).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1623D90", Offset = "0x1622790", VA = "0x181623D90")]
		public bool Verify()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
