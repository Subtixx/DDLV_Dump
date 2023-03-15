using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000819")]
	public sealed class ConditionMissionObjectiveStatus : ICondition, IMissionObjective, IMissionSubStep, IMissionStep, IMissionItem, IDataValidation, IMessage<ConditionMissionObjectiveStatus>, IMessage, IEquatable<ConditionMissionObjectiveStatus>, IDeepCloneable<ConditionMissionObjectiveStatus>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400284E")]
		private static readonly MessageParser<ConditionMissionObjectiveStatus> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400284F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002850")]
		public const int MissionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002851")]
		private int mission_;

		[Cpp2IlInjected.Token(Token = "0x4002852")]
		public const int StepIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002853")]
		private int stepID_;

		[Cpp2IlInjected.Token(Token = "0x4002854")]
		public const int SubStepIDFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002855")]
		private int subStepID_;

		[Cpp2IlInjected.Token(Token = "0x4002856")]
		public const int ObjectiveIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002857")]
		private int objectiveID_;

		[Cpp2IlInjected.Token(Token = "0x4002858")]
		public const int StatusFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002859")]
		private MissionStatusOperator status_;

		[Cpp2IlInjected.Token(Token = "0x170016DF")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6A")]
			[Cpp2IlInjected.Address(RVA = "0x207FA70", Offset = "0x207E470", VA = "0x18207FA70", Slot = "14")]
			get
			{
				long num = Convert.ToInt64((uint)mission_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E0")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6C")]
			[Cpp2IlInjected.Address(RVA = "0x207F7F0", Offset = "0x207E1F0", VA = "0x18207F7F0", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0080
				//IL_007f: Expected O, but got I4
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)mission_);
				MissionItemData missionItemData = default(MissionItemData);
				if (missionItemData != null)
				{
					int objectiveID = objectiveID_;
					int subStepID = subStepID_;
					int stepID = stepID_;
					MissionObjectiveData objectiveByIds = missionItemData.GetObjectiveByIds(stepID, subStepID, objectiveID);
					if (objectiveByIds != null && objectiveByIds.stepName_ != null)
					{
					}
				}
				MissionStatusOperator missionStatusOperator = status_;
				int num2 = mission_;
				string text = default(string);
				string arg = text.Replace("Mission/MissionData/", "");
				return string.Format("Objective {0} is {1} in '{2}'", "Invalid", missionStatusOperator, arg);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E1")]
		private string StepInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6D")]
			[Cpp2IlInjected.Address(RVA = "0x207FB30", Offset = "0x207E530", VA = "0x18207FB30")]
			get
			{
				//Discarded unreachable code: IL_004f
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)mission_);
				MissionItemData missionItemData = default(MissionItemData);
				if (missionItemData != null)
				{
					int objectiveID = objectiveID_;
					int subStepID = subStepID_;
					int stepID = stepID_;
					MissionObjectiveData objectiveByIds = missionItemData.GetObjectiveByIds(stepID, subStepID, objectiveID);
					if (objectiveByIds != null && objectiveByIds.stepName_ != null)
					{
					}
				}
				return "Invalid";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E2")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6E")]
			[Cpp2IlInjected.Address(RVA = "0x207FA50", Offset = "0x207E450", VA = "0x18207FA50", Slot = "6")]
			get
			{
				MissionStatusOperator missionStatusOperator = status_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E3")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionObjectiveStatus> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005A71")]
			[Cpp2IlInjected.Address(RVA = "0x207FAD0", Offset = "0x207E4D0", VA = "0x18207FAD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A72")]
			[Cpp2IlInjected.Address(RVA = "0x207F720", Offset = "0x207E120", VA = "0x18207F720")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A73")]
			[Cpp2IlInjected.Address(RVA = "0x207FCA0", Offset = "0x207E6A0", VA = "0x18207FCA0", Slot = "20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E6")]
		[DebuggerNonUserCode]
		public int Mission
		{
			[Cpp2IlInjected.Token(Token = "0x6005A77")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mission_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A78")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E7")]
		[DebuggerNonUserCode]
		public int StepID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A79")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "12")]
			get
			{
				return stepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A7A")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0", Slot = "13")]
			set
			{
				stepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E8")]
		[DebuggerNonUserCode]
		public int SubStepID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A7B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "10")]
			get
			{
				return subStepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A7C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0", Slot = "11")]
			set
			{
				subStepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016E9")]
		[DebuggerNonUserCode]
		public int ObjectiveID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A7D")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960", Slot = "8")]
			get
			{
				return objectiveID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A7E")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0", Slot = "9")]
			set
			{
				objectiveID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016EA")]
		[DebuggerNonUserCode]
		public MissionStatusOperator Status
		{
			[Cpp2IlInjected.Token(Token = "0x6005A7F")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return status_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A80")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				status_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A6B")]
		[Cpp2IlInjected.Address(RVA = "0x207F030", Offset = "0x207DA30", VA = "0x18207F030")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002f
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			int num2 = objectiveID_;
			int num3 = 0;
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
			MissionStatusOperator missionStatusOperator = status_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A6F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A70")]
		[Cpp2IlInjected.Address(RVA = "0x207ECC0", Offset = "0x207D6C0", VA = "0x18207ECC0", Slot = "15")]
		public void DataValidation(DataValidation.Context context)
		{
			MissionItemData missionItemData = default(MissionItemData);
			IEnumerable<MissionObjectiveData> allStepsObjectives;
			Func<MissionObjectiveData, bool> cpp2il__autoParamName__idx_;
			do
			{
				int num = 0;
				if (mission_ == num)
				{
					context.AddInvalidMemberError("Please select a mission", "Mission");
				}
				if (objectiveID_ < 0)
				{
					context.AddInvalidMemberError("Please select a objective", "ObjectiveID");
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
				allStepsObjectives = (IEnumerable<MissionObjectiveData>)missionItemData.get_AllStepsObjectives();
				cpp2il__autoParamName__idx_ = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
				{
					//Discarded unreachable code: IL_0011
					int num4 = objectiveID_;
					return x.objectiveID_ == num4;
				};
			}
			while (((IEnumerable<>)allStepsObjectives).Any<MissionObjectiveData>((Func<, >)(object)cpp2il__autoParamName__idx_));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A74")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionObjectiveStatus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005A75")]
		[Cpp2IlInjected.Address(RVA = "0x1A54730", Offset = "0x1A53130", VA = "0x181A54730")]
		[DebuggerNonUserCode]
		public ConditionMissionObjectiveStatus(ConditionMissionObjectiveStatus other)
		{
			int num = (mission_ = other.mission_);
			int num2 = (stepID_ = other.stepID_);
			int num3 = (subStepID_ = other.subStepID_);
			int num4 = (objectiveID_ = other.objectiveID_);
			MissionStatusOperator missionStatusOperator = (status_ = other.status_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A76")]
		[Cpp2IlInjected.Address(RVA = "0x207EC20", Offset = "0x207D620", VA = "0x18207EC20", Slot = "22")]
		[DebuggerNonUserCode]
		public ConditionMissionObjectiveStatus Clone()
		{
			//Discarded unreachable code: IL_0067
			ConditionMissionObjectiveStatus conditionMissionObjectiveStatus = new ConditionMissionObjectiveStatus();
			int num = (conditionMissionObjectiveStatus.mission_ = mission_);
			int num2 = (conditionMissionObjectiveStatus.stepID_ = stepID_);
			int num3 = (conditionMissionObjectiveStatus.subStepID_ = subStepID_);
			int num4 = (conditionMissionObjectiveStatus.objectiveID_ = objectiveID_);
			MissionStatusOperator missionStatusOperator = (conditionMissionObjectiveStatus.status_ = status_);
			UnknownFieldSet unknownFieldSet = (conditionMissionObjectiveStatus._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionObjectiveStatus;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A81")]
		[Cpp2IlInjected.Address(RVA = "0x207F190", Offset = "0x207DB90", VA = "0x18207F190", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mission_ == (IntPtr)typeof(ConditionMissionObjectiveStatus).TypeHandle && (IntPtr)stepID_ == (IntPtr)typeof(ConditionMissionObjectiveStatus).TypeHandle && (IntPtr)subStepID_ == (IntPtr)typeof(ConditionMissionObjectiveStatus).TypeHandle && (IntPtr)objectiveID_ == (IntPtr)typeof(ConditionMissionObjectiveStatus).TypeHandle && (IntPtr)(void*)(int)status_ == (IntPtr)typeof(ConditionMissionObjectiveStatus).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A82")]
		[Cpp2IlInjected.Address(RVA = "0x1A53B70", Offset = "0x1A52570", VA = "0x181A53B70", Slot = "21")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionObjectiveStatus other)
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
						int num3 = other.subStepID_;
						if (subStepID_ == num3)
						{
							int num4 = other.objectiveID_;
							if (objectiveID_ == num4)
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
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A83")]
		[Cpp2IlInjected.Address(RVA = "0x207F330", Offset = "0x207DD30", VA = "0x18207F330", Slot = "2")]
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
				if (subStepID_ != 0)
				{
				}
				if (objectiveID_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005A84")]
		[Cpp2IlInjected.Address(RVA = "0x207F5B0", Offset = "0x207DFB0", VA = "0x18207F5B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005A85")]
		[Cpp2IlInjected.Address(RVA = "0x1A54520", Offset = "0x1A52F20", VA = "0x181A54520", Slot = "18")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007b
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
			if (subStepID_ != 0)
			{
				int value3 = subStepID_;
				output.WriteInt32(value3);
			}
			if (objectiveID_ != 0)
			{
				int value4 = objectiveID_;
				output.WriteInt32(value4);
			}
			if (status_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005A86")]
		[Cpp2IlInjected.Address(RVA = "0x207EAC0", Offset = "0x207D4C0", VA = "0x18207EAC0", Slot = "19")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = mission_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = stepID_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = subStepID_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				int num8 = objectiveID_;
				if (num8 != 0)
				{
					int num9 = CodedOutputStream.ComputeInt32Size(num8);
					num9++;
					num2 += num9;
				}
				MissionStatusOperator missionStatusOperator = status_;
				if (missionStatusOperator != 0)
				{
					int num10 = CodedOutputStream.ComputeEnumSize((int)missionStatusOperator);
					num10++;
					num2 += num10;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num11 = unknownFields.CalculateSize();
			return num11 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A87")]
		[Cpp2IlInjected.Address(RVA = "0x1A53E20", Offset = "0x1A52820", VA = "0x181A53E20", Slot = "16")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionObjectiveStatus other)
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
				int num3 = other.subStepID_;
				if (num3 != 0)
				{
					subStepID_ = num3;
				}
				int num4 = other.objectiveID_;
				if (num4 != 0)
				{
					objectiveID_ = num4;
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

		[Cpp2IlInjected.Token(Token = "0x6005A88")]
		[Cpp2IlInjected.Address(RVA = "0x1A53EA0", Offset = "0x1A528A0", VA = "0x181A53EA0", Slot = "17")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0092
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (subStepID_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (objectiveID_ = input.ReadInt32());
				}
				if (num3 != 40)
				{
					goto IL_007b;
				}
				int num4 = (int)(status_ = (MissionStatusOperator)input.ReadInt32());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (mission_ = input.ReadInt32());
			}
			if (num5 == 16)
			{
				int num6 = (stepID_ = input.ReadInt32());
			}
			goto IL_007b;
			IL_007b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005A89")]
		[Cpp2IlInjected.Address(RVA = "0x207F240", Offset = "0x207DC40", VA = "0x18207F240", Slot = "23")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 0 || num == 0 || num == 1)
			{
				int num2 = mission_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A8A")]
		[Cpp2IlInjected.Address(RVA = "0x207F400", Offset = "0x207DE00", VA = "0x18207F400", Slot = "24")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0042
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_002f: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			//IL_0041: Expected I4, but got O
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
							status_ = (MissionStatusOperator)obj2;
							break;
						}
						case 0:
						{
							object obj = default(object);
							objectiveID_ = (int)obj;
							break;
						}
						}
					}
					else
					{
						object obj3 = default(object);
						subStepID_ = (int)obj3;
					}
				}
				else
				{
					object obj4 = default(object);
					stepID_ = (int)obj4;
				}
			}
			else
			{
				object obj5 = default(object);
				mission_ = (int)obj5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A8B")]
		[Cpp2IlInjected.Address(RVA = "0x1A53A70", Offset = "0x1A52470", VA = "0x181A53A70", Slot = "25")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022, IL_002c
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				status_ = MissionStatusOperator.NotStarted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A8C")]
		[Cpp2IlInjected.Address(RVA = "0x207F610", Offset = "0x207E010", VA = "0x18207F610")]
		static ConditionMissionObjectiveStatus()
		{
			Func<ConditionMissionObjectiveStatus> func = default(Func<ConditionMissionObjectiveStatus>);
			_parser = (MessageParser<ConditionMissionObjectiveStatus>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A8D")]
		[Cpp2IlInjected.Address(RVA = "0x207F030", Offset = "0x207DA30", VA = "0x18207F030", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002f
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			int num2 = objectiveID_;
			int num3 = 0;
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
			MissionStatusOperator missionStatusOperator = status_;
			bool result = default(bool);
			return result;
		}
	}
}
