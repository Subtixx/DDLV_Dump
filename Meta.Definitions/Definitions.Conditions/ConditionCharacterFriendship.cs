using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007DC")]
	public sealed class ConditionCharacterFriendship : ICondition, IDataValidation, IMessage<ConditionCharacterFriendship>, IMessage, IEquatable<ConditionCharacterFriendship>, IDeepCloneable<ConditionCharacterFriendship>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400276B")]
		private static readonly MessageParser<ConditionCharacterFriendship> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400276C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400276D")]
		public const int CharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400276E")]
		private int character_;

		[Cpp2IlInjected.Token(Token = "0x400276F")]
		public const int OperatorFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002770")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x4002771")]
		public const int FriendshipLevelFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002772")]
		private int friendshipLevel_;

		[Cpp2IlInjected.Token(Token = "0x170015F2")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x600569E")]
			[Cpp2IlInjected.Address(RVA = "0x3214160", Offset = "0x3212B60", VA = "0x183214160")]
			get
			{
				long num = Convert.ToInt64((uint)character_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F3")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60056A0")]
			[Cpp2IlInjected.Address(RVA = "0x3214290", Offset = "0x3212C90", VA = "0x183214290", Slot = "5")]
			get
			{
				//IL_0027: Expected O, but got I4
				int num = character_;
				string text = Operations.ToString(operator_);
				int num2 = friendshipLevel_;
				return $"{num} friendship {text} {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F4")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60056A1")]
			[Cpp2IlInjected.Address(RVA = "0x20BE200", Offset = "0x20BCC00", VA = "0x1820BE200", Slot = "6")]
			get
			{
				return ConditionListener.FriendshipLevel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F5")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCharacterFriendship> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60056A4")]
			[Cpp2IlInjected.Address(RVA = "0x3214340", Offset = "0x3212D40", VA = "0x183214340")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60056A5")]
			[Cpp2IlInjected.Address(RVA = "0x32141C0", Offset = "0x3212BC0", VA = "0x1832141C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60056A6")]
			[Cpp2IlInjected.Address(RVA = "0x32143A0", Offset = "0x3212DA0", VA = "0x1832143A0", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F8")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x60056AA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return character_;
			}
			[Cpp2IlInjected.Token(Token = "0x60056AB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				character_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F9")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x60056AC")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x60056AD")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FA")]
		[DebuggerNonUserCode]
		public int FriendshipLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60056AE")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return friendshipLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x60056AF")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				friendshipLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600569F")]
		[Cpp2IlInjected.Address(RVA = "0x3213BE0", Offset = "0x32125E0", VA = "0x183213BE0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0043
			if (character_ == 0)
			{
				int num = 0;
			}
			IProfileWorld section = worldProfile.Section;
			int num2 = character_;
			int num3 = 0;
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
			int protobufValue = friendshipLevel_;
			IntOperator intOperator = operator_;
			return Operations.Evaluate(num3, intOperator, protobufValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60056A2")]
		[Cpp2IlInjected.Address(RVA = "0x3213E10", Offset = "0x3212810", VA = "0x183213E10", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			//IL_0041: Expected O, but got I4
			int num = character_;
			if (data.ownerCharacter_ == num)
			{
				IntOperator intOperator = operator_;
				if (intOperator == IntOperator.GreaterThan)
				{
					int num2 = friendshipLevel_;
				}
				if (intOperator == IntOperator.GreaterThanOrEqual)
				{
					int num3 = friendshipLevel_;
					if (num3 > 0)
					{
						return LockedInfo.New("menu.dialog_locked_friendship_level", "level", num3);
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60056A3")]
		[Cpp2IlInjected.Address(RVA = "0x3213920", Offset = "0x3212320", VA = "0x183213920", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0032
			if (character_ == 0)
			{
				context.AddInvalidMemberError("Please select a character", "Character");
			}
			int protobufValue = friendshipLevel_;
			IntOperator intOperator = operator_;
			string text = default(string);
			Operations.DataValidationMinValue(1, intOperator, protobufValue, context, text);
		}

		[Cpp2IlInjected.Token(Token = "0x60056A7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionCharacterFriendship()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60056A8")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public ConditionCharacterFriendship(ConditionCharacterFriendship other)
		{
			int num = (character_ = other.character_);
			IntOperator intOperator = (operator_ = other.operator_);
			int num2 = (friendshipLevel_ = other.friendshipLevel_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60056A9")]
		[Cpp2IlInjected.Address(RVA = "0x3213890", Offset = "0x3212290", VA = "0x183213890", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionCharacterFriendship Clone()
		{
			//Discarded unreachable code: IL_0047
			ConditionCharacterFriendship conditionCharacterFriendship = new ConditionCharacterFriendship();
			int num = (conditionCharacterFriendship.character_ = character_);
			IntOperator intOperator = (conditionCharacterFriendship.operator_ = operator_);
			int num2 = (conditionCharacterFriendship.friendshipLevel_ = friendshipLevel_);
			UnknownFieldSet unknownFieldSet = (conditionCharacterFriendship._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCharacterFriendship;
		}

		[Cpp2IlInjected.Token(Token = "0x60056B0")]
		[Cpp2IlInjected.Address(RVA = "0x3213B40", Offset = "0x3212540", VA = "0x183213B40", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)character_ == (IntPtr)typeof(ConditionCharacterFriendship).TypeHandle && (IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionCharacterFriendship).TypeHandle && (IntPtr)friendshipLevel_ == (IntPtr)typeof(ConditionCharacterFriendship).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056B1")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCharacterFriendship other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.character_;
				if (character_ == num)
				{
					IntOperator intOperator = other.operator_;
					if (operator_ == intOperator)
					{
						int num2 = other.friendshipLevel_;
						if (friendshipLevel_ == num2)
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

		[Cpp2IlInjected.Token(Token = "0x60056B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DF83C0", Offset = "0x1DF6DC0", VA = "0x181DF83C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (character_ != 0)
				{
				}
				if (operator_ != 0)
				{
				}
				if (friendshipLevel_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60056B3")]
		[Cpp2IlInjected.Address(RVA = "0x3213FF0", Offset = "0x32129F0", VA = "0x183213FF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60056B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			if (character_ != 0)
			{
				int value = character_;
				output.WriteInt32(value);
			}
			if (operator_ != 0)
			{
			}
			if (friendshipLevel_ != 0)
			{
				int value2 = friendshipLevel_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60056B5")]
		[Cpp2IlInjected.Address(RVA = "0x3213790", Offset = "0x3212190", VA = "0x183213790", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = character_;
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
				int num5 = friendshipLevel_;
				if (num5 != 0)
				{
					int num6 = CodedOutputStream.ComputeInt32Size(num5);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60056B6")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCharacterFriendship other)
		{
			if (other != null)
			{
				int num = other.character_;
				if (num != 0)
				{
					character_ = num;
				}
				IntOperator intOperator = other.operator_;
				if (intOperator != 0)
				{
					operator_ = intOperator;
				}
				int num2 = other.friendshipLevel_;
				if (num2 != 0)
				{
					friendshipLevel_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056B7")]
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
					int num2 = (character_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (int)(operator_ = (IntOperator)input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (friendshipLevel_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056B8")]
		[Cpp2IlInjected.Address(RVA = "0x3213D30", Offset = "0x3212730", VA = "0x183213D30", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = character_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056B9")]
		[Cpp2IlInjected.Address(RVA = "0x3213ED0", Offset = "0x32128D0", VA = "0x183213ED0", Slot = "17")]
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
					friendshipLevel_ = (int)obj2;
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
				character_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056BA")]
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
				friendshipLevel_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056BB")]
		[Cpp2IlInjected.Address(RVA = "0x3214050", Offset = "0x3212A50", VA = "0x183214050")]
		static ConditionCharacterFriendship()
		{
			Func<ConditionCharacterFriendship> func = default(Func<ConditionCharacterFriendship>);
			_parser = (MessageParser<ConditionCharacterFriendship>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056BC")]
		[Cpp2IlInjected.Address(RVA = "0x32139E0", Offset = "0x32123E0", VA = "0x1832139E0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0043
			if (character_ == 0)
			{
				int num = 0;
			}
			IProfileWorld section = worldProfile.Section;
			int num2 = character_;
			int num3 = 0;
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
			int protobufValue = friendshipLevel_;
			IntOperator intOperator = operator_;
			return Operations.Evaluate(num3, intOperator, protobufValue);
		}
	}
}
