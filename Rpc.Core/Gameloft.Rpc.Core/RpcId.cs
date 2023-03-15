using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class RpcId : IMessage<RpcId>, IMessage, IEquatable<RpcId>, IDeepCloneable<RpcId>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly MessageParser<RpcId> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public const int ServiceNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private string serviceName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public const int MethodNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private string methodName_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		[DebuggerNonUserCode]
		public static MessageParser<RpcId> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x38E3510", Offset = "0x38E1F10", VA = "0x1838E3510")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x38E3440", Offset = "0x38E1E40", VA = "0x1838E3440")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x38E3570", Offset = "0x38E1F70", VA = "0x1838E3570", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[DebuggerNonUserCode]
		public string ServiceName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return serviceName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x38E36F0", Offset = "0x38E20F0", VA = "0x1838E36F0")]
			set
			{
				string text = (serviceName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		[DebuggerNonUserCode]
		public string MethodName
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return methodName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x38E3680", Offset = "0x38E2080", VA = "0x1838E3680")]
			set
			{
				string text = (methodName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x38E3310", Offset = "0x38E1D10", VA = "0x1838E3310")]
		[DebuggerNonUserCode]
		public RpcId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x38E3370", Offset = "0x38E1D70", VA = "0x1838E3370")]
		[DebuggerNonUserCode]
		public RpcId(RpcId other)
		{
			string text = (serviceName_ = other.serviceName_);
			string text2 = (methodName_ = other.methodName_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x38E2D10", Offset = "0x38E1710", VA = "0x1838E2D10", Slot = "10")]
		[DebuggerNonUserCode]
		public RpcId Clone()
		{
			//Discarded unreachable code: IL_004d
			RpcId rpcId = new RpcId();
			rpcId.serviceName_ = "";
			rpcId.methodName_ = "";
			string text = (rpcId.serviceName_ = serviceName_);
			string text2 = (rpcId.methodName_ = methodName_);
			UnknownFieldSet unknownFieldSet = (rpcId._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return rpcId;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x38E2E10", Offset = "0x38E1810", VA = "0x1838E2E10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = serviceName_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = methodName_;
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

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RpcId other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.serviceName_;
				if (!(serviceName_ != text))
				{
					string text2 = other.methodName_;
					if (!(methodName_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = serviceName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = methodName_;
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

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x38E31A0", Offset = "0x38E1BA0", VA = "0x1838E31A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (serviceName_.m_stringLength != 0)
			{
				string value = serviceName_;
				output.WriteString(value);
			}
			if (methodName_.m_stringLength != 0)
			{
				string value2 = methodName_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x38E2B80", Offset = "0x38E1580", VA = "0x1838E2B80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = serviceName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = methodName_;
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

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x38E3010", Offset = "0x38E1A10", VA = "0x1838E3010", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RpcId other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.serviceName_;
				if (text.m_stringLength != 0)
				{
					ServiceName = text;
				}
				string text2 = other.methodName_;
				if (text2.m_stringLength != 0)
				{
					MethodName = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x38E2F60", Offset = "0x38E1960", VA = "0x1838E2F60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (ServiceName = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (MethodName = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x38E2ED0", Offset = "0x38E18D0", VA = "0x1838E2ED0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = serviceName_;
			}
			if (fieldNumber == 2)
			{
				string text2 = methodName_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x38E3090", Offset = "0x38E1A90", VA = "0x1838E3090", Slot = "12")]
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
				string text = (serviceName_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
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

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x38E2C60", Offset = "0x38E1660", VA = "0x1838E2C60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (serviceName_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				MethodName = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x38E3200", Offset = "0x38E1C00", VA = "0x1838E3200")]
		static RpcId()
		{
			Func<RpcId> func = default(Func<RpcId>);
			_parser = (MessageParser<RpcId>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
