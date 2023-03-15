using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002A7")]
	public sealed class EphemeralItemData : IMessage<EphemeralItemData>, IMessage, IEquatable<EphemeralItemData>, IDeepCloneable<EphemeralItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IGridEditRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x4000B08")]
		private static readonly MessageParser<EphemeralItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000B09")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000B0A")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B0B")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000B0C")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B0D")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B0E")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B0F")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B10")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B11")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B12")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B13")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B14")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B15")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000B16")]
		public const int EphemeralTypeFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B17")]
		private EphemeralType ephemeralType_;

		[Cpp2IlInjected.Token(Token = "0x4000B18")]
		public const int TreasureLootTableFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000B19")]
		private int treasureLootTable_;

		[Cpp2IlInjected.Token(Token = "0x4000B1A")]
		public const int IgnoreManaCostFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000B1B")]
		private bool ignoreManaCost_;

		[Cpp2IlInjected.Token(Token = "0x4000B1C")]
		public const int NoMiniGameFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000B1D")]
		private bool noMiniGame_;

		[Cpp2IlInjected.Token(Token = "0x4000B1E")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000B1F")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000B20")]
		private static readonly GridEditRestriction gridEditRestriction;

		[Cpp2IlInjected.Token(Token = "0x170005E5")]
		[DebuggerNonUserCode]
		public static MessageParser<EphemeralItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001B20")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EF00", Offset = "0x2C9D900", VA = "0x182C9EF00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001B21")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EDD0", Offset = "0x2C9D7D0", VA = "0x182C9EDD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001B22")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EFC0", Offset = "0x2C9D9C0", VA = "0x182C9EFC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E8")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001B27")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B28")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E9")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001B29")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B2A")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F1B0", Offset = "0x2C9DBB0", VA = "0x182C9F1B0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005EA")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001B2B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B2C")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F0D0", Offset = "0x2C9DAD0", VA = "0x182C9F0D0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005EB")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B2D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B2E")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F140", Offset = "0x2C9DB40", VA = "0x182C9F140")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005EC")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B2F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B30")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F220", Offset = "0x2C9DC20", VA = "0x182C9F220")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005ED")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001B31")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B32")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005EE")]
		[DebuggerNonUserCode]
		public EphemeralType EphemeralType
		{
			[Cpp2IlInjected.Token(Token = "0x6001B33")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return ephemeralType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B34")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				ephemeralType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005EF")]
		[DebuggerNonUserCode]
		public int TreasureLootTable
		{
			[Cpp2IlInjected.Token(Token = "0x6001B35")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return treasureLootTable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B36")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				treasureLootTable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F0")]
		[DebuggerNonUserCode]
		public bool IgnoreManaCost
		{
			[Cpp2IlInjected.Token(Token = "0x6001B37")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return ignoreManaCost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B38")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				ignoreManaCost_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F1")]
		[DebuggerNonUserCode]
		public bool NoMiniGame
		{
			[Cpp2IlInjected.Token(Token = "0x6001B39")]
			[Cpp2IlInjected.Address(RVA = "0xFAD850", Offset = "0xFAC250", VA = "0x180FAD850")]
			get
			{
				return noMiniGame_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B3A")]
			[Cpp2IlInjected.Address(RVA = "0x2191C60", Offset = "0x2190660", VA = "0x182191C60")]
			set
			{
				noMiniGame_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F2")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001B3B")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B3C")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F3")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001B48")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F4")]
		public Item TreasureLootTableItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B49")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EF60", Offset = "0x2C9D960", VA = "0x182C9EF60")]
			get
			{
				long num = Convert.ToInt64((uint)treasureLootTable_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F5")]
		public GridEditRestriction GridEditRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6001B4A")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EEA0", Offset = "0x2C9D8A0", VA = "0x182C9EEA0", Slot = "24")]
			get
			{
				return gridEditRestriction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B23")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EB50", Offset = "0x2C9D550", VA = "0x182C9EB50")]
		[DebuggerNonUserCode]
		public EphemeralItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B24")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E230", Offset = "0x2C9CC30", VA = "0x182C9E230")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B25")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EC20", Offset = "0x2C9D620", VA = "0x182C9EC20")]
		[DebuggerNonUserCode]
		public EphemeralItemData(EphemeralItemData other)
		{
			//IL_00aa: Expected O, but got I4
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
			EphemeralType ephemeralType = (ephemeralType_ = other.ephemeralType_);
			int num3 = (treasureLootTable_ = other.treasureLootTable_);
			bool flag = (ignoreManaCost_ = other.ignoreManaCost_);
			bool flag2 = (noMiniGame_ = other.noMiniGame_);
			uint num4 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B26")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D860", Offset = "0x2C9C260", VA = "0x182C9D860", Slot = "10")]
		[DebuggerNonUserCode]
		public EphemeralItemData Clone()
		{
			return new EphemeralItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D9C0", Offset = "0x2C9C3C0", VA = "0x182C9D9C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(EphemeralItemData).TypeHandle)
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
									if (flag5 && ephemeralType_ == (flag5 ? EphemeralType.QuestItem : EphemeralType.NightThorn) && treasureLootTable_ == (flag5 ? 1 : 0) && ignoreManaCost_ == flag5 && noMiniGame_ == flag5 && glotID_ == (flag5 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x6001B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D8C0", Offset = "0x2C9C2C0", VA = "0x182C9D8C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EphemeralItemData other)
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
										EphemeralType ephemeralType = other.ephemeralType_;
										if (ephemeralType_ == ephemeralType)
										{
											int num2 = other.treasureLootTable_;
											if (treasureLootTable_ == num2)
											{
												bool flag = other.ignoreManaCost_;
												if (ignoreManaCost_ == flag)
												{
													bool flag2 = other.noMiniGame_;
													if (noMiniGame_ == flag2)
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

		[Cpp2IlInjected.Token(Token = "0x6001B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DD00", Offset = "0x2C9C700", VA = "0x182C9DD00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00cc
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
			if (ephemeralType_ != 0)
			{
			}
			if (treasureLootTable_ != 0)
			{
			}
			if (ignoreManaCost_)
			{
			}
			if (noMiniGame_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B40")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E640", Offset = "0x2C9D040", VA = "0x182C9E640", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B41")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E6A0", Offset = "0x2C9D0A0", VA = "0x182C9E6A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0128
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
			if (ephemeralType_ != 0)
			{
			}
			if (treasureLootTable_ != 0)
			{
				int value7 = treasureLootTable_;
				output.WriteInt32(value7);
			}
			if (ignoreManaCost_)
			{
				bool value8 = ignoreManaCost_;
				output.WriteBool(value8);
			}
			if (noMiniGame_)
			{
				bool value9 = noMiniGame_;
				output.WriteBool(value9);
			}
			if (glotID_ != 0)
			{
				uint value10 = glotID_;
				output.WriteUInt32(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B42")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D480", Offset = "0x2C9BE80", VA = "0x182C9D480", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_014b
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
			EphemeralType ephemeralType = ephemeralType_;
			if (ephemeralType != 0)
			{
				int num9 = CodedOutputStream.ComputeEnumSize((int)ephemeralType);
				num9++;
				num2 += num9;
			}
			int num10 = treasureLootTable_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
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

		[Cpp2IlInjected.Token(Token = "0x6001B43")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E0B0", Offset = "0x2C9CAB0", VA = "0x182C9E0B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EphemeralItemData other)
		{
			//Discarded unreachable code: IL_013e
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
			EphemeralType ephemeralType = other.ephemeralType_;
			if (ephemeralType != 0)
			{
				ephemeralType_ = ephemeralType;
			}
			int num2 = other.treasureLootTable_;
			if (num2 != 0)
			{
				treasureLootTable_ = num2;
			}
			bool flag = other.ignoreManaCost_;
			if (flag)
			{
				ignoreManaCost_ = flag;
			}
			bool flag2 = other.noMiniGame_;
			if (flag2)
			{
				noMiniGame_ = flag2;
			}
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001B44")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DEA0", Offset = "0x2C9C8A0", VA = "0x182C9DEA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_014a
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
						bool flag = (ignoreManaCost_ = input.ReadBool());
					}
					bool flag2 = default(bool);
					if (num == 80)
					{
						flag2 = (noMiniGame_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_0133;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
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
				int num3 = default(int);
				if ((long)gridAreaData == 56)
				{
					num3 = (int)(ephemeralType_ = (EphemeralType)input.ReadInt32());
				}
				if (num3 != 64)
				{
					goto IL_0133;
				}
				int num4 = (treasureLootTable_ = input.ReadInt32());
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 26)
				{
					text2 = (DisplayName = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_0133;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text6 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			if (num5 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_0133;
			IL_0133:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001B45")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DB10", Offset = "0x2C9C510", VA = "0x182C9DB10", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6001B46")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E290", Offset = "0x2C9CC90", VA = "0x182C9E290", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_002b, IL_0033, IL_003b, IL_0053, IL_0059, IL_005f, IL_0065, IL_006b, IL_0071
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0052: Expected I4, but got O
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

		[Cpp2IlInjected.Token(Token = "0x6001B47")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D6F0", Offset = "0x2C9C0F0", VA = "0x182C9D6F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018
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

		[Cpp2IlInjected.Token(Token = "0x6001B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D860", Offset = "0x2C9C260", VA = "0x182C9D860", Slot = "20")]
		IItemData IItemData.Clone()
		{
			EphemeralItemData ephemeralItemData = new EphemeralItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E8E0", Offset = "0x2C9D2E0", VA = "0x182C9E8E0")]
		static EphemeralItemData()
		{
			Func<EphemeralItemData> func = default(Func<EphemeralItemData>);
			_parser = (MessageParser<EphemeralItemData>)(object)new MessageParser<T>((Func<>)(object)func);
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
			_parser = (MessageParser<EphemeralItemData>)(object)gridEditRestriction;
			throw new NullReferenceException();
		}
	}
}
