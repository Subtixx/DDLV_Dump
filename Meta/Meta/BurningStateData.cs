using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008A5")]
	public sealed class BurningStateData : IMessage<BurningStateData>, IMessage, IEquatable<BurningStateData>, IDeepCloneable<BurningStateData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20008A6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20008A7")]
			public sealed class ActivityData : IMessage<ActivityData>, IMessage, IEquatable<ActivityData>, IDeepCloneable<ActivityData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40022D2")]
				private static readonly MessageParser<ActivityData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40022D3")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40022D4")]
				public const int ProbabilityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40022D5")]
				private int probability_;

				[Cpp2IlInjected.Token(Token = "0x40022D6")]
				public const int DurationFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40022D7")]
				private Duration duration_;

				[Cpp2IlInjected.Token(Token = "0x40022D8")]
				public const int CollectIntervalFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40022D9")]
				private Duration collectInterval_;

				[Cpp2IlInjected.Token(Token = "0x17000C58")]
				[DebuggerNonUserCode]
				public static MessageParser<ActivityData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60049B6")]
					[Cpp2IlInjected.Address(RVA = "0x27213C0", Offset = "0x271FDC0", VA = "0x1827213C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C59")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60049B7")]
					[Cpp2IlInjected.Address(RVA = "0x2721340", Offset = "0x271FD40", VA = "0x182721340")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60049B8")]
					[Cpp2IlInjected.Address(RVA = "0x2721420", Offset = "0x271FE20", VA = "0x182721420", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5B")]
				[DebuggerNonUserCode]
				public int Probability
				{
					[Cpp2IlInjected.Token(Token = "0x60049BD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60049BE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5C")]
				[DebuggerNonUserCode]
				public Duration Duration
				{
					[Cpp2IlInjected.Token(Token = "0x60049BF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60049C0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5D")]
				[DebuggerNonUserCode]
				public Duration CollectInterval
				{
					[Cpp2IlInjected.Token(Token = "0x60049C1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60049C2")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60049B9")]
				[Cpp2IlInjected.Address(RVA = "0x27212B0", Offset = "0x271FCB0", VA = "0x1827212B0")]
				[DebuggerNonUserCode]
				public ActivityData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049BA")]
				[Cpp2IlInjected.Address(RVA = "0x2720E80", Offset = "0x271F880", VA = "0x182720E80")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049BB")]
				[Cpp2IlInjected.Address(RVA = "0x2721180", Offset = "0x271FB80", VA = "0x182721180")]
				[DebuggerNonUserCode]
				public ActivityData(ActivityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049BC")]
				[Cpp2IlInjected.Address(RVA = "0x2720900", Offset = "0x271F300", VA = "0x182720900", Slot = "10")]
				[DebuggerNonUserCode]
				public ActivityData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60049C3")]
				[Cpp2IlInjected.Address(RVA = "0x2720A60", Offset = "0x271F460", VA = "0x182720A60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60049C4")]
				[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ActivityData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60049C5")]
				[Cpp2IlInjected.Address(RVA = "0x7AFC70", Offset = "0x7AE670", VA = "0x1807AFC70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60049C6")]
				[Cpp2IlInjected.Address(RVA = "0x2721010", Offset = "0x271FA10", VA = "0x182721010", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60049C7")]
				[Cpp2IlInjected.Address(RVA = "0x7B03B0", Offset = "0x7AEDB0", VA = "0x1807B03B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049C8")]
				[Cpp2IlInjected.Address(RVA = "0x2720800", Offset = "0x271F200", VA = "0x182720800", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60049C9")]
				[Cpp2IlInjected.Address(RVA = "0x2720D50", Offset = "0x271F750", VA = "0x182720D50", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ActivityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049CA")]
				[Cpp2IlInjected.Address(RVA = "0x2720C10", Offset = "0x271F610", VA = "0x182720C10", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049CB")]
				[Cpp2IlInjected.Address(RVA = "0x2720B30", Offset = "0x271F530", VA = "0x182720B30", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60049CC")]
				[Cpp2IlInjected.Address(RVA = "0x2720F10", Offset = "0x271F910", VA = "0x182720F10", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60049CD")]
				[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40022CA")]
		private static readonly MessageParser<BurningStateData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40022CB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40022CC")]
		public const int GardeningVegetableFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40022CD")]
		private Types.ActivityData gardeningVegetable_;

		[Cpp2IlInjected.Token(Token = "0x40022CE")]
		public const int GardeningFruitFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40022CF")]
		private Types.ActivityData gardeningFruit_;

		[Cpp2IlInjected.Token(Token = "0x40022D0")]
		public const int GracePeriodFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40022D1")]
		private Duration gracePeriod_;

		[Cpp2IlInjected.Token(Token = "0x17000C52")]
		[DebuggerNonUserCode]
		public static MessageParser<BurningStateData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600499D")]
			[Cpp2IlInjected.Address(RVA = "0x713E60", Offset = "0x712860", VA = "0x180713E60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C53")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600499E")]
			[Cpp2IlInjected.Address(RVA = "0x713D90", Offset = "0x712790", VA = "0x180713D90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C54")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600499F")]
			[Cpp2IlInjected.Address(RVA = "0x713EC0", Offset = "0x7128C0", VA = "0x180713EC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C55")]
		[DebuggerNonUserCode]
		public Types.ActivityData GardeningVegetable
		{
			[Cpp2IlInjected.Token(Token = "0x60049A4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gardeningVegetable_;
			}
			[Cpp2IlInjected.Token(Token = "0x60049A5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				gardeningVegetable_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C56")]
		[DebuggerNonUserCode]
		public Types.ActivityData GardeningFruit
		{
			[Cpp2IlInjected.Token(Token = "0x60049A6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return gardeningFruit_;
			}
			[Cpp2IlInjected.Token(Token = "0x60049A7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				gardeningFruit_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C57")]
		[DebuggerNonUserCode]
		public Duration GracePeriod
		{
			[Cpp2IlInjected.Token(Token = "0x60049A8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return gracePeriod_;
			}
			[Cpp2IlInjected.Token(Token = "0x60049A9")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				gracePeriod_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049A0")]
		[Cpp2IlInjected.Address(RVA = "0x713CD0", Offset = "0x7126D0", VA = "0x180713CD0")]
		[DebuggerNonUserCode]
		public BurningStateData()
		{
			Types.ActivityData activityData = (gardeningVegetable_ = new Types.ActivityData());
			Types.ActivityData activityData2 = (gardeningFruit_ = new Types.ActivityData());
			Duration duration = (gracePeriod_ = new Duration());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049A1")]
		[Cpp2IlInjected.Address(RVA = "0x713760", Offset = "0x712160", VA = "0x180713760")]
		private void OnConstruction()
		{
			Types.ActivityData activityData = (gardeningVegetable_ = new Types.ActivityData());
			Types.ActivityData activityData2 = (gardeningFruit_ = new Types.ActivityData());
			Duration duration = (gracePeriod_ = new Duration());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049A2")]
		[Cpp2IlInjected.Address(RVA = "0x713B50", Offset = "0x712550", VA = "0x180713B50")]
		[DebuggerNonUserCode]
		public BurningStateData(BurningStateData other)
		{
			//IL_004b: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			Types.ActivityData activityData = (gardeningVegetable_ = new Types.ActivityData());
			Types.ActivityData activityData2 = (gardeningFruit_ = new Types.ActivityData());
			Duration duration = (gracePeriod_ = new Duration());
			Types.ActivityData activityData3 = other.gardeningVegetable_;
			int num = 0;
			if (activityData3 != null)
			{
				Types.ActivityData activityData4 = activityData3.Clone();
			}
			gardeningVegetable_ = (Types.ActivityData)num;
			Types.ActivityData activityData5 = other.gardeningFruit_;
			if (activityData5 != null)
			{
				Types.ActivityData activityData6 = activityData5.Clone();
			}
			gardeningFruit_ = (Types.ActivityData)num;
			Duration duration2 = other.gracePeriod_;
			Duration duration3 = default(Duration);
			if (duration2 != null)
			{
				duration3 = duration2.Clone();
			}
			gracePeriod_ = duration3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60049A3")]
		[Cpp2IlInjected.Address(RVA = "0x712FF0", Offset = "0x7119F0", VA = "0x180712FF0", Slot = "10")]
		[DebuggerNonUserCode]
		public BurningStateData Clone()
		{
			//Discarded unreachable code: IL_00a1
			//IL_004e: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			BurningStateData burningStateData = new BurningStateData();
			Types.ActivityData activityData = (burningStateData.gardeningVegetable_ = new Types.ActivityData());
			Types.ActivityData activityData2 = (burningStateData.gardeningFruit_ = new Types.ActivityData());
			Duration duration = (burningStateData.gracePeriod_ = new Duration());
			Types.ActivityData activityData3 = gardeningVegetable_;
			int num = 0;
			if (activityData3 != null)
			{
				Types.ActivityData activityData4 = activityData3.Clone();
			}
			burningStateData.gardeningVegetable_ = (Types.ActivityData)num;
			Types.ActivityData activityData5 = gardeningFruit_;
			if (activityData5 != null)
			{
				Types.ActivityData activityData6 = activityData5.Clone();
			}
			burningStateData.gardeningFruit_ = (Types.ActivityData)num;
			Duration duration2 = gracePeriod_;
			Duration duration3 = default(Duration);
			if (duration2 != null)
			{
				duration3 = duration2.Clone();
			}
			burningStateData.gracePeriod_ = duration3;
			UnknownFieldSet unknownFieldSet = (burningStateData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return burningStateData;
		}

		[Cpp2IlInjected.Token(Token = "0x60049AA")]
		[Cpp2IlInjected.Address(RVA = "0x7131A0", Offset = "0x711BA0", VA = "0x1807131A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(gardeningVegetable_, other) && object.Equals(gardeningFruit_, other) && object.Equals(gracePeriod_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049AB")]
		[Cpp2IlInjected.Address(RVA = "0x713280", Offset = "0x711C80", VA = "0x180713280", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BurningStateData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.ActivityData objB = other.gardeningVegetable_;
				if (object.Equals(gardeningVegetable_, objB))
				{
					Types.ActivityData objB2 = other.gardeningFruit_;
					if (object.Equals(gardeningFruit_, objB2))
					{
						Duration objB3 = other.gracePeriod_;
						if (object.Equals(gracePeriod_, objB3))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049AC")]
		[Cpp2IlInjected.Address(RVA = "0x7133C0", Offset = "0x711DC0", VA = "0x1807133C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Types.ActivityData activityData = gardeningVegetable_;
				if (activityData != null)
				{
					int hashCode = activityData.GetHashCode();
				}
				Types.ActivityData activityData2 = gardeningFruit_;
				if (activityData2 != null)
				{
					int hashCode2 = activityData2.GetHashCode();
				}
				Duration duration = gracePeriod_;
				if (duration != null)
				{
					int hashCode3 = duration.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60049AD")]
		[Cpp2IlInjected.Address(RVA = "0x713920", Offset = "0x712320", VA = "0x180713920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60049AE")]
		[Cpp2IlInjected.Address(RVA = "0x713980", Offset = "0x712380", VA = "0x180713980", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			if ((long)gardeningVegetable_ != 0)
			{
				Types.ActivityData value = gardeningVegetable_;
				output.WriteMessage(value);
			}
			if ((long)gardeningFruit_ != 0)
			{
				Types.ActivityData value2 = gardeningFruit_;
				output.WriteMessage(value2);
			}
			if ((long)gracePeriod_ != 0)
			{
				Duration value3 = gracePeriod_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60049AF")]
		[Cpp2IlInjected.Address(RVA = "0x712E90", Offset = "0x711890", VA = "0x180712E90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.ActivityData activityData = gardeningVegetable_;
				num = 0;
				if (activityData != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(activityData);
				}
				Types.ActivityData activityData2 = gardeningFruit_;
				if (activityData2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(activityData2);
					num3++;
					num += num3;
				}
				Duration duration = gracePeriod_;
				if (duration != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(duration);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60049B0")]
		[Cpp2IlInjected.Address(RVA = "0x713460", Offset = "0x711E60", VA = "0x180713460", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BurningStateData other)
		{
			//Discarded unreachable code: IL_00d7
			if (other == null)
			{
				return;
			}
			if ((long)other.gardeningVegetable_ != 0)
			{
				Types.ActivityData activityData = gardeningVegetable_;
				if (activityData == null)
				{
					Types.ActivityData activityData2 = (gardeningVegetable_ = new Types.ActivityData());
					Types.ActivityData activityData3 = gardeningVegetable_;
				}
				Types.ActivityData other2 = other.gardeningVegetable_;
				activityData.MergeFrom(other2);
			}
			if ((long)other.gardeningFruit_ != 0)
			{
				Types.ActivityData activityData5 = default(Types.ActivityData);
				if (gardeningFruit_ == null)
				{
					Types.ActivityData activityData4 = (gardeningFruit_ = new Types.ActivityData());
					activityData5 = gardeningFruit_;
				}
				Types.ActivityData other3 = other.gardeningFruit_;
				activityData5.MergeFrom(other3);
			}
			if ((long)other.gracePeriod_ != 0)
			{
				Duration duration2 = default(Duration);
				if (gracePeriod_ == null)
				{
					Duration duration = (gracePeriod_ = new Duration());
					duration2 = gracePeriod_;
				}
				Duration other4 = other.gracePeriod_;
				duration2.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60049B1")]
		[Cpp2IlInjected.Address(RVA = "0x7135E0", Offset = "0x711FE0", VA = "0x1807135E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Types.ActivityData activityData = gardeningVegetable_;
				if (activityData == null)
				{
					Types.ActivityData activityData2 = (gardeningVegetable_ = new Types.ActivityData());
				}
				input.ReadMessage(activityData);
			}
			Types.ActivityData activityData3 = default(Types.ActivityData);
			if (num == 18)
			{
				Types.ActivityData builder = default(Types.ActivityData);
				if (gardeningFruit_ == null)
				{
					activityData3 = (gardeningFruit_ = new Types.ActivityData());
					builder = gardeningFruit_;
				}
				input.ReadMessage(builder);
			}
			if ((long)activityData3 == 42)
			{
				Duration builder2 = default(Duration);
				if (gracePeriod_ == null)
				{
					Duration duration = (gracePeriod_ = new Duration());
					builder2 = gracePeriod_;
				}
				input.ReadMessage(builder2);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60049B2")]
		[Cpp2IlInjected.Address(RVA = "0x713310", Offset = "0x711D10", VA = "0x180713310", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Duration duration = gracePeriod_;
				Types.ActivityData activityData = gardeningFruit_;
				Types.ActivityData activityData2 = gardeningVegetable_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049B3")]
		[Cpp2IlInjected.Address(RVA = "0x713820", Offset = "0x712220", VA = "0x180713820", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0029: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0 && num != 0 && num == 1)
					{
						int num2 = 0;
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						gracePeriod_ = (Duration)num2;
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

		[Cpp2IlInjected.Token(Token = "0x60049B4")]
		[Cpp2IlInjected.Address(RVA = "0x712FA0", Offset = "0x7119A0", VA = "0x180712FA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049B5")]
		[Cpp2IlInjected.Address(RVA = "0x713A40", Offset = "0x712440", VA = "0x180713A40")]
		static BurningStateData()
		{
			Func<BurningStateData> func = default(Func<BurningStateData>);
			_parser = (MessageParser<BurningStateData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
