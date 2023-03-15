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
	[Cpp2IlInjected.Token(Token = "0x20002AE")]
	public sealed class MineralItemData : IMessage<MineralItemData>, IMessage, IEquatable<MineralItemData>, IDeepCloneable<MineralItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IHasTags, IBackpackItem, ISellable, IIsMissionItem, IHasExtraGiftFriendship, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4000B5C")]
		private static readonly MessageParser<MineralItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000B5D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000B5E")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B5F")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000B60")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B61")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B62")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B63")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B64")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B65")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B66")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B67")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B68")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B69")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000B6A")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B6B")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B6C")]
		public const int TagsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000B6D")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000B6E")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000B6F")]
		public const int SpecialMiningRockMaterialAddressFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000B70")]
		private string specialMiningRockMaterialAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B71")]
		public const int IsMissionItemFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000B72")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4000B73")]
		public const int UnsellableFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000B74")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x4000B75")]
		public const int ExtraGiftFriendshipFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000B76")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4000B77")]
		public const int IsShinyFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000B78")]
		private bool isShiny_;

		[Cpp2IlInjected.Token(Token = "0x4000B79")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000B7A")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000B7B")]
		public static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x1700061B")]
		[DebuggerNonUserCode]
		public static MessageParser<MineralItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001BBE")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C8D0", Offset = "0x1D2B2D0", VA = "0x181D2C8D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001BBF")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C800", Offset = "0x1D2B200", VA = "0x181D2C800")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC0")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C990", Offset = "0x1D2B390", VA = "0x181D2C990", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061E")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BC6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061F")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BC8")]
			[Cpp2IlInjected.Address(RVA = "0x1D2CBF0", Offset = "0x1D2B5F0", VA = "0x181D2CBF0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000620")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "27")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BCA")]
			[Cpp2IlInjected.Address(RVA = "0x1D2CB10", Offset = "0x1D2B510", VA = "0x181D2CB10")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000621")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001BCB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BCC")]
			[Cpp2IlInjected.Address(RVA = "0x1D2CB80", Offset = "0x1D2B580", VA = "0x181D2CB80")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000622")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001BCD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BCE")]
			[Cpp2IlInjected.Address(RVA = "0x1D2CC60", Offset = "0x1D2B660", VA = "0x181D2CC60")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000623")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001BCF")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BD0")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000624")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001BD1")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "28")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BD2")]
			[Cpp2IlInjected.Address(RVA = "0x1D2CAA0", Offset = "0x1D2B4A0", VA = "0x181D2CAA0")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000625")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001BD3")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "25")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000626")]
		[DebuggerNonUserCode]
		public string SpecialMiningRockMaterialAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001BD4")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return specialMiningRockMaterialAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BD5")]
			[Cpp2IlInjected.Address(RVA = "0x1D2CCD0", Offset = "0x1D2B6D0", VA = "0x181D2CCD0")]
			set
			{
				string text = (specialMiningRockMaterialAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000627")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001BD6")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0", Slot = "30")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BD7")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000628")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6001BD8")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5F0", Offset = "0xE38FF0", VA = "0x180E3A5F0")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BD9")]
			[Cpp2IlInjected.Address(RVA = "0x1A7B2C0", Offset = "0x1A79CC0", VA = "0x181A7B2C0")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000629")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6001BDA")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "31")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BDB")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062A")]
		[DebuggerNonUserCode]
		public bool IsShiny
		{
			[Cpp2IlInjected.Token(Token = "0x6001BDC")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0")]
			get
			{
				return isShiny_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BDD")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
			set
			{
				isShiny_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062B")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001BDE")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BDF")]
			[Cpp2IlInjected.Address(RVA = "0x960750", Offset = "0x95F150", VA = "0x180960750", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062C")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001BEB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "32")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062D")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001BEC")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C7E0", Offset = "0x1D2B1E0", VA = "0x181D2C7E0", Slot = "33")]
			get
			{
				return !isMissionItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062E")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001BED")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C7F0", Offset = "0x1D2B1F0", VA = "0x181D2C7F0", Slot = "29")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062F")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001BEE")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C930", Offset = "0x1D2B330", VA = "0x181D2C930", Slot = "24")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BC1")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C6A0", Offset = "0x1D2B0A0", VA = "0x181D2C6A0")]
		[DebuggerNonUserCode]
		public MineralItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BC2")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B980", Offset = "0x1D2A380", VA = "0x181D2B980")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BC3")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C410", Offset = "0x1D2AE10", VA = "0x181D2C410")]
		[DebuggerNonUserCode]
		public MineralItemData(MineralItemData other)
		{
			//IL_00cf: Expected O, but got I4
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
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			string text6 = (specialMiningRockMaterialAddress_ = other.specialMiningRockMaterialAddress_);
			bool flag = (isMissionItem_ = other.isMissionItem_);
			bool flag2 = (unsellable_ = other.unsellable_);
			int num3 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			bool flag3 = (isShiny_ = other.isShiny_);
			uint num4 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BC4")]
		[Cpp2IlInjected.Address(RVA = "0x1D2ACF0", Offset = "0x1D296F0", VA = "0x181D2ACF0", Slot = "10")]
		[DebuggerNonUserCode]
		public MineralItemData Clone()
		{
			return new MineralItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE0")]
		[Cpp2IlInjected.Address(RVA = "0x1D2AED0", Offset = "0x1D298D0", VA = "0x181D2AED0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(MineralItemData).TypeHandle)
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
									if (!flag5)
									{
										RepeatedField<int> repeatedField = tags_;
										bool flag6 = default(bool);
										if (flag6)
										{
											string text6 = specialMiningRockMaterialAddress_;
											bool flag7 = default(bool);
											if (!flag7 && isMissionItem_ == flag7 && unsellable_ == flag7 && extraGiftFriendship_ == (flag7 ? 1 : 0) && isShiny_ == flag7 && glotID_ == (flag7 ? 1u : 0u))
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
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE1")]
		[Cpp2IlInjected.Address(RVA = "0x1D2AD50", Offset = "0x1D29750", VA = "0x181D2AD50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MineralItemData other)
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
											RepeatedField<int> repeatedField = tags_;
											RepeatedField<int> repeatedField2 = other.tags_;
											if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
											{
												string text6 = other.specialMiningRockMaterialAddress_;
												if (!(specialMiningRockMaterialAddress_ != text6))
												{
													bool flag = other.isMissionItem_;
													if (isMissionItem_ == flag)
													{
														bool flag2 = other.unsellable_;
														if (unsellable_ == flag2)
														{
															int num2 = other.extraGiftFriendship_;
															if (extraGiftFriendship_ == num2)
															{
																bool flag3 = other.isShiny_;
																if (isShiny_ == flag3)
																{
																	uint num3 = other.glotID_;
																	if (glotID_ == num3)
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE2")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B290", Offset = "0x1D29C90", VA = "0x181D2B290", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_010f
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
			int hashCode7 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			string text6 = specialMiningRockMaterialAddress_;
			if (text6.m_stringLength != 0)
			{
				int hashCode8 = text6.GetHashCode();
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
			if (isShiny_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE3")]
		[Cpp2IlInjected.Address(RVA = "0x1D2BE70", Offset = "0x1D2A870", VA = "0x181D2BE70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE4")]
		[Cpp2IlInjected.Address(RVA = "0x1D2BED0", Offset = "0x1D2A8D0", VA = "0x181D2BED0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_018d
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
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (specialMiningRockMaterialAddress_.m_stringLength != 0)
			{
				string value8 = specialMiningRockMaterialAddress_;
				output.WriteString(value8);
			}
			if (isMissionItem_)
			{
				bool value9 = isMissionItem_;
				output.WriteBool(value9);
			}
			if (extraGiftFriendship_ != 0)
			{
				int value10 = extraGiftFriendship_;
				output.WriteInt32(value10);
			}
			if (isShiny_)
			{
				bool value11 = isShiny_;
				output.WriteBool(value11);
			}
			if (unsellable_)
			{
				bool value12 = unsellable_;
				output.WriteBool(value12);
			}
			if (glotID_ != 0)
			{
				uint value13 = glotID_;
				output.WriteUInt32(value13);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE5")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A7D0", Offset = "0x1D291D0", VA = "0x181D2A7D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0195
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
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			string text6 = specialMiningRockMaterialAddress_;
			num2 += num10;
			if (text6.m_stringLength != 0)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text6);
				num11++;
				num2 += num11;
			}
			int num12 = extraGiftFriendship_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			uint num14 = glotID_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeUInt32Size(num14);
				num15 += 2;
				num2 += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num2 += num16;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE6")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B4A0", Offset = "0x1D29EA0", VA = "0x181D2B4A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MineralItemData other)
		{
			//Discarded unreachable code: IL_018b
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
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			string text6 = other.specialMiningRockMaterialAddress_;
			if (text6.m_stringLength != 0)
			{
				SpecialMiningRockMaterialAddress = text6;
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
			int num2 = other.extraGiftFriendship_;
			if (num2 != 0)
			{
				extraGiftFriendship_ = num2;
			}
			bool flag3 = other.isShiny_;
			if (flag3)
			{
				isShiny_ = flag3;
			}
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE7")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B690", Offset = "0x1D2A090", VA = "0x181D2B690", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01ba
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 58)
			{
				if ((int)num > 88)
				{
					if ((int)num > 104)
					{
						if (num == 112)
						{
							bool flag = (unsellable_ = input.ReadBool());
						}
						if (num != 7992)
						{
							goto IL_01a3;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 96)
					{
						num3 = (extraGiftFriendship_ = input.ReadInt32());
					}
					if (num3 != 104)
					{
						goto IL_01a3;
					}
					bool flag2 = (isShiny_ = input.ReadBool());
				}
				bool flag3 = default(bool);
				if ((int)num > 74)
				{
					string text2 = default(string);
					if (num == 82)
					{
						text2 = (SpecialMiningRockMaterialAddress = input.ReadString());
					}
					if ((long)text2 != 88)
					{
						goto IL_01a3;
					}
					flag3 = (isMissionItem_ = input.ReadBool());
				}
				if (!flag3)
				{
					goto IL_01a3;
				}
				RepeatedField<int> repeatedField = tags_;
				FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			}
			string text8 = default(string);
			if ((int)num > 26)
			{
				string text4 = default(string);
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
					if ((long)gridAreaData != 58)
					{
						goto IL_01a3;
					}
					text4 = (Description = input.ReadString());
				}
				string text6 = default(string);
				if ((long)text4 == 34)
				{
					text6 = (IconAddress = input.ReadString());
				}
				if ((long)text6 != 42)
				{
					goto IL_01a3;
				}
				text8 = (PrefabAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text8 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			string text10 = default(string);
			if (num4 == 18)
			{
				text10 = (Name = input.ReadString());
			}
			if ((long)text10 == 26)
			{
				string text12 = (DisplayName = input.ReadString());
			}
			goto IL_01a3;
			IL_01a3:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE8")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B090", Offset = "0x1D29A90", VA = "0x181D2B090", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 13)
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

		[Cpp2IlInjected.Token(Token = "0x6001BE9")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B9E0", Offset = "0x1D2A3E0", VA = "0x181D2B9E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0025, IL_0032, IL_003a, IL_0042, IL_004a, IL_0062, IL_0068, IL_006e, IL_0074, IL_007a, IL_0080, IL_0086
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0061: Expected I4, but got O
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

		[Cpp2IlInjected.Token(Token = "0x6001BEA")]
		[Cpp2IlInjected.Address(RVA = "0x1D2AB00", Offset = "0x1D29500", VA = "0x181D2AB00", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_002f
			//IL_0010: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			if (fieldNumber - 1 <= 13)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BEF")]
		[Cpp2IlInjected.Address(RVA = "0x1D2ACF0", Offset = "0x1D296F0", VA = "0x181D2ACF0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			MineralItemData mineralItemData = new MineralItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BF0")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C210", Offset = "0x1D2AC10", VA = "0x181D2C210")]
		static MineralItemData()
		{
			//Discarded unreachable code: IL_0032
			//IL_002b: Expected O, but got I4
			Func<MineralItemData> func = default(Func<MineralItemData>);
			_parser = (MessageParser<MineralItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<MineralItemData>)(object)FieldCodec.ForInt32(74u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<MineralItemData>)(object)array;
		}
	}
}
