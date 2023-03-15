using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007F0")]
	public sealed class ConditionTimeOfDay : ICondition, IMessage<ConditionTimeOfDay>, IMessage, IEquatable<ConditionTimeOfDay>, IDeepCloneable<ConditionTimeOfDay>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027B3")]
		private static readonly MessageParser<ConditionTimeOfDay> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027B4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027B5")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027B6")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x40027B7")]
		public const int HourFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027B8")]
		private int hour_;

		[Cpp2IlInjected.Token(Token = "0x40027B9")]
		public const int MinuteFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027BA")]
		private int minute_;

		[Cpp2IlInjected.Token(Token = "0x40027BB")]
		public const int LocalTimeFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40027BC")]
		private bool localTime_;

		[Cpp2IlInjected.Token(Token = "0x17001640")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60057DC")]
			[Cpp2IlInjected.Address(RVA = "0x24C9EF0", Offset = "0x24C88F0", VA = "0x1824C9EF0", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0080
				//IL_003a: Expected O, but got I4
				//IL_0053: Expected O, but got I4
				object[] array;
				while (true)
				{
					array = new object[4];
					string text = Operations.ToString(operator_);
					if (text != null && text == null)
					{
						continue;
					}
					array[0] = text;
					int num = hour_;
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[1] = num;
					int num2 = minute_;
					num = num2;
					if (num2 == 0 || num2 != 0)
					{
						array[2] = num;
						if (!localTime_)
						{
						}
						if ("UTC" == null || num2 != 0)
						{
							break;
						}
					}
				}
				array[3] = "UTC";
				return string.Format("TimeOfDay {0} {1:D2}:{2:D2} ({3})", array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001641")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60057DD")]
			[Cpp2IlInjected.Address(RVA = "0x20BE250", Offset = "0x20BCC50", VA = "0x1820BE250", Slot = "6")]
			get
			{
				return ConditionListener.Time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001642")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionTimeOfDay> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60057DF")]
			[Cpp2IlInjected.Address(RVA = "0x24CA150", Offset = "0x24C8B50", VA = "0x1824CA150")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001643")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60057E0")]
			[Cpp2IlInjected.Address(RVA = "0x24C9E20", Offset = "0x24C8820", VA = "0x1824C9E20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001644")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60057E1")]
			[Cpp2IlInjected.Address(RVA = "0x24CA1B0", Offset = "0x24C8BB0", VA = "0x1824CA1B0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001645")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x60057E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057E6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001646")]
		[DebuggerNonUserCode]
		public int Hour
		{
			[Cpp2IlInjected.Token(Token = "0x60057E7")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return hour_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057E8")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				hour_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001647")]
		[DebuggerNonUserCode]
		public int Minute
		{
			[Cpp2IlInjected.Token(Token = "0x60057E9")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return minute_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057EA")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				minute_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001648")]
		[DebuggerNonUserCode]
		public bool LocalTime
		{
			[Cpp2IlInjected.Token(Token = "0x60057EB")]
			[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
			get
			{
				return localTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x60057EC")]
			[Cpp2IlInjected.Address(RVA = "0x1703720", Offset = "0x1702120", VA = "0x181703720")]
			set
			{
				localTime_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057DA")]
		[Cpp2IlInjected.Address(RVA = "0x24C9840", Offset = "0x24C8240", VA = "0x1824C9840")]
		private int GetTimeOfDay(IProfileWorld world, ITransactionContext context)
		{
			if (localTime_)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60057DB")]
		[Cpp2IlInjected.Address(RVA = "0x24C9590", Offset = "0x24C7F90", VA = "0x1824C9590")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0012
			IProfileWorld section = worldProfile.Section;
			if (localTime_)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60057DE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057E2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionTimeOfDay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60057E3")]
		[Cpp2IlInjected.Address(RVA = "0x24C9DC0", Offset = "0x24C87C0", VA = "0x1824C9DC0")]
		[DebuggerNonUserCode]
		public ConditionTimeOfDay(ConditionTimeOfDay other)
		{
			IntOperator intOperator = (operator_ = other.operator_);
			int num = (hour_ = other.hour_);
			int num2 = (minute_ = other.minute_);
			bool flag = (localTime_ = other.localTime_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60057E4")]
		[Cpp2IlInjected.Address(RVA = "0x24C9330", Offset = "0x24C7D30", VA = "0x1824C9330", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionTimeOfDay Clone()
		{
			//Discarded unreachable code: IL_0057
			ConditionTimeOfDay conditionTimeOfDay = new ConditionTimeOfDay();
			IntOperator intOperator = (conditionTimeOfDay.operator_ = operator_);
			int num = (conditionTimeOfDay.hour_ = hour_);
			int num2 = (conditionTimeOfDay.minute_ = minute_);
			bool flag = (conditionTimeOfDay.localTime_ = localTime_);
			UnknownFieldSet unknownFieldSet = (conditionTimeOfDay._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionTimeOfDay;
		}

		[Cpp2IlInjected.Token(Token = "0x60057ED")]
		[Cpp2IlInjected.Address(RVA = "0x24C94F0", Offset = "0x24C7EF0", VA = "0x1824C94F0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionTimeOfDay).TypeHandle && (IntPtr)hour_ == (IntPtr)typeof(ConditionTimeOfDay).TypeHandle && (IntPtr)minute_ == (IntPtr)typeof(ConditionTimeOfDay).TypeHandle && (IntPtr)(localTime_ ? 1 : 0) == (IntPtr)typeof(ConditionTimeOfDay).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057EE")]
		[Cpp2IlInjected.Address(RVA = "0x24C94A0", Offset = "0x24C7EA0", VA = "0x1824C94A0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionTimeOfDay other)
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
					int num = other.hour_;
					if (hour_ == num)
					{
						int num2 = other.minute_;
						if (minute_ == num2)
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
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057EF")]
		[Cpp2IlInjected.Address(RVA = "0x24C9780", Offset = "0x24C8180", VA = "0x1824C9780", Slot = "2")]
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
				if (hour_ != 0)
				{
				}
				if (minute_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x60057F0")]
		[Cpp2IlInjected.Address(RVA = "0x24C9B70", Offset = "0x24C8570", VA = "0x1824C9B70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60057F1")]
		[Cpp2IlInjected.Address(RVA = "0x24C9BD0", Offset = "0x24C85D0", VA = "0x1824C9BD0", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0061
			if (operator_ != 0)
			{
			}
			if (hour_ != 0)
			{
				int value = hour_;
				output.WriteInt32(value);
			}
			if (minute_ != 0)
			{
				int value2 = minute_;
				output.WriteInt32(value2);
			}
			if (localTime_)
			{
				bool value3 = localTime_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60057F2")]
		[Cpp2IlInjected.Address(RVA = "0x24C91E0", Offset = "0x24C7BE0", VA = "0x1824C91E0", Slot = "11")]
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
				int num3 = hour_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				int num5 = minute_;
				if (num5 != 0)
				{
					int num6 = CodedOutputStream.ComputeInt32Size(num5);
					num6++;
					num += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60057F3")]
		[Cpp2IlInjected.Address(RVA = "0x24C98D0", Offset = "0x24C82D0", VA = "0x1824C98D0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionTimeOfDay other)
		{
			if (other != null)
			{
				IntOperator intOperator = other.operator_;
				if (intOperator != 0)
				{
					operator_ = intOperator;
				}
				int num = other.hour_;
				if (num != 0)
				{
					hour_ = num;
				}
				int num2 = other.minute_;
				if (num2 != 0)
				{
					minute_ = num2;
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

		[Cpp2IlInjected.Token(Token = "0x60057F4")]
		[Cpp2IlInjected.Address(RVA = "0x24C9940", Offset = "0x24C8340", VA = "0x1824C9940", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0079
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (minute_ = input.ReadInt32());
				}
				if (num != 32)
				{
					goto IL_0062;
				}
				bool flag = (localTime_ = input.ReadBool());
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (int)(operator_ = (IntOperator)input.ReadInt32());
			}
			if (num3 == 16)
			{
				int num4 = (hour_ = input.ReadInt32());
			}
			goto IL_0062;
			IL_0062:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60057F5")]
		[Cpp2IlInjected.Address(RVA = "0x24C9660", Offset = "0x24C8060", VA = "0x1824C9660", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_0022;
				}
				bool flag = localTime_;
			}
			IntOperator intOperator = operator_;
			goto IL_0022;
			IL_0022:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057F6")]
		[Cpp2IlInjected.Address(RVA = "0x24C9A00", Offset = "0x24C8400", VA = "0x1824C9A00", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0035
			//IL_001b: Expected I4, but got O
			//IL_0023: Expected I4, but got O
			//IL_002b: Expected I4, but got O
			//IL_0034: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
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
						minute_ = (int)obj;
						break;
					}
					}
				}
				else
				{
					object obj3 = default(object);
					hour_ = (int)obj3;
				}
			}
			else
			{
				object obj4 = default(object);
				operator_ = (IntOperator)obj4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057F7")]
		[Cpp2IlInjected.Address(RVA = "0x24C92F0", Offset = "0x24C7CF0", VA = "0x1824C92F0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016, IL_0020
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			//IL_0029: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				localTime_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057F8")]
		[Cpp2IlInjected.Address(RVA = "0x24C9CB0", Offset = "0x24C86B0", VA = "0x1824C9CB0")]
		static ConditionTimeOfDay()
		{
			Func<ConditionTimeOfDay> func = default(Func<ConditionTimeOfDay>);
			_parser = (MessageParser<ConditionTimeOfDay>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60057F9")]
		[Cpp2IlInjected.Address(RVA = "0x24C93C0", Offset = "0x24C7DC0", VA = "0x1824C93C0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0012
			IProfileWorld section = worldProfile.Section;
			if (localTime_)
			{
			}
			bool result = default(bool);
			return result;
		}
	}
}
