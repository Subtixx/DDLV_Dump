using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E0A")]
	public sealed class ActionRemoveFromGrid : IMessage<ActionRemoveFromGrid>, IMessage, IEquatable<ActionRemoveFromGrid>, IDeepCloneable<ActionRemoveFromGrid>, IMessageFieldAccessor, IAction, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40038F4")]
		private static readonly MessageParser<ActionRemoveFromGrid> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038F5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038F6")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038F7")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x40038F8")]
		public const int GiveBackFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40038F9")]
		private bool giveBack_;

		[Cpp2IlInjected.Token(Token = "0x17001489")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionRemoveFromGrid> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60075FE")]
			[Cpp2IlInjected.Address(RVA = "0x18D9C90", Offset = "0x18D8690", VA = "0x1818D9C90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700148A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60075FF")]
			[Cpp2IlInjected.Address(RVA = "0x18D9AB0", Offset = "0x18D84B0", VA = "0x1818D9AB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700148B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007600")]
			[Cpp2IlInjected.Address(RVA = "0x18D9CF0", Offset = "0x18D86F0", VA = "0x1818D9CF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700148C")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6007604")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007605")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700148D")]
		[DebuggerNonUserCode]
		public bool GiveBack
		{
			[Cpp2IlInjected.Token(Token = "0x6007606")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return giveBack_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007607")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				giveBack_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700148E")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6007613")]
			[Cpp2IlInjected.Address(RVA = "0x18D9C30", Offset = "0x18D8630", VA = "0x1818D9C30")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700148F")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6007615")]
			[Cpp2IlInjected.Address(RVA = "0x18D9B80", Offset = "0x18D8580", VA = "0x1818D9B80", Slot = "15")]
			get
			{
				//IL_0017: Expected O, but got I8
				long num = Convert.ToInt64((uint)itemID_);
				return $"RemoveFromGrid {num}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007601")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActionRemoveFromGrid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007602")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ActionRemoveFromGrid(ActionRemoveFromGrid other)
		{
			int num = (itemID_ = other.itemID_);
			bool flag = (giveBack_ = other.giveBack_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007603")]
		[Cpp2IlInjected.Address(RVA = "0x18D91A0", Offset = "0x18D7BA0", VA = "0x1818D91A0", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionRemoveFromGrid Clone()
		{
			//Discarded unreachable code: IL_0037
			ActionRemoveFromGrid actionRemoveFromGrid = new ActionRemoveFromGrid();
			int num = (actionRemoveFromGrid.itemID_ = itemID_);
			bool flag = (actionRemoveFromGrid.giveBack_ = giveBack_);
			UnknownFieldSet unknownFieldSet = (actionRemoveFromGrid._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionRemoveFromGrid;
		}

		[Cpp2IlInjected.Token(Token = "0x6007608")]
		[Cpp2IlInjected.Address(RVA = "0x18D9570", Offset = "0x18D7F70", VA = "0x1818D9570", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(ActionRemoveFromGrid).TypeHandle && (IntPtr)(giveBack_ ? 1 : 0) == (IntPtr)typeof(ActionRemoveFromGrid).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007609")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionRemoveFromGrid other)
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
					bool flag = other.giveBack_;
					if (giveBack_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600760A")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemID_ != 0)
				{
				}
				if (giveBack_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600760B")]
		[Cpp2IlInjected.Address(RVA = "0x18D9850", Offset = "0x18D8250", VA = "0x1818D9850", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600760C")]
		[Cpp2IlInjected.Address(RVA = "0x18D98B0", Offset = "0x18D82B0", VA = "0x1818D98B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (itemID_ != 0)
			{
				int value = itemID_;
				output.WriteInt32(value);
			}
			if (giveBack_)
			{
				bool value2 = giveBack_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600760D")]
		[Cpp2IlInjected.Address(RVA = "0x18D90F0", Offset = "0x18D7AF0", VA = "0x1818D90F0", Slot = "7")]
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
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600760E")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionRemoveFromGrid other)
		{
			if (other != null)
			{
				int num = other.itemID_;
				if (num != 0)
				{
					itemID_ = num;
				}
				bool flag = other.giveBack_;
				if (flag)
				{
					giveBack_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600760F")]
		[Cpp2IlInjected.Address(RVA = "0x18D96F0", Offset = "0x18D80F0", VA = "0x1818D96F0", Slot = "5")]
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
				if (num == 24)
				{
					bool flag = (giveBack_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007610")]
		[Cpp2IlInjected.Address(RVA = "0x18D9600", Offset = "0x18D8000", VA = "0x1818D9600", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = itemID_;
			}
			if (fieldNumber == 3)
			{
				bool flag = giveBack_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007611")]
		[Cpp2IlInjected.Address(RVA = "0x18D9780", Offset = "0x18D8180", VA = "0x1818D9780", Slot = "12")]
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
			while (fieldNumber != 3)
			{
			}
			object obj2 = default(object);
			giveBack_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6007612")]
		[Cpp2IlInjected.Address(RVA = "0x18D9180", Offset = "0x18D7B80", VA = "0x1818D9180", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				itemID_ = 0;
				break;
			case 3:
				giveBack_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007614")]
		[Cpp2IlInjected.Address(RVA = "0x18D9070", Offset = "0x18D7A70", VA = "0x1818D9070", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = itemID_;
		}

		[Cpp2IlInjected.Token(Token = "0x6007616")]
		[Cpp2IlInjected.Address(RVA = "0x18D9230", Offset = "0x18D7C30", VA = "0x1818D9230", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_005e
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num2 = itemID_;
			bool flag = default(bool);
			if (flag && num == -3)
			{
				context.AddError("Furniture with SubGrid/Container interactions cannot be used for now - Ask jfroux to fix");
			}
			if (!giveBack_)
			{
				return;
			}
			int num3 = itemID_;
			bool flag2 = default(bool);
			if (flag2)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				int num4 = itemID_;
				bool flag3 = default(bool);
				if (flag3)
				{
					context.AddInvalidMemberError("Cannot be use with 'Backpack' (to avoid InventoryFull issue)", "GiveBack");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007617")]
		[Cpp2IlInjected.Address(RVA = "0x18D9940", Offset = "0x18D8340", VA = "0x1818D9940")]
		static ActionRemoveFromGrid()
		{
			Func<ActionRemoveFromGrid> func = default(Func<ActionRemoveFromGrid>);
			_parser = (MessageParser<ActionRemoveFromGrid>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
