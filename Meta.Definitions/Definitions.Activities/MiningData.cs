using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008A2")]
	public sealed class MiningData : IVillageAreaLootTableUser, IMessage<MiningData>, IMessage, IEquatable<MiningData>, IDeepCloneable<MiningData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20008A3")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20008A4")]
			public sealed class PerHitReward : IMessage<PerHitReward>, IMessage, IEquatable<PerHitReward>, IDeepCloneable<PerHitReward>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002A80")]
				private static readonly MessageParser<PerHitReward> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002A81")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002A82")]
				public const int LocationFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002A83")]
				private ActivityDataLocationFilter location_;

				[Cpp2IlInjected.Token(Token = "0x4002A84")]
				public const int LootTableFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002A85")]
				private int lootTable_;

				[Cpp2IlInjected.Token(Token = "0x17001840")]
				[DebuggerNonUserCode]
				public static MessageParser<PerHitReward> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006097")]
					[Cpp2IlInjected.Address(RVA = "0x2FF1810", Offset = "0x2FF0210", VA = "0x182FF1810")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001841")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006098")]
					[Cpp2IlInjected.Address(RVA = "0x2FF1790", Offset = "0x2FF0190", VA = "0x182FF1790")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001842")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006099")]
					[Cpp2IlInjected.Address(RVA = "0x2FF1870", Offset = "0x2FF0270", VA = "0x182FF1870", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001843")]
				[DebuggerNonUserCode]
				public ActivityDataLocationFilter Location
				{
					[Cpp2IlInjected.Token(Token = "0x600609E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600609F")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001844")]
				[DebuggerNonUserCode]
				public int LootTable
				{
					[Cpp2IlInjected.Token(Token = "0x60060A0")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60060A1")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600609A")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1650", Offset = "0x2FF0050", VA = "0x182FF1650")]
				[DebuggerNonUserCode]
				public PerHitReward()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600609B")]
				[Cpp2IlInjected.Address(RVA = "0x2FF13B0", Offset = "0x2FEFDB0", VA = "0x182FF13B0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600609C")]
				[Cpp2IlInjected.Address(RVA = "0x2FF16C0", Offset = "0x2FF00C0", VA = "0x182FF16C0")]
				[DebuggerNonUserCode]
				public PerHitReward(PerHitReward other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600609D")]
				[Cpp2IlInjected.Address(RVA = "0x2FF0F60", Offset = "0x2FEF960", VA = "0x182FF0F60", Slot = "10")]
				[DebuggerNonUserCode]
				public PerHitReward Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60060A2")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1060", Offset = "0x2FEFA60", VA = "0x182FF1060", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60060A3")]
				[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(PerHitReward other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60060A4")]
				[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60060A5")]
				[Cpp2IlInjected.Address(RVA = "0x2FF14E0", Offset = "0x2FEFEE0", VA = "0x182FF14E0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60060A6")]
				[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060A7")]
				[Cpp2IlInjected.Address(RVA = "0x2FF0E90", Offset = "0x2FEF890", VA = "0x182FF0E90", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60060A8")]
				[Cpp2IlInjected.Address(RVA = "0x2FF12D0", Offset = "0x2FEFCD0", VA = "0x182FF12D0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(PerHitReward other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060A9")]
				[Cpp2IlInjected.Address(RVA = "0x2FF11E0", Offset = "0x2FEFBE0", VA = "0x182FF11E0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060AA")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1110", Offset = "0x2FEFB10", VA = "0x182FF1110", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60060AB")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1410", Offset = "0x2FEFE10", VA = "0x182FF1410", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060AC")]
				[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20008A6")]
			public sealed class MiningRarityData : IMessage<MiningRarityData>, IMessage, IEquatable<MiningRarityData>, IDeepCloneable<MiningRarityData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002A87")]
				private static readonly MessageParser<MiningRarityData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002A88")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002A89")]
				public const int RarityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002A8A")]
				private MiningRarity rarity_;

				[Cpp2IlInjected.Token(Token = "0x4002A8B")]
				public const int WeightFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4002A8C")]
				private int weight_;

				[Cpp2IlInjected.Token(Token = "0x17001845")]
				[DebuggerNonUserCode]
				public static MessageParser<MiningRarityData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60060B1")]
					[Cpp2IlInjected.Address(RVA = "0x2FF0D70", Offset = "0x2FEF770", VA = "0x182FF0D70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001846")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60060B2")]
					[Cpp2IlInjected.Address(RVA = "0x2FF0CF0", Offset = "0x2FEF6F0", VA = "0x182FF0CF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001847")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60060B3")]
					[Cpp2IlInjected.Address(RVA = "0x2FF0DD0", Offset = "0x2FEF7D0", VA = "0x182FF0DD0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001848")]
				[DebuggerNonUserCode]
				public MiningRarity Rarity
				{
					[Cpp2IlInjected.Token(Token = "0x60060B7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(MiningRarity);
					}
					[Cpp2IlInjected.Token(Token = "0x60060B8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001849")]
				[DebuggerNonUserCode]
				public int Weight
				{
					[Cpp2IlInjected.Token(Token = "0x60060B9")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60060BA")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60060B4")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public MiningRarityData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060B5")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public MiningRarityData(MiningRarityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060B6")]
				[Cpp2IlInjected.Address(RVA = "0x2FF08A0", Offset = "0x2FEF2A0", VA = "0x182FF08A0", Slot = "10")]
				[DebuggerNonUserCode]
				public MiningRarityData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60060BB")]
				[Cpp2IlInjected.Address(RVA = "0x2FF0930", Offset = "0x2FEF330", VA = "0x182FF0930", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60060BC")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(MiningRarityData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60060BD")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60060BE")]
				[Cpp2IlInjected.Address(RVA = "0x2FF0B80", Offset = "0x2FEF580", VA = "0x182FF0B80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60060BF")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060C0")]
				[Cpp2IlInjected.Address(RVA = "0x2FF07D0", Offset = "0x2FEF1D0", VA = "0x182FF07D0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60060C1")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(MiningRarityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060C2")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060C3")]
				[Cpp2IlInjected.Address(RVA = "0x2FF09C0", Offset = "0x2FEF3C0", VA = "0x182FF09C0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60060C4")]
				[Cpp2IlInjected.Address(RVA = "0x2FF0AB0", Offset = "0x2FEF4B0", VA = "0x182FF0AB0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060C5")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002A6C")]
		private static readonly MessageParser<MiningData> _parser = (MessageParser<MiningData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MiningData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A6D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A6E")]
		public const int RockRefillTimerFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A6F")]
		private Duration rockRefillTimer_;

		[Cpp2IlInjected.Token(Token = "0x4002A70")]
		public const int ProbabilityOfSpecialAfterTwoHitsFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A71")]
		private int probabilityOfSpecialAfterTwoHits_;

		[Cpp2IlInjected.Token(Token = "0x4002A72")]
		public const int NumberOfRewardsForCriticalSuccessFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002A73")]
		private int numberOfRewardsForCriticalSuccess_;

		[Cpp2IlInjected.Token(Token = "0x4002A74")]
		public const int ResultMinDistanceFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A75")]
		private int resultMinDistance_;

		[Cpp2IlInjected.Token(Token = "0x4002A76")]
		public const int ResultMaxDistanceFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002A77")]
		private int resultMaxDistance_;

		[Cpp2IlInjected.Token(Token = "0x4002A78")]
		public const int RarityDataFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4002A79")]
		private static readonly FieldCodec<Types.MiningRarityData> _repeated_rarityData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002A7A")]
		private readonly RepeatedField<Types.MiningRarityData> rarityData_ = (RepeatedField<Types.MiningRarityData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002A7B")]
		public const int ProbabilityOfPerHitRewardFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002A7C")]
		private int probabilityOfPerHitReward_;

		[Cpp2IlInjected.Token(Token = "0x4002A7D")]
		public const int PerHitRewardsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4002A7E")]
		private static readonly FieldCodec<Types.PerHitReward> _repeated_perHitRewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002A7F")]
		private readonly RepeatedField<Types.PerHitReward> perHitRewards_ = (RepeatedField<Types.PerHitReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001835")]
		[DebuggerNonUserCode]
		public static MessageParser<MiningData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006077")]
			[Cpp2IlInjected.Address(RVA = "0x1D35B60", Offset = "0x1D34560", VA = "0x181D35B60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001836")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006078")]
			[Cpp2IlInjected.Address(RVA = "0x1D35A90", Offset = "0x1D34490", VA = "0x181D35A90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001837")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006079")]
			[Cpp2IlInjected.Address(RVA = "0x1D35BC0", Offset = "0x1D345C0", VA = "0x181D35BC0", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001838")]
		[DebuggerNonUserCode]
		public Duration RockRefillTimer
		{
			[Cpp2IlInjected.Token(Token = "0x600607D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return rockRefillTimer_;
			}
			[Cpp2IlInjected.Token(Token = "0x600607E")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				rockRefillTimer_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001839")]
		[DebuggerNonUserCode]
		public int ProbabilityOfSpecialAfterTwoHits
		{
			[Cpp2IlInjected.Token(Token = "0x600607F")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return probabilityOfSpecialAfterTwoHits_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006080")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				probabilityOfSpecialAfterTwoHits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183A")]
		[DebuggerNonUserCode]
		public int NumberOfRewardsForCriticalSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x6006081")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return numberOfRewardsForCriticalSuccess_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006082")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				numberOfRewardsForCriticalSuccess_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183B")]
		[DebuggerNonUserCode]
		public int ResultMinDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6006083")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return resultMinDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006084")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				resultMinDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183C")]
		[DebuggerNonUserCode]
		public int ResultMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6006085")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return resultMaxDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006086")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				resultMaxDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183D")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.MiningRarityData> RarityData
		{
			[Cpp2IlInjected.Token(Token = "0x6006087")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return rarityData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183E")]
		[DebuggerNonUserCode]
		public int ProbabilityOfPerHitReward
		{
			[Cpp2IlInjected.Token(Token = "0x6006088")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return probabilityOfPerHitReward_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006089")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				probabilityOfPerHitReward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183F")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.PerHitReward> PerHitRewards
		{
			[Cpp2IlInjected.Token(Token = "0x600608A")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return perHitRewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006076")]
		[Cpp2IlInjected.Address(RVA = "0x1D34AA0", Offset = "0x1D334A0", VA = "0x181D34AA0", Slot = "4")]
		public IEnumerable<(VillageAreaType, Item)> GetVillageAreaLootTables()
		{
			RepeatedField<Types.PerHitReward> repeatedField = perHitRewards_;
			Func<Types.PerHitReward, bool> _003C_003E9__1_ = _003C_003Ec._003C_003E9__1_0;
			if (_003C_003E9__1_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.PerHitReward x) => x.location_.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea);
			}
			IEnumerable<Types.PerHitReward> enumerable = (IEnumerable<Types.PerHitReward>)Enumerable.Where<Types.PerHitReward>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__1_);
			Func<Types.PerHitReward, (VillageAreaType, Item)> func = default(Func<Types.PerHitReward, (VillageAreaType, Item)>);
			if (_003C_003Ec._003C_003E9__1_1 == null)
			{
				func = (Func<Types.PerHitReward, (VillageAreaType, Item)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Types.PerHitReward x)
				{
					VillageAreaType villageArea = x.location_.VillageArea;
					int num = (int)villageArea;
					int lootTable_ = x.lootTable_;
					int num2 = (int)villageArea;
					throw new NullReferenceException();
				});
			}
			return (IEnumerable<(VillageAreaType, Item)>)Enumerable.Select<Types.PerHitReward, (VillageAreaType, Item)>((IEnumerable<>)enumerable, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600607A")]
		[Cpp2IlInjected.Address(RVA = "0x1D35810", Offset = "0x1D34210", VA = "0x181D35810")]
		[DebuggerNonUserCode]
		public MiningData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600607B")]
		[Cpp2IlInjected.Address(RVA = "0x1D358D0", Offset = "0x1D342D0", VA = "0x181D358D0")]
		[DebuggerNonUserCode]
		public MiningData(MiningData other)
		{
			//IL_003d: Expected O, but got I4
			Duration duration = other.rockRefillTimer_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			int num = 0;
			rockRefillTimer_ = (Duration)num;
			int num2 = (probabilityOfSpecialAfterTwoHits_ = other.probabilityOfSpecialAfterTwoHits_);
			int num3 = (numberOfRewardsForCriticalSuccess_ = other.numberOfRewardsForCriticalSuccess_);
			int num4 = (resultMinDistance_ = other.resultMinDistance_);
			int num5 = (resultMaxDistance_ = other.resultMaxDistance_);
			RepeatedField<Types.MiningRarityData> repeatedField = (rarityData_ = (RepeatedField<Types.MiningRarityData>)(object)((RepeatedField<T>)(object)other.rarityData_).Clone());
			int num6 = (probabilityOfPerHitReward_ = other.probabilityOfPerHitReward_);
			RepeatedField<Types.PerHitReward> repeatedField2 = (perHitRewards_ = (RepeatedField<Types.PerHitReward>)(object)((RepeatedField<T>)(object)other.perHitRewards_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600607C")]
		[Cpp2IlInjected.Address(RVA = "0x1D34590", Offset = "0x1D32F90", VA = "0x181D34590", Slot = "11")]
		[DebuggerNonUserCode]
		public MiningData Clone()
		{
			return new MiningData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600608B")]
		[Cpp2IlInjected.Address(RVA = "0x1D34700", Offset = "0x1D33100", VA = "0x181D34700", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(rockRefillTimer_, other);
				if (flag && probabilityOfSpecialAfterTwoHits_ == (flag ? 1 : 0) && numberOfRewardsForCriticalSuccess_ == (flag ? 1 : 0) && resultMinDistance_ == (flag ? 1 : 0) && resultMaxDistance_ == (flag ? 1 : 0))
				{
					RepeatedField<Types.MiningRarityData> repeatedField = rarityData_;
					bool flag2 = default(bool);
					if (flag2 && probabilityOfPerHitReward_ == (flag2 ? 1 : 0))
					{
						RepeatedField<Types.PerHitReward> repeatedField2 = perHitRewards_;
						bool flag3 = default(bool);
						if (flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600608C")]
		[Cpp2IlInjected.Address(RVA = "0x1D345F0", Offset = "0x1D32FF0", VA = "0x181D345F0", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(MiningData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Duration objB = other.rockRefillTimer_;
				if (object.Equals(rockRefillTimer_, objB))
				{
					int num = other.probabilityOfSpecialAfterTwoHits_;
					if (probabilityOfSpecialAfterTwoHits_ == num)
					{
						int num2 = other.numberOfRewardsForCriticalSuccess_;
						if (numberOfRewardsForCriticalSuccess_ == num2)
						{
							int num3 = other.resultMinDistance_;
							if (resultMinDistance_ == num3)
							{
								int num4 = other.resultMaxDistance_;
								if (resultMaxDistance_ == num4)
								{
									RepeatedField<Types.MiningRarityData> repeatedField = rarityData_;
									RepeatedField<Types.MiningRarityData> repeatedField2 = other.rarityData_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										int num5 = other.probabilityOfPerHitReward_;
										if (probabilityOfPerHitReward_ == num5)
										{
											RepeatedField<Types.PerHitReward> repeatedField3 = perHitRewards_;
											RepeatedField<Types.PerHitReward> repeatedField4 = other.perHitRewards_;
											if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
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
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600608D")]
		[Cpp2IlInjected.Address(RVA = "0x1D34980", Offset = "0x1D33380", VA = "0x181D34980", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0070
			Duration duration = rockRefillTimer_;
			if (duration != null)
			{
				int hashCode = duration.GetHashCode();
			}
			if (probabilityOfSpecialAfterTwoHits_ != 0)
			{
			}
			if (numberOfRewardsForCriticalSuccess_ != 0)
			{
			}
			if (resultMinDistance_ != 0)
			{
			}
			if (resultMaxDistance_ != 0)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)rarityData_).GetHashCode();
			if (probabilityOfPerHitReward_ != 0)
			{
			}
			int hashCode3 = ((RepeatedField<T>)(object)perHitRewards_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600608E")]
		[Cpp2IlInjected.Address(RVA = "0x1D35300", Offset = "0x1D33D00", VA = "0x181D35300", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600608F")]
		[Cpp2IlInjected.Address(RVA = "0x1D35360", Offset = "0x1D33D60", VA = "0x181D35360", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d8
			if ((long)rockRefillTimer_ != 0)
			{
				Duration value = rockRefillTimer_;
				output.WriteMessage(value);
			}
			if (probabilityOfSpecialAfterTwoHits_ != 0)
			{
				int value2 = probabilityOfSpecialAfterTwoHits_;
				output.WriteInt32(value2);
			}
			if (numberOfRewardsForCriticalSuccess_ != 0)
			{
				int value3 = numberOfRewardsForCriticalSuccess_;
				output.WriteInt32(value3);
			}
			if (resultMinDistance_ != 0)
			{
				int value4 = resultMinDistance_;
				output.WriteInt32(value4);
			}
			if (resultMaxDistance_ != 0)
			{
				int value5 = resultMaxDistance_;
				output.WriteInt32(value5);
			}
			RepeatedField<Types.MiningRarityData> repeatedField = rarityData_;
			FieldCodec<Types.MiningRarityData> repeated_rarityData_codec = _repeated_rarityData_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rarityData_codec);
			if (probabilityOfPerHitReward_ != 0)
			{
				int value6 = probabilityOfPerHitReward_;
				output.WriteInt32(value6);
			}
			RepeatedField<Types.PerHitReward> repeatedField2 = perHitRewards_;
			FieldCodec<Types.PerHitReward> repeated_perHitRewards_codec = _repeated_perHitRewards_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_perHitRewards_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006090")]
		[Cpp2IlInjected.Address(RVA = "0x1D34230", Offset = "0x1D32C30", VA = "0x181D34230", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0111
			Duration duration = rockRefillTimer_;
			int num = 0;
			if (duration != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(duration);
			}
			int num3 = probabilityOfSpecialAfterTwoHits_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			int num5 = numberOfRewardsForCriticalSuccess_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			int num7 = resultMinDistance_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num += num8;
			}
			int num9 = resultMaxDistance_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num += num10;
			}
			RepeatedField<Types.MiningRarityData> repeatedField = rarityData_;
			FieldCodec<Types.MiningRarityData> repeated_rarityData_codec = _repeated_rarityData_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rarityData_codec);
			int num12 = probabilityOfPerHitReward_;
			num += num11;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num += num13;
			}
			RepeatedField<Types.PerHitReward> repeatedField2 = perHitRewards_;
			FieldCodec<Types.PerHitReward> repeated_perHitRewards_codec = _repeated_perHitRewards_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_perHitRewards_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num14;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				num += num15;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006091")]
		[Cpp2IlInjected.Address(RVA = "0x1D34CB0", Offset = "0x1D336B0", VA = "0x181D34CB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiningData other)
		{
			//Discarded unreachable code: IL_00f0
			if (other == null)
			{
				return;
			}
			if ((long)other.rockRefillTimer_ != 0)
			{
				Duration duration = rockRefillTimer_;
				if (duration == null)
				{
					Duration duration2 = (rockRefillTimer_ = new Duration());
				}
				Duration other2 = other.rockRefillTimer_;
				duration.MergeFrom(other2);
			}
			int num = other.probabilityOfSpecialAfterTwoHits_;
			if (num != 0)
			{
				probabilityOfSpecialAfterTwoHits_ = num;
			}
			int num2 = other.numberOfRewardsForCriticalSuccess_;
			if (num2 != 0)
			{
				numberOfRewardsForCriticalSuccess_ = num2;
			}
			int num3 = other.resultMinDistance_;
			if (num3 != 0)
			{
				resultMinDistance_ = num3;
			}
			int num4 = other.resultMaxDistance_;
			if (num4 != 0)
			{
				resultMaxDistance_ = num4;
			}
			RepeatedField<Types.MiningRarityData> repeatedField = rarityData_;
			RepeatedField<Types.MiningRarityData> repeatedField2 = other.rarityData_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num5 = other.probabilityOfPerHitReward_;
			if (num5 != 0)
			{
				probabilityOfPerHitReward_ = num5;
			}
			RepeatedField<Types.PerHitReward> repeatedField3 = perHitRewards_;
			RepeatedField<Types.PerHitReward> repeatedField4 = other.perHitRewards_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6006092")]
		[Cpp2IlInjected.Address(RVA = "0x1D34E00", Offset = "0x1D33800", VA = "0x181D34E00", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0114
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 32)
			{
				if ((int)num > 50)
				{
					if (num == 56)
					{
						int num2 = (probabilityOfPerHitReward_ = input.ReadInt32());
					}
					if (num != 66)
					{
						goto IL_00fd;
					}
					RepeatedField<Types.PerHitReward> repeatedField = perHitRewards_;
					FieldCodec<Types.PerHitReward> repeated_perHitRewards_codec = _repeated_perHitRewards_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_perHitRewards_codec);
				}
				int num3 = default(int);
				if (num == 40)
				{
					num3 = (resultMaxDistance_ = input.ReadInt32());
				}
				if (num3 != 50)
				{
					goto IL_00fd;
				}
				RepeatedField<Types.MiningRarityData> repeatedField2 = rarityData_;
				FieldCodec<Types.MiningRarityData> repeated_rarityData_codec = _repeated_rarityData_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rarityData_codec);
			}
			int num5 = default(int);
			if ((int)num > 16)
			{
				int num4 = default(int);
				if (num == 24)
				{
					num4 = (numberOfRewardsForCriticalSuccess_ = input.ReadInt32());
				}
				if (num4 != 32)
				{
					goto IL_00fd;
				}
				num5 = (resultMinDistance_ = input.ReadInt32());
			}
			Duration duration = default(Duration);
			if (num5 == 10)
			{
				Duration builder = default(Duration);
				if (rockRefillTimer_ == null)
				{
					duration = (rockRefillTimer_ = new Duration());
					builder = rockRefillTimer_;
				}
				input.ReadMessage(builder);
			}
			if ((long)duration == 16)
			{
				int num6 = (probabilityOfSpecialAfterTwoHits_ = input.ReadInt32());
			}
			goto IL_00fd;
			IL_00fd:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006093")]
		[Cpp2IlInjected.Address(RVA = "0x1D34850", Offset = "0x1D33250", VA = "0x181D34850", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				Duration duration = rockRefillTimer_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006094")]
		[Cpp2IlInjected.Address(RVA = "0x1D35050", Offset = "0x1D33A50", VA = "0x181D35050", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				rockRefillTimer_ = (Duration)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006095")]
		[Cpp2IlInjected.Address(RVA = "0x1D34480", Offset = "0x1D32E80", VA = "0x181D34480", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_0009, IL_000a, IL_000b, IL_000c
			if (fieldNumber - 1 > 7)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006096")]
		[Cpp2IlInjected.Address(RVA = "0x1D35580", Offset = "0x1D33F80", VA = "0x181D35580")]
		static MiningData()
		{
			MessageParser<Types.MiningRarityData> parser = Types.MiningRarityData._parser;
			uint num = default(uint);
			_parser = (MessageParser<MiningData>)(object)FieldCodec.ForMessage<Types.MiningRarityData>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.PerHitReward> parser2 = Types.PerHitReward._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<MiningData>)(object)FieldCodec.ForMessage<Types.PerHitReward>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
