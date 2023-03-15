using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002A9")]
	public sealed class LootPresentItemData : IMessage<LootPresentItemData>, IMessage, IEquatable<LootPresentItemData>, IDeepCloneable<LootPresentItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IBackpackItem, ISellable, IIsMissionItem, IIsOnlineOnly
	{
		[Cpp2IlInjected.Token(Token = "0x4000B22")]
		private static readonly MessageParser<LootPresentItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000B23")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000B24")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B25")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000B26")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B27")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B28")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B29")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B2A")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B2B")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B2C")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B2D")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B2E")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B2F")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000B30")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B31")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B32")]
		public const int LootTableItemIDFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000B33")]
		private int lootTableItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000B34")]
		public const int BoxIndexFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000B35")]
		private int boxIndex_;

		[Cpp2IlInjected.Token(Token = "0x4000B36")]
		public const int IsMissionItemFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000B37")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4000B38")]
		public const int IsOnlineOnlyFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000B39")]
		private bool isOnlineOnly_;

		[Cpp2IlInjected.Token(Token = "0x4000B3A")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000B3B")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x170005F6")]
		[DebuggerNonUserCode]
		public static MessageParser<LootPresentItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001B50")]
			[Cpp2IlInjected.Address(RVA = "0x38F93F0", Offset = "0x38F7DF0", VA = "0x1838F93F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001B51")]
			[Cpp2IlInjected.Address(RVA = "0x38F9320", Offset = "0x38F7D20", VA = "0x1838F9320")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001B52")]
			[Cpp2IlInjected.Address(RVA = "0x38F9450", Offset = "0x38F7E50", VA = "0x1838F9450", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F9")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001B57")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B58")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FA")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001B59")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B5A")]
			[Cpp2IlInjected.Address(RVA = "0x38F96B0", Offset = "0x38F80B0", VA = "0x1838F96B0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FB")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001B5B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "25")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B5C")]
			[Cpp2IlInjected.Address(RVA = "0x38F95D0", Offset = "0x38F7FD0", VA = "0x1838F95D0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FC")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B5D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B5E")]
			[Cpp2IlInjected.Address(RVA = "0x38F9640", Offset = "0x38F8040", VA = "0x1838F9640")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FD")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B5F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B60")]
			[Cpp2IlInjected.Address(RVA = "0x38F9720", Offset = "0x38F8120", VA = "0x1838F9720")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FE")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001B61")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B62")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FF")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001B63")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "26")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B64")]
			[Cpp2IlInjected.Address(RVA = "0x38F9560", Offset = "0x38F7F60", VA = "0x1838F9560")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000600")]
		[DebuggerNonUserCode]
		public int LootTableItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001B65")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return lootTableItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B66")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				lootTableItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000601")]
		[DebuggerNonUserCode]
		public int BoxIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6001B67")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return boxIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B68")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				boxIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000602")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B69")]
			[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820", Slot = "28")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B6A")]
			[Cpp2IlInjected.Address(RVA = "0xE3A650", Offset = "0xE39050", VA = "0x180E3A650")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000603")]
		[DebuggerNonUserCode]
		public bool IsOnlineOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6001B6B")]
			[Cpp2IlInjected.Address(RVA = "0x2287B40", Offset = "0x2286540", VA = "0x182287B40", Slot = "29")]
			get
			{
				return isOnlineOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B6C")]
			[Cpp2IlInjected.Address(RVA = "0x2287B90", Offset = "0x2286590", VA = "0x182287B90")]
			set
			{
				isOnlineOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000604")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001B6D")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B6E")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000605")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001B7A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "24")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000606")]
		public Item LootTableItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B7B")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				int num = lootTableItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000607")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001B7C")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "27")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B53")]
		[Cpp2IlInjected.Address(RVA = "0x38F9060", Offset = "0x38F7A60", VA = "0x1838F9060")]
		[DebuggerNonUserCode]
		public LootPresentItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B54")]
		[Cpp2IlInjected.Address(RVA = "0x38F8820", Offset = "0x38F7220", VA = "0x1838F8820")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B55")]
		[Cpp2IlInjected.Address(RVA = "0x38F9140", Offset = "0x38F7B40", VA = "0x1838F9140")]
		[DebuggerNonUserCode]
		public LootPresentItemData(LootPresentItemData other)
		{
			//IL_00b5: Expected O, but got I4
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
			int num3 = (lootTableItemID_ = other.lootTableItemID_);
			int num4 = (boxIndex_ = other.boxIndex_);
			bool flag = (isMissionItem_ = other.isMissionItem_);
			bool flag2 = (isOnlineOnly_ = other.isOnlineOnly_);
			uint num5 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B56")]
		[Cpp2IlInjected.Address(RVA = "0x38F7DE0", Offset = "0x38F67E0", VA = "0x1838F7DE0", Slot = "10")]
		[DebuggerNonUserCode]
		public LootPresentItemData Clone()
		{
			return new LootPresentItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B6F")]
		[Cpp2IlInjected.Address(RVA = "0x38F7E40", Offset = "0x38F6840", VA = "0x1838F7E40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(LootPresentItemData).TypeHandle)
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
									if (!flag5 && lootTableItemID_ == (flag5 ? 1 : 0) && boxIndex_ == (flag5 ? 1 : 0) && isMissionItem_ == flag5 && isOnlineOnly_ == flag5 && glotID_ == (flag5 ? 1u : 0u))
									{
										return object.Equals(_unknownFields, other);
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

		[Cpp2IlInjected.Token(Token = "0x6001B70")]
		[Cpp2IlInjected.Address(RVA = "0x38F7FA0", Offset = "0x38F69A0", VA = "0x1838F7FA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootPresentItemData other)
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
											int num2 = other.lootTableItemID_;
											if (lootTableItemID_ == num2)
											{
												int num3 = other.boxIndex_;
												if (boxIndex_ == num3)
												{
													bool flag = other.isMissionItem_;
													if (isMissionItem_ == flag)
													{
														bool flag2 = other.isOnlineOnly_;
														if (isOnlineOnly_ == flag2)
														{
															uint num4 = other.glotID_;
															if (glotID_ == num4)
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
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B71")]
		[Cpp2IlInjected.Address(RVA = "0x38F8290", Offset = "0x38F6C90", VA = "0x1838F8290", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e7
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
			if (lootTableItemID_ != 0)
			{
			}
			if (boxIndex_ != 0)
			{
			}
			if (isMissionItem_)
			{
			}
			if (isOnlineOnly_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B72")]
		[Cpp2IlInjected.Address(RVA = "0x38F8C70", Offset = "0x38F7670", VA = "0x1838F8C70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B73")]
		[Cpp2IlInjected.Address(RVA = "0x38F8CD0", Offset = "0x38F76D0", VA = "0x1838F8CD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0156
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
			if (lootTableItemID_ != 0)
			{
				int value8 = lootTableItemID_;
				output.WriteInt32(value8);
			}
			if (boxIndex_ != 0)
			{
				int value9 = boxIndex_;
				output.WriteInt32(value9);
			}
			if (isMissionItem_)
			{
				bool value10 = isMissionItem_;
				output.WriteBool(value10);
			}
			if (isOnlineOnly_)
			{
				bool value11 = isOnlineOnly_;
				output.WriteBool(value11);
			}
			if (glotID_ != 0)
			{
				uint value12 = glotID_;
				output.WriteUInt32(value12);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B74")]
		[Cpp2IlInjected.Address(RVA = "0x38F79A0", Offset = "0x38F63A0", VA = "0x1838F79A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0171
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
			int num10 = lootTableItemID_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = boxIndex_;
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

		[Cpp2IlInjected.Token(Token = "0x6001B75")]
		[Cpp2IlInjected.Address(RVA = "0x38F8680", Offset = "0x38F7080", VA = "0x1838F8680", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootPresentItemData other)
		{
			//Discarded unreachable code: IL_0158
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
			int num2 = other.lootTableItemID_;
			if (num2 != 0)
			{
				lootTableItemID_ = num2;
			}
			int num3 = other.boxIndex_;
			if (num3 != 0)
			{
				boxIndex_ = num3;
			}
			bool flag = other.isMissionItem_;
			if (flag)
			{
				isMissionItem_ = flag;
			}
			bool flag2 = other.isOnlineOnly_;
			if (flag2)
			{
				isOnlineOnly_ = flag2;
			}
			uint num4 = other.glotID_;
			if (num4 != 0)
			{
				glotID_ = num4;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001B76")]
		[Cpp2IlInjected.Address(RVA = "0x38F8450", Offset = "0x38F6E50", VA = "0x1838F8450", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0162
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 50)
			{
				if ((int)num > 72)
				{
					if (num == 80)
					{
						bool flag = (isMissionItem_ = input.ReadBool());
					}
					bool flag2 = default(bool);
					if (num == 88)
					{
						flag2 = (isOnlineOnly_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_014b;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 58)
				{
					text2 = (Description = input.ReadString());
				}
				int num3 = default(int);
				if ((long)text2 == 64)
				{
					num3 = (lootTableItemID_ = input.ReadInt32());
				}
				if (num3 != 72)
				{
					goto IL_014b;
				}
				int num4 = (boxIndex_ = input.ReadInt32());
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
					goto IL_014b;
				}
				GridAreaData builder = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder = gridAreaData_;
				}
				input.ReadMessage(builder);
			}
			int num5 = default(int);
			if ((long)gridAreaData == 8)
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
			goto IL_014b;
			IL_014b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001B77")]
		[Cpp2IlInjected.Address(RVA = "0x38F80B0", Offset = "0x38F6AB0", VA = "0x1838F80B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B78")]
		[Cpp2IlInjected.Address(RVA = "0x38F8880", Offset = "0x38F7280", VA = "0x1838F8880", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0031, IL_0039, IL_0041, IL_0049, IL_0061, IL_0067, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085, IL_008b
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0060: Expected I4, but got O
			if (fieldNumber - 1 <= 10)
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

		[Cpp2IlInjected.Token(Token = "0x6001B79")]
		[Cpp2IlInjected.Address(RVA = "0x38F7C50", Offset = "0x38F6650", VA = "0x1838F7C50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_002c, IL_0034, IL_003c, IL_0044
			//IL_0010: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			if (fieldNumber - 1 <= 10)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7D")]
		[Cpp2IlInjected.Address(RVA = "0x38F7DE0", Offset = "0x38F67E0", VA = "0x1838F7DE0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			LootPresentItemData lootPresentItemData = new LootPresentItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7E")]
		[Cpp2IlInjected.Address(RVA = "0x38F8F50", Offset = "0x38F7950", VA = "0x1838F8F50")]
		static LootPresentItemData()
		{
			Func<LootPresentItemData> func = default(Func<LootPresentItemData>);
			_parser = (MessageParser<LootPresentItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
