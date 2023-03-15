using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000E2D")]
	public sealed class AccountInfo : IMessage<AccountInfo>, IMessage, IEquatable<AccountInfo>, IDeepCloneable<AccountInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400395A")]
		private static readonly MessageParser<AccountInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400395B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400395C")]
		public const int AccountIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400395D")]
		private string accountId_ = "";

		[Cpp2IlInjected.Token(Token = "0x400395E")]
		public const int AvatarUrlFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400395F")]
		private string avatarUrl_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014C5")]
		[DebuggerNonUserCode]
		public static MessageParser<AccountInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600774C")]
			[Cpp2IlInjected.Address(RVA = "0x1E223E0", Offset = "0x1E20DE0", VA = "0x181E223E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600774D")]
			[Cpp2IlInjected.Address(RVA = "0x1E22310", Offset = "0x1E20D10", VA = "0x181E22310")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600774E")]
			[Cpp2IlInjected.Address(RVA = "0x1E22440", Offset = "0x1E20E40", VA = "0x181E22440", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C8")]
		[DebuggerNonUserCode]
		public string AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6007752")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return accountId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007753")]
			[Cpp2IlInjected.Address(RVA = "0x1E22550", Offset = "0x1E20F50", VA = "0x181E22550")]
			set
			{
				string text = (accountId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C9")]
		[DebuggerNonUserCode]
		public string AvatarUrl
		{
			[Cpp2IlInjected.Token(Token = "0x6007754")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return avatarUrl_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007755")]
			[Cpp2IlInjected.Address(RVA = "0x1E225C0", Offset = "0x1E20FC0", VA = "0x181E225C0")]
			set
			{
				string text = (avatarUrl_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600774F")]
		[Cpp2IlInjected.Address(RVA = "0x1E221E0", Offset = "0x1E20BE0", VA = "0x181E221E0")]
		[DebuggerNonUserCode]
		public AccountInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007750")]
		[Cpp2IlInjected.Address(RVA = "0x1E22240", Offset = "0x1E20C40", VA = "0x181E22240")]
		[DebuggerNonUserCode]
		public AccountInfo(AccountInfo other)
		{
			string text = (accountId_ = other.accountId_);
			string text2 = (avatarUrl_ = other.avatarUrl_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007751")]
		[Cpp2IlInjected.Address(RVA = "0x1E21BE0", Offset = "0x1E205E0", VA = "0x181E21BE0", Slot = "10")]
		[DebuggerNonUserCode]
		public AccountInfo Clone()
		{
			//Discarded unreachable code: IL_004d
			AccountInfo accountInfo = new AccountInfo();
			accountInfo.accountId_ = "";
			accountInfo.avatarUrl_ = "";
			string text = (accountInfo.accountId_ = accountId_);
			string text2 = (accountInfo.avatarUrl_ = avatarUrl_);
			UnknownFieldSet unknownFieldSet = (accountInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return accountInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6007756")]
		[Cpp2IlInjected.Address(RVA = "0x1E21CE0", Offset = "0x1E206E0", VA = "0x181E21CE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = accountId_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = avatarUrl_;
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

		[Cpp2IlInjected.Token(Token = "0x6007757")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AccountInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.accountId_;
				if (!(accountId_ != text))
				{
					string text2 = other.avatarUrl_;
					if (!(avatarUrl_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007758")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = accountId_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = avatarUrl_;
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

		[Cpp2IlInjected.Token(Token = "0x6007759")]
		[Cpp2IlInjected.Address(RVA = "0x1E22070", Offset = "0x1E20A70", VA = "0x181E22070", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600775A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (accountId_.m_stringLength != 0)
			{
				string value = accountId_;
				output.WriteString(value);
			}
			if (avatarUrl_.m_stringLength != 0)
			{
				string value2 = avatarUrl_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600775B")]
		[Cpp2IlInjected.Address(RVA = "0x1E21A50", Offset = "0x1E20450", VA = "0x181E21A50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = accountId_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = avatarUrl_;
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

		[Cpp2IlInjected.Token(Token = "0x600775C")]
		[Cpp2IlInjected.Address(RVA = "0x1E21E30", Offset = "0x1E20830", VA = "0x181E21E30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AccountInfo other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.accountId_;
				if (text.m_stringLength != 0)
				{
					AccountId = text;
				}
				string text2 = other.avatarUrl_;
				if (text2.m_stringLength != 0)
				{
					AvatarUrl = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600775D")]
		[Cpp2IlInjected.Address(RVA = "0x1E21EB0", Offset = "0x1E208B0", VA = "0x181E21EB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (AccountId = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (AvatarUrl = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600775E")]
		[Cpp2IlInjected.Address(RVA = "0x1E21DA0", Offset = "0x1E207A0", VA = "0x181E21DA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = accountId_;
			}
			if (fieldNumber == 2)
			{
				string text2 = avatarUrl_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600775F")]
		[Cpp2IlInjected.Address(RVA = "0x1E21F60", Offset = "0x1E20960", VA = "0x181E21F60", Slot = "12")]
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
				string text = (accountId_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
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

		[Cpp2IlInjected.Token(Token = "0x6007760")]
		[Cpp2IlInjected.Address(RVA = "0x1E21B30", Offset = "0x1E20530", VA = "0x181E21B30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (accountId_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				AvatarUrl = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007761")]
		[Cpp2IlInjected.Address(RVA = "0x1E220D0", Offset = "0x1E20AD0", VA = "0x181E220D0")]
		static AccountInfo()
		{
			Func<AccountInfo> func = default(Func<AccountInfo>);
			_parser = (MessageParser<AccountInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
