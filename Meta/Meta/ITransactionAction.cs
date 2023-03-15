using Cpp2IlInjected;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A5A")]
	public interface ITransactionAction
	{
		[Cpp2IlInjected.Token(Token = "0x17000EBA")]
		bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600591A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBB")]
		bool IsTriggeringSave
		{
			[Cpp2IlInjected.Token(Token = "0x600591B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6005917")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Apply(in Player player, in World world, ITransactionContext transactionContext);

		[Cpp2IlInjected.Token(Token = "0x6005918")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object GetResult();

		[Cpp2IlInjected.Token(Token = "0x6005919")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetResult(int result);
	}
}
