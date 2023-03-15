using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000983")]
	public static class FilterUtil
	{
		[Cpp2IlInjected.Token(Token = "0x2000984")]
		public enum FilterCombineMode
		{
			[Cpp2IlInjected.Token(Token = "0x400384D")]
			Union,
			[Cpp2IlInjected.Token(Token = "0x400384E")]
			Intersection
		}

		[Cpp2IlInjected.Token(Token = "0x400384A")]
		public const FilterCombineMode Union = FilterCombineMode.Union;

		[Cpp2IlInjected.Token(Token = "0x400384B")]
		public const FilterCombineMode Intersection = FilterCombineMode.Intersection;

		[Cpp2IlInjected.Token(Token = "0x6003BC6")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5020", Offset = "0x1BB3A20", VA = "0x181BB5020")]
		public static List<T> FilterQuest<T>(IEnumerable<T> items, ItemFilterData itemFilters, FilterColorConfig colorConfig, List<Filter> rarityFilters) where T : class
		{
			//Discarded unreachable code: IL_00bb, IL_00c1, IL_00c7, IL_00cd
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected I4, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected I4, but got Unknown
			bool flag = default(bool);
			Filter item = default(Filter);
			Filter item2 = default(Filter);
			Filter item3 = default(Filter);
			Filter item4 = default(Filter);
			Filter item5 = default(Filter);
			bool flag7 = default(bool);
			int num5;
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
				RepeatedField<int> tags_ = itemFilters.tags_;
				if (flag)
				{
					bool flag2 = ((HashSet<T>)(object)hashSet).Add((T)item);
				}
				int num4 = 0;
				num4 += num4;
				num4++;
				if (num3 == 0)
				{
					num4 += 312;
					num4 += typeof(List<int>.Enumerator).TypeHandle;
					bool flag3 = ((HashSet<T>)(object)hashSet).Add((T)item2);
					bool flag4 = ((HashSet<T>)(object)hashSet).Add((T)item3);
					bool flag5 = ((HashSet<T>)(object)hashSet).Add((T)item4);
					bool flag6 = ((HashSet<T>)(object)hashSet).Add((T)item5);
					if (flag7)
					{
					}
					num5 = 0;
					if (num5 < (flag7 ? 1 : 0))
					{
						num5 += num5;
						num5++;
					}
					if (num3 == 0)
					{
						break;
					}
				}
			}
			num5 += 312;
			num5 += typeof(List<Filter>.Enumerator).TypeHandle;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC7")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5790", Offset = "0x1BB4190", VA = "0x181BB5790")]
		public static List<> Filter<T>(IEnumerable<> P_0, IEnumerable<> P_1, FilterCombineMode P_2, FilterCombineMode P_3) where T : class
		{
			//Discarded unreachable code: IL_0079, IL_007f, IL_008b
			//IL_005e: Expected O, but got I4
			Type type = default(Type);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				if (((object)typeof(Type).TypeHandle == null || (object)typeof(Type).TypeHandle != null) && ((object)typeof(Type).TypeHandle == null || (object)typeof(Type).TypeHandle != null))
				{
					bool flag = Enumerable.Any<Filter>(P_1);
					if (flag)
					{
						Type typeFromHandle = typeof(StoreMenu.StoreItem);
						bool flag2 = ((object)type).Equals((object)typeFromHandle);
						if (flag2)
						{
							while (!flag3)
							{
							}
							Type typeFromHandle2 = typeof(StoreMenu.StoreItem);
							if (Convert.ChangeType(flag2, typeFromHandle2) == null)
							{
								break;
							}
							while (!flag4)
							{
							}
						}
						if (flag2)
						{
						}
						if (flag2)
						{
							continue;
						}
						flag4 = flag;
					}
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC8")]
		[Cpp2IlInjected.Address(RVA = "0x165BDF0", Offset = "0x165A7F0", VA = "0x18165BDF0")]
		public static IEnumerable<Filter> BuildGroups(IEnumerable<Filter> filters, FilterCombineMode groupCombineMode)
		{
			//Discarded unreachable code: IL_0045, IL_004a, IL_007a, IL_0080, IL_0086, IL_008c, IL_0092, IL_0098
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			Dictionary<string, HashSet<Filter>> dictionary = (Dictionary<string, HashSet<Filter>>)(object)new Dictionary<TKey, TValue>();
			if (dictionary != null)
			{
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					if (num3 == (int)num4)
					{
						goto IL_0038;
					}
					num3++;
				}
				Dictionary<, >.Entry[] entries = (Dictionary<, >.Entry[])(object)((Dictionary<, >)(object)dictionary).entries;
				if (dictionary != null)
				{
					goto IL_0038;
				}
				goto IL_003f;
			}
			if (dictionary != null)
			{
			}
			Dictionary<string, HashSet<Filter>>.ValueCollection values = (Dictionary<string, HashSet<Filter>>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary).get_Values();
			bool flag = default(bool);
			if (flag)
			{
				FilterGroup item = default(FilterGroup);
				bool flag2 = ((HashSet<T>)(object)hashSet).Add((T)item);
			}
			throw new NullReferenceException();
			IL_0038:
			dictionary = (Dictionary<string, HashSet<Filter>>)(object)((object)dictionary + (object)dictionary);
			goto IL_003f;
			IL_003f:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC9")]
		[Cpp2IlInjected.Address(RVA = "0x165C8D0", Offset = "0x165B2D0", VA = "0x18165C8D0")]
		public static bool FiltersRetainItem(IEnumerable<Filter> filters, object item, FilterCombineMode combineMode)
		{
			//Discarded unreachable code: IL_0044, IL_004a
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				if (combineMode == FilterCombineMode.Intersection)
				{
					while ((object)typeof(IEnumerator).TypeHandle != null)
					{
					}
					int num4 = 0;
					num2++;
				}
				while (combineMode != 0)
				{
				}
				while (num2 == 0)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			ulong num5 = default(ulong);
			if (num5 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BCA")]
		[Cpp2IlInjected.Address(RVA = "0x165C680", Offset = "0x165B080", VA = "0x18165C680")]
		public static List<Filter> BuildTraitFilters(int order)
		{
			//Discarded unreachable code: IL_005e
			List<Filter> list = (List<Filter>)(object)new List<T>();
			int complexity = default(int);
			ComplexityFilter item = new ComplexityFilter((Complexity)complexity, order);
			complexity = 0;
			((List<T>)(object)list).Add((T)item);
			int order2 = default(int);
			ComplexityFilter item2 = new ComplexityFilter(Complexity.Simple, order2);
			order2 = order + 1;
			((List<T>)(object)list).Add((T)item2);
			MoodFilter item3 = default(MoodFilter);
			((List<T>)(object)list).Add((T)item3);
			MoodFilter item4 = default(MoodFilter);
			((List<T>)(object)list).Add((T)item4);
			SturdinessFilter item5 = default(SturdinessFilter);
			((List<T>)(object)list).Add((T)item5);
			SturdinessFilter item6 = default(SturdinessFilter);
			((List<T>)(object)list).Add((T)item6);
			NormalityFilter item7 = default(NormalityFilter);
			((List<T>)(object)list).Add((T)item7);
			NormalityFilter item8 = default(NormalityFilter);
			((List<T>)(object)list).Add((T)item8);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BCB")]
		[Cpp2IlInjected.Address(RVA = "0x165C230", Offset = "0x165AC30", VA = "0x18165C230")]
		public static List<Filter> BuildRarityFilters(FilterTierConfig TierConfig, int order)
		{
			//Discarded unreachable code: IL_002d
			List<Filter> list = (List<Filter>)(object)new List<T>();
			int num = 0;
			int size = ((List<>)(object)TierConfig.TiersFilter)._size;
			if (num < size)
			{
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				RarityFilter item = default(RarityFilter);
				((List<T>)(object)list).Add((T)item);
				num++;
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BCC")]
		[Cpp2IlInjected.Address(RVA = "0x165C3A0", Offset = "0x165ADA0", VA = "0x18165C3A0")]
		public static List<Filter> BuildTagFilters(TagItemType tagType, int order)
		{
			//Discarded unreachable code: IL_0039, IL_003f, IL_0045
			int num = 0;
			List<Filter> list = (List<Filter>)(object)new List<T>();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> enumerable = default(IEnumerable<>);
			TagFilter tagFilter = default(TagFilter);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_002c;
					}
					num++;
				}
				((List<T>)(object)list).Add((T)tagFilter);
				goto IL_002c;
			}
			goto IL_0033;
			IL_0033:
			if (enumerable != null)
			{
			}
			return list;
			IL_002c:
			tagFilter = (TagFilter)(object)((object)tagFilter + (object)tagFilter);
			goto IL_0033;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BCD")]
		[Cpp2IlInjected.Address(RVA = "0x165B9B0", Offset = "0x165A3B0", VA = "0x18165B9B0")]
		public unsafe static Filter BuildFilter(string name, FilterColorConfig colorConfig, int order = 0)
		{
			int num = 0;
			Item item = ItemDatabase.Instance.GetItem(ItemType.Tag, name);
			bool flag = default(bool);
			if (!flag)
			{
				if (!Enum.TryParse<Complexity>(name, out *(Complexity*)num))
				{
					if (!Enum.TryParse<Mood>(name, out *(Mood*)num))
					{
						if (!Enum.TryParse<Sturdiness>(name, out *(Sturdiness*)num))
						{
							if (!Enum.TryParse<Normality>(name, out *(Normality*)num))
							{
								int num2 = 0;
							}
							NormalityFilter normalityFilter = new NormalityFilter((Normality)num, order);
						}
						SturdinessFilter sturdinessFilter = new SturdinessFilter((Sturdiness)num, order);
					}
					MoodFilter moodFilter = new MoodFilter((Mood)num, order);
				}
				ComplexityFilter complexityFilter = new ComplexityFilter((Complexity)num, order);
			}
			TagFilter tagFilter = new TagFilter(ItemDatabase.Instance.GetTagData(item), order);
			throw new NullReferenceException();
		}
	}
}
