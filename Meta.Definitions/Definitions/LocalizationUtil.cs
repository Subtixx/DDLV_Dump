using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Localization.Core;
using glPlayFab;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	public static class LocalizationUtil
	{
		[Cpp2IlInjected.Token(Token = "0x2000137")]
		public class LocaleInfo
		{
			[Cpp2IlInjected.Token(Token = "0x1700030D")]
			public string Culture
			{
				[Cpp2IlInjected.Token(Token = "0x6000C6F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CCulture_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C70")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CCulture_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700030E")]
			public string ISOCode
			{
				[Cpp2IlInjected.Token(Token = "0x6000C71")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CISOCode_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C72")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CISOCode_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700030F")]
			public string NintendoLanguageName
			{
				[Cpp2IlInjected.Token(Token = "0x6000C73")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CNintendoLanguageName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C74")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CNintendoLanguageName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LocaleInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public const string DefaultLocale = "en-US";

		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private static Dictionary<Locale, LocaleInfo> localesMapping;

		[Cpp2IlInjected.Token(Token = "0x1700030A")]
		public static string CurrentLanguage
		{
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0x27516A0", Offset = "0x27500A0", VA = "0x1827516A0")]
			get
			{
				return PlayFabSysHttp.DefaultAcceptLanguage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030B")]
		public static Localizator Localizator
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x2751810", Offset = "0x2750210", VA = "0x182751810")]
			[CompilerGenerated]
			get
			{
				return _003CLocalizator_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0x2751870", Offset = "0x2750270", VA = "0x182751870")]
			[CompilerGenerated]
			set
			{
				localesMapping = (Dictionary<Locale, LocaleInfo>)(object)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030C")]
		public static List<LocaleInfo> Locales
		{
			[Cpp2IlInjected.Token(Token = "0x6000C6A")]
			[Cpp2IlInjected.Address(RVA = "0x2751760", Offset = "0x2750160", VA = "0x182751760")]
			get
			{
				//Discarded unreachable code: IL_0015
				return (List<LocaleInfo>)(object)Enumerable.ToList<LocaleInfo>(Enumerable.Distinct<LocaleInfo>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)localesMapping).get_Values()));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2750850", Offset = "0x274F250", VA = "0x182750850")]
		public static string GetCulture(Locale locale)
		{
			//Discarded unreachable code: IL_0010
			Dictionary<Locale, LocaleInfo> dictionary = localesMapping;
			bool flag = default(bool);
			if (flag)
			{
			}
			return "en-US";
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2750910", Offset = "0x274F310", VA = "0x182750910")]
		public static string GetISOCode(Locale locale)
		{
			//Discarded unreachable code: IL_0010
			Dictionary<Locale, LocaleInfo> dictionary = localesMapping;
			bool flag = default(bool);
			if (flag)
			{
			}
			return "en-US";
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2751060", Offset = "0x274FA60", VA = "0x182751060")]
		public static string GetNintendoLanguageNameFromGameCulture(string culture)
		{
			Dictionary<Locale, LocaleInfo>.ValueCollection values = (Dictionary<Locale, LocaleInfo>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)localesMapping).get_Values();
			Func<LocaleInfo, bool> func = (Func<LocaleInfo, bool>)(object)(Func<T, TResult>)delegate(LocaleInfo x)
			{
				//Discarded unreachable code: IL_0014
				string b = culture;
				return string.Equals(x.Culture, b);
			};
			LocaleInfo localeInfo = Enumerable.FirstOrDefault<LocaleInfo>((IEnumerable<>)(object)values, (Func<, >)(object)func);
			if (localeInfo != null)
			{
				return localeInfo.NintendoLanguageName;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2750300", Offset = "0x274ED00", VA = "0x182750300")]
		public static string GetBestCultureMatch(string culture)
		{
			//Discarded unreachable code: IL_00bb, IL_00c1, IL_00c7, IL_00cd, IL_00d3, IL_00d9, IL_00df, IL_00e5, IL_00eb, IL_00f1, IL_00f7, IL_00fd
			bool flag3 = default(bool);
			string text = default(string);
			string text2 = default(string);
			string[] array = default(string[]);
			string[] array2 = default(string[]);
			bool flag4 = default(bool);
			string text3 = default(string);
			while (true)
			{
				int num = 0;
				if (string.IsNullOrEmpty(culture))
				{
					break;
				}
				bool flag = string.Equals(culture.ToLower(), "zh-hans");
				bool flag2 = string.Equals("zh-cn", "zh-hant");
				Dictionary<Locale, LocaleInfo> dictionary = localesMapping;
				if (flag3)
				{
					if (text == null && text2 == null)
					{
						(new char[1])[0] = '-';
						if (Enumerable.First<string>((IEnumerable<>)(object)array).ToLower() == null)
						{
							(new char[1])[0] = '-';
							if (Enumerable.First<string>((IEnumerable<>)(object)array2).ToLower() == null)
							{
								continue;
							}
						}
						num++;
					}
					num++;
				}
				if (num + 1 != 0)
				{
				}
				if (flag4)
				{
					char[] separator = new char[1];
					string bestCultureMatch = GetBestCultureMatch(Enumerable.First<string>((IEnumerable<>)(object)text3.Split(separator)));
				}
				break;
			}
			return "en-US";
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x2750FE0", Offset = "0x274F9E0", VA = "0x182750FE0")]
		public static void GetLocalizationFromTitleId(string titleLocId, Dictionary<string, string> outTitles, string neutralKey = "neutral")
		{
			//IL_000e: Expected O, but got I4
			//IL_000e: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			LocalizationUtil.GetLocalizationFromIds(titleLocId, (string)num2, (Dictionary<, >)(object)outTitles, (Dictionary<, >)num, neutralKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x27509D0", Offset = "0x274F3D0", VA = "0x1827509D0")]
		public static void GetLocalizationFromIds(string titleLocId, string descLocId, Dictionary<string, string> outTitles, Dictionary<string, string> outDescriptions, string neutralKey = "neutral")
		{
			//Discarded unreachable code: IL_009e, IL_00a2, IL_00ae, IL_00b2, IL_00b8, IL_00b9, IL_00bf, IL_00c5, IL_00cb, IL_00d1, IL_00d7, IL_00dd
			//IL_004d: Expected O, but got I4
			//IL_005d: Expected I4, but got I8
			//IL_005d: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			int num = 0;
			bool flag = "Localization/" == null;
			Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			List<LocaleInfo> list = (List<LocaleInfo>)(object)Enumerable.ToList<LocaleInfo>(Enumerable.Distinct<LocaleInfo>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)localesMapping).get_Values()));
			bool flag2 = default(bool);
			if (flag2)
			{
				CultureInfo cultureInfo = default(CultureInfo);
				bool bypassTimestampCheck = cultureInfo.Name == null;
				string path = default(string);
				int num3 = default(int);
				FluxTableProvider provider = new FluxTableProvider(path, (Gameloft.Localization.Core.IFileSystem)num3);
				num3 = 0;
				ulong num5 = default(ulong);
				int num4 = default(int);
				TableOptions options = new TableOptions((string)num4, bypassTimestampCheck, (byte)num5 != 0);
				num4 = 0;
				FluxReviewedTableProvider fluxReviewedTableProvider = new FluxReviewedTableProvider(provider, options);
				CultureInfo cultureInfo2 = (fluxReviewedTableProvider.ReferenceCulture = CultureInfo.GetCultureInfo("en-US"));
				int num6 = default(int);
				Localizator localizator = new Localizator(cultureInfo.Name, (ITableProvider)fluxReviewedTableProvider, (Func<, >)num6, (Func<, , >)num);
				num6 = 0;
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x27511C0", Offset = "0x274FBC0", VA = "0x1827511C0")]
		static LocalizationUtil()
		{
			//Discarded unreachable code: IL_0033, IL_0060, IL_008d, IL_00be, IL_00ef, IL_0120, IL_0151, IL_0182
			Dictionary<Locale, LocaleInfo> dictionary = (Dictionary<Locale, LocaleInfo>)(object)new Dictionary<TKey, TValue>();
			LocaleInfo localeInfo = new LocaleInfo
			{
				Culture = "en-US",
				ISOCode = "en-US",
				NintendoLanguageName = "en-US"
			};
			throw new NullReferenceException();
		}
	}
}
