using System;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000521")]
	public class OnEditCallbackAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002034")]
		public string callback;

		[Cpp2IlInjected.Token(Token = "0x60016A6")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public OnEditCallbackAttribute(string callback)
		{
			this.callback = callback;
			/*Error: Unexpected end of block*/;
		}
	}
}
