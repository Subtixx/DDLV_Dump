using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004DA")]
	public sealed class CustomStepPetCompanion : IMessage<CustomStepPetCompanion>, IMessage, IEquatable<CustomStepPetCompanion>, IDeepCloneable<CustomStepPetCompanion>, IMessageFieldAccessor, IStepAmount
	{
		[Cpp2IlInjected.Token(Token = "0x40019D7")]
		private static readonly MessageParser<CustomStepPetCompanion> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40019D8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40019D9")]
		public const int TargetAmountFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019DA")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000F46")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepPetCompanion> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003BA7")]
			[Cpp2IlInjected.Address(RVA = "0x31F2620", Offset = "0x31F1020", VA = "0x1831F2620")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F47")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003BA8")]
			[Cpp2IlInjected.Address(RVA = "0x31F2550", Offset = "0x31F0F50", VA = "0x1831F2550")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F48")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003BA9")]
			[Cpp2IlInjected.Address(RVA = "0x31F2680", Offset = "0x31F1080", VA = "0x1831F2680", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F49")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003BAE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BAF")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F4A")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003BBB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAA")]
		[Cpp2IlInjected.Address(RVA = "0x31F2410", Offset = "0x31F0E10", VA = "0x1831F2410")]
		[DebuggerNonUserCode]
		public CustomStepPetCompanion()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAB")]
		[Cpp2IlInjected.Address(RVA = "0x31F21C0", Offset = "0x31F0BC0", VA = "0x1831F21C0")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAC")]
		[Cpp2IlInjected.Address(RVA = "0x31F2480", Offset = "0x31F0E80", VA = "0x1831F2480")]
		[DebuggerNonUserCode]
		public CustomStepPetCompanion(CustomStepPetCompanion other)
		{
			//IL_002e: Expected O, but got I4
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
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

		[Cpp2IlInjected.Token(Token = "0x6003BAD")]
		[Cpp2IlInjected.Address(RVA = "0x31F1DE0", Offset = "0x31F07E0", VA = "0x1831F1DE0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepPetCompanion Clone()
		{
			//Discarded unreachable code: IL_0047
			//IL_0030: Expected O, but got I4
			CustomStepPetCompanion customStepPetCompanion = new CustomStepPetCompanion();
			StepAmount stepAmount = (customStepPetCompanion.targetAmount_ = new StepAmount());
			StepAmount stepAmount2 = targetAmount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			int num = 0;
			customStepPetCompanion.targetAmount_ = (StepAmount)num;
			UnknownFieldSet unknownFieldSet = (customStepPetCompanion._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepPetCompanion;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BB0")]
		[Cpp2IlInjected.Address(RVA = "0x31F1EE0", Offset = "0x31F08E0", VA = "0x1831F1EE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(targetAmount_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BB1")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepPetCompanion other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				StepAmount objB = other.targetAmount_;
				if (object.Equals(targetAmount_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BB2")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
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

		[Cpp2IlInjected.Token(Token = "0x6003BB3")]
		[Cpp2IlInjected.Address(RVA = "0x31F22A0", Offset = "0x31F0CA0", VA = "0x1831F22A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003BB4")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)targetAmount_ != 0)
			{
				StepAmount value = targetAmount_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003BB5")]
		[Cpp2IlInjected.Address(RVA = "0x31F1D40", Offset = "0x31F0740", VA = "0x1831F1D40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				StepAmount stepAmount = targetAmount_;
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

		[Cpp2IlInjected.Token(Token = "0x6003BB6")]
		[Cpp2IlInjected.Address(RVA = "0x31F2010", Offset = "0x31F0A10", VA = "0x1831F2010", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepPetCompanion other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount = targetAmount_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (targetAmount_ = new StepAmount());
				}
				StepAmount other2 = other.targetAmount_;
				stepAmount.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003BB7")]
		[Cpp2IlInjected.Address(RVA = "0x31F20E0", Offset = "0x31F0AE0", VA = "0x1831F20E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				StepAmount stepAmount = targetAmount_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (targetAmount_ = new StepAmount());
				}
				input.ReadMessage(stepAmount);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003BB8")]
		[Cpp2IlInjected.Address(RVA = "0x31F1F90", Offset = "0x31F0990", VA = "0x1831F1F90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				StepAmount stepAmount = targetAmount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BB9")]
		[Cpp2IlInjected.Address(RVA = "0x31F2220", Offset = "0x31F0C20", VA = "0x1831F2220", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				targetAmount_ = (StepAmount)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BBA")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BBC")]
		[Cpp2IlInjected.Address(RVA = "0x31F2300", Offset = "0x31F0D00", VA = "0x1831F2300")]
		static CustomStepPetCompanion()
		{
			Func<CustomStepPetCompanion> func = default(Func<CustomStepPetCompanion>);
			_parser = (MessageParser<CustomStepPetCompanion>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
