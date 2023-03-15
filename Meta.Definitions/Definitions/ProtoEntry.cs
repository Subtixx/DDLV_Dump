using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class ProtoEntry : IMessage<ProtoEntry>, IMessage, IEquatable<ProtoEntry>, IDeepCloneable<ProtoEntry>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly MessageParser<ProtoEntry> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public const int BasePathFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private string basePath_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public const int SourceFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private string source_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public const int NameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public const int PathFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private string path_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public const int TypenameFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private string typename_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public const int ContentFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private ByteString content_;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		public static MessageParser<ProtoEntry> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D4B0", Offset = "0x2D9BEB0", VA = "0x182D9D4B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D3E0", Offset = "0x2D9BDE0", VA = "0x182D9D3E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D510", Offset = "0x2D9BF10", VA = "0x182D9D510", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public string BasePath
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return basePath_;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D620", Offset = "0x2D9C020", VA = "0x182D9D620")]
			set
			{
				string text = (basePath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		public string Source
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return source_;
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D7E0", Offset = "0x2D9C1E0", VA = "0x182D9D7E0")]
			set
			{
				string text = (source_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D700", Offset = "0x2D9C100", VA = "0x182D9D700")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return path_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D770", Offset = "0x2D9C170", VA = "0x182D9D770")]
			set
			{
				string text = (path_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public string Typename
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return typename_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D850", Offset = "0x2D9C250", VA = "0x182D9D850")]
			set
			{
				string text = (typename_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public ByteString Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return content_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D690", Offset = "0x2D9C090", VA = "0x182D9D690")]
			set
			{
				ByteString byteString = (content_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D160", Offset = "0x2D9BB60", VA = "0x182D9D160")]
		[DebuggerNonUserCode]
		public ProtoEntry()
		{
			int num = 0;
			content_ = ByteString.Empty;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D240", Offset = "0x2D9BC40", VA = "0x182D9D240")]
		[DebuggerNonUserCode]
		public ProtoEntry(ProtoEntry other)
		{
			int num = 0;
			content_ = ByteString.Empty;
			base._002Ector();
			string text = (basePath_ = other.basePath_);
			string text2 = (source_ = other.source_);
			string text3 = (name_ = other.name_);
			string text4 = (path_ = other.path_);
			string text5 = (typename_ = other.typename_);
			ByteString byteString = (content_ = other.content_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C500", Offset = "0x2D9AF00", VA = "0x182D9C500", Slot = "10")]
		[DebuggerNonUserCode]
		public ProtoEntry Clone()
		{
			return new ProtoEntry(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9AF60", VA = "0x182D9C560", Slot = "0")]
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
				string text = basePath_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = source_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = name_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							string text4 = path_;
							bool flag4 = default(bool);
							if (!flag4)
							{
								string text5 = typename_;
								bool flag5 = default(bool);
								if (!flag5)
								{
									ByteString byteString = content_;
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
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C6D0", Offset = "0x2D9B0D0", VA = "0x182D9C6D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProtoEntry other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.basePath_;
				if (!(basePath_ != text))
				{
					string text2 = other.source_;
					if (!(source_ != text2))
					{
						string text3 = other.name_;
						if (!(name_ != text3))
						{
							string text4 = other.path_;
							if (!(path_ != text4))
							{
								string text5 = other.typename_;
								if (!(typename_ != text5))
								{
									ByteString byteString = content_;
									ByteString byteString2 = other.content_;
									if (!(byteString != byteString2))
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
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C8F0", Offset = "0x2D9B2F0", VA = "0x182D9C8F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b2
			string text = basePath_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = source_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = name_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = path_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			string text5 = typename_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			if (content_.Length != 0)
			{
				int hashCode6 = content_.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CE70", Offset = "0x2D9B870", VA = "0x182D9CE70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CED0", Offset = "0x2D9B8D0", VA = "0x182D9CED0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00c2
			if (basePath_.m_stringLength != 0)
			{
				string value = basePath_;
				output.WriteString(value);
			}
			if (source_.m_stringLength != 0)
			{
				string value2 = source_;
				output.WriteString(value2);
			}
			if (name_.m_stringLength != 0)
			{
				string value3 = name_;
				output.WriteString(value3);
			}
			if (path_.m_stringLength != 0)
			{
				string value4 = path_;
				output.WriteString(value4);
			}
			if (typename_.m_stringLength != 0)
			{
				string value5 = typename_;
				output.WriteString(value5);
			}
			if (content_.Length != 0)
			{
				ByteString value6 = content_;
				output.WriteBytes(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C1E0", Offset = "0x2D9ABE0", VA = "0x182D9C1E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00f1
			string text = basePath_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = source_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = name_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			string text4 = path_;
			if (text4.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text4);
				num5++;
				num += num5;
			}
			string text5 = typename_;
			if (text5.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text5);
				num6++;
				num += num6;
			}
			if (content_.Length != 0)
			{
				int num7 = CodedOutputStream.ComputeBytesSize(content_);
				num7++;
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CB60", Offset = "0x2D9B560", VA = "0x182D9CB60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProtoEntry other)
		{
			//Discarded unreachable code: IL_00bb
			if (other != null)
			{
				string text = other.basePath_;
				if (text.m_stringLength != 0)
				{
					BasePath = text;
				}
				string text2 = other.source_;
				if (text2.m_stringLength != 0)
				{
					Source = text2;
				}
				string text3 = other.name_;
				if (text3.m_stringLength != 0)
				{
					Name = text3;
				}
				string text4 = other.path_;
				if (text4.m_stringLength != 0)
				{
					Path = text4;
				}
				string text5 = other.typename_;
				if (text5.m_stringLength != 0)
				{
					Typename = text5;
				}
				if (other.content_.Length != 0)
				{
					ByteString byteString2 = (Content = other.content_);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CA20", Offset = "0x2D9B420", VA = "0x182D9CA20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00af
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (Path = input.ReadString());
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (Typename = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_0098;
				}
				ByteString byteString2 = (Content = input.ReadBytes());
			}
			string text6 = default(string);
			if (num == 10)
			{
				text6 = (BasePath = input.ReadString());
			}
			string text8 = default(string);
			if ((long)text6 == 18)
			{
				text8 = (Source = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_0098;
			IL_0098:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C810", Offset = "0x2D9B210", VA = "0x182D9C810", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 5)
			{
				string text = basePath_;
				string text2 = source_;
				string text3 = name_;
				string text4 = path_;
				string text5 = typename_;
				ByteString byteString = content_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CC60", Offset = "0x2D9B660", VA = "0x182D9CC60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_0029, IL_002f, IL_0035, IL_003b
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				BasePath = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C3C0", Offset = "0x2D9ADC0", VA = "0x182D9C3C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0014, IL_0015, IL_0016
			if (fieldNumber - 1 <= 5)
			{
				BasePath = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D050", Offset = "0x2D9BA50", VA = "0x182D9D050")]
		static ProtoEntry()
		{
			Func<ProtoEntry> func = default(Func<ProtoEntry>);
			_parser = (MessageParser<ProtoEntry>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
