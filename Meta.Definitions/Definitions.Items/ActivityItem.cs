using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200062D")]
	public readonly struct ActivityItem : IEquatable<ActivityItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40021EF")]
		internal readonly int ActivityItemID;

		[Cpp2IlInjected.Token(Token = "0x40021F0")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40021F1")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170012E3")]
		public ActivityItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600494E")]
			[Cpp2IlInjected.Address(RVA = "0x3159A70", Offset = "0x3158470", VA = "0x183159A70")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012E4")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600494F")]
			[Cpp2IlInjected.Address(RVA = "0x3159A10", Offset = "0x3158410", VA = "0x183159A10")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004950")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public ActivityItem(int activityItemId)
		{
			ActivityItemID = activityItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004951")]
		[Cpp2IlInjected.Address(RVA = "0x3159990", Offset = "0x3158390", VA = "0x183159990")]
		public ActivityItem(ActivityItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (ActivityItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004952")]
		[Cpp2IlInjected.Address(RVA = "0x31597C0", Offset = "0x31581C0", VA = "0x1831597C0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004953")]
		[Cpp2IlInjected.Address(RVA = "0x3159880", Offset = "0x3158280", VA = "0x183159880", Slot = "4")]
		public bool Equals(ActivityItem other)
		{
			int activityItemID = other.ActivityItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004954")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004955")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in ActivityItem lhs, in ActivityItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004956")]
		[Cpp2IlInjected.Address(RVA = "0x3159AD0", Offset = "0x31584D0", VA = "0x183159AD0")]
		public static bool operator !=(in ActivityItem lhs, in ActivityItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004957")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004958")]
		[Cpp2IlInjected.Address(RVA = "0x31598E0", Offset = "0x31582E0", VA = "0x1831598E0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
