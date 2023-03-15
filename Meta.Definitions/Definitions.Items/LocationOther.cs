using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000452")]
	public sealed class LocationOther : IMessage<LocationOther>, IMessage, IEquatable<LocationOther>, IDeepCloneable<LocationOther>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400178A")]
		private static readonly MessageParser<LocationOther> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400178B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400178C")]
		public const int LocationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400178D")]
		private string location_;

		[Cpp2IlInjected.Token(Token = "0x17000D93")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationOther> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600351D")]
			[Cpp2IlInjected.Address(RVA = "0x38EBBC0", Offset = "0x38EA5C0", VA = "0x1838EBBC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D94")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600351E")]
			[Cpp2IlInjected.Address(RVA = "0x38EBAF0", Offset = "0x38EA4F0", VA = "0x1838EBAF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D95")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600351F")]
			[Cpp2IlInjected.Address(RVA = "0x38EBC20", Offset = "0x38EA620", VA = "0x1838EBC20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D96")]
		[DebuggerNonUserCode]
		public string Location
		{
			[Cpp2IlInjected.Token(Token = "0x6003524")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003525")]
			[Cpp2IlInjected.Address(RVA = "0x38EBD30", Offset = "0x38EA730", VA = "0x1838EBD30")]
			set
			{
				string text = (location_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003520")]
		[Cpp2IlInjected.Address(RVA = "0x38EBA20", Offset = "0x38EA420", VA = "0x1838EBA20")]
		[DebuggerNonUserCode]
		public LocationOther()
		{
			location_ = "";
			base._002Ector();
			string text = (location_ = ProtoPreconditions.CheckNotNull("WishingWell", "value"));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003521")]
		[Cpp2IlInjected.Address(RVA = "0x38EB700", Offset = "0x38EA100", VA = "0x1838EB700")]
		private void OnConstruction()
		{
			string text = (location_ = ProtoPreconditions.CheckNotNull("WishingWell", "value"));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003522")]
		[Cpp2IlInjected.Address(RVA = "0x38EB9C0", Offset = "0x38EA3C0", VA = "0x1838EB9C0")]
		[DebuggerNonUserCode]
		public LocationOther(LocationOther other)
		{
			string text = (location_ = other.location_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003523")]
		[Cpp2IlInjected.Address(RVA = "0x38EB450", Offset = "0x38E9E50", VA = "0x1838EB450", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationOther Clone()
		{
			//Discarded unreachable code: IL_0029
			LocationOther locationOther = new LocationOther();
			string text = (locationOther.location_ = location_);
			UnknownFieldSet unknownFieldSet = (locationOther._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationOther;
		}

		[Cpp2IlInjected.Token(Token = "0x6003526")]
		[Cpp2IlInjected.Address(RVA = "0x38EB4E0", Offset = "0x38E9EE0", VA = "0x1838EB4E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = location_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003527")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationOther other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.location_;
				if (!(location_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003528")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = location_;
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

		[Cpp2IlInjected.Token(Token = "0x6003529")]
		[Cpp2IlInjected.Address(RVA = "0x38EB850", Offset = "0x38EA250", VA = "0x1838EB850", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600352A")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (location_.m_stringLength != 0)
			{
				string value = location_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600352B")]
		[Cpp2IlInjected.Address(RVA = "0x38EB320", Offset = "0x38E9D20", VA = "0x1838EB320", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = location_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600352C")]
		[Cpp2IlInjected.Address(RVA = "0x38EB610", Offset = "0x38EA010", VA = "0x1838EB610", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationOther other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.location_;
				if (text.m_stringLength != 0)
				{
					Location = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600352D")]
		[Cpp2IlInjected.Address(RVA = "0x38EB670", Offset = "0x38EA070", VA = "0x1838EB670", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Location = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600352E")]
		[Cpp2IlInjected.Address(RVA = "0x38EB590", Offset = "0x38E9F90", VA = "0x1838EB590", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = location_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600352F")]
		[Cpp2IlInjected.Address(RVA = "0x38EB790", Offset = "0x38EA190", VA = "0x1838EB790", Slot = "12")]
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
				string text = (location_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003530")]
		[Cpp2IlInjected.Address(RVA = "0x38EB3C0", Offset = "0x38E9DC0", VA = "0x1838EB3C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (location_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003531")]
		[Cpp2IlInjected.Address(RVA = "0x38EB8B0", Offset = "0x38EA2B0", VA = "0x1838EB8B0")]
		static LocationOther()
		{
			Func<LocationOther> func = default(Func<LocationOther>);
			_parser = (MessageParser<LocationOther>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
