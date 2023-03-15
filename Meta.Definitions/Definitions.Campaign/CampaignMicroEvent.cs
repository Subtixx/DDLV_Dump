using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Campaign
{
	[Cpp2IlInjected.Token(Token = "0x2000265")]
	public sealed class CampaignMicroEvent : IMessage<CampaignMicroEvent>, IMessage, IEquatable<CampaignMicroEvent>, IDeepCloneable<CampaignMicroEvent>, IMessageFieldAccessor, ICampaignType
	{
		[Cpp2IlInjected.Token(Token = "0x4000987")]
		private static readonly MessageParser<CampaignMicroEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000988")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000989")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400098A")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700050F")]
		[DebuggerNonUserCode]
		public static MessageParser<CampaignMicroEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60016D1")]
			[Cpp2IlInjected.Address(RVA = "0x288F6E0", Offset = "0x288E0E0", VA = "0x18288F6E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000510")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016D2")]
			[Cpp2IlInjected.Address(RVA = "0x288F610", Offset = "0x288E010", VA = "0x18288F610")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000511")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016D3")]
			[Cpp2IlInjected.Address(RVA = "0x288F740", Offset = "0x288E140", VA = "0x18288F740", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000512")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60016D7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60016D8")]
			[Cpp2IlInjected.Address(RVA = "0x288F850", Offset = "0x288E250", VA = "0x18288F850")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016D4")]
		[Cpp2IlInjected.Address(RVA = "0x288F5C0", Offset = "0x288DFC0", VA = "0x18288F5C0")]
		[DebuggerNonUserCode]
		public CampaignMicroEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60016D5")]
		[Cpp2IlInjected.Address(RVA = "0x288F520", Offset = "0x288DF20", VA = "0x18288F520")]
		[DebuggerNonUserCode]
		public CampaignMicroEvent(CampaignMicroEvent other)
		{
			string text = (name_ = other.name_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016D6")]
		[Cpp2IlInjected.Address(RVA = "0x288EF30", Offset = "0x288D930", VA = "0x18288EF30", Slot = "10")]
		[DebuggerNonUserCode]
		public CampaignMicroEvent Clone()
		{
			//Discarded unreachable code: IL_0034
			CampaignMicroEvent campaignMicroEvent = new CampaignMicroEvent();
			campaignMicroEvent.name_ = "";
			string text = (campaignMicroEvent.name_ = name_);
			UnknownFieldSet unknownFieldSet = (campaignMicroEvent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return campaignMicroEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x60016D9")]
		[Cpp2IlInjected.Address(RVA = "0x288EFF0", Offset = "0x288D9F0", VA = "0x18288EFF0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60016DA")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CampaignMicroEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x60016DB")]
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

		[Cpp2IlInjected.Token(Token = "0x60016DC")]
		[Cpp2IlInjected.Address(RVA = "0x288F3B0", Offset = "0x288DDB0", VA = "0x18288F3B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60016DD")]
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

		[Cpp2IlInjected.Token(Token = "0x60016DE")]
		[Cpp2IlInjected.Address(RVA = "0x288EE00", Offset = "0x288D800", VA = "0x18288EE00", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60016DF")]
		[Cpp2IlInjected.Address(RVA = "0x288F120", Offset = "0x288DB20", VA = "0x18288F120", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignMicroEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x60016E0")]
		[Cpp2IlInjected.Address(RVA = "0x288F180", Offset = "0x288DB80", VA = "0x18288F180", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60016E1")]
		[Cpp2IlInjected.Address(RVA = "0x288F0A0", Offset = "0x288DAA0", VA = "0x18288F0A0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60016E2")]
		[Cpp2IlInjected.Address(RVA = "0x288F2F0", Offset = "0x288DCF0", VA = "0x18288F2F0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60016E3")]
		[Cpp2IlInjected.Address(RVA = "0x288EEA0", Offset = "0x288D8A0", VA = "0x18288EEA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016E4")]
		[Cpp2IlInjected.Address(RVA = "0x288F210", Offset = "0x288DC10", VA = "0x18288F210", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60016E5")]
		[Cpp2IlInjected.Address(RVA = "0x288F410", Offset = "0x288DE10", VA = "0x18288F410")]
		static CampaignMicroEvent()
		{
			Func<CampaignMicroEvent> func = default(Func<CampaignMicroEvent>);
			_parser = (MessageParser<CampaignMicroEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
