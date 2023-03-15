using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D4")]
	public readonly struct MakeupItem : IEquatable<MakeupItem>, IComparable<MakeupItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022B9")]
		internal readonly int MakeupItemID;

		[Cpp2IlInjected.Token(Token = "0x40022BA")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022BB")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x1700139F")]
		public MakeupItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C1E")]
			[Cpp2IlInjected.Address(RVA = "0x3901800", Offset = "0x3900200", VA = "0x183901800")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013A0")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C1F")]
			[Cpp2IlInjected.Address(RVA = "0x39017A0", Offset = "0x39001A0", VA = "0x1839017A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C20")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public MakeupItem(int makeupItemId)
		{
			MakeupItemID = makeupItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C21")]
		[Cpp2IlInjected.Address(RVA = "0x3901720", Offset = "0x3900120", VA = "0x183901720")]
		public MakeupItem(MakeupItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (MakeupItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C22")]
		[Cpp2IlInjected.Address(RVA = "0x3901550", Offset = "0x38FFF50", VA = "0x183901550", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C23")]
		[Cpp2IlInjected.Address(RVA = "0x3901610", Offset = "0x3900010", VA = "0x183901610", Slot = "4")]
		public bool Equals(MakeupItem other)
		{
			int makeupItemID = other.MakeupItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C24")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C25")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0E00", Offset = "0x2EBF800", VA = "0x182EC0E00", Slot = "5")]
		public int CompareTo(MakeupItem other)
		{
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C26")]
		[Cpp2IlInjected.Address(RVA = "0x2EC11F0", Offset = "0x2EBFBF0", VA = "0x182EC11F0")]
		public static bool operator <(MakeupItem left, MakeupItem right)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C27")]
		[Cpp2IlInjected.Address(RVA = "0x2EC11D0", Offset = "0x2EBFBD0", VA = "0x182EC11D0")]
		public static bool operator <=(MakeupItem left, MakeupItem right)
		{
			int num = default(int);
			return num <= 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C28")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1150", Offset = "0x2EBFB50", VA = "0x182EC1150")]
		public static bool operator >(MakeupItem left, MakeupItem right)
		{
			int num = default(int);
			return num > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C29")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1130", Offset = "0x2EBFB30", VA = "0x182EC1130")]
		public static bool operator >=(MakeupItem left, MakeupItem right)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2A")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in MakeupItem lhs, in MakeupItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2B")]
		[Cpp2IlInjected.Address(RVA = "0x3901860", Offset = "0x3900260", VA = "0x183901860")]
		public static bool operator !=(in MakeupItem lhs, in MakeupItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "7")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2D")]
		[Cpp2IlInjected.Address(RVA = "0x3901670", Offset = "0x3900070", VA = "0x183901670", Slot = "6")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
