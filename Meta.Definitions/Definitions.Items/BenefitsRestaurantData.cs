using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002E6")]
	public sealed class BenefitsRestaurantData : IMessage<BenefitsRestaurantData>, IMessage, IEquatable<BenefitsRestaurantData>, IDeepCloneable<BenefitsRestaurantData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000D4A")]
		private static readonly MessageParser<BenefitsRestaurantData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D4B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D4C")]
		public const int CookManaReductionPercentageFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000D4D")]
		private int cookManaReductionPercentage_;

		[Cpp2IlInjected.Token(Token = "0x4000D4E")]
		public const int NumberOfClientsFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000D4F")]
		private int numberOfClients_;

		[Cpp2IlInjected.Token(Token = "0x4000D50")]
		public const int OrderFriendshipBonusFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000D51")]
		private int orderFriendshipBonus_;

		[Cpp2IlInjected.Token(Token = "0x17000754")]
		[DebuggerNonUserCode]
		public static MessageParser<BenefitsRestaurantData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001FA6")]
			[Cpp2IlInjected.Address(RVA = "0x32E5E80", Offset = "0x32E4880", VA = "0x1832E5E80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000755")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001FA7")]
			[Cpp2IlInjected.Address(RVA = "0x32E5DB0", Offset = "0x32E47B0", VA = "0x1832E5DB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000756")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001FA8")]
			[Cpp2IlInjected.Address(RVA = "0x32E5EE0", Offset = "0x32E48E0", VA = "0x1832E5EE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000757")]
		[DebuggerNonUserCode]
		public int CookManaReductionPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6001FAC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return cookManaReductionPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001FAD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				cookManaReductionPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000758")]
		[DebuggerNonUserCode]
		public int NumberOfClients
		{
			[Cpp2IlInjected.Token(Token = "0x6001FAE")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return numberOfClients_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001FAF")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				numberOfClients_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000759")]
		[DebuggerNonUserCode]
		public int OrderFriendshipBonus
		{
			[Cpp2IlInjected.Token(Token = "0x6001FB0")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return orderFriendshipBonus_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001FB1")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				orderFriendshipBonus_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BenefitsRestaurantData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAA")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public BenefitsRestaurantData(BenefitsRestaurantData other)
		{
			int num = (cookManaReductionPercentage_ = other.cookManaReductionPercentage_);
			int num2 = (numberOfClients_ = other.numberOfClients_);
			int num3 = (orderFriendshipBonus_ = other.orderFriendshipBonus_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAB")]
		[Cpp2IlInjected.Address(RVA = "0x32E5930", Offset = "0x32E4330", VA = "0x1832E5930", Slot = "10")]
		[DebuggerNonUserCode]
		public BenefitsRestaurantData Clone()
		{
			//Discarded unreachable code: IL_0047
			BenefitsRestaurantData benefitsRestaurantData = new BenefitsRestaurantData();
			int num = (benefitsRestaurantData.cookManaReductionPercentage_ = cookManaReductionPercentage_);
			int num2 = (benefitsRestaurantData.numberOfClients_ = numberOfClients_);
			int num3 = (benefitsRestaurantData.orderFriendshipBonus_ = orderFriendshipBonus_);
			UnknownFieldSet unknownFieldSet = (benefitsRestaurantData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return benefitsRestaurantData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB2")]
		[Cpp2IlInjected.Address(RVA = "0x32E59C0", Offset = "0x32E43C0", VA = "0x1832E59C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)cookManaReductionPercentage_ == (IntPtr)typeof(BenefitsRestaurantData).TypeHandle && (IntPtr)numberOfClients_ == (IntPtr)typeof(BenefitsRestaurantData).TypeHandle && (IntPtr)orderFriendshipBonus_ == (IntPtr)typeof(BenefitsRestaurantData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB3")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BenefitsRestaurantData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.cookManaReductionPercentage_;
				if (cookManaReductionPercentage_ == num)
				{
					int num2 = other.numberOfClients_;
					if (numberOfClients_ == num2)
					{
						int num3 = other.orderFriendshipBonus_;
						if (orderFriendshipBonus_ == num3)
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

		[Cpp2IlInjected.Token(Token = "0x6001FB4")]
		[Cpp2IlInjected.Address(RVA = "0x25C36F0", Offset = "0x25C20F0", VA = "0x1825C36F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (cookManaReductionPercentage_ != 0)
				{
				}
				if (numberOfClients_ != 0)
				{
				}
				if (orderFriendshipBonus_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB5")]
		[Cpp2IlInjected.Address(RVA = "0x32E5C40", Offset = "0x32E4640", VA = "0x1832E5C40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB6")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (cookManaReductionPercentage_ != 0)
			{
				int value = cookManaReductionPercentage_;
				output.WriteInt32(value);
			}
			if (numberOfClients_ != 0)
			{
				int value2 = numberOfClients_;
				output.WriteInt32(value2);
			}
			if (orderFriendshipBonus_ != 0)
			{
				int value3 = orderFriendshipBonus_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB7")]
		[Cpp2IlInjected.Address(RVA = "0x32E5830", Offset = "0x32E4230", VA = "0x1832E5830", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = cookManaReductionPercentage_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = numberOfClients_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = orderFriendshipBonus_;
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

		[Cpp2IlInjected.Token(Token = "0x6001FB8")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BenefitsRestaurantData other)
		{
			if (other != null)
			{
				int num = other.cookManaReductionPercentage_;
				if (num != 0)
				{
					cookManaReductionPercentage_ = num;
				}
				int num2 = other.numberOfClients_;
				if (num2 != 0)
				{
					numberOfClients_ = num2;
				}
				int num3 = other.orderFriendshipBonus_;
				if (num3 != 0)
				{
					orderFriendshipBonus_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB9")]
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
					int num2 = (cookManaReductionPercentage_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (numberOfClients_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (orderFriendshipBonus_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FBA")]
		[Cpp2IlInjected.Address(RVA = "0x32E5A60", Offset = "0x32E4460", VA = "0x1832E5A60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = cookManaReductionPercentage_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FBB")]
		[Cpp2IlInjected.Address(RVA = "0x32E5B30", Offset = "0x32E4530", VA = "0x1832E5B30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028, IL_002e, IL_0034
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
					orderFriendshipBonus_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					numberOfClients_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				cookManaReductionPercentage_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FBC")]
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
				orderFriendshipBonus_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FBD")]
		[Cpp2IlInjected.Address(RVA = "0x32E5CA0", Offset = "0x32E46A0", VA = "0x1832E5CA0")]
		static BenefitsRestaurantData()
		{
			Func<BenefitsRestaurantData> func = default(Func<BenefitsRestaurantData>);
			_parser = (MessageParser<BenefitsRestaurantData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
