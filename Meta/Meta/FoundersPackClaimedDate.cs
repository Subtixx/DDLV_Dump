using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008ED")]
	public sealed class FoundersPackClaimedDate : IMessage<FoundersPackClaimedDate>, IMessage, IEquatable<FoundersPackClaimedDate>, IDeepCloneable<FoundersPackClaimedDate>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002429")]
		private static readonly MessageParser<FoundersPackClaimedDate> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400242A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400242B")]
		public const int DateFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400242C")]
		private Timestamp date_;

		[Cpp2IlInjected.Token(Token = "0x400242D")]
		public const int IsAccurateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400242E")]
		private bool isAccurate_;

		[Cpp2IlInjected.Token(Token = "0x17000D28")]
		[DebuggerNonUserCode]
		public static MessageParser<FoundersPackClaimedDate> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D50")]
			[Cpp2IlInjected.Address(RVA = "0x1808120", Offset = "0x1806B20", VA = "0x181808120")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D29")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D51")]
			[Cpp2IlInjected.Address(RVA = "0x1808050", Offset = "0x1806A50", VA = "0x181808050")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D2A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D52")]
			[Cpp2IlInjected.Address(RVA = "0x1808180", Offset = "0x1806B80", VA = "0x181808180", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D2B")]
		[DebuggerNonUserCode]
		public Timestamp Date
		{
			[Cpp2IlInjected.Token(Token = "0x6004D56")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return date_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D57")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				date_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D2C")]
		[DebuggerNonUserCode]
		public bool IsAccurate
		{
			[Cpp2IlInjected.Token(Token = "0x6004D58")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return isAccurate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D59")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				isAccurate_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D53")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FoundersPackClaimedDate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D54")]
		[Cpp2IlInjected.Address(RVA = "0x1807FD0", Offset = "0x18069D0", VA = "0x181807FD0")]
		[DebuggerNonUserCode]
		public FoundersPackClaimedDate(FoundersPackClaimedDate other)
		{
			//IL_0021: Expected O, but got I4
			Timestamp timestamp = other.date_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			date_ = (Timestamp)num;
			bool flag = (isAccurate_ = other.isAccurate_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D55")]
		[Cpp2IlInjected.Address(RVA = "0x1807800", Offset = "0x1806200", VA = "0x181807800", Slot = "10")]
		[DebuggerNonUserCode]
		public FoundersPackClaimedDate Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0021: Expected O, but got I4
			FoundersPackClaimedDate foundersPackClaimedDate = new FoundersPackClaimedDate();
			Timestamp timestamp = date_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			foundersPackClaimedDate.date_ = (Timestamp)num;
			bool flag = (foundersPackClaimedDate.isAccurate_ = isAccurate_);
			UnknownFieldSet unknownFieldSet = (foundersPackClaimedDate._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return foundersPackClaimedDate;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D5A")]
		[Cpp2IlInjected.Address(RVA = "0x18078B0", Offset = "0x18062B0", VA = "0x1818078B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(date_, other);
				if (flag && isAccurate_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D5B")]
		[Cpp2IlInjected.Address(RVA = "0x1807960", Offset = "0x1806360", VA = "0x181807960", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FoundersPackClaimedDate other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.date_;
				if (object.Equals(date_, objB))
				{
					bool flag = other.isAccurate_;
					if (isAccurate_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D5C")]
		[Cpp2IlInjected.Address(RVA = "0x1807AA0", Offset = "0x18064A0", VA = "0x181807AA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = date_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				if (isAccurate_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D5D")]
		[Cpp2IlInjected.Address(RVA = "0x1807DD0", Offset = "0x18067D0", VA = "0x181807DD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D5E")]
		[Cpp2IlInjected.Address(RVA = "0x1807E30", Offset = "0x1806830", VA = "0x181807E30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)date_ != 0)
			{
				Timestamp value = date_;
				output.WriteMessage(value);
			}
			if (isAccurate_)
			{
				bool value2 = isAccurate_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D5F")]
		[Cpp2IlInjected.Address(RVA = "0x1807730", Offset = "0x1806130", VA = "0x181807730", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = date_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
					num2++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D60")]
		[Cpp2IlInjected.Address(RVA = "0x1807C20", Offset = "0x1806620", VA = "0x181807C20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FoundersPackClaimedDate other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.date_ != 0)
			{
				Timestamp timestamp = date_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (date_ = new Timestamp());
				}
				Timestamp other2 = other.date_;
				timestamp.MergeFrom(other2);
			}
			bool flag = other.isAccurate_;
			if (flag)
			{
				isAccurate_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004D61")]
		[Cpp2IlInjected.Address(RVA = "0x1807B30", Offset = "0x1806530", VA = "0x181807B30", Slot = "5")]
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
				Timestamp timestamp = date_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (date_ = new Timestamp());
				}
				input.ReadMessage(timestamp);
			}
			if (num == 16)
			{
				bool flag = (isAccurate_ = input.ReadBool());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004D62")]
		[Cpp2IlInjected.Address(RVA = "0x18079D0", Offset = "0x18063D0", VA = "0x1818079D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = date_;
			}
			if (fieldNumber == 2)
			{
				bool flag = isAccurate_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D63")]
		[Cpp2IlInjected.Address(RVA = "0x1807D00", Offset = "0x1806700", VA = "0x181807D00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				date_ = (Timestamp)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				isAccurate_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D64")]
		[Cpp2IlInjected.Address(RVA = "0x18077D0", Offset = "0x18061D0", VA = "0x1818077D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				isAccurate_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D65")]
		[Cpp2IlInjected.Address(RVA = "0x1807EC0", Offset = "0x18068C0", VA = "0x181807EC0")]
		static FoundersPackClaimedDate()
		{
			Func<FoundersPackClaimedDate> func = default(Func<FoundersPackClaimedDate>);
			_parser = (MessageParser<FoundersPackClaimedDate>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
