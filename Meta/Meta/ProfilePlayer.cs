using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Conditions;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Player;
using Definitions.Rewards;
using Definitions.Util;
using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Collections;
using Meta.Customization;
using Meta.Duties;
using Meta.Grids;
using Meta.Missions;
using Meta.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200092D")]
	public sealed class ProfilePlayer : IMessage<ProfilePlayer>, IMessage, IEquatable<ProfilePlayer>, IDeepCloneable<ProfilePlayer>, IMessageFieldAccessor, IProfilePlayer, IContainerInventoryProvider
	{
		[Cpp2IlInjected.Token(Token = "0x200092E")]
		internal enum AddManaContext
		{
			[Cpp2IlInjected.Token(Token = "0x40025F7")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40025F8")]
			Refill,
			[Cpp2IlInjected.Token(Token = "0x40025F9")]
			Meal
		}

		[Cpp2IlInjected.Token(Token = "0x4002563")]
		private static readonly MessageParser<ProfilePlayer> _parser = (MessageParser<ProfilePlayer>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ProfilePlayer()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002564")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002565")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002566")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x4002567")]
		public const int LevelFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002568")]
		private int level_;

		[Cpp2IlInjected.Token(Token = "0x4002569")]
		public const int XpFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400256A")]
		private int xp_;

		[Cpp2IlInjected.Token(Token = "0x400256B")]
		public const int ContainerInventoriesFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400256C")]
		private static readonly MapField<uint, ContainerInventory>.Codec _map_containerInventories_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400256D")]
		private readonly MapField<uint, ContainerInventory> containerInventories_;

		[Cpp2IlInjected.Token(Token = "0x400256E")]
		public const int NextContainerInventoryIDFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400256F")]
		private uint nextContainerInventoryID_;

		[Cpp2IlInjected.Token(Token = "0x4002570")]
		public const int ListInventoriesFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4002571")]
		private static readonly MapField<uint, ListInventory>.Codec _map_listInventories_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002572")]
		private readonly MapField<uint, ListInventory> listInventories_;

		[Cpp2IlInjected.Token(Token = "0x4002573")]
		public const int NextListInventoryIDFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002574")]
		private uint nextListInventoryID_;

		[Cpp2IlInjected.Token(Token = "0x4002575")]
		public const int CurrencyAmountsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4002576")]
		private static readonly MapField<int, int>.Codec _map_currencyAmounts_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002577")]
		private readonly MapField<int, int> currencyAmounts_;

		[Cpp2IlInjected.Token(Token = "0x4002578")]
		public const int ToolsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4002579")]
		private static readonly FieldCodec<ToolInfo> _repeated_tools_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400257A")]
		private readonly RepeatedField<ToolInfo> tools_;

		[Cpp2IlInjected.Token(Token = "0x400257B")]
		public const int ManaFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400257C")]
		private int mana_;

		[Cpp2IlInjected.Token(Token = "0x400257D")]
		public const int ManaHasAlreadyMissedFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400257E")]
		private bool manaHasAlreadyMissed_;

		[Cpp2IlInjected.Token(Token = "0x400257F")]
		public const int FemaleAvatarFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002580")]
		private Avatar femaleAvatar_;

		[Cpp2IlInjected.Token(Token = "0x4002581")]
		public const int MaleAvatarFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002582")]
		private Avatar maleAvatar_;

		[Cpp2IlInjected.Token(Token = "0x4002583")]
		public const int AvatarIsMaleFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002584")]
		private bool avatarIsMale_;

		[Cpp2IlInjected.Token(Token = "0x4002585")]
		public const int TransferDoneFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4002586")]
		private bool transferDone_;

		[Cpp2IlInjected.Token(Token = "0x4002587")]
		public const int CookbookFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002588")]
		private Cookbook cookbook_;

		[Cpp2IlInjected.Token(Token = "0x4002589")]
		public const int CookingHistoryFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x400258A")]
		private static readonly FieldCodec<CookingHistory> _repeated_cookingHistory_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400258B")]
		private readonly RepeatedField<CookingHistory> cookingHistory_;

		[Cpp2IlInjected.Token(Token = "0x400258C")]
		public const int UnlockedCraftingRecipesFieldNumber = 18;

		[Cpp2IlInjected.Token(Token = "0x400258D")]
		private static readonly FieldCodec<int> _repeated_unlockedCraftingRecipes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400258E")]
		private readonly RepeatedField<int> unlockedCraftingRecipes_;

		[Cpp2IlInjected.Token(Token = "0x400258F")]
		public const int BuffsFieldNumber = 19;

		[Cpp2IlInjected.Token(Token = "0x4002590")]
		private static readonly FieldCodec<Buff> _repeated_buffs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002591")]
		private readonly RepeatedField<Buff> buffs_;

		[Cpp2IlInjected.Token(Token = "0x4002592")]
		public const int PetsFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x4002593")]
		private static readonly FieldCodec<Pet> _repeated_pets_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002594")]
		private readonly RepeatedField<Pet> pets_;

		[Cpp2IlInjected.Token(Token = "0x4002595")]
		public const int CurrentPetFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002596")]
		private int currentPet_;

		[Cpp2IlInjected.Token(Token = "0x4002597")]
		public const int FishRecordsFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x4002598")]
		private static readonly MapField<int, FishRecord>.Codec _map_fishRecords_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002599")]
		private readonly MapField<int, FishRecord> fishRecords_;

		[Cpp2IlInjected.Token(Token = "0x400259A")]
		public const int DutySlotsFieldNumber = 23;

		[Cpp2IlInjected.Token(Token = "0x400259B")]
		private static readonly MapField<int, DutyList>.Codec _map_dutySlots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400259C")]
		private readonly MapField<int, DutyList> dutySlots_;

		[Cpp2IlInjected.Token(Token = "0x400259D")]
		public const int RoyalDutyProgressFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400259E")]
		private RoyalDutyProgress royalDutyProgress_;

		[Cpp2IlInjected.Token(Token = "0x400259F")]
		public const int CollectionSetsFieldNumber = 25;

		[Cpp2IlInjected.Token(Token = "0x40025A0")]
		private static readonly FieldCodec<CollectionSet> _repeated_collectionSets_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40025A1")]
		private readonly RepeatedField<CollectionSet> collectionSets_;

		[Cpp2IlInjected.Token(Token = "0x40025A2")]
		public const int AchievementsDataFieldNumber = 26;

		[Cpp2IlInjected.Token(Token = "0x40025A3")]
		private static readonly FieldCodec<AchievementData> _repeated_achievementsData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40025A4")]
		private readonly RepeatedField<AchievementData> achievementsData_;

		[Cpp2IlInjected.Token(Token = "0x40025A5")]
		public const int MiniEventStatesFieldNumber = 27;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40025A6")]
		private MiniEventStatesData miniEventStates_;

		[Cpp2IlInjected.Token(Token = "0x40025A7")]
		public const int MegaEventProgressFieldNumber = 28;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40025A8")]
		private MegaEventProgress megaEventProgress_;

		[Cpp2IlInjected.Token(Token = "0x40025A9")]
		public const int CampaignHistoryFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40025AA")]
		private CampaignHistoryData campaignHistory_;

		[Cpp2IlInjected.Token(Token = "0x40025AB")]
		public const int BattlePassStatesFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40025AC")]
		private BattlePassStatesData battlePassStates_;

		[Cpp2IlInjected.Token(Token = "0x40025AD")]
		public const int FurnitureDesignsFieldNumber = 32;

		[Cpp2IlInjected.Token(Token = "0x40025AE")]
		private static readonly MapField<int, DesignMap>.Codec _map_furnitureDesigns_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40025AF")]
		private readonly MapField<int, DesignMap> furnitureDesigns_;

		[Cpp2IlInjected.Token(Token = "0x40025B0")]
		public const int FurnitureDataFieldNumber = 33;

		[Cpp2IlInjected.Token(Token = "0x40025B1")]
		private static readonly MapField<int, Furniture>.Codec _map_furnitureData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40025B2")]
		private readonly MapField<int, Furniture> furnitureData_;

		[Cpp2IlInjected.Token(Token = "0x40025B3")]
		public const int NextFurnitureDesignIDFieldNumber = 34;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40025B4")]
		private int nextFurnitureDesignID_;

		[Cpp2IlInjected.Token(Token = "0x40025B5")]
		public const int FemaleClothingDesignsFieldNumber = 35;

		[Cpp2IlInjected.Token(Token = "0x40025B6")]
		private static readonly MapField<int, DesignMap>.Codec _map_femaleClothingDesigns_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40025B7")]
		private readonly MapField<int, DesignMap> femaleClothingDesigns_;

		[Cpp2IlInjected.Token(Token = "0x40025B8")]
		public const int MaleClothingDesignsFieldNumber = 36;

		[Cpp2IlInjected.Token(Token = "0x40025B9")]
		private static readonly MapField<int, DesignMap>.Codec _map_maleClothingDesigns_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40025BA")]
		private readonly MapField<int, DesignMap> maleClothingDesigns_;

		[Cpp2IlInjected.Token(Token = "0x40025BB")]
		public const int NextClothingDesignIDFieldNumber = 37;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40025BC")]
		private int nextClothingDesignID_;

		[Cpp2IlInjected.Token(Token = "0x40025BD")]
		public const int ClothingDesignLimitReachedCountFieldNumber = 38;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40025BE")]
		private int clothingDesignLimitReachedCount_;

		[Cpp2IlInjected.Token(Token = "0x40025BF")]
		public const int MemoryShardsFieldNumber = 39;

		[Cpp2IlInjected.Token(Token = "0x40025C0")]
		private static readonly MapField<int, int>.Codec _map_memoryShards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40025C1")]
		private readonly MapField<int, int> memoryShards_;

		[Cpp2IlInjected.Token(Token = "0x40025C2")]
		public const int RandomMasterSeedFieldNumber = 40;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40025C3")]
		private int randomMasterSeed_;

		[Cpp2IlInjected.Token(Token = "0x40025C4")]
		public const int RandomSeedsFieldNumber = 41;

		[Cpp2IlInjected.Token(Token = "0x40025C5")]
		private static readonly MapField<string, int>.Codec _map_randomSeeds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40025C6")]
		private readonly MapField<string, int> randomSeeds_;

		[Cpp2IlInjected.Token(Token = "0x40025C7")]
		public const int DebugTimeSkippedOnlineFieldNumber = 42;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40025C8")]
		private Duration debugTimeSkippedOnline_;

		[Cpp2IlInjected.Token(Token = "0x40025C9")]
		public const int DebugTimeSkippedFieldNumber = 43;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40025CA")]
		private Duration debugTimeSkipped_;

		[Cpp2IlInjected.Token(Token = "0x40025CB")]
		public const int LimitedActionsFieldNumber = 44;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40025CC")]
		private ProfileLimits limitedActions_;

		[Cpp2IlInjected.Token(Token = "0x40025CD")]
		public const int ActivityBonusRewardFieldNumber = 45;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40025CE")]
		private ActivityBonusReward activityBonusReward_;

		[Cpp2IlInjected.Token(Token = "0x40025CF")]
		public const int MaxFTUEPlayerLevelFieldNumber = 46;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40025D0")]
		private int maxFTUEPlayerLevel_;

		[Cpp2IlInjected.Token(Token = "0x40025D1")]
		public const int CurrentFtueEventFieldNumber = 47;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40025D2")]
		private int currentFtueEvent_;

		[Cpp2IlInjected.Token(Token = "0x40025D3")]
		public const int CompletedFtueEventsFieldNumber = 48;

		[Cpp2IlInjected.Token(Token = "0x40025D4")]
		private static readonly FieldCodec<int> _repeated_completedFtueEvents_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40025D5")]
		private readonly RepeatedField<int> completedFtueEvents_;

		[Cpp2IlInjected.Token(Token = "0x40025D6")]
		public const int TimePlayedInMinutesFieldNumber = 49;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40025D7")]
		private int timePlayedInMinutes_;

		[Cpp2IlInjected.Token(Token = "0x40025D8")]
		public const int HudApparitionFieldNumber = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x40025D9")]
		private uint hudApparition_;

		[Cpp2IlInjected.Token(Token = "0x40025DA")]
		public const int InboxFieldNumber = 70;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40025DB")]
		private Inbox inbox_;

		[Cpp2IlInjected.Token(Token = "0x40025DC")]
		public const int TrackingDataFieldNumber = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40025DD")]
		private TrackingData trackingData_;

		[Cpp2IlInjected.Token(Token = "0x40025DE")]
		public const int PhonePromptEventFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40025DF")]
		private PhonePromptEventData phonePromptEvent_;

		[Cpp2IlInjected.Token(Token = "0x40025E0")]
		public const int TimestampsFieldNumber = 110;

		[Cpp2IlInjected.Token(Token = "0x40025E1")]
		private static readonly MapField<string, Timestamp>.Codec _map_timestamps_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40025E2")]
		private readonly MapField<string, Timestamp> timestamps_;

		[Cpp2IlInjected.Token(Token = "0x40025E3")]
		public const int OnlineShopStatesFieldNumber = 200;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40025E4")]
		private OnlineShopStatesData onlineShopStates_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40025E5")]
		private ManaData cachedManaData;

		[Cpp2IlInjected.Token(Token = "0x40025E6")]
		public const uint ContainerInventoryBackpackId = 0u;

		[Cpp2IlInjected.Token(Token = "0x40025E7")]
		public const uint ContainerInventoryHomeStorageId = 1u;

		[Cpp2IlInjected.Token(Token = "0x40025E8")]
		public const uint ListInventoryCatalogId = 0u;

		[Cpp2IlInjected.Token(Token = "0x40025E9")]
		public const uint ListInventoryWardrobeId = 1u;

		[Cpp2IlInjected.Token(Token = "0x40025EA")]
		public const uint ListInventoryPantryId = 2u;

		[Cpp2IlInjected.Token(Token = "0x40025EB")]
		public const uint ListInventoryMakeupId = 3u;

		[Cpp2IlInjected.Token(Token = "0x40025EC")]
		public const uint ListInventoryTrimmingId = 4u;

		[Cpp2IlInjected.Token(Token = "0x40025ED")]
		public const uint ListInventoryBuildingId = 5u;

		[Cpp2IlInjected.Token(Token = "0x40025EE")]
		public const uint ListInventoryDecalId = 6u;

		[Cpp2IlInjected.Token(Token = "0x40025EF")]
		public const uint ListInventorySkinId = 7u;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40025F0")]
		private readonly List<uint> orphanedContainerInventories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40025F1")]
		private List<Buff> TransientBuffs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40025F3")]
		private PlayerInfo cachedPlayerInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40025F4")]
		private List<CollectionInfo> _collectionInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40025F5")]
		private IEnumerable<StaticBuffData> CachedStaticBuffData;

		[Cpp2IlInjected.Token(Token = "0x17000DBE")]
		[DebuggerNonUserCode]
		public static MessageParser<ProfilePlayer> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600501C")]
			[Cpp2IlInjected.Address(RVA = "0x976170", Offset = "0x974B70", VA = "0x180976170")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600501D")]
			[Cpp2IlInjected.Address(RVA = "0x975E40", Offset = "0x974840", VA = "0x180975E40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600501E")]
			[Cpp2IlInjected.Address(RVA = "0x976410", Offset = "0x974E10", VA = "0x180976410", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC1")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6005023")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005024")]
			[Cpp2IlInjected.Address(RVA = "0x976610", Offset = "0x975010", VA = "0x180976610")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC2")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6005025")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "17")]
			get
			{
				return level_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005026")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				level_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC3")]
		[DebuggerNonUserCode]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x6005027")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return xp_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005028")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				xp_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC4")]
		[DebuggerNonUserCode]
		public MapField<uint, ContainerInventory> ContainerInventories
		{
			[Cpp2IlInjected.Token(Token = "0x6005029")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return containerInventories_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC5")]
		[DebuggerNonUserCode]
		public uint NextContainerInventoryID
		{
			[Cpp2IlInjected.Token(Token = "0x600502A")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return nextContainerInventoryID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600502B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				nextContainerInventoryID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC6")]
		[DebuggerNonUserCode]
		public MapField<uint, ListInventory> ListInventories
		{
			[Cpp2IlInjected.Token(Token = "0x600502C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return listInventories_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC7")]
		[DebuggerNonUserCode]
		public uint NextListInventoryID
		{
			[Cpp2IlInjected.Token(Token = "0x600502D")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return nextListInventoryID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600502E")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				nextListInventoryID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC8")]
		[DebuggerNonUserCode]
		public MapField<int, int> CurrencyAmounts
		{
			[Cpp2IlInjected.Token(Token = "0x600502F")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return currencyAmounts_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC9")]
		[DebuggerNonUserCode]
		public RepeatedField<ToolInfo> Tools
		{
			[Cpp2IlInjected.Token(Token = "0x6005030")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return tools_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCA")]
		[DebuggerNonUserCode]
		public int Mana
		{
			[Cpp2IlInjected.Token(Token = "0x6005031")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return mana_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005032")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				mana_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCB")]
		[DebuggerNonUserCode]
		public bool ManaHasAlreadyMissed
		{
			[Cpp2IlInjected.Token(Token = "0x6005033")]
			[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0")]
			get
			{
				return manaHasAlreadyMissed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005034")]
			[Cpp2IlInjected.Address(RVA = "0x9765E0", Offset = "0x974FE0", VA = "0x1809765E0")]
			set
			{
				manaHasAlreadyMissed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCC")]
		[DebuggerNonUserCode]
		public Avatar FemaleAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6005035")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return femaleAvatar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005036")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				femaleAvatar_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCD")]
		[DebuggerNonUserCode]
		public Avatar MaleAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6005037")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return maleAvatar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005038")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				maleAvatar_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCE")]
		[DebuggerNonUserCode]
		public bool AvatarIsMale
		{
			[Cpp2IlInjected.Token(Token = "0x6005039")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get
			{
				return avatarIsMale_;
			}
			[Cpp2IlInjected.Token(Token = "0x600503A")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530")]
			set
			{
				avatarIsMale_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCF")]
		[DebuggerNonUserCode]
		public bool TransferDone
		{
			[Cpp2IlInjected.Token(Token = "0x600503B")]
			[Cpp2IlInjected.Address(RVA = "0x976360", Offset = "0x974D60", VA = "0x180976360")]
			get
			{
				return transferDone_;
			}
			[Cpp2IlInjected.Token(Token = "0x600503C")]
			[Cpp2IlInjected.Address(RVA = "0x9766D0", Offset = "0x9750D0", VA = "0x1809766D0")]
			set
			{
				transferDone_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD0")]
		[DebuggerNonUserCode]
		public Cookbook Cookbook
		{
			[Cpp2IlInjected.Token(Token = "0x600503D")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return cookbook_;
			}
			[Cpp2IlInjected.Token(Token = "0x600503E")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			set
			{
				cookbook_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD1")]
		[DebuggerNonUserCode]
		public RepeatedField<CookingHistory> CookingHistory
		{
			[Cpp2IlInjected.Token(Token = "0x600503F")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return cookingHistory_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD2")]
		[DebuggerNonUserCode]
		public RepeatedField<int> UnlockedCraftingRecipes
		{
			[Cpp2IlInjected.Token(Token = "0x6005040")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return unlockedCraftingRecipes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD3")]
		[DebuggerNonUserCode]
		public RepeatedField<Buff> Buffs
		{
			[Cpp2IlInjected.Token(Token = "0x6005041")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return buffs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD4")]
		[DebuggerNonUserCode]
		public RepeatedField<Pet> Pets
		{
			[Cpp2IlInjected.Token(Token = "0x6005042")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return pets_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD5")]
		[DebuggerNonUserCode]
		public int CurrentPet
		{
			[Cpp2IlInjected.Token(Token = "0x6005043")]
			[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
			get
			{
				return currentPet_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005044")]
			[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x974F80", VA = "0x180976580")]
			set
			{
				currentPet_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD6")]
		[DebuggerNonUserCode]
		public MapField<int, FishRecord> FishRecords
		{
			[Cpp2IlInjected.Token(Token = "0x6005045")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return fishRecords_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD7")]
		[DebuggerNonUserCode]
		public MapField<int, DutyList> DutySlots
		{
			[Cpp2IlInjected.Token(Token = "0x6005046")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return dutySlots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD8")]
		[DebuggerNonUserCode]
		public RoyalDutyProgress RoyalDutyProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6005047")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return royalDutyProgress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005048")]
			[Cpp2IlInjected.Address(RVA = "0x9766B0", Offset = "0x9750B0", VA = "0x1809766B0")]
			set
			{
				royalDutyProgress_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD9")]
		[DebuggerNonUserCode]
		public RepeatedField<CollectionSet> CollectionSets
		{
			[Cpp2IlInjected.Token(Token = "0x6005049")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return collectionSets_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDA")]
		[DebuggerNonUserCode]
		public RepeatedField<AchievementData> AchievementsData
		{
			[Cpp2IlInjected.Token(Token = "0x600504A")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get
			{
				return achievementsData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDB")]
		[DebuggerNonUserCode]
		public MiniEventStatesData MiniEventStates
		{
			[Cpp2IlInjected.Token(Token = "0x600504B")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			get
			{
				return miniEventStates_;
			}
			[Cpp2IlInjected.Token(Token = "0x600504C")]
			[Cpp2IlInjected.Address(RVA = "0x976600", Offset = "0x975000", VA = "0x180976600")]
			set
			{
				miniEventStates_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDC")]
		[DebuggerNonUserCode]
		public MegaEventProgress MegaEventProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600504D")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			get
			{
				return megaEventProgress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600504E")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			set
			{
				megaEventProgress_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDD")]
		[DebuggerNonUserCode]
		public CampaignHistoryData CampaignHistory
		{
			[Cpp2IlInjected.Token(Token = "0x600504F")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get
			{
				return campaignHistory_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005050")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			set
			{
				campaignHistory_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDE")]
		[DebuggerNonUserCode]
		public BattlePassStatesData BattlePassStates
		{
			[Cpp2IlInjected.Token(Token = "0x6005051")]
			[Cpp2IlInjected.Address(RVA = "0x7393C0", Offset = "0x737DC0", VA = "0x1807393C0")]
			get
			{
				return battlePassStates_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005052")]
			[Cpp2IlInjected.Address(RVA = "0x976540", Offset = "0x974F40", VA = "0x180976540")]
			set
			{
				battlePassStates_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDF")]
		[DebuggerNonUserCode]
		public MapField<int, DesignMap> FurnitureDesigns
		{
			[Cpp2IlInjected.Token(Token = "0x6005053")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
			get
			{
				return furnitureDesigns_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE0")]
		[DebuggerNonUserCode]
		public MapField<int, Furniture> FurnitureData
		{
			[Cpp2IlInjected.Token(Token = "0x6005054")]
			[Cpp2IlInjected.Address(RVA = "0x7389F0", Offset = "0x7373F0", VA = "0x1807389F0")]
			get
			{
				return furnitureData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE1")]
		[DebuggerNonUserCode]
		public int NextFurnitureDesignID
		{
			[Cpp2IlInjected.Token(Token = "0x6005055")]
			[Cpp2IlInjected.Address(RVA = "0x976100", Offset = "0x974B00", VA = "0x180976100")]
			get
			{
				return nextFurnitureDesignID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005056")]
			[Cpp2IlInjected.Address(RVA = "0x976690", Offset = "0x975090", VA = "0x180976690")]
			set
			{
				nextFurnitureDesignID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE2")]
		[DebuggerNonUserCode]
		public MapField<int, DesignMap> FemaleClothingDesigns
		{
			[Cpp2IlInjected.Token(Token = "0x6005057")]
			[Cpp2IlInjected.Address(RVA = "0x738AB0", Offset = "0x7374B0", VA = "0x180738AB0")]
			get
			{
				return femaleClothingDesigns_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE3")]
		[DebuggerNonUserCode]
		public MapField<int, DesignMap> MaleClothingDesigns
		{
			[Cpp2IlInjected.Token(Token = "0x6005058")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			get
			{
				return maleClothingDesigns_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE4")]
		[DebuggerNonUserCode]
		public int NextClothingDesignID
		{
			[Cpp2IlInjected.Token(Token = "0x6005059")]
			[Cpp2IlInjected.Address(RVA = "0x9760F0", Offset = "0x974AF0", VA = "0x1809760F0")]
			get
			{
				return nextClothingDesignID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600505A")]
			[Cpp2IlInjected.Address(RVA = "0x976680", Offset = "0x975080", VA = "0x180976680")]
			set
			{
				nextClothingDesignID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE5")]
		[DebuggerNonUserCode]
		public int ClothingDesignLimitReachedCount
		{
			[Cpp2IlInjected.Token(Token = "0x600505B")]
			[Cpp2IlInjected.Address(RVA = "0x975D90", Offset = "0x974790", VA = "0x180975D90")]
			get
			{
				return clothingDesignLimitReachedCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600505C")]
			[Cpp2IlInjected.Address(RVA = "0x976560", Offset = "0x974F60", VA = "0x180976560")]
			set
			{
				clothingDesignLimitReachedCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE6")]
		[DebuggerNonUserCode]
		public MapField<int, int> MemoryShards
		{
			[Cpp2IlInjected.Token(Token = "0x600505D")]
			[Cpp2IlInjected.Address(RVA = "0x9760E0", Offset = "0x974AE0", VA = "0x1809760E0", Slot = "18")]
			get
			{
				return memoryShards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE7")]
		[DebuggerNonUserCode]
		public int RandomMasterSeed
		{
			[Cpp2IlInjected.Token(Token = "0x600505E")]
			[Cpp2IlInjected.Address(RVA = "0x9762D0", Offset = "0x974CD0", VA = "0x1809762D0")]
			get
			{
				return randomMasterSeed_;
			}
			[Cpp2IlInjected.Token(Token = "0x600505F")]
			[Cpp2IlInjected.Address(RVA = "0x9766A0", Offset = "0x9750A0", VA = "0x1809766A0")]
			set
			{
				randomMasterSeed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE8")]
		[DebuggerNonUserCode]
		public MapField<string, int> RandomSeeds
		{
			[Cpp2IlInjected.Token(Token = "0x6005060")]
			[Cpp2IlInjected.Address(RVA = "0x9762E0", Offset = "0x974CE0", VA = "0x1809762E0")]
			get
			{
				return randomSeeds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DE9")]
		[DebuggerNonUserCode]
		public Duration DebugTimeSkippedOnline
		{
			[Cpp2IlInjected.Token(Token = "0x6005061")]
			[Cpp2IlInjected.Address(RVA = "0x975DD0", Offset = "0x9747D0", VA = "0x180975DD0")]
			get
			{
				return debugTimeSkippedOnline_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005062")]
			[Cpp2IlInjected.Address(RVA = "0x9765A0", Offset = "0x974FA0", VA = "0x1809765A0")]
			set
			{
				debugTimeSkippedOnline_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEA")]
		[DebuggerNonUserCode]
		public Duration DebugTimeSkipped
		{
			[Cpp2IlInjected.Token(Token = "0x6005063")]
			[Cpp2IlInjected.Address(RVA = "0x975DE0", Offset = "0x9747E0", VA = "0x180975DE0")]
			get
			{
				return debugTimeSkipped_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005064")]
			[Cpp2IlInjected.Address(RVA = "0x9765B0", Offset = "0x974FB0", VA = "0x1809765B0")]
			set
			{
				debugTimeSkipped_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEB")]
		[DebuggerNonUserCode]
		public ProfileLimits LimitedActions
		{
			[Cpp2IlInjected.Token(Token = "0x6005065")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			get
			{
				return limitedActions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005066")]
			[Cpp2IlInjected.Address(RVA = "0x9765D0", Offset = "0x974FD0", VA = "0x1809765D0")]
			set
			{
				limitedActions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEC")]
		[DebuggerNonUserCode]
		public ActivityBonusReward ActivityBonusReward
		{
			[Cpp2IlInjected.Token(Token = "0x6005067")]
			[Cpp2IlInjected.Address(RVA = "0x975C80", Offset = "0x974680", VA = "0x180975C80")]
			get
			{
				return activityBonusReward_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005068")]
			[Cpp2IlInjected.Address(RVA = "0x976520", Offset = "0x974F20", VA = "0x180976520")]
			set
			{
				activityBonusReward_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DED")]
		[DebuggerNonUserCode]
		public int MaxFTUEPlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005069")]
			[Cpp2IlInjected.Address(RVA = "0x9760D0", Offset = "0x974AD0", VA = "0x1809760D0")]
			get
			{
				return maxFTUEPlayerLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x600506A")]
			[Cpp2IlInjected.Address(RVA = "0x9765F0", Offset = "0x974FF0", VA = "0x1809765F0")]
			set
			{
				maxFTUEPlayerLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEE")]
		[DebuggerNonUserCode]
		public int CurrentFtueEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600506B")]
			[Cpp2IlInjected.Address(RVA = "0x975DA0", Offset = "0x9747A0", VA = "0x180975DA0")]
			get
			{
				return currentFtueEvent_;
			}
			[Cpp2IlInjected.Token(Token = "0x600506C")]
			[Cpp2IlInjected.Address(RVA = "0x976570", Offset = "0x974F70", VA = "0x180976570")]
			set
			{
				currentFtueEvent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEF")]
		[DebuggerNonUserCode]
		public RepeatedField<int> CompletedFtueEvents
		{
			[Cpp2IlInjected.Token(Token = "0x600506D")]
			[Cpp2IlInjected.Address(RVA = "0x738EC0", Offset = "0x7378C0", VA = "0x180738EC0")]
			get
			{
				return completedFtueEvents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF0")]
		[DebuggerNonUserCode]
		public int TimePlayedInMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x600506E")]
			[Cpp2IlInjected.Address(RVA = "0x976340", Offset = "0x974D40", VA = "0x180976340")]
			get
			{
				return timePlayedInMinutes_;
			}
			[Cpp2IlInjected.Token(Token = "0x600506F")]
			[Cpp2IlInjected.Address(RVA = "0x9766C0", Offset = "0x9750C0", VA = "0x1809766C0")]
			set
			{
				timePlayedInMinutes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF1")]
		[DebuggerNonUserCode]
		public uint HudApparition
		{
			[Cpp2IlInjected.Token(Token = "0x6005070")]
			[Cpp2IlInjected.Address(RVA = "0x975F70", Offset = "0x974970", VA = "0x180975F70")]
			get
			{
				return hudApparition_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005071")]
			[Cpp2IlInjected.Address(RVA = "0x9765C0", Offset = "0x974FC0", VA = "0x1809765C0")]
			set
			{
				hudApparition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF2")]
		[DebuggerNonUserCode]
		public Inbox Inbox
		{
			[Cpp2IlInjected.Token(Token = "0x6005072")]
			[Cpp2IlInjected.Address(RVA = "0x739220", Offset = "0x737C20", VA = "0x180739220")]
			get
			{
				return inbox_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005073")]
			[Cpp2IlInjected.Address(RVA = "0x73A350", Offset = "0x738D50", VA = "0x18073A350")]
			set
			{
				inbox_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF3")]
		[DebuggerNonUserCode]
		public TrackingData TrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6005074")]
			[Cpp2IlInjected.Address(RVA = "0x739280", Offset = "0x737C80", VA = "0x180739280")]
			get
			{
				return trackingData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005075")]
			[Cpp2IlInjected.Address(RVA = "0x73A360", Offset = "0x738D60", VA = "0x18073A360")]
			set
			{
				trackingData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF4")]
		[DebuggerNonUserCode]
		public PhonePromptEventData PhonePromptEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6005076")]
			[Cpp2IlInjected.Address(RVA = "0x738AD0", Offset = "0x7374D0", VA = "0x180738AD0")]
			get
			{
				return phonePromptEvent_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005077")]
			[Cpp2IlInjected.Address(RVA = "0x739E70", Offset = "0x738870", VA = "0x180739E70")]
			set
			{
				phonePromptEvent_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF5")]
		[DebuggerNonUserCode]
		public MapField<string, Timestamp> Timestamps
		{
			[Cpp2IlInjected.Token(Token = "0x6005078")]
			[Cpp2IlInjected.Address(RVA = "0x976350", Offset = "0x974D50", VA = "0x180976350")]
			get
			{
				return timestamps_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF6")]
		[DebuggerNonUserCode]
		public OnlineShopStatesData OnlineShopStates
		{
			[Cpp2IlInjected.Token(Token = "0x6005079")]
			[Cpp2IlInjected.Address(RVA = "0x738EB0", Offset = "0x7378B0", VA = "0x180738EB0")]
			get
			{
				return onlineShopStates_;
			}
			[Cpp2IlInjected.Token(Token = "0x600507A")]
			[Cpp2IlInjected.Address(RVA = "0x739EA0", Offset = "0x7388A0", VA = "0x180739EA0")]
			set
			{
				onlineShopStates_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF7")]
		public ManaData ManaData
		{
			[Cpp2IlInjected.Token(Token = "0x6005088")]
			[Cpp2IlInjected.Address(RVA = "0x975FD0", Offset = "0x9749D0", VA = "0x180975FD0")]
			get
			{
				//Discarded unreachable code: IL_0013
				ManaData manaData = cachedManaData;
				if (manaData == null)
				{
					ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				}
				return manaData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF8")]
		public ContainerInventory Backpack
		{
			[Cpp2IlInjected.Token(Token = "0x60050AA")]
			[Cpp2IlInjected.Address(RVA = "0x975CA0", Offset = "0x9746A0", VA = "0x180975CA0")]
			get
			{
				//Discarded unreachable code: IL_0011
				//IL_0010: Expected O, but got I4
				MapField<uint, ContainerInventory> mapField = containerInventories_;
				int num = 0;
				return (ContainerInventory)((MapField<TKey, TValue>)(object)mapField)[(TKey)num];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF9")]
		public ContainerInventory HomeStorage
		{
			[Cpp2IlInjected.Token(Token = "0x60050AB")]
			[Cpp2IlInjected.Address(RVA = "0x975F20", Offset = "0x974920", VA = "0x180975F20")]
			get
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				return (ContainerInventory)((MapField<TKey, TValue>)(object)containerInventories_)[(TKey)1];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFA")]
		public ListInventory Catalog
		{
			[Cpp2IlInjected.Token(Token = "0x60050AC")]
			[Cpp2IlInjected.Address(RVA = "0x975D40", Offset = "0x974740", VA = "0x180975D40")]
			get
			{
				//Discarded unreachable code: IL_0011
				//IL_0010: Expected O, but got I4
				MapField<uint, ListInventory> mapField = listInventories_;
				int num = 0;
				return (ListInventory)((MapField<TKey, TValue>)(object)mapField)[(TKey)num];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFB")]
		public ListInventory Wardrobe
		{
			[Cpp2IlInjected.Token(Token = "0x60050AD")]
			[Cpp2IlInjected.Address(RVA = "0x9763C0", Offset = "0x974DC0", VA = "0x1809763C0")]
			get
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				return (ListInventory)((MapField<TKey, TValue>)(object)listInventories_)[(TKey)1];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFC")]
		public ListInventory Pantry
		{
			[Cpp2IlInjected.Token(Token = "0x60050AE")]
			[Cpp2IlInjected.Address(RVA = "0x976120", Offset = "0x974B20", VA = "0x180976120")]
			get
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				return (ListInventory)((MapField<TKey, TValue>)(object)listInventories_)[(TKey)2];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFD")]
		public ListInventory Makeup
		{
			[Cpp2IlInjected.Token(Token = "0x60050AF")]
			[Cpp2IlInjected.Address(RVA = "0x975F80", Offset = "0x974980", VA = "0x180975F80")]
			get
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				return (ListInventory)((MapField<TKey, TValue>)(object)listInventories_)[(TKey)3];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFE")]
		public ListInventory Trimming
		{
			[Cpp2IlInjected.Token(Token = "0x60050B0")]
			[Cpp2IlInjected.Address(RVA = "0x976370", Offset = "0x974D70", VA = "0x180976370")]
			get
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				return (ListInventory)((MapField<TKey, TValue>)(object)listInventories_)[(TKey)4];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFF")]
		public ListInventory Buildings
		{
			[Cpp2IlInjected.Token(Token = "0x60050B1")]
			[Cpp2IlInjected.Address(RVA = "0x975CF0", Offset = "0x9746F0", VA = "0x180975CF0")]
			get
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				return (ListInventory)((MapField<TKey, TValue>)(object)listInventories_)[(TKey)5];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E00")]
		public ListInventory Decals
		{
			[Cpp2IlInjected.Token(Token = "0x60050B2")]
			[Cpp2IlInjected.Address(RVA = "0x975DF0", Offset = "0x9747F0", VA = "0x180975DF0")]
			get
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				return (ListInventory)((MapField<TKey, TValue>)(object)listInventories_)[(TKey)6];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E01")]
		public ListInventory Skins
		{
			[Cpp2IlInjected.Token(Token = "0x60050B3")]
			[Cpp2IlInjected.Address(RVA = "0x9762F0", Offset = "0x974CF0", VA = "0x1809762F0")]
			get
			{
				//Discarded unreachable code: IL_000e
				//IL_000d: Expected O, but got I4
				return (ListInventory)((MapField<TKey, TValue>)(object)listInventories_)[(TKey)7];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E02")]
		public DateTime NowUtc
		{
			[Cpp2IlInjected.Token(Token = "0x60050B4")]
			[Cpp2IlInjected.Address(RVA = "0x976110", Offset = "0x974B10", VA = "0x180976110")]
			get
			{
				return ServerUtil.NowUtc(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E03")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1B0"), Cpp2IlInjected.Token(Token = "0x40025F2")]
		public Item CurrentScene
		{
			[Cpp2IlInjected.Token(Token = "0x60050B5")]
			[Cpp2IlInjected.Address(RVA = "0x975DC0", Offset = "0x9747C0", VA = "0x180975DC0", Slot = "28")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60050B6")]
			[Cpp2IlInjected.Address(RVA = "0x976590", Offset = "0x974F90", VA = "0x180976590")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E04")]
		public PlayerInfo PlayerInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60050B7")]
			[Cpp2IlInjected.Address(RVA = "0x9761D0", Offset = "0x974BD0", VA = "0x1809761D0")]
			get
			{
				//Discarded unreachable code: IL_001e
				if ((long)cachedPlayerInfo == 0)
				{
					ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
					bool flag = default(bool);
					if (!flag)
					{
						int num = 0;
					}
				}
				return cachedPlayerInfo;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E05")]
		public Avatar ActiveAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x60050D4")]
			[Cpp2IlInjected.Address(RVA = "0x975C70", Offset = "0x974670", VA = "0x180975C70")]
			get
			{
				if ((long)_map_furnitureData_codec != 0)
				{
					return maleAvatar_;
				}
				return femaleAvatar_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600501F")]
		[Cpp2IlInjected.Address(RVA = "0x974E10", Offset = "0x973810", VA = "0x180974E10")]
		[DebuggerNonUserCode]
		public ProfilePlayer()
		{
			name_ = "";
			containerInventories_ = (MapField<uint, ContainerInventory>)(object)new MapField<TKey, TValue>();
			listInventories_ = (MapField<uint, ListInventory>)(object)new MapField<TKey, TValue>();
			currencyAmounts_ = (MapField<int, int>)(object)new MapField<TKey, TValue>();
			tools_ = (RepeatedField<ToolInfo>)(object)new RepeatedField<T>();
			cookingHistory_ = (RepeatedField<CookingHistory>)(object)new RepeatedField<T>();
			unlockedCraftingRecipes_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			buffs_ = (RepeatedField<Buff>)(object)new RepeatedField<T>();
			pets_ = (RepeatedField<Pet>)(object)new RepeatedField<T>();
			fishRecords_ = (MapField<int, FishRecord>)(object)new MapField<TKey, TValue>();
			dutySlots_ = (MapField<int, DutyList>)(object)new MapField<TKey, TValue>();
			collectionSets_ = (RepeatedField<CollectionSet>)(object)new RepeatedField<T>();
			achievementsData_ = (RepeatedField<AchievementData>)(object)new RepeatedField<T>();
			furnitureDesigns_ = (MapField<int, DesignMap>)(object)new MapField<TKey, TValue>();
			furnitureData_ = (MapField<int, Furniture>)(object)new MapField<TKey, TValue>();
			femaleClothingDesigns_ = (MapField<int, DesignMap>)(object)new MapField<TKey, TValue>();
			maleClothingDesigns_ = (MapField<int, DesignMap>)(object)new MapField<TKey, TValue>();
			memoryShards_ = (MapField<int, int>)(object)new MapField<TKey, TValue>();
			randomSeeds_ = (MapField<string, int>)(object)new MapField<TKey, TValue>();
			completedFtueEvents_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			timestamps_ = (MapField<string, Timestamp>)(object)new MapField<TKey, TValue>();
			orphanedContainerInventories = (List<uint>)(object)new List<T>();
			TransientBuffs = (List<Buff>)(object)new List<T>();
			base._002Ector();
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6005020")]
		[Cpp2IlInjected.Address(RVA = "0x96EA90", Offset = "0x96D490", VA = "0x18096EA90")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			//IL_004e: Expected I4, but got I8
			//IL_0059: Expected I4, but got I8
			//IL_006f: Expected O, but got I4
			//IL_0080: Expected I4, but got I8
			//IL_008f: Expected O, but got I4
			//IL_0098: Expected I4, but got I8
			//IL_00a9: Expected I4, but got I8
			//IL_00b3: Expected I4, but got I8
			//IL_00cf: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_00eb: Expected O, but got I4
			//IL_00f9: Expected O, but got I4
			//IL_0107: Expected O, but got I4
			//IL_0115: Expected O, but got I4
			//IL_013a: Expected O, but got I4
			//IL_014b: Expected I4, but got I8
			//IL_0155: Expected I4, but got I8
			//IL_0164: Expected O, but got I4
			//IL_0175: Expected I4, but got I8
			//IL_017f: Expected I4, but got I8
			//IL_018e: Expected O, but got I4
			//IL_019f: Expected I4, but got I8
			//IL_01aa: Expected I4, but got I8
			//IL_01b9: Expected O, but got I4
			//IL_01ca: Expected I4, but got I8
			//IL_01d5: Expected I4, but got I8
			//IL_01e4: Expected O, but got I4
			//IL_01f5: Expected I4, but got I8
			//IL_01ff: Expected I4, but got I8
			//IL_020e: Expected O, but got I4
			//IL_021f: Expected I4, but got I8
			//IL_022a: Expected I4, but got I8
			//IL_0239: Expected O, but got I4
			//IL_024a: Expected I4, but got I8
			//IL_0255: Expected I4, but got I8
			//IL_0264: Expected O, but got I4
			//IL_026d: Expected I4, but got I8
			//IL_02ee: Expected I4, but got I8
			level_ = 1;
			CampaignHistoryData campaignHistoryData = (campaignHistory_ = new CampaignHistoryData());
			MiniEventStatesData miniEventStatesData = (miniEventStates_ = new MiniEventStatesData());
			BattlePassStatesData battlePassStatesData = (battlePassStates_ = new BattlePassStatesData());
			OnlineShopStatesData onlineShopStatesData = (onlineShopStates_ = new OnlineShopStatesData());
			ContainerInventory containerInventory = new ContainerInventory();
			containerInventory.iD_ = 0u;
			containerInventory.size_ = 12;
			MapField<uint, ContainerInventory> mapField = containerInventories_;
			int num = 0;
			((MapField<TKey, TValue>)(object)mapField).Add((TKey)num, (TValue)containerInventory);
			ContainerInventory containerInventory2 = new ContainerInventory();
			containerInventory2.iD_ = 1u;
			((MapField<TKey, TValue>)(object)containerInventories_).Add((TKey)1, (TValue)containerInventory2);
			nextContainerInventoryID_ = 2u;
			ListInventory listInventory = new ListInventory();
			listInventory.iD_ = 0u;
			listInventory.compatibleItemType_ = ItemType.Furniture;
			ListInventory.Types.FurnitureRestrictionList furnitureRestrictionList = new ListInventory.Types.FurnitureRestrictionList();
			RepeatedField<FurnitureItemType> list_ = furnitureRestrictionList.list_;
			int num2 = 0;
			((RepeatedField<T>)(object)list_).Add((T)num2);
			((RepeatedField<T>)(object)furnitureRestrictionList.list_).Add((T)1);
			((RepeatedField<T>)(object)furnitureRestrictionList.list_).Add((T)3);
			((RepeatedField<T>)(object)furnitureRestrictionList.list_).Add((T)5);
			((RepeatedField<T>)(object)furnitureRestrictionList.list_).Add((T)6);
			((RepeatedField<T>)(object)furnitureRestrictionList.list_).Add((T)7);
			listInventory.CompatibleFurnitureTypes = furnitureRestrictionList;
			MapField<uint, ListInventory> mapField2 = listInventories_;
			uint iD_ = listInventory.iD_;
			((MapField<TKey, TValue>)(object)mapField2).Add((TKey)iD_, (TValue)listInventory);
			ListInventory listInventory2 = new ListInventory();
			listInventory2.iD_ = 1u;
			listInventory2.compatibleItemType_ = ItemType.Clothing;
			((MapField<TKey, TValue>)(object)listInventories_).Add((TKey)1, (TValue)listInventory2);
			ListInventory listInventory3 = new ListInventory();
			listInventory3.iD_ = 2u;
			listInventory3.compatibleItemType_ = ItemType.ActivityItem;
			((MapField<TKey, TValue>)(object)listInventories_).Add((TKey)2, (TValue)listInventory3);
			ListInventory listInventory4 = new ListInventory();
			listInventory4.iD_ = 3u;
			listInventory4.compatibleItemType_ = ItemType.Makeup;
			((MapField<TKey, TValue>)(object)listInventories_).Add((TKey)3, (TValue)listInventory4);
			ListInventory listInventory5 = new ListInventory();
			listInventory5.iD_ = 4u;
			listInventory5.compatibleItemType_ = ItemType.Trimming;
			((MapField<TKey, TValue>)(object)listInventories_).Add((TKey)4, (TValue)listInventory5);
			ListInventory listInventory6 = new ListInventory();
			listInventory6.iD_ = 5u;
			listInventory6.compatibleItemType_ = ItemType.Building;
			((MapField<TKey, TValue>)(object)listInventories_).Add((TKey)5, (TValue)listInventory6);
			ListInventory listInventory7 = new ListInventory();
			listInventory7.iD_ = 6u;
			listInventory7.compatibleItemType_ = ItemType.Decal;
			((MapField<TKey, TValue>)(object)listInventories_).Add((TKey)6, (TValue)listInventory7);
			ListInventory listInventory8 = new ListInventory();
			listInventory8.iD_ = 7u;
			listInventory8.compatibleItemType_ = ItemType.Skin;
			((MapField<TKey, TValue>)(object)listInventories_).Add((TKey)7, (TValue)listInventory8);
			nextListInventoryID_ = 8u;
			Avatar avatar = (femaleAvatar_ = new Avatar());
			Avatar avatar2 = (maleAvatar_ = new Avatar());
			Cookbook cookbook = (cookbook_ = new Cookbook());
			MegaEventProgress megaEventProgress = (megaEventProgress_ = new MegaEventProgress());
			PhonePromptEventData phonePromptEventData = (phonePromptEvent_ = new PhonePromptEventData());
			Duration duration = (debugTimeSkippedOnline_ = new Duration());
			Duration duration2 = (debugTimeSkipped_ = new Duration());
			ActivityBonusReward activityBonusReward = (activityBonusReward_ = new ActivityBonusReward());
			maxFTUEPlayerLevel_ = 5;
			Inbox inbox = (inbox_ = new Inbox());
			TrackingData trackingData = (trackingData_ = new TrackingData());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005021")]
		[Cpp2IlInjected.Address(RVA = "0x975440", Offset = "0x973E40", VA = "0x180975440")]
		[DebuggerNonUserCode]
		public ProfilePlayer(ProfilePlayer other)
		{
			//IL_00dd: Expected O, but got I4
			//IL_00fb: Expected O, but got I4
			//IL_0139: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			//IL_022d: Expected O, but got I4
			//IL_024b: Expected O, but got I4
			//IL_0269: Expected O, but got I4
			//IL_0287: Expected O, but got I4
			//IL_0363: Expected O, but got I4
			//IL_0381: Expected O, but got I4
			//IL_039f: Expected O, but got I4
			//IL_03bd: Expected O, but got I4
			//IL_0430: Expected O, but got I4
			//IL_044e: Expected O, but got I4
			//IL_046c: Expected O, but got I4
			string text = (name_ = other.name_);
			int num = (level_ = other.level_);
			int num2 = (xp_ = other.xp_);
			MapField<uint, ContainerInventory> mapField = (containerInventories_ = (MapField<uint, ContainerInventory>)(object)((MapField<TKey, TValue>)(object)other.containerInventories_).Clone());
			uint num3 = (nextContainerInventoryID_ = other.nextContainerInventoryID_);
			MapField<uint, ListInventory> mapField2 = (listInventories_ = (MapField<uint, ListInventory>)(object)((MapField<TKey, TValue>)(object)other.listInventories_).Clone());
			uint num4 = (nextListInventoryID_ = other.nextListInventoryID_);
			MapField<int, int> mapField3 = (currencyAmounts_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)other.currencyAmounts_).Clone());
			RepeatedField<ToolInfo> repeatedField = (tools_ = (RepeatedField<ToolInfo>)(object)((RepeatedField<T>)(object)other.tools_).Clone());
			int num5 = other.mana_;
			int num6 = 0;
			mana_ = num5;
			bool flag = (manaHasAlreadyMissed_ = other.manaHasAlreadyMissed_);
			Avatar avatar = other.femaleAvatar_;
			if (avatar != null)
			{
				Avatar avatar2 = avatar.Clone();
			}
			femaleAvatar_ = (Avatar)num6;
			Avatar avatar3 = other.maleAvatar_;
			if (avatar3 != null)
			{
				Avatar avatar4 = avatar3.Clone();
			}
			maleAvatar_ = (Avatar)num6;
			bool flag2 = (avatarIsMale_ = other.avatarIsMale_);
			bool flag3 = (transferDone_ = other.transferDone_);
			Cookbook cookbook = other.cookbook_;
			if (cookbook != null)
			{
				Cookbook cookbook2 = cookbook.Clone();
			}
			cookbook_ = (Cookbook)num6;
			RepeatedField<CookingHistory> repeatedField2 = (cookingHistory_ = (RepeatedField<CookingHistory>)(object)((RepeatedField<T>)(object)other.cookingHistory_).Clone());
			RepeatedField<int> repeatedField3 = (unlockedCraftingRecipes_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.unlockedCraftingRecipes_).Clone());
			RepeatedField<Buff> repeatedField4 = (buffs_ = (RepeatedField<Buff>)(object)((RepeatedField<T>)(object)other.buffs_).Clone());
			RepeatedField<Pet> repeatedField5 = (pets_ = (RepeatedField<Pet>)(object)((RepeatedField<T>)(object)other.pets_).Clone());
			int num7 = (currentPet_ = other.currentPet_);
			MapField<int, FishRecord> mapField4 = (fishRecords_ = (MapField<int, FishRecord>)(object)((MapField<TKey, TValue>)(object)other.fishRecords_).Clone());
			MapField<int, DutyList> mapField5 = (dutySlots_ = (MapField<int, DutyList>)(object)((MapField<TKey, TValue>)(object)other.dutySlots_).Clone());
			RoyalDutyProgress royalDutyProgress = other.royalDutyProgress_;
			if (royalDutyProgress != null)
			{
				RoyalDutyProgress royalDutyProgress2 = royalDutyProgress.Clone();
			}
			royalDutyProgress_ = (RoyalDutyProgress)num6;
			RepeatedField<CollectionSet> repeatedField6 = (collectionSets_ = (RepeatedField<CollectionSet>)(object)((RepeatedField<T>)(object)other.collectionSets_).Clone());
			RepeatedField<AchievementData> repeatedField7 = (achievementsData_ = (RepeatedField<AchievementData>)(object)((RepeatedField<T>)(object)other.achievementsData_).Clone());
			MiniEventStatesData miniEventStatesData = other.miniEventStates_;
			if (miniEventStatesData != null)
			{
				MiniEventStatesData miniEventStatesData2 = miniEventStatesData.Clone();
			}
			miniEventStates_ = (MiniEventStatesData)num6;
			MegaEventProgress megaEventProgress = other.megaEventProgress_;
			if (megaEventProgress != null)
			{
				MegaEventProgress megaEventProgress2 = megaEventProgress.Clone();
			}
			megaEventProgress_ = (MegaEventProgress)num6;
			CampaignHistoryData campaignHistoryData = other.campaignHistory_;
			if (campaignHistoryData != null)
			{
				CampaignHistoryData campaignHistoryData2 = campaignHistoryData.Clone();
			}
			campaignHistory_ = (CampaignHistoryData)num6;
			BattlePassStatesData battlePassStatesData = other.battlePassStates_;
			if (battlePassStatesData != null)
			{
				BattlePassStatesData battlePassStatesData2 = battlePassStatesData.Clone();
			}
			battlePassStates_ = (BattlePassStatesData)num6;
			MapField<int, DesignMap> mapField6 = (furnitureDesigns_ = (MapField<int, DesignMap>)(object)((MapField<TKey, TValue>)(object)other.furnitureDesigns_).Clone());
			MapField<int, Furniture> mapField7 = (furnitureData_ = (MapField<int, Furniture>)(object)((MapField<TKey, TValue>)(object)other.furnitureData_).Clone());
			int num8 = (nextFurnitureDesignID_ = other.nextFurnitureDesignID_);
			MapField<int, DesignMap> mapField8 = (femaleClothingDesigns_ = (MapField<int, DesignMap>)(object)((MapField<TKey, TValue>)(object)other.femaleClothingDesigns_).Clone());
			MapField<int, DesignMap> mapField9 = (maleClothingDesigns_ = (MapField<int, DesignMap>)(object)((MapField<TKey, TValue>)(object)other.maleClothingDesigns_).Clone());
			int num9 = (nextClothingDesignID_ = other.nextClothingDesignID_);
			int num10 = (clothingDesignLimitReachedCount_ = other.clothingDesignLimitReachedCount_);
			MapField<int, int> mapField10 = (memoryShards_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)other.memoryShards_).Clone());
			int num11 = (randomMasterSeed_ = other.randomMasterSeed_);
			MapField<string, int> mapField11 = (randomSeeds_ = (MapField<string, int>)(object)((MapField<TKey, TValue>)(object)other.randomSeeds_).Clone());
			Duration duration = other.debugTimeSkippedOnline_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			debugTimeSkippedOnline_ = (Duration)num6;
			Duration duration3 = other.debugTimeSkipped_;
			if (duration3 != null)
			{
				Duration duration4 = duration3.Clone();
			}
			debugTimeSkipped_ = (Duration)num6;
			ProfileLimits profileLimits = other.limitedActions_;
			if (profileLimits != null)
			{
				ProfileLimits profileLimits2 = new ProfileLimits(profileLimits);
			}
			limitedActions_ = (ProfileLimits)num6;
			ActivityBonusReward activityBonusReward = other.activityBonusReward_;
			if (activityBonusReward != null)
			{
				ActivityBonusReward activityBonusReward2 = activityBonusReward.Clone();
			}
			activityBonusReward_ = (ActivityBonusReward)num6;
			int num12 = (maxFTUEPlayerLevel_ = other.maxFTUEPlayerLevel_);
			int num13 = (currentFtueEvent_ = other.currentFtueEvent_);
			RepeatedField<int> repeatedField8 = (completedFtueEvents_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.completedFtueEvents_).Clone());
			int num14 = (timePlayedInMinutes_ = other.timePlayedInMinutes_);
			uint num15 = (hudApparition_ = other.hudApparition_);
			Inbox inbox = other.inbox_;
			if (inbox != null)
			{
				Inbox inbox2 = inbox.Clone();
			}
			inbox_ = (Inbox)num6;
			TrackingData trackingData = other.trackingData_;
			if (trackingData != null)
			{
				TrackingData trackingData2 = trackingData.Clone();
			}
			trackingData_ = (TrackingData)num6;
			PhonePromptEventData phonePromptEventData = other.phonePromptEvent_;
			if (phonePromptEventData != null)
			{
				PhonePromptEventData phonePromptEventData2 = phonePromptEventData.Clone();
			}
			phonePromptEvent_ = (PhonePromptEventData)num6;
			MapField<string, Timestamp> mapField12 = (timestamps_ = (MapField<string, Timestamp>)(object)((MapField<TKey, TValue>)(object)other.timestamps_).Clone());
			OnlineShopStatesData onlineShopStatesData = other.onlineShopStates_;
			OnlineShopStatesData onlineShopStatesData2 = default(OnlineShopStatesData);
			if (onlineShopStatesData != null)
			{
				onlineShopStatesData2 = onlineShopStatesData.Clone();
			}
			onlineShopStates_ = onlineShopStatesData2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005022")]
		[Cpp2IlInjected.Address(RVA = "0x9652A0", Offset = "0x963CA0", VA = "0x1809652A0", Slot = "10")]
		[DebuggerNonUserCode]
		public ProfilePlayer Clone()
		{
			return new ProfilePlayer(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600507B")]
		[Cpp2IlInjected.Address(RVA = "0x9657B0", Offset = "0x9641B0", VA = "0x1809657B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ProfilePlayer)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600507C")]
		[Cpp2IlInjected.Address(RVA = "0x965810", Offset = "0x964210", VA = "0x180965810", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProfilePlayer other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					int num = other.level_;
					if ((IntPtr)_repeated_tools_codec == (IntPtr)num)
					{
						int num2 = other.xp_;
						if (xp_ == num2)
						{
							MapField<uint, ContainerInventory> mapField = containerInventories_;
							MapField<uint, ContainerInventory> mapField2 = other.containerInventories_;
							if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
							{
								uint num3 = other.nextContainerInventoryID_;
								if (nextContainerInventoryID_ == num3)
								{
									MapField<uint, ListInventory> mapField3 = listInventories_;
									MapField<uint, ListInventory> mapField4 = other.listInventories_;
									if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
									{
										uint num4 = other.nextListInventoryID_;
										if ((IntPtr)_repeated_pets_codec == (IntPtr)(int)num4)
										{
											MapField<int, int> mapField5 = currencyAmounts_;
											MapField<int, int> mapField6 = other.currencyAmounts_;
											if (((MapField<TKey, TValue>)(object)mapField5).Equals((MapField<, >)(object)mapField6))
											{
												RepeatedField<ToolInfo> repeatedField = tools_;
												RepeatedField<ToolInfo> repeatedField2 = other.tools_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													int num5 = other.mana_;
													if ((IntPtr)_repeated_collectionSets_codec == (IntPtr)num5)
													{
														bool flag = other.manaHasAlreadyMissed_;
														if (manaHasAlreadyMissed_ == flag)
														{
															Avatar objB = other.femaleAvatar_;
															if (object.Equals(femaleAvatar_, objB))
															{
																Avatar objB2 = other.maleAvatar_;
																if (object.Equals(maleAvatar_, objB2))
																{
																	bool flag2 = other.avatarIsMale_;
																	if ((IntPtr)_map_furnitureData_codec == (IntPtr)(flag2 ? 1 : 0))
																	{
																		bool flag3 = other.transferDone_;
																		if (transferDone_ == flag3)
																		{
																			Cookbook objB3 = other.cookbook_;
																			if (object.Equals(cookbook_, objB3))
																			{
																				RepeatedField<CookingHistory> repeatedField3 = cookingHistory_;
																				RepeatedField<CookingHistory> repeatedField4 = other.cookingHistory_;
																				if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																				{
																					RepeatedField<int> repeatedField5 = unlockedCraftingRecipes_;
																					RepeatedField<int> repeatedField6 = other.unlockedCraftingRecipes_;
																					if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
																					{
																						RepeatedField<Buff> repeatedField7 = buffs_;
																						RepeatedField<Buff> repeatedField8 = other.buffs_;
																						if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
																						{
																							RepeatedField<Pet> repeatedField9 = pets_;
																							RepeatedField<Pet> repeatedField10 = other.pets_;
																							if (((RepeatedField<T>)(object)repeatedField9).Equals((RepeatedField<>)(object)repeatedField10))
																							{
																								int num6 = other.currentPet_;
																								if (currentPet_ == num6)
																								{
																									MapField<int, FishRecord> mapField7 = fishRecords_;
																									MapField<int, FishRecord> mapField8 = other.fishRecords_;
																									if (((MapField<TKey, TValue>)(object)mapField7).Equals((MapField<, >)(object)mapField8))
																									{
																										MapField<int, DutyList> mapField9 = dutySlots_;
																										MapField<int, DutyList> mapField10 = other.dutySlots_;
																										if (((MapField<TKey, TValue>)(object)mapField9).Equals((MapField<, >)(object)mapField10))
																										{
																											RoyalDutyProgress objB4 = other.royalDutyProgress_;
																											if (object.Equals(royalDutyProgress_, objB4))
																											{
																												RepeatedField<CollectionSet> repeatedField11 = collectionSets_;
																												RepeatedField<CollectionSet> repeatedField12 = other.collectionSets_;
																												if (((RepeatedField<T>)(object)repeatedField11).Equals((RepeatedField<>)(object)repeatedField12))
																												{
																													RepeatedField<AchievementData> repeatedField13 = achievementsData_;
																													RepeatedField<AchievementData> repeatedField14 = other.achievementsData_;
																													if (((RepeatedField<T>)(object)repeatedField13).Equals((RepeatedField<>)(object)repeatedField14))
																													{
																														MiniEventStatesData objB5 = other.miniEventStates_;
																														if (object.Equals(miniEventStates_, objB5))
																														{
																															MegaEventProgress objB6 = other.megaEventProgress_;
																															if (object.Equals(megaEventProgress_, objB6))
																															{
																																CampaignHistoryData objB7 = other.campaignHistory_;
																																if (object.Equals(campaignHistory_, objB7))
																																{
																																	BattlePassStatesData objB8 = other.battlePassStates_;
																																	if (object.Equals(battlePassStates_, objB8))
																																	{
																																		MapField<int, DesignMap> mapField11 = furnitureDesigns_;
																																		MapField<int, DesignMap> mapField12 = other.furnitureDesigns_;
																																		if (((MapField<TKey, TValue>)(object)mapField11).Equals((MapField<, >)(object)mapField12))
																																		{
																																			MapField<int, Furniture> mapField13 = furnitureData_;
																																			MapField<int, Furniture> mapField14 = other.furnitureData_;
																																			if (((MapField<TKey, TValue>)(object)mapField13).Equals((MapField<, >)(object)mapField14))
																																			{
																																				int num7 = other.nextFurnitureDesignID_;
																																				if (nextFurnitureDesignID_ == num7)
																																				{
																																					MapField<int, DesignMap> mapField15 = femaleClothingDesigns_;
																																					MapField<int, DesignMap> mapField16 = other.femaleClothingDesigns_;
																																					if (((MapField<TKey, TValue>)(object)mapField15).Equals((MapField<, >)(object)mapField16))
																																					{
																																						MapField<int, DesignMap> mapField17 = maleClothingDesigns_;
																																						MapField<int, DesignMap> mapField18 = other.maleClothingDesigns_;
																																						if (((MapField<TKey, TValue>)(object)mapField17).Equals((MapField<, >)(object)mapField18))
																																						{
																																							int num8 = other.nextClothingDesignID_;
																																							if (nextClothingDesignID_ == num8)
																																							{
																																								int num9 = other.clothingDesignLimitReachedCount_;
																																								if (clothingDesignLimitReachedCount_ == num9)
																																								{
																																									MapField<int, int> mapField19 = memoryShards_;
																																									MapField<int, int> mapField20 = other.memoryShards_;
																																									if (((MapField<TKey, TValue>)(object)mapField19).Equals((MapField<, >)(object)mapField20))
																																									{
																																										int num10 = other.randomMasterSeed_;
																																										if (randomMasterSeed_ == num10)
																																										{
																																											MapField<string, int> mapField21 = randomSeeds_;
																																											MapField<string, int> mapField22 = other.randomSeeds_;
																																											if (((MapField<TKey, TValue>)(object)mapField21).Equals((MapField<, >)(object)mapField22))
																																											{
																																												Duration objB9 = other.debugTimeSkippedOnline_;
																																												if (object.Equals(debugTimeSkippedOnline_, objB9))
																																												{
																																													Duration objB10 = other.debugTimeSkipped_;
																																													if (object.Equals(debugTimeSkipped_, objB10))
																																													{
																																														ProfileLimits objB11 = other.limitedActions_;
																																														if (object.Equals(limitedActions_, objB11))
																																														{
																																															ActivityBonusReward objB12 = other.activityBonusReward_;
																																															if (object.Equals(activityBonusReward_, objB12))
																																															{
																																																int num11 = other.maxFTUEPlayerLevel_;
																																																if (maxFTUEPlayerLevel_ == num11)
																																																{
																																																	int num12 = other.currentFtueEvent_;
																																																	if (currentFtueEvent_ == num12)
																																																	{
																																																		RepeatedField<int> repeatedField15 = completedFtueEvents_;
																																																		RepeatedField<int> repeatedField16 = other.completedFtueEvents_;
																																																		if (((RepeatedField<T>)(object)repeatedField15).Equals((RepeatedField<>)(object)repeatedField16))
																																																		{
																																																			int num13 = other.timePlayedInMinutes_;
																																																			if (timePlayedInMinutes_ == num13)
																																																			{
																																																				uint num14 = other.hudApparition_;
																																																				if (hudApparition_ == num14)
																																																				{
																																																					Inbox objB13 = other.inbox_;
																																																					if (object.Equals(inbox_, objB13))
																																																					{
																																																						TrackingData objB14 = other.trackingData_;
																																																						if (object.Equals(trackingData_, objB14))
																																																						{
																																																							PhonePromptEventData objB15 = other.phonePromptEvent_;
																																																							if (object.Equals(phonePromptEvent_, objB15))
																																																							{
																																																								MapField<string, Timestamp> mapField23 = timestamps_;
																																																								MapField<string, Timestamp> mapField24 = other.timestamps_;
																																																								if (((MapField<TKey, TValue>)(object)mapField23).Equals((MapField<, >)(object)mapField24))
																																																								{
																																																									OnlineShopStatesData objB16 = other.onlineShopStates_;
																																																									if (object.Equals(onlineShopStates_, objB16))
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
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num15 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600507D")]
		[Cpp2IlInjected.Address(RVA = "0x968A20", Offset = "0x967420", VA = "0x180968A20", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_0385
			int num = 0;
			string text = name_;
			if (text.m_stringLength != num)
			{
				int hashCode = text.GetHashCode();
			}
			if (level_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text)->ResultCode;
			}
			if (xp_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text)->ResultCode;
			}
			int hashCode2 = ((MapField<TKey, TValue>)(object)containerInventories_).GetHashCode();
			if (nextContainerInventoryID_ != 0)
			{
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)listInventories_).GetHashCode();
			if (nextListInventoryID_ != 0)
			{
			}
			int hashCode4 = ((MapField<TKey, TValue>)(object)currencyAmounts_).GetHashCode();
			int hashCode5 = ((RepeatedField<T>)(object)tools_).GetHashCode();
			if (mana_ != 0)
			{
			}
			if (manaHasAlreadyMissed_)
			{
			}
			Avatar avatar = femaleAvatar_;
			if (avatar != null)
			{
				int hashCode6 = avatar.GetHashCode();
			}
			Avatar avatar2 = maleAvatar_;
			if (avatar2 != null)
			{
				int hashCode7 = avatar2.GetHashCode();
			}
			if (avatarIsMale_)
			{
			}
			if (transferDone_)
			{
			}
			Cookbook cookbook = cookbook_;
			if (cookbook != null)
			{
				int hashCode8 = cookbook.GetHashCode();
			}
			int hashCode9 = ((RepeatedField<T>)(object)cookingHistory_).GetHashCode();
			RepeatedField<int> repeatedField = unlockedCraftingRecipes_;
			hashCode4 = hashCode9;
			int hashCode10 = ((RepeatedField<T>)(object)repeatedField).GetHashCode();
			RepeatedField<Buff> repeatedField2 = buffs_;
			hashCode5 = hashCode10;
			int hashCode11 = ((RepeatedField<T>)(object)repeatedField2).GetHashCode();
			RepeatedField<Pet> repeatedField3 = pets_;
			hashCode4 = hashCode11;
			hashCode5 = ((RepeatedField<T>)(object)repeatedField3).GetHashCode();
			if (currentPet_ != 0)
			{
			}
			int hashCode12 = ((MapField<TKey, TValue>)(object)fishRecords_).GetHashCode();
			MapField<int, DutyList> mapField = dutySlots_;
			hashCode4 = hashCode12;
			int hashCode13 = ((MapField<TKey, TValue>)(object)mapField).GetHashCode();
			RoyalDutyProgress royalDutyProgress = royalDutyProgress_;
			hashCode5 = hashCode13;
			if (royalDutyProgress != null)
			{
				int hashCode14 = royalDutyProgress.GetHashCode();
			}
			int hashCode15 = ((RepeatedField<T>)(object)collectionSets_).GetHashCode();
			RepeatedField<AchievementData> repeatedField4 = achievementsData_;
			hashCode4 = hashCode15;
			int hashCode16 = ((RepeatedField<T>)(object)repeatedField4).GetHashCode();
			MiniEventStatesData miniEventStatesData = miniEventStates_;
			hashCode5 = hashCode16;
			if (miniEventStatesData != null)
			{
				int hashCode17 = miniEventStatesData.GetHashCode();
			}
			MegaEventProgress megaEventProgress = megaEventProgress_;
			if (megaEventProgress != null)
			{
				int hashCode18 = megaEventProgress.GetHashCode();
			}
			CampaignHistoryData campaignHistoryData = campaignHistory_;
			if (campaignHistoryData != null)
			{
				int hashCode19 = campaignHistoryData.GetHashCode();
			}
			BattlePassStatesData battlePassStatesData = battlePassStates_;
			if (battlePassStatesData != null)
			{
				int hashCode20 = battlePassStatesData.GetHashCode();
			}
			int hashCode21 = ((MapField<TKey, TValue>)(object)furnitureDesigns_).GetHashCode();
			MapField<int, Furniture> mapField2 = furnitureData_;
			hashCode4 = hashCode21;
			hashCode5 = ((MapField<TKey, TValue>)(object)mapField2).GetHashCode();
			if (nextFurnitureDesignID_ != 0)
			{
			}
			int hashCode22 = ((MapField<TKey, TValue>)(object)femaleClothingDesigns_).GetHashCode();
			MapField<int, DesignMap> mapField3 = maleClothingDesigns_;
			hashCode4 = hashCode22;
			hashCode5 = ((MapField<TKey, TValue>)(object)mapField3).GetHashCode();
			if (nextClothingDesignID_ != 0)
			{
			}
			if (clothingDesignLimitReachedCount_ != 0)
			{
			}
			int hashCode23 = ((MapField<TKey, TValue>)(object)memoryShards_).GetHashCode();
			if (randomMasterSeed_ != 0)
			{
			}
			int hashCode24 = ((MapField<TKey, TValue>)(object)randomSeeds_).GetHashCode();
			Duration duration = debugTimeSkippedOnline_;
			if (duration != null)
			{
				int hashCode25 = duration.GetHashCode();
			}
			Duration duration2 = debugTimeSkipped_;
			if (duration2 != null)
			{
				int hashCode26 = duration2.GetHashCode();
			}
			ProfileLimits profileLimits = limitedActions_;
			if (profileLimits != null)
			{
				int hashCode27 = profileLimits.GetHashCode();
			}
			ActivityBonusReward activityBonusReward = activityBonusReward_;
			if (activityBonusReward != null)
			{
				int hashCode28 = activityBonusReward.GetHashCode();
			}
			if (maxFTUEPlayerLevel_ != 0)
			{
			}
			if (currentFtueEvent_ != 0)
			{
			}
			int hashCode29 = ((RepeatedField<T>)(object)completedFtueEvents_).GetHashCode();
			if (timePlayedInMinutes_ != 0)
			{
			}
			if (hudApparition_ != 0)
			{
			}
			Inbox inbox = inbox_;
			if (inbox != null)
			{
				int hashCode30 = inbox.GetHashCode();
			}
			TrackingData trackingData = trackingData_;
			if (trackingData != null)
			{
				int hashCode31 = trackingData.GetHashCode();
			}
			PhonePromptEventData phonePromptEventData = phonePromptEvent_;
			if (phonePromptEventData != null)
			{
				int hashCode32 = phonePromptEventData.GetHashCode();
			}
			int hashCode33 = ((MapField<TKey, TValue>)(object)timestamps_).GetHashCode();
			OnlineShopStatesData onlineShopStatesData = onlineShopStates_;
			if (onlineShopStatesData != null)
			{
				int hashCode34 = onlineShopStatesData.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode35 = unknownFields.GetHashCode();
			}
			return hashCode5;
		}

		[Cpp2IlInjected.Token(Token = "0x600507E")]
		[Cpp2IlInjected.Address(RVA = "0x972780", Offset = "0x971180", VA = "0x180972780", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600507F")]
		[Cpp2IlInjected.Address(RVA = "0x973080", Offset = "0x971A80", VA = "0x180973080", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0583
			if (name_.m_stringLength != 0)
			{
				string value = name_;
				output.WriteString(value);
			}
			if ((long)_repeated_tools_codec != 0)
			{
				int value2 = level_;
				output.WriteInt32(value2);
			}
			if (xp_ != 0)
			{
				int value3 = xp_;
				output.WriteInt32(value3);
			}
			MapField<uint, ContainerInventory> mapField = containerInventories_;
			MapField<uint, ContainerInventory>.Codec map_containerInventories_codec = _map_containerInventories_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_containerInventories_codec);
			if (nextContainerInventoryID_ != 0)
			{
				uint value4 = nextContainerInventoryID_;
				output.WriteUInt32(value4);
			}
			MapField<uint, ListInventory> mapField2 = listInventories_;
			MapField<uint, ListInventory>.Codec map_listInventories_codec = _map_listInventories_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_listInventories_codec);
			if ((long)_repeated_pets_codec != 0)
			{
				uint value5 = nextListInventoryID_;
				output.WriteUInt32(value5);
			}
			MapField<int, int> mapField3 = currencyAmounts_;
			MapField<int, int>.Codec map_currencyAmounts_codec = _map_currencyAmounts_codec;
			((MapField<TKey, TValue>)(object)mapField3).WriteTo(output, (MapField<, >.Codec)(object)map_currencyAmounts_codec);
			RepeatedField<ToolInfo> repeatedField = tools_;
			FieldCodec<ToolInfo> repeated_tools_codec = _repeated_tools_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tools_codec);
			if ((long)_repeated_collectionSets_codec != 0)
			{
				int value6 = mana_;
				output.WriteInt32(value6);
			}
			if (manaHasAlreadyMissed_)
			{
				bool value7 = manaHasAlreadyMissed_;
				output.WriteBool(value7);
			}
			if ((long)femaleAvatar_ != 0)
			{
				Avatar value8 = femaleAvatar_;
				output.WriteMessage(value8);
			}
			if ((long)maleAvatar_ != 0)
			{
				Avatar value9 = maleAvatar_;
				output.WriteMessage(value9);
			}
			if ((long)_map_furnitureData_codec != 0)
			{
				bool value10 = avatarIsMale_;
				output.WriteBool(value10);
			}
			if (transferDone_)
			{
				bool value11 = transferDone_;
				output.WriteBool(value11);
			}
			if ((long)_map_femaleClothingDesigns_codec != 0)
			{
				Cookbook value12 = cookbook_;
				output.WriteMessage(value12);
			}
			RepeatedField<CookingHistory> repeatedField2 = cookingHistory_;
			FieldCodec<CookingHistory> repeated_cookingHistory_codec = _repeated_cookingHistory_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_cookingHistory_codec);
			RepeatedField<int> repeatedField3 = unlockedCraftingRecipes_;
			FieldCodec<int> repeated_unlockedCraftingRecipes_codec = _repeated_unlockedCraftingRecipes_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_unlockedCraftingRecipes_codec);
			RepeatedField<Buff> repeatedField4 = buffs_;
			FieldCodec<Buff> repeated_buffs_codec = _repeated_buffs_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_buffs_codec);
			RepeatedField<Pet> repeatedField5 = pets_;
			FieldCodec<Pet> repeated_pets_codec = _repeated_pets_codec;
			((RepeatedField<T>)(object)repeatedField5).WriteTo(output, (FieldCodec<>)(object)repeated_pets_codec);
			if (currentPet_ != 0)
			{
				int value13 = currentPet_;
				output.WriteInt32(value13);
			}
			MapField<int, FishRecord> mapField4 = fishRecords_;
			MapField<int, FishRecord>.Codec map_fishRecords_codec = _map_fishRecords_codec;
			((MapField<TKey, TValue>)(object)mapField4).WriteTo(output, (MapField<, >.Codec)(object)map_fishRecords_codec);
			MapField<int, DutyList> mapField5 = dutySlots_;
			MapField<int, DutyList>.Codec map_dutySlots_codec = _map_dutySlots_codec;
			((MapField<TKey, TValue>)(object)mapField5).WriteTo(output, (MapField<, >.Codec)(object)map_dutySlots_codec);
			if ((long)royalDutyProgress_ != 0)
			{
				RoyalDutyProgress value14 = royalDutyProgress_;
				output.WriteMessage(value14);
			}
			RepeatedField<CollectionSet> repeatedField6 = collectionSets_;
			FieldCodec<CollectionSet> repeated_collectionSets_codec = _repeated_collectionSets_codec;
			((RepeatedField<T>)(object)repeatedField6).WriteTo(output, (FieldCodec<>)(object)repeated_collectionSets_codec);
			RepeatedField<AchievementData> repeatedField7 = achievementsData_;
			FieldCodec<AchievementData> repeated_achievementsData_codec = _repeated_achievementsData_codec;
			((RepeatedField<T>)(object)repeatedField7).WriteTo(output, (FieldCodec<>)(object)repeated_achievementsData_codec);
			if ((long)miniEventStates_ != 0)
			{
				MiniEventStatesData value15 = miniEventStates_;
				output.WriteMessage(value15);
			}
			if ((long)megaEventProgress_ != 0)
			{
				MegaEventProgress value16 = megaEventProgress_;
				output.WriteMessage(value16);
			}
			if ((long)campaignHistory_ != 0)
			{
				CampaignHistoryData value17 = campaignHistory_;
				output.WriteMessage(value17);
			}
			if ((long)battlePassStates_ != 0)
			{
				BattlePassStatesData value18 = battlePassStates_;
				output.WriteMessage(value18);
			}
			MapField<int, DesignMap> mapField6 = furnitureDesigns_;
			MapField<int, DesignMap>.Codec map_furnitureDesigns_codec = _map_furnitureDesigns_codec;
			((MapField<TKey, TValue>)(object)mapField6).WriteTo(output, (MapField<, >.Codec)(object)map_furnitureDesigns_codec);
			MapField<int, Furniture> mapField7 = furnitureData_;
			MapField<int, Furniture>.Codec map_furnitureData_codec = _map_furnitureData_codec;
			((MapField<TKey, TValue>)(object)mapField7).WriteTo(output, (MapField<, >.Codec)(object)map_furnitureData_codec);
			if (nextFurnitureDesignID_ != 0)
			{
				int value19 = nextFurnitureDesignID_;
				output.WriteInt32(value19);
			}
			MapField<int, DesignMap> mapField8 = femaleClothingDesigns_;
			MapField<int, DesignMap>.Codec map_femaleClothingDesigns_codec = _map_femaleClothingDesigns_codec;
			((MapField<TKey, TValue>)(object)mapField8).WriteTo(output, (MapField<, >.Codec)(object)map_femaleClothingDesigns_codec);
			MapField<int, DesignMap> mapField9 = maleClothingDesigns_;
			MapField<int, DesignMap>.Codec map_maleClothingDesigns_codec = _map_maleClothingDesigns_codec;
			((MapField<TKey, TValue>)(object)mapField9).WriteTo(output, (MapField<, >.Codec)(object)map_maleClothingDesigns_codec);
			if (nextClothingDesignID_ != 0)
			{
				int value20 = nextClothingDesignID_;
				output.WriteInt32(value20);
			}
			if (clothingDesignLimitReachedCount_ != 0)
			{
				int value21 = clothingDesignLimitReachedCount_;
				output.WriteInt32(value21);
			}
			MapField<int, int> mapField10 = memoryShards_;
			MapField<int, int>.Codec map_memoryShards_codec = _map_memoryShards_codec;
			((MapField<TKey, TValue>)(object)mapField10).WriteTo(output, (MapField<, >.Codec)(object)map_memoryShards_codec);
			if (randomMasterSeed_ != 0)
			{
				int value22 = randomMasterSeed_;
				output.WriteInt32(value22);
			}
			MapField<string, int> mapField11 = randomSeeds_;
			MapField<string, int>.Codec map_randomSeeds_codec = _map_randomSeeds_codec;
			((MapField<TKey, TValue>)(object)mapField11).WriteTo(output, (MapField<, >.Codec)(object)map_randomSeeds_codec);
			if ((long)debugTimeSkippedOnline_ != 0)
			{
				Duration value23 = debugTimeSkippedOnline_;
				output.WriteMessage(value23);
			}
			if ((long)debugTimeSkipped_ != 0)
			{
				Duration value24 = debugTimeSkipped_;
				output.WriteMessage(value24);
			}
			if ((long)limitedActions_ != 0)
			{
				ProfileLimits value25 = limitedActions_;
				output.WriteMessage(value25);
			}
			if ((long)activityBonusReward_ != 0)
			{
				ActivityBonusReward value26 = activityBonusReward_;
				output.WriteMessage(value26);
			}
			if (maxFTUEPlayerLevel_ != 0)
			{
				int value27 = maxFTUEPlayerLevel_;
				output.WriteInt32(value27);
			}
			if (currentFtueEvent_ != 0)
			{
				int value28 = currentFtueEvent_;
				output.WriteInt32(value28);
			}
			RepeatedField<int> repeatedField8 = completedFtueEvents_;
			FieldCodec<int> repeated_completedFtueEvents_codec = _repeated_completedFtueEvents_codec;
			((RepeatedField<T>)(object)repeatedField8).WriteTo(output, (FieldCodec<>)(object)repeated_completedFtueEvents_codec);
			if (timePlayedInMinutes_ != 0)
			{
				int value29 = timePlayedInMinutes_;
				output.WriteInt32(value29);
			}
			if (hudApparition_ != 0)
			{
				uint value30 = hudApparition_;
				output.WriteFixed32(value30);
			}
			if ((long)inbox_ != 0)
			{
				Inbox value31 = inbox_;
				output.WriteMessage(value31);
			}
			if ((long)trackingData_ != 0)
			{
				TrackingData value32 = trackingData_;
				output.WriteMessage(value32);
			}
			if ((long)phonePromptEvent_ != 0)
			{
				PhonePromptEventData value33 = phonePromptEvent_;
				output.WriteMessage(value33);
			}
			MapField<string, Timestamp> mapField12 = timestamps_;
			MapField<string, Timestamp>.Codec map_timestamps_codec = _map_timestamps_codec;
			((MapField<TKey, TValue>)(object)mapField12).WriteTo(output, (MapField<, >.Codec)(object)map_timestamps_codec);
			if ((long)onlineShopStates_ != 0)
			{
				OnlineShopStatesData value34 = onlineShopStates_;
				output.WriteMessage(value34);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005080")]
		[Cpp2IlInjected.Address(RVA = "0x963990", Offset = "0x962390", VA = "0x180963990", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected O, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected O, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Expected O, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected O, but got Unknown
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Expected O, but got Unknown
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Expected O, but got Unknown
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Expected O, but got Unknown
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Expected O, but got Unknown
			//IL_0390: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Expected O, but got Unknown
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Expected O, but got Unknown
			//IL_040a: Unknown result type (might be due to invalid IL or missing references)
			//IL_040d: Expected O, but got Unknown
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Expected O, but got Unknown
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0451: Expected O, but got Unknown
			//IL_0477: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Expected O, but got Unknown
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Expected O, but got Unknown
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b8: Expected O, but got Unknown
			//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04db: Expected O, but got Unknown
			//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fe: Expected O, but got Unknown
			//IL_051e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0521: Expected O, but got Unknown
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0544: Expected O, but got Unknown
			//IL_056a: Unknown result type (might be due to invalid IL or missing references)
			//IL_056d: Expected O, but got Unknown
			//IL_0585: Unknown result type (might be due to invalid IL or missing references)
			//IL_0588: Expected O, but got Unknown
			//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ab: Expected O, but got Unknown
			//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ce: Expected O, but got Unknown
			//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f1: Expected O, but got Unknown
			//IL_0617: Unknown result type (might be due to invalid IL or missing references)
			//IL_061a: Expected O, but got Unknown
			//IL_0632: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Expected O, but got Unknown
			//IL_064f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0652: Expected O, but got Unknown
			string text = name_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			int num3 = level_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			int num5 = xp_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			MapField<uint, ContainerInventory> mapField = containerInventories_;
			MapField<uint, ContainerInventory>.Codec map_containerInventories_codec = _map_containerInventories_codec;
			int num7 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_containerInventories_codec);
			uint num8 = nextContainerInventoryID_;
			num += num7;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeUInt32Size(num8);
				num9++;
				num += num9;
			}
			MapField<uint, ListInventory> mapField2 = listInventories_;
			MapField<uint, ListInventory>.Codec map_listInventories_codec = _map_listInventories_codec;
			int num10 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_listInventories_codec);
			uint num11 = nextListInventoryID_;
			num += num10;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeUInt32Size(num11);
				num12++;
				num += num12;
			}
			MapField<int, int> mapField3 = currencyAmounts_;
			MapField<int, int>.Codec map_currencyAmounts_codec = _map_currencyAmounts_codec;
			int num13 = ((MapField<TKey, TValue>)(object)mapField3).CalculateSize((MapField<, >.Codec)(object)map_currencyAmounts_codec);
			RepeatedField<ToolInfo> repeatedField = tools_;
			FieldCodec<ToolInfo> repeated_tools_codec = _repeated_tools_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tools_codec);
			int num15 = mana_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				mapField3 = (MapField<int, int>)(mapField3 + num16);
			}
			Avatar avatar = femaleAvatar_;
			if (avatar != null)
			{
				int num17 = CodedOutputStream.ComputeMessageSize(avatar);
				num17++;
				mapField3 = (MapField<int, int>)(mapField3 + num17);
			}
			Avatar avatar2 = maleAvatar_;
			if (avatar2 != null)
			{
				int num18 = CodedOutputStream.ComputeMessageSize(avatar2);
				num18++;
				mapField3 = (MapField<int, int>)(mapField3 + num18);
			}
			Cookbook cookbook = cookbook_;
			if (cookbook != null)
			{
				int num19 = CodedOutputStream.ComputeMessageSize(cookbook);
				num19 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num19);
			}
			RepeatedField<CookingHistory> repeatedField2 = cookingHistory_;
			FieldCodec<CookingHistory> repeated_cookingHistory_codec = _repeated_cookingHistory_codec;
			int num20 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_cookingHistory_codec);
			RepeatedField<int> repeatedField3 = unlockedCraftingRecipes_;
			FieldCodec<int> repeated_unlockedCraftingRecipes_codec = _repeated_unlockedCraftingRecipes_codec;
			int num21 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_unlockedCraftingRecipes_codec);
			RepeatedField<Buff> repeatedField4 = buffs_;
			FieldCodec<Buff> repeated_buffs_codec = _repeated_buffs_codec;
			int num22 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_buffs_codec);
			RepeatedField<Pet> repeatedField5 = pets_;
			FieldCodec<Pet> repeated_pets_codec = _repeated_pets_codec;
			int num23 = ((RepeatedField<T>)(object)repeatedField5).CalculateSize((FieldCodec<>)(object)repeated_pets_codec);
			int num24 = currentPet_;
			if (num24 != 0)
			{
				int num25 = CodedOutputStream.ComputeInt32Size(num24);
				num25 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num25);
			}
			MapField<int, FishRecord> mapField4 = fishRecords_;
			MapField<int, FishRecord>.Codec map_fishRecords_codec = _map_fishRecords_codec;
			int num26 = ((MapField<TKey, TValue>)(object)mapField4).CalculateSize((MapField<, >.Codec)(object)map_fishRecords_codec);
			MapField<int, DutyList> mapField5 = dutySlots_;
			MapField<int, DutyList>.Codec map_dutySlots_codec = _map_dutySlots_codec;
			int num27 = ((MapField<TKey, TValue>)(object)mapField5).CalculateSize((MapField<, >.Codec)(object)map_dutySlots_codec);
			RoyalDutyProgress royalDutyProgress = royalDutyProgress_;
			if (royalDutyProgress != null)
			{
				int num28 = CodedOutputStream.ComputeMessageSize(royalDutyProgress);
				num28 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num28);
			}
			RepeatedField<CollectionSet> repeatedField6 = collectionSets_;
			FieldCodec<CollectionSet> repeated_collectionSets_codec = _repeated_collectionSets_codec;
			int num29 = ((RepeatedField<T>)(object)repeatedField6).CalculateSize((FieldCodec<>)(object)repeated_collectionSets_codec);
			RepeatedField<AchievementData> repeatedField7 = achievementsData_;
			FieldCodec<AchievementData> repeated_achievementsData_codec = _repeated_achievementsData_codec;
			int num30 = ((RepeatedField<T>)(object)repeatedField7).CalculateSize((FieldCodec<>)(object)repeated_achievementsData_codec);
			MiniEventStatesData miniEventStatesData = miniEventStates_;
			if (miniEventStatesData != null)
			{
				int num31 = CodedOutputStream.ComputeMessageSize(miniEventStatesData);
				num31 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num31);
			}
			MegaEventProgress megaEventProgress = megaEventProgress_;
			if (megaEventProgress != null)
			{
				int num32 = CodedOutputStream.ComputeMessageSize(megaEventProgress);
				num32 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num32);
			}
			CampaignHistoryData campaignHistoryData = campaignHistory_;
			if (campaignHistoryData != null)
			{
				int num33 = CodedOutputStream.ComputeMessageSize(campaignHistoryData);
				num33 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num33);
			}
			BattlePassStatesData battlePassStatesData = battlePassStates_;
			if (battlePassStatesData != null)
			{
				int num34 = CodedOutputStream.ComputeMessageSize(battlePassStatesData);
				num34 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num34);
			}
			MapField<int, DesignMap> mapField6 = furnitureDesigns_;
			MapField<int, DesignMap>.Codec map_furnitureDesigns_codec = _map_furnitureDesigns_codec;
			int num35 = ((MapField<TKey, TValue>)(object)mapField6).CalculateSize((MapField<, >.Codec)(object)map_furnitureDesigns_codec);
			MapField<int, Furniture> mapField7 = furnitureData_;
			MapField<int, Furniture>.Codec map_furnitureData_codec = _map_furnitureData_codec;
			int num36 = ((MapField<TKey, TValue>)(object)mapField7).CalculateSize((MapField<, >.Codec)(object)map_furnitureData_codec);
			int num37 = nextFurnitureDesignID_;
			if (num37 != 0)
			{
				int num38 = CodedOutputStream.ComputeInt32Size(num37);
				num38 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num38);
			}
			MapField<int, DesignMap> mapField8 = femaleClothingDesigns_;
			MapField<int, DesignMap>.Codec map_femaleClothingDesigns_codec = _map_femaleClothingDesigns_codec;
			int num39 = ((MapField<TKey, TValue>)(object)mapField8).CalculateSize((MapField<, >.Codec)(object)map_femaleClothingDesigns_codec);
			MapField<int, DesignMap> mapField9 = maleClothingDesigns_;
			MapField<int, DesignMap>.Codec map_maleClothingDesigns_codec = _map_maleClothingDesigns_codec;
			int num40 = ((MapField<TKey, TValue>)(object)mapField9).CalculateSize((MapField<, >.Codec)(object)map_maleClothingDesigns_codec);
			int num41 = nextClothingDesignID_;
			if (num41 != 0)
			{
				int num42 = CodedOutputStream.ComputeInt32Size(num41);
				num42 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num42);
			}
			int num43 = clothingDesignLimitReachedCount_;
			if (num43 != 0)
			{
				int num44 = CodedOutputStream.ComputeInt32Size(num43);
				num44 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num44);
			}
			MapField<int, int> mapField10 = memoryShards_;
			MapField<int, int>.Codec map_memoryShards_codec = _map_memoryShards_codec;
			int num45 = ((MapField<TKey, TValue>)(object)mapField10).CalculateSize((MapField<, >.Codec)(object)map_memoryShards_codec);
			int num46 = randomMasterSeed_;
			mapField3 = (MapField<int, int>)(mapField3 + num45);
			if (num46 != 0)
			{
				int num47 = CodedOutputStream.ComputeInt32Size(num46);
				num47 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num47);
			}
			MapField<string, int> mapField11 = randomSeeds_;
			MapField<string, int>.Codec map_randomSeeds_codec = _map_randomSeeds_codec;
			int num48 = ((MapField<TKey, TValue>)(object)mapField11).CalculateSize((MapField<, >.Codec)(object)map_randomSeeds_codec);
			Duration duration = debugTimeSkippedOnline_;
			mapField3 = (MapField<int, int>)(mapField3 + num48);
			if (duration != null)
			{
				int num49 = CodedOutputStream.ComputeMessageSize(duration);
				num49 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num49);
			}
			Duration duration2 = debugTimeSkipped_;
			if (duration2 != null)
			{
				int num50 = CodedOutputStream.ComputeMessageSize(duration2);
				num50 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num50);
			}
			ProfileLimits profileLimits = limitedActions_;
			if (profileLimits != null)
			{
				int num51 = CodedOutputStream.ComputeMessageSize(profileLimits);
				num51 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num51);
			}
			ActivityBonusReward activityBonusReward = activityBonusReward_;
			if (activityBonusReward != null)
			{
				int num52 = CodedOutputStream.ComputeMessageSize(activityBonusReward);
				num52 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num52);
			}
			int num53 = maxFTUEPlayerLevel_;
			if (num53 != 0)
			{
				int num54 = CodedOutputStream.ComputeInt32Size(num53);
				num54 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num54);
			}
			int num55 = currentFtueEvent_;
			if (num55 != 0)
			{
				int num56 = CodedOutputStream.ComputeInt32Size(num55);
				num56 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num56);
			}
			RepeatedField<int> repeatedField8 = completedFtueEvents_;
			FieldCodec<int> repeated_completedFtueEvents_codec = _repeated_completedFtueEvents_codec;
			int num57 = ((RepeatedField<T>)(object)repeatedField8).CalculateSize((FieldCodec<>)(object)repeated_completedFtueEvents_codec);
			int num58 = timePlayedInMinutes_;
			mapField3 = (MapField<int, int>)(mapField3 + num57);
			if (num58 != 0)
			{
				int num59 = CodedOutputStream.ComputeInt32Size(num58);
				num59 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num59);
			}
			Inbox inbox = inbox_;
			if (inbox != null)
			{
				int num60 = CodedOutputStream.ComputeMessageSize(inbox);
				num60 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num60);
			}
			TrackingData trackingData = trackingData_;
			if (trackingData != null)
			{
				int num61 = CodedOutputStream.ComputeMessageSize(trackingData);
				num61 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num61);
			}
			PhonePromptEventData phonePromptEventData = phonePromptEvent_;
			if (phonePromptEventData != null)
			{
				int num62 = CodedOutputStream.ComputeMessageSize(phonePromptEventData);
				num62 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num62);
			}
			MapField<string, Timestamp> mapField12 = timestamps_;
			MapField<string, Timestamp>.Codec map_timestamps_codec = _map_timestamps_codec;
			int num63 = ((MapField<TKey, TValue>)(object)mapField12).CalculateSize((MapField<, >.Codec)(object)map_timestamps_codec);
			OnlineShopStatesData onlineShopStatesData = onlineShopStates_;
			mapField3 = (MapField<int, int>)(mapField3 + num63);
			if (onlineShopStatesData != null)
			{
				int num64 = CodedOutputStream.ComputeMessageSize(onlineShopStatesData);
				num64 += 2;
				mapField3 = (MapField<int, int>)(mapField3 + num64);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num65 = unknownFields.CalculateSize();
				mapField3 = (MapField<int, int>)(mapField3 + num65);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005081")]
		[Cpp2IlInjected.Address(RVA = "0x96DF00", Offset = "0x96C900", VA = "0x18096DF00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProfilePlayer other)
		{
			//Discarded unreachable code: IL_0752
			if (other == null)
			{
				return;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			int num = other.level_;
			if (num != 0)
			{
				level_ = num;
			}
			int num2 = other.xp_;
			if (num2 != 0)
			{
				xp_ = num2;
			}
			MapField<uint, ContainerInventory> mapField = containerInventories_;
			MapField<uint, ContainerInventory> mapField2 = other.containerInventories_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			uint num3 = other.nextContainerInventoryID_;
			if (num3 != 0)
			{
				nextContainerInventoryID_ = num3;
			}
			MapField<uint, ListInventory> mapField3 = listInventories_;
			MapField<uint, ListInventory> mapField4 = other.listInventories_;
			((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
			uint num4 = other.nextListInventoryID_;
			if (num4 != 0)
			{
				nextListInventoryID_ = num4;
			}
			MapField<int, int> mapField5 = currencyAmounts_;
			MapField<int, int> mapField6 = other.currencyAmounts_;
			((MapField<TKey, TValue>)(object)mapField5).Add((IDictionary<, >)(object)mapField6);
			RepeatedField<ToolInfo> repeatedField = tools_;
			RepeatedField<ToolInfo> repeatedField2 = other.tools_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num5 = other.mana_;
			if (num5 != 0)
			{
				mana_ = num5;
			}
			bool flag = other.manaHasAlreadyMissed_;
			if (flag)
			{
				manaHasAlreadyMissed_ = flag;
			}
			if ((long)other.femaleAvatar_ != 0)
			{
				Avatar avatar2 = default(Avatar);
				if (femaleAvatar_ == null)
				{
					Avatar avatar = (femaleAvatar_ = new Avatar());
					avatar2 = femaleAvatar_;
				}
				Avatar other2 = other.femaleAvatar_;
				avatar2.MergeFrom(other2);
			}
			if ((long)other.maleAvatar_ != 0)
			{
				Avatar avatar4 = default(Avatar);
				if (maleAvatar_ == null)
				{
					Avatar avatar3 = (maleAvatar_ = new Avatar());
					avatar4 = maleAvatar_;
				}
				Avatar other3 = other.maleAvatar_;
				avatar4.MergeFrom(other3);
			}
			bool flag2 = other.avatarIsMale_;
			if (flag2)
			{
				avatarIsMale_ = flag2;
			}
			bool flag3 = other.transferDone_;
			if (flag3)
			{
				transferDone_ = flag3;
			}
			if ((long)_map_femaleClothingDesigns_codec != 0)
			{
				Cookbook cookbook2 = default(Cookbook);
				if (cookbook_ == null)
				{
					Cookbook cookbook = (cookbook_ = new Cookbook());
					cookbook2 = cookbook_;
				}
				Cookbook other4 = other.cookbook_;
				cookbook2.MergeFrom(other4);
			}
			RepeatedField<CookingHistory> repeatedField3 = cookingHistory_;
			RepeatedField<CookingHistory> repeatedField4 = other.cookingHistory_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			RepeatedField<int> repeatedField5 = unlockedCraftingRecipes_;
			RepeatedField<int> repeatedField6 = other.unlockedCraftingRecipes_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			RepeatedField<Buff> repeatedField7 = buffs_;
			RepeatedField<Buff> repeatedField8 = other.buffs_;
			((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
			RepeatedField<Pet> repeatedField9 = pets_;
			RepeatedField<Pet> repeatedField10 = other.pets_;
			((RepeatedField<T>)(object)repeatedField9).Add((IEnumerable<>)(object)repeatedField10);
			int num6 = other.currentPet_;
			if (num6 != 0)
			{
				currentPet_ = num6;
			}
			MapField<int, FishRecord> mapField7 = fishRecords_;
			MapField<int, FishRecord> mapField8 = other.fishRecords_;
			((MapField<TKey, TValue>)(object)mapField7).Add((IDictionary<, >)(object)mapField8);
			MapField<int, DutyList> mapField9 = dutySlots_;
			MapField<int, DutyList> mapField10 = other.dutySlots_;
			((MapField<TKey, TValue>)(object)mapField9).Add((IDictionary<, >)(object)mapField10);
			if ((long)other.royalDutyProgress_ != 0)
			{
				RoyalDutyProgress royalDutyProgress2 = default(RoyalDutyProgress);
				if (royalDutyProgress_ == null)
				{
					RoyalDutyProgress royalDutyProgress = (royalDutyProgress_ = new RoyalDutyProgress());
					royalDutyProgress2 = royalDutyProgress_;
				}
				RoyalDutyProgress other5 = other.royalDutyProgress_;
				royalDutyProgress2.MergeFrom(other5);
			}
			RepeatedField<CollectionSet> repeatedField11 = collectionSets_;
			RepeatedField<CollectionSet> repeatedField12 = other.collectionSets_;
			((RepeatedField<T>)(object)repeatedField11).Add((IEnumerable<>)(object)repeatedField12);
			RepeatedField<AchievementData> repeatedField13 = achievementsData_;
			RepeatedField<AchievementData> repeatedField14 = other.achievementsData_;
			((RepeatedField<T>)(object)repeatedField13).Add((IEnumerable<>)(object)repeatedField14);
			if ((long)other.miniEventStates_ != 0)
			{
				MiniEventStatesData miniEventStatesData2 = default(MiniEventStatesData);
				if (miniEventStates_ == null)
				{
					MiniEventStatesData miniEventStatesData = (miniEventStates_ = new MiniEventStatesData());
					miniEventStatesData2 = miniEventStates_;
				}
				MiniEventStatesData other6 = other.miniEventStates_;
				miniEventStatesData2.MergeFrom(other6);
			}
			if ((long)other.megaEventProgress_ != 0)
			{
				MegaEventProgress megaEventProgress2 = default(MegaEventProgress);
				if (megaEventProgress_ == null)
				{
					MegaEventProgress megaEventProgress = (megaEventProgress_ = new MegaEventProgress());
					megaEventProgress2 = megaEventProgress_;
				}
				MegaEventProgress other7 = other.megaEventProgress_;
				megaEventProgress2.MergeFrom(other7);
			}
			if ((long)other.campaignHistory_ != 0)
			{
				CampaignHistoryData campaignHistoryData2 = default(CampaignHistoryData);
				if (campaignHistory_ == null)
				{
					CampaignHistoryData campaignHistoryData = (campaignHistory_ = new CampaignHistoryData());
					campaignHistoryData2 = campaignHistory_;
				}
				CampaignHistoryData other8 = other.campaignHistory_;
				campaignHistoryData2.MergeFrom(other8);
			}
			if ((long)other.battlePassStates_ != 0)
			{
				BattlePassStatesData battlePassStatesData2 = default(BattlePassStatesData);
				if (battlePassStates_ == null)
				{
					BattlePassStatesData battlePassStatesData = (battlePassStates_ = new BattlePassStatesData());
					battlePassStatesData2 = battlePassStates_;
				}
				BattlePassStatesData other9 = other.battlePassStates_;
				battlePassStatesData2.MergeFrom(other9);
			}
			MapField<int, DesignMap> mapField11 = furnitureDesigns_;
			MapField<int, DesignMap> mapField12 = other.furnitureDesigns_;
			((MapField<TKey, TValue>)(object)mapField11).Add((IDictionary<, >)(object)mapField12);
			MapField<int, Furniture> mapField13 = furnitureData_;
			MapField<int, Furniture> mapField14 = other.furnitureData_;
			((MapField<TKey, TValue>)(object)mapField13).Add((IDictionary<, >)(object)mapField14);
			int num7 = other.nextFurnitureDesignID_;
			if (num7 != 0)
			{
				nextFurnitureDesignID_ = num7;
			}
			MapField<int, DesignMap> mapField15 = femaleClothingDesigns_;
			MapField<int, DesignMap> mapField16 = other.femaleClothingDesigns_;
			((MapField<TKey, TValue>)(object)mapField15).Add((IDictionary<, >)(object)mapField16);
			MapField<int, DesignMap> mapField17 = maleClothingDesigns_;
			MapField<int, DesignMap> mapField18 = other.maleClothingDesigns_;
			((MapField<TKey, TValue>)(object)mapField17).Add((IDictionary<, >)(object)mapField18);
			int num8 = other.nextClothingDesignID_;
			if (num8 != 0)
			{
				nextClothingDesignID_ = num8;
			}
			int num9 = other.clothingDesignLimitReachedCount_;
			if (num9 != 0)
			{
				clothingDesignLimitReachedCount_ = num9;
			}
			MapField<int, int> mapField19 = memoryShards_;
			MapField<int, int> mapField20 = other.memoryShards_;
			((MapField<TKey, TValue>)(object)mapField19).Add((IDictionary<, >)(object)mapField20);
			int num10 = other.randomMasterSeed_;
			if (num10 != 0)
			{
				randomMasterSeed_ = num10;
			}
			MapField<string, int> mapField21 = randomSeeds_;
			MapField<string, int> mapField22 = other.randomSeeds_;
			((MapField<TKey, TValue>)(object)mapField21).Add((IDictionary<, >)(object)mapField22);
			if ((long)other.debugTimeSkippedOnline_ != 0)
			{
				Duration duration2 = default(Duration);
				if (debugTimeSkippedOnline_ == null)
				{
					Duration duration = (debugTimeSkippedOnline_ = new Duration());
					duration2 = debugTimeSkippedOnline_;
				}
				Duration other10 = other.debugTimeSkippedOnline_;
				duration2.MergeFrom(other10);
			}
			if ((long)other.debugTimeSkipped_ != 0)
			{
				Duration duration4 = default(Duration);
				if (debugTimeSkipped_ == null)
				{
					Duration duration3 = (debugTimeSkipped_ = new Duration());
					duration4 = debugTimeSkipped_;
				}
				Duration other11 = other.debugTimeSkipped_;
				duration4.MergeFrom(other11);
			}
			if ((long)other.limitedActions_ != 0)
			{
				ProfileLimits profileLimits2 = default(ProfileLimits);
				if (limitedActions_ == null)
				{
					ProfileLimits profileLimits = (limitedActions_ = new ProfileLimits());
					profileLimits2 = limitedActions_;
				}
				ProfileLimits other12 = other.limitedActions_;
				profileLimits2.MergeFrom(other12);
			}
			if ((long)other.activityBonusReward_ != 0)
			{
				ActivityBonusReward activityBonusReward2 = default(ActivityBonusReward);
				if (activityBonusReward_ == null)
				{
					ActivityBonusReward activityBonusReward = (activityBonusReward_ = new ActivityBonusReward());
					activityBonusReward2 = activityBonusReward_;
				}
				ActivityBonusReward other13 = other.activityBonusReward_;
				activityBonusReward2.MergeFrom(other13);
			}
			int num11 = other.maxFTUEPlayerLevel_;
			if (num11 != 0)
			{
				maxFTUEPlayerLevel_ = num11;
			}
			int num12 = other.currentFtueEvent_;
			if (num12 != 0)
			{
				currentFtueEvent_ = num12;
			}
			RepeatedField<int> repeatedField15 = completedFtueEvents_;
			RepeatedField<int> repeatedField16 = other.completedFtueEvents_;
			((RepeatedField<T>)(object)repeatedField15).Add((IEnumerable<>)(object)repeatedField16);
			int num13 = other.timePlayedInMinutes_;
			if (num13 != 0)
			{
				timePlayedInMinutes_ = num13;
			}
			uint num14 = other.hudApparition_;
			if (num14 != 0)
			{
				hudApparition_ = num14;
			}
			if ((long)other.inbox_ != 0)
			{
				Inbox inbox2 = default(Inbox);
				if (inbox_ == null)
				{
					Inbox inbox = (inbox_ = new Inbox());
					inbox2 = inbox_;
				}
				Inbox other14 = other.inbox_;
				inbox2.MergeFrom(other14);
			}
			if ((long)other.trackingData_ != 0)
			{
				TrackingData trackingData2 = default(TrackingData);
				if (trackingData_ == null)
				{
					TrackingData trackingData = (trackingData_ = new TrackingData());
					trackingData2 = trackingData_;
				}
				TrackingData other15 = other.trackingData_;
				trackingData2.MergeFrom(other15);
			}
			if ((long)other.phonePromptEvent_ != 0)
			{
				PhonePromptEventData phonePromptEventData2 = default(PhonePromptEventData);
				if (phonePromptEvent_ == null)
				{
					PhonePromptEventData phonePromptEventData = (phonePromptEvent_ = new PhonePromptEventData());
					phonePromptEventData2 = phonePromptEvent_;
				}
				PhonePromptEventData other16 = other.phonePromptEvent_;
				phonePromptEventData2.MergeFrom(other16);
			}
			MapField<string, Timestamp> mapField23 = timestamps_;
			MapField<string, Timestamp> mapField24 = other.timestamps_;
			((MapField<TKey, TValue>)(object)mapField23).Add((IDictionary<, >)(object)mapField24);
			if ((long)other.onlineShopStates_ != 0)
			{
				OnlineShopStatesData onlineShopStatesData2 = default(OnlineShopStatesData);
				if (onlineShopStates_ == null)
				{
					OnlineShopStatesData onlineShopStatesData = (onlineShopStates_ = new OnlineShopStatesData());
					onlineShopStatesData2 = onlineShopStates_;
				}
				OnlineShopStatesData other17 = other.onlineShopStates_;
				onlineShopStatesData2.MergeFrom(other17);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6005082")]
		[Cpp2IlInjected.Address(RVA = "0x96CCC0", Offset = "0x96B6C0", VA = "0x18096CCC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_08c3
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 218)
			{
				if ((int)num > 338)
				{
					if ((int)num > 386)
					{
						if ((int)num > 562)
						{
							if ((int)num > 802)
							{
								if (num == 882)
								{
									MapField<string, Timestamp> mapField = timestamps_;
									MapField<string, Timestamp>.Codec map_timestamps_codec = _map_timestamps_codec;
									((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_timestamps_codec);
								}
								if (num != 1602)
								{
									goto IL_08ac;
								}
								OnlineShopStatesData builder = default(OnlineShopStatesData);
								if (onlineShopStates_ == null)
								{
									OnlineShopStatesData onlineShopStatesData = (onlineShopStates_ = new OnlineShopStatesData());
									builder = onlineShopStates_;
								}
								input.ReadMessage(builder);
							}
							TrackingData trackingData = default(TrackingData);
							if (num == 642)
							{
								TrackingData builder2 = default(TrackingData);
								if (trackingData_ == null)
								{
									trackingData = (trackingData_ = new TrackingData());
									builder2 = trackingData_;
								}
								input.ReadMessage(builder2);
							}
							if ((long)trackingData != 802)
							{
								goto IL_08ac;
							}
							PhonePromptEventData builder3 = default(PhonePromptEventData);
							if (phonePromptEvent_ == null)
							{
								PhonePromptEventData phonePromptEventData = (phonePromptEvent_ = new PhonePromptEventData());
								builder3 = phonePromptEvent_;
							}
							input.ReadMessage(builder3);
						}
						int num2 = default(int);
						if (num == 392)
						{
							num2 = (timePlayedInMinutes_ = input.ReadInt32());
						}
						uint num3 = default(uint);
						if (num2 == 405)
						{
							num3 = (hudApparition_ = input.ReadFixed32());
						}
						if (num3 != 562)
						{
							goto IL_08ac;
						}
						Inbox builder4 = default(Inbox);
						if (inbox_ == null)
						{
							Inbox inbox = (inbox_ = new Inbox());
							builder4 = inbox_;
						}
						input.ReadMessage(builder4);
					}
					int num5 = default(int);
					if ((int)num > 362)
					{
						if ((int)num > 376)
						{
							num += 4294966912u;
							if (num != 4294967293u)
							{
								goto IL_08ac;
							}
							RepeatedField<int> repeatedField = completedFtueEvents_;
							FieldCodec<int> repeated_completedFtueEvents_codec = _repeated_completedFtueEvents_codec;
							((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_completedFtueEvents_codec);
						}
						int num4 = default(int);
						if (num == 368)
						{
							num4 = (maxFTUEPlayerLevel_ = input.ReadInt32());
						}
						if (num4 != 376)
						{
							goto IL_08ac;
						}
						num5 = (currentFtueEvent_ = input.ReadInt32());
					}
					Duration duration = default(Duration);
					if (num5 == 346)
					{
						Duration builder5 = default(Duration);
						if (debugTimeSkipped_ == null)
						{
							duration = (debugTimeSkipped_ = new Duration());
							builder5 = debugTimeSkipped_;
						}
						input.ReadMessage(builder5);
					}
					ProfileLimits profileLimits = default(ProfileLimits);
					if ((long)duration == 354)
					{
						ProfileLimits builder6 = default(ProfileLimits);
						if (limitedActions_ == null)
						{
							profileLimits = (limitedActions_ = new ProfileLimits());
							builder6 = limitedActions_;
						}
						input.ReadMessage(builder6);
					}
					if ((long)profileLimits != 362)
					{
						goto IL_08ac;
					}
					ActivityBonusReward builder7 = default(ActivityBonusReward);
					if (activityBonusReward_ == null)
					{
						ActivityBonusReward activityBonusReward = (activityBonusReward_ = new ActivityBonusReward());
						builder7 = activityBonusReward_;
					}
					input.ReadMessage(builder7);
				}
				int num8 = default(int);
				if ((int)num > 282)
				{
					int num6 = default(int);
					if ((int)num > 304)
					{
						Duration duration2 = default(Duration);
						if ((int)num > 320)
						{
							if (num == 330)
							{
								MapField<string, int> mapField2 = randomSeeds_;
								MapField<string, int>.Codec map_randomSeeds_codec = _map_randomSeeds_codec;
								((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_randomSeeds_codec);
							}
							if (num != 338)
							{
								goto IL_08ac;
							}
							Duration builder8 = default(Duration);
							if (debugTimeSkippedOnline_ == null)
							{
								duration2 = (debugTimeSkippedOnline_ = new Duration());
								builder8 = debugTimeSkippedOnline_;
							}
							input.ReadMessage(builder8);
						}
						if ((long)duration2 == 314)
						{
							MapField<int, int> mapField3 = memoryShards_;
							MapField<int, int>.Codec map_memoryShards_codec = _map_memoryShards_codec;
							((MapField<TKey, TValue>)(object)mapField3).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_memoryShards_codec);
						}
						if ((long)duration2 != 320)
						{
							goto IL_08ac;
						}
						num6 = (randomMasterSeed_ = input.ReadInt32());
					}
					if (num6 == 290)
					{
						MapField<int, DesignMap> mapField4 = maleClothingDesigns_;
						MapField<int, DesignMap>.Codec map_maleClothingDesigns_codec = _map_maleClothingDesigns_codec;
						((MapField<TKey, TValue>)(object)mapField4).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_maleClothingDesigns_codec);
					}
					int num7 = default(int);
					if (num6 == 296)
					{
						num7 = (nextClothingDesignID_ = input.ReadInt32());
					}
					if (num7 != 304)
					{
						goto IL_08ac;
					}
					num8 = (clothingDesignLimitReachedCount_ = input.ReadInt32());
				}
				int num9 = default(int);
				if (num8 > 250)
				{
					if (num8 > 266)
					{
						if (num8 == 272)
						{
							num9 = (nextFurnitureDesignID_ = input.ReadInt32());
						}
						if (num9 != 282)
						{
							goto IL_08ac;
						}
						MapField<int, DesignMap> mapField5 = femaleClothingDesigns_;
						MapField<int, DesignMap>.Codec map_femaleClothingDesigns_codec = _map_femaleClothingDesigns_codec;
						((MapField<TKey, TValue>)(object)mapField5).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_femaleClothingDesigns_codec);
					}
					if (num9 == 258)
					{
						MapField<int, DesignMap> mapField6 = furnitureDesigns_;
						MapField<int, DesignMap>.Codec map_furnitureDesigns_codec = _map_furnitureDesigns_codec;
						((MapField<TKey, TValue>)(object)mapField6).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_furnitureDesigns_codec);
					}
					if (num9 != 266)
					{
						goto IL_08ac;
					}
					MapField<int, Furniture> mapField7 = furnitureData_;
					MapField<int, Furniture>.Codec map_furnitureData_codec = _map_furnitureData_codec;
					((MapField<TKey, TValue>)(object)mapField7).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_furnitureData_codec);
				}
				MegaEventProgress megaEventProgress = default(MegaEventProgress);
				if (num9 == 226)
				{
					MegaEventProgress builder9 = default(MegaEventProgress);
					if (megaEventProgress_ == null)
					{
						megaEventProgress = (megaEventProgress_ = new MegaEventProgress());
						builder9 = megaEventProgress_;
					}
					input.ReadMessage(builder9);
				}
				CampaignHistoryData campaignHistoryData = default(CampaignHistoryData);
				if ((long)megaEventProgress == 242)
				{
					CampaignHistoryData builder10 = default(CampaignHistoryData);
					if (campaignHistory_ == null)
					{
						campaignHistoryData = (campaignHistory_ = new CampaignHistoryData());
						builder10 = campaignHistory_;
					}
					input.ReadMessage(builder10);
				}
				if ((long)campaignHistoryData != 250)
				{
					goto IL_08ac;
				}
				BattlePassStatesData builder11 = default(BattlePassStatesData);
				if (battlePassStates_ == null)
				{
					BattlePassStatesData battlePassStatesData = (battlePassStates_ = new BattlePassStatesData());
					builder11 = battlePassStates_;
				}
				input.ReadMessage(builder11);
			}
			Cookbook cookbook = default(Cookbook);
			if ((int)num > 112)
			{
				int num10 = default(int);
				if ((int)num > 162)
				{
					RoyalDutyProgress royalDutyProgress = default(RoyalDutyProgress);
					if ((int)num > 186)
					{
						MiniEventStatesData miniEventStatesData = default(MiniEventStatesData);
						if ((int)num > 202)
						{
							if (num == 210)
							{
								RepeatedField<AchievementData> repeatedField2 = achievementsData_;
								FieldCodec<AchievementData> repeated_achievementsData_codec = _repeated_achievementsData_codec;
								((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_achievementsData_codec);
							}
							if (num != 218)
							{
								goto IL_08ac;
							}
							MiniEventStatesData builder12 = default(MiniEventStatesData);
							if (miniEventStates_ == null)
							{
								miniEventStatesData = (miniEventStates_ = new MiniEventStatesData());
								builder12 = miniEventStates_;
							}
							input.ReadMessage(builder12);
						}
						if ((long)miniEventStatesData == 194)
						{
							RoyalDutyProgress builder13 = default(RoyalDutyProgress);
							if (royalDutyProgress_ == null)
							{
								royalDutyProgress = (royalDutyProgress_ = new RoyalDutyProgress());
								builder13 = royalDutyProgress_;
							}
							input.ReadMessage(builder13);
						}
						if ((long)royalDutyProgress != 202)
						{
							goto IL_08ac;
						}
						RepeatedField<CollectionSet> repeatedField3 = collectionSets_;
						FieldCodec<CollectionSet> repeated_collectionSets_codec = _repeated_collectionSets_codec;
						((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_collectionSets_codec);
					}
					if ((long)royalDutyProgress == 168)
					{
						num10 = (currentPet_ = input.ReadInt32());
					}
					if (num10 == 178)
					{
						MapField<int, FishRecord> mapField8 = fishRecords_;
						MapField<int, FishRecord>.Codec map_fishRecords_codec = _map_fishRecords_codec;
						((MapField<TKey, TValue>)(object)mapField8).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_fishRecords_codec);
					}
					if (num10 != 186)
					{
						goto IL_08ac;
					}
					MapField<int, DutyList> mapField9 = dutySlots_;
					MapField<int, DutyList>.Codec map_dutySlots_codec = _map_dutySlots_codec;
					((MapField<TKey, TValue>)(object)mapField9).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_dutySlots_codec);
				}
				if (num10 > 138)
				{
					if (num10 > 146)
					{
						if (num10 == 154)
						{
							RepeatedField<Buff> repeatedField4 = buffs_;
							FieldCodec<Buff> repeated_buffs_codec = _repeated_buffs_codec;
							((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_buffs_codec);
						}
						if (num10 != 162)
						{
							goto IL_08ac;
						}
						RepeatedField<Pet> repeatedField5 = pets_;
						FieldCodec<Pet> repeated_pets_codec = _repeated_pets_codec;
						((RepeatedField<T>)(object)repeatedField5).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_pets_codec);
					}
					num10 += -144;
					if (num10 != -3)
					{
						goto IL_08ac;
					}
					RepeatedField<int> repeatedField6 = unlockedCraftingRecipes_;
					FieldCodec<int> repeated_unlockedCraftingRecipes_codec = _repeated_unlockedCraftingRecipes_codec;
					((RepeatedField<T>)(object)repeatedField6).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_unlockedCraftingRecipes_codec);
				}
				bool flag = default(bool);
				if (num10 == 120)
				{
					flag = (transferDone_ = input.ReadBool());
				}
				if (flag)
				{
					Cookbook builder14 = default(Cookbook);
					if (cookbook_ == null)
					{
						cookbook = (cookbook_ = new Cookbook());
						builder14 = cookbook_;
					}
					input.ReadMessage(builder14);
				}
				if ((long)cookbook != 138)
				{
					goto IL_08ac;
				}
				RepeatedField<CookingHistory> repeatedField7 = cookingHistory_;
				FieldCodec<CookingHistory> repeated_cookingHistory_codec = _repeated_cookingHistory_codec;
				((RepeatedField<T>)(object)repeatedField7).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_cookingHistory_codec);
			}
			int num11 = default(int);
			if ((long)cookbook > 56)
			{
				Avatar avatar2 = default(Avatar);
				if ((long)cookbook > 80)
				{
					bool flag2 = default(bool);
					if ((long)cookbook > 98)
					{
						Avatar avatar = default(Avatar);
						if ((long)cookbook == 106)
						{
							Avatar builder15 = default(Avatar);
							if (maleAvatar_ == null)
							{
								avatar = (maleAvatar_ = new Avatar());
								builder15 = maleAvatar_;
							}
							input.ReadMessage(builder15);
						}
						if ((long)avatar != 112)
						{
							goto IL_08ac;
						}
						flag2 = (avatarIsMale_ = input.ReadBool());
					}
					bool flag3 = default(bool);
					if (flag2)
					{
						flag3 = (manaHasAlreadyMissed_ = input.ReadBool());
					}
					if (!flag3)
					{
						goto IL_08ac;
					}
					Avatar builder16 = default(Avatar);
					if (femaleAvatar_ == null)
					{
						avatar2 = (femaleAvatar_ = new Avatar());
						builder16 = femaleAvatar_;
					}
					input.ReadMessage(builder16);
				}
				if ((long)avatar2 == 66)
				{
					MapField<int, int> mapField10 = currencyAmounts_;
					MapField<int, int>.Codec map_currencyAmounts_codec = _map_currencyAmounts_codec;
					((MapField<TKey, TValue>)(object)mapField10).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_currencyAmounts_codec);
				}
				if ((long)avatar2 == 74)
				{
					RepeatedField<ToolInfo> repeatedField8 = tools_;
					FieldCodec<ToolInfo> repeated_tools_codec = _repeated_tools_codec;
					((RepeatedField<T>)(object)repeatedField8).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tools_codec);
				}
				if ((long)avatar2 != 80)
				{
					goto IL_08ac;
				}
				num11 = (mana_ = input.ReadInt32());
			}
			int num13 = default(int);
			if (num11 > 24)
			{
				int num12 = default(int);
				if (num11 > 40)
				{
					if (num11 == 50)
					{
						MapField<uint, ListInventory> mapField11 = listInventories_;
						MapField<uint, ListInventory>.Codec map_listInventories_codec = _map_listInventories_codec;
						((MapField<TKey, TValue>)(object)mapField11).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_listInventories_codec);
					}
					if (num11 != 56)
					{
						goto IL_08ac;
					}
					num12 = (int)(nextListInventoryID_ = (uint)input.ReadInt32());
				}
				if (num12 == 34)
				{
					MapField<uint, ContainerInventory> mapField12 = containerInventories_;
					MapField<uint, ContainerInventory>.Codec map_containerInventories_codec = _map_containerInventories_codec;
					((MapField<TKey, TValue>)(object)mapField12).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_containerInventories_codec);
				}
				if (num12 != 40)
				{
					goto IL_08ac;
				}
				num13 = (int)(nextContainerInventoryID_ = (uint)input.ReadInt32());
			}
			string text2 = default(string);
			if (num13 == 10)
			{
				text2 = (Name = input.ReadString());
			}
			int num14 = default(int);
			if ((long)text2 == 16)
			{
				num14 = (level_ = input.ReadInt32());
			}
			if (num14 == 24)
			{
				int num15 = (xp_ = input.ReadInt32());
			}
			goto IL_08ac;
			IL_08ac:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005083")]
		[Cpp2IlInjected.Address(RVA = "0x9682B0", Offset = "0x966CB0", VA = "0x1809682B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 99)
			{
				string text = name_;
			}
			if (fieldNumber == 110)
			{
				MapField<string, Timestamp> mapField = timestamps_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005084")]
		[Cpp2IlInjected.Address(RVA = "0x9709D0", Offset = "0x96F3D0", VA = "0x1809709D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001f, IL_002f, IL_0037, IL_003f, IL_0047, IL_004f, IL_0057, IL_005f, IL_0067, IL_006f, IL_0077, IL_007f, IL_0087, IL_008f, IL_0097, IL_009f, IL_00a7, IL_00af, IL_00b7, IL_00e3
			//IL_001e: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			while (true)
			{
				if (fieldNumber - 1 <= 99)
				{
					int num = 0;
					if (value != null && value == null)
					{
						break;
					}
					Name = (string)num;
					return;
				}
				if (fieldNumber != 110)
				{
					while (fieldNumber != 200)
					{
					}
					if (value == null || value != null)
					{
					}
					throw new InvalidCastException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005085")]
		[Cpp2IlInjected.Address(RVA = "0x964DA0", Offset = "0x9637A0", VA = "0x180964DA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0022, IL_0023, IL_0024, IL_0025, IL_0034
			if (fieldNumber - 1 <= 99)
			{
				int num = 0;
				Name = "";
				return;
			}
			if (fieldNumber == 110)
			{
			}
			if (fieldNumber != 200)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005086")]
		[Cpp2IlInjected.Address(RVA = "0x9669C0", Offset = "0x9653C0", VA = "0x1809669C0")]
		public static Item GetActiveStoreFrontCurrencyAlt(Item currencyItem)
		{
			return GetActiveStoreFrontCurrencyAlt(currencyItem.ItemID);
		}

		[Cpp2IlInjected.Token(Token = "0x6005087")]
		[Cpp2IlInjected.Address(RVA = "0x9666C0", Offset = "0x9650C0", VA = "0x1809666C0")]
		public static Item GetActiveStoreFrontCurrencyAlt(int currencyID)
		{
			//Discarded unreachable code: IL_007b
			StoreFrontGroup activeStoreGroup = StoreFrontGroup.CurrentStoreFrontGroup;
			if ((long)activeStoreGroup == 0)
			{
				return Item.Invalid;
			}
			int num = 0;
			IEnumerable<StoreFrontSpecificCurrencyItemData> all = (IEnumerable<StoreFrontSpecificCurrencyItemData>)StoreFrontSpecificCurrencyItemData.GetAll();
			Func<StoreFrontSpecificCurrencyItemData, bool> func = (Func<StoreFrontSpecificCurrencyItemData, bool>)(object)(Func<T, TResult>)delegate(StoreFrontSpecificCurrencyItemData x)
			{
				//Discarded unreachable code: IL_002d
				if ((IntPtr)x.EmulatedCurrencyItem != (IntPtr)currencyID)
				{
					int num2 = 0;
				}
				StoreFrontGroup storeFrontGroup = activeStoreGroup;
				string specificTo_ = x.specificTo_;
				string uniqueName_ = storeFrontGroup.uniqueName_;
				return specificTo_.Equals(uniqueName_);
			};
			IEnumerable<StoreFrontSpecificCurrencyItemData> enumerable = (IEnumerable<StoreFrontSpecificCurrencyItemData>)Enumerable.Where<StoreFrontSpecificCurrencyItemData>((IEnumerable<>)all, (Func<, >)(object)func);
			Func<StoreFrontSpecificCurrencyItemData, Item> func2 = default(Func<StoreFrontSpecificCurrencyItemData, Item>);
			if (_003C_003Ec._003C_003E9__294_1 == null)
			{
				func2 = (Func<StoreFrontSpecificCurrencyItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(StoreFrontSpecificCurrencyItemData y)
				{
					int iD = y.ID;
					throw new NullReferenceException();
				});
			}
			return Enumerable.FirstOrDefault<Item>(Enumerable.Select<StoreFrontSpecificCurrencyItemData, Item>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
		}

		[Cpp2IlInjected.Token(Token = "0x6005089")]
		[Cpp2IlInjected.Address(RVA = "0x9646E0", Offset = "0x9630E0", VA = "0x1809646E0")]
		internal AddRemoveItemResult CanAddCurrency(Item currency, int amount)
		{
			//Discarded unreachable code: IL_0025
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Currency)
			{
				CurrencyType currencyType = default(CurrencyType);
				if (currencyType == CurrencyType.Limited)
				{
					MapField<int, int> mapField = currencyAmounts_;
					LimitedCurrencyItemData limitedCurrencyItemData = default(LimitedCurrencyItemData);
					int maximumAmount_ = limitedCurrencyItemData.maximumAmount_;
					if ((long)(IntPtr)mapField > (long)maximumAmount_)
					{
						return AddRemoveItemResult.InventoryFull;
					}
				}
				int num = 0;
			}
			return AddRemoveItemResult.InvalidItem;
		}

		[Cpp2IlInjected.Token(Token = "0x600508A")]
		[Cpp2IlInjected.Address(RVA = "0x9624E0", Offset = "0x960EE0", VA = "0x1809624E0")]
		internal AddRemoveItemResult AddCurrency(Item currency, int amount, IPlayerEventDispatcher dispatcher, [Optional] AddDetail detail)
		{
			//Discarded unreachable code: IL_0069
			//IL_003e: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			//IL_0060: Expected I4, but got O
			int itemID = currency.ItemID;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Currency)
			{
				CurrencyType currencyType = default(CurrencyType);
				if (currencyType == CurrencyType.Limited)
				{
					MapField<int, int> mapField = currencyAmounts_;
					int valueOrDefault = ProtoExtensions.GetValueOrDefault<int, int>((MapField<, >)(object)mapField, itemID);
					LimitedCurrencyItemData limitedCurrencyItemData = default(LimitedCurrencyItemData);
					int maximumAmount_ = limitedCurrencyItemData.maximumAmount_;
					if ((long)(IntPtr)mapField > (long)maximumAmount_)
					{
						return AddRemoveItemResult.InventoryFull;
					}
				}
				bool flag = ((MapField<TKey, TValue>)(object)currencyAmounts_).ContainsKey((TKey)itemID);
				MapField<int, int> mapField2 = currencyAmounts_;
				if (!flag)
				{
					((MapField<TKey, TValue>)(object)mapField2).Add((TKey)itemID, (TValue)amount);
				}
				int num = (int)((MapField<TKey, TValue>)(object)mapField2)[(TKey)itemID];
				if (dispatcher != null)
				{
				}
				int num2 = 0;
			}
			return AddRemoveItemResult.InvalidItem;
		}

		[Cpp2IlInjected.Token(Token = "0x600508B")]
		[Cpp2IlInjected.Address(RVA = "0x9623A0", Offset = "0x960DA0", VA = "0x1809623A0")]
		internal void AddCurrencies(Dictionary<Item, int> currencies, IPlayerEventDispatcher dispatcher)
		{
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600508C")]
		[Cpp2IlInjected.Address(RVA = "0x972610", Offset = "0x971010", VA = "0x180972610")]
		internal int SpendStoreFrontSpecificCurrency(Item currencyItem, int amount)
		{
			//Discarded unreachable code: IL_0056
			//IL_0038: Expected O, but got I4
			//IL_003a: Expected I4, but got O
			//IL_0054: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			int itemID = currencyItem.ItemID;
			int result = 0;
			Item activeStoreFrontCurrencyAlt = GetActiveStoreFrontCurrencyAlt(itemID);
			bool flag = default(bool);
			if (flag)
			{
				MapField<int, int> mapField = currencyAmounts_;
				int num = default(int);
				itemID = num;
				MapField<int, int> mapField2 = currencyAmounts_;
				int itemID2 = activeStoreFrontCurrencyAlt.ItemID;
				int num2 = (int)((MapField<TKey, TValue>)(object)mapField2)[(TKey)itemID2];
				num2 -= num;
				int itemID3 = activeStoreFrontCurrencyAlt.ItemID;
				((MapField<TKey, TValue>)(object)mapField2)[(TKey)itemID3] = (TValue)num2;
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600508D")]
		[Cpp2IlInjected.Address(RVA = "0x972100", Offset = "0x970B00", VA = "0x180972100")]
		internal unsafe AddRemoveItemResult SpendCurrency(Item currencyItem, int amount, IPlayerEventDispatcher dispatcher, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			//IL_002c: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_0090: Expected I4, but got O
			//IL_00ab: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				int num2 = 0;
				if ((object)CurrencyItem.SoftCurrencyItem != null)
				{
					int num3 = 0;
					int itemID = CurrencyItem.SoftCurrencyItem.ItemID;
					bool flag2 = ((MapField<TKey, TValue>)(object)currencyAmounts_).TryGetValue((TKey)itemID, out *(TValue*)num);
					int storeFrontSpecificCurrencyAmount = GetStoreFrontSpecificCurrencyAmount(itemID);
					num += storeFrontSpecificCurrencyAmount;
					itemID = amount;
					int hardCurrencyPriceForSoftCurrency = GetHardCurrencyPriceForSoftCurrency(itemID);
					int num4 = 0;
					itemID = hardCurrencyPriceForSoftCurrency;
					Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
					AddRemoveItemResult addRemoveItemResult = default(AddRemoveItemResult);
					if (addRemoveItemResult == AddRemoveItemResult.Success)
					{
					}
				}
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				MapField<int, int> mapField = currencyAmounts_;
				int val = default(int);
				int num5 = Math.Min(val, amount);
				MapField<int, int> mapField2 = currencyAmounts_;
				Item item = default(Item);
				int itemID2 = item.ItemID;
				int num6 = (int)((MapField<TKey, TValue>)(object)mapField2)[(TKey)itemID2];
				num6 -= num5;
				int itemID3 = item.ItemID;
				((MapField<TKey, TValue>)(object)mapField2)[(TKey)itemID3] = (TValue)num6;
			}
			MapField<int, int> mapField3 = currencyAmounts_;
			bool flag4 = default(bool);
			if (flag4)
			{
				MapField<int, int> mapField4 = currencyAmounts_;
				int num7 = num7 - amount;
			}
			if (dispatcher != null)
			{
			}
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600508E")]
		[Cpp2IlInjected.Address(RVA = "0x972090", Offset = "0x970A90", VA = "0x180972090")]
		internal AddRemoveItemResult SpendCurrency(CurrencyCost cost, IPlayerEventDispatcher dispatcher, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			//Discarded unreachable code: IL_0009
			Item item = cost.Item;
			AddRemoveItemResult result = default(AddRemoveItemResult);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600508F")]
		[Cpp2IlInjected.Address(RVA = "0x971E80", Offset = "0x970880", VA = "0x180971E80")]
		internal bool SpendCurrencies(Dictionary<Item, int> currencies, IPlayerEventDispatcher dispatcher, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			int num = 0;
			bool buyMissingSoftCurrencyWithHardCurrency2 = (byte)num != 0;
			Func<KeyValuePair<Item, int>, bool> func = (Func<KeyValuePair<Item, int>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				ProfilePlayer profilePlayer = this;
				bool result = default(bool);
				return result;
			};
			bool flag = ((IEnumerable<>)currencies).All<KeyValuePair<Item, int>>((Func<, >)(object)func);
			if (!flag)
			{
				return flag;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005090")]
		[Cpp2IlInjected.Address(RVA = "0x971C80", Offset = "0x970680", VA = "0x180971C80")]
		internal bool SpendCurrencies(RepeatedField<CurrencyCost> costs, IPlayerEventDispatcher dispatcher, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			Func<CurrencyCost, bool> func = (Func<CurrencyCost, bool>)(object)(Func<T, TResult>)delegate(CurrencyCost x)
			{
				//Discarded unreachable code: IL_0017
				ProfilePlayer profilePlayer = this;
				bool buyMissingSoftCurrencyWithHardCurrency2 = buyMissingSoftCurrencyWithHardCurrency;
				return profilePlayer.HasEnoughCurrency(x, buyMissingSoftCurrencyWithHardCurrency2);
			};
			bool flag = ((IEnumerable<>)(object)costs).All<CurrencyCost>((Func<, >)(object)func);
			if (!flag)
			{
				return flag;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005091")]
		[Cpp2IlInjected.Address(RVA = "0x967D50", Offset = "0x966750", VA = "0x180967D50")]
		public unsafe int GetCurrencyAmount(int currencyItemID, bool genericCurrencyOnly = false)
		{
			//Discarded unreachable code: IL_0024
			//IL_0011: Expected O, but got I4
			MapField<int, int> mapField = currencyAmounts_;
			int num = 0;
			bool flag = ((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)currencyItemID, out *(TValue*)num);
			if (!genericCurrencyOnly)
			{
				int storeFrontSpecificCurrencyAmount = GetStoreFrontSpecificCurrencyAmount(currencyItemID);
				num += storeFrontSpecificCurrencyAmount;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005092")]
		[Cpp2IlInjected.Address(RVA = "0x967D40", Offset = "0x966740", VA = "0x180967D40")]
		public int GetCurrencyAmount(Item currencyItem, bool genericCurrencyOnly = false)
		{
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005093")]
		[Cpp2IlInjected.Address(RVA = "0x96A8E0", Offset = "0x9692E0", VA = "0x18096A8E0")]
		public int GetStoreFrontSpecificCurrencyAmount(Item currencyItem)
		{
			int itemID = GetActiveStoreFrontCurrencyAlt(currencyItem.ItemID).ItemID;
			return GetCurrencyAmount(itemID, genericCurrencyOnly: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6005094")]
		[Cpp2IlInjected.Address(RVA = "0x96A8E0", Offset = "0x9692E0", VA = "0x18096A8E0")]
		public int GetStoreFrontSpecificCurrencyAmount(int currencyItemID)
		{
			int itemID = GetActiveStoreFrontCurrencyAlt(currencyItemID).ItemID;
			return GetCurrencyAmount(itemID, genericCurrencyOnly: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6005095")]
		[Cpp2IlInjected.Address(RVA = "0x967D30", Offset = "0x966730", VA = "0x180967D30")]
		public int GetCurrencyAmountAllStore(Item currencyItem)
		{
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005096")]
		[Cpp2IlInjected.Address(RVA = "0x967AF0", Offset = "0x9664F0", VA = "0x180967AF0")]
		public unsafe int GetCurrencyAmountAllStore(int currencyItemID)
		{
			//Discarded unreachable code: IL_0063, IL_0069, IL_006f
			//IL_000f: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0045: Expected I4, but got I8
			int num = 0;
			bool flag = ((MapField<TKey, TValue>)(object)currencyAmounts_).TryGetValue((TKey)currencyItemID, out *(TValue*)num);
			int num2 = 0;
			IEnumerable<StoreFrontSpecificCurrencyItemData> all = (IEnumerable<StoreFrontSpecificCurrencyItemData>)StoreFrontSpecificCurrencyItemData.GetAll();
			int price = default(int);
			int currencyAmount = default(int);
			if (all != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_004c;
					}
					num++;
				}
				Item item = default(Item);
				while ((IntPtr)item != (IntPtr)currencyItemID)
				{
				}
				price = ((glPlayFab.Disney.BattlePassReward)num).Price;
				ulong num4 = default(ulong);
				currencyAmount = GetCurrencyAmount(price, (byte)num4 != 0);
				num += currencyAmount;
				goto IL_004c;
			}
			goto IL_005d;
			IL_004c:
			price += price;
			currencyAmount += 312;
			goto IL_005d;
			IL_005d:
			if (all != null)
			{
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005097")]
		[Cpp2IlInjected.Address(RVA = "0x967DF0", Offset = "0x9667F0", VA = "0x180967DF0")]
		public Dictionary<int, int> GetCurrentAmountPerStore(Item currencyItem)
		{
			Dictionary<int, int> result = default(Dictionary<int, int>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005098")]
		[Cpp2IlInjected.Address(RVA = "0x967E00", Offset = "0x966800", VA = "0x180967E00")]
		public Dictionary<int, int> GetCurrentAmountPerStore(int currencyItemID)
		{
			//Discarded unreachable code: IL_0053, IL_0059, IL_005f, IL_0065
			//IL_003e: Expected I4, but got I8
			int num = 0;
			Dictionary<int, int> result = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();
			int num2 = 0;
			IEnumerable<StoreFrontSpecificCurrencyItemData> all = (IEnumerable<StoreFrontSpecificCurrencyItemData>)StoreFrontSpecificCurrencyItemData.GetAll();
			if (all != null)
			{
				uint num3 = default(uint);
				int num4 = default(int);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						num4 += num4;
						goto IL_004d;
					}
					num++;
				}
				Item item = default(Item);
				while ((IntPtr)item != (IntPtr)currencyItemID)
				{
				}
				num4 = item.ItemID;
				ulong num5 = default(ulong);
				int currencyAmount = GetCurrencyAmount(num4, (byte)num5 != 0);
				throw new NullReferenceException();
			}
			goto IL_004d;
			IL_004d:
			if (all != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005099")]
		[Cpp2IlInjected.Address(RVA = "0x9676B0", Offset = "0x9660B0", VA = "0x1809676B0")]
		public unsafe Dictionary<Item, int> GetCurrencies()
		{
			//Discarded unreachable code: IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6
			//IL_004f: Expected O, but got I4
			//IL_0068: Expected I4, but got I8
			Dictionary<Item, int> result;
			uint num2 = default(uint);
			uint num3 = default(uint);
			uint num4 = default(uint);
			ulong num5 = default(ulong);
			int num;
			do
			{
				num = 0;
				result = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				IEnumerable<IItemData> allByType = (IEnumerable<IItemData>)ItemDatabase.Instance.GetAllByType(ItemType.Currency);
				if (allByType != null)
				{
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							num += num;
							num += num;
							num += num;
							goto IL_0081;
						}
						num++;
					}
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					if (num < (int)num4)
					{
						num += num;
						num++;
					}
					bool flag = ((MapField<TKey, TValue>)(object)currencyAmounts_).TryGetValue((TKey)num, out *(TValue*)num);
					int itemID = GetActiveStoreFrontCurrencyAlt(num).ItemID;
					int currencyAmount = GetCurrencyAmount(itemID, (byte)num5 != 0);
					num += currencyAmount;
					throw new NullReferenceException();
				}
				goto IL_0081;
				IL_0081:
				if (allByType != null)
				{
				}
			}
			while (num != 0);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600509A")]
		[Cpp2IlInjected.Address(RVA = "0x96AFC0", Offset = "0x9699C0", VA = "0x18096AFC0")]
		public bool HasEnoughCurrency(Item currencyItem, int amount, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			//Discarded unreachable code: IL_0045
			MapField<int, int> mapField = currencyAmounts_;
			bool flag = default(bool);
			if (flag)
			{
				MapField<int, int> mapField2 = currencyAmounts_;
				int num2 = default(int);
				ulong num = num + (ulong)num2;
				if (buyMissingSoftCurrencyWithHardCurrency)
				{
					int num3 = 0;
					if ((object)CurrencyItem.SoftCurrencyItem != null && (long)num < (long)amount)
					{
						int num4 = 0;
						Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
						int hardCurrencyPriceForSoftCurrency = GetHardCurrencyPriceForSoftCurrency(amount);
						bool result = default(bool);
						return result;
					}
				}
			}
			return amount == 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600509B")]
		[Cpp2IlInjected.Address(RVA = "0x96B1D0", Offset = "0x969BD0", VA = "0x18096B1D0")]
		public bool HasEnoughCurrency(CurrencyCost cost, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			//Discarded unreachable code: IL_0009
			Item item = cost.Item;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600509C")]
		[Cpp2IlInjected.Address(RVA = "0x96ADE0", Offset = "0x9697E0", VA = "0x18096ADE0")]
		public bool HasEnoughCurrencies(Dictionary<Item, int> currencies, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			//Discarded unreachable code: IL_0029
			Func<KeyValuePair<Item, int>, bool> func = (Func<KeyValuePair<Item, int>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				ProfilePlayer profilePlayer = this;
				bool result = default(bool);
				return result;
			};
			return ((IEnumerable<>)currencies).All<KeyValuePair<Item, int>>((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600509D")]
		[Cpp2IlInjected.Address(RVA = "0x96AED0", Offset = "0x9698D0", VA = "0x18096AED0")]
		public bool HasEnoughCurrencies(IEnumerable<CurrencyCost> costs, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			//Discarded unreachable code: IL_0029
			Func<CurrencyCost, bool> func = (Func<CurrencyCost, bool>)(object)(Func<T, TResult>)delegate(CurrencyCost x)
			{
				//Discarded unreachable code: IL_0017
				ProfilePlayer profilePlayer = this;
				bool buyMissingSoftCurrencyWithHardCurrency2 = buyMissingSoftCurrencyWithHardCurrency;
				return profilePlayer.HasEnoughCurrency(x, buyMissingSoftCurrencyWithHardCurrency2);
			};
			return ((IEnumerable<>)costs).All<CurrencyCost>((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600509E")]
		[Cpp2IlInjected.Address(RVA = "0x968900", Offset = "0x967300", VA = "0x180968900")]
		public int GetHardCurrencyPriceForSoftCurrency(int amount)
		{
			//Discarded unreachable code: IL_001d
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = 0;
			int itemID = CurrencyItem.SoftCurrencyItem.ItemID;
			itemID = amount;
			SoftCurrencyItemData softCurrencyItemData = default(SoftCurrencyItemData);
			return softCurrencyItemData.GetHardCurrencyPriceForSoftCurrency(itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x600509F")]
		[Cpp2IlInjected.Address(RVA = "0x96B230", Offset = "0x969C30", VA = "0x18096B230")]
		public bool HasEnoughHardCurrencyToBuySoftCurrency(int amount)
		{
			int num = 0;
			Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			int hardCurrencyPriceForSoftCurrency = GetHardCurrencyPriceForSoftCurrency(amount);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60050A0")]
		[Cpp2IlInjected.Address(RVA = "0x96CAB0", Offset = "0x96B4B0", VA = "0x18096CAB0")]
		public bool IsValidCurrencyId(int currencyId)
		{
			//Discarded unreachable code: IL_000d
			//IL_000c: Expected O, but got I4
			return ((MapField<TKey, TValue>)(object)currencyAmounts_).ContainsKey((TKey)currencyId);
		}

		[Cpp2IlInjected.Token(Token = "0x60050A1")]
		[Cpp2IlInjected.Address(RVA = "0x969D90", Offset = "0x968790", VA = "0x180969D90")]
		public unsafe int GetMissingCurrency(int currencyId, int amount)
		{
			//Discarded unreachable code: IL_0035
			//IL_000c: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			if (!((MapField<TKey, TValue>)(object)currencyAmounts_).ContainsKey((TKey)currencyId))
			{
			}
			MapField<int, int> mapField = currencyAmounts_;
			int num = 0;
			bool flag = ((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)currencyId, out *(TValue*)num);
			int storeFrontSpecificCurrencyAmount = GetStoreFrontSpecificCurrencyAmount(currencyId);
			num += storeFrontSpecificCurrencyAmount;
			int num2 = 0;
			return storeFrontSpecificCurrencyAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x60050A2")]
		[Cpp2IlInjected.Address(RVA = "0x969EC0", Offset = "0x9688C0", VA = "0x180969EC0")]
		public unsafe int GetMissingCurrency(CurrencyCost cost)
		{
			//IL_001a: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			int id_ = cost.id_;
			int amount_ = cost.amount_;
			if (!((MapField<TKey, TValue>)(object)currencyAmounts_).ContainsKey((TKey)id_))
			{
			}
			MapField<int, int> mapField = currencyAmounts_;
			int num = 0;
			bool flag = ((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)id_, out *(TValue*)num);
			int storeFrontSpecificCurrencyAmount = GetStoreFrontSpecificCurrencyAmount(id_);
			num += storeFrontSpecificCurrencyAmount;
			amount_ -= num;
			id_ = amount_;
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050A3")]
		[Cpp2IlInjected.Address(RVA = "0x96B2C0", Offset = "0x969CC0", VA = "0x18096B2C0")]
		public bool HasEnoughMana(int amount)
		{
			return (long)(IntPtr)_repeated_collectionSets_codec >= (long)amount;
		}

		[Cpp2IlInjected.Token(Token = "0x60050A4")]
		[Cpp2IlInjected.Address(RVA = "0x962C60", Offset = "0x961660", VA = "0x180962C60")]
		internal void AddMana(int amount, IPlayerEventDispatcher dispatcher, AddManaContext addManaContext = AddManaContext.Default)
		{
			//Discarded unreachable code: IL_00ab
			//IL_008e: Expected I4, but got I8
			//IL_0098: Expected I4, but got I8
			//IL_00a1: Expected I4, but got O
			int level = level_;
			int maximumManaAmountForLevel = GetMaximumManaAmountForLevel(level);
			if (addManaContext == AddManaContext.Meal || addManaContext == AddManaContext.Refill)
			{
				int level2 = level_;
				int maximumManaAmountForLevel2 = GetMaximumManaAmountForLevel(level2);
				ManaData manaData = ManaData;
				ulong num = num + num;
				num += (ulong)maximumManaAmountForLevel2;
			}
			level = maximumManaAmountForLevel;
			int num2 = mana_;
			if (maximumManaAmountForLevel > num2)
			{
				int origin_ = 0;
				mana_ = maximumManaAmountForLevel;
				if (dispatcher != null)
				{
					bool flag = addManaContext == AddManaContext.Refill;
				}
				if (maximumManaAmountForLevel > maximumManaAmountForLevel)
				{
					float exceedingManaMoveSpeedMultiplier_ = ManaData.exceedingManaMoveSpeedMultiplier_;
					Buff buff = new Buff();
					buff.origin_ = (BuffOrigin)origin_;
					buff.type_ = BuffType.AvatarMovementSpeedMultiplier;
					buff.persistence_ = BuffPersistence.Transient;
					buff.percentageEffect_ = (int)buff;
					AddBuff(buff, dispatcher);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050A5")]
		[Cpp2IlInjected.Address(RVA = "0x962B60", Offset = "0x961560", VA = "0x180962B60")]
		internal void AddManaMoveSpeedBuff(IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_003e
			//IL_001b: Expected I4, but got I8
			//IL_0025: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			//IL_0035: Expected I4, but got O
			float exceedingManaMoveSpeedMultiplier_ = ManaData.exceedingManaMoveSpeedMultiplier_;
			Buff buff = new Buff();
			buff.origin_ = BuffOrigin.Default;
			buff.type_ = BuffType.AvatarMovementSpeedMultiplier;
			buff.persistence_ = BuffPersistence.Transient;
			buff.percentageEffect_ = (int)buff;
			AddBuff(buff, dispatcher);
		}

		[Cpp2IlInjected.Token(Token = "0x60050A6")]
		[Cpp2IlInjected.Address(RVA = "0x9724F0", Offset = "0x970EF0", VA = "0x1809724F0")]
		internal bool SpendMana(int amount, int rawAmount, ManaData.Types.ManaSpendingActionType manaSpendingActionType, IPlayerEventDispatcher dispatcher)
		{
			int num = mana_;
			num = (mana_ = num - amount);
			ProfileEventDispatcher.ManaSpentData manaSpentData = new ProfileEventDispatcher.ManaSpentData();
			manaSpentData.ManaCost = amount;
			manaSpentData.UnmodifiedManaCost = rawAmount;
			manaSpentData.Type = manaSpendingActionType;
			int num2 = mana_;
			int level = level_;
			int maximumManaAmountForLevel = GetMaximumManaAmountForLevel(level);
			if (num > maximumManaAmountForLevel)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050A7")]
		[Cpp2IlInjected.Address(RVA = "0x969C70", Offset = "0x968670", VA = "0x180969C70")]
		public int GetMaximumManaAmountForLevel(int level)
		{
			//Discarded unreachable code: IL_0045
			int level2 = level;
			if (level != 0)
			{
				RepeatedField<PlayerLevel> playerLevels_ = PlayerInfo.playerLevels_;
				Func<PlayerLevel, bool> func = (Func<PlayerLevel, bool>)(object)(Func<T, TResult>)delegate(PlayerLevel x)
				{
					//Discarded unreachable code: IL_0011
					int num = level2;
					return x.level_ == num;
				};
				return Enumerable.FirstOrDefault<PlayerLevel>((IEnumerable<>)(object)playerLevels_, (Func<, >)(object)func)?.maximumManaAmount_ ?? int.MaxValue;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60050A8")]
		[Cpp2IlInjected.Address(RVA = "0x969C20", Offset = "0x968620", VA = "0x180969C20")]
		public int GetMaximumExceedingManaAmountForLevel(int level)
		{
			int maximumManaAmountForLevel = GetMaximumManaAmountForLevel(level);
			ManaData manaData = ManaData;
			ulong num = num + num;
			num += (ulong)maximumManaAmountForLevel;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050A9")]
		[Cpp2IlInjected.Address(RVA = "0x96C620", Offset = "0x96B020", VA = "0x18096C620")]
		public bool IsManaAutoFillUnlocked(IProfile profile, ITransactionContext context)
		{
			ManaData manaData;
			do
			{
				manaData = ManaData;
			}
			while (manaData == null);
			ConditionsList autoFillOnLoadUnlockCondition_ = manaData.autoFillOnLoadUnlockCondition_;
			if (autoFillOnLoadUnlockCondition_ != null)
			{
				bool flag = autoFillOnLoadUnlockCondition_.Evaluate(profile, context);
				return 0 == 1;
			}
			return (long)autoFillOnLoadUnlockCondition_ == 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60050B8")]
		[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0", Slot = "27")]
		bool IProfilePlayer.ManaHasAlreadyMissed()
		{
			return manaHasAlreadyMissed_;
		}

		[Cpp2IlInjected.Token(Token = "0x60050B9")]
		[Cpp2IlInjected.Address(RVA = "0x969A20", Offset = "0x968420", VA = "0x180969A20")]
		public RepeatedField<ItemReward> GetLevelRewards(int currentLevel, int newLevel)
		{
			//Discarded unreachable code: IL_0018, IL_001e, IL_0024
			RepeatedField<ItemReward> result = (RepeatedField<ItemReward>)(object)new RepeatedField<T>();
			RepeatedField<PlayerLevel> playerLevels_ = PlayerInfo.playerLevels_;
			bool flag = default(bool);
			if (flag)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60050BA")]
		[Cpp2IlInjected.Address(RVA = "0x963050", Offset = "0x961A50", VA = "0x180963050")]
		internal void AddPlayerXp(int amount, in Player player, ITransactionContext context, AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_00ac, IL_00b2
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			int num = 0;
			int num2 = level_;
			int num3 = xp_;
			int levelForXp = GetLevelForXp(xp_ = num3 + amount);
			uint num4 = default(uint);
			if (player.dispatcher != null && num < (int)num4)
			{
				num += num;
				num++;
			}
			level_ = levelForXp;
			if (levelForXp <= num2)
			{
				return;
			}
			num3 = num2;
			RepeatedField<ItemReward> levelRewards = (RepeatedField<ItemReward>)(object)this.GetLevelRewards(num3, levelForXp);
			bool flag = default(bool);
			if (flag)
			{
				IPlayerEventDispatcher dispatcher = player.dispatcher;
				if (dispatcher == null)
				{
					dispatcher = (IPlayerEventDispatcher)(object)((object)dispatcher + (object)dispatcher);
				}
				int num5 = 0;
			}
			int num6 = 0;
			MultiReward multiReward = new MultiReward((IEnumerable<>)(object)levelRewards);
			ManaData manaData = default(ManaData);
			int num9 = default(int);
			if (manaData != null)
			{
				if (manaData.autoFillOnLoadUnlockCondition_ != null)
				{
				}
				if (num6 != 1)
				{
					int num7 = default(int);
					multiReward = (MultiReward)(multiReward - num7);
					int num8 = 0;
					num9 = 0;
					int num10 = num10 + num7;
				}
			}
			if (num9 != 0)
			{
				uint num11 = num11 - (uint)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050BB")]
		[Cpp2IlInjected.Address(RVA = "0x971A50", Offset = "0x970450", VA = "0x180971A50")]
		internal void SetLevel(int level, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0065
			int num = level_;
			level_ = level;
			int level2 = level;
			if (level != 0)
			{
				RepeatedField<PlayerLevel> playerLevels_ = PlayerInfo.playerLevels_;
				Func<PlayerLevel, bool> func = (Func<PlayerLevel, bool>)(object)(Func<T, TResult>)delegate(PlayerLevel x)
				{
					//Discarded unreachable code: IL_0011
					int num4 = level2;
					return x.level_ == num4;
				};
				if (Enumerable.FirstOrDefault<PlayerLevel>((IEnumerable<>)(object)playerLevels_, (Func<, >)(object)func) == null)
				{
				}
			}
			int num2 = 0;
			int num3 = level_;
			xp_ = num2;
			if (num3 > num && dispatcher != null)
			{
				num3 -= num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050BC")]
		[Cpp2IlInjected.Address(RVA = "0x9690E0", Offset = "0x967AE0", VA = "0x1809690E0", Slot = "19")]
		public int GetItemAmount(Item item, [Optional] ItemState state)
		{
			return GetItemAmount(item, state, includePantry: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60050BD")]
		[Cpp2IlInjected.Address(RVA = "0x969100", Offset = "0x967B00", VA = "0x180969100")]
		public int GetItemAmount(Item item, ItemState state, bool includePantry)
		{
			//Discarded unreachable code: IL_007a, IL_0080
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType <= (ItemType)7)
			{
				ListInventory buildings = Buildings;
				bool flag = default(bool);
				if (flag)
				{
					ContainerInventory backpack = Backpack;
					if (includePantry)
					{
						ContainerInventory homeStorage = HomeStorage;
						int num3 = default(int);
						int num2 = num2 + num3;
						ICollection<ContainerInventory> values = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)containerInventories_).get_Values();
						if (values != null)
						{
							ContainerInventory backpack2 = Backpack;
							while (values == backpack2)
							{
							}
							ContainerInventory homeStorage2 = HomeStorage;
							while (values == homeStorage2)
							{
							}
							int num4 = default(int);
							num2 += num4;
						}
						if (values != null)
						{
						}
						bool flag2 = default(bool);
						if (!flag2)
						{
						}
					}
					bool flag3 = default(bool);
					bool flag4 = default(bool);
					if (flag3 && !flag4)
					{
					}
				}
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60050BE")]
		[Cpp2IlInjected.Address(RVA = "0x9694E0", Offset = "0x967EE0", VA = "0x1809694E0")]
		public int GetItemsQuantityFromBackpack(ItemFilter filter, bool useDifferentItem, bool includeStorage = false, bool includePantry = false)
		{
			//Discarded unreachable code: IL_0080, IL_0086, IL_008c
			//IL_005b: Expected O, but got I4
			int num = 0;
			_003CGetBackpackInventory_003Ed__380 _003CGetBackpackInventory_003Ed__;
			if (filter.data_.type_ == ItemType.ActivityItem)
			{
				List<Dictionary<(Item, ItemState), int>> list = (List<Dictionary<(Item, ItemState), int>>)(object)new List<T>();
				_003CGetBackpackInventory_003Ed__ = new _003CGetBackpackInventory_003Ed__380(-2);
				_003CGetBackpackInventory_003Ed__._003C_003E4__this = this;
				_003CGetBackpackInventory_003Ed__._003C_003E3__includeStorage = includeStorage;
				_003CGetBackpackInventory_003Ed__._003C_003E3__includePantry = false;
				if (_003CGetBackpackInventory_003Ed__ != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_005b;
						}
						num++;
					}
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					((List<T>)(object)list).Add((T)num);
					goto IL_005b;
				}
				goto IL_0073;
			}
			throw new NullReferenceException();
			IL_0073:
			if (_003CGetBackpackInventory_003Ed__ != null)
			{
			}
			int result = default(int);
			return result;
			IL_005b:
			num += num;
			num += 312;
			num += num;
			num += 312;
			goto IL_0073;
		}

		[Cpp2IlInjected.Token(Token = "0x60050BF")]
		[Cpp2IlInjected.Address(RVA = "0x9671E0", Offset = "0x965BE0", VA = "0x1809671E0")]
		[IteratorStateMachine(typeof(_003CGetBackpackInventory_003Ed__380))]
		private IEnumerable<IInventory> GetBackpackInventory(bool includeStorage = false, bool includePantry = false)
		{
			_003CGetBackpackInventory_003Ed__380 _003CGetBackpackInventory_003Ed__ = new _003CGetBackpackInventory_003Ed__380(-2);
			_003CGetBackpackInventory_003Ed__._003C_003E4__this = this;
			_003CGetBackpackInventory_003Ed__._003C_003E3__includeStorage = includeStorage;
			_003CGetBackpackInventory_003Ed__._003C_003E3__includePantry = includePantry;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050C0")]
		[Cpp2IlInjected.Address(RVA = "0x96AC30", Offset = "0x969630", VA = "0x18096AC30")]
		public bool HasAnyItem(List<Item> items, int amount = 1)
		{
			//Discarded unreachable code: IL_0029
			Func<Item, bool> cpp2il__autoParamName__idx_ = (Func<Item, bool>)(object)(Func<T, TResult>)delegate(Item x)
			{
				//Discarded unreachable code: IL_0017
				ProfilePlayer profilePlayer = this;
				int amount2 = amount;
				return profilePlayer.HasItem(x, amount2);
			};
			return ((IEnumerable<>)items).Any<Item>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x60050C1")]
		[Cpp2IlInjected.Address(RVA = "0x96AB40", Offset = "0x969540", VA = "0x18096AB40")]
		public bool HasAllItems(List<Item> items, int amount = 1)
		{
			//Discarded unreachable code: IL_0029
			Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate(Item x)
			{
				//Discarded unreachable code: IL_0017
				ProfilePlayer profilePlayer = this;
				int amount2 = amount;
				return profilePlayer.HasItem(x, amount2);
			};
			return ((IEnumerable<>)items).All<Item>((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60050C2")]
		[Cpp2IlInjected.Address(RVA = "0x96B2E0", Offset = "0x969CE0", VA = "0x18096B2E0", Slot = "24")]
		public bool HasItem(Item item, int amount = 1)
		{
			//Discarded unreachable code: IL_00d6, IL_00dc, IL_00e2, IL_00e8
			int num = 0;
			int num2 = 0;
			if ((object)typeof(Item).TypeHandle == null)
			{
				ItemType itemType = default(ItemType);
				if (itemType > ItemType.Currency)
				{
					if (itemType == ItemType.Tool)
					{
					}
					if (itemType != ItemType.Upgrade)
					{
						goto IL_0036;
					}
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_00cd;
					}
				}
				if (itemType == ItemType.Currency)
				{
					MapField<int, int> mapField = currencyAmounts_;
					int num3 = default(int);
					num += num3;
				}
				goto IL_0036;
			}
			goto IL_00cd;
			IL_006b:
			num++;
			ICollection<ListInventory> values;
			if (values != null)
			{
			}
			if (num != 0)
			{
				ContainerInventory backpack = Backpack;
				ContainerInventory homeStorage = HomeStorage;
				ICollection<ContainerInventory> values2 = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)containerInventories_).get_Values();
				if (values2 != null)
				{
					ContainerInventory backpack2 = Backpack;
					while (values2 == backpack2)
					{
					}
					ContainerInventory homeStorage2 = HomeStorage;
					while (values2 == homeStorage2)
					{
					}
				}
				if (values2 != null)
				{
				}
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				ListInventory buildings = Buildings;
				bool flag3 = default(bool);
				if (!flag3)
				{
				}
			}
			goto IL_00cd;
			IL_0036:
			values = (ICollection<ListInventory>)((MapField<TKey, TValue>)(object)listInventories_).get_Values();
			if (values != null)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_0063;
					}
					num++;
				}
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				num++;
				goto IL_0063;
			}
			goto IL_006b;
			IL_00cd:
			int num5 = 0;
			throw new NullReferenceException();
			IL_0063:
			num += 312;
			goto IL_006b;
		}

		[Cpp2IlInjected.Token(Token = "0x60050C3")]
		[Cpp2IlInjected.Address(RVA = "0x96FCF0", Offset = "0x96E6F0", VA = "0x18096FCF0")]
		internal void RemoveItem(Item item, int amount, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0010, IL_001c, IL_0028, IL_002c
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType <= (ItemType)7)
			{
				ContainerInventory backpack = Backpack;
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050C4")]
		[Cpp2IlInjected.Address(RVA = "0x96F940", Offset = "0x96E340", VA = "0x18096F940")]
		internal AddRemoveItemResult RemoveClothingItem(Item item)
		{
			//Discarded unreachable code: IL_005c
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Clothing)
			{
				AvatarRules _003CInstance_003Ek__BackingField = AvatarRules.Instance;
				bool flag = default(bool);
				if (!flag)
				{
					MapField<int, DesignMap> mapField = maleClothingDesigns_;
					MapField<int, int> clothingCustomization_ = maleAvatar_.clothingCustomization_;
					MapField<int, DesignMap> mapField2 = femaleClothingDesigns_;
					MapField<int, int> clothingCustomization_2 = femaleAvatar_.clothingCustomization_;
					AvatarWorkingCopy avatarWorkingCopy = new AvatarWorkingCopy(maleAvatar_, isMale: true);
					int isMale = default(int);
					AvatarWorkingCopy avatarWorkingCopy2 = new AvatarWorkingCopy(femaleAvatar_, (byte)isMale != 0);
					isMale = 0;
					int num = 0;
				}
			}
			return AddRemoveItemResult.InvalidItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60050C5")]
		[Cpp2IlInjected.Address(RVA = "0x972C90", Offset = "0x971690", VA = "0x180972C90")]
		private void UnlinkDesigns(Item item, bool isMale)
		{
			//Discarded unreachable code: IL_002f
			//IL_0017: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			int itemID = item.ItemID;
			if (isMale)
			{
			}
			bool flag = ((MapField<TKey, TValue>)(object)femaleClothingDesigns_).Remove((TKey)itemID);
			if (isMale)
			{
			}
			bool flag2 = ((MapField<TKey, TValue>)(object)femaleAvatar_.clothingCustomization_).Remove((TKey)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x60050C6")]
		[Cpp2IlInjected.Address(RVA = "0x96F7C0", Offset = "0x96E1C0", VA = "0x18096F7C0")]
		private void RemoveClothingItemAvatar(Item item, AvatarWorkingCopy avatar)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				AvatarRules _003CInstance_003Ek__BackingField = AvatarRules.Instance;
				Item item2 = default(Item);
				if ((object)item2 == null)
				{
					bool flag3 = avatar.SetClothes(item2);
				}
				Avatar _003CData_003Ek__BackingField = avatar.Data;
				if (avatar.IsMale)
				{
					throw new NullReferenceException();
				}
				femaleAvatar_ = _003CData_003Ek__BackingField;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050C7")]
		[Cpp2IlInjected.Address(RVA = "0x96FEF0", Offset = "0x96E8F0", VA = "0x18096FEF0")]
		internal AddRemoveItemResult RemoveMakeupItem(Item item)
		{
			//Discarded unreachable code: IL_0077
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Makeup)
			{
				AvatarWorkingCopy avatarWorkingCopy = new AvatarWorkingCopy(maleAvatar_, isMale: true);
				bool flag = default(bool);
				if (flag)
				{
					Avatar _003CData_003Ek__BackingField = avatarWorkingCopy.Data;
					if (!avatarWorkingCopy.IsMale)
					{
						femaleAvatar_ = _003CData_003Ek__BackingField;
					}
					maleAvatar_ = _003CData_003Ek__BackingField;
				}
				int isMale = default(int);
				AvatarWorkingCopy avatarWorkingCopy2 = new AvatarWorkingCopy(femaleAvatar_, (byte)isMale != 0);
				isMale = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
					Avatar _003CData_003Ek__BackingField2 = avatarWorkingCopy2.Data;
					if (!avatarWorkingCopy2.IsMale)
					{
						femaleAvatar_ = _003CData_003Ek__BackingField2;
					}
					maleAvatar_ = _003CData_003Ek__BackingField2;
				}
				int num = 0;
			}
			return AddRemoveItemResult.InvalidItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60050C8")]
		[Cpp2IlInjected.Address(RVA = "0x96FE50", Offset = "0x96E850", VA = "0x18096FE50")]
		private void RemoveMakeupItemAvatar(MakeupItem makeupItem, AvatarWorkingCopy avatar)
		{
			bool flag = default(bool);
			if (flag)
			{
				Avatar _003CData_003Ek__BackingField = avatar.Data;
				if (avatar.IsMale)
				{
					throw new NullReferenceException();
				}
				femaleAvatar_ = _003CData_003Ek__BackingField;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050C9")]
		[Cpp2IlInjected.Address(RVA = "0x964920", Offset = "0x963320", VA = "0x180964920")]
		internal bool CanAddTool(Item item)
		{
			bool flag = default(bool);
			ToolInfo toolInfo = default(ToolInfo);
			if (flag && toolInfo == null)
			{
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60050CA")]
		[Cpp2IlInjected.Address(RVA = "0x963630", Offset = "0x962030", VA = "0x180963630")]
		internal bool AddTool(Item item, IPlayerEventDispatcher dispatcher)
		{
			int itemID = item.ItemID;
			int num = 0;
			bool flag = default(bool);
			ToolInfo toolInfo = default(ToolInfo);
			if (flag && toolInfo == null)
			{
				RepeatedField<ToolInfo> repeatedField = tools_;
				ToolInfo item2 = default(ToolInfo);
				((RepeatedField<T>)(object)repeatedField).Add((T)item2);
				uint num2 = default(uint);
				if (dispatcher != null && num < (int)num2)
				{
					num += num;
					num++;
				}
				repeatedField = (RepeatedField<ToolInfo>)(object)((object)repeatedField + (object)repeatedField);
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050CB")]
		[Cpp2IlInjected.Address(RVA = "0x9634B0", Offset = "0x961EB0", VA = "0x1809634B0")]
		internal bool AddToolUpgrade(Item toolItem, Item upgradeItem, IPlayerEventDispatcher dispatcher)
		{
			//IL_001b: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			int itemID = upgradeItem.ItemID;
			int itemID2 = toolItem.ItemID;
			Item toolItem2 = (Item)itemID2;
			RepeatedField<ToolInfo> repeatedField = tools_;
			Func<ToolInfo, bool> func = (Func<ToolInfo, bool>)(object)(Func<T, TResult>)delegate(ToolInfo t)
			{
				//Discarded unreachable code: IL_0011
				Item item = toolItem2;
				return (IntPtr)t.toolItemID_ == (IntPtr)item;
			};
			ToolInfo toolInfo = Enumerable.FirstOrDefault<ToolInfo>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (toolInfo != null && !((RepeatedField<T>)(object)toolInfo.upgradeItemIDs_).Contains((T)itemID))
			{
				((RepeatedField<T>)(object)toolInfo.upgradeItemIDs_).Add((T)itemID);
				if (dispatcher != null)
				{
				}
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050CC")]
		[Cpp2IlInjected.Address(RVA = "0x96CA10", Offset = "0x96B410", VA = "0x18096CA10", Slot = "21")]
		public bool IsToolUnlocked(Item item)
		{
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			ToolInfo toolInfo = default(ToolInfo);
			return toolInfo != null;
		}

		[Cpp2IlInjected.Token(Token = "0x60050CD")]
		[Cpp2IlInjected.Address(RVA = "0x96CA90", Offset = "0x96B490", VA = "0x18096CA90")]
		public bool IsToolUnlocked(ToolItemType toolItemType)
		{
			return FindTool(toolItemType) != null;
		}

		[Cpp2IlInjected.Token(Token = "0x60050CE")]
		[Cpp2IlInjected.Address(RVA = "0x966330", Offset = "0x964D30", VA = "0x180966330")]
		public ToolInfo FindTool(ToolItemType toolItemType)
		{
			//Discarded unreachable code: IL_002b
			RepeatedField<ToolInfo> repeatedField = tools_;
			Func<ToolInfo, bool> func = (Func<ToolInfo, bool>)(object)(Func<T, TResult>)delegate(ToolInfo x)
			{
				//Discarded unreachable code: IL_0011
				int toolItemID_ = x.toolItemID_;
				ToolItemType toolItemType2 = default(ToolItemType);
				return toolItemType2 == toolItemType;
			};
			return Enumerable.FirstOrDefault<ToolInfo>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60050CF")]
		[Cpp2IlInjected.Address(RVA = "0x96BEC0", Offset = "0x96A8C0", VA = "0x18096BEC0")]
		public bool HasToolAndUpgrade(ToolItemType toolItemType, Item upgradeItem)
		{
			//Discarded unreachable code: IL_000c
			ToolInfo toolInfo = default(ToolInfo);
			if (toolInfo == null)
			{
			}
			if (toolInfo != null)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60050D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0", Slot = "14")]
		public IContainerInventoryProvider GetContainerInventoryProvider()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60050D1")]
		[Cpp2IlInjected.Address(RVA = "0x965300", Offset = "0x963D00", VA = "0x180965300", Slot = "31")]
		uint IContainerInventoryProvider.AddContainerInventory(Item parentItem, string containerInventoryDefaultData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60050D2")]
		[Cpp2IlInjected.Address(RVA = "0x965640", Offset = "0x964040", VA = "0x180965640", Slot = "32")]
		void IContainerInventoryProvider.RemoveContainerInventory(uint containerInventoryID)
		{
			//Discarded unreachable code: IL_001a, IL_001b, IL_0021
			//IL_0017: Expected O, but got I4
			MapField<uint, ContainerInventory> mapField = containerInventories_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = ((MapField<TKey, TValue>)(object)containerInventories_).Remove((TKey)containerInventoryID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050D3")]
		[Cpp2IlInjected.Address(RVA = "0x965F60", Offset = "0x964960", VA = "0x180965F60")]
		internal void FindOrphanedContainerInventories(GridCollection gridCollection)
		{
			//Discarded unreachable code: IL_006d, IL_0073, IL_0079, IL_007f, IL_0085, IL_008b, IL_0091, IL_0097
			//IL_001c: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			ICollection<> collection = default(ICollection<>);
			ContainerInventory containerInventory = default(ContainerInventory);
			ContainerInventory containerInventory2 = default(ContainerInventory);
			IEnumerable<IGrid> allGrids;
			StorageGridData storageGridData = default(StorageGridData);
			StorageGridData storageGridData2 = default(StorageGridData);
			while (true)
			{
				int num = 0;
				HashSet<uint> hashSet = (HashSet<uint>)(object)new HashSet<T>((IEqualityComparer<>)collection);
				int num2 = 0;
				uint iD_ = containerInventory.iD_;
				bool flag = ((HashSet<T>)(object)hashSet).Remove((T)iD_);
				uint iD_2 = containerInventory2.iD_;
				bool flag2 = ((HashSet<T>)(object)hashSet).Remove((T)iD_2);
				allGrids = (IEnumerable<IGrid>)gridCollection.get_AllGrids();
				if (allGrids == null)
				{
					break;
				}
				if (allGrids != null)
				{
					if (0 == 0)
					{
						continue;
					}
					while (storageGridData == null)
					{
					}
					uint containerInventoryID_ = storageGridData2.containerInventoryID_;
					bool flag3 = ((HashSet<T>)(object)hashSet).Remove((T)containerInventoryID_);
				}
				if (allGrids == null)
				{
				}
				break;
			}
			if (allGrids != null)
			{
				int num3 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050D5")]
		[Cpp2IlInjected.Address(RVA = "0x96CB10", Offset = "0x96B510", VA = "0x18096CB10")]
		public bool IsWearing(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_0018
			if ((long)_map_furnitureData_codec != 0)
			{
			}
			return femaleAvatar_.IsWearing(clothingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60050D6")]
		[Cpp2IlInjected.Address(RVA = "0x96CB40", Offset = "0x96B540", VA = "0x18096CB40", Slot = "20")]
		public bool IsWearing(Item item)
		{
			//Discarded unreachable code: IL_0018
			if ((long)_map_furnitureData_codec != 0)
			{
			}
			return femaleAvatar_.IsWearing(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60050D7")]
		[Cpp2IlInjected.Address(RVA = "0x965780", Offset = "0x964180", VA = "0x180965780")]
		public bool IsRecipeUnlocked(Item recipeItem)
		{
			//Discarded unreachable code: IL_000d
			return cookbook_.IsRecipeUnlocked(recipeItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60050D8")]
		[Cpp2IlInjected.Address(RVA = "0x96BA70", Offset = "0x96A470", VA = "0x18096BA70", Slot = "23")]
		public bool HasRecipeInCookbookWith(int minStarRating)
		{
			//Discarded unreachable code: IL_000d
			return cookbook_.HasRecipeUnlockedWith(minStarRating);
		}

		[Cpp2IlInjected.Token(Token = "0x60050D9")]
		[Cpp2IlInjected.Address(RVA = "0x972D40", Offset = "0x971740", VA = "0x180972D40")]
		internal bool UnlockCraftingRecipe(Item item)
		{
			//Discarded unreachable code: IL_0027
			//IL_0025: Expected O, but got I4
			int itemID = item.ItemID;
			int num = ProtoExtensions.BinarySearch<int>((RepeatedField<>)(object)unlockedCraftingRecipes_, itemID);
			RepeatedField<int> repeatedField = unlockedCraftingRecipes_;
			itemID = num;
			((RepeatedField<T>)(object)repeatedField).Insert(itemID, (T)itemID);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60050DA")]
		[Cpp2IlInjected.Address(RVA = "0x96C530", Offset = "0x96AF30", VA = "0x18096C530", Slot = "25")]
		public bool IsCraftingRecipeUnlocked(Item item)
		{
			int itemID = item.ItemID;
			int num = ProtoExtensions.BinarySearch<int>((RepeatedField<>)(object)unlockedCraftingRecipes_, itemID);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60050DB")]
		[Cpp2IlInjected.Address(RVA = "0x96BFA0", Offset = "0x96A9A0", VA = "0x18096BFA0")]
		public bool IsCraftingRecipeAvailable(Item item, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			Func<(CraftingRecipeItemData, int), CraftingRecipeItemData> func = default(Func<(CraftingRecipeItemData, int), CraftingRecipeItemData>);
			if (_003C_003Ec._003C_003E9__412_0 == null)
			{
				func = (Func<(CraftingRecipeItemData, int), CraftingRecipeItemData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			List<(CraftingRecipeItemData, int)> list = default(List<(CraftingRecipeItemData, int)>);
			List<CraftingRecipeItemData> list2 = (List<CraftingRecipeItemData>)(object)Enumerable.ToList<CraftingRecipeItemData>(Enumerable.Select<(CraftingRecipeItemData, int), CraftingRecipeItemData>((IEnumerable<>)list, (Func<, >)(object)func));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050DC")]
		[Cpp2IlInjected.Address(RVA = "0x96C230", Offset = "0x96AC30", VA = "0x18096C230")]
		public bool IsCraftingRecipeAvailable(CraftingRecipeItemData data, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0032
			Func<(CraftingRecipeItemData, int), CraftingRecipeItemData> _003C_003E9__412_ = _003C_003Ec._003C_003E9__412_0;
			if (_003C_003E9__412_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			List<(CraftingRecipeItemData, int)> list = default(List<(CraftingRecipeItemData, int)>);
			return ((List<T>)(object)Enumerable.ToList<CraftingRecipeItemData>(Enumerable.Select<(CraftingRecipeItemData, int), CraftingRecipeItemData>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__412_))).Contains((T)data);
		}

		[Cpp2IlInjected.Token(Token = "0x60050DD")]
		[Cpp2IlInjected.Address(RVA = "0x96C3E0", Offset = "0x96ADE0", VA = "0x18096C3E0")]
		public bool IsCraftingRecipeAvailable(CraftingRecipeItemData data, int amount, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			Func<(CraftingRecipeItemData, int), bool> func = (Func<(CraftingRecipeItemData, int), bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0015
				int iD_ = data.iD_;
				return (IntPtr)"{il2cpp field on {'constant1' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x18}" == (IntPtr)iD_;
			};
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050DE")]
		[Cpp2IlInjected.Address(RVA = "0x967060", Offset = "0x965A60", VA = "0x180967060")]
		public List<CraftingRecipeItemData> GetAvailableCraftingRecipes(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			List<(CraftingRecipeItemData, int)> availableCraftingRecipesInfo = (List<(CraftingRecipeItemData, int)>)(object)this.GetAvailableCraftingRecipesInfo(ref playerProfile, ref worldProfile, context);
			Func<(CraftingRecipeItemData, int), CraftingRecipeItemData> _003C_003E9__412_ = _003C_003Ec._003C_003E9__412_0;
			if (_003C_003E9__412_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			return (List<CraftingRecipeItemData>)(object)Enumerable.ToList<CraftingRecipeItemData>(Enumerable.Select<(CraftingRecipeItemData, int), CraftingRecipeItemData>((IEnumerable<>)availableCraftingRecipesInfo, (Func<, >)(object)_003C_003E9__412_));
		}

		[Cpp2IlInjected.Token(Token = "0x60050DF")]
		[Cpp2IlInjected.Address(RVA = "0x966A60", Offset = "0x965460", VA = "0x180966A60")]
		public List<(CraftingRecipeItemData, int)> GetAvailableCraftingRecipesInfo(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00a5, IL_00c9, IL_00ce, IL_00da, IL_00e2, IL_00e8
			//IL_00da: Expected O, but got I4
			int num = 0;
			IProfileWorld section = worldProfile.Section;
			Func<ProfileWorld.FilterInfo, IEnumerable<MissionObjective>> _003C_003E9__413_ = _003C_003Ec._003C_003E9__413_0;
			if (_003C_003E9__413_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo x)
				{
					List<MissionObjective> _003CObjectives_003Ek__BackingField = x.Objectives;
					throw new NullReferenceException();
				};
			}
			IEnumerable<ProfileWorld.FilterInfo> enumerable = default(IEnumerable<ProfileWorld.FilterInfo>);
			MissionObjective[] craftingObjectives = Enumerable.SelectMany<ProfileWorld.FilterInfo, MissionObjective>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__413_).ToArray<MissionObjective>();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			List<CraftingRecipeItemData> recipes = (List<CraftingRecipeItemData>)(object)Enumerable.ToList<CraftingRecipeItemData>(enumerable2);
			List<CraftingRecipeItemData> list = recipes;
			Func<CraftingRecipeItemData, (CraftingRecipeItemData, int)> func = default(Func<CraftingRecipeItemData, (CraftingRecipeItemData, int)>);
			if (_003C_003Ec._003C_003E9__413_1 == null)
			{
				func = (Func<CraftingRecipeItemData, (CraftingRecipeItemData, int)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num2 = 0;
					/*Error: Unexpected end of block*/;
				});
			}
			return (List<(CraftingRecipeItemData, int)>)(object)Enumerable.ToList<(CraftingRecipeItemData, int)>(Enumerable.Select<CraftingRecipeItemData, (CraftingRecipeItemData, int)>((IEnumerable<>)list, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x60050E0")]
		[Cpp2IlInjected.Address(RVA = "0x972E10", Offset = "0x971810", VA = "0x180972E10")]
		internal bool UnlockPet(Item item, IPlayerEventDispatcher dispatcher, [Optional] AddDetail detail)
		{
			int itemID = item.ItemID;
			int num = 0;
			bool flag = default(bool);
			CompanionItemType companionItemType = default(CompanionItemType);
			bool flag2 = default(bool);
			if (flag && companionItemType == CompanionItemType.Pet && !flag2)
			{
				Pet pet = new Pet();
				pet.PetItemID = itemID;
				((RepeatedField<T>)(object)pets_).Add((T)pet);
				uint num2 = default(uint);
				if (dispatcher != null && num < (int)num2)
				{
					num += num;
					num++;
				}
				if (((RepeatedField<T>)(object)pets_).Count != 1)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050E1")]
		[Cpp2IlInjected.Address(RVA = "0x9700C0", Offset = "0x96EAC0", VA = "0x1809700C0")]
		internal bool RemovePet(Item item, IPlayerEventDispatcher dispatcher)
		{
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			bool flag = default(bool);
			CompanionItemType companionItemType = default(CompanionItemType);
			if (flag && companionItemType == CompanionItemType.Pet)
			{
				Item item3 = item2;
				if (IsPetUnlocked(item3))
				{
					Item item4 = item2;
					if ((IntPtr)currentPet_ == (IntPtr)item4)
					{
						Item invalid = Item.Invalid;
						ChangeCurrentPet(invalid, dispatcher);
					}
					RepeatedField<Pet> repeatedField = pets_;
					Func<Pet, bool> func = (Func<Pet, bool>)(object)(Func<T, TResult>)delegate(Pet x)
					{
						//Discarded unreachable code: IL_0011
						Item item6 = item2;
						return (IntPtr)x.petItemID_ == (IntPtr)item6;
					};
					Pet item5 = Enumerable.FirstOrDefault<Pet>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
					bool flag2 = ((RepeatedField<T>)(object)pets_).Remove((T)item5);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050E2")]
		[Cpp2IlInjected.Address(RVA = "0x9649A0", Offset = "0x9633A0", VA = "0x1809649A0")]
		internal void ChangeCurrentPet(Item petItem, IPlayerEventDispatcher dispatcher)
		{
			int itemID = petItem.ItemID;
			int num = currentPet_;
			currentPet_ = itemID;
			if (dispatcher == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050E3")]
		[Cpp2IlInjected.Address(RVA = "0x96C900", Offset = "0x96B300", VA = "0x18096C900")]
		internal bool IsPetUnlocked(Item item)
		{
			//Discarded unreachable code: IL_0030
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			RepeatedField<Pet> repeatedField = pets_;
			Predicate<Pet> predicate = (Predicate<Pet>)(object)(Predicate<T>)delegate(Pet x)
			{
				Item petItem = x.PetItem;
				throw new NullReferenceException();
			};
			return ProtoExtensions.Exists<Pet>((RepeatedField<>)(object)repeatedField, (Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60050E4")]
		[Cpp2IlInjected.Address(RVA = "0x96C890", Offset = "0x96B290", VA = "0x18096C890")]
		internal bool IsPetItem(Item item)
		{
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			CompanionItemType companionItemType = default(CompanionItemType);
			return companionItemType == CompanionItemType.Pet;
		}

		[Cpp2IlInjected.Token(Token = "0x60050E5")]
		[Cpp2IlInjected.Address(RVA = "0x96C5B0", Offset = "0x96AFB0", VA = "0x18096C5B0", Slot = "29")]
		public bool IsFtueEventCompleted(Item ftueItem)
		{
			//Discarded unreachable code: IL_0013
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Ftue)
			{
				int num = 0;
			}
			RepeatedField<int> repeatedField = completedFtueEvents_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60050E6")]
		[Cpp2IlInjected.Address(RVA = "0x96C700", Offset = "0x96B100", VA = "0x18096C700")]
		public unsafe bool IsMemoryShardCompleted(Item item)
		{
			//IL_0018: Expected O, but got I4
			int itemID = item.ItemID;
			MapField<int, int> mapField = memoryShards_;
			int num = 0;
			if (((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)itemID, out *(TValue*)num))
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				MemoryShardItemData memoryShardItemData = default(MemoryShardItemData);
				if (memoryShardItemData != null)
				{
					int completedShardFlag = memoryShardItemData.CompletedShardFlag;
				}
				return num == num;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050E7")]
		[Cpp2IlInjected.Address(RVA = "0x964860", Offset = "0x963260", VA = "0x180964860")]
		internal bool CanAddMemoryShard(Item item, ItemState itemState)
		{
			if (itemState != null && itemState.stateCase_ == ItemState.StateOneofCase.MemoryShardIndex)
			{
				MapField<int, int> mapField = memoryShards_;
				bool flag = default(bool);
				if (flag)
				{
					int memoryShardIndex = itemState.MemoryShardIndex;
				}
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050E8")]
		[Cpp2IlInjected.Address(RVA = "0x962E90", Offset = "0x961890", VA = "0x180962E90")]
		internal AddRemoveItemResult AddMemoryShard(Item item, IPlayerEventDispatcher dispatcher, ItemState itemState, AddDetail detail)
		{
			//Discarded unreachable code: IL_0048
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.MemoryShard && itemState != null && itemState.stateCase_ == ItemState.StateOneofCase.MemoryShardIndex)
			{
				MapField<int, int> mapField = memoryShards_;
				bool flag = default(bool);
				if (!flag)
				{
					MapField<int, int> mapField2 = memoryShards_;
				}
				int memoryShardIndex = itemState.MemoryShardIndex;
				MapField<int, int> mapField3 = memoryShards_;
				if (dispatcher != null)
				{
					int memoryShardIndex2 = itemState.MemoryShardIndex;
				}
				int num2 = 0;
			}
			return AddRemoveItemResult.InvalidItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60050E9")]
		[Cpp2IlInjected.Address(RVA = "0x96B9D0", Offset = "0x96A3D0", VA = "0x18096B9D0")]
		public bool HasMemoryShard(Item memoryShardItem, int memoryShardIndex)
		{
			MapField<int, int> mapField = memoryShards_;
			bool flag = default(bool);
			if (flag)
			{
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050EA")]
		[Cpp2IlInjected.Address(RVA = "0x969FF0", Offset = "0x9689F0", VA = "0x180969FF0")]
		private int GetOrAddRandomSeed(string key)
		{
			//IL_001a: Expected I4, but got I8
			MapField<string, int> mapField = randomSeeds_;
			bool flag = default(bool);
			if (!flag)
			{
				int hashCode = key.GetHashCode();
				ulong num = default(ulong);
				return SetNextRandomSeed(key, (int)num);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050EB")]
		[Cpp2IlInjected.Address(RVA = "0x971BC0", Offset = "0x9705C0", VA = "0x180971BC0")]
		private int SetNextRandomSeed(string key, int prevSeed)
		{
			//Discarded unreachable code: IL_0023
			//IL_0021: Expected O, but got I4
			int num = new Random(prevSeed).Next();
			if (num == prevSeed)
			{
				num++;
			}
			((MapField<TKey, TValue>)(object)randomSeeds_)[(TKey)key] = (TValue)num;
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60050EC")]
		[Cpp2IlInjected.Address(RVA = "0x96A0B0", Offset = "0x968AB0", VA = "0x18096A0B0")]
		public int GetRandomSeed(string key)
		{
			//Discarded unreachable code: IL_0008
			return GetOrAddRandomSeed(key);
		}

		[Cpp2IlInjected.Token(Token = "0x60050ED")]
		[Cpp2IlInjected.Address(RVA = "0x9637C0", Offset = "0x9621C0", VA = "0x1809637C0")]
		public void AdvanceRandomSeed(string key)
		{
			int orAddRandomSeed = GetOrAddRandomSeed(key);
			int num = SetNextRandomSeed(key, orAddRandomSeed);
		}

		[Cpp2IlInjected.Token(Token = "0x60050EE")]
		[Cpp2IlInjected.Address(RVA = "0x9629E0", Offset = "0x9613E0", VA = "0x1809629E0")]
		internal void AddHudApparition(HudApparitionPhases phases, in Player player, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0032
			if ((hudApparition_ = hudApparition_) != 0)
			{
				UpdateRoyalDutySlots.Types.Response response = new UpdateRoyalDutySlots.Types.Response();
				UpdateRoyalDutySlots.Types.Request request = (response.request_ = new UpdateRoyalDutySlots.Types.Request());
				if (player.dispatcher != null)
				{
					int num = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050EF")]
		[Cpp2IlInjected.Address(RVA = "0x9629E0", Offset = "0x9613E0", VA = "0x1809629E0")]
		internal void AddHudApparition(uint phases, in Player player, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0032
			if ((hudApparition_ = hudApparition_) != 0)
			{
				UpdateRoyalDutySlots.Types.Response response = new UpdateRoyalDutySlots.Types.Response();
				UpdateRoyalDutySlots.Types.Request request = (response.request_ = new UpdateRoyalDutySlots.Types.Request());
				if (player.dispatcher != null)
				{
					int num = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050F0")]
		[Cpp2IlInjected.Address(RVA = "0x96B2D0", Offset = "0x969CD0", VA = "0x18096B2D0")]
		public bool HasHudApparition(uint phases)
		{
			return hudApparition_ == phases;
		}

		[Cpp2IlInjected.Token(Token = "0x60050F1")]
		[Cpp2IlInjected.Address(RVA = "0x96B2D0", Offset = "0x969CD0", VA = "0x18096B2D0")]
		public bool HasHudApparition(HudApparitionPhases phases)
		{
			return hudApparition_ == (uint)phases;
		}

		[Cpp2IlInjected.Token(Token = "0x60050F2")]
		[Cpp2IlInjected.Address(RVA = "0x9674F0", Offset = "0x965EF0", VA = "0x1809674F0")]
		public List<CollectionInfo> GetCollectionsInfo()
		{
			//Discarded unreachable code: IL_0038
			int num = 0;
			if ((IntPtr)_collectionInfos == (IntPtr)num)
			{
				List<CollectionInfo> list = (_collectionInfos = (List<CollectionInfo>)(object)new List<T>());
				RepeatedField<CollectionSet> repeatedField = collectionSets_;
				bool flag = default(bool);
				if (flag)
				{
					CollectionInfo item = default(CollectionInfo);
					((List<T>)(object)_collectionInfos).Add((T)item);
				}
			}
			return _collectionInfos;
		}

		[Cpp2IlInjected.Token(Token = "0x60050F3")]
		[Cpp2IlInjected.Address(RVA = "0x9702A0", Offset = "0x96ECA0", VA = "0x1809702A0")]
		internal void ResumeCollectionSets(ProfileEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0022, IL_0028, IL_002e, IL_0034
			int num = 0;
			List<CollectionSet> list = (List<CollectionSet>)(object)new List<T>();
			RepeatedField<CollectionSet> repeatedField = collectionSets_;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag || !flag2)
			{
			}
			Action<CollectionSet> action = default(Action<CollectionSet>);
			((List<T>)(object)list).ForEach((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x60050F4")]
		[Cpp2IlInjected.Address(RVA = "0x96BA90", Offset = "0x96A490", VA = "0x18096BA90")]
		public bool HasTakePictureDutyAchievment()
		{
			//Discarded unreachable code: IL_00ab, IL_00b1, IL_00b7, IL_00bd, IL_00c3
			//IL_001a: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			MapField<int, DutyList> mapField = dutySlots_;
			int num4 = 0;
			if (!((MapField<TKey, TValue>)(object)mapField).ContainsKey((TKey)num4))
			{
				MapField<int, DutyList> mapField2 = dutySlots_;
				DutyList value = new DutyList();
				int num5 = 0;
				((MapField<TKey, TValue>)(object)mapField2).Add((TKey)num5, (TValue)value);
			}
			MapField<int, DutyList> mapField3 = dutySlots_;
			int num6 = 0;
			RepeatedField<DutySlot> slots_ = ((DutyList)((MapField<TKey, TValue>)(object)mapField3)[(TKey)num6]).slots_;
			bool flag = default(bool);
			if (flag)
			{
				RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
				while (royalDutyItemData == null)
				{
				}
				RepeatedField<DutyStepDifficulty> stepDifficultyLayers_ = royalDutyItemData.stepDifficultyLayers_;
				DutyStepDifficulty dutyStepDifficulty = default(DutyStepDifficulty);
				while (dutyStepDifficulty.difficultyStepCase_ != DutyStepDifficulty.DifficultyStepOneofCase.TakePicture)
				{
				}
				num3++;
			}
			if (num3 + 1 != 0)
			{
			}
			bool flag2 = default(bool);
			int num7 = default(int);
			if (flag2)
			{
				AchievementItemData achievementItemData = default(AchievementItemData);
				while (achievementItemData == null)
				{
				}
				while (achievementItemData.stepCase_ != AchievementItemData.StepOneofCase.TakePicture)
				{
				}
				num7++;
			}
			if (num7 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050F5")]
		[Cpp2IlInjected.Address(RVA = "0x96A100", Offset = "0x968B00", VA = "0x18096A100")]
		public DutyList GetRoyalDutiesList()
		{
			//Discarded unreachable code: IL_0041
			//IL_0010: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			MapField<int, DutyList> mapField = dutySlots_;
			int num = 0;
			if (!((MapField<TKey, TValue>)(object)mapField).ContainsKey((TKey)num))
			{
				MapField<int, DutyList> mapField2 = dutySlots_;
				DutyList value = new DutyList();
				int num2 = 0;
				((MapField<TKey, TValue>)(object)mapField2).Add((TKey)num2, (TValue)value);
			}
			MapField<int, DutyList> mapField3 = dutySlots_;
			int num3 = 0;
			return (DutyList)((MapField<TKey, TValue>)(object)mapField3)[(TKey)num3];
		}

		[Cpp2IlInjected.Token(Token = "0x60050F6")]
		[Cpp2IlInjected.Address(RVA = "0x96A1E0", Offset = "0x968BE0", VA = "0x18096A1E0")]
		public unsafe RoyalDutyProgress GetRoyalDutyProgress(ITransactionContext context)
		{
			//IL_0028: Expected I4, but got O
			if ((object)typeof(RoyalDutyProgress).TypeHandle == null)
			{
				Timestamp lastResetTime_ = default(Timestamp);
				(royalDutyProgress_ = new RoyalDutyProgress()).lastResetTime_ = lastResetTime_;
			}
			bool flag = default(bool);
			if (flag)
			{
				Timestamp timestamp = default(Timestamp);
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)timestamp != 0;
				int num = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050F7")]
		[Cpp2IlInjected.Address(RVA = "0x966410", Offset = "0x964E10", VA = "0x180966410")]
		public int GetAchievementsCompletePercentage()
		{
			//Discarded unreachable code: IL_0093, IL_0099, IL_009f, IL_00a5, IL_00ab, IL_00b1, IL_00b7, IL_00bd, IL_00c3
			int num = 0;
			int num2 = 0;
			int count = ((RepeatedField<T>)(object)achievementsData_).Count;
			RepeatedField<AchievementMilestone> milestones_ = default(RepeatedField<AchievementMilestone>);
			if (num < count)
			{
				AchievementData achievementData = (AchievementData)((RepeatedField<T>)(object)achievementsData_)[num];
				AchievementItemData itemData = achievementData.ItemData;
				int count2 = ((RepeatedField<T>)(object)itemData.milestones_).Count;
				if (achievementData.state_ != AchievementState.Completed)
				{
					int count3 = ((RepeatedField<T>)(object)itemData.milestones_).Count;
					if (num < count3)
					{
						AchievementMilestone achievementMilestone = (AchievementMilestone)((RepeatedField<T>)(object)itemData.milestones_)[num];
						num++;
						int milestone_ = achievementMilestone.milestone_;
					}
					num++;
				}
				milestones_ = itemData.milestones_;
				int count4 = ((RepeatedField<T>)(object)milestones_).Count;
				num++;
			}
			if (milestones_ == null)
			{
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60050F8")]
		[Cpp2IlInjected.Address(RVA = "0x965780", Offset = "0x964180", VA = "0x180965780", Slot = "22")]
		bool IProfilePlayer.IsRecipeInCookbook(Item recipeItem)
		{
			//Discarded unreachable code: IL_000d
			return cookbook_.IsRecipeUnlocked(recipeItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60050F9")]
		[Cpp2IlInjected.Address(RVA = "0x96A950", Offset = "0x969350", VA = "0x18096A950", Slot = "30")]
		public DateTime? GetTimestamp(string guid)
		{
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050FA")]
		[Cpp2IlInjected.Address(RVA = "0x962250", Offset = "0x960C50", VA = "0x180962250")]
		internal void AddBuff(BuffOrigin buffOrigin, BuffType buffType, BuffPersistence persistence, float percentageEffect, DateTime endTime, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0031
			//IL_0028: Expected I4, but got O
			Buff buff = new Buff();
			buff.origin_ = buffOrigin;
			buff.type_ = buffType;
			buff.persistence_ = persistence;
			buff.percentageEffect_ = (int)buff;
			Timestamp endTime2 = default(Timestamp);
			buff.EndTime = endTime2;
		}

		[Cpp2IlInjected.Token(Token = "0x60050FB")]
		[Cpp2IlInjected.Address(RVA = "0x961C10", Offset = "0x960610", VA = "0x180961C10")]
		internal void AddBuff(BuffOrigin buffOrigin, BuffType buffType, BuffPersistence persistence, int percentageEffect, DateTime endTime, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0031
			Buff buff = new Buff();
			buff.percentageEffect_ = 0;
			buff.origin_ = buffOrigin;
			buff.type_ = buffType;
			buff.persistence_ = persistence;
			Timestamp endTime2 = default(Timestamp);
			buff.EndTime = endTime2;
		}

		[Cpp2IlInjected.Token(Token = "0x60050FC")]
		[Cpp2IlInjected.Address(RVA = "0x961EC0", Offset = "0x9608C0", VA = "0x180961EC0")]
		internal void AddBuff(BuffOrigin buffOrigin, BuffType buffType, BuffPersistence persistence, float percentageEffect, int numberOfUses, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0029
			//IL_0028: Expected I4, but got O
			Buff buff = new Buff();
			buff.origin_ = buffOrigin;
			buff.type_ = buffType;
			buff.persistence_ = persistence;
			buff.percentageEffect_ = (int)buff;
		}

		[Cpp2IlInjected.Token(Token = "0x60050FD")]
		[Cpp2IlInjected.Address(RVA = "0x961D00", Offset = "0x960700", VA = "0x180961D00")]
		internal void AddBuff(BuffOrigin buffOrigin, BuffType buffType, BuffPersistence persistence, int percentageEffect, int numberOfUses, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0029
			Buff buff = new Buff();
			buff.percentageEffect_ = 0;
			buff.origin_ = buffOrigin;
			buff.type_ = buffType;
			buff.persistence_ = persistence;
		}

		[Cpp2IlInjected.Token(Token = "0x60050FE")]
		[Cpp2IlInjected.Address(RVA = "0x961DC0", Offset = "0x9607C0", VA = "0x180961DC0")]
		internal void AddBuff(BuffOrigin buffOrigin, BuffType buffType, BuffPersistence persistence, float percentageEffect, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0029
			//IL_0028: Expected I4, but got O
			Buff buff = new Buff();
			buff.origin_ = buffOrigin;
			buff.type_ = buffType;
			buff.persistence_ = persistence;
			buff.percentageEffect_ = (int)buff;
		}

		[Cpp2IlInjected.Token(Token = "0x60050FF")]
		[Cpp2IlInjected.Address(RVA = "0x961FD0", Offset = "0x9609D0", VA = "0x180961FD0")]
		internal void AddBuff(BuffOrigin buffOrigin, BuffType buffType, BuffPersistence persistence, int percentageEffect, IPlayerEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0029
			Buff buff = new Buff();
			buff.percentageEffect_ = 0;
			buff.origin_ = buffOrigin;
			buff.type_ = buffType;
			buff.persistence_ = persistence;
		}

		[Cpp2IlInjected.Token(Token = "0x6005100")]
		[Cpp2IlInjected.Address(RVA = "0x962080", Offset = "0x960A80", VA = "0x180962080")]
		private void AddBuff(Buff buff, IPlayerEventDispatcher dispatcher)
		{
			if (buff.type_ == BuffType.None)
			{
				return;
			}
			RepeatedField<Buff> repeatedField = buffs_;
			if (buff.persistence_ == BuffPersistence.Transient)
			{
			}
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_0057;
				}
				num++;
			}
			BuffType type_ = buff.type_;
			BuffOrigin origin_ = buff.origin_;
			int num3 = MatchingBuffCount(origin_, type_);
			if (dispatcher != null)
			{
				if (num3 != 1)
				{
					BuffType type_2 = buff.type_;
					return;
				}
				goto IL_0057;
			}
			return;
			IL_0057:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005101")]
		[Cpp2IlInjected.Address(RVA = "0x967280", Offset = "0x965C80", VA = "0x180967280")]
		public int GetBuff(BuffType buffType)
		{
			//Discarded unreachable code: IL_0093
			DateTime now = ServerUtil.NowUtc(this);
			RepeatedField<Buff> repeatedField = buffs_;
			Func<Buff, bool> func = (Func<Buff, bool>)(object)(Func<T, TResult>)delegate(Buff x)
			{
				//Discarded unreachable code: IL_002b
				BuffType buffType3 = buffType;
				if (x.type_ != buffType3)
				{
					int num2 = 0;
				}
				if (x.EndTime == null)
				{
					return true;
				}
				DateTime dateTime2 = x.EndTime.ToDateTime();
				bool result2 = default(bool);
				return result2;
			};
			IEnumerable<Buff> enumerable = (IEnumerable<Buff>)Enumerable.Where<Buff>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			List<Buff> transientBuffs = TransientBuffs;
			Func<Buff, bool> func2 = (Func<Buff, bool>)(object)(Func<T, TResult>)delegate(Buff x)
			{
				//Discarded unreachable code: IL_002b
				BuffType buffType2 = buffType;
				if (x.type_ != buffType2)
				{
					int num = 0;
				}
				if (x.EndTime == null)
				{
					return true;
				}
				DateTime dateTime = x.EndTime.ToDateTime();
				bool result = default(bool);
				return result;
			};
			IEnumerable<Buff> enumerable2 = (IEnumerable<Buff>)Enumerable.Where<Buff>((IEnumerable<>)transientBuffs, (Func<, >)(object)func2);
			IEnumerable<Buff> enumerable3 = (IEnumerable<Buff>)Enumerable.Concat<Buff>((IEnumerable<>)enumerable, (IEnumerable<>)enumerable2);
			Func<Buff, int> _003C_003E9__448_ = _003C_003Ec._003C_003E9__448_2;
			if (_003C_003E9__448_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Buff x) => x.percentageEffect_);
			}
			return Enumerable.Sum<Buff>((IEnumerable<>)enumerable3, (Func<, >)(object)_003C_003E9__448_);
		}

		[Cpp2IlInjected.Token(Token = "0x6005102")]
		[Cpp2IlInjected.Address(RVA = "0x972FF0", Offset = "0x9719F0", VA = "0x180972FF0")]
		internal bool UseBuff(BuffType buffType, IPlayerEventDispatcher dispatcher)
		{
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005103")]
		[Cpp2IlInjected.Address(RVA = "0x966A10", Offset = "0x965410", VA = "0x180966A10")]
		public IEnumerable<Buff> GetAllBuffs()
		{
			List<Buff> transientBuffs = TransientBuffs;
			return (IEnumerable<Buff>)Enumerable.Concat<Buff>((IEnumerable<>)(object)buffs_, (IEnumerable<>)transientBuffs);
		}

		[Cpp2IlInjected.Token(Token = "0x6005104")]
		[Cpp2IlInjected.Address(RVA = "0x96A3B0", Offset = "0x968DB0", VA = "0x18096A3B0")]
		public BuffDisplayData GetStaticBuffData(BuffOrigin origin, BuffType buffType)
		{
			//Discarded unreachable code: IL_00af, IL_00b5, IL_00bb, IL_00c1, IL_00c7, IL_00d3, IL_00d9
			int num = 0;
			_003C_003Ec__DisplayClass452_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass452_0();
			CS_0024_003C_003E8__locals0.origin = origin;
			CS_0024_003C_003E8__locals0.buffType = buffType;
			if (CachedStaticBuffData == null)
			{
				IEnumerable<> enumerable = (IEnumerable<>)(CachedStaticBuffData = (IEnumerable<StaticBuffData>)ProtoDatabase.Instance.Enumerate<StaticBuffData>());
				IEnumerable<StaticBuffData> cachedStaticBuffData = CachedStaticBuffData;
			}
			if (CS_0024_003C_003E8__locals0 != null)
			{
				if (CS_0024_003C_003E8__locals0._003C_003E9__0 == null)
				{
					Predicate<BuffDisplayData> predicate = (CS_0024_003C_003E8__locals0._003C_003E9__0 = (Predicate<BuffDisplayData>)(object)(Predicate<T>)delegate(BuffDisplayData d)
					{
						//Discarded unreachable code: IL_0023
						BuffOrigin origin2 = CS_0024_003C_003E8__locals0.origin;
						if (d.origin_ != origin2)
						{
							int num6 = 0;
						}
						BuffType buffType2 = CS_0024_003C_003E8__locals0.buffType;
						return d.type_ == buffType2;
					});
				}
				BuffDisplayData buffDisplayData = default(BuffDisplayData);
				while (buffDisplayData == null)
				{
				}
				num++;
			}
			num++;
			int num2 = default(int);
			if (CS_0024_003C_003E8__locals0 != null)
			{
				num2 = 0;
			}
			if (num == 0 || num2 != 248)
			{
				int num4 = default(int);
				if (uint.MaxValue != 0)
				{
					int num3 = 0;
					while ((BuffOrigin)(-1) != CS_0024_003C_003E8__locals0.origin)
					{
					}
					num4++;
				}
				num4++;
				int num5 = default(int);
				if (num5 != 0)
				{
				}
				if (num4 == 0)
				{
					throw new NullReferenceException();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005105")]
		[Cpp2IlInjected.Address(RVA = "0x96F220", Offset = "0x96DC20", VA = "0x18096F220")]
		internal void RemoveBuffs(BuffOrigin buffOrigin, IPlayerEventDispatcher dispatcher)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005106")]
		[Cpp2IlInjected.Address(RVA = "0x96F5B0", Offset = "0x96DFB0", VA = "0x18096F5B0")]
		internal void RemoveBuffs(BuffOrigin buffOrigin, BuffType buffType, IPlayerEventDispatcher dispatcher)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005107")]
		[Cpp2IlInjected.Address(RVA = "0x96CB70", Offset = "0x96B570", VA = "0x18096CB70")]
		private int MatchingBuffCount(BuffOrigin origin, BuffType type)
		{
			//Discarded unreachable code: IL_0062
			RepeatedField<Buff> repeatedField = buffs_;
			Func<Buff, bool> func = (Func<Buff, bool>)(object)(Func<T, TResult>)delegate(Buff b)
			{
				//Discarded unreachable code: IL_0023
				BuffType buffType2 = type;
				if (b.type_ != buffType2)
				{
					int num4 = 0;
				}
				BuffOrigin buffOrigin2 = origin;
				return b.origin_ == buffOrigin2;
			};
			int num = Enumerable.Count<Buff>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			List<Buff> transientBuffs = TransientBuffs;
			Func<Buff, bool> func2 = (Func<Buff, bool>)(object)(Func<T, TResult>)delegate(Buff b)
			{
				//Discarded unreachable code: IL_0023
				BuffType buffType = type;
				if (b.type_ != buffType)
				{
					int num3 = 0;
				}
				BuffOrigin buffOrigin = origin;
				return b.origin_ == buffOrigin;
			};
			int num2 = Enumerable.Count<Buff>((IEnumerable<>)transientBuffs, (Func<, >)(object)func2);
			return num2 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005108")]
		[Cpp2IlInjected.Address(RVA = "0x963810", Offset = "0x962210", VA = "0x180963810", Slot = "15")]
		public void ApplyBuff(BuffType buffType, ref int value, bool isReduction = false, int extraBuff = 0)
		{
			int buff = GetBuff(buffType);
			ulong num = num + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005109")]
		[Cpp2IlInjected.Address(RVA = "0x963870", Offset = "0x962270", VA = "0x180963870", Slot = "16")]
		public void ApplyBuff(BuffType buffType, ref TimeSpan value, bool isReduction = false, int extraBuff = 0)
		{
			//IL_0014: Expected I8, but got O
			if (!isReduction)
			{
				ulong num = num + num;
			}
			ulong num2 = num2 + num2;
			TimeSpan timeSpan = default(TimeSpan);
			value._ticks = (long)timeSpan;
		}

		[Cpp2IlInjected.Token(Token = "0x600510A")]
		[Cpp2IlInjected.Address(RVA = "0x970560", Offset = "0x96EF60", VA = "0x180970560")]
		internal bool SendItemToInbox(Item item, int amount, ItemState itemState, in Player player, ITransactionContext context, ItemsSentToInboxReason reason = ItemsSentToInboxReason.None)
		{
			//Discarded unreachable code: IL_0024
			int itemID = item.ItemID;
			InboxItemReward inboxItemReward = new InboxItemReward();
			inboxItemReward.state_ = itemState;
			inboxItemReward.id_ = itemID;
			inboxItemReward.amount_ = amount;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600510B")]
		[Cpp2IlInjected.Address(RVA = "0x9707C0", Offset = "0x96F1C0", VA = "0x1809707C0")]
		internal bool SendItemToInbox(InboxItemReward item, in Player player, ITransactionContext context, ItemsSentToInboxReason reason = ItemsSentToInboxReason.None)
		{
			//Discarded unreachable code: IL_0046
			List<InboxItemReward> list = (List<InboxItemReward>)(object)new List<T>();
			((List<T>)(object)list).Add((T)item);
			SendItemsToInbox.Types.Response response = new SendItemsToInbox.Types.Response();
			SendItemsToInbox.Types.Request request = new SendItemsToInbox.Types.Request();
			request.reason_ = ItemsSentToInboxReason.None;
			response.request_ = request;
			((RepeatedField<T>)(object)response.request_.items_).AddRange((IEnumerable<>)list);
			if (player.dispatcher == null)
			{
			}
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600510C")]
		[Cpp2IlInjected.Address(RVA = "0x970620", Offset = "0x96F020", VA = "0x180970620")]
		internal bool SendItemToInbox(List<InboxItemReward> items, in Player player, ITransactionContext context, ItemsSentToInboxReason reason = ItemsSentToInboxReason.None)
		{
			//Discarded unreachable code: IL_0038
			SendItemsToInbox.Types.Response response = new SendItemsToInbox.Types.Response();
			SendItemsToInbox.Types.Request request = new SendItemsToInbox.Types.Request();
			request.reason_ = ItemsSentToInboxReason.None;
			response.request_ = request;
			((RepeatedField<T>)(object)response.request_.items_).AddRange((IEnumerable<>)items);
			if (player.dispatcher == null)
			{
			}
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600510D")]
		[Cpp2IlInjected.Address(RVA = "0x96AA20", Offset = "0x969420", VA = "0x18096AA20")]
		public int GetXpRequiredForLevel(int level)
		{
			//Discarded unreachable code: IL_0045
			int level2 = level;
			if (level != 0)
			{
				RepeatedField<PlayerLevel> playerLevels_ = PlayerInfo.playerLevels_;
				Func<PlayerLevel, bool> func = (Func<PlayerLevel, bool>)(object)(Func<T, TResult>)delegate(PlayerLevel x)
				{
					//Discarded unreachable code: IL_0011
					int num = level2;
					return x.level_ == num;
				};
				return Enumerable.FirstOrDefault<PlayerLevel>((IEnumerable<>)(object)playerLevels_, (Func<, >)(object)func)?.xp_ ?? int.MaxValue;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600510E")]
		[Cpp2IlInjected.Address(RVA = "0x969BC0", Offset = "0x9685C0", VA = "0x180969BC0")]
		public int GetMaxLevel()
		{
			//Discarded unreachable code: IL_0011
			return ((RepeatedField<T>)(object)PlayerInfo.playerLevels_).Count;
		}

		[Cpp2IlInjected.Token(Token = "0x600510F")]
		[Cpp2IlInjected.Address(RVA = "0x969800", Offset = "0x968200", VA = "0x180969800")]
		public int GetLevelForXp(int xp)
		{
			//Discarded unreachable code: IL_003f, IL_0045
			int num = 0;
			IEnumerable<PlayerLevel> enumerable = (IEnumerable<PlayerLevel>)Enumerable.Reverse<PlayerLevel>((IEnumerable<>)(object)PlayerInfo.playerLevels_);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_002b;
					}
					num++;
				}
				num++;
			}
			goto IL_002b;
			IL_002b:
			num++;
			if (enumerable != null)
			{
			}
			if (num != 0)
			{
				return num;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005110")]
		[Cpp2IlInjected.Address(RVA = "0x968290", Offset = "0x966C90", VA = "0x180968290")]
		public MapField<int, DesignMap> GetDesignMaps(bool isMale)
		{
			if (isMale)
			{
				return maleClothingDesigns_;
			}
			return femaleClothingDesigns_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005111")]
		[Cpp2IlInjected.Address(RVA = "0x96AD20", Offset = "0x969720", VA = "0x18096AD20")]
		public bool HasDesignFor(bool isMale, Item item, int designId)
		{
			if (isMale)
			{
			}
			MapField<int, DesignMap> mapField = femaleClothingDesigns_;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005112")]
		[Cpp2IlInjected.Address(RVA = "0x9681B0", Offset = "0x966BB0", VA = "0x1809681B0")]
		public unsafe Design GetDesignFor(bool isMale, Item item, int designId)
		{
			//IL_0020: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			if (designId != -1)
			{
				if (isMale)
				{
				}
				MapField<int, DesignMap> mapField = femaleClothingDesigns_;
				if (((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)itemID, out *(TValue*)num))
				{
					itemID = designId;
					if (!((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)itemID, out *(TValue*)num))
					{
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005113")]
		[Cpp2IlInjected.Address(RVA = "0x962760", Offset = "0x961160", VA = "0x180962760")]
		internal unsafe int AddDesignFor(bool isMale, Item item, Design design)
		{
			//Discarded unreachable code: IL_007f
			//IL_0032: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			bool flag = ProtoDatabase.Instance.TryGet("ClothingDesign", out *(ClothingDesignData*)num);
			MapField<int, DesignMap> mapField = femaleClothingDesigns_;
			bool flag2 = LimitReached();
			DesignMap designMap = default(DesignMap);
			if (!((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)itemID, out *(TValue*)num))
			{
				designMap = new DesignMap();
				((MapField<TKey, TValue>)(object)mapField).Add((TKey)itemID, (TValue)designMap);
			}
			Design design2 = new Design(design);
			int num2 = default(int);
			if (num2 == -1)
			{
				nextClothingDesignID_++;
			}
			MapField<int, Design> designs_ = designMap.designs_;
			if (flag2 || LimitReached())
			{
			}
			int result = default(int);
			return result;
			[Cpp2IlInjected.Token(Token = "0x600511C")]
			[Cpp2IlInjected.Address(RVA = "0x9727E0", Offset = "0x9711E0", VA = "0x1809727E0")]
			bool LimitReached()
			{
				//Discarded unreachable code: IL_0043
				//Could not transform parameter 0: unsupported argument pattern
				//Could not transform parameter 0: unsupported argument pattern
				int num3 = 0;
				if (cpp2il__autoParamName__idx_0.isMale)
				{
				}
				MapField<int, DesignMap> mapField2 = femaleClothingDesigns_;
				Func<KeyValuePair<int, DesignMap>, int> func = default(Func<KeyValuePair<int, DesignMap>, int>);
				if (_003C_003Ec._003C_003E9__469_0 == null)
				{
					int result2 = default(int);
					func = (Func<KeyValuePair<int, DesignMap>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, DesignMap> x) => result2));
				}
				return (long)Enumerable.Sum<KeyValuePair<int, DesignMap>>((IEnumerable<>)(object)mapField2, (Func<, >)(object)func) >= (long)(IntPtr)"{il2cpp field on {'constant31' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x18}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005114")]
		[Cpp2IlInjected.Address(RVA = "0x96FB60", Offset = "0x96E560", VA = "0x18096FB60")]
		internal unsafe void RemoveDesignFor(bool isMale, Item item, int designId)
		{
			//Discarded unreachable code: IL_005e
			//IL_0023: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			int num = item.ItemID;
			int num2 = 0;
			if (isMale)
			{
			}
			Avatar avatar = femaleAvatar_;
			MapField<int, DesignMap> mapField = femaleClothingDesigns_;
			if (((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)num, out *(TValue*)num2))
			{
				num = designId;
				bool flag = ((MapField<TKey, TValue>)(object)mapField).Remove((TKey)num);
				int num3 = default(int);
				if (num3 == 0)
				{
					bool flag2 = ((MapField<TKey, TValue>)(object)mapField).Remove((TKey)num);
				}
			}
			if (((MapField<TKey, TValue>)(object)avatar.clothingCustomization_).TryGetValue((TKey)num, out *(TValue*)num2))
			{
				bool flag3 = ((MapField<TKey, TValue>)(object)avatar.clothingCustomization_).Remove((TKey)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005115")]
		[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x966A70", VA = "0x180968070")]
		public int GetDesignCount(bool isMale)
		{
			if (isMale)
			{
			}
			MapField<int, DesignMap> mapField = femaleClothingDesigns_;
			Func<KeyValuePair<int, DesignMap>, int> func = default(Func<KeyValuePair<int, DesignMap>, int>);
			if (_003C_003Ec._003C_003E9__469_0 == null)
			{
				int result = default(int);
				func = (Func<KeyValuePair<int, DesignMap>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, DesignMap> x) => result));
			}
			return Enumerable.Sum<KeyValuePair<int, DesignMap>>((IEnumerable<>)(object)mapField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6005116")]
		[Cpp2IlInjected.Address(RVA = "0x964A50", Offset = "0x963450", VA = "0x180964A50")]
		internal unsafe void CleanupCustomizationFor(bool isMale)
		{
			//Discarded unreachable code: IL_0064, IL_006a, IL_0070, IL_0076, IL_007c
			//IL_003a: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			int num3;
			Avatar avatar;
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				num3 = 0;
				if (isMale)
				{
				}
				avatar = femaleAvatar_;
				if (isMale)
				{
				}
				MapField<int, DesignMap> mapField = femaleClothingDesigns_;
				List<int> list = (List<int>)(object)new List<T>();
				MapField<int, int> clothingCustomization_ = avatar.clothingCustomization_;
				if (!flag)
				{
					break;
				}
				if (!((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)num, out *(TValue*)num) || !((MapField<TKey, TValue>)(object)mapField).ContainsKey((TKey)num))
				{
					((List<T>)(object)list).Add((T)num);
					break;
				}
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = ((MapField<TKey, TValue>)(object)avatar.clothingCustomization_).Remove((TKey)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005117")]
		[Cpp2IlInjected.Address(RVA = "0x973DD0", Offset = "0x9727D0", VA = "0x180973DD0")]
		static ProfilePlayer()
		{
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<ContainerInventory> parser = ContainerInventory._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<ContainerInventory>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			FieldCodec<uint> fieldCodec3 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<ListInventory> parser2 = ListInventory._parser;
			uint num3 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<ListInventory>(num3, (MessageParser<>)(object)parser2);
			uint num4 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num4);
			FieldCodec<int> fieldCodec5 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<int> fieldCodec6 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num5 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec5, (FieldCodec<>)(object)fieldCodec6, num5);
			MessageParser<ToolInfo> parser3 = ToolInfo._parser;
			uint num6 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)FieldCodec.ForMessage<ToolInfo>(num6, (MessageParser<>)(object)parser3);
			MessageParser<CookingHistory> parser4 = Meta.CookingHistory._parser;
			uint num7 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)FieldCodec.ForMessage<CookingHistory>(num7, (MessageParser<>)(object)parser4);
			uint num8 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)FieldCodec.ForInt32(num8);
			MessageParser<Buff> parser5 = Buff._parser;
			uint num9 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)FieldCodec.ForMessage<Buff>(num9, (MessageParser<>)(object)parser5);
			MessageParser<Pet> parser6 = Pet._parser;
			uint num10 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)FieldCodec.ForMessage<Pet>(num10, (MessageParser<>)(object)parser6);
			FieldCodec<int> fieldCodec7 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<FishRecord> parser7 = FishRecord._parser;
			uint num11 = default(uint);
			FieldCodec<> fieldCodec8 = FieldCodec.ForMessage<FishRecord>(num11, (MessageParser<>)(object)parser7);
			uint num12 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec7, fieldCodec8, num12);
			FieldCodec<int> fieldCodec9 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<DutyList> parser8 = DutyList._parser;
			uint num13 = default(uint);
			FieldCodec<> fieldCodec10 = FieldCodec.ForMessage<DutyList>(num13, (MessageParser<>)(object)parser8);
			uint num14 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec9, fieldCodec10, num14);
			MessageParser<CollectionSet> parser9 = CollectionSet._parser;
			uint num15 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)FieldCodec.ForMessage<CollectionSet>(num15, (MessageParser<>)(object)parser9);
			MessageParser<AchievementData> parser10 = AchievementData._parser;
			uint num16 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)FieldCodec.ForMessage<AchievementData>(num16, (MessageParser<>)(object)parser10);
			FieldCodec<int> fieldCodec11 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<DesignMap> parser11 = DesignMap._parser;
			uint num17 = default(uint);
			FieldCodec<> fieldCodec12 = FieldCodec.ForMessage<DesignMap>(num17, (MessageParser<>)(object)parser11);
			uint num18 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec11, fieldCodec12, num18);
			FieldCodec<int> fieldCodec13 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<Furniture> parser12 = Furniture._parser;
			uint num19 = default(uint);
			FieldCodec<> fieldCodec14 = FieldCodec.ForMessage<Furniture>(num19, (MessageParser<>)(object)parser12);
			uint num20 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec13, fieldCodec14, num20);
			FieldCodec<int> fieldCodec15 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<DesignMap> parser13 = DesignMap._parser;
			uint num21 = default(uint);
			FieldCodec<> fieldCodec16 = FieldCodec.ForMessage<DesignMap>(num21, (MessageParser<>)(object)parser13);
			uint num22 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec15, fieldCodec16, num22);
			FieldCodec<int> fieldCodec17 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<DesignMap> parser14 = DesignMap._parser;
			uint num23 = default(uint);
			FieldCodec<> fieldCodec18 = FieldCodec.ForMessage<DesignMap>(num23, (MessageParser<>)(object)parser14);
			uint num24 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec17, fieldCodec18, num24);
			FieldCodec<int> fieldCodec19 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<int> fieldCodec20 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num25 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec19, (FieldCodec<>)(object)fieldCodec20, num25);
			FieldCodec<string> fieldCodec21 = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			FieldCodec<int> fieldCodec22 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num26 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec21, (FieldCodec<>)(object)fieldCodec22, num26);
			uint num27 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)FieldCodec.ForInt32(num27);
			FieldCodec<string> fieldCodec23 = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<Timestamp> parser15 = Timestamp._parser;
			uint num28 = default(uint);
			FieldCodec<> fieldCodec24 = FieldCodec.ForMessage<Timestamp>(num28, (MessageParser<>)(object)parser15);
			uint num29 = default(uint);
			_parser = (MessageParser<ProfilePlayer>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec23, fieldCodec24, num29);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005118")]
		[Cpp2IlInjected.Address(RVA = "0x965770", Offset = "0x964170", VA = "0x180965770", Slot = "26")]
		bool IProfilePlayer.IsCraftingRecipeAvailable(Item item, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			bool result = default(bool);
			return result;
		}
	}
}
