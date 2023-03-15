using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000E24")]
	public sealed class Guild : IMessage<Guild>, IMessage, IEquatable<Guild>, IDeepCloneable<Guild>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000E25")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000E26")]
			public enum Action
			{
				[Cpp2IlInjected.Token(Token = "0x4003944")]
				[OriginalName("Created")]
				Created,
				[Cpp2IlInjected.Token(Token = "0x4003945")]
				[OriginalName("Joined")]
				Joined,
				[Cpp2IlInjected.Token(Token = "0x4003946")]
				[OriginalName("Quit")]
				Quit,
				[Cpp2IlInjected.Token(Token = "0x4003947")]
				[OriginalName("Promoted")]
				Promoted
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400393B")]
		private static readonly MessageParser<Guild> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400393C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400393D")]
		public const int ActionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400393E")]
		private Types.Action action_;

		[Cpp2IlInjected.Token(Token = "0x400393F")]
		public const int GuildNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003940")]
		private string guildName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003941")]
		public const int GuildIdFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003942")]
		private string guildId_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014B8")]
		[DebuggerNonUserCode]
		public static MessageParser<Guild> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007714")]
			[Cpp2IlInjected.Address(RVA = "0x17015C0", Offset = "0x16FFFC0", VA = "0x1817015C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007715")]
			[Cpp2IlInjected.Address(RVA = "0x17014F0", Offset = "0x16FFEF0", VA = "0x1817014F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007716")]
			[Cpp2IlInjected.Address(RVA = "0x1701620", Offset = "0x1700020", VA = "0x181701620", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BB")]
		[DebuggerNonUserCode]
		public Types.Action Action
		{
			[Cpp2IlInjected.Token(Token = "0x600771A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return action_;
			}
			[Cpp2IlInjected.Token(Token = "0x600771B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				action_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BC")]
		[DebuggerNonUserCode]
		public string GuildName
		{
			[Cpp2IlInjected.Token(Token = "0x600771C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return guildName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600771D")]
			[Cpp2IlInjected.Address(RVA = "0x17017A0", Offset = "0x17001A0", VA = "0x1817017A0")]
			set
			{
				string text = (guildName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BD")]
		[DebuggerNonUserCode]
		public string GuildId
		{
			[Cpp2IlInjected.Token(Token = "0x600771E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return guildId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600771F")]
			[Cpp2IlInjected.Address(RVA = "0x1701730", Offset = "0x1700130", VA = "0x181701730")]
			set
			{
				string text = (guildId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007717")]
		[Cpp2IlInjected.Address(RVA = "0x1701490", Offset = "0x16FFE90", VA = "0x181701490")]
		[DebuggerNonUserCode]
		public Guild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007718")]
		[Cpp2IlInjected.Address(RVA = "0x17013C0", Offset = "0x16FFDC0", VA = "0x1817013C0")]
		[DebuggerNonUserCode]
		public Guild(Guild other)
		{
			Types.Action action = (action_ = other.action_);
			string text = (guildName_ = other.guildName_);
			string text2 = (guildId_ = other.guildId_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007719")]
		[Cpp2IlInjected.Address(RVA = "0x1700B40", Offset = "0x16FF540", VA = "0x181700B40", Slot = "10")]
		[DebuggerNonUserCode]
		public Guild Clone()
		{
			//Discarded unreachable code: IL_005d
			Guild guild = new Guild();
			guild.guildName_ = "";
			guild.guildId_ = "";
			Types.Action action = (guild.action_ = action_);
			string text = (guild.guildName_ = guildName_);
			string text2 = (guild.guildId_ = guildId_);
			UnknownFieldSet unknownFieldSet = (guild._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return guild;
		}

		[Cpp2IlInjected.Token(Token = "0x6007720")]
		[Cpp2IlInjected.Address(RVA = "0x1700CC0", Offset = "0x16FF6C0", VA = "0x181700CC0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)action_ == (IntPtr)typeof(Guild).TypeHandle)
				{
					string text = guildName_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = guildId_;
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

		[Cpp2IlInjected.Token(Token = "0x6007721")]
		[Cpp2IlInjected.Address(RVA = "0x1700C40", Offset = "0x16FF640", VA = "0x181700C40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Guild other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.Action action = other.action_;
				if (action_ == action)
				{
					string text = other.guildName_;
					if (!(guildName_ != text))
					{
						string text2 = other.guildId_;
						if (!(guildId_ != text2))
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

		[Cpp2IlInjected.Token(Token = "0x6007722")]
		[Cpp2IlInjected.Address(RVA = "0x1700E70", Offset = "0x16FF870", VA = "0x181700E70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0050
			if (action_ != 0)
			{
			}
			string text = guildName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = guildId_;
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

		[Cpp2IlInjected.Token(Token = "0x6007723")]
		[Cpp2IlInjected.Address(RVA = "0x1701190", Offset = "0x16FFB90", VA = "0x181701190", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007724")]
		[Cpp2IlInjected.Address(RVA = "0x17011F0", Offset = "0x16FFBF0", VA = "0x1817011F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0054
			if (action_ != 0)
			{
			}
			if (guildName_.m_stringLength != 0)
			{
				string value = guildName_;
				output.WriteString(value);
			}
			if (guildId_.m_stringLength != 0)
			{
				string value2 = guildId_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007725")]
		[Cpp2IlInjected.Address(RVA = "0x17009A0", Offset = "0x16FF3A0", VA = "0x1817009A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007a
			Types.Action action = action_;
			int num = 0;
			if (action != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)action);
			}
			string text = guildName_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			string text2 = guildId_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6007726")]
		[Cpp2IlInjected.Address(RVA = "0x1700FE0", Offset = "0x16FF9E0", VA = "0x181700FE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Guild other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				Types.Action action = other.action_;
				if (action != 0)
				{
					action_ = action;
				}
				string text = other.guildName_;
				if (text.m_stringLength != 0)
				{
					GuildName = text;
				}
				string text2 = other.guildId_;
				if (text2.m_stringLength != 0)
				{
					GuildId = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007727")]
		[Cpp2IlInjected.Address(RVA = "0x1700F20", Offset = "0x16FF920", VA = "0x181700F20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005f
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(action_ = (Types.Action)input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 18)
				{
					text2 = (GuildName = input.ReadString());
				}
				if ((long)text2 == 26)
				{
					string text4 = (GuildId = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007728")]
		[Cpp2IlInjected.Address(RVA = "0x1700D90", Offset = "0x16FF790", VA = "0x181700D90", Slot = "11")]
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
					string text = guildId_;
				}
				string text2 = guildName_;
			}
			Types.Action action = action_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007729")]
		[Cpp2IlInjected.Address(RVA = "0x1701070", Offset = "0x16FFA70", VA = "0x181701070", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0033
			//IL_0021: Expected O, but got I4
			//IL_0032: Expected I4, but got O
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
						GuildId = (string)num2;
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

		[Cpp2IlInjected.Token(Token = "0x600772A")]
		[Cpp2IlInjected.Address(RVA = "0x1700AB0", Offset = "0x16FF4B0", VA = "0x181700AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0031: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					GuildId = "";
					break;
				case 0:
					GuildName = "";
					break;
				}
			}
			else
			{
				action_ = Types.Action.Created;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600772B")]
		[Cpp2IlInjected.Address(RVA = "0x17012B0", Offset = "0x16FFCB0", VA = "0x1817012B0")]
		static Guild()
		{
			Func<Guild> func = default(Func<Guild>);
			_parser = (MessageParser<Guild>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
