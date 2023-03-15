using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200027F")]
	public sealed class ItemInstance : IMessage<ItemInstance>, IMessage, IEquatable<ItemInstance>, IDeepCloneable<ItemInstance>, IMessageFieldAccessor, IItemInstance, IItemWithState
	{
		[Cpp2IlInjected.Token(Token = "0x40009DE")]
		private static readonly MessageParser<ItemInstance> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009DF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009E0")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009E1")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x40009E2")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40009E3")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x40009E4")]
		public const int StateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009E5")]
		private ItemState state_;

		[Cpp2IlInjected.Token(Token = "0x17000542")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemInstance> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60017CE")]
			[Cpp2IlInjected.Address(RVA = "0x25DEDF0", Offset = "0x25DD7F0", VA = "0x1825DEDF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000543")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60017CF")]
			[Cpp2IlInjected.Address(RVA = "0x25DEC50", Offset = "0x25DD650", VA = "0x1825DEC50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000544")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60017D0")]
			[Cpp2IlInjected.Address(RVA = "0x25DEE50", Offset = "0x25DD850", VA = "0x1825DEE50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000545")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60017D4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60017D5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000546")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x60017D6")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "14")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60017D7")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000547")]
		[DebuggerNonUserCode]
		public ItemState State
		{
			[Cpp2IlInjected.Token(Token = "0x60017D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "17")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x60017D9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "18")]
			set
			{
				state_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000548")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60017E5")]
			[Cpp2IlInjected.Address(RVA = "0x25DED90", Offset = "0x25DD790", VA = "0x1825DED90", Slot = "16")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x60017E6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				itemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000549")]
		public ItemAmount ItemAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60017E7")]
			[Cpp2IlInjected.Address(RVA = "0x25DED20", Offset = "0x25DD720", VA = "0x1825DED20")]
			get
			{
				//Discarded unreachable code: IL_0024
				ItemAmount itemAmount = new ItemAmount();
				int num = (itemAmount.id_ = itemID_);
				int num2 = (itemAmount.amount_ = amount_);
				return itemAmount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017D1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemInstance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60017D2")]
		[Cpp2IlInjected.Address(RVA = "0x1F17030", Offset = "0x1F15A30", VA = "0x181F17030")]
		[DebuggerNonUserCode]
		public ItemInstance(ItemInstance other)
		{
			//IL_003f: Expected O, but got I4
			int num = (itemID_ = other.itemID_);
			int num2 = (amount_ = other.amount_);
			ItemState itemState = other.state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num3 = 0;
			state_ = (ItemState)num3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017D3")]
		[Cpp2IlInjected.Address(RVA = "0x25DE4C0", Offset = "0x25DCEC0", VA = "0x1825DE4C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemInstance Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0040: Expected O, but got I4
			ItemInstance itemInstance = new ItemInstance();
			int num = (itemInstance.itemID_ = itemID_);
			int num2 = (itemInstance.amount_ = amount_);
			ItemState itemState = state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num3 = 0;
			itemInstance.state_ = (ItemState)num3;
			UnknownFieldSet unknownFieldSet = (itemInstance._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemInstance;
		}

		[Cpp2IlInjected.Token(Token = "0x60017DA")]
		[Cpp2IlInjected.Address(RVA = "0x25DE640", Offset = "0x25DD040", VA = "0x1825DE640", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(ItemInstance).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(ItemInstance).TypeHandle && object.Equals(state_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017DB")]
		[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemInstance other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.itemID_;
				if (itemID_ == num)
				{
					int num2 = other.amount_;
					if (amount_ == num2)
					{
						ItemState objB = other.state_;
						if (object.Equals(state_, objB))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017DC")]
		[Cpp2IlInjected.Address(RVA = "0x18C2EE0", Offset = "0x18C18E0", VA = "0x1818C2EE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemID_ != 0)
				{
				}
				if (amount_ != 0)
				{
				}
				ItemState itemState = state_;
				if (itemState != null)
				{
					int hashCode = itemState.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60017DD")]
		[Cpp2IlInjected.Address(RVA = "0x25DEAE0", Offset = "0x25DD4E0", VA = "0x1825DEAE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60017DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F16E70", Offset = "0x1F15870", VA = "0x181F16E70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005a
			if (itemID_ != 0)
			{
				int value = itemID_;
				output.WriteInt32(value);
			}
			if (amount_ != 0)
			{
				int value2 = amount_;
				output.WriteInt32(value2);
			}
			if ((long)state_ != 0)
			{
				ItemState value3 = state_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60017DF")]
		[Cpp2IlInjected.Address(RVA = "0x25DE3C0", Offset = "0x25DCDC0", VA = "0x1825DE3C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = itemID_;
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
				ItemState itemState = state_;
				if (itemState != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(itemState);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60017E0")]
		[Cpp2IlInjected.Address(RVA = "0x25DE7D0", Offset = "0x25DD1D0", VA = "0x1825DE7D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemInstance other)
		{
			//Discarded unreachable code: IL_0083
			if (other == null)
			{
				return;
			}
			int num = other.itemID_;
			if (num != 0)
			{
				itemID_ = num;
			}
			int num2 = other.amount_;
			if (num2 != 0)
			{
				amount_ = num2;
			}
			if ((long)other.state_ != 0)
			{
				ItemState itemState2 = default(ItemState);
				if (state_ == null)
				{
					ItemState itemState = (state_ = new ItemState());
					itemState2 = state_;
				}
				ItemState other2 = other.state_;
				itemState2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60017E1")]
		[Cpp2IlInjected.Address(RVA = "0x25DE8B0", Offset = "0x25DD2B0", VA = "0x1825DE8B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0075
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (itemID_ = input.ReadInt32());
			}
			int num3 = default(int);
			if (num == 16)
			{
				num3 = (amount_ = input.ReadInt32());
			}
			if (num3 == 26)
			{
				ItemState builder = default(ItemState);
				if (state_ == null)
				{
					ItemState itemState = (state_ = new ItemState());
					builder = state_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60017E2")]
		[Cpp2IlInjected.Address(RVA = "0x25DE700", Offset = "0x25DD100", VA = "0x1825DE700", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_001e;
				}
				ItemState itemState = state_;
			}
			int num2 = itemID_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017E3")]
		[Cpp2IlInjected.Address(RVA = "0x25DE9C0", Offset = "0x25DD3C0", VA = "0x1825DE9C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0032
			//IL_0021: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_0031: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						state_ = (ItemState)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
				{
					object obj = default(object);
					amount_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj2 = default(object);
				itemID_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017E4")]
		[Cpp2IlInjected.Address(RVA = "0x1F16580", Offset = "0x1F14F80", VA = "0x181F16580", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017E8")]
		[Cpp2IlInjected.Address(RVA = "0x25DE570", Offset = "0x25DCF70", VA = "0x1825DE570")]
		public static bool Equals(IItemInstance item1, IItemInstance item2)
		{
			//Discarded unreachable code: IL_0011
			if ((object)typeof(ItemWithState).TypeHandle != null)
			{
				int num = 0;
			}
			return ItemWithState.Equals(item1, item2);
		}

		[Cpp2IlInjected.Token(Token = "0x60017E9")]
		[Cpp2IlInjected.Address(RVA = "0x25DEB40", Offset = "0x25DD540", VA = "0x1825DEB40")]
		static ItemInstance()
		{
			Func<ItemInstance> func = default(Func<ItemInstance>);
			_parser = (MessageParser<ItemInstance>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
