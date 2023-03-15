using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Rewards;

namespace Meta.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x2001098")]
	public class GachaResults
	{
		[Cpp2IlInjected.Token(Token = "0x2001099")]
		public class PullResults
		{
			[Cpp2IlInjected.Token(Token = "0x200109A")]
			public class RollResults
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4004481")]
				internal TreeGacha.GachaGeneratorData Generator;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4004482")]
				public IReward Reward;

				[Cpp2IlInjected.Token(Token = "0x60086D0")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public RollResults()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4004480")]
			public List<RollResults> Rolls = (List<RollResults>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x60086CF")]
			[Cpp2IlInjected.Address(RVA = "0x99BEF0", Offset = "0x99A8F0", VA = "0x18099BEF0")]
			public PullResults()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400447E")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400447F")]
		public List<PullResults> Pulls = (List<PullResults>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60086CD")]
		[Cpp2IlInjected.Address(RVA = "0x180CFC0", Offset = "0x180B9C0", VA = "0x18180CFC0")]
		public void Debug()
		{
			//Discarded unreachable code: IL_0027, IL_002c, IL_0032, IL_003e, IL_0044, IL_004a, IL_0050, IL_0056, IL_005c, IL_0062, IL_0068
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Dictionary<string, int> dictionary = (Dictionary<string, int>)(object)new Dictionary<TKey, TValue>();
			List<PullResults> pulls = Pulls;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				int num4 = 0;
				throw new NullReferenceException();
			}
			bool flag3 = default(bool);
			while (flag3)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60086CE")]
		[Cpp2IlInjected.Address(RVA = "0x180D450", Offset = "0x180BE50", VA = "0x18180D450")]
		public GachaResults()
		{
		}
	}
}
