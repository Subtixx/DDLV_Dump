using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200029B")]
	public sealed class ActivityItemData : IMessage<ActivityItemData>, IMessage, IEquatable<ActivityItemData>, IDeepCloneable<ActivityItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IBackpackItem, ISellable, IGridPlaceableItemData, IIsMissionItem, IHasExtraGiftFriendship, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4000A6A")]
		private static readonly MessageParser<ActivityItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000A6B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000A6C")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A6D")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000A6E")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A6F")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A70")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000A71")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A72")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A73")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A74")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000A75")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A76")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000A77")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000A78")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000A79")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A7A")]
		public const int IsMissionItemFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000A7B")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4000A7C")]
		public const int UnsellableFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000A7D")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x4000A7E")]
		public const int ExtraGiftFriendshipFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000A7F")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4000A80")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000A81")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x1700057E")]
		[DebuggerNonUserCode]
		public static MessageParser<ActivityItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001A0B")]
			[Cpp2IlInjected.Address(RVA = "0x3159420", Offset = "0x3157E20", VA = "0x183159420")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001A0C")]
			[Cpp2IlInjected.Address(RVA = "0x3159350", Offset = "0x3157D50", VA = "0x183159350")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000580")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001A0D")]
			[Cpp2IlInjected.Address(RVA = "0x3159480", Offset = "0x3157E80", VA = "0x183159480", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000581")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001A12")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A13")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000582")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001A14")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A15")]
			[Cpp2IlInjected.Address(RVA = "0x31596E0", Offset = "0x31580E0", VA = "0x1831596E0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000583")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001A16")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "24")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A17")]
			[Cpp2IlInjected.Address(RVA = "0x3159600", Offset = "0x3158000", VA = "0x183159600")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000584")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001A18")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A19")]
			[Cpp2IlInjected.Address(RVA = "0x3159670", Offset = "0x3158070", VA = "0x183159670")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000585")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001A1A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A1B")]
			[Cpp2IlInjected.Address(RVA = "0x3159750", Offset = "0x3158150", VA = "0x183159750")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000586")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001A1C")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "27")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A1D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000587")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001A1E")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A1F")]
			[Cpp2IlInjected.Address(RVA = "0x3159590", Offset = "0x3157F90", VA = "0x183159590")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000588")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001A20")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "28")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A21")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000589")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6001A22")]
			[Cpp2IlInjected.Address(RVA = "0xFAD850", Offset = "0xFAC250", VA = "0x180FAD850")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A23")]
			[Cpp2IlInjected.Address(RVA = "0x2191C60", Offset = "0x2190660", VA = "0x182191C60")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058A")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6001A24")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830", Slot = "29")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A25")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058B")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001A26")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A27")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058C")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001A33")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "30")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058D")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001A34")]
			[Cpp2IlInjected.Address(RVA = "0x3159330", Offset = "0x3157D30", VA = "0x183159330", Slot = "31")]
			get
			{
				return !isMissionItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058E")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001A35")]
			[Cpp2IlInjected.Address(RVA = "0x3159340", Offset = "0x3157D40", VA = "0x183159340", Slot = "26")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A0E")]
		[Cpp2IlInjected.Address(RVA = "0x3159250", Offset = "0x3157C50", VA = "0x183159250")]
		[DebuggerNonUserCode]
		public ActivityItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A0F")]
		[Cpp2IlInjected.Address(RVA = "0x31588B0", Offset = "0x31572B0", VA = "0x1831588B0")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A10")]
		[Cpp2IlInjected.Address(RVA = "0x3159080", Offset = "0x3157A80", VA = "0x183159080")]
		[DebuggerNonUserCode]
		public ActivityItemData(ActivityItemData other)
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
			bool flag = (isMissionItem_ = other.isMissionItem_);
			bool flag2 = (unsellable_ = other.unsellable_);
			int num3 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			uint num4 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A11")]
		[Cpp2IlInjected.Address(RVA = "0x3157EB0", Offset = "0x31568B0", VA = "0x183157EB0", Slot = "10")]
		[DebuggerNonUserCode]
		public ActivityItemData Clone()
		{
			return new ActivityItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A28")]
		[Cpp2IlInjected.Address(RVA = "0x3157F10", Offset = "0x3156910", VA = "0x183157F10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(ActivityItemData).TypeHandle)
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
									if (!flag5 && isMissionItem_ == flag5 && unsellable_ == flag5 && extraGiftFriendship_ == (flag5 ? 1 : 0) && glotID_ == (flag5 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x6001A29")]
		[Cpp2IlInjected.Address(RVA = "0x3158070", Offset = "0x3156A70", VA = "0x183158070", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActivityItemData other)
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
											bool flag = other.isMissionItem_;
											if (isMissionItem_ == flag)
											{
												bool flag2 = other.unsellable_;
												if (unsellable_ == flag2)
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
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2A")]
		[Cpp2IlInjected.Address(RVA = "0x3158350", Offset = "0x3156D50", VA = "0x183158350", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00de
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
			if (isMissionItem_)
			{
			}
			if (unsellable_)
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
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2B")]
		[Cpp2IlInjected.Address(RVA = "0x3158CC0", Offset = "0x31576C0", VA = "0x183158CC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2C")]
		[Cpp2IlInjected.Address(RVA = "0x3158D20", Offset = "0x3157720", VA = "0x183158D20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_013d
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
			if (glotID_ != 0)
			{
				uint value11 = glotID_;
				output.WriteUInt32(value11);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2D")]
		[Cpp2IlInjected.Address(RVA = "0x3157AB0", Offset = "0x31564B0", VA = "0x183157AB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0170
			int num = iD_;
			int num2 = 0;
			int num3 = default(int);
			if (num != 0)
			{
				num3 = CodedOutputStream.ComputeInt32Size(num) + 1;
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num3 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num3 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num3 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num3 += num7;
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(gridAreaData);
				num8++;
				num3 += num8;
			}
			string text5 = description_;
			int num9 = default(int);
			if (text5.m_stringLength != 0)
			{
				num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num3 += num9;
			}
			if (!isMissionItem_)
			{
				num9 = num3;
			}
			int num10 = extraGiftFriendship_;
			if (!unsellable_)
			{
				num3 = num9;
			}
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num3 += num11;
			}
			uint num12 = glotID_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeUInt32Size(num12);
				num13 += 2;
				num3 += num13;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
				num3 += num14;
			}
			return num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2E")]
		[Cpp2IlInjected.Address(RVA = "0x3158500", Offset = "0x3156F00", VA = "0x183158500", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActivityItemData other)
		{
			//Discarded unreachable code: IL_0143
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

		[Cpp2IlInjected.Token(Token = "0x6001A2F")]
		[Cpp2IlInjected.Address(RVA = "0x31586A0", Offset = "0x31570A0", VA = "0x1831586A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_014c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 64)
				{
					if (num == 72)
					{
						int num2 = (extraGiftFriendship_ = input.ReadInt32());
					}
					bool flag = default(bool);
					if (num == 80)
					{
						flag = (unsellable_ = input.ReadBool());
					}
					if (!flag)
					{
						goto IL_0135;
					}
					int num3 = (int)(glotID_ = (uint)input.ReadInt32());
				}
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
				string text2 = default(string);
				if ((long)gridAreaData == 58)
				{
					text2 = (Description = input.ReadString());
				}
				if ((long)text2 != 64)
				{
					goto IL_0135;
				}
				bool flag2 = (isMissionItem_ = input.ReadBool());
			}
			string text8 = default(string);
			if ((int)num > 18)
			{
				string text4 = default(string);
				if (num == 26)
				{
					text4 = (DisplayName = input.ReadString());
				}
				string text6 = default(string);
				if ((long)text4 == 34)
				{
					text6 = (IconAddress = input.ReadString());
				}
				if ((long)text6 != 42)
				{
					goto IL_0135;
				}
				text8 = (PrefabAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text8 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_0135;
			IL_0135:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001A30")]
		[Cpp2IlInjected.Address(RVA = "0x3158180", Offset = "0x3156B80", VA = "0x183158180", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
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

		[Cpp2IlInjected.Token(Token = "0x6001A31")]
		[Cpp2IlInjected.Address(RVA = "0x3158910", Offset = "0x3157310", VA = "0x183158910", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0031, IL_0039, IL_0041, IL_0059, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077, IL_007d, IL_0083
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0058: Expected I4, but got O
			if (fieldNumber - 1 <= 9)
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

		[Cpp2IlInjected.Token(Token = "0x6001A32")]
		[Cpp2IlInjected.Address(RVA = "0x3157D30", Offset = "0x3156730", VA = "0x183157D30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_002b, IL_0033, IL_003b, IL_0043, IL_004b, IL_0053
			//IL_0010: Expected I4, but got I8
			//IL_002a: Expected I4, but got I8
			if (fieldNumber - 1 <= 9)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A36")]
		[Cpp2IlInjected.Address(RVA = "0x3157EB0", Offset = "0x31568B0", VA = "0x183157EB0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			ActivityItemData activityItemData = new ActivityItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A37")]
		[Cpp2IlInjected.Address(RVA = "0x3158F70", Offset = "0x3157970", VA = "0x183158F70")]
		static ActivityItemData()
		{
			Func<ActivityItemData> func = default(Func<ActivityItemData>);
			_parser = (MessageParser<ActivityItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
