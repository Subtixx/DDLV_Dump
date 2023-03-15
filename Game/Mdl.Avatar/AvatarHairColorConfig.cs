using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A60")]
	[CreateAssetMenu]
	public class AvatarHairColorConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A61")]
		public struct HairColorOption
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003951")]
			[ColorUsage(false)]
			public Color baseColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003952")]
			[ColorUsage(false)]
			public Color firstColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003953")]
			[ColorUsage(false)]
			public Color secondColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4003954")]
			public int displayOrder;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A62")]
		public struct HighlightColorOption
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003955")]
			public Color baseColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003956")]
			public int displayOrder;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400394F")]
		public List<HairColorOption> hairColorOptions = (List<HairColorOption>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003950")]
		public List<HighlightColorOption> highlightColorOptions = (List<HighlightColorOption>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003033")]
		[Cpp2IlInjected.Address(RVA = "0x151DC30", Offset = "0x151C630", VA = "0x18151DC30")]
		public AvatarHairColorConfig()
		{
		}
	}
}
