using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E39")]
	public sealed class ServerConfig : IMessage<ServerConfig>, IMessage, IEquatable<ServerConfig>, IDeepCloneable<ServerConfig>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4003993")]
		private static readonly MessageParser<ServerConfig> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003994")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003995")]
		public const int DefaultProfilePathFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003996")]
		private string defaultProfilePath_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003997")]
		public const string Path = "ServerConfig.json";

		[Cpp2IlInjected.Token(Token = "0x4003998")]
		private static ServerConfig instance;

		[Cpp2IlInjected.Token(Token = "0x170014E9")]
		[DebuggerNonUserCode]
		public static MessageParser<ServerConfig> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60077E6")]
			[Cpp2IlInjected.Address(RVA = "0x17741B0", Offset = "0x1772BB0", VA = "0x1817741B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60077E7")]
			[Cpp2IlInjected.Address(RVA = "0x1773E70", Offset = "0x1772870", VA = "0x181773E70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60077E8")]
			[Cpp2IlInjected.Address(RVA = "0x1774210", Offset = "0x1772C10", VA = "0x181774210", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EC")]
		[DebuggerNonUserCode]
		public string DefaultProfilePath
		{
			[Cpp2IlInjected.Token(Token = "0x60077EC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return defaultProfilePath_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077ED")]
			[Cpp2IlInjected.Address(RVA = "0x1774320", Offset = "0x1772D20", VA = "0x181774320")]
			set
			{
				string text = (defaultProfilePath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014ED")]
		public static ServerConfig Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60077F9")]
			[Cpp2IlInjected.Address(RVA = "0x1773F40", Offset = "0x1772940", VA = "0x181773F40")]
			get
			{
				//Discarded unreachable code: IL_003d
				IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if ((object)typeof(FileSystem).TypeHandle != null)
				{
					ServerConfig serverConfig = (ServerConfig)(object)(_parser = (MessageParser<ServerConfig>)(object)ProtoParser.Parse<ServerConfig>(FileSystem.Data.ReadAllBytes("ServerConfig.json")));
				}
				return instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077E9")]
		[Cpp2IlInjected.Address(RVA = "0x1773E20", Offset = "0x1772820", VA = "0x181773E20")]
		[DebuggerNonUserCode]
		public ServerConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60077EA")]
		[Cpp2IlInjected.Address(RVA = "0x1773D80", Offset = "0x1772780", VA = "0x181773D80")]
		[DebuggerNonUserCode]
		public ServerConfig(ServerConfig other)
		{
			string text = (defaultProfilePath_ = other.defaultProfilePath_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60077EB")]
		[Cpp2IlInjected.Address(RVA = "0x1773870", Offset = "0x1772270", VA = "0x181773870", Slot = "10")]
		[DebuggerNonUserCode]
		public ServerConfig Clone()
		{
			//Discarded unreachable code: IL_0034
			ServerConfig serverConfig = new ServerConfig();
			serverConfig.defaultProfilePath_ = "";
			string text = (serverConfig.defaultProfilePath_ = defaultProfilePath_);
			UnknownFieldSet unknownFieldSet = (serverConfig._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return serverConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x60077EE")]
		[Cpp2IlInjected.Address(RVA = "0x1773930", Offset = "0x1772330", VA = "0x181773930", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = defaultProfilePath_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077EF")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ServerConfig other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.defaultProfilePath_;
				if (!(defaultProfilePath_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077F0")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = defaultProfilePath_;
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

		[Cpp2IlInjected.Token(Token = "0x60077F1")]
		[Cpp2IlInjected.Address(RVA = "0x1773C10", Offset = "0x1772610", VA = "0x181773C10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60077F2")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (defaultProfilePath_.m_stringLength != 0)
			{
				string value = defaultProfilePath_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60077F3")]
		[Cpp2IlInjected.Address(RVA = "0x1773740", Offset = "0x1772140", VA = "0x181773740", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = defaultProfilePath_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60077F4")]
		[Cpp2IlInjected.Address(RVA = "0x1773A60", Offset = "0x1772460", VA = "0x181773A60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ServerConfig other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.defaultProfilePath_;
				if (text.m_stringLength != 0)
				{
					DefaultProfilePath = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077F5")]
		[Cpp2IlInjected.Address(RVA = "0x1773AC0", Offset = "0x17724C0", VA = "0x181773AC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (DefaultProfilePath = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077F6")]
		[Cpp2IlInjected.Address(RVA = "0x17739E0", Offset = "0x17723E0", VA = "0x1817739E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = defaultProfilePath_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077F7")]
		[Cpp2IlInjected.Address(RVA = "0x1773B50", Offset = "0x1772550", VA = "0x181773B50", Slot = "12")]
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
				string text = (defaultProfilePath_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077F8")]
		[Cpp2IlInjected.Address(RVA = "0x17737E0", Offset = "0x17721E0", VA = "0x1817737E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (defaultProfilePath_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077FA")]
		[Cpp2IlInjected.Address(RVA = "0x1773C70", Offset = "0x1772670", VA = "0x181773C70")]
		static ServerConfig()
		{
			Func<ServerConfig> func = default(Func<ServerConfig>);
			_parser = (MessageParser<ServerConfig>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
