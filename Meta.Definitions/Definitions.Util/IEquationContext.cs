using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public interface IEquationContext
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float GetVariableValue(string variableName);

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HasVariableValue(string variableName);
	}
}
