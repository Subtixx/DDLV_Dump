using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	public sealed class FurnitureSubTypeFilter : IMessage<FurnitureSubTypeFilter>, IMessage, IEquatable<FurnitureSubTypeFilter>, IDeepCloneable<FurnitureSubTypeFilter>, IMessageFieldAccessor, ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private static readonly MessageParser<FurnitureSubTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private static readonly FieldCodec<FurnitureItemType> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private readonly RepeatedField<FurnitureItemType> values_ = (RepeatedField<FurnitureItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700039B")]
		[DebuggerNonUserCode]
		public static MessageParser<FurnitureSubTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000F5A")]
			[Cpp2IlInjected.Address(RVA = "0x21865C0", Offset = "0x2184FC0", VA = "0x1821865C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F5B")]
			[Cpp2IlInjected.Address(RVA = "0x21864F0", Offset = "0x2184EF0", VA = "0x1821864F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F5C")]
			[Cpp2IlInjected.Address(RVA = "0x2186620", Offset = "0x2185020", VA = "0x182186620", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039E")]
		[DebuggerNonUserCode]
		public RepeatedField<FurnitureItemType> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F60")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5D")]
		[Cpp2IlInjected.Address(RVA = "0x2186370", Offset = "0x2184D70", VA = "0x182186370")]
		[DebuggerNonUserCode]
		public FurnitureSubTypeFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5E")]
		[Cpp2IlInjected.Address(RVA = "0x21863F0", Offset = "0x2184DF0", VA = "0x1821863F0")]
		[DebuggerNonUserCode]
		public FurnitureSubTypeFilter(FurnitureSubTypeFilter other)
		{
			RepeatedField<FurnitureItemType> repeatedField = (values_ = (RepeatedField<FurnitureItemType>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5F")]
		[Cpp2IlInjected.Address(RVA = "0x2185A90", Offset = "0x2184490", VA = "0x182185A90", Slot = "10")]
		[DebuggerNonUserCode]
		public FurnitureSubTypeFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			FurnitureSubTypeFilter furnitureSubTypeFilter = new FurnitureSubTypeFilter();
			RepeatedField<FurnitureItemType> repeatedField = (furnitureSubTypeFilter.values_ = (RepeatedField<FurnitureItemType>)(object)new RepeatedField<T>());
			RepeatedField<FurnitureItemType> repeatedField2 = (furnitureSubTypeFilter.values_ = (RepeatedField<FurnitureItemType>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (furnitureSubTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return furnitureSubTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F61")]
		[Cpp2IlInjected.Address(RVA = "0x2185C50", Offset = "0x2184650", VA = "0x182185C50", Slot = "0")]
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
				RepeatedField<FurnitureItemType> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F62")]
		[Cpp2IlInjected.Address(RVA = "0x2185BC0", Offset = "0x21845C0", VA = "0x182185BC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FurnitureSubTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<FurnitureItemType> repeatedField = values_;
				RepeatedField<FurnitureItemType> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F63")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)values_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F64")]
		[Cpp2IlInjected.Address(RVA = "0x2186030", Offset = "0x2184A30", VA = "0x182186030", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F65")]
		[Cpp2IlInjected.Address(RVA = "0x2186090", Offset = "0x2184A90", VA = "0x182186090", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<FurnitureItemType> repeatedField = values_;
			FieldCodec<FurnitureItemType> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F66")]
		[Cpp2IlInjected.Address(RVA = "0x2185980", Offset = "0x2184380", VA = "0x182185980", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<FurnitureItemType> repeatedField = values_;
			FieldCodec<FurnitureItemType> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F67")]
		[Cpp2IlInjected.Address(RVA = "0x2185E60", Offset = "0x2184860", VA = "0x182185E60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FurnitureSubTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<FurnitureItemType> repeatedField = values_;
				RepeatedField<FurnitureItemType> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F68")]
		[Cpp2IlInjected.Address(RVA = "0x2185EE0", Offset = "0x21848E0", VA = "0x182185EE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<FurnitureItemType> repeatedField = values_;
				FieldCodec<FurnitureItemType> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F69")]
		[Cpp2IlInjected.Address(RVA = "0x2185D30", Offset = "0x2184730", VA = "0x182185D30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<FurnitureItemType> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6A")]
		[Cpp2IlInjected.Address(RVA = "0x2185FD0", Offset = "0x21849D0", VA = "0x182185FD0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F6B")]
		[Cpp2IlInjected.Address(RVA = "0x2185A30", Offset = "0x2184430", VA = "0x182185A30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<FurnitureItemType> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6C")]
		[Cpp2IlInjected.Address(RVA = "0x2185DB0", Offset = "0x21847B0", VA = "0x182185DB0", Slot = "14")]
		public bool IsValid(ItemDatabase itemDb, Item item)
		{
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			if (itemType == ItemType.Furniture && flag)
			{
				RepeatedField<FurnitureItemType> repeatedField = values_;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6D")]
		[Cpp2IlInjected.Address(RVA = "0x2186150", Offset = "0x2184B50", VA = "0x182186150")]
		static FurnitureSubTypeFilter()
		{
			Func<FurnitureSubTypeFilter> func = default(Func<FurnitureSubTypeFilter>);
			MessageParser<FurnitureSubTypeFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<FurnitureSubTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<FurnitureItemType, int> func2 = (Func<FurnitureItemType, int>)(object)(Func<T, TResult>)((FurnitureItemType x) => (int)x);
			Func<int, FurnitureItemType> func3 = (Func<int, FurnitureItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<FurnitureSubTypeFilter>)(object)FieldCodec.ForEnum<FurnitureItemType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
