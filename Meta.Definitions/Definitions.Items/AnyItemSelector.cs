using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000433")]
	public sealed class AnyItemSelector : IMessage<AnyItemSelector>, IMessage, IEquatable<AnyItemSelector>, IDeepCloneable<AnyItemSelector>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001702")]
		private static readonly MessageParser<AnyItemSelector> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001703")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001704")]
		public const int ItemTypeToGiveFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001705")]
		private AnyItemSelectorChoices itemTypeToGive_;

		[Cpp2IlInjected.Token(Token = "0x4001706")]
		public const int ItemToGiveFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001707")]
		private ItemSelector itemToGive_;

		[Cpp2IlInjected.Token(Token = "0x17000D31")]
		[DebuggerNonUserCode]
		public static MessageParser<AnyItemSelector> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003381")]
			[Cpp2IlInjected.Address(RVA = "0x26EACA0", Offset = "0x26E96A0", VA = "0x1826EACA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D32")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003382")]
			[Cpp2IlInjected.Address(RVA = "0x26EABD0", Offset = "0x26E95D0", VA = "0x1826EABD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D33")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003383")]
			[Cpp2IlInjected.Address(RVA = "0x26EAD00", Offset = "0x26E9700", VA = "0x1826EAD00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D34")]
		[DebuggerNonUserCode]
		public AnyItemSelectorChoices ItemTypeToGive
		{
			[Cpp2IlInjected.Token(Token = "0x6003388")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemTypeToGive_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003389")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemTypeToGive_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D35")]
		[DebuggerNonUserCode]
		public ItemSelector ItemToGive
		{
			[Cpp2IlInjected.Token(Token = "0x600338A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemToGive_;
			}
			[Cpp2IlInjected.Token(Token = "0x600338B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemToGive_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003384")]
		[Cpp2IlInjected.Address(RVA = "0x26EAB60", Offset = "0x26E9560", VA = "0x1826EAB60")]
		[DebuggerNonUserCode]
		public AnyItemSelector()
		{
			ItemSelector itemSelector = (itemToGive_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003385")]
		[Cpp2IlInjected.Address(RVA = "0x26EA7F0", Offset = "0x26E91F0", VA = "0x1826EA7F0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (itemToGive_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003386")]
		[Cpp2IlInjected.Address(RVA = "0x26EAA90", Offset = "0x26E9490", VA = "0x1826EAA90")]
		[DebuggerNonUserCode]
		public AnyItemSelector(AnyItemSelector other)
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

		[Cpp2IlInjected.Token(Token = "0x6003387")]
		[Cpp2IlInjected.Address(RVA = "0x26EA3A0", Offset = "0x26E8DA0", VA = "0x1826EA3A0", Slot = "10")]
		[DebuggerNonUserCode]
		public AnyItemSelector Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_003f: Expected O, but got I4
			AnyItemSelector anyItemSelector = new AnyItemSelector();
			ItemSelector itemSelector = (anyItemSelector.itemToGive_ = new ItemSelector());
			AnyItemSelectorChoices anyItemSelectorChoices = (anyItemSelector.itemTypeToGive_ = itemTypeToGive_);
			ItemSelector itemSelector2 = itemToGive_;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			int num = 0;
			anyItemSelector.itemToGive_ = (ItemSelector)num;
			UnknownFieldSet unknownFieldSet = (anyItemSelector._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return anyItemSelector;
		}

		[Cpp2IlInjected.Token(Token = "0x600338C")]
		[Cpp2IlInjected.Address(RVA = "0x26EA4A0", Offset = "0x26E8EA0", VA = "0x1826EA4A0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)itemTypeToGive_ == (IntPtr)typeof(AnyItemSelector).TypeHandle && object.Equals(itemToGive_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600338D")]
		[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AnyItemSelector other)
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

		[Cpp2IlInjected.Token(Token = "0x600338E")]
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

		[Cpp2IlInjected.Token(Token = "0x600338F")]
		[Cpp2IlInjected.Address(RVA = "0x26EA920", Offset = "0x26E9320", VA = "0x1826EA920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003390")]
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

		[Cpp2IlInjected.Token(Token = "0x6003391")]
		[Cpp2IlInjected.Address(RVA = "0x26EA2D0", Offset = "0x26E8CD0", VA = "0x1826EA2D0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6003392")]
		[Cpp2IlInjected.Address(RVA = "0x26EA710", Offset = "0x26E9110", VA = "0x1826EA710", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AnyItemSelector other)
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

		[Cpp2IlInjected.Token(Token = "0x6003393")]
		[Cpp2IlInjected.Address(RVA = "0x26EA620", Offset = "0x26E9020", VA = "0x1826EA620", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6003394")]
		[Cpp2IlInjected.Address(RVA = "0x26EA550", Offset = "0x26E8F50", VA = "0x1826EA550", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6003395")]
		[Cpp2IlInjected.Address(RVA = "0x26EA850", Offset = "0x26E9250", VA = "0x1826EA850", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6003396")]
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

		[Cpp2IlInjected.Token(Token = "0x6003397")]
		[Cpp2IlInjected.Address(RVA = "0x26EA980", Offset = "0x26E9380", VA = "0x1826EA980")]
		static AnyItemSelector()
		{
			Func<AnyItemSelector> func = default(Func<AnyItemSelector>);
			_parser = (MessageParser<AnyItemSelector>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
