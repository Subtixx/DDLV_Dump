using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class AnyFatigue : IFatigue, IMessage<AnyFatigue>, IMessage, IEquatable<AnyFatigue>, IDeepCloneable<AnyFatigue>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public enum FatigueOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			No,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			Frequency,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			Interval,
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			Limit
		}

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static readonly MessageParser<AnyFatigue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public const int NoFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public const int FrequencyFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public const int IntervalFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public const int LimitFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private object fatigue_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private FatigueOneofCase fatigueCase_;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public IFatigue DefaultFatigue
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x315F2A0", Offset = "0x315DCA0", VA = "0x18315F2A0")]
			get
			{
				NoFatigue _003CDefault_003Ek__BackingField = NoFatigue.Default;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[DebuggerNonUserCode]
		public static MessageParser<AnyFatigue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x315F5A0", Offset = "0x315DFA0", VA = "0x18315F5A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x315F340", Offset = "0x315DD40", VA = "0x18315F340")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x315F600", Offset = "0x315E000", VA = "0x18315F600", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[DebuggerNonUserCode]
		public NoFatigue No
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x315F540", Offset = "0x315DF40", VA = "0x18315F540")]
			get
			{
				int num = 0;
				if (fatigueCase_ == FatigueOneofCase.No)
				{
					object obj = fatigue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				fatigue_ = value;
				bool flag = (byte)(fatigueCase_ = ((value != null) ? FatigueOneofCase.No : FatigueOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[DebuggerNonUserCode]
		public FrequencyFatigue Frequency
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x315F420", Offset = "0x315DE20", VA = "0x18315F420")]
			get
			{
				int num = 0;
				if (fatigueCase_ == FatigueOneofCase.Frequency)
				{
					object obj = fatigue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				fatigue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[DebuggerNonUserCode]
		public IntervalFatigue Interval
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x315F480", Offset = "0x315DE80", VA = "0x18315F480")]
			get
			{
				int num = 0;
				if (fatigueCase_ == FatigueOneofCase.Interval)
				{
					object obj = fatigue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				fatigue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[DebuggerNonUserCode]
		public LimitFatigue Limit
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x315F4E0", Offset = "0x315DEE0", VA = "0x18315F4E0")]
			get
			{
				int num = 0;
				if (fatigueCase_ == FatigueOneofCase.Limit)
				{
					object obj = fatigue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				fatigue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[DebuggerNonUserCode]
		public FatigueOneofCase FatigueCase
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return fatigueCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[DebuggerNonUserCode]
		public IFatigue Fatigue
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x315F410", Offset = "0x315DE10", VA = "0x18315F410")]
			get
			{
				return GetFatigue();
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x315EAA0", Offset = "0x315D4A0", VA = "0x18315EAA0")]
			set
			{
				//IL_0026: Expected I4, but got I8
				//IL_0037: Expected I4, but got I8
				//IL_0048: Expected I4, but got I8
				//IL_0059: Expected I4, but got I8
				//IL_0068: Expected O, but got I4
				int num = 0;
				if (value != null)
				{
					if (value != null)
					{
						fatigue_ = value;
						fatigueCase_ = FatigueOneofCase.No;
						return;
					}
					if (value != null)
					{
						fatigue_ = value;
						fatigueCase_ = FatigueOneofCase.Frequency;
						return;
					}
					if (value != null)
					{
						fatigue_ = value;
						fatigueCase_ = FatigueOneofCase.Interval;
						return;
					}
					if (value != null)
					{
						fatigue_ = value;
						fatigueCase_ = FatigueOneofCase.Limit;
						return;
					}
				}
				fatigueCase_ = (FatigueOneofCase)num;
				fatigue_ = num;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x315DA70", Offset = "0x315C470", VA = "0x18315DA70", Slot = "4")]
		public bool CanRefresh(DateTime lastRefresh, DateTime now)
		{
			//Discarded unreachable code: IL_001e
			IFatigue fatigue = GetFatigue();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return fatigue.CanRefresh(lastRefresh, now);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x315E9E0", Offset = "0x315D3E0", VA = "0x18315E9E0", Slot = "5")]
		public DateTime NextAutoRefresh(DateTime now)
		{
			//Discarded unreachable code: IL_001d
			IFatigue fatigue = GetFatigue();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return fatigue.NextAutoRefresh(now);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AnyFatigue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x315F130", Offset = "0x315DB30", VA = "0x18315F130")]
		[DebuggerNonUserCode]
		public AnyFatigue(AnyFatigue other)
		{
			//IL_0037: Expected I4, but got O
			//IL_0051: Expected I4, but got O
			//IL_006b: Expected I4, but got O
			FatigueOneofCase fatigueOneofCase = other.fatigueCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (fatigueOneofCase != FatigueOneofCase.No)
						{
							goto IL_0092;
						}
						fatigueCase_ = (FatigueOneofCase)(fatigue_ = other.Limit.Clone());
					}
					fatigueCase_ = (FatigueOneofCase)(fatigue_ = other.Interval.Clone());
				}
				fatigueCase_ = (FatigueOneofCase)(fatigue_ = other.Frequency.Clone());
			}
			bool flag = (byte)(fatigueCase_ = (((fatigue_ = other.No.Clone()) != null) ? FatigueOneofCase.No : FatigueOneofCase.None)) != 0;
			goto IL_0092;
			IL_0092:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x315DBC0", Offset = "0x315C5C0", VA = "0x18315DBC0", Slot = "12")]
		[DebuggerNonUserCode]
		public AnyFatigue Clone()
		{
			//Discarded unreachable code: IL_00ac
			//IL_0037: Expected I4, but got O
			//IL_0051: Expected I4, but got O
			//IL_006e: Expected I4, but got O
			AnyFatigue anyFatigue = new AnyFatigue();
			FatigueOneofCase fatigueOneofCase = fatigueCase_;
			if (this != null)
			{
				if (this != null)
				{
					if (this != null)
					{
						if (fatigueOneofCase != FatigueOneofCase.No)
						{
							goto IL_0095;
						}
						anyFatigue.fatigueCase_ = (FatigueOneofCase)(anyFatigue.fatigue_ = Limit.Clone());
					}
					anyFatigue.fatigueCase_ = (FatigueOneofCase)(anyFatigue.fatigue_ = Interval.Clone());
				}
				anyFatigue.fatigueCase_ = (FatigueOneofCase)(anyFatigue.fatigue_ = Frequency.Clone());
			}
			bool flag = (byte)(anyFatigue.fatigueCase_ = (((anyFatigue.fatigue_ = No.Clone()) != null) ? FatigueOneofCase.No : FatigueOneofCase.None)) != 0;
			goto IL_0095;
			IL_0095:
			UnknownFieldSet unknownFieldSet = (anyFatigue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return anyFatigue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearFatigue()
		{
			//IL_0010: Expected O, but got I4
			fatigue_ = (fatigueCase_ = FatigueOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x315DF50", Offset = "0x315C950", VA = "0x18315DF50")]
		[DebuggerNonUserCode]
		public IFatigue GetFatigue()
		{
			if (fatigueCase_ != FatigueOneofCase.No)
			{
				NoFatigue _003CDefault_003Ek__BackingField = NoFatigue.Default;
			}
			LimitFatigue limit = Limit;
			IntervalFatigue interval = Interval;
			FrequencyFatigue frequency = Frequency;
			NoFatigue no = No;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x315EAA0", Offset = "0x315D4A0", VA = "0x18315EAA0")]
		[DebuggerNonUserCode]
		public void SetFatigue(IFatigue value)
		{
			//IL_0026: Expected I4, but got I8
			//IL_0037: Expected I4, but got I8
			//IL_0048: Expected I4, but got I8
			//IL_0059: Expected I4, but got I8
			//IL_0068: Expected O, but got I4
			int num = 0;
			if (value != null)
			{
				if (value != null)
				{
					fatigue_ = value;
					fatigueCase_ = FatigueOneofCase.No;
					return;
				}
				if (value != null)
				{
					fatigue_ = value;
					fatigueCase_ = FatigueOneofCase.Frequency;
					return;
				}
				if (value != null)
				{
					fatigue_ = value;
					fatigueCase_ = FatigueOneofCase.Interval;
					return;
				}
				if (value != null)
				{
					fatigue_ = value;
					fatigueCase_ = FatigueOneofCase.Limit;
					return;
				}
			}
			fatigueCase_ = (FatigueOneofCase)num;
			fatigue_ = num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x315DEF0", Offset = "0x315C8F0", VA = "0x18315DEF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((AnyFatigue)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x315DD60", Offset = "0x315C760", VA = "0x18315DD60", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(AnyFatigue other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (fatigueCase_ == FatigueOneofCase.No)
				{
					object obj = fatigue_;
					if (obj != null && obj == null)
					{
						goto IL_00d7;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.fatigueCase_ == FatigueOneofCase.No)
				{
					obj2 = other.fatigue_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					FrequencyFatigue frequency = Frequency;
					FrequencyFatigue frequency2 = other.Frequency;
					if (object.Equals(frequency, frequency2))
					{
						IntervalFatigue interval = Interval;
						IntervalFatigue interval2 = other.Interval;
						if (object.Equals(interval, interval2))
						{
							LimitFatigue limit = Limit;
							LimitFatigue limit2 = other.Limit;
							if (object.Equals(limit, limit2))
							{
								FatigueOneofCase fatigueOneofCase = other.fatigueCase_;
								if (fatigueCase_ == fatigueOneofCase)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									bool flag = object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00d7;
			IL_00d7:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x315E100", Offset = "0x315CB00", VA = "0x18315E100", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0092
			while (true)
			{
				FatigueOneofCase fatigueOneofCase = fatigueCase_;
				int num = 0;
				if (fatigueOneofCase == FatigueOneofCase.No)
				{
					object obj = fatigue_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (fatigueOneofCase != FatigueOneofCase.Frequency)
				{
					continue;
				}
				object obj2 = fatigue_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (fatigueCase_ != FatigueOneofCase.Interval)
					{
						continue;
					}
					object obj3 = fatigue_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (fatigueCase_ == FatigueOneofCase.Limit)
						{
							object obj4 = fatigue_;
							if (obj4 == null)
							{
								break;
							}
							int hashCode4 = obj4.GetHashCode();
						}
						UnknownFieldSet unknownFields = _unknownFields;
						if (unknownFields != null)
						{
							int hashCode5 = unknownFields.GetHashCode();
						}
						return 1;
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x315EDB0", Offset = "0x315D7B0", VA = "0x18315EDB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x315EE10", Offset = "0x315D810", VA = "0x18315EE10", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ac
			//IL_002f: Expected O, but got I4
			while (true)
			{
				FatigueOneofCase fatigueOneofCase = fatigueCase_;
				int num = 0;
				if (fatigueOneofCase == FatigueOneofCase.No)
				{
					if (fatigueCase_ == FatigueOneofCase.No)
					{
						object obj = fatigue_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (fatigueOneofCase != FatigueOneofCase.Frequency)
				{
					continue;
				}
				if (fatigueCase_ == FatigueOneofCase.Frequency)
				{
					object obj2 = fatigue_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				if (fatigueCase_ != FatigueOneofCase.Interval)
				{
					continue;
				}
				if (fatigueCase_ == FatigueOneofCase.Interval)
				{
					object obj3 = fatigue_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (fatigueCase_ == FatigueOneofCase.Limit && fatigueCase_ == FatigueOneofCase.Limit)
				{
					object obj4 = fatigue_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x315D820", Offset = "0x315C220", VA = "0x18315D820", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (fatigueCase_ == FatigueOneofCase.No)
			{
				if (fatigueCase_ == FatigueOneofCase.No)
				{
					object obj = fatigue_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (fatigueCase_ == FatigueOneofCase.Frequency)
			{
				if (fatigueCase_ != FatigueOneofCase.Frequency)
				{
				}
				object obj2 = fatigue_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (fatigueCase_ == FatigueOneofCase.Interval)
			{
				if (fatigueCase_ != FatigueOneofCase.Interval)
				{
				}
				object obj3 = fatigue_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (fatigueCase_ == FatigueOneofCase.Limit)
			{
				if (fatigueCase_ == FatigueOneofCase.Limit)
				{
					object obj4 = fatigue_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x315E760", Offset = "0x315D160", VA = "0x18315E760", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(AnyFatigue other)
		{
			//Discarded unreachable code: IL_012b
			//IL_0041: Expected I4, but got O
			//IL_0076: Expected I4, but got O
			//IL_00af: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			FatigueOneofCase fatigueOneofCase = other.fatigueCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (fatigueOneofCase != FatigueOneofCase.No)
						{
							goto IL_010b;
						}
						if (Limit == null)
						{
							fatigueCase_ = (FatigueOneofCase)(fatigue_ = new LimitFatigue());
						}
						LimitFatigue limit = Limit;
						LimitFatigue limit2 = other.Limit;
						limit.MergeFrom(limit2);
					}
					if (Interval == null)
					{
						fatigueCase_ = (FatigueOneofCase)(fatigue_ = new IntervalFatigue());
					}
					IntervalFatigue interval = Interval;
					IntervalFatigue interval2 = other.Interval;
					interval.MergeFrom(interval2);
				}
				if (Frequency == null)
				{
					fatigueCase_ = (FatigueOneofCase)(fatigue_ = new FrequencyFatigue());
				}
				FrequencyFatigue frequency = Frequency;
				FrequencyFatigue frequency2 = other.Frequency;
				frequency.MergeFrom(frequency2);
			}
			if (No == null)
			{
				bool flag = (byte)(fatigueCase_ = (((fatigue_ = new NoFatigue()) != null) ? FatigueOneofCase.No : FatigueOneofCase.None)) != 0;
			}
			NoFatigue no = No;
			NoFatigue no2 = other.No;
			no.MergeFrom(no2);
			goto IL_010b;
			IL_010b:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x315E3C0", Offset = "0x315CDC0", VA = "0x18315E3C0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00ac: Expected I4, but got O
			//IL_014d: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					IntervalFatigue intervalFatigue = new IntervalFatigue();
					if (fatigueCase_ == FatigueOneofCase.Interval)
					{
						if (fatigueCase_ != FatigueOneofCase.Interval)
						{
						}
						object obj = fatigue_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(intervalFatigue);
					fatigue_ = intervalFatigue;
					fatigueCase_ = (FatigueOneofCase)intervalFatigue;
				}
				if (num != 34)
				{
					goto IL_014d;
				}
				LimitFatigue builder = new LimitFatigue();
				if (fatigueCase_ == FatigueOneofCase.Limit)
				{
					if (fatigueCase_ != FatigueOneofCase.Limit)
					{
					}
					object obj2 = fatigue_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				fatigue_ = builder;
				fatigueCase_ = (FatigueOneofCase)typeof(LimitFatigue).TypeHandle;
			}
			bool flag = default(bool);
			if (num == 10)
			{
				NoFatigue noFatigue = new NoFatigue();
				if (fatigueCase_ == FatigueOneofCase.No)
				{
					if (fatigueCase_ != FatigueOneofCase.No)
					{
					}
					object obj3 = fatigue_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(noFatigue);
				fatigue_ = noFatigue;
				flag = (byte)(fatigueCase_ = ((noFatigue != null) ? FatigueOneofCase.No : FatigueOneofCase.None)) != 0;
			}
			if (flag)
			{
				FrequencyFatigue builder2 = new FrequencyFatigue();
				if (fatigueCase_ == FatigueOneofCase.Frequency)
				{
					if (fatigueCase_ != FatigueOneofCase.Frequency)
					{
					}
					object obj4 = fatigue_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				fatigue_ = builder2;
				fatigueCase_ = (FatigueOneofCase)typeof(FrequencyFatigue).TypeHandle;
			}
			goto IL_014d;
			IL_014d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x315E040", Offset = "0x315CA40", VA = "0x18315E040", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				LimitFatigue limit = Limit;
				IntervalFatigue interval = Interval;
				FrequencyFatigue frequency = Frequency;
				NoFatigue no = No;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x315EBE0", Offset = "0x315D5E0", VA = "0x18315EBE0", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_002b: Expected O, but got I4
			//IL_0036: Expected I4, but got O
			//IL_0051: Expected I4, but got O
			//IL_006c: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							fatigue_ = num2;
							fatigueCase_ = (FatigueOneofCase)typeof(NoFatigue).TypeHandle;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
						if (value == null || value != null)
						{
							fatigue_ = value;
							fatigueCase_ = (FatigueOneofCase)typeof(NoFatigue).TypeHandle;
							break;
						}
						throw new InvalidCastException();
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					fatigue_ = value;
					fatigueCase_ = (FatigueOneofCase)typeof(NoFatigue).TypeHandle;
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				fatigue_ = value;
				bool flag = (byte)(fatigueCase_ = ((value != null) ? FatigueOneofCase.No : FatigueOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x27B3340", Offset = "0x27B1D40", VA = "0x1827B3340", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				fatigue_ = num;
				fatigueCase_ = (FatigueOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x315E310", Offset = "0x315CD10", VA = "0x18315E310", Slot = "16")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "fatigue"))
			{
				FatigueOneofCase fatigueOneofCase = fatigueCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x315DB50", Offset = "0x315C550", VA = "0x18315DB50", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "fatigue"))
			{
				fatigue_ = (fatigueCase_ = FatigueOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x315F020", Offset = "0x315DA20", VA = "0x18315F020")]
		static AnyFatigue()
		{
			Func<AnyFatigue> func = default(Func<AnyFatigue>);
			_parser = (MessageParser<AnyFatigue>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
