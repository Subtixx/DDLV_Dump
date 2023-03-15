using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	internal class BinaryOperatorToken : IOperator, IToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public readonly char OperatorSymbol;

		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public static char[] Operators;

		[Cpp2IlInjected.Token(Token = "0x1700031D")]
		public int BinaryPriority
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEA")]
			[Cpp2IlInjected.Address(RVA = "0x32E7570", Offset = "0x32E5F70", VA = "0x1832E7570")]
			get
			{
				char[] operators = Operators;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031E")]
		int IOperator.NumberOfOperands
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEB")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "4")]
			get
			{
				return 2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x32E7540", Offset = "0x32E5F40", VA = "0x1832E7540")]
		public BinaryOperatorToken(char operatorSymbol)
		{
			OperatorSymbol = operatorSymbol;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEC")]
		[Cpp2IlInjected.Address(RVA = "0x32E6FC0", Offset = "0x32E59C0", VA = "0x1832E6FC0", Slot = "5")]
		void IOperator.Evaluate(IEquationContext context, Stack<IOperand> operands, bool log)
		{
			//Discarded unreachable code: IL_0021
			IOperand operandB = (IOperand)((Stack<T>)(object)operands).Pop();
			IOperand operandA = (IOperand)((Stack<T>)(object)operands).Pop();
			NumberToken item = Evaluate(operandA, operandB, context, log);
			((Stack<T>)(object)operands).Push((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x32E7090", Offset = "0x32E5A90", VA = "0x1832E7090")]
		public NumberToken Evaluate(IOperand operandA, IOperand operandB, IEquationContext context, bool log)
		{
			//Discarded unreachable code: IL_0065, IL_0083
			//IL_005c: Expected F8, but got I4
			//IL_005c: Expected F8, but got I4
			//IL_0064: Expected F4, but got I4
			//IL_007b: Expected O, but got I4
			string empty = string.Empty;
			string empty2 = string.Empty;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			uint num3 = default(uint);
			if (num < (int)num3)
			{
				num += num;
				num++;
			}
			char operatorSymbol = OperatorSymbol;
			if (num <= 5)
			{
				operatorSymbol = (char)(operatorSymbol + operatorSymbol);
				num += 328;
				operatorSymbol = (char)(operatorSymbol + operatorSymbol);
				num += 328;
			}
			int num4 = 0;
			double num5 = Math.Pow(0.0, num4);
			return new NumberToken(0f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x32E7440", Offset = "0x32E5E40", VA = "0x1832E7440")]
		public static bool IsBinaryOperator(char c)
		{
			char[] operators = Operators;
			int num = default(int);
			return num != -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x32E74C0", Offset = "0x32E5EC0", VA = "0x1832E74C0")]
		static BinaryOperatorToken()
		{
			char[] array = new char[5];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			Operators = array;
			/*Error: Unexpected end of block*/;
		}
	}
}
