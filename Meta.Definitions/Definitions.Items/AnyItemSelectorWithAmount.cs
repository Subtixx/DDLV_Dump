using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000437")]
	public sealed class AnyItemSelectorWithAmount : IMessage<AnyItemSelectorWithAmount>, IMessage, IEquatable<AnyItemSelectorWithAmount>, IDeepCloneable<AnyItemSelectorWithAmount>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001710")]
		private static readonly MessageParser<AnyItemSelectorWithAmount> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001711")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001712")]
		public const int ItemToGiveFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001713")]
		private AnyItemSelector itemToGive_;

		[Cpp2IlInjected.Token(Token = "0x4001714")]
		public const int ItemToGiveAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001715")]
		private StepAmount itemToGiveAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000D3B")]
		[DebuggerNonUserCode]
		public static MessageParser<AnyItemSelectorWithAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60033B5")]
			[Cpp2IlInjected.Address(RVA = "0x26EA160", Offset = "0x26E8B60", VA = "0x1826EA160")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60033B6")]
			[Cpp2IlInjected.Address(RVA = "0x26EA090", Offset = "0x26E8A90", VA = "0x1826EA090")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60033B7")]
			[Cpp2IlInjected.Address(RVA = "0x26EA1C0", Offset = "0x26E8BC0", VA = "0x1826EA1C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3E")]
		[DebuggerNonUserCode]
		public AnyItemSelector ItemToGive
		{
			[Cpp2IlInjected.Token(Token = "0x60033BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemToGive_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				itemToGive_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3F")]
		[DebuggerNonUserCode]
		public StepAmount ItemToGiveAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60033BE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemToGiveAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemToGiveAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033B8")]
		[Cpp2IlInjected.Address(RVA = "0x26E9D60", Offset = "0x26E8760", VA = "0x1826E9D60")]
		[DebuggerNonUserCode]
		public AnyItemSelectorWithAmount()
		{
			AnyItemSelector anyItemSelector = new AnyItemSelector();
			ItemSelector itemSelector = (anyItemSelector.itemToGive_ = new ItemSelector());
			itemToGive_ = anyItemSelector;
			StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033B9")]
		[Cpp2IlInjected.Address(RVA = "0x26E9A50", Offset = "0x26E8450", VA = "0x1826E9A50")]
		private void OnConstruction()
		{
			AnyItemSelector anyItemSelector = new AnyItemSelector();
			ItemSelector itemSelector = (anyItemSelector.itemToGive_ = new ItemSelector());
			itemToGive_ = anyItemSelector;
			StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033BA")]
		[Cpp2IlInjected.Address(RVA = "0x26E9E50", Offset = "0x26E8850", VA = "0x1826E9E50")]
		[DebuggerNonUserCode]
		public AnyItemSelectorWithAmount(AnyItemSelectorWithAmount other)
		{
			//IL_0082: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			AnyItemSelector anyItemSelector = new AnyItemSelector();
			ItemSelector itemSelector = (anyItemSelector.itemToGive_ = new ItemSelector());
			itemToGive_ = anyItemSelector;
			StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
			AnyItemSelector anyItemSelector2 = other.itemToGive_;
			if (anyItemSelector2 != null)
			{
				AnyItemSelector anyItemSelector3 = new AnyItemSelector();
				ItemSelector itemSelector2 = (anyItemSelector3.itemToGive_ = new ItemSelector());
				AnyItemSelectorChoices itemTypeToGive_ = anyItemSelector2.itemTypeToGive_;
				int num = 0;
				anyItemSelector3.itemTypeToGive_ = itemTypeToGive_;
				ItemSelector itemSelector3 = anyItemSelector2.itemToGive_;
				if (itemSelector3 != null)
				{
					ItemSelector itemSelector4 = itemSelector3.Clone();
				}
				anyItemSelector3.itemToGive_ = (ItemSelector)num;
				UnknownFieldSet unknownFieldSet = (anyItemSelector3._unknownFields = UnknownFieldSet.Clone(anyItemSelector2._unknownFields));
			}
			int num2 = 0;
			itemToGive_ = (AnyItemSelector)num2;
			StepAmount stepAmount2 = other.itemToGiveAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			itemToGiveAmount_ = stepAmount3;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033BB")]
		[Cpp2IlInjected.Address(RVA = "0x26E9510", Offset = "0x26E7F10", VA = "0x1826E9510", Slot = "10")]
		[DebuggerNonUserCode]
		public AnyItemSelectorWithAmount Clone()
		{
			return new AnyItemSelectorWithAmount(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60033C0")]
		[Cpp2IlInjected.Address(RVA = "0x26E95F0", Offset = "0x26E7FF0", VA = "0x1826E95F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(itemToGive_, other) && object.Equals(itemToGiveAmount_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033C1")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AnyItemSelectorWithAmount other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				AnyItemSelector objB = other.itemToGive_;
				if (object.Equals(itemToGive_, objB))
				{
					StepAmount objB2 = other.itemToGiveAmount_;
					if (object.Equals(itemToGiveAmount_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033C2")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				AnyItemSelector anyItemSelector = itemToGive_;
				if (anyItemSelector != null)
				{
					int hashCode = anyItemSelector.GetHashCode();
				}
				StepAmount stepAmount = itemToGiveAmount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60033C3")]
		[Cpp2IlInjected.Address(RVA = "0x26E9BF0", Offset = "0x26E85F0", VA = "0x1826E9BF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60033C4")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)itemToGive_ != 0)
			{
				AnyItemSelector value = itemToGive_;
				output.WriteMessage(value);
			}
			if ((long)itemToGiveAmount_ != 0)
			{
				StepAmount value2 = itemToGiveAmount_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60033C5")]
		[Cpp2IlInjected.Address(RVA = "0x26E9440", Offset = "0x26E7E40", VA = "0x1826E9440", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				AnyItemSelector anyItemSelector = itemToGive_;
				num = 0;
				if (anyItemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(anyItemSelector);
				}
				StepAmount stepAmount = itemToGiveAmount_;
				if (stepAmount != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60033C6")]
		[Cpp2IlInjected.Address(RVA = "0x26E9880", Offset = "0x26E8280", VA = "0x1826E9880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AnyItemSelectorWithAmount other)
		{
			//Discarded unreachable code: IL_0104
			if (other == null)
			{
				return;
			}
			AnyItemSelector anyItemSelector = other.itemToGive_;
			if (anyItemSelector != null)
			{
				AnyItemSelector anyItemSelector2 = itemToGive_;
				if (anyItemSelector2 == null)
				{
					AnyItemSelector anyItemSelector3 = (itemToGive_ = new AnyItemSelector());
					AnyItemSelector anyItemSelector4 = itemToGive_;
				}
				if (anyItemSelector != null)
				{
					AnyItemSelectorChoices itemTypeToGive_ = anyItemSelector.itemTypeToGive_;
					if (itemTypeToGive_ != 0)
					{
						anyItemSelector2.itemTypeToGive_ = itemTypeToGive_;
					}
					if ((long)anyItemSelector.itemToGive_ != 0)
					{
						ItemSelector itemSelector2 = default(ItemSelector);
						if (anyItemSelector2.itemToGive_ == null)
						{
							ItemSelector itemSelector = (anyItemSelector2.itemToGive_ = new ItemSelector());
							itemSelector2 = anyItemSelector2.itemToGive_;
						}
						ItemSelector other2 = anyItemSelector.itemToGive_;
						itemSelector2.MergeFrom(other2);
					}
					UnknownFieldSet unknownFields = anyItemSelector._unknownFields;
					UnknownFieldSet unknownFieldSet = (anyItemSelector2._unknownFields = UnknownFieldSet.MergeFrom(anyItemSelector2._unknownFields, unknownFields));
				}
			}
			if ((long)other.itemToGiveAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (itemToGiveAmount_ == null)
				{
					StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
					stepAmount2 = itemToGiveAmount_;
				}
				StepAmount other3 = other.itemToGiveAmount_;
				stepAmount2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x60033C7")]
		[Cpp2IlInjected.Address(RVA = "0x26E9740", Offset = "0x26E8140", VA = "0x1826E9740", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				AnyItemSelector anyItemSelector = itemToGive_;
				if (anyItemSelector == null)
				{
					AnyItemSelector anyItemSelector2 = (itemToGive_ = new AnyItemSelector());
				}
				input.ReadMessage(anyItemSelector);
			}
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (itemToGiveAmount_ == null)
				{
					StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
					builder = itemToGiveAmount_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60033C8")]
		[Cpp2IlInjected.Address(RVA = "0x26E96B0", Offset = "0x26E80B0", VA = "0x1826E96B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				AnyItemSelector anyItemSelector = itemToGive_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount = itemToGiveAmount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033C9")]
		[Cpp2IlInjected.Address(RVA = "0x26E9B30", Offset = "0x26E8530", VA = "0x1826E9B30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					itemToGive_ = (AnyItemSelector)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033CA")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033CB")]
		[Cpp2IlInjected.Address(RVA = "0x26E9570", Offset = "0x26E7F70", VA = "0x1826E9570", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0020
			if (itemToGiveAmount_.IsValueSmallerThen(1))
			{
				context.AddInvalidMemberError("Must be positive (1+)", "ItemToGiveAmount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033CC")]
		[Cpp2IlInjected.Address(RVA = "0x26E9C50", Offset = "0x26E8650", VA = "0x1826E9C50")]
		static AnyItemSelectorWithAmount()
		{
			Func<AnyItemSelectorWithAmount> func = default(Func<AnyItemSelectorWithAmount>);
			_parser = (MessageParser<AnyItemSelectorWithAmount>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
