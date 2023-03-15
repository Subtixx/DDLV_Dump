using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Sky
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20004D0")]
	public struct GPUQuadInfos
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4001E2C")]
		public Vector2 offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4001E2D")]
		public Vector4 colorUpRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E2E")]
		public float isStar;

		[Cpp2IlInjected.Token(Token = "0x170002A3")]
		public static int stride
		{
			[Cpp2IlInjected.Token(Token = "0x600152E")]
			[Cpp2IlInjected.Address(RVA = "0x8BC8A0", Offset = "0x8BB2A0", VA = "0x1808BC8A0")]
			get
			{
				return 28;
			}
		}
	}
}
