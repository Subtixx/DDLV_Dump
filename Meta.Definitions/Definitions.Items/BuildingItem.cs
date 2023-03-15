using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200062E")]
	public readonly struct BuildingItem : IEquatable<BuildingItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40021F2")]
		internal readonly int BuildingItemID;

		[Cpp2IlInjected.Token(Token = "0x40021F3")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40021F4")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x40021F5")]
		public static readonly Item DreamCastle = (Item)Convert.ToInt64(20400007u);

		[Cpp2IlInjected.Token(Token = "0x40021F6")]
		public static readonly Item Restaurant = (Item)Convert.ToInt64(20300009u);

		[Cpp2IlInjected.Token(Token = "0x40021F7")]
		public static readonly Item UrbanWishingWell = (Item)Convert.ToInt64(20300018u);

		[Cpp2IlInjected.Token(Token = "0x40021F8")]
		public static readonly Item KitchenStall = (Item)Convert.ToInt64(20100001u);

		[Cpp2IlInjected.Token(Token = "0x40021F9")]
		public static readonly Item FruitTreeGarden = (Item)Convert.ToInt64(20200002u);

		[Cpp2IlInjected.Token(Token = "0x40021FA")]
		public static readonly Item ScroogeGeneralStore = (Item)Convert.ToInt64(20300028u);

		[Cpp2IlInjected.Token(Token = "0x170012E5")]
		public BuildingItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600495A")]
			[Cpp2IlInjected.Address(RVA = "0x32EF460", Offset = "0x32EDE60", VA = "0x1832EF460")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012E6")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600495B")]
			[Cpp2IlInjected.Address(RVA = "0x32EF400", Offset = "0x32EDE00", VA = "0x1832EF400")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600495C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public BuildingItem(int activityItemId)
		{
			BuildingItemID = activityItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x600495D")]
		[Cpp2IlInjected.Address(RVA = "0x32EF380", Offset = "0x32EDD80", VA = "0x1832EF380")]
		public BuildingItem(BuildingItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (BuildingItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x600495E")]
		[Cpp2IlInjected.Address(RVA = "0x32EF130", Offset = "0x32EDB30", VA = "0x1832EF130", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600495F")]
		[Cpp2IlInjected.Address(RVA = "0x32EF0D0", Offset = "0x32EDAD0", VA = "0x1832EF0D0", Slot = "4")]
		public bool Equals(BuildingItem other)
		{
			int buildingItemID = other.BuildingItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004960")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004961")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in BuildingItem lhs, in BuildingItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004962")]
		[Cpp2IlInjected.Address(RVA = "0x32EF4C0", Offset = "0x32EDEC0", VA = "0x1832EF4C0")]
		public static bool operator !=(in BuildingItem lhs, in BuildingItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004963")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004964")]
		[Cpp2IlInjected.Address(RVA = "0x32EF1F0", Offset = "0x32EDBF0", VA = "0x1832EF1F0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
