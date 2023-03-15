using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008B2")]
	public sealed class GardenStallData : IGridStateData, IGridUpgradeStateData, IGridStateDailyResetNotify, IMessage<GardenStallData>, IMessage, IEquatable<GardenStallData>, IDeepCloneable<GardenStallData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20008B3")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20008B4")]
			public sealed class GardenStallSlot : IMessage<GardenStallSlot>, IMessage, IEquatable<GardenStallSlot>, IDeepCloneable<GardenStallSlot>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002AC0")]
				private static readonly MessageParser<GardenStallSlot> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002AC1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002AC2")]
				public const int SeedItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002AC3")]
				private int seedItemID_;

				[Cpp2IlInjected.Token(Token = "0x4002AC4")]
				public const int LastCollectFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002AC5")]
				private Timestamp lastCollect_;

				[Cpp2IlInjected.Token(Token = "0x1700186E")]
				public Item SeedItem
				{
					[Cpp2IlInjected.Token(Token = "0x600615B")]
					[Cpp2IlInjected.Address(RVA = "0x2940BB0", Offset = "0x293F5B0", VA = "0x182940BB0")]
					get
					{
						return default(Item);
					}
					[Cpp2IlInjected.Token(Token = "0x600615C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700186F")]
				[DebuggerNonUserCode]
				public static MessageParser<GardenStallSlot> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600615D")]
					[Cpp2IlInjected.Address(RVA = "0x2940B50", Offset = "0x293F550", VA = "0x182940B50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001870")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600615E")]
					[Cpp2IlInjected.Address(RVA = "0x2940AD0", Offset = "0x293F4D0", VA = "0x182940AD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001871")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600615F")]
					[Cpp2IlInjected.Address(RVA = "0x2940C10", Offset = "0x293F610", VA = "0x182940C10", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001872")]
				[DebuggerNonUserCode]
				public int SeedItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6006163")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006164")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001873")]
				[DebuggerNonUserCode]
				public Timestamp LastCollect
				{
					[Cpp2IlInjected.Token(Token = "0x6006165")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006166")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006160")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public GardenStallSlot()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006161")]
				[Cpp2IlInjected.Address(RVA = "0x17397E0", Offset = "0x17381E0", VA = "0x1817397E0")]
				[DebuggerNonUserCode]
				public GardenStallSlot(GardenStallSlot other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006162")]
				[Cpp2IlInjected.Address(RVA = "0x29404A0", Offset = "0x293EEA0", VA = "0x1829404A0", Slot = "10")]
				[DebuggerNonUserCode]
				public GardenStallSlot Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006167")]
				[Cpp2IlInjected.Address(RVA = "0x2940540", Offset = "0x293EF40", VA = "0x182940540", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006168")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(GardenStallSlot other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006169")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600616A")]
				[Cpp2IlInjected.Address(RVA = "0x2940960", Offset = "0x293F360", VA = "0x182940960", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600616B")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600616C")]
				[Cpp2IlInjected.Address(RVA = "0x29403D0", Offset = "0x293EDD0", VA = "0x1829403D0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600616D")]
				[Cpp2IlInjected.Address(RVA = "0x29407B0", Offset = "0x293F1B0", VA = "0x1829407B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(GardenStallSlot other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600616E")]
				[Cpp2IlInjected.Address(RVA = "0x29406C0", Offset = "0x293F0C0", VA = "0x1829406C0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600616F")]
				[Cpp2IlInjected.Address(RVA = "0x29405F0", Offset = "0x293EFF0", VA = "0x1829405F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006170")]
				[Cpp2IlInjected.Address(RVA = "0x2940890", Offset = "0x293F290", VA = "0x182940890", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006171")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002AB9")]
		private static readonly MessageParser<GardenStallData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002ABA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002ABB")]
		public const int UpgradeStateFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002ABC")]
		private UpgradeState upgradeState_;

		[Cpp2IlInjected.Token(Token = "0x4002ABD")]
		public const int SlotsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002ABE")]
		private static readonly FieldCodec<Types.GardenStallSlot> _repeated_slots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002ABF")]
		private readonly RepeatedField<Types.GardenStallSlot> slots_ = (RepeatedField<Types.GardenStallSlot>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001869")]
		[DebuggerNonUserCode]
		public static MessageParser<GardenStallData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006145")]
			[Cpp2IlInjected.Address(RVA = "0x2193070", Offset = "0x2191A70", VA = "0x182193070")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006146")]
			[Cpp2IlInjected.Address(RVA = "0x2192FA0", Offset = "0x21919A0", VA = "0x182192FA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006147")]
			[Cpp2IlInjected.Address(RVA = "0x21930D0", Offset = "0x2191AD0", VA = "0x1821930D0", Slot = "11")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186C")]
		[DebuggerNonUserCode]
		public UpgradeState UpgradeState
		{
			[Cpp2IlInjected.Token(Token = "0x600614B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "4")]
			get
			{
				return upgradeState_;
			}
			[Cpp2IlInjected.Token(Token = "0x600614C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "5")]
			set
			{
				upgradeState_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186D")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.GardenStallSlot> Slots
		{
			[Cpp2IlInjected.Token(Token = "0x600614D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006144")]
		[Cpp2IlInjected.Address(RVA = "0x21921D0", Offset = "0x2190BD0", VA = "0x1821921D0")]
		public GridStateDailyResetResult ExecuteDailyReset(Item item, in WorldProfile worldProfile, Random random, ITransactionContext context)
		{
			//Discarded unreachable code: IL_010e, IL_0114, IL_011a, IL_0120, IL_0126, IL_012c, IL_0132, IL_0138, IL_013e, IL_0144, IL_014a
			StallBuildingItemData stallBuildingItemData = default(StallBuildingItemData);
			LootTableItemData lootTableItemData = default(LootTableItemData);
			bool flag = default(bool);
			Item item2 = default(Item);
			MultiReward multiReward = default(MultiReward);
			bool flag2 = default(bool);
			ActivityItemType activityItemType = default(ActivityItemType);
			ulong num4 = default(ulong);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if ((IntPtr)upgradeState_ == (IntPtr)num)
				{
					break;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				RepeatedField<UpgradeData> upgradeInfo_ = stallBuildingItemData.upgradeInfo_;
				int level_ = upgradeState_.level_;
				UpgradeData upgradeData = Enumerable.ElementAtOrDefault<UpgradeData>((IEnumerable<>)(object)upgradeInfo_, level_);
				if (upgradeData != null)
				{
					Item seedLootTableItem = upgradeData.Garden.SeedLootTableItem;
				}
				Item invalid = Item.Invalid;
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				if (lootTableItemData == null)
				{
					break;
				}
				int num3 = 0;
				RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
				if (flag)
				{
					while ((object)item2 == null)
					{
					}
					LootTable rewards_ = lootTableItemData.rewards_;
					if (((RepeatedField<T>)(object)multiReward.rewards_).Count <= 0)
					{
						continue;
					}
					RepeatedField<AnyReward> rewards_2 = multiReward.rewards_;
					int index = 0;
					if (((AnyReward)((RepeatedField<T>)(object)rewards_2)[index]).rewardCase_ != AnyReward.RewardOneofCase.Item)
					{
						continue;
					}
					RepeatedField<AnyReward> rewards_3 = multiReward.rewards_;
					int index2 = 0;
					Item item3 = ((AnyReward)((RepeatedField<T>)(object)rewards_3)[index2]).Item.Item;
					while (!flag2)
					{
					}
					while (activityItemType != ActivityItemType.Seed)
					{
					}
					RepeatedField<AnyReward> rewards_4 = multiReward.rewards_;
					int index3 = 0;
					Item item4 = ((AnyReward)((RepeatedField<T>)(object)rewards_4)[index3]).Item.Item;
				}
				if (num4 == 0)
				{
				}
				break;
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006148")]
		[Cpp2IlInjected.Address(RVA = "0x2192F20", Offset = "0x2191920", VA = "0x182192F20")]
		[DebuggerNonUserCode]
		public GardenStallData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6006149")]
		[Cpp2IlInjected.Address(RVA = "0x2192E00", Offset = "0x2191800", VA = "0x182192E00")]
		[DebuggerNonUserCode]
		public GardenStallData(GardenStallData other)
		{
			//IL_002e: Expected O, but got I4
			UpgradeState upgradeState = other.upgradeState_;
			if (upgradeState != null)
			{
				UpgradeState upgradeState2 = upgradeState.Clone();
			}
			int num = 0;
			upgradeState_ = (UpgradeState)num;
			RepeatedField<Types.GardenStallSlot> repeatedField = (slots_ = (RepeatedField<Types.GardenStallSlot>)(object)((RepeatedField<T>)(object)other.slots_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600614A")]
		[Cpp2IlInjected.Address(RVA = "0x2191ED0", Offset = "0x21908D0", VA = "0x182191ED0", Slot = "13")]
		[DebuggerNonUserCode]
		public GardenStallData Clone()
		{
			//Discarded unreachable code: IL_005c
			//IL_0030: Expected O, but got I4
			GardenStallData gardenStallData = new GardenStallData();
			RepeatedField<Types.GardenStallSlot> repeatedField = (gardenStallData.slots_ = (RepeatedField<Types.GardenStallSlot>)(object)new RepeatedField<T>());
			UpgradeState upgradeState = upgradeState_;
			if (upgradeState != null)
			{
				UpgradeState upgradeState2 = upgradeState.Clone();
			}
			int num = 0;
			gardenStallData.upgradeState_ = (UpgradeState)num;
			RepeatedField<Types.GardenStallSlot> repeatedField2 = (gardenStallData.slots_ = (RepeatedField<Types.GardenStallSlot>)(object)((RepeatedField<T>)(object)slots_).Clone());
			UnknownFieldSet unknownFieldSet = (gardenStallData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gardenStallData;
		}

		[Cpp2IlInjected.Token(Token = "0x600614E")]
		[Cpp2IlInjected.Address(RVA = "0x21920E0", Offset = "0x2190AE0", VA = "0x1821920E0", Slot = "0")]
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
				if (object.Equals(upgradeState_, other))
				{
					RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600614F")]
		[Cpp2IlInjected.Address(RVA = "0x2192030", Offset = "0x2190A30", VA = "0x182192030", Slot = "12")]
		[DebuggerNonUserCode]
		public bool Equals(GardenStallData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				UpgradeState objB = other.upgradeState_;
				if (object.Equals(upgradeState_, objB))
				{
					RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
					RepeatedField<Types.GardenStallSlot> repeatedField2 = other.slots_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006150")]
		[Cpp2IlInjected.Address(RVA = "0xC052E0", Offset = "0xC03CE0", VA = "0x180C052E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0033
			UpgradeState upgradeState = upgradeState_;
			if (upgradeState != null)
			{
				int hashCode = upgradeState.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)slots_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006151")]
		[Cpp2IlInjected.Address(RVA = "0x2192AE0", Offset = "0x21914E0", VA = "0x182192AE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006152")]
		[Cpp2IlInjected.Address(RVA = "0x2192B40", Offset = "0x2191540", VA = "0x182192B40", Slot = "9")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if ((long)upgradeState_ != 0)
			{
				UpgradeState value = upgradeState_;
				output.WriteMessage(value);
			}
			RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
			FieldCodec<Types.GardenStallSlot> repeated_slots_codec = _repeated_slots_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_slots_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006153")]
		[Cpp2IlInjected.Address(RVA = "0x2191D50", Offset = "0x2190750", VA = "0x182191D50", Slot = "10")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			UpgradeState upgradeState = upgradeState_;
			int num = 0;
			if (upgradeState != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(upgradeState);
			}
			RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
			FieldCodec<Types.GardenStallSlot> repeated_slots_codec = _repeated_slots_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_slots_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006154")]
		[Cpp2IlInjected.Address(RVA = "0x2192920", Offset = "0x2191320", VA = "0x182192920", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(GardenStallData other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			if ((long)other.upgradeState_ != 0)
			{
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState == null)
				{
					UpgradeState upgradeState2 = (upgradeState_ = new UpgradeState());
				}
				UpgradeState other2 = other.upgradeState_;
				upgradeState.MergeFrom(other2);
			}
			RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
			RepeatedField<Types.GardenStallSlot> repeatedField2 = other.slots_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6006155")]
		[Cpp2IlInjected.Address(RVA = "0x21927C0", Offset = "0x21911C0", VA = "0x1821927C0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0065
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState == null)
				{
					UpgradeState upgradeState2 = (upgradeState_ = new UpgradeState());
				}
				input.ReadMessage(upgradeState);
			}
			if (num == 18)
			{
				RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
				FieldCodec<Types.GardenStallSlot> repeated_slots_codec = _repeated_slots_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slots_codec);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006156")]
		[Cpp2IlInjected.Address(RVA = "0x2192730", Offset = "0x2191130", VA = "0x182192730", Slot = "14")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				UpgradeState upgradeState = upgradeState_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006157")]
		[Cpp2IlInjected.Address(RVA = "0x2192A10", Offset = "0x2191410", VA = "0x182192A10", Slot = "15")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					upgradeState_ = (UpgradeState)num;
					return;
				}
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006158")]
		[Cpp2IlInjected.Address(RVA = "0x2191E50", Offset = "0x2190850", VA = "0x182191E50", Slot = "16")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<Types.GardenStallSlot> repeatedField = slots_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006159")]
		[Cpp2IlInjected.Address(RVA = "0x2192C30", Offset = "0x2191630", VA = "0x182192C30")]
		static GardenStallData()
		{
			Func<GardenStallData> func = default(Func<GardenStallData>);
			_parser = (MessageParser<GardenStallData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.GardenStallSlot> parser = Types.GardenStallSlot._parser;
			uint num = default(uint);
			_parser = (MessageParser<GardenStallData>)(object)FieldCodec.ForMessage<Types.GardenStallSlot>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600615A")]
		[Cpp2IlInjected.Address(RVA = "0x2192020", Offset = "0x2190A20", VA = "0x182192020", Slot = "6")]
		GridStateDailyResetResult IGridStateDailyResetNotify.ExecuteDailyReset(Item item, in WorldProfile worldProfile, Random random, ITransactionContext context)
		{
			GridStateDailyResetResult result = default(GridStateDailyResetResult);
			return result;
		}
	}
}
