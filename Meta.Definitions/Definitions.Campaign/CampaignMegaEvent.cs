using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Campaign
{
	[Cpp2IlInjected.Token(Token = "0x2000261")]
	public sealed class CampaignMegaEvent : IMessage<CampaignMegaEvent>, IMessage, IEquatable<CampaignMegaEvent>, IDeepCloneable<CampaignMegaEvent>, IMessageFieldAccessor, ICampaignType
	{
		[Cpp2IlInjected.Token(Token = "0x400097D")]
		private static readonly MessageParser<CampaignMegaEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400097E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400097F")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000980")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000507")]
		[DebuggerNonUserCode]
		public static MessageParser<CampaignMegaEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60016A1")]
			[Cpp2IlInjected.Address(RVA = "0x32F38B0", Offset = "0x32F22B0", VA = "0x1832F38B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000508")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016A2")]
			[Cpp2IlInjected.Address(RVA = "0x32F37E0", Offset = "0x32F21E0", VA = "0x1832F37E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000509")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016A3")]
			[Cpp2IlInjected.Address(RVA = "0x32F3910", Offset = "0x32F2310", VA = "0x1832F3910", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050A")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60016A7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60016A8")]
			[Cpp2IlInjected.Address(RVA = "0x32F3A20", Offset = "0x32F2420", VA = "0x1832F3A20")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016A4")]
		[Cpp2IlInjected.Address(RVA = "0x32F3790", Offset = "0x32F2190", VA = "0x1832F3790")]
		[DebuggerNonUserCode]
		public CampaignMegaEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60016A5")]
		[Cpp2IlInjected.Address(RVA = "0x32F36F0", Offset = "0x32F20F0", VA = "0x1832F36F0")]
		[DebuggerNonUserCode]
		public CampaignMegaEvent(CampaignMegaEvent other)
		{
			string text = (name_ = other.name_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016A6")]
		[Cpp2IlInjected.Address(RVA = "0x32F3100", Offset = "0x32F1B00", VA = "0x1832F3100", Slot = "10")]
		[DebuggerNonUserCode]
		public CampaignMegaEvent Clone()
		{
			//Discarded unreachable code: IL_0034
			CampaignMegaEvent campaignMegaEvent = new CampaignMegaEvent();
			campaignMegaEvent.name_ = "";
			string text = (campaignMegaEvent.name_ = name_);
			UnknownFieldSet unknownFieldSet = (campaignMegaEvent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return campaignMegaEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x60016A9")]
		[Cpp2IlInjected.Address(RVA = "0x32F31C0", Offset = "0x32F1BC0", VA = "0x1832F31C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = name_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016AA")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CampaignMegaEvent other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016AB")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = name_;
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

		[Cpp2IlInjected.Token(Token = "0x60016AC")]
		[Cpp2IlInjected.Address(RVA = "0x32F3580", Offset = "0x32F1F80", VA = "0x1832F3580", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60016AD")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (name_.m_stringLength != 0)
			{
				string value = name_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60016AE")]
		[Cpp2IlInjected.Address(RVA = "0x32F2FD0", Offset = "0x32F19D0", VA = "0x1832F2FD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = name_;
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

		[Cpp2IlInjected.Token(Token = "0x60016AF")]
		[Cpp2IlInjected.Address(RVA = "0x32F32F0", Offset = "0x32F1CF0", VA = "0x1832F32F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignMegaEvent other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016B0")]
		[Cpp2IlInjected.Address(RVA = "0x32F3350", Offset = "0x32F1D50", VA = "0x1832F3350", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Name = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016B1")]
		[Cpp2IlInjected.Address(RVA = "0x32F3270", Offset = "0x32F1C70", VA = "0x1832F3270", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = name_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016B2")]
		[Cpp2IlInjected.Address(RVA = "0x32F34C0", Offset = "0x32F1EC0", VA = "0x1832F34C0", Slot = "12")]
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
				string text = (name_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016B3")]
		[Cpp2IlInjected.Address(RVA = "0x32F3070", Offset = "0x32F1A70", VA = "0x1832F3070", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016B4")]
		[Cpp2IlInjected.Address(RVA = "0x32F33E0", Offset = "0x32F1DE0", VA = "0x1832F33E0", Slot = "14")]
		public void OnUpdate(CampaignUpdate update, ICampaignManager manager, CampaignData campaign)
		{
			//Discarded unreachable code: IL_0011
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016B5")]
		[Cpp2IlInjected.Address(RVA = "0x32F35E0", Offset = "0x32F1FE0", VA = "0x1832F35E0")]
		static CampaignMegaEvent()
		{
			Func<CampaignMegaEvent> func = default(Func<CampaignMegaEvent>);
			_parser = (MessageParser<CampaignMegaEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
