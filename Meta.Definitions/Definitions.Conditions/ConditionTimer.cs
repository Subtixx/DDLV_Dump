using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000829")]
	public sealed class ConditionTimer : ICondition, IMessage<ConditionTimer>, IMessage, IEquatable<ConditionTimer>, IDeepCloneable<ConditionTimer>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400288C")]
		private static readonly MessageParser<ConditionTimer> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400288D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400288E")]
		public const int TimerTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400288F")]
		private ProfileTimerType timerType_;

		[Cpp2IlInjected.Token(Token = "0x4002890")]
		public const int OperatorFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002891")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x4002892")]
		public const int MinutesFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002893")]
		private int minutes_;

		[Cpp2IlInjected.Token(Token = "0x17001721")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005B6F")]
			[Cpp2IlInjected.Address(RVA = "0x24CAA70", Offset = "0x24C9470", VA = "0x1824CAA70", Slot = "5")]
			get
			{
				//IL_0027: Expected O, but got I4
				ProfileTimerType profileTimerType = timerType_;
				string text = Operations.ToString(operator_);
				int num = minutes_;
				return $"Timer {profileTimerType} {text} {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001722")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005B70")]
			[Cpp2IlInjected.Address(RVA = "0x20BE250", Offset = "0x20BCC50", VA = "0x1820BE250", Slot = "6")]
			get
			{
				return ConditionListener.Time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001723")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionTimer> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005B72")]
			[Cpp2IlInjected.Address(RVA = "0x24CAB30", Offset = "0x24C9530", VA = "0x1824CAB30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001724")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B73")]
			[Cpp2IlInjected.Address(RVA = "0x24CA9A0", Offset = "0x24C93A0", VA = "0x1824CA9A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001725")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B74")]
			[Cpp2IlInjected.Address(RVA = "0x24CAB90", Offset = "0x24C9590", VA = "0x1824CAB90", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001726")]
		[DebuggerNonUserCode]
		public ProfileTimerType TimerType
		{
			[Cpp2IlInjected.Token(Token = "0x6005B78")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return timerType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B79")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				timerType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001727")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005B7A")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B7B")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001728")]
		[DebuggerNonUserCode]
		public int Minutes
		{
			[Cpp2IlInjected.Token(Token = "0x6005B7C")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return minutes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B7D")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				minutes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B6E")]
		[Cpp2IlInjected.Address(RVA = "0x24CA450", Offset = "0x24C8E50", VA = "0x1824CA450")]
		public unsafe bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001f
			ProfileTimerType profileTimerType = timerType_;
			int num = 0;
			if ((long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile))
			{
				num += num;
				num++;
			}
			int num2 = (int)operator_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B71")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B75")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionTimer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B76")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public ConditionTimer(ConditionTimer other)
		{
			ProfileTimerType profileTimerType = (timerType_ = other.timerType_);
			IntOperator intOperator = (operator_ = other.operator_);
			int num = (minutes_ = other.minutes_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B77")]
		[Cpp2IlInjected.Address(RVA = "0x24CA3C0", Offset = "0x24C8DC0", VA = "0x1824CA3C0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionTimer Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionTimer conditionTimer = new ConditionTimer();
			ProfileTimerType profileTimerType = (conditionTimer.timerType_ = timerType_);
			IntOperator intOperator = (conditionTimer.operator_ = operator_);
			int num = (conditionTimer.minutes_ = minutes_);
			UnknownFieldSet unknownFieldSet = (conditionTimer._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionTimer;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B7E")]
		[Cpp2IlInjected.Address(RVA = "0x24CA580", Offset = "0x24C8F80", VA = "0x1824CA580", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)timerType_ == (IntPtr)typeof(ConditionTimer).TypeHandle && (IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionTimer).TypeHandle && (IntPtr)minutes_ == (IntPtr)typeof(ConditionTimer).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B7F")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionTimer other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ProfileTimerType profileTimerType = other.timerType_;
				if (timerType_ == profileTimerType)
				{
					IntOperator intOperator = other.operator_;
					if (operator_ == intOperator)
					{
						int num = other.minutes_;
						if (minutes_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6005B80")]
		[Cpp2IlInjected.Address(RVA = "0x2081110", Offset = "0x207FB10", VA = "0x182081110", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (timerType_ != 0)
				{
				}
				if (operator_ != 0)
				{
				}
				if (minutes_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B81")]
		[Cpp2IlInjected.Address(RVA = "0x24CA830", Offset = "0x24C9230", VA = "0x1824CA830", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B82")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003c
			if (timerType_ != 0)
			{
			}
			if (operator_ != 0)
			{
			}
			if (minutes_ != 0)
			{
				int value = minutes_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B83")]
		[Cpp2IlInjected.Address(RVA = "0x24CA2C0", Offset = "0x24C8CC0", VA = "0x1824CA2C0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ProfileTimerType profileTimerType = timerType_;
				num = 0;
				if (profileTimerType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)profileTimerType);
				}
				IntOperator intOperator = operator_;
				if (intOperator != 0)
				{
					int num3 = CodedOutputStream.ComputeEnumSize((int)intOperator);
					num3++;
					num += num3;
				}
				int num4 = minutes_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B84")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionTimer other)
		{
			if (other != null)
			{
				ProfileTimerType profileTimerType = other.timerType_;
				if (profileTimerType != 0)
				{
					timerType_ = profileTimerType;
				}
				IntOperator intOperator = other.operator_;
				if (intOperator != 0)
				{
					operator_ = intOperator;
				}
				int num = other.minutes_;
				if (num != 0)
				{
					minutes_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B85")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(timerType_ = (ProfileTimerType)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (int)(operator_ = (IntOperator)input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (minutes_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B86")]
		[Cpp2IlInjected.Address(RVA = "0x24CA620", Offset = "0x24C9020", VA = "0x1824CA620", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				ProfileTimerType profileTimerType = timerType_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B87")]
		[Cpp2IlInjected.Address(RVA = "0x24CA710", Offset = "0x24C9110", VA = "0x1824CA710", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					minutes_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					operator_ = (IntOperator)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				timerType_ = (ProfileTimerType)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B88")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				minutes_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B89")]
		[Cpp2IlInjected.Address(RVA = "0x24CA890", Offset = "0x24C9290", VA = "0x1824CA890")]
		static ConditionTimer()
		{
			Func<ConditionTimer> func = default(Func<ConditionTimer>);
			_parser = (MessageParser<ConditionTimer>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B8A")]
		[Cpp2IlInjected.Address(RVA = "0x24CA450", Offset = "0x24C8E50", VA = "0x1824CA450", Slot = "4")]
		unsafe bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001f
			ProfileTimerType profileTimerType = timerType_;
			int num = 0;
			if ((long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile))
			{
				num += num;
				num++;
			}
			int num2 = (int)operator_;
			bool result = default(bool);
			return result;
		}
	}
}
