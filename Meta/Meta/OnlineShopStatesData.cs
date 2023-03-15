using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008E9")]
	public sealed class OnlineShopStatesData : IMessage<OnlineShopStatesData>, IMessage, IEquatable<OnlineShopStatesData>, IDeepCloneable<OnlineShopStatesData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002416")]
		private static readonly MessageParser<OnlineShopStatesData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002417")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002418")]
		public const int BundlesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002419")]
		private static readonly MapField<string, OnlineShopContentStatus>.Codec _map_bundles_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400241A")]
		private readonly MapField<string, OnlineShopContentStatus> bundles_ = (MapField<string, OnlineShopContentStatus>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x400241B")]
		public const int StoresFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400241C")]
		private static readonly MapField<string, OnlineShopContentStatus>.Codec _map_stores_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400241D")]
		private readonly MapField<string, OnlineShopContentStatus> stores_ = (MapField<string, OnlineShopContentStatus>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000D1A")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineShopStatesData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D16")]
			[Cpp2IlInjected.Address(RVA = "0x13ABAF0", Offset = "0x13AA4F0", VA = "0x1813ABAF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D17")]
			[Cpp2IlInjected.Address(RVA = "0x13ABA20", Offset = "0x13AA420", VA = "0x1813ABA20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D18")]
			[Cpp2IlInjected.Address(RVA = "0x13ABB50", Offset = "0x13AA550", VA = "0x1813ABB50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1D")]
		[DebuggerNonUserCode]
		public MapField<string, OnlineShopContentStatus> Bundles
		{
			[Cpp2IlInjected.Token(Token = "0x6004D1C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return bundles_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D1E")]
		[DebuggerNonUserCode]
		public MapField<string, OnlineShopContentStatus> Stores
		{
			[Cpp2IlInjected.Token(Token = "0x6004D1D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return stores_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D19")]
		[Cpp2IlInjected.Address(RVA = "0x13AB810", Offset = "0x13AA210", VA = "0x1813AB810")]
		[DebuggerNonUserCode]
		public OnlineShopStatesData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1A")]
		[Cpp2IlInjected.Address(RVA = "0x13AB8C0", Offset = "0x13AA2C0", VA = "0x1813AB8C0")]
		[DebuggerNonUserCode]
		public OnlineShopStatesData(OnlineShopStatesData other)
		{
			MapField<string, OnlineShopContentStatus> mapField = (bundles_ = (MapField<string, OnlineShopContentStatus>)(object)((MapField<TKey, TValue>)(object)other.bundles_).Clone());
			MapField<string, OnlineShopContentStatus> mapField2 = (stores_ = (MapField<string, OnlineShopContentStatus>)(object)((MapField<TKey, TValue>)(object)other.stores_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1B")]
		[Cpp2IlInjected.Address(RVA = "0x13AACE0", Offset = "0x13A96E0", VA = "0x1813AACE0", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineShopStatesData Clone()
		{
			//Discarded unreachable code: IL_005f
			OnlineShopStatesData onlineShopStatesData = new OnlineShopStatesData();
			MapField<string, OnlineShopContentStatus> mapField = (onlineShopStatesData.bundles_ = (MapField<string, OnlineShopContentStatus>)(object)new MapField<TKey, TValue>());
			MapField<string, OnlineShopContentStatus> mapField2 = (onlineShopStatesData.stores_ = (MapField<string, OnlineShopContentStatus>)(object)new MapField<TKey, TValue>());
			MapField<string, OnlineShopContentStatus> mapField3 = (onlineShopStatesData.bundles_ = (MapField<string, OnlineShopContentStatus>)(object)((MapField<TKey, TValue>)(object)bundles_).Clone());
			MapField<string, OnlineShopContentStatus> mapField4 = (onlineShopStatesData.stores_ = (MapField<string, OnlineShopContentStatus>)(object)((MapField<TKey, TValue>)(object)stores_).Clone());
			UnknownFieldSet unknownFieldSet = (onlineShopStatesData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return onlineShopStatesData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D1E")]
		[Cpp2IlInjected.Address(RVA = "0x13AAF20", Offset = "0x13A9920", VA = "0x1813AAF20", Slot = "0")]
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
				MapField<string, OnlineShopContentStatus> mapField = bundles_;
				bool flag = default(bool);
				if (flag)
				{
					MapField<string, OnlineShopContentStatus> mapField2 = stores_;
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

		[Cpp2IlInjected.Token(Token = "0x6004D1F")]
		[Cpp2IlInjected.Address(RVA = "0x13AAE70", Offset = "0x13A9870", VA = "0x1813AAE70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineShopStatesData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, OnlineShopContentStatus> mapField = bundles_;
				MapField<string, OnlineShopContentStatus> mapField2 = other.bundles_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					MapField<string, OnlineShopContentStatus> mapField3 = stores_;
					MapField<string, OnlineShopContentStatus> mapField4 = other.stores_;
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

		[Cpp2IlInjected.Token(Token = "0x6004D20")]
		[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			int hashCode = ((MapField<TKey, TValue>)(object)bundles_).GetHashCode();
			int hashCode2 = ((MapField<TKey, TValue>)(object)stores_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D21")]
		[Cpp2IlInjected.Address(RVA = "0x13AB3D0", Offset = "0x13A9DD0", VA = "0x1813AB3D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D22")]
		[Cpp2IlInjected.Address(RVA = "0x13AB430", Offset = "0x13A9E30", VA = "0x1813AB430", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			MapField<string, OnlineShopContentStatus> mapField = bundles_;
			MapField<string, OnlineShopContentStatus>.Codec map_bundles_codec = _map_bundles_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_bundles_codec);
			MapField<string, OnlineShopContentStatus> mapField2 = stores_;
			MapField<string, OnlineShopContentStatus>.Codec map_stores_codec = _map_stores_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_stores_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D23")]
		[Cpp2IlInjected.Address(RVA = "0x13AAB90", Offset = "0x13A9590", VA = "0x1813AAB90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			MapField<string, OnlineShopContentStatus> mapField = bundles_;
			MapField<string, OnlineShopContentStatus>.Codec map_bundles_codec = _map_bundles_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_bundles_codec);
			MapField<string, OnlineShopContentStatus> mapField2 = stores_;
			MapField<string, OnlineShopContentStatus>.Codec map_stores_codec = _map_stores_codec;
			int num2 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_stores_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				mapField = (MapField<string, OnlineShopContentStatus>)(mapField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D24")]
		[Cpp2IlInjected.Address(RVA = "0x13AB280", Offset = "0x13A9C80", VA = "0x1813AB280", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineShopStatesData other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				MapField<string, OnlineShopContentStatus> mapField = bundles_;
				MapField<string, OnlineShopContentStatus> mapField2 = other.bundles_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				MapField<string, OnlineShopContentStatus> mapField3 = stores_;
				MapField<string, OnlineShopContentStatus> mapField4 = other.stores_;
				((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D25")]
		[Cpp2IlInjected.Address(RVA = "0x13AB130", Offset = "0x13A9B30", VA = "0x1813AB130", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005b
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<string, OnlineShopContentStatus> mapField = bundles_;
					MapField<string, OnlineShopContentStatus>.Codec map_bundles_codec = _map_bundles_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_bundles_codec);
				}
				if (num == 18)
				{
					MapField<string, OnlineShopContentStatus> mapField2 = stores_;
					MapField<string, OnlineShopContentStatus>.Codec map_stores_codec = _map_stores_codec;
					((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_stores_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D26")]
		[Cpp2IlInjected.Address(RVA = "0x13AB010", Offset = "0x13A9A10", VA = "0x1813AB010", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<string, OnlineShopContentStatus> mapField = bundles_;
			}
			if (fieldNumber == 2)
			{
				MapField<string, OnlineShopContentStatus> mapField2 = stores_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D27")]
		[Cpp2IlInjected.Address(RVA = "0x13AB320", Offset = "0x13A9D20", VA = "0x1813AB320", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004D28")]
		[Cpp2IlInjected.Address(RVA = "0x13AAC70", Offset = "0x13A9670", VA = "0x1813AAC70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				MapField<string, OnlineShopContentStatus> mapField = stores_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D29")]
		[Cpp2IlInjected.Address(RVA = "0x13AB520", Offset = "0x13A9F20", VA = "0x1813AB520")]
		static OnlineShopStatesData()
		{
			Func<OnlineShopStatesData> func = default(Func<OnlineShopStatesData>);
			_parser = (MessageParser<OnlineShopStatesData>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<OnlineShopContentStatus> parser = OnlineShopContentStatus._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<OnlineShopContentStatus>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<OnlineShopStatesData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			FieldCodec<string> fieldCodec3 = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<OnlineShopContentStatus> parser2 = OnlineShopContentStatus._parser;
			uint num3 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<OnlineShopContentStatus>(num3, (MessageParser<>)(object)parser2);
			uint num4 = default(uint);
			_parser = (MessageParser<OnlineShopStatesData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num4);
			/*Error: Unexpected end of block*/;
		}
	}
}
