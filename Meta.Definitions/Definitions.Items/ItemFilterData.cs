using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200042E")]
	public sealed class ItemFilterData : IMessage<ItemFilterData>, IMessage, IEquatable<ItemFilterData>, IDeepCloneable<ItemFilterData>, IMessageFieldAccessor, IHasTags
	{
		[Cpp2IlInjected.Token(Token = "0x40016B6")]
		private static readonly MessageParser<ItemFilterData> _parser = (MessageParser<ItemFilterData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ItemFilterData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40016B7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40016B8")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40016B9")]
		private int item_;

		[Cpp2IlInjected.Token(Token = "0x40016BA")]
		public const int ItemListFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40016BB")]
		private static readonly FieldCodec<int> _repeated_itemList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016BC")]
		private readonly RepeatedField<int> itemList_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40016BD")]
		public const int TypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40016BE")]
		private ItemType type_;

		[Cpp2IlInjected.Token(Token = "0x40016BF")]
		public const int ActivityItemTypeFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40016C0")]
		private ActivityItemType activityItemType_;

		[Cpp2IlInjected.Token(Token = "0x40016C1")]
		public const int SetFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40016C2")]
		private int set_;

		[Cpp2IlInjected.Token(Token = "0x40016C3")]
		public const int ComplexityFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40016C4")]
		private OptionalField complexity_;

		[Cpp2IlInjected.Token(Token = "0x40016C5")]
		public const int MoodFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40016C6")]
		private OptionalField mood_;

		[Cpp2IlInjected.Token(Token = "0x40016C7")]
		public const int SturdinessFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40016C8")]
		private OptionalField sturdiness_;

		[Cpp2IlInjected.Token(Token = "0x40016C9")]
		public const int NormalityFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40016CA")]
		private OptionalField normality_;

		[Cpp2IlInjected.Token(Token = "0x40016CB")]
		public const int MinRarityFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40016CC")]
		private int minRarity_;

		[Cpp2IlInjected.Token(Token = "0x40016CD")]
		public const int MaxRarityFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40016CE")]
		private int maxRarity_;

		[Cpp2IlInjected.Token(Token = "0x40016CF")]
		public const int FishLocationFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40016D0")]
		private OptionalField fishLocation_;

		[Cpp2IlInjected.Token(Token = "0x40016D1")]
		public const int FishRarityFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40016D2")]
		private OptionalField fishRarity_;

		[Cpp2IlInjected.Token(Token = "0x40016D3")]
		public const int ConstraintFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40016D4")]
		private string constraint_ = "";

		[Cpp2IlInjected.Token(Token = "0x40016D5")]
		public const int FishIncludeTrashFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40016D6")]
		private bool fishIncludeTrash_;

		[Cpp2IlInjected.Token(Token = "0x40016D7")]
		public const int FishWeatherFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40016D8")]
		private string fishWeather_ = "";

		[Cpp2IlInjected.Token(Token = "0x40016D9")]
		public const int RequireAtLeastOneTagFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40016DA")]
		private bool requireAtLeastOneTag_;

		[Cpp2IlInjected.Token(Token = "0x40016DB")]
		public const int TagsFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x40016DC")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40016DD")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40016DE")]
		public const int CropTypeFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40016DF")]
		private CropTypeCondition cropType_;

		[Cpp2IlInjected.Token(Token = "0x40016E0")]
		public const int SeedTypeFieldNumber = 33;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40016E1")]
		private SeedTypeCondition seedType_;

		[Cpp2IlInjected.Token(Token = "0x40016E2")]
		public const int FlowerRarityFieldNumber = 40;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40016E3")]
		private FlowerRarityCondition flowerRarity_;

		[Cpp2IlInjected.Token(Token = "0x40016E4")]
		public const int IngredientsTypeFieldNumber = 41;

		[Cpp2IlInjected.Token(Token = "0x40016E5")]
		private static readonly FieldCodec<int> _repeated_ingredientsType_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40016E6")]
		private readonly RepeatedField<int> ingredientsType_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40016E7")]
		public const int MinMealStarRatingFieldNumber = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40016E8")]
		private int minMealStarRating_;

		[Cpp2IlInjected.Token(Token = "0x40016E9")]
		public const int MinUnlockLevelFieldNumber = 60;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40016EA")]
		private int minUnlockLevel_;

		[Cpp2IlInjected.Token(Token = "0x40016EB")]
		public const int MaxUnlockLevelFieldNumber = 61;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40016EC")]
		private int maxUnlockLevel_;

		[Cpp2IlInjected.Token(Token = "0x40016ED")]
		public const int MineralRoughnessFieldNumber = 62;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40016EE")]
		private MineralRoughness mineralRoughness_;

		[Cpp2IlInjected.Token(Token = "0x40016EF")]
		public const int EphemeralTypeFieldNumber = 63;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40016F0")]
		private EphemeralTypeCondition ephemeralType_;

		[Cpp2IlInjected.Token(Token = "0x40016F1")]
		public const int ProfessionFieldNumber = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40016F2")]
		private int profession_;

		[Cpp2IlInjected.Token(Token = "0x40016F3")]
		public const int OnlySeedCropFieldNumber = 70;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40016F4")]
		private bool onlySeedCrop_;

		[Cpp2IlInjected.Token(Token = "0x40016F5")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000D09")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemFilterData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600330F")]
			[Cpp2IlInjected.Address(RVA = "0x22DD060", Offset = "0x22DBA60", VA = "0x1822DD060")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003310")]
			[Cpp2IlInjected.Address(RVA = "0x22DCF90", Offset = "0x22DB990", VA = "0x1822DCF90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003311")]
			[Cpp2IlInjected.Address(RVA = "0x22DD390", Offset = "0x22DBD90", VA = "0x1822DD390", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0C")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003316")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003317")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0D")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6003318")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0E")]
		[DebuggerNonUserCode]
		public ItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6003319")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x600331A")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0F")]
		[DebuggerNonUserCode]
		public ActivityItemType ActivityItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600331B")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return activityItemType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600331C")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				activityItemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D10")]
		[DebuggerNonUserCode]
		public int Set
		{
			[Cpp2IlInjected.Token(Token = "0x600331D")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return set_;
			}
			[Cpp2IlInjected.Token(Token = "0x600331E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				set_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D11")]
		[DebuggerNonUserCode]
		public OptionalField Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x600331F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return complexity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003320")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				complexity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D12")]
		[DebuggerNonUserCode]
		public OptionalField Mood
		{
			[Cpp2IlInjected.Token(Token = "0x6003321")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return mood_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003322")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				mood_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D13")]
		[DebuggerNonUserCode]
		public OptionalField Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x6003323")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return sturdiness_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003324")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				sturdiness_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D14")]
		[DebuggerNonUserCode]
		public OptionalField Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6003325")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return normality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003326")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				normality_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D15")]
		[DebuggerNonUserCode]
		public int MinRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6003327")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return minRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003328")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				minRarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D16")]
		[DebuggerNonUserCode]
		public int MaxRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6003329")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820")]
			get
			{
				return maxRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x600332A")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				maxRarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D17")]
		[DebuggerNonUserCode]
		public OptionalField FishLocation
		{
			[Cpp2IlInjected.Token(Token = "0x600332B")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return fishLocation_;
			}
			[Cpp2IlInjected.Token(Token = "0x600332C")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				fishLocation_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D18")]
		[DebuggerNonUserCode]
		public OptionalField FishRarity
		{
			[Cpp2IlInjected.Token(Token = "0x600332D")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return fishRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x600332E")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				fishRarity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D19")]
		[DebuggerNonUserCode]
		public string Constraint
		{
			[Cpp2IlInjected.Token(Token = "0x600332F")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return constraint_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003330")]
			[Cpp2IlInjected.Address(RVA = "0x22DD4A0", Offset = "0x22DBEA0", VA = "0x1822DD4A0")]
			set
			{
				string text = (constraint_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1A")]
		[DebuggerNonUserCode]
		public bool FishIncludeTrash
		{
			[Cpp2IlInjected.Token(Token = "0x6003331")]
			[Cpp2IlInjected.Address(RVA = "0xAE8610", Offset = "0xAE7010", VA = "0x180AE8610")]
			get
			{
				return fishIncludeTrash_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003332")]
			[Cpp2IlInjected.Address(RVA = "0xBCC430", Offset = "0xBCAE30", VA = "0x180BCC430")]
			set
			{
				fishIncludeTrash_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1B")]
		[DebuggerNonUserCode]
		public string FishWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6003333")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return fishWeather_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003334")]
			[Cpp2IlInjected.Address(RVA = "0x22DD510", Offset = "0x22DBF10", VA = "0x1822DD510")]
			set
			{
				string text = (fishWeather_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1C")]
		[DebuggerNonUserCode]
		public bool RequireAtLeastOneTag
		{
			[Cpp2IlInjected.Token(Token = "0x6003335")]
			[Cpp2IlInjected.Address(RVA = "0xBD6330", Offset = "0xBD4D30", VA = "0x180BD6330")]
			get
			{
				return requireAtLeastOneTag_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003336")]
			[Cpp2IlInjected.Address(RVA = "0x102A930", Offset = "0x1029330", VA = "0x18102A930")]
			set
			{
				requireAtLeastOneTag_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1D")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6003337")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "15")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1E")]
		[DebuggerNonUserCode]
		public CropTypeCondition CropType
		{
			[Cpp2IlInjected.Token(Token = "0x6003338")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get
			{
				return cropType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003339")]
			[Cpp2IlInjected.Address(RVA = "0x1373C40", Offset = "0x1372640", VA = "0x181373C40")]
			set
			{
				cropType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1F")]
		[DebuggerNonUserCode]
		public SeedTypeCondition SeedType
		{
			[Cpp2IlInjected.Token(Token = "0x600333A")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0390", Offset = "0x1E9ED90", VA = "0x181EA0390")]
			get
			{
				return seedType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600333B")]
			[Cpp2IlInjected.Address(RVA = "0x22DD580", Offset = "0x22DBF80", VA = "0x1822DD580")]
			set
			{
				seedType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D20")]
		[DebuggerNonUserCode]
		public FlowerRarityCondition FlowerRarity
		{
			[Cpp2IlInjected.Token(Token = "0x600333C")]
			[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
			get
			{
				return flowerRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x600333D")]
			[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x974F80", VA = "0x180976580")]
			set
			{
				flowerRarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D21")]
		[DebuggerNonUserCode]
		public RepeatedField<int> IngredientsType
		{
			[Cpp2IlInjected.Token(Token = "0x600333E")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return ingredientsType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D22")]
		[DebuggerNonUserCode]
		public int MinMealStarRating
		{
			[Cpp2IlInjected.Token(Token = "0x600333F")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACB0", Offset = "0xA596B0", VA = "0x180A5ACB0")]
			get
			{
				return minMealStarRating_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003340")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACD0", Offset = "0xA596D0", VA = "0x180A5ACD0")]
			set
			{
				minMealStarRating_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D23")]
		[DebuggerNonUserCode]
		public int MinUnlockLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6003341")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACC0", Offset = "0xA596C0", VA = "0x180A5ACC0")]
			get
			{
				return minUnlockLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003342")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACF0", Offset = "0xA596F0", VA = "0x180A5ACF0")]
			set
			{
				minUnlockLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D24")]
		[DebuggerNonUserCode]
		public int MaxUnlockLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6003343")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCF0", Offset = "0xD2E6F0", VA = "0x180D2FCF0")]
			get
			{
				return maxUnlockLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003344")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD30", Offset = "0xD2E730", VA = "0x180D2FD30")]
			set
			{
				maxUnlockLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D25")]
		[DebuggerNonUserCode]
		public MineralRoughness MineralRoughness
		{
			[Cpp2IlInjected.Token(Token = "0x6003345")]
			[Cpp2IlInjected.Address(RVA = "0x18D7BB0", Offset = "0x18D65B0", VA = "0x1818D7BB0")]
			get
			{
				return mineralRoughness_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003346")]
			[Cpp2IlInjected.Address(RVA = "0x18D8420", Offset = "0x18D6E20", VA = "0x1818D8420")]
			set
			{
				mineralRoughness_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D26")]
		[DebuggerNonUserCode]
		public EphemeralTypeCondition EphemeralType
		{
			[Cpp2IlInjected.Token(Token = "0x6003347")]
			[Cpp2IlInjected.Address(RVA = "0x148A150", Offset = "0x1488B50", VA = "0x18148A150")]
			get
			{
				return ephemeralType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003348")]
			[Cpp2IlInjected.Address(RVA = "0x148A410", Offset = "0x1488E10", VA = "0x18148A410")]
			set
			{
				ephemeralType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D27")]
		[DebuggerNonUserCode]
		public int Profession
		{
			[Cpp2IlInjected.Token(Token = "0x6003349")]
			[Cpp2IlInjected.Address(RVA = "0x148A2F0", Offset = "0x1488CF0", VA = "0x18148A2F0")]
			get
			{
				return profession_;
			}
			[Cpp2IlInjected.Token(Token = "0x600334A")]
			[Cpp2IlInjected.Address(RVA = "0x148A4B0", Offset = "0x1488EB0", VA = "0x18148A4B0")]
			set
			{
				profession_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D28")]
		[DebuggerNonUserCode]
		public bool OnlySeedCrop
		{
			[Cpp2IlInjected.Token(Token = "0x600334B")]
			[Cpp2IlInjected.Address(RVA = "0xD3CD40", Offset = "0xD3B740", VA = "0x180D3CD40")]
			get
			{
				return onlySeedCrop_;
			}
			[Cpp2IlInjected.Token(Token = "0x600334C")]
			[Cpp2IlInjected.Address(RVA = "0xD3CEF0", Offset = "0xD3B8F0", VA = "0x180D3CEF0")]
			set
			{
				onlySeedCrop_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D29")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6003358")]
			[Cpp2IlInjected.Address(RVA = "0x22DD0C0", Offset = "0x22DBAC0", VA = "0x1822DD0C0", Slot = "14")]
			get
			{
				ItemType itemType = type_;
				if (itemType == ItemType.Furniture)
				{
					List<(TagItemType, int?)> list = (List<(TagItemType, int?)>)(object)Enumerable.ToList<(TagItemType, int?)>((IEnumerable<>)FurnitureItemData.usedTagTypes);
					Predicate<(TagItemType, int?)> _003C_003E9__170_ = _003C_003Ec._003C_003E9__170_0;
					if (_003C_003E9__170_ == null)
					{
						bool result = default(bool);
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)(((TagItemType tagType, int? limit) x) => result);
					}
					if (((List<T>)(object)list).FindIndex((Predicate<>)(object)_003C_003E9__170_) != 1)
					{
						int num = 0;
					}
				}
				if (itemType != ItemType.Clothing)
				{
					ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				}
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection2 = ClothingItemData.usedTagTypes;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003312")]
		[Cpp2IlInjected.Address(RVA = "0x22DCAA0", Offset = "0x22DB4A0", VA = "0x1822DCAA0")]
		[DebuggerNonUserCode]
		public ItemFilterData()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6003313")]
		[Cpp2IlInjected.Address(RVA = "0x22DB620", Offset = "0x22DA020", VA = "0x1822DB620")]
		private void OnConstruction()
		{
			OptionalField optionalField = new OptionalField();
			optionalField.useField_ = false;
			int num = (int)(optionalField.Complexity = Definitions.Items.Complexity.Lavish);
			complexity_ = optionalField;
			OptionalField optionalField2 = new OptionalField();
			optionalField2.useField_ = false;
			int num2 = (int)(optionalField2.Mood = Definitions.Items.Mood.Calm);
			mood_ = optionalField2;
			OptionalField optionalField3 = new OptionalField();
			optionalField3.useField_ = false;
			int num3 = (int)(optionalField3.Sturdiness = Definitions.Items.Sturdiness.Strong);
			sturdiness_ = optionalField3;
			OptionalField optionalField4 = new OptionalField();
			optionalField4.useField_ = false;
			int num4 = (int)(optionalField4.Normality = Definitions.Items.Normality.Wondrous);
			normality_ = optionalField4;
			OptionalField optionalField5 = new OptionalField();
			optionalField5.useField_ = false;
			VillageAreaList villageAreaList2 = (optionalField5.VillageAreas = new VillageAreaList());
			fishLocation_ = optionalField5;
			OptionalField optionalField6 = new OptionalField();
			optionalField6.useField_ = false;
			FishRarityList fishRarityList2 = (optionalField6.FishRarities = new FishRarityList());
			fishRarity_ = optionalField6;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003314")]
		[Cpp2IlInjected.Address(RVA = "0x22DCBC0", Offset = "0x22DB5C0", VA = "0x1822DCBC0")]
		[DebuggerNonUserCode]
		public ItemFilterData(ItemFilterData other)
		{
			//IL_00bd: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			//IL_00f9: Expected O, but got I4
			//IL_0117: Expected O, but got I4
			//IL_0155: Expected O, but got I4
			OnConstruction();
			int num = (item_ = other.item_);
			RepeatedField<int> repeatedField = (itemList_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemList_).Clone());
			ItemType itemType = other.type_;
			int num2 = 0;
			type_ = itemType;
			ActivityItemType activityItemType = (activityItemType_ = other.activityItemType_);
			int num3 = (set_ = other.set_);
			OptionalField optionalField = other.complexity_;
			if (optionalField != null)
			{
				OptionalField optionalField2 = optionalField.Clone();
			}
			complexity_ = (OptionalField)num2;
			OptionalField optionalField3 = other.mood_;
			if (optionalField3 != null)
			{
				OptionalField optionalField4 = optionalField3.Clone();
			}
			mood_ = (OptionalField)num2;
			OptionalField optionalField5 = other.sturdiness_;
			if (optionalField5 != null)
			{
				OptionalField optionalField6 = optionalField5.Clone();
			}
			sturdiness_ = (OptionalField)num2;
			OptionalField optionalField7 = other.normality_;
			if (optionalField7 != null)
			{
				OptionalField optionalField8 = optionalField7.Clone();
			}
			normality_ = (OptionalField)num2;
			int num4 = (minRarity_ = other.minRarity_);
			int num5 = (maxRarity_ = other.maxRarity_);
			OptionalField optionalField9 = other.fishLocation_;
			if (optionalField9 != null)
			{
				OptionalField optionalField10 = optionalField9.Clone();
			}
			fishLocation_ = (OptionalField)num2;
			OptionalField optionalField11 = other.fishRarity_;
			OptionalField optionalField12 = default(OptionalField);
			if (optionalField11 != null)
			{
				optionalField12 = optionalField11.Clone();
			}
			fishRarity_ = optionalField12;
			string text = (constraint_ = other.constraint_);
			bool flag = (fishIncludeTrash_ = other.fishIncludeTrash_);
			string text2 = (fishWeather_ = other.fishWeather_);
			bool flag2 = (requireAtLeastOneTag_ = other.requireAtLeastOneTag_);
			RepeatedField<int> repeatedField2 = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			CropTypeCondition cropTypeCondition = (cropType_ = other.cropType_);
			SeedTypeCondition seedTypeCondition = (seedType_ = other.seedType_);
			FlowerRarityCondition flowerRarityCondition = (flowerRarity_ = other.flowerRarity_);
			RepeatedField<int> repeatedField3 = (ingredientsType_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.ingredientsType_).Clone());
			int num6 = (minMealStarRating_ = other.minMealStarRating_);
			int num7 = (minUnlockLevel_ = other.minUnlockLevel_);
			int num8 = (maxUnlockLevel_ = other.maxUnlockLevel_);
			MineralRoughness mineralRoughness = (mineralRoughness_ = other.mineralRoughness_);
			EphemeralTypeCondition ephemeralTypeCondition = (ephemeralType_ = other.ephemeralType_);
			int num9 = (profession_ = other.profession_);
			bool flag3 = (onlySeedCrop_ = other.onlySeedCrop_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003315")]
		[Cpp2IlInjected.Address(RVA = "0x22DA010", Offset = "0x22D8A10", VA = "0x1822DA010", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemFilterData Clone()
		{
			return new ItemFilterData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600334D")]
		[Cpp2IlInjected.Address(RVA = "0x22DA070", Offset = "0x22D8A70", VA = "0x1822DA070", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ItemFilterData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600334E")]
		[Cpp2IlInjected.Address(RVA = "0x22DA0D0", Offset = "0x22D8AD0", VA = "0x1822DA0D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemFilterData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.item_;
				if (item_ == num)
				{
					RepeatedField<int> repeatedField = itemList_;
					RepeatedField<int> repeatedField2 = other.itemList_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						ItemType itemType = other.type_;
						if (type_ == itemType)
						{
							ActivityItemType activityItemType = other.activityItemType_;
							if (activityItemType_ == activityItemType)
							{
								int num2 = other.set_;
								if (set_ == num2)
								{
									OptionalField objB = other.complexity_;
									if (object.Equals(complexity_, objB))
									{
										OptionalField objB2 = other.mood_;
										if (object.Equals(mood_, objB2))
										{
											OptionalField objB3 = other.sturdiness_;
											if (object.Equals(sturdiness_, objB3))
											{
												OptionalField objB4 = other.normality_;
												if (object.Equals(normality_, objB4))
												{
													int num3 = other.minRarity_;
													if (minRarity_ == num3)
													{
														int num4 = other.maxRarity_;
														if (maxRarity_ == num4)
														{
															OptionalField objB5 = other.fishLocation_;
															if (object.Equals(fishLocation_, objB5))
															{
																OptionalField objB6 = other.fishRarity_;
																if (object.Equals(fishRarity_, objB6))
																{
																	string text = other.constraint_;
																	if (!(constraint_ != text))
																	{
																		bool flag = other.fishIncludeTrash_;
																		if (fishIncludeTrash_ == flag)
																		{
																			string text2 = other.fishWeather_;
																			if (!(fishWeather_ != text2))
																			{
																				bool flag2 = other.requireAtLeastOneTag_;
																				if (requireAtLeastOneTag_ == flag2)
																				{
																					RepeatedField<int> repeatedField3 = tags_;
																					RepeatedField<int> repeatedField4 = other.tags_;
																					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																					{
																						CropTypeCondition cropTypeCondition = other.cropType_;
																						if (cropType_ == cropTypeCondition)
																						{
																							SeedTypeCondition seedTypeCondition = other.seedType_;
																							if (seedType_ == seedTypeCondition)
																							{
																								FlowerRarityCondition flowerRarityCondition = other.flowerRarity_;
																								if (flowerRarity_ == flowerRarityCondition)
																								{
																									RepeatedField<int> repeatedField5 = ingredientsType_;
																									RepeatedField<int> repeatedField6 = other.ingredientsType_;
																									if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
																									{
																										int num5 = other.minMealStarRating_;
																										if (minMealStarRating_ == num5)
																										{
																											int num6 = other.minUnlockLevel_;
																											if (minUnlockLevel_ == num6)
																											{
																												int num7 = other.maxUnlockLevel_;
																												if (maxUnlockLevel_ == num7)
																												{
																													MineralRoughness mineralRoughness = other.mineralRoughness_;
																													if (mineralRoughness_ == mineralRoughness)
																													{
																														EphemeralTypeCondition ephemeralTypeCondition = other.ephemeralType_;
																														if (ephemeralType_ == ephemeralTypeCondition)
																														{
																															int num8 = other.profession_;
																															if (profession_ == num8)
																															{
																																bool flag3 = other.onlySeedCrop_;
																																if (onlySeedCrop_ == flag3)
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
			int num9 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600334F")]
		[Cpp2IlInjected.Address(RVA = "0x22DA810", Offset = "0x22D9210", VA = "0x1822DA810", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0193
			if (item_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)itemList_).GetHashCode();
			if (type_ != 0)
			{
			}
			if (activityItemType_ != 0)
			{
			}
			if (set_ != 0)
			{
			}
			OptionalField optionalField = complexity_;
			if (optionalField != null)
			{
				int hashCode2 = optionalField.GetHashCode();
			}
			OptionalField optionalField2 = mood_;
			if (optionalField2 != null)
			{
				int hashCode3 = optionalField2.GetHashCode();
			}
			OptionalField optionalField3 = sturdiness_;
			if (optionalField3 != null)
			{
				int hashCode4 = optionalField3.GetHashCode();
			}
			OptionalField optionalField4 = normality_;
			if (optionalField4 != null)
			{
				int hashCode5 = optionalField4.GetHashCode();
			}
			if (minRarity_ != 0)
			{
			}
			if (maxRarity_ != 0)
			{
			}
			OptionalField optionalField5 = fishLocation_;
			if (optionalField5 != null)
			{
				int hashCode6 = optionalField5.GetHashCode();
			}
			OptionalField optionalField6 = fishRarity_;
			if (optionalField6 != null)
			{
				int hashCode7 = optionalField6.GetHashCode();
			}
			string text = constraint_;
			if (text.m_stringLength != 0)
			{
				int hashCode8 = text.GetHashCode();
			}
			if (fishIncludeTrash_)
			{
			}
			string text2 = fishWeather_;
			if (text2.m_stringLength != 0)
			{
				int hashCode9 = text2.GetHashCode();
			}
			if (requireAtLeastOneTag_)
			{
			}
			int hashCode10 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (cropType_ != 0)
			{
			}
			if (seedType_ != 0)
			{
			}
			if (flowerRarity_ != 0)
			{
			}
			int hashCode11 = ((RepeatedField<T>)(object)ingredientsType_).GetHashCode();
			if (minMealStarRating_ != 0)
			{
			}
			if (minUnlockLevel_ != 0)
			{
			}
			if (maxUnlockLevel_ != 0)
			{
			}
			if (mineralRoughness_ != 0)
			{
			}
			if (ephemeralType_ != 0)
			{
			}
			if (profession_ != 0)
			{
			}
			if (onlySeedCrop_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode12 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003350")]
		[Cpp2IlInjected.Address(RVA = "0x22DC210", Offset = "0x22DAC10", VA = "0x1822DC210", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003351")]
		[Cpp2IlInjected.Address(RVA = "0x22DC270", Offset = "0x22DAC70", VA = "0x1822DC270", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0289
			if (item_ != 0)
			{
				int value = item_;
				output.WriteInt32(value);
			}
			RepeatedField<int> repeatedField = itemList_;
			FieldCodec<int> repeated_itemList_codec = _repeated_itemList_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemList_codec);
			if (type_ != 0)
			{
			}
			if (activityItemType_ != 0)
			{
			}
			if (set_ != 0)
			{
				int value2 = set_;
				output.WriteInt32(value2);
			}
			if ((long)complexity_ != 0)
			{
				OptionalField value3 = complexity_;
				output.WriteMessage(value3);
			}
			if ((long)mood_ != 0)
			{
				OptionalField value4 = mood_;
				output.WriteMessage(value4);
			}
			if ((long)sturdiness_ != 0)
			{
				OptionalField value5 = sturdiness_;
				output.WriteMessage(value5);
			}
			if ((long)normality_ != 0)
			{
				OptionalField value6 = normality_;
				output.WriteMessage(value6);
			}
			if (minRarity_ != 0)
			{
				int value7 = minRarity_;
				output.WriteInt32(value7);
			}
			if (maxRarity_ != 0)
			{
				int value8 = maxRarity_;
				output.WriteInt32(value8);
			}
			if ((long)fishLocation_ != 0)
			{
				OptionalField value9 = fishLocation_;
				output.WriteMessage(value9);
			}
			if ((long)fishRarity_ != 0)
			{
				OptionalField value10 = fishRarity_;
				output.WriteMessage(value10);
			}
			if (constraint_.m_stringLength != 0)
			{
				string value11 = constraint_;
				output.WriteString(value11);
			}
			if (fishIncludeTrash_)
			{
				bool value12 = fishIncludeTrash_;
				output.WriteBool(value12);
			}
			if (fishWeather_.m_stringLength != 0)
			{
				string value13 = fishWeather_;
				output.WriteString(value13);
			}
			if (requireAtLeastOneTag_)
			{
				bool value14 = requireAtLeastOneTag_;
				output.WriteBool(value14);
			}
			RepeatedField<int> repeatedField2 = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (cropType_ != 0)
			{
			}
			if (seedType_ != 0)
			{
			}
			if (flowerRarity_ != 0)
			{
			}
			RepeatedField<int> repeatedField3 = ingredientsType_;
			FieldCodec<int> repeated_ingredientsType_codec = _repeated_ingredientsType_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_ingredientsType_codec);
			if (minMealStarRating_ != 0)
			{
				int value15 = minMealStarRating_;
				output.WriteInt32(value15);
			}
			if (minUnlockLevel_ != 0)
			{
				int value16 = minUnlockLevel_;
				output.WriteInt32(value16);
			}
			if (maxUnlockLevel_ != 0)
			{
				int value17 = maxUnlockLevel_;
				output.WriteInt32(value17);
			}
			if (mineralRoughness_ != 0)
			{
			}
			if (ephemeralType_ != 0)
			{
			}
			if (profession_ != 0)
			{
				int value18 = profession_;
				output.WriteInt32(value18);
			}
			if (onlySeedCrop_)
			{
				bool value19 = onlySeedCrop_;
				output.WriteBool(value19);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003352")]
		[Cpp2IlInjected.Address(RVA = "0x22D95D0", Offset = "0x22D7FD0", VA = "0x1822D95D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Expected O, but got Unknown
			//IL_0245: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Expected O, but got Unknown
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected O, but got Unknown
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Expected O, but got Unknown
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Expected O, but got Unknown
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Expected O, but got Unknown
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected O, but got Unknown
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected O, but got Unknown
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Expected O, but got Unknown
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Expected O, but got Unknown
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Expected O, but got Unknown
			int num = item_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			RepeatedField<int> repeatedField = itemList_;
			FieldCodec<int> repeated_itemList_codec = _repeated_itemList_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemList_codec);
			ItemType itemType = type_;
			num2 += num4;
			if (itemType != 0)
			{
				int num5 = CodedOutputStream.ComputeEnumSize((int)itemType);
				num5++;
				num2 += num5;
			}
			ActivityItemType activityItemType = activityItemType_;
			if (activityItemType != 0)
			{
				int num6 = CodedOutputStream.ComputeEnumSize((int)activityItemType);
				num6++;
				num2 += num6;
			}
			int num7 = set_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num2 += num8;
			}
			OptionalField optionalField = complexity_;
			if (optionalField != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(optionalField);
				num9++;
				num2 += num9;
			}
			OptionalField optionalField2 = mood_;
			if (optionalField2 != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(optionalField2);
				num10++;
				num2 += num10;
			}
			OptionalField optionalField3 = sturdiness_;
			if (optionalField3 != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(optionalField3);
				num11++;
				num2 += num11;
			}
			OptionalField optionalField4 = normality_;
			if (optionalField4 != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(optionalField4);
				num12++;
				num2 += num12;
			}
			int num13 = minRarity_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14 += 2;
				num2 += num14;
			}
			int num15 = maxRarity_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16 += 2;
				num2 += num16;
			}
			OptionalField optionalField5 = fishLocation_;
			if (optionalField5 != null)
			{
				int num17 = CodedOutputStream.ComputeMessageSize(optionalField5);
				num17 += 2;
				num2 += num17;
			}
			OptionalField optionalField6 = fishRarity_;
			if (optionalField6 != null)
			{
				int num18 = CodedOutputStream.ComputeMessageSize(optionalField6);
				num18 += 2;
				num2 += num18;
			}
			string text = constraint_;
			if (text.m_stringLength != 0)
			{
				int num19 = CodedOutputStream.ComputeStringSize(text);
				num19 += 2;
				num2 += num19;
			}
			string text2 = fishWeather_;
			if (text2.m_stringLength != 0)
			{
				int num20 = CodedOutputStream.ComputeStringSize(text2);
				num20 += 2;
				num2 += num20;
			}
			RepeatedField<int> repeatedField2 = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num21 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			CropTypeCondition cropTypeCondition = cropType_;
			if (cropTypeCondition != 0)
			{
				int num22 = CodedOutputStream.ComputeEnumSize((int)cropTypeCondition);
				num22 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num22);
			}
			SeedTypeCondition seedTypeCondition = seedType_;
			if (seedTypeCondition != 0)
			{
				int num23 = CodedOutputStream.ComputeEnumSize((int)seedTypeCondition);
				num23 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num23);
			}
			FlowerRarityCondition flowerRarityCondition = flowerRarity_;
			if (flowerRarityCondition != 0)
			{
				int num24 = CodedOutputStream.ComputeEnumSize((int)flowerRarityCondition);
				num24 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num24);
			}
			RepeatedField<int> repeatedField3 = ingredientsType_;
			FieldCodec<int> repeated_ingredientsType_codec = _repeated_ingredientsType_codec;
			int num25 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_ingredientsType_codec);
			int num26 = minMealStarRating_;
			repeatedField2 = (RepeatedField<int>)(repeatedField2 + num25);
			if (num26 != 0)
			{
				int num27 = CodedOutputStream.ComputeInt32Size(num26);
				num27 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num27);
			}
			int num28 = minUnlockLevel_;
			if (num28 != 0)
			{
				int num29 = CodedOutputStream.ComputeInt32Size(num28);
				num29 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num29);
			}
			int num30 = maxUnlockLevel_;
			if (num30 != 0)
			{
				int num31 = CodedOutputStream.ComputeInt32Size(num30);
				num31 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num31);
			}
			MineralRoughness mineralRoughness = mineralRoughness_;
			if (mineralRoughness != 0)
			{
				int num32 = CodedOutputStream.ComputeEnumSize((int)mineralRoughness);
				num32 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num32);
			}
			EphemeralTypeCondition ephemeralTypeCondition = ephemeralType_;
			if (ephemeralTypeCondition != 0)
			{
				int num33 = CodedOutputStream.ComputeEnumSize((int)ephemeralTypeCondition);
				num33 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num33);
			}
			int num34 = profession_;
			if (num34 != 0)
			{
				int num35 = CodedOutputStream.ComputeInt32Size(num34);
				num35 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num35);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num36 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num36);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003353")]
		[Cpp2IlInjected.Address(RVA = "0x22DAB90", Offset = "0x22D9590", VA = "0x1822DAB90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemFilterData other)
		{
			//Discarded unreachable code: IL_037e
			if (other == null)
			{
				return;
			}
			int num = other.item_;
			if (num != 0)
			{
				item_ = num;
			}
			RepeatedField<int> repeatedField = itemList_;
			RepeatedField<int> repeatedField2 = other.itemList_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			ItemType itemType = other.type_;
			if (itemType != 0)
			{
				type_ = itemType;
			}
			ActivityItemType activityItemType = other.activityItemType_;
			if (activityItemType != 0)
			{
				activityItemType_ = activityItemType;
			}
			int num2 = other.set_;
			if (num2 != 0)
			{
				set_ = num2;
			}
			if ((long)other.complexity_ != 0)
			{
				OptionalField optionalField2 = default(OptionalField);
				if (complexity_ == null)
				{
					OptionalField optionalField = (complexity_ = new OptionalField());
					optionalField2 = complexity_;
				}
				OptionalField other2 = other.complexity_;
				optionalField2.MergeFrom(other2);
			}
			if ((long)other.mood_ != 0)
			{
				OptionalField optionalField4 = default(OptionalField);
				if (mood_ == null)
				{
					OptionalField optionalField3 = (mood_ = new OptionalField());
					optionalField4 = mood_;
				}
				OptionalField other3 = other.mood_;
				optionalField4.MergeFrom(other3);
			}
			if ((long)other.sturdiness_ != 0)
			{
				OptionalField optionalField6 = default(OptionalField);
				if (sturdiness_ == null)
				{
					OptionalField optionalField5 = (sturdiness_ = new OptionalField());
					optionalField6 = sturdiness_;
				}
				OptionalField other4 = other.sturdiness_;
				optionalField6.MergeFrom(other4);
			}
			if ((long)other.normality_ != 0)
			{
				OptionalField optionalField8 = default(OptionalField);
				if (normality_ == null)
				{
					OptionalField optionalField7 = (normality_ = new OptionalField());
					optionalField8 = normality_;
				}
				OptionalField other5 = other.normality_;
				optionalField8.MergeFrom(other5);
			}
			int num3 = other.minRarity_;
			if (num3 != 0)
			{
				minRarity_ = num3;
			}
			int num4 = other.maxRarity_;
			if (num4 != 0)
			{
				maxRarity_ = num4;
			}
			if ((long)other.fishLocation_ != 0)
			{
				OptionalField optionalField10 = default(OptionalField);
				if (fishLocation_ == null)
				{
					OptionalField optionalField9 = (fishLocation_ = new OptionalField());
					optionalField10 = fishLocation_;
				}
				OptionalField other6 = other.fishLocation_;
				optionalField10.MergeFrom(other6);
			}
			if ((long)other.fishRarity_ != 0)
			{
				OptionalField optionalField12 = default(OptionalField);
				if (fishRarity_ == null)
				{
					OptionalField optionalField11 = (fishRarity_ = new OptionalField());
					optionalField12 = fishRarity_;
				}
				OptionalField other7 = other.fishRarity_;
				optionalField12.MergeFrom(other7);
			}
			string text = other.constraint_;
			if (text.m_stringLength != 0)
			{
				Constraint = text;
			}
			bool flag = other.fishIncludeTrash_;
			if (flag)
			{
				fishIncludeTrash_ = flag;
			}
			string text2 = other.fishWeather_;
			if (text2.m_stringLength != 0)
			{
				FishWeather = text2;
			}
			bool flag2 = other.requireAtLeastOneTag_;
			if (flag2)
			{
				requireAtLeastOneTag_ = flag2;
			}
			RepeatedField<int> repeatedField3 = tags_;
			RepeatedField<int> repeatedField4 = other.tags_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			CropTypeCondition cropTypeCondition = other.cropType_;
			if (cropTypeCondition != 0)
			{
				cropType_ = cropTypeCondition;
			}
			SeedTypeCondition seedTypeCondition = other.seedType_;
			if (seedTypeCondition != 0)
			{
				seedType_ = seedTypeCondition;
			}
			FlowerRarityCondition flowerRarityCondition = other.flowerRarity_;
			if (flowerRarityCondition != 0)
			{
				flowerRarity_ = flowerRarityCondition;
			}
			RepeatedField<int> repeatedField5 = ingredientsType_;
			RepeatedField<int> repeatedField6 = other.ingredientsType_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			int num5 = other.minMealStarRating_;
			if (num5 != 0)
			{
				minMealStarRating_ = num5;
			}
			int num6 = other.minUnlockLevel_;
			if (num6 != 0)
			{
				minUnlockLevel_ = num6;
			}
			int num7 = other.maxUnlockLevel_;
			if (num7 != 0)
			{
				maxUnlockLevel_ = num7;
			}
			MineralRoughness mineralRoughness = other.mineralRoughness_;
			if (mineralRoughness != 0)
			{
				mineralRoughness_ = mineralRoughness;
			}
			EphemeralTypeCondition ephemeralTypeCondition = other.ephemeralType_;
			if (ephemeralTypeCondition != 0)
			{
				ephemeralType_ = ephemeralTypeCondition;
			}
			int num8 = other.profession_;
			if (num8 != 0)
			{
				profession_ = num8;
			}
			bool flag3 = other.onlySeedCrop_;
			if (flag3)
			{
				onlySeedCrop_ = flag3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003354")]
		[Cpp2IlInjected.Address(RVA = "0x22DAFA0", Offset = "0x22D99A0", VA = "0x1822DAFA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_045c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 184)
			{
				goto IL_01f3;
			}
			if ((int)num > 328)
			{
				if ((int)num > 488)
				{
					if ((int)num > 504)
					{
						if (num == 512)
						{
							int num2 = (profession_ = input.ReadInt32());
						}
						if (num != 560)
						{
							goto IL_0445;
						}
						bool flag = (onlySeedCrop_ = input.ReadBool());
					}
					int num3 = default(int);
					if (num == 496)
					{
						num3 = (int)(mineralRoughness_ = (MineralRoughness)input.ReadInt32());
					}
					if (num3 != 504)
					{
						goto IL_0445;
					}
					int num4 = (int)(ephemeralType_ = (EphemeralTypeCondition)input.ReadInt32());
				}
				int num6 = default(int);
				if ((int)num > 400)
				{
					int num5 = default(int);
					if (num == 480)
					{
						num5 = (minUnlockLevel_ = input.ReadInt32());
					}
					if (num5 != 488)
					{
						goto IL_0445;
					}
					num6 = (maxUnlockLevel_ = input.ReadInt32());
				}
				if (num6 == 330)
				{
					goto IL_0139;
				}
				if (num6 != 400)
				{
					goto IL_0445;
				}
				int num7 = (minMealStarRating_ = input.ReadInt32());
			}
			if ((int)num <= 250)
			{
				goto IL_0187;
			}
			if ((int)num <= 264)
			{
				goto IL_0152;
			}
			int num8 = default(int);
			if (num == 320)
			{
				num8 = (int)(flowerRarity_ = (FlowerRarityCondition)input.ReadInt32());
			}
			if (num8 == 328)
			{
				goto IL_0139;
			}
			goto IL_0445;
			IL_0187:
			int num9 = default(int);
			if (num9 > 240)
			{
				num9 += -248;
				if (num9 != -3)
				{
					goto IL_0445;
				}
				RepeatedField<int> repeatedField = tags_;
				FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			}
			string text2 = default(string);
			if (num9 == 194)
			{
				text2 = (FishWeather = input.ReadString());
			}
			if ((long)text2 == 240)
			{
				bool flag2 = (requireAtLeastOneTag_ = input.ReadBool());
				goto IL_01f3;
			}
			goto IL_0445;
			IL_0445:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_0139:
			RepeatedField<int> repeatedField2 = ingredientsType_;
			FieldCodec<int> repeated_ingredientsType_codec = _repeated_ingredientsType_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ingredientsType_codec);
			goto IL_0152;
			IL_0152:
			int num10 = default(int);
			if (num8 == 256)
			{
				num10 = (int)(cropType_ = (CropTypeCondition)input.ReadInt32());
			}
			if (num10 == 264)
			{
				num9 = (int)(seedType_ = (SeedTypeCondition)input.ReadInt32());
				goto IL_0187;
			}
			goto IL_0445;
			IL_042c:
			RepeatedField<int> repeatedField3 = itemList_;
			FieldCodec<int> repeated_itemList_codec = _repeated_itemList_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemList_codec);
			goto IL_0445;
			IL_01f3:
			OptionalField optionalField4 = default(OptionalField);
			if ((int)num > 98)
			{
				OptionalField optionalField2 = default(OptionalField);
				if ((int)num > 136)
				{
					bool flag3 = default(bool);
					if ((int)num > 170)
					{
						string text4 = default(string);
						if (num == 178)
						{
							text4 = (Constraint = input.ReadString());
						}
						if ((long)text4 != 184)
						{
							goto IL_0445;
						}
						flag3 = (fishIncludeTrash_ = input.ReadBool());
					}
					OptionalField optionalField = default(OptionalField);
					if (flag3)
					{
						OptionalField builder = default(OptionalField);
						if (fishLocation_ == null)
						{
							optionalField = (fishLocation_ = new OptionalField());
							builder = fishLocation_;
						}
						input.ReadMessage(builder);
					}
					if ((long)optionalField != 170)
					{
						goto IL_0445;
					}
					OptionalField builder2 = default(OptionalField);
					if (fishRarity_ == null)
					{
						optionalField2 = (fishRarity_ = new OptionalField());
						builder2 = fishRarity_;
					}
					input.ReadMessage(builder2);
				}
				int num12 = default(int);
				if ((long)optionalField2 > 114)
				{
					int num11 = default(int);
					if ((long)optionalField2 == 128)
					{
						num11 = (minRarity_ = input.ReadInt32());
					}
					if (num11 != 136)
					{
						goto IL_0445;
					}
					num12 = (maxRarity_ = input.ReadInt32());
				}
				OptionalField optionalField3 = default(OptionalField);
				if (num12 == 106)
				{
					OptionalField builder3 = default(OptionalField);
					if (sturdiness_ == null)
					{
						optionalField3 = (sturdiness_ = new OptionalField());
						builder3 = sturdiness_;
					}
					input.ReadMessage(builder3);
				}
				if ((long)optionalField3 != 114)
				{
					goto IL_0445;
				}
				OptionalField builder4 = default(OptionalField);
				if (normality_ == null)
				{
					optionalField4 = (normality_ = new OptionalField());
					builder4 = normality_;
				}
				input.ReadMessage(builder4);
			}
			int num14 = default(int);
			if ((long)optionalField4 > 24)
			{
				OptionalField optionalField6 = default(OptionalField);
				if ((long)optionalField4 > 80)
				{
					OptionalField optionalField5 = default(OptionalField);
					if ((long)optionalField4 == 90)
					{
						OptionalField builder5 = default(OptionalField);
						if (complexity_ == null)
						{
							optionalField5 = (complexity_ = new OptionalField());
							builder5 = complexity_;
						}
						input.ReadMessage(builder5);
					}
					if ((long)optionalField5 != 98)
					{
						goto IL_0445;
					}
					OptionalField builder6 = default(OptionalField);
					if (mood_ == null)
					{
						optionalField6 = (mood_ = new OptionalField());
						builder6 = mood_;
					}
					input.ReadMessage(builder6);
				}
				int num13 = default(int);
				if ((long)optionalField6 == 32)
				{
					num13 = (int)(activityItemType_ = (ActivityItemType)input.ReadInt32());
				}
				if (num13 != 80)
				{
					goto IL_0445;
				}
				num14 = (set_ = input.ReadInt32());
			}
			int num15 = default(int);
			if (num14 > 16)
			{
				if (num14 == 18)
				{
					goto IL_042c;
				}
				if (num14 != 24)
				{
					goto IL_0445;
				}
				num15 = (int)(type_ = (ItemType)input.ReadInt32());
			}
			int num16 = default(int);
			if (num15 == 8)
			{
				num16 = (item_ = input.ReadInt32());
			}
			if (num16 == 16)
			{
				goto IL_042c;
			}
			goto IL_0445;
		}

		[Cpp2IlInjected.Token(Token = "0x6003355")]
		[Cpp2IlInjected.Address(RVA = "0x22DA390", Offset = "0x22D8D90", VA = "0x1822DA390", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 40)
			{
				RepeatedField<int> repeatedField = itemList_;
			}
			if (fieldNumber == 50)
			{
			}
			if (fieldNumber <= 10)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003356")]
		[Cpp2IlInjected.Address(RVA = "0x22DB8C0", Offset = "0x22DA2C0", VA = "0x1822DB8C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0012, IL_001a, IL_0022, IL_002a, IL_0036, IL_003e, IL_0046, IL_0047, IL_0054, IL_005c, IL_005d, IL_006a, IL_0072, IL_007a, IL_0082, IL_00aa, IL_00b2, IL_00ba, IL_00c2, IL_00ca, IL_00d2
			//IL_0011: Expected I4, but got O
			//IL_0019: Expected I4, but got O
			//IL_0021: Expected I4, but got O
			//IL_0029: Expected I4, but got O
			//IL_0035: Expected O, but got I4
			//IL_0097: Expected I4, but got O
			if (fieldNumber - 1 <= 40)
			{
				object obj = default(object);
				item_ = (int)obj;
				return;
			}
			object obj2 = default(object);
			if (fieldNumber == 50)
			{
				minMealStarRating_ = (int)obj2;
				return;
			}
			obj2 += (object)typeof(int).TypeHandle;
			minUnlockLevel_ = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003357")]
		[Cpp2IlInjected.Address(RVA = "0x22D9C40", Offset = "0x22D8640", VA = "0x1822D9C40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_0036, IL_0037, IL_0038, IL_0039, IL_003b
			//IL_0012: Expected I4, but got I8
			//IL_002d: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num <= 40)
			{
				item_ = 0;
			}
			else if (fieldNumber == 50)
			{
				minMealStarRating_ = 0;
			}
			else if (fieldNumber <= 10)
			{
				num = fieldNumber;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003359")]
		[Cpp2IlInjected.Address(RVA = "0x22DB850", Offset = "0x22DA250", VA = "0x1822DB850")]
		[IteratorStateMachine(typeof(_003CSelectedItems_003Ed__171))]
		public IEnumerable<Item> SelectedItems()
		{
			new _003CSelectedItems_003Ed__171(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600335A")]
		[Cpp2IlInjected.Address(RVA = "0x22DC8C0", Offset = "0x22DB2C0", VA = "0x1822DC8C0")]
		static ItemFilterData()
		{
			_parser = (MessageParser<ItemFilterData>)(object)FieldCodec.ForInt32(18u);
			uint num = default(uint);
			_parser = (MessageParser<ItemFilterData>)(object)FieldCodec.ForInt32(num);
			uint num2 = default(uint);
			_parser = (MessageParser<ItemFilterData>)(object)FieldCodec.ForInt32(num2);
			(TagItemType, int?)[] array = new(TagItemType, int?)[0];
			ReadOnlyCollection<(TagItemType, int?)> parser = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<ItemFilterData>)(object)parser;
			/*Error: Unexpected end of block*/;
		}
	}
}
