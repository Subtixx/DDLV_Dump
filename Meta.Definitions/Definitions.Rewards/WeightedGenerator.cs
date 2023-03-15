using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001F5")]
	public sealed class WeightedGenerator : IMessage<WeightedGenerator>, IMessage, IEquatable<WeightedGenerator>, IDeepCloneable<WeightedGenerator>, IMessageFieldAccessor, IGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private static readonly MessageParser<WeightedGenerator> _parser = (MessageParser<WeightedGenerator>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new WeightedGenerator()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000804")]
		public const int GeneratorsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private static readonly FieldCodec<Generator> _repeated_generators_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private readonly RepeatedField<Generator> generators_ = (RepeatedField<Generator>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700043C")]
		[DebuggerNonUserCode]
		public static MessageParser<WeightedGenerator> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60012C7")]
			[Cpp2IlInjected.Address(RVA = "0x17CD540", Offset = "0x17CBF40", VA = "0x1817CD540")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60012C8")]
			[Cpp2IlInjected.Address(RVA = "0x17CD470", Offset = "0x17CBE70", VA = "0x1817CD470")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60012C9")]
			[Cpp2IlInjected.Address(RVA = "0x17CD5A0", Offset = "0x17CBFA0", VA = "0x1817CD5A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043F")]
		[DebuggerNonUserCode]
		public RepeatedField<Generator> Generators
		{
			[Cpp2IlInjected.Token(Token = "0x60012CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return generators_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012CA")]
		[Cpp2IlInjected.Address(RVA = "0x17CD3F0", Offset = "0x17CBDF0", VA = "0x1817CD3F0")]
		[DebuggerNonUserCode]
		public WeightedGenerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60012CB")]
		[Cpp2IlInjected.Address(RVA = "0x17CD2F0", Offset = "0x17CBCF0", VA = "0x1817CD2F0")]
		[DebuggerNonUserCode]
		public WeightedGenerator(WeightedGenerator other)
		{
			RepeatedField<Generator> repeatedField = (generators_ = (RepeatedField<Generator>)(object)((RepeatedField<T>)(object)other.generators_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012CC")]
		[Cpp2IlInjected.Address(RVA = "0x17CC4D0", Offset = "0x17CAED0", VA = "0x1817CC4D0", Slot = "10")]
		[DebuggerNonUserCode]
		public WeightedGenerator Clone()
		{
			//Discarded unreachable code: IL_003b
			WeightedGenerator weightedGenerator = new WeightedGenerator();
			RepeatedField<Generator> repeatedField = (weightedGenerator.generators_ = (RepeatedField<Generator>)(object)new RepeatedField<T>());
			RepeatedField<Generator> repeatedField2 = (weightedGenerator.generators_ = (RepeatedField<Generator>)(object)((RepeatedField<T>)(object)generators_).Clone());
			UnknownFieldSet unknownFieldSet = (weightedGenerator._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return weightedGenerator;
		}

		[Cpp2IlInjected.Token(Token = "0x60012CE")]
		[Cpp2IlInjected.Address(RVA = "0x17CC620", Offset = "0x17CB020", VA = "0x1817CC620", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<Generator> repeatedField = generators_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012CF")]
		[Cpp2IlInjected.Address(RVA = "0x17CC700", Offset = "0x17CB100", VA = "0x1817CC700", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WeightedGenerator other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Generator> repeatedField = generators_;
				RepeatedField<Generator> repeatedField2 = other.generators_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012D0")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)generators_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60012D1")]
		[Cpp2IlInjected.Address(RVA = "0x17CD000", Offset = "0x17CBA00", VA = "0x1817CD000", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60012D2")]
		[Cpp2IlInjected.Address(RVA = "0x17CD060", Offset = "0x17CBA60", VA = "0x1817CD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Generator> repeatedField = generators_;
			FieldCodec<Generator> repeated_generators_codec = _repeated_generators_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_generators_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60012D3")]
		[Cpp2IlInjected.Address(RVA = "0x17CC3C0", Offset = "0x17CADC0", VA = "0x1817CC3C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Generator> repeatedField = generators_;
			FieldCodec<Generator> repeated_generators_codec = _repeated_generators_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_generators_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60012D4")]
		[Cpp2IlInjected.Address(RVA = "0x17CCE30", Offset = "0x17CB830", VA = "0x1817CCE30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WeightedGenerator other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Generator> repeatedField = generators_;
				RepeatedField<Generator> repeatedField2 = other.generators_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012D5")]
		[Cpp2IlInjected.Address(RVA = "0x17CCEB0", Offset = "0x17CB8B0", VA = "0x1817CCEB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Generator> repeatedField = generators_;
					FieldCodec<Generator> repeated_generators_codec = _repeated_generators_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_generators_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012D6")]
		[Cpp2IlInjected.Address(RVA = "0x17CCC10", Offset = "0x17CB610", VA = "0x1817CCC10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Generator> repeatedField = generators_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012D7")]
		[Cpp2IlInjected.Address(RVA = "0x17CCFA0", Offset = "0x17CB9A0", VA = "0x1817CCFA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012D8")]
		[Cpp2IlInjected.Address(RVA = "0x17CC470", Offset = "0x17CAE70", VA = "0x1817CC470", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Generator> repeatedField = generators_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012D9")]
		[Cpp2IlInjected.Address(RVA = "0x17CCC90", Offset = "0x17CB690", VA = "0x1817CCC90")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			int num2 = 0;
			RepeatedField<Generator> repeatedField = generators_;
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012DA")]
		[Cpp2IlInjected.Address(RVA = "0x17CC790", Offset = "0x17CB190", VA = "0x1817CC790")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0071, IL_0077
			//IL_0016: Expected O, but got I4
			int num = 0;
			List<ItemWithState> items2 = (List<ItemWithState>)0;
			Func<Generator, int> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_1;
			if (_003C_003E9__29_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Generator x) => x.weight_);
			}
			IEnumerable<Generator> enumerable = default(IEnumerable<Generator>);
			if (Enumerable.Sum<Generator>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__29_) > 0)
			{
				double num2 = random.NextDouble();
				num += num;
				num++;
				List<ItemWithState> list = items2;
				num++;
				num += 312;
				if (num + 1 == 0)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012DB")]
		[Cpp2IlInjected.Address(RVA = "0x17CD120", Offset = "0x17CBB20", VA = "0x1817CD120")]
		static WeightedGenerator()
		{
			MessageParser<Generator> parser = Generator._parser;
			uint num = default(uint);
			_parser = (MessageParser<WeightedGenerator>)(object)FieldCodec.ForMessage<Generator>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012DC")]
		[Cpp2IlInjected.Address(RVA = "0x17CC610", Offset = "0x17CB010", VA = "0x1817CC610", Slot = "14")]
		bool IGenerator.IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			return this.IsValid(ref playerProfile, ref worldProfile, (List<>)(object)items);
		}

		[Cpp2IlInjected.Token(Token = "0x60012DD")]
		[Cpp2IlInjected.Address(RVA = "0x17CC600", Offset = "0x17CB000", VA = "0x1817CC600", Slot = "15")]
		IReward IGenerator.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			IReward result = default(IReward);
			return result;
		}
	}
}
