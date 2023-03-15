using System;
using Cpp2IlInjected;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[AttributeUsage(AttributeTargets.Class)]
	public class GlobalMaterialReplacerAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public GlobalMaterialReplacerAttribute()
		{
		}
	}
}
