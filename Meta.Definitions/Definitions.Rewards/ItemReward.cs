using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000226")]
	[DebuggerDisplay("{DebugDisplay,nq}")]
	public sealed class ItemReward : IMessage<ItemReward>, IMessage, IEquatable<ItemReward>, IDeepCloneable<ItemReward>, IMessageFieldAccessor, IReward, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40008C5")]
		private static readonly MessageParser<ItemReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008C6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40008C7")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008C8")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x40008C9")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40008CA")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x40008CB")]
		public const int StateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008CC")]
		private ItemState state_;

		[Cpp2IlInjected.Token(Token = "0x1700048F")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600148A")]
			[Cpp2IlInjected.Address(RVA = "0x25ED820", Offset = "0x25EC220", VA = "0x1825ED820")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000490")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600148B")]
			[Cpp2IlInjected.Address(RVA = "0x25ED6F0", Offset = "0x25EC0F0", VA = "0x1825ED6F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000491")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600148C")]
			[Cpp2IlInjected.Address(RVA = "0x25ED880", Offset = "0x25EC280", VA = "0x1825ED880", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000492")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6001490")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001491")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000493")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6001492")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001493")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000494")]
		[DebuggerNonUserCode]
		public ItemState State
		{
			[Cpp2IlInjected.Token(Token = "0x6001494")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001495")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				state_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000495")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60014A1")]
			[Cpp2IlInjected.Address(RVA = "0x25ED7C0", Offset = "0x25EC1C0", VA = "0x1825ED7C0")]
			get
			{
				long num = Convert.ToInt64((uint)id_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000496")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60014A2")]
			[Cpp2IlInjected.Address(RVA = "0x25ED610", Offset = "0x25EC010", VA = "0x1825ED610", Slot = "14")]
			get
			{
				//IL_001f: Expected O, but got I8
				//IL_001f: Expected O, but got I4
				int num = amount_;
				long num2 = Convert.ToInt64((uint)id_);
				return $"{num}x {num2}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600148D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600148E")]
		[Cpp2IlInjected.Address(RVA = "0x1F17030", Offset = "0x1F15A30", VA = "0x181F17030")]
		[DebuggerNonUserCode]
		public ItemReward(ItemReward other)
		{
			//IL_003f: Expected O, but got I4
			int num = (id_ = other.id_);
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

		[Cpp2IlInjected.Token(Token = "0x600148F")]
		[Cpp2IlInjected.Address(RVA = "0x25ECA70", Offset = "0x25EB470", VA = "0x1825ECA70", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemReward Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0040: Expected O, but got I4
			ItemReward itemReward = new ItemReward();
			int num = (itemReward.id_ = id_);
			int num2 = (itemReward.amount_ = amount_);
			ItemState itemState = state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num3 = 0;
			itemReward.state_ = (ItemState)num3;
			UnknownFieldSet unknownFieldSet = (itemReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6001496")]
		[Cpp2IlInjected.Address(RVA = "0x25ECCA0", Offset = "0x25EB6A0", VA = "0x1825ECCA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(ItemReward).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(ItemReward).TypeHandle && object.Equals(state_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001497")]
		[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemReward other)
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

		[Cpp2IlInjected.Token(Token = "0x6001498")]
		[Cpp2IlInjected.Address(RVA = "0x18C2EE0", Offset = "0x18C18E0", VA = "0x1818C2EE0", Slot = "2")]
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

		[Cpp2IlInjected.Token(Token = "0x6001499")]
		[Cpp2IlInjected.Address(RVA = "0x25ED4A0", Offset = "0x25EBEA0", VA = "0x1825ED4A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600149A")]
		[Cpp2IlInjected.Address(RVA = "0x1F16E70", Offset = "0x1F15870", VA = "0x181F16E70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005a
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
			if ((long)state_ != 0)
			{
				ItemState value3 = state_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600149B")]
		[Cpp2IlInjected.Address(RVA = "0x25EC850", Offset = "0x25EB250", VA = "0x1825EC850", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x600149C")]
		[Cpp2IlInjected.Address(RVA = "0x25ED210", Offset = "0x25EBC10", VA = "0x1825ED210", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemReward other)
		{
			//Discarded unreachable code: IL_0083
			if (other == null)
			{
				return;
			}
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

		[Cpp2IlInjected.Token(Token = "0x600149D")]
		[Cpp2IlInjected.Address(RVA = "0x25ED100", Offset = "0x25EBB00", VA = "0x1825ED100", Slot = "5")]
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
				int num2 = (id_ = input.ReadInt32());
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

		[Cpp2IlInjected.Token(Token = "0x600149E")]
		[Cpp2IlInjected.Address(RVA = "0x25ECD60", Offset = "0x25EB760", VA = "0x1825ECD60", Slot = "11")]
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
			int num2 = id_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600149F")]
		[Cpp2IlInjected.Address(RVA = "0x25ED380", Offset = "0x25EBD80", VA = "0x1825ED380", Slot = "12")]
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
				id_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014A0")]
		[Cpp2IlInjected.Address(RVA = "0x1F16580", Offset = "0x1F14F80", VA = "0x181F16580", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014A3")]
		[Cpp2IlInjected.Address(RVA = "0x25ED2F0", Offset = "0x25EBCF0", VA = "0x1825ED2F0")]
		public static ItemReward New(Item item, int amount, [Optional] ItemState state)
		{
			//Discarded unreachable code: IL_0024
			int itemID = item.ItemID;
			ItemReward itemReward = new ItemReward();
			itemReward.state_ = state;
			itemReward.id_ = itemID;
			itemReward.amount_ = amount;
			return itemReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60014A4")]
		[Cpp2IlInjected.Address(RVA = "0x25EC950", Offset = "0x25EB350", VA = "0x1825EC950", Slot = "15")]
		public bool CanGive(IRewardRecipient recipient)
		{
			//Discarded unreachable code: IL_001b
			//IL_001b: Expected I4, but got O
			int num = id_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			return (byte)(int)typeof(Item).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60014A5")]
		[Cpp2IlInjected.Address(RVA = "0x25ECEE0", Offset = "0x25EB8E0", VA = "0x1825ECEE0")]
		public void Give(IRewardRecipient recipient, IProfile profile, IProfileEventDispatcher dispatcher, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60014A6")]
		[Cpp2IlInjected.Address(RVA = "0x25ECF90", Offset = "0x25EB990", VA = "0x1825ECF90")]
		public void Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false)
		{
			//Discarded unreachable code: IL_001d
			int num = id_;
			ItemState itemState = state_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014A7")]
		[Cpp2IlInjected.Address(RVA = "0x25ECE30", Offset = "0x25EB830", VA = "0x1825ECE30", Slot = "17")]
		public int GetGivenItems(MultiItemInstance rewards)
		{
			//Discarded unreachable code: IL_0042
			RepeatedField<ItemInstance> items_ = rewards.items_;
			ItemInstance itemInstance = new ItemInstance();
			int num = (itemInstance.itemID_ = id_);
			int num2 = (itemInstance.amount_ = amount_);
			ItemState itemState = (itemInstance.state_ = state_);
			((RepeatedField<T>)(object)items_).Add((T)itemInstance);
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60014A8")]
		[Cpp2IlInjected.Address(RVA = "0x25ECB20", Offset = "0x25EB520", VA = "0x1825ECB20", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0042
			if (amount_ != 0)
			{
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
		}

		[Cpp2IlInjected.Token(Token = "0x60014A9")]
		[Cpp2IlInjected.Address(RVA = "0x25ED500", Offset = "0x25EBF00", VA = "0x1825ED500")]
		static ItemReward()
		{
			Func<ItemReward> func = default(Func<ItemReward>);
			_parser = (MessageParser<ItemReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014AA")]
		[Cpp2IlInjected.Address(RVA = "0x25ECC80", Offset = "0x25EB680", VA = "0x1825ECC80", Slot = "16")]
		void IReward.Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, Item? characterItem, bool canSendToInbox)
		{
		}
	}
}
