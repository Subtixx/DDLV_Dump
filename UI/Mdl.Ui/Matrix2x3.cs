using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008BE")]
	public struct Matrix2x3
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003457")]
		public float m00;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4003458")]
		public float m01;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4003459")]
		public float m02;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400345A")]
		public float m10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400345B")]
		public float m11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400345C")]
		public float m12;

		[Cpp2IlInjected.Token(Token = "0x6003725")]
		[Cpp2IlInjected.Address(RVA = "0x118BE10", Offset = "0x118A810", VA = "0x18118BE10")]
		public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12)
		{
			//IL_0007: Expected F4, but got I4
			//IL_0015: Expected F4, but got I4
			//IL_002a: Expected F4, but got I4
			this.m10 = 0f;
			this.m00 = m00;
			this.m12 = 0f;
			this.m01 = m01;
			this.m02 = m02;
			this.m11 = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6003726")]
		[Cpp2IlInjected.Address(RVA = "0x118BE40", Offset = "0x118A840", VA = "0x18118BE40")]
		public static Vector2 operator *(Matrix2x3 m, Vector2 v)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
