using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004F2")]
	public sealed class CustomStepCatchFish : IMessage<CustomStepCatchFish>, IMessage, IEquatable<CustomStepCatchFish>, IDeepCloneable<CustomStepCatchFish>, IMessageFieldAccessor, IItemSelector, IStringTag, IStepAmount, IMinWeightReq, IMaxWeightReq, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001A73")]
		private static readonly MessageParser<CustomStepCatchFish> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A74")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A75")]
		public const int TargetItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A76")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001A77")]
		public const int ConditionTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001A78")]
		private CatchFishConditionType conditionType_;

		[Cpp2IlInjected.Token(Token = "0x4001A79")]
		public const int UseDifferentItemFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001A7A")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x4001A7B")]
		public const int WithFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001A7C")]
		private HangoutWithCharacter with_;

		[Cpp2IlInjected.Token(Token = "0x17000FA0")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepCatchFish> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003D03")]
			[Cpp2IlInjected.Address(RVA = "0x2D4DD50", Offset = "0x2D4C750", VA = "0x182D4DD50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003D04")]
			[Cpp2IlInjected.Address(RVA = "0x2D4DC80", Offset = "0x2D4C680", VA = "0x182D4DC80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003D05")]
			[Cpp2IlInjected.Address(RVA = "0x2D4E240", Offset = "0x2D4CC40", VA = "0x182D4E240", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA3")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003D0A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D0B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA4")]
		[DebuggerNonUserCode]
		public CatchFishConditionType ConditionType
		{
			[Cpp2IlInjected.Token(Token = "0x6003D0C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return conditionType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D0D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				conditionType_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA5")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003D0E")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D0F")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA6")]
		[DebuggerNonUserCode]
		public HangoutWithCharacter With
		{
			[Cpp2IlInjected.Token(Token = "0x6003D10")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return with_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D11")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				with_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA7")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003D1D")]
			[Cpp2IlInjected.Address(RVA = "0x2D4DE00", Offset = "0x2D4C800", VA = "0x182D4DE00", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_0115
				string[] array;
				while (true)
				{
					array = new string[9];
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
					if ("MinWeightRequired" != null && "MinWeightRequired" == null)
					{
						continue;
					}
					array[3] = "MinWeightRequired";
					if ("MaxWeightRequired" != null && "MaxWeightRequired" == null)
					{
						continue;
					}
					array[4] = "MaxWeightRequired";
					if ("MinRarity" != null && "MinRarity" == null)
					{
						continue;
					}
					array[5] = "MinRarity";
					if ("MaxRarity" != null && "MaxRarity" == null)
					{
						continue;
					}
					array[6] = "MaxRarity";
					if ("FishLocation" == null || "FishLocation" != null)
					{
						array[7] = "FishLocation";
						if ("FishConstraint" == null || "FishConstraint" != null)
						{
							break;
						}
					}
				}
				array[8] = "FishConstraint";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA8")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003D1E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA9")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003D1F")]
			[Cpp2IlInjected.Address(RVA = "0x2D4DDB0", Offset = "0x2D4C7B0", VA = "0x182D4DDB0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_002b
				CatchFishConditionType catchFishConditionType = conditionType_;
				CatchFishConditionType.TypesOneofCase typesCase_ = catchFishConditionType.typesCase_;
				if (typesCase_ != CatchFishConditionType.TypesOneofCase.Amount)
				{
					if (typesCase_ != CatchFishConditionType.TypesOneofCase.TotalWeight)
					{
						int num = 0;
					}
					CatchFishConditionWeight totalWeight = catchFishConditionType.TotalWeight;
				}
				return catchFishConditionType.Amount.amountToCatch_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAA")]
		public StepAmount MinWeightReq
		{
			[Cpp2IlInjected.Token(Token = "0x6003D20")]
			[Cpp2IlInjected.Address(RVA = "0x2D4D1D0", Offset = "0x2D4BBD0", VA = "0x182D4D1D0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_001e
				CatchFishConditionType catchFishConditionType = conditionType_;
				if (catchFishConditionType.typesCase_ != CatchFishConditionType.TypesOneofCase.Amount)
				{
					int num = 0;
				}
				return catchFishConditionType.Amount.minWeightRequired_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAB")]
		public StepAmount MaxWeightReq
		{
			[Cpp2IlInjected.Token(Token = "0x6003D21")]
			[Cpp2IlInjected.Address(RVA = "0x2D4D190", Offset = "0x2D4BB90", VA = "0x182D4D190", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_001e
				CatchFishConditionType catchFishConditionType = conditionType_;
				if (catchFishConditionType.typesCase_ != CatchFishConditionType.TypesOneofCase.Amount)
				{
					int num = 0;
				}
				return catchFishConditionType.Amount.maxWeightRequired_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D06")]
		[Cpp2IlInjected.Address(RVA = "0x2D4DBB0", Offset = "0x2D4C5B0", VA = "0x182D4DBB0")]
		[DebuggerNonUserCode]
		public CustomStepCatchFish()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			CatchFishConditionType catchFishConditionType = (conditionType_ = new CatchFishConditionType());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D07")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D5A0", Offset = "0x2D4BFA0", VA = "0x182D4D5A0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			CatchFishConditionType catchFishConditionType = (conditionType_ = new CatchFishConditionType());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D08")]
		[Cpp2IlInjected.Address(RVA = "0x2D4DA20", Offset = "0x2D4C420", VA = "0x182D4DA20")]
		[DebuggerNonUserCode]
		public CustomStepCatchFish(CustomStepCatchFish other)
		{
			//IL_004b: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			CatchFishConditionType catchFishConditionType = (conditionType_ = new CatchFishConditionType());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			ItemSelector itemSelector2 = other.targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num;
			CatchFishConditionType catchFishConditionType2 = other.conditionType_;
			if (catchFishConditionType2 != null)
			{
				CatchFishConditionType catchFishConditionType3 = catchFishConditionType2.Clone();
			}
			conditionType_ = (CatchFishConditionType)num;
			bool flag = (useDifferentItem_ = other.useDifferentItem_);
			HangoutWithCharacter hangoutWithCharacter2 = other.with_;
			HangoutWithCharacter hangoutWithCharacter3 = default(HangoutWithCharacter);
			if (hangoutWithCharacter2 != null)
			{
				hangoutWithCharacter3 = hangoutWithCharacter2.Clone();
			}
			with_ = hangoutWithCharacter3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D09")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CC10", Offset = "0x2D4B610", VA = "0x182D4CC10", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepCatchFish Clone()
		{
			return new CustomStepCatchFish(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D12")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CE60", Offset = "0x2D4B860", VA = "0x182D4CE60", Slot = "0")]
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
					bool flag = object.Equals(conditionType_, other);
					if (flag && useDifferentItem_ == flag && object.Equals(with_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D13")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CF40", Offset = "0x2D4B940", VA = "0x182D4CF40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepCatchFish other)
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
					CatchFishConditionType objB2 = other.conditionType_;
					if (object.Equals(conditionType_, objB2))
					{
						bool flag = other.useDifferentItem_;
						if (useDifferentItem_ == flag)
						{
							HangoutWithCharacter objB3 = other.with_;
							if (object.Equals(with_, objB3))
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

		[Cpp2IlInjected.Token(Token = "0x6003D14")]
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
				CatchFishConditionType catchFishConditionType = conditionType_;
				if (catchFishConditionType != null)
				{
					int hashCode2 = catchFishConditionType.GetHashCode();
				}
				if (useDifferentItem_)
				{
				}
				HangoutWithCharacter hangoutWithCharacter = with_;
				if (hangoutWithCharacter != null)
				{
					int hashCode3 = hangoutWithCharacter.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D15")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D7D0", Offset = "0x2D4C1D0", VA = "0x182D4D7D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D16")]
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
			if ((long)conditionType_ != 0)
			{
				CatchFishConditionType value2 = conditionType_;
				output.WriteMessage(value2);
			}
			if (useDifferentItem_)
			{
				bool value3 = useDifferentItem_;
				output.WriteBool(value3);
			}
			if ((long)with_ != 0)
			{
				HangoutWithCharacter value4 = with_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D17")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CAB0", Offset = "0x2D4B4B0", VA = "0x182D4CAB0", Slot = "7")]
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
				CatchFishConditionType catchFishConditionType = conditionType_;
				if (catchFishConditionType != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(catchFishConditionType);
					num3++;
					num += num3;
				}
				HangoutWithCharacter hangoutWithCharacter = with_;
				if (hangoutWithCharacter != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(hangoutWithCharacter);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D18")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D260", Offset = "0x2D4BC60", VA = "0x182D4D260", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepCatchFish other)
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
			if ((long)other.conditionType_ != 0)
			{
				CatchFishConditionType catchFishConditionType2 = default(CatchFishConditionType);
				if (conditionType_ == null)
				{
					CatchFishConditionType catchFishConditionType = (conditionType_ = new CatchFishConditionType());
					catchFishConditionType2 = conditionType_;
				}
				CatchFishConditionType other3 = other.conditionType_;
				catchFishConditionType2.MergeFrom(other3);
			}
			bool flag = other.useDifferentItem_;
			if (flag)
			{
				useDifferentItem_ = flag;
			}
			if ((long)other.with_ != 0)
			{
				HangoutWithCharacter hangoutWithCharacter2 = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					hangoutWithCharacter2 = with_;
				}
				HangoutWithCharacter other4 = other.with_;
				hangoutWithCharacter2.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003D19")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D3F0", Offset = "0x2D4BDF0", VA = "0x182D4D3F0", Slot = "5")]
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
				HangoutWithCharacter builder = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					builder = with_;
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
				CatchFishConditionType builder3 = default(CatchFishConditionType);
				if (conditionType_ == null)
				{
					CatchFishConditionType catchFishConditionType = (conditionType_ = new CatchFishConditionType());
					builder3 = conditionType_;
				}
				input.ReadMessage(builder3);
			}
			goto IL_00b4;
			IL_00b4:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003D1A")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CFE0", Offset = "0x2D4B9E0", VA = "0x182D4CFE0", Slot = "11")]
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
						HangoutWithCharacter hangoutWithCharacter = with_;
					}
					bool flag = useDifferentItem_;
				}
				CatchFishConditionType catchFishConditionType = conditionType_;
			}
			ItemSelector itemSelector = targetItem_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D1B")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D670", Offset = "0x2D4C070", VA = "0x182D4D670", Slot = "12")]
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
							with_ = (HangoutWithCharacter)num2;
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

		[Cpp2IlInjected.Token(Token = "0x6003D1C")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CBC0", Offset = "0x2D4B5C0", VA = "0x182D4CBC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D22")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D210", Offset = "0x2D4BC10", VA = "0x182D4D210")]
		private StepAmount GetStepAmount()
		{
			CatchFishConditionType catchFishConditionType = conditionType_;
			CatchFishConditionType.TypesOneofCase typesCase_ = catchFishConditionType.typesCase_;
			if (typesCase_ != CatchFishConditionType.TypesOneofCase.Amount)
			{
				if (typesCase_ != CatchFishConditionType.TypesOneofCase.TotalWeight)
				{
					int num = 0;
				}
				return catchFishConditionType.TotalWeight.totalWeightToCatch_;
			}
			CatchFishConditionAmount amount = catchFishConditionType.Amount;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D23")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D1D0", Offset = "0x2D4BBD0", VA = "0x182D4D1D0")]
		private StepAmount GetMinWeightReqStepAmount()
		{
			//Discarded unreachable code: IL_001e
			CatchFishConditionType catchFishConditionType = conditionType_;
			if (catchFishConditionType.typesCase_ != CatchFishConditionType.TypesOneofCase.Amount)
			{
				int num = 0;
			}
			return catchFishConditionType.Amount.minWeightRequired_;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D24")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D190", Offset = "0x2D4BB90", VA = "0x182D4D190")]
		private StepAmount GetMaxWeightReqStepAmount()
		{
			//Discarded unreachable code: IL_001e
			CatchFishConditionType catchFishConditionType = conditionType_;
			if (catchFishConditionType.typesCase_ != CatchFishConditionType.TypesOneofCase.Amount)
			{
				int num = 0;
			}
			return catchFishConditionType.Amount.maxWeightRequired_;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D25")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CC70", Offset = "0x2D4B670", VA = "0x182D4CC70", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00d2
			if (!useDifferentItem_)
			{
				CatchFishConditionType catchFishConditionType = conditionType_;
				switch (catchFishConditionType.typesCase_)
				{
				default:
				{
					CatchFishConditionWeight totalWeight = catchFishConditionType.TotalWeight;
					break;
				}
				case CatchFishConditionType.TypesOneofCase.Amount:
					break;
				}
				StepAmount amountToCatch_ = catchFishConditionType.Amount.amountToCatch_;
				if (context.IsMissionStep && amountToCatch_ != null && amountToCatch_.IsValueSmallerThen(1))
				{
					string missionStepName = context.MissionStepName;
					string error = "[Amount] Should be 1+ in " + missionStepName;
					context.AddError(error);
				}
			}
			else
			{
				if (targetItem_.itemSelectorCase_ == (ItemSelector.ItemSelectorOneofCase)(-3))
				{
					context.AddInvalidMemberError("Cannot be used with an Item generator", "UseDifferentItem");
				}
				CatchFishConditionType catchFishConditionType2 = conditionType_;
				CatchFishConditionType.TypesOneofCase typesCase_ = catchFishConditionType2.typesCase_;
				if (typesCase_ != CatchFishConditionType.TypesOneofCase.TotalWeight && typesCase_ == CatchFishConditionType.TypesOneofCase.Amount && catchFishConditionType2.Amount.amountToCatch_.IsValueSmallerThen(2))
				{
					context.AddInvalidMemberError("Must be 2+ when used with UseDifferentItem", "AmountToCatch");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D26")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D910", Offset = "0x2D4C310", VA = "0x182D4D910")]
		static CustomStepCatchFish()
		{
			Func<CustomStepCatchFish> func = default(Func<CustomStepCatchFish>);
			_parser = (MessageParser<CustomStepCatchFish>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
