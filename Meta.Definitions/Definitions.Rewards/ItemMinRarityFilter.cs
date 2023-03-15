using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public sealed class ItemMinRarityFilter : BaseItemFilter, IMessage<ItemMinRarityFilter>, IMessage, IEquatable<ItemMinRarityFilter>, IDeepCloneable<ItemMinRarityFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private static readonly MessageParser<ItemMinRarityFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public const int ValueFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private int value_;

		[Cpp2IlInjected.Token(Token = "0x170003D4")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemMinRarityFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60010B5")]
			[Cpp2IlInjected.Address(RVA = "0x25E2E00", Offset = "0x25E1800", VA = "0x1825E2E00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60010B6")]
			[Cpp2IlInjected.Address(RVA = "0x25E2D30", Offset = "0x25E1730", VA = "0x1825E2D30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60010B7")]
			[Cpp2IlInjected.Address(RVA = "0x25E2E60", Offset = "0x25E1860", VA = "0x1825E2E60", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D7")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x60010BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x60010BC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				value_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010B8")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		[DebuggerNonUserCode]
		public ItemMinRarityFilter()
		{
			((System.TypeNames.ATypeName)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60010B9")]
		[Cpp2IlInjected.Address(RVA = "0x25E1AB0", Offset = "0x25E04B0", VA = "0x1825E1AB0")]
		[DebuggerNonUserCode]
		public ItemMinRarityFilter(ItemMinRarityFilter other)
		{
			((System.TypeNames.ATypeName)(object)this)._002Ector();
			int num = (value_ = other.value_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010BA")]
		[Cpp2IlInjected.Address(RVA = "0x25E2780", Offset = "0x25E1180", VA = "0x1825E2780", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemMinRarityFilter Clone()
		{
			//Discarded unreachable code: IL_0029
			ItemMinRarityFilter itemMinRarityFilter = new ItemMinRarityFilter();
			int num = (itemMinRarityFilter.value_ = value_);
			UnknownFieldSet unknownFieldSet = (itemMinRarityFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemMinRarityFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x60010BD")]
		[Cpp2IlInjected.Address(RVA = "0x25E2A00", Offset = "0x25E1400", VA = "0x1825E2A00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)value_ == (IntPtr)typeof(ItemMinRarityFilter).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010BE")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemMinRarityFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.value_;
				if (value_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (value_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60010C0")]
		[Cpp2IlInjected.Address(RVA = "0x25E2BC0", Offset = "0x25E15C0", VA = "0x1825E2BC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60010C1")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (value_ != 0)
			{
				int value = value_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60010C2")]
		[Cpp2IlInjected.Address(RVA = "0x25E26E0", Offset = "0x25E10E0", VA = "0x1825E26E0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = value_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60010C3")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemMinRarityFilter other)
		{
			if (other != null)
			{
				int num = other.value_;
				if (num != 0)
				{
					value_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (value_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010C5")]
		[Cpp2IlInjected.Address(RVA = "0x25E2A90", Offset = "0x25E1490", VA = "0x1825E2A90", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = value_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010C6")]
		[Cpp2IlInjected.Address(RVA = "0x25E2B40", Offset = "0x25E1540", VA = "0x1825E2B40", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				value_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				value_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010C8")]
		[Cpp2IlInjected.Address(RVA = "0x25E2900", Offset = "0x25E1300", VA = "0x1825E2900", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0023
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					int num2 = value_;
					int num3 = 0;
				}
				return true;
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60010C9")]
		[Cpp2IlInjected.Address(RVA = "0x25E2800", Offset = "0x25E1200", VA = "0x1825E2800", Slot = "7")]
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
					int num2 = value_;
					return true;
				}
				int num3 = 0;
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60010CA")]
		[Cpp2IlInjected.Address(RVA = "0x25E2C20", Offset = "0x25E1620", VA = "0x1825E2C20")]
		static ItemMinRarityFilter()
		{
			Func<ItemMinRarityFilter> func = default(Func<ItemMinRarityFilter>);
			_parser = (MessageParser<ItemMinRarityFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
