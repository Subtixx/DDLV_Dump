using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000301")]
	public sealed class UpgradeBackpackItemData : IMessage<UpgradeBackpackItemData>, IMessage, IEquatable<UpgradeBackpackItemData>, IDeepCloneable<UpgradeBackpackItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGenericBuyable, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000EBF")]
		private static readonly MessageParser<UpgradeBackpackItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000EC0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000EC1")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000EC2")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000EC3")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000EC4")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EC5")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000EC6")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EC7")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000EC8")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EC9")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000ECA")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000ECB")]
		public const int BackpackExpansionSizeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000ECC")]
		private int backpackExpansionSize_;

		[Cpp2IlInjected.Token(Token = "0x4000ECD")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000ECE")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x1700083B")]
		[DebuggerNonUserCode]
		public static MessageParser<UpgradeBackpackItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600221C")]
			[Cpp2IlInjected.Address(RVA = "0x3558D20", Offset = "0x3557720", VA = "0x183558D20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600221D")]
			[Cpp2IlInjected.Address(RVA = "0x3558BF0", Offset = "0x35575F0", VA = "0x183558BF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600221E")]
			[Cpp2IlInjected.Address(RVA = "0x3558D80", Offset = "0x3557780", VA = "0x183558D80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083E")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002222")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002223")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083F")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002224")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002225")]
			[Cpp2IlInjected.Address(RVA = "0x3558F70", Offset = "0x3557970", VA = "0x183558F70")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000840")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002226")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002227")]
			[Cpp2IlInjected.Address(RVA = "0x3558E90", Offset = "0x3557890", VA = "0x183558E90")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000841")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002228")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002229")]
			[Cpp2IlInjected.Address(RVA = "0x3558F00", Offset = "0x3557900", VA = "0x183558F00")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000842")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600222A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600222B")]
			[Cpp2IlInjected.Address(RVA = "0x3558FE0", Offset = "0x35579E0", VA = "0x183558FE0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000843")]
		[DebuggerNonUserCode]
		public int BackpackExpansionSize
		{
			[Cpp2IlInjected.Token(Token = "0x600222C")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return backpackExpansionSize_;
			}
			[Cpp2IlInjected.Token(Token = "0x600222D")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				backpackExpansionSize_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000844")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x600222E")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600222F")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000845")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600223B")]
			[Cpp2IlInjected.Address(RVA = "0x3558CC0", Offset = "0x35576C0", VA = "0x183558CC0", Slot = "23")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000846")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x600223D")]
			[Cpp2IlInjected.Address(RVA = "0x3558190", Offset = "0x3556B90", VA = "0x183558190", Slot = "24")]
			get
			{
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600221F")]
		[Cpp2IlInjected.Address(RVA = "0x3558B70", Offset = "0x3557570", VA = "0x183558B70")]
		[DebuggerNonUserCode]
		public UpgradeBackpackItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002220")]
		[Cpp2IlInjected.Address(RVA = "0x3558A40", Offset = "0x3557440", VA = "0x183558A40")]
		[DebuggerNonUserCode]
		public UpgradeBackpackItemData(UpgradeBackpackItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (backpackExpansionSize_ = other.backpackExpansionSize_);
			uint num3 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002221")]
		[Cpp2IlInjected.Address(RVA = "0x3557FC0", Offset = "0x35569C0", VA = "0x183557FC0", Slot = "10")]
		[DebuggerNonUserCode]
		public UpgradeBackpackItemData Clone()
		{
			//Discarded unreachable code: IL_00b3
			UpgradeBackpackItemData upgradeBackpackItemData = new UpgradeBackpackItemData();
			upgradeBackpackItemData.name_ = "";
			upgradeBackpackItemData.displayName_ = "";
			upgradeBackpackItemData.iconAddress_ = "";
			upgradeBackpackItemData.prefabAddress_ = "";
			int num = (upgradeBackpackItemData.iD_ = iD_);
			string text = (upgradeBackpackItemData.name_ = name_);
			string text2 = (upgradeBackpackItemData.displayName_ = displayName_);
			string text3 = (upgradeBackpackItemData.iconAddress_ = iconAddress_);
			string text4 = (upgradeBackpackItemData.prefabAddress_ = prefabAddress_);
			int num2 = (upgradeBackpackItemData.backpackExpansionSize_ = backpackExpansionSize_);
			uint num3 = (upgradeBackpackItemData.glotID_ = glotID_);
			UnknownFieldSet unknownFieldSet = (upgradeBackpackItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return upgradeBackpackItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x6002230")]
		[Cpp2IlInjected.Address(RVA = "0x35581F0", Offset = "0x3556BF0", VA = "0x1835581F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(UpgradeBackpackItemData).TypeHandle)
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
								if (!flag4 && backpackExpansionSize_ == (flag4 ? 1 : 0) && glotID_ == (flag4 ? 1u : 0u))
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002231")]
		[Cpp2IlInjected.Address(RVA = "0x17C0540", Offset = "0x17BEF40", VA = "0x1817C0540", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpgradeBackpackItemData other)
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
									int num2 = other.backpackExpansionSize_;
									if (backpackExpansionSize_ == num2)
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
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002232")]
		[Cpp2IlInjected.Address(RVA = "0x17C0750", Offset = "0x17BF150", VA = "0x1817C0750", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_009b
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
			if (backpackExpansionSize_ != 0)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002233")]
		[Cpp2IlInjected.Address(RVA = "0x35588D0", Offset = "0x35572D0", VA = "0x1835588D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002234")]
		[Cpp2IlInjected.Address(RVA = "0x17C0D70", Offset = "0x17BF770", VA = "0x1817C0D70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d2
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
			if (backpackExpansionSize_ != 0)
			{
				int value6 = backpackExpansionSize_;
				output.WriteInt32(value6);
			}
			if (glotID_ != 0)
			{
				uint value7 = glotID_;
				output.WriteUInt32(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002235")]
		[Cpp2IlInjected.Address(RVA = "0x3557CB0", Offset = "0x35566B0", VA = "0x183557CB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0109
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
			int num8 = backpackExpansionSize_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			uint num10 = glotID_;
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

		[Cpp2IlInjected.Token(Token = "0x6002236")]
		[Cpp2IlInjected.Address(RVA = "0x3558580", Offset = "0x3556F80", VA = "0x183558580", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpgradeBackpackItemData other)
		{
			//Discarded unreachable code: IL_00c3
			if (other != null)
			{
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
				int num2 = other.backpackExpansionSize_;
				if (num2 != 0)
				{
					backpackExpansionSize_ = num2;
				}
				uint num3 = other.glotID_;
				if (num3 != 0)
				{
					glotID_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002237")]
		[Cpp2IlInjected.Address(RVA = "0x3558440", Offset = "0x3556E40", VA = "0x183558440", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ce
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					if (num == 48)
					{
						int num2 = (backpackExpansionSize_ = input.ReadInt32());
					}
					if (num != 7992)
					{
						goto IL_00b7;
					}
					int num3 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_00b7;
				}
				string text4 = (PrefabAddress = input.ReadString());
			}
			int num4 = default(int);
			if (num == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num4 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_00b7;
			IL_00b7:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002238")]
		[Cpp2IlInjected.Address(RVA = "0x3558300", Offset = "0x3556D00", VA = "0x183558300", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002239")]
		[Cpp2IlInjected.Address(RVA = "0x3558660", Offset = "0x3557060", VA = "0x183558660", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0019, IL_001a, IL_001b, IL_0028, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058, IL_005e
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			//IL_003f: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
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

		[Cpp2IlInjected.Token(Token = "0x600223A")]
		[Cpp2IlInjected.Address(RVA = "0x3557EA0", Offset = "0x35568A0", VA = "0x183557EA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0027, IL_002f
			//IL_000f: Expected I4, but got I8
			//IL_0026: Expected I4, but got I8
			if (fieldNumber - 1 <= 5)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600223C")]
		[Cpp2IlInjected.Address(RVA = "0x3557FC0", Offset = "0x35569C0", VA = "0x183557FC0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			UpgradeBackpackItemData upgradeBackpackItemData = new UpgradeBackpackItemData();
			upgradeBackpackItemData.name_ = "";
			upgradeBackpackItemData.displayName_ = "";
			upgradeBackpackItemData.iconAddress_ = "";
			upgradeBackpackItemData.prefabAddress_ = "";
			int num = (upgradeBackpackItemData.iD_ = iD_);
			string text = (upgradeBackpackItemData.name_ = name_);
			string text2 = (upgradeBackpackItemData.displayName_ = displayName_);
			string text3 = (upgradeBackpackItemData.iconAddress_ = iconAddress_);
			string text4 = (upgradeBackpackItemData.prefabAddress_ = prefabAddress_);
			int num2 = (upgradeBackpackItemData.backpackExpansionSize_ = backpackExpansionSize_);
			uint num3 = (upgradeBackpackItemData.glotID_ = glotID_);
			UnknownFieldSet unknownFieldSet = (upgradeBackpackItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600223E")]
		[Cpp2IlInjected.Address(RVA = "0x3558120", Offset = "0x3556B20", VA = "0x183558120", Slot = "25")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0011
			context.AddInvalidMemberError("Must be greater than 0", "BackpackExpansionSize");
		}

		[Cpp2IlInjected.Token(Token = "0x600223F")]
		[Cpp2IlInjected.Address(RVA = "0x3558930", Offset = "0x3557330", VA = "0x183558930")]
		static UpgradeBackpackItemData()
		{
			Func<UpgradeBackpackItemData> func = default(Func<UpgradeBackpackItemData>);
			_parser = (MessageParser<UpgradeBackpackItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
