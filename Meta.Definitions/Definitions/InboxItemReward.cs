using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class InboxItemReward : IMessage<InboxItemReward>, IMessage, IEquatable<InboxItemReward>, IDeepCloneable<InboxItemReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private static readonly MessageParser<InboxItemReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public const int StateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private ItemState state_;

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		[DebuggerNonUserCode]
		public static MessageParser<InboxItemReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000984")]
			[Cpp2IlInjected.Address(RVA = "0x27B5450", Offset = "0x27B3E50", VA = "0x1827B5450")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000985")]
			[Cpp2IlInjected.Address(RVA = "0x27B5380", Offset = "0x27B3D80", VA = "0x1827B5380")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0x27B54B0", Offset = "0x27B3EB0", VA = "0x1827B54B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600098A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x600098B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		[DebuggerNonUserCode]
		public ItemState State
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				state_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public InboxItemReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x1F17030", Offset = "0x1F15A30", VA = "0x181F17030")]
		[DebuggerNonUserCode]
		public InboxItemReward(InboxItemReward other)
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

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0x27B4CC0", Offset = "0x27B36C0", VA = "0x1827B4CC0", Slot = "10")]
		[DebuggerNonUserCode]
		public InboxItemReward Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0040: Expected O, but got I4
			InboxItemReward inboxItemReward = new InboxItemReward();
			int num = (inboxItemReward.id_ = id_);
			int num2 = (inboxItemReward.amount_ = amount_);
			ItemState itemState = state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num3 = 0;
			inboxItemReward.state_ = (ItemState)num3;
			UnknownFieldSet unknownFieldSet = (inboxItemReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return inboxItemReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x27B4D70", Offset = "0x27B3770", VA = "0x1827B4D70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(InboxItemReward).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(InboxItemReward).TypeHandle && object.Equals(state_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(InboxItemReward other)
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

		[Cpp2IlInjected.Token(Token = "0x6000992")]
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

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x27B5210", Offset = "0x27B3C10", VA = "0x1827B5210", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
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

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x27B4BC0", Offset = "0x27B35C0", VA = "0x1827B4BC0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x27B4F00", Offset = "0x27B3900", VA = "0x1827B4F00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(InboxItemReward other)
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

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x27B4FE0", Offset = "0x27B39E0", VA = "0x1827B4FE0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x27B4E30", Offset = "0x27B3830", VA = "0x1827B4E30", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x27B50F0", Offset = "0x27B3AF0", VA = "0x1827B50F0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x1F16580", Offset = "0x1F14F80", VA = "0x181F16580", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x27B5270", Offset = "0x27B3C70", VA = "0x1827B5270")]
		static InboxItemReward()
		{
			Func<InboxItemReward> func = default(Func<InboxItemReward>);
			_parser = (MessageParser<InboxItemReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
