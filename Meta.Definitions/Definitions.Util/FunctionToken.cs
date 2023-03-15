using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	internal class FunctionToken : IOperator, IToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private readonly string functionName;

		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public static string[] Functions;

		[Cpp2IlInjected.Token(Token = "0x1700031F")]
		int IOperator.NumberOfOperands
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF1")]
			[Cpp2IlInjected.Address(RVA = "0x3441450", Offset = "0x343FE50", VA = "0x183441450", Slot = "4")]
			get
			{
				string text = functionName;
				if (text != null)
				{
					uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(text);
					if ((int)num > 1587810493)
					{
						if ((int)num > -485413336)
						{
							if (num == 4106703835u)
							{
							}
							if (num != 4263151599u)
							{
								goto IL_00a5;
							}
						}
						if ((num == 2362612187u && !string.Equals(text, "Abs")) || num != 3809553960u)
						{
							goto IL_00a5;
						}
					}
					if (num == 781469175 && string.Equals(text, "Min"))
					{
						goto IL_008a;
					}
					if (num == 1017635769)
					{
						if (string.Equals(text, "Max"))
						{
							goto IL_008a;
						}
					}
					else if (num == 1587810493 && string.Equals(text, "Floor"))
					{
						return 1;
					}
				}
				goto IL_00a5;
				IL_008a:
				return 2;
				IL_00a5:
				string message = default(string);
				EquationException ex = new EquationException(message);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public FunctionToken(string functionName)
		{
			this.functionName = functionName;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x3441270", Offset = "0x343FC70", VA = "0x183441270", Slot = "5")]
		void IOperator.Evaluate(IEquationContext context, Stack<IOperand> operands, bool log)
		{
			//Discarded unreachable code: IL_0046
			uint num2 = default(uint);
			IOperand[] array;
			IOperand operand;
			int length;
			do
			{
				int num = 0;
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				array = new IOperand[0];
				length = array.Length;
				operand = (IOperand)((Stack<T>)(object)operands).Pop();
			}
			while (operand != null && operand == null);
			length += 4;
			NumberToken item = Evaluate(array, context, log);
			((Stack<T>)(object)operands).Push((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x3441620", Offset = "0x3440020", VA = "0x183441620")]
		public NumberToken Evaluate(IOperand[] operands, IEquationContext context, bool log)
		{
			//Discarded unreachable code: IL_012d
			//IL_012c: Expected F4, but got I4
			//IL_0140: Expected O, but got I4
			//IL_0179: Expected F4, but got I4
			uint num2 = default(uint);
			uint num3 = default(uint);
			while (true)
			{
				float[] array = new float[operands.Length];
				int num = 0;
				if (!log)
				{
					int length = operands.Length;
					if (num >= length)
					{
						goto IL_007e;
					}
					IOperand operand = operands[num];
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					num++;
					length += 312;
				}
				string[] array2 = new string[operands.Length];
				int length2 = operands.Length;
				if (num < length2)
				{
					IOperand operand2 = operands[num];
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					num++;
					num += num;
					num += 328;
				}
				goto IL_007e;
				IL_007e:
				if (num == 0)
				{
					continue;
				}
				if (num > 1587810493)
				{
					if (num > -485413336)
					{
						if (num == -188263461)
						{
							if (num == 0)
							{
								continue;
							}
							if (num == 1 || (num == 1 && num == 1))
							{
								break;
							}
						}
						if (num != -31815697 || num == 0)
						{
							continue;
						}
					}
					if ((num == -1932355109 && num == 0) || num != -485413336 || num == 0)
					{
						continue;
					}
				}
				if (num == 781469175)
				{
					if (num == 0)
					{
						continue;
					}
					float num4 = Enumerable.Min((IEnumerable<>)(object)array);
				}
				if (num == 1017635769)
				{
					if (num == 0)
					{
						continue;
					}
					float num5 = Enumerable.Max((IEnumerable<>)(object)array);
				}
				if (num == 1587810493 && num != 0)
				{
					break;
				}
			}
			return new NumberToken(0f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x3441EB0", Offset = "0x34408B0", VA = "0x183441EB0")]
		public static FunctionToken Parse(string stringToParse, ref int index)
		{
			//Discarded unreachable code: IL_0030
			int num;
			string text = default(string);
			uint value = default(uint);
			do
			{
				num = 0;
				int num2 = text.IndexOf((char)value);
				index.m_value = num;
			}
			while (num == -1);
			string text2 = default(string);
			if (Enumerable.Contains<string>((IEnumerable<>)(object)Functions, text2))
			{
				FunctionToken functionToken = default(FunctionToken);
				functionToken.functionName = text2;
				return functionToken;
			}
			EquationException ex = new EquationException("Invalid function " + text2);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x3442070", Offset = "0x3440A70", VA = "0x183442070")]
		static FunctionToken()
		{
			string[] array;
			while (true)
			{
				array = new string[7];
				if ("Abs" != null && "Abs" == null)
				{
					continue;
				}
				array[0] = "Abs";
				if ("Sqrt" != null && "Sqrt" == null)
				{
					continue;
				}
				array[1] = "Sqrt";
				if ("Floor" != null && "Floor" == null)
				{
					continue;
				}
				array[2] = "Floor";
				if ("Ceil" != null && "Ceil" == null)
				{
					continue;
				}
				array[3] = "Ceil";
				if ("Round" != null && "Round" == null)
				{
					continue;
				}
				array[4] = "Round";
				if ("Min" == null || "Min" != null)
				{
					array[5] = "Min";
					if ("Max" == null || "Max" != null)
					{
						break;
					}
				}
			}
			array[6] = "Max";
			Functions = array;
			throw new NullReferenceException();
		}
	}
}
