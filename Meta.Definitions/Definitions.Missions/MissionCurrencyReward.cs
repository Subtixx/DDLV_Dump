using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000254")]
	public sealed class MissionCurrencyReward : IMessage<MissionCurrencyReward>, IMessage, IEquatable<MissionCurrencyReward>, IDeepCloneable<MissionCurrencyReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000947")]
		private static readonly MessageParser<MissionCurrencyReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000948")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000949")]
		public const int CurrencyIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400094A")]
		private int currencyId_;

		[Cpp2IlInjected.Token(Token = "0x400094B")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400094C")]
		private MissionRewardRange amount_;

		[Cpp2IlInjected.Token(Token = "0x170004EC")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionCurrencyReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600162F")]
			[Cpp2IlInjected.Address(RVA = "0x1D389D0", Offset = "0x1D373D0", VA = "0x181D389D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004ED")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001630")]
			[Cpp2IlInjected.Address(RVA = "0x1D38900", Offset = "0x1D37300", VA = "0x181D38900")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001631")]
			[Cpp2IlInjected.Address(RVA = "0x1D38A30", Offset = "0x1D37430", VA = "0x181D38A30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EF")]
		[DebuggerNonUserCode]
		public int CurrencyId
		{
			[Cpp2IlInjected.Token(Token = "0x6001635")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return currencyId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001636")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				currencyId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F0")]
		[DebuggerNonUserCode]
		public MissionRewardRange Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6001637")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001638")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				amount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001632")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MissionCurrencyReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001633")]
		[Cpp2IlInjected.Address(RVA = "0x1D38890", Offset = "0x1D37290", VA = "0x181D38890")]
		[DebuggerNonUserCode]
		public MissionCurrencyReward(MissionCurrencyReward other)
		{
			//IL_002f: Expected O, but got I4
			int num = (currencyId_ = other.currencyId_);
			MissionRewardRange missionRewardRange = other.amount_;
			if (missionRewardRange != null)
			{
				MissionRewardRange missionRewardRange2 = missionRewardRange.Clone();
			}
			int num2 = 0;
			amount_ = (MissionRewardRange)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001634")]
		[Cpp2IlInjected.Address(RVA = "0x1D38260", Offset = "0x1D36C60", VA = "0x181D38260", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionCurrencyReward Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0031: Expected O, but got I4
			MissionCurrencyReward missionCurrencyReward = new MissionCurrencyReward();
			int num = (missionCurrencyReward.currencyId_ = currencyId_);
			MissionRewardRange missionRewardRange = amount_;
			if (missionRewardRange != null)
			{
				MissionRewardRange missionRewardRange2 = missionRewardRange.Clone();
			}
			int num2 = 0;
			missionCurrencyReward.amount_ = (MissionRewardRange)num2;
			UnknownFieldSet unknownFieldSet = (missionCurrencyReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionCurrencyReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6001639")]
		[Cpp2IlInjected.Address(RVA = "0x1D38300", Offset = "0x1D36D00", VA = "0x181D38300", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)currencyId_ == (IntPtr)typeof(MissionCurrencyReward).TypeHandle && object.Equals(amount_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600163A")]
		[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionCurrencyReward other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.currencyId_;
				if (currencyId_ == num)
				{
					MissionRewardRange objB = other.amount_;
					if (object.Equals(amount_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600163B")]
		[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (currencyId_ != 0)
				{
				}
				MissionRewardRange missionRewardRange = amount_;
				if (missionRewardRange != null)
				{
					int hashCode = missionRewardRange.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600163C")]
		[Cpp2IlInjected.Address(RVA = "0x1D38720", Offset = "0x1D37120", VA = "0x181D38720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600163D")]
		[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if (currencyId_ != 0)
			{
				int value = currencyId_;
				output.WriteInt32(value);
			}
			if ((long)amount_ != 0)
			{
				MissionRewardRange value2 = amount_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600163E")]
		[Cpp2IlInjected.Address(RVA = "0x1D38190", Offset = "0x1D36B90", VA = "0x181D38190", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = currencyId_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				MissionRewardRange missionRewardRange = amount_;
				if (missionRewardRange != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(missionRewardRange);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600163F")]
		[Cpp2IlInjected.Address(RVA = "0x1D38480", Offset = "0x1D36E80", VA = "0x181D38480", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionCurrencyReward other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			int num = other.currencyId_;
			if (num != 0)
			{
				currencyId_ = num;
			}
			if ((long)other.amount_ != 0)
			{
				MissionRewardRange missionRewardRange2 = default(MissionRewardRange);
				if (amount_ == null)
				{
					MissionRewardRange missionRewardRange = (amount_ = new MissionRewardRange());
					missionRewardRange2 = amount_;
				}
				MissionRewardRange other2 = other.amount_;
				missionRewardRange2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001640")]
		[Cpp2IlInjected.Address(RVA = "0x1D38560", Offset = "0x1D36F60", VA = "0x181D38560", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (currencyId_ = input.ReadInt32());
			}
			if (num == 18)
			{
				MissionRewardRange builder = default(MissionRewardRange);
				if (amount_ == null)
				{
					MissionRewardRange missionRewardRange = (amount_ = new MissionRewardRange());
					builder = amount_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001641")]
		[Cpp2IlInjected.Address(RVA = "0x1D383B0", Offset = "0x1D36DB0", VA = "0x181D383B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = currencyId_;
			}
			if (fieldNumber == 2)
			{
				MissionRewardRange missionRewardRange = amount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001642")]
		[Cpp2IlInjected.Address(RVA = "0x1D38650", Offset = "0x1D37050", VA = "0x181D38650", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				currencyId_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				amount_ = (MissionRewardRange)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001643")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				currencyId_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001644")]
		[Cpp2IlInjected.Address(RVA = "0x1D38780", Offset = "0x1D37180", VA = "0x181D38780")]
		static MissionCurrencyReward()
		{
			Func<MissionCurrencyReward> func = default(Func<MissionCurrencyReward>);
			_parser = (MessageParser<MissionCurrencyReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
