using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class InboxMessageKey : IMessage<InboxMessageKey>, IMessage, IEquatable<InboxMessageKey>, IDeepCloneable<InboxMessageKey>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private static readonly MessageParser<InboxMessageKey> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private string id_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public const int OnlineInstanceIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private string onlineInstanceId_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000276")]
		[DebuggerNonUserCode]
		public static MessageParser<InboxMessageKey> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x27B5F50", Offset = "0x27B4950", VA = "0x1827B5F50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x27B5E80", Offset = "0x27B4880", VA = "0x1827B5E80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x27B5FB0", Offset = "0x27B49B0", VA = "0x1827B5FB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		[DebuggerNonUserCode]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x27B60C0", Offset = "0x27B4AC0", VA = "0x1827B60C0")]
			set
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		[DebuggerNonUserCode]
		public string OnlineInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return onlineInstanceId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x27B6130", Offset = "0x27B4B30", VA = "0x1827B6130")]
			set
			{
				string text = (onlineInstanceId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x27B5E20", Offset = "0x27B4820", VA = "0x1827B5E20")]
		[DebuggerNonUserCode]
		public InboxMessageKey()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x27B5D50", Offset = "0x27B4750", VA = "0x1827B5D50")]
		[DebuggerNonUserCode]
		public InboxMessageKey(InboxMessageKey other)
		{
			string text = (id_ = other.id_);
			string text2 = (onlineInstanceId_ = other.onlineInstanceId_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x27B5750", Offset = "0x27B4150", VA = "0x1827B5750", Slot = "10")]
		[DebuggerNonUserCode]
		public InboxMessageKey Clone()
		{
			//Discarded unreachable code: IL_004d
			InboxMessageKey inboxMessageKey = new InboxMessageKey();
			inboxMessageKey.id_ = "";
			inboxMessageKey.onlineInstanceId_ = "";
			string text = (inboxMessageKey.id_ = id_);
			string text2 = (inboxMessageKey.onlineInstanceId_ = onlineInstanceId_);
			UnknownFieldSet unknownFieldSet = (inboxMessageKey._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return inboxMessageKey;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x27B5850", Offset = "0x27B4250", VA = "0x1827B5850", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = id_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = onlineInstanceId_;
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

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(InboxMessageKey other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.id_;
				if (!(id_ != text))
				{
					string text2 = other.onlineInstanceId_;
					if (!(onlineInstanceId_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = id_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = onlineInstanceId_;
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

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x27B5BE0", Offset = "0x27B45E0", VA = "0x1827B5BE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (id_.m_stringLength != 0)
			{
				string value = id_;
				output.WriteString(value);
			}
			if (onlineInstanceId_.m_stringLength != 0)
			{
				string value2 = onlineInstanceId_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x27B55C0", Offset = "0x27B3FC0", VA = "0x1827B55C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = id_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = onlineInstanceId_;
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

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x27B59A0", Offset = "0x27B43A0", VA = "0x1827B59A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(InboxMessageKey other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.id_;
				if (text.m_stringLength != 0)
				{
					Id = text;
				}
				string text2 = other.onlineInstanceId_;
				if (text2.m_stringLength != 0)
				{
					OnlineInstanceId = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x27B5A20", Offset = "0x27B4420", VA = "0x1827B5A20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Id = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (OnlineInstanceId = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x27B5910", Offset = "0x27B4310", VA = "0x1827B5910", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = id_;
			}
			if (fieldNumber == 2)
			{
				string text2 = onlineInstanceId_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x27B5AD0", Offset = "0x27B44D0", VA = "0x1827B5AD0", Slot = "12")]
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
				string text = (id_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
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

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x27B56A0", Offset = "0x27B40A0", VA = "0x1827B56A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				OnlineInstanceId = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x27B5C40", Offset = "0x27B4640", VA = "0x1827B5C40")]
		static InboxMessageKey()
		{
			Func<InboxMessageKey> func = default(Func<InboxMessageKey>);
			_parser = (MessageParser<InboxMessageKey>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
