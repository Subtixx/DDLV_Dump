using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	public sealed class ItemAnyTagFilter : BaseItemFilter, IMessage<ItemAnyTagFilter>, IMessage, IEquatable<ItemAnyTagFilter>, IDeepCloneable<ItemAnyTagFilter>, IMessageFieldAccessor, IItemFilter, IInvertFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private static readonly MessageParser<ItemAnyTagFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private static readonly FieldCodec<int> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private readonly RepeatedField<int> values_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public const int InvertFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private bool invert_;

		[Cpp2IlInjected.Token(Token = "0x170003E4")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemAnyTagFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600112C")]
			[Cpp2IlInjected.Address(RVA = "0x27C30B0", Offset = "0x27C1AB0", VA = "0x1827C30B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600112D")]
			[Cpp2IlInjected.Address(RVA = "0x27C2FE0", Offset = "0x27C19E0", VA = "0x1827C2FE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600112E")]
			[Cpp2IlInjected.Address(RVA = "0x27C3110", Offset = "0x27C1B10", VA = "0x1827C3110", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E7")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6001132")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E8")]
		[DebuggerNonUserCode]
		public bool Invert
		{
			[Cpp2IlInjected.Token(Token = "0x6001133")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "18")]
			get
			{
				return invert_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001134")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				invert_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600112F")]
		[Cpp2IlInjected.Address(RVA = "0x27C2E60", Offset = "0x27C1860", VA = "0x1827C2E60")]
		[DebuggerNonUserCode]
		public ItemAnyTagFilter()
		{
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001130")]
		[Cpp2IlInjected.Address(RVA = "0x27C2EE0", Offset = "0x27C18E0", VA = "0x1827C2EE0")]
		[DebuggerNonUserCode]
		public ItemAnyTagFilter(ItemAnyTagFilter other)
		{
			((ServiceContainer)(object)this)._002Ector();
			RepeatedField<int> repeatedField = (values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			bool flag = (invert_ = other.invert_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001131")]
		[Cpp2IlInjected.Address(RVA = "0x27C23F0", Offset = "0x27C0DF0", VA = "0x1827C23F0", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemAnyTagFilter Clone()
		{
			//Discarded unreachable code: IL_004b
			ItemAnyTagFilter itemAnyTagFilter = new ItemAnyTagFilter();
			RepeatedField<int> repeatedField = (itemAnyTagFilter.values_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (itemAnyTagFilter.values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)values_).Clone());
			bool flag = (itemAnyTagFilter.invert_ = invert_);
			UnknownFieldSet unknownFieldSet = (itemAnyTagFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemAnyTagFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001135")]
		[Cpp2IlInjected.Address(RVA = "0x27C27C0", Offset = "0x27C11C0", VA = "0x1827C27C0", Slot = "0")]
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
				RepeatedField<int> repeatedField = values_;
				bool flag = default(bool);
				if (flag && invert_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001136")]
		[Cpp2IlInjected.Address(RVA = "0x27C2720", Offset = "0x27C1120", VA = "0x1827C2720", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemAnyTagFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = values_;
				RepeatedField<int> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					bool flag = other.invert_;
					if (invert_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001137")]
		[Cpp2IlInjected.Address(RVA = "0x1BFA7F0", Offset = "0x1BF91F0", VA = "0x181BFA7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002e
			int hashCode = ((RepeatedField<T>)(object)values_).GetHashCode();
			if (invert_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6001138")]
		[Cpp2IlInjected.Address(RVA = "0x27C2BE0", Offset = "0x27C15E0", VA = "0x1827C2BE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001139")]
		[Cpp2IlInjected.Address(RVA = "0x27C2C40", Offset = "0x27C1640", VA = "0x1827C2C40", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			RepeatedField<int> repeatedField = values_;
			FieldCodec<int> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			if (invert_)
			{
				bool value = invert_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600113A")]
		[Cpp2IlInjected.Address(RVA = "0x27C22D0", Offset = "0x27C0CD0", VA = "0x1827C22D0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = values_;
			FieldCodec<int> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600113B")]
		[Cpp2IlInjected.Address(RVA = "0x27C2970", Offset = "0x27C1370", VA = "0x1827C2970", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemAnyTagFilter other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				RepeatedField<int> repeatedField = values_;
				RepeatedField<int> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				bool flag = other.invert_;
				if (flag)
				{
					invert_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600113C")]
		[Cpp2IlInjected.Address(RVA = "0x27C2A00", Offset = "0x27C1400", VA = "0x1827C2A00", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0059
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((long)input != 4294967293L)
			{
				if (num == 16)
				{
					bool flag = (invert_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
			RepeatedField<int> repeatedField = values_;
			FieldCodec<int> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
		}

		[Cpp2IlInjected.Token(Token = "0x600113D")]
		[Cpp2IlInjected.Address(RVA = "0x27C28A0", Offset = "0x27C12A0", VA = "0x1827C28A0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = values_;
			}
			if (fieldNumber == 2)
			{
				bool flag = invert_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600113E")]
		[Cpp2IlInjected.Address(RVA = "0x27C2B10", Offset = "0x27C1510", VA = "0x1827C2B10", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0010
			//IL_000f: Expected I4, but got O
			switch (fieldNumber)
			{
			case 2:
			{
				object obj = default(object);
				invert_ = (byte)(int)obj != 0;
				break;
			}
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600113F")]
		[Cpp2IlInjected.Address(RVA = "0x27C2380", Offset = "0x27C0D80", VA = "0x1827C2380", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0017
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = values_;
			}
			if (fieldNumber == 2)
			{
				invert_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001140")]
		[Cpp2IlInjected.Address(RVA = "0x27C2620", Offset = "0x27C1020", VA = "0x1827C2620", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				IHasTags tagItem = (IHasTags)itemData;
				if ((long)tagItem != 0)
				{
					RepeatedField<int> repeatedField = values_;
					Predicate<int> predicate2 = (Predicate<int>)(object)(Predicate<T>)delegate
					{
						//Discarded unreachable code: IL_0009
						IHasTags hasTags = tagItem;
						bool result = default(bool);
						return result;
					};
					if (((RepeatedField<>)(object)repeatedField).Any<int>((Predicate<>)(object)predicate2))
					{
						int num2 = 0;
					}
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001141")]
		[Cpp2IlInjected.Address(RVA = "0x27C2520", Offset = "0x27C0F20", VA = "0x1827C2520", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				IHasTags tagItem = (IHasTags)itemData;
				if ((long)tagItem != 0)
				{
					RepeatedField<int> repeatedField = values_;
					Predicate<int> predicate2 = (Predicate<int>)(object)(Predicate<T>)delegate
					{
						//Discarded unreachable code: IL_0009
						IHasTags hasTags = tagItem;
						bool result = default(bool);
						return result;
					};
					if (((RepeatedField<>)(object)repeatedField).Any<int>((Predicate<>)(object)predicate2))
					{
						return true;
					}
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001142")]
		[Cpp2IlInjected.Address(RVA = "0x27C2D20", Offset = "0x27C1720", VA = "0x1827C2D20")]
		static ItemAnyTagFilter()
		{
			Func<ItemAnyTagFilter> func = default(Func<ItemAnyTagFilter>);
			_parser = (MessageParser<ItemAnyTagFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemAnyTagFilter>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
