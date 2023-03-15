using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002D1")]
	public sealed class IndexInteraction : IMessage<IndexInteraction>, IMessage, IEquatable<IndexInteraction>, IDeepCloneable<IndexInteraction>, IMessageFieldAccessor, IGridStateDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4000C9C")]
		private static readonly MessageParser<IndexInteraction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C9D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C9E")]
		public const int DefaultValueFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C9F")]
		private int defaultValue_;

		[Cpp2IlInjected.Token(Token = "0x170006E0")]
		[DebuggerNonUserCode]
		public static MessageParser<IndexInteraction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001E2D")]
			[Cpp2IlInjected.Address(RVA = "0x27BC4B0", Offset = "0x27BAEB0", VA = "0x1827BC4B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E2E")]
			[Cpp2IlInjected.Address(RVA = "0x27BC3E0", Offset = "0x27BADE0", VA = "0x1827BC3E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E2F")]
			[Cpp2IlInjected.Address(RVA = "0x27BC510", Offset = "0x27BAF10", VA = "0x1827BC510", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E3")]
		[DebuggerNonUserCode]
		public int DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6001E33")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return defaultValue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E34")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				defaultValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E30")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public IndexInteraction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001E31")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public IndexInteraction(IndexInteraction other)
		{
			int num = (defaultValue_ = other.defaultValue_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E32")]
		[Cpp2IlInjected.Address(RVA = "0x27BBFC0", Offset = "0x27BA9C0", VA = "0x1827BBFC0", Slot = "10")]
		[DebuggerNonUserCode]
		public IndexInteraction Clone()
		{
			//Discarded unreachable code: IL_0029
			IndexInteraction indexInteraction = new IndexInteraction();
			int num = (indexInteraction.defaultValue_ = defaultValue_);
			UnknownFieldSet unknownFieldSet = (indexInteraction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return indexInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E35")]
		[Cpp2IlInjected.Address(RVA = "0x27BC0B0", Offset = "0x27BAAB0", VA = "0x1827BC0B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)defaultValue_ == (IntPtr)typeof(IndexInteraction).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E36")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(IndexInteraction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.defaultValue_;
				if (defaultValue_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E37")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (defaultValue_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E38")]
		[Cpp2IlInjected.Address(RVA = "0x27BC270", Offset = "0x27BAC70", VA = "0x1827BC270", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E39")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (defaultValue_ != 0)
			{
				int value = defaultValue_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3A")]
		[Cpp2IlInjected.Address(RVA = "0x27BBF20", Offset = "0x27BA920", VA = "0x1827BBF20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = defaultValue_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3B")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(IndexInteraction other)
		{
			if (other != null)
			{
				int num = other.defaultValue_;
				if (num != 0)
				{
					defaultValue_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3C")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (defaultValue_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3D")]
		[Cpp2IlInjected.Address(RVA = "0x27BC140", Offset = "0x27BAB40", VA = "0x1827BC140", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = defaultValue_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3E")]
		[Cpp2IlInjected.Address(RVA = "0x27BC1F0", Offset = "0x27BABF0", VA = "0x1827BC1F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				defaultValue_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3F")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				defaultValue_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E40")]
		[Cpp2IlInjected.Address(RVA = "0x27BC040", Offset = "0x27BAA40", VA = "0x1827BC040")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			IndexGridData indexGridData = new IndexGridData();
			int num = (indexGridData.currentIndex_ = defaultValue_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E41")]
		[Cpp2IlInjected.Address(RVA = "0x27BC2D0", Offset = "0x27BACD0", VA = "0x1827BC2D0")]
		static IndexInteraction()
		{
			Func<IndexInteraction> func = default(Func<IndexInteraction>);
			_parser = (MessageParser<IndexInteraction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E42")]
		[Cpp2IlInjected.Address(RVA = "0x27BC040", Offset = "0x27BAA40", VA = "0x1827BC040", Slot = "14")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			IndexGridData indexGridData = new IndexGridData();
			int num = (indexGridData.currentIndex_ = defaultValue_);
			throw new NullReferenceException();
		}
	}
}
