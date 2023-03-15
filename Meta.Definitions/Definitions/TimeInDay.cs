using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public sealed class TimeInDay : IMessage<TimeInDay>, IMessage, IEquatable<TimeInDay>, IDeepCloneable<TimeInDay>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private static readonly MessageParser<TimeInDay> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public const int HourFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private int hour_;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public const int MinuteFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private int minute_;

		[Cpp2IlInjected.Token(Token = "0x170002A0")]
		[DebuggerNonUserCode]
		public static MessageParser<TimeInDay> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADD")]
			[Cpp2IlInjected.Address(RVA = "0x3547D30", Offset = "0x3546730", VA = "0x183547D30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADE")]
			[Cpp2IlInjected.Address(RVA = "0x3547C60", Offset = "0x3546660", VA = "0x183547C60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADF")]
			[Cpp2IlInjected.Address(RVA = "0x3547E90", Offset = "0x3546890", VA = "0x183547E90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A3")]
		[DebuggerNonUserCode]
		public int Hour
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return hour_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				hour_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A4")]
		[DebuggerNonUserCode]
		public int Minute
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE5")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return minute_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE6")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				minute_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		public TimeSpan ToTimeSpan
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF2")]
			[Cpp2IlInjected.Address(RVA = "0x3547D90", Offset = "0x3546790", VA = "0x183547D90")]
			get
			{
				//IL_0014: Expected I8, but got I4
				int num = hour_;
				int num2 = minute_;
				long num3 = num * 60;
				num3 += num2;
				TimeSpan result = default(TimeSpan);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		public float TotalDays
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF3")]
			[Cpp2IlInjected.Address(RVA = "0x3547E00", Offset = "0x3546800", VA = "0x183547E00")]
			get
			{
				//IL_0014: Expected I8, but got I4
				int num = hour_;
				int num2 = minute_;
				long num3 = num * 60;
				num3 += num2;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public TimeInDay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public TimeInDay(TimeInDay other)
		{
			int num = (hour_ = other.hour_);
			int num2 = (minute_ = other.minute_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x3547730", Offset = "0x3546130", VA = "0x183547730", Slot = "10")]
		[DebuggerNonUserCode]
		public TimeInDay Clone()
		{
			//Discarded unreachable code: IL_0037
			TimeInDay timeInDay = new TimeInDay();
			int num = (timeInDay.hour_ = hour_);
			int num2 = (timeInDay.minute_ = minute_);
			UnknownFieldSet unknownFieldSet = (timeInDay._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return timeInDay;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x35477C0", Offset = "0x35461C0", VA = "0x1835477C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)hour_ == (IntPtr)typeof(TimeInDay).TypeHandle && (IntPtr)minute_ == (IntPtr)typeof(TimeInDay).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TimeInDay other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.hour_;
				if (hour_ == num)
				{
					int num2 = other.minute_;
					if (minute_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (hour_ != 0)
				{
				}
				if (minute_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x3547A60", Offset = "0x3546460", VA = "0x183547A60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x3547AC0", Offset = "0x35464C0", VA = "0x183547AC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (hour_ != 0)
			{
				int value = hour_;
				output.WriteInt32(value);
			}
			if (minute_ != 0)
			{
				int value2 = minute_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x3547640", Offset = "0x3546040", VA = "0x183547640", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = hour_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = minute_;
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

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TimeInDay other)
		{
			if (other != null)
			{
				int num = other.hour_;
				if (num != 0)
				{
					hour_ = num;
				}
				int num2 = other.minute_;
				if (num2 != 0)
				{
					minute_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x3547910", Offset = "0x3546310", VA = "0x183547910", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 16)
				{
					int num2 = (hour_ = input.ReadInt32());
				}
				if (num == 24)
				{
					int num3 = (minute_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x3547850", Offset = "0x3546250", VA = "0x183547850", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 2)
			{
				int num = hour_;
			}
			if (fieldNumber == 3)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x35479A0", Offset = "0x35463A0", VA = "0x1835479A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 2)
			{
				object obj = default(object);
				hour_ = (int)obj;
				return;
			}
			while (fieldNumber != 3)
			{
			}
			object obj2 = default(object);
			minute_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x3547710", Offset = "0x3546110", VA = "0x183547710", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 2:
				hour_ = 0;
				break;
			case 3:
				minute_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x3547B50", Offset = "0x3546550", VA = "0x183547B50")]
		static TimeInDay()
		{
			Func<TimeInDay> func = default(Func<TimeInDay>);
			_parser = (MessageParser<TimeInDay>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
