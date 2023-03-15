using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007AB")]
	[AttributeUsage(AttributeTargets.Field)]
	public abstract class RequiredAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6002220")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract IEnumerable<string> GetErrors(object value);

		[Cpp2IlInjected.Token(Token = "0x6002221")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		protected RequiredAttribute()
		{
		}
	}
}
