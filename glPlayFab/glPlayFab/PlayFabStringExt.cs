using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public static class PlayFabStringExt
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x10408A0", Offset = "0x103F2A0", VA = "0x1810408A0")]
		public static string ToSearchNameShort(this string name, int len)
		{
			//Discarded unreachable code: IL_0049
			char[] array = new char[1];
			array[0] = ' ';
			string[] array2 = name.Split(array);
			Func<string, string> func = (Func<string, string>)(object)(Func<T, TResult>)delegate(string x)
			{
				//Discarded unreachable code: IL_002f
				int val = len;
				int stringLength = x.m_stringLength;
				int length = Math.Min(val, stringLength);
				int startIndex = 0;
				string text = x.Substring(startIndex, length);
				return "___" + text;
			};
			IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Select<string, string>((IEnumerable<>)(object)array2, (Func<, >)(object)func);
			return string.Join(" ", (IEnumerable<>)enumerable);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1040800", Offset = "0x103F200", VA = "0x181040800")]
		public static string ReplaceFirst(this string text, string search, string replace)
		{
			//Discarded unreachable code: IL_0031
			int num = text.IndexOf(search);
			int startIndex = 0;
			string text2 = text.Substring(startIndex, num);
			int stringLength = search.m_stringLength;
			stringLength += num;
			string text3 = text.Substring(stringLength);
			return text2 + replace + text3;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x1040770", Offset = "0x103F170", VA = "0x181040770")]
		public static bool IsTrue(this string boolAsStr)
		{
			if (string.Equals(boolAsStr, "1"))
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}
	}
}
