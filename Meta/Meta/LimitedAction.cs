using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007DF")]
	public sealed class LimitedAction : IMessage<LimitedAction>, IMessage, IEquatable<LimitedAction>, IDeepCloneable<LimitedAction>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001F4F")]
		private static readonly MessageParser<LimitedAction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F50")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F51")]
		public const int FirstActionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F52")]
		private Timestamp firstAction_;

		[Cpp2IlInjected.Token(Token = "0x4001F53")]
		public const int LastActionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F54")]
		private Timestamp lastAction_;

		[Cpp2IlInjected.Token(Token = "0x4001F55")]
		public const int FatigueFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F56")]
		private AnyFatigue fatigue_;

		[Cpp2IlInjected.Token(Token = "0x4001F57")]
		public const int CountFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001F58")]
		private int count_;

		[Cpp2IlInjected.Token(Token = "0x4001F59")]
		public const int MaxCountFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001F5A")]
		private int maxCount_;

		[Cpp2IlInjected.Token(Token = "0x17000A7C")]
		[DebuggerNonUserCode]
		public static MessageParser<LimitedAction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600411D")]
			[Cpp2IlInjected.Address(RVA = "0x18A5140", Offset = "0x18A3B40", VA = "0x1818A5140")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A7D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600411E")]
			[Cpp2IlInjected.Address(RVA = "0x18A5070", Offset = "0x18A3A70", VA = "0x1818A5070")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A7E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600411F")]
			[Cpp2IlInjected.Address(RVA = "0x18A51A0", Offset = "0x18A3BA0", VA = "0x1818A51A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A7F")]
		[DebuggerNonUserCode]
		public Timestamp FirstAction
		{
			[Cpp2IlInjected.Token(Token = "0x6004124")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return firstAction_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004125")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				firstAction_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A80")]
		[DebuggerNonUserCode]
		public Timestamp LastAction
		{
			[Cpp2IlInjected.Token(Token = "0x6004126")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return lastAction_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004127")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				lastAction_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A81")]
		[DebuggerNonUserCode]
		public AnyFatigue Fatigue
		{
			[Cpp2IlInjected.Token(Token = "0x6004128")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return fatigue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004129")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				fatigue_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A82")]
		[DebuggerNonUserCode]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600412A")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return count_;
			}
			[Cpp2IlInjected.Token(Token = "0x600412B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				count_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A83")]
		[DebuggerNonUserCode]
		public int MaxCount
		{
			[Cpp2IlInjected.Token(Token = "0x600412C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return maxCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600412D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				maxCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004120")]
		[Cpp2IlInjected.Address(RVA = "0x18A4D90", Offset = "0x18A3790", VA = "0x1818A4D90")]
		[DebuggerNonUserCode]
		public LimitedAction()
		{
			//IL_002b: Expected I4, but got I8
			AnyFatigue anyFatigue = new AnyFatigue();
			int num = 0;
			FrequencyFatigue frequencyFatigue = (FrequencyFatigue)(anyFatigue.Fatigue = FrequencyFatigue.CreateDefault);
			fatigue_ = anyFatigue;
			maxCount_ = 1;
			Timestamp timestamp = (firstAction_ = new Timestamp());
			Timestamp timestamp2 = (lastAction_ = new Timestamp());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004121")]
		[Cpp2IlInjected.Address(RVA = "0x18A4860", Offset = "0x18A3260", VA = "0x1818A4860")]
		private void OnConstruction()
		{
			//IL_0025: Expected I4, but got I8
			AnyFatigue anyFatigue = new AnyFatigue();
			int num = 0;
			FrequencyFatigue frequencyFatigue = (FrequencyFatigue)(anyFatigue.Fatigue = FrequencyFatigue.CreateDefault);
			fatigue_ = anyFatigue;
			maxCount_ = 1;
			Timestamp timestamp = (firstAction_ = new Timestamp());
			Timestamp timestamp2 = (lastAction_ = new Timestamp());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004122")]
		[Cpp2IlInjected.Address(RVA = "0x18A4EA0", Offset = "0x18A38A0", VA = "0x1818A4EA0")]
		[DebuggerNonUserCode]
		public LimitedAction(LimitedAction other)
		{
			//IL_002b: Expected I4, but got I8
			//IL_0068: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			AnyFatigue anyFatigue = new AnyFatigue();
			int num = 0;
			FrequencyFatigue frequencyFatigue = (FrequencyFatigue)(anyFatigue.Fatigue = FrequencyFatigue.CreateDefault);
			fatigue_ = anyFatigue;
			maxCount_ = 1;
			Timestamp timestamp = (firstAction_ = new Timestamp());
			Timestamp timestamp2 = (lastAction_ = new Timestamp());
			Timestamp timestamp3 = other.firstAction_;
			int num2 = 0;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			firstAction_ = (Timestamp)num2;
			Timestamp timestamp5 = other.lastAction_;
			if (timestamp5 != null)
			{
				Timestamp timestamp6 = timestamp5.Clone();
			}
			lastAction_ = (Timestamp)num2;
			AnyFatigue anyFatigue2 = other.fatigue_;
			AnyFatigue anyFatigue3 = default(AnyFatigue);
			if (anyFatigue2 != null)
			{
				anyFatigue3 = anyFatigue2.Clone();
			}
			fatigue_ = anyFatigue3;
			int num3 = (count_ = other.count_);
			int num4 = (maxCount_ = other.maxCount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004123")]
		[Cpp2IlInjected.Address(RVA = "0x18A3E00", Offset = "0x18A2800", VA = "0x1818A3E00", Slot = "10")]
		[DebuggerNonUserCode]
		public LimitedAction Clone()
		{
			return new LimitedAction(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600412E")]
		[Cpp2IlInjected.Address(RVA = "0x18A3F00", Offset = "0x18A2900", VA = "0x1818A3F00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(firstAction_, other) && object.Equals(lastAction_, other))
				{
					bool flag = object.Equals(fatigue_, other);
					if (flag && count_ == (flag ? 1 : 0) && maxCount_ == (flag ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600412F")]
		[Cpp2IlInjected.Address(RVA = "0x18A3E60", Offset = "0x18A2860", VA = "0x1818A3E60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LimitedAction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.firstAction_;
				if (object.Equals(firstAction_, objB))
				{
					Timestamp objB2 = other.lastAction_;
					if (object.Equals(lastAction_, objB2))
					{
						AnyFatigue objB3 = other.fatigue_;
						if (object.Equals(fatigue_, objB3))
						{
							int num = other.count_;
							if (count_ == num)
							{
								int num2 = other.maxCount_;
								if (maxCount_ == num2)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004130")]
		[Cpp2IlInjected.Address(RVA = "0x18A43E0", Offset = "0x18A2DE0", VA = "0x1818A43E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = firstAction_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				Timestamp timestamp2 = lastAction_;
				if (timestamp2 != null)
				{
					int hashCode2 = timestamp2.GetHashCode();
				}
				AnyFatigue anyFatigue = fatigue_;
				if (anyFatigue != null)
				{
					int hashCode3 = anyFatigue.GetHashCode();
				}
				if (count_ != 0)
				{
				}
				if (maxCount_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004131")]
		[Cpp2IlInjected.Address(RVA = "0x18A4B10", Offset = "0x18A3510", VA = "0x1818A4B10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004132")]
		[Cpp2IlInjected.Address(RVA = "0x18A4B70", Offset = "0x18A3570", VA = "0x1818A4B70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0091
			if ((long)firstAction_ != 0)
			{
				Timestamp value = firstAction_;
				output.WriteMessage(value);
			}
			if ((long)lastAction_ != 0)
			{
				Timestamp value2 = lastAction_;
				output.WriteMessage(value2);
			}
			if ((long)fatigue_ != 0)
			{
				AnyFatigue value3 = fatigue_;
				output.WriteMessage(value3);
			}
			if (count_ != 0)
			{
				int value4 = count_;
				output.WriteInt32(value4);
			}
			if (maxCount_ != 0)
			{
				int value5 = maxCount_;
				output.WriteInt32(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004133")]
		[Cpp2IlInjected.Address(RVA = "0x18A3B60", Offset = "0x18A2560", VA = "0x1818A3B60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = firstAction_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				}
				Timestamp timestamp2 = lastAction_;
				if (timestamp2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(timestamp2);
					num3++;
					num += num3;
				}
				AnyFatigue anyFatigue = fatigue_;
				if (anyFatigue != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(anyFatigue);
					num4++;
					num += num4;
				}
				int num5 = count_;
				if (num5 != 0)
				{
					int num6 = CodedOutputStream.ComputeInt32Size(num5);
					num6++;
					num += num6;
				}
				int num7 = maxCount_;
				if (num7 != 0)
				{
					int num8 = CodedOutputStream.ComputeInt32Size(num7);
					num8++;
					num += num8;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num9 = unknownFields.CalculateSize();
			return num9 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004134")]
		[Cpp2IlInjected.Address(RVA = "0x18A46D0", Offset = "0x18A30D0", VA = "0x1818A46D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LimitedAction other)
		{
			//Discarded unreachable code: IL_0101
			if (other == null)
			{
				return;
			}
			if ((long)other.firstAction_ != 0)
			{
				Timestamp timestamp = firstAction_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (firstAction_ = new Timestamp());
					Timestamp timestamp3 = firstAction_;
				}
				Timestamp other2 = other.firstAction_;
				timestamp.MergeFrom(other2);
			}
			if ((long)other.lastAction_ != 0)
			{
				Timestamp timestamp5 = default(Timestamp);
				if (lastAction_ == null)
				{
					Timestamp timestamp4 = (lastAction_ = new Timestamp());
					timestamp5 = lastAction_;
				}
				Timestamp other3 = other.lastAction_;
				timestamp5.MergeFrom(other3);
			}
			if ((long)other.fatigue_ != 0)
			{
				AnyFatigue anyFatigue2 = default(AnyFatigue);
				if (fatigue_ == null)
				{
					AnyFatigue anyFatigue = (fatigue_ = new AnyFatigue());
					anyFatigue2 = fatigue_;
				}
				AnyFatigue other4 = other.fatigue_;
				anyFatigue2.MergeFrom(other4);
			}
			int num = other.count_;
			if (num != 0)
			{
				count_ = num;
			}
			int num2 = other.maxCount_;
			if (num2 != 0)
			{
				maxCount_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004135")]
		[Cpp2IlInjected.Address(RVA = "0x18A4510", Offset = "0x18A2F10", VA = "0x1818A4510", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00d8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					AnyFatigue anyFatigue = fatigue_;
					if (anyFatigue == null)
					{
						AnyFatigue anyFatigue2 = (fatigue_ = new AnyFatigue());
					}
					input.ReadMessage(anyFatigue);
				}
				int num2 = default(int);
				if (num == 32)
				{
					num2 = (count_ = input.ReadInt32());
				}
				if (num2 != 40)
				{
					goto IL_00c1;
				}
				int num3 = (maxCount_ = input.ReadInt32());
			}
			Timestamp timestamp = default(Timestamp);
			if (num == 10)
			{
				Timestamp builder = default(Timestamp);
				if (firstAction_ == null)
				{
					timestamp = (firstAction_ = new Timestamp());
					builder = firstAction_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 18)
			{
				Timestamp builder2 = default(Timestamp);
				if (lastAction_ == null)
				{
					Timestamp timestamp2 = (lastAction_ = new Timestamp());
					builder2 = lastAction_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_00c1;
			IL_00c1:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004136")]
		[Cpp2IlInjected.Address(RVA = "0x18A42E0", Offset = "0x18A2CE0", VA = "0x1818A42E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0 && num != 1)
						{
							goto IL_0035;
						}
						int num2 = count_;
					}
					AnyFatigue anyFatigue = fatigue_;
				}
				Timestamp timestamp = lastAction_;
			}
			Timestamp timestamp2 = firstAction_;
			goto IL_0035;
			IL_0035:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004137")]
		[Cpp2IlInjected.Address(RVA = "0x18A4970", Offset = "0x18A3370", VA = "0x1818A4970", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_0039: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							object obj2 = default(object);
							maxCount_ = (int)obj2;
							break;
						}
						case 0:
						{
							object obj = default(object);
							count_ = (int)obj;
							break;
						}
						}
					}
					else
					{
						int num2 = 0;
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						fatigue_ = (AnyFatigue)num2;
					}
					return;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004138")]
		[Cpp2IlInjected.Address(RVA = "0x18A3DA0", Offset = "0x18A27A0", VA = "0x1818A3DA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				maxCount_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004139")]
		[Cpp2IlInjected.Address(RVA = "0x18A44C0", Offset = "0x18A2EC0", VA = "0x1818A44C0")]
		public bool IsExpired(DateTime now)
		{
			//Discarded unreachable code: IL_001c
			AnyFatigue anyFatigue = fatigue_;
			DateTime lastRefresh = firstAction_.ToDateTime();
			return anyFatigue.CanRefresh(lastRefresh, now);
		}

		[Cpp2IlInjected.Token(Token = "0x600413A")]
		[Cpp2IlInjected.Address(RVA = "0x18A3D70", Offset = "0x18A2770", VA = "0x1818A3D70")]
		public bool CanExecute(DateTime now, bool force = false)
		{
			return CanExecuteCount(now, 1, force);
		}

		[Cpp2IlInjected.Token(Token = "0x600413B")]
		[Cpp2IlInjected.Address(RVA = "0x18A3CD0", Offset = "0x18A26D0", VA = "0x1818A3CD0")]
		public bool CanExecuteCount(DateTime now, int count, bool force = false)
		{
			//Discarded unreachable code: IL_003a
			if (force)
			{
			}
			AnyFatigue anyFatigue = fatigue_;
			DateTime lastRefresh = firstAction_.ToDateTime();
			if (anyFatigue.CanRefresh(lastRefresh, now))
			{
			}
			int num = count_;
			num += count;
			return num <= maxCount_;
		}

		[Cpp2IlInjected.Token(Token = "0x600413C")]
		[Cpp2IlInjected.Address(RVA = "0x18A4170", Offset = "0x18A2B70", VA = "0x1818A4170")]
		public bool TryExecute(DateTime now, bool force = false)
		{
			//Discarded unreachable code: IL_0076
			//IL_0071: Expected I4, but got O
			int num = 0;
			if (CanExecuteCount(now, 1, force))
			{
				if (!force)
				{
					Timestamp timestamp = firstAction_;
					AnyFatigue anyFatigue = fatigue_;
					DateTime lastRefresh = timestamp.ToDateTime();
					if (!anyFatigue.CanRefresh(lastRefresh, now))
					{
						goto IL_0049;
					}
				}
				count_ = num;
				Timestamp timestamp2 = (firstAction_ = now.ToProto());
				goto IL_0049;
			}
			goto IL_0071;
			IL_0049:
			Timestamp timestamp3 = (lastAction_ = now.ToProto());
			int num2 = maxCount_;
			int num3 = count_;
			count_ = (int)timestamp3;
			goto IL_0071;
			IL_0071:
			return num > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600413D")]
		[Cpp2IlInjected.Address(RVA = "0x18A4170", Offset = "0x18A2B70", VA = "0x1818A4170")]
		public bool Execute(DateTime now, bool force = false)
		{
			//Discarded unreachable code: IL_0076
			//IL_0071: Expected I4, but got O
			int num = 0;
			if (CanExecuteCount(now, 1, force))
			{
				if (!force)
				{
					Timestamp timestamp = firstAction_;
					AnyFatigue anyFatigue = fatigue_;
					DateTime lastRefresh = timestamp.ToDateTime();
					if (!anyFatigue.CanRefresh(lastRefresh, now))
					{
						goto IL_0049;
					}
				}
				count_ = num;
				Timestamp timestamp2 = (firstAction_ = now.ToProto());
				goto IL_0049;
			}
			goto IL_0071;
			IL_0049:
			Timestamp timestamp3 = (lastAction_ = now.ToProto());
			int num2 = maxCount_;
			int num3 = count_;
			count_ = (int)timestamp3;
			goto IL_0071;
			IL_0071:
			return num > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600413E")]
		[Cpp2IlInjected.Address(RVA = "0x18A3FF0", Offset = "0x18A29F0", VA = "0x1818A3FF0")]
		public int ExecuteCount(DateTime now, int count, bool force = false)
		{
			//IL_0039: Expected I4, but got I8
			//IL_0069: Expected I4, but got O
			if (!CanExecuteCount(now, count, force))
			{
			}
			if (!force)
			{
				Timestamp timestamp = firstAction_;
				AnyFatigue anyFatigue = fatigue_;
				DateTime lastRefresh = timestamp.ToDateTime();
				if (!anyFatigue.CanRefresh(lastRefresh, now))
				{
					goto IL_0049;
				}
			}
			count_ = 0;
			Timestamp timestamp2 = (firstAction_ = now.ToProto());
			goto IL_0049;
			IL_0049:
			Timestamp timestamp3 = (lastAction_ = now.ToProto());
			int num = maxCount_;
			count_ = (int)timestamp3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600413F")]
		[Cpp2IlInjected.Address(RVA = "0x18A4C80", Offset = "0x18A3680", VA = "0x1818A4C80")]
		static LimitedAction()
		{
			Func<LimitedAction> func = default(Func<LimitedAction>);
			_parser = (MessageParser<LimitedAction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
