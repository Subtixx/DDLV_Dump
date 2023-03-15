using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x20007A4")]
	public sealed class ChoiceRenameMessage : IMessage<ChoiceRenameMessage>, IMessage, IEquatable<ChoiceRenameMessage>, IDeepCloneable<ChoiceRenameMessage>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002651")]
		private static readonly MessageParser<ChoiceRenameMessage> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002652")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002653")]
		public const int ChoiceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002654")]
		private string choice_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002655")]
		public const int ValueFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002656")]
		private string value_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001552")]
		[DebuggerNonUserCode]
		public static MessageParser<ChoiceRenameMessage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600543D")]
			[Cpp2IlInjected.Address(RVA = "0x2EB9870", Offset = "0x2EB8270", VA = "0x182EB9870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001553")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600543E")]
			[Cpp2IlInjected.Address(RVA = "0x2EB97A0", Offset = "0x2EB81A0", VA = "0x182EB97A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001554")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600543F")]
			[Cpp2IlInjected.Address(RVA = "0x2EB98D0", Offset = "0x2EB82D0", VA = "0x182EB98D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001555")]
		[DebuggerNonUserCode]
		public string Choice
		{
			[Cpp2IlInjected.Token(Token = "0x6005443")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return choice_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005444")]
			[Cpp2IlInjected.Address(RVA = "0x2EB99E0", Offset = "0x2EB83E0", VA = "0x182EB99E0")]
			set
			{
				string text = (choice_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001556")]
		[DebuggerNonUserCode]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6005445")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005446")]
			[Cpp2IlInjected.Address(RVA = "0x2EB9A50", Offset = "0x2EB8450", VA = "0x182EB9A50")]
			set
			{
				string text = (value_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005440")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9740", Offset = "0x2EB8140", VA = "0x182EB9740")]
		[DebuggerNonUserCode]
		public ChoiceRenameMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005441")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9670", Offset = "0x2EB8070", VA = "0x182EB9670")]
		[DebuggerNonUserCode]
		public ChoiceRenameMessage(ChoiceRenameMessage other)
		{
			string text = (choice_ = other.choice_);
			string text2 = (value_ = other.value_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005442")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9070", Offset = "0x2EB7A70", VA = "0x182EB9070", Slot = "10")]
		[DebuggerNonUserCode]
		public ChoiceRenameMessage Clone()
		{
			//Discarded unreachable code: IL_004d
			ChoiceRenameMessage choiceRenameMessage = new ChoiceRenameMessage();
			choiceRenameMessage.choice_ = "";
			choiceRenameMessage.value_ = "";
			string text = (choiceRenameMessage.choice_ = choice_);
			string text2 = (choiceRenameMessage.value_ = value_);
			UnknownFieldSet unknownFieldSet = (choiceRenameMessage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return choiceRenameMessage;
		}

		[Cpp2IlInjected.Token(Token = "0x6005447")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9170", Offset = "0x2EB7B70", VA = "0x182EB9170", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6005448")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChoiceRenameMessage other)
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

		[Cpp2IlInjected.Token(Token = "0x6005449")]
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

		[Cpp2IlInjected.Token(Token = "0x600544A")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9500", Offset = "0x2EB7F00", VA = "0x182EB9500", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600544B")]
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

		[Cpp2IlInjected.Token(Token = "0x600544C")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8EE0", Offset = "0x2EB78E0", VA = "0x182EB8EE0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x600544D")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9370", Offset = "0x2EB7D70", VA = "0x182EB9370", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChoiceRenameMessage other)
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

		[Cpp2IlInjected.Token(Token = "0x600544E")]
		[Cpp2IlInjected.Address(RVA = "0x2EB92C0", Offset = "0x2EB7CC0", VA = "0x182EB92C0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x600544F")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9230", Offset = "0x2EB7C30", VA = "0x182EB9230", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6005450")]
		[Cpp2IlInjected.Address(RVA = "0x2EB93F0", Offset = "0x2EB7DF0", VA = "0x182EB93F0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6005451")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8FC0", Offset = "0x2EB79C0", VA = "0x182EB8FC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (choice_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				Value = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005452")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9560", Offset = "0x2EB7F60", VA = "0x182EB9560")]
		static ChoiceRenameMessage()
		{
			Func<ChoiceRenameMessage> func = default(Func<ChoiceRenameMessage>);
			_parser = (MessageParser<ChoiceRenameMessage>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
