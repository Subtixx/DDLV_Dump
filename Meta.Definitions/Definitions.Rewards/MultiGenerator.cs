using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001F1")]
	public sealed class MultiGenerator : IMessage<MultiGenerator>, IMessage, IEquatable<MultiGenerator>, IDeepCloneable<MultiGenerator>, IMessageFieldAccessor, IGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private static readonly MessageParser<MultiGenerator> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		public const int GeneratorsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		private static readonly FieldCodec<AnyGenerator> _repeated_generators_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private readonly RepeatedField<AnyGenerator> generators_ = (RepeatedField<AnyGenerator>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000438")]
		[DebuggerNonUserCode]
		public static MessageParser<MultiGenerator> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60012A8")]
			[Cpp2IlInjected.Address(RVA = "0x29F3350", Offset = "0x29F1D50", VA = "0x1829F3350")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000439")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60012A9")]
			[Cpp2IlInjected.Address(RVA = "0x29F3280", Offset = "0x29F1C80", VA = "0x1829F3280")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60012AA")]
			[Cpp2IlInjected.Address(RVA = "0x29F33B0", Offset = "0x29F1DB0", VA = "0x1829F33B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043B")]
		[DebuggerNonUserCode]
		public RepeatedField<AnyGenerator> Generators
		{
			[Cpp2IlInjected.Token(Token = "0x60012AE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return generators_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012AB")]
		[Cpp2IlInjected.Address(RVA = "0x29F3200", Offset = "0x29F1C00", VA = "0x1829F3200")]
		[DebuggerNonUserCode]
		public MultiGenerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60012AC")]
		[Cpp2IlInjected.Address(RVA = "0x29F3100", Offset = "0x29F1B00", VA = "0x1829F3100")]
		[DebuggerNonUserCode]
		public MultiGenerator(MultiGenerator other)
		{
			RepeatedField<AnyGenerator> repeatedField = (generators_ = (RepeatedField<AnyGenerator>)(object)((RepeatedField<T>)(object)other.generators_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012AD")]
		[Cpp2IlInjected.Address(RVA = "0x29F2490", Offset = "0x29F0E90", VA = "0x1829F2490", Slot = "10")]
		[DebuggerNonUserCode]
		public MultiGenerator Clone()
		{
			//Discarded unreachable code: IL_003b
			MultiGenerator multiGenerator = new MultiGenerator();
			RepeatedField<AnyGenerator> repeatedField = (multiGenerator.generators_ = (RepeatedField<AnyGenerator>)(object)new RepeatedField<T>());
			RepeatedField<AnyGenerator> repeatedField2 = (multiGenerator.generators_ = (RepeatedField<AnyGenerator>)(object)((RepeatedField<T>)(object)generators_).Clone());
			UnknownFieldSet unknownFieldSet = (multiGenerator._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return multiGenerator;
		}

		[Cpp2IlInjected.Token(Token = "0x60012AF")]
		[Cpp2IlInjected.Address(RVA = "0x29F2670", Offset = "0x29F1070", VA = "0x1829F2670", Slot = "0")]
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
				RepeatedField<AnyGenerator> repeatedField = generators_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012B0")]
		[Cpp2IlInjected.Address(RVA = "0x29F25E0", Offset = "0x29F0FE0", VA = "0x1829F25E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MultiGenerator other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<AnyGenerator> repeatedField = generators_;
				RepeatedField<AnyGenerator> repeatedField2 = other.generators_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012B1")]
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

		[Cpp2IlInjected.Token(Token = "0x60012B2")]
		[Cpp2IlInjected.Address(RVA = "0x29F2E10", Offset = "0x29F1810", VA = "0x1829F2E10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60012B3")]
		[Cpp2IlInjected.Address(RVA = "0x29F2E70", Offset = "0x29F1870", VA = "0x1829F2E70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<AnyGenerator> repeatedField = generators_;
			FieldCodec<AnyGenerator> repeated_generators_codec = _repeated_generators_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_generators_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60012B4")]
		[Cpp2IlInjected.Address(RVA = "0x29F2380", Offset = "0x29F0D80", VA = "0x1829F2380", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<AnyGenerator> repeatedField = generators_;
			FieldCodec<AnyGenerator> repeated_generators_codec = _repeated_generators_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_generators_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60012B5")]
		[Cpp2IlInjected.Address(RVA = "0x29F2C40", Offset = "0x29F1640", VA = "0x1829F2C40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MultiGenerator other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<AnyGenerator> repeatedField = generators_;
				RepeatedField<AnyGenerator> repeatedField2 = other.generators_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012B6")]
		[Cpp2IlInjected.Address(RVA = "0x29F2CC0", Offset = "0x29F16C0", VA = "0x1829F2CC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<AnyGenerator> repeatedField = generators_;
					FieldCodec<AnyGenerator> repeated_generators_codec = _repeated_generators_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_generators_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012B7")]
		[Cpp2IlInjected.Address(RVA = "0x29F2A20", Offset = "0x29F1420", VA = "0x1829F2A20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<AnyGenerator> repeatedField = generators_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012B8")]
		[Cpp2IlInjected.Address(RVA = "0x29F2DB0", Offset = "0x29F17B0", VA = "0x1829F2DB0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60012B9")]
		[Cpp2IlInjected.Address(RVA = "0x29F2430", Offset = "0x29F0E30", VA = "0x1829F2430", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<AnyGenerator> repeatedField = generators_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012BA")]
		[Cpp2IlInjected.Address(RVA = "0x29F2AA0", Offset = "0x29F14A0", VA = "0x1829F2AA0")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			int num2 = 0;
			RepeatedField<AnyGenerator> repeatedField = generators_;
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

		[Cpp2IlInjected.Token(Token = "0x60012BB")]
		[Cpp2IlInjected.Address(RVA = "0x29F25C0", Offset = "0x29F0FC0", VA = "0x1829F25C0")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60012BC")]
		[Cpp2IlInjected.Address(RVA = "0x29F2750", Offset = "0x29F1150", VA = "0x1829F2750")]
		public MultiReward GenerateThis(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0050, IL_0056, IL_005c, IL_0062
			//IL_0016: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			int num = 0;
			List<ItemWithState> items2 = (List<ItemWithState>)0;
			List<IReward> list = (List<IReward>)(object)new List<T>();
			IEnumerable<AnyGenerator> enumerable = default(IEnumerable<AnyGenerator>);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0039;
					}
					num++;
				}
				((List<T>)(object)list).Add((T)num);
				goto IL_0039;
			}
			goto IL_0045;
			IL_0045:
			if (enumerable != null)
			{
			}
			return new MultiReward((IEnumerable<>)list);
			IL_0039:
			num += num;
			num += 312;
			goto IL_0045;
		}

		[Cpp2IlInjected.Token(Token = "0x60012BD")]
		[Cpp2IlInjected.Address(RVA = "0x29F2F30", Offset = "0x29F1930", VA = "0x1829F2F30")]
		static MultiGenerator()
		{
			Func<MultiGenerator> func = default(Func<MultiGenerator>);
			_parser = (MessageParser<MultiGenerator>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<AnyGenerator> parser = AnyGenerator._parser;
			uint num = default(uint);
			_parser = (MessageParser<MultiGenerator>)(object)FieldCodec.ForMessage<AnyGenerator>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012BE")]
		[Cpp2IlInjected.Address(RVA = "0x29F25D0", Offset = "0x29F0FD0", VA = "0x1829F25D0", Slot = "14")]
		bool IGenerator.IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			return this.IsValid(ref playerProfile, ref worldProfile, (List<>)(object)items);
		}

		[Cpp2IlInjected.Token(Token = "0x60012BF")]
		[Cpp2IlInjected.Address(RVA = "0x29F25C0", Offset = "0x29F0FC0", VA = "0x1829F25C0", Slot = "15")]
		IReward IGenerator.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
