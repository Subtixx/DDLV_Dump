using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000838")]
	public enum KeyholeStatusOperator
	{
		[Cpp2IlInjected.Token(Token = "0x40028D1")]
		[OriginalName("KeyholeStatusOperator_Equal")]
		Equal,
		[Cpp2IlInjected.Token(Token = "0x40028D2")]
		[OriginalName("KeyholeStatusOperator_NotEqual")]
		NotEqual,
		[Cpp2IlInjected.Token(Token = "0x40028D3")]
		[OriginalName("KeyholeStatusOperator_LessThan")]
		LessThan,
		[Cpp2IlInjected.Token(Token = "0x40028D4")]
		[OriginalName("KeyholeStatusOperator_LessThanOrEqual")]
		LessThanOrEqual,
		[Cpp2IlInjected.Token(Token = "0x40028D5")]
		[OriginalName("KeyholeStatusOperator_GreaterThan")]
		GreaterThan,
		[Cpp2IlInjected.Token(Token = "0x40028D6")]
		[OriginalName("KeyholeStatusOperator_GreaterThanOrEqual")]
		GreaterThanOrEqual
	}
}
