using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Definitions.Shops
{
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	public static class ItemPriceDatabases
	{
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private static Dictionary<Item, int> PriceGemOnlyCache;

		[Cpp2IlInjected.Token(Token = "0x17000381")]
		public static CurrencyCost InvalidPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000E99")]
			[Cpp2IlInjected.Address(RVA = "0x25EA170", Offset = "0x25E8B70", VA = "0x1825EA170")]
			get
			{
				int num = 0;
				return ItemPriceDatabase.InvalidPrice;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9A")]
		[Cpp2IlInjected.Address(RVA = "0x25E98A0", Offset = "0x25E82A0", VA = "0x1825E98A0")]
		public static bool TryGetPrice(Item item, Item currency, out int price)
		{
			//Discarded unreachable code: IL_00b0, IL_00b6, IL_00bc
			//IL_0032: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			CurrencyCost currencyCost = default(CurrencyCost);
			int num2;
			do
			{
				int itemID = currency.ItemID;
				int itemID2 = item.ItemID;
				int num = 0;
				num2 = 0;
				IEnumerable<> enumerable = ProtoDatabase.Instance.Enumerate<ItemPriceDatabase>();
				if (enumerable != null)
				{
					ItemPriceDatabase._003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals0 = new ItemPriceDatabase._003C_003Ec__DisplayClass30_0();
					CS_0024_003C_003E8__locals0.item = (Item)itemID2;
					CS_0024_003C_003E8__locals0.currency = (Item)itemID;
					if (currencyCost == null)
					{
						Func<ItemPrices, bool> func = (Func<ItemPrices, bool>)(object)(Func<T, TResult>)delegate(ItemPrices x)
						{
							//Discarded unreachable code: IL_0011
							Item item2 = CS_0024_003C_003E8__locals0.item;
							return (IntPtr)x.id_ == (IntPtr)item2;
						};
						ItemPrices itemPrices = Enumerable.FirstOrDefault<ItemPrices>(enumerable, (Func<, >)(object)func);
						if (itemPrices != null)
						{
							RepeatedField<CurrencyCost> prices_ = itemPrices.prices_;
							Func<CurrencyCost, bool> func2 = (Func<CurrencyCost, bool>)(object)(Func<T, TResult>)delegate(CurrencyCost x)
							{
								//Discarded unreachable code: IL_0011
								Item currency2 = CS_0024_003C_003E8__locals0.currency;
								return (IntPtr)x.id_ == (IntPtr)currency2;
							};
							if (Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)(object)prices_, (Func<, >)(object)func2) != null)
							{
							}
						}
					}
					while (1L == 0L)
					{
					}
					num2++;
				}
				num2++;
				if (enumerable != null)
				{
				}
			}
			while (num2 != 0);
			if (num2 != 0)
			{
			}
			int num3 = 0;
			CurrencyCost invalidPrice = ItemPriceDatabase.InvalidPrice;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9B")]
		[Cpp2IlInjected.Address(RVA = "0x25E9D20", Offset = "0x25E8720", VA = "0x1825E9D20")]
		public static bool TryGetPrice(Item item, int currencyId, out int price)
		{
			int itemID = item.ItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9C")]
		[Cpp2IlInjected.Address(RVA = "0x25E9DD0", Offset = "0x25E87D0", VA = "0x1825E9DD0")]
		public static bool TryGetPrices(Item item, out List<CurrencyCost> prices)
		{
			//Discarded unreachable code: IL_0047, IL_004d
			int num = 0;
			int num2 = 0;
			IEnumerable<> enumerable = ProtoDatabase.Instance.Enumerate<ItemPriceDatabase>();
			if (enumerable != null)
			{
				bool flag = default(bool);
				while (!flag)
				{
				}
				num2++;
			}
			num2++;
			if (enumerable != null)
			{
			}
			if (num2 != 0)
			{
			}
			List<CurrencyCost> list = (List<CurrencyCost>)(object)new List<T>();
			int num3 = 0;
			CurrencyCost invalidPrice = ItemPriceDatabase.InvalidPrice;
			((List<T>)(object)list).Add((T)invalidPrice);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9D")]
		[Cpp2IlInjected.Address(RVA = "0x25E9290", Offset = "0x25E7C90", VA = "0x1825E9290")]
		public static int GetSoftCurrencySellPrice(Item item, ItemState state, int defaultPrice = 1)
		{
			//Discarded unreachable code: IL_0031, IL_0037
			bool flag = default(bool);
			int num;
			do
			{
				num = 0;
				IEnumerable<> enumerable = ProtoDatabase.Instance.Enumerate<ItemPriceDatabase>();
				if (enumerable != null)
				{
					while (!flag)
					{
					}
					num++;
				}
				num++;
				if (enumerable != null)
				{
				}
			}
			while (num != 0);
			if (num != 0)
			{
				return num;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9E")]
		[Cpp2IlInjected.Address(RVA = "0x25E9050", Offset = "0x25E7A50", VA = "0x1825E9050")]
		internal static int GetDefaultSoftCurrencySellPrice(Item item, int defaultPrice = 1)
		{
			//Discarded unreachable code: IL_0031, IL_0037
			bool flag = default(bool);
			int num;
			do
			{
				num = 0;
				IEnumerable<> enumerable = ProtoDatabase.Instance.Enumerate<ItemPriceDatabase>();
				if (enumerable != null)
				{
					while (!flag)
					{
					}
					num++;
				}
				num++;
				if (enumerable != null)
				{
				}
			}
			while (num != 0);
			if (num != 0)
			{
				return num;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9F")]
		[Cpp2IlInjected.Address(RVA = "0x25E94E0", Offset = "0x25E7EE0", VA = "0x1825E94E0")]
		public static bool TryGetPriceGemOnly_EDITOR(Item item, out int price)
		{
			//Discarded unreachable code: IL_0049, IL_0060, IL_0066, IL_006c, IL_0072
			int value = 0;
			int num = 0;
			if ((price.m_value = ItemPriceDatabase.InvalidPrice.amount_) == 0)
			{
				bool flag = default(bool);
				if (!flag)
				{
					int num2 = 0;
					int itemID = CurrencyItem.HardCurrencyItem.ItemID;
					IEnumerable<> enumerable = default(IEnumerable<>);
					if (enumerable != null)
					{
						bool flag2 = default(bool);
						while (!flag2)
						{
						}
						price.m_value = value;
					}
					if (enumerable != null)
					{
					}
					throw new NullReferenceException();
				}
				bool result = default(bool);
				return result;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA0")]
		[Cpp2IlInjected.Address(RVA = "0x25EA0F0", Offset = "0x25E8AF0", VA = "0x1825EA0F0")]
		static ItemPriceDatabases()
		{
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			/*Error: Unexpected end of block*/;
		}
	}
}
