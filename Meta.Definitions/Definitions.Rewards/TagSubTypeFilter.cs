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
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	public sealed class TagSubTypeFilter : IMessage<TagSubTypeFilter>, IMessage, IEquatable<TagSubTypeFilter>, IDeepCloneable<TagSubTypeFilter>, IMessageFieldAccessor, ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private static readonly MessageParser<TagSubTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private static readonly FieldCodec<TagItemType> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private readonly RepeatedField<TagItemType> values_;

		[Cpp2IlInjected.Token(Token = "0x1700039F")]
		[DebuggerNonUserCode]
		public static MessageParser<TagSubTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000F73")]
			[Cpp2IlInjected.Address(RVA = "0x2565130", Offset = "0x2563B30", VA = "0x182565130")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F74")]
			[Cpp2IlInjected.Address(RVA = "0x2565060", Offset = "0x2563A60", VA = "0x182565060")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F75")]
			[Cpp2IlInjected.Address(RVA = "0x2565190", Offset = "0x2563B90", VA = "0x182565190", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A2")]
		[DebuggerNonUserCode]
		public RepeatedField<TagItemType> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F79")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0x2564F50", Offset = "0x2563950", VA = "0x182564F50")]
		[DebuggerNonUserCode]
		public TagSubTypeFilter()
		{
			values_ = (RepeatedField<TagItemType>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F77")]
		[Cpp2IlInjected.Address(RVA = "0x2564FD0", Offset = "0x25639D0", VA = "0x182564FD0")]
		[DebuggerNonUserCode]
		public TagSubTypeFilter(TagSubTypeFilter other)
		{
			RepeatedField<TagItemType> repeatedField = (values_ = (RepeatedField<TagItemType>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F78")]
		[Cpp2IlInjected.Address(RVA = "0x2564690", Offset = "0x2563090", VA = "0x182564690", Slot = "10")]
		[DebuggerNonUserCode]
		public TagSubTypeFilter Clone()
		{
			//Discarded unreachable code: IL_002e
			TagSubTypeFilter tagSubTypeFilter = new TagSubTypeFilter();
			RepeatedField<TagItemType> repeatedField = (tagSubTypeFilter.values_ = (RepeatedField<TagItemType>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (tagSubTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return tagSubTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7A")]
		[Cpp2IlInjected.Address(RVA = "0x2564750", Offset = "0x2563150", VA = "0x182564750", Slot = "0")]
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
				RepeatedField<TagItemType> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7B")]
		[Cpp2IlInjected.Address(RVA = "0x2564830", Offset = "0x2563230", VA = "0x182564830", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TagSubTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<TagItemType> repeatedField = values_;
				RepeatedField<TagItemType> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7C")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F7D")]
		[Cpp2IlInjected.Address(RVA = "0x2564C10", Offset = "0x2563610", VA = "0x182564C10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7E")]
		[Cpp2IlInjected.Address(RVA = "0x2564C70", Offset = "0x2563670", VA = "0x182564C70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<TagItemType> repeatedField = values_;
			FieldCodec<TagItemType> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7F")]
		[Cpp2IlInjected.Address(RVA = "0x2564580", Offset = "0x2562F80", VA = "0x182564580", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<TagItemType> repeatedField = values_;
			FieldCodec<TagItemType> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F80")]
		[Cpp2IlInjected.Address(RVA = "0x2564B30", Offset = "0x2563530", VA = "0x182564B30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TagSubTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<TagItemType> repeatedField = values_;
				RepeatedField<TagItemType> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F81")]
		[Cpp2IlInjected.Address(RVA = "0x2564A40", Offset = "0x2563440", VA = "0x182564A40", Slot = "5")]
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
				RepeatedField<TagItemType> repeatedField = values_;
				FieldCodec<TagItemType> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F82")]
		[Cpp2IlInjected.Address(RVA = "0x25648C0", Offset = "0x25632C0", VA = "0x1825648C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<TagItemType> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F83")]
		[Cpp2IlInjected.Address(RVA = "0x2564BB0", Offset = "0x25635B0", VA = "0x182564BB0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F84")]
		[Cpp2IlInjected.Address(RVA = "0x2564630", Offset = "0x2563030", VA = "0x182564630", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<TagItemType> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F85")]
		[Cpp2IlInjected.Address(RVA = "0x2564940", Offset = "0x2563340", VA = "0x182564940", Slot = "14")]
		public bool IsValid(ItemDatabase itemDb, Item item)
		{
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			if (itemType == ItemType.Tag && flag)
			{
				RepeatedField<TagItemType> repeatedField = values_;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F86")]
		[Cpp2IlInjected.Address(RVA = "0x2564D30", Offset = "0x2563730", VA = "0x182564D30")]
		static TagSubTypeFilter()
		{
			Func<TagSubTypeFilter> func = default(Func<TagSubTypeFilter>);
			MessageParser<TagSubTypeFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<TagSubTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<TagItemType, int> func2 = (Func<TagItemType, int>)(object)(Func<T, TResult>)((TagItemType x) => (int)x);
			Func<int, TagItemType> func3 = (Func<int, TagItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<TagSubTypeFilter>)(object)FieldCodec.ForEnum<TagItemType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
