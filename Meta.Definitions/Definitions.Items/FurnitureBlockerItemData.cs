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
	[Cpp2IlInjected.Token(Token = "0x20002D7")]
	public sealed class FurnitureBlockerItemData : IMessage<FurnitureBlockerItemData>, IMessage, IEquatable<FurnitureBlockerItemData>, IDeepCloneable<FurnitureBlockerItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IGridEditRestriction, IDataValidation, IHasTags
	{
		[Cpp2IlInjected.Token(Token = "0x4000CD4")]
		private static readonly MessageParser<FurnitureBlockerItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000CD5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000CD6")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000CD7")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000CD8")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000CD9")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CDA")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000CDB")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CDC")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000CDD")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CDE")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000CDF")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CE0")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000CE1")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000CE2")]
		public const int ToolFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000CE3")]
		private int tool_;

		[Cpp2IlInjected.Token(Token = "0x4000CE4")]
		public const int UpgradeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000CE5")]
		private int upgrade_;

		[Cpp2IlInjected.Token(Token = "0x4000CE6")]
		public const int DefaultRewardItemIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000CE7")]
		private int defaultRewardItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000CE8")]
		public const int ReplaceByFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000CE9")]
		private int replaceBy_;

		[Cpp2IlInjected.Token(Token = "0x4000CEA")]
		public const int RewardLootTableItemIDFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000CEB")]
		private int rewardLootTableItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000CEC")]
		public const int GridEditRestrictionFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000CED")]
		private GridEditRestriction gridEditRestriction_;

		[Cpp2IlInjected.Token(Token = "0x4000CEE")]
		public const int TagsFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x4000CEF")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000CF0")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000CF1")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000CF2")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000CF3")]
		public static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000706")]
		[DebuggerNonUserCode]
		public static MessageParser<FurnitureBlockerItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001EA3")]
			[Cpp2IlInjected.Address(RVA = "0x3444D40", Offset = "0x3443740", VA = "0x183444D40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000707")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001EA4")]
			[Cpp2IlInjected.Address(RVA = "0x3444C10", Offset = "0x3443610", VA = "0x183444C10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000708")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001EA5")]
			[Cpp2IlInjected.Address(RVA = "0x3444F80", Offset = "0x3443980", VA = "0x183444F80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000709")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001EAA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EAB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070A")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001EAC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EAD")]
			[Cpp2IlInjected.Address(RVA = "0x3445170", Offset = "0x3443B70", VA = "0x183445170")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070B")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001EAE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EAF")]
			[Cpp2IlInjected.Address(RVA = "0x3445090", Offset = "0x3443A90", VA = "0x183445090")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070C")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001EB0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EB1")]
			[Cpp2IlInjected.Address(RVA = "0x3445100", Offset = "0x3443B00", VA = "0x183445100")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070D")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001EB2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EB3")]
			[Cpp2IlInjected.Address(RVA = "0x34451E0", Offset = "0x3443BE0", VA = "0x1834451E0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070E")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001EB4")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EB5")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070F")]
		[DebuggerNonUserCode]
		public int Tool
		{
			[Cpp2IlInjected.Token(Token = "0x6001EB6")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return tool_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EB7")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				tool_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000710")]
		[DebuggerNonUserCode]
		public int Upgrade
		{
			[Cpp2IlInjected.Token(Token = "0x6001EB8")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return upgrade_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EB9")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				upgrade_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000711")]
		[DebuggerNonUserCode]
		public int DefaultRewardItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001EBA")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return defaultRewardItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EBB")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				defaultRewardItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000712")]
		[DebuggerNonUserCode]
		public int ReplaceBy
		{
			[Cpp2IlInjected.Token(Token = "0x6001EBC")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return replaceBy_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EBD")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				replaceBy_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000713")]
		[DebuggerNonUserCode]
		public int RewardLootTableItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001EBE")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return rewardLootTableItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EBF")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				rewardLootTableItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000714")]
		[DebuggerNonUserCode]
		public GridEditRestriction GridEditRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC0")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060", Slot = "24")]
			get
			{
				return gridEditRestriction_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EC1")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				gridEditRestriction_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000715")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC2")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "27")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000716")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC3")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001EC4")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000717")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001ED0")]
			[Cpp2IlInjected.Address(RVA = "0x3444CE0", Offset = "0x34436E0", VA = "0x183444CE0", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000718")]
		public Item ToolItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001ED2")]
			[Cpp2IlInjected.Address(RVA = "0x3444E60", Offset = "0x3443860", VA = "0x183444E60")]
			get
			{
				long num = Convert.ToInt64((uint)tool_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000719")]
		public Item UpgradeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001ED3")]
			[Cpp2IlInjected.Address(RVA = "0x3444EC0", Offset = "0x34438C0", VA = "0x183444EC0")]
			get
			{
				long num = Convert.ToInt64((uint)upgrade_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700071A")]
		public Item DefaultRewardItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001ED4")]
			[Cpp2IlInjected.Address(RVA = "0x3444BB0", Offset = "0x34435B0", VA = "0x183444BB0")]
			get
			{
				long num = Convert.ToInt64((uint)defaultRewardItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700071B")]
		public Item ReplaceByItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001ED5")]
			[Cpp2IlInjected.Address(RVA = "0x3444DA0", Offset = "0x34437A0", VA = "0x183444DA0")]
			get
			{
				long num = Convert.ToInt64((uint)replaceBy_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700071C")]
		public Item RewardLootTableItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001ED6")]
			[Cpp2IlInjected.Address(RVA = "0x3444E00", Offset = "0x3443800", VA = "0x183444E00")]
			get
			{
				long num = Convert.ToInt64((uint)rewardLootTableItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700071D")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001ED9")]
			[Cpp2IlInjected.Address(RVA = "0x3444F20", Offset = "0x3443920", VA = "0x183444F20", Slot = "26")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA6")]
		[Cpp2IlInjected.Address(RVA = "0x3444AD0", Offset = "0x34434D0", VA = "0x183444AD0")]
		[DebuggerNonUserCode]
		public FurnitureBlockerItemData()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA7")]
		[Cpp2IlInjected.Address(RVA = "0x3443CF0", Offset = "0x34426F0", VA = "0x183443CF0")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			GridEditRestriction gridEditRestriction = new GridEditRestriction();
			GridEditRestriction.Types.Restriction restriction = new GridEditRestriction.Types.Restriction();
			int num = ((restriction.Value = false) ? 1 : 0);
			gridEditRestriction.canMove_ = restriction;
			GridEditRestriction.Types.Restriction restriction2 = new GridEditRestriction.Types.Restriction();
			int num2 = ((restriction2.Value = false) ? 1 : 0);
			gridEditRestriction.canRotate_ = restriction2;
			GridEditRestriction.Types.Restriction restriction3 = new GridEditRestriction.Types.Restriction();
			int num3 = ((restriction3.Value = false) ? 1 : 0);
			gridEditRestriction.canBeRemoved_ = restriction3;
			gridEditRestriction.canBeCleared_ = false;
			GridEditRestriction.Types.Restriction restriction4 = new GridEditRestriction.Types.Restriction();
			int num4 = ((restriction4.Value = false) ? 1 : 0);
			gridEditRestriction.canBeSelected_ = restriction4;
			gridEditRestriction_ = gridEditRestriction;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA8")]
		[Cpp2IlInjected.Address(RVA = "0x34448A0", Offset = "0x34432A0", VA = "0x1834448A0")]
		[DebuggerNonUserCode]
		public FurnitureBlockerItemData(FurnitureBlockerItemData other)
		{
			//IL_00b0: Expected O, but got I4
			OnConstruction();
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData = other.gridAreaData_;
			int num2 = 0;
			if (gridAreaData != null)
			{
				GridAreaData gridAreaData2 = gridAreaData.Clone();
			}
			gridAreaData_ = (GridAreaData)num2;
			int num3 = (tool_ = other.tool_);
			int num4 = (upgrade_ = other.upgrade_);
			int num5 = (defaultRewardItemID_ = other.defaultRewardItemID_);
			int num6 = (replaceBy_ = other.replaceBy_);
			int num7 = (rewardLootTableItemID_ = other.rewardLootTableItemID_);
			GridEditRestriction gridEditRestriction = other.gridEditRestriction_;
			GridEditRestriction gridEditRestriction2 = default(GridEditRestriction);
			if (gridEditRestriction != null)
			{
				gridEditRestriction2 = gridEditRestriction.Clone();
			}
			gridEditRestriction_ = gridEditRestriction2;
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			uint num8 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA9")]
		[Cpp2IlInjected.Address(RVA = "0x3442970", Offset = "0x3441370", VA = "0x183442970", Slot = "10")]
		[DebuggerNonUserCode]
		public FurnitureBlockerItemData Clone()
		{
			return new FurnitureBlockerItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EC5")]
		[Cpp2IlInjected.Address(RVA = "0x3443120", Offset = "0x3441B20", VA = "0x183443120", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(FurnitureBlockerItemData).TypeHandle)
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
								if (!flag4)
								{
									bool flag5 = object.Equals(gridAreaData_, other);
									if (flag5 && tool_ == (flag5 ? 1 : 0) && upgrade_ == (flag5 ? 1 : 0) && defaultRewardItemID_ == (flag5 ? 1 : 0) && replaceBy_ == (flag5 ? 1 : 0) && rewardLootTableItemID_ == (flag5 ? 1 : 0) && object.Equals(gridEditRestriction_, other))
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

		[Cpp2IlInjected.Token(Token = "0x6001EC6")]
		[Cpp2IlInjected.Address(RVA = "0x3442FB0", Offset = "0x34419B0", VA = "0x183442FB0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FurnitureBlockerItemData other)
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
										int num2 = other.tool_;
										if (tool_ == num2)
										{
											int num3 = other.upgrade_;
											if (upgrade_ == num3)
											{
												int num4 = other.defaultRewardItemID_;
												if (defaultRewardItemID_ == num4)
												{
													int num5 = other.replaceBy_;
													if (replaceBy_ == num5)
													{
														int num6 = other.rewardLootTableItemID_;
														if (rewardLootTableItemID_ == num6)
														{
															GridEditRestriction objB2 = other.gridEditRestriction_;
															if (object.Equals(gridEditRestriction_, objB2))
															{
																RepeatedField<int> repeatedField = tags_;
																RepeatedField<int> repeatedField2 = other.tags_;
																if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																{
																	uint num7 = other.glotID_;
																	if (glotID_ == num7)
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
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EC7")]
		[Cpp2IlInjected.Address(RVA = "0x3443480", Offset = "0x3441E80", VA = "0x183443480", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00f8
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
			if (tool_ != 0)
			{
			}
			if (upgrade_ != 0)
			{
			}
			if (defaultRewardItemID_ != 0)
			{
			}
			if (replaceBy_ != 0)
			{
			}
			if (rewardLootTableItemID_ != 0)
			{
			}
			GridEditRestriction gridEditRestriction = gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				int hashCode6 = gridEditRestriction.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6001EC8")]
		[Cpp2IlInjected.Address(RVA = "0x3444320", Offset = "0x3442D20", VA = "0x183444320", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EC9")]
		[Cpp2IlInjected.Address(RVA = "0x3444380", Offset = "0x3442D80", VA = "0x183444380", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0185
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
			if (tool_ != 0)
			{
				int value7 = tool_;
				output.WriteInt32(value7);
			}
			if (upgrade_ != 0)
			{
				int value8 = upgrade_;
				output.WriteInt32(value8);
			}
			if (defaultRewardItemID_ != 0)
			{
				int value9 = defaultRewardItemID_;
				output.WriteInt32(value9);
			}
			if (replaceBy_ != 0)
			{
				int value10 = replaceBy_;
				output.WriteInt32(value10);
			}
			if (rewardLootTableItemID_ != 0)
			{
				int value11 = rewardLootTableItemID_;
				output.WriteInt32(value11);
			}
			if ((long)gridEditRestriction_ != 0)
			{
				GridEditRestriction value12 = gridEditRestriction_;
				output.WriteMessage(value12);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (glotID_ != 0)
			{
				uint value13 = glotID_;
				output.WriteUInt32(value13);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECA")]
		[Cpp2IlInjected.Address(RVA = "0x34423F0", Offset = "0x3440DF0", VA = "0x1834423F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01ee
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
			int num9 = tool_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			int num11 = upgrade_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			int num13 = defaultRewardItemID_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			int num15 = replaceBy_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num2 += num16;
			}
			int num17 = rewardLootTableItemID_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18++;
				num2 += num18;
			}
			GridEditRestriction gridEditRestriction = gridEditRestriction_;
			if (gridEditRestriction != null)
			{
				int num19 = CodedOutputStream.ComputeMessageSize(gridEditRestriction);
				num19++;
				num2 += num19;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num20 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			uint num21 = glotID_;
			num2 += num20;
			if (num21 != 0)
			{
				int num22 = CodedOutputStream.ComputeUInt32Size(num21);
				num22 += 2;
				num2 += num22;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num23 = unknownFields.CalculateSize();
				num2 += num23;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECB")]
		[Cpp2IlInjected.Address(RVA = "0x3443AE0", Offset = "0x34424E0", VA = "0x183443AE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FurnitureBlockerItemData other)
		{
			//Discarded unreachable code: IL_01a8
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
			int num2 = other.tool_;
			if (num2 != 0)
			{
				tool_ = num2;
			}
			int num3 = other.upgrade_;
			if (num3 != 0)
			{
				upgrade_ = num3;
			}
			int num4 = other.defaultRewardItemID_;
			if (num4 != 0)
			{
				defaultRewardItemID_ = num4;
			}
			int num5 = other.replaceBy_;
			if (num5 != 0)
			{
				replaceBy_ = num5;
			}
			int num6 = other.rewardLootTableItemID_;
			if (num6 != 0)
			{
				rewardLootTableItemID_ = num6;
			}
			if ((long)other.gridEditRestriction_ != 0)
			{
				GridEditRestriction gridEditRestriction2 = default(GridEditRestriction);
				if (gridEditRestriction_ == null)
				{
					GridEditRestriction gridEditRestriction = (gridEditRestriction_ = new GridEditRestriction());
					gridEditRestriction2 = gridEditRestriction_;
				}
				GridEditRestriction other3 = other.gridEditRestriction_;
				gridEditRestriction2.MergeFrom(other3);
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

		[Cpp2IlInjected.Token(Token = "0x6001ECC")]
		[Cpp2IlInjected.Address(RVA = "0x34437C0", Offset = "0x34421C0", VA = "0x1834437C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01d1
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 56)
			{
				goto IL_00ef;
			}
			if ((int)num <= 88)
			{
				goto IL_008b;
			}
			if ((int)num > 112)
			{
				if (num == 114)
				{
					goto IL_0072;
				}
				if (num != 7992)
				{
					goto IL_01ba;
				}
				int num2 = (int)(glotID_ = (uint)input.ReadInt32());
			}
			if (num == 98)
			{
				GridEditRestriction gridEditRestriction = gridEditRestriction_;
				if (gridEditRestriction == null)
				{
					GridEditRestriction gridEditRestriction2 = (gridEditRestriction_ = new GridEditRestriction());
				}
				input.ReadMessage(gridEditRestriction);
			}
			if (num == 112)
			{
				goto IL_0072;
			}
			goto IL_01ba;
			IL_01ba:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_0072:
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_008b;
			IL_008b:
			int num4 = default(int);
			if ((int)num > 72)
			{
				int num3 = default(int);
				if (num == 80)
				{
					num3 = (replaceBy_ = input.ReadInt32());
				}
				if (num3 != 88)
				{
					goto IL_01ba;
				}
				num4 = (rewardLootTableItemID_ = input.ReadInt32());
			}
			int num5 = default(int);
			if (num4 == 64)
			{
				num5 = (upgrade_ = input.ReadInt32());
			}
			if (num5 == 72)
			{
				int num6 = (defaultRewardItemID_ = input.ReadInt32());
				goto IL_00ef;
			}
			goto IL_01ba;
			IL_00ef:
			string text4 = default(string);
			if ((int)num > 26)
			{
				int num7 = default(int);
				if ((int)num > 42)
				{
					GridAreaData gridAreaData = default(GridAreaData);
					if (num == 50)
					{
						GridAreaData builder = default(GridAreaData);
						if (gridAreaData_ == null)
						{
							gridAreaData = (gridAreaData_ = new GridAreaData());
							builder = gridAreaData_;
						}
						input.ReadMessage(builder);
					}
					if ((long)gridAreaData != 56)
					{
						goto IL_01ba;
					}
					num7 = (tool_ = input.ReadInt32());
				}
				string text2 = default(string);
				if (num7 == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_01ba;
				}
				text4 = (PrefabAddress = input.ReadString());
			}
			int num8 = default(int);
			if ((long)text4 == 8)
			{
				num8 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num8 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_01ba;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECD")]
		[Cpp2IlInjected.Address(RVA = "0x34432D0", Offset = "0x3441CD0", VA = "0x1834432D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 13)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECE")]
		[Cpp2IlInjected.Address(RVA = "0x3443EA0", Offset = "0x34428A0", VA = "0x183443EA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_002c, IL_0034, IL_003c, IL_0044, IL_005c, IL_0062, IL_0068, IL_006e, IL_0074, IL_007a, IL_0080
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_005b: Expected I4, but got O
			if (fieldNumber - 1 <= 13)
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

		[Cpp2IlInjected.Token(Token = "0x6001ECF")]
		[Cpp2IlInjected.Address(RVA = "0x3442780", Offset = "0x3441180", VA = "0x183442780", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_002e
			//IL_0010: Expected I4, but got I8
			//IL_002d: Expected I4, but got I8
			if (fieldNumber - 1 <= 13)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED1")]
		[Cpp2IlInjected.Address(RVA = "0x3442970", Offset = "0x3441370", VA = "0x183442970", Slot = "20")]
		IItemData IItemData.Clone()
		{
			FurnitureBlockerItemData furnitureBlockerItemData = new FurnitureBlockerItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED7")]
		[Cpp2IlInjected.Address(RVA = "0x3443660", Offset = "0x3442060", VA = "0x183443660")]
		public static bool IsValidBlockerReward(Item item)
		{
			//Discarded unreachable code: IL_0016
			int itemID = item.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
			if (gridPlaceableItemData != null)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED8")]
		[Cpp2IlInjected.Address(RVA = "0x34429D0", Offset = "0x34413D0", VA = "0x1834429D0", Slot = "25")]
		public void DataValidation(DataValidation.Context context)
		{
			int num = tool_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				context.AddInvalidMemberError("Cannot be None", "Tool");
			}
			long num2 = Convert.ToInt64((uint)upgrade_);
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num3 = Convert.ToInt64((uint)upgrade_);
				UpgradeToolItemData upgradeToolItemData = default(UpgradeToolItemData);
				Item toolItem = upgradeToolItemData.ToolItem;
				int num4 = tool_;
				bool flag2 = default(bool);
				if (flag2)
				{
					context.AddInvalidMemberError("Tool & Upgrade mismatch", "Upgrade");
				}
			}
			int num5 = replaceBy_;
			bool flag3 = default(bool);
			if (!flag3)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			long num6 = Convert.ToInt64((uint)replaceBy_);
			IItemData itemData = default(IItemData);
			if (itemData == null)
			{
				context.AddInvalidMemberError("Is not a IGridPlaceableItemData", "ReplaceBy");
				return;
			}
			bool flag4 = default(bool);
			while (flag4)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EDA")]
		[Cpp2IlInjected.Address(RVA = "0x34446A0", Offset = "0x34430A0", VA = "0x1834446A0")]
		static FurnitureBlockerItemData()
		{
			//Discarded unreachable code: IL_0032
			//IL_002b: Expected O, but got I4
			Func<FurnitureBlockerItemData> func = default(Func<FurnitureBlockerItemData>);
			_parser = (MessageParser<FurnitureBlockerItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<FurnitureBlockerItemData>)(object)FieldCodec.ForInt32(114u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<FurnitureBlockerItemData>)(object)array;
		}
	}
}
