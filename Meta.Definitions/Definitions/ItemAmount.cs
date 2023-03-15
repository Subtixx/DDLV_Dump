using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[DebuggerDisplay("{DebugDisplay}")]
	public sealed class ItemAmount : IMessage<ItemAmount>, IMessage, IEquatable<ItemAmount>, IDeepCloneable<ItemAmount>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public const int Infinite = -1;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly MessageParser<ItemAmount> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x27C2110", Offset = "0x27C0B10", VA = "0x1827C2110")]
			get
			{
				int num = id_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x27C1F70", Offset = "0x27C0970", VA = "0x1827C1F70")]
			get
			{
				int num = amount_;
				int num2 = id_;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x27C2160", Offset = "0x27C0B60", VA = "0x1827C2160")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x27C2040", Offset = "0x27C0A40", VA = "0x1827C2040")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x27C21C0", Offset = "0x27C0BC0", VA = "0x1827C21C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemAmount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public ItemAmount(ItemAmount other)
		{
			int num = (id_ = other.id_);
			int num2 = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x27C1B60", Offset = "0x27C0560", VA = "0x1827C1B60", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemAmount Clone()
		{
			//Discarded unreachable code: IL_0037
			ItemAmount itemAmount = new ItemAmount();
			int num = (itemAmount.id_ = id_);
			int num2 = (itemAmount.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (itemAmount._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x27C1BF0", Offset = "0x27C05F0", VA = "0x1827C1BF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(ItemAmount).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(ItemAmount).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemAmount other)
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

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x27C1E00", Offset = "0x27C0800", VA = "0x1827C1E00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27C1A90", Offset = "0x27C0490", VA = "0x1827C1A90", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemAmount other)
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

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
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
					int num2 = (id_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x27C1C80", Offset = "0x27C0680", VA = "0x1827C1C80", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x27C1D40", Offset = "0x27C0740", VA = "0x1827C1D40", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x27C1E60", Offset = "0x27C0860", VA = "0x1827C1E60")]
		static ItemAmount()
		{
			Func<ItemAmount> func = default(Func<ItemAmount>);
			_parser = (MessageParser<ItemAmount>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
