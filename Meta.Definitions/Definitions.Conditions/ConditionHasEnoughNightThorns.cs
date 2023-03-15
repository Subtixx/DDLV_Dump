using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007FC")]
	public sealed class ConditionHasEnoughNightThorns : ICondition, IMessage<ConditionHasEnoughNightThorns>, IMessage, IEquatable<ConditionHasEnoughNightThorns>, IDeepCloneable<ConditionHasEnoughNightThorns>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027DD")]
		private static readonly MessageParser<ConditionHasEnoughNightThorns> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027DE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027DF")]
		public const int MinimumFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027E0")]
		private int minimum_;

		[Cpp2IlInjected.Token(Token = "0x1700166B")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005894")]
			[Cpp2IlInjected.Address(RVA = "0x20745A0", Offset = "0x2072FA0", VA = "0x1820745A0", Slot = "5")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = minimum_;
				return $"Has a minimum of '{num}' night thorns available";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166C")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005895")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166D")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionHasEnoughNightThorns> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005897")]
			[Cpp2IlInjected.Address(RVA = "0x2074610", Offset = "0x2073010", VA = "0x182074610")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005898")]
			[Cpp2IlInjected.Address(RVA = "0x20744D0", Offset = "0x2072ED0", VA = "0x1820744D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005899")]
			[Cpp2IlInjected.Address(RVA = "0x2074670", Offset = "0x2073070", VA = "0x182074670", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001670")]
		[DebuggerNonUserCode]
		public int Minimum
		{
			[Cpp2IlInjected.Token(Token = "0x600589D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minimum_;
			}
			[Cpp2IlInjected.Token(Token = "0x600589E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minimum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005893")]
		[Cpp2IlInjected.Address(RVA = "0x2074130", Offset = "0x2072B30", VA = "0x182074130")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005896")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600589A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughNightThorns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600589B")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughNightThorns(ConditionHasEnoughNightThorns other)
		{
			int num = (minimum_ = other.minimum_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600589C")]
		[Cpp2IlInjected.Address(RVA = "0x20740B0", Offset = "0x2072AB0", VA = "0x1820740B0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughNightThorns Clone()
		{
			//Discarded unreachable code: IL_0029
			ConditionHasEnoughNightThorns conditionHasEnoughNightThorns = new ConditionHasEnoughNightThorns();
			int num = (conditionHasEnoughNightThorns.minimum_ = minimum_);
			UnknownFieldSet unknownFieldSet = (conditionHasEnoughNightThorns._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionHasEnoughNightThorns;
		}

		[Cpp2IlInjected.Token(Token = "0x600589F")]
		[Cpp2IlInjected.Address(RVA = "0x20741A0", Offset = "0x2072BA0", VA = "0x1820741A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minimum_ == (IntPtr)typeof(ConditionHasEnoughNightThorns).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058A0")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionHasEnoughNightThorns other)
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

		[Cpp2IlInjected.Token(Token = "0x60058A1")]
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

		[Cpp2IlInjected.Token(Token = "0x60058A2")]
		[Cpp2IlInjected.Address(RVA = "0x2074360", Offset = "0x2072D60", VA = "0x182074360", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60058A3")]
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

		[Cpp2IlInjected.Token(Token = "0x60058A4")]
		[Cpp2IlInjected.Address(RVA = "0x2074010", Offset = "0x2072A10", VA = "0x182074010", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60058A5")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionHasEnoughNightThorns other)
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

		[Cpp2IlInjected.Token(Token = "0x60058A6")]
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

		[Cpp2IlInjected.Token(Token = "0x60058A7")]
		[Cpp2IlInjected.Address(RVA = "0x2074230", Offset = "0x2072C30", VA = "0x182074230", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x60058A8")]
		[Cpp2IlInjected.Address(RVA = "0x20742E0", Offset = "0x2072CE0", VA = "0x1820742E0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x60058A9")]
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

		[Cpp2IlInjected.Token(Token = "0x60058AA")]
		[Cpp2IlInjected.Address(RVA = "0x20743C0", Offset = "0x2072DC0", VA = "0x1820743C0")]
		static ConditionHasEnoughNightThorns()
		{
			Func<ConditionHasEnoughNightThorns> func = default(Func<ConditionHasEnoughNightThorns>);
			_parser = (MessageParser<ConditionHasEnoughNightThorns>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058AB")]
		[Cpp2IlInjected.Address(RVA = "0x2074130", Offset = "0x2072B30", VA = "0x182074130", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			IProfileWorld section = worldProfile.Section;
			throw new NullReferenceException();
		}
	}
}
