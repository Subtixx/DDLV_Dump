using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000821")]
	public sealed class ConditionPlayerLevel : ICondition, IDataValidation, IMessage<ConditionPlayerLevel>, IMessage, IEquatable<ConditionPlayerLevel>, IDeepCloneable<ConditionPlayerLevel>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002870")]
		private static readonly MessageParser<ConditionPlayerLevel> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002871")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002872")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002873")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x4002874")]
		public const int PlayerLevelFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002875")]
		private int playerLevel_;

		[Cpp2IlInjected.Token(Token = "0x17001702")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005AF2")]
			[Cpp2IlInjected.Address(RVA = "0x24C8230", Offset = "0x24C6C30", VA = "0x1824C8230", Slot = "5")]
			get
			{
				string text = Operations.ToString(operator_);
				int num = playerLevel_;
				return $"PlayerLevel {text} {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001703")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005AF3")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "6")]
			get
			{
				return ConditionListener.PlayerLevel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001704")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionPlayerLevel> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005AF6")]
			[Cpp2IlInjected.Address(RVA = "0x24C82B0", Offset = "0x24C6CB0", VA = "0x1824C82B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001705")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005AF7")]
			[Cpp2IlInjected.Address(RVA = "0x24C8160", Offset = "0x24C6B60", VA = "0x1824C8160")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001706")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005AF8")]
			[Cpp2IlInjected.Address(RVA = "0x24C8310", Offset = "0x24C6D10", VA = "0x1824C8310", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001707")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005AFC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005AFD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001708")]
		[DebuggerNonUserCode]
		public int PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005AFE")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return playerLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005AFF")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				playerLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF1")]
		[Cpp2IlInjected.Address(RVA = "0x24C7D20", Offset = "0x24C6720", VA = "0x1824C7D20")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0009
			IProfilePlayer section = playerProfile.Section;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF5")]
		[Cpp2IlInjected.Address(RVA = "0x24C7CB0", Offset = "0x24C66B0", VA = "0x1824C7CB0", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			int protobufValue = playerLevel_;
			IntOperator intOperator = operator_;
			string text = default(string);
			Operations.DataValidationMinValue(1, intOperator, protobufValue, context, text);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionPlayerLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005AFA")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public ConditionPlayerLevel(ConditionPlayerLevel other)
		{
			IntOperator intOperator = (operator_ = other.operator_);
			int num = (playerLevel_ = other.playerLevel_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005AFB")]
		[Cpp2IlInjected.Address(RVA = "0x24C7C20", Offset = "0x24C6620", VA = "0x1824C7C20", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionPlayerLevel Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionPlayerLevel conditionPlayerLevel = new ConditionPlayerLevel();
			IntOperator intOperator = (conditionPlayerLevel.operator_ = operator_);
			int num = (conditionPlayerLevel.playerLevel_ = playerLevel_);
			UnknownFieldSet unknownFieldSet = (conditionPlayerLevel._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionPlayerLevel;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B00")]
		[Cpp2IlInjected.Address(RVA = "0x24C7DA0", Offset = "0x24C67A0", VA = "0x1824C7DA0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionPlayerLevel).TypeHandle && (IntPtr)playerLevel_ == (IntPtr)typeof(ConditionPlayerLevel).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B01")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionPlayerLevel other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				IntOperator intOperator = other.operator_;
				if (operator_ == intOperator)
				{
					int num = other.playerLevel_;
					if (playerLevel_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B02")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (operator_ != 0)
				{
				}
				if (playerLevel_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B03")]
		[Cpp2IlInjected.Address(RVA = "0x24C7FF0", Offset = "0x24C69F0", VA = "0x1824C7FF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B04")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (operator_ != 0)
			{
			}
			if (playerLevel_ != 0)
			{
				int value = playerLevel_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B05")]
		[Cpp2IlInjected.Address(RVA = "0x24C7B50", Offset = "0x24C6550", VA = "0x1824C7B50", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				IntOperator intOperator = operator_;
				num = 0;
				if (intOperator != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)intOperator);
				}
				int num3 = playerLevel_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B06")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionPlayerLevel other)
		{
			if (other != null)
			{
				IntOperator intOperator = other.operator_;
				if (intOperator != 0)
				{
					operator_ = intOperator;
				}
				int num = other.playerLevel_;
				if (num != 0)
				{
					playerLevel_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B07")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(operator_ = (IntOperator)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (playerLevel_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B08")]
		[Cpp2IlInjected.Address(RVA = "0x24C7E30", Offset = "0x24C6830", VA = "0x1824C7E30", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				IntOperator intOperator = operator_;
			}
			if (fieldNumber == 2)
			{
				int num = playerLevel_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B09")]
		[Cpp2IlInjected.Address(RVA = "0x24C7F20", Offset = "0x24C6920", VA = "0x1824C7F20", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				operator_ = (IntOperator)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			playerLevel_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0A")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				operator_ = IntOperator.Equal;
				break;
			case 2:
				playerLevel_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0B")]
		[Cpp2IlInjected.Address(RVA = "0x24C8050", Offset = "0x24C6A50", VA = "0x1824C8050")]
		static ConditionPlayerLevel()
		{
			Func<ConditionPlayerLevel> func = default(Func<ConditionPlayerLevel>);
			_parser = (MessageParser<ConditionPlayerLevel>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B0C")]
		[Cpp2IlInjected.Address(RVA = "0x24C7D20", Offset = "0x24C6720", VA = "0x1824C7D20", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0009
			IProfilePlayer section = playerProfile.Section;
			bool result = default(bool);
			return result;
		}
	}
}
