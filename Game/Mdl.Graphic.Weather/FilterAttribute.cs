using System;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x200052A")]
	public class FilterAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400203B")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60016AF")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public FilterAttribute(Type type)
		{
			this.type = type;
			/*Error: Unexpected end of block*/;
		}
	}
}
