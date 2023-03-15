using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200080A")]
	public sealed class ConditionMissionAvailable : ICondition, IDataValidation, IMessage<ConditionMissionAvailable>, IMessage, IEquatable<ConditionMissionAvailable>, IDeepCloneable<ConditionMissionAvailable>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400280B")]
		private static readonly MessageParser<ConditionMissionAvailable> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400280C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400280D")]
		public const int MissionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400280E")]
		private int mission_;

		[Cpp2IlInjected.Token(Token = "0x400280F")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002810")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x1700169D")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600596B")]
			[Cpp2IlInjected.Address(RVA = "0x207C4C0", Offset = "0x207AEC0", VA = "0x18207C4C0")]
			get
			{
				long num = Convert.ToInt64((uint)mission_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169E")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600596D")]
			[Cpp2IlInjected.Address(RVA = "0x207C390", Offset = "0x207AD90", VA = "0x18207C390", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_003c
				long num = Convert.ToInt64((uint)mission_);
				string text = default(string);
				string text2 = text.Replace("Mission/MissionData/", "");
				if (!inversed_)
				{
				}
				return "Mission '" + text2 + "' " + "not available";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169F")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600596E")]
			[Cpp2IlInjected.Address(RVA = "0x207C4B0", Offset = "0x207AEB0", VA = "0x18207C4B0", Slot = "6")]
			get
			{
				return ConditionListener.MissionAvailable;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A0")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionMissionAvailable> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005971")]
			[Cpp2IlInjected.Address(RVA = "0x207C520", Offset = "0x207AF20", VA = "0x18207C520")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005972")]
			[Cpp2IlInjected.Address(RVA = "0x207C2C0", Offset = "0x207ACC0", VA = "0x18207C2C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005973")]
			[Cpp2IlInjected.Address(RVA = "0x207C580", Offset = "0x207AF80", VA = "0x18207C580", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A3")]
		[DebuggerNonUserCode]
		public int Mission
		{
			[Cpp2IlInjected.Token(Token = "0x6005977")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mission_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005978")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A4")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005979")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x600597A")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600596C")]
		[Cpp2IlInjected.Address(RVA = "0x207BE30", Offset = "0x207A830", VA = "0x18207BE30")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600596F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005970")]
		[Cpp2IlInjected.Address(RVA = "0x207BD00", Offset = "0x207A700", VA = "0x18207BD00", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0032
			MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
			if (parentOfType != null)
			{
				int iD = parentOfType.ID;
				int num = mission_;
				if ((object)typeof(Item).TypeHandle != null)
				{
					context.AddInvalidMemberError("Please don't use current mission inside MissionAvailable condition", "Mission");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005974")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionMissionAvailable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005975")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionMissionAvailable(ConditionMissionAvailable other)
		{
			int num = (mission_ = other.mission_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005976")]
		[Cpp2IlInjected.Address(RVA = "0x207BC70", Offset = "0x207A670", VA = "0x18207BC70", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionMissionAvailable Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionMissionAvailable conditionMissionAvailable = new ConditionMissionAvailable();
			int num = (conditionMissionAvailable.mission_ = mission_);
			bool flag = (conditionMissionAvailable.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionMissionAvailable._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionMissionAvailable;
		}

		[Cpp2IlInjected.Token(Token = "0x600597B")]
		[Cpp2IlInjected.Address(RVA = "0x207BF00", Offset = "0x207A900", VA = "0x18207BF00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mission_ == (IntPtr)typeof(ConditionMissionAvailable).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionMissionAvailable).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600597C")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionMissionAvailable other)
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

		[Cpp2IlInjected.Token(Token = "0x600597D")]
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

		[Cpp2IlInjected.Token(Token = "0x600597E")]
		[Cpp2IlInjected.Address(RVA = "0x207C150", Offset = "0x207AB50", VA = "0x18207C150", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600597F")]
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

		[Cpp2IlInjected.Token(Token = "0x6005980")]
		[Cpp2IlInjected.Address(RVA = "0x207BBE0", Offset = "0x207A5E0", VA = "0x18207BBE0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6005981")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionMissionAvailable other)
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

		[Cpp2IlInjected.Token(Token = "0x6005982")]
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

		[Cpp2IlInjected.Token(Token = "0x6005983")]
		[Cpp2IlInjected.Address(RVA = "0x207BF90", Offset = "0x207A990", VA = "0x18207BF90", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x6005984")]
		[Cpp2IlInjected.Address(RVA = "0x207C080", Offset = "0x207AA80", VA = "0x18207C080", Slot = "17")]
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

		[Cpp2IlInjected.Token(Token = "0x6005985")]
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

		[Cpp2IlInjected.Token(Token = "0x6005986")]
		[Cpp2IlInjected.Address(RVA = "0x207C1B0", Offset = "0x207ABB0", VA = "0x18207C1B0")]
		static ConditionMissionAvailable()
		{
			Func<ConditionMissionAvailable> func = default(Func<ConditionMissionAvailable>);
			_parser = (MessageParser<ConditionMissionAvailable>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005987")]
		[Cpp2IlInjected.Address(RVA = "0x207BE30", Offset = "0x207A830", VA = "0x18207BE30", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = mission_;
			bool result = default(bool);
			return result;
		}
	}
}
