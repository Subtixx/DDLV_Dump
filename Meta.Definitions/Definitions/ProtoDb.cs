using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class ProtoDb : IMessage<ProtoDb>, IMessage, IEquatable<ProtoDb>, IDeepCloneable<ProtoDb>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly MessageParser<ProtoDb> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public const int EntriesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private static readonly MapField<string, ProtoEntry>.Codec _map_entries_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly MapField<string, ProtoEntry> entries_ = (MapField<string, ProtoEntry>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		public static MessageParser<ProtoDb> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2D9C070", Offset = "0x2D9AA70", VA = "0x182D9C070")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x2D9BFA0", Offset = "0x2D9A9A0", VA = "0x182D9BFA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2D9C0D0", Offset = "0x2D9AAD0", VA = "0x182D9C0D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[DebuggerNonUserCode]
		public MapField<string, ProtoEntry> Entries
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return entries_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BE20", Offset = "0x2D9A820", VA = "0x182D9BE20")]
		[DebuggerNonUserCode]
		public ProtoDb()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BEA0", Offset = "0x2D9A8A0", VA = "0x182D9BEA0")]
		[DebuggerNonUserCode]
		public ProtoDb(ProtoDb other)
		{
			MapField<string, ProtoEntry> mapField = (entries_ = (MapField<string, ProtoEntry>)(object)((MapField<TKey, TValue>)(object)other.entries_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B5E0", Offset = "0x2D99FE0", VA = "0x182D9B5E0", Slot = "10")]
		[DebuggerNonUserCode]
		public ProtoDb Clone()
		{
			//Discarded unreachable code: IL_003b
			ProtoDb protoDb = new ProtoDb();
			MapField<string, ProtoEntry> mapField = (protoDb.entries_ = (MapField<string, ProtoEntry>)(object)new MapField<TKey, TValue>());
			MapField<string, ProtoEntry> mapField2 = (protoDb.entries_ = (MapField<string, ProtoEntry>)(object)((MapField<TKey, TValue>)(object)entries_).Clone());
			UnknownFieldSet unknownFieldSet = (protoDb._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return protoDb;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B710", Offset = "0x2D9A110", VA = "0x182D9B710", Slot = "0")]
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
				MapField<string, ProtoEntry> mapField = entries_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B7F0", Offset = "0x2D9A1F0", VA = "0x182D9B7F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProtoDb other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, ProtoEntry> mapField = entries_;
				MapField<string, ProtoEntry> mapField2 = other.entries_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((MapField<TKey, TValue>)(object)entries_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BAD0", Offset = "0x2D9A4D0", VA = "0x182D9BAD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BB30", Offset = "0x2D9A530", VA = "0x182D9BB30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			MapField<string, ProtoEntry> mapField = entries_;
			MapField<string, ProtoEntry>.Codec map_entries_codec = _map_entries_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_entries_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B4D0", Offset = "0x2D99ED0", VA = "0x182D9B4D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			MapField<string, ProtoEntry> mapField = entries_;
			MapField<string, ProtoEntry>.Codec map_entries_codec = _map_entries_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_entries_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B9F0", Offset = "0x2D9A3F0", VA = "0x182D9B9F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProtoDb other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				MapField<string, ProtoEntry> mapField = entries_;
				MapField<string, ProtoEntry> mapField2 = other.entries_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B900", Offset = "0x2D9A300", VA = "0x182D9B900", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<string, ProtoEntry> mapField = entries_;
					MapField<string, ProtoEntry>.Codec map_entries_codec = _map_entries_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_entries_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B880", Offset = "0x2D9A280", VA = "0x182D9B880", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<string, ProtoEntry> mapField = entries_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BA70", Offset = "0x2D9A470", VA = "0x182D9BA70", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B580", Offset = "0x2D99F80", VA = "0x182D9B580", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				MapField<string, ProtoEntry> mapField = entries_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BBF0", Offset = "0x2D9A5F0", VA = "0x182D9BBF0")]
		static ProtoDb()
		{
			Func<ProtoDb> func = default(Func<ProtoDb>);
			_parser = (MessageParser<ProtoDb>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<ProtoEntry> parser = ProtoEntry._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<ProtoEntry>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<ProtoDb>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
