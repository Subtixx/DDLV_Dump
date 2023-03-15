using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public sealed class TimeOfDay : IMessage<TimeOfDay>, IMessage, IEquatable<TimeOfDay>, IDeepCloneable<TimeOfDay>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly MessageParser<TimeOfDay> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public const int StartFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private int start_;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public const int EndFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private int end_;

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		[DebuggerNonUserCode]
		public static MessageParser<TimeOfDay> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0x3549190", Offset = "0x3547B90", VA = "0x183549190")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC3")]
			[Cpp2IlInjected.Address(RVA = "0x35490C0", Offset = "0x3547AC0", VA = "0x1835490C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0x35491F0", Offset = "0x3547BF0", VA = "0x1835491F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		[DebuggerNonUserCode]
		public int Start
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return start_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				start_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		[DebuggerNonUserCode]
		public int End
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACA")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return end_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACB")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				end_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public TimeOfDay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public TimeOfDay(TimeOfDay other)
		{
			int num = (start_ = other.start_);
			int num2 = (end_ = other.end_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(RVA = "0x3548BE0", Offset = "0x35475E0", VA = "0x183548BE0", Slot = "10")]
		[DebuggerNonUserCode]
		public TimeOfDay Clone()
		{
			//Discarded unreachable code: IL_0037
			TimeOfDay timeOfDay = new TimeOfDay();
			int num = (timeOfDay.start_ = start_);
			int num2 = (timeOfDay.end_ = end_);
			UnknownFieldSet unknownFieldSet = (timeOfDay._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return timeOfDay;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x3548CE0", Offset = "0x35476E0", VA = "0x183548CE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)start_ == (IntPtr)typeof(TimeOfDay).TypeHandle && (IntPtr)end_ == (IntPtr)typeof(TimeOfDay).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TimeOfDay other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.start_;
				if (start_ == num)
				{
					int num2 = other.end_;
					if (end_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (start_ != 0)
				{
				}
				if (end_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x3548F50", Offset = "0x3547950", VA = "0x183548F50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (start_ != 0)
			{
				int value = start_;
				output.WriteInt32(value);
			}
			if (end_ != 0)
			{
				int value2 = end_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x3548B10", Offset = "0x3547510", VA = "0x183548B10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = start_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = end_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TimeOfDay other)
		{
			if (other != null)
			{
				int num = other.start_;
				if (num != 0)
				{
					start_ = num;
				}
				int num2 = other.end_;
				if (num2 != 0)
				{
					end_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (start_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (end_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3548D70", Offset = "0x3547770", VA = "0x183548D70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = start_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3548E90", Offset = "0x3547890", VA = "0x183548E90", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				start_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			end_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				start_ = 0;
				break;
			case 2:
				end_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x3548E30", Offset = "0x3547830", VA = "0x183548E30")]
		public bool IsTimeWithinInterval(DateTime time)
		{
			//Discarded unreachable code: IL_001e, IL_0022
			int num = end_;
			int num2 = start_;
			int num3 = default(int);
			if (num3 < num)
			{
				return true;
			}
			return num3 >= num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x3548C70", Offset = "0x3547670", VA = "0x183548C70", Slot = "14")]
		void IDataValidation.DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0021
			int num = end_;
			if (start_ == num)
			{
				context.AddInvalidMemberError("Start cannot be equal to End", "Start");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x3548FB0", Offset = "0x35479B0", VA = "0x183548FB0")]
		static TimeOfDay()
		{
			Func<TimeOfDay> func = default(Func<TimeOfDay>);
			_parser = (MessageParser<TimeOfDay>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
