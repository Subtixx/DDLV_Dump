using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B47")]
	public sealed class Amount : IMessage<Amount>, IMessage, IEquatable<Amount>, IDeepCloneable<Amount>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002BC6")]
		private static readonly MessageParser<Amount> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BC7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002BC8")]
		public const int QuantityFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BC9")]
		private int quantity_;

		[Cpp2IlInjected.Token(Token = "0x4002BCA")]
		public const int ChangedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002BCB")]
		private int changed_;

		[Cpp2IlInjected.Token(Token = "0x17001057")]
		[DebuggerNonUserCode]
		public static MessageParser<Amount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005F71")]
			[Cpp2IlInjected.Address(RVA = "0x18E9CA0", Offset = "0x18E86A0", VA = "0x1818E9CA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001058")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F72")]
			[Cpp2IlInjected.Address(RVA = "0x18E9BD0", Offset = "0x18E85D0", VA = "0x1818E9BD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001059")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F73")]
			[Cpp2IlInjected.Address(RVA = "0x18E9D00", Offset = "0x18E8700", VA = "0x1818E9D00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105A")]
		[DebuggerNonUserCode]
		public int Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x6005F77")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return quantity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F78")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				quantity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105B")]
		[DebuggerNonUserCode]
		public int Changed
		{
			[Cpp2IlInjected.Token(Token = "0x6005F79")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return changed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F7A")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				changed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F74")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Amount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005F75")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public Amount(Amount other)
		{
			int num = (quantity_ = other.quantity_);
			int num2 = (changed_ = other.changed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F76")]
		[Cpp2IlInjected.Address(RVA = "0x18E97C0", Offset = "0x18E81C0", VA = "0x1818E97C0", Slot = "10")]
		[DebuggerNonUserCode]
		public Amount Clone()
		{
			//Discarded unreachable code: IL_0037
			Amount amount = new Amount();
			int num = (amount.quantity_ = quantity_);
			int num2 = (amount.changed_ = changed_);
			UnknownFieldSet unknownFieldSet = (amount._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return amount;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7B")]
		[Cpp2IlInjected.Address(RVA = "0x18E9850", Offset = "0x18E8250", VA = "0x1818E9850", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)quantity_ == (IntPtr)typeof(Amount).TypeHandle && (IntPtr)changed_ == (IntPtr)typeof(Amount).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7C")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Amount other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.quantity_;
				if (quantity_ == num)
				{
					int num2 = other.changed_;
					if (changed_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7D")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (quantity_ != 0)
				{
				}
				if (changed_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7E")]
		[Cpp2IlInjected.Address(RVA = "0x18E9A60", Offset = "0x18E8460", VA = "0x1818E9A60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F7F")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (quantity_ != 0)
			{
				int value = quantity_;
				output.WriteInt32(value);
			}
			if (changed_ != 0)
			{
				int value2 = changed_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F80")]
		[Cpp2IlInjected.Address(RVA = "0x18E96F0", Offset = "0x18E80F0", VA = "0x1818E96F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = quantity_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = changed_;
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

		[Cpp2IlInjected.Token(Token = "0x6005F81")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Amount other)
		{
			if (other != null)
			{
				int num = other.quantity_;
				if (num != 0)
				{
					quantity_ = num;
				}
				int num2 = other.changed_;
				if (num2 != 0)
				{
					changed_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F82")]
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
					int num2 = (quantity_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (changed_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F83")]
		[Cpp2IlInjected.Address(RVA = "0x18E98E0", Offset = "0x18E82E0", VA = "0x1818E98E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = quantity_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F84")]
		[Cpp2IlInjected.Address(RVA = "0x18E99A0", Offset = "0x18E83A0", VA = "0x1818E99A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				quantity_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			changed_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F85")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				quantity_ = 0;
				break;
			case 2:
				changed_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F86")]
		[Cpp2IlInjected.Address(RVA = "0x18E9AC0", Offset = "0x18E84C0", VA = "0x1818E9AC0")]
		static Amount()
		{
			Func<Amount> func = default(Func<Amount>);
			_parser = (MessageParser<Amount>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
