using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200071C")]
	public class VillageObjectLimit
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023BE")]
		private readonly HashSet<Item> uniqueItems = (HashSet<Item>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023BF")]
		private readonly List<Item> allItems = (List<Item>)(object)new List<T>(1024);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023C0")]
		private readonly RepeatedField<ItemTypeSelector> exclusions;

		[Cpp2IlInjected.Token(Token = "0x17001423")]
		public int UniqueCount
		{
			[Cpp2IlInjected.Token(Token = "0x6004EE8")]
			[Cpp2IlInjected.Address(RVA = "0x17C4120", Offset = "0x17C2B20", VA = "0x1817C4120")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((HashSet<>)(object)uniqueItems)._count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001424")]
		public int AllCount
		{
			[Cpp2IlInjected.Token(Token = "0x6004EE9")]
			[Cpp2IlInjected.Address(RVA = "0x17C40E0", Offset = "0x17C2AE0", VA = "0x1817C40E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)allItems)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEA")]
		[Cpp2IlInjected.Address(RVA = "0x17C4000", Offset = "0x17C2A00", VA = "0x1817C4000")]
		public VillageObjectLimit(RepeatedField<ItemTypeSelector> exclusions)
		{
			this.exclusions = exclusions;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEB")]
		[Cpp2IlInjected.Address(RVA = "0x17C3E80", Offset = "0x17C2880", VA = "0x1817C3E80")]
		public static bool IsGoingOverLimit(VillageObjectLimit previous, VillageObjectLimit current, VillageObjectLimitData limits)
		{
			//Discarded unreachable code: IL_002f, IL_0042, IL_0046
			int count = ((HashSet<>)(object)current.uniqueItems)._count;
			if (1L == 0L)
			{
			}
			HashSet<Item> hashSet = previous.uniqueItems;
			if (1L == 0L)
			{
			}
			HashSet<Item> hashSet2 = current.uniqueItems;
			int uniqueLimit_ = limits.uniqueLimit_;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEC")]
		[Cpp2IlInjected.Address(RVA = "0x17C3D10", Offset = "0x17C2710", VA = "0x1817C3D10")]
		public VillageObjectLimit Clone()
		{
			//Discarded unreachable code: IL_0061
			RepeatedField<ItemTypeSelector> repeatedField = exclusions;
			VillageObjectLimit villageObjectLimit = default(VillageObjectLimit);
			HashSet<Item> hashSet = (villageObjectLimit.uniqueItems = (HashSet<Item>)(object)new HashSet<T>());
			List<Item> list = (villageObjectLimit.allItems = (List<Item>)(object)new List<T>(1024));
			villageObjectLimit.exclusions = repeatedField;
			HashSet<Item> hashSet2 = villageObjectLimit.uniqueItems;
			HashSet<Item> hashSet3 = uniqueItems;
			((HashSet<T>)(object)hashSet2).UnionWith((IEnumerable<>)hashSet3);
			List<Item> list2 = villageObjectLimit.allItems;
			List<Item> list3 = allItems;
			((List<T>)(object)list2).AddRange((IEnumerable<>)list3);
			return villageObjectLimit;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EED")]
		[Cpp2IlInjected.Address(RVA = "0x17C3AC0", Offset = "0x17C24C0", VA = "0x1817C3AC0")]
		public void AddObject(Item item)
		{
			CheckItem(item, add: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEE")]
		[Cpp2IlInjected.Address(RVA = "0x17C3FF0", Offset = "0x17C29F0", VA = "0x1817C3FF0")]
		public void RemoveObject(Item item)
		{
			int add = 0;
			CheckItem(item, (byte)add != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEF")]
		[Cpp2IlInjected.Address(RVA = "0x17C3AD0", Offset = "0x17C24D0", VA = "0x1817C3AD0")]
		private void CheckItem(Item item, bool add)
		{
			//Discarded unreachable code: IL_0024, IL_0025, IL_002b
			int num = 0;
			RepeatedField<ItemTypeSelector> repeatedField = exclusions;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num++;
			}
			if (num + 1 != 0)
			{
			}
			bool flag3 = default(bool);
			if (!flag3)
			{
			}
		}
	}
}
