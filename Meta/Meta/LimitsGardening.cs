using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000887")]
	public sealed class LimitsGardening : IMessage<LimitsGardening>, IMessage, IEquatable<LimitsGardening>, IDeepCloneable<LimitsGardening>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002242")]
		private static readonly MessageParser<LimitsGardening> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002243")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002244")]
		public const int LastDailyResetFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002245")]
		private Timestamp lastDailyReset_;

		[Cpp2IlInjected.Token(Token = "0x4002246")]
		public const int DailySellFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002247")]
		private int dailySell_;

		[Cpp2IlInjected.Token(Token = "0x17000BF8")]
		[DebuggerNonUserCode]
		public static MessageParser<LimitsGardening> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004823")]
			[Cpp2IlInjected.Address(RVA = "0x18A5FB0", Offset = "0x18A49B0", VA = "0x1818A5FB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004824")]
			[Cpp2IlInjected.Address(RVA = "0x18A5EE0", Offset = "0x18A48E0", VA = "0x1818A5EE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004825")]
			[Cpp2IlInjected.Address(RVA = "0x18A6010", Offset = "0x18A4A10", VA = "0x1818A6010", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFB")]
		[DebuggerNonUserCode]
		public Timestamp LastDailyReset
		{
			[Cpp2IlInjected.Token(Token = "0x6004829")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return lastDailyReset_;
			}
			[Cpp2IlInjected.Token(Token = "0x600482A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				lastDailyReset_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFC")]
		[DebuggerNonUserCode]
		public int DailySell
		{
			[Cpp2IlInjected.Token(Token = "0x600482B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return dailySell_;
			}
			[Cpp2IlInjected.Token(Token = "0x600482C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				dailySell_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004826")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LimitsGardening()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004827")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B00", Offset = "0x7B1500", VA = "0x1807B2B00")]
		[DebuggerNonUserCode]
		public LimitsGardening(LimitsGardening other)
		{
			//IL_0021: Expected O, but got I4
			Timestamp timestamp = other.lastDailyReset_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			lastDailyReset_ = (Timestamp)num;
			int num2 = (dailySell_ = other.dailySell_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004828")]
		[Cpp2IlInjected.Address(RVA = "0x18A58A0", Offset = "0x18A42A0", VA = "0x1818A58A0", Slot = "10")]
		[DebuggerNonUserCode]
		public LimitsGardening Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0021: Expected O, but got I4
			LimitsGardening limitsGardening = new LimitsGardening();
			Timestamp timestamp = lastDailyReset_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			limitsGardening.lastDailyReset_ = (Timestamp)num;
			int num2 = (limitsGardening.dailySell_ = dailySell_);
			UnknownFieldSet unknownFieldSet = (limitsGardening._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return limitsGardening;
		}

		[Cpp2IlInjected.Token(Token = "0x600482D")]
		[Cpp2IlInjected.Address(RVA = "0x18A5950", Offset = "0x18A4350", VA = "0x1818A5950", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(lastDailyReset_, other);
				if (flag && dailySell_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600482E")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LimitsGardening other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.lastDailyReset_;
				if (object.Equals(lastDailyReset_, objB))
				{
					int num = other.dailySell_;
					if (dailySell_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600482F")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = lastDailyReset_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				if (dailySell_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004830")]
		[Cpp2IlInjected.Address(RVA = "0x18A5D70", Offset = "0x18A4770", VA = "0x1818A5D70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004831")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)lastDailyReset_ != 0)
			{
				Timestamp value = lastDailyReset_;
				output.WriteMessage(value);
			}
			if (dailySell_ != 0)
			{
				int value2 = dailySell_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004832")]
		[Cpp2IlInjected.Address(RVA = "0x18A57D0", Offset = "0x18A41D0", VA = "0x1818A57D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = lastDailyReset_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				}
				int num3 = dailySell_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004833")]
		[Cpp2IlInjected.Address(RVA = "0x18A5AD0", Offset = "0x18A44D0", VA = "0x1818A5AD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LimitsGardening other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.lastDailyReset_ != 0)
			{
				Timestamp timestamp = lastDailyReset_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastDailyReset_ = new Timestamp());
				}
				Timestamp other2 = other.lastDailyReset_;
				timestamp.MergeFrom(other2);
			}
			int num = other.dailySell_;
			if (num != 0)
			{
				dailySell_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004834")]
		[Cpp2IlInjected.Address(RVA = "0x18A5BB0", Offset = "0x18A45B0", VA = "0x1818A5BB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Timestamp timestamp = lastDailyReset_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastDailyReset_ = new Timestamp());
				}
				input.ReadMessage(timestamp);
			}
			if (num == 16)
			{
				int num2 = (dailySell_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004835")]
		[Cpp2IlInjected.Address(RVA = "0x18A5A00", Offset = "0x18A4400", VA = "0x1818A5A00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = lastDailyReset_;
			}
			if (fieldNumber == 2)
			{
				int num = dailySell_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004836")]
		[Cpp2IlInjected.Address(RVA = "0x18A5CA0", Offset = "0x18A46A0", VA = "0x1818A5CA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				lastDailyReset_ = (Timestamp)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				dailySell_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004837")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				dailySell_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004838")]
		[Cpp2IlInjected.Address(RVA = "0x18A5DD0", Offset = "0x18A47D0", VA = "0x1818A5DD0")]
		static LimitsGardening()
		{
			Func<LimitsGardening> func = default(Func<LimitsGardening>);
			_parser = (MessageParser<LimitsGardening>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
