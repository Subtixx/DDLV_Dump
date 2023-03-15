using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class PromotionalAttachment : IMessage<PromotionalAttachment>, IMessage, IEquatable<PromotionalAttachment>, IDeepCloneable<PromotionalAttachment>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private static readonly MessageParser<PromotionalAttachment> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public const int PackIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private string packId_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public const int AlternateTitleFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private string alternateTitle_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public const int AlternateSubtitleFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private string alternateSubtitle_ = "";

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public const int AlternateMessageFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private string alternateMessage_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		[DebuggerNonUserCode]
		public static MessageParser<PromotionalAttachment> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x288A890", Offset = "0x2889290", VA = "0x18288A890")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x288A7C0", Offset = "0x28891C0", VA = "0x18288A7C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x288A8F0", Offset = "0x28892F0", VA = "0x18288A8F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		[DebuggerNonUserCode]
		public string PackId
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return packId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x288AB50", Offset = "0x2889550", VA = "0x18288AB50")]
			set
			{
				string text = (packId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		[DebuggerNonUserCode]
		public string AlternateTitle
		{
			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return alternateTitle_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0x288AAE0", Offset = "0x28894E0", VA = "0x18288AAE0")]
			set
			{
				string text = (alternateTitle_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		[DebuggerNonUserCode]
		public string AlternateSubtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return alternateSubtitle_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x288AA70", Offset = "0x2889470", VA = "0x18288AA70")]
			set
			{
				string text = (alternateSubtitle_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		[DebuggerNonUserCode]
		public string AlternateMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return alternateMessage_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x288AA00", Offset = "0x2889400", VA = "0x18288AA00")]
			set
			{
				string text = (alternateMessage_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x288A740", Offset = "0x2889140", VA = "0x18288A740")]
		[DebuggerNonUserCode]
		public PromotionalAttachment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x288A620", Offset = "0x2889020", VA = "0x18288A620")]
		[DebuggerNonUserCode]
		public PromotionalAttachment(PromotionalAttachment other)
		{
			string text = (packId_ = other.packId_);
			string text2 = (alternateTitle_ = other.alternateTitle_);
			string text3 = (alternateSubtitle_ = other.alternateSubtitle_);
			string text4 = (alternateMessage_ = other.alternateMessage_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2889EB0", Offset = "0x28888B0", VA = "0x182889EB0", Slot = "10")]
		[DebuggerNonUserCode]
		public PromotionalAttachment Clone()
		{
			//Discarded unreachable code: IL_0083
			PromotionalAttachment promotionalAttachment = new PromotionalAttachment();
			promotionalAttachment.packId_ = "";
			promotionalAttachment.alternateTitle_ = "";
			promotionalAttachment.alternateSubtitle_ = "";
			promotionalAttachment.alternateMessage_ = "";
			string text = (promotionalAttachment.packId_ = packId_);
			string text2 = (promotionalAttachment.alternateTitle_ = alternateTitle_);
			string text3 = (promotionalAttachment.alternateSubtitle_ = alternateSubtitle_);
			string text4 = (promotionalAttachment.alternateMessage_ = alternateMessage_);
			UnknownFieldSet unknownFieldSet = (promotionalAttachment._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return promotionalAttachment;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x288A000", Offset = "0x2888A00", VA = "0x18288A000", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = packId_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = alternateTitle_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = alternateSubtitle_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							string text4 = alternateMessage_;
							bool flag4 = default(bool);
							if (!flag4)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7540", Offset = "0x1AB5F40", VA = "0x181AB7540", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PromotionalAttachment other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.packId_;
				if (!(packId_ != text))
				{
					string text2 = other.alternateTitle_;
					if (!(alternateTitle_ != text2))
					{
						string text3 = other.alternateSubtitle_;
						if (!(alternateSubtitle_ != text3))
						{
							string text4 = other.alternateMessage_;
							if (!(alternateMessage_ != text4))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7690", Offset = "0x1AB6090", VA = "0x181AB7690", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_007c
			string text = packId_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = alternateTitle_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = alternateSubtitle_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = alternateMessage_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x288A4B0", Offset = "0x2888EB0", VA = "0x18288A4B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7AD0", Offset = "0x1AB64D0", VA = "0x181AB7AD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0086
			if (packId_.m_stringLength != 0)
			{
				string value = packId_;
				output.WriteString(value);
			}
			if (alternateTitle_.m_stringLength != 0)
			{
				string value2 = alternateTitle_;
				output.WriteString(value2);
			}
			if (alternateSubtitle_.m_stringLength != 0)
			{
				string value3 = alternateSubtitle_;
				output.WriteString(value3);
			}
			if (alternateMessage_.m_stringLength != 0)
			{
				string value4 = alternateMessage_;
				output.WriteString(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2889CA0", Offset = "0x28886A0", VA = "0x182889CA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00a5
			string text = packId_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = alternateTitle_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = alternateSubtitle_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			string text4 = alternateMessage_;
			if (text4.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text4);
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

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x288A1A0", Offset = "0x2888BA0", VA = "0x18288A1A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PromotionalAttachment other)
		{
			//Discarded unreachable code: IL_0083
			if (other != null)
			{
				string text = other.packId_;
				if (text.m_stringLength != 0)
				{
					PackId = text;
				}
				string text2 = other.alternateTitle_;
				if (text2.m_stringLength != 0)
				{
					AlternateTitle = text2;
				}
				string text3 = other.alternateSubtitle_;
				if (text3.m_stringLength != 0)
				{
					AlternateSubtitle = text3;
				}
				string text4 = other.alternateMessage_;
				if (text4.m_stringLength != 0)
				{
					AlternateMessage = text4;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x288A260", Offset = "0x2888C60", VA = "0x18288A260", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_007c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (AlternateSubtitle = input.ReadString());
				}
				if (num != 34)
				{
					goto IL_0065;
				}
				string text4 = (AlternateMessage = input.ReadString());
			}
			string text6 = default(string);
			if (num == 10)
			{
				text6 = (PackId = input.ReadString());
			}
			if ((long)text6 == 18)
			{
				string text8 = (AlternateTitle = input.ReadString());
			}
			goto IL_0065;
			IL_0065:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x288A0F0", Offset = "0x2888AF0", VA = "0x18288A0F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = alternateMessage_;
				string text2 = alternateSubtitle_;
				string text3 = alternateTitle_;
				string text4 = packId_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x288A350", Offset = "0x2888D50", VA = "0x18288A350", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
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
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2889DF0", Offset = "0x28887F0", VA = "0x182889DF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
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
			else
			{
				PackId = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x288A510", Offset = "0x2888F10", VA = "0x18288A510")]
		static PromotionalAttachment()
		{
			Func<PromotionalAttachment> func = default(Func<PromotionalAttachment>);
			_parser = (MessageParser<PromotionalAttachment>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
