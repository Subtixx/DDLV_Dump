using System;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000522")]
	public class NiceNameAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002035")]
		public string name;

		[Cpp2IlInjected.Token(Token = "0x60016A7")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public NiceNameAttribute(string name)
		{
			this.name = name;
			/*Error: Unexpected end of block*/;
		}
	}
}
