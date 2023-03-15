using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000431")]
	public sealed class CharacterList : IMessage<CharacterList>, IMessage, IEquatable<CharacterList>, IDeepCloneable<CharacterList>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40016FD")]
		private static readonly MessageParser<CharacterList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40016FE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40016FF")]
		public const int TargetCharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001700")]
		private int targetCharacter_;

		[Cpp2IlInjected.Token(Token = "0x17000D2C")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003368")]
			[Cpp2IlInjected.Address(RVA = "0x289F800", Offset = "0x289E200", VA = "0x18289F800")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D2D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003369")]
			[Cpp2IlInjected.Address(RVA = "0x289F730", Offset = "0x289E130", VA = "0x18289F730")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D2E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600336A")]
			[Cpp2IlInjected.Address(RVA = "0x289F860", Offset = "0x289E260", VA = "0x18289F860", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D2F")]
		[DebuggerNonUserCode]
		public int TargetCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x600336E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return targetCharacter_;
			}
			[Cpp2IlInjected.Token(Token = "0x600336F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				targetCharacter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D30")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x600337B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				int num = targetCharacter_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600336B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CharacterList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600336C")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public CharacterList(CharacterList other)
		{
			int num = (targetCharacter_ = other.targetCharacter_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600336D")]
		[Cpp2IlInjected.Address(RVA = "0x289F290", Offset = "0x289DC90", VA = "0x18289F290", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterList Clone()
		{
			//Discarded unreachable code: IL_0029
			CharacterList characterList = new CharacterList();
			int num = (characterList.targetCharacter_ = targetCharacter_);
			UnknownFieldSet unknownFieldSet = (characterList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return characterList;
		}

		[Cpp2IlInjected.Token(Token = "0x6003370")]
		[Cpp2IlInjected.Address(RVA = "0x289F400", Offset = "0x289DE00", VA = "0x18289F400", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)targetCharacter_ == (IntPtr)typeof(CharacterList).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003371")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.targetCharacter_;
				if (targetCharacter_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003372")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (targetCharacter_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003373")]
		[Cpp2IlInjected.Address(RVA = "0x289F5C0", Offset = "0x289DFC0", VA = "0x18289F5C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003374")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (targetCharacter_ != 0)
			{
				int value = targetCharacter_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003375")]
		[Cpp2IlInjected.Address(RVA = "0x289F1F0", Offset = "0x289DBF0", VA = "0x18289F1F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = targetCharacter_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003376")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterList other)
		{
			if (other != null)
			{
				int num = other.targetCharacter_;
				if (num != 0)
				{
					targetCharacter_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003377")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (targetCharacter_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003378")]
		[Cpp2IlInjected.Address(RVA = "0x289F490", Offset = "0x289DE90", VA = "0x18289F490", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = targetCharacter_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003379")]
		[Cpp2IlInjected.Address(RVA = "0x289F540", Offset = "0x289DF40", VA = "0x18289F540", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				targetCharacter_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600337A")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				targetCharacter_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600337C")]
		[Cpp2IlInjected.Address(RVA = "0x289F310", Offset = "0x289DD10", VA = "0x18289F310", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_002c
			//IL_0023: Expected O, but got I4
			if (targetCharacter_ != 0)
			{
				int num = targetCharacter_;
				string missionStepName = context.MissionStepName;
				string error = $"TargetCharacter is invalid ({num}) in {missionStepName}";
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600337D")]
		[Cpp2IlInjected.Address(RVA = "0x289F620", Offset = "0x289E020", VA = "0x18289F620")]
		static CharacterList()
		{
			Func<CharacterList> func = default(Func<CharacterList>);
			_parser = (MessageParser<CharacterList>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
