using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Sw
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class CurrencyAmount : IMessage<CurrencyAmount>, IMessage, IEquatable<CurrencyAmount>, IDeepCloneable<CurrencyAmount>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly MessageParser<CurrencyAmount> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public const int CurrencyFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private CurrencyType currency_;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[DebuggerNonUserCode]
		public static MessageParser<CurrencyAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2D42E40", Offset = "0x2D41840", VA = "0x182D42E40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2D42D70", Offset = "0x2D41770", VA = "0x182D42D70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2D42EA0", Offset = "0x2D418A0", VA = "0x182D42EA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		[DebuggerNonUserCode]
		public CurrencyType Currency
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return currency_;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				currency_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CurrencyAmount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public CurrencyAmount(CurrencyAmount other)
		{
			CurrencyType currencyType = (currency_ = other.currency_);
			int num = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2D42920", Offset = "0x2D41320", VA = "0x182D42920", Slot = "10")]
		[DebuggerNonUserCode]
		public CurrencyAmount Clone()
		{
			//Discarded unreachable code: IL_0037
			CurrencyAmount currencyAmount = new CurrencyAmount();
			CurrencyType currencyType = (currencyAmount.currency_ = currency_);
			int num = (currencyAmount.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (currencyAmount._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return currencyAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2D429B0", Offset = "0x2D413B0", VA = "0x182D429B0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)currency_ == (IntPtr)typeof(CurrencyAmount).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(CurrencyAmount).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CurrencyAmount other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				CurrencyType currencyType = other.currency_;
				if (currency_ == currencyType)
				{
					int num = other.amount_;
					if (amount_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (currency_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2D42C00", Offset = "0x2D41600", VA = "0x182D42C00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (currency_ != 0)
			{
			}
			if (amount_ != 0)
			{
				int value = amount_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2D42850", Offset = "0x2D41250", VA = "0x182D42850", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				CurrencyType currencyType = currency_;
				num = 0;
				if (currencyType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)currencyType);
				}
				int num3 = amount_;
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

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CurrencyAmount other)
		{
			if (other != null)
			{
				CurrencyType currencyType = other.currency_;
				if (currencyType != 0)
				{
					currency_ = currencyType;
				}
				int num = other.amount_;
				if (num != 0)
				{
					amount_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
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
					int num2 = (int)(currency_ = (CurrencyType)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2D42A40", Offset = "0x2D41440", VA = "0x182D42A40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				CurrencyType currencyType = currency_;
			}
			int num = amount_;
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2D42B30", Offset = "0x2D41530", VA = "0x182D42B30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				currency_ = (CurrencyType)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			amount_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				currency_ = CurrencyType.Energy;
				break;
			case 2:
				amount_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2D42C60", Offset = "0x2D41660", VA = "0x182D42C60")]
		static CurrencyAmount()
		{
			Func<CurrencyAmount> func = default(Func<CurrencyAmount>);
			_parser = (MessageParser<CurrencyAmount>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
