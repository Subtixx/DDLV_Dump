using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002DC")]
	public sealed class BenefitsFishingData : IMessage<BenefitsFishingData>, IMessage, IEquatable<BenefitsFishingData>, IDeepCloneable<BenefitsFishingData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000D14")]
		private static readonly MessageParser<BenefitsFishingData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D15")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D16")]
		public const int FishPerHourFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000D17")]
		private int fishPerHour_;

		[Cpp2IlInjected.Token(Token = "0x4000D18")]
		public const int FishCapFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000D19")]
		private int fishCap_;

		[Cpp2IlInjected.Token(Token = "0x4000D1A")]
		public const int FishAvailableFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000D1B")]
		private FishRarity fishAvailable_;

		[Cpp2IlInjected.Token(Token = "0x4000D1C")]
		public const int FishLootTableItemIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000D1D")]
		private int fishLootTableItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000D1E")]
		public const int FishingManaReductionPercentageFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000D1F")]
		private int fishingManaReductionPercentage_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000D20")]
		private List<FishRarity> allFishAvailable;

		[Cpp2IlInjected.Token(Token = "0x1700072F")]
		[DebuggerNonUserCode]
		public static MessageParser<BenefitsFishingData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001F11")]
			[Cpp2IlInjected.Address(RVA = "0x32E35C0", Offset = "0x32E1FC0", VA = "0x1832E35C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000730")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F12")]
			[Cpp2IlInjected.Address(RVA = "0x32E3490", Offset = "0x32E1E90", VA = "0x1832E3490")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000731")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F13")]
			[Cpp2IlInjected.Address(RVA = "0x32E3690", Offset = "0x32E2090", VA = "0x1832E3690", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000732")]
		[DebuggerNonUserCode]
		public int FishPerHour
		{
			[Cpp2IlInjected.Token(Token = "0x6001F17")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return fishPerHour_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F18")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				fishPerHour_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000733")]
		[DebuggerNonUserCode]
		public int FishCap
		{
			[Cpp2IlInjected.Token(Token = "0x6001F19")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return fishCap_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F1A")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				fishCap_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000734")]
		[DebuggerNonUserCode]
		public FishRarity FishAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6001F1B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return fishAvailable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F1C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				fishAvailable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000735")]
		[DebuggerNonUserCode]
		public int FishLootTableItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001F1D")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return fishLootTableItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F1E")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				fishLootTableItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000736")]
		[DebuggerNonUserCode]
		public int FishingManaReductionPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6001F1F")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return fishingManaReductionPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F20")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				fishingManaReductionPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000737")]
		public Item FishLootTableItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001F2C")]
			[Cpp2IlInjected.Address(RVA = "0x32E3560", Offset = "0x32E1F60", VA = "0x1832E3560")]
			get
			{
				long num = Convert.ToInt64((uint)fishLootTableItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000738")]
		public TimeSpan TimePerFish
		{
			[Cpp2IlInjected.Token(Token = "0x6001F2E")]
			[Cpp2IlInjected.Address(RVA = "0x32E3620", Offset = "0x32E2020", VA = "0x1832E3620")]
			get
			{
				TimeSpan result = default(TimeSpan);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F14")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BenefitsFishingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001F15")]
		[Cpp2IlInjected.Address(RVA = "0x1A54730", Offset = "0x1A53130", VA = "0x181A54730")]
		[DebuggerNonUserCode]
		public BenefitsFishingData(BenefitsFishingData other)
		{
			int num = (fishPerHour_ = other.fishPerHour_);
			int num2 = (fishCap_ = other.fishCap_);
			FishRarity fishRarity = (fishAvailable_ = other.fishAvailable_);
			int num3 = (fishLootTableItemID_ = other.fishLootTableItemID_);
			int num4 = (fishingManaReductionPercentage_ = other.fishingManaReductionPercentage_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F16")]
		[Cpp2IlInjected.Address(RVA = "0x32E2C60", Offset = "0x32E1660", VA = "0x1832E2C60", Slot = "10")]
		[DebuggerNonUserCode]
		public BenefitsFishingData Clone()
		{
			//Discarded unreachable code: IL_0067
			BenefitsFishingData benefitsFishingData = new BenefitsFishingData();
			int num = (benefitsFishingData.fishPerHour_ = fishPerHour_);
			int num2 = (benefitsFishingData.fishCap_ = fishCap_);
			FishRarity fishRarity = (benefitsFishingData.fishAvailable_ = fishAvailable_);
			int num3 = (benefitsFishingData.fishLootTableItemID_ = fishLootTableItemID_);
			int num4 = (benefitsFishingData.fishingManaReductionPercentage_ = fishingManaReductionPercentage_);
			UnknownFieldSet unknownFieldSet = (benefitsFishingData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return benefitsFishingData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F21")]
		[Cpp2IlInjected.Address(RVA = "0x32E2D00", Offset = "0x32E1700", VA = "0x1832E2D00", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)fishPerHour_ == (IntPtr)typeof(BenefitsFishingData).TypeHandle && (IntPtr)fishCap_ == (IntPtr)typeof(BenefitsFishingData).TypeHandle && (IntPtr)(void*)(int)fishAvailable_ == (IntPtr)typeof(BenefitsFishingData).TypeHandle && (IntPtr)fishLootTableItemID_ == (IntPtr)typeof(BenefitsFishingData).TypeHandle && (IntPtr)fishingManaReductionPercentage_ == (IntPtr)typeof(BenefitsFishingData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F22")]
		[Cpp2IlInjected.Address(RVA = "0x1A53B70", Offset = "0x1A52570", VA = "0x181A53B70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BenefitsFishingData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.fishPerHour_;
				if (fishPerHour_ == num)
				{
					int num2 = other.fishCap_;
					if (fishCap_ == num2)
					{
						FishRarity fishRarity = other.fishAvailable_;
						if (fishAvailable_ == fishRarity)
						{
							int num3 = other.fishLootTableItemID_;
							if (fishLootTableItemID_ == num3)
							{
								int num4 = other.fishingManaReductionPercentage_;
								if (fishingManaReductionPercentage_ == num4)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F23")]
		[Cpp2IlInjected.Address(RVA = "0x32E30A0", Offset = "0x32E1AA0", VA = "0x1832E30A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (fishPerHour_ != 0)
				{
				}
				if (fishCap_ != 0)
				{
				}
				if (fishAvailable_ != 0)
				{
				}
				if (fishLootTableItemID_ != 0)
				{
				}
				if (fishingManaReductionPercentage_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F24")]
		[Cpp2IlInjected.Address(RVA = "0x32E3320", Offset = "0x32E1D20", VA = "0x1832E3320", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F25")]
		[Cpp2IlInjected.Address(RVA = "0x1A54520", Offset = "0x1A52F20", VA = "0x181A54520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007b
			if (fishPerHour_ != 0)
			{
				int value = fishPerHour_;
				output.WriteInt32(value);
			}
			if (fishCap_ != 0)
			{
				int value2 = fishCap_;
				output.WriteInt32(value2);
			}
			if (fishAvailable_ != 0)
			{
			}
			if (fishLootTableItemID_ != 0)
			{
				int value3 = fishLootTableItemID_;
				output.WriteInt32(value3);
			}
			if (fishingManaReductionPercentage_ != 0)
			{
				int value4 = fishingManaReductionPercentage_;
				output.WriteInt32(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F26")]
		[Cpp2IlInjected.Address(RVA = "0x32E2B00", Offset = "0x32E1500", VA = "0x1832E2B00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = fishPerHour_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = fishCap_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				FishRarity fishRarity = fishAvailable_;
				if (fishRarity != 0)
				{
					int num6 = CodedOutputStream.ComputeEnumSize((int)fishRarity);
					num6++;
					num2 += num6;
				}
				int num7 = fishLootTableItemID_;
				if (num7 != 0)
				{
					int num8 = CodedOutputStream.ComputeInt32Size(num7);
					num8++;
					num2 += num8;
				}
				int num9 = fishingManaReductionPercentage_;
				if (num9 != 0)
				{
					int num10 = CodedOutputStream.ComputeInt32Size(num9);
					num10++;
					num2 += num10;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num11 = unknownFields.CalculateSize();
			return num11 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F27")]
		[Cpp2IlInjected.Address(RVA = "0x1A53E20", Offset = "0x1A52820", VA = "0x181A53E20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BenefitsFishingData other)
		{
			if (other != null)
			{
				int num = other.fishPerHour_;
				if (num != 0)
				{
					fishPerHour_ = num;
				}
				int num2 = other.fishCap_;
				if (num2 != 0)
				{
					fishCap_ = num2;
				}
				FishRarity fishRarity = other.fishAvailable_;
				if (fishRarity != 0)
				{
					fishAvailable_ = fishRarity;
				}
				int num3 = other.fishLootTableItemID_;
				if (num3 != 0)
				{
					fishLootTableItemID_ = num3;
				}
				int num4 = other.fishingManaReductionPercentage_;
				if (num4 != 0)
				{
					fishingManaReductionPercentage_ = num4;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F28")]
		[Cpp2IlInjected.Address(RVA = "0x1A53EA0", Offset = "0x1A528A0", VA = "0x181A53EA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0092
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (int)(fishAvailable_ = (FishRarity)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (fishLootTableItemID_ = input.ReadInt32());
				}
				if (num3 != 40)
				{
					goto IL_007b;
				}
				int num4 = (fishingManaReductionPercentage_ = input.ReadInt32());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (fishPerHour_ = input.ReadInt32());
			}
			if (num5 == 16)
			{
				int num6 = (fishCap_ = input.ReadInt32());
			}
			goto IL_007b;
			IL_007b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001F29")]
		[Cpp2IlInjected.Address(RVA = "0x32E2FB0", Offset = "0x32E19B0", VA = "0x1832E2FB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 0 || num == 0 || num == 1)
			{
				int num2 = fishPerHour_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2A")]
		[Cpp2IlInjected.Address(RVA = "0x32E3170", Offset = "0x32E1B70", VA = "0x1832E3170", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0042
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_002f: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							object obj2 = default(object);
							fishingManaReductionPercentage_ = (int)obj2;
							break;
						}
						case 0:
						{
							object obj = default(object);
							fishLootTableItemID_ = (int)obj;
							break;
						}
						}
					}
					else
					{
						object obj3 = default(object);
						fishAvailable_ = (FishRarity)obj3;
					}
				}
				else
				{
					object obj4 = default(object);
					fishCap_ = (int)obj4;
				}
			}
			else
			{
				object obj5 = default(object);
				fishPerHour_ = (int)obj5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2B")]
		[Cpp2IlInjected.Address(RVA = "0x1A53A70", Offset = "0x1A52470", VA = "0x181A53A70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022, IL_002c
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				fishingManaReductionPercentage_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2D")]
		[Cpp2IlInjected.Address(RVA = "0x32E2850", Offset = "0x32E1250", VA = "0x1832E2850")]
		public List<FishRarity> AllFishAvailable(IBuildingUpgradable buildingUpgradable)
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_007c, IL_0082, IL_0088
			int num = 0;
			List<FishRarity> list = allFishAvailable;
			if (list == null)
			{
				List<FishRarity> list2 = (allFishAvailable = (List<FishRarity>)(object)new List<T>());
				FishRarity fishRarity = fishAvailable_;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				bool flag = default(bool);
				BenefitsFishingData benefitsFishingData = default(BenefitsFishingData);
				if (flag && fishAvailable_ != benefitsFishingData.fishAvailable_)
				{
					BenefitsFishingData benefitsFishingData2 = default(BenefitsFishingData);
					while (fishRarity == benefitsFishingData2.fishAvailable_)
					{
					}
					BenefitsFishingData benefitsFishingData3 = default(BenefitsFishingData);
					FishRarity fishRarity2 = benefitsFishingData3.fishAvailable_;
					List<FishRarity> list3 = allFishAvailable;
					int num3 = (int)fishRarity2;
					num3 += num3;
				}
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2F")]
		[Cpp2IlInjected.Address(RVA = "0x32E2DB0", Offset = "0x32E17B0", VA = "0x1832E2DB0")]
		public (TimeSpan, int) FishCollectInfo(DateTime now, DateTime lastCollect)
		{
			int num = 0;
			TimeSpan timeSpan = default(TimeSpan);
			TimeSpan timeSpan2 = default(TimeSpan);
			TimeSpan timeSpan3 = default(TimeSpan);
			if (timeSpan > timeSpan2)
			{
				timeSpan3 = timeSpan - timeSpan2;
				num++;
			}
			TimeSpan timeSpan4 = timeSpan2 - timeSpan3;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F30")]
		[Cpp2IlInjected.Address(RVA = "0x32E3380", Offset = "0x32E1D80", VA = "0x1832E3380")]
		static BenefitsFishingData()
		{
			Func<BenefitsFishingData> func = default(Func<BenefitsFishingData>);
			_parser = (MessageParser<BenefitsFishingData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
