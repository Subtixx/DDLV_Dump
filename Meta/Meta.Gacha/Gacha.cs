using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Meta.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x20010A4")]
	internal class Gacha
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004499")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400449A")]
		public List<Pull> Pulls;

		[Cpp2IlInjected.Token(Token = "0x60086E9")]
		[Cpp2IlInjected.Address(RVA = "0x180D690", Offset = "0x180C090", VA = "0x18180D690")]
		public GachaResults Roll(Random random, in Player player, in World world, [Optional] int? debugPull)
		{
			//Discarded unreachable code: IL_0030, IL_0036, IL_003c, IL_0042
			int num = 0;
			GachaResults gachaResults = new GachaResults();
			List<GachaResults.PullResults> list = (gachaResults.Pulls = (List<GachaResults.PullResults>)(object)new List<T>());
			List<Pull> pulls = Pulls;
			bool flag = default(bool);
			if (flag)
			{
				GachaResults.PullResults item = default(GachaResults.PullResults);
				((List<T>)(object)gachaResults.Pulls).Add((T)item);
			}
			return gachaResults;
		}

		[Cpp2IlInjected.Token(Token = "0x60086EA")]
		[Cpp2IlInjected.Address(RVA = "0x180D4D0", Offset = "0x180BED0", VA = "0x18180D4D0")]
		public GachaInfo GetGachaInfo()
		{
			//Discarded unreachable code: IL_0030, IL_0036, IL_003c, IL_0042
			int num = 0;
			GachaInfo gachaInfo = new GachaInfo();
			List<GachaInfo.PullInfo> list = (gachaInfo.Pulls = (List<GachaInfo.PullInfo>)(object)new List<T>());
			List<Pull> pulls = Pulls;
			bool flag = default(bool);
			if (flag)
			{
				GachaInfo.PullInfo item = default(GachaInfo.PullInfo);
				((List<T>)(object)gachaInfo.Pulls).Add((T)item);
			}
			return gachaInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x60086EB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Gacha()
		{
		}
	}
}
