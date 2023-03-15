using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008AA")]
	public sealed class CriticalSuccess : IMessage<CriticalSuccess>, IMessage, IEquatable<CriticalSuccess>, IDeepCloneable<CriticalSuccess>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20008AB")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20008AC")]
			public sealed class CountersData : IMessage<CountersData>, IMessage, IEquatable<CountersData>, IDeepCloneable<CountersData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40022E8")]
				private static readonly MessageParser<CountersData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40022E9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40022EA")]
				public const int CropsHarvestedFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40022EB")]
				private static readonly MapField<int, int>.Codec _map_cropsHarvested_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40022EC")]
				private readonly MapField<int, int> cropsHarvested_;

				[Cpp2IlInjected.Token(Token = "0x40022ED")]
				public const int FishesFishedFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40022EE")]
				private int fishesFished_;

				[Cpp2IlInjected.Token(Token = "0x40022EF")]
				public const int RocksMinedFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40022F0")]
				private int rocksMined_;

				[Cpp2IlInjected.Token(Token = "0x17000C64")]
				[DebuggerNonUserCode]
				public static MessageParser<CountersData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60049F9")]
					[Cpp2IlInjected.Address(RVA = "0x26421C0", Offset = "0x2640BC0", VA = "0x1826421C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C65")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60049FA")]
					[Cpp2IlInjected.Address(RVA = "0x2642140", Offset = "0x2640B40", VA = "0x182642140")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C66")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60049FB")]
					[Cpp2IlInjected.Address(RVA = "0x2642220", Offset = "0x2640C20", VA = "0x182642220", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C67")]
				[DebuggerNonUserCode]
				public MapField<int, int> CropsHarvested
				{
					[Cpp2IlInjected.Token(Token = "0x60049FF")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C68")]
				[DebuggerNonUserCode]
				public int FishesFished
				{
					[Cpp2IlInjected.Token(Token = "0x6004A00")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004A01")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C69")]
				[DebuggerNonUserCode]
				public int RocksMined
				{
					[Cpp2IlInjected.Token(Token = "0x6004A02")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004A03")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60049FC")]
				[Cpp2IlInjected.Address(RVA = "0x2641FB0", Offset = "0x26409B0", VA = "0x182641FB0")]
				[DebuggerNonUserCode]
				public CountersData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049FD")]
				[Cpp2IlInjected.Address(RVA = "0x2642030", Offset = "0x2640A30", VA = "0x182642030")]
				[DebuggerNonUserCode]
				public CountersData(CountersData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049FE")]
				[Cpp2IlInjected.Address(RVA = "0x2641640", Offset = "0x2640040", VA = "0x182641640", Slot = "10")]
				[DebuggerNonUserCode]
				public CountersData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004A04")]
				[Cpp2IlInjected.Address(RVA = "0x2641810", Offset = "0x2640210", VA = "0x182641810", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004A05")]
				[Cpp2IlInjected.Address(RVA = "0x2641770", Offset = "0x2640170", VA = "0x182641770", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(CountersData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004A06")]
				[Cpp2IlInjected.Address(RVA = "0x2004090", Offset = "0x2002A90", VA = "0x182004090", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004A07")]
				[Cpp2IlInjected.Address(RVA = "0x2641CA0", Offset = "0x26406A0", VA = "0x182641CA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004A08")]
				[Cpp2IlInjected.Address(RVA = "0x2641D00", Offset = "0x2640700", VA = "0x182641D00", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A09")]
				[Cpp2IlInjected.Address(RVA = "0x2641480", Offset = "0x263FE80", VA = "0x182641480", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004A0A")]
				[Cpp2IlInjected.Address(RVA = "0x2641AF0", Offset = "0x26404F0", VA = "0x182641AF0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(CountersData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A0B")]
				[Cpp2IlInjected.Address(RVA = "0x26419D0", Offset = "0x26403D0", VA = "0x1826419D0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A0C")]
				[Cpp2IlInjected.Address(RVA = "0x2641900", Offset = "0x2640300", VA = "0x182641900", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004A0D")]
				[Cpp2IlInjected.Address(RVA = "0x2641B80", Offset = "0x2640580", VA = "0x182641B80", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A0E")]
				[Cpp2IlInjected.Address(RVA = "0x26415B0", Offset = "0x263FFB0", VA = "0x1826415B0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40022DC")]
		private static readonly MessageParser<CriticalSuccess> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40022DD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40022DE")]
		public const int LastCriticalSuccessFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40022DF")]
		private Timestamp lastCriticalSuccess_;

		[Cpp2IlInjected.Token(Token = "0x40022E0")]
		public const int CountersFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40022E1")]
		private Types.CountersData counters_;

		[Cpp2IlInjected.Token(Token = "0x40022E2")]
		private const string RandomSeedName = "BurningState";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40022E3")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40022E4")]
		private ProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40022E5")]
		private ITransactionContext transactionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40022E6")]
		private CriticalSuccessData criticalSuccessData;

		[Cpp2IlInjected.Token(Token = "0x17000C5E")]
		[DebuggerNonUserCode]
		public static MessageParser<CriticalSuccess> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60049D5")]
			[Cpp2IlInjected.Address(RVA = "0x18C28C0", Offset = "0x18C12C0", VA = "0x1818C28C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C5F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60049D6")]
			[Cpp2IlInjected.Address(RVA = "0x18C27F0", Offset = "0x18C11F0", VA = "0x1818C27F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C60")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60049D7")]
			[Cpp2IlInjected.Address(RVA = "0x18C2920", Offset = "0x18C1320", VA = "0x1818C2920", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C61")]
		[DebuggerNonUserCode]
		public Timestamp LastCriticalSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x60049DC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return lastCriticalSuccess_;
			}
			[Cpp2IlInjected.Token(Token = "0x60049DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				lastCriticalSuccess_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C62")]
		[DebuggerNonUserCode]
		public Types.CountersData Counters
		{
			[Cpp2IlInjected.Token(Token = "0x60049DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return counters_;
			}
			[Cpp2IlInjected.Token(Token = "0x60049DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				counters_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C63")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x40022E7")]
		public bool Force
		{
			[Cpp2IlInjected.Token(Token = "0x60049EB")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60049EC")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x60049D8")]
		[Cpp2IlInjected.Address(RVA = "0x18C2690", Offset = "0x18C1090", VA = "0x1818C2690")]
		[DebuggerNonUserCode]
		public CriticalSuccess()
		{
			Types.CountersData countersData = (counters_ = new Types.CountersData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049D9")]
		[Cpp2IlInjected.Address(RVA = "0x18C1750", Offset = "0x18C0150", VA = "0x1818C1750")]
		private void OnConstruction()
		{
			Types.CountersData countersData = (counters_ = new Types.CountersData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049DA")]
		[Cpp2IlInjected.Address(RVA = "0x18C2700", Offset = "0x18C1100", VA = "0x1818C2700")]
		[DebuggerNonUserCode]
		public CriticalSuccess(CriticalSuccess other)
		{
			//IL_002e: Expected O, but got I4
			Types.CountersData countersData = (counters_ = new Types.CountersData());
			Timestamp timestamp = other.lastCriticalSuccess_;
			int num = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			lastCriticalSuccess_ = (Timestamp)num;
			Types.CountersData countersData2 = other.counters_;
			Types.CountersData countersData3 = default(Types.CountersData);
			if (countersData2 != null)
			{
				countersData3 = countersData2.Clone();
			}
			counters_ = countersData3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60049DB")]
		[Cpp2IlInjected.Address(RVA = "0x18C0E30", Offset = "0x18BF830", VA = "0x1818C0E30", Slot = "10")]
		[DebuggerNonUserCode]
		public CriticalSuccess Clone()
		{
			//Discarded unreachable code: IL_0064
			//IL_002f: Expected O, but got I4
			CriticalSuccess criticalSuccess = new CriticalSuccess();
			Types.CountersData countersData = (criticalSuccess.counters_ = new Types.CountersData());
			Timestamp timestamp = lastCriticalSuccess_;
			int num = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			criticalSuccess.lastCriticalSuccess_ = (Timestamp)num;
			Types.CountersData countersData2 = counters_;
			Types.CountersData countersData3 = default(Types.CountersData);
			if (countersData2 != null)
			{
				countersData3 = countersData2.Clone();
			}
			criticalSuccess.counters_ = countersData3;
			UnknownFieldSet unknownFieldSet = (criticalSuccess._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return criticalSuccess;
		}

		[Cpp2IlInjected.Token(Token = "0x60049E0")]
		[Cpp2IlInjected.Address(RVA = "0x18C1070", Offset = "0x18BFA70", VA = "0x1818C1070", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(lastCriticalSuccess_, other) && object.Equals(counters_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049E1")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CriticalSuccess other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.lastCriticalSuccess_;
				if (object.Equals(lastCriticalSuccess_, objB))
				{
					Types.CountersData objB2 = other.counters_;
					if (object.Equals(counters_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049E2")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = lastCriticalSuccess_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				Types.CountersData countersData = counters_;
				if (countersData != null)
				{
					int hashCode2 = countersData.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60049E3")]
		[Cpp2IlInjected.Address(RVA = "0x18C1C10", Offset = "0x18C0610", VA = "0x1818C1C10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60049E4")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)lastCriticalSuccess_ != 0)
			{
				Timestamp value = lastCriticalSuccess_;
				output.WriteMessage(value);
			}
			if ((long)counters_ != 0)
			{
				Types.CountersData value2 = counters_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60049E5")]
		[Cpp2IlInjected.Address(RVA = "0x18C0D60", Offset = "0x18BF760", VA = "0x1818C0D60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = lastCriticalSuccess_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				}
				Types.CountersData countersData = counters_;
				if (countersData != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(countersData);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60049E6")]
		[Cpp2IlInjected.Address(RVA = "0x18C1620", Offset = "0x18C0020", VA = "0x1818C1620", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CriticalSuccess other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.lastCriticalSuccess_ != 0)
			{
				Timestamp timestamp = lastCriticalSuccess_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastCriticalSuccess_ = new Timestamp());
					Timestamp timestamp3 = lastCriticalSuccess_;
				}
				Timestamp other2 = other.lastCriticalSuccess_;
				timestamp.MergeFrom(other2);
			}
			if ((long)other.counters_ != 0)
			{
				Types.CountersData countersData2 = default(Types.CountersData);
				if (counters_ == null)
				{
					Types.CountersData countersData = (counters_ = new Types.CountersData());
					countersData2 = counters_;
				}
				Types.CountersData other3 = other.counters_;
				countersData2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60049E7")]
		[Cpp2IlInjected.Address(RVA = "0x18C14E0", Offset = "0x18BFEE0", VA = "0x1818C14E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Timestamp timestamp = lastCriticalSuccess_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastCriticalSuccess_ = new Timestamp());
				}
				input.ReadMessage(timestamp);
			}
			if (num == 18)
			{
				Types.CountersData builder = default(Types.CountersData);
				if (counters_ == null)
				{
					Types.CountersData countersData = (counters_ = new Types.CountersData());
					builder = counters_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60049E8")]
		[Cpp2IlInjected.Address(RVA = "0x18C1130", Offset = "0x18BFB30", VA = "0x1818C1130", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = lastCriticalSuccess_;
			}
			if (fieldNumber == 2)
			{
				Types.CountersData countersData = counters_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049E9")]
		[Cpp2IlInjected.Address(RVA = "0x18C1A30", Offset = "0x18C0430", VA = "0x1818C1A30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					lastCriticalSuccess_ = (Timestamp)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60049EA")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049ED")]
		[Cpp2IlInjected.Address(RVA = "0x18C11C0", Offset = "0x18BFBC0", VA = "0x1818C11C0")]
		internal void Initialize(Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext transactionContext)
		{
			//Discarded unreachable code: IL_0058
			this.profile = profile;
			this.dispatcher = dispatcher;
			this.transactionContext = transactionContext;
			ProfileEventDispatcher.GardeningEvent value = OnGardeningEvent;
			dispatcher.OnGardeningEvent += value;
			ProfileEventDispatcher.FishingResultReceived value2 = OnFishingResultReceived;
			dispatcher.OnFishingResultReceived += value2;
			ProfileEventDispatcher.MiningRockEmptied value3 = OnMiningRockEmptied;
			dispatcher.OnMiningRockEmptied += value3;
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
		}

		[Cpp2IlInjected.Token(Token = "0x60049EE")]
		[Cpp2IlInjected.Address(RVA = "0x18C1DE0", Offset = "0x18C07E0", VA = "0x1818C1DE0")]
		internal bool TryHarvestCriticalSuccess(GardenItemData gardenItemData, IGrid grid, GridObject gridObject, int slotIndex, out int minigameID)
		{
			//IL_0072: Expected O, but got I8
			//IL_00de: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			SeedItemData seedItemData;
			CriticalSuccessData.Types.ActivityData activityData;
			if (!IsInCooldown())
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				RepeatedField<GardenData.Types.GardeningSlot> slots_ = gridObject.state_.GardenData.slots_;
				GardenData.Types.GardeningSlot gardeningSlot = default(GardenData.Types.GardeningSlot);
				Item plantedSeedItem = gardeningSlot.PlantedSeedItem;
				SeedItemData seedItemData2 = default(SeedItemData);
				seedItemData = seedItemData2;
				SeedItemData seedItemData3 = seedItemData;
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Item producedItem = seedItemData3.ProducedItem;
				IItemData itemData = default(IItemData);
				if (!itemData.IsMissionItem())
				{
					if (itemData == null || itemData != null)
					{
					}
					activityData = (CriticalSuccessData.Types.ActivityData)0;
					if (1 == 0)
					{
						CriticalSuccessData criticalSuccessData = this.criticalSuccessData;
					}
					if (1L == 1L)
					{
						activityData = this.criticalSuccessData.harvestVegetable_;
					}
					if ((long)activityData != 0)
					{
						MapField<int, int> cropsHarvested_ = counters_.cropsHarvested_;
						Func<List<MultiItemInstance>> func = (Func<List<MultiItemInstance>>)(object)new Func<TResult>(GetItemsToCollect);
						bool flag = default(bool);
						if (flag)
						{
							MapField<int, int> cropsHarvested_2 = counters_.cropsHarvested_;
							int num = 0;
							((MapField<TKey, TValue>)(object)cropsHarvested_2)[(TKey)1] = (TValue)num;
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6004A14")]
			[Cpp2IlInjected.Address(RVA = "0x9AA970", Offset = "0x9A9370", VA = "0x1809AA970")]
			List<MultiItemInstance> GetItemsToCollect()
			{
				//Discarded unreachable code: IL_0033
				int numberOfItemsToCollect_ = activityData.minigameData_.numberOfItemsToCollect_;
				IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Range(0, numberOfItemsToCollect_);
				Func<int, MultiItemInstance> func2 = (Func<int, MultiItemInstance>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_003d
					//IL_0034: Expected I4, but got I8
					MultiItemInstance multiItemInstance = new MultiItemInstance();
					RepeatedField<ItemInstance> items_ = multiItemInstance.items_;
					ItemInstance itemInstance = new ItemInstance();
					int num3 = (itemInstance.ItemID = seedItemData.ProducedItem.ItemID);
					itemInstance.amount_ = 1;
					((RepeatedField<T>)(object)items_).Add((T)itemInstance);
					return multiItemInstance;
				};
				return (List<MultiItemInstance>)(object)Enumerable.ToList<MultiItemInstance>(Enumerable.Select<int, MultiItemInstance>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049EF")]
		[Cpp2IlInjected.Address(RVA = "0x18C1C70", Offset = "0x18C0670", VA = "0x1818C1C70")]
		internal bool TryFishingCriticalSuccess(PendingFish pendingFish, out int minigameID)
		{
			//IL_005a: Expected I4, but got I8
			if (!IsInCooldown())
			{
				PendingFish pendingFish2 = pendingFish;
				CriticalSuccessData.Types.ActivityData fishing_ = criticalSuccessData.fishing_;
				int fishesFished_ = counters_.fishesFished_;
				Func<List<MultiItemInstance>> func = (Func<List<MultiItemInstance>>)(object)new Func<TResult>(GetItemsToCollect);
				int fishesFished_2 = 0;
				ulong num = default(ulong);
				if (this.TryToTriggerCriticalSuccess(fishing_, fishesFished_, (Func<>)(object)func, ref minigameID, (byte)num != 0))
				{
					counters_.fishesFished_ = fishesFished_2;
					return true;
				}
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6004A17")]
			[Cpp2IlInjected.Address(RVA = "0x9AAB70", Offset = "0x9A9570", VA = "0x1809AAB70")]
			List<MultiItemInstance> GetItemsToCollect()
			{
				//Discarded unreachable code: IL_009b
				CriticalSuccess criticalSuccess = this;
				ITransactionContext context = criticalSuccess.transactionContext;
				Profile profile = criticalSuccess.profile;
				PendingFish pendingFish3 = pendingFish;
				FishingRewardSelector fishingRewardSelector = FishingRewardSelector.Create(profile, context, pendingFish3);
				Random random = new Random(this.profile.player_.GetRandomSeed("BurningState"));
				ItemCollectMinigameData minigameData_ = criticalSuccessData.fishing_.minigameData_;
				Func<FishingDataItemData, MultiItemInstance> func2 = (Func<FishingDataItemData, MultiItemInstance>)(object)(Func<T, TResult>)delegate(FishingDataItemData chosenFishingData)
				{
					//Discarded unreachable code: IL_0017
					CriticalSuccess criticalSuccess2 = this;
					ItemWithState result_ = chosenFishingData.result_;
					return criticalSuccess2.CreateMultiItemInstanceFrom(result_);
				};
				IEnumerable<FishingDataItemData> enumerable = default(IEnumerable<FishingDataItemData>);
				List<MultiItemInstance> result = (List<MultiItemInstance>)(object)Enumerable.ToList<MultiItemInstance>(Enumerable.Select<FishingDataItemData, MultiItemInstance>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
				this.profile.player_.AdvanceRandomSeed("BurningState");
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049F0")]
		[Cpp2IlInjected.Address(RVA = "0x18C21C0", Offset = "0x18C0BC0", VA = "0x1818C21C0")]
		internal bool TryMiningCriticalSuccess(MiningDataItemData[] miningDataItemDatas, MiningData miningData, out int minigameID)
		{
			if (!IsInCooldown())
			{
				CriticalSuccessData.Types.ActivityData mining_ = criticalSuccessData.mining_;
				int rocksMined_ = counters_.rocksMined_;
				Func<List<MultiItemInstance>> func = (Func<List<MultiItemInstance>>)(object)new Func<TResult>(GetItemsToCollect);
				int num = 0;
				if (this.TryToTriggerCriticalSuccess(mining_, rocksMined_, (Func<>)(object)func, ref minigameID, (byte)num != 0))
				{
					counters_.rocksMined_ = num;
					return true;
				}
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6004A1A")]
			[Cpp2IlInjected.Address(RVA = "0x9AAD80", Offset = "0x9A9780", VA = "0x1809AAD80")]
			List<MultiItemInstance> GetItemsToCollect()
			{
				//Discarded unreachable code: IL_0091
				Random random = new Random(profile.player_.GetRandomSeed("BurningState"));
				int numberOfItemsToCollect_ = criticalSuccessData.mining_.minigameData_.numberOfItemsToCollect_;
				IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Range(0, numberOfItemsToCollect_);
				Func<int, MultiItemInstance> func2 = (Func<int, MultiItemInstance>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_005f
					CriticalSuccess criticalSuccess = this;
					MiningDataItemData[] miningDataItemDatas2 = miningDataItemDatas;
					Random random2 = random;
					ProfilePlayer player_ = criticalSuccess.profile.player_;
					MiningData miningData2 = miningData;
					MiningDataItemData miningDataItemData = HitMiningRock.Types.Response.ChooseMiningData(miningDataItemDatas2, random2, player_, miningData2);
					CriticalSuccess criticalSuccess2 = this;
					ItemWithState result_ = miningDataItemData.result_;
					return criticalSuccess2.CreateMultiItemInstanceFrom(result_);
				};
				List<MultiItemInstance> result = (List<MultiItemInstance>)(object)Enumerable.ToList<MultiItemInstance>(Enumerable.Select<int, MultiItemInstance>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
				profile.player_.AdvanceRandomSeed("BurningState");
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049F1")]
		[Cpp2IlInjected.Address(RVA = "0x18C0F50", Offset = "0x18BF950", VA = "0x1818C0F50")]
		private MultiItemInstance CreateMultiItemInstanceFrom(ItemWithState itemWithState, int amount = 1)
		{
			//Discarded unreachable code: IL_0057
			//IL_004e: Expected O, but got I4
			MultiItemInstance multiItemInstance = new MultiItemInstance();
			RepeatedField<ItemInstance> items_ = multiItemInstance.items_;
			ItemInstance itemInstance = new ItemInstance();
			int num = (itemInstance.ItemID = itemWithState.Item.ItemID);
			itemInstance.amount_ = amount;
			ItemState state_ = itemWithState.state_;
			if (state_ != null)
			{
				ItemState itemState = state_.Clone();
			}
			int num2 = 0;
			itemInstance.state_ = (ItemState)num2;
			((RepeatedField<T>)(object)items_).Add((T)itemInstance);
			return multiItemInstance;
		}

		[Cpp2IlInjected.Token(Token = "0x60049F2")]
		[Cpp2IlInjected.Address(RVA = "0x18C13E0", Offset = "0x18BFDE0", VA = "0x1818C13E0")]
		private bool IsInCooldown()
		{
			if (!Force && (long)lastCriticalSuccess_ != 0)
			{
				ITransactionContext transactionContext = this.transactionContext;
				DateTime dateTime = lastCriticalSuccess_.ToDateTime();
				TimeSpan timeSpan = criticalSuccessData.cooldownDuration_.ToTimeSpan();
				DateTime dateTime2 = dateTime + timeSpan;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60049F3")]
		[Cpp2IlInjected.Address(RVA = "0x18C2330", Offset = "0x18C0D30", VA = "0x1818C2330")]
		private bool TryToTriggerCriticalSuccess(CriticalSuccessData.Types.ActivityData activityData, int numberOfFailedAttempts, Func<List<MultiItemInstance>> getItemsToCollect, out int minigameID, bool delayedStart = false)
		{
			if (!Force)
			{
				Random random = new Random(this.profile.player_.GetRandomSeed("BurningState"));
				int probability_ = activityData.probability_;
				int probabilityIncreasePerTry_ = activityData.probabilityIncreasePerTry_;
				int minValue = 0;
				uint maxValue = default(uint);
				int num = random.Next(minValue, (int)maxValue);
				this.profile.player_.AdvanceRandomSeed("BurningState");
				int num2 = probabilityIncreasePerTry_ * numberOfFailedAttempts;
				num2 += probability_;
				if (num >= num2)
				{
					int num3 = 0;
				}
			}
			ITransactionContext transactionContext = this.transactionContext;
			Timestamp timestamp = default(Timestamp);
			lastCriticalSuccess_ = timestamp;
			ITransactionContext transactionContext2 = this.transactionContext;
			Profile profile = this.profile;
			List<MultiItemInstance> list = (List<MultiItemInstance>)getItemsToCollect();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60049F4")]
		[Cpp2IlInjected.Address(RVA = "0x18C1AF0", Offset = "0x18C04F0", VA = "0x1818C1AF0")]
		private bool ShouldTriggerCriticalSuccess(CriticalSuccessData.Types.ActivityData activityData, int numberOfFailedAttempts)
		{
			if (!Force)
			{
				Random random = new Random(profile.player_.GetRandomSeed("BurningState"));
				int probability_ = activityData.probability_;
				int probabilityIncreasePerTry_ = activityData.probabilityIncreasePerTry_;
				int minValue = 0;
				uint maxValue = default(uint);
				int num = random.Next(minValue, (int)maxValue);
				profile.player_.AdvanceRandomSeed("BurningState");
				int num2 = probabilityIncreasePerTry_ * numberOfFailedAttempts;
				num2 += probability_;
				return num < num2;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60049F5")]
		[Cpp2IlInjected.Address(RVA = "0x18C17D0", Offset = "0x18C01D0", VA = "0x1818C17D0")]
		private void OnGardeningEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_0079
			//IL_0038: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			//IL_006a: Expected O, but got I4
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected I4, but got Unknown
			//IL_0078: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
			SeedItemData seedItemData = default(SeedItemData);
			Item producedItem = seedItemData.ProducedItem;
			CropItemData cropItemData = default(CropItemData);
			if (cropItemData != null)
			{
			}
			if (!((MapField<TKey, TValue>)(object)counters_.cropsHarvested_).ContainsKey((TKey)1))
			{
				MapField<int, int> cropsHarvested_ = counters_.cropsHarvested_;
				int num = 0;
				((MapField<TKey, TValue>)(object)cropsHarvested_).Add((TKey)1, (TValue)num);
			}
			MapField<int, int> cropsHarvested_2 = counters_.cropsHarvested_;
			int num2 = ((MapField<TKey, TValue>)(object)cropsHarvested_2)[(TKey)1] + 1;
			((MapField<TKey, TValue>)(object)cropsHarvested_2)[(TKey)1] = (TValue)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60049F6")]
		[Cpp2IlInjected.Address(RVA = "0x18C17B0", Offset = "0x18C01B0", VA = "0x1818C17B0")]
		private void OnFishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter areaFished, Item spectator, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_000c
			if (success)
			{
				Types.CountersData countersData = counters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049F7")]
		[Cpp2IlInjected.Address(RVA = "0x18C1A10", Offset = "0x18C0410", VA = "0x1818C1A10")]
		private void OnMiningRockEmptied(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_000c
			if (success)
			{
				Types.CountersData countersData = counters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049F8")]
		[Cpp2IlInjected.Address(RVA = "0x18C2580", Offset = "0x18C0F80", VA = "0x1818C2580")]
		static CriticalSuccess()
		{
			Func<CriticalSuccess> func = default(Func<CriticalSuccess>);
			_parser = (MessageParser<CriticalSuccess>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
