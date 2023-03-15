using System;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x200051A")]
	public class GroupAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002033")]
		public string name;

		[Cpp2IlInjected.Token(Token = "0x600169F")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public GroupAttribute(string name)
		{
			this.name = name;
			/*Error: Unexpected end of block*/;
		}
	}
}
