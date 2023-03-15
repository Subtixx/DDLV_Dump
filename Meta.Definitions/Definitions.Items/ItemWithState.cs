using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000283")]
	public sealed class ItemWithState : IMessage<ItemWithState>, IMessage, IEquatable<ItemWithState>, IDeepCloneable<ItemWithState>, IMessageFieldAccessor, IItemWithState, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40009ED")]
		private static readonly MessageParser<ItemWithState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009EE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009EF")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009F0")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x40009F1")]
		public const int StateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009F2")]
		private ItemState state_;

		[Cpp2IlInjected.Token(Token = "0x1700054E")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemWithState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001804")]
			[Cpp2IlInjected.Address(RVA = "0x649E60", Offset = "0x648860", VA = "0x180649E60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001805")]
			[Cpp2IlInjected.Address(RVA = "0x649D30", Offset = "0x648730", VA = "0x180649D30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000550")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001806")]
			[Cpp2IlInjected.Address(RVA = "0x649F30", Offset = "0x648930", VA = "0x180649F30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000551")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600180A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600180B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000552")]
		[DebuggerNonUserCode]
		public ItemState State
		{
			[Cpp2IlInjected.Token(Token = "0x600180C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x600180D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "17")]
			set
			{
				state_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000553")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001819")]
			[Cpp2IlInjected.Address(RVA = "0x649E00", Offset = "0x648800", VA = "0x180649E00", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600181A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				itemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000554")]
		public ItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600181B")]
			[Cpp2IlInjected.Address(RVA = "0x649EC0", Offset = "0x6488C0", VA = "0x180649EC0")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				ItemType result = default(ItemType);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001807")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemWithState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001808")]
		[Cpp2IlInjected.Address(RVA = "0x649CC0", Offset = "0x6486C0", VA = "0x180649CC0")]
		[DebuggerNonUserCode]
		public ItemWithState(ItemWithState other)
		{
			//IL_002f: Expected O, but got I4
			int num = (itemID_ = other.itemID_);
			ItemState itemState = other.state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num2 = 0;
			state_ = (ItemState)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001809")]
		[Cpp2IlInjected.Address(RVA = "0x648A50", Offset = "0x647450", VA = "0x180648A50", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemWithState Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0031: Expected O, but got I4
			ItemWithState itemWithState = new ItemWithState();
			int num = (itemWithState.itemID_ = itemID_);
			ItemState itemState = state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num2 = 0;
			itemWithState.state_ = (ItemState)num2;
			UnknownFieldSet unknownFieldSet = (itemWithState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemWithState;
		}

		[Cpp2IlInjected.Token(Token = "0x600180E")]
		[Cpp2IlInjected.Address(RVA = "0x648BB0", Offset = "0x6475B0", VA = "0x180648BB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(ItemWithState).TypeHandle && object.Equals(state_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600180F")]
		[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemWithState other)
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
					ItemState objB = other.state_;
					if (object.Equals(state_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001810")]
		[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemID_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6001811")]
		[Cpp2IlInjected.Address(RVA = "0x649AC0", Offset = "0x6484C0", VA = "0x180649AC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001812")]
		[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if (itemID_ != 0)
			{
				int value = itemID_;
				output.WriteInt32(value);
			}
			if ((long)state_ != 0)
			{
				ItemState value2 = state_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001813")]
		[Cpp2IlInjected.Address(RVA = "0x648950", Offset = "0x647350", VA = "0x180648950", Slot = "7")]
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
				ItemState itemState = state_;
				if (itemState != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(itemState);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001814")]
		[Cpp2IlInjected.Address(RVA = "0x649820", Offset = "0x648220", VA = "0x180649820", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemWithState other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			int num = other.itemID_;
			if (num != 0)
			{
				itemID_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6001815")]
		[Cpp2IlInjected.Address(RVA = "0x649900", Offset = "0x648300", VA = "0x180649900", Slot = "5")]
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
				int num2 = (itemID_ = input.ReadInt32());
			}
			if (num == 18)
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

		[Cpp2IlInjected.Token(Token = "0x6001816")]
		[Cpp2IlInjected.Address(RVA = "0x6491E0", Offset = "0x647BE0", VA = "0x1806491E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = itemID_;
			}
			if (fieldNumber == 2)
			{
				ItemState itemState = state_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001817")]
		[Cpp2IlInjected.Address(RVA = "0x6499F0", Offset = "0x6483F0", VA = "0x1806499F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				itemID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				state_ = (ItemState)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001818")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				itemID_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600181C")]
		[Cpp2IlInjected.Address(RVA = "0x648E60", Offset = "0x647860", VA = "0x180648E60")]
		public static bool Equals(IItemWithState item1, IItemWithState item2)
		{
			bool flag = default(bool);
			bool result = default(bool);
			if ((object)typeof(Item).TypeHandle != null && flag)
			{
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600181D")]
		[Cpp2IlInjected.Address(RVA = "0x649050", Offset = "0x647A50", VA = "0x180649050")]
		public static bool Equals(IItemWithState item1, Item item2, ItemState state2)
		{
			bool flag = default(bool);
			bool result = default(bool);
			if ((object)typeof(Item).TypeHandle != null && flag)
			{
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600181E")]
		[Cpp2IlInjected.Address(RVA = "0x648CD0", Offset = "0x6476D0", VA = "0x180648CD0")]
		public static bool Equals(IItemWithState item1, Item item2, ItemState state2, bool ignoreItemState)
		{
			//Discarded unreachable code: IL_0016
			if ((object)typeof(Item).TypeHandle != null)
			{
				if (ignoreItemState)
				{
					return true;
				}
				bool flag = default(bool);
				if (flag)
				{
					goto IL_0014;
				}
			}
			int num = 0;
			goto IL_0014;
			IL_0014:
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600181F")]
		[Cpp2IlInjected.Address(RVA = "0x649730", Offset = "0x648130", VA = "0x180649730")]
		private static bool MealEquals(Item item1, ItemState state1, Item item2, ItemState state2)
		{
			int itemID = item1.ItemID;
			int num = 0;
			if (state1 != null && state1.stateCase_ == ItemState.StateOneofCase.MealData)
			{
				int num2 = default(int);
				itemID = num2;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001820")]
		[Cpp2IlInjected.Address(RVA = "0x648AF0", Offset = "0x6474F0", VA = "0x180648AF0", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			int num = itemID_;
		}

		[Cpp2IlInjected.Token(Token = "0x6001821")]
		[Cpp2IlInjected.Address(RVA = "0x649340", Offset = "0x647D40", VA = "0x180649340")]
		public static void ItemAndStateValidation(Item item, ItemState state, DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0077, IL_00d3
			//IL_00c8: Expected O, but got I4
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.ActivityItem)
			{
				ActivityItemType activityItemType = default(ActivityItemType);
				ItemInstance itemInstance2 = default(ItemInstance);
				switch (activityItemType)
				{
				case ActivityItemType.Meal:
					if (state == null || state.stateCase_ != ItemState.StateOneofCase.MealData)
					{
						context.AddError("A meal must have a valid MealData state");
					}
					return;
				case ActivityItemType.LootPresent:
					if (state != null)
					{
						while (state.stateCase_ == ItemState.StateOneofCase.LootPresentData)
						{
						}
					}
					context.AddError("A loot present must have a valid LootPresentData state");
					return;
				case ActivityItemType.Consummable:
				{
					bool flag = default(bool);
					if (flag)
					{
						context.AddError("Consummable with DefaultItem cannot have State (Editor error?)");
						return;
					}
					ItemInstance itemInstance = default(ItemInstance);
					Item item2 = itemInstance.Item;
					while (itemInstance2.amount_ >= 1)
					{
					}
					context.AddError("The ConsummableData state must have valid Item and Amount");
					return;
				}
				}
				string text = $"An activity item of type {itemInstance2} cannot have a state";
			}
			if (itemType == ItemType.MemoryShard)
			{
				if (state != null)
				{
					while (state.stateCase_ == ItemState.StateOneofCase.MemoryShardIndex)
					{
					}
				}
				context.AddError("A memory shard must have a valid MemoryShardIndex state");
			}
			else
			{
				while (state == null)
				{
				}
				while (state.stateCase_ == ItemState.StateOneofCase.None)
				{
				}
				ItemType itemType2 = default(ItemType);
				string error = $"An item of type {itemType2} cannot have a state";
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001822")]
		[Cpp2IlInjected.Address(RVA = "0x649BB0", Offset = "0x6485B0", VA = "0x180649BB0")]
		static ItemWithState()
		{
			Func<ItemWithState> func = default(Func<ItemWithState>);
			_parser = (MessageParser<ItemWithState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
