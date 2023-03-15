using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000483")]
	public sealed class CustomStepSellItem : IMessage<CustomStepSellItem>, IMessage, IEquatable<CustomStepSellItem>, IDeepCloneable<CustomStepSellItem>, IMessageFieldAccessor, IItemSelector, IStepAmount, IStringTag
	{
		[Cpp2IlInjected.Token(Token = "0x400183E")]
		private static readonly MessageParser<CustomStepSellItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400183F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001840")]
		public const int MustSellSpecificItemsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001841")]
		private bool mustSellSpecificItems_;

		[Cpp2IlInjected.Token(Token = "0x4001842")]
		public const int ItemToSellFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001843")]
		private AnyMarketableItemSelector itemToSell_;

		[Cpp2IlInjected.Token(Token = "0x4001844")]
		public const int ItemToGiveAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001845")]
		private StepAmount itemToGiveAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000E12")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepSellItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003741")]
			[Cpp2IlInjected.Address(RVA = "0x31FEAF0", Offset = "0x31FD4F0", VA = "0x1831FEAF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E13")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003742")]
			[Cpp2IlInjected.Address(RVA = "0x31FEA20", Offset = "0x31FD420", VA = "0x1831FEA20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E14")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003743")]
			[Cpp2IlInjected.Address(RVA = "0x31FF160", Offset = "0x31FDB60", VA = "0x1831FF160", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E15")]
		[DebuggerNonUserCode]
		public bool MustSellSpecificItems
		{
			[Cpp2IlInjected.Token(Token = "0x6003748")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return mustSellSpecificItems_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003749")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				mustSellSpecificItems_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E16")]
		[DebuggerNonUserCode]
		public AnyMarketableItemSelector ItemToSell
		{
			[Cpp2IlInjected.Token(Token = "0x600374A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemToSell_;
			}
			[Cpp2IlInjected.Token(Token = "0x600374B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemToSell_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E17")]
		[DebuggerNonUserCode]
		public StepAmount ItemToGiveAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600374C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return itemToGiveAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600374D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				itemToGiveAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E18")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003759")]
			[Cpp2IlInjected.Address(RVA = "0x2D4AD40", Offset = "0x2D49740", VA = "0x182D4AD40", Slot = "14")]
			get
			{
				//Discarded unreachable code: IL_000c
				return itemToSell_.itemToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E19")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600375A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "15")]
			get
			{
				return itemToGiveAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1A")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x600375B")]
			[Cpp2IlInjected.Address(RVA = "0x31FEB50", Offset = "0x31FD550", VA = "0x1831FEB50", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0195
				string[] array;
				while (true)
				{
					array = new string[13];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" != null && "TargetAmount" == null)
					{
						continue;
					}
					array[1] = "TargetAmount";
					if ("CurrentAmount" != null && "CurrentAmount" == null)
					{
						continue;
					}
					array[2] = "CurrentAmount";
					if ("MinRarity" != null && "MinRarity" == null)
					{
						continue;
					}
					array[3] = "MinRarity";
					if ("MaxRarity" != null && "MaxRarity" == null)
					{
						continue;
					}
					array[4] = "MaxRarity";
					if ("FishLocation" != null && "FishLocation" == null)
					{
						continue;
					}
					array[5] = "FishLocation";
					if ("FishConstraint" != null && "FishConstraint" == null)
					{
						continue;
					}
					array[6] = "FishConstraint";
					if ("CropType" != null && "CropType" == null)
					{
						continue;
					}
					array[7] = "CropType";
					if ("FlowerRarity" != null && "FlowerRarity" == null)
					{
						continue;
					}
					array[8] = "FlowerRarity";
					if ("MealType" != null && "MealType" == null)
					{
						continue;
					}
					array[9] = "MealType";
					if ("IngredientType" != null && "IngredientType" == null)
					{
						continue;
					}
					array[10] = "IngredientType";
					if ("MinUnlockLevel" == null || "MinUnlockLevel" != null)
					{
						array[11] = "MinUnlockLevel";
						if ("MaxUnlockLevel" == null || "MaxUnlockLevel" != null)
						{
							break;
						}
					}
				}
				array[12] = "MaxUnlockLevel";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003744")]
		[Cpp2IlInjected.Address(RVA = "0x31FE840", Offset = "0x31FD240", VA = "0x1831FE840")]
		[DebuggerNonUserCode]
		public CustomStepSellItem()
		{
			AnyMarketableItemSelector anyMarketableItemSelector = (itemToSell_ = new AnyMarketableItemSelector());
			StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003745")]
		[Cpp2IlInjected.Address(RVA = "0x31FE480", Offset = "0x31FCE80", VA = "0x1831FE480")]
		private void OnConstruction()
		{
			AnyMarketableItemSelector anyMarketableItemSelector = (itemToSell_ = new AnyMarketableItemSelector());
			StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003746")]
		[Cpp2IlInjected.Address(RVA = "0x31FE8E0", Offset = "0x31FD2E0", VA = "0x1831FE8E0")]
		[DebuggerNonUserCode]
		public CustomStepSellItem(CustomStepSellItem other)
		{
			//IL_004d: Expected O, but got I4
			AnyMarketableItemSelector anyMarketableItemSelector = (itemToSell_ = new AnyMarketableItemSelector());
			StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
			bool flag = other.mustSellSpecificItems_;
			int num = 0;
			mustSellSpecificItems_ = flag;
			AnyMarketableItemSelector anyMarketableItemSelector2 = other.itemToSell_;
			if (anyMarketableItemSelector2 != null)
			{
				AnyMarketableItemSelector anyMarketableItemSelector3 = anyMarketableItemSelector2.Clone();
			}
			itemToSell_ = (AnyMarketableItemSelector)num;
			StepAmount stepAmount2 = other.itemToGiveAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			itemToGiveAmount_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003747")]
		[Cpp2IlInjected.Address(RVA = "0x31FDDB0", Offset = "0x31FC7B0", VA = "0x1831FDDB0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepSellItem Clone()
		{
			//Discarded unreachable code: IL_0084
			//IL_004f: Expected O, but got I4
			CustomStepSellItem customStepSellItem = new CustomStepSellItem();
			AnyMarketableItemSelector anyMarketableItemSelector = (customStepSellItem.itemToSell_ = new AnyMarketableItemSelector());
			StepAmount stepAmount = (customStepSellItem.itemToGiveAmount_ = new StepAmount());
			bool flag = mustSellSpecificItems_;
			int num = 0;
			customStepSellItem.mustSellSpecificItems_ = flag;
			AnyMarketableItemSelector anyMarketableItemSelector2 = itemToSell_;
			if (anyMarketableItemSelector2 != null)
			{
				AnyMarketableItemSelector anyMarketableItemSelector3 = anyMarketableItemSelector2.Clone();
			}
			customStepSellItem.itemToSell_ = (AnyMarketableItemSelector)num;
			StepAmount stepAmount2 = itemToGiveAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepSellItem.itemToGiveAmount_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (customStepSellItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepSellItem;
		}

		[Cpp2IlInjected.Token(Token = "0x600374E")]
		[Cpp2IlInjected.Address(RVA = "0x31FDFA0", Offset = "0x31FC9A0", VA = "0x1831FDFA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(mustSellSpecificItems_ ? 1 : 0) == (IntPtr)typeof(CustomStepSellItem).TypeHandle && object.Equals(itemToSell_, other) && object.Equals(itemToGiveAmount_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600374F")]
		[Cpp2IlInjected.Address(RVA = "0x31FDF20", Offset = "0x31FC920", VA = "0x1831FDF20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepSellItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.mustSellSpecificItems_;
				if (mustSellSpecificItems_ == flag)
				{
					AnyMarketableItemSelector objB = other.itemToSell_;
					if (object.Equals(itemToSell_, objB))
					{
						StepAmount objB2 = other.itemToGiveAmount_;
						if (object.Equals(itemToGiveAmount_, objB2))
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

		[Cpp2IlInjected.Token(Token = "0x6003750")]
		[Cpp2IlInjected.Address(RVA = "0x31FE150", Offset = "0x31FCB50", VA = "0x1831FE150", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (mustSellSpecificItems_)
				{
				}
				AnyMarketableItemSelector anyMarketableItemSelector = itemToSell_;
				if (anyMarketableItemSelector != null)
				{
					int hashCode = anyMarketableItemSelector.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6003751")]
		[Cpp2IlInjected.Address(RVA = "0x31FE620", Offset = "0x31FD020", VA = "0x1831FE620", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003752")]
		[Cpp2IlInjected.Address(RVA = "0x31FE680", Offset = "0x31FD080", VA = "0x1831FE680", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005c
			if (mustSellSpecificItems_)
			{
				bool value = mustSellSpecificItems_;
				output.WriteBool(value);
			}
			if ((long)itemToSell_ != 0)
			{
				AnyMarketableItemSelector value2 = itemToSell_;
				output.WriteMessage(value2);
			}
			if ((long)itemToGiveAmount_ != 0)
			{
				StepAmount value3 = itemToGiveAmount_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003753")]
		[Cpp2IlInjected.Address(RVA = "0x31FDC90", Offset = "0x31FC690", VA = "0x1831FDC90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				AnyMarketableItemSelector anyMarketableItemSelector = itemToSell_;
				if (anyMarketableItemSelector != null)
				{
					int num = CodedOutputStream.ComputeMessageSize(anyMarketableItemSelector);
					num++;
				}
				StepAmount stepAmount = itemToGiveAmount_;
				if (stepAmount != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num2++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x6003754")]
		[Cpp2IlInjected.Address(RVA = "0x31FE340", Offset = "0x31FCD40", VA = "0x1831FE340", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepSellItem other)
		{
			//Discarded unreachable code: IL_00ab
			if (other == null)
			{
				return;
			}
			bool flag = other.mustSellSpecificItems_;
			if (flag)
			{
				mustSellSpecificItems_ = flag;
			}
			if ((long)other.itemToSell_ != 0)
			{
				AnyMarketableItemSelector anyMarketableItemSelector2 = default(AnyMarketableItemSelector);
				if (itemToSell_ == null)
				{
					AnyMarketableItemSelector anyMarketableItemSelector = (itemToSell_ = new AnyMarketableItemSelector());
					anyMarketableItemSelector2 = itemToSell_;
				}
				AnyMarketableItemSelector other2 = other.itemToSell_;
				anyMarketableItemSelector2.MergeFrom(other2);
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
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003755")]
		[Cpp2IlInjected.Address(RVA = "0x31FE1F0", Offset = "0x31FCBF0", VA = "0x1831FE1F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0092
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				bool flag = (mustSellSpecificItems_ = input.ReadBool());
			}
			AnyMarketableItemSelector anyMarketableItemSelector = default(AnyMarketableItemSelector);
			if (num == 18)
			{
				AnyMarketableItemSelector builder = default(AnyMarketableItemSelector);
				if (itemToSell_ == null)
				{
					anyMarketableItemSelector = (itemToSell_ = new AnyMarketableItemSelector());
					builder = itemToSell_;
				}
				input.ReadMessage(builder);
			}
			if ((long)anyMarketableItemSelector == 26)
			{
				StepAmount builder2 = default(StepAmount);
				if (itemToGiveAmount_ == null)
				{
					StepAmount stepAmount = (itemToGiveAmount_ = new StepAmount());
					builder2 = itemToGiveAmount_;
				}
				input.ReadMessage(builder2);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003756")]
		[Cpp2IlInjected.Address(RVA = "0x31FE070", Offset = "0x31FCA70", VA = "0x1831FE070", Slot = "11")]
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
					StepAmount stepAmount = itemToGiveAmount_;
				}
				AnyMarketableItemSelector anyMarketableItemSelector = itemToSell_;
			}
			bool flag = mustSellSpecificItems_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003757")]
		[Cpp2IlInjected.Address(RVA = "0x31FE510", Offset = "0x31FCF10", VA = "0x1831FE510", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0032
			//IL_0021: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						itemToGiveAmount_ = (StepAmount)num2;
						return;
					}
					throw new InvalidCastException();
				}
				default:
					return;
				case 0:
					break;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			object obj = default(object);
			mustSellSpecificItems_ = (byte)(int)obj != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003758")]
		[Cpp2IlInjected.Address(RVA = "0x31FDD70", Offset = "0x31FC770", VA = "0x1831FDD70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600375C")]
		[Cpp2IlInjected.Address(RVA = "0x31FE730", Offset = "0x31FD130", VA = "0x1831FE730")]
		static CustomStepSellItem()
		{
			Func<CustomStepSellItem> func = default(Func<CustomStepSellItem>);
			_parser = (MessageParser<CustomStepSellItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
