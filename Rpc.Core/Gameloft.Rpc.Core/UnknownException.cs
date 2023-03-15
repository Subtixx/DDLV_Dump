using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class UnknownException : IMessage<UnknownException>, IMessage, IEquatable<UnknownException>, IDeepCloneable<UnknownException>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly MessageParser<UnknownException> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public const int ClrTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private string clrType_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public const int MessageFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private string message_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		[DebuggerNonUserCode]
		public static MessageParser<UnknownException> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x38E7D00", Offset = "0x38E6700", VA = "0x1838E7D00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x38E7C30", Offset = "0x38E6630", VA = "0x1838E7C30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x38E7D60", Offset = "0x38E6760", VA = "0x1838E7D60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		[DebuggerNonUserCode]
		public string ClrType
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return clrType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x38E7E70", Offset = "0x38E6870", VA = "0x1838E7E70")]
			set
			{
				string text = (clrType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		[DebuggerNonUserCode]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return message_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x38E7EE0", Offset = "0x38E68E0", VA = "0x1838E7EE0")]
			set
			{
				string text = (message_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x38E7B00", Offset = "0x38E6500", VA = "0x1838E7B00")]
		[DebuggerNonUserCode]
		public UnknownException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x38E7B60", Offset = "0x38E6560", VA = "0x1838E7B60")]
		[DebuggerNonUserCode]
		public UnknownException(UnknownException other)
		{
			string text = (clrType_ = other.clrType_);
			string text2 = (message_ = other.message_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x38E7500", Offset = "0x38E5F00", VA = "0x1838E7500", Slot = "10")]
		[DebuggerNonUserCode]
		public UnknownException Clone()
		{
			//Discarded unreachable code: IL_004d
			UnknownException ex = new UnknownException();
			ex.clrType_ = "";
			ex.message_ = "";
			string text = (ex.clrType_ = clrType_);
			string text2 = (ex.message_ = message_);
			UnknownFieldSet unknownFieldSet = (ex._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return ex;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x38E7600", Offset = "0x38E6000", VA = "0x1838E7600", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = clrType_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = message_;
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

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnknownException other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.clrType_;
				if (!(clrType_ != text))
				{
					string text2 = other.message_;
					if (!(message_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = clrType_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = message_;
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

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x38E7990", Offset = "0x38E6390", VA = "0x1838E7990", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (clrType_.m_stringLength != 0)
			{
				string value = clrType_;
				output.WriteString(value);
			}
			if (message_.m_stringLength != 0)
			{
				string value2 = message_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x38E7370", Offset = "0x38E5D70", VA = "0x1838E7370", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = clrType_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = message_;
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

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x38E7800", Offset = "0x38E6200", VA = "0x1838E7800", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnknownException other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.clrType_;
				if (text.m_stringLength != 0)
				{
					ClrType = text;
				}
				string text2 = other.message_;
				if (text2.m_stringLength != 0)
				{
					Message = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x38E7750", Offset = "0x38E6150", VA = "0x1838E7750", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (ClrType = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (Message = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x38E76C0", Offset = "0x38E60C0", VA = "0x1838E76C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = clrType_;
			}
			if (fieldNumber == 2)
			{
				string text2 = message_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x38E7880", Offset = "0x38E6280", VA = "0x1838E7880", Slot = "12")]
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
				string text = (clrType_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
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

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x38E7450", Offset = "0x38E5E50", VA = "0x1838E7450", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (clrType_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				Message = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x38E79F0", Offset = "0x38E63F0", VA = "0x1838E79F0")]
		static UnknownException()
		{
			Func<UnknownException> func = default(Func<UnknownException>);
			_parser = (MessageParser<UnknownException>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
