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
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	public sealed class TrimmingSubTypeFilter : IMessage<TrimmingSubTypeFilter>, IMessage, IEquatable<TrimmingSubTypeFilter>, IDeepCloneable<TrimmingSubTypeFilter>, IMessageFieldAccessor, ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private static readonly MessageParser<TrimmingSubTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private static readonly FieldCodec<TrimmingItemType> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private readonly RepeatedField<TrimmingItemType> values_ = (RepeatedField<TrimmingItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170003AB")]
		[DebuggerNonUserCode]
		public static MessageParser<TrimmingSubTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000FBE")]
			[Cpp2IlInjected.Address(RVA = "0x3552B90", Offset = "0x3551590", VA = "0x183552B90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000FBF")]
			[Cpp2IlInjected.Address(RVA = "0x3552AC0", Offset = "0x35514C0", VA = "0x183552AC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000FC0")]
			[Cpp2IlInjected.Address(RVA = "0x3552BF0", Offset = "0x35515F0", VA = "0x183552BF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AE")]
		[DebuggerNonUserCode]
		public RepeatedField<TrimmingItemType> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000FC4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC1")]
		[Cpp2IlInjected.Address(RVA = "0x3552A40", Offset = "0x3551440", VA = "0x183552A40")]
		[DebuggerNonUserCode]
		public TrimmingSubTypeFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC2")]
		[Cpp2IlInjected.Address(RVA = "0x3552940", Offset = "0x3551340", VA = "0x183552940")]
		[DebuggerNonUserCode]
		public TrimmingSubTypeFilter(TrimmingSubTypeFilter other)
		{
			RepeatedField<TrimmingItemType> repeatedField = (values_ = (RepeatedField<TrimmingItemType>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC3")]
		[Cpp2IlInjected.Address(RVA = "0x3552010", Offset = "0x3550A10", VA = "0x183552010", Slot = "10")]
		[DebuggerNonUserCode]
		public TrimmingSubTypeFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			TrimmingSubTypeFilter trimmingSubTypeFilter = new TrimmingSubTypeFilter();
			RepeatedField<TrimmingItemType> repeatedField = (trimmingSubTypeFilter.values_ = (RepeatedField<TrimmingItemType>)(object)new RepeatedField<T>());
			RepeatedField<TrimmingItemType> repeatedField2 = (trimmingSubTypeFilter.values_ = (RepeatedField<TrimmingItemType>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (trimmingSubTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return trimmingSubTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC5")]
		[Cpp2IlInjected.Address(RVA = "0x3552140", Offset = "0x3550B40", VA = "0x183552140", Slot = "0")]
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
				RepeatedField<TrimmingItemType> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC6")]
		[Cpp2IlInjected.Address(RVA = "0x3552220", Offset = "0x3550C20", VA = "0x183552220", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TrimmingSubTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<TrimmingItemType> repeatedField = values_;
				RepeatedField<TrimmingItemType> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC7")]
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

		[Cpp2IlInjected.Token(Token = "0x6000FC8")]
		[Cpp2IlInjected.Address(RVA = "0x3552600", Offset = "0x3551000", VA = "0x183552600", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC9")]
		[Cpp2IlInjected.Address(RVA = "0x3552660", Offset = "0x3551060", VA = "0x183552660", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<TrimmingItemType> repeatedField = values_;
			FieldCodec<TrimmingItemType> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FCA")]
		[Cpp2IlInjected.Address(RVA = "0x3551F00", Offset = "0x3550900", VA = "0x183551F00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<TrimmingItemType> repeatedField = values_;
			FieldCodec<TrimmingItemType> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FCB")]
		[Cpp2IlInjected.Address(RVA = "0x3552520", Offset = "0x3550F20", VA = "0x183552520", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TrimmingSubTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<TrimmingItemType> repeatedField = values_;
				RepeatedField<TrimmingItemType> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FCC")]
		[Cpp2IlInjected.Address(RVA = "0x3552430", Offset = "0x3550E30", VA = "0x183552430", Slot = "5")]
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
				RepeatedField<TrimmingItemType> repeatedField = values_;
				FieldCodec<TrimmingItemType> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FCD")]
		[Cpp2IlInjected.Address(RVA = "0x35522B0", Offset = "0x3550CB0", VA = "0x1835522B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<TrimmingItemType> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FCE")]
		[Cpp2IlInjected.Address(RVA = "0x35525A0", Offset = "0x3550FA0", VA = "0x1835525A0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000FCF")]
		[Cpp2IlInjected.Address(RVA = "0x3551FB0", Offset = "0x35509B0", VA = "0x183551FB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<TrimmingItemType> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD0")]
		[Cpp2IlInjected.Address(RVA = "0x3552330", Offset = "0x3550D30", VA = "0x183552330", Slot = "14")]
		public bool IsValid(ItemDatabase itemDb, Item item)
		{
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			if (itemType == ItemType.Trimming && flag)
			{
				RepeatedField<TrimmingItemType> repeatedField = values_;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD1")]
		[Cpp2IlInjected.Address(RVA = "0x3552720", Offset = "0x3551120", VA = "0x183552720")]
		static TrimmingSubTypeFilter()
		{
			Func<TrimmingSubTypeFilter> func = default(Func<TrimmingSubTypeFilter>);
			MessageParser<TrimmingSubTypeFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<TrimmingSubTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<TrimmingItemType, int> func2 = (Func<TrimmingItemType, int>)(object)(Func<T, TResult>)((TrimmingItemType x) => (int)x);
			Func<int, TrimmingItemType> func3 = (Func<int, TrimmingItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<TrimmingSubTypeFilter>)(object)FieldCodec.ForEnum<TrimmingItemType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
