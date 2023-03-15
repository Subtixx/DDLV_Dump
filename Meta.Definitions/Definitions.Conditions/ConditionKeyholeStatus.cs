using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Keyholes;
using Definitions.Options;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007F4")]
	public sealed class ConditionKeyholeStatus : ICondition, IDataValidation, IMessage<ConditionKeyholeStatus>, IMessage, IEquatable<ConditionKeyholeStatus>, IDeepCloneable<ConditionKeyholeStatus>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027C5")]
		private static readonly MessageParser<ConditionKeyholeStatus> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027C6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027C7")]
		public const int KeyholeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027C8")]
		private string keyhole_ = "";

		[Cpp2IlInjected.Token(Token = "0x40027C9")]
		public const int LevelFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027CA")]
		private int level_;

		[Cpp2IlInjected.Token(Token = "0x40027CB")]
		public const int StatusFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40027CC")]
		private KeyholeStatusOperator status_;

		[Cpp2IlInjected.Token(Token = "0x17001651")]
		public unsafe string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600581F")]
			[Cpp2IlInjected.Address(RVA = "0x207A690", Offset = "0x2079090", VA = "0x18207A690", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0060
				//IL_005f: Expected O, but got I4
				//IL_005f: Expected O, but got I4
				int num = 0;
				int num2 = 0;
				bool flag = default(bool);
				if (Descriptor.FindFieldByName("Keyhole").CustomOptions.TryGetMessage<AllFieldOptions, ChoiceOptions>(AllFieldOptions.Choice, out *(ChoiceOptions*)num) && flag)
				{
					string text = keyhole_;
					bool flag2 = default(bool);
					if (flag2)
					{
						goto IL_003f;
					}
				}
				string arg = keyhole_;
				goto IL_003f;
				IL_003f:
				KeyholeStatusOperator keyholeStatusOperator = status_;
				int num3 = level_;
				return $"'{arg}' KeyholeLevel {keyholeStatusOperator} {keyholeStatusOperator}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001652")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005820")]
			[Cpp2IlInjected.Address(RVA = "0x207A860", Offset = "0x2079260", VA = "0x18207A860", Slot = "6")]
			get
			{
				return ConditionListener.Keyhole;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001653")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionKeyholeStatus> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005823")]
			[Cpp2IlInjected.Address(RVA = "0x207A870", Offset = "0x2079270", VA = "0x18207A870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001654")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005824")]
			[Cpp2IlInjected.Address(RVA = "0x207A5C0", Offset = "0x2078FC0", VA = "0x18207A5C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001655")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005825")]
			[Cpp2IlInjected.Address(RVA = "0x207A8D0", Offset = "0x20792D0", VA = "0x18207A8D0", Slot = "13")]
			get
			{
				int num = 0;
				return Descriptor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001656")]
		[DebuggerNonUserCode]
		public string Keyhole
		{
			[Cpp2IlInjected.Token(Token = "0x6005829")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return keyhole_;
			}
			[Cpp2IlInjected.Token(Token = "0x600582A")]
			[Cpp2IlInjected.Address(RVA = "0x207A920", Offset = "0x2079320", VA = "0x18207A920")]
			set
			{
				string text = (keyhole_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001657")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x600582B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return level_;
			}
			[Cpp2IlInjected.Token(Token = "0x600582C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				level_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001658")]
		[DebuggerNonUserCode]
		public KeyholeStatusOperator Status
		{
			[Cpp2IlInjected.Token(Token = "0x600582D")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return status_;
			}
			[Cpp2IlInjected.Token(Token = "0x600582E")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				status_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600581D")]
		[Cpp2IlInjected.Address(RVA = "0x2079EE0", Offset = "0x20788E0", VA = "0x182079EE0")]
		private unsafe string GetEditorKeyholeName()
		{
			//Discarded unreachable code: IL_003e
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (Descriptor.FindFieldByName("Keyhole").CustomOptions.TryGetMessage<AllFieldOptions, ChoiceOptions>(AllFieldOptions.Choice, out *(ChoiceOptions*)num) && flag)
			{
				string text = keyhole_;
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
			}
			return keyhole_;
		}

		[Cpp2IlInjected.Token(Token = "0x600581E")]
		[Cpp2IlInjected.Address(RVA = "0x2079D30", Offset = "0x2078730", VA = "0x182079D30")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001f
			IProfileWorld section = worldProfile.Section;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			KeyholeStatusOperator keyholeStatusOperator = status_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005821")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005822")]
		[Cpp2IlInjected.Address(RVA = "0x2079B70", Offset = "0x2078570", VA = "0x182079B70", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004e
			//IL_003e: Expected O, but got I4
			KeyholeConfig keyholeConfig = KeyholeConfig.GetKeyholeConfig(keyhole_);
			if (keyholeConfig != null)
			{
				RepeatedField<CompletionLevel> levels_ = keyholeConfig.levels_;
				int num = level_;
				int count = ((RepeatedField<T>)(object)levels_).Count;
				int count2 = ((RepeatedField<T>)(object)keyholeConfig.levels_).Count;
				int num2 = default(int);
				string message = $"Cannot be higher then the config Levels.Count: {num2}";
				context.AddInvalidMemberError(message, "Level");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005826")]
		[Cpp2IlInjected.Address(RVA = "0x207A4D0", Offset = "0x2078ED0", VA = "0x18207A4D0")]
		[DebuggerNonUserCode]
		public ConditionKeyholeStatus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005827")]
		[Cpp2IlInjected.Address(RVA = "0x207A520", Offset = "0x2078F20", VA = "0x18207A520")]
		[DebuggerNonUserCode]
		public ConditionKeyholeStatus(ConditionKeyholeStatus other)
		{
			string text = (keyhole_ = other.keyhole_);
			int num = (level_ = other.level_);
			KeyholeStatusOperator keyholeStatusOperator = (status_ = other.status_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005828")]
		[Cpp2IlInjected.Address(RVA = "0x2079AA0", Offset = "0x20784A0", VA = "0x182079AA0", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionKeyholeStatus Clone()
		{
			//Discarded unreachable code: IL_0052
			ConditionKeyholeStatus conditionKeyholeStatus = new ConditionKeyholeStatus();
			conditionKeyholeStatus.keyhole_ = "";
			string text = (conditionKeyholeStatus.keyhole_ = keyhole_);
			int num = (conditionKeyholeStatus.level_ = level_);
			KeyholeStatusOperator keyholeStatusOperator = (conditionKeyholeStatus.status_ = status_);
			UnknownFieldSet unknownFieldSet = (conditionKeyholeStatus._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionKeyholeStatus;
		}

		[Cpp2IlInjected.Token(Token = "0x600582F")]
		[Cpp2IlInjected.Address(RVA = "0x2079E20", Offset = "0x2078820", VA = "0x182079E20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = keyhole_;
				bool flag = default(bool);
				if (!flag && level_ == (flag ? 1 : 0) && status_ == (flag ? KeyholeStatusOperator.NotEqual : KeyholeStatusOperator.Equal))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005830")]
		[Cpp2IlInjected.Address(RVA = "0x17FB860", Offset = "0x17FA260", VA = "0x1817FB860", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionKeyholeStatus other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.keyhole_;
				if (!(keyhole_ != text))
				{
					int num = other.level_;
					if (level_ == num)
					{
						KeyholeStatusOperator keyholeStatusOperator = other.status_;
						if (status_ == keyholeStatusOperator)
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

		[Cpp2IlInjected.Token(Token = "0x6005831")]
		[Cpp2IlInjected.Address(RVA = "0x17FB9E0", Offset = "0x17FA3E0", VA = "0x1817FB9E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0040
			int num = 0;
			string text = keyhole_;
			if (text.m_stringLength != num)
			{
				int hashCode = text.GetHashCode();
			}
			if (level_ != 0)
			{
			}
			if (status_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005832")]
		[Cpp2IlInjected.Address(RVA = "0x207A360", Offset = "0x2078D60", VA = "0x18207A360", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005833")]
		[Cpp2IlInjected.Address(RVA = "0x201B510", Offset = "0x2019F10", VA = "0x18201B510", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004f
			if (keyhole_.m_stringLength != 0)
			{
				string value = keyhole_;
				output.WriteString(value);
			}
			if (level_ != 0)
			{
				int value2 = level_;
				output.WriteInt32(value2);
			}
			if (status_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005834")]
		[Cpp2IlInjected.Address(RVA = "0x2079920", Offset = "0x2078320", VA = "0x182079920", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0075
			string text = keyhole_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			int num3 = level_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			KeyholeStatusOperator keyholeStatusOperator = status_;
			if (keyholeStatusOperator != 0)
			{
				int num5 = CodedOutputStream.ComputeEnumSize((int)keyholeStatusOperator);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005835")]
		[Cpp2IlInjected.Address(RVA = "0x207A100", Offset = "0x2078B00", VA = "0x18207A100", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionKeyholeStatus other)
		{
			//Discarded unreachable code: IL_005d
			if (other != null)
			{
				string text = other.keyhole_;
				if (text.m_stringLength != 0)
				{
					Keyhole = text;
				}
				int num = other.level_;
				if (num != 0)
				{
					level_ = num;
				}
				KeyholeStatusOperator keyholeStatusOperator = other.status_;
				if (keyholeStatusOperator != 0)
				{
					status_ = keyholeStatusOperator;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005836")]
		[Cpp2IlInjected.Address(RVA = "0x207A180", Offset = "0x2078B80", VA = "0x18207A180", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005e
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Keyhole = input.ReadString());
				}
				int num2 = default(int);
				if (num == 16)
				{
					num2 = (level_ = input.ReadInt32());
				}
				if (num2 == 24)
				{
					int num3 = (int)(status_ = (KeyholeStatusOperator)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005837")]
		[Cpp2IlInjected.Address(RVA = "0x207A000", Offset = "0x2078A00", VA = "0x18207A000", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					KeyholeStatusOperator keyholeStatusOperator = status_;
				}
				int num2 = level_;
			}
			string text = keyhole_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005838")]
		[Cpp2IlInjected.Address(RVA = "0x207A230", Offset = "0x2078C30", VA = "0x18207A230", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					status_ = (KeyholeStatusOperator)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					level_ = (int)obj;
					break;
				}
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005839")]
		[Cpp2IlInjected.Address(RVA = "0x2079A20", Offset = "0x2078420", VA = "0x182079A20", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					status_ = KeyholeStatusOperator.Equal;
					break;
				case 0:
					level_ = 0;
					break;
				}
			}
			else
			{
				Keyhole = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600583A")]
		[Cpp2IlInjected.Address(RVA = "0x207A3C0", Offset = "0x2078DC0", VA = "0x18207A3C0")]
		static ConditionKeyholeStatus()
		{
			Func<ConditionKeyholeStatus> func = default(Func<ConditionKeyholeStatus>);
			_parser = (MessageParser<ConditionKeyholeStatus>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600583B")]
		[Cpp2IlInjected.Address(RVA = "0x2079D30", Offset = "0x2078730", VA = "0x182079D30", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001f
			IProfileWorld section = worldProfile.Section;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			KeyholeStatusOperator keyholeStatusOperator = status_;
			bool result = default(bool);
			return result;
		}
	}
}
