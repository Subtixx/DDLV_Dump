using System;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public class EquationException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F330", Offset = "0x2C9DD30", VA = "0x182C9F330")]
		public EquationException(string message)
			: base(message)
		{
		}
	}
}
