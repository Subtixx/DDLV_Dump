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
	[Cpp2IlInjected.Token(Token = "0x20002D5")]
	public sealed class FurnitureRequestItemData : IMessage<FurnitureRequestItemData>, IMessage, IEquatable<FurnitureRequestItemData>, IDeepCloneable<FurnitureRequestItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IGridEditRestriction, IHasTags
	{
		[Cpp2IlInjected.Token(Token = "0x4000CBE")]
		private static readonly MessageParser<FurnitureRequestItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000CBF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000CC0")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000CC1")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000CC2")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000CC3")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CC4")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000CC5")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CC6")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000CC7")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CC8")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000CC9")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CCA")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000CCB")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000CCC")]
		public const int TagsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4000CCD")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000CCE")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000CCF")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000CD0")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000CD1")]
		private static readonly GridEditRestriction gridEditRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000CD2")]
		public static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x170006F8")]
		[DebuggerNonUserCode]
		public static MessageParser<FurnitureRequestItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001E7A")]
			[Cpp2IlInjected.Address(RVA = "0x21855F0", Offset = "0x2183FF0", VA = "0x1821855F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E7B")]
			[Cpp2IlInjected.Address(RVA = "0x2185460", Offset = "0x2183E60", VA = "0x182185460")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E7C")]
			[Cpp2IlInjected.Address(RVA = "0x21856B0", Offset = "0x21840B0", VA = "0x1821856B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FB")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001E81")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E82")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FC")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001E83")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E84")]
			[Cpp2IlInjected.Address(RVA = "0x21858A0", Offset = "0x21842A0", VA = "0x1821858A0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FD")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001E85")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E86")]
			[Cpp2IlInjected.Address(RVA = "0x21857C0", Offset = "0x21841C0", VA = "0x1821857C0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FE")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001E87")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E88")]
			[Cpp2IlInjected.Address(RVA = "0x2185830", Offset = "0x2184230", VA = "0x182185830")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FF")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001E89")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E8A")]
			[Cpp2IlInjected.Address(RVA = "0x2185910", Offset = "0x2184310", VA = "0x182185910")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000700")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001E8B")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E8C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000701")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001E8D")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "26")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000702")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001E8E")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E8F")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000703")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001E9B")]
			[Cpp2IlInjected.Address(RVA = "0x2185590", Offset = "0x2183F90", VA = "0x182185590", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000704")]
		public GridEditRestriction GridEditRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6001E9D")]
			[Cpp2IlInjected.Address(RVA = "0x2185530", Offset = "0x2183F30", VA = "0x182185530", Slot = "24")]
			get
			{
				return gridEditRestriction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000705")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001E9E")]
			[Cpp2IlInjected.Address(RVA = "0x2185650", Offset = "0x2184050", VA = "0x182185650", Slot = "25")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7D")]
		[Cpp2IlInjected.Address(RVA = "0x2185120", Offset = "0x2183B20", VA = "0x182185120")]
		[DebuggerNonUserCode]
		public FurnitureRequestItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7E")]
		[Cpp2IlInjected.Address(RVA = "0x21847F0", Offset = "0x21831F0", VA = "0x1821847F0")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7F")]
		[Cpp2IlInjected.Address(RVA = "0x2185240", Offset = "0x2183C40", VA = "0x182185240")]
		[DebuggerNonUserCode]
		public FurnitureRequestItemData(FurnitureRequestItemData other)
		{
			//IL_00b9: Expected O, but got I4
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
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			uint num3 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E80")]
		[Cpp2IlInjected.Address(RVA = "0x2183E90", Offset = "0x2182890", VA = "0x182183E90", Slot = "10")]
		[DebuggerNonUserCode]
		public FurnitureRequestItemData Clone()
		{
			return new FurnitureRequestItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E90")]
		[Cpp2IlInjected.Address(RVA = "0x2183EF0", Offset = "0x21828F0", VA = "0x182183EF0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(FurnitureRequestItemData).TypeHandle)
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
									RepeatedField<int> repeatedField = tags_;
									bool flag5 = default(bool);
									if (flag5 && glotID_ == (flag5 ? 1u : 0u))
									{
										return object.Equals(_unknownFields, other);
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

		[Cpp2IlInjected.Token(Token = "0x6001E91")]
		[Cpp2IlInjected.Address(RVA = "0x2184050", Offset = "0x2182A50", VA = "0x182184050", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FurnitureRequestItemData other)
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
										RepeatedField<int> repeatedField = tags_;
										RepeatedField<int> repeatedField2 = other.tags_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											uint num2 = other.glotID_;
											if (glotID_ == num2)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E92")]
		[Cpp2IlInjected.Address(RVA = "0x21842F0", Offset = "0x2182CF0", VA = "0x1821842F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b5
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
			int hashCode6 = ((RepeatedField<T>)(object)tags_).GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6001E93")]
		[Cpp2IlInjected.Address(RVA = "0x2184B20", Offset = "0x2183520", VA = "0x182184B20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E94")]
		[Cpp2IlInjected.Address(RVA = "0x2184B80", Offset = "0x2183580", VA = "0x182184B80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ed
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
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (glotID_ != 0)
			{
				uint value7 = glotID_;
				output.WriteUInt32(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E95")]
		[Cpp2IlInjected.Address(RVA = "0x2183AD0", Offset = "0x21824D0", VA = "0x182183AD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0128
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
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			uint num10 = glotID_;
			num2 += num9;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeUInt32Size(num10);
				num11 += 2;
				num2 += num11;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num12 = unknownFields.CalculateSize();
				num2 += num12;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E96")]
		[Cpp2IlInjected.Address(RVA = "0x2184440", Offset = "0x2182E40", VA = "0x182184440", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FurnitureRequestItemData other)
		{
			//Discarded unreachable code: IL_0103
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
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			uint num2 = other.glotID_;
			if (num2 != 0)
			{
				glotID_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001E97")]
		[Cpp2IlInjected.Address(RVA = "0x21845C0", Offset = "0x2182FC0", VA = "0x1821845C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0119
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 7992)
						{
							goto IL_0102;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					RepeatedField<int> repeatedField = tags_;
					FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
				}
				if (num == 42)
				{
					string text2 = (PrefabAddress = input.ReadString());
				}
				if (num != 50)
				{
					goto IL_0102;
				}
				GridAreaData builder = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
					builder = gridAreaData_;
				}
				input.ReadMessage(builder);
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text4 = default(string);
				if (num == 26)
				{
					text4 = (DisplayName = input.ReadString());
				}
				if ((long)text4 != 34)
				{
					goto IL_0102;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text6 == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_0102;
			IL_0102:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001E98")]
		[Cpp2IlInjected.Address(RVA = "0x2184170", Offset = "0x2182B70", VA = "0x182184170", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
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

		[Cpp2IlInjected.Token(Token = "0x6001E99")]
		[Cpp2IlInjected.Address(RVA = "0x2184850", Offset = "0x2183250", VA = "0x182184850", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0019, IL_001a, IL_001b, IL_0032, IL_0038, IL_003e, IL_0044, IL_004a, IL_0050
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			if (fieldNumber - 1 <= 6)
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

		[Cpp2IlInjected.Token(Token = "0x6001E9A")]
		[Cpp2IlInjected.Address(RVA = "0x2183D30", Offset = "0x2182730", VA = "0x182183D30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0028
			//IL_000f: Expected I4, but got I8
			//IL_0027: Expected I4, but got I8
			if (fieldNumber - 1 <= 6)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9C")]
		[Cpp2IlInjected.Address(RVA = "0x2183E90", Offset = "0x2182890", VA = "0x182183E90", Slot = "20")]
		IItemData IItemData.Clone()
		{
			FurnitureRequestItemData furnitureRequestItemData = new FurnitureRequestItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9F")]
		[Cpp2IlInjected.Address(RVA = "0x2184DA0", Offset = "0x21837A0", VA = "0x182184DA0")]
		static FurnitureRequestItemData()
		{
			//Discarded unreachable code: IL_00b4
			//IL_002b: Expected I4, but got I8
			//IL_0042: Expected I4, but got I8
			//IL_007c: Expected I4, but got I8
			//IL_009f: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			Func<FurnitureRequestItemData> func = default(Func<FurnitureRequestItemData>);
			_parser = (MessageParser<FurnitureRequestItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<FurnitureRequestItemData>)(object)FieldCodec.ForInt32(58u);
			ulong num = default(ulong);
			ulong num2 = default(ulong);
			GridEditRestriction gridEditRestriction = new GridEditRestriction
			{
				canMove_ = new GridEditRestriction.Types.Restriction
				{
					Value = ((byte)num != 0)
				},
				canRotate_ = new GridEditRestriction.Types.Restriction
				{
					Value = ((byte)num2 != 0)
				}
			};
			GridEditRestriction.Types.Restriction restriction = new GridEditRestriction.Types.Restriction();
			int num3 = ((restriction.Value = false) ? 1 : 0);
			gridEditRestriction.canBeRemoved_ = restriction;
			gridEditRestriction.canBeCleared_ = false;
			ulong num4 = default(ulong);
			gridEditRestriction.canBeSelected_ = new GridEditRestriction.Types.Restriction
			{
				Value = ((byte)num4 != 0)
			};
			_parser = (MessageParser<FurnitureRequestItemData>)(object)gridEditRestriction;
			(TagItemType, int?)[] array = new(TagItemType, int?)[2];
			int num5 = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num5;
			int num6 = 0;
			((ValueTuple<, >[])(object)array)[2] = (ValueTuple<, >)num6;
			_parser = (MessageParser<FurnitureRequestItemData>)(object)array;
		}
	}
}
