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
	[Cpp2IlInjected.Token(Token = "0x200085C")]
	public sealed class FlowerSpawningInVillage : IMessage<FlowerSpawningInVillage>, IMessage, IEquatable<FlowerSpawningInVillage>, IDeepCloneable<FlowerSpawningInVillage>, IMessageFieldAccessor, IRecurringEvent
	{
		[Cpp2IlInjected.Token(Token = "0x4002193")]
		private static readonly MessageParser<FlowerSpawningInVillage> _parser = (MessageParser<FlowerSpawningInVillage>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new FlowerSpawningInVillage()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002194")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002195")]
		public const int RecurringEventItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002196")]
		private int recurringEventItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002197")]
		public const int NextOccurrenceFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002198")]
		private Timestamp nextOccurrence_;

		[Cpp2IlInjected.Token(Token = "0x4002199")]
		public const int EndDateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400219A")]
		private Timestamp endDate_;

		[Cpp2IlInjected.Token(Token = "0x17000B94")]
		[DebuggerNonUserCode]
		public static MessageParser<FlowerSpawningInVillage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004632")]
			[Cpp2IlInjected.Address(RVA = "0x18056E0", Offset = "0x18040E0", VA = "0x1818056E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B95")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004633")]
			[Cpp2IlInjected.Address(RVA = "0x1805610", Offset = "0x1804010", VA = "0x181805610")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B96")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004634")]
			[Cpp2IlInjected.Address(RVA = "0x18057A0", Offset = "0x18041A0", VA = "0x1818057A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B97")]
		[DebuggerNonUserCode]
		public int RecurringEventItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004638")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recurringEventItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004639")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recurringEventItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B98")]
		[DebuggerNonUserCode]
		public Timestamp NextOccurrence
		{
			[Cpp2IlInjected.Token(Token = "0x600463A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return nextOccurrence_;
			}
			[Cpp2IlInjected.Token(Token = "0x600463B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "16")]
			set
			{
				nextOccurrence_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B99")]
		[DebuggerNonUserCode]
		public Timestamp EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x600463C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x600463D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "18")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B9A")]
		public Item RecurringEventItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004649")]
			[Cpp2IlInjected.Address(RVA = "0x1805740", Offset = "0x1804140", VA = "0x181805740", Slot = "14")]
			get
			{
				long num = Convert.ToInt64((uint)recurringEventItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004635")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FlowerSpawningInVillage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004636")]
		[Cpp2IlInjected.Address(RVA = "0x7B0570", Offset = "0x7AEF70", VA = "0x1807B0570")]
		[DebuggerNonUserCode]
		public FlowerSpawningInVillage(FlowerSpawningInVillage other)
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

		[Cpp2IlInjected.Token(Token = "0x6004637")]
		[Cpp2IlInjected.Address(RVA = "0x1803FE0", Offset = "0x18029E0", VA = "0x181803FE0", Slot = "10")]
		[DebuggerNonUserCode]
		public FlowerSpawningInVillage Clone()
		{
			//Discarded unreachable code: IL_0065
			//IL_0030: Expected O, but got I4
			FlowerSpawningInVillage flowerSpawningInVillage = new FlowerSpawningInVillage();
			int num = (flowerSpawningInVillage.recurringEventItemID_ = recurringEventItemID_);
			Timestamp timestamp = nextOccurrence_;
			int num2 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			flowerSpawningInVillage.nextOccurrence_ = (Timestamp)num2;
			Timestamp timestamp3 = endDate_;
			Timestamp timestamp4 = default(Timestamp);
			if (timestamp3 != null)
			{
				timestamp4 = timestamp3.Clone();
			}
			flowerSpawningInVillage.endDate_ = timestamp4;
			UnknownFieldSet unknownFieldSet = (flowerSpawningInVillage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return flowerSpawningInVillage;
		}

		[Cpp2IlInjected.Token(Token = "0x600463E")]
		[Cpp2IlInjected.Address(RVA = "0x18040C0", Offset = "0x1802AC0", VA = "0x1818040C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)recurringEventItemID_ == (IntPtr)typeof(FlowerSpawningInVillage).TypeHandle && object.Equals(nextOccurrence_, other) && object.Equals(endDate_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600463F")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FlowerSpawningInVillage other)
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

		[Cpp2IlInjected.Token(Token = "0x6004640")]
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

		[Cpp2IlInjected.Token(Token = "0x6004641")]
		[Cpp2IlInjected.Address(RVA = "0x18054A0", Offset = "0x1803EA0", VA = "0x1818054A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004642")]
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

		[Cpp2IlInjected.Token(Token = "0x6004643")]
		[Cpp2IlInjected.Address(RVA = "0x1803EE0", Offset = "0x18028E0", VA = "0x181803EE0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6004644")]
		[Cpp2IlInjected.Address(RVA = "0x1805260", Offset = "0x1803C60", VA = "0x181805260", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FlowerSpawningInVillage other)
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

		[Cpp2IlInjected.Token(Token = "0x6004645")]
		[Cpp2IlInjected.Address(RVA = "0x1805120", Offset = "0x1803B20", VA = "0x181805120", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6004646")]
		[Cpp2IlInjected.Address(RVA = "0x1804EC0", Offset = "0x18038C0", VA = "0x181804EC0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6004647")]
		[Cpp2IlInjected.Address(RVA = "0x18053A0", Offset = "0x1803DA0", VA = "0x1818053A0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004648")]
		[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600464A")]
		[Cpp2IlInjected.Address(RVA = "0x1804190", Offset = "0x1802B90", VA = "0x181804190")]
		public void Execute(in World world, ITransactionContext context, Random random)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600464B")]
		[Cpp2IlInjected.Address(RVA = "0x1804FA0", Offset = "0x18039A0", VA = "0x181804FA0")]
		public TimeSpan GetMaxIntervalToFullyExecute(in World world)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected I4, but got Unknown
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = recurringEventItemID_;
			FlowerSpawningInVillageRecurringEventItemData flowerSpawningInVillageRecurringEventItemData = default(FlowerSpawningInVillageRecurringEventItemData);
			TimeSpan maxTimeBetweenExecutions = flowerSpawningInVillageRecurringEventItemData.intervalData_.GetMaxTimeBetweenExecutions();
			int num2 = flowerSpawningInVillageRecurringEventItemData.maximumAmount_ * maxTimeBetweenExecutions;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600464C")]
		[Cpp2IlInjected.Address(RVA = "0x1805500", Offset = "0x1803F00", VA = "0x181805500")]
		static FlowerSpawningInVillage()
		{
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600464D")]
		[Cpp2IlInjected.Address(RVA = "0x1805390", Offset = "0x1803D90", VA = "0x181805390", Slot = "19")]
		void IRecurringEvent.Execute(in World world, ITransactionContext context, Random random)
		{
			Execute(in world, context, random);
		}

		[Cpp2IlInjected.Token(Token = "0x600464E")]
		[Cpp2IlInjected.Address(RVA = "0x1804FA0", Offset = "0x18039A0", VA = "0x181804FA0", Slot = "20")]
		TimeSpan IRecurringEvent.GetMaxIntervalToFullyExecute(in World world)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected I4, but got Unknown
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = recurringEventItemID_;
			FlowerSpawningInVillageRecurringEventItemData flowerSpawningInVillageRecurringEventItemData = default(FlowerSpawningInVillageRecurringEventItemData);
			TimeSpan maxTimeBetweenExecutions = flowerSpawningInVillageRecurringEventItemData.intervalData_.GetMaxTimeBetweenExecutions();
			int num2 = flowerSpawningInVillageRecurringEventItemData.maximumAmount_ * maxTimeBetweenExecutions;
			throw new NullReferenceException();
		}
	}
}
