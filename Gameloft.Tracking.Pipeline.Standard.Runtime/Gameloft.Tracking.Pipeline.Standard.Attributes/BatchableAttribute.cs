using System;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[AttributeUsage(AttributeTargets.Property)]
	public class BatchableAttribute : Attribute
	{
	}
}
