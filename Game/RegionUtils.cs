using System;
using System.Text;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class RegionUtils
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private enum GeoClass
	{
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		Nation = 16,
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		Region = 14
	}

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly string[] COUNTRY_CODE_FRIENDLY_STREAMING;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly string[] COUNTRY_NAME_FRIENDLY_STREAMING;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private const int GEO_FRIENDLYNAME = 8;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xCBD220", Offset = "0xCBBC20", VA = "0x180CBD220")]
	private static extern int GetUserGeoID(GeoClass geoClass);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xCBD1B0", Offset = "0xCBBBB0", VA = "0x180CBD1B0")]
	private static extern int GetUserDefaultLCID();

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xCBD0D0", Offset = "0xCBBAD0", VA = "0x180CBD0D0")]
	private static extern int GetGeoInfo(int geoid, int geoType, StringBuilder lpGeoData, int cchData, int langid);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0xCBCEA0", Offset = "0xCBB8A0", VA = "0x180CBCEA0")]
	public static string GetCurrentCountry()
	{
		//Discarded unreachable code: IL_001b
		StringBuilder stringBuilder = new StringBuilder(100);
		int capacity = stringBuilder.Capacity;
		return stringBuilder.ToString().Trim();
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
	public RegionUtils()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xCBD2A0", Offset = "0xCBBCA0", VA = "0x180CBD2A0")]
	static RegionUtils()
	{
		string[] array2;
		while (true)
		{
			string[] array = new string[1];
			if ("JP" == null || "JP" != null)
			{
				array[0] = "JP";
				COUNTRY_CODE_FRIENDLY_STREAMING = array;
				array2 = new string[1];
				if ("Japan" == null || array2 != null)
				{
					break;
				}
			}
		}
		array2[0] = "Japan";
		COUNTRY_CODE_FRIENDLY_STREAMING = array2;
		throw new NullReferenceException();
	}
}
