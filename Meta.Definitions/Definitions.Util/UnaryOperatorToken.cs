using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	internal class UnaryOperatorToken : IOperator, IToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public readonly char OperatorSymbol;

		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public static char[] Operators;

		[Cpp2IlInjected.Token(Token = "0x1700031B")]
		public int UnaryPriority
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE3")]
			[Cpp2IlInjected.Address(RVA = "0x35540F0", Offset = "0x3552AF0", VA = "0x1835540F0")]
			get
			{
				char[] operators = Operators;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031C")]
		int IOperator.NumberOfOperands
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE4")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "4")]
			get
			{
				return 1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE2")]
		[Cpp2IlInjected.Address(RVA = "0x32E7540", Offset = "0x32E5F40", VA = "0x1832E7540")]
		public UnaryOperatorToken(char operatorSymbol)
		{
			OperatorSymbol = operatorSymbol;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE5")]
		[Cpp2IlInjected.Address(RVA = "0x3553CB0", Offset = "0x35526B0", VA = "0x183553CB0", Slot = "5")]
		void IOperator.Evaluate(IEquationContext context, Stack<IOperand> operands, bool log)
		{
			//Discarded unreachable code: IL_0019
			IOperand operand = (IOperand)((Stack<T>)(object)operands).Pop();
			NumberToken item = Evaluate(operand, context, log);
			((Stack<T>)(object)operands).Push((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x3553D60", Offset = "0x3552760", VA = "0x183553D60")]
		public NumberToken Evaluate(IOperand operand, IEquationContext context, bool log)
		{
			//Discarded unreachable code: IL_003f
			//IL_0037: Expected O, but got I4
			string empty = string.Empty;
			int num = 0;
			uint num2 = default(uint);
			if (!log && num < (int)num2)
			{
				num += num;
				num++;
			}
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			NumberToken result = default(NumberToken);
			if (!log)
			{
				return result;
			}
			uint num3 = default(uint);
			string text = $"{num3}{empty}";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x3553FE0", Offset = "0x35529E0", VA = "0x183553FE0")]
		public static bool IsUnaryOperator(char c)
		{
			char[] operators = Operators;
			int num = default(int);
			return num != -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x3554060", Offset = "0x3552A60", VA = "0x183554060")]
		static UnaryOperatorToken()
		{
			char[] array = new char[1];
			array[0] = '-';
			Operators = array;
			throw new NullReferenceException();
		}
	}
}
