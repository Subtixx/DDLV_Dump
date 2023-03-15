using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007DE")]
	public sealed class ConditionCharacterLockedInVillage : ICondition, IDataValidation, IMessage<ConditionCharacterLockedInVillage>, IMessage, IEquatable<ConditionCharacterLockedInVillage>, IDeepCloneable<ConditionCharacterLockedInVillage>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002774")]
		private static readonly MessageParser<ConditionCharacterLockedInVillage> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002775")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002776")]
		public const int CharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002777")]
		private int character_;

		[Cpp2IlInjected.Token(Token = "0x4002778")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002779")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170015FB")]
		private Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x60056C0")]
			[Cpp2IlInjected.Address(RVA = "0x3214AD0", Offset = "0x32134D0", VA = "0x183214AD0")]
			get
			{
				long num = Convert.ToInt64((uint)character_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FC")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60056C2")]
			[Cpp2IlInjected.Address(RVA = "0x3214C00", Offset = "0x3213600", VA = "0x183214C00", Slot = "5")]
			get
			{
				//IL_0020: Expected O, but got I8
				//IL_0038: Expected O, but got I8
				if (inversed_)
				{
					long num = Convert.ToInt64((uint)character_);
					return $"Character {num} is not locked in village";
				}
				long num2 = Convert.ToInt64((uint)character_);
				return $"Character {num2} is locked in village";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FD")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60056C3")]
			[Cpp2IlInjected.Address(RVA = "0x20BE290", Offset = "0x20BCC90", VA = "0x1820BE290", Slot = "6")]
			get
			{
				return ConditionListener.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FE")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCharacterLockedInVillage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60056C6")]
			[Cpp2IlInjected.Address(RVA = "0x3214D30", Offset = "0x3213730", VA = "0x183214D30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60056C7")]
			[Cpp2IlInjected.Address(RVA = "0x3214B30", Offset = "0x3213530", VA = "0x183214B30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001600")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60056C8")]
			[Cpp2IlInjected.Address(RVA = "0x3214D90", Offset = "0x3213790", VA = "0x183214D90", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001601")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x60056CC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return character_;
			}
			[Cpp2IlInjected.Token(Token = "0x60056CD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				character_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001602")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x60056CE")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x60056CF")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056C1")]
		[Cpp2IlInjected.Address(RVA = "0x3214640", Offset = "0x3213040", VA = "0x183214640")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = character_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60056C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056C5")]
		[Cpp2IlInjected.Address(RVA = "0x32145D0", Offset = "0x3212FD0", VA = "0x1832145D0", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (character_ == 0)
			{
				context.AddInvalidMemberError("Please select a character", "Character");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60056C9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionCharacterLockedInVillage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60056CA")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionCharacterLockedInVillage(ConditionCharacterLockedInVillage other)
		{
			int num = (character_ = other.character_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60056CB")]
		[Cpp2IlInjected.Address(RVA = "0x3214540", Offset = "0x3212F40", VA = "0x183214540", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionCharacterLockedInVillage Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionCharacterLockedInVillage conditionCharacterLockedInVillage = new ConditionCharacterLockedInVillage();
			int num = (conditionCharacterLockedInVillage.character_ = character_);
			bool flag = (conditionCharacterLockedInVillage.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionCharacterLockedInVillage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCharacterLockedInVillage;
		}

		[Cpp2IlInjected.Token(Token = "0x60056D0")]
		[Cpp2IlInjected.Address(RVA = "0x3214710", Offset = "0x3213110", VA = "0x183214710", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)character_ == (IntPtr)typeof(ConditionCharacterLockedInVillage).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionCharacterLockedInVillage).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCharacterLockedInVillage other)
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

		[Cpp2IlInjected.Token(Token = "0x60056D2")]
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

		[Cpp2IlInjected.Token(Token = "0x60056D3")]
		[Cpp2IlInjected.Address(RVA = "0x3214960", Offset = "0x3213360", VA = "0x183214960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60056D4")]
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

		[Cpp2IlInjected.Token(Token = "0x60056D5")]
		[Cpp2IlInjected.Address(RVA = "0x32144B0", Offset = "0x3212EB0", VA = "0x1832144B0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60056D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCharacterLockedInVillage other)
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

		[Cpp2IlInjected.Token(Token = "0x60056D7")]
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

		[Cpp2IlInjected.Token(Token = "0x60056D8")]
		[Cpp2IlInjected.Address(RVA = "0x32147A0", Offset = "0x32131A0", VA = "0x1832147A0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x60056D9")]
		[Cpp2IlInjected.Address(RVA = "0x3214890", Offset = "0x3213290", VA = "0x183214890", Slot = "17")]
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

		[Cpp2IlInjected.Token(Token = "0x60056DA")]
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

		[Cpp2IlInjected.Token(Token = "0x60056DB")]
		[Cpp2IlInjected.Address(RVA = "0x32149C0", Offset = "0x32133C0", VA = "0x1832149C0")]
		static ConditionCharacterLockedInVillage()
		{
			Func<ConditionCharacterLockedInVillage> func = default(Func<ConditionCharacterLockedInVillage>);
			_parser = (MessageParser<ConditionCharacterLockedInVillage>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60056DC")]
		[Cpp2IlInjected.Address(RVA = "0x3214640", Offset = "0x3213040", VA = "0x183214640", Slot = "4")]
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
