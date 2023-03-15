using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B49")]
	public sealed class OnlineProfile : IMessage<OnlineProfile>, IMessage, IEquatable<OnlineProfile>, IDeepCloneable<OnlineProfile>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002BCD")]
		private static readonly MessageParser<OnlineProfile> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BCE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002BCF")]
		public const int StatisticsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002BD0")]
		private static readonly MapField<string, Statistic>.Codec _map_statistics_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BD1")]
		private readonly MapField<string, Statistic> statistics_ = (MapField<string, Statistic>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4002BD2")]
		public const int ItemsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002BD3")]
		private static readonly MapField<int, Amount>.Codec _map_items_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002BD4")]
		private readonly MapField<int, Amount> items_ = (MapField<int, Amount>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4002BD5")]
		public const int CurrenciesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4002BD6")]
		private static readonly MapField<int, Amount>.Codec _map_currencies_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002BD7")]
		private readonly MapField<int, Amount> currencies_ = (MapField<int, Amount>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x1700105C")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineProfile> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005F8A")]
			[Cpp2IlInjected.Address(RVA = "0x13AA1C0", Offset = "0x13A8BC0", VA = "0x1813AA1C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F8B")]
			[Cpp2IlInjected.Address(RVA = "0x13AA0F0", Offset = "0x13A8AF0", VA = "0x1813AA0F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F8C")]
			[Cpp2IlInjected.Address(RVA = "0x13AA220", Offset = "0x13A8C20", VA = "0x1813AA220", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105F")]
		[DebuggerNonUserCode]
		public MapField<string, Statistic> Statistics
		{
			[Cpp2IlInjected.Token(Token = "0x6005F90")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return statistics_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001060")]
		[DebuggerNonUserCode]
		public MapField<int, Amount> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6005F91")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return items_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001061")]
		[DebuggerNonUserCode]
		public MapField<int, Amount> Currencies
		{
			[Cpp2IlInjected.Token(Token = "0x6005F92")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return currencies_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8D")]
		[Cpp2IlInjected.Address(RVA = "0x13A9E30", Offset = "0x13A8830", VA = "0x1813A9E30")]
		[DebuggerNonUserCode]
		public OnlineProfile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8E")]
		[Cpp2IlInjected.Address(RVA = "0x13A9F20", Offset = "0x13A8920", VA = "0x1813A9F20")]
		[DebuggerNonUserCode]
		public OnlineProfile(OnlineProfile other)
		{
			MapField<string, Statistic> mapField = (statistics_ = (MapField<string, Statistic>)(object)((MapField<TKey, TValue>)(object)other.statistics_).Clone());
			MapField<int, Amount> mapField2 = (items_ = (MapField<int, Amount>)(object)((MapField<TKey, TValue>)(object)other.items_).Clone());
			MapField<int, Amount> mapField3 = (currencies_ = (MapField<int, Amount>)(object)((MapField<TKey, TValue>)(object)other.currencies_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F8F")]
		[Cpp2IlInjected.Address(RVA = "0x13A9190", Offset = "0x13A7B90", VA = "0x1813A9190", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineProfile Clone()
		{
			return new OnlineProfile(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F93")]
		[Cpp2IlInjected.Address(RVA = "0x13A91F0", Offset = "0x13A7BF0", VA = "0x1813A91F0", Slot = "0")]
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
				MapField<string, Statistic> mapField = statistics_;
				bool flag = default(bool);
				if (flag)
				{
					MapField<int, Amount> mapField2 = items_;
					bool flag2 = default(bool);
					if (flag2)
					{
						MapField<int, Amount> mapField3 = currencies_;
						bool flag3 = default(bool);
						if (flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F94")]
		[Cpp2IlInjected.Address(RVA = "0x13A9310", Offset = "0x13A7D10", VA = "0x1813A9310", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineProfile other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, Statistic> mapField = statistics_;
				MapField<string, Statistic> mapField2 = other.statistics_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					MapField<int, Amount> mapField3 = items_;
					MapField<int, Amount> mapField4 = other.items_;
					if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
					{
						MapField<int, Amount> mapField5 = currencies_;
						MapField<int, Amount> mapField6 = other.currencies_;
						if (((MapField<TKey, TValue>)(object)mapField5).Equals((MapField<, >)(object)mapField6))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F95")]
		[Cpp2IlInjected.Address(RVA = "0x13A9490", Offset = "0x13A7E90", VA = "0x1813A9490", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_003d
			int hashCode = ((MapField<TKey, TValue>)(object)statistics_).GetHashCode();
			int hashCode2 = ((MapField<TKey, TValue>)(object)items_).GetHashCode();
			int hashCode3 = ((MapField<TKey, TValue>)(object)currencies_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			hashCode = hashCode3;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F96")]
		[Cpp2IlInjected.Address(RVA = "0x13A98B0", Offset = "0x13A82B0", VA = "0x1813A98B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F97")]
		[Cpp2IlInjected.Address(RVA = "0x13A9910", Offset = "0x13A8310", VA = "0x1813A9910", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			MapField<string, Statistic> mapField = statistics_;
			MapField<string, Statistic>.Codec map_statistics_codec = _map_statistics_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_statistics_codec);
			MapField<int, Amount> mapField2 = items_;
			MapField<int, Amount>.Codec map_items_codec = _map_items_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_items_codec);
			MapField<int, Amount> mapField3 = currencies_;
			MapField<int, Amount>.Codec map_currencies_codec = _map_currencies_codec;
			((MapField<TKey, TValue>)(object)mapField3).WriteTo(output, (MapField<, >.Codec)(object)map_currencies_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F98")]
		[Cpp2IlInjected.Address(RVA = "0x13A8FF0", Offset = "0x13A79F0", VA = "0x1813A8FF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0068
			MapField<string, Statistic> mapField = statistics_;
			MapField<string, Statistic>.Codec map_statistics_codec = _map_statistics_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_statistics_codec);
			MapField<int, Amount> mapField2 = items_;
			MapField<int, Amount>.Codec map_items_codec = _map_items_codec;
			int num2 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_items_codec);
			MapField<int, Amount> mapField3 = currencies_;
			MapField<int, Amount>.Codec map_currencies_codec = _map_currencies_codec;
			int num3 = ((MapField<TKey, TValue>)(object)mapField3).CalculateSize((MapField<, >.Codec)(object)map_currencies_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F99")]
		[Cpp2IlInjected.Address(RVA = "0x13A96F0", Offset = "0x13A80F0", VA = "0x1813A96F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineProfile other)
		{
			//Discarded unreachable code: IL_0067
			if (other != null)
			{
				MapField<string, Statistic> mapField = statistics_;
				MapField<string, Statistic> mapField2 = other.statistics_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				MapField<int, Amount> mapField3 = items_;
				MapField<int, Amount> mapField4 = other.items_;
				((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
				MapField<int, Amount> mapField5 = currencies_;
				MapField<int, Amount> mapField6 = other.currencies_;
				((MapField<TKey, TValue>)(object)mapField5).Add((IDictionary<, >)(object)mapField6);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F9A")]
		[Cpp2IlInjected.Address(RVA = "0x13A9530", Offset = "0x13A7F30", VA = "0x1813A9530", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_007a
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<string, Statistic> mapField = statistics_;
					MapField<string, Statistic>.Codec map_statistics_codec = _map_statistics_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_statistics_codec);
				}
				if (num == 18)
				{
					MapField<int, Amount> mapField2 = items_;
					MapField<int, Amount>.Codec map_items_codec = _map_items_codec;
					((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_items_codec);
				}
				if (num == 26)
				{
					MapField<int, Amount> mapField3 = currencies_;
					MapField<int, Amount>.Codec map_currencies_codec = _map_currencies_codec;
					((MapField<TKey, TValue>)(object)mapField3).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_currencies_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F9B")]
		[Cpp2IlInjected.Address(RVA = "0x13A93F0", Offset = "0x13A7DF0", VA = "0x1813A93F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<int, Amount> mapField = currencies_;
				MapField<int, Amount> mapField2 = items_;
				MapField<string, Statistic> mapField3 = statistics_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F9C")]
		[Cpp2IlInjected.Address(RVA = "0x13A97B0", Offset = "0x13A81B0", VA = "0x1813A97B0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6005F9D")]
		[Cpp2IlInjected.Address(RVA = "0x13A9110", Offset = "0x13A7B10", VA = "0x1813A9110", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0018
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				MapField<string, Statistic> mapField = statistics_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F9E")]
		[Cpp2IlInjected.Address(RVA = "0x13A9A30", Offset = "0x13A8430", VA = "0x1813A9A30")]
		static OnlineProfile()
		{
			Func<OnlineProfile> func = default(Func<OnlineProfile>);
			_parser = (MessageParser<OnlineProfile>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<Statistic> parser = Statistic._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<Statistic>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<OnlineProfile>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			FieldCodec<int> fieldCodec3 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<Amount> parser2 = Amount._parser;
			uint num3 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<Amount>(num3, (MessageParser<>)(object)parser2);
			uint num4 = default(uint);
			_parser = (MessageParser<OnlineProfile>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num4);
			FieldCodec<int> fieldCodec5 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<Amount> parser3 = Amount._parser;
			uint num5 = default(uint);
			FieldCodec<> fieldCodec6 = FieldCodec.ForMessage<Amount>(num5, (MessageParser<>)(object)parser3);
			uint num6 = default(uint);
			_parser = (MessageParser<OnlineProfile>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec5, fieldCodec6, num6);
			/*Error: Unexpected end of block*/;
		}
	}
}
