using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000788")]
	public sealed class AddressableFieldOptions : IMessage<AddressableFieldOptions>, IMessage, IEquatable<AddressableFieldOptions>, IDeepCloneable<AddressableFieldOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40025BE")]
		private static readonly MessageParser<AddressableFieldOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40025BF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40025C0")]
		public const int AddressableObjectTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025C1")]
		private string addressableObjectType_ = "";

		[Cpp2IlInjected.Token(Token = "0x40025C2")]
		public const int RequiredFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40025C3")]
		private bool required_;

		[Cpp2IlInjected.Token(Token = "0x17001503")]
		[DebuggerNonUserCode]
		public static MessageParser<AddressableFieldOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60052F4")]
			[Cpp2IlInjected.Address(RVA = "0x315B220", Offset = "0x3159C20", VA = "0x18315B220")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001504")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60052F5")]
			[Cpp2IlInjected.Address(RVA = "0x315B150", Offset = "0x3159B50", VA = "0x18315B150")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001505")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60052F6")]
			[Cpp2IlInjected.Address(RVA = "0x315B280", Offset = "0x3159C80", VA = "0x18315B280", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001506")]
		[DebuggerNonUserCode]
		public string AddressableObjectType
		{
			[Cpp2IlInjected.Token(Token = "0x60052FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return addressableObjectType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052FB")]
			[Cpp2IlInjected.Address(RVA = "0x315B390", Offset = "0x3159D90", VA = "0x18315B390")]
			set
			{
				string text = (addressableObjectType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001507")]
		[DebuggerNonUserCode]
		public bool Required
		{
			[Cpp2IlInjected.Token(Token = "0x60052FC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return required_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052FD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				required_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60052F7")]
		[Cpp2IlInjected.Address(RVA = "0x315B100", Offset = "0x3159B00", VA = "0x18315B100")]
		[DebuggerNonUserCode]
		public AddressableFieldOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052F8")]
		[Cpp2IlInjected.Address(RVA = "0x315B060", Offset = "0x3159A60", VA = "0x18315B060")]
		[DebuggerNonUserCode]
		public AddressableFieldOptions(AddressableFieldOptions other)
		{
			string text = (addressableObjectType_ = other.addressableObjectType_);
			bool flag = (required_ = other.required_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60052F9")]
		[Cpp2IlInjected.Address(RVA = "0x315AA80", Offset = "0x3159480", VA = "0x18315AA80", Slot = "10")]
		[DebuggerNonUserCode]
		public AddressableFieldOptions Clone()
		{
			//Discarded unreachable code: IL_0042
			AddressableFieldOptions addressableFieldOptions = new AddressableFieldOptions();
			addressableFieldOptions.addressableObjectType_ = "";
			string text = (addressableFieldOptions.addressableObjectType_ = addressableObjectType_);
			bool flag = (addressableFieldOptions.required_ = required_);
			UnknownFieldSet unknownFieldSet = (addressableFieldOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return addressableFieldOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x60052FE")]
		[Cpp2IlInjected.Address(RVA = "0x315AB50", Offset = "0x3159550", VA = "0x18315AB50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = addressableObjectType_;
				bool flag = default(bool);
				if (!flag && required_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60052FF")]
		[Cpp2IlInjected.Address(RVA = "0x17C5550", Offset = "0x17C3F50", VA = "0x1817C5550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AddressableFieldOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.addressableObjectType_;
				if (!(addressableObjectType_ != text))
				{
					bool flag = other.required_;
					if (required_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005300")]
		[Cpp2IlInjected.Address(RVA = "0x17C5740", Offset = "0x17C4140", VA = "0x1817C5740", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0038
			string text = addressableObjectType_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (required_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005301")]
		[Cpp2IlInjected.Address(RVA = "0x315AEF0", Offset = "0x31598F0", VA = "0x18315AEF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005302")]
		[Cpp2IlInjected.Address(RVA = "0x17C5A50", Offset = "0x17C4450", VA = "0x1817C5A50", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0046
			if (addressableObjectType_.m_stringLength != 0)
			{
				string value = addressableObjectType_;
				output.WriteString(value);
			}
			if (required_)
			{
				bool value2 = required_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005303")]
		[Cpp2IlInjected.Address(RVA = "0x315A930", Offset = "0x3159330", VA = "0x18315A930", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0037
			string text = addressableObjectType_;
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

		[Cpp2IlInjected.Token(Token = "0x6005304")]
		[Cpp2IlInjected.Address(RVA = "0x315AD70", Offset = "0x3159770", VA = "0x18315AD70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AddressableFieldOptions other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				string text = other.addressableObjectType_;
				if (text.m_stringLength != 0)
				{
					AddressableObjectType = text;
				}
				bool flag = other.required_;
				if (flag)
				{
					required_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005305")]
		[Cpp2IlInjected.Address(RVA = "0x315ACD0", Offset = "0x31596D0", VA = "0x18315ACD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (AddressableObjectType = input.ReadString());
				}
				if (num == 16)
				{
					bool flag = (required_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005306")]
		[Cpp2IlInjected.Address(RVA = "0x315AC00", Offset = "0x3159600", VA = "0x18315AC00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = addressableObjectType_;
			}
			bool flag = required_;
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005307")]
		[Cpp2IlInjected.Address(RVA = "0x315ADE0", Offset = "0x31597E0", VA = "0x18315ADE0", Slot = "12")]
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
				string text = (addressableObjectType_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				required_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005308")]
		[Cpp2IlInjected.Address(RVA = "0x315A9D0", Offset = "0x31593D0", VA = "0x18315A9D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (addressableObjectType_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				required_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005309")]
		[Cpp2IlInjected.Address(RVA = "0x315AF50", Offset = "0x3159950", VA = "0x18315AF50")]
		static AddressableFieldOptions()
		{
			Func<AddressableFieldOptions> func = default(Func<AddressableFieldOptions>);
			_parser = (MessageParser<AddressableFieldOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
