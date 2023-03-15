using System;
using System.Globalization;
using Cpp2IlInjected;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x200032B")]
	public class NativeShopUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000DB7")]
		[Cpp2IlInjected.Address(RVA = "0xF018E0", Offset = "0xF002E0", VA = "0x180F018E0")]
		public static bool IsCultureInfoUsingThisCurrencyCode(CultureInfo cultureInfo, string currencyCode)
		{
			if (cultureInfo != null && (object)typeof(RegionInfo).TypeHandle == null)
			{
				return new RegionInfo(cultureInfo.LCID).ISOCurrencySymbol.Equals(currencyCode);
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB8")]
		[Cpp2IlInjected.Address(RVA = "0xF017B0", Offset = "0xF001B0", VA = "0x180F017B0")]
		public static CultureInfo FindCultureInfoWithCurrencyCode(string currencyCode)
		{
			if (!string.IsNullOrEmpty(currencyCode))
			{
				int num = 0;
				if (!IsCultureInfoUsingThisCurrencyCode(CultureInfo.CurrentCulture, currencyCode))
				{
					CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
					int num2 = 0;
					int length = cultures.Length;
					if (num2 >= length)
					{
						goto IL_004b;
					}
					if (!IsCultureInfoUsingThisCurrencyCode(cultures[num2], currencyCode))
					{
						num2++;
					}
				}
				int num3 = 0;
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
			}
			goto IL_004b;
			IL_004b:
			int num4 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB9")]
		[Cpp2IlInjected.Address(RVA = "0xF019B0", Offset = "0xF003B0", VA = "0x180F019B0")]
		public static string ToFormattedPrice(double price, CultureInfo culture)
		{
			//Discarded unreachable code: IL_0015
			if (culture == null)
			{
				int num = 0;
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
			}
			NumberFormatInfo numberFormat = culture.NumberFormat;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public NativeShopUtils()
		{
		}
	}
}
