using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	internal class ParenthesisToken : IOperator, IToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public readonly char Parenthesis;

		[Cpp2IlInjected.Token(Token = "0x1700031A")]
		int IOperator.NumberOfOperands
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE0")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDF")]
		[Cpp2IlInjected.Address(RVA = "0x32E7540", Offset = "0x32E5F40", VA = "0x1832E7540")]
		public ParenthesisToken(char parenthesis)
		{
			Parenthesis = parenthesis;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE1")]
		[Cpp2IlInjected.Address(RVA = "0x36A8F60", Offset = "0x36A7960", VA = "0x1836A8F60", Slot = "5")]
		void IOperator.Evaluate(IEquationContext context, Stack<IOperand> operands, bool log)
		{
			EquationException ex = new EquationException("Invalid equation");
			/*Error: Unexpected end of block*/;
		}
	}
}
