using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B10")]
	public class PathSegmentPos
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003D87")]
		public int NodeAIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003D88")]
		public int NodeBIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D89")]
		public Vector3 intersectionPoint;

		[Cpp2IlInjected.Token(Token = "0x6003301")]
		[Cpp2IlInjected.Address(RVA = "0xF0CE00", Offset = "0xF0B800", VA = "0x180F0CE00")]
		public unsafe void Set(PathSegmentPos other)
		{
			//Discarded unreachable code: IL_0035
			//IL_002f: Expected native int or pointer, but got O
			int num = (NodeAIndex = other.NodeAIndex);
			int num2 = (NodeBIndex = other.NodeBIndex);
			float z = other.intersectionPoint.z;
			((Vector3*)(IntPtr)intersectionPoint)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003302")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PathSegmentPos()
		{
		}
	}
}
