using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Localization.Core;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;
using Meta.Missions;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010BE")]
	public sealed class DutySlot : IMessage<DutySlot>, IMessage, IEquatable<DutySlot>, IDeepCloneable<DutySlot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40044F8")]
		private ProfileEventDispatcher Dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40044F9")]
		private Profile Profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40044FA")]
		private ITransactionContext Context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40044FB")]
		private RoyalDutyItemData dutyData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40044FC")]
		private DutyStepDifficulty dutyStepData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40044FD")]
		private RoyalDutySlotStringResolver _stringResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40044FE")]
		private bool isStarted;

		[Cpp2IlInjected.Token(Token = "0x40044FF")]
		private static readonly MessageParser<DutySlot> _parser = (MessageParser<DutySlot>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new DutySlot()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004500")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004501")]
		public const int SlotIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004502")]
		private int slotId_;

		[Cpp2IlInjected.Token(Token = "0x4004503")]
		public const int DutyIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4004504")]
		private int dutyId_;

		[Cpp2IlInjected.Token(Token = "0x4004505")]
		public const int StepDataFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004506")]
		private DutyStepData stepData_;

		[Cpp2IlInjected.Token(Token = "0x4004507")]
		public const int StateFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004508")]
		private DutySlotState state_;

		[Cpp2IlInjected.Token(Token = "0x4004509")]
		public const int DutyNameFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400450A")]
		private string dutyName_ = "";

		[Cpp2IlInjected.Token(Token = "0x400450B")]
		public const int StartTimeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400450C")]
		private Timestamp startTime_;

		[Cpp2IlInjected.Token(Token = "0x400450D")]
		public const int ExpiresFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400450E")]
		private bool expires_;

		[Cpp2IlInjected.Token(Token = "0x400450F")]
		public const int DifficultyLayerFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4004510")]
		private int difficultyLayer_;

		[Cpp2IlInjected.Token(Token = "0x4004511")]
		public const int ItemsUsedFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4004512")]
		private static readonly FieldCodec<int> _repeated_itemsUsed_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4004513")]
		private readonly RepeatedField<int> itemsUsed_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001793")]
		[DebuggerNonUserCode]
		public static MessageParser<DutySlot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008803")]
			[Cpp2IlInjected.Address(RVA = "0x1749710", Offset = "0x1748110", VA = "0x181749710")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001794")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008804")]
			[Cpp2IlInjected.Address(RVA = "0x1749640", Offset = "0x1748040", VA = "0x181749640")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001795")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008805")]
			[Cpp2IlInjected.Address(RVA = "0x1749770", Offset = "0x1748170", VA = "0x181749770", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001796")]
		[DebuggerNonUserCode]
		public int SlotId
		{
			[Cpp2IlInjected.Token(Token = "0x6008809")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return slotId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600880A")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				slotId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001797")]
		[DebuggerNonUserCode]
		public int DutyId
		{
			[Cpp2IlInjected.Token(Token = "0x600880B")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return dutyId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600880C")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				dutyId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001798")]
		[DebuggerNonUserCode]
		public DutyStepData StepData
		{
			[Cpp2IlInjected.Token(Token = "0x600880D")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return stepData_;
			}
			[Cpp2IlInjected.Token(Token = "0x600880E")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				stepData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001799")]
		[DebuggerNonUserCode]
		public DutySlotState State
		{
			[Cpp2IlInjected.Token(Token = "0x600880F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008810")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179A")]
		[DebuggerNonUserCode]
		public string DutyName
		{
			[Cpp2IlInjected.Token(Token = "0x6008811")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return dutyName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008812")]
			[Cpp2IlInjected.Address(RVA = "0x1749880", Offset = "0x1748280", VA = "0x181749880")]
			set
			{
				string text = (dutyName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179B")]
		[DebuggerNonUserCode]
		public Timestamp StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6008813")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return startTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008814")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				startTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179C")]
		[DebuggerNonUserCode]
		public bool Expires
		{
			[Cpp2IlInjected.Token(Token = "0x6008815")]
			[Cpp2IlInjected.Address(RVA = "0xAE8610", Offset = "0xAE7010", VA = "0x180AE8610")]
			get
			{
				return expires_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008816")]
			[Cpp2IlInjected.Address(RVA = "0xBCC430", Offset = "0xBCAE30", VA = "0x180BCC430")]
			set
			{
				expires_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179D")]
		[DebuggerNonUserCode]
		public int DifficultyLayer
		{
			[Cpp2IlInjected.Token(Token = "0x6008817")]
			[Cpp2IlInjected.Address(RVA = "0xAE8600", Offset = "0xAE7000", VA = "0x180AE8600")]
			get
			{
				return difficultyLayer_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008818")]
			[Cpp2IlInjected.Address(RVA = "0x1525600", Offset = "0x1524000", VA = "0x181525600")]
			set
			{
				difficultyLayer_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179E")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6008819")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return itemsUsed_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087CE")]
		[Cpp2IlInjected.Address(RVA = "0x1748EA0", Offset = "0x17478A0", VA = "0x181748EA0")]
		public RoyalDutySlotStringResolver StringResolver(Localizator localizator)
		{
			RoyalDutySlotStringResolver stringResolver = _stringResolver;
			if (stringResolver == null)
			{
				RoyalDutySlotStringResolver royalDutySlotStringResolver = (_stringResolver = new RoyalDutySlotStringResolver(this, localizator));
			}
			return stringResolver;
		}

		[Cpp2IlInjected.Token(Token = "0x60087CF")]
		[Cpp2IlInjected.Address(RVA = "0x1747640", Offset = "0x1746040", VA = "0x181747640")]
		internal void Start(Profile profile, ITransactionContext context, IPlayerEventDispatcher dispatcher, bool generated = false)
		{
			//Discarded unreachable code: IL_042a
			//IL_00e1: Expected I4, but got I8
			//IL_0429: Expected O, but got I4
			if (isStarted)
			{
				return;
			}
			isStarted = true;
			if (dispatcher == null)
			{
			}
			int num = 0;
			Dispatcher = (ProfileEventDispatcher)dispatcher;
			Profile = profile;
			Context = context;
			if (dutyId_ != 0)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
			dutyData = royalDutyItemData;
			RoyalDutyItemData royalDutyItemData2 = dutyData;
			if (royalDutyItemData2 == null)
			{
				return;
			}
			int count = ((RepeatedField<T>)(object)royalDutyItemData2.stepDifficultyLayers_).Count;
			int num2 = difficultyLayer_;
			if (count <= num2)
			{
				return;
			}
			DutyStepDifficulty dutyStepDifficulty = (dutyStepData = (DutyStepDifficulty)((RepeatedField<T>)(object)dutyData.stepDifficultyLayers_)[num2]);
			DutySlotState dutySlotState = state_;
			if ((long)dutyStepDifficulty <= 1 || dutySlotState == DutySlotState.None || (long)Dispatcher == 0 || (long)Profile == 0 || (long)Context == 0)
			{
				return;
			}
			if (dutySlotState == DutySlotState.NotStarted)
			{
				state_ = DutySlotState.OnGoing;
			}
			DutyStepDifficulty dutyStepDifficulty2 = dutyStepData;
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.ItemsGivenToCharacter value = OnItemsGiven;
			dispatcher2.OnItemsGivenToCharacter += value;
			ProfileEventDispatcher dispatcher3 = Dispatcher;
			ProfileEventDispatcher.FishingResultReceived value2 = OnCatchFish;
			dispatcher3.OnFishingResultReceived += value2;
			ProfileEventDispatcher dispatcher4 = Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value3 = OnCurrencyChanged;
			dispatcher4.OnCurrencyChanged += value3;
			ProfileEventDispatcher dispatcher5 = Dispatcher;
			ProfileEventDispatcher.MealCooked value4 = OnCookMeal;
			dispatcher5.OnMealCooked += value4;
			ProfileEventDispatcher dispatcher6 = Dispatcher;
			ProfileEventDispatcher.GardeningEvent value5 = OnGardeningHarvest;
			dispatcher6.OnGardeningEvent += value5;
			ProfileEventDispatcher dispatcher7 = Dispatcher;
			ProfileEventDispatcher.GardeningEvent value6 = OnGardeningPlant;
			dispatcher7.OnGardeningEvent += value6;
			ProfileEventDispatcher dispatcher8 = Dispatcher;
			ProfileEventDispatcher.GridChanged value7 = OnPickup;
			dispatcher8.OnGridChanged += value7;
			ProfileEventDispatcher dispatcher9 = Dispatcher;
			ProfileEventDispatcher.GardeningEvent value8 = OnPickupFromHarvest;
			dispatcher9.OnGardeningEvent += value8;
			ProfileEventDispatcher dispatcher10 = Dispatcher;
			ProfileEventDispatcher.ShopItemsSold value9 = OnShopItemsSold;
			dispatcher10.OnShopItemsSold += value9;
			ProfileEventDispatcher dispatcher11 = Dispatcher;
			ProfileEventDispatcher.PictureTaken value10 = OnPictureTaken;
			dispatcher11.OnPictureTaken += value10;
			ProfileEventDispatcher dispatcher12 = Dispatcher;
			ProfileEventDispatcher.AvatarCustomizationChanged value11 = OnDressUp;
			dispatcher12.OnAvatarCustomizationChanged += value11;
			ProfileEventDispatcher dispatcher13 = Dispatcher;
			ProfileEventDispatcher.ItemsGivenToCharacter value12 = OnGiftGivenToCharacter;
			dispatcher13.OnItemsGivenToCharacter += value12;
			ProfileEventDispatcher dispatcher14 = Dispatcher;
			ProfileEventDispatcher.DiscussionEnded value13 = OnDiscussionEnded;
			dispatcher14.OnDiscussionEnded += value13;
			ProfileEventDispatcher dispatcher15 = Dispatcher;
			ProfileEventDispatcher.MiningRockEmptied value14 = OnMiningMineral;
			dispatcher15.OnMiningRockEmptied += value14;
			ProfileEventDispatcher.FlowerEvent flowerEvent = default(ProfileEventDispatcher.FlowerEvent);
			if (dutyStepData.WaterPlant.plantTypesCase_ == CustomStepWaterPlant.PlantTypesOneofCase.FlowerItem)
			{
				ProfileEventDispatcher dispatcher16 = Dispatcher;
				flowerEvent = OnWaterFlowerResultReceived;
				dispatcher16.OnFlowerEvent += flowerEvent;
			}
			if ((long)flowerEvent == 2)
			{
				ProfileEventDispatcher dispatcher17 = Dispatcher;
				ProfileEventDispatcher.GardeningEvent value15 = OnWaterCropResultReceived;
				dispatcher17.OnGardeningEvent += value15;
				ProfileEventDispatcher dispatcher18 = Dispatcher;
				ProfileEventDispatcher.CritterFed value16 = OnCritterFed;
				dispatcher18.OnCritterFed += value16;
				ProfileEventDispatcher dispatcher19 = Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value17 = OnCharacterUnlocked;
				dispatcher19.OnCharacterUnlocked += value17;
				ProfileEventDispatcher dispatcher20 = Dispatcher;
				ProfileEventDispatcher.CharacterFriendshipLevelChanged value18 = OnCharacterFriendshipLevelChanged;
				dispatcher20.OnCharacterFriendshipLevelChanged += value18;
				DutyStepDifficulty dutyStepDifficulty3 = dutyStepData;
				if (dutyStepDifficulty3 != null)
				{
					CustomStepUpgrade upgrade = dutyStepDifficulty3.Upgrade;
					if (upgrade != null)
					{
						CustomStepUpgrade.TargetOneofCase targetCase_ = upgrade.targetCase_;
						if ((long)dutyStepDifficulty3 <= 1)
						{
							ProfileEventDispatcher dispatcher21 = Dispatcher;
							ProfileEventDispatcher.BuidingUpgraded value19 = OnBuidingUpgraded;
							dispatcher21.OnBuidingUpgraded += value19;
							if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any)
							{
							}
							Item buildingItem = upgrade.BuildingItem;
						}
						if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any || upgrade.targetCase_ == CustomStepUpgrade.TargetOneofCase.PlayerLevel)
						{
							ProfileEventDispatcher dispatcher22 = Dispatcher;
							ProfileEventDispatcher.PlayerLevelGained value20 = OnPlayerLevelGained;
							dispatcher22.OnPlayerLevelGained += value20;
							CheckPlayerLevelCompletion();
							StartUnlockBuilding();
							int num3 = 0;
							StartExpandHouse();
							if (num3 == 56)
							{
								ProfileEventDispatcher dispatcher23 = Dispatcher;
								ProfileEventDispatcher.RestaurantOrderFulfilled value21 = OnRestaurantOrderFulfilled;
								dispatcher23.OnRestaurantOrderFulfilled += value21;
							}
						}
					}
				}
			}
			int num4 = 0;
			int num5 = 0;
			this.CheckForCompletion((List<>)num5, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60087D0")]
		[Cpp2IlInjected.Address(RVA = "0x1748370", Offset = "0x1746D70", VA = "0x181748370")]
		public void Stop()
		{
			//Discarded unreachable code: IL_0055, IL_0064, IL_0073, IL_0082, IL_0091, IL_00a0, IL_00ce, IL_00dd, IL_00ec, IL_00fb, IL_010a, IL_0119, IL_0128, IL_0167, IL_0176, IL_01a4, IL_01d2, IL_025d, IL_02c6
			if (!isStarted)
			{
				return;
			}
			ProfileEventDispatcher dispatcher = Dispatcher;
			isStarted = false;
			if (dispatcher == null)
			{
				return;
			}
			DutyStepDifficulty dutyStepDifficulty = dutyStepData;
			if (dutyStepDifficulty != null)
			{
				DutyStepDifficulty.DifficultyStepOneofCase difficultyStepCase_ = dutyStepDifficulty.difficultyStepCase_;
				if ((long)dutyStepDifficulty <= 20)
				{
					ProfileEventDispatcher.ItemsGivenToCharacter value = OnItemsGiven;
					dispatcher.OnItemsGivenToCharacter -= value;
				}
				else if (difficultyStepCase_ == DutyStepDifficulty.DifficultyStepOneofCase.ServeRestaurantOrder)
				{
					ProfileEventDispatcher.RestaurantOrderFulfilled value2 = OnRestaurantOrderFulfilled;
					dispatcher.OnRestaurantOrderFulfilled -= value2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087D1")]
		[Cpp2IlInjected.Address(RVA = "0x1747520", Offset = "0x1745F20", VA = "0x181747520")]
		private void StartWaterPlant()
		{
			//Discarded unreachable code: IL_0053
			CustomStepWaterPlant.PlantTypesOneofCase plantTypesCase_ = dutyStepData.WaterPlant.plantTypesCase_;
			if (plantTypesCase_ == CustomStepWaterPlant.PlantTypesOneofCase.FlowerItem)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.FlowerEvent value = OnWaterFlowerResultReceived;
				dispatcher.OnFlowerEvent += value;
				return;
			}
			while (plantTypesCase_ != CustomStepWaterPlant.PlantTypesOneofCase.CropItem)
			{
			}
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.GardeningEvent value2 = OnWaterCropResultReceived;
			dispatcher2.OnGardeningEvent += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x60087D2")]
		[Cpp2IlInjected.Address(RVA = "0x1748290", Offset = "0x1746C90", VA = "0x181748290")]
		private void StopWaterPlant()
		{
			//Discarded unreachable code: IL_0037
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.GardeningEvent value = OnWaterCropResultReceived;
			dispatcher.OnGardeningEvent -= value;
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.FlowerEvent value2 = OnWaterFlowerResultReceived;
			dispatcher2.OnFlowerEvent -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x60087D3")]
		[Cpp2IlInjected.Address(RVA = "0x1746550", Offset = "0x1744F50", VA = "0x181746550")]
		private void OnWaterCropResultReceived(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_0096
			//IL_007b: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			GridState gridState = gridObject.state_;
			if (gridState == null)
			{
				return;
			}
			GardenData gardenData = gridState.GardenData;
			if (gardenData != null && Enumerable.ElementAt<GardenData.Types.GardeningSlot>((IEnumerable<>)(object)gardenData.slots_, slotIndex) != null)
			{
				Item plantedSeedItem = Enumerable.ElementAt<GardenData.Types.GardeningSlot>((IEnumerable<>)(object)gridObject.state_.GardenData.slots_, slotIndex).PlantedSeedItem;
				SeedItemData seedItemData = default(SeedItemData);
				if (seedItemData != null)
				{
					Item producedItem = seedItemData.ProducedItem;
				}
				Item invalid = Item.Invalid;
				bool flag = default(bool);
				if (flag)
				{
					ItemFilter itemFilter_ = stepData_.itemFilter_;
					int num = 0;
					int itemQuantity = itemFilter_.GetItemQuantity(invalid, 1, (ItemState)num);
					DutyStepData dutyStepData = stepData_;
				}
				int num2 = 0;
				int num3 = 0;
				this.CheckForCompletion((List<>)num3, (byte)num2 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087D4")]
		[Cpp2IlInjected.Address(RVA = "0x1746780", Offset = "0x1745180", VA = "0x181746780")]
		private void OnWaterFlowerResultReceived(IGrid grid, GridObject gridObject, FlowerOperation operation, bool automatic, bool wasDry)
		{
			//Discarded unreachable code: IL_003d
			//IL_003c: Expected O, but got I4
			if (operation == FlowerOperation.Water && gridObject != null)
			{
				int itemID = gridObject.ItemID;
				ItemType itemType = default(ItemType);
				ActivityItemType activityItemType = default(ActivityItemType);
				if (itemType == ItemType.ActivityItem && activityItemType == ActivityItemType.Flower)
				{
					ItemFilter itemFilter_ = stepData_.itemFilter_;
					DutyStepData dutyStepData = stepData_;
					int num = 0;
					int num2 = 0;
					this.CheckForCompletion((List<>)num2, (byte)num != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087D5")]
		[Cpp2IlInjected.Address(RVA = "0x17446E0", Offset = "0x17430E0", VA = "0x1817446E0")]
		private void OnDiscussionEnded(Item characterItem)
		{
			//Discarded unreachable code: IL_00da
			//IL_0053: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_009e: Expected I4, but got I8
			int itemID = characterItem.ItemID;
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null || dutyStepDifficulty.StartDiscussion == null)
			{
				return;
			}
			CustomStepStartDiscussion startDiscussion = this.dutyStepData.StartDiscussion;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (this.dutyStepData.StartDiscussion.useDifferentCharacter_)
			{
				bool flag2 = ((RepeatedField<T>)(object)itemsUsed_).Contains((T)itemID);
				bool flag3 = !flag2;
				if (!flag2)
				{
					((RepeatedField<T>)(object)itemsUsed_).Add((T)itemID);
				}
				if (!flag3)
				{
					goto IL_007a;
				}
			}
			DutyStepData dutyStepData = stepData_;
			goto IL_007a;
			IL_007a:
			int targetAmount_ = stepData_.targetAmount_;
			Stop();
			Profile profile = Profile;
			state_ = DutySlotState.Completed;
			if (profile != null)
			{
				ProfilePlayer player_ = profile.player_;
				ITransactionContext context = Context;
				RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
				int dutyID = dutyId_;
				royalDutyProgress.IncrementDailyDutyProgress(dutyID);
			}
			if (Dispatcher == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087D6")]
		[Cpp2IlInjected.Address(RVA = "0x17435F0", Offset = "0x1741FF0", VA = "0x1817435F0")]
		private void Init(Profile profile, RoyalDutyItemData dutyData, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0143
			//IL_00eb: Expected O, but got I4
			//IL_012d: Expected O, but got I4
			if (dutyData == null)
			{
				return;
			}
			int num = (difficultyLayer_ = profile.player_.GetRoyalDutyProgress(context).IncDifficultyLayerLevel(dutyData));
			if ((long)stepData_ == 0)
			{
				DutyStepData dutyStepData = (stepData_ = new DutyStepData());
			}
			int num2 = (dutyId_ = dutyData.ID);
			string text = (dutyName_ = ProtoPreconditions.CheckNotNull(dutyData.name_, "value"));
			int count = ((RepeatedField<T>)(object)dutyData.stepDifficultyLayers_).Count;
			int num3 = difficultyLayer_;
			int num4 = 0;
			if (count > num3)
			{
				DutyStepDifficulty dutyStepDifficulty = (DutyStepDifficulty)((RepeatedField<T>)(object)dutyData.stepDifficultyLayers_)[num3];
				Random random = new Random(profile.player_.GetRandomSeed("DutyRandomSeed"));
				DutyStepData dutyStepData2 = stepData_;
				ItemFilter itemFilter = (dutyStepData2.itemFilter_ = GetItemFilter(dutyStepDifficulty, random, profile));
				DutyStepData dutyStepData3 = stepData_;
				StepAmount stepAmount = dutyStepDifficulty.StepAmount;
				if (stepAmount != null)
				{
					int num5 = 0;
					int amount = stepAmount.GetAmount(random, 1, (Func<, >)num5, (byte)num4 != 0);
				}
				uint targetAmount_ = default(uint);
				dutyStepData3.targetAmount_ = (int)targetAmount_;
				profile.player_.AdvanceRandomSeed("DutyRandomSeed");
			}
			stepData_.curAmount_ = num4;
			uint num6 = default(uint);
			if (num4 < (int)num6)
			{
				num4 += num4;
				num4++;
			}
			Timestamp timestamp = (startTime_ = ((DateTime)num4).ToTimestamp());
			((RepeatedField<T>)(object)itemsUsed_).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60087D7")]
		[Cpp2IlInjected.Address(RVA = "0x1742F00", Offset = "0x1741900", VA = "0x181742F00")]
		private ItemFilter GetItemFilter(DutyStepDifficulty dutyStepData, Random random, Profile profile)
		{
			//Discarded unreachable code: IL_009c
			//IL_0023: Expected O, but got I4
			//IL_0037: Expected I4, but got I8
			//IL_0075: Expected I4, but got O
			int num = 0;
			ItemSelector itemSelector = dutyStepData.ItemSelector;
			string arg = dutyName_;
			int num2 = difficultyLayer_;
			string debugName = $"DutySlot:{arg}, Difficulty:{num2}";
			int onlySeedCrop = 0;
			ulong num3 = default(ulong);
			ItemFilter itemFilter = ItemFilter.New(itemSelector, profile, random, (byte)onlySeedCrop != 0, (byte)num != 0, (byte)num3 != 0, debugName);
			int num4 = 0;
			IUniqueItem getIUniqueItem = dutyStepData.GetIUniqueItem;
			if ((IntPtr)itemFilter.data_ == (IntPtr)num && getIUniqueItem != null)
			{
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					num++;
				}
				bool flag = default(bool);
				if (flag)
				{
					ItemFilterData itemFilterData = new ItemFilterData();
					itemFilterData.item_ = (int)getIUniqueItem;
					ItemType type_ = default(ItemType);
					itemFilterData.type_ = type_;
					ItemType itemType = default(ItemType);
					int activityItemType_ = default(int);
					if (itemType == ItemType.ActivityItem)
					{
						ActivityItemType activityItemType = default(ActivityItemType);
						activityItemType_ = (int)activityItemType;
					}
					itemFilterData.activityItemType_ = (ActivityItemType)activityItemType_;
					itemFilter.data_ = itemFilterData;
				}
			}
			return itemFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x60087D8")]
		[Cpp2IlInjected.Address(RVA = "0x1745A60", Offset = "0x1744460", VA = "0x181745A60")]
		private void OnPickup(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_00a1
			//IL_0093: Expected O, but got I4
			int num = (int)operation;
			if (num != 1 || state_ != DutySlotState.OnGoing)
			{
				return;
			}
			HangoutWithCharacter with_ = this.dutyStepData.PickUp.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			DutyStepData dutyStepData = stepData_;
			if (dutyStepData == null)
			{
				return;
			}
			ItemFilter itemFilter_ = dutyStepData.itemFilter_;
			if (itemFilter_ != null && (long)itemFilter_.data_ != 0)
			{
				List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
				int itemID = gridObject.ItemID;
				GridState gridState = gridObject.state_;
				num = itemID;
				if (gridState == null || gridState.ItemAmountState != null)
				{
				}
				int num2 = 0;
				int num3 = 0;
				((List<T>)(object)list).Add((T)num3);
				int num4 = 0;
				this.CheckForCompletion((List<>)(object)list, (byte)num4 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087D9")]
		[Cpp2IlInjected.Address(RVA = "0x17459B0", Offset = "0x17443B0", VA = "0x1817459B0")]
		private void OnPickupFromHarvest(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_0042
			if (state_ == DutySlotState.OnGoing)
			{
				HangoutWithCharacter with_ = dutyStepData.PickUp.with_;
				Profile profile = Profile;
				if (with_.CurrentHangoutCharacterIsValid(profile))
				{
					List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)this.OnGardeningEvent(grid, gridObject, slotIndex);
					int num = 0;
					this.CheckForCompletion((List<>)(object)list, (byte)num != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087DA")]
		[Cpp2IlInjected.Address(RVA = "0x1743E90", Offset = "0x1742890", VA = "0x181743E90")]
		private void OnCatchFish(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_00df
			//IL_0014: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			int itemID = fishItem.ItemID;
			int? criticalSuccessMinigameID2 = (int?)(object)0;
			HangoutWithCharacter with_ = this.dutyStepData.CatchFish.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile) || !success)
			{
				return;
			}
			DutyStepData dutyStepData = stepData_;
			if (dutyStepData != null)
			{
				ItemFilter itemFilter_ = dutyStepData.itemFilter_;
				if (itemFilter_ != null && (long)itemFilter_.data_ != 0)
				{
					List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
					int num = 0;
					int num2 = 0;
					itemID = amount;
					IEnumerable<(Item, ItemState)> enumerable = (IEnumerable<(Item, ItemState)>)Enumerable.Repeat<(Item, ItemState)>(((Item, ItemState))num, itemID);
					((List<T>)(object)list).AddRange((IEnumerable<>)enumerable);
					int num3 = 0;
					this.CheckForCompletion((List<>)(object)list, (byte)num3 != 0);
					ProfileEventDispatcher dispatcher = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value = MinigameStopped;
					dispatcher.OnItemCollectMinigameEnded += value;
					ProfileEventDispatcher dispatcher2 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value2 = MinigameItemsCollected;
					dispatcher2.OnMinigameItemsCollected += value2;
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6008829")]
			[Cpp2IlInjected.Address(RVA = "0x9A8B00", Offset = "0x9A7500", VA = "0x1809A8B00")]
			void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
			{
				int num4 = default(int);
				int num6 = default(int);
				do
				{
					if (minigame.ID != num4)
					{
						return;
					}
					if (state_ != DutySlotState.Completed)
					{
						List<(Item item, ItemState state)> itemList = (List<(Item item, ItemState state)>)(object)new List<T>();
						RepeatedField<ItemInstance> items_ = items.items_;
						Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
						{
							//Discarded unreachable code: IL_003a
							//IL_002f: Expected O, but got I4
							List<(Item, ItemState)> list3 = itemList;
							Item item = x.Item;
							ItemState itemState = x.state_;
							int num7 = 0;
							int itemID2 = item.ItemID;
							int amount_ = x.amount_;
							IEnumerable<(Item, ItemState)> enumerable2 = (IEnumerable<(Item, ItemState)>)Enumerable.Repeat<(Item, ItemState)>(((Item, ItemState))num7, amount_);
							((List<T>)(object)list3).AddRange((IEnumerable<>)enumerable2);
						};
						((RepeatedField<>)(object)items_).ForEach<ItemInstance>((Action<>)(object)action);
						DutySlot dutySlot = this;
						List<(Item, ItemState)> list2 = itemList;
						int num5 = 0;
						dutySlot.CheckForCompletion((List<>)(object)list2, (byte)num5 != 0);
						return;
					}
				}
				while (minigame.ID != num6);
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.MinigameEventHandler value3 = MinigameStopped;
				dispatcher3.OnItemCollectMinigameEnded -= value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.MinigameItemsCollected value4 = MinigameItemsCollected;
				dispatcher4.OnMinigameItemsCollected -= value4;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008828")]
			[Cpp2IlInjected.Address(RVA = "0x9A8DC0", Offset = "0x9A77C0", VA = "0x1809A8DC0")]
			void MinigameStopped(Profile.ItemCollectMinigame minigame)
			{
				//Discarded unreachable code: IL_004c
				int num8 = default(int);
				if (minigame.ID == num8)
				{
					ProfileEventDispatcher dispatcher5 = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value5 = MinigameStopped;
					dispatcher5.OnItemCollectMinigameEnded -= value5;
					ProfileEventDispatcher dispatcher6 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value6 = MinigameItemsCollected;
					dispatcher6.OnMinigameItemsCollected -= value6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087DB")]
		[Cpp2IlInjected.Address(RVA = "0x1744140", Offset = "0x1742B40", VA = "0x181744140")]
		private void OnCookMeal(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene)
		{
			//Discarded unreachable code: IL_009d
			//IL_005b: Expected O, but got I4
			int itemID = mealItem.ItemID;
			bool flag = default(bool);
			int num = default(int);
			if (state_ != DutySlotState.OnGoing || !flag || num <= 0)
			{
				return;
			}
			DutyStepData dutyStepData = stepData_;
			if (dutyStepData == null)
			{
				return;
			}
			ItemFilter itemFilter_ = dutyStepData.itemFilter_;
			if (itemFilter_ == null || (long)itemFilter_.data_ == 0)
			{
				return;
			}
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
			int num2 = 0;
			int num3 = 0;
			((List<T>)(object)list).Add((T)num2);
			Func<KeyValuePair<Item, int>, (Item, ItemState)> _003C_003E9__20_ = _003C_003Ec._003C_003E9__20_0;
			if (_003C_003E9__20_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num5 = 0;
					/*Error: Unexpected end of block*/;
				};
			}
			IEnumerable<KeyValuePair<Item, int>> enumerable = (IEnumerable<KeyValuePair<Item, int>>)Enumerable.Select<KeyValuePair<Item, int>, (Item, ItemState)>((IEnumerable<>)ingredients, (Func<, >)(object)_003C_003E9__20_);
			((List<T>)(object)list).AddRange((IEnumerable<>)enumerable);
			int num4 = 0;
			this.CheckForCompletion((List<>)(object)list, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60087DC")]
		[Cpp2IlInjected.Address(RVA = "0x1746120", Offset = "0x1744B20", VA = "0x181746120")]
		private void OnShopItemsSold(string shopName, IInventory inventory, IEnumerable<ItemInstance> items, IEnumerable<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_0073, IL_0079, IL_007f, IL_0085
			//IL_0062: Expected O, but got I4
			uint num2 = default(uint);
			int num3 = default(int);
			Item item = default(Item);
			while (true)
			{
				int num = 0;
				if (state_ != DutySlotState.OnGoing)
				{
					break;
				}
				DutyStepData dutyStepData = stepData_;
				if (dutyStepData == null)
				{
					break;
				}
				ItemFilter itemFilter_ = dutyStepData.itemFilter_;
				if (itemFilter_ == null || (IntPtr)itemFilter_.data_ == (IntPtr)num)
				{
					break;
				}
				List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
				if (list != null)
				{
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_0066;
						}
						num++;
					}
					num3 = 0;
					object syncRoot = ((List<>)(object)list)._syncRoot;
					int itemID = item.ItemID;
					((List<T>)(object)list).Add((T)num3);
					num++;
				}
				goto IL_0066;
				IL_0066:
				if (list != null)
				{
				}
				if (num3 == 0)
				{
					int num4 = 0;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087DD")]
		[Cpp2IlInjected.Address(RVA = "0x1745340", Offset = "0x1743D40", VA = "0x181745340")]
		private void OnItemsGiven(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool isGifted = false)
		{
			//Discarded unreachable code: IL_003d, IL_0043
			int num = 0;
			if (state_ != DutySlotState.OnGoing)
			{
				return;
			}
			DutyStepData dutyStepData = stepData_;
			if (dutyStepData == null)
			{
				return;
			}
			ItemFilter itemFilter_ = dutyStepData.itemFilter_;
			if (itemFilter_ != null && (IntPtr)itemFilter_.data_ != (IntPtr)num)
			{
				List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
				bool flag = default(bool);
				if (flag)
				{
					num++;
				}
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087DE")]
		[Cpp2IlInjected.Address(RVA = "0x1745C00", Offset = "0x1744600", VA = "0x181745C00")]
		private void OnPictureTaken(PhotoModeType photoMode, List<int> itemIds, List<int> gardenItemIds, SceneType sceneType)
		{
			//Discarded unreachable code: IL_006a
			//IL_0032: Expected I4, but got I8
			if (state_ == DutySlotState.OnGoing)
			{
				DutyStepData dutyStepData = stepData_;
				int targetAmount_ = stepData_.targetAmount_;
				Stop();
				Profile profile = Profile;
				state_ = DutySlotState.Completed;
				if (profile != null)
				{
					ProfilePlayer player_ = profile.player_;
					ITransactionContext context = Context;
					RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
					int dutyID = dutyId_;
					royalDutyProgress.IncrementDailyDutyProgress(dutyID);
				}
				if (Dispatcher == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087DF")]
		[Cpp2IlInjected.Address(RVA = "0x1744570", Offset = "0x1742F70", VA = "0x181744570")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_00af
			//IL_0073: Expected I4, but got I8
			int itemID = currencyItem.ItemID;
			if (gained <= 0)
			{
				return;
			}
			DutyStepData dutyStepData = stepData_;
			int num = 0;
			if (dutyStepData != null)
			{
				ItemFilter itemFilter_ = dutyStepData.itemFilter_;
				if (itemFilter_ != null)
				{
					ItemFilterData data_ = itemFilter_.data_;
					if (data_ != null)
					{
						int item_ = data_.item_;
					}
				}
			}
			bool flag = itemID == num;
			if (num != (flag ? 1 : 0))
			{
				DutyStepData dutyStepData2 = stepData_;
			}
			int targetAmount_ = stepData_.targetAmount_;
			Stop();
			Profile profile = Profile;
			state_ = DutySlotState.Completed;
			if (profile != null)
			{
				ProfilePlayer player_ = profile.player_;
				ITransactionContext context = Context;
				RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
				int dutyID = dutyId_;
				royalDutyProgress.IncrementDailyDutyProgress(dutyID);
			}
			if (Dispatcher == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087E0")]
		[Cpp2IlInjected.Address(RVA = "0x17448A0", Offset = "0x17432A0", VA = "0x1817448A0")]
		private void OnDressUp(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures)
		{
			//Discarded unreachable code: IL_0072
			//IL_003a: Expected I4, but got I8
			if (success && newEquippedClothes != null && Enumerable.Any<ClothingInfo>((IEnumerable<>)newEquippedClothes))
			{
				DutyStepData dutyStepData = stepData_;
				int targetAmount_ = stepData_.targetAmount_;
				Stop();
				Profile profile = Profile;
				state_ = DutySlotState.Completed;
				if (profile != null)
				{
					ProfilePlayer player_ = profile.player_;
					ITransactionContext context = Context;
					RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
					int dutyID = dutyId_;
					royalDutyProgress.IncrementDailyDutyProgress(dutyID);
				}
				if (Dispatcher == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087E1")]
		[Cpp2IlInjected.Address(RVA = "0x1744E90", Offset = "0x1743890", VA = "0x181744E90")]
		private void OnGiftGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool alreadyGifted = false)
		{
			//Discarded unreachable code: IL_0164
			//IL_0022: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			int itemID = characterItem.ItemID;
			bool alreadyGifted2 = false;
			Item characterItem2 = (Item)itemID;
			bool flag = default(bool);
			if (flag || itemsGiven == null)
			{
				return;
			}
			int count = ((Dictionary<TKey, TValue>)(object)itemsGiven).Count;
			if (count <= 0 || count != 0)
			{
				return;
			}
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null || dutyStepDifficulty.GiftToCharacter == null)
			{
				return;
			}
			CustomStepGiftToCharacterItem giftToCharacter = this.dutyStepData.GiftToCharacter;
			Item characterItem3 = characterItem2;
			if (!giftToCharacter.IsValid(characterItem3))
			{
				return;
			}
			Func<KeyValuePair<(Item, ItemState), int>, Item> _003C_003E9__26_ = _003C_003Ec._003C_003E9__26_0;
			if (_003C_003E9__26_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<KeyValuePair<(Item, ItemState), int>, Item>((IEnumerable<>)itemsGiven, (Func<, >)(object)_003C_003E9__26_));
			if (this.dutyStepData.GiftToCharacter.mustBeFavoriteThing_)
			{
				Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0021
					ProfileWorld world_ = Profile.world_;
					bool flag3 = default(bool);
					return (!flag3) ? flag3 : (!alreadyGifted2);
				};
				List<Item> list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Where<Item>((IEnumerable<>)list, (Func<, >)(object)func));
			}
			if (this.dutyStepData.GiftToCharacter.targetItem_.itemSelectorCase_ != 0)
			{
				ItemFilter itemFilter_ = stepData_.itemFilter_;
				int num = 0;
				if (itemFilter_.GetItemsQuantity((Dictionary<, >)(object)itemsGiven, (byte)num != 0) == 0)
				{
					return;
				}
			}
			if (this.dutyStepData.GiftToCharacter.useDifferentCharacter_)
			{
				RepeatedField<int> repeatedField = itemsUsed_;
				bool flag2 = default(bool);
				if (!flag2)
				{
					RepeatedField<int> repeatedField2 = itemsUsed_;
				}
				List<Item> list3 = (List<Item>)(object)new List<T>();
			}
			DutyStepData dutyStepData = stepData_;
			int num2 = 0;
			int num3 = 0;
			this.CheckForCompletion((List<>)num3, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60087E2")]
		[Cpp2IlInjected.Address(RVA = "0x1744E50", Offset = "0x1743850", VA = "0x181744E50")]
		private void OnGardeningPlant(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			if (state_ == DutySlotState.OnGoing)
			{
				List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)this.OnGardeningEvent(grid, gridObject, slotIndex);
				int num = 0;
				this.CheckForCompletion((List<>)(object)list, (byte)num != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087E3")]
		[Cpp2IlInjected.Address(RVA = "0x1744C60", Offset = "0x1743660", VA = "0x181744C60")]
		private void OnGardeningHarvest(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_00a1
			//IL_000d: Expected O, but got I4
			GardeningDetail detail2 = (GardeningDetail)0;
			if (state_ == DutySlotState.OnGoing)
			{
				HangoutWithCharacter with_ = dutyStepData.GardeningHarvest.with_;
				Profile profile = Profile;
				if (with_.CurrentHangoutCharacterIsValid(profile))
				{
					List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)this.OnGardeningEvent(grid, gridObject, slotIndex);
					int num = 0;
					this.CheckForCompletion((List<>)(object)list, (byte)num != 0);
					GardeningDetail gardeningDetail = detail2;
					ProfileEventDispatcher dispatcher = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value = MinigameStopped;
					dispatcher.OnItemCollectMinigameEnded += value;
					ProfileEventDispatcher dispatcher2 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value2 = MinigameItemsCollected;
					dispatcher2.OnMinigameItemsCollected += value2;
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6008838")]
			[Cpp2IlInjected.Address(RVA = "0x9A93B0", Offset = "0x9A7DB0", VA = "0x1809A93B0")]
			void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
			{
				GardeningDetail gardeningDetail2 = detail2;
				int num2 = default(int);
				if (minigame.ID == num2)
				{
					if (state_ == DutySlotState.Completed)
					{
						throw new NullReferenceException();
					}
					List<(Item item, ItemState state)> itemList = (List<(Item item, ItemState state)>)(object)new List<T>();
					RepeatedField<ItemInstance> items_ = items.items_;
					Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
					{
						//Discarded unreachable code: IL_003a
						//IL_002f: Expected O, but got I4
						List<(Item, ItemState)> list3 = itemList;
						Item item = x.Item;
						ItemState itemState = x.state_;
						int num4 = 0;
						int itemID = item.ItemID;
						int amount_ = x.amount_;
						IEnumerable<(Item, ItemState)> enumerable = (IEnumerable<(Item, ItemState)>)Enumerable.Repeat<(Item, ItemState)>(((Item, ItemState))num4, amount_);
						((List<T>)(object)list3).AddRange((IEnumerable<>)enumerable);
					};
					((RepeatedField<>)(object)items_).ForEach<ItemInstance>((Action<>)(object)action);
					DutySlot dutySlot = this;
					List<(Item, ItemState)> list2 = itemList;
					int num3 = 0;
					dutySlot.CheckForCompletion((List<>)(object)list2, (byte)num3 != 0);
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6008837")]
			[Cpp2IlInjected.Address(RVA = "0x9A9690", Offset = "0x9A8090", VA = "0x1809A9690")]
			void MinigameStopped(Profile.ItemCollectMinigame minigame)
			{
				//Discarded unreachable code: IL_0055
				GardeningDetail gardeningDetail3 = detail2;
				int num5 = default(int);
				if (minigame.ID == num5)
				{
					ProfileEventDispatcher dispatcher3 = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value3 = MinigameStopped;
					dispatcher3.OnItemCollectMinigameEnded -= value3;
					ProfileEventDispatcher dispatcher4 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value4 = MinigameItemsCollected;
					dispatcher4.OnMinigameItemsCollected -= value4;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087E4")]
		[Cpp2IlInjected.Address(RVA = "0x1745550", Offset = "0x1743F50", VA = "0x181745550")]
		private void OnMiningMineral(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_0160
			//IL_0014: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			int? criticalSuccessMinigameID2 = (int?)(object)0;
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepMineMineral mineMineral = dutyStepDifficulty.MineMineral;
			if (mineMineral == null)
			{
				return;
			}
			HangoutWithCharacter with_ = mineMineral.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			if (Enumerable.Any<ActivityDataLocationFilter>((IEnumerable<>)(object)mineMineral.locations_) && location.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.Scene)
			{
				RepeatedField<ActivityDataLocationFilter> locations_ = mineMineral.locations_;
				Predicate<ActivityDataLocationFilter> predicate = (Predicate<ActivityDataLocationFilter>)(object)(Predicate<T>)delegate(ActivityDataLocationFilter x)
				{
					//Discarded unreachable code: IL_0018
					int scene = x.Scene;
					int scene2 = location.Scene;
					return scene == scene2;
				};
				if (!((RepeatedField<>)(object)locations_).Any<ActivityDataLocationFilter>((Predicate<>)(object)predicate))
				{
					return;
				}
			}
			if (Enumerable.Any<ActivityDataLocationFilter>((IEnumerable<>)(object)mineMineral.locations_) && location.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea)
			{
				RepeatedField<ActivityDataLocationFilter> locations_2 = mineMineral.locations_;
				Predicate<ActivityDataLocationFilter> predicate2 = (Predicate<ActivityDataLocationFilter>)(object)(Predicate<T>)delegate(ActivityDataLocationFilter x)
				{
					//Discarded unreachable code: IL_001c
					VillageAreaType villageArea = x.VillageArea;
					ActivityDataLocationFilter activityDataLocationFilter = location;
					int num9 = (int)villageArea;
					VillageAreaType villageArea2 = activityDataLocationFilter.VillageArea;
					return num9 == (int)villageArea2;
				};
				if (!((RepeatedField<>)(object)locations_2).Any<ActivityDataLocationFilter>((Predicate<>)(object)predicate2))
				{
					return;
				}
			}
			if (!mineMineral.acceptMiningFailure_)
			{
				if (!success)
				{
					goto IL_0121;
				}
				if (_003C_003Ec._003C_003E9__29_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						int num8 = 0;
						throw new NullReferenceException();
					};
				}
				IEnumerable<ItemWithState> enumerable = default(IEnumerable<ItemWithState>);
				List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)Enumerable.ToList<(Item, ItemState)>((IEnumerable<>)enumerable);
			}
			DutyStepData dutyStepData = stepData_;
			int num = 0;
			int num2 = 0;
			this.CheckForCompletion((List<>)num, (byte)num2 != 0);
			goto IL_0121;
			IL_0121:
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.MinigameEventHandler value = MinigameStopped;
			dispatcher.OnItemCollectMinigameEnded += value;
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.MinigameItemsCollected value2 = MinigameItemsCollected;
			dispatcher2.OnMinigameItemsCollected += value2;
			[Cpp2IlInjected.Token(Token = "0x600883F")]
			[Cpp2IlInjected.Address(RVA = "0x9A9930", Offset = "0x9A8330", VA = "0x1809A9930")]
			void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
			{
				int num3 = default(int);
				int num5 = default(int);
				do
				{
					if (minigame.ID != num3)
					{
						return;
					}
					if (state_ != DutySlotState.Completed)
					{
						List<(Item item, ItemState state)> itemList = (List<(Item item, ItemState state)>)(object)new List<T>();
						RepeatedField<ItemInstance> items_ = items.items_;
						Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
						{
							//Discarded unreachable code: IL_003a
							//IL_002f: Expected O, but got I4
							List<(Item, ItemState)> list3 = itemList;
							Item item = x.Item;
							ItemState itemState = x.state_;
							int num6 = 0;
							int itemID = item.ItemID;
							int amount_ = x.amount_;
							IEnumerable<(Item, ItemState)> enumerable2 = (IEnumerable<(Item, ItemState)>)Enumerable.Repeat<(Item, ItemState)>(((Item, ItemState))num6, amount_);
							((List<T>)(object)list3).AddRange((IEnumerable<>)enumerable2);
						};
						((RepeatedField<>)(object)items_).ForEach<ItemInstance>((Action<>)(object)action);
						DutySlot dutySlot = this;
						List<(Item, ItemState)> list2 = itemList;
						int num4 = 0;
						dutySlot.CheckForCompletion((List<>)(object)list2, (byte)num4 != 0);
						return;
					}
				}
				while (minigame.ID != num5);
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.MinigameEventHandler value3 = MinigameStopped;
				dispatcher3.OnItemCollectMinigameEnded -= value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.MinigameItemsCollected value4 = MinigameItemsCollected;
				dispatcher4.OnMinigameItemsCollected -= value4;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600883E")]
			[Cpp2IlInjected.Address(RVA = "0x9A9BF0", Offset = "0x9A85F0", VA = "0x1809A9BF0")]
			void MinigameStopped(Profile.ItemCollectMinigame minigame)
			{
				//Discarded unreachable code: IL_004c
				int num7 = default(int);
				if (minigame.ID == num7)
				{
					ProfileEventDispatcher dispatcher5 = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value5 = MinigameStopped;
					dispatcher5.OnItemCollectMinigameEnded -= value5;
					ProfileEventDispatcher dispatcher6 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value6 = MinigameItemsCollected;
					dispatcher6.OnMinigameItemsCollected -= value6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087E5")]
		[Cpp2IlInjected.Address(RVA = "0x17449D0", Offset = "0x17433D0", VA = "0x1817449D0")]
		private List<(Item, ItemState)> OnGardeningEvent(IGrid grid, GridObject gridObject, int slotIndex)
		{
			//IL_0076: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
			SeedItemData seedItemData = default(SeedItemData);
			if (seedItemData != null && (object)seedItemData.ProducedItem == null)
			{
				DutyStepData dutyStepData = stepData_;
				if (dutyStepData != null)
				{
					ItemFilter itemFilter_ = dutyStepData.itemFilter_;
					if (itemFilter_ != null && (long)itemFilter_.data_ != 0)
					{
						List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
						int num = 0;
						if (num < seedItemData.producedAmount_)
						{
							int num2 = 0;
							int num3 = 0;
							((List<T>)(object)list).Add((T)num2);
							num++;
						}
						return list;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60087E6")]
		[Cpp2IlInjected.Address(RVA = "0x17410C0", Offset = "0x173FAC0", VA = "0x1817410C0")]
		private void CheckForCompletion([Optional] List<(Item item, ItemState state)> items, bool forceComplete = false)
		{
			//Discarded unreachable code: IL_00ba
			//IL_007e: Expected I4, but got I8
			if (items != null)
			{
				DutyStepData dutyStepData = stepData_;
				if (dutyStepData == null)
				{
					return;
				}
				ItemFilter itemFilter_ = dutyStepData.itemFilter_;
				if (itemFilter_ == null)
				{
					return;
				}
				List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)itemFilter_.ApplyFilter((IEnumerable<>)items);
				if (list == null || ((List<>)(object)list)._size <= 0)
				{
					return;
				}
				DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
				DutyStepData dutyStepData2 = stepData_;
				if (dutyStepDifficulty.difficultyStepCase_ == DutyStepDifficulty.DifficultyStepOneofCase.CookMeal)
				{
				}
			}
			int curAmount_ = stepData_.curAmount_;
			uint num = default(uint);
			if (num != 0)
			{
				Stop();
				Profile profile = Profile;
				state_ = DutySlotState.Completed;
				if (profile != null)
				{
					ProfilePlayer player_ = profile.player_;
					ITransactionContext context = Context;
					RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
					int dutyID = dutyId_;
					royalDutyProgress.IncrementDailyDutyProgress(dutyID);
				}
			}
			if (Dispatcher == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087E7")]
		[Cpp2IlInjected.Address(RVA = "0x1746EA0", Offset = "0x17458A0", VA = "0x181746EA0")]
		private void StartExpandHouse()
		{
			//Discarded unreachable code: IL_009e
			//IL_002d: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepExpandHouse expandHouse = dutyStepDifficulty.ExpandHouse;
			if (expandHouse != null)
			{
				ExpandHouseEventType eventToListen = expandHouse.EventToListen;
				int num = (int)eventToListen;
				ExpandHouseEventType expandHouseEventType = default(ExpandHouseEventType);
				if (((System.Enum)eventToListen).HasFlag(expandHouseEventType))
				{
					ProfileEventDispatcher dispatcher = Dispatcher;
					ProfileEventDispatcher.PlayerHouseRoomExpanded value = OnPlayerHouseRoomExpanded;
					dispatcher.OnPlayerHouseRoomExpanded += value;
				}
				bool flag = default(bool);
				if (flag)
				{
					ProfileEventDispatcher dispatcher2 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseRoomAdded value2 = OnPlayerHouseRoomAdded;
					dispatcher2.OnPlayerHouseRoomAdded += value2;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					ProfileEventDispatcher dispatcher3 = Dispatcher;
					ProfileEventDispatcher.PlayerHouseFloorAdded value3 = OnPlayerHouseFloorAdded;
					dispatcher3.OnPlayerHouseFloorAdded += value3;
				}
				InitExpandHouse();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087E8")]
		[Cpp2IlInjected.Address(RVA = "0x17431C0", Offset = "0x1741BC0", VA = "0x1817431C0")]
		private void InitExpandHouse()
		{
			//Discarded unreachable code: IL_01d4
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected I4, but got Unknown
			//IL_01d3: Expected O, but got I4
			if (stepData_.curAmount_ >= 1)
			{
				return;
			}
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepExpandHouse expandHouse = dutyStepDifficulty.ExpandHouse;
			if (expandHouse == null)
			{
				return;
			}
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			if (expandHouse.actionType_ > CustomStepExpandHouse.Types.ExpandType.ReachNumberOfFloor)
			{
				return;
			}
			int count = ((RepeatedField<T>)(object)Profile.world_.playerHouse_.floors_).Count;
			int num = num - count;
			int roomCount = Profile.world_.playerHouse_.RoomCount;
			int num2 = default(int);
			num += num2;
			num -= roomCount;
			Profile profile = Profile;
			int num3 = default(int);
			num2 = num3;
			House playerHouse_ = profile.world_.playerHouse_;
			int amount_ = expandHouse.amount_;
			int num4 = default(int);
			profile = (Profile)(profile - num4);
			if ((long)amount_ <= (long)(IntPtr)profile)
			{
				return;
			}
			DutyStepData dutyStepData = stepData_;
			amount_ = (dutyStepData.curAmount_ = amount_ - profile);
			House playerHouse_2 = Profile.world_.playerHouse_;
			int roomCount2 = Profile.world_.playerHouse_.RoomCount;
			int num5 = num5 - roomCount2;
			int amount_2 = expandHouse.amount_;
			if (amount_2 > num5)
			{
				DutyStepData dutyStepData2 = stepData_;
				amount_2 = (dutyStepData2.curAmount_ = amount_2 - num5);
				Profile profile2 = Profile;
				int num6 = default(int);
				num5 = num6;
				int count2 = ((RepeatedField<T>)(object)profile2.world_.playerHouse_.floors_).Count;
				num5 -= count2;
				int amount_3 = expandHouse.amount_;
				if (amount_3 > num5)
				{
					DutyStepData dutyStepData3 = stepData_;
					amount_3 = (dutyStepData3.curAmount_ = amount_3 - num5);
					int roomCount3 = Profile.world_.playerHouse_.RoomCount;
					Profile profile3 = Profile;
					DutyStepData dutyStepData4 = stepData_;
					int num7 = (dutyStepData4.curAmount_ = ((RepeatedField<T>)(object)profile3.world_.playerHouse_.floors_).Count);
					int num8 = 0;
					int num9 = 0;
					this.CheckForCompletion((List<>)num9, (byte)num8 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087E9")]
		[Cpp2IlInjected.Address(RVA = "0x1745DB0", Offset = "0x17447B0", VA = "0x181745DB0")]
		private void OnPlayerHouseRoomExpanded(int sizeX, int sizeY, int floorIndex, House.Types.RoomSlot roomSlot, [Optional] List<CurrencyCost> cost)
		{
			//Discarded unreachable code: IL_0061
			//IL_0029: Expected I4, but got I8
			DutyStepData dutyStepData = stepData_;
			int targetAmount_ = stepData_.targetAmount_;
			Stop();
			Profile profile = Profile;
			state_ = DutySlotState.Completed;
			if (profile != null)
			{
				ProfilePlayer player_ = profile.player_;
				ITransactionContext context = Context;
				RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
				int dutyID = dutyId_;
				royalDutyProgress.IncrementDailyDutyProgress(dutyID);
			}
			if (Dispatcher == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087EA")]
		[Cpp2IlInjected.Address(RVA = "0x1745DB0", Offset = "0x17447B0", VA = "0x181745DB0")]
		private void OnPlayerHouseRoomAdded(int floorIndex, House.Types.RoomSlot roomSlot, List<CurrencyCost> cost)
		{
			//Discarded unreachable code: IL_0061
			//IL_0029: Expected I4, but got I8
			DutyStepData dutyStepData = stepData_;
			int targetAmount_ = stepData_.targetAmount_;
			Stop();
			Profile profile = Profile;
			state_ = DutySlotState.Completed;
			if (profile != null)
			{
				ProfilePlayer player_ = profile.player_;
				ITransactionContext context = Context;
				RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
				int dutyID = dutyId_;
				royalDutyProgress.IncrementDailyDutyProgress(dutyID);
			}
			if (Dispatcher == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087EB")]
		[Cpp2IlInjected.Address(RVA = "0x1745CE0", Offset = "0x17446E0", VA = "0x181745CE0")]
		private void OnPlayerHouseFloorAdded([Optional] CurrencyCost cost)
		{
			//Discarded unreachable code: IL_0061
			//IL_0029: Expected I4, but got I8
			DutyStepData dutyStepData = stepData_;
			int targetAmount_ = stepData_.targetAmount_;
			Stop();
			Profile profile = Profile;
			state_ = DutySlotState.Completed;
			if (profile != null)
			{
				ProfilePlayer player_ = profile.player_;
				ITransactionContext context = Context;
				RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
				int dutyID = dutyId_;
				royalDutyProgress.IncrementDailyDutyProgress(dutyID);
			}
			if (Dispatcher == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087EC")]
		[Cpp2IlInjected.Address(RVA = "0x1745F40", Offset = "0x1744940", VA = "0x181745F40")]
		private void OnRestaurantOrderFulfilled(CharacterRestaurantOrder order, ItemWithState mealServed)
		{
			//Discarded unreachable code: IL_00ac
			//IL_0070: Expected I4, but got I8
			if (!order.fulfilled_)
			{
				return;
			}
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepServeRestaurantOrder serveRestaurantOrder = dutyStepDifficulty.ServeRestaurantOrder;
			if (serveRestaurantOrder != null)
			{
				Item item = mealServed.Item;
				MealItemData mealItemData = default(MealItemData);
				int starRating_ = mealItemData.starRating_;
				ScalableValue value = serveRestaurantOrder.MinimumStarRating.Value;
				DutyStepData dutyStepData = stepData_;
				int targetAmount_ = stepData_.targetAmount_;
				Stop();
				Profile profile = Profile;
				state_ = DutySlotState.Completed;
				if (profile != null)
				{
					ProfilePlayer player_ = profile.player_;
					ITransactionContext context = Context;
					RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
					int dutyID = dutyId_;
					royalDutyProgress.IncrementDailyDutyProgress(dutyID);
				}
				if (Dispatcher == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087ED")]
		[Cpp2IlInjected.Address(RVA = "0x1747120", Offset = "0x1745B20", VA = "0x181747120")]
		private void StartUnlockBuilding()
		{
			//Discarded unreachable code: IL_00ca
			DutyStepDifficulty dutyStepDifficulty = dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUnlock unlock = dutyStepDifficulty.Unlock;
			if (unlock == null)
			{
				return;
			}
			CustomStepUnlock.TypeOneofCase typeCase_ = unlock.typeCase_;
			if (unlock != null)
			{
				if (unlock != null)
				{
					if (unlock != null)
					{
						if (typeCase_ == CustomStepUnlock.TypeOneofCase.Building)
						{
							ProfileEventDispatcher dispatcher = Dispatcher;
							ProfileEventDispatcher.ToolAdded value = OnToolAdded;
							dispatcher.OnToolAdded += value;
						}
					}
					else
					{
						ProfileEventDispatcher dispatcher2 = Dispatcher;
						ProfileEventDispatcher.RealmUnlocked value2 = OnRealmUnlocked;
						dispatcher2.OnRealmUnlocked += value2;
					}
				}
				else
				{
					ProfileEventDispatcher dispatcher3 = Dispatcher;
					ProfileEventDispatcher.VillageAreaUnlocked value3 = OnVillageAreaUnlocked;
					dispatcher3.OnVillageAreaUnlocked += value3;
				}
			}
			else
			{
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value4 = OnBuildingUnlocked;
				dispatcher4.OnBuildingUnlocked += value4;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.BuildingBuilt value5 = OnBuildingBuilt;
				dispatcher5.OnBuildingBuilt += value5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087EE")]
		[Cpp2IlInjected.Address(RVA = "0x1743E80", Offset = "0x1742880", VA = "0x181743E80")]
		private void OnBuildingUnlocked(Item item, [Optional] List<CurrencyCost> costs)
		{
			CheckBuildingUnlockedCompletion(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60087EF")]
		[Cpp2IlInjected.Address(RVA = "0x1743E80", Offset = "0x1742880", VA = "0x181743E80")]
		private void OnBuildingBuilt(Item item)
		{
			CheckBuildingUnlockedCompletion(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60087F0")]
		[Cpp2IlInjected.Address(RVA = "0x1740EE0", Offset = "0x173F8E0", VA = "0x181740EE0")]
		private void CheckBuildingUnlockedCompletion(Item item)
		{
			//Discarded unreachable code: IL_00c0
			//IL_00bf: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Building)
			{
				return;
			}
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUnlock unlock = dutyStepDifficulty.Unlock;
			if (unlock == null)
			{
				return;
			}
			TargetBuildingType building = unlock.Building;
			if (building.buildingTypeCase_ != TargetBuildingType.BuildingTypeOneofCase.Any)
			{
				if (building.TargetBuilding == null)
				{
					return;
				}
				BuildingItemType buildingItemType = default(BuildingItemType);
				int num2 = (int)buildingItemType;
				BuildingItemType targetBuildingItemType = building.TargetBuildingItemType;
				if (num2 != (int)targetBuildingItemType)
				{
					return;
				}
				if (building.TargetBuilding.targetCase_ == TargetBuilding.TargetOneofCase.ItemID)
				{
					Item item2 = building.TargetBuilding.Item;
					bool flag = default(bool);
					if (flag)
					{
						return;
					}
				}
			}
			ProfileWorld world_ = Profile.world_;
			bool flag2 = default(bool);
			if (flag2)
			{
				ProfileWorld world_2 = Profile.world_;
				bool flag3 = default(bool);
				if (flag3)
				{
					DutyStepData dutyStepData = stepData_;
					int num3 = 0;
					int num4 = 0;
					this.CheckForCompletion((List<>)num4, (byte)num3 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087F1")]
		[Cpp2IlInjected.Address(RVA = "0x1746490", Offset = "0x1744E90", VA = "0x181746490")]
		private void OnVillageAreaUnlocked(VillageAreaType areaType, [Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_006c
			//IL_006b: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUnlock unlock = dutyStepDifficulty.Unlock;
			if (unlock == null)
			{
				return;
			}
			if (unlock.Area.targetCase_ == TargetArea.TargetOneofCase.Area)
			{
				ProfileWorld world_ = Profile.world_;
				VillageAreaType area = unlock.Area.Area;
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
			}
			DutyStepData dutyStepData = stepData_;
			int num = (dutyStepData.curAmount_ = dutyStepData.targetAmount_);
			int num2 = 0;
			int num3 = 0;
			this.CheckForCompletion((List<>)num3, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60087F2")]
		[Cpp2IlInjected.Address(RVA = "0x17415E0", Offset = "0x173FFE0", VA = "0x1817415E0")]
		private void CheckVillageAreaUnlockedCompletion(bool anyAllowed)
		{
			//Discarded unreachable code: IL_006c
			//IL_006b: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUnlock unlock = dutyStepDifficulty.Unlock;
			if (unlock != null)
			{
				if (unlock.Area.targetCase_ != TargetArea.TargetOneofCase.Area)
				{
				}
				ProfileWorld world_ = Profile.world_;
				VillageAreaType area = unlock.Area.Area;
				bool flag = default(bool);
				if (flag)
				{
					DutyStepData dutyStepData = stepData_;
					int num = (dutyStepData.curAmount_ = dutyStepData.targetAmount_);
					int num2 = 0;
					int num3 = 0;
					this.CheckForCompletion((List<>)num3, (byte)num2 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087F3")]
		[Cpp2IlInjected.Address(RVA = "0x1745E90", Offset = "0x1744890", VA = "0x181745E90")]
		private void OnRealmUnlocked(string realmName, bool unlockedByFlag)
		{
			//Discarded unreachable code: IL_004e
			//IL_004d: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUnlock unlock = dutyStepDifficulty.Unlock;
			if (unlock == null)
			{
				return;
			}
			if (unlock.Realm.targetCase_ == TargetRealm.TargetOneofCase.RealmID)
			{
				ProfileWorld world_ = Profile.world_;
				Item realmItem = unlock.Realm.RealmItem;
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
			}
			int num = 0;
			this.CheckForCompletion((List<>)num, true);
		}

		[Cpp2IlInjected.Token(Token = "0x60087F4")]
		[Cpp2IlInjected.Address(RVA = "0x17463D0", Offset = "0x1744DD0", VA = "0x1817463D0")]
		private void OnToolAdded(Item toolItem)
		{
			//Discarded unreachable code: IL_003b
			//IL_003a: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUnlock unlock = dutyStepDifficulty.Unlock;
			if (unlock != null)
			{
				ProfilePlayer player_ = Profile.player_;
				Item toolItem2 = unlock.ToolItem;
				bool flag = default(bool);
				if (flag)
				{
					int num = 0;
					this.CheckForCompletion((List<>)num, true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087F5")]
		[Cpp2IlInjected.Address(RVA = "0x1741530", Offset = "0x173FF30", VA = "0x181741530")]
		private void CheckRealmUnlockedCompletion(bool anyAllowed)
		{
			//Discarded unreachable code: IL_004e
			//IL_004d: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUnlock unlock = dutyStepDifficulty.Unlock;
			if (unlock != null)
			{
				if (unlock.Realm.targetCase_ != TargetRealm.TargetOneofCase.RealmID)
				{
				}
				ProfileWorld world_ = Profile.world_;
				Item realmItem = unlock.Realm.RealmItem;
				bool flag = default(bool);
				if (flag)
				{
					int num = 0;
					this.CheckForCompletion((List<>)num, true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087F6")]
		[Cpp2IlInjected.Address(RVA = "0x1744130", Offset = "0x1742B30", VA = "0x181744130")]
		private void OnCharacterFriendshipLevelChanged(Item characterItem, int levelsGained)
		{
			CheckFriendCompletion(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60087F7")]
		[Cpp2IlInjected.Address(RVA = "0x1744130", Offset = "0x1742B30", VA = "0x181744130")]
		private void OnCharacterUnlocked(Item characterItem)
		{
			CheckFriendCompletion(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60087F8")]
		[Cpp2IlInjected.Address(RVA = "0x1741210", Offset = "0x173FC10", VA = "0x181741210")]
		private void CheckFriendCompletion(Item characterItem)
		{
			//IL_0021: Expected O, but got I4
			//IL_008b: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty != null)
			{
				CustomStepFriend makeFriend = dutyStepDifficulty.MakeFriend;
			}
			int num = 0;
			CustomStepFriend customStepFriend = (CustomStepFriend)num;
			CustomStepFriend customStepFriend2 = customStepFriend;
			if (customStepFriend2 == null)
			{
				return;
			}
			if (customStepFriend2.characterCase_ != CustomStepFriend.CharacterOneofCase.Any)
			{
				if ((object)customStepFriend2.CharacterItem != null)
				{
					ProfileWorld world_ = Profile.world_;
					Character character = default(Character);
					if (character != null)
					{
						int minimumFriendshipLevel_ = customStepFriend.minimumFriendshipLevel_;
						DutyStepData dutyStepData = stepData_;
						int num2 = (dutyStepData.curAmount_ = dutyStepData.targetAmount_);
						int num3 = 0;
						int num4 = 0;
						this.CheckForCompletion((List<>)num4, (byte)num3 != 0);
					}
				}
				return;
			}
			Profile profile = Profile;
			DutyStepData dutyStepData2 = stepData_;
			RepeatedField<Character> characters_ = profile.world_.characters_;
			Func<Character, bool> func = (Func<Character, bool>)(object)(Func<T, TResult>)delegate(Character x)
			{
				//Discarded unreachable code: IL_0024
				if (x.status_ != Character.Types.CharacterStatus.InVillage)
				{
					int num6 = 0;
				}
				int minimumFriendshipLevel_2 = customStepFriend.minimumFriendshipLevel_;
				return x.friendshipLevel_ >= minimumFriendshipLevel_2;
			};
			int num5 = (dutyStepData2.curAmount_ = Enumerable.Count<Character>((IEnumerable<>)(object)characters_, (Func<, >)(object)func));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60087F9")]
		[Cpp2IlInjected.Address(RVA = "0x1744410", Offset = "0x1742E10", VA = "0x181744410")]
		private void OnCritterFed(Critter critter, FeedCritterDetails details)
		{
			//IL_0082: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepFeedCritter feedCritter = dutyStepDifficulty.FeedCritter;
			if (feedCritter == null || critter == null)
			{
				return;
			}
			CritterItemData data = critter.Data;
			if (data == null || data != null || (feedCritter.conditionCase_ == CustomStepFeedCritter.ConditionOneofCase.Location && feedCritter.Location != data.location_))
			{
				return;
			}
			CustomStepFeedCritter.Types.FeedAction action_ = feedCritter.action_;
			if (action_ == CustomStepFeedCritter.Types.FeedAction.FavoriteItem)
			{
				if (details.Reaction != (FeedCritter.Types.CritterReaction)action_)
				{
					return;
				}
			}
			else if ((object)typeof(Item).TypeHandle != null)
			{
			}
			ItemFilter itemFilter_ = stepData_.itemFilter_;
			DutyStepData dutyStepData = stepData_;
			int num = 0;
			int num2 = 0;
			this.CheckForCompletion((List<>)num2, (byte)num != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60087FA")]
		[Cpp2IlInjected.Address(RVA = "0x1741840", Offset = "0x1740240", VA = "0x181741840")]
		internal void CollectDutyRewards(Profile profile, IPlayerEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0021, IL_00a9, IL_00b6
			//IL_0089: Expected I4, but got O
			//IL_00bf: Expected I4, but got I8
			//IL_00d2: Expected I4, but got I8
			if (state_ == DutySlotState.Completed)
			{
				RoyalDutyItemData royalDutyItemData = dutyData;
				if (royalDutyItemData != null)
				{
					int count = ((RepeatedField<T>)(object)royalDutyItemData.stepDifficultyLayers_).Count;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087FB")]
		[Cpp2IlInjected.Address(RVA = "0x1741E50", Offset = "0x1740850", VA = "0x181741E50")]
		public void GenerateDuty(Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_035f, IL_0365
			//IL_002b: Expected I4, but got O
			//IL_004b: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_02bc: Expected O, but got I4
			RoyalDutyProgress dutyProgress;
			ProfilePlayer profilePlayer = default(ProfilePlayer);
			IEnumerable<> enumerable = default(IEnumerable<>);
			RoyalDutyItemData royalDutyItemData;
			IEnumerable<RoyalDutyItemData> enumerable2 = default(IEnumerable<RoyalDutyItemData>);
			Func<KeyValuePair<int, int>, int> func5 = default(Func<KeyValuePair<int, int>, int>);
			bool flag2 = default(bool);
			RoyalDutyItemData royalDutyItemData3 = default(RoyalDutyItemData);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				Stop();
				Item invalid = Item.Invalid;
				dutyId_ = (int)invalid;
				string text = (dutyName_ = ProtoPreconditions.CheckNotNull("", "value"));
				stepData_ = (DutyStepData)num2;
				startTime_ = (Timestamp)num2;
				Profile profile2 = profile;
				ITransactionContext context2 = context;
				dutyProgress = profilePlayer.GetRoyalDutyProgress(context2);
				RepeatedField<DutySlot> slots_ = profile.player_.GetRoyalDutiesList().slots_;
				Func<DutySlot, int> _003C_003E9__52_ = _003C_003Ec._003C_003E9__52_0;
				if (_003C_003E9__52_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DutySlot x) => x.dutyId_);
				}
				List<int> dutySlots = (List<int>)(object)Enumerable.ToList<int>(Enumerable.Select<DutySlot, int>((IEnumerable<>)(object)slots_, (Func<, >)(object)_003C_003E9__52_));
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				List<RoyalDutyItemData> list = (List<RoyalDutyItemData>)(object)Enumerable.ToList<RoyalDutyItemData>(enumerable);
				RoyalDutyProgress royalDutyProgress = dutyProgress;
				int curDutyIndex_ = royalDutyProgress.curDutyIndex_;
				int nextIndex = (royalDutyProgress.curDutyIndex_ = curDutyIndex_ + 1);
				Func<RoyalDutyItemData, bool> func = (Func<RoyalDutyItemData, bool>)(object)(Func<T, TResult>)delegate(RoyalDutyItemData x)
				{
					//Discarded unreachable code: IL_0011
					int num11 = nextIndex;
					return x.queueIndex_ == num11;
				};
				royalDutyItemData = Enumerable.FirstOrDefault<RoyalDutyItemData>((IEnumerable<>)list, (Func<, >)(object)func);
				bool flag = (expires_ = royalDutyItemData == null);
				difficultyLayer_ = num2;
				if (royalDutyItemData != null)
				{
					break;
				}
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				RoyalDutyProgress royalDutyProgress2 = dutyProgress;
				Func<RoyalDutyItemData, bool> func2 = (Func<RoyalDutyItemData, bool>)(object)new Func<T, TResult>(DutyIsAvailable);
				if (!Enumerable.Any<RoyalDutyItemData>(Enumerable.Where<RoyalDutyItemData>((IEnumerable<>)list, (Func<, >)(object)func2)))
				{
					RoyalDutyProgress royalDutyProgress3 = dutyProgress;
					List<int> list2 = dutySlots;
					royalDutyProgress3.resetDifficultyLevels((List<>)(object)list2);
					Func<RoyalDutyItemData, bool> func3 = (Func<RoyalDutyItemData, bool>)(object)new Func<T, TResult>(DutyIsAvailable);
					enumerable2 = (IEnumerable<RoyalDutyItemData>)Enumerable.Where<RoyalDutyItemData>((IEnumerable<>)list, (Func<, >)(object)func3);
				}
				Func<RoyalDutyItemData, bool> func4 = (Func<RoyalDutyItemData, bool>)(object)(Func<T, TResult>)((RoyalDutyItemData x) => !dutyProgress.IsStepUsed(x));
				List<RoyalDutyItemData> list3 = (List<RoyalDutyItemData>)(object)Enumerable.ToList<RoyalDutyItemData>(Enumerable.Where<RoyalDutyItemData>((IEnumerable<>)enumerable2, (Func<, >)(object)func4));
				dutyProgress.resetStepsUsed();
				List<RoyalDutyItemData> list4 = (List<RoyalDutyItemData>)(object)Enumerable.ToList<RoyalDutyItemData>((IEnumerable<>)enumerable2);
				Dictionary<int, int> validDailyDutyCount = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();
				Action<RoyalDutyItemData> action = (Action<RoyalDutyItemData>)(object)(Action<T>)delegate(RoyalDutyItemData x)
				{
					//IL_001f: Expected O, but got I4
					//IL_0040: Expected O, but got I4
					//IL_0040: Expected O, but got I4
					//IL_006c: Expected O, but got I4
					//IL_006e: Expected I4, but got O
					MapField<int, int> dutyDayCount_ = dutyProgress.dutyDayCount_;
					int iD2 = x.ID;
					bool flag5 = ((MapField<TKey, TValue>)(object)dutyDayCount_).ContainsKey((TKey)iD2);
					Dictionary<int, int> dictionary3 = validDailyDutyCount;
					if (!flag5)
					{
						int iD3 = x.ID;
						int num9 = 0;
						((Dictionary<TKey, TValue>)(object)dictionary3).Add((TKey)iD3, (TValue)num9);
						return;
					}
					int iD4 = x.ID;
					MapField<int, int> dutyDayCount_2 = dutyProgress.dutyDayCount_;
					int iD5 = x.ID;
					int num10 = (int)((MapField<TKey, TValue>)(object)dutyDayCount_2)[(TKey)iD5];
					iD5 = iD4;
					throw new NullReferenceException();
				};
				((List<T>)(object)list4).ForEach((Action<>)(object)action);
				Dictionary<int, int> dictionary = validDailyDutyCount;
				if (_003C_003Ec._003C_003E9__52_5 == null)
				{
					func5 = (Func<KeyValuePair<int, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				int num3 = Enumerable.Min<KeyValuePair<int, int>>((IEnumerable<>)dictionary, (Func<, >)(object)func5);
				List<int> list5 = (List<int>)(object)new List<T>();
				Dictionary<int, int> dictionary2 = validDailyDutyCount;
				if (flag2)
				{
					Predicate<RoyalDutyItemData> predicate = (Predicate<RoyalDutyItemData>)(object)new Predicate<T>(new _003C_003Ec__DisplayClass52_2()._003CGenerateDuty_003Eb__7);
					RoyalDutyItemData royalDutyItemData2 = (RoyalDutyItemData)((List<T>)(object)list4).Find((Predicate<>)(object)predicate);
					if (royalDutyItemData2 != null)
					{
						if (royalDutyItemData3 != null)
						{
							DutyType type_ = royalDutyItemData3.type_;
						}
						bool flag3 = num2 == (int)royalDutyItemData2.type_;
						if (num2 != (flag3 ? 1 : 0))
						{
							int num4 = 0;
						}
					}
					((List<T>)(object)list5).Add((T)num2);
				}
				int num5 = 0;
				if (num3 == 0)
				{
					num3 = profile.player_.GetRandomSeed("DutyRandomSeed");
					Random random = new Random(num3);
					int selectedIndex = MissionUtil.ResolveWeightList((List<>)(object)list5, random);
					profile.player_.AdvanceRandomSeed("DutyRandomSeed");
					Predicate<RoyalDutyItemData> predicate2 = (Predicate<RoyalDutyItemData>)(object)(Predicate<T>)delegate(RoyalDutyItemData x)
					{
						//Discarded unreachable code: IL_0020
						int iD = x.ID;
						int num8 = selectedIndex;
						KeyValuePair<int, int> keyValuePair = Enumerable.ElementAt<KeyValuePair<int, int>>((IEnumerable<>)validDailyDutyCount, num8);
						return (IntPtr)iD == (IntPtr)keyValuePair;
					};
					RoyalDutyItemData royalDutyItemData4 = (RoyalDutyItemData)((List<T>)(object)list4).Find((Predicate<>)(object)predicate2);
					if (royalDutyItemData != null)
					{
						break;
					}
					return;
				}
				continue;
				List<int> list6;
				int iD_;
				ConditionsList availableWhen_;
				ITransactionContext context3;
				Profile profile4;
				RoyalDutyProgress royalDutyProgress4;
				bool flag4 = default(bool);
				ConditionsList availableWhen_2;
				ulong num6 = default(ulong);
				ITransactionContext context4;
				Profile profile5;
				int num7;
				[Cpp2IlInjected.Token(Token = "0x6008846")]
				[Cpp2IlInjected.Address(RVA = "0x9AB100", Offset = "0x9A9B00", VA = "0x1809AB100")]
				bool DutyIsAvailable(RoyalDutyItemData dutyData)
				{
					//IL_0015: Expected O, but got I4
					//IL_0055: Expected I4, but got I8
					list6 = dutySlots;
					iD_ = dutyData.iD_;
					if (!((List<T>)(object)list6).Contains((T)iD_))
					{
						availableWhen_ = dutyData.availableWhen_;
						context3 = context;
						profile4 = profile;
						if (availableWhen_.Evaluate(profile4, context3))
						{
							royalDutyProgress4 = dutyProgress;
							if (flag4)
							{
								availableWhen_2 = ((DutyStepDifficulty)((RepeatedField<T>)(object)dutyData.stepDifficultyLayers_)[(int)num6]).availableWhen_;
								if (availableWhen_2 != null)
								{
									context4 = context;
									profile5 = profile;
									return availableWhen_2.Evaluate(profile5, context4);
								}
								return true;
							}
						}
					}
					num7 = 0;
					throw new NullReferenceException();
				}
				[Cpp2IlInjected.Token(Token = "0x6008846")]
				[Cpp2IlInjected.Address(RVA = "0x9AB100", Offset = "0x9A9B00", VA = "0x1809AB100")]
				bool DutyIsAvailable(RoyalDutyItemData dutyData)
				{
					//IL_0015: Expected O, but got I4
					//IL_0055: Expected I4, but got I8
					list6 = dutySlots;
					iD_ = dutyData.iD_;
					if (!((List<T>)(object)list6).Contains((T)iD_))
					{
						availableWhen_ = dutyData.availableWhen_;
						context3 = context;
						profile4 = profile;
						if (availableWhen_.Evaluate(profile4, context3))
						{
							royalDutyProgress4 = dutyProgress;
							if (flag4)
							{
								availableWhen_2 = ((DutyStepDifficulty)((RepeatedField<T>)(object)dutyData.stepDifficultyLayers_)[(int)num6]).availableWhen_;
								if (availableWhen_2 != null)
								{
									context4 = context;
									profile5 = profile;
									return availableWhen_2.Evaluate(profile5, context4);
								}
								return true;
							}
						}
					}
					num7 = 0;
					throw new NullReferenceException();
				}
			}
			ITransactionContext transactionContext = context;
			Profile profile3 = profile;
			dutyProgress.UseDutyWithStep(royalDutyItemData);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60087FC")]
		[Cpp2IlInjected.Address(RVA = "0x1747370", Offset = "0x1745D70", VA = "0x181747370")]
		private void StartUpgrade()
		{
			//Discarded unreachable code: IL_0082
			DutyStepDifficulty dutyStepDifficulty = dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUpgrade upgrade = dutyStepDifficulty.Upgrade;
			if (upgrade == null)
			{
				return;
			}
			CustomStepUpgrade.TargetOneofCase targetCase_ = upgrade.targetCase_;
			if ((long)dutyStepDifficulty <= 1)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.BuidingUpgraded value = OnBuidingUpgraded;
				dispatcher.OnBuidingUpgraded += value;
				if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any)
				{
				}
				Item buildingItem = upgrade.BuildingItem;
			}
			if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any || upgrade.targetCase_ == CustomStepUpgrade.TargetOneofCase.PlayerLevel)
			{
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value2 = OnPlayerLevelGained;
				dispatcher2.OnPlayerLevelGained += value2;
				CheckPlayerLevelCompletion();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087FD")]
		[Cpp2IlInjected.Address(RVA = "0x1743E20", Offset = "0x1742820", VA = "0x181743E20")]
		private void OnBuidingUpgraded(GridObject gridObj, UpgradeData upData)
		{
			//Discarded unreachable code: IL_0008
			int itemID = gridObj.ItemID;
		}

		[Cpp2IlInjected.Token(Token = "0x60087FE")]
		[Cpp2IlInjected.Address(RVA = "0x1740D50", Offset = "0x173F750", VA = "0x181740D50")]
		private void CheckBuidingUpgradedCompletion(bool isUpgradeEvent, Item item, int level)
		{
			//Discarded unreachable code: IL_0080
			//IL_007f: Expected O, but got I4
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			int num = 0;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUpgrade upgrade = dutyStepDifficulty.Upgrade;
			if (upgrade == null)
			{
				return;
			}
			if (upgrade.targetCase_ == CustomStepUpgrade.TargetOneofCase.BuildingID)
			{
				Item buildingItem = upgrade.BuildingItem;
				bool flag = default(bool);
				if (flag)
				{
					if ((object)upgrade.BuildingItem == null)
					{
						return;
					}
					ProfileWorld world_ = Profile.world_;
				}
			}
			if (!isUpgradeEvent)
			{
				return;
			}
			if (upgrade.targetTypeCase_ != CustomStepUpgrade.TargetTypeOneofCase.TargetLevel)
			{
				if (!isUpgradeEvent || level <= 1)
				{
					return;
				}
				DutyStepData dutyStepData = stepData_;
			}
			stepData_.curAmount_ = level;
			int num2 = 0;
			int num3 = 0;
			this.CheckForCompletion((List<>)num3, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60087FF")]
		[Cpp2IlInjected.Address(RVA = "0x1745E80", Offset = "0x1744880", VA = "0x181745E80")]
		private void OnPlayerLevelGained(int gained)
		{
			CheckPlayerLevelCompletion();
		}

		[Cpp2IlInjected.Token(Token = "0x6008800")]
		[Cpp2IlInjected.Address(RVA = "0x1741410", Offset = "0x173FE10", VA = "0x181741410")]
		private void CheckPlayerLevelCompletion()
		{
			//Discarded unreachable code: IL_00a4
			//IL_0068: Expected I4, but got I8
			DutyStepDifficulty dutyStepDifficulty = this.dutyStepData;
			if (dutyStepDifficulty == null)
			{
				return;
			}
			CustomStepUpgrade upgrade = dutyStepDifficulty.Upgrade;
			if (upgrade != null)
			{
				DutyStepData dutyStepData = stepData_;
				if (upgrade.targetTypeCase_ != CustomStepUpgrade.TargetTypeOneofCase.TargetLevel)
				{
				}
				int num = (dutyStepData.curAmount_ = Profile.player_.level_);
				int targetAmount_ = stepData_.targetAmount_;
				Stop();
				Profile profile = Profile;
				state_ = DutySlotState.Completed;
				if (profile != null)
				{
					ProfilePlayer player_ = profile.player_;
					ITransactionContext context = Context;
					RoyalDutyProgress royalDutyProgress = player_.GetRoyalDutyProgress(context);
					int dutyID = dutyId_;
					royalDutyProgress.IncrementDailyDutyProgress(dutyID);
				}
				if (Dispatcher == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008801")]
		[Cpp2IlInjected.Address(RVA = "0x1742E60", Offset = "0x1741860", VA = "0x181742E60")]
		private string GetItemDisplayName(int itemID, Localizator localizator)
		{
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008802")]
		[Cpp2IlInjected.Address(RVA = "0x1746880", Offset = "0x1745280", VA = "0x181746880")]
		internal object ResolveKey(Localizator localizator, string key)
		{
			string text2 = default(string);
			string text3 = default(string);
			while (localizator != null && (long)stepData_ != 0 && "" == null)
			{
				ItemFilter itemFilter_ = stepData_.itemFilter_;
				string text = key.ToLower();
				if (text == null)
				{
					break;
				}
				if (text != null)
				{
					if (itemFilter_ == null)
					{
						break;
					}
					ItemFilterData data_ = itemFilter_.data_;
					if (data_ == null)
					{
						break;
					}
					int item_ = data_.item_;
					int item_2 = itemFilter_.data_.item_;
					if (text2 != null)
					{
						break;
					}
				}
				if (text != null)
				{
					int targetAmount_ = stepData_.targetAmount_;
				}
				if (text == null)
				{
					continue;
				}
				if (itemFilter_ == null || itemFilter_.MinRarity == 0 || itemFilter_ == null)
				{
					break;
				}
				ItemFilterData data_2 = itemFilter_.data_;
				if (data_2 != null)
				{
					int minMealStarRating_ = data_2.minMealStarRating_;
					while (text3 != null)
					{
					}
				}
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008806")]
		[Cpp2IlInjected.Address(RVA = "0x17495A0", Offset = "0x1747FA0", VA = "0x1817495A0")]
		[DebuggerNonUserCode]
		public DutySlot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008807")]
		[Cpp2IlInjected.Address(RVA = "0x1749360", Offset = "0x1747D60", VA = "0x181749360")]
		[DebuggerNonUserCode]
		public DutySlot(DutySlot other)
		{
			//IL_006e: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			int num = (slotId_ = other.slotId_);
			int num2 = (dutyId_ = other.dutyId_);
			DutyStepData dutyStepData = other.stepData_;
			if (dutyStepData != null)
			{
				DutyStepData dutyStepData2 = new DutyStepData();
				ItemFilter itemFilter_ = dutyStepData.itemFilter_;
				int num3 = 0;
				if (itemFilter_ != null)
				{
					ItemFilter itemFilter = itemFilter_.Clone();
				}
				dutyStepData2.itemFilter_ = (ItemFilter)num3;
				int num4 = (dutyStepData2.targetAmount_ = dutyStepData.targetAmount_);
				int num5 = (dutyStepData2.curAmount_ = dutyStepData.curAmount_);
				UnknownFieldSet unknownFieldSet = (dutyStepData2._unknownFields = UnknownFieldSet.Clone(dutyStepData._unknownFields));
			}
			int num6 = 0;
			stepData_ = (DutyStepData)num6;
			DutySlotState dutySlotState = (state_ = other.state_);
			string text = (dutyName_ = other.dutyName_);
			Timestamp timestamp = other.startTime_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			startTime_ = timestamp2;
			bool flag = (expires_ = other.expires_);
			int num7 = (difficultyLayer_ = other.difficultyLayer_);
			RepeatedField<int> repeatedField = (itemsUsed_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemsUsed_).Clone());
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008808")]
		[Cpp2IlInjected.Address(RVA = "0x17417E0", Offset = "0x17401E0", VA = "0x1817417E0", Slot = "10")]
		[DebuggerNonUserCode]
		public DutySlot Clone()
		{
			return new DutySlot(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600881A")]
		[Cpp2IlInjected.Address(RVA = "0x1741BE0", Offset = "0x17405E0", VA = "0x181741BE0", Slot = "0")]
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
				if ((IntPtr)slotId_ == (IntPtr)typeof(DutySlot).TypeHandle && (IntPtr)dutyId_ == (IntPtr)typeof(DutySlot).TypeHandle)
				{
					bool flag = object.Equals(stepData_, other);
					if (flag && state_ == (flag ? DutySlotState.NotStarted : DutySlotState.None))
					{
						string text = dutyName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							bool flag3 = object.Equals(startTime_, other);
							if (flag3 && expires_ == flag3 && difficultyLayer_ == (flag3 ? 1 : 0))
							{
								RepeatedField<int> repeatedField = itemsUsed_;
								bool flag4 = default(bool);
								if (flag4)
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

		[Cpp2IlInjected.Token(Token = "0x600881B")]
		[Cpp2IlInjected.Address(RVA = "0x1741D40", Offset = "0x1740740", VA = "0x181741D40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DutySlot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.slotId_;
				if (slotId_ == num)
				{
					int num2 = other.dutyId_;
					if (dutyId_ == num2)
					{
						DutyStepData objB = other.stepData_;
						if (object.Equals(stepData_, objB))
						{
							DutySlotState dutySlotState = other.state_;
							if (state_ == dutySlotState)
							{
								string text = other.dutyName_;
								if (!(dutyName_ != text))
								{
									Timestamp objB2 = other.startTime_;
									if (object.Equals(startTime_, objB2))
									{
										bool flag = other.expires_;
										if (expires_ == flag)
										{
											int num3 = other.difficultyLayer_;
											if (difficultyLayer_ == num3)
											{
												RepeatedField<int> repeatedField = itemsUsed_;
												RepeatedField<int> repeatedField2 = other.itemsUsed_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
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
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600881C")]
		[Cpp2IlInjected.Address(RVA = "0x1742D10", Offset = "0x1741710", VA = "0x181742D10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0094
			int num = 0;
			if (slotId_ != 0)
			{
			}
			if (dutyId_ != 0)
			{
			}
			DutyStepData dutyStepData = stepData_;
			if (dutyStepData != null)
			{
				int hashCode = dutyStepData.GetHashCode();
			}
			if (state_ != 0)
			{
			}
			string text = dutyName_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			Timestamp timestamp = startTime_;
			if (timestamp != null)
			{
				int hashCode3 = timestamp.GetHashCode();
			}
			if (expires_)
			{
			}
			if (difficultyLayer_ != 0)
			{
			}
			int hashCode4 = ((RepeatedField<T>)(object)itemsUsed_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600881D")]
		[Cpp2IlInjected.Address(RVA = "0x1748F30", Offset = "0x1747930", VA = "0x181748F30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600881E")]
		[Cpp2IlInjected.Address(RVA = "0x1749000", Offset = "0x1747A00", VA = "0x181749000", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00e8
			if (slotId_ != 0)
			{
				int value = slotId_;
				output.WriteInt32(value);
			}
			if (dutyId_ != 0)
			{
				int value2 = dutyId_;
				output.WriteInt32(value2);
			}
			if ((long)stepData_ != 0)
			{
				DutyStepData value3 = stepData_;
				output.WriteMessage(value3);
			}
			if (state_ != 0)
			{
			}
			if (dutyName_.m_stringLength != 0)
			{
				string value4 = dutyName_;
				output.WriteString(value4);
			}
			if ((long)startTime_ != 0)
			{
				Timestamp value5 = startTime_;
				output.WriteMessage(value5);
			}
			if (expires_)
			{
				bool value6 = expires_;
				output.WriteBool(value6);
			}
			if (difficultyLayer_ != 0)
			{
				int value7 = difficultyLayer_;
				output.WriteInt32(value7);
			}
			RepeatedField<int> repeatedField = itemsUsed_;
			FieldCodec<int> repeated_itemsUsed_codec = _repeated_itemsUsed_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemsUsed_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600881F")]
		[Cpp2IlInjected.Address(RVA = "0x1740B10", Offset = "0x173F510", VA = "0x181740B10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0118
			int num = slotId_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = dutyId_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			DutyStepData dutyStepData = stepData_;
			if (dutyStepData != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(dutyStepData);
				num6++;
				num2 += num6;
			}
			DutySlotState dutySlotState = state_;
			if (dutySlotState != 0)
			{
				int num7 = CodedOutputStream.ComputeEnumSize((int)dutySlotState);
				num7++;
				num2 += num7;
			}
			string text = dutyName_;
			if (text.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text);
				num8++;
				num2 += num8;
			}
			Timestamp timestamp = startTime_;
			if (timestamp != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(timestamp);
				num9++;
				num2 += num9;
			}
			int num10 = difficultyLayer_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			RepeatedField<int> repeatedField = itemsUsed_;
			FieldCodec<int> repeated_itemsUsed_codec = _repeated_itemsUsed_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemsUsed_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num12;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num2 += num13;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008820")]
		[Cpp2IlInjected.Address(RVA = "0x1743950", Offset = "0x1742350", VA = "0x181743950", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DutySlot other)
		{
			//Discarded unreachable code: IL_01bc
			if (other == null)
			{
				return;
			}
			int num = other.slotId_;
			if (num != 0)
			{
				slotId_ = num;
			}
			int num2 = other.dutyId_;
			if (num2 != 0)
			{
				dutyId_ = num2;
			}
			if (other.stepData_ != null)
			{
				DutyStepData dutyStepData2 = default(DutyStepData);
				DutyStepData dutyStepData3 = default(DutyStepData);
				if (stepData_ == null)
				{
					DutyStepData dutyStepData = (stepData_ = new DutyStepData());
					dutyStepData2 = stepData_;
					dutyStepData3 = other.stepData_;
				}
				if (dutyStepData3 != null)
				{
					if ((long)dutyStepData3.itemFilter_ != 0)
					{
						ItemFilter itemFilter_ = default(ItemFilter);
						if (dutyStepData2.itemFilter_ == null)
						{
							ItemFilter itemFilter = (dutyStepData2.itemFilter_ = new ItemFilter());
							itemFilter_ = dutyStepData2.itemFilter_;
						}
						ItemFilter itemFilter_2 = dutyStepData3.itemFilter_;
						itemFilter_.MergeFrom(itemFilter_2);
					}
					int targetAmount_ = dutyStepData3.targetAmount_;
					if (targetAmount_ != 0)
					{
						dutyStepData2.targetAmount_ = targetAmount_;
					}
					int curAmount_ = dutyStepData3.curAmount_;
					if (curAmount_ != 0)
					{
						dutyStepData2.curAmount_ = curAmount_;
					}
					UnknownFieldSet unknownFields = dutyStepData3._unknownFields;
					UnknownFieldSet unknownFieldSet = (dutyStepData2._unknownFields = UnknownFieldSet.MergeFrom(dutyStepData2._unknownFields, unknownFields));
				}
			}
			DutySlotState dutySlotState = other.state_;
			if (dutySlotState != 0)
			{
				state_ = dutySlotState;
			}
			string text = other.dutyName_;
			if (text.m_stringLength != 0)
			{
				DutyName = text;
			}
			if ((long)other.startTime_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (startTime_ == null)
				{
					Timestamp timestamp = (startTime_ = new Timestamp());
					timestamp2 = startTime_;
				}
				Timestamp other2 = other.startTime_;
				timestamp2.MergeFrom(other2);
			}
			bool flag = other.expires_;
			if (flag)
			{
				expires_ = flag;
			}
			int num3 = other.difficultyLayer_;
			if (num3 != 0)
			{
				difficultyLayer_ = num3;
			}
			RepeatedField<int> repeatedField = itemsUsed_;
			RepeatedField<int> repeatedField2 = other.itemsUsed_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6008821")]
		[Cpp2IlInjected.Address(RVA = "0x1743BB0", Offset = "0x17425B0", VA = "0x181743BB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0145
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 56)
				{
					if (num == 64)
					{
						int num2 = (difficultyLayer_ = input.ReadInt32());
					}
					num += 4294967224u;
					if (num != 4294967293u)
					{
						goto IL_012e;
					}
					RepeatedField<int> repeatedField = itemsUsed_;
					FieldCodec<int> repeated_itemsUsed_codec = _repeated_itemsUsed_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsUsed_codec);
				}
				Timestamp timestamp = default(Timestamp);
				if (num == 50)
				{
					Timestamp builder = default(Timestamp);
					if (startTime_ == null)
					{
						timestamp = (startTime_ = new Timestamp());
						builder = startTime_;
					}
					input.ReadMessage(builder);
				}
				if ((long)timestamp != 56)
				{
					goto IL_012e;
				}
				bool flag = (expires_ = input.ReadBool());
			}
			string text2 = default(string);
			if ((int)num > 16)
			{
				DutyStepData dutyStepData = default(DutyStepData);
				if (num == 26)
				{
					DutyStepData builder2 = default(DutyStepData);
					if (stepData_ == null)
					{
						dutyStepData = (stepData_ = new DutyStepData());
						builder2 = stepData_;
					}
					input.ReadMessage(builder2);
				}
				int num3 = default(int);
				if ((long)dutyStepData == 32)
				{
					num3 = (int)(state_ = (DutySlotState)input.ReadInt32());
				}
				if (num3 != 42)
				{
					goto IL_012e;
				}
				text2 = (DutyName = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text2 == 8)
			{
				num4 = (slotId_ = input.ReadInt32());
			}
			if (num4 == 16)
			{
				int num5 = (dutyId_ = input.ReadInt32());
			}
			goto IL_012e;
			IL_012e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008822")]
		[Cpp2IlInjected.Address(RVA = "0x1742B80", Offset = "0x1741580", VA = "0x181742B80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				int num = slotId_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008823")]
		[Cpp2IlInjected.Address(RVA = "0x1746B80", Offset = "0x1745580", VA = "0x181746B80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0016, IL_0020, IL_0021, IL_0022, IL_002a, IL_0032, IL_0043, IL_0049, IL_004f
			//IL_000d: Expected I4, but got O
			//IL_0015: Expected I4, but got O
			//IL_001f: Expected O, but got I4
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				slotId_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008824")]
		[Cpp2IlInjected.Address(RVA = "0x17416A0", Offset = "0x17400A0", VA = "0x1817416A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0012, IL_0013, IL_0016, IL_0017, IL_0018
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				slotId_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008825")]
		[Cpp2IlInjected.Address(RVA = "0x1749220", Offset = "0x1747C20", VA = "0x181749220")]
		static DutySlot()
		{
			_parser = (MessageParser<DutySlot>)(object)FieldCodec.ForInt32(74u);
			/*Error: Unexpected end of block*/;
		}
	}
}
