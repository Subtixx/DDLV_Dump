using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004B3")]
	public sealed class CustomStepHangoutWithCharacter : IMessage<CustomStepHangoutWithCharacter>, IMessage, IEquatable<CustomStepHangoutWithCharacter>, IDeepCloneable<CustomStepHangoutWithCharacter>, IMessageFieldAccessor, IItemSelector, IStepAmount, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001929")]
		private static readonly MessageParser<CustomStepHangoutWithCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400192A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400192B")]
		public const int TargetCharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400192C")]
		private ItemSelector targetCharacter_;

		[Cpp2IlInjected.Token(Token = "0x400192D")]
		public const int AmountOfMinutesFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400192E")]
		private StepAmount amountOfMinutes_;

		[Cpp2IlInjected.Token(Token = "0x17000EC7")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepHangoutWithCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60039E0")]
			[Cpp2IlInjected.Address(RVA = "0x34EF200", Offset = "0x34EDC00", VA = "0x1834EF200")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60039E1")]
			[Cpp2IlInjected.Address(RVA = "0x34EF130", Offset = "0x34EDB30", VA = "0x1834EF130")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60039E2")]
			[Cpp2IlInjected.Address(RVA = "0x34EF260", Offset = "0x34EDC60", VA = "0x1834EF260", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ECA")]
		[DebuggerNonUserCode]
		public ItemSelector TargetCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60039E7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetCharacter_;
			}
			[Cpp2IlInjected.Token(Token = "0x60039E8")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetCharacter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ECB")]
		[DebuggerNonUserCode]
		public StepAmount AmountOfMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x60039E9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return amountOfMinutes_;
			}
			[Cpp2IlInjected.Token(Token = "0x60039EA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				amountOfMinutes_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ECC")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x60039F6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return targetCharacter_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ECD")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60039F7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return amountOfMinutes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039E3")]
		[Cpp2IlInjected.Address(RVA = "0x34EF090", Offset = "0x34EDA90", VA = "0x1834EF090")]
		[DebuggerNonUserCode]
		public CustomStepHangoutWithCharacter()
		{
			ItemSelector itemSelector = (targetCharacter_ = new ItemSelector());
			StepAmount stepAmount = (amountOfMinutes_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039E4")]
		[Cpp2IlInjected.Address(RVA = "0x34EECA0", Offset = "0x34ED6A0", VA = "0x1834EECA0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (targetCharacter_ = new ItemSelector());
			StepAmount stepAmount = (amountOfMinutes_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039E5")]
		[Cpp2IlInjected.Address(RVA = "0x34EEF60", Offset = "0x34ED960", VA = "0x1834EEF60")]
		[DebuggerNonUserCode]
		public CustomStepHangoutWithCharacter(CustomStepHangoutWithCharacter other)
		{
			//IL_003c: Expected O, but got I4
			ItemSelector itemSelector = (targetCharacter_ = new ItemSelector());
			StepAmount stepAmount = (amountOfMinutes_ = new StepAmount());
			ItemSelector itemSelector2 = other.targetCharacter_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetCharacter_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.amountOfMinutes_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			amountOfMinutes_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039E6")]
		[Cpp2IlInjected.Address(RVA = "0x34EE700", Offset = "0x34ED100", VA = "0x1834EE700", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepHangoutWithCharacter Clone()
		{
			//Discarded unreachable code: IL_0073
			//IL_003e: Expected O, but got I4
			CustomStepHangoutWithCharacter customStepHangoutWithCharacter = new CustomStepHangoutWithCharacter();
			ItemSelector itemSelector = (customStepHangoutWithCharacter.targetCharacter_ = new ItemSelector());
			StepAmount stepAmount = (customStepHangoutWithCharacter.amountOfMinutes_ = new StepAmount());
			ItemSelector itemSelector2 = targetCharacter_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			customStepHangoutWithCharacter.targetCharacter_ = (ItemSelector)num;
			StepAmount stepAmount2 = amountOfMinutes_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepHangoutWithCharacter.amountOfMinutes_ = stepAmount3;
			UnknownFieldSet unknownFieldSet = (customStepHangoutWithCharacter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepHangoutWithCharacter;
		}

		[Cpp2IlInjected.Token(Token = "0x60039EB")]
		[Cpp2IlInjected.Address(RVA = "0x34EE8E0", Offset = "0x34ED2E0", VA = "0x1834EE8E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(targetCharacter_, other) && object.Equals(amountOfMinutes_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039EC")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepHangoutWithCharacter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.targetCharacter_;
				if (object.Equals(targetCharacter_, objB))
				{
					StepAmount objB2 = other.amountOfMinutes_;
					if (object.Equals(amountOfMinutes_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039ED")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = targetCharacter_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = amountOfMinutes_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60039EE")]
		[Cpp2IlInjected.Address(RVA = "0x34EEDF0", Offset = "0x34ED7F0", VA = "0x1834EEDF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60039EF")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)targetCharacter_ != 0)
			{
				ItemSelector value = targetCharacter_;
				output.WriteMessage(value);
			}
			if ((long)amountOfMinutes_ != 0)
			{
				StepAmount value2 = amountOfMinutes_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60039F0")]
		[Cpp2IlInjected.Address(RVA = "0x34EE630", Offset = "0x34ED030", VA = "0x1834EE630", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = targetCharacter_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
				}
				StepAmount stepAmount = amountOfMinutes_;
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

		[Cpp2IlInjected.Token(Token = "0x60039F1")]
		[Cpp2IlInjected.Address(RVA = "0x34EEB70", Offset = "0x34ED570", VA = "0x1834EEB70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepHangoutWithCharacter other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.targetCharacter_ != 0)
			{
				ItemSelector itemSelector = targetCharacter_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (targetCharacter_ = new ItemSelector());
					ItemSelector itemSelector3 = targetCharacter_;
				}
				ItemSelector other2 = other.targetCharacter_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.amountOfMinutes_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amountOfMinutes_ == null)
				{
					StepAmount stepAmount = (amountOfMinutes_ = new StepAmount());
					stepAmount2 = amountOfMinutes_;
				}
				StepAmount other3 = other.amountOfMinutes_;
				stepAmount2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60039F2")]
		[Cpp2IlInjected.Address(RVA = "0x34EEA30", Offset = "0x34ED430", VA = "0x1834EEA30", Slot = "5")]
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
				ItemSelector itemSelector = targetCharacter_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (targetCharacter_ = new ItemSelector());
				}
				input.ReadMessage(itemSelector);
			}
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (amountOfMinutes_ == null)
				{
					StepAmount stepAmount = (amountOfMinutes_ = new StepAmount());
					builder = amountOfMinutes_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60039F3")]
		[Cpp2IlInjected.Address(RVA = "0x34EE9A0", Offset = "0x34ED3A0", VA = "0x1834EE9A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemSelector itemSelector = targetCharacter_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount = amountOfMinutes_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039F4")]
		[Cpp2IlInjected.Address(RVA = "0x34EED30", Offset = "0x34ED730", VA = "0x1834EED30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					targetCharacter_ = (ItemSelector)num;
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

		[Cpp2IlInjected.Token(Token = "0x60039F5")]
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

		[Cpp2IlInjected.Token(Token = "0x60039F8")]
		[Cpp2IlInjected.Address(RVA = "0x31FC4E0", Offset = "0x31FAEE0", VA = "0x1831FC4E0", Slot = "16")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			amountOfMinutes_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60039F9")]
		[Cpp2IlInjected.Address(RVA = "0x34EE860", Offset = "0x34ED260", VA = "0x1834EE860", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001f
			if (targetCharacter_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.None)
			{
				context.AddInvalidMemberError("Cannot be None", "TargetCharacter");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039FA")]
		[Cpp2IlInjected.Address(RVA = "0x34EEE50", Offset = "0x34ED850", VA = "0x1834EEE50")]
		static CustomStepHangoutWithCharacter()
		{
			Func<CustomStepHangoutWithCharacter> func = default(Func<CustomStepHangoutWithCharacter>);
			_parser = (MessageParser<CustomStepHangoutWithCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
