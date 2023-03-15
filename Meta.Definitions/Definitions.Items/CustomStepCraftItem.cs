using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200049C")]
	public sealed class CustomStepCraftItem : IMessage<CustomStepCraftItem>, IMessage, IEquatable<CustomStepCraftItem>, IDeepCloneable<CustomStepCraftItem>, IMessageFieldAccessor, IStringTag, IItemSelector, IStepAmount, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40018B2")]
		private static readonly MessageParser<CustomStepCraftItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40018B3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40018B4")]
		public const int TargetFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018B5")]
		private ItemSelector target_;

		[Cpp2IlInjected.Token(Token = "0x40018B6")]
		public const int AmountToCraftFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018B7")]
		private StepAmount amountToCraft_;

		[Cpp2IlInjected.Token(Token = "0x17000E6D")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepCraftItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600389A")]
			[Cpp2IlInjected.Address(RVA = "0x2D55930", Offset = "0x2D54330", VA = "0x182D55930")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600389B")]
			[Cpp2IlInjected.Address(RVA = "0x2D55860", Offset = "0x2D54260", VA = "0x182D55860")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600389C")]
			[Cpp2IlInjected.Address(RVA = "0x2D55BA0", Offset = "0x2D545A0", VA = "0x182D55BA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E70")]
		[DebuggerNonUserCode]
		public ItemSelector Target
		{
			[Cpp2IlInjected.Token(Token = "0x60038A1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return target_;
			}
			[Cpp2IlInjected.Token(Token = "0x60038A2")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				target_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E71")]
		[DebuggerNonUserCode]
		public StepAmount AmountToCraft
		{
			[Cpp2IlInjected.Token(Token = "0x60038A3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return amountToCraft_;
			}
			[Cpp2IlInjected.Token(Token = "0x60038A4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				amountToCraft_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E72")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x60038B0")]
			[Cpp2IlInjected.Address(RVA = "0x2D55990", Offset = "0x2D54390", VA = "0x182D55990", Slot = "14")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("CollectedItems" != null && "CollectedItems" == null)
					{
						continue;
					}
					array[1] = "CollectedItems";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[2] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[3] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E73")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x60038B1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "15")]
			get
			{
				return target_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E74")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60038B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return amountToCraft_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600389D")]
		[Cpp2IlInjected.Address(RVA = "0x2D557C0", Offset = "0x2D541C0", VA = "0x182D557C0")]
		[DebuggerNonUserCode]
		public CustomStepCraftItem()
		{
			ItemSelector itemSelector = (target_ = new ItemSelector());
			StepAmount stepAmount = (amountToCraft_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600389E")]
		[Cpp2IlInjected.Address(RVA = "0x2D553D0", Offset = "0x2D53DD0", VA = "0x182D553D0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (target_ = new ItemSelector());
			StepAmount stepAmount = (amountToCraft_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600389F")]
		[Cpp2IlInjected.Address(RVA = "0x2D55690", Offset = "0x2D54090", VA = "0x182D55690")]
		[DebuggerNonUserCode]
		public CustomStepCraftItem(CustomStepCraftItem other)
		{
			//IL_003c: Expected O, but got I4
			ItemSelector itemSelector = (target_ = new ItemSelector());
			StepAmount stepAmount = (amountToCraft_ = new StepAmount());
			ItemSelector itemSelector2 = other.target_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			target_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.amountToCraft_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			amountToCraft_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D54B70", Offset = "0x2D53570", VA = "0x182D54B70", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepCraftItem Clone()
		{
			//Discarded unreachable code: IL_0073
			//IL_003e: Expected O, but got I4
			CustomStepCraftItem customStepCraftItem = new CustomStepCraftItem();
			ItemSelector itemSelector = (customStepCraftItem.target_ = new ItemSelector());
			StepAmount stepAmount = (customStepCraftItem.amountToCraft_ = new StepAmount());
			ItemSelector itemSelector2 = target_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			customStepCraftItem.target_ = (ItemSelector)num;
			StepAmount stepAmount2 = amountToCraft_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepCraftItem.amountToCraft_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (customStepCraftItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepCraftItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60038A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D55010", Offset = "0x2D53A10", VA = "0x182D55010", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(target_, other) && object.Equals(amountToCraft_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038A6")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepCraftItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.target_;
				if (object.Equals(target_, objB))
				{
					StepAmount objB2 = other.amountToCraft_;
					if (object.Equals(amountToCraft_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038A7")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = target_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = amountToCraft_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60038A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D55520", Offset = "0x2D53F20", VA = "0x182D55520", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60038A9")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)target_ != 0)
			{
				ItemSelector value = target_;
				output.WriteMessage(value);
			}
			if ((long)amountToCraft_ != 0)
			{
				StepAmount value2 = amountToCraft_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60038AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D54AA0", Offset = "0x2D534A0", VA = "0x182D54AA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = target_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
				}
				StepAmount stepAmount = amountToCraft_;
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

		[Cpp2IlInjected.Token(Token = "0x60038AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D55160", Offset = "0x2D53B60", VA = "0x182D55160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepCraftItem other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.target_ != 0)
			{
				ItemSelector itemSelector = target_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (target_ = new ItemSelector());
					ItemSelector itemSelector3 = target_;
				}
				ItemSelector other2 = other.target_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.amountToCraft_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amountToCraft_ == null)
				{
					StepAmount stepAmount = (amountToCraft_ = new StepAmount());
					stepAmount2 = amountToCraft_;
				}
				StepAmount other3 = other.amountToCraft_;
				stepAmount2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60038AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D55290", Offset = "0x2D53C90", VA = "0x182D55290", Slot = "5")]
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
				ItemSelector itemSelector = target_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (target_ = new ItemSelector());
				}
				input.ReadMessage(itemSelector);
			}
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (amountToCraft_ == null)
				{
					StepAmount stepAmount = (amountToCraft_ = new StepAmount());
					builder = amountToCraft_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60038AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D550D0", Offset = "0x2D53AD0", VA = "0x182D550D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemSelector itemSelector = target_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount = amountToCraft_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D55460", Offset = "0x2D53E60", VA = "0x182D55460", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					target_ = (ItemSelector)num;
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

		[Cpp2IlInjected.Token(Token = "0x60038AF")]
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

		[Cpp2IlInjected.Token(Token = "0x60038B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D54CD0", Offset = "0x2D536D0", VA = "0x182D54CD0", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0110
			//IL_0100: Expected O, but got I4
			//IL_0100: Expected O, but got I4
			if (target_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.None)
			{
				string missionStepName = context.MissionStepName;
				string message = "Cannot be None in " + missionStepName;
				context.AddInvalidMemberError(message, "Target");
			}
			if (amountToCraft_.IsValueSmallerThen(1) && context.IsMissionStep)
			{
				string missionStepName2 = context.MissionStepName;
				string message2 = "Should be 1+ in " + missionStepName2;
				context.AddInvalidMemberError(message2, "AmountToCraft");
			}
			ItemSelector itemSelector = target_;
			if (itemSelector.itemSelectorCase_ != ItemSelector.ItemSelectorOneofCase.Item || itemSelector.Item.item_.Item == 0)
			{
				return;
			}
			StepAmount stepAmount = amountToCraft_;
			int value = 0;
			if (!stepAmount.IsValueGreaterThen(value))
			{
				return;
			}
			long num = Convert.ToInt64((uint)target_.Item.item_.Item);
			bool flag = default(bool);
			if (flag)
			{
				StepAmount stepAmount2 = amountToCraft_;
				int num2 = 0;
				int value_ = stepAmount2.Value.value_;
				if (num2 != 0)
				{
					string missionStepName3 = context.MissionStepName;
					string message3 = $"Target are crafted {value_} at time but you ask for {value_} in {missionStepName3}";
					context.AddInvalidMemberError(message3, "AmountToCraft");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D55580", Offset = "0x2D53F80", VA = "0x182D55580")]
		static CustomStepCraftItem()
		{
			Func<CustomStepCraftItem> func = default(Func<CustomStepCraftItem>);
			_parser = (MessageParser<CustomStepCraftItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
