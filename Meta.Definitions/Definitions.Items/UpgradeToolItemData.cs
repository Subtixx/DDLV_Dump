using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000303")]
	public sealed class UpgradeToolItemData : IMessage<UpgradeToolItemData>, IMessage, IEquatable<UpgradeToolItemData>, IDeepCloneable<UpgradeToolItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000ED0")]
		private static readonly MessageParser<UpgradeToolItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000ED1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000ED2")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000ED3")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000ED4")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000ED5")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000ED6")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000ED7")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000ED8")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000ED9")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EDA")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000EDB")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EDC")]
		public const int ToolFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000EDD")]
		private int tool_;

		[Cpp2IlInjected.Token(Token = "0x4000EDE")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000EDF")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x17000847")]
		[DebuggerNonUserCode]
		public static MessageParser<UpgradeToolItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002243")]
			[Cpp2IlInjected.Address(RVA = "0x17C12F0", Offset = "0x17BFCF0", VA = "0x1817C12F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000848")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002244")]
			[Cpp2IlInjected.Address(RVA = "0x17C11C0", Offset = "0x17BFBC0", VA = "0x1817C11C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000849")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002245")]
			[Cpp2IlInjected.Address(RVA = "0x17C13B0", Offset = "0x17BFDB0", VA = "0x1817C13B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084A")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002249")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x600224A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084B")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600224B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600224C")]
			[Cpp2IlInjected.Address(RVA = "0x17C15A0", Offset = "0x17BFFA0", VA = "0x1817C15A0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084C")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600224D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600224E")]
			[Cpp2IlInjected.Address(RVA = "0x17C14C0", Offset = "0x17BFEC0", VA = "0x1817C14C0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084D")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600224F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002250")]
			[Cpp2IlInjected.Address(RVA = "0x17C1530", Offset = "0x17BFF30", VA = "0x1817C1530")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084E")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002251")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002252")]
			[Cpp2IlInjected.Address(RVA = "0x17C1610", Offset = "0x17C0010", VA = "0x1817C1610")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084F")]
		[DebuggerNonUserCode]
		public int Tool
		{
			[Cpp2IlInjected.Token(Token = "0x6002253")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return tool_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002254")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				tool_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000850")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002255")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002256")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000851")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002262")]
			[Cpp2IlInjected.Address(RVA = "0x17C1290", Offset = "0x17BFC90", VA = "0x1817C1290", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000852")]
		public Item ToolItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002263")]
			[Cpp2IlInjected.Address(RVA = "0x17C1350", Offset = "0x17BFD50", VA = "0x1817C1350")]
			get
			{
				long num = Convert.ToInt64((uint)tool_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002246")]
		[Cpp2IlInjected.Address(RVA = "0x17C1140", Offset = "0x17BFB40", VA = "0x1817C1140")]
		[DebuggerNonUserCode]
		public UpgradeToolItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002247")]
		[Cpp2IlInjected.Address(RVA = "0x17C1010", Offset = "0x17BFA10", VA = "0x1817C1010")]
		[DebuggerNonUserCode]
		public UpgradeToolItemData(UpgradeToolItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (tool_ = other.tool_);
			uint num3 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002248")]
		[Cpp2IlInjected.Address(RVA = "0x17C01D0", Offset = "0x17BEBD0", VA = "0x1817C01D0", Slot = "10")]
		[DebuggerNonUserCode]
		public UpgradeToolItemData Clone()
		{
			//Discarded unreachable code: IL_00b3
			UpgradeToolItemData upgradeToolItemData = new UpgradeToolItemData();
			upgradeToolItemData.name_ = "";
			upgradeToolItemData.displayName_ = "";
			upgradeToolItemData.iconAddress_ = "";
			upgradeToolItemData.prefabAddress_ = "";
			int num = (upgradeToolItemData.iD_ = iD_);
			string text = (upgradeToolItemData.name_ = name_);
			string text2 = (upgradeToolItemData.displayName_ = displayName_);
			string text3 = (upgradeToolItemData.iconAddress_ = iconAddress_);
			string text4 = (upgradeToolItemData.prefabAddress_ = prefabAddress_);
			int num2 = (upgradeToolItemData.tool_ = tool_);
			uint num3 = (upgradeToolItemData.glotID_ = glotID_);
			UnknownFieldSet unknownFieldSet = (upgradeToolItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return upgradeToolItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x6002257")]
		[Cpp2IlInjected.Address(RVA = "0x17C0430", Offset = "0x17BEE30", VA = "0x1817C0430", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(UpgradeToolItemData).TypeHandle)
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
								if (!flag4 && tool_ == (flag4 ? 1 : 0) && glotID_ == (flag4 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x6002258")]
		[Cpp2IlInjected.Address(RVA = "0x17C0540", Offset = "0x17BEF40", VA = "0x1817C0540", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpgradeToolItemData other)
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
									int num2 = other.tool_;
									if (tool_ == num2)
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

		[Cpp2IlInjected.Token(Token = "0x6002259")]
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
			if (tool_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x600225A")]
		[Cpp2IlInjected.Address(RVA = "0x17C0D10", Offset = "0x17BF710", VA = "0x1817C0D10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600225B")]
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
			if (tool_ != 0)
			{
				int value6 = tool_;
				output.WriteInt32(value6);
			}
			if (glotID_ != 0)
			{
				uint value7 = glotID_;
				output.WriteUInt32(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600225C")]
		[Cpp2IlInjected.Address(RVA = "0x17BFEC0", Offset = "0x17BE8C0", VA = "0x1817BFEC0", Slot = "7")]
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
			int num8 = tool_;
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

		[Cpp2IlInjected.Token(Token = "0x600225D")]
		[Cpp2IlInjected.Address(RVA = "0x17C09C0", Offset = "0x17BF3C0", VA = "0x1817C09C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpgradeToolItemData other)
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
				int num2 = other.tool_;
				if (num2 != 0)
				{
					tool_ = num2;
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

		[Cpp2IlInjected.Token(Token = "0x600225E")]
		[Cpp2IlInjected.Address(RVA = "0x17C0880", Offset = "0x17BF280", VA = "0x1817C0880", Slot = "5")]
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
						int num2 = (tool_ = input.ReadInt32());
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

		[Cpp2IlInjected.Token(Token = "0x600225F")]
		[Cpp2IlInjected.Address(RVA = "0x17C0610", Offset = "0x17BF010", VA = "0x1817C0610", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6002260")]
		[Cpp2IlInjected.Address(RVA = "0x17C0AA0", Offset = "0x17BF4A0", VA = "0x1817C0AA0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6002261")]
		[Cpp2IlInjected.Address(RVA = "0x17C00B0", Offset = "0x17BEAB0", VA = "0x1817C00B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014
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

		[Cpp2IlInjected.Token(Token = "0x6002264")]
		[Cpp2IlInjected.Address(RVA = "0x17C01D0", Offset = "0x17BEBD0", VA = "0x1817C01D0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			UpgradeToolItemData upgradeToolItemData = new UpgradeToolItemData();
			upgradeToolItemData.name_ = "";
			upgradeToolItemData.displayName_ = "";
			upgradeToolItemData.iconAddress_ = "";
			upgradeToolItemData.prefabAddress_ = "";
			int num = (upgradeToolItemData.iD_ = iD_);
			string text = (upgradeToolItemData.name_ = name_);
			string text2 = (upgradeToolItemData.displayName_ = displayName_);
			string text3 = (upgradeToolItemData.iconAddress_ = iconAddress_);
			string text4 = (upgradeToolItemData.prefabAddress_ = prefabAddress_);
			int num2 = (upgradeToolItemData.tool_ = tool_);
			uint num3 = (upgradeToolItemData.glotID_ = glotID_);
			UnknownFieldSet unknownFieldSet = (upgradeToolItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002265")]
		[Cpp2IlInjected.Address(RVA = "0x17C0330", Offset = "0x17BED30", VA = "0x1817C0330", Slot = "23")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0020
			int num = tool_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				context.AddInvalidMemberError("Cannot be None", "Tool");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002266")]
		[Cpp2IlInjected.Address(RVA = "0x17C0F00", Offset = "0x17BF900", VA = "0x1817C0F00")]
		static UpgradeToolItemData()
		{
			Func<UpgradeToolItemData> func = default(Func<UpgradeToolItemData>);
			_parser = (MessageParser<UpgradeToolItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
