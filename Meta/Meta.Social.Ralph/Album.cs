using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DE0")]
	public sealed class Album : IMessage<Album>, IMessage, IEquatable<Album>, IDeepCloneable<Album>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400382F")]
		private static readonly MessageParser<Album> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003830")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003831")]
		public const int EntriesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4003832")]
		private static readonly MapField<int, AlbumPicture>.Codec _map_entries_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003833")]
		private readonly MapField<int, AlbumPicture> entries_ = (MapField<int, AlbumPicture>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17001405")]
		[DebuggerNonUserCode]
		public static MessageParser<Album> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60073C1")]
			[Cpp2IlInjected.Address(RVA = "0x18E9580", Offset = "0x18E7F80", VA = "0x1818E9580")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001406")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60073C2")]
			[Cpp2IlInjected.Address(RVA = "0x18E94B0", Offset = "0x18E7EB0", VA = "0x1818E94B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001407")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60073C3")]
			[Cpp2IlInjected.Address(RVA = "0x18E95E0", Offset = "0x18E7FE0", VA = "0x1818E95E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001408")]
		[DebuggerNonUserCode]
		public MapField<int, AlbumPicture> Entries
		{
			[Cpp2IlInjected.Token(Token = "0x60073C7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return entries_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073C4")]
		[Cpp2IlInjected.Address(RVA = "0x18E9430", Offset = "0x18E7E30", VA = "0x1818E9430")]
		[DebuggerNonUserCode]
		public Album()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60073C5")]
		[Cpp2IlInjected.Address(RVA = "0x18E9330", Offset = "0x18E7D30", VA = "0x1818E9330")]
		[DebuggerNonUserCode]
		public Album(Album other)
		{
			MapField<int, AlbumPicture> mapField = (entries_ = (MapField<int, AlbumPicture>)(object)((MapField<TKey, TValue>)(object)other.entries_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60073C6")]
		[Cpp2IlInjected.Address(RVA = "0x18E8AF0", Offset = "0x18E74F0", VA = "0x1818E8AF0", Slot = "10")]
		[DebuggerNonUserCode]
		public Album Clone()
		{
			//Discarded unreachable code: IL_003b
			Album album = new Album();
			MapField<int, AlbumPicture> mapField = (album.entries_ = (MapField<int, AlbumPicture>)(object)new MapField<TKey, TValue>());
			MapField<int, AlbumPicture> mapField2 = (album.entries_ = (MapField<int, AlbumPicture>)(object)((MapField<TKey, TValue>)(object)entries_).Clone());
			UnknownFieldSet unknownFieldSet = (album._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return album;
		}

		[Cpp2IlInjected.Token(Token = "0x60073C8")]
		[Cpp2IlInjected.Address(RVA = "0x18E8CB0", Offset = "0x18E76B0", VA = "0x1818E8CB0", Slot = "0")]
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
				MapField<int, AlbumPicture> mapField = entries_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60073C9")]
		[Cpp2IlInjected.Address(RVA = "0x18E8C20", Offset = "0x18E7620", VA = "0x1818E8C20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Album other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<int, AlbumPicture> mapField = entries_;
				MapField<int, AlbumPicture> mapField2 = other.entries_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60073CA")]
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

		[Cpp2IlInjected.Token(Token = "0x60073CB")]
		[Cpp2IlInjected.Address(RVA = "0x18E8FE0", Offset = "0x18E79E0", VA = "0x1818E8FE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60073CC")]
		[Cpp2IlInjected.Address(RVA = "0x18E9040", Offset = "0x18E7A40", VA = "0x1818E9040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			MapField<int, AlbumPicture> mapField = entries_;
			MapField<int, AlbumPicture>.Codec map_entries_codec = _map_entries_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_entries_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60073CD")]
		[Cpp2IlInjected.Address(RVA = "0x18E89E0", Offset = "0x18E73E0", VA = "0x1818E89E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			MapField<int, AlbumPicture> mapField = entries_;
			MapField<int, AlbumPicture>.Codec map_entries_codec = _map_entries_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_entries_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60073CE")]
		[Cpp2IlInjected.Address(RVA = "0x18E8E10", Offset = "0x18E7810", VA = "0x1818E8E10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Album other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				MapField<int, AlbumPicture> mapField = entries_;
				MapField<int, AlbumPicture> mapField2 = other.entries_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073CF")]
		[Cpp2IlInjected.Address(RVA = "0x18E8E90", Offset = "0x18E7890", VA = "0x1818E8E90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<int, AlbumPicture> mapField = entries_;
					MapField<int, AlbumPicture>.Codec map_entries_codec = _map_entries_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_entries_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073D0")]
		[Cpp2IlInjected.Address(RVA = "0x18E8D90", Offset = "0x18E7790", VA = "0x1818E8D90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<int, AlbumPicture> mapField = entries_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60073D1")]
		[Cpp2IlInjected.Address(RVA = "0x18E8F80", Offset = "0x18E7980", VA = "0x1818E8F80", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60073D2")]
		[Cpp2IlInjected.Address(RVA = "0x18E8A90", Offset = "0x18E7490", VA = "0x1818E8A90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				MapField<int, AlbumPicture> mapField = entries_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073D3")]
		[Cpp2IlInjected.Address(RVA = "0x18E9100", Offset = "0x18E7B00", VA = "0x1818E9100")]
		static Album()
		{
			Func<Album> func = default(Func<Album>);
			_parser = (MessageParser<Album>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<AlbumPicture> parser = AlbumPicture._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<AlbumPicture>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<Album>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
