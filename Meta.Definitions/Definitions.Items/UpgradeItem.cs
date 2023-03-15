using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006DC")]
	public readonly struct UpgradeItem : IEquatable<UpgradeItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022D2")]
		internal readonly int UpgradeItemID;

		[Cpp2IlInjected.Token(Token = "0x40022D3")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022D4")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170013AF")]
		public UpgradeItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C83")]
			[Cpp2IlInjected.Address(RVA = "0x17BF760", Offset = "0x17BE160", VA = "0x1817BF760")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B0")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C84")]
			[Cpp2IlInjected.Address(RVA = "0x17BF700", Offset = "0x17BE100", VA = "0x1817BF700")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C85")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public UpgradeItem(int upgradeItemId)
		{
			UpgradeItemID = upgradeItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C86")]
		[Cpp2IlInjected.Address(RVA = "0x17BF680", Offset = "0x17BE080", VA = "0x1817BF680")]
		public UpgradeItem(UpgradeItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (UpgradeItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C87")]
		[Cpp2IlInjected.Address(RVA = "0x17BF490", Offset = "0x17BDE90", VA = "0x1817BF490", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C88")]
		[Cpp2IlInjected.Address(RVA = "0x17BF550", Offset = "0x17BDF50", VA = "0x1817BF550", Slot = "4")]
		public bool Equals(UpgradeItem other)
		{
			int upgradeItemID = other.UpgradeItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C89")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8A")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in UpgradeItem lhs, in UpgradeItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8B")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7D0", Offset = "0x17BE1D0", VA = "0x1817BF7D0")]
		public static bool operator !=(in UpgradeItem lhs, in UpgradeItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8D")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5D0", Offset = "0x17BDFD0", VA = "0x1817BF5D0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
