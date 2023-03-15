using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004B7")]
	public sealed class PartyCharacter : IMessage<PartyCharacter>, IMessage, IEquatable<PartyCharacter>, IDeepCloneable<PartyCharacter>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001937")]
		private static readonly MessageParser<PartyCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001938")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001939")]
		public const int CharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400193A")]
		private int character_;

		[Cpp2IlInjected.Token(Token = "0x400193B")]
		public const int AnimationFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400193C")]
		private CharacterAnimation animation_;

		[Cpp2IlInjected.Token(Token = "0x400193D")]
		public const int AcceptEmptySlotFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400193E")]
		private bool acceptEmptySlot_;

		[Cpp2IlInjected.Token(Token = "0x17000ED4")]
		[DebuggerNonUserCode]
		public static MessageParser<PartyCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003A1A")]
			[Cpp2IlInjected.Address(RVA = "0x36A9620", Offset = "0x36A8020", VA = "0x1836A9620")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A1B")]
			[Cpp2IlInjected.Address(RVA = "0x36A9550", Offset = "0x36A7F50", VA = "0x1836A9550")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A1C")]
			[Cpp2IlInjected.Address(RVA = "0x36A9680", Offset = "0x36A8080", VA = "0x1836A9680", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED7")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x6003A20")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return character_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A21")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				character_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED8")]
		[DebuggerNonUserCode]
		public CharacterAnimation Animation
		{
			[Cpp2IlInjected.Token(Token = "0x6003A22")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return animation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A23")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				animation_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED9")]
		[DebuggerNonUserCode]
		public bool AcceptEmptySlot
		{
			[Cpp2IlInjected.Token(Token = "0x6003A24")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return acceptEmptySlot_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A25")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				acceptEmptySlot_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PartyCharacter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1E")]
		[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
		[DebuggerNonUserCode]
		public PartyCharacter(PartyCharacter other)
		{
			int num = (character_ = other.character_);
			CharacterAnimation characterAnimation = (animation_ = other.animation_);
			bool flag = (acceptEmptySlot_ = other.acceptEmptySlot_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1F")]
		[Cpp2IlInjected.Address(RVA = "0x36A9080", Offset = "0x36A7A80", VA = "0x1836A9080", Slot = "10")]
		[DebuggerNonUserCode]
		public PartyCharacter Clone()
		{
			//Discarded unreachable code: IL_0047
			PartyCharacter partyCharacter = new PartyCharacter();
			int num = (partyCharacter.character_ = character_);
			CharacterAnimation characterAnimation = (partyCharacter.animation_ = animation_);
			bool flag = (partyCharacter.acceptEmptySlot_ = acceptEmptySlot_);
			UnknownFieldSet unknownFieldSet = (partyCharacter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return partyCharacter;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A26")]
		[Cpp2IlInjected.Address(RVA = "0x36A9110", Offset = "0x36A7B10", VA = "0x1836A9110", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)character_ == (IntPtr)typeof(PartyCharacter).TypeHandle && (IntPtr)(void*)(int)animation_ == (IntPtr)typeof(PartyCharacter).TypeHandle && (IntPtr)(acceptEmptySlot_ ? 1 : 0) == (IntPtr)typeof(PartyCharacter).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A27")]
		[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PartyCharacter other)
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
					CharacterAnimation characterAnimation = other.animation_;
					if (animation_ == characterAnimation)
					{
						bool flag = other.acceptEmptySlot_;
						if (acceptEmptySlot_ == flag)
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

		[Cpp2IlInjected.Token(Token = "0x6003A28")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EC90", Offset = "0x1E0D690", VA = "0x181E0EC90", Slot = "2")]
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
				if (animation_ != 0)
				{
				}
				if (acceptEmptySlot_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A29")]
		[Cpp2IlInjected.Address(RVA = "0x36A93E0", Offset = "0x36A7DE0", VA = "0x1836A93E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2A")]
		[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			if (character_ != 0)
			{
				int value = character_;
				output.WriteInt32(value);
			}
			if (animation_ != 0)
			{
			}
			if (acceptEmptySlot_)
			{
				bool value2 = acceptEmptySlot_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2B")]
		[Cpp2IlInjected.Address(RVA = "0x36A8FB0", Offset = "0x36A79B0", VA = "0x1836A8FB0", Slot = "7")]
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
				CharacterAnimation characterAnimation = animation_;
				if (characterAnimation != 0)
				{
					int num4 = CodedOutputStream.ComputeEnumSize((int)characterAnimation);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2C")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PartyCharacter other)
		{
			if (other != null)
			{
				int num = other.character_;
				if (num != 0)
				{
					character_ = num;
				}
				CharacterAnimation characterAnimation = other.animation_;
				if (characterAnimation != 0)
				{
					animation_ = characterAnimation;
				}
				bool flag = other.acceptEmptySlot_;
				if (flag)
				{
					acceptEmptySlot_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2D")]
		[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "5")]
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
					num3 = (int)(animation_ = (CharacterAnimation)input.ReadInt32());
				}
				if (num3 == 24)
				{
					bool flag = (acceptEmptySlot_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2E")]
		[Cpp2IlInjected.Address(RVA = "0x36A91B0", Offset = "0x36A7BB0", VA = "0x1836A91B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_001e;
				}
				bool flag = acceptEmptySlot_;
			}
			int num2 = character_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2F")]
		[Cpp2IlInjected.Address(RVA = "0x36A92C0", Offset = "0x36A7CC0", VA = "0x1836A92C0", Slot = "12")]
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
					acceptEmptySlot_ = (byte)(int)obj2 != 0;
					break;
				}
				case 0:
				{
					object obj = default(object);
					animation_ = (CharacterAnimation)obj;
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

		[Cpp2IlInjected.Token(Token = "0x6003A30")]
		[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				acceptEmptySlot_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A31")]
		[Cpp2IlInjected.Address(RVA = "0x36A9440", Offset = "0x36A7E40", VA = "0x1836A9440")]
		static PartyCharacter()
		{
			Func<PartyCharacter> func = default(Func<PartyCharacter>);
			_parser = (MessageParser<PartyCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
