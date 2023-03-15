using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000834")]
	public enum IntOperator
	{
		[Cpp2IlInjected.Token(Token = "0x40028B3")]
		[OriginalName("IntOperator_Equal")]
		Equal,
		[Cpp2IlInjected.Token(Token = "0x40028B4")]
		[OriginalName("IntOperator_NotEqual")]
		NotEqual,
		[Cpp2IlInjected.Token(Token = "0x40028B5")]
		[OriginalName("IntOperator_LessThan")]
		LessThan,
		[Cpp2IlInjected.Token(Token = "0x40028B6")]
		[OriginalName("IntOperator_LessThanOrEqual")]
		LessThanOrEqual,
		[Cpp2IlInjected.Token(Token = "0x40028B7")]
		[OriginalName("IntOperator_GreaterThan")]
		GreaterThan,
		[Cpp2IlInjected.Token(Token = "0x40028B8")]
		[OriginalName("IntOperator_GreaterThanOrEqual")]
		GreaterThanOrEqual
	}
}
