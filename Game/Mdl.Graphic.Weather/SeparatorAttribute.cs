using System;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000529")]
	public class SeparatorAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400203A")]
		public string name;

		[Cpp2IlInjected.Token(Token = "0x60016AE")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public SeparatorAttribute(string name)
		{
			this.name = name;
			/*Error: Unexpected end of block*/;
		}
	}
}
