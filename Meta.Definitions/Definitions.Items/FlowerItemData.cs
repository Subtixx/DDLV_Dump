using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000386")]
	public sealed class FlowerItemData : IMessage<FlowerItemData>, IMessage, IEquatable<FlowerItemData>, IDeepCloneable<FlowerItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IBackpackItem, ISellable, IGridPlaceableItemData, IHasTags, IGridStateDataProvider, IIsMissionItem, IUndiggable, IHasExtraGiftFriendship, ICollectionItem, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001209")]
		private static readonly MessageParser<FlowerItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400120A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400120B")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400120C")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x400120D")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400120E")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400120F")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001210")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001211")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001212")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001213")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001214")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001215")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001216")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4001217")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001218")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001219")]
		public const int TagsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x400121A")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400121B")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400121C")]
		public const int RarityFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400121D")]
		private FlowerRarity rarity_;

		[Cpp2IlInjected.Token(Token = "0x400121E")]
		public const int IsMissionItemFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400121F")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4001220")]
		public const int UnsellableFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4001221")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x4001222")]
		public const int UndiggableFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4001223")]
		private bool undiggable_;

		[Cpp2IlInjected.Token(Token = "0x4001224")]
		public const int ExtraGiftFriendshipFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001225")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4001226")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4001227")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4001228")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000A39")]
		[DebuggerNonUserCode]
		public static MessageParser<FlowerItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600293F")]
			[Cpp2IlInjected.Address(RVA = "0x3584900", Offset = "0x3583300", VA = "0x183584900")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A3A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002940")]
			[Cpp2IlInjected.Address(RVA = "0x3584830", Offset = "0x3583230", VA = "0x183584830")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A3B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002941")]
			[Cpp2IlInjected.Address(RVA = "0x35849C0", Offset = "0x35833C0", VA = "0x1835849C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A3C")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002946")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002947")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A3D")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002948")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002949")]
			[Cpp2IlInjected.Address(RVA = "0x3584C20", Offset = "0x3583620", VA = "0x183584C20")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A3E")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600294A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "24")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600294B")]
			[Cpp2IlInjected.Address(RVA = "0x3584B40", Offset = "0x3583540", VA = "0x183584B40")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A3F")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600294C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600294D")]
			[Cpp2IlInjected.Address(RVA = "0x3584BB0", Offset = "0x35835B0", VA = "0x183584BB0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A40")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600294E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600294F")]
			[Cpp2IlInjected.Address(RVA = "0x3584C90", Offset = "0x3583690", VA = "0x183584C90")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A41")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6002950")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "27")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002951")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A42")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6002952")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002953")]
			[Cpp2IlInjected.Address(RVA = "0x3584AD0", Offset = "0x35834D0", VA = "0x183584AD0")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A43")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002954")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "29")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A44")]
		[DebuggerNonUserCode]
		public FlowerRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6002955")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002956")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				rarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A45")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002957")]
			[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0", Slot = "31")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002958")]
			[Cpp2IlInjected.Address(RVA = "0x9765E0", Offset = "0x974FE0", VA = "0x1809765E0")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A46")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6002959")]
			[Cpp2IlInjected.Address(RVA = "0xDD7060", Offset = "0xDD5A60", VA = "0x180DD7060")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x600295A")]
			[Cpp2IlInjected.Address(RVA = "0xDD7120", Offset = "0xDD5B20", VA = "0x180DD7120")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A47")]
		[DebuggerNonUserCode]
		public bool Undiggable
		{
			[Cpp2IlInjected.Token(Token = "0x600295B")]
			[Cpp2IlInjected.Address(RVA = "0xDD7070", Offset = "0xDD5A70", VA = "0x180DD7070", Slot = "32")]
			get
			{
				return undiggable_;
			}
			[Cpp2IlInjected.Token(Token = "0x600295C")]
			[Cpp2IlInjected.Address(RVA = "0xDD7130", Offset = "0xDD5B30", VA = "0x180DD7130")]
			set
			{
				undiggable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A48")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x600295D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "33")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x600295E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A49")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x600295F")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002960")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A4A")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600296C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "34")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A4B")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600296D")]
			[Cpp2IlInjected.Address(RVA = "0x3584960", Offset = "0x3583360", VA = "0x183584960", Slot = "28")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A4C")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x600296E")]
			[Cpp2IlInjected.Address(RVA = "0x27BE680", Offset = "0x27BD080", VA = "0x1827BE680", Slot = "35")]
			get
			{
				return !isMissionItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A4D")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x600296F")]
			[Cpp2IlInjected.Address(RVA = "0x27BE690", Offset = "0x27BD090", VA = "0x1827BE690", Slot = "26")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002942")]
		[Cpp2IlInjected.Address(RVA = "0x35846E0", Offset = "0x35830E0", VA = "0x1835846E0")]
		[DebuggerNonUserCode]
		public FlowerItemData()
		{
			//Discarded unreachable code: IL_0068
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			gridAreaData_.AcceptedFloorTypesFlag = 5375;
		}

		[Cpp2IlInjected.Token(Token = "0x6002943")]
		[Cpp2IlInjected.Address(RVA = "0x35839D0", Offset = "0x35823D0", VA = "0x1835839D0")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_001e
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			gridAreaData_.AcceptedFloorTypesFlag = 5375;
		}

		[Cpp2IlInjected.Token(Token = "0x6002944")]
		[Cpp2IlInjected.Address(RVA = "0x3584460", Offset = "0x3582E60", VA = "0x183584460")]
		[DebuggerNonUserCode]
		public FlowerItemData(FlowerItemData other)
		{
			//IL_00d4: Expected O, but got I4
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			gridAreaData_.AcceptedFloorTypesFlag = 5375;
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
			FlowerRarity flowerRarity = (rarity_ = other.rarity_);
			bool flag = (isMissionItem_ = other.isMissionItem_);
			bool flag2 = (unsellable_ = other.unsellable_);
			bool flag3 = (undiggable_ = other.undiggable_);
			int num3 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			uint num4 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002945")]
		[Cpp2IlInjected.Address(RVA = "0x3582C70", Offset = "0x3581670", VA = "0x183582C70", Slot = "10")]
		[DebuggerNonUserCode]
		public FlowerItemData Clone()
		{
			return new FlowerItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002961")]
		[Cpp2IlInjected.Address(RVA = "0x3582DF0", Offset = "0x35817F0", VA = "0x183582DF0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(FlowerItemData).TypeHandle)
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
										if (flag6 && rarity_ == (flag6 ? FlowerRarity.Uncommon : FlowerRarity.Common) && isMissionItem_ == flag6 && unsellable_ == flag6 && undiggable_ == flag6 && extraGiftFriendship_ == (flag6 ? 1 : 0) && glotID_ == (flag6 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x6002962")]
		[Cpp2IlInjected.Address(RVA = "0x3582FA0", Offset = "0x35819A0", VA = "0x183582FA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FlowerItemData other)
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
												FlowerRarity flowerRarity = other.rarity_;
												if (rarity_ == flowerRarity)
												{
													bool flag = other.isMissionItem_;
													if (isMissionItem_ == flag)
													{
														bool flag2 = other.unsellable_;
														if (unsellable_ == flag2)
														{
															bool flag3 = other.undiggable_;
															if (undiggable_ == flag3)
															{
																int num2 = other.extraGiftFriendship_;
																if (extraGiftFriendship_ == num2)
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

		[Cpp2IlInjected.Token(Token = "0x6002963")]
		[Cpp2IlInjected.Address(RVA = "0x3583320", Offset = "0x3581D20", VA = "0x183583320", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00fd
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
			if (rarity_ != 0)
			{
			}
			if (isMissionItem_)
			{
			}
			if (unsellable_)
			{
			}
			if (undiggable_)
			{
			}
			if (extraGiftFriendship_ != 0)
			{
			}
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

		[Cpp2IlInjected.Token(Token = "0x6002964")]
		[Cpp2IlInjected.Address(RVA = "0x3583EE0", Offset = "0x35828E0", VA = "0x183583EE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002965")]
		[Cpp2IlInjected.Address(RVA = "0x3583F40", Offset = "0x3582940", VA = "0x183583F40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0178
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
			if (rarity_ != 0)
			{
			}
			if (isMissionItem_)
			{
				bool value8 = isMissionItem_;
				output.WriteBool(value8);
			}
			if (extraGiftFriendship_ != 0)
			{
				int value9 = extraGiftFriendship_;
				output.WriteInt32(value9);
			}
			if (unsellable_)
			{
				bool value10 = unsellable_;
				output.WriteBool(value10);
			}
			if (undiggable_)
			{
				bool value11 = undiggable_;
				output.WriteBool(value11);
			}
			if (glotID_ != 0)
			{
				uint value12 = glotID_;
				output.WriteUInt32(value12);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002966")]
		[Cpp2IlInjected.Address(RVA = "0x3582770", Offset = "0x3581170", VA = "0x183582770", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0190
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
			FlowerRarity flowerRarity = rarity_;
			num2 += num10;
			if (flowerRarity != 0)
			{
				int num11 = CodedOutputStream.ComputeEnumSize((int)flowerRarity);
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

		[Cpp2IlInjected.Token(Token = "0x6002967")]
		[Cpp2IlInjected.Address(RVA = "0x3583520", Offset = "0x3581F20", VA = "0x183583520", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FlowerItemData other)
		{
			//Discarded unreachable code: IL_0186
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
			FlowerRarity flowerRarity = other.rarity_;
			if (flowerRarity != 0)
			{
				rarity_ = flowerRarity;
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
			bool flag3 = other.undiggable_;
			if (flag3)
			{
				undiggable_ = flag3;
			}
			int num2 = other.extraGiftFriendship_;
			if (num2 != 0)
			{
				extraGiftFriendship_ = num2;
			}
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002968")]
		[Cpp2IlInjected.Address(RVA = "0x35836F0", Offset = "0x35820F0", VA = "0x1835836F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01b8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 58)
			{
				if ((int)num > 80)
				{
					if ((int)num > 96)
					{
						if (num == 104)
						{
							bool flag = (undiggable_ = input.ReadBool());
						}
						if (num != 7992)
						{
							goto IL_01a1;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 88)
					{
						num3 = (extraGiftFriendship_ = input.ReadInt32());
					}
					if (num3 != 96)
					{
						goto IL_01a1;
					}
					bool flag2 = (unsellable_ = input.ReadBool());
				}
				bool flag3 = default(bool);
				if ((int)num > 66)
				{
					int num4 = default(int);
					if (num == 72)
					{
						num4 = (int)(rarity_ = (FlowerRarity)input.ReadInt32());
					}
					if (num4 != 80)
					{
						goto IL_01a1;
					}
					flag3 = (isMissionItem_ = input.ReadBool());
				}
				if (!flag3)
				{
					goto IL_01a1;
				}
				RepeatedField<int> repeatedField = tags_;
				FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			}
			string text6 = default(string);
			if ((int)num > 26)
			{
				string text2 = default(string);
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
						goto IL_01a1;
					}
					text2 = (Description = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_01a1;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text6 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			string text8 = default(string);
			if (num5 == 18)
			{
				text8 = (Name = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (DisplayName = input.ReadString());
			}
			goto IL_01a1;
			IL_01a1:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002969")]
		[Cpp2IlInjected.Address(RVA = "0x3583100", Offset = "0x3581B00", VA = "0x183583100", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
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

		[Cpp2IlInjected.Token(Token = "0x600296A")]
		[Cpp2IlInjected.Address(RVA = "0x3583A50", Offset = "0x3582450", VA = "0x183583A50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0031, IL_0039, IL_0041, IL_0049, IL_0051, IL_0069, IL_006f, IL_0075, IL_007b, IL_0081, IL_0087, IL_008d
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0068: Expected I4, but got O
			if (fieldNumber - 1 <= 12)
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

		[Cpp2IlInjected.Token(Token = "0x600296B")]
		[Cpp2IlInjected.Address(RVA = "0x3582A90", Offset = "0x3581490", VA = "0x183582A90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_002f
			//IL_0010: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			if (fieldNumber - 1 <= 12)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002970")]
		[Cpp2IlInjected.Address(RVA = "0x3582D90", Offset = "0x3581790", VA = "0x183582D90")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			new FlowerData().dry_ = false;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002971")]
		[Cpp2IlInjected.Address(RVA = "0x3582CD0", Offset = "0x35816D0", VA = "0x183582CD0", Slot = "36")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001c
			int acceptedFloorTypesFlag = gridAreaData_.AcceptedFloorTypesFlag;
			bool flag = default(bool);
			if (!flag)
			{
				context.AddError("Floor Type Preset is not set to Light Item.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002972")]
		[Cpp2IlInjected.Address(RVA = "0x3582C70", Offset = "0x3581670", VA = "0x183582C70", Slot = "20")]
		IItemData IItemData.Clone()
		{
			FlowerItemData flowerItemData = new FlowerItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002973")]
		[Cpp2IlInjected.Address(RVA = "0x3584270", Offset = "0x3582C70", VA = "0x183584270")]
		static FlowerItemData()
		{
			//Discarded unreachable code: IL_0031
			//IL_0029: Expected O, but got I4
			Func<FlowerItemData> func = default(Func<FlowerItemData>);
			_parser = (MessageParser<FlowerItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<FlowerItemData>)(object)FieldCodec.ForInt32(66u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			ReadOnlyCollection<(TagItemType, int?)> parser = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<FlowerItemData>)(object)parser;
		}

		[Cpp2IlInjected.Token(Token = "0x6002974")]
		[Cpp2IlInjected.Address(RVA = "0x3582D90", Offset = "0x3581790", VA = "0x183582D90", Slot = "30")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			new FlowerData().dry_ = false;
			throw new NullReferenceException();
		}
	}
}
