using System;
using System.Globalization;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	internal class ConstantToken : IOperand, IToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public readonly string ConstantName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private readonly float value;

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0x3279100", Offset = "0x3277B00", VA = "0x183279100")]
		public ConstantToken(string constantName, float value)
		{
			ConstantName = constantName;
			this.value = value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330", Slot = "4")]
		public float GetValue(IEquationContext context)
		{
			return value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x3278EA0", Offset = "0x32778A0", VA = "0x183278EA0", Slot = "5")]
		public float GetValueWithLog(IEquationContext context, out string logStr)
		{
			float num = value;
			string constantName = ConstantName;
			string text = string.Format("[{0} {1}]", constantName, "[{0} {1}]");
			return value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x3278F40", Offset = "0x3277940", VA = "0x183278F40")]
		public static IToken Parse(string stringToParse, ref int index)
		{
			//IL_000b: Expected I4, but got O
			int num = default(int);
			if (num != -1)
			{
				index.m_value = (int)stringToParse;
				int startIndex = 0;
				string text = default(string);
				int length = default(int);
				string constantName = text.Substring(startIndex, length);
				int num2 = default(int);
				int startIndex2 = num2 + 1;
				string s = text.Substring(startIndex2);
				int num3 = 0;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				float num4 = float.Parse(s, invariantCulture);
				ConstantToken constantToken = default(ConstantToken);
				constantToken.ConstantName = constantName;
				constantToken.value = num4;
				throw new NullReferenceException();
			}
			EquationException ex = new EquationException("Mismatched vertical lines");
			/*Error: Unexpected end of block*/;
		}
	}
}
