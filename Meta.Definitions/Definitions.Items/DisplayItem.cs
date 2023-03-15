using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200063E")]
	public readonly struct DisplayItem : IEquatable<DisplayItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002220")]
		internal readonly int DisplayItemID;

		[Cpp2IlInjected.Token(Token = "0x4002221")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x4002222")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x17001303")]
		public DisplayItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60049D9")]
			[Cpp2IlInjected.Address(RVA = "0x2C439F0", Offset = "0x2C423F0", VA = "0x182C439F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001304")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60049DA")]
			[Cpp2IlInjected.Address(RVA = "0x2C43990", Offset = "0x2C42390", VA = "0x182C43990")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049DB")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public DisplayItem(int activityItemId)
		{
			DisplayItemID = activityItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x60049DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C43910", Offset = "0x2C42310", VA = "0x182C43910")]
		public DisplayItem(DisplayItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (DisplayItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x60049DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C43740", Offset = "0x2C42140", VA = "0x182C43740", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60049DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C43800", Offset = "0x2C42200", VA = "0x182C43800", Slot = "4")]
		public bool Equals(DisplayItem other)
		{
			int displayItemID = other.DisplayItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049DF")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60049E0")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in DisplayItem lhs, in DisplayItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C43A50", Offset = "0x2C42450", VA = "0x182C43A50")]
		public static bool operator !=(in DisplayItem lhs, in DisplayItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049E2")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60049E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C43860", Offset = "0x2C42260", VA = "0x182C43860", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
