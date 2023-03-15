using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class LimitFatigue : IFatigue, IFatigueQuantity, IMessage<LimitFatigue>, IMessage, IEquatable<LimitFatigue>, IDeepCloneable<LimitFatigue>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly MessageParser<LimitFatigue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public const int QuantityFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int quantity_;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[DebuggerNonUserCode]
		public static MessageParser<LimitFatigue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x2745690", Offset = "0x2744090", VA = "0x182745690")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x27455C0", Offset = "0x2743FC0", VA = "0x1827455C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x27456F0", Offset = "0x27440F0", VA = "0x1827456F0", Slot = "11")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[DebuggerNonUserCode]
		public int Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "6")]
			get
			{
				return quantity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				quantity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "4")]
		public bool CanRefresh(DateTime lastRefresh, DateTime now)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2745370", Offset = "0x2743D70", VA = "0x182745370", Slot = "5")]
		public DateTime NextAutoRefresh(DateTime now)
		{
			return DateTime.MaxValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LimitFatigue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public LimitFatigue(LimitFatigue other)
		{
			int num = (quantity_ = other.quantity_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x27451B0", Offset = "0x2743BB0", VA = "0x1827451B0", Slot = "13")]
		[DebuggerNonUserCode]
		public LimitFatigue Clone()
		{
			//Discarded unreachable code: IL_0029
			LimitFatigue limitFatigue = new LimitFatigue();
			int num = (limitFatigue.quantity_ = quantity_);
			UnknownFieldSet unknownFieldSet = (limitFatigue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return limitFatigue;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2745230", Offset = "0x2743C30", VA = "0x182745230", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)quantity_ == (IntPtr)typeof(LimitFatigue).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "12")]
		[DebuggerNonUserCode]
		public bool Equals(LimitFatigue other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.quantity_;
				if (quantity_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (quantity_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2745450", Offset = "0x2743E50", VA = "0x182745450", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "9")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (quantity_ != 0)
			{
				int value = quantity_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2745110", Offset = "0x2743B10", VA = "0x182745110", Slot = "10")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = quantity_;
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

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(LimitFatigue other)
		{
			if (other != null)
			{
				int num = other.quantity_;
				if (num != 0)
				{
					quantity_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (quantity_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x27452C0", Offset = "0x2743CC0", VA = "0x1827452C0", Slot = "14")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = quantity_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x27453D0", Offset = "0x2743DD0", VA = "0x1827453D0", Slot = "15")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				quantity_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "16")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				quantity_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x27454B0", Offset = "0x2743EB0", VA = "0x1827454B0")]
		static LimitFatigue()
		{
			Func<LimitFatigue> func = default(Func<LimitFatigue>);
			_parser = (MessageParser<LimitFatigue>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
