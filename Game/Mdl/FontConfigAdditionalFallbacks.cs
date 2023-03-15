using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
	[CreateAssetMenu]
	public class FontConfigAdditionalFallbacks : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010FD")]
		[Tooltip("Specific fallback fonts to support extended characters")]
		public List<TMP_FontAsset> additionalFallbackFonts;

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public FontConfigAdditionalFallbacks()
		{
		}
	}
}
