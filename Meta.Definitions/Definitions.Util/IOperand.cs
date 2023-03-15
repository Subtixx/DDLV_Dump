using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	internal interface IOperand : IToken
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float GetValue(IEquationContext context);

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float GetValueWithLog(IEquationContext context, out string logStr);
	}
}
