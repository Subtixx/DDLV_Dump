using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200030A")]
	public sealed class TagItemData : IMessage<TagItemData>, IMessage, IEquatable<TagItemData>, IDeepCloneable<TagItemData>, IMessageFieldAccessor, ITagData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4000F33")]
		private static readonly MessageParser<TagItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F34")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000F35")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F36")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000F37")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F38")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F39")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F3A")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F3B")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F3C")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F3D")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F3E")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F3F")]
		public const int AlternativeIconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F40")]
		private string alternativeIconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F41")]
		public const int HtmlColorFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F42")]
		private string htmlColor_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000882")]
		[DebuggerNonUserCode]
		public static MessageParser<TagItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60022E4")]
			[Cpp2IlInjected.Address(RVA = "0x2563E00", Offset = "0x2562800", VA = "0x182563E00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000883")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60022E5")]
			[Cpp2IlInjected.Address(RVA = "0x2563D30", Offset = "0x2562730", VA = "0x182563D30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000884")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60022E6")]
			[Cpp2IlInjected.Address(RVA = "0x2563E60", Offset = "0x2562860", VA = "0x182563E60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000885")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60022EA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022EB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000886")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60022EC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022ED")]
			[Cpp2IlInjected.Address(RVA = "0x2564130", Offset = "0x2562B30", VA = "0x182564130")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000887")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60022EE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022EF")]
			[Cpp2IlInjected.Address(RVA = "0x2563FE0", Offset = "0x25629E0", VA = "0x182563FE0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000888")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60022F0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022F1")]
			[Cpp2IlInjected.Address(RVA = "0x25640C0", Offset = "0x2562AC0", VA = "0x1825640C0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000889")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60022F2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022F3")]
			[Cpp2IlInjected.Address(RVA = "0x25641A0", Offset = "0x2562BA0", VA = "0x1825641A0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700088A")]
		[DebuggerNonUserCode]
		public string AlternativeIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60022F4")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "14")]
			get
			{
				return alternativeIconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022F5")]
			[Cpp2IlInjected.Address(RVA = "0x2563F70", Offset = "0x2562970", VA = "0x182563F70")]
			set
			{
				string text = (alternativeIconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700088B")]
		[DebuggerNonUserCode]
		public string HtmlColor
		{
			[Cpp2IlInjected.Token(Token = "0x60022F6")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return htmlColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022F7")]
			[Cpp2IlInjected.Address(RVA = "0x2564050", Offset = "0x2562A50", VA = "0x182564050")]
			set
			{
				string text = (htmlColor_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700088C")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002303")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022E7")]
		[Cpp2IlInjected.Address(RVA = "0x2563B00", Offset = "0x2562500", VA = "0x182563B00")]
		[DebuggerNonUserCode]
		public TagItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60022E8")]
		[Cpp2IlInjected.Address(RVA = "0x2563BB0", Offset = "0x25625B0", VA = "0x182563BB0")]
		[DebuggerNonUserCode]
		public TagItemData(TagItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x60022E9")]
		[Cpp2IlInjected.Address(RVA = "0x2562D00", Offset = "0x2561700", VA = "0x182562D00", Slot = "10")]
		[DebuggerNonUserCode]
		public TagItemData Clone()
		{
			//Discarded unreachable code: IL_00c9
			TagItemData tagItemData = new TagItemData();
			tagItemData.name_ = "";
			tagItemData.displayName_ = "";
			tagItemData.iconAddress_ = "";
			tagItemData.prefabAddress_ = "";
			tagItemData.alternativeIconAddress_ = "";
			tagItemData.htmlColor_ = "";
			int num = (tagItemData.iD_ = iD_);
			string text = (tagItemData.name_ = name_);
			string text2 = (tagItemData.displayName_ = displayName_);
			string text3 = (tagItemData.iconAddress_ = iconAddress_);
			string text4 = (tagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (tagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (tagItemData.htmlColor_ = htmlColor_);
			UnknownFieldSet unknownFieldSet = (tagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return tagItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x60022F8")]
		[Cpp2IlInjected.Address(RVA = "0x2562F80", Offset = "0x2561980", VA = "0x182562F80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(TagItemData).TypeHandle)
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

		[Cpp2IlInjected.Token(Token = "0x60022F9")]
		[Cpp2IlInjected.Address(RVA = "0x2562EA0", Offset = "0x25618A0", VA = "0x182562EA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TagItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x60022FA")]
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

		[Cpp2IlInjected.Token(Token = "0x60022FB")]
		[Cpp2IlInjected.Address(RVA = "0x25637F0", Offset = "0x25621F0", VA = "0x1825637F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60022FC")]
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

		[Cpp2IlInjected.Token(Token = "0x60022FD")]
		[Cpp2IlInjected.Address(RVA = "0x25629D0", Offset = "0x25613D0", VA = "0x1825629D0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60022FE")]
		[Cpp2IlInjected.Address(RVA = "0x2563330", Offset = "0x2561D30", VA = "0x182563330", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TagItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x60022FF")]
		[Cpp2IlInjected.Address(RVA = "0x2563430", Offset = "0x2561E30", VA = "0x182563430", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6002300")]
		[Cpp2IlInjected.Address(RVA = "0x25630B0", Offset = "0x2561AB0", VA = "0x1825630B0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6002301")]
		[Cpp2IlInjected.Address(RVA = "0x2563590", Offset = "0x2561F90", VA = "0x182563590", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6002302")]
		[Cpp2IlInjected.Address(RVA = "0x2562BD0", Offset = "0x25615D0", VA = "0x182562BD0", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x6002304")]
		[Cpp2IlInjected.Address(RVA = "0x2562D00", Offset = "0x2561700", VA = "0x182562D00", Slot = "22")]
		IItemData IItemData.Clone()
		{
			TagItemData tagItemData = new TagItemData();
			tagItemData.name_ = "";
			tagItemData.displayName_ = "";
			tagItemData.iconAddress_ = "";
			tagItemData.prefabAddress_ = "";
			tagItemData.alternativeIconAddress_ = "";
			tagItemData.htmlColor_ = "";
			int num = (tagItemData.iD_ = iD_);
			string text = (tagItemData.name_ = name_);
			string text2 = (tagItemData.displayName_ = displayName_);
			string text3 = (tagItemData.iconAddress_ = iconAddress_);
			string text4 = (tagItemData.prefabAddress_ = prefabAddress_);
			string text5 = (tagItemData.alternativeIconAddress_ = alternativeIconAddress_);
			string text6 = (tagItemData.htmlColor_ = htmlColor_);
			UnknownFieldSet unknownFieldSet = (tagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002305")]
		[Cpp2IlInjected.Address(RVA = "0x25639F0", Offset = "0x25623F0", VA = "0x1825639F0")]
		static TagItemData()
		{
			Func<TagItemData> func = default(Func<TagItemData>);
			_parser = (MessageParser<TagItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
