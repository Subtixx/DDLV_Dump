using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	public sealed class ItemAllTagsFilter : BaseItemFilter, IMessage<ItemAllTagsFilter>, IMessage, IEquatable<ItemAllTagsFilter>, IDeepCloneable<ItemAllTagsFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private static readonly MessageParser<ItemAllTagsFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private static readonly FieldCodec<int> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private readonly RepeatedField<int> values_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170003E0")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemAllTagsFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600110C")]
			[Cpp2IlInjected.Address(RVA = "0x27C1920", Offset = "0x27C0320", VA = "0x1827C1920")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600110D")]
			[Cpp2IlInjected.Address(RVA = "0x27C1850", Offset = "0x27C0250", VA = "0x1827C1850")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600110E")]
			[Cpp2IlInjected.Address(RVA = "0x27C1980", Offset = "0x27C0380", VA = "0x1827C1980", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E3")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6001112")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600110F")]
		[Cpp2IlInjected.Address(RVA = "0x27C17D0", Offset = "0x27C01D0", VA = "0x1827C17D0")]
		[DebuggerNonUserCode]
		public ItemAllTagsFilter()
		{
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001110")]
		[Cpp2IlInjected.Address(RVA = "0x27C16D0", Offset = "0x27C00D0", VA = "0x1827C16D0")]
		[DebuggerNonUserCode]
		public ItemAllTagsFilter(ItemAllTagsFilter other)
		{
			((ServiceContainer)(object)this)._002Ector();
			RepeatedField<int> repeatedField = (values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001111")]
		[Cpp2IlInjected.Address(RVA = "0x27C0D80", Offset = "0x27BF780", VA = "0x1827C0D80", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemAllTagsFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			ItemAllTagsFilter itemAllTagsFilter = new ItemAllTagsFilter();
			RepeatedField<int> repeatedField = (itemAllTagsFilter.values_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (itemAllTagsFilter.values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (itemAllTagsFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemAllTagsFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001113")]
		[Cpp2IlInjected.Address(RVA = "0x27C1140", Offset = "0x27BFB40", VA = "0x1827C1140", Slot = "0")]
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
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001114")]
		[Cpp2IlInjected.Address(RVA = "0x27C10B0", Offset = "0x27BFAB0", VA = "0x1827C10B0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemAllTagsFilter other)
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
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001115")]
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

		[Cpp2IlInjected.Token(Token = "0x6001116")]
		[Cpp2IlInjected.Address(RVA = "0x27C1470", Offset = "0x27BFE70", VA = "0x1827C1470", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001117")]
		[Cpp2IlInjected.Address(RVA = "0x27C14D0", Offset = "0x27BFED0", VA = "0x1827C14D0", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = values_;
			FieldCodec<int> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001118")]
		[Cpp2IlInjected.Address(RVA = "0x27C0C70", Offset = "0x27BF670", VA = "0x1827C0C70", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6001119")]
		[Cpp2IlInjected.Address(RVA = "0x27C1390", Offset = "0x27BFD90", VA = "0x1827C1390", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemAllTagsFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = values_;
				RepeatedField<int> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600111A")]
		[Cpp2IlInjected.Address(RVA = "0x27C12A0", Offset = "0x27BFCA0", VA = "0x1827C12A0", Slot = "9")]
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
				RepeatedField<int> repeatedField = values_;
				FieldCodec<int> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600111B")]
		[Cpp2IlInjected.Address(RVA = "0x27C1220", Offset = "0x27BFC20", VA = "0x1827C1220", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600111C")]
		[Cpp2IlInjected.Address(RVA = "0x27C1410", Offset = "0x27BFE10", VA = "0x1827C1410", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x600111D")]
		[Cpp2IlInjected.Address(RVA = "0x27C0D20", Offset = "0x27BF720", VA = "0x1827C0D20", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600111E")]
		[Cpp2IlInjected.Address(RVA = "0x27C0FB0", Offset = "0x27BF9B0", VA = "0x1827C0FB0", Slot = "6")]
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
					Func<int, bool> func = (Func<int, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0009
						IHasTags hasTags = tagItem;
						bool result = default(bool);
						return result;
					};
					if (((IEnumerable<>)(object)repeatedField).All<int>((Func<, >)(object)func))
					{
						int num2 = 0;
					}
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x600111F")]
		[Cpp2IlInjected.Address(RVA = "0x27C0EB0", Offset = "0x27BF8B0", VA = "0x1827C0EB0", Slot = "7")]
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
					Func<int, bool> func = (Func<int, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0009
						IHasTags hasTags = tagItem;
						bool result = default(bool);
						return result;
					};
					if (((IEnumerable<>)(object)repeatedField).All<int>((Func<, >)(object)func))
					{
						return true;
					}
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001120")]
		[Cpp2IlInjected.Address(RVA = "0x27C1590", Offset = "0x27BFF90", VA = "0x1827C1590")]
		static ItemAllTagsFilter()
		{
			Func<ItemAllTagsFilter> func = default(Func<ItemAllTagsFilter>);
			_parser = (MessageParser<ItemAllTagsFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemAllTagsFilter>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
