using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public class ModuloOperation : IOperationValidator<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x1033890", Offset = "0x1032290", VA = "0x181033890", Slot = "4")]
		public bool Validate(int leftValue, int rightValue, int expected)
		{
			return leftValue == expected;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ModuloOperation()
		{
		}
	}
}
