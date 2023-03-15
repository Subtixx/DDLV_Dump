using System;
using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200069E")]
	public static class HasUnlockConditionsExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004AF4")]
		[Cpp2IlInjected.Address(RVA = "0x27AA820", Offset = "0x27A9220", VA = "0x1827AA820")]
		public static bool CanView(this IHasUnlockConditions self, in PlayerProfile playerProfile, in WorldProfile worldProfile)
		{
			//Discarded unreachable code: IL_0010
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IHasUnlockConditions).TypeHandle != null)
			{
				return (byte)(int)typeof(IHasUnlockConditions).TypeHandle != 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004AF5")]
		[Cpp2IlInjected.Address(RVA = "0x27AA600", Offset = "0x27A9000", VA = "0x1827AA600")]
		public static bool CanBuy(this IHasUnlockConditions self, in PlayerProfile playerProfile, in WorldProfile worldProfile)
		{
			int num = 0;
			bool? flag = default(bool?);
			bool result = default(bool);
			if ((object)typeof(ItemDatabase).TypeHandle != null && (object)flag != null)
			{
				return result;
			}
			if ((object)typeof(ItemDatabase).TypeHandle != null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				SetItemData setItemData = default(SetItemData);
				if (setItemData != null)
				{
					bool flag2 = setItemData.CanBuy(in playerProfile, in worldProfile);
				}
				if (num == 0)
				{
				}
			}
			throw new NullReferenceException();
		}
	}
}
