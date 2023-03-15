using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class StoreSaleType : IMessage<StoreSaleType>, IMessage, IEquatable<StoreSaleType>, IDeepCloneable<StoreSaleType>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		public enum SaleTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			PriceDiscountValue,
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			PriceDiscountPct
		}

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private static readonly MessageParser<StoreSaleType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public const int PriceDiscountValueFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public const int PriceDiscountPctFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private object saleType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private SaleTypeOneofCase saleTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreSaleType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0x2551DF0", Offset = "0x25507F0", VA = "0x182551DF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x2551D20", Offset = "0x2550720", VA = "0x182551D20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x2551F30", Offset = "0x2550930", VA = "0x182551F30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		[DebuggerNonUserCode]
		public int PriceDiscountValue
		{
			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x2551EC0", Offset = "0x25508C0", VA = "0x182551EC0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (saleTypeCase_ == SaleTypeOneofCase.PriceDiscountValue)
				{
					object obj = saleType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x25520B0", Offset = "0x2550AB0", VA = "0x1825520B0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				saleType_ = typeof(int).TypeHandle;
				saleTypeCase_ = SaleTypeOneofCase.PriceDiscountValue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		[DebuggerNonUserCode]
		public int PriceDiscountPct
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x2551E50", Offset = "0x2550850", VA = "0x182551E50")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (saleTypeCase_ == SaleTypeOneofCase.PriceDiscountPct)
				{
					object obj = saleType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x2552040", Offset = "0x2550A40", VA = "0x182552040")]
			set
			{
				//IL_0014: Expected I4, but got I8
				saleType_ = typeof(int).TypeHandle;
				saleTypeCase_ = SaleTypeOneofCase.PriceDiscountPct;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		[DebuggerNonUserCode]
		public SaleTypeOneofCase SaleTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return saleTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StoreSaleType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2551C50", Offset = "0x2550650", VA = "0x182551C50")]
		[DebuggerNonUserCode]
		public StoreSaleType(StoreSaleType other)
		{
			//IL_002c: Expected I4, but got I8
			SaleTypeOneofCase saleTypeOneofCase = other.saleTypeCase_;
			if (saleTypeOneofCase == SaleTypeOneofCase.PriceDiscountValue)
			{
				int priceDiscountValue = other.PriceDiscountValue;
				saleType_ = typeof(int).TypeHandle;
				saleTypeCase_ = SaleTypeOneofCase.PriceDiscountValue;
			}
			if (saleTypeOneofCase == SaleTypeOneofCase.PriceDiscountPct)
			{
				int num = (PriceDiscountPct = other.PriceDiscountPct);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x25512C0", Offset = "0x254FCC0", VA = "0x1825512C0", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreSaleType Clone()
		{
			//Discarded unreachable code: IL_0055
			//IL_002c: Expected I4, but got I8
			StoreSaleType storeSaleType = new StoreSaleType();
			SaleTypeOneofCase saleTypeOneofCase = saleTypeCase_;
			if (saleTypeOneofCase == SaleTypeOneofCase.PriceDiscountValue)
			{
				int priceDiscountValue = PriceDiscountValue;
				storeSaleType.saleType_ = typeof(int).TypeHandle;
				storeSaleType.saleTypeCase_ = SaleTypeOneofCase.PriceDiscountValue;
			}
			if (saleTypeOneofCase == SaleTypeOneofCase.PriceDiscountPct)
			{
				int num = (storeSaleType.PriceDiscountPct = PriceDiscountPct);
			}
			UnknownFieldSet unknownFieldSet = (storeSaleType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeSaleType;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearSaleType()
		{
			//IL_0010: Expected O, but got I4
			saleType_ = (saleTypeCase_ = SaleTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x25513C0", Offset = "0x254FDC0", VA = "0x1825513C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_003d: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int priceDiscountValue = PriceDiscountValue;
				int num = default(int);
				if (priceDiscountValue == num)
				{
					int priceDiscountPct = PriceDiscountPct;
					int num2 = 0;
					priceDiscountValue = priceDiscountPct;
					int num3 = default(int);
					if (priceDiscountValue == num3 && saleTypeCase_ == (SaleTypeOneofCase)num3)
					{
						return object.Equals(_unknownFields, num2);
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x25514A0", Offset = "0x254FEA0", VA = "0x1825514A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreSaleType other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int priceDiscountValue = PriceDiscountValue;
				int priceDiscountValue2 = other.PriceDiscountValue;
				if (priceDiscountValue == priceDiscountValue2)
				{
					priceDiscountValue = PriceDiscountPct;
					int priceDiscountPct = other.PriceDiscountPct;
					if (priceDiscountValue == priceDiscountPct)
					{
						SaleTypeOneofCase saleTypeOneofCase = other.saleTypeCase_;
						if (saleTypeCase_ == saleTypeOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2551610", Offset = "0x2550010", VA = "0x182551610", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0049
			int num = 0;
			if (saleTypeCase_ == SaleTypeOneofCase.PriceDiscountValue)
			{
				if (saleTypeCase_ != SaleTypeOneofCase.PriceDiscountValue)
				{
				}
				object obj = saleType_;
			}
			if (saleTypeCase_ == SaleTypeOneofCase.PriceDiscountPct && saleTypeCase_ == SaleTypeOneofCase.PriceDiscountPct)
			{
				object obj2 = saleType_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2551A40", Offset = "0x2550440", VA = "0x182551A40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2551AA0", Offset = "0x25504A0", VA = "0x182551AA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003e
			SaleTypeOneofCase saleTypeOneofCase = saleTypeCase_;
			if (saleTypeOneofCase == SaleTypeOneofCase.PriceDiscountValue)
			{
				int priceDiscountValue = PriceDiscountValue;
				output.WriteInt32(priceDiscountValue);
			}
			if (saleTypeOneofCase == SaleTypeOneofCase.PriceDiscountPct)
			{
				int priceDiscountPct = PriceDiscountPct;
				output.WriteInt32(priceDiscountPct);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2551020", Offset = "0x254FA20", VA = "0x182551020", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0061
			int num = 0;
			if (saleTypeCase_ == SaleTypeOneofCase.PriceDiscountValue)
			{
				if (saleTypeCase_ == SaleTypeOneofCase.PriceDiscountValue)
				{
					object obj = saleType_;
				}
				int num2 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (saleTypeCase_ == SaleTypeOneofCase.PriceDiscountPct)
			{
				if (saleTypeCase_ == SaleTypeOneofCase.PriceDiscountPct)
				{
					object obj2 = saleType_;
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x25517F0", Offset = "0x25501F0", VA = "0x1825517F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreSaleType other)
		{
			if (other != null)
			{
				SaleTypeOneofCase saleTypeOneofCase = other.saleTypeCase_;
				if (saleTypeOneofCase == SaleTypeOneofCase.PriceDiscountValue)
				{
					int num = (PriceDiscountValue = other.PriceDiscountValue);
				}
				if (saleTypeOneofCase == SaleTypeOneofCase.PriceDiscountPct)
				{
					int num2 = (PriceDiscountPct = other.PriceDiscountPct);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2551870", Offset = "0x2550270", VA = "0x182551870", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num3 = (PriceDiscountValue = input.ReadInt32());
				}
				if (num == 16)
				{
					int num5 = (PriceDiscountPct = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2551540", Offset = "0x254FF40", VA = "0x182551540", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int priceDiscountValue = PriceDiscountValue;
			}
			if (fieldNumber == 2)
			{
				int priceDiscountPct = PriceDiscountPct;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2551920", Offset = "0x2550320", VA = "0x182551920", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001e
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				saleType_ = typeof(int).TypeHandle;
				saleTypeCase_ = SaleTypeOneofCase.PriceDiscountValue;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2551190", Offset = "0x254FB90", VA = "0x182551190", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_0020: Expected O, but got I4
			//IL_0029: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				int num2 = default(int);
				saleType_ = num2;
				saleTypeCase_ = SaleTypeOneofCase.PriceDiscountValue;
				break;
			}
			case 2:
			{
				int num = default(int);
				saleType_ = num;
				saleTypeCase_ = SaleTypeOneofCase.PriceDiscountPct;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2551740", Offset = "0x2550140", VA = "0x182551740", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "SaleType"))
			{
				SaleTypeOneofCase saleTypeOneofCase = saleTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2551250", Offset = "0x254FC50", VA = "0x182551250", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "SaleType"))
			{
				saleType_ = (saleTypeCase_ = SaleTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2551B40", Offset = "0x2550540", VA = "0x182551B40")]
		static StoreSaleType()
		{
			Func<StoreSaleType> func = default(Func<StoreSaleType>);
			_parser = (MessageParser<StoreSaleType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
