using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Avatar
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000A57")]
	public class ClothingOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400392F")]
		public bool expanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003930")]
		public List<ClothingOptionLabel> optionLabels = (List<ClothingOptionLabel>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003931")]
		public List<HiddenAvatarPart> hiddenParts = (List<HiddenAvatarPart>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003932")]
		public List<HiddenAvatarPart> unhiddenParts = (List<HiddenAvatarPart>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003027")]
		[Cpp2IlInjected.Address(RVA = "0xA87020", Offset = "0xA85A20", VA = "0x180A87020")]
		public ClothingOptions()
		{
		}
	}
}
