using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000897")]
	public sealed class ActivityBonusRewardData : IMessage<ActivityBonusRewardData>, IMessage, IEquatable<ActivityBonusRewardData>, IDeepCloneable<ActivityBonusRewardData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000898")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000899")]
			public sealed class Data : IMessage<Data>, IMessage, IEquatable<Data>, IDeepCloneable<Data>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400229A")]
				private static readonly MessageParser<Data> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400229B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400229C")]
				public const int LootTableItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400229D")]
				private int lootTableItemID_;

				[Cpp2IlInjected.Token(Token = "0x400229E")]
				public const int RewardProbabilityFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400229F")]
				private int rewardProbability_;

				[Cpp2IlInjected.Token(Token = "0x40022A0")]
				public const int SpawnOnGridFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40022A1")]
				private bool spawnOnGrid_;

				[Cpp2IlInjected.Token(Token = "0x17000C30")]
				[DebuggerNonUserCode]
				public static MessageParser<Data> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600490E")]
					[Cpp2IlInjected.Address(RVA = "0x75C460", Offset = "0x75AE60", VA = "0x18075C460")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C31")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600490F")]
					[Cpp2IlInjected.Address(RVA = "0x75C380", Offset = "0x75AD80", VA = "0x18075C380")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C32")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004910")]
					[Cpp2IlInjected.Address(RVA = "0x75C4C0", Offset = "0x75AEC0", VA = "0x18075C4C0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C33")]
				[DebuggerNonUserCode]
				public int LootTableItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6004914")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004915")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C34")]
				[DebuggerNonUserCode]
				public int RewardProbability
				{
					[Cpp2IlInjected.Token(Token = "0x6004916")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004917")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C35")]
				[DebuggerNonUserCode]
				public bool SpawnOnGrid
				{
					[Cpp2IlInjected.Token(Token = "0x6004918")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6004919")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C36")]
				public Item LootTableItem
				{
					[Cpp2IlInjected.Token(Token = "0x6004925")]
					[Cpp2IlInjected.Address(RVA = "0x75C400", Offset = "0x75AE00", VA = "0x18075C400")]
					get
					{
						return default(Item);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004911")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Data()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004912")]
				[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
				[DebuggerNonUserCode]
				public Data(Data other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004913")]
				[Cpp2IlInjected.Address(RVA = "0x75BBB0", Offset = "0x75A5B0", VA = "0x18075BBB0", Slot = "10")]
				[DebuggerNonUserCode]
				public Data Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600491A")]
				[Cpp2IlInjected.Address(RVA = "0x75BC80", Offset = "0x75A680", VA = "0x18075BC80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600491B")]
				[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Data other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600491C")]
				[Cpp2IlInjected.Address(RVA = "0x75BE10", Offset = "0x75A810", VA = "0x18075BE10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600491D")]
				[Cpp2IlInjected.Address(RVA = "0x75C100", Offset = "0x75AB00", VA = "0x18075C100", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600491E")]
				[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600491F")]
				[Cpp2IlInjected.Address(RVA = "0x75BAB0", Offset = "0x75A4B0", VA = "0x18075BAB0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004920")]
				[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Data other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004921")]
				[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004922")]
				[Cpp2IlInjected.Address(RVA = "0x75BD20", Offset = "0x75A720", VA = "0x18075BD20", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004923")]
				[Cpp2IlInjected.Address(RVA = "0x75BFE0", Offset = "0x75A9E0", VA = "0x18075BFE0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004924")]
				[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200089B")]
			public sealed class HarvestData : IMessage<HarvestData>, IMessage, IEquatable<HarvestData>, IDeepCloneable<HarvestData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40022A3")]
				private static readonly MessageParser<HarvestData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40022A4")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40022A5")]
				public const int DataFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40022A6")]
				private Data data_;

				[Cpp2IlInjected.Token(Token = "0x40022A7")]
				public const int SpecificGardenItemIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40022A8")]
				private int specificGardenItemID_;

				[Cpp2IlInjected.Token(Token = "0x17000C37")]
				[DebuggerNonUserCode]
				public static MessageParser<HarvestData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600492A")]
					[Cpp2IlInjected.Address(RVA = "0x75D9B0", Offset = "0x75C3B0", VA = "0x18075D9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C38")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600492B")]
					[Cpp2IlInjected.Address(RVA = "0x75D930", Offset = "0x75C330", VA = "0x18075D930")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C39")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600492C")]
					[Cpp2IlInjected.Address(RVA = "0x75DA70", Offset = "0x75C470", VA = "0x18075DA70", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C3A")]
				[DebuggerNonUserCode]
				public Data Data
				{
					[Cpp2IlInjected.Token(Token = "0x6004931")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004932")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C3B")]
				[DebuggerNonUserCode]
				public int SpecificGardenItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6004933")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004934")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C3C")]
				public Item SpecificGardenItem
				{
					[Cpp2IlInjected.Token(Token = "0x6004940")]
					[Cpp2IlInjected.Address(RVA = "0x75DA10", Offset = "0x75C410", VA = "0x18075DA10")]
					get
					{
						return default(Item);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600492D")]
				[Cpp2IlInjected.Address(RVA = "0x75D8C0", Offset = "0x75C2C0", VA = "0x18075D8C0")]
				[DebuggerNonUserCode]
				public HarvestData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600492E")]
				[Cpp2IlInjected.Address(RVA = "0x75D450", Offset = "0x75BE50", VA = "0x18075D450")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600492F")]
				[Cpp2IlInjected.Address(RVA = "0x75D780", Offset = "0x75C180", VA = "0x18075D780")]
				[DebuggerNonUserCode]
				public HarvestData(HarvestData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004930")]
				[Cpp2IlInjected.Address(RVA = "0x75CE50", Offset = "0x75B850", VA = "0x18075CE50", Slot = "10")]
				[DebuggerNonUserCode]
				public HarvestData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004935")]
				[Cpp2IlInjected.Address(RVA = "0x75D030", Offset = "0x75BA30", VA = "0x18075D030", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004936")]
				[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(HarvestData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004937")]
				[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004938")]
				[Cpp2IlInjected.Address(RVA = "0x75D580", Offset = "0x75BF80", VA = "0x18075D580", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004939")]
				[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600493A")]
				[Cpp2IlInjected.Address(RVA = "0x75CD50", Offset = "0x75B750", VA = "0x18075CD50", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600493B")]
				[Cpp2IlInjected.Address(RVA = "0x75D240", Offset = "0x75BC40", VA = "0x18075D240", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(HarvestData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600493C")]
				[Cpp2IlInjected.Address(RVA = "0x75D360", Offset = "0x75BD60", VA = "0x18075D360", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600493D")]
				[Cpp2IlInjected.Address(RVA = "0x75D0E0", Offset = "0x75BAE0", VA = "0x18075D0E0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600493E")]
				[Cpp2IlInjected.Address(RVA = "0x75D4B0", Offset = "0x75BEB0", VA = "0x18075D4B0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600493F")]
				[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002289")]
		private static readonly MessageParser<ActivityBonusRewardData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400228A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400228B")]
		public const int HarvestFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400228C")]
		private static readonly FieldCodec<Types.HarvestData> _repeated_harvest_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400228D")]
		private readonly RepeatedField<Types.HarvestData> harvest_ = (RepeatedField<Types.HarvestData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400228E")]
		public const int WaterFlowersFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400228F")]
		private static readonly FieldCodec<Types.Data> _repeated_waterFlowers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002290")]
		private readonly RepeatedField<Types.Data> waterFlowers_ = (RepeatedField<Types.Data>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002291")]
		public const int FishingFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4002292")]
		private static readonly FieldCodec<Types.Data> _repeated_fishing_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002293")]
		private readonly RepeatedField<Types.Data> fishing_ = (RepeatedField<Types.Data>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002294")]
		public const int CookingFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4002295")]
		private static readonly FieldCodec<Types.Data> _repeated_cooking_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002296")]
		private readonly RepeatedField<Types.Data> cooking_ = (RepeatedField<Types.Data>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002297")]
		public const int MiningFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4002298")]
		private static readonly FieldCodec<Types.Data> _repeated_mining_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002299")]
		private readonly RepeatedField<Types.Data> mining_ = (RepeatedField<Types.Data>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000C28")]
		[DebuggerNonUserCode]
		public static MessageParser<ActivityBonusRewardData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60048F7")]
			[Cpp2IlInjected.Address(RVA = "0x18E3490", Offset = "0x18E1E90", VA = "0x1818E3490")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C29")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048F8")]
			[Cpp2IlInjected.Address(RVA = "0x18E33C0", Offset = "0x18E1DC0", VA = "0x1818E33C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048F9")]
			[Cpp2IlInjected.Address(RVA = "0x18E34F0", Offset = "0x18E1EF0", VA = "0x1818E34F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2B")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.HarvestData> Harvest
		{
			[Cpp2IlInjected.Token(Token = "0x60048FD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return harvest_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2C")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Data> WaterFlowers
		{
			[Cpp2IlInjected.Token(Token = "0x60048FE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return waterFlowers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2D")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Data> Fishing
		{
			[Cpp2IlInjected.Token(Token = "0x60048FF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return fishing_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2E")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Data> Cooking
		{
			[Cpp2IlInjected.Token(Token = "0x6004900")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return cooking_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C2F")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Data> Mining
		{
			[Cpp2IlInjected.Token(Token = "0x6004901")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return mining_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048FA")]
		[Cpp2IlInjected.Address(RVA = "0x18E3270", Offset = "0x18E1C70", VA = "0x1818E3270")]
		[DebuggerNonUserCode]
		public ActivityBonusRewardData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048FB")]
		[Cpp2IlInjected.Address(RVA = "0x18E2FE0", Offset = "0x18E19E0", VA = "0x1818E2FE0")]
		[DebuggerNonUserCode]
		public ActivityBonusRewardData(ActivityBonusRewardData other)
		{
			RepeatedField<Types.HarvestData> repeatedField = (harvest_ = (RepeatedField<Types.HarvestData>)(object)((RepeatedField<T>)(object)other.harvest_).Clone());
			RepeatedField<Types.Data> repeatedField2 = (waterFlowers_ = (RepeatedField<Types.Data>)(object)((RepeatedField<T>)(object)other.waterFlowers_).Clone());
			RepeatedField<Types.Data> repeatedField3 = (fishing_ = (RepeatedField<Types.Data>)(object)((RepeatedField<T>)(object)other.fishing_).Clone());
			RepeatedField<Types.Data> repeatedField4 = (cooking_ = (RepeatedField<Types.Data>)(object)((RepeatedField<T>)(object)other.cooking_).Clone());
			RepeatedField<Types.Data> repeatedField5 = (mining_ = (RepeatedField<Types.Data>)(object)((RepeatedField<T>)(object)other.mining_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048FC")]
		[Cpp2IlInjected.Address(RVA = "0x18E2030", Offset = "0x18E0A30", VA = "0x1818E2030", Slot = "10")]
		[DebuggerNonUserCode]
		public ActivityBonusRewardData Clone()
		{
			return new ActivityBonusRewardData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004902")]
		[Cpp2IlInjected.Address(RVA = "0x18E21C0", Offset = "0x18E0BC0", VA = "0x1818E21C0", Slot = "0")]
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
				RepeatedField<Types.HarvestData> repeatedField = harvest_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<Types.Data> repeatedField2 = waterFlowers_;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<Types.Data> repeatedField3 = fishing_;
						bool flag3 = default(bool);
						if (flag3)
						{
							RepeatedField<Types.Data> repeatedField4 = cooking_;
							bool flag4 = default(bool);
							if (flag4)
							{
								RepeatedField<Types.Data> repeatedField5 = mining_;
								bool flag5 = default(bool);
								if (flag5)
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004903")]
		[Cpp2IlInjected.Address(RVA = "0x18E2090", Offset = "0x18E0A90", VA = "0x1818E2090", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActivityBonusRewardData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.HarvestData> repeatedField = harvest_;
				RepeatedField<Types.HarvestData> repeatedField2 = other.harvest_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					RepeatedField<Types.Data> repeatedField3 = waterFlowers_;
					RepeatedField<Types.Data> repeatedField4 = other.waterFlowers_;
					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
					{
						RepeatedField<Types.Data> repeatedField5 = fishing_;
						RepeatedField<Types.Data> repeatedField6 = other.fishing_;
						if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
						{
							RepeatedField<Types.Data> repeatedField7 = cooking_;
							RepeatedField<Types.Data> repeatedField8 = other.cooking_;
							if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
							{
								RepeatedField<Types.Data> repeatedField9 = mining_;
								RepeatedField<Types.Data> repeatedField10 = other.mining_;
								if (((RepeatedField<T>)(object)repeatedField9).Equals((RepeatedField<>)(object)repeatedField10))
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
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004904")]
		[Cpp2IlInjected.Address(RVA = "0x18E23F0", Offset = "0x18E0DF0", VA = "0x1818E23F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0068
			int hashCode = ((RepeatedField<T>)(object)harvest_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)waterFlowers_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)fishing_).GetHashCode();
			RepeatedField<Types.Data> repeatedField = cooking_;
			hashCode = hashCode3;
			int hashCode4 = ((RepeatedField<T>)(object)repeatedField).GetHashCode();
			RepeatedField<Types.Data> repeatedField2 = mining_;
			hashCode2 = hashCode4;
			int hashCode5 = ((RepeatedField<T>)(object)repeatedField2).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			hashCode = hashCode5;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004905")]
		[Cpp2IlInjected.Address(RVA = "0x18E2A00", Offset = "0x18E1400", VA = "0x1818E2A00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004906")]
		[Cpp2IlInjected.Address(RVA = "0x18E2A60", Offset = "0x18E1460", VA = "0x1818E2A60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008b
			RepeatedField<Types.HarvestData> repeatedField = harvest_;
			FieldCodec<Types.HarvestData> repeated_harvest_codec = _repeated_harvest_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_harvest_codec);
			RepeatedField<Types.Data> repeatedField2 = waterFlowers_;
			FieldCodec<Types.Data> repeated_waterFlowers_codec = _repeated_waterFlowers_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_waterFlowers_codec);
			RepeatedField<Types.Data> repeatedField3 = fishing_;
			FieldCodec<Types.Data> repeated_fishing_codec = _repeated_fishing_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_fishing_codec);
			RepeatedField<Types.Data> repeatedField4 = cooking_;
			FieldCodec<Types.Data> repeated_cooking_codec = _repeated_cooking_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_cooking_codec);
			RepeatedField<Types.Data> repeatedField5 = mining_;
			FieldCodec<Types.Data> repeated_mining_codec = _repeated_mining_codec;
			((RepeatedField<T>)(object)repeatedField5).WriteTo(output, (FieldCodec<>)(object)repeated_mining_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004907")]
		[Cpp2IlInjected.Address(RVA = "0x18E1E20", Offset = "0x18E0820", VA = "0x1818E1E20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			RepeatedField<Types.HarvestData> repeatedField = harvest_;
			FieldCodec<Types.HarvestData> repeated_harvest_codec = _repeated_harvest_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_harvest_codec);
			RepeatedField<Types.Data> repeatedField2 = waterFlowers_;
			FieldCodec<Types.Data> repeated_waterFlowers_codec = _repeated_waterFlowers_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_waterFlowers_codec);
			RepeatedField<Types.Data> repeatedField3 = fishing_;
			FieldCodec<Types.Data> repeated_fishing_codec = _repeated_fishing_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_fishing_codec);
			RepeatedField<Types.Data> repeatedField4 = cooking_;
			FieldCodec<Types.Data> repeated_cooking_codec = _repeated_cooking_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_cooking_codec);
			RepeatedField<Types.Data> repeatedField5 = mining_;
			FieldCodec<Types.Data> repeated_mining_codec = _repeated_mining_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField5).CalculateSize((FieldCodec<>)(object)repeated_mining_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<Types.HarvestData>)(repeatedField + num6);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004908")]
		[Cpp2IlInjected.Address(RVA = "0x18E2760", Offset = "0x18E1160", VA = "0x1818E2760", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActivityBonusRewardData other)
		{
			//Discarded unreachable code: IL_009c
			if (other != null)
			{
				RepeatedField<Types.HarvestData> repeatedField = harvest_;
				RepeatedField<Types.HarvestData> repeatedField2 = other.harvest_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<Types.Data> repeatedField3 = waterFlowers_;
				RepeatedField<Types.Data> repeatedField4 = other.waterFlowers_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<Types.Data> repeatedField5 = fishing_;
				RepeatedField<Types.Data> repeatedField6 = other.fishing_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				RepeatedField<Types.Data> repeatedField7 = cooking_;
				RepeatedField<Types.Data> repeatedField8 = other.cooking_;
				((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
				RepeatedField<Types.Data> repeatedField9 = mining_;
				RepeatedField<Types.Data> repeatedField10 = other.mining_;
				((RepeatedField<T>)(object)repeatedField9).Add((IEnumerable<>)(object)repeatedField10);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004909")]
		[Cpp2IlInjected.Address(RVA = "0x18E24E0", Offset = "0x18E0EE0", VA = "0x1818E24E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c1
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					RepeatedField<Types.Data> repeatedField = fishing_;
					FieldCodec<Types.Data> repeated_fishing_codec = _repeated_fishing_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_fishing_codec);
				}
				if (num == 34)
				{
					RepeatedField<Types.Data> repeatedField2 = cooking_;
					FieldCodec<Types.Data> repeated_cooking_codec = _repeated_cooking_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_cooking_codec);
				}
				if (num != 42)
				{
					goto IL_00aa;
				}
				RepeatedField<Types.Data> repeatedField3 = mining_;
				FieldCodec<Types.Data> repeated_mining_codec = _repeated_mining_codec;
				((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_mining_codec);
			}
			if (num == 10)
			{
				RepeatedField<Types.HarvestData> repeatedField4 = harvest_;
				FieldCodec<Types.HarvestData> repeated_harvest_codec = _repeated_harvest_codec;
				((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_harvest_codec);
			}
			if (num == 18)
			{
				RepeatedField<Types.Data> repeatedField5 = waterFlowers_;
				FieldCodec<Types.Data> repeated_waterFlowers_codec = _repeated_waterFlowers_codec;
				((RepeatedField<T>)(object)repeatedField5).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_waterFlowers_codec);
			}
			goto IL_00aa;
			IL_00aa:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600490A")]
		[Cpp2IlInjected.Address(RVA = "0x18E2330", Offset = "0x18E0D30", VA = "0x1818E2330", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.Data> repeatedField = mining_;
				RepeatedField<Types.Data> repeatedField2 = cooking_;
				RepeatedField<Types.Data> repeatedField3 = fishing_;
				RepeatedField<Types.Data> repeatedField4 = waterFlowers_;
				RepeatedField<Types.HarvestData> repeatedField5 = harvest_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600490B")]
		[Cpp2IlInjected.Address(RVA = "0x18E2860", Offset = "0x18E1260", VA = "0x1818E2860", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600490C")]
		[Cpp2IlInjected.Address(RVA = "0x18E1FA0", Offset = "0x18E09A0", VA = "0x1818E1FA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0020
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 0 || num == 0 || num == 1)
			{
				RepeatedField<Types.HarvestData> repeatedField = harvest_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600490D")]
		[Cpp2IlInjected.Address(RVA = "0x18E2BE0", Offset = "0x18E15E0", VA = "0x1818E2BE0")]
		static ActivityBonusRewardData()
		{
			Func<ActivityBonusRewardData> func = default(Func<ActivityBonusRewardData>);
			_parser = (MessageParser<ActivityBonusRewardData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.HarvestData> parser = Types.HarvestData._parser;
			uint num = default(uint);
			_parser = (MessageParser<ActivityBonusRewardData>)(object)FieldCodec.ForMessage<Types.HarvestData>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.Data> parser2 = Types.Data._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<ActivityBonusRewardData>)(object)FieldCodec.ForMessage<Types.Data>(num2, (MessageParser<>)(object)parser2);
			MessageParser<Types.Data> parser3 = Types.Data._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<ActivityBonusRewardData>)(object)FieldCodec.ForMessage<Types.Data>(num3, (MessageParser<>)(object)parser3);
			MessageParser<Types.Data> parser4 = Types.Data._parser;
			uint num4 = default(uint);
			_parser = (MessageParser<ActivityBonusRewardData>)(object)FieldCodec.ForMessage<Types.Data>(num4, (MessageParser<>)(object)parser4);
			MessageParser<Types.Data> parser5 = Types.Data._parser;
			uint num5 = default(uint);
			_parser = (MessageParser<ActivityBonusRewardData>)(object)FieldCodec.ForMessage<Types.Data>(num5, (MessageParser<>)(object)parser5);
			/*Error: Unexpected end of block*/;
		}
	}
}
