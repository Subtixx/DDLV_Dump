using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200022A")]
	public sealed class CharacterUnlockReward : IMessage<CharacterUnlockReward>, IMessage, IEquatable<CharacterUnlockReward>, IDeepCloneable<CharacterUnlockReward>, IMessageFieldAccessor, IReward
	{
		[Cpp2IlInjected.Token(Token = "0x40008D7")]
		private static readonly MessageParser<CharacterUnlockReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008D8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40008D9")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008DA")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x1700049F")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterUnlockReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60014D0")]
			[Cpp2IlInjected.Address(RVA = "0x28A48B0", Offset = "0x28A32B0", VA = "0x1828A48B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60014D1")]
			[Cpp2IlInjected.Address(RVA = "0x28A47E0", Offset = "0x28A31E0", VA = "0x1828A47E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60014D2")]
			[Cpp2IlInjected.Address(RVA = "0x28A4910", Offset = "0x28A3310", VA = "0x1828A4910", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A2")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60014D6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x60014D7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A3")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60014E3")]
			[Cpp2IlInjected.Address(RVA = "0x28A4770", Offset = "0x28A3170", VA = "0x1828A4770", Slot = "14")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = id_;
				return $"unlock {num}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014D3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CharacterUnlockReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60014D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public CharacterUnlockReward(CharacterUnlockReward other)
		{
			int num = (id_ = other.id_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014D5")]
		[Cpp2IlInjected.Address(RVA = "0x28A43C0", Offset = "0x28A2DC0", VA = "0x1828A43C0", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterUnlockReward Clone()
		{
			//Discarded unreachable code: IL_0023
			CharacterUnlockReward characterUnlockReward = default(CharacterUnlockReward);
			int num = (characterUnlockReward.id_ = id_);
			UnknownFieldSet unknownFieldSet = (characterUnlockReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return characterUnlockReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60014D8")]
		[Cpp2IlInjected.Address(RVA = "0x28A4440", Offset = "0x28A2E40", VA = "0x1828A4440", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(CharacterUnlockReward).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014D9")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterUnlockReward other)
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

		[Cpp2IlInjected.Token(Token = "0x60014DA")]
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

		[Cpp2IlInjected.Token(Token = "0x60014DB")]
		[Cpp2IlInjected.Address(RVA = "0x28A4600", Offset = "0x28A3000", VA = "0x1828A4600", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60014DC")]
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

		[Cpp2IlInjected.Token(Token = "0x60014DD")]
		[Cpp2IlInjected.Address(RVA = "0x28A4320", Offset = "0x28A2D20", VA = "0x1828A4320", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60014DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterUnlockReward other)
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

		[Cpp2IlInjected.Token(Token = "0x60014DF")]
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

		[Cpp2IlInjected.Token(Token = "0x60014E0")]
		[Cpp2IlInjected.Address(RVA = "0x28A44D0", Offset = "0x28A2ED0", VA = "0x1828A44D0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60014E1")]
		[Cpp2IlInjected.Address(RVA = "0x28A4580", Offset = "0x28A2F80", VA = "0x1828A4580", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60014E2")]
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

		[Cpp2IlInjected.Token(Token = "0x60014E4")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "15")]
		public bool CanGive(IRewardRecipient recipient)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60014E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60014E6")]
		[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "17")]
		public int GetGivenItems(MultiItemInstance rewards)
		{
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60014E7")]
		[Cpp2IlInjected.Address(RVA = "0x28A4660", Offset = "0x28A3060", VA = "0x1828A4660")]
		static CharacterUnlockReward()
		{
			Func<CharacterUnlockReward> func = default(Func<CharacterUnlockReward>);
			_parser = (MessageParser<CharacterUnlockReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		void IReward.Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, Item? characterItem, bool canSendToInbox)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
