using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009B0")]
	public class AddedFriendshipSummary
	{
		[Cpp2IlInjected.Token(Token = "0x17000E9E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002821")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x600546A")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600546B")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E9F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4002822")]
		public int PreviousCharacterFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x600546C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600546D")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002823")]
		public bool CharacterLevelUp
		{
			[Cpp2IlInjected.Token(Token = "0x600546E")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600546F")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA1")]
		public MultiReward CharacterLevelUpRewards
		{
			[Cpp2IlInjected.Token(Token = "0x6005470")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterLevelUpRewards_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6005471")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			internal set
			{
				_003CCharacterLevelUpRewards_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4002825")]
		public int PreviousPlayerXP
		{
			[Cpp2IlInjected.Token(Token = "0x6005472")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005473")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x4002826")]
		public bool PlayerLevelUp
		{
			[Cpp2IlInjected.Token(Token = "0x6005474")]
			[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005475")]
			[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA4")]
		public MultiReward PlayerLevelUpRewards
		{
			[Cpp2IlInjected.Token(Token = "0x6005476")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayerLevelUpRewards_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6005477")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			internal set
			{
				_003CPlayerLevelUpRewards_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4002828")]
		public int FriendshipGained
		{
			[Cpp2IlInjected.Token(Token = "0x6005478")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005479")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x4002829")]
		public FriendshipSource FriendshipSource
		{
			[Cpp2IlInjected.Token(Token = "0x600547A")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600547B")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x600547C")]
		[Cpp2IlInjected.Address(RVA = "0x18E6890", Offset = "0x18E5290", VA = "0x1818E6890")]
		internal unsafe void MergeWith(AddedFriendshipSummary other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerLevelUp)
			{
				MultiReward multiReward = PlayerLevelUpRewards;
				PlayerLevelUp = true;
				MultiReward moreRewards = other.PlayerLevelUpRewards;
				multiReward?.MergedRewards(moreRewards);
				PlayerLevelUpRewards = moreRewards;
			}
			if (other.CharacterLevelUp)
			{
				Item item = CharacterItem;
				Item item2 = other.CharacterItem;
				if (*(Item*)item == *(Item*)item2)
				{
					MultiReward multiReward2 = CharacterLevelUpRewards;
					CharacterLevelUp = true;
					MultiReward moreRewards2 = other.PlayerLevelUpRewards;
					multiReward2?.MergedRewards(moreRewards2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600547D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AddedFriendshipSummary()
		{
		}
	}
}
