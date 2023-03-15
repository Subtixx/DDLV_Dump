using System;
using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard.Events;

namespace Gameloft.Tracking.Pipeline.Standard.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[AttributeUsage(AttributeTargets.Class)]
	public class PriorityAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000E4")]
		public EventPriority Priority
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xD7B5E0", Offset = "0xD79FE0", VA = "0x180D7B5E0")]
		public PriorityAttribute(EventPriority priority)
		{
			Priority = priority;
		}
	}
}
