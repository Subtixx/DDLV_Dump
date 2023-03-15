using Cpp2IlInjected;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A58")]
	public interface ITransactionValidator
	{
		[Cpp2IlInjected.Token(Token = "0x6005912")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Validate(in Player player, in World world, ITransactionContext transactionContext);
	}
}
