using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Campaign
{
	[Cpp2IlInjected.Token(Token = "0x2000267")]
	public sealed class CampaignPhonePromptEvent : IMessage<CampaignPhonePromptEvent>, IMessage, IEquatable<CampaignPhonePromptEvent>, IDeepCloneable<CampaignPhonePromptEvent>, IMessageFieldAccessor, ICampaignType
	{
		[Cpp2IlInjected.Token(Token = "0x400098C")]
		private static readonly MessageParser<CampaignPhonePromptEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400098D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400098E")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400098F")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000513")]
		[DebuggerNonUserCode]
		public static MessageParser<CampaignPhonePromptEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60016E9")]
			[Cpp2IlInjected.Address(RVA = "0x2890C60", Offset = "0x288F660", VA = "0x182890C60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000514")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016EA")]
			[Cpp2IlInjected.Address(RVA = "0x2890B90", Offset = "0x288F590", VA = "0x182890B90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000515")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016EB")]
			[Cpp2IlInjected.Address(RVA = "0x2890CC0", Offset = "0x288F6C0", VA = "0x182890CC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000516")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60016EF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60016F0")]
			[Cpp2IlInjected.Address(RVA = "0x2890DD0", Offset = "0x288F7D0", VA = "0x182890DD0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016EC")]
		[Cpp2IlInjected.Address(RVA = "0x2890AA0", Offset = "0x288F4A0", VA = "0x182890AA0")]
		[DebuggerNonUserCode]
		public CampaignPhonePromptEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60016ED")]
		[Cpp2IlInjected.Address(RVA = "0x2890AF0", Offset = "0x288F4F0", VA = "0x182890AF0")]
		[DebuggerNonUserCode]
		public CampaignPhonePromptEvent(CampaignPhonePromptEvent other)
		{
			string text = (name_ = other.name_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016EE")]
		[Cpp2IlInjected.Address(RVA = "0x28904B0", Offset = "0x288EEB0", VA = "0x1828904B0", Slot = "10")]
		[DebuggerNonUserCode]
		public CampaignPhonePromptEvent Clone()
		{
			//Discarded unreachable code: IL_0034
			CampaignPhonePromptEvent campaignPhonePromptEvent = new CampaignPhonePromptEvent();
			campaignPhonePromptEvent.name_ = "";
			string text = (campaignPhonePromptEvent.name_ = name_);
			UnknownFieldSet unknownFieldSet = (campaignPhonePromptEvent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return campaignPhonePromptEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x60016F1")]
		[Cpp2IlInjected.Address(RVA = "0x2890570", Offset = "0x288EF70", VA = "0x182890570", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60016F2")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CampaignPhonePromptEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x60016F3")]
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

		[Cpp2IlInjected.Token(Token = "0x60016F4")]
		[Cpp2IlInjected.Address(RVA = "0x2890930", Offset = "0x288F330", VA = "0x182890930", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60016F5")]
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

		[Cpp2IlInjected.Token(Token = "0x60016F6")]
		[Cpp2IlInjected.Address(RVA = "0x2890380", Offset = "0x288ED80", VA = "0x182890380", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60016F7")]
		[Cpp2IlInjected.Address(RVA = "0x28906A0", Offset = "0x288F0A0", VA = "0x1828906A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignPhonePromptEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x60016F8")]
		[Cpp2IlInjected.Address(RVA = "0x2890700", Offset = "0x288F100", VA = "0x182890700", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60016F9")]
		[Cpp2IlInjected.Address(RVA = "0x2890620", Offset = "0x288F020", VA = "0x182890620", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60016FA")]
		[Cpp2IlInjected.Address(RVA = "0x2890870", Offset = "0x288F270", VA = "0x182890870", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60016FB")]
		[Cpp2IlInjected.Address(RVA = "0x2890420", Offset = "0x288EE20", VA = "0x182890420", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016FC")]
		[Cpp2IlInjected.Address(RVA = "0x2890790", Offset = "0x288F190", VA = "0x182890790", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60016FD")]
		[Cpp2IlInjected.Address(RVA = "0x2890990", Offset = "0x288F390", VA = "0x182890990")]
		static CampaignPhonePromptEvent()
		{
			Func<CampaignPhonePromptEvent> func = default(Func<CampaignPhonePromptEvent>);
			_parser = (MessageParser<CampaignPhonePromptEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
