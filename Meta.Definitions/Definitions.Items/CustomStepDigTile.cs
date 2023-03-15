using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004B5")]
	public sealed class CustomStepDigTile : IMessage<CustomStepDigTile>, IMessage, IEquatable<CustomStepDigTile>, IDeepCloneable<CustomStepDigTile>, IMessageFieldAccessor, IStepAmount, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x4001930")]
		private static readonly MessageParser<CustomStepDigTile> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001931")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001932")]
		public const int TargetAmountFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001933")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001934")]
		public const int WithFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001935")]
		private HangoutWithCharacter with_;

		[Cpp2IlInjected.Token(Token = "0x17000ECE")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepDigTile> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60039FE")]
			[Cpp2IlInjected.Address(RVA = "0x34DEC10", Offset = "0x34DD610", VA = "0x1834DEC10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ECF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60039FF")]
			[Cpp2IlInjected.Address(RVA = "0x34DEB40", Offset = "0x34DD540", VA = "0x1834DEB40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A00")]
			[Cpp2IlInjected.Address(RVA = "0x34DEC70", Offset = "0x34DD670", VA = "0x1834DEC70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED1")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003A05")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A06")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED2")]
		[DebuggerNonUserCode]
		public HangoutWithCharacter With
		{
			[Cpp2IlInjected.Token(Token = "0x6003A07")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return with_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A08")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				with_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED3")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003A14")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A01")]
		[Cpp2IlInjected.Address(RVA = "0x34DE970", Offset = "0x34DD370", VA = "0x1834DE970")]
		[DebuggerNonUserCode]
		public CustomStepDigTile()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A02")]
		[Cpp2IlInjected.Address(RVA = "0x34DE6B0", Offset = "0x34DD0B0", VA = "0x1834DE6B0")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A03")]
		[Cpp2IlInjected.Address(RVA = "0x34DEA10", Offset = "0x34DD410", VA = "0x1834DEA10")]
		[DebuggerNonUserCode]
		public CustomStepDigTile(CustomStepDigTile other)
		{
			//IL_003c: Expected O, but got I4
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			StepAmount stepAmount2 = other.targetAmount_;
			int num = 0;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			targetAmount_ = (StepAmount)num;
			HangoutWithCharacter hangoutWithCharacter2 = other.with_;
			HangoutWithCharacter hangoutWithCharacter3 = default(HangoutWithCharacter);
			if (hangoutWithCharacter2 != null)
			{
				hangoutWithCharacter3 = hangoutWithCharacter2.Clone();
			}
			with_ = hangoutWithCharacter3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A04")]
		[Cpp2IlInjected.Address(RVA = "0x34DE190", Offset = "0x34DCB90", VA = "0x1834DE190", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepDigTile Clone()
		{
			//Discarded unreachable code: IL_0073
			//IL_003e: Expected O, but got I4
			CustomStepDigTile customStepDigTile = new CustomStepDigTile();
			StepAmount stepAmount = (customStepDigTile.targetAmount_ = new StepAmount());
			HangoutWithCharacter hangoutWithCharacter = (customStepDigTile.with_ = new HangoutWithCharacter());
			StepAmount stepAmount2 = targetAmount_;
			int num = 0;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			customStepDigTile.targetAmount_ = (StepAmount)num;
			HangoutWithCharacter hangoutWithCharacter2 = with_;
			HangoutWithCharacter hangoutWithCharacter3 = default(HangoutWithCharacter);
			if (hangoutWithCharacter2 != null)
			{
				hangoutWithCharacter3 = hangoutWithCharacter2.Clone();
			}
			customStepDigTile.with_ = hangoutWithCharacter3;
			UnknownFieldSet unknownFieldSet = (customStepDigTile._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepDigTile;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A09")]
		[Cpp2IlInjected.Address(RVA = "0x34DE2F0", Offset = "0x34DCCF0", VA = "0x1834DE2F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(targetAmount_, other) && object.Equals(with_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A0A")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepDigTile other)
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
					HangoutWithCharacter objB2 = other.with_;
					if (object.Equals(with_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A0B")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
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
				HangoutWithCharacter hangoutWithCharacter = with_;
				if (hangoutWithCharacter != null)
				{
					int hashCode2 = hangoutWithCharacter.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A0C")]
		[Cpp2IlInjected.Address(RVA = "0x34DE800", Offset = "0x34DD200", VA = "0x1834DE800", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A0D")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)targetAmount_ != 0)
			{
				StepAmount value = targetAmount_;
				output.WriteMessage(value);
			}
			if ((long)with_ != 0)
			{
				HangoutWithCharacter value2 = with_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A0E")]
		[Cpp2IlInjected.Address(RVA = "0x34DE0C0", Offset = "0x34DCAC0", VA = "0x1834DE0C0", Slot = "7")]
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
				HangoutWithCharacter hangoutWithCharacter = with_;
				if (hangoutWithCharacter != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(hangoutWithCharacter);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A0F")]
		[Cpp2IlInjected.Address(RVA = "0x34DE440", Offset = "0x34DCE40", VA = "0x1834DE440", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepDigTile other)
		{
			//Discarded unreachable code: IL_009b
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
					StepAmount stepAmount3 = targetAmount_;
				}
				StepAmount other2 = other.targetAmount_;
				stepAmount.MergeFrom(other2);
			}
			if ((long)other.with_ != 0)
			{
				HangoutWithCharacter hangoutWithCharacter2 = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					hangoutWithCharacter2 = with_;
				}
				HangoutWithCharacter other3 = other.with_;
				hangoutWithCharacter2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003A10")]
		[Cpp2IlInjected.Address(RVA = "0x34DE570", Offset = "0x34DCF70", VA = "0x1834DE570", Slot = "5")]
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
				StepAmount stepAmount = targetAmount_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (targetAmount_ = new StepAmount());
				}
				input.ReadMessage(stepAmount);
			}
			if (num == 18)
			{
				HangoutWithCharacter builder = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					builder = with_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003A11")]
		[Cpp2IlInjected.Address(RVA = "0x34DE3B0", Offset = "0x34DCDB0", VA = "0x1834DE3B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				StepAmount stepAmount = targetAmount_;
			}
			if (fieldNumber == 2)
			{
				HangoutWithCharacter hangoutWithCharacter = with_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A12")]
		[Cpp2IlInjected.Address(RVA = "0x34DE740", Offset = "0x34DD140", VA = "0x1834DE740", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					targetAmount_ = (StepAmount)num;
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

		[Cpp2IlInjected.Token(Token = "0x6003A13")]
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

		[Cpp2IlInjected.Token(Token = "0x6003A15")]
		[Cpp2IlInjected.Address(RVA = "0x2565780", Offset = "0x2564180", VA = "0x182565780", Slot = "15")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			targetAmount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A16")]
		[Cpp2IlInjected.Address(RVA = "0x34DE860", Offset = "0x34DD260", VA = "0x1834DE860")]
		static CustomStepDigTile()
		{
			Func<CustomStepDigTile> func = default(Func<CustomStepDigTile>);
			_parser = (MessageParser<CustomStepDigTile>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
