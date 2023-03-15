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
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	public sealed class BuildingSubTypeFilter : IMessage<BuildingSubTypeFilter>, IMessage, IEquatable<BuildingSubTypeFilter>, IDeepCloneable<BuildingSubTypeFilter>, IMessageFieldAccessor, ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private static readonly MessageParser<BuildingSubTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private static readonly FieldCodec<BuildingItemType> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private readonly RepeatedField<BuildingItemType> values_ = (RepeatedField<BuildingItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000397")]
		[DebuggerNonUserCode]
		public static MessageParser<BuildingSubTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000F41")]
			[Cpp2IlInjected.Address(RVA = "0x32F01B0", Offset = "0x32EEBB0", VA = "0x1832F01B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000398")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F42")]
			[Cpp2IlInjected.Address(RVA = "0x32F00E0", Offset = "0x32EEAE0", VA = "0x1832F00E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000399")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F43")]
			[Cpp2IlInjected.Address(RVA = "0x32F0210", Offset = "0x32EEC10", VA = "0x1832F0210", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039A")]
		[DebuggerNonUserCode]
		public RepeatedField<BuildingItemType> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F47")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F44")]
		[Cpp2IlInjected.Address(RVA = "0x32F0060", Offset = "0x32EEA60", VA = "0x1832F0060")]
		[DebuggerNonUserCode]
		public BuildingSubTypeFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F45")]
		[Cpp2IlInjected.Address(RVA = "0x32EFF60", Offset = "0x32EE960", VA = "0x1832EFF60")]
		[DebuggerNonUserCode]
		public BuildingSubTypeFilter(BuildingSubTypeFilter other)
		{
			RepeatedField<BuildingItemType> repeatedField = (values_ = (RepeatedField<BuildingItemType>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F46")]
		[Cpp2IlInjected.Address(RVA = "0x32EF630", Offset = "0x32EE030", VA = "0x1832EF630", Slot = "10")]
		[DebuggerNonUserCode]
		public BuildingSubTypeFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			BuildingSubTypeFilter buildingSubTypeFilter = new BuildingSubTypeFilter();
			RepeatedField<BuildingItemType> repeatedField = (buildingSubTypeFilter.values_ = (RepeatedField<BuildingItemType>)(object)new RepeatedField<T>());
			RepeatedField<BuildingItemType> repeatedField2 = (buildingSubTypeFilter.values_ = (RepeatedField<BuildingItemType>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (buildingSubTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return buildingSubTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F48")]
		[Cpp2IlInjected.Address(RVA = "0x32EF7F0", Offset = "0x32EE1F0", VA = "0x1832EF7F0", Slot = "0")]
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
				RepeatedField<BuildingItemType> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F49")]
		[Cpp2IlInjected.Address(RVA = "0x32EF760", Offset = "0x32EE160", VA = "0x1832EF760", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuildingSubTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<BuildingItemType> repeatedField = values_;
				RepeatedField<BuildingItemType> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4A")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F4B")]
		[Cpp2IlInjected.Address(RVA = "0x32EFC20", Offset = "0x32EE620", VA = "0x1832EFC20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4C")]
		[Cpp2IlInjected.Address(RVA = "0x32EFC80", Offset = "0x32EE680", VA = "0x1832EFC80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<BuildingItemType> repeatedField = values_;
			FieldCodec<BuildingItemType> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4D")]
		[Cpp2IlInjected.Address(RVA = "0x32EF520", Offset = "0x32EDF20", VA = "0x1832EF520", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<BuildingItemType> repeatedField = values_;
			FieldCodec<BuildingItemType> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4E")]
		[Cpp2IlInjected.Address(RVA = "0x32EFB40", Offset = "0x32EE540", VA = "0x1832EFB40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuildingSubTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<BuildingItemType> repeatedField = values_;
				RepeatedField<BuildingItemType> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4F")]
		[Cpp2IlInjected.Address(RVA = "0x32EFA50", Offset = "0x32EE450", VA = "0x1832EFA50", Slot = "5")]
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
				RepeatedField<BuildingItemType> repeatedField = values_;
				FieldCodec<BuildingItemType> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F50")]
		[Cpp2IlInjected.Address(RVA = "0x32EF8D0", Offset = "0x32EE2D0", VA = "0x1832EF8D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<BuildingItemType> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F51")]
		[Cpp2IlInjected.Address(RVA = "0x32EFBC0", Offset = "0x32EE5C0", VA = "0x1832EFBC0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F52")]
		[Cpp2IlInjected.Address(RVA = "0x32EF5D0", Offset = "0x32EDFD0", VA = "0x1832EF5D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<BuildingItemType> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F53")]
		[Cpp2IlInjected.Address(RVA = "0x32EF950", Offset = "0x32EE350", VA = "0x1832EF950", Slot = "14")]
		public bool IsValid(ItemDatabase itemDb, Item item)
		{
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			if (itemType == ItemType.Building && flag)
			{
				RepeatedField<BuildingItemType> repeatedField = values_;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F54")]
		[Cpp2IlInjected.Address(RVA = "0x32EFD40", Offset = "0x32EE740", VA = "0x1832EFD40")]
		static BuildingSubTypeFilter()
		{
			Func<BuildingSubTypeFilter> func = default(Func<BuildingSubTypeFilter>);
			MessageParser<BuildingSubTypeFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<BuildingSubTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<BuildingItemType, int> func2 = (Func<BuildingItemType, int>)(object)(Func<T, TResult>)((BuildingItemType x) => (int)x);
			Func<int, BuildingItemType> func3 = (Func<int, BuildingItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<BuildingSubTypeFilter>)(object)FieldCodec.ForEnum<BuildingItemType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
