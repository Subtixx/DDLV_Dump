using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D8")]
	public readonly struct SetItem : IEquatable<SetItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022C6")]
		internal readonly int SetItemID;

		[Cpp2IlInjected.Token(Token = "0x40022C7")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022C8")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170013A7")]
		public SetItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C53")]
			[Cpp2IlInjected.Address(RVA = "0x384CBF0", Offset = "0x384B5F0", VA = "0x18384CBF0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013A8")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C54")]
			[Cpp2IlInjected.Address(RVA = "0x384CB90", Offset = "0x384B590", VA = "0x18384CB90")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C55")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public SetItem(int setItemId)
		{
			SetItemID = setItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C56")]
		[Cpp2IlInjected.Address(RVA = "0x384CB10", Offset = "0x384B510", VA = "0x18384CB10")]
		public SetItem(SetItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (SetItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C57")]
		[Cpp2IlInjected.Address(RVA = "0x384C9A0", Offset = "0x384B3A0", VA = "0x18384C9A0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C58")]
		[Cpp2IlInjected.Address(RVA = "0x384C940", Offset = "0x384B340", VA = "0x18384C940", Slot = "4")]
		public bool Equals(SetItem other)
		{
			int setItemID = other.SetItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C59")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5A")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in SetItem lhs, in SetItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5B")]
		[Cpp2IlInjected.Address(RVA = "0x384CC50", Offset = "0x384B650", VA = "0x18384CC50")]
		public static bool operator !=(in SetItem lhs, in SetItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5D")]
		[Cpp2IlInjected.Address(RVA = "0x384CA60", Offset = "0x384B460", VA = "0x18384CA60", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
