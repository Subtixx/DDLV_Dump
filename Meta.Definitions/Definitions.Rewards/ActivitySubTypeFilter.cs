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
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	public sealed class ActivitySubTypeFilter : IMessage<ActivitySubTypeFilter>, IMessage, IEquatable<ActivitySubTypeFilter>, IDeepCloneable<ActivitySubTypeFilter>, IMessageFieldAccessor, ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private static readonly MessageParser<ActivitySubTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private static readonly FieldCodec<ActivityItemType> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private readonly RepeatedField<ActivityItemType> values_ = (RepeatedField<ActivityItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000393")]
		[DebuggerNonUserCode]
		public static MessageParser<ActivitySubTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000F28")]
			[Cpp2IlInjected.Address(RVA = "0x315A7C0", Offset = "0x31591C0", VA = "0x18315A7C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000394")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F29")]
			[Cpp2IlInjected.Address(RVA = "0x315A6F0", Offset = "0x31590F0", VA = "0x18315A6F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000395")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F2A")]
			[Cpp2IlInjected.Address(RVA = "0x315A820", Offset = "0x3159220", VA = "0x18315A820", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000396")]
		[DebuggerNonUserCode]
		public RepeatedField<ActivityItemType> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F2E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2B")]
		[Cpp2IlInjected.Address(RVA = "0x315A670", Offset = "0x3159070", VA = "0x18315A670")]
		[DebuggerNonUserCode]
		public ActivitySubTypeFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2C")]
		[Cpp2IlInjected.Address(RVA = "0x315A570", Offset = "0x3158F70", VA = "0x18315A570")]
		[DebuggerNonUserCode]
		public ActivitySubTypeFilter(ActivitySubTypeFilter other)
		{
			RepeatedField<ActivityItemType> repeatedField = (values_ = (RepeatedField<ActivityItemType>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2D")]
		[Cpp2IlInjected.Address(RVA = "0x3159C40", Offset = "0x3158640", VA = "0x183159C40", Slot = "10")]
		[DebuggerNonUserCode]
		public ActivitySubTypeFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			ActivitySubTypeFilter activitySubTypeFilter = new ActivitySubTypeFilter();
			RepeatedField<ActivityItemType> repeatedField = (activitySubTypeFilter.values_ = (RepeatedField<ActivityItemType>)(object)new RepeatedField<T>());
			RepeatedField<ActivityItemType> repeatedField2 = (activitySubTypeFilter.values_ = (RepeatedField<ActivityItemType>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (activitySubTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return activitySubTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2F")]
		[Cpp2IlInjected.Address(RVA = "0x3159D70", Offset = "0x3158770", VA = "0x183159D70", Slot = "0")]
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
				RepeatedField<ActivityItemType> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F30")]
		[Cpp2IlInjected.Address(RVA = "0x3159E50", Offset = "0x3158850", VA = "0x183159E50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActivitySubTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ActivityItemType> repeatedField = values_;
				RepeatedField<ActivityItemType> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F31")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F32")]
		[Cpp2IlInjected.Address(RVA = "0x315A230", Offset = "0x3158C30", VA = "0x18315A230", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F33")]
		[Cpp2IlInjected.Address(RVA = "0x315A290", Offset = "0x3158C90", VA = "0x18315A290", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<ActivityItemType> repeatedField = values_;
			FieldCodec<ActivityItemType> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F34")]
		[Cpp2IlInjected.Address(RVA = "0x3159B30", Offset = "0x3158530", VA = "0x183159B30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<ActivityItemType> repeatedField = values_;
			FieldCodec<ActivityItemType> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F35")]
		[Cpp2IlInjected.Address(RVA = "0x315A150", Offset = "0x3158B50", VA = "0x18315A150", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActivitySubTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<ActivityItemType> repeatedField = values_;
				RepeatedField<ActivityItemType> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F36")]
		[Cpp2IlInjected.Address(RVA = "0x315A060", Offset = "0x3158A60", VA = "0x18315A060", Slot = "5")]
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
				RepeatedField<ActivityItemType> repeatedField = values_;
				FieldCodec<ActivityItemType> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F37")]
		[Cpp2IlInjected.Address(RVA = "0x3159EE0", Offset = "0x31588E0", VA = "0x183159EE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ActivityItemType> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F38")]
		[Cpp2IlInjected.Address(RVA = "0x315A1D0", Offset = "0x3158BD0", VA = "0x18315A1D0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F39")]
		[Cpp2IlInjected.Address(RVA = "0x3159BE0", Offset = "0x31585E0", VA = "0x183159BE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<ActivityItemType> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3A")]
		[Cpp2IlInjected.Address(RVA = "0x3159F60", Offset = "0x3158960", VA = "0x183159F60", Slot = "14")]
		public bool IsValid(ItemDatabase itemDb, Item item)
		{
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			if (itemType == ItemType.ActivityItem && flag)
			{
				RepeatedField<ActivityItemType> repeatedField = values_;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3B")]
		[Cpp2IlInjected.Address(RVA = "0x315A350", Offset = "0x3158D50", VA = "0x18315A350")]
		static ActivitySubTypeFilter()
		{
			Func<ActivitySubTypeFilter> func = default(Func<ActivitySubTypeFilter>);
			MessageParser<ActivitySubTypeFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ActivitySubTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<ActivityItemType, int> func2 = (Func<ActivityItemType, int>)(object)(Func<T, TResult>)((ActivityItemType x) => (int)x);
			Func<int, ActivityItemType> func3 = (Func<int, ActivityItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ActivitySubTypeFilter>)(object)FieldCodec.ForEnum<ActivityItemType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
