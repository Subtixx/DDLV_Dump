using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Character;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002C1")]
	public sealed class ManualItemData : IMessage<ManualItemData>, IMessage, IEquatable<ManualItemData>, IDeepCloneable<ManualItemData>, IMessageFieldAccessor, IItemData, IGridPlaceableItemData, IHasTags, IBackpackItem, ISellable, IHasExtraGiftFriendship, IHasGiftRequirements, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4000C59")]
		private static readonly MessageParser<ManualItemData> _parser = (MessageParser<ManualItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ManualItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C5A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C5B")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C5C")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000C5D")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000C5E")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C5F")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000C60")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C61")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000C62")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C63")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000C64")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C65")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000C66")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000C67")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000C68")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C69")]
		public const int IsMissionItemFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000C6A")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x4000C6B")]
		public const int ExtraGiftFriendshipFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000C6C")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4000C6D")]
		public const int TagsFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x4000C6E")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000C6F")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000C70")]
		public const int ProfessionFieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000C71")]
		private int profession_;

		[Cpp2IlInjected.Token(Token = "0x4000C72")]
		internal static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x170006B4")]
		[DebuggerNonUserCode]
		public static MessageParser<ManualItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001D61")]
			[Cpp2IlInjected.Address(RVA = "0x3067950", Offset = "0x3066350", VA = "0x183067950")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001D62")]
			[Cpp2IlInjected.Address(RVA = "0x3067880", Offset = "0x3066280", VA = "0x183067880")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001D63")]
			[Cpp2IlInjected.Address(RVA = "0x3067A10", Offset = "0x3066410", VA = "0x183067A10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B7")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001D68")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D69")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B8")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001D6A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D6B")]
			[Cpp2IlInjected.Address(RVA = "0x3067C70", Offset = "0x3066670", VA = "0x183067C70")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B9")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001D6C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "25")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D6D")]
			[Cpp2IlInjected.Address(RVA = "0x3067B90", Offset = "0x3066590", VA = "0x183067B90")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BA")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001D6E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D6F")]
			[Cpp2IlInjected.Address(RVA = "0x3067C00", Offset = "0x3066600", VA = "0x183067C00")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BB")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001D70")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D71")]
			[Cpp2IlInjected.Address(RVA = "0x3067CE0", Offset = "0x30666E0", VA = "0x183067CE0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BC")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001D72")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "21")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D73")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BD")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001D74")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "26")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D75")]
			[Cpp2IlInjected.Address(RVA = "0x3067B20", Offset = "0x3066520", VA = "0x183067B20")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BE")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001D76")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D77")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BF")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6001D78")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830", Slot = "28")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D79")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C0")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001D7A")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "23")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C1")]
		[DebuggerNonUserCode]
		public int Profession
		{
			[Cpp2IlInjected.Token(Token = "0x6001D7B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return profession_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D7C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				profession_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C2")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001D88")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "30")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C3")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001D89")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "27")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C4")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001D8A")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "31")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C5")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001D8D")]
			[Cpp2IlInjected.Address(RVA = "0x30679B0", Offset = "0x30663B0", VA = "0x1830679B0", Slot = "22")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D64")]
		[Cpp2IlInjected.Address(RVA = "0x3067500", Offset = "0x3065F00", VA = "0x183067500")]
		[DebuggerNonUserCode]
		public ManualItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D65")]
		[Cpp2IlInjected.Address(RVA = "0x3066BE0", Offset = "0x30655E0", VA = "0x183066BE0")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D66")]
		[Cpp2IlInjected.Address(RVA = "0x3067630", Offset = "0x3066030", VA = "0x183067630")]
		[DebuggerNonUserCode]
		public ManualItemData(ManualItemData other)
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
			bool flag = (isMissionItem_ = other.isMissionItem_);
			int num3 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			int num4 = (profession_ = other.profession_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D67")]
		[Cpp2IlInjected.Address(RVA = "0x3065CE0", Offset = "0x30646E0", VA = "0x183065CE0", Slot = "10")]
		[DebuggerNonUserCode]
		public ManualItemData Clone()
		{
			return new ManualItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7D")]
		[Cpp2IlInjected.Address(RVA = "0x3065D40", Offset = "0x3064740", VA = "0x183065D40", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(ManualItemData).TypeHandle)
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
									if (!flag5 && isMissionItem_ == flag5 && extraGiftFriendship_ == (flag5 ? 1 : 0))
									{
										RepeatedField<int> repeatedField = tags_;
										bool flag6 = default(bool);
										if (flag6 && profession_ == (flag6 ? 1 : 0))
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

		[Cpp2IlInjected.Token(Token = "0x6001D7E")]
		[Cpp2IlInjected.Address(RVA = "0x3065ED0", Offset = "0x30648D0", VA = "0x183065ED0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ManualItemData other)
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
												int num2 = other.extraGiftFriendship_;
												if (extraGiftFriendship_ == num2)
												{
													RepeatedField<int> repeatedField = tags_;
													RepeatedField<int> repeatedField2 = other.tags_;
													if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
													{
														int num3 = other.profession_;
														if (profession_ == num3)
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
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7F")]
		[Cpp2IlInjected.Address(RVA = "0x30661E0", Offset = "0x3064BE0", VA = "0x1830661E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e2
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
			if (extraGiftFriendship_ != 0)
			{
			}
			int hashCode7 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (profession_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D80")]
		[Cpp2IlInjected.Address(RVA = "0x3067000", Offset = "0x3065A00", VA = "0x183067000", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D81")]
		[Cpp2IlInjected.Address(RVA = "0x3067070", Offset = "0x3065A70", VA = "0x183067070", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_013c
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
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (profession_ != 0)
			{
				int value10 = profession_;
				output.WriteInt32(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D82")]
		[Cpp2IlInjected.Address(RVA = "0x3065850", Offset = "0x3064250", VA = "0x183065850", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_016e
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
			int num10 = extraGiftFriendship_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			int num13 = profession_;
			num2 += num12;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14 += 2;
				num2 += num14;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				num2 += num15;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D83")]
		[Cpp2IlInjected.Address(RVA = "0x3066A30", Offset = "0x3065430", VA = "0x183066A30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ManualItemData other)
		{
			//Discarded unreachable code: IL_0146
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
			int num2 = other.extraGiftFriendship_;
			if (num2 != 0)
			{
				extraGiftFriendship_ = num2;
			}
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num3 = other.profession_;
			if (num3 != 0)
			{
				profession_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001D84")]
		[Cpp2IlInjected.Address(RVA = "0x30667A0", Offset = "0x30651A0", VA = "0x1830667A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_015e
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 50)
			{
				if ((int)num > 112)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 152)
						{
							goto IL_0147;
						}
						int num2 = (profession_ = input.ReadInt32());
					}
					RepeatedField<int> repeatedField = tags_;
					FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
				}
				if (num == 58)
				{
					string text2 = (Description = input.ReadString());
				}
				bool flag = default(bool);
				if (num == 104)
				{
					flag = (isMissionItem_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0147;
				}
				int num3 = (extraGiftFriendship_ = input.ReadInt32());
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
					goto IL_0147;
				}
				GridAreaData builder = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder = gridAreaData_;
				}
				input.ReadMessage(builder);
			}
			int num4 = default(int);
			if ((long)gridAreaData == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			string text8 = default(string);
			if (num4 == 18)
			{
				text8 = (Name = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (DisplayName = input.ReadString());
			}
			goto IL_0147;
			IL_0147:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001D85")]
		[Cpp2IlInjected.Address(RVA = "0x3066020", Offset = "0x3064A20", VA = "0x183066020", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 18)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D86")]
		[Cpp2IlInjected.Address(RVA = "0x3066C40", Offset = "0x3065640", VA = "0x183066C40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_001b, IL_0028, IL_0030, IL_0038, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058, IL_005e, IL_0064, IL_006a
			//IL_000e: Expected I4, but got O
			//IL_001a: Expected O, but got I4
			if (fieldNumber - 1 <= 18)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D87")]
		[Cpp2IlInjected.Address(RVA = "0x3065B20", Offset = "0x3064520", VA = "0x183065B20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_001b
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 18)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8B")]
		[Cpp2IlInjected.Address(RVA = "0x3065CE0", Offset = "0x30646E0", VA = "0x183065CE0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			ManualItemData manualItemData = new ManualItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8C")]
		[Cpp2IlInjected.Address(RVA = "0x3066390", Offset = "0x3064D90", VA = "0x183066390", Slot = "29")]
		public bool IsGiftableTo(IProfile profile, Item giftTargetItem)
		{
			int itemID = giftTargetItem.ItemID;
			int num = 0;
			if ((long)num < (long)(IntPtr)profile)
			{
				num += num;
				if ((object)"{il2cpp array field il2cppMethodInfo->}" == (object)typeof(IProfileWorld).TypeHandle)
				{
					goto IL_00ad;
				}
				num++;
			}
			Func<Item, bool> func2 = default(Func<Item, bool>);
			IEnumerable<int> enumerable = default(IEnumerable<int>);
			if ((IntPtr)typeof(_003C_003Ec).TypeHandle != (IntPtr)profession_ && (object)typeof(_003C_003Ec).TypeHandle == null)
			{
				RepeatedField<FriendshipLevel> repeatedField = default(RepeatedField<FriendshipLevel>);
				int num2 = ((RepeatedField<T>)(object)repeatedField).Count - 1;
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (num == num2)
				{
					CharacterItemData characterItemData = default(CharacterItemData);
					if (characterItemData != null)
					{
						RepeatedField<int> forbiddenProfessions_ = characterItemData.forbiddenProfessions_;
						Func<int, Item> func = default(Func<int, Item>);
						if (_003C_003Ec._003C_003E9__85_0 == null)
						{
							func = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int professionID) => (Item)typeof(Item).TypeHandle));
						}
						enumerable = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)(object)forbiddenProfessions_, (Func<, >)(object)func);
						func2 = (Func<Item, bool>)(object)(Func<T, TResult>)((Item p) => (IntPtr)p == (IntPtr)profession_);
						if (((IEnumerable<>)enumerable).Any<Item>((Func<, >)(object)func2))
						{
							goto IL_00bb;
						}
					}
					goto IL_00ad;
				}
			}
			goto IL_00bb;
			IL_00ad:
			func2 += func2;
			enumerable = (IEnumerable<int>)(object)((object)enumerable + (object)enumerable);
			goto IL_00bb;
			IL_00bb:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8E")]
		[Cpp2IlInjected.Address(RVA = "0x3067320", Offset = "0x3065D20", VA = "0x183067320")]
		static ManualItemData()
		{
			//Discarded unreachable code: IL_003f
			//IL_0038: Expected O, but got I4
			_parser = (MessageParser<ManualItemData>)(object)FieldCodec.ForInt32(122u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<ManualItemData>)(object)array;
		}
	}
}
