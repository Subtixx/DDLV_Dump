using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D6")]
	public readonly struct PreferenceItem : IEquatable<PreferenceItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022C0")]
		internal readonly int PreferenceItemID;

		[Cpp2IlInjected.Token(Token = "0x40022C1")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022C2")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170013A3")]
		public PreferenceItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C3B")]
			[Cpp2IlInjected.Address(RVA = "0x287B400", Offset = "0x2879E00", VA = "0x18287B400")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013A4")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C3C")]
			[Cpp2IlInjected.Address(RVA = "0x287B3A0", Offset = "0x2879DA0", VA = "0x18287B3A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C3D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public PreferenceItem(int preferenceItemId)
		{
			PreferenceItemID = preferenceItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C3E")]
		[Cpp2IlInjected.Address(RVA = "0x287B320", Offset = "0x2879D20", VA = "0x18287B320")]
		public PreferenceItem(PreferenceItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (PreferenceItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C3F")]
		[Cpp2IlInjected.Address(RVA = "0x287B150", Offset = "0x2879B50", VA = "0x18287B150", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C40")]
		[Cpp2IlInjected.Address(RVA = "0x287B210", Offset = "0x2879C10", VA = "0x18287B210", Slot = "4")]
		public bool Equals(PreferenceItem other)
		{
			int preferenceItemID = other.PreferenceItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C41")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C42")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in PreferenceItem lhs, in PreferenceItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C43")]
		[Cpp2IlInjected.Address(RVA = "0x287B460", Offset = "0x2879E60", VA = "0x18287B460")]
		public static bool operator !=(in PreferenceItem lhs, in PreferenceItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C44")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C45")]
		[Cpp2IlInjected.Address(RVA = "0x287B270", Offset = "0x2879C70", VA = "0x18287B270", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
