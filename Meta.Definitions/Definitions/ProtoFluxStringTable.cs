using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class ProtoFluxStringTable : IMessage<ProtoFluxStringTable>, IMessage, IEquatable<ProtoFluxStringTable>, IDeepCloneable<ProtoFluxStringTable>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private static readonly MessageParser<ProtoFluxStringTable> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public const int StringsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private static readonly MapField<string, string>.Codec _map_strings_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly MapField<string, string> strings_ = (MapField<string, string>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public static MessageParser<ProtoFluxStringTable> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2D9FC70", Offset = "0x2D9E670", VA = "0x182D9FC70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2D9FBA0", Offset = "0x2D9E5A0", VA = "0x182D9FBA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2D9FCD0", Offset = "0x2D9E6D0", VA = "0x182D9FCD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		[DebuggerNonUserCode]
		public MapField<string, string> Strings
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return strings_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FB20", Offset = "0x2D9E520", VA = "0x182D9FB20")]
		[DebuggerNonUserCode]
		public ProtoFluxStringTable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA20", Offset = "0x2D9E420", VA = "0x182D9FA20")]
		[DebuggerNonUserCode]
		public ProtoFluxStringTable(ProtoFluxStringTable other)
		{
			MapField<string, string> mapField = (strings_ = (MapField<string, string>)(object)((MapField<TKey, TValue>)(object)other.strings_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F270", Offset = "0x2D9DC70", VA = "0x182D9F270", Slot = "10")]
		[DebuggerNonUserCode]
		public ProtoFluxStringTable Clone()
		{
			//Discarded unreachable code: IL_003b
			ProtoFluxStringTable protoFluxStringTable = new ProtoFluxStringTable();
			MapField<string, string> mapField = (protoFluxStringTable.strings_ = (MapField<string, string>)(object)new MapField<TKey, TValue>());
			MapField<string, string> mapField2 = (protoFluxStringTable.strings_ = (MapField<string, string>)(object)((MapField<TKey, TValue>)(object)strings_).Clone());
			UnknownFieldSet unknownFieldSet = (protoFluxStringTable._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return protoFluxStringTable;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F430", Offset = "0x2D9DE30", VA = "0x182D9F430", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				MapField<string, string> mapField = strings_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F3A0", Offset = "0x2D9DDA0", VA = "0x182D9F3A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProtoFluxStringTable other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, string> mapField = strings_;
				MapField<string, string> mapField2 = other.strings_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((MapField<TKey, TValue>)(object)strings_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F760", Offset = "0x2D9E160", VA = "0x182D9F760", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F7C0", Offset = "0x2D9E1C0", VA = "0x182D9F7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			MapField<string, string> mapField = strings_;
			MapField<string, string>.Codec map_strings_codec = _map_strings_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_strings_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F160", Offset = "0x2D9DB60", VA = "0x182D9F160", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			MapField<string, string> mapField = strings_;
			MapField<string, string>.Codec map_strings_codec = _map_strings_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_strings_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F680", Offset = "0x2D9E080", VA = "0x182D9F680", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProtoFluxStringTable other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				MapField<string, string> mapField = strings_;
				MapField<string, string> mapField2 = other.strings_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F590", Offset = "0x2D9DF90", VA = "0x182D9F590", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<string, string> mapField = strings_;
					MapField<string, string>.Codec map_strings_codec = _map_strings_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_strings_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F510", Offset = "0x2D9DF10", VA = "0x182D9F510", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<string, string> mapField = strings_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F700", Offset = "0x2D9E100", VA = "0x182D9F700", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F210", Offset = "0x2D9DC10", VA = "0x182D9F210", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				MapField<string, string> mapField = strings_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F880", Offset = "0x2D9E280", VA = "0x182D9F880")]
		static ProtoFluxStringTable()
		{
			Func<ProtoFluxStringTable> func = default(Func<ProtoFluxStringTable>);
			_parser = (MessageParser<ProtoFluxStringTable>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			FieldCodec<string> fieldCodec2 = (FieldCodec<string>)(object)FieldCodec.ForString(18u);
			uint num = default(uint);
			_parser = (MessageParser<ProtoFluxStringTable>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			/*Error: Unexpected end of block*/;
		}
	}
}
