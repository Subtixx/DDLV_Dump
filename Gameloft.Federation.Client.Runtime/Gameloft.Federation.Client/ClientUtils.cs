using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ClientUtils
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly Regex JsonRegex;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4032670", Offset = "0x4031070", VA = "0x184032670")]
		public static bool IsValid(object value)
		{
			if (value != null)
			{
				int num = 0;
				return Enum.IsDefined(value.GetType(), value);
			}
			return value != null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4032730", Offset = "0x4031130", VA = "0x184032730")]
		public static Multimap<string, string> ParameterToMultiMap(string collectionFormat, string name, object value)
		{
			//Discarded unreachable code: IL_0042, IL_0048, IL_004e
			int num = 0;
			Multimap<string, string> multimap = (Multimap<string, string>)(object)new Multimap<TKey, TValue>();
			if (multimap != null && multimap != null)
			{
				if (multimap != null)
				{
					string value2 = ParameterToString(multimap);
					((Multimap<TKey, TValue>)(object)multimap).Add((TKey)name, (TValue)value2);
				}
				num++;
				if (num != 0)
				{
				}
				if (num == 0)
				{
				}
			}
			string value3 = ParameterToString(value);
			((Multimap<TKey, TValue>)(object)multimap).Add((TKey)name, (TValue)value3);
			return multimap;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x40329C0", Offset = "0x40313C0", VA = "0x1840329C0")]
		public static string ParameterToString(object param)
		{
			//Discarded unreachable code: IL_006f
			int num = 0;
			if (param != null)
			{
				if (param != null)
				{
					string result = default(string);
					return result;
				}
				if (param != null)
				{
					string result2 = default(string);
					return result2;
				}
				if (param != null)
				{
					string result3 = "false";
					if ((IntPtr)"{il2cpp field on {'constant28' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" != (IntPtr)num)
					{
						result3 = "true";
					}
					return result3;
				}
			}
			string text = default(string);
			if ("," == null)
			{
				if (param != null)
				{
					int num2 = 0;
					if (param != null)
					{
						return JToken.FromObject(param).ToString();
					}
				}
				int num3 = 0;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				return text;
			}
			IEnumerable<object> enumerable = default(IEnumerable<object>);
			if (text == null)
			{
				return string.Join<object>(",", (IEnumerable<>)enumerable);
			}
			string result4 = default(string);
			return result4;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4032D60", Offset = "0x4031760", VA = "0x184032D60")]
		static ClientUtils()
		{
			Regex regex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");
			/*Error: Unexpected end of block*/;
		}
	}
}
