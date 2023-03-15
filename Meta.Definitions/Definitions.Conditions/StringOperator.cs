using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000833")]
	public enum StringOperator
	{
		[Cpp2IlInjected.Token(Token = "0x40028AD")]
		[OriginalName("StringOperator_Equal")]
		Equal,
		[Cpp2IlInjected.Token(Token = "0x40028AE")]
		[OriginalName("StringOperator_NotEqual")]
		NotEqual,
		[Cpp2IlInjected.Token(Token = "0x40028AF")]
		[OriginalName("StringOperator_Contain")]
		Contain,
		[Cpp2IlInjected.Token(Token = "0x40028B0")]
		[OriginalName("StringOperator_StartsWith")]
		StartsWith,
		[Cpp2IlInjected.Token(Token = "0x40028B1")]
		[OriginalName("StringOperator_EndsWith")]
		EndsWith
	}
}
