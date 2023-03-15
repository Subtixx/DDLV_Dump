using System.Globalization;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	internal class NumberToken : IOperand, IToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private readonly float value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private string log;

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x29797A0", Offset = "0x29781A0", VA = "0x1829797A0")]
		public NumberToken(float value)
		{
			this.value = value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2979750", Offset = "0x2978150", VA = "0x182979750")]
		public NumberToken(float value, string log)
		{
			this.log = log;
			this.value = value;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0", Slot = "4")]
		public float GetValue(IEquationContext context)
		{
			return value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCF")]
		[Cpp2IlInjected.Address(RVA = "0x2979580", Offset = "0x2977F80", VA = "0x182979580", Slot = "5")]
		public float GetValueWithLog(IEquationContext context, out string logStr)
		{
			string text = log;
			int num = 0;
			float result = value;
			if (text == null)
			{
				string text2 = default(string);
				log = text2;
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD0")]
		[Cpp2IlInjected.Address(RVA = "0x2979600", Offset = "0x2978000", VA = "0x182979600")]
		public static NumberToken Parse(string stringToParse, ref int index)
		{
			//Discarded unreachable code: IL_0028
			char c = default(char);
			if (!char.IsDigit(c))
			{
			}
			int num = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			NumberToken numberToken = default(NumberToken);
			string s = default(string);
			float num2 = (numberToken.value = float.Parse(s, invariantCulture));
			return numberToken;
		}
	}
}
