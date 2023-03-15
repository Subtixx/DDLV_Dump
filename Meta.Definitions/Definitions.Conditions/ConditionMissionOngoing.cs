using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200081B")]
	public sealed class ConditionMissionOngoing : ICondition, IDataValidation, IMessage<ConditionMissionOngoing>, IMessage, IEquatable<ConditionMissionOngoing>, IDeepCloneable<ConditionMissionOngoing>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400285B")]
		private static readonly MessageParser<ConditionMissionOngoing> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400285C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400285D")]
		public const int MissionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400285E")]
		private int mission_;

		[Cpp2IlInjected.Token(Token = "0x400285F")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002860")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170016EB")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005A92")]
			[Cpp2IlInjected.Address(RVA = "0x2080740", Offset = "0x207F140", VA = "0x182080740")]
			get
			{
				long num = Convert.ToInt64((uint)mission_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016EC")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005A94")]
			[Cpp2IlInjected.Address(RVA = "0x2080610", Offset = "0x207F010", VA = "0x182080610", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_003c
				long num = Convert.ToInt64((uint)mission_);
				string text = default(string);
				string text2 = text.Replace("Mission/MissionData/", "");
				if (!inversed_)
				{
				}
				return "Mission '" + text2 + "' " + "not ongoing";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016ED")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005A95")]
			[Cpp2IlInjected.Address(RVA = "0x2080730", Offset = "0x207F130", VA = "0x182080730", Slot = "6")]
			get
			{
				return ConditionListener.MissionOngoing;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016EE")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionOngoing> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005A98")]
			[Cpp2IlInjected.Address(RVA = "0x20807A0", Offset = "0x207F1A0", VA = "0x1820807A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016EF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A99")]
			[Cpp2IlInjected.Address(RVA = "0x2080540", Offset = "0x207EF40", VA = "0x182080540")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005A9A")]
			[Cpp2IlInjected.Address(RVA = "0x2080800", Offset = "0x207F200", VA = "0x182080800", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F1")]
		[DebuggerNonUserCode]
		public int Mission
		{
			[Cpp2IlInjected.Token(Token = "0x6005A9E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mission_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005A9F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F2")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005AA0")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005AA1")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A93")]
		[Cpp2IlInjected.Address(RVA = "0x2080030", Offset = "0x207EA30", VA = "0x182080030")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			if ((object)typeof(Item).TypeHandle != null)
			{
			}
			IProfileWorld section2 = worldProfile.Section;
			int num2 = mission_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A96")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A97")]
		[Cpp2IlInjected.Address(RVA = "0x207FED0", Offset = "0x207E8D0", VA = "0x18207FED0", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004b
			if (mission_ == 0)
			{
				context.AddInvalidMemberError("Please select a mission", "Mission");
			}
			MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
			if (parentOfType != null)
			{
				int iD = parentOfType.ID;
				int num = mission_;
				if ((object)typeof(Item).TypeHandle != null)
				{
					context.AddInvalidMemberError("Please don't use current mission inside MissionOngoing condition", "Mission");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A9B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionOngoing()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005A9C")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionMissionOngoing(ConditionMissionOngoing other)
		{
			int num = (mission_ = other.mission_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A9D")]
		[Cpp2IlInjected.Address(RVA = "0x207FE40", Offset = "0x207E840", VA = "0x18207FE40", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionMissionOngoing Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionMissionOngoing conditionMissionOngoing = new ConditionMissionOngoing();
			int num = (conditionMissionOngoing.mission_ = mission_);
			bool flag = (conditionMissionOngoing.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionMissionOngoing._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionOngoing;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AA2")]
		[Cpp2IlInjected.Address(RVA = "0x2080180", Offset = "0x207EB80", VA = "0x182080180", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mission_ == (IntPtr)typeof(ConditionMissionOngoing).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionMissionOngoing).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AA3")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionOngoing other)
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
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AA4")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (mission_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005AA5")]
		[Cpp2IlInjected.Address(RVA = "0x20803D0", Offset = "0x207EDD0", VA = "0x1820803D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AA6")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (mission_ != 0)
			{
				int value = mission_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AA7")]
		[Cpp2IlInjected.Address(RVA = "0x207FDB0", Offset = "0x207E7B0", VA = "0x18207FDB0", Slot = "12")]
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
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AA8")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionOngoing other)
		{
			if (other != null)
			{
				int num = other.mission_;
				if (num != 0)
				{
					mission_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005AA9")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (mission_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2080210", Offset = "0x207EC10", VA = "0x182080210", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = mission_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AAB")]
		[Cpp2IlInjected.Address(RVA = "0x2080300", Offset = "0x207ED00", VA = "0x182080300", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				mission_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AAC")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				mission_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AAD")]
		[Cpp2IlInjected.Address(RVA = "0x2080430", Offset = "0x207EE30", VA = "0x182080430")]
		static ConditionMissionOngoing()
		{
			Func<ConditionMissionOngoing> func = default(Func<ConditionMissionOngoing>);
			_parser = (MessageParser<ConditionMissionOngoing>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AAE")]
		[Cpp2IlInjected.Address(RVA = "0x2080030", Offset = "0x207EA30", VA = "0x182080030", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			if ((object)typeof(Item).TypeHandle != null)
			{
			}
			IProfileWorld section2 = worldProfile.Section;
			int num2 = mission_;
			bool result = default(bool);
			return result;
		}
	}
}
