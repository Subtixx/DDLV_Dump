using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class InitProfileResult : IMessage<InitProfileResult>, IMessage, IEquatable<InitProfileResult>, IDeepCloneable<InitProfileResult>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			public enum ErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x400021C")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x400021D")]
				[OriginalName("InitializationError")]
				InitializationError = 1,
				[Cpp2IlInjected.Token(Token = "0x400021E")]
				[OriginalName("ActualizationError")]
				ActualizationError = 2,
				[Cpp2IlInjected.Token(Token = "0x400021F")]
				[OriginalName("UnknownError")]
				UnknownError = 20
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private static readonly MessageParser<InitProfileResult> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public const int ResultFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private Types.ErrorCode result_;

		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public const int MessageFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private string message_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		[DebuggerNonUserCode]
		public static MessageParser<InitProfileResult> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x1709120", Offset = "0x1707B20", VA = "0x181709120")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x1709050", Offset = "0x1707A50", VA = "0x181709050")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x1709180", Offset = "0x1707B80", VA = "0x181709180", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		[DebuggerNonUserCode]
		public Types.ErrorCode Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return result_;
			}
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				result_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		[DebuggerNonUserCode]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return message_;
			}
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x1709290", Offset = "0x1707C90", VA = "0x181709290")]
			set
			{
				string text = (message_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x1708F60", Offset = "0x1707960", VA = "0x181708F60")]
		[DebuggerNonUserCode]
		public InitProfileResult()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x1708FB0", Offset = "0x17079B0", VA = "0x181708FB0")]
		[DebuggerNonUserCode]
		public InitProfileResult(InitProfileResult other)
		{
			Types.ErrorCode errorCode = (result_ = other.result_);
			string text = (message_ = other.message_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x1708830", Offset = "0x1707230", VA = "0x181708830", Slot = "10")]
		[DebuggerNonUserCode]
		public InitProfileResult Clone()
		{
			//Discarded unreachable code: IL_0042
			InitProfileResult initProfileResult = new InitProfileResult();
			initProfileResult.message_ = "";
			Types.ErrorCode errorCode = (initProfileResult.result_ = result_);
			string text = (initProfileResult.message_ = message_);
			UnknownFieldSet unknownFieldSet = (initProfileResult._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return initProfileResult;
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x1708970", Offset = "0x1707370", VA = "0x181708970", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)result_ == (IntPtr)typeof(InitProfileResult).TypeHandle)
				{
					string text = message_;
					bool flag = default(bool);
					if (!flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x1708900", Offset = "0x1707300", VA = "0x181708900", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(InitProfileResult other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x1708AF0", Offset = "0x17074F0", VA = "0x181708AF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0035
			if (result_ != 0)
			{
			}
			string text = message_;
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

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x1708D60", Offset = "0x1707760", VA = "0x181708D60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x1708DC0", Offset = "0x17077C0", VA = "0x181708DC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0038
			if (result_ != 0)
			{
			}
			if (message_.m_stringLength != 0)
			{
				string value = message_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x17086F0", Offset = "0x17070F0", VA = "0x1817086F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			Types.ErrorCode errorCode = result_;
			int num = 0;
			if (errorCode != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)errorCode);
			}
			string text = message_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
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

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x1708B80", Offset = "0x1707580", VA = "0x181708B80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(InitProfileResult other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
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
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x1708BF0", Offset = "0x17075F0", VA = "0x181708BF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(result_ = (Types.ErrorCode)input.ReadInt32());
				}
				if (num == 18)
				{
					string text2 = (Message = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x1708A20", Offset = "0x1707420", VA = "0x181708A20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.ErrorCode errorCode = result_;
			}
			if (fieldNumber == 2)
			{
				string text = message_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x1708C90", Offset = "0x1707690", VA = "0x181708C90", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				result_ = (Types.ErrorCode)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x17087C0", Offset = "0x17071C0", VA = "0x1817087C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				result_ = Types.ErrorCode.Success;
				break;
			case 2:
				Message = "";
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x1708E50", Offset = "0x1707850", VA = "0x181708E50")]
		static InitProfileResult()
		{
			Func<InitProfileResult> func = default(Func<InitProfileResult>);
			_parser = (MessageParser<InitProfileResult>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
