using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	public sealed class ItemMoodFilter : BaseItemFilter, IMessage<ItemMoodFilter>, IMessage, IEquatable<ItemMoodFilter>, IDeepCloneable<ItemMoodFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private static readonly MessageParser<ItemMoodFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private static readonly FieldCodec<Mood> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private readonly RepeatedField<Mood> values_;

		[Cpp2IlInjected.Token(Token = "0x170003C8")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemMoodFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600105B")]
			[Cpp2IlInjected.Address(RVA = "0x25E3C20", Offset = "0x25E2620", VA = "0x1825E3C20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600105C")]
			[Cpp2IlInjected.Address(RVA = "0x25E3B50", Offset = "0x25E2550", VA = "0x1825E3B50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600105D")]
			[Cpp2IlInjected.Address(RVA = "0x25E3C80", Offset = "0x25E2680", VA = "0x1825E3C80", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CB")]
		[DebuggerNonUserCode]
		public RepeatedField<Mood> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6001061")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600105E")]
		[Cpp2IlInjected.Address(RVA = "0x25E3AD0", Offset = "0x25E24D0", VA = "0x1825E3AD0")]
		[DebuggerNonUserCode]
		public ItemMoodFilter()
		{
			values_ = (RepeatedField<Mood>)(object)new RepeatedField<T>();
			((MarshalByValueComponent)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600105F")]
		[Cpp2IlInjected.Address(RVA = "0x25E3A40", Offset = "0x25E2440", VA = "0x1825E3A40")]
		[DebuggerNonUserCode]
		public ItemMoodFilter(ItemMoodFilter other)
		{
			RepeatedField<Mood> repeatedField = (values_ = (RepeatedField<Mood>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001060")]
		[Cpp2IlInjected.Address(RVA = "0x25E3080", Offset = "0x25E1A80", VA = "0x1825E3080", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemMoodFilter Clone()
		{
			//Discarded unreachable code: IL_002e
			ItemMoodFilter itemMoodFilter = new ItemMoodFilter();
			RepeatedField<Mood> repeatedField = (itemMoodFilter.values_ = (RepeatedField<Mood>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (itemMoodFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemMoodFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001062")]
		[Cpp2IlInjected.Address(RVA = "0x25E3340", Offset = "0x25E1D40", VA = "0x1825E3340", Slot = "0")]
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
				RepeatedField<Mood> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001063")]
		[Cpp2IlInjected.Address(RVA = "0x25E3420", Offset = "0x25E1E20", VA = "0x1825E3420", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemMoodFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Mood> repeatedField = values_;
				RepeatedField<Mood> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001064")]
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

		[Cpp2IlInjected.Token(Token = "0x6001065")]
		[Cpp2IlInjected.Address(RVA = "0x25E3700", Offset = "0x25E2100", VA = "0x1825E3700", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001066")]
		[Cpp2IlInjected.Address(RVA = "0x25E3760", Offset = "0x25E2160", VA = "0x1825E3760", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Mood> repeatedField = values_;
			FieldCodec<Mood> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001067")]
		[Cpp2IlInjected.Address(RVA = "0x25E2F70", Offset = "0x25E1970", VA = "0x1825E2F70", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Mood> repeatedField = values_;
			FieldCodec<Mood> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001068")]
		[Cpp2IlInjected.Address(RVA = "0x25E3620", Offset = "0x25E2020", VA = "0x1825E3620", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemMoodFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Mood> repeatedField = values_;
				RepeatedField<Mood> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001069")]
		[Cpp2IlInjected.Address(RVA = "0x25E3530", Offset = "0x25E1F30", VA = "0x1825E3530", Slot = "9")]
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
				RepeatedField<Mood> repeatedField = values_;
				FieldCodec<Mood> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600106A")]
		[Cpp2IlInjected.Address(RVA = "0x25E34B0", Offset = "0x25E1EB0", VA = "0x1825E34B0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Mood> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600106B")]
		[Cpp2IlInjected.Address(RVA = "0x25E36A0", Offset = "0x25E20A0", VA = "0x1825E36A0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x600106C")]
		[Cpp2IlInjected.Address(RVA = "0x25E3020", Offset = "0x25E1A20", VA = "0x1825E3020", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Mood> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600106D")]
		[Cpp2IlInjected.Address(RVA = "0x25E3240", Offset = "0x25E1C40", VA = "0x1825E3240", Slot = "6")]
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
					RepeatedField<Mood> repeatedField = values_;
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

		[Cpp2IlInjected.Token(Token = "0x600106E")]
		[Cpp2IlInjected.Address(RVA = "0x25E3140", Offset = "0x25E1B40", VA = "0x1825E3140", Slot = "7")]
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
					RepeatedField<Mood> repeatedField = values_;
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

		[Cpp2IlInjected.Token(Token = "0x600106F")]
		[Cpp2IlInjected.Address(RVA = "0x25E3820", Offset = "0x25E2220", VA = "0x1825E3820")]
		static ItemMoodFilter()
		{
			Func<ItemMoodFilter> func = default(Func<ItemMoodFilter>);
			MessageParser<ItemMoodFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ItemMoodFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<Mood, int> func2 = (Func<Mood, int>)(object)(Func<T, TResult>)((Mood x) => (int)x);
			Func<int, Mood> func3 = (Func<int, Mood>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ItemMoodFilter>)(object)FieldCodec.ForEnum<Mood>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
