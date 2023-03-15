using System;
using Cpp2IlInjected;
using Meta;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	internal class VariableToken : IOperand, IToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public readonly string VariableName;

		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public VariableToken(string variableName)
		{
			VariableName = variableName;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x17C17E0", Offset = "0x17C01E0", VA = "0x1817C17E0", Slot = "4")]
		public float GetValue(IEquationContext context)
		{
			//Discarded unreachable code: IL_001d
			string variableName = VariableName;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return context.GetVariableValue(variableName);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x17C1680", Offset = "0x17C0080", VA = "0x1817C1680", Slot = "5")]
		public float GetValueWithLog(IEquationContext context, out string logStr)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string text = text + text;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x17C18A0", Offset = "0x17C02A0", VA = "0x1817C18A0")]
		public static VariableToken Parse(string stringToParse, ref int index)
		{
			//Discarded unreachable code: IL_0020
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			int num = default(int);
			if (num != -1)
			{
				string text = default(string);
				index.m_value = (int)text;
				int fieldNumber = 0;
				VariableToken variableToken = default(VariableToken);
				((SetFurnitureToggleState)(object)variableToken).SetFieldValue(fieldNumber, (object)num);
				string variableName = default(string);
				variableToken.VariableName = variableName;
				return variableToken;
			}
			EquationException ex = new EquationException("Mismatched curly braces");
			/*Error: Unexpected end of block*/;
		}
	}
}
