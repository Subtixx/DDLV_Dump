using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010D5")]
	public sealed class DutyList : IMessage<DutyList>, IMessage, IEquatable<DutyList>, IDeepCloneable<DutyList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400454A")]
		private static readonly MessageParser<DutyList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400454B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400454C")]
		public const int SlotsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400454D")]
		private static readonly FieldCodec<DutySlot> _repeated_slots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400454E")]
		private readonly RepeatedField<DutySlot> slots_ = (RepeatedField<DutySlot>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170017A6")]
		[DebuggerNonUserCode]
		public static MessageParser<DutyList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008879")]
			[Cpp2IlInjected.Address(RVA = "0x17409A0", Offset = "0x173F3A0", VA = "0x1817409A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600887A")]
			[Cpp2IlInjected.Address(RVA = "0x17408D0", Offset = "0x173F2D0", VA = "0x1817408D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600887B")]
			[Cpp2IlInjected.Address(RVA = "0x1740A00", Offset = "0x173F400", VA = "0x181740A00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A9")]
		[DebuggerNonUserCode]
		public RepeatedField<DutySlot> Slots
		{
			[Cpp2IlInjected.Token(Token = "0x600887F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600887C")]
		[Cpp2IlInjected.Address(RVA = "0x1740850", Offset = "0x173F250", VA = "0x181740850")]
		[DebuggerNonUserCode]
		public DutyList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600887D")]
		[Cpp2IlInjected.Address(RVA = "0x1740750", Offset = "0x173F150", VA = "0x181740750")]
		[DebuggerNonUserCode]
		public DutyList(DutyList other)
		{
			RepeatedField<DutySlot> repeatedField = (slots_ = (RepeatedField<DutySlot>)(object)((RepeatedField<T>)(object)other.slots_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600887E")]
		[Cpp2IlInjected.Address(RVA = "0x173FF70", Offset = "0x173E970", VA = "0x18173FF70", Slot = "10")]
		[DebuggerNonUserCode]
		public DutyList Clone()
		{
			//Discarded unreachable code: IL_003b
			DutyList dutyList = new DutyList();
			RepeatedField<DutySlot> repeatedField = (dutyList.slots_ = (RepeatedField<DutySlot>)(object)new RepeatedField<T>());
			RepeatedField<DutySlot> repeatedField2 = (dutyList.slots_ = (RepeatedField<DutySlot>)(object)((RepeatedField<T>)(object)slots_).Clone());
			UnknownFieldSet unknownFieldSet = (dutyList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return dutyList;
		}

		[Cpp2IlInjected.Token(Token = "0x6008880")]
		[Cpp2IlInjected.Address(RVA = "0x17400A0", Offset = "0x173EAA0", VA = "0x1817400A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<DutySlot> repeatedField = slots_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008881")]
		[Cpp2IlInjected.Address(RVA = "0x1740180", Offset = "0x173EB80", VA = "0x181740180", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DutyList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<DutySlot> repeatedField = slots_;
				RepeatedField<DutySlot> repeatedField2 = other.slots_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008882")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)slots_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6008883")]
		[Cpp2IlInjected.Address(RVA = "0x1740460", Offset = "0x173EE60", VA = "0x181740460", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008884")]
		[Cpp2IlInjected.Address(RVA = "0x17404C0", Offset = "0x173EEC0", VA = "0x1817404C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<DutySlot> repeatedField = slots_;
			FieldCodec<DutySlot> repeated_slots_codec = _repeated_slots_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_slots_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008885")]
		[Cpp2IlInjected.Address(RVA = "0x173FE60", Offset = "0x173E860", VA = "0x18173FE60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<DutySlot> repeatedField = slots_;
			FieldCodec<DutySlot> repeated_slots_codec = _repeated_slots_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_slots_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008886")]
		[Cpp2IlInjected.Address(RVA = "0x1740290", Offset = "0x173EC90", VA = "0x181740290", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DutyList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<DutySlot> repeatedField = slots_;
				RepeatedField<DutySlot> repeatedField2 = other.slots_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008887")]
		[Cpp2IlInjected.Address(RVA = "0x1740310", Offset = "0x173ED10", VA = "0x181740310", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<DutySlot> repeatedField = slots_;
					FieldCodec<DutySlot> repeated_slots_codec = _repeated_slots_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slots_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008888")]
		[Cpp2IlInjected.Address(RVA = "0x1740210", Offset = "0x173EC10", VA = "0x181740210", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<DutySlot> repeatedField = slots_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008889")]
		[Cpp2IlInjected.Address(RVA = "0x1740400", Offset = "0x173EE00", VA = "0x181740400", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600888A")]
		[Cpp2IlInjected.Address(RVA = "0x173FF10", Offset = "0x173E910", VA = "0x18173FF10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<DutySlot> repeatedField = slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600888B")]
		[Cpp2IlInjected.Address(RVA = "0x1740580", Offset = "0x173EF80", VA = "0x181740580")]
		static DutyList()
		{
			Func<DutyList> func = default(Func<DutyList>);
			_parser = (MessageParser<DutyList>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<DutySlot> parser = DutySlot._parser;
			uint num = default(uint);
			_parser = (MessageParser<DutyList>)(object)FieldCodec.ForMessage<DutySlot>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
