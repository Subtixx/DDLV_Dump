using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200062C")]
	public readonly struct ActivityDataItem : IEquatable<ActivityDataItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40021EC")]
		internal readonly int ActivityDataItemID;

		[Cpp2IlInjected.Token(Token = "0x40021ED")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40021EE")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170012E1")]
		public ActivityDataItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004942")]
			[Cpp2IlInjected.Address(RVA = "0x3156870", Offset = "0x3155270", VA = "0x183156870")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012E2")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004943")]
			[Cpp2IlInjected.Address(RVA = "0x3156810", Offset = "0x3155210", VA = "0x183156810")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004944")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public ActivityDataItem(int activityDataItemId)
		{
			ActivityDataItemID = activityDataItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004945")]
		[Cpp2IlInjected.Address(RVA = "0x3156790", Offset = "0x3155190", VA = "0x183156790")]
		public ActivityDataItem(ActivityDataItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (ActivityDataItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004946")]
		[Cpp2IlInjected.Address(RVA = "0x31565C0", Offset = "0x3154FC0", VA = "0x1831565C0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004947")]
		[Cpp2IlInjected.Address(RVA = "0x3156680", Offset = "0x3155080", VA = "0x183156680", Slot = "4")]
		public bool Equals(ActivityDataItem other)
		{
			int activityDataItemID = other.ActivityDataItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004948")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004949")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in ActivityDataItem lhs, in ActivityDataItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600494A")]
		[Cpp2IlInjected.Address(RVA = "0x31568D0", Offset = "0x31552D0", VA = "0x1831568D0")]
		public static bool operator !=(in ActivityDataItem lhs, in ActivityDataItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600494B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600494C")]
		[Cpp2IlInjected.Address(RVA = "0x31566E0", Offset = "0x31550E0", VA = "0x1831566E0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
