using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D5")]
	public readonly struct MissionItem : IEquatable<MissionItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022BC")]
		internal readonly int MissionItemID;

		[Cpp2IlInjected.Token(Token = "0x40022BD")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022BE")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x40022BF")]
		public static Item FirstMissionItem = (Item)Convert.ToInt64(2070000620u);

		[Cpp2IlInjected.Token(Token = "0x170013A1")]
		public MissionItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C2F")]
			[Cpp2IlInjected.Address(RVA = "0x1D475E0", Offset = "0x1D45FE0", VA = "0x181D475E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013A2")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C30")]
			[Cpp2IlInjected.Address(RVA = "0x1D47580", Offset = "0x1D45F80", VA = "0x181D47580")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C31")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public MissionItem(int missionItemId)
		{
			MissionItemID = missionItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C32")]
		[Cpp2IlInjected.Address(RVA = "0x1D47500", Offset = "0x1D45F00", VA = "0x181D47500")]
		public MissionItem(MissionItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (MissionItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C33")]
		[Cpp2IlInjected.Address(RVA = "0x1D472E0", Offset = "0x1D45CE0", VA = "0x181D472E0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C34")]
		[Cpp2IlInjected.Address(RVA = "0x1D473A0", Offset = "0x1D45DA0", VA = "0x181D473A0", Slot = "4")]
		public bool Equals(MissionItem other)
		{
			int missionItemID = other.MissionItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C35")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C36")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in MissionItem lhs, in MissionItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C37")]
		[Cpp2IlInjected.Address(RVA = "0x1D47640", Offset = "0x1D46040", VA = "0x181D47640")]
		public static bool operator !=(in MissionItem lhs, in MissionItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C38")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C39")]
		[Cpp2IlInjected.Address(RVA = "0x1D47400", Offset = "0x1D45E00", VA = "0x181D47400", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
