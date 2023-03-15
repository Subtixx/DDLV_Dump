using System;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[AttributeUsage(AttributeTargets.Class)]
	public class EventIdAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xD7B5E0", Offset = "0xD79FE0", VA = "0x180D7B5E0")]
		public EventIdAttribute(int id)
		{
			Id = id;
		}
	}
}
