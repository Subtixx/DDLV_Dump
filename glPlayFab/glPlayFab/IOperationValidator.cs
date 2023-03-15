using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public interface IOperationValidator<TYPE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Validate(TYPE leftValue, TYPE rightValue, TYPE expected);
	}
}
