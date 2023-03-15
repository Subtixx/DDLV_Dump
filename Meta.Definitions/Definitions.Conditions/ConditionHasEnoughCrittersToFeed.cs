using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007F8")]
	public sealed class ConditionHasEnoughCrittersToFeed : ICondition, IMessage<ConditionHasEnoughCrittersToFeed>, IMessage, IEquatable<ConditionHasEnoughCrittersToFeed>, IDeepCloneable<ConditionHasEnoughCrittersToFeed>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027D3")]
		private static readonly MessageParser<ConditionHasEnoughCrittersToFeed> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027D4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027D5")]
		public const int MinimumFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027D6")]
		private int minimum_;

		[Cpp2IlInjected.Token(Token = "0x1700165F")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600585C")]
			[Cpp2IlInjected.Address(RVA = "0x20736C0", Offset = "0x20720C0", VA = "0x1820736C0", Slot = "5")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = minimum_;
				return $"Has a minimum of '{num}' critters to feed";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001660")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600585D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001661")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionHasEnoughCrittersToFeed> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600585F")]
			[Cpp2IlInjected.Address(RVA = "0x2073730", Offset = "0x2072130", VA = "0x182073730")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001662")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005860")]
			[Cpp2IlInjected.Address(RVA = "0x20735F0", Offset = "0x2071FF0", VA = "0x1820735F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001663")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005861")]
			[Cpp2IlInjected.Address(RVA = "0x2073790", Offset = "0x2072190", VA = "0x182073790", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001664")]
		[DebuggerNonUserCode]
		public int Minimum
		{
			[Cpp2IlInjected.Token(Token = "0x6005865")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minimum_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005866")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minimum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600585B")]
		[Cpp2IlInjected.Address(RVA = "0x2073240", Offset = "0x2071C40", VA = "0x182073240")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600585E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005862")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughCrittersToFeed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005863")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughCrittersToFeed(ConditionHasEnoughCrittersToFeed other)
		{
			int num = (minimum_ = other.minimum_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005864")]
		[Cpp2IlInjected.Address(RVA = "0x20731C0", Offset = "0x2071BC0", VA = "0x1820731C0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughCrittersToFeed Clone()
		{
			//Discarded unreachable code: IL_0029
			ConditionHasEnoughCrittersToFeed conditionHasEnoughCrittersToFeed = new ConditionHasEnoughCrittersToFeed();
			int num = (conditionHasEnoughCrittersToFeed.minimum_ = minimum_);
			UnknownFieldSet unknownFieldSet = (conditionHasEnoughCrittersToFeed._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionHasEnoughCrittersToFeed;
		}

		[Cpp2IlInjected.Token(Token = "0x6005867")]
		[Cpp2IlInjected.Address(RVA = "0x20732C0", Offset = "0x2071CC0", VA = "0x1820732C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minimum_ == (IntPtr)typeof(ConditionHasEnoughCrittersToFeed).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005868")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionHasEnoughCrittersToFeed other)
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

		[Cpp2IlInjected.Token(Token = "0x6005869")]
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

		[Cpp2IlInjected.Token(Token = "0x600586A")]
		[Cpp2IlInjected.Address(RVA = "0x2073480", Offset = "0x2071E80", VA = "0x182073480", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600586B")]
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

		[Cpp2IlInjected.Token(Token = "0x600586C")]
		[Cpp2IlInjected.Address(RVA = "0x2073120", Offset = "0x2071B20", VA = "0x182073120", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x600586D")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionHasEnoughCrittersToFeed other)
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

		[Cpp2IlInjected.Token(Token = "0x600586E")]
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

		[Cpp2IlInjected.Token(Token = "0x600586F")]
		[Cpp2IlInjected.Address(RVA = "0x2073350", Offset = "0x2071D50", VA = "0x182073350", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x6005870")]
		[Cpp2IlInjected.Address(RVA = "0x2073400", Offset = "0x2071E00", VA = "0x182073400", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x6005871")]
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

		[Cpp2IlInjected.Token(Token = "0x6005872")]
		[Cpp2IlInjected.Address(RVA = "0x20734E0", Offset = "0x2071EE0", VA = "0x1820734E0")]
		static ConditionHasEnoughCrittersToFeed()
		{
			Func<ConditionHasEnoughCrittersToFeed> func = default(Func<ConditionHasEnoughCrittersToFeed>);
			_parser = (MessageParser<ConditionHasEnoughCrittersToFeed>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005873")]
		[Cpp2IlInjected.Address(RVA = "0x2073240", Offset = "0x2071C40", VA = "0x182073240", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}
	}
}
