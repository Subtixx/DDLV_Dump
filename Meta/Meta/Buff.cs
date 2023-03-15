using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000889")]
	public sealed class Buff : IMessage<Buff>, IMessage, IEquatable<Buff>, IDeepCloneable<Buff>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200088A")]
		public enum EndConditionOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4002258")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4002259")]
			EndTime = 4,
			[Cpp2IlInjected.Token(Token = "0x400225A")]
			NumberOfUsesLeft = 5
		}

		[Cpp2IlInjected.Token(Token = "0x4002249")]
		private static readonly MessageParser<Buff> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400224A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400224B")]
		public const int OriginFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400224C")]
		private BuffOrigin origin_;

		[Cpp2IlInjected.Token(Token = "0x400224D")]
		public const int TypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400224E")]
		private BuffType type_;

		[Cpp2IlInjected.Token(Token = "0x400224F")]
		public const int PercentageEffectFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002250")]
		private int percentageEffect_;

		[Cpp2IlInjected.Token(Token = "0x4002251")]
		public const int EndTimeFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4002252")]
		public const int NumberOfUsesLeftFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4002253")]
		public const int PersistenceFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002254")]
		private BuffPersistence persistence_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002255")]
		private object endCondition_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002256")]
		private EndConditionOneofCase endConditionCase_;

		[Cpp2IlInjected.Token(Token = "0x17000BFD")]
		[DebuggerNonUserCode]
		public static MessageParser<Buff> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600483C")]
			[Cpp2IlInjected.Address(RVA = "0x1AC4100", Offset = "0x1AC2B00", VA = "0x181AC4100")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600483D")]
			[Cpp2IlInjected.Address(RVA = "0x1AC3F60", Offset = "0x1AC2960", VA = "0x181AC3F60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600483E")]
			[Cpp2IlInjected.Address(RVA = "0x1AC4160", Offset = "0x1AC2B60", VA = "0x181AC4160", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C00")]
		[DebuggerNonUserCode]
		public BuffOrigin Origin
		{
			[Cpp2IlInjected.Token(Token = "0x6004842")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return origin_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004843")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				origin_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C01")]
		[DebuggerNonUserCode]
		public BuffType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004844")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004845")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C02")]
		[DebuggerNonUserCode]
		public int PercentageEffect
		{
			[Cpp2IlInjected.Token(Token = "0x6004846")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return percentageEffect_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004847")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				percentageEffect_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C03")]
		[DebuggerNonUserCode]
		public Timestamp EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6004848")]
			[Cpp2IlInjected.Address(RVA = "0x1AC4030", Offset = "0x1AC2A30", VA = "0x181AC4030")]
			get
			{
				int num = 0;
				if (endConditionCase_ == EndConditionOneofCase.EndTime)
				{
					object obj = endCondition_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004849")]
			[Cpp2IlInjected.Address(RVA = "0x1AC4270", Offset = "0x1AC2C70", VA = "0x181AC4270")]
			set
			{
				endCondition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C04")]
		[DebuggerNonUserCode]
		public int NumberOfUsesLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600484A")]
			[Cpp2IlInjected.Address(RVA = "0x1AC4090", Offset = "0x1AC2A90", VA = "0x181AC4090")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (endConditionCase_ == EndConditionOneofCase.NumberOfUsesLeft)
				{
					object obj = endCondition_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x600484B")]
			[Cpp2IlInjected.Address(RVA = "0x1AC42B0", Offset = "0x1AC2CB0", VA = "0x181AC42B0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				endCondition_ = typeof(int).TypeHandle;
				endConditionCase_ = EndConditionOneofCase.NumberOfUsesLeft;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C05")]
		[DebuggerNonUserCode]
		public BuffPersistence Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x600484C")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return persistence_;
			}
			[Cpp2IlInjected.Token(Token = "0x600484D")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				persistence_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C06")]
		[DebuggerNonUserCode]
		public EndConditionOneofCase EndConditionCase
		{
			[Cpp2IlInjected.Token(Token = "0x600484E")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return endConditionCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600483F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Buff()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004840")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3E50", Offset = "0x1AC2850", VA = "0x181AC3E50")]
		[DebuggerNonUserCode]
		public Buff(Buff other)
		{
			//IL_006c: Expected I4, but got O
			BuffOrigin buffOrigin = (origin_ = other.origin_);
			BuffType buffType = (type_ = other.type_);
			int num = (percentageEffect_ = other.percentageEffect_);
			BuffPersistence buffPersistence = (persistence_ = other.persistence_);
			EndConditionOneofCase endConditionOneofCase = other.endConditionCase_;
			if (endConditionOneofCase == EndConditionOneofCase.EndTime)
			{
				EndConditionOneofCase endConditionOneofCase2 = other.endConditionCase_;
				if (other.endCondition_ == null)
				{
					throw new InvalidCastException();
				}
				Timestamp timestamp = default(Timestamp);
				endCondition_ = timestamp;
				endConditionCase_ = (EndConditionOneofCase)timestamp;
			}
			if (endConditionOneofCase == EndConditionOneofCase.NumberOfUsesLeft)
			{
				int num2 = (NumberOfUsesLeft = other.NumberOfUsesLeft);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004841")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2E30", Offset = "0x1AC1830", VA = "0x181AC2E30", Slot = "10")]
		[DebuggerNonUserCode]
		public Buff Clone()
		{
			//Discarded unreachable code: IL_009a
			//IL_006e: Expected I4, but got O
			Buff buff = new Buff();
			BuffOrigin buffOrigin = (buff.origin_ = origin_);
			BuffType buffType = (buff.type_ = type_);
			int num = (buff.percentageEffect_ = percentageEffect_);
			BuffPersistence buffPersistence = (buff.persistence_ = persistence_);
			EndConditionOneofCase endConditionOneofCase = endConditionCase_;
			if (endConditionOneofCase == EndConditionOneofCase.EndTime)
			{
				EndConditionOneofCase endConditionOneofCase2 = endConditionCase_;
				if (endCondition_ == null)
				{
					throw new InvalidCastException();
				}
				Timestamp timestamp = default(Timestamp);
				buff.endCondition_ = timestamp;
				buff.endConditionCase_ = (EndConditionOneofCase)timestamp;
			}
			if (endConditionOneofCase == EndConditionOneofCase.NumberOfUsesLeft)
			{
				int num2 = (buff.NumberOfUsesLeft = NumberOfUsesLeft);
			}
			UnknownFieldSet unknownFieldSet = (buff._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return buff;
		}

		[Cpp2IlInjected.Token(Token = "0x600484F")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearEndCondition()
		{
			//IL_0010: Expected O, but got I4
			endCondition_ = (endConditionCase_ = EndConditionOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004850")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2F70", Offset = "0x1AC1970", VA = "0x181AC2F70", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			//IL_0073: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = default(Timestamp);
				if ((IntPtr)(void*)(int)origin_ == (IntPtr)typeof(Buff).TypeHandle && (IntPtr)(void*)(int)type_ == (IntPtr)typeof(Buff).TypeHandle && (IntPtr)percentageEffect_ == (IntPtr)typeof(Buff).TypeHandle && object.Equals(EndTime, objB))
				{
					int numberOfUsesLeft = NumberOfUsesLeft;
					int num = 0;
					int num2 = default(int);
					if (numberOfUsesLeft == num2 && persistence_ == (BuffPersistence)num2 && endConditionCase_ == (EndConditionOneofCase)num2)
					{
						return object.Equals(_unknownFields, num);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004851")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3090", Offset = "0x1AC1A90", VA = "0x181AC3090", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Buff other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				BuffOrigin buffOrigin = other.origin_;
				if (origin_ == buffOrigin)
				{
					BuffType buffType = other.type_;
					if (type_ == buffType)
					{
						int num = other.percentageEffect_;
						if (percentageEffect_ == num)
						{
							Timestamp endTime = EndTime;
							Timestamp endTime2 = other.EndTime;
							if (object.Equals(endTime, endTime2))
							{
								int numberOfUsesLeft = NumberOfUsesLeft;
								int numberOfUsesLeft2 = other.NumberOfUsesLeft;
								if (numberOfUsesLeft == numberOfUsesLeft2)
								{
									BuffPersistence buffPersistence = other.persistence_;
									if (persistence_ == buffPersistence)
									{
										EndConditionOneofCase endConditionOneofCase = other.endConditionCase_;
										if (endConditionCase_ == endConditionOneofCase)
										{
											UnknownFieldSet unknownFields = other._unknownFields;
											return object.Equals(_unknownFields, unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004852")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3300", Offset = "0x1AC1D00", VA = "0x181AC3300", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0075
			do
			{
				BuffOrigin buffOrigin = origin_;
				int num = 0;
				if (buffOrigin != 0)
				{
				}
				if (type_ != 0)
				{
				}
				if (percentageEffect_ != 0)
				{
				}
			}
			while (endConditionCase_ != EndConditionOneofCase.EndTime);
			object obj = endCondition_;
			if (obj != null)
			{
				int hashCode = obj.GetHashCode();
				if (endConditionCase_ == EndConditionOneofCase.NumberOfUsesLeft && endConditionCase_ == EndConditionOneofCase.NumberOfUsesLeft)
				{
					object obj2 = endCondition_;
				}
				if (persistence_ != 0)
				{
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode2 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004853")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3B60", Offset = "0x1AC2560", VA = "0x181AC3B60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004854")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3BC0", Offset = "0x1AC25C0", VA = "0x181AC3BC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007d
			do
			{
				if (origin_ != 0)
				{
				}
				if (type_ != 0)
				{
				}
				if (percentageEffect_ != 0)
				{
					int value = percentageEffect_;
					output.WriteInt32(value);
				}
			}
			while (endConditionCase_ != EndConditionOneofCase.EndTime);
			if (endConditionCase_ == EndConditionOneofCase.EndTime)
			{
				object obj = endCondition_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (endConditionCase_ == EndConditionOneofCase.NumberOfUsesLeft)
			{
				int numberOfUsesLeft = NumberOfUsesLeft;
				output.WriteInt32(numberOfUsesLeft);
			}
			if (persistence_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004855")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2AD0", Offset = "0x1AC14D0", VA = "0x181AC2AD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00e1
			BuffOrigin buffOrigin = origin_;
			int num = 0;
			if (buffOrigin != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)buffOrigin);
			}
			BuffType buffType = type_;
			if (buffType != 0)
			{
				int num3 = CodedOutputStream.ComputeEnumSize((int)buffType);
				num3++;
				num += num3;
			}
			int num4 = percentageEffect_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			if (endConditionCase_ == EndConditionOneofCase.EndTime)
			{
				if (endConditionCase_ != EndConditionOneofCase.EndTime)
				{
				}
				object obj = endCondition_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (endConditionCase_ == EndConditionOneofCase.NumberOfUsesLeft)
			{
				if (endConditionCase_ == EndConditionOneofCase.NumberOfUsesLeft)
				{
					object obj2 = endCondition_;
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			BuffPersistence buffPersistence = persistence_;
			if (buffPersistence != 0)
			{
				int num8 = CodedOutputStream.ComputeEnumSize((int)buffPersistence);
				num8++;
				num += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num += num9;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004856")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3710", Offset = "0x1AC2110", VA = "0x181AC3710", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Buff other)
		{
			if (other == null)
			{
				return;
			}
			BuffOrigin buffOrigin = other.origin_;
			if (buffOrigin != 0)
			{
				origin_ = buffOrigin;
			}
			BuffType buffType = other.type_;
			if (buffType != 0)
			{
				type_ = buffType;
			}
			int num = other.percentageEffect_;
			if (num != 0)
			{
				percentageEffect_ = num;
			}
			BuffPersistence buffPersistence = other.persistence_;
			if (buffPersistence != 0)
			{
				persistence_ = buffPersistence;
			}
			if (other.endConditionCase_ == EndConditionOneofCase.EndTime)
			{
				EndConditionOneofCase endConditionOneofCase = endConditionCase_;
				object obj = default(object);
				if (endConditionOneofCase == EndConditionOneofCase.EndTime)
				{
					obj = endCondition_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					Timestamp timestamp = (Timestamp)(endCondition_ = new Timestamp());
					endConditionCase_ = endConditionOneofCase;
				}
				if (endConditionCase_ == EndConditionOneofCase.EndTime)
				{
					object obj2 = endCondition_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.endConditionCase_ == EndConditionOneofCase.EndTime)
				{
					object obj3 = other.endCondition_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(Timestamp).TypeHandle == 5)
			{
				int num2 = (NumberOfUsesLeft = other.NumberOfUsesLeft);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004857")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3540", Offset = "0x1AC1F40", VA = "0x181AC3540", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 34)
				{
					Timestamp timestamp = new Timestamp();
					if (endConditionCase_ == EndConditionOneofCase.EndTime)
					{
						if (endConditionCase_ != EndConditionOneofCase.EndTime)
						{
						}
						object obj = endCondition_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(timestamp);
					endCondition_ = timestamp;
					endConditionCase_ = (EndConditionOneofCase)timestamp;
				}
				int num3 = default(int);
				if (num == 40)
				{
					num3 = (NumberOfUsesLeft = input.ReadInt32());
				}
				if (num3 != 48)
				{
					goto IL_00c7;
				}
				int num4 = (int)(persistence_ = (BuffPersistence)input.ReadInt32());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (int)(origin_ = (BuffOrigin)input.ReadInt32());
			}
			int num6 = default(int);
			if (num5 == 16)
			{
				num6 = (int)(type_ = (BuffType)input.ReadInt32());
			}
			if (num6 == 24)
			{
				int num7 = (percentageEffect_ = input.ReadInt32());
			}
			goto IL_00c7;
			IL_00c7:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004858")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3170", Offset = "0x1AC1B70", VA = "0x181AC3170", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				BuffOrigin buffOrigin = origin_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004859")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3920", Offset = "0x1AC2320", VA = "0x181AC3920", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0019
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				origin_ = (BuffOrigin)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600485A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2D10", Offset = "0x1AC1710", VA = "0x181AC2D10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022, IL_002c, IL_0036
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			//IL_003f: Expected I4, but got I8
			if (fieldNumber <= 5)
			{
				origin_ = BuffOrigin.Default;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600485B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3490", Offset = "0x1AC1E90", VA = "0x181AC3490", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "EndCondition"))
			{
				EndConditionOneofCase endConditionOneofCase = endConditionCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600485C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2DC0", Offset = "0x1AC17C0", VA = "0x181AC2DC0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "EndCondition"))
			{
				endCondition_ = (endConditionCase_ = EndConditionOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600485D")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3D40", Offset = "0x1AC2740", VA = "0x181AC3D40")]
		static Buff()
		{
			Func<Buff> func = default(Func<Buff>);
			_parser = (MessageParser<Buff>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
