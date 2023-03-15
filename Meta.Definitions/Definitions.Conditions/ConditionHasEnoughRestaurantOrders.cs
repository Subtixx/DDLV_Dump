using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007FE")]
	public sealed class ConditionHasEnoughRestaurantOrders : ICondition, IMessage<ConditionHasEnoughRestaurantOrders>, IMessage, IEquatable<ConditionHasEnoughRestaurantOrders>, IDeepCloneable<ConditionHasEnoughRestaurantOrders>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027E2")]
		private static readonly MessageParser<ConditionHasEnoughRestaurantOrders> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027E3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027E4")]
		public const int MinimumFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027E5")]
		private int minimum_;

		[Cpp2IlInjected.Token(Token = "0x17001671")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60058B0")]
			[Cpp2IlInjected.Address(RVA = "0x2074D20", Offset = "0x2073720", VA = "0x182074D20", Slot = "5")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = minimum_;
				return $"Has a minimum of '{num}' restaurant orders available";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001672")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60058B1")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001673")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionHasEnoughRestaurantOrders> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60058B3")]
			[Cpp2IlInjected.Address(RVA = "0x2074D90", Offset = "0x2073790", VA = "0x182074D90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001674")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60058B4")]
			[Cpp2IlInjected.Address(RVA = "0x2074C50", Offset = "0x2073650", VA = "0x182074C50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001675")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60058B5")]
			[Cpp2IlInjected.Address(RVA = "0x2074DF0", Offset = "0x20737F0", VA = "0x182074DF0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001676")]
		[DebuggerNonUserCode]
		public int Minimum
		{
			[Cpp2IlInjected.Token(Token = "0x60058B9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minimum_;
			}
			[Cpp2IlInjected.Token(Token = "0x60058BA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minimum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058AF")]
		[Cpp2IlInjected.Address(RVA = "0x20748A0", Offset = "0x20732A0", VA = "0x1820748A0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058B2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058B6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughRestaurantOrders()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60058B7")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughRestaurantOrders(ConditionHasEnoughRestaurantOrders other)
		{
			int num = (minimum_ = other.minimum_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058B8")]
		[Cpp2IlInjected.Address(RVA = "0x2074820", Offset = "0x2073220", VA = "0x182074820", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughRestaurantOrders Clone()
		{
			//Discarded unreachable code: IL_0029
			ConditionHasEnoughRestaurantOrders conditionHasEnoughRestaurantOrders = new ConditionHasEnoughRestaurantOrders();
			int num = (conditionHasEnoughRestaurantOrders.minimum_ = minimum_);
			UnknownFieldSet unknownFieldSet = (conditionHasEnoughRestaurantOrders._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionHasEnoughRestaurantOrders;
		}

		[Cpp2IlInjected.Token(Token = "0x60058BB")]
		[Cpp2IlInjected.Address(RVA = "0x2074920", Offset = "0x2073320", VA = "0x182074920", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minimum_ == (IntPtr)typeof(ConditionHasEnoughRestaurantOrders).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058BC")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionHasEnoughRestaurantOrders other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.minimum_;
				if (minimum_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058BD")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (minimum_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60058BE")]
		[Cpp2IlInjected.Address(RVA = "0x2074AE0", Offset = "0x20734E0", VA = "0x182074AE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60058BF")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (minimum_ != 0)
			{
				int value = minimum_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60058C0")]
		[Cpp2IlInjected.Address(RVA = "0x2074780", Offset = "0x2073180", VA = "0x182074780", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = minimum_;
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

		[Cpp2IlInjected.Token(Token = "0x60058C1")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionHasEnoughRestaurantOrders other)
		{
			if (other != null)
			{
				int num = other.minimum_;
				if (num != 0)
				{
					minimum_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (minimum_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058C3")]
		[Cpp2IlInjected.Address(RVA = "0x20749B0", Offset = "0x20733B0", VA = "0x1820749B0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = minimum_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058C4")]
		[Cpp2IlInjected.Address(RVA = "0x2074A60", Offset = "0x2073460", VA = "0x182074A60", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				minimum_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058C5")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				minimum_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058C6")]
		[Cpp2IlInjected.Address(RVA = "0x2074B40", Offset = "0x2073540", VA = "0x182074B40")]
		static ConditionHasEnoughRestaurantOrders()
		{
			Func<ConditionHasEnoughRestaurantOrders> func = default(Func<ConditionHasEnoughRestaurantOrders>);
			_parser = (MessageParser<ConditionHasEnoughRestaurantOrders>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058C7")]
		[Cpp2IlInjected.Address(RVA = "0x20748A0", Offset = "0x20732A0", VA = "0x1820748A0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}
	}
}
