using System;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x2000850")]
	public class FriendshipHelper
	{
		[Cpp2IlInjected.Token(Token = "0x17001770")]
		public static RepeatedField<FriendshipLevel> DefaultFriendshipLevels
		{
			[Cpp2IlInjected.Token(Token = "0x6005CF4")]
			[Cpp2IlInjected.Address(RVA = "0x3438DF0", Offset = "0x34377F0", VA = "0x183438DF0")]
			get
			{
				Friendship instance;
				do
				{
					int num = 0;
					instance = Friendship.Instance;
				}
				while (instance == null);
				return instance.defaultFriendship_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CF1")]
		[Cpp2IlInjected.Address(RVA = "0x3438A10", Offset = "0x3437410", VA = "0x183438A10")]
		public static int GetDiscussionFriendship(Item characterItem)
		{
			Friendship instance;
			do
			{
				int num = 0;
				instance = Friendship.Instance;
			}
			while (instance == null);
			if (Friendship._003C_003Ec._003C_003E9__10_0 == null)
			{
				Friendship._003C_003Ec._003C_003E9 = (Friendship._003C_003Ec)(object)(Func<T, TResult>)((FriendshipData x) => x.discussionFriendship_ > 0);
			}
			FriendshipData friendshipData = default(FriendshipData);
			return friendshipData?.discussionFriendship_ ?? instance.defaultDiscussionFriendship_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CF2")]
		[Cpp2IlInjected.Address(RVA = "0x3438C10", Offset = "0x3437610", VA = "0x183438C10")]
		public static int GetGiftFriendship(Item characterItem, Item giftItem, ItemState giftState)
		{
			bool flag = default(bool);
			FriendshipData friendshipData = default(FriendshipData);
			while (true)
			{
				int itemID = giftItem.ItemID;
				if (flag)
				{
					continue;
				}
				int num = 0;
				if (Friendship.Instance == null)
				{
					continue;
				}
				if (Friendship._003C_003Ec._003C_003E9__11_0 == null)
				{
					Friendship._003C_003Ec._003C_003E9 = (Friendship._003C_003Ec)(object)(Func<T, TResult>)((FriendshipData x) => x.giftFriendship_ > 0);
				}
				if (friendshipData != null)
				{
					break;
				}
			}
			return friendshipData.giftFriendship_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CF3")]
		[Cpp2IlInjected.Address(RVA = "0x3438BA0", Offset = "0x34375A0", VA = "0x183438BA0")]
		public static RepeatedField<FriendshipLevel> GetFriendshipLevels(Item characterItem)
		{
			do
			{
				int num = 0;
			}
			while (Friendship.Instance == null);
			RepeatedField<FriendshipLevel> result = default(RepeatedField<FriendshipLevel>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CF5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FriendshipHelper()
		{
		}
	}
}
