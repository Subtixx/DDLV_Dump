using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008EB")]
	public sealed class PhonePromptEventData : IMessage<PhonePromptEventData>, IMessage, IEquatable<PhonePromptEventData>, IDeepCloneable<PhonePromptEventData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400241F")]
		private static readonly MessageParser<PhonePromptEventData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002420")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002421")]
		public const int StartDateFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002422")]
		private Timestamp startDate_;

		[Cpp2IlInjected.Token(Token = "0x4002423")]
		public const int ParticipationCountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002424")]
		private int participationCount_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002425")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002426")]
		private PhonePromptData data;

		[Cpp2IlInjected.Token(Token = "0x17000D1F")]
		[DebuggerNonUserCode]
		public static MessageParser<PhonePromptEventData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D2D")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D80", Offset = "0x7B1780", VA = "0x1807B2D80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D20")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D2E")]
			[Cpp2IlInjected.Address(RVA = "0x7B2C90", Offset = "0x7B1690", VA = "0x1807B2C90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D21")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D2F")]
			[Cpp2IlInjected.Address(RVA = "0x7B2DE0", Offset = "0x7B17E0", VA = "0x1807B2DE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D22")]
		[DebuggerNonUserCode]
		public Timestamp StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6004D33")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return startDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D34")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				startDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D23")]
		[DebuggerNonUserCode]
		public int ParticipationCount
		{
			[Cpp2IlInjected.Token(Token = "0x6004D35")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return participationCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D36")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				participationCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D24")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004D42")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return name;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D43")]
			[Cpp2IlInjected.Address(RVA = "0x7B2F00", Offset = "0x7B1900", VA = "0x1807B2F00")]
			set
			{
				if (name != value)
				{
					name = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D25")]
		public unsafe PhonePromptData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6004D44")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B80", Offset = "0x7B1580", VA = "0x1807B2B80")]
			get
			{
				//Discarded unreachable code: IL_002d
				//IL_002b: Expected O, but got I4
				PhonePromptData phonePromptData = data;
				int num = 0;
				if (phonePromptData == null)
				{
					ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
					string text = name;
					bool flag = _003CInstance_003Ek__BackingField.TryGet(text, out *(PhonePromptData*)num);
					data = (PhonePromptData)num;
				}
				return phonePromptData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D26")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4002427")]
		public DateTime EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6004D45")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004D46")]
			[Cpp2IlInjected.Address(RVA = "0x7B2EF0", Offset = "0x7B18F0", VA = "0x1807B2EF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000D27")]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6004D47")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D60", Offset = "0x7B1760", VA = "0x1807B2D60")]
			get
			{
				return !string.IsNullOrEmpty(name);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D30")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PhonePromptEventData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D31")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B00", Offset = "0x7B1500", VA = "0x1807B2B00")]
		[DebuggerNonUserCode]
		public PhonePromptEventData(PhonePromptEventData other)
		{
			//IL_0021: Expected O, but got I4
			Timestamp timestamp = other.startDate_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			startDate_ = (Timestamp)num;
			int num2 = (participationCount_ = other.participationCount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D32")]
		[Cpp2IlInjected.Address(RVA = "0x7B2240", Offset = "0x7B0C40", VA = "0x1807B2240", Slot = "10")]
		[DebuggerNonUserCode]
		public PhonePromptEventData Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0021: Expected O, but got I4
			PhonePromptEventData phonePromptEventData = new PhonePromptEventData();
			Timestamp timestamp = startDate_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			phonePromptEventData.startDate_ = (Timestamp)num;
			int num2 = (phonePromptEventData.participationCount_ = participationCount_);
			UnknownFieldSet unknownFieldSet = (phonePromptEventData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return phonePromptEventData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D37")]
		[Cpp2IlInjected.Address(RVA = "0x7B22F0", Offset = "0x7B0CF0", VA = "0x1807B22F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(startDate_, other);
				if (flag && participationCount_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D38")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PhonePromptEventData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.startDate_;
				if (object.Equals(startDate_, objB))
				{
					int num = other.participationCount_;
					if (participationCount_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D39")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = startDate_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				if (participationCount_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2990", Offset = "0x7B1390", VA = "0x1807B2990", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3B")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)startDate_ != 0)
			{
				Timestamp value = startDate_;
				output.WriteMessage(value);
			}
			if (participationCount_ != 0)
			{
				int value2 = participationCount_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3C")]
		[Cpp2IlInjected.Address(RVA = "0x7B2170", Offset = "0x7B0B70", VA = "0x1807B2170", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = startDate_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				}
				int num3 = participationCount_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3D")]
		[Cpp2IlInjected.Address(RVA = "0x7B25F0", Offset = "0x7B0FF0", VA = "0x1807B25F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PhonePromptEventData other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.startDate_ != 0)
			{
				Timestamp timestamp = startDate_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (startDate_ = new Timestamp());
				}
				Timestamp other2 = other.startDate_;
				timestamp.MergeFrom(other2);
			}
			int num = other.participationCount_;
			if (num != 0)
			{
				participationCount_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3E")]
		[Cpp2IlInjected.Address(RVA = "0x7B26D0", Offset = "0x7B10D0", VA = "0x1807B26D0", Slot = "5")]
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
				Timestamp timestamp = startDate_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (startDate_ = new Timestamp());
				}
				input.ReadMessage(timestamp);
			}
			if (num == 16)
			{
				int num2 = (participationCount_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004D3F")]
		[Cpp2IlInjected.Address(RVA = "0x7B23A0", Offset = "0x7B0DA0", VA = "0x1807B23A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = startDate_;
			}
			if (fieldNumber == 2)
			{
				int num = participationCount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D40")]
		[Cpp2IlInjected.Address(RVA = "0x7B28C0", Offset = "0x7B12C0", VA = "0x1807B28C0", Slot = "12")]
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
				startDate_ = (Timestamp)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				participationCount_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D41")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				participationCount_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D48")]
		[Cpp2IlInjected.Address(RVA = "0x7B27C0", Offset = "0x7B11C0", VA = "0x1807B27C0")]
		public TimeSpan RemainingTime(DateTime serverTime)
		{
			TimeSpan timeSpan = EndDate - serverTime;
			TimeSpan zero = TimeSpan.Zero;
			if (timeSpan > zero)
			{
				return timeSpan;
			}
			return TimeSpan.Zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D49")]
		[Cpp2IlInjected.Address(RVA = "0x7B2470", Offset = "0x7B0E70", VA = "0x1807B2470")]
		public bool IsEventEnded(DateTime serverTime)
		{
			TimeSpan timeSpan = EndDate - serverTime;
			TimeSpan zero = TimeSpan.Zero;
			if (!(timeSpan > zero))
			{
			}
			TimeSpan zero2 = TimeSpan.Zero;
			return ((object)timeSpan).Equals((object)zero2);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4A")]
		[Cpp2IlInjected.Address(RVA = "0x7B25B0", Offset = "0x7B0FB0", VA = "0x1807B25B0")]
		public bool IsParticipationCompleted()
		{
			PhonePromptData phonePromptData = data;
			if (phonePromptData != null)
			{
				int participationMaxCount_ = phonePromptData.participationMaxCount_;
				return participationCount_ >= participationMaxCount_;
			}
			return (long)participationCount_ >= (long)(IntPtr)phonePromptData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4B")]
		[Cpp2IlInjected.Address(RVA = "0x7B25D0", Offset = "0x7B0FD0", VA = "0x1807B25D0")]
		public bool JustParticipated()
		{
			int num = participationCount_;
			PhonePromptData phonePromptData = data;
			num = (participationCount_ = num + 1);
			if (phonePromptData != null)
			{
				int participationMaxCount_ = phonePromptData.participationMaxCount_;
				return num >= participationMaxCount_;
			}
			return (long)num >= (long)(IntPtr)phonePromptData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4C")]
		[Cpp2IlInjected.Address(RVA = "0x7B29F0", Offset = "0x7B13F0", VA = "0x1807B29F0")]
		static PhonePromptEventData()
		{
			Func<PhonePromptEventData> func = default(Func<PhonePromptEventData>);
			_parser = (MessageParser<PhonePromptEventData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
