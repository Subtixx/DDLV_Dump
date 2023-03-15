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
	[Cpp2IlInjected.Token(Token = "0x2000813")]
	public sealed class ConditionMissionStepCompleted : ICondition, IMissionStep, IMissionItem, IDataValidation, IMessage<ConditionMissionStepCompleted>, IMessage, IEquatable<ConditionMissionStepCompleted>, IDeepCloneable<ConditionMissionStepCompleted>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400282F")]
		private static readonly MessageParser<ConditionMissionStepCompleted> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002830")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002831")]
		public const int MissionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002832")]
		private int mission_;

		[Cpp2IlInjected.Token(Token = "0x4002833")]
		public const int StepIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002834")]
		private int stepID_;

		[Cpp2IlInjected.Token(Token = "0x4002835")]
		public const int InversedFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002836")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170016BF")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x60059F8")]
			[Cpp2IlInjected.Address(RVA = "0x2082790", Offset = "0x2081190", VA = "0x182082790", Slot = "10")]
			get
			{
				long num = Convert.ToInt64((uint)mission_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C0")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60059FA")]
			[Cpp2IlInjected.Address(RVA = "0x2082390", Offset = "0x2080D90", VA = "0x182082390", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_00f9
				string[] array;
				string text = default(string);
				while (true)
				{
					array = new string[7];
					if ("Step " != null && "Step " == null)
					{
						continue;
					}
					array[0] = "Step ";
					string stepInfo = StepInfo;
					if (stepInfo != null && stepInfo == null)
					{
						continue;
					}
					array[1] = stepInfo;
					if (" " != null && " " == null)
					{
						continue;
					}
					array[2] = " ";
					stepInfo = "completed";
					if (inversed_)
					{
						stepInfo = "not completed";
					}
					if (stepInfo != null && " " == null)
					{
						continue;
					}
					array[3] = stepInfo;
					if (" in '" != null && " in '" == null)
					{
						continue;
					}
					array[4] = " in '";
					long num = Convert.ToInt64((uint)mission_);
					string text2 = text.Replace("Mission/MissionData/", "");
					if (text2 == null || text2 != null)
					{
						array[5] = text2;
						if ("'" == null || "'" != null)
						{
							break;
						}
					}
				}
				array[6] = "'";
				return string.Concat(array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C1")]
		private string StepInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60059FB")]
			[Cpp2IlInjected.Address(RVA = "0x2082850", Offset = "0x2081250", VA = "0x182082850")]
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

		[Cpp2IlInjected.Token(Token = "0x170016C2")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60059FC")]
			[Cpp2IlInjected.Address(RVA = "0x17EC850", Offset = "0x17EB250", VA = "0x1817EC850", Slot = "6")]
			get
			{
				return ConditionListener.MissionStepChanged;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C3")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionStepCompleted> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60059FF")]
			[Cpp2IlInjected.Address(RVA = "0x20827F0", Offset = "0x20811F0", VA = "0x1820827F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A00")]
			[Cpp2IlInjected.Address(RVA = "0x20822C0", Offset = "0x2080CC0", VA = "0x1820822C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A01")]
			[Cpp2IlInjected.Address(RVA = "0x2082A50", Offset = "0x2081450", VA = "0x182082A50", Slot = "16")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C6")]
		[DebuggerNonUserCode]
		public int Mission
		{
			[Cpp2IlInjected.Token(Token = "0x6005A05")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mission_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A06")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C7")]
		[DebuggerNonUserCode]
		public int StepID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A07")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "8")]
			get
			{
				return stepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A08")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0", Slot = "9")]
			set
			{
				stepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016C8")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005A09")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A0A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059F9")]
		[Cpp2IlInjected.Address(RVA = "0x2081DD0", Offset = "0x20807D0", VA = "0x182081DD0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0017
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			int num2 = stepID_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60059FD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059FE")]
		[Cpp2IlInjected.Address(RVA = "0x2081A40", Offset = "0x2080440", VA = "0x182081A40", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6005A02")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionStepCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005A03")]
		[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
		[DebuggerNonUserCode]
		public ConditionMissionStepCompleted(ConditionMissionStepCompleted other)
		{
			int num = (mission_ = other.mission_);
			int num2 = (stepID_ = other.stepID_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A04")]
		[Cpp2IlInjected.Address(RVA = "0x20819B0", Offset = "0x20803B0", VA = "0x1820819B0", Slot = "18")]
		[DebuggerNonUserCode]
		public ConditionMissionStepCompleted Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionMissionStepCompleted conditionMissionStepCompleted = new ConditionMissionStepCompleted();
			int num = (conditionMissionStepCompleted.mission_ = mission_);
			int num2 = (conditionMissionStepCompleted.stepID_ = stepID_);
			bool flag = (conditionMissionStepCompleted.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionMissionStepCompleted._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionStepCompleted;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A0B")]
		[Cpp2IlInjected.Address(RVA = "0x2081EA0", Offset = "0x20808A0", VA = "0x182081EA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mission_ == (IntPtr)typeof(ConditionMissionStepCompleted).TypeHandle && (IntPtr)stepID_ == (IntPtr)typeof(ConditionMissionStepCompleted).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionMissionStepCompleted).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A0C")]
		[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "17")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionStepCompleted other)
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
						bool flag = other.inversed_;
						if (inversed_ == flag)
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

		[Cpp2IlInjected.Token(Token = "0x6005A0D")]
		[Cpp2IlInjected.Address(RVA = "0x75BE10", Offset = "0x75A810", VA = "0x18075BE10", Slot = "2")]
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
				if (inversed_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2082150", Offset = "0x2080B50", VA = "0x182082150", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005A0F")]
		[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "14")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
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
			if (inversed_)
			{
				bool value3 = inversed_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005A10")]
		[Cpp2IlInjected.Address(RVA = "0x20818E0", Offset = "0x20802E0", VA = "0x1820818E0", Slot = "15")]
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A11")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionStepCompleted other)
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
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A12")]
		[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "13")]
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
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A13")]
		[Cpp2IlInjected.Address(RVA = "0x2081F40", Offset = "0x2080940", VA = "0x182081F40", Slot = "19")]
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
				bool flag = inversed_;
			}
			int num2 = mission_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A14")]
		[Cpp2IlInjected.Address(RVA = "0x2082030", Offset = "0x2080A30", VA = "0x182082030", Slot = "20")]
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
					inversed_ = (byte)(int)obj2 != 0;
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

		[Cpp2IlInjected.Token(Token = "0x6005A15")]
		[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "21")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				inversed_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A16")]
		[Cpp2IlInjected.Address(RVA = "0x20821B0", Offset = "0x2080BB0", VA = "0x1820821B0")]
		static ConditionMissionStepCompleted()
		{
			Func<ConditionMissionStepCompleted> func = default(Func<ConditionMissionStepCompleted>);
			_parser = (MessageParser<ConditionMissionStepCompleted>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A17")]
		[Cpp2IlInjected.Address(RVA = "0x2081DD0", Offset = "0x20807D0", VA = "0x182081DD0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0017
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			int num2 = stepID_;
			bool result = default(bool);
			return result;
		}
	}
}
