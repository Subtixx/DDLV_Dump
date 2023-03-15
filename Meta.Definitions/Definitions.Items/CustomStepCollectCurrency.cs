using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004AC")]
	public sealed class CustomStepCollectCurrency : IMessage<CustomStepCollectCurrency>, IMessage, IEquatable<CustomStepCollectCurrency>, IDeepCloneable<CustomStepCollectCurrency>, IMessageFieldAccessor, IStepAmount, IStringTag, IItemSelector
	{
		[Cpp2IlInjected.Token(Token = "0x40018FF")]
		private static readonly MessageParser<CustomStepCollectCurrency> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001900")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001901")]
		public const int CurrencyTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001902")]
		private ItemSelector currencyType_;

		[Cpp2IlInjected.Token(Token = "0x4001903")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001904")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000EA6")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepCollectCurrency> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003972")]
			[Cpp2IlInjected.Address(RVA = "0x2D50940", Offset = "0x2D4F340", VA = "0x182D50940")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003973")]
			[Cpp2IlInjected.Address(RVA = "0x2D50870", Offset = "0x2D4F270", VA = "0x182D50870")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003974")]
			[Cpp2IlInjected.Address(RVA = "0x2D50AC0", Offset = "0x2D4F4C0", VA = "0x182D50AC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA9")]
		[DebuggerNonUserCode]
		public ItemSelector CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6003979")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return currencyType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600397A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				currencyType_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EAA")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600397B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600397C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EAB")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003988")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "14")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EAC")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003989")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "16")]
			get
			{
				return currencyType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EAD")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x600398A")]
			[Cpp2IlInjected.Address(RVA = "0x2D509A0", Offset = "0x2D4F3A0", VA = "0x182D509A0", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x6003975")]
		[Cpp2IlInjected.Address(RVA = "0x2D507D0", Offset = "0x2D4F1D0", VA = "0x182D507D0")]
		[DebuggerNonUserCode]
		public CustomStepCollectCurrency()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			ItemSelector itemSelector = (currencyType_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003976")]
		[Cpp2IlInjected.Address(RVA = "0x2D503E0", Offset = "0x2D4EDE0", VA = "0x182D503E0")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			ItemSelector itemSelector = (currencyType_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003977")]
		[Cpp2IlInjected.Address(RVA = "0x2D506A0", Offset = "0x2D4F0A0", VA = "0x182D506A0")]
		[DebuggerNonUserCode]
		public CustomStepCollectCurrency(CustomStepCollectCurrency other)
		{
			//IL_003c: Expected O, but got I4
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			ItemSelector itemSelector = (currencyType_ = new ItemSelector());
			ItemSelector itemSelector2 = other.currencyType_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			currencyType_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.targetAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			targetAmount_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003978")]
		[Cpp2IlInjected.Address(RVA = "0x2D4FEC0", Offset = "0x2D4E8C0", VA = "0x182D4FEC0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepCollectCurrency Clone()
		{
			//Discarded unreachable code: IL_0073
			//IL_003e: Expected O, but got I4
			CustomStepCollectCurrency customStepCollectCurrency = new CustomStepCollectCurrency();
			StepAmount stepAmount = (customStepCollectCurrency.targetAmount_ = new StepAmount());
			ItemSelector itemSelector = (customStepCollectCurrency.currencyType_ = new ItemSelector());
			ItemSelector itemSelector2 = currencyType_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			customStepCollectCurrency.currencyType_ = (ItemSelector)num;
			StepAmount stepAmount2 = targetAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepCollectCurrency.targetAmount_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (customStepCollectCurrency._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepCollectCurrency;
		}

		[Cpp2IlInjected.Token(Token = "0x600397D")]
		[Cpp2IlInjected.Address(RVA = "0x2D50020", Offset = "0x2D4EA20", VA = "0x182D50020", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(currencyType_, other) && object.Equals(targetAmount_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600397E")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepCollectCurrency other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.currencyType_;
				if (object.Equals(currencyType_, objB))
				{
					StepAmount objB2 = other.targetAmount_;
					if (object.Equals(targetAmount_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600397F")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = currencyType_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = targetAmount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003980")]
		[Cpp2IlInjected.Address(RVA = "0x2D50530", Offset = "0x2D4EF30", VA = "0x182D50530", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003981")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)currencyType_ != 0)
			{
				ItemSelector value = currencyType_;
				output.WriteMessage(value);
			}
			if ((long)targetAmount_ != 0)
			{
				StepAmount value2 = targetAmount_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003982")]
		[Cpp2IlInjected.Address(RVA = "0x2D4FDF0", Offset = "0x2D4E7F0", VA = "0x182D4FDF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = currencyType_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
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

		[Cpp2IlInjected.Token(Token = "0x6003983")]
		[Cpp2IlInjected.Address(RVA = "0x2D50170", Offset = "0x2D4EB70", VA = "0x182D50170", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepCollectCurrency other)
		{
			//Discarded unreachable code: IL_0097
			if (other == null)
			{
				return;
			}
			if ((long)other.currencyType_ != 0)
			{
				ItemSelector itemSelector2 = default(ItemSelector);
				if (currencyType_ == null)
				{
					ItemSelector itemSelector = (currencyType_ = new ItemSelector());
					itemSelector2 = currencyType_;
				}
				ItemSelector other2 = other.currencyType_;
				itemSelector2.MergeFrom(other2);
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					stepAmount2 = targetAmount_;
				}
				StepAmount other3 = other.targetAmount_;
				stepAmount2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003984")]
		[Cpp2IlInjected.Address(RVA = "0x2D502A0", Offset = "0x2D4ECA0", VA = "0x182D502A0", Slot = "5")]
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
				ItemSelector itemSelector = currencyType_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (currencyType_ = new ItemSelector());
				}
				input.ReadMessage(itemSelector);
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

		[Cpp2IlInjected.Token(Token = "0x6003985")]
		[Cpp2IlInjected.Address(RVA = "0x2D500E0", Offset = "0x2D4EAE0", VA = "0x182D500E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemSelector itemSelector = currencyType_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount = targetAmount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003986")]
		[Cpp2IlInjected.Address(RVA = "0x2D50470", Offset = "0x2D4EE70", VA = "0x182D50470", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					currencyType_ = (ItemSelector)num;
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

		[Cpp2IlInjected.Token(Token = "0x6003987")]
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

		[Cpp2IlInjected.Token(Token = "0x600398B")]
		[Cpp2IlInjected.Address(RVA = "0x2D50590", Offset = "0x2D4EF90", VA = "0x182D50590")]
		static CustomStepCollectCurrency()
		{
			Func<CustomStepCollectCurrency> func = default(Func<CustomStepCollectCurrency>);
			_parser = (MessageParser<CustomStepCollectCurrency>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
