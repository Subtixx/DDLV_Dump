using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000790")]
	public sealed class ChoiceRename : IMessage<ChoiceRename>, IMessage, IEquatable<ChoiceRename>, IDeepCloneable<ChoiceRename>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40025DF")]
		private static readonly MessageParser<ChoiceRename> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40025E0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40025E1")]
		public const int ChoiceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025E2")]
		private string choice_ = "";

		[Cpp2IlInjected.Token(Token = "0x40025E3")]
		public const int ValueFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40025E4")]
		private string value_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001515")]
		[DebuggerNonUserCode]
		public static MessageParser<ChoiceRename> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005345")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB030", Offset = "0x2EB9A30", VA = "0x182EBB030")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001516")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005346")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAF60", Offset = "0x2EB9960", VA = "0x182EBAF60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001517")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005347")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB090", Offset = "0x2EB9A90", VA = "0x182EBB090", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001518")]
		[DebuggerNonUserCode]
		public string Choice
		{
			[Cpp2IlInjected.Token(Token = "0x600534B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return choice_;
			}
			[Cpp2IlInjected.Token(Token = "0x600534C")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB1A0", Offset = "0x2EB9BA0", VA = "0x182EBB1A0")]
			set
			{
				string text = (choice_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001519")]
		[DebuggerNonUserCode]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600534D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x600534E")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB210", Offset = "0x2EB9C10", VA = "0x182EBB210")]
			set
			{
				string text = (value_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005348")]
		[Cpp2IlInjected.Address(RVA = "0x2EBAE30", Offset = "0x2EB9830", VA = "0x182EBAE30")]
		[DebuggerNonUserCode]
		public ChoiceRename()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005349")]
		[Cpp2IlInjected.Address(RVA = "0x2EBAE90", Offset = "0x2EB9890", VA = "0x182EBAE90")]
		[DebuggerNonUserCode]
		public ChoiceRename(ChoiceRename other)
		{
			string text = (choice_ = other.choice_);
			string text2 = (value_ = other.value_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600534A")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA830", Offset = "0x2EB9230", VA = "0x182EBA830", Slot = "10")]
		[DebuggerNonUserCode]
		public ChoiceRename Clone()
		{
			//Discarded unreachable code: IL_004d
			ChoiceRename choiceRename = new ChoiceRename();
			choiceRename.choice_ = "";
			choiceRename.value_ = "";
			string text = (choiceRename.choice_ = choice_);
			string text2 = (choiceRename.value_ = value_);
			UnknownFieldSet unknownFieldSet = (choiceRename._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return choiceRename;
		}

		[Cpp2IlInjected.Token(Token = "0x600534F")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA930", Offset = "0x2EB9330", VA = "0x182EBA930", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6005350")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChoiceRename other)
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

		[Cpp2IlInjected.Token(Token = "0x6005351")]
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

		[Cpp2IlInjected.Token(Token = "0x6005352")]
		[Cpp2IlInjected.Address(RVA = "0x2EBACC0", Offset = "0x2EB96C0", VA = "0x182EBACC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005353")]
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

		[Cpp2IlInjected.Token(Token = "0x6005354")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA6A0", Offset = "0x2EB90A0", VA = "0x182EBA6A0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6005355")]
		[Cpp2IlInjected.Address(RVA = "0x2EBAA80", Offset = "0x2EB9480", VA = "0x182EBAA80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChoiceRename other)
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

		[Cpp2IlInjected.Token(Token = "0x6005356")]
		[Cpp2IlInjected.Address(RVA = "0x2EBAB00", Offset = "0x2EB9500", VA = "0x182EBAB00", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6005357")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA9F0", Offset = "0x2EB93F0", VA = "0x182EBA9F0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6005358")]
		[Cpp2IlInjected.Address(RVA = "0x2EBABB0", Offset = "0x2EB95B0", VA = "0x182EBABB0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6005359")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA780", Offset = "0x2EB9180", VA = "0x182EBA780", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x600535A")]
		[Cpp2IlInjected.Address(RVA = "0x2EBAD20", Offset = "0x2EB9720", VA = "0x182EBAD20")]
		static ChoiceRename()
		{
			Func<ChoiceRename> func = default(Func<ChoiceRename>);
			_parser = (MessageParser<ChoiceRename>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
