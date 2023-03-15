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
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	public sealed class ItemComplexityFilter : BaseItemFilter, IMessage<ItemComplexityFilter>, IMessage, IEquatable<ItemComplexityFilter>, IDeepCloneable<ItemComplexityFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private static readonly MessageParser<ItemComplexityFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private static readonly FieldCodec<Complexity> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private readonly RepeatedField<Complexity> values_ = (RepeatedField<Complexity>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170003C4")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemComplexityFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600103D")]
			[Cpp2IlInjected.Address(RVA = "0x22C1BC0", Offset = "0x22C05C0", VA = "0x1822C1BC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600103E")]
			[Cpp2IlInjected.Address(RVA = "0x22C1AF0", Offset = "0x22C04F0", VA = "0x1822C1AF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600103F")]
			[Cpp2IlInjected.Address(RVA = "0x22C1C20", Offset = "0x22C0620", VA = "0x1822C1C20", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C7")]
		[DebuggerNonUserCode]
		public RepeatedField<Complexity> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6001043")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001040")]
		[Cpp2IlInjected.Address(RVA = "0x22C1970", Offset = "0x22C0370", VA = "0x1822C1970")]
		[DebuggerNonUserCode]
		public ItemComplexityFilter()
		{
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001041")]
		[Cpp2IlInjected.Address(RVA = "0x22C19F0", Offset = "0x22C03F0", VA = "0x1822C19F0")]
		[DebuggerNonUserCode]
		public ItemComplexityFilter(ItemComplexityFilter other)
		{
			((ServiceContainer)(object)this)._002Ector();
			RepeatedField<Complexity> repeatedField = (values_ = (RepeatedField<Complexity>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001042")]
		[Cpp2IlInjected.Address(RVA = "0x22C0F40", Offset = "0x22BF940", VA = "0x1822C0F40", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemComplexityFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			ItemComplexityFilter itemComplexityFilter = new ItemComplexityFilter();
			RepeatedField<Complexity> repeatedField = (itemComplexityFilter.values_ = (RepeatedField<Complexity>)(object)new RepeatedField<T>());
			RepeatedField<Complexity> repeatedField2 = (itemComplexityFilter.values_ = (RepeatedField<Complexity>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (itemComplexityFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemComplexityFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001044")]
		[Cpp2IlInjected.Address(RVA = "0x22C1300", Offset = "0x22BFD00", VA = "0x1822C1300", Slot = "0")]
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
				RepeatedField<Complexity> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001045")]
		[Cpp2IlInjected.Address(RVA = "0x22C1270", Offset = "0x22BFC70", VA = "0x1822C1270", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemComplexityFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Complexity> repeatedField = values_;
				RepeatedField<Complexity> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001046")]
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

		[Cpp2IlInjected.Token(Token = "0x6001047")]
		[Cpp2IlInjected.Address(RVA = "0x22C1630", Offset = "0x22C0030", VA = "0x1822C1630", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001048")]
		[Cpp2IlInjected.Address(RVA = "0x22C1690", Offset = "0x22C0090", VA = "0x1822C1690", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Complexity> repeatedField = values_;
			FieldCodec<Complexity> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001049")]
		[Cpp2IlInjected.Address(RVA = "0x22C0E30", Offset = "0x22BF830", VA = "0x1822C0E30", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Complexity> repeatedField = values_;
			FieldCodec<Complexity> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600104A")]
		[Cpp2IlInjected.Address(RVA = "0x22C1460", Offset = "0x22BFE60", VA = "0x1822C1460", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemComplexityFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Complexity> repeatedField = values_;
				RepeatedField<Complexity> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600104B")]
		[Cpp2IlInjected.Address(RVA = "0x22C14E0", Offset = "0x22BFEE0", VA = "0x1822C14E0", Slot = "9")]
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
				RepeatedField<Complexity> repeatedField = values_;
				FieldCodec<Complexity> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600104C")]
		[Cpp2IlInjected.Address(RVA = "0x22C13E0", Offset = "0x22BFDE0", VA = "0x1822C13E0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Complexity> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600104D")]
		[Cpp2IlInjected.Address(RVA = "0x22C15D0", Offset = "0x22BFFD0", VA = "0x1822C15D0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x600104E")]
		[Cpp2IlInjected.Address(RVA = "0x22C0EE0", Offset = "0x22BF8E0", VA = "0x1822C0EE0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Complexity> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600104F")]
		[Cpp2IlInjected.Address(RVA = "0x22C1170", Offset = "0x22BFB70", VA = "0x1822C1170", Slot = "6")]
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
					RepeatedField<Complexity> repeatedField = values_;
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

		[Cpp2IlInjected.Token(Token = "0x6001050")]
		[Cpp2IlInjected.Address(RVA = "0x22C1070", Offset = "0x22BFA70", VA = "0x1822C1070", Slot = "7")]
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
					RepeatedField<Complexity> repeatedField = values_;
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

		[Cpp2IlInjected.Token(Token = "0x6001051")]
		[Cpp2IlInjected.Address(RVA = "0x22C1750", Offset = "0x22C0150", VA = "0x1822C1750")]
		static ItemComplexityFilter()
		{
			Func<ItemComplexityFilter> func = default(Func<ItemComplexityFilter>);
			MessageParser<ItemComplexityFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ItemComplexityFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<Complexity, int> func2 = (Func<Complexity, int>)(object)(Func<T, TResult>)((Complexity x) => (int)x);
			Func<int, Complexity> func3 = (Func<int, Complexity>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ItemComplexityFilter>)(object)FieldCodec.ForEnum<Complexity>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
