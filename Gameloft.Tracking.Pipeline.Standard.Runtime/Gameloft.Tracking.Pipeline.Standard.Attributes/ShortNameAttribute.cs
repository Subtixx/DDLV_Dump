using System;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[AttributeUsage(AttributeTargets.Property)]
	public class ShortNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000E5")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public ShortNameAttribute(string name)
		{
			Name = name;
			/*Error: Unexpected end of block*/;
		}
	}
}
