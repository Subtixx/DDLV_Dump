using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000435")]
	public sealed class AnyMarketableItemSelector : IMessage<AnyMarketableItemSelector>, IMessage, IEquatable<AnyMarketableItemSelector>, IDeepCloneable<AnyMarketableItemSelector>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001709")]
		private static readonly MessageParser<AnyMarketableItemSelector> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400170A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400170B")]
		public const int ItemTypeToGiveFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400170C")]
		private AnyItemSelectorChoices itemTypeToGive_;

		[Cpp2IlInjected.Token(Token = "0x400170D")]
		public const int ItemToGiveFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400170E")]
		private ItemSelector itemToGive_;

		[Cpp2IlInjected.Token(Token = "0x17000D36")]
		[DebuggerNonUserCode]
		public static MessageParser<AnyMarketableItemSelector> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600339B")]
			[Cpp2IlInjected.Address(RVA = "0x26EB7E0", Offset = "0x26EA1E0", VA = "0x1826EB7E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D37")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600339C")]
			[Cpp2IlInjected.Address(RVA = "0x26EB710", Offset = "0x26EA110", VA = "0x1826EB710")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D38")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600339D")]
			[Cpp2IlInjected.Address(RVA = "0x26EB840", Offset = "0x26EA240", VA = "0x1826EB840", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D39")]
		[DebuggerNonUserCode]
		public AnyItemSelectorChoices ItemTypeToGive
		{
			[Cpp2IlInjected.Token(Token = "0x60033A2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemTypeToGive_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033A3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemTypeToGive_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3A")]
		[DebuggerNonUserCode]
		public ItemSelector ItemToGive
		{
			[Cpp2IlInjected.Token(Token = "0x60033A4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemToGive_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033A5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemToGive_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600339E")]
		[Cpp2IlInjected.Address(RVA = "0x26EB5D0", Offset = "0x26E9FD0", VA = "0x1826EB5D0")]
		[DebuggerNonUserCode]
		public AnyMarketableItemSelector()
		{
			ItemSelector itemSelector = (itemToGive_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600339F")]
		[Cpp2IlInjected.Address(RVA = "0x26EB330", Offset = "0x26E9D30", VA = "0x1826EB330")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (itemToGive_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033A0")]
		[Cpp2IlInjected.Address(RVA = "0x26EB640", Offset = "0x26EA040", VA = "0x1826EB640")]
		[DebuggerNonUserCode]
		public AnyMarketableItemSelector(AnyMarketableItemSelector other)
		{
			//IL_003e: Expected O, but got I4
			ItemSelector itemSelector = (itemToGive_ = new ItemSelector());
			AnyItemSelectorChoices anyItemSelectorChoices = (itemTypeToGive_ = other.itemTypeToGive_);
			ItemSelector itemSelector2 = other.itemToGive_;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			int num = 0;
			itemToGive_ = (ItemSelector)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033A1")]
		[Cpp2IlInjected.Address(RVA = "0x26EAEE0", Offset = "0x26E98E0", VA = "0x1826EAEE0", Slot = "10")]
		[DebuggerNonUserCode]
		public AnyMarketableItemSelector Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_003f: Expected O, but got I4
			AnyMarketableItemSelector anyMarketableItemSelector = new AnyMarketableItemSelector();
			ItemSelector itemSelector = (anyMarketableItemSelector.itemToGive_ = new ItemSelector());
			AnyItemSelectorChoices anyItemSelectorChoices = (anyMarketableItemSelector.itemTypeToGive_ = itemTypeToGive_);
			ItemSelector itemSelector2 = itemToGive_;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			int num = 0;
			anyMarketableItemSelector.itemToGive_ = (ItemSelector)num;
			UnknownFieldSet unknownFieldSet = (anyMarketableItemSelector._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return anyMarketableItemSelector;
		}

		[Cpp2IlInjected.Token(Token = "0x60033A6")]
		[Cpp2IlInjected.Address(RVA = "0x26EAFE0", Offset = "0x26E99E0", VA = "0x1826EAFE0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)itemTypeToGive_ == (IntPtr)typeof(AnyMarketableItemSelector).TypeHandle && object.Equals(itemToGive_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033A7")]
		[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AnyMarketableItemSelector other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				AnyItemSelectorChoices anyItemSelectorChoices = other.itemTypeToGive_;
				if (itemTypeToGive_ == anyItemSelectorChoices)
				{
					ItemSelector objB = other.itemToGive_;
					if (object.Equals(itemToGive_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033A8")]
		[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemTypeToGive_ != 0)
				{
				}
				ItemSelector itemSelector = itemToGive_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60033A9")]
		[Cpp2IlInjected.Address(RVA = "0x26EB460", Offset = "0x26E9E60", VA = "0x1826EB460", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60033AA")]
		[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0035
			if (itemTypeToGive_ != 0)
			{
			}
			if ((long)itemToGive_ != 0)
			{
				ItemSelector value = itemToGive_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60033AB")]
		[Cpp2IlInjected.Address(RVA = "0x26EAE10", Offset = "0x26E9810", VA = "0x1826EAE10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				AnyItemSelectorChoices anyItemSelectorChoices = itemTypeToGive_;
				num = 0;
				if (anyItemSelectorChoices != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)anyItemSelectorChoices);
				}
				ItemSelector itemSelector = itemToGive_;
				if (itemSelector != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(itemSelector);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60033AC")]
		[Cpp2IlInjected.Address(RVA = "0x26EB160", Offset = "0x26E9B60", VA = "0x1826EB160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AnyMarketableItemSelector other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			AnyItemSelectorChoices anyItemSelectorChoices = other.itemTypeToGive_;
			if (anyItemSelectorChoices != 0)
			{
				itemTypeToGive_ = anyItemSelectorChoices;
			}
			if ((long)other.itemToGive_ != 0)
			{
				ItemSelector itemSelector2 = default(ItemSelector);
				if (itemToGive_ == null)
				{
					ItemSelector itemSelector = (itemToGive_ = new ItemSelector());
					itemSelector2 = itemToGive_;
				}
				ItemSelector other2 = other.itemToGive_;
				itemSelector2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60033AD")]
		[Cpp2IlInjected.Address(RVA = "0x26EB240", Offset = "0x26E9C40", VA = "0x1826EB240", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (int)(itemTypeToGive_ = (AnyItemSelectorChoices)input.ReadInt32());
			}
			if (num == 18)
			{
				ItemSelector builder = default(ItemSelector);
				if (itemToGive_ == null)
				{
					ItemSelector itemSelector = (itemToGive_ = new ItemSelector());
					builder = itemToGive_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60033AE")]
		[Cpp2IlInjected.Address(RVA = "0x26EB090", Offset = "0x26E9A90", VA = "0x1826EB090", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				AnyItemSelectorChoices anyItemSelectorChoices = itemTypeToGive_;
			}
			if (fieldNumber == 2)
			{
				ItemSelector itemSelector = itemToGive_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033AF")]
		[Cpp2IlInjected.Address(RVA = "0x26EB390", Offset = "0x26E9D90", VA = "0x1826EB390", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				itemTypeToGive_ = (AnyItemSelectorChoices)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				itemToGive_ = (ItemSelector)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033B0")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				itemTypeToGive_ = AnyItemSelectorChoices.BuffElixir;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033B1")]
		[Cpp2IlInjected.Address(RVA = "0x26EB4C0", Offset = "0x26E9EC0", VA = "0x1826EB4C0")]
		static AnyMarketableItemSelector()
		{
			Func<AnyMarketableItemSelector> func = default(Func<AnyMarketableItemSelector>);
			_parser = (MessageParser<AnyMarketableItemSelector>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
