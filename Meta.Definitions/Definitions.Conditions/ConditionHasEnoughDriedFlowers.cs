using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007FA")]
	public sealed class ConditionHasEnoughDriedFlowers : ICondition, IMessage<ConditionHasEnoughDriedFlowers>, IMessage, IEquatable<ConditionHasEnoughDriedFlowers>, IDeepCloneable<ConditionHasEnoughDriedFlowers>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027D8")]
		private static readonly MessageParser<ConditionHasEnoughDriedFlowers> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027D9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027DA")]
		public const int MinimumFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027DB")]
		private int minimum_;

		[Cpp2IlInjected.Token(Token = "0x17001665")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005878")]
			[Cpp2IlInjected.Address(RVA = "0x2073E30", Offset = "0x2072830", VA = "0x182073E30", Slot = "5")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = minimum_;
				return $"Has a minimum of '{num}' dried flowers available";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001666")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005879")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001667")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionHasEnoughDriedFlowers> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600587B")]
			[Cpp2IlInjected.Address(RVA = "0x2073EA0", Offset = "0x20728A0", VA = "0x182073EA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001668")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600587C")]
			[Cpp2IlInjected.Address(RVA = "0x2073D60", Offset = "0x2072760", VA = "0x182073D60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001669")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600587D")]
			[Cpp2IlInjected.Address(RVA = "0x2073F00", Offset = "0x2072900", VA = "0x182073F00", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166A")]
		[DebuggerNonUserCode]
		public int Minimum
		{
			[Cpp2IlInjected.Token(Token = "0x6005881")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minimum_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005882")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minimum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005877")]
		[Cpp2IlInjected.Address(RVA = "0x20739C0", Offset = "0x20723C0", VA = "0x1820739C0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600587A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600587E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughDriedFlowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600587F")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughDriedFlowers(ConditionHasEnoughDriedFlowers other)
		{
			int num = (minimum_ = other.minimum_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005880")]
		[Cpp2IlInjected.Address(RVA = "0x2073940", Offset = "0x2072340", VA = "0x182073940", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughDriedFlowers Clone()
		{
			//Discarded unreachable code: IL_0029
			ConditionHasEnoughDriedFlowers conditionHasEnoughDriedFlowers = new ConditionHasEnoughDriedFlowers();
			int num = (conditionHasEnoughDriedFlowers.minimum_ = minimum_);
			UnknownFieldSet unknownFieldSet = (conditionHasEnoughDriedFlowers._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionHasEnoughDriedFlowers;
		}

		[Cpp2IlInjected.Token(Token = "0x6005883")]
		[Cpp2IlInjected.Address(RVA = "0x2073A30", Offset = "0x2072430", VA = "0x182073A30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minimum_ == (IntPtr)typeof(ConditionHasEnoughDriedFlowers).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005884")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionHasEnoughDriedFlowers other)
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

		[Cpp2IlInjected.Token(Token = "0x6005885")]
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

		[Cpp2IlInjected.Token(Token = "0x6005886")]
		[Cpp2IlInjected.Address(RVA = "0x2073BF0", Offset = "0x20725F0", VA = "0x182073BF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005887")]
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

		[Cpp2IlInjected.Token(Token = "0x6005888")]
		[Cpp2IlInjected.Address(RVA = "0x20738A0", Offset = "0x20722A0", VA = "0x1820738A0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6005889")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionHasEnoughDriedFlowers other)
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

		[Cpp2IlInjected.Token(Token = "0x600588A")]
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

		[Cpp2IlInjected.Token(Token = "0x600588B")]
		[Cpp2IlInjected.Address(RVA = "0x2073AC0", Offset = "0x20724C0", VA = "0x182073AC0", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x600588C")]
		[Cpp2IlInjected.Address(RVA = "0x2073B70", Offset = "0x2072570", VA = "0x182073B70", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x600588D")]
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

		[Cpp2IlInjected.Token(Token = "0x600588E")]
		[Cpp2IlInjected.Address(RVA = "0x2073C50", Offset = "0x2072650", VA = "0x182073C50")]
		static ConditionHasEnoughDriedFlowers()
		{
			Func<ConditionHasEnoughDriedFlowers> func = default(Func<ConditionHasEnoughDriedFlowers>);
			_parser = (MessageParser<ConditionHasEnoughDriedFlowers>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600588F")]
		[Cpp2IlInjected.Address(RVA = "0x20739C0", Offset = "0x20723C0", VA = "0x1820739C0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}
	}
}
