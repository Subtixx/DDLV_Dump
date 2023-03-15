using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010DD")]
	public sealed class DefaultAvatar : IDataValidation, IMessage<DefaultAvatar>, IMessage, IEquatable<DefaultAvatar>, IDeepCloneable<DefaultAvatar>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4004579")]
		private static readonly MessageParser<DefaultAvatar> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400457A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400457B")]
		public const int FemaleFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400457C")]
		private Avatar female_;

		[Cpp2IlInjected.Token(Token = "0x400457D")]
		public const int MaleFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400457E")]
		private Avatar male_;

		[Cpp2IlInjected.Token(Token = "0x170017C3")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultAvatar> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60088EA")]
			[Cpp2IlInjected.Address(RVA = "0x1A20D10", Offset = "0x1A1F710", VA = "0x181A20D10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60088EB")]
			[Cpp2IlInjected.Address(RVA = "0x1A20C40", Offset = "0x1A1F640", VA = "0x181A20C40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60088EC")]
			[Cpp2IlInjected.Address(RVA = "0x1A20D70", Offset = "0x1A1F770", VA = "0x181A20D70", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C6")]
		[DebuggerNonUserCode]
		public Avatar Female
		{
			[Cpp2IlInjected.Token(Token = "0x60088F0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return female_;
			}
			[Cpp2IlInjected.Token(Token = "0x60088F1")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				female_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C7")]
		[DebuggerNonUserCode]
		public Avatar Male
		{
			[Cpp2IlInjected.Token(Token = "0x60088F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return male_;
			}
			[Cpp2IlInjected.Token(Token = "0x60088F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				male_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088E9")]
		[Cpp2IlInjected.Address(RVA = "0x1A1FEA0", Offset = "0x1A1E8A0", VA = "0x181A1FEA0", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0026
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				Avatar avatar = female_;
				Avatar avatar2 = male_;
			}
			else
			{
				context.AddError("Unable to find default inventories");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088ED")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DefaultAvatar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60088EE")]
		[Cpp2IlInjected.Address(RVA = "0x1A20BA0", Offset = "0x1A1F5A0", VA = "0x181A20BA0")]
		[DebuggerNonUserCode]
		public DefaultAvatar(DefaultAvatar other)
		{
			//IL_0021: Expected O, but got I4
			Avatar avatar = other.female_;
			int num = 0;
			if (avatar != null)
			{
				Avatar avatar2 = avatar.Clone();
			}
			female_ = (Avatar)num;
			Avatar avatar3 = other.male_;
			Avatar avatar4 = default(Avatar);
			if (avatar3 != null)
			{
				avatar4 = avatar3.Clone();
			}
			male_ = avatar4;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088EF")]
		[Cpp2IlInjected.Address(RVA = "0x1A1FDD0", Offset = "0x1A1E7D0", VA = "0x181A1FDD0", Slot = "11")]
		[DebuggerNonUserCode]
		public DefaultAvatar Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_0021: Expected O, but got I4
			DefaultAvatar defaultAvatar = new DefaultAvatar();
			Avatar avatar = female_;
			int num = 0;
			if (avatar != null)
			{
				Avatar avatar2 = avatar.Clone();
			}
			defaultAvatar.female_ = (Avatar)num;
			Avatar avatar3 = male_;
			Avatar avatar4 = default(Avatar);
			if (avatar3 != null)
			{
				avatar4 = avatar3.Clone();
			}
			defaultAvatar.male_ = avatar4;
			UnknownFieldSet unknownFieldSet = (defaultAvatar._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return defaultAvatar;
		}

		[Cpp2IlInjected.Token(Token = "0x60088F4")]
		[Cpp2IlInjected.Address(RVA = "0x1A20060", Offset = "0x1A1EA60", VA = "0x181A20060", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(female_, other) && object.Equals(male_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60088F5")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultAvatar other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Avatar objB = other.female_;
				if (object.Equals(female_, objB))
				{
					Avatar objB2 = other.male_;
					if (object.Equals(male_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60088F6")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Avatar avatar = female_;
				if (avatar != null)
				{
					int hashCode = avatar.GetHashCode();
				}
				Avatar avatar2 = male_;
				if (avatar2 != null)
				{
					int hashCode2 = avatar2.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60088F7")]
		[Cpp2IlInjected.Address(RVA = "0x1A204B0", Offset = "0x1A1EEB0", VA = "0x181A204B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60088F8")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)female_ != 0)
			{
				Avatar value = female_;
				output.WriteMessage(value);
			}
			if ((long)male_ != 0)
			{
				Avatar value2 = male_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60088F9")]
		[Cpp2IlInjected.Address(RVA = "0x1A1FD00", Offset = "0x1A1E700", VA = "0x181A1FD00", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Avatar avatar = female_;
				num = 0;
				if (avatar != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(avatar);
				}
				Avatar avatar2 = male_;
				if (avatar2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(avatar2);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60088FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A202E0", Offset = "0x1A1ECE0", VA = "0x181A202E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefaultAvatar other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.female_ != 0)
			{
				Avatar avatar = female_;
				if (avatar == null)
				{
					Avatar avatar2 = (female_ = new Avatar());
					Avatar avatar3 = female_;
				}
				Avatar other2 = other.female_;
				avatar.MergeFrom(other2);
			}
			if ((long)other.male_ != 0)
			{
				Avatar avatar5 = default(Avatar);
				if (male_ == null)
				{
					Avatar avatar4 = (male_ = new Avatar());
					avatar5 = male_;
				}
				Avatar other3 = other.male_;
				avatar5.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60088FB")]
		[Cpp2IlInjected.Address(RVA = "0x1A201B0", Offset = "0x1A1EBB0", VA = "0x181A201B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Avatar avatar = female_;
				if (avatar == null)
				{
					Avatar avatar2 = (female_ = new Avatar());
				}
				input.ReadMessage(avatar);
			}
			if (num == 18)
			{
				Avatar builder = default(Avatar);
				if (male_ == null)
				{
					Avatar avatar3 = (male_ = new Avatar());
					builder = male_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60088FC")]
		[Cpp2IlInjected.Address(RVA = "0x1A20120", Offset = "0x1A1EB20", VA = "0x181A20120", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Avatar avatar = female_;
			}
			if (fieldNumber == 2)
			{
				Avatar avatar2 = male_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60088FD")]
		[Cpp2IlInjected.Address(RVA = "0x1A20400", Offset = "0x1A1EE00", VA = "0x181A20400", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					female_ = (Avatar)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088FE")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088FF")]
		[Cpp2IlInjected.Address(RVA = "0x1A20A90", Offset = "0x1A1F490", VA = "0x181A20A90")]
		static DefaultAvatar()
		{
			Func<DefaultAvatar> func = default(Func<DefaultAvatar>);
			_parser = (MessageParser<DefaultAvatar>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
