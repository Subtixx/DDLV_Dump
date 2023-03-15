using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C4C")]
	public static class SkippableTimerProviderExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600386C")]
		[Cpp2IlInjected.Address(RVA = "0xF54D00", Offset = "0xF53700", VA = "0x180F54D00")]
		public static (Item, int) GetPriceToSkip(this ISkippableTimerProvider skippableTimerProvider)
		{
			//IL_0051: Expected O, but got I4
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool flag = default(bool);
			if (!flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int num3 = 0;
				Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
				HardCurrencyItemData hardCurrencyItemData = default(HardCurrencyItemData);
				int iD = hardCurrencyItemData.ID;
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				int priceToSkip = hardCurrencyItemData.GetPriceToSkip((TimeSpan)num);
				iD += iD;
				num += 312;
				iD += iD;
				num += 328;
			}
			int num5 = 0;
			Item hardCurrencyItem2 = CurrencyItem.HardCurrencyItem;
			int num6 = 0;
			int itemID = hardCurrencyItem2.ItemID;
			throw new NullReferenceException();
		}
	}
}
