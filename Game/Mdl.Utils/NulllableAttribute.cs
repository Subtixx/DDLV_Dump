using System;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007B3")]
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class NulllableAttribute : OptionalAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6002242")]
		[Cpp2IlInjected.Address(RVA = "0xF03470", Offset = "0xF01E70", VA = "0x180F03470")]
		public NulllableAttribute()
		{
			Type typeFromHandle = typeof(NotNullAttribute);
			base._002Ector();
			base.IgnoredType = typeFromHandle;
			/*Error: Unexpected end of block*/;
		}
	}
}
