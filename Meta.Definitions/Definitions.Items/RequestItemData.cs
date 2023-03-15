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
	[Cpp2IlInjected.Token(Token = "0x20002A5")]
	public sealed class RequestItemData : IMessage<RequestItemData>, IMessage, IEquatable<RequestItemData>, IDeepCloneable<RequestItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IBackpackItem, ISellable, IGridPlaceableItemData, IHasTags, IIsMissionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4000AF1")]
		private static readonly MessageParser<RequestItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000AF2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000AF3")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000AF4")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000AF5")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000AF6")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000AF7")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000AF8")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000AF9")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000AFA")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000AFB")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000AFC")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000AFD")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000AFE")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000AFF")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B00")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000B01")]
		public const int TagsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4000B02")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000B03")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000B04")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000B05")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000B06")]
		public static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x170005D5")]
		[DebuggerNonUserCode]
		public static MessageParser<RequestItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001AF4")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD0B0", Offset = "0x2DABAB0", VA = "0x182DAD0B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001AF5")]
			[Cpp2IlInjected.Address(RVA = "0x2DACFE0", Offset = "0x2DAB9E0", VA = "0x182DACFE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001AF6")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD170", Offset = "0x2DABB70", VA = "0x182DAD170", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D8")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001AFB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AFC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D9")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001AFD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001AFE")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD3D0", Offset = "0x2DABDD0", VA = "0x182DAD3D0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005DA")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001AFF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "24")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B00")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD2F0", Offset = "0x2DABCF0", VA = "0x182DAD2F0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005DB")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B01")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B02")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD360", Offset = "0x2DABD60", VA = "0x182DAD360")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005DC")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B03")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B04")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD440", Offset = "0x2DABE40", VA = "0x182DAD440")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005DD")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001B05")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "27")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B06")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005DE")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6001B07")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B08")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD280", Offset = "0x2DABC80", VA = "0x182DAD280")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005DF")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001B09")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "29")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E0")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001B0A")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B0B")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E1")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001B17")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "23")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E2")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001B18")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD110", Offset = "0x2DABB10", VA = "0x182DAD110", Slot = "28")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E3")]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B19")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "30")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E4")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6001B1A")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "26")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF7")]
		[Cpp2IlInjected.Address(RVA = "0x2DACEB0", Offset = "0x2DAB8B0", VA = "0x182DACEB0")]
		[DebuggerNonUserCode]
		public RequestItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF8")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC470", Offset = "0x2DAAE70", VA = "0x182DAC470")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF9")]
		[Cpp2IlInjected.Address(RVA = "0x2DACC70", Offset = "0x2DAB670", VA = "0x182DACC70")]
		[DebuggerNonUserCode]
		public RequestItemData(RequestItemData other)
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
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			uint num3 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AFA")]
		[Cpp2IlInjected.Address(RVA = "0x2DABA60", Offset = "0x2DAA460", VA = "0x182DABA60", Slot = "10")]
		[DebuggerNonUserCode]
		public RequestItemData Clone()
		{
			return new RequestItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B0C")]
		[Cpp2IlInjected.Address(RVA = "0x2DABAC0", Offset = "0x2DAA4C0", VA = "0x182DABAC0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(RequestItemData).TypeHandle)
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

		[Cpp2IlInjected.Token(Token = "0x6001B0D")]
		[Cpp2IlInjected.Address(RVA = "0x2DABC40", Offset = "0x2DAA640", VA = "0x182DABC40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RequestItemData other)
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
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B0E")]
		[Cpp2IlInjected.Address(RVA = "0x2DABF00", Offset = "0x2DAA900", VA = "0x182DABF00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00d0
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

		[Cpp2IlInjected.Token(Token = "0x6001B0F")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC7E0", Offset = "0x2DAB1E0", VA = "0x182DAC7E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B10")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC840", Offset = "0x2DAB240", VA = "0x182DAC840", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_010b
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
			if (glotID_ != 0)
			{
				uint value8 = glotID_;
				output.WriteUInt32(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B11")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB640", Offset = "0x2DAA040", VA = "0x182DAB640", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_014e
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
			uint num11 = glotID_;
			num2 += num10;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeUInt32Size(num11);
				num12 += 2;
				num2 += num12;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num2 += num13;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B12")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC070", Offset = "0x2DAAA70", VA = "0x182DAC070", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RequestItemData other)
		{
			//Discarded unreachable code: IL_011d
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
			uint num2 = other.glotID_;
			if (num2 != 0)
			{
				glotID_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001B13")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC210", Offset = "0x2DAAC10", VA = "0x182DAC210", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_012d
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 58)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 7992)
						{
							goto IL_0116;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					RepeatedField<int> repeatedField = tags_;
					FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
				}
				if (num == 50)
				{
					GridAreaData gridAreaData = gridAreaData_;
					if (gridAreaData == null)
					{
						GridAreaData gridAreaData2 = (gridAreaData_ = new GridAreaData());
					}
					input.ReadMessage(gridAreaData);
				}
				if (num != 58)
				{
					goto IL_0116;
				}
				string text2 = (Description = input.ReadString());
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
					goto IL_0116;
				}
				text8 = (PrefabAddress = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text8 == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_0116;
			IL_0116:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001B14")]
		[Cpp2IlInjected.Address(RVA = "0x2DABD70", Offset = "0x2DAA770", VA = "0x182DABD70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
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

		[Cpp2IlInjected.Token(Token = "0x6001B15")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC4D0", Offset = "0x2DAAED0", VA = "0x182DAC4D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0019, IL_001a, IL_001b, IL_0033, IL_0039, IL_003f, IL_0045, IL_004b, IL_0051, IL_0057
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_0032: Expected I4, but got O
			if (fieldNumber - 1 <= 7)
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

		[Cpp2IlInjected.Token(Token = "0x6001B16")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB8E0", Offset = "0x2DAA2E0", VA = "0x182DAB8E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0029
			//IL_000f: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			if (fieldNumber - 1 <= 7)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B1B")]
		[Cpp2IlInjected.Address(RVA = "0x2DABA60", Offset = "0x2DAA460", VA = "0x182DABA60", Slot = "20")]
		IItemData IItemData.Clone()
		{
			RequestItemData requestItemData = new RequestItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2DACA90", Offset = "0x2DAB490", VA = "0x182DACA90")]
		static RequestItemData()
		{
			//Discarded unreachable code: IL_0030
			//IL_0029: Expected O, but got I4
			Func<RequestItemData> func = default(Func<RequestItemData>);
			_parser = (MessageParser<RequestItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<RequestItemData>)(object)FieldCodec.ForInt32(66u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<RequestItemData>)(object)array;
		}
	}
}
