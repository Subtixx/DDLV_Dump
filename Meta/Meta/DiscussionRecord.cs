using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000880")]
	public sealed class DiscussionRecord : IMessage<DiscussionRecord>, IMessage, IEquatable<DiscussionRecord>, IDeepCloneable<DiscussionRecord>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002227")]
		private static readonly MessageParser<DiscussionRecord> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002228")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002229")]
		public const int DiscussionItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400222A")]
		private int discussionItemID_;

		[Cpp2IlInjected.Token(Token = "0x400222B")]
		public const int TimestampFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400222C")]
		private Timestamp timestamp_;

		[Cpp2IlInjected.Token(Token = "0x17000BE4")]
		[DebuggerNonUserCode]
		public static MessageParser<DiscussionRecord> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60047BF")]
			[Cpp2IlInjected.Address(RVA = "0x1739920", Offset = "0x1738320", VA = "0x181739920")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047C0")]
			[Cpp2IlInjected.Address(RVA = "0x1739850", Offset = "0x1738250", VA = "0x181739850")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047C1")]
			[Cpp2IlInjected.Address(RVA = "0x1739980", Offset = "0x1738380", VA = "0x181739980", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE7")]
		[DebuggerNonUserCode]
		public int DiscussionItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60047C5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return discussionItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60047C6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				discussionItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE8")]
		[DebuggerNonUserCode]
		public Timestamp Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60047C7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return timestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x60047C8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				timestamp_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047C2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DiscussionRecord()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60047C3")]
		[Cpp2IlInjected.Address(RVA = "0x17397E0", Offset = "0x17381E0", VA = "0x1817397E0")]
		[DebuggerNonUserCode]
		public DiscussionRecord(DiscussionRecord other)
		{
			//IL_002f: Expected O, but got I4
			int num = (discussionItemID_ = other.discussionItemID_);
			Timestamp timestamp = other.timestamp_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num2 = 0;
			timestamp_ = (Timestamp)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047C4")]
		[Cpp2IlInjected.Address(RVA = "0x17391B0", Offset = "0x1737BB0", VA = "0x1817391B0", Slot = "10")]
		[DebuggerNonUserCode]
		public DiscussionRecord Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0031: Expected O, but got I4
			DiscussionRecord discussionRecord = new DiscussionRecord();
			int num = (discussionRecord.discussionItemID_ = discussionItemID_);
			Timestamp timestamp = timestamp_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num2 = 0;
			discussionRecord.timestamp_ = (Timestamp)num2;
			UnknownFieldSet unknownFieldSet = (discussionRecord._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return discussionRecord;
		}

		[Cpp2IlInjected.Token(Token = "0x60047C9")]
		[Cpp2IlInjected.Address(RVA = "0x1739250", Offset = "0x1737C50", VA = "0x181739250", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)discussionItemID_ == (IntPtr)typeof(DiscussionRecord).TypeHandle && object.Equals(timestamp_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047CA")]
		[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DiscussionRecord other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.discussionItemID_;
				if (discussionItemID_ == num)
				{
					Timestamp objB = other.timestamp_;
					if (object.Equals(timestamp_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047CB")]
		[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (discussionItemID_ != 0)
				{
				}
				Timestamp timestamp = timestamp_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60047CC")]
		[Cpp2IlInjected.Address(RVA = "0x1739670", Offset = "0x1738070", VA = "0x181739670", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60047CD")]
		[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if (discussionItemID_ != 0)
			{
				int value = discussionItemID_;
				output.WriteInt32(value);
			}
			if ((long)timestamp_ != 0)
			{
				Timestamp value2 = timestamp_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60047CE")]
		[Cpp2IlInjected.Address(RVA = "0x17390E0", Offset = "0x1737AE0", VA = "0x1817390E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = discussionItemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				Timestamp timestamp = timestamp_;
				if (timestamp != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(timestamp);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60047CF")]
		[Cpp2IlInjected.Address(RVA = "0x17393D0", Offset = "0x1737DD0", VA = "0x1817393D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DiscussionRecord other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			int num = other.discussionItemID_;
			if (num != 0)
			{
				discussionItemID_ = num;
			}
			if ((long)other.timestamp_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (timestamp_ == null)
				{
					Timestamp timestamp = (timestamp_ = new Timestamp());
					timestamp2 = timestamp_;
				}
				Timestamp other2 = other.timestamp_;
				timestamp2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60047D0")]
		[Cpp2IlInjected.Address(RVA = "0x17394B0", Offset = "0x1737EB0", VA = "0x1817394B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (discussionItemID_ = input.ReadInt32());
			}
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (timestamp_ == null)
				{
					Timestamp timestamp = (timestamp_ = new Timestamp());
					builder = timestamp_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60047D1")]
		[Cpp2IlInjected.Address(RVA = "0x1739300", Offset = "0x1737D00", VA = "0x181739300", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = discussionItemID_;
			}
			if (fieldNumber == 2)
			{
				Timestamp timestamp = timestamp_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047D2")]
		[Cpp2IlInjected.Address(RVA = "0x17395A0", Offset = "0x1737FA0", VA = "0x1817395A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				discussionItemID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				timestamp_ = (Timestamp)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047D3")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				discussionItemID_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047D4")]
		[Cpp2IlInjected.Address(RVA = "0x17396D0", Offset = "0x17380D0", VA = "0x1817396D0")]
		static DiscussionRecord()
		{
			Func<DiscussionRecord> func = default(Func<DiscussionRecord>);
			_parser = (MessageParser<DiscussionRecord>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
