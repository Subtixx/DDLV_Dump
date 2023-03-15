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
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	public sealed class ClothingSubTypeFilter : IMessage<ClothingSubTypeFilter>, IMessage, IEquatable<ClothingSubTypeFilter>, IDeepCloneable<ClothingSubTypeFilter>, IMessageFieldAccessor, ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private static readonly MessageParser<ClothingSubTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private static readonly FieldCodec<ClothingItemType> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private readonly RepeatedField<ClothingItemType> values_ = (RepeatedField<ClothingItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170003A7")]
		[DebuggerNonUserCode]
		public static MessageParser<ClothingSubTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA5")]
			[Cpp2IlInjected.Address(RVA = "0x2EC1EA0", Offset = "0x2EC08A0", VA = "0x182EC1EA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA6")]
			[Cpp2IlInjected.Address(RVA = "0x2EC1DD0", Offset = "0x2EC07D0", VA = "0x182EC1DD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA7")]
			[Cpp2IlInjected.Address(RVA = "0x2EC1F00", Offset = "0x2EC0900", VA = "0x182EC1F00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AA")]
		[DebuggerNonUserCode]
		public RepeatedField<ClothingItemType> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000FAB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1C50", Offset = "0x2EC0650", VA = "0x182EC1C50")]
		[DebuggerNonUserCode]
		public ClothingSubTypeFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1CD0", Offset = "0x2EC06D0", VA = "0x182EC1CD0")]
		[DebuggerNonUserCode]
		public ClothingSubTypeFilter(ClothingSubTypeFilter other)
		{
			RepeatedField<ClothingItemType> repeatedField = (values_ = (RepeatedField<ClothingItemType>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1320", Offset = "0x2EBFD20", VA = "0x182EC1320", Slot = "10")]
		[DebuggerNonUserCode]
		public ClothingSubTypeFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			ClothingSubTypeFilter clothingSubTypeFilter = new ClothingSubTypeFilter();
			RepeatedField<ClothingItemType> repeatedField = (clothingSubTypeFilter.values_ = (RepeatedField<ClothingItemType>)(object)new RepeatedField<T>());
			RepeatedField<ClothingItemType> repeatedField2 = (clothingSubTypeFilter.values_ = (RepeatedField<ClothingItemType>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (clothingSubTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return clothingSubTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAC")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1450", Offset = "0x2EBFE50", VA = "0x182EC1450", Slot = "0")]
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
				RepeatedField<ClothingItemType> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAD")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1530", Offset = "0x2EBFF30", VA = "0x182EC1530", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ClothingSubTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ClothingItemType> repeatedField = values_;
				RepeatedField<ClothingItemType> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAE")]
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

		[Cpp2IlInjected.Token(Token = "0x6000FAF")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1910", Offset = "0x2EC0310", VA = "0x182EC1910", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB0")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1970", Offset = "0x2EC0370", VA = "0x182EC1970", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<ClothingItemType> repeatedField = values_;
			FieldCodec<ClothingItemType> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB1")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1210", Offset = "0x2EBFC10", VA = "0x182EC1210", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<ClothingItemType> repeatedField = values_;
			FieldCodec<ClothingItemType> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1830", Offset = "0x2EC0230", VA = "0x182EC1830", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ClothingSubTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<ClothingItemType> repeatedField = values_;
				RepeatedField<ClothingItemType> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1740", Offset = "0x2EC0140", VA = "0x182EC1740", Slot = "5")]
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
				RepeatedField<ClothingItemType> repeatedField = values_;
				FieldCodec<ClothingItemType> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC15C0", Offset = "0x2EBFFC0", VA = "0x182EC15C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ClothingItemType> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC18B0", Offset = "0x2EC02B0", VA = "0x182EC18B0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000FB6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC12C0", Offset = "0x2EBFCC0", VA = "0x182EC12C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<ClothingItemType> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1640", Offset = "0x2EC0040", VA = "0x182EC1640", Slot = "14")]
		public bool IsValid(ItemDatabase itemDb, Item item)
		{
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			if (itemType == ItemType.Clothing && flag)
			{
				RepeatedField<ClothingItemType> repeatedField = values_;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1A30", Offset = "0x2EC0430", VA = "0x182EC1A30")]
		static ClothingSubTypeFilter()
		{
			Func<ClothingSubTypeFilter> func = default(Func<ClothingSubTypeFilter>);
			MessageParser<ClothingSubTypeFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ClothingSubTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<ClothingItemType, int> func2 = (Func<ClothingItemType, int>)(object)(Func<T, TResult>)((ClothingItemType x) => (int)x);
			Func<int, ClothingItemType> func3 = (Func<int, ClothingItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ClothingSubTypeFilter>)(object)FieldCodec.ForEnum<ClothingItemType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
