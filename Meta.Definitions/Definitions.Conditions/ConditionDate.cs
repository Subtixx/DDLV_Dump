using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007BF")]
	public sealed class ConditionDate : IDateCondition, ICondition, IMessage<ConditionDate>, IMessage, IEquatable<ConditionDate>, IDeepCloneable<ConditionDate>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40026AD")]
		private static readonly MessageParser<ConditionDate> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40026AE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40026AF")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40026B0")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x40026B1")]
		public const int DateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40026B2")]
		private Timestamp date_;

		[Cpp2IlInjected.Token(Token = "0x40026B3")]
		public const int LocalTimeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40026B4")]
		private bool localTime_;

		[Cpp2IlInjected.Token(Token = "0x1700157C")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005529")]
			[Cpp2IlInjected.Address(RVA = "0x321A430", Offset = "0x3218E30", VA = "0x18321A430", Slot = "7")]
			get
			{
				string arg = Operations.ToString(operator_);
				if (!localTime_)
				{
				}
				Timestamp arg2 = date_;
				return string.Format("Date {0} {1} ({2})", arg, arg2, "Local");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700157D")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600552A")]
			[Cpp2IlInjected.Address(RVA = "0x20BE250", Offset = "0x20BCC50", VA = "0x1820BE250", Slot = "8")]
			get
			{
				return ConditionListener.Time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700157E")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionDate> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600552C")]
			[Cpp2IlInjected.Address(RVA = "0x321A4B0", Offset = "0x3218EB0", VA = "0x18321A4B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700157F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600552D")]
			[Cpp2IlInjected.Address(RVA = "0x321A360", Offset = "0x3218D60", VA = "0x18321A360")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001580")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600552E")]
			[Cpp2IlInjected.Address(RVA = "0x321A510", Offset = "0x3218F10", VA = "0x18321A510", Slot = "14")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001581")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005532")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005533")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001582")]
		[DebuggerNonUserCode]
		public Timestamp Date
		{
			[Cpp2IlInjected.Token(Token = "0x6005534")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return date_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005535")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				date_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001583")]
		[DebuggerNonUserCode]
		public bool LocalTime
		{
			[Cpp2IlInjected.Token(Token = "0x6005536")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return localTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005537")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				localTime_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005525")]
		[Cpp2IlInjected.Address(RVA = "0x3219E30", Offset = "0x3218830", VA = "0x183219E30")]
		public bool HasStartDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime startDate)
		{
			if (operator_ > IntOperator.NotEqual)
			{
				int num = 0;
			}
			DateTime dateTime = date_.ToDateTime();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005526")]
		[Cpp2IlInjected.Address(RVA = "0x3219D90", Offset = "0x3218790", VA = "0x183219D90")]
		public bool HasEndDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime endDate)
		{
			if (operator_ > IntOperator.NotEqual)
			{
				int num = 0;
			}
			DateTime dateTime = date_.ToDateTime();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005527")]
		[Cpp2IlInjected.Address(RVA = "0x3219C20", Offset = "0x3218620", VA = "0x183219C20")]
		private DateTime GetDate(IProfileWorld world, ITransactionContext context)
		{
			if (localTime_)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005528")]
		[Cpp2IlInjected.Address(RVA = "0x3219960", Offset = "0x3218360", VA = "0x183219960")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0028
			IProfileWorld section = worldProfile.Section;
			if (localTime_)
			{
			}
			Timestamp timestamp = date_;
			IntOperator intOperator = operator_;
			DateTime dateTime = timestamp.ToDateTime();
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600552B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600552F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionDate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005530")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9E0", Offset = "0x5C93E0", VA = "0x1805CA9E0")]
		[DebuggerNonUserCode]
		public ConditionDate(ConditionDate other)
		{
			//IL_002f: Expected O, but got I4
			IntOperator intOperator = (operator_ = other.operator_);
			Timestamp timestamp = other.date_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			date_ = (Timestamp)num;
			bool flag = (localTime_ = other.localTime_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005531")]
		[Cpp2IlInjected.Address(RVA = "0x32198B0", Offset = "0x32182B0", VA = "0x1832198B0", Slot = "16")]
		[DebuggerNonUserCode]
		public ConditionDate Clone()
		{
			//Discarded unreachable code: IL_0058
			//IL_0031: Expected O, but got I4
			ConditionDate conditionDate = new ConditionDate();
			IntOperator intOperator = (conditionDate.operator_ = operator_);
			Timestamp timestamp = date_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			conditionDate.date_ = (Timestamp)num;
			bool flag = (conditionDate.localTime_ = localTime_);
			UnknownFieldSet unknownFieldSet = (conditionDate._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionDate;
		}

		[Cpp2IlInjected.Token(Token = "0x6005538")]
		[Cpp2IlInjected.Address(RVA = "0x3219B60", Offset = "0x3218560", VA = "0x183219B60", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionDate).TypeHandle)
				{
					bool flag = object.Equals(date_, other);
					if (flag && localTime_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005539")]
		[Cpp2IlInjected.Address(RVA = "0x5CA1B0", Offset = "0x5C8BB0", VA = "0x1805CA1B0", Slot = "15")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionDate other)
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
					Timestamp objB = other.date_;
					if (object.Equals(date_, objB))
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600553A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA3F0", Offset = "0x5C8DF0", VA = "0x1805CA3F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (operator_ != 0)
				{
				}
				Timestamp timestamp = date_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				if (localTime_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600553B")]
		[Cpp2IlInjected.Address(RVA = "0x321A1F0", Offset = "0x3218BF0", VA = "0x18321A1F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600553C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA820", Offset = "0x5C9220", VA = "0x1805CA820", Slot = "12")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004c
			if (operator_ != 0)
			{
			}
			if ((long)date_ != 0)
			{
				Timestamp value = date_;
				output.WriteMessage(value);
			}
			if (localTime_)
			{
				bool value2 = localTime_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600553D")]
		[Cpp2IlInjected.Address(RVA = "0x32197D0", Offset = "0x32181D0", VA = "0x1832197D0", Slot = "13")]
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
				Timestamp timestamp = date_;
				if (timestamp != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(timestamp);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600553E")]
		[Cpp2IlInjected.Address(RVA = "0x3219FE0", Offset = "0x32189E0", VA = "0x183219FE0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionDate other)
		{
			//Discarded unreachable code: IL_0084
			if (other == null)
			{
				return;
			}
			IntOperator intOperator = other.operator_;
			if (intOperator != 0)
			{
				operator_ = intOperator;
			}
			if ((long)other.date_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (date_ == null)
				{
					Timestamp timestamp = (date_ = new Timestamp());
					timestamp2 = date_;
				}
				Timestamp other2 = other.date_;
				timestamp2.MergeFrom(other2);
			}
			bool flag = other.localTime_;
			if (flag)
			{
				localTime_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600553F")]
		[Cpp2IlInjected.Address(RVA = "0x3219ED0", Offset = "0x32188D0", VA = "0x183219ED0", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0076
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(operator_ = (IntOperator)input.ReadInt32());
			}
			Timestamp timestamp = default(Timestamp);
			if (num2 == 18)
			{
				Timestamp builder = default(Timestamp);
				if (date_ == null)
				{
					timestamp = (date_ = new Timestamp());
					builder = date_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 24)
			{
				bool flag = (localTime_ = input.ReadBool());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005540")]
		[Cpp2IlInjected.Address(RVA = "0x3219C90", Offset = "0x3218690", VA = "0x183219C90", Slot = "17")]
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
					bool flag = localTime_;
				}
				Timestamp timestamp = date_;
			}
			IntOperator intOperator = operator_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005541")]
		[Cpp2IlInjected.Address(RVA = "0x321A0C0", Offset = "0x3218AC0", VA = "0x18321A0C0", Slot = "18")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002f
			//IL_0017: Expected I4, but got O
			//IL_002e: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					localTime_ = (byte)(int)obj != 0;
					return;
				}
				default:
					return;
				case 0:
					break;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				date_ = (Timestamp)value;
			}
			object obj2 = default(object);
			operator_ = (IntOperator)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005542")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0D0", Offset = "0x5C8AD0", VA = "0x1805CA0D0", Slot = "19")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				localTime_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005543")]
		[Cpp2IlInjected.Address(RVA = "0x321A250", Offset = "0x3218C50", VA = "0x18321A250")]
		static ConditionDate()
		{
			Func<ConditionDate> func = default(Func<ConditionDate>);
			_parser = (MessageParser<ConditionDate>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005544")]
		[Cpp2IlInjected.Address(RVA = "0x3219AC0", Offset = "0x32184C0", VA = "0x183219AC0", Slot = "4")]
		bool IDateCondition.HasStartDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime startDate)
		{
			if (operator_ > IntOperator.NotEqual)
			{
				int num = 0;
			}
			DateTime dateTime = date_.ToDateTime();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005545")]
		[Cpp2IlInjected.Address(RVA = "0x3219A20", Offset = "0x3218420", VA = "0x183219A20", Slot = "5")]
		bool IDateCondition.HasEndDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime endDate)
		{
			if (operator_ > IntOperator.NotEqual)
			{
				int num = 0;
			}
			DateTime dateTime = date_.ToDateTime();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005546")]
		[Cpp2IlInjected.Address(RVA = "0x3219960", Offset = "0x3218360", VA = "0x183219960", Slot = "6")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0028
			IProfileWorld section = worldProfile.Section;
			if (localTime_)
			{
			}
			Timestamp timestamp = date_;
			IntOperator intOperator = operator_;
			DateTime dateTime = timestamp.ToDateTime();
			bool result = default(bool);
			return result;
		}
	}
}
