using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000492")]
	public sealed class CustomStepConsumeItem : IMessage<CustomStepConsumeItem>, IMessage, IEquatable<CustomStepConsumeItem>, IDeepCloneable<CustomStepConsumeItem>, IMessageFieldAccessor, IItemSelector, IStepAmount, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400188D")]
		private static readonly MessageParser<CustomStepConsumeItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400188E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400188F")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001890")]
		private ItemSelector item_;

		[Cpp2IlInjected.Token(Token = "0x4001891")]
		public const int ItemAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001892")]
		private StepAmount itemAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001893")]
		public const int UseDifferentItemFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001894")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x17000E4F")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepConsumeItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600381B")]
			[Cpp2IlInjected.Address(RVA = "0x2D52A50", Offset = "0x2D51450", VA = "0x182D52A50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E50")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600381C")]
			[Cpp2IlInjected.Address(RVA = "0x2D52980", Offset = "0x2D51380", VA = "0x182D52980")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E51")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600381D")]
			[Cpp2IlInjected.Address(RVA = "0x2D52C50", Offset = "0x2D51650", VA = "0x182D52C50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E52")]
		[DebuggerNonUserCode]
		public ItemSelector Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003822")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003823")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				item_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E53")]
		[DebuggerNonUserCode]
		public StepAmount ItemAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003824")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003825")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E54")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003826")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003827")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E55")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003833")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return item_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E56")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003834")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return itemAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E57")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003835")]
			[Cpp2IlInjected.Address(RVA = "0x2D52AB0", Offset = "0x2D514B0", VA = "0x182D52AB0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x600381E")]
		[Cpp2IlInjected.Address(RVA = "0x2D528E0", Offset = "0x2D512E0", VA = "0x182D528E0")]
		[DebuggerNonUserCode]
		public CustomStepConsumeItem()
		{
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (itemAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600381F")]
		[Cpp2IlInjected.Address(RVA = "0x2D523D0", Offset = "0x2D50DD0", VA = "0x182D523D0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (itemAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003820")]
		[Cpp2IlInjected.Address(RVA = "0x2D527A0", Offset = "0x2D511A0", VA = "0x182D527A0")]
		[DebuggerNonUserCode]
		public CustomStepConsumeItem(CustomStepConsumeItem other)
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
			bool flag = (useDifferentItem_ = other.useDifferentItem_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003821")]
		[Cpp2IlInjected.Address(RVA = "0x2D51CD0", Offset = "0x2D506D0", VA = "0x182D51CD0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepConsumeItem Clone()
		{
			//Discarded unreachable code: IL_0083
			//IL_003e: Expected O, but got I4
			CustomStepConsumeItem customStepConsumeItem = new CustomStepConsumeItem();
			ItemSelector itemSelector = (customStepConsumeItem.item_ = new ItemSelector());
			StepAmount stepAmount = (customStepConsumeItem.itemAmount_ = new StepAmount());
			ItemSelector itemSelector2 = item_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			customStepConsumeItem.item_ = (ItemSelector)num;
			StepAmount stepAmount2 = itemAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepConsumeItem.itemAmount_ = stepAmount3;
			bool flag = (customStepConsumeItem.useDifferentItem_ = useDifferentItem_);
			UnknownFieldSet unknownFieldSet = (customStepConsumeItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepConsumeItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6003828")]
		[Cpp2IlInjected.Address(RVA = "0x2D51F90", Offset = "0x2D50990", VA = "0x182D51F90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(item_, other))
				{
					bool flag = object.Equals(itemAmount_, other);
					if (flag && useDifferentItem_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003829")]
		[Cpp2IlInjected.Address(RVA = "0x2725FC0", Offset = "0x27249C0", VA = "0x182725FC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepConsumeItem other)
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

		[Cpp2IlInjected.Token(Token = "0x600382A")]
		[Cpp2IlInjected.Address(RVA = "0x2726AC0", Offset = "0x27254C0", VA = "0x182726AC0", Slot = "2")]
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
				if (useDifferentItem_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600382B")]
		[Cpp2IlInjected.Address(RVA = "0x2D52580", Offset = "0x2D50F80", VA = "0x182D52580", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600382C")]
		[Cpp2IlInjected.Address(RVA = "0x2D525E0", Offset = "0x2D50FE0", VA = "0x182D525E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005c
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
			if (useDifferentItem_)
			{
				bool value3 = useDifferentItem_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600382D")]
		[Cpp2IlInjected.Address(RVA = "0x2D51BB0", Offset = "0x2D505B0", VA = "0x182D51BB0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x600382E")]
		[Cpp2IlInjected.Address(RVA = "0x2D52140", Offset = "0x2D50B40", VA = "0x182D52140", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepConsumeItem other)
		{
			//Discarded unreachable code: IL_00b0
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
			bool flag = other.useDifferentItem_;
			if (flag)
			{
				useDifferentItem_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600382F")]
		[Cpp2IlInjected.Address(RVA = "0x2D52280", Offset = "0x2D50C80", VA = "0x182D52280", Slot = "5")]
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
				ItemSelector itemSelector = item_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (item_ = new ItemSelector());
				}
				input.ReadMessage(itemSelector);
			}
			StepAmount stepAmount = default(StepAmount);
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (itemAmount_ == null)
				{
					stepAmount = (itemAmount_ = new StepAmount());
					builder = itemAmount_;
				}
				input.ReadMessage(builder);
			}
			if ((long)stepAmount == 24)
			{
				bool flag = (useDifferentItem_ = input.ReadBool());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003830")]
		[Cpp2IlInjected.Address(RVA = "0x2D52060", Offset = "0x2D50A60", VA = "0x182D52060", Slot = "11")]
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
				StepAmount stepAmount = itemAmount_;
			}
			ItemSelector itemSelector = item_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003831")]
		[Cpp2IlInjected.Address(RVA = "0x2D52460", Offset = "0x2D50E60", VA = "0x182D52460", Slot = "12")]
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
						itemAmount_ = (StepAmount)num2;
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

		[Cpp2IlInjected.Token(Token = "0x6003832")]
		[Cpp2IlInjected.Address(RVA = "0x2D51C90", Offset = "0x2D50690", VA = "0x182D51C90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				useDifferentItem_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003836")]
		[Cpp2IlInjected.Address(RVA = "0x2D51E40", Offset = "0x2D50840", VA = "0x182D51E40", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0080
			do
			{
				if (!useDifferentItem_)
				{
					if (itemAmount_.IsValueSmallerThen(1) && context.IsMissionStep)
					{
						string missionStepName = context.MissionStepName;
						string message = "Should be 1+ in " + missionStepName;
						context.AddInvalidMemberError(message, "ItemAmount");
					}
					return;
				}
				if (item_.itemSelectorCase_ == (ItemSelector.ItemSelectorOneofCase)(-3))
				{
					context.AddInvalidMemberError("Cannot be used with an Item generator", "UseDifferentItem");
				}
			}
			while (!itemAmount_.IsValueSmallerThen(2));
			context.AddInvalidMemberError("Must be 2+ when used with UseDifferentItem", "ItemAmount");
		}

		[Cpp2IlInjected.Token(Token = "0x6003837")]
		[Cpp2IlInjected.Address(RVA = "0x2D52690", Offset = "0x2D51090", VA = "0x182D52690")]
		static CustomStepConsumeItem()
		{
			Func<CustomStepConsumeItem> func = default(Func<CustomStepConsumeItem>);
			_parser = (MessageParser<CustomStepConsumeItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
