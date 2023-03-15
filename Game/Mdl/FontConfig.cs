using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[CreateAssetMenu]
	public sealed class FontConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010F8")]
		[Tooltip("Main fallback font if there's not other specific fallback font")]
		public TMP_FontAsset mainFontFallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010F9")]
		[Tooltip("Specific fallback fonts that have higher priority per culture")]
		public List<CultureFontFallbackGroup> cultureFontFallbackGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40010FA")]
		public List<TMP_FontAsset> keepLoaded;

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public FontConfig()
		{
		}
	}
}
