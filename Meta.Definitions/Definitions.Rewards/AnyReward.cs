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
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	public sealed class AnyReward : IReward, IMessage<AnyReward>, IMessage, IEquatable<AnyReward>, IDeepCloneable<AnyReward>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200022F")]
		public enum RewardOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40008EB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40008EC")]
			Any,
			[Cpp2IlInjected.Token(Token = "0x40008ED")]
			Multi,
			[Cpp2IlInjected.Token(Token = "0x40008EE")]
			Item,
			[Cpp2IlInjected.Token(Token = "0x40008EF")]
			Friendship,
			[Cpp2IlInjected.Token(Token = "0x40008F0")]
			CharacterUnlock,
			[Cpp2IlInjected.Token(Token = "0x40008F1")]
			Null
		}

		[Cpp2IlInjected.Token(Token = "0x40008E0")]
		private static readonly MessageParser<AnyReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008E1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40008E2")]
		public const int AnyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40008E3")]
		public const int MultiFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40008E4")]
		public const int ItemFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40008E5")]
		public const int FriendshipFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40008E6")]
		public const int CharacterUnlockFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40008E7")]
		public const int NullFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008E8")]
		private object reward_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008E9")]
		private RewardOneofCase rewardCase_;

		[Cpp2IlInjected.Token(Token = "0x170004A9")]
		[DebuggerNonUserCode]
		public static MessageParser<AnyReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001507")]
			[Cpp2IlInjected.Address(RVA = "0x26EE2A0", Offset = "0x26ECCA0", VA = "0x1826EE2A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001508")]
			[Cpp2IlInjected.Address(RVA = "0x26EE050", Offset = "0x26ECA50", VA = "0x1826EE050")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001509")]
			[Cpp2IlInjected.Address(RVA = "0x26EE310", Offset = "0x26ECD10", VA = "0x1826EE310", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AC")]
		[DebuggerNonUserCode]
		public AnyReward Any
		{
			[Cpp2IlInjected.Token(Token = "0x600150D")]
			[Cpp2IlInjected.Address(RVA = "0x26EDE30", Offset = "0x26EC830", VA = "0x1826EDE30")]
			get
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.Any)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600150E")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				reward_ = value;
				bool flag = (byte)(rewardCase_ = ((value != null) ? RewardOneofCase.Any : RewardOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AD")]
		[DebuggerNonUserCode]
		public MultiReward Multi
		{
			[Cpp2IlInjected.Token(Token = "0x600150F")]
			[Cpp2IlInjected.Address(RVA = "0x26EE1E0", Offset = "0x26ECBE0", VA = "0x1826EE1E0")]
			get
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.Multi)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001510")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				reward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AE")]
		[DebuggerNonUserCode]
		public ItemReward Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001511")]
			[Cpp2IlInjected.Address(RVA = "0x26EE180", Offset = "0x26ECB80", VA = "0x1826EE180")]
			get
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.Item)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001512")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				reward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AF")]
		[DebuggerNonUserCode]
		public FriendshipReward Friendship
		{
			[Cpp2IlInjected.Token(Token = "0x6001513")]
			[Cpp2IlInjected.Address(RVA = "0x26EE120", Offset = "0x26ECB20", VA = "0x1826EE120")]
			get
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.Friendship)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001514")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				reward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B0")]
		[DebuggerNonUserCode]
		public CharacterUnlockReward CharacterUnlock
		{
			[Cpp2IlInjected.Token(Token = "0x6001515")]
			[Cpp2IlInjected.Address(RVA = "0x26EDE90", Offset = "0x26EC890", VA = "0x1826EDE90")]
			get
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.CharacterUnlock)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001516")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				reward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B1")]
		[DebuggerNonUserCode]
		public NullReward Null
		{
			[Cpp2IlInjected.Token(Token = "0x6001517")]
			[Cpp2IlInjected.Address(RVA = "0x26EE240", Offset = "0x26ECC40", VA = "0x1826EE240")]
			get
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.Null)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001518")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				reward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B2")]
		[DebuggerNonUserCode]
		public RewardOneofCase RewardCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001519")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return rewardCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B3")]
		[DebuggerNonUserCode]
		public IReward Reward
		{
			[Cpp2IlInjected.Token(Token = "0x600151B")]
			[Cpp2IlInjected.Address(RVA = "0x26EE300", Offset = "0x26ECD00", VA = "0x1826EE300")]
			get
			{
				return GetReward();
			}
			[Cpp2IlInjected.Token(Token = "0x600151C")]
			[Cpp2IlInjected.Address(RVA = "0x26ED5D0", Offset = "0x26EBFD0", VA = "0x1826ED5D0")]
			set
			{
				//IL_0031: Expected I4, but got I8
				//IL_0042: Expected I4, but got I8
				//IL_0053: Expected I4, but got I8
				//IL_0064: Expected I4, but got I8
				//IL_0075: Expected I4, but got I8
				//IL_0086: Expected I4, but got I8
				//IL_0095: Expected O, but got I4
				int num = 0;
				if (value != null)
				{
					if (value != null)
					{
						reward_ = value;
						rewardCase_ = RewardOneofCase.Any;
						return;
					}
					if (value != null)
					{
						reward_ = value;
						rewardCase_ = RewardOneofCase.Multi;
						return;
					}
					if (value != null)
					{
						reward_ = value;
						rewardCase_ = RewardOneofCase.Item;
						return;
					}
					if (value != null)
					{
						reward_ = value;
						rewardCase_ = RewardOneofCase.Friendship;
						return;
					}
					if (value != null)
					{
						reward_ = value;
						rewardCase_ = RewardOneofCase.CharacterUnlock;
						return;
					}
					if (value != null)
					{
						reward_ = value;
						rewardCase_ = RewardOneofCase.Null;
						return;
					}
				}
				rewardCase_ = (RewardOneofCase)num;
				reward_ = num;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B4")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x600152C")]
			[Cpp2IlInjected.Address(RVA = "0x26EDEF0", Offset = "0x26EC8F0", VA = "0x1826EDEF0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_001c, IL_0023
				IReward reward = GetReward();
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				return reward.DebugDisplay;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B5")]
		public IReward DefaultReward
		{
			[Cpp2IlInjected.Token(Token = "0x6001530")]
			[Cpp2IlInjected.Address(RVA = "0x26EDFB0", Offset = "0x26EC9B0", VA = "0x1826EDFB0")]
			get
			{
				NullReward _003CDefault_003Ek__BackingField = NullReward.Default;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600150A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AnyReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600150B")]
		[Cpp2IlInjected.Address(RVA = "0x26EDC00", Offset = "0x26EC600", VA = "0x1826EDC00")]
		[DebuggerNonUserCode]
		public AnyReward(AnyReward other)
		{
			//IL_00a1: Expected I4, but got O
			if (other.rewardCase_ <= RewardOneofCase.CharacterUnlock)
			{
				bool flag = (byte)(rewardCase_ = (((reward_ = new AnyReward(other.Any)) != null) ? RewardOneofCase.Any : RewardOneofCase.None)) != 0;
				MultiReward multiReward = (MultiReward)(reward_ = other.Multi.Clone());
				ItemReward itemReward = (ItemReward)(reward_ = other.Item.Clone());
				FriendshipReward friendshipReward = (FriendshipReward)(reward_ = other.Friendship.Clone());
				CharacterUnlockReward characterUnlockReward = (CharacterUnlockReward)(reward_ = other.CharacterUnlock.Clone());
				rewardCase_ = (RewardOneofCase)(reward_ = other.Null.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600150C")]
		[Cpp2IlInjected.Address(RVA = "0x26EBE40", Offset = "0x26EA840", VA = "0x1826EBE40", Slot = "14")]
		[DebuggerNonUserCode]
		public AnyReward Clone()
		{
			return new AnyReward(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600151A")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearReward()
		{
			//IL_0010: Expected O, but got I4
			reward_ = (rewardCase_ = RewardOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600151D")]
		[Cpp2IlInjected.Address(RVA = "0x26EC950", Offset = "0x26EB350", VA = "0x1826EC950")]
		[DebuggerNonUserCode]
		public IReward GetReward()
		{
			if (rewardCase_ <= RewardOneofCase.CharacterUnlock)
			{
				AnyReward any = Any;
				MultiReward multi = Multi;
				ItemReward item = Item;
				FriendshipReward friendship = Friendship;
				CharacterUnlockReward characterUnlock = CharacterUnlock;
				NullReward @null = Null;
			}
			NullReward _003CDefault_003Ek__BackingField = NullReward.Default;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600151E")]
		[Cpp2IlInjected.Address(RVA = "0x26ED5D0", Offset = "0x26EBFD0", VA = "0x1826ED5D0")]
		[DebuggerNonUserCode]
		public void SetReward(IReward value)
		{
			//IL_0031: Expected I4, but got I8
			//IL_0042: Expected I4, but got I8
			//IL_0053: Expected I4, but got I8
			//IL_0064: Expected I4, but got I8
			//IL_0075: Expected I4, but got I8
			//IL_0086: Expected I4, but got I8
			//IL_0095: Expected O, but got I4
			int num = 0;
			if (value != null)
			{
				if (value != null)
				{
					reward_ = value;
					rewardCase_ = RewardOneofCase.Any;
					return;
				}
				if (value != null)
				{
					reward_ = value;
					rewardCase_ = RewardOneofCase.Multi;
					return;
				}
				if (value != null)
				{
					reward_ = value;
					rewardCase_ = RewardOneofCase.Item;
					return;
				}
				if (value != null)
				{
					reward_ = value;
					rewardCase_ = RewardOneofCase.Friendship;
					return;
				}
				if (value != null)
				{
					reward_ = value;
					rewardCase_ = RewardOneofCase.CharacterUnlock;
					return;
				}
				if (value != null)
				{
					reward_ = value;
					rewardCase_ = RewardOneofCase.Null;
					return;
				}
			}
			rewardCase_ = (RewardOneofCase)num;
			reward_ = num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600151F")]
		[Cpp2IlInjected.Address(RVA = "0x26EBFB0", Offset = "0x26EA9B0", VA = "0x1826EBFB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((AnyReward)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001520")]
		[Cpp2IlInjected.Address(RVA = "0x26EC010", Offset = "0x26EAA10", VA = "0x1826EC010", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(AnyReward other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.Any)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
						goto IL_0115;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.rewardCase_ == RewardOneofCase.Any)
				{
					obj2 = other.reward_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					MultiReward multi = Multi;
					MultiReward multi2 = other.Multi;
					if (object.Equals(multi, multi2))
					{
						ItemReward item = Item;
						ItemReward item2 = other.Item;
						if (object.Equals(item, item2))
						{
							FriendshipReward friendship = Friendship;
							FriendshipReward friendship2 = other.Friendship;
							if (object.Equals(friendship, friendship2))
							{
								CharacterUnlockReward characterUnlock = CharacterUnlock;
								CharacterUnlockReward characterUnlock2 = other.CharacterUnlock;
								if (object.Equals(characterUnlock, characterUnlock2))
								{
									NullReward @null = Null;
									NullReward null2 = other.Null;
									if (object.Equals(@null, null2))
									{
										RewardOneofCase rewardOneofCase = other.rewardCase_;
										if (rewardCase_ == rewardOneofCase)
										{
											UnknownFieldSet unknownFields = other._unknownFields;
											bool flag = object.Equals(_unknownFields, unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0115;
			IL_0115:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001521")]
		[Cpp2IlInjected.Address(RVA = "0x26EC5B0", Offset = "0x26EAFB0", VA = "0x1826EC5B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00dc
			while (true)
			{
				RewardOneofCase rewardOneofCase = rewardCase_;
				int num = 0;
				if (rewardOneofCase == RewardOneofCase.Any)
				{
					object obj = reward_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (rewardOneofCase != RewardOneofCase.Multi)
				{
					continue;
				}
				object obj2 = reward_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (rewardCase_ != RewardOneofCase.Item)
					{
						continue;
					}
					object obj3 = reward_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (rewardCase_ != RewardOneofCase.Friendship)
						{
							continue;
						}
						object obj4 = reward_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (rewardCase_ != RewardOneofCase.CharacterUnlock)
							{
								continue;
							}
							object obj5 = reward_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (rewardCase_ == RewardOneofCase.Null)
								{
									object obj6 = reward_;
									if (obj6 == null)
									{
										break;
									}
									int hashCode6 = obj6.GetHashCode();
								}
								UnknownFieldSet unknownFields = _unknownFields;
								if (unknownFields != null)
								{
									int hashCode7 = unknownFields.GetHashCode();
								}
								return 1;
							}
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001522")]
		[Cpp2IlInjected.Address(RVA = "0x26ED790", Offset = "0x26EC190", VA = "0x1826ED790", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001523")]
		[Cpp2IlInjected.Address(RVA = "0x26ED7F0", Offset = "0x26EC1F0", VA = "0x1826ED7F0", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0100
			//IL_002f: Expected O, but got I4
			while (true)
			{
				RewardOneofCase rewardOneofCase = rewardCase_;
				int num = 0;
				if (rewardOneofCase == RewardOneofCase.Any)
				{
					if (rewardCase_ == RewardOneofCase.Any)
					{
						object obj = reward_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (rewardOneofCase != RewardOneofCase.Multi)
				{
					continue;
				}
				if (rewardCase_ == RewardOneofCase.Multi)
				{
					object obj2 = reward_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (rewardCase_ != RewardOneofCase.Item)
				{
					continue;
				}
				if (rewardCase_ == RewardOneofCase.Item)
				{
					object obj3 = reward_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (rewardCase_ != RewardOneofCase.Friendship)
				{
					continue;
				}
				if (rewardCase_ == RewardOneofCase.Friendship)
				{
					object obj4 = reward_;
					if (obj4 != null && obj4 == null)
					{
						break;
					}
				}
				if (rewardCase_ != RewardOneofCase.CharacterUnlock)
				{
					continue;
				}
				if (rewardCase_ == RewardOneofCase.CharacterUnlock)
				{
					object obj5 = reward_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (rewardCase_ == RewardOneofCase.Null && rewardCase_ == RewardOneofCase.Null)
				{
					object obj6 = reward_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001524")]
		[Cpp2IlInjected.Address(RVA = "0x26EB950", Offset = "0x26EA350", VA = "0x1826EB950", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (rewardCase_ == RewardOneofCase.Any)
			{
				if (rewardCase_ == RewardOneofCase.Any)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (rewardCase_ == RewardOneofCase.Multi)
			{
				if (rewardCase_ != RewardOneofCase.Multi)
				{
				}
				object obj2 = reward_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (rewardCase_ == RewardOneofCase.Item)
			{
				if (rewardCase_ != RewardOneofCase.Item)
				{
				}
				object obj3 = reward_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (rewardCase_ == RewardOneofCase.Friendship)
			{
				if (rewardCase_ != RewardOneofCase.Friendship)
				{
				}
				object obj4 = reward_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (rewardCase_ == RewardOneofCase.CharacterUnlock)
			{
				if (rewardCase_ != RewardOneofCase.CharacterUnlock)
				{
				}
				object obj5 = reward_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (rewardCase_ == RewardOneofCase.Null)
			{
				if (rewardCase_ == RewardOneofCase.Null)
				{
					object obj6 = reward_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001525")]
		[Cpp2IlInjected.Address(RVA = "0x26ECFA0", Offset = "0x26EB9A0", VA = "0x1826ECFA0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(AnyReward other)
		{
			//Discarded unreachable code: IL_0067, IL_0070, IL_0087, IL_009d, IL_00b4, IL_00ca, IL_00e1, IL_00f7, IL_010e, IL_0124, IL_013b
			//IL_0087: Expected I4, but got O
			//IL_00b4: Expected I4, but got O
			//IL_00e1: Expected I4, but got O
			//IL_010e: Expected I4, but got O
			//IL_013b: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.rewardCase_ <= RewardOneofCase.CharacterUnlock)
			{
				if (Any == null)
				{
					bool flag = (byte)(rewardCase_ = (((reward_ = new AnyReward()) != null) ? RewardOneofCase.Any : RewardOneofCase.None)) != 0;
				}
				AnyReward any = Any;
				AnyReward any2 = other.Any;
				any.MergeFrom(any2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001526")]
		[Cpp2IlInjected.Address(RVA = "0x26ECA70", Offset = "0x26EB470", VA = "0x1826ECA70", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00a9: Expected I4, but got O
			//IL_0100: Expected I4, but got O
			//IL_01a4: Expected I4, but got O
			//IL_01f5: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					FriendshipReward friendshipReward = new FriendshipReward();
					if (rewardCase_ == RewardOneofCase.Friendship)
					{
						if (rewardCase_ != RewardOneofCase.Friendship)
						{
						}
						object obj = reward_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(friendshipReward);
					reward_ = friendshipReward;
					rewardCase_ = (RewardOneofCase)friendshipReward;
				}
				if (num == 42)
				{
					CharacterUnlockReward builder = new CharacterUnlockReward();
					if (rewardCase_ == RewardOneofCase.CharacterUnlock)
					{
						if (rewardCase_ != RewardOneofCase.CharacterUnlock)
						{
						}
						object obj2 = reward_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					reward_ = builder;
					rewardCase_ = (RewardOneofCase)typeof(CharacterUnlockReward).TypeHandle;
				}
				if ((long)typeof(CharacterUnlockReward).TypeHandle != 50)
				{
					goto IL_01f5;
				}
				NullReward builder2 = new NullReward();
				if (rewardCase_ == RewardOneofCase.Null)
				{
					if (rewardCase_ != RewardOneofCase.Null)
					{
					}
					object obj3 = reward_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				reward_ = builder2;
				rewardCase_ = (RewardOneofCase)typeof(NullReward).TypeHandle;
			}
			bool flag = default(bool);
			if (num == 10)
			{
				AnyReward anyReward = new AnyReward();
				if (rewardCase_ == RewardOneofCase.Any)
				{
					if (rewardCase_ != RewardOneofCase.Any)
					{
					}
					object obj4 = reward_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(anyReward);
				reward_ = anyReward;
				flag = (byte)(rewardCase_ = ((anyReward != null) ? RewardOneofCase.Any : RewardOneofCase.None)) != 0;
			}
			if (flag)
			{
				MultiReward builder3 = new MultiReward();
				if (rewardCase_ == RewardOneofCase.Multi)
				{
					if (rewardCase_ != RewardOneofCase.Multi)
					{
					}
					object obj5 = reward_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				reward_ = builder3;
				rewardCase_ = (RewardOneofCase)typeof(MultiReward).TypeHandle;
			}
			if ((long)typeof(MultiReward).TypeHandle == 26)
			{
				ItemReward builder4 = new ItemReward();
				if (rewardCase_ == RewardOneofCase.Item)
				{
					if (rewardCase_ != RewardOneofCase.Item)
					{
					}
					object obj6 = reward_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				reward_ = builder4;
				rewardCase_ = (RewardOneofCase)typeof(ItemReward).TypeHandle;
			}
			goto IL_01f5;
			IL_01f5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001527")]
		[Cpp2IlInjected.Address(RVA = "0x26EC400", Offset = "0x26EAE00", VA = "0x1826EC400", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 5)
			{
				AnyReward any = Any;
				MultiReward multi = Multi;
				ItemReward item = Item;
				FriendshipReward friendship = Friendship;
				CharacterUnlockReward characterUnlock = CharacterUnlock;
				NullReward @null = Null;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001528")]
		[Cpp2IlInjected.Address(RVA = "0x26ED340", Offset = "0x26EBD40", VA = "0x1826ED340", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0027, IL_002b, IL_002f, IL_0030, IL_0034, IL_0038, IL_0039, IL_003d, IL_0041, IL_0042, IL_0046, IL_004a, IL_004b, IL_004f, IL_0053, IL_0054, IL_0060, IL_0066, IL_006c, IL_0072
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				reward_ = num;
				bool flag = (byte)(rewardCase_ = ((num != 0) ? RewardOneofCase.Any : RewardOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001529")]
		[Cpp2IlInjected.Address(RVA = "0x26EBD60", Offset = "0x26EA760", VA = "0x1826EBD60", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber <= 5)
			{
				int num = 0;
				reward_ = num;
				rewardCase_ = (RewardOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600152A")]
		[Cpp2IlInjected.Address(RVA = "0x26EC8A0", Offset = "0x26EB2A0", VA = "0x1826EC8A0", Slot = "18")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "reward"))
			{
				RewardOneofCase rewardOneofCase = rewardCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600152B")]
		[Cpp2IlInjected.Address(RVA = "0x26EBDD0", Offset = "0x26EA7D0", VA = "0x1826EBDD0", Slot = "19")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "reward"))
			{
				reward_ = (rewardCase_ = RewardOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600152D")]
		[Cpp2IlInjected.Address(RVA = "0x26EBCA0", Offset = "0x26EA6A0", VA = "0x1826EBCA0", Slot = "5")]
		public bool CanGive(IRewardRecipient recipient)
		{
			IReward reward = GetReward();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string debugDisplay = reward.DebugDisplay;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600152E")]
		[Cpp2IlInjected.Address(RVA = "0x26EBEA0", Offset = "0x26EA8A0", VA = "0x1826EBEA0")]
		public void Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false)
		{
			//Discarded unreachable code: IL_001d
			IReward reward = GetReward();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string debugDisplay = reward.DebugDisplay;
		}

		[Cpp2IlInjected.Token(Token = "0x600152F")]
		[Cpp2IlInjected.Address(RVA = "0x26EC4F0", Offset = "0x26EAEF0", VA = "0x1826EC4F0", Slot = "7")]
		public int GetGivenItems(MultiItemInstance rewards)
		{
			IReward reward = GetReward();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string debugDisplay = reward.DebugDisplay;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001531")]
		[Cpp2IlInjected.Address(RVA = "0x26EC1F0", Offset = "0x26EABF0", VA = "0x1826EC1F0")]
		public static AnyReward From(IReward reward)
		{
			//Discarded unreachable code: IL_00a3
			//IL_0037: Expected I4, but got I8
			//IL_0049: Expected I4, but got I8
			//IL_005b: Expected I4, but got I8
			//IL_006d: Expected I4, but got I8
			//IL_007f: Expected I4, but got I8
			//IL_0091: Expected I4, but got I8
			//IL_00a1: Expected O, but got I4
			AnyReward anyReward = new AnyReward();
			int num = 0;
			if (reward != null)
			{
				if (reward != null)
				{
					anyReward.reward_ = reward;
					anyReward.rewardCase_ = RewardOneofCase.Any;
					return anyReward;
				}
				if (reward != null)
				{
					anyReward.reward_ = reward;
					anyReward.rewardCase_ = RewardOneofCase.Multi;
					return anyReward;
				}
				if (reward != null)
				{
					anyReward.reward_ = reward;
					anyReward.rewardCase_ = RewardOneofCase.Item;
					return anyReward;
				}
				if (reward != null)
				{
					anyReward.reward_ = reward;
					anyReward.rewardCase_ = RewardOneofCase.Friendship;
					return anyReward;
				}
				if (reward != null)
				{
					anyReward.reward_ = reward;
					anyReward.rewardCase_ = RewardOneofCase.CharacterUnlock;
					return anyReward;
				}
				if (reward != null)
				{
					anyReward.reward_ = reward;
					anyReward.rewardCase_ = RewardOneofCase.Null;
					return anyReward;
				}
			}
			anyReward.rewardCase_ = (RewardOneofCase)num;
			anyReward.reward_ = num;
			return anyReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6001532")]
		[Cpp2IlInjected.Address(RVA = "0x26EDAF0", Offset = "0x26EC4F0", VA = "0x1826EDAF0")]
		static AnyReward()
		{
			Func<AnyReward> func = default(Func<AnyReward>);
			_parser = (MessageParser<AnyReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001533")]
		[Cpp2IlInjected.Address(RVA = "0x26EBEA0", Offset = "0x26EA8A0", VA = "0x1826EBEA0", Slot = "6")]
		void IReward.Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, Item? characterItem, bool canSendToInbox)
		{
			//Discarded unreachable code: IL_001d
			IReward reward = GetReward();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string debugDisplay = reward.DebugDisplay;
		}
	}
}
