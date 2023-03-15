using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000815")]
	public sealed class ConditionMissionStepStatus : ICondition, IMissionStep, IMissionItem, IDataValidation, IMessage<ConditionMissionStepStatus>, IMessage, IEquatable<ConditionMissionStepStatus>, IDeepCloneable<ConditionMissionStepStatus>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002838")]
		private static readonly MessageParser<ConditionMissionStepStatus> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002839")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400283A")]
		public const int MissionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400283B")]
		private int mission_;

		[Cpp2IlInjected.Token(Token = "0x400283C")]
		public const int StepIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400283D")]
		private int stepID_;

		[Cpp2IlInjected.Token(Token = "0x400283E")]
		public const int StatusFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400283F")]
		private MissionStatusOperator status_;

		[Cpp2IlInjected.Token(Token = "0x170016C9")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005A1D")]
			[Cpp2IlInjected.Address(RVA = "0x20837D0", Offset = "0x20821D0", VA = "0x1820837D0", Slot = "10")]
			get
			{
				long num = Convert.ToInt64((uint)mission_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CA")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005A1F")]
			[Cpp2IlInjected.Address(RVA = "0x20836A0", Offset = "0x20820A0", VA = "0x1820836A0", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_003b
				string stepInfo = StepInfo;
				MissionStatusOperator missionStatusOperator = status_;
				long num = Convert.ToInt64((uint)mission_);
				string text = default(string);
				string arg = text.Replace("Mission/MissionData/", "");
				return $"Step {stepInfo} is {stepInfo} in '{arg}'";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CB")]
		private string StepInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6005A20")]
			[Cpp2IlInjected.Address(RVA = "0x2083890", Offset = "0x2082290", VA = "0x182083890")]
			get
			{
				//Discarded unreachable code: IL_0070
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)mission_);
				MissionItemData missionItemData = default(MissionItemData);
				if (missionItemData != null)
				{
					RepeatedField<MissionStepData> steps_ = missionItemData.steps_;
					Func<MissionStepData, bool> func = (Func<MissionStepData, bool>)(object)(Func<T, TResult>)delegate(MissionStepData x)
					{
						//Discarded unreachable code: IL_0011
						int num2 = stepID_;
						return x.stepID_ == num2;
					};
					MissionStepData missionStepData = Enumerable.FirstOrDefault<MissionStepData>((IEnumerable<>)(object)steps_, (Func<, >)(object)func);
					if (missionStepData != null)
					{
						MissionSubStepData missionSubStepData = Enumerable.FirstOrDefault<MissionSubStepData>((IEnumerable<>)(object)missionStepData.subSteps_);
						if (missionSubStepData != null)
						{
							MissionObjectiveData missionObjectiveData = Enumerable.FirstOrDefault<MissionObjectiveData>((IEnumerable<>)(object)missionSubStepData.objectives_);
							if (missionObjectiveData != null && missionObjectiveData.stepName_ != null)
							{
							}
						}
					}
				}
				return "Invalid";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CC")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005A21")]
			[Cpp2IlInjected.Address(RVA = "0x17EC850", Offset = "0x17EB250", VA = "0x1817EC850", Slot = "6")]
			get
			{
				return ConditionListener.MissionStepChanged;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CD")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionStepStatus> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005A24")]
			[Cpp2IlInjected.Address(RVA = "0x2083830", Offset = "0x2082230", VA = "0x182083830")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A25")]
			[Cpp2IlInjected.Address(RVA = "0x20835D0", Offset = "0x2081FD0", VA = "0x1820835D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016CF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A26")]
			[Cpp2IlInjected.Address(RVA = "0x2083A90", Offset = "0x2082490", VA = "0x182083A90", Slot = "16")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D0")]
		[DebuggerNonUserCode]
		public int Mission
		{
			[Cpp2IlInjected.Token(Token = "0x6005A2A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mission_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A2B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D1")]
		[DebuggerNonUserCode]
		public int StepID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A2C")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "8")]
			get
			{
				return stepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A2D")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0", Slot = "9")]
			set
			{
				stepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D2")]
		[DebuggerNonUserCode]
		public MissionStatusOperator Status
		{
			[Cpp2IlInjected.Token(Token = "0x6005A2E")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return status_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A2F")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				status_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A1E")]
		[Cpp2IlInjected.Address(RVA = "0x2083080", Offset = "0x2081A80", VA = "0x182083080")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			MissionStatusOperator missionStatusOperator = status_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A22")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A23")]
		[Cpp2IlInjected.Address(RVA = "0x2082CF0", Offset = "0x20816F0", VA = "0x182082CF0", Slot = "11")]
		public void DataValidation(DataValidation.Context context)
		{
			MissionItemData missionItemData = default(MissionItemData);
			RepeatedField<MissionStepData> steps_;
			Predicate<MissionStepData> predicate;
			do
			{
				int num = 0;
				if (mission_ == num || stepID_ < num)
				{
					context.AddInvalidMemberError("Please select a mission", "Mission");
				}
				MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
				if (parentOfType != null)
				{
					int iD = parentOfType.ID;
					int num2 = mission_;
					if ((object)typeof(Item).TypeHandle != null)
					{
						context.AddInvalidMemberError("Please don't use current mission inside MissionStepCompleted condition", "Mission");
					}
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int num3 = mission_;
				if (missionItemData == null)
				{
					context.AddInvalidMemberError("Please select a valid mission", "Mission");
					return;
				}
				steps_ = missionItemData.steps_;
				predicate = (Predicate<MissionStepData>)(object)(Predicate<T>)delegate(MissionStepData x)
				{
					//Discarded unreachable code: IL_0011
					int num4 = stepID_;
					return x.stepID_ == num4;
				};
			}
			while (((RepeatedField<>)(object)steps_).Any<MissionStepData>((Predicate<>)(object)predicate));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A27")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionStepStatus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005A28")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public ConditionMissionStepStatus(ConditionMissionStepStatus other)
		{
			int num = (mission_ = other.mission_);
			int num2 = (stepID_ = other.stepID_);
			MissionStatusOperator missionStatusOperator = (status_ = other.status_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A29")]
		[Cpp2IlInjected.Address(RVA = "0x2082C60", Offset = "0x2081660", VA = "0x182082C60", Slot = "18")]
		[DebuggerNonUserCode]
		public ConditionMissionStepStatus Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionMissionStepStatus conditionMissionStepStatus = new ConditionMissionStepStatus();
			int num = (conditionMissionStepStatus.mission_ = mission_);
			int num2 = (conditionMissionStepStatus.stepID_ = stepID_);
			MissionStatusOperator missionStatusOperator = (conditionMissionStepStatus.status_ = status_);
			UnknownFieldSet unknownFieldSet = (conditionMissionStepStatus._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionStepStatus;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A30")]
		[Cpp2IlInjected.Address(RVA = "0x20831C0", Offset = "0x2081BC0", VA = "0x1820831C0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mission_ == (IntPtr)typeof(ConditionMissionStepStatus).TypeHandle && (IntPtr)stepID_ == (IntPtr)typeof(ConditionMissionStepStatus).TypeHandle && (IntPtr)(void*)(int)status_ == (IntPtr)typeof(ConditionMissionStepStatus).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A31")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "17")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionStepStatus other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.mission_;
				if (mission_ == num)
				{
					int num2 = other.stepID_;
					if (stepID_ == num2)
					{
						MissionStatusOperator missionStatusOperator = other.status_;
						if (status_ == missionStatusOperator)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A32")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B090", Offset = "0x1E79A90", VA = "0x181E7B090", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (mission_ != 0)
				{
				}
				if (stepID_ != 0)
				{
				}
				if (status_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A33")]
		[Cpp2IlInjected.Address(RVA = "0x2083460", Offset = "0x2081E60", VA = "0x182083460", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005A34")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "14")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			if (mission_ != 0)
			{
				int value = mission_;
				output.WriteInt32(value);
			}
			if (stepID_ != 0)
			{
				int value2 = stepID_;
				output.WriteInt32(value2);
			}
			if (status_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005A35")]
		[Cpp2IlInjected.Address(RVA = "0x2082B60", Offset = "0x2081560", VA = "0x182082B60", Slot = "15")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num3 = default(int);
			UnknownFieldSet unknownFields;
			do
			{
				int num = mission_;
				int num2 = 0;
				if (num != 0)
				{
					num3 = CodedOutputStream.ComputeInt32Size(num) + 1;
				}
				int num4 = stepID_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num3 += num5;
				}
				MissionStatusOperator missionStatusOperator = status_;
				if (missionStatusOperator != 0)
				{
					int num6 = CodedOutputStream.ComputeEnumSize((int)missionStatusOperator);
					num6++;
					num3 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A36")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionStepStatus other)
		{
			if (other != null)
			{
				int num = other.mission_;
				if (num != 0)
				{
					mission_ = num;
				}
				int num2 = other.stepID_;
				if (num2 != 0)
				{
					stepID_ = num2;
				}
				MissionStatusOperator missionStatusOperator = other.status_;
				if (missionStatusOperator != 0)
				{
					status_ = missionStatusOperator;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A37")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (mission_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (stepID_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (int)(status_ = (MissionStatusOperator)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A38")]
		[Cpp2IlInjected.Address(RVA = "0x2083260", Offset = "0x2081C60", VA = "0x182083260", Slot = "19")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = mission_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A39")]
		[Cpp2IlInjected.Address(RVA = "0x2083340", Offset = "0x2081D40", VA = "0x182083340", Slot = "20")]
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
					status_ = (MissionStatusOperator)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					stepID_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				mission_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A3A")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "21")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				status_ = MissionStatusOperator.NotStarted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A3B")]
		[Cpp2IlInjected.Address(RVA = "0x20834C0", Offset = "0x2081EC0", VA = "0x1820834C0")]
		static ConditionMissionStepStatus()
		{
			Func<ConditionMissionStepStatus> func = default(Func<ConditionMissionStepStatus>);
			_parser = (MessageParser<ConditionMissionStepStatus>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A3C")]
		[Cpp2IlInjected.Address(RVA = "0x2083080", Offset = "0x2081A80", VA = "0x182083080", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			MissionStatusOperator missionStatusOperator = status_;
			bool result = default(bool);
			return result;
		}
	}
}
