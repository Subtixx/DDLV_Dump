using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000643")]
	public readonly struct Item : IEquatable<Item>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400222C")]
		public readonly int ItemID;

		[Cpp2IlInjected.Token(Token = "0x400222D")]
		public static readonly Item Invalid;

		[Cpp2IlInjected.Token(Token = "0x400222E")]
		private const int DigitsForIDs = 7;

		[Cpp2IlInjected.Token(Token = "0x400222F")]
		public static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x1700130B")]
		public ItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004A0B")]
			[Cpp2IlInjected.Address(RVA = "0x27C39F0", Offset = "0x27C23F0", VA = "0x1827C39F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700130C")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004A0C")]
			[Cpp2IlInjected.Address(RVA = "0x27C3980", Offset = "0x27C2380", VA = "0x1827C3980")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A0D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public Item(int itemID)
		{
			ItemID = itemID;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A0E")]
		[Cpp2IlInjected.Address(RVA = "0x27C3900", Offset = "0x27C2300", VA = "0x1827C3900")]
		public Item(ItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (ItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A0F")]
		[Cpp2IlInjected.Address(RVA = "0x27C3280", Offset = "0x27C1C80", VA = "0x1827C3280", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004A10")]
		[Cpp2IlInjected.Address(RVA = "0x27C3220", Offset = "0x27C1C20", VA = "0x1827C3220", Slot = "4")]
		public bool Equals(Item other)
		{
			int itemID = other.ItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A11")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A12")]
		[Cpp2IlInjected.Address(RVA = "0x27C3340", Offset = "0x27C1D40", VA = "0x1827C3340", Slot = "3")]
		public override string ToString()
		{
			//Discarded unreachable code: IL_0066, IL_006c
			//IL_0029: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			Item invalid = Invalid;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			string text = default(string);
			if (!string.IsNullOrEmpty(text))
			{
				ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
				Type _003CSubTypeEnumType_003Ek__BackingField = itemTypeMetaInfo.SubTypeEnumType;
				int num = 0;
				if (!(_003CSubTypeEnumType_003Ek__BackingField != (Type)num))
				{
					ItemType type = Type;
					return $"{type}/{text}";
				}
				ItemType type2 = Type;
				ItemDatabase.ItemTypeMetaInfo.GetSubTypeDelegate _003CGetSubType_003Ek__BackingField = itemTypeMetaInfo.GetSubType;
				GenericEnum arg = default(GenericEnum);
				string text2 = $"{type2}/{arg}/{text}";
			}
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A13")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in Item lhs, in Item rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A14")]
		[Cpp2IlInjected.Address(RVA = "0x27C3A50", Offset = "0x27C2450", VA = "0x1827C3A50")]
		public static bool operator !=(in Item lhs, in Item rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A15")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A16")]
		[Cpp2IlInjected.Address(RVA = "0x19AEC60", Offset = "0x19AD660", VA = "0x1819AEC60")]
		public SubItemType To<SubItemType>() where SubItemType : struct, ISubItem
		{
			//Discarded unreachable code: IL_001c
			int index = Index;
			ItemType itemType = default(ItemType);
			int num = (int)itemType;
			ItemType type = Type;
			if (num == (int)type)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A17")]
		[Cpp2IlInjected.Address(RVA = "0x19B07E0", Offset = "0x19AF1E0", VA = "0x1819B07E0")]
		public bool TryGet<SubItemType>(out SubItemType subItem) where SubItemType : struct, ISubItem
		{
			int index = Index;
			ItemType itemType = default(ItemType);
			int num = (int)itemType;
			ItemType type = Type;
			return num == (int)type;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A18")]
		[Cpp2IlInjected.Address(RVA = "0x7EF590", Offset = "0x7EDF90", VA = "0x1807EF590")]
		public static Item New(int id)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A19")]
		[Cpp2IlInjected.Address(RVA = "0x27C36F0", Offset = "0x27C20F0", VA = "0x1827C36F0")]
		public bool TryGetPrice(int currencyId, out int price)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A1A")]
		[Cpp2IlInjected.Address(RVA = "0x27C3670", Offset = "0x27C2070", VA = "0x1827C3670")]
		public bool TryGetPrice(Item currency, out int price)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A1B")]
		[Cpp2IlInjected.Address(RVA = "0x27C3800", Offset = "0x27C2200", VA = "0x1827C3800")]
		public bool TryGetPrices(int currencyId, out List<CurrencyCost> prices)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A1C")]
		[Cpp2IlInjected.Address(RVA = "0x27C3790", Offset = "0x27C2190", VA = "0x1827C3790")]
		public bool TryGetPrices(Item currency, out List<CurrencyCost> prices)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A1D")]
		[Cpp2IlInjected.Address(RVA = "0x27C3870", Offset = "0x27C2270", VA = "0x1827C3870")]
		static Item()
		{
			//IL_0008: Expected O, but got I4
			int num = 0;
			Invalid = (Item)num;
			ItemTypeFilter = num;
		}
	}
}
