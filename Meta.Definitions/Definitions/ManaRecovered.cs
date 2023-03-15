using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public static class ManaRecovered
	{
		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x30655F0", Offset = "0x3063FF0", VA = "0x1830655F0")]
		public static int GetManaRecovered(Item item, ItemState state, int defaultValue = int.MaxValue)
		{
			return defaultValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x3065620", Offset = "0x3064020", VA = "0x183065620")]
		public static bool TryGetManaRecovered(Item item, ItemState state, out int manaRecovered)
		{
			//IL_002a: Expected I4, but got O
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (itemData == null)
			{
				int num = 0;
				if (itemData == null)
				{
					manaRecovered.m_value = num;
				}
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				manaRecovered.m_value = (int)itemData;
				return (long)(IntPtr)itemData > 0L;
			}
			int num3 = 0;
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
			throw new NullReferenceException();
		}
	}
}
