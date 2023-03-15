using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Avatar
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000A55")]
	public class ClothingOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003928")]
		public bool expanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003929")]
		public string name = "New Option";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400392A")]
		public List<HiddenAvatarPart> hiddenParts = (List<HiddenAvatarPart>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400392B")]
		public List<HiddenAvatarPart> unhiddenParts = (List<HiddenAvatarPart>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003025")]
		[Cpp2IlInjected.Address(RVA = "0xA86F50", Offset = "0xA85950", VA = "0x180A86F50")]
		public ClothingOption()
		{
		}
	}
}
