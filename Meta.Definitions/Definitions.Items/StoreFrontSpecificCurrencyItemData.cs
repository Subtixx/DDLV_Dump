using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000382")]
	public sealed class StoreFrontSpecificCurrencyItemData : IMessage<StoreFrontSpecificCurrencyItemData>, IMessage, IEquatable<StoreFrontSpecificCurrencyItemData>, IDeepCloneable<StoreFrontSpecificCurrencyItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasCurrencyGlotIDs, IGenericBuyable, IIsOnlineOnly, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40011D9")]
		private static readonly MessageParser<StoreFrontSpecificCurrencyItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40011DA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40011DB")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40011DC")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40011DD")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40011DE")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011DF")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40011E0")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011E1")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40011E2")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011E3")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40011E4")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011E5")]
		public const int EmulatedCurrencyFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40011E6")]
		private int emulatedCurrency_;

		[Cpp2IlInjected.Token(Token = "0x40011E7")]
		public const int SpecificToFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40011E8")]
		private string specificTo_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011E9")]
		public const int DefaultCurrencyItemIDFieldNumber = 99;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40011EA")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x40011EB")]
		public const int IsOnlineOnlyFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40011EC")]
		private bool isOnlineOnly_;

		[Cpp2IlInjected.Token(Token = "0x40011ED")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40011EE")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x40011EF")]
		public const int CurrencyGlotIDFieldNumber = 1000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40011F0")]
		private uint currencyGlotID_;

		[Cpp2IlInjected.Token(Token = "0x17000A16")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreFrontSpecificCurrencyItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60028DE")]
			[Cpp2IlInjected.Address(RVA = "0x254FDE0", Offset = "0x254E7E0", VA = "0x18254FDE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A17")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60028DF")]
			[Cpp2IlInjected.Address(RVA = "0x254FCB0", Offset = "0x254E6B0", VA = "0x18254FCB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A18")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60028E0")]
			[Cpp2IlInjected.Address(RVA = "0x254FEA0", Offset = "0x254E8A0", VA = "0x18254FEA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A19")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60028E4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A1A")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60028E6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028E7")]
			[Cpp2IlInjected.Address(RVA = "0x2550090", Offset = "0x254EA90", VA = "0x182550090")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A1B")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60028E8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028E9")]
			[Cpp2IlInjected.Address(RVA = "0x254FFB0", Offset = "0x254E9B0", VA = "0x18254FFB0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A1C")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60028EA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028EB")]
			[Cpp2IlInjected.Address(RVA = "0x2550020", Offset = "0x254EA20", VA = "0x182550020")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A1D")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60028EC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028ED")]
			[Cpp2IlInjected.Address(RVA = "0x2550100", Offset = "0x254EB00", VA = "0x182550100")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A1E")]
		[DebuggerNonUserCode]
		public int EmulatedCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x60028EE")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return emulatedCurrency_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028EF")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				emulatedCurrency_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A1F")]
		[DebuggerNonUserCode]
		public string SpecificTo
		{
			[Cpp2IlInjected.Token(Token = "0x60028F0")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return specificTo_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028F1")]
			[Cpp2IlInjected.Address(RVA = "0x2550170", Offset = "0x254EB70", VA = "0x182550170")]
			set
			{
				string text = (specificTo_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A20")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60028F2")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028F3")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A21")]
		[DebuggerNonUserCode]
		public bool IsOnlineOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60028F4")]
			[Cpp2IlInjected.Address(RVA = "0x1781430", Offset = "0x177FE30", VA = "0x181781430", Slot = "27")]
			get
			{
				return isOnlineOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028F5")]
			[Cpp2IlInjected.Address(RVA = "0x1781A50", Offset = "0x1780450", VA = "0x181781A50")]
			set
			{
				isOnlineOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A22")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60028F6")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028F7")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A23")]
		[DebuggerNonUserCode]
		public uint CurrencyGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60028F8")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820", Slot = "23")]
			get
			{
				return currencyGlotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028F9")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				currencyGlotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A24")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002905")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A25")]
		public uint CurrencyTypeGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002906")]
			[Cpp2IlInjected.Address(RVA = "0x254FCA0", Offset = "0x254E6A0", VA = "0x18254FCA0", Slot = "24")]
			get
			{
				return 440880u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A26")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002907")]
			[Cpp2IlInjected.Address(RVA = "0x254E960", Offset = "0x254D360", VA = "0x18254E960", Slot = "26")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A27")]
		public Item EmulatedCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002909")]
			[Cpp2IlInjected.Address(RVA = "0x254FD80", Offset = "0x254E780", VA = "0x18254FD80")]
			get
			{
				long num = Convert.ToInt64((uint)emulatedCurrency_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A28")]
		public StoreFrontGroup SpecificToStoreFrontGroup
		{
			[Cpp2IlInjected.Token(Token = "0x600290B")]
			[Cpp2IlInjected.Address(RVA = "0x254FE40", Offset = "0x254E840", VA = "0x18254FE40")]
			get
			{
				return StoreFrontGroup.GetByUniqueName(specificTo_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028E1")]
		[Cpp2IlInjected.Address(RVA = "0x254FA90", Offset = "0x254E490", VA = "0x18254FA90")]
		[DebuggerNonUserCode]
		public StoreFrontSpecificCurrencyItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60028E2")]
		[Cpp2IlInjected.Address(RVA = "0x254FB30", Offset = "0x254E530", VA = "0x18254FB30")]
		[DebuggerNonUserCode]
		public StoreFrontSpecificCurrencyItemData(StoreFrontSpecificCurrencyItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (emulatedCurrency_ = other.emulatedCurrency_);
			string text5 = (specificTo_ = other.specificTo_);
			int num3 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			bool flag = (isOnlineOnly_ = other.isOnlineOnly_);
			uint num4 = (glotID_ = other.glotID_);
			uint num5 = (currencyGlotID_ = other.currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E3")]
		[Cpp2IlInjected.Address(RVA = "0x254E3C0", Offset = "0x254CDC0", VA = "0x18254E3C0", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreFrontSpecificCurrencyItemData Clone()
		{
			//Discarded unreachable code: IL_00fe
			StoreFrontSpecificCurrencyItemData storeFrontSpecificCurrencyItemData = new StoreFrontSpecificCurrencyItemData();
			storeFrontSpecificCurrencyItemData.name_ = "";
			storeFrontSpecificCurrencyItemData.displayName_ = "";
			storeFrontSpecificCurrencyItemData.iconAddress_ = "";
			storeFrontSpecificCurrencyItemData.prefabAddress_ = "";
			storeFrontSpecificCurrencyItemData.specificTo_ = "";
			int num = (storeFrontSpecificCurrencyItemData.iD_ = iD_);
			string text = (storeFrontSpecificCurrencyItemData.name_ = name_);
			string text2 = (storeFrontSpecificCurrencyItemData.displayName_ = displayName_);
			string text3 = (storeFrontSpecificCurrencyItemData.iconAddress_ = iconAddress_);
			string text4 = (storeFrontSpecificCurrencyItemData.prefabAddress_ = prefabAddress_);
			int num2 = (storeFrontSpecificCurrencyItemData.emulatedCurrency_ = emulatedCurrency_);
			string text5 = (storeFrontSpecificCurrencyItemData.specificTo_ = specificTo_);
			int num3 = (storeFrontSpecificCurrencyItemData.defaultCurrencyItemID_ = defaultCurrencyItemID_);
			bool flag = (storeFrontSpecificCurrencyItemData.isOnlineOnly_ = isOnlineOnly_);
			uint num4 = (storeFrontSpecificCurrencyItemData.glotID_ = glotID_);
			uint num5 = (storeFrontSpecificCurrencyItemData.currencyGlotID_ = currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (storeFrontSpecificCurrencyItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeFrontSpecificCurrencyItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x60028FA")]
		[Cpp2IlInjected.Address(RVA = "0x254E9C0", Offset = "0x254D3C0", VA = "0x18254E9C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(StoreFrontSpecificCurrencyItemData).TypeHandle)
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
								if (!flag4 && emulatedCurrency_ == (flag4 ? 1 : 0))
								{
									string text5 = specificTo_;
									bool flag5 = default(bool);
									if (!flag5 && defaultCurrencyItemID_ == (flag5 ? 1 : 0) && isOnlineOnly_ == flag5 && glotID_ == (flag5 ? 1u : 0u) && currencyGlotID_ == (flag5 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x60028FB")]
		[Cpp2IlInjected.Address(RVA = "0x254EB10", Offset = "0x254D510", VA = "0x18254EB10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreFrontSpecificCurrencyItemData other)
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
									int num2 = other.emulatedCurrency_;
									if (emulatedCurrency_ == num2)
									{
										string text5 = other.specificTo_;
										if (!(specificTo_ != text5))
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
			}
			int num6 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028FC")]
		[Cpp2IlInjected.Address(RVA = "0x254EE90", Offset = "0x254D890", VA = "0x18254EE90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00d2
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
			if (emulatedCurrency_ != 0)
			{
			}
			string text5 = specificTo_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
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
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60028FD")]
		[Cpp2IlInjected.Address(RVA = "0x254F6C0", Offset = "0x254E0C0", VA = "0x18254F6C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60028FE")]
		[Cpp2IlInjected.Address(RVA = "0x254F720", Offset = "0x254E120", VA = "0x18254F720", Slot = "6")]
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
			if (emulatedCurrency_ != 0)
			{
				int value6 = emulatedCurrency_;
				output.WriteInt32(value6);
			}
			if (specificTo_.m_stringLength != 0)
			{
				string value7 = specificTo_;
				output.WriteString(value7);
			}
			if (defaultCurrencyItemID_ != 0)
			{
				int value8 = defaultCurrencyItemID_;
				output.WriteInt32(value8);
			}
			if (isOnlineOnly_)
			{
				bool value9 = isOnlineOnly_;
				output.WriteBool(value9);
			}
			if (glotID_ != 0)
			{
				uint value10 = glotID_;
				output.WriteUInt32(value10);
			}
			if (currencyGlotID_ != 0)
			{
				uint value11 = currencyGlotID_;
				output.WriteUInt32(value11);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60028FF")]
		[Cpp2IlInjected.Address(RVA = "0x254DFA0", Offset = "0x254C9A0", VA = "0x18254DFA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0172
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
			int num8 = emulatedCurrency_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9 += 2;
				num2 += num9;
			}
			string text5 = specificTo_;
			if (text5.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text5);
				num10 += 2;
				num2 += num10;
			}
			int num11 = defaultCurrencyItemID_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12 += 2;
				num2 += num12;
			}
			uint num13 = glotID_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeUInt32Size(num13);
				num14 += 2;
				num2 += num14;
			}
			uint num15 = currencyGlotID_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeUInt32Size(num15);
				num16 += 2;
				num2 += num16;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num17 = unknownFields.CalculateSize();
				num2 += num17;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002900")]
		[Cpp2IlInjected.Address(RVA = "0x254F1F0", Offset = "0x254DBF0", VA = "0x18254F1F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreFrontSpecificCurrencyItemData other)
		{
			//Discarded unreachable code: IL_011d
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
				int num2 = other.emulatedCurrency_;
				if (num2 != 0)
				{
					emulatedCurrency_ = num2;
				}
				string text5 = other.specificTo_;
				if (text5.m_stringLength != 0)
				{
					SpecificTo = text5;
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

		[Cpp2IlInjected.Token(Token = "0x6002901")]
		[Cpp2IlInjected.Address(RVA = "0x254F030", Offset = "0x254DA30", VA = "0x18254F030", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0148
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 792)
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
						goto IL_0131;
					}
					int num3 = (int)(currencyGlotID_ = (uint)input.ReadInt32());
				}
				int num4 = default(int);
				if (num == 168)
				{
					num4 = (emulatedCurrency_ = input.ReadInt32());
				}
				string text2 = default(string);
				if (num4 == 250)
				{
					text2 = (SpecificTo = input.ReadString());
				}
				if ((long)text2 != 792)
				{
					goto IL_0131;
				}
				int num5 = (defaultCurrencyItemID_ = input.ReadInt32());
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
					goto IL_0131;
				}
				text8 = (PrefabAddress = input.ReadString());
			}
			int num6 = default(int);
			if ((long)text8 == 8)
			{
				num6 = (iD_ = input.ReadInt32());
			}
			if (num6 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_0131;
			IL_0131:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002902")]
		[Cpp2IlInjected.Address(RVA = "0x254ECE0", Offset = "0x254D6E0", VA = "0x18254ECE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 31)
			{
				if (fieldNumber > 100)
				{
					if (fieldNumber == 999)
					{
					}
					if (fieldNumber != 1000)
					{
						goto IL_007b;
					}
				}
				if (fieldNumber == 99)
				{
				}
				if (fieldNumber != 100)
				{
					goto IL_007b;
				}
				bool flag = isOnlineOnly_;
			}
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 1)
							{
								if (fieldNumber == 21)
								{
								}
								if (fieldNumber != 31)
								{
									goto IL_007b;
								}
								string text = specificTo_;
							}
							string text2 = prefabAddress_;
						}
						string text3 = iconAddress_;
					}
					string text4 = displayName_;
				}
				string text5 = name_;
			}
			int num2 = iD_;
			goto IL_007b;
			IL_007b:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002903")]
		[Cpp2IlInjected.Address(RVA = "0x254F310", Offset = "0x254DD10", VA = "0x18254F310", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_006e, IL_0074, IL_007a, IL_0080, IL_0086, IL_008c, IL_0092
			//IL_0019: Expected I4, but got O
			//IL_0029: Expected I4, but got O
			//IL_0036: Expected I4, but got O
			//IL_0062: Expected I4, but got O
			if (fieldNumber > 31)
			{
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
				else if (fieldNumber == 99)
				{
					object obj3 = default(object);
					defaultCurrencyItemID_ = (int)obj3;
				}
				else
				{
					while (fieldNumber != 100)
					{
					}
				}
				return;
			}
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 0 || num == 0 || num == 1)
			{
				return;
			}
			if (fieldNumber == 21)
			{
				object obj4 = default(object);
				emulatedCurrency_ = (int)obj4;
			}
			else
			{
				while (fieldNumber != 31)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002904")]
		[Cpp2IlInjected.Address(RVA = "0x254E240", Offset = "0x254CC40", VA = "0x18254E240", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_001b: Expected I4, but got I8
			//IL_002d: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			//IL_0069: Expected I4, but got I8
			if (fieldNumber > 31)
			{
				switch (fieldNumber)
				{
				case 999:
					glotID_ = 0u;
					break;
				case 1000:
					currencyGlotID_ = 0u;
					break;
				case 99:
					defaultCurrencyItemID_ = 0;
					break;
				}
				return;
			}
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 0 && num != 1)
			{
				switch (fieldNumber)
				{
				case 21:
					emulatedCurrency_ = 0;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002908")]
		[Cpp2IlInjected.Address(RVA = "0x254E3C0", Offset = "0x254CDC0", VA = "0x18254E3C0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			StoreFrontSpecificCurrencyItemData storeFrontSpecificCurrencyItemData = new StoreFrontSpecificCurrencyItemData();
			storeFrontSpecificCurrencyItemData.name_ = "";
			storeFrontSpecificCurrencyItemData.displayName_ = "";
			storeFrontSpecificCurrencyItemData.iconAddress_ = "";
			storeFrontSpecificCurrencyItemData.prefabAddress_ = "";
			storeFrontSpecificCurrencyItemData.specificTo_ = "";
			int num = (storeFrontSpecificCurrencyItemData.iD_ = iD_);
			string text = (storeFrontSpecificCurrencyItemData.name_ = name_);
			string text2 = (storeFrontSpecificCurrencyItemData.displayName_ = displayName_);
			string text3 = (storeFrontSpecificCurrencyItemData.iconAddress_ = iconAddress_);
			string text4 = (storeFrontSpecificCurrencyItemData.prefabAddress_ = prefabAddress_);
			int num2 = (storeFrontSpecificCurrencyItemData.emulatedCurrency_ = emulatedCurrency_);
			string text5 = (storeFrontSpecificCurrencyItemData.specificTo_ = specificTo_);
			int num3 = (storeFrontSpecificCurrencyItemData.defaultCurrencyItemID_ = defaultCurrencyItemID_);
			bool flag = (storeFrontSpecificCurrencyItemData.isOnlineOnly_ = isOnlineOnly_);
			uint num4 = (storeFrontSpecificCurrencyItemData.glotID_ = glotID_);
			uint num5 = (storeFrontSpecificCurrencyItemData.currencyGlotID_ = currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (storeFrontSpecificCurrencyItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600290A")]
		[Cpp2IlInjected.Address(RVA = "0x254EC10", Offset = "0x254D610", VA = "0x18254EC10")]
		public static IEnumerable<StoreFrontSpecificCurrencyItemData> GetAll()
		{
			//Discarded unreachable code: IL_000d
			return (IEnumerable<StoreFrontSpecificCurrencyItemData>)ItemDatabase.Instance.GetAllByType<StoreFrontSpecificCurrencyItemData>(ItemType.Currency);
		}

		[Cpp2IlInjected.Token(Token = "0x600290C")]
		[Cpp2IlInjected.Address(RVA = "0x254E560", Offset = "0x254CF60", VA = "0x18254E560", Slot = "28")]
		public void DataValidation(DataValidation.Context context)
		{
			if (currencyGlotID_ == 0)
			{
				context.AddInvalidMemberError("Must be properly defined", "CurrencyGlotID");
			}
			int num = emulatedCurrency_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				context.AddInvalidMemberError("EmulatedCurrency was not resolved to a valid Item", "EmulatedCurrency");
			}
			int num2 = emulatedCurrency_;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				CurrencyItemData currencyItemData = default(CurrencyItemData);
				if (currencyItemData != null)
				{
					string text = currencyItemData.displayName_;
					if (displayName_ != text)
					{
						context.AddInvalidMemberError("EmulatedCurrency DisplayName doesnt match", "DisplayName");
					}
					string text2 = currencyItemData.iconAddress_;
					flag2 = iconAddress_ != text2;
					if (flag2)
					{
						context.AddInvalidMemberError("EmulatedCurrency IconAddress doesnt match", "IconAddress");
					}
				}
			}
			string text3 = specificTo_;
			if (!flag2)
			{
				if (StoreFrontGroup.GetByUniqueName(specificTo_) == null)
				{
					string text4 = specificTo_;
					string message = "SpecificTo StoreFrontGroup with GUID=" + text4 + " not found";
					context.AddInvalidMemberError(message, "SpecificTo");
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600290D")]
		[Cpp2IlInjected.Address(RVA = "0x254F980", Offset = "0x254E380", VA = "0x18254F980")]
		static StoreFrontSpecificCurrencyItemData()
		{
			Func<StoreFrontSpecificCurrencyItemData> func = default(Func<StoreFrontSpecificCurrencyItemData>);
			_parser = (MessageParser<StoreFrontSpecificCurrencyItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
