using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007C1")]
	public sealed class ConditionDayOfWeek : IDateCondition, ICondition, IMessage<ConditionDayOfWeek>, IMessage, IEquatable<ConditionDayOfWeek>, IDeepCloneable<ConditionDayOfWeek>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20007C2")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20007C3")]
			public enum DayOfWeek
			{
				[Cpp2IlInjected.Token(Token = "0x40026BF")]
				[OriginalName("DayOfWeek_Sunday")]
				Sunday,
				[Cpp2IlInjected.Token(Token = "0x40026C0")]
				[OriginalName("DayOfWeek_Monday")]
				Monday,
				[Cpp2IlInjected.Token(Token = "0x40026C1")]
				[OriginalName("DayOfWeek_Tuesday")]
				Tuesday,
				[Cpp2IlInjected.Token(Token = "0x40026C2")]
				[OriginalName("DayOfWeek_Wednesday")]
				Wednesday,
				[Cpp2IlInjected.Token(Token = "0x40026C3")]
				[OriginalName("DayOfWeek_Thursday")]
				Thursday,
				[Cpp2IlInjected.Token(Token = "0x40026C4")]
				[OriginalName("DayOfWeek_Friday")]
				Friday,
				[Cpp2IlInjected.Token(Token = "0x40026C5")]
				[OriginalName("DayOfWeek_Saturday")]
				Saturday
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40026B6")]
		private static readonly MessageParser<ConditionDayOfWeek> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40026B7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40026B8")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40026B9")]
		private EqualOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x40026BA")]
		public const int DayFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40026BB")]
		private Types.DayOfWeek day_;

		[Cpp2IlInjected.Token(Token = "0x40026BC")]
		public const int LocalTimeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40026BD")]
		private bool localTime_;

		[Cpp2IlInjected.Token(Token = "0x17001584")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005550")]
			[Cpp2IlInjected.Address(RVA = "0x321BDF0", Offset = "0x321A7F0", VA = "0x18321BDF0", Slot = "7")]
			get
			{
				string text = Operations.ToString(operator_);
				Types.DayOfWeek dayOfWeek = day_;
				if (!localTime_)
				{
				}
				return string.Format("DayOfWeek {0} {1} ({2})", text, text, "Local");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001585")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005551")]
			[Cpp2IlInjected.Address(RVA = "0x20BE250", Offset = "0x20BCC50", VA = "0x1820BE250", Slot = "8")]
			get
			{
				return ConditionListener.Time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001586")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionDayOfWeek> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005553")]
			[Cpp2IlInjected.Address(RVA = "0x321BEA0", Offset = "0x321A8A0", VA = "0x18321BEA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001587")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005554")]
			[Cpp2IlInjected.Address(RVA = "0x321BD20", Offset = "0x321A720", VA = "0x18321BD20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001588")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005555")]
			[Cpp2IlInjected.Address(RVA = "0x321BF00", Offset = "0x321A900", VA = "0x18321BF00", Slot = "14")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001589")]
		[DebuggerNonUserCode]
		public EqualOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005559")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x600555A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700158A")]
		[DebuggerNonUserCode]
		public Types.DayOfWeek Day
		{
			[Cpp2IlInjected.Token(Token = "0x600555B")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return day_;
			}
			[Cpp2IlInjected.Token(Token = "0x600555C")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				day_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700158B")]
		[DebuggerNonUserCode]
		public bool LocalTime
		{
			[Cpp2IlInjected.Token(Token = "0x600555D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return localTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x600555E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				localTime_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600554A")]
		[Cpp2IlInjected.Address(RVA = "0x321BA60", Offset = "0x321A460", VA = "0x18321BA60")]
		private int PreviousDayOfWeek(DateTime now)
		{
			Types.DayOfWeek dayOfWeek = day_;
			DayOfWeek dayOfWeek2 = default(DayOfWeek);
			dayOfWeek = (Types.DayOfWeek)((int)dayOfWeek - (int)dayOfWeek2);
			int result = (int)dayOfWeek;
			if (dayOfWeek > Types.DayOfWeek.Sunday)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600554B")]
		[Cpp2IlInjected.Address(RVA = "0x321BA30", Offset = "0x321A430", VA = "0x18321BA30")]
		private int NextDayOfWeek(DateTime now)
		{
			Types.DayOfWeek dayOfWeek = day_;
			DayOfWeek dayOfWeek2 = default(DayOfWeek);
			return (int)dayOfWeek - (int)dayOfWeek2;
		}

		[Cpp2IlInjected.Token(Token = "0x600554C")]
		[Cpp2IlInjected.Address(RVA = "0x321B8E0", Offset = "0x321A2E0", VA = "0x18321B8E0")]
		public bool HasStartDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime startDate)
		{
			if (localTime_)
			{
			}
			if (operator_ != 0)
			{
				if (!Evaluate(in playerProfile, in worldProfile, context))
				{
				}
				Types.DayOfWeek dayOfWeek = day_;
				DayOfWeek dayOfWeek2 = default(DayOfWeek);
				dayOfWeek = (Types.DayOfWeek)((int)dayOfWeek - (int)dayOfWeek2);
				int num = default(int);
				if (dayOfWeek > Types.DayOfWeek.Sunday)
				{
					num = (int)dayOfWeek2;
				}
				num++;
			}
			Types.DayOfWeek dayOfWeek3 = day_;
			int num2 = 0;
			DayOfWeek dayOfWeek4 = default(DayOfWeek);
			dayOfWeek3 = (Types.DayOfWeek)((int)dayOfWeek3 - (int)dayOfWeek4);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600554D")]
		[Cpp2IlInjected.Address(RVA = "0x321B790", Offset = "0x321A190", VA = "0x18321B790")]
		public bool HasEndDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime endDate)
		{
			if (localTime_)
			{
			}
			if (operator_ != 0)
			{
				if (!Evaluate(in playerProfile, in worldProfile, context))
				{
				}
				Types.DayOfWeek dayOfWeek = day_;
				DayOfWeek dayOfWeek2 = default(DayOfWeek);
				dayOfWeek = (Types.DayOfWeek)((int)dayOfWeek - (int)dayOfWeek2);
			}
			Types.DayOfWeek dayOfWeek3 = day_;
			int num = 0;
			DayOfWeek dayOfWeek4 = default(DayOfWeek);
			dayOfWeek3 = (Types.DayOfWeek)((int)dayOfWeek3 - (int)dayOfWeek4);
			int num2 = num2 + 1;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600554E")]
		[Cpp2IlInjected.Address(RVA = "0x321B600", Offset = "0x321A000", VA = "0x18321B600")]
		private int GetDayOfWeek(IProfileWorld world, ITransactionContext context)
		{
			if (localTime_)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600554F")]
		[Cpp2IlInjected.Address(RVA = "0x321B540", Offset = "0x3219F40", VA = "0x18321B540")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0014
			IProfileWorld section = worldProfile.Section;
			if (localTime_)
			{
			}
			DayOfWeek dayOfWeek = default(DayOfWeek);
			int num = (int)dayOfWeek;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005552")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005556")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionDayOfWeek()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005557")]
		[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
		[DebuggerNonUserCode]
		public ConditionDayOfWeek(ConditionDayOfWeek other)
		{
			EqualOperator equalOperator = (operator_ = other.operator_);
			Types.DayOfWeek dayOfWeek = (day_ = other.day_);
			bool flag = (localTime_ = other.localTime_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005558")]
		[Cpp2IlInjected.Address(RVA = "0x321B180", Offset = "0x3219B80", VA = "0x18321B180", Slot = "16")]
		[DebuggerNonUserCode]
		public ConditionDayOfWeek Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionDayOfWeek conditionDayOfWeek = new ConditionDayOfWeek();
			EqualOperator equalOperator = (conditionDayOfWeek.operator_ = operator_);
			Types.DayOfWeek dayOfWeek = (conditionDayOfWeek.day_ = day_);
			bool flag = (conditionDayOfWeek.localTime_ = localTime_);
			UnknownFieldSet unknownFieldSet = (conditionDayOfWeek._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionDayOfWeek;
		}

		[Cpp2IlInjected.Token(Token = "0x600555F")]
		[Cpp2IlInjected.Address(RVA = "0x321B4A0", Offset = "0x3219EA0", VA = "0x18321B4A0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionDayOfWeek).TypeHandle && (IntPtr)(void*)(int)day_ == (IntPtr)typeof(ConditionDayOfWeek).TypeHandle && (IntPtr)(localTime_ ? 1 : 0) == (IntPtr)typeof(ConditionDayOfWeek).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005560")]
		[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "15")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionDayOfWeek other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				EqualOperator equalOperator = other.operator_;
				if (operator_ == equalOperator)
				{
					Types.DayOfWeek dayOfWeek = other.day_;
					if (day_ == dayOfWeek)
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

		[Cpp2IlInjected.Token(Token = "0x6005561")]
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

		[Cpp2IlInjected.Token(Token = "0x6005562")]
		[Cpp2IlInjected.Address(RVA = "0x321BBB0", Offset = "0x321A5B0", VA = "0x18321BBB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005563")]
		[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "12")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003c
			if (operator_ != 0)
			{
			}
			if (day_ != 0)
			{
			}
			if (localTime_)
			{
				bool value = localTime_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005564")]
		[Cpp2IlInjected.Address(RVA = "0x321B0B0", Offset = "0x3219AB0", VA = "0x18321B0B0", Slot = "13")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				EqualOperator equalOperator = operator_;
				num = 0;
				if (equalOperator != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)equalOperator);
				}
				Types.DayOfWeek dayOfWeek = day_;
				if (dayOfWeek != 0)
				{
					int num3 = CodedOutputStream.ComputeEnumSize((int)dayOfWeek);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005565")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionDayOfWeek other)
		{
			if (other != null)
			{
				EqualOperator equalOperator = other.operator_;
				if (equalOperator != 0)
				{
					operator_ = equalOperator;
				}
				Types.DayOfWeek dayOfWeek = other.day_;
				if (dayOfWeek != 0)
				{
					day_ = dayOfWeek;
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

		[Cpp2IlInjected.Token(Token = "0x6005566")]
		[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(operator_ = (EqualOperator)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (int)(day_ = (Types.DayOfWeek)input.ReadInt32());
				}
				if (num3 == 24)
				{
					bool flag = (localTime_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005567")]
		[Cpp2IlInjected.Address(RVA = "0x321B680", Offset = "0x321A080", VA = "0x18321B680", Slot = "17")]
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
			EqualOperator equalOperator = operator_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005568")]
		[Cpp2IlInjected.Address(RVA = "0x321BA90", Offset = "0x321A490", VA = "0x18321BA90", Slot = "18")]
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
					day_ = (Types.DayOfWeek)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				operator_ = (EqualOperator)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005569")]
		[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "19")]
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

		[Cpp2IlInjected.Token(Token = "0x600556A")]
		[Cpp2IlInjected.Address(RVA = "0x321BC10", Offset = "0x321A610", VA = "0x18321BC10")]
		static ConditionDayOfWeek()
		{
			Func<ConditionDayOfWeek> func = default(Func<ConditionDayOfWeek>);
			_parser = (MessageParser<ConditionDayOfWeek>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600556B")]
		[Cpp2IlInjected.Address(RVA = "0x321B360", Offset = "0x3219D60", VA = "0x18321B360", Slot = "4")]
		bool IDateCondition.HasStartDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime startDate)
		{
			if (localTime_)
			{
			}
			if (operator_ != 0)
			{
				if (!Evaluate(in playerProfile, in worldProfile, context))
				{
				}
				Types.DayOfWeek dayOfWeek = day_;
				DayOfWeek dayOfWeek2 = default(DayOfWeek);
				dayOfWeek = (Types.DayOfWeek)((int)dayOfWeek - (int)dayOfWeek2);
				int num = default(int);
				if (dayOfWeek > Types.DayOfWeek.Sunday)
				{
					num = (int)dayOfWeek2;
				}
				num++;
			}
			Types.DayOfWeek dayOfWeek3 = day_;
			int num2 = 0;
			DayOfWeek dayOfWeek4 = default(DayOfWeek);
			dayOfWeek3 = (Types.DayOfWeek)((int)dayOfWeek3 - (int)dayOfWeek4);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600556C")]
		[Cpp2IlInjected.Address(RVA = "0x321B220", Offset = "0x3219C20", VA = "0x18321B220", Slot = "5")]
		bool IDateCondition.HasEndDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime endDate)
		{
			if (localTime_)
			{
			}
			if (operator_ != 0)
			{
				if (!Evaluate(in playerProfile, in worldProfile, context))
				{
				}
				Types.DayOfWeek dayOfWeek = day_;
				DayOfWeek dayOfWeek2 = default(DayOfWeek);
				dayOfWeek = (Types.DayOfWeek)((int)dayOfWeek - (int)dayOfWeek2);
			}
			Types.DayOfWeek dayOfWeek3 = day_;
			int num = 0;
			DayOfWeek dayOfWeek4 = default(DayOfWeek);
			dayOfWeek3 = (Types.DayOfWeek)((int)dayOfWeek3 - (int)dayOfWeek4);
			int num2 = num2 + 1;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600556D")]
		[Cpp2IlInjected.Address(RVA = "0x321B210", Offset = "0x3219C10", VA = "0x18321B210", Slot = "6")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			return Evaluate(in playerProfile, in worldProfile, context);
		}
	}
}
