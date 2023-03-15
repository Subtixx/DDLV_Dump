using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000890")]
	public sealed class Critter : IMessage<Critter>, IMessage, IEquatable<Critter>, IDeepCloneable<Critter>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400226F")]
		private static readonly MessageParser<Critter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002270")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002271")]
		public const int CritterItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002272")]
		private int critterItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002273")]
		public const int NumberOfFeedingDoneFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002274")]
		private int numberOfFeedingDone_;

		[Cpp2IlInjected.Token(Token = "0x4002275")]
		public const int LastFeedingTimeFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002276")]
		private Timestamp lastFeedingTime_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002277")]
		private CritterItemData _critterItemData;

		[Cpp2IlInjected.Token(Token = "0x17000C15")]
		[DebuggerNonUserCode]
		public static MessageParser<Critter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600489B")]
			[Cpp2IlInjected.Address(RVA = "0x18C3AC0", Offset = "0x18C24C0", VA = "0x1818C3AC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C16")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600489C")]
			[Cpp2IlInjected.Address(RVA = "0x18C39F0", Offset = "0x18C23F0", VA = "0x1818C39F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C17")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600489D")]
			[Cpp2IlInjected.Address(RVA = "0x18C3B20", Offset = "0x18C2520", VA = "0x1818C3B20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C18")]
		[DebuggerNonUserCode]
		public int CritterItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60048A1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return critterItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048A2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				critterItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C19")]
		[DebuggerNonUserCode]
		public int NumberOfFeedingDone
		{
			[Cpp2IlInjected.Token(Token = "0x60048A3")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return numberOfFeedingDone_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048A4")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				numberOfFeedingDone_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1A")]
		[DebuggerNonUserCode]
		public Timestamp LastFeedingTime
		{
			[Cpp2IlInjected.Token(Token = "0x60048A5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return lastFeedingTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048A6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				lastFeedingTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1B")]
		public Item CritterItem
		{
			[Cpp2IlInjected.Token(Token = "0x60048B2")]
			[Cpp2IlInjected.Address(RVA = "0x18C3840", Offset = "0x18C2240", VA = "0x1818C3840")]
			get
			{
				long num = Convert.ToInt64((uint)critterItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x60048B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				critterItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1C")]
		public CritterItemData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60048B4")]
			[Cpp2IlInjected.Address(RVA = "0x18C38A0", Offset = "0x18C22A0", VA = "0x1818C38A0")]
			get
			{
				//Discarded unreachable code: IL_0026
				CritterItemData critterItemData = _critterItemData;
				if (critterItemData == null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					long num = Convert.ToInt64((uint)critterItemID_);
					CritterItemData critterItemData2 = default(CritterItemData);
					_critterItemData = critterItemData2;
				}
				return critterItemData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600489E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Critter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600489F")]
		[Cpp2IlInjected.Address(RVA = "0x18C37C0", Offset = "0x18C21C0", VA = "0x1818C37C0")]
		[DebuggerNonUserCode]
		public Critter(Critter other)
		{
			//IL_003f: Expected O, but got I4
			int num = (critterItemID_ = other.critterItemID_);
			int num2 = (numberOfFeedingDone_ = other.numberOfFeedingDone_);
			Timestamp timestamp = other.lastFeedingTime_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num3 = 0;
			lastFeedingTime_ = (Timestamp)num3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048A0")]
		[Cpp2IlInjected.Address(RVA = "0x18C2B70", Offset = "0x18C1570", VA = "0x1818C2B70", Slot = "10")]
		[DebuggerNonUserCode]
		public Critter Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0040: Expected O, but got I4
			Critter critter = new Critter();
			int num = (critter.critterItemID_ = critterItemID_);
			int num2 = (critter.numberOfFeedingDone_ = numberOfFeedingDone_);
			Timestamp timestamp = lastFeedingTime_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num3 = 0;
			critter.lastFeedingTime_ = (Timestamp)num3;
			UnknownFieldSet unknownFieldSet = (critter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return critter;
		}

		[Cpp2IlInjected.Token(Token = "0x60048A7")]
		[Cpp2IlInjected.Address(RVA = "0x18C2C20", Offset = "0x18C1620", VA = "0x1818C2C20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)critterItemID_ == (IntPtr)typeof(Critter).TypeHandle && (IntPtr)numberOfFeedingDone_ == (IntPtr)typeof(Critter).TypeHandle && object.Equals(lastFeedingTime_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048A8")]
		[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Critter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.critterItemID_;
				if (critterItemID_ == num)
				{
					int num2 = other.numberOfFeedingDone_;
					if (numberOfFeedingDone_ == num2)
					{
						Timestamp objB = other.lastFeedingTime_;
						if (object.Equals(lastFeedingTime_, objB))
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

		[Cpp2IlInjected.Token(Token = "0x60048A9")]
		[Cpp2IlInjected.Address(RVA = "0x18C2EE0", Offset = "0x18C18E0", VA = "0x1818C2EE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (critterItemID_ != 0)
				{
				}
				if (numberOfFeedingDone_ != 0)
				{
				}
				Timestamp timestamp = lastFeedingTime_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60048AA")]
		[Cpp2IlInjected.Address(RVA = "0x18C35A0", Offset = "0x18C1FA0", VA = "0x1818C35A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60048AB")]
		[Cpp2IlInjected.Address(RVA = "0x18C3600", Offset = "0x18C2000", VA = "0x1818C3600", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005a
			if (critterItemID_ != 0)
			{
				int value = critterItemID_;
				output.WriteInt32(value);
			}
			if (numberOfFeedingDone_ != 0)
			{
				int value2 = numberOfFeedingDone_;
				output.WriteInt32(value2);
			}
			if ((long)lastFeedingTime_ != 0)
			{
				Timestamp value3 = lastFeedingTime_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60048AC")]
		[Cpp2IlInjected.Address(RVA = "0x18C2A30", Offset = "0x18C1430", VA = "0x1818C2A30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = critterItemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = numberOfFeedingDone_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				Timestamp timestamp = lastFeedingTime_;
				if (timestamp != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(timestamp);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60048AD")]
		[Cpp2IlInjected.Address(RVA = "0x18C3390", Offset = "0x18C1D90", VA = "0x1818C3390", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Critter other)
		{
			//Discarded unreachable code: IL_0083
			if (other == null)
			{
				return;
			}
			int num = other.critterItemID_;
			if (num != 0)
			{
				critterItemID_ = num;
			}
			int num2 = other.numberOfFeedingDone_;
			if (num2 != 0)
			{
				numberOfFeedingDone_ = num2;
			}
			if ((long)other.lastFeedingTime_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastFeedingTime_ == null)
				{
					Timestamp timestamp = (lastFeedingTime_ = new Timestamp());
					timestamp2 = lastFeedingTime_;
				}
				Timestamp other2 = other.lastFeedingTime_;
				timestamp2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60048AE")]
		[Cpp2IlInjected.Address(RVA = "0x18C3280", Offset = "0x18C1C80", VA = "0x1818C3280", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0075
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (critterItemID_ = input.ReadInt32());
			}
			int num3 = default(int);
			if (num == 32)
			{
				num3 = (numberOfFeedingDone_ = input.ReadInt32());
			}
			if (num3 == 42)
			{
				Timestamp builder = default(Timestamp);
				if (lastFeedingTime_ == null)
				{
					Timestamp timestamp = (lastFeedingTime_ = new Timestamp());
					builder = lastFeedingTime_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60048AF")]
		[Cpp2IlInjected.Address(RVA = "0x18C2E00", Offset = "0x18C1800", VA = "0x1818C2E00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num == 0)
				{
					goto IL_0026;
				}
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0026;
					}
					Timestamp timestamp = lastFeedingTime_;
				}
			}
			int num2 = critterItemID_;
			goto IL_0026;
			IL_0026:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048B0")]
		[Cpp2IlInjected.Address(RVA = "0x18C3470", Offset = "0x18C1E70", VA = "0x1818C3470", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003a
			//IL_0029: Expected O, but got I4
			//IL_0039: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num == 0)
				{
					return;
				}
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						lastFeedingTime_ = (Timestamp)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
					numberOfFeedingDone_ = 0;
					break;
				}
			}
			else
			{
				object obj = default(object);
				critterItemID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048B1")]
		[Cpp2IlInjected.Address(RVA = "0x18C2B30", Offset = "0x18C1530", VA = "0x1818C2B30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048B5")]
		[Cpp2IlInjected.Address(RVA = "0x18C2D60", Offset = "0x18C1760", VA = "0x1818C2D60")]
		public bool Fed(DateTime localTime)
		{
			Timestamp timestamp = lastFeedingTime_;
			if (timestamp == null)
			{
				int num = 0;
			}
			DateTime dateTime = timestamp.ToDateTime();
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime3 = default(DateTime);
			return dateTime2 == dateTime3;
		}

		[Cpp2IlInjected.Token(Token = "0x60048B6")]
		[Cpp2IlInjected.Address(RVA = "0x18C2F80", Offset = "0x18C1980", VA = "0x1818C2F80")]
		private CritterItemData.Types.DailyScheduleData.Types.Data GetPeriod(DateTime time)
		{
			//Discarded unreachable code: IL_0042
			int num = 0;
			if ((object)typeof(ItemDatabase).TypeHandle == null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int num2 = critterItemID_;
				CritterItemData critterItemData = default(CritterItemData);
				_critterItemData = critterItemData;
			}
			DayOfWeek dayOfWeek = default(DayOfWeek);
			int num3 = (int)dayOfWeek;
			CritterItemData.Types.DailyScheduleData dailyScheduleData = default(CritterItemData.Types.DailyScheduleData);
			RepeatedField<CritterItemData.Types.DailyScheduleData.Types.Data> schedule_ = dailyScheduleData.schedule_;
			bool flag = default(bool);
			if (flag)
			{
				num++;
			}
			if (num + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048B7")]
		[Cpp2IlInjected.Address(RVA = "0x18C36B0", Offset = "0x18C20B0", VA = "0x1818C36B0")]
		static Critter()
		{
			Func<Critter> func = default(Func<Critter>);
			_parser = (MessageParser<Critter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
