using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200041E")]
	public sealed class GeneratorWeightedItem : IMessage<GeneratorWeightedItem>, IMessage, IEquatable<GeneratorWeightedItem>, IDeepCloneable<GeneratorWeightedItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400167C")]
		private static readonly MessageParser<GeneratorWeightedItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400167D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400167E")]
		public const int WeightFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400167F")]
		private ScalableValue weight_;

		[Cpp2IlInjected.Token(Token = "0x4001680")]
		public const int ItemFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001681")]
		private int item_;

		[Cpp2IlInjected.Token(Token = "0x17000CE5")]
		[DebuggerNonUserCode]
		public static MessageParser<GeneratorWeightedItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600325B")]
			[Cpp2IlInjected.Address(RVA = "0x2199780", Offset = "0x2198180", VA = "0x182199780")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600325C")]
			[Cpp2IlInjected.Address(RVA = "0x21996B0", Offset = "0x21980B0", VA = "0x1821996B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600325D")]
			[Cpp2IlInjected.Address(RVA = "0x21997E0", Offset = "0x21981E0", VA = "0x1821997E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE8")]
		[DebuggerNonUserCode]
		public ScalableValue Weight
		{
			[Cpp2IlInjected.Token(Token = "0x6003262")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return weight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003263")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				weight_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE9")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003264")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003265")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600325E")]
		[Cpp2IlInjected.Address(RVA = "0x2199570", Offset = "0x2197F70", VA = "0x182199570")]
		[DebuggerNonUserCode]
		public GeneratorWeightedItem()
		{
			ScalableValue scalableValue = (weight_ = new ScalableValue());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600325F")]
		[Cpp2IlInjected.Address(RVA = "0x21992D0", Offset = "0x2197CD0", VA = "0x1821992D0")]
		private void OnConstruction()
		{
			ScalableValue scalableValue = (weight_ = new ScalableValue());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003260")]
		[Cpp2IlInjected.Address(RVA = "0x21995E0", Offset = "0x2197FE0", VA = "0x1821995E0")]
		[DebuggerNonUserCode]
		public GeneratorWeightedItem(GeneratorWeightedItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6003261")]
		[Cpp2IlInjected.Address(RVA = "0x2198E80", Offset = "0x2197880", VA = "0x182198E80", Slot = "10")]
		[DebuggerNonUserCode]
		public GeneratorWeightedItem Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0030: Expected O, but got I4
			GeneratorWeightedItem generatorWeightedItem = new GeneratorWeightedItem();
			ScalableValue scalableValue = (generatorWeightedItem.weight_ = new ScalableValue());
			ScalableValue scalableValue2 = weight_;
			if (scalableValue2 != null)
			{
				ScalableValue scalableValue3 = scalableValue2.Clone();
			}
			int num = 0;
			generatorWeightedItem.weight_ = (ScalableValue)num;
			int num2 = (generatorWeightedItem.item_ = item_);
			UnknownFieldSet unknownFieldSet = (generatorWeightedItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return generatorWeightedItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6003266")]
		[Cpp2IlInjected.Address(RVA = "0x2198F80", Offset = "0x2197980", VA = "0x182198F80", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003267")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GeneratorWeightedItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6003268")]
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

		[Cpp2IlInjected.Token(Token = "0x6003269")]
		[Cpp2IlInjected.Address(RVA = "0x2199400", Offset = "0x2197E00", VA = "0x182199400", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600326A")]
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

		[Cpp2IlInjected.Token(Token = "0x600326B")]
		[Cpp2IlInjected.Address(RVA = "0x2198DB0", Offset = "0x21977B0", VA = "0x182198DB0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x600326C")]
		[Cpp2IlInjected.Address(RVA = "0x21991F0", Offset = "0x2197BF0", VA = "0x1821991F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GeneratorWeightedItem other)
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

		[Cpp2IlInjected.Token(Token = "0x600326D")]
		[Cpp2IlInjected.Address(RVA = "0x2199100", Offset = "0x2197B00", VA = "0x182199100", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ScalableValue scalableValue = weight_;
				if (scalableValue == null)
				{
					ScalableValue scalableValue2 = (weight_ = new ScalableValue());
				}
				input.ReadMessage(scalableValue);
			}
			if (num == 16)
			{
				int num2 = (item_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600326E")]
		[Cpp2IlInjected.Address(RVA = "0x2199030", Offset = "0x2197A30", VA = "0x182199030", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x600326F")]
		[Cpp2IlInjected.Address(RVA = "0x2199330", Offset = "0x2197D30", VA = "0x182199330", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6003270")]
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

		[Cpp2IlInjected.Token(Token = "0x6003271")]
		[Cpp2IlInjected.Address(RVA = "0x2199460", Offset = "0x2197E60", VA = "0x182199460")]
		static GeneratorWeightedItem()
		{
			Func<GeneratorWeightedItem> func = default(Func<GeneratorWeightedItem>);
			_parser = (MessageParser<GeneratorWeightedItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
