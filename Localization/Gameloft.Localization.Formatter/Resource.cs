using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace Gameloft.Localization.Formatter
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class Resource
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static Regex regex;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x40900C0", Offset = "0x408EAC0", VA = "0x1840900C0")]
		public static string Format(string s, IResolver resolver, CultureInfo culture)
		{
			//Discarded unreachable code: IL_00e5, IL_00eb, IL_00f1, IL_00f7, IL_00fd, IL_0103, IL_0109, IL_010f, IL_0115, IL_011b, IL_0121, IL_0127, IL_0133
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			int num = 0;
			if (resolver != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				MatchCollection matchCollection = default(MatchCollection);
				IEnumerator enumerator = matchCollection.GetEnumerator();
				StringBuilder stringBuilder4 = default(StringBuilder);
				if (enumerator != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					enumerator = (IEnumerator)(enumerator - num);
					int count = 0;
					string value = default(string);
					StringBuilder stringBuilder2 = stringBuilder.Append(value);
					char[] array = new char[1];
					uint num4 = default(uint);
					array[0] = (char)num4;
					string text = default(string);
					string text2 = text.Split(array, count)[0];
					char[] array2 = new char[3];
					RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					string text3 = text2.Trim(array2);
					uint num5 = default(uint);
					if (num < (int)num5)
					{
						num += num;
						num++;
					}
					if (num != 0 && num != 0)
					{
						StringBuilder stringBuilder3 = stringBuilder.Append(text);
						text += text;
					}
					string text4 = default(string);
					string text5 = "{0:" + text4;
					string value2 = default(string);
					stringBuilder4 = stringBuilder.Append((object)value2);
				}
				if (stringBuilder4 != null)
				{
				}
				int num6 = default(int);
				if ((long)num6 < (long)(IntPtr)stringBuilder4)
				{
					stringBuilder4 = (StringBuilder)(stringBuilder4 - num6);
					string value3 = default(string);
					StringBuilder stringBuilder5 = stringBuilder.Append(value3);
				}
			}
			return s;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4090670", Offset = "0x408F070", VA = "0x184090670")]
		static Resource()
		{
			Regex regex = new Regex("\\{(.*?)\\}");
			/*Error: Unexpected end of block*/;
		}
	}
}
