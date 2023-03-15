using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200030E")]
	public sealed class CraftingRecipeTypeTagItemData : IMessage<CraftingRecipeTypeTagItemData>, IMessage, IEquatable<CraftingRecipeTypeTagItemData>, IDeepCloneable<CraftingRecipeTypeTagItemData>, IMessageFieldAccessor, ITagData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4000F55")]
		private static readonly MessageParser<CraftingRecipeTypeTagItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F56")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000F57")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F58")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000F59")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F5A")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F5B")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F5C")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F5D")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F5E")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F5F")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F60")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F61")]
		public const int AlternativeIconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F62")]
		private string alternativeIconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F63")]
		public const int HtmlColorFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F64")]
		private string htmlColor_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F65")]
		public const int SortPriorityFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000F66")]
		private int sortPriority_;

		[Cpp2IlInjected.Token(Token = "0x17000898")]
		[DebuggerNonUserCode]
		public static MessageParser<CraftingRecipeTypeTagItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600232E")]
			[Cpp2IlInjected.Address(RVA = "0x3289B60", Offset = "0x3288560", VA = "0x183289B60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000899")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600232F")]
			[Cpp2IlInjected.Address(RVA = "0x3289A90", Offset = "0x3288490", VA = "0x183289A90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002330")]
			[Cpp2IlInjected.Address(RVA = "0x3289BC0", Offset = "0x32885C0", VA = "0x183289BC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089B")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002334")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002335")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089C")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002336")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002337")]
			[Cpp2IlInjected.Address(RVA = "0x3289E90", Offset = "0x3288890", VA = "0x183289E90")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089D")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002338")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002339")]
			[Cpp2IlInjected.Address(RVA = "0x3289D40", Offset = "0x3288740", VA = "0x183289D40")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089E")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600233A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600233B")]
			[Cpp2IlInjected.Address(RVA = "0x3289E20", Offset = "0x3288820", VA = "0x183289E20")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089F")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600233C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600233D")]
			[Cpp2IlInjected.Address(RVA = "0x3289F00", Offset = "0x3288900", VA = "0x183289F00")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A0")]
		[DebuggerNonUserCode]
		public string AlternativeIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600233E")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "14")]
			get
			{
				return alternativeIconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600233F")]
			[Cpp2IlInjected.Address(RVA = "0x3289CD0", Offset = "0x32886D0", VA = "0x183289CD0")]
			set
			{
				string text = (alternativeIconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A1")]
		[DebuggerNonUserCode]
		public string HtmlColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002340")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return htmlColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002341")]
			[Cpp2IlInjected.Address(RVA = "0x3289DB0", Offset = "0x32887B0", VA = "0x183289DB0")]
			set
			{
				string text = (htmlColor_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A2")]
		[DebuggerNonUserCode]
		public int SortPriority
		{
			[Cpp2IlInjected.Token(Token = "0x6002342")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return sortPriority_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002343")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				sortPriority_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A3")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600234F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002331")]
		[Cpp2IlInjected.Address(RVA = "0x32899E0", Offset = "0x32883E0", VA = "0x1832899E0")]
		[DebuggerNonUserCode]
		public CraftingRecipeTypeTagItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002332")]
		[Cpp2IlInjected.Address(RVA = "0x3289860", Offset = "0x3288260", VA = "0x183289860")]
		[DebuggerNonUserCode]
		public CraftingRecipeTypeTagItemData(CraftingRecipeTypeTagItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (alternativeIconAddress_ = other.alternativeIconAddress_);
			string text6 = (htmlColor_ = other.htmlColor_);
			int num2 = (sortPriority_ = other.sortPriority_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002333")]
		[Cpp2IlInjected.Address(RVA = "0x3288D80", Offset = "0x3287780", VA = "0x183288D80", Slot = "10")]
		[DebuggerNonUserCode]
		public CraftingRecipeTypeTagItemData Clone()
		{
			//Discarded unreachable code: IL_00d9
			CraftingRecipeTypeTagItemData craftingRecipeTypeTagItemData = new CraftingRecipeTypeTagItemData();
			craftingRecipeTypeTagItemData.name_ = "";
			craftingRecipeTypeTagItemData.displayName_ = "";
			craftingRecipeTypeTagItemData.iconAddress_ = "";
			craftingRecipeTypeTagItemData.prefabAddress_ = "";
			craftingRecipeTypeTagItemData.alternativeIconAddress_ = "";
			craftingRecipeTypeTagItemData.htmlColor_ = "";
			int num = (craftingRecipeTypeTagItemData.iD_ = iD_);
			string text = (craftingRecipeTypeTagItemData.name_ = name_);
			string text2 = (craftingRecipeTypeTagItemData.displayName_ = displayName_);
			string text3 = (craftingRecipeTypeTagItemData.iconAddress_ = iconAddress_);
			string text4 = (craftingRecipeTypeTagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (craftingRecipeTypeTagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (craftingRecipeTypeTagItemData.htmlColor_ = htmlColor_);
			int num2 = (craftingRecipeTypeTagItemData.sortPriority_ = sortPriority_);
			UnknownFieldSet unknownFieldSet = (craftingRecipeTypeTagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return craftingRecipeTypeTagItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x6002344")]
		[Cpp2IlInjected.Address(RVA = "0x3288F30", Offset = "0x3287930", VA = "0x183288F30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(CraftingRecipeTypeTagItemData).TypeHandle)
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
									string text5 = alternativeIconAddress_;
									bool flag5 = default(bool);
									if (!flag5)
									{
										string text6 = htmlColor_;
										bool flag6 = default(bool);
										if (!flag6 && sortPriority_ == (flag6 ? 1 : 0))
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002345")]
		[Cpp2IlInjected.Address(RVA = "0x3282C20", Offset = "0x3281620", VA = "0x183282C20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CraftingRecipeTypeTagItemData other)
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
									string text5 = other.alternativeIconAddress_;
									if (!(alternativeIconAddress_ != text5))
									{
										string text6 = other.htmlColor_;
										if (!(htmlColor_ != text6))
										{
											int num2 = other.sortPriority_;
											if (sortPriority_ == num2)
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
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002346")]
		[Cpp2IlInjected.Address(RVA = "0x3282FA0", Offset = "0x32819A0", VA = "0x183282FA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00c5
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
			string text5 = alternativeIconAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			string text6 = htmlColor_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			if (sortPriority_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002347")]
		[Cpp2IlInjected.Address(RVA = "0x32896F0", Offset = "0x32880F0", VA = "0x1832896F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002348")]
		[Cpp2IlInjected.Address(RVA = "0x3283690", Offset = "0x3282090", VA = "0x183283690", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00f4
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
			if (alternativeIconAddress_.m_stringLength != 0)
			{
				string value6 = alternativeIconAddress_;
				output.WriteString(value6);
			}
			if (htmlColor_.m_stringLength != 0)
			{
				string value7 = htmlColor_;
				output.WriteString(value7);
			}
			if (sortPriority_ != 0)
			{
				int value8 = sortPriority_;
				output.WriteInt32(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002349")]
		[Cpp2IlInjected.Address(RVA = "0x3288A00", Offset = "0x3287400", VA = "0x183288A00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0133
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
			string text5 = alternativeIconAddress_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			string text6 = htmlColor_;
			if (text6.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text6);
				num9++;
				num2 += num9;
			}
			int num10 = sortPriority_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
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

		[Cpp2IlInjected.Token(Token = "0x600234A")]
		[Cpp2IlInjected.Address(RVA = "0x32891C0", Offset = "0x3287BC0", VA = "0x1832891C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CraftingRecipeTypeTagItemData other)
		{
			//Discarded unreachable code: IL_00e1
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
				string text5 = other.alternativeIconAddress_;
				if (text5.m_stringLength != 0)
				{
					AlternativeIconAddress = text5;
				}
				string text6 = other.htmlColor_;
				if (text6.m_stringLength != 0)
				{
					HtmlColor = text6;
				}
				int num2 = other.sortPriority_;
				if (num2 != 0)
				{
					sortPriority_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600234B")]
		[Cpp2IlInjected.Address(RVA = "0x32892D0", Offset = "0x3287CD0", VA = "0x1832892D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ec
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 58)
					{
						string text2 = (HtmlColor = input.ReadString());
					}
					if (num != 64)
					{
						goto IL_00d5;
					}
					int num2 = (sortPriority_ = input.ReadInt32());
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_00d5;
				}
				string text6 = (AlternativeIconAddress = input.ReadString());
			}
			string text10 = default(string);
			if ((int)num > 18)
			{
				string text8 = default(string);
				if (num == 26)
				{
					text8 = (DisplayName = input.ReadString());
				}
				if ((long)text8 != 34)
				{
					goto IL_00d5;
				}
				text10 = (IconAddress = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text10 == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text12 = (Name = input.ReadString());
			}
			goto IL_00d5;
			IL_00d5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600234C")]
		[Cpp2IlInjected.Address(RVA = "0x3289070", Offset = "0x3287A70", VA = "0x183289070", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600234D")]
		[Cpp2IlInjected.Address(RVA = "0x3289450", Offset = "0x3287E50", VA = "0x183289450", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0021, IL_0029, IL_002f, IL_0035, IL_003b, IL_0041, IL_0047, IL_004d, IL_0053
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 7)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600234E")]
		[Cpp2IlInjected.Address(RVA = "0x3288C40", Offset = "0x3287640", VA = "0x183288C40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 7)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002350")]
		[Cpp2IlInjected.Address(RVA = "0x3288D80", Offset = "0x3287780", VA = "0x183288D80", Slot = "22")]
		IItemData IItemData.Clone()
		{
			CraftingRecipeTypeTagItemData craftingRecipeTypeTagItemData = new CraftingRecipeTypeTagItemData();
			craftingRecipeTypeTagItemData.name_ = "";
			craftingRecipeTypeTagItemData.displayName_ = "";
			craftingRecipeTypeTagItemData.iconAddress_ = "";
			craftingRecipeTypeTagItemData.prefabAddress_ = "";
			craftingRecipeTypeTagItemData.alternativeIconAddress_ = "";
			craftingRecipeTypeTagItemData.htmlColor_ = "";
			int num = (craftingRecipeTypeTagItemData.iD_ = iD_);
			string text = (craftingRecipeTypeTagItemData.name_ = name_);
			string text2 = (craftingRecipeTypeTagItemData.displayName_ = displayName_);
			string text3 = (craftingRecipeTypeTagItemData.iconAddress_ = iconAddress_);
			string text4 = (craftingRecipeTypeTagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (craftingRecipeTypeTagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (craftingRecipeTypeTagItemData.htmlColor_ = htmlColor_);
			int num2 = (craftingRecipeTypeTagItemData.sortPriority_ = sortPriority_);
			UnknownFieldSet unknownFieldSet = (craftingRecipeTypeTagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002351")]
		[Cpp2IlInjected.Address(RVA = "0x3289750", Offset = "0x3288150", VA = "0x183289750")]
		static CraftingRecipeTypeTagItemData()
		{
			Func<CraftingRecipeTypeTagItemData> func = default(Func<CraftingRecipeTypeTagItemData>);
			_parser = (MessageParser<CraftingRecipeTypeTagItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
