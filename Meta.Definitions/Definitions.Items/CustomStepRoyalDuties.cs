using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004D1")]
	public sealed class CustomStepRoyalDuties : IMessage<CustomStepRoyalDuties>, IMessage, IEquatable<CustomStepRoyalDuties>, IDeepCloneable<CustomStepRoyalDuties>, IMessageFieldAccessor, IStringTag, IStepAmount, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40019B6")]
		private static readonly MessageParser<CustomStepRoyalDuties> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40019B7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40019B8")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019B9")]
		private DutyType type_;

		[Cpp2IlInjected.Token(Token = "0x40019BA")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019BB")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000F2C")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepRoyalDuties> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003B47")]
			[Cpp2IlInjected.Address(RVA = "0x31FDA00", Offset = "0x31FC400", VA = "0x1831FDA00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B48")]
			[Cpp2IlInjected.Address(RVA = "0x31FD930", Offset = "0x31FC330", VA = "0x1831FD930")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B49")]
			[Cpp2IlInjected.Address(RVA = "0x31FDB80", Offset = "0x31FC580", VA = "0x1831FDB80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2F")]
		[DebuggerNonUserCode]
		public DutyType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6003B4E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B4F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F30")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003B50")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B51")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F31")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003B5D")]
			[Cpp2IlInjected.Address(RVA = "0x31FDA60", Offset = "0x31FC460", VA = "0x1831FDA60", Slot = "14")]
			get
			{
				//Discarded unreachable code: IL_0041
				string[] array;
				while (true)
				{
					array = new string[2];
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[0] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[1] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F32")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003B5E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B4A")]
		[Cpp2IlInjected.Address(RVA = "0x31FD8C0", Offset = "0x31FC2C0", VA = "0x1831FD8C0")]
		[DebuggerNonUserCode]
		public CustomStepRoyalDuties()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B4B")]
		[Cpp2IlInjected.Address(RVA = "0x31FD550", Offset = "0x31FBF50", VA = "0x1831FD550")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B4C")]
		[Cpp2IlInjected.Address(RVA = "0x31FD7F0", Offset = "0x31FC1F0", VA = "0x1831FD7F0")]
		[DebuggerNonUserCode]
		public CustomStepRoyalDuties(CustomStepRoyalDuties other)
		{
			//IL_003e: Expected O, but got I4
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			DutyType dutyType = (type_ = other.type_);
			StepAmount stepAmount2 = other.targetAmount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			int num = 0;
			targetAmount_ = (StepAmount)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B4D")]
		[Cpp2IlInjected.Address(RVA = "0x31FD060", Offset = "0x31FBA60", VA = "0x1831FD060", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepRoyalDuties Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_003f: Expected O, but got I4
			CustomStepRoyalDuties customStepRoyalDuties = new CustomStepRoyalDuties();
			StepAmount stepAmount = (customStepRoyalDuties.targetAmount_ = new StepAmount());
			DutyType dutyType = (customStepRoyalDuties.type_ = type_);
			StepAmount stepAmount2 = targetAmount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			int num = 0;
			customStepRoyalDuties.targetAmount_ = (StepAmount)num;
			UnknownFieldSet unknownFieldSet = (customStepRoyalDuties._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepRoyalDuties;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B52")]
		[Cpp2IlInjected.Address(RVA = "0x31FD200", Offset = "0x31FBC00", VA = "0x1831FD200", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)type_ == (IntPtr)typeof(CustomStepRoyalDuties).TypeHandle && object.Equals(targetAmount_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B53")]
		[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepRoyalDuties other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				DutyType dutyType = other.type_;
				if (type_ == dutyType)
				{
					StepAmount objB = other.targetAmount_;
					if (object.Equals(targetAmount_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B54")]
		[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (type_ != 0)
				{
				}
				StepAmount stepAmount = targetAmount_;
				if (stepAmount != null)
				{
					int hashCode = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B55")]
		[Cpp2IlInjected.Address(RVA = "0x31FD680", Offset = "0x31FC080", VA = "0x1831FD680", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B56")]
		[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0035
			if (type_ != 0)
			{
			}
			if ((long)targetAmount_ != 0)
			{
				StepAmount value = targetAmount_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B57")]
		[Cpp2IlInjected.Address(RVA = "0x31FCF90", Offset = "0x31FB990", VA = "0x1831FCF90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				DutyType dutyType = type_;
				num = 0;
				if (dutyType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)dutyType);
				}
				StepAmount stepAmount = targetAmount_;
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

		[Cpp2IlInjected.Token(Token = "0x6003B58")]
		[Cpp2IlInjected.Address(RVA = "0x31FD470", Offset = "0x31FBE70", VA = "0x1831FD470", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepRoyalDuties other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			DutyType dutyType = other.type_;
			if (dutyType != 0)
			{
				type_ = dutyType;
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					stepAmount2 = targetAmount_;
				}
				StepAmount other2 = other.targetAmount_;
				stepAmount2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003B59")]
		[Cpp2IlInjected.Address(RVA = "0x31FD380", Offset = "0x31FBD80", VA = "0x1831FD380", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (int)(type_ = (DutyType)input.ReadInt32());
			}
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					builder = targetAmount_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003B5A")]
		[Cpp2IlInjected.Address(RVA = "0x31FD2B0", Offset = "0x31FBCB0", VA = "0x1831FD2B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				DutyType dutyType = type_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount = targetAmount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B5B")]
		[Cpp2IlInjected.Address(RVA = "0x31FD5B0", Offset = "0x31FBFB0", VA = "0x1831FD5B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				type_ = (DutyType)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				targetAmount_ = (StepAmount)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B5C")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				type_ = DutyType.None;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B5F")]
		[Cpp2IlInjected.Address(RVA = "0x31FD160", Offset = "0x31FBB60", VA = "0x1831FD160", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_002f
			if (targetAmount_.IsValueSmallerThen(1))
			{
				string missionStepName = context.MissionStepName;
				string message = "Should be 1+ in " + missionStepName;
				context.AddInvalidMemberError(message, "TargetAmount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B60")]
		[Cpp2IlInjected.Address(RVA = "0x31FD6E0", Offset = "0x31FC0E0", VA = "0x1831FD6E0")]
		static CustomStepRoyalDuties()
		{
			Func<CustomStepRoyalDuties> func = default(Func<CustomStepRoyalDuties>);
			_parser = (MessageParser<CustomStepRoyalDuties>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
