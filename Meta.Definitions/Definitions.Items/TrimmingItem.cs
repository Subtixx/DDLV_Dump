using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006DB")]
	public readonly struct TrimmingItem : IEquatable<TrimmingItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022CF")]
		internal readonly int TrimmingItemID;

		[Cpp2IlInjected.Token(Token = "0x40022D0")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022D1")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170013AD")]
		public TrimmingItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C77")]
			[Cpp2IlInjected.Address(RVA = "0x3551E40", Offset = "0x3550840", VA = "0x183551E40")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013AE")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C78")]
			[Cpp2IlInjected.Address(RVA = "0x3551DE0", Offset = "0x35507E0", VA = "0x183551DE0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C79")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public TrimmingItem(int trimmingItemId)
		{
			TrimmingItemID = trimmingItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3551D60", Offset = "0x3550760", VA = "0x183551D60")]
		public TrimmingItem(TrimmingItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (TrimmingItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C7B")]
		[Cpp2IlInjected.Address(RVA = "0x3551B90", Offset = "0x3550590", VA = "0x183551B90", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C7C")]
		[Cpp2IlInjected.Address(RVA = "0x3551C50", Offset = "0x3550650", VA = "0x183551C50", Slot = "4")]
		public bool Equals(TrimmingItem other)
		{
			int trimmingItemID = other.TrimmingItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C7D")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C7E")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in TrimmingItem lhs, in TrimmingItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C7F")]
		[Cpp2IlInjected.Address(RVA = "0x3551EA0", Offset = "0x35508A0", VA = "0x183551EA0")]
		public static bool operator !=(in TrimmingItem lhs, in TrimmingItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C80")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C81")]
		[Cpp2IlInjected.Address(RVA = "0x3551CB0", Offset = "0x35506B0", VA = "0x183551CB0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
