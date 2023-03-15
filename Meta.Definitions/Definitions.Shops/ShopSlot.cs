using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Shops
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	public sealed class ShopSlot : IMessage<ShopSlot>, IMessage, IEquatable<ShopSlot>, IDeepCloneable<ShopSlot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private static readonly MessageParser<ShopSlot> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public const int FatigueFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private AnyFatigue fatigue_;

		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public const int CurrencyIdFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private int currencyId_;

		[Cpp2IlInjected.Token(Token = "0x17000363")]
		[DebuggerNonUserCode]
		public static MessageParser<ShopSlot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000E13")]
			[Cpp2IlInjected.Address(RVA = "0x384F790", Offset = "0x384E190", VA = "0x18384F790")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000364")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E14")]
			[Cpp2IlInjected.Address(RVA = "0x384F580", Offset = "0x384DF80", VA = "0x18384F580")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000365")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E15")]
			[Cpp2IlInjected.Address(RVA = "0x384F850", Offset = "0x384E250", VA = "0x18384F850", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000366")]
		[DebuggerNonUserCode]
		public AnyFatigue Fatigue
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return fatigue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E1B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				fatigue_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000367")]
		[DebuggerNonUserCode]
		public int CurrencyId
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1C")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return currencyId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E1D")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				currencyId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000368")]
		public bool HasLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000E29")]
			[Cpp2IlInjected.Address(RVA = "0x384F720", Offset = "0x384E120", VA = "0x18384F720")]
			get
			{
				AnyFatigue anyFatigue;
				do
				{
					anyFatigue = fatigue_;
				}
				while (anyFatigue == null);
				return anyFatigue.fatigueCase_ == AnyFatigue.FatigueOneofCase.Limit;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000369")]
		public int LimitAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2A")]
			[Cpp2IlInjected.Address(RVA = "0x384F760", Offset = "0x384E160", VA = "0x18384F760")]
			get
			{
				//Discarded unreachable code: IL_0011
				return fatigue_.Limit.quantity_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E16")]
		[Cpp2IlInjected.Address(RVA = "0x384F3B0", Offset = "0x384DDB0", VA = "0x18384F3B0")]
		[DebuggerNonUserCode]
		public ShopSlot()
		{
			//IL_0011: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			Item item = default(Item);
			currencyId_ = (int)item;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E17")]
		[Cpp2IlInjected.Address(RVA = "0x384EDC0", Offset = "0x384D7C0", VA = "0x18384EDC0")]
		private void OnConstruction()
		{
			//IL_000b: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			Item item = default(Item);
			currencyId_ = (int)item;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E18")]
		[Cpp2IlInjected.Address(RVA = "0x384F4B0", Offset = "0x384DEB0", VA = "0x18384F4B0")]
		[DebuggerNonUserCode]
		public ShopSlot(ShopSlot other)
		{
			//IL_0013: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Item item = default(Item);
			currencyId_ = (int)item;
			AnyFatigue anyFatigue = other.fatigue_;
			if (anyFatigue != null)
			{
				AnyFatigue anyFatigue2 = anyFatigue.Clone();
			}
			fatigue_ = (AnyFatigue)num;
			int num4 = (currencyId_ = other.currencyId_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E19")]
		[Cpp2IlInjected.Address(RVA = "0x384E380", Offset = "0x384CD80", VA = "0x18384E380", Slot = "10")]
		[DebuggerNonUserCode]
		public ShopSlot Clone()
		{
			//Discarded unreachable code: IL_0058
			//IL_0014: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			ShopSlot shopSlot = new ShopSlot();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Item item = default(Item);
			shopSlot.currencyId_ = (int)item;
			AnyFatigue anyFatigue = fatigue_;
			if (anyFatigue != null)
			{
				AnyFatigue anyFatigue2 = anyFatigue.Clone();
			}
			shopSlot.fatigue_ = (AnyFatigue)num;
			int num4 = (shopSlot.currencyId_ = currencyId_);
			UnknownFieldSet unknownFieldSet = (shopSlot._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return shopSlot;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1E")]
		[Cpp2IlInjected.Address(RVA = "0x384E610", Offset = "0x384D010", VA = "0x18384E610", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(fatigue_, other);
				if (flag && currencyId_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1F")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ShopSlot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				AnyFatigue objB = other.fatigue_;
				if (object.Equals(fatigue_, objB))
				{
					int num = other.currencyId_;
					if (currencyId_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E20")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				AnyFatigue anyFatigue = fatigue_;
				if (anyFatigue != null)
				{
					int hashCode = anyFatigue.GetHashCode();
				}
				if (currencyId_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E21")]
		[Cpp2IlInjected.Address(RVA = "0x384F040", Offset = "0x384DA40", VA = "0x18384F040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E22")]
		[Cpp2IlInjected.Address(RVA = "0x384F100", Offset = "0x384DB00", VA = "0x18384F100", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)fatigue_ != 0)
			{
				AnyFatigue value = fatigue_;
				output.WriteMessage(value);
			}
			if (currencyId_ != 0)
			{
				int value2 = currencyId_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E23")]
		[Cpp2IlInjected.Address(RVA = "0x384E260", Offset = "0x384CC60", VA = "0x18384E260", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				AnyFatigue anyFatigue = fatigue_;
				num = 0;
				if (anyFatigue != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(anyFatigue);
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

		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0x384EA30", Offset = "0x384D430", VA = "0x18384EA30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ShopSlot other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.fatigue_ != 0)
			{
				AnyFatigue anyFatigue = fatigue_;
				if (anyFatigue == null)
				{
					AnyFatigue anyFatigue2 = (fatigue_ = new AnyFatigue());
				}
				AnyFatigue other2 = other.fatigue_;
				anyFatigue.MergeFrom(other2);
			}
			int num = other.currencyId_;
			if (num != 0)
			{
				currencyId_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000E25")]
		[Cpp2IlInjected.Address(RVA = "0x384E940", Offset = "0x384D340", VA = "0x18384E940", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 18)
			{
				AnyFatigue anyFatigue = fatigue_;
				if (anyFatigue == null)
				{
					AnyFatigue anyFatigue2 = (fatigue_ = new AnyFatigue());
				}
				input.ReadMessage(anyFatigue);
			}
			if (num == 32)
			{
				int num2 = (currencyId_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000E26")]
		[Cpp2IlInjected.Address(RVA = "0x384E6C0", Offset = "0x384D0C0", VA = "0x18384E6C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 2)
			{
				AnyFatigue anyFatigue = fatigue_;
			}
			if (fieldNumber == 4)
			{
				int num = currencyId_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E27")]
		[Cpp2IlInjected.Address(RVA = "0x384EF70", Offset = "0x384D970", VA = "0x18384EF70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			if (fieldNumber == 2)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				fatigue_ = (AnyFatigue)num;
			}
			else
			{
				while (fieldNumber != 4)
				{
				}
				object obj = default(object);
				currencyId_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E28")]
		[Cpp2IlInjected.Address(RVA = "0x384E330", Offset = "0x384CD30", VA = "0x18384E330", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 2)
			{
			}
			if (fieldNumber == 4)
			{
				currencyId_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2B")]
		[Cpp2IlInjected.Address(RVA = "0x384F2A0", Offset = "0x384DCA0", VA = "0x18384F2A0")]
		static ShopSlot()
		{
			Func<ShopSlot> func = default(Func<ShopSlot>);
			_parser = (MessageParser<ShopSlot>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
