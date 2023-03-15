using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000E28")]
	public sealed class Connection : IMessage<Connection>, IMessage, IEquatable<Connection>, IDeepCloneable<Connection>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000E29")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000E2A")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x4003954")]
				[OriginalName("Friend")]
				Friend,
				[Cpp2IlInjected.Token(Token = "0x4003955")]
				[OriginalName("Followee")]
				Followee
			}

			[Cpp2IlInjected.Token(Token = "0x2000E2B")]
			public enum Action
			{
				[Cpp2IlInjected.Token(Token = "0x4003957")]
				[OriginalName("Add")]
				Add,
				[Cpp2IlInjected.Token(Token = "0x4003958")]
				[OriginalName("Remove")]
				Remove
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4003949")]
		private static readonly MessageParser<Connection> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400394A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400394B")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400394C")]
		private Types.Type type_;

		[Cpp2IlInjected.Token(Token = "0x400394D")]
		public const int ActionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400394E")]
		private Types.Action action_;

		[Cpp2IlInjected.Token(Token = "0x400394F")]
		public const int IdFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003950")]
		private string id_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003951")]
		public const int PlayerNameFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003952")]
		private string playerName_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014BE")]
		[DebuggerNonUserCode]
		public static MessageParser<Connection> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600772F")]
			[Cpp2IlInjected.Address(RVA = "0x168CEC0", Offset = "0x168B8C0", VA = "0x18168CEC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007730")]
			[Cpp2IlInjected.Address(RVA = "0x168CDF0", Offset = "0x168B7F0", VA = "0x18168CDF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007731")]
			[Cpp2IlInjected.Address(RVA = "0x168D090", Offset = "0x168BA90", VA = "0x18168D090", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C1")]
		[DebuggerNonUserCode]
		public Types.Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x6007735")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007736")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C2")]
		[DebuggerNonUserCode]
		public Types.Action Action
		{
			[Cpp2IlInjected.Token(Token = "0x6007737")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return action_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007738")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				action_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C3")]
		[DebuggerNonUserCode]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6007739")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x600773A")]
			[Cpp2IlInjected.Address(RVA = "0x168D280", Offset = "0x168BC80", VA = "0x18168D280")]
			set
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C4")]
		[DebuggerNonUserCode]
		public string PlayerName
		{
			[Cpp2IlInjected.Token(Token = "0x600773B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return playerName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600773C")]
			[Cpp2IlInjected.Address(RVA = "0x168D2F0", Offset = "0x168BCF0", VA = "0x18168D2F0")]
			set
			{
				string text = (playerName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007732")]
		[Cpp2IlInjected.Address(RVA = "0x168CCC0", Offset = "0x168B6C0", VA = "0x18168CCC0")]
		[DebuggerNonUserCode]
		public Connection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007733")]
		[Cpp2IlInjected.Address(RVA = "0x168CBE0", Offset = "0x168B5E0", VA = "0x18168CBE0")]
		[DebuggerNonUserCode]
		public Connection(Connection other)
		{
			Types.Type type = (type_ = other.type_);
			Types.Action action = (action_ = other.action_);
			string text = (id_ = other.id_);
			string text2 = (playerName_ = other.playerName_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007734")]
		[Cpp2IlInjected.Address(RVA = "0x168B150", Offset = "0x1689B50", VA = "0x18168B150", Slot = "10")]
		[DebuggerNonUserCode]
		public Connection Clone()
		{
			//Discarded unreachable code: IL_006d
			Connection connection = new Connection();
			connection.id_ = "";
			connection.playerName_ = "";
			Types.Type type = (connection.type_ = type_);
			Types.Action action = (connection.action_ = action_);
			string text = (connection.id_ = id_);
			string text2 = (connection.playerName_ = playerName_);
			UnknownFieldSet unknownFieldSet = (connection._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return connection;
		}

		[Cpp2IlInjected.Token(Token = "0x600773D")]
		[Cpp2IlInjected.Address(RVA = "0x168B2B0", Offset = "0x1689CB0", VA = "0x18168B2B0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)type_ == (IntPtr)typeof(Connection).TypeHandle && (IntPtr)(void*)(int)action_ == (IntPtr)typeof(Connection).TypeHandle)
				{
					string text = id_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = playerName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600773E")]
		[Cpp2IlInjected.Address(RVA = "0x168B5E0", Offset = "0x1689FE0", VA = "0x18168B5E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Connection other)
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
					Types.Action action = other.action_;
					if (action_ == action)
					{
						string text = other.id_;
						if (!(id_ != text))
						{
							string text2 = other.playerName_;
							if (!(playerName_ != text2))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600773F")]
		[Cpp2IlInjected.Address(RVA = "0x168B960", Offset = "0x168A360", VA = "0x18168B960", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005b
			int num = 0;
			if (type_ != 0)
			{
			}
			if (action_ != 0)
			{
			}
			string text = id_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = playerName_;
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

		[Cpp2IlInjected.Token(Token = "0x6007740")]
		[Cpp2IlInjected.Address(RVA = "0x168C350", Offset = "0x168AD50", VA = "0x18168C350", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007741")]
		[Cpp2IlInjected.Address(RVA = "0x168C5C0", Offset = "0x168AFC0", VA = "0x18168C5C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005d
			if (type_ != 0)
			{
			}
			if (action_ != 0)
			{
			}
			if (id_.m_stringLength != 0)
			{
				string value = id_;
				output.WriteString(value);
			}
			if (playerName_.m_stringLength != 0)
			{
				string value2 = playerName_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007742")]
		[Cpp2IlInjected.Address(RVA = "0x168AC80", Offset = "0x1689680", VA = "0x18168AC80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_009b
			Types.Type type = type_;
			int num = 0;
			if (type != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)type);
			}
			Types.Action action = action_;
			if (action != 0)
			{
				int num3 = CodedOutputStream.ComputeEnumSize((int)action);
				num3++;
				num += num3;
			}
			string text = id_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num += num4;
			}
			string text2 = playerName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6007743")]
		[Cpp2IlInjected.Address(RVA = "0x168BA20", Offset = "0x168A420", VA = "0x18168BA20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Connection other)
		{
			//Discarded unreachable code: IL_0076
			if (other != null)
			{
				Types.Type type = other.type_;
				if (type != 0)
				{
					type_ = type;
				}
				Types.Action action = other.action_;
				if (action != 0)
				{
					action_ = action;
				}
				string text = other.id_;
				if (text.m_stringLength != 0)
				{
					Id = text;
				}
				string text2 = other.playerName_;
				if (text2.m_stringLength != 0)
				{
					PlayerName = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007744")]
		[Cpp2IlInjected.Address(RVA = "0x168BEF0", Offset = "0x168A8F0", VA = "0x18168BEF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0079
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					string text2 = (Id = input.ReadString());
				}
				if (num != 34)
				{
					goto IL_0062;
				}
				string text4 = (PlayerName = input.ReadString());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(type_ = (Types.Type)input.ReadInt32());
			}
			if (num2 == 16)
			{
				int num3 = (int)(action_ = (Types.Action)input.ReadInt32());
			}
			goto IL_0062;
			IL_0062:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6007745")]
		[Cpp2IlInjected.Address(RVA = "0x168B760", Offset = "0x168A160", VA = "0x18168B760", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0029;
					}
					string text = playerName_;
				}
				string text2 = id_;
			}
			Types.Type type = type_;
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007746")]
		[Cpp2IlInjected.Address(RVA = "0x168C1E0", Offset = "0x168ABE0", VA = "0x18168C1E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003f
			//IL_0025: Expected O, but got I4
			//IL_0036: Expected I4, but got O
			//IL_003e: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							PlayerName = (string)num2;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
						if (value == null || value != null)
						{
							break;
						}
						throw new InvalidCastException();
					}
				}
				else
				{
					object obj = default(object);
					action_ = (Types.Action)obj;
				}
			}
			else
			{
				object obj2 = default(object);
				type_ = (Types.Type)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007747")]
		[Cpp2IlInjected.Address(RVA = "0x168B0B0", Offset = "0x1689AB0", VA = "0x18168B0B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0035: Expected I4, but got I8
			//IL_003f: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						PlayerName = "";
						break;
					case 0:
						Id = "";
						break;
					}
				}
				else
				{
					action_ = Types.Action.Add;
				}
			}
			else
			{
				type_ = Types.Type.Friend;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007748")]
		[Cpp2IlInjected.Address(RVA = "0x168C6B0", Offset = "0x168B0B0", VA = "0x18168C6B0")]
		static Connection()
		{
			Func<Connection> func = default(Func<Connection>);
			_parser = (MessageParser<Connection>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
