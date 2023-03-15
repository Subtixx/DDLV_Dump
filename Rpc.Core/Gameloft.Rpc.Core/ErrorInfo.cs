using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class ErrorInfo : IMessage<ErrorInfo>, IMessage, IEquatable<ErrorInfo>, IDeepCloneable<ErrorInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static readonly MessageParser<ErrorInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public const int StatusCodeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private StatusCode statusCode_;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public const int DetailFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private string detail_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public const int StackTraceFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private string stackTrace_ = "";

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public const int UnknownErrorFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Any unknownError_;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		[DebuggerNonUserCode]
		public static MessageParser<ErrorInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x38DBD40", Offset = "0x38DA740", VA = "0x1838DBD40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x38DBC70", Offset = "0x38DA670", VA = "0x1838DBC70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x38DBDA0", Offset = "0x38DA7A0", VA = "0x1838DBDA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		[DebuggerNonUserCode]
		public StatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return statusCode_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				statusCode_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		[DebuggerNonUserCode]
		public string Detail
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return detail_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x38DBEB0", Offset = "0x38DA8B0", VA = "0x1838DBEB0")]
			set
			{
				string text = (detail_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[DebuggerNonUserCode]
		public string StackTrace
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return stackTrace_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x38DBF20", Offset = "0x38DA920", VA = "0x1838DBF20")]
			set
			{
				string text = (stackTrace_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		[DebuggerNonUserCode]
		public Any UnknownError
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return unknownError_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				unknownError_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x38DBC10", Offset = "0x38DA610", VA = "0x1838DBC10")]
		[DebuggerNonUserCode]
		public ErrorInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x38DBB20", Offset = "0x38DA520", VA = "0x1838DBB20")]
		[DebuggerNonUserCode]
		public ErrorInfo(ErrorInfo other)
		{
			//IL_0064: Expected O, but got I4
			StatusCode statusCode = (statusCode_ = other.statusCode_);
			string text = (detail_ = other.detail_);
			string text2 = (stackTrace_ = other.stackTrace_);
			Any any = other.unknownError_;
			if (any != null)
			{
				Any any2 = any.Clone();
			}
			int num = 0;
			unknownError_ = (Any)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x38DB090", Offset = "0x38D9A90", VA = "0x1838DB090", Slot = "10")]
		[DebuggerNonUserCode]
		public ErrorInfo Clone()
		{
			//Discarded unreachable code: IL_007e
			//IL_0067: Expected O, but got I4
			ErrorInfo errorInfo = new ErrorInfo();
			errorInfo.detail_ = "";
			errorInfo.stackTrace_ = "";
			StatusCode statusCode = (errorInfo.statusCode_ = statusCode_);
			string text = (errorInfo.detail_ = detail_);
			string text2 = (errorInfo.stackTrace_ = stackTrace_);
			Any any = unknownError_;
			if (any != null)
			{
				Any any2 = any.Clone();
			}
			int num = 0;
			errorInfo.unknownError_ = (Any)num;
			UnknownFieldSet unknownFieldSet = (errorInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return errorInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x38DB250", Offset = "0x38D9C50", VA = "0x1838DB250", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)statusCode_ == (IntPtr)typeof(ErrorInfo).TypeHandle)
				{
					string text = detail_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = stackTrace_;
						bool flag2 = default(bool);
						if (!flag2 && object.Equals(unknownError_, other))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x38DB1B0", Offset = "0x38D9BB0", VA = "0x1838DB1B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ErrorInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				StatusCode statusCode = other.statusCode_;
				if (statusCode_ == statusCode)
				{
					string text = other.detail_;
					if (!(detail_ != text))
					{
						string text2 = other.stackTrace_;
						if (!(stackTrace_ != text2))
						{
							Any objB = other.unknownError_;
							if (object.Equals(unknownError_, objB))
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

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x38DB420", Offset = "0x38D9E20", VA = "0x1838DB420", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0066
			if (statusCode_ != 0)
			{
			}
			string text = detail_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = stackTrace_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			Any any = unknownError_;
			if (any != null)
			{
				int hashCode3 = any.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x38DB8C0", Offset = "0x38DA2C0", VA = "0x1838DB8C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x38DB920", Offset = "0x38DA320", VA = "0x1838DB920", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_006d
			if (statusCode_ != 0)
			{
			}
			if (detail_.m_stringLength != 0)
			{
				string value = detail_;
				output.WriteString(value);
			}
			if (stackTrace_.m_stringLength != 0)
			{
				string value2 = stackTrace_;
				output.WriteString(value2);
			}
			if ((long)unknownError_ != 0)
			{
				Any value3 = unknownError_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x38DAEA0", Offset = "0x38D98A0", VA = "0x1838DAEA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_009b
			StatusCode statusCode = statusCode_;
			int num = 0;
			if (statusCode != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)statusCode);
			}
			string text = detail_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			string text2 = stackTrace_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			Any any = unknownError_;
			if (any != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(any);
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

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x38DB4F0", Offset = "0x38D9EF0", VA = "0x1838DB4F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ErrorInfo other)
		{
			//Discarded unreachable code: IL_00a1
			if (other == null)
			{
				return;
			}
			StatusCode statusCode = other.statusCode_;
			if (statusCode != 0)
			{
				statusCode_ = statusCode;
			}
			string text = other.detail_;
			if (text.m_stringLength != 0)
			{
				Detail = text;
			}
			string text2 = other.stackTrace_;
			if (text2.m_stringLength != 0)
			{
				StackTrace = text2;
			}
			if ((long)other.unknownError_ != 0)
			{
				Any any2 = default(Any);
				if (unknownError_ == null)
				{
					Any any = (unknownError_ = new Any());
					any2 = unknownError_;
				}
				Any other2 = other.unknownError_;
				any2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x38DB600", Offset = "0x38DA000", VA = "0x1838DB600", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0095
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (StackTrace = input.ReadString());
				}
				if (num != 34)
				{
					goto IL_007e;
				}
				Any builder = default(Any);
				if (unknownError_ == null)
				{
					Any any = (unknownError_ = new Any());
					builder = unknownError_;
				}
				input.ReadMessage(builder);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(statusCode_ = (StatusCode)input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text4 = (Detail = input.ReadString());
			}
			goto IL_007e;
			IL_007e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x38DB330", Offset = "0x38D9D30", VA = "0x1838DB330", Slot = "11")]
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
						Any any = unknownError_;
					}
					string text = stackTrace_;
				}
				string text2 = detail_;
			}
			StatusCode statusCode = statusCode_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x38DB740", Offset = "0x38DA140", VA = "0x1838DB740", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e, IL_003a, IL_0040, IL_0046
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0 && num == 1)
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					unknownError_ = (Any)value;
				}
			}
			else
			{
				statusCode_ = StatusCode.Ok;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x38DAFE0", Offset = "0x38D99E0", VA = "0x1838DAFE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0035: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num == 1)
					{
						StackTrace = "";
					}
				}
				else
				{
					Detail = "";
				}
			}
			else
			{
				statusCode_ = StatusCode.Ok;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x38DBA10", Offset = "0x38DA410", VA = "0x1838DBA10")]
		static ErrorInfo()
		{
			Func<ErrorInfo> func = default(Func<ErrorInfo>);
			_parser = (MessageParser<ErrorInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
