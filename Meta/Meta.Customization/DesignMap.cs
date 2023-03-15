using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x2001102")]
	public sealed class DesignMap : IMessage<DesignMap>, IMessage, IEquatable<DesignMap>, IDeepCloneable<DesignMap>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400462C")]
		private static readonly MessageParser<DesignMap> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400462D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400462E")]
		public const int DesignsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400462F")]
		private static readonly MapField<int, Design>.Codec _map_designs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004630")]
		private readonly MapField<int, Design> designs_ = (MapField<int, Design>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x1700184A")]
		[DebuggerNonUserCode]
		public static MessageParser<DesignMap> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008AB4")]
			[Cpp2IlInjected.Address(RVA = "0x1A2A7C0", Offset = "0x1A291C0", VA = "0x181A2A7C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700184B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008AB5")]
			[Cpp2IlInjected.Address(RVA = "0x1A2A6F0", Offset = "0x1A290F0", VA = "0x181A2A6F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700184C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008AB6")]
			[Cpp2IlInjected.Address(RVA = "0x1A2A820", Offset = "0x1A29220", VA = "0x181A2A820", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700184D")]
		[DebuggerNonUserCode]
		public MapField<int, Design> Designs
		{
			[Cpp2IlInjected.Token(Token = "0x6008ABA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return designs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AB7")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A570", Offset = "0x1A28F70", VA = "0x181A2A570")]
		[DebuggerNonUserCode]
		public DesignMap()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008AB8")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A5F0", Offset = "0x1A28FF0", VA = "0x181A2A5F0")]
		[DebuggerNonUserCode]
		public DesignMap(DesignMap other)
		{
			MapField<int, Design> mapField = (designs_ = (MapField<int, Design>)(object)((MapField<TKey, TValue>)(object)other.designs_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008AB9")]
		[Cpp2IlInjected.Address(RVA = "0x1A29D30", Offset = "0x1A28730", VA = "0x181A29D30", Slot = "10")]
		[DebuggerNonUserCode]
		public DesignMap Clone()
		{
			//Discarded unreachable code: IL_003b
			DesignMap designMap = new DesignMap();
			MapField<int, Design> mapField = (designMap.designs_ = (MapField<int, Design>)(object)new MapField<TKey, TValue>());
			MapField<int, Design> mapField2 = (designMap.designs_ = (MapField<int, Design>)(object)((MapField<TKey, TValue>)(object)designs_).Clone());
			UnknownFieldSet unknownFieldSet = (designMap._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return designMap;
		}

		[Cpp2IlInjected.Token(Token = "0x6008ABB")]
		[Cpp2IlInjected.Address(RVA = "0x1A29E60", Offset = "0x1A28860", VA = "0x181A29E60", Slot = "0")]
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
				MapField<int, Design> mapField = designs_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008ABC")]
		[Cpp2IlInjected.Address(RVA = "0x1A29F40", Offset = "0x1A28940", VA = "0x181A29F40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DesignMap other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<int, Design> mapField = designs_;
				MapField<int, Design> mapField2 = other.designs_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008ABD")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((MapField<TKey, TValue>)(object)designs_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6008ABE")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A220", Offset = "0x1A28C20", VA = "0x181A2A220", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008ABF")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A280", Offset = "0x1A28C80", VA = "0x181A2A280", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			MapField<int, Design> mapField = designs_;
			MapField<int, Design>.Codec map_designs_codec = _map_designs_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_designs_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008AC0")]
		[Cpp2IlInjected.Address(RVA = "0x1A29C20", Offset = "0x1A28620", VA = "0x181A29C20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			MapField<int, Design> mapField = designs_;
			MapField<int, Design>.Codec map_designs_codec = _map_designs_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_designs_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008AC1")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A050", Offset = "0x1A28A50", VA = "0x181A2A050", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DesignMap other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				MapField<int, Design> mapField = designs_;
				MapField<int, Design> mapField2 = other.designs_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AC2")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A0D0", Offset = "0x1A28AD0", VA = "0x181A2A0D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<int, Design> mapField = designs_;
					MapField<int, Design>.Codec map_designs_codec = _map_designs_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_designs_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AC3")]
		[Cpp2IlInjected.Address(RVA = "0x1A29FD0", Offset = "0x1A289D0", VA = "0x181A29FD0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<int, Design> mapField = designs_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008AC4")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A1C0", Offset = "0x1A28BC0", VA = "0x181A2A1C0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6008AC5")]
		[Cpp2IlInjected.Address(RVA = "0x1A29CD0", Offset = "0x1A286D0", VA = "0x181A29CD0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				MapField<int, Design> mapField = designs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AC6")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A340", Offset = "0x1A28D40", VA = "0x181A2A340")]
		static DesignMap()
		{
			Func<DesignMap> func = default(Func<DesignMap>);
			_parser = (MessageParser<DesignMap>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<Design> parser = Design._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<Design>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<DesignMap>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
