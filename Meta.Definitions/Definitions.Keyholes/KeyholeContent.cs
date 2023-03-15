using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Keyholes
{
	[Cpp2IlInjected.Token(Token = "0x200026E")]
	public sealed class KeyholeContent : IMessage<KeyholeContent>, IMessage, IEquatable<KeyholeContent>, IDeepCloneable<KeyholeContent>, IMessageFieldAccessor, IItemInstance, IItemWithState, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000997")]
		private static readonly MessageParser<KeyholeContent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000998")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000999")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400099A")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x400099B")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400099C")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x400099D")]
		public const int StateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400099E")]
		private ItemState state_;

		[Cpp2IlInjected.Token(Token = "0x17000518")]
		[DebuggerNonUserCode]
		public static MessageParser<KeyholeContent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600170F")]
			[Cpp2IlInjected.Address(RVA = "0x273B4D0", Offset = "0x2739ED0", VA = "0x18273B4D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000519")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001710")]
			[Cpp2IlInjected.Address(RVA = "0x273B400", Offset = "0x2739E00", VA = "0x18273B400")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001711")]
			[Cpp2IlInjected.Address(RVA = "0x273B530", Offset = "0x2739F30", VA = "0x18273B530", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051B")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001715")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001716")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051C")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6001717")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "14")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001718")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051D")]
		[DebuggerNonUserCode]
		public ItemState State
		{
			[Cpp2IlInjected.Token(Token = "0x6001719")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "17")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x600171A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "18")]
			set
			{
				state_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051E")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001726")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				int num = itemID_;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6001727")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				itemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001712")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public KeyholeContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001713")]
		[Cpp2IlInjected.Address(RVA = "0x1F17030", Offset = "0x1F15A30", VA = "0x181F17030")]
		[DebuggerNonUserCode]
		public KeyholeContent(KeyholeContent other)
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

		[Cpp2IlInjected.Token(Token = "0x6001714")]
		[Cpp2IlInjected.Address(RVA = "0x273ABB0", Offset = "0x27395B0", VA = "0x18273ABB0", Slot = "10")]
		[DebuggerNonUserCode]
		public KeyholeContent Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0040: Expected O, but got I4
			KeyholeContent keyholeContent = new KeyholeContent();
			int num = (keyholeContent.itemID_ = itemID_);
			int num2 = (keyholeContent.amount_ = amount_);
			ItemState itemState = state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num3 = 0;
			keyholeContent.state_ = (ItemState)num3;
			UnknownFieldSet unknownFieldSet = (keyholeContent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return keyholeContent;
		}

		[Cpp2IlInjected.Token(Token = "0x600171B")]
		[Cpp2IlInjected.Address(RVA = "0x273ADF0", Offset = "0x27397F0", VA = "0x18273ADF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(KeyholeContent).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(KeyholeContent).TypeHandle && object.Equals(state_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600171C")]
		[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(KeyholeContent other)
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

		[Cpp2IlInjected.Token(Token = "0x600171D")]
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

		[Cpp2IlInjected.Token(Token = "0x600171E")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x2739C90", VA = "0x18273B290", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600171F")]
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

		[Cpp2IlInjected.Token(Token = "0x6001720")]
		[Cpp2IlInjected.Address(RVA = "0x273AAB0", Offset = "0x27394B0", VA = "0x18273AAB0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6001721")]
		[Cpp2IlInjected.Address(RVA = "0x273B090", Offset = "0x2739A90", VA = "0x18273B090", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(KeyholeContent other)
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

		[Cpp2IlInjected.Token(Token = "0x6001722")]
		[Cpp2IlInjected.Address(RVA = "0x273AF80", Offset = "0x2739980", VA = "0x18273AF80", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6001723")]
		[Cpp2IlInjected.Address(RVA = "0x273AEB0", Offset = "0x27398B0", VA = "0x18273AEB0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6001724")]
		[Cpp2IlInjected.Address(RVA = "0x273B170", Offset = "0x2739B70", VA = "0x18273B170", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6001725")]
		[Cpp2IlInjected.Address(RVA = "0x1F16580", Offset = "0x1F14F80", VA = "0x181F16580", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001728")]
		[Cpp2IlInjected.Address(RVA = "0x273AC60", Offset = "0x2739660", VA = "0x18273AC60", Slot = "19")]
		void IDataValidation.DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004d
			//IL_0032: Expected O, but got I4
			if (itemID_ != 0)
			{
				if (amount_ != 0)
				{
					context.AddInvalidMemberError("Amount should be 0 if the Item is invalid", "Amount");
				}
				ItemState a = state_;
				int num = 0;
				if (!ItemState.Equals(a, (ItemState)num))
				{
					context.AddInvalidMemberError("State should be null or None if Item is invalid", "State");
				}
			}
			int num2 = itemID_;
		}

		[Cpp2IlInjected.Token(Token = "0x6001729")]
		[Cpp2IlInjected.Address(RVA = "0x273B2F0", Offset = "0x2739CF0", VA = "0x18273B2F0")]
		static KeyholeContent()
		{
			Func<KeyholeContent> func = default(Func<KeyholeContent>);
			_parser = (MessageParser<KeyholeContent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
