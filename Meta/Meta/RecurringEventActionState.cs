using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008FE")]
	public sealed class RecurringEventActionState : IMessage<RecurringEventActionState>, IMessage, IEquatable<RecurringEventActionState>, IDeepCloneable<RecurringEventActionState>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400246F")]
		private static readonly MessageParser<RecurringEventActionState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002470")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002471")]
		public const int RecurringEventIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002472")]
		private uint recurringEventID_;

		[Cpp2IlInjected.Token(Token = "0x17000D4B")]
		[DebuggerNonUserCode]
		public static MessageParser<RecurringEventActionState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E1C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C70", Offset = "0x5C1670", VA = "0x1805C2C70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E1D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2BA0", Offset = "0x5C15A0", VA = "0x1805C2BA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E1E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CE0", Offset = "0x5C16E0", VA = "0x1805C2CE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4E")]
		[DebuggerNonUserCode]
		public uint RecurringEventID
		{
			[Cpp2IlInjected.Token(Token = "0x6004E22")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recurringEventID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E23")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recurringEventID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E1F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public RecurringEventActionState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E20")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public RecurringEventActionState(RecurringEventActionState other)
		{
			uint num = (recurringEventID_ = other.recurringEventID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E21")]
		[Cpp2IlInjected.Address(RVA = "0x5C25D0", Offset = "0x5C0FD0", VA = "0x1805C25D0", Slot = "10")]
		[DebuggerNonUserCode]
		public RecurringEventActionState Clone()
		{
			//Discarded unreachable code: IL_0029
			RecurringEventActionState recurringEventActionState = new RecurringEventActionState();
			uint num = (recurringEventActionState.recurringEventID_ = recurringEventID_);
			UnknownFieldSet unknownFieldSet = (recurringEventActionState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return recurringEventActionState;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E24")]
		[Cpp2IlInjected.Address(RVA = "0x5C2650", Offset = "0x5C1050", VA = "0x1805C2650", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(int)recurringEventID_ == (IntPtr)typeof(RecurringEventActionState).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E25")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RecurringEventActionState other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.recurringEventID_;
				if (recurringEventID_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E26")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (recurringEventID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E27")]
		[Cpp2IlInjected.Address(RVA = "0x5C2980", Offset = "0x5C1380", VA = "0x1805C2980", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E28")]
		[Cpp2IlInjected.Address(RVA = "0x5C29E0", Offset = "0x5C13E0", VA = "0x1805C29E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002b
			if (recurringEventID_ != 0)
			{
				uint value = recurringEventID_;
				output.WriteUInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E29")]
		[Cpp2IlInjected.Address(RVA = "0x5C2520", Offset = "0x5C0F20", VA = "0x1805C2520", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				uint num = recurringEventID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeUInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2A")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RecurringEventActionState other)
		{
			if (other != null)
			{
				uint num = other.recurringEventID_;
				if (num != 0)
				{
					recurringEventID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2B")]
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
					int num2 = (int)(recurringEventID_ = (uint)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2C")]
		[Cpp2IlInjected.Address(RVA = "0x5C2710", Offset = "0x5C1110", VA = "0x1805C2710", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				uint num = recurringEventID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2D")]
		[Cpp2IlInjected.Address(RVA = "0x5C2900", Offset = "0x5C1300", VA = "0x1805C2900", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				recurringEventID_ = (uint)(int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2E")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				recurringEventID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2F")]
		[Cpp2IlInjected.Address(RVA = "0x5C2A40", Offset = "0x5C1440", VA = "0x1805C2A40")]
		static RecurringEventActionState()
		{
			Func<RecurringEventActionState> func = default(Func<RecurringEventActionState>);
			_parser = (MessageParser<RecurringEventActionState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
