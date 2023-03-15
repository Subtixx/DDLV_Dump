using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005D7")]
	public sealed class CustomXmlSettings : IMessage<CustomXmlSettings>, IMessage, IEquatable<CustomXmlSettings>, IDeepCloneable<CustomXmlSettings>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001FDB")]
		private static readonly MessageParser<CustomXmlSettings> _parser = (MessageParser<CustomXmlSettings>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CustomXmlSettings()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FDC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FDD")]
		public const int UseCustomTagsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FDE")]
		private bool useCustomTags_;

		[Cpp2IlInjected.Token(Token = "0x4001FDF")]
		public const int BoldTag1FieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FE0")]
		private string boldTag1_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FE1")]
		public const int BoldTag2FieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001FE2")]
		private string boldTag2_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FE3")]
		public const int ItalicTag1FieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001FE4")]
		private string italicTag1_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FE5")]
		public const int ItalicTag2FieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001FE6")]
		private string italicTag2_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FE7")]
		public const int TagsFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001FE8")]
		private static readonly FieldCodec<CustomXmlTag> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001FE9")]
		private readonly RepeatedField<CustomXmlTag> tags_ = (RepeatedField<CustomXmlTag>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170012C0")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomXmlSettings> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60048D6")]
			[Cpp2IlInjected.Address(RVA = "0x3569B50", Offset = "0x3568550", VA = "0x183569B50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048D7")]
			[Cpp2IlInjected.Address(RVA = "0x35699A0", Offset = "0x35683A0", VA = "0x1835699A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048D8")]
			[Cpp2IlInjected.Address(RVA = "0x3569BB0", Offset = "0x35685B0", VA = "0x183569BB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C3")]
		[DebuggerNonUserCode]
		public bool UseCustomTags
		{
			[Cpp2IlInjected.Token(Token = "0x60048DC")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useCustomTags_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048DD")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useCustomTags_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C4")]
		[DebuggerNonUserCode]
		public string BoldTag1
		{
			[Cpp2IlInjected.Token(Token = "0x60048DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return boldTag1_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048DF")]
			[Cpp2IlInjected.Address(RVA = "0x3569CC0", Offset = "0x35686C0", VA = "0x183569CC0")]
			set
			{
				string text = (boldTag1_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C5")]
		[DebuggerNonUserCode]
		public string BoldTag2
		{
			[Cpp2IlInjected.Token(Token = "0x60048E0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return boldTag2_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048E1")]
			[Cpp2IlInjected.Address(RVA = "0x3569D30", Offset = "0x3568730", VA = "0x183569D30")]
			set
			{
				string text = (boldTag2_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C6")]
		[DebuggerNonUserCode]
		public string ItalicTag1
		{
			[Cpp2IlInjected.Token(Token = "0x60048E2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return italicTag1_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048E3")]
			[Cpp2IlInjected.Address(RVA = "0x3569DA0", Offset = "0x35687A0", VA = "0x183569DA0")]
			set
			{
				string text = (italicTag1_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C7")]
		[DebuggerNonUserCode]
		public string ItalicTag2
		{
			[Cpp2IlInjected.Token(Token = "0x60048E4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return italicTag2_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048E5")]
			[Cpp2IlInjected.Address(RVA = "0x3569E10", Offset = "0x3568810", VA = "0x183569E10")]
			set
			{
				string text = (italicTag2_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C8")]
		[DebuggerNonUserCode]
		public RepeatedField<CustomXmlTag> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x60048E6")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C9")]
		public static CustomXmlSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60048F2")]
			[Cpp2IlInjected.Address(RVA = "0x3569A70", Offset = "0x3568470", VA = "0x183569A70")]
			get
			{
				//Discarded unreachable code: IL_0010
				return ProtoDatabase.Instance.Get<CustomXmlSettings>("CustomXmlSettings");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048D9")]
		[Cpp2IlInjected.Address(RVA = "0x35698D0", Offset = "0x35682D0", VA = "0x1835698D0")]
		[DebuggerNonUserCode]
		public CustomXmlSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048DA")]
		[Cpp2IlInjected.Address(RVA = "0x3569720", Offset = "0x3568120", VA = "0x183569720")]
		[DebuggerNonUserCode]
		public CustomXmlSettings(CustomXmlSettings other)
		{
			bool flag = (useCustomTags_ = other.useCustomTags_);
			string text = (boldTag1_ = other.boldTag1_);
			string text2 = (boldTag2_ = other.boldTag2_);
			string text3 = (italicTag1_ = other.italicTag1_);
			string text4 = (italicTag2_ = other.italicTag2_);
			RepeatedField<CustomXmlTag> repeatedField = (tags_ = (RepeatedField<CustomXmlTag>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048DB")]
		[Cpp2IlInjected.Address(RVA = "0x3568200", Offset = "0x3566C00", VA = "0x183568200", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomXmlSettings Clone()
		{
			//Discarded unreachable code: IL_00b7
			CustomXmlSettings customXmlSettings = new CustomXmlSettings();
			customXmlSettings.boldTag1_ = "";
			customXmlSettings.boldTag2_ = "";
			customXmlSettings.italicTag1_ = "";
			customXmlSettings.italicTag2_ = "";
			RepeatedField<CustomXmlTag> repeatedField = (customXmlSettings.tags_ = (RepeatedField<CustomXmlTag>)(object)new RepeatedField<T>());
			bool flag = (customXmlSettings.useCustomTags_ = useCustomTags_);
			string text = (customXmlSettings.boldTag1_ = boldTag1_);
			string text2 = (customXmlSettings.boldTag2_ = boldTag2_);
			string text3 = (customXmlSettings.italicTag1_ = italicTag1_);
			string text4 = (customXmlSettings.italicTag2_ = italicTag2_);
			RepeatedField<CustomXmlTag> repeatedField2 = (customXmlSettings.tags_ = (RepeatedField<CustomXmlTag>)(object)((RepeatedField<T>)(object)tags_).Clone());
			UnknownFieldSet unknownFieldSet = (customXmlSettings._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customXmlSettings;
		}

		[Cpp2IlInjected.Token(Token = "0x60048E7")]
		[Cpp2IlInjected.Address(RVA = "0x35686A0", Offset = "0x35670A0", VA = "0x1835686A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((IntPtr)(useCustomTags_ ? 1 : 0) == (IntPtr)typeof(CustomXmlSettings).TypeHandle)
				{
					string text = boldTag1_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = boldTag2_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = italicTag1_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = italicTag2_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									RepeatedField<CustomXmlTag> repeatedField = tags_;
									bool flag5 = default(bool);
									if (flag5)
									{
										return object.Equals(_unknownFields, other);
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048E8")]
		[Cpp2IlInjected.Address(RVA = "0x35687E0", Offset = "0x35671E0", VA = "0x1835687E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomXmlSettings other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.useCustomTags_;
				if (useCustomTags_ == flag)
				{
					string text = other.boldTag1_;
					if (!(boldTag1_ != text))
					{
						string text2 = other.boldTag2_;
						if (!(boldTag2_ != text2))
						{
							string text3 = other.italicTag1_;
							if (!(italicTag1_ != text3))
							{
								string text4 = other.italicTag2_;
								if (!(italicTag2_ != text4))
								{
									RepeatedField<CustomXmlTag> repeatedField = tags_;
									RepeatedField<CustomXmlTag> repeatedField2 = other.tags_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
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
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048E9")]
		[Cpp2IlInjected.Address(RVA = "0x3568A10", Offset = "0x3567410", VA = "0x183568A10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0096
			if (useCustomTags_)
			{
			}
			string text = boldTag1_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = boldTag2_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = italicTag1_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = italicTag2_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60048EA")]
		[Cpp2IlInjected.Address(RVA = "0x3569320", Offset = "0x3567D20", VA = "0x183569320", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60048EB")]
		[Cpp2IlInjected.Address(RVA = "0x3569380", Offset = "0x3567D80", VA = "0x183569380", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b8
			if (useCustomTags_)
			{
				bool value = useCustomTags_;
				output.WriteBool(value);
			}
			if (boldTag1_.m_stringLength != 0)
			{
				string value2 = boldTag1_;
				output.WriteString(value2);
			}
			if (boldTag2_.m_stringLength != 0)
			{
				string value3 = boldTag2_;
				output.WriteString(value3);
			}
			if (italicTag1_.m_stringLength != 0)
			{
				string value4 = italicTag1_;
				output.WriteString(value4);
			}
			if (italicTag2_.m_stringLength != 0)
			{
				string value5 = italicTag2_;
				output.WriteString(value5);
			}
			RepeatedField<CustomXmlTag> repeatedField = tags_;
			FieldCodec<CustomXmlTag> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60048EC")]
		[Cpp2IlInjected.Address(RVA = "0x3567F10", Offset = "0x3566910", VA = "0x183567F10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00aa
			UnknownFieldSet unknownFields;
			do
			{
				string text = boldTag1_;
				if (text.m_stringLength != 0)
				{
					int num = CodedOutputStream.ComputeStringSize(text);
					num++;
				}
				string text2 = boldTag2_;
				if (text2.m_stringLength != 0)
				{
					int num2 = CodedOutputStream.ComputeStringSize(text2);
					num2++;
				}
				string text3 = italicTag1_;
				if (text3.m_stringLength != 0)
				{
					int num3 = CodedOutputStream.ComputeStringSize(text3);
					num3++;
				}
				string text4 = italicTag2_;
				if (text4.m_stringLength != 0)
				{
					int num4 = CodedOutputStream.ComputeStringSize(text4);
					num4++;
				}
				RepeatedField<CustomXmlTag> repeatedField = tags_;
				FieldCodec<CustomXmlTag> repeated_tags_codec = _repeated_tags_codec;
				int num5 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x60048ED")]
		[Cpp2IlInjected.Address(RVA = "0x3568CC0", Offset = "0x35676C0", VA = "0x183568CC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomXmlSettings other)
		{
			//Discarded unreachable code: IL_00b1
			if (other != null)
			{
				bool flag = other.useCustomTags_;
				if (flag)
				{
					useCustomTags_ = flag;
				}
				string text = other.boldTag1_;
				if (text.m_stringLength != 0)
				{
					BoldTag1 = text;
				}
				string text2 = other.boldTag2_;
				if (text2.m_stringLength != 0)
				{
					BoldTag2 = text2;
				}
				string text3 = other.italicTag1_;
				if (text3.m_stringLength != 0)
				{
					ItalicTag1 = text3;
				}
				string text4 = other.italicTag2_;
				if (text4.m_stringLength != 0)
				{
					ItalicTag2 = text4;
				}
				RepeatedField<CustomXmlTag> repeatedField = tags_;
				RepeatedField<CustomXmlTag> repeatedField2 = other.tags_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048EE")]
		[Cpp2IlInjected.Address(RVA = "0x3568B20", Offset = "0x3567520", VA = "0x183568B20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b4
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (ItalicTag1 = input.ReadString());
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (ItalicTag2 = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_009d;
				}
				RepeatedField<CustomXmlTag> repeatedField = tags_;
				FieldCodec<CustomXmlTag> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			}
			bool flag = default(bool);
			if (num == 8)
			{
				flag = (useCustomTags_ = input.ReadBool());
			}
			string text6 = default(string);
			if (flag)
			{
				text6 = (BoldTag1 = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (BoldTag2 = input.ReadString());
			}
			goto IL_009d;
			IL_009d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60048EF")]
		[Cpp2IlInjected.Address(RVA = "0x35688E0", Offset = "0x35672E0", VA = "0x1835688E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				bool flag = useCustomTags_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048F0")]
		[Cpp2IlInjected.Address(RVA = "0x3569070", Offset = "0x3567A70", VA = "0x183569070", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0023, IL_0029, IL_002f
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				useCustomTags_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048F1")]
		[Cpp2IlInjected.Address(RVA = "0x35680E0", Offset = "0x3566AE0", VA = "0x1835680E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0014
			if (fieldNumber - 1 <= 5)
			{
				useCustomTags_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048F3")]
		[Cpp2IlInjected.Address(RVA = "0x3568DC0", Offset = "0x35677C0", VA = "0x183568DC0")]
		public string Parse(string str, bool useXml = true)
		{
			//Discarded unreachable code: IL_005f, IL_0065, IL_006b
			//IL_0052: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			int num = 0;
			if (">" == null)
			{
				int startIndex = str.IndexOf("<") + 1;
				if (str.IndexOf(">", startIndex) == 0)
				{
					RepeatedField<CustomXmlTag> repeatedField = tags_;
					bool flag = default(bool);
					if (flag)
					{
						bool flag2 = useCustomTags_;
						int num2 = 0;
						if (flag2)
						{
						}
						if (flag2)
						{
						}
						string newValue = default(string);
						string newValue2 = default(string);
						string text = str.Replace((string)num2, newValue).Replace((string)num2, newValue2);
					}
				}
			}
			return str;
		}

		[Cpp2IlInjected.Token(Token = "0x60048F4")]
		[Cpp2IlInjected.Address(RVA = "0x3569290", Offset = "0x3567C90", VA = "0x183569290")]
		private bool SkipParse(string str)
		{
			//Discarded unreachable code: IL_0025
			if (">" == null)
			{
				int startIndex = str.IndexOf("<") + 1;
				int num = str.IndexOf(">", startIndex);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60048F5")]
		[Cpp2IlInjected.Address(RVA = "0x35683E0", Offset = "0x3566DE0", VA = "0x1835683E0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0084
			RepeatedField<CustomXmlTag> repeatedField = tags_;
			Func<CustomXmlTag, bool> _003C_003E9__57_ = _003C_003Ec._003C_003E9__57_0;
			if (_003C_003E9__57_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CustomXmlTag x)
				{
					//Discarded unreachable code: IL_000c
					string xmlTag_ = x.xmlTag_;
					return x == null;
				};
			}
			IEnumerable<CustomXmlTag> enumerable = (IEnumerable<CustomXmlTag>)Enumerable.Where<CustomXmlTag>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__57_);
			Func<CustomXmlTag, string> func = default(Func<CustomXmlTag, string>);
			if (_003C_003Ec._003C_003E9__57_1 == null)
			{
				func = (Func<CustomXmlTag, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CustomXmlTag x) => x.xmlTag_));
			}
			List<string> list = (List<string>)(object)Enumerable.ToList<string>(Enumerable.Select<CustomXmlTag, string>((IEnumerable<>)enumerable, (Func<, >)(object)func));
			int size = ((List<>)(object)list)._size;
			int num = Enumerable.Count<string>(Enumerable.Distinct<string>((IEnumerable<>)list));
			if (size != num)
			{
				context.AddError("CustomXmlSettings cannot contain same XmlTag twice");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048F6")]
		[Cpp2IlInjected.Address(RVA = "0x3569550", Offset = "0x3567F50", VA = "0x183569550")]
		static CustomXmlSettings()
		{
			MessageParser<CustomXmlTag> parser = CustomXmlTag._parser;
			uint num = default(uint);
			_parser = (MessageParser<CustomXmlSettings>)(object)FieldCodec.ForMessage<CustomXmlTag>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
