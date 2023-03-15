using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E31")]
	public sealed class ClientConfig : IMessage<ClientConfig>, IMessage, IEquatable<ClientConfig>, IDeepCloneable<ClientConfig>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4003963")]
		private static readonly MessageParser<ClientConfig> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003964")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003965")]
		public const int VersionFileFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003966")]
		private string versionFile_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003967")]
		public const int ProfilePathFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003968")]
		private string profilePath_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003969")]
		public const string Path = "ClientConfig.json";

		[Cpp2IlInjected.Token(Token = "0x400396A")]
		private static ClientConfig instance;

		[Cpp2IlInjected.Token(Token = "0x170014CB")]
		[DebuggerNonUserCode]
		public static MessageParser<ClientConfig> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600776E")]
			[Cpp2IlInjected.Address(RVA = "0x1672680", Offset = "0x1671080", VA = "0x181672680")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600776F")]
			[Cpp2IlInjected.Address(RVA = "0x1672400", Offset = "0x1670E00", VA = "0x181672400")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007770")]
			[Cpp2IlInjected.Address(RVA = "0x16726E0", Offset = "0x16710E0", VA = "0x1816726E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CE")]
		[DebuggerNonUserCode]
		public string VersionFile
		{
			[Cpp2IlInjected.Token(Token = "0x6007774")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return versionFile_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007775")]
			[Cpp2IlInjected.Address(RVA = "0x1672860", Offset = "0x1671260", VA = "0x181672860")]
			set
			{
				string text = (versionFile_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CF")]
		[DebuggerNonUserCode]
		public string ProfilePath
		{
			[Cpp2IlInjected.Token(Token = "0x6007776")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return profilePath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007777")]
			[Cpp2IlInjected.Address(RVA = "0x16727F0", Offset = "0x16711F0", VA = "0x1816727F0")]
			set
			{
				string text = (profilePath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D0")]
		public static ClientConfig Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6007783")]
			[Cpp2IlInjected.Address(RVA = "0x16724D0", Offset = "0x1670ED0", VA = "0x1816724D0")]
			get
			{
				//Discarded unreachable code: IL_001f
				_parser = (MessageParser<ClientConfig>)(object)ProtoParser.Parse<ClientConfig>(FileSystem.Data.ReadAllBytes("ClientConfig.json"));
				return instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007771")]
		[Cpp2IlInjected.Address(RVA = "0x16722D0", Offset = "0x1670CD0", VA = "0x1816722D0")]
		[DebuggerNonUserCode]
		public ClientConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007772")]
		[Cpp2IlInjected.Address(RVA = "0x1672330", Offset = "0x1670D30", VA = "0x181672330")]
		[DebuggerNonUserCode]
		public ClientConfig(ClientConfig other)
		{
			string text = (versionFile_ = other.versionFile_);
			string text2 = (profilePath_ = other.profilePath_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007773")]
		[Cpp2IlInjected.Address(RVA = "0x1671CD0", Offset = "0x16706D0", VA = "0x181671CD0", Slot = "10")]
		[DebuggerNonUserCode]
		public ClientConfig Clone()
		{
			//Discarded unreachable code: IL_004d
			ClientConfig clientConfig = new ClientConfig();
			clientConfig.versionFile_ = "";
			clientConfig.profilePath_ = "";
			string text = (clientConfig.versionFile_ = versionFile_);
			string text2 = (clientConfig.profilePath_ = profilePath_);
			UnknownFieldSet unknownFieldSet = (clientConfig._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return clientConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x6007778")]
		[Cpp2IlInjected.Address(RVA = "0x1671DD0", Offset = "0x16707D0", VA = "0x181671DD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = versionFile_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = profilePath_;
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

		[Cpp2IlInjected.Token(Token = "0x6007779")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ClientConfig other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.versionFile_;
				if (!(versionFile_ != text))
				{
					string text2 = other.profilePath_;
					if (!(profilePath_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600777A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = versionFile_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = profilePath_;
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

		[Cpp2IlInjected.Token(Token = "0x600777B")]
		[Cpp2IlInjected.Address(RVA = "0x1672160", Offset = "0x1670B60", VA = "0x181672160", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600777C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (versionFile_.m_stringLength != 0)
			{
				string value = versionFile_;
				output.WriteString(value);
			}
			if (profilePath_.m_stringLength != 0)
			{
				string value2 = profilePath_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600777D")]
		[Cpp2IlInjected.Address(RVA = "0x1671B40", Offset = "0x1670540", VA = "0x181671B40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = versionFile_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = profilePath_;
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

		[Cpp2IlInjected.Token(Token = "0x600777E")]
		[Cpp2IlInjected.Address(RVA = "0x1671FD0", Offset = "0x16709D0", VA = "0x181671FD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ClientConfig other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.versionFile_;
				if (text.m_stringLength != 0)
				{
					VersionFile = text;
				}
				string text2 = other.profilePath_;
				if (text2.m_stringLength != 0)
				{
					ProfilePath = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600777F")]
		[Cpp2IlInjected.Address(RVA = "0x1671F20", Offset = "0x1670920", VA = "0x181671F20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (VersionFile = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (ProfilePath = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007780")]
		[Cpp2IlInjected.Address(RVA = "0x1671E90", Offset = "0x1670890", VA = "0x181671E90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = versionFile_;
			}
			if (fieldNumber == 2)
			{
				string text2 = profilePath_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007781")]
		[Cpp2IlInjected.Address(RVA = "0x1672050", Offset = "0x1670A50", VA = "0x181672050", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (versionFile_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007782")]
		[Cpp2IlInjected.Address(RVA = "0x1671C20", Offset = "0x1670620", VA = "0x181671C20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (versionFile_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				ProfilePath = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007784")]
		[Cpp2IlInjected.Address(RVA = "0x1671CD0", Offset = "0x16706D0", VA = "0x181671CD0")]
		public ClientConfig Create()
		{
			//Discarded unreachable code: IL_004d
			ClientConfig clientConfig = new ClientConfig();
			clientConfig.versionFile_ = "";
			clientConfig.profilePath_ = "";
			string text = (clientConfig.versionFile_ = versionFile_);
			string text2 = (clientConfig.profilePath_ = profilePath_);
			UnknownFieldSet unknownFieldSet = (clientConfig._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return clientConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x6007785")]
		[Cpp2IlInjected.Address(RVA = "0x16721C0", Offset = "0x1670BC0", VA = "0x1816721C0")]
		static ClientConfig()
		{
			Func<ClientConfig> func = default(Func<ClientConfig>);
			_parser = (MessageParser<ClientConfig>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
