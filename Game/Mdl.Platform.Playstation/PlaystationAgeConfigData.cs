using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Platform.Playstation
{
	[Cpp2IlInjected.Token(Token = "0x2000308")]
	[CreateAssetMenu]
	public class PlaystationAgeConfigData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001643")]
		public string[] CountryCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001644")]
		public int[] AgeRestriction;

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0xCAFFB0", Offset = "0xCAE9B0", VA = "0x180CAFFB0")]
		public PlaystationAgeConfigData()
		{
			while (true)
			{
				string[] array = new string[69];
				if ("DE" != null && "DE" == null)
				{
					continue;
				}
				array[0] = "DE";
				if ("HK" != null && "HK" == null)
				{
					continue;
				}
				array[1] = "HK";
				if ("TW" != null && "TW" == null)
				{
					continue;
				}
				array[2] = "TW";
				if ("PT" != null && "PT" == null)
				{
					continue;
				}
				array[3] = "PT";
				if ("HN" != null && "HN" == null)
				{
					continue;
				}
				array[4] = "HN";
				if ("DK" != null && "DK" == null)
				{
					continue;
				}
				array[5] = "DK";
				if ("LU" != null && "LU" == null)
				{
					continue;
				}
				array[6] = "LU";
				if ("PY" != null && "PY" == null)
				{
					continue;
				}
				array[7] = "PY";
				if ("HR" != null && "HR" == null)
				{
					continue;
				}
				array[8] = "HR";
				if ("UA" != null && "UA" == null)
				{
					continue;
				}
				array[9] = "UA";
				if ("HU" != null && "HU" == null)
				{
					continue;
				}
				array[10] = "HU";
				if ("QA" != null && "QA" == null)
				{
					continue;
				}
				array[11] = "QA";
				if ("ID" != null && "ID" == null)
				{
					continue;
				}
				array[12] = "ID";
				if ("IE" != null && "IE" == null)
				{
					continue;
				}
				array[13] = "IE";
				if ("EC" != null && "EC" == null)
				{
					continue;
				}
				array[14] = "EC";
				if ("US" != null && "US" == null)
				{
					continue;
				}
				array[15] = "US";
				if ("IL" != null && "IL" == null)
				{
					continue;
				}
				array[16] = "IL";
				if ("AE" != null && "AE" == null)
				{
					continue;
				}
				array[17] = "AE";
				if ("UY" != null && "UY" == null)
				{
					continue;
				}
				array[18] = "UY";
				if ("IN" != null && "IN" == null)
				{
					continue;
				}
				array[19] = "IN";
				if ("MT" != null && "MT" == null)
				{
					continue;
				}
				array[20] = "MT";
				if ("ZA" != null && "ZA" == null)
				{
					continue;
				}
				array[21] = "ZA";
				if ("IS" != null && "IS" == null)
				{
					continue;
				}
				array[22] = "IS";
				if ("IT" != null && "IT" == null)
				{
					continue;
				}
				array[23] = "IT";
				if ("MX" != null && "MX" == null)
				{
					continue;
				}
				array[24] = "MX";
				if ("MY" != null && "MY" == null)
				{
					continue;
				}
				array[25] = "MY";
				if ("ES" != null && "ES" == null)
				{
					continue;
				}
				array[26] = "ES";
				if ("AR" != null && "AR" == null)
				{
					continue;
				}
				array[27] = "AR";
				if ("AT" != null && "AT" == null)
				{
					continue;
				}
				array[28] = "AT";
				if ("AU" != null && "AU" == null)
				{
					continue;
				}
				array[29] = "AU";
				if ("NI" != null && "NI" == null)
				{
					continue;
				}
				array[30] = "NI";
				if ("RO" != null && "RO" == null)
				{
					continue;
				}
				array[31] = "RO";
				if ("NL" != null && "NL" == null)
				{
					continue;
				}
				array[32] = "NL";
				if ("NO" != null && "NO" == null)
				{
					continue;
				}
				array[33] = "NO";
				if ("BE" != null && "BE" == null)
				{
					continue;
				}
				array[34] = "BE";
				if ("FI" != null && "FI" == null)
				{
					continue;
				}
				array[35] = "FI";
				if ("RU" != null && "RU" == null)
				{
					continue;
				}
				array[36] = "RU";
				if ("BG" != null && "BG" == null)
				{
					continue;
				}
				array[37] = "BG";
				if ("BH" != null && "BH" == null)
				{
					continue;
				}
				array[38] = "BH";
				if ("JP" != null && "JP" == null)
				{
					continue;
				}
				array[39] = "JP";
				if ("FR" != null && "FR" == null)
				{
					continue;
				}
				array[40] = "FR";
				if ("NZ" != null && "NZ" == null)
				{
					continue;
				}
				array[41] = "NZ";
				if ("BO" != null && "BO" == null)
				{
					continue;
				}
				array[42] = "BO";
				if ("SA" != null && "SA" == null)
				{
					continue;
				}
				array[43] = "SA";
				if ("BR" != null && "BR" == null)
				{
					continue;
				}
				array[44] = "BR";
				if ("SE" != null && "SE" == null)
				{
					continue;
				}
				array[45] = "SE";
				if ("SG" != null && "SG" == null)
				{
					continue;
				}
				array[46] = "SG";
				if ("SI" != null && "SI" == null)
				{
					continue;
				}
				array[47] = "SI";
				if ("SK" != null && "SK" == null)
				{
					continue;
				}
				array[48] = "SK";
				if ("GB" != null && "GB" == null)
				{
					continue;
				}
				array[49] = "GB";
				if ("CA" != null && "CA" == null)
				{
					continue;
				}
				array[50] = "CA";
				if ("OM" != null && "OM" == null)
				{
					continue;
				}
				array[51] = "OM";
				if ("SV" != null && "SV" == null)
				{
					continue;
				}
				array[52] = "SV";
				if ("CH" != null && "CH" == null)
				{
					continue;
				}
				array[53] = "CH";
				if ("KR" != null && "KR" == null)
				{
					continue;
				}
				array[54] = "KR";
				if ("CL" != null && "CL" == null)
				{
					continue;
				}
				array[55] = "CL";
				if ("GR" == null || "GR" != null)
				{
					array[56] = "GR";
					if ("CO" != null && "CO" != null)
					{
						/*Error: Could not find block for branch target IL_0729*/;
					}
				}
			}
		}
	}
}
