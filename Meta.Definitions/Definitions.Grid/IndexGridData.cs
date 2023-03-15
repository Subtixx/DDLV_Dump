using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000707")]
	public sealed class IndexGridData : IMessage<IndexGridData>, IMessage, IEquatable<IndexGridData>, IDeepCloneable<IndexGridData>, IMessageFieldAccessor, IGridStateData
	{
		[Cpp2IlInjected.Token(Token = "0x4002399")]
		private static readonly MessageParser<IndexGridData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400239A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400239B")]
		public const int CurrentIndexFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400239C")]
		private int currentIndex_;

		[Cpp2IlInjected.Token(Token = "0x1700140F")]
		[DebuggerNonUserCode]
		public static MessageParser<IndexGridData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E5D")]
			[Cpp2IlInjected.Address(RVA = "0x27BBDB0", Offset = "0x27BA7B0", VA = "0x1827BBDB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001410")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E5E")]
			[Cpp2IlInjected.Address(RVA = "0x27BBCE0", Offset = "0x27BA6E0", VA = "0x1827BBCE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001411")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E5F")]
			[Cpp2IlInjected.Address(RVA = "0x27BBE10", Offset = "0x27BA810", VA = "0x1827BBE10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001412")]
		[DebuggerNonUserCode]
		public int CurrentIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6004E63")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return currentIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E64")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				currentIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E60")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public IndexGridData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E61")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public IndexGridData(IndexGridData other)
		{
			int num = (currentIndex_ = other.currentIndex_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E62")]
		[Cpp2IlInjected.Address(RVA = "0x27BB930", Offset = "0x27BA330", VA = "0x1827BB930", Slot = "10")]
		[DebuggerNonUserCode]
		public IndexGridData Clone()
		{
			//Discarded unreachable code: IL_0029
			IndexGridData indexGridData = new IndexGridData();
			int num = (indexGridData.currentIndex_ = currentIndex_);
			UnknownFieldSet unknownFieldSet = (indexGridData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return indexGridData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E65")]
		[Cpp2IlInjected.Address(RVA = "0x27BB9B0", Offset = "0x27BA3B0", VA = "0x1827BB9B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)currentIndex_ == (IntPtr)typeof(IndexGridData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E66")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(IndexGridData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.currentIndex_;
				if (currentIndex_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E67")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (currentIndex_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E68")]
		[Cpp2IlInjected.Address(RVA = "0x27BBB70", Offset = "0x27BA570", VA = "0x1827BBB70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E69")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (currentIndex_ != 0)
			{
				int value = currentIndex_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6A")]
		[Cpp2IlInjected.Address(RVA = "0x27BB890", Offset = "0x27BA290", VA = "0x1827BB890", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = currentIndex_;
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

		[Cpp2IlInjected.Token(Token = "0x6004E6B")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(IndexGridData other)
		{
			if (other != null)
			{
				int num = other.currentIndex_;
				if (num != 0)
				{
					currentIndex_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6C")]
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
					int num2 = (currentIndex_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6D")]
		[Cpp2IlInjected.Address(RVA = "0x27BBA40", Offset = "0x27BA440", VA = "0x1827BBA40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = currentIndex_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6E")]
		[Cpp2IlInjected.Address(RVA = "0x27BBAF0", Offset = "0x27BA4F0", VA = "0x1827BBAF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				currentIndex_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6F")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				currentIndex_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E70")]
		[Cpp2IlInjected.Address(RVA = "0x27BBBD0", Offset = "0x27BA5D0", VA = "0x1827BBBD0")]
		static IndexGridData()
		{
			Func<IndexGridData> func = default(Func<IndexGridData>);
			_parser = (MessageParser<IndexGridData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
