using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D7")]
	public readonly struct RecurringEventItem : IEquatable<RecurringEventItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022C3")]
		internal readonly int RecurringEventItemID;

		[Cpp2IlInjected.Token(Token = "0x40022C4")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022C5")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170013A5")]
		public RecurringEventType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C47")]
			[Cpp2IlInjected.Address(RVA = "0x2DAB580", Offset = "0x2DA9F80", VA = "0x182DAB580")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013A6")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C48")]
			[Cpp2IlInjected.Address(RVA = "0x2DAB520", Offset = "0x2DA9F20", VA = "0x182DAB520")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C49")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public RecurringEventItem(int recurringEventItemId)
		{
			RecurringEventItemID = recurringEventItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C4A")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB4A0", Offset = "0x2DA9EA0", VA = "0x182DAB4A0")]
		public RecurringEventItem(RecurringEventType itemType, int index)
		{
			int num = (int)itemType;
			num = (RecurringEventItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C4B")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB2D0", Offset = "0x2DA9CD0", VA = "0x182DAB2D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C4C")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB390", Offset = "0x2DA9D90", VA = "0x182DAB390", Slot = "4")]
		public bool Equals(RecurringEventItem other)
		{
			int recurringEventItemID = other.RecurringEventItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C4D")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C4E")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in RecurringEventItem lhs, in RecurringEventItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C4F")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB5E0", Offset = "0x2DA9FE0", VA = "0x182DAB5E0")]
		public static bool operator !=(in RecurringEventItem lhs, in RecurringEventItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C50")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C51")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB3F0", Offset = "0x2DA9DF0", VA = "0x182DAB3F0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
