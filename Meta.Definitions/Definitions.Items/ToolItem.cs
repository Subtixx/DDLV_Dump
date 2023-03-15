using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006DA")]
	public readonly struct ToolItem : IEquatable<ToolItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40022CC")]
		internal readonly int ToolID;

		[Cpp2IlInjected.Token(Token = "0x40022CD")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x40022CE")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x170013AB")]
		public ToolItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004C6B")]
			[Cpp2IlInjected.Address(RVA = "0x354CA40", Offset = "0x354B440", VA = "0x18354CA40")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013AC")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C6C")]
			[Cpp2IlInjected.Address(RVA = "0x354C9E0", Offset = "0x354B3E0", VA = "0x18354C9E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C6D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public ToolItem(int toolId)
		{
			ToolID = toolId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C6E")]
		[Cpp2IlInjected.Address(RVA = "0x354C960", Offset = "0x354B360", VA = "0x18354C960")]
		public ToolItem(ToolItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (ToolID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C6F")]
		[Cpp2IlInjected.Address(RVA = "0x354C790", Offset = "0x354B190", VA = "0x18354C790", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C70")]
		[Cpp2IlInjected.Address(RVA = "0x354C850", Offset = "0x354B250", VA = "0x18354C850", Slot = "4")]
		public bool Equals(ToolItem other)
		{
			int toolID = other.ToolID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C71")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C72")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in ToolItem lhs, in ToolItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C73")]
		[Cpp2IlInjected.Address(RVA = "0x354CAA0", Offset = "0x354B4A0", VA = "0x18354CAA0")]
		public static bool operator !=(in ToolItem lhs, in ToolItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C74")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004C75")]
		[Cpp2IlInjected.Address(RVA = "0x354C8B0", Offset = "0x354B2B0", VA = "0x18354C8B0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
