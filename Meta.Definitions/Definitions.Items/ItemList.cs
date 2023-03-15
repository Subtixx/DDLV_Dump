using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000295")]
	public sealed class ItemList : IMessage<ItemList>, IMessage, IEquatable<ItemList>, IDeepCloneable<ItemList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000A48")]
		private static readonly MessageParser<ItemList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000A49")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000A4A")]
		public const int CurrentFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000A4B")]
		private static readonly MapField<string, int>.Codec _map_current_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A4C")]
		private readonly MapField<string, int> current_ = (MapField<string, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4000A4D")]
		public const int IdsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000A4E")]
		private static readonly MapField<int, ItemListDefinition>.Codec _map_ids_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A4F")]
		private readonly MapField<int, ItemListDefinition> ids_ = (MapField<int, ItemListDefinition>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000569")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60019B7")]
			[Cpp2IlInjected.Address(RVA = "0x25E12F0", Offset = "0x25DFCF0", VA = "0x1825E12F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60019B8")]
			[Cpp2IlInjected.Address(RVA = "0x25E1220", Offset = "0x25DFC20", VA = "0x1825E1220")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60019B9")]
			[Cpp2IlInjected.Address(RVA = "0x25E1350", Offset = "0x25DFD50", VA = "0x1825E1350", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056C")]
		[DebuggerNonUserCode]
		public MapField<string, int> Current
		{
			[Cpp2IlInjected.Token(Token = "0x60019BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return current_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056D")]
		[DebuggerNonUserCode]
		public MapField<int, ItemListDefinition> Ids
		{
			[Cpp2IlInjected.Token(Token = "0x60019BE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return ids_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019BA")]
		[Cpp2IlInjected.Address(RVA = "0x25E1160", Offset = "0x25DFB60", VA = "0x1825E1160")]
		[DebuggerNonUserCode]
		public ItemList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60019BB")]
		[Cpp2IlInjected.Address(RVA = "0x25E0FE0", Offset = "0x25DF9E0", VA = "0x1825E0FE0")]
		[DebuggerNonUserCode]
		public ItemList(ItemList other)
		{
			MapField<string, int> mapField = (current_ = (MapField<string, int>)(object)((MapField<TKey, TValue>)(object)other.current_).Clone());
			MapField<int, ItemListDefinition> mapField2 = (ids_ = (MapField<int, ItemListDefinition>)(object)((MapField<TKey, TValue>)(object)other.ids_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019BC")]
		[Cpp2IlInjected.Address(RVA = "0x25E0530", Offset = "0x25DEF30", VA = "0x1825E0530", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemList Clone()
		{
			//Discarded unreachable code: IL_005f
			ItemList itemList = new ItemList();
			MapField<string, int> mapField = (itemList.current_ = (MapField<string, int>)(object)new MapField<TKey, TValue>());
			MapField<int, ItemListDefinition> mapField2 = (itemList.ids_ = (MapField<int, ItemListDefinition>)(object)new MapField<TKey, TValue>());
			MapField<string, int> mapField3 = (itemList.current_ = (MapField<string, int>)(object)((MapField<TKey, TValue>)(object)current_).Clone());
			MapField<int, ItemListDefinition> mapField4 = (itemList.ids_ = (MapField<int, ItemListDefinition>)(object)((MapField<TKey, TValue>)(object)ids_).Clone());
			UnknownFieldSet unknownFieldSet = (itemList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemList;
		}

		[Cpp2IlInjected.Token(Token = "0x60019BF")]
		[Cpp2IlInjected.Address(RVA = "0x25E07A0", Offset = "0x25DF1A0", VA = "0x1825E07A0", Slot = "0")]
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
				MapField<string, int> mapField = current_;
				bool flag = default(bool);
				if (flag)
				{
					MapField<int, ItemListDefinition> mapField2 = ids_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019C0")]
		[Cpp2IlInjected.Address(RVA = "0x25E06E0", Offset = "0x25DF0E0", VA = "0x1825E06E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, int> mapField = current_;
				MapField<string, int> mapField2 = other.current_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					MapField<int, ItemListDefinition> mapField3 = ids_;
					MapField<int, ItemListDefinition> mapField4 = other.ids_;
					if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019C1")]
		[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			int hashCode = ((MapField<TKey, TValue>)(object)current_).GetHashCode();
			int hashCode2 = ((MapField<TKey, TValue>)(object)ids_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x60019C2")]
		[Cpp2IlInjected.Address(RVA = "0x25E0BE0", Offset = "0x25DF5E0", VA = "0x1825E0BE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60019C3")]
		[Cpp2IlInjected.Address(RVA = "0x25E0C40", Offset = "0x25DF640", VA = "0x1825E0C40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			MapField<string, int> mapField = current_;
			MapField<string, int>.Codec map_current_codec = _map_current_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_current_codec);
			MapField<int, ItemListDefinition> mapField2 = ids_;
			MapField<int, ItemListDefinition>.Codec map_ids_codec = _map_ids_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_ids_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60019C4")]
		[Cpp2IlInjected.Address(RVA = "0x25E03D0", Offset = "0x25DEDD0", VA = "0x1825E03D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			MapField<string, int> mapField = current_;
			MapField<string, int>.Codec map_current_codec = _map_current_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_current_codec);
			MapField<int, ItemListDefinition> mapField2 = ids_;
			MapField<int, ItemListDefinition>.Codec map_ids_codec = _map_ids_codec;
			int num2 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_ids_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				mapField = (MapField<string, int>)(mapField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019C5")]
		[Cpp2IlInjected.Address(RVA = "0x25E0A90", Offset = "0x25DF490", VA = "0x1825E0A90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemList other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				MapField<string, int> mapField = current_;
				MapField<string, int> mapField2 = other.current_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				MapField<int, ItemListDefinition> mapField3 = ids_;
				MapField<int, ItemListDefinition> mapField4 = other.ids_;
				((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019C6")]
		[Cpp2IlInjected.Address(RVA = "0x25E0930", Offset = "0x25DF330", VA = "0x1825E0930", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005b
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<string, int> mapField = current_;
					MapField<string, int>.Codec map_current_codec = _map_current_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_current_codec);
				}
				if (num == 18)
				{
					MapField<int, ItemListDefinition> mapField2 = ids_;
					MapField<int, ItemListDefinition>.Codec map_ids_codec = _map_ids_codec;
					((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_ids_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019C7")]
		[Cpp2IlInjected.Address(RVA = "0x25E08A0", Offset = "0x25DF2A0", VA = "0x1825E08A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<string, int> mapField = current_;
			}
			if (fieldNumber == 2)
			{
				MapField<int, ItemListDefinition> mapField2 = ids_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60019C8")]
		[Cpp2IlInjected.Address(RVA = "0x25E0B30", Offset = "0x25DF530", VA = "0x1825E0B30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			switch (fieldNumber)
			{
			default:
				return;
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			case 2:
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60019C9")]
		[Cpp2IlInjected.Address(RVA = "0x25E04C0", Offset = "0x25DEEC0", VA = "0x1825E04C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				MapField<int, ItemListDefinition> mapField = ids_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019CA")]
		[Cpp2IlInjected.Address(RVA = "0x25E0D30", Offset = "0x25DF730", VA = "0x1825E0D30")]
		static ItemList()
		{
			Func<ItemList> func = default(Func<ItemList>);
			_parser = (MessageParser<ItemList>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num = default(uint);
			_parser = (MessageParser<ItemList>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			FieldCodec<int> fieldCodec3 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<ItemListDefinition> parser = ItemListDefinition._parser;
			uint num2 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<ItemListDefinition>(num2, (MessageParser<>)(object)parser);
			uint num3 = default(uint);
			_parser = (MessageParser<ItemList>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num3);
			/*Error: Unexpected end of block*/;
		}
	}
}
