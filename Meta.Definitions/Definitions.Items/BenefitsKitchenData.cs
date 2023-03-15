using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002E0")]
	public sealed class BenefitsKitchenData : IMessage<BenefitsKitchenData>, IMessage, IEquatable<BenefitsKitchenData>, IDeepCloneable<BenefitsKitchenData>, IMessageFieldAccessor, IUpgradeStallDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4000D2B")]
		private static readonly MessageParser<BenefitsKitchenData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D2C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D2D")]
		public const int NumberOfSlotsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000D2E")]
		private int numberOfSlots_;

		[Cpp2IlInjected.Token(Token = "0x4000D2F")]
		public const int RefreshCostFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000D30")]
		private int refreshCost_;

		[Cpp2IlInjected.Token(Token = "0x1700073F")]
		[DebuggerNonUserCode]
		public static MessageParser<BenefitsKitchenData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001F4F")]
			[Cpp2IlInjected.Address(RVA = "0x32E56C0", Offset = "0x32E40C0", VA = "0x1832E56C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000740")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F50")]
			[Cpp2IlInjected.Address(RVA = "0x32E55F0", Offset = "0x32E3FF0", VA = "0x1832E55F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000741")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F51")]
			[Cpp2IlInjected.Address(RVA = "0x32E5720", Offset = "0x32E4120", VA = "0x1832E5720", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000742")]
		[DebuggerNonUserCode]
		public int NumberOfSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6001F55")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				return numberOfSlots_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F56")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				numberOfSlots_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000743")]
		[DebuggerNonUserCode]
		public int RefreshCost
		{
			[Cpp2IlInjected.Token(Token = "0x6001F57")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "14")]
			get
			{
				return refreshCost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F58")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				refreshCost_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F52")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BenefitsKitchenData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001F53")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public BenefitsKitchenData(BenefitsKitchenData other)
		{
			int num = (numberOfSlots_ = other.numberOfSlots_);
			int num2 = (refreshCost_ = other.refreshCost_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F54")]
		[Cpp2IlInjected.Address(RVA = "0x32E51E0", Offset = "0x32E3BE0", VA = "0x1832E51E0", Slot = "10")]
		[DebuggerNonUserCode]
		public BenefitsKitchenData Clone()
		{
			//Discarded unreachable code: IL_0037
			BenefitsKitchenData benefitsKitchenData = new BenefitsKitchenData();
			int num = (benefitsKitchenData.numberOfSlots_ = numberOfSlots_);
			int num2 = (benefitsKitchenData.refreshCost_ = refreshCost_);
			UnknownFieldSet unknownFieldSet = (benefitsKitchenData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return benefitsKitchenData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F59")]
		[Cpp2IlInjected.Address(RVA = "0x32E5270", Offset = "0x32E3C70", VA = "0x1832E5270", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)numberOfSlots_ == (IntPtr)typeof(BenefitsKitchenData).TypeHandle && (IntPtr)refreshCost_ == (IntPtr)typeof(BenefitsKitchenData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5A")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BenefitsKitchenData other)
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
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5B")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5C")]
		[Cpp2IlInjected.Address(RVA = "0x32E5480", Offset = "0x32E3E80", VA = "0x1832E5480", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5D")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
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
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5E")]
		[Cpp2IlInjected.Address(RVA = "0x32E5110", Offset = "0x32E3B10", VA = "0x1832E5110", Slot = "7")]
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5F")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BenefitsKitchenData other)
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
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F60")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (numberOfSlots_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (refreshCost_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F61")]
		[Cpp2IlInjected.Address(RVA = "0x32E5300", Offset = "0x32E3D00", VA = "0x1832E5300", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = numberOfSlots_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F62")]
		[Cpp2IlInjected.Address(RVA = "0x32E53C0", Offset = "0x32E3DC0", VA = "0x1832E53C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				numberOfSlots_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			refreshCost_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F63")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				numberOfSlots_ = 0;
				break;
			case 2:
				refreshCost_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F64")]
		[Cpp2IlInjected.Address(RVA = "0x32E54E0", Offset = "0x32E3EE0", VA = "0x1832E54E0")]
		static BenefitsKitchenData()
		{
			Func<BenefitsKitchenData> func = default(Func<BenefitsKitchenData>);
			_parser = (MessageParser<BenefitsKitchenData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
