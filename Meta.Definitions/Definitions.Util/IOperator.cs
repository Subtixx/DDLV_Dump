using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	internal interface IOperator : IToken
	{
		[Cpp2IlInjected.Token(Token = "0x17000319")]
		int NumberOfOperands
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Evaluate(IEquationContext context, Stack<IOperand> operands, bool log);
	}
}
