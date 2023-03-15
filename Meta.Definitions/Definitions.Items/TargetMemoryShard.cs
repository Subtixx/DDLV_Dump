using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200047D")]
	public sealed class TargetMemoryShard : IMessage<TargetMemoryShard>, IMessage, IEquatable<TargetMemoryShard>, IDeepCloneable<TargetMemoryShard>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001820")]
		private static readonly MessageParser<TargetMemoryShard> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001821")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001822")]
		public const int MemoryShardFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001823")]
		private int memoryShard_;

		[Cpp2IlInjected.Token(Token = "0x4001824")]
		public const int MemoryShardIndexFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001825")]
		private int memoryShardIndex_;

		[Cpp2IlInjected.Token(Token = "0x4001826")]
		public const int CompletedFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001827")]
		private bool completed_;

		[Cpp2IlInjected.Token(Token = "0x17000DFE")]
		[DebuggerNonUserCode]
		public static MessageParser<TargetMemoryShard> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60036F8")]
			[Cpp2IlInjected.Address(RVA = "0x3546000", Offset = "0x3544A00", VA = "0x183546000")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60036F9")]
			[Cpp2IlInjected.Address(RVA = "0x3545ED0", Offset = "0x35448D0", VA = "0x183545ED0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E00")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60036FA")]
			[Cpp2IlInjected.Address(RVA = "0x3546060", Offset = "0x3544A60", VA = "0x183546060", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E01")]
		[DebuggerNonUserCode]
		public int MemoryShard
		{
			[Cpp2IlInjected.Token(Token = "0x60036FE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return memoryShard_;
			}
			[Cpp2IlInjected.Token(Token = "0x60036FF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				memoryShard_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E02")]
		[DebuggerNonUserCode]
		public int MemoryShardIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6003700")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return memoryShardIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003701")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				memoryShardIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E03")]
		[DebuggerNonUserCode]
		public bool Completed
		{
			[Cpp2IlInjected.Token(Token = "0x6003702")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return completed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003703")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				completed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E04")]
		public Item MemoryShardItem
		{
			[Cpp2IlInjected.Token(Token = "0x600370F")]
			[Cpp2IlInjected.Address(RVA = "0x3545FA0", Offset = "0x35449A0", VA = "0x183545FA0")]
			get
			{
				long num = Convert.ToInt64((uint)memoryShard_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036FB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public TargetMemoryShard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60036FC")]
		[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
		[DebuggerNonUserCode]
		public TargetMemoryShard(TargetMemoryShard other)
		{
			int num = (memoryShard_ = other.memoryShard_);
			int num2 = (memoryShardIndex_ = other.memoryShardIndex_);
			bool flag = (completed_ = other.completed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036FD")]
		[Cpp2IlInjected.Address(RVA = "0x3545A20", Offset = "0x3544420", VA = "0x183545A20", Slot = "10")]
		[DebuggerNonUserCode]
		public TargetMemoryShard Clone()
		{
			//Discarded unreachable code: IL_0047
			TargetMemoryShard targetMemoryShard = new TargetMemoryShard();
			int num = (targetMemoryShard.memoryShard_ = memoryShard_);
			int num2 = (targetMemoryShard.memoryShardIndex_ = memoryShardIndex_);
			bool flag = (targetMemoryShard.completed_ = completed_);
			UnknownFieldSet unknownFieldSet = (targetMemoryShard._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return targetMemoryShard;
		}

		[Cpp2IlInjected.Token(Token = "0x6003704")]
		[Cpp2IlInjected.Address(RVA = "0x3545AB0", Offset = "0x35444B0", VA = "0x183545AB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)memoryShard_ == (IntPtr)typeof(TargetMemoryShard).TypeHandle && (IntPtr)memoryShardIndex_ == (IntPtr)typeof(TargetMemoryShard).TypeHandle && (IntPtr)(completed_ ? 1 : 0) == (IntPtr)typeof(TargetMemoryShard).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003705")]
		[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TargetMemoryShard other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.memoryShard_;
				if (memoryShard_ == num)
				{
					int num2 = other.memoryShardIndex_;
					if (memoryShardIndex_ == num2)
					{
						bool flag = other.completed_;
						if (completed_ == flag)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003706")]
		[Cpp2IlInjected.Address(RVA = "0x75BE10", Offset = "0x75A810", VA = "0x18075BE10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (memoryShard_ != 0)
				{
				}
				if (memoryShardIndex_ != 0)
				{
				}
				if (completed_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003707")]
		[Cpp2IlInjected.Address(RVA = "0x3545D60", Offset = "0x3544760", VA = "0x183545D60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003708")]
		[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (memoryShard_ != 0)
			{
				int value = memoryShard_;
				output.WriteInt32(value);
			}
			if (memoryShardIndex_ != 0)
			{
				int value2 = memoryShardIndex_;
				output.WriteInt32(value2);
			}
			if (completed_)
			{
				bool value3 = completed_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003709")]
		[Cpp2IlInjected.Address(RVA = "0x3545950", Offset = "0x3544350", VA = "0x183545950", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = memoryShard_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = memoryShardIndex_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600370A")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TargetMemoryShard other)
		{
			if (other != null)
			{
				int num = other.memoryShard_;
				if (num != 0)
				{
					memoryShard_ = num;
				}
				int num2 = other.memoryShardIndex_;
				if (num2 != 0)
				{
					memoryShardIndex_ = num2;
				}
				bool flag = other.completed_;
				if (flag)
				{
					completed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600370B")]
		[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (memoryShard_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (memoryShardIndex_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					bool flag = (completed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600370C")]
		[Cpp2IlInjected.Address(RVA = "0x3545B50", Offset = "0x3544550", VA = "0x183545B50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_001e;
				}
				bool flag = completed_;
			}
			int num2 = memoryShard_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600370D")]
		[Cpp2IlInjected.Address(RVA = "0x3545C40", Offset = "0x3544640", VA = "0x183545C40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					completed_ = (byte)(int)obj2 != 0;
					break;
				}
				case 0:
				{
					object obj = default(object);
					memoryShardIndex_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				memoryShard_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600370E")]
		[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				completed_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003710")]
		[Cpp2IlInjected.Address(RVA = "0x3545DC0", Offset = "0x35447C0", VA = "0x183545DC0")]
		static TargetMemoryShard()
		{
			Func<TargetMemoryShard> func = default(Func<TargetMemoryShard>);
			_parser = (MessageParser<TargetMemoryShard>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
