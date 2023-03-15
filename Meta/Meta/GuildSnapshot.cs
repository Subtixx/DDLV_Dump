using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class GuildSnapshot : IMessage<GuildSnapshot>, IMessage, IEquatable<GuildSnapshot>, IDeepCloneable<GuildSnapshot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly MessageParser<GuildSnapshot> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public const int IdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private string id_ = "";

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public const int SymbolUrlFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private string symbolUrl_ = "";

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public const int LevelFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int level_;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[DebuggerNonUserCode]
		public static MessageParser<GuildSnapshot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x17006E0", Offset = "0x16FF0E0", VA = "0x1817006E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1700610", Offset = "0x16FF010", VA = "0x181700610")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1700740", Offset = "0x16FF140", VA = "0x181700740", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x17008C0", Offset = "0x16FF2C0", VA = "0x1817008C0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		[DebuggerNonUserCode]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x1700850", Offset = "0x16FF250", VA = "0x181700850")]
			set
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		[DebuggerNonUserCode]
		public string SymbolUrl
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return symbolUrl_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1700930", Offset = "0x16FF330", VA = "0x181700930")]
			set
			{
				string text = (symbolUrl_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return level_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				level_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x17005A0", Offset = "0x16FEFA0", VA = "0x1817005A0")]
		[DebuggerNonUserCode]
		public GuildSnapshot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x17004A0", Offset = "0x16FEEA0", VA = "0x1817004A0")]
		[DebuggerNonUserCode]
		public GuildSnapshot(GuildSnapshot other)
		{
			string text = (name_ = other.name_);
			string text2 = (id_ = other.id_);
			string text3 = (symbolUrl_ = other.symbolUrl_);
			int num = (level_ = other.level_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x16FFAC0", Offset = "0x16FE4C0", VA = "0x1816FFAC0", Slot = "10")]
		[DebuggerNonUserCode]
		public GuildSnapshot Clone()
		{
			//Discarded unreachable code: IL_0078
			GuildSnapshot guildSnapshot = new GuildSnapshot();
			guildSnapshot.name_ = "";
			guildSnapshot.id_ = "";
			guildSnapshot.symbolUrl_ = "";
			string text = (guildSnapshot.name_ = name_);
			string text2 = (guildSnapshot.id_ = id_);
			string text3 = (guildSnapshot.symbolUrl_ = symbolUrl_);
			int num = (guildSnapshot.level_ = level_);
			UnknownFieldSet unknownFieldSet = (guildSnapshot._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return guildSnapshot;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x16FFBF0", Offset = "0x16FE5F0", VA = "0x1816FFBF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = name_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = id_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = symbolUrl_;
						bool flag3 = default(bool);
						if (!flag3 && level_ == (flag3 ? 1 : 0))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x16FFCD0", Offset = "0x16FE6D0", VA = "0x1816FFCD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GuildSnapshot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					string text2 = other.id_;
					if (!(id_ != text2))
					{
						string text3 = other.symbolUrl_;
						if (!(symbolUrl_ != text3))
						{
							int num = other.level_;
							if (level_ == num)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x16FFE60", Offset = "0x16FE860", VA = "0x1816FFE60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006b
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = id_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = symbolUrl_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			if (level_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1700230", Offset = "0x16FEC30", VA = "0x181700230", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1700290", Offset = "0x16FEC90", VA = "0x181700290", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0081
			if (name_.m_stringLength != 0)
			{
				string value = name_;
				output.WriteString(value);
			}
			if (id_.m_stringLength != 0)
			{
				string value2 = id_;
				output.WriteString(value2);
			}
			if (symbolUrl_.m_stringLength != 0)
			{
				string value3 = symbolUrl_;
				output.WriteString(value3);
			}
			if (level_ != 0)
			{
				int value4 = level_;
				output.WriteInt32(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x16FF8C0", Offset = "0x16FE2C0", VA = "0x1816FF8C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00a0
			string text = name_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = id_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = symbolUrl_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			int num5 = level_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
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

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x16FFF30", Offset = "0x16FE930", VA = "0x1816FFF30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GuildSnapshot other)
		{
			//Discarded unreachable code: IL_007e
			if (other != null)
			{
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				string text2 = other.id_;
				if (text2.m_stringLength != 0)
				{
					Id = text2;
				}
				string text3 = other.symbolUrl_;
				if (text3.m_stringLength != 0)
				{
					SymbolUrl = text3;
				}
				int num = other.level_;
				if (num != 0)
				{
					level_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x16FFFD0", Offset = "0x16FE9D0", VA = "0x1816FFFD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_007c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (SymbolUrl = input.ReadString());
				}
				if (num != 32)
				{
					goto IL_0065;
				}
				int num2 = (level_ = input.ReadInt32());
			}
			string text4 = default(string);
			if (num == 10)
			{
				text4 = (Name = input.ReadString());
			}
			if ((long)text4 == 18)
			{
				string text6 = (Id = input.ReadString());
			}
			goto IL_0065;
			IL_0065:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x16FFD70", Offset = "0x16FE770", VA = "0x1816FFD70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						int num2 = level_;
					}
					string text = symbolUrl_;
				}
				string text2 = id_;
			}
			string text3 = name_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x17000C0", Offset = "0x16FEAC0", VA = "0x1817000C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001b: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj = default(object);
						level_ = (int)obj;
						break;
					}
					case 0:
						if (value == null || value != null)
						{
							break;
						}
						throw new InvalidCastException();
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x16FFA10", Offset = "0x16FE410", VA = "0x1816FFA10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_001d: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						level_ = 0;
						break;
					case 0:
						SymbolUrl = "";
						break;
					}
				}
				else
				{
					Id = "";
				}
			}
			else
			{
				Name = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1700390", Offset = "0x16FED90", VA = "0x181700390")]
		static GuildSnapshot()
		{
			Func<GuildSnapshot> func = default(Func<GuildSnapshot>);
			_parser = (MessageParser<GuildSnapshot>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
