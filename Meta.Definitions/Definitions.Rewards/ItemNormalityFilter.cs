using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	public sealed class ItemNormalityFilter : BaseItemFilter, IMessage<ItemNormalityFilter>, IMessage, IEquatable<ItemNormalityFilter>, IDeepCloneable<ItemNormalityFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private static readonly MessageParser<ItemNormalityFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private static readonly FieldCodec<Normality> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private readonly RepeatedField<Normality> values_;

		[Cpp2IlInjected.Token(Token = "0x170003D0")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemNormalityFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001097")]
			[Cpp2IlInjected.Address(RVA = "0x25E6C40", Offset = "0x25E5640", VA = "0x1825E6C40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001098")]
			[Cpp2IlInjected.Address(RVA = "0x25E6B70", Offset = "0x25E5570", VA = "0x1825E6B70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001099")]
			[Cpp2IlInjected.Address(RVA = "0x25E6CA0", Offset = "0x25E56A0", VA = "0x1825E6CA0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D3")]
		[DebuggerNonUserCode]
		public RepeatedField<Normality> Values
		{
			[Cpp2IlInjected.Token(Token = "0x600109D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600109A")]
		[Cpp2IlInjected.Address(RVA = "0x25E6A60", Offset = "0x25E5460", VA = "0x1825E6A60")]
		[DebuggerNonUserCode]
		public ItemNormalityFilter()
		{
			values_ = (RepeatedField<Normality>)(object)new RepeatedField<T>();
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600109B")]
		[Cpp2IlInjected.Address(RVA = "0x25E6AE0", Offset = "0x25E54E0", VA = "0x1825E6AE0")]
		[DebuggerNonUserCode]
		public ItemNormalityFilter(ItemNormalityFilter other)
		{
			RepeatedField<Normality> repeatedField = (values_ = (RepeatedField<Normality>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600109C")]
		[Cpp2IlInjected.Address(RVA = "0x25E60A0", Offset = "0x25E4AA0", VA = "0x1825E60A0", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemNormalityFilter Clone()
		{
			//Discarded unreachable code: IL_002e
			ItemNormalityFilter itemNormalityFilter = new ItemNormalityFilter();
			RepeatedField<Normality> repeatedField = (itemNormalityFilter.values_ = (RepeatedField<Normality>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (itemNormalityFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemNormalityFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x600109E")]
		[Cpp2IlInjected.Address(RVA = "0x25E6360", Offset = "0x25E4D60", VA = "0x1825E6360", Slot = "0")]
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
				RepeatedField<Normality> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600109F")]
		[Cpp2IlInjected.Address(RVA = "0x25E6440", Offset = "0x25E4E40", VA = "0x1825E6440", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemNormalityFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Normality> repeatedField = values_;
				RepeatedField<Normality> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010A0")]
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

		[Cpp2IlInjected.Token(Token = "0x60010A1")]
		[Cpp2IlInjected.Address(RVA = "0x25E6720", Offset = "0x25E5120", VA = "0x1825E6720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60010A2")]
		[Cpp2IlInjected.Address(RVA = "0x25E6780", Offset = "0x25E5180", VA = "0x1825E6780", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Normality> repeatedField = values_;
			FieldCodec<Normality> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60010A3")]
		[Cpp2IlInjected.Address(RVA = "0x25E5F90", Offset = "0x25E4990", VA = "0x1825E5F90", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Normality> repeatedField = values_;
			FieldCodec<Normality> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60010A4")]
		[Cpp2IlInjected.Address(RVA = "0x25E6550", Offset = "0x25E4F50", VA = "0x1825E6550", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemNormalityFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Normality> repeatedField = values_;
				RepeatedField<Normality> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010A5")]
		[Cpp2IlInjected.Address(RVA = "0x25E65D0", Offset = "0x25E4FD0", VA = "0x1825E65D0", Slot = "9")]
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
				RepeatedField<Normality> repeatedField = values_;
				FieldCodec<Normality> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010A6")]
		[Cpp2IlInjected.Address(RVA = "0x25E64D0", Offset = "0x25E4ED0", VA = "0x1825E64D0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Normality> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010A7")]
		[Cpp2IlInjected.Address(RVA = "0x25E66C0", Offset = "0x25E50C0", VA = "0x1825E66C0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x60010A8")]
		[Cpp2IlInjected.Address(RVA = "0x25E6040", Offset = "0x25E4A40", VA = "0x1825E6040", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Normality> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010A9")]
		[Cpp2IlInjected.Address(RVA = "0x25E6260", Offset = "0x25E4C60", VA = "0x1825E6260", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0028
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					RepeatedField<Normality> repeatedField = values_;
					bool flag = default(bool);
					if (flag)
					{
						int num2 = 0;
					}
				}
				return true;
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60010AA")]
		[Cpp2IlInjected.Address(RVA = "0x25E6160", Offset = "0x25E4B60", VA = "0x1825E6160", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					RepeatedField<Normality> repeatedField = values_;
					bool flag = default(bool);
					if (flag)
					{
						return true;
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60010AB")]
		[Cpp2IlInjected.Address(RVA = "0x25E6840", Offset = "0x25E5240", VA = "0x1825E6840")]
		static ItemNormalityFilter()
		{
			Func<ItemNormalityFilter> func = default(Func<ItemNormalityFilter>);
			MessageParser<ItemNormalityFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ItemNormalityFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<Normality, int> func2 = (Func<Normality, int>)(object)(Func<T, TResult>)((Normality x) => (int)x);
			Func<int, Normality> func3 = (Func<int, Normality>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ItemNormalityFilter>)(object)FieldCodec.ForEnum<Normality>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
