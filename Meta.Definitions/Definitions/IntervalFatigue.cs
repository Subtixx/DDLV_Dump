using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class IntervalFatigue : IFatigue, IMessage<IntervalFatigue>, IMessage, IEquatable<IntervalFatigue>, IDeepCloneable<IntervalFatigue>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly MessageParser<IntervalFatigue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public const int IntervalFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Duration interval_;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[DebuggerNonUserCode]
		public static MessageParser<IntervalFatigue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x27BF460", Offset = "0x27BDE60", VA = "0x1827BF460")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x27BF390", Offset = "0x27BDD90", VA = "0x1827BF390")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x27BF4C0", Offset = "0x27BDEC0", VA = "0x1827BF4C0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[DebuggerNonUserCode]
		public Duration Interval
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return interval_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				interval_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x27BEC60", Offset = "0x27BD660", VA = "0x1827BEC60", Slot = "4")]
		public bool CanRefresh(DateTime lastRefresh, DateTime now)
		{
			//Discarded unreachable code: IL_001c
			TimeSpan timeSpan = now - lastRefresh;
			TimeSpan timeSpan2 = interval_.ToTimeSpan();
			return timeSpan > timeSpan2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x27BF0B0", Offset = "0x27BDAB0", VA = "0x1827BF0B0", Slot = "5")]
		public DateTime NextAutoRefresh(DateTime now)
		{
			//Discarded unreachable code: IL_0014
			TimeSpan timeSpan = interval_.ToTimeSpan();
			return now + timeSpan;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public IntervalFatigue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x27BF320", Offset = "0x27BDD20", VA = "0x1827BF320")]
		[DebuggerNonUserCode]
		public IntervalFatigue(IntervalFatigue other)
		{
			//IL_0021: Expected O, but got I4
			Duration duration = other.interval_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			int num = 0;
			interval_ = (Duration)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x27BED30", Offset = "0x27BD730", VA = "0x1827BED30", Slot = "12")]
		[DebuggerNonUserCode]
		public IntervalFatigue Clone()
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected O, but got I4
			IntervalFatigue intervalFatigue = new IntervalFatigue();
			Duration duration = interval_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			int num = 0;
			intervalFatigue.interval_ = (Duration)num;
			UnknownFieldSet unknownFieldSet = (intervalFatigue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return intervalFatigue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x27BEDD0", Offset = "0x27BD7D0", VA = "0x1827BEDD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(interval_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(IntervalFatigue other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Duration objB = other.interval_;
				if (object.Equals(interval_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Duration duration = interval_;
				if (duration != null)
				{
					int hashCode = duration.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x27BF1B0", Offset = "0x27BDBB0", VA = "0x1827BF1B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)interval_ != 0)
			{
				Duration value = interval_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x27BEBC0", Offset = "0x27BD5C0", VA = "0x1827BEBC0", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2 = default(int);
			UnknownFieldSet unknownFields;
			do
			{
				Duration duration = interval_;
				int num = 0;
				if (duration != null)
				{
					num2 = CodedOutputStream.ComputeMessageSize(duration) + 1;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x27BEF00", Offset = "0x27BD900", VA = "0x1827BEF00", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(IntervalFatigue other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.interval_ != 0)
			{
				Duration duration = interval_;
				if (duration == null)
				{
					Duration duration2 = (interval_ = new Duration());
				}
				Duration other2 = other.interval_;
				duration.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x27BEFD0", Offset = "0x27BD9D0", VA = "0x1827BEFD0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Duration duration = interval_;
				if (duration == null)
				{
					Duration duration2 = (interval_ = new Duration());
				}
				input.ReadMessage(duration);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x27BEE80", Offset = "0x27BD880", VA = "0x1827BEE80", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Duration duration = interval_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x27BF130", Offset = "0x27BDB30", VA = "0x1827BF130", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				interval_ = (Duration)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x27BF210", Offset = "0x27BDC10", VA = "0x1827BF210")]
		static IntervalFatigue()
		{
			Func<IntervalFatigue> func = default(Func<IntervalFatigue>);
			_parser = (MessageParser<IntervalFatigue>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
