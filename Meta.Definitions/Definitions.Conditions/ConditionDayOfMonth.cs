using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007EE")]
	public sealed class ConditionDayOfMonth : ICondition, IMessage<ConditionDayOfMonth>, IMessage, IEquatable<ConditionDayOfMonth>, IDeepCloneable<ConditionDayOfMonth>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027AA")]
		private static readonly MessageParser<ConditionDayOfMonth> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027AB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027AC")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027AD")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x40027AE")]
		public const int DayFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027AF")]
		private int day_;

		[Cpp2IlInjected.Token(Token = "0x40027B0")]
		public const int LocalTimeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027B1")]
		private bool localTime_;

		[Cpp2IlInjected.Token(Token = "0x17001638")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60057BB")]
			[Cpp2IlInjected.Address(RVA = "0x321AE90", Offset = "0x3219890", VA = "0x18321AE90", Slot = "5")]
			get
			{
				string text = Operations.ToString(operator_);
				int num = day_;
				if (!localTime_)
				{
				}
				return string.Format("DayOMonth {0} {1} ({2})", text, text, "Local");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001639")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60057BC")]
			[Cpp2IlInjected.Address(RVA = "0x20BE250", Offset = "0x20BCC50", VA = "0x1820BE250", Slot = "6")]
			get
			{
				return ConditionListener.Time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163A")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionDayOfMonth> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60057BE")]
			[Cpp2IlInjected.Address(RVA = "0x321AF40", Offset = "0x3219940", VA = "0x18321AF40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60057BF")]
			[Cpp2IlInjected.Address(RVA = "0x321ADC0", Offset = "0x32197C0", VA = "0x18321ADC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60057C0")]
			[Cpp2IlInjected.Address(RVA = "0x321AFA0", Offset = "0x32199A0", VA = "0x18321AFA0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163D")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x60057C4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057C5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163E")]
		[DebuggerNonUserCode]
		public int Day
		{
			[Cpp2IlInjected.Token(Token = "0x60057C6")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return day_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057C7")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				day_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163F")]
		[DebuggerNonUserCode]
		public bool LocalTime
		{
			[Cpp2IlInjected.Token(Token = "0x60057C8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return localTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057C9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				localTime_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057B9")]
		[Cpp2IlInjected.Address(RVA = "0x321A9A0", Offset = "0x32193A0", VA = "0x18321A9A0")]
		private int GetDayOfMonth(IProfileWorld world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_000b
			if (localTime_)
			{
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60057BA")]
		[Cpp2IlInjected.Address(RVA = "0x321A8E0", Offset = "0x32192E0", VA = "0x18321A8E0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			IProfileWorld section = worldProfile.Section;
			if (localTime_)
			{
			}
			int protobufValue = day_;
			IntOperator intOperator = operator_;
			int profileValue = default(int);
			return Operations.Evaluate(profileValue, intOperator, protobufValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60057BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057C1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionDayOfMonth()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60057C2")]
		[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
		[DebuggerNonUserCode]
		public ConditionDayOfMonth(ConditionDayOfMonth other)
		{
			IntOperator intOperator = (operator_ = other.operator_);
			int num = (day_ = other.day_);
			bool flag = (localTime_ = other.localTime_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60057C3")]
		[Cpp2IlInjected.Address(RVA = "0x321A6F0", Offset = "0x32190F0", VA = "0x18321A6F0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionDayOfMonth Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionDayOfMonth conditionDayOfMonth = new ConditionDayOfMonth();
			IntOperator intOperator = (conditionDayOfMonth.operator_ = operator_);
			int num = (conditionDayOfMonth.day_ = day_);
			bool flag = (conditionDayOfMonth.localTime_ = localTime_);
			UnknownFieldSet unknownFieldSet = (conditionDayOfMonth._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionDayOfMonth;
		}

		[Cpp2IlInjected.Token(Token = "0x60057CA")]
		[Cpp2IlInjected.Address(RVA = "0x321A840", Offset = "0x3219240", VA = "0x18321A840", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionDayOfMonth).TypeHandle && (IntPtr)day_ == (IntPtr)typeof(ConditionDayOfMonth).TypeHandle && (IntPtr)(localTime_ ? 1 : 0) == (IntPtr)typeof(ConditionDayOfMonth).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057CB")]
		[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionDayOfMonth other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				IntOperator intOperator = other.operator_;
				if (operator_ == intOperator)
				{
					int num = other.day_;
					if (day_ == num)
					{
						bool flag = other.localTime_;
						if (localTime_ == flag)
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

		[Cpp2IlInjected.Token(Token = "0x60057CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EC90", Offset = "0x1E0D690", VA = "0x181E0EC90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (operator_ != 0)
				{
				}
				if (day_ != 0)
				{
				}
				if (localTime_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60057CD")]
		[Cpp2IlInjected.Address(RVA = "0x321AC50", Offset = "0x3219650", VA = "0x18321AC50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60057CE")]
		[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			if (operator_ != 0)
			{
			}
			if (day_ != 0)
			{
				int value = day_;
				output.WriteInt32(value);
			}
			if (localTime_)
			{
				bool value2 = localTime_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60057CF")]
		[Cpp2IlInjected.Address(RVA = "0x321A620", Offset = "0x3219020", VA = "0x18321A620", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				IntOperator intOperator = operator_;
				num = 0;
				if (intOperator != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)intOperator);
				}
				int num3 = day_;
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

		[Cpp2IlInjected.Token(Token = "0x60057D0")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionDayOfMonth other)
		{
			if (other != null)
			{
				IntOperator intOperator = other.operator_;
				if (intOperator != 0)
				{
					operator_ = intOperator;
				}
				int num = other.day_;
				if (num != 0)
				{
					day_ = num;
				}
				bool flag = other.localTime_;
				if (flag)
				{
					localTime_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057D1")]
		[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(operator_ = (IntOperator)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (day_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					bool flag = (localTime_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057D2")]
		[Cpp2IlInjected.Address(RVA = "0x321AA20", Offset = "0x3219420", VA = "0x18321AA20", Slot = "15")]
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
				bool flag = localTime_;
			}
			IntOperator intOperator = operator_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057D3")]
		[Cpp2IlInjected.Address(RVA = "0x321AB30", Offset = "0x3219530", VA = "0x18321AB30", Slot = "16")]
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
					localTime_ = (byte)(int)obj2 != 0;
					break;
				}
				case 0:
				{
					object obj = default(object);
					day_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				operator_ = (IntOperator)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057D4")]
		[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				localTime_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057D5")]
		[Cpp2IlInjected.Address(RVA = "0x321ACB0", Offset = "0x32196B0", VA = "0x18321ACB0")]
		static ConditionDayOfMonth()
		{
			Func<ConditionDayOfMonth> func = default(Func<ConditionDayOfMonth>);
			_parser = (MessageParser<ConditionDayOfMonth>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057D6")]
		[Cpp2IlInjected.Address(RVA = "0x321A780", Offset = "0x3219180", VA = "0x18321A780", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			IProfileWorld section = worldProfile.Section;
			if (localTime_)
			{
			}
			int protobufValue = day_;
			IntOperator intOperator = operator_;
			int profileValue = default(int);
			return Operations.Evaluate(profileValue, intOperator, protobufValue);
		}
	}
}
