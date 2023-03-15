using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x20007B2")]
	public sealed class ChoiceRenameOneOf : IMessage<ChoiceRenameOneOf>, IMessage, IEquatable<ChoiceRenameOneOf>, IDeepCloneable<ChoiceRenameOneOf>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002685")]
		private static readonly MessageParser<ChoiceRenameOneOf> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002686")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002687")]
		public const int ChoiceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002688")]
		private string choice_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002689")]
		public const int ValueFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400268A")]
		private string value_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001568")]
		[DebuggerNonUserCode]
		public static MessageParser<ChoiceRenameOneOf> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60054A8")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA450", Offset = "0x2EB8E50", VA = "0x182EBA450")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001569")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60054A9")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA380", Offset = "0x2EB8D80", VA = "0x182EBA380")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700156A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60054AA")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA4B0", Offset = "0x2EB8EB0", VA = "0x182EBA4B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700156B")]
		[DebuggerNonUserCode]
		public string Choice
		{
			[Cpp2IlInjected.Token(Token = "0x60054AE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return choice_;
			}
			[Cpp2IlInjected.Token(Token = "0x60054AF")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA5C0", Offset = "0x2EB8FC0", VA = "0x182EBA5C0")]
			set
			{
				string text = (choice_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700156C")]
		[DebuggerNonUserCode]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x60054B0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x60054B1")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA630", Offset = "0x2EB9030", VA = "0x182EBA630")]
			set
			{
				string text = (value_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054AB")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA320", Offset = "0x2EB8D20", VA = "0x182EBA320")]
		[DebuggerNonUserCode]
		public ChoiceRenameOneOf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60054AC")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA250", Offset = "0x2EB8C50", VA = "0x182EBA250")]
		[DebuggerNonUserCode]
		public ChoiceRenameOneOf(ChoiceRenameOneOf other)
		{
			string text = (choice_ = other.choice_);
			string text2 = (value_ = other.value_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054AD")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9C50", Offset = "0x2EB8650", VA = "0x182EB9C50", Slot = "10")]
		[DebuggerNonUserCode]
		public ChoiceRenameOneOf Clone()
		{
			//Discarded unreachable code: IL_004d
			ChoiceRenameOneOf choiceRenameOneOf = new ChoiceRenameOneOf();
			choiceRenameOneOf.choice_ = "";
			choiceRenameOneOf.value_ = "";
			string text = (choiceRenameOneOf.choice_ = choice_);
			string text2 = (choiceRenameOneOf.value_ = value_);
			UnknownFieldSet unknownFieldSet = (choiceRenameOneOf._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return choiceRenameOneOf;
		}

		[Cpp2IlInjected.Token(Token = "0x60054B2")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9D50", Offset = "0x2EB8750", VA = "0x182EB9D50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = choice_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = value_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60054B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChoiceRenameOneOf other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.choice_;
				if (!(choice_ != text))
				{
					string text2 = other.value_;
					if (!(value_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60054B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = choice_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = value_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60054B5")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA0E0", Offset = "0x2EB8AE0", VA = "0x182EBA0E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60054B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (choice_.m_stringLength != 0)
			{
				string value = choice_;
				output.WriteString(value);
			}
			if (value_.m_stringLength != 0)
			{
				string value2 = value_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60054B7")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9AC0", Offset = "0x2EB84C0", VA = "0x182EB9AC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = choice_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = value_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60054B8")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9F50", Offset = "0x2EB8950", VA = "0x182EB9F50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChoiceRenameOneOf other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.choice_;
				if (text.m_stringLength != 0)
				{
					Choice = text;
				}
				string text2 = other.value_;
				if (text2.m_stringLength != 0)
				{
					Value = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054B9")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9EA0", Offset = "0x2EB88A0", VA = "0x182EB9EA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Choice = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (Value = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054BA")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9E10", Offset = "0x2EB8810", VA = "0x182EB9E10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = choice_;
			}
			if (fieldNumber == 2)
			{
				string text2 = value_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60054BB")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9FD0", Offset = "0x2EB89D0", VA = "0x182EB9FD0", Slot = "12")]
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
				string text = (choice_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054BC")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9BA0", Offset = "0x2EB85A0", VA = "0x182EB9BA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (choice_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			Value = "";
		}

		[Cpp2IlInjected.Token(Token = "0x60054BD")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA140", Offset = "0x2EB8B40", VA = "0x182EBA140")]
		static ChoiceRenameOneOf()
		{
			Func<ChoiceRenameOneOf> func = default(Func<ChoiceRenameOneOf>);
			_parser = (MessageParser<ChoiceRenameOneOf>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
