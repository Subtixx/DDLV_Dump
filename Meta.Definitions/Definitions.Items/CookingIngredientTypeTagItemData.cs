using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000310")]
	public sealed class CookingIngredientTypeTagItemData : IMessage<CookingIngredientTypeTagItemData>, IMessage, IEquatable<CookingIngredientTypeTagItemData>, IDeepCloneable<CookingIngredientTypeTagItemData>, IMessageFieldAccessor, ITagData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4000F68")]
		private static readonly MessageParser<CookingIngredientTypeTagItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F69")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000F6A")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F6B")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000F6C")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F6D")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F6E")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F6F")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F70")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F71")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F72")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F73")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F74")]
		public const int AlternativeIconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F75")]
		private string alternativeIconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F76")]
		public const int HtmlColorFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F77")]
		private string htmlColor_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F78")]
		public const int SortPriorityFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000F79")]
		private int sortPriority_;

		[Cpp2IlInjected.Token(Token = "0x170008A4")]
		[DebuggerNonUserCode]
		public static MessageParser<CookingIngredientTypeTagItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002355")]
			[Cpp2IlInjected.Address(RVA = "0x3283C70", Offset = "0x3282670", VA = "0x183283C70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002356")]
			[Cpp2IlInjected.Address(RVA = "0x3283BA0", Offset = "0x32825A0", VA = "0x183283BA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002357")]
			[Cpp2IlInjected.Address(RVA = "0x3283CD0", Offset = "0x32826D0", VA = "0x183283CD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A7")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x600235B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x600235C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A8")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600235D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600235E")]
			[Cpp2IlInjected.Address(RVA = "0x3283FA0", Offset = "0x32829A0", VA = "0x183283FA0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A9")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600235F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002360")]
			[Cpp2IlInjected.Address(RVA = "0x3283E50", Offset = "0x3282850", VA = "0x183283E50")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AA")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002361")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002362")]
			[Cpp2IlInjected.Address(RVA = "0x3283F30", Offset = "0x3282930", VA = "0x183283F30")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AB")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002363")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002364")]
			[Cpp2IlInjected.Address(RVA = "0x3284010", Offset = "0x3282A10", VA = "0x183284010")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AC")]
		[DebuggerNonUserCode]
		public string AlternativeIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002365")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "14")]
			get
			{
				return alternativeIconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002366")]
			[Cpp2IlInjected.Address(RVA = "0x3283DE0", Offset = "0x32827E0", VA = "0x183283DE0")]
			set
			{
				string text = (alternativeIconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AD")]
		[DebuggerNonUserCode]
		public string HtmlColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002367")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return htmlColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002368")]
			[Cpp2IlInjected.Address(RVA = "0x3283EC0", Offset = "0x32828C0", VA = "0x183283EC0")]
			set
			{
				string text = (htmlColor_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AE")]
		[DebuggerNonUserCode]
		public int SortPriority
		{
			[Cpp2IlInjected.Token(Token = "0x6002369")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return sortPriority_;
			}
			[Cpp2IlInjected.Token(Token = "0x600236A")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				sortPriority_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AF")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002376")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002358")]
		[Cpp2IlInjected.Address(RVA = "0x3283970", Offset = "0x3282370", VA = "0x183283970")]
		[DebuggerNonUserCode]
		public CookingIngredientTypeTagItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002359")]
		[Cpp2IlInjected.Address(RVA = "0x3283A20", Offset = "0x3282420", VA = "0x183283A20")]
		[DebuggerNonUserCode]
		public CookingIngredientTypeTagItemData(CookingIngredientTypeTagItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x600235A")]
		[Cpp2IlInjected.Address(RVA = "0x3282A70", Offset = "0x3281470", VA = "0x183282A70", Slot = "10")]
		[DebuggerNonUserCode]
		public CookingIngredientTypeTagItemData Clone()
		{
			//Discarded unreachable code: IL_00d9
			CookingIngredientTypeTagItemData cookingIngredientTypeTagItemData = new CookingIngredientTypeTagItemData();
			cookingIngredientTypeTagItemData.name_ = "";
			cookingIngredientTypeTagItemData.displayName_ = "";
			cookingIngredientTypeTagItemData.iconAddress_ = "";
			cookingIngredientTypeTagItemData.prefabAddress_ = "";
			cookingIngredientTypeTagItemData.alternativeIconAddress_ = "";
			cookingIngredientTypeTagItemData.htmlColor_ = "";
			int num = (cookingIngredientTypeTagItemData.iD_ = iD_);
			string text = (cookingIngredientTypeTagItemData.name_ = name_);
			string text2 = (cookingIngredientTypeTagItemData.displayName_ = displayName_);
			string text3 = (cookingIngredientTypeTagItemData.iconAddress_ = iconAddress_);
			string text4 = (cookingIngredientTypeTagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (cookingIngredientTypeTagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (cookingIngredientTypeTagItemData.htmlColor_ = htmlColor_);
			int num2 = (cookingIngredientTypeTagItemData.sortPriority_ = sortPriority_);
			UnknownFieldSet unknownFieldSet = (cookingIngredientTypeTagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return cookingIngredientTypeTagItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600236B")]
		[Cpp2IlInjected.Address(RVA = "0x3282D10", Offset = "0x3281710", VA = "0x183282D10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(CookingIngredientTypeTagItemData).TypeHandle)
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

		[Cpp2IlInjected.Token(Token = "0x600236C")]
		[Cpp2IlInjected.Address(RVA = "0x3282C20", Offset = "0x3281620", VA = "0x183282C20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CookingIngredientTypeTagItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x600236D")]
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

		[Cpp2IlInjected.Token(Token = "0x600236E")]
		[Cpp2IlInjected.Address(RVA = "0x3283630", Offset = "0x3282030", VA = "0x183283630", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600236F")]
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

		[Cpp2IlInjected.Token(Token = "0x6002370")]
		[Cpp2IlInjected.Address(RVA = "0x32826F0", Offset = "0x32810F0", VA = "0x1832826F0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6002371")]
		[Cpp2IlInjected.Address(RVA = "0x3283100", Offset = "0x3281B00", VA = "0x183283100", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CookingIngredientTypeTagItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x6002372")]
		[Cpp2IlInjected.Address(RVA = "0x3283210", Offset = "0x3281C10", VA = "0x183283210", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6002373")]
		[Cpp2IlInjected.Address(RVA = "0x3282E50", Offset = "0x3281850", VA = "0x183282E50", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6002374")]
		[Cpp2IlInjected.Address(RVA = "0x3283390", Offset = "0x3281D90", VA = "0x183283390", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6002375")]
		[Cpp2IlInjected.Address(RVA = "0x3282930", Offset = "0x3281330", VA = "0x183282930", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x6002377")]
		[Cpp2IlInjected.Address(RVA = "0x3282A70", Offset = "0x3281470", VA = "0x183282A70", Slot = "22")]
		IItemData IItemData.Clone()
		{
			CookingIngredientTypeTagItemData cookingIngredientTypeTagItemData = new CookingIngredientTypeTagItemData();
			cookingIngredientTypeTagItemData.name_ = "";
			cookingIngredientTypeTagItemData.displayName_ = "";
			cookingIngredientTypeTagItemData.iconAddress_ = "";
			cookingIngredientTypeTagItemData.prefabAddress_ = "";
			cookingIngredientTypeTagItemData.alternativeIconAddress_ = "";
			cookingIngredientTypeTagItemData.htmlColor_ = "";
			int num = (cookingIngredientTypeTagItemData.iD_ = iD_);
			string text = (cookingIngredientTypeTagItemData.name_ = name_);
			string text2 = (cookingIngredientTypeTagItemData.displayName_ = displayName_);
			string text3 = (cookingIngredientTypeTagItemData.iconAddress_ = iconAddress_);
			string text4 = (cookingIngredientTypeTagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (cookingIngredientTypeTagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (cookingIngredientTypeTagItemData.htmlColor_ = htmlColor_);
			int num2 = (cookingIngredientTypeTagItemData.sortPriority_ = sortPriority_);
			UnknownFieldSet unknownFieldSet = (cookingIngredientTypeTagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002378")]
		[Cpp2IlInjected.Address(RVA = "0x3283860", Offset = "0x3282260", VA = "0x183283860")]
		static CookingIngredientTypeTagItemData()
		{
			Func<CookingIngredientTypeTagItemData> func = default(Func<CookingIngredientTypeTagItemData>);
			_parser = (MessageParser<CookingIngredientTypeTagItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
