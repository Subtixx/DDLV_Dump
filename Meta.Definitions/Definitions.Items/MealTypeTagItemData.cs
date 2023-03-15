using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000312")]
	public sealed class MealTypeTagItemData : IMessage<MealTypeTagItemData>, IMessage, IEquatable<MealTypeTagItemData>, IDeepCloneable<MealTypeTagItemData>, IMessageFieldAccessor, ITagData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4000F7B")]
		private static readonly MessageParser<MealTypeTagItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F7C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000F7D")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F7E")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000F7F")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F80")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F81")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F82")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F83")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F84")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F85")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F86")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F87")]
		public const int AlternativeIconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F88")]
		private string alternativeIconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F89")]
		public const int HtmlColorFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F8A")]
		private string htmlColor_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F8B")]
		public const int PreferredItemCategoryFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000F8C")]
		private PreferredItemCategory preferredItemCategory_;

		[Cpp2IlInjected.Token(Token = "0x4000F8D")]
		public const int SortPriorityFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000F8E")]
		private int sortPriority_;

		[Cpp2IlInjected.Token(Token = "0x170008B0")]
		[DebuggerNonUserCode]
		public static MessageParser<MealTypeTagItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600237C")]
			[Cpp2IlInjected.Address(RVA = "0x306F9B0", Offset = "0x306E3B0", VA = "0x18306F9B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600237D")]
			[Cpp2IlInjected.Address(RVA = "0x306F8E0", Offset = "0x306E2E0", VA = "0x18306F8E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600237E")]
			[Cpp2IlInjected.Address(RVA = "0x306FA10", Offset = "0x306E410", VA = "0x18306FA10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B3")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002382")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002383")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B4")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002384")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002385")]
			[Cpp2IlInjected.Address(RVA = "0x306FCE0", Offset = "0x306E6E0", VA = "0x18306FCE0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B5")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002386")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002387")]
			[Cpp2IlInjected.Address(RVA = "0x306FB90", Offset = "0x306E590", VA = "0x18306FB90")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B6")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002388")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002389")]
			[Cpp2IlInjected.Address(RVA = "0x306FC70", Offset = "0x306E670", VA = "0x18306FC70")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B7")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600238A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600238B")]
			[Cpp2IlInjected.Address(RVA = "0x306FD50", Offset = "0x306E750", VA = "0x18306FD50")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B8")]
		[DebuggerNonUserCode]
		public string AlternativeIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600238C")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "14")]
			get
			{
				return alternativeIconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600238D")]
			[Cpp2IlInjected.Address(RVA = "0x306FB20", Offset = "0x306E520", VA = "0x18306FB20")]
			set
			{
				string text = (alternativeIconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B9")]
		[DebuggerNonUserCode]
		public string HtmlColor
		{
			[Cpp2IlInjected.Token(Token = "0x600238E")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return htmlColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x600238F")]
			[Cpp2IlInjected.Address(RVA = "0x306FC00", Offset = "0x306E600", VA = "0x18306FC00")]
			set
			{
				string text = (htmlColor_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BA")]
		[DebuggerNonUserCode]
		public PreferredItemCategory PreferredItemCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6002390")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return preferredItemCategory_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002391")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				preferredItemCategory_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BB")]
		[DebuggerNonUserCode]
		public int SortPriority
		{
			[Cpp2IlInjected.Token(Token = "0x6002392")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return sortPriority_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002393")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				sortPriority_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BC")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600239F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600237F")]
		[Cpp2IlInjected.Address(RVA = "0x306F6B0", Offset = "0x306E0B0", VA = "0x18306F6B0")]
		[DebuggerNonUserCode]
		public MealTypeTagItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002380")]
		[Cpp2IlInjected.Address(RVA = "0x306F760", Offset = "0x306E160", VA = "0x18306F760")]
		[DebuggerNonUserCode]
		public MealTypeTagItemData(MealTypeTagItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (alternativeIconAddress_ = other.alternativeIconAddress_);
			string text6 = (htmlColor_ = other.htmlColor_);
			PreferredItemCategory preferredItemCategory = (preferredItemCategory_ = other.preferredItemCategory_);
			int num2 = (sortPriority_ = other.sortPriority_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002381")]
		[Cpp2IlInjected.Address(RVA = "0x306E6B0", Offset = "0x306D0B0", VA = "0x18306E6B0", Slot = "10")]
		[DebuggerNonUserCode]
		public MealTypeTagItemData Clone()
		{
			//Discarded unreachable code: IL_00e9
			MealTypeTagItemData mealTypeTagItemData = new MealTypeTagItemData();
			mealTypeTagItemData.name_ = "";
			mealTypeTagItemData.displayName_ = "";
			mealTypeTagItemData.iconAddress_ = "";
			mealTypeTagItemData.prefabAddress_ = "";
			mealTypeTagItemData.alternativeIconAddress_ = "";
			mealTypeTagItemData.htmlColor_ = "";
			int num = (mealTypeTagItemData.iD_ = iD_);
			string text = (mealTypeTagItemData.name_ = name_);
			string text2 = (mealTypeTagItemData.displayName_ = displayName_);
			string text3 = (mealTypeTagItemData.iconAddress_ = iconAddress_);
			string text4 = (mealTypeTagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (mealTypeTagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (mealTypeTagItemData.htmlColor_ = htmlColor_);
			PreferredItemCategory preferredItemCategory = (mealTypeTagItemData.preferredItemCategory_ = preferredItemCategory_);
			int num2 = (mealTypeTagItemData.sortPriority_ = sortPriority_);
			UnknownFieldSet unknownFieldSet = (mealTypeTagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return mealTypeTagItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x6002394")]
		[Cpp2IlInjected.Address(RVA = "0x306E860", Offset = "0x306D260", VA = "0x18306E860", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(MealTypeTagItemData).TypeHandle)
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
										if (!flag6 && preferredItemCategory_ == (flag6 ? PreferredItemCategory.Treasure : PreferredItemCategory.None) && sortPriority_ == (flag6 ? 1 : 0))
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

		[Cpp2IlInjected.Token(Token = "0x6002395")]
		[Cpp2IlInjected.Address(RVA = "0x306E9A0", Offset = "0x306D3A0", VA = "0x18306E9A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MealTypeTagItemData other)
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
											PreferredItemCategory preferredItemCategory = other.preferredItemCategory_;
											if (preferredItemCategory_ == preferredItemCategory)
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
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002396")]
		[Cpp2IlInjected.Address(RVA = "0x306EC20", Offset = "0x306D620", VA = "0x18306EC20", Slot = "2")]
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
			if (preferredItemCategory_ != 0)
			{
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

		[Cpp2IlInjected.Token(Token = "0x6002397")]
		[Cpp2IlInjected.Address(RVA = "0x306F340", Offset = "0x306DD40", VA = "0x18306F340", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002398")]
		[Cpp2IlInjected.Address(RVA = "0x306F3A0", Offset = "0x306DDA0", VA = "0x18306F3A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00fd
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
			if (preferredItemCategory_ != 0)
			{
			}
			if (sortPriority_ != 0)
			{
				int value8 = sortPriority_;
				output.WriteInt32(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002399")]
		[Cpp2IlInjected.Address(RVA = "0x306E2F0", Offset = "0x306CCF0", VA = "0x18306E2F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0154
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
			PreferredItemCategory preferredItemCategory = preferredItemCategory_;
			if (preferredItemCategory != 0)
			{
				int num10 = CodedOutputStream.ComputeEnumSize((int)preferredItemCategory);
				num10++;
				num2 += num10;
			}
			int num11 = sortPriority_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
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

		[Cpp2IlInjected.Token(Token = "0x600239A")]
		[Cpp2IlInjected.Address(RVA = "0x306EDA0", Offset = "0x306D7A0", VA = "0x18306EDA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MealTypeTagItemData other)
		{
			//Discarded unreachable code: IL_00f6
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
				PreferredItemCategory preferredItemCategory = other.preferredItemCategory_;
				if (preferredItemCategory != 0)
				{
					preferredItemCategory_ = preferredItemCategory;
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

		[Cpp2IlInjected.Token(Token = "0x600239B")]
		[Cpp2IlInjected.Address(RVA = "0x306EEC0", Offset = "0x306D8C0", VA = "0x18306EEC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0105
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
					int num2 = default(int);
					if (num == 64)
					{
						num2 = (int)(preferredItemCategory_ = (PreferredItemCategory)input.ReadInt32());
					}
					if (num2 != 72)
					{
						goto IL_00ee;
					}
					int num3 = (sortPriority_ = input.ReadInt32());
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_00ee;
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
					goto IL_00ee;
				}
				text10 = (IconAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text10 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text12 = (Name = input.ReadString());
			}
			goto IL_00ee;
			IL_00ee:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600239C")]
		[Cpp2IlInjected.Address(RVA = "0x306EAA0", Offset = "0x306D4A0", VA = "0x18306EAA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600239D")]
		[Cpp2IlInjected.Address(RVA = "0x306F050", Offset = "0x306DA50", VA = "0x18306F050", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0021, IL_0029, IL_0031, IL_0037, IL_003d, IL_0043, IL_0049, IL_004f, IL_0055, IL_005b
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600239E")]
		[Cpp2IlInjected.Address(RVA = "0x306E560", Offset = "0x306CF60", VA = "0x18306E560", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023A0")]
		[Cpp2IlInjected.Address(RVA = "0x306E6B0", Offset = "0x306D0B0", VA = "0x18306E6B0", Slot = "22")]
		IItemData IItemData.Clone()
		{
			MealTypeTagItemData mealTypeTagItemData = new MealTypeTagItemData();
			mealTypeTagItemData.name_ = "";
			mealTypeTagItemData.displayName_ = "";
			mealTypeTagItemData.iconAddress_ = "";
			mealTypeTagItemData.prefabAddress_ = "";
			mealTypeTagItemData.alternativeIconAddress_ = "";
			mealTypeTagItemData.htmlColor_ = "";
			int num = (mealTypeTagItemData.iD_ = iD_);
			string text = (mealTypeTagItemData.name_ = name_);
			string text2 = (mealTypeTagItemData.displayName_ = displayName_);
			string text3 = (mealTypeTagItemData.iconAddress_ = iconAddress_);
			string text4 = (mealTypeTagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (mealTypeTagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (mealTypeTagItemData.htmlColor_ = htmlColor_);
			PreferredItemCategory preferredItemCategory = (mealTypeTagItemData.preferredItemCategory_ = preferredItemCategory_);
			int num2 = (mealTypeTagItemData.sortPriority_ = sortPriority_);
			UnknownFieldSet unknownFieldSet = (mealTypeTagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023A1")]
		[Cpp2IlInjected.Address(RVA = "0x306F5A0", Offset = "0x306DFA0", VA = "0x18306F5A0")]
		static MealTypeTagItemData()
		{
			Func<MealTypeTagItemData> func = default(Func<MealTypeTagItemData>);
			_parser = (MessageParser<MealTypeTagItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
