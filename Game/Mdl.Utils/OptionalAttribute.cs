using System;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007B2")]
	[AttributeUsage(AttributeTargets.Field)]
	public class OptionalAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x170004C7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002BB8")]
		public Type IgnoredType
		{
			[Cpp2IlInjected.Token(Token = "0x6002240")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6002241")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public OptionalAttribute(Type ignoredType)
		{
			IgnoredType = ignoredType;
			/*Error: Unexpected end of block*/;
		}
	}
}
