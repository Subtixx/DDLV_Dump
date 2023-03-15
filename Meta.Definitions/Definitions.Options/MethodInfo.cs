using System;
using System.Diagnostics;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x200075D")]
	public sealed class MethodInfo : IMessage<MethodInfo>, IMessage, IEquatable<MethodInfo>, IDeepCloneable<MethodInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40024B1")]
		private static readonly MessageParser<MethodInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024B2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024B3")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024B4")]
		private string type_ = "";

		[Cpp2IlInjected.Token(Token = "0x40024B5")]
		public const int MethodFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024B6")]
		private string method_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014A3")]
		[DebuggerNonUserCode]
		public static MessageParser<MethodInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600515B")]
			[Cpp2IlInjected.Address(RVA = "0x1D27230", Offset = "0x1D25C30", VA = "0x181D27230")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014A4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600515C")]
			[Cpp2IlInjected.Address(RVA = "0x1D27160", Offset = "0x1D25B60", VA = "0x181D27160")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014A5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600515D")]
			[Cpp2IlInjected.Address(RVA = "0x1D27290", Offset = "0x1D25C90", VA = "0x181D27290", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014A6")]
		[DebuggerNonUserCode]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6005161")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005162")]
			[Cpp2IlInjected.Address(RVA = "0x1D27410", Offset = "0x1D25E10", VA = "0x181D27410")]
			set
			{
				string text = (type_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014A7")]
		[DebuggerNonUserCode]
		public string Method
		{
			[Cpp2IlInjected.Token(Token = "0x6005163")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return method_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005164")]
			[Cpp2IlInjected.Address(RVA = "0x1D273A0", Offset = "0x1D25DA0", VA = "0x181D273A0")]
			set
			{
				string text = (method_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005158")]
		[Cpp2IlInjected.Address(RVA = "0x1D26BD0", Offset = "0x1D255D0", VA = "0x181D26BD0")]
		private System.Reflection.MethodInfo GetMethodInfo()
		{
			if ((object)typeof(Type).TypeHandle != null)
			{
				string text = method_;
				System.Reflection.MethodInfo result = default(System.Reflection.MethodInfo);
				return result;
			}
			return (System.Reflection.MethodInfo)typeof(Type).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6005159")]
		[Cpp2IlInjected.Address(RVA = "0x26C9EA0", Offset = "0x26C88A0", VA = "0x1826C9EA0")]
		public Func<, > GetMethod<T1, R>()
		{
			System.Reflection.MethodInfo methodInfo = GetMethodInfo();
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600515A")]
		[Cpp2IlInjected.Address(RVA = "0x26C9EA0", Offset = "0x26C88A0", VA = "0x1826C9EA0")]
		public Func<T1, T2, T3, R> GetMethod<T1, T2, T3, R>()
		{
			System.Reflection.MethodInfo methodInfo = GetMethodInfo();
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600515E")]
		[Cpp2IlInjected.Address(RVA = "0x1D27030", Offset = "0x1D25A30", VA = "0x181D27030")]
		[DebuggerNonUserCode]
		public MethodInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600515F")]
		[Cpp2IlInjected.Address(RVA = "0x1D27090", Offset = "0x1D25A90", VA = "0x181D27090")]
		[DebuggerNonUserCode]
		public MethodInfo(MethodInfo other)
		{
			string text = (type_ = other.type_);
			string text2 = (method_ = other.method_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005160")]
		[Cpp2IlInjected.Address(RVA = "0x1D26980", Offset = "0x1D25380", VA = "0x181D26980", Slot = "10")]
		[DebuggerNonUserCode]
		public MethodInfo Clone()
		{
			//Discarded unreachable code: IL_004d
			MethodInfo methodInfo = new MethodInfo();
			methodInfo.type_ = "";
			methodInfo.method_ = "";
			string text = (methodInfo.type_ = type_);
			string text2 = (methodInfo.method_ = method_);
			UnknownFieldSet unknownFieldSet = (methodInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return methodInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6005165")]
		[Cpp2IlInjected.Address(RVA = "0x1D26A80", Offset = "0x1D25480", VA = "0x181D26A80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = type_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = method_;
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

		[Cpp2IlInjected.Token(Token = "0x6005166")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MethodInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.type_;
				if (!(type_ != text))
				{
					string text2 = other.method_;
					if (!(method_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005167")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = type_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = method_;
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

		[Cpp2IlInjected.Token(Token = "0x6005168")]
		[Cpp2IlInjected.Address(RVA = "0x1D26EC0", Offset = "0x1D258C0", VA = "0x181D26EC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005169")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (type_.m_stringLength != 0)
			{
				string value = type_;
				output.WriteString(value);
			}
			if (method_.m_stringLength != 0)
			{
				string value2 = method_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600516A")]
		[Cpp2IlInjected.Address(RVA = "0x1D267F0", Offset = "0x1D251F0", VA = "0x181D267F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = type_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = method_;
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

		[Cpp2IlInjected.Token(Token = "0x600516B")]
		[Cpp2IlInjected.Address(RVA = "0x1D26C80", Offset = "0x1D25680", VA = "0x181D26C80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MethodInfo other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.type_;
				if (text.m_stringLength != 0)
				{
					Type = text;
				}
				string text2 = other.method_;
				if (text2.m_stringLength != 0)
				{
					Method = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600516C")]
		[Cpp2IlInjected.Address(RVA = "0x1D26D00", Offset = "0x1D25700", VA = "0x181D26D00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Type = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (Method = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600516D")]
		[Cpp2IlInjected.Address(RVA = "0x1D26B40", Offset = "0x1D25540", VA = "0x181D26B40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = type_;
			}
			if (fieldNumber == 2)
			{
				string text2 = method_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600516E")]
		[Cpp2IlInjected.Address(RVA = "0x1D26DB0", Offset = "0x1D257B0", VA = "0x181D26DB0", Slot = "12")]
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
				string text = (type_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
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

		[Cpp2IlInjected.Token(Token = "0x600516F")]
		[Cpp2IlInjected.Address(RVA = "0x1D268D0", Offset = "0x1D252D0", VA = "0x181D268D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (type_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				Method = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005170")]
		[Cpp2IlInjected.Address(RVA = "0x1D26F20", Offset = "0x1D25920", VA = "0x181D26F20")]
		static MethodInfo()
		{
			Func<MethodInfo> func = default(Func<MethodInfo>);
			_parser = (MessageParser<MethodInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
