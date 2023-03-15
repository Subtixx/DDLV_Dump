using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;

namespace Mdl
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20001ED")]
	public sealed class CultureFontFallbackGroup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40010FB")]
		public string languageIso;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010FC")]
		public List<TMP_FontAsset> fontReferences;

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CultureFontFallbackGroup()
		{
		}
	}
}
