using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000779")]
	public sealed class VisibleIfOptions : IMessage<VisibleIfOptions>, IMessage, IEquatable<VisibleIfOptions>, IDeepCloneable<VisibleIfOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400251C")]
		private static readonly MessageParser<VisibleIfOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400251D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400251E")]
		public const int BoolFieldNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400251F")]
		private string boolFieldName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002520")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002521")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170014D9")]
		[DebuggerNonUserCode]
		public static MessageParser<VisibleIfOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005263")]
			[Cpp2IlInjected.Address(RVA = "0x17C5DB0", Offset = "0x17C47B0", VA = "0x1817C5DB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005264")]
			[Cpp2IlInjected.Address(RVA = "0x17C5CE0", Offset = "0x17C46E0", VA = "0x1817C5CE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005265")]
			[Cpp2IlInjected.Address(RVA = "0x17C5E10", Offset = "0x17C4810", VA = "0x1817C5E10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DC")]
		[DebuggerNonUserCode]
		public string BoolFieldName
		{
			[Cpp2IlInjected.Token(Token = "0x6005269")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return boolFieldName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600526A")]
			[Cpp2IlInjected.Address(RVA = "0x17C5F20", Offset = "0x17C4920", VA = "0x1817C5F20")]
			set
			{
				string text = (boolFieldName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DD")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x600526B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x600526C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005266")]
		[Cpp2IlInjected.Address(RVA = "0x17C5BF0", Offset = "0x17C45F0", VA = "0x1817C5BF0")]
		[DebuggerNonUserCode]
		public VisibleIfOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005267")]
		[Cpp2IlInjected.Address(RVA = "0x17C5C40", Offset = "0x17C4640", VA = "0x1817C5C40")]
		[DebuggerNonUserCode]
		public VisibleIfOptions(VisibleIfOptions other)
		{
			string text = (boolFieldName_ = other.boolFieldName_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005268")]
		[Cpp2IlInjected.Address(RVA = "0x17C5480", Offset = "0x17C3E80", VA = "0x1817C5480", Slot = "10")]
		[DebuggerNonUserCode]
		public VisibleIfOptions Clone()
		{
			//Discarded unreachable code: IL_0042
			VisibleIfOptions visibleIfOptions = new VisibleIfOptions();
			visibleIfOptions.boolFieldName_ = "";
			string text = (visibleIfOptions.boolFieldName_ = boolFieldName_);
			bool flag = (visibleIfOptions.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (visibleIfOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return visibleIfOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x600526D")]
		[Cpp2IlInjected.Address(RVA = "0x17C55C0", Offset = "0x17C3FC0", VA = "0x1817C55C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = boolFieldName_;
				bool flag = default(bool);
				if (!flag && inversed_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600526E")]
		[Cpp2IlInjected.Address(RVA = "0x17C5550", Offset = "0x17C3F50", VA = "0x1817C5550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(VisibleIfOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.boolFieldName_;
				if (!(boolFieldName_ != text))
				{
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600526F")]
		[Cpp2IlInjected.Address(RVA = "0x17C5740", Offset = "0x17C4140", VA = "0x1817C5740", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0038
			string text = boolFieldName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (inversed_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005270")]
		[Cpp2IlInjected.Address(RVA = "0x17C59F0", Offset = "0x17C43F0", VA = "0x1817C59F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005271")]
		[Cpp2IlInjected.Address(RVA = "0x17C5A50", Offset = "0x17C4450", VA = "0x1817C5A50", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0046
			if (boolFieldName_.m_stringLength != 0)
			{
				string value = boolFieldName_;
				output.WriteString(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005272")]
		[Cpp2IlInjected.Address(RVA = "0x17C5330", Offset = "0x17C3D30", VA = "0x1817C5330", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0037
			string text = boolFieldName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005273")]
		[Cpp2IlInjected.Address(RVA = "0x17C5870", Offset = "0x17C4270", VA = "0x1817C5870", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(VisibleIfOptions other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				string text = other.boolFieldName_;
				if (text.m_stringLength != 0)
				{
					BoolFieldName = text;
				}
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005274")]
		[Cpp2IlInjected.Address(RVA = "0x17C57D0", Offset = "0x17C41D0", VA = "0x1817C57D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (BoolFieldName = input.ReadString());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005275")]
		[Cpp2IlInjected.Address(RVA = "0x17C5670", Offset = "0x17C4070", VA = "0x1817C5670", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = boolFieldName_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005276")]
		[Cpp2IlInjected.Address(RVA = "0x17C58E0", Offset = "0x17C42E0", VA = "0x1817C58E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e
			//IL_0019: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (boolFieldName_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				inversed_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005277")]
		[Cpp2IlInjected.Address(RVA = "0x17C53D0", Offset = "0x17C3DD0", VA = "0x1817C53D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (boolFieldName_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				inversed_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005278")]
		[Cpp2IlInjected.Address(RVA = "0x17C5AE0", Offset = "0x17C44E0", VA = "0x1817C5AE0")]
		static VisibleIfOptions()
		{
			Func<VisibleIfOptions> func = default(Func<VisibleIfOptions>);
			_parser = (MessageParser<VisibleIfOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
