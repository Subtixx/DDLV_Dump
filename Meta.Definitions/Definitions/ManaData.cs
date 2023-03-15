using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class ManaData : IMessage<ManaData>, IMessage, IEquatable<ManaData>, IDeepCloneable<ManaData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			public enum ManaSpendingActionType
			{
				[Cpp2IlInjected.Token(Token = "0x4000425")]
				[OriginalName("Plant")]
				Plant,
				[Cpp2IlInjected.Token(Token = "0x4000426")]
				[OriginalName("Fish")]
				Fish,
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				[OriginalName("Cook")]
				Cook,
				[Cpp2IlInjected.Token(Token = "0x4000428")]
				[OriginalName("PullWeed")]
				PullWeed,
				[Cpp2IlInjected.Token(Token = "0x4000429")]
				[OriginalName("CreateGardeningTile")]
				CreateGardeningTile,
				[Cpp2IlInjected.Token(Token = "0x400042A")]
				[OriginalName("Mine")]
				Mine,
				[Cpp2IlInjected.Token(Token = "0x400042B")]
				[OriginalName("Water")]
				Water,
				[Cpp2IlInjected.Token(Token = "0x400042C")]
				[OriginalName("UnlockBuilding")]
				UnlockBuilding,
				[Cpp2IlInjected.Token(Token = "0x400042D")]
				[OriginalName("UnlockVillageArea")]
				UnlockVillageArea,
				[Cpp2IlInjected.Token(Token = "0x400042E")]
				[OriginalName("MineBlocker")]
				MineBlocker,
				[Cpp2IlInjected.Token(Token = "0x400042F")]
				[OriginalName("WaterEmpty")]
				WaterEmpty
			}

			[Cpp2IlInjected.Token(Token = "0x20000DE")]
			public sealed class ManaSpendingAction : IMessage<ManaSpendingAction>, IMessage, IEquatable<ManaSpendingAction>, IDeepCloneable<ManaSpendingAction>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000430")]
				private static readonly MessageParser<ManaSpendingAction> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000431")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000432")]
				public const int TypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000433")]
				private ManaSpendingActionType type_;

				[Cpp2IlInjected.Token(Token = "0x4000434")]
				public const int ManaCostFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000435")]
				private int manaCost_;

				[Cpp2IlInjected.Token(Token = "0x1700024B")]
				[DebuggerNonUserCode]
				public static MessageParser<ManaSpendingAction> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000959")]
					[Cpp2IlInjected.Address(RVA = "0x2FF06B0", Offset = "0x2FEF0B0", VA = "0x182FF06B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600095A")]
					[Cpp2IlInjected.Address(RVA = "0x2FF0630", Offset = "0x2FEF030", VA = "0x182FF0630")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600095B")]
					[Cpp2IlInjected.Address(RVA = "0x2FF0710", Offset = "0x2FEF110", VA = "0x182FF0710", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024E")]
				[DebuggerNonUserCode]
				public ManaSpendingActionType Type
				{
					[Cpp2IlInjected.Token(Token = "0x600095F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(ManaSpendingActionType);
					}
					[Cpp2IlInjected.Token(Token = "0x6000960")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024F")]
				[DebuggerNonUserCode]
				public int ManaCost
				{
					[Cpp2IlInjected.Token(Token = "0x6000961")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000962")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600095C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ManaSpendingAction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600095D")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public ManaSpendingAction(ManaSpendingAction other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600095E")]
				[Cpp2IlInjected.Address(RVA = "0x2FF01E0", Offset = "0x2FEEBE0", VA = "0x182FF01E0", Slot = "10")]
				[DebuggerNonUserCode]
				public ManaSpendingAction Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000963")]
				[Cpp2IlInjected.Address(RVA = "0x2FF0270", Offset = "0x2FEEC70", VA = "0x182FF0270", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000964")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ManaSpendingAction other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000965")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000966")]
				[Cpp2IlInjected.Address(RVA = "0x2FF04C0", Offset = "0x2FEEEC0", VA = "0x182FF04C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000967")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000968")]
				[Cpp2IlInjected.Address(RVA = "0x2FF0110", Offset = "0x2FEEB10", VA = "0x182FF0110", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000969")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ManaSpendingAction other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600096A")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600096B")]
				[Cpp2IlInjected.Address(RVA = "0x2FF0300", Offset = "0x2FEED00", VA = "0x182FF0300", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600096C")]
				[Cpp2IlInjected.Address(RVA = "0x2FF03F0", Offset = "0x2FEEDF0", VA = "0x182FF03F0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600096D")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private static readonly MessageParser<ManaData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public const int SpendingActionsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private static readonly FieldCodec<Types.ManaSpendingAction> _repeated_spendingActions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private readonly RepeatedField<Types.ManaSpendingAction> spendingActions_ = (RepeatedField<Types.ManaSpendingAction>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public const int MeditationRegenTickIntervalFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private Duration meditationRegenTickInterval_;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public const int MeditationMaxRegenPercentageFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private int meditationMaxRegenPercentage_;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public const int ExceedingManaMaximumMultiplierFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private int exceedingManaMaximumMultiplier_;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public const int ExceedingManaMoveSpeedMultiplierFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private float exceedingManaMoveSpeedMultiplier_;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public const int ExhaustEffectThresholdPercentFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private int exhaustEffectThresholdPercent_;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public const int ExhaustEffectThresholdFlatFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private int exhaustEffectThresholdFlat_;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public const int ExhaustEffectDurationFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private Duration exhaustEffectDuration_;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public const int AutoFillOnLoadUnlockConditionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private ConditionsList autoFillOnLoadUnlockCondition_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private readonly Dictionary<Types.ManaSpendingActionType, int> manaCost = (Dictionary<Types.ManaSpendingActionType, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		[DebuggerNonUserCode]
		public static MessageParser<ManaData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x3065480", Offset = "0x3063E80", VA = "0x183065480")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0x30653B0", Offset = "0x3063DB0", VA = "0x1830653B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(RVA = "0x30654E0", Offset = "0x3063EE0", VA = "0x1830654E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ManaSpendingAction> SpendingActions
		{
			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return spendingActions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		[DebuggerNonUserCode]
		public Duration MeditationRegenTickInterval
		{
			[Cpp2IlInjected.Token(Token = "0x600093C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return meditationRegenTickInterval_;
			}
			[Cpp2IlInjected.Token(Token = "0x600093D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				meditationRegenTickInterval_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		[DebuggerNonUserCode]
		public int MeditationMaxRegenPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return meditationMaxRegenPercentage_;
			}
			[Cpp2IlInjected.Token(Token = "0x600093F")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				meditationMaxRegenPercentage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		[DebuggerNonUserCode]
		public int ExceedingManaMaximumMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000940")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return exceedingManaMaximumMultiplier_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				exceedingManaMaximumMultiplier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		[DebuggerNonUserCode]
		public float ExceedingManaMoveSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000942")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
			get
			{
				return exceedingManaMoveSpeedMultiplier_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0xDD7740", Offset = "0xDD6140", VA = "0x180DD7740")]
			set
			{
				exceedingManaMoveSpeedMultiplier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		[DebuggerNonUserCode]
		public int ExhaustEffectThresholdPercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return exhaustEffectThresholdPercent_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				exhaustEffectThresholdPercent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		[DebuggerNonUserCode]
		public int ExhaustEffectThresholdFlat
		{
			[Cpp2IlInjected.Token(Token = "0x6000946")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return exhaustEffectThresholdFlat_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000947")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				exhaustEffectThresholdFlat_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		[DebuggerNonUserCode]
		public Duration ExhaustEffectDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return exhaustEffectDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				exhaustEffectDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		[DebuggerNonUserCode]
		public ConditionsList AutoFillOnLoadUnlockCondition
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return autoFillOnLoadUnlockCondition_;
			}
			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				autoFillOnLoadUnlockCondition_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x3065100", Offset = "0x3063B00", VA = "0x183065100")]
		[DebuggerNonUserCode]
		public ManaData()
		{
			exceedingManaMoveSpeedMultiplier_ = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x30649A0", Offset = "0x30633A0", VA = "0x1830649A0")]
		private void OnConstruction()
		{
			exceedingManaMoveSpeedMultiplier_ = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x30651D0", Offset = "0x3063BD0", VA = "0x1830651D0")]
		[DebuggerNonUserCode]
		public ManaData(ManaData other)
		{
			//IL_005c: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			exceedingManaMoveSpeedMultiplier_ = 1f;
			RepeatedField<Types.ManaSpendingAction> repeatedField = (spendingActions_ = (RepeatedField<Types.ManaSpendingAction>)(object)((RepeatedField<T>)(object)other.spendingActions_).Clone());
			Duration duration = other.meditationRegenTickInterval_;
			int num = 0;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			meditationRegenTickInterval_ = (Duration)num;
			int num2 = (meditationMaxRegenPercentage_ = other.meditationMaxRegenPercentage_);
			int num3 = (exceedingManaMaximumMultiplier_ = other.exceedingManaMaximumMultiplier_);
			float num4 = (exceedingManaMoveSpeedMultiplier_ = other.exceedingManaMoveSpeedMultiplier_);
			int num5 = (exhaustEffectThresholdPercent_ = other.exhaustEffectThresholdPercent_);
			int num6 = (exhaustEffectThresholdFlat_ = other.exhaustEffectThresholdFlat_);
			Duration duration3 = other.exhaustEffectDuration_;
			if (duration3 != null)
			{
				Duration duration4 = duration3.Clone();
			}
			exhaustEffectDuration_ = (Duration)num;
			ConditionsList conditionsList = other.autoFillOnLoadUnlockCondition_;
			ConditionsList conditionsList2 = default(ConditionsList);
			if (conditionsList != null)
			{
				conditionsList2 = conditionsList.Clone();
			}
			autoFillOnLoadUnlockCondition_ = conditionsList2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x3063CF0", Offset = "0x30626F0", VA = "0x183063CF0", Slot = "10")]
		[DebuggerNonUserCode]
		public ManaData Clone()
		{
			return new ManaData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x3063EB0", Offset = "0x30628B0", VA = "0x183063EB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = object.Equals(meditationRegenTickInterval_, other);
					sbyte b = default(sbyte);
					if (flag2 && meditationMaxRegenPercentage_ == (flag2 ? 1 : 0) && exceedingManaMaximumMultiplier_ == (flag2 ? 1 : 0) && exhaustEffectThresholdPercent_ == b && exhaustEffectThresholdFlat_ == b)
					{
						Duration duration = exhaustEffectDuration_;
						bool flag3 = default(bool);
						if (flag3)
						{
							ConditionsList conditionsList = autoFillOnLoadUnlockCondition_;
							bool flag4 = default(bool);
							if (flag4)
							{
								UnknownFieldSet unknownFields = _unknownFields;
								bool result = default(bool);
								return result;
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x3063D50", Offset = "0x3062750", VA = "0x183063D50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ManaData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
				RepeatedField<Types.ManaSpendingAction> repeatedField2 = other.spendingActions_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					Duration objB = other.meditationRegenTickInterval_;
					if (object.Equals(meditationRegenTickInterval_, objB))
					{
						int num = other.meditationMaxRegenPercentage_;
						if (meditationMaxRegenPercentage_ == num)
						{
							int num2 = other.exceedingManaMaximumMultiplier_;
							if (exceedingManaMaximumMultiplier_ == num2)
							{
								int num3 = other.exhaustEffectThresholdPercent_;
								if (exhaustEffectThresholdPercent_ == num3)
								{
									int num4 = other.exhaustEffectThresholdFlat_;
									if (exhaustEffectThresholdFlat_ == num4)
									{
										Duration objB2 = other.exhaustEffectDuration_;
										if (object.Equals(exhaustEffectDuration_, objB2))
										{
											ConditionsList objB3 = other.autoFillOnLoadUnlockCondition_;
											if (object.Equals(autoFillOnLoadUnlockCondition_, objB3))
											{
												UnknownFieldSet unknownFields = other._unknownFields;
												return object.Equals(_unknownFields, unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x30641F0", Offset = "0x3062BF0", VA = "0x1830641F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a4
			//IL_0048: Expected O, but got I4
			int hashCode = ((RepeatedField<T>)(object)spendingActions_).GetHashCode();
			Duration duration = meditationRegenTickInterval_;
			if (duration != null)
			{
				int hashCode2 = duration.GetHashCode();
			}
			if (meditationMaxRegenPercentage_ != 0)
			{
			}
			int num = exceedingManaMaximumMultiplier_;
			int num2 = default(int);
			if (num != 0)
			{
				num2 = 0;
			}
			if (num != 0)
			{
				int hashCode3 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num2);
			}
			if (exhaustEffectThresholdPercent_ != 0)
			{
			}
			if (exhaustEffectThresholdFlat_ != 0)
			{
			}
			Duration duration2 = exhaustEffectDuration_;
			if (duration2 != null)
			{
				int hashCode4 = duration2.GetHashCode();
			}
			ConditionsList conditionsList = autoFillOnLoadUnlockCondition_;
			if (conditionsList != null)
			{
				int hashCode5 = conditionsList.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x3064CB0", Offset = "0x30636B0", VA = "0x183064CB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x3064D10", Offset = "0x3063710", VA = "0x183064D10", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00f0
			RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
			FieldCodec<Types.ManaSpendingAction> repeated_spendingActions_codec = _repeated_spendingActions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_spendingActions_codec);
			if ((long)meditationRegenTickInterval_ != 0)
			{
				Duration value = meditationRegenTickInterval_;
				output.WriteMessage(value);
			}
			if (meditationMaxRegenPercentage_ != 0)
			{
				int value2 = meditationMaxRegenPercentage_;
				output.WriteInt32(value2);
			}
			if (exceedingManaMaximumMultiplier_ != 0)
			{
				int value3 = exceedingManaMaximumMultiplier_;
				output.WriteInt32(value3);
			}
			if (output != null)
			{
				float value4 = exceedingManaMoveSpeedMultiplier_;
				output.WriteFloat(value4);
			}
			if ((long)autoFillOnLoadUnlockCondition_ != 0)
			{
				ConditionsList value5 = autoFillOnLoadUnlockCondition_;
				output.WriteMessage(value5);
			}
			if (exhaustEffectThresholdPercent_ != 0)
			{
				int value6 = exhaustEffectThresholdPercent_;
				output.WriteInt32(value6);
			}
			if (exhaustEffectThresholdFlat_ != 0)
			{
				int value7 = exhaustEffectThresholdFlat_;
				output.WriteInt32(value7);
			}
			if ((long)exhaustEffectDuration_ != 0)
			{
				Duration value8 = exhaustEffectDuration_;
				output.WriteMessage(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x3063970", Offset = "0x3062370", VA = "0x183063970", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_011e
			RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
			FieldCodec<Types.ManaSpendingAction> repeated_spendingActions_codec = _repeated_spendingActions_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_spendingActions_codec);
			Duration duration = meditationRegenTickInterval_;
			if (duration != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(duration);
				num2++;
				num += num2;
			}
			int num3 = meditationMaxRegenPercentage_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			int num5 = exceedingManaMaximumMultiplier_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			num += 5;
			int num7 = exhaustEffectThresholdPercent_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num += num8;
			}
			int num9 = exhaustEffectThresholdFlat_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num += num10;
			}
			Duration duration2 = exhaustEffectDuration_;
			if (duration2 != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(duration2);
				num11++;
				num += num11;
			}
			ConditionsList conditionsList = autoFillOnLoadUnlockCondition_;
			if (conditionsList != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num12++;
				num += num12;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num += num13;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x3064530", Offset = "0x3062F30", VA = "0x183064530", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ManaData other)
		{
			//Discarded unreachable code: IL_0158
			if (other == null)
			{
				return;
			}
			RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
			RepeatedField<Types.ManaSpendingAction> repeatedField2 = other.spendingActions_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.meditationRegenTickInterval_ != 0)
			{
				Duration duration = meditationRegenTickInterval_;
				if (duration == null)
				{
					Duration duration2 = (meditationRegenTickInterval_ = new Duration());
					Duration duration3 = meditationRegenTickInterval_;
				}
				Duration other2 = other.meditationRegenTickInterval_;
				duration.MergeFrom(other2);
			}
			int num = other.meditationMaxRegenPercentage_;
			if (num != 0)
			{
				meditationMaxRegenPercentage_ = num;
			}
			int num2 = other.exceedingManaMaximumMultiplier_;
			if (num2 != 0)
			{
				exceedingManaMaximumMultiplier_ = num2;
			}
			float num3 = other.exceedingManaMoveSpeedMultiplier_;
			if (num2 != 0)
			{
				exceedingManaMoveSpeedMultiplier_ = num3;
			}
			int num4 = other.exhaustEffectThresholdPercent_;
			if (num4 != 0)
			{
				exhaustEffectThresholdPercent_ = num4;
			}
			int num5 = other.exhaustEffectThresholdFlat_;
			if (num5 != 0)
			{
				exhaustEffectThresholdFlat_ = num5;
			}
			if ((long)other.exhaustEffectDuration_ != 0)
			{
				Duration duration5 = default(Duration);
				if (exhaustEffectDuration_ == null)
				{
					Duration duration4 = (exhaustEffectDuration_ = new Duration());
					duration5 = exhaustEffectDuration_;
				}
				Duration other3 = other.exhaustEffectDuration_;
				duration5.MergeFrom(other3);
			}
			if ((long)other.autoFillOnLoadUnlockCondition_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (autoFillOnLoadUnlockCondition_ == null)
				{
					ConditionsList conditionsList = (autoFillOnLoadUnlockCondition_ = new ConditionsList());
					conditionsList2 = autoFillOnLoadUnlockCondition_;
				}
				ConditionsList other4 = other.autoFillOnLoadUnlockCondition_;
				conditionsList2.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x3064710", Offset = "0x3063110", VA = "0x183064710", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0151
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 40)
			{
				if ((int)num > 58)
				{
					if (num == 104)
					{
						int num2 = (exhaustEffectThresholdPercent_ = input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 112)
					{
						num3 = (exhaustEffectThresholdFlat_ = input.ReadInt32());
					}
					if (num3 != 122)
					{
						goto IL_013a;
					}
					Duration builder = default(Duration);
					if (exhaustEffectDuration_ == null)
					{
						Duration duration = (exhaustEffectDuration_ = new Duration());
						builder = exhaustEffectDuration_;
					}
					input.ReadMessage(builder);
				}
				if (num == 53)
				{
					float num4 = (exceedingManaMoveSpeedMultiplier_ = input.ReadFloat());
				}
				if (num != 58)
				{
					goto IL_013a;
				}
				ConditionsList builder2 = default(ConditionsList);
				if (autoFillOnLoadUnlockCondition_ == null)
				{
					ConditionsList conditionsList = (autoFillOnLoadUnlockCondition_ = new ConditionsList());
					builder2 = autoFillOnLoadUnlockCondition_;
				}
				input.ReadMessage(builder2);
			}
			int num6 = default(int);
			if ((int)num > 26)
			{
				int num5 = default(int);
				if (num == 32)
				{
					num5 = (meditationMaxRegenPercentage_ = input.ReadInt32());
				}
				if (num5 != 40)
				{
					goto IL_013a;
				}
				num6 = (exceedingManaMaximumMultiplier_ = input.ReadInt32());
			}
			if (num6 == 10)
			{
				RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
				FieldCodec<Types.ManaSpendingAction> repeated_spendingActions_codec = _repeated_spendingActions_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_spendingActions_codec);
			}
			if (num6 == 26)
			{
				Duration builder3 = default(Duration);
				if (meditationRegenTickInterval_ == null)
				{
					Duration duration2 = (meditationRegenTickInterval_ = new Duration());
					builder3 = meditationRegenTickInterval_;
				}
				input.ReadMessage(builder3);
			}
			goto IL_013a;
			IL_013a:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x3064060", Offset = "0x3062A60", VA = "0x183064060", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 14)
			{
				RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x30649B0", Offset = "0x30633B0", VA = "0x1830649B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_002c
			//IL_0018: Expected O, but got I4
			while (fieldNumber - 1 <= 14)
			{
				int num = 0;
				if (value == null || value != null)
				{
					meditationRegenTickInterval_ = (Duration)num;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x3063BB0", Offset = "0x30625B0", VA = "0x183063BB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0014
			if (fieldNumber - 1 <= 14)
			{
				RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x30643E0", Offset = "0x3062DE0", VA = "0x1830643E0")]
		public int GetManaCost(Types.ManaSpendingActionType actionType)
		{
			//Discarded unreachable code: IL_004f
			int result = 0;
			Dictionary<Types.ManaSpendingActionType, int> dictionary = manaCost;
			bool flag = default(bool);
			if (!flag)
			{
				RepeatedField<Types.ManaSpendingAction> repeatedField = spendingActions_;
				Func<Types.ManaSpendingAction, bool> func = (Func<Types.ManaSpendingAction, bool>)(object)(Func<T, TResult>)delegate(Types.ManaSpendingAction x)
				{
					//Discarded unreachable code: IL_0011
					Types.ManaSpendingActionType manaSpendingActionType = actionType;
					return x.type_ == manaSpendingActionType;
				};
				if (Enumerable.FirstOrDefault<Types.ManaSpendingAction>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func) != null)
				{
				}
				Dictionary<Types.ManaSpendingActionType, int> dictionary2 = manaCost;
				throw new NullReferenceException();
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x3064F30", Offset = "0x3063930", VA = "0x183064F30")]
		static ManaData()
		{
			Func<ManaData> func = default(Func<ManaData>);
			_parser = (MessageParser<ManaData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.ManaSpendingAction> parser = Types.ManaSpendingAction._parser;
			uint num = default(uint);
			_parser = (MessageParser<ManaData>)(object)FieldCodec.ForMessage<Types.ManaSpendingAction>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
