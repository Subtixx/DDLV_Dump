using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001FC")]
	public class PromptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001127")]
		public string title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001128")]
		public string subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001129")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400112A")]
		public bool allowClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400112B")]
		public Action onCloseButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400112C")]
		public List<PromptButtonData> buttons = (List<PromptButtonData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400112D")]
		public float duration = -1f;

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xCB96F0", Offset = "0xCB80F0", VA = "0x180CB96F0")]
		public PromptData()
		{
		}
	}
}
