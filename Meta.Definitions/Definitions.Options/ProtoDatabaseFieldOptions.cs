using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000796")]
	public sealed class ProtoDatabaseFieldOptions : IMessage<ProtoDatabaseFieldOptions>, IMessage, IEquatable<ProtoDatabaseFieldOptions>, IDeepCloneable<ProtoDatabaseFieldOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40025FA")]
		private static readonly MessageParser<ProtoDatabaseFieldOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40025FB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40025FC")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025FD")]
		private string type_ = "";

		[Cpp2IlInjected.Token(Token = "0x40025FE")]
		public const int RequiredFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40025FF")]
		private bool required_;

		[Cpp2IlInjected.Token(Token = "0x4002600")]
		public const int InvalidTextFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002601")]
		private string invalidText_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001526")]
		[DebuggerNonUserCode]
		public static MessageParser<ProtoDatabaseFieldOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005394")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B280", Offset = "0x2D99C80", VA = "0x182D9B280")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001527")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005395")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B1B0", Offset = "0x2D99BB0", VA = "0x182D9B1B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001528")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005396")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B2E0", Offset = "0x2D99CE0", VA = "0x182D9B2E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001529")]
		[DebuggerNonUserCode]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x600539A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x600539B")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B460", Offset = "0x2D99E60", VA = "0x182D9B460")]
			set
			{
				string text = (type_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700152A")]
		[DebuggerNonUserCode]
		public bool Required
		{
			[Cpp2IlInjected.Token(Token = "0x600539C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return required_;
			}
			[Cpp2IlInjected.Token(Token = "0x600539D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				required_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700152B")]
		[DebuggerNonUserCode]
		public string InvalidText
		{
			[Cpp2IlInjected.Token(Token = "0x600539E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return invalidText_;
			}
			[Cpp2IlInjected.Token(Token = "0x600539F")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B3F0", Offset = "0x2D99DF0", VA = "0x182D9B3F0")]
			set
			{
				string text = (invalidText_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005397")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B080", Offset = "0x2D99A80", VA = "0x182D9B080")]
		[DebuggerNonUserCode]
		public ProtoDatabaseFieldOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005398")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B0E0", Offset = "0x2D99AE0", VA = "0x182D9B0E0")]
		[DebuggerNonUserCode]
		public ProtoDatabaseFieldOptions(ProtoDatabaseFieldOptions other)
		{
			string text = (type_ = other.type_);
			bool flag = (required_ = other.required_);
			string text2 = (invalidText_ = other.invalidText_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005399")]
		[Cpp2IlInjected.Address(RVA = "0x2D9A9F0", Offset = "0x2D993F0", VA = "0x182D9A9F0", Slot = "10")]
		[DebuggerNonUserCode]
		public ProtoDatabaseFieldOptions Clone()
		{
			//Discarded unreachable code: IL_005d
			ProtoDatabaseFieldOptions protoDatabaseFieldOptions = new ProtoDatabaseFieldOptions();
			protoDatabaseFieldOptions.type_ = "";
			protoDatabaseFieldOptions.invalidText_ = "";
			string text = (protoDatabaseFieldOptions.type_ = type_);
			bool flag = (protoDatabaseFieldOptions.required_ = required_);
			string text2 = (protoDatabaseFieldOptions.invalidText_ = invalidText_);
			UnknownFieldSet unknownFieldSet = (protoDatabaseFieldOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return protoDatabaseFieldOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x60053A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D9AAF0", Offset = "0x2D994F0", VA = "0x182D9AAF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = type_;
				bool flag = default(bool);
				if (!flag && required_ == flag)
				{
					string text2 = invalidText_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60053A1")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1FE0", Offset = "0x2CB09E0", VA = "0x182CB1FE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProtoDatabaseFieldOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.type_;
				if (!(type_ != text))
				{
					bool flag = other.required_;
					if (required_ == flag)
					{
						string text2 = other.invalidText_;
						if (!(invalidText_ != text2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60053A2")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2480", Offset = "0x2CB0E80", VA = "0x182CB2480", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0053
			string text = type_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (required_)
			{
			}
			string text2 = invalidText_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60053A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D9AF10", Offset = "0x2D99910", VA = "0x182D9AF10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60053A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2800", Offset = "0x2CB1200", VA = "0x182CB2800", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0062
			if (type_.m_stringLength != 0)
			{
				string value = type_;
				output.WriteString(value);
			}
			if (required_)
			{
				bool value2 = required_;
				output.WriteBool(value2);
			}
			if (invalidText_.m_stringLength != 0)
			{
				string value3 = invalidText_;
				output.WriteString(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60053A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D9A880", Offset = "0x2D99280", VA = "0x182D9A880", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_005d
			string text = type_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
			}
			string text2 = invalidText_;
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

		[Cpp2IlInjected.Token(Token = "0x60053A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D9ACA0", Offset = "0x2D996A0", VA = "0x182D9ACA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProtoDatabaseFieldOptions other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				string text = other.type_;
				if (text.m_stringLength != 0)
				{
					Type = text;
				}
				bool flag = other.required_;
				if (flag)
				{
					required_ = flag;
				}
				string text2 = other.invalidText_;
				if (text2.m_stringLength != 0)
				{
					InvalidText = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D9AD30", Offset = "0x2D99730", VA = "0x182D9AD30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Type = input.ReadString());
				}
				bool flag = default(bool);
				if (num == 16)
				{
					flag = (required_ = input.ReadBool());
				}
				if (flag)
				{
					string text4 = (InvalidText = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D9ABC0", Offset = "0x2D995C0", VA = "0x182D9ABC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					string text = invalidText_;
				}
				bool flag = required_;
			}
			string text2 = type_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60053A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D9ADF0", Offset = "0x2D997F0", VA = "0x182D9ADF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						InvalidText = (string)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
				{
					object obj = default(object);
					required_ = (byte)(int)obj != 0;
					break;
				}
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D9A960", Offset = "0x2D99360", VA = "0x182D9A960", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					InvalidText = "";
					break;
				case 0:
					required_ = false;
					break;
				}
			}
			else
			{
				Type = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D9AF70", Offset = "0x2D99970", VA = "0x182D9AF70")]
		static ProtoDatabaseFieldOptions()
		{
			Func<ProtoDatabaseFieldOptions> func = default(Func<ProtoDatabaseFieldOptions>);
			_parser = (MessageParser<ProtoDatabaseFieldOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
