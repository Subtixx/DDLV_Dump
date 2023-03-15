using System;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000797")]
	public class ViewMargins
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002B61")]
		public float left = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4002B62")]
		public float right = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B63")]
		public float bottom = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002B64")]
		public float top = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x60021A8")]
		[Cpp2IlInjected.Address(RVA = "0xD46760", Offset = "0xD45160", VA = "0x180D46760")]
		public ViewMargins()
		{
		}
	}
}
