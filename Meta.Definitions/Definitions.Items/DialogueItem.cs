using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200063D")]
	public readonly struct DialogueItem : IEquatable<DialogueItem>, ISubItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400221D")]
		internal readonly int DialogueItemID;

		[Cpp2IlInjected.Token(Token = "0x400221E")]
		private const int DigitsForIDs = 5;

		[Cpp2IlInjected.Token(Token = "0x400221F")]
		private static readonly int ItemTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x17001301")]
		public DialogueItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60049CD")]
			[Cpp2IlInjected.Address(RVA = "0x2C3DB80", Offset = "0x2C3C580", VA = "0x182C3DB80")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001302")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60049CE")]
			[Cpp2IlInjected.Address(RVA = "0x2C3DB20", Offset = "0x2C3C520", VA = "0x182C3DB20")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049CF")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2B0", Offset = "0x6DCCB0", VA = "0x1806DE2B0")]
		public DialogueItem(int dialogueItemId)
		{
			DialogueItemID = dialogueItemId;
		}

		[Cpp2IlInjected.Token(Token = "0x60049D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DAA0", Offset = "0x2C3C4A0", VA = "0x182C3DAA0")]
		public DialogueItem(DialogueItemType itemType, int index)
		{
			int num = (int)itemType;
			num = (DialogueItemID = num + index);
		}

		[Cpp2IlInjected.Token(Token = "0x60049D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D8D0", Offset = "0x2C3C2D0", VA = "0x182C3D8D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60049D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D990", Offset = "0x2C3C390", VA = "0x182C3D990", Slot = "4")]
		public bool Equals(DialogueItem other)
		{
			int dialogueItemID = other.DialogueItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049D3")]
		[Cpp2IlInjected.Address(RVA = "0x17BF5B0", Offset = "0x17BDFB0", VA = "0x1817BF5B0", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60049D4")]
		[Cpp2IlInjected.Address(RVA = "0x17BF7C0", Offset = "0x17BE1C0", VA = "0x1817BF7C0")]
		public static bool operator ==(in DialogueItem lhs, in DialogueItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DBE0", Offset = "0x2C3C5E0", VA = "0x182C3DBE0")]
		public static bool operator !=(in DialogueItem lhs, in DialogueItem rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60049D6")]
		[Cpp2IlInjected.Address(RVA = "0x6DE140", Offset = "0x6DCB40", VA = "0x1806DE140", Slot = "6")]
		public int ToInt()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60049D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D9F0", Offset = "0x2C3C3F0", VA = "0x182C3D9F0", Slot = "5")]
		public Item ToItem()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
