using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002C9")]
	public sealed class ContainerInteraction : IMessage<ContainerInteraction>, IMessage, IEquatable<ContainerInteraction>, IDeepCloneable<ContainerInteraction>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000C86")]
		private static readonly MessageParser<ContainerInteraction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C87")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C88")]
		public const int DefaultContainerInventoryDataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C89")]
		private string defaultContainerInventoryData_ = "";

		[Cpp2IlInjected.Token(Token = "0x170006D3")]
		[DebuggerNonUserCode]
		public static MessageParser<ContainerInteraction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE0")]
			[Cpp2IlInjected.Address(RVA = "0x327D130", Offset = "0x327BB30", VA = "0x18327D130")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE1")]
			[Cpp2IlInjected.Address(RVA = "0x327D060", Offset = "0x327BA60", VA = "0x18327D060")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE2")]
			[Cpp2IlInjected.Address(RVA = "0x327D190", Offset = "0x327BB90", VA = "0x18327D190", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D6")]
		[DebuggerNonUserCode]
		public string DefaultContainerInventoryData
		{
			[Cpp2IlInjected.Token(Token = "0x6001DE6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return defaultContainerInventoryData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DE7")]
			[Cpp2IlInjected.Address(RVA = "0x327D2A0", Offset = "0x327BCA0", VA = "0x18327D2A0")]
			set
			{
				string text = (defaultContainerInventoryData_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE3")]
		[Cpp2IlInjected.Address(RVA = "0x327CF70", Offset = "0x327B970", VA = "0x18327CF70")]
		[DebuggerNonUserCode]
		public ContainerInteraction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE4")]
		[Cpp2IlInjected.Address(RVA = "0x327CFC0", Offset = "0x327B9C0", VA = "0x18327CFC0")]
		[DebuggerNonUserCode]
		public ContainerInteraction(ContainerInteraction other)
		{
			string text = (defaultContainerInventoryData_ = other.defaultContainerInventoryData_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE5")]
		[Cpp2IlInjected.Address(RVA = "0x327C8C0", Offset = "0x327B2C0", VA = "0x18327C8C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ContainerInteraction Clone()
		{
			//Discarded unreachable code: IL_0034
			ContainerInteraction containerInteraction = new ContainerInteraction();
			containerInteraction.defaultContainerInventoryData_ = "";
			string text = (containerInteraction.defaultContainerInventoryData_ = defaultContainerInventoryData_);
			UnknownFieldSet unknownFieldSet = (containerInteraction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return containerInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE8")]
		[Cpp2IlInjected.Address(RVA = "0x327C980", Offset = "0x327B380", VA = "0x18327C980", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = defaultContainerInventoryData_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DE9")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ContainerInteraction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.defaultContainerInventoryData_;
				if (!(defaultContainerInventoryData_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEA")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = defaultContainerInventoryData_;
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

		[Cpp2IlInjected.Token(Token = "0x6001DEB")]
		[Cpp2IlInjected.Address(RVA = "0x327CE00", Offset = "0x327B800", VA = "0x18327CE00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEC")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (defaultContainerInventoryData_.m_stringLength != 0)
			{
				string value = defaultContainerInventoryData_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DED")]
		[Cpp2IlInjected.Address(RVA = "0x327C790", Offset = "0x327B190", VA = "0x18327C790", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = defaultContainerInventoryData_;
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

		[Cpp2IlInjected.Token(Token = "0x6001DEE")]
		[Cpp2IlInjected.Address(RVA = "0x327CCE0", Offset = "0x327B6E0", VA = "0x18327CCE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ContainerInteraction other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.defaultContainerInventoryData_;
				if (text.m_stringLength != 0)
				{
					DefaultContainerInventoryData = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DEF")]
		[Cpp2IlInjected.Address(RVA = "0x327CC50", Offset = "0x327B650", VA = "0x18327CC50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (DefaultContainerInventoryData = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF0")]
		[Cpp2IlInjected.Address(RVA = "0x327CA30", Offset = "0x327B430", VA = "0x18327CA30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = defaultContainerInventoryData_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF1")]
		[Cpp2IlInjected.Address(RVA = "0x327CD40", Offset = "0x327B740", VA = "0x18327CD40", Slot = "12")]
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
				string text = (defaultContainerInventoryData_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF2")]
		[Cpp2IlInjected.Address(RVA = "0x327C830", Offset = "0x327B230", VA = "0x18327C830", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (defaultContainerInventoryData_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF3")]
		[Cpp2IlInjected.Address(RVA = "0x327CAB0", Offset = "0x327B4B0", VA = "0x18327CAB0")]
		public IGridStateData GetGridStateData(Item item, in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_0032: Expected I4, but got O
			string text = defaultContainerInventoryData_;
			int num = 0;
			if ((object)typeof(StorageGridData).TypeHandle == null && (object)typeof(StorageGridData).TypeHandle != null)
			{
				StorageGridData storageGridData = new StorageGridData();
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				storageGridData.containerInventoryID_ = (uint)(int)storageGridData;
			}
			text += text;
			num += 312;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DF4")]
		[Cpp2IlInjected.Address(RVA = "0x327CE60", Offset = "0x327B860", VA = "0x18327CE60")]
		static ContainerInteraction()
		{
			Func<ContainerInteraction> func = default(Func<ContainerInteraction>);
			_parser = (MessageParser<ContainerInteraction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
