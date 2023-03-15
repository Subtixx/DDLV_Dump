using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007DD")]
	public sealed class AccountLinkingInfo : IMessage<AccountLinkingInfo>, IMessage, IEquatable<AccountLinkingInfo>, IDeepCloneable<AccountLinkingInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001F48")]
		private static readonly MessageParser<AccountLinkingInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F49")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F4A")]
		public const int LoggedDeviceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F4B")]
		private DeviceInfo loggedDevice_;

		[Cpp2IlInjected.Token(Token = "0x4001F4C")]
		public const int LastServerSaveFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F4D")]
		private Timestamp lastServerSave_;

		[Cpp2IlInjected.Token(Token = "0x17000A77")]
		[DebuggerNonUserCode]
		public static MessageParser<AccountLinkingInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004104")]
			[Cpp2IlInjected.Address(RVA = "0x1E22F30", Offset = "0x1E21930", VA = "0x181E22F30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A78")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004105")]
			[Cpp2IlInjected.Address(RVA = "0x1E22E60", Offset = "0x1E21860", VA = "0x181E22E60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A79")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004106")]
			[Cpp2IlInjected.Address(RVA = "0x1E22F90", Offset = "0x1E21990", VA = "0x181E22F90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A7A")]
		[DebuggerNonUserCode]
		public DeviceInfo LoggedDevice
		{
			[Cpp2IlInjected.Token(Token = "0x600410A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return loggedDevice_;
			}
			[Cpp2IlInjected.Token(Token = "0x600410B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				loggedDevice_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A7B")]
		[DebuggerNonUserCode]
		public Timestamp LastServerSave
		{
			[Cpp2IlInjected.Token(Token = "0x600410C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return lastServerSave_;
			}
			[Cpp2IlInjected.Token(Token = "0x600410D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				lastServerSave_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004107")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AccountLinkingInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004108")]
		[Cpp2IlInjected.Address(RVA = "0x1E22DC0", Offset = "0x1E217C0", VA = "0x181E22DC0")]
		[DebuggerNonUserCode]
		public AccountLinkingInfo(AccountLinkingInfo other)
		{
			//IL_0021: Expected O, but got I4
			DeviceInfo deviceInfo = other.loggedDevice_;
			int num = 0;
			if (deviceInfo != null)
			{
				DeviceInfo deviceInfo2 = deviceInfo.Clone();
			}
			loggedDevice_ = (DeviceInfo)num;
			Timestamp timestamp = other.lastServerSave_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			lastServerSave_ = timestamp2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004109")]
		[Cpp2IlInjected.Address(RVA = "0x1E22700", Offset = "0x1E21100", VA = "0x181E22700", Slot = "10")]
		[DebuggerNonUserCode]
		public AccountLinkingInfo Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_0021: Expected O, but got I4
			AccountLinkingInfo accountLinkingInfo = new AccountLinkingInfo();
			DeviceInfo deviceInfo = loggedDevice_;
			int num = 0;
			if (deviceInfo != null)
			{
				DeviceInfo deviceInfo2 = deviceInfo.Clone();
			}
			accountLinkingInfo.loggedDevice_ = (DeviceInfo)num;
			Timestamp timestamp = lastServerSave_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			accountLinkingInfo.lastServerSave_ = timestamp2;
			UnknownFieldSet unknownFieldSet = (accountLinkingInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return accountLinkingInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x600410E")]
		[Cpp2IlInjected.Address(RVA = "0x1E227D0", Offset = "0x1E211D0", VA = "0x181E227D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(loggedDevice_, other) && object.Equals(lastServerSave_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600410F")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AccountLinkingInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				DeviceInfo objB = other.loggedDevice_;
				if (object.Equals(loggedDevice_, objB))
				{
					Timestamp objB2 = other.lastServerSave_;
					if (object.Equals(lastServerSave_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004110")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				DeviceInfo deviceInfo = loggedDevice_;
				if (deviceInfo != null)
				{
					int hashCode = deviceInfo.GetHashCode();
				}
				Timestamp timestamp = lastServerSave_;
				if (timestamp != null)
				{
					int hashCode2 = timestamp.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004111")]
		[Cpp2IlInjected.Address(RVA = "0x1E22C50", Offset = "0x1E21650", VA = "0x181E22C50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004112")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)loggedDevice_ != 0)
			{
				DeviceInfo value = loggedDevice_;
				output.WriteMessage(value);
			}
			if ((long)lastServerSave_ != 0)
			{
				Timestamp value2 = lastServerSave_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004113")]
		[Cpp2IlInjected.Address(RVA = "0x1E22630", Offset = "0x1E21030", VA = "0x181E22630", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				DeviceInfo deviceInfo = loggedDevice_;
				num = 0;
				if (deviceInfo != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(deviceInfo);
				}
				Timestamp timestamp = lastServerSave_;
				if (timestamp != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(timestamp);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004114")]
		[Cpp2IlInjected.Address(RVA = "0x1E22A60", Offset = "0x1E21460", VA = "0x181E22A60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AccountLinkingInfo other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.loggedDevice_ != 0)
			{
				DeviceInfo deviceInfo = loggedDevice_;
				if (deviceInfo == null)
				{
					DeviceInfo deviceInfo2 = (loggedDevice_ = new DeviceInfo());
					DeviceInfo deviceInfo3 = loggedDevice_;
				}
				DeviceInfo other2 = other.loggedDevice_;
				deviceInfo.MergeFrom(other2);
			}
			if ((long)other.lastServerSave_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastServerSave_ == null)
				{
					Timestamp timestamp = (lastServerSave_ = new Timestamp());
					timestamp2 = lastServerSave_;
				}
				Timestamp other3 = other.lastServerSave_;
				timestamp2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004115")]
		[Cpp2IlInjected.Address(RVA = "0x1E22920", Offset = "0x1E21320", VA = "0x181E22920", Slot = "5")]
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
				DeviceInfo deviceInfo = loggedDevice_;
				if (deviceInfo == null)
				{
					DeviceInfo deviceInfo2 = (loggedDevice_ = new DeviceInfo());
				}
				input.ReadMessage(deviceInfo);
			}
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (lastServerSave_ == null)
				{
					Timestamp timestamp = (lastServerSave_ = new Timestamp());
					builder = lastServerSave_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004116")]
		[Cpp2IlInjected.Address(RVA = "0x1E22890", Offset = "0x1E21290", VA = "0x181E22890", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				DeviceInfo deviceInfo = loggedDevice_;
			}
			if (fieldNumber == 2)
			{
				Timestamp timestamp = lastServerSave_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004117")]
		[Cpp2IlInjected.Address(RVA = "0x1E22B90", Offset = "0x1E21590", VA = "0x181E22B90", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					loggedDevice_ = (DeviceInfo)num;
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

		[Cpp2IlInjected.Token(Token = "0x6004118")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x6004119")]
		[Cpp2IlInjected.Address(RVA = "0x1E22CB0", Offset = "0x1E216B0", VA = "0x181E22CB0")]
		static AccountLinkingInfo()
		{
			Func<AccountLinkingInfo> func = default(Func<AccountLinkingInfo>);
			_parser = (MessageParser<AccountLinkingInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
