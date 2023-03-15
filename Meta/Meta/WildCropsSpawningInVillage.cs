using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000854")]
	public sealed class WildCropsSpawningInVillage : IMessage<WildCropsSpawningInVillage>, IMessage, IEquatable<WildCropsSpawningInVillage>, IDeepCloneable<WildCropsSpawningInVillage>, IMessageFieldAccessor, IRecurringEvent
	{
		[Cpp2IlInjected.Token(Token = "0x400216E")]
		private static readonly MessageParser<WildCropsSpawningInVillage> _parser = (MessageParser<WildCropsSpawningInVillage>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new WildCropsSpawningInVillage()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400216F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002170")]
		public const int RecurringEventItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002171")]
		private int recurringEventItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002172")]
		public const int NextOccurrenceFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002173")]
		private Timestamp nextOccurrence_;

		[Cpp2IlInjected.Token(Token = "0x4002174")]
		public const int EndDateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002175")]
		private Timestamp endDate_;

		[Cpp2IlInjected.Token(Token = "0x17000B85")]
		[DebuggerNonUserCode]
		public static MessageParser<WildCropsSpawningInVillage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60045D6")]
			[Cpp2IlInjected.Address(RVA = "0x15EA290", Offset = "0x15E8C90", VA = "0x1815EA290")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B86")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60045D7")]
			[Cpp2IlInjected.Address(RVA = "0x15EA1C0", Offset = "0x15E8BC0", VA = "0x1815EA1C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B87")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60045D8")]
			[Cpp2IlInjected.Address(RVA = "0x15EA350", Offset = "0x15E8D50", VA = "0x1815EA350", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B88")]
		[DebuggerNonUserCode]
		public int RecurringEventItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60045DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recurringEventItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045DD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recurringEventItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B89")]
		[DebuggerNonUserCode]
		public Timestamp NextOccurrence
		{
			[Cpp2IlInjected.Token(Token = "0x60045DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return nextOccurrence_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "16")]
			set
			{
				nextOccurrence_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8A")]
		[DebuggerNonUserCode]
		public Timestamp EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x60045E0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045E1")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "18")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8B")]
		public Item RecurringEventItem
		{
			[Cpp2IlInjected.Token(Token = "0x60045ED")]
			[Cpp2IlInjected.Address(RVA = "0x15EA2F0", Offset = "0x15E8CF0", VA = "0x1815EA2F0", Slot = "14")]
			get
			{
				long num = Convert.ToInt64((uint)recurringEventItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045D9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public WildCropsSpawningInVillage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60045DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B0570", Offset = "0x7AEF70", VA = "0x1807B0570")]
		[DebuggerNonUserCode]
		public WildCropsSpawningInVillage(WildCropsSpawningInVillage other)
		{
			//IL_002f: Expected O, but got I4
			int num = (recurringEventItemID_ = other.recurringEventItemID_);
			Timestamp timestamp = other.nextOccurrence_;
			int num2 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			nextOccurrence_ = (Timestamp)num2;
			Timestamp timestamp3 = other.endDate_;
			Timestamp timestamp4 = default(Timestamp);
			if (timestamp3 != null)
			{
				timestamp4 = timestamp3.Clone();
			}
			endDate_ = timestamp4;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045DB")]
		[Cpp2IlInjected.Address(RVA = "0x15E8550", Offset = "0x15E6F50", VA = "0x1815E8550", Slot = "10")]
		[DebuggerNonUserCode]
		public WildCropsSpawningInVillage Clone()
		{
			//Discarded unreachable code: IL_0065
			//IL_0030: Expected O, but got I4
			WildCropsSpawningInVillage wildCropsSpawningInVillage = new WildCropsSpawningInVillage();
			int num = (wildCropsSpawningInVillage.recurringEventItemID_ = recurringEventItemID_);
			Timestamp timestamp = nextOccurrence_;
			int num2 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			wildCropsSpawningInVillage.nextOccurrence_ = (Timestamp)num2;
			Timestamp timestamp3 = endDate_;
			Timestamp timestamp4 = default(Timestamp);
			if (timestamp3 != null)
			{
				timestamp4 = timestamp3.Clone();
			}
			wildCropsSpawningInVillage.endDate_ = timestamp4;
			UnknownFieldSet unknownFieldSet = (wildCropsSpawningInVillage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return wildCropsSpawningInVillage;
		}

		[Cpp2IlInjected.Token(Token = "0x60045E2")]
		[Cpp2IlInjected.Address(RVA = "0x15E8630", Offset = "0x15E7030", VA = "0x1815E8630", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)recurringEventItemID_ == (IntPtr)typeof(WildCropsSpawningInVillage).TypeHandle && object.Equals(nextOccurrence_, other) && object.Equals(endDate_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045E3")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WildCropsSpawningInVillage other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.recurringEventItemID_;
				if (recurringEventItemID_ == num)
				{
					Timestamp objB = other.nextOccurrence_;
					if (object.Equals(nextOccurrence_, objB))
					{
						Timestamp objB2 = other.endDate_;
						if (object.Equals(endDate_, objB2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045E4")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC70", Offset = "0x7AE670", VA = "0x1807AFC70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (recurringEventItemID_ != 0)
				{
				}
				Timestamp timestamp = nextOccurrence_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				Timestamp timestamp2 = endDate_;
				if (timestamp2 != null)
				{
					int hashCode2 = timestamp2.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60045E5")]
		[Cpp2IlInjected.Address(RVA = "0x15EA050", Offset = "0x15E8A50", VA = "0x1815EA050", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60045E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B03B0", Offset = "0x7AEDB0", VA = "0x1807B03B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005c
			if (recurringEventItemID_ != 0)
			{
				int value = recurringEventItemID_;
				output.WriteInt32(value);
			}
			if ((long)nextOccurrence_ != 0)
			{
				Timestamp value2 = nextOccurrence_;
				output.WriteMessage(value2);
			}
			if ((long)endDate_ != 0)
			{
				Timestamp value3 = endDate_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60045E7")]
		[Cpp2IlInjected.Address(RVA = "0x15E8450", Offset = "0x15E6E50", VA = "0x1815E8450", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = recurringEventItemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				Timestamp timestamp = nextOccurrence_;
				if (timestamp != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(timestamp);
					num4++;
					num2 += num4;
				}
				Timestamp timestamp2 = endDate_;
				if (timestamp2 != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(timestamp2);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60045E8")]
		[Cpp2IlInjected.Address(RVA = "0x15E9CC0", Offset = "0x15E86C0", VA = "0x1815E9CC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WildCropsSpawningInVillage other)
		{
			//Discarded unreachable code: IL_00ab
			if (other == null)
			{
				return;
			}
			int num = other.recurringEventItemID_;
			if (num != 0)
			{
				recurringEventItemID_ = num;
			}
			if ((long)other.nextOccurrence_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (nextOccurrence_ == null)
				{
					Timestamp timestamp = (nextOccurrence_ = new Timestamp());
					timestamp2 = nextOccurrence_;
				}
				Timestamp other2 = other.nextOccurrence_;
				timestamp2.MergeFrom(other2);
			}
			if ((long)other.endDate_ != 0)
			{
				Timestamp timestamp4 = default(Timestamp);
				if (endDate_ == null)
				{
					Timestamp timestamp3 = (endDate_ = new Timestamp());
					timestamp4 = endDate_;
				}
				Timestamp other3 = other.endDate_;
				timestamp4.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60045E9")]
		[Cpp2IlInjected.Address(RVA = "0x15E9DF0", Offset = "0x15E87F0", VA = "0x1815E9DF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0092
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (recurringEventItemID_ = input.ReadInt32());
			}
			Timestamp timestamp = default(Timestamp);
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (nextOccurrence_ == null)
				{
					timestamp = (nextOccurrence_ = new Timestamp());
					builder = nextOccurrence_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 26)
			{
				Timestamp builder2 = default(Timestamp);
				if (endDate_ == null)
				{
					Timestamp timestamp2 = (endDate_ = new Timestamp());
					builder2 = endDate_;
				}
				input.ReadMessage(builder2);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60045EA")]
		[Cpp2IlInjected.Address(RVA = "0x15E99A0", Offset = "0x15E83A0", VA = "0x1815E99A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					Timestamp timestamp = endDate_;
				}
				Timestamp timestamp2 = nextOccurrence_;
			}
			int num2 = recurringEventItemID_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045EB")]
		[Cpp2IlInjected.Address(RVA = "0x15E9F50", Offset = "0x15E8950", VA = "0x1815E9F50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0032
			//IL_0021: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						endDate_ = (Timestamp)num2;
						return;
					}
					throw new InvalidCastException();
				}
				default:
					return;
				case 0:
					break;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			object obj = default(object);
			recurringEventItemID_ = (int)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x60045EC")]
		[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045EE")]
		[Cpp2IlInjected.Address(RVA = "0x15E8700", Offset = "0x15E7100", VA = "0x1815E8700")]
		public void Execute(in World world, ITransactionContext context, Random random)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60045EF")]
		[Cpp2IlInjected.Address(RVA = "0x15E9A80", Offset = "0x15E8480", VA = "0x1815E9A80")]
		public TimeSpan GetMaxIntervalToFullyExecute(in World world)
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected I4, but got Unknown
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = recurringEventItemID_;
			WildCropsSpawningInVillageRecurringEventItemData wildCropsSpawningInVillageRecurringEventItemData = default(WildCropsSpawningInVillageRecurringEventItemData);
			TimeSpan maxTimeBetweenExecutions = wildCropsSpawningInVillageRecurringEventItemData.intervalData_.GetMaxTimeBetweenExecutions();
			SpawnRecurringEventAreaSpecification areaSpecification_ = wildCropsSpawningInVillageRecurringEventItemData.areaSpecification_;
			int maximumAmount_ = wildCropsSpawningInVillageRecurringEventItemData.maximumAmount_;
			if (areaSpecification_.FromChooseVillageAreaEvent != null && wildCropsSpawningInVillageRecurringEventItemData.areaSpecification_.FromChooseVillageAreaEvent.useChooseVillageAreaMaximumAmount_)
			{
				Item chooseVillageAreaEventItem = wildCropsSpawningInVillageRecurringEventItemData.areaSpecification_.FromChooseVillageAreaEvent.ChooseVillageAreaEventItem;
			}
			int num2 = maximumAmount_ * maxTimeBetweenExecutions;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045F0")]
		[Cpp2IlInjected.Address(RVA = "0x15EA0B0", Offset = "0x15E8AB0", VA = "0x1815EA0B0")]
		static WildCropsSpawningInVillage()
		{
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045F1")]
		[Cpp2IlInjected.Address(RVA = "0x15E9F30", Offset = "0x15E8930", VA = "0x1815E9F30", Slot = "19")]
		void IRecurringEvent.Execute(in World world, ITransactionContext context, Random random)
		{
			Execute(in world, context, random);
		}

		[Cpp2IlInjected.Token(Token = "0x60045F2")]
		[Cpp2IlInjected.Address(RVA = "0x15E9F40", Offset = "0x15E8940", VA = "0x1815E9F40", Slot = "20")]
		TimeSpan IRecurringEvent.GetMaxIntervalToFullyExecute(in World world)
		{
			return GetMaxIntervalToFullyExecute(in world);
		}
	}
}
