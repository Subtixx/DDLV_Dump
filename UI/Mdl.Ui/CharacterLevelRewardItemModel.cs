using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Character;
using Definitions.Items;
using Definitions.Rewards;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005F3")]
	public class CharacterLevelRewardItemModel : CustomeElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x170005F0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002108")]
		public bool IsFinalReward
		{
			[Cpp2IlInjected.Token(Token = "0x600271A")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600271B")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005F1")]
		public Character Character
		{
			[Cpp2IlInjected.Token(Token = "0x600271C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCharacter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600271D")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCharacter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F2")]
		public FriendshipLevel FriendshipLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600271E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CFriendshipLevel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600271F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CFriendshipLevel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F3")]
		public IItemData MissionReward
		{
			[Cpp2IlInjected.Token(Token = "0x6002720")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CMissionReward_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002721")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CMissionReward_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F4")]
		public IItemData MissionRewardAlt
		{
			[Cpp2IlInjected.Token(Token = "0x6002722")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CMissionRewardAlt_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002723")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CMissionRewardAlt_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002724")]
		[Cpp2IlInjected.Address(RVA = "0xFF8920", Offset = "0xFF7320", VA = "0x180FF8920", Slot = "4")]
		public override void UpdateDisplay(CustomElement viewBase)
		{
			//Discarded unreachable code: IL_0054, IL_0081, IL_00a0, IL_00b5, IL_00e2, IL_00ef, IL_0109, IL_0120, IL_012e, IL_014c, IL_0151, IL_015f, IL_016c, IL_0170, IL_0179, IL_019a
			//IL_0145: Expected O, but got I4
			//IL_0179: Expected I4, but got I8
			FriendshipLevel friendshipLevel = FriendshipLevel;
			int num = 0;
			if (friendshipLevel != null)
			{
				if ((object)viewBase == null)
				{
				}
				int num2 = 0;
				if (((RepeatedField<T>)(object)friendshipLevel.tier1Reward_).Count > 0)
				{
					Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = viewBase.Sprites;
					RepeatedField<ItemReward> tier1Reward_ = FriendshipLevel.tier1Reward_;
					int index = 0;
					Item item = ((ItemReward)((RepeatedField<T>)(object)tier1Reward_)[index]).Item;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002725")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public CharacterLevelRewardItemModel()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
