using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008EF")]
	public sealed class TrackingData : IMessage<TrackingData>, IMessage, IEquatable<TrackingData>, IDeepCloneable<TrackingData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002430")]
		private static readonly MessageParser<TrackingData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002431")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002432")]
		public const int BackwardFoundersPackTrackedFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002433")]
		private bool backwardFoundersPackTracked_;

		[Cpp2IlInjected.Token(Token = "0x4002434")]
		public const int FoundersPackClaimedDatesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002435")]
		private static readonly MapField<string, FoundersPackClaimedDate>.Codec _map_foundersPackClaimedDates_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002436")]
		private readonly MapField<string, FoundersPackClaimedDate> foundersPackClaimedDates_ = (MapField<string, FoundersPackClaimedDate>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000D2D")]
		[DebuggerNonUserCode]
		public static MessageParser<TrackingData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D69")]
			[Cpp2IlInjected.Address(RVA = "0x78C790", Offset = "0x78B190", VA = "0x18078C790")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D2E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D6A")]
			[Cpp2IlInjected.Address(RVA = "0x78C6C0", Offset = "0x78B0C0", VA = "0x18078C6C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D2F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D6B")]
			[Cpp2IlInjected.Address(RVA = "0x78C7F0", Offset = "0x78B1F0", VA = "0x18078C7F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D30")]
		[DebuggerNonUserCode]
		public bool BackwardFoundersPackTracked
		{
			[Cpp2IlInjected.Token(Token = "0x6004D6F")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return backwardFoundersPackTracked_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D70")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				backwardFoundersPackTracked_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D31")]
		[DebuggerNonUserCode]
		public MapField<string, FoundersPackClaimedDate> FoundersPackClaimedDates
		{
			[Cpp2IlInjected.Token(Token = "0x6004D71")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return foundersPackClaimedDates_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6C")]
		[Cpp2IlInjected.Address(RVA = "0x78C540", Offset = "0x78AF40", VA = "0x18078C540")]
		[DebuggerNonUserCode]
		public TrackingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6D")]
		[Cpp2IlInjected.Address(RVA = "0x78C5C0", Offset = "0x78AFC0", VA = "0x18078C5C0")]
		[DebuggerNonUserCode]
		public TrackingData(TrackingData other)
		{
			bool flag = (backwardFoundersPackTracked_ = other.backwardFoundersPackTracked_);
			MapField<string, FoundersPackClaimedDate> mapField = (foundersPackClaimedDates_ = (MapField<string, FoundersPackClaimedDate>)(object)((MapField<TKey, TValue>)(object)other.foundersPackClaimedDates_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6E")]
		[Cpp2IlInjected.Address(RVA = "0x78BB60", Offset = "0x78A560", VA = "0x18078BB60", Slot = "10")]
		[DebuggerNonUserCode]
		public TrackingData Clone()
		{
			//Discarded unreachable code: IL_004b
			TrackingData trackingData = new TrackingData();
			MapField<string, FoundersPackClaimedDate> mapField = (trackingData.foundersPackClaimedDates_ = (MapField<string, FoundersPackClaimedDate>)(object)new MapField<TKey, TValue>());
			bool flag = (trackingData.backwardFoundersPackTracked_ = backwardFoundersPackTracked_);
			MapField<string, FoundersPackClaimedDate> mapField2 = (trackingData.foundersPackClaimedDates_ = (MapField<string, FoundersPackClaimedDate>)(object)((MapField<TKey, TValue>)(object)foundersPackClaimedDates_).Clone());
			UnknownFieldSet unknownFieldSet = (trackingData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return trackingData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D72")]
		[Cpp2IlInjected.Address(RVA = "0x78BD30", Offset = "0x78A730", VA = "0x18078BD30", Slot = "0")]
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
				if ((IntPtr)(backwardFoundersPackTracked_ ? 1 : 0) == (IntPtr)typeof(TrackingData).TypeHandle)
				{
					MapField<string, FoundersPackClaimedDate> mapField = foundersPackClaimedDates_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D73")]
		[Cpp2IlInjected.Address(RVA = "0x78BC90", Offset = "0x78A690", VA = "0x18078BC90", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TrackingData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.backwardFoundersPackTracked_;
				if (backwardFoundersPackTracked_ == flag)
				{
					MapField<string, FoundersPackClaimedDate> mapField = foundersPackClaimedDates_;
					MapField<string, FoundersPackClaimedDate> mapField2 = other.foundersPackClaimedDates_;
					if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D74")]
		[Cpp2IlInjected.Address(RVA = "0x78BEE0", Offset = "0x78A8E0", VA = "0x18078BEE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002a
			if (backwardFoundersPackTracked_)
			{
			}
			int hashCode = ((MapField<TKey, TValue>)(object)foundersPackClaimedDates_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D75")]
		[Cpp2IlInjected.Address(RVA = "0x78C1C0", Offset = "0x78ABC0", VA = "0x18078C1C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D76")]
		[Cpp2IlInjected.Address(RVA = "0x78C220", Offset = "0x78AC20", VA = "0x18078C220", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (backwardFoundersPackTracked_)
			{
				bool value = backwardFoundersPackTracked_;
				output.WriteBool(value);
			}
			MapField<string, FoundersPackClaimedDate> mapField = foundersPackClaimedDates_;
			MapField<string, FoundersPackClaimedDate>.Codec map_foundersPackClaimedDates_codec = _map_foundersPackClaimedDates_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_foundersPackClaimedDates_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D77")]
		[Cpp2IlInjected.Address(RVA = "0x78BA30", Offset = "0x78A430", VA = "0x18078BA30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			MapField<string, FoundersPackClaimedDate> mapField = foundersPackClaimedDates_;
			MapField<string, FoundersPackClaimedDate>.Codec map_foundersPackClaimedDates_codec = _map_foundersPackClaimedDates_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_foundersPackClaimedDates_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				mapField = (MapField<string, FoundersPackClaimedDate>)(mapField + num2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D78")]
		[Cpp2IlInjected.Address(RVA = "0x78C060", Offset = "0x78AA60", VA = "0x18078C060", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TrackingData other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				bool flag = other.backwardFoundersPackTracked_;
				if (flag)
				{
					backwardFoundersPackTracked_ = flag;
				}
				MapField<string, FoundersPackClaimedDate> mapField = foundersPackClaimedDates_;
				MapField<string, FoundersPackClaimedDate> mapField2 = other.foundersPackClaimedDates_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D79")]
		[Cpp2IlInjected.Address(RVA = "0x78BF60", Offset = "0x78A960", VA = "0x18078BF60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (backwardFoundersPackTracked_ = input.ReadBool());
				}
				if (num == 18)
				{
					MapField<string, FoundersPackClaimedDate> mapField = foundersPackClaimedDates_;
					MapField<string, FoundersPackClaimedDate>.Codec map_foundersPackClaimedDates_codec = _map_foundersPackClaimedDates_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_foundersPackClaimedDates_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D7A")]
		[Cpp2IlInjected.Address(RVA = "0x78BE10", Offset = "0x78A810", VA = "0x18078BE10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = backwardFoundersPackTracked_;
			}
			if (fieldNumber == 2)
			{
				MapField<string, FoundersPackClaimedDate> mapField = foundersPackClaimedDates_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D7B")]
		[Cpp2IlInjected.Address(RVA = "0x78C0F0", Offset = "0x78AAF0", VA = "0x18078C0F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				backwardFoundersPackTracked_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D7C")]
		[Cpp2IlInjected.Address(RVA = "0x78BAF0", Offset = "0x78A4F0", VA = "0x18078BAF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				backwardFoundersPackTracked_ = false;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			MapField<string, FoundersPackClaimedDate> mapField = foundersPackClaimedDates_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D7D")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78AD10", VA = "0x18078C310")]
		static TrackingData()
		{
			Func<TrackingData> func = default(Func<TrackingData>);
			_parser = (MessageParser<TrackingData>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<FoundersPackClaimedDate> parser = FoundersPackClaimedDate._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<FoundersPackClaimedDate>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<TrackingData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
