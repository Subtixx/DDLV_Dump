using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200046F")]
	public sealed class TargetAnyWithAmount : IMessage<TargetAnyWithAmount>, IMessage, IEquatable<TargetAnyWithAmount>, IDeepCloneable<TargetAnyWithAmount>, IMessageFieldAccessor, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x40017E5")]
		private static readonly MessageParser<TargetAnyWithAmount> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40017E6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40017E7")]
		public const int TargetAmountFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40017E8")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000DD7")]
		[DebuggerNonUserCode]
		public static MessageParser<TargetAnyWithAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003658")]
			[Cpp2IlInjected.Address(RVA = "0x2565BB0", Offset = "0x25645B0", VA = "0x182565BB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003659")]
			[Cpp2IlInjected.Address(RVA = "0x2565AE0", Offset = "0x25644E0", VA = "0x182565AE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600365A")]
			[Cpp2IlInjected.Address(RVA = "0x2565C10", Offset = "0x2564610", VA = "0x182565C10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DDA")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600365F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003660")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600365B")]
		[Cpp2IlInjected.Address(RVA = "0x25659A0", Offset = "0x25643A0", VA = "0x1825659A0")]
		[DebuggerNonUserCode]
		public TargetAnyWithAmount()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600365C")]
		[Cpp2IlInjected.Address(RVA = "0x2565720", Offset = "0x2564120", VA = "0x182565720")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600365D")]
		[Cpp2IlInjected.Address(RVA = "0x2565A10", Offset = "0x2564410", VA = "0x182565A10")]
		[DebuggerNonUserCode]
		public TargetAnyWithAmount(TargetAnyWithAmount other)
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

		[Cpp2IlInjected.Token(Token = "0x600365E")]
		[Cpp2IlInjected.Address(RVA = "0x2565340", Offset = "0x2563D40", VA = "0x182565340", Slot = "10")]
		[DebuggerNonUserCode]
		public TargetAnyWithAmount Clone()
		{
			//Discarded unreachable code: IL_0047
			//IL_0030: Expected O, but got I4
			TargetAnyWithAmount targetAnyWithAmount = new TargetAnyWithAmount();
			StepAmount stepAmount = (targetAnyWithAmount.targetAmount_ = new StepAmount());
			StepAmount stepAmount2 = targetAmount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			int num = 0;
			targetAnyWithAmount.targetAmount_ = (StepAmount)num;
			UnknownFieldSet unknownFieldSet = (targetAnyWithAmount._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return targetAnyWithAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x6003661")]
		[Cpp2IlInjected.Address(RVA = "0x2565440", Offset = "0x2563E40", VA = "0x182565440", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003662")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TargetAnyWithAmount other)
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

		[Cpp2IlInjected.Token(Token = "0x6003663")]
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

		[Cpp2IlInjected.Token(Token = "0x6003664")]
		[Cpp2IlInjected.Address(RVA = "0x2565830", Offset = "0x2564230", VA = "0x182565830", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003665")]
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

		[Cpp2IlInjected.Token(Token = "0x6003666")]
		[Cpp2IlInjected.Address(RVA = "0x25652A0", Offset = "0x2563CA0", VA = "0x1825652A0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6003667")]
		[Cpp2IlInjected.Address(RVA = "0x2565570", Offset = "0x2563F70", VA = "0x182565570", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TargetAnyWithAmount other)
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

		[Cpp2IlInjected.Token(Token = "0x6003668")]
		[Cpp2IlInjected.Address(RVA = "0x2565640", Offset = "0x2564040", VA = "0x182565640", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6003669")]
		[Cpp2IlInjected.Address(RVA = "0x25654F0", Offset = "0x2563EF0", VA = "0x1825654F0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x600366A")]
		[Cpp2IlInjected.Address(RVA = "0x25657B0", Offset = "0x25641B0", VA = "0x1825657B0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600366B")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600366C")]
		[Cpp2IlInjected.Address(RVA = "0x2565780", Offset = "0x2564180", VA = "0x182565780", Slot = "14")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			targetAmount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600366D")]
		[Cpp2IlInjected.Address(RVA = "0x2565890", Offset = "0x2564290", VA = "0x182565890")]
		static TargetAnyWithAmount()
		{
			Func<TargetAnyWithAmount> func = default(Func<TargetAnyWithAmount>);
			_parser = (MessageParser<TargetAnyWithAmount>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
