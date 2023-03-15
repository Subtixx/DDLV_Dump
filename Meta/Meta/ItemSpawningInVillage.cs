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
	[Cpp2IlInjected.Token(Token = "0x200084C")]
	public sealed class ItemSpawningInVillage : IMessage<ItemSpawningInVillage>, IMessage, IEquatable<ItemSpawningInVillage>, IDeepCloneable<ItemSpawningInVillage>, IMessageFieldAccessor, IRecurringEvent
	{
		[Cpp2IlInjected.Token(Token = "0x400214E")]
		private static readonly MessageParser<ItemSpawningInVillage> _parser = (MessageParser<ItemSpawningInVillage>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ItemSpawningInVillage()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400214F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002150")]
		public const int RecurringEventItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002151")]
		private int recurringEventItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002152")]
		public const int NextOccurrenceFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002153")]
		private Timestamp nextOccurrence_;

		[Cpp2IlInjected.Token(Token = "0x4002154")]
		public const int EndDateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002155")]
		private Timestamp endDate_;

		[Cpp2IlInjected.Token(Token = "0x4002156")]
		public const int LastOccurrenceFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002157")]
		private Timestamp lastOccurrence_;

		[Cpp2IlInjected.Token(Token = "0x17000B7D")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemSpawningInVillage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600459F")]
			[Cpp2IlInjected.Address(RVA = "0x17199E0", Offset = "0x17183E0", VA = "0x1817199E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60045A0")]
			[Cpp2IlInjected.Address(RVA = "0x1719910", Offset = "0x1718310", VA = "0x181719910")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60045A1")]
			[Cpp2IlInjected.Address(RVA = "0x1719AA0", Offset = "0x17184A0", VA = "0x181719AA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B80")]
		[DebuggerNonUserCode]
		public int RecurringEventItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60045A5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recurringEventItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045A6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recurringEventItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B81")]
		[DebuggerNonUserCode]
		public Timestamp NextOccurrence
		{
			[Cpp2IlInjected.Token(Token = "0x60045A7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return nextOccurrence_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045A8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "16")]
			set
			{
				nextOccurrence_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B82")]
		[DebuggerNonUserCode]
		public Timestamp EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x60045A9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045AA")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "18")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B83")]
		[DebuggerNonUserCode]
		public Timestamp LastOccurrence
		{
			[Cpp2IlInjected.Token(Token = "0x60045AB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return lastOccurrence_;
			}
			[Cpp2IlInjected.Token(Token = "0x60045AC")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				lastOccurrence_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B84")]
		public Item RecurringEventItem
		{
			[Cpp2IlInjected.Token(Token = "0x60045B8")]
			[Cpp2IlInjected.Address(RVA = "0x1719A40", Offset = "0x1718440", VA = "0x181719A40", Slot = "14")]
			get
			{
				long num = Convert.ToInt64((uint)recurringEventItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045A2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemSpawningInVillage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60045A3")]
		[Cpp2IlInjected.Address(RVA = "0x1719840", Offset = "0x1718240", VA = "0x181719840")]
		[DebuggerNonUserCode]
		public ItemSpawningInVillage(ItemSpawningInVillage other)
		{
			//IL_002f: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			int num = (recurringEventItemID_ = other.recurringEventItemID_);
			Timestamp timestamp = other.nextOccurrence_;
			int num2 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			nextOccurrence_ = (Timestamp)num2;
			Timestamp timestamp3 = other.endDate_;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			endDate_ = (Timestamp)num2;
			Timestamp timestamp5 = other.lastOccurrence_;
			Timestamp timestamp6 = default(Timestamp);
			if (timestamp5 != null)
			{
				timestamp6 = timestamp5.Clone();
			}
			lastOccurrence_ = timestamp6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045A4")]
		[Cpp2IlInjected.Address(RVA = "0x1716B70", Offset = "0x1715570", VA = "0x181716B70", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemSpawningInVillage Clone()
		{
			//Discarded unreachable code: IL_0082
			//IL_0030: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			ItemSpawningInVillage itemSpawningInVillage = new ItemSpawningInVillage();
			int num = (itemSpawningInVillage.recurringEventItemID_ = recurringEventItemID_);
			Timestamp timestamp = nextOccurrence_;
			int num2 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			itemSpawningInVillage.nextOccurrence_ = (Timestamp)num2;
			Timestamp timestamp3 = endDate_;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			itemSpawningInVillage.endDate_ = (Timestamp)num2;
			Timestamp timestamp5 = lastOccurrence_;
			Timestamp timestamp6 = default(Timestamp);
			if (timestamp5 != null)
			{
				timestamp6 = timestamp5.Clone();
			}
			itemSpawningInVillage.lastOccurrence_ = timestamp6;
			UnknownFieldSet unknownFieldSet = (itemSpawningInVillage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemSpawningInVillage;
		}

		[Cpp2IlInjected.Token(Token = "0x60045AD")]
		[Cpp2IlInjected.Address(RVA = "0x1716C70", Offset = "0x1715670", VA = "0x181716C70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)recurringEventItemID_ == (IntPtr)typeof(ItemSpawningInVillage).TypeHandle && object.Equals(nextOccurrence_, other) && object.Equals(endDate_, other) && object.Equals(lastOccurrence_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045AE")]
		[Cpp2IlInjected.Address(RVA = "0x1716D50", Offset = "0x1715750", VA = "0x181716D50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemSpawningInVillage other)
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
							Timestamp objB3 = other.lastOccurrence_;
							if (object.Equals(lastOccurrence_, objB3))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045AF")]
		[Cpp2IlInjected.Address(RVA = "0x1718D20", Offset = "0x1717720", VA = "0x181718D20", Slot = "2")]
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
				Timestamp timestamp3 = lastOccurrence_;
				if (timestamp3 != null)
				{
					int hashCode3 = timestamp3.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60045B0")]
		[Cpp2IlInjected.Address(RVA = "0x17194A0", Offset = "0x1717EA0", VA = "0x1817194A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60045B1")]
		[Cpp2IlInjected.Address(RVA = "0x1719650", Offset = "0x1718050", VA = "0x181719650", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0078
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
			if ((long)lastOccurrence_ != 0)
			{
				Timestamp value4 = lastOccurrence_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60045B2")]
		[Cpp2IlInjected.Address(RVA = "0x17169D0", Offset = "0x17153D0", VA = "0x1817169D0", Slot = "7")]
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
				Timestamp timestamp3 = lastOccurrence_;
				if (timestamp3 != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(timestamp3);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60045B3")]
		[Cpp2IlInjected.Address(RVA = "0x1719020", Offset = "0x1717A20", VA = "0x181719020", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemSpawningInVillage other)
		{
			//Discarded unreachable code: IL_00e7
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
			if ((long)other.lastOccurrence_ != 0)
			{
				Timestamp timestamp6 = default(Timestamp);
				if (lastOccurrence_ == null)
				{
					Timestamp timestamp5 = (lastOccurrence_ = new Timestamp());
					timestamp6 = lastOccurrence_;
				}
				Timestamp other4 = other.lastOccurrence_;
				timestamp6.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60045B4")]
		[Cpp2IlInjected.Address(RVA = "0x17191A0", Offset = "0x1717BA0", VA = "0x1817191A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c0
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					Timestamp timestamp = endDate_;
					if (timestamp == null)
					{
						Timestamp timestamp2 = (endDate_ = new Timestamp());
					}
					input.ReadMessage(timestamp);
				}
				if (num != 34)
				{
					goto IL_00a9;
				}
				Timestamp builder = default(Timestamp);
				if (lastOccurrence_ == null)
				{
					Timestamp timestamp3 = (lastOccurrence_ = new Timestamp());
					builder = lastOccurrence_;
				}
				input.ReadMessage(builder);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (recurringEventItemID_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				Timestamp builder2 = default(Timestamp);
				if (nextOccurrence_ == null)
				{
					Timestamp timestamp4 = (nextOccurrence_ = new Timestamp());
					builder2 = nextOccurrence_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_00a9;
			IL_00a9:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60045B5")]
		[Cpp2IlInjected.Address(RVA = "0x1718C30", Offset = "0x1717630", VA = "0x181718C30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						Timestamp timestamp = lastOccurrence_;
					}
					Timestamp timestamp2 = endDate_;
				}
				Timestamp timestamp3 = nextOccurrence_;
			}
			int num2 = recurringEventItemID_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045B6")]
		[Cpp2IlInjected.Address(RVA = "0x1719360", Offset = "0x1717D60", VA = "0x181719360", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003e
			//IL_0025: Expected O, but got I4
			//IL_003d: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							lastOccurrence_ = (Timestamp)num2;
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
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			object obj = default(object);
			recurringEventItemID_ = (int)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x60045B7")]
		[Cpp2IlInjected.Address(RVA = "0x1716B10", Offset = "0x1715510", VA = "0x181716B10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045B9")]
		[Cpp2IlInjected.Address(RVA = "0x1716DF0", Offset = "0x17157F0", VA = "0x181716DF0")]
		public void Execute(in World world, ITransactionContext context, Random random)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60045BA")]
		[Cpp2IlInjected.Address(RVA = "0x1718DE0", Offset = "0x17177E0", VA = "0x181718DE0")]
		public TimeSpan GetMaxIntervalToFullyExecute(in World world)
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected I4, but got Unknown
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = recurringEventItemID_;
			ItemSpawningInVillageRecurringEventItemData itemSpawningInVillageRecurringEventItemData = default(ItemSpawningInVillageRecurringEventItemData);
			TimeSpan maxTimeBetweenExecutions = itemSpawningInVillageRecurringEventItemData.intervalData_.GetMaxTimeBetweenExecutions();
			SpawnRecurringEventAreaSpecification areaSpecification_ = itemSpawningInVillageRecurringEventItemData.areaSpecification_;
			int maximumAmount_ = itemSpawningInVillageRecurringEventItemData.maximumAmount_;
			if (areaSpecification_.FromChooseVillageAreaEvent != null && itemSpawningInVillageRecurringEventItemData.areaSpecification_.FromChooseVillageAreaEvent.useChooseVillageAreaMaximumAmount_)
			{
				Item chooseVillageAreaEventItem = itemSpawningInVillageRecurringEventItemData.areaSpecification_.FromChooseVillageAreaEvent.ChooseVillageAreaEventItem;
			}
			int num2 = maximumAmount_ * maxTimeBetweenExecutions;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60045BB")]
		[Cpp2IlInjected.Address(RVA = "0x1719730", Offset = "0x1718130", VA = "0x181719730")]
		static ItemSpawningInVillage()
		{
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60045BC")]
		[Cpp2IlInjected.Address(RVA = "0x1719340", Offset = "0x1717D40", VA = "0x181719340", Slot = "19")]
		void IRecurringEvent.Execute(in World world, ITransactionContext context, Random random)
		{
			Execute(in world, context, random);
		}

		[Cpp2IlInjected.Token(Token = "0x60045BD")]
		[Cpp2IlInjected.Address(RVA = "0x1719350", Offset = "0x1717D50", VA = "0x181719350", Slot = "20")]
		TimeSpan IRecurringEvent.GetMaxIntervalToFullyExecute(in World world)
		{
			return GetMaxIntervalToFullyExecute(in world);
		}
	}
}
