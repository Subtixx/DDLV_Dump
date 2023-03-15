using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DEC")]
	public sealed class ConditionalActions : IMessage<ConditionalActions>, IMessage, IEquatable<ConditionalActions>, IDeepCloneable<ConditionalActions>, IMessageFieldAccessor, IAction, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4003856")]
		private static readonly MessageParser<ConditionalActions> _parser = (MessageParser<ConditionalActions>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ConditionalActions()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003857")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003858")]
		public const int ConditionsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003859")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x400385A")]
		public const int ActionsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400385B")]
		private static readonly FieldCodec<ActionOneOf> _repeated_actions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400385C")]
		private readonly RepeatedField<ActionOneOf> actions_ = (RepeatedField<ActionOneOf>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700141B")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionalActions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007444")]
			[Cpp2IlInjected.Address(RVA = "0x1683B70", Offset = "0x1682570", VA = "0x181683B70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700141C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007445")]
			[Cpp2IlInjected.Address(RVA = "0x1683930", Offset = "0x1682330", VA = "0x181683930")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700141D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007446")]
			[Cpp2IlInjected.Address(RVA = "0x1683BD0", Offset = "0x16825D0", VA = "0x181683BD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700141E")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x600744B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x600744C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700141F")]
		[DebuggerNonUserCode]
		public RepeatedField<ActionOneOf> Actions
		{
			[Cpp2IlInjected.Token(Token = "0x600744D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return actions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001420")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600745A")]
			[Cpp2IlInjected.Address(RVA = "0x1683A00", Offset = "0x1682400", VA = "0x181683A00", Slot = "15")]
			get
			{
				RepeatedField<ActionOneOf> repeatedField = actions_;
				Func<ActionOneOf, string> _003C_003E9__35_ = _003C_003Ec._003C_003E9__35_0;
				if (_003C_003E9__35_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ActionOneOf x)
					{
						//Discarded unreachable code: IL_0013
						string info = x.Info;
						return "  " + info;
					};
				}
				IEnumerable<ActionOneOf> enumerable = (IEnumerable<ActionOneOf>)Enumerable.Select<ActionOneOf, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__35_);
				return string.Join("\n", (IEnumerable<>)enumerable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007447")]
		[Cpp2IlInjected.Address(RVA = "0x1683870", Offset = "0x1682270", VA = "0x181683870")]
		[DebuggerNonUserCode]
		public ConditionalActions()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007448")]
		[Cpp2IlInjected.Address(RVA = "0x1683230", Offset = "0x1681C30", VA = "0x181683230")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007449")]
		[Cpp2IlInjected.Address(RVA = "0x1683700", Offset = "0x1682100", VA = "0x181683700")]
		[DebuggerNonUserCode]
		public ConditionalActions(ConditionalActions other)
		{
			//IL_003d: Expected O, but got I4
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			ConditionsList conditionsList2 = other.conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num = 0;
			conditions_ = (ConditionsList)num;
			RepeatedField<ActionOneOf> repeatedField = (actions_ = (RepeatedField<ActionOneOf>)(object)((RepeatedField<T>)(object)other.actions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600744A")]
		[Cpp2IlInjected.Address(RVA = "0x1682030", Offset = "0x1680A30", VA = "0x181682030", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionalActions Clone()
		{
			//Discarded unreachable code: IL_006a
			//IL_003e: Expected O, but got I4
			ConditionalActions conditionalActions = new ConditionalActions();
			RepeatedField<ActionOneOf> repeatedField = (conditionalActions.actions_ = (RepeatedField<ActionOneOf>)(object)new RepeatedField<T>());
			ConditionsList conditionsList = (conditionalActions.conditions_ = new ConditionsList());
			ConditionsList conditionsList2 = conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num = 0;
			conditionalActions.conditions_ = (ConditionsList)num;
			RepeatedField<ActionOneOf> repeatedField2 = (conditionalActions.actions_ = (RepeatedField<ActionOneOf>)(object)((RepeatedField<T>)(object)actions_).Clone());
			UnknownFieldSet unknownFieldSet = (conditionalActions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionalActions;
		}

		[Cpp2IlInjected.Token(Token = "0x600744E")]
		[Cpp2IlInjected.Address(RVA = "0x1682DF0", Offset = "0x16817F0", VA = "0x181682DF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if (object.Equals(conditions_, other))
				{
					RepeatedField<ActionOneOf> repeatedField = actions_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600744F")]
		[Cpp2IlInjected.Address(RVA = "0x1682D40", Offset = "0x1681740", VA = "0x181682D40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionalActions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ConditionsList objB = other.conditions_;
				if (object.Equals(conditions_, objB))
				{
					RepeatedField<ActionOneOf> repeatedField = actions_;
					RepeatedField<ActionOneOf> repeatedField2 = other.actions_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007450")]
		[Cpp2IlInjected.Address(RVA = "0xC052E0", Offset = "0xC03CE0", VA = "0x180C052E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0033
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int hashCode = conditionsList.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)actions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6007451")]
		[Cpp2IlInjected.Address(RVA = "0x1683360", Offset = "0x1681D60", VA = "0x181683360", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007452")]
		[Cpp2IlInjected.Address(RVA = "0x1683440", Offset = "0x1681E40", VA = "0x181683440", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if ((long)conditions_ != 0)
			{
				ConditionsList value = conditions_;
				output.WriteMessage(value);
			}
			RepeatedField<ActionOneOf> repeatedField = actions_;
			FieldCodec<ActionOneOf> repeated_actions_codec = _repeated_actions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_actions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007453")]
		[Cpp2IlInjected.Address(RVA = "0x1681EB0", Offset = "0x16808B0", VA = "0x181681EB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			ConditionsList conditionsList = conditions_;
			int num = 0;
			if (conditionsList != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(conditionsList);
			}
			RepeatedField<ActionOneOf> repeatedField = actions_;
			FieldCodec<ActionOneOf> repeated_actions_codec = _repeated_actions_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_actions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6007454")]
		[Cpp2IlInjected.Address(RVA = "0x1682FE0", Offset = "0x16819E0", VA = "0x181682FE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionalActions other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (conditions_ = new ConditionsList());
				}
				ConditionsList other2 = other.conditions_;
				conditionsList.MergeFrom(other2);
			}
			RepeatedField<ActionOneOf> repeatedField = actions_;
			RepeatedField<ActionOneOf> repeatedField2 = other.actions_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6007455")]
		[Cpp2IlInjected.Address(RVA = "0x16830D0", Offset = "0x1681AD0", VA = "0x1816830D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0065
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (conditions_ = new ConditionsList());
				}
				input.ReadMessage(conditionsList);
			}
			if (num == 18)
			{
				RepeatedField<ActionOneOf> repeatedField = actions_;
				FieldCodec<ActionOneOf> repeated_actions_codec = _repeated_actions_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_actions_codec);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6007456")]
		[Cpp2IlInjected.Address(RVA = "0x1682EE0", Offset = "0x16818E0", VA = "0x181682EE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ConditionsList conditionsList = conditions_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<ActionOneOf> repeatedField = actions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007457")]
		[Cpp2IlInjected.Address(RVA = "0x1683290", Offset = "0x1681C90", VA = "0x181683290", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					conditions_ = (ConditionsList)num;
					return;
				}
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007458")]
		[Cpp2IlInjected.Address(RVA = "0x1681FB0", Offset = "0x16809B0", VA = "0x181681FB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<ActionOneOf> repeatedField = actions_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007459")]
		[Cpp2IlInjected.Address(RVA = "0x1681D70", Offset = "0x1680770", VA = "0x181681D70", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001c
			if (conditions_.Evaluate(profile, context))
			{
				RepeatedField<ActionOneOf> repeatedField = actions_;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600745B")]
		[Cpp2IlInjected.Address(RVA = "0x1682F70", Offset = "0x1681970", VA = "0x181682F70")]
		[IteratorStateMachine(typeof(_003CGetLeafActions_003Ed__36))]
		public IEnumerable<IAction> GetLeafActions()
		{
			new _003CGetLeafActions_003Ed__36(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600745C")]
		[Cpp2IlInjected.Address(RVA = "0x16829B0", Offset = "0x16813B0", VA = "0x1816829B0", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00b2
			IEnumerable<ICondition> allConditions = (IEnumerable<ICondition>)conditions_.GetAllConditions();
			Func<ICondition, bool> _003C_003E9__37_ = _003C_003Ec._003C_003E9__37_0;
			if (_003C_003E9__37_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ICondition x)
				{
					int num2 = 0;
					return (x != null && x != null) || num2 != 0;
				};
			}
			if (!((IEnumerable<>)allConditions).Any<ICondition>((Func<, >)(object)_003C_003E9__37_))
			{
				IEnumerable<ICondition> allConditions2 = (IEnumerable<ICondition>)conditions_.GetAllConditions();
				Func<ICondition, bool> cpp2il__autoParamName__idx_ = default(Func<ICondition, bool>);
				if (_003C_003Ec._003C_003E9__37_1 == null)
				{
					cpp2il__autoParamName__idx_ = (Func<ICondition, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ICondition x)
					{
						int num = 0;
						return (x != null && x != null) || num != 0;
					});
				}
				if (!((IEnumerable<>)allConditions2).Any<ICondition>((Func<, >)(object)cpp2il__autoParamName__idx_))
				{
					goto IL_007a;
				}
			}
			context.AddInvalidMemberError("Unsupported condition: ConditionMissionObjectiveCompleted ConditionMissionObjectiveStatus  (if needed talk to jfroux)", "Conditions");
			goto IL_007a;
			IL_007a:
			if (((RepeatedField<T>)(object)actions_).Count == 0)
			{
				context.AddInvalidMemberError("Cannot be empty", "Actions");
			}
			_003CGetLeafActions_003Ed__36 _003CGetLeafActions_003Ed__ = new _003CGetLeafActions_003Ed__36(-2);
			_003CGetLeafActions_003Ed__._003C_003E4__this = this;
			ConditionalActions.DataValidationForLeafActions((IEnumerable<>)(object)_003CGetLeafActions_003Ed__, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600745D")]
		[Cpp2IlInjected.Address(RVA = "0x16821D0", Offset = "0x1680BD0", VA = "0x1816821D0")]
		public static void DataValidationForLeafActions(IEnumerable<IAction> leafActions, DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0019, IL_002a, IL_003c, IL_0048, IL_005d, IL_0074, IL_0080, IL_0089, IL_008d, IL_0096, IL_009b, IL_00a5, IL_00bd, IL_00cf, IL_00e8, IL_00f8, IL_011a, IL_011f, IL_0123, IL_0128, IL_012f, IL_0130, IL_0136, IL_013c, IL_0142, IL_0148, IL_014e, IL_0154
			int num = 0;
			Dictionary<Type, int> dictionary = (Dictionary<Type, int>)(object)new Dictionary<TKey, TValue>();
			Type typeFromHandle = typeof(ActionRemoveMissionStep);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600745E")]
		[Cpp2IlInjected.Address(RVA = "0x1683530", Offset = "0x1681F30", VA = "0x181683530")]
		static ConditionalActions()
		{
			MessageParser<ActionOneOf> parser = ActionOneOf._parser;
			uint num = default(uint);
			_parser = (MessageParser<ConditionalActions>)(object)FieldCodec.ForMessage<ActionOneOf>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
