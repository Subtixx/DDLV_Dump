using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Meta.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x20010A3")]
	internal class Pull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004497")]
		public TreeGacha Tree;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004498")]
		public int Pulls;

		[Cpp2IlInjected.Token(Token = "0x60086E6")]
		[Cpp2IlInjected.Address(RVA = "0x148B1B0", Offset = "0x1489BB0", VA = "0x18148B1B0")]
		public GachaResults.PullResults Roll(Random random, in Player player, in World world, [Optional] int? debugPull)
		{
			//Discarded unreachable code: IL_003e
			GachaResults.PullResults pullResults = new GachaResults.PullResults();
			int pulls = Pulls;
			int num = 0;
			if (pulls > 0)
			{
				TreeGacha tree = Tree;
				List<GachaResults.PullResults.RollResults> rolls = pullResults.Rolls;
				GachaResults.PullResults.RollResults item = tree.Roll(random, in player, in world);
				((List<T>)(object)rolls).Add((T)item);
				num++;
			}
			return pullResults;
		}

		[Cpp2IlInjected.Token(Token = "0x60086E7")]
		[Cpp2IlInjected.Address(RVA = "0x148B030", Offset = "0x1489A30", VA = "0x18148B030")]
		public GachaInfo.PullInfo GetGachaInfo()
		{
			//Discarded unreachable code: IL_0034, IL_003a, IL_0040
			GachaInfo.PullInfo pullInfo = new GachaInfo.PullInfo();
			int num = (pullInfo.Pulls = Pulls);
			List<TreeGacha.GachaGeneratorData> generators = Tree.Generators;
			bool flag = default(bool);
			if (flag)
			{
				GachaInfo.PullInfo.TableInfo item = default(GachaInfo.PullInfo.TableInfo);
				((List<T>)(object)pullInfo.TableInfos).Add((T)item);
			}
			return pullInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x60086E8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Pull()
		{
		}
	}
}
