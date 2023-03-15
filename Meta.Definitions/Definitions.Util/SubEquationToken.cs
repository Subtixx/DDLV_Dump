using System;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	internal class SubEquationToken : IOperand, IToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public readonly Equation SubEquation;

		[Cpp2IlInjected.Token(Token = "0x6000CD9")]
		[Cpp2IlInjected.Address(RVA = "0x539250", Offset = "0x537C50", VA = "0x180539250")]
		public SubEquationToken(string subEquationName, Equation subEquation)
		{
			Name = subEquationName;
			SubEquation = subEquation;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDA")]
		[Cpp2IlInjected.Address(RVA = "0x25570E0", Offset = "0x2555AE0", VA = "0x1825570E0", Slot = "4")]
		public float GetValue(IEquationContext context)
		{
			//Discarded unreachable code: IL_000d
			return SubEquation.Evaluate(context);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDB")]
		[Cpp2IlInjected.Address(RVA = "0x25570C0", Offset = "0x2555AC0", VA = "0x1825570C0", Slot = "5")]
		public float GetValueWithLog(IEquationContext context, out string logStr)
		{
			//Discarded unreachable code: IL_000e
			return SubEquation.EvaluateWithLog(context, out logStr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDC")]
		[Cpp2IlInjected.Address(RVA = "0x2557100", Offset = "0x2555B00", VA = "0x182557100")]
		public static IToken Parse(string stringToParse, ref int index)
		{
			//Discarded unreachable code: IL_005d
			uint num = num + 1;
			if (num != 0)
			{
			}
			string text = default(string);
			string text2 = text.Trim();
			uint value = default(uint);
			int length = text2.IndexOf((char)value);
			int startIndex = 0;
			string name = text2.Substring(startIndex, length);
			uint value2 = default(uint);
			int startIndex2 = text2.IndexOf((char)value2) + 1;
			Equation subEquation = Equation.Parse(text2.Substring(startIndex2));
			SubEquationToken subEquationToken = default(SubEquationToken);
			subEquationToken.Name = name;
			subEquationToken.SubEquation = subEquation;
			throw new NullReferenceException();
		}
	}
}
