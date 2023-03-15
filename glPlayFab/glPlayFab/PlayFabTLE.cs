using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public class PlayFabTLE
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public const string NamePrefix = "tle";

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x14F00D0", Offset = "0x14EEAD0", VA = "0x1814F00D0")]
		public static string BuildUgcName(string name)
		{
			//IL_0011: Expected O, but got I4
			SearchType searchType = default(SearchType);
			return string.Format("{0}_{1}_{2}", "tle", searchType, name);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x14EFE10", Offset = "0x14EE810", VA = "0x1814EFE10")]
		public static string BuildCurrencyName(string name)
		{
			//IL_0011: Expected O, but got I4
			SearchType searchType = default(SearchType);
			return string.Format("{0}_{1}_{2}", "tle", searchType, name);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x14EFD90", Offset = "0x14EE790", VA = "0x1814EFD90")]
		public static string BuildBundleName(string name)
		{
			//IL_0011: Expected O, but got I4
			SearchType searchType = default(SearchType);
			return string.Format("{0}_{1}_{2}", "tle", searchType, name);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x14EFE90", Offset = "0x14EE890", VA = "0x1814EFE90")]
		public static string BuildEventName(string name, string version)
		{
			return BuildStoreName(name, version);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x14EFEA0", Offset = "0x14EE8A0", VA = "0x1814EFEA0")]
		public static string BuildStoreName(string name, string version)
		{
			//Discarded unreachable code: IL_005f
			//IL_0033: Expected O, but got I4
			object[] array;
			SearchType searchType = default(SearchType);
			while (true)
			{
				array = new object[4];
				if ("tle" != null && "tle" == null)
				{
					continue;
				}
				array[0] = "tle";
				if (searchType != 0 && searchType == SearchType.ugc)
				{
					continue;
				}
				array[1] = searchType;
				if (name == null || searchType != 0)
				{
					array[2] = name;
					if (version == null || searchType != 0)
					{
						break;
					}
				}
			}
			array[3] = version;
			return string.Format("{0}_{1}_{2}_{3}", array);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PlayFabTLE()
		{
		}
	}
}
