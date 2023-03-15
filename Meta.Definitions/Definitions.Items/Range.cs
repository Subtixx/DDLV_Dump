using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000410")]
	public sealed class Range : IMessage<Range>, IMessage, IEquatable<Range>, IDeepCloneable<Range>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001633")]
		private static readonly MessageParser<Range> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001634")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001635")]
		public const int MinFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001636")]
		private ScalableValue min_;

		[Cpp2IlInjected.Token(Token = "0x4001637")]
		public const int MaxFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001638")]
		private ScalableValue max_;

		[Cpp2IlInjected.Token(Token = "0x17000CBC")]
		[DebuggerNonUserCode]
		public static MessageParser<Range> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60031AD")]
			[Cpp2IlInjected.Address(RVA = "0x2DA0ED0", Offset = "0x2D9F8D0", VA = "0x182DA0ED0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CBD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60031AE")]
			[Cpp2IlInjected.Address(RVA = "0x2DA0E00", Offset = "0x2D9F800", VA = "0x182DA0E00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CBE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60031AF")]
			[Cpp2IlInjected.Address(RVA = "0x2DA0F30", Offset = "0x2D9F930", VA = "0x182DA0F30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CBF")]
		[DebuggerNonUserCode]
		public ScalableValue Min
		{
			[Cpp2IlInjected.Token(Token = "0x60031B4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return min_;
			}
			[Cpp2IlInjected.Token(Token = "0x60031B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				min_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC0")]
		[DebuggerNonUserCode]
		public ScalableValue Max
		{
			[Cpp2IlInjected.Token(Token = "0x60031B6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return max_;
			}
			[Cpp2IlInjected.Token(Token = "0x60031B7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				max_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031B0")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0C10", Offset = "0x2D9F610", VA = "0x182DA0C10")]
		[DebuggerNonUserCode]
		public Range()
		{
			ScalableValue scalableValue = (min_ = new ScalableValue());
			ScalableValue scalableValue2 = (max_ = new ScalableValue());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0960", Offset = "0x2D9F360", VA = "0x182DA0960")]
		private void OnConstruction()
		{
			ScalableValue scalableValue = (min_ = new ScalableValue());
			ScalableValue scalableValue2 = (max_ = new ScalableValue());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031B2")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0CA0", Offset = "0x2D9F6A0", VA = "0x182DA0CA0")]
		[DebuggerNonUserCode]
		public Range(Range other)
		{
			//IL_004d: Expected O, but got I4
			int num = 0;
			ScalableValue scalableValue = other.min_;
			if (scalableValue != null)
			{
				ScalableValue scalableValue2 = new ScalableValue();
				int num2 = (scalableValue2.value_ = scalableValue.value_);
				int num3 = (scalableValue2.scalingScript_ = scalableValue.scalingScript_);
				UnknownFieldSet unknownFieldSet = (scalableValue2._unknownFields = UnknownFieldSet.Clone(scalableValue._unknownFields));
			}
			min_ = (ScalableValue)num;
			ScalableValue scalableValue3 = other.max_;
			ScalableValue scalableValue4 = default(ScalableValue);
			if (scalableValue3 != null)
			{
				scalableValue4 = new ScalableValue();
				int num4 = (scalableValue4.value_ = scalableValue3.value_);
				int num5 = (scalableValue4.scalingScript_ = scalableValue3.scalingScript_);
				UnknownFieldSet unknownFieldSet2 = (scalableValue4._unknownFields = UnknownFieldSet.Clone(scalableValue3._unknownFields));
			}
			max_ = scalableValue4;
			UnknownFieldSet unknownFieldSet3 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031B3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA03D0", Offset = "0x2D9EDD0", VA = "0x182DA03D0", Slot = "10")]
		[DebuggerNonUserCode]
		public Range Clone()
		{
			//Discarded unreachable code: IL_00c3
			//IL_0055: Expected O, but got I4
			Range range = new Range();
			int num = 0;
			ScalableValue scalableValue = min_;
			if (scalableValue != null)
			{
				ScalableValue scalableValue2 = new ScalableValue();
				int num2 = (scalableValue2.value_ = scalableValue.value_);
				int num3 = (scalableValue2.scalingScript_ = scalableValue.scalingScript_);
				UnknownFieldSet unknownFieldSet = (scalableValue2._unknownFields = UnknownFieldSet.Clone(scalableValue._unknownFields));
			}
			range.min_ = (ScalableValue)num;
			ScalableValue scalableValue3 = max_;
			ScalableValue scalableValue4 = default(ScalableValue);
			if (scalableValue3 != null)
			{
				scalableValue4 = new ScalableValue();
				int num4 = (scalableValue4.value_ = scalableValue3.value_);
				int num5 = (scalableValue4.scalingScript_ = scalableValue3.scalingScript_);
				UnknownFieldSet unknownFieldSet2 = (scalableValue4._unknownFields = UnknownFieldSet.Clone(scalableValue3._unknownFields));
			}
			range.max_ = scalableValue4;
			UnknownFieldSet unknownFieldSet3 = (range._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return range;
		}

		[Cpp2IlInjected.Token(Token = "0x60031B8")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0560", Offset = "0x2D9EF60", VA = "0x182DA0560", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(min_, other) && object.Equals(max_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031B9")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Range other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ScalableValue objB = other.min_;
				if (object.Equals(min_, objB))
				{
					ScalableValue objB2 = other.max_;
					if (object.Equals(max_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031BA")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ScalableValue scalableValue = min_;
				if (scalableValue != null)
				{
					int hashCode = scalableValue.GetHashCode();
				}
				ScalableValue scalableValue2 = max_;
				if (scalableValue2 != null)
				{
					int hashCode2 = scalableValue2.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60031BB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0AA0", Offset = "0x2D9F4A0", VA = "0x182DA0AA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60031BC")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)min_ != 0)
			{
				ScalableValue value = min_;
				output.WriteMessage(value);
			}
			if ((long)max_ != 0)
			{
				ScalableValue value2 = max_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60031BD")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0300", Offset = "0x2D9ED00", VA = "0x182DA0300", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ScalableValue scalableValue = min_;
				num = 0;
				if (scalableValue != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(scalableValue);
				}
				ScalableValue scalableValue2 = max_;
				if (scalableValue2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(scalableValue2);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60031BE")]
		[Cpp2IlInjected.Address(RVA = "0x2DA06B0", Offset = "0x2D9F0B0", VA = "0x182DA06B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Range other)
		{
			//Discarded unreachable code: IL_0127
			if (other == null)
			{
				return;
			}
			ScalableValue scalableValue = other.min_;
			if (scalableValue != null)
			{
				ScalableValue scalableValue2 = min_;
				if (scalableValue2 == null)
				{
					ScalableValue scalableValue3 = (min_ = new ScalableValue());
					ScalableValue scalableValue4 = min_;
				}
				if (scalableValue != null)
				{
					int value_ = scalableValue.value_;
					if (value_ != 0)
					{
						scalableValue2.value_ = value_;
					}
					int scalingScript_ = scalableValue.scalingScript_;
					if (scalingScript_ != 0)
					{
						scalableValue2.scalingScript_ = scalingScript_;
					}
					UnknownFieldSet unknownFields = scalableValue._unknownFields;
					UnknownFieldSet unknownFieldSet = (scalableValue2._unknownFields = UnknownFieldSet.MergeFrom(scalableValue2._unknownFields, unknownFields));
				}
			}
			if (other.max_ != null)
			{
				ScalableValue scalableValue6 = default(ScalableValue);
				ScalableValue scalableValue7 = default(ScalableValue);
				if (max_ == null)
				{
					ScalableValue scalableValue5 = (max_ = new ScalableValue());
					scalableValue6 = other.max_;
					scalableValue7 = max_;
				}
				if (scalableValue6 != null)
				{
					int value_2 = scalableValue6.value_;
					if (value_2 != 0)
					{
						scalableValue7.value_ = value_2;
					}
					int scalingScript_2 = scalableValue6.scalingScript_;
					if (scalingScript_2 != 0)
					{
						scalableValue7.scalingScript_ = scalingScript_2;
					}
					UnknownFieldSet unknownFields2 = scalableValue6._unknownFields;
					UnknownFieldSet unknownFieldSet2 = (scalableValue7._unknownFields = UnknownFieldSet.MergeFrom(scalableValue7._unknownFields, unknownFields2));
				}
			}
			UnknownFieldSet unknownFields3 = other._unknownFields;
			UnknownFieldSet unknownFieldSet3 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields3));
		}

		[Cpp2IlInjected.Token(Token = "0x60031BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0830", Offset = "0x2D9F230", VA = "0x182DA0830", Slot = "5")]
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
				ScalableValue scalableValue = min_;
				if (scalableValue == null)
				{
					ScalableValue scalableValue2 = (min_ = new ScalableValue());
				}
				input.ReadMessage(scalableValue);
			}
			if (num == 18)
			{
				ScalableValue builder = default(ScalableValue);
				if (max_ == null)
				{
					ScalableValue scalableValue3 = (max_ = new ScalableValue());
					builder = max_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60031C0")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0620", Offset = "0x2D9F020", VA = "0x182DA0620", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ScalableValue scalableValue = min_;
			}
			if (fieldNumber == 2)
			{
				ScalableValue scalableValue2 = max_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031C1")]
		[Cpp2IlInjected.Address(RVA = "0x2DA09F0", Offset = "0x2D9F3F0", VA = "0x182DA09F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					min_ = (ScalableValue)num;
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

		[Cpp2IlInjected.Token(Token = "0x60031C2")]
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

		[Cpp2IlInjected.Token(Token = "0x60031C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0B00", Offset = "0x2D9F500", VA = "0x182DA0B00")]
		static Range()
		{
			Func<Range> func = default(Func<Range>);
			_parser = (MessageParser<Range>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
