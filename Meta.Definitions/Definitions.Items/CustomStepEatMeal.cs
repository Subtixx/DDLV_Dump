using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004D3")]
	public sealed class CustomStepEatMeal : IMessage<CustomStepEatMeal>, IMessage, IEquatable<CustomStepEatMeal>, IDeepCloneable<CustomStepEatMeal>, IMessageFieldAccessor, IStepAmount, IStringTag, IItemSelector
	{
		[Cpp2IlInjected.Token(Token = "0x40019BD")]
		private static readonly MessageParser<CustomStepEatMeal> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40019BE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40019BF")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019C0")]
		private ItemSelector item_;

		[Cpp2IlInjected.Token(Token = "0x40019C1")]
		public const int ItemAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019C2")]
		private StepAmount itemAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000F33")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepEatMeal> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003B64")]
			[Cpp2IlInjected.Address(RVA = "0x34E0E00", Offset = "0x34DF800", VA = "0x1834E0E00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F34")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B65")]
			[Cpp2IlInjected.Address(RVA = "0x34E0D30", Offset = "0x34DF730", VA = "0x1834E0D30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F35")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B66")]
			[Cpp2IlInjected.Address(RVA = "0x34E1000", Offset = "0x34DFA00", VA = "0x1834E1000", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F36")]
		[DebuggerNonUserCode]
		public ItemSelector Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003B6B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B6C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				item_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F37")]
		[DebuggerNonUserCode]
		public StepAmount ItemAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003B6D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B6E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F38")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003B7A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "14")]
			get
			{
				return itemAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F39")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003B7B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "16")]
			get
			{
				return item_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3A")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003B7C")]
			[Cpp2IlInjected.Address(RVA = "0x34E0E60", Offset = "0x34DF860", VA = "0x1834E0E60", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[1] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[2] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B67")]
		[Cpp2IlInjected.Address(RVA = "0x34E0B60", Offset = "0x34DF560", VA = "0x1834E0B60")]
		[DebuggerNonUserCode]
		public CustomStepEatMeal()
		{
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (itemAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B68")]
		[Cpp2IlInjected.Address(RVA = "0x34E08A0", Offset = "0x34DF2A0", VA = "0x1834E08A0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (itemAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B69")]
		[Cpp2IlInjected.Address(RVA = "0x34E0C00", Offset = "0x34DF600", VA = "0x1834E0C00")]
		[DebuggerNonUserCode]
		public CustomStepEatMeal(CustomStepEatMeal other)
		{
			//IL_003c: Expected O, but got I4
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (itemAmount_ = new StepAmount());
			ItemSelector itemSelector2 = other.item_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			item_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.itemAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			itemAmount_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B6A")]
		[Cpp2IlInjected.Address(RVA = "0x34E0380", Offset = "0x34DED80", VA = "0x1834E0380", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepEatMeal Clone()
		{
			//Discarded unreachable code: IL_0073
			//IL_003e: Expected O, but got I4
			CustomStepEatMeal customStepEatMeal = new CustomStepEatMeal();
			ItemSelector itemSelector = (customStepEatMeal.item_ = new ItemSelector());
			StepAmount stepAmount = (customStepEatMeal.itemAmount_ = new StepAmount());
			ItemSelector itemSelector2 = item_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			customStepEatMeal.item_ = (ItemSelector)num;
			StepAmount stepAmount2 = itemAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepEatMeal.itemAmount_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (customStepEatMeal._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepEatMeal;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B6F")]
		[Cpp2IlInjected.Address(RVA = "0x34E04E0", Offset = "0x34DEEE0", VA = "0x1834E04E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(item_, other) && object.Equals(itemAmount_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B70")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepEatMeal other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.item_;
				if (object.Equals(item_, objB))
				{
					StepAmount objB2 = other.itemAmount_;
					if (object.Equals(itemAmount_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B71")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = item_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = itemAmount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B72")]
		[Cpp2IlInjected.Address(RVA = "0x34E09F0", Offset = "0x34DF3F0", VA = "0x1834E09F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B73")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)item_ != 0)
			{
				ItemSelector value = item_;
				output.WriteMessage(value);
			}
			if ((long)itemAmount_ != 0)
			{
				StepAmount value2 = itemAmount_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B74")]
		[Cpp2IlInjected.Address(RVA = "0x34E02B0", Offset = "0x34DECB0", VA = "0x1834E02B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = item_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
				}
				StepAmount stepAmount = itemAmount_;
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

		[Cpp2IlInjected.Token(Token = "0x6003B75")]
		[Cpp2IlInjected.Address(RVA = "0x34E0770", Offset = "0x34DF170", VA = "0x1834E0770", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepEatMeal other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.item_ != 0)
			{
				ItemSelector itemSelector = item_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (item_ = new ItemSelector());
					ItemSelector itemSelector3 = item_;
				}
				ItemSelector other2 = other.item_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.itemAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (itemAmount_ == null)
				{
					StepAmount stepAmount = (itemAmount_ = new StepAmount());
					stepAmount2 = itemAmount_;
				}
				StepAmount other3 = other.itemAmount_;
				stepAmount2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003B76")]
		[Cpp2IlInjected.Address(RVA = "0x34E0630", Offset = "0x34DF030", VA = "0x1834E0630", Slot = "5")]
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
				ItemSelector itemSelector = item_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (item_ = new ItemSelector());
				}
				input.ReadMessage(itemSelector);
			}
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (itemAmount_ == null)
				{
					StepAmount stepAmount = (itemAmount_ = new StepAmount());
					builder = itemAmount_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003B77")]
		[Cpp2IlInjected.Address(RVA = "0x34E05A0", Offset = "0x34DEFA0", VA = "0x1834E05A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemSelector itemSelector = item_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount = itemAmount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B78")]
		[Cpp2IlInjected.Address(RVA = "0x34E0930", Offset = "0x34DF330", VA = "0x1834E0930", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					item_ = (ItemSelector)num;
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

		[Cpp2IlInjected.Token(Token = "0x6003B79")]
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

		[Cpp2IlInjected.Token(Token = "0x6003B7D")]
		[Cpp2IlInjected.Address(RVA = "0x34E0A50", Offset = "0x34DF450", VA = "0x1834E0A50")]
		static CustomStepEatMeal()
		{
			Func<CustomStepEatMeal> func = default(Func<CustomStepEatMeal>);
			_parser = (MessageParser<CustomStepEatMeal>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
