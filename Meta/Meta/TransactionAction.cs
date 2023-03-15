using System;
using Cpp2IlInjected;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A5B")]
	public abstract class TransactionAction<TResult> : ITransactionAction where TResult : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000EBC")]
		bool ITransactionAction.IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600591F")]
			[Cpp2IlInjected.Address(RVA = "0x1A30C00", Offset = "0x1A2F600", VA = "0x181A30C00", Slot = "7")]
			get
			{
				TResult myResult = MyResult;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBD")]
		bool ITransactionAction.IsTriggeringSave
		{
			[Cpp2IlInjected.Token(Token = "0x6005920")]
			[Cpp2IlInjected.Address(RVA = "0x29C8D40", Offset = "0x29C7740", VA = "0x1829C8D40", Slot = "8")]
			get
			{
				TResult myResult = MyResult;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBE")]
		protected abstract TResult MyResult
		{
			[Cpp2IlInjected.Token(Token = "0x6005922")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005923")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBF")]
		protected virtual bool IsTriggeringSave
		{
			[Cpp2IlInjected.Token(Token = "0x6005924")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "12")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC0")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6005925")]
			[Cpp2IlInjected.Address(RVA = "0x2C8FCC0", Offset = "0x2C8E6C0", VA = "0x182C8FCC0")]
			get
			{
				//Discarded unreachable code: IL_0012
				TResult myResult = MyResult;
				return (long)"{il2cpp field on {'constant7' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x0}" == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600591C")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F790", Offset = "0x2C8E190", VA = "0x182C8F790")]
		public bool Apply(in Player player, in World world, ITransactionContext transactionContext)
		{
			//Discarded unreachable code: IL_0027
			string fullName = GetType().FullName;
			string text = "TransactionAction<" + fullName + ">.Apply";
			return ApplyThis(in player, in world, transactionContext);
		}

		[Cpp2IlInjected.Token(Token = "0x600591D")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FA40", Offset = "0x2C8E440", VA = "0x182C8FA40", Slot = "5")]
		object ITransactionAction.GetResult()
		{
			TResult myResult = MyResult;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600591E")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FAA0", Offset = "0x2C8E4A0", VA = "0x182C8FAA0", Slot = "6")]
		void ITransactionAction.SetResult(int result)
		{
		}//Discarded unreachable code: IL_0001


		[Cpp2IlInjected.Token(Token = "0x6005921")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext);

		[Cpp2IlInjected.Token(Token = "0x6005926")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		protected TransactionAction()
		{
		}//Discarded unreachable code: IL_0007


		[Cpp2IlInjected.Token(Token = "0x6005927")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FA10", Offset = "0x2C8E410", VA = "0x182C8FA10", Slot = "4")]
		bool ITransactionAction.Apply(in Player player, in World world, ITransactionContext transactionContext)
		{
			//Discarded unreachable code: IL_000a
			return ApplyThis(in player, in world, transactionContext);
		}
	}
}
