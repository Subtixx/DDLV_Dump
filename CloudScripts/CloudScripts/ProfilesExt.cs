using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlayFab.LeaderboardsModels;
using PlayFab.ProfilesModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	public static class ProfilesExt
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x11708E0", Offset = "0x116F2E0", VA = "0x1811708E0")]
		public static int GetValue(this PlayFab.LeaderboardsModels.EntityStatisticValue self, int defaultValue = 0)
		{
			if ((object)self.Value == null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x1170940", Offset = "0x116F340", VA = "0x181170940")]
		public static int GetValue(this PlayFab.ProfilesModels.EntityStatisticValue self, int defaultValue = 0)
		{
			if ((object)self.Value == null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x1170820", Offset = "0x116F220", VA = "0x181170820")]
		public static int GetStatistic(this EntityProfileBody self, string name, int defaultValue = 0)
		{
			//Discarded unreachable code: IL_000d
			Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue> statistics = self.Statistics;
			bool flag = default(bool);
			if (flag)
			{
			}
			return defaultValue;
		}
	}
}
