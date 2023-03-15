using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class LoadProfileResult : IMessage<LoadProfileResult>, IMessage, IEquatable<LoadProfileResult>, IDeepCloneable<LoadProfileResult>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000AA")]
			public enum ErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x400022A")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x400022B")]
				[OriginalName("ParsingError")]
				ParsingError = 1,
				[Cpp2IlInjected.Token(Token = "0x400022C")]
				[OriginalName("BinaryParsingError")]
				BinaryParsingError = 2,
				[Cpp2IlInjected.Token(Token = "0x400022D")]
				[OriginalName("VersionMismatch")]
				VersionMismatch = 3,
				[Cpp2IlInjected.Token(Token = "0x400022E")]
				[OriginalName("ProfileMissingData")]
				ProfileMissingData = 4,
				[Cpp2IlInjected.Token(Token = "0x400022F")]
				[OriginalName("DecryptingError")]
				DecryptingError = 5,
				[Cpp2IlInjected.Token(Token = "0x4000230")]
				[OriginalName("UnknownError")]
				UnknownError = 20
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private static readonly MessageParser<LoadProfileResult> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public const int ProfileFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private Profile profile_;

		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public const int ResultFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private Types.ErrorCode result_;

		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public const int MessageFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private string message_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		[DebuggerNonUserCode]
		public static MessageParser<LoadProfileResult> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x18ACE20", Offset = "0x18AB820", VA = "0x1818ACE20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x18ACD50", Offset = "0x18AB750", VA = "0x1818ACD50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x18ACE80", Offset = "0x18AB880", VA = "0x1818ACE80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		[DebuggerNonUserCode]
		public Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return profile_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				profile_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		[DebuggerNonUserCode]
		public Types.ErrorCode Result
		{
			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return result_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				result_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[DebuggerNonUserCode]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return message_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x18ACF90", Offset = "0x18AB990", VA = "0x1818ACF90")]
			set
			{
				string text = (message_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x18ACD00", Offset = "0x18AB700", VA = "0x1818ACD00")]
		[DebuggerNonUserCode]
		public LoadProfileResult()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x18ACC40", Offset = "0x18AB640", VA = "0x1818ACC40")]
		[DebuggerNonUserCode]
		public LoadProfileResult(LoadProfileResult other)
		{
			//IL_002c: Expected O, but got I4
			Profile profile = other.profile_;
			if (profile != null)
			{
				Profile profile2 = profile.Clone();
			}
			int num = 0;
			profile_ = (Profile)num;
			Types.ErrorCode errorCode = (result_ = other.result_);
			string text = (message_ = other.message_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x18AC310", Offset = "0x18AAD10", VA = "0x1818AC310", Slot = "10")]
		[DebuggerNonUserCode]
		public LoadProfileResult Clone()
		{
			//Discarded unreachable code: IL_0063
			//IL_002c: Expected O, but got I4
			LoadProfileResult loadProfileResult = new LoadProfileResult();
			loadProfileResult.message_ = "";
			Profile profile = profile_;
			if (profile != null)
			{
				Profile profile2 = profile.Clone();
			}
			int num = 0;
			loadProfileResult.profile_ = (Profile)num;
			Types.ErrorCode errorCode = (loadProfileResult.result_ = result_);
			string text = (loadProfileResult.message_ = message_);
			UnknownFieldSet unknownFieldSet = (loadProfileResult._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return loadProfileResult;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x18AC400", Offset = "0x18AAE00", VA = "0x1818AC400", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(profile_, other);
				if (flag && result_ == (flag ? Types.ErrorCode.ParsingError : Types.ErrorCode.Success))
				{
					string text = message_;
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

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x18AC4D0", Offset = "0x18AAED0", VA = "0x1818AC4D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LoadProfileResult other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Profile objB = other.profile_;
				if (object.Equals(profile_, objB))
				{
					Types.ErrorCode errorCode = other.result_;
					if (result_ == errorCode)
					{
						string text = other.message_;
						if (!(message_ != text))
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

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x18AC630", Offset = "0x18AB030", VA = "0x1818AC630", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004b
			Profile profile = profile_;
			if (profile != null)
			{
				int hashCode = profile.GetHashCode();
			}
			if (result_ != 0)
			{
			}
			string text = message_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x18ACA10", Offset = "0x18AB410", VA = "0x1818ACA10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x18ACA70", Offset = "0x18AB470", VA = "0x1818ACA70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0051
			if ((long)profile_ != 0)
			{
				Profile value = profile_;
				output.WriteMessage(value);
			}
			if (result_ != 0)
			{
			}
			if (message_.m_stringLength != 0)
			{
				string value2 = message_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x18AC180", Offset = "0x18AAB80", VA = "0x1818AC180", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0075
			Profile profile = profile_;
			int num = 0;
			if (profile != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(profile);
			}
			Types.ErrorCode errorCode = result_;
			if (errorCode != 0)
			{
				int num3 = CodedOutputStream.ComputeEnumSize((int)errorCode);
				num3++;
				num += num3;
			}
			string text = message_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
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

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x18AC7F0", Offset = "0x18AB1F0", VA = "0x1818AC7F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LoadProfileResult other)
		{
			//Discarded unreachable code: IL_0084
			if (other == null)
			{
				return;
			}
			if ((long)other.profile_ != 0)
			{
				Profile profile = profile_;
				if (profile == null)
				{
					Profile profile2 = (profile_ = new Profile());
				}
				Profile other2 = other.profile_;
				profile.MergeFrom(other2);
			}
			Types.ErrorCode errorCode = other.result_;
			if (errorCode != 0)
			{
				result_ = errorCode;
			}
			string text = other.message_;
			if (text.m_stringLength != 0)
			{
				Message = text;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x18AC6E0", Offset = "0x18AB0E0", VA = "0x1818AC6E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0071
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Profile profile = profile_;
				if (profile == null)
				{
					Profile profile2 = (profile_ = new Profile());
				}
				input.ReadMessage(profile);
			}
			int num2 = default(int);
			if (num == 16)
			{
				num2 = (int)(result_ = (Types.ErrorCode)input.ReadInt32());
			}
			if (num2 == 26)
			{
				string text2 = (Message = input.ReadString());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x18AC550", Offset = "0x18AAF50", VA = "0x1818AC550", Slot = "11")]
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
					string text = message_;
				}
				Types.ErrorCode errorCode = result_;
			}
			Profile profile = profile_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x18AC8E0", Offset = "0x18AB2E0", VA = "0x1818AC8E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			//IL_0029: Expected I4, but got O
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
						Message = (string)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
				{
					object obj = default(object);
					result_ = (Types.ErrorCode)obj;
					break;
				}
				}
				return;
			}
			if (value == null || value != null)
			{
				profile_ = (Profile)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x18AC280", Offset = "0x18AAC80", VA = "0x1818AC280", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0025: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					Message = "";
					break;
				case 0:
					result_ = Types.ErrorCode.Success;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x18ACB30", Offset = "0x18AB530", VA = "0x1818ACB30")]
		static LoadProfileResult()
		{
			Func<LoadProfileResult> func = default(Func<LoadProfileResult>);
			_parser = (MessageParser<LoadProfileResult>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
