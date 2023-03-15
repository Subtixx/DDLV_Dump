using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerDisplay("{DebugDisplay}")]
	public sealed class CurrencyCost : IDataValidation, IMessage<CurrencyCost>, IMessage, IEquatable<CurrencyCost>, IDeepCloneable<CurrencyCost>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly MessageParser<CurrencyCost> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x2D438B0", Offset = "0x2D422B0", VA = "0x182D438B0")]
			get
			{
				long num = Convert.ToInt64((uint)id_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2D43700", Offset = "0x2D42100", VA = "0x182D43700")]
			get
			{
				//IL_001f: Expected O, but got I8
				//IL_001f: Expected O, but got I4
				int num = amount_;
				long num2 = Convert.ToInt64((uint)id_);
				return $"{num}x {num2}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		[DebuggerNonUserCode]
		public static MessageParser<CurrencyCost> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2D43910", Offset = "0x2D42310", VA = "0x182D43910")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2D437E0", Offset = "0x2D421E0", VA = "0x182D437E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2D43970", Offset = "0x2D42370", VA = "0x182D43970", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D42FB0", Offset = "0x2D419B0", VA = "0x182D42FB0")]
		public CurrencyCost ApplyDiscount(int percent)
		{
			if (percent == 1 || percent != 1 || percent != 1)
			{
			}
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D43230", Offset = "0x2D41C30", VA = "0x182D43230", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0039
			int num = id_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				context.AddInvalidMemberError("Cannot be None", "Id");
			}
			if (amount_ < 0)
			{
				context.AddInvalidMemberError("Cannot be negative", "Amount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CurrencyCost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public CurrencyCost(CurrencyCost other)
		{
			int num = (id_ = other.id_);
			int num2 = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D431A0", Offset = "0x2D41BA0", VA = "0x182D431A0", Slot = "11")]
		[DebuggerNonUserCode]
		public CurrencyCost Clone()
		{
			//Discarded unreachable code: IL_0037
			CurrencyCost currencyCost = new CurrencyCost();
			int num = (currencyCost.id_ = id_);
			int num2 = (currencyCost.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (currencyCost._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return currencyCost;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D43380", Offset = "0x2D41D80", VA = "0x182D43380", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(CurrencyCost).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(CurrencyCost).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(CurrencyCost other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.id_;
				if (id_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (id_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2D43590", Offset = "0x2D41F90", VA = "0x182D43590", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (id_ != 0)
			{
				int value = id_;
				output.WriteInt32(value);
			}
			if (amount_ != 0)
			{
				int value2 = amount_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2D430D0", Offset = "0x2D41AD0", VA = "0x182D430D0", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = id_;
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

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CurrencyCost other)
		{
			if (other != null)
			{
				int num = other.id_;
				if (num != 0)
				{
					id_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (id_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2D43410", Offset = "0x2D41E10", VA = "0x182D43410", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = id_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2D434D0", Offset = "0x2D41ED0", VA = "0x182D434D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				id_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			amount_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				id_ = 0;
				break;
			case 2:
				amount_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2D435F0", Offset = "0x2D41FF0", VA = "0x182D435F0")]
		static CurrencyCost()
		{
			Func<CurrencyCost> func = default(Func<CurrencyCost>);
			_parser = (MessageParser<CurrencyCost>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
