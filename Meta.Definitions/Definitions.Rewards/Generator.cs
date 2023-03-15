using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001FE")]
	public sealed class Generator : IMessage<Generator>, IMessage, IEquatable<Generator>, IDeepCloneable<Generator>, IMessageFieldAccessor, IGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private static readonly MessageParser<Generator> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000825")]
		public const int SelfFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private AnyGenerator self_;

		[Cpp2IlInjected.Token(Token = "0x4000827")]
		public const int WeightFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private int weight_;

		[Cpp2IlInjected.Token(Token = "0x1700044F")]
		[DebuggerNonUserCode]
		public static MessageParser<Generator> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600132E")]
			[Cpp2IlInjected.Address(RVA = "0x219A1B0", Offset = "0x2198BB0", VA = "0x18219A1B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000450")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600132F")]
			[Cpp2IlInjected.Address(RVA = "0x219A0E0", Offset = "0x2198AE0", VA = "0x18219A0E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000451")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001330")]
			[Cpp2IlInjected.Address(RVA = "0x219A210", Offset = "0x2198C10", VA = "0x18219A210", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000452")]
		[DebuggerNonUserCode]
		public AnyGenerator Self
		{
			[Cpp2IlInjected.Token(Token = "0x6001334")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return self_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001335")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				self_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000453")]
		[DebuggerNonUserCode]
		public int Weight
		{
			[Cpp2IlInjected.Token(Token = "0x6001336")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return weight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001337")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				weight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001331")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Generator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001332")]
		[Cpp2IlInjected.Address(RVA = "0x219A060", Offset = "0x2198A60", VA = "0x18219A060")]
		[DebuggerNonUserCode]
		public Generator(Generator other)
		{
			//IL_0021: Expected O, but got I4
			AnyGenerator anyGenerator = other.self_;
			if (anyGenerator != null)
			{
				AnyGenerator anyGenerator2 = anyGenerator.Clone();
			}
			int num = 0;
			self_ = (AnyGenerator)num;
			int num2 = (weight_ = other.weight_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001333")]
		[Cpp2IlInjected.Address(RVA = "0x21999C0", Offset = "0x21983C0", VA = "0x1821999C0", Slot = "10")]
		[DebuggerNonUserCode]
		public Generator Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0021: Expected O, but got I4
			Generator generator = new Generator();
			AnyGenerator anyGenerator = self_;
			if (anyGenerator != null)
			{
				AnyGenerator anyGenerator2 = anyGenerator.Clone();
			}
			int num = 0;
			generator.self_ = (AnyGenerator)num;
			int num2 = (generator.weight_ = weight_);
			UnknownFieldSet unknownFieldSet = (generator._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return generator;
		}

		[Cpp2IlInjected.Token(Token = "0x6001338")]
		[Cpp2IlInjected.Address(RVA = "0x2199AD0", Offset = "0x21984D0", VA = "0x182199AD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(self_, other);
				if (flag && weight_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001339")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Generator other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				AnyGenerator objB = other.self_;
				if (object.Equals(self_, objB))
				{
					int num = other.weight_;
					if (weight_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600133A")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				AnyGenerator anyGenerator = self_;
				if (anyGenerator != null)
				{
					int hashCode = anyGenerator.GetHashCode();
				}
				if (weight_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600133B")]
		[Cpp2IlInjected.Address(RVA = "0x2199EF0", Offset = "0x21988F0", VA = "0x182199EF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600133C")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)self_ != 0)
			{
				AnyGenerator value = self_;
				output.WriteMessage(value);
			}
			if (weight_ != 0)
			{
				int value2 = weight_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600133D")]
		[Cpp2IlInjected.Address(RVA = "0x21998F0", Offset = "0x21982F0", VA = "0x1821998F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				AnyGenerator anyGenerator = self_;
				num = 0;
				if (anyGenerator != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(anyGenerator);
				}
				int num3 = weight_;
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

		[Cpp2IlInjected.Token(Token = "0x600133E")]
		[Cpp2IlInjected.Address(RVA = "0x2199D40", Offset = "0x2198740", VA = "0x182199D40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Generator other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.self_ != 0)
			{
				AnyGenerator anyGenerator = self_;
				if (anyGenerator == null)
				{
					AnyGenerator anyGenerator2 = (self_ = new AnyGenerator());
				}
				AnyGenerator other2 = other.self_;
				anyGenerator.MergeFrom(other2);
			}
			int num = other.weight_;
			if (num != 0)
			{
				weight_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600133F")]
		[Cpp2IlInjected.Address(RVA = "0x2199C50", Offset = "0x2198650", VA = "0x182199C50", Slot = "5")]
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
				AnyGenerator anyGenerator = self_;
				if (anyGenerator == null)
				{
					AnyGenerator anyGenerator2 = (self_ = new AnyGenerator());
				}
				input.ReadMessage(anyGenerator);
			}
			if (num == 16)
			{
				int num2 = (weight_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001340")]
		[Cpp2IlInjected.Address(RVA = "0x2199B80", Offset = "0x2198580", VA = "0x182199B80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				AnyGenerator anyGenerator = self_;
			}
			if (fieldNumber == 2)
			{
				int num = weight_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001341")]
		[Cpp2IlInjected.Address(RVA = "0x2199E20", Offset = "0x2198820", VA = "0x182199E20", Slot = "12")]
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
				self_ = (AnyGenerator)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				weight_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001342")]
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
				weight_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001343")]
		[Cpp2IlInjected.Address(RVA = "0x2199AA0", Offset = "0x21984A0", VA = "0x182199AA0")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_000f
			return self_.IsValid(ref playerProfile, ref worldProfile, (List<>)(object)items);
		}

		[Cpp2IlInjected.Token(Token = "0x6001344")]
		[Cpp2IlInjected.Address(RVA = "0x2199A70", Offset = "0x2198470", VA = "0x182199A70")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0009
			AnyGenerator anyGenerator = self_;
			IReward result = default(IReward);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001345")]
		[Cpp2IlInjected.Address(RVA = "0x2199F50", Offset = "0x2198950", VA = "0x182199F50")]
		static Generator()
		{
			Func<Generator> func = default(Func<Generator>);
			_parser = (MessageParser<Generator>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001346")]
		[Cpp2IlInjected.Address(RVA = "0x2199AA0", Offset = "0x21984A0", VA = "0x182199AA0", Slot = "14")]
		bool IGenerator.IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_000f
			return self_.IsValid(ref playerProfile, ref worldProfile, (List<>)(object)items);
		}

		[Cpp2IlInjected.Token(Token = "0x6001347")]
		[Cpp2IlInjected.Address(RVA = "0x2199A70", Offset = "0x2198470", VA = "0x182199A70", Slot = "15")]
		IReward IGenerator.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0009
			AnyGenerator anyGenerator = self_;
			IReward result = default(IReward);
			return result;
		}
	}
}
