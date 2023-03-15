using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002A3")]
	public sealed class CropItemData : IMessage<CropItemData>, IMessage, IEquatable<CropItemData>, IDeepCloneable<CropItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IBackpackItem, ISellable, IGridPlaceableItemData, ICookingIngredient, IHasTags, IAvailableInStall, ICanBeEaten, IIsMissionItem, IHasExtraGiftFriendship, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4000ACA")]
		private static readonly MessageParser<CropItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000ACB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000ACC")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000ACD")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000ACE")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000ACF")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000AD0")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000AD1")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000AD2")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000AD3")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000AD4")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000AD5")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000AD6")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000AD7")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000AD8")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000AD9")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000ADA")]
		public const int CropTypeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000ADB")]
		private CropType cropType_;

		[Cpp2IlInjected.Token(Token = "0x4000ADC")]
		public const int CookingIngredientTypeFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000ADD")]
		private int cookingIngredientType_;

		[Cpp2IlInjected.Token(Token = "0x4000ADE")]
		public const int TierFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000ADF")]
		private int tier_;

		[Cpp2IlInjected.Token(Token = "0x4000AE0")]
		public const int AvailableInStallFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000AE1")]
		private bool availableInStall_;

		[Cpp2IlInjected.Token(Token = "0x4000AE2")]
		public const int ManaRecoveredFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000AE3")]
		private int manaRecovered_;

		[Cpp2IlInjected.Token(Token = "0x4000AE4")]
		public const int IsMissionItemFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000AE5")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4000AE6")]
		public const int UnsellableFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
		[Cpp2IlInjected.Token(Token = "0x4000AE7")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x4000AE8")]
		public const int ExtraGiftFriendshipFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000AE9")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4000AEA")]
		public const int TagsFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x4000AEB")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000AEC")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000AED")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000AEE")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000AEF")]
		internal static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x170005BB")]
		[DebuggerNonUserCode]
		public static MessageParser<CropItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001AB5")]
			[Cpp2IlInjected.Address(RVA = "0x2D41600", Offset = "0x2D40000", VA = "0x182D41600")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001AB6")]
			[Cpp2IlInjected.Address(RVA = "0x2D41530", Offset = "0x2D3FF30", VA = "0x182D41530")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001AB7")]
			[Cpp2IlInjected.Address(RVA = "0x2D416C0", Offset = "0x2D400C0", VA = "0x182D416C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BE")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001ABC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001ABD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BF")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001ABE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "29")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001ABF")]
			[Cpp2IlInjected.Address(RVA = "0x2D41920", Offset = "0x2D40320", VA = "0x182D41920")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C0")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001AC0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "24")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AC1")]
			[Cpp2IlInjected.Address(RVA = "0x2D41840", Offset = "0x2D40240", VA = "0x182D41840")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C1")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001AC2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AC3")]
			[Cpp2IlInjected.Address(RVA = "0x2D418B0", Offset = "0x2D402B0", VA = "0x182D418B0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C2")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001AC4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AC5")]
			[Cpp2IlInjected.Address(RVA = "0x2D41990", Offset = "0x2D40390", VA = "0x182D41990")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C3")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001AC6")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "27")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AC7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C4")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001AC8")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AC9")]
			[Cpp2IlInjected.Address(RVA = "0x2D417D0", Offset = "0x2D401D0", VA = "0x182D417D0")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C5")]
		[DebuggerNonUserCode]
		public CropType CropType
		{
			[Cpp2IlInjected.Token(Token = "0x6001ACA")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return cropType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001ACB")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				cropType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C6")]
		[DebuggerNonUserCode]
		public int CookingIngredientType
		{
			[Cpp2IlInjected.Token(Token = "0x6001ACC")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return cookingIngredientType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001ACD")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				cookingIngredientType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C7")]
		[DebuggerNonUserCode]
		public int Tier
		{
			[Cpp2IlInjected.Token(Token = "0x6001ACE")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return tier_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001ACF")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				tier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C8")]
		[DebuggerNonUserCode]
		public bool AvailableInStall
		{
			[Cpp2IlInjected.Token(Token = "0x6001AD0")]
			[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0", Slot = "34")]
			get
			{
				return availableInStall_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AD1")]
			[Cpp2IlInjected.Address(RVA = "0x9765E0", Offset = "0x974FE0", VA = "0x1809765E0")]
			set
			{
				availableInStall_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C9")]
		[DebuggerNonUserCode]
		public int ManaRecovered
		{
			[Cpp2IlInjected.Token(Token = "0x6001AD2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "35")]
			get
			{
				return manaRecovered_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AD3")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				manaRecovered_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CA")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001AD4")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0", Slot = "36")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AD5")]
			[Cpp2IlInjected.Address(RVA = "0xD2B640", Offset = "0xD2A040", VA = "0x180D2B640")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CB")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6001AD6")]
			[Cpp2IlInjected.Address(RVA = "0x24344D0", Offset = "0x2432ED0", VA = "0x1824344D0")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AD7")]
			[Cpp2IlInjected.Address(RVA = "0x24344E0", Offset = "0x2432EE0", VA = "0x1824344E0")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CC")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6001AD8")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70", Slot = "37")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AD9")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CD")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001ADA")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "33")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CE")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001ADB")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001ADC")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CF")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001AE8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "38")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D0")]
		public bool CanBeUsedAsIngredient
		{
			[Cpp2IlInjected.Token(Token = "0x6001AE9")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "31")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D1")]
		public Item CookingIngredientTypeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001AEA")]
			[Cpp2IlInjected.Address(RVA = "0x2D414D0", Offset = "0x2D3FED0", VA = "0x182D414D0", Slot = "30")]
			get
			{
				long num = Convert.ToInt64((uint)cookingIngredientType_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AEB")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				//IL_0007: Expected I4, but got O
				cookingIngredientType_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D2")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001AEC")]
			[Cpp2IlInjected.Address(RVA = "0x2D414B0", Offset = "0x2D3FEB0", VA = "0x182D414B0", Slot = "39")]
			get
			{
				return !isMissionItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D3")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001AED")]
			[Cpp2IlInjected.Address(RVA = "0x2D414C0", Offset = "0x2D3FEC0", VA = "0x182D414C0", Slot = "26")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D4")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001AEE")]
			[Cpp2IlInjected.Address(RVA = "0x2D41660", Offset = "0x2D40060", VA = "0x182D41660", Slot = "32")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB8")]
		[Cpp2IlInjected.Address(RVA = "0x2D41100", Offset = "0x2D3FB00", VA = "0x182D41100")]
		[DebuggerNonUserCode]
		public CropItemData()
		{
			//IL_0060: Expected I4, but got I8
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			tier_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB9")]
		[Cpp2IlInjected.Address(RVA = "0x2D40530", Offset = "0x2D3EF30", VA = "0x182D40530")]
		private void OnConstruction()
		{
			//IL_0016: Expected I4, but got I8
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			tier_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABA")]
		[Cpp2IlInjected.Address(RVA = "0x2D41230", Offset = "0x2D3FC30", VA = "0x182D41230")]
		[DebuggerNonUserCode]
		public CropItemData(CropItemData other)
		{
			//IL_0060: Expected I4, but got I8
			//IL_00cd: Expected O, but got I4
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			tier_ = 1;
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData2 = other.gridAreaData_;
			if (gridAreaData2 != null)
			{
				GridAreaData gridAreaData3 = gridAreaData2.Clone();
			}
			int num2 = 0;
			gridAreaData_ = (GridAreaData)num2;
			string text5 = (description_ = other.description_);
			CropType cropType = (cropType_ = other.cropType_);
			int num3 = (cookingIngredientType_ = other.cookingIngredientType_);
			int num4 = (tier_ = other.tier_);
			bool flag = (availableInStall_ = other.availableInStall_);
			int num5 = (manaRecovered_ = other.manaRecovered_);
			bool flag2 = (isMissionItem_ = other.isMissionItem_);
			bool flag3 = (unsellable_ = other.unsellable_);
			int num6 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			uint num7 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABB")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F7E0", Offset = "0x2D3E1E0", VA = "0x182D3F7E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CropItemData Clone()
		{
			return new CropItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001ADD")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F840", Offset = "0x2D3E240", VA = "0x182D3F840", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(CropItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && object.Equals(gridAreaData_, other))
								{
									string text5 = description_;
									bool flag5 = default(bool);
									if (!flag5 && cropType_ == (flag5 ? CropType.Vegetable : CropType.Fruit) && cookingIngredientType_ == (flag5 ? 1 : 0) && tier_ == (flag5 ? 1 : 0) && availableInStall_ == flag5 && manaRecovered_ == (flag5 ? 1 : 0) && isMissionItem_ == flag5 && unsellable_ == flag5 && extraGiftFriendship_ == (flag5 ? 1 : 0))
									{
										RepeatedField<int> repeatedField = tags_;
										bool flag6 = default(bool);
										if (flag6 && glotID_ == (flag6 ? 1u : 0u))
										{
											return object.Equals(_unknownFields, other);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ADE")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FA10", Offset = "0x2D3E410", VA = "0x182D3FA10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CropItemData other)
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
										string text5 = other.description_;
										if (!(description_ != text5))
										{
											CropType cropType = other.cropType_;
											if (cropType_ == cropType)
											{
												int num2 = other.cookingIngredientType_;
												if (cookingIngredientType_ == num2)
												{
													int num3 = other.tier_;
													if (tier_ == num3)
													{
														bool flag = other.availableInStall_;
														if (availableInStall_ == flag)
														{
															int num4 = other.manaRecovered_;
															if (manaRecovered_ == num4)
															{
																bool flag2 = other.isMissionItem_;
																if (isMissionItem_ == flag2)
																{
																	bool flag3 = other.unsellable_;
																	if (unsellable_ == flag3)
																	{
																		int num5 = other.extraGiftFriendship_;
																		if (extraGiftFriendship_ == num5)
																		{
																			RepeatedField<int> repeatedField = tags_;
																			RepeatedField<int> repeatedField2 = other.tags_;
																			if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																			{
																				uint num6 = other.glotID_;
																				if (glotID_ == num6)
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
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ADF")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FDD0", Offset = "0x2D3E7D0", VA = "0x182D3FDD0", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_0142
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
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int hashCode5 = gridAreaData.GetHashCode();
			}
			string text5 = description_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			if (cropType_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (cookingIngredientType_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (tier_ != 0)
			{
				Result resultCode3 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (availableInStall_)
			{
			}
			if (manaRecovered_ != 0)
			{
				Result resultCode4 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (isMissionItem_)
			{
			}
			if (unsellable_)
			{
			}
			if (extraGiftFriendship_ != 0)
			{
				Result resultCode5 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			int hashCode7 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE0")]
		[Cpp2IlInjected.Address(RVA = "0x2D40B10", Offset = "0x2D3F510", VA = "0x182D40B10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE1")]
		[Cpp2IlInjected.Address(RVA = "0x2D40B70", Offset = "0x2D3F570", VA = "0x182D40B70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01c3
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
			if (description_.m_stringLength != 0)
			{
				string value7 = description_;
				output.WriteString(value7);
			}
			if (cropType_ != 0)
			{
			}
			if (cookingIngredientType_ != 0)
			{
				int value8 = cookingIngredientType_;
				output.WriteInt32(value8);
			}
			if (tier_ != 0)
			{
				int value9 = tier_;
				output.WriteInt32(value9);
			}
			if (availableInStall_)
			{
				bool value10 = availableInStall_;
				output.WriteBool(value10);
			}
			if (manaRecovered_ != 0)
			{
				int value11 = manaRecovered_;
				output.WriteInt32(value11);
			}
			if (isMissionItem_)
			{
				bool value12 = isMissionItem_;
				output.WriteBool(value12);
			}
			if (extraGiftFriendship_ != 0)
			{
				int value13 = extraGiftFriendship_;
				output.WriteInt32(value13);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (unsellable_)
			{
				bool value14 = unsellable_;
				output.WriteBool(value14);
			}
			if (glotID_ != 0)
			{
				uint value15 = glotID_;
				output.WriteUInt32(value15);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F210", Offset = "0x2D3DC10", VA = "0x182D3F210", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01f3
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
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(gridAreaData);
				num8++;
				num2 += num8;
			}
			string text5 = description_;
			if (text5.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num2 += num9;
			}
			CropType cropType = cropType_;
			if (cropType != 0)
			{
				int num10 = CodedOutputStream.ComputeEnumSize((int)cropType);
				num10++;
				num2 += num10;
			}
			int num11 = cookingIngredientType_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			int num13 = tier_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			int num15 = manaRecovered_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num2 += num16;
			}
			int num17 = extraGiftFriendship_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18++;
				num2 += num18;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num19 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			uint num20 = glotID_;
			num2 += num19;
			if (num20 != 0)
			{
				int num21 = CodedOutputStream.ComputeUInt32Size(num20);
				num21 += 2;
				num2 += num21;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num22 = unknownFields.CalculateSize();
				num2 += num22;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE3")]
		[Cpp2IlInjected.Address(RVA = "0x2D40000", Offset = "0x2D3EA00", VA = "0x182D40000", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CropItemData other)
		{
			//Discarded unreachable code: IL_01c5
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
			string text5 = other.description_;
			if (text5.m_stringLength != 0)
			{
				Description = text5;
			}
			CropType cropType = other.cropType_;
			if (cropType != 0)
			{
				cropType_ = cropType;
			}
			int num2 = other.cookingIngredientType_;
			if (num2 != 0)
			{
				cookingIngredientType_ = num2;
			}
			int num3 = other.tier_;
			if (num3 != 0)
			{
				tier_ = num3;
			}
			bool flag = other.availableInStall_;
			if (flag)
			{
				availableInStall_ = flag;
			}
			int num4 = other.manaRecovered_;
			if (num4 != 0)
			{
				manaRecovered_ = num4;
			}
			bool flag2 = other.isMissionItem_;
			if (flag2)
			{
				isMissionItem_ = flag2;
			}
			bool flag3 = other.unsellable_;
			if (flag3)
			{
				unsellable_ = flag3;
			}
			int num5 = other.extraGiftFriendship_;
			if (num5 != 0)
			{
				extraGiftFriendship_ = num5;
			}
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			uint num6 = other.glotID_;
			if (num6 != 0)
			{
				glotID_ = num6;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE4")]
		[Cpp2IlInjected.Address(RVA = "0x2D401F0", Offset = "0x2D3EBF0", VA = "0x182D401F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_020e
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 72)
			{
				goto IL_00f3;
			}
			if ((int)num <= 104)
			{
				goto IL_0090;
			}
			if ((int)num > 120)
			{
				if (num == 122)
				{
					goto IL_0077;
				}
				if (num == 128)
				{
					bool flag = (unsellable_ = input.ReadBool());
				}
				if (num != 7992)
				{
					goto IL_01f7;
				}
				int num2 = (int)(glotID_ = (uint)input.ReadInt32());
			}
			int num3 = default(int);
			if (num == 112)
			{
				num3 = (extraGiftFriendship_ = input.ReadInt32());
			}
			if (num3 == 120)
			{
				goto IL_0077;
			}
			goto IL_01f7;
			IL_00f3:
			GridAreaData gridAreaData = default(GridAreaData);
			if ((int)num > 34)
			{
				int num5 = default(int);
				if ((int)num > 50)
				{
					string text2 = default(string);
					if (num == 58)
					{
						text2 = (Description = input.ReadString());
					}
					int num4 = default(int);
					if ((long)text2 == 64)
					{
						num4 = (int)(cropType_ = (CropType)input.ReadInt32());
					}
					if (num4 != 72)
					{
						goto IL_01f7;
					}
					num5 = (cookingIngredientType_ = input.ReadInt32());
				}
				string text4 = default(string);
				if (num5 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_01f7;
				}
				GridAreaData builder = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder = gridAreaData_;
				}
				input.ReadMessage(builder);
			}
			string text8 = default(string);
			if ((long)gridAreaData > 18)
			{
				string text6 = default(string);
				if ((long)gridAreaData == 26)
				{
					text6 = (DisplayName = input.ReadString());
				}
				if ((long)text6 != 34)
				{
					goto IL_01f7;
				}
				text8 = (IconAddress = input.ReadString());
			}
			int num6 = default(int);
			if ((long)text8 == 8)
			{
				num6 = (iD_ = input.ReadInt32());
			}
			if (num6 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_01f7;
			IL_0077:
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_0090;
			IL_01f7:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_0090:
			bool flag2 = default(bool);
			if ((int)num > 88)
			{
				int num7 = default(int);
				if (num == 96)
				{
					num7 = (manaRecovered_ = input.ReadInt32());
				}
				if (num7 != 104)
				{
					goto IL_01f7;
				}
				flag2 = (isMissionItem_ = input.ReadBool());
			}
			int num8 = default(int);
			if (flag2)
			{
				num8 = (tier_ = input.ReadInt32());
			}
			if (num8 == 88)
			{
				bool flag3 = (availableInStall_ = input.ReadBool());
				goto IL_00f3;
			}
			goto IL_01f7;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE5")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FB90", Offset = "0x2D3E590", VA = "0x182D3FB90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 15)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
				uint num2 = glotID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE6")]
		[Cpp2IlInjected.Address(RVA = "0x2D405A0", Offset = "0x2D3EFA0", VA = "0x182D405A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0031, IL_0039, IL_0041, IL_0049, IL_0051, IL_0059, IL_0061, IL_0069, IL_0081, IL_0087, IL_008d, IL_0093, IL_0099, IL_009f, IL_00a5, IL_00ab
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0080: Expected I4, but got O
			if (fieldNumber - 1 <= 15)
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

		[Cpp2IlInjected.Token(Token = "0x6001AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F5C0", Offset = "0x2D3DFC0", VA = "0x182D3F5C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0032
			//IL_0010: Expected I4, but got I8
			//IL_0031: Expected I4, but got I8
			if (fieldNumber - 1 <= 15)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AEF")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F7E0", Offset = "0x2D3E1E0", VA = "0x182D3F7E0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			CropItemData cropItemData = new CropItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF0")]
		[Cpp2IlInjected.Address(RVA = "0x2D40F20", Offset = "0x2D3F920", VA = "0x182D40F20")]
		static CropItemData()
		{
			//Discarded unreachable code: IL_0030
			//IL_0029: Expected O, but got I4
			Func<CropItemData> func = default(Func<CropItemData>);
			_parser = (MessageParser<CropItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<CropItemData>)(object)FieldCodec.ForInt32(122u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<CropItemData>)(object)array;
		}
	}
}
