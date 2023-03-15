using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004FA")]
	public sealed class CustomStepDressUp : IMessage<CustomStepDressUp>, IMessage, IEquatable<CustomStepDressUp>, IDeepCloneable<CustomStepDressUp>, IMessageFieldAccessor, IItemSelector, IStepAmount, IStringTag, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001A96")]
		private static readonly MessageParser<CustomStepDressUp> _parser = (MessageParser<CustomStepDressUp>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CustomStepDressUp()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A97")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A98")]
		public const int TargetItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A99")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001A9A")]
		public const int AmountToWearFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001A9B")]
		private StepAmount amountToWear_;

		[Cpp2IlInjected.Token(Token = "0x17000FBB")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepDressUp> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003D67")]
			[Cpp2IlInjected.Address(RVA = "0x34DFB30", Offset = "0x34DE530", VA = "0x1834DFB30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003D68")]
			[Cpp2IlInjected.Address(RVA = "0x34DFA60", Offset = "0x34DE460", VA = "0x1834DFA60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003D69")]
			[Cpp2IlInjected.Address(RVA = "0x34E01A0", Offset = "0x34DEBA0", VA = "0x1834E01A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBE")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003D6E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D6F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBF")]
		[DebuggerNonUserCode]
		public StepAmount AmountToWear
		{
			[Cpp2IlInjected.Token(Token = "0x6003D70")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return amountToWear_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D71")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				amountToWear_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC0")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003D7D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC1")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003D7E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return amountToWear_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC2")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003D7F")]
			[Cpp2IlInjected.Address(RVA = "0x34DFB90", Offset = "0x34DE590", VA = "0x1834DFB90", Slot = "16")]
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
					if ("Complexity" != null && "Complexity" == null)
					{
						continue;
					}
					array[3] = "Complexity";
					if ("Mood" != null && "Mood" == null)
					{
						continue;
					}
					array[4] = "Mood";
					if ("Sturdiness" != null && "Sturdiness" == null)
					{
						continue;
					}
					array[5] = "Sturdiness";
					if ("Normality" != null && "Normality" == null)
					{
						continue;
					}
					array[6] = "Normality";
					if ("MinRarity" != null && "MinRarity" == null)
					{
						continue;
					}
					array[7] = "MinRarity";
					if ("MaxRarity" != null && "MaxRarity" == null)
					{
						continue;
					}
					array[8] = "MaxRarity";
					if ("Color" != null && "Color" == null)
					{
						continue;
					}
					array[9] = "Color";
					if ("Style" != null && "Style" == null)
					{
						continue;
					}
					array[10] = "Style";
					if ("Type" == null || "Type" != null)
					{
						array[11] = "Type";
						if ("Universe" == null || "Universe" != null)
						{
							break;
						}
					}
				}
				array[12] = "Universe";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D6A")]
		[Cpp2IlInjected.Address(RVA = "0x34DF9C0", Offset = "0x34DE3C0", VA = "0x1834DF9C0")]
		[DebuggerNonUserCode]
		public CustomStepDressUp()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amountToWear_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D6B")]
		[Cpp2IlInjected.Address(RVA = "0x34DF5D0", Offset = "0x34DDFD0", VA = "0x1834DF5D0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amountToWear_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D6C")]
		[Cpp2IlInjected.Address(RVA = "0x34DF890", Offset = "0x34DE290", VA = "0x1834DF890")]
		[DebuggerNonUserCode]
		public CustomStepDressUp(CustomStepDressUp other)
		{
			//IL_003c: Expected O, but got I4
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (amountToWear_ = new StepAmount());
			ItemSelector itemSelector2 = other.targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.amountToWear_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			amountToWear_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D6D")]
		[Cpp2IlInjected.Address(RVA = "0x34DEE50", Offset = "0x34DD850", VA = "0x1834DEE50", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepDressUp Clone()
		{
			//Discarded unreachable code: IL_0073
			//IL_003e: Expected O, but got I4
			CustomStepDressUp customStepDressUp = new CustomStepDressUp();
			ItemSelector itemSelector = (customStepDressUp.targetItem_ = new ItemSelector());
			StepAmount stepAmount = (customStepDressUp.amountToWear_ = new StepAmount());
			ItemSelector itemSelector2 = targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			customStepDressUp.targetItem_ = (ItemSelector)num;
			StepAmount stepAmount2 = amountToWear_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepDressUp.amountToWear_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (customStepDressUp._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepDressUp;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D72")]
		[Cpp2IlInjected.Address(RVA = "0x34DF210", Offset = "0x34DDC10", VA = "0x1834DF210", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(targetItem_, other) && object.Equals(amountToWear_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D73")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepDressUp other)
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
					StepAmount objB2 = other.amountToWear_;
					if (object.Equals(amountToWear_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D74")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
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
				StepAmount stepAmount = amountToWear_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D75")]
		[Cpp2IlInjected.Address(RVA = "0x34DF720", Offset = "0x34DE120", VA = "0x1834DF720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D76")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)targetItem_ != 0)
			{
				ItemSelector value = targetItem_;
				output.WriteMessage(value);
			}
			if ((long)amountToWear_ != 0)
			{
				StepAmount value2 = amountToWear_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D77")]
		[Cpp2IlInjected.Address(RVA = "0x34DED80", Offset = "0x34DD780", VA = "0x1834DED80", Slot = "7")]
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
				StepAmount stepAmount = amountToWear_;
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

		[Cpp2IlInjected.Token(Token = "0x6003D78")]
		[Cpp2IlInjected.Address(RVA = "0x34DF360", Offset = "0x34DDD60", VA = "0x1834DF360", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepDressUp other)
		{
			//Discarded unreachable code: IL_009b
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
			if ((long)other.amountToWear_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amountToWear_ == null)
				{
					StepAmount stepAmount = (amountToWear_ = new StepAmount());
					stepAmount2 = amountToWear_;
				}
				StepAmount other3 = other.amountToWear_;
				stepAmount2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003D79")]
		[Cpp2IlInjected.Address(RVA = "0x34DF490", Offset = "0x34DDE90", VA = "0x1834DF490", Slot = "5")]
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
				ItemSelector itemSelector = targetItem_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (targetItem_ = new ItemSelector());
				}
				input.ReadMessage(itemSelector);
			}
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (amountToWear_ == null)
				{
					StepAmount stepAmount = (amountToWear_ = new StepAmount());
					builder = amountToWear_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003D7A")]
		[Cpp2IlInjected.Address(RVA = "0x34DF2D0", Offset = "0x34DDCD0", VA = "0x1834DF2D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemSelector itemSelector = targetItem_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount = amountToWear_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D7B")]
		[Cpp2IlInjected.Address(RVA = "0x34DF660", Offset = "0x34DE060", VA = "0x1834DF660", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					targetItem_ = (ItemSelector)num;
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

		[Cpp2IlInjected.Token(Token = "0x6003D7C")]
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

		[Cpp2IlInjected.Token(Token = "0x6003D80")]
		[Cpp2IlInjected.Address(RVA = "0x31FC4E0", Offset = "0x31FAEE0", VA = "0x1831FC4E0", Slot = "17")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			amountToWear_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D81")]
		[Cpp2IlInjected.Address(RVA = "0x34DEFB0", Offset = "0x34DD9B0", VA = "0x1834DEFB0", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00ac
			if (amountToWear_.IsValueSmallerThen(1))
			{
				string missionStepName = context.MissionStepName;
				string message = "Should be 1+ in " + missionStepName;
				context.AddInvalidMemberError(message, "AmountToWear");
			}
			MissionItemGenerator filterGenerator = default(MissionItemGenerator);
			if (targetItem_.ItemGenerator == null)
			{
				filterGenerator = targetItem_.FilterGenerator;
				if (filterGenerator == null)
				{
					return;
				}
			}
			RepeatedField<TagGroupWithRndOption> tags_ = filterGenerator.tags_;
			Predicate<TagGroupWithRndOption> predicate = default(Predicate<TagGroupWithRndOption>);
			if (_003C_003Ec._003C_003E9__40_0 == null)
			{
				predicate = (Predicate<TagGroupWithRndOption>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(TagGroupWithRndOption x)
				{
					//Discarded unreachable code: IL_0017
					if (x.tagType_ != TagItemType.ApparelType)
					{
						int num = 0;
					}
					return Enumerable.Any<int>((IEnumerable<>)(object)x.tags_);
				});
			}
			if (((RepeatedField<>)(object)tags_).Any<TagGroupWithRndOption>((Predicate<>)(object)predicate))
			{
				ScalableValue value = amountToWear_.Value;
				if (value != null && value.value_ > 1)
				{
					context.AddInvalidMemberError("Value should be limited to 1", "AmountToWear");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D82")]
		[Cpp2IlInjected.Address(RVA = "0x34DF780", Offset = "0x34DE180", VA = "0x1834DF780")]
		static CustomStepDressUp()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
