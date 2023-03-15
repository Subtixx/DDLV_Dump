using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class DateTimeExtension
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static DateTime epoch;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x41137D0", Offset = "0x41121D0", VA = "0x1841137D0")]
		public static string ToLocalPrettyTime(this DateTime time, [Optional] CultureInfo culture)
		{
			int num = 0;
			int num2 = 0;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			if (culture != null)
			{
				CultureInfo.CurrentCulture = culture;
			}
			string text = default(string);
			string text2 = default(string);
			string result = text + " " + text2;
			CultureInfo.CurrentCulture = currentCulture;
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4113920", Offset = "0x4112320", VA = "0x184113920")]
		static DateTimeExtension()
		{
			int num = 0;
		}
	}
}
