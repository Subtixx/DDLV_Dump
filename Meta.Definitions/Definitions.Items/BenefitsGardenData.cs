using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002E2")]
	public sealed class BenefitsGardenData : IMessage<BenefitsGardenData>, IMessage, IEquatable<BenefitsGardenData>, IDeepCloneable<BenefitsGardenData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000D32")]
		private static readonly MessageParser<BenefitsGardenData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D33")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D34")]
		public const int NumberOfSlotsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000D35")]
		private int numberOfSlots_;

		[Cpp2IlInjected.Token(Token = "0x4000D36")]
		public const int SeedLootTableItemIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000D37")]
		private int seedLootTableItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000D38")]
		public const int CreateGardeningTileManaReductionPercentageFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000D39")]
		private int createGardeningTileManaReductionPercentage_;

		[Cpp2IlInjected.Token(Token = "0x4000D3A")]
		public const int PlantSeedManaReductionPercentageFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000D3B")]
		private int plantSeedManaReductionPercentage_;

		[Cpp2IlInjected.Token(Token = "0x17000744")]
		[DebuggerNonUserCode]
		public static MessageParser<BenefitsGardenData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001F68")]
			[Cpp2IlInjected.Address(RVA = "0x32E3E70", Offset = "0x32E2870", VA = "0x1832E3E70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000745")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F69")]
			[Cpp2IlInjected.Address(RVA = "0x32E3DA0", Offset = "0x32E27A0", VA = "0x1832E3DA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000746")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F6A")]
			[Cpp2IlInjected.Address(RVA = "0x32E3F30", Offset = "0x32E2930", VA = "0x1832E3F30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000747")]
		[DebuggerNonUserCode]
		public int NumberOfSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6001F6E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return numberOfSlots_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F6F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				numberOfSlots_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000748")]
		[DebuggerNonUserCode]
		public int SeedLootTableItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001F70")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return seedLootTableItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F71")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				seedLootTableItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000749")]
		[DebuggerNonUserCode]
		public int CreateGardeningTileManaReductionPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6001F72")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return createGardeningTileManaReductionPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F73")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				createGardeningTileManaReductionPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074A")]
		[DebuggerNonUserCode]
		public int PlantSeedManaReductionPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6001F74")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return plantSeedManaReductionPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F75")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				plantSeedManaReductionPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074B")]
		public Item SeedLootTableItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001F81")]
			[Cpp2IlInjected.Address(RVA = "0x32E3ED0", Offset = "0x32E28D0", VA = "0x1832E3ED0")]
			get
			{
				long num = Convert.ToInt64((uint)seedLootTableItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F82")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				//IL_0007: Expected I4, but got O
				seedLootTableItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F6B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BenefitsGardenData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001F6C")]
		[Cpp2IlInjected.Address(RVA = "0x1BF4500", Offset = "0x1BF2F00", VA = "0x181BF4500")]
		[DebuggerNonUserCode]
		public BenefitsGardenData(BenefitsGardenData other)
		{
			int num = (numberOfSlots_ = other.numberOfSlots_);
			int num2 = (seedLootTableItemID_ = other.seedLootTableItemID_);
			int num3 = (createGardeningTileManaReductionPercentage_ = other.createGardeningTileManaReductionPercentage_);
			int num4 = (plantSeedManaReductionPercentage_ = other.plantSeedManaReductionPercentage_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F6D")]
		[Cpp2IlInjected.Address(RVA = "0x32E38D0", Offset = "0x32E22D0", VA = "0x1832E38D0", Slot = "10")]
		[DebuggerNonUserCode]
		public BenefitsGardenData Clone()
		{
			//Discarded unreachable code: IL_0057
			BenefitsGardenData benefitsGardenData = new BenefitsGardenData();
			int num = (benefitsGardenData.numberOfSlots_ = numberOfSlots_);
			int num2 = (benefitsGardenData.seedLootTableItemID_ = seedLootTableItemID_);
			int num3 = (benefitsGardenData.createGardeningTileManaReductionPercentage_ = createGardeningTileManaReductionPercentage_);
			int num4 = (benefitsGardenData.plantSeedManaReductionPercentage_ = plantSeedManaReductionPercentage_);
			UnknownFieldSet unknownFieldSet = (benefitsGardenData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return benefitsGardenData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F76")]
		[Cpp2IlInjected.Address(RVA = "0x32E3960", Offset = "0x32E2360", VA = "0x1832E3960", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)numberOfSlots_ == (IntPtr)typeof(BenefitsGardenData).TypeHandle && (IntPtr)seedLootTableItemID_ == (IntPtr)typeof(BenefitsGardenData).TypeHandle && (IntPtr)createGardeningTileManaReductionPercentage_ == (IntPtr)typeof(BenefitsGardenData).TypeHandle && (IntPtr)plantSeedManaReductionPercentage_ == (IntPtr)typeof(BenefitsGardenData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F77")]
		[Cpp2IlInjected.Address(RVA = "0x1BF3E50", Offset = "0x1BF2850", VA = "0x181BF3E50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BenefitsGardenData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.numberOfSlots_;
				if (numberOfSlots_ == num)
				{
					int num2 = other.seedLootTableItemID_;
					if (seedLootTableItemID_ == num2)
					{
						int num3 = other.createGardeningTileManaReductionPercentage_;
						if (createGardeningTileManaReductionPercentage_ == num3)
						{
							int num4 = other.plantSeedManaReductionPercentage_;
							if (plantSeedManaReductionPercentage_ == num4)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F78")]
		[Cpp2IlInjected.Address(RVA = "0x1BF3F60", Offset = "0x1BF2960", VA = "0x181BF3F60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (numberOfSlots_ != 0)
				{
				}
				if (seedLootTableItemID_ != 0)
				{
				}
				if (createGardeningTileManaReductionPercentage_ != 0)
				{
				}
				if (plantSeedManaReductionPercentage_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F79")]
		[Cpp2IlInjected.Address(RVA = "0x32E3C30", Offset = "0x32E2630", VA = "0x1832E3C30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7A")]
		[Cpp2IlInjected.Address(RVA = "0x1BF4310", Offset = "0x1BF2D10", VA = "0x181BF4310", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0072
			if (numberOfSlots_ != 0)
			{
				int value = numberOfSlots_;
				output.WriteInt32(value);
			}
			if (seedLootTableItemID_ != 0)
			{
				int value2 = seedLootTableItemID_;
				output.WriteInt32(value2);
			}
			if (createGardeningTileManaReductionPercentage_ != 0)
			{
				int value3 = createGardeningTileManaReductionPercentage_;
				output.WriteInt32(value3);
			}
			if (plantSeedManaReductionPercentage_ != 0)
			{
				int value4 = plantSeedManaReductionPercentage_;
				output.WriteInt32(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7B")]
		[Cpp2IlInjected.Address(RVA = "0x32E37A0", Offset = "0x32E21A0", VA = "0x1832E37A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = numberOfSlots_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = seedLootTableItemID_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = createGardeningTileManaReductionPercentage_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				int num8 = plantSeedManaReductionPercentage_;
				if (num8 != 0)
				{
					int num9 = CodedOutputStream.ComputeInt32Size(num8);
					num9++;
					num2 += num9;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num10 = unknownFields.CalculateSize();
			return num10 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7C")]
		[Cpp2IlInjected.Address(RVA = "0x1BF4020", Offset = "0x1BF2A20", VA = "0x181BF4020", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BenefitsGardenData other)
		{
			if (other != null)
			{
				int num = other.numberOfSlots_;
				if (num != 0)
				{
					numberOfSlots_ = num;
				}
				int num2 = other.seedLootTableItemID_;
				if (num2 != 0)
				{
					seedLootTableItemID_ = num2;
				}
				int num3 = other.createGardeningTileManaReductionPercentage_;
				if (num3 != 0)
				{
					createGardeningTileManaReductionPercentage_ = num3;
				}
				int num4 = other.plantSeedManaReductionPercentage_;
				if (num4 != 0)
				{
					plantSeedManaReductionPercentage_ = num4;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7D")]
		[Cpp2IlInjected.Address(RVA = "0x1BF4090", Offset = "0x1BF2A90", VA = "0x181BF4090", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0079
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (createGardeningTileManaReductionPercentage_ = input.ReadInt32());
				}
				if (num != 32)
				{
					goto IL_0062;
				}
				int num3 = (plantSeedManaReductionPercentage_ = input.ReadInt32());
			}
			int num4 = default(int);
			if (num == 8)
			{
				num4 = (numberOfSlots_ = input.ReadInt32());
			}
			if (num4 == 16)
			{
				int num5 = (seedLootTableItemID_ = input.ReadInt32());
			}
			goto IL_0062;
			IL_0062:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7E")]
		[Cpp2IlInjected.Address(RVA = "0x32E3A00", Offset = "0x32E2400", VA = "0x1832E3A00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 0 || num == 1)
			{
				int num2 = numberOfSlots_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7F")]
		[Cpp2IlInjected.Address(RVA = "0x32E3AD0", Offset = "0x32E24D0", VA = "0x1832E3AD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0035
			//IL_001b: Expected I4, but got O
			//IL_0023: Expected I4, but got O
			//IL_002b: Expected I4, but got O
			//IL_0034: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj2 = default(object);
						plantSeedManaReductionPercentage_ = (int)obj2;
						break;
					}
					case 0:
					{
						object obj = default(object);
						createGardeningTileManaReductionPercentage_ = (int)obj;
						break;
					}
					}
				}
				else
				{
					object obj3 = default(object);
					seedLootTableItemID_ = (int)obj3;
				}
			}
			else
			{
				object obj4 = default(object);
				numberOfSlots_ = (int)obj4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F80")]
		[Cpp2IlInjected.Address(RVA = "0x1BF3CE0", Offset = "0x1BF26E0", VA = "0x181BF3CE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				plantSeedManaReductionPercentage_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F83")]
		[Cpp2IlInjected.Address(RVA = "0x32E3C90", Offset = "0x32E2690", VA = "0x1832E3C90")]
		static BenefitsGardenData()
		{
			Func<BenefitsGardenData> func = default(Func<BenefitsGardenData>);
			_parser = (MessageParser<BenefitsGardenData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
