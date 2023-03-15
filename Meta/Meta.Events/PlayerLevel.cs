using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000E22")]
	public sealed class PlayerLevel : IMessage<PlayerLevel>, IMessage, IEquatable<PlayerLevel>, IDeepCloneable<PlayerLevel>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4003936")]
		private static readonly MessageParser<PlayerLevel> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003937")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003938")]
		public const int LevelFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003939")]
		private int level_;

		[Cpp2IlInjected.Token(Token = "0x170014B4")]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerLevel> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60076FD")]
			[Cpp2IlInjected.Address(RVA = "0x7BC610", Offset = "0x7BB010", VA = "0x1807BC610")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60076FE")]
			[Cpp2IlInjected.Address(RVA = "0x7BC540", Offset = "0x7BAF40", VA = "0x1807BC540")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60076FF")]
			[Cpp2IlInjected.Address(RVA = "0x7BC670", Offset = "0x7BB070", VA = "0x1807BC670", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B7")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6007703")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return level_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007704")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				level_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007700")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PlayerLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007701")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public PlayerLevel(PlayerLevel other)
		{
			int num = (level_ = other.level_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007702")]
		[Cpp2IlInjected.Address(RVA = "0x7BC190", Offset = "0x7BAB90", VA = "0x1807BC190", Slot = "10")]
		[DebuggerNonUserCode]
		public PlayerLevel Clone()
		{
			//Discarded unreachable code: IL_0029
			PlayerLevel playerLevel = new PlayerLevel();
			int num = (playerLevel.level_ = level_);
			UnknownFieldSet unknownFieldSet = (playerLevel._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return playerLevel;
		}

		[Cpp2IlInjected.Token(Token = "0x6007705")]
		[Cpp2IlInjected.Address(RVA = "0x7BC210", Offset = "0x7BAC10", VA = "0x1807BC210", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)level_ == (IntPtr)typeof(PlayerLevel).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007706")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PlayerLevel other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.level_;
				if (level_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007707")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (level_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6007708")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3D0", Offset = "0x7BADD0", VA = "0x1807BC3D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007709")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (level_ != 0)
			{
				int value = level_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600770A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0F0", Offset = "0x7BAAF0", VA = "0x1807BC0F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = level_;
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

		[Cpp2IlInjected.Token(Token = "0x600770B")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerLevel other)
		{
			if (other != null)
			{
				int num = other.level_;
				if (num != 0)
				{
					level_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600770C")]
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
					int num2 = (level_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600770D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2A0", Offset = "0x7BACA0", VA = "0x1807BC2A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = level_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600770E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC350", Offset = "0x7BAD50", VA = "0x1807BC350", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				level_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600770F")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				level_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007710")]
		[Cpp2IlInjected.Address(RVA = "0x7BC430", Offset = "0x7BAE30", VA = "0x1807BC430")]
		static PlayerLevel()
		{
			Func<PlayerLevel> func = default(Func<PlayerLevel>);
			_parser = (MessageParser<PlayerLevel>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
