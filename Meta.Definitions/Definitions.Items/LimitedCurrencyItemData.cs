using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000384")]
	public sealed class LimitedCurrencyItemData : IMessage<LimitedCurrencyItemData>, IMessage, IEquatable<LimitedCurrencyItemData>, IDeepCloneable<LimitedCurrencyItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasCurrencyGlotIDs, IGenericBuyable, IIsOnlineOnly, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40011F2")]
		private static readonly MessageParser<LimitedCurrencyItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40011F3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40011F4")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40011F5")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40011F6")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40011F7")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011F8")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40011F9")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011FA")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40011FB")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011FC")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40011FD")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011FE")]
		public const int MaximumAmountFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40011FF")]
		private int maximumAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001200")]
		public const int DefaultCurrencyItemIDFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001201")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x4001202")]
		public const int IsOnlineOnlyFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001203")]
		private bool isOnlineOnly_;

		[Cpp2IlInjected.Token(Token = "0x4001204")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001205")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4001206")]
		public const int CurrencyGlotIDFieldNumber = 1000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001207")]
		private uint currencyGlotID_;

		[Cpp2IlInjected.Token(Token = "0x17000A29")]
		[DebuggerNonUserCode]
		public static MessageParser<LimitedCurrencyItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002911")]
			[Cpp2IlInjected.Address(RVA = "0x2746F40", Offset = "0x2745940", VA = "0x182746F40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A2A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002912")]
			[Cpp2IlInjected.Address(RVA = "0x2746E70", Offset = "0x2745870", VA = "0x182746E70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A2B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002913")]
			[Cpp2IlInjected.Address(RVA = "0x2746FA0", Offset = "0x27459A0", VA = "0x182746FA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A2C")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002917")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002918")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A2D")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002919")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600291A")]
			[Cpp2IlInjected.Address(RVA = "0x2747190", Offset = "0x2745B90", VA = "0x182747190")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A2E")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600291B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600291C")]
			[Cpp2IlInjected.Address(RVA = "0x27470B0", Offset = "0x2745AB0", VA = "0x1827470B0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A2F")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600291D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600291E")]
			[Cpp2IlInjected.Address(RVA = "0x2747120", Offset = "0x2745B20", VA = "0x182747120")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A30")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600291F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002920")]
			[Cpp2IlInjected.Address(RVA = "0x2747200", Offset = "0x2745C00", VA = "0x182747200")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A31")]
		[DebuggerNonUserCode]
		public int MaximumAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6002921")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return maximumAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002922")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				maximumAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A32")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002923")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002924")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A33")]
		[DebuggerNonUserCode]
		public bool IsOnlineOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6002925")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70", Slot = "27")]
			get
			{
				return isOnlineOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002926")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90")]
			set
			{
				isOnlineOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A34")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002927")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002928")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A35")]
		[DebuggerNonUserCode]
		public uint CurrencyGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002929")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "23")]
			get
			{
				return currencyGlotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600292A")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				currencyGlotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A36")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002936")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A37")]
		public uint CurrencyTypeGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002937")]
			[Cpp2IlInjected.Address(RVA = "0x262A8C0", Offset = "0x26292C0", VA = "0x18262A8C0", Slot = "24")]
			get
			{
				return 440881u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A38")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002938")]
			[Cpp2IlInjected.Address(RVA = "0x2745DA0", Offset = "0x27447A0", VA = "0x182745DA0", Slot = "26")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002914")]
		[Cpp2IlInjected.Address(RVA = "0x2746CB0", Offset = "0x27456B0", VA = "0x182746CB0")]
		[DebuggerNonUserCode]
		public LimitedCurrencyItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002915")]
		[Cpp2IlInjected.Address(RVA = "0x2746D30", Offset = "0x2745730", VA = "0x182746D30")]
		[DebuggerNonUserCode]
		public LimitedCurrencyItemData(LimitedCurrencyItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (maximumAmount_ = other.maximumAmount_);
			int num3 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			bool flag = (isOnlineOnly_ = other.isOnlineOnly_);
			uint num4 = (glotID_ = other.glotID_);
			uint num5 = (currencyGlotID_ = other.currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002916")]
		[Cpp2IlInjected.Address(RVA = "0x2745BC0", Offset = "0x27445C0", VA = "0x182745BC0", Slot = "10")]
		[DebuggerNonUserCode]
		public LimitedCurrencyItemData Clone()
		{
			//Discarded unreachable code: IL_00e3
			LimitedCurrencyItemData limitedCurrencyItemData = new LimitedCurrencyItemData();
			limitedCurrencyItemData.name_ = "";
			limitedCurrencyItemData.displayName_ = "";
			limitedCurrencyItemData.iconAddress_ = "";
			limitedCurrencyItemData.prefabAddress_ = "";
			int num = (limitedCurrencyItemData.iD_ = iD_);
			string text = (limitedCurrencyItemData.name_ = name_);
			string text2 = (limitedCurrencyItemData.displayName_ = displayName_);
			string text3 = (limitedCurrencyItemData.iconAddress_ = iconAddress_);
			string text4 = (limitedCurrencyItemData.prefabAddress_ = prefabAddress_);
			int num2 = (limitedCurrencyItemData.maximumAmount_ = maximumAmount_);
			int num3 = (limitedCurrencyItemData.defaultCurrencyItemID_ = defaultCurrencyItemID_);
			bool flag = (limitedCurrencyItemData.isOnlineOnly_ = isOnlineOnly_);
			uint num4 = (limitedCurrencyItemData.glotID_ = glotID_);
			uint num5 = (limitedCurrencyItemData.currencyGlotID_ = currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (limitedCurrencyItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return limitedCurrencyItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600292B")]
		[Cpp2IlInjected.Address(RVA = "0x2745EE0", Offset = "0x27448E0", VA = "0x182745EE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(LimitedCurrencyItemData).TypeHandle)
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
								if (!flag4 && maximumAmount_ == (flag4 ? 1 : 0) && defaultCurrencyItemID_ == (flag4 ? 1 : 0) && isOnlineOnly_ == flag4 && glotID_ == (flag4 ? 1u : 0u) && currencyGlotID_ == (flag4 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x600292C")]
		[Cpp2IlInjected.Address(RVA = "0x2745E00", Offset = "0x2744800", VA = "0x182745E00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LimitedCurrencyItemData other)
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
									int num2 = other.maximumAmount_;
									if (maximumAmount_ == num2)
									{
										int num3 = other.defaultCurrencyItemID_;
										if (defaultCurrencyItemID_ == num3)
										{
											bool flag = other.isOnlineOnly_;
											if (isOnlineOnly_ == flag)
											{
												uint num4 = other.glotID_;
												if (glotID_ == num4)
												{
													uint num5 = other.currencyGlotID_;
													if (currencyGlotID_ == num5)
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
			int num6 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600292D")]
		[Cpp2IlInjected.Address(RVA = "0x27461B0", Offset = "0x2744BB0", VA = "0x1827461B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b7
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
			if (maximumAmount_ != 0)
			{
			}
			if (defaultCurrencyItemID_ != 0)
			{
			}
			if (isOnlineOnly_)
			{
			}
			if (glotID_ != 0)
			{
			}
			if (currencyGlotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600292E")]
		[Cpp2IlInjected.Address(RVA = "0x2746920", Offset = "0x2745320", VA = "0x182746920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600292F")]
		[Cpp2IlInjected.Address(RVA = "0x2746980", Offset = "0x2745380", VA = "0x182746980", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_011e
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
			if (maximumAmount_ != 0)
			{
				int value6 = maximumAmount_;
				output.WriteInt32(value6);
			}
			if (defaultCurrencyItemID_ != 0)
			{
				int value7 = defaultCurrencyItemID_;
				output.WriteInt32(value7);
			}
			if (isOnlineOnly_)
			{
				bool value8 = isOnlineOnly_;
				output.WriteBool(value8);
			}
			if (glotID_ != 0)
			{
				uint value9 = glotID_;
				output.WriteUInt32(value9);
			}
			if (currencyGlotID_ != 0)
			{
				uint value10 = currencyGlotID_;
				output.WriteUInt32(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002930")]
		[Cpp2IlInjected.Address(RVA = "0x2745800", Offset = "0x2744200", VA = "0x182745800", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_014c
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
			int num8 = maximumAmount_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			int num10 = defaultCurrencyItemID_;
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
			uint num14 = currencyGlotID_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeUInt32Size(num14);
				num15 += 2;
				num2 += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num2 += num16;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002931")]
		[Cpp2IlInjected.Address(RVA = "0x27464C0", Offset = "0x2744EC0", VA = "0x1827464C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LimitedCurrencyItemData other)
		{
			//Discarded unreachable code: IL_0103
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
				int num2 = other.maximumAmount_;
				if (num2 != 0)
				{
					maximumAmount_ = num2;
				}
				int num3 = other.defaultCurrencyItemID_;
				if (num3 != 0)
				{
					defaultCurrencyItemID_ = num3;
				}
				bool flag = other.isOnlineOnly_;
				if (flag)
				{
					isOnlineOnly_ = flag;
				}
				uint num4 = other.glotID_;
				if (num4 != 0)
				{
					glotID_ = num4;
				}
				uint num5 = other.currencyGlotID_;
				if (num5 != 0)
				{
					currencyGlotID_ = num5;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002932")]
		[Cpp2IlInjected.Address(RVA = "0x2746330", Offset = "0x2744D30", VA = "0x182746330", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0124
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 56)
				{
					if (num == 800)
					{
						bool flag = (isOnlineOnly_ = input.ReadBool());
					}
					int num2 = default(int);
					if (num == 7992)
					{
						num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					if (num2 != 8000)
					{
						goto IL_010d;
					}
					int num3 = (int)(currencyGlotID_ = (uint)input.ReadInt32());
				}
				int num4 = default(int);
				if (num == 48)
				{
					num4 = (maximumAmount_ = input.ReadInt32());
				}
				if (num4 != 56)
				{
					goto IL_010d;
				}
				int num5 = (defaultCurrencyItemID_ = input.ReadInt32());
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
					goto IL_010d;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num6 = default(int);
			if ((long)text6 == 8)
			{
				num6 = (iD_ = input.ReadInt32());
			}
			if (num6 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_010d;
			IL_010d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002933")]
		[Cpp2IlInjected.Address(RVA = "0x2746010", Offset = "0x2744A10", VA = "0x182746010", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 100)
			{
				if (fieldNumber == 999)
				{
				}
				if (fieldNumber != 1000)
				{
					goto IL_0027;
				}
			}
			if (fieldNumber - 1 <= 6)
			{
				int num = iD_;
			}
			if (fieldNumber != 100)
			{
			}
			goto IL_0027;
			IL_0027:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002934")]
		[Cpp2IlInjected.Address(RVA = "0x27465C0", Offset = "0x2744FC0", VA = "0x1827465C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0033, IL_0034, IL_0035, IL_0036, IL_0037, IL_0038, IL_003f, IL_0045, IL_004b, IL_0051, IL_0057
			//IL_0014: Expected I4, but got O
			//IL_0024: Expected I4, but got O
			//IL_0032: Expected I4, but got O
			if (fieldNumber > 100)
			{
				if (fieldNumber == 999)
				{
					object obj = default(object);
					glotID_ = (uint)(int)obj;
					return;
				}
				while (fieldNumber != 1000)
				{
				}
				object obj2 = default(object);
				currencyGlotID_ = (uint)(int)obj2;
			}
			else if (fieldNumber - 1 <= 6)
			{
				object obj3 = default(object);
				iD_ = (int)obj3;
			}
			else
			{
				while (fieldNumber != 100)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002935")]
		[Cpp2IlInjected.Address(RVA = "0x2745A60", Offset = "0x2744460", VA = "0x182745A60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0039, IL_003a, IL_003b, IL_003c, IL_003d, IL_003e, IL_0045, IL_004a, IL_004f, IL_0054, IL_0059, IL_005e, IL_0064, IL_00f8
			//IL_0016: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			//IL_0038: Expected I4, but got I8
			//IL_009d: Expected I4, but got O
			//IL_00a4: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_00c4: Expected I4, but got O
			//IL_00cf: Expected I4, but got O
			//IL_00da: Expected I4, but got O
			//IL_00e5: Expected I4, but got O
			//IL_00f0: Expected I4, but got O
			if (fieldNumber > 100)
			{
				switch (fieldNumber)
				{
				case 999:
					glotID_ = 0u;
					break;
				case 1000:
					currencyGlotID_ = 0u;
					break;
				}
			}
			else if (fieldNumber - 1 <= 6)
			{
				iD_ = 0;
			}
			else if (fieldNumber != 100)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002939")]
		[Cpp2IlInjected.Address(RVA = "0x2745BC0", Offset = "0x27445C0", VA = "0x182745BC0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			LimitedCurrencyItemData limitedCurrencyItemData = new LimitedCurrencyItemData();
			limitedCurrencyItemData.name_ = "";
			limitedCurrencyItemData.displayName_ = "";
			limitedCurrencyItemData.iconAddress_ = "";
			limitedCurrencyItemData.prefabAddress_ = "";
			int num = (limitedCurrencyItemData.iD_ = iD_);
			string text = (limitedCurrencyItemData.name_ = name_);
			string text2 = (limitedCurrencyItemData.displayName_ = displayName_);
			string text3 = (limitedCurrencyItemData.iconAddress_ = iconAddress_);
			string text4 = (limitedCurrencyItemData.prefabAddress_ = prefabAddress_);
			int num2 = (limitedCurrencyItemData.maximumAmount_ = maximumAmount_);
			int num3 = (limitedCurrencyItemData.defaultCurrencyItemID_ = defaultCurrencyItemID_);
			bool flag = (limitedCurrencyItemData.isOnlineOnly_ = isOnlineOnly_);
			uint num4 = (limitedCurrencyItemData.glotID_ = glotID_);
			uint num5 = (limitedCurrencyItemData.currencyGlotID_ = currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (limitedCurrencyItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600293A")]
		[Cpp2IlInjected.Address(RVA = "0x2745D30", Offset = "0x2744730", VA = "0x182745D30", Slot = "28")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001b
			if (currencyGlotID_ == 0)
			{
				context.AddInvalidMemberError("Must be properly defined", "CurrencyGlotID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600293B")]
		[Cpp2IlInjected.Address(RVA = "0x2746BA0", Offset = "0x27455A0", VA = "0x182746BA0")]
		static LimitedCurrencyItemData()
		{
			Func<LimitedCurrencyItemData> func = default(Func<LimitedCurrencyItemData>);
			_parser = (MessageParser<LimitedCurrencyItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
