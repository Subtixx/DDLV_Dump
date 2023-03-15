using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000374")]
	public sealed class CurrencyItemData : IMessage<CurrencyItemData>, IMessage, IEquatable<CurrencyItemData>, IDeepCloneable<CurrencyItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasCurrencyGlotIDs, IGenericBuyable, IIsOnlineOnly, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001177")]
		private static readonly MessageParser<CurrencyItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001178")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001179")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400117A")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x400117B")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400117C")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400117D")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400117E")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x400117F")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001180")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001181")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001182")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001183")]
		public const int DefaultCurrencyItemIDFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001184")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x4001185")]
		public const int IsOnlineOnlyFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001186")]
		private bool isOnlineOnly_;

		[Cpp2IlInjected.Token(Token = "0x4001187")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001188")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4001189")]
		public const int CurrencyGlotIDFieldNumber = 1000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400118A")]
		private uint currencyGlotID_;

		[Cpp2IlInjected.Token(Token = "0x170009D7")]
		[DebuggerNonUserCode]
		public static MessageParser<CurrencyItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002810")]
			[Cpp2IlInjected.Address(RVA = "0x2D450D0", Offset = "0x2D43AD0", VA = "0x182D450D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002811")]
			[Cpp2IlInjected.Address(RVA = "0x2D45000", Offset = "0x2D43A00", VA = "0x182D45000")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002812")]
			[Cpp2IlInjected.Address(RVA = "0x2D45130", Offset = "0x2D43B30", VA = "0x182D45130", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009DA")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002816")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002817")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009DB")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002818")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002819")]
			[Cpp2IlInjected.Address(RVA = "0x2D45320", Offset = "0x2D43D20", VA = "0x182D45320")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009DC")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600281A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600281B")]
			[Cpp2IlInjected.Address(RVA = "0x2D45240", Offset = "0x2D43C40", VA = "0x182D45240")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009DD")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600281C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600281D")]
			[Cpp2IlInjected.Address(RVA = "0x2D452B0", Offset = "0x2D43CB0", VA = "0x182D452B0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009DE")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600281E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600281F")]
			[Cpp2IlInjected.Address(RVA = "0x2D45390", Offset = "0x2D43D90", VA = "0x182D45390")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009DF")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002820")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002821")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E0")]
		[DebuggerNonUserCode]
		public bool IsOnlineOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6002822")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E60", Offset = "0xAE0860", VA = "0x180AE1E60", Slot = "27")]
			get
			{
				return isOnlineOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002823")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E70", Offset = "0xAE0870", VA = "0x180AE1E70")]
			set
			{
				isOnlineOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E1")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002824")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002825")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E2")]
		[DebuggerNonUserCode]
		public uint CurrencyGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002826")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40", Slot = "23")]
			get
			{
				return currencyGlotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002827")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				currencyGlotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E3")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002833")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E4")]
		public uint CurrencyTypeGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002834")]
			[Cpp2IlInjected.Address(RVA = "0x262A8C0", Offset = "0x26292C0", VA = "0x18262A8C0", Slot = "24")]
			get
			{
				return 440881u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E5")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002835")]
			[Cpp2IlInjected.Address(RVA = "0x2D43FE0", Offset = "0x2D429E0", VA = "0x182D43FE0", Slot = "26")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002813")]
		[Cpp2IlInjected.Address(RVA = "0x2D44E40", Offset = "0x2D43840", VA = "0x182D44E40")]
		[DebuggerNonUserCode]
		public CurrencyItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002814")]
		[Cpp2IlInjected.Address(RVA = "0x2D44EC0", Offset = "0x2D438C0", VA = "0x182D44EC0")]
		[DebuggerNonUserCode]
		public CurrencyItemData(CurrencyItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			bool flag = (isOnlineOnly_ = other.isOnlineOnly_);
			uint num3 = (glotID_ = other.glotID_);
			uint num4 = (currencyGlotID_ = other.currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002815")]
		[Cpp2IlInjected.Address(RVA = "0x2D43E00", Offset = "0x2D42800", VA = "0x182D43E00", Slot = "10")]
		[DebuggerNonUserCode]
		public CurrencyItemData Clone()
		{
			//Discarded unreachable code: IL_00d3
			CurrencyItemData currencyItemData = new CurrencyItemData();
			currencyItemData.name_ = "";
			currencyItemData.displayName_ = "";
			currencyItemData.iconAddress_ = "";
			currencyItemData.prefabAddress_ = "";
			int num = (currencyItemData.iD_ = iD_);
			string text = (currencyItemData.name_ = name_);
			string text2 = (currencyItemData.displayName_ = displayName_);
			string text3 = (currencyItemData.iconAddress_ = iconAddress_);
			string text4 = (currencyItemData.prefabAddress_ = prefabAddress_);
			int num2 = (currencyItemData.defaultCurrencyItemID_ = defaultCurrencyItemID_);
			bool flag = (currencyItemData.isOnlineOnly_ = isOnlineOnly_);
			uint num3 = (currencyItemData.glotID_ = glotID_);
			uint num4 = (currencyItemData.currencyGlotID_ = currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (currencyItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return currencyItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x6002828")]
		[Cpp2IlInjected.Address(RVA = "0x2D44120", Offset = "0x2D42B20", VA = "0x182D44120", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(CurrencyItemData).TypeHandle)
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
								if (!flag4 && defaultCurrencyItemID_ == (flag4 ? 1 : 0) && isOnlineOnly_ == flag4 && glotID_ == (flag4 ? 1u : 0u) && currencyGlotID_ == (flag4 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x6002829")]
		[Cpp2IlInjected.Address(RVA = "0x2D44040", Offset = "0x2D42A40", VA = "0x182D44040", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CurrencyItemData other)
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
									int num2 = other.defaultCurrencyItemID_;
									if (defaultCurrencyItemID_ == num2)
									{
										bool flag = other.isOnlineOnly_;
										if (isOnlineOnly_ == flag)
										{
											uint num3 = other.glotID_;
											if (glotID_ == num3)
											{
												uint num4 = other.currencyGlotID_;
												if (currencyGlotID_ == num4)
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
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600282A")]
		[Cpp2IlInjected.Address(RVA = "0x2D443E0", Offset = "0x2D42DE0", VA = "0x182D443E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00ae
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

		[Cpp2IlInjected.Token(Token = "0x600282B")]
		[Cpp2IlInjected.Address(RVA = "0x2D44AE0", Offset = "0x2D434E0", VA = "0x182D44AE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600282C")]
		[Cpp2IlInjected.Address(RVA = "0x2D44B40", Offset = "0x2D43540", VA = "0x182D44B40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0105
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
			if (defaultCurrencyItemID_ != 0)
			{
				int value6 = defaultCurrencyItemID_;
				output.WriteInt32(value6);
			}
			if (isOnlineOnly_)
			{
				bool value7 = isOnlineOnly_;
				output.WriteBool(value7);
			}
			if (glotID_ != 0)
			{
				uint value8 = glotID_;
				output.WriteUInt32(value8);
			}
			if (currencyGlotID_ != 0)
			{
				uint value9 = currencyGlotID_;
				output.WriteUInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600282D")]
		[Cpp2IlInjected.Address(RVA = "0x2D43A80", Offset = "0x2D42480", VA = "0x182D43A80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_012b
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
			int num8 = defaultCurrencyItemID_;
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
			uint num12 = currencyGlotID_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeUInt32Size(num12);
				num13 += 2;
				num2 += num13;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
				num2 += num14;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600282E")]
		[Cpp2IlInjected.Address(RVA = "0x2D44550", Offset = "0x2D42F50", VA = "0x182D44550", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CurrencyItemData other)
		{
			//Discarded unreachable code: IL_00ee
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
				int num2 = other.defaultCurrencyItemID_;
				if (num2 != 0)
				{
					defaultCurrencyItemID_ = num2;
				}
				bool flag = other.isOnlineOnly_;
				if (flag)
				{
					isOnlineOnly_ = flag;
				}
				uint num3 = other.glotID_;
				if (num3 != 0)
				{
					glotID_ = num3;
				}
				uint num4 = other.currencyGlotID_;
				if (num4 != 0)
				{
					currencyGlotID_ = num4;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600282F")]
		[Cpp2IlInjected.Address(RVA = "0x2D44640", Offset = "0x2D43040", VA = "0x182D44640", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_010e
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 48)
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
						goto IL_00f7;
					}
					int num3 = (int)(currencyGlotID_ = (uint)input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 42)
				{
					text2 = (PrefabAddress = input.ReadString());
				}
				if ((long)text2 != 48)
				{
					goto IL_00f7;
				}
				int num4 = (defaultCurrencyItemID_ = input.ReadInt32());
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
					goto IL_00f7;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text6 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			if (num5 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_00f7;
			IL_00f7:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002830")]
		[Cpp2IlInjected.Address(RVA = "0x2D44240", Offset = "0x2D42C40", VA = "0x182D44240", Slot = "11")]
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
			if (fieldNumber - 1 <= 5)
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

		[Cpp2IlInjected.Token(Token = "0x6002831")]
		[Cpp2IlInjected.Address(RVA = "0x2D447C0", Offset = "0x2D431C0", VA = "0x182D447C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0033, IL_0034, IL_0035, IL_0036, IL_0037, IL_003e, IL_0044, IL_004a, IL_0050, IL_0056
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
			else if (fieldNumber - 1 <= 5)
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

		[Cpp2IlInjected.Token(Token = "0x6002832")]
		[Cpp2IlInjected.Address(RVA = "0x2D43CB0", Offset = "0x2D426B0", VA = "0x182D43CB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0039, IL_003a, IL_003b, IL_003c, IL_003d
			//IL_0016: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			//IL_0038: Expected I4, but got I8
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
			else if (fieldNumber - 1 <= 5)
			{
				iD_ = 0;
			}
			else if (fieldNumber != 100)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002836")]
		[Cpp2IlInjected.Address(RVA = "0x2D43E00", Offset = "0x2D42800", VA = "0x182D43E00", Slot = "20")]
		IItemData IItemData.Clone()
		{
			CurrencyItemData currencyItemData = new CurrencyItemData();
			currencyItemData.name_ = "";
			currencyItemData.displayName_ = "";
			currencyItemData.iconAddress_ = "";
			currencyItemData.prefabAddress_ = "";
			int num = (currencyItemData.iD_ = iD_);
			string text = (currencyItemData.name_ = name_);
			string text2 = (currencyItemData.displayName_ = displayName_);
			string text3 = (currencyItemData.iconAddress_ = iconAddress_);
			string text4 = (currencyItemData.prefabAddress_ = prefabAddress_);
			int num2 = (currencyItemData.defaultCurrencyItemID_ = defaultCurrencyItemID_);
			bool flag = (currencyItemData.isOnlineOnly_ = isOnlineOnly_);
			uint num3 = (currencyItemData.glotID_ = glotID_);
			uint num4 = (currencyItemData.currencyGlotID_ = currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (currencyItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002837")]
		[Cpp2IlInjected.Address(RVA = "0x2D43F70", Offset = "0x2D42970", VA = "0x182D43F70", Slot = "28")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001b
			if (currencyGlotID_ == 0)
			{
				context.AddInvalidMemberError("Must be properly defined", "CurrencyGlotID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002838")]
		[Cpp2IlInjected.Address(RVA = "0x2D44D30", Offset = "0x2D43730", VA = "0x182D44D30")]
		static CurrencyItemData()
		{
			Func<CurrencyItemData> func = default(Func<CurrencyItemData>);
			_parser = (MessageParser<CurrencyItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
