using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000E20")]
	public sealed class CharacterUnlock : IMessage<CharacterUnlock>, IMessage, IEquatable<CharacterUnlock>, IDeepCloneable<CharacterUnlock>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4003931")]
		private static readonly MessageParser<CharacterUnlock> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003932")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003933")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003934")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x170014B0")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterUnlock> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60076E6")]
			[Cpp2IlInjected.Address(RVA = "0x71C280", Offset = "0x71AC80", VA = "0x18071C280")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60076E7")]
			[Cpp2IlInjected.Address(RVA = "0x71C1B0", Offset = "0x71ABB0", VA = "0x18071C1B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60076E8")]
			[Cpp2IlInjected.Address(RVA = "0x71C2E0", Offset = "0x71ACE0", VA = "0x18071C2E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B3")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60076EC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x60076ED")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60076E9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CharacterUnlock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60076EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public CharacterUnlock(CharacterUnlock other)
		{
			int num = (id_ = other.id_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60076EB")]
		[Cpp2IlInjected.Address(RVA = "0x71BDA0", Offset = "0x71A7A0", VA = "0x18071BDA0", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterUnlock Clone()
		{
			//Discarded unreachable code: IL_0029
			CharacterUnlock characterUnlock = new CharacterUnlock();
			int num = (characterUnlock.id_ = id_);
			UnknownFieldSet unknownFieldSet = (characterUnlock._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return characterUnlock;
		}

		[Cpp2IlInjected.Token(Token = "0x60076EE")]
		[Cpp2IlInjected.Address(RVA = "0x71BE20", Offset = "0x71A820", VA = "0x18071BE20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(CharacterUnlock).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60076EF")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterUnlock other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.id_;
				if (id_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60076F0")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (id_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60076F1")]
		[Cpp2IlInjected.Address(RVA = "0x71BFE0", Offset = "0x71A9E0", VA = "0x18071BFE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60076F2")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (id_ != 0)
			{
				int value = id_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60076F3")]
		[Cpp2IlInjected.Address(RVA = "0x71BD00", Offset = "0x71A700", VA = "0x18071BD00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = id_;
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

		[Cpp2IlInjected.Token(Token = "0x60076F4")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterUnlock other)
		{
			if (other != null)
			{
				int num = other.id_;
				if (num != 0)
				{
					id_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60076F5")]
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
					int num2 = (id_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60076F6")]
		[Cpp2IlInjected.Address(RVA = "0x71BEB0", Offset = "0x71A8B0", VA = "0x18071BEB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = id_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60076F7")]
		[Cpp2IlInjected.Address(RVA = "0x71BF60", Offset = "0x71A960", VA = "0x18071BF60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				id_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60076F8")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				id_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60076F9")]
		[Cpp2IlInjected.Address(RVA = "0x71C0A0", Offset = "0x71AAA0", VA = "0x18071C0A0")]
		static CharacterUnlock()
		{
			Func<CharacterUnlock> func = default(Func<CharacterUnlock>);
			_parser = (MessageParser<CharacterUnlock>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
