using System;
using Cpp2IlInjected;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A59")]
	public abstract class TransactionValidator<TResult> : ITransactionValidator where TResult : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x6005913")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FD80", Offset = "0x2C8E780", VA = "0x182C8FD80", Slot = "4")]
		int ITransactionValidator.Validate(in Player player, in World world, ITransactionContext transactionContext)
		{
			TResult val = ValidateThis(in player, in world, transactionContext);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005914")]
		[Cpp2IlInjected.Address(RVA = "0x2C90060", Offset = "0x2C8EA60", VA = "0x182C90060")]
		public TResult Validate(in Player player, in World world, ITransactionContext transactionContext)
		{
			//Discarded unreachable code: IL_0029
			int num = 0;
			string fullName = GetType().FullName;
			string text = "TransactionValidator<" + fullName + ">.Validate";
			return ValidateThis(in player, in world, transactionContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6005915")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract TResult ValidateThis(in Player player, in World world, ITransactionContext transactionContext);

		[Cpp2IlInjected.Token(Token = "0x6005916")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		protected TransactionValidator()
		{
		}//Discarded unreachable code: IL_0007

	}
}
