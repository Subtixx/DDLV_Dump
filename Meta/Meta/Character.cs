using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Character;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000835")]
	public sealed class Character : IMessage<Character>, IMessage, IEquatable<Character>, IDeepCloneable<Character>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000836")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000837")]
			public enum CharacterStatus
			{
				[Cpp2IlInjected.Token(Token = "0x40020F0")]
				[OriginalName("CharacterStatus_InRealm")]
				InRealm,
				[Cpp2IlInjected.Token(Token = "0x40020F1")]
				[OriginalName("CharacterStatus_LockedInVillage")]
				LockedInVillage,
				[Cpp2IlInjected.Token(Token = "0x40020F2")]
				[OriginalName("CharacterStatus_Unlocked")]
				Unlocked,
				[Cpp2IlInjected.Token(Token = "0x40020F3")]
				[OriginalName("CharacterStatus_InVillage")]
				InVillage,
				[Cpp2IlInjected.Token(Token = "0x40020F4")]
				[OriginalName("CharacterStatus_InEvent")]
				InEvent,
				[Cpp2IlInjected.Token(Token = "0x40020F5")]
				[OriginalName("CharacterStatus_Secret")]
				Secret
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000838")]
		public class GiftItemResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40020F6")]
			public int FriendshipGained;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40020F7")]
			public bool FirstDailyPreferred;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40020F8")]
			public PreferredItemStatus Status;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40020F9")]
			public List<(int index, PreferredItemStatus status)> NewDiscovery;

			[Cpp2IlInjected.Token(Token = "0x60044FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GiftItemResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40020BB")]
		private static readonly MessageParser<Character> _parser = (MessageParser<Character>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new Character()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40020BC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40020BD")]
		public const int BaseFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40020BE")]
		private BaseItem base_;

		[Cpp2IlInjected.Token(Token = "0x40020BF")]
		public const int FriendshipLevelFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40020C0")]
		private int friendshipLevel_;

		[Cpp2IlInjected.Token(Token = "0x40020C1")]
		public const int FriendshipFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40020C2")]
		private int friendship_;

		[Cpp2IlInjected.Token(Token = "0x40020C3")]
		public const int HappinessFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40020C4")]
		private uint happiness_;

		[Cpp2IlInjected.Token(Token = "0x40020C5")]
		public const int StatusFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40020C6")]
		private Types.CharacterStatus status_;

		[Cpp2IlInjected.Token(Token = "0x40020C7")]
		public const int DiscussedWithTheAvatarTodayFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40020C8")]
		private bool discussedWithTheAvatarToday_;

		[Cpp2IlInjected.Token(Token = "0x40020C9")]
		public const int LastGiftDateFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40020CA")]
		private Timestamp lastGiftDate_;

		[Cpp2IlInjected.Token(Token = "0x40020CB")]
		public const int LatestGiftedItemsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x40020CC")]
		private static readonly FieldCodec<int> _repeated_latestGiftedItems_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40020CD")]
		private readonly RepeatedField<int> latestGiftedItems_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40020CE")]
		public const int PreferredItemStatusFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x40020CF")]
		private static readonly MapField<int, PreferredItemStatus>.Codec _map_preferredItemStatus_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40020D0")]
		private readonly MapField<int, PreferredItemStatus> preferredItemStatus_ = (MapField<int, PreferredItemStatus>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40020D1")]
		public const int FreeTimeScheduleFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40020D2")]
		private ScheduleType freeTimeSchedule_;

		[Cpp2IlInjected.Token(Token = "0x40020D3")]
		public const int FreeTimeScheduleTimestampFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40020D4")]
		private Timestamp freeTimeScheduleTimestamp_;

		[Cpp2IlInjected.Token(Token = "0x40020D5")]
		public const int SecretCharacterDataFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40020D6")]
		private SecretCharacterRecurringConditionData secretCharacterData_;

		[Cpp2IlInjected.Token(Token = "0x40020D7")]
		public const int ProfessionIDFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40020D8")]
		private int professionID_;

		[Cpp2IlInjected.Token(Token = "0x40020D9")]
		public const int LastSelfieDateFieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40020DA")]
		private Timestamp lastSelfieDate_;

		[Cpp2IlInjected.Token(Token = "0x40020DB")]
		public const int PreferredItemSlotsFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x40020DC")]
		private static readonly FieldCodec<PreferredItemSlot> _repeated_preferredItemSlots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40020DD")]
		private readonly RepeatedField<PreferredItemSlot> preferredItemSlots_ = (RepeatedField<PreferredItemSlot>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40020DE")]
		public const int SeenPreferredItemsFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40020DF")]
		private bool seenPreferredItems_;

		[Cpp2IlInjected.Token(Token = "0x40020E0")]
		public const int PendingHangoutGatherRewardsFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x40020E1")]
		private static readonly FieldCodec<ItemReward> _repeated_pendingHangoutGatherRewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40020E2")]
		private readonly RepeatedField<ItemReward> pendingHangoutGatherRewards_ = (RepeatedField<ItemReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40020E3")]
		public const int SkinIDFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40020E4")]
		private int skinID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40020E5")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40020E6")]
		private ProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40020E7")]
		private ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40020E8")]
		private CharacterSkinItemData[] conditionalCharacterSkins;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40020E9")]
		private int characterMainStoryCount = -1;

		[Cpp2IlInjected.Token(Token = "0x40020EA")]
		private static int _GiftDailyLimitation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40020EB")]
		private ProfessionItemData cachedProfessionItemData;

		[Cpp2IlInjected.Token(Token = "0x40020EC")]
		private static ProfessionItemData[] EmptyProfessionList;

		[Cpp2IlInjected.Token(Token = "0x40020ED")]
		public const string GoofyItemName = "Mickey!Goofy";

		[Cpp2IlInjected.Token(Token = "0x40020EE")]
		public const string RemyItemName = "Ratatouille!Remy";

		[Cpp2IlInjected.Token(Token = "0x17000B39")]
		[DebuggerNonUserCode]
		public static MessageParser<Character> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600448C")]
			[Cpp2IlInjected.Address(RVA = "0x724DE0", Offset = "0x7237E0", VA = "0x180724DE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600448D")]
			[Cpp2IlInjected.Address(RVA = "0x724870", Offset = "0x723270", VA = "0x180724870")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600448E")]
			[Cpp2IlInjected.Address(RVA = "0x7251B0", Offset = "0x723BB0", VA = "0x1807251B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3C")]
		[DebuggerNonUserCode]
		public BaseItem Base
		{
			[Cpp2IlInjected.Token(Token = "0x6004493")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return base_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004494")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				base_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3D")]
		[DebuggerNonUserCode]
		public int FriendshipLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6004495")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return friendshipLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004496")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				friendshipLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3E")]
		[DebuggerNonUserCode]
		public int Friendship
		{
			[Cpp2IlInjected.Token(Token = "0x6004497")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return friendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004498")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				friendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3F")]
		[DebuggerNonUserCode]
		public uint Happiness
		{
			[Cpp2IlInjected.Token(Token = "0x6004499")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return happiness_;
			}
			[Cpp2IlInjected.Token(Token = "0x600449A")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				happiness_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B40")]
		[DebuggerNonUserCode]
		public Types.CharacterStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x600449B")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return status_;
			}
			[Cpp2IlInjected.Token(Token = "0x600449C")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				status_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B41")]
		[DebuggerNonUserCode]
		public bool DiscussedWithTheAvatarToday
		{
			[Cpp2IlInjected.Token(Token = "0x600449D")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return discussedWithTheAvatarToday_;
			}
			[Cpp2IlInjected.Token(Token = "0x600449E")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				discussedWithTheAvatarToday_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B42")]
		[DebuggerNonUserCode]
		public Timestamp LastGiftDate
		{
			[Cpp2IlInjected.Token(Token = "0x600449F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return lastGiftDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044A0")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				lastGiftDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B43")]
		[DebuggerNonUserCode]
		public RepeatedField<int> LatestGiftedItems
		{
			[Cpp2IlInjected.Token(Token = "0x60044A1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return latestGiftedItems_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B44")]
		[DebuggerNonUserCode]
		public MapField<int, PreferredItemStatus> PreferredItemStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60044A2")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return preferredItemStatus_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B45")]
		[DebuggerNonUserCode]
		public ScheduleType FreeTimeSchedule
		{
			[Cpp2IlInjected.Token(Token = "0x60044A3")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return freeTimeSchedule_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044A4")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				freeTimeSchedule_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B46")]
		[DebuggerNonUserCode]
		public Timestamp FreeTimeScheduleTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60044A5")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return freeTimeScheduleTimestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044A6")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				freeTimeScheduleTimestamp_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B47")]
		[DebuggerNonUserCode]
		public SecretCharacterRecurringConditionData SecretCharacterData
		{
			[Cpp2IlInjected.Token(Token = "0x60044A7")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return secretCharacterData_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044A8")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				secretCharacterData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B48")]
		[DebuggerNonUserCode]
		public int ProfessionID
		{
			[Cpp2IlInjected.Token(Token = "0x60044A9")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get
			{
				return professionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044AA")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				professionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B49")]
		[DebuggerNonUserCode]
		public Timestamp LastSelfieDate
		{
			[Cpp2IlInjected.Token(Token = "0x60044AB")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return lastSelfieDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044AC")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				lastSelfieDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4A")]
		[DebuggerNonUserCode]
		public RepeatedField<PreferredItemSlot> PreferredItemSlots
		{
			[Cpp2IlInjected.Token(Token = "0x60044AD")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return preferredItemSlots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4B")]
		[DebuggerNonUserCode]
		public bool SeenPreferredItems
		{
			[Cpp2IlInjected.Token(Token = "0x60044AE")]
			[Cpp2IlInjected.Address(RVA = "0x725070", Offset = "0x723A70", VA = "0x180725070")]
			get
			{
				return seenPreferredItems_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044AF")]
			[Cpp2IlInjected.Address(RVA = "0x725360", Offset = "0x723D60", VA = "0x180725360")]
			set
			{
				seenPreferredItems_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4C")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemReward> PendingHangoutGatherRewards
		{
			[Cpp2IlInjected.Token(Token = "0x60044B0")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return pendingHangoutGatherRewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4D")]
		[DebuggerNonUserCode]
		public int SkinID
		{
			[Cpp2IlInjected.Token(Token = "0x60044B1")]
			[Cpp2IlInjected.Address(RVA = "0x725190", Offset = "0x723B90", VA = "0x180725190")]
			get
			{
				return skinID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044B2")]
			[Cpp2IlInjected.Address(RVA = "0x725370", Offset = "0x723D70", VA = "0x180725370")]
			set
			{
				skinID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4E")]
		public CharacterItemData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60044BF")]
			[Cpp2IlInjected.Address(RVA = "0x724690", Offset = "0x723090", VA = "0x180724690")]
			get
			{
				//Discarded unreachable code: IL_0016
				BaseItem baseItem = base_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = baseItem.Item;
				CharacterItemData result = default(CharacterItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4F")]
		public CharacterSkinItemData SkinData
		{
			[Cpp2IlInjected.Token(Token = "0x60044C0")]
			[Cpp2IlInjected.Address(RVA = "0x725080", Offset = "0x723A80", VA = "0x180725080")]
			get
			{
				//Discarded unreachable code: IL_0016
				int value = skinID_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)value);
				CharacterSkinItemData result = default(CharacterSkinItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B50")]
		public bool InRealm
		{
			[Cpp2IlInjected.Token(Token = "0x60044C1")]
			[Cpp2IlInjected.Address(RVA = "0x724B80", Offset = "0x723580", VA = "0x180724B80")]
			get
			{
				return status_ == Types.CharacterStatus.InRealm;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B51")]
		public bool InEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60044C2")]
			[Cpp2IlInjected.Address(RVA = "0x724B70", Offset = "0x723570", VA = "0x180724B70")]
			get
			{
				return status_ == Types.CharacterStatus.InEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B52")]
		public bool InVillage
		{
			[Cpp2IlInjected.Token(Token = "0x60044C3")]
			[Cpp2IlInjected.Address(RVA = "0x724B90", Offset = "0x723590", VA = "0x180724B90")]
			get
			{
				Types.CharacterStatus characterStatus = status_;
				if (characterStatus == Types.CharacterStatus.InVillage)
				{
					return true;
				}
				return characterStatus == Types.CharacterStatus.LockedInVillage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B53")]
		public bool IsLockedInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x60044C4")]
			[Cpp2IlInjected.Address(RVA = "0x724BB0", Offset = "0x7235B0", VA = "0x180724BB0")]
			get
			{
				return status_ == Types.CharacterStatus.LockedInVillage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B54")]
		public bool IsUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60044C5")]
			[Cpp2IlInjected.Address(RVA = "0x724BF0", Offset = "0x7235F0", VA = "0x180724BF0")]
			get
			{
				Types.CharacterStatus characterStatus = status_;
				if (characterStatus == Types.CharacterStatus.InVillage)
				{
					return true;
				}
				return characterStatus == Types.CharacterStatus.Unlocked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B55")]
		public bool IsSecretAndHide
		{
			[Cpp2IlInjected.Token(Token = "0x60044C6")]
			[Cpp2IlInjected.Address(RVA = "0x724BC0", Offset = "0x7235C0", VA = "0x180724BC0")]
			get
			{
				//Discarded unreachable code: IL_001a
				if (status_ != Types.CharacterStatus.Secret)
				{
					int num = 0;
				}
				return !secretCharacterData_.isDiscovered_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B56")]
		public bool CanHangoutWithPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60044C7")]
			[Cpp2IlInjected.Address(RVA = "0x724540", Offset = "0x722F40", VA = "0x180724540")]
			get
			{
				//Discarded unreachable code: IL_002b
				int value = skinID_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)value);
				CharacterSkinItemData characterSkinItemData = default(CharacterSkinItemData);
				return characterSkinItemData?.canHangoutWithPlayer_ ?? Data.canHangoutWithPlayer_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B57")]
		public int MaxLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60044D2")]
			[Cpp2IlInjected.Address(RVA = "0x724CF0", Offset = "0x7236F0", VA = "0x180724CF0")]
			get
			{
				//Discarded unreachable code: IL_0018
				int itemID = base_.Item.ItemID;
				RepeatedField<FriendshipLevel> repeatedField = default(RepeatedField<FriendshipLevel>);
				return ((RepeatedField<T>)(object)repeatedField).Count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B58")]
		public int MaxLevelXP
		{
			[Cpp2IlInjected.Token(Token = "0x60044D3")]
			[Cpp2IlInjected.Address(RVA = "0x724C20", Offset = "0x723620", VA = "0x180724C20")]
			get
			{
				//Discarded unreachable code: IL_0032
				int itemID = base_.Item.ItemID;
				int itemID2 = base_.Item.ItemID;
				RepeatedField<FriendshipLevel> repeatedField = default(RepeatedField<FriendshipLevel>);
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				FriendshipLevel friendshipLevel = default(FriendshipLevel);
				return friendshipLevel.xP_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B59")]
		public int NextFriendshipLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60044D8")]
			[Cpp2IlInjected.Address(RVA = "0x724D50", Offset = "0x723750", VA = "0x180724D50")]
			get
			{
				//Discarded unreachable code: IL_0035
				int num = friendshipLevel_;
				int itemID = base_.Item.ItemID;
				RepeatedField<FriendshipLevel> repeatedField = default(RepeatedField<FriendshipLevel>);
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				int num2 = friendshipLevel_;
				if (num < count)
				{
					return num2 + 1;
				}
				return num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5A")]
		public static int GiftDailyLimitation
		{
			[Cpp2IlInjected.Token(Token = "0x60044E0")]
			[Cpp2IlInjected.Address(RVA = "0x7249C0", Offset = "0x7233C0", VA = "0x1807249C0")]
			get
			{
				//Discarded unreachable code: IL_0019
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				ulong num = default(ulong);
				if (num != 0)
				{
				}
				_GiftDailyLimitation = -1;
				return _GiftDailyLimitation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5B")]
		public static PreferredItemStatus DefaultDiscoveryStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60044E1")]
			[Cpp2IlInjected.Address(RVA = "0x724780", Offset = "0x723180", VA = "0x180724780")]
			get
			{
				//Discarded unreachable code: IL_001d
				return ProtoDatabase.Instance.Get<CharacterSettingsData>("CharacterSettings")?.defaultDiscoveryStatus_ ?? Definitions.Items.PreferredItemStatus.Discovered;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5C")]
		public IEnumerable<Item> PreferredItems
		{
			[Cpp2IlInjected.Token(Token = "0x60044E2")]
			[Cpp2IlInjected.Address(RVA = "0x724E40", Offset = "0x723840", VA = "0x180724E40")]
			get
			{
				RepeatedField<PreferredItemSlot> repeatedField = preferredItemSlots_;
				Func<PreferredItemSlot, Item> _003C_003E9__171_ = _003C_003Ec._003C_003E9__171_0;
				if (_003C_003E9__171_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(PreferredItemSlot x)
					{
						//Discarded unreachable code: IL_000d
						int preferredItemId_ = x.preferredItemId_;
						return (Item)typeof(Item).TypeHandle;
					};
				}
				return (IEnumerable<Item>)Enumerable.Select<PreferredItemSlot, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__171_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5D")]
		public int GiftCountForToday
		{
			[Cpp2IlInjected.Token(Token = "0x60044EF")]
			[Cpp2IlInjected.Address(RVA = "0x724970", Offset = "0x723370", VA = "0x180724970")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((RepeatedField<T>)(object)latestGiftedItems_).Count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5E")]
		public ProfessionItemData Profession
		{
			[Cpp2IlInjected.Token(Token = "0x60044F1")]
			[Cpp2IlInjected.Address(RVA = "0x724F80", Offset = "0x723980", VA = "0x180724F80")]
			get
			{
				//Discarded unreachable code: IL_002e
				if ((object)typeof(Item).TypeHandle == null && (IntPtr)professionID_ != (IntPtr)typeof(Item).TypeHandle)
				{
					long num = Convert.ToInt64((uint)professionID_);
					ProfessionItemData professionItemData = default(ProfessionItemData);
					cachedProfessionItemData = professionItemData;
				}
				return (ProfessionItemData)typeof(Item).TypeHandle;
			}
			[Cpp2IlInjected.Token(Token = "0x60044F2")]
			[Cpp2IlInjected.Address(RVA = "0x725300", Offset = "0x723D00", VA = "0x180725300")]
			set
			{
				cachedProfessionItemData = value;
				ProfessionItemData professionItemData = cachedProfessionItemData;
				if (professionItemData != null)
				{
					int num = (professionID_ = professionItemData.ID);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B5F")]
		public ICollection<ProfessionItemData> AvailableProfessions
		{
			[Cpp2IlInjected.Token(Token = "0x60044F5")]
			[Cpp2IlInjected.Address(RVA = "0x724150", Offset = "0x722B50", VA = "0x180724150")]
			get
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (IsCharacterAvailableToSelectProfession())
				{
					RepeatedField<int> forbiddenProfessions_ = Data.forbiddenProfessions_;
					Func<int, Item> _003C_003E9__196_ = _003C_003Ec._003C_003E9__196_0;
					if (_003C_003E9__196_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int professionID) => (Item)typeof(Item).TypeHandle);
					}
					IEnumerable<Item> forbiddenProfessions = (IEnumerable<Item>)Enumerable.Select<int, Item>((IEnumerable<>)(object)forbiddenProfessions_, (Func<, >)(object)_003C_003E9__196_);
					Func<ProfessionItemData, bool> func = default(Func<ProfessionItemData, bool>);
					if (_003C_003Ec._003C_003E9__196_1 == null)
					{
						func = (Func<ProfessionItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ProfessionItemData profession) => !profession.isUnique_));
					}
					IEnumerable<> enumerable = default(IEnumerable<>);
					IEnumerable<ProfessionItemData> enumerable2 = (IEnumerable<ProfessionItemData>)Enumerable.Where<ProfessionItemData>(enumerable, (Func<, >)(object)func);
					Func<ProfessionItemData, bool> func2 = (Func<ProfessionItemData, bool>)(object)(Func<T, TResult>)delegate(ProfessionItemData profession)
					{
						//Discarded unreachable code: IL_0013
						IEnumerable<Item> enumerable3 = forbiddenProfessions;
						int iD = profession.ID;
						bool flag = default(bool);
						return !flag;
					};
					List<ProfessionItemData> list = (List<ProfessionItemData>)(object)Enumerable.ToList<ProfessionItemData>(Enumerable.Where<ProfessionItemData>((IEnumerable<>)enumerable2, (Func<, >)(object)func2));
				}
				ProfessionItemData[] emptyProfessionList = EmptyProfessionList;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600448F")]
		[Cpp2IlInjected.Address(RVA = "0x723FA0", Offset = "0x7229A0", VA = "0x180723FA0")]
		[DebuggerNonUserCode]
		public Character()
		{
			//IL_0044: Expected I4, but got I8
			//IL_0053: Expected I4, but got I8
			//IL_006b: Expected I4, but got I8
			friendshipLevel_ = 0;
			BaseItem baseItem = (base_ = new BaseItem());
			freeTimeSchedule_ = ScheduleType.Outdoor;
		}

		[Cpp2IlInjected.Token(Token = "0x6004490")]
		[Cpp2IlInjected.Address(RVA = "0x7229F0", Offset = "0x7213F0", VA = "0x1807229F0")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			friendshipLevel_ = 0;
			BaseItem baseItem = (base_ = new BaseItem());
			freeTimeSchedule_ = ScheduleType.Outdoor;
		}

		[Cpp2IlInjected.Token(Token = "0x6004491")]
		[Cpp2IlInjected.Address(RVA = "0x723BC0", Offset = "0x7225C0", VA = "0x180723BC0")]
		[DebuggerNonUserCode]
		public Character(Character other)
		{
			//IL_0044: Expected I4, but got I8
			//IL_006d: Expected I4, but got I8
			//IL_008b: Expected O, but got I4
			//IL_00f9: Expected O, but got I4
			//IL_0151: Expected O, but got I4
			//IL_016f: Expected O, but got I4
			int num = (friendshipLevel_ = 0);
			BaseItem baseItem = (base_ = new BaseItem());
			freeTimeSchedule_ = ScheduleType.Outdoor;
			BaseItem baseItem2 = other.base_;
			if (baseItem2 != null)
			{
				BaseItem baseItem3 = baseItem2.Clone();
			}
			base_ = (BaseItem)num;
			int num2 = (friendshipLevel_ = other.friendshipLevel_);
			int num3 = (friendship_ = other.friendship_);
			uint num4 = (happiness_ = other.happiness_);
			Types.CharacterStatus characterStatus = (status_ = other.status_);
			bool flag = (discussedWithTheAvatarToday_ = other.discussedWithTheAvatarToday_);
			Timestamp timestamp = other.lastGiftDate_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			lastGiftDate_ = (Timestamp)num;
			RepeatedField<int> repeatedField = (latestGiftedItems_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.latestGiftedItems_).Clone());
			MapField<int, PreferredItemStatus> mapField = (preferredItemStatus_ = (MapField<int, PreferredItemStatus>)(object)((MapField<TKey, TValue>)(object)other.preferredItemStatus_).Clone());
			ScheduleType scheduleType = (freeTimeSchedule_ = other.freeTimeSchedule_);
			Timestamp timestamp3 = other.freeTimeScheduleTimestamp_;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			freeTimeScheduleTimestamp_ = (Timestamp)num;
			SecretCharacterRecurringConditionData secretCharacterRecurringConditionData = other.secretCharacterData_;
			if (secretCharacterRecurringConditionData != null)
			{
				SecretCharacterRecurringConditionData secretCharacterRecurringConditionData2 = secretCharacterRecurringConditionData.Clone();
			}
			secretCharacterData_ = (SecretCharacterRecurringConditionData)num;
			int num5 = (professionID_ = other.professionID_);
			Timestamp timestamp5 = other.lastSelfieDate_;
			Timestamp timestamp6 = default(Timestamp);
			if (timestamp5 != null)
			{
				timestamp6 = timestamp5.Clone();
			}
			lastSelfieDate_ = timestamp6;
			RepeatedField<PreferredItemSlot> repeatedField2 = (preferredItemSlots_ = (RepeatedField<PreferredItemSlot>)(object)((RepeatedField<T>)(object)other.preferredItemSlots_).Clone());
			bool flag2 = (seenPreferredItems_ = other.seenPreferredItems_);
			RepeatedField<ItemReward> repeatedField3 = (pendingHangoutGatherRewards_ = (RepeatedField<ItemReward>)(object)((RepeatedField<T>)(object)other.pendingHangoutGatherRewards_).Clone());
			int num6 = (skinID_ = other.skinID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004492")]
		[Cpp2IlInjected.Address(RVA = "0x71CC80", Offset = "0x71B680", VA = "0x18071CC80", Slot = "10")]
		[DebuggerNonUserCode]
		public Character Clone()
		{
			return new Character(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60044B3")]
		[Cpp2IlInjected.Address(RVA = "0x71CF00", Offset = "0x71B900", VA = "0x18071CF00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((Character)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60044B4")]
		[Cpp2IlInjected.Address(RVA = "0x71CCE0", Offset = "0x71B6E0", VA = "0x18071CCE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Character other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				BaseItem objB = other.base_;
				if (object.Equals(base_, objB))
				{
					int num = other.friendshipLevel_;
					if (friendshipLevel_ == num)
					{
						int num2 = other.friendship_;
						if (friendship_ == num2)
						{
							uint num3 = other.happiness_;
							if (happiness_ == num3)
							{
								Types.CharacterStatus characterStatus = other.status_;
								if (status_ == characterStatus)
								{
									bool flag = other.discussedWithTheAvatarToday_;
									if ((IntPtr)EmptyProfessionList == (IntPtr)(flag ? 1 : 0))
									{
										Timestamp objB2 = other.lastGiftDate_;
										if (object.Equals(lastGiftDate_, objB2))
										{
											RepeatedField<int> repeatedField = latestGiftedItems_;
											RepeatedField<int> repeatedField2 = other.latestGiftedItems_;
											if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
											{
												MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
												MapField<int, PreferredItemStatus> mapField2 = other.preferredItemStatus_;
												if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
												{
													ScheduleType scheduleType = other.freeTimeSchedule_;
													if (freeTimeSchedule_ == scheduleType)
													{
														Timestamp objB3 = other.freeTimeScheduleTimestamp_;
														if (object.Equals(freeTimeScheduleTimestamp_, objB3))
														{
															SecretCharacterRecurringConditionData objB4 = other.secretCharacterData_;
															if (object.Equals(secretCharacterData_, objB4))
															{
																int num4 = other.professionID_;
																if (professionID_ == num4)
																{
																	Timestamp objB5 = other.lastSelfieDate_;
																	if (object.Equals(lastSelfieDate_, objB5))
																	{
																		RepeatedField<PreferredItemSlot> repeatedField3 = preferredItemSlots_;
																		RepeatedField<PreferredItemSlot> repeatedField4 = other.preferredItemSlots_;
																		if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																		{
																			bool flag2 = other.seenPreferredItems_;
																			if (seenPreferredItems_ == flag2)
																			{
																				RepeatedField<ItemReward> repeatedField5 = pendingHangoutGatherRewards_;
																				RepeatedField<ItemReward> repeatedField6 = other.pendingHangoutGatherRewards_;
																				if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
																				{
																					int num5 = other.skinID_;
																					if (skinID_ == num5)
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
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044B5")]
		[Cpp2IlInjected.Address(RVA = "0x71F3E0", Offset = "0x71DDE0", VA = "0x18071F3E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_010f
			int num = 0;
			BaseItem baseItem = base_;
			if (baseItem != null)
			{
				int hashCode = baseItem.GetHashCode();
			}
			if (friendshipLevel_ != 0)
			{
			}
			if (friendship_ != 0)
			{
			}
			if (happiness_ != 0)
			{
			}
			if (status_ != 0)
			{
			}
			if (discussedWithTheAvatarToday_)
			{
			}
			Timestamp timestamp = lastGiftDate_;
			if (timestamp != null)
			{
				int hashCode2 = timestamp.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)latestGiftedItems_).GetHashCode();
			int hashCode4 = ((MapField<TKey, TValue>)(object)preferredItemStatus_).GetHashCode();
			if (freeTimeSchedule_ != 0)
			{
			}
			Timestamp timestamp2 = freeTimeScheduleTimestamp_;
			if (timestamp2 != null)
			{
				int hashCode5 = timestamp2.GetHashCode();
			}
			SecretCharacterRecurringConditionData secretCharacterRecurringConditionData = secretCharacterData_;
			if (secretCharacterRecurringConditionData != null)
			{
				int hashCode6 = secretCharacterRecurringConditionData.GetHashCode();
			}
			if (professionID_ != 0)
			{
			}
			Timestamp timestamp3 = lastSelfieDate_;
			if (timestamp3 != null)
			{
				int hashCode7 = timestamp3.GetHashCode();
			}
			int hashCode8 = ((RepeatedField<T>)(object)preferredItemSlots_).GetHashCode();
			if (seenPreferredItems_)
			{
			}
			int hashCode9 = ((RepeatedField<T>)(object)pendingHangoutGatherRewards_).GetHashCode();
			if (skinID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode10 = unknownFields.GetHashCode();
			}
			return hashCode4;
		}

		[Cpp2IlInjected.Token(Token = "0x60044B6")]
		[Cpp2IlInjected.Address(RVA = "0x7230F0", Offset = "0x721AF0", VA = "0x1807230F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60044B7")]
		[Cpp2IlInjected.Address(RVA = "0x723340", Offset = "0x721D40", VA = "0x180723340", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01bd
			if ((long)_repeated_preferredItemSlots_codec != 0)
			{
				BaseItem value = base_;
				output.WriteMessage(value);
			}
			if (friendshipLevel_ != 0)
			{
				int value2 = friendshipLevel_;
				output.WriteInt32(value2);
			}
			if (friendship_ != 0)
			{
				int value3 = friendship_;
				output.WriteInt32(value3);
			}
			if (happiness_ != 0)
			{
				uint value4 = happiness_;
				output.WriteUInt32(value4);
			}
			if (status_ != 0)
			{
			}
			if ((long)EmptyProfessionList != 0)
			{
				bool value5 = discussedWithTheAvatarToday_;
				output.WriteBool(value5);
			}
			if ((long)lastGiftDate_ != 0)
			{
				Timestamp value6 = lastGiftDate_;
				output.WriteMessage(value6);
			}
			RepeatedField<int> repeatedField = latestGiftedItems_;
			FieldCodec<int> repeated_latestGiftedItems_codec = _repeated_latestGiftedItems_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_latestGiftedItems_codec);
			MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
			MapField<int, PreferredItemStatus>.Codec map_preferredItemStatus_codec = _map_preferredItemStatus_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_preferredItemStatus_codec);
			if (freeTimeSchedule_ != 0)
			{
			}
			if ((long)freeTimeScheduleTimestamp_ != 0)
			{
				Timestamp value7 = freeTimeScheduleTimestamp_;
				output.WriteMessage(value7);
			}
			if ((long)secretCharacterData_ != 0)
			{
				SecretCharacterRecurringConditionData value8 = secretCharacterData_;
				output.WriteMessage(value8);
			}
			if (professionID_ != 0)
			{
				int value9 = professionID_;
				output.WriteInt32(value9);
			}
			if ((long)lastSelfieDate_ != 0)
			{
				Timestamp value10 = lastSelfieDate_;
				output.WriteMessage(value10);
			}
			RepeatedField<PreferredItemSlot> repeatedField2 = preferredItemSlots_;
			FieldCodec<PreferredItemSlot> repeated_preferredItemSlots_codec = _repeated_preferredItemSlots_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_preferredItemSlots_codec);
			if (seenPreferredItems_)
			{
				bool value11 = seenPreferredItems_;
				output.WriteBool(value11);
			}
			RepeatedField<ItemReward> repeatedField3 = pendingHangoutGatherRewards_;
			FieldCodec<ItemReward> repeated_pendingHangoutGatherRewards_codec = _repeated_pendingHangoutGatherRewards_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_pendingHangoutGatherRewards_codec);
			if (skinID_ != 0)
			{
				int value12 = skinID_;
				output.WriteInt32(value12);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60044B8")]
		[Cpp2IlInjected.Address(RVA = "0x71C4C0", Offset = "0x71AEC0", VA = "0x18071C4C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected O, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected O, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected O, but got Unknown
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			BaseItem baseItem = base_;
			int num = 0;
			if (baseItem != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(baseItem);
			}
			int num3 = friendshipLevel_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			int num5 = friendship_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			uint num7 = happiness_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeUInt32Size(num7);
				num8++;
				num += num8;
			}
			Types.CharacterStatus characterStatus = status_;
			if (characterStatus != 0)
			{
				int num9 = CodedOutputStream.ComputeEnumSize((int)characterStatus);
				num9++;
				num += num9;
			}
			Timestamp timestamp = lastGiftDate_;
			if (timestamp != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(timestamp);
				num10++;
				num += num10;
			}
			RepeatedField<int> repeatedField = latestGiftedItems_;
			FieldCodec<int> repeated_latestGiftedItems_codec = _repeated_latestGiftedItems_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_latestGiftedItems_codec);
			MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
			MapField<int, PreferredItemStatus>.Codec map_preferredItemStatus_codec = _map_preferredItemStatus_codec;
			int num12 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_preferredItemStatus_codec);
			ScheduleType scheduleType = freeTimeSchedule_;
			if (scheduleType != 0)
			{
				int num13 = CodedOutputStream.ComputeEnumSize((int)scheduleType);
				num13++;
				repeatedField = (RepeatedField<int>)(repeatedField + num13);
			}
			Timestamp timestamp2 = freeTimeScheduleTimestamp_;
			if (timestamp2 != null)
			{
				int num14 = CodedOutputStream.ComputeMessageSize(timestamp2);
				num14 += 2;
				repeatedField = (RepeatedField<int>)(repeatedField + num14);
			}
			SecretCharacterRecurringConditionData secretCharacterRecurringConditionData = secretCharacterData_;
			if (secretCharacterRecurringConditionData != null)
			{
				int num15 = CodedOutputStream.ComputeMessageSize(secretCharacterRecurringConditionData);
				num15 += 2;
				repeatedField = (RepeatedField<int>)(repeatedField + num15);
			}
			int num16 = professionID_;
			if (num16 != 0)
			{
				int num17 = CodedOutputStream.ComputeInt32Size(num16);
				num17 += 2;
				repeatedField = (RepeatedField<int>)(repeatedField + num17);
			}
			Timestamp timestamp3 = lastSelfieDate_;
			if (timestamp3 != null)
			{
				int num18 = CodedOutputStream.ComputeMessageSize(timestamp3);
				num18 += 2;
				repeatedField = (RepeatedField<int>)(repeatedField + num18);
			}
			RepeatedField<PreferredItemSlot> repeatedField2 = preferredItemSlots_;
			FieldCodec<PreferredItemSlot> repeated_preferredItemSlots_codec = _repeated_preferredItemSlots_codec;
			int num19 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_preferredItemSlots_codec);
			RepeatedField<ItemReward> repeatedField3 = pendingHangoutGatherRewards_;
			FieldCodec<ItemReward> repeated_pendingHangoutGatherRewards_codec = _repeated_pendingHangoutGatherRewards_codec;
			int num20 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_pendingHangoutGatherRewards_codec);
			int num21 = skinID_;
			if (num21 != 0)
			{
				int num22 = CodedOutputStream.ComputeInt32Size(num21);
				num22 += 2;
				repeatedField3 = (RepeatedField<ItemReward>)(repeatedField3 + num22);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num23 = unknownFields.CalculateSize();
				repeatedField3 = (RepeatedField<ItemReward>)(repeatedField3 + num23);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044B9")]
		[Cpp2IlInjected.Address(RVA = "0x722290", Offset = "0x720C90", VA = "0x180722290", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Character other)
		{
			//Discarded unreachable code: IL_0271
			if (other == null)
			{
				return;
			}
			if ((long)_repeated_preferredItemSlots_codec != 0)
			{
				BaseItem baseItem = base_;
				if (baseItem == null)
				{
					BaseItem baseItem2 = (base_ = new BaseItem());
					BaseItem baseItem3 = base_;
				}
				BaseItem other2 = other.base_;
				baseItem.MergeFrom(other2);
			}
			int num = other.friendshipLevel_;
			if (num != 0)
			{
				friendshipLevel_ = num;
			}
			int num2 = other.friendship_;
			if (num2 != 0)
			{
				friendship_ = num2;
			}
			uint num3 = other.happiness_;
			if (num3 != 0)
			{
				happiness_ = num3;
			}
			Types.CharacterStatus characterStatus = other.status_;
			if (characterStatus != 0)
			{
				status_ = characterStatus;
			}
			bool flag = other.discussedWithTheAvatarToday_;
			if (flag)
			{
				discussedWithTheAvatarToday_ = flag;
			}
			if ((long)other.lastGiftDate_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastGiftDate_ == null)
				{
					Timestamp timestamp = (lastGiftDate_ = new Timestamp());
					timestamp2 = lastGiftDate_;
				}
				Timestamp other3 = other.lastGiftDate_;
				timestamp2.MergeFrom(other3);
			}
			RepeatedField<int> repeatedField = latestGiftedItems_;
			RepeatedField<int> repeatedField2 = other.latestGiftedItems_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
			MapField<int, PreferredItemStatus> mapField2 = other.preferredItemStatus_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			ScheduleType scheduleType = other.freeTimeSchedule_;
			if (scheduleType != 0)
			{
				freeTimeSchedule_ = scheduleType;
			}
			if ((long)other.freeTimeScheduleTimestamp_ != 0)
			{
				Timestamp timestamp4 = default(Timestamp);
				if (freeTimeScheduleTimestamp_ == null)
				{
					Timestamp timestamp3 = (freeTimeScheduleTimestamp_ = new Timestamp());
					timestamp4 = freeTimeScheduleTimestamp_;
				}
				Timestamp other4 = other.freeTimeScheduleTimestamp_;
				timestamp4.MergeFrom(other4);
			}
			if ((long)other.secretCharacterData_ != 0)
			{
				SecretCharacterRecurringConditionData secretCharacterRecurringConditionData2 = default(SecretCharacterRecurringConditionData);
				if (secretCharacterData_ == null)
				{
					SecretCharacterRecurringConditionData secretCharacterRecurringConditionData = (secretCharacterData_ = new SecretCharacterRecurringConditionData());
					secretCharacterRecurringConditionData2 = secretCharacterData_;
				}
				SecretCharacterRecurringConditionData other5 = other.secretCharacterData_;
				secretCharacterRecurringConditionData2.MergeFrom(other5);
			}
			int num4 = other.professionID_;
			if (num4 != 0)
			{
				professionID_ = num4;
			}
			if ((long)other.lastSelfieDate_ != 0)
			{
				Timestamp timestamp6 = default(Timestamp);
				if (lastSelfieDate_ == null)
				{
					Timestamp timestamp5 = (lastSelfieDate_ = new Timestamp());
					timestamp6 = lastSelfieDate_;
				}
				Timestamp other6 = other.lastSelfieDate_;
				timestamp6.MergeFrom(other6);
			}
			RepeatedField<PreferredItemSlot> repeatedField3 = preferredItemSlots_;
			RepeatedField<PreferredItemSlot> repeatedField4 = other.preferredItemSlots_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			bool flag2 = other.seenPreferredItems_;
			if (flag2)
			{
				seenPreferredItems_ = flag2;
			}
			RepeatedField<ItemReward> repeatedField5 = pendingHangoutGatherRewards_;
			RepeatedField<ItemReward> repeatedField6 = other.pendingHangoutGatherRewards_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			int num5 = other.skinID_;
			if (num5 != 0)
			{
				skinID_ = num5;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60044BA")]
		[Cpp2IlInjected.Address(RVA = "0x721D70", Offset = "0x720770", VA = "0x180721D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_02be
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 74)
			{
				if ((int)num > 144)
				{
					if ((int)num > 162)
					{
						if (num == 168)
						{
							bool flag = (seenPreferredItems_ = input.ReadBool());
						}
						if (num == 178)
						{
							RepeatedField<ItemReward> repeatedField = pendingHangoutGatherRewards_;
							FieldCodec<ItemReward> repeated_pendingHangoutGatherRewards_codec = _repeated_pendingHangoutGatherRewards_codec;
							((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_pendingHangoutGatherRewards_codec);
						}
						if (num != 184)
						{
							goto IL_02a7;
						}
						int num2 = (skinID_ = input.ReadInt32());
					}
					Timestamp timestamp = default(Timestamp);
					if (num == 154)
					{
						Timestamp builder = default(Timestamp);
						if (lastSelfieDate_ == null)
						{
							timestamp = (lastSelfieDate_ = new Timestamp());
							builder = lastSelfieDate_;
						}
						input.ReadMessage(builder);
					}
					if ((long)timestamp != 162)
					{
						goto IL_02a7;
					}
					RepeatedField<PreferredItemSlot> repeatedField2 = preferredItemSlots_;
					FieldCodec<PreferredItemSlot> repeated_preferredItemSlots_codec = _repeated_preferredItemSlots_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_preferredItemSlots_codec);
				}
				int num3 = default(int);
				if ((int)num > 120)
				{
					Timestamp timestamp2 = default(Timestamp);
					if (num == 130)
					{
						Timestamp builder2 = default(Timestamp);
						if (freeTimeScheduleTimestamp_ == null)
						{
							timestamp2 = (freeTimeScheduleTimestamp_ = new Timestamp());
							builder2 = freeTimeScheduleTimestamp_;
						}
						input.ReadMessage(builder2);
					}
					SecretCharacterRecurringConditionData secretCharacterRecurringConditionData = default(SecretCharacterRecurringConditionData);
					if ((long)timestamp2 == 138)
					{
						SecretCharacterRecurringConditionData builder3 = default(SecretCharacterRecurringConditionData);
						if (secretCharacterData_ == null)
						{
							secretCharacterRecurringConditionData = (secretCharacterData_ = new SecretCharacterRecurringConditionData());
							builder3 = secretCharacterData_;
						}
						input.ReadMessage(builder3);
					}
					if ((long)secretCharacterRecurringConditionData != 144)
					{
						goto IL_02a7;
					}
					num3 = (professionID_ = input.ReadInt32());
				}
				if (num3 == 82)
				{
					MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
					MapField<int, PreferredItemStatus>.Codec map_preferredItemStatus_codec = _map_preferredItemStatus_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_preferredItemStatus_codec);
				}
				if (num3 != 120)
				{
					goto IL_02a7;
				}
				int num4 = (int)(freeTimeSchedule_ = (ScheduleType)input.ReadInt32());
			}
			bool flag2 = default(bool);
			if ((int)num > 40)
			{
				Timestamp timestamp3 = default(Timestamp);
				if ((int)num > 56)
				{
					if (num == 66)
					{
						Timestamp builder4 = default(Timestamp);
						if (lastGiftDate_ == null)
						{
							timestamp3 = (lastGiftDate_ = new Timestamp());
							builder4 = lastGiftDate_;
						}
						input.ReadMessage(builder4);
					}
					if ((long)timestamp3 != 4294967293L)
					{
						goto IL_02a7;
					}
					RepeatedField<int> repeatedField3 = latestGiftedItems_;
					FieldCodec<int> repeated_latestGiftedItems_codec = _repeated_latestGiftedItems_codec;
					((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_latestGiftedItems_codec);
				}
				int num5 = default(int);
				if ((long)timestamp3 == 48)
				{
					num5 = (int)(status_ = (Types.CharacterStatus)input.ReadInt32());
				}
				if (num5 != 56)
				{
					goto IL_02a7;
				}
				flag2 = (discussedWithTheAvatarToday_ = input.ReadBool());
			}
			int num7 = default(int);
			if ((flag2 ? 1 : 0) > (true ? 1 : 0))
			{
				int num6 = default(int);
				if (flag2)
				{
					num6 = (friendship_ = input.ReadInt32());
				}
				if (num6 != 40)
				{
					goto IL_02a7;
				}
				num7 = (int)(happiness_ = (uint)input.ReadInt32());
			}
			BaseItem baseItem = default(BaseItem);
			if (num7 == 10)
			{
				BaseItem builder5 = default(BaseItem);
				if (base_ == null)
				{
					baseItem = (base_ = new BaseItem());
					builder5 = base_;
				}
				input.ReadMessage(builder5);
			}
			if ((long)baseItem == 24)
			{
				int num8 = (friendshipLevel_ = input.ReadInt32());
			}
			goto IL_02a7;
			IL_02a7:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60044BB")]
		[Cpp2IlInjected.Address(RVA = "0x71EC10", Offset = "0x71D610", VA = "0x18071EC10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 22)
			{
				BaseItem baseItem = base_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044BC")]
		[Cpp2IlInjected.Address(RVA = "0x722A60", Offset = "0x721460", VA = "0x180722A60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_0026, IL_002e, IL_0036, IL_003e, IL_004a
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 22)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				base_ = (BaseItem)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044BD")]
		[Cpp2IlInjected.Address(RVA = "0x71CA30", Offset = "0x71B430", VA = "0x18071CA30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0008, IL_0009, IL_000a, IL_000b, IL_000c, IL_000d, IL_000e, IL_0010
			if (fieldNumber - 1 > 22)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044BE")]
		[Cpp2IlInjected.Address(RVA = "0x71D550", Offset = "0x71BF50", VA = "0x18071D550")]
		public unsafe void GeneratePreferredItems(Profile profile, ITransactionContext context, [Optional] PreferredItemSlot.PreferredItemCache preferredItemCache)
		{
			//Discarded unreachable code: IL_01c2, IL_01c8, IL_01d4
			//IL_00d9: Expected I4, but got O
			//IL_00f1: Expected I4, but got O
			//IL_00fa: Expected O, but got I4
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			CharacterItemData characterItemData = default(CharacterItemData);
			Item invalid2 = default(Item);
			int count3 = default(int);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			IOrderedEnumerable<PreferredItemSlot> orderedEnumerable = default(IOrderedEnumerable<PreferredItemSlot>);
			uint num8 = default(uint);
			int num10 = default(int);
			PreferredItemSlot preferredItemSlot2 = default(PreferredItemSlot);
			bool flag6 = default(bool);
			PreferredItemSlot preferredItemSlot3 = default(PreferredItemSlot);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = base_.Item;
				Item invalid = Item.Invalid;
				bool flag = ProtoDatabase.Instance.TryGet("PreferredItemSettings", out *(PreferredItemSettings*)num);
				if (flag)
				{
					if (flag2)
					{
						while (!flag3)
						{
						}
					}
					if (num != 0)
					{
						break;
					}
				}
				if (flag)
				{
					if (characterItemData != null)
					{
						Item preferredItemsProfileItem = characterItemData.PreferredItemsProfileItem;
					}
					invalid2 = Item.Invalid;
				}
				PreferenceProfileItemData itemData = ItemDatabase.Instance.GetItemData<PreferenceProfileItemData>(invalid2);
				if (profile == null || itemData == null || characterItemData == null)
				{
					return;
				}
				((RepeatedField<T>)(object)preferredItemSlots_).Clear();
				int count = ((RepeatedField<T>)(object)itemData.slots_).Count;
				if (num < count)
				{
					PreferredItemSlot preferredItemSlot = new PreferredItemSlot();
					preferredItemSlot.Difficulty = (PreferredItemDifficulty)num;
					int count2 = ((RepeatedField<T>)(object)characterItemData.preferredItemDifficulties_).Count;
					if (num < count2)
					{
						PreferredItemDifficulty preferredItemDifficulty = (preferredItemSlot.Difficulty = (PreferredItemDifficulty)((RepeatedField<T>)(object)characterItemData.preferredItemDifficulties_)[num]);
					}
					int num5 = (int)((RepeatedField<T>)(object)itemData.slots_)[num];
					preferredItemSlot.PoolItem = (Item)num5;
					((RepeatedField<T>)(object)preferredItemSlots_).Add((T)preferredItemSlot);
					num++;
				}
				Random random = new Random(count3);
				PreferredItemSlot.PreferredItemCache preferredItemCache2 = new PreferredItemSlot.PreferredItemCache();
				count3 = ((RepeatedField<T>)(object)preferredItemSlots_).Count;
				List<Item> list = (List<Item>)(object)new List<T>(count3);
				RepeatedField<PreferredItemSlot> repeatedField = preferredItemSlots_;
				if (flag4)
				{
					while (!flag5)
					{
					}
				}
				int num6 = 0;
				if (num != 0)
				{
					continue;
				}
				if (_003C_003Ec._003C_003E9__114_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((PreferredItemSlot x) => x.Difficulty);
				}
				int size = Enumerable.ToList<PreferredItemSlot>((IEnumerable<>)orderedEnumerable)._size;
				if (num6 < size)
				{
					int num7 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					num6++;
					num8 += 8;
				}
				int num9 = 0;
				if (DefaultDiscoveryStatus != 0 && num6 < num10)
				{
					int preferredItemId_ = preferredItemSlot2.preferredItemId_;
					if (flag6)
					{
						int preferredItemId_2 = preferredItemSlot3.preferredItemId_;
					}
					num6++;
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044C8")]
		[Cpp2IlInjected.Address(RVA = "0x721200", Offset = "0x71FC00", VA = "0x180721200")]
		public unsafe void Initialize(Profile profile, in World world, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00ab
			//IL_0015: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			this.profile = profile;
			this.dispatcher = dispatcher;
			this.context = (ITransactionContext)0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<CharacterSkinItemData, bool> func = (Func<CharacterSkinItemData, bool>)(object)(Func<T, TResult>)delegate(CharacterSkinItemData x)
			{
				//Discarded unreachable code: IL_0047
				do
				{
					Item characterItem = x.CharacterItem;
					Item item = base_.Item;
					if (!(*(Item*)characterItem == *(Item*)item))
					{
						int num2 = 0;
					}
				}
				while (x.conditions_.IsEmpty);
				ListInventory skins = this.profile.Skins;
				Item item2 = x.Item;
				bool flag = default(bool);
				return !flag;
			};
			IEnumerable<> enumerable = default(IEnumerable<>);
			CharacterSkinItemData[] array = (conditionalCharacterSkins = Enumerable.Where<CharacterSkinItemData>(enumerable, (Func<, >)(object)func).ToArray<CharacterSkinItemData>());
			CharacterSkinItemData[] array2 = conditionalCharacterSkins;
			if (array2.Length != 0)
			{
				Func<ConditionListener, CharacterSkinItemData, ConditionListener> _003C_003E9__137_ = _003C_003Ec._003C_003E9__137_1;
				if (_003C_003E9__137_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)((ConditionListener x, CharacterSkinItemData y) => y.conditions_.Listener);
				}
				int num = 0;
				CharacterSkinItemData characterSkinItemData = Enumerable.Aggregate<CharacterSkinItemData, ConditionListener>((IEnumerable<>)(object)array2, (CharacterSkinItemData)num, (Func<, , >)(object)_003C_003E9__137_);
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
				int conditionListener = 0;
				OnAnyConditionChanged((ConditionListener)conditionListener);
			}
			if (status_ == Types.CharacterStatus.Secret && secretCharacterData_ == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044C9")]
		[Cpp2IlInjected.Address(RVA = "0x721CE0", Offset = "0x7206E0", VA = "0x180721CE0")]
		private bool IsValidConditionalCharacterSkin(CharacterSkinItemData skin)
		{
			//Discarded unreachable code: IL_0028
			if (skin.conditions_.IsEmpty)
			{
				int num = 0;
			}
			ListInventory skins = profile.Skins;
			Item item = skin.Item;
			bool flag = default(bool);
			return !flag;
		}

		[Cpp2IlInjected.Token(Token = "0x60044CA")]
		[Cpp2IlInjected.Address(RVA = "0x7225D0", Offset = "0x720FD0", VA = "0x1807225D0")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_00da, IL_00e0, IL_00e6, IL_00ec, IL_00f2, IL_00f8, IL_00fe
			//IL_00ab: Expected I4, but got O
			//IL_00b4: Expected I4, but got O
			uint num4 = default(uint);
			Item item = default(Item);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			do
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				CharacterSkinItemData[] array = conditionalCharacterSkins;
				Func<CharacterSkinItemData, bool> func = (Func<CharacterSkinItemData, bool>)(object)(Func<T, TResult>)delegate(CharacterSkinItemData x)
				{
					//Discarded unreachable code: IL_0028
					if (x.conditions_.IsEmpty)
					{
						int num6 = 0;
					}
					ListInventory skins = this.profile.Skins;
					Item item2 = x.Item;
					bool flag4 = default(bool);
					return !flag4;
				};
				IEnumerable<CharacterSkinItemData> enumerable = (IEnumerable<CharacterSkinItemData>)Enumerable.Where<CharacterSkinItemData>((IEnumerable<>)(object)array, (Func<, >)(object)func);
				if (enumerable != null)
				{
					if (num3 < (int)num4)
					{
						num3 += num3;
						if (num3 == (int)num4)
						{
							goto IL_00cc;
						}
						num3++;
					}
					int num5 = skinID_;
					int itemID = item.ItemID;
					ITransactionContext transactionContext = context;
					Profile profile = this.profile;
					bool flag = num5 == itemID;
					if (flag2)
					{
						Profile profile2 = this.profile;
						if (flag3)
						{
							Profile profile3 = this.profile;
							ProfileEventDispatcher profileEventDispatcher = dispatcher;
							ITransactionContext transactionContext2 = context;
						}
					}
					while (flag == flag2)
					{
					}
					ApplyCharacterSkin.Types.Request request = new ApplyCharacterSkin.Types.Request();
					request.characterID_ = (int)request;
					request.skinID_ = (int)request;
					ApplyCharacterSkin.Types.Response response = new ApplyCharacterSkin.Types.Response();
					response.request_ = request;
					response.automatic = true;
				}
				goto IL_00cc;
				IL_00cc:
				if (enumerable != null)
				{
				}
			}
			while (flag2);
		}

		[Cpp2IlInjected.Token(Token = "0x60044CB")]
		[Cpp2IlInjected.Address(RVA = "0x721B90", Offset = "0x720590", VA = "0x180721B90")]
		public bool IsSecretCharacterVisiting(DateTime localTime)
		{
			if (status_ == Types.CharacterStatus.Secret)
			{
				SecretCharacterRecurringConditionData secretCharacterRecurringConditionData = secretCharacterData_;
				if (secretCharacterRecurringConditionData != null && (long)secretCharacterRecurringConditionData.lastVisit_ != 0)
				{
					if (Data.secretCharacterData_.apparitionCase_ != Definitions.Items.SecretCharacterData.ApparitionOneofCase.Always)
					{
						DateTime dateTime = secretCharacterData_.lastVisit_.ToDateTime();
						TimeSpan duration = Data.secretCharacterData_.SpecificMoment.time_.Duration;
						DateTime dateTime2 = dateTime + duration;
						return localTime < dateTime2;
					}
					return true;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044CC")]
		[Cpp2IlInjected.Address(RVA = "0x7216F0", Offset = "0x7200F0", VA = "0x1807216F0")]
		public unsafe bool IsInactiveAndTargetedByMission(Profile profile)
		{
			int num = 0;
			int num2 = 0;
			if (status_ == Types.CharacterStatus.Unlocked)
			{
				MapField<int, MissionQueue> missionSlots_ = profile.world_.missionSlots_;
				bool flag = default(bool);
				if (flag)
				{
					if (profile != null)
					{
						Predicate<MissionSlot> predicate = (Predicate<MissionSlot>)(object)(Predicate<T>)delegate(MissionSlot x)
						{
							Item characterItem = x.CharacterItem;
							Item item = base_.Item;
							if (*(Item*)characterItem != *(Item*)item && x.IsMissionStarted)
							{
								Item item2 = base_.Item;
								bool flag2 = default(bool);
								if (flag2)
								{
									return !x.OwnerInactive;
								}
							}
							int num4 = 0;
							throw new NullReferenceException();
						};
					}
					while (num2 == 1)
					{
					}
					num2++;
				}
				if (num2 + 1 == 0)
				{
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044CD")]
		[Cpp2IlInjected.Address(RVA = "0x71F370", Offset = "0x71DD70", VA = "0x18071F370")]
		public RepeatedField<FriendshipLevel> GetFriendshipLevels()
		{
			//Discarded unreachable code: IL_0013
			int itemID = base_.Item.ItemID;
			RepeatedField<FriendshipLevel> result = default(RepeatedField<FriendshipLevel>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60044CE")]
		[Cpp2IlInjected.Address(RVA = "0x71EBE0", Offset = "0x71D5E0", VA = "0x18071EBE0")]
		public int GetDiscussionBaseFriendship()
		{
			//Discarded unreachable code: IL_0013
			int itemID = base_.Item.ItemID;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60044CF")]
		[Cpp2IlInjected.Address(RVA = "0x71F3A0", Offset = "0x71DDA0", VA = "0x18071F3A0")]
		public int GetGiftBaseFriendship(Item giftItem, ItemState giftState)
		{
			//Discarded unreachable code: IL_0013
			int itemID = base_.Item.ItemID;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60044D0")]
		[Cpp2IlInjected.Address(RVA = "0x71FAC0", Offset = "0x71E4C0", VA = "0x18071FAC0")]
		public float GetXpProgression(Profile profile, int friendship = -1)
		{
			int num = friendshipLevel_;
			num = GetLevelForXp(friendship);
			int xpRequiredForLevel = GetXpRequiredForLevel(friendship, profile);
			int level = num + 1;
			int xpRequiredForLevel2 = GetXpRequiredForLevel(level, profile);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044D1")]
		[Cpp2IlInjected.Address(RVA = "0x71FB70", Offset = "0x71E570", VA = "0x18071FB70")]
		public int GetXpRequiredForLevel(int level, Profile profile)
		{
			//Discarded unreachable code: IL_008b
			RepeatedField<FriendshipLevel> repeatedField = default(RepeatedField<FriendshipLevel>);
			bool flag = default(bool);
			Item item = default(Item);
			Item item2 = default(Item);
			RepeatedField<FriendshipLevel> repeatedField2 = default(RepeatedField<FriendshipLevel>);
			while (true)
			{
				int num = 0;
				if (level > 0)
				{
					int itemID = base_.Item.ItemID;
					if (repeatedField == null)
					{
						break;
					}
					if (flag)
					{
						int num2 = level - 1;
						num++;
					}
					num++;
					if (num != 0)
					{
						return num;
					}
					int itemID2 = item.ItemID;
					int itemID3 = item2.ItemID;
					int count = ((RepeatedField<T>)(object)repeatedField2).Count;
				}
				if (Data.unlockCondition_ == CharacterUnlockCondition.StoryReward)
				{
					if (status_ == Types.CharacterStatus.InEvent)
					{
						int characterMegaEventStoryCount = GetCharacterMegaEventStoryCount(profile);
					}
					if (GetCharacterMainStoryCount(profile) == 4)
					{
						SecretCharacterData secretCharacterData = Data.secretCharacterData_;
					}
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044D4")]
		[Cpp2IlInjected.Address(RVA = "0x71F630", Offset = "0x71E030", VA = "0x18071F630")]
		public int GetLevelForXp(int xp)
		{
			//Discarded unreachable code: IL_002e
			int num = 0;
			int itemID = base_.Item.ItemID;
			RepeatedField<FriendshipLevel> repeatedField = default(RepeatedField<FriendshipLevel>);
			if (repeatedField == null)
			{
			}
			bool flag = default(bool);
			if (flag)
			{
				num++;
			}
			if (num + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044D5")]
		[Cpp2IlInjected.Address(RVA = "0x720810", Offset = "0x71F210", VA = "0x180720810")]
		public MultiReward GiveAllFriendshipRewards(int oldLevel, int newLevel, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0015
			MultiReward multiReward = new MultiReward();
			int num = 0;
			MultiReward other = default(MultiReward);
			multiReward.MergeFrom(other);
			while (oldLevel <= newLevel)
			{
			}
			return multiReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60044D6")]
		[Cpp2IlInjected.Address(RVA = "0x7208F0", Offset = "0x71F2F0", VA = "0x1807208F0")]
		internal MultiReward GiveFriendshipRewards(int level, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00d9, IL_00df, IL_00e5, IL_00eb, IL_00f1, IL_00f7, IL_00fd, IL_0103, IL_0109, IL_010f, IL_0115, IL_011b, IL_0121
			int num = 0;
			MultiReward multiReward = new MultiReward();
			Item item = default(Item);
			int itemID = item.ItemID;
			Predicate<FriendshipLevel> predicate = (Predicate<FriendshipLevel>)(object)(Predicate<T>)delegate(FriendshipLevel x)
			{
				//Discarded unreachable code: IL_0011
				int num2 = level;
				return x.level_ == num2;
			};
			RepeatedField<FriendshipLevel> repeatedField = default(RepeatedField<FriendshipLevel>);
			FriendshipLevel friendshipLevel = ((RepeatedField<>)(object)repeatedField).Find<FriendshipLevel>((Predicate<>)(object)predicate);
			RepeatedField<ItemReward> tier1Reward_ = friendshipLevel.tier1Reward_;
			bool flag = default(bool);
			if (flag)
			{
				RepeatedField<AnyReward> rewards_ = multiReward.rewards_;
				AnyReward item2 = new AnyReward();
				((RepeatedField<T>)(object)rewards_).Add((T)item2);
			}
			RepeatedField<ItemReward> tier2Reward_ = friendshipLevel.tier2Reward_;
			bool flag2 = default(bool);
			if (flag2)
			{
				RepeatedField<AnyReward> rewards_2 = multiReward.rewards_;
				AnyReward item3 = new AnyReward();
				((RepeatedField<T>)(object)rewards_2).Add((T)item3);
			}
			RepeatedField<ItemReward> tier3Reward_ = friendshipLevel.tier3Reward_;
			bool flag3 = default(bool);
			if (flag3)
			{
				RepeatedField<AnyReward> rewards_3 = multiReward.rewards_;
				AnyReward item4 = new AnyReward();
				((RepeatedField<T>)(object)rewards_3).Add((T)item4);
			}
			RepeatedField<ItemReward> levelReward_ = friendshipLevel.levelReward_;
			bool flag4 = default(bool);
			if (flag4)
			{
				RepeatedField<AnyReward> rewards_4 = multiReward.rewards_;
				AnyReward item5 = new AnyReward();
				((RepeatedField<T>)(object)rewards_4).Add((T)item5);
			}
			Item item6 = default(Item);
			int itemID2 = item6.ItemID;
			return multiReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60044D7")]
		[Cpp2IlInjected.Address(RVA = "0x71EE80", Offset = "0x71D880", VA = "0x18071EE80")]
		public MultiReward GetFinalFriendshipReward()
		{
			//Discarded unreachable code: IL_00b4, IL_00ba, IL_00c0, IL_00c6, IL_00cc, IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00ea, IL_00f0, IL_00f6, IL_00fc
			MultiReward multiReward = new MultiReward();
			int itemID = base_.Item.ItemID;
			RepeatedField<FriendshipLevel> cpp2il__autoParamName__idx_ = default(RepeatedField<FriendshipLevel>);
			FriendshipLevel friendshipLevel = ((IEnumerable<>)(object)cpp2il__autoParamName__idx_).Last<FriendshipLevel>();
			RepeatedField<ItemReward> tier1Reward_ = friendshipLevel.tier1Reward_;
			bool flag = default(bool);
			if (flag)
			{
				RepeatedField<AnyReward> rewards_ = multiReward.rewards_;
				AnyReward item = new AnyReward();
				((RepeatedField<T>)(object)rewards_).Add((T)item);
			}
			RepeatedField<ItemReward> tier2Reward_ = friendshipLevel.tier2Reward_;
			bool flag2 = default(bool);
			if (flag2)
			{
				RepeatedField<AnyReward> rewards_2 = multiReward.rewards_;
				AnyReward item2 = new AnyReward();
				((RepeatedField<T>)(object)rewards_2).Add((T)item2);
			}
			RepeatedField<ItemReward> tier3Reward_ = friendshipLevel.tier3Reward_;
			bool flag3 = default(bool);
			if (flag3)
			{
				RepeatedField<AnyReward> rewards_3 = multiReward.rewards_;
				AnyReward item3 = new AnyReward();
				((RepeatedField<T>)(object)rewards_3).Add((T)item3);
			}
			RepeatedField<ItemReward> levelReward_ = friendshipLevel.levelReward_;
			bool flag4 = default(bool);
			if (flag4)
			{
				RepeatedField<AnyReward> rewards_4 = multiReward.rewards_;
				AnyReward item4 = new AnyReward();
				((RepeatedField<T>)(object)rewards_4).Add((T)item4);
			}
			return multiReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60044D9")]
		[Cpp2IlInjected.Address(RVA = "0x71EBC0", Offset = "0x71D5C0", VA = "0x18071EBC0")]
		public int GetCharacterStoryCount(Profile profile)
		{
			while (status_ == Types.CharacterStatus.InEvent)
			{
			}
			return GetCharacterMainStoryCount(profile);
		}

		[Cpp2IlInjected.Token(Token = "0x60044DA")]
		[Cpp2IlInjected.Address(RVA = "0x71E150", Offset = "0x71CB50", VA = "0x18071E150")]
		private int GetCharacterMainStoryCount(Profile profile)
		{
			//Discarded unreachable code: IL_0137, IL_013d, IL_0143, IL_0149
			IEnumerable<> enumerable = default(IEnumerable<>);
			bool flag = default(bool);
			IEnumerable<QuestNode> enumerable2 = default(IEnumerable<QuestNode>);
			uint num6 = default(uint);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int characterId = base_.id_;
				int num4 = characterMainStoryCount;
				if (num4 == -1)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Func<MissionItemData, bool> func = (Func<MissionItemData, bool>)(object)(Func<T, TResult>)delegate(MissionItemData x)
					{
						int num10 = characterId;
						if (x.ownerCharacter_ == num10 && x.type_ == MissionType.Story)
						{
							int questId2 = x.QuestId;
							bool flag3 = default(bool);
							if (flag3)
							{
								return flag3;
							}
						}
						int num11 = 0;
						throw new NullReferenceException();
					};
					MissionItemData missionItemData = Enumerable.FirstOrDefault<MissionItemData>(enumerable, (Func<, >)(object)func);
					if (missionItemData == null)
					{
						break;
					}
					QuestInformation questInfo_ = profile.world_.questInfo_;
					int questId = missionItemData.QuestId;
					if (!flag)
					{
						break;
					}
					characterMainStoryCount = num;
					List<ItemWithState> list = (List<ItemWithState>)(object)new List<T>();
					ItemWithState item = new ItemWithState();
					int num5 = characterId;
					((List<T>)(object)list).Add((T)item);
					if (enumerable2 != null)
					{
						if (num < (int)num6)
						{
							num += num;
							if (num == (int)num6)
							{
								goto IL_00d3;
							}
							num++;
						}
						if (num == characterId)
						{
						}
						while (num5 == 0)
						{
						}
						while (!flag2)
						{
						}
						int num7 = characterMainStoryCount;
						num++;
						goto IL_00d3;
					}
					goto IL_00db;
				}
				goto IL_00ef;
				IL_00d3:
				num += 312;
				goto IL_00db;
				IL_00db:
				num++;
				if (enumerable2 != null)
				{
				}
				if (num != 0)
				{
					continue;
				}
				if (num == 0)
				{
					break;
				}
				goto IL_00ef;
				IL_00ef:
				return num4;
			}
			int val = characterMainStoryCount;
			int num8 = (characterMainStoryCount = Math.Max(1, val));
			Item item2 = base_.Item;
			int num9 = characterMainStoryCount;
			string text = $"GetCharacterMainStoryCount failed on {item2}, using {item2} has default value";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044DB")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71D280", VA = "0x18071E880")]
		private unsafe int GetCharacterMegaEventStoryCount(Profile profile)
		{
			//Discarded unreachable code: IL_0066, IL_006c, IL_0072, IL_0078
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int id_ = base_.id_;
			MegaEventProgress megaEventProgress_ = profile.player_.megaEventProgress_;
			if (megaEventProgress_.IsActive)
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				string _003CName_003Ek__BackingField = megaEventProgress_.Name;
				if (_003CInstance_003Ek__BackingField.TryGet(_003CName_003Ek__BackingField, out *(MegaEventData*)num))
				{
					bool flag = default(bool);
					bool flag2 = default(bool);
					if (flag && flag2)
					{
						MissionItemData missionItemData = default(MissionItemData);
						while (missionItemData.ownerCharacter_ != id_)
						{
						}
						num++;
					}
					return num;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044DC")]
		[Cpp2IlInjected.Address(RVA = "0x71C3F0", Offset = "0x71ADF0", VA = "0x18071C3F0")]
		internal void AddFriendship(int amount, in World world, ITransactionContext context, AddedFriendshipSummary addedFriendshipSummary)
		{
			if (friendshipLevel_ > 0)
			{
				int xp = friendship_;
				int levelForXp = GetLevelForXp(xp);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044DD")]
		[Cpp2IlInjected.Address(RVA = "0x720FD0", Offset = "0x71F9D0", VA = "0x180720FD0")]
		internal void IncreaseStoryFriendship(in World world, ITransactionContext context, AddedFriendshipSummary addedFriendshipSummary)
		{
			//IL_0032: Expected I4, but got I8
			int num = friendship_;
			num = (friendship_ = num + 1);
			if (status_ == Types.CharacterStatus.InEvent)
			{
			}
			int oldLevel = 0;
			int num2 = default(int);
			bool newLevel = num == num2;
			ulong num3 = default(ulong);
			FriendshipChanged(in world, context, 1, oldLevel, newLevel ? 1 : 0, addedFriendshipSummary, (byte)num3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60044DE")]
		[Cpp2IlInjected.Address(RVA = "0x720F30", Offset = "0x71F930", VA = "0x180720F30")]
		internal void IncreaseSecretFriendship(in World world, ITransactionContext context, AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_003a
			//IL_0039: Expected I4, but got I8
			int num = friendship_;
			num = (friendship_ = num + 1);
			SecretCharacterData secretCharacterData = Data.secretCharacterData_;
			int oldLevel = 0;
			bool newLevel = num == secretCharacterData.numberOfMissionsToComplete_;
			ulong num2 = default(ulong);
			FriendshipChanged(in world, context, 1, oldLevel, newLevel ? 1 : 0, addedFriendshipSummary, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60044DF")]
		[Cpp2IlInjected.Address(RVA = "0x71D270", Offset = "0x71BC70", VA = "0x18071D270")]
		private void FriendshipChanged(in World world, ITransactionContext context, int amount, int oldLevel, int newLevel, AddedFriendshipSummary addedFriendshipSummary, bool resetFriendshipOnLevelUp = false)
		{
			//Discarded unreachable code: IL_0067
			IWorldEventDispatcher worldEventDispatcher = world.dispatcher;
			int num = 0;
			uint num2 = default(uint);
			if (worldEventDispatcher != null && num < (int)num2)
			{
				num += num;
				num++;
			}
			friendshipLevel_ = 0;
			friendship_ = num;
			IWorldEventDispatcher worldEventDispatcher2 = world.dispatcher;
			if (worldEventDispatcher2 == null)
			{
				worldEventDispatcher2 = (IWorldEventDispatcher)(object)((object)worldEventDispatcher2 + (object)worldEventDispatcher2);
			}
			int num3 = 0;
			MultiReward multiReward = new MultiReward();
			int num4 = 0;
			MultiReward other = default(MultiReward);
			multiReward.MergeFrom(other);
			Item item = base_.Item;
			if (num < num4)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044E3")]
		[Cpp2IlInjected.Address(RVA = "0x721A90", Offset = "0x720490", VA = "0x180721A90")]
		public bool IsPreferredItem(Item item)
		{
			//Discarded unreachable code: IL_0030
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			RepeatedField<PreferredItemSlot> repeatedField = preferredItemSlots_;
			Predicate<PreferredItemSlot> predicate = (Predicate<PreferredItemSlot>)(object)(Predicate<T>)delegate(PreferredItemSlot x)
			{
				Item preferredItem = x.PreferredItem;
				throw new NullReferenceException();
			};
			return ((RepeatedField<>)(object)repeatedField).Any<PreferredItemSlot>((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60044E4")]
		[Cpp2IlInjected.Address(RVA = "0x71F7D0", Offset = "0x71E1D0", VA = "0x18071F7D0")]
		public int GetPreferredItemIndex(Item item)
		{
			//Discarded unreachable code: IL_0030
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			RepeatedField<PreferredItemSlot> repeatedField = preferredItemSlots_;
			Func<PreferredItemSlot, bool> func = (Func<PreferredItemSlot, bool>)(object)(Func<T, TResult>)delegate(PreferredItemSlot x)
			{
				Item preferredItem = x.PreferredItem;
				throw new NullReferenceException();
			};
			return ((RepeatedField<>)(object)repeatedField).FindIndex<PreferredItemSlot>((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60044E5")]
		[Cpp2IlInjected.Address(RVA = "0x71F940", Offset = "0x71E340", VA = "0x18071F940")]
		private PreferredItemStatus GetPreferredItemStatus(Item item)
		{
			MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044E6")]
		[Cpp2IlInjected.Address(RVA = "0x723000", Offset = "0x721A00", VA = "0x180723000")]
		private void SetPreferredItemStatus(Item item, PreferredItemStatus status)
		{
			//Discarded unreachable code: IL_000c
			bool flag = default(bool);
			if (flag)
			{
				MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044E7")]
		[Cpp2IlInjected.Address(RVA = "0x721070", Offset = "0x71FA70", VA = "0x180721070")]
		internal void InitPreferredItemStatus(PreferredItemStatus status)
		{
			//Discarded unreachable code: IL_0064
			MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
			int num = 0;
			((MapField<TKey, TValue>)(object)mapField).Clear();
			if (status == Definitions.Items.PreferredItemStatus.Unknown)
			{
				return;
			}
			int count = ((RepeatedField<T>)(object)preferredItemSlots_).Count;
			if (num < count)
			{
				int preferredItemId_ = ((PreferredItemSlot)((RepeatedField<T>)(object)preferredItemSlots_)[num]).preferredItemId_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<PreferredItemSlot> repeatedField = preferredItemSlots_;
					MapField<int, PreferredItemStatus> mapField2 = preferredItemStatus_;
					PreferredItemSlot preferredItemSlot = (PreferredItemSlot)((RepeatedField<T>)(object)repeatedField)[num];
				}
				RepeatedField<PreferredItemSlot> repeatedField2 = preferredItemSlots_;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044E8")]
		[Cpp2IlInjected.Address(RVA = "0x71CF60", Offset = "0x71B960", VA = "0x18071CF60")]
		internal unsafe void FixDefaultDiscoveryStatus()
		{
			//Discarded unreachable code: IL_0078, IL_007e
			//IL_0068: Expected O, but got I4
			int num;
			uint num4 = default(uint);
			do
			{
				num = 0;
				int num2 = 0;
				PreferredItemStatus defaultDiscoveryStatus = DefaultDiscoveryStatus;
				int num3 = (int)defaultDiscoveryStatus;
				if (defaultDiscoveryStatus == Definitions.Items.PreferredItemStatus.Unknown)
				{
					break;
				}
				RepeatedField<PreferredItemSlot> repeatedField = preferredItemSlots_;
				Func<PreferredItemSlot, Item> _003C_003E9__171_ = _003C_003Ec._003C_003E9__171_0;
				if (_003C_003E9__171_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(PreferredItemSlot x)
					{
						//Discarded unreachable code: IL_000d
						int preferredItemId_ = x.preferredItemId_;
						return (Item)typeof(Item).TypeHandle;
					};
				}
				IEnumerable<PreferredItemSlot> enumerable = (IEnumerable<PreferredItemSlot>)Enumerable.Select<PreferredItemSlot, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__171_);
				if (enumerable != null)
				{
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_006a;
						}
						num++;
					}
					bool flag = ((MapField<TKey, TValue>)(object)preferredItemStatus_).TryGetValue((TKey)num, out *(TValue*)num);
					goto IL_006a;
				}
				goto IL_006e;
				IL_006e:
				if (enumerable != null)
				{
				}
				continue;
				IL_006a:
				num += num;
				goto IL_006e;
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60044E9")]
		[Cpp2IlInjected.Address(RVA = "0x71F8D0", Offset = "0x71E2D0", VA = "0x18071F8D0")]
		public PreferredItemStatus GetPreferredItemStatus(int index)
		{
			Item preferredItem = GetPreferredItem(index);
			MapField<int, PreferredItemStatus> mapField = preferredItemStatus_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044EA")]
		[Cpp2IlInjected.Address(RVA = "0x7230B0", Offset = "0x721AB0", VA = "0x1807230B0")]
		private void SetPreferredItemStatus(int index, PreferredItemStatus status)
		{
			Item preferredItem = GetPreferredItem(index);
		}

		[Cpp2IlInjected.Token(Token = "0x60044EB")]
		[Cpp2IlInjected.Address(RVA = "0x71F9B0", Offset = "0x71E3B0", VA = "0x18071F9B0")]
		public Item GetPreferredItem(int index)
		{
			return Enumerable.ElementAtOrDefault<PreferredItemSlot>((IEnumerable<>)(object)preferredItemSlots_, index)?.PreferredItem ?? Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x60044EC")]
		[Cpp2IlInjected.Address(RVA = "0x7219B0", Offset = "0x7203B0", VA = "0x1807219B0")]
		public bool IsPreferredItemAlreadyGifted(Item item)
		{
			//Discarded unreachable code: IL_0035
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			RepeatedField<PreferredItemSlot> repeatedField = preferredItemSlots_;
			Func<PreferredItemSlot, bool> func = (Func<PreferredItemSlot, bool>)(object)(Func<T, TResult>)delegate(PreferredItemSlot x)
			{
				Item preferredItem = x.PreferredItem;
				throw new NullReferenceException();
			};
			return Enumerable.First<PreferredItemSlot>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func).gifted_;
		}

		[Cpp2IlInjected.Token(Token = "0x60044ED")]
		[Cpp2IlInjected.Address(RVA = "0x71C480", Offset = "0x71AE80", VA = "0x18071C480")]
		public bool AreSwitcherButtonsUnlocked(IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_000e
			return Data.AreSwitcherButtonsUnlocked(profile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60044EE")]
		[Cpp2IlInjected.Address(RVA = "0x71C910", Offset = "0x71B310", VA = "0x18071C910")]
		public bool CanGiftItem()
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			if (GiftDailyLimitation == -1)
			{
				return true;
			}
			int count = ((RepeatedField<T>)(object)latestGiftedItems_).Count;
			int num2 = 0;
			int giftDailyLimitation = GiftDailyLimitation;
			return count < giftDailyLimitation;
		}

		[Cpp2IlInjected.Token(Token = "0x60044F0")]
		[Cpp2IlInjected.Address(RVA = "0x71FE30", Offset = "0x71E830", VA = "0x18071FE30")]
		internal unsafe GiftItemResult GiftItem(ITransactionContext context, Item item, ItemState state)
		{
			//Discarded unreachable code: IL_0203
			//IL_001d: Expected O, but got I4
			//IL_0161: Expected I4, but got O
			//IL_01f7: Expected I4, but got I8
			int itemID = item.ItemID;
			int num = 0;
			Item item2 = (Item)itemID;
			DateTime localTime = default(DateTime);
			Timestamp timestamp = (lastGiftDate_ = profile.world_.GetServerTime(localTime).ToProto());
			RepeatedField<int> repeatedField = latestGiftedItems_;
			CharacterItemData data = Data;
			Item item3 = item2;
			RepeatedField<PreferredItemSlot> repeatedField2 = preferredItemSlots_;
			Func<PreferredItemSlot, Item> _003C_003E9__187_ = _003C_003Ec._003C_003E9__187_0;
			if (_003C_003E9__187_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(PreferredItemSlot x)
				{
					//Discarded unreachable code: IL_000d
					int preferredItemId_ = x.preferredItemId_;
					return (Item)typeof(Item).TypeHandle;
				};
			}
			IEnumerable<PreferredItemSlot> enumerable = (IEnumerable<PreferredItemSlot>)Enumerable.Select<PreferredItemSlot, Item>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)_003C_003E9__187_);
			Func<PreferredItemStatus, int, (int, PreferredItemStatus, PreferredItemStatus)> func = (Func<PreferredItemStatus, int, (int, PreferredItemStatus, PreferredItemStatus)>)(object)(Func<T1, T2, TResult>)delegate
			{
				int num6 = 0;
				throw new NullReferenceException();
			};
			IEnumerable<PreferredItemStatus> enumerable2 = default(IEnumerable<PreferredItemStatus>);
			List<(int, PreferredItemStatus, PreferredItemStatus)> list = (List<(int, PreferredItemStatus, PreferredItemStatus)>)(object)Enumerable.ToList<(int, PreferredItemStatus, PreferredItemStatus)>(Enumerable.Select<PreferredItemStatus, (int, PreferredItemStatus, PreferredItemStatus)>((IEnumerable<>)enumerable2, (Func<, , >)(object)func));
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item4 = item2;
			IItemData itemData = _003CInstance_003Ek__BackingField.GetItemData(item4);
			BaseItem baseItem = base_;
			Item item5 = item2;
			int itemID2 = baseItem.Item.ItemID;
			int num2 = default(int);
			if (num2 != 0)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				num2 += num;
			}
			int num4 = 0;
			if (ProtoDatabase.Instance.TryGet("PreferredItemSettings", out *(PreferredItemSettings*)num))
			{
				RepeatedField<PreferredItemSlot> repeatedField3 = preferredItemSlots_;
				Predicate<PreferredItemSlot> predicate = (Predicate<PreferredItemSlot>)(object)(Predicate<T>)delegate(PreferredItemSlot x)
				{
					Item preferredItem = x.PreferredItem;
					throw new NullReferenceException();
				};
				if (!ProtoExtensions.TryFindValue<PreferredItemSlot>((RepeatedField<>)(object)repeatedField3, (Predicate<>)(object)predicate, ref *(PreferredItemSlot*)num))
				{
				}
			}
			Func<(int, PreferredItemStatus, PreferredItemStatus), PreferredItemStatus> func2 = default(Func<(int, PreferredItemStatus, PreferredItemStatus), PreferredItemStatus>);
			if (_003C_003Ec._003C_003E9__187_3 == null)
			{
				func2 = (Func<(int, PreferredItemStatus, PreferredItemStatus), PreferredItemStatus>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			int status = (int)((ValueTuple<, , >)Enumerable.Max<(int, PreferredItemStatus, PreferredItemStatus), PreferredItemStatus>((IEnumerable<>)list, (Func<, >)(object)func2)).Item1;
			Func<(int, PreferredItemStatus, PreferredItemStatus), bool> func3 = default(Func<(int, PreferredItemStatus, PreferredItemStatus), bool>);
			if (_003C_003Ec._003C_003E9__187_4 == null)
			{
				bool result = default(bool);
				func3 = (Func<(int, PreferredItemStatus, PreferredItemStatus), bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(((int index, PreferredItemStatus status, PreferredItemStatus newStatus) x) => result));
			}
			IEnumerable<(int, PreferredItemStatus, PreferredItemStatus)> enumerable3 = (IEnumerable<(int, PreferredItemStatus, PreferredItemStatus)>)Enumerable.Where<(int, PreferredItemStatus, PreferredItemStatus)>((IEnumerable<>)list, (Func<, >)(object)func3);
			Func<(int, PreferredItemStatus, PreferredItemStatus), (int, PreferredItemStatus)> func4 = default(Func<(int, PreferredItemStatus, PreferredItemStatus), (int, PreferredItemStatus)>);
			if (_003C_003Ec._003C_003E9__187_5 == null)
			{
				func4 = (Func<(int, PreferredItemStatus, PreferredItemStatus), (int, PreferredItemStatus)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			List<(int, PreferredItemStatus)> list2 = (List<(int, PreferredItemStatus)>)(object)Enumerable.ToList<(int, PreferredItemStatus)>(Enumerable.Select<(int, PreferredItemStatus, PreferredItemStatus), (int, PreferredItemStatus)>((IEnumerable<>)enumerable3, (Func<, >)(object)func4));
			Action<(int, PreferredItemStatus)> action = (Action<(int, PreferredItemStatus)>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				Character character = this;
			};
			((List<T>)(object)list2).ForEach((Action<>)(object)action);
			GiftItemResult giftItemResult = new GiftItemResult();
			giftItemResult.NewDiscovery = list2;
			giftItemResult.FriendshipGained = num2;
			ulong num5 = default(ulong);
			giftItemResult.FirstDailyPreferred = (byte)num5 != 0;
			giftItemResult.Status = (PreferredItemStatus)status;
			return giftItemResult;
		}

		[Cpp2IlInjected.Token(Token = "0x60044F3")]
		[Cpp2IlInjected.Address(RVA = "0x71C9D0", Offset = "0x71B3D0", VA = "0x18071C9D0")]
		public bool CanSelectProfession()
		{
			bool flag = IsCharacterAvailableToSelectProfession();
			if (!flag)
			{
				return flag;
			}
			return Enumerable.Any<ProfessionItemData>((IEnumerable<>)this.get_AvailableProfessions());
		}

		[Cpp2IlInjected.Token(Token = "0x60044F4")]
		[Cpp2IlInjected.Address(RVA = "0x721580", Offset = "0x71FF80", VA = "0x180721580")]
		private bool IsCharacterAvailableToSelectProfession()
		{
			int value = skinID_;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			long num = Convert.ToInt64((uint)value);
			CharacterSkinItemData characterSkinItemData = default(CharacterSkinItemData);
			if (characterSkinItemData != null)
			{
			}
			if (Data.canHangoutWithPlayer_ && Profession == null)
			{
				return friendshipLevel_ >= 2;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044F6")]
		[Cpp2IlInjected.Address(RVA = "0x71FA50", Offset = "0x71E450", VA = "0x18071FA50")]
		public int GetProfessionLevel()
		{
			while (Profession == null)
			{
			}
			int val = friendshipLevel_;
			return Math.Max(0, val);
		}

		[Cpp2IlInjected.Token(Token = "0x60044F7")]
		[Cpp2IlInjected.Address(RVA = "0x723770", Offset = "0x722170", VA = "0x180723770")]
		static Character()
		{
			_parser = (MessageParser<Character>)(object)FieldCodec.ForInt32(74u);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			Func<PreferredItemStatus, int> func = (Func<PreferredItemStatus, int>)(object)(Func<T, TResult>)((PreferredItemStatus x) => (int)x);
			Func<int, PreferredItemStatus> func2 = (Func<int, PreferredItemStatus>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			FieldCodec<PreferredItemStatus> fieldCodec2 = (FieldCodec<PreferredItemStatus>)(object)FieldCodec.ForEnum<PreferredItemStatus>(num, (Func<, >)(object)func, (Func<, >)(object)func2);
			uint num2 = default(uint);
			_parser = (MessageParser<Character>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num2);
			MessageParser<PreferredItemSlot> parser = PreferredItemSlot._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<Character>)(object)FieldCodec.ForMessage<PreferredItemSlot>(num3, (MessageParser<>)(object)parser);
			MessageParser<ItemReward> parser2 = ItemReward._parser;
			uint num4 = default(uint);
			_parser = (MessageParser<Character>)(object)FieldCodec.ForMessage<ItemReward>(num4, (MessageParser<>)(object)parser2);
			_parser = (MessageParser<Character>)(object)new ProfessionItemData[0];
			/*Error: Unexpected end of block*/;
		}
	}
}
