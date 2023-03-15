using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000641")]
	public struct FurnitureItem : ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002229")]
		internal readonly int FurnitureItemID;

		[Cpp2IlInjected.Token(Token = "0x400222A")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x400222B")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x17001309")]
		public FurnitureItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60049FD")]
			[Cpp2IlInjected.Address(RVA = "0x344C890", Offset = "0x344B290", VA = "0x18344C890")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700130A")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60049FE")]
			[Cpp2IlInjected.Address(RVA = "0x344C830", Offset = "0x344B230", VA = "0x18344C830")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049FF")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public FurnitureItem(int furnitureItemId)
		{
			FurnitureItemID = furnitureItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A00")]
		[Cpp2IlInjected.Address(RVA = "0x344C7B0", Offset = "0x344B1B0", VA = "0x18344C7B0")]
		public FurnitureItem(FurnitureItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (FurnitureItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A01")]
		[Cpp2IlInjected.Address(RVA = "0x344C640", Offset = "0x344B040", VA = "0x18344C640", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004A02")]
		[Cpp2IlInjected.Address(RVA = "0x344C5E0", Offset = "0x344AFE0", VA = "0x18344C5E0")]
		public bool Equals(FurnitureItem other)
		{
			int furnitureItemID = other.FurnitureItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A03")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A04")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in FurnitureItem lhs, in FurnitureItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A05")]
		[Cpp2IlInjected.Address(RVA = "0x344C8F0", Offset = "0x344B2F0", VA = "0x18344C8F0")]
		public static bool operator !=(in FurnitureItem lhs, in FurnitureItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A06")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "5")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A07")]
		[Cpp2IlInjected.Address(RVA = "0x344C700", Offset = "0x344B100", VA = "0x18344C700", Slot = "4")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
