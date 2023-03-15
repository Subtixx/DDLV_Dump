using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000877")]
	public sealed class FishRecord : IMessage<FishRecord>, IMessage, IEquatable<FishRecord>, IDeepCloneable<FishRecord>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002202")]
		private static readonly MessageParser<FishRecord> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002203")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002204")]
		public const int FirstObtainedFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002205")]
		private Timestamp firstObtained_;

		[Cpp2IlInjected.Token(Token = "0x4002206")]
		public const int MaxWeightFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002207")]
		private float maxWeight_;

		[Cpp2IlInjected.Token(Token = "0x17000BCE")]
		[DebuggerNonUserCode]
		public static MessageParser<FishRecord> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004754")]
			[Cpp2IlInjected.Address(RVA = "0x17FE590", Offset = "0x17FCF90", VA = "0x1817FE590")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004755")]
			[Cpp2IlInjected.Address(RVA = "0x17FE4C0", Offset = "0x17FCEC0", VA = "0x1817FE4C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004756")]
			[Cpp2IlInjected.Address(RVA = "0x17FE5F0", Offset = "0x17FCFF0", VA = "0x1817FE5F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD1")]
		[DebuggerNonUserCode]
		public Timestamp FirstObtained
		{
			[Cpp2IlInjected.Token(Token = "0x600475A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return firstObtained_;
			}
			[Cpp2IlInjected.Token(Token = "0x600475B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				firstObtained_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD2")]
		[DebuggerNonUserCode]
		public float MaxWeight
		{
			[Cpp2IlInjected.Token(Token = "0x600475C")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
			get
			{
				return maxWeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x600475D")]
			[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
			set
			{
				maxWeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004757")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FishRecord()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004758")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B00", Offset = "0x7B1500", VA = "0x1807B2B00")]
		[DebuggerNonUserCode]
		public FishRecord(FishRecord other)
		{
			//IL_0021: Expected O, but got I4
			Timestamp timestamp = other.firstObtained_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			firstObtained_ = (Timestamp)num;
			float num2 = (maxWeight_ = other.maxWeight_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004759")]
		[Cpp2IlInjected.Address(RVA = "0x17FDC00", Offset = "0x17FC600", VA = "0x1817FDC00", Slot = "10")]
		[DebuggerNonUserCode]
		public FishRecord Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0021: Expected O, but got I4
			FishRecord fishRecord = new FishRecord();
			Timestamp timestamp = firstObtained_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			fishRecord.firstObtained_ = (Timestamp)num;
			float num2 = (fishRecord.maxWeight_ = maxWeight_);
			UnknownFieldSet unknownFieldSet = (fishRecord._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return fishRecord;
		}

		[Cpp2IlInjected.Token(Token = "0x600475E")]
		[Cpp2IlInjected.Address(RVA = "0x17FDD90", Offset = "0x17FC790", VA = "0x1817FDD90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if (object.Equals(firstObtained_, other))
				{
					UnknownFieldSet unknownFields = _unknownFields;
					bool result = default(bool);
					return result;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600475F")]
		[Cpp2IlInjected.Address(RVA = "0x17FDCB0", Offset = "0x17FC6B0", VA = "0x1817FDCB0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FishRecord other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.firstObtained_;
				if (object.Equals(firstObtained_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004760")]
		[Cpp2IlInjected.Address(RVA = "0x17FDF80", Offset = "0x17FC980", VA = "0x1817FDF80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0034
			Timestamp timestamp = firstObtained_;
			if (timestamp != null)
			{
				int hashCode = timestamp.GetHashCode();
			}
			if (timestamp != null)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004761")]
		[Cpp2IlInjected.Address(RVA = "0x17FE350", Offset = "0x17FCD50", VA = "0x1817FE350", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004762")]
		[Cpp2IlInjected.Address(RVA = "0x1712F30", Offset = "0x1711930", VA = "0x181712F30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003e
			if ((long)firstObtained_ != 0)
			{
				Timestamp value = firstObtained_;
				output.WriteMessage(value);
			}
			if (output != null)
			{
				float value2 = maxWeight_;
				output.WriteFloat(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004763")]
		[Cpp2IlInjected.Address(RVA = "0x17FDB50", Offset = "0x17FC550", VA = "0x1817FDB50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = firstObtained_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				}
				num += 5;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004764")]
		[Cpp2IlInjected.Address(RVA = "0x17FE0B0", Offset = "0x17FCAB0", VA = "0x1817FE0B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishRecord other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			Timestamp timestamp = default(Timestamp);
			if ((long)other.firstObtained_ != 0)
			{
				timestamp = firstObtained_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (firstObtained_ = new Timestamp());
				}
				Timestamp other2 = other.firstObtained_;
				timestamp.MergeFrom(other2);
			}
			float num = other.maxWeight_;
			if (timestamp != null)
			{
				maxWeight_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004765")]
		[Cpp2IlInjected.Address(RVA = "0x17FE190", Offset = "0x17FCB90", VA = "0x1817FE190", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Timestamp timestamp = firstObtained_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (firstObtained_ = new Timestamp());
				}
				input.ReadMessage(timestamp);
			}
			if (num == 21)
			{
				float num2 = (maxWeight_ = input.ReadFloat());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004766")]
		[Cpp2IlInjected.Address(RVA = "0x17FDEB0", Offset = "0x17FC8B0", VA = "0x1817FDEB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = firstObtained_;
			}
			if (fieldNumber == 2)
			{
				float num = maxWeight_;
				return typeof(float).TypeHandle;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004767")]
		[Cpp2IlInjected.Address(RVA = "0x17FE280", Offset = "0x17FCC80", VA = "0x1817FE280", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected F4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				firstObtained_ = (Timestamp)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				maxWeight_ = (float)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004768")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				maxWeight_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004769")]
		[Cpp2IlInjected.Address(RVA = "0x17FE3B0", Offset = "0x17FCDB0", VA = "0x1817FE3B0")]
		static FishRecord()
		{
			Func<FishRecord> func = default(Func<FishRecord>);
			_parser = (MessageParser<FishRecord>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
