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
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	public sealed class ItemSturdinessFilter : BaseItemFilter, IMessage<ItemSturdinessFilter>, IMessage, IEquatable<ItemSturdinessFilter>, IDeepCloneable<ItemSturdinessFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private static readonly MessageParser<ItemSturdinessFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private static readonly FieldCodec<Sturdiness> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private readonly RepeatedField<Sturdiness> values_ = (RepeatedField<Sturdiness>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170003CC")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemSturdinessFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001079")]
			[Cpp2IlInjected.Address(RVA = "0x6449C0", Offset = "0x6433C0", VA = "0x1806449C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600107A")]
			[Cpp2IlInjected.Address(RVA = "0x6448F0", Offset = "0x6432F0", VA = "0x1806448F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600107B")]
			[Cpp2IlInjected.Address(RVA = "0x644A20", Offset = "0x643420", VA = "0x180644A20", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CF")]
		[DebuggerNonUserCode]
		public RepeatedField<Sturdiness> Values
		{
			[Cpp2IlInjected.Token(Token = "0x600107F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600107C")]
		[Cpp2IlInjected.Address(RVA = "0x644770", Offset = "0x643170", VA = "0x180644770")]
		[DebuggerNonUserCode]
		public ItemSturdinessFilter()
		{
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600107D")]
		[Cpp2IlInjected.Address(RVA = "0x6447F0", Offset = "0x6431F0", VA = "0x1806447F0")]
		[DebuggerNonUserCode]
		public ItemSturdinessFilter(ItemSturdinessFilter other)
		{
			((ServiceContainer)(object)this)._002Ector();
			RepeatedField<Sturdiness> repeatedField = (values_ = (RepeatedField<Sturdiness>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600107E")]
		[Cpp2IlInjected.Address(RVA = "0x643D40", Offset = "0x642740", VA = "0x180643D40", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemSturdinessFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			ItemSturdinessFilter itemSturdinessFilter = new ItemSturdinessFilter();
			RepeatedField<Sturdiness> repeatedField = (itemSturdinessFilter.values_ = (RepeatedField<Sturdiness>)(object)new RepeatedField<T>());
			RepeatedField<Sturdiness> repeatedField2 = (itemSturdinessFilter.values_ = (RepeatedField<Sturdiness>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (itemSturdinessFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemSturdinessFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001080")]
		[Cpp2IlInjected.Address(RVA = "0x644100", Offset = "0x642B00", VA = "0x180644100", Slot = "0")]
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
				RepeatedField<Sturdiness> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001081")]
		[Cpp2IlInjected.Address(RVA = "0x644070", Offset = "0x642A70", VA = "0x180644070", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemSturdinessFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Sturdiness> repeatedField = values_;
				RepeatedField<Sturdiness> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001082")]
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

		[Cpp2IlInjected.Token(Token = "0x6001083")]
		[Cpp2IlInjected.Address(RVA = "0x644430", Offset = "0x642E30", VA = "0x180644430", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001084")]
		[Cpp2IlInjected.Address(RVA = "0x644490", Offset = "0x642E90", VA = "0x180644490", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Sturdiness> repeatedField = values_;
			FieldCodec<Sturdiness> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001085")]
		[Cpp2IlInjected.Address(RVA = "0x643C30", Offset = "0x642630", VA = "0x180643C30", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Sturdiness> repeatedField = values_;
			FieldCodec<Sturdiness> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001086")]
		[Cpp2IlInjected.Address(RVA = "0x644260", Offset = "0x642C60", VA = "0x180644260", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemSturdinessFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Sturdiness> repeatedField = values_;
				RepeatedField<Sturdiness> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001087")]
		[Cpp2IlInjected.Address(RVA = "0x6442E0", Offset = "0x642CE0", VA = "0x1806442E0", Slot = "9")]
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
				RepeatedField<Sturdiness> repeatedField = values_;
				FieldCodec<Sturdiness> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001088")]
		[Cpp2IlInjected.Address(RVA = "0x6441E0", Offset = "0x642BE0", VA = "0x1806441E0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Sturdiness> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001089")]
		[Cpp2IlInjected.Address(RVA = "0x6443D0", Offset = "0x642DD0", VA = "0x1806443D0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x600108A")]
		[Cpp2IlInjected.Address(RVA = "0x643CE0", Offset = "0x6426E0", VA = "0x180643CE0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Sturdiness> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600108B")]
		[Cpp2IlInjected.Address(RVA = "0x643F70", Offset = "0x642970", VA = "0x180643F70", Slot = "6")]
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
					RepeatedField<Sturdiness> repeatedField = values_;
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

		[Cpp2IlInjected.Token(Token = "0x600108C")]
		[Cpp2IlInjected.Address(RVA = "0x643E70", Offset = "0x642870", VA = "0x180643E70", Slot = "7")]
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
					RepeatedField<Sturdiness> repeatedField = values_;
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

		[Cpp2IlInjected.Token(Token = "0x600108D")]
		[Cpp2IlInjected.Address(RVA = "0x644550", Offset = "0x642F50", VA = "0x180644550")]
		static ItemSturdinessFilter()
		{
			Func<ItemSturdinessFilter> func = default(Func<ItemSturdinessFilter>);
			MessageParser<ItemSturdinessFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ItemSturdinessFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<Sturdiness, int> func2 = (Func<Sturdiness, int>)(object)(Func<T, TResult>)((Sturdiness x) => (int)x);
			Func<int, Sturdiness> func3 = (Func<int, Sturdiness>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ItemSturdinessFilter>)(object)FieldCodec.ForEnum<Sturdiness>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
