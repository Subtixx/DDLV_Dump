using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005D5")]
	public sealed class CustomXmlTag : IMessage<CustomXmlTag>, IMessage, IEquatable<CustomXmlTag>, IDeepCloneable<CustomXmlTag>, IMessageFieldAccessor, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001FCA")]
		private static readonly MessageParser<CustomXmlTag> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FCB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FCC")]
		public const int XmlTagFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FCD")]
		private string xmlTag_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FCE")]
		public const int EnabledFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FCF")]
		private bool enabled_;

		[Cpp2IlInjected.Token(Token = "0x4001FD0")]
		public const int HtmlColorFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001FD1")]
		private string htmlColor_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FD2")]
		public const int BoldFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001FD3")]
		private bool bold_;

		[Cpp2IlInjected.Token(Token = "0x4001FD4")]
		public const int ItalicFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4001FD5")]
		private bool italic_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001FD6")]
		private string PreOld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001FD7")]
		private string PreNew;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001FD8")]
		private string PostOld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001FD9")]
		private string PostNew;

		[Cpp2IlInjected.Token(Token = "0x170012B8")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomXmlTag> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60048B0")]
			[Cpp2IlInjected.Address(RVA = "0x356B360", Offset = "0x3569D60", VA = "0x18356B360")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048B1")]
			[Cpp2IlInjected.Address(RVA = "0x356B290", Offset = "0x3569C90", VA = "0x18356B290")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012BA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048B2")]
			[Cpp2IlInjected.Address(RVA = "0x356B3C0", Offset = "0x3569DC0", VA = "0x18356B3C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012BB")]
		[DebuggerNonUserCode]
		public string XmlTag
		{
			[Cpp2IlInjected.Token(Token = "0x60048B6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return xmlTag_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048B7")]
			[Cpp2IlInjected.Address(RVA = "0x356B540", Offset = "0x3569F40", VA = "0x18356B540")]
			set
			{
				string text = (xmlTag_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012BC")]
		[DebuggerNonUserCode]
		public bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x60048B8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return enabled_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048B9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				enabled_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012BD")]
		[DebuggerNonUserCode]
		public string HtmlColor
		{
			[Cpp2IlInjected.Token(Token = "0x60048BA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return htmlColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048BB")]
			[Cpp2IlInjected.Address(RVA = "0x356B4D0", Offset = "0x3569ED0", VA = "0x18356B4D0")]
			set
			{
				string text = (htmlColor_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012BE")]
		[DebuggerNonUserCode]
		public bool Bold
		{
			[Cpp2IlInjected.Token(Token = "0x60048BC")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return bold_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048BD")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				bold_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012BF")]
		[DebuggerNonUserCode]
		public bool Italic
		{
			[Cpp2IlInjected.Token(Token = "0x60048BE")]
			[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90")]
			get
			{
				return italic_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048BF")]
			[Cpp2IlInjected.Address(RVA = "0x997DC0", Offset = "0x9967C0", VA = "0x180997DC0")]
			set
			{
				italic_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048B3")]
		[Cpp2IlInjected.Address(RVA = "0x356B230", Offset = "0x3569C30", VA = "0x18356B230")]
		[DebuggerNonUserCode]
		public CustomXmlTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048B4")]
		[Cpp2IlInjected.Address(RVA = "0x356B150", Offset = "0x3569B50", VA = "0x18356B150")]
		[DebuggerNonUserCode]
		public CustomXmlTag(CustomXmlTag other)
		{
			string text = (xmlTag_ = other.xmlTag_);
			bool flag = (enabled_ = other.enabled_);
			string text2 = (htmlColor_ = other.htmlColor_);
			bool flag2 = (bold_ = other.bold_);
			bool flag3 = (italic_ = other.italic_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048B5")]
		[Cpp2IlInjected.Address(RVA = "0x356A020", Offset = "0x3568A20", VA = "0x18356A020", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomXmlTag Clone()
		{
			//Discarded unreachable code: IL_007d
			CustomXmlTag customXmlTag = new CustomXmlTag();
			customXmlTag.xmlTag_ = "";
			customXmlTag.htmlColor_ = "";
			string text = (customXmlTag.xmlTag_ = xmlTag_);
			bool flag = (customXmlTag.enabled_ = enabled_);
			string text2 = (customXmlTag.htmlColor_ = htmlColor_);
			bool flag2 = (customXmlTag.bold_ = bold_);
			bool flag3 = (customXmlTag.italic_ = italic_);
			UnknownFieldSet unknownFieldSet = (customXmlTag._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customXmlTag;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C0")]
		[Cpp2IlInjected.Address(RVA = "0x356A4E0", Offset = "0x3568EE0", VA = "0x18356A4E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = xmlTag_;
				bool flag = default(bool);
				if (!flag && enabled_ == flag)
				{
					string text2 = htmlColor_;
					bool flag2 = default(bool);
					if (!flag2 && bold_ == flag2 && italic_ == flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C1")]
		[Cpp2IlInjected.Address(RVA = "0x356A440", Offset = "0x3568E40", VA = "0x18356A440", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomXmlTag other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.xmlTag_;
				if (!(xmlTag_ != text))
				{
					bool flag = other.enabled_;
					if (enabled_ == flag)
					{
						string text2 = other.htmlColor_;
						if (!(htmlColor_ != text2))
						{
							bool flag2 = other.bold_;
							if (bold_ == flag2)
							{
								bool flag3 = other.italic_;
								if (italic_ == flag3)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C2")]
		[Cpp2IlInjected.Address(RVA = "0x356A6B0", Offset = "0x35690B0", VA = "0x18356A6B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0065
			string text = xmlTag_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (enabled_)
			{
			}
			string text2 = htmlColor_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (bold_)
			{
			}
			if (italic_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C3")]
		[Cpp2IlInjected.Address(RVA = "0x356AEC0", Offset = "0x35698C0", VA = "0x18356AEC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60048C4")]
		[Cpp2IlInjected.Address(RVA = "0x356AF20", Offset = "0x3569920", VA = "0x18356AF20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0095
			if (xmlTag_.m_stringLength != 0)
			{
				string value = xmlTag_;
				output.WriteString(value);
			}
			if (enabled_)
			{
				bool value2 = enabled_;
				output.WriteBool(value2);
			}
			if (htmlColor_.m_stringLength != 0)
			{
				string value3 = htmlColor_;
				output.WriteString(value3);
			}
			if (bold_)
			{
				bool value4 = bold_;
				output.WriteBool(value4);
			}
			if (italic_)
			{
				bool value5 = italic_;
				output.WriteBool(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60048C5")]
		[Cpp2IlInjected.Address(RVA = "0x3569E80", Offset = "0x3568880", VA = "0x183569E80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_005d
			string text = xmlTag_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
			}
			string text2 = htmlColor_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C6")]
		[Cpp2IlInjected.Address(RVA = "0x356AA70", Offset = "0x3569470", VA = "0x18356AA70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomXmlTag other)
		{
			//Discarded unreachable code: IL_008e
			if (other != null)
			{
				string text = other.xmlTag_;
				if (text.m_stringLength != 0)
				{
					XmlTag = text;
				}
				bool flag = other.enabled_;
				if (flag)
				{
					enabled_ = flag;
				}
				string text2 = other.htmlColor_;
				if (text2.m_stringLength != 0)
				{
					HtmlColor = text2;
				}
				bool flag2 = other.bold_;
				if (flag2)
				{
					bold_ = flag2;
				}
				bool flag3 = other.italic_;
				if (flag3)
				{
					italic_ = flag3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048C7")]
		[Cpp2IlInjected.Address(RVA = "0x356AB10", Offset = "0x3569510", VA = "0x18356AB10", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0094
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					string text2 = (HtmlColor = input.ReadString());
				}
				bool flag = default(bool);
				if (num == 32)
				{
					flag = (bold_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_007d;
				}
				bool flag2 = (italic_ = input.ReadBool());
			}
			string text4 = default(string);
			if (num == 10)
			{
				text4 = (XmlTag = input.ReadString());
			}
			if ((long)text4 == 16)
			{
				bool flag3 = (enabled_ = input.ReadBool());
			}
			goto IL_007d;
			IL_007d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60048C8")]
		[Cpp2IlInjected.Address(RVA = "0x356A5C0", Offset = "0x3568FC0", VA = "0x18356A5C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0 && num != 0 && num != 1)
					{
						goto IL_002d;
					}
					string text = htmlColor_;
				}
				bool flag = enabled_;
			}
			string text2 = xmlTag_;
			goto IL_002d;
			IL_002d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C9")]
		[Cpp2IlInjected.Address(RVA = "0x356AD00", Offset = "0x3569700", VA = "0x18356AD00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							object obj2 = default(object);
							italic_ = (byte)(int)obj2 != 0;
							break;
						}
						case 0:
						{
							object obj = default(object);
							bold_ = (byte)(int)obj != 0;
							break;
						}
						}
					}
					else if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					object obj3 = default(object);
					enabled_ = (byte)(int)obj3 != 0;
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048CA")]
		[Cpp2IlInjected.Address(RVA = "0x3569F70", Offset = "0x3568970", VA = "0x183569F70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
							italic_ = false;
							break;
						case 0:
							bold_ = false;
							break;
						}
					}
					else
					{
						HtmlColor = "";
					}
				}
				else
				{
					enabled_ = false;
				}
			}
			else
			{
				XmlTag = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048CB")]
		[Cpp2IlInjected.Address(RVA = "0x1457620", Offset = "0x1456020", VA = "0x181457620", Slot = "14")]
		public void SetDefaultData()
		{
			enabled_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60048CC")]
		[Cpp2IlInjected.Address(RVA = "0x356A130", Offset = "0x3568B30", VA = "0x18356A130")]
		private void CreateCache()
		{
			string text = xmlTag_;
			string text2 = (PreOld = "<" + text + ">");
			string text3 = xmlTag_;
			string text4 = (PostOld = "</" + text3 + ">");
			string preNew = default(string);
			if (enabled_)
			{
				int num = 0;
				CustomXmlSettings instance = CustomXmlSettings.Instance;
				string text5 = htmlColor_;
				string text7 = default(string);
				if (instance == null)
				{
					string text6 = htmlColor_;
					text7 = "" + "<color=" + text6 + ">";
				}
				string text8 = default(string);
				if (bold_)
				{
					string boldTag1_ = instance.boldTag1_;
					text8 = text7 + boldTag1_;
				}
				if (italic_)
				{
					string italicTag1_ = instance.italicTag1_;
					preNew = text8 + italicTag1_;
				}
			}
			PreNew = preNew;
			string postNew = default(string);
			if (enabled_)
			{
				int num2 = 0;
				CustomXmlSettings instance2 = CustomXmlSettings.Instance;
				string text9 = default(string);
				if (italic_)
				{
					string italicTag2_ = instance2.italicTag2_;
					text9 = "" + italicTag2_;
				}
				string text10 = default(string);
				if (bold_)
				{
					string boldTag2_ = instance2.boldTag2_;
					text10 = text9 + boldTag2_;
				}
				string text11 = htmlColor_;
				if (text10 == null)
				{
					postNew = text10 + "</color>";
				}
			}
			PostNew = postNew;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048CD")]
		[Cpp2IlInjected.Address(RVA = "0x356A890", Offset = "0x3569290", VA = "0x18356A890")]
		private string GetPreDst()
		{
			//Discarded unreachable code: IL_0074
			CustomXmlSettings instance;
			string text2 = default(string);
			string text3 = default(string);
			while (true)
			{
				if (enabled_)
				{
					int num = 0;
					instance = CustomXmlSettings.Instance;
					if (!string.IsNullOrEmpty(htmlColor_))
					{
						string text = htmlColor_;
						text2 = "" + "<color=" + text + ">";
					}
					if (bold_)
					{
						string boldTag1_ = instance.boldTag1_;
						text3 = text2 + boldTag1_;
					}
					if (italic_)
					{
						break;
					}
				}
			}
			string italicTag1_ = instance.italicTag1_;
			return text3 + italicTag1_;
		}

		[Cpp2IlInjected.Token(Token = "0x60048CE")]
		[Cpp2IlInjected.Address(RVA = "0x356A790", Offset = "0x3569190", VA = "0x18356A790")]
		private string GetPostDst()
		{
			//Discarded unreachable code: IL_006e
			if (enabled_)
			{
				int num = 0;
				CustomXmlSettings instance = CustomXmlSettings.Instance;
				if (italic_)
				{
					string italicTag2_ = instance.italicTag2_;
					string text = "" + italicTag2_;
				}
				string text2 = default(string);
				if (bold_)
				{
					string boldTag2_ = instance.boldTag2_;
					text2 = "" + boldTag2_;
				}
				if (!string.IsNullOrEmpty(htmlColor_))
				{
					string text3 = text2 + "</color>";
				}
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x60048CF")]
		[Cpp2IlInjected.Address(RVA = "0x356A9B0", Offset = "0x35693B0", VA = "0x18356A9B0")]
		private void GetReplaceInfo(bool useXml, out string preOld, out string preNew, out string postOld, out string postNew)
		{
			while (true)
			{
				if ((long)PreNew == 0)
				{
					CreateCache();
				}
				string preOld2 = PreOld;
				if (useXml)
				{
				}
				if (useXml)
				{
					/*Error: Could not find block for branch target IL_0020*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048D0")]
		[Cpp2IlInjected.Address(RVA = "0x356AC00", Offset = "0x3569600", VA = "0x18356AC00")]
		public string Parse(string str, bool useXml = true)
		{
			//Discarded unreachable code: IL_0037
			if ((long)PreNew == 0)
			{
				CreateCache();
			}
			string preOld = PreOld;
			string postOld = PostOld;
			if (useXml)
			{
			}
			if (useXml)
			{
			}
			string newValue = default(string);
			string newValue2 = default(string);
			return str.Replace(preOld, newValue).Replace(postOld, newValue2);
		}

		[Cpp2IlInjected.Token(Token = "0x60048D1")]
		[Cpp2IlInjected.Address(RVA = "0x356A3C0", Offset = "0x3568DC0", VA = "0x18356A3C0", Slot = "15")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0020
			string text = xmlTag_;
			if ("XmlTag" != null)
			{
				context.AddInvalidMemberError("Cannot be empty", "XmlTag");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048D2")]
		[Cpp2IlInjected.Address(RVA = "0x356B040", Offset = "0x3569A40", VA = "0x18356B040")]
		static CustomXmlTag()
		{
			Func<CustomXmlTag> func = default(Func<CustomXmlTag>);
			_parser = (MessageParser<CustomXmlTag>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
