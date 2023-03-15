using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E02")]
	public sealed class ActionRemoveFromCollectionMenu : IMessage<ActionRemoveFromCollectionMenu>, IMessage, IEquatable<ActionRemoveFromCollectionMenu>, IDeepCloneable<ActionRemoveFromCollectionMenu>, IMessageFieldAccessor, IAction
	{
		[Cpp2IlInjected.Token(Token = "0x40038D6")]
		private static readonly MessageParser<ActionRemoveFromCollectionMenu> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038D7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038D8")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038D9")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x17001473")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionRemoveFromCollectionMenu> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600759C")]
			[Cpp2IlInjected.Address(RVA = "0x18D8F00", Offset = "0x18D7900", VA = "0x1818D8F00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001474")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600759D")]
			[Cpp2IlInjected.Address(RVA = "0x18D8D20", Offset = "0x18D7720", VA = "0x1818D8D20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001475")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600759E")]
			[Cpp2IlInjected.Address(RVA = "0x18D8F60", Offset = "0x18D7960", VA = "0x1818D8F60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001476")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60075A2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60075A3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001477")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60075AF")]
			[Cpp2IlInjected.Address(RVA = "0x18D8EA0", Offset = "0x18D78A0", VA = "0x1818D8EA0")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001478")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60075B1")]
			[Cpp2IlInjected.Address(RVA = "0x18D8DF0", Offset = "0x18D77F0", VA = "0x1818D8DF0", Slot = "15")]
			get
			{
				//IL_0017: Expected O, but got I8
				long num = Convert.ToInt64((uint)itemID_);
				return $"RemoveFromCollectionMenu {num}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600759F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActionRemoveFromCollectionMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60075A0")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ActionRemoveFromCollectionMenu(ActionRemoveFromCollectionMenu other)
		{
			int num = (itemID_ = other.itemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60075A1")]
		[Cpp2IlInjected.Address(RVA = "0x18D8970", Offset = "0x18D7370", VA = "0x1818D8970", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionRemoveFromCollectionMenu Clone()
		{
			//Discarded unreachable code: IL_0029
			ActionRemoveFromCollectionMenu actionRemoveFromCollectionMenu = new ActionRemoveFromCollectionMenu();
			int num = (actionRemoveFromCollectionMenu.itemID_ = itemID_);
			UnknownFieldSet unknownFieldSet = (actionRemoveFromCollectionMenu._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionRemoveFromCollectionMenu;
		}

		[Cpp2IlInjected.Token(Token = "0x60075A4")]
		[Cpp2IlInjected.Address(RVA = "0x18D89F0", Offset = "0x18D73F0", VA = "0x1818D89F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(ActionRemoveFromCollectionMenu).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075A5")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionRemoveFromCollectionMenu other)
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
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60075A7")]
		[Cpp2IlInjected.Address(RVA = "0x18D8BB0", Offset = "0x18D75B0", VA = "0x1818D8BB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60075A8")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (itemID_ != 0)
			{
				int value = itemID_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60075A9")]
		[Cpp2IlInjected.Address(RVA = "0x18D88D0", Offset = "0x18D72D0", VA = "0x1818D88D0", Slot = "7")]
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60075AA")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionRemoveFromCollectionMenu other)
		{
			if (other != null)
			{
				int num = other.itemID_;
				if (num != 0)
				{
					itemID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (itemID_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075AC")]
		[Cpp2IlInjected.Address(RVA = "0x18D8A80", Offset = "0x18D7480", VA = "0x1818D8A80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = itemID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075AD")]
		[Cpp2IlInjected.Address(RVA = "0x18D8B30", Offset = "0x18D7530", VA = "0x1818D8B30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				itemID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075AE")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				itemID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075B0")]
		[Cpp2IlInjected.Address(RVA = "0x18D8860", Offset = "0x18D7260", VA = "0x1818D8860", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = itemID_;
		}

		[Cpp2IlInjected.Token(Token = "0x60075B2")]
		[Cpp2IlInjected.Address(RVA = "0x18D8C10", Offset = "0x18D7610", VA = "0x1818D8C10")]
		static ActionRemoveFromCollectionMenu()
		{
			Func<ActionRemoveFromCollectionMenu> func = default(Func<ActionRemoveFromCollectionMenu>);
			_parser = (MessageParser<ActionRemoveFromCollectionMenu>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
