using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x2000725")]
	public sealed class GachaDatabase : IMessage<GachaDatabase>, IMessage, IEquatable<GachaDatabase>, IDeepCloneable<GachaDatabase>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023E1")]
		private static readonly MessageParser<GachaDatabase> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023E2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023E3")]
		public const int GachasFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023E4")]
		private static readonly FieldCodec<Gacha> _repeated_gachas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023E5")]
		private readonly RepeatedField<Gacha> gachas_ = (RepeatedField<Gacha>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001437")]
		[DebuggerNonUserCode]
		public static MessageParser<GachaDatabase> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F42")]
			[Cpp2IlInjected.Address(RVA = "0x2189300", Offset = "0x2187D00", VA = "0x182189300")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001438")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F43")]
			[Cpp2IlInjected.Address(RVA = "0x2189230", Offset = "0x2187C30", VA = "0x182189230")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001439")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F44")]
			[Cpp2IlInjected.Address(RVA = "0x2189360", Offset = "0x2187D60", VA = "0x182189360", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143A")]
		[DebuggerNonUserCode]
		public RepeatedField<Gacha> Gachas
		{
			[Cpp2IlInjected.Token(Token = "0x6004F48")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gachas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F45")]
		[Cpp2IlInjected.Address(RVA = "0x21890B0", Offset = "0x2187AB0", VA = "0x1821890B0")]
		[DebuggerNonUserCode]
		public GachaDatabase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F46")]
		[Cpp2IlInjected.Address(RVA = "0x2189130", Offset = "0x2187B30", VA = "0x182189130")]
		[DebuggerNonUserCode]
		public GachaDatabase(GachaDatabase other)
		{
			RepeatedField<Gacha> repeatedField = (gachas_ = (RepeatedField<Gacha>)(object)((RepeatedField<T>)(object)other.gachas_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F47")]
		[Cpp2IlInjected.Address(RVA = "0x21888D0", Offset = "0x21872D0", VA = "0x1821888D0", Slot = "10")]
		[DebuggerNonUserCode]
		public GachaDatabase Clone()
		{
			//Discarded unreachable code: IL_003b
			GachaDatabase gachaDatabase = new GachaDatabase();
			RepeatedField<Gacha> repeatedField = (gachaDatabase.gachas_ = (RepeatedField<Gacha>)(object)new RepeatedField<T>());
			RepeatedField<Gacha> repeatedField2 = (gachaDatabase.gachas_ = (RepeatedField<Gacha>)(object)((RepeatedField<T>)(object)gachas_).Clone());
			UnknownFieldSet unknownFieldSet = (gachaDatabase._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gachaDatabase;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F49")]
		[Cpp2IlInjected.Address(RVA = "0x2188A90", Offset = "0x2187490", VA = "0x182188A90", Slot = "0")]
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
				RepeatedField<Gacha> repeatedField = gachas_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4A")]
		[Cpp2IlInjected.Address(RVA = "0x2188A00", Offset = "0x2187400", VA = "0x182188A00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GachaDatabase other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Gacha> repeatedField = gachas_;
				RepeatedField<Gacha> repeatedField2 = other.gachas_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)gachas_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4C")]
		[Cpp2IlInjected.Address(RVA = "0x2188DC0", Offset = "0x21877C0", VA = "0x182188DC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4D")]
		[Cpp2IlInjected.Address(RVA = "0x2188E20", Offset = "0x2187820", VA = "0x182188E20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Gacha> repeatedField = gachas_;
			FieldCodec<Gacha> repeated_gachas_codec = _repeated_gachas_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_gachas_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4E")]
		[Cpp2IlInjected.Address(RVA = "0x21887C0", Offset = "0x21871C0", VA = "0x1821887C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Gacha> repeatedField = gachas_;
			FieldCodec<Gacha> repeated_gachas_codec = _repeated_gachas_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_gachas_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4F")]
		[Cpp2IlInjected.Address(RVA = "0x2188BF0", Offset = "0x21875F0", VA = "0x182188BF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GachaDatabase other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Gacha> repeatedField = gachas_;
				RepeatedField<Gacha> repeatedField2 = other.gachas_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F50")]
		[Cpp2IlInjected.Address(RVA = "0x2188C70", Offset = "0x2187670", VA = "0x182188C70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Gacha> repeatedField = gachas_;
					FieldCodec<Gacha> repeated_gachas_codec = _repeated_gachas_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gachas_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F51")]
		[Cpp2IlInjected.Address(RVA = "0x2188B70", Offset = "0x2187570", VA = "0x182188B70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Gacha> repeatedField = gachas_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F52")]
		[Cpp2IlInjected.Address(RVA = "0x2188D60", Offset = "0x2187760", VA = "0x182188D60", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004F53")]
		[Cpp2IlInjected.Address(RVA = "0x2188870", Offset = "0x2187270", VA = "0x182188870", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Gacha> repeatedField = gachas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F54")]
		[Cpp2IlInjected.Address(RVA = "0x2188EE0", Offset = "0x21878E0", VA = "0x182188EE0")]
		static GachaDatabase()
		{
			Func<GachaDatabase> func = default(Func<GachaDatabase>);
			_parser = (MessageParser<GachaDatabase>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Gacha> parser = Gacha._parser;
			uint num = default(uint);
			_parser = (MessageParser<GachaDatabase>)(object)FieldCodec.ForMessage<Gacha>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
