using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003CE")]
	public sealed class SpawnGarden : IMessage<SpawnGarden>, IMessage, IEquatable<SpawnGarden>, IDeepCloneable<SpawnGarden>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001406")]
		private static readonly MessageParser<SpawnGarden> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001407")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001408")]
		public const int GardenFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001409")]
		private ItemSelector garden_;

		[Cpp2IlInjected.Token(Token = "0x400140A")]
		public const int SeedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400140B")]
		private int seed_;

		[Cpp2IlInjected.Token(Token = "0x17000B65")]
		[DebuggerNonUserCode]
		public static MessageParser<SpawnGarden> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002D66")]
			[Cpp2IlInjected.Address(RVA = "0x262BA50", Offset = "0x262A450", VA = "0x18262BA50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B66")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D67")]
			[Cpp2IlInjected.Address(RVA = "0x262B980", Offset = "0x262A380", VA = "0x18262B980")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B67")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D68")]
			[Cpp2IlInjected.Address(RVA = "0x262BB10", Offset = "0x262A510", VA = "0x18262BB10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B68")]
		[DebuggerNonUserCode]
		public ItemSelector Garden
		{
			[Cpp2IlInjected.Token(Token = "0x6002D6D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return garden_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D6E")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				garden_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B69")]
		[DebuggerNonUserCode]
		public int Seed
		{
			[Cpp2IlInjected.Token(Token = "0x6002D6F")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return seed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D70")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				seed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B6A")]
		public Item SeedItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002D7C")]
			[Cpp2IlInjected.Address(RVA = "0x262BAB0", Offset = "0x262A4B0", VA = "0x18262BAB0")]
			get
			{
				long num = Convert.ToInt64((uint)seed_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D69")]
		[Cpp2IlInjected.Address(RVA = "0x262B840", Offset = "0x262A240", VA = "0x18262B840")]
		[DebuggerNonUserCode]
		public SpawnGarden()
		{
			ItemSelector itemSelector = (garden_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D6A")]
		[Cpp2IlInjected.Address(RVA = "0x262B5A0", Offset = "0x2629FA0", VA = "0x18262B5A0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (garden_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D6B")]
		[Cpp2IlInjected.Address(RVA = "0x262B8B0", Offset = "0x262A2B0", VA = "0x18262B8B0")]
		[DebuggerNonUserCode]
		public SpawnGarden(SpawnGarden other)
		{
			//IL_002e: Expected O, but got I4
			ItemSelector itemSelector = (garden_ = new ItemSelector());
			ItemSelector itemSelector2 = other.garden_;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			int num = 0;
			garden_ = (ItemSelector)num;
			int num2 = (seed_ = other.seed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D6C")]
		[Cpp2IlInjected.Address(RVA = "0x262AE00", Offset = "0x2629800", VA = "0x18262AE00", Slot = "10")]
		[DebuggerNonUserCode]
		public SpawnGarden Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0030: Expected O, but got I4
			SpawnGarden spawnGarden = new SpawnGarden();
			ItemSelector itemSelector = (spawnGarden.garden_ = new ItemSelector());
			ItemSelector itemSelector2 = garden_;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			int num = 0;
			spawnGarden.garden_ = (ItemSelector)num;
			int num2 = (spawnGarden.seed_ = seed_);
			UnknownFieldSet unknownFieldSet = (spawnGarden._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return spawnGarden;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D71")]
		[Cpp2IlInjected.Address(RVA = "0x262B250", Offset = "0x2629C50", VA = "0x18262B250", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(garden_, other);
				if (flag && seed_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D72")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SpawnGarden other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.garden_;
				if (object.Equals(garden_, objB))
				{
					int num = other.seed_;
					if (seed_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D73")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = garden_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				if (seed_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D74")]
		[Cpp2IlInjected.Address(RVA = "0x262B6D0", Offset = "0x262A0D0", VA = "0x18262B6D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D75")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)garden_ != 0)
			{
				ItemSelector value = garden_;
				output.WriteMessage(value);
			}
			if (seed_ != 0)
			{
				int value2 = seed_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D76")]
		[Cpp2IlInjected.Address(RVA = "0x262AD30", Offset = "0x2629730", VA = "0x18262AD30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = garden_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
				}
				int num3 = seed_;
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

		[Cpp2IlInjected.Token(Token = "0x6002D77")]
		[Cpp2IlInjected.Address(RVA = "0x262B3D0", Offset = "0x2629DD0", VA = "0x18262B3D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SpawnGarden other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.garden_ != 0)
			{
				ItemSelector itemSelector = garden_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (garden_ = new ItemSelector());
				}
				ItemSelector other2 = other.garden_;
				itemSelector.MergeFrom(other2);
			}
			int num = other.seed_;
			if (num != 0)
			{
				seed_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002D78")]
		[Cpp2IlInjected.Address(RVA = "0x262B4B0", Offset = "0x2629EB0", VA = "0x18262B4B0", Slot = "5")]
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
				ItemSelector itemSelector = garden_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (garden_ = new ItemSelector());
				}
				input.ReadMessage(itemSelector);
			}
			if (num == 16)
			{
				int num2 = (seed_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002D79")]
		[Cpp2IlInjected.Address(RVA = "0x262B300", Offset = "0x2629D00", VA = "0x18262B300", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemSelector itemSelector = garden_;
			}
			if (fieldNumber == 2)
			{
				int num = seed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7A")]
		[Cpp2IlInjected.Address(RVA = "0x262B600", Offset = "0x262A000", VA = "0x18262B600", Slot = "12")]
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
				garden_ = (ItemSelector)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				seed_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7B")]
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
				seed_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7D")]
		[Cpp2IlInjected.Address(RVA = "0x262AF00", Offset = "0x2629900", VA = "0x18262AF00", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			int num = 0;
			ItemSelector itemSelector = garden_;
			if (itemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Item)
			{
				ItemSelector itemSelector2 = garden_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int item = itemSelector2.Item.item_.Item;
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				int num2 = seed_;
				bool flag2 = default(bool);
				if (!flag2)
				{
					return;
				}
				flag = flag2;
				bool flag3 = default(bool);
				if (flag3)
				{
					if (num != 0)
					{
					}
					context.AddInvalidMemberError("Those Garden/Seed cannot be pair together (wrong crop type)", "Seed");
				}
				return;
			}
			string text = $"Should be an Item, cannot be {itemSelector}";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7E")]
		[Cpp2IlInjected.Address(RVA = "0x262B730", Offset = "0x262A130", VA = "0x18262B730")]
		static SpawnGarden()
		{
			Func<SpawnGarden> func = default(Func<SpawnGarden>);
			_parser = (MessageParser<SpawnGarden>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
