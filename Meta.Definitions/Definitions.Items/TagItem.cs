using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D9")]
	public readonly struct TagItem : IEquatable<TagItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022C9")]
		internal readonly int TagItemID;

		[Cpp2IlInjected.Token(Token = "0x40022CA")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022CB")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170013A9")]
		public TagItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C5F")]
			[Cpp2IlInjected.Address(RVA = "0x25644C0", Offset = "0x2562EC0", VA = "0x1825644C0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013AA")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C60")]
			[Cpp2IlInjected.Address(RVA = "0x2564460", Offset = "0x2562E60", VA = "0x182564460")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C61")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public TagItem(int tagItemId)
		{
			TagItemID = tagItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C62")]
		[Cpp2IlInjected.Address(RVA = "0x25643E0", Offset = "0x2562DE0", VA = "0x1825643E0")]
		public TagItem(TagItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (TagItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C63")]
		[Cpp2IlInjected.Address(RVA = "0x2564270", Offset = "0x2562C70", VA = "0x182564270", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C64")]
		[Cpp2IlInjected.Address(RVA = "0x2564210", Offset = "0x2562C10", VA = "0x182564210", Slot = "4")]
		public bool Equals(TagItem other)
		{
			int tagItemID = other.TagItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C65")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C66")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in TagItem lhs, in TagItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C67")]
		[Cpp2IlInjected.Address(RVA = "0x2564520", Offset = "0x2562F20", VA = "0x182564520")]
		public static bool operator !=(in TagItem lhs, in TagItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C68")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C69")]
		[Cpp2IlInjected.Address(RVA = "0x2564330", Offset = "0x2562D30", VA = "0x182564330", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
