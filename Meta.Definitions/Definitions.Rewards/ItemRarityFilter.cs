using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	public sealed class ItemRarityFilter : BaseItemFilter, IMessage<ItemRarityFilter>, IMessage, IEquatable<ItemRarityFilter>, IDeepCloneable<ItemRarityFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private static readonly MessageParser<ItemRarityFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public const int ValueFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private int value_;

		[Cpp2IlInjected.Token(Token = "0x170003DC")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemRarityFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60010EF")]
			[Cpp2IlInjected.Address(RVA = "0x25EC6E0", Offset = "0x25EB0E0", VA = "0x1825EC6E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60010F0")]
			[Cpp2IlInjected.Address(RVA = "0x25EC610", Offset = "0x25EB010", VA = "0x1825EC610")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60010F1")]
			[Cpp2IlInjected.Address(RVA = "0x25EC740", Offset = "0x25EB140", VA = "0x1825EC740", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DF")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x60010F5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x60010F6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				value_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010F2")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		[DebuggerNonUserCode]
		public ItemRarityFilter()
		{
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60010F3")]
		[Cpp2IlInjected.Address(RVA = "0x25E1AB0", Offset = "0x25E04B0", VA = "0x1825E1AB0")]
		[DebuggerNonUserCode]
		public ItemRarityFilter(ItemRarityFilter other)
		{
			((ServiceContainer)(object)this)._002Ector();
			int num = (value_ = other.value_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010F4")]
		[Cpp2IlInjected.Address(RVA = "0x25EC060", Offset = "0x25EAA60", VA = "0x1825EC060", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemRarityFilter Clone()
		{
			//Discarded unreachable code: IL_0029
			ItemRarityFilter itemRarityFilter = new ItemRarityFilter();
			int num = (itemRarityFilter.value_ = value_);
			UnknownFieldSet unknownFieldSet = (itemRarityFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemRarityFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F7")]
		[Cpp2IlInjected.Address(RVA = "0x25EC2E0", Offset = "0x25EACE0", VA = "0x1825EC2E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)value_ == (IntPtr)typeof(ItemRarityFilter).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F8")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemRarityFilter other)
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

		[Cpp2IlInjected.Token(Token = "0x60010F9")]
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

		[Cpp2IlInjected.Token(Token = "0x60010FA")]
		[Cpp2IlInjected.Address(RVA = "0x25EC4A0", Offset = "0x25EAEA0", VA = "0x1825EC4A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60010FB")]
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

		[Cpp2IlInjected.Token(Token = "0x60010FC")]
		[Cpp2IlInjected.Address(RVA = "0x25EBFC0", Offset = "0x25EA9C0", VA = "0x1825EBFC0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60010FD")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemRarityFilter other)
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

		[Cpp2IlInjected.Token(Token = "0x60010FE")]
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

		[Cpp2IlInjected.Token(Token = "0x60010FF")]
		[Cpp2IlInjected.Address(RVA = "0x25EC370", Offset = "0x25EAD70", VA = "0x1825EC370", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x6001100")]
		[Cpp2IlInjected.Address(RVA = "0x25EC420", Offset = "0x25EAE20", VA = "0x1825EC420", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x6001101")]
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

		[Cpp2IlInjected.Token(Token = "0x6001102")]
		[Cpp2IlInjected.Address(RVA = "0x25EC1E0", Offset = "0x25EABE0", VA = "0x1825EC1E0", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0024
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null && (IntPtr)value_ != (IntPtr)itemData)
				{
					int num2 = 0;
				}
				return true;
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001103")]
		[Cpp2IlInjected.Address(RVA = "0x25EC0E0", Offset = "0x25EAAE0", VA = "0x1825EC0E0", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null && (IntPtr)value_ != (IntPtr)itemData)
				{
					return true;
				}
				int num2 = 0;
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001104")]
		[Cpp2IlInjected.Address(RVA = "0x25EC500", Offset = "0x25EAF00", VA = "0x1825EC500")]
		static ItemRarityFilter()
		{
			Func<ItemRarityFilter> func = default(Func<ItemRarityFilter>);
			_parser = (MessageParser<ItemRarityFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
