using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004ED")]
	public sealed class CatchFishConditionWeight : IMessage<CatchFishConditionWeight>, IMessage, IEquatable<CatchFishConditionWeight>, IDeepCloneable<CatchFishConditionWeight>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001A63")]
		private static readonly MessageParser<CatchFishConditionWeight> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A64")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A65")]
		public const int TotalWeightToCatchFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A66")]
		private StepAmount totalWeightToCatch_;

		[Cpp2IlInjected.Token(Token = "0x17000F96")]
		[DebuggerNonUserCode]
		public static MessageParser<CatchFishConditionWeight> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003CCB")]
			[Cpp2IlInjected.Address(RVA = "0x28967B0", Offset = "0x28951B0", VA = "0x1828967B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F97")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003CCC")]
			[Cpp2IlInjected.Address(RVA = "0x28966E0", Offset = "0x28950E0", VA = "0x1828966E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F98")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003CCD")]
			[Cpp2IlInjected.Address(RVA = "0x2896810", Offset = "0x2895210", VA = "0x182896810", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F99")]
		[DebuggerNonUserCode]
		public StepAmount TotalWeightToCatch
		{
			[Cpp2IlInjected.Token(Token = "0x6003CD2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return totalWeightToCatch_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003CD3")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				totalWeightToCatch_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CCE")]
		[Cpp2IlInjected.Address(RVA = "0x2896670", Offset = "0x2895070", VA = "0x182896670")]
		[DebuggerNonUserCode]
		public CatchFishConditionWeight()
		{
			StepAmount stepAmount = (totalWeightToCatch_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CCF")]
		[Cpp2IlInjected.Address(RVA = "0x28962F0", Offset = "0x2894CF0", VA = "0x1828962F0")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (totalWeightToCatch_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD0")]
		[Cpp2IlInjected.Address(RVA = "0x28965A0", Offset = "0x2894FA0", VA = "0x1828965A0")]
		[DebuggerNonUserCode]
		public CatchFishConditionWeight(CatchFishConditionWeight other)
		{
			//IL_002e: Expected O, but got I4
			StepAmount stepAmount = (totalWeightToCatch_ = new StepAmount());
			StepAmount stepAmount2 = other.totalWeightToCatch_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			int num = 0;
			totalWeightToCatch_ = (StepAmount)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD1")]
		[Cpp2IlInjected.Address(RVA = "0x2895E70", Offset = "0x2894870", VA = "0x182895E70", Slot = "10")]
		[DebuggerNonUserCode]
		public CatchFishConditionWeight Clone()
		{
			//Discarded unreachable code: IL_0047
			//IL_0030: Expected O, but got I4
			CatchFishConditionWeight catchFishConditionWeight = new CatchFishConditionWeight();
			StepAmount stepAmount = (catchFishConditionWeight.totalWeightToCatch_ = new StepAmount());
			StepAmount stepAmount2 = totalWeightToCatch_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			int num = 0;
			catchFishConditionWeight.totalWeightToCatch_ = (StepAmount)num;
			UnknownFieldSet unknownFieldSet = (catchFishConditionWeight._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return catchFishConditionWeight;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD4")]
		[Cpp2IlInjected.Address(RVA = "0x2896010", Offset = "0x2894A10", VA = "0x182896010", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(totalWeightToCatch_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD5")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CatchFishConditionWeight other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				StepAmount objB = other.totalWeightToCatch_;
				if (object.Equals(totalWeightToCatch_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD6")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				StepAmount stepAmount = totalWeightToCatch_;
				if (stepAmount != null)
				{
					int hashCode = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD7")]
		[Cpp2IlInjected.Address(RVA = "0x28963D0", Offset = "0x2894DD0", VA = "0x1828963D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD8")]
		[Cpp2IlInjected.Address(RVA = "0x2896430", Offset = "0x2894E30", VA = "0x182896430", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)totalWeightToCatch_ != 0)
			{
				StepAmount value = totalWeightToCatch_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD9")]
		[Cpp2IlInjected.Address(RVA = "0x2895DB0", Offset = "0x28947B0", VA = "0x182895DB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				StepAmount stepAmount = totalWeightToCatch_;
				num = 0;
				if (stepAmount != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(stepAmount);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDA")]
		[Cpp2IlInjected.Address(RVA = "0x2896140", Offset = "0x2894B40", VA = "0x182896140", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CatchFishConditionWeight other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.totalWeightToCatch_ != 0)
			{
				StepAmount stepAmount = totalWeightToCatch_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (totalWeightToCatch_ = new StepAmount());
				}
				StepAmount other2 = other.totalWeightToCatch_;
				stepAmount.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDB")]
		[Cpp2IlInjected.Address(RVA = "0x2896210", Offset = "0x2894C10", VA = "0x182896210", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 106)
			{
				StepAmount stepAmount = totalWeightToCatch_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (totalWeightToCatch_ = new StepAmount());
				}
				input.ReadMessage(stepAmount);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDC")]
		[Cpp2IlInjected.Address(RVA = "0x28960C0", Offset = "0x2894AC0", VA = "0x1828960C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 13)
			{
				StepAmount stepAmount = totalWeightToCatch_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDD")]
		[Cpp2IlInjected.Address(RVA = "0x2896350", Offset = "0x2894D50", VA = "0x182896350", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0016: Expected O, but got I4
			if (fieldNumber == 13)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				totalWeightToCatch_ = (StepAmount)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDE")]
		[Cpp2IlInjected.Address(RVA = "0x2895E50", Offset = "0x2894850", VA = "0x182895E50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 13)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDF")]
		[Cpp2IlInjected.Address(RVA = "0x2896670", Offset = "0x2895070", VA = "0x182896670")]
		public CatchFishConditionWeight(string item_type)
		{
			StepAmount stepAmount = (totalWeightToCatch_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CE0")]
		[Cpp2IlInjected.Address(RVA = "0x2895F70", Offset = "0x2894970", VA = "0x182895F70")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0033
			StepAmount stepAmount = totalWeightToCatch_;
			int value = 0;
			if (stepAmount.IsValueSmallerThen(value))
			{
				string missionStepName = context.MissionStepName;
				string message = "Should be 0+ in " + missionStepName;
				context.AddInvalidMemberError(message, "TotalWeightToCatch");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CE1")]
		[Cpp2IlInjected.Address(RVA = "0x2896490", Offset = "0x2894E90", VA = "0x182896490")]
		static CatchFishConditionWeight()
		{
			Func<CatchFishConditionWeight> func = default(Func<CatchFishConditionWeight>);
			_parser = (MessageParser<CatchFishConditionWeight>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
