using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Character;
using Definitions.Items;
using Definitions.Rewards;
using Google.Protobuf.Collections;
using Mdl.Characters;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200030D")]
	public class CollectionTooltipCharacterModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000ED5")]
		private List<FriendshipLevel> _friendshipLevels;

		[Cpp2IlInjected.Token(Token = "0x17000365")]
		public CharacterItemData CharacterItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013CA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCharacterItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013CC")]
		[Cpp2IlInjected.Address(RVA = "0x1147A10", Offset = "0x1146410", VA = "0x181147A10", Slot = "4")]
		public unsafe override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_0382, IL_0388, IL_038e, IL_0394, IL_039a, IL_03a0, IL_03a6, IL_03ac, IL_03b2, IL_03b8, IL_03be, IL_03ca, IL_03d0, IL_03d6, IL_03dc, IL_03e2, IL_03e8, IL_03ee, IL_03f4
			//IL_00ee: Expected I4, but got I8
			//IL_0122: Expected I4, but got I8
			//IL_0194: Expected I4, but got I8
			//IL_02ae: Expected I4, but got I8
			//IL_02d4: Expected O, but got I4
			//IL_0301: Expected O, but got I4
			//IL_033f: Expected O, but got I4
			//IL_035a: Expected O, but got I4
			CharacterItemData characterItemData = default(CharacterItemData);
			CharacterManager.CharacterInstance characterInstance = default(CharacterManager.CharacterInstance);
			GameObject gameObject = default(GameObject);
			GameObject gameObject2 = default(GameObject);
			ulong num6 = default(ulong);
			GameObject gameObject3 = default(GameObject);
			ulong num7 = default(ulong);
			int num9 = default(int);
			int num10 = default(int);
			Transform transform = default(Transform);
			GameObject gameObject5 = default(GameObject);
			ulong num14 = default(ulong);
			Transform transform2 = default(Transform);
			IItemData itemData3 = default(IItemData);
			PreferredItemCategory _003CPreferredItemCategory_003Ek__BackingField = default(PreferredItemCategory);
			bool flag = default(bool);
			Predicate<FriendshipLevel> predicate = default(Predicate<FriendshipLevel>);
			Client client = default(Client);
			bool flag2 = default(bool);
			GameObject gameObject7 = default(GameObject);
			ulong num19 = default(ulong);
			IItemData _003CMissionRewardAlt_003Ek__BackingField = default(IItemData);
			bool flag4 = default(bool);
			int num25 = default(int);
			Transform transform3 = default(Transform);
			bool _003CIsFinalReward_003Ek__BackingField = default(bool);
			IItemData _003CMissionRewardAlt_003Ek__BackingField2 = default(IItemData);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if ((object)viewBase == null)
				{
				}
				int num4 = 0;
				if ((IntPtr)CharacterItemData == (IntPtr)num3)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					IItemData itemData = base.ItemData;
					CharacterItemData = characterItemData;
				}
				CollectionTooltipFriendshipElementModel collectionTooltipFriendshipElementModel = new CollectionTooltipFriendshipElementModel();
				IItemData itemData2 = (((CollectionTooltipElementModel)collectionTooltipFriendshipElementModel).ItemData = base.ItemData);
				CharacterItemData characterItemData2 = (collectionTooltipFriendshipElementModel.CharacterItemData = CharacterItemData);
				collectionTooltipFriendshipElementModel.CharacterItemData = (CharacterItemData)(object)collectionTooltipFriendshipElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipFriendshipElementModel).Sprites;
				int num5 = 0;
				if (!Application.isPlaying)
				{
					return;
				}
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				CharacterItemData characterItemData3 = CharacterItemData;
				if (characterInstance == null)
				{
					return;
				}
				Meta.Character metaCharacter = characterInstance.MetaCharacter;
				if (!metaCharacter.CanHangoutWithPlayer)
				{
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				ProfessionItemData profession = metaCharacter.Profession;
				CollectionTooltipProfessionElementModel collectionTooltipProfessionElementModel = new CollectionTooltipProfessionElementModel();
				((CollectionTooltipElementModel)collectionTooltipProfessionElementModel).ItemData = profession;
				collectionTooltipProfessionElementModel.ProfessionItemData = profession;
				collectionTooltipProfessionElementModel.ProfessionItemData = (ProfessionItemData)(object)collectionTooltipProfessionElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField2 = ((CollectionTooltipElementModel)collectionTooltipProfessionElementModel).Sprites;
				gameObject2.SetActive((byte)num6 != 0);
				CollectionTooltipHangoutBuffElementModel collectionTooltipHangoutBuffElementModel = new CollectionTooltipHangoutBuffElementModel();
				((CollectionTooltipElementModel)collectionTooltipHangoutBuffElementModel).ItemData = profession;
				((CollectionTooltipProfessionElementModel)collectionTooltipHangoutBuffElementModel).ProfessionItemData = profession;
				((CollectionTooltipProfessionElementModel)collectionTooltipHangoutBuffElementModel).ProfessionItemData = (ProfessionItemData)(object)collectionTooltipHangoutBuffElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField3 = ((CollectionTooltipElementModel)collectionTooltipHangoutBuffElementModel).Sprites;
				gameObject3.SetActive((byte)num7 != 0);
				int num8 = Enumerable.Count<Item>(metaCharacter.get_PreferredItems());
				num9 -= num8;
				int num11 = num10 - 1;
				CollectionTooltipElement component = transform.GetComponent<CollectionTooltipElement>();
				RecycleBin recycleBin = viewBase.RecycleBin;
				GameObject gameObject4 = component.gameObject;
				recycleBin.SendToBin(gameObject4);
				int num12 = 0;
				IEnumerable<Item> preferredItems = (IEnumerable<Item>)metaCharacter.get_PreferredItems();
				if (preferredItems != null)
				{
					int num13 = 0;
					RecycleBin recycleBin2 = viewBase.RecycleBin;
					Type typeFromHandle = typeof(CollectionTooltipElement);
					gameObject5.SetActive((byte)num14 != 0);
					CollectionTooltipElement component2 = transform2.GetComponent<CollectionTooltipElement>();
					Item preferredItem = metaCharacter.GetPreferredItem(num12);
					CollectionTooltipFavoriteElementModel collectionTooltipFavoriteElementModel = new CollectionTooltipFavoriteElementModel();
					((CollectionTooltipElementModel)collectionTooltipFavoriteElementModel).ItemData = itemData3;
					int num15 = (int)(collectionTooltipFavoriteElementModel.PreferredItemStatus = metaCharacter.GetPreferredItemStatus(num12));
					collectionTooltipFavoriteElementModel.PreferredItemCategory = _003CPreferredItemCategory_003Ek__BackingField;
					collectionTooltipFavoriteElementModel.IsAlreadyGifted = flag;
					component2.Model = collectionTooltipFavoriteElementModel;
					component2.Model.UpdateDisplay(component2);
					num12++;
				}
				if (preferredItems != null)
				{
				}
				if (flag)
				{
					break;
				}
				List<FriendshipLevel> list = (List<FriendshipLevel>)(object)Enumerable.ToList<FriendshipLevel>((IEnumerable<>)(object)metaCharacter.GetFriendshipLevels());
				if (_003C_003Ec._003C_003E9__5_0 == null)
				{
					predicate = (Predicate<FriendshipLevel>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(FriendshipLevel x)
					{
						//Discarded unreachable code: IL_0017
						RepeatedField<ItemReward> tier1Reward_ = x.tier1Reward_;
						if (tier1Reward_ == null)
						{
							int num28 = 0;
						}
						return ((RepeatedField<T>)(object)tier1Reward_).Count > 0;
					});
				}
				List<FriendshipLevel> list2 = (_friendshipLevels = (List<FriendshipLevel>)(object)((List<T>)(object)list).FindAll((Predicate<>)(object)predicate));
				Meta.Character metaCharacter2 = characterInstance.MetaCharacter;
				Profile profile = client.profile;
				float xpProgression = metaCharacter2.GetXpProgression(profile);
				int num16 = 0;
				CharacterItemData data = metaCharacter.Data;
				if (flag2)
				{
					int num17 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				int num18 = 0;
				int friendshipLevel_ = metaCharacter.friendshipLevel_;
				GameObject gameObject6 = viewBase.gameObject;
				int active2 = 0;
				gameObject6.SetActive((byte)active2 != 0);
				gameObject7.SetActive((byte)num19 != 0);
				CharacterLevelRewardItemModel characterLevelRewardItemModel = new CharacterLevelRewardItemModel();
				int num20 = 0;
				int num21 = metaCharacter.friendshipLevel_ - 1;
				int num22 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				characterLevelRewardItemModel.FriendshipLevel = (FriendshipLevel)num20;
				characterLevelRewardItemModel.Character = metaCharacter;
				bool flag3 = (characterLevelRewardItemModel.IsFinalReward = (IntPtr)characterLevelRewardItemModel.Character == (IntPtr)metaCharacter.friendshipLevel_);
				characterLevelRewardItemModel.MissionReward = (IItemData)num18;
				if (flag2)
				{
					int num23 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					characterLevelRewardItemModel.MissionRewardAlt = _003CMissionRewardAlt_003Ek__BackingField;
				}
				int num24 = 0;
				if (flag4)
				{
					if (num24 < num25)
					{
					}
					if (transform3.TryGetComponent<NPCLevelRewardItem>(out *(NPCLevelRewardItem*)num2))
					{
						CharacterLevelRewardItemModel characterLevelRewardItemModel2 = new CharacterLevelRewardItemModel();
						characterLevelRewardItemModel2.FriendshipLevel = (FriendshipLevel)num2;
						characterLevelRewardItemModel2.Character = metaCharacter;
						characterLevelRewardItemModel2.IsFinalReward = _003CIsFinalReward_003Ek__BackingField;
						characterLevelRewardItemModel2.MissionReward = (IItemData)num18;
						if (flag2)
						{
							int num26 = 0;
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							characterLevelRewardItemModel2.MissionRewardAlt = _003CMissionRewardAlt_003Ek__BackingField2;
						}
						int num27 = 0;
					}
					num24++;
				}
				if (num18 == 0)
				{
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013CD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipCharacterModel()
		{
		}
	}
}
