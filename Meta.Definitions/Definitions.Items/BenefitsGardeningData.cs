using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002DE")]
	public sealed class BenefitsGardeningData : IMessage<BenefitsGardeningData>, IMessage, IEquatable<BenefitsGardeningData>, IDeepCloneable<BenefitsGardeningData>, IMessageFieldAccessor, IUpgradeStallDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4000D22")]
		private static readonly MessageParser<BenefitsGardeningData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D23")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D24")]
		public const int NumberOfSlotsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000D25")]
		private int numberOfSlots_;

		[Cpp2IlInjected.Token(Token = "0x4000D26")]
		public const int RefreshCostFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000D27")]
		private int refreshCost_;

		[Cpp2IlInjected.Token(Token = "0x4000D28")]
		public const int SellCapFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000D29")]
		private int sellCap_;

		[Cpp2IlInjected.Token(Token = "0x17000739")]
		[DebuggerNonUserCode]
		public static MessageParser<BenefitsGardeningData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001F34")]
			[Cpp2IlInjected.Address(RVA = "0x32E4690", Offset = "0x32E3090", VA = "0x1832E4690")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F35")]
			[Cpp2IlInjected.Address(RVA = "0x32E45C0", Offset = "0x32E2FC0", VA = "0x1832E45C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F36")]
			[Cpp2IlInjected.Address(RVA = "0x32E46F0", Offset = "0x32E30F0", VA = "0x1832E46F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073C")]
		[DebuggerNonUserCode]
		public int NumberOfSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6001F3A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				return numberOfSlots_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F3B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				numberOfSlots_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073D")]
		[DebuggerNonUserCode]
		public int RefreshCost
		{
			[Cpp2IlInjected.Token(Token = "0x6001F3C")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "14")]
			get
			{
				return refreshCost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F3D")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				refreshCost_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073E")]
		[DebuggerNonUserCode]
		public int SellCap
		{
			[Cpp2IlInjected.Token(Token = "0x6001F3E")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return sellCap_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F3F")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				sellCap_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F37")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BenefitsGardeningData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001F38")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public BenefitsGardeningData(BenefitsGardeningData other)
		{
			int num = (numberOfSlots_ = other.numberOfSlots_);
			int num2 = (refreshCost_ = other.refreshCost_);
			int num3 = (sellCap_ = other.sellCap_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F39")]
		[Cpp2IlInjected.Address(RVA = "0x32E4140", Offset = "0x32E2B40", VA = "0x1832E4140", Slot = "10")]
		[DebuggerNonUserCode]
		public BenefitsGardeningData Clone()
		{
			//Discarded unreachable code: IL_0047
			BenefitsGardeningData benefitsGardeningData = new BenefitsGardeningData();
			int num = (benefitsGardeningData.numberOfSlots_ = numberOfSlots_);
			int num2 = (benefitsGardeningData.refreshCost_ = refreshCost_);
			int num3 = (benefitsGardeningData.sellCap_ = sellCap_);
			UnknownFieldSet unknownFieldSet = (benefitsGardeningData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return benefitsGardeningData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F40")]
		[Cpp2IlInjected.Address(RVA = "0x32E41D0", Offset = "0x32E2BD0", VA = "0x1832E41D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)numberOfSlots_ == (IntPtr)typeof(BenefitsGardeningData).TypeHandle && (IntPtr)refreshCost_ == (IntPtr)typeof(BenefitsGardeningData).TypeHandle && (IntPtr)sellCap_ == (IntPtr)typeof(BenefitsGardeningData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F41")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BenefitsGardeningData other)
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
					int num2 = other.refreshCost_;
					if (refreshCost_ == num2)
					{
						int num3 = other.sellCap_;
						if (sellCap_ == num3)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F42")]
		[Cpp2IlInjected.Address(RVA = "0x25C36F0", Offset = "0x25C20F0", VA = "0x1825C36F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (numberOfSlots_ != 0)
				{
				}
				if (refreshCost_ != 0)
				{
				}
				if (sellCap_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F43")]
		[Cpp2IlInjected.Address(RVA = "0x32E4450", Offset = "0x32E2E50", VA = "0x1832E4450", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F44")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (numberOfSlots_ != 0)
			{
				int value = numberOfSlots_;
				output.WriteInt32(value);
			}
			if (refreshCost_ != 0)
			{
				int value2 = refreshCost_;
				output.WriteInt32(value2);
			}
			if (sellCap_ != 0)
			{
				int value3 = sellCap_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F45")]
		[Cpp2IlInjected.Address(RVA = "0x32E4040", Offset = "0x32E2A40", VA = "0x1832E4040", Slot = "7")]
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
				int num4 = refreshCost_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = sellCap_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num8 = unknownFields.CalculateSize();
			return num8 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F46")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BenefitsGardeningData other)
		{
			if (other != null)
			{
				int num = other.numberOfSlots_;
				if (num != 0)
				{
					numberOfSlots_ = num;
				}
				int num2 = other.refreshCost_;
				if (num2 != 0)
				{
					refreshCost_ = num2;
				}
				int num3 = other.sellCap_;
				if (num3 != 0)
				{
					sellCap_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F47")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (numberOfSlots_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (refreshCost_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (sellCap_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F48")]
		[Cpp2IlInjected.Address(RVA = "0x32E4270", Offset = "0x32E2C70", VA = "0x1832E4270", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = numberOfSlots_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F49")]
		[Cpp2IlInjected.Address(RVA = "0x32E4340", Offset = "0x32E2D40", VA = "0x1832E4340", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					sellCap_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					refreshCost_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				numberOfSlots_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4A")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				sellCap_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4B")]
		[Cpp2IlInjected.Address(RVA = "0x32E44B0", Offset = "0x32E2EB0", VA = "0x1832E44B0")]
		static BenefitsGardeningData()
		{
			Func<BenefitsGardeningData> func = default(Func<BenefitsGardeningData>);
			_parser = (MessageParser<BenefitsGardeningData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
