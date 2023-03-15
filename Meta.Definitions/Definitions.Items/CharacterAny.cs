using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000463")]
	public sealed class CharacterAny : IMessage<CharacterAny>, IMessage, IEquatable<CharacterAny>, IDeepCloneable<CharacterAny>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40017BD")]
		private static readonly MessageParser<CharacterAny> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40017BE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40017BF")]
		public const int AmountOfCharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40017C0")]
		private int amountOfCharacter_;

		[Cpp2IlInjected.Token(Token = "0x17000DB9")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterAny> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60035DC")]
			[Cpp2IlInjected.Address(RVA = "0x2897A60", Offset = "0x2896460", VA = "0x182897A60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60035DD")]
			[Cpp2IlInjected.Address(RVA = "0x2897990", Offset = "0x2896390", VA = "0x182897990")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60035DE")]
			[Cpp2IlInjected.Address(RVA = "0x2897AC0", Offset = "0x28964C0", VA = "0x182897AC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBC")]
		[DebuggerNonUserCode]
		public int AmountOfCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60035E2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return amountOfCharacter_;
			}
			[Cpp2IlInjected.Token(Token = "0x60035E3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				amountOfCharacter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035DF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CharacterAny()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60035E0")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public CharacterAny(CharacterAny other)
		{
			int num = (amountOfCharacter_ = other.amountOfCharacter_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035E1")]
		[Cpp2IlInjected.Address(RVA = "0x28975E0", Offset = "0x2895FE0", VA = "0x1828975E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterAny Clone()
		{
			//Discarded unreachable code: IL_0029
			CharacterAny characterAny = new CharacterAny();
			int num = (characterAny.amountOfCharacter_ = amountOfCharacter_);
			UnknownFieldSet unknownFieldSet = (characterAny._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return characterAny;
		}

		[Cpp2IlInjected.Token(Token = "0x60035E4")]
		[Cpp2IlInjected.Address(RVA = "0x2897660", Offset = "0x2896060", VA = "0x182897660", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)amountOfCharacter_ == (IntPtr)typeof(CharacterAny).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60035E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterAny other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.amountOfCharacter_;
				if (amountOfCharacter_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60035E6")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (amountOfCharacter_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60035E7")]
		[Cpp2IlInjected.Address(RVA = "0x2897820", Offset = "0x2896220", VA = "0x182897820", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60035E8")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (amountOfCharacter_ != 0)
			{
				int value = amountOfCharacter_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60035E9")]
		[Cpp2IlInjected.Address(RVA = "0x2897540", Offset = "0x2895F40", VA = "0x182897540", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = amountOfCharacter_;
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

		[Cpp2IlInjected.Token(Token = "0x60035EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterAny other)
		{
			if (other != null)
			{
				int num = other.amountOfCharacter_;
				if (num != 0)
				{
					amountOfCharacter_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035EB")]
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
					int num2 = (amountOfCharacter_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035EC")]
		[Cpp2IlInjected.Address(RVA = "0x28976F0", Offset = "0x28960F0", VA = "0x1828976F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = amountOfCharacter_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60035ED")]
		[Cpp2IlInjected.Address(RVA = "0x28977A0", Offset = "0x28961A0", VA = "0x1828977A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				amountOfCharacter_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035EE")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				amountOfCharacter_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035EF")]
		[Cpp2IlInjected.Address(RVA = "0x2897880", Offset = "0x2896280", VA = "0x182897880")]
		static CharacterAny()
		{
			Func<CharacterAny> func = default(Func<CharacterAny>);
			_parser = (MessageParser<CharacterAny>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
