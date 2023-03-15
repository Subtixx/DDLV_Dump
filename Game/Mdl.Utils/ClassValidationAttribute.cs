using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007B4")]
	[AttributeUsage(AttributeTargets.Class)]
	public abstract class ClassValidationAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6002243")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract IEnumerable<RequiredAttribute> GetRequiredAttributes(Type type);

		[Cpp2IlInjected.Token(Token = "0x6002244")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		protected ClassValidationAttribute()
		{
		}
	}
}
