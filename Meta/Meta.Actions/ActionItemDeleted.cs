using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E00")]
	public sealed class ActionItemDeleted : IMessage<ActionItemDeleted>, IMessage, IEquatable<ActionItemDeleted>, IDeepCloneable<ActionItemDeleted>, IMessageFieldAccessor, IAction, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40038D1")]
		private static readonly MessageParser<ActionItemDeleted> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038D2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038D3")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038D4")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x1700146D")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionItemDeleted> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007581")]
			[Cpp2IlInjected.Address(RVA = "0x1E319E0", Offset = "0x1E303E0", VA = "0x181E319E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007582")]
			[Cpp2IlInjected.Address(RVA = "0x1E31800", Offset = "0x1E30200", VA = "0x181E31800")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007583")]
			[Cpp2IlInjected.Address(RVA = "0x1E31A40", Offset = "0x1E30440", VA = "0x181E31A40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001470")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6007587")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007588")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001471")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6007594")]
			[Cpp2IlInjected.Address(RVA = "0x1E31980", Offset = "0x1E30380", VA = "0x181E31980")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001472")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6007596")]
			[Cpp2IlInjected.Address(RVA = "0x1E318D0", Offset = "0x1E302D0", VA = "0x181E318D0", Slot = "15")]
			get
			{
				//IL_0017: Expected O, but got I8
				long num = Convert.ToInt64((uint)itemID_);
				return $"ItemDeleted {num} (Remove all trace of it)";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007584")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActionItemDeleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007585")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ActionItemDeleted(ActionItemDeleted other)
		{
			int num = (itemID_ = other.itemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007586")]
		[Cpp2IlInjected.Address(RVA = "0x1E31180", Offset = "0x1E2FB80", VA = "0x181E31180", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionItemDeleted Clone()
		{
			//Discarded unreachable code: IL_0029
			ActionItemDeleted actionItemDeleted = new ActionItemDeleted();
			int num = (actionItemDeleted.itemID_ = itemID_);
			UnknownFieldSet unknownFieldSet = (actionItemDeleted._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionItemDeleted;
		}

		[Cpp2IlInjected.Token(Token = "0x6007589")]
		[Cpp2IlInjected.Address(RVA = "0x1E314D0", Offset = "0x1E2FED0", VA = "0x181E314D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(ActionItemDeleted).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600758A")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionItemDeleted other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.itemID_;
				if (itemID_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600758B")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600758C")]
		[Cpp2IlInjected.Address(RVA = "0x1E31690", Offset = "0x1E30090", VA = "0x181E31690", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600758D")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (itemID_ != 0)
			{
				int value = itemID_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600758E")]
		[Cpp2IlInjected.Address(RVA = "0x1E310E0", Offset = "0x1E2FAE0", VA = "0x181E310E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = itemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600758F")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionItemDeleted other)
		{
			if (other != null)
			{
				int num = other.itemID_;
				if (num != 0)
				{
					itemID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007590")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (itemID_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007591")]
		[Cpp2IlInjected.Address(RVA = "0x1E31560", Offset = "0x1E2FF60", VA = "0x181E31560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = itemID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007592")]
		[Cpp2IlInjected.Address(RVA = "0x1E31610", Offset = "0x1E30010", VA = "0x181E31610", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				itemID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007593")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				itemID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007595")]
		[Cpp2IlInjected.Address(RVA = "0x1E31070", Offset = "0x1E2FA70", VA = "0x181E31070", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = itemID_;
		}

		[Cpp2IlInjected.Token(Token = "0x6007597")]
		[Cpp2IlInjected.Address(RVA = "0x1E31200", Offset = "0x1E2FC00", VA = "0x181E31200", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0053, IL_0064
			//IL_001c: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = itemID_;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num2 = itemID_;
			ItemEditStatus itemEditStatus = default(ItemEditStatus);
			ItemEditStatus itemEditStatus2 = default(ItemEditStatus);
			if (((Enum)itemEditStatus).HasFlag(itemEditStatus2))
			{
				long num3 = Convert.ToInt64((uint)itemID_);
				ItemType itemType = default(ItemType);
				if (itemType != ItemType.Furniture)
				{
					context.AddInvalidMemberError("Only Furniture are supported for now (WIP)", "Item");
				}
			}
			else
			{
				context.AddInvalidMemberError("Invalid ID, it have not been deleted", "Item");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007598")]
		[Cpp2IlInjected.Address(RVA = "0x1E316F0", Offset = "0x1E300F0", VA = "0x181E316F0")]
		static ActionItemDeleted()
		{
			Func<ActionItemDeleted> func = default(Func<ActionItemDeleted>);
			_parser = (MessageParser<ActionItemDeleted>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
