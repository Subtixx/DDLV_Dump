using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000553")]
	public sealed class FtueReward : IMessage<FtueReward>, IMessage, IEquatable<FtueReward>, IDeepCloneable<FtueReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001CF1")]
		private static readonly MessageParser<FtueReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CF2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001CF3")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CF4")]
		private int item_;

		[Cpp2IlInjected.Token(Token = "0x4001CF5")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001CF6")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x1700112D")]
		[DebuggerNonUserCode]
		public static MessageParser<FtueReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600427D")]
			[Cpp2IlInjected.Address(RVA = "0x3440310", Offset = "0x343ED10", VA = "0x183440310")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700112E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600427E")]
			[Cpp2IlInjected.Address(RVA = "0x3440240", Offset = "0x343EC40", VA = "0x183440240")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700112F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600427F")]
			[Cpp2IlInjected.Address(RVA = "0x3440370", Offset = "0x343ED70", VA = "0x183440370", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001130")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004283")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004284")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001131")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6004285")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004286")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004280")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FtueReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004281")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public FtueReward(FtueReward other)
		{
			int num = (item_ = other.item_);
			int num2 = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004282")]
		[Cpp2IlInjected.Address(RVA = "0x343FE30", Offset = "0x343E830", VA = "0x18343FE30", Slot = "10")]
		[DebuggerNonUserCode]
		public FtueReward Clone()
		{
			//Discarded unreachable code: IL_0037
			FtueReward ftueReward = new FtueReward();
			int num = (ftueReward.item_ = item_);
			int num2 = (ftueReward.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (ftueReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return ftueReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6004287")]
		[Cpp2IlInjected.Address(RVA = "0x343FEC0", Offset = "0x343E8C0", VA = "0x18343FEC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)item_ == (IntPtr)typeof(FtueReward).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(FtueReward).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004288")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FtueReward other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.item_;
				if (item_ == num)
				{
					int num2 = other.amount_;
					if (amount_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004289")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (item_ != 0)
				{
				}
				if (amount_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600428A")]
		[Cpp2IlInjected.Address(RVA = "0x34400D0", Offset = "0x343EAD0", VA = "0x1834400D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600428B")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (item_ != 0)
			{
				int value = item_;
				output.WriteInt32(value);
			}
			if (amount_ != 0)
			{
				int value2 = amount_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600428C")]
		[Cpp2IlInjected.Address(RVA = "0x343FD60", Offset = "0x343E760", VA = "0x18343FD60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = item_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = amount_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600428D")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FtueReward other)
		{
			if (other != null)
			{
				int num = other.item_;
				if (num != 0)
				{
					item_ = num;
				}
				int num2 = other.amount_;
				if (num2 != 0)
				{
					amount_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600428E")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (item_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600428F")]
		[Cpp2IlInjected.Address(RVA = "0x343FF50", Offset = "0x343E950", VA = "0x18343FF50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = item_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004290")]
		[Cpp2IlInjected.Address(RVA = "0x3440010", Offset = "0x343EA10", VA = "0x183440010", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				item_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			amount_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004291")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				item_ = 0;
				break;
			case 2:
				amount_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004292")]
		[Cpp2IlInjected.Address(RVA = "0x3440130", Offset = "0x343EB30", VA = "0x183440130")]
		static FtueReward()
		{
			Func<FtueReward> func = default(Func<FtueReward>);
			_parser = (MessageParser<FtueReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
