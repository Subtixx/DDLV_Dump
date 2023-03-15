using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003C6")]
	public sealed class ConditionalTimestampData : IMessage<ConditionalTimestampData>, IMessage, IEquatable<ConditionalTimestampData>, IDeepCloneable<ConditionalTimestampData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40013E7")]
		private static readonly MessageParser<ConditionalTimestampData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40013E8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40013E9")]
		public const int TimestampFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40013EA")]
		private string timestamp_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000B53")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionalTimestampData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002D10")]
			[Cpp2IlInjected.Address(RVA = "0x24D9A60", Offset = "0x24D8460", VA = "0x1824D9A60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B54")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D11")]
			[Cpp2IlInjected.Address(RVA = "0x24D9990", Offset = "0x24D8390", VA = "0x1824D9990")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B55")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D12")]
			[Cpp2IlInjected.Address(RVA = "0x24D9AC0", Offset = "0x24D84C0", VA = "0x1824D9AC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B56")]
		[DebuggerNonUserCode]
		public string Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6002D16")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return timestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D17")]
			[Cpp2IlInjected.Address(RVA = "0x24D9BD0", Offset = "0x24D85D0", VA = "0x1824D9BD0")]
			set
			{
				string text = (timestamp_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D13")]
		[Cpp2IlInjected.Address(RVA = "0x24D9940", Offset = "0x24D8340", VA = "0x1824D9940")]
		[DebuggerNonUserCode]
		public ConditionalTimestampData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002D14")]
		[Cpp2IlInjected.Address(RVA = "0x24D98A0", Offset = "0x24D82A0", VA = "0x1824D98A0")]
		[DebuggerNonUserCode]
		public ConditionalTimestampData(ConditionalTimestampData other)
		{
			string text = (timestamp_ = other.timestamp_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D15")]
		[Cpp2IlInjected.Address(RVA = "0x24D9390", Offset = "0x24D7D90", VA = "0x1824D9390", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionalTimestampData Clone()
		{
			//Discarded unreachable code: IL_0034
			ConditionalTimestampData conditionalTimestampData = new ConditionalTimestampData();
			conditionalTimestampData.timestamp_ = "";
			string text = (conditionalTimestampData.timestamp_ = timestamp_);
			UnknownFieldSet unknownFieldSet = (conditionalTimestampData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionalTimestampData;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D18")]
		[Cpp2IlInjected.Address(RVA = "0x24D9450", Offset = "0x24D7E50", VA = "0x1824D9450", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = timestamp_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D19")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionalTimestampData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.timestamp_;
				if (!(timestamp_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D1A")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = timestamp_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D1B")]
		[Cpp2IlInjected.Address(RVA = "0x24D9730", Offset = "0x24D8130", VA = "0x1824D9730", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D1C")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (timestamp_.m_stringLength != 0)
			{
				string value = timestamp_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D1D")]
		[Cpp2IlInjected.Address(RVA = "0x24D9260", Offset = "0x24D7C60", VA = "0x1824D9260", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = timestamp_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D1E")]
		[Cpp2IlInjected.Address(RVA = "0x24D9610", Offset = "0x24D8010", VA = "0x1824D9610", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionalTimestampData other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.timestamp_;
				if (text.m_stringLength != 0)
				{
					Timestamp = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D1F")]
		[Cpp2IlInjected.Address(RVA = "0x24D9580", Offset = "0x24D7F80", VA = "0x1824D9580", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Timestamp = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D20")]
		[Cpp2IlInjected.Address(RVA = "0x24D9500", Offset = "0x24D7F00", VA = "0x1824D9500", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = timestamp_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D21")]
		[Cpp2IlInjected.Address(RVA = "0x24D9670", Offset = "0x24D8070", VA = "0x1824D9670", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (timestamp_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D22")]
		[Cpp2IlInjected.Address(RVA = "0x24D9300", Offset = "0x24D7D00", VA = "0x1824D9300", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (timestamp_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D23")]
		[Cpp2IlInjected.Address(RVA = "0x24D9790", Offset = "0x24D8190", VA = "0x1824D9790")]
		static ConditionalTimestampData()
		{
			Func<ConditionalTimestampData> func = default(Func<ConditionalTimestampData>);
			_parser = (MessageParser<ConditionalTimestampData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
