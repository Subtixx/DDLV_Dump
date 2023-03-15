using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200089B")]
	public static class TextUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600362C")]
		[Cpp2IlInjected.Address(RVA = "0x17EDB30", Offset = "0x17EC530", VA = "0x1817EDB30")]
		public static string GetLocalizedText(string key, [Optional] IResolver resolver)
		{
			return LocalizationManager.FromStringID(key, resolver);
		}

		[Cpp2IlInjected.Token(Token = "0x600362D")]
		[Cpp2IlInjected.Address(RVA = "0x17ED460", Offset = "0x17EBE60", VA = "0x1817ED460")]
		public static string FormatNumber(double number, int maxDigits = 4, int maxDecimals = 2, int childMaxDecimals = 1, bool roundDown = true)
		{
			int num = 0;
			if (maxDigits > 0)
			{
				uint divider = default(uint);
				string text = FormatWithAbbreviation((int)divider, "menu.currency_abbr_thousand");
				uint divider2 = default(uint);
				string text2 = FormatWithAbbreviation((int)divider2, "menu.currency_abbr_million");
				uint divider3 = default(uint);
				string text3 = FormatWithAbbreviation((int)divider3, "menu.currency_abbr_billion");
			}
			string text4 = "";
			if (maxDecimals > 0)
			{
				text4 = ".";
			}
			if (maxDecimals > 0)
			{
				string text5 = text4 + "#";
				while (maxDecimals != 0)
				{
				}
			}
			string text6 = "{0:#,0" + text4 + "}";
			return string.Format(text6, text6);
			[Cpp2IlInjected.Token(Token = "0x6003630")]
			[Cpp2IlInjected.Address(RVA = "0x17EDB40", Offset = "0x17EC540", VA = "0x1817EDB40")]
			string FormatWithAbbreviation(int _divider, string _strID)
			{
				//IL_001f: Expected O, but got I4
				//Could not transform parameter 2: unsupported argument pattern
				//Could not transform parameter 2: unsupported argument pattern
				//Could not transform parameter 2: unsupported argument pattern
				int childMaxDecimals2 = cpp2il__autoParamName__idx_2.childMaxDecimals;
				if (!cpp2il__autoParamName__idx_2.roundDown || childMaxDecimals2 > 0)
				{
				}
				int num2 = 0;
				string text7 = LocalizationManager.FromStringID(_strID, (IResolver)num2);
				string text8 = default(string);
				return text8 + text7;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600362E")]
		[Cpp2IlInjected.Address(RVA = "0x17ED1E0", Offset = "0x17EBBE0", VA = "0x1817ED1E0")]
		public static string FormatAbbrTime(float milliseconds, bool roundToNextSecond = true)
		{
			//Discarded unreachable code: IL_00a0
			//IL_0014: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			//IL_007a: Expected O, but got I4
			string[] array;
			string text4;
			while (true)
			{
				array = new string[4];
				int num = 0;
				string text = LocalizationManager.FromStringID("menu.common_time_label_day_abbr", (IResolver)num);
				if (text != null && text == null)
				{
					continue;
				}
				array[0] = text;
				int num2 = 0;
				string text2 = LocalizationManager.FromStringID("menu.common_time_label_hour_abbr", (IResolver)num2);
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[1] = text2;
				int num3 = 0;
				string text3 = LocalizationManager.FromStringID("menu.common_time_label_minute_abbr", (IResolver)num3);
				if (text3 == null || text3 != null)
				{
					array[2] = text3;
					int num4 = 0;
					text4 = LocalizationManager.FromStringID("menu.common_time_label_second_abbr", (IResolver)num4);
					if (text4 == null || text4 != null)
					{
						break;
					}
				}
			}
			array[3] = text4;
			return FormatTime(milliseconds, array, roundToNextSecond);
		}

		[Cpp2IlInjected.Token(Token = "0x600362F")]
		[Cpp2IlInjected.Address(RVA = "0x17ED630", Offset = "0x17EC030", VA = "0x1817ED630")]
		public static string FormatTime(float milliseconds, string[] dateFormat, bool roundToNextSecond = true, string formatStr = "")
		{
			//Discarded unreachable code: IL_0128
			//IL_0083: Invalid comparison between F4 and I4
			//IL_00fa: Expected O, but got I4
			//IL_010b: Expected O, but got I4
			int num = 0;
			float num2 = milliseconds * 0.001f;
			float[] array = new float[4];
			float f = milliseconds * 1.1574074E-08f;
			int num3 = Mathf.FloorToInt(f);
			f = milliseconds;
			float num4 = f * 2.777778E-07f;
			int num5 = Mathf.FloorToInt(num4);
			int num6 = Mathf.FloorToInt(num4);
			int length = array.Length;
			array[1] = num4;
			if (!roundToNextSecond)
			{
			}
			num4 = num2;
			int num7 = Mathf.FloorToInt(num4);
			int length2 = array.Length;
			array[1] = num2;
			int num8 = 0;
			float num9 = array[num8];
			if (!(num9 > (float)num))
			{
				num8++;
			}
			if (num8 != -1 && num8 < dateFormat.Length)
			{
				if (!roundToNextSecond && num8 == 3 && !(num2 >= 1f))
				{
					string text = default(string);
					string text2 = default(string);
					string text3 = "" + text + text2;
					if (1 >= dateFormat.Length)
					{
						goto IL_011b;
					}
					if (roundToNextSecond || 1L != 3L)
					{
						goto IL_00fc;
					}
					num8++;
				}
				if (!(num9 >= 1f))
				{
					string text4 = dateFormat[num8];
					string text5 = default(string);
					string text6 = (string)num8 + " " + text5 + text4;
				}
			}
			goto IL_00fc;
			IL_00fc:
			int num10 = 0;
			string text7 = LocalizationManager.FromStringID("menu.common_time_label_second_abbr", (IResolver)num10);
			string text8 = "0" + text7;
			goto IL_011b;
			IL_011b:
			return "-" + text8;
		}
	}
}
