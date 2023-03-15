using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000457")]
	public sealed class LocationRealm : IMessage<LocationRealm>, IMessage, IEquatable<LocationRealm>, IDeepCloneable<LocationRealm>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001795")]
		private static readonly MessageParser<LocationRealm> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001796")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001797")]
		public const int RealmFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001798")]
		private string realm_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000D9B")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationRealm> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600354F")]
			[Cpp2IlInjected.Address(RVA = "0x38EC5A0", Offset = "0x38EAFA0", VA = "0x1838EC5A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003550")]
			[Cpp2IlInjected.Address(RVA = "0x38EC4D0", Offset = "0x38EAED0", VA = "0x1838EC4D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003551")]
			[Cpp2IlInjected.Address(RVA = "0x38EC600", Offset = "0x38EB000", VA = "0x1838EC600", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9E")]
		[DebuggerNonUserCode]
		public string Realm
		{
			[Cpp2IlInjected.Token(Token = "0x6003555")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return realm_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003556")]
			[Cpp2IlInjected.Address(RVA = "0x38EC710", Offset = "0x38EB110", VA = "0x1838EC710")]
			set
			{
				string text = (realm_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003552")]
		[Cpp2IlInjected.Address(RVA = "0x38EC480", Offset = "0x38EAE80", VA = "0x1838EC480")]
		[DebuggerNonUserCode]
		public LocationRealm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003553")]
		[Cpp2IlInjected.Address(RVA = "0x38EC3E0", Offset = "0x38EADE0", VA = "0x1838EC3E0")]
		[DebuggerNonUserCode]
		public LocationRealm(LocationRealm other)
		{
			string text = (realm_ = other.realm_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003554")]
		[Cpp2IlInjected.Address(RVA = "0x38EBED0", Offset = "0x38EA8D0", VA = "0x1838EBED0", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationRealm Clone()
		{
			//Discarded unreachable code: IL_0034
			LocationRealm locationRealm = new LocationRealm();
			locationRealm.realm_ = "";
			string text = (locationRealm.realm_ = realm_);
			UnknownFieldSet unknownFieldSet = (locationRealm._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationRealm;
		}

		[Cpp2IlInjected.Token(Token = "0x6003557")]
		[Cpp2IlInjected.Address(RVA = "0x38EBF90", Offset = "0x38EA990", VA = "0x1838EBF90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = realm_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003558")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationRealm other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.realm_;
				if (!(realm_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003559")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = realm_;
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

		[Cpp2IlInjected.Token(Token = "0x600355A")]
		[Cpp2IlInjected.Address(RVA = "0x38EC270", Offset = "0x38EAC70", VA = "0x1838EC270", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600355B")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (realm_.m_stringLength != 0)
			{
				string value = realm_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600355C")]
		[Cpp2IlInjected.Address(RVA = "0x38EBDA0", Offset = "0x38EA7A0", VA = "0x1838EBDA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = realm_;
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

		[Cpp2IlInjected.Token(Token = "0x600355D")]
		[Cpp2IlInjected.Address(RVA = "0x38EC150", Offset = "0x38EAB50", VA = "0x1838EC150", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationRealm other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.realm_;
				if (text.m_stringLength != 0)
				{
					Realm = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600355E")]
		[Cpp2IlInjected.Address(RVA = "0x38EC0C0", Offset = "0x38EAAC0", VA = "0x1838EC0C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Realm = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600355F")]
		[Cpp2IlInjected.Address(RVA = "0x38EC040", Offset = "0x38EAA40", VA = "0x1838EC040", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = realm_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003560")]
		[Cpp2IlInjected.Address(RVA = "0x38EC1B0", Offset = "0x38EABB0", VA = "0x1838EC1B0", Slot = "12")]
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
				string text = (realm_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003561")]
		[Cpp2IlInjected.Address(RVA = "0x38EBE40", Offset = "0x38EA840", VA = "0x1838EBE40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (realm_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003562")]
		[Cpp2IlInjected.Address(RVA = "0x38EC2D0", Offset = "0x38EACD0", VA = "0x1838EC2D0")]
		static LocationRealm()
		{
			Func<LocationRealm> func = default(Func<LocationRealm>);
			_parser = (MessageParser<LocationRealm>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
