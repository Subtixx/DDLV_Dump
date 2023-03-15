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
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	public sealed class ItemIdFilter : BaseItemFilter, IMessage<ItemIdFilter>, IMessage, IEquatable<ItemIdFilter>, IDeepCloneable<ItemIdFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private static readonly MessageParser<ItemIdFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private static readonly FieldCodec<int> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private readonly RepeatedField<int> values_;

		[Cpp2IlInjected.Token(Token = "0x1700038B")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemIdFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000EF2")]
			[Cpp2IlInjected.Address(RVA = "0x25DE250", Offset = "0x25DCC50", VA = "0x1825DE250")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000EF3")]
			[Cpp2IlInjected.Address(RVA = "0x25DE180", Offset = "0x25DCB80", VA = "0x1825DE180")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000EF4")]
			[Cpp2IlInjected.Address(RVA = "0x25DE2B0", Offset = "0x25DCCB0", VA = "0x1825DE2B0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038E")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EF8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF5")]
		[Cpp2IlInjected.Address(RVA = "0x25DE100", Offset = "0x25DCB00", VA = "0x1825DE100")]
		[DebuggerNonUserCode]
		public ItemIdFilter()
		{
			values_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF6")]
		[Cpp2IlInjected.Address(RVA = "0x25DE070", Offset = "0x25DCA70", VA = "0x1825DE070")]
		[DebuggerNonUserCode]
		public ItemIdFilter(ItemIdFilter other)
		{
			RepeatedField<int> repeatedField = (values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF7")]
		[Cpp2IlInjected.Address(RVA = "0x25DD770", Offset = "0x25DC170", VA = "0x1825DD770", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemIdFilter Clone()
		{
			//Discarded unreachable code: IL_002e
			ItemIdFilter itemIdFilter = new ItemIdFilter();
			RepeatedField<int> repeatedField = (itemIdFilter.values_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (itemIdFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemIdFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF9")]
		[Cpp2IlInjected.Address(RVA = "0x25DDA20", Offset = "0x25DC420", VA = "0x1825DDA20", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000EFA")]
		[Cpp2IlInjected.Address(RVA = "0x25DD990", Offset = "0x25DC390", VA = "0x1825DD990", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemIdFilter other)
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

		[Cpp2IlInjected.Token(Token = "0x6000EFB")]
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

		[Cpp2IlInjected.Token(Token = "0x6000EFC")]
		[Cpp2IlInjected.Address(RVA = "0x25DDD50", Offset = "0x25DC750", VA = "0x1825DDD50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFD")]
		[Cpp2IlInjected.Address(RVA = "0x25DDE70", Offset = "0x25DC870", VA = "0x1825DDE70", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = values_;
			FieldCodec<int> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFE")]
		[Cpp2IlInjected.Address(RVA = "0x25DD660", Offset = "0x25DC060", VA = "0x1825DD660", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6000EFF")]
		[Cpp2IlInjected.Address(RVA = "0x25DDC70", Offset = "0x25DC670", VA = "0x1825DDC70", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemIdFilter other)
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

		[Cpp2IlInjected.Token(Token = "0x6000F00")]
		[Cpp2IlInjected.Address(RVA = "0x25DDB80", Offset = "0x25DC580", VA = "0x1825DDB80", Slot = "9")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F01")]
		[Cpp2IlInjected.Address(RVA = "0x25DDB00", Offset = "0x25DC500", VA = "0x1825DDB00", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F02")]
		[Cpp2IlInjected.Address(RVA = "0x25DDCF0", Offset = "0x25DC6F0", VA = "0x1825DDCF0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F03")]
		[Cpp2IlInjected.Address(RVA = "0x25DD710", Offset = "0x25DC110", VA = "0x1825DD710", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F04")]
		[Cpp2IlInjected.Address(RVA = "0x25DD8E0", Offset = "0x25DC2E0", VA = "0x1825DD8E0", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_0016
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0019
				//IL_0015: Expected O, but got I4
				RepeatedField<int> repeatedField = values_;
				int itemID_ = x.itemID_;
				return !((RepeatedField<T>)(object)repeatedField).Contains((T)itemID_);
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F05")]
		[Cpp2IlInjected.Address(RVA = "0x25DD830", Offset = "0x25DC230", VA = "0x1825DD830", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_0016
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0016
				//IL_0015: Expected O, but got I4
				RepeatedField<int> repeatedField = values_;
				int itemID_ = x.itemID_;
				return ((RepeatedField<T>)(object)repeatedField).Contains((T)itemID_);
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F06")]
		[Cpp2IlInjected.Address(RVA = "0x25DDF30", Offset = "0x25DC930", VA = "0x1825DDF30")]
		static ItemIdFilter()
		{
			Func<ItemIdFilter> func = default(Func<ItemIdFilter>);
			_parser = (MessageParser<ItemIdFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemIdFilter>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
