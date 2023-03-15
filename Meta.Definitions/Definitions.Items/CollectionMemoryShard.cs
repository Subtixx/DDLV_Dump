using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005B7")]
	public sealed class CollectionMemoryShard : IMessage<CollectionMemoryShard>, IMessage, IEquatable<CollectionMemoryShard>, IDeepCloneable<CollectionMemoryShard>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005B8")]
		public enum MemoryShardFilterTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001F3E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001F3F")]
			Universe,
			[Cpp2IlInjected.Token(Token = "0x4001F40")]
			MemoryShardSubType
		}

		[Cpp2IlInjected.Token(Token = "0x4001F37")]
		private static readonly MessageParser<CollectionMemoryShard> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F38")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F39")]
		public const int UniverseFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001F3A")]
		public const int MemoryShardSubTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F3B")]
		private object memoryShardFilterType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F3C")]
		private MemoryShardFilterTypeOneofCase memoryShardFilterTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17001277")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionMemoryShard> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004765")]
			[Cpp2IlInjected.Address(RVA = "0x320AFB0", Offset = "0x32099B0", VA = "0x18320AFB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001278")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004766")]
			[Cpp2IlInjected.Address(RVA = "0x320AE70", Offset = "0x3209870", VA = "0x18320AE70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001279")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004767")]
			[Cpp2IlInjected.Address(RVA = "0x320B080", Offset = "0x3209A80", VA = "0x18320B080", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700127A")]
		[DebuggerNonUserCode]
		public int Universe
		{
			[Cpp2IlInjected.Token(Token = "0x600476B")]
			[Cpp2IlInjected.Address(RVA = "0x320B010", Offset = "0x3209A10", VA = "0x18320B010")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.Universe)
				{
					object obj = memoryShardFilterType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x600476C")]
			[Cpp2IlInjected.Address(RVA = "0x320B200", Offset = "0x3209C00", VA = "0x18320B200")]
			set
			{
				//IL_0014: Expected I4, but got I8
				memoryShardFilterType_ = typeof(int).TypeHandle;
				memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.Universe;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700127B")]
		[DebuggerNonUserCode]
		public int MemoryShardSubType
		{
			[Cpp2IlInjected.Token(Token = "0x600476D")]
			[Cpp2IlInjected.Address(RVA = "0x320AF40", Offset = "0x3209940", VA = "0x18320AF40")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.MemoryShardSubType)
				{
					object obj = memoryShardFilterType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x600476E")]
			[Cpp2IlInjected.Address(RVA = "0x320B190", Offset = "0x3209B90", VA = "0x18320B190")]
			set
			{
				//IL_0014: Expected I4, but got I8
				memoryShardFilterType_ = typeof(int).TypeHandle;
				memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.MemoryShardSubType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700127C")]
		[DebuggerNonUserCode]
		public MemoryShardFilterTypeOneofCase MemoryShardFilterTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x600476F")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return memoryShardFilterTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004768")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionMemoryShard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004769")]
		[Cpp2IlInjected.Address(RVA = "0x320ADA0", Offset = "0x32097A0", VA = "0x18320ADA0")]
		[DebuggerNonUserCode]
		public CollectionMemoryShard(CollectionMemoryShard other)
		{
			//IL_002c: Expected I4, but got I8
			MemoryShardFilterTypeOneofCase memoryShardFilterTypeOneofCase = other.memoryShardFilterTypeCase_;
			if (memoryShardFilterTypeOneofCase == MemoryShardFilterTypeOneofCase.Universe)
			{
				int universe = other.Universe;
				memoryShardFilterType_ = typeof(int).TypeHandle;
				memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.Universe;
			}
			if (memoryShardFilterTypeOneofCase == MemoryShardFilterTypeOneofCase.MemoryShardSubType)
			{
				int num = (MemoryShardSubType = other.MemoryShardSubType);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600476A")]
		[Cpp2IlInjected.Address(RVA = "0x320A410", Offset = "0x3208E10", VA = "0x18320A410", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionMemoryShard Clone()
		{
			//Discarded unreachable code: IL_0055
			//IL_002c: Expected I4, but got I8
			CollectionMemoryShard collectionMemoryShard = new CollectionMemoryShard();
			MemoryShardFilterTypeOneofCase memoryShardFilterTypeOneofCase = memoryShardFilterTypeCase_;
			if (memoryShardFilterTypeOneofCase == MemoryShardFilterTypeOneofCase.Universe)
			{
				int universe = Universe;
				collectionMemoryShard.memoryShardFilterType_ = typeof(int).TypeHandle;
				collectionMemoryShard.memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.Universe;
			}
			if (memoryShardFilterTypeOneofCase == MemoryShardFilterTypeOneofCase.MemoryShardSubType)
			{
				int num = (collectionMemoryShard.MemoryShardSubType = MemoryShardSubType);
			}
			UnknownFieldSet unknownFieldSet = (collectionMemoryShard._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionMemoryShard;
		}

		[Cpp2IlInjected.Token(Token = "0x6004770")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearMemoryShardFilterType()
		{
			//IL_0010: Expected O, but got I4
			memoryShardFilterType_ = (memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004771")]
		[Cpp2IlInjected.Address(RVA = "0x320A510", Offset = "0x3208F10", VA = "0x18320A510", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_003d: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int universe = Universe;
				int num = default(int);
				if (universe == num)
				{
					int memoryShardSubType = MemoryShardSubType;
					int num2 = 0;
					universe = memoryShardSubType;
					int num3 = default(int);
					if (universe == num3 && memoryShardFilterTypeCase_ == (MemoryShardFilterTypeOneofCase)num3)
					{
						return object.Equals(_unknownFields, num2);
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004772")]
		[Cpp2IlInjected.Address(RVA = "0x320A5F0", Offset = "0x3208FF0", VA = "0x18320A5F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionMemoryShard other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int universe = Universe;
				int universe2 = other.Universe;
				if (universe == universe2)
				{
					universe = MemoryShardSubType;
					int memoryShardSubType = other.MemoryShardSubType;
					if (universe == memoryShardSubType)
					{
						MemoryShardFilterTypeOneofCase memoryShardFilterTypeOneofCase = other.memoryShardFilterTypeCase_;
						if (memoryShardFilterTypeCase_ == memoryShardFilterTypeOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004773")]
		[Cpp2IlInjected.Address(RVA = "0x320A760", Offset = "0x3209160", VA = "0x18320A760", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0049
			int num = 0;
			if (memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.Universe)
			{
				if (memoryShardFilterTypeCase_ != MemoryShardFilterTypeOneofCase.Universe)
				{
				}
				object obj = memoryShardFilterType_;
			}
			if (memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.MemoryShardSubType && memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.MemoryShardSubType)
			{
				object obj2 = memoryShardFilterType_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004774")]
		[Cpp2IlInjected.Address(RVA = "0x320AB90", Offset = "0x3209590", VA = "0x18320AB90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004775")]
		[Cpp2IlInjected.Address(RVA = "0x320ABF0", Offset = "0x32095F0", VA = "0x18320ABF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003e
			MemoryShardFilterTypeOneofCase memoryShardFilterTypeOneofCase = memoryShardFilterTypeCase_;
			if (memoryShardFilterTypeOneofCase == MemoryShardFilterTypeOneofCase.Universe)
			{
				int universe = Universe;
				output.WriteInt32(universe);
			}
			if (memoryShardFilterTypeOneofCase == MemoryShardFilterTypeOneofCase.MemoryShardSubType)
			{
				int memoryShardSubType = MemoryShardSubType;
				output.WriteInt32(memoryShardSubType);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004776")]
		[Cpp2IlInjected.Address(RVA = "0x320A170", Offset = "0x3208B70", VA = "0x18320A170", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0061
			int num = 0;
			if (memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.Universe)
			{
				if (memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.Universe)
				{
					object obj = memoryShardFilterType_;
				}
				int num2 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.MemoryShardSubType)
			{
				if (memoryShardFilterTypeCase_ == MemoryShardFilterTypeOneofCase.MemoryShardSubType)
				{
					object obj2 = memoryShardFilterType_;
				}
				num++;
				int num3 = default(int);
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

		[Cpp2IlInjected.Token(Token = "0x6004777")]
		[Cpp2IlInjected.Address(RVA = "0x320A9F0", Offset = "0x32093F0", VA = "0x18320A9F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionMemoryShard other)
		{
			if (other != null)
			{
				MemoryShardFilterTypeOneofCase memoryShardFilterTypeOneofCase = other.memoryShardFilterTypeCase_;
				if (memoryShardFilterTypeOneofCase == MemoryShardFilterTypeOneofCase.Universe)
				{
					int num = (Universe = other.Universe);
				}
				if (memoryShardFilterTypeOneofCase == MemoryShardFilterTypeOneofCase.MemoryShardSubType)
				{
					int num2 = (MemoryShardSubType = other.MemoryShardSubType);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004778")]
		[Cpp2IlInjected.Address(RVA = "0x320A940", Offset = "0x3209340", VA = "0x18320A940", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num3 = (Universe = input.ReadInt32());
				}
				if (num == 16)
				{
					int num5 = (MemoryShardSubType = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004779")]
		[Cpp2IlInjected.Address(RVA = "0x320A690", Offset = "0x3209090", VA = "0x18320A690", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int universe = Universe;
			}
			if (fieldNumber == 2)
			{
				int memoryShardSubType = MemoryShardSubType;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600477A")]
		[Cpp2IlInjected.Address(RVA = "0x320AA70", Offset = "0x3209470", VA = "0x18320AA70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001e
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				memoryShardFilterType_ = typeof(int).TypeHandle;
				memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.Universe;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600477B")]
		[Cpp2IlInjected.Address(RVA = "0x320A2E0", Offset = "0x3208CE0", VA = "0x18320A2E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_0020: Expected O, but got I4
			//IL_0029: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				int num2 = default(int);
				memoryShardFilterType_ = num2;
				memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.Universe;
				break;
			}
			case 2:
			{
				int num = default(int);
				memoryShardFilterType_ = num;
				memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.MemoryShardSubType;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600477C")]
		[Cpp2IlInjected.Address(RVA = "0x320A890", Offset = "0x3209290", VA = "0x18320A890", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "MemoryShardFilterType"))
			{
				MemoryShardFilterTypeOneofCase memoryShardFilterTypeOneofCase = memoryShardFilterTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600477D")]
		[Cpp2IlInjected.Address(RVA = "0x320A3A0", Offset = "0x3208DA0", VA = "0x18320A3A0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "MemoryShardFilterType"))
			{
				memoryShardFilterType_ = (memoryShardFilterTypeCase_ = MemoryShardFilterTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600477E")]
		[Cpp2IlInjected.Address(RVA = "0x320AC90", Offset = "0x3209690", VA = "0x18320AC90")]
		static CollectionMemoryShard()
		{
			Func<CollectionMemoryShard> func = default(Func<CollectionMemoryShard>);
			_parser = (MessageParser<CollectionMemoryShard>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
