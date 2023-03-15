using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class GameCommunicationAttachment : IMessage<GameCommunicationAttachment>, IMessage, IEquatable<GameCommunicationAttachment>, IDeepCloneable<GameCommunicationAttachment>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private static readonly MessageParser<GameCommunicationAttachment> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public const int AlternateTitleFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private string alternateTitle_ = "";

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public const int AlternateSubtitleFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private string alternateSubtitle_ = "";

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public const int AlternateMessageFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private string alternateMessage_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		[DebuggerNonUserCode]
		public static MessageParser<GameCommunicationAttachment> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x218E350", Offset = "0x218CD50", VA = "0x18218E350")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x218E280", Offset = "0x218CC80", VA = "0x18218E280")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x218E3B0", Offset = "0x218CDB0", VA = "0x18218E3B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		[DebuggerNonUserCode]
		public string AlternateTitle
		{
			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return alternateTitle_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0x218E5A0", Offset = "0x218CFA0", VA = "0x18218E5A0")]
			set
			{
				string text = (alternateTitle_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		[DebuggerNonUserCode]
		public string AlternateSubtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60009F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return alternateSubtitle_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0x218E530", Offset = "0x218CF30", VA = "0x18218E530")]
			set
			{
				string text = (alternateSubtitle_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		[DebuggerNonUserCode]
		public string AlternateMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return alternateMessage_;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0x218E4C0", Offset = "0x218CEC0", VA = "0x18218E4C0")]
			set
			{
				string text = (alternateMessage_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0x218E210", Offset = "0x218CC10", VA = "0x18218E210")]
		[DebuggerNonUserCode]
		public GameCommunicationAttachment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0x218E110", Offset = "0x218CB10", VA = "0x18218E110")]
		[DebuggerNonUserCode]
		public GameCommunicationAttachment(GameCommunicationAttachment other)
		{
			string text = (alternateTitle_ = other.alternateTitle_);
			string text2 = (alternateSubtitle_ = other.alternateSubtitle_);
			string text3 = (alternateMessage_ = other.alternateMessage_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0x218DA80", Offset = "0x218C480", VA = "0x18218DA80", Slot = "10")]
		[DebuggerNonUserCode]
		public GameCommunicationAttachment Clone()
		{
			//Discarded unreachable code: IL_0068
			GameCommunicationAttachment gameCommunicationAttachment = new GameCommunicationAttachment();
			gameCommunicationAttachment.alternateTitle_ = "";
			gameCommunicationAttachment.alternateSubtitle_ = "";
			gameCommunicationAttachment.alternateMessage_ = "";
			string text = (gameCommunicationAttachment.alternateTitle_ = alternateTitle_);
			string text2 = (gameCommunicationAttachment.alternateSubtitle_ = alternateSubtitle_);
			string text3 = (gameCommunicationAttachment.alternateMessage_ = alternateMessage_);
			UnknownFieldSet unknownFieldSet = (gameCommunicationAttachment._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gameCommunicationAttachment;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0x218DBA0", Offset = "0x218C5A0", VA = "0x18218DBA0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x1BF9E30", Offset = "0x1BF8830", VA = "0x181BF9E30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GameCommunicationAttachment other)
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

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
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

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x218DFA0", Offset = "0x218C9A0", VA = "0x18218DFA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
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

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x218D8D0", Offset = "0x218C2D0", VA = "0x18218D8D0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x218DDF0", Offset = "0x218C7F0", VA = "0x18218DDF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GameCommunicationAttachment other)
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

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x218DD20", Offset = "0x218C720", VA = "0x18218DD20", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x218DC80", Offset = "0x218C680", VA = "0x18218DC80", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x218DE90", Offset = "0x218C890", VA = "0x18218DE90", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x218D9E0", Offset = "0x218C3E0", VA = "0x18218D9E0", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x218E000", Offset = "0x218CA00", VA = "0x18218E000")]
		static GameCommunicationAttachment()
		{
			Func<GameCommunicationAttachment> func = default(Func<GameCommunicationAttachment>);
			_parser = (MessageParser<GameCommunicationAttachment>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
