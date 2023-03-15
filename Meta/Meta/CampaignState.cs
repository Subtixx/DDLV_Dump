using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008F5")]
	public sealed class CampaignState : IMessage<CampaignState>, IMessage, IEquatable<CampaignState>, IDeepCloneable<CampaignState>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400244A")]
		private static readonly MessageParser<CampaignState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400244B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400244C")]
		public const int IsActiveFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400244D")]
		private bool isActive_;

		[Cpp2IlInjected.Token(Token = "0x400244E")]
		public const int CountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400244F")]
		private int count_;

		[Cpp2IlInjected.Token(Token = "0x17000D38")]
		[DebuggerNonUserCode]
		public static MessageParser<CampaignState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004DAB")]
			[Cpp2IlInjected.Address(RVA = "0x7188F0", Offset = "0x7172F0", VA = "0x1807188F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D39")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004DAC")]
			[Cpp2IlInjected.Address(RVA = "0x718820", Offset = "0x717220", VA = "0x180718820")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004DAD")]
			[Cpp2IlInjected.Address(RVA = "0x718950", Offset = "0x717350", VA = "0x180718950", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3B")]
		[DebuggerNonUserCode]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6004DB1")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return isActive_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004DB2")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				isActive_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3C")]
		[DebuggerNonUserCode]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6004DB3")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return count_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004DB4")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				count_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CampaignState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAF")]
		[Cpp2IlInjected.Address(RVA = "0x7187C0", Offset = "0x7171C0", VA = "0x1807187C0")]
		[DebuggerNonUserCode]
		public CampaignState(CampaignState other)
		{
			bool flag = (isActive_ = other.isActive_);
			int num = (count_ = other.count_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DB0")]
		[Cpp2IlInjected.Address(RVA = "0x718120", Offset = "0x716B20", VA = "0x180718120", Slot = "10")]
		[DebuggerNonUserCode]
		public CampaignState Clone()
		{
			//Discarded unreachable code: IL_0037
			CampaignState campaignState = new CampaignState();
			bool flag = (campaignState.isActive_ = isActive_);
			int num = (campaignState.count_ = count_);
			UnknownFieldSet unknownFieldSet = (campaignState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return campaignState;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DB5")]
		[Cpp2IlInjected.Address(RVA = "0x7181B0", Offset = "0x716BB0", VA = "0x1807181B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(isActive_ ? 1 : 0) == (IntPtr)typeof(CampaignState).TypeHandle && (IntPtr)count_ == (IntPtr)typeof(CampaignState).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DB6")]
		[Cpp2IlInjected.Address(RVA = "0x718240", Offset = "0x716C40", VA = "0x180718240", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CampaignState other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.isActive_;
				if (isActive_ == flag)
				{
					int num = other.count_;
					if (count_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DB7")]
		[Cpp2IlInjected.Address(RVA = "0x718370", Offset = "0x716D70", VA = "0x180718370", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (isActive_)
				{
				}
				if (count_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DB8")]
		[Cpp2IlInjected.Address(RVA = "0x7185C0", Offset = "0x716FC0", VA = "0x1807185C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DB9")]
		[Cpp2IlInjected.Address(RVA = "0x718620", Offset = "0x717020", VA = "0x180718620", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (isActive_)
			{
				bool value = isActive_;
				output.WriteBool(value);
			}
			if (count_ != 0)
			{
				int value2 = count_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBA")]
		[Cpp2IlInjected.Address(RVA = "0x718060", Offset = "0x716A60", VA = "0x180718060", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = count_;
				if (num != 0)
				{
					int num2 = CodedOutputStream.ComputeInt32Size(num);
					num2++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBB")]
		[Cpp2IlInjected.Address(RVA = "0x718490", Offset = "0x716E90", VA = "0x180718490", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignState other)
		{
			if (other != null)
			{
				bool flag = other.isActive_;
				if (flag)
				{
					isActive_ = flag;
				}
				int num = other.count_;
				if (num != 0)
				{
					count_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBC")]
		[Cpp2IlInjected.Address(RVA = "0x718400", Offset = "0x716E00", VA = "0x180718400", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (isActive_ = input.ReadBool());
				}
				if (num == 16)
				{
					int num2 = (count_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBD")]
		[Cpp2IlInjected.Address(RVA = "0x718280", Offset = "0x716C80", VA = "0x180718280", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = isActive_;
			}
			if (fieldNumber == 2)
			{
				int num = count_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBE")]
		[Cpp2IlInjected.Address(RVA = "0x7184F0", Offset = "0x716EF0", VA = "0x1807184F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				isActive_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			count_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBF")]
		[Cpp2IlInjected.Address(RVA = "0x718100", Offset = "0x716B00", VA = "0x180718100", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				isActive_ = false;
				break;
			case 2:
				count_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC0")]
		[Cpp2IlInjected.Address(RVA = "0x7186B0", Offset = "0x7170B0", VA = "0x1807186B0")]
		static CampaignState()
		{
			Func<CampaignState> func = default(Func<CampaignState>);
			_parser = (MessageParser<CampaignState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
