using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class FrequencyFatigue : IFatigue, IFatigueQuantity, IMessage<FrequencyFatigue>, IMessage, IEquatable<FrequencyFatigue>, IDeepCloneable<FrequencyFatigue>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000029")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x400009F")]
				[OriginalName("Type_Hourly")]
				Hourly = 0,
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				[OriginalName("Type_Daily")]
				Daily = 1,
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				[OriginalName("Type_Weekly")]
				Weekly = 2,
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				[OriginalName("Type_Monthly")]
				Monthly = 4,
				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				[OriginalName("Type_Yearly")]
				Yearly = 5
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly MessageParser<FrequencyFatigue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Types.Type type_;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public const int QuantityFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int quantity_;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public const int OffsetFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Duration offset_;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static FrequencyFatigue CreateDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3588390", Offset = "0x3586D90", VA = "0x183588390")]
			get
			{
				//IL_000f: Expected I4, but got I8
				//IL_0018: Expected I4, but got I8
				FrequencyFatigue frequencyFatigue = new FrequencyFatigue();
				frequencyFatigue.quantity_ = 1;
				frequencyFatigue.type_ = Types.Type.Daily;
				Duration duration = (frequencyFatigue.offset_ = new Duration());
				return frequencyFatigue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[DebuggerNonUserCode]
		public static MessageParser<FrequencyFatigue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x35884F0", Offset = "0x3586EF0", VA = "0x1835884F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3588420", Offset = "0x3586E20", VA = "0x183588420")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x3588550", Offset = "0x3586F50", VA = "0x183588550", Slot = "11")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[DebuggerNonUserCode]
		public Types.Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[DebuggerNonUserCode]
		public int Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "6")]
			get
			{
				return quantity_;
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				quantity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[DebuggerNonUserCode]
		public Duration Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return offset_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				offset_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x35875E0", Offset = "0x3585FE0", VA = "0x1835875E0", Slot = "4")]
		public bool CanRefresh(DateTime lastRefresh, DateTime now)
		{
			//Discarded unreachable code: IL_006e
			TimeSpan timeSpan = -offset_.ToTimeSpan();
			int num = 0;
			if (type_ <= Types.Type.Yearly)
			{
				DateTime self = default(DateTime);
				long num2 = self.Hours();
				num2 = self.Days();
				int num3 = self.Weeks();
			}
			TimeSpan timeSpan2 = -offset_.ToTimeSpan();
			if (type_ <= Types.Type.Yearly)
			{
				DateTime self2 = default(DateTime);
				long num4 = self2.Hours();
				num4 = self2.Days();
				int num5 = self2.Weeks();
			}
			int num6 = default(int);
			return num < num6;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3587DE0", Offset = "0x35867E0", VA = "0x183587DE0", Slot = "5")]
		public DateTime NextAutoRefresh(DateTime now)
		{
			//Discarded unreachable code: IL_0049
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			TimeSpan timeSpan = offset_.ToTimeSpan();
			TimeSpan timeSpan2 = -timeSpan;
			int num = 0;
			if (type_ <= Types.Type.Yearly)
			{
				timeSpan += 6.3706613826E-314;
				int num2 = default(int);
				int num3 = num2;
				int num4 = default(int);
				int num5 = num4;
				int num6 = default(int);
				num5 = num6;
				int num7 = default(int);
				num3 = num7;
				int num8 = default(int);
				num5 = num8;
				int num9 = default(int);
				num5 = num9;
				int num10 = default(int);
				num5 = num10;
			}
			DateTime result = default(DateTime);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1EE50B0", Offset = "0x1EE3AB0", VA = "0x181EE50B0")]
		[DebuggerNonUserCode]
		public FrequencyFatigue()
		{
			//IL_000f: Expected I4, but got I8
			quantity_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			quantity_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3588310", Offset = "0x3586D10", VA = "0x183588310")]
		[DebuggerNonUserCode]
		public FrequencyFatigue(FrequencyFatigue other)
		{
			//IL_000f: Expected I4, but got I8
			//IL_0048: Expected O, but got I4
			quantity_ = 1;
			Types.Type type = (type_ = other.type_);
			int num = (quantity_ = other.quantity_);
			Duration duration = other.offset_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			int num2 = 0;
			offset_ = (Duration)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x35878F0", Offset = "0x35862F0", VA = "0x1835878F0", Slot = "13")]
		[DebuggerNonUserCode]
		public FrequencyFatigue Clone()
		{
			//Discarded unreachable code: IL_0060
			//IL_000f: Expected I4, but got I8
			//IL_0049: Expected O, but got I4
			FrequencyFatigue frequencyFatigue = new FrequencyFatigue();
			frequencyFatigue.quantity_ = 1;
			Types.Type type = (frequencyFatigue.type_ = type_);
			int num = (frequencyFatigue.quantity_ = quantity_);
			Duration duration = offset_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			int num2 = 0;
			frequencyFatigue.offset_ = (Duration)num2;
			UnknownFieldSet unknownFieldSet = (frequencyFatigue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return frequencyFatigue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x35879A0", Offset = "0x35863A0", VA = "0x1835879A0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)type_ == (IntPtr)typeof(FrequencyFatigue).TypeHandle && (IntPtr)quantity_ == (IntPtr)typeof(FrequencyFatigue).TypeHandle && object.Equals(offset_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "12")]
		[DebuggerNonUserCode]
		public bool Equals(FrequencyFatigue other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.Type type = other.type_;
				if (type_ == type)
				{
					int num = other.quantity_;
					if (quantity_ == num)
					{
						Duration objB = other.offset_;
						if (object.Equals(offset_, objB))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3587B50", Offset = "0x3586550", VA = "0x183587B50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (type_ != 0)
				{
				}
				if (quantity_ != 0)
				{
				}
				Duration duration = offset_;
				if (duration != null)
				{
					int hashCode = duration.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x35881A0", Offset = "0x3586BA0", VA = "0x1835881A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x1F16E70", Offset = "0x1F15870", VA = "0x181F16E70", Slot = "9")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004c
			if (type_ != 0)
			{
			}
			if (quantity_ != 0)
			{
				int value = quantity_;
				output.WriteInt32(value);
			}
			if ((long)offset_ != 0)
			{
				Duration value2 = offset_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x35874E0", Offset = "0x3585EE0", VA = "0x1835874E0", Slot = "10")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.Type type = type_;
				num = 0;
				if (type != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)type);
				}
				int num3 = quantity_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				Duration duration = offset_;
				if (duration != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(duration);
					num5++;
					num += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3587BF0", Offset = "0x35865F0", VA = "0x183587BF0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(FrequencyFatigue other)
		{
			//Discarded unreachable code: IL_0083
			if (other == null)
			{
				return;
			}
			Types.Type type = other.type_;
			if (type != 0)
			{
				type_ = type;
			}
			int num = other.quantity_;
			if (num != 0)
			{
				quantity_ = num;
			}
			if ((long)other.offset_ != 0)
			{
				Duration duration2 = default(Duration);
				if (offset_ == null)
				{
					Duration duration = (offset_ = new Duration());
					duration2 = offset_;
				}
				Duration other2 = other.offset_;
				duration2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3587CD0", Offset = "0x35866D0", VA = "0x183587CD0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0075
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (int)(type_ = (Types.Type)input.ReadInt32());
			}
			int num3 = default(int);
			if (num == 16)
			{
				num3 = (quantity_ = input.ReadInt32());
			}
			if (num3 == 26)
			{
				Duration builder = default(Duration);
				if (offset_ == null)
				{
					Duration duration = (offset_ = new Duration());
					builder = offset_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3587A60", Offset = "0x3586460", VA = "0x183587A60", Slot = "14")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_001e;
				}
				Duration duration = offset_;
			}
			Types.Type type = type_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3588080", Offset = "0x3586A80", VA = "0x183588080", Slot = "15")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0032
			//IL_0021: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_0031: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						offset_ = (Duration)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
				{
					object obj = default(object);
					quantity_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj2 = default(object);
				type_ = (Types.Type)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1F16580", Offset = "0x1F14F80", VA = "0x181F16580", Slot = "16")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3588200", Offset = "0x3586C00", VA = "0x183588200")]
		static FrequencyFatigue()
		{
			Func<FrequencyFatigue> func = default(Func<FrequencyFatigue>);
			_parser = (MessageParser<FrequencyFatigue>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
