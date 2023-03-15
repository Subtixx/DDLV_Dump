using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002BB")]
	public sealed class FurnitureItemData : IMessage<FurnitureItemData>, IMessage, IEquatable<FurnitureItemData>, IDeepCloneable<FurnitureItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IHasTags, IHasTraits, IGridStateDataProvider, IGenericBuyable, IOnlineAvailability, IAvailability, IHasSet, IHasRarity, IDreamDustConvertible, IHasUnlockConditions, IPriceOverrider, IIsCustomizable, IIsHiddable, IDataValidation, IGridEditRestriction, IHasSubGridInteraction, ICollectionItem, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x20002BC")]
		public enum InteractionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000C29")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000C2A")]
			SubGrid = 26,
			[Cpp2IlInjected.Token(Token = "0x4000C2B")]
			HomeStorage = 27,
			[Cpp2IlInjected.Token(Token = "0x4000C2C")]
			Container = 28,
			[Cpp2IlInjected.Token(Token = "0x4000C2D")]
			CookingStation = 29,
			[Cpp2IlInjected.Token(Token = "0x4000C2E")]
			Radio = 30,
			[Cpp2IlInjected.Token(Token = "0x4000C2F")]
			Keyhole = 31,
			[Cpp2IlInjected.Token(Token = "0x4000C30")]
			CraftingStation = 32,
			[Cpp2IlInjected.Token(Token = "0x4000C31")]
			Toggle = 33,
			[Cpp2IlInjected.Token(Token = "0x4000C32")]
			PictureFrame = 34,
			[Cpp2IlInjected.Token(Token = "0x4000C33")]
			Index = 35
		}

		[Cpp2IlInjected.Token(Token = "0x4000BE0")]
		private static readonly MessageParser<FurnitureItemData> _parser = (MessageParser<FurnitureItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new FurnitureItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000BE1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000BE2")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000BE3")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000BE4")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000BE5")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BE6")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000BE7")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BE8")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000BE9")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BEA")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000BEB")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BEC")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000BED")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000BEE")]
		public const int RarityFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000BEF")]
		private int rarity_;

		[Cpp2IlInjected.Token(Token = "0x4000BF0")]
		public const int SetItemIDFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000BF1")]
		private int setItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000BF2")]
		public const int TagsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000BF3")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000BF4")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000BF5")]
		public const int ComplexityFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000BF6")]
		private Complexity complexity_;

		[Cpp2IlInjected.Token(Token = "0x4000BF7")]
		public const int ComplexityStrengthFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000BF8")]
		private int complexityStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000BF9")]
		public const int MoodFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000BFA")]
		private Mood mood_;

		[Cpp2IlInjected.Token(Token = "0x4000BFB")]
		public const int MoodStrengthFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000BFC")]
		private int moodStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000BFD")]
		public const int SturdinessFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000BFE")]
		private Sturdiness sturdiness_;

		[Cpp2IlInjected.Token(Token = "0x4000BFF")]
		public const int SturdinessStrengthFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000C00")]
		private int sturdinessStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000C01")]
		public const int NormalityFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000C02")]
		private Normality normality_;

		[Cpp2IlInjected.Token(Token = "0x4000C03")]
		public const int NormalityStrengthFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000C04")]
		private int normalityStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000C05")]
		public const int DefaultCurrencyItemIDFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000C06")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000C07")]
		public const int DreamDustOverrideValueFieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000C08")]
		private int dreamDustOverrideValue_;

		[Cpp2IlInjected.Token(Token = "0x4000C09")]
		public const int CatalogVisibilityConditionsFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000C0A")]
		private CatalogVisibilityConditions catalogVisibilityConditions_;

		[Cpp2IlInjected.Token(Token = "0x4000C0B")]
		public const int PriceOverrideFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000C0C")]
		private PriceOverride priceOverride_;

		[Cpp2IlInjected.Token(Token = "0x4000C0D")]
		public const int CanAddDecalsFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000C0E")]
		private bool canAddDecals_;

		[Cpp2IlInjected.Token(Token = "0x4000C0F")]
		public const int CanChangeColorFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000C10")]
		private bool canChangeColor_;

		[Cpp2IlInjected.Token(Token = "0x4000C11")]
		public const int IsHiddenFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x4000C12")]
		private bool isHidden_;

		[Cpp2IlInjected.Token(Token = "0x4000C13")]
		public const int GridEditRestrictionFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000C14")]
		private GridEditRestriction gridEditRestriction_;

		[Cpp2IlInjected.Token(Token = "0x4000C15")]
		public const int SubGridFieldNumber = 26;

		[Cpp2IlInjected.Token(Token = "0x4000C16")]
		public const int HomeStorageFieldNumber = 27;

		[Cpp2IlInjected.Token(Token = "0x4000C17")]
		public const int ContainerFieldNumber = 28;

		[Cpp2IlInjected.Token(Token = "0x4000C18")]
		public const int CookingStationFieldNumber = 29;

		[Cpp2IlInjected.Token(Token = "0x4000C19")]
		public const int RadioFieldNumber = 30;

		[Cpp2IlInjected.Token(Token = "0x4000C1A")]
		public const int KeyholeFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x4000C1B")]
		public const int CraftingStationFieldNumber = 32;

		[Cpp2IlInjected.Token(Token = "0x4000C1C")]
		public const int ToggleFieldNumber = 33;

		[Cpp2IlInjected.Token(Token = "0x4000C1D")]
		public const int PictureFrameFieldNumber = 34;

		[Cpp2IlInjected.Token(Token = "0x4000C1E")]
		public const int IndexFieldNumber = 35;

		[Cpp2IlInjected.Token(Token = "0x4000C1F")]
		public const int IsUnavailableForGeneratorFieldNumber = 36;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000C20")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x4000C21")]
		public const int IsSyncOnlineItemFieldNumber = 37;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4000C22")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4000C23")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000C24")]
		private uint glotID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000C25")]
		private object interactions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000C26")]
		private InteractionsOneofCase interactionsCase_;

		[Cpp2IlInjected.Token(Token = "0x4000C27")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x1700066F")]
		[DebuggerNonUserCode]
		public static MessageParser<FurnitureItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB6")]
			[Cpp2IlInjected.Address(RVA = "0x344BE30", Offset = "0x344A830", VA = "0x18344BE30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000670")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB7")]
			[Cpp2IlInjected.Address(RVA = "0x344BC10", Offset = "0x344A610", VA = "0x18344BC10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000671")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB8")]
			[Cpp2IlInjected.Address(RVA = "0x344C070", Offset = "0x344AA70", VA = "0x18344C070", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000672")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001CBD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CBE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000673")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001CBF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CC0")]
			[Cpp2IlInjected.Address(RVA = "0x344C400", Offset = "0x344AE00", VA = "0x18344C400")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000674")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001CC1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CC2")]
			[Cpp2IlInjected.Address(RVA = "0x344C250", Offset = "0x344AC50", VA = "0x18344C250")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000675")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001CC3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CC4")]
			[Cpp2IlInjected.Address(RVA = "0x344C300", Offset = "0x344AD00", VA = "0x18344C300")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000676")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001CC5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CC6")]
			[Cpp2IlInjected.Address(RVA = "0x344C4B0", Offset = "0x344AEB0", VA = "0x18344C4B0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000677")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001CC7")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "25")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CC8")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000678")]
		[DebuggerNonUserCode]
		public int Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6001CC9")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "44")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CCA")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				rarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000679")]
		[DebuggerNonUserCode]
		public int SetItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001CCB")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return setItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CCC")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				setItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067A")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001CCD")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "27")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067B")]
		[DebuggerNonUserCode]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6001CCE")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "28")]
			get
			{
				return complexity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CCF")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				complexity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067C")]
		[DebuggerNonUserCode]
		public int ComplexityStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6001CD0")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820", Slot = "29")]
			get
			{
				return complexityStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CD1")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				complexityStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067D")]
		[DebuggerNonUserCode]
		public Mood Mood
		{
			[Cpp2IlInjected.Token(Token = "0x6001CD2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "30")]
			get
			{
				return mood_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CD3")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				mood_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067E")]
		[DebuggerNonUserCode]
		public int MoodStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6001CD4")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "31")]
			get
			{
				return moodStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CD5")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				moodStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067F")]
		[DebuggerNonUserCode]
		public Sturdiness Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x6001CD6")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70", Slot = "32")]
			get
			{
				return sturdiness_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CD7")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				sturdiness_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000680")]
		[DebuggerNonUserCode]
		public int SturdinessStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6001CD8")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0", Slot = "33")]
			get
			{
				return sturdinessStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CD9")]
			[Cpp2IlInjected.Address(RVA = "0x960750", Offset = "0x95F150", VA = "0x180960750")]
			set
			{
				sturdinessStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000681")]
		[DebuggerNonUserCode]
		public Normality Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6001CDA")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "34")]
			get
			{
				return normality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CDB")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set
			{
				normality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000682")]
		[DebuggerNonUserCode]
		public int NormalityStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6001CDC")]
			[Cpp2IlInjected.Address(RVA = "0xDD7040", Offset = "0xDD5A40", VA = "0x180DD7040", Slot = "35")]
			get
			{
				return normalityStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CDD")]
			[Cpp2IlInjected.Address(RVA = "0xDD7100", Offset = "0xDD5B00", VA = "0x180DD7100")]
			set
			{
				normalityStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000683")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001CDE")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CDF")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000684")]
		[DebuggerNonUserCode]
		public int DreamDustOverrideValue
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE0")]
			[Cpp2IlInjected.Address(RVA = "0xAE8600", Offset = "0xAE7000", VA = "0x180AE8600", Slot = "46")]
			get
			{
				return dreamDustOverrideValue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CE1")]
			[Cpp2IlInjected.Address(RVA = "0x1525600", Offset = "0x1524000", VA = "0x181525600")]
			set
			{
				dreamDustOverrideValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000685")]
		[DebuggerNonUserCode]
		public CatalogVisibilityConditions CatalogVisibilityConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE2")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80", Slot = "47")]
			get
			{
				return catalogVisibilityConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CE3")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000686")]
		[DebuggerNonUserCode]
		public PriceOverride PriceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE4")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80", Slot = "48")]
			get
			{
				return priceOverride_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CE5")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			set
			{
				priceOverride_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000687")]
		[DebuggerNonUserCode]
		public bool CanAddDecals
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE6")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEA0", Offset = "0x7D98A0", VA = "0x1807DAEA0", Slot = "49")]
			get
			{
				return canAddDecals_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CE7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB470", Offset = "0x7D9E70", VA = "0x1807DB470")]
			set
			{
				canAddDecals_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000688")]
		[DebuggerNonUserCode]
		public bool CanChangeColor
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE8")]
			[Cpp2IlInjected.Address(RVA = "0x344BAE0", Offset = "0x344A4E0", VA = "0x18344BAE0", Slot = "50")]
			get
			{
				return canChangeColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CE9")]
			[Cpp2IlInjected.Address(RVA = "0x344C180", Offset = "0x344AB80", VA = "0x18344C180")]
			set
			{
				canChangeColor_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000689")]
		[DebuggerNonUserCode]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x6001CEA")]
			[Cpp2IlInjected.Address(RVA = "0x344BDC0", Offset = "0x344A7C0", VA = "0x18344BDC0", Slot = "51")]
			get
			{
				return isHidden_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CEB")]
			[Cpp2IlInjected.Address(RVA = "0x344C3B0", Offset = "0x344ADB0", VA = "0x18344C3B0")]
			set
			{
				isHidden_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068A")]
		[DebuggerNonUserCode]
		public GridEditRestriction GridEditRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6001CEC")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0", Slot = "53")]
			get
			{
				return gridEditRestriction_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CED")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			set
			{
				gridEditRestriction_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068B")]
		[DebuggerNonUserCode]
		public SubGridInteraction SubGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6001CEE")]
			[Cpp2IlInjected.Address(RVA = "0x344BF50", Offset = "0x344A950", VA = "0x18344BF50", Slot = "54")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.SubGrid)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CEF")]
			[Cpp2IlInjected.Address(RVA = "0x344C560", Offset = "0x344AF60", VA = "0x18344C560", Slot = "55")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068C")]
		[DebuggerNonUserCode]
		public Empty HomeStorage
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF0")]
			[Cpp2IlInjected.Address(RVA = "0x344BCE0", Offset = "0x344A6E0", VA = "0x18344BCE0")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.HomeStorage)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CF1")]
			[Cpp2IlInjected.Address(RVA = "0x344C2C0", Offset = "0x344ACC0", VA = "0x18344C2C0")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068D")]
		[DebuggerNonUserCode]
		public ContainerInteraction Container
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF2")]
			[Cpp2IlInjected.Address(RVA = "0x344BAF0", Offset = "0x344A4F0", VA = "0x18344BAF0")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.Container)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CF3")]
			[Cpp2IlInjected.Address(RVA = "0x344C190", Offset = "0x344AB90", VA = "0x18344C190")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068E")]
		[DebuggerNonUserCode]
		public CookingStationInteraction CookingStation
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF4")]
			[Cpp2IlInjected.Address(RVA = "0x344BB50", Offset = "0x344A550", VA = "0x18344BB50")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.CookingStation)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CF5")]
			[Cpp2IlInjected.Address(RVA = "0x344C1D0", Offset = "0x344ABD0", VA = "0x18344C1D0")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068F")]
		[DebuggerNonUserCode]
		public Empty Radio
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF6")]
			[Cpp2IlInjected.Address(RVA = "0x344BEF0", Offset = "0x344A8F0", VA = "0x18344BEF0")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.Radio)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CF7")]
			[Cpp2IlInjected.Address(RVA = "0x344C520", Offset = "0x344AF20", VA = "0x18344C520")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000690")]
		[DebuggerNonUserCode]
		public KeyholeInteraction Keyhole
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF8")]
			[Cpp2IlInjected.Address(RVA = "0x344BDD0", Offset = "0x344A7D0", VA = "0x18344BDD0")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.Keyhole)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CF9")]
			[Cpp2IlInjected.Address(RVA = "0x344C3C0", Offset = "0x344ADC0", VA = "0x18344C3C0")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000691")]
		[DebuggerNonUserCode]
		public Empty CraftingStation
		{
			[Cpp2IlInjected.Token(Token = "0x6001CFA")]
			[Cpp2IlInjected.Address(RVA = "0x344BBB0", Offset = "0x344A5B0", VA = "0x18344BBB0")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.CraftingStation)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CFB")]
			[Cpp2IlInjected.Address(RVA = "0x344C210", Offset = "0x344AC10", VA = "0x18344C210")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000692")]
		[DebuggerNonUserCode]
		public ToggleInteraction Toggle
		{
			[Cpp2IlInjected.Token(Token = "0x6001CFC")]
			[Cpp2IlInjected.Address(RVA = "0x344BFB0", Offset = "0x344A9B0", VA = "0x18344BFB0")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.Toggle)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CFD")]
			[Cpp2IlInjected.Address(RVA = "0x344C5A0", Offset = "0x344AFA0", VA = "0x18344C5A0")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000693")]
		[DebuggerNonUserCode]
		public PictureFrameInteraction PictureFrame
		{
			[Cpp2IlInjected.Token(Token = "0x6001CFE")]
			[Cpp2IlInjected.Address(RVA = "0x344BE90", Offset = "0x344A890", VA = "0x18344BE90")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.PictureFrame)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CFF")]
			[Cpp2IlInjected.Address(RVA = "0x344C470", Offset = "0x344AE70", VA = "0x18344C470")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000694")]
		[DebuggerNonUserCode]
		public IndexInteraction Index
		{
			[Cpp2IlInjected.Token(Token = "0x6001D00")]
			[Cpp2IlInjected.Address(RVA = "0x344BD40", Offset = "0x344A740", VA = "0x18344BD40")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.Index)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001D01")]
			[Cpp2IlInjected.Address(RVA = "0x344C370", Offset = "0x344AD70", VA = "0x18344C370")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000695")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6001D02")]
			[Cpp2IlInjected.Address(RVA = "0x1603120", Offset = "0x1601B20", VA = "0x181603120", Slot = "41")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D03")]
			[Cpp2IlInjected.Address(RVA = "0x1552740", Offset = "0x1551140", VA = "0x181552740", Slot = "42")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000696")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001D04")]
			[Cpp2IlInjected.Address(RVA = "0x2287B30", Offset = "0x2286530", VA = "0x182287B30", Slot = "39")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D05")]
			[Cpp2IlInjected.Address(RVA = "0x2287B80", Offset = "0x2286580", VA = "0x182287B80", Slot = "40")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000697")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001D06")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7C0", Offset = "0xF391C0", VA = "0x180F3A7C0", Slot = "23")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D07")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7D0", Offset = "0xF391D0", VA = "0x180F3A7D0", Slot = "24")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000698")]
		[DebuggerNonUserCode]
		public InteractionsOneofCase InteractionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001D08")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACB0", Offset = "0xA596B0", VA = "0x180A5ACB0")]
			get
			{
				return interactionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000699")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001D17")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "56")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069A")]
		public Item SetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001D18")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40", Slot = "43")]
			get
			{
				int num = setItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069B")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001D19")]
			[Cpp2IlInjected.Address(RVA = "0x344C010", Offset = "0x344AA10", VA = "0x18344C010", Slot = "26")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069C")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001D1A")]
			[Cpp2IlInjected.Address(RVA = "0x34468E0", Offset = "0x34452E0", VA = "0x1834468E0", Slot = "38")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069D")]
		public bool IsCustomizable
		{
			[Cpp2IlInjected.Token(Token = "0x6001D1B")]
			[Cpp2IlInjected.Address(RVA = "0x344BDA0", Offset = "0x344A7A0", VA = "0x18344BDA0")]
			get
			{
				if (!canAddDecals_)
				{
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069E")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001D1C")]
			[Cpp2IlInjected.Address(RVA = "0x344BA50", Offset = "0x344A450", VA = "0x18344BA50", Slot = "57")]
			get
			{
				if (!isHidden_ && !name_.Contains("Request!"))
				{
					return !name_.Contains("Mission!");
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB9")]
		[Cpp2IlInjected.Address(RVA = "0x344B890", Offset = "0x344A290", VA = "0x18344B890")]
		[DebuggerNonUserCode]
		public FurnitureItemData()
		{
			//IL_0062: Expected I4, but got I8
			//IL_006b: Expected I4, but got I8
			//IL_0074: Expected I4, but got I8
			//IL_007d: Expected I4, but got I8
			//IL_0086: Expected I4, but got I8
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
			rarity_ = 1;
			complexityStrength_ = 1;
			moodStrength_ = 1;
			sturdinessStrength_ = 1;
			normalityStrength_ = 1;
			PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBA")]
		[Cpp2IlInjected.Address(RVA = "0x34493E0", Offset = "0x3447DE0", VA = "0x1834493E0")]
		private void OnConstruction()
		{
			//IL_0023: Expected I4, but got I8
			//IL_002c: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			//IL_003e: Expected I4, but got I8
			//IL_0047: Expected I4, but got I8
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
			rarity_ = 1;
			complexityStrength_ = 1;
			moodStrength_ = 1;
			sturdinessStrength_ = 1;
			normalityStrength_ = 1;
			PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBB")]
		[Cpp2IlInjected.Address(RVA = "0x344B1F0", Offset = "0x3449BF0", VA = "0x18344B1F0")]
		[DebuggerNonUserCode]
		public FurnitureItemData(FurnitureItemData other)
		{
			//IL_0062: Expected I4, but got I8
			//IL_006b: Expected I4, but got I8
			//IL_0074: Expected I4, but got I8
			//IL_007d: Expected I4, but got I8
			//IL_0086: Expected I4, but got I8
			//IL_009e: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			//IL_01ff: Expected O, but got I4
			//IL_021d: Expected O, but got I4
			//IL_0382: Expected I4, but got O
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
			rarity_ = 1;
			complexityStrength_ = 1;
			moodStrength_ = 1;
			sturdinessStrength_ = 1;
			normalityStrength_ = 1;
			PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
			int num = 0;
			gridEditRestriction_ = (GridEditRestriction)num;
			int num2 = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData2 = other.gridAreaData_;
			if (gridAreaData2 != null)
			{
				GridAreaData gridAreaData3 = gridAreaData2.Clone();
			}
			gridAreaData_ = (GridAreaData)num;
			int num3 = (rarity_ = other.rarity_);
			int num4 = (setItemID_ = other.setItemID_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			Complexity complexity = (complexity_ = other.complexity_);
			int num5 = (complexityStrength_ = other.complexityStrength_);
			Mood mood = (mood_ = other.mood_);
			int num6 = (moodStrength_ = other.moodStrength_);
			Sturdiness sturdiness = (sturdiness_ = other.sturdiness_);
			int num7 = (sturdinessStrength_ = other.sturdinessStrength_);
			Normality normality = (normality_ = other.normality_);
			int num8 = (normalityStrength_ = other.normalityStrength_);
			int num9 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			int num10 = (dreamDustOverrideValue_ = other.dreamDustOverrideValue_);
			CatalogVisibilityConditions catalogVisibilityConditions2 = other.catalogVisibilityConditions_;
			if (catalogVisibilityConditions2 != null)
			{
				CatalogVisibilityConditions catalogVisibilityConditions3 = catalogVisibilityConditions2.Clone();
			}
			catalogVisibilityConditions_ = (CatalogVisibilityConditions)num;
			PriceOverride priceOverride2 = other.priceOverride_;
			if (priceOverride2 != null)
			{
				PriceOverride priceOverride3 = priceOverride2.Clone();
			}
			priceOverride_ = (PriceOverride)num;
			bool flag = (canAddDecals_ = other.canAddDecals_);
			bool flag2 = (canChangeColor_ = other.canChangeColor_);
			bool flag3 = (isHidden_ = other.isHidden_);
			GridEditRestriction gridEditRestriction = other.gridEditRestriction_;
			GridEditRestriction gridEditRestriction2 = default(GridEditRestriction);
			if (gridEditRestriction != null)
			{
				gridEditRestriction2 = gridEditRestriction.Clone();
			}
			gridEditRestriction_ = gridEditRestriction2;
			bool flag4 = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			bool flag5 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			uint num11 = (glotID_ = other.glotID_);
			if (other.interactionsCase_ <= (InteractionsOneofCase)9)
			{
				SubGridInteraction subGridInteraction = (SubGridInteraction)(interactions_ = other.SubGrid.Clone());
				Empty empty = (Empty)(interactions_ = other.HomeStorage.Clone());
				ContainerInteraction containerInteraction = (ContainerInteraction)(interactions_ = other.Container.Clone());
				CookingStationInteraction cookingStationInteraction = (CookingStationInteraction)(interactions_ = other.CookingStation.Clone());
				Empty empty2 = (Empty)(interactions_ = other.Radio.Clone());
				KeyholeInteraction keyholeInteraction = (KeyholeInteraction)(interactions_ = other.Keyhole.Clone());
				Empty empty3 = (Empty)(interactions_ = other.CraftingStation.Clone());
				ToggleInteraction toggleInteraction = (ToggleInteraction)(interactions_ = other.Toggle.Clone());
				PictureFrameInteraction pictureFrameInteraction = (PictureFrameInteraction)(interactions_ = other.PictureFrame.Clone());
				interactionsCase_ = (InteractionsOneofCase)(interactions_ = other.Index.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBC")]
		[Cpp2IlInjected.Address(RVA = "0x3446150", Offset = "0x3444B50", VA = "0x183446150", Slot = "10")]
		[DebuggerNonUserCode]
		public FurnitureItemData Clone()
		{
			return new FurnitureItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D09")]
		[Cpp2IlInjected.Address(RVA = "0x34460C0", Offset = "0x3444AC0", VA = "0x1834460C0")]
		[DebuggerNonUserCode]
		public void ClearInteractions()
		{
			//IL_0010: Expected O, but got I4
			interactions_ = (interactionsCase_ = InteractionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D0A")]
		[Cpp2IlInjected.Address(RVA = "0x3446D90", Offset = "0x3445790", VA = "0x183446D90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((FurnitureItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D0B")]
		[Cpp2IlInjected.Address(RVA = "0x3446940", Offset = "0x3445340", VA = "0x183446940", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FurnitureItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
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
									GridAreaData objB = other.gridAreaData_;
									if (object.Equals(gridAreaData_, objB))
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
																					int num8 = other.defaultCurrencyItemID_;
																					if (defaultCurrencyItemID_ == num8)
																					{
																						int num9 = other.dreamDustOverrideValue_;
																						if (dreamDustOverrideValue_ == num9)
																						{
																							CatalogVisibilityConditions objB2 = other.catalogVisibilityConditions_;
																							if (object.Equals(catalogVisibilityConditions_, objB2))
																							{
																								PriceOverride objB3 = other.priceOverride_;
																								if (object.Equals(priceOverride_, objB3))
																								{
																									bool flag = other.canAddDecals_;
																									if (canAddDecals_ == flag)
																									{
																										bool flag2 = other.canChangeColor_;
																										if (canChangeColor_ == flag2)
																										{
																											bool flag3 = other.isHidden_;
																											if (isHidden_ == flag3)
																											{
																												GridEditRestriction objB4 = other.gridEditRestriction_;
																												if (object.Equals(gridEditRestriction_, objB4))
																												{
																													SubGridInteraction subGrid = SubGrid;
																													SubGridInteraction subGrid2 = other.SubGrid;
																													if (object.Equals(subGrid, subGrid2))
																													{
																														Empty homeStorage = HomeStorage;
																														Empty homeStorage2 = other.HomeStorage;
																														if (object.Equals(homeStorage, homeStorage2))
																														{
																															ContainerInteraction container = Container;
																															ContainerInteraction container2 = other.Container;
																															if (object.Equals(container, container2))
																															{
																																CookingStationInteraction cookingStation = CookingStation;
																																CookingStationInteraction cookingStation2 = other.CookingStation;
																																if (object.Equals(cookingStation, cookingStation2))
																																{
																																	Empty radio = Radio;
																																	Empty radio2 = other.Radio;
																																	if (object.Equals(radio, radio2))
																																	{
																																		KeyholeInteraction keyhole = Keyhole;
																																		KeyholeInteraction keyhole2 = other.Keyhole;
																																		if (object.Equals(keyhole, keyhole2))
																																		{
																																			Empty craftingStation = CraftingStation;
																																			Empty craftingStation2 = other.CraftingStation;
																																			if (object.Equals(craftingStation, craftingStation2))
																																			{
																																				ToggleInteraction toggle = Toggle;
																																				ToggleInteraction toggle2 = other.Toggle;
																																				if (object.Equals(toggle, toggle2))
																																				{
																																					PictureFrameInteraction pictureFrame = PictureFrame;
																																					PictureFrameInteraction pictureFrame2 = other.PictureFrame;
																																					if (object.Equals(pictureFrame, pictureFrame2))
																																					{
																																						IndexInteraction index = Index;
																																						IndexInteraction index2 = other.Index;
																																						if (object.Equals(index, index2))
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
																																										InteractionsOneofCase interactionsOneofCase = other.interactionsCase_;
																																										if (interactionsCase_ == interactionsOneofCase)
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
			int num11 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D0C")]
		[Cpp2IlInjected.Address(RVA = "0x3447430", Offset = "0x3445E30", VA = "0x183447430", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_030e
			while (true)
			{
				int num = iD_;
				int num2 = 0;
				if (num != 0)
				{
				}
				string text = name_;
				if (text.m_stringLength != num2)
				{
					int hashCode = text.GetHashCode();
				}
				string text2 = displayName_;
				if (text2.m_stringLength != num2)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = iconAddress_;
				if (text3.m_stringLength != num2)
				{
					int hashCode3 = text3.GetHashCode();
				}
				string text4 = prefabAddress_;
				if (text4.m_stringLength != num2)
				{
					int hashCode4 = text4.GetHashCode();
				}
				GridAreaData gridAreaData = gridAreaData_;
				if (gridAreaData != null)
				{
					int hashCode5 = gridAreaData.GetHashCode();
				}
				if (rarity_ != 0)
				{
				}
				if (setItemID_ != 0)
				{
				}
				int hashCode6 = ((RepeatedField<T>)(object)tags_).GetHashCode();
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
				if (defaultCurrencyItemID_ != 0)
				{
				}
				if (dreamDustOverrideValue_ != 0)
				{
				}
				CatalogVisibilityConditions catalogVisibilityConditions = catalogVisibilityConditions_;
				if (catalogVisibilityConditions != null)
				{
					int hashCode7 = catalogVisibilityConditions.GetHashCode();
				}
				PriceOverride priceOverride = priceOverride_;
				if (priceOverride != null)
				{
					int hashCode8 = priceOverride.GetHashCode();
				}
				if (canAddDecals_)
				{
				}
				if (canChangeColor_)
				{
				}
				if (isHidden_)
				{
				}
				GridEditRestriction gridEditRestriction = gridEditRestriction_;
				if (gridEditRestriction != null)
				{
					int hashCode9 = gridEditRestriction.GetHashCode();
				}
				if (interactionsCase_ != InteractionsOneofCase.SubGrid)
				{
					continue;
				}
				object obj = interactions_;
				if (obj != null)
				{
					int hashCode10 = obj.GetHashCode();
					if (interactionsCase_ != InteractionsOneofCase.HomeStorage)
					{
						continue;
					}
					object obj2 = interactions_;
					if (obj2 != null)
					{
						int hashCode11 = obj2.GetHashCode();
						if (interactionsCase_ != InteractionsOneofCase.Container)
						{
							continue;
						}
						object obj3 = interactions_;
						if (obj3 != null)
						{
							int hashCode12 = obj3.GetHashCode();
							if (interactionsCase_ != InteractionsOneofCase.CookingStation)
							{
								continue;
							}
							object obj4 = interactions_;
							if (obj4 != null)
							{
								int hashCode13 = obj4.GetHashCode();
								if (interactionsCase_ != InteractionsOneofCase.Radio)
								{
									continue;
								}
								object obj5 = interactions_;
								if (obj5 != null)
								{
									int hashCode14 = obj5.GetHashCode();
									if (interactionsCase_ != InteractionsOneofCase.Keyhole)
									{
										continue;
									}
									object obj6 = interactions_;
									if (obj6 != null)
									{
										int hashCode15 = obj6.GetHashCode();
										if (interactionsCase_ != InteractionsOneofCase.CraftingStation)
										{
											continue;
										}
										object obj7 = interactions_;
										if (obj7 != null)
										{
											int hashCode16 = obj7.GetHashCode();
											if (interactionsCase_ != InteractionsOneofCase.Toggle)
											{
												continue;
											}
											object obj8 = interactions_;
											if (obj8 != null)
											{
												int hashCode17 = obj8.GetHashCode();
												if (interactionsCase_ != InteractionsOneofCase.PictureFrame)
												{
													continue;
												}
												object obj9 = interactions_;
												if (obj9 != null)
												{
													int hashCode18 = obj9.GetHashCode();
													if (interactionsCase_ == InteractionsOneofCase.Index)
													{
														object obj10 = interactions_;
														if (obj10 == null)
														{
															break;
														}
														int hashCode19 = obj10.GetHashCode();
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
														int hashCode20 = unknownFields.GetHashCode();
													}
													return 1;
												}
											}
											throw new InvalidCastException();
										}
										throw new InvalidCastException();
									}
									throw new InvalidCastException();
								}
								throw new InvalidCastException();
							}
							throw new InvalidCastException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D0D")]
		[Cpp2IlInjected.Address(RVA = "0x344A3D0", Offset = "0x3448DD0", VA = "0x18344A3D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D0E")]
		[Cpp2IlInjected.Address(RVA = "0x344A430", Offset = "0x3448E30", VA = "0x18344A430", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0463
			while (true)
			{
				if (iD_ != 0)
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
				if ((long)gridAreaData_ != 0)
				{
					GridAreaData value6 = gridAreaData_;
					output.WriteMessage(value6);
				}
				if (rarity_ != 0)
				{
					int value7 = rarity_;
					output.WriteInt32(value7);
				}
				if (setItemID_ != 0)
				{
					int value8 = setItemID_;
					output.WriteInt32(value8);
				}
				RepeatedField<int> repeatedField = tags_;
				FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
				if (complexity_ != 0)
				{
				}
				if (complexityStrength_ != 0)
				{
					int value9 = complexityStrength_;
					output.WriteInt32(value9);
				}
				if (mood_ != 0)
				{
				}
				if (moodStrength_ != 0)
				{
					int value10 = moodStrength_;
					output.WriteInt32(value10);
				}
				if (sturdiness_ != 0)
				{
				}
				if (sturdinessStrength_ != 0)
				{
					int value11 = sturdinessStrength_;
					output.WriteInt32(value11);
				}
				if (normality_ != 0)
				{
				}
				if (normalityStrength_ != 0)
				{
					int value12 = normalityStrength_;
					output.WriteInt32(value12);
				}
				if (defaultCurrencyItemID_ != 0)
				{
					int value13 = defaultCurrencyItemID_;
					output.WriteInt32(value13);
				}
				if (dreamDustOverrideValue_ != 0)
				{
					int value14 = dreamDustOverrideValue_;
					output.WriteInt32(value14);
				}
				if ((long)catalogVisibilityConditions_ != 0)
				{
					CatalogVisibilityConditions value15 = catalogVisibilityConditions_;
					output.WriteMessage(value15);
				}
				if ((long)priceOverride_ != 0)
				{
					PriceOverride value16 = priceOverride_;
					output.WriteMessage(value16);
				}
				if (canAddDecals_)
				{
					bool value17 = canAddDecals_;
					output.WriteBool(value17);
				}
				if (canChangeColor_)
				{
					bool value18 = canChangeColor_;
					output.WriteBool(value18);
				}
				if (isHidden_)
				{
					bool value19 = isHidden_;
					output.WriteBool(value19);
				}
				if ((long)gridEditRestriction_ != 0)
				{
					GridEditRestriction value20 = gridEditRestriction_;
					output.WriteMessage(value20);
				}
				InteractionsOneofCase interactionsOneofCase = interactionsCase_;
				int num = 0;
				if (interactionsOneofCase != InteractionsOneofCase.SubGrid)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.SubGrid)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (interactionsCase_ != InteractionsOneofCase.HomeStorage)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.HomeStorage)
				{
					object obj2 = interactions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (interactionsCase_ != InteractionsOneofCase.Container)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.Container)
				{
					object obj3 = interactions_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (interactionsCase_ != InteractionsOneofCase.CookingStation)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.CookingStation)
				{
					object obj4 = interactions_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (interactionsCase_ != InteractionsOneofCase.Radio)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.Radio)
				{
					object obj5 = interactions_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (interactionsCase_ != InteractionsOneofCase.Keyhole)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.Keyhole)
				{
					object obj6 = interactions_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (interactionsCase_ != InteractionsOneofCase.CraftingStation)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.CraftingStation)
				{
					object obj7 = interactions_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (interactionsCase_ != InteractionsOneofCase.Toggle)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.Toggle)
				{
					object obj8 = interactions_;
					if (obj8 != null && obj8 == null)
					{
						break;
					}
				}
				if (interactionsCase_ != InteractionsOneofCase.PictureFrame)
				{
					continue;
				}
				if (interactionsCase_ == InteractionsOneofCase.PictureFrame)
				{
					object obj9 = interactions_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (interactionsCase_ == InteractionsOneofCase.Index && interactionsCase_ == InteractionsOneofCase.Index)
				{
					object obj10 = interactions_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
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
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D0F")]
		[Cpp2IlInjected.Address(RVA = "0x3445250", Offset = "0x3443C50", VA = "0x183445250", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_050b
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(gridAreaData);
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
			int num26 = defaultCurrencyItemID_;
			if (num26 != 0)
			{
				int num27 = CodedOutputStream.ComputeInt32Size(num26);
				num27 += 2;
				num2 += num27;
			}
			int num28 = dreamDustOverrideValue_;
			if (num28 != 0)
			{
				int num29 = CodedOutputStream.ComputeInt32Size(num28);
				num29 += 2;
				num2 += num29;
			}
			CatalogVisibilityConditions catalogVisibilityConditions = catalogVisibilityConditions_;
			if (catalogVisibilityConditions != null)
			{
				int num30 = CodedOutputStream.ComputeMessageSize(catalogVisibilityConditions);
				num30 += 2;
				num2 += num30;
			}
			PriceOverride priceOverride = priceOverride_;
			if (priceOverride != null)
			{
				int num31 = CodedOutputStream.ComputeMessageSize(priceOverride);
				num31 += 2;
				num2 += num31;
			}
			GridEditRestriction gridEditRestriction = gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				int num32 = CodedOutputStream.ComputeMessageSize(gridEditRestriction);
				num32 += 2;
				num2 += num32;
			}
			if (interactionsCase_ == InteractionsOneofCase.SubGrid)
			{
				if (interactionsCase_ != InteractionsOneofCase.SubGrid)
				{
				}
				object obj = interactions_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num33 = default(int);
				num2 += num33;
			}
			if (interactionsCase_ == InteractionsOneofCase.HomeStorage)
			{
				if (interactionsCase_ != InteractionsOneofCase.HomeStorage)
				{
				}
				object obj2 = interactions_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num34 = default(int);
				num2 += num34;
			}
			if (interactionsCase_ == InteractionsOneofCase.Container)
			{
				if (interactionsCase_ != InteractionsOneofCase.Container)
				{
				}
				object obj3 = interactions_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num35 = default(int);
				num2 += num35;
			}
			if (interactionsCase_ == InteractionsOneofCase.CookingStation)
			{
				if (interactionsCase_ != InteractionsOneofCase.CookingStation)
				{
				}
				object obj4 = interactions_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num36 = default(int);
				num2 += num36;
			}
			if (interactionsCase_ == InteractionsOneofCase.Radio)
			{
				if (interactionsCase_ != InteractionsOneofCase.Radio)
				{
				}
				object obj5 = interactions_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num37 = default(int);
				num2 += num37;
			}
			if (interactionsCase_ == InteractionsOneofCase.Keyhole)
			{
				if (interactionsCase_ != InteractionsOneofCase.Keyhole)
				{
				}
				object obj6 = interactions_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num38 = default(int);
				num2 += num38;
			}
			if (interactionsCase_ == InteractionsOneofCase.CraftingStation)
			{
				if (interactionsCase_ != InteractionsOneofCase.CraftingStation)
				{
				}
				object obj7 = interactions_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num39 = default(int);
				num2 += num39;
			}
			if (interactionsCase_ == InteractionsOneofCase.Toggle)
			{
				if (interactionsCase_ != InteractionsOneofCase.Toggle)
				{
				}
				object obj8 = interactions_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num40 = default(int);
				num2 += num40;
			}
			if (interactionsCase_ == InteractionsOneofCase.PictureFrame)
			{
				if (interactionsCase_ != InteractionsOneofCase.PictureFrame)
				{
				}
				object obj9 = interactions_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num41 = default(int);
				num2 += num41;
			}
			if (interactionsCase_ == InteractionsOneofCase.Index)
			{
				if (interactionsCase_ == InteractionsOneofCase.Index)
				{
					object obj10 = interactions_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2 += 2;
				int num42 = default(int);
				num2 += num42;
			}
			uint num43 = glotID_;
			if (num43 != 0)
			{
				int num44 = CodedOutputStream.ComputeUInt32Size(num43);
				num44 += 2;
				num2 += num44;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num45 = unknownFields.CalculateSize();
				num2 += num45;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D10")]
		[Cpp2IlInjected.Address(RVA = "0x3448AF0", Offset = "0x34474F0", VA = "0x183448AF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FurnitureItemData other)
		{
			//Discarded unreachable code: IL_0551
			//IL_0329: Expected I4, but got O
			//IL_0362: Expected I4, but got O
			//IL_039b: Expected I4, but got O
			//IL_03d4: Expected I4, but got O
			//IL_040d: Expected I4, but got O
			//IL_043d: Expected I4, but got O
			//IL_0476: Expected I4, but got O
			//IL_04a6: Expected I4, but got O
			//IL_04df: Expected I4, but got O
			//IL_0518: Expected I4, but got O
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
			if ((long)other.gridAreaData_ != 0)
			{
				GridAreaData gridAreaData2 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
					gridAreaData2 = gridAreaData_;
				}
				GridAreaData other2 = other.gridAreaData_;
				gridAreaData2.MergeFrom(other2);
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
				CatalogVisibilityConditions other3 = other.catalogVisibilityConditions_;
				catalogVisibilityConditions2.MergeFrom(other3);
			}
			if ((long)other.priceOverride_ != 0)
			{
				PriceOverride priceOverride2 = default(PriceOverride);
				if (priceOverride_ == null)
				{
					PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
					priceOverride2 = priceOverride_;
				}
				PriceOverride other4 = other.priceOverride_;
				priceOverride2.MergeFrom(other4);
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
			bool flag3 = other.isHidden_;
			if (flag3)
			{
				isHidden_ = flag3;
			}
			if ((long)other.gridEditRestriction_ != 0)
			{
				GridEditRestriction gridEditRestriction2 = default(GridEditRestriction);
				if (gridEditRestriction_ == null)
				{
					GridEditRestriction gridEditRestriction = (gridEditRestriction_ = new GridEditRestriction());
					gridEditRestriction2 = gridEditRestriction_;
				}
				GridEditRestriction other5 = other.gridEditRestriction_;
				gridEditRestriction2.MergeFrom(other5);
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
			if (other.interactionsCase_ <= (InteractionsOneofCase)9)
			{
				if (SubGrid == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new SubGridInteraction());
				}
				SubGridInteraction subGrid = SubGrid;
				SubGridInteraction subGrid2 = other.SubGrid;
				subGrid.MergeFrom(subGrid2);
				if (HomeStorage == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new Empty());
				}
				Empty homeStorage = HomeStorage;
				Empty homeStorage2 = other.HomeStorage;
				homeStorage.MergeFrom(homeStorage2);
				if (Container == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new ContainerInteraction());
				}
				ContainerInteraction container = Container;
				ContainerInteraction container2 = other.Container;
				container.MergeFrom(container2);
				if (CookingStation == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new CookingStationInteraction());
				}
				CookingStationInteraction cookingStation = CookingStation;
				CookingStationInteraction cookingStation2 = other.CookingStation;
				cookingStation.MergeFrom(cookingStation2);
				if (Radio == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new Empty());
				}
				Empty radio = Radio;
				Empty radio2 = other.Radio;
				if (Keyhole == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new KeyholeInteraction());
				}
				KeyholeInteraction keyhole = Keyhole;
				KeyholeInteraction keyhole2 = other.Keyhole;
				keyhole.MergeFrom(keyhole2);
				if (CraftingStation == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new Empty());
				}
				Empty craftingStation = CraftingStation;
				Empty craftingStation2 = other.CraftingStation;
				if (Toggle == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new ToggleInteraction());
				}
				ToggleInteraction toggle = Toggle;
				ToggleInteraction toggle2 = other.Toggle;
				toggle.MergeFrom(toggle2);
				if (PictureFrame == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new PictureFrameInteraction());
				}
				PictureFrameInteraction pictureFrame = PictureFrame;
				PictureFrameInteraction pictureFrame2 = other.PictureFrame;
				pictureFrame.MergeFrom(pictureFrame2);
				if (Index == null)
				{
					interactionsCase_ = (InteractionsOneofCase)(interactions_ = new IndexInteraction());
				}
				IndexInteraction index = Index;
				IndexInteraction index2 = other.Index;
				index.MergeFrom(index2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001D11")]
		[Cpp2IlInjected.Address(RVA = "0x3447D00", Offset = "0x3446700", VA = "0x183447D00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00d3: Expected I4, but got O
			//IL_012f: Expected I4, but got O
			//IL_018f: Expected I4, but got O
			//IL_01e8: Expected I4, but got O
			//IL_0244: Expected I4, but got O
			//IL_029d: Expected I4, but got O
			//IL_02f9: Expected I4, but got O
			//IL_0365: Expected I4, but got O
			//IL_03be: Expected I4, but got O
			//IL_041a: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 144)
			{
				if ((int)num > 226)
				{
					if ((int)num > 266)
					{
						if ((int)num > 282)
						{
							if (num == 288)
							{
								bool flag = (isUnavailableForGenerator_ = input.ReadBool());
							}
							bool flag2 = default(bool);
							if (num == 296)
							{
								flag2 = (isSyncOnlineItem_ = input.ReadBool());
							}
							if (!flag2)
							{
								goto IL_072c;
							}
							int num2 = (int)(glotID_ = (uint)input.ReadInt32());
						}
						if (num == 274)
						{
							PictureFrameInteraction builder = new PictureFrameInteraction();
							if (interactionsCase_ == InteractionsOneofCase.PictureFrame)
							{
								if (interactionsCase_ != InteractionsOneofCase.PictureFrame)
								{
								}
								object obj = interactions_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder);
							interactions_ = builder;
							interactionsCase_ = (InteractionsOneofCase)typeof(PictureFrameInteraction).TypeHandle;
						}
						if ((long)typeof(PictureFrameInteraction).TypeHandle != 282)
						{
							goto IL_072c;
						}
						IndexInteraction builder2 = new IndexInteraction();
						if (interactionsCase_ == InteractionsOneofCase.Index)
						{
							if (interactionsCase_ != InteractionsOneofCase.Index)
							{
							}
							object obj2 = interactions_;
							if (obj2 != null && obj2 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder2);
						interactions_ = builder2;
						interactionsCase_ = (InteractionsOneofCase)typeof(IndexInteraction).TypeHandle;
					}
					if ((int)num > 242)
					{
						if (num == 250)
						{
							KeyholeInteraction builder3 = new KeyholeInteraction();
							if (interactionsCase_ == InteractionsOneofCase.Keyhole)
							{
								if (interactionsCase_ != InteractionsOneofCase.Keyhole)
								{
								}
								object obj3 = interactions_;
								if (obj3 != null && obj3 == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder3);
							interactions_ = builder3;
							interactionsCase_ = (InteractionsOneofCase)typeof(KeyholeInteraction).TypeHandle;
						}
						if ((long)typeof(KeyholeInteraction).TypeHandle == 258)
						{
							Empty builder4 = new Empty();
							if (interactionsCase_ == InteractionsOneofCase.CraftingStation)
							{
								if (interactionsCase_ != InteractionsOneofCase.CraftingStation)
								{
								}
								object obj4 = interactions_;
								if (obj4 != null && obj4 == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder4);
							interactions_ = builder4;
							interactionsCase_ = (InteractionsOneofCase)typeof(Empty).TypeHandle;
						}
						if ((long)typeof(Empty).TypeHandle != 266)
						{
							goto IL_072c;
						}
						ToggleInteraction builder5 = new ToggleInteraction();
						if (interactionsCase_ == InteractionsOneofCase.Toggle)
						{
							if (interactionsCase_ != InteractionsOneofCase.Toggle)
							{
							}
							object obj5 = interactions_;
							if (obj5 != null && obj5 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder5);
						interactions_ = builder5;
						interactionsCase_ = (InteractionsOneofCase)typeof(ToggleInteraction).TypeHandle;
					}
					if ((long)typeof(ToggleInteraction).TypeHandle == 234)
					{
						CookingStationInteraction builder6 = new CookingStationInteraction();
						if (interactionsCase_ == InteractionsOneofCase.CookingStation)
						{
							if (interactionsCase_ != InteractionsOneofCase.CookingStation)
							{
							}
							object obj6 = interactions_;
							if (obj6 != null && obj6 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder6);
						interactions_ = builder6;
						interactionsCase_ = (InteractionsOneofCase)typeof(CookingStationInteraction).TypeHandle;
					}
					if ((long)typeof(CookingStationInteraction).TypeHandle != 242)
					{
						goto IL_072c;
					}
					Empty builder7 = new Empty();
					if (interactionsCase_ == InteractionsOneofCase.Radio)
					{
						if (interactionsCase_ != InteractionsOneofCase.Radio)
						{
						}
						object obj7 = interactions_;
						if (obj7 != null && obj7 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder7);
					interactions_ = builder7;
					interactionsCase_ = (InteractionsOneofCase)typeof(Empty).TypeHandle;
				}
				GridEditRestriction gridEditRestriction = default(GridEditRestriction);
				if ((int)num > 184)
				{
					if ((int)num > 202)
					{
						if (num == 210)
						{
							SubGridInteraction builder8 = new SubGridInteraction();
							if (interactionsCase_ == InteractionsOneofCase.SubGrid)
							{
								if (interactionsCase_ != InteractionsOneofCase.SubGrid)
								{
								}
								object obj8 = interactions_;
								if (obj8 != null && obj8 == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder8);
							interactions_ = builder8;
							interactionsCase_ = (InteractionsOneofCase)typeof(SubGridInteraction).TypeHandle;
						}
						if ((long)typeof(SubGridInteraction).TypeHandle == 218)
						{
							Empty builder9 = new Empty();
							if (interactionsCase_ == InteractionsOneofCase.HomeStorage)
							{
								if (interactionsCase_ != InteractionsOneofCase.HomeStorage)
								{
								}
								object obj9 = interactions_;
								if (obj9 != null && obj9 == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder9);
							interactions_ = builder9;
							interactionsCase_ = (InteractionsOneofCase)typeof(Empty).TypeHandle;
						}
						if ((long)typeof(Empty).TypeHandle != 226)
						{
							goto IL_072c;
						}
						ContainerInteraction builder10 = new ContainerInteraction();
						if (interactionsCase_ == InteractionsOneofCase.Container)
						{
							if (interactionsCase_ != InteractionsOneofCase.Container)
							{
							}
							object obj10 = interactions_;
							if (obj10 != null && obj10 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder10);
						interactions_ = builder10;
						interactionsCase_ = (InteractionsOneofCase)typeof(ContainerInteraction).TypeHandle;
					}
					bool flag3 = default(bool);
					if ((long)typeof(ContainerInteraction).TypeHandle == 192)
					{
						flag3 = (isHidden_ = input.ReadBool());
					}
					if (!flag3)
					{
						goto IL_072c;
					}
					GridEditRestriction builder11 = default(GridEditRestriction);
					if (gridEditRestriction_ == null)
					{
						gridEditRestriction = (gridEditRestriction_ = new GridEditRestriction());
						builder11 = gridEditRestriction_;
					}
					input.ReadMessage(builder11);
				}
				bool flag5 = default(bool);
				if ((long)gridEditRestriction > 162)
				{
					PriceOverride priceOverride = default(PriceOverride);
					if ((long)gridEditRestriction == 170)
					{
						PriceOverride builder12 = default(PriceOverride);
						if (priceOverride_ == null)
						{
							priceOverride = (priceOverride_ = new PriceOverride());
							builder12 = priceOverride_;
						}
						input.ReadMessage(builder12);
					}
					bool flag4 = default(bool);
					if ((long)priceOverride == 176)
					{
						flag4 = (canAddDecals_ = input.ReadBool());
					}
					if (!flag4)
					{
						goto IL_072c;
					}
					flag5 = (canChangeColor_ = input.ReadBool());
				}
				int num3 = default(int);
				if (flag5)
				{
					num3 = (dreamDustOverrideValue_ = input.ReadInt32());
				}
				if (num3 != 162)
				{
					goto IL_072c;
				}
				CatalogVisibilityConditions builder13 = default(CatalogVisibilityConditions);
				if (catalogVisibilityConditions_ == null)
				{
					CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
					builder13 = catalogVisibilityConditions_;
				}
				input.ReadMessage(builder13);
			}
			int num12 = default(int);
			if ((int)num > 72)
			{
				int num8 = default(int);
				if ((int)num > 104)
				{
					int num6 = default(int);
					if ((int)num > 120)
					{
						int num4 = default(int);
						if (num == 128)
						{
							num4 = (int)(normality_ = (Normality)input.ReadInt32());
						}
						int num5 = default(int);
						if (num4 == 136)
						{
							num5 = (normalityStrength_ = input.ReadInt32());
						}
						if (num5 != 144)
						{
							goto IL_072c;
						}
						num6 = (defaultCurrencyItemID_ = input.ReadInt32());
					}
					int num7 = default(int);
					if (num6 == 112)
					{
						num7 = (int)(sturdiness_ = (Sturdiness)input.ReadInt32());
					}
					if (num7 != 120)
					{
						goto IL_072c;
					}
					num8 = (sturdinessStrength_ = input.ReadInt32());
				}
				int num11 = default(int);
				if (num8 > 80)
				{
					int num9 = default(int);
					if (num8 == 88)
					{
						num9 = (complexityStrength_ = input.ReadInt32());
					}
					int num10 = default(int);
					if (num9 == 96)
					{
						num10 = (int)(mood_ = (Mood)input.ReadInt32());
					}
					if (num10 != 104)
					{
						goto IL_072c;
					}
					num11 = (moodStrength_ = input.ReadInt32());
				}
				if (num11 == 74)
				{
					goto IL_0665;
				}
				if (num11 != 80)
				{
					goto IL_072c;
				}
				num12 = (int)(complexity_ = (Complexity)input.ReadInt32());
			}
			if (num12 <= 34)
			{
				goto IL_06c7;
			}
			if (num12 <= 50)
			{
				goto IL_067e;
			}
			int num13 = default(int);
			if (num12 == 56)
			{
				num13 = (rarity_ = input.ReadInt32());
			}
			int num14 = default(int);
			if (num13 == 64)
			{
				num14 = (setItemID_ = input.ReadInt32());
			}
			if (num14 == 72)
			{
				goto IL_0665;
			}
			goto IL_072c;
			IL_06c7:
			GridAreaData gridAreaData = default(GridAreaData);
			string text4 = default(string);
			if ((long)gridAreaData > 18)
			{
				string text2 = default(string);
				if ((long)gridAreaData == 26)
				{
					text2 = (DisplayName = input.ReadString());
				}
				if ((long)text2 != 34)
				{
					goto IL_072c;
				}
				text4 = (IconAddress = input.ReadString());
			}
			int num15 = default(int);
			if ((long)text4 == 8)
			{
				num15 = (iD_ = input.ReadInt32());
			}
			if (num15 == 18)
			{
				string text6 = (Name = input.ReadString());
			}
			goto IL_072c;
			IL_067e:
			string text8 = default(string);
			if (num14 == 42)
			{
				text8 = (PrefabAddress = input.ReadString());
			}
			if ((long)text8 == 50)
			{
				GridAreaData builder14 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder14 = gridAreaData_;
				}
				input.ReadMessage(builder14);
				goto IL_06c7;
			}
			goto IL_072c;
			IL_0665:
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_067e;
			IL_072c:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001D12")]
		[Cpp2IlInjected.Address(RVA = "0x3446DF0", Offset = "0x34457F0", VA = "0x183446DF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 36)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D13")]
		[Cpp2IlInjected.Address(RVA = "0x3449730", Offset = "0x3448130", VA = "0x183449730", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001f, IL_0020, IL_0024, IL_002b, IL_002c, IL_0030, IL_0037, IL_0038, IL_003c, IL_0043, IL_0044, IL_0048, IL_004f, IL_0050, IL_0051, IL_0052, IL_0053, IL_0054, IL_0055, IL_0056, IL_0057, IL_0058, IL_0059, IL_005a, IL_005b, IL_005c, IL_0060, IL_0064, IL_0068, IL_006c, IL_006d, IL_006e, IL_006f, IL_0073, IL_0077, IL_007b, IL_0082, IL_0083, IL_0087, IL_008e, IL_008f, IL_0093, IL_009a, IL_009b, IL_009f, IL_00a6, IL_00a7, IL_00ab, IL_00b2, IL_00b3, IL_00b7, IL_00be, IL_00bf, IL_00c3, IL_00ca, IL_00cb, IL_00cf, IL_00d6, IL_00d7, IL_00db, IL_00e2, IL_00e3, IL_00e7, IL_00ee, IL_00ef, IL_00f0, IL_0101, IL_0107, IL_010d, IL_0113, IL_0119, IL_011f
			//IL_0011: Expected I4, but got O
			//IL_0100: Expected I4, but got O
			if (fieldNumber - 1 <= 36)
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

		[Cpp2IlInjected.Token(Token = "0x6001D14")]
		[Cpp2IlInjected.Address(RVA = "0x3445D50", Offset = "0x3444750", VA = "0x183445D50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0014, IL_0020, IL_002c, IL_0038, IL_0044, IL_0057, IL_0061, IL_0075, IL_0081, IL_008d, IL_0099, IL_00a5, IL_00b1, IL_00bd, IL_00c9, IL_00d5, IL_00e1, IL_00ff, IL_0107, IL_010f, IL_012e, IL_0136, IL_0152
			//IL_004d: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			//IL_00f7: Expected O, but got I4
			//IL_011a: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			if (fieldNumber - 1 <= 36)
			{
				int num = (iD_ = 0);
			}
			else if (fieldNumber == 999)
			{
				int num2 = (int)(glotID_ = 0u);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D15")]
		[Cpp2IlInjected.Address(RVA = "0x3447C40", Offset = "0x3446640", VA = "0x183447C40", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Interactions"))
			{
				InteractionsOneofCase interactionsOneofCase = interactionsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D16")]
		[Cpp2IlInjected.Address(RVA = "0x34460E0", Offset = "0x3444AE0", VA = "0x1834460E0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Interactions"))
			{
				interactions_ = (interactionsCase_ = InteractionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1D")]
		[Cpp2IlInjected.Address(RVA = "0x3446150", Offset = "0x3444B50", VA = "0x183446150", Slot = "22")]
		IItemData IItemData.Clone()
		{
			FurnitureItemData furnitureItemData = new FurnitureItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1E")]
		[Cpp2IlInjected.Address(RVA = "0x3447270", Offset = "0x3445C70", VA = "0x183447270")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0018, IL_001a, IL_001d, IL_0020, IL_0023
			if (interactionsCase_ <= (InteractionsOneofCase)9)
			{
				return SubGrid.GetGridStateData(in worldProfile, context);
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1F")]
		[Cpp2IlInjected.Address(RVA = "0x34461B0", Offset = "0x3444BB0", VA = "0x1834461B0", Slot = "52")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_01aa
			//IL_0071: Expected O, but got I4
			int num = iD_;
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__226_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CurrencyCost x) => x.amount_ > 0);
				}
				bool flag2 = default(bool);
				if (!flag2)
				{
					context.AddError("Furniture item must have at least one price greater than 0. Make sure Price Formula is well defined, or use PriceOverride fields.");
				}
			}
			if (this.IsBuyable())
			{
				int acceptedFloorTypesFlag = gridAreaData_.AcceptedFloorTypesFlag;
				RepeatedField<int> repeatedField = tags_;
				num = acceptedFloorTypesFlag;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = default(Item);
				int itemID = item.ItemID;
				bool flag3 = ((RepeatedField<T>)(object)repeatedField).Contains((T)itemID);
				if (num != 0)
				{
				}
				context.AddError("Furniture item has its FloorType set to Wall on visual but it's missing the Wall tag on data in FurnitureFunction section.");
			}
			if (name_.StartsWith("Mission!") && !isHidden_)
			{
				context.AddError("Furniture item used by a mission should have its IsHidden flag set to true.");
			}
			int num2 = iD_;
			FurnitureItem furnitureItem = default(FurnitureItem);
			if (furnitureItem.FurnitureItemID != 3)
			{
				return;
			}
			GridEditRestriction gridEditRestriction = gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				GridEditRestriction.Types.Restriction canRotate_ = gridEditRestriction.canRotate_;
				if (canRotate_.restrictionCase_ == GridEditRestriction.Types.Restriction.RestrictionOneofCase.Value && !canRotate_.Value)
				{
					goto IL_00f8;
				}
			}
			context.AddInvalidMemberError("Doors cannot be rotated", "GridEditRestriction");
			goto IL_00f8;
			IL_0132:
			if (gridEditRestriction_ != null)
			{
			}
			uint num3 = default(uint);
			GridEditRestriction gridEditRestriction2 = default(GridEditRestriction);
			if (num3 != 0)
			{
				context.AddInvalidMemberError("Doors cannot be cleared", "GridEditRestriction");
				gridEditRestriction2 = gridEditRestriction_;
			}
			if (gridEditRestriction2 != null)
			{
				GridEditRestriction.Types.Restriction canSwitchGrid_ = gridEditRestriction2.canSwitchGrid_;
				if (canSwitchGrid_.restrictionCase_ == GridEditRestriction.Types.Restriction.RestrictionOneofCase.Value && !canSwitchGrid_.Value)
				{
					goto IL_018b;
				}
			}
			context.AddInvalidMemberError("Doors cannot switch grids", "GridEditRestriction");
			goto IL_018b;
			IL_00f8:
			GridEditRestriction gridEditRestriction3 = gridEditRestriction_;
			if (gridEditRestriction3 != null)
			{
				GridEditRestriction.Types.Restriction canBeRemoved_ = gridEditRestriction3.canBeRemoved_;
				if (canBeRemoved_.restrictionCase_ == GridEditRestriction.Types.Restriction.RestrictionOneofCase.Value && !canBeRemoved_.Value)
				{
					goto IL_0132;
				}
			}
			context.AddInvalidMemberError("Doors cannot be removed", "GridEditRestriction");
			goto IL_0132;
			IL_018b:
			if (gridAreaData_.sizeX_ != 1)
			{
				context.AddInvalidMemberError("GridAreaData.SizeX should be an even number so the door can be centered on the wall", "GridAreaData");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D20")]
		[Cpp2IlInjected.Address(RVA = "0x34494F0", Offset = "0x3447EF0", VA = "0x1834494F0", Slot = "58")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_00a4
			int num = iD_;
			FurnitureItem furnitureItem = default(FurnitureItem);
			if (furnitureItem.FurnitureItemID == 3)
			{
				GridEditRestriction gridEditRestriction = new GridEditRestriction();
				GridEditRestriction.Types.Restriction restriction = new GridEditRestriction.Types.Restriction();
				restriction.Value = true;
				gridEditRestriction.canMove_ = restriction;
				GridEditRestriction.Types.Restriction restriction2 = new GridEditRestriction.Types.Restriction();
				int num2 = ((restriction2.Value = false) ? 1 : 0);
				gridEditRestriction.canRotate_ = restriction2;
				GridEditRestriction.Types.Restriction restriction3 = new GridEditRestriction.Types.Restriction();
				int num3 = ((restriction3.Value = false) ? 1 : 0);
				gridEditRestriction.canBeRemoved_ = restriction3;
				gridEditRestriction.canBeCleared_ = false;
				GridEditRestriction.Types.Restriction restriction4 = new GridEditRestriction.Types.Restriction();
				restriction4.Value = true;
				gridEditRestriction.canBeSelected_ = restriction4;
				GridEditRestriction.Types.Restriction restriction5 = new GridEditRestriction.Types.Restriction();
				int num4 = ((restriction5.Value = false) ? 1 : 0);
				gridEditRestriction.canSwitchGrid_ = restriction5;
				gridEditRestriction_ = gridEditRestriction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D21")]
		[Cpp2IlInjected.Address(RVA = "0x344AF10", Offset = "0x3449910", VA = "0x18344AF10")]
		static FurnitureItemData()
		{
			//Discarded unreachable code: IL_0062
			//IL_0038: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			_parser = (MessageParser<FurnitureItemData>)(object)FieldCodec.ForInt32(74u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[4];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			int num2 = 0;
			((ValueTuple<, >[])(object)array)[2] = (ValueTuple<, >)num2;
			int num3 = 0;
			((ValueTuple<, >[])(object)array)[4] = (ValueTuple<, >)num3;
			int num4 = 0;
			((ValueTuple<, >[])(object)array)[5] = (ValueTuple<, >)num4;
			ReadOnlyCollection<(TagItemType, int?)> parser = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<FurnitureItemData>)(object)parser;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D22")]
		[Cpp2IlInjected.Address(RVA = "0x3446720", Offset = "0x3445120", VA = "0x183446720", Slot = "36")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0018, IL_001c, IL_001f, IL_0022, IL_0025
			if (interactionsCase_ <= (InteractionsOneofCase)9)
			{
				return SubGrid.GetGridStateData(in worldProfile, context);
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
