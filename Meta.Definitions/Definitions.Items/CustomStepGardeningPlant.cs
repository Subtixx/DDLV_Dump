using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000505")]
	public sealed class CustomStepGardeningPlant : IMessage<CustomStepGardeningPlant>, IMessage, IEquatable<CustomStepGardeningPlant>, IDeepCloneable<CustomStepGardeningPlant>, IMessageFieldAccessor, IItemSelector, IStepAmount, IStringTag, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001ACF")]
		private static readonly MessageParser<CustomStepGardeningPlant> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001AD0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001AD1")]
		public const int TargetItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AD2")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001AD3")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001AD4")]
		private StepAmount amount_;

		[Cpp2IlInjected.Token(Token = "0x4001AD5")]
		public const int UseDifferentItemFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001AD6")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x4001AD7")]
		public const int FilterFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001AD8")]
		private GridLocationFilter filter_;

		[Cpp2IlInjected.Token(Token = "0x17000FE7")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepGardeningPlant> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003E10")]
			[Cpp2IlInjected.Address(RVA = "0x34EC060", Offset = "0x34EAA60", VA = "0x1834EC060")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003E11")]
			[Cpp2IlInjected.Address(RVA = "0x34EBF90", Offset = "0x34EA990", VA = "0x1834EBF90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003E12")]
			[Cpp2IlInjected.Address(RVA = "0x34EC3B0", Offset = "0x34EADB0", VA = "0x1834EC3B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEA")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E17")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E18")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEB")]
		[DebuggerNonUserCode]
		public StepAmount Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6003E19")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E1A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				amount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEC")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E1B")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E1C")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FED")]
		[DebuggerNonUserCode]
		public GridLocationFilter Filter
		{
			[Cpp2IlInjected.Token(Token = "0x6003E1D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return filter_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E1E")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				filter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEE")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003E2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEF")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003E2B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return amount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF0")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003E2C")]
			[Cpp2IlInjected.Address(RVA = "0x34EC0C0", Offset = "0x34EAAC0", VA = "0x1834EC0C0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_00b7
				string[] array;
				while (true)
				{
					array = new string[6];
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
					if ("CropType" != null && "CropType" == null)
					{
						continue;
					}
					array[3] = "CropType";
					if ("MinUnlockLevel" == null || "MinUnlockLevel" != null)
					{
						array[4] = "MinUnlockLevel";
						if ("MaxUnlockLevel" == null || "MaxUnlockLevel" != null)
						{
							break;
						}
					}
				}
				array[5] = "MaxUnlockLevel";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E13")]
		[Cpp2IlInjected.Address(RVA = "0x34EBE70", Offset = "0x34EA870", VA = "0x1834EBE70")]
		[DebuggerNonUserCode]
		public CustomStepGardeningPlant()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E14")]
		[Cpp2IlInjected.Address(RVA = "0x34EB8C0", Offset = "0x34EA2C0", VA = "0x1834EB8C0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E15")]
		[Cpp2IlInjected.Address(RVA = "0x34EBCA0", Offset = "0x34EA6A0", VA = "0x1834EBCA0")]
		[DebuggerNonUserCode]
		public CustomStepGardeningPlant(CustomStepGardeningPlant other)
		{
			//IL_005b: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			filter_ = gridLocationFilter;
			ItemSelector itemSelector2 = other.targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.amount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			amount_ = (StepAmount)num;
			bool flag = (useDifferentItem_ = other.useDifferentItem_);
			GridLocationFilter gridLocationFilter2 = other.filter_;
			GridLocationFilter gridLocationFilter3 = default(GridLocationFilter);
			if (gridLocationFilter2 != null)
			{
				gridLocationFilter3 = gridLocationFilter2.Clone();
			}
			filter_ = gridLocationFilter3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E16")]
		[Cpp2IlInjected.Address(RVA = "0x34EB200", Offset = "0x34E9C00", VA = "0x1834EB200", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepGardeningPlant Clone()
		{
			return new CustomStepGardeningPlant(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E1F")]
		[Cpp2IlInjected.Address(RVA = "0x34EB3B0", Offset = "0x34E9DB0", VA = "0x1834EB3B0", Slot = "0")]
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
					bool flag = object.Equals(amount_, other);
					if (flag && useDifferentItem_ == flag && object.Equals(filter_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E20")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CF40", Offset = "0x2D4B940", VA = "0x182D4CF40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepGardeningPlant other)
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
					StepAmount objB2 = other.amount_;
					if (object.Equals(amount_, objB2))
					{
						bool flag = other.useDifferentItem_;
						if (useDifferentItem_ == flag)
						{
							GridLocationFilter objB3 = other.filter_;
							if (object.Equals(filter_, objB3))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E21")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D0D0", Offset = "0x2D4BAD0", VA = "0x182D4D0D0", Slot = "2")]
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
				StepAmount stepAmount = amount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				if (useDifferentItem_)
				{
				}
				GridLocationFilter gridLocationFilter = filter_;
				if (gridLocationFilter != null)
				{
					int hashCode3 = gridLocationFilter.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E22")]
		[Cpp2IlInjected.Address(RVA = "0x34EBB30", Offset = "0x34EA530", VA = "0x1834EBB30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E23")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D830", Offset = "0x2D4C230", VA = "0x182D4D830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0078
			if ((long)targetItem_ != 0)
			{
				ItemSelector value = targetItem_;
				output.WriteMessage(value);
			}
			if ((long)amount_ != 0)
			{
				StepAmount value2 = amount_;
				output.WriteMessage(value2);
			}
			if (useDifferentItem_)
			{
				bool value3 = useDifferentItem_;
				output.WriteBool(value3);
			}
			if ((long)filter_ != 0)
			{
				GridLocationFilter value4 = filter_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E24")]
		[Cpp2IlInjected.Address(RVA = "0x34EB0F0", Offset = "0x34E9AF0", VA = "0x1834EB0F0", Slot = "7")]
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
				StepAmount stepAmount = amount_;
				if (stepAmount != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num3++;
					num += num3;
				}
				GridLocationFilter gridLocationFilter = filter_;
				if (gridLocationFilter != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(gridLocationFilter);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E25")]
		[Cpp2IlInjected.Address(RVA = "0x34EB730", Offset = "0x34EA130", VA = "0x1834EB730", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepGardeningPlant other)
		{
			//Discarded unreachable code: IL_00ec
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
			if ((long)other.amount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amount_ == null)
				{
					StepAmount stepAmount = (amount_ = new StepAmount());
					stepAmount2 = amount_;
				}
				StepAmount other3 = other.amount_;
				stepAmount2.MergeFrom(other3);
			}
			bool flag = other.useDifferentItem_;
			if (flag)
			{
				useDifferentItem_ = flag;
			}
			if ((long)other.filter_ != 0)
			{
				GridLocationFilter gridLocationFilter2 = default(GridLocationFilter);
				if (filter_ == null)
				{
					GridLocationFilter gridLocationFilter = (filter_ = new GridLocationFilter());
					gridLocationFilter2 = filter_;
				}
				GridLocationFilter other4 = other.filter_;
				gridLocationFilter2.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003E26")]
		[Cpp2IlInjected.Address(RVA = "0x34EB580", Offset = "0x34E9F80", VA = "0x1834EB580", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00cb
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					bool flag = (useDifferentItem_ = input.ReadBool());
				}
				if (num != 34)
				{
					goto IL_00b4;
				}
				GridLocationFilter builder = default(GridLocationFilter);
				if (filter_ == null)
				{
					GridLocationFilter gridLocationFilter = (filter_ = new GridLocationFilter());
					builder = filter_;
				}
				input.ReadMessage(builder);
			}
			ItemSelector itemSelector = default(ItemSelector);
			if (num == 10)
			{
				ItemSelector builder2 = default(ItemSelector);
				if (targetItem_ == null)
				{
					itemSelector = (targetItem_ = new ItemSelector());
					builder2 = targetItem_;
				}
				input.ReadMessage(builder2);
			}
			if ((long)itemSelector == 18)
			{
				StepAmount builder3 = default(StepAmount);
				if (amount_ == null)
				{
					StepAmount stepAmount = (amount_ = new StepAmount());
					builder3 = amount_;
				}
				input.ReadMessage(builder3);
			}
			goto IL_00b4;
			IL_00b4:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003E27")]
		[Cpp2IlInjected.Address(RVA = "0x34EB490", Offset = "0x34E9E90", VA = "0x1834EB490", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						GridLocationFilter gridLocationFilter = filter_;
					}
					bool flag = useDifferentItem_;
				}
				StepAmount stepAmount = amount_;
			}
			ItemSelector itemSelector = targetItem_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E28")]
		[Cpp2IlInjected.Address(RVA = "0x34EB9D0", Offset = "0x34EA3D0", VA = "0x1834EB9D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							filter_ = (GridLocationFilter)num2;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
					{
						object obj = default(object);
						useDifferentItem_ = (byte)(int)obj != 0;
						break;
					}
					}
					return;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E29")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CBC0", Offset = "0x2D4B5C0", VA = "0x182D4CBC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E2D")]
		[Cpp2IlInjected.Address(RVA = "0x31FC4E0", Offset = "0x31FAEE0", VA = "0x1831FC4E0", Slot = "17")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			amount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E2E")]
		[Cpp2IlInjected.Address(RVA = "0x34EB260", Offset = "0x34E9C60", VA = "0x1834EB260", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0080
			do
			{
				if (!useDifferentItem_)
				{
					if (amount_.IsValueSmallerThen(1) && context.IsMissionStep)
					{
						string missionStepName = context.MissionStepName;
						string message = "Should be 1+ in " + missionStepName;
						context.AddInvalidMemberError(message, "Amount");
					}
					return;
				}
				if (targetItem_.itemSelectorCase_ == (ItemSelector.ItemSelectorOneofCase)(-3))
				{
					context.AddInvalidMemberError("Cannot be used with an Item generator", "UseDifferentItem");
				}
			}
			while (!amount_.IsValueSmallerThen(2));
			context.AddInvalidMemberError("Must be 2+ when used with UseDifferentItem", "Amount");
		}

		[Cpp2IlInjected.Token(Token = "0x6003E2F")]
		[Cpp2IlInjected.Address(RVA = "0x34EBB90", Offset = "0x34EA590", VA = "0x1834EBB90")]
		static CustomStepGardeningPlant()
		{
			Func<CustomStepGardeningPlant> func = default(Func<CustomStepGardeningPlant>);
			_parser = (MessageParser<CustomStepGardeningPlant>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
