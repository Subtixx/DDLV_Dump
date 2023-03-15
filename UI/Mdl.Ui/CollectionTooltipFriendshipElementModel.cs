using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000327")]
	public class CollectionTooltipFriendshipElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700037A")]
		public CharacterItemData CharacterItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001428")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001429")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CCharacterItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600142A")]
		[Cpp2IlInjected.Address(RVA = "0x114BCE0", Offset = "0x114A6E0", VA = "0x18114BCE0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_006f, IL_007d, IL_0093, IL_0094
			if ((long)CharacterItemData == 0)
			{
				IItemData itemData = base.ItemData;
				CharacterItemData characterItemData = default(CharacterItemData);
				CharacterItemData = characterItemData;
			}
			int num = 0;
			if (Application.isPlaying)
			{
				int iD = CharacterItemData.ID;
				CharacterManager.CharacterInstance characterInstance = default(CharacterManager.CharacterInstance);
				if (characterInstance != null)
				{
					int friendshipLevel_ = characterInstance.MetaCharacter.friendshipLevel_;
					Meta.Character metaCharacter = characterInstance.MetaCharacter;
					Client client = default(Client);
					Profile profile = client.profile;
					float xpProgression = metaCharacter.GetXpProgression(profile);
				}
			}
			Dictionary<FloatValueType, float> dictionary = base.Floats;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600142B")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipFriendshipElementModel()
		{
		}
	}
}
