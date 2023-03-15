using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004BC")]
	public sealed class BackpackItem : IMessage<BackpackItem>, IMessage, IEquatable<BackpackItem>, IDeepCloneable<BackpackItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000EBE")]
		private static readonly MessageParser<BackpackItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000EBF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000EC0")]
		public const int PositionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000EC1")]
		private int position_;

		[Cpp2IlInjected.Token(Token = "0x4000EC2")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000EC3")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x17000875")]
		[DebuggerNonUserCode]
		public static MessageParser<BackpackItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002E08")]
			[Cpp2IlInjected.Address(RVA = "0x1AB8880", Offset = "0x1AB7280", VA = "0x181AB8880")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000876")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E09")]
			[Cpp2IlInjected.Address(RVA = "0x1AB87B0", Offset = "0x1AB71B0", VA = "0x181AB87B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000877")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0A")]
			[Cpp2IlInjected.Address(RVA = "0x1AB88E0", Offset = "0x1AB72E0", VA = "0x181AB88E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000878")]
		[DebuggerNonUserCode]
		public int Position
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return position_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E0F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				position_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000879")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6002E10")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E11")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BackpackItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0C")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public BackpackItem(BackpackItem other)
		{
			int num = (position_ = other.position_);
			int num2 = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0D")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8360", Offset = "0x1AB6D60", VA = "0x181AB8360", Slot = "10")]
		[DebuggerNonUserCode]
		public BackpackItem Clone()
		{
			//Discarded unreachable code: IL_0037
			BackpackItem backpackItem = new BackpackItem();
			int num = (backpackItem.position_ = position_);
			int num2 = (backpackItem.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (backpackItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return backpackItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E12")]
		[Cpp2IlInjected.Address(RVA = "0x1AB83F0", Offset = "0x1AB6DF0", VA = "0x181AB83F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)position_ == (IntPtr)typeof(BackpackItem).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(BackpackItem).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E13")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BackpackItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.position_;
				if (position_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6002E14")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (position_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6002E15")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8600", Offset = "0x1AB7000", VA = "0x181AB8600", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E16")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (position_ != 0)
			{
				int value = position_;
				output.WriteInt32(value);
			}
			if (amount_ != 0)
			{
				int value2 = amount_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E17")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8290", Offset = "0x1AB6C90", VA = "0x181AB8290", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = position_;
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

		[Cpp2IlInjected.Token(Token = "0x6002E18")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BackpackItem other)
		{
			if (other != null)
			{
				int num = other.position_;
				if (num != 0)
				{
					position_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6002E19")]
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
					int num2 = (position_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1A")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8480", Offset = "0x1AB6E80", VA = "0x181AB8480", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = position_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1B")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8540", Offset = "0x1AB6F40", VA = "0x181AB8540", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				position_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			amount_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1C")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				position_ = 0;
				break;
			case 2:
				amount_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1D")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8770", Offset = "0x1AB7170", VA = "0x181AB8770")]
		public BackpackItem(int position, int amount)
		{
			position_ = position;
			amount_ = amount;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1E")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8660", Offset = "0x1AB7060", VA = "0x181AB8660")]
		static BackpackItem()
		{
			Func<BackpackItem> func = default(Func<BackpackItem>);
			_parser = (MessageParser<BackpackItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
