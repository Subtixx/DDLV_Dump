using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000454")]
	public sealed class LocationCustom : IMessage<LocationCustom>, IMessage, IEquatable<LocationCustom>, IDeepCloneable<LocationCustom>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400178F")]
		private static readonly MessageParser<LocationCustom> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001790")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001791")]
		public const int GUIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001792")]
		private string gUID_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000D97")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationCustom> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003535")]
			[Cpp2IlInjected.Address(RVA = "0x2754600", Offset = "0x2753000", VA = "0x182754600")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D98")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003536")]
			[Cpp2IlInjected.Address(RVA = "0x2754530", Offset = "0x2752F30", VA = "0x182754530")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D99")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003537")]
			[Cpp2IlInjected.Address(RVA = "0x2754660", Offset = "0x2753060", VA = "0x182754660", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9A")]
		[DebuggerNonUserCode]
		public string GUID
		{
			[Cpp2IlInjected.Token(Token = "0x600353B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gUID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600353C")]
			[Cpp2IlInjected.Address(RVA = "0x2754770", Offset = "0x2753170", VA = "0x182754770")]
			set
			{
				string text = (gUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003538")]
		[Cpp2IlInjected.Address(RVA = "0x2754440", Offset = "0x2752E40", VA = "0x182754440")]
		[DebuggerNonUserCode]
		public LocationCustom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003539")]
		[Cpp2IlInjected.Address(RVA = "0x2754490", Offset = "0x2752E90", VA = "0x182754490")]
		[DebuggerNonUserCode]
		public LocationCustom(LocationCustom other)
		{
			string text = (gUID_ = other.gUID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600353A")]
		[Cpp2IlInjected.Address(RVA = "0x2753D40", Offset = "0x2752740", VA = "0x182753D40", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationCustom Clone()
		{
			//Discarded unreachable code: IL_0034
			LocationCustom locationCustom = new LocationCustom();
			locationCustom.gUID_ = "";
			string text = (locationCustom.gUID_ = gUID_);
			UnknownFieldSet unknownFieldSet = (locationCustom._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationCustom;
		}

		[Cpp2IlInjected.Token(Token = "0x600353D")]
		[Cpp2IlInjected.Address(RVA = "0x2753E00", Offset = "0x2752800", VA = "0x182753E00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = gUID_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600353E")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationCustom other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.gUID_;
				if (!(gUID_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600353F")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = gUID_;
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

		[Cpp2IlInjected.Token(Token = "0x6003540")]
		[Cpp2IlInjected.Address(RVA = "0x27542D0", Offset = "0x2752CD0", VA = "0x1827542D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003541")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (gUID_.m_stringLength != 0)
			{
				string value = gUID_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003542")]
		[Cpp2IlInjected.Address(RVA = "0x2753C10", Offset = "0x2752610", VA = "0x182753C10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = gUID_;
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

		[Cpp2IlInjected.Token(Token = "0x6003543")]
		[Cpp2IlInjected.Address(RVA = "0x2754120", Offset = "0x2752B20", VA = "0x182754120", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationCustom other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.gUID_;
				if (text.m_stringLength != 0)
				{
					GUID = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003544")]
		[Cpp2IlInjected.Address(RVA = "0x2754180", Offset = "0x2752B80", VA = "0x182754180", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (GUID = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003545")]
		[Cpp2IlInjected.Address(RVA = "0x2753EB0", Offset = "0x27528B0", VA = "0x182753EB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = gUID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003546")]
		[Cpp2IlInjected.Address(RVA = "0x2754210", Offset = "0x2752C10", VA = "0x182754210", Slot = "12")]
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
				string text = (gUID_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003547")]
		[Cpp2IlInjected.Address(RVA = "0x2753CB0", Offset = "0x27526B0", VA = "0x182753CB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (gUID_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003548")]
		[Cpp2IlInjected.Address(RVA = "0x2753F30", Offset = "0x2752930", VA = "0x182753F30")]
		public static bool IsValidGUID(string guid)
		{
			if (!string.IsNullOrEmpty(guid))
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				bool flag = default(bool);
				if (flag)
				{
					Func<GUIDNameCollection.Types.GUIDName, bool> func = (Func<GUIDNameCollection.Types.GUIDName, bool>)(object)(Func<T, TResult>)delegate(GUIDNameCollection.Types.GUIDName x)
					{
						//Discarded unreachable code: IL_0014
						string b = guid;
						return string.Equals(x.gUID_, b);
					};
					GUIDNameCollection.Types.GUIDName gUIDName = default(GUIDNameCollection.Types.GUIDName);
					return gUIDName != null;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003549")]
		[Cpp2IlInjected.Address(RVA = "0x2754330", Offset = "0x2752D30", VA = "0x182754330")]
		static LocationCustom()
		{
			Func<LocationCustom> func = default(Func<LocationCustom>);
			_parser = (MessageParser<LocationCustom>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
