using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x200089E")]
	public sealed class GardeningData : IActivityLockCondition, IMessage<GardeningData>, IMessage, IEquatable<GardeningData>, IDeepCloneable<GardeningData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002A58")]
		private static readonly MessageParser<GardeningData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A59")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A5A")]
		public const int MinimumWateredDurationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A5B")]
		private Duration minimumWateredDuration_;

		[Cpp2IlInjected.Token(Token = "0x4002A5C")]
		public const int DryingDurationFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A5D")]
		private Duration dryingDuration_;

		[Cpp2IlInjected.Token(Token = "0x4002A5E")]
		public const int RightAreaGrowthPeriodReductionPercentageFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A5F")]
		private int rightAreaGrowthPeriodReductionPercentage_;

		[Cpp2IlInjected.Token(Token = "0x4002A60")]
		public const int EmptyGardeningSlotExpirationFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002A61")]
		private Duration emptyGardeningSlotExpiration_;

		[Cpp2IlInjected.Token(Token = "0x4002A62")]
		public const int UnlockBuildingItemIDFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002A63")]
		private int unlockBuildingItemID_;

		[Cpp2IlInjected.Token(Token = "0x17001827")]
		public Item UnlockBuildingItem
		{
			[Cpp2IlInjected.Token(Token = "0x600603D")]
			[Cpp2IlInjected.Address(RVA = "0x2194190", Offset = "0x2192B90", VA = "0x182194190", Slot = "4")]
			get
			{
				long num = Convert.ToInt64((uint)unlockBuildingItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001828")]
		[DebuggerNonUserCode]
		public static MessageParser<GardeningData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600603E")]
			[Cpp2IlInjected.Address(RVA = "0x2194130", Offset = "0x2192B30", VA = "0x182194130")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001829")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600603F")]
			[Cpp2IlInjected.Address(RVA = "0x2194060", Offset = "0x2192A60", VA = "0x182194060")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006040")]
			[Cpp2IlInjected.Address(RVA = "0x21941F0", Offset = "0x2192BF0", VA = "0x1821941F0", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182B")]
		[DebuggerNonUserCode]
		public Duration MinimumWateredDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6006044")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return minimumWateredDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006045")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				minimumWateredDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182C")]
		[DebuggerNonUserCode]
		public Duration DryingDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6006046")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return dryingDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006047")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				dryingDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182D")]
		[DebuggerNonUserCode]
		public int RightAreaGrowthPeriodReductionPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6006048")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return rightAreaGrowthPeriodReductionPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006049")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				rightAreaGrowthPeriodReductionPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182E")]
		[DebuggerNonUserCode]
		public Duration EmptyGardeningSlotExpiration
		{
			[Cpp2IlInjected.Token(Token = "0x600604A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return emptyGardeningSlotExpiration_;
			}
			[Cpp2IlInjected.Token(Token = "0x600604B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				emptyGardeningSlotExpiration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182F")]
		[DebuggerNonUserCode]
		public int UnlockBuildingItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600604C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return unlockBuildingItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600604D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				unlockBuildingItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006041")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GardeningData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6006042")]
		[Cpp2IlInjected.Address(RVA = "0x2193F80", Offset = "0x2192980", VA = "0x182193F80")]
		[DebuggerNonUserCode]
		public GardeningData(GardeningData other)
		{
			//IL_0021: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			Duration duration = other.minimumWateredDuration_;
			int num = 0;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			minimumWateredDuration_ = (Duration)num;
			Duration duration3 = other.dryingDuration_;
			if (duration3 != null)
			{
				Duration duration4 = duration3.Clone();
			}
			dryingDuration_ = (Duration)num;
			int num2 = (rightAreaGrowthPeriodReductionPercentage_ = other.rightAreaGrowthPeriodReductionPercentage_);
			Duration duration5 = other.emptyGardeningSlotExpiration_;
			Duration duration6 = default(Duration);
			if (duration5 != null)
			{
				duration6 = duration5.Clone();
			}
			emptyGardeningSlotExpiration_ = duration6;
			int num3 = (unlockBuildingItemID_ = other.unlockBuildingItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006043")]
		[Cpp2IlInjected.Address(RVA = "0x21933B0", Offset = "0x2191DB0", VA = "0x1821933B0", Slot = "11")]
		[DebuggerNonUserCode]
		public GardeningData Clone()
		{
			//Discarded unreachable code: IL_0093
			//IL_0021: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			GardeningData gardeningData = new GardeningData();
			Duration duration = minimumWateredDuration_;
			int num = 0;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			gardeningData.minimumWateredDuration_ = (Duration)num;
			Duration duration3 = dryingDuration_;
			if (duration3 != null)
			{
				Duration duration4 = duration3.Clone();
			}
			gardeningData.dryingDuration_ = (Duration)num;
			int num2 = (gardeningData.rightAreaGrowthPeriodReductionPercentage_ = rightAreaGrowthPeriodReductionPercentage_);
			Duration duration5 = emptyGardeningSlotExpiration_;
			Duration duration6 = default(Duration);
			if (duration5 != null)
			{
				duration6 = duration5.Clone();
			}
			gardeningData.emptyGardeningSlotExpiration_ = duration6;
			int num3 = (gardeningData.unlockBuildingItemID_ = unlockBuildingItemID_);
			UnknownFieldSet unknownFieldSet = (gardeningData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gardeningData;
		}

		[Cpp2IlInjected.Token(Token = "0x600604E")]
		[Cpp2IlInjected.Address(RVA = "0x21934C0", Offset = "0x2191EC0", VA = "0x1821934C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(minimumWateredDuration_, other))
				{
					bool flag = object.Equals(dryingDuration_, other);
					if (flag && rightAreaGrowthPeriodReductionPercentage_ == (flag ? 1 : 0))
					{
						bool flag2 = object.Equals(emptyGardeningSlotExpiration_, other);
						if (flag2 && unlockBuildingItemID_ == (flag2 ? 1 : 0))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600604F")]
		[Cpp2IlInjected.Address(RVA = "0x21935B0", Offset = "0x2191FB0", VA = "0x1821935B0", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(GardeningData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Duration objB = other.minimumWateredDuration_;
				if (object.Equals(minimumWateredDuration_, objB))
				{
					Duration objB2 = other.dryingDuration_;
					if (object.Equals(dryingDuration_, objB2))
					{
						int num = other.rightAreaGrowthPeriodReductionPercentage_;
						if (rightAreaGrowthPeriodReductionPercentage_ == num)
						{
							Duration objB3 = other.emptyGardeningSlotExpiration_;
							if (object.Equals(emptyGardeningSlotExpiration_, objB3))
							{
								int num2 = other.unlockBuildingItemID_;
								if (unlockBuildingItemID_ == num2)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006050")]
		[Cpp2IlInjected.Address(RVA = "0x2193750", Offset = "0x2192150", VA = "0x182193750", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Duration duration = minimumWateredDuration_;
				if (duration != null)
				{
					int hashCode = duration.GetHashCode();
				}
				Duration duration2 = dryingDuration_;
				if (duration2 != null)
				{
					int hashCode2 = duration2.GetHashCode();
				}
				if (rightAreaGrowthPeriodReductionPercentage_ != 0)
				{
				}
				Duration duration3 = emptyGardeningSlotExpiration_;
				if (duration3 != null)
				{
					int hashCode3 = duration3.GetHashCode();
				}
				if (unlockBuildingItemID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6006051")]
		[Cpp2IlInjected.Address(RVA = "0x2193D00", Offset = "0x2192700", VA = "0x182193D00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006052")]
		[Cpp2IlInjected.Address(RVA = "0x2193D60", Offset = "0x2192760", VA = "0x182193D60", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0091
			if ((long)minimumWateredDuration_ != 0)
			{
				Duration value = minimumWateredDuration_;
				output.WriteMessage(value);
			}
			if ((long)dryingDuration_ != 0)
			{
				Duration value2 = dryingDuration_;
				output.WriteMessage(value2);
			}
			if (rightAreaGrowthPeriodReductionPercentage_ != 0)
			{
				int value3 = rightAreaGrowthPeriodReductionPercentage_;
				output.WriteInt32(value3);
			}
			if ((long)emptyGardeningSlotExpiration_ != 0)
			{
				Duration value4 = emptyGardeningSlotExpiration_;
				output.WriteMessage(value4);
			}
			if (unlockBuildingItemID_ != 0)
			{
				int value5 = unlockBuildingItemID_;
				output.WriteInt32(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006053")]
		[Cpp2IlInjected.Address(RVA = "0x21931E0", Offset = "0x2191BE0", VA = "0x1821931E0", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Duration duration = minimumWateredDuration_;
				num = 0;
				if (duration != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(duration);
				}
				Duration duration2 = dryingDuration_;
				if (duration2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(duration2);
					num3++;
					num += num3;
				}
				int num4 = rightAreaGrowthPeriodReductionPercentage_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num += num5;
				}
				Duration duration3 = emptyGardeningSlotExpiration_;
				if (duration3 != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(duration3);
					num6++;
					num += num6;
				}
				int num7 = unlockBuildingItemID_;
				if (num7 != 0)
				{
					int num8 = CodedOutputStream.ComputeInt32Size(num7);
					num8++;
					num += num8;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num9 = unknownFields.CalculateSize();
			return num9 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006054")]
		[Cpp2IlInjected.Address(RVA = "0x2193830", Offset = "0x2192230", VA = "0x182193830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(GardeningData other)
		{
			//Discarded unreachable code: IL_0101
			if (other == null)
			{
				return;
			}
			if ((long)other.minimumWateredDuration_ != 0)
			{
				Duration duration = minimumWateredDuration_;
				if (duration == null)
				{
					Duration duration2 = (minimumWateredDuration_ = new Duration());
					Duration duration3 = minimumWateredDuration_;
				}
				Duration other2 = other.minimumWateredDuration_;
				duration.MergeFrom(other2);
			}
			if ((long)other.dryingDuration_ != 0)
			{
				Duration duration5 = default(Duration);
				if (dryingDuration_ == null)
				{
					Duration duration4 = (dryingDuration_ = new Duration());
					duration5 = dryingDuration_;
				}
				Duration other3 = other.dryingDuration_;
				duration5.MergeFrom(other3);
			}
			int num = other.rightAreaGrowthPeriodReductionPercentage_;
			if (num != 0)
			{
				rightAreaGrowthPeriodReductionPercentage_ = num;
			}
			if ((long)other.emptyGardeningSlotExpiration_ != 0)
			{
				Duration duration7 = default(Duration);
				if (emptyGardeningSlotExpiration_ == null)
				{
					Duration duration6 = (emptyGardeningSlotExpiration_ = new Duration());
					duration7 = emptyGardeningSlotExpiration_;
				}
				Duration other4 = other.emptyGardeningSlotExpiration_;
				duration7.MergeFrom(other4);
			}
			int num2 = other.unlockBuildingItemID_;
			if (num2 != 0)
			{
				unlockBuildingItemID_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6006055")]
		[Cpp2IlInjected.Address(RVA = "0x21939B0", Offset = "0x21923B0", VA = "0x1821939B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00df
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					int num2 = (rightAreaGrowthPeriodReductionPercentage_ = input.ReadInt32());
				}
				Duration duration = default(Duration);
				if (num == 34)
				{
					Duration builder = default(Duration);
					if (emptyGardeningSlotExpiration_ == null)
					{
						duration = (emptyGardeningSlotExpiration_ = new Duration());
						builder = emptyGardeningSlotExpiration_;
					}
					input.ReadMessage(builder);
				}
				if ((long)duration != 40)
				{
					goto IL_00c8;
				}
				int num3 = (unlockBuildingItemID_ = input.ReadInt32());
			}
			Duration duration2 = default(Duration);
			if (num == 10)
			{
				Duration builder2 = default(Duration);
				if (minimumWateredDuration_ == null)
				{
					duration2 = (minimumWateredDuration_ = new Duration());
					builder2 = minimumWateredDuration_;
				}
				input.ReadMessage(builder2);
			}
			if ((long)duration2 == 18)
			{
				Duration builder3 = default(Duration);
				if (dryingDuration_ == null)
				{
					Duration duration3 = (dryingDuration_ = new Duration());
					builder3 = dryingDuration_;
				}
				input.ReadMessage(builder3);
			}
			goto IL_00c8;
			IL_00c8:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006056")]
		[Cpp2IlInjected.Address(RVA = "0x2193650", Offset = "0x2192050", VA = "0x182193650", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0 && num != 1)
						{
							goto IL_0035;
						}
						Duration duration = emptyGardeningSlotExpiration_;
					}
					int num2 = rightAreaGrowthPeriodReductionPercentage_;
				}
				Duration duration2 = dryingDuration_;
			}
			Duration duration3 = minimumWateredDuration_;
			goto IL_0035;
			IL_0035:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006057")]
		[Cpp2IlInjected.Address(RVA = "0x2193B60", Offset = "0x2192560", VA = "0x182193B60", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001f: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			//IL_0039: Expected I4, but got O
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
							object obj = default(object);
							unlockBuildingItemID_ = (int)obj;
							break;
						}
						case 0:
						{
							int num2 = 0;
							if (value == null || value != null)
							{
								emptyGardeningSlotExpiration_ = (Duration)num2;
								break;
							}
							throw new InvalidCastException();
						}
						}
					}
					else
					{
						object obj2 = default(object);
						rightAreaGrowthPeriodReductionPercentage_ = (int)obj2;
					}
					return;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006058")]
		[Cpp2IlInjected.Address(RVA = "0x2193350", Offset = "0x2191D50", VA = "0x182193350", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				unlockBuildingItemID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006059")]
		[Cpp2IlInjected.Address(RVA = "0x2193E70", Offset = "0x2192870", VA = "0x182193E70")]
		static GardeningData()
		{
			Func<GardeningData> func = default(Func<GardeningData>);
			_parser = (MessageParser<GardeningData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
