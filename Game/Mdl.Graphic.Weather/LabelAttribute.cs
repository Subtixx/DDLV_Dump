using System;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x200052B")]
	public class LabelAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400203C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400203D")]
		public LabelType type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400203E")]
		public bool belowPropertie;

		[Cpp2IlInjected.Token(Token = "0x60016B0")]
		[Cpp2IlInjected.Address(RVA = "0x11C5440", Offset = "0x11C3E40", VA = "0x1811C5440")]
		public LabelAttribute(string name, LabelType type, bool belowPropertie)
		{
			this.name = name;
			this.type = type;
			this.belowPropertie = belowPropertie;
		}
	}
}
