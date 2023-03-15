using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	public sealed class ItemMealFilter : BaseItemFilter, IMessage<ItemMealFilter>, IMessage, IEquatable<ItemMealFilter>, IDeepCloneable<ItemMealFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		private static readonly MessageParser<ItemMealFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170003EF")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemMealFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001170")]
			[Cpp2IlInjected.Address(RVA = "0x25E2320", Offset = "0x25E0D20", VA = "0x1825E2320")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001171")]
			[Cpp2IlInjected.Address(RVA = "0x25E2250", Offset = "0x25E0C50", VA = "0x1825E2250")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001172")]
			[Cpp2IlInjected.Address(RVA = "0x25E2380", Offset = "0x25E0D80", VA = "0x1825E2380", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001173")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		[DebuggerNonUserCode]
		public ItemMealFilter()
		{
			((DecoderExceptionFallback)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001174")]
		[Cpp2IlInjected.Address(RVA = "0x25E2200", Offset = "0x25E0C00", VA = "0x1825E2200")]
		[DebuggerNonUserCode]
		public ItemMealFilter(ItemMealFilter other)
		{
			((DecoderExceptionFallback)(object)this)._002Ector();
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001175")]
		[Cpp2IlInjected.Address(RVA = "0x25E1D40", Offset = "0x25E0740", VA = "0x1825E1D40", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemMealFilter Clone()
		{
			//Discarded unreachable code: IL_001b
			ItemMealFilter itemMealFilter = new ItemMealFilter();
			UnknownFieldSet unknownFieldSet = (itemMealFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemMealFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001176")]
		[Cpp2IlInjected.Address(RVA = "0x25E1FA0", Offset = "0x25E09A0", VA = "0x1825E1FA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001177")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemMealFilter other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001178")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001179")]
		[Cpp2IlInjected.Address(RVA = "0x25E2090", Offset = "0x25E0A90", VA = "0x1825E2090", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600117A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600117B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600117C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemMealFilter other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600117D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600117E")]
		[Cpp2IlInjected.Address(RVA = "0x25E2020", Offset = "0x25E0A20", VA = "0x1825E2020", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600117F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001180")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001181")]
		[Cpp2IlInjected.Address(RVA = "0x25E1EB0", Offset = "0x25E08B0", VA = "0x1825E1EB0", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_0023
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0019
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				int num2 = 0;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
				}
				return num2 == 0;
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001182")]
		[Cpp2IlInjected.Address(RVA = "0x25E1DC0", Offset = "0x25E07C0", VA = "0x1825E1DC0", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_0023
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_001c
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				int num2 = 0;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
				}
				return num2 != 0;
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001183")]
		[Cpp2IlInjected.Address(RVA = "0x25E20F0", Offset = "0x25E0AF0", VA = "0x1825E20F0")]
		static ItemMealFilter()
		{
			Func<ItemMealFilter> func = default(Func<ItemMealFilter>);
			_parser = (MessageParser<ItemMealFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
