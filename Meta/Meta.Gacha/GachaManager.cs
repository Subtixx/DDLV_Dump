using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Gacha;
using Definitions.Items;
using Definitions.Rewards;
using Google.Protobuf.Collections;

namespace Meta.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x20010A5")]
	public class GachaManager : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400449B")]
		private static GachaManager instance;

		[Cpp2IlInjected.Token(Token = "0x1700176F")]
		public static GachaManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60086EC")]
			[Cpp2IlInjected.Address(RVA = "0x180CF40", Offset = "0x180B940", VA = "0x18180CF40")]
			get
			{
				GachaManager gachaManager = new GachaManager();
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60086ED")]
		[Cpp2IlInjected.Address(RVA = "0x180C010", Offset = "0x180AA10", VA = "0x18180C010")]
		internal List<Definitions.Gacha.Gacha> GetGachaDatas()
		{
			//Discarded unreachable code: IL_002d, IL_0033, IL_0039, IL_003f
			int num = 0;
			List<Definitions.Gacha.Gacha> result = (List<Definitions.Gacha.Gacha>)(object)new List<T>();
			IEnumerable<> enumerable = ProtoDatabase.Instance.Enumerate<GachaDatabase>();
			uint num2 = default(uint);
			if (enumerable != null && num < (int)num2)
			{
				num += num;
				if (num != (int)num2)
				{
					num++;
				}
			}
			if (enumerable != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60086EE")]
		[Cpp2IlInjected.Address(RVA = "0x180BF20", Offset = "0x180A920", VA = "0x18180BF20")]
		internal Definitions.Gacha.Gacha GetGachaData(string id)
		{
			//Discarded unreachable code: IL_0029
			List<Definitions.Gacha.Gacha> gachaDatas = (List<Definitions.Gacha.Gacha>)(object)this.GetGachaDatas();
			Predicate<Definitions.Gacha.Gacha> predicate = (Predicate<Definitions.Gacha.Gacha>)(object)(Predicate<T>)delegate(Definitions.Gacha.Gacha x)
			{
				//Discarded unreachable code: IL_0014
				string b = id;
				return string.Equals(x.id_, b);
			};
			return (Definitions.Gacha.Gacha)((List<T>)(object)gachaDatas).Find((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60086EF")]
		[Cpp2IlInjected.Address(RVA = "0x180CB80", Offset = "0x180B580", VA = "0x18180CB80")]
		internal Gacha GetGacha(string id)
		{
			//Discarded unreachable code: IL_009a, IL_00a0, IL_00a6
			//IL_0077: Expected O, but got I4
			//IL_008b: Expected I4, but got O
			int num = 0;
			List<Definitions.Gacha.Gacha> gachaDatas = (List<Definitions.Gacha.Gacha>)(object)this.GetGachaDatas();
			Predicate<Definitions.Gacha.Gacha> predicate = (Predicate<Definitions.Gacha.Gacha>)(object)(Predicate<T>)delegate(Definitions.Gacha.Gacha x)
			{
				//Discarded unreachable code: IL_0014
				string b = id;
				return string.Equals(x.id_, b);
			};
			Definitions.Gacha.Gacha gacha = (Definitions.Gacha.Gacha)((List<T>)(object)gachaDatas).Find((Predicate<>)(object)predicate);
			if (gacha == null)
			{
			}
			Gacha gacha2 = default(Gacha);
			string text = (gacha2.Id = gacha.id_);
			List<Pull> list = (gacha2.Pulls = (List<Pull>)(object)new List<T>());
			RepeatedField<GachaPull> pulls_ = gacha.pulls_;
			bool flag = default(bool);
			if (flag)
			{
				List<Pull> pulls = gacha2.Pulls;
				Pull pull = new Pull();
				pull.Pulls = (int)(pull.Tree = new TreeGacha((RepeatedField<>)0));
				((List<T>)(object)pulls).Add((T)pull);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086F0")]
		[Cpp2IlInjected.Address(RVA = "0x180CEA0", Offset = "0x180B8A0", VA = "0x18180CEA0")]
		public GachaResults Roll(string id, Random random, in Player player, in World world, bool debug = false, [Optional] int? debugPull)
		{
			//Discarded unreachable code: IL_0019
			if (GetGacha(id) == null)
			{
			}
			GachaResults gachaResults = default(GachaResults);
			gachaResults.Id = id;
			gachaResults.Debug();
			return gachaResults;
		}

		[Cpp2IlInjected.Token(Token = "0x60086F1")]
		[Cpp2IlInjected.Address(RVA = "0x180C3E0", Offset = "0x180ADE0", VA = "0x18180C3E0")]
		public GachaInfo GetGachaInfo(string id)
		{
			Gacha gacha = GetGacha(id);
			if (gacha == null)
			{
			}
			return gacha.GetGachaInfo();
		}

		[Cpp2IlInjected.Token(Token = "0x60086F2")]
		[Cpp2IlInjected.Address(RVA = "0x180C290", Offset = "0x180AC90", VA = "0x18180C290")]
		public List<string> GetGachaIds()
		{
			List<Definitions.Gacha.Gacha> gachaDatas = (List<Definitions.Gacha.Gacha>)(object)this.GetGachaDatas();
			Func<Definitions.Gacha.Gacha, string> _003C_003E9__8_ = _003C_003Ec._003C_003E9__8_0;
			if (_003C_003E9__8_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Definitions.Gacha.Gacha x) => x.id_);
			}
			return (List<string>)(object)Enumerable.ToList<string>(Enumerable.Select<Definitions.Gacha.Gacha, string>((IEnumerable<>)gachaDatas, (Func<, >)(object)_003C_003E9__8_));
		}

		[Cpp2IlInjected.Token(Token = "0x60086F3")]
		[Cpp2IlInjected.Address(RVA = "0x180C410", Offset = "0x180AE10", VA = "0x18180C410")]
		public MultiReward GetGachaResults(string gachaId, in Player player, in World world)
		{
			//Discarded unreachable code: IL_0116, IL_011c, IL_0122, IL_0128, IL_012e, IL_013a
			//IL_00c3: Expected I4, but got O
			GachaResults gachaResults = default(GachaResults);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			IItemData itemData = default(IItemData);
			bool flag4 = default(bool);
			ItemReward itemReward = default(ItemReward);
			Func<IReward, IReward> func = default(Func<IReward, IReward>);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				List<Definitions.Gacha.Gacha> gachaDatas = (List<Definitions.Gacha.Gacha>)(object)this.GetGachaDatas();
				Func<Definitions.Gacha.Gacha, string> _003C_003E9__8_ = _003C_003Ec._003C_003E9__8_0;
				if (_003C_003E9__8_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Definitions.Gacha.Gacha x) => x.id_);
				}
				if (!((List<T>)(object)Enumerable.ToList<string>(Enumerable.Select<Definitions.Gacha.Gacha, string>((IEnumerable<>)gachaDatas, (Func<, >)(object)_003C_003E9__8_))).Contains((T)gachaId))
				{
					int num4 = 0;
				}
				List<IReward> list = (List<IReward>)(object)new List<T>();
				Random random = new Random(player.Section.GetRandomSeed("gacha_roll"));
				if (GetGacha(gachaId) == null)
				{
				}
				gachaResults.Id = gachaId;
				player.Section.AdvanceRandomSeed("gacha_roll");
				List<GachaResults.PullResults> pulls = gachaResults.Pulls;
				if (flag)
				{
					if (flag2)
					{
						if (flag3 && itemData != null && flag4)
						{
							itemReward = new ItemReward();
							int num5 = 0;
							Item dreamDustCurrencyItem = CurrencyItem.DreamDustCurrencyItem;
							itemReward.id_ = (int)dreamDustCurrencyItem;
							itemReward.amount_ = num3;
						}
						((List<T>)(object)list).Add((T)itemReward);
					}
					if (num3 != 0)
					{
						break;
					}
				}
				if (num3 != 0)
				{
					continue;
				}
				if (_003C_003Ec._003C_003E9__9_0 == null)
				{
					func = (Func<IReward, IReward>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IReward x) => x));
				}
				MultiReward multiReward = new MultiReward(Enumerable.Select<IReward, IReward>((IEnumerable<>)list, (Func<, >)(object)func));
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086F4")]
		[Cpp2IlInjected.Address(RVA = "0x180BED0", Offset = "0x180A8D0", VA = "0x18180BED0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60086F5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GachaManager()
		{
		}
	}
}
