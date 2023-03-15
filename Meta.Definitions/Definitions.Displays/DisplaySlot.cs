using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x200074A")]
	public sealed class DisplaySlot : IMessage<DisplaySlot>, IMessage, IEquatable<DisplaySlot>, IDeepCloneable<DisplaySlot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400246E")]
		private static readonly MessageParser<DisplaySlot> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400246F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002470")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002471")]
		private ItemAmount item_;

		[Cpp2IlInjected.Token(Token = "0x4002472")]
		public const int IsAvailableFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002473")]
		private bool isAvailable_;

		[Cpp2IlInjected.Token(Token = "0x4002474")]
		public const int CurrencyIdFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002475")]
		private int currencyId_;

		[Cpp2IlInjected.Token(Token = "0x17001479")]
		[DebuggerNonUserCode]
		public static MessageParser<DisplaySlot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600508D")]
			[Cpp2IlInjected.Address(RVA = "0x2C4BEE0", Offset = "0x2C4A8E0", VA = "0x182C4BEE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600508E")]
			[Cpp2IlInjected.Address(RVA = "0x2C4BE10", Offset = "0x2C4A810", VA = "0x182C4BE10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600508F")]
			[Cpp2IlInjected.Address(RVA = "0x2C4BF40", Offset = "0x2C4A940", VA = "0x182C4BF40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147C")]
		[DebuggerNonUserCode]
		public ItemAmount Item
		{
			[Cpp2IlInjected.Token(Token = "0x6005093")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005094")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				item_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147D")]
		[DebuggerNonUserCode]
		public bool IsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6005095")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return isAvailable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005096")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				isAvailable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700147E")]
		[DebuggerNonUserCode]
		public int CurrencyId
		{
			[Cpp2IlInjected.Token(Token = "0x6005097")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return currencyId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005098")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				currencyId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005090")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DisplaySlot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005091")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BD90", Offset = "0x2C4A790", VA = "0x182C4BD90")]
		[DebuggerNonUserCode]
		public DisplaySlot(DisplaySlot other)
		{
			//IL_0021: Expected O, but got I4
			ItemAmount itemAmount = other.item_;
			if (itemAmount != null)
			{
				ItemAmount itemAmount2 = itemAmount.Clone();
			}
			int num = 0;
			item_ = (ItemAmount)num;
			bool flag = (isAvailable_ = other.isAvailable_);
			int num2 = (currencyId_ = other.currencyId_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005092")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B690", Offset = "0x2C4A090", VA = "0x182C4B690", Slot = "10")]
		[DebuggerNonUserCode]
		public DisplaySlot Clone()
		{
			//Discarded unreachable code: IL_0058
			//IL_0021: Expected O, but got I4
			DisplaySlot displaySlot = new DisplaySlot();
			ItemAmount itemAmount = item_;
			if (itemAmount != null)
			{
				ItemAmount itemAmount2 = itemAmount.Clone();
			}
			int num = 0;
			displaySlot.item_ = (ItemAmount)num;
			bool flag = (displaySlot.isAvailable_ = isAvailable_);
			int num2 = (displaySlot.currencyId_ = currencyId_);
			UnknownFieldSet unknownFieldSet = (displaySlot._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return displaySlot;
		}

		[Cpp2IlInjected.Token(Token = "0x6005099")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B740", Offset = "0x2C4A140", VA = "0x182C4B740", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(item_, other);
				if (flag && isAvailable_ == flag && currencyId_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600509A")]
		[Cpp2IlInjected.Address(RVA = "0x21169E0", Offset = "0x21153E0", VA = "0x1821169E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DisplaySlot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemAmount objB = other.item_;
				if (object.Equals(item_, objB))
				{
					bool flag = other.isAvailable_;
					if (isAvailable_ == flag)
					{
						int num = other.currencyId_;
						if (currencyId_ == num)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600509B")]
		[Cpp2IlInjected.Address(RVA = "0x2117C20", Offset = "0x2116620", VA = "0x182117C20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemAmount itemAmount = item_;
				if (itemAmount != null)
				{
					int hashCode = itemAmount.GetHashCode();
				}
				if (isAvailable_)
				{
				}
				if (currencyId_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600509C")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BC20", Offset = "0x2C4A620", VA = "0x182C4BC20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600509D")]
		[Cpp2IlInjected.Address(RVA = "0x2119600", Offset = "0x2118000", VA = "0x182119600", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005a
			if ((long)item_ != 0)
			{
				ItemAmount value = item_;
				output.WriteMessage(value);
			}
			if (isAvailable_)
			{
				bool value2 = isAvailable_;
				output.WriteBool(value2);
			}
			if (currencyId_ != 0)
			{
				int value3 = currencyId_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600509E")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B5B0", Offset = "0x2C49FB0", VA = "0x182C4B5B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemAmount itemAmount = item_;
				num = 0;
				if (itemAmount != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemAmount);
					num2++;
				}
				int num3 = currencyId_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600509F")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BA10", Offset = "0x2C4A410", VA = "0x182C4BA10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DisplaySlot other)
		{
			//Discarded unreachable code: IL_007f
			if (other == null)
			{
				return;
			}
			if ((long)other.item_ != 0)
			{
				ItemAmount itemAmount = item_;
				if (itemAmount == null)
				{
					ItemAmount itemAmount2 = (item_ = new ItemAmount());
				}
				ItemAmount other2 = other.item_;
				itemAmount.MergeFrom(other2);
			}
			bool flag = other.isAvailable_;
			if (flag)
			{
				isAvailable_ = flag;
			}
			int num = other.currencyId_;
			if (num != 0)
			{
				currencyId_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60050A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B900", Offset = "0x2C4A300", VA = "0x182C4B900", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0070
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemAmount itemAmount = item_;
				if (itemAmount == null)
				{
					ItemAmount itemAmount2 = (item_ = new ItemAmount());
				}
				input.ReadMessage(itemAmount);
			}
			bool flag = default(bool);
			if (num == 16)
			{
				flag = (isAvailable_ = input.ReadBool());
			}
			if (flag)
			{
				int num2 = (currencyId_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60050A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B800", Offset = "0x2C4A200", VA = "0x182C4B800", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					int num2 = currencyId_;
				}
				bool flag = isAvailable_;
			}
			ItemAmount itemAmount = item_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60050A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BAF0", Offset = "0x2C4A4F0", VA = "0x182C4BAF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					currencyId_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					isAvailable_ = (byte)(int)obj != 0;
					break;
				}
				}
				return;
			}
			if (value == null || value != null)
			{
				item_ = (ItemAmount)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050A3")]
		[Cpp2IlInjected.Address(RVA = "0x2115AA0", Offset = "0x21144A0", VA = "0x182115AA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				currencyId_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BC80", Offset = "0x2C4A680", VA = "0x182C4BC80")]
		static DisplaySlot()
		{
			Func<DisplaySlot> func = default(Func<DisplaySlot>);
			_parser = (MessageParser<DisplaySlot>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
