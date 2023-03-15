using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200050A")]
	public sealed class CustomStepInteraction : IMessage<CustomStepInteraction>, IMessage, IEquatable<CustomStepInteraction>, IDeepCloneable<CustomStepInteraction>, IMessageFieldAccessor, IStringTag, IItemSelector, IStepAmount, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001AED")]
		private static readonly MessageParser<CustomStepInteraction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001AEE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001AEF")]
		public const int TargetItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AF0")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001AF1")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001AF2")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001AF3")]
		public const int UseDifferentItemFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001AF4")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x17001002")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepInteraction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003E63")]
			[Cpp2IlInjected.Address(RVA = "0x34F0100", Offset = "0x34EEB00", VA = "0x1834F0100")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001003")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003E64")]
			[Cpp2IlInjected.Address(RVA = "0x34F0030", Offset = "0x34EEA30", VA = "0x1834F0030")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001004")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003E65")]
			[Cpp2IlInjected.Address(RVA = "0x34F01A0", Offset = "0x34EEBA0", VA = "0x1834F01A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001005")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E6A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E6B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001006")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003E6C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E6D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001007")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E6E")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E6F")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001008")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003E7B")]
			[Cpp2IlInjected.Address(RVA = "0x34F0160", Offset = "0x34EEB60", VA = "0x1834F0160", Slot = "14")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001009")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003E7C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "15")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100A")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003E7D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E66")]
		[Cpp2IlInjected.Address(RVA = "0x34EFF90", Offset = "0x34EE990", VA = "0x1834EFF90")]
		[DebuggerNonUserCode]
		public CustomStepInteraction()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount(1));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E67")]
		[Cpp2IlInjected.Address(RVA = "0x34EFB20", Offset = "0x34EE520", VA = "0x1834EFB20")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount(1));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E68")]
		[Cpp2IlInjected.Address(RVA = "0x34EFE50", Offset = "0x34EE850", VA = "0x1834EFE50")]
		[DebuggerNonUserCode]
		public CustomStepInteraction(CustomStepInteraction other)
		{
			//IL_003d: Expected O, but got I4
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount(1));
			ItemSelector itemSelector2 = other.targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.targetAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			targetAmount_ = stepAmount3;
			bool flag = (useDifferentItem_ = other.useDifferentItem_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E69")]
		[Cpp2IlInjected.Address(RVA = "0x34EF450", Offset = "0x34EDE50", VA = "0x1834EF450", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepInteraction Clone()
		{
			//Discarded unreachable code: IL_0084
			//IL_003f: Expected O, but got I4
			CustomStepInteraction customStepInteraction = new CustomStepInteraction();
			ItemSelector itemSelector = (customStepInteraction.targetItem_ = new ItemSelector());
			StepAmount stepAmount = (customStepInteraction.targetAmount_ = new StepAmount(1));
			ItemSelector itemSelector2 = targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			customStepInteraction.targetItem_ = (ItemSelector)num;
			StepAmount stepAmount2 = targetAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepInteraction.targetAmount_ = stepAmount3;
			bool flag = (customStepInteraction.useDifferentItem_ = useDifferentItem_);
			UnknownFieldSet unknownFieldSet = (customStepInteraction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E70")]
		[Cpp2IlInjected.Address(RVA = "0x34EF6E0", Offset = "0x34EE0E0", VA = "0x1834EF6E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(targetItem_, other))
				{
					bool flag = object.Equals(targetAmount_, other);
					if (flag && useDifferentItem_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E71")]
		[Cpp2IlInjected.Address(RVA = "0x2725FC0", Offset = "0x27249C0", VA = "0x182725FC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepInteraction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.targetItem_;
				if (object.Equals(targetItem_, objB))
				{
					StepAmount objB2 = other.targetAmount_;
					if (object.Equals(targetAmount_, objB2))
					{
						bool flag = other.useDifferentItem_;
						if (useDifferentItem_ == flag)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E72")]
		[Cpp2IlInjected.Address(RVA = "0x2726AC0", Offset = "0x27254C0", VA = "0x182726AC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = targetAmount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				if (useDifferentItem_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E73")]
		[Cpp2IlInjected.Address(RVA = "0x34EFCE0", Offset = "0x34EE6E0", VA = "0x1834EFCE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E74")]
		[Cpp2IlInjected.Address(RVA = "0x2D525E0", Offset = "0x2D50FE0", VA = "0x182D525E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005c
			if ((long)targetItem_ != 0)
			{
				ItemSelector value = targetItem_;
				output.WriteMessage(value);
			}
			if ((long)targetAmount_ != 0)
			{
				StepAmount value2 = targetAmount_;
				output.WriteMessage(value2);
			}
			if (useDifferentItem_)
			{
				bool value3 = useDifferentItem_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E75")]
		[Cpp2IlInjected.Address(RVA = "0x34EF370", Offset = "0x34EDD70", VA = "0x1834EF370", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = targetItem_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
				}
				StepAmount stepAmount = targetAmount_;
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

		[Cpp2IlInjected.Token(Token = "0x6003E76")]
		[Cpp2IlInjected.Address(RVA = "0x34EF9E0", Offset = "0x34EE3E0", VA = "0x1834EF9E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepInteraction other)
		{
			//Discarded unreachable code: IL_00b0
			if (other == null)
			{
				return;
			}
			if ((long)other.targetItem_ != 0)
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (targetItem_ = new ItemSelector());
					ItemSelector itemSelector3 = targetItem_;
				}
				ItemSelector other2 = other.targetItem_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					stepAmount2 = targetAmount_;
				}
				StepAmount other3 = other.targetAmount_;
				stepAmount2.MergeFrom(other3);
			}
			bool flag = other.useDifferentItem_;
			if (flag)
			{
				useDifferentItem_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003E77")]
		[Cpp2IlInjected.Address(RVA = "0x34EF890", Offset = "0x34EE290", VA = "0x1834EF890", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_008e
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (targetItem_ = new ItemSelector());
				}
				input.ReadMessage(itemSelector);
			}
			StepAmount stepAmount = default(StepAmount);
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (targetAmount_ == null)
				{
					stepAmount = (targetAmount_ = new StepAmount());
					builder = targetAmount_;
				}
				input.ReadMessage(builder);
			}
			if ((long)stepAmount == 24)
			{
				bool flag = (useDifferentItem_ = input.ReadBool());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003E78")]
		[Cpp2IlInjected.Address(RVA = "0x34EF7B0", Offset = "0x34EE1B0", VA = "0x1834EF7B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					bool flag = useDifferentItem_;
				}
				StepAmount stepAmount = targetAmount_;
			}
			ItemSelector itemSelector = targetItem_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E79")]
		[Cpp2IlInjected.Address(RVA = "0x34EFBC0", Offset = "0x34EE5C0", VA = "0x1834EFBC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			//IL_0029: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					useDifferentItem_ = (byte)(int)obj != 0;
					break;
				}
				case 0:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						targetAmount_ = (StepAmount)num2;
						break;
					}
					throw new InvalidCastException();
				}
				}
				return;
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E7A")]
		[Cpp2IlInjected.Address(RVA = "0x2D51C90", Offset = "0x2D50690", VA = "0x182D51C90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				useDifferentItem_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E7E")]
		[Cpp2IlInjected.Address(RVA = "0x34EF5C0", Offset = "0x34EDFC0", VA = "0x1834EF5C0", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_005a
			if (useDifferentItem_)
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector != null && (itemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Item || (itemSelector != null && itemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.ItemGenerator)))
				{
					context.AddInvalidMemberError("Cannot be used with an Item generator", "UseDifferentItem");
				}
				if (targetAmount_.IsValueSmallerThen(2))
				{
					context.AddInvalidMemberError("Must be 2+ when used with UseDifferentItem", "TargetAmount");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E7F")]
		[Cpp2IlInjected.Address(RVA = "0x34EF6A0", Offset = "0x34EE0A0", VA = "0x1834EF6A0")]
		public static bool EDITOR_IsValidInteractionItem(Item item)
		{
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.ActivityItem)
			{
				return true;
			}
			ItemType itemType2 = default(ItemType);
			return itemType2 == ItemType.Furniture;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E80")]
		[Cpp2IlInjected.Address(RVA = "0x34EFD40", Offset = "0x34EE740", VA = "0x1834EFD40")]
		static CustomStepInteraction()
		{
			Func<CustomStepInteraction> func = default(Func<CustomStepInteraction>);
			_parser = (MessageParser<CustomStepInteraction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
