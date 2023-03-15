using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000631")]
	public readonly struct CurrencyItem : IEquatable<CurrencyItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002201")]
		internal readonly int CurrencyItemID;

		[Cpp2IlInjected.Token(Token = "0x4002202")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x4002203")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x4002204")]
		public const string SoftCurrencyName = "StarCoin";

		[Cpp2IlInjected.Token(Token = "0x4002205")]
		public const string HardCurrencyName = "Gem";

		[Cpp2IlInjected.Token(Token = "0x4002206")]
		public const string SocialCurrencyName = "Heart";

		[Cpp2IlInjected.Token(Token = "0x4002207")]
		public const string TicketCurrencyName = "Ticket";

		[Cpp2IlInjected.Token(Token = "0x4002208")]
		public const string DreamDustCurrencyName = "DreamDust";

		[Cpp2IlInjected.Token(Token = "0x4002209")]
		public const string WishTokenCurrencyName = "WishToken";

		[Cpp2IlInjected.Token(Token = "0x170012EB")]
		public CurrencyType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004983")]
			[Cpp2IlInjected.Address(RVA = "0x2D46100", Offset = "0x2D44B00", VA = "0x182D46100")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012EC")]
		public static Item SoftCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x600498E")]
			[Cpp2IlInjected.Address(RVA = "0x2D46060", Offset = "0x2D44A60", VA = "0x182D46060")]
			get
			{
				long num = Convert.ToInt64(80000000u);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012ED")]
		public static Item HardCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x600498F")]
			[Cpp2IlInjected.Address(RVA = "0x2D45FC0", Offset = "0x2D449C0", VA = "0x182D45FC0")]
			get
			{
				long num = Convert.ToInt64(80100000u);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012EE")]
		public static Item SocialCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004990")]
			[Cpp2IlInjected.Address(RVA = "0x2D46010", Offset = "0x2D44A10", VA = "0x182D46010")]
			get
			{
				long num = Convert.ToInt64(80200000u);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012EF")]
		public static Item TicketCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004991")]
			[Cpp2IlInjected.Address(RVA = "0x2D460B0", Offset = "0x2D44AB0", VA = "0x182D460B0")]
			get
			{
				long num = Convert.ToInt64(80200001u);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012F0")]
		public static Item DreamDustCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004992")]
			[Cpp2IlInjected.Address(RVA = "0x2D45F70", Offset = "0x2D44970", VA = "0x182D45F70")]
			get
			{
				long num = Convert.ToInt64(80300000u);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012F1")]
		public static Item WishTokenCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004993")]
			[Cpp2IlInjected.Address(RVA = "0x2D46160", Offset = "0x2D44B60", VA = "0x182D46160")]
			get
			{
				long num = Convert.ToInt64(80700000u);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004984")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public CurrencyItem(int currencyItemID)
		{
			CurrencyItemID = currencyItemID;
		}

		[Cpp2IlInjected.Token(Token = "0x6004985")]
		[Cpp2IlInjected.Address(RVA = "0x2D45EF0", Offset = "0x2D448F0", VA = "0x182D45EF0")]
		public CurrencyItem(CurrencyType itemType, int index)
		{
			int num = (int)itemType;
			num = (CurrencyItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004986")]
		[Cpp2IlInjected.Address(RVA = "0x2D45A40", Offset = "0x2D44440", VA = "0x182D45A40", Slot = "0")]
		public override bool Equals(object obj)
		{
			bool result = default(bool);
			if (obj != null && obj != null)
			{
				return result;
			}
			int num = 0;
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004987")]
		[Cpp2IlInjected.Address(RVA = "0x2D45B00", Offset = "0x2D44500", VA = "0x182D45B00", Slot = "4")]
		public bool Equals(CurrencyItem other)
		{
			int currencyItemID = other.CurrencyItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004988")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004989")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in CurrencyItem lhs, in CurrencyItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600498A")]
		[Cpp2IlInjected.Address(RVA = "0x2D461B0", Offset = "0x2D44BB0", VA = "0x182D461B0")]
		public static bool operator !=(in CurrencyItem lhs, in CurrencyItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600498B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600498C")]
		[Cpp2IlInjected.Address(RVA = "0x2D45E40", Offset = "0x2D44840", VA = "0x182D45E40", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600498D")]
		[Cpp2IlInjected.Address(RVA = "0x2D45400", Offset = "0x2D43E00", VA = "0x182D45400")]
		public static Item CurrencyItemByName(string currencyName)
		{
			//Discarded unreachable code: IL_000d
			return ItemDatabase.Instance.GetItem(ItemType.Currency, currencyName);
		}

		[Cpp2IlInjected.Token(Token = "0x6004994")]
		[Cpp2IlInjected.Address(RVA = "0x2D45B60", Offset = "0x2D44560", VA = "0x182D45B60")]
		public static bool IsHardCurrencyItem(Item currencyItem)
		{
			//Discarded unreachable code: IL_0065, IL_006a
			//IL_0014: Expected O, but got I4
			//IL_0065: Expected I4, but got O
			int itemID = currencyItem.ItemID;
			Item currencyItem2 = (Item)itemID;
			long num = Convert.ToInt64(80100000u);
			int num2 = 0;
			IEnumerable<StoreFrontSpecificCurrencyItemData> all = (IEnumerable<StoreFrontSpecificCurrencyItemData>)StoreFrontSpecificCurrencyItemData.GetAll();
			Func<StoreFrontSpecificCurrencyItemData, bool> func = (Func<StoreFrontSpecificCurrencyItemData, bool>)(object)(Func<T, TResult>)delegate(StoreFrontSpecificCurrencyItemData x)
			{
				int iD = x.ID;
				throw new NullReferenceException();
			};
			StoreFrontSpecificCurrencyItemData storeFrontSpecificCurrencyItemData = Enumerable.FirstOrDefault<StoreFrontSpecificCurrencyItemData>((IEnumerable<>)all, (Func<, >)(object)func);
			if (storeFrontSpecificCurrencyItemData != null)
			{
				Item emulatedCurrencyItem = storeFrontSpecificCurrencyItemData.EmulatedCurrencyItem;
				int num3 = 0;
				int itemID2 = emulatedCurrencyItem.ItemID;
			}
			int num4 = 0;
			return (byte)(int)typeof(Item).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004995")]
		[Cpp2IlInjected.Address(RVA = "0x2D454C0", Offset = "0x2D43EC0", VA = "0x182D454C0")]
		public static void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00f3
			long num = Convert.ToInt64(80000000u);
			Item item = CurrencyItemByName("StarCoin");
			bool flag = default(bool);
			if (flag)
			{
				context.AddError("[CurrencyItem.SoftCurrencyItem] This hardcoded ItemID is now invalid, have to change code");
			}
			long num2 = Convert.ToInt64(80100000u);
			Item item2 = CurrencyItemByName("Gem");
			bool flag2 = default(bool);
			if (flag2)
			{
				context.AddError("[CurrencyItem.HardCurrencyItem] This hardcoded ItemID is now invalid, have to change code");
			}
			long num3 = Convert.ToInt64(80200000u);
			Item item3 = CurrencyItemByName("Heart");
			bool flag3 = default(bool);
			if (flag3)
			{
				context.AddError("[CurrencyItem.SocialCurrencyItem] This hardcoded ItemID is now invalid, have to change code");
			}
			long num4 = Convert.ToInt64(80200001u);
			Item item4 = CurrencyItemByName("Ticket");
			bool flag4 = default(bool);
			if (flag4)
			{
				context.AddError("[CurrencyItem.TicketCurrencyItem] This hardcoded ItemID is now invalid, have to change code");
			}
			long num5 = Convert.ToInt64(80300000u);
			Item item5 = CurrencyItemByName("DreamDust");
			bool flag5 = default(bool);
			if (flag5)
			{
				context.AddError("[CurrencyItem.DreamDustCurrencyItem] This hardcoded ItemID is now invalid, have to change code");
			}
			long num6 = Convert.ToInt64(80700000u);
			Item item6 = CurrencyItemByName("WishToken");
			bool flag6 = default(bool);
			if (flag6)
			{
				context.AddError("[CurrencyItem.WishTokenCurrencyItem] This hardcoded ItemID is now invalid, have to change code");
			}
		}
	}
}
