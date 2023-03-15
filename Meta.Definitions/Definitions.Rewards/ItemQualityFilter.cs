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
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	public sealed class ItemQualityFilter : BaseItemFilter, IMessage<ItemQualityFilter>, IMessage, IEquatable<ItemQualityFilter>, IDeepCloneable<ItemQualityFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private static readonly MessageParser<ItemQualityFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private static readonly FieldCodec<Quality> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private readonly RepeatedField<Quality> values_;

		[Cpp2IlInjected.Token(Token = "0x170003C0")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemQualityFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600101F")]
			[Cpp2IlInjected.Address(RVA = "0x25EBE50", Offset = "0x25EA850", VA = "0x1825EBE50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001020")]
			[Cpp2IlInjected.Address(RVA = "0x25EBD80", Offset = "0x25EA780", VA = "0x1825EBD80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001021")]
			[Cpp2IlInjected.Address(RVA = "0x25EBEB0", Offset = "0x25EA8B0", VA = "0x1825EBEB0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C3")]
		[DebuggerNonUserCode]
		public RepeatedField<Quality> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6001025")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001022")]
		[Cpp2IlInjected.Address(RVA = "0x25EBD00", Offset = "0x25EA700", VA = "0x1825EBD00")]
		[DebuggerNonUserCode]
		public ItemQualityFilter()
		{
			values_ = (RepeatedField<Quality>)(object)new RepeatedField<T>();
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001023")]
		[Cpp2IlInjected.Address(RVA = "0x25EBC70", Offset = "0x25EA670", VA = "0x1825EBC70")]
		[DebuggerNonUserCode]
		public ItemQualityFilter(ItemQualityFilter other)
		{
			RepeatedField<Quality> repeatedField = (values_ = (RepeatedField<Quality>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001024")]
		[Cpp2IlInjected.Address(RVA = "0x25EB2B0", Offset = "0x25E9CB0", VA = "0x1825EB2B0", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemQualityFilter Clone()
		{
			//Discarded unreachable code: IL_002e
			ItemQualityFilter itemQualityFilter = new ItemQualityFilter();
			RepeatedField<Quality> repeatedField = (itemQualityFilter.values_ = (RepeatedField<Quality>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (itemQualityFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemQualityFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001026")]
		[Cpp2IlInjected.Address(RVA = "0x25EB600", Offset = "0x25EA000", VA = "0x1825EB600", Slot = "0")]
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
				RepeatedField<Quality> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001027")]
		[Cpp2IlInjected.Address(RVA = "0x25EB570", Offset = "0x25E9F70", VA = "0x1825EB570", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemQualityFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Quality> repeatedField = values_;
				RepeatedField<Quality> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001028")]
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

		[Cpp2IlInjected.Token(Token = "0x6001029")]
		[Cpp2IlInjected.Address(RVA = "0x25EB930", Offset = "0x25EA330", VA = "0x1825EB930", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600102A")]
		[Cpp2IlInjected.Address(RVA = "0x25EB990", Offset = "0x25EA390", VA = "0x1825EB990", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Quality> repeatedField = values_;
			FieldCodec<Quality> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600102B")]
		[Cpp2IlInjected.Address(RVA = "0x25EB1A0", Offset = "0x25E9BA0", VA = "0x1825EB1A0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Quality> repeatedField = values_;
			FieldCodec<Quality> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600102C")]
		[Cpp2IlInjected.Address(RVA = "0x25EB760", Offset = "0x25EA160", VA = "0x1825EB760", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemQualityFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Quality> repeatedField = values_;
				RepeatedField<Quality> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600102D")]
		[Cpp2IlInjected.Address(RVA = "0x25EB7E0", Offset = "0x25EA1E0", VA = "0x1825EB7E0", Slot = "9")]
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
				RepeatedField<Quality> repeatedField = values_;
				FieldCodec<Quality> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600102E")]
		[Cpp2IlInjected.Address(RVA = "0x25EB6E0", Offset = "0x25EA0E0", VA = "0x1825EB6E0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Quality> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600102F")]
		[Cpp2IlInjected.Address(RVA = "0x25EB8D0", Offset = "0x25EA2D0", VA = "0x1825EB8D0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x6001030")]
		[Cpp2IlInjected.Address(RVA = "0x25EB250", Offset = "0x25E9C50", VA = "0x1825EB250", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Quality> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001031")]
		[Cpp2IlInjected.Address(RVA = "0x25EB470", Offset = "0x25E9E70", VA = "0x1825EB470", Slot = "6")]
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
					RepeatedField<Quality> repeatedField = values_;
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

		[Cpp2IlInjected.Token(Token = "0x6001032")]
		[Cpp2IlInjected.Address(RVA = "0x25EB370", Offset = "0x25E9D70", VA = "0x1825EB370", Slot = "7")]
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
					RepeatedField<Quality> repeatedField = values_;
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

		[Cpp2IlInjected.Token(Token = "0x6001033")]
		[Cpp2IlInjected.Address(RVA = "0x25EBA50", Offset = "0x25EA450", VA = "0x1825EBA50")]
		static ItemQualityFilter()
		{
			Func<ItemQualityFilter> func = default(Func<ItemQualityFilter>);
			MessageParser<ItemQualityFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ItemQualityFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<Quality, int> func2 = (Func<Quality, int>)(object)(Func<T, TResult>)((Quality x) => (int)x);
			Func<int, Quality> func3 = (Func<int, Quality>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ItemQualityFilter>)(object)FieldCodec.ForEnum<Quality>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
