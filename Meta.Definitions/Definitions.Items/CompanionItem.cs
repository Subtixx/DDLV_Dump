using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000630")]
	public readonly struct CompanionItem : IEquatable<CompanionItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40021FE")]
		internal readonly int CompanionItemID;

		[Cpp2IlInjected.Token(Token = "0x40021FF")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x4002200")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170012E9")]
		public CompanionItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004977")]
			[Cpp2IlInjected.Address(RVA = "0x320EF50", Offset = "0x320D950", VA = "0x18320EF50")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012EA")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004978")]
			[Cpp2IlInjected.Address(RVA = "0x320EEF0", Offset = "0x320D8F0", VA = "0x18320EEF0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004979")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public CompanionItem(int companionItemID)
		{
			CompanionItemID = companionItemID;
		}

		[Cpp2IlInjected.Token(Token = "0x600497A")]
		[Cpp2IlInjected.Address(RVA = "0x320EE70", Offset = "0x320D870", VA = "0x18320EE70")]
		public CompanionItem(CompanionItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (CompanionItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x600497B")]
		[Cpp2IlInjected.Address(RVA = "0x320ECA0", Offset = "0x320D6A0", VA = "0x18320ECA0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600497C")]
		[Cpp2IlInjected.Address(RVA = "0x320ED60", Offset = "0x320D760", VA = "0x18320ED60", Slot = "4")]
		public bool Equals(CompanionItem other)
		{
			int companionItemID = other.CompanionItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600497D")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600497E")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in CompanionItem lhs, in CompanionItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600497F")]
		[Cpp2IlInjected.Address(RVA = "0x320EFB0", Offset = "0x320D9B0", VA = "0x18320EFB0")]
		public static bool operator !=(in CompanionItem lhs, in CompanionItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004980")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004981")]
		[Cpp2IlInjected.Address(RVA = "0x320EDC0", Offset = "0x320D7C0", VA = "0x18320EDC0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
