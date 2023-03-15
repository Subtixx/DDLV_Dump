using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Gacha;
using Definitions.Rewards;
using Google.Protobuf.Collections;

namespace Meta.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x200109E")]
	internal class TreeGacha
	{
		[Cpp2IlInjected.Token(Token = "0x200109F")]
		public class GachaGeneratorData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400448A")]
			public double NormalizedWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400448B")]
			public double RollWeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400448C")]
			public List<AnyItemFilter> Filters;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400448D")]
			public List<AnyItemFilter> Exclusions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400448E")]
			public List<AnyItemFilter> LeftChildrenExclusions;

			[Cpp2IlInjected.Token(Token = "0x60086D7")]
			[Cpp2IlInjected.Address(RVA = "0x75C580", Offset = "0x75AF80", VA = "0x18075C580")]
			public IReward GenerateReward(Random random, in Player player, in World world)
			{
				//Discarded unreachable code: IL_00fa
				ExtraFilterInfo extraFilterInfo = new ExtraFilterInfo();
				List<IItemFilter> list = (extraFilterInfo.FilterList = (List<IItemFilter>)(object)new List<T>());
				List<IItemFilter> list2 = (extraFilterInfo.FilterOutList = (List<IItemFilter>)(object)new List<T>());
				List<IItemFilter> _003CFilterOutList_003Ek__BackingField = extraFilterInfo.FilterOutList;
				List<AnyItemFilter> leftChildrenExclusions = LeftChildrenExclusions;
				Func<AnyItemFilter, IItemFilter> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
				if (_003C_003E9__5_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AnyItemFilter x) => null);
				}
				IEnumerable<AnyItemFilter> enumerable = (IEnumerable<AnyItemFilter>)Enumerable.Select<AnyItemFilter, IItemFilter>((IEnumerable<>)leftChildrenExclusions, (Func<, >)(object)_003C_003E9__5_);
				((List<T>)(object)_003CFilterOutList_003Ek__BackingField).AddRange((IEnumerable<>)enumerable);
				List<IItemFilter> _003CFilterOutList_003Ek__BackingField2 = extraFilterInfo.FilterOutList;
				List<AnyItemFilter> exclusions = Exclusions;
				Func<AnyItemFilter, IItemFilter> func = default(Func<AnyItemFilter, IItemFilter>);
				if (_003C_003Ec._003C_003E9__5_1 == null)
				{
					func = (Func<AnyItemFilter, IItemFilter>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AnyItemFilter x) => null));
				}
				IEnumerable<AnyItemFilter> enumerable2 = (IEnumerable<AnyItemFilter>)Enumerable.Select<AnyItemFilter, IItemFilter>((IEnumerable<>)exclusions, (Func<, >)(object)func);
				((List<T>)(object)_003CFilterOutList_003Ek__BackingField2).AddRange((IEnumerable<>)enumerable2);
				List<IItemFilter> _003CFilterList_003Ek__BackingField = extraFilterInfo.FilterList;
				List<AnyItemFilter> filters = Filters;
				Func<AnyItemFilter, IItemFilter> func2 = default(Func<AnyItemFilter, IItemFilter>);
				if (_003C_003Ec._003C_003E9__5_2 == null)
				{
					func2 = (Func<AnyItemFilter, IItemFilter>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AnyItemFilter x) => null));
				}
				IEnumerable<AnyItemFilter> enumerable3 = (IEnumerable<AnyItemFilter>)Enumerable.Select<AnyItemFilter, IItemFilter>((IEnumerable<>)filters, (Func<, >)(object)func2);
				((List<T>)(object)_003CFilterList_003Ek__BackingField).AddRange((IEnumerable<>)enumerable3);
				ItemGenerator itemGenerator = new ItemGenerator();
				int num = 0;
				IReward result = default(IReward);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60086D8")]
			[Cpp2IlInjected.Address(RVA = "0x75CA40", Offset = "0x75B440", VA = "0x18075CA40")]
			public string GetDescription()
			{
				List<AnyItemFilter> filters = Filters;
				Func<AnyItemFilter, string> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
				if (_003C_003E9__6_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AnyItemFilter x) => null);
				}
				IEnumerable<AnyItemFilter> enumerable = (IEnumerable<AnyItemFilter>)Enumerable.Select<AnyItemFilter, string>((IEnumerable<>)filters, (Func<, >)(object)_003C_003E9__6_);
				return string.Join("|", (IEnumerable<>)enumerable);
			}

			[Cpp2IlInjected.Token(Token = "0x60086D9")]
			[Cpp2IlInjected.Address(RVA = "0x75CB90", Offset = "0x75B590", VA = "0x18075CB90")]
			public GachaInfo.PullInfo.TableInfo GetInfo()
			{
				//Discarded unreachable code: IL_005b
				GachaInfo.PullInfo.TableInfo tableInfo = new GachaInfo.PullInfo.TableInfo();
				List<AnyItemFilter> filters = Filters;
				Func<AnyItemFilter, string> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
				if (_003C_003E9__6_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AnyItemFilter x) => null);
				}
				IEnumerable<AnyItemFilter> enumerable = (IEnumerable<AnyItemFilter>)Enumerable.Select<AnyItemFilter, string>((IEnumerable<>)filters, (Func<, >)(object)_003C_003E9__6_);
				string text = (tableInfo.Description = string.Join("|", (IEnumerable<>)enumerable));
				double num = (tableInfo.Rate = NormalizedWeight);
				return tableInfo;
			}

			[Cpp2IlInjected.Token(Token = "0x60086DA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GachaGeneratorData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004488")]
		internal List<GachaGeneratorData> Generators;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004489")]
		internal RepeatedField<GachaTable> TableData;

		[Cpp2IlInjected.Token(Token = "0x60086D4")]
		[Cpp2IlInjected.Address(RVA = "0x15D1DA0", Offset = "0x15D07A0", VA = "0x1815D1DA0")]
		public TreeGacha(RepeatedField<GachaTable> tableData)
		{
			//Discarded unreachable code: IL_001b
			TableData = tableData;
			List<GachaGeneratorData> list = (Generators = (List<GachaGeneratorData>)(object)new List<T>());
		}

		[Cpp2IlInjected.Token(Token = "0x60086D5")]
		[Cpp2IlInjected.Address(RVA = "0x15D1BC0", Offset = "0x15D05C0", VA = "0x1815D1BC0")]
		public GachaResults.PullResults.RollResults Roll(Random random, in Player player, in World world)
		{
			//Discarded unreachable code: IL_005d
			GachaResults.PullResults.RollResults rollResults = new GachaResults.PullResults.RollResults();
			double num = random.NextDouble();
			List<GachaGeneratorData> generators = Generators;
			Predicate<GachaGeneratorData> predicate = (Predicate<GachaGeneratorData>)(object)(Predicate<T>)delegate
			{
				throw new NullReferenceException();
			};
			GachaGeneratorData gachaGeneratorData = (rollResults.Generator = (GachaGeneratorData)((List<T>)(object)generators).Find((Predicate<>)(object)predicate));
			GachaGeneratorData generator = rollResults.Generator;
			if (generator == null)
			{
				Exception ex = new Exception("Gacha did not generate a result");
				/*Error: Unexpected end of block*/;
			}
			IReward reward = (rollResults.Reward = generator.GenerateReward(random, in player, in world));
			return rollResults;
		}

		[Cpp2IlInjected.Token(Token = "0x60086D6")]
		[Cpp2IlInjected.Address(RVA = "0x15D1640", Offset = "0x15D0040", VA = "0x1815D1640")]
		internal double ParseTree(RepeatedField<GachaTable> tableData, [Optional] List<AnyItemFilter> filters, [Optional] List<AnyItemFilter> exclusions, double lastBranchNormalizedWeight = 1.0, double lastChildNormalizedWeight = 0.0)
		{
			//Discarded unreachable code: IL_00bc, IL_00c2, IL_00c8, IL_00ce, IL_00d4, IL_00da, IL_00e0, IL_00e6, IL_00ec, IL_00f2
			//IL_0050: Expected I4, but got O
			//IL_0061: Expected I4, but got O
			//IL_008c: Expected I4, but got O
			//IL_00a9: Expected I4, but got O
			int num = 0;
			Func<GachaTable, int> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
			if (_003C_003E9__5_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GachaTable x) => x.weigth_);
			}
			int num2 = Enumerable.Sum<GachaTable>((IEnumerable<>)(object)tableData, (Func<, >)(object)_003C_003E9__5_);
			List<AnyItemFilter> list = default(List<AnyItemFilter>);
			List<AnyItemFilter> list2 = default(List<AnyItemFilter>);
			if (filters == null && exclusions == null)
			{
				list = (List<AnyItemFilter>)(object)new List<T>();
				list2 = (List<AnyItemFilter>)(object)new List<T>();
			}
			List<AnyItemFilter> list3 = (List<AnyItemFilter>)(object)new List<T>();
			bool flag = default(bool);
			if (flag)
			{
				List<AnyItemFilter> list4 = (List<AnyItemFilter>)(object)new List<T>((int)list);
				((List<T>)(object)list4).AddRange((IEnumerable<>)list);
				List<AnyItemFilter> list5 = (List<AnyItemFilter>)(object)new List<T>((int)list2);
				((List<T>)(object)list5).AddRange((IEnumerable<>)list2);
				GachaGeneratorData gachaGeneratorData = new GachaGeneratorData();
				gachaGeneratorData.Filters = list4;
				gachaGeneratorData.Exclusions = list5;
				List<AnyItemFilter> list6 = (gachaGeneratorData.LeftChildrenExclusions = (List<AnyItemFilter>)(object)new List<T>((int)list3));
				int num3 = 0;
				((List<T>)(object)list6).AddRange((IEnumerable<>)list);
				new List<T>((int)list2).AddRange((IEnumerable<>)list2);
				((List<T>)(object)list3).AddRange((IEnumerable<>)list2);
			}
			double result = default(double);
			return result;
		}
	}
}
