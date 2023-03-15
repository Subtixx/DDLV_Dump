using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Cpp2IlInjected;
using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002F7")]
	public sealed class ClothingItemData : IMessage<ClothingItemData>, IMessage, IEquatable<ClothingItemData>, IDeepCloneable<ClothingItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IAppraisableItemData, IHasTags, IHasTraits, IGenericBuyable, IOnlineAvailability, IAvailability, IHasSet, IHasRarity, IDreamDustConvertible, IHasUnlockConditions, IPriceOverrider, IIsCustomizable, IIsHiddable, IDataValidation, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4000E0E")]
		private static readonly MessageParser<ClothingItemData> _parser = (MessageParser<ClothingItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ClothingItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E0F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000E10")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000E11")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000E12")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E13")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x4000E14")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000E15")]
		private string displayName_;

		[Cpp2IlInjected.Token(Token = "0x4000E16")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000E17")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000E18")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000E19")]
		private string prefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000E1A")]
		public const int QualityFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000E1B")]
		private Quality quality_;

		[Cpp2IlInjected.Token(Token = "0x4000E1C")]
		public const int RarityFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000E1D")]
		private int rarity_;

		[Cpp2IlInjected.Token(Token = "0x4000E1E")]
		public const int SetItemIDFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000E1F")]
		private int setItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000E20")]
		public const int TagsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000E21")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000E22")]
		private readonly RepeatedField<int> tags_;

		[Cpp2IlInjected.Token(Token = "0x4000E23")]
		public const int ComplexityFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000E24")]
		private Complexity complexity_;

		[Cpp2IlInjected.Token(Token = "0x4000E25")]
		public const int ComplexityStrengthFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000E26")]
		private int complexityStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000E27")]
		public const int MoodFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000E28")]
		private Mood mood_;

		[Cpp2IlInjected.Token(Token = "0x4000E29")]
		public const int MoodStrengthFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000E2A")]
		private int moodStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000E2B")]
		public const int SturdinessFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000E2C")]
		private Sturdiness sturdiness_;

		[Cpp2IlInjected.Token(Token = "0x4000E2D")]
		public const int SturdinessStrengthFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000E2E")]
		private int sturdinessStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000E2F")]
		public const int NormalityFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000E30")]
		private Normality normality_;

		[Cpp2IlInjected.Token(Token = "0x4000E31")]
		public const int NormalityStrengthFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000E32")]
		private int normalityStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000E33")]
		public const int MaleIconAddressFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000E34")]
		private string maleIconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000E35")]
		public const int MalePrefabAddressFieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000E36")]
		private string malePrefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000E37")]
		public const int DefaultCurrencyItemIDFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000E38")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000E39")]
		public const int DreamDustOverrideValueFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000E3A")]
		private int dreamDustOverrideValue_;

		[Cpp2IlInjected.Token(Token = "0x4000E3B")]
		public const int CatalogVisibilityConditionsFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000E3C")]
		private CatalogVisibilityConditions catalogVisibilityConditions_;

		[Cpp2IlInjected.Token(Token = "0x4000E3D")]
		public const int PriceOverrideFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000E3E")]
		private PriceOverride priceOverride_;

		[Cpp2IlInjected.Token(Token = "0x4000E3F")]
		public const int CanAddDecalsFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000E40")]
		private bool canAddDecals_;

		[Cpp2IlInjected.Token(Token = "0x4000E41")]
		public const int CanChangeColorFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4000E42")]
		private bool canChangeColor_;

		[Cpp2IlInjected.Token(Token = "0x4000E43")]
		public const int IncompatibleWithFieldNumber = 26;

		[Cpp2IlInjected.Token(Token = "0x4000E44")]
		private static readonly FieldCodec<ClothingItemType> _repeated_incompatibleWith_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000E45")]
		private readonly RepeatedField<ClothingItemType> incompatibleWith_;

		[Cpp2IlInjected.Token(Token = "0x4000E46")]
		public const int IsHiddenFieldNumber = 27;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000E47")]
		private bool isHidden_;

		[Cpp2IlInjected.Token(Token = "0x4000E48")]
		public const int IsUnavailableForGeneratorFieldNumber = 28;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x4000E49")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x4000E4A")]
		public const int IsSyncOnlineItemFieldNumber = 29;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB2")]
		[Cpp2IlInjected.Token(Token = "0x4000E4B")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4000E4C")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000E4D")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000E4E")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x170007CF")]
		[DebuggerNonUserCode]
		public static MessageParser<ClothingItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60020FE")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0980", Offset = "0x2EBF380", VA = "0x182EC0980")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60020FF")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0880", Offset = "0x2EBF280", VA = "0x182EC0880")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002100")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0A40", Offset = "0x2EBF440", VA = "0x182EC0A40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D2")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002105")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002106")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D3")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002107")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002108")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0D20", Offset = "0x2EBF720", VA = "0x182EC0D20")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D4")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002109")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600210A")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0B50", Offset = "0x2EBF550", VA = "0x182EC0B50")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D5")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600210B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600210C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0BC0", Offset = "0x2EBF5C0", VA = "0x182EC0BC0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D6")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600210D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600210E")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0D90", Offset = "0x2EBF790", VA = "0x182EC0D90")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D7")]
		[DebuggerNonUserCode]
		public Quality Quality
		{
			[Cpp2IlInjected.Token(Token = "0x600210F")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0", Slot = "24")]
			get
			{
				return quality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002110")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				quality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D8")]
		[DebuggerNonUserCode]
		public int Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6002111")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70", Slot = "42")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002112")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				rarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D9")]
		[DebuggerNonUserCode]
		public int SetItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002113")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return setItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002114")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				setItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DA")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002115")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "26")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DB")]
		[DebuggerNonUserCode]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6002116")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "27")]
			get
			{
				return complexity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002117")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				complexity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DC")]
		[DebuggerNonUserCode]
		public int ComplexityStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6002118")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820", Slot = "28")]
			get
			{
				return complexityStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002119")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				complexityStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DD")]
		[DebuggerNonUserCode]
		public Mood Mood
		{
			[Cpp2IlInjected.Token(Token = "0x600211A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "29")]
			get
			{
				return mood_;
			}
			[Cpp2IlInjected.Token(Token = "0x600211B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				mood_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DE")]
		[DebuggerNonUserCode]
		public int MoodStrength
		{
			[Cpp2IlInjected.Token(Token = "0x600211C")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "30")]
			get
			{
				return moodStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x600211D")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				moodStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DF")]
		[DebuggerNonUserCode]
		public Sturdiness Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x600211E")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70", Slot = "31")]
			get
			{
				return sturdiness_;
			}
			[Cpp2IlInjected.Token(Token = "0x600211F")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				sturdiness_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E0")]
		[DebuggerNonUserCode]
		public int SturdinessStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6002120")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0", Slot = "32")]
			get
			{
				return sturdinessStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002121")]
			[Cpp2IlInjected.Address(RVA = "0x960750", Offset = "0x95F150", VA = "0x180960750")]
			set
			{
				sturdinessStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E1")]
		[DebuggerNonUserCode]
		public Normality Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6002122")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "33")]
			get
			{
				return normality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002123")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set
			{
				normality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E2")]
		[DebuggerNonUserCode]
		public int NormalityStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6002124")]
			[Cpp2IlInjected.Address(RVA = "0xDD7040", Offset = "0xDD5A40", VA = "0x180DD7040", Slot = "34")]
			get
			{
				return normalityStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002125")]
			[Cpp2IlInjected.Address(RVA = "0xDD7100", Offset = "0xDD5B00", VA = "0x180DD7100")]
			set
			{
				normalityStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E3")]
		[DebuggerNonUserCode]
		public string MaleIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002126")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return maleIconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002127")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0C40", Offset = "0x2EBF640", VA = "0x182EC0C40")]
			set
			{
				string text = (maleIconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E4")]
		[DebuggerNonUserCode]
		public string MalePrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002128")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return malePrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002129")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0CB0", Offset = "0x2EBF6B0", VA = "0x182EC0CB0")]
			set
			{
				string text = (malePrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E5")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600212A")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600212B")]
			[Cpp2IlInjected.Address(RVA = "0x125C1F0", Offset = "0x125ABF0", VA = "0x18125C1F0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E6")]
		[DebuggerNonUserCode]
		public int DreamDustOverrideValue
		{
			[Cpp2IlInjected.Token(Token = "0x600212C")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0A0", Offset = "0xA8CAA0", VA = "0x180A8E0A0", Slot = "44")]
			get
			{
				return dreamDustOverrideValue_;
			}
			[Cpp2IlInjected.Token(Token = "0x600212D")]
			[Cpp2IlInjected.Address(RVA = "0x125C200", Offset = "0x125AC00", VA = "0x18125C200")]
			set
			{
				dreamDustOverrideValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E7")]
		[DebuggerNonUserCode]
		public CatalogVisibilityConditions CatalogVisibilityConditions
		{
			[Cpp2IlInjected.Token(Token = "0x600212E")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "45")]
			get
			{
				return catalogVisibilityConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x600212F")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			set
			{
				catalogVisibilityConditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E8")]
		[DebuggerNonUserCode]
		public PriceOverride PriceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6002130")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0", Slot = "46")]
			get
			{
				return priceOverride_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002131")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			set
			{
				priceOverride_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E9")]
		[DebuggerNonUserCode]
		public bool CanAddDecals
		{
			[Cpp2IlInjected.Token(Token = "0x6002132")]
			[Cpp2IlInjected.Address(RVA = "0x1603120", Offset = "0x1601B20", VA = "0x181603120", Slot = "47")]
			get
			{
				return canAddDecals_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002133")]
			[Cpp2IlInjected.Address(RVA = "0x1552740", Offset = "0x1551140", VA = "0x181552740")]
			set
			{
				canAddDecals_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007EA")]
		[DebuggerNonUserCode]
		public bool CanChangeColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002134")]
			[Cpp2IlInjected.Address(RVA = "0x2287B30", Offset = "0x2286530", VA = "0x182287B30", Slot = "48")]
			get
			{
				return canChangeColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002135")]
			[Cpp2IlInjected.Address(RVA = "0x2287B80", Offset = "0x2286580", VA = "0x182287B80")]
			set
			{
				canChangeColor_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007EB")]
		[DebuggerNonUserCode]
		public RepeatedField<ClothingItemType> IncompatibleWith
		{
			[Cpp2IlInjected.Token(Token = "0x6002136")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return incompatibleWith_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007EC")]
		[DebuggerNonUserCode]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x6002137")]
			[Cpp2IlInjected.Address(RVA = "0x1195B30", Offset = "0x1194530", VA = "0x181195B30", Slot = "49")]
			get
			{
				return isHidden_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002138")]
			[Cpp2IlInjected.Address(RVA = "0x1339830", Offset = "0x1338230", VA = "0x181339830")]
			set
			{
				isHidden_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007ED")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6002139")]
			[Cpp2IlInjected.Address(RVA = "0x1195B50", Offset = "0x1194550", VA = "0x181195B50", Slot = "39")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x600213A")]
			[Cpp2IlInjected.Address(RVA = "0x20B6200", Offset = "0x20B4C00", VA = "0x1820B6200", Slot = "40")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007EE")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x600213B")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0970", Offset = "0x2EBF370", VA = "0x182EC0970", Slot = "37")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x600213C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0C30", Offset = "0x2EBF630", VA = "0x182EC0C30", Slot = "38")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007EF")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x600213D")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACC0", Offset = "0xA596C0", VA = "0x180A5ACC0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600213E")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACF0", Offset = "0xA596F0", VA = "0x180A5ACF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F0")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600214A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "51")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F1")]
		public Item SetItem
		{
			[Cpp2IlInjected.Token(Token = "0x600214B")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "41")]
			get
			{
				int num = setItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F2")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600214C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC09E0", Offset = "0x2EBF3E0", VA = "0x182EC09E0", Slot = "25")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F3")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x600214D")]
			[Cpp2IlInjected.Address(RVA = "0x2EBDB70", Offset = "0x2EBC570", VA = "0x182EBDB70", Slot = "36")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F4")]
		public bool IsCustomizable
		{
			[Cpp2IlInjected.Token(Token = "0x600214E")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0950", Offset = "0x2EBF350", VA = "0x182EC0950")]
			get
			{
				if (!canAddDecals_)
				{
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F5")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x600214F")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0870", Offset = "0x2EBF270", VA = "0x182EC0870", Slot = "52")]
			get
			{
				return !isHidden_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002101")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0450", Offset = "0x2EBEE50", VA = "0x182EC0450")]
		[DebuggerNonUserCode]
		public ClothingItemData()
		{
			//IL_0078: Expected I4, but got I8
			//IL_0081: Expected I4, but got I8
			//IL_008a: Expected I4, but got I8
			//IL_0093: Expected I4, but got I8
			//IL_009c: Expected I4, but got I8
			name_ = "";
			displayName_ = "";
			iconAddress_ = "";
			prefabAddress_ = "";
			tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			maleIconAddress_ = "";
			malePrefabAddress_ = "";
			incompatibleWith_ = (RepeatedField<ClothingItemType>)(object)new RepeatedField<T>();
			base._002Ector();
			CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
			rarity_ = 1;
			complexityStrength_ = 1;
			moodStrength_ = 1;
			sturdinessStrength_ = 1;
			normalityStrength_ = 1;
			PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002102")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEFA0", Offset = "0x2EBD9A0", VA = "0x182EBEFA0")]
		private void OnConstruction()
		{
			//IL_0016: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			//IL_0031: Expected I4, but got I8
			//IL_003a: Expected I4, but got I8
			CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
			rarity_ = 1;
			complexityStrength_ = 1;
			moodStrength_ = 1;
			sturdinessStrength_ = 1;
			normalityStrength_ = 1;
			PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002103")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0630", Offset = "0x2EBF030", VA = "0x182EC0630")]
		[DebuggerNonUserCode]
		public ClothingItemData(ClothingItemData other)
		{
			//IL_016e: Expected O, but got I4
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			Quality quality = (quality_ = other.quality_);
			int num2 = (rarity_ = other.rarity_);
			int num3 = (setItemID_ = other.setItemID_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			Complexity complexity = (complexity_ = other.complexity_);
			int num4 = (complexityStrength_ = other.complexityStrength_);
			Mood mood = (mood_ = other.mood_);
			int num5 = (moodStrength_ = other.moodStrength_);
			Sturdiness sturdiness = (sturdiness_ = other.sturdiness_);
			int num6 = (sturdinessStrength_ = other.sturdinessStrength_);
			Normality normality = (normality_ = other.normality_);
			int num7 = (normalityStrength_ = other.normalityStrength_);
			string text5 = (maleIconAddress_ = other.maleIconAddress_);
			string text6 = (malePrefabAddress_ = other.malePrefabAddress_);
			int num8 = other.defaultCurrencyItemID_;
			int num9 = 0;
			defaultCurrencyItemID_ = num8;
			int num10 = (dreamDustOverrideValue_ = other.dreamDustOverrideValue_);
			CatalogVisibilityConditions catalogVisibilityConditions = other.catalogVisibilityConditions_;
			if (catalogVisibilityConditions != null)
			{
				CatalogVisibilityConditions catalogVisibilityConditions2 = catalogVisibilityConditions.Clone();
			}
			catalogVisibilityConditions_ = (CatalogVisibilityConditions)num9;
			PriceOverride priceOverride = other.priceOverride_;
			PriceOverride priceOverride2 = default(PriceOverride);
			if (priceOverride != null)
			{
				priceOverride2 = priceOverride.Clone();
			}
			priceOverride_ = priceOverride2;
			bool flag = (canAddDecals_ = other.canAddDecals_);
			bool flag2 = (canChangeColor_ = other.canChangeColor_);
			RepeatedField<ClothingItemType> repeatedField2 = (incompatibleWith_ = (RepeatedField<ClothingItemType>)(object)((RepeatedField<T>)(object)other.incompatibleWith_).Clone());
			bool flag3 = (isHidden_ = other.isHidden_);
			bool flag4 = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			bool flag5 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			uint num11 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002104")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD960", Offset = "0x2EBC360", VA = "0x182EBD960", Slot = "10")]
		[DebuggerNonUserCode]
		public ClothingItemData Clone()
		{
			return new ClothingItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600213F")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDBD0", Offset = "0x2EBC5D0", VA = "0x182EBDBD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002140")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDC30", Offset = "0x2EBC630", VA = "0x182EBDC30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ClothingItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if ((IntPtr)usedTagTypes == (IntPtr)num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									Quality quality = other.quality_;
									if (quality_ == quality)
									{
										int num2 = other.rarity_;
										if (rarity_ == num2)
										{
											int num3 = other.setItemID_;
											if (setItemID_ == num3)
											{
												RepeatedField<int> repeatedField = tags_;
												RepeatedField<int> repeatedField2 = other.tags_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													Complexity complexity = other.complexity_;
													if (complexity_ == complexity)
													{
														int num4 = other.complexityStrength_;
														if (complexityStrength_ == num4)
														{
															Mood mood = other.mood_;
															if (mood_ == mood)
															{
																int num5 = other.moodStrength_;
																if (moodStrength_ == num5)
																{
																	Sturdiness sturdiness = other.sturdiness_;
																	if (sturdiness_ == sturdiness)
																	{
																		int num6 = other.sturdinessStrength_;
																		if (sturdinessStrength_ == num6)
																		{
																			Normality normality = other.normality_;
																			if (normality_ == normality)
																			{
																				int num7 = other.normalityStrength_;
																				if (normalityStrength_ == num7)
																				{
																					string text5 = other.maleIconAddress_;
																					if (!(maleIconAddress_ != text5))
																					{
																						string text6 = other.malePrefabAddress_;
																						if (!(malePrefabAddress_ != text6))
																						{
																							int num8 = other.defaultCurrencyItemID_;
																							if (defaultCurrencyItemID_ == num8)
																							{
																								int num9 = other.dreamDustOverrideValue_;
																								if (dreamDustOverrideValue_ == num9)
																								{
																									CatalogVisibilityConditions objB = other.catalogVisibilityConditions_;
																									if (object.Equals(catalogVisibilityConditions_, objB))
																									{
																										PriceOverride objB2 = other.priceOverride_;
																										if (object.Equals(priceOverride_, objB2))
																										{
																											bool flag = other.canAddDecals_;
																											if (canAddDecals_ == flag)
																											{
																												bool flag2 = other.canChangeColor_;
																												if (canChangeColor_ == flag2)
																												{
																													RepeatedField<ClothingItemType> repeatedField3 = incompatibleWith_;
																													RepeatedField<ClothingItemType> repeatedField4 = other.incompatibleWith_;
																													if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																													{
																														bool flag3 = other.isHidden_;
																														if (isHidden_ == flag3)
																														{
																															bool flag4 = other.isUnavailableForGenerator_;
																															if (isUnavailableForGenerator_ == flag4)
																															{
																																bool flag5 = other.isSyncOnlineItem_;
																																if (isSyncOnlineItem_ == flag5)
																																{
																																	uint num10 = other.glotID_;
																																	if (glotID_ == num10)
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
			int num11 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002141")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE2E0", Offset = "0x2EBCCE0", VA = "0x182EBE2E0", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_01da
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			if (quality_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text4)->ResultCode;
			}
			if (rarity_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text4)->ResultCode;
			}
			if (setItemID_ != 0)
			{
				Result resultCode3 = ((SessionSearchFindCallbackInfo*)text4)->ResultCode;
			}
			int hashCode5 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (complexity_ != 0)
			{
			}
			if (complexityStrength_ != 0)
			{
			}
			if (mood_ != 0)
			{
			}
			if (moodStrength_ != 0)
			{
			}
			if (sturdiness_ != 0)
			{
			}
			if (sturdinessStrength_ != 0)
			{
			}
			if (normality_ != 0)
			{
			}
			if (normalityStrength_ != 0)
			{
			}
			string text5 = maleIconAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			string text6 = malePrefabAddress_;
			if (text6.m_stringLength != 0)
			{
				int hashCode7 = text6.GetHashCode();
			}
			if (defaultCurrencyItemID_ != 0)
			{
				Result resultCode4 = ((SessionSearchFindCallbackInfo*)text6)->ResultCode;
			}
			if (dreamDustOverrideValue_ != 0)
			{
				Result resultCode5 = ((SessionSearchFindCallbackInfo*)text6)->ResultCode;
			}
			CatalogVisibilityConditions catalogVisibilityConditions = catalogVisibilityConditions_;
			if (catalogVisibilityConditions != null)
			{
				int hashCode8 = catalogVisibilityConditions.GetHashCode();
			}
			PriceOverride priceOverride = priceOverride_;
			if (priceOverride != null)
			{
				int hashCode9 = priceOverride.GetHashCode();
			}
			if (canAddDecals_)
			{
			}
			if (canChangeColor_)
			{
			}
			int hashCode10 = ((RepeatedField<T>)(object)incompatibleWith_).GetHashCode();
			if (isHidden_)
			{
			}
			if (isUnavailableForGenerator_)
			{
			}
			if (isSyncOnlineItem_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode11 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002142")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF9D0", Offset = "0x2EBE3D0", VA = "0x182EBF9D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002143")]
		[Cpp2IlInjected.Address(RVA = "0x2EBFA30", Offset = "0x2EBE430", VA = "0x182EBFA30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_02d1
			if ((long)usedTagTypes != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (quality_ != 0)
			{
			}
			if (rarity_ != 0)
			{
				int value6 = rarity_;
				output.WriteInt32(value6);
			}
			if (setItemID_ != 0)
			{
				int value7 = setItemID_;
				output.WriteInt32(value7);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (complexity_ != 0)
			{
			}
			if (complexityStrength_ != 0)
			{
				int value8 = complexityStrength_;
				output.WriteInt32(value8);
			}
			if (mood_ != 0)
			{
			}
			if (moodStrength_ != 0)
			{
				int value9 = moodStrength_;
				output.WriteInt32(value9);
			}
			if (sturdiness_ != 0)
			{
			}
			if (sturdinessStrength_ != 0)
			{
				int value10 = sturdinessStrength_;
				output.WriteInt32(value10);
			}
			if (normality_ != 0)
			{
			}
			if (normalityStrength_ != 0)
			{
				int value11 = normalityStrength_;
				output.WriteInt32(value11);
			}
			if (maleIconAddress_.m_stringLength != 0)
			{
				string value12 = maleIconAddress_;
				output.WriteString(value12);
			}
			if (malePrefabAddress_.m_stringLength != 0)
			{
				string value13 = malePrefabAddress_;
				output.WriteString(value13);
			}
			if (defaultCurrencyItemID_ != 0)
			{
				int value14 = defaultCurrencyItemID_;
				output.WriteInt32(value14);
			}
			if (dreamDustOverrideValue_ != 0)
			{
				int value15 = dreamDustOverrideValue_;
				output.WriteInt32(value15);
			}
			if ((long)catalogVisibilityConditions_ != 0)
			{
				CatalogVisibilityConditions value16 = catalogVisibilityConditions_;
				output.WriteMessage(value16);
			}
			if ((long)priceOverride_ != 0)
			{
				PriceOverride value17 = priceOverride_;
				output.WriteMessage(value17);
			}
			if (canAddDecals_)
			{
				bool value18 = canAddDecals_;
				output.WriteBool(value18);
			}
			if (canChangeColor_)
			{
				bool value19 = canChangeColor_;
				output.WriteBool(value19);
			}
			RepeatedField<ClothingItemType> repeatedField2 = incompatibleWith_;
			FieldCodec<ClothingItemType> repeated_incompatibleWith_codec = _repeated_incompatibleWith_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_incompatibleWith_codec);
			if (isHidden_)
			{
				bool value20 = isHidden_;
				output.WriteBool(value20);
			}
			if (isUnavailableForGenerator_)
			{
				bool value21 = isUnavailableForGenerator_;
				output.WriteBool(value21);
			}
			if (isSyncOnlineItem_)
			{
				bool value22 = isSyncOnlineItem_;
				output.WriteBool(value22);
			}
			if (glotID_ != 0)
			{
				uint value23 = glotID_;
				output.WriteUInt32(value23);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002144")]
		[Cpp2IlInjected.Address(RVA = "0x2EBCFA0", Offset = "0x2EBB9A0", VA = "0x182EBCFA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Expected O, but got Unknown
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			Quality quality = quality_;
			if (quality != 0)
			{
				int num8 = CodedOutputStream.ComputeEnumSize((int)quality);
				num8++;
				num2 += num8;
			}
			int num9 = rarity_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			int num11 = setItemID_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num13 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			Complexity complexity = complexity_;
			num2 += num13;
			if (complexity != 0)
			{
				int num14 = CodedOutputStream.ComputeEnumSize((int)complexity);
				num14++;
				num2 += num14;
			}
			int num15 = complexityStrength_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num2 += num16;
			}
			Mood mood = mood_;
			if (mood != 0)
			{
				int num17 = CodedOutputStream.ComputeEnumSize((int)mood);
				num17++;
				num2 += num17;
			}
			int num18 = moodStrength_;
			if (num18 != 0)
			{
				int num19 = CodedOutputStream.ComputeInt32Size(num18);
				num19++;
				num2 += num19;
			}
			Sturdiness sturdiness = sturdiness_;
			if (sturdiness != 0)
			{
				int num20 = CodedOutputStream.ComputeEnumSize((int)sturdiness);
				num20++;
				num2 += num20;
			}
			int num21 = sturdinessStrength_;
			if (num21 != 0)
			{
				int num22 = CodedOutputStream.ComputeInt32Size(num21);
				num22++;
				num2 += num22;
			}
			Normality normality = normality_;
			if (normality != 0)
			{
				int num23 = CodedOutputStream.ComputeEnumSize((int)normality);
				num23 += 2;
				num2 += num23;
			}
			int num24 = normalityStrength_;
			if (num24 != 0)
			{
				int num25 = CodedOutputStream.ComputeInt32Size(num24);
				num25 += 2;
				num2 += num25;
			}
			string text5 = maleIconAddress_;
			if (text5.m_stringLength != 0)
			{
				int num26 = CodedOutputStream.ComputeStringSize(text5);
				num26 += 2;
				num2 += num26;
			}
			string text6 = malePrefabAddress_;
			if (text6.m_stringLength != 0)
			{
				int num27 = CodedOutputStream.ComputeStringSize(text6);
				num27 += 2;
				num2 += num27;
			}
			int num28 = defaultCurrencyItemID_;
			if (num28 != 0)
			{
				int num29 = CodedOutputStream.ComputeInt32Size(num28);
				num29 += 2;
				num2 += num29;
			}
			int num30 = dreamDustOverrideValue_;
			if (num30 != 0)
			{
				int num31 = CodedOutputStream.ComputeInt32Size(num30);
				num31 += 2;
				num2 += num31;
			}
			CatalogVisibilityConditions catalogVisibilityConditions = catalogVisibilityConditions_;
			if (catalogVisibilityConditions != null)
			{
				int num32 = CodedOutputStream.ComputeMessageSize(catalogVisibilityConditions);
				num32 += 2;
				num2 += num32;
			}
			PriceOverride priceOverride = priceOverride_;
			if (priceOverride != null)
			{
				int num33 = CodedOutputStream.ComputeMessageSize(priceOverride);
				num33 += 2;
				num2 += num33;
			}
			RepeatedField<ClothingItemType> repeatedField2 = incompatibleWith_;
			FieldCodec<ClothingItemType> repeated_incompatibleWith_codec = _repeated_incompatibleWith_codec;
			int num34 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_incompatibleWith_codec);
			uint num35 = glotID_;
			if (num35 != 0)
			{
				int num36 = CodedOutputStream.ComputeUInt32Size(num35);
				num36 += 2;
				repeatedField2 = (RepeatedField<ClothingItemType>)(repeatedField2 + num36);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num37 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<ClothingItemType>)(repeatedField2 + num37);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002145")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE690", Offset = "0x2EBD090", VA = "0x182EBE690", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ClothingItemData other)
		{
			//Discarded unreachable code: IL_0306
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			Quality quality = other.quality_;
			if (quality != 0)
			{
				quality_ = quality;
			}
			int num2 = other.rarity_;
			if (num2 != 0)
			{
				rarity_ = num2;
			}
			int num3 = other.setItemID_;
			if (num3 != 0)
			{
				setItemID_ = num3;
			}
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			Complexity complexity = other.complexity_;
			if (complexity != 0)
			{
				complexity_ = complexity;
			}
			int num4 = other.complexityStrength_;
			if (num4 != 0)
			{
				complexityStrength_ = num4;
			}
			Mood mood = other.mood_;
			if (mood != 0)
			{
				mood_ = mood;
			}
			int num5 = other.moodStrength_;
			if (num5 != 0)
			{
				moodStrength_ = num5;
			}
			Sturdiness sturdiness = other.sturdiness_;
			if (sturdiness != 0)
			{
				sturdiness_ = sturdiness;
			}
			int num6 = other.sturdinessStrength_;
			if (num6 != 0)
			{
				sturdinessStrength_ = num6;
			}
			Normality normality = other.normality_;
			if (normality != 0)
			{
				normality_ = normality;
			}
			int num7 = other.normalityStrength_;
			if (num7 != 0)
			{
				normalityStrength_ = num7;
			}
			string text5 = other.maleIconAddress_;
			if (text5.m_stringLength != 0)
			{
				MaleIconAddress = text5;
			}
			string text6 = other.malePrefabAddress_;
			if (text6.m_stringLength != 0)
			{
				MalePrefabAddress = text6;
			}
			int num8 = other.defaultCurrencyItemID_;
			if (num8 != 0)
			{
				defaultCurrencyItemID_ = num8;
			}
			int num9 = other.dreamDustOverrideValue_;
			if (num9 != 0)
			{
				dreamDustOverrideValue_ = num9;
			}
			if ((long)other.catalogVisibilityConditions_ != 0)
			{
				CatalogVisibilityConditions catalogVisibilityConditions2 = default(CatalogVisibilityConditions);
				if (catalogVisibilityConditions_ == null)
				{
					CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
					catalogVisibilityConditions2 = catalogVisibilityConditions_;
				}
				CatalogVisibilityConditions other2 = other.catalogVisibilityConditions_;
				catalogVisibilityConditions2.MergeFrom(other2);
			}
			if ((long)other.priceOverride_ != 0)
			{
				PriceOverride priceOverride2 = default(PriceOverride);
				if (priceOverride_ == null)
				{
					PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
					priceOverride2 = priceOverride_;
				}
				PriceOverride other3 = other.priceOverride_;
				priceOverride2.MergeFrom(other3);
			}
			bool flag = other.canAddDecals_;
			if (flag)
			{
				canAddDecals_ = flag;
			}
			bool flag2 = other.canChangeColor_;
			if (flag2)
			{
				canChangeColor_ = flag2;
			}
			RepeatedField<ClothingItemType> repeatedField3 = incompatibleWith_;
			RepeatedField<ClothingItemType> repeatedField4 = other.incompatibleWith_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			bool flag3 = other.isHidden_;
			if (flag3)
			{
				isHidden_ = flag3;
			}
			bool flag4 = other.isUnavailableForGenerator_;
			if (flag4)
			{
				isUnavailableForGenerator_ = flag4;
			}
			bool flag5 = other.isSyncOnlineItem_;
			if (flag5)
			{
				isSyncOnlineItem_ = flag5;
			}
			uint num10 = other.glotID_;
			if (num10 != 0)
			{
				glotID_ = num10;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002146")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE9F0", Offset = "0x2EBD3F0", VA = "0x182EBE9F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_03d9
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 120)
			{
				if ((int)num > 186)
				{
					if ((int)num > 210)
					{
						if ((int)num > 224)
						{
							if (num == 232)
							{
								bool flag = (isSyncOnlineItem_ = input.ReadBool());
							}
							if (num != 7992)
							{
								goto IL_03c2;
							}
							int num2 = (int)(glotID_ = (uint)input.ReadInt32());
						}
						bool flag2 = default(bool);
						if (num == 216)
						{
							flag2 = (isHidden_ = input.ReadBool());
						}
						if (!flag2)
						{
							goto IL_03c2;
						}
						bool flag3 = (isUnavailableForGenerator_ = input.ReadBool());
					}
					if ((int)num > 200)
					{
						num += 4294967088u;
						if (num != 4294967293u)
						{
							goto IL_03c2;
						}
						RepeatedField<ClothingItemType> repeatedField = incompatibleWith_;
						FieldCodec<ClothingItemType> repeated_incompatibleWith_codec = _repeated_incompatibleWith_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_incompatibleWith_codec);
					}
					bool flag4 = default(bool);
					if (num == 192)
					{
						flag4 = (canAddDecals_ = input.ReadBool());
					}
					if (!flag4)
					{
						goto IL_03c2;
					}
					bool flag5 = (canChangeColor_ = input.ReadBool());
				}
				int num4 = default(int);
				if ((int)num > 154)
				{
					PriceOverride priceOverride = default(PriceOverride);
					if ((int)num > 168)
					{
						CatalogVisibilityConditions catalogVisibilityConditions = default(CatalogVisibilityConditions);
						if (num == 178)
						{
							CatalogVisibilityConditions builder = default(CatalogVisibilityConditions);
							if (catalogVisibilityConditions_ == null)
							{
								catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
								builder = catalogVisibilityConditions_;
							}
							input.ReadMessage(builder);
						}
						if ((long)catalogVisibilityConditions != 186)
						{
							goto IL_03c2;
						}
						PriceOverride builder2 = default(PriceOverride);
						if (priceOverride_ == null)
						{
							priceOverride = (priceOverride_ = new PriceOverride());
							builder2 = priceOverride_;
						}
						input.ReadMessage(builder2);
					}
					int num3 = default(int);
					if ((long)priceOverride == 160)
					{
						num3 = (defaultCurrencyItemID_ = input.ReadInt32());
					}
					if (num3 != 168)
					{
						goto IL_03c2;
					}
					num4 = (dreamDustOverrideValue_ = input.ReadInt32());
				}
				string text4 = default(string);
				if (num4 > 136)
				{
					string text2 = default(string);
					if (num4 == 146)
					{
						text2 = (MaleIconAddress = input.ReadString());
					}
					if ((long)text2 != 154)
					{
						goto IL_03c2;
					}
					text4 = (MalePrefabAddress = input.ReadString());
				}
				int num5 = default(int);
				if ((long)text4 == 128)
				{
					num5 = (int)(normality_ = (Normality)input.ReadInt32());
				}
				if (num5 != 136)
				{
					goto IL_03c2;
				}
				int num6 = (normalityStrength_ = input.ReadInt32());
			}
			int num12 = default(int);
			if ((int)num > 64)
			{
				int num10 = default(int);
				if ((int)num > 88)
				{
					int num8 = default(int);
					if ((int)num > 104)
					{
						int num7 = default(int);
						if (num == 112)
						{
							num7 = (int)(sturdiness_ = (Sturdiness)input.ReadInt32());
						}
						if (num7 != 120)
						{
							goto IL_03c2;
						}
						num8 = (sturdinessStrength_ = input.ReadInt32());
					}
					int num9 = default(int);
					if (num8 == 96)
					{
						num9 = (int)(mood_ = (Mood)input.ReadInt32());
					}
					if (num9 != 104)
					{
						goto IL_03c2;
					}
					num10 = (moodStrength_ = input.ReadInt32());
				}
				if (num10 > 74)
				{
					int num11 = default(int);
					if (num10 == 80)
					{
						num11 = (int)(complexity_ = (Complexity)input.ReadInt32());
					}
					if (num11 != 88)
					{
						goto IL_03c2;
					}
					num12 = (complexityStrength_ = input.ReadInt32());
				}
				num12 += -72;
				if (num12 != -3)
				{
					goto IL_03c2;
				}
				RepeatedField<int> repeatedField2 = tags_;
				FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			}
			int num15 = default(int);
			if (num12 > 34)
			{
				int num14 = default(int);
				if (num12 > 48)
				{
					int num13 = default(int);
					if (num12 == 56)
					{
						num13 = (rarity_ = input.ReadInt32());
					}
					if (num13 != 64)
					{
						goto IL_03c2;
					}
					num14 = (setItemID_ = input.ReadInt32());
				}
				string text6 = default(string);
				if (num14 == 42)
				{
					text6 = (PrefabAddress = input.ReadString());
				}
				if ((long)text6 != 48)
				{
					goto IL_03c2;
				}
				num15 = (int)(quality_ = (Quality)input.ReadInt32());
			}
			string text10 = default(string);
			if (num15 > 18)
			{
				string text8 = default(string);
				if (num15 == 26)
				{
					text8 = (DisplayName = input.ReadString());
				}
				if ((long)text8 != 34)
				{
					goto IL_03c2;
				}
				text10 = (IconAddress = input.ReadString());
			}
			int num16 = default(int);
			if ((long)text10 == 8)
			{
				num16 = (iD_ = input.ReadInt32());
			}
			if (num16 == 18)
			{
				string text12 = (Name = input.ReadString());
			}
			goto IL_03c2;
			IL_03c2:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002147")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDEF0", Offset = "0x2EBC8F0", VA = "0x182EBDEF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 28)
			{
				string text = name_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002148")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF060", Offset = "0x2EBDA60", VA = "0x182EBF060", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0012, IL_001c, IL_001d, IL_001e, IL_001f, IL_002f, IL_0037, IL_003f, IL_0047, IL_004f, IL_0057, IL_005f, IL_0067, IL_006f, IL_0077, IL_007f, IL_0087, IL_0088, IL_0089, IL_0099, IL_00a1, IL_00a9, IL_00b1, IL_00b9, IL_00c1, IL_00c9, IL_00d1, IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107
			//IL_0011: Expected I4, but got O
			//IL_001b: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			//IL_00e8: Expected I4, but got O
			if (fieldNumber - 1 <= 28)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002149")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD5F0", Offset = "0x2EBBFF0", VA = "0x182EBD5F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0022, IL_0023, IL_0024, IL_0025, IL_0026, IL_0027, IL_0028, IL_0029, IL_002a, IL_003d
			//IL_0010: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			if (fieldNumber - 1 <= 28)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002150")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD960", Offset = "0x2EBC360", VA = "0x182EBD960", Slot = "20")]
		IItemData IItemData.Clone()
		{
			ClothingItemData clothingItemData = new ClothingItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002151")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD9C0", Offset = "0x2EBC3C0", VA = "0x182EBD9C0", Slot = "50")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0038
			int num = iD_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__187_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CurrencyCost x) => x.amount_ > 0);
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
				context.AddError("Clothing item must have at least one price greater than 0. Make sure Price Formula is well defined, or use PriceOverride fields.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002152")]
		[Cpp2IlInjected.Address(RVA = "0x2EC00B0", Offset = "0x2EBEAB0", VA = "0x182EC00B0")]
		static ClothingItemData()
		{
			//Discarded unreachable code: IL_0093
			//IL_0071: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_008b: Expected O, but got I4
			_parser = (MessageParser<ClothingItemData>)(object)FieldCodec.ForInt32(74u);
			Func<ClothingItemType, int> func = (Func<ClothingItemType, int>)(object)(Func<T, TResult>)((ClothingItemType x) => (int)x);
			Func<int, ClothingItemType> func2 = (Func<int, ClothingItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ClothingItemData>)(object)FieldCodec.ForEnum<ClothingItemType>(num, (Func<, >)(object)func, (Func<, >)(object)func2);
			(TagItemType, int?)[] array = new(TagItemType, int?)[3];
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num2;
			int num5 = 0;
			((ValueTuple<, >[])(object)array)[2] = (ValueTuple<, >)num5;
			int num6 = 0;
			((ValueTuple<, >[])(object)array)[4] = (ValueTuple<, >)num6;
			ReadOnlyCollection<(TagItemType, int?)> parser = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<ClothingItemData>)(object)parser;
		}
	}
}
