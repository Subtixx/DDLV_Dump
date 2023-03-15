using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x2000851")]
	public sealed class Friendship : IDataValidation, IHasItemDependencies, IMessage<Friendship>, IMessage, IEquatable<Friendship>, IDeepCloneable<Friendship>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002927")]
		private List<Item> itemDependencies;

		[Cpp2IlInjected.Token(Token = "0x4002928")]
		private static readonly MessageParser<Friendship> _parser = (MessageParser<Friendship>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new Friendship()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002929")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400292A")]
		public const int DefaultFriendshipFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400292B")]
		private static readonly FieldCodec<FriendshipLevel> _repeated_defaultFriendship_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400292C")]
		private readonly RepeatedField<FriendshipLevel> defaultFriendship_ = (RepeatedField<FriendshipLevel>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400292D")]
		public const int FriendshipsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400292E")]
		private static readonly FieldCodec<FriendshipData> _repeated_friendships_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400292F")]
		private readonly RepeatedField<FriendshipData> friendships_ = (RepeatedField<FriendshipData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002930")]
		public const int DefaultDiscussionFriendshipFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002931")]
		private int defaultDiscussionFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4002932")]
		public const int DefaultGiftFriendshipFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002933")]
		private int defaultGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4002934")]
		public const int FriendshipBonusFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002935")]
		private FriendshipBonus friendshipBonus_;

		[Cpp2IlInjected.Token(Token = "0x4002936")]
		public const int DailyLimitationFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002937")]
		private int dailyLimitation_;

		[Cpp2IlInjected.Token(Token = "0x17001771")]
		public static Friendship Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6005CF6")]
			[Cpp2IlInjected.Address(RVA = "0x343D7A0", Offset = "0x343C1A0", VA = "0x18343D7A0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return ProtoDatabase.Instance.Get<Friendship>("Friendship");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001772")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6005CF7")]
			[Cpp2IlInjected.Address(RVA = "0x343D740", Offset = "0x343C140", VA = "0x18343D740", Slot = "5")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001773")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6005CF8")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001774")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6005CF9")]
			[Cpp2IlInjected.Address(RVA = "0x343D880", Offset = "0x343C280", VA = "0x18343D880", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_00c5, IL_00cb, IL_00d1, IL_00d7, IL_00dd, IL_00e3
				int num = 0;
				int num2 = 0;
				if ((IntPtr)itemDependencies == (IntPtr)num2)
				{
					List<Item> list = (itemDependencies = (List<Item>)(object)new List<T>());
					RepeatedField<FriendshipData> repeatedField = friendships_;
					bool flag = default(bool);
					bool flag2 = default(bool);
					if (flag && flag2)
					{
						List<Item> list2 = itemDependencies;
						if (_003C_003Ec._003C_003E9__8_0 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemReward x) => x.Item);
						}
						IEnumerable<ItemReward> enumerable = default(IEnumerable<ItemReward>);
						((List<T>)(object)list2).AddRange((IEnumerable<>)enumerable);
						List<Item> list3 = itemDependencies;
						if (_003C_003Ec._003C_003E9__8_1 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemReward x) => x.Item);
						}
						IEnumerable<ItemReward> enumerable2 = default(IEnumerable<ItemReward>);
						((List<T>)(object)list3).AddRange((IEnumerable<>)enumerable2);
						List<Item> list4 = itemDependencies;
						if (_003C_003Ec._003C_003E9__8_2 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemReward x) => x.Item);
						}
						IEnumerable<ItemReward> enumerable3 = default(IEnumerable<ItemReward>);
						((List<T>)(object)list4).AddRange((IEnumerable<>)enumerable3);
					}
				}
				return itemDependencies;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001775")]
		[DebuggerNonUserCode]
		public static MessageParser<Friendship> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005D02")]
			[Cpp2IlInjected.Address(RVA = "0x343DDE0", Offset = "0x343C7E0", VA = "0x18343DDE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001776")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D03")]
			[Cpp2IlInjected.Address(RVA = "0x343D670", Offset = "0x343C070", VA = "0x18343D670")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001777")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D04")]
			[Cpp2IlInjected.Address(RVA = "0x343DE40", Offset = "0x343C840", VA = "0x18343DE40", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001778")]
		[DebuggerNonUserCode]
		public RepeatedField<FriendshipLevel> DefaultFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6005D08")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return defaultFriendship_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001779")]
		[DebuggerNonUserCode]
		public RepeatedField<FriendshipData> Friendships
		{
			[Cpp2IlInjected.Token(Token = "0x6005D09")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return friendships_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177A")]
		[DebuggerNonUserCode]
		public int DefaultDiscussionFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6005D0A")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return defaultDiscussionFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D0B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				defaultDiscussionFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177B")]
		[DebuggerNonUserCode]
		public int DefaultGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6005D0C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return defaultGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D0D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				defaultGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177C")]
		[DebuggerNonUserCode]
		public FriendshipBonus FriendshipBonus
		{
			[Cpp2IlInjected.Token(Token = "0x6005D0E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return friendshipBonus_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D0F")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				friendshipBonus_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177D")]
		[DebuggerNonUserCode]
		public int DailyLimitation
		{
			[Cpp2IlInjected.Token(Token = "0x6005D10")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return dailyLimitation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D11")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				dailyLimitation_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFA")]
		[Cpp2IlInjected.Address(RVA = "0x343BB10", Offset = "0x343A510", VA = "0x18343BB10")]
		public FriendshipData GetFriendshipData(Item characterItem, [Optional] Func<FriendshipData, bool> predicate)
		{
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			RepeatedField<FriendshipData> repeatedField = friendships_;
			Predicate<FriendshipData> predicate2 = (Predicate<FriendshipData>)(object)(Predicate<T>)delegate(FriendshipData x)
			{
				Item characterItem3 = x.CharacterItem;
				throw new NullReferenceException();
			};
			FriendshipData friendshipData = ((RepeatedField<>)(object)repeatedField).Find<FriendshipData>((Predicate<>)(object)predicate2);
			if (friendshipData != null && (predicate == null || predicate((T)friendshipData) != null))
			{
				return friendshipData;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFB")]
		[Cpp2IlInjected.Address(RVA = "0x343B8A0", Offset = "0x343A2A0", VA = "0x18343B8A0")]
		public int GetDiscussionFriendship(Item characterItem)
		{
			//Discarded unreachable code: IL_002f
			if (_003C_003Ec._003C_003E9__10_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FriendshipData x) => x.discussionFriendship_ > 0);
			}
			FriendshipData friendshipData = default(FriendshipData);
			return friendshipData?.discussionFriendship_ ?? defaultDiscussionFriendship_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFC")]
		[Cpp2IlInjected.Address(RVA = "0x343BF80", Offset = "0x343A980", VA = "0x18343BF80")]
		public int GetGiftFriendship(Item characterItem)
		{
			//Discarded unreachable code: IL_002f
			if (_003C_003Ec._003C_003E9__11_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FriendshipData x) => x.giftFriendship_ > 0);
			}
			FriendshipData friendshipData = default(FriendshipData);
			return friendshipData?.giftFriendship_ ?? defaultGiftFriendship_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFD")]
		[Cpp2IlInjected.Address(RVA = "0x343BC60", Offset = "0x343A660", VA = "0x18343BC60")]
		public RepeatedField<FriendshipLevel> GetFriendshipLevels(Item characterItem)
		{
			//Discarded unreachable code: IL_00a4, IL_00aa, IL_00b0, IL_00b6, IL_00bc
			//IL_0049: Expected O, but got I4
			RepeatedField<FriendshipLevel> repeatedField = (RepeatedField<FriendshipLevel>)(object)((RepeatedField<T>)(object)defaultFriendship_).Clone();
			FriendshipData friendshipData = default(FriendshipData);
			if (friendshipData != null)
			{
				RepeatedField<FriendshipLevel> friendshipLevels_ = friendshipData.friendshipLevels_;
				if (friendshipLevels_ != null)
				{
					int count = ((RepeatedField<T>)(object)friendshipLevels_).Count;
					int count2 = ((RepeatedField<T>)(object)repeatedField).Count;
					bool flag = default(bool);
					if (count != count2 && flag)
					{
						FriendshipLevel characterLevel = (FriendshipLevel)0;
						Predicate<FriendshipLevel> predicate = (Predicate<FriendshipLevel>)(object)(Predicate<T>)delegate(FriendshipLevel x)
						{
							//Discarded unreachable code: IL_0016
							int level_ = characterLevel.level_;
							return x.level_ == level_;
						};
						FriendshipLevel friendshipLevel = ((RepeatedField<>)(object)repeatedField).Find<FriendshipLevel>((Predicate<>)(object)predicate);
						while (friendshipLevel == null)
						{
						}
						((RepeatedField<T>)(object)friendshipLevel.tier1Reward_).Clear();
						((RepeatedField<T>)(object)friendshipLevel.tier2Reward_).Clear();
						((RepeatedField<T>)(object)friendshipLevel.tier3Reward_).Clear();
						((RepeatedField<T>)(object)friendshipLevel.levelReward_).Clear();
					}
					return (RepeatedField<FriendshipLevel>)(object)((RepeatedField<T>)(object)friendshipLevels_).Clone();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFE")]
		[Cpp2IlInjected.Address(RVA = "0x343B380", Offset = "0x3439D80", VA = "0x18343B380", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_008d
			//IL_0081: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			int num = 0;
			if (defaultDiscussionFriendship_ < num)
			{
				context.AddInvalidMemberError("Must be >= 0", "DefaultDiscussionFriendship");
			}
			context.AddInvalidMemberError("Must be > 0", "DefaultGiftFriendship");
			if (Enumerable.First<FriendshipLevel>((IEnumerable<>)(object)defaultFriendship_).level_ != num)
			{
				context.AddInvalidMemberError("First Level must be 0", "DefaultFriendship");
			}
			RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
			this.ValidateFriendshipLevels(context, (RepeatedField<>)(object)repeatedField, "DefaultFriendship");
			RepeatedField<FriendshipData> repeatedField2 = friendships_;
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				bool flag2 = default(bool);
				string text = default(string);
				if (!flag2)
				{
					this.ValidateFriendshipLevelOverrides(context, (RepeatedField<>)num2, text);
				}
				this.ValidateFriendshipLevels(context, (RepeatedField<>)num2, text);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFF")]
		[Cpp2IlInjected.Address(RVA = "0x343C1D0", Offset = "0x343ABD0", VA = "0x18343C1D0")]
		private bool IsOverridingAllLevels(FriendshipData friendship)
		{
			//Discarded unreachable code: IL_0066, IL_006c, IL_0072
			//IL_001f: Expected O, but got I4
			int num2;
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				num2 = 0;
				RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
				if (!flag)
				{
					break;
				}
				FriendshipLevel friendshipLevel = (FriendshipLevel)0;
				if (friendshipLevel.level_ != 0)
				{
					RepeatedField<FriendshipLevel> friendshipLevels_ = friendship.friendshipLevels_;
					Func<FriendshipLevel, bool> func = (Func<FriendshipLevel, bool>)(object)(Func<T, TResult>)delegate(FriendshipLevel x)
					{
						//Discarded unreachable code: IL_0016
						int level_ = friendshipLevel.level_;
						return x.level_ == level_;
					};
					if (Enumerable.FirstOrDefault<FriendshipLevel>((IEnumerable<>)(object)friendshipLevels_, (Func<, >)(object)func) == null)
					{
						int num3 = 0;
						num2++;
						break;
					}
				}
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D00")]
		[Cpp2IlInjected.Address(RVA = "0x343CCA0", Offset = "0x343B6A0", VA = "0x18343CCA0")]
		private void ValidateFriendshipLevels(DataValidation.Context context, RepeatedField<FriendshipLevel> friendshipLevels, string name)
		{
			//Discarded unreachable code: IL_004c, IL_0052, IL_0058
			int num = 0;
			Func<FriendshipLevel, bool> _003C_003E9__15_ = _003C_003Ec._003C_003E9__15_0;
			if (_003C_003E9__15_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FriendshipLevel x) => x.level_ == 0);
			}
			FriendshipLevel friendshipLevel = Enumerable.FirstOrDefault<FriendshipLevel>((IEnumerable<>)(object)friendshipLevels, (Func<, >)(object)_003C_003E9__15_);
			bool flag = default(bool);
			if (flag)
			{
				if (flag)
				{
					context.AddInvalidMemberError("XP must be greater than previous element", name);
				}
				context.AddInvalidMemberError("Level must use an incremental step of 1", name);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D01")]
		[Cpp2IlInjected.Address(RVA = "0x343CA40", Offset = "0x343B440", VA = "0x18343CA40")]
		private void ValidateFriendshipLevelOverrides(DataValidation.Context context, RepeatedField<FriendshipLevel> friendshipLevels, string name)
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_007c
			//IL_0011: Expected O, but got I4
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			FriendshipLevel friendshipLevel = (FriendshipLevel)0;
			RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
			Func<FriendshipLevel, bool> func = (Func<FriendshipLevel, bool>)(object)(Func<T, TResult>)delegate(FriendshipLevel x)
			{
				//Discarded unreachable code: IL_0016
				int level_ = friendshipLevel.level_;
				return x.level_ == level_;
			};
			FriendshipLevel friendshipLevel2 = Enumerable.FirstOrDefault<FriendshipLevel>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (friendshipLevel2 != null)
			{
				int xP_ = friendshipLevel2.xP_;
				FriendshipLevel friendshipLevel3 = friendshipLevel;
				while (xP_ == friendshipLevel3.xP_)
				{
				}
				context.AddInvalidMemberError("XP must use the same value as DefaultFriendship or override ALL levels", name);
			}
			context.AddInvalidMemberError("Level is not valid", name);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D05")]
		[Cpp2IlInjected.Address(RVA = "0x343D360", Offset = "0x343BD60", VA = "0x18343D360")]
		[DebuggerNonUserCode]
		public Friendship()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005D06")]
		[Cpp2IlInjected.Address(RVA = "0x343D420", Offset = "0x343BE20", VA = "0x18343D420")]
		[DebuggerNonUserCode]
		public Friendship(Friendship other)
		{
			//IL_00b3: Expected O, but got I4
			RepeatedField<FriendshipLevel> repeatedField = (defaultFriendship_ = (RepeatedField<FriendshipLevel>)(object)((RepeatedField<T>)(object)other.defaultFriendship_).Clone());
			RepeatedField<FriendshipData> repeatedField2 = (friendships_ = (RepeatedField<FriendshipData>)(object)((RepeatedField<T>)(object)other.friendships_).Clone());
			int num = (defaultDiscussionFriendship_ = other.defaultDiscussionFriendship_);
			int num2 = (defaultGiftFriendship_ = other.defaultGiftFriendship_);
			FriendshipBonus friendshipBonus = other.friendshipBonus_;
			if (friendshipBonus != null)
			{
				FriendshipBonus friendshipBonus2 = new FriendshipBonus();
				RepeatedField<int> repeatedField3 = (friendshipBonus2.dialogueXP_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)friendshipBonus.dialogueXP_).Clone());
				UnknownFieldSet unknownFieldSet = (friendshipBonus2._unknownFields = UnknownFieldSet.Clone(friendshipBonus._unknownFields));
			}
			int num3 = 0;
			friendshipBonus_ = (FriendshipBonus)num3;
			int num4 = (dailyLimitation_ = other.dailyLimitation_);
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D07")]
		[Cpp2IlInjected.Address(RVA = "0x343B320", Offset = "0x3439D20", VA = "0x18343B320", Slot = "14")]
		[DebuggerNonUserCode]
		public Friendship Clone()
		{
			return new Friendship(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D12")]
		[Cpp2IlInjected.Address(RVA = "0x343B760", Offset = "0x343A160", VA = "0x18343B760", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<FriendshipData> repeatedField2 = friendships_;
					bool flag2 = default(bool);
					if (flag2 && defaultDiscussionFriendship_ == (flag2 ? 1 : 0) && defaultGiftFriendship_ == (flag2 ? 1 : 0))
					{
						bool flag3 = object.Equals(friendshipBonus_, other);
						if (flag3 && dailyLimitation_ == (flag3 ? 1 : 0))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D13")]
		[Cpp2IlInjected.Address(RVA = "0x343B670", Offset = "0x343A070", VA = "0x18343B670", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(Friendship other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
				RepeatedField<FriendshipLevel> repeatedField2 = other.defaultFriendship_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					RepeatedField<FriendshipData> repeatedField3 = friendships_;
					RepeatedField<FriendshipData> repeatedField4 = other.friendships_;
					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
					{
						int num = other.defaultDiscussionFriendship_;
						if (defaultDiscussionFriendship_ == num)
						{
							int num2 = other.defaultGiftFriendship_;
							if (defaultGiftFriendship_ == num2)
							{
								FriendshipBonus objB = other.friendshipBonus_;
								if (object.Equals(friendshipBonus_, objB))
								{
									int num3 = other.dailyLimitation_;
									if (dailyLimitation_ == num3)
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										return object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D14")]
		[Cpp2IlInjected.Address(RVA = "0x343C0D0", Offset = "0x343AAD0", VA = "0x18343C0D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0062
			int hashCode = ((RepeatedField<T>)(object)defaultFriendship_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)friendships_).GetHashCode();
			if (defaultDiscussionFriendship_ != 0)
			{
			}
			if (defaultGiftFriendship_ != 0)
			{
			}
			FriendshipBonus friendshipBonus = friendshipBonus_;
			if (friendshipBonus != null)
			{
				int hashCode3 = friendshipBonus.GetHashCode();
			}
			if (dailyLimitation_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D15")]
		[Cpp2IlInjected.Address(RVA = "0x343C9E0", Offset = "0x343B3E0", VA = "0x18343C9E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D16")]
		[Cpp2IlInjected.Address(RVA = "0x343CF30", Offset = "0x343B930", VA = "0x18343CF30", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a6
			RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
			FieldCodec<FriendshipLevel> repeated_defaultFriendship_codec = _repeated_defaultFriendship_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_defaultFriendship_codec);
			RepeatedField<FriendshipData> repeatedField2 = friendships_;
			FieldCodec<FriendshipData> repeated_friendships_codec = _repeated_friendships_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_friendships_codec);
			if (defaultDiscussionFriendship_ != 0)
			{
				int value = defaultDiscussionFriendship_;
				output.WriteInt32(value);
			}
			if (defaultGiftFriendship_ != 0)
			{
				int value2 = defaultGiftFriendship_;
				output.WriteInt32(value2);
			}
			if ((long)friendshipBonus_ != 0)
			{
				FriendshipBonus value3 = friendshipBonus_;
				output.WriteMessage(value3);
			}
			if (dailyLimitation_ != 0)
			{
				int value4 = dailyLimitation_;
				output.WriteInt32(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D17")]
		[Cpp2IlInjected.Address(RVA = "0x343B060", Offset = "0x3439A60", VA = "0x18343B060", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
			FieldCodec<FriendshipLevel> repeated_defaultFriendship_codec = _repeated_defaultFriendship_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_defaultFriendship_codec);
			RepeatedField<FriendshipData> repeatedField2 = friendships_;
			FieldCodec<FriendshipData> repeated_friendships_codec = _repeated_friendships_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_friendships_codec);
			int num3 = defaultDiscussionFriendship_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				repeatedField = (RepeatedField<FriendshipLevel>)(repeatedField + num4);
			}
			int num5 = defaultGiftFriendship_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				repeatedField = (RepeatedField<FriendshipLevel>)(repeatedField + num6);
			}
			FriendshipBonus friendshipBonus = friendshipBonus_;
			if (friendshipBonus != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(friendshipBonus);
				num7++;
				repeatedField = (RepeatedField<FriendshipLevel>)(repeatedField + num7);
			}
			int num8 = dailyLimitation_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				repeatedField = (RepeatedField<FriendshipLevel>)(repeatedField + num9);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<FriendshipLevel>)(repeatedField + num10);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D18")]
		[Cpp2IlInjected.Address(RVA = "0x343C420", Offset = "0x343AE20", VA = "0x18343C420", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(Friendship other)
		{
			//Discarded unreachable code: IL_0103
			if (other == null)
			{
				return;
			}
			RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
			RepeatedField<FriendshipLevel> repeatedField2 = other.defaultFriendship_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<FriendshipData> repeatedField3 = friendships_;
			RepeatedField<FriendshipData> repeatedField4 = other.friendships_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			int num = other.defaultDiscussionFriendship_;
			if (num != 0)
			{
				defaultDiscussionFriendship_ = num;
			}
			int num2 = other.defaultGiftFriendship_;
			if (num2 != 0)
			{
				defaultGiftFriendship_ = num2;
			}
			if (other.friendshipBonus_ != null)
			{
				FriendshipBonus friendshipBonus2 = default(FriendshipBonus);
				FriendshipBonus friendshipBonus3 = default(FriendshipBonus);
				if (friendshipBonus_ == null)
				{
					FriendshipBonus friendshipBonus = (friendshipBonus_ = new FriendshipBonus());
					friendshipBonus2 = friendshipBonus_;
					friendshipBonus3 = other.friendshipBonus_;
				}
				if (friendshipBonus3 != null)
				{
					RepeatedField<int> dialogueXP_ = friendshipBonus2.dialogueXP_;
					RepeatedField<int> dialogueXP_2 = friendshipBonus3.dialogueXP_;
					((RepeatedField<T>)(object)dialogueXP_).Add((IEnumerable<>)(object)dialogueXP_2);
					UnknownFieldSet unknownFields = friendshipBonus3._unknownFields;
					UnknownFieldSet unknownFieldSet = (friendshipBonus2._unknownFields = UnknownFieldSet.MergeFrom(friendshipBonus2._unknownFields, unknownFields));
				}
			}
			int num3 = other.dailyLimitation_;
			if (num3 != 0)
			{
				dailyLimitation_ = num3;
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6005D19")]
		[Cpp2IlInjected.Address(RVA = "0x343C5C0", Offset = "0x343AFC0", VA = "0x18343C5C0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00d5
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 32)
				{
					int num2 = (defaultGiftFriendship_ = input.ReadInt32());
				}
				FriendshipBonus friendshipBonus = default(FriendshipBonus);
				if (num == 42)
				{
					FriendshipBonus builder = default(FriendshipBonus);
					if (friendshipBonus_ == null)
					{
						friendshipBonus = (friendshipBonus_ = new FriendshipBonus());
						builder = friendshipBonus_;
					}
					input.ReadMessage(builder);
				}
				if ((long)friendshipBonus != 48)
				{
					goto IL_00be;
				}
				int num3 = (dailyLimitation_ = input.ReadInt32());
			}
			if (num == 10)
			{
				RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
				FieldCodec<FriendshipLevel> repeated_defaultFriendship_codec = _repeated_defaultFriendship_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_defaultFriendship_codec);
			}
			if (num == 18)
			{
				RepeatedField<FriendshipData> repeatedField2 = friendships_;
				FieldCodec<FriendshipData> repeated_friendships_codec = _repeated_friendships_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_friendships_codec);
			}
			if (num == 24)
			{
				int num4 = (defaultDiscussionFriendship_ = input.ReadInt32());
			}
			goto IL_00be;
			IL_00be:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1A")]
		[Cpp2IlInjected.Address(RVA = "0x343B9F0", Offset = "0x343A3F0", VA = "0x18343B9F0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1B")]
		[Cpp2IlInjected.Address(RVA = "0x343C7C0", Offset = "0x343B1C0", VA = "0x18343C7C0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_001e
			//IL_000d: Expected I4, but got O
			//IL_0016: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				defaultDiscussionFriendship_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1C")]
		[Cpp2IlInjected.Address(RVA = "0x343B230", Offset = "0x3439C30", VA = "0x18343B230", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0010
			if (fieldNumber - 1 <= 5)
			{
				RepeatedField<FriendshipLevel> repeatedField = defaultFriendship_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1D")]
		[Cpp2IlInjected.Address(RVA = "0x343D0D0", Offset = "0x343BAD0", VA = "0x18343D0D0")]
		static Friendship()
		{
			MessageParser<FriendshipLevel> parser = FriendshipLevel._parser;
			uint num = default(uint);
			_parser = (MessageParser<Friendship>)(object)FieldCodec.ForMessage<FriendshipLevel>(num, (MessageParser<>)(object)parser);
			MessageParser<FriendshipData> parser2 = FriendshipData._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<Friendship>)(object)FieldCodec.ForMessage<FriendshipData>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
