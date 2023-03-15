using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008F9")]
	public sealed class ConditionalEventState : IMessage<ConditionalEventState>, IMessage, IEquatable<ConditionalEventState>, IDeepCloneable<ConditionalEventState>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20008FA")]
		public enum ActionStateOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4002465")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002466")]
			SpawnState,
			[Cpp2IlInjected.Token(Token = "0x4002467")]
			RecurringEventState
		}

		[Cpp2IlInjected.Token(Token = "0x400245E")]
		private static readonly MessageParser<ConditionalEventState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400245F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002460")]
		public const int SpawnStateFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002461")]
		public const int RecurringEventStateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002462")]
		private object actionState_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002463")]
		private ActionStateOneofCase actionStateCase_;

		[Cpp2IlInjected.Token(Token = "0x17000D41")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionalEventState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004DE9")]
			[Cpp2IlInjected.Address(RVA = "0x1687A40", Offset = "0x1686440", VA = "0x181687A40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D42")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004DEA")]
			[Cpp2IlInjected.Address(RVA = "0x1687970", Offset = "0x1686370", VA = "0x181687970")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D43")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004DEB")]
			[Cpp2IlInjected.Address(RVA = "0x1687B60", Offset = "0x1686560", VA = "0x181687B60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D44")]
		[DebuggerNonUserCode]
		public SpawnActionState SpawnState
		{
			[Cpp2IlInjected.Token(Token = "0x6004DEF")]
			[Cpp2IlInjected.Address(RVA = "0x1687B00", Offset = "0x1686500", VA = "0x181687B00")]
			get
			{
				int num = 0;
				if (actionStateCase_ == ActionStateOneofCase.SpawnState)
				{
					object obj = actionState_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004DF0")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				actionState_ = value;
				bool flag = (byte)(actionStateCase_ = ((value != null) ? ActionStateOneofCase.SpawnState : ActionStateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D45")]
		[DebuggerNonUserCode]
		public RecurringEventActionState RecurringEventState
		{
			[Cpp2IlInjected.Token(Token = "0x6004DF1")]
			[Cpp2IlInjected.Address(RVA = "0x1687AA0", Offset = "0x16864A0", VA = "0x181687AA0")]
			get
			{
				if (actionStateCase_ == ActionStateOneofCase.RecurringEventState)
				{
					object obj = actionState_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004DF2")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				actionState_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D46")]
		[DebuggerNonUserCode]
		public ActionStateOneofCase ActionStateCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004DF3")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return actionStateCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionalEventState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DED")]
		[Cpp2IlInjected.Address(RVA = "0x1687810", Offset = "0x1686210", VA = "0x181687810")]
		[DebuggerNonUserCode]
		public ConditionalEventState(ConditionalEventState other)
		{
			//IL_0054: Expected I4, but got O
			ActionStateOneofCase actionStateOneofCase = other.actionStateCase_;
			if (actionStateOneofCase == ActionStateOneofCase.SpawnState)
			{
				ActionStateOneofCase actionStateOneofCase2 = other.actionStateCase_;
				if (other.actionState_ == null)
				{
					throw new InvalidCastException();
				}
				SpawnActionState spawnActionState = default(SpawnActionState);
				actionState_ = spawnActionState;
				bool flag = (byte)(actionStateCase_ = ((spawnActionState != null) ? ActionStateOneofCase.SpawnState : ActionStateOneofCase.None)) != 0;
			}
			if (actionStateOneofCase == ActionStateOneofCase.RecurringEventState)
			{
				if (other.actionState_ == null)
				{
					throw new InvalidCastException();
				}
				RecurringEventActionState recurringEventActionState = default(RecurringEventActionState);
				actionState_ = recurringEventActionState;
				actionStateCase_ = (ActionStateOneofCase)recurringEventActionState;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEE")]
		[Cpp2IlInjected.Address(RVA = "0x1686910", Offset = "0x1685310", VA = "0x181686910", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionalEventState Clone()
		{
			//Discarded unreachable code: IL_006d
			//IL_0056: Expected I4, but got O
			ConditionalEventState conditionalEventState = new ConditionalEventState();
			ActionStateOneofCase actionStateOneofCase = actionStateCase_;
			if (actionStateOneofCase == ActionStateOneofCase.SpawnState)
			{
				ActionStateOneofCase actionStateOneofCase2 = actionStateCase_;
				if (actionState_ == null)
				{
					throw new InvalidCastException();
				}
				SpawnActionState spawnActionState = default(SpawnActionState);
				conditionalEventState.actionState_ = spawnActionState;
				bool flag = (byte)(conditionalEventState.actionStateCase_ = ((spawnActionState != null) ? ActionStateOneofCase.SpawnState : ActionStateOneofCase.None)) != 0;
			}
			if (actionStateOneofCase == ActionStateOneofCase.RecurringEventState)
			{
				if (actionState_ == null)
				{
					throw new InvalidCastException();
				}
				RecurringEventActionState recurringEventActionState = default(RecurringEventActionState);
				conditionalEventState.actionState_ = recurringEventActionState;
				conditionalEventState.actionStateCase_ = (ActionStateOneofCase)recurringEventActionState;
			}
			UnknownFieldSet unknownFieldSet = (conditionalEventState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionalEventState;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF4")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearActionState()
		{
			//IL_0010: Expected O, but got I4
			actionState_ = (actionStateCase_ = ActionStateOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF5")]
		[Cpp2IlInjected.Address(RVA = "0x1686BD0", Offset = "0x16855D0", VA = "0x181686BD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (actionStateCase_ == ActionStateOneofCase.SpawnState)
					{
						object obj = actionState_;
						if (obj != null && obj == null)
						{
							goto IL_0071;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(SpawnActionState).TypeHandle != null && (object)typeof(SpawnActionState).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						RecurringEventActionState objB = default(RecurringEventActionState);
						bool flag2 = object.Equals(RecurringEventState, objB);
						if (flag2 && actionStateCase_ == (flag2 ? ActionStateOneofCase.SpawnState : ActionStateOneofCase.None))
						{
							bool flag3 = object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0071;
			IL_0071:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF6")]
		[Cpp2IlInjected.Address(RVA = "0x1686AA0", Offset = "0x16854A0", VA = "0x181686AA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionalEventState other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (actionStateCase_ == ActionStateOneofCase.SpawnState)
				{
					object obj = actionState_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.actionStateCase_ == ActionStateOneofCase.SpawnState)
				{
					obj2 = other.actionState_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					RecurringEventActionState recurringEventState = RecurringEventState;
					RecurringEventActionState recurringEventState2 = other.RecurringEventState;
					if (object.Equals(recurringEventState, recurringEventState2))
					{
						ActionStateOneofCase actionStateOneofCase = other.actionStateCase_;
						if (actionStateCase_ == actionStateOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0099;
			IL_0099:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF7")]
		[Cpp2IlInjected.Address(RVA = "0x1686E50", Offset = "0x1685850", VA = "0x181686E50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0051
			ActionStateOneofCase actionStateOneofCase = actionStateCase_;
			int num = 0;
			if (actionStateOneofCase == ActionStateOneofCase.SpawnState)
			{
				object obj = actionState_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (actionStateOneofCase == ActionStateOneofCase.RecurringEventState)
			{
				object obj2 = actionState_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF8")]
		[Cpp2IlInjected.Address(RVA = "0x1687570", Offset = "0x1685F70", VA = "0x181687570", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF9")]
		[Cpp2IlInjected.Address(RVA = "0x16875D0", Offset = "0x1685FD0", VA = "0x1816875D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			//IL_002c: Expected O, but got I4
			ActionStateOneofCase actionStateOneofCase = actionStateCase_;
			int num = 0;
			if (actionStateOneofCase == ActionStateOneofCase.SpawnState)
			{
				if (actionStateCase_ == ActionStateOneofCase.SpawnState)
				{
					object obj = actionState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (actionStateOneofCase == ActionStateOneofCase.RecurringEventState && actionStateCase_ == ActionStateOneofCase.RecurringEventState)
			{
				object obj2 = actionState_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFA")]
		[Cpp2IlInjected.Address(RVA = "0x1686710", Offset = "0x1685110", VA = "0x181686710", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (actionStateCase_ == ActionStateOneofCase.SpawnState)
			{
				if (actionStateCase_ == ActionStateOneofCase.SpawnState)
				{
					object obj = actionState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (actionStateCase_ == ActionStateOneofCase.RecurringEventState)
			{
				if (actionStateCase_ == ActionStateOneofCase.RecurringEventState)
				{
					object obj2 = actionState_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFB")]
		[Cpp2IlInjected.Address(RVA = "0x1687030", Offset = "0x1685A30", VA = "0x181687030", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionalEventState other)
		{
			//IL_00dd: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.actionStateCase_ == ActionStateOneofCase.SpawnState)
			{
				ActionStateOneofCase actionStateOneofCase = actionStateCase_;
				int num = 0;
				if (actionStateOneofCase == ActionStateOneofCase.SpawnState)
				{
					object obj = actionState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(actionStateCase_ = (((actionState_ = new SpawnActionState()) != null) ? ActionStateOneofCase.SpawnState : ActionStateOneofCase.None)) != 0;
				}
				if (actionStateCase_ == ActionStateOneofCase.SpawnState)
				{
					object obj2 = actionState_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.actionStateCase_ == ActionStateOneofCase.SpawnState)
				{
					object obj3 = other.actionState_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(SpawnActionState).TypeHandle != 2)
			{
			}
			if (RecurringEventState == null)
			{
				actionStateCase_ = (ActionStateOneofCase)(actionState_ = new RecurringEventActionState());
			}
			RecurringEventActionState other2 = default(RecurringEventActionState);
			RecurringEventState.MergeFrom(other2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFC")]
		[Cpp2IlInjected.Address(RVA = "0x1687280", Offset = "0x1685C80", VA = "0x181687280", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a8: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				SpawnActionState spawnActionState = new SpawnActionState();
				if (actionStateCase_ == ActionStateOneofCase.SpawnState)
				{
					if (actionStateCase_ != ActionStateOneofCase.SpawnState)
					{
					}
					object obj = actionState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(spawnActionState);
				actionState_ = spawnActionState;
				bool flag = (byte)(actionStateCase_ = ((spawnActionState != null) ? ActionStateOneofCase.SpawnState : ActionStateOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				RecurringEventActionState builder = new RecurringEventActionState();
				if (actionStateCase_ == ActionStateOneofCase.RecurringEventState)
				{
					if (actionStateCase_ != ActionStateOneofCase.RecurringEventState)
					{
					}
					object obj2 = actionState_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				actionState_ = builder;
				actionStateCase_ = (ActionStateOneofCase)typeof(RecurringEventActionState).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFD")]
		[Cpp2IlInjected.Address(RVA = "0x1686D40", Offset = "0x1685740", VA = "0x181686D40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (actionStateCase_ == ActionStateOneofCase.SpawnState)
			{
				object obj = actionState_;
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					goto IL_001c;
				}
			}
			goto IL_0038;
			IL_0038:
			object obj2 = default(object);
			return obj2;
			IL_001c:
			if (fieldNumber == 2)
			{
				if (actionStateCase_ == ActionStateOneofCase.RecurringEventState)
				{
					obj2 = actionState_;
					if (obj2 != null && obj2 == null)
					{
						goto IL_0040;
					}
				}
				goto IL_0038;
			}
			goto IL_0040;
			IL_0040:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFE")]
		[Cpp2IlInjected.Address(RVA = "0x1687480", Offset = "0x1685E80", VA = "0x181687480", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			//IL_0043: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				actionState_ = num;
				bool flag = (byte)(actionStateCase_ = ((num != 0) ? ActionStateOneofCase.SpawnState : ActionStateOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				actionState_ = value;
				actionStateCase_ = (ActionStateOneofCase)typeof(SpawnActionState).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DFF")]
		[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1 || fieldNumber == 2)
			{
				actionStateCase_ = ActionStateOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E00")]
		[Cpp2IlInjected.Address(RVA = "0x1686F80", Offset = "0x1685980", VA = "0x181686F80", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ActionState"))
			{
				ActionStateOneofCase actionStateOneofCase = actionStateCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E01")]
		[Cpp2IlInjected.Address(RVA = "0x16868A0", Offset = "0x16852A0", VA = "0x1816868A0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ActionState"))
			{
				actionState_ = (actionStateCase_ = ActionStateOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E02")]
		[Cpp2IlInjected.Address(RVA = "0x1687700", Offset = "0x1686100", VA = "0x181687700")]
		static ConditionalEventState()
		{
			Func<ConditionalEventState> func = default(Func<ConditionalEventState>);
			_parser = (MessageParser<ConditionalEventState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
