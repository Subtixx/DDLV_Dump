using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200049D")]
	public struct TerrainRect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4001D0E")]
		public Rect rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001D0F")]
		public int firstTerrainIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4001D10")]
		public int secondTerrainIndex;
	}
}
