using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000425")]
	public sealed class GeneratorWeightedItemIngredient : IMessage<GeneratorWeightedItemIngredient>, IMessage, IEquatable<GeneratorWeightedItemIngredient>, IDeepCloneable<GeneratorWeightedItemIngredient>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001696")]
		private static readonly MessageParser<GeneratorWeightedItemIngredient> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001697")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001698")]
		public const int WeightFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001699")]
		private ScalableValue weight_;

		[Cpp2IlInjected.Token(Token = "0x400169A")]
		public const int ItemFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400169B")]
		private int item_;

		[Cpp2IlInjected.Token(Token = "0x17000CF5")]
		[DebuggerNonUserCode]
		public static MessageParser<GeneratorWeightedItemIngredient> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60032AA")]
			[Cpp2IlInjected.Address(RVA = "0x2198C40", Offset = "0x2197640", VA = "0x182198C40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60032AB")]
			[Cpp2IlInjected.Address(RVA = "0x2198B70", Offset = "0x2197570", VA = "0x182198B70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60032AC")]
			[Cpp2IlInjected.Address(RVA = "0x2198CA0", Offset = "0x21976A0", VA = "0x182198CA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF8")]
		[DebuggerNonUserCode]
		public ScalableValue Weight
		{
			[Cpp2IlInjected.Token(Token = "0x60032B1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return weight_;
			}
			[Cpp2IlInjected.Token(Token = "0x60032B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				weight_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF9")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x60032B3")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x60032B4")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032AD")]
		[Cpp2IlInjected.Address(RVA = "0x2198B00", Offset = "0x2197500", VA = "0x182198B00")]
		[DebuggerNonUserCode]
		public GeneratorWeightedItemIngredient()
		{
			ScalableValue scalableValue = (weight_ = new ScalableValue());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032AE")]
		[Cpp2IlInjected.Address(RVA = "0x2198790", Offset = "0x2197190", VA = "0x182198790")]
		private void OnConstruction()
		{
			ScalableValue scalableValue = (weight_ = new ScalableValue());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032AF")]
		[Cpp2IlInjected.Address(RVA = "0x2198A30", Offset = "0x2197430", VA = "0x182198A30")]
		[DebuggerNonUserCode]
		public GeneratorWeightedItemIngredient(GeneratorWeightedItemIngredient other)
		{
			//IL_002e: Expected O, but got I4
			ScalableValue scalableValue = (weight_ = new ScalableValue());
			ScalableValue scalableValue2 = other.weight_;
			if (scalableValue2 != null)
			{
				ScalableValue scalableValue3 = scalableValue2.Clone();
			}
			int num = 0;
			weight_ = (ScalableValue)num;
			int num2 = (item_ = other.item_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032B0")]
		[Cpp2IlInjected.Address(RVA = "0x2198340", Offset = "0x2196D40", VA = "0x182198340", Slot = "10")]
		[DebuggerNonUserCode]
		public GeneratorWeightedItemIngredient Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0030: Expected O, but got I4
			GeneratorWeightedItemIngredient generatorWeightedItemIngredient = new GeneratorWeightedItemIngredient();
			ScalableValue scalableValue = (generatorWeightedItemIngredient.weight_ = new ScalableValue());
			ScalableValue scalableValue2 = weight_;
			if (scalableValue2 != null)
			{
				ScalableValue scalableValue3 = scalableValue2.Clone();
			}
			int num = 0;
			generatorWeightedItemIngredient.weight_ = (ScalableValue)num;
			int num2 = (generatorWeightedItemIngredient.item_ = item_);
			UnknownFieldSet unknownFieldSet = (generatorWeightedItemIngredient._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return generatorWeightedItemIngredient;
		}

		[Cpp2IlInjected.Token(Token = "0x60032B5")]
		[Cpp2IlInjected.Address(RVA = "0x2198440", Offset = "0x2196E40", VA = "0x182198440", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(weight_, other);
				if (flag && item_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032B6")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GeneratorWeightedItemIngredient other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ScalableValue objB = other.weight_;
				if (object.Equals(weight_, objB))
				{
					int num = other.item_;
					if (item_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032B7")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ScalableValue scalableValue = weight_;
				if (scalableValue != null)
				{
					int hashCode = scalableValue.GetHashCode();
				}
				if (item_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60032B8")]
		[Cpp2IlInjected.Address(RVA = "0x21988C0", Offset = "0x21972C0", VA = "0x1821988C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60032B9")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)weight_ != 0)
			{
				ScalableValue value = weight_;
				output.WriteMessage(value);
			}
			if (item_ != 0)
			{
				int value2 = item_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60032BA")]
		[Cpp2IlInjected.Address(RVA = "0x2198270", Offset = "0x2196C70", VA = "0x182198270", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ScalableValue scalableValue = weight_;
				num = 0;
				if (scalableValue != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(scalableValue);
				}
				int num3 = item_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60032BB")]
		[Cpp2IlInjected.Address(RVA = "0x21986B0", Offset = "0x21970B0", VA = "0x1821986B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GeneratorWeightedItemIngredient other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.weight_ != 0)
			{
				ScalableValue scalableValue = weight_;
				if (scalableValue == null)
				{
					ScalableValue scalableValue2 = (weight_ = new ScalableValue());
				}
				ScalableValue other2 = other.weight_;
				scalableValue.MergeFrom(other2);
			}
			int num = other.item_;
			if (num != 0)
			{
				item_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60032BC")]
		[Cpp2IlInjected.Address(RVA = "0x21985C0", Offset = "0x2196FC0", VA = "0x1821985C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0062
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			ScalableValue scalableValue = default(ScalableValue);
			if (num == 10)
			{
				ScalableValue builder = default(ScalableValue);
				if (weight_ == null)
				{
					scalableValue = (weight_ = new ScalableValue());
					builder = weight_;
				}
				input.ReadMessage(builder);
			}
			if ((long)scalableValue == 16)
			{
				int num2 = (item_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60032BD")]
		[Cpp2IlInjected.Address(RVA = "0x21984F0", Offset = "0x2196EF0", VA = "0x1821984F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ScalableValue scalableValue = weight_;
			}
			if (fieldNumber == 2)
			{
				int num = item_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032BE")]
		[Cpp2IlInjected.Address(RVA = "0x21987F0", Offset = "0x21971F0", VA = "0x1821987F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				weight_ = (ScalableValue)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				item_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032BF")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				item_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032C0")]
		[Cpp2IlInjected.Address(RVA = "0x2198920", Offset = "0x2197320", VA = "0x182198920")]
		static GeneratorWeightedItemIngredient()
		{
			Func<GeneratorWeightedItemIngredient> func = default(Func<GeneratorWeightedItemIngredient>);
			_parser = (MessageParser<GeneratorWeightedItemIngredient>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
