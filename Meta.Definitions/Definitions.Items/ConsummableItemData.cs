using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002AB")]
	public sealed class ConsummableItemData : IMessage<ConsummableItemData>, IMessage, IEquatable<ConsummableItemData>, IDeepCloneable<ConsummableItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IBackpackItem, ISellable, IIsMissionItem, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20002AC")]
		public enum ContentOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000B58")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000B59")]
			ItemTypeSelector = 10,
			[Cpp2IlInjected.Token(Token = "0x4000B5A")]
			DefaultItem = 11
		}

		[Cpp2IlInjected.Token(Token = "0x4000B3D")]
		private static readonly MessageParser<ConsummableItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000B3E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000B3F")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B40")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000B41")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B42")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B43")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B44")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B45")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B46")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B47")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B48")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B49")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B4A")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000B4B")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B4C")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B4D")]
		public const int ItemTypeSelectorFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000B4E")]
		public const int DefaultItemFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000B4F")]
		public const int IsMissionItemFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000B50")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4000B51")]
		public const int UnsellableFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000B52")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x4000B53")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000B54")]
		private uint glotID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000B55")]
		private object content_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000B56")]
		private ContentOneofCase contentCase_;

		[Cpp2IlInjected.Token(Token = "0x17000608")]
		[DebuggerNonUserCode]
		public static MessageParser<ConsummableItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001B82")]
			[Cpp2IlInjected.Address(RVA = "0x327C3B0", Offset = "0x327ADB0", VA = "0x18327C3B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000609")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001B83")]
			[Cpp2IlInjected.Address(RVA = "0x327C280", Offset = "0x327AC80", VA = "0x18327C280")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001B84")]
			[Cpp2IlInjected.Address(RVA = "0x327C410", Offset = "0x327AE10", VA = "0x18327C410", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060B")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001B89")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B8A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060C")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001B8B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B8C")]
			[Cpp2IlInjected.Address(RVA = "0x327C6B0", Offset = "0x327B0B0", VA = "0x18327C6B0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060D")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001B8D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "27")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B8E")]
			[Cpp2IlInjected.Address(RVA = "0x327C5D0", Offset = "0x327AFD0", VA = "0x18327C5D0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060E")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B90")]
			[Cpp2IlInjected.Address(RVA = "0x327C640", Offset = "0x327B040", VA = "0x18327C640")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060F")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B91")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B92")]
			[Cpp2IlInjected.Address(RVA = "0x327C720", Offset = "0x327B120", VA = "0x18327C720")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000610")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001B93")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "25")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B94")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000611")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001B95")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "28")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B96")]
			[Cpp2IlInjected.Address(RVA = "0x327C560", Offset = "0x327AF60", VA = "0x18327C560")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000612")]
		[DebuggerNonUserCode]
		public ItemTypeSelector ItemTypeSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6001B97")]
			[Cpp2IlInjected.Address(RVA = "0x327C350", Offset = "0x327AD50", VA = "0x18327C350")]
			get
			{
				int num = 0;
				if (contentCase_ == ContentOneofCase.ItemTypeSelector)
				{
					object obj = content_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001B98")]
			[Cpp2IlInjected.Address(RVA = "0x1D38150", Offset = "0x1D36B50", VA = "0x181D38150")]
			set
			{
				content_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000613")]
		[DebuggerNonUserCode]
		public ItemInstance DefaultItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B99")]
			[Cpp2IlInjected.Address(RVA = "0x327C220", Offset = "0x327AC20", VA = "0x18327C220")]
			get
			{
				int num = 0;
				if (contentCase_ == ContentOneofCase.DefaultItem)
				{
					object obj = content_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001B9A")]
			[Cpp2IlInjected.Address(RVA = "0x327C520", Offset = "0x327AF20", VA = "0x18327C520")]
			set
			{
				content_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000614")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B9B")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "30")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B9C")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000615")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6001B9D")]
			[Cpp2IlInjected.Address(RVA = "0xFAD850", Offset = "0xFAC250", VA = "0x180FAD850")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B9E")]
			[Cpp2IlInjected.Address(RVA = "0x2191C60", Offset = "0x2190660", VA = "0x182191C60")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000616")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001B9F")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830", Slot = "23")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BA0")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10", Slot = "24")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000617")]
		[DebuggerNonUserCode]
		public ContentOneofCase ContentCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001BA1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return contentCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000618")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001BB0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "26")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000619")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001BB1")]
			[Cpp2IlInjected.Address(RVA = "0x3159340", Offset = "0x3157D40", VA = "0x183159340", Slot = "29")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061A")]
		public ItemType ContentItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6001BB6")]
			[Cpp2IlInjected.Address(RVA = "0x327C130", Offset = "0x327AB30", VA = "0x18327C130")]
			get
			{
				ContentOneofCase contentOneofCase = contentCase_;
				if (contentOneofCase == ContentOneofCase.ItemTypeSelector)
				{
					ContentOneofCase contentOneofCase2 = contentCase_;
					if (content_ == null)
					{
						goto IL_0037;
					}
				}
				if (contentOneofCase == ContentOneofCase.DefaultItem)
				{
					ContentOneofCase contentOneofCase3 = contentCase_;
					ItemType result = default(ItemType);
					if (content_ != null)
					{
						return result;
					}
					throw new InvalidCastException();
				}
				int num = 0;
				goto IL_0037;
				IL_0037:
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B85")]
		[Cpp2IlInjected.Address(RVA = "0x327C050", Offset = "0x327AA50", VA = "0x18327C050")]
		[DebuggerNonUserCode]
		public ConsummableItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B86")]
		[Cpp2IlInjected.Address(RVA = "0x327B180", Offset = "0x3279B80", VA = "0x18327B180")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B87")]
		[Cpp2IlInjected.Address(RVA = "0x327BD90", Offset = "0x327A790", VA = "0x18327BD90")]
		[DebuggerNonUserCode]
		public ConsummableItemData(ConsummableItemData other)
		{
			//IL_00b5: Expected O, but got I4
			//IL_0141: Expected I4, but got O
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData2 = other.gridAreaData_;
			int num2 = 0;
			if (gridAreaData2 != null)
			{
				GridAreaData gridAreaData3 = gridAreaData2.Clone();
			}
			gridAreaData_ = (GridAreaData)num2;
			string text5 = (description_ = other.description_);
			bool flag = (isMissionItem_ = other.isMissionItem_);
			bool flag2 = (unsellable_ = other.unsellable_);
			uint num3 = (glotID_ = other.glotID_);
			ItemTypeSelector itemTypeSelector = default(ItemTypeSelector);
			if (other.contentCase_ == ContentOneofCase.ItemTypeSelector)
			{
				ContentOneofCase contentOneofCase = other.contentCase_;
				if (other.content_ == null)
				{
					throw new InvalidCastException();
				}
				content_ = itemTypeSelector;
			}
			if ((long)itemTypeSelector == 11)
			{
				ContentOneofCase contentOneofCase2 = other.contentCase_;
				if (other.content_ == null)
				{
					throw new InvalidCastException();
				}
				ItemInstance itemInstance = default(ItemInstance);
				content_ = itemInstance;
				contentCase_ = (ContentOneofCase)itemInstance;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B88")]
		[Cpp2IlInjected.Address(RVA = "0x3279CC0", Offset = "0x32786C0", VA = "0x183279CC0", Slot = "10")]
		[DebuggerNonUserCode]
		public ConsummableItemData Clone()
		{
			return new ConsummableItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BA2")]
		[Cpp2IlInjected.Address(RVA = "0x1D36160", Offset = "0x1D34B60", VA = "0x181D36160")]
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			//IL_0010: Expected O, but got I4
			content_ = (contentCase_ = ContentOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BA3")]
		[Cpp2IlInjected.Address(RVA = "0x327A230", Offset = "0x3278C30", VA = "0x18327A230", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(ConsummableItemData).TypeHandle)
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
									ItemTypeSelector objB = default(ItemTypeSelector);
									if (!flag5 && object.Equals(ItemTypeSelector, objB))
									{
										ItemInstance objB2 = default(ItemInstance);
										bool flag6 = object.Equals(DefaultItem, objB2);
										if (flag6 && isMissionItem_ == flag6 && unsellable_ == flag6 && glotID_ == (flag6 ? 1u : 0u) && contentCase_ == (flag6 ? ((ContentOneofCase)1) : ContentOneofCase.None))
										{
											return object.Equals(_unknownFields, objB2);
										}
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BA4")]
		[Cpp2IlInjected.Address(RVA = "0x327A3E0", Offset = "0x3278DE0", VA = "0x18327A3E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConsummableItemData other)
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
											ItemTypeSelector itemTypeSelector = ItemTypeSelector;
											ItemTypeSelector itemTypeSelector2 = other.ItemTypeSelector;
											if (object.Equals(itemTypeSelector, itemTypeSelector2))
											{
												ItemInstance defaultItem = DefaultItem;
												ItemInstance defaultItem2 = other.DefaultItem;
												if (object.Equals(defaultItem, defaultItem2))
												{
													bool flag = other.isMissionItem_;
													if (isMissionItem_ == flag)
													{
														bool flag2 = other.unsellable_;
														if (unsellable_ == flag2)
														{
															uint num2 = other.glotID_;
															if (glotID_ == num2)
															{
																ContentOneofCase contentOneofCase = other.contentCase_;
																if (contentCase_ == contentOneofCase)
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
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BA5")]
		[Cpp2IlInjected.Address(RVA = "0x327A760", Offset = "0x3279160", VA = "0x18327A760", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_011d
			do
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
				string text5 = description_;
				if (text5.m_stringLength != num2)
				{
					int hashCode6 = text5.GetHashCode();
				}
			}
			while (contentCase_ != ContentOneofCase.ItemTypeSelector);
			object obj = content_;
			if (obj != null)
			{
				int hashCode7 = obj.GetHashCode();
				if (contentCase_ == ContentOneofCase.DefaultItem)
				{
					object obj2 = content_;
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode8 = obj2.GetHashCode();
				}
				if (isMissionItem_)
				{
				}
				if (unsellable_)
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
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BA6")]
		[Cpp2IlInjected.Address(RVA = "0x327B610", Offset = "0x327A010", VA = "0x18327B610", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BA7")]
		[Cpp2IlInjected.Address(RVA = "0x327B960", Offset = "0x327A360", VA = "0x18327B960", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_017d
			ContentOneofCase contentOneofCase;
			do
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
				if (description_.m_stringLength != 0)
				{
					string value7 = description_;
					output.WriteString(value7);
				}
				contentOneofCase = contentCase_;
				int num = 0;
			}
			while (contentOneofCase != ContentOneofCase.ItemTypeSelector);
			if (contentCase_ == ContentOneofCase.ItemTypeSelector)
			{
				object obj = content_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (contentCase_ == ContentOneofCase.DefaultItem && contentCase_ == ContentOneofCase.DefaultItem)
			{
				object obj2 = content_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (isMissionItem_)
			{
				bool value8 = isMissionItem_;
				output.WriteBool(value8);
			}
			if (unsellable_)
			{
				bool value9 = unsellable_;
				output.WriteBool(value9);
			}
			if (glotID_ != 0)
			{
				uint value10 = glotID_;
				output.WriteUInt32(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BA8")]
		[Cpp2IlInjected.Address(RVA = "0x3279150", Offset = "0x3277B50", VA = "0x183279150", Slot = "7")]
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
			string text5 = description_;
			if (text5.m_stringLength != num2)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num2 += num9;
			}
			if (contentCase_ == ContentOneofCase.ItemTypeSelector)
			{
				if (contentCase_ != ContentOneofCase.ItemTypeSelector)
				{
				}
				object obj = content_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num10 = default(int);
				num2 += num10;
			}
			if (contentCase_ == ContentOneofCase.DefaultItem)
			{
				if (contentCase_ == ContentOneofCase.DefaultItem)
				{
					object obj2 = content_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2++;
				int num11 = default(int);
				num2 += num11;
			}
			uint num12 = glotID_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeUInt32Size(num12);
				num13 += 2;
				num2 += num13;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
				num2 += num14;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BA9")]
		[Cpp2IlInjected.Address(RVA = "0x327AE10", Offset = "0x3279810", VA = "0x18327AE10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConsummableItemData other)
		{
			//Discarded unreachable code: IL_01ff
			//IL_01c6: Expected I4, but got O
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
			uint num2 = other.glotID_;
			if (num2 != 0)
			{
				glotID_ = num2;
			}
			if (other.contentCase_ == ContentOneofCase.ItemTypeSelector)
			{
				ContentOneofCase contentOneofCase = contentCase_;
				object obj = default(object);
				if (contentOneofCase == ContentOneofCase.ItemTypeSelector)
				{
					obj = content_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					ItemTypeSelector itemTypeSelector = (ItemTypeSelector)(content_ = new ItemTypeSelector());
					contentCase_ = contentOneofCase;
				}
				if (contentCase_ == ContentOneofCase.ItemTypeSelector)
				{
					object obj2 = content_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.contentCase_ == ContentOneofCase.ItemTypeSelector)
				{
					object obj3 = other.content_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(ItemTypeSelector).TypeHandle == 11)
			{
				if (DefaultItem == null)
				{
					contentCase_ = (ContentOneofCase)(content_ = new ItemInstance());
				}
				ItemInstance defaultItem = DefaultItem;
				ItemInstance defaultItem2 = other.DefaultItem;
				defaultItem.MergeFrom(defaultItem2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAA")]
		[Cpp2IlInjected.Address(RVA = "0x327AA80", Offset = "0x3279480", VA = "0x18327AA80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00c7: Expected I4, but got O
			//IL_0120: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 50)
			{
				if ((int)num > 90)
				{
					if (num == 120)
					{
						bool flag = (isMissionItem_ = input.ReadBool());
					}
					bool flag2 = default(bool);
					if (num == 128)
					{
						flag2 = (unsellable_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_01c9;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 58)
				{
					text2 = (Description = input.ReadString());
				}
				if ((long)text2 == 82)
				{
					ItemTypeSelector builder = new ItemTypeSelector();
					if (contentCase_ == ContentOneofCase.ItemTypeSelector)
					{
						if (contentCase_ != ContentOneofCase.ItemTypeSelector)
						{
						}
						object obj = content_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					content_ = builder;
					contentCase_ = (ContentOneofCase)typeof(ItemTypeSelector).TypeHandle;
				}
				if ((long)typeof(ItemTypeSelector).TypeHandle != 90)
				{
					goto IL_01c9;
				}
				ItemInstance builder2 = new ItemInstance();
				if (contentCase_ == ContentOneofCase.DefaultItem)
				{
					if (contentCase_ != ContentOneofCase.DefaultItem)
					{
					}
					object obj2 = content_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				content_ = builder2;
				contentCase_ = (ContentOneofCase)typeof(ItemInstance).TypeHandle;
			}
			GridAreaData gridAreaData = default(GridAreaData);
			if ((int)num > 26)
			{
				string text4 = default(string);
				if (num == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				string text6 = default(string);
				if ((long)text4 == 42)
				{
					text6 = (PrefabAddress = input.ReadString());
				}
				if ((long)text6 != 50)
				{
					goto IL_01c9;
				}
				GridAreaData builder3 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder3 = gridAreaData_;
				}
				input.ReadMessage(builder3);
			}
			int num3 = default(int);
			if ((long)gridAreaData == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			string text8 = default(string);
			if (num3 == 18)
			{
				text8 = (Name = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (DisplayName = input.ReadString());
			}
			goto IL_01c9;
			IL_01c9:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAB")]
		[Cpp2IlInjected.Address(RVA = "0x327A560", Offset = "0x3278F60", VA = "0x18327A560", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6001BAC")]
		[Cpp2IlInjected.Address(RVA = "0x327B1E0", Offset = "0x3279BE0", VA = "0x18327B1E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001f, IL_0020, IL_0024, IL_0028, IL_0029, IL_002d, IL_0031, IL_0032, IL_0036, IL_003a, IL_003b, IL_003f, IL_0043, IL_0047, IL_004b, IL_004c, IL_0050, IL_0054, IL_0055, IL_0059, IL_005d, IL_005e, IL_005f, IL_0070, IL_0076, IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0
			//IL_0011: Expected I4, but got O
			//IL_006f: Expected I4, but got O
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

		[Cpp2IlInjected.Token(Token = "0x6001BAD")]
		[Cpp2IlInjected.Address(RVA = "0x3279AB0", Offset = "0x32784B0", VA = "0x183279AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018
			if (fieldNumber - 1 <= 15)
			{
				int num = (iD_ = 0);
			}
			else if (fieldNumber == 999)
			{
				int num2 = (int)(glotID_ = 0u);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAE")]
		[Cpp2IlInjected.Address(RVA = "0x327A9D0", Offset = "0x32793D0", VA = "0x18327A9D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Content"))
			{
				ContentOneofCase contentOneofCase = contentCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAF")]
		[Cpp2IlInjected.Address(RVA = "0x3279C50", Offset = "0x3278650", VA = "0x183279C50", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Content"))
			{
				content_ = (contentCase_ = ContentOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB2")]
		[Cpp2IlInjected.Address(RVA = "0x327A1C0", Offset = "0x3278BC0", VA = "0x18327A1C0", Slot = "31")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_0014: Expected I4, but got O
			contentCase_ = (ContentOneofCase)(content_ = new ItemTypeSelector());
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB3")]
		[Cpp2IlInjected.Address(RVA = "0x3279CC0", Offset = "0x32786C0", VA = "0x183279CC0", Slot = "22")]
		IItemData IItemData.Clone()
		{
			ConsummableItemData consummableItemData = new ConsummableItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB4")]
		[Cpp2IlInjected.Address(RVA = "0x3279490", Offset = "0x3277E90", VA = "0x183279490")]
		public static Item ChooseConsummableItem(Item itemToWrap)
		{
			//Discarded unreachable code: IL_0093, IL_0099, IL_009f, IL_00a5, IL_00ab, IL_00b1
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemConsummableOverride itemConsummableOverride = default(IItemConsummableOverride);
			bool flag = default(bool);
			Item result = default(Item);
			if (itemConsummableOverride != null && itemConsummableOverride != null && flag)
			{
				return result;
			}
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			IEnumerable<ConsummableItemData> enumerable = default(IEnumerable<ConsummableItemData>);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_004e;
					}
					num++;
				}
				if ((object)typeof(ItemTypeSelector).TypeHandle == null || (object)typeof(ItemTypeSelector).TypeHandle != null)
				{
					if ((object)typeof(ItemTypeSelector).TypeHandle == null)
					{
					}
					goto IL_004e;
				}
				throw new InvalidCastException();
			}
			goto IL_007a;
			IL_004e:
			ItemType itemType = default(ItemType);
			bool flag2 = num == (int)itemType;
			while (num == (flag2 ? 1 : 0))
			{
			}
			ItemTypeSelector itemTypeSelector = default(ItemTypeSelector);
			if (itemTypeSelector.restrictSubType_)
			{
				ItemType itemType2 = default(ItemType);
				int num3 = (int)itemType2;
				ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
				ItemDatabase.ItemTypeMetaInfo.GetSubTypeDelegate _003CGetSubType_003Ek__BackingField = itemTypeMetaInfo.GetSubType;
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
			}
			num++;
			goto IL_007a;
			IL_007a:
			num++;
			if (enumerable != null)
			{
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB5")]
		[Cpp2IlInjected.Address(RVA = "0x327B7B0", Offset = "0x327A1B0", VA = "0x18327B7B0")]
		public static ItemInstance WrapIntoConsummableItem(Item itemToWrap, int amountToWrap, ItemState stateToWrap)
		{
			//IL_0026: Expected I4, but got I8
			int itemID = itemToWrap.ItemID;
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				ItemInstance itemInstance = new ItemInstance();
				Item item = default(Item);
				itemInstance.Item = item;
				itemInstance.amount_ = 1;
				ItemState itemState = new ItemState();
				ItemInstance itemInstance2 = new ItemInstance();
				itemInstance2.ItemID = itemID;
				itemInstance2.state_ = stateToWrap;
				itemInstance2.amount_ = amountToWrap;
				itemState.ConsummableData = itemInstance2;
				itemInstance.state_ = itemState;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB7")]
		[Cpp2IlInjected.Address(RVA = "0x3279D20", Offset = "0x3278720", VA = "0x183279D20")]
		public unsafe bool ContentIsItemType(ItemType itemtype)
		{
			switch (contentCase_)
			{
			case ContentOneofCase.ItemTypeSelector:
			{
				ContentOneofCase contentOneofCase2 = contentCase_;
				object obj = content_;
				if (obj != null)
				{
					return (IntPtr)obj == (IntPtr)(void*)(int)itemtype;
				}
				throw new InvalidCastException();
			}
			case ContentOneofCase.DefaultItem:
			{
				ContentOneofCase contentOneofCase = contentCase_;
				ItemType itemType = default(ItemType);
				if (content_ != null)
				{
					return itemType == itemtype;
				}
				throw new InvalidCastException();
			}
			default:
				return ItemType.None == itemtype;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB8")]
		[Cpp2IlInjected.Address(RVA = "0x327B670", Offset = "0x327A070", VA = "0x18327B670")]
		public bool TryGetDefaultContent(out ItemInstance consummableData)
		{
			ContentOneofCase contentOneofCase = contentCase_;
			if (contentOneofCase != 0)
			{
				if (contentOneofCase == ContentOneofCase.DefaultItem)
				{
					if (content_ == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						ItemInstance defaultItem = DefaultItem;
					}
				}
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB9")]
		[Cpp2IlInjected.Address(RVA = "0x3279E30", Offset = "0x3278830", VA = "0x183279E30", Slot = "32")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0069
			ContentOneofCase contentOneofCase = contentCase_;
			int num = 0;
			switch (contentOneofCase)
			{
			case ContentOneofCase.DefaultItem:
				if (content_ != null)
				{
					Item item = default(Item);
					if ((object)item != null)
					{
						context.AddError("ItemContent cannot be none");
					}
					if (content_ != null)
					{
						bool flag = default(bool);
						ActivityItemType activityItemType = default(ActivityItemType);
						if (flag && activityItemType == ActivityItemType.Consummable)
						{
							context.AddError("ItemContent cannot be another consumable");
						}
						if (content_ != null)
						{
							context.AddError("ItemContent amount must be positive");
							break;
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			case ContentOneofCase.ItemTypeSelector:
				if (content_ != null)
				{
					break;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BBA")]
		[Cpp2IlInjected.Address(RVA = "0x327BC80", Offset = "0x327A680", VA = "0x18327BC80")]
		static ConsummableItemData()
		{
			Func<ConsummableItemData> func = default(Func<ConsummableItemData>);
			_parser = (MessageParser<ConsummableItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
