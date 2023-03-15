using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DFA")]
	public sealed class ActionGiveItem : IMessage<ActionGiveItem>, IMessage, IEquatable<ActionGiveItem>, IDeepCloneable<ActionGiveItem>, IMessageFieldAccessor, IAction, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40038B1")]
		private static readonly MessageParser<ActionGiveItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038B2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038B3")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038B4")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x40038B5")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40038B6")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x17001450")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionGiveItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007518")]
			[Cpp2IlInjected.Address(RVA = "0x1E30F00", Offset = "0x1E2F900", VA = "0x181E30F00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001451")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007519")]
			[Cpp2IlInjected.Address(RVA = "0x1E30CF0", Offset = "0x1E2F6F0", VA = "0x181E30CF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001452")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600751A")]
			[Cpp2IlInjected.Address(RVA = "0x1E30F60", Offset = "0x1E2F960", VA = "0x181E30F60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001453")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600751E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600751F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001454")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6007520")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007521")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001455")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600752D")]
			[Cpp2IlInjected.Address(RVA = "0x1E30EA0", Offset = "0x1E2F8A0", VA = "0x181E30EA0")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001456")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600752F")]
			[Cpp2IlInjected.Address(RVA = "0x1E30DC0", Offset = "0x1E2F7C0", VA = "0x181E30DC0", Slot = "15")]
			get
			{
				//IL_001f: Expected O, but got I8
				//IL_001f: Expected O, but got I4
				int num = amount_;
				long num2 = Convert.ToInt64((uint)itemID_);
				return $"GiveItem {num}x {num2}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600751B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActionGiveItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600751C")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public ActionGiveItem(ActionGiveItem other)
		{
			int num = (itemID_ = other.itemID_);
			int num2 = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600751D")]
		[Cpp2IlInjected.Address(RVA = "0x1E30760", Offset = "0x1E2F160", VA = "0x181E30760", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionGiveItem Clone()
		{
			//Discarded unreachable code: IL_0037
			ActionGiveItem actionGiveItem = new ActionGiveItem();
			int num = (actionGiveItem.itemID_ = itemID_);
			int num2 = (actionGiveItem.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (actionGiveItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionGiveItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6007522")]
		[Cpp2IlInjected.Address(RVA = "0x1E30970", Offset = "0x1E2F370", VA = "0x181E30970", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(ActionGiveItem).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(ActionGiveItem).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007523")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionGiveItem other)
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
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007524")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6007525")]
		[Cpp2IlInjected.Address(RVA = "0x1E30B80", Offset = "0x1E2F580", VA = "0x181E30B80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007526")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
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
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007527")]
		[Cpp2IlInjected.Address(RVA = "0x1E30690", Offset = "0x1E2F090", VA = "0x181E30690", Slot = "7")]
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6007528")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionGiveItem other)
		{
			if (other != null)
			{
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
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007529")]
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
					int num2 = (itemID_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600752A")]
		[Cpp2IlInjected.Address(RVA = "0x1E30A00", Offset = "0x1E2F400", VA = "0x181E30A00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = itemID_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600752B")]
		[Cpp2IlInjected.Address(RVA = "0x1E30AC0", Offset = "0x1E2F4C0", VA = "0x181E30AC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				itemID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			amount_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x600752C")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				itemID_ = 0;
				break;
			case 2:
				amount_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600752E")]
		[Cpp2IlInjected.Address(RVA = "0x1E30610", Offset = "0x1E2F010", VA = "0x181E30610", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = itemID_;
		}

		[Cpp2IlInjected.Token(Token = "0x6007530")]
		[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960", Slot = "16")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_0009: Expected I4, but got I8
			amount_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6007531")]
		[Cpp2IlInjected.Address(RVA = "0x1E307F0", Offset = "0x1E2F1F0", VA = "0x181E307F0", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0022
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = itemID_;
			bool flag = default(bool);
			if (flag)
			{
				context.AddInvalidMemberError("Unsupported item. Cannot give any 'BackpackItem' for now", "Item");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007532")]
		[Cpp2IlInjected.Address(RVA = "0x1E30BE0", Offset = "0x1E2F5E0", VA = "0x181E30BE0")]
		static ActionGiveItem()
		{
			Func<ActionGiveItem> func = default(Func<ActionGiveItem>);
			_parser = (MessageParser<ActionGiveItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
