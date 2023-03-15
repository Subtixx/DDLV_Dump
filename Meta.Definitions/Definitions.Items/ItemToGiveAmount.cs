using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200050F")]
	public sealed class ItemToGiveAmount : IMessage<ItemToGiveAmount>, IMessage, IEquatable<ItemToGiveAmount>, IDeepCloneable<ItemToGiveAmount>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001B0B")]
		private static readonly MessageParser<ItemToGiveAmount> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001B0C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001B0D")]
		public const int ItemToGiveFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001B0E")]
		private int itemToGive_;

		[Cpp2IlInjected.Token(Token = "0x4001B0F")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001B10")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x17001019")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemToGiveAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003EB0")]
			[Cpp2IlInjected.Address(RVA = "0x646260", Offset = "0x644C60", VA = "0x180646260")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003EB1")]
			[Cpp2IlInjected.Address(RVA = "0x646190", Offset = "0x644B90", VA = "0x180646190")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003EB2")]
			[Cpp2IlInjected.Address(RVA = "0x6462C0", Offset = "0x644CC0", VA = "0x1806462C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101C")]
		[DebuggerNonUserCode]
		public int ItemToGive
		{
			[Cpp2IlInjected.Token(Token = "0x6003EB6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemToGive_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003EB7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemToGive_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101D")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6003EB8")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003EB9")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EB3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemToGiveAmount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003EB4")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public ItemToGiveAmount(ItemToGiveAmount other)
		{
			int num = (itemToGive_ = other.itemToGive_);
			int num2 = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003EB5")]
		[Cpp2IlInjected.Address(RVA = "0x645AD0", Offset = "0x6444D0", VA = "0x180645AD0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemToGiveAmount Clone()
		{
			//Discarded unreachable code: IL_0037
			ItemToGiveAmount itemToGiveAmount = new ItemToGiveAmount();
			int num = (itemToGiveAmount.itemToGive_ = itemToGive_);
			int num2 = (itemToGiveAmount.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (itemToGiveAmount._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemToGiveAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x6003EBA")]
		[Cpp2IlInjected.Address(RVA = "0x645B60", Offset = "0x644560", VA = "0x180645B60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemToGive_ == (IntPtr)typeof(ItemToGiveAmount).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(ItemToGiveAmount).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003EBB")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemToGiveAmount other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.itemToGive_;
				if (itemToGive_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6003EBC")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemToGive_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6003EBD")]
		[Cpp2IlInjected.Address(RVA = "0x645F20", Offset = "0x644920", VA = "0x180645F20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003EBE")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (itemToGive_ != 0)
			{
				int value = itemToGive_;
				output.WriteInt32(value);
			}
			if (amount_ != 0)
			{
				int value2 = amount_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003EBF")]
		[Cpp2IlInjected.Address(RVA = "0x6459E0", Offset = "0x6443E0", VA = "0x1806459E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = itemToGive_;
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

		[Cpp2IlInjected.Token(Token = "0x6003EC0")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemToGiveAmount other)
		{
			if (other != null)
			{
				int num = other.itemToGive_;
				if (num != 0)
				{
					itemToGive_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6003EC1")]
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
					int num2 = (itemToGive_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EC2")]
		[Cpp2IlInjected.Address(RVA = "0x645C20", Offset = "0x644620", VA = "0x180645C20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = itemToGive_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003EC3")]
		[Cpp2IlInjected.Address(RVA = "0x645E60", Offset = "0x644860", VA = "0x180645E60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				itemToGive_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			amount_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003EC4")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				itemToGive_ = 0;
				break;
			case 2:
				amount_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EC5")]
		[Cpp2IlInjected.Address(RVA = "0x646010", Offset = "0x644A10", VA = "0x180646010")]
		static ItemToGiveAmount()
		{
			Func<ItemToGiveAmount> func = default(Func<ItemToGiveAmount>);
			_parser = (MessageParser<ItemToGiveAmount>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
