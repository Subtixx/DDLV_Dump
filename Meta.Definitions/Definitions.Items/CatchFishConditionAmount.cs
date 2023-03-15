using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004EB")]
	public sealed class CatchFishConditionAmount : IMessage<CatchFishConditionAmount>, IMessage, IEquatable<CatchFishConditionAmount>, IDeepCloneable<CatchFishConditionAmount>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001A5A")]
		private static readonly MessageParser<CatchFishConditionAmount> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A5B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A5C")]
		public const int AmountToCatchFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A5D")]
		private StepAmount amountToCatch_;

		[Cpp2IlInjected.Token(Token = "0x4001A5E")]
		public const int MinWeightRequiredFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001A5F")]
		private StepAmount minWeightRequired_;

		[Cpp2IlInjected.Token(Token = "0x4001A60")]
		public const int MaxWeightRequiredFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001A61")]
		private StepAmount maxWeightRequired_;

		[Cpp2IlInjected.Token(Token = "0x17000F90")]
		[DebuggerNonUserCode]
		public static MessageParser<CatchFishConditionAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003CAD")]
			[Cpp2IlInjected.Address(RVA = "0x28944F0", Offset = "0x2892EF0", VA = "0x1828944F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F91")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003CAE")]
			[Cpp2IlInjected.Address(RVA = "0x2894420", Offset = "0x2892E20", VA = "0x182894420")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F92")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003CAF")]
			[Cpp2IlInjected.Address(RVA = "0x2894550", Offset = "0x2892F50", VA = "0x182894550", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F93")]
		[DebuggerNonUserCode]
		public StepAmount AmountToCatch
		{
			[Cpp2IlInjected.Token(Token = "0x6003CB4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return amountToCatch_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003CB5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				amountToCatch_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F94")]
		[DebuggerNonUserCode]
		public StepAmount MinWeightRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6003CB6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return minWeightRequired_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003CB7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				minWeightRequired_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F95")]
		[DebuggerNonUserCode]
		public StepAmount MaxWeightRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6003CB8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return maxWeightRequired_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003CB9")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				maxWeightRequired_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB0")]
		[Cpp2IlInjected.Address(RVA = "0x2894330", Offset = "0x2892D30", VA = "0x182894330")]
		[DebuggerNonUserCode]
		public CatchFishConditionAmount()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2893F70", Offset = "0x2892970", VA = "0x182893F70")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (amountToCatch_ = new StepAmount());
			StepAmount stepAmount2 = (minWeightRequired_ = new StepAmount());
			StepAmount stepAmount3 = (maxWeightRequired_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2894350", Offset = "0x2892D50", VA = "0x182894350")]
		[DebuggerNonUserCode]
		public CatchFishConditionAmount(CatchFishConditionAmount other)
		{
			//IL_0027: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			OnConstruction();
			StepAmount stepAmount = other.amountToCatch_;
			int num = 0;
			if (stepAmount != null)
			{
				StepAmount stepAmount2 = stepAmount.Clone();
			}
			amountToCatch_ = (StepAmount)num;
			StepAmount stepAmount3 = other.minWeightRequired_;
			if (stepAmount3 != null)
			{
				StepAmount stepAmount4 = stepAmount3.Clone();
			}
			minWeightRequired_ = (StepAmount)num;
			StepAmount stepAmount5 = other.maxWeightRequired_;
			StepAmount stepAmount6 = default(StepAmount);
			if (stepAmount5 != null)
			{
				stepAmount6 = stepAmount5.Clone();
			}
			maxWeightRequired_ = stepAmount6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB3")]
		[Cpp2IlInjected.Address(RVA = "0x2893960", Offset = "0x2892360", VA = "0x182893960", Slot = "10")]
		[DebuggerNonUserCode]
		public CatchFishConditionAmount Clone()
		{
			//Discarded unreachable code: IL_0079
			//IL_0027: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			CatchFishConditionAmount catchFishConditionAmount = new CatchFishConditionAmount();
			catchFishConditionAmount.OnConstruction();
			StepAmount stepAmount = amountToCatch_;
			int num = 0;
			if (stepAmount != null)
			{
				StepAmount stepAmount2 = stepAmount.Clone();
			}
			catchFishConditionAmount.amountToCatch_ = (StepAmount)num;
			StepAmount stepAmount3 = minWeightRequired_;
			if (stepAmount3 != null)
			{
				StepAmount stepAmount4 = stepAmount3.Clone();
			}
			catchFishConditionAmount.minWeightRequired_ = (StepAmount)num;
			StepAmount stepAmount5 = maxWeightRequired_;
			StepAmount stepAmount6 = default(StepAmount);
			if (stepAmount5 != null)
			{
				stepAmount6 = stepAmount5.Clone();
			}
			catchFishConditionAmount.maxWeightRequired_ = stepAmount6;
			UnknownFieldSet unknownFieldSet = (catchFishConditionAmount._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return catchFishConditionAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CBA")]
		[Cpp2IlInjected.Address(RVA = "0x2893B10", Offset = "0x2892510", VA = "0x182893B10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(amountToCatch_, other) && object.Equals(minWeightRequired_, other) && object.Equals(maxWeightRequired_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CBB")]
		[Cpp2IlInjected.Address(RVA = "0x713280", Offset = "0x711C80", VA = "0x180713280", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CatchFishConditionAmount other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				StepAmount objB = other.amountToCatch_;
				if (object.Equals(amountToCatch_, objB))
				{
					StepAmount objB2 = other.minWeightRequired_;
					if (object.Equals(minWeightRequired_, objB2))
					{
						StepAmount objB3 = other.maxWeightRequired_;
						if (object.Equals(maxWeightRequired_, objB3))
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

		[Cpp2IlInjected.Token(Token = "0x6003CBC")]
		[Cpp2IlInjected.Address(RVA = "0x7133C0", Offset = "0x711DC0", VA = "0x1807133C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				StepAmount stepAmount = amountToCatch_;
				if (stepAmount != null)
				{
					int hashCode = stepAmount.GetHashCode();
				}
				StepAmount stepAmount2 = minWeightRequired_;
				if (stepAmount2 != null)
				{
					int hashCode2 = stepAmount2.GetHashCode();
				}
				StepAmount stepAmount3 = maxWeightRequired_;
				if (stepAmount3 != null)
				{
					int hashCode3 = stepAmount3.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CBD")]
		[Cpp2IlInjected.Address(RVA = "0x2894100", Offset = "0x2892B00", VA = "0x182894100", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CBE")]
		[Cpp2IlInjected.Address(RVA = "0x2894160", Offset = "0x2892B60", VA = "0x182894160", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			if ((long)amountToCatch_ != 0)
			{
				StepAmount value = amountToCatch_;
				output.WriteMessage(value);
			}
			if ((long)minWeightRequired_ != 0)
			{
				StepAmount value2 = minWeightRequired_;
				output.WriteMessage(value2);
			}
			if ((long)maxWeightRequired_ != 0)
			{
				StepAmount value3 = maxWeightRequired_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CBF")]
		[Cpp2IlInjected.Address(RVA = "0x2893800", Offset = "0x2892200", VA = "0x182893800", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				StepAmount stepAmount = amountToCatch_;
				num = 0;
				if (stepAmount != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(stepAmount);
				}
				StepAmount stepAmount2 = minWeightRequired_;
				if (stepAmount2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(stepAmount2);
					num3++;
					num += num3;
				}
				StepAmount stepAmount3 = maxWeightRequired_;
				if (stepAmount3 != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(stepAmount3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC0")]
		[Cpp2IlInjected.Address(RVA = "0x2893E00", Offset = "0x2892800", VA = "0x182893E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CatchFishConditionAmount other)
		{
			//Discarded unreachable code: IL_00d7
			if (other == null)
			{
				return;
			}
			if ((long)other.amountToCatch_ != 0)
			{
				StepAmount stepAmount = amountToCatch_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (amountToCatch_ = new StepAmount());
					StepAmount stepAmount3 = amountToCatch_;
				}
				StepAmount other2 = other.amountToCatch_;
				stepAmount.MergeFrom(other2);
			}
			if ((long)other.minWeightRequired_ != 0)
			{
				StepAmount stepAmount5 = default(StepAmount);
				if (minWeightRequired_ == null)
				{
					StepAmount stepAmount4 = (minWeightRequired_ = new StepAmount());
					stepAmount5 = minWeightRequired_;
				}
				StepAmount other3 = other.minWeightRequired_;
				stepAmount5.MergeFrom(other3);
			}
			if ((long)other.maxWeightRequired_ != 0)
			{
				StepAmount stepAmount7 = default(StepAmount);
				if (maxWeightRequired_ == null)
				{
					StepAmount stepAmount6 = (maxWeightRequired_ = new StepAmount());
					stepAmount7 = maxWeightRequired_;
				}
				StepAmount other4 = other.maxWeightRequired_;
				stepAmount7.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC1")]
		[Cpp2IlInjected.Address(RVA = "0x2893C90", Offset = "0x2892690", VA = "0x182893C90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 82)
			{
				StepAmount stepAmount = amountToCatch_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (amountToCatch_ = new StepAmount());
				}
				input.ReadMessage(stepAmount);
			}
			StepAmount stepAmount3 = default(StepAmount);
			if (num == 90)
			{
				StepAmount builder = default(StepAmount);
				if (minWeightRequired_ == null)
				{
					stepAmount3 = (minWeightRequired_ = new StepAmount());
					builder = minWeightRequired_;
				}
				input.ReadMessage(builder);
			}
			if ((long)stepAmount3 == 98)
			{
				StepAmount builder2 = default(StepAmount);
				if (maxWeightRequired_ == null)
				{
					StepAmount stepAmount4 = (maxWeightRequired_ = new StepAmount());
					builder2 = maxWeightRequired_;
				}
				input.ReadMessage(builder2);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC2")]
		[Cpp2IlInjected.Address(RVA = "0x2893BF0", Offset = "0x28925F0", VA = "0x182893BF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				StepAmount stepAmount = maxWeightRequired_;
				StepAmount stepAmount2 = minWeightRequired_;
				StepAmount stepAmount3 = amountToCatch_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC3")]
		[Cpp2IlInjected.Address(RVA = "0x2894020", Offset = "0x2892A20", VA = "0x182894020", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001d: Expected O, but got I4
			if (fieldNumber != 0)
			{
				switch (fieldNumber)
				{
				case 1:
				{
					int num = 0;
					if (value == null || value != null)
					{
						maxWeightRequired_ = (StepAmount)num;
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

		[Cpp2IlInjected.Token(Token = "0x6003CC4")]
		[Cpp2IlInjected.Address(RVA = "0x2893910", Offset = "0x2892310", VA = "0x182893910", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC5")]
		[Cpp2IlInjected.Address(RVA = "0x2894330", Offset = "0x2892D30", VA = "0x182894330")]
		public CatchFishConditionAmount(string item_type)
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC6")]
		[Cpp2IlInjected.Address(RVA = "0x2893A70", Offset = "0x2892470", VA = "0x182893A70", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0033
			StepAmount stepAmount = amountToCatch_;
			int value = 0;
			if (stepAmount.IsValueSmallerThen(value))
			{
				string missionStepName = context.MissionStepName;
				string message = "Should be 0+ in " + missionStepName;
				context.AddInvalidMemberError(message, "AmountToCatch");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC7")]
		[Cpp2IlInjected.Address(RVA = "0x2894220", Offset = "0x2892C20", VA = "0x182894220")]
		static CatchFishConditionAmount()
		{
			Func<CatchFishConditionAmount> func = default(Func<CatchFishConditionAmount>);
			_parser = (MessageParser<CatchFishConditionAmount>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
