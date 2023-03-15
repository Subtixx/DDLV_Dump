using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class CustomerCareAttachment : IMessage<CustomerCareAttachment>, IMessage, IEquatable<CustomerCareAttachment>, IDeepCloneable<CustomerCareAttachment>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly MessageParser<CustomerCareAttachment> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public const int AlternateTitleFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private string alternateTitle_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public const int AlternateSubtitleFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private string alternateSubtitle_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public const int AlternateMessageFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private string alternateMessage_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomerCareAttachment> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x356C030", Offset = "0x356AA30", VA = "0x18356C030")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000263")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x356BF60", Offset = "0x356A960", VA = "0x18356BF60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x356C090", Offset = "0x356AA90", VA = "0x18356C090", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		[DebuggerNonUserCode]
		public string AlternateTitle
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return alternateTitle_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x356C280", Offset = "0x356AC80", VA = "0x18356C280")]
			set
			{
				string text = (alternateTitle_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		[DebuggerNonUserCode]
		public string AlternateSubtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return alternateSubtitle_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009DB")]
			[Cpp2IlInjected.Address(RVA = "0x356C210", Offset = "0x356AC10", VA = "0x18356C210")]
			set
			{
				string text = (alternateSubtitle_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		[DebuggerNonUserCode]
		public string AlternateMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60009DC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return alternateMessage_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0x356C1A0", Offset = "0x356ABA0", VA = "0x18356C1A0")]
			set
			{
				string text = (alternateMessage_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x356BEF0", Offset = "0x356A8F0", VA = "0x18356BEF0")]
		[DebuggerNonUserCode]
		public CustomerCareAttachment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x356BDF0", Offset = "0x356A7F0", VA = "0x18356BDF0")]
		[DebuggerNonUserCode]
		public CustomerCareAttachment(CustomerCareAttachment other)
		{
			string text = (alternateTitle_ = other.alternateTitle_);
			string text2 = (alternateSubtitle_ = other.alternateSubtitle_);
			string text3 = (alternateMessage_ = other.alternateMessage_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x356B760", Offset = "0x356A160", VA = "0x18356B760", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomerCareAttachment Clone()
		{
			//Discarded unreachable code: IL_0068
			CustomerCareAttachment customerCareAttachment = new CustomerCareAttachment();
			customerCareAttachment.alternateTitle_ = "";
			customerCareAttachment.alternateSubtitle_ = "";
			customerCareAttachment.alternateMessage_ = "";
			string text = (customerCareAttachment.alternateTitle_ = alternateTitle_);
			string text2 = (customerCareAttachment.alternateSubtitle_ = alternateSubtitle_);
			string text3 = (customerCareAttachment.alternateMessage_ = alternateMessage_);
			UnknownFieldSet unknownFieldSet = (customerCareAttachment._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customerCareAttachment;
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x356B880", Offset = "0x356A280", VA = "0x18356B880", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = alternateTitle_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = alternateSubtitle_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = alternateMessage_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x1BF9E30", Offset = "0x1BF8830", VA = "0x181BF9E30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomerCareAttachment other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.alternateTitle_;
				if (!(alternateTitle_ != text))
				{
					string text2 = other.alternateSubtitle_;
					if (!(alternateSubtitle_ != text2))
					{
						string text3 = other.alternateMessage_;
						if (!(alternateMessage_ != text3))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x1BFA590", Offset = "0x1BF8F90", VA = "0x181BFA590", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0061
			string text = alternateTitle_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = alternateSubtitle_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = alternateMessage_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x356BC80", Offset = "0x356A680", VA = "0x18356BC80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x1BFD120", Offset = "0x1BFBB20", VA = "0x181BFD120", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0067
			if (alternateTitle_.m_stringLength != 0)
			{
				string value = alternateTitle_;
				output.WriteString(value);
			}
			if (alternateSubtitle_.m_stringLength != 0)
			{
				string value2 = alternateSubtitle_;
				output.WriteString(value2);
			}
			if (alternateMessage_.m_stringLength != 0)
			{
				string value3 = alternateMessage_;
				output.WriteString(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x356B5B0", Offset = "0x3569FB0", VA = "0x18356B5B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007f
			string text = alternateTitle_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = alternateSubtitle_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = alternateMessage_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x356BA00", Offset = "0x356A400", VA = "0x18356BA00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomerCareAttachment other)
		{
			//Discarded unreachable code: IL_0067
			if (other != null)
			{
				string text = other.alternateTitle_;
				if (text.m_stringLength != 0)
				{
					AlternateTitle = text;
				}
				string text2 = other.alternateSubtitle_;
				if (text2.m_stringLength != 0)
				{
					AlternateSubtitle = text2;
				}
				string text3 = other.alternateMessage_;
				if (text3.m_stringLength != 0)
				{
					AlternateMessage = text3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x356BAA0", Offset = "0x356A4A0", VA = "0x18356BAA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (AlternateTitle = input.ReadString());
				}
				string text4 = default(string);
				if (num == 18)
				{
					text4 = (AlternateSubtitle = input.ReadString());
				}
				if ((long)text4 == 26)
				{
					string text6 = (AlternateMessage = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x356B960", Offset = "0x356A360", VA = "0x18356B960", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = alternateMessage_;
				string text2 = alternateSubtitle_;
				string text3 = alternateTitle_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x356BB70", Offset = "0x356A570", VA = "0x18356BB70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
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
						AlternateMessage = (string)num2;
						break;
					}
					throw new InvalidCastException();
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

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x356B6C0", Offset = "0x356A0C0", VA = "0x18356B6C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					AlternateMessage = "";
					break;
				case 0:
					AlternateSubtitle = "";
					break;
				}
			}
			else
			{
				AlternateTitle = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x356BCE0", Offset = "0x356A6E0", VA = "0x18356BCE0")]
		static CustomerCareAttachment()
		{
			Func<CustomerCareAttachment> func = default(Func<CustomerCareAttachment>);
			_parser = (MessageParser<CustomerCareAttachment>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
