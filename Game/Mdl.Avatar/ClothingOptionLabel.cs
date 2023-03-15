using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Avatar
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000A56")]
	public class ClothingOptionLabel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400392C")]
		public bool expanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400392D")]
		public string name = "New Label";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400392E")]
		public List<ClothingOption> options = (List<ClothingOption>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003026")]
		[Cpp2IlInjected.Address(RVA = "0xA86EB0", Offset = "0xA858B0", VA = "0x180A86EB0")]
		public ClothingOptionLabel()
		{
		}
	}
}
