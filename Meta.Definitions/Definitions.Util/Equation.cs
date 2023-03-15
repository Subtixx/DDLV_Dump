using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public class Equation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private List<IToken> parsedEquation = (List<IToken>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000315")]
		public string EquationString
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CEquationString_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CEquationString_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000316")]
		public Dictionary<string, float> Constants
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB8")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0F50", Offset = "0x2C9F950", VA = "0x182CA0F50")]
			get
			{
				//Discarded unreachable code: IL_00e4
				IEnumerable<ConstantToken> enumerable = (IEnumerable<ConstantToken>)Enumerable.OfType<ConstantToken>((IEnumerable)parsedEquation);
				Func<ConstantToken, string> _003C_003E9__14_ = _003C_003Ec._003C_003E9__14_0;
				if (_003C_003E9__14_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ConstantToken x) => x.ConstantName);
				}
				Func<ConstantToken, float> func = default(Func<ConstantToken, float>);
				if (_003C_003Ec._003C_003E9__14_1 == null)
				{
					func = (Func<ConstantToken, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ConstantToken x) => x.value));
				}
				Dictionary<ConstantToken, string> dictionary = (Dictionary<ConstantToken, string>)(object)Enumerable.ToDictionary<ConstantToken, string, float>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__14_, (Func<, >)(object)func);
				Dictionary<string, Equation>.ValueCollection values = (Dictionary<string, Equation>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)this.get_SubEquations()).get_Values();
				Func<Equation, IEnumerable<KeyValuePair<string, float>>> func2 = default(Func<Equation, IEnumerable<KeyValuePair<string, float>>>);
				if (_003C_003Ec._003C_003E9__14_2 == null)
				{
					func2 = (Func<Equation, IEnumerable<KeyValuePair<string, float>>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Equation x)
					{
						Dictionary<string, float> constants = (Dictionary<string, float>)(object)x.get_Constants();
						throw new NullReferenceException();
					});
				}
				IEnumerable<Equation> enumerable2 = (IEnumerable<Equation>)Enumerable.SelectMany<Equation, KeyValuePair<string, float>>((IEnumerable<>)(object)values, (Func<, >)(object)func2);
				IEnumerable<KeyValuePair<string, float>> enumerable3 = (IEnumerable<KeyValuePair<string, float>>)Enumerable.Concat<KeyValuePair<string, float>>((IEnumerable<>)dictionary, (IEnumerable<>)enumerable2);
				Func<KeyValuePair<string, float>, string> func3 = default(Func<KeyValuePair<string, float>, string>);
				if (_003C_003Ec._003C_003E9__14_3 == null)
				{
					func3 = (Func<KeyValuePair<string, float>, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				Func<KeyValuePair<string, float>, float> func4 = default(Func<KeyValuePair<string, float>, float>);
				if (_003C_003Ec._003C_003E9__14_4 == null)
				{
					func4 = (Func<KeyValuePair<string, float>, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				return (Dictionary<string, float>)(object)Enumerable.ToDictionary<KeyValuePair<string, float>, string, float>((IEnumerable<>)enumerable3, (Func<, >)(object)func3, (Func<, >)(object)func4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		public Dictionary<string, Equation> SubEquations
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB9")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1480", Offset = "0x2C9FE80", VA = "0x182CA1480")]
			get
			{
				List<SubEquationToken> list = (List<SubEquationToken>)(object)Enumerable.ToList<SubEquationToken>(Enumerable.OfType<SubEquationToken>((IEnumerable)parsedEquation));
				Func<SubEquationToken, string> _003C_003E9__16_ = _003C_003Ec._003C_003E9__16_0;
				if (_003C_003E9__16_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SubEquationToken x) => x.Name);
				}
				Func<SubEquationToken, Equation> func = default(Func<SubEquationToken, Equation>);
				if (_003C_003Ec._003C_003E9__16_1 == null)
				{
					func = (Func<SubEquationToken, Equation>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SubEquationToken x) => x.SubEquation));
				}
				Dictionary<SubEquationToken, string> dictionary = (Dictionary<SubEquationToken, string>)(object)Enumerable.ToDictionary<SubEquationToken, string, Equation>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__16_, (Func<, >)(object)func);
				Func<SubEquationToken, IEnumerable<KeyValuePair<string, Equation>>> func2 = default(Func<SubEquationToken, IEnumerable<KeyValuePair<string, Equation>>>);
				if (_003C_003Ec._003C_003E9__16_2 == null)
				{
					func2 = (Func<SubEquationToken, IEnumerable<KeyValuePair<string, Equation>>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(SubEquationToken x)
					{
						Dictionary<string, Equation> subEquations = (Dictionary<string, Equation>)(object)x.SubEquation.get_SubEquations();
						throw new NullReferenceException();
					});
				}
				IEnumerable<SubEquationToken> enumerable = (IEnumerable<SubEquationToken>)Enumerable.SelectMany<SubEquationToken, KeyValuePair<string, Equation>>((IEnumerable<>)list, (Func<, >)(object)func2);
				IEnumerable<KeyValuePair<string, Equation>> enumerable2 = (IEnumerable<KeyValuePair<string, Equation>>)Enumerable.Concat<KeyValuePair<string, Equation>>((IEnumerable<>)dictionary, (IEnumerable<>)enumerable);
				Func<KeyValuePair<string, Equation>, string> func3 = default(Func<KeyValuePair<string, Equation>, string>);
				if (_003C_003Ec._003C_003E9__16_3 == null)
				{
					func3 = (Func<KeyValuePair<string, Equation>, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				Func<KeyValuePair<string, Equation>, Equation> func4 = default(Func<KeyValuePair<string, Equation>, Equation>);
				if (_003C_003Ec._003C_003E9__16_4 == null)
				{
					func4 = (Func<KeyValuePair<string, Equation>, Equation>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				return (Dictionary<string, Equation>)(object)Enumerable.ToDictionary<KeyValuePair<string, Equation>, string, Equation>((IEnumerable<>)enumerable2, (Func<, >)(object)func3, (Func<, >)(object)func4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		public IEnumerable<string> Variables
		{
			[Cpp2IlInjected.Token(Token = "0x6000CBA")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1980", Offset = "0x2CA0380", VA = "0x182CA1980")]
			get
			{
				IEnumerable<VariableToken> enumerable = (IEnumerable<VariableToken>)Enumerable.OfType<VariableToken>((IEnumerable)parsedEquation);
				Func<VariableToken, string> _003C_003E9__18_ = _003C_003Ec._003C_003E9__18_0;
				if (_003C_003E9__18_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VariableToken x) => x.VariableName);
				}
				return (IEnumerable<string>)Enumerable.Distinct<string>(Enumerable.Select<VariableToken, string>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__18_));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0ED0", Offset = "0x2C9F8D0", VA = "0x182CA0ED0")]
		private Equation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA02D0", Offset = "0x2C9ECD0", VA = "0x182CA02D0")]
		public static Equation Parse(string equationString)
		{
			//Discarded unreachable code: IL_02f4
			FunctionToken item3 = default(FunctionToken);
			char c12 = default(char);
			while (true)
			{
				Equation equation = new Equation();
				List<IToken> list = (equation.parsedEquation = (List<IToken>)(object)new List<T>());
				equation.EquationString = equationString;
				Stack<IOperator> stack = (Stack<IOperator>)(object)new Stack<T>();
				int num = 0;
				int index = 0;
				int index6;
				char c9;
				if (num < equationString.m_stringLength)
				{
					char c = equationString[index];
					int index2 = 0;
					bool flag = char.IsWhiteSpace(c);
					if (!flag)
					{
						c = equationString[index2];
						int index3 = 0;
						if (char.IsDigit(c))
						{
							goto IL_0293;
						}
						char c2 = equationString[index3];
						char c3 = equationString[index3];
						char c4 = equationString[index3];
						char c5 = equationString[index3];
						char c6 = equationString[index3];
						c = equationString[index3];
						int index4 = 0;
						if (char.IsLetter(c))
						{
							goto IL_028b;
						}
						char c7 = equationString[index4];
						if (1L != 0L)
						{
							char c8 = equationString[index4];
							int index5 = 0;
							if (UnaryOperatorToken.IsUnaryOperator(c8))
							{
								c8 = equationString[index5];
								UnaryOperatorToken item = new UnaryOperatorToken(c8);
								((Stack<T>)(object)stack).Push((T)item);
							}
						}
					}
					c9 = equationString[flag ? 1 : 0];
					index6 = 0;
					if (!BinaryOperatorToken.IsBinaryOperator(c9))
					{
						char c10 = equationString[index6];
						char c11 = equationString[index6];
						if (Enumerable.Any<IOperator>((IEnumerable<>)stack))
						{
							IOperator @operator = (IOperator)((Stack<T>)(object)stack).Peek();
							if (@operator != null)
							{
								int num2 = 0;
								if (@operator != null)
								{
									goto IL_0168;
								}
							}
							List<IToken> list2 = equation.parsedEquation;
							IOperator item2 = (IOperator)((Stack<T>)(object)stack).Pop();
							((List<T>)(object)list2).Add((T)item2);
							if (Enumerable.Any<IOperator>((IEnumerable<>)stack))
							{
								continue;
							}
						}
						goto IL_0168;
					}
					goto IL_01e1;
				}
				goto IL_02a0;
				IL_0293:
				((List<T>)(object)equation.parsedEquation).Add((T)item3);
				goto IL_02a0;
				IL_01e1:
				c9 = c12;
				BinaryOperatorToken operatorA = new BinaryOperatorToken(c9);
				if (!Enumerable.Any<IOperator>((IEnumerable<>)stack))
				{
					continue;
				}
				IOperator operatorB = (IOperator)((Stack<T>)(object)stack).Peek();
				if (!IsHigherPriority(operatorA, operatorB))
				{
					continue;
				}
				List<IToken> list3 = equation.parsedEquation;
				IOperator item4 = (IOperator)((Stack<T>)(object)stack).Pop();
				((List<T>)(object)list3).Add((T)item4);
				if (Enumerable.Any<IOperator>((IEnumerable<>)stack) || !Enumerable.Any<IOperator>((IEnumerable<>)stack))
				{
					continue;
				}
				IOperator operator2 = (IOperator)((Stack<T>)(object)stack).Peek();
				if (operator2 != null)
				{
					int num3 = 0;
					if (operator2 != null)
					{
						goto IL_0270;
					}
				}
				List<IToken> list4 = equation.parsedEquation;
				IOperator item5 = (IOperator)((Stack<T>)(object)stack).Pop();
				((List<T>)(object)list4).Add((T)item5);
				goto IL_0270;
				IL_0270:
				IOperator operator3 = (IOperator)((Stack<T>)(object)stack).Peek();
				if (operator3 == null)
				{
					continue;
				}
				int num4 = 0;
				if (operator3 == null)
				{
					continue;
				}
				goto IL_028b;
				IL_028b:
				((Stack<T>)(object)stack).Push((T)item3);
				goto IL_0293;
				IL_0168:
				if (!Enumerable.Any<IOperator>((IEnumerable<>)stack))
				{
					break;
				}
				IOperator operator4 = (IOperator)((Stack<T>)(object)stack).Peek();
				if (operator4 == null)
				{
					break;
				}
				int num5 = 0;
				if (operator4 == null)
				{
					break;
				}
				IOperator operator5 = (IOperator)((Stack<T>)(object)stack).Pop();
				if (Enumerable.Any<IOperator>((IEnumerable<>)stack))
				{
					IOperator operator6 = (IOperator)((Stack<T>)(object)stack).Peek();
					if (operator6 != null)
					{
						int num6 = 0;
						if (operator6 != null)
						{
							List<IToken> list5 = equation.parsedEquation;
							IOperator item6 = (IOperator)((Stack<T>)(object)stack).Pop();
							((List<T>)(object)list5).Add((T)item6);
						}
					}
				}
				c9 = equationString[index6];
				ParenthesisToken parenthesisToken = new ParenthesisToken(c9);
				goto IL_01e1;
				IL_02a0:
				if (Enumerable.Any<IOperator>((IEnumerable<>)stack))
				{
					IOperator operator7 = (IOperator)((Stack<T>)(object)stack).Peek();
					if (operator7 != null)
					{
						int num7 = 0;
						if (operator7 != null)
						{
							continue;
						}
					}
					List<IToken> list6 = equation.parsedEquation;
					IOperator item7 = (IOperator)((Stack<T>)(object)stack).Pop();
					((List<T>)(object)list6).Add((T)item7);
					if (Enumerable.Any<IOperator>((IEnumerable<>)stack))
					{
						continue;
					}
				}
				if (CheckValidity(equation))
				{
					return equation;
				}
			}
			EquationException ex = new EquationException("Mismatched parentheses");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FF00", Offset = "0x2C9E900", VA = "0x182C9FF00")]
		private static bool IsHigherPriority(IOperator operatorA, IOperator operatorB)
		{
			if (operatorA != null)
			{
				int num = 0;
				if (operatorA != null)
				{
					goto IL_0036;
				}
			}
			if (operatorB != null)
			{
				int num2 = 0;
				if (operatorB != null)
				{
					goto IL_0024;
				}
			}
			int num3 = 0;
			if (operatorA != null && operatorB != null)
			{
				int num4 = 0;
				if (operatorB == null)
				{
				}
			}
			goto IL_0024;
			IL_0024:
			int num5 = 0;
			if (operatorA != null && operatorB != null)
			{
				int num6 = 0;
				if (operatorB == null)
				{
				}
			}
			goto IL_0036;
			IL_0036:
			int num7 = 0;
			if (operatorA == null)
			{
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				int num13 = default(int);
				int num14 = default(int);
				return num13 > num14;
			}
			int num15 = 0;
			int num16 = 0;
			int num17 = 0;
			int num18 = 0;
			int num19 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F730", Offset = "0x2C9E130", VA = "0x182C9F730")]
		private static bool CheckValidity(Equation equation)
		{
			//Discarded unreachable code: IL_0035, IL_003b
			int num = 0;
			int num2 = 0;
			List<IToken> list = equation.parsedEquation;
			bool flag = default(bool);
			if (flag)
			{
				if (!flag)
				{
					while (!flag)
					{
					}
					num2 -= (flag ? 1 : 0);
				}
				num2++;
				int num3 = 0;
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FCD0", Offset = "0x2C9E6D0", VA = "0x182C9FCD0")]
		public float Evaluate(IEquationContext context)
		{
			//Discarded unreachable code: IL_005d
			if (context == null)
			{
				List<IToken> cpp2il__autoParamName__idx_ = parsedEquation;
				Func<IToken, bool> _003C_003E9__9_ = _003C_003Ec._003C_003E9__9_0;
				if (_003C_003E9__9_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(IToken x)
					{
						if (x == null)
						{
							return 0 != 0;
						}
						int num3 = 0;
						return x != null;
					};
				}
				if (((IEnumerable<>)cpp2il__autoParamName__idx_).Any<IToken>((Func<, >)(object)_003C_003E9__9_))
				{
					EquationException ex = new EquationException("The equation contains variables and no context was provided.");
					/*Error: Unexpected end of block*/;
				}
			}
			int log = 0;
			IOperand operand = Evaluate(context, (byte)log != 0);
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return operand.GetValue(context);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F950", Offset = "0x2C9E350", VA = "0x182C9F950")]
		public float EvaluateWithLog(IEquationContext context, out string logStr)
		{
			//Discarded unreachable code: IL_001f
			//IL_0008: Expected I4, but got I8
			ulong num = default(ulong);
			IOperand operand = Evaluate(context, (byte)num != 0);
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			return operand.GetValue(context);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB6")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FA30", Offset = "0x2C9E430", VA = "0x182C9FA30")]
		private IOperand Evaluate(IEquationContext context, bool log)
		{
			//Discarded unreachable code: IL_0041
			//IL_0036: Expected F4, but got I4
			if (Enumerable.Any<IToken>((IEnumerable<>)parsedEquation))
			{
				Stack<IOperand> stack = (Stack<IOperand>)(object)new Stack<T>();
				List<IToken> list = parsedEquation;
				bool flag = default(bool);
				if (flag && !flag)
				{
					while (!flag)
					{
					}
				}
				IOperand operand = (IOperand)((Stack<T>)(object)stack).Pop();
			}
			int num = default(int);
			NumberToken numberToken = new NumberToken(num);
			num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB7")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F3A0", Offset = "0x2C9DDA0", VA = "0x182C9F3A0")]
		public bool CanEvaluate(IEquationContext context)
		{
			//Discarded unreachable code: IL_008e, IL_0094, IL_009a
			int num = 0;
			int num2 = 0;
			IEnumerable<VariableToken> enumerable = (IEnumerable<VariableToken>)Enumerable.OfType<VariableToken>((IEnumerable)parsedEquation);
			Dictionary<string, Equation>.ValueCollection values = (Dictionary<string, Equation>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)this.get_SubEquations()).get_Values();
			Func<Equation, IEnumerable<VariableToken>> _003C_003E9__12_ = _003C_003Ec._003C_003E9__12_0;
			if (_003C_003E9__12_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Equation x) => (IEnumerable<VariableToken>)Enumerable.OfType<VariableToken>((IEnumerable)x.parsedEquation));
			}
			IEnumerable<Equation> enumerable2 = (IEnumerable<Equation>)Enumerable.SelectMany<Equation, VariableToken>((IEnumerable<>)(object)values, (Func<, >)(object)_003C_003E9__12_);
			IEnumerable<VariableToken> enumerable3 = (IEnumerable<VariableToken>)Enumerable.Concat<VariableToken>((IEnumerable<>)enumerable, (IEnumerable<>)enumerable2);
			if (enumerable3 != null)
			{
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					if (num2 == (int)num3)
					{
						goto IL_0073;
					}
					num2++;
				}
				while (num2 != 0)
				{
				}
				int num4 = 0;
				num2++;
				goto IL_0073;
			}
			goto IL_007b;
			IL_007b:
			num2++;
			if (enumerable3 != null)
			{
			}
			if (num2 != 0)
			{
			}
			throw new NullReferenceException();
			IL_0073:
			num2 += 312;
			goto IL_007b;
		}
	}
}
