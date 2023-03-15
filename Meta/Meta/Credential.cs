using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class Credential : IMessage<Credential>, IMessage, IEquatable<Credential>, IDeepCloneable<Credential>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200008A")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				[OriginalName("Anonymous")]
				Anonymous,
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				[OriginalName("FedId")]
				FedId,
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				[OriginalName("Game")]
				Game,
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				[OriginalName("Steam")]
				Steam
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private static readonly MessageParser<Credential> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Types.Type type_;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public const int UsernameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private string username_ = "";

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[DebuggerNonUserCode]
		public static MessageParser<Credential> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x18BF750", Offset = "0x18BE150", VA = "0x1818BF750")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0x18BF5C0", Offset = "0x18BDFC0", VA = "0x1818BF5C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x18BF7B0", Offset = "0x18BE1B0", VA = "0x1818BF7B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		[DebuggerNonUserCode]
		public Types.Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		[DebuggerNonUserCode]
		public string Username
		{
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return username_;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x18BF8C0", Offset = "0x18BE2C0", VA = "0x1818BF8C0")]
			set
			{
				string text = (username_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public string Formatted
		{
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x18BF690", Offset = "0x18BE090", VA = "0x1818BF690")]
			get
			{
				//Discarded unreachable code: IL_002d
				//IL_000d: Expected O, but got I4
				Types.Type type = type_;
				string text = ((Enum)type).ToString();
				Types.Type type2 = type;
				string text2 = text.ToLower();
				string text3 = username_;
				return text2 + ":" + text3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x18BF4D0", Offset = "0x18BDED0", VA = "0x1818BF4D0")]
		[DebuggerNonUserCode]
		public Credential()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x18BF520", Offset = "0x18BDF20", VA = "0x1818BF520")]
		[DebuggerNonUserCode]
		public Credential(Credential other)
		{
			Types.Type type = (type_ = other.type_);
			string text = (username_ = other.username_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x18BEF30", Offset = "0x18BD930", VA = "0x1818BEF30", Slot = "10")]
		[DebuggerNonUserCode]
		public Credential Clone()
		{
			//Discarded unreachable code: IL_0042
			Credential credential = new Credential();
			credential.username_ = "";
			Types.Type type = (credential.type_ = type_);
			string text = (credential.username_ = username_);
			UnknownFieldSet unknownFieldSet = (credential._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return credential;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x18BF000", Offset = "0x18BDA00", VA = "0x1818BF000", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)type_ == (IntPtr)typeof(Credential).TypeHandle)
				{
					string text = username_;
					bool flag = default(bool);
					if (!flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x1708900", Offset = "0x1707300", VA = "0x181708900", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Credential other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.Type type = other.type_;
				if (type_ == type)
				{
					string text = other.username_;
					if (!(username_ != text))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x1708AF0", Offset = "0x17074F0", VA = "0x181708AF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0035
			if (type_ != 0)
			{
			}
			string text = username_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x18BF360", Offset = "0x18BDD60", VA = "0x1818BF360", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x1708DC0", Offset = "0x17077C0", VA = "0x181708DC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0038
			if (type_ != 0)
			{
			}
			if (username_.m_stringLength != 0)
			{
				string value = username_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x18BEDF0", Offset = "0x18BD7F0", VA = "0x1818BEDF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			Types.Type type = type_;
			int num = 0;
			if (type != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)type);
			}
			string text = username_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
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

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x18BF180", Offset = "0x18BDB80", VA = "0x1818BF180", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Credential other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				Types.Type type = other.type_;
				if (type != 0)
				{
					type_ = type;
				}
				string text = other.username_;
				if (text.m_stringLength != 0)
				{
					Username = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x18BF1F0", Offset = "0x18BDBF0", VA = "0x1818BF1F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(type_ = (Types.Type)input.ReadInt32());
				}
				if (num == 18)
				{
					string text2 = (Username = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x18BF0B0", Offset = "0x18BDAB0", VA = "0x1818BF0B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.Type type = type_;
			}
			if (fieldNumber == 2)
			{
				string text = username_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x18BF290", Offset = "0x18BDC90", VA = "0x1818BF290", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				type_ = (Types.Type)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x18BEEC0", Offset = "0x18BD8C0", VA = "0x1818BEEC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				type_ = Types.Type.Anonymous;
				break;
			case 2:
				Username = "";
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x18BF3C0", Offset = "0x18BDDC0", VA = "0x1818BF3C0")]
		static Credential()
		{
			Func<Credential> func = default(Func<Credential>);
			_parser = (MessageParser<Credential>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
