using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000496")]
	public sealed class CustomStepCookMeal : IMessage<CustomStepCookMeal>, IMessage, IEquatable<CustomStepCookMeal>, IDeepCloneable<CustomStepCookMeal>, IMessageFieldAccessor, IMessageOneofAccessor, IItemSelector, IStepAmount, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000497")]
		public enum ConditionTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40018A6")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40018A7")]
			TargetMealItem = 2,
			[Cpp2IlInjected.Token(Token = "0x40018A8")]
			TargetIngredientItem = 4
		}

		[Cpp2IlInjected.Token(Token = "0x400189D")]
		private static readonly MessageParser<CustomStepCookMeal> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400189E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400189F")]
		public const int TargetMealItemFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40018A0")]
		public const int TargetIngredientItemFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40018A1")]
		public const int AmountToCookFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018A2")]
		private StepAmount amountToCook_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018A3")]
		private object conditionType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018A4")]
		private ConditionTypeOneofCase conditionTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000E5E")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepCookMeal> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003856")]
			[Cpp2IlInjected.Address(RVA = "0x2D54580", Offset = "0x2D52F80", VA = "0x182D54580")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E5F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003857")]
			[Cpp2IlInjected.Address(RVA = "0x2D54400", Offset = "0x2D52E00", VA = "0x182D54400")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E60")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003858")]
			[Cpp2IlInjected.Address(RVA = "0x2D54990", Offset = "0x2D53390", VA = "0x182D54990", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E61")]
		[DebuggerNonUserCode]
		public ItemSelector TargetMealItem
		{
			[Cpp2IlInjected.Token(Token = "0x600385D")]
			[Cpp2IlInjected.Address(RVA = "0x2D54930", Offset = "0x2D53330", VA = "0x182D54930")]
			get
			{
				int num = 0;
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					object obj = conditionType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600385E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE160", Offset = "0x7FCB60", VA = "0x1807FE160")]
			set
			{
				conditionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E62")]
		[DebuggerNonUserCode]
		public ItemSelector TargetIngredientItem
		{
			[Cpp2IlInjected.Token(Token = "0x600385F")]
			[Cpp2IlInjected.Address(RVA = "0x2D548D0", Offset = "0x2D532D0", VA = "0x182D548D0")]
			get
			{
				int num = 0;
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetIngredientItem)
				{
					object obj = conditionType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003860")]
			[Cpp2IlInjected.Address(RVA = "0x24D4380", Offset = "0x24D2D80", VA = "0x1824D4380")]
			set
			{
				conditionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E63")]
		[DebuggerNonUserCode]
		public StepAmount AmountToCook
		{
			[Cpp2IlInjected.Token(Token = "0x6003861")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return amountToCook_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003862")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				amountToCook_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E64")]
		[DebuggerNonUserCode]
		public ConditionTypeOneofCase ConditionTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003863")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return conditionTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E65")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003872")]
			[Cpp2IlInjected.Address(RVA = "0x2D544D0", Offset = "0x2D52ED0", VA = "0x182D544D0", Slot = "16")]
			get
			{
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetIngredientItem)
				{
					if (conditionTypeCase_ != ConditionTypeOneofCase.TargetIngredientItem)
					{
						goto IL_0039;
					}
					object obj = conditionType_;
					if (obj == null || obj == null)
					{
						goto IL_003b;
					}
				}
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					object obj2 = conditionType_;
					if (obj2 == null)
					{
						goto IL_003b;
					}
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				goto IL_0039;
				IL_0039:
				int num = 0;
				goto IL_003b;
				IL_003b:
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E66")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003873")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "17")]
			get
			{
				return amountToCook_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E67")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003874")]
			[Cpp2IlInjected.Address(RVA = "0x2D545E0", Offset = "0x2D52FE0", VA = "0x182D545E0", Slot = "18")]
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
					if ("MinimumStarRating" != null && "MinimumStarRating" == null)
					{
						continue;
					}
					array[1] = "MinimumStarRating";
					if ("TargetAmount" != null && "TargetAmount" == null)
					{
						continue;
					}
					array[2] = "TargetAmount";
					if ("CurrentAmount" != null && "CurrentAmount" == null)
					{
						continue;
					}
					array[3] = "CurrentAmount";
					if ("MealType" == null || "MealType" != null)
					{
						array[4] = "MealType";
						if ("IngredientType" == null || "IngredientType" != null)
						{
							break;
						}
					}
				}
				array[5] = "IngredientType";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003859")]
		[Cpp2IlInjected.Address(RVA = "0x2D540E0", Offset = "0x2D52AE0", VA = "0x182D540E0")]
		[DebuggerNonUserCode]
		public CustomStepCookMeal()
		{
			//IL_001a: Expected I4, but got O
			//IL_002e: Expected I4, but got O
			conditionTypeCase_ = (ConditionTypeOneofCase)(conditionType_ = new ItemSelector());
			conditionTypeCase_ = (ConditionTypeOneofCase)(conditionType_ = new ItemSelector());
			StepAmount stepAmount = (amountToCook_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600385A")]
		[Cpp2IlInjected.Address(RVA = "0x2D53C10", Offset = "0x2D52610", VA = "0x182D53C10")]
		private void OnConstruction()
		{
			//IL_0014: Expected I4, but got O
			//IL_0028: Expected I4, but got O
			conditionTypeCase_ = (ConditionTypeOneofCase)(conditionType_ = new ItemSelector());
			conditionTypeCase_ = (ConditionTypeOneofCase)(conditionType_ = new ItemSelector());
			StepAmount stepAmount = (amountToCook_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600385B")]
		[Cpp2IlInjected.Address(RVA = "0x2D541C0", Offset = "0x2D52BC0", VA = "0x182D541C0")]
		[DebuggerNonUserCode]
		public CustomStepCookMeal(CustomStepCookMeal other)
		{
			//IL_001a: Expected I4, but got O
			//IL_002e: Expected I4, but got O
			//IL_0059: Expected O, but got I4
			//IL_00a3: Expected I4, but got O
			conditionTypeCase_ = (ConditionTypeOneofCase)(conditionType_ = new ItemSelector());
			conditionTypeCase_ = (ConditionTypeOneofCase)(conditionType_ = new ItemSelector());
			StepAmount stepAmount = (amountToCook_ = new StepAmount());
			StepAmount stepAmount2 = other.amountToCook_;
			int num = 0;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			amountToCook_ = (StepAmount)num;
			ItemSelector itemSelector = default(ItemSelector);
			if (other.conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
			{
				ConditionTypeOneofCase conditionTypeOneofCase = other.conditionTypeCase_;
				if (other.conditionType_ == null)
				{
					throw new InvalidCastException();
				}
				conditionType_ = itemSelector;
			}
			if ((long)itemSelector == 4)
			{
				ConditionTypeOneofCase conditionTypeOneofCase2 = other.conditionTypeCase_;
				if (other.conditionType_ == null)
				{
					throw new InvalidCastException();
				}
				ItemSelector itemSelector2 = default(ItemSelector);
				conditionType_ = itemSelector2;
				conditionTypeCase_ = (ConditionTypeOneofCase)itemSelector2;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600385C")]
		[Cpp2IlInjected.Address(RVA = "0x2D52FB0", Offset = "0x2D519B0", VA = "0x182D52FB0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepCookMeal Clone()
		{
			return new CustomStepCookMeal(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003864")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearConditionType()
		{
			//IL_0010: Expected O, but got I4
			conditionType_ = (conditionTypeCase_ = ConditionTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003865")]
		[Cpp2IlInjected.Address(RVA = "0x2D53130", Offset = "0x2D51B30", VA = "0x182D53130", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
					{
						object obj = conditionType_;
						if (obj != null && obj == null)
						{
							goto IL_0086;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(ItemSelector).TypeHandle != null && (object)typeof(ItemSelector).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					ItemSelector objB = default(ItemSelector);
					if (flag && object.Equals(TargetIngredientItem, objB))
					{
						bool flag2 = object.Equals(amountToCook_, objB);
						if (flag2 && conditionTypeCase_ == (flag2 ? ((ConditionTypeOneofCase)1) : ConditionTypeOneofCase.None))
						{
							bool flag3 = object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0086;
			IL_0086:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003866")]
		[Cpp2IlInjected.Address(RVA = "0x2D532B0", Offset = "0x2D51CB0", VA = "0x182D532B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepCookMeal other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					object obj = conditionType_;
					if (obj != null && obj == null)
					{
						goto IL_00b1;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					obj2 = other.conditionType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ItemSelector targetIngredientItem = TargetIngredientItem;
					ItemSelector targetIngredientItem2 = other.TargetIngredientItem;
					if (object.Equals(targetIngredientItem, targetIngredientItem2))
					{
						StepAmount objB = other.amountToCook_;
						if (object.Equals(amountToCook_, objB))
						{
							ConditionTypeOneofCase conditionTypeOneofCase = other.conditionTypeCase_;
							if (conditionTypeCase_ == conditionTypeOneofCase)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								bool flag = object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00b1;
			IL_00b1:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003867")]
		[Cpp2IlInjected.Address(RVA = "0x2D53520", Offset = "0x2D51F20", VA = "0x182D53520", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0067
			ConditionTypeOneofCase conditionTypeOneofCase = conditionTypeCase_;
			int num = 0;
			if (conditionTypeOneofCase == ConditionTypeOneofCase.TargetMealItem)
			{
				object obj = conditionType_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (conditionTypeOneofCase == ConditionTypeOneofCase.TargetIngredientItem)
			{
				object obj2 = conditionType_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			StepAmount stepAmount = amountToCook_;
			if (stepAmount != null)
			{
				int hashCode3 = stepAmount.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003868")]
		[Cpp2IlInjected.Address(RVA = "0x2D53E20", Offset = "0x2D52820", VA = "0x182D53E20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003869")]
		[Cpp2IlInjected.Address(RVA = "0x2D53E80", Offset = "0x2D52880", VA = "0x182D53E80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0079
			//IL_002c: Expected O, but got I4
			ConditionTypeOneofCase conditionTypeOneofCase = conditionTypeCase_;
			int num = 0;
			if (conditionTypeOneofCase == ConditionTypeOneofCase.TargetMealItem)
			{
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					object obj = conditionType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (conditionTypeOneofCase == ConditionTypeOneofCase.TargetIngredientItem && conditionTypeCase_ == ConditionTypeOneofCase.TargetIngredientItem)
			{
				object obj2 = conditionType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if ((long)amountToCook_ != 0)
			{
				StepAmount value = amountToCook_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600386A")]
		[Cpp2IlInjected.Address(RVA = "0x2D52D60", Offset = "0x2D51760", VA = "0x182D52D60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
			{
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					object obj = conditionType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (conditionTypeCase_ == ConditionTypeOneofCase.TargetIngredientItem)
			{
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetIngredientItem)
				{
					object obj2 = conditionType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			StepAmount stepAmount = amountToCook_;
			if (stepAmount != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600386B")]
		[Cpp2IlInjected.Address(RVA = "0x2D53970", Offset = "0x2D52370", VA = "0x182D53970", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepCookMeal other)
		{
			//IL_0112: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.amountToCook_ != 0)
			{
				StepAmount stepAmount = amountToCook_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (amountToCook_ = new StepAmount());
					StepAmount stepAmount3 = amountToCook_;
				}
				StepAmount other2 = other.amountToCook_;
				stepAmount.MergeFrom(other2);
			}
			if (other.conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
			{
				ConditionTypeOneofCase conditionTypeOneofCase = conditionTypeCase_;
				object obj = default(object);
				if (conditionTypeOneofCase == ConditionTypeOneofCase.TargetMealItem)
				{
					obj = conditionType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					ItemSelector itemSelector = (ItemSelector)(conditionType_ = new ItemSelector());
					conditionTypeCase_ = conditionTypeOneofCase;
				}
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					object obj2 = conditionType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					object obj3 = other.conditionType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(StepAmount).TypeHandle != 4)
			{
			}
			if (TargetIngredientItem == null)
			{
				conditionTypeCase_ = (ConditionTypeOneofCase)(conditionType_ = new ItemSelector());
			}
			ItemSelector targetIngredientItem = TargetIngredientItem;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600386C")]
		[Cpp2IlInjected.Address(RVA = "0x2D53710", Offset = "0x2D52110", VA = "0x182D53710", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0054: Expected I4, but got O
			//IL_009d: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 18)
			{
				ItemSelector itemSelector = new ItemSelector();
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
				{
					if (conditionTypeCase_ != ConditionTypeOneofCase.TargetMealItem)
					{
					}
					object obj = conditionType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(itemSelector);
				conditionType_ = itemSelector;
				conditionTypeCase_ = (ConditionTypeOneofCase)itemSelector;
			}
			if (num == 34)
			{
				ItemSelector builder = new ItemSelector();
				if (conditionTypeCase_ == ConditionTypeOneofCase.TargetIngredientItem)
				{
					if (conditionTypeCase_ != ConditionTypeOneofCase.TargetIngredientItem)
					{
					}
					object obj2 = conditionType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				conditionType_ = builder;
				conditionTypeCase_ = (ConditionTypeOneofCase)typeof(ItemSelector).TypeHandle;
			}
			if ((long)typeof(ItemSelector).TypeHandle == 82)
			{
				StepAmount builder2 = default(StepAmount);
				if (amountToCook_ == null)
				{
					StepAmount stepAmount = (amountToCook_ = new StepAmount());
					builder2 = amountToCook_;
				}
				input.ReadMessage(builder2);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600386D")]
		[Cpp2IlInjected.Address(RVA = "0x2D53400", Offset = "0x2D51E00", VA = "0x182D53400", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 2)
			{
				goto IL_001c;
			}
			if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
			{
				object obj = conditionType_;
				if (obj != null)
				{
					if (obj != null)
					{
						goto IL_001c;
					}
					goto IL_0054;
				}
			}
			goto IL_0044;
			IL_0044:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0054;
			IL_0038:
			if (fieldNumber == 10)
			{
				StepAmount stepAmount = amountToCook_;
			}
			goto IL_0044;
			IL_0054:
			throw new InvalidCastException();
			IL_001c:
			if (fieldNumber != 4)
			{
				goto IL_0038;
			}
			if (conditionTypeCase_ == ConditionTypeOneofCase.TargetIngredientItem)
			{
				object obj2 = conditionType_;
				if (obj2 != null)
				{
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					goto IL_0038;
				}
			}
			goto IL_0044;
		}

		[Cpp2IlInjected.Token(Token = "0x600386E")]
		[Cpp2IlInjected.Address(RVA = "0x2D53CF0", Offset = "0x2D526F0", VA = "0x182D53CF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			//IL_0020: Expected I4, but got O
			//IL_003f: Expected I4, but got O
			switch (fieldNumber)
			{
			case 2:
			{
				int num = 0;
				if (value == null || value != null)
				{
					conditionType_ = num;
					conditionTypeCase_ = (ConditionTypeOneofCase)typeof(StepAmount).TypeHandle;
					break;
				}
				throw new InvalidCastException();
			}
			case 4:
				if (value == null || value != null)
				{
					conditionType_ = value;
					conditionTypeCase_ = (ConditionTypeOneofCase)typeof(StepAmount).TypeHandle;
					break;
				}
				throw new InvalidCastException();
			default:
				if (value == null || value != null)
				{
					conditionType_ = value;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600386F")]
		[Cpp2IlInjected.Address(RVA = "0x2D52EE0", Offset = "0x2D518E0", VA = "0x182D52EE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 2)
			{
				conditionTypeCase_ = ConditionTypeOneofCase.None;
				return;
			}
			while (true)
			{
				switch (fieldNumber)
				{
				case 4:
					break;
				default:
					return;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003870")]
		[Cpp2IlInjected.Address(RVA = "0x2D53660", Offset = "0x2D52060", VA = "0x182D53660", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ConditionType"))
			{
				ConditionTypeOneofCase conditionTypeOneofCase = conditionTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003871")]
		[Cpp2IlInjected.Address(RVA = "0x2D52F40", Offset = "0x2D51940", VA = "0x182D52F40", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ConditionType"))
			{
				conditionType_ = (conditionTypeCase_ = ConditionTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003875")]
		[Cpp2IlInjected.Address(RVA = "0x2D53010", Offset = "0x2D51A10", VA = "0x182D53010", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0058
			if (conditionTypeCase_ == ConditionTypeOneofCase.TargetIngredientItem)
			{
				if (conditionTypeCase_ != ConditionTypeOneofCase.TargetIngredientItem)
				{
					goto IL_0039;
				}
				object obj = conditionType_;
				if (obj == null)
				{
					goto IL_003b;
				}
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (conditionTypeCase_ == ConditionTypeOneofCase.TargetMealItem)
			{
				object obj2 = conditionType_;
				if (obj2 == null)
				{
					goto IL_003b;
				}
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			goto IL_0039;
			IL_0039:
			int num = 0;
			goto IL_003b;
			IL_003b:
			string missionStepName = context.MissionStepName;
			string error = "Cannot be None in " + missionStepName;
			context.AddError(error);
		}

		[Cpp2IlInjected.Token(Token = "0x6003876")]
		[Cpp2IlInjected.Address(RVA = "0x2D53FD0", Offset = "0x2D529D0", VA = "0x182D53FD0")]
		static CustomStepCookMeal()
		{
			Func<CustomStepCookMeal> func = default(Func<CustomStepCookMeal>);
			_parser = (MessageParser<CustomStepCookMeal>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
