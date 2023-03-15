using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000240")]
	public class ItemMinLevelFilter : BaseItemFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000902")]
		private PlayerProfile playerProfile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000903")]
		private WorldProfile worldProfile;

		[Cpp2IlInjected.Token(Token = "0x600157C")]
		[Cpp2IlInjected.Address(RVA = "0x25E2690", Offset = "0x25E1090", VA = "0x1825E2690")]
		public ItemMinLevelFilter(in PlayerProfile playerProfile, in WorldProfile worldProfile)
		{
			((ServiceContainer)(object)this)._002Ector();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600157D")]
		[Cpp2IlInjected.Address(RVA = "0x25E2590", Offset = "0x25E0F90", VA = "0x1825E2590", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData.GetUnlockConditions() != null)
				{
					ItemMinLevelFilter itemMinLevelFilter = this;
					bool result = default(bool);
					return result;
				}
				int num2 = 0;
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x600157E")]
		[Cpp2IlInjected.Address(RVA = "0x25E2490", Offset = "0x25E0E90", VA = "0x1825E2490", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData.GetUnlockConditions() != null)
				{
					ItemMinLevelFilter itemMinLevelFilter = this;
					bool result = default(bool);
					return result;
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}
	}
}
