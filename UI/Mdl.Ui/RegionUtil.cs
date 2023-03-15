using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000880")]
	public static class RegionUtil
	{
		[Cpp2IlInjected.Token(Token = "0x400325B")]
		public static HashSet<string> americanCodes;

		[Cpp2IlInjected.Token(Token = "0x60035AF")]
		[Cpp2IlInjected.Address(RVA = "0xE2F190", Offset = "0xE2DB90", VA = "0x180E2F190")]
		public static bool IsRegionAmerica()
		{
			//Discarded unreachable code: IL_0015
			int num = 0;
			string twoLetterISORegionName = RegionInfo.CurrentRegion.TwoLetterISORegionName;
			bool flag = default(bool);
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x60035B0")]
		[Cpp2IlInjected.Address(RVA = "0xE2F240", Offset = "0xE2DC40", VA = "0x180E2F240")]
		public static bool IsRegionEurope()
		{
			//Discarded unreachable code: IL_0012
			int num = 0;
			string twoLetterISORegionName = RegionInfo.CurrentRegion.TwoLetterISORegionName;
			bool flag = default(bool);
			return !flag;
		}

		[Cpp2IlInjected.Token(Token = "0x60035B1")]
		[Cpp2IlInjected.Address(RVA = "0xE2F2F0", Offset = "0xE2DCF0", VA = "0x180E2F2F0")]
		static RegionUtil()
		{
			HashSet<string> hashSet = (HashSet<string>)(object)new HashSet<T>();
			bool flag = ((HashSet<T>)(object)hashSet).Add((T)"AR");
			bool flag2 = ((HashSet<T>)(object)hashSet).Add((T)"BZ");
			bool flag3 = ((HashSet<T>)(object)hashSet).Add((T)"BR");
			bool flag4 = ((HashSet<T>)(object)hashSet).Add((T)"CA");
			bool flag5 = ((HashSet<T>)(object)hashSet).Add((T)"CL");
			bool flag6 = ((HashSet<T>)(object)hashSet).Add((T)"CO");
			bool flag7 = ((HashSet<T>)(object)hashSet).Add((T)"CR");
			bool flag8 = ((HashSet<T>)(object)hashSet).Add((T)"DO");
			bool flag9 = ((HashSet<T>)(object)hashSet).Add((T)"EC");
			bool flag10 = ((HashSet<T>)(object)hashSet).Add((T)"SV");
			bool flag11 = ((HashSet<T>)(object)hashSet).Add((T)"GT");
			bool flag12 = ((HashSet<T>)(object)hashSet).Add((T)"HN");
			bool flag13 = ((HashSet<T>)(object)hashSet).Add((T)"JM");
			bool flag14 = ((HashSet<T>)(object)hashSet).Add((T)"MX");
			bool flag15 = ((HashSet<T>)(object)hashSet).Add((T)"NI");
			bool flag16 = ((HashSet<T>)(object)hashSet).Add((T)"PA");
			bool flag17 = ((HashSet<T>)(object)hashSet).Add((T)"PY");
			bool flag18 = ((HashSet<T>)(object)hashSet).Add((T)"PE");
			bool flag19 = ((HashSet<T>)(object)hashSet).Add((T)"PR");
			bool flag20 = ((HashSet<T>)(object)hashSet).Add((T)"TT");
			bool flag21 = ((HashSet<T>)(object)hashSet).Add((T)"US");
			bool flag22 = ((HashSet<T>)(object)hashSet).Add((T)"UY");
			bool flag23 = ((HashSet<T>)(object)hashSet).Add((T)"VE");
			throw new NullReferenceException();
		}
	}
}
