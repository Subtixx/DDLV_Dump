using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003D0")]
	public sealed class FishItemData : IMessage<FishItemData>, IMessage, IEquatable<FishItemData>, IDeepCloneable<FishItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IBackpackItem, ISellable, IGridPlaceableItemData, ICookingIngredient, IHasTags, IDataValidation, ICanBeEaten, IIsMissionItem, IHasExtraGiftFriendship, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x400140D")]
		private static readonly MessageParser<FishItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400140E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400140F")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001410")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001411")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001412")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001413")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001414")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001415")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001416")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001417")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001418")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001419")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400141A")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x400141B")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400141C")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x400141D")]
		public const int MinMassFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400141E")]
		private float minMass_;

		[Cpp2IlInjected.Token(Token = "0x400141F")]
		public const int MaxMassFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001420")]
		private float maxMass_;

		[Cpp2IlInjected.Token(Token = "0x4001421")]
		public const int CookingIngredientTypeFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001422")]
		private int cookingIngredientType_;

		[Cpp2IlInjected.Token(Token = "0x4001423")]
		public const int ManaRecoveredFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001424")]
		private int manaRecovered_;

		[Cpp2IlInjected.Token(Token = "0x4001425")]
		public const int IsMissionItemFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001426")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4001427")]
		public const int UnsellableFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4001428")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x4001429")]
		public const int ExtraGiftFriendshipFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400142A")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x400142B")]
		public const int TagsFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x400142C")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400142D")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400142E")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400142F")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4001430")]
		internal static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000B6B")]
		[DebuggerNonUserCode]
		public static MessageParser<FishItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002D82")]
			[Cpp2IlInjected.Address(RVA = "0x3577ED0", Offset = "0x35768D0", VA = "0x183577ED0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B6C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D83")]
			[Cpp2IlInjected.Address(RVA = "0x3577E00", Offset = "0x3576800", VA = "0x183577E00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B6D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D84")]
			[Cpp2IlInjected.Address(RVA = "0x3577F90", Offset = "0x3576990", VA = "0x183577F90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B6E")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002D89")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D8A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B6F")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002D8B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "29")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D8C")]
			[Cpp2IlInjected.Address(RVA = "0x35781F0", Offset = "0x3576BF0", VA = "0x1835781F0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B70")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002D8D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "24")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D8E")]
			[Cpp2IlInjected.Address(RVA = "0x3578110", Offset = "0x3576B10", VA = "0x183578110")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B71")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002D8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D90")]
			[Cpp2IlInjected.Address(RVA = "0x3578180", Offset = "0x3576B80", VA = "0x183578180")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B72")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002D91")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D92")]
			[Cpp2IlInjected.Address(RVA = "0x3578260", Offset = "0x3576C60", VA = "0x183578260")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B73")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6002D93")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "27")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D94")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B74")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6002D95")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D96")]
			[Cpp2IlInjected.Address(RVA = "0x35780A0", Offset = "0x3576AA0", VA = "0x1835780A0")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B75")]
		[DebuggerNonUserCode]
		public float MinMass
		{
			[Cpp2IlInjected.Token(Token = "0x6002D97")]
			[Cpp2IlInjected.Address(RVA = "0xCBE930", Offset = "0xCBD330", VA = "0x180CBE930")]
			get
			{
				return minMass_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D98")]
			[Cpp2IlInjected.Address(RVA = "0x282E0B0", Offset = "0x282CAB0", VA = "0x18282E0B0")]
			set
			{
				minMass_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B76")]
		[DebuggerNonUserCode]
		public float MaxMass
		{
			[Cpp2IlInjected.Token(Token = "0x6002D99")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5D0", Offset = "0xE38FD0", VA = "0x180E3A5D0")]
			get
			{
				return maxMass_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D9A")]
			[Cpp2IlInjected.Address(RVA = "0xE3A850", Offset = "0xE39250", VA = "0x180E3A850")]
			set
			{
				maxMass_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B77")]
		[DebuggerNonUserCode]
		public int CookingIngredientType
		{
			[Cpp2IlInjected.Token(Token = "0x6002D9B")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return cookingIngredientType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D9C")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				cookingIngredientType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B78")]
		[DebuggerNonUserCode]
		public int ManaRecovered
		{
			[Cpp2IlInjected.Token(Token = "0x6002D9D")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820", Slot = "35")]
			get
			{
				return manaRecovered_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D9E")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				manaRecovered_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B79")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002D9F")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0", Slot = "36")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DA0")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7A")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6002DA1")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5F0", Offset = "0xE38FF0", VA = "0x180E3A5F0")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DA2")]
			[Cpp2IlInjected.Address(RVA = "0x1A7B2C0", Offset = "0x1A79CC0", VA = "0x181A7B2C0")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7B")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6002DA3")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "37")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DA4")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7C")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002DA5")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "33")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7D")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002DA6")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DA7")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7E")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "38")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7F")]
		public bool CanBeUsedAsIngredient
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB4")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "31")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B80")]
		public Item CookingIngredientTypeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB5")]
			[Cpp2IlInjected.Address(RVA = "0x3577DA0", Offset = "0x35767A0", VA = "0x183577DA0", Slot = "30")]
			get
			{
				long num = Convert.ToInt64((uint)cookingIngredientType_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DB6")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				cookingIngredientType_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B81")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB7")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C7E0", Offset = "0x1D2B1E0", VA = "0x181D2C7E0", Slot = "39")]
			get
			{
				return !isMissionItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B82")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB8")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C7F0", Offset = "0x1D2B1F0", VA = "0x181D2C7F0", Slot = "26")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B83")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB9")]
			[Cpp2IlInjected.Address(RVA = "0x3577F30", Offset = "0x3576930", VA = "0x183577F30", Slot = "32")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D85")]
		[Cpp2IlInjected.Address(RVA = "0x3577A00", Offset = "0x3576400", VA = "0x183577A00")]
		[DebuggerNonUserCode]
		public FishItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D86")]
		[Cpp2IlInjected.Address(RVA = "0x3576EA0", Offset = "0x35758A0", VA = "0x183576EA0")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D87")]
		[Cpp2IlInjected.Address(RVA = "0x3577B30", Offset = "0x3576530", VA = "0x183577B30")]
		[DebuggerNonUserCode]
		public FishItemData(FishItemData other)
		{
			//IL_00c4: Expected O, but got I4
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
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
			float num3 = (minMass_ = other.minMass_);
			float num4 = (maxMass_ = other.maxMass_);
			int num5 = (cookingIngredientType_ = other.cookingIngredientType_);
			int num6 = (manaRecovered_ = other.manaRecovered_);
			bool flag = (isMissionItem_ = other.isMissionItem_);
			bool flag2 = (unsellable_ = other.unsellable_);
			int num7 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			uint num8 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D88")]
		[Cpp2IlInjected.Address(RVA = "0x3576080", Offset = "0x3574A80", VA = "0x183576080", Slot = "10")]
		[DebuggerNonUserCode]
		public FishItemData Clone()
		{
			return new FishItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA8")]
		[Cpp2IlInjected.Address(RVA = "0x3576380", Offset = "0x3574D80", VA = "0x183576380", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((FishItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA9")]
		[Cpp2IlInjected.Address(RVA = "0x3576160", Offset = "0x3574B60", VA = "0x183576160", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FishItemData other)
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
											int num2 = other.cookingIngredientType_;
											if (cookingIngredientType_ == num2)
											{
												int num3 = other.manaRecovered_;
												if (manaRecovered_ == num3)
												{
													bool flag = other.isMissionItem_;
													if (isMissionItem_ == flag)
													{
														bool flag2 = other.unsellable_;
														if (unsellable_ == flag2)
														{
															int num4 = other.extraGiftFriendship_;
															if (extraGiftFriendship_ == num4)
															{
																RepeatedField<int> repeatedField = tags_;
																RepeatedField<int> repeatedField2 = other.tags_;
																if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																{
																	uint num5 = other.glotID_;
																	if (glotID_ == num5)
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
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DAA")]
		[Cpp2IlInjected.Address(RVA = "0x3576610", Offset = "0x3575010", VA = "0x183576610", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0132
			//IL_00be: Expected O, but got F4
			//IL_00d4: Expected O, but got F4
			int num = 0;
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
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = default(EqualityComparer<float>);
			if (text5.m_stringLength != 0)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode7 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)0f);
			}
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField != null)
			{
				int hashCode8 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)0f);
			}
			if (cookingIngredientType_ != 0)
			{
			}
			if (manaRecovered_ != 0)
			{
			}
			if (isMissionItem_)
			{
			}
			if (unsellable_)
			{
			}
			if (extraGiftFriendship_ != 0)
			{
			}
			int hashCode9 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode10 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DAB")]
		[Cpp2IlInjected.Address(RVA = "0x3577420", Offset = "0x3575E20", VA = "0x183577420", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DAC")]
		[Cpp2IlInjected.Address(RVA = "0x3577480", Offset = "0x3575E80", VA = "0x183577480", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01b0
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
			if (output != null)
			{
				float value8 = minMass_;
				output.WriteFloat(value8);
			}
			if (output != null)
			{
				float value9 = maxMass_;
				output.WriteFloat(value9);
			}
			if (cookingIngredientType_ != 0)
			{
				int value10 = cookingIngredientType_;
				output.WriteInt32(value10);
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

		[Cpp2IlInjected.Token(Token = "0x6002DAD")]
		[Cpp2IlInjected.Address(RVA = "0x3575B10", Offset = "0x3574510", VA = "0x183575B10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01b9
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
			num2 += 5;
			num2 += 5;
			int num10 = cookingIngredientType_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = manaRecovered_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			int num14 = extraGiftFriendship_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num16 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			uint num17 = glotID_;
			num2 += num16;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeUInt32Size(num17);
				num18 += 2;
				num2 += num18;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num19 = unknownFields.CalculateSize();
				num2 += num19;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DAE")]
		[Cpp2IlInjected.Address(RVA = "0x3576CA0", Offset = "0x35756A0", VA = "0x183576CA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishItemData other)
		{
			//Discarded unreachable code: IL_01ba
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
			float num2 = other.minMass_;
			if (text5.m_stringLength != 0)
			{
				minMass_ = num2;
			}
			float num3 = other.maxMass_;
			if (text5.m_stringLength != 0)
			{
				maxMass_ = num3;
			}
			int num4 = other.cookingIngredientType_;
			if (num4 != 0)
			{
				cookingIngredientType_ = num4;
			}
			int num5 = other.manaRecovered_;
			if (num5 != 0)
			{
				manaRecovered_ = num5;
			}
			bool flag = other.isMissionItem_;
			if (flag)
			{
				isMissionItem_ = flag;
			}
			bool flag2 = other.unsellable_;
			if (flag2)
			{
				unsellable_ = flag2;
			}
			int num6 = other.extraGiftFriendship_;
			if (num6 != 0)
			{
				extraGiftFriendship_ = num6;
			}
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			uint num7 = other.glotID_;
			if (num7 != 0)
			{
				glotID_ = num7;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002DAF")]
		[Cpp2IlInjected.Address(RVA = "0x3576980", Offset = "0x3575380", VA = "0x183576980", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01f6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 69)
			{
				goto IL_00ef;
			}
			if ((int)num <= 96)
			{
				goto IL_008d;
			}
			if ((int)num > 112)
			{
				if (num == 114)
				{
					goto IL_0074;
				}
				if (num == 120)
				{
					bool flag = (unsellable_ = input.ReadBool());
				}
				if (num != 7992)
				{
					goto IL_01df;
				}
				int num2 = (int)(glotID_ = (uint)input.ReadInt32());
			}
			int num3 = default(int);
			if (num == 104)
			{
				num3 = (extraGiftFriendship_ = input.ReadInt32());
			}
			if (num3 == 112)
			{
				goto IL_0074;
			}
			goto IL_01df;
			IL_00ef:
			GridAreaData gridAreaData = default(GridAreaData);
			if ((int)num > 34)
			{
				string text2 = default(string);
				if ((int)num > 50)
				{
					if (num == 58)
					{
						text2 = (Description = input.ReadString());
					}
					if ((long)text2 != 69)
					{
						goto IL_01df;
					}
					float num4 = (minMass_ = input.ReadFloat());
				}
				string text4 = default(string);
				if ((long)text2 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_01df;
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
					goto IL_01df;
				}
				text8 = (IconAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text8 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			if (num5 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_01df;
			IL_0074:
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_008d;
			IL_01df:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_008d:
			bool flag2 = default(bool);
			if ((int)num > 80)
			{
				int num6 = default(int);
				if (num == 88)
				{
					num6 = (manaRecovered_ = input.ReadInt32());
				}
				if (num6 != 96)
				{
					goto IL_01df;
				}
				flag2 = (isMissionItem_ = input.ReadBool());
			}
			if (flag2)
			{
				float num7 = (maxMass_ = input.ReadFloat());
			}
			if (flag2)
			{
				int num8 = (cookingIngredientType_ = input.ReadInt32());
				goto IL_00ef;
			}
			goto IL_01df;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB0")]
		[Cpp2IlInjected.Address(RVA = "0x35763E0", Offset = "0x3574DE0", VA = "0x1835763E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 14)
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

		[Cpp2IlInjected.Token(Token = "0x6002DB1")]
		[Cpp2IlInjected.Address(RVA = "0x3576F00", Offset = "0x3575900", VA = "0x183576F00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0031, IL_0039, IL_0041, IL_0049, IL_0051, IL_0059, IL_0061, IL_0079, IL_007f, IL_0085, IL_008b, IL_0091, IL_0097, IL_009d, IL_00a3
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0038: Expected F4, but got I4
			//IL_0040: Expected F4, but got I4
			//IL_0078: Expected I4, but got O
			if (fieldNumber - 1 <= 14)
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

		[Cpp2IlInjected.Token(Token = "0x6002DB2")]
		[Cpp2IlInjected.Address(RVA = "0x3575E70", Offset = "0x3574870", VA = "0x183575E70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_0031
			//IL_0010: Expected I4, but got I8
			//IL_0030: Expected I4, but got I8
			if (fieldNumber - 1 <= 14)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DBA")]
		[Cpp2IlInjected.Address(RVA = "0x3576080", Offset = "0x3574A80", VA = "0x183576080", Slot = "20")]
		IItemData IItemData.Clone()
		{
			FishItemData fishItemData = new FishItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DBB")]
		[Cpp2IlInjected.Address(RVA = "0x35760E0", Offset = "0x3574AE0", VA = "0x1835760E0", Slot = "34")]
		public void DataValidation(DataValidation.Context context)
		{
		}//Discarded unreachable code: IL_0001


		[Cpp2IlInjected.Token(Token = "0x6002DBC")]
		[Cpp2IlInjected.Address(RVA = "0x3577820", Offset = "0x3576220", VA = "0x183577820")]
		static FishItemData()
		{
			//Discarded unreachable code: IL_0030
			//IL_0029: Expected O, but got I4
			Func<FishItemData> func = default(Func<FishItemData>);
			_parser = (MessageParser<FishItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<FishItemData>)(object)FieldCodec.ForInt32(114u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<FishItemData>)(object)array;
		}
	}
}
