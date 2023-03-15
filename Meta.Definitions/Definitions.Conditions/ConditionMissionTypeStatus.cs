using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000810")]
	public sealed class ConditionMissionTypeStatus : ICondition, IProtobufDefaultData, IDataValidation, IMessage<ConditionMissionTypeStatus>, IMessage, IEquatable<ConditionMissionTypeStatus>, IDeepCloneable<ConditionMissionTypeStatus>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002822")]
		private static readonly MessageParser<ConditionMissionTypeStatus> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002823")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002824")]
		public const int SpecificTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002825")]
		private bool specificType_;

		[Cpp2IlInjected.Token(Token = "0x4002826")]
		public const int MissionTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002827")]
		private MissionType missionType_;

		[Cpp2IlInjected.Token(Token = "0x4002828")]
		public const int OperatorFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002829")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x400282A")]
		public const int StateFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400282B")]
		private MissionState state_;

		[Cpp2IlInjected.Token(Token = "0x170016B6")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60059D1")]
			[Cpp2IlInjected.Address(RVA = "0x20849C0", Offset = "0x20833C0", VA = "0x1820849C0", Slot = "5")]
			get
			{
				//IL_001b: Expected O, but got I4
				//IL_003b: Expected O, but got I4
				//IL_003b: Expected O, but got I4
				if (specificType_)
				{
					MissionType missionType = missionType_;
					string text = $"'{missionType}' ";
				}
				IntOperator intOperator = operator_;
				MissionState missionState = state_;
				return string.Format("Any mission {0}{1} {2}", "", intOperator, intOperator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B7")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60059D2")]
			[Cpp2IlInjected.Address(RVA = "0x2084AD0", Offset = "0x20834D0", VA = "0x182084AD0", Slot = "6")]
			get
			{
				MissionState missionState;
				int num;
				do
				{
					missionState = state_;
					num = (int)missionState;
				}
				while (missionState == MissionState.NotAvailableYet || missionState == MissionState.NotAvailableYet || missionState == MissionState.NotAvailableYet || missionState == MissionState.NotAvailableYet || num == 1 || missionState != MissionState.Completed);
				int num2 = (int)missionState;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B8")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionTypeStatus> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60059D6")]
			[Cpp2IlInjected.Address(RVA = "0x2084B60", Offset = "0x2083560", VA = "0x182084B60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60059D7")]
			[Cpp2IlInjected.Address(RVA = "0x20848F0", Offset = "0x20832F0", VA = "0x1820848F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60059D8")]
			[Cpp2IlInjected.Address(RVA = "0x2084BC0", Offset = "0x20835C0", VA = "0x182084BC0", Slot = "14")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BB")]
		[DebuggerNonUserCode]
		public bool SpecificType
		{
			[Cpp2IlInjected.Token(Token = "0x60059DC")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return specificType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60059DD")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				specificType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BC")]
		[DebuggerNonUserCode]
		public MissionType MissionType
		{
			[Cpp2IlInjected.Token(Token = "0x60059DE")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return missionType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60059DF")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				missionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BD")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x60059E0")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x60059E1")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BE")]
		[DebuggerNonUserCode]
		public MissionState State
		{
			[Cpp2IlInjected.Token(Token = "0x60059E2")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x60059E3")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059CF")]
		[Cpp2IlInjected.Address(RVA = "0x2083F00", Offset = "0x2082900", VA = "0x182083F00")]
		private bool Evaluate(WorldProfile worldProfile)
		{
			if (operator_ == IntOperator.Equal)
			{
				MissionState missionState = state_;
				int num = (int)missionState;
				if (missionState != 0)
				{
					if (missionState != 0 && (missionState == MissionState.NotAvailableYet || (missionState != 0 && (num == 1 || missionState == MissionState.Completed))))
					{
						Func<Item, bool> func = (Func<Item, bool>)(object)new Func<T, TResult>(ApplyItem);
						bool result = default(bool);
						return result;
					}
				}
				else
				{
					Func<Item, bool> func2 = (Func<Item, bool>)(object)new Func<T, TResult>(ApplyItem);
					bool flag = default(bool);
					if (!flag)
					{
					}
				}
			}
			Func<Item, bool> func3 = (Func<Item, bool>)(object)new Func<T, TResult>(ApplyItem);
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x60059F2")]
			[Cpp2IlInjected.Address(RVA = "0x908240", Offset = "0x906C40", VA = "0x180908240")]
			bool ApplyItem(Item item)
			{
				//Discarded unreachable code: IL_0043
				//IL_003b: Expected O, but got I8
				if (specificType_)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					bool flag2 = default(bool);
					if (!flag2)
					{
						int num2 = 0;
					}
					ConditionMissionTypeStatus conditionMissionTypeStatus = this;
					if (conditionMissionTypeStatus.specificType_)
					{
						MissionType missionType = conditionMissionTypeStatus.missionType_;
					}
					ulong num3 = default(ulong);
					int price = ((glPlayFab.Disney.BattlePassReward)num3).Price;
					bool result2 = default(bool);
					return result2;
				}
				bool result3 = default(bool);
				return result3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059D0")]
		[Cpp2IlInjected.Address(RVA = "0x2083DE0", Offset = "0x20827E0", VA = "0x182083DE0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60059D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059D4")]
		[Cpp2IlInjected.Address(RVA = "0x2083D80", Offset = "0x2082780", VA = "0x182083D80", Slot = "9")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0015
			if (operator_ != 0)
			{
				context.AddError("You must use '==' operator");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059D5")]
		[Cpp2IlInjected.Address(RVA = "0x2083E00", Offset = "0x2082800", VA = "0x182083E00", Slot = "8")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_0009: Expected I4, but got I8
			state_ = MissionState.Available;
		}

		[Cpp2IlInjected.Token(Token = "0x60059D9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionTypeStatus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60059DA")]
		[Cpp2IlInjected.Address(RVA = "0x2084890", Offset = "0x2083290", VA = "0x182084890")]
		[DebuggerNonUserCode]
		public ConditionMissionTypeStatus(ConditionMissionTypeStatus other)
		{
			bool flag = (specificType_ = other.specificType_);
			MissionType missionType = (missionType_ = other.missionType_);
			IntOperator intOperator = (operator_ = other.operator_);
			MissionState missionState = (state_ = other.state_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60059DB")]
		[Cpp2IlInjected.Address(RVA = "0x2083CF0", Offset = "0x20826F0", VA = "0x182083CF0", Slot = "16")]
		[DebuggerNonUserCode]
		public ConditionMissionTypeStatus Clone()
		{
			//Discarded unreachable code: IL_0057
			ConditionMissionTypeStatus conditionMissionTypeStatus = new ConditionMissionTypeStatus();
			bool flag = (conditionMissionTypeStatus.specificType_ = specificType_);
			MissionType missionType = (conditionMissionTypeStatus.missionType_ = missionType_);
			IntOperator intOperator = (conditionMissionTypeStatus.operator_ = operator_);
			MissionState missionState = (conditionMissionTypeStatus.state_ = state_);
			UnknownFieldSet unknownFieldSet = (conditionMissionTypeStatus._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionTypeStatus;
		}

		[Cpp2IlInjected.Token(Token = "0x60059E4")]
		[Cpp2IlInjected.Address(RVA = "0x2083E10", Offset = "0x2082810", VA = "0x182083E10", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(specificType_ ? 1 : 0) == (IntPtr)typeof(ConditionMissionTypeStatus).TypeHandle && (IntPtr)(void*)(int)missionType_ == (IntPtr)typeof(ConditionMissionTypeStatus).TypeHandle && (IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionMissionTypeStatus).TypeHandle && (IntPtr)(void*)(int)state_ == (IntPtr)typeof(ConditionMissionTypeStatus).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059E5")]
		[Cpp2IlInjected.Address(RVA = "0x2083EB0", Offset = "0x20828B0", VA = "0x182083EB0", Slot = "15")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionTypeStatus other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.specificType_;
				if (specificType_ == flag)
				{
					MissionType missionType = other.missionType_;
					if (missionType_ == missionType)
					{
						IntOperator intOperator = other.operator_;
						if (operator_ == intOperator)
						{
							MissionState missionState = other.state_;
							if (state_ == missionState)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059E6")]
		[Cpp2IlInjected.Address(RVA = "0x20842D0", Offset = "0x2082CD0", VA = "0x1820842D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (specificType_)
				{
				}
				if (missionType_ != 0)
				{
				}
				if (operator_ != 0)
				{
				}
				if (state_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60059E7")]
		[Cpp2IlInjected.Address(RVA = "0x2084640", Offset = "0x2083040", VA = "0x182084640", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60059E8")]
		[Cpp2IlInjected.Address(RVA = "0x20846A0", Offset = "0x20830A0", VA = "0x1820846A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if (specificType_)
			{
				bool value = specificType_;
				output.WriteBool(value);
			}
			if (missionType_ != 0)
			{
			}
			if (operator_ != 0)
			{
			}
			if (state_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60059E9")]
		[Cpp2IlInjected.Address(RVA = "0x2083BA0", Offset = "0x20825A0", VA = "0x182083BA0", Slot = "13")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				MissionType missionType = missionType_;
				if (missionType != 0)
				{
					int num = CodedOutputStream.ComputeEnumSize((int)missionType);
					num++;
				}
				IntOperator intOperator = operator_;
				if (intOperator != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)intOperator);
					num2++;
				}
				MissionState missionState = state_;
				if (missionState != 0)
				{
					int num3 = CodedOutputStream.ComputeEnumSize((int)missionState);
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x60059EA")]
		[Cpp2IlInjected.Address(RVA = "0x2084450", Offset = "0x2082E50", VA = "0x182084450", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionTypeStatus other)
		{
			if (other != null)
			{
				bool flag = other.specificType_;
				if (flag)
				{
					specificType_ = flag;
				}
				MissionType missionType = other.missionType_;
				if (missionType != 0)
				{
					missionType_ = missionType;
				}
				IntOperator intOperator = other.operator_;
				if (intOperator != 0)
				{
					operator_ = intOperator;
				}
				MissionState missionState = other.state_;
				if (missionState != 0)
				{
					state_ = missionState;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059EB")]
		[Cpp2IlInjected.Address(RVA = "0x2084390", Offset = "0x2082D90", VA = "0x182084390", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0078
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (int)(operator_ = (IntOperator)input.ReadInt32());
				}
				if (num != 32)
				{
					goto IL_0061;
				}
				int num3 = (int)(state_ = (MissionState)input.ReadInt32());
			}
			bool flag = default(bool);
			if (num == 8)
			{
				flag = (specificType_ = input.ReadBool());
			}
			if (flag)
			{
				int num4 = (int)(missionType_ = (MissionType)input.ReadInt32());
			}
			goto IL_0061;
			IL_0061:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60059EC")]
		[Cpp2IlInjected.Address(RVA = "0x2084170", Offset = "0x2082B70", VA = "0x182084170", Slot = "17")]
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
						if (num != 1)
						{
							goto IL_0031;
						}
						MissionState missionState = state_;
					}
					IntOperator intOperator = operator_;
				}
				MissionType missionType = missionType_;
			}
			bool flag = specificType_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059ED")]
		[Cpp2IlInjected.Address(RVA = "0x20844C0", Offset = "0x2082EC0", VA = "0x1820844C0", Slot = "18")]
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
						state_ = (MissionState)obj2;
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
					missionType_ = (MissionType)obj3;
				}
			}
			else
			{
				object obj4 = default(object);
				specificType_ = (byte)(int)obj4 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059EE")]
		[Cpp2IlInjected.Address(RVA = "0x2083CB0", Offset = "0x20826B0", VA = "0x182083CB0", Slot = "19")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				state_ = MissionState.NotAvailableYet;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059EF")]
		[Cpp2IlInjected.Address(RVA = "0x2084780", Offset = "0x2083180", VA = "0x182084780")]
		static ConditionMissionTypeStatus()
		{
			Func<ConditionMissionTypeStatus> func = default(Func<ConditionMissionTypeStatus>);
			_parser = (MessageParser<ConditionMissionTypeStatus>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059F0")]
		[Cpp2IlInjected.Address(RVA = "0x2083DE0", Offset = "0x20827E0", VA = "0x182083DE0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			bool result = default(bool);
			return result;
		}
	}
}
