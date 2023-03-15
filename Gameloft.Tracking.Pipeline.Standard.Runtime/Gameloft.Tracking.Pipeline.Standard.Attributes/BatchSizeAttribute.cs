using System;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[AttributeUsage(AttributeTargets.Class)]
	public class BatchSizeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000E2")]
		public uint BatchSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
		}
	}
}
