using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008B3")]
	public sealed class CriticalSuccessData : IMessage<CriticalSuccessData>, IMessage, IEquatable<CriticalSuccessData>, IDeepCloneable<CriticalSuccessData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20008B4")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20008B5")]
			public sealed class ActivityData : IMessage<ActivityData>, IMessage, IEquatable<ActivityData>, IDeepCloneable<ActivityData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002308")]
				private static readonly MessageParser<ActivityData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002309")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400230A")]
				public const int ProbabilityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400230B")]
				private int probability_;

				[Cpp2IlInjected.Token(Token = "0x400230C")]
				public const int ProbabilityIncreasePerTryFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400230D")]
				private int probabilityIncreasePerTry_;

				[Cpp2IlInjected.Token(Token = "0x400230E")]
				public const int MinigameDataFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400230F")]
				private ItemCollectMinigameData minigameData_;

				[Cpp2IlInjected.Token(Token = "0x17000C72")]
				[DebuggerNonUserCode]
				public static MessageParser<ActivityData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004A3D")]
					[Cpp2IlInjected.Address(RVA = "0x2641360", Offset = "0x263FD60", VA = "0x182641360")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C73")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004A3E")]
					[Cpp2IlInjected.Address(RVA = "0x26412E0", Offset = "0x263FCE0", VA = "0x1826412E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C74")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004A3F")]
					[Cpp2IlInjected.Address(RVA = "0x26413C0", Offset = "0x263FDC0", VA = "0x1826413C0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C75")]
				[DebuggerNonUserCode]
				public int Probability
				{
					[Cpp2IlInjected.Token(Token = "0x6004A44")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004A45")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C76")]
				[DebuggerNonUserCode]
				public int ProbabilityIncreasePerTry
				{
					[Cpp2IlInjected.Token(Token = "0x6004A46")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004A47")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C77")]
				[DebuggerNonUserCode]
				public ItemCollectMinigameData MinigameData
				{
					[Cpp2IlInjected.Token(Token = "0x6004A48")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004A49")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004A40")]
				[Cpp2IlInjected.Address(RVA = "0x2641270", Offset = "0x263FC70", VA = "0x182641270")]
				[DebuggerNonUserCode]
				public ActivityData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A41")]
				[Cpp2IlInjected.Address(RVA = "0x2640EA0", Offset = "0x263F8A0", VA = "0x182640EA0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A42")]
				[Cpp2IlInjected.Address(RVA = "0x2641190", Offset = "0x263FB90", VA = "0x182641190")]
				[DebuggerNonUserCode]
				public ActivityData(ActivityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A43")]
				[Cpp2IlInjected.Address(RVA = "0x2640A20", Offset = "0x263F420", VA = "0x182640A20", Slot = "10")]
				[DebuggerNonUserCode]
				public ActivityData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004A4A")]
				[Cpp2IlInjected.Address(RVA = "0x2640B20", Offset = "0x263F520", VA = "0x182640B20", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004A4B")]
				[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ActivityData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004A4C")]
				[Cpp2IlInjected.Address(RVA = "0x18C2EE0", Offset = "0x18C18E0", VA = "0x1818C2EE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004A4D")]
				[Cpp2IlInjected.Address(RVA = "0x2641020", Offset = "0x263FA20", VA = "0x182641020", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004A4E")]
				[Cpp2IlInjected.Address(RVA = "0x1F16E70", Offset = "0x1F15870", VA = "0x181F16E70", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A4F")]
				[Cpp2IlInjected.Address(RVA = "0x2640920", Offset = "0x263F320", VA = "0x182640920", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004A50")]
				[Cpp2IlInjected.Address(RVA = "0x2640CB0", Offset = "0x263F6B0", VA = "0x182640CB0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ActivityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A51")]
				[Cpp2IlInjected.Address(RVA = "0x2640D90", Offset = "0x263F790", VA = "0x182640D90", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A52")]
				[Cpp2IlInjected.Address(RVA = "0x2640BE0", Offset = "0x263F5E0", VA = "0x182640BE0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004A53")]
				[Cpp2IlInjected.Address(RVA = "0x2640F00", Offset = "0x263F900", VA = "0x182640F00", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004A54")]
				[Cpp2IlInjected.Address(RVA = "0x1F16580", Offset = "0x1F14F80", VA = "0x181F16580", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40022FC")]
		private static readonly MessageParser<CriticalSuccessData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40022FD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40022FE")]
		public const int HarvestVegetableFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40022FF")]
		private Types.ActivityData harvestVegetable_;

		[Cpp2IlInjected.Token(Token = "0x4002300")]
		public const int HarvestFruitFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002301")]
		private Types.ActivityData harvestFruit_;

		[Cpp2IlInjected.Token(Token = "0x4002302")]
		public const int FishingFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002303")]
		private Types.ActivityData fishing_;

		[Cpp2IlInjected.Token(Token = "0x4002304")]
		public const int MiningFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002305")]
		private Types.ActivityData mining_;

		[Cpp2IlInjected.Token(Token = "0x4002306")]
		public const int CooldownDurationFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002307")]
		private Duration cooldownDuration_;

		[Cpp2IlInjected.Token(Token = "0x17000C6A")]
		[DebuggerNonUserCode]
		public static MessageParser<CriticalSuccessData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004A20")]
			[Cpp2IlInjected.Address(RVA = "0x18C0BF0", Offset = "0x18BF5F0", VA = "0x1818C0BF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A21")]
			[Cpp2IlInjected.Address(RVA = "0x18C0B20", Offset = "0x18BF520", VA = "0x1818C0B20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A22")]
			[Cpp2IlInjected.Address(RVA = "0x18C0C50", Offset = "0x18BF650", VA = "0x1818C0C50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6D")]
		[DebuggerNonUserCode]
		public Types.ActivityData HarvestVegetable
		{
			[Cpp2IlInjected.Token(Token = "0x6004A27")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return harvestVegetable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A28")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				harvestVegetable_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6E")]
		[DebuggerNonUserCode]
		public Types.ActivityData HarvestFruit
		{
			[Cpp2IlInjected.Token(Token = "0x6004A29")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return harvestFruit_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				harvestFruit_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C6F")]
		[DebuggerNonUserCode]
		public Types.ActivityData Fishing
		{
			[Cpp2IlInjected.Token(Token = "0x6004A2B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return fishing_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A2C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				fishing_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C70")]
		[DebuggerNonUserCode]
		public Types.ActivityData Mining
		{
			[Cpp2IlInjected.Token(Token = "0x6004A2D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return mining_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A2E")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				mining_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C71")]
		[DebuggerNonUserCode]
		public Duration CooldownDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6004A2F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return cooldownDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A30")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				cooldownDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A23")]
		[Cpp2IlInjected.Address(RVA = "0x18C0A40", Offset = "0x18BF440", VA = "0x1818C0A40")]
		[DebuggerNonUserCode]
		public CriticalSuccessData()
		{
			Types.ActivityData activityData = (harvestVegetable_ = new Types.ActivityData());
			Types.ActivityData activityData2 = (harvestFruit_ = new Types.ActivityData());
			Types.ActivityData activityData3 = (fishing_ = new Types.ActivityData());
			Types.ActivityData activityData4 = (mining_ = new Types.ActivityData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A24")]
		[Cpp2IlInjected.Address(RVA = "0x18C0370", Offset = "0x18BED70", VA = "0x1818C0370")]
		private void OnConstruction()
		{
			Types.ActivityData activityData = (harvestVegetable_ = new Types.ActivityData());
			Types.ActivityData activityData2 = (harvestFruit_ = new Types.ActivityData());
			Types.ActivityData activityData3 = (fishing_ = new Types.ActivityData());
			Types.ActivityData activityData4 = (mining_ = new Types.ActivityData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A25")]
		[Cpp2IlInjected.Address(RVA = "0x18C0850", Offset = "0x18BF250", VA = "0x1818C0850")]
		[DebuggerNonUserCode]
		public CriticalSuccessData(CriticalSuccessData other)
		{
			//IL_005b: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			Types.ActivityData activityData = (harvestVegetable_ = new Types.ActivityData());
			Types.ActivityData activityData2 = (harvestFruit_ = new Types.ActivityData());
			Types.ActivityData activityData3 = (fishing_ = new Types.ActivityData());
			Types.ActivityData activityData4 = (mining_ = new Types.ActivityData());
			Types.ActivityData activityData5 = other.harvestVegetable_;
			int num = 0;
			if (activityData5 != null)
			{
				Types.ActivityData activityData6 = activityData5.Clone();
			}
			harvestVegetable_ = (Types.ActivityData)num;
			Types.ActivityData activityData7 = other.harvestFruit_;
			if (activityData7 != null)
			{
				Types.ActivityData activityData8 = activityData7.Clone();
			}
			harvestFruit_ = (Types.ActivityData)num;
			Types.ActivityData activityData9 = other.fishing_;
			if (activityData9 != null)
			{
				Types.ActivityData activityData10 = activityData9.Clone();
			}
			fishing_ = (Types.ActivityData)num;
			Types.ActivityData activityData11 = other.mining_;
			if (activityData11 != null)
			{
				Types.ActivityData activityData12 = activityData11.Clone();
			}
			mining_ = (Types.ActivityData)num;
			Duration duration = other.cooldownDuration_;
			Duration duration2 = default(Duration);
			if (duration != null)
			{
				duration2 = duration.Clone();
			}
			cooldownDuration_ = duration2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A26")]
		[Cpp2IlInjected.Address(RVA = "0x18BFB40", Offset = "0x18BE540", VA = "0x1818BFB40", Slot = "10")]
		[DebuggerNonUserCode]
		public CriticalSuccessData Clone()
		{
			return new CriticalSuccessData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A31")]
		[Cpp2IlInjected.Address(RVA = "0x18BFC60", Offset = "0x18BE660", VA = "0x1818BFC60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(harvestVegetable_, other) && object.Equals(harvestFruit_, other) && object.Equals(fishing_, other) && object.Equals(mining_, other) && object.Equals(cooldownDuration_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A32")]
		[Cpp2IlInjected.Address(RVA = "0x18BFBA0", Offset = "0x18BE5A0", VA = "0x1818BFBA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CriticalSuccessData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.ActivityData objB = other.harvestVegetable_;
				if (object.Equals(harvestVegetable_, objB))
				{
					Types.ActivityData objB2 = other.harvestFruit_;
					if (object.Equals(harvestFruit_, objB2))
					{
						Types.ActivityData objB3 = other.fishing_;
						if (object.Equals(fishing_, objB3))
						{
							Types.ActivityData objB4 = other.mining_;
							if (object.Equals(mining_, objB4))
							{
								Duration objB5 = other.cooldownDuration_;
								if (object.Equals(cooldownDuration_, objB5))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A33")]
		[Cpp2IlInjected.Address(RVA = "0x18BFE50", Offset = "0x18BE850", VA = "0x1818BFE50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Types.ActivityData activityData = harvestVegetable_;
				if (activityData != null)
				{
					int hashCode = activityData.GetHashCode();
				}
				Types.ActivityData activityData2 = harvestFruit_;
				if (activityData2 != null)
				{
					int hashCode2 = activityData2.GetHashCode();
				}
				Types.ActivityData activityData3 = fishing_;
				if (activityData3 != null)
				{
					int hashCode3 = activityData3.GetHashCode();
				}
				Types.ActivityData activityData4 = mining_;
				if (activityData4 != null)
				{
					int hashCode4 = activityData4.GetHashCode();
				}
				Duration duration = cooldownDuration_;
				if (duration != null)
				{
					int hashCode5 = duration.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A34")]
		[Cpp2IlInjected.Address(RVA = "0x18C05D0", Offset = "0x18BEFD0", VA = "0x1818C05D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A35")]
		[Cpp2IlInjected.Address(RVA = "0x18C0630", Offset = "0x18BF030", VA = "0x1818C0630", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0095
			if ((long)harvestVegetable_ != 0)
			{
				Types.ActivityData value = harvestVegetable_;
				output.WriteMessage(value);
			}
			if ((long)harvestFruit_ != 0)
			{
				Types.ActivityData value2 = harvestFruit_;
				output.WriteMessage(value2);
			}
			if ((long)fishing_ != 0)
			{
				Types.ActivityData value3 = fishing_;
				output.WriteMessage(value3);
			}
			if ((long)mining_ != 0)
			{
				Types.ActivityData value4 = mining_;
				output.WriteMessage(value4);
			}
			if ((long)cooldownDuration_ != 0)
			{
				Duration value5 = cooldownDuration_;
				output.WriteMessage(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A36")]
		[Cpp2IlInjected.Address(RVA = "0x18BF930", Offset = "0x18BE330", VA = "0x1818BF930", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.ActivityData activityData = harvestVegetable_;
				num = 0;
				if (activityData != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(activityData);
				}
				Types.ActivityData activityData2 = harvestFruit_;
				if (activityData2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(activityData2);
					num3++;
					num += num3;
				}
				Types.ActivityData activityData3 = fishing_;
				if (activityData3 != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(activityData3);
					num4++;
					num += num4;
				}
				Types.ActivityData activityData4 = mining_;
				if (activityData4 != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(activityData4);
					num5++;
					num += num5;
				}
				Duration duration = cooldownDuration_;
				if (duration != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(duration);
					num6++;
					num += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A37")]
		[Cpp2IlInjected.Address(RVA = "0x18BFF20", Offset = "0x18BE920", VA = "0x1818BFF20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CriticalSuccessData other)
		{
			//Discarded unreachable code: IL_014f
			if (other == null)
			{
				return;
			}
			if ((long)other.harvestVegetable_ != 0)
			{
				Types.ActivityData activityData = harvestVegetable_;
				if (activityData == null)
				{
					Types.ActivityData activityData2 = (harvestVegetable_ = new Types.ActivityData());
					Types.ActivityData activityData3 = harvestVegetable_;
				}
				Types.ActivityData other2 = other.harvestVegetable_;
				activityData.MergeFrom(other2);
			}
			if ((long)other.harvestFruit_ != 0)
			{
				Types.ActivityData activityData5 = default(Types.ActivityData);
				if (harvestFruit_ == null)
				{
					Types.ActivityData activityData4 = (harvestFruit_ = new Types.ActivityData());
					activityData5 = harvestFruit_;
				}
				Types.ActivityData other3 = other.harvestFruit_;
				activityData5.MergeFrom(other3);
			}
			if ((long)other.fishing_ != 0)
			{
				Types.ActivityData activityData7 = default(Types.ActivityData);
				if (fishing_ == null)
				{
					Types.ActivityData activityData6 = (fishing_ = new Types.ActivityData());
					activityData7 = fishing_;
				}
				Types.ActivityData other4 = other.fishing_;
				activityData7.MergeFrom(other4);
			}
			if ((long)other.mining_ != 0)
			{
				Types.ActivityData activityData9 = default(Types.ActivityData);
				if (mining_ == null)
				{
					Types.ActivityData activityData8 = (mining_ = new Types.ActivityData());
					activityData9 = mining_;
				}
				Types.ActivityData other5 = other.mining_;
				activityData9.MergeFrom(other5);
			}
			if ((long)other.cooldownDuration_ != 0)
			{
				Duration duration2 = default(Duration);
				if (cooldownDuration_ == null)
				{
					Duration duration = (cooldownDuration_ = new Duration());
					duration2 = cooldownDuration_;
				}
				Duration other6 = other.cooldownDuration_;
				duration2.MergeFrom(other6);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004A38")]
		[Cpp2IlInjected.Address(RVA = "0x18C0140", Offset = "0x18BEB40", VA = "0x1818C0140", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0110
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					Types.ActivityData activityData = fishing_;
					if (activityData == null)
					{
						Types.ActivityData activityData2 = (fishing_ = new Types.ActivityData());
					}
					input.ReadMessage(activityData);
				}
				Types.ActivityData activityData3 = default(Types.ActivityData);
				if (num == 34)
				{
					Types.ActivityData builder = default(Types.ActivityData);
					if (mining_ == null)
					{
						activityData3 = (mining_ = new Types.ActivityData());
						builder = mining_;
					}
					input.ReadMessage(builder);
				}
				if ((long)activityData3 != 50)
				{
					goto IL_00f9;
				}
				Duration builder2 = default(Duration);
				if (cooldownDuration_ == null)
				{
					Duration duration = (cooldownDuration_ = new Duration());
					builder2 = cooldownDuration_;
				}
				input.ReadMessage(builder2);
			}
			Types.ActivityData activityData4 = default(Types.ActivityData);
			if (num == 10)
			{
				Types.ActivityData builder3 = default(Types.ActivityData);
				if (harvestVegetable_ == null)
				{
					activityData4 = (harvestVegetable_ = new Types.ActivityData());
					builder3 = harvestVegetable_;
				}
				input.ReadMessage(builder3);
			}
			if ((long)activityData4 == 18)
			{
				Types.ActivityData builder4 = default(Types.ActivityData);
				if (harvestFruit_ == null)
				{
					Types.ActivityData activityData5 = (harvestFruit_ = new Types.ActivityData());
					builder4 = harvestFruit_;
				}
				input.ReadMessage(builder4);
			}
			goto IL_00f9;
			IL_00f9:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004A39")]
		[Cpp2IlInjected.Address(RVA = "0x18BFD70", Offset = "0x18BE770", VA = "0x1818BFD70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 5)
			{
				Types.ActivityData activityData = harvestVegetable_;
				Types.ActivityData activityData2 = harvestFruit_;
				Types.ActivityData activityData3 = fishing_;
				Types.ActivityData activityData4 = mining_;
				Duration duration = cooldownDuration_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A3A")]
		[Cpp2IlInjected.Address(RVA = "0x18C0450", Offset = "0x18BEE50", VA = "0x1818C0450", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0024, IL_002a, IL_0030
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				harvestVegetable_ = (Types.ActivityData)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A3B")]
		[Cpp2IlInjected.Address(RVA = "0x18BFAA0", Offset = "0x18BE4A0", VA = "0x1818BFAA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber > 5)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A3C")]
		[Cpp2IlInjected.Address(RVA = "0x18C0740", Offset = "0x18BF140", VA = "0x1818C0740")]
		static CriticalSuccessData()
		{
			Func<CriticalSuccessData> func = default(Func<CriticalSuccessData>);
			_parser = (MessageParser<CriticalSuccessData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
