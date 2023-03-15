using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E0C")]
	public sealed class ActionSetDialogFlag : IMessage<ActionSetDialogFlag>, IMessage, IEquatable<ActionSetDialogFlag>, IDeepCloneable<ActionSetDialogFlag>, IMessageFieldAccessor, IAction
	{
		[Cpp2IlInjected.Token(Token = "0x40038FB")]
		private static readonly MessageParser<ActionSetDialogFlag> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038FC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038FD")]
		public const int FlagIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038FE")]
		private int flagID_;

		[Cpp2IlInjected.Token(Token = "0x40038FF")]
		public const int ValueFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003900")]
		private bool value_;

		[Cpp2IlInjected.Token(Token = "0x17001490")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionSetDialogFlag> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600761B")]
			[Cpp2IlInjected.Address(RVA = "0x18DD1A0", Offset = "0x18DBBA0", VA = "0x1818DD1A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001491")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600761C")]
			[Cpp2IlInjected.Address(RVA = "0x18DCF90", Offset = "0x18DB990", VA = "0x1818DCF90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001492")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600761D")]
			[Cpp2IlInjected.Address(RVA = "0x18DD200", Offset = "0x18DBC00", VA = "0x1818DD200", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001493")]
		[DebuggerNonUserCode]
		public int FlagID
		{
			[Cpp2IlInjected.Token(Token = "0x6007621")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return flagID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007622")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				flagID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001494")]
		[DebuggerNonUserCode]
		public bool Value
		{
			[Cpp2IlInjected.Token(Token = "0x6007623")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007624")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				value_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001495")]
		public Item FlagItem
		{
			[Cpp2IlInjected.Token(Token = "0x6007630")]
			[Cpp2IlInjected.Address(RVA = "0x18DD060", Offset = "0x18DBA60", VA = "0x1818DD060")]
			get
			{
				long num = Convert.ToInt64((uint)flagID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001496")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6007632")]
			[Cpp2IlInjected.Address(RVA = "0x18DD0C0", Offset = "0x18DBAC0", VA = "0x1818DD0C0", Slot = "15")]
			get
			{
				//IL_0025: Expected O, but got I8
				long num = Convert.ToInt64((uint)flagID_);
				if (!value_)
				{
				}
				return string.Format("SetFlag '{0}' {1}", num, "ON");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600761E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActionSetDialogFlag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600761F")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ActionSetDialogFlag(ActionSetDialogFlag other)
		{
			int num = (flagID_ = other.flagID_);
			bool flag = (value_ = other.value_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007620")]
		[Cpp2IlInjected.Address(RVA = "0x18DCB40", Offset = "0x18DB540", VA = "0x1818DCB40", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionSetDialogFlag Clone()
		{
			//Discarded unreachable code: IL_0037
			ActionSetDialogFlag actionSetDialogFlag = new ActionSetDialogFlag();
			int num = (actionSetDialogFlag.flagID_ = flagID_);
			bool flag = (actionSetDialogFlag.value_ = value_);
			UnknownFieldSet unknownFieldSet = (actionSetDialogFlag._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionSetDialogFlag;
		}

		[Cpp2IlInjected.Token(Token = "0x6007625")]
		[Cpp2IlInjected.Address(RVA = "0x18DCBD0", Offset = "0x18DB5D0", VA = "0x1818DCBD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)flagID_ == (IntPtr)typeof(ActionSetDialogFlag).TypeHandle && (IntPtr)(value_ ? 1 : 0) == (IntPtr)typeof(ActionSetDialogFlag).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007626")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionSetDialogFlag other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.flagID_;
				if (flagID_ == num)
				{
					bool flag = other.value_;
					if (value_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007627")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (flagID_ != 0)
				{
				}
				if (value_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6007628")]
		[Cpp2IlInjected.Address(RVA = "0x18DCE20", Offset = "0x18DB820", VA = "0x1818DCE20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007629")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (flagID_ != 0)
			{
				int value = flagID_;
				output.WriteInt32(value);
			}
			if (value_)
			{
				bool value2 = value_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600762A")]
		[Cpp2IlInjected.Address(RVA = "0x18DCAB0", Offset = "0x18DB4B0", VA = "0x1818DCAB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = flagID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600762B")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionSetDialogFlag other)
		{
			if (other != null)
			{
				int num = other.flagID_;
				if (num != 0)
				{
					flagID_ = num;
				}
				bool flag = other.value_;
				if (flag)
				{
					value_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600762C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (flagID_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (value_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600762D")]
		[Cpp2IlInjected.Address(RVA = "0x18DCC60", Offset = "0x18DB660", VA = "0x1818DCC60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = flagID_;
			}
			if (fieldNumber == 2)
			{
				bool flag = value_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600762E")]
		[Cpp2IlInjected.Address(RVA = "0x18DCD50", Offset = "0x18DB750", VA = "0x1818DCD50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				flagID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			value_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600762F")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				flagID_ = 0;
				break;
			case 2:
				value_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007631")]
		[Cpp2IlInjected.Address(RVA = "0x18DCA10", Offset = "0x18DB410", VA = "0x1818DCA10", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_000f
			ProfileWorld world_ = profile.world_;
			int num = flagID_;
		}

		[Cpp2IlInjected.Token(Token = "0x6007633")]
		[Cpp2IlInjected.Address(RVA = "0x18DCE80", Offset = "0x18DB880", VA = "0x1818DCE80")]
		static ActionSetDialogFlag()
		{
			Func<ActionSetDialogFlag> func = default(Func<ActionSetDialogFlag>);
			_parser = (MessageParser<ActionSetDialogFlag>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
