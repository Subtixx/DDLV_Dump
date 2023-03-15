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
	[Cpp2IlInjected.Token(Token = "0x200021F")]
	public sealed class LootTable : IMessage<LootTable>, IMessage, IEquatable<LootTable>, IDeepCloneable<LootTable>, IMessageFieldAccessor, IGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x40008AC")]
		private static readonly MessageParser<LootTable> _parser = (MessageParser<LootTable>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new LootTable()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008AD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40008AE")]
		public const int SubLootTablesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40008AF")]
		private static readonly FieldCodec<SubLootTable> _repeated_subLootTables_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008B0")]
		private readonly RepeatedField<SubLootTable> subLootTables_;

		[Cpp2IlInjected.Token(Token = "0x1700048A")]
		[DebuggerNonUserCode]
		public static MessageParser<LootTable> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001460")]
			[Cpp2IlInjected.Address(RVA = "0x38FBBA0", Offset = "0x38FA5A0", VA = "0x1838FBBA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001461")]
			[Cpp2IlInjected.Address(RVA = "0x38FBAD0", Offset = "0x38FA4D0", VA = "0x1838FBAD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001462")]
			[Cpp2IlInjected.Address(RVA = "0x38FBC00", Offset = "0x38FA600", VA = "0x1838FBC00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048D")]
		[DebuggerNonUserCode]
		public RepeatedField<SubLootTable> SubLootTables
		{
			[Cpp2IlInjected.Token(Token = "0x6001466")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return subLootTables_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001463")]
		[Cpp2IlInjected.Address(RVA = "0x38FBA50", Offset = "0x38FA450", VA = "0x1838FBA50")]
		[DebuggerNonUserCode]
		public LootTable()
		{
			subLootTables_ = (RepeatedField<SubLootTable>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001464")]
		[Cpp2IlInjected.Address(RVA = "0x38FB9C0", Offset = "0x38FA3C0", VA = "0x1838FB9C0")]
		[DebuggerNonUserCode]
		public LootTable(LootTable other)
		{
			RepeatedField<SubLootTable> repeatedField = (subLootTables_ = (RepeatedField<SubLootTable>)(object)((RepeatedField<T>)(object)other.subLootTables_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001465")]
		[Cpp2IlInjected.Address(RVA = "0x38FAC40", Offset = "0x38F9640", VA = "0x1838FAC40", Slot = "10")]
		[DebuggerNonUserCode]
		public LootTable Clone()
		{
			//Discarded unreachable code: IL_002e
			LootTable lootTable = new LootTable();
			RepeatedField<SubLootTable> repeatedField = (lootTable.subLootTables_ = (RepeatedField<SubLootTable>)(object)((RepeatedField<T>)(object)subLootTables_).Clone());
			UnknownFieldSet unknownFieldSet = (lootTable._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return lootTable;
		}

		[Cpp2IlInjected.Token(Token = "0x6001467")]
		[Cpp2IlInjected.Address(RVA = "0x38FAD40", Offset = "0x38F9740", VA = "0x1838FAD40", Slot = "0")]
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
				RepeatedField<SubLootTable> repeatedField = subLootTables_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001468")]
		[Cpp2IlInjected.Address(RVA = "0x38FAE20", Offset = "0x38F9820", VA = "0x1838FAE20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootTable other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<SubLootTable> repeatedField = subLootTables_;
				RepeatedField<SubLootTable> repeatedField2 = other.subLootTables_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001469")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)subLootTables_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600146A")]
		[Cpp2IlInjected.Address(RVA = "0x38FB6D0", Offset = "0x38FA0D0", VA = "0x1838FB6D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600146B")]
		[Cpp2IlInjected.Address(RVA = "0x38FB730", Offset = "0x38FA130", VA = "0x1838FB730", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<SubLootTable> repeatedField = subLootTables_;
			FieldCodec<SubLootTable> repeated_subLootTables_codec = _repeated_subLootTables_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_subLootTables_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600146C")]
		[Cpp2IlInjected.Address(RVA = "0x38FAB30", Offset = "0x38F9530", VA = "0x1838FAB30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<SubLootTable> repeatedField = subLootTables_;
			FieldCodec<SubLootTable> repeated_subLootTables_codec = _repeated_subLootTables_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_subLootTables_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600146D")]
		[Cpp2IlInjected.Address(RVA = "0x38FB5F0", Offset = "0x38F9FF0", VA = "0x1838FB5F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootTable other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<SubLootTable> repeatedField = subLootTables_;
				RepeatedField<SubLootTable> repeatedField2 = other.subLootTables_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600146E")]
		[Cpp2IlInjected.Address(RVA = "0x38FB500", Offset = "0x38F9F00", VA = "0x1838FB500", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<SubLootTable> repeatedField = subLootTables_;
					FieldCodec<SubLootTable> repeated_subLootTables_codec = _repeated_subLootTables_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_subLootTables_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600146F")]
		[Cpp2IlInjected.Address(RVA = "0x38FB2E0", Offset = "0x38F9CE0", VA = "0x1838FB2E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<SubLootTable> repeatedField = subLootTables_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001470")]
		[Cpp2IlInjected.Address(RVA = "0x38FB670", Offset = "0x38FA070", VA = "0x1838FB670", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6001471")]
		[Cpp2IlInjected.Address(RVA = "0x38FABE0", Offset = "0x38F95E0", VA = "0x1838FABE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<SubLootTable> repeatedField = subLootTables_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001472")]
		[Cpp2IlInjected.Address(RVA = "0x38FB360", Offset = "0x38F9D60", VA = "0x1838FB360")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			int num2 = 0;
			RepeatedField<SubLootTable> repeatedField = subLootTables_;
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

		[Cpp2IlInjected.Token(Token = "0x6001473")]
		[Cpp2IlInjected.Address(RVA = "0x38FAD00", Offset = "0x38F9700", VA = "0x1838FAD00")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001474")]
		[Cpp2IlInjected.Address(RVA = "0x38FAEB0", Offset = "0x38F98B0", VA = "0x1838FAEB0")]
		public MultiReward GenerateThis(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items, [Optional] RewardGenerationParameters parameters)
		{
			//Discarded unreachable code: IL_00ac, IL_00b2, IL_00b8
			//IL_0016: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			List<IReward> list;
			IEnumerable<SubLootTable> enumerable = default(IEnumerable<SubLootTable>);
			int num2;
			bool flag = default(bool);
			uint num4 = default(uint);
			IReward reward = default(IReward);
			do
			{
				int num = 0;
				List<ItemWithState> items2 = (List<ItemWithState>)0;
				RewardGenerationParameters parameters2 = (RewardGenerationParameters)0;
				list = (List<IReward>)(object)new List<T>();
				List<SubLootTable> list2 = (List<SubLootTable>)(object)Enumerable.ToList<SubLootTable>((IEnumerable<>)enumerable);
				Func<SubLootTable, int> _003C_003E9__30_ = _003C_003Ec._003C_003E9__30_1;
				if (_003C_003E9__30_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SubLootTable x) => x.weight_);
				}
				int maxValue = Enumerable.Sum<SubLootTable>((IEnumerable<>)list2, (Func<, >)(object)_003C_003E9__30_);
				num2 = random.Next(maxValue);
				int num3 = 0;
				if (!flag)
				{
					continue;
				}
				if (num3 != 0)
				{
				}
				flag = num > num2;
				while (num4 == 0)
				{
				}
				List<ItemWithState> list3 = items2;
				RewardGenerationParameters rewardGenerationParameters = parameters2;
				if (reward != null)
				{
					while (reward != null)
					{
					}
				}
				((List<T>)(object)list).Add((T)reward);
			}
			while (num2 != 0);
			return new MultiReward((IEnumerable<>)list);
		}

		[Cpp2IlInjected.Token(Token = "0x6001475")]
		[Cpp2IlInjected.Address(RVA = "0x38FB7F0", Offset = "0x38FA1F0", VA = "0x1838FB7F0")]
		static LootTable()
		{
			MessageParser<SubLootTable> parser = SubLootTable._parser;
			uint num = default(uint);
			_parser = (MessageParser<LootTable>)(object)FieldCodec.ForMessage<SubLootTable>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001476")]
		[Cpp2IlInjected.Address(RVA = "0x38FAD30", Offset = "0x38F9730", VA = "0x1838FAD30", Slot = "14")]
		bool IGenerator.IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			return this.IsValid(ref playerProfile, ref worldProfile, (List<>)(object)items);
		}

		[Cpp2IlInjected.Token(Token = "0x6001477")]
		[Cpp2IlInjected.Address(RVA = "0x38FAD00", Offset = "0x38F9700", VA = "0x1838FAD00", Slot = "15")]
		IReward IGenerator.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
