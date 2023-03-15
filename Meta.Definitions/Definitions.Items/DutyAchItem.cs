using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200063F")]
	public readonly struct DutyAchItem : IEquatable<DutyAchItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002223")]
		internal readonly int DutyAchItemID;

		[Cpp2IlInjected.Token(Token = "0x4002224")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x4002225")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x17001305")]
		public DutyAchItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60049E5")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E3F0", Offset = "0x2C4CDF0", VA = "0x182C4E3F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001306")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60049E6")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E390", Offset = "0x2C4CD90", VA = "0x182C4E390")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049E7")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public DutyAchItem(int dutyItemId)
		{
			DutyAchItemID = dutyItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x60049E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E310", Offset = "0x2C4CD10", VA = "0x182C4E310")]
		public DutyAchItem(DutyAchItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (DutyAchItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x60049E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E1A0", Offset = "0x2C4CBA0", VA = "0x182C4E1A0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60049EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E140", Offset = "0x2C4CB40", VA = "0x182C4E140", Slot = "4")]
		public bool Equals(DutyAchItem other)
		{
			int dutyAchItemID = other.DutyAchItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049EB")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60049EC")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in DutyAchItem lhs, in DutyAchItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E450", Offset = "0x2C4CE50", VA = "0x182C4E450")]
		public static bool operator !=(in DutyAchItem lhs, in DutyAchItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049EE")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60049EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E260", Offset = "0x2C4CC60", VA = "0x182C4E260", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
