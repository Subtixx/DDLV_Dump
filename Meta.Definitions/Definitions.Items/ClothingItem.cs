using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200062F")]
	public readonly struct ClothingItem : IEquatable<ClothingItem>, IComparable<ClothingItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40021FB")]
		internal readonly int ClothingItemID;

		[Cpp2IlInjected.Token(Token = "0x40021FC")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40021FD")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170012E7")]
		public ClothingItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004966")]
			[Cpp2IlInjected.Address(RVA = "0x2EC10D0", Offset = "0x2EBFAD0", VA = "0x182EC10D0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012E8")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004967")]
			[Cpp2IlInjected.Address(RVA = "0x2EC1070", Offset = "0x2EBFA70", VA = "0x182EC1070")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004968")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public ClothingItem(int clothingItemId)
		{
			ClothingItemID = clothingItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004969")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0FF0", Offset = "0x2EBF9F0", VA = "0x182EC0FF0")]
		public ClothingItem(ClothingItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (ClothingItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x600496A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0E80", Offset = "0x2EBF880", VA = "0x182EC0E80", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600496B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0E20", Offset = "0x2EBF820", VA = "0x182EC0E20", Slot = "4")]
		public bool Equals(ClothingItem other)
		{
			int clothingItemID = other.ClothingItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600496C")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600496D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0E00", Offset = "0x2EBF800", VA = "0x182EC0E00", Slot = "5")]
		public int CompareTo(ClothingItem other)
		{
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600496E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC11F0", Offset = "0x2EBFBF0", VA = "0x182EC11F0")]
		public static bool operator <(ClothingItem left, ClothingItem right)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600496F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC11D0", Offset = "0x2EBFBD0", VA = "0x182EC11D0")]
		public static bool operator <=(ClothingItem left, ClothingItem right)
		{
			int num = default(int);
			return num <= 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004970")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1150", Offset = "0x2EBFB50", VA = "0x182EC1150")]
		public static bool operator >(ClothingItem left, ClothingItem right)
		{
			int num = default(int);
			return num > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004971")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1130", Offset = "0x2EBFB30", VA = "0x182EC1130")]
		public static bool operator >=(ClothingItem left, ClothingItem right)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004972")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in ClothingItem lhs, in ClothingItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004973")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1170", Offset = "0x2EBFB70", VA = "0x182EC1170")]
		public static bool operator !=(in ClothingItem lhs, in ClothingItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004974")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "7")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004975")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0F40", Offset = "0x2EBF940", VA = "0x182EC0F40", Slot = "6")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
