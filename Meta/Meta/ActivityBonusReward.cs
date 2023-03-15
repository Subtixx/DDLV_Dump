using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000894")]
	public sealed class ActivityBonusReward : IMessage<ActivityBonusReward>, IMessage, IEquatable<ActivityBonusReward>, IDeepCloneable<ActivityBonusReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400227E")]
		private static readonly MessageParser<ActivityBonusReward> _parser = (MessageParser<ActivityBonusReward>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ActivityBonusReward()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400227F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002280")]
		private const string RandomSeedName = "ActivityBonusReward";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002282")]
		private Player player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002283")]
		private World world;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002284")]
		private ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002285")]
		private ActivityBonusRewardData activityBonusRewardData;

		[Cpp2IlInjected.Token(Token = "0x17000C22")]
		[DebuggerNonUserCode]
		public static MessageParser<ActivityBonusReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60048D4")]
			[Cpp2IlInjected.Address(RVA = "0x18E4970", Offset = "0x18E3370", VA = "0x1818E4970")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C23")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048D5")]
			[Cpp2IlInjected.Address(RVA = "0x18E48A0", Offset = "0x18E32A0", VA = "0x1818E48A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C24")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048D6")]
			[Cpp2IlInjected.Address(RVA = "0x18E4AD0", Offset = "0x18E34D0", VA = "0x1818E4AD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C25")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002281")]
		public bool Force
		{
			[Cpp2IlInjected.Token(Token = "0x60048E5")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60048E6")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000C26")]
		private ProfileEventDispatcher playerDispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x60048E7")]
			[Cpp2IlInjected.Address(RVA = "0x18E49D0", Offset = "0x18E33D0", VA = "0x1818E49D0")]
			get
			{
				if (player.dispatcher == null)
				{
					int num = 0;
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C27")]
		private ProfileEventDispatcher worldDispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x60048E8")]
			[Cpp2IlInjected.Address(RVA = "0x18E4A50", Offset = "0x18E3450", VA = "0x1818E4A50")]
			get
			{
				if (world.dispatcher == null)
				{
					int num = 0;
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048D7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActivityBonusReward()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60048D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ActivityBonusReward(ActivityBonusReward other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048D9")]
		[Cpp2IlInjected.Address(RVA = "0x18E3600", Offset = "0x18E2000", VA = "0x1818E3600", Slot = "10")]
		[DebuggerNonUserCode]
		public ActivityBonusReward Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ActivityBonusReward activityBonusReward = default(ActivityBonusReward);
			activityBonusReward.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (activityBonusReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return activityBonusReward;
		}

		[Cpp2IlInjected.Token(Token = "0x60048DA")]
		[Cpp2IlInjected.Address(RVA = "0x18E3680", Offset = "0x18E2080", VA = "0x1818E3680", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActivityBonusReward other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048DC")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60048DD")]
		[Cpp2IlInjected.Address(RVA = "0x18E4170", Offset = "0x18E2B70", VA = "0x1818E4170", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60048DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60048DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60048E0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActivityBonusReward other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048E1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048E2")]
		[Cpp2IlInjected.Address(RVA = "0x18E3700", Offset = "0x18E2100", VA = "0x1818E3700", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60048E4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60048E9")]
		[Cpp2IlInjected.Address(RVA = "0x18E3770", Offset = "0x18E2170", VA = "0x1818E3770")]
		internal void Initialize(in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00a2
			this.context = context;
			ProfileEventDispatcher profileEventDispatcher = worldDispatcher;
			ProfileEventDispatcher.GardeningEvent value = OnGardeningEvent;
			profileEventDispatcher.OnGardeningEvent += value;
			ProfileEventDispatcher profileEventDispatcher2 = worldDispatcher;
			ProfileEventDispatcher.FlowerEvent value2 = OnFlowerEvent;
			profileEventDispatcher2.OnFlowerEvent += value2;
			ProfileEventDispatcher profileEventDispatcher3 = playerDispatcher;
			ProfileEventDispatcher.FishingResultReceived value3 = OnFishingResultReceived;
			profileEventDispatcher3.OnFishingResultReceived += value3;
			ProfileEventDispatcher profileEventDispatcher4 = playerDispatcher;
			ProfileEventDispatcher.MealCooked value4 = OnMealCooked;
			profileEventDispatcher4.OnMealCooked += value4;
			ProfileEventDispatcher profileEventDispatcher5 = worldDispatcher;
			ProfileEventDispatcher.MiningRockEmptied value5 = OnMiningRockEmptied;
			profileEventDispatcher5.OnMiningRockEmptied += value5;
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
		}

		[Cpp2IlInjected.Token(Token = "0x60048EA")]
		[Cpp2IlInjected.Address(RVA = "0x18E3C80", Offset = "0x18E2680", VA = "0x1818E3C80")]
		private void OnGardeningEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_0065
			RepeatedField<ActivityBonusRewardData.Types.HarvestData> harvest_ = activityBonusRewardData.harvest_;
			Func<ActivityBonusRewardData.Types.HarvestData, bool> func = (Func<ActivityBonusRewardData.Types.HarvestData, bool>)(object)(Func<T, TResult>)delegate(ActivityBonusRewardData.Types.HarvestData x)
			{
				if ((object)x.SpecificGardenItem != null)
				{
					return true;
				}
				Item specificGardenItem = x.SpecificGardenItem;
				int itemID = gridObject.ItemID;
				throw new NullReferenceException();
			};
			IEnumerable<ActivityBonusRewardData.Types.HarvestData> enumerable = (IEnumerable<ActivityBonusRewardData.Types.HarvestData>)Enumerable.Where<ActivityBonusRewardData.Types.HarvestData>((IEnumerable<>)(object)harvest_, (Func<, >)(object)func);
			Func<ActivityBonusRewardData.Types.HarvestData, ActivityBonusRewardData.Types.Data> _003C_003E9__37_ = _003C_003Ec._003C_003E9__37_1;
			if (_003C_003E9__37_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ActivityBonusRewardData.Types.HarvestData x) => x.data_);
			}
			if (Enumerable.Select<ActivityBonusRewardData.Types.HarvestData, ActivityBonusRewardData.Types.Data>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__37_).ToArray<ActivityBonusRewardData.Types.Data>().Length == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048EB")]
		[Cpp2IlInjected.Address(RVA = "0x18E3BB0", Offset = "0x18E25B0", VA = "0x1818E3BB0")]
		private void OnFlowerEvent(IGrid grid, GridObject gridObject, FlowerOperation operation, bool automatic, bool wasDry)
		{
			//Discarded unreachable code: IL_0036
			if (operation == FlowerOperation.Water && ((RepeatedField<T>)(object)activityBonusRewardData.waterFlowers_).Count > 0)
			{
				RepeatedField<ActivityBonusRewardData.Types.Data> waterFlowers_ = activityBonusRewardData.waterFlowers_;
				GridPosition position = gridObject.Position;
				this.TryToSpawnBonusReward((IEnumerable<>)(object)waterFlowers_, RewardAppearanceCondition.WateringFlowers, grid, position);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048EC")]
		[Cpp2IlInjected.Address(RVA = "0x18E3A90", Offset = "0x18E2490", VA = "0x1818E3A90")]
		private unsafe void OnFishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_004d
			//IL_004c: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			int num = 0;
			if (success && ((RepeatedField<T>)(object)activityBonusRewardData.fishing_).Count > 0)
			{
				Player player = this.player;
				bool flag = default(bool);
				ProfileWorld profileWorld = default(ProfileWorld);
				if (flag && profileWorld.gridCollection_.TryGetGrid((uint)num, out *(IGrid*)num))
				{
					RepeatedField<ActivityBonusRewardData.Types.Data> fishing_ = activityBonusRewardData.fishing_;
					this.TryToSpawnBonusReward((IEnumerable<>)(object)fishing_, RewardAppearanceCondition.Fishing, (IGrid)num, (GridPosition)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048ED")]
		[Cpp2IlInjected.Address(RVA = "0x18E3F10", Offset = "0x18E2910", VA = "0x1818E3F10")]
		private unsafe void OnMealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene)
		{
			//Discarded unreachable code: IL_0058
			//IL_0057: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			int num = 0;
			ItemType itemType = default(ItemType);
			ActivityItemType activityItemType = default(ActivityItemType);
			if (itemType == ItemType.ActivityItem && activityItemType == ActivityItemType.Meal && ingredients != null && ((RepeatedField<T>)(object)activityBonusRewardData.cooking_).Count > 0)
			{
				Player player = this.player;
				bool flag = default(bool);
				ProfileWorld profileWorld = default(ProfileWorld);
				if (flag && profileWorld.gridCollection_.TryGetGrid((uint)num, out *(IGrid*)num))
				{
					RepeatedField<ActivityBonusRewardData.Types.Data> cooking_ = activityBonusRewardData.cooking_;
					this.TryToSpawnBonusReward((IEnumerable<>)(object)cooking_, RewardAppearanceCondition.Cooking, (IGrid)num, (GridPosition)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048EE")]
		[Cpp2IlInjected.Address(RVA = "0x18E4080", Offset = "0x18E2A80", VA = "0x1818E4080")]
		private unsafe void OnMiningRockEmptied(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_0049
			//IL_0048: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			Player player = this.player;
			int num = 0;
			bool flag = default(bool);
			ProfileWorld profileWorld = default(ProfileWorld);
			if (flag && profileWorld.gridCollection_.TryGetGrid((uint)num, out *(IGrid*)num) && ((RepeatedField<T>)(object)activityBonusRewardData.mining_).Count > 0)
			{
				RepeatedField<ActivityBonusRewardData.Types.Data> mining_ = activityBonusRewardData.mining_;
				this.TryToSpawnBonusReward((IEnumerable<>)(object)mining_, RewardAppearanceCondition.Mining, (IGrid)num, (GridPosition)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048EF")]
		[Cpp2IlInjected.Address(RVA = "0x18E41D0", Offset = "0x18E2BD0", VA = "0x1818E41D0")]
		private void TryToSpawnBonusReward(IEnumerable<ActivityBonusRewardData.Types.Data> dataList, RewardAppearanceCondition rewardAppearanceCondition, IGrid grid, GridPosition gridPosition)
		{
			//Discarded unreachable code: IL_00d7, IL_00dd, IL_00e3, IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d, IL_0113, IL_0119, IL_011f, IL_0125, IL_012b
			//IL_0054: Expected O, but got I4
			Random random;
			ProfilePlayer profilePlayer = default(ProfilePlayer);
			uint num4 = default(uint);
			uint maxValue = default(uint);
			LootTableItemData lootTableItemData = default(LootTableItemData);
			MultiReward multiReward = default(MultiReward);
			AddRemoveItemResult addRemoveItemResult = default(AddRemoveItemResult);
			int amount_ = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				random = new Random(profilePlayer.GetRandomSeed("ActivityBonusReward"));
				if (random == null)
				{
					break;
				}
				if (num3 < (int)num4)
				{
					num3 += num3;
					if (num3 == (int)num4)
					{
						goto IL_00be;
					}
					num3++;
				}
				int num5 = random.Next((int)maxValue);
				LootTable rewards_ = lootTableItemData.rewards_;
				new RewardGenerationParameters().RewardAppearanceCondition = (RewardAppearanceCondition?)(object)num3;
				if (((RepeatedField<T>)(object)multiReward.rewards_).Count <= 0)
				{
					continue;
				}
				RepeatedField<AnyReward> rewards_2 = multiReward.rewards_;
				int index = 0;
				ItemReward item = ((AnyReward)((RepeatedField<T>)(object)rewards_2)[index]).Item;
				if (item == null)
				{
					int num6 = 0;
					Item item2 = item.Item;
					ItemState state_ = item.state_;
					if (addRemoveItemResult == AddRemoveItemResult.Success)
					{
						continue;
					}
				}
				int itemID = item.Item.ItemID;
				amount_ = item.amount_;
				goto IL_00be;
				IL_00be:
				amount_ += amount_;
				break;
			}
			if (random != null)
			{
			}
			ProfilePlayer profilePlayer2 = default(ProfilePlayer);
			profilePlayer2.AdvanceRandomSeed("ActivityBonusReward");
		}

		[Cpp2IlInjected.Token(Token = "0x60048F0")]
		[Cpp2IlInjected.Address(RVA = "0x18E4790", Offset = "0x18E3190", VA = "0x1818E4790")]
		static ActivityBonusReward()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
