using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DFE")]
	public sealed class ActionNewMissionStep : IMessage<ActionNewMissionStep>, IMessage, IEquatable<ActionNewMissionStep>, IDeepCloneable<ActionNewMissionStep>, IMessageFieldAccessor, IAction, IMissionItem, IMissionStep
	{
		[Cpp2IlInjected.Token(Token = "0x40038C8")]
		private static readonly MessageParser<ActionNewMissionStep> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038C9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038CA")]
		public const int MissionIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038CB")]
		private int missionID_;

		[Cpp2IlInjected.Token(Token = "0x40038CC")]
		public const int StepIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40038CD")]
		private int stepID_;

		[Cpp2IlInjected.Token(Token = "0x40038CE")]
		public const int CanOverrideActiveFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40038CF")]
		private bool canOverrideActive_;

		[Cpp2IlInjected.Token(Token = "0x17001463")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionNewMissionStep> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007560")]
			[Cpp2IlInjected.Address(RVA = "0x1E33F80", Offset = "0x1E32980", VA = "0x181E33F80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001464")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007561")]
			[Cpp2IlInjected.Address(RVA = "0x1E33D30", Offset = "0x1E32730", VA = "0x181E33D30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001465")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007562")]
			[Cpp2IlInjected.Address(RVA = "0x1E341E0", Offset = "0x1E32BE0", VA = "0x181E341E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001466")]
		[DebuggerNonUserCode]
		public int MissionID
		{
			[Cpp2IlInjected.Token(Token = "0x6007566")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return missionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007567")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				missionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001467")]
		[DebuggerNonUserCode]
		public int StepID
		{
			[Cpp2IlInjected.Token(Token = "0x6007568")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "17")]
			get
			{
				return stepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007569")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0", Slot = "18")]
			set
			{
				stepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001468")]
		[DebuggerNonUserCode]
		public bool CanOverrideActive
		{
			[Cpp2IlInjected.Token(Token = "0x600756A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return canOverrideActive_;
			}
			[Cpp2IlInjected.Token(Token = "0x600756B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				canOverrideActive_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001469")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6007577")]
			[Cpp2IlInjected.Address(RVA = "0x1E33EC0", Offset = "0x1E328C0", VA = "0x181E33EC0", Slot = "16")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146A")]
		private string MissionName
		{
			[Cpp2IlInjected.Token(Token = "0x6007578")]
			[Cpp2IlInjected.Address(RVA = "0x1E33F20", Offset = "0x1E32920", VA = "0x181E33F20")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146B")]
		private string StepName
		{
			[Cpp2IlInjected.Token(Token = "0x6007579")]
			[Cpp2IlInjected.Address(RVA = "0x1E33FE0", Offset = "0x1E329E0", VA = "0x181E33FE0")]
			get
			{
				//Discarded unreachable code: IL_0070
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)missionID_);
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

		[Cpp2IlInjected.Token(Token = "0x1700146C")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600757B")]
			[Cpp2IlInjected.Address(RVA = "0x1E33E00", Offset = "0x1E32800", VA = "0x181E33E00", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				string stepName = StepName;
				string text = default(string);
				return "Add 'MissionStep': " + text + " - " + stepName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007563")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActionNewMissionStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007564")]
		[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
		[DebuggerNonUserCode]
		public ActionNewMissionStep(ActionNewMissionStep other)
		{
			int num = (missionID_ = other.missionID_);
			int num2 = (stepID_ = other.stepID_);
			bool flag = (canOverrideActive_ = other.canOverrideActive_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007565")]
		[Cpp2IlInjected.Address(RVA = "0x1E33860", Offset = "0x1E32260", VA = "0x181E33860", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionNewMissionStep Clone()
		{
			//Discarded unreachable code: IL_0047
			ActionNewMissionStep actionNewMissionStep = new ActionNewMissionStep();
			int num = (actionNewMissionStep.missionID_ = missionID_);
			int num2 = (actionNewMissionStep.stepID_ = stepID_);
			bool flag = (actionNewMissionStep.canOverrideActive_ = canOverrideActive_);
			UnknownFieldSet unknownFieldSet = (actionNewMissionStep._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionNewMissionStep;
		}

		[Cpp2IlInjected.Token(Token = "0x600756C")]
		[Cpp2IlInjected.Address(RVA = "0x1E338F0", Offset = "0x1E322F0", VA = "0x181E338F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)missionID_ == (IntPtr)typeof(ActionNewMissionStep).TypeHandle && (IntPtr)stepID_ == (IntPtr)typeof(ActionNewMissionStep).TypeHandle && (IntPtr)(canOverrideActive_ ? 1 : 0) == (IntPtr)typeof(ActionNewMissionStep).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600756D")]
		[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionNewMissionStep other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.missionID_;
				if (missionID_ == num)
				{
					int num2 = other.stepID_;
					if (stepID_ == num2)
					{
						bool flag = other.canOverrideActive_;
						if (canOverrideActive_ == flag)
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

		[Cpp2IlInjected.Token(Token = "0x600756E")]
		[Cpp2IlInjected.Address(RVA = "0x75BE10", Offset = "0x75A810", VA = "0x18075BE10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (missionID_ != 0)
				{
				}
				if (stepID_ != 0)
				{
				}
				if (canOverrideActive_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600756F")]
		[Cpp2IlInjected.Address(RVA = "0x1E33BA0", Offset = "0x1E325A0", VA = "0x181E33BA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007570")]
		[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (missionID_ != 0)
			{
				int value = missionID_;
				output.WriteInt32(value);
			}
			if (stepID_ != 0)
			{
				int value2 = stepID_;
				output.WriteInt32(value2);
			}
			if (canOverrideActive_)
			{
				bool value3 = canOverrideActive_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007571")]
		[Cpp2IlInjected.Address(RVA = "0x1E33790", Offset = "0x1E32190", VA = "0x181E33790", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = missionID_;
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

		[Cpp2IlInjected.Token(Token = "0x6007572")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionNewMissionStep other)
		{
			if (other != null)
			{
				int num = other.missionID_;
				if (num != 0)
				{
					missionID_ = num;
				}
				int num2 = other.stepID_;
				if (num2 != 0)
				{
					stepID_ = num2;
				}
				bool flag = other.canOverrideActive_;
				if (flag)
				{
					canOverrideActive_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007573")]
		[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (missionID_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (stepID_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					bool flag = (canOverrideActive_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007574")]
		[Cpp2IlInjected.Address(RVA = "0x1E33990", Offset = "0x1E32390", VA = "0x181E33990", Slot = "11")]
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
				bool flag = canOverrideActive_;
			}
			int num2 = missionID_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007575")]
		[Cpp2IlInjected.Address(RVA = "0x1E33A80", Offset = "0x1E32480", VA = "0x181E33A80", Slot = "12")]
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
					canOverrideActive_ = (byte)(int)obj2 != 0;
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
				missionID_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007576")]
		[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				canOverrideActive_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600757A")]
		[Cpp2IlInjected.Address(RVA = "0x1E33700", Offset = "0x1E32100", VA = "0x181E33700", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = missionID_;
		}

		[Cpp2IlInjected.Token(Token = "0x600757C")]
		[Cpp2IlInjected.Address(RVA = "0x1E33C20", Offset = "0x1E32620", VA = "0x181E33C20")]
		static ActionNewMissionStep()
		{
			Func<ActionNewMissionStep> func = default(Func<ActionNewMissionStep>);
			_parser = (MessageParser<ActionNewMissionStep>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
