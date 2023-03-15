using System;
using Cpp2IlInjected;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001FB")]
	public struct PromptButtonData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4001124")]
		public string label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4001125")]
		public PromptButtonStyle style;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001126")]
		public Action onClick;
	}
}
