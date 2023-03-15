using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000804")]
	public sealed class ConditionInventory : ICondition, IDataValidation, IMessage<ConditionInventory>, IMessage, IEquatable<ConditionInventory>, IDeepCloneable<ConditionInventory>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027F4")]
		private static readonly MessageParser<ConditionInventory> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027F5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027F6")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027F7")]
		private int item_;

		[Cpp2IlInjected.Token(Token = "0x40027F8")]
		public const int OperatorFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027F9")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x40027FA")]
		public const int AmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027FB")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x17001685")]
		private bool IsCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005909")]
			[Cpp2IlInjected.Address(RVA = "0x20759E0", Offset = "0x20743E0", VA = "0x1820759E0")]
			get
			{
				long num = Convert.ToInt64((uint)item_);
				ItemType itemType = default(ItemType);
				return itemType == ItemType.Currency;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001686")]
		private bool IsUpgradeItem
		{
			[Cpp2IlInjected.Token(Token = "0x600590A")]
			[Cpp2IlInjected.Address(RVA = "0x2075A50", Offset = "0x2074450", VA = "0x182075A50")]
			get
			{
				long num = Convert.ToInt64((uint)item_);
				ItemType itemType = default(ItemType);
				return itemType == ItemType.Upgrade;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001687")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600590D")]
			[Cpp2IlInjected.Address(RVA = "0x2075900", Offset = "0x2074300", VA = "0x182075900", Slot = "5")]
			get
			{
				//IL_002c: Expected O, but got I8
				long num = Convert.ToInt64((uint)item_);
				string text = Operations.ToString(operator_);
				int num2 = amount_;
				return $"Inventory {num} {text} {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001688")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600590E")]
			[Cpp2IlInjected.Address(RVA = "0x2075AC0", Offset = "0x20744C0", VA = "0x182075AC0", Slot = "6")]
			get
			{
				long num = Convert.ToInt64((uint)item_);
				ItemType itemType = default(ItemType);
				int num2 = (int)itemType;
				if (itemType == ItemType.Currency)
				{
				}
				return ConditionListener.ToolUpgraded;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001689")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionInventory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005911")]
			[Cpp2IlInjected.Address(RVA = "0x2075B50", Offset = "0x2074550", VA = "0x182075B50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005912")]
			[Cpp2IlInjected.Address(RVA = "0x2075830", Offset = "0x2074230", VA = "0x182075830")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005913")]
			[Cpp2IlInjected.Address(RVA = "0x2075BB0", Offset = "0x20745B0", VA = "0x182075BB0", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168C")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6005917")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005918")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168D")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005919")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x600591A")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168E")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x600591B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600591C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005908")]
		[Cpp2IlInjected.Address(RVA = "0x2075520", Offset = "0x2073F20", VA = "0x182075520")]
		public static bool IsAcceptedItem(Item item)
		{
			ItemType itemType = default(ItemType);
			UpgradeItemType upgradeItemType = default(UpgradeItemType);
			if (itemType != ItemType.Currency && (itemType != ItemType.Upgrade || upgradeItemType != UpgradeItemType.Tool))
			{
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600590B")]
		[Cpp2IlInjected.Address(RVA = "0x2075250", Offset = "0x2073C50", VA = "0x182075250")]
		private int GetAmount(IProfilePlayer player)
		{
			int num = item_;
			int num2 = item_;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Upgrade)
			{
				int num3 = (int)itemType;
				int num4 = 0;
				uint num5 = default(uint);
				if (num4 < (int)num5)
				{
					num4 += num4;
					num4++;
				}
				IContainerInventoryProvider containerInventoryProvider = player.GetContainerInventoryProvider();
				num3 += num3;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600590C")]
		[Cpp2IlInjected.Address(RVA = "0x2075140", Offset = "0x2073B40", VA = "0x182075140")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfilePlayer section = playerProfile.Section;
			int amount = GetAmount(section);
			int protobufValue = amount_;
			IntOperator intOperator = operator_;
			return Operations.Evaluate(amount, intOperator, protobufValue);
		}

		[Cpp2IlInjected.Token(Token = "0x600590F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005910")]
		[Cpp2IlInjected.Address(RVA = "0x2075090", Offset = "0x2073A90", VA = "0x182075090", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0034
			if (item_ == 0)
			{
				context.AddInvalidMemberError("Please select a item", "Item");
			}
			int protobufValue = amount_;
			int minValue = 0;
			IntOperator intOperator = operator_;
			string text = default(string);
			Operations.DataValidationMinValue(minValue, intOperator, protobufValue, context, text);
		}

		[Cpp2IlInjected.Token(Token = "0x6005914")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionInventory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005915")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public ConditionInventory(ConditionInventory other)
		{
			int num = (item_ = other.item_);
			IntOperator intOperator = (operator_ = other.operator_);
			int num2 = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005916")]
		[Cpp2IlInjected.Address(RVA = "0x2075000", Offset = "0x2073A00", VA = "0x182075000", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionInventory Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionInventory conditionInventory = new ConditionInventory();
			int num = (conditionInventory.item_ = item_);
			IntOperator intOperator = (conditionInventory.operator_ = operator_);
			int num2 = (conditionInventory.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (conditionInventory._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionInventory;
		}

		[Cpp2IlInjected.Token(Token = "0x600591D")]
		[Cpp2IlInjected.Address(RVA = "0x20751B0", Offset = "0x2073BB0", VA = "0x1820751B0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)item_ == (IntPtr)typeof(ConditionInventory).TypeHandle && (IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionInventory).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(ConditionInventory).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600591E")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionInventory other)
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
					IntOperator intOperator = other.operator_;
					if (operator_ == intOperator)
					{
						int num2 = other.amount_;
						if (amount_ == num2)
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

		[Cpp2IlInjected.Token(Token = "0x600591F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF83C0", Offset = "0x1DF6DC0", VA = "0x181DF83C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (item_ != 0)
				{
				}
				if (operator_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005920")]
		[Cpp2IlInjected.Address(RVA = "0x20756C0", Offset = "0x20740C0", VA = "0x1820756C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005921")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			if (item_ != 0)
			{
				int value = item_;
				output.WriteInt32(value);
			}
			if (operator_ != 0)
			{
			}
			if (amount_ != 0)
			{
				int value2 = amount_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005922")]
		[Cpp2IlInjected.Address(RVA = "0x2074F00", Offset = "0x2073900", VA = "0x182074F00", Slot = "12")]
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
				IntOperator intOperator = operator_;
				if (intOperator != 0)
				{
					int num4 = CodedOutputStream.ComputeEnumSize((int)intOperator);
					num4++;
					num2 += num4;
				}
				int num5 = amount_;
				if (num5 != 0)
				{
					int num6 = CodedOutputStream.ComputeInt32Size(num5);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005923")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionInventory other)
		{
			if (other != null)
			{
				int num = other.item_;
				if (num != 0)
				{
					item_ = num;
				}
				IntOperator intOperator = other.operator_;
				if (intOperator != 0)
				{
					operator_ = intOperator;
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

		[Cpp2IlInjected.Token(Token = "0x6005924")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (item_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (int)(operator_ = (IntOperator)input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005925")]
		[Cpp2IlInjected.Address(RVA = "0x2075440", Offset = "0x2073E40", VA = "0x182075440", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = item_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005926")]
		[Cpp2IlInjected.Address(RVA = "0x20755A0", Offset = "0x2073FA0", VA = "0x1820755A0", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					amount_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					operator_ = (IntOperator)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				item_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005927")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				amount_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005928")]
		[Cpp2IlInjected.Address(RVA = "0x2075720", Offset = "0x2074120", VA = "0x182075720")]
		static ConditionInventory()
		{
			Func<ConditionInventory> func = default(Func<ConditionInventory>);
			_parser = (MessageParser<ConditionInventory>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005929")]
		[Cpp2IlInjected.Address(RVA = "0x2075140", Offset = "0x2073B40", VA = "0x182075140", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfilePlayer section = playerProfile.Section;
			int amount = GetAmount(section);
			int protobufValue = amount_;
			IntOperator intOperator = operator_;
			return Operations.Evaluate(amount, intOperator, protobufValue);
		}
	}
}
