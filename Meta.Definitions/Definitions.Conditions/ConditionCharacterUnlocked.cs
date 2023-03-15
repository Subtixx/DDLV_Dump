using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007E0")]
	public sealed class ConditionCharacterUnlocked : ICondition, IDataValidation, IMessage<ConditionCharacterUnlocked>, IMessage, IEquatable<ConditionCharacterUnlocked>, IDeepCloneable<ConditionCharacterUnlocked>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400277B")]
		private static readonly MessageParser<ConditionCharacterUnlocked> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400277C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400277D")]
		public const int CharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400277E")]
		private int character_;

		[Cpp2IlInjected.Token(Token = "0x400277F")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002780")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001603")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x60056E0")]
			[Cpp2IlInjected.Address(RVA = "0x32154C0", Offset = "0x3213EC0", VA = "0x1832154C0")]
			get
			{
				long num = Convert.ToInt64((uint)character_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001604")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60056E2")]
			[Cpp2IlInjected.Address(RVA = "0x32155F0", Offset = "0x3213FF0", VA = "0x1832155F0", Slot = "5")]
			get
			{
				//IL_0020: Expected O, but got I8
				//IL_0038: Expected O, but got I8
				if (inversed_)
				{
					long num = Convert.ToInt64((uint)character_);
					return $"Character {num} is locked";
				}
				long num2 = Convert.ToInt64((uint)character_);
				return $"Character {num2} is unlocked";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001605")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60056E3")]
			[Cpp2IlInjected.Address(RVA = "0x20BE290", Offset = "0x20BCC90", VA = "0x1820BE290", Slot = "6")]
			get
			{
				return ConditionListener.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001606")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCharacterUnlocked> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60056E6")]
			[Cpp2IlInjected.Address(RVA = "0x3215720", Offset = "0x3214120", VA = "0x183215720")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001607")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60056E7")]
			[Cpp2IlInjected.Address(RVA = "0x3215520", Offset = "0x3213F20", VA = "0x183215520")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001608")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60056E8")]
			[Cpp2IlInjected.Address(RVA = "0x3215780", Offset = "0x3214180", VA = "0x183215780", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001609")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x60056EC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return character_;
			}
			[Cpp2IlInjected.Token(Token = "0x60056ED")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				character_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160A")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x60056EE")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x60056EF")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056E1")]
		[Cpp2IlInjected.Address(RVA = "0x3215030", Offset = "0x3213A30", VA = "0x183215030")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = character_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60056E4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056E5")]
		[Cpp2IlInjected.Address(RVA = "0x3214FC0", Offset = "0x32139C0", VA = "0x183214FC0", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (character_ == 0)
			{
				context.AddInvalidMemberError("Please select a character", "Character");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056E9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionCharacterUnlocked()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60056EA")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionCharacterUnlocked(ConditionCharacterUnlocked other)
		{
			int num = (character_ = other.character_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60056EB")]
		[Cpp2IlInjected.Address(RVA = "0x3214F30", Offset = "0x3213930", VA = "0x183214F30", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionCharacterUnlocked Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionCharacterUnlocked conditionCharacterUnlocked = new ConditionCharacterUnlocked();
			int num = (conditionCharacterUnlocked.character_ = character_);
			bool flag = (conditionCharacterUnlocked.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionCharacterUnlocked._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCharacterUnlocked;
		}

		[Cpp2IlInjected.Token(Token = "0x60056F0")]
		[Cpp2IlInjected.Address(RVA = "0x3215100", Offset = "0x3213B00", VA = "0x183215100", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)character_ == (IntPtr)typeof(ConditionCharacterUnlocked).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionCharacterUnlocked).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCharacterUnlocked other)
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

		[Cpp2IlInjected.Token(Token = "0x60056F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (character_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x60056F3")]
		[Cpp2IlInjected.Address(RVA = "0x3215350", Offset = "0x3213D50", VA = "0x183215350", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60056F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (character_ != 0)
			{
				int value = character_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60056F5")]
		[Cpp2IlInjected.Address(RVA = "0x3214EA0", Offset = "0x32138A0", VA = "0x183214EA0", Slot = "12")]
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
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60056F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCharacterUnlocked other)
		{
			if (other != null)
			{
				int num = other.character_;
				if (num != 0)
				{
					character_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x60056F7")]
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
					int num2 = (character_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056F8")]
		[Cpp2IlInjected.Address(RVA = "0x3215190", Offset = "0x3213B90", VA = "0x183215190", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = character_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056F9")]
		[Cpp2IlInjected.Address(RVA = "0x3215280", Offset = "0x3213C80", VA = "0x183215280", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				character_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60056FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				character_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056FB")]
		[Cpp2IlInjected.Address(RVA = "0x32153B0", Offset = "0x3213DB0", VA = "0x1832153B0")]
		static ConditionCharacterUnlocked()
		{
			Func<ConditionCharacterUnlocked> func = default(Func<ConditionCharacterUnlocked>);
			_parser = (MessageParser<ConditionCharacterUnlocked>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056FC")]
		[Cpp2IlInjected.Address(RVA = "0x3215030", Offset = "0x3213A30", VA = "0x183215030", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = character_;
			bool result = default(bool);
			return result;
		}
	}
}
