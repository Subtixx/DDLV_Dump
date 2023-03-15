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
	[Cpp2IlInjected.Token(Token = "0x20003EE")]
	public sealed class IngredientItemData : IMessage<IngredientItemData>, IMessage, IEquatable<IngredientItemData>, IDeepCloneable<IngredientItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IBackpackItem, ISellable, IGridPlaceableItemData, ICookingIngredient, IHasTags, IAvailableInStall, ICanBeEaten, IIsMissionItem, IHasExtraGiftFriendship, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4001554")]
		private static readonly MessageParser<IngredientItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001555")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001556")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001557")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001558")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001559")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400155A")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400155B")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x400155C")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400155D")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400155E")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400155F")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001560")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001561")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4001562")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001563")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001564")]
		public const int CookingIngredientTypeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001565")]
		private int cookingIngredientType_;

		[Cpp2IlInjected.Token(Token = "0x4001566")]
		public const int AvailableInStallFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001567")]
		private bool availableInStall_;

		[Cpp2IlInjected.Token(Token = "0x4001568")]
		public const int ManaRecoveredFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001569")]
		private int manaRecovered_;

		[Cpp2IlInjected.Token(Token = "0x400156A")]
		public const int IsMissionItemFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400156B")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x400156C")]
		public const int UnsellableFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400156D")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x400156E")]
		public const int ExtraGiftFriendshipFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400156F")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4001570")]
		public const int TagsFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4001571")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001572")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001573")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001574")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4001575")]
		internal static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000C29")]
		[DebuggerNonUserCode]
		public static MessageParser<IngredientItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002FB5")]
			[Cpp2IlInjected.Address(RVA = "0x27BE7C0", Offset = "0x27BD1C0", VA = "0x1827BE7C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002FB6")]
			[Cpp2IlInjected.Address(RVA = "0x27BE6F0", Offset = "0x27BD0F0", VA = "0x1827BE6F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002FB7")]
			[Cpp2IlInjected.Address(RVA = "0x27BE880", Offset = "0x27BD280", VA = "0x1827BE880", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2C")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002FBC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FBD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2D")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002FBE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "29")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FBF")]
			[Cpp2IlInjected.Address(RVA = "0x27BEAE0", Offset = "0x27BD4E0", VA = "0x1827BEAE0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2E")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002FC0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "24")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FC1")]
			[Cpp2IlInjected.Address(RVA = "0x27BEA00", Offset = "0x27BD400", VA = "0x1827BEA00")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2F")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002FC2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FC3")]
			[Cpp2IlInjected.Address(RVA = "0x27BEA70", Offset = "0x27BD470", VA = "0x1827BEA70")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C30")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002FC4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FC5")]
			[Cpp2IlInjected.Address(RVA = "0x27BEB50", Offset = "0x27BD550", VA = "0x1827BEB50")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C31")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6002FC6")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "27")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FC7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C32")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6002FC8")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FC9")]
			[Cpp2IlInjected.Address(RVA = "0x27BE990", Offset = "0x27BD390", VA = "0x1827BE990")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C33")]
		[DebuggerNonUserCode]
		public int CookingIngredientType
		{
			[Cpp2IlInjected.Token(Token = "0x6002FCA")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return cookingIngredientType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FCB")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				cookingIngredientType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C34")]
		[DebuggerNonUserCode]
		public bool AvailableInStall
		{
			[Cpp2IlInjected.Token(Token = "0x6002FCC")]
			[Cpp2IlInjected.Address(RVA = "0x1781430", Offset = "0x177FE30", VA = "0x181781430", Slot = "34")]
			get
			{
				return availableInStall_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FCD")]
			[Cpp2IlInjected.Address(RVA = "0x1781A50", Offset = "0x1780450", VA = "0x181781A50")]
			set
			{
				availableInStall_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C35")]
		[DebuggerNonUserCode]
		public int ManaRecovered
		{
			[Cpp2IlInjected.Token(Token = "0x6002FCE")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "35")]
			get
			{
				return manaRecovered_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FCF")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				manaRecovered_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C36")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002FD0")]
			[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0", Slot = "36")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FD1")]
			[Cpp2IlInjected.Address(RVA = "0x9765E0", Offset = "0x974FE0", VA = "0x1809765E0")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C37")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6002FD2")]
			[Cpp2IlInjected.Address(RVA = "0xDD7060", Offset = "0xDD5A60", VA = "0x180DD7060")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FD3")]
			[Cpp2IlInjected.Address(RVA = "0xDD7120", Offset = "0xDD5B20", VA = "0x180DD7120")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C38")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6002FD4")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "37")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FD5")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C39")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002FD6")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "33")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C3A")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002FD7")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FD8")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C3B")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002FE4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "38")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C3C")]
		public bool CanBeUsedAsIngredient
		{
			[Cpp2IlInjected.Token(Token = "0x6002FE5")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "31")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C3D")]
		public Item CookingIngredientTypeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002FE6")]
			[Cpp2IlInjected.Address(RVA = "0x27BE6A0", Offset = "0x27BD0A0", VA = "0x1827BE6A0", Slot = "30")]
			get
			{
				int num = cookingIngredientType_;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FE7")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				//IL_0007: Expected I4, but got O
				cookingIngredientType_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C3E")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6002FE8")]
			[Cpp2IlInjected.Address(RVA = "0x27BE680", Offset = "0x27BD080", VA = "0x1827BE680", Slot = "39")]
			get
			{
				return !isMissionItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C3F")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6002FE9")]
			[Cpp2IlInjected.Address(RVA = "0x27BE690", Offset = "0x27BD090", VA = "0x1827BE690", Slot = "26")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C40")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002FEA")]
			[Cpp2IlInjected.Address(RVA = "0x27BE820", Offset = "0x27BD220", VA = "0x1827BE820", Slot = "32")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB8")]
		[Cpp2IlInjected.Address(RVA = "0x27BE550", Offset = "0x27BCF50", VA = "0x1827BE550")]
		[DebuggerNonUserCode]
		public IngredientItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB9")]
		[Cpp2IlInjected.Address(RVA = "0x27BD820", Offset = "0x27BC220", VA = "0x1827BD820")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FBA")]
		[Cpp2IlInjected.Address(RVA = "0x27BE2E0", Offset = "0x27BCCE0", VA = "0x1827BE2E0")]
		[DebuggerNonUserCode]
		public IngredientItemData(IngredientItemData other)
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
			int num3 = (cookingIngredientType_ = other.cookingIngredientType_);
			bool flag = (availableInStall_ = other.availableInStall_);
			int num4 = (manaRecovered_ = other.manaRecovered_);
			bool flag2 = (isMissionItem_ = other.isMissionItem_);
			bool flag3 = (unsellable_ = other.unsellable_);
			int num5 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			uint num6 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FBB")]
		[Cpp2IlInjected.Address(RVA = "0x27BCB70", Offset = "0x27BB570", VA = "0x1827BCB70", Slot = "10")]
		[DebuggerNonUserCode]
		public IngredientItemData Clone()
		{
			return new IngredientItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FD9")]
		[Cpp2IlInjected.Address(RVA = "0x27BCD40", Offset = "0x27BB740", VA = "0x1827BCD40", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(IngredientItemData).TypeHandle)
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
									if (!flag5 && cookingIngredientType_ == (flag5 ? 1 : 0) && availableInStall_ == flag5 && manaRecovered_ == (flag5 ? 1 : 0) && isMissionItem_ == flag5 && unsellable_ == flag5 && extraGiftFriendship_ == (flag5 ? 1 : 0))
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

		[Cpp2IlInjected.Token(Token = "0x6002FDA")]
		[Cpp2IlInjected.Address(RVA = "0x27BCBD0", Offset = "0x27BB5D0", VA = "0x1827BCBD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(IngredientItemData other)
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
												bool flag = other.availableInStall_;
												if (availableInStall_ == flag)
												{
													int num3 = other.manaRecovered_;
													if (manaRecovered_ == num3)
													{
														bool flag2 = other.isMissionItem_;
														if (isMissionItem_ == flag2)
														{
															bool flag3 = other.unsellable_;
															if (unsellable_ == flag3)
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
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FDB")]
		[Cpp2IlInjected.Address(RVA = "0x27BD120", Offset = "0x27BBB20", VA = "0x1827BD120", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0106
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
			if (cookingIngredientType_ != 0)
			{
			}
			if (availableInStall_)
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

		[Cpp2IlInjected.Token(Token = "0x6002FDC")]
		[Cpp2IlInjected.Address(RVA = "0x27BDD50", Offset = "0x27BC750", VA = "0x1827BDD50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FDD")]
		[Cpp2IlInjected.Address(RVA = "0x27BDDB0", Offset = "0x27BC7B0", VA = "0x1827BDDB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01a1
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
			if (cookingIngredientType_ != 0)
			{
				int value8 = cookingIngredientType_;
				output.WriteInt32(value8);
			}
			if (availableInStall_)
			{
				bool value9 = availableInStall_;
				output.WriteBool(value9);
			}
			if (manaRecovered_ != 0)
			{
				int value10 = manaRecovered_;
				output.WriteInt32(value10);
			}
			if (isMissionItem_)
			{
				bool value11 = isMissionItem_;
				output.WriteBool(value11);
			}
			if (extraGiftFriendship_ != 0)
			{
				int value12 = extraGiftFriendship_;
				output.WriteInt32(value12);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (unsellable_)
			{
				bool value13 = unsellable_;
				output.WriteBool(value13);
			}
			if (glotID_ != 0)
			{
				uint value14 = glotID_;
				output.WriteUInt32(value14);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FDE")]
		[Cpp2IlInjected.Address(RVA = "0x27BC620", Offset = "0x27BB020", VA = "0x1827BC620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01b1
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

		[Cpp2IlInjected.Token(Token = "0x6002FDF")]
		[Cpp2IlInjected.Address(RVA = "0x27BD640", Offset = "0x27BC040", VA = "0x1827BD640", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(IngredientItemData other)
		{
			//Discarded unreachable code: IL_019b
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
			int num2 = other.cookingIngredientType_;
			if (num2 != 0)
			{
				cookingIngredientType_ = num2;
			}
			bool flag = other.availableInStall_;
			if (flag)
			{
				availableInStall_ = flag;
			}
			int num3 = other.manaRecovered_;
			if (num3 != 0)
			{
				manaRecovered_ = num3;
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
			int num4 = other.extraGiftFriendship_;
			if (num4 != 0)
			{
				extraGiftFriendship_ = num4;
			}
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			uint num5 = other.glotID_;
			if (num5 != 0)
			{
				glotID_ = num5;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002FE0")]
		[Cpp2IlInjected.Address(RVA = "0x27BD330", Offset = "0x27BBD30", VA = "0x1827BD330", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01e2
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 64)
			{
				if ((int)num > 96)
				{
					if ((int)num > 106)
					{
						if (num == 256)
						{
							bool flag = (unsellable_ = input.ReadBool());
						}
						if (num != 7992)
						{
							goto IL_01cb;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					num += 4294967192u;
					if (num != 4294967293u)
					{
						goto IL_01cb;
					}
					RepeatedField<int> repeatedField = tags_;
					FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
				}
				int num3 = default(int);
				if ((int)num > 80)
				{
					bool flag2 = default(bool);
					if (num == 88)
					{
						flag2 = (isMissionItem_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_01cb;
					}
					num3 = (extraGiftFriendship_ = input.ReadInt32());
				}
				bool flag3 = default(bool);
				if (num3 == 72)
				{
					flag3 = (availableInStall_ = input.ReadBool());
				}
				if (!flag3)
				{
					goto IL_01cb;
				}
				int num4 = (manaRecovered_ = input.ReadInt32());
			}
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
					if ((long)text2 != 64)
					{
						goto IL_01cb;
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
					goto IL_01cb;
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
					goto IL_01cb;
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
			goto IL_01cb;
			IL_01cb:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002FE1")]
		[Cpp2IlInjected.Address(RVA = "0x27BCF00", Offset = "0x27BB900", VA = "0x1827BCF00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
			{
				int num = iD_;
			}
			if (fieldNumber == 32)
			{
				bool flag = unsellable_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FE2")]
		[Cpp2IlInjected.Address(RVA = "0x27BD880", Offset = "0x27BC280", VA = "0x1827BD880", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0031, IL_0039, IL_0041, IL_0049, IL_0051, IL_006e, IL_0074, IL_007a, IL_0080, IL_0086, IL_008c, IL_0092, IL_0098
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0065: Expected I4, but got O
			//IL_006d: Expected I4, but got O
			if (fieldNumber - 1 <= 12)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
			else if (fieldNumber == 32)
			{
				object obj2 = default(object);
				unsellable_ = (byte)(int)obj2 != 0;
			}
			else
			{
				object obj3 = default(object);
				glotID_ = (uint)(int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FE3")]
		[Cpp2IlInjected.Address(RVA = "0x27BC970", Offset = "0x27BB370", VA = "0x1827BC970", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_0033
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 12)
			{
				iD_ = 0;
				return;
			}
			switch (fieldNumber)
			{
			case 32:
				unsellable_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FEB")]
		[Cpp2IlInjected.Address(RVA = "0x27BCB70", Offset = "0x27BB570", VA = "0x1827BCB70", Slot = "20")]
		IItemData IItemData.Clone()
		{
			IngredientItemData ingredientItemData = new IngredientItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FEC")]
		[Cpp2IlInjected.Address(RVA = "0x27BE100", Offset = "0x27BCB00", VA = "0x1827BE100")]
		static IngredientItemData()
		{
			//Discarded unreachable code: IL_0030
			//IL_0029: Expected O, but got I4
			Func<IngredientItemData> func = default(Func<IngredientItemData>);
			_parser = (MessageParser<IngredientItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<IngredientItemData>)(object)FieldCodec.ForInt32(106u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<IngredientItemData>)(object)array;
		}
	}
}
