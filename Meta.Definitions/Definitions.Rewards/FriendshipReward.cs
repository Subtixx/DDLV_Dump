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
	[Cpp2IlInjected.Token(Token = "0x2000228")]
	[DebuggerDisplay("{DebugDisplay,nq}")]
	public sealed class FriendshipReward : IMessage<FriendshipReward>, IMessage, IEquatable<FriendshipReward>, IDeepCloneable<FriendshipReward>, IMessageFieldAccessor, IReward
	{
		[Cpp2IlInjected.Token(Token = "0x40008CE")]
		private static readonly MessageParser<FriendshipReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008CF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40008D0")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008D1")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x40008D2")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40008D3")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x40008D4")]
		public const int SourceFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008D5")]
		private FriendshipSource source_;

		[Cpp2IlInjected.Token(Token = "0x17000497")]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60014AE")]
			[Cpp2IlInjected.Address(RVA = "0x343AEF0", Offset = "0x34398F0", VA = "0x18343AEF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000498")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60014AF")]
			[Cpp2IlInjected.Address(RVA = "0x343ADC0", Offset = "0x34397C0", VA = "0x18343ADC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000499")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60014B0")]
			[Cpp2IlInjected.Address(RVA = "0x343AF50", Offset = "0x3439950", VA = "0x18343AF50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049A")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60014B4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x60014B5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049B")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x60014B6")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60014B7")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049C")]
		[DebuggerNonUserCode]
		public FriendshipSource Source
		{
			[Cpp2IlInjected.Token(Token = "0x60014B8")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return source_;
			}
			[Cpp2IlInjected.Token(Token = "0x60014B9")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				source_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049D")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60014C5")]
			[Cpp2IlInjected.Address(RVA = "0x343AE90", Offset = "0x3439890", VA = "0x18343AE90")]
			get
			{
				long num = Convert.ToInt64((uint)id_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049E")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60014C6")]
			[Cpp2IlInjected.Address(RVA = "0x343AD30", Offset = "0x3439730", VA = "0x18343AD30", Slot = "14")]
			get
			{
				//IL_001a: Expected O, but got I4
				//IL_001a: Expected O, but got I4
				int num = amount_;
				int num2 = id_;
				return $"friendship {num}x {num}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014B1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FriendshipReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60014B2")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public FriendshipReward(FriendshipReward other)
		{
			int num = (id_ = other.id_);
			int num2 = (amount_ = other.amount_);
			FriendshipSource friendshipSource = (source_ = other.source_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014B3")]
		[Cpp2IlInjected.Address(RVA = "0x343A6B0", Offset = "0x34390B0", VA = "0x18343A6B0", Slot = "10")]
		[DebuggerNonUserCode]
		public FriendshipReward Clone()
		{
			//Discarded unreachable code: IL_0047
			FriendshipReward friendshipReward = new FriendshipReward();
			int num = (friendshipReward.id_ = id_);
			int num2 = (friendshipReward.amount_ = amount_);
			FriendshipSource friendshipSource = (friendshipReward.source_ = source_);
			UnknownFieldSet unknownFieldSet = (friendshipReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return friendshipReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60014BA")]
		[Cpp2IlInjected.Address(RVA = "0x343A8A0", Offset = "0x34392A0", VA = "0x18343A8A0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(FriendshipReward).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(FriendshipReward).TypeHandle && (IntPtr)(void*)(int)source_ == (IntPtr)typeof(FriendshipReward).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014BB")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FriendshipReward other)
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
					int num2 = other.amount_;
					if (amount_ == num2)
					{
						FriendshipSource friendshipSource = other.source_;
						if (source_ == friendshipSource)
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

		[Cpp2IlInjected.Token(Token = "0x60014BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B090", Offset = "0x1E79A90", VA = "0x181E7B090", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (id_ != 0)
				{
				}
				if (amount_ != 0)
				{
				}
				if (source_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60014BD")]
		[Cpp2IlInjected.Address(RVA = "0x343ABC0", Offset = "0x34395C0", VA = "0x18343ABC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60014BE")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			if (id_ != 0)
			{
				int value = id_;
				output.WriteInt32(value);
			}
			if (amount_ != 0)
			{
				int value2 = amount_;
				output.WriteInt32(value2);
			}
			if (source_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60014BF")]
		[Cpp2IlInjected.Address(RVA = "0x343A5B0", Offset = "0x3438FB0", VA = "0x18343A5B0", Slot = "7")]
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
				int num4 = amount_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				FriendshipSource friendshipSource = source_;
				if (friendshipSource != 0)
				{
					int num6 = CodedOutputStream.ComputeEnumSize((int)friendshipSource);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60014C0")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FriendshipReward other)
		{
			if (other != null)
			{
				int num = other.id_;
				if (num != 0)
				{
					id_ = num;
				}
				int num2 = other.amount_;
				if (num2 != 0)
				{
					amount_ = num2;
				}
				FriendshipSource friendshipSource = other.source_;
				if (friendshipSource != 0)
				{
					source_ = friendshipSource;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014C1")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (id_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (amount_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (int)(source_ = (FriendshipSource)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014C2")]
		[Cpp2IlInjected.Address(RVA = "0x343A940", Offset = "0x3439340", VA = "0x18343A940", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = id_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014C3")]
		[Cpp2IlInjected.Address(RVA = "0x343AAA0", Offset = "0x34394A0", VA = "0x18343AAA0", Slot = "12")]
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
					source_ = (FriendshipSource)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					amount_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				id_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014C4")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				source_ = FriendshipSource.Unknown;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014C7")]
		[Cpp2IlInjected.Address(RVA = "0x343AA20", Offset = "0x3439420", VA = "0x18343AA20")]
		public static FriendshipReward New(int id, int amount, FriendshipSource source)
		{
			//Discarded unreachable code: IL_001f
			FriendshipReward friendshipReward = new FriendshipReward();
			friendshipReward.id_ = id;
			friendshipReward.amount_ = amount;
			friendshipReward.source_ = source;
			return friendshipReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60014C8")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "15")]
		public bool CanGive(IRewardRecipient recipient)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60014C9")]
		[Cpp2IlInjected.Address(RVA = "0x343A740", Offset = "0x3439140", VA = "0x18343A740")]
		public void Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false)
		{
			//Discarded unreachable code: IL_001d
			int num = id_;
			FriendshipSource friendshipSource = source_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014CA")]
		[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "17")]
		public int GetGivenItems(MultiItemInstance rewards)
		{
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60014CB")]
		[Cpp2IlInjected.Address(RVA = "0x343AC20", Offset = "0x3439620", VA = "0x18343AC20")]
		static FriendshipReward()
		{
			Func<FriendshipReward> func = default(Func<FriendshipReward>);
			_parser = (MessageParser<FriendshipReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014CC")]
		[Cpp2IlInjected.Address(RVA = "0x343A740", Offset = "0x3439140", VA = "0x18343A740", Slot = "16")]
		void IReward.Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, Item? characterItem, bool canSendToInbox)
		{
			//Discarded unreachable code: IL_001d
			int num = id_;
			FriendshipSource friendshipSource = source_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
		}
	}
}
