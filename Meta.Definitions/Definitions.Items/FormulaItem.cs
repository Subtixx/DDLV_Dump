using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000640")]
	public readonly struct FormulaItem : IEquatable<FormulaItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002226")]
		internal readonly int FormulaItemID;

		[Cpp2IlInjected.Token(Token = "0x4002227")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x4002228")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x17001307")]
		public FormulaItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60049F1")]
			[Cpp2IlInjected.Address(RVA = "0x3587420", Offset = "0x3585E20", VA = "0x183587420")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001308")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60049F2")]
			[Cpp2IlInjected.Address(RVA = "0x35873C0", Offset = "0x3585DC0", VA = "0x1835873C0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049F3")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public FormulaItem(int formulaItemId)
		{
			FormulaItemID = formulaItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x60049F4")]
		[Cpp2IlInjected.Address(RVA = "0x3587340", Offset = "0x3585D40", VA = "0x183587340")]
		public FormulaItem(FormulaItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (FormulaItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x60049F5")]
		[Cpp2IlInjected.Address(RVA = "0x35871D0", Offset = "0x3585BD0", VA = "0x1835871D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60049F6")]
		[Cpp2IlInjected.Address(RVA = "0x3587170", Offset = "0x3585B70", VA = "0x183587170", Slot = "4")]
		public bool Equals(FormulaItem other)
		{
			int formulaItemID = other.FormulaItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049F7")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60049F8")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in FormulaItem lhs, in FormulaItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049F9")]
		[Cpp2IlInjected.Address(RVA = "0x3587480", Offset = "0x3585E80", VA = "0x183587480")]
		public static bool operator !=(in FormulaItem lhs, in FormulaItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049FA")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60049FB")]
		[Cpp2IlInjected.Address(RVA = "0x3587290", Offset = "0x3585C90", VA = "0x183587290", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
