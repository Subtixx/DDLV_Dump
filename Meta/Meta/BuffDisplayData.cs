using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008C7")]
	public sealed class BuffDisplayData : IMessage<BuffDisplayData>, IMessage, IEquatable<BuffDisplayData>, IDeepCloneable<BuffDisplayData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400236F")]
		private static readonly MessageParser<BuffDisplayData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002370")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002371")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002372")]
		private BuffType type_;

		[Cpp2IlInjected.Token(Token = "0x4002373")]
		public const int OriginFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002374")]
		private BuffOrigin origin_;

		[Cpp2IlInjected.Token(Token = "0x4002375")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002376")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002377")]
		public const int DescriptionFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002378")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002379")]
		public const int IconAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400237A")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400237B")]
		public const int HiddenInUIFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400237C")]
		private bool hiddenInUI_;

		[Cpp2IlInjected.Token(Token = "0x17000CAB")]
		[DebuggerNonUserCode]
		public static MessageParser<BuffDisplayData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004B1E")]
			[Cpp2IlInjected.Address(RVA = "0x1AC1990", Offset = "0x1AC0390", VA = "0x181AC1990")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CAC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004B1F")]
			[Cpp2IlInjected.Address(RVA = "0x1AC18C0", Offset = "0x1AC02C0", VA = "0x181AC18C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CAD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004B20")]
			[Cpp2IlInjected.Address(RVA = "0x1AC19F0", Offset = "0x1AC03F0", VA = "0x181AC19F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CAE")]
		[DebuggerNonUserCode]
		public BuffType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6004B24")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B25")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CAF")]
		[DebuggerNonUserCode]
		public BuffOrigin Origin
		{
			[Cpp2IlInjected.Token(Token = "0x6004B26")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return origin_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B27")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				origin_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB0")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004B28")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B29")]
			[Cpp2IlInjected.Address(RVA = "0x1AC1B70", Offset = "0x1AC0570", VA = "0x181AC1B70")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB1")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6004B2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B2B")]
			[Cpp2IlInjected.Address(RVA = "0x1AC1B00", Offset = "0x1AC0500", VA = "0x181AC1B00")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB2")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004B2C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B2D")]
			[Cpp2IlInjected.Address(RVA = "0x1AC1BE0", Offset = "0x1AC05E0", VA = "0x181AC1BE0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB3")]
		[DebuggerNonUserCode]
		public bool HiddenInUI
		{
			[Cpp2IlInjected.Token(Token = "0x6004B2E")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return hiddenInUI_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B2F")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			set
			{
				hiddenInUI_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B21")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1850", Offset = "0x1AC0250", VA = "0x181AC1850")]
		[DebuggerNonUserCode]
		public BuffDisplayData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B22")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1740", Offset = "0x1AC0140", VA = "0x181AC1740")]
		[DebuggerNonUserCode]
		public BuffDisplayData(BuffDisplayData other)
		{
			BuffType buffType = (type_ = other.type_);
			BuffOrigin buffOrigin = (origin_ = other.origin_);
			string text = (displayName_ = other.displayName_);
			string text2 = (description_ = other.description_);
			string text3 = (iconAddress_ = other.iconAddress_);
			bool flag = (hiddenInUI_ = other.hiddenInUI_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B23")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0B30", Offset = "0x1ABF530", VA = "0x181AC0B30", Slot = "10")]
		[DebuggerNonUserCode]
		public BuffDisplayData Clone()
		{
			//Discarded unreachable code: IL_0098
			BuffDisplayData buffDisplayData = new BuffDisplayData();
			buffDisplayData.displayName_ = "";
			buffDisplayData.description_ = "";
			buffDisplayData.iconAddress_ = "";
			BuffType buffType = (buffDisplayData.type_ = type_);
			BuffOrigin buffOrigin = (buffDisplayData.origin_ = origin_);
			string text = (buffDisplayData.displayName_ = displayName_);
			string text2 = (buffDisplayData.description_ = description_);
			string text3 = (buffDisplayData.iconAddress_ = iconAddress_);
			bool flag = (buffDisplayData.hiddenInUI_ = hiddenInUI_);
			UnknownFieldSet unknownFieldSet = (buffDisplayData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return buffDisplayData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B30")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0D20", Offset = "0x1ABF720", VA = "0x181AC0D20", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)type_ == (IntPtr)typeof(BuffDisplayData).TypeHandle && (IntPtr)(void*)(int)origin_ == (IntPtr)typeof(BuffDisplayData).TypeHandle)
				{
					string text = displayName_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = description_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3 && hiddenInUI_ == flag3)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B31")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0C70", Offset = "0x1ABF670", VA = "0x181AC0C70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuffDisplayData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				BuffType buffType = other.type_;
				if (type_ == buffType)
				{
					BuffOrigin buffOrigin = other.origin_;
					if (origin_ == buffOrigin)
					{
						string text = other.displayName_;
						if (!(displayName_ != text))
						{
							string text2 = other.description_;
							if (!(description_ != text2))
							{
								string text3 = other.iconAddress_;
								if (!(iconAddress_ != text3))
								{
									bool flag = other.hiddenInUI_;
									if (hiddenInUI_ == flag)
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

		[Cpp2IlInjected.Token(Token = "0x6004B32")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0F80", Offset = "0x1ABF980", VA = "0x181AC0F80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_007f
			int num = 0;
			if (type_ != 0)
			{
			}
			if (origin_ != 0)
			{
			}
			string text = displayName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = description_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			if (hiddenInUI_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B33")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1480", Offset = "0x1ABFE80", VA = "0x181AC1480", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B34")]
		[Cpp2IlInjected.Address(RVA = "0x1AC14E0", Offset = "0x1ABFEE0", VA = "0x181AC14E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0093
			if (type_ != 0)
			{
			}
			if (origin_ != 0)
			{
			}
			if (displayName_.m_stringLength != 0)
			{
				string value = displayName_;
				output.WriteString(value);
			}
			if (description_.m_stringLength != 0)
			{
				string value2 = description_;
				output.WriteString(value2);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value3 = iconAddress_;
				output.WriteString(value3);
			}
			if (hiddenInUI_)
			{
				bool value4 = hiddenInUI_;
				output.WriteBool(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B35")]
		[Cpp2IlInjected.Address(RVA = "0x1AC08C0", Offset = "0x1ABF2C0", VA = "0x181AC08C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00c1
			BuffType buffType = type_;
			int num = 0;
			if (buffType != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)buffType);
			}
			BuffOrigin buffOrigin = origin_;
			if (buffOrigin != 0)
			{
				int num3 = CodedOutputStream.ComputeEnumSize((int)buffOrigin);
				num3++;
				num += num3;
			}
			string text = displayName_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num += num4;
			}
			string text2 = description_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B36")]
		[Cpp2IlInjected.Address(RVA = "0x1AC11A0", Offset = "0x1ABFBA0", VA = "0x181AC11A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuffDisplayData other)
		{
			//Discarded unreachable code: IL_00a8
			if (other != null)
			{
				BuffType buffType = other.type_;
				if (buffType != 0)
				{
					type_ = buffType;
				}
				BuffOrigin buffOrigin = other.origin_;
				if (buffOrigin != 0)
				{
					origin_ = buffOrigin;
				}
				string text = other.displayName_;
				if (text.m_stringLength != 0)
				{
					DisplayName = text;
				}
				string text2 = other.description_;
				if (text2.m_stringLength != 0)
				{
					Description = text2;
				}
				string text3 = other.iconAddress_;
				if (text3.m_stringLength != 0)
				{
					IconAddress = text3;
				}
				bool flag = other.hiddenInUI_;
				if (flag)
				{
					hiddenInUI_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B37")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1090", Offset = "0x1ABFA90", VA = "0x181AC1090", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00aa
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (Description = input.ReadString());
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 48)
				{
					goto IL_0093;
				}
				bool flag = (hiddenInUI_ = input.ReadBool());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(type_ = (BuffType)input.ReadInt32());
			}
			int num3 = default(int);
			if (num2 == 16)
			{
				num3 = (int)(origin_ = (BuffOrigin)input.ReadInt32());
			}
			if (num3 == 26)
			{
				string text6 = (DisplayName = input.ReadString());
			}
			goto IL_0093;
			IL_0093:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004B38")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0E10", Offset = "0x1ABF810", VA = "0x181AC0E10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				BuffType buffType = type_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B39")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1260", Offset = "0x1ABFC60", VA = "0x181AC1260", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_001a, IL_0020, IL_0026, IL_002c, IL_0032
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				type_ = (BuffType)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B3A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0A40", Offset = "0x1ABF440", VA = "0x181AC0A40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 5)
			{
				type_ = BuffType.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B3B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1630", Offset = "0x1AC0030", VA = "0x181AC1630")]
		static BuffDisplayData()
		{
			Func<BuffDisplayData> func = default(Func<BuffDisplayData>);
			_parser = (MessageParser<BuffDisplayData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
