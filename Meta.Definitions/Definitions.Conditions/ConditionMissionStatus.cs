using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200080E")]
	public sealed class ConditionMissionStatus : ICondition, IDataValidation, IMessage<ConditionMissionStatus>, IMessage, IEquatable<ConditionMissionStatus>, IDeepCloneable<ConditionMissionStatus>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002819")]
		private static readonly MessageParser<ConditionMissionStatus> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400281A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400281B")]
		public const int MissionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400281C")]
		private int mission_;

		[Cpp2IlInjected.Token(Token = "0x400281D")]
		public const int OperatorFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400281E")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x400281F")]
		public const int StateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002820")]
		private MissionState state_;

		[Cpp2IlInjected.Token(Token = "0x170016AD")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x60059AB")]
			[Cpp2IlInjected.Address(RVA = "0x2081710", Offset = "0x2080110", VA = "0x182081710")]
			get
			{
				long num = Convert.ToInt64((uint)mission_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AE")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60059AF")]
			[Cpp2IlInjected.Address(RVA = "0x2081540", Offset = "0x207FF40", VA = "0x182081540", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_003a
				long num = Convert.ToInt64((uint)mission_);
				string text = default(string);
				string text2 = text.Replace("Mission/MissionData/", "");
				IntOperator intOperator = operator_;
				MissionState missionState = state_;
				return $"Mission {text2} {text2} {text2}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AF")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60059B0")]
			[Cpp2IlInjected.Address(RVA = "0x2081680", Offset = "0x2080080", VA = "0x182081680", Slot = "6")]
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

		[Cpp2IlInjected.Token(Token = "0x170016B0")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionStatus> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60059B3")]
			[Cpp2IlInjected.Address(RVA = "0x2081770", Offset = "0x2080170", VA = "0x182081770")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60059B4")]
			[Cpp2IlInjected.Address(RVA = "0x2081470", Offset = "0x207FE70", VA = "0x182081470")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60059B5")]
			[Cpp2IlInjected.Address(RVA = "0x20817D0", Offset = "0x20801D0", VA = "0x1820817D0", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B3")]
		[DebuggerNonUserCode]
		public int Mission
		{
			[Cpp2IlInjected.Token(Token = "0x60059B9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mission_;
			}
			[Cpp2IlInjected.Token(Token = "0x60059BA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B4")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x60059BB")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x60059BC")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B5")]
		[DebuggerNonUserCode]
		public MissionState State
		{
			[Cpp2IlInjected.Token(Token = "0x60059BD")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x60059BE")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059AC")]
		[Cpp2IlInjected.Address(RVA = "0x2080EE0", Offset = "0x207F8E0", VA = "0x182080EE0")]
		public static MissionState GetCurrentState(Item missionItem, in WorldProfile worldProfile)
		{
			int itemID = missionItem.ItemID;
			if (worldProfile.Section == null)
			{
				IProfileWorld section = worldProfile.Section;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (section != null && section != null && (section == null || (long)section == 1))
				{
					itemID += itemID;
					uint num3 = num3 + 696;
				}
				int num4 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60059AD")]
		[Cpp2IlInjected.Address(RVA = "0x20811B0", Offset = "0x207FBB0", VA = "0x1820811B0")]
		public static ConditionListener GetListener(MissionState state)
		{
			while (state == MissionState.NotAvailableYet || state == MissionState.NotAvailableYet || state == MissionState.NotAvailableYet || state == MissionState.NotAvailableYet || state == (MissionState)1 || state != MissionState.Completed)
			{
			}
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059AE")]
		[Cpp2IlInjected.Address(RVA = "0x2080D10", Offset = "0x207F710", VA = "0x182080D10")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_003a
			int num = mission_;
			if (worldProfile.Section == null)
			{
				IProfileWorld section = worldProfile.Section;
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
				if (section != null && section != null && section != null && (long)section != 1)
				{
				}
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60059B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059B2")]
		[Cpp2IlInjected.Address(RVA = "0x2080AA0", Offset = "0x207F4A0", VA = "0x182080AA0", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0037
			int num = 0;
			MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
			if (parentOfType != null)
			{
				int iD = parentOfType.ID;
				int num2 = mission_;
				if ((object)typeof(Item).TypeHandle != null)
				{
					context.AddInvalidMemberError("Please don't use current mission inside MissionStatus condition", "Mission");
				}
			}
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60059B6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionStatus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60059B7")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public ConditionMissionStatus(ConditionMissionStatus other)
		{
			int num = (mission_ = other.mission_);
			IntOperator intOperator = (operator_ = other.operator_);
			MissionState missionState = (state_ = other.state_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60059B8")]
		[Cpp2IlInjected.Address(RVA = "0x2080A10", Offset = "0x207F410", VA = "0x182080A10", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionMissionStatus Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionMissionStatus conditionMissionStatus = new ConditionMissionStatus();
			int num = (conditionMissionStatus.mission_ = mission_);
			IntOperator intOperator = (conditionMissionStatus.operator_ = operator_);
			MissionState missionState = (conditionMissionStatus.state_ = state_);
			UnknownFieldSet unknownFieldSet = (conditionMissionStatus._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionStatus;
		}

		[Cpp2IlInjected.Token(Token = "0x60059BF")]
		[Cpp2IlInjected.Address(RVA = "0x2080C70", Offset = "0x207F670", VA = "0x182080C70", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mission_ == (IntPtr)typeof(ConditionMissionStatus).TypeHandle && (IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionMissionStatus).TypeHandle && (IntPtr)(void*)(int)state_ == (IntPtr)typeof(ConditionMissionStatus).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059C0")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionStatus other)
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
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059C1")]
		[Cpp2IlInjected.Address(RVA = "0x2081110", Offset = "0x207FB10", VA = "0x182081110", Slot = "2")]
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

		[Cpp2IlInjected.Token(Token = "0x60059C2")]
		[Cpp2IlInjected.Address(RVA = "0x2081300", Offset = "0x207FD00", VA = "0x182081300", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C3")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003c
			if (mission_ != 0)
			{
				int value = mission_;
				output.WriteInt32(value);
			}
			if (operator_ != 0)
			{
			}
			if (state_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C4")]
		[Cpp2IlInjected.Address(RVA = "0x2080910", Offset = "0x207F310", VA = "0x182080910", Slot = "12")]
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
				IntOperator intOperator = operator_;
				if (intOperator != 0)
				{
					int num4 = CodedOutputStream.ComputeEnumSize((int)intOperator);
					num4++;
					num2 += num4;
				}
				MissionState missionState = state_;
				if (missionState != 0)
				{
					int num5 = CodedOutputStream.ComputeEnumSize((int)missionState);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60059C5")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionStatus other)
		{
			if (other != null)
			{
				int num = other.mission_;
				if (num != 0)
				{
					mission_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x60059C6")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "10")]
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
					num3 = (int)(operator_ = (IntOperator)input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (int)(state_ = (MissionState)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059C7")]
		[Cpp2IlInjected.Address(RVA = "0x2081020", Offset = "0x207FA20", VA = "0x182081020", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x60059C8")]
		[Cpp2IlInjected.Address(RVA = "0x20811E0", Offset = "0x207FBE0", VA = "0x1820811E0", Slot = "17")]
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
				mission_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059C9")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				state_ = MissionState.NotAvailableYet;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059CA")]
		[Cpp2IlInjected.Address(RVA = "0x2081360", Offset = "0x207FD60", VA = "0x182081360")]
		static ConditionMissionStatus()
		{
			Func<ConditionMissionStatus> func = default(Func<ConditionMissionStatus>);
			_parser = (MessageParser<ConditionMissionStatus>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059CB")]
		[Cpp2IlInjected.Address(RVA = "0x2080C60", Offset = "0x207F660", VA = "0x182080C60", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			return Evaluate(in playerProfile, in worldProfile, context);
		}
	}
}
