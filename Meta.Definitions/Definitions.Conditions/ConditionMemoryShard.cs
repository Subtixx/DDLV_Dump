using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000808")]
	public sealed class ConditionMemoryShard : ICondition, IDataValidation, IMessage<ConditionMemoryShard>, IMessage, IEquatable<ConditionMemoryShard>, IDeepCloneable<ConditionMemoryShard>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002802")]
		private static readonly MessageParser<ConditionMemoryShard> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002803")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002804")]
		public const int ShardFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002805")]
		private int shard_;

		[Cpp2IlInjected.Token(Token = "0x4002806")]
		public const int OperatorFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002807")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x4002808")]
		public const int ProgressFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002809")]
		private int progress_;

		[Cpp2IlInjected.Token(Token = "0x17001695")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600594B")]
			[Cpp2IlInjected.Address(RVA = "0x207B9B0", Offset = "0x207A3B0", VA = "0x18207B9B0", Slot = "5")]
			get
			{
				//IL_0027: Expected O, but got I4
				int num = shard_;
				string text = Operations.ToString(operator_);
				int num2 = progress_;
				return $"MemoryShard {num} progress {text} {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001696")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600594C")]
			[Cpp2IlInjected.Address(RVA = "0x207BA60", Offset = "0x207A460", VA = "0x18207BA60", Slot = "6")]
			get
			{
				return ConditionListener.MemoryShard;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001697")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMemoryShard> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600594F")]
			[Cpp2IlInjected.Address(RVA = "0x207BA70", Offset = "0x207A470", VA = "0x18207BA70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001698")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005950")]
			[Cpp2IlInjected.Address(RVA = "0x207B8E0", Offset = "0x207A2E0", VA = "0x18207B8E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001699")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005951")]
			[Cpp2IlInjected.Address(RVA = "0x207BAD0", Offset = "0x207A4D0", VA = "0x18207BAD0", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169A")]
		[DebuggerNonUserCode]
		public int Shard
		{
			[Cpp2IlInjected.Token(Token = "0x6005955")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return shard_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005956")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				shard_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169B")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005957")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005958")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169C")]
		[DebuggerNonUserCode]
		public int Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6005959")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return progress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600595A")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				progress_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005949")]
		[Cpp2IlInjected.Address(RVA = "0x207B460", Offset = "0x2079E60", VA = "0x18207B460")]
		private int GetProgress(IProfilePlayer player)
		{
			//Discarded unreachable code: IL_001f, IL_0045
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			int num3 = shard_;
			bool flag = default(bool);
			if (!flag)
			{
				return 0;
			}
			int num4 = shard_;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			MemoryShardItemData memoryShardItemData = default(MemoryShardItemData);
			return memoryShardItemData.Progression(num);
		}

		[Cpp2IlInjected.Token(Token = "0x600594A")]
		[Cpp2IlInjected.Address(RVA = "0x207B270", Offset = "0x2079C70", VA = "0x18207B270")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfilePlayer section = playerProfile.Section;
			int progress = GetProgress(section);
			int protobufValue = progress_;
			IntOperator intOperator = operator_;
			return Operations.Evaluate(progress, intOperator, protobufValue);
		}

		[Cpp2IlInjected.Token(Token = "0x600594D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600594E")]
		[Cpp2IlInjected.Address(RVA = "0x207B200", Offset = "0x2079C00", VA = "0x18207B200", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (shard_ == 0)
			{
				context.AddInvalidMemberError("Please select a MemoryShard", "Shard");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005952")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMemoryShard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005953")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public ConditionMemoryShard(ConditionMemoryShard other)
		{
			int num = (shard_ = other.shard_);
			IntOperator intOperator = (operator_ = other.operator_);
			int num2 = (progress_ = other.progress_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005954")]
		[Cpp2IlInjected.Address(RVA = "0x207B170", Offset = "0x2079B70", VA = "0x18207B170", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionMemoryShard Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionMemoryShard conditionMemoryShard = new ConditionMemoryShard();
			int num = (conditionMemoryShard.shard_ = shard_);
			IntOperator intOperator = (conditionMemoryShard.operator_ = operator_);
			int num2 = (conditionMemoryShard.progress_ = progress_);
			UnknownFieldSet unknownFieldSet = (conditionMemoryShard._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMemoryShard;
		}

		[Cpp2IlInjected.Token(Token = "0x600595B")]
		[Cpp2IlInjected.Address(RVA = "0x207B2E0", Offset = "0x2079CE0", VA = "0x18207B2E0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)shard_ == (IntPtr)typeof(ConditionMemoryShard).TypeHandle && (IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionMemoryShard).TypeHandle && (IntPtr)progress_ == (IntPtr)typeof(ConditionMemoryShard).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600595C")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMemoryShard other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.shard_;
				if (shard_ == num)
				{
					IntOperator intOperator = other.operator_;
					if (operator_ == intOperator)
					{
						int num2 = other.progress_;
						if (progress_ == num2)
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

		[Cpp2IlInjected.Token(Token = "0x600595D")]
		[Cpp2IlInjected.Address(RVA = "0x1DF83C0", Offset = "0x1DF6DC0", VA = "0x181DF83C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (shard_ != 0)
				{
				}
				if (operator_ != 0)
				{
				}
				if (progress_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600595E")]
		[Cpp2IlInjected.Address(RVA = "0x207B770", Offset = "0x207A170", VA = "0x18207B770", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600595F")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			if (shard_ != 0)
			{
				int value = shard_;
				output.WriteInt32(value);
			}
			if (operator_ != 0)
			{
			}
			if (progress_ != 0)
			{
				int value2 = progress_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005960")]
		[Cpp2IlInjected.Address(RVA = "0x207B070", Offset = "0x2079A70", VA = "0x18207B070", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = shard_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				IntOperator intOperator = operator_;
				if (intOperator != 0)
				{
					int num4 = CodedOutputStream.ComputeEnumSize((int)intOperator);
					num4++;
					num2 += num4;
				}
				int num5 = progress_;
				if (num5 != 0)
				{
					int num6 = CodedOutputStream.ComputeInt32Size(num5);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005961")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMemoryShard other)
		{
			if (other != null)
			{
				int num = other.shard_;
				if (num != 0)
				{
					shard_ = num;
				}
				IntOperator intOperator = other.operator_;
				if (intOperator != 0)
				{
					operator_ = intOperator;
				}
				int num2 = other.progress_;
				if (num2 != 0)
				{
					progress_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005962")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (shard_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (int)(operator_ = (IntOperator)input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (progress_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005963")]
		[Cpp2IlInjected.Address(RVA = "0x207B380", Offset = "0x2079D80", VA = "0x18207B380", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = shard_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005964")]
		[Cpp2IlInjected.Address(RVA = "0x207B650", Offset = "0x207A050", VA = "0x18207B650", Slot = "17")]
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
					progress_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					operator_ = (IntOperator)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				shard_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005965")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				progress_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005966")]
		[Cpp2IlInjected.Address(RVA = "0x207B7D0", Offset = "0x207A1D0", VA = "0x18207B7D0")]
		static ConditionMemoryShard()
		{
			Func<ConditionMemoryShard> func = default(Func<ConditionMemoryShard>);
			_parser = (MessageParser<ConditionMemoryShard>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005967")]
		[Cpp2IlInjected.Address(RVA = "0x207B270", Offset = "0x2079C70", VA = "0x18207B270", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfilePlayer section = playerProfile.Section;
			int progress = GetProgress(section);
			int protobufValue = progress_;
			IntOperator intOperator = operator_;
			return Operations.Evaluate(progress, intOperator, protobufValue);
		}
	}
}
