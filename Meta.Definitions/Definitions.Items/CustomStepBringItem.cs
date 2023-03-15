using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000511")]
	public sealed class CustomStepBringItem : IMessage<CustomStepBringItem>, IMessage, IEquatable<CustomStepBringItem>, IDeepCloneable<CustomStepBringItem>, IMessageFieldAccessor, IItemSelector, IStepAmount, IStringTag, ITargetCharacterOverride, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001B12")]
		private static readonly MessageParser<CustomStepBringItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001B13")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001B14")]
		public const int TargetIsNotOwnerFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001B15")]
		private OptionalField targetIsNotOwner_;

		[Cpp2IlInjected.Token(Token = "0x4001B16")]
		public const int TargetItemFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001B17")]
		private AnyItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001B18")]
		public const int AmountToGiveFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001B19")]
		private StepAmount amountToGive_;

		[Cpp2IlInjected.Token(Token = "0x1700101E")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepBringItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003EC9")]
			[Cpp2IlInjected.Address(RVA = "0x2D4AD60", Offset = "0x2D49760", VA = "0x182D4AD60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003ECA")]
			[Cpp2IlInjected.Address(RVA = "0x2D4AC70", Offset = "0x2D49670", VA = "0x182D4AC70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001020")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003ECB")]
			[Cpp2IlInjected.Address(RVA = "0x2D4BA20", Offset = "0x2D4A420", VA = "0x182D4BA20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001021")]
		[DebuggerNonUserCode]
		public OptionalField TargetIsNotOwner
		{
			[Cpp2IlInjected.Token(Token = "0x6003ED0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetIsNotOwner_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003ED1")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetIsNotOwner_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001022")]
		[DebuggerNonUserCode]
		public AnyItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003ED2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003ED3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001023")]
		[DebuggerNonUserCode]
		public StepAmount AmountToGive
		{
			[Cpp2IlInjected.Token(Token = "0x6003ED4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return amountToGive_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003ED5")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				amountToGive_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001024")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003EE1")]
			[Cpp2IlInjected.Address(RVA = "0x2D4AD40", Offset = "0x2D49740", VA = "0x182D4AD40", Slot = "14")]
			get
			{
				//Discarded unreachable code: IL_000c
				return targetItem_.itemToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001025")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003EE2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "15")]
			get
			{
				return amountToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001026")]
		public (Item? characterItem, bool random) TargetCharacterOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6003EE3")]
			[Cpp2IlInjected.Address(RVA = "0x2D4B930", Offset = "0x2D4A330", VA = "0x182D4B930", Slot = "17")]
			get
			{
				int num = 0;
				CharacterList characterList = default(CharacterList);
				int targetCharacter = characterList.TargetCharacter;
				int num2 = 0;
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001027")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003EE4")]
			[Cpp2IlInjected.Address(RVA = "0x2D4ADC0", Offset = "0x2D497C0", VA = "0x182D4ADC0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0315
				string[] array;
				while (true)
				{
					array = new string[25];
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
					if ("TargetNPC" != null && "TargetNPC" == null)
					{
						continue;
					}
					array[3] = "TargetNPC";
					if ("Complexity" != null && "Complexity" == null)
					{
						continue;
					}
					array[4] = "Complexity";
					if ("Mood" != null && "Mood" == null)
					{
						continue;
					}
					array[5] = "Mood";
					if ("Sturdiness" != null && "Sturdiness" == null)
					{
						continue;
					}
					array[6] = "Sturdiness";
					if ("Normality" != null && "Normality" == null)
					{
						continue;
					}
					array[7] = "Normality";
					if ("MinRarity" != null && "MinRarity" == null)
					{
						continue;
					}
					array[8] = "MinRarity";
					if ("MaxRarity" != null && "MaxRarity" == null)
					{
						continue;
					}
					array[9] = "MaxRarity";
					if ("Tags" != null && "Tags" == null)
					{
						continue;
					}
					array[10] = "Tags";
					if ("Color" != null && "Color" == null)
					{
						continue;
					}
					array[11] = "Color";
					if ("Style" != null && "Style" == null)
					{
						continue;
					}
					array[12] = "Style";
					if ("Function" != null && "Function" == null)
					{
						continue;
					}
					array[13] = "Function";
					if ("Zone" != null && "Zone" == null)
					{
						continue;
					}
					array[14] = "Zone";
					if ("Universe" != null && "Universe" == null)
					{
						continue;
					}
					array[15] = "Universe";
					if ("Type" != null && "Type" == null)
					{
						continue;
					}
					array[16] = "Type";
					if ("FishLocation" != null && "FishLocation" == null)
					{
						continue;
					}
					array[17] = "FishLocation";
					if ("FishConstraint" != null && "FishConstraint" == null)
					{
						continue;
					}
					array[18] = "FishConstraint";
					if ("CropType" != null && "CropType" == null)
					{
						continue;
					}
					array[19] = "CropType";
					if ("FlowerRarity" != null && "FlowerRarity" == null)
					{
						continue;
					}
					array[20] = "FlowerRarity";
					if ("MealType" != null && "MealType" == null)
					{
						continue;
					}
					array[21] = "MealType";
					if ("IngredientType" != null && "IngredientType" == null)
					{
						continue;
					}
					array[22] = "IngredientType";
					if ("MinUnlockLevel" == null || "MinUnlockLevel" != null)
					{
						array[23] = "MinUnlockLevel";
						if ("MaxUnlockLevel" == null || "MaxUnlockLevel" != null)
						{
							break;
						}
					}
				}
				array[24] = "MaxUnlockLevel";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003ECC")]
		[Cpp2IlInjected.Address(RVA = "0x2D4AB50", Offset = "0x2D49550", VA = "0x182D4AB50")]
		[DebuggerNonUserCode]
		public CustomStepBringItem()
		{
			AnyItemSelector anyItemSelector = (targetItem_ = new AnyItemSelector());
			StepAmount stepAmount = (amountToGive_ = new StepAmount());
			OptionalField optionalField = new OptionalField
			{
				useField_ = false,
				showRandomCheckbox_ = true
			};
			CharacterList characterList2 = (optionalField.Character = new CharacterList());
			targetIsNotOwner_ = optionalField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003ECD")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A5E0", Offset = "0x2D48FE0", VA = "0x182D4A5E0")]
		private void OnConstruction()
		{
			AnyItemSelector anyItemSelector = (targetItem_ = new AnyItemSelector());
			StepAmount stepAmount = (amountToGive_ = new StepAmount());
			OptionalField optionalField = new OptionalField();
			optionalField.useField_ = false;
			optionalField.showRandomCheckbox_ = true;
			CharacterList characterList2 = (optionalField.Character = new CharacterList());
			targetIsNotOwner_ = optionalField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003ECE")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A970", Offset = "0x2D49370", VA = "0x182D4A970")]
		[DebuggerNonUserCode]
		public CustomStepBringItem(CustomStepBringItem other)
		{
			//IL_0069: Expected O, but got I4
			//IL_0087: Expected O, but got I4
			AnyItemSelector anyItemSelector = (targetItem_ = new AnyItemSelector());
			StepAmount stepAmount = (amountToGive_ = new StepAmount());
			OptionalField optionalField = new OptionalField
			{
				useField_ = false,
				showRandomCheckbox_ = true
			};
			CharacterList characterList2 = (optionalField.Character = new CharacterList());
			targetIsNotOwner_ = optionalField;
			OptionalField optionalField2 = other.targetIsNotOwner_;
			int num = 0;
			if (optionalField2 != null)
			{
				OptionalField optionalField3 = optionalField2.Clone();
			}
			targetIsNotOwner_ = (OptionalField)num;
			AnyItemSelector anyItemSelector2 = other.targetItem_;
			if (anyItemSelector2 != null)
			{
				AnyItemSelector anyItemSelector3 = anyItemSelector2.Clone();
			}
			targetItem_ = (AnyItemSelector)num;
			StepAmount stepAmount2 = other.amountToGive_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			amountToGive_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003ECF")]
		[Cpp2IlInjected.Address(RVA = "0x2D49CE0", Offset = "0x2D486E0", VA = "0x182D49CE0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepBringItem Clone()
		{
			return new CustomStepBringItem(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003ED6")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A140", Offset = "0x2D48B40", VA = "0x182D4A140", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(targetIsNotOwner_, other) && object.Equals(targetItem_, other) && object.Equals(amountToGive_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003ED7")]
		[Cpp2IlInjected.Address(RVA = "0x713280", Offset = "0x711C80", VA = "0x180713280", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepBringItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				OptionalField objB = other.targetIsNotOwner_;
				if (object.Equals(targetIsNotOwner_, objB))
				{
					AnyItemSelector objB2 = other.targetItem_;
					if (object.Equals(targetItem_, objB2))
					{
						StepAmount objB3 = other.amountToGive_;
						if (object.Equals(amountToGive_, objB3))
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

		[Cpp2IlInjected.Token(Token = "0x6003ED8")]
		[Cpp2IlInjected.Address(RVA = "0x7133C0", Offset = "0x711DC0", VA = "0x1807133C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				OptionalField optionalField = targetIsNotOwner_;
				if (optionalField != null)
				{
					int hashCode = optionalField.GetHashCode();
				}
				AnyItemSelector anyItemSelector = targetItem_;
				if (anyItemSelector != null)
				{
					int hashCode2 = anyItemSelector.GetHashCode();
				}
				StepAmount stepAmount = amountToGive_;
				if (stepAmount != null)
				{
					int hashCode3 = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003ED9")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A800", Offset = "0x2D49200", VA = "0x182D4A800", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003EDA")]
		[Cpp2IlInjected.Address(RVA = "0x2375E90", Offset = "0x2374890", VA = "0x182375E90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			if ((long)targetIsNotOwner_ != 0)
			{
				OptionalField value = targetIsNotOwner_;
				output.WriteMessage(value);
			}
			if ((long)targetItem_ != 0)
			{
				AnyItemSelector value2 = targetItem_;
				output.WriteMessage(value2);
			}
			if ((long)amountToGive_ != 0)
			{
				StepAmount value3 = amountToGive_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003EDB")]
		[Cpp2IlInjected.Address(RVA = "0x2D49BD0", Offset = "0x2D485D0", VA = "0x182D49BD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				OptionalField optionalField = targetIsNotOwner_;
				num = 0;
				if (optionalField != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(optionalField);
				}
				AnyItemSelector anyItemSelector = targetItem_;
				if (anyItemSelector != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(anyItemSelector);
					num3++;
					num += num3;
				}
				StepAmount stepAmount = amountToGive_;
				if (stepAmount != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003EDC")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A450", Offset = "0x2D48E50", VA = "0x182D4A450", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepBringItem other)
		{
			//Discarded unreachable code: IL_00d7
			if (other == null)
			{
				return;
			}
			if ((long)other.targetIsNotOwner_ != 0)
			{
				OptionalField optionalField = targetIsNotOwner_;
				if (optionalField == null)
				{
					OptionalField optionalField2 = (targetIsNotOwner_ = new OptionalField());
					OptionalField optionalField3 = targetIsNotOwner_;
				}
				OptionalField other2 = other.targetIsNotOwner_;
				optionalField.MergeFrom(other2);
			}
			if ((long)other.targetItem_ != 0)
			{
				AnyItemSelector anyItemSelector2 = default(AnyItemSelector);
				if (targetItem_ == null)
				{
					AnyItemSelector anyItemSelector = (targetItem_ = new AnyItemSelector());
					anyItemSelector2 = targetItem_;
				}
				AnyItemSelector other3 = other.targetItem_;
				anyItemSelector2.MergeFrom(other3);
			}
			if ((long)other.amountToGive_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amountToGive_ == null)
				{
					StepAmount stepAmount = (amountToGive_ = new StepAmount());
					stepAmount2 = amountToGive_;
				}
				StepAmount other4 = other.amountToGive_;
				stepAmount2.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003EDD")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A2C0", Offset = "0x2D48CC0", VA = "0x182D4A2C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				OptionalField optionalField = targetIsNotOwner_;
				if (optionalField == null)
				{
					OptionalField optionalField2 = (targetIsNotOwner_ = new OptionalField());
				}
				input.ReadMessage(optionalField);
			}
			AnyItemSelector anyItemSelector = default(AnyItemSelector);
			if (num == 18)
			{
				AnyItemSelector builder = default(AnyItemSelector);
				if (targetItem_ == null)
				{
					anyItemSelector = (targetItem_ = new AnyItemSelector());
					builder = targetItem_;
				}
				input.ReadMessage(builder);
			}
			if ((long)anyItemSelector == 26)
			{
				StepAmount builder2 = default(StepAmount);
				if (amountToGive_ == null)
				{
					StepAmount stepAmount = (amountToGive_ = new StepAmount());
					builder2 = amountToGive_;
				}
				input.ReadMessage(builder2);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003EDE")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A220", Offset = "0x2D48C20", VA = "0x182D4A220", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				StepAmount stepAmount = amountToGive_;
				AnyItemSelector anyItemSelector = targetItem_;
				OptionalField optionalField = targetIsNotOwner_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003EDF")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A700", Offset = "0x2D49100", VA = "0x182D4A700", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
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
						amountToGive_ = (StepAmount)num2;
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
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003EE0")]
		[Cpp2IlInjected.Address(RVA = "0x2375600", Offset = "0x2374000", VA = "0x182375600", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EE5")]
		[Cpp2IlInjected.Address(RVA = "0x2D49D40", Offset = "0x2D48740", VA = "0x182D49D40", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00ea
			//IL_0080: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			AnyItemSelector anyItemSelector = targetItem_;
			if (anyItemSelector.itemTypeToGive_ == AnyItemSelectorChoices.Ingredient)
			{
				ItemSelector itemToGive_ = anyItemSelector.itemToGive_;
				if (itemToGive_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Item)
				{
					if (itemToGive_.Item.item_.Item == 0)
					{
						int item = targetItem_.itemToGive_.Item.itemIngredient_.Item;
					}
					bool flag = default(bool);
					if (flag)
					{
						ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
						IngredientItemData ingredientItemData = default(IngredientItemData);
						if (ingredientItemData == null)
						{
							ItemType itemType = default(ItemType);
							int num = (int)itemType;
							ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
							if (itemTypeMetaInfo != null)
							{
							}
							int num2 = 0;
							int num3 = 0;
							if ((System.RuntimeType)num2 != (System.RuntimeType)num3)
							{
								ItemDatabase.ItemTypeMetaInfo.GetSubTypeDelegate _003CGetSubType_003Ek__BackingField = itemTypeMetaInfo.GetSubType;
							}
							ItemType itemType2 = default(ItemType);
							string text = $"{itemType2}";
							string missionStepName = context.MissionStepName;
							string error = "Did you select Ingredient instead of " + text + " in " + missionStepName;
							context.AddError(error);
						}
					}
				}
			}
			if (targetItem_.itemTypeToGive_ == AnyItemSelectorChoices.LootPresent)
			{
				AnyItemSelectorChoices anyItemSelectorChoices = default(AnyItemSelectorChoices);
				string message = $"{anyItemSelectorChoices} is not allowed";
				context.AddInvalidMemberError(message, "TargetItem");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003EE6")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A860", Offset = "0x2D49260", VA = "0x182D4A860")]
		static CustomStepBringItem()
		{
			Func<CustomStepBringItem> func = default(Func<CustomStepBringItem>);
			_parser = (MessageParser<CustomStepBringItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
