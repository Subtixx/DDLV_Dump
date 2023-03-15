using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GK
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public class VoronoiClipper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private List<Vector2> pointsIn = (List<Vector2>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private List<Vector2> pointsOut = (List<Vector2>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xD4C4C0", Offset = "0xD4AEC0", VA = "0x180D4C4C0")]
		public VoronoiClipper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xD4BE40", Offset = "0xD4A840", VA = "0x180D4BE40")]
		public void ClipSite(VoronoiDiagram diag, IList<Vector2> polygon, int site, ref List<Vector2> clipped)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
