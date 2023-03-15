using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B43")]
	public sealed class StatisticChildValue : IMessage<StatisticChildValue>, IMessage, IEquatable<StatisticChildValue>, IDeepCloneable<StatisticChildValue>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002BAF")]
		private static readonly MessageParser<StatisticChildValue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BB0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002BB1")]
		public const int ChildNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BB2")]
		private string childName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002BB3")]
		public const int MetadataFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002BB4")]
		private string metadata_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002BB5")]
		public const int ValueFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002BB6")]
		private int value_;

		[Cpp2IlInjected.Token(Token = "0x17001049")]
		[DebuggerNonUserCode]
		public static MessageParser<StatisticChildValue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005F38")]
			[Cpp2IlInjected.Address(RVA = "0xC069B0", Offset = "0xC053B0", VA = "0x180C069B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F39")]
			[Cpp2IlInjected.Address(RVA = "0xC068E0", Offset = "0xC052E0", VA = "0x180C068E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F3A")]
			[Cpp2IlInjected.Address(RVA = "0xC06A10", Offset = "0xC05410", VA = "0x180C06A10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104C")]
		[DebuggerNonUserCode]
		public string ChildName
		{
			[Cpp2IlInjected.Token(Token = "0x6005F3E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return childName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F3F")]
			[Cpp2IlInjected.Address(RVA = "0xC06B20", Offset = "0xC05520", VA = "0x180C06B20")]
			set
			{
				string text = (childName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104D")]
		[DebuggerNonUserCode]
		public string Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x6005F40")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return metadata_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F41")]
			[Cpp2IlInjected.Address(RVA = "0xC06B90", Offset = "0xC05590", VA = "0x180C06B90")]
			set
			{
				string text = (metadata_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104E")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6005F42")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F43")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				value_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F3B")]
		[Cpp2IlInjected.Address(RVA = "0xC06880", Offset = "0xC05280", VA = "0x180C06880")]
		[DebuggerNonUserCode]
		public StatisticChildValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005F3C")]
		[Cpp2IlInjected.Address(RVA = "0xC067B0", Offset = "0xC051B0", VA = "0x180C067B0")]
		[DebuggerNonUserCode]
		public StatisticChildValue(StatisticChildValue other)
		{
			string text = (childName_ = other.childName_);
			string text2 = (metadata_ = other.metadata_);
			int num = (value_ = other.value_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F3D")]
		[Cpp2IlInjected.Address(RVA = "0xC05F20", Offset = "0xC04920", VA = "0x180C05F20", Slot = "10")]
		[DebuggerNonUserCode]
		public StatisticChildValue Clone()
		{
			//Discarded unreachable code: IL_005d
			StatisticChildValue statisticChildValue = new StatisticChildValue();
			statisticChildValue.childName_ = "";
			statisticChildValue.metadata_ = "";
			string text = (statisticChildValue.childName_ = childName_);
			string text2 = (statisticChildValue.metadata_ = metadata_);
			int num = (statisticChildValue.value_ = value_);
			UnknownFieldSet unknownFieldSet = (statisticChildValue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return statisticChildValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F44")]
		[Cpp2IlInjected.Address(RVA = "0xC060A0", Offset = "0xC04AA0", VA = "0x180C060A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = childName_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = metadata_;
					bool flag2 = default(bool);
					if (!flag2 && value_ == (flag2 ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F45")]
		[Cpp2IlInjected.Address(RVA = "0xC06020", Offset = "0xC04A20", VA = "0x180C06020", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StatisticChildValue other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.childName_;
				if (!(childName_ != text))
				{
					string text2 = other.metadata_;
					if (!(metadata_ != text2))
					{
						int num = other.value_;
						if (value_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6005F46")]
		[Cpp2IlInjected.Address(RVA = "0xC06250", Offset = "0xC04C50", VA = "0x180C06250", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0050
			string text = childName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = metadata_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (value_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F47")]
		[Cpp2IlInjected.Address(RVA = "0xC06570", Offset = "0xC04F70", VA = "0x180C06570", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F48")]
		[Cpp2IlInjected.Address(RVA = "0xC065D0", Offset = "0xC04FD0", VA = "0x180C065D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0062
			if (childName_.m_stringLength != 0)
			{
				string value = childName_;
				output.WriteString(value);
			}
			if (metadata_.m_stringLength != 0)
			{
				string value2 = metadata_;
				output.WriteString(value2);
			}
			if (value_ != 0)
			{
				int value3 = value_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F49")]
		[Cpp2IlInjected.Address(RVA = "0xC05D80", Offset = "0xC04780", VA = "0x180C05D80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007a
			string text = childName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = metadata_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			int num4 = value_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F4A")]
		[Cpp2IlInjected.Address(RVA = "0xC06300", Offset = "0xC04D00", VA = "0x180C06300", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StatisticChildValue other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				string text = other.childName_;
				if (text.m_stringLength != 0)
				{
					ChildName = text;
				}
				string text2 = other.metadata_;
				if (text2.m_stringLength != 0)
				{
					Metadata = text2;
				}
				int num = other.value_;
				if (num != 0)
				{
					value_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F4B")]
		[Cpp2IlInjected.Address(RVA = "0xC06390", Offset = "0xC04D90", VA = "0x180C06390", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (ChildName = input.ReadString());
				}
				string text4 = default(string);
				if (num == 18)
				{
					text4 = (Metadata = input.ReadString());
				}
				if ((long)text4 == 24)
				{
					int num2 = (value_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F4C")]
		[Cpp2IlInjected.Address(RVA = "0xC06170", Offset = "0xC04B70", VA = "0x180C06170", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					int num2 = value_;
				}
				string text = metadata_;
			}
			string text2 = childName_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F4D")]
		[Cpp2IlInjected.Address(RVA = "0xC06450", Offset = "0xC04E50", VA = "0x180C06450", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					value_ = (int)obj;
					break;
				}
				case 0:
					if (value == null || value != null)
					{
						break;
					}
					throw new InvalidCastException();
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F4E")]
		[Cpp2IlInjected.Address(RVA = "0xC05E90", Offset = "0xC04890", VA = "0x180C05E90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					value_ = 0;
					break;
				case 0:
					Metadata = "";
					break;
				}
			}
			else
			{
				ChildName = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F4F")]
		[Cpp2IlInjected.Address(RVA = "0xC066A0", Offset = "0xC050A0", VA = "0x180C066A0")]
		static StatisticChildValue()
		{
			Func<StatisticChildValue> func = default(Func<StatisticChildValue>);
			_parser = (MessageParser<StatisticChildValue>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
