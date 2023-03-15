using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008BB")]
	public sealed class UpgradeState : IMessage<UpgradeState>, IMessage, IEquatable<UpgradeState>, IDeepCloneable<UpgradeState>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002AD2")]
		private static readonly MessageParser<UpgradeState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002AD3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002AD4")]
		public const int LevelFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AD5")]
		private int level_;

		[Cpp2IlInjected.Token(Token = "0x17001875")]
		[DebuggerNonUserCode]
		public static MessageParser<UpgradeState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600619B")]
			[Cpp2IlInjected.Address(RVA = "0x17BFD50", Offset = "0x17BE750", VA = "0x1817BFD50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001876")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600619C")]
			[Cpp2IlInjected.Address(RVA = "0x17BFC80", Offset = "0x17BE680", VA = "0x1817BFC80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001877")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600619D")]
			[Cpp2IlInjected.Address(RVA = "0x17BFDB0", Offset = "0x17BE7B0", VA = "0x1817BFDB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001878")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x60061A1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return level_;
			}
			[Cpp2IlInjected.Token(Token = "0x60061A2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				level_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600619E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UpgradeState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600619F")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public UpgradeState(UpgradeState other)
		{
			int num = (level_ = other.level_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60061A0")]
		[Cpp2IlInjected.Address(RVA = "0x17BF8D0", Offset = "0x17BE2D0", VA = "0x1817BF8D0", Slot = "10")]
		[DebuggerNonUserCode]
		public UpgradeState Clone()
		{
			//Discarded unreachable code: IL_0029
			UpgradeState upgradeState = new UpgradeState();
			int num = (upgradeState.level_ = level_);
			UnknownFieldSet unknownFieldSet = (upgradeState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return upgradeState;
		}

		[Cpp2IlInjected.Token(Token = "0x60061A3")]
		[Cpp2IlInjected.Address(RVA = "0x17BF950", Offset = "0x17BE350", VA = "0x1817BF950", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)level_ == (IntPtr)typeof(UpgradeState).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60061A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpgradeState other)
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

		[Cpp2IlInjected.Token(Token = "0x60061A5")]
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

		[Cpp2IlInjected.Token(Token = "0x60061A6")]
		[Cpp2IlInjected.Address(RVA = "0x17BFB10", Offset = "0x17BE510", VA = "0x1817BFB10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60061A7")]
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

		[Cpp2IlInjected.Token(Token = "0x60061A8")]
		[Cpp2IlInjected.Address(RVA = "0x17BF830", Offset = "0x17BE230", VA = "0x1817BF830", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60061A9")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpgradeState other)
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

		[Cpp2IlInjected.Token(Token = "0x60061AA")]
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

		[Cpp2IlInjected.Token(Token = "0x60061AB")]
		[Cpp2IlInjected.Address(RVA = "0x17BF9E0", Offset = "0x17BE3E0", VA = "0x1817BF9E0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60061AC")]
		[Cpp2IlInjected.Address(RVA = "0x17BFA90", Offset = "0x17BE490", VA = "0x1817BFA90", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60061AD")]
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

		[Cpp2IlInjected.Token(Token = "0x60061AE")]
		[Cpp2IlInjected.Address(RVA = "0x17BFB70", Offset = "0x17BE570", VA = "0x1817BFB70")]
		static UpgradeState()
		{
			Func<UpgradeState> func = default(Func<UpgradeState>);
			_parser = (MessageParser<UpgradeState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
