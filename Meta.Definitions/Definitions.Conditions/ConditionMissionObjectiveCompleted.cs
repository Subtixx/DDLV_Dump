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
	[Cpp2IlInjected.Token(Token = "0x2000817")]
	public sealed class ConditionMissionObjectiveCompleted : ICondition, IMissionObjective, IMissionSubStep, IMissionStep, IMissionItem, IDataValidation, IMessage<ConditionMissionObjectiveCompleted>, IMessage, IEquatable<ConditionMissionObjectiveCompleted>, IDeepCloneable<ConditionMissionObjectiveCompleted>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002841")]
		private static readonly MessageParser<ConditionMissionObjectiveCompleted> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002842")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002843")]
		public const int MissionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002844")]
		private int mission_;

		[Cpp2IlInjected.Token(Token = "0x4002845")]
		public const int StepIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002846")]
		private int stepID_;

		[Cpp2IlInjected.Token(Token = "0x4002847")]
		public const int SubStepIDFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002848")]
		private int subStepID_;

		[Cpp2IlInjected.Token(Token = "0x4002849")]
		public const int ObjectiveIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400284A")]
		private int objectiveID_;

		[Cpp2IlInjected.Token(Token = "0x400284B")]
		public const int InversedFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400284C")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170016D3")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005A42")]
			[Cpp2IlInjected.Address(RVA = "0x207E780", Offset = "0x207D180", VA = "0x18207E780", Slot = "14")]
			get
			{
				long num = Convert.ToInt64((uint)mission_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D4")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005A44")]
			[Cpp2IlInjected.Address(RVA = "0x207E230", Offset = "0x207CC30", VA = "0x18207E230", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_014d
				string[] array;
				MissionItemData missionItemData = default(MissionItemData);
				MissionObjectiveData objectiveByIds = default(MissionObjectiveData);
				string text2 = default(string);
				while (true)
				{
					array = new string[7];
					if ("Objective " != null && "Objective " == null)
					{
						continue;
					}
					array[0] = "Objective ";
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					long num = Convert.ToInt64((uint)mission_);
					if (missionItemData != null)
					{
						int objectiveID = objectiveID_;
						int subStepID = subStepID_;
						int stepID = stepID_;
						objectiveByIds = missionItemData.GetObjectiveByIds(stepID, subStepID, objectiveID);
						if (objectiveByIds != null && objectiveByIds.stepName_ != null)
						{
							goto IL_0076;
						}
					}
					if ("Invalid" != null)
					{
						goto IL_0076;
					}
					goto IL_007b;
					IL_007b:
					array[1] = "Invalid";
					if (" " != null && " " == null)
					{
						continue;
					}
					array[2] = " ";
					string text = "completed";
					if (inversed_)
					{
						text = "not completed";
					}
					if (text != null && " " == null)
					{
						continue;
					}
					array[3] = text;
					if (" in '" != null && " in '" == null)
					{
						continue;
					}
					array[4] = " in '";
					int num2 = mission_;
					string text3 = text2.Replace("Mission/MissionData/", "");
					if (text3 == null || text3 != null)
					{
						array[5] = text3;
						if ("'" == null || "'" != null)
						{
							break;
						}
					}
					continue;
					IL_0076:
					if (objectiveByIds == null)
					{
						continue;
					}
					goto IL_007b;
				}
				array[6] = "'";
				return string.Concat(array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D5")]
		private string StepInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6005A45")]
			[Cpp2IlInjected.Address(RVA = "0x207E840", Offset = "0x207D240", VA = "0x18207E840")]
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

		[Cpp2IlInjected.Token(Token = "0x170016D6")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005A46")]
			[Cpp2IlInjected.Address(RVA = "0x207E770", Offset = "0x207D170", VA = "0x18207E770", Slot = "6")]
			get
			{
				return ConditionListener.MissionObjectiveCompleted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D7")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionObjectiveCompleted> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005A49")]
			[Cpp2IlInjected.Address(RVA = "0x207E7E0", Offset = "0x207D1E0", VA = "0x18207E7E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4A")]
			[Cpp2IlInjected.Address(RVA = "0x207E160", Offset = "0x207CB60", VA = "0x18207E160")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016D9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4B")]
			[Cpp2IlInjected.Address(RVA = "0x207E9B0", Offset = "0x207D3B0", VA = "0x18207E9B0", Slot = "20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DA")]
		[DebuggerNonUserCode]
		public int Mission
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mission_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A50")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DB")]
		[DebuggerNonUserCode]
		public int StepID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A51")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "12")]
			get
			{
				return stepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A52")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0", Slot = "13")]
			set
			{
				stepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DC")]
		[DebuggerNonUserCode]
		public int SubStepID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A53")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "10")]
			get
			{
				return subStepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A54")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0", Slot = "11")]
			set
			{
				subStepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DD")]
		[DebuggerNonUserCode]
		public int ObjectiveID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A55")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960", Slot = "8")]
			get
			{
				return objectiveID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A56")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0", Slot = "9")]
			set
			{
				objectiveID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016DE")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005A57")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A58")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A43")]
		[Cpp2IlInjected.Address(RVA = "0x207D6F0", Offset = "0x207C0F0", VA = "0x18207D6F0")]
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
			bool flag = inversed_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A47")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A48")]
		[Cpp2IlInjected.Address(RVA = "0x207D380", Offset = "0x207BD80", VA = "0x18207D380", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x6005A4C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionObjectiveCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005A4D")]
		[Cpp2IlInjected.Address(RVA = "0x207E0F0", Offset = "0x207CAF0", VA = "0x18207E0F0")]
		[DebuggerNonUserCode]
		public ConditionMissionObjectiveCompleted(ConditionMissionObjectiveCompleted other)
		{
			int num = (mission_ = other.mission_);
			int num2 = (stepID_ = other.stepID_);
			int num3 = (subStepID_ = other.subStepID_);
			int num4 = (objectiveID_ = other.objectiveID_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A4E")]
		[Cpp2IlInjected.Address(RVA = "0x207D2E0", Offset = "0x207BCE0", VA = "0x18207D2E0", Slot = "22")]
		[DebuggerNonUserCode]
		public ConditionMissionObjectiveCompleted Clone()
		{
			//Discarded unreachable code: IL_0067
			ConditionMissionObjectiveCompleted conditionMissionObjectiveCompleted = new ConditionMissionObjectiveCompleted();
			int num = (conditionMissionObjectiveCompleted.mission_ = mission_);
			int num2 = (conditionMissionObjectiveCompleted.stepID_ = stepID_);
			int num3 = (conditionMissionObjectiveCompleted.subStepID_ = subStepID_);
			int num4 = (conditionMissionObjectiveCompleted.objectiveID_ = objectiveID_);
			bool flag = (conditionMissionObjectiveCompleted.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionMissionObjectiveCompleted._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionObjectiveCompleted;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A59")]
		[Cpp2IlInjected.Address(RVA = "0x207D850", Offset = "0x207C250", VA = "0x18207D850", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mission_ == (IntPtr)typeof(ConditionMissionObjectiveCompleted).TypeHandle && (IntPtr)stepID_ == (IntPtr)typeof(ConditionMissionObjectiveCompleted).TypeHandle && (IntPtr)subStepID_ == (IntPtr)typeof(ConditionMissionObjectiveCompleted).TypeHandle && (IntPtr)objectiveID_ == (IntPtr)typeof(ConditionMissionObjectiveCompleted).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionMissionObjectiveCompleted).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A5A")]
		[Cpp2IlInjected.Address(RVA = "0x207D900", Offset = "0x207C300", VA = "0x18207D900", Slot = "21")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionObjectiveCompleted other)
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
								bool flag = other.inversed_;
								if (inversed_ == flag)
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

		[Cpp2IlInjected.Token(Token = "0x6005A5B")]
		[Cpp2IlInjected.Address(RVA = "0x207DA60", Offset = "0x207C460", VA = "0x18207DA60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
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
				if (inversed_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A5C")]
		[Cpp2IlInjected.Address(RVA = "0x207DE60", Offset = "0x207C860", VA = "0x18207DE60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005A5D")]
		[Cpp2IlInjected.Address(RVA = "0x207DEE0", Offset = "0x207C8E0", VA = "0x18207DEE0", Slot = "18")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008b
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
			if (inversed_)
			{
				bool value5 = inversed_;
				output.WriteBool(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005A5E")]
		[Cpp2IlInjected.Address(RVA = "0x207D160", Offset = "0x207BB60", VA = "0x18207D160", Slot = "19")]
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num10 = unknownFields.CalculateSize();
			return num10 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A5F")]
		[Cpp2IlInjected.Address(RVA = "0x207DC20", Offset = "0x207C620", VA = "0x18207DC20", Slot = "16")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionObjectiveCompleted other)
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
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A60")]
		[Cpp2IlInjected.Address(RVA = "0x207DB40", Offset = "0x207C540", VA = "0x18207DB40", Slot = "17")]
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
				bool flag = (inversed_ = input.ReadBool());
			}
			int num4 = default(int);
			if (num == 8)
			{
				num4 = (mission_ = input.ReadInt32());
			}
			if (num4 == 16)
			{
				int num5 = (stepID_ = input.ReadInt32());
			}
			goto IL_007b;
			IL_007b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005A61")]
		[Cpp2IlInjected.Address(RVA = "0x207D950", Offset = "0x207C350", VA = "0x18207D950", Slot = "23")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_0026;
				}
				bool flag = inversed_;
			}
			int num2 = mission_;
			goto IL_0026;
			IL_0026:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A62")]
		[Cpp2IlInjected.Address(RVA = "0x207DCA0", Offset = "0x207C6A0", VA = "0x18207DCA0", Slot = "24")]
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
							inversed_ = (byte)(int)obj2 != 0;
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

		[Cpp2IlInjected.Token(Token = "0x6005A63")]
		[Cpp2IlInjected.Address(RVA = "0x207D2A0", Offset = "0x207BCA0", VA = "0x18207D2A0", Slot = "25")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016, IL_0020, IL_002a
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			//IL_0029: Expected I4, but got I8
			//IL_0033: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				inversed_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A64")]
		[Cpp2IlInjected.Address(RVA = "0x207DFE0", Offset = "0x207C9E0", VA = "0x18207DFE0")]
		static ConditionMissionObjectiveCompleted()
		{
			Func<ConditionMissionObjectiveCompleted> func = default(Func<ConditionMissionObjectiveCompleted>);
			_parser = (MessageParser<ConditionMissionObjectiveCompleted>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A65")]
		[Cpp2IlInjected.Address(RVA = "0x207D6F0", Offset = "0x207C0F0", VA = "0x18207D6F0", Slot = "4")]
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
			bool flag = inversed_;
			bool result = default(bool);
			return result;
		}
	}
}
