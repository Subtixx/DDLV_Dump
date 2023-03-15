using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002FB")]
	public sealed class ToolItemData : IMessage<ToolItemData>, IMessage, IEquatable<ToolItemData>, IDeepCloneable<ToolItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000E70")]
		private static readonly MessageParser<ToolItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E71")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000E72")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000E73")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000E74")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E75")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E76")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000E77")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E78")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000E79")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E7A")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000E7B")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E7C")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000E7D")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000E7E")]
		public const int DefaultUpgradeFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000E7F")]
		private int defaultUpgrade_;

		[Cpp2IlInjected.Token(Token = "0x4000E80")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000E81")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x17000809")]
		[DebuggerNonUserCode]
		public static MessageParser<ToolItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600218E")]
			[Cpp2IlInjected.Address(RVA = "0x354C460", Offset = "0x354AE60", VA = "0x18354C460")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600218F")]
			[Cpp2IlInjected.Address(RVA = "0x354C390", Offset = "0x354AD90", VA = "0x18354C390")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002190")]
			[Cpp2IlInjected.Address(RVA = "0x354C4C0", Offset = "0x354AEC0", VA = "0x18354C4C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080C")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002195")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002196")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080D")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002197")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002198")]
			[Cpp2IlInjected.Address(RVA = "0x354C6B0", Offset = "0x354B0B0", VA = "0x18354C6B0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080E")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002199")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600219A")]
			[Cpp2IlInjected.Address(RVA = "0x354C5D0", Offset = "0x354AFD0", VA = "0x18354C5D0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080F")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600219B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600219C")]
			[Cpp2IlInjected.Address(RVA = "0x354C640", Offset = "0x354B040", VA = "0x18354C640")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000810")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600219D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600219E")]
			[Cpp2IlInjected.Address(RVA = "0x354C720", Offset = "0x354B120", VA = "0x18354C720")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000811")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x600219F")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021A0")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000812")]
		[DebuggerNonUserCode]
		public int DefaultUpgrade
		{
			[Cpp2IlInjected.Token(Token = "0x60021A1")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return defaultUpgrade_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021A2")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				defaultUpgrade_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000813")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60021A3")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021A4")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000814")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60021B0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000815")]
		public Item DefaultUpgradeItem
		{
			[Cpp2IlInjected.Token(Token = "0x60021B1")]
			[Cpp2IlInjected.Address(RVA = "0x354C330", Offset = "0x354AD30", VA = "0x18354C330")]
			get
			{
				long num = Convert.ToInt64((uint)defaultUpgrade_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002191")]
		[Cpp2IlInjected.Address(RVA = "0x354C260", Offset = "0x354AC60", VA = "0x18354C260")]
		[DebuggerNonUserCode]
		public ToolItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002192")]
		[Cpp2IlInjected.Address(RVA = "0x354BA70", Offset = "0x354A470", VA = "0x18354BA70")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002193")]
		[Cpp2IlInjected.Address(RVA = "0x354C0C0", Offset = "0x354AAC0", VA = "0x18354C0C0")]
		[DebuggerNonUserCode]
		public ToolItemData(ToolItemData other)
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
			int num3 = (defaultUpgrade_ = other.defaultUpgrade_);
			uint num4 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002194")]
		[Cpp2IlInjected.Address(RVA = "0x354AE60", Offset = "0x3549860", VA = "0x18354AE60", Slot = "10")]
		[DebuggerNonUserCode]
		public ToolItemData Clone()
		{
			//Discarded unreachable code: IL_00e3
			//IL_00ac: Expected O, but got I4
			ToolItemData toolItemData = new ToolItemData();
			toolItemData.name_ = "";
			toolItemData.displayName_ = "";
			toolItemData.iconAddress_ = "";
			toolItemData.prefabAddress_ = "";
			GridAreaData gridAreaData = (toolItemData.gridAreaData_ = new GridAreaData());
			int num = (toolItemData.iD_ = iD_);
			string text = (toolItemData.name_ = name_);
			string text2 = (toolItemData.displayName_ = displayName_);
			string text3 = (toolItemData.iconAddress_ = iconAddress_);
			string text4 = (toolItemData.prefabAddress_ = prefabAddress_);
			GridAreaData gridAreaData2 = gridAreaData_;
			if (gridAreaData2 != null)
			{
				GridAreaData gridAreaData3 = gridAreaData2.Clone();
			}
			int num2 = 0;
			toolItemData.gridAreaData_ = (GridAreaData)num2;
			int num3 = (toolItemData.defaultUpgrade_ = defaultUpgrade_);
			uint num4 = (toolItemData.glotID_ = glotID_);
			UnknownFieldSet unknownFieldSet = (toolItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return toolItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x60021A5")]
		[Cpp2IlInjected.Address(RVA = "0x354B370", Offset = "0x3549D70", VA = "0x18354B370", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(ToolItemData).TypeHandle)
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
									if (flag5 && defaultUpgrade_ == (flag5 ? 1 : 0) && glotID_ == (flag5 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x60021A6")]
		[Cpp2IlInjected.Address(RVA = "0x354B290", Offset = "0x3549C90", VA = "0x18354B290", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ToolItemData other)
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
										int num2 = other.defaultUpgrade_;
										if (defaultUpgrade_ == num2)
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
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021A7")]
		[Cpp2IlInjected.Address(RVA = "0x354B600", Offset = "0x354A000", VA = "0x18354B600", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b1
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
			if (defaultUpgrade_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x60021A8")]
		[Cpp2IlInjected.Address(RVA = "0x354BD90", Offset = "0x354A790", VA = "0x18354BD90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60021A9")]
		[Cpp2IlInjected.Address(RVA = "0x354BDF0", Offset = "0x354A7F0", VA = "0x18354BDF0", Slot = "6")]
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
			if (defaultUpgrade_ != 0)
			{
				int value7 = defaultUpgrade_;
				output.WriteInt32(value7);
			}
			if (glotID_ != 0)
			{
				uint value8 = glotID_;
				output.WriteUInt32(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60021AA")]
		[Cpp2IlInjected.Address(RVA = "0x354AB00", Offset = "0x3549500", VA = "0x18354AB00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_012a
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
			int num9 = defaultUpgrade_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			uint num11 = glotID_;
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

		[Cpp2IlInjected.Token(Token = "0x60021AB")]
		[Cpp2IlInjected.Address(RVA = "0x354B750", Offset = "0x354A150", VA = "0x18354B750", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ToolItemData other)
		{
			//Discarded unreachable code: IL_00ff
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
			int num2 = other.defaultUpgrade_;
			if (num2 != 0)
			{
				defaultUpgrade_ = num2;
			}
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60021AC")]
		[Cpp2IlInjected.Address(RVA = "0x354B8B0", Offset = "0x354A2B0", VA = "0x18354B8B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_010a
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 56)
					{
						int num2 = (defaultUpgrade_ = input.ReadInt32());
					}
					if (num != 7992)
					{
						goto IL_00f3;
					}
					int num3 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 42)
				{
					text2 = (PrefabAddress = input.ReadString());
				}
				if ((long)text2 != 50)
				{
					goto IL_00f3;
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
					goto IL_00f3;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text6 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_00f3;
			IL_00f3:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60021AD")]
		[Cpp2IlInjected.Address(RVA = "0x354B4A0", Offset = "0x3549EA0", VA = "0x18354B4A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021AE")]
		[Cpp2IlInjected.Address(RVA = "0x354BAD0", Offset = "0x354A4D0", VA = "0x18354BAD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0019, IL_001a, IL_001b, IL_003a, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_0039: Expected I4, but got O
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

		[Cpp2IlInjected.Token(Token = "0x60021AF")]
		[Cpp2IlInjected.Address(RVA = "0x354AD20", Offset = "0x3549720", VA = "0x18354AD20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014
			//IL_000f: Expected I4, but got I8
			//IL_0026: Expected I4, but got I8
			if (fieldNumber - 1 <= 6)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021B2")]
		[Cpp2IlInjected.Address(RVA = "0x354B280", Offset = "0x3549C80", VA = "0x18354B280", Slot = "20")]
		IItemData IItemData.Clone()
		{
			ToolItemData toolItemData = Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021B3")]
		[Cpp2IlInjected.Address(RVA = "0x354B030", Offset = "0x3549A30", VA = "0x18354B030", Slot = "24")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0044
			int num = defaultUpgrade_;
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num2 = Convert.ToInt64((uint)defaultUpgrade_);
				UpgradeToolItemData upgradeToolItemData = default(UpgradeToolItemData);
				Item toolItem = upgradeToolItemData.ToolItem;
				int num3 = iD_;
				bool flag2 = default(bool);
				if (flag2)
				{
					context.AddInvalidMemberError("Tool & Upgrade mismatch", "DefaultUpgrade");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021B4")]
		[Cpp2IlInjected.Address(RVA = "0x354BFB0", Offset = "0x354A9B0", VA = "0x18354BFB0")]
		static ToolItemData()
		{
			Func<ToolItemData> func = default(Func<ToolItemData>);
			_parser = (MessageParser<ToolItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
