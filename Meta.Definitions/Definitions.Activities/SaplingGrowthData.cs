using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000889")]
	public sealed class SaplingGrowthData : IGridStateData, IGrowable, IMessage<SaplingGrowthData>, IMessage, IEquatable<SaplingGrowthData>, IDeepCloneable<SaplingGrowthData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002A11")]
		private static readonly MessageParser<SaplingGrowthData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A12")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A13")]
		public const int EndOfGrowthFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A14")]
		private Timestamp endOfGrowth_;

		[Cpp2IlInjected.Token(Token = "0x4002A15")]
		public const int LastWateringDateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A16")]
		private Timestamp lastWateringDate_;

		[Cpp2IlInjected.Token(Token = "0x170017F9")]
		[DebuggerNonUserCode]
		public static MessageParser<SaplingGrowthData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005F59")]
			[Cpp2IlInjected.Address(RVA = "0x2DB3140", Offset = "0x2DB1B40", VA = "0x182DB3140")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017FA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F5A")]
			[Cpp2IlInjected.Address(RVA = "0x2DB3070", Offset = "0x2DB1A70", VA = "0x182DB3070")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017FB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F5B")]
			[Cpp2IlInjected.Address(RVA = "0x2DB31A0", Offset = "0x2DB1BA0", VA = "0x182DB31A0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017FC")]
		[DebuggerNonUserCode]
		public Timestamp EndOfGrowth
		{
			[Cpp2IlInjected.Token(Token = "0x6005F60")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "4")]
			get
			{
				return endOfGrowth_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F61")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "5")]
			set
			{
				endOfGrowth_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017FD")]
		[DebuggerNonUserCode]
		public Timestamp LastWateringDate
		{
			[Cpp2IlInjected.Token(Token = "0x6005F62")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return lastWateringDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F63")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				lastWateringDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F58")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2830", Offset = "0x2DB1230", VA = "0x182DB2830")]
		public void Initialize(SeedItemData plantedSeedItemData, ITransactionContext context)
		{
			TimeSpan timeSpan = plantedSeedItemData.growthPeriod_.ToTimeSpan();
			DateTime dateTime = default(DateTime);
			Timestamp timestamp = (endOfGrowth_ = Timestamp.FromDateTime(dateTime));
			Timestamp timestamp2 = default(Timestamp);
			lastWateringDate_ = timestamp2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F5C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2EC0", Offset = "0x2DB18C0", VA = "0x182DB2EC0")]
		[DebuggerNonUserCode]
		public SaplingGrowthData()
		{
			Timestamp timestamp = (endOfGrowth_ = new Timestamp());
			Timestamp timestamp2 = (lastWateringDate_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F5D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2C10", Offset = "0x2DB1610", VA = "0x182DB2C10")]
		private void OnConstruction()
		{
			Timestamp timestamp = (endOfGrowth_ = new Timestamp());
			Timestamp timestamp2 = (lastWateringDate_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F5E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2F50", Offset = "0x2DB1950", VA = "0x182DB2F50")]
		[DebuggerNonUserCode]
		public SaplingGrowthData(SaplingGrowthData other)
		{
			//IL_003c: Expected O, but got I4
			Timestamp timestamp = (endOfGrowth_ = new Timestamp());
			Timestamp timestamp2 = (lastWateringDate_ = new Timestamp());
			Timestamp timestamp3 = other.endOfGrowth_;
			int num = 0;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			endOfGrowth_ = (Timestamp)num;
			Timestamp timestamp5 = other.lastWateringDate_;
			Timestamp timestamp6 = default(Timestamp);
			if (timestamp5 != null)
			{
				timestamp6 = timestamp5.Clone();
			}
			lastWateringDate_ = timestamp6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F5F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2580", Offset = "0x2DB0F80", VA = "0x182DB2580", Slot = "12")]
		[DebuggerNonUserCode]
		public SaplingGrowthData Clone()
		{
			//Discarded unreachable code: IL_0073
			//IL_003e: Expected O, but got I4
			SaplingGrowthData saplingGrowthData = new SaplingGrowthData();
			Timestamp timestamp = (saplingGrowthData.endOfGrowth_ = new Timestamp());
			Timestamp timestamp2 = (saplingGrowthData.lastWateringDate_ = new Timestamp());
			Timestamp timestamp3 = endOfGrowth_;
			int num = 0;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			saplingGrowthData.endOfGrowth_ = (Timestamp)num;
			Timestamp timestamp5 = lastWateringDate_;
			Timestamp timestamp6 = default(Timestamp);
			if (timestamp5 != null)
			{
				timestamp6 = timestamp5.Clone();
			}
			saplingGrowthData.lastWateringDate_ = timestamp6;
			UnknownFieldSet unknownFieldSet = (saplingGrowthData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return saplingGrowthData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F64")]
		[Cpp2IlInjected.Address(RVA = "0x2DB26E0", Offset = "0x2DB10E0", VA = "0x182DB26E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(endOfGrowth_, other) && object.Equals(lastWateringDate_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F65")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(SaplingGrowthData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.endOfGrowth_;
				if (object.Equals(endOfGrowth_, objB))
				{
					Timestamp objB2 = other.lastWateringDate_;
					if (object.Equals(lastWateringDate_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F66")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = endOfGrowth_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				Timestamp timestamp2 = lastWateringDate_;
				if (timestamp2 != null)
				{
					int hashCode2 = timestamp2.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F67")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2D50", Offset = "0x2DB1750", VA = "0x182DB2D50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F68")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)endOfGrowth_ != 0)
			{
				Timestamp value = endOfGrowth_;
				output.WriteMessage(value);
			}
			if ((long)lastWateringDate_ != 0)
			{
				Timestamp value2 = lastWateringDate_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F69")]
		[Cpp2IlInjected.Address(RVA = "0x2DB24B0", Offset = "0x2DB0EB0", VA = "0x182DB24B0", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = endOfGrowth_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				}
				Timestamp timestamp2 = lastWateringDate_;
				if (timestamp2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(timestamp2);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F6A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2AF0", Offset = "0x2DB14F0", VA = "0x182DB2AF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(SaplingGrowthData other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.endOfGrowth_ != 0)
			{
				Timestamp timestamp = endOfGrowth_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (endOfGrowth_ = new Timestamp());
					Timestamp timestamp3 = endOfGrowth_;
				}
				Timestamp other2 = other.endOfGrowth_;
				timestamp.MergeFrom(other2);
			}
			if ((long)other.lastWateringDate_ != 0)
			{
				Timestamp timestamp5 = default(Timestamp);
				if (lastWateringDate_ == null)
				{
					Timestamp timestamp4 = (lastWateringDate_ = new Timestamp());
					timestamp5 = lastWateringDate_;
				}
				Timestamp other3 = other.lastWateringDate_;
				timestamp5.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6005F6B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB29C0", Offset = "0x2DB13C0", VA = "0x182DB29C0", Slot = "7")]
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
				Timestamp timestamp = endOfGrowth_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (endOfGrowth_ = new Timestamp());
				}
				input.ReadMessage(timestamp);
			}
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (lastWateringDate_ == null)
				{
					Timestamp timestamp3 = (lastWateringDate_ = new Timestamp());
					builder = lastWateringDate_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005F6C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB27A0", Offset = "0x2DB11A0", VA = "0x182DB27A0", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = endOfGrowth_;
			}
			if (fieldNumber == 2)
			{
				Timestamp timestamp2 = lastWateringDate_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F6D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2CA0", Offset = "0x2DB16A0", VA = "0x182DB2CA0", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					endOfGrowth_ = (Timestamp)num;
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

		[Cpp2IlInjected.Token(Token = "0x6005F6E")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x6005F6F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2DB0", Offset = "0x2DB17B0", VA = "0x182DB2DB0")]
		static SaplingGrowthData()
		{
			Func<SaplingGrowthData> func = default(Func<SaplingGrowthData>);
			_parser = (MessageParser<SaplingGrowthData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
