using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200030C")]
	public sealed class UniverseTagItemData : IMessage<UniverseTagItemData>, IMessage, IEquatable<UniverseTagItemData>, IDeepCloneable<UniverseTagItemData>, IMessageFieldAccessor, ITagData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4000F44")]
		private static readonly MessageParser<UniverseTagItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F45")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000F46")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F47")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000F48")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F49")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F4A")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F4B")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F4C")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F4D")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F4E")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F4F")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F50")]
		public const int AlternativeIconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F51")]
		private string alternativeIconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F52")]
		public const int HtmlColorFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F53")]
		private string htmlColor_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700088D")]
		[DebuggerNonUserCode]
		public static MessageParser<UniverseTagItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002309")]
			[Cpp2IlInjected.Address(RVA = "0x35564F0", Offset = "0x3554EF0", VA = "0x1835564F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700088E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600230A")]
			[Cpp2IlInjected.Address(RVA = "0x3556420", Offset = "0x3554E20", VA = "0x183556420")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700088F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600230B")]
			[Cpp2IlInjected.Address(RVA = "0x3556550", Offset = "0x3554F50", VA = "0x183556550", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000890")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x600230F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002310")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000891")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002311")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002312")]
			[Cpp2IlInjected.Address(RVA = "0x3556820", Offset = "0x3555220", VA = "0x183556820")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000892")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002313")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002314")]
			[Cpp2IlInjected.Address(RVA = "0x35566D0", Offset = "0x35550D0", VA = "0x1835566D0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000893")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002315")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002316")]
			[Cpp2IlInjected.Address(RVA = "0x35567B0", Offset = "0x35551B0", VA = "0x1835567B0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000894")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002317")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002318")]
			[Cpp2IlInjected.Address(RVA = "0x3556890", Offset = "0x3555290", VA = "0x183556890")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000895")]
		[DebuggerNonUserCode]
		public string AlternativeIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002319")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "14")]
			get
			{
				return alternativeIconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600231A")]
			[Cpp2IlInjected.Address(RVA = "0x3556660", Offset = "0x3555060", VA = "0x183556660")]
			set
			{
				string text = (alternativeIconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000896")]
		[DebuggerNonUserCode]
		public string HtmlColor
		{
			[Cpp2IlInjected.Token(Token = "0x600231B")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return htmlColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x600231C")]
			[Cpp2IlInjected.Address(RVA = "0x3556740", Offset = "0x3555140", VA = "0x183556740")]
			set
			{
				string text = (htmlColor_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000897")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002328")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600230C")]
		[Cpp2IlInjected.Address(RVA = "0x35561F0", Offset = "0x3554BF0", VA = "0x1835561F0")]
		[DebuggerNonUserCode]
		public UniverseTagItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600230D")]
		[Cpp2IlInjected.Address(RVA = "0x35562A0", Offset = "0x3554CA0", VA = "0x1835562A0")]
		[DebuggerNonUserCode]
		public UniverseTagItemData(UniverseTagItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (alternativeIconAddress_ = other.alternativeIconAddress_);
			string text6 = (htmlColor_ = other.htmlColor_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600230E")]
		[Cpp2IlInjected.Address(RVA = "0x35557B0", Offset = "0x35541B0", VA = "0x1835557B0", Slot = "10")]
		[DebuggerNonUserCode]
		public UniverseTagItemData Clone()
		{
			//Discarded unreachable code: IL_00c9
			UniverseTagItemData universeTagItemData = new UniverseTagItemData();
			universeTagItemData.name_ = "";
			universeTagItemData.displayName_ = "";
			universeTagItemData.iconAddress_ = "";
			universeTagItemData.prefabAddress_ = "";
			universeTagItemData.alternativeIconAddress_ = "";
			universeTagItemData.htmlColor_ = "";
			int num = (universeTagItemData.iD_ = iD_);
			string text = (universeTagItemData.name_ = name_);
			string text2 = (universeTagItemData.displayName_ = displayName_);
			string text3 = (universeTagItemData.iconAddress_ = iconAddress_);
			string text4 = (universeTagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (universeTagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (universeTagItemData.htmlColor_ = htmlColor_);
			UnknownFieldSet unknownFieldSet = (universeTagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return universeTagItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600231D")]
		[Cpp2IlInjected.Address(RVA = "0x3555950", Offset = "0x3554350", VA = "0x183555950", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(UniverseTagItemData).TypeHandle)
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
										if (!flag6)
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

		[Cpp2IlInjected.Token(Token = "0x600231E")]
		[Cpp2IlInjected.Address(RVA = "0x2562EA0", Offset = "0x25618A0", VA = "0x182562EA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UniverseTagItemData other)
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
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600231F")]
		[Cpp2IlInjected.Address(RVA = "0x25631F0", Offset = "0x2561BF0", VA = "0x1825631F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00bc
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
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002320")]
		[Cpp2IlInjected.Address(RVA = "0x3556080", Offset = "0x3554A80", VA = "0x183556080", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002321")]
		[Cpp2IlInjected.Address(RVA = "0x2563850", Offset = "0x2562250", VA = "0x182563850", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00db
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
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002322")]
		[Cpp2IlInjected.Address(RVA = "0x3555480", Offset = "0x3553E80", VA = "0x183555480", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0112
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
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num2 += num10;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002323")]
		[Cpp2IlInjected.Address(RVA = "0x3555D20", Offset = "0x3554720", VA = "0x183555D20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UniverseTagItemData other)
		{
			//Discarded unreachable code: IL_00cc
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
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002324")]
		[Cpp2IlInjected.Address(RVA = "0x3555BC0", Offset = "0x35545C0", VA = "0x183555BC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00cb
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					if (num == 50)
					{
						string text2 = (AlternativeIconAddress = input.ReadString());
					}
					if (num != 58)
					{
						goto IL_00b4;
					}
					string text4 = (HtmlColor = input.ReadString());
				}
				string text6 = default(string);
				if (num == 34)
				{
					text6 = (IconAddress = input.ReadString());
				}
				if ((long)text6 != 42)
				{
					goto IL_00b4;
				}
				string text8 = (PrefabAddress = input.ReadString());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			string text10 = default(string);
			if (num2 == 18)
			{
				text10 = (Name = input.ReadString());
			}
			if ((long)text10 == 26)
			{
				string text12 = (DisplayName = input.ReadString());
			}
			goto IL_00b4;
			IL_00b4:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002325")]
		[Cpp2IlInjected.Address(RVA = "0x3555A80", Offset = "0x3554480", VA = "0x183555A80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002326")]
		[Cpp2IlInjected.Address(RVA = "0x3555E20", Offset = "0x3554820", VA = "0x183555E20", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_001a, IL_0020, IL_0026, IL_002c, IL_0032
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 6)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002327")]
		[Cpp2IlInjected.Address(RVA = "0x3555680", Offset = "0x3554080", VA = "0x183555680", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 6)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002329")]
		[Cpp2IlInjected.Address(RVA = "0x35557B0", Offset = "0x35541B0", VA = "0x1835557B0", Slot = "22")]
		IItemData IItemData.Clone()
		{
			UniverseTagItemData universeTagItemData = new UniverseTagItemData();
			universeTagItemData.name_ = "";
			universeTagItemData.displayName_ = "";
			universeTagItemData.iconAddress_ = "";
			universeTagItemData.prefabAddress_ = "";
			universeTagItemData.alternativeIconAddress_ = "";
			universeTagItemData.htmlColor_ = "";
			int num = (universeTagItemData.iD_ = iD_);
			string text = (universeTagItemData.name_ = name_);
			string text2 = (universeTagItemData.displayName_ = displayName_);
			string text3 = (universeTagItemData.iconAddress_ = iconAddress_);
			string text4 = (universeTagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (universeTagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (universeTagItemData.htmlColor_ = htmlColor_);
			UnknownFieldSet unknownFieldSet = (universeTagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600232A")]
		[Cpp2IlInjected.Address(RVA = "0x35560E0", Offset = "0x3554AE0", VA = "0x1835560E0")]
		static UniverseTagItemData()
		{
			Func<UniverseTagItemData> func = default(Func<UniverseTagItemData>);
			_parser = (MessageParser<UniverseTagItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
