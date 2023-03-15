using System;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[AttributeUsage(AttributeTargets.Property)]
	public class EncryptAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public EncryptAttribute()
		{
		}
	}
}
