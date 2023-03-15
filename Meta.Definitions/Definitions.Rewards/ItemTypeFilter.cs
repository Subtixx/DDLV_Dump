using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	public sealed class ItemTypeFilter : BaseItemFilter, IMessage<ItemTypeFilter>, IMessage, IEquatable<ItemTypeFilter>, IDeepCloneable<ItemTypeFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private static readonly MessageParser<ItemTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private static readonly FieldCodec<ItemType> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private readonly RepeatedField<ItemType> values_ = (RepeatedField<ItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700038F")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0C")]
			[Cpp2IlInjected.Address(RVA = "0x647250", Offset = "0x645C50", VA = "0x180647250")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000390")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0D")]
			[Cpp2IlInjected.Address(RVA = "0x647180", Offset = "0x645B80", VA = "0x180647180")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000391")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0E")]
			[Cpp2IlInjected.Address(RVA = "0x6472B0", Offset = "0x645CB0", VA = "0x1806472B0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000392")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemType> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F12")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0F")]
		[Cpp2IlInjected.Address(RVA = "0x647000", Offset = "0x645A00", VA = "0x180647000")]
		[DebuggerNonUserCode]
		public ItemTypeFilter()
		{
			((System.Xml.Schema.RestrictionFacets)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F10")]
		[Cpp2IlInjected.Address(RVA = "0x647080", Offset = "0x645A80", VA = "0x180647080")]
		[DebuggerNonUserCode]
		public ItemTypeFilter(ItemTypeFilter other)
		{
			((System.Xml.Schema.RestrictionFacets)(object)this)._002Ector();
			RepeatedField<ItemType> repeatedField = (values_ = (RepeatedField<ItemType>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F11")]
		[Cpp2IlInjected.Address(RVA = "0x6464F0", Offset = "0x644EF0", VA = "0x1806464F0", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemTypeFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			ItemTypeFilter itemTypeFilter = new ItemTypeFilter();
			RepeatedField<ItemType> repeatedField = (itemTypeFilter.values_ = (RepeatedField<ItemType>)(object)new RepeatedField<T>());
			RepeatedField<ItemType> repeatedField2 = (itemTypeFilter.values_ = (RepeatedField<ItemType>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (itemTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F13")]
		[Cpp2IlInjected.Address(RVA = "0x646810", Offset = "0x645210", VA = "0x180646810", Slot = "0")]
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
				RepeatedField<ItemType> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F14")]
		[Cpp2IlInjected.Address(RVA = "0x646780", Offset = "0x645180", VA = "0x180646780", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ItemType> repeatedField = values_;
				RepeatedField<ItemType> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F15")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F16")]
		[Cpp2IlInjected.Address(RVA = "0x646B40", Offset = "0x645540", VA = "0x180646B40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F17")]
		[Cpp2IlInjected.Address(RVA = "0x646D20", Offset = "0x645720", VA = "0x180646D20", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<ItemType> repeatedField = values_;
			FieldCodec<ItemType> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F18")]
		[Cpp2IlInjected.Address(RVA = "0x6463E0", Offset = "0x644DE0", VA = "0x1806463E0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<ItemType> repeatedField = values_;
			FieldCodec<ItemType> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F19")]
		[Cpp2IlInjected.Address(RVA = "0x646970", Offset = "0x645370", VA = "0x180646970", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<ItemType> repeatedField = values_;
				RepeatedField<ItemType> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1A")]
		[Cpp2IlInjected.Address(RVA = "0x6469F0", Offset = "0x6453F0", VA = "0x1806469F0", Slot = "9")]
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
				RepeatedField<ItemType> repeatedField = values_;
				FieldCodec<ItemType> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0x6468F0", Offset = "0x6452F0", VA = "0x1806468F0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ItemType> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1C")]
		[Cpp2IlInjected.Address(RVA = "0x646AE0", Offset = "0x6454E0", VA = "0x180646AE0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F1D")]
		[Cpp2IlInjected.Address(RVA = "0x646490", Offset = "0x644E90", VA = "0x180646490", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<ItemType> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1E")]
		[Cpp2IlInjected.Address(RVA = "0x6466D0", Offset = "0x6450D0", VA = "0x1806466D0", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_0016
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0013
				RepeatedField<ItemType> repeatedField = values_;
				int itemID_ = x.itemID_;
				bool flag = default(bool);
				return !flag;
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1F")]
		[Cpp2IlInjected.Address(RVA = "0x646620", Offset = "0x645020", VA = "0x180646620", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_0016
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0010
				RepeatedField<ItemType> repeatedField = values_;
				int itemID_ = x.itemID_;
				bool result = default(bool);
				return result;
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F20")]
		[Cpp2IlInjected.Address(RVA = "0x646DE0", Offset = "0x6457E0", VA = "0x180646DE0")]
		static ItemTypeFilter()
		{
			Func<ItemTypeFilter> func = default(Func<ItemTypeFilter>);
			MessageParser<ItemTypeFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ItemTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<ItemType, int> func2 = (Func<ItemType, int>)(object)(Func<T, TResult>)((ItemType x) => (int)x);
			Func<int, ItemType> func3 = (Func<int, ItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ItemTypeFilter>)(object)FieldCodec.ForEnum<ItemType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
