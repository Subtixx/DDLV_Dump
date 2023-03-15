using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Campaign
{
	[Cpp2IlInjected.Token(Token = "0x2000263")]
	public sealed class CampaignMiniEvent : IMessage<CampaignMiniEvent>, IMessage, IEquatable<CampaignMiniEvent>, IDeepCloneable<CampaignMiniEvent>, IMessageFieldAccessor, ICampaignType
	{
		[Cpp2IlInjected.Token(Token = "0x4000982")]
		private static readonly MessageParser<CampaignMiniEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000983")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000984")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000985")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700050B")]
		[DebuggerNonUserCode]
		public static MessageParser<CampaignMiniEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60016B9")]
			[Cpp2IlInjected.Address(RVA = "0x28901A0", Offset = "0x288EBA0", VA = "0x1828901A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016BA")]
			[Cpp2IlInjected.Address(RVA = "0x28900D0", Offset = "0x288EAD0", VA = "0x1828900D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016BB")]
			[Cpp2IlInjected.Address(RVA = "0x2890200", Offset = "0x288EC00", VA = "0x182890200", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050E")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60016BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60016C0")]
			[Cpp2IlInjected.Address(RVA = "0x2890310", Offset = "0x288ED10", VA = "0x182890310")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016BC")]
		[Cpp2IlInjected.Address(RVA = "0x288FFE0", Offset = "0x288E9E0", VA = "0x18288FFE0")]
		[DebuggerNonUserCode]
		public CampaignMiniEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60016BD")]
		[Cpp2IlInjected.Address(RVA = "0x2890030", Offset = "0x288EA30", VA = "0x182890030")]
		[DebuggerNonUserCode]
		public CampaignMiniEvent(CampaignMiniEvent other)
		{
			string text = (name_ = other.name_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016BE")]
		[Cpp2IlInjected.Address(RVA = "0x288F9F0", Offset = "0x288E3F0", VA = "0x18288F9F0", Slot = "10")]
		[DebuggerNonUserCode]
		public CampaignMiniEvent Clone()
		{
			//Discarded unreachable code: IL_0034
			CampaignMiniEvent campaignMiniEvent = new CampaignMiniEvent();
			campaignMiniEvent.name_ = "";
			string text = (campaignMiniEvent.name_ = name_);
			UnknownFieldSet unknownFieldSet = (campaignMiniEvent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return campaignMiniEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x60016C1")]
		[Cpp2IlInjected.Address(RVA = "0x288FAB0", Offset = "0x288E4B0", VA = "0x18288FAB0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60016C2")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CampaignMiniEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x60016C3")]
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

		[Cpp2IlInjected.Token(Token = "0x60016C4")]
		[Cpp2IlInjected.Address(RVA = "0x288FE70", Offset = "0x288E870", VA = "0x18288FE70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60016C5")]
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

		[Cpp2IlInjected.Token(Token = "0x60016C6")]
		[Cpp2IlInjected.Address(RVA = "0x288F8C0", Offset = "0x288E2C0", VA = "0x18288F8C0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60016C7")]
		[Cpp2IlInjected.Address(RVA = "0x288FC70", Offset = "0x288E670", VA = "0x18288FC70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignMiniEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x60016C8")]
		[Cpp2IlInjected.Address(RVA = "0x288FBE0", Offset = "0x288E5E0", VA = "0x18288FBE0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60016C9")]
		[Cpp2IlInjected.Address(RVA = "0x288FB60", Offset = "0x288E560", VA = "0x18288FB60", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60016CA")]
		[Cpp2IlInjected.Address(RVA = "0x288FDB0", Offset = "0x288E7B0", VA = "0x18288FDB0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60016CB")]
		[Cpp2IlInjected.Address(RVA = "0x288F960", Offset = "0x288E360", VA = "0x18288F960", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016CC")]
		[Cpp2IlInjected.Address(RVA = "0x288FCD0", Offset = "0x288E6D0", VA = "0x18288FCD0", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60016CD")]
		[Cpp2IlInjected.Address(RVA = "0x288FED0", Offset = "0x288E8D0", VA = "0x18288FED0")]
		static CampaignMiniEvent()
		{
			Func<CampaignMiniEvent> func = default(Func<CampaignMiniEvent>);
			_parser = (MessageParser<CampaignMiniEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
