using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Character;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Gameloft.Rpc.Core.Server;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Meta.Online;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A5D")]
	public class TransactionServiceServerImpl : TransactionService.TransactionServiceBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40028FE")]
		private readonly ProfileEventDispatcher Dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40028FF")]
		private readonly IProfileHolder profileHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002900")]
		private readonly NetworkDataProvider networkData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002901")]
		private readonly ServerTransactionContext serverTransactionContext;

		[Cpp2IlInjected.Token(Token = "0x17000EC2")]
		public Player Player
		{
			[Cpp2IlInjected.Token(Token = "0x60059AA")]
			[Cpp2IlInjected.Address(RVA = "0x7A7DD0", Offset = "0x7A67D0", VA = "0x1807A7DD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC3")]
		public World World
		{
			[Cpp2IlInjected.Token(Token = "0x60059AB")]
			[Cpp2IlInjected.Address(RVA = "0x7A7EA0", Offset = "0x7A68A0", VA = "0x1807A7EA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC4")]
		public NetworkDataProvider NetworkData
		{
			[Cpp2IlInjected.Token(Token = "0x60059AD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return networkData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC5")]
		public IProfileHolder ProfileHolder
		{
			[Cpp2IlInjected.Token(Token = "0x60059AE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return profileHolder;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC6")]
		public Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x60059AF")]
			[Cpp2IlInjected.Address(RVA = "0x7A7E50", Offset = "0x7A6850", VA = "0x1807A7E50")]
			get
			{
				IProfileHolder profileHolder = this.profileHolder;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005929")]
		[Cpp2IlInjected.Address(RVA = "0x7A1C70", Offset = "0x7A0670", VA = "0x1807A1C70", Slot = "100")]
		public override Task<CreateGardeningTile.Types.Response> CreateGardeningTileAsync(CreateGardeningTile.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CreateGardeningTile.Types.Response response = new CreateGardeningTile.Types.Response();
			response.request_ = request;
			return (Task<CreateGardeningTile.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600592A")]
		[Cpp2IlInjected.Address(RVA = "0x7A5650", Offset = "0x7A4050", VA = "0x1807A5650", Slot = "101")]
		public override Task<RemoveGardeningTile.Types.Response> RemoveGardeningTileAsync(RemoveGardeningTile.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			RemoveGardeningTile.Types.Response response = new RemoveGardeningTile.Types.Response();
			response.request_ = request;
			return (Task<RemoveGardeningTile.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600592B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5230", Offset = "0x7A3C30", VA = "0x1807A5230", Slot = "102")]
		public override Task<PlantSeed.Types.Response> PlantSeedAsync(PlantSeed.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PlantSeed.Types.Response response = new PlantSeed.Types.Response();
			response.request_ = request;
			return (Task<PlantSeed.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600592C")]
		[Cpp2IlInjected.Address(RVA = "0x7A3A80", Offset = "0x7A2480", VA = "0x1807A3A80", Slot = "103")]
		public override Task<FinishGardeningSlotGrowth.Types.Response> FinishGardeningSlotGrowthAsync(FinishGardeningSlotGrowth.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			FinishGardeningSlotGrowth.Types.Response response = new FinishGardeningSlotGrowth.Types.Response();
			response.request_ = request;
			return (Task<FinishGardeningSlotGrowth.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600592D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4400", Offset = "0x7A2E00", VA = "0x1807A4400", Slot = "104")]
		public override Task<HarvestGardeningSlot.Types.Response> HarvestGardeningSlotAsync(HarvestGardeningSlot.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			HarvestGardeningSlot.Types.Response response = new HarvestGardeningSlot.Types.Response();
			response.request_ = request;
			return (Task<HarvestGardeningSlot.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600592E")]
		[Cpp2IlInjected.Address(RVA = "0x7A16F0", Offset = "0x7A00F0", VA = "0x1807A16F0", Slot = "105")]
		public override Task<CollectGardenStallSlot.Types.Response> CollectGardenStallSlotAsync(CollectGardenStallSlot.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectGardenStallSlot.Types.Response response = new CollectGardenStallSlot.Types.Response();
			response.request_ = request;
			return (Task<CollectGardenStallSlot.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600592F")]
		[Cpp2IlInjected.Address(RVA = "0x7A7CA0", Offset = "0x7A66A0", VA = "0x1807A7CA0", Slot = "106")]
		public override Task<WaterObjects.Types.Response> WaterObjectsAsync(WaterObjects.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			WaterObjects.Types.Response response = new WaterObjects.Types.Response();
			response.request_ = request;
			return (Task<WaterObjects.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005930")]
		[Cpp2IlInjected.Address(RVA = "0x7A6800", Offset = "0x7A5200", VA = "0x1807A6800", Slot = "107")]
		public override Task<StartFishing.Types.Response> StartFishingAsync(StartFishing.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StartFishing.Types.Response response = new StartFishing.Types.Response();
			response.request_ = request;
			return (Task<StartFishing.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005931")]
		[Cpp2IlInjected.Address(RVA = "0x7A6960", Offset = "0x7A5360", VA = "0x1807A6960", Slot = "111")]
		public override Task<StartHangoutWithCharacter.Types.Response> StartHangoutWithCharacterAsync(StartHangoutWithCharacter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StartHangoutWithCharacter.Types.Response response = new StartHangoutWithCharacter.Types.Response();
			response.request_ = request;
			return (Task<StartHangoutWithCharacter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005932")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C20", Offset = "0x7A5620", VA = "0x1807A6C20", Slot = "112")]
		public override Task<StopHangoutWithCharacter.Types.Response> StopHangoutWithCharacterAsync(StopHangoutWithCharacter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StopHangoutWithCharacter.Types.Response response = new StopHangoutWithCharacter.Types.Response();
			response.request_ = request;
			return (Task<StopHangoutWithCharacter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005933")]
		[Cpp2IlInjected.Address(RVA = "0x7A6750", Offset = "0x7A5150", VA = "0x1807A6750", Slot = "113")]
		public override Task<SpawnHangoutRewardsForCharacter.Types.Response> SpawnHangoutRewardsForCharacterAsync(SpawnHangoutRewardsForCharacter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SpawnHangoutRewardsForCharacter.Types.Response response = new SpawnHangoutRewardsForCharacter.Types.Response();
			response.request_ = request;
			return (Task<SpawnHangoutRewardsForCharacter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005934")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C80", Offset = "0x7A4680", VA = "0x1807A5C80", Slot = "108")]
		public override Task<SendFishingResult.Types.Response> SendFishingResultAsync(SendFishingResult.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SendFishingResult.Types.Response response = new SendFishingResult.Types.Response();
			response.request_ = request;
			return (Task<SendFishingResult.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005935")]
		[Cpp2IlInjected.Address(RVA = "0x7A7930", Offset = "0x7A6330", VA = "0x1807A7930", Slot = "109")]
		public override Task<UpdatePendingFishes.Types.Response> UpdatePendingFishesAsync(UpdatePendingFishes.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdatePendingFishes.Types.Response response = new UpdatePendingFishes.Types.Response();
			response.request_ = request;
			return (Task<UpdatePendingFishes.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005936")]
		[Cpp2IlInjected.Address(RVA = "0x7A1640", Offset = "0x7A0040", VA = "0x1807A1640", Slot = "110")]
		public override Task<CollectFishingStall.Types.Response> CollectFishingStallAsync(CollectFishingStall.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectFishingStall.Types.Response response = new CollectFishingStall.Types.Response();
			response.request_ = request;
			return (Task<CollectFishingStall.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005937")]
		[Cpp2IlInjected.Address(RVA = "0x7A7250", Offset = "0x7A5C50", VA = "0x1807A7250", Slot = "117")]
		public override Task<TransferToPantry.Types.Response> TransferToPantryAsync(TransferToPantry.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			TransferToPantry.Types.Response response = new TransferToPantry.Types.Response();
			response.request_ = request;
			return (Task<TransferToPantry.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005938")]
		[Cpp2IlInjected.Address(RVA = "0x7A1B10", Offset = "0x7A0510", VA = "0x1807A1B10", Slot = "118")]
		public override Task<CookWithIngredients.Types.Response> CookWithIngredientsAsync(CookWithIngredients.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CookWithIngredients.Types.Response response = new CookWithIngredients.Types.Response();
			response.request_ = request;
			return (Task<CookWithIngredients.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005939")]
		[Cpp2IlInjected.Address(RVA = "0x7A33A0", Offset = "0x7A1DA0", VA = "0x1807A33A0", Slot = "119")]
		public override Task<EatItem.Types.Response> EatItemAsync(EatItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			EatItem.Types.Response response = new EatItem.Types.Response();
			response.request_ = request;
			return (Task<EatItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600593A")]
		[Cpp2IlInjected.Address(RVA = "0x7A79E0", Offset = "0x7A63E0", VA = "0x1807A79E0", Slot = "120")]
		public override Task<UpdateRestaurantOrders.Types.Response> UpdateRestaurantOrdersAsync(UpdateRestaurantOrders.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdateRestaurantOrders.Types.Response response = new UpdateRestaurantOrders.Types.Response();
			response.request_ = request;
			return (Task<UpdateRestaurantOrders.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600593B")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B30", Offset = "0x7A2530", VA = "0x1807A3B30", Slot = "121")]
		public override Task<FulfillRestaurantOrders.Types.Response> FulfillRestaurantOrdersAsync(FulfillRestaurantOrders.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			FulfillRestaurantOrders.Types.Response response = new FulfillRestaurantOrders.Types.Response();
			response.request_ = request;
			return (Task<FulfillRestaurantOrders.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600593C")]
		[Cpp2IlInjected.Address(RVA = "0x7A44B0", Offset = "0x7A2EB0", VA = "0x1807A44B0", Slot = "122")]
		public override Task<HitMiningRock.Types.Response> HitMiningRockAsync(HitMiningRock.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			HitMiningRock.Types.Response response = new HitMiningRock.Types.Response();
			response.request_ = request;
			return (Task<HitMiningRock.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600593D")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BC0", Offset = "0x7A05C0", VA = "0x1807A1BC0", Slot = "123")]
		public override Task<CraftWithRecipe.Types.Response> CraftWithRecipeAsync(CraftWithRecipe.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CraftWithRecipe.Types.Response response = new CraftWithRecipe.Types.Response();
			response.request_ = request;
			return (Task<CraftWithRecipe.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600593E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E90", Offset = "0x7A4890", VA = "0x1807A5E90", Slot = "124")]
		public override Task<SetCraftingRecipeAsSeen.Types.Response> SetCraftingRecipeAsSeenAsync(SetCraftingRecipeAsSeen.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetCraftingRecipeAsSeen.Types.Response response = new SetCraftingRecipeAsSeen.Types.Response();
			response.request_ = request;
			return (Task<SetCraftingRecipeAsSeen.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600593F")]
		[Cpp2IlInjected.Address(RVA = "0x7A3450", Offset = "0x7A1E50", VA = "0x1807A3450", Slot = "52")]
		public override Task<EnableCharacter.Types.Response> EnableCharacterAsync(EnableCharacter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			EnableCharacter.Types.Response response = new EnableCharacter.Types.Response();
			response.request_ = request;
			return (Task<EnableCharacter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005940")]
		[Cpp2IlInjected.Address(RVA = "0x7A3240", Offset = "0x7A1C40", VA = "0x1807A3240", Slot = "53")]
		public override Task<DiscussWithCharacter.Types.Response> DiscussWithCharacterAsync(DiscussWithCharacter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DiscussWithCharacter.Types.Response response = new DiscussWithCharacter.Types.Response();
			response.request_ = request;
			return (Task<DiscussWithCharacter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005941")]
		[Cpp2IlInjected.Address(RVA = "0x7A5910", Offset = "0x7A4310", VA = "0x1807A5910", Slot = "54")]
		public override Task<ResetCharacterDiscussions.Types.Response> ResetCharacterDiscussionsAsync(ResetCharacterDiscussions.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ResetCharacterDiscussions.Types.Response response = new ResetCharacterDiscussions.Types.Response();
			response.request_ = request;
			return (Task<ResetCharacterDiscussions.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005942")]
		[Cpp2IlInjected.Address(RVA = "0x7A4350", Offset = "0x7A2D50", VA = "0x1807A4350", Slot = "55")]
		public override Task<GiveItemsToCharacter.Types.Response> GiveItemsToCharacterAsync(GiveItemsToCharacter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			GiveItemsToCharacter.Types.Response response = new GiveItemsToCharacter.Types.Response();
			response.request_ = request;
			return (Task<GiveItemsToCharacter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005943")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DE0", Offset = "0x7A47E0", VA = "0x1807A5DE0", Slot = "56")]
		public override Task<SetCharacterPreferredItemsAsSeen.Types.Response> SetCharacterPreferredItemsAsSeenAsync(SetCharacterPreferredItemsAsSeen.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetCharacterPreferredItemsAsSeen.Types.Response response = new SetCharacterPreferredItemsAsSeen.Types.Response();
			response.request_ = request;
			return (Task<SetCharacterPreferredItemsAsSeen.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005944")]
		[Cpp2IlInjected.Address(RVA = "0x7A0920", Offset = "0x79F320", VA = "0x1807A0920", Slot = "59")]
		public override Task<ApplyCharacterProfession.Types.Response> ApplyCharacterProfessionAsync(ApplyCharacterProfession.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ApplyCharacterProfession.Types.Response response = new ApplyCharacterProfession.Types.Response();
			response.request_ = request;
			return (Task<ApplyCharacterProfession.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005945")]
		[Cpp2IlInjected.Address(RVA = "0x7A0EB0", Offset = "0x79F8B0", VA = "0x1807A0EB0", Slot = "60")]
		public override Task<ChangeCharacterProfession.Types.Response> ChangeCharacterProfessionAsync(ChangeCharacterProfession.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ChangeCharacterProfession.Types.Response response = new ChangeCharacterProfession.Types.Response();
			response.request_ = request;
			return (Task<ChangeCharacterProfession.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005946")]
		[Cpp2IlInjected.Address(RVA = "0x7A09D0", Offset = "0x79F3D0", VA = "0x1807A09D0", Slot = "61")]
		public override Task<ApplyCharacterSkin.Types.Response> ApplyCharacterSkinAsync(ApplyCharacterSkin.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ApplyCharacterSkin.Types.Response response = new ApplyCharacterSkin.Types.Response();
			response.request_ = request;
			return (Task<ApplyCharacterSkin.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005947")]
		[Cpp2IlInjected.Address(RVA = "0x7A7670", Offset = "0x7A6070", VA = "0x1807A7670", Slot = "57")]
		public override Task<UpdateCharacterSchedules.Types.Response> UpdateCharacterSchedulesAsync(UpdateCharacterSchedules.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdateCharacterSchedules.Types.Response response = new UpdateCharacterSchedules.Types.Response();
			response.request_ = request;
			return (Task<UpdateCharacterSchedules.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005948")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BD0", Offset = "0x7A45D0", VA = "0x1807A5BD0", Slot = "58")]
		public override Task<SecretCharacterDiscovered.Types.Response> SecretCharacterDiscoveredAsync(SecretCharacterDiscovered.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SecretCharacterDiscovered.Types.Response response = new SecretCharacterDiscovered.Types.Response();
			response.request_ = request;
			return (Task<SecretCharacterDiscovered.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005949")]
		[Cpp2IlInjected.Address(RVA = "0x7A4C20", Offset = "0x7A3620", VA = "0x1807A4C20", Slot = "126")]
		public override Task<PetCompanion.Types.Response> PetCompanionAsync(PetCompanion.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PetCompanion.Types.Response response = new PetCompanion.Types.Response();
			response.request_ = request;
			return (Task<PetCompanion.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600594A")]
		[Cpp2IlInjected.Address(RVA = "0x7A39D0", Offset = "0x7A23D0", VA = "0x1807A39D0", Slot = "125")]
		public override Task<FeedCritter.Types.Response> FeedCritterAsync(FeedCritter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			FeedCritter.Types.Response response = new FeedCritter.Types.Response();
			response.request_ = request;
			return (Task<FeedCritter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600594B")]
		[Cpp2IlInjected.Address(RVA = "0x7A2D70", Offset = "0x7A1770", VA = "0x1807A2D70", Slot = "79")]
		public override Task<DebugUnlockAllCritters.Types.Response> DebugUnlockAllCrittersAsync(DebugUnlockAllCritters.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugUnlockAllCritters.Types.Response response = new DebugUnlockAllCritters.Types.Response();
			response.request_ = request;
			return (Task<DebugUnlockAllCritters.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600594C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D20", Offset = "0x7A0720", VA = "0x1807A1D20", Slot = "127")]
		public override Task<DebugAddCurrency.Types.Response> DebugAddCurrencyAsync(DebugAddCurrency.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugAddCurrency.Types.Response response = new DebugAddCurrency.Types.Response();
			response.request_ = request;
			return (Task<DebugAddCurrency.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600594D")]
		[Cpp2IlInjected.Address(RVA = "0x7A0A80", Offset = "0x79F480", VA = "0x1807A0A80", Slot = "45")]
		public override Task<AvatarTransfer.Types.Response> AvatarTransferAsync(AvatarTransfer.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			AvatarTransfer.Types.Response response = new AvatarTransfer.Types.Response();
			response.request_ = request;
			return (Task<AvatarTransfer.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600594E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D30", Offset = "0x7A4730", VA = "0x1807A5D30", Slot = "46")]
		public override Task<AvatarCustomization.Types.Response> SetAvatarCustomizationAsync(AvatarCustomization.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			AvatarCustomization.Types.Response response = new AvatarCustomization.Types.Response();
			response.request_ = request;
			return (Task<AvatarCustomization.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600594F")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F40", Offset = "0x7A4940", VA = "0x1807A5F40", Slot = "49")]
		public override Task<FurnitureCustomization.Types.Response> SetFurnitureCustomizationAsync(FurnitureCustomization.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			FurnitureCustomization.Types.Response response = new FurnitureCustomization.Types.Response();
			response.request_ = request;
			return (Task<FurnitureCustomization.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005950")]
		[Cpp2IlInjected.Address(RVA = "0x7A59C0", Offset = "0x7A43C0", VA = "0x1807A59C0", Slot = "47")]
		public override Task<SaveClothingDesign.Types.Response> SaveClothingDesignAsync(SaveClothingDesign.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SaveClothingDesign.Types.Response response = new SaveClothingDesign.Types.Response();
			response.request_ = request;
			return (Task<SaveClothingDesign.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005951")]
		[Cpp2IlInjected.Address(RVA = "0x7A30E0", Offset = "0x7A1AE0", VA = "0x1807A30E0", Slot = "48")]
		public override Task<DeleteClothingDesign.Types.Response> DeleteClothingDesignAsync(DeleteClothingDesign.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DeleteClothingDesign.Types.Response response = new DeleteClothingDesign.Types.Response();
			response.request_ = request;
			return (Task<DeleteClothingDesign.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005952")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A70", Offset = "0x7A4470", VA = "0x1807A5A70", Slot = "50")]
		public override Task<SaveFurnitureDesign.Types.Response> SaveFurnitureDesignAsync(SaveFurnitureDesign.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SaveFurnitureDesign.Types.Response response = new SaveFurnitureDesign.Types.Response();
			response.request_ = request;
			return (Task<SaveFurnitureDesign.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005953")]
		[Cpp2IlInjected.Address(RVA = "0x7A3190", Offset = "0x7A1B90", VA = "0x1807A3190", Slot = "51")]
		public override Task<DeleteFurnitureDesign.Types.Response> DeleteFurnitureDesignAsync(DeleteFurnitureDesign.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DeleteFurnitureDesign.Types.Response response = new DeleteFurnitureDesign.Types.Response();
			response.request_ = request;
			return (Task<DeleteFurnitureDesign.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005954")]
		[Cpp2IlInjected.Address(RVA = "0x7A2ED0", Offset = "0x7A18D0", VA = "0x1807A2ED0", Slot = "65")]
		public override Task<DebugUnlockCharacter.Types.Response> DebugUnlockCharacterAsync(DebugUnlockCharacter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugUnlockCharacter.Types.Response response = new DebugUnlockCharacter.Types.Response();
			response.request_ = request;
			return (Task<DebugUnlockCharacter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005955")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B60", Offset = "0x7A1560", VA = "0x1807A2B60", Slot = "66")]
		public override Task<DebugStartEvent.Types.Response> DebugStartEventAsync(DebugStartEvent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugStartEvent.Types.Response response = new DebugStartEvent.Types.Response();
			response.request_ = request;
			return (Task<DebugStartEvent.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005956")]
		[Cpp2IlInjected.Address(RVA = "0x7A22A0", Offset = "0x7A0CA0", VA = "0x1807A22A0", Slot = "67")]
		public override Task<DebugEndEvent.Types.Response> DebugEndEventAsync(DebugEndEvent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugEndEvent.Types.Response response = new DebugEndEvent.Types.Response();
			response.request_ = request;
			return (Task<DebugEndEvent.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005957")]
		[Cpp2IlInjected.Address(RVA = "0x7A2AB0", Offset = "0x7A14B0", VA = "0x1807A2AB0", Slot = "68")]
		public override Task<DebugSkipTime.Types.Response> DebugSkipTimeAsync(DebugSkipTime.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugSkipTime.Types.Response response = new DebugSkipTime.Types.Response();
			response.request_ = request;
			return (Task<DebugSkipTime.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005958")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1090", VA = "0x1807A2690", Slot = "69")]
		public override Task<DebugGenericCheat.Types.Response> DebugGenericCheatAsync(DebugGenericCheat.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugGenericCheat.Types.Response response = new DebugGenericCheat.Types.Response();
			response.request_ = request;
			return (Task<DebugGenericCheat.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005959")]
		[Cpp2IlInjected.Address(RVA = "0x7A1F30", Offset = "0x7A0930", VA = "0x1807A1F30", Slot = "70")]
		public override Task<DebugAddItem.Types.Response> DebugAddItemAsync(DebugAddItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugAddItem.Types.Response response = new DebugAddItem.Types.Response();
			response.request_ = request;
			return (Task<DebugAddItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600595A")]
		[Cpp2IlInjected.Address(RVA = "0x7A27F0", Offset = "0x7A11F0", VA = "0x1807A27F0", Slot = "71")]
		public override Task<DebugRemoveItem.Types.Response> DebugRemoveItemAsync(DebugRemoveItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugRemoveItem.Types.Response response = new DebugRemoveItem.Types.Response();
			response.request_ = request;
			return (Task<DebugRemoveItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600595B")]
		[Cpp2IlInjected.Address(RVA = "0x7A1E80", Offset = "0x7A0880", VA = "0x1807A1E80", Slot = "72")]
		public override Task<DebugAddFriendship.Types.Response> DebugAddFriendshipAsync(DebugAddFriendship.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugAddFriendship.Types.Response response = new DebugAddFriendship.Types.Response();
			response.request_ = request;
			return (Task<DebugAddFriendship.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600595C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1FE0", Offset = "0x7A09E0", VA = "0x1807A1FE0", Slot = "73")]
		public override Task<DebugAddPlayerXP.Types.Response> DebugAddPlayerXPAsync(DebugAddPlayerXP.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugAddPlayerXP.Types.Response response = new DebugAddPlayerXP.Types.Response();
			response.request_ = request;
			return (Task<DebugAddPlayerXP.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600595D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2950", Offset = "0x7A1350", VA = "0x1807A2950", Slot = "74")]
		public override Task<DebugSetPlayerLevel.Types.Response> DebugSetPlayerLevelAsync(DebugSetPlayerLevel.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugSetPlayerLevel.Types.Response response = new DebugSetPlayerLevel.Types.Response();
			response.request_ = request;
			return (Task<DebugSetPlayerLevel.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600595E")]
		[Cpp2IlInjected.Address(RVA = "0x7A28A0", Offset = "0x7A12A0", VA = "0x1807A28A0", Slot = "146")]
		public override Task<DebugResetFtueEvent.Types.Response> DebugResetFtueEventAsync(DebugResetFtueEvent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugResetFtueEvent.Types.Response response = new DebugResetFtueEvent.Types.Response();
			response.request_ = request;
			return (Task<DebugResetFtueEvent.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600595F")]
		[Cpp2IlInjected.Address(RVA = "0x7A1DD0", Offset = "0x7A07D0", VA = "0x1807A1DD0", Slot = "75")]
		public override Task<DebugAddFreeTimer.Types.Response> DebugAddFreeTimerAsync(DebugAddFreeTimer.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugAddFreeTimer.Types.Response response = new DebugAddFreeTimer.Types.Response();
			response.request_ = request;
			return (Task<DebugAddFreeTimer.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005960")]
		[Cpp2IlInjected.Address(RVA = "0x7A23D0", Offset = "0x7A0DD0", VA = "0x1807A23D0", Slot = "76")]
		public override Task<DebugForceActivityBonusReward.Types.Response> DebugForceActivityBonusRewardAsync(DebugForceActivityBonusReward.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugForceActivityBonusReward.Types.Response response = new DebugForceActivityBonusReward.Types.Response();
			response.request_ = request;
			return (Task<DebugForceActivityBonusReward.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005961")]
		[Cpp2IlInjected.Address(RVA = "0x7A2480", Offset = "0x7A0E80", VA = "0x1807A2480", Slot = "77")]
		public override Task<DebugForceBurningState.Types.Response> DebugForceBurningStateAsync(DebugForceBurningState.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugForceBurningState.Types.Response response = new DebugForceBurningState.Types.Response();
			response.request_ = request;
			return (Task<DebugForceBurningState.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005962")]
		[Cpp2IlInjected.Address(RVA = "0x7A2530", Offset = "0x7A0F30", VA = "0x1807A2530", Slot = "78")]
		public override Task<DebugForceSecretCharacter.Types.Response> DebugForceSecretCharacterAsync(DebugForceSecretCharacter.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugForceSecretCharacter.Types.Response response = new DebugForceSecretCharacter.Types.Response();
			response.request_ = request;
			return (Task<DebugForceSecretCharacter.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005963")]
		[Cpp2IlInjected.Address(RVA = "0x7A3030", Offset = "0x7A1A30", VA = "0x1807A3030", Slot = "80")]
		public override Task<DebugUnlockVillageArea.Types.Response> DebugUnlockVillageAreaAsync(DebugUnlockVillageArea.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugUnlockVillageArea.Types.Response response = new DebugUnlockVillageArea.Types.Response();
			response.request_ = request;
			return (Task<DebugUnlockVillageArea.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005964")]
		[Cpp2IlInjected.Address(RVA = "0x7A2CC0", Offset = "0x7A16C0", VA = "0x1807A2CC0", Slot = "81")]
		public override Task<DebugUnlockAllBuildings.Types.Response> DebugUnlockAllBuildingsAsync(DebugUnlockAllBuildings.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugUnlockAllBuildings.Types.Response response = new DebugUnlockAllBuildings.Types.Response();
			response.request_ = request;
			return (Task<DebugUnlockAllBuildings.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005965")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E20", Offset = "0x7A1820", VA = "0x1807A2E20", Slot = "82")]
		public override Task<DebugUnlockAllRealms.Types.Response> DebugUnlockAllRealmsAsync(DebugUnlockAllRealms.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugUnlockAllRealms.Types.Response response = new DebugUnlockAllRealms.Types.Response();
			response.request_ = request;
			return (Task<DebugUnlockAllRealms.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005966")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F80", Offset = "0x7A1980", VA = "0x1807A2F80", Slot = "83")]
		public override Task<DebugUnlockCharacterPreferredItems.Types.Response> DebugUnlockCharacterPreferredItemsAsync(DebugUnlockCharacterPreferredItems.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugUnlockCharacterPreferredItems.Types.Response response = new DebugUnlockCharacterPreferredItems.Types.Response();
			response.request_ = request;
			return (Task<DebugUnlockCharacterPreferredItems.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005967")]
		[Cpp2IlInjected.Address(RVA = "0x7A2740", Offset = "0x7A1140", VA = "0x1807A2740", Slot = "84")]
		public override Task<DebugRemoveAllForagingItems.Types.Response> DebugRemoveAllForagingItemsAsync(DebugRemoveAllForagingItems.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugRemoveAllForagingItems.Types.Response response = new DebugRemoveAllForagingItems.Types.Response();
			response.request_ = request;
			return (Task<DebugRemoveAllForagingItems.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005968")]
		[Cpp2IlInjected.Address(RVA = "0x7A21F0", Offset = "0x7A0BF0", VA = "0x1807A21F0", Slot = "85")]
		public override Task<DebugEmptyAllActivitySources.Types.Response> DebugEmptyAllActivitySourcesAsync(DebugEmptyAllActivitySources.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugEmptyAllActivitySources.Types.Response response = new DebugEmptyAllActivitySources.Types.Response();
			response.request_ = request;
			return (Task<DebugEmptyAllActivitySources.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005969")]
		[Cpp2IlInjected.Address(RVA = "0x7A2350", Offset = "0x7A0D50", VA = "0x1807A2350", Slot = "86")]
		public override Task<DebugFakeRPCException.Types.Response> DebugFakeRPCExceptionAsync(DebugFakeRPCException.Types.Request request, CallContext context)
		{
			new DebugFakeRPCException.Types.Response().request_ = request;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600596A")]
		[Cpp2IlInjected.Address(RVA = "0x7A7A90", Offset = "0x7A6490", VA = "0x1807A7A90", Slot = "161")]
		public override Task<UpdateRoyalDutySlots.Types.Response> UpdateRoyalDutySlotsAsync(UpdateRoyalDutySlots.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdateRoyalDutySlots.Types.Response response = new UpdateRoyalDutySlots.Types.Response();
			response.request_ = request;
			return (Task<UpdateRoyalDutySlots.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600596B")]
		[Cpp2IlInjected.Address(RVA = "0x7A1900", Offset = "0x7A0300", VA = "0x1807A1900", Slot = "162")]
		public override Task<CollectRoyalDutyReward.Types.Response> CollectRoyalDutyRewardAsync(CollectRoyalDutyReward.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectRoyalDutyReward.Types.Response response = new CollectRoyalDutyReward.Types.Response();
			response.request_ = request;
			return (Task<CollectRoyalDutyReward.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600596C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1430", Offset = "0x79FE30", VA = "0x1807A1430", Slot = "164")]
		public override Task<CollectAchievementReward.Types.Response> CollectAchievementRewardAsync(CollectAchievementReward.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectAchievementReward.Types.Response response = new CollectAchievementReward.Types.Response();
			response.request_ = request;
			return (Task<CollectAchievementReward.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600596D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2140", Offset = "0x7A0B40", VA = "0x1807A2140", Slot = "165")]
		public override Task<DebugCompleteAchievementMilestone.Types.Response> DebugCompleteAchievementMilestoneAsync(DebugCompleteAchievementMilestone.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugCompleteAchievementMilestone.Types.Response response = new DebugCompleteAchievementMilestone.Types.Response();
			response.request_ = request;
			return (Task<DebugCompleteAchievementMilestone.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600596E")]
		[Cpp2IlInjected.Address(RVA = "0x7A25E0", Offset = "0x7A0FE0", VA = "0x1807A25E0", Slot = "163")]
		public override Task<DebugGenerateNewRoyalDuties.Types.Response> DebugGenerateNewRoyalDutiesAsync(DebugGenerateNewRoyalDuties.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugGenerateNewRoyalDuties.Types.Response response = new DebugGenerateNewRoyalDuties.Types.Response();
			response.request_ = request;
			return (Task<DebugGenerateNewRoyalDuties.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600596F")]
		[Cpp2IlInjected.Address(RVA = "0x7A12D0", Offset = "0x79FCD0", VA = "0x1807A12D0", Slot = "89")]
		public override Task<ClaimMiniEventReward.Types.Response> ClaimMiniEventRewardAsync(ClaimMiniEventReward.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ClaimMiniEventReward.Types.Response response = new ClaimMiniEventReward.Types.Response();
			response.request_ = request;
			return (Task<ClaimMiniEventReward.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005970")]
		[Cpp2IlInjected.Address(RVA = "0x7A3710", Offset = "0x7A2110", VA = "0x1807A3710", Slot = "129")]
		public override Task<ExecuteCampaignEvent.Types.Response> ExecuteCampaignEventAsync(ExecuteCampaignEvent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ExecuteCampaignEvent.Types.Response response = new ExecuteCampaignEvent.Types.Response();
			response.request_ = request;
			return (Task<ExecuteCampaignEvent.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005971")]
		[Cpp2IlInjected.Address(RVA = "0x7A68B0", Offset = "0x7A52B0", VA = "0x1807A68B0", Slot = "144")]
		public override Task<StartFtueEvent.Types.Response> StartFtueEventAsync(StartFtueEvent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StartFtueEvent.Types.Response response = new StartFtueEvent.Types.Response();
			response.request_ = request;
			return (Task<StartFtueEvent.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005972")]
		[Cpp2IlInjected.Address(RVA = "0x7A3500", Offset = "0x7A1F00", VA = "0x1807A3500", Slot = "145")]
		public override Task<EndFtueEvent.Types.Response> EndFtueEventAsync(EndFtueEvent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			EndFtueEvent.Types.Response response = new EndFtueEvent.Types.Response();
			response.request_ = request;
			return (Task<EndFtueEvent.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005973")]
		[Cpp2IlInjected.Address(RVA = "0x7A7040", Offset = "0x7A5A40", VA = "0x1807A7040", Slot = "43")]
		public override Task<SwitchPictureFrame.Types.Response> SwitchPictureFrameAsync(SwitchPictureFrame.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SwitchPictureFrame.Types.Response response = new SwitchPictureFrame.Types.Response();
			response.request_ = request;
			return (Task<SwitchPictureFrame.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005974")]
		[Cpp2IlInjected.Address(RVA = "0x7A7460", Offset = "0x7A5E60", VA = "0x1807A7460", Slot = "167")]
		public override Task<UnlockStorage.Types.Response> UnlockStorageAsync(UnlockStorage.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UnlockStorage.Types.Response response = new UnlockStorage.Types.Response();
			response.request_ = request;
			return (Task<UnlockStorage.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005975")]
		[Cpp2IlInjected.Address(RVA = "0x7A60A0", Offset = "0x7A4AA0", VA = "0x1807A60A0", Slot = "38")]
		public override Task<SetFurnitureToggleState.Types.Response> SetFurnitureToggleStateAsync(SetFurnitureToggleState.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetFurnitureToggleState.Types.Response response = new SetFurnitureToggleState.Types.Response();
			response.request_ = request;
			return (Task<SetFurnitureToggleState.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005976")]
		[Cpp2IlInjected.Address(RVA = "0x7A5FF0", Offset = "0x7A49F0", VA = "0x1807A5FF0", Slot = "39")]
		public override Task<SetFurnitureIndexState.Types.Response> SetFurnitureIndexStateAsync(SetFurnitureIndexState.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetFurnitureIndexState.Types.Response response = new SetFurnitureIndexState.Types.Response();
			response.request_ = request;
			return (Task<SetFurnitureIndexState.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005977")]
		[Cpp2IlInjected.Address(RVA = "0x7A5180", Offset = "0x7A3B80", VA = "0x1807A5180", Slot = "14")]
		public override Task<PlaceOnGrid.Types.Response> PlaceOnGridAsync(PlaceOnGrid.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PlaceOnGrid.Types.Response response = new PlaceOnGrid.Types.Response();
			response.request_ = request;
			return (Task<PlaceOnGrid.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005978")]
		[Cpp2IlInjected.Address(RVA = "0x7A55A0", Offset = "0x7A3FA0", VA = "0x1807A55A0", Slot = "15")]
		public override Task<RemoveFromGrid.Types.Response> RemoveFromGridAsync(RemoveFromGrid.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			RemoveFromGrid.Types.Response response = new RemoveFromGrid.Types.Response();
			response.request_ = request;
			return (Task<RemoveFromGrid.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005979")]
		[Cpp2IlInjected.Address(RVA = "0x7A54F0", Offset = "0x7A3EF0", VA = "0x1807A54F0", Slot = "16")]
		public override Task<RemoveBlocker.Types.Response> RemoveBlockerAsync(RemoveBlocker.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			RemoveBlocker.Types.Response response = new RemoveBlocker.Types.Response();
			response.request_ = request;
			return (Task<RemoveBlocker.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600597A")]
		[Cpp2IlInjected.Address(RVA = "0x7A77D0", Offset = "0x7A61D0", VA = "0x1807A77D0", Slot = "29")]
		public override Task<UpdateGridObjectTransform.Types.Response> UpdateGridObjectTransformAsync(UpdateGridObjectTransform.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdateGridObjectTransform.Types.Response response = new UpdateGridObjectTransform.Types.Response();
			response.request_ = request;
			return (Task<UpdateGridObjectTransform.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600597B")]
		[Cpp2IlInjected.Address(RVA = "0x7A6F90", Offset = "0x7A5990", VA = "0x1807A6F90", Slot = "30")]
		public override Task<SwitchGridObjectGrid.Types.Response> SwitchGridObjectGridAsync(SwitchGridObjectGrid.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SwitchGridObjectGrid.Types.Response response = new SwitchGridObjectGrid.Types.Response();
			response.request_ = request;
			return (Task<SwitchGridObjectGrid.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600597C")]
		[Cpp2IlInjected.Address(RVA = "0x7A5860", Offset = "0x7A4260", VA = "0x1807A5860", Slot = "31")]
		public override Task<ReplaceGridObject.Types.Response> ReplaceGridObjectAsync(ReplaceGridObject.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ReplaceGridObject.Types.Response response = new ReplaceGridObject.Types.Response();
			response.request_ = request;
			return (Task<ReplaceGridObject.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600597D")]
		[Cpp2IlInjected.Address(RVA = "0x7A50D0", Offset = "0x7A3AD0", VA = "0x1807A50D0", Slot = "28")]
		public override Task<PlaceLandscapingItem.Types.Response> PlaceLandscapingItemAsync(PlaceLandscapingItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PlaceLandscapingItem.Types.Response response = new PlaceLandscapingItem.Types.Response();
			response.request_ = request;
			return (Task<PlaceLandscapingItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600597E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5020", Offset = "0x7A3A20", VA = "0x1807A5020", Slot = "114")]
		public override Task<PlaceBuilding.Types.Response> PlaceBuildingAsync(PlaceBuilding.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PlaceBuilding.Types.Response response = new PlaceBuilding.Types.Response();
			response.request_ = request;
			return (Task<PlaceBuilding.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600597F")]
		[Cpp2IlInjected.Address(RVA = "0x7A5700", Offset = "0x7A4100", VA = "0x1807A5700", Slot = "115")]
		public override Task<RemoveHouse.Types.Response> RemoveHouseAsync(RemoveHouse.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			RemoveHouse.Types.Response response = new RemoveHouse.Types.Response();
			response.request_ = request;
			return (Task<RemoveHouse.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005980")]
		[Cpp2IlInjected.Address(RVA = "0x7A0B30", Offset = "0x79F530", VA = "0x1807A0B30", Slot = "116")]
		public override Task<BuildHouse.Types.Response> BuildHouseAsync(BuildHouse.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			BuildHouse.Types.Response response = new BuildHouse.Types.Response();
			response.request_ = request;
			return (Task<BuildHouse.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005981")]
		[Cpp2IlInjected.Address(RVA = "0x7A4B70", Offset = "0x7A3570", VA = "0x1807A4B70", Slot = "32")]
		public override Task<MoveInContainerInventory.Types.Response> MoveInContainerInventoryAsync(MoveInContainerInventory.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			MoveInContainerInventory.Types.Response response = new MoveInContainerInventory.Types.Response();
			response.request_ = request;
			return (Task<MoveInContainerInventory.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005982")]
		[Cpp2IlInjected.Address(RVA = "0x7A66A0", Offset = "0x7A50A0", VA = "0x1807A66A0", Slot = "33")]
		public override Task<SortContainerInventory.Types.Response> SortContainerInventoryAsync(SortContainerInventory.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SortContainerInventory.Types.Response response = new SortContainerInventory.Types.Response();
			response.request_ = request;
			return (Task<SortContainerInventory.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005983")]
		[Cpp2IlInjected.Address(RVA = "0x7A65F0", Offset = "0x7A4FF0", VA = "0x1807A65F0", Slot = "34")]
		public override Task<SmartInventoryTransfer.Types.Response> SmartInventoryTransferAsync(SmartInventoryTransfer.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SmartInventoryTransfer.Types.Response response = new SmartInventoryTransfer.Types.Response();
			response.request_ = request;
			return (Task<SmartInventoryTransfer.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005984")]
		[Cpp2IlInjected.Address(RVA = "0x7A4CD0", Offset = "0x7A36D0", VA = "0x1807A4CD0", Slot = "22")]
		public override Task<PickUpContainerItem.Types.Response> PickUpContainerItemAsync(PickUpContainerItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PickUpContainerItem.Types.Response response = new PickUpContainerItem.Types.Response();
			response.request_ = request;
			return (Task<PickUpContainerItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005985")]
		[Cpp2IlInjected.Address(RVA = "0x7A5390", Offset = "0x7A3D90", VA = "0x1807A5390", Slot = "23")]
		public override Task<PutDownContainerItem.Types.Response> PutDownContainerItemAsync(PutDownContainerItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PutDownContainerItem.Types.Response response = new PutDownContainerItem.Types.Response();
			response.request_ = request;
			return (Task<PutDownContainerItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005986")]
		[Cpp2IlInjected.Address(RVA = "0x7A32F0", Offset = "0x7A1CF0", VA = "0x1807A32F0", Slot = "24")]
		public override Task<DropContainerInventoryStack.Types.Response> DropContainerInventoryStackAsync(DropContainerInventoryStack.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DropContainerInventoryStack.Types.Response response = new DropContainerInventoryStack.Types.Response();
			response.request_ = request;
			return (Task<DropContainerInventoryStack.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005987")]
		[Cpp2IlInjected.Address(RVA = "0x7A4E30", Offset = "0x7A3830", VA = "0x1807A4E30", Slot = "25")]
		public override Task<PickUpListItem.Types.Response> PickUpListItemAsync(PickUpListItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PickUpListItem.Types.Response response = new PickUpListItem.Types.Response();
			response.request_ = request;
			return (Task<PickUpListItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005988")]
		[Cpp2IlInjected.Address(RVA = "0x7A5440", Offset = "0x7A3E40", VA = "0x1807A5440", Slot = "26")]
		public override Task<PutDownListItem.Types.Response> PutDownListItemAsync(PutDownListItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PutDownListItem.Types.Response response = new PutDownListItem.Types.Response();
			response.request_ = request;
			return (Task<PutDownListItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005989")]
		[Cpp2IlInjected.Address(RVA = "0x7A4D80", Offset = "0x7A3780", VA = "0x1807A4D80", Slot = "27")]
		public override Task<PickUpItem.Types.Response> PickUpItemAsync(PickUpItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PickUpItem.Types.Response response = new PickUpItem.Types.Response();
			response.request_ = request;
			return (Task<PickUpItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600598A")]
		[Cpp2IlInjected.Address(RVA = "0x7A07C0", Offset = "0x79F1C0", VA = "0x1807A07C0", Slot = "35")]
		public override Task<AddItemToKeyhole.Types.Response> AddItemToKeyholeAsync(AddItemToKeyhole.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			AddItemToKeyhole.Types.Response response = new AddItemToKeyhole.Types.Response();
			response.request_ = request;
			return (Task<AddItemToKeyhole.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600598B")]
		[Cpp2IlInjected.Address(RVA = "0x7A57B0", Offset = "0x7A41B0", VA = "0x1807A57B0", Slot = "36")]
		public override Task<RemoveItemFromKeyhole.Types.Response> RemoveItemFromKeyholeAsync(RemoveItemFromKeyhole.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			RemoveItemFromKeyhole.Types.Response response = new RemoveItemFromKeyhole.Types.Response();
			response.request_ = request;
			return (Task<RemoveItemFromKeyhole.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600598C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6EE0", Offset = "0x7A58E0", VA = "0x1807A6EE0", Slot = "37")]
		public override Task<SwapItemInKeyhole.Types.Response> SwapItemInKeyholeAsync(SwapItemInKeyhole.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SwapItemInKeyhole.Types.Response response = new SwapItemInKeyhole.Types.Response();
			response.request_ = request;
			return (Task<SwapItemInKeyhole.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600598D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2C10", Offset = "0x7A1610", VA = "0x1807A2C10", Slot = "98")]
		public override Task<DebugTestMission.Types.Response> DebugTestMissionAsync(DebugTestMission.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugTestMission.Types.Response response = new DebugTestMission.Types.Response();
			response.request_ = request;
			return (Task<DebugTestMission.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600598E")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A00", Offset = "0x7A1400", VA = "0x1807A2A00", Slot = "99")]
		public override Task<DebugSkipMissionStep.Types.Response> DebugSkipMissionStepAsync(DebugSkipMissionStep.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugSkipMissionStep.Types.Response response = new DebugSkipMissionStep.Types.Response();
			response.request_ = request;
			return (Task<DebugSkipMissionStep.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600598F")]
		[Cpp2IlInjected.Address(RVA = "0x7A6AC0", Offset = "0x7A54C0", VA = "0x1807A6AC0", Slot = "90")]
		public override Task<StartMission.Types.Response> StartMissionAsync(StartMission.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StartMission.Types.Response response = new StartMission.Types.Response();
			response.request_ = request;
			return (Task<StartMission.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005990")]
		[Cpp2IlInjected.Address(RVA = "0x7A7720", Offset = "0x7A6120", VA = "0x1807A7720", Slot = "91")]
		public override Task<UpdateDialogueFlags.Types.Response> UpdateDialogueFlagsAsync(UpdateDialogueFlags.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdateDialogueFlags.Types.Response response = new UpdateDialogueFlags.Types.Response();
			response.request_ = request;
			return (Task<UpdateDialogueFlags.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005991")]
		[Cpp2IlInjected.Address(RVA = "0x7A4A10", Offset = "0x7A3410", VA = "0x1807A4A10", Slot = "96")]
		public override Task<MissionCompleteStep.Types.Response> MissionCompleteStepAsync(MissionCompleteStep.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			MissionCompleteStep.Types.Response response = new MissionCompleteStep.Types.Response();
			response.request_ = request;
			return (Task<MissionCompleteStep.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005992")]
		[Cpp2IlInjected.Address(RVA = "0x7A35B0", Offset = "0x7A1FB0", VA = "0x1807A35B0", Slot = "87")]
		public override Task<EndMission.Types.Response> EndMissionAsync(EndMission.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			EndMission.Types.Response response = new EndMission.Types.Response();
			response.request_ = request;
			return (Task<EndMission.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005993")]
		[Cpp2IlInjected.Address(RVA = "0x7A2090", Offset = "0x7A0A90", VA = "0x1807A2090", Slot = "97")]
		public override Task<DebugCancelMission.Types.Response> DebugCancelMissionAsync(DebugCancelMission.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugCancelMission.Types.Response response = new DebugCancelMission.Types.Response();
			response.request_ = request;
			return (Task<DebugCancelMission.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005994")]
		[Cpp2IlInjected.Address(RVA = "0x7A71A0", Offset = "0x7A5BA0", VA = "0x1807A71A0", Slot = "92")]
		public override Task<TrackMission.Types.Response> TrackMissionAsync(TrackMission.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			TrackMission.Types.Response response = new TrackMission.Types.Response();
			response.request_ = request;
			return (Task<TrackMission.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005995")]
		[Cpp2IlInjected.Address(RVA = "0x7A6280", Offset = "0x7A4C80", VA = "0x1807A6280", Slot = "93")]
		public override Task<SetMissionNextChoice.Types.Response> SetMissionNextChoiceAsync(SetMissionNextChoice.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetMissionNextChoice.Types.Response response = new SetMissionNextChoice.Types.Response();
			response.request_ = request;
			return (Task<SetMissionNextChoice.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005996")]
		[Cpp2IlInjected.Address(RVA = "0x7A4560", Offset = "0x7A2F60", VA = "0x1807A4560", Slot = "88")]
		public override Task<InitTLE.Types.Response> InitTLEAsync(InitTLE.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_001d
			InitTLE.Types.Response response = new InitTLE.Types.Response();
			Timestamp timestamp = (response.serverTime_ = request.serverTime_);
			return (Task<InitTLE.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005997")]
		[Cpp2IlInjected.Address(RVA = "0x7A3BE0", Offset = "0x7A25E0", VA = "0x1807A3BE0")]
		public static MultiReward GenerateMissionRewards(Item characterItem, Func<int> missionIndex, Func<int> missionCount, MissionReward reward, Random random)
		{
			//Discarded unreachable code: IL_0105, IL_010b, IL_0111, IL_0117, IL_011d
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected I4, but got Unknown
			//IL_007d: Expected I4, but got O
			//IL_0085: Expected I4, but got O
			//IL_00ba: Expected I4, but got I8
			int itemID = characterItem.ItemID;
			MultiReward multiReward = new MultiReward();
			if (reward != null)
			{
				MissionReward.FriendshipOneofCase friendshipCase_ = reward.friendshipCase_;
				if (friendshipCase_ != 0 && friendshipCase_ == MissionReward.FriendshipOneofCase.FriendshipOverride)
				{
					int min_ = reward.FriendshipOverride.min_;
					int max_ = reward.FriendshipOverride.max_;
					MissionRewardRange friendshipOverride = reward.FriendshipOverride;
					int min_2 = friendshipOverride.min_;
					max_ -= min_2;
					min_ += friendshipOverride;
				}
				RepeatedField<FriendshipLevel> repeatedField = default(RepeatedField<FriendshipLevel>);
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				int index = 0;
				RepeatedField<FriendshipLevel> repeatedField2 = default(RepeatedField<FriendshipLevel>);
				int xP_ = ((FriendshipLevel)((RepeatedField<T>)(object)repeatedField2)[index]).xP_;
				int num = (int)missionIndex();
				int missionCount2 = (int)missionCount();
				xP_ = reward.GetAmount(num, missionCount2, xP_);
				if (xP_ > 0)
				{
					FriendshipReward friendshipReward = new FriendshipReward();
					friendshipReward.id_ = itemID;
					friendshipReward.amount_ = xP_;
					friendshipReward.source_ = FriendshipSource.Mission;
					RepeatedField<AnyReward> rewards_ = multiReward.rewards_;
					AnyReward item = AnyReward.From(friendshipReward);
					((RepeatedField<T>)(object)rewards_).Add((T)item);
				}
				bool flag = default(bool);
				if (reward.currency_ != null && flag)
				{
					num += (flag ? 1 : 0);
					RepeatedField<AnyReward> rewards_2 = multiReward.rewards_;
					ItemReward reward2 = default(ItemReward);
					AnyReward item2 = AnyReward.From(reward2);
					((RepeatedField<T>)(object)rewards_2).Add((T)item2);
				}
			}
			return multiReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6005998")]
		[Cpp2IlInjected.Address(RVA = "0x7A3920", Offset = "0x7A2320", VA = "0x1807A3920", Slot = "148")]
		public override Task<ExpandPlayerHouseRoom.Types.Response> ExpandPlayerHouseRoomAsync(ExpandPlayerHouseRoom.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ExpandPlayerHouseRoom.Types.Response response = new ExpandPlayerHouseRoom.Types.Response();
			response.request_ = request;
			return (Task<ExpandPlayerHouseRoom.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6005999")]
		[Cpp2IlInjected.Address(RVA = "0x7A48B0", Offset = "0x7A32B0", VA = "0x1807A48B0", Slot = "149")]
		public override Task<ManagePlayerHouseRoom.Types.Response> ManagePlayerHouseRoomAsync(ManagePlayerHouseRoom.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ManagePlayerHouseRoom.Types.Response response = new ManagePlayerHouseRoom.Types.Response();
			response.request_ = request;
			return (Task<ManagePlayerHouseRoom.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600599A")]
		[Cpp2IlInjected.Address(RVA = "0x7A0870", Offset = "0x79F270", VA = "0x1807A0870", Slot = "150")]
		public override Task<AddPlayerHouseFloor.Types.Response> AddPlayerHouseFloorAsync(AddPlayerHouseFloor.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			AddPlayerHouseFloor.Types.Response response = new AddPlayerHouseFloor.Types.Response();
			response.request_ = request;
			return (Task<AddPlayerHouseFloor.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600599B")]
		[Cpp2IlInjected.Address(RVA = "0x7A10C0", Offset = "0x79FAC0", VA = "0x1807A10C0", Slot = "151")]
		public override Task<ChangePlayerHouseFlooring.Types.Response> ChangePlayerHouseFlooringAsync(ChangePlayerHouseFlooring.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ChangePlayerHouseFlooring.Types.Response response = new ChangePlayerHouseFlooring.Types.Response();
			response.request_ = request;
			return (Task<ChangePlayerHouseFlooring.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600599C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1170", Offset = "0x79FB70", VA = "0x1807A1170", Slot = "152")]
		public override Task<ChangePlayerHouseWallpaper.Types.Response> ChangePlayerHouseWallpaperAsync(ChangePlayerHouseWallpaper.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ChangePlayerHouseWallpaper.Types.Response response = new ChangePlayerHouseWallpaper.Types.Response();
			response.request_ = request;
			return (Task<ChangePlayerHouseWallpaper.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600599D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6490", Offset = "0x7A4E90", VA = "0x1807A6490", Slot = "130")]
		public override Task<ShopRefresh.Types.Response> ShopRefreshAsync(ShopRefresh.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ShopRefresh.Types.Response response = new ShopRefresh.Types.Response();
			response.request_ = request;
			return (Task<ShopRefresh.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600599E")]
		[Cpp2IlInjected.Address(RVA = "0x7A63E0", Offset = "0x7A4DE0", VA = "0x1807A63E0", Slot = "131")]
		public override Task<ShopBuyItem.Types.Response> ShopBuyItemAsync(ShopBuyItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ShopBuyItem.Types.Response response = new ShopBuyItem.Types.Response();
			response.request_ = request;
			return (Task<ShopBuyItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600599F")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E30", Offset = "0x7A5830", VA = "0x1807A6E30", Slot = "133")]
		public override Task<StoreRefresh.Types.Response> StoreRefreshAsync(StoreRefresh.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StoreRefresh.Types.Response response = new StoreRefresh.Types.Response();
			response.request_ = request;
			return (Task<StoreRefresh.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D80", Offset = "0x7A5780", VA = "0x1807A6D80", Slot = "134")]
		public override Task<StoreBuyItem.Types.Response> StoreBuyItemAsync(StoreBuyItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StoreBuyItem.Types.Response response = new StoreBuyItem.Types.Response();
			response.request_ = request;
			return (Task<StoreBuyItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4060", Offset = "0x7A2A60", VA = "0x1807A4060", Slot = "135")]
		public override Task<GenericBuyItem.Types.Response> GenericBuyItemAsync(GenericBuyItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			GenericBuyItem.Types.Response response = new GenericBuyItem.Types.Response();
			response.request_ = request;
			return (Task<GenericBuyItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A2")]
		[Cpp2IlInjected.Address(RVA = "0x7A4110", Offset = "0x7A2B10", VA = "0x1807A4110", Slot = "136")]
		public override Task<GenericSellItems.Types.Response> GenericSellItemsAsync(GenericSellItems.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			GenericSellItems.Types.Response response = new GenericSellItems.Types.Response();
			response.request_ = request;
			return (Task<GenericSellItems.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A3")]
		[Cpp2IlInjected.Address(RVA = "0x7A0BE0", Offset = "0x79F5E0", VA = "0x1807A0BE0", Slot = "137")]
		public override Task<BuyDeliverySystem.Types.Response> BuyDeliverySystemAsync(BuyDeliverySystem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			BuyDeliverySystem.Types.Response response = new BuyDeliverySystem.Types.Response();
			response.request_ = request;
			return (Task<BuyDeliverySystem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A4")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A60", Offset = "0x7A0460", VA = "0x1807A1A60", Slot = "138")]
		public override Task<ConvertToDreamDust.Types.Response> ConvertToDreamDustAsync(ConvertToDreamDust.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ConvertToDreamDust.Types.Response response = new ConvertToDreamDust.Types.Response();
			response.request_ = request;
			return (Task<ConvertToDreamDust.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A0E00", Offset = "0x79F800", VA = "0x1807A0E00", Slot = "139")]
		public override Task<BuySoftCurrency.Types.Response> BuySoftCurrencyAsync(BuySoftCurrency.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			BuySoftCurrency.Types.Response response = new BuySoftCurrency.Types.Response();
			response.request_ = request;
			return (Task<BuySoftCurrency.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A5D00", VA = "0x1807A7300", Slot = "140")]
		public override Task<UnlockBuilding.Types.Response> UnlockBuildingAsync(UnlockBuilding.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UnlockBuilding.Types.Response response = new UnlockBuilding.Types.Response();
			response.request_ = request;
			return (Task<UnlockBuilding.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A7BF0", Offset = "0x7A65F0", VA = "0x1807A7BF0", Slot = "141")]
		public override Task<UpgradeBuilding.Types.Response> UpgradeBuildingAsync(UpgradeBuilding.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpgradeBuilding.Types.Response response = new UpgradeBuilding.Types.Response();
			response.request_ = request;
			return (Task<UpgradeBuilding.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A8")]
		[Cpp2IlInjected.Address(RVA = "0x7A6540", Offset = "0x7A4F40", VA = "0x1807A6540", Slot = "132")]
		public override Task<ShopSellItems.Types.Response> ShopSellItemsAsync(ShopSellItems.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ShopSellItems.Types.Response response = new ShopSellItems.Types.Response();
			response.request_ = request;
			return (Task<ShopSellItems.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A0D50", Offset = "0x79F750", VA = "0x1807A0D50", Slot = "142")]
		public override Task<BuyOffline.Types.Response> BuyOfflineAsync(BuyOffline.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			BuyOffline.Types.Response response = new BuyOffline.Types.Response();
			response.request_ = request;
			return (Task<BuyOffline.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A4330", Offset = "0x7A2D30", VA = "0x1807A4330")]
		internal ServerTransactionContext GetTransactionContext(Profile profile, CallContext callContext)
		{
			//Discarded unreachable code: IL_000e
			return serverTransactionContext.PrepareForTransaction(profile, callContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60059B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A7D50", Offset = "0x7A6750", VA = "0x1807A7D50")]
		public TransactionServiceServerImpl(IProfileHolder profileHolder, ProfileEventDispatcher dispatcher, NetworkDataProvider networkData, ServerTransactionContext serverTransactionContext)
		{
			//IL_0022: Expected O, but got I4
			this.profileHolder = profileHolder;
			Dispatcher = dispatcher;
			this.networkData = networkData;
			this.serverTransactionContext = (ServerTransactionContext)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60059B1")]
		[Cpp2IlInjected.Address(RVA = "0x175B310", Offset = "0x1759D10", VA = "0x18175B310")]
		private Task<> ApplyTransaction<TResponse>(TResponse response, CallContext P_1) where TResponse : ITransactionAction
		{
			//Discarded unreachable code: IL_004d
			int num = 0;
			NetworkDataProvider networkDataProvider = networkData;
			Profile profile = Profile;
			NetworkDataProvider networkDataProvider2 = networkData;
			int playerId = P_1.RequestMetadata.GetPlayerId();
			ProfileEventDispatcher dispatcher = Dispatcher;
			Profile profile2 = Profile;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			ServerTransactionContext serverTransactionContext = default(ServerTransactionContext);
			if (serverTransactionContext != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60059B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A4F90", Offset = "0x7A3990", VA = "0x1807A4F90", Slot = "8")]
		public override Task<Ping.Types.Response> PingAsync(Ping.Types.Request request, CallContext context)
		{
			return (Task<Ping.Types.Response>)(object)Task.FromResult(new Ping.Types.Response());
		}

		[Cpp2IlInjected.Token(Token = "0x60059B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B20", Offset = "0x7A4520", VA = "0x1807A5B20", Slot = "9")]
		public override Task<SaveProfile.Types.Response> SaveProfileAsync(SaveProfile.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SaveProfile.Types.Response response = new SaveProfile.Types.Response();
			response.request_ = request;
			return (Task<SaveProfile.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A4610", Offset = "0x7A3010", VA = "0x1807A4610", Slot = "19")]
		public override Task<InitWithServerProfile.Types.Response> InitWithServerProfileAsync(InitWithServerProfile.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0048
			int num = 0;
			ServerTransactionContext serverTransactionContext = this.serverTransactionContext;
			Profile profile_ = request.profile_;
			ServerTransactionContext serverTransactionContext2 = serverTransactionContext.PrepareForTransaction(profile_, context);
			ProfileEventDispatcher dispatcher = Dispatcher;
			Profile profile_2 = request.profile_;
			profileHolder.Init(profile_2, serverTransactionContext2, dispatcher);
			if (serverTransactionContext2 != null)
			{
			}
			return (Task<InitWithServerProfile.Types.Response>)(object)Task.FromResult(new InitWithServerProfile.Types.Response());
		}

		[Cpp2IlInjected.Token(Token = "0x60059B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4750", Offset = "0x7A3150", VA = "0x1807A4750", Slot = "17")]
		[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__149))]
		public override Task<Login.Types.Response> LoginAsync(Login.Types.Request request, CallContext context)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Login.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60059B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A06F0", Offset = "0x79F0F0", VA = "0x1807A06F0", Slot = "18")]
		public override Task<Actualize.Types.Response> ActualizeAsync(Actualize.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0015
			Actualize.Types.Response response = new Actualize.Types.Response();
			Actualize.Types.Request request2 = new Actualize.Types.Request();
			return (Task<Actualize.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A41C0", Offset = "0x7A2BC0", VA = "0x1807A41C0")]
		[AsyncStateMachine(typeof(_003CGetProfileAsync_003Ed__151))]
		public Task<LoadAndInitProfileResult> GetProfileAsync(TimeSpan playerTimeZoneOffset, DeviceInfo deviceInfo, bool isDev, CallContext callContext)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LoadAndInitProfileResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60059B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C90", Offset = "0x79F690", VA = "0x1807A0C90", Slot = "44")]
		public override Task<BuyItem.Types.Response> BuyItemAsync(BuyItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0036
			//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			//IL_002d: Expected I4, but got I8
			BuyItem.Types.Response response = new BuyItem.Types.Response();
			response.request_ = request;
			response.itemId_ = 1003;
			response.quantity_ = 1;
			response.goldCost_ = 18;
			return (Task<BuyItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A3870", Offset = "0x7A2270", VA = "0x1807A3870", Slot = "128")]
		public override Task<ExecuteRecurringEvent.Types.Response> ExecuteRecurringEventAsync(ExecuteRecurringEvent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ExecuteRecurringEvent.Types.Response response = new ExecuteRecurringEvent.Types.Response();
			response.request_ = request;
			return (Task<ExecuteRecurringEvent.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059BA")]
		[Cpp2IlInjected.Address(RVA = "0x7A3660", Offset = "0x7A2060", VA = "0x1807A3660", Slot = "12")]
		public override Task<EnterRealm.Types.Response> EnterRealmAsync(EnterRealm.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			EnterRealm.Types.Response response = new EnterRealm.Types.Response();
			response.request_ = request;
			return (Task<EnterRealm.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A73B0", Offset = "0x7A5DB0", VA = "0x1807A73B0", Slot = "13")]
		public override Task<UnlockRealm.Types.Response> UnlockRealmAsync(UnlockRealm.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UnlockRealm.Types.Response response = new UnlockRealm.Types.Response();
			response.request_ = request;
			return (Task<UnlockRealm.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A1220", Offset = "0x79FC20", VA = "0x1807A1220", Slot = "143")]
		public override Task<CheckWeatherChange.Types.Response> CheckWeatherChangeAsync(CheckWeatherChange.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CheckWeatherChange.Types.Response response = new CheckWeatherChange.Types.Response();
			response.request_ = request;
			return (Task<CheckWeatherChange.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A6150", Offset = "0x7A4B50", VA = "0x1807A6150", Slot = "147")]
		public override Task<SetHudApparition.Types.Response> SetHudApparitionAsync(SetHudApparition.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetHudApparition.Types.Response response = new SetHudApparition.Types.Response();
			response.request_ = request;
			return (Task<SetHudApparition.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A6330", Offset = "0x7A4D30", VA = "0x1807A6330", Slot = "20")]
		public override Task<SetName.Types.Response> SetNameAsync(SetName.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetName.Types.Response response = new SetName.Types.Response();
			response.request_ = request;
			return (Task<SetName.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A70F0", Offset = "0x7A5AF0", VA = "0x1807A70F0", Slot = "21")]
		public override Task<TrackClaimedFoundersPack.Types.Response> TrackClaimedFoundersPackAsync(TrackClaimedFoundersPack.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			TrackClaimedFoundersPack.Types.Response response = new TrackClaimedFoundersPack.Types.Response();
			response.request_ = request;
			return (Task<TrackClaimedFoundersPack.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A7B40", Offset = "0x7A6540", VA = "0x1807A7B40", Slot = "166")]
		public override Task<UpdateTimeAcumulated.Types.Response> UpdateTimeAcumulatedAsync(UpdateTimeAcumulated.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdateTimeAcumulated.Types.Response response = new UpdateTimeAcumulated.Types.Response();
			response.request_ = request;
			return (Task<UpdateTimeAcumulated.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4EE0", Offset = "0x7A38E0", VA = "0x1807A4EE0", Slot = "94")]
		public override Task<PictureTaken.Types.Response> PictureTakenAsync(PictureTaken.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PictureTaken.Types.Response response = new PictureTaken.Types.Response();
			response.request_ = request;
			return (Task<PictureTaken.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A4AC0", Offset = "0x7A34C0", VA = "0x1807A4AC0", Slot = "95")]
		public override Task<MissionItemInteraction.Types.Response> MissionItemInteractionAsync(MissionItemInteraction.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			MissionItemInteraction.Types.Response response = new MissionItemInteraction.Types.Response();
			response.request_ = request;
			return (Task<MissionItemInteraction.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A7510", Offset = "0x7A5F10", VA = "0x1807A7510", Slot = "62")]
		public override Task<UnlockVillageArea.Types.Response> UnlockVillageAreaAsync(UnlockVillageArea.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UnlockVillageArea.Types.Response response = new UnlockVillageArea.Types.Response();
			response.request_ = request;
			return (Task<UnlockVillageArea.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A17A0", Offset = "0x7A01A0", VA = "0x1807A17A0", Slot = "40")]
		public override Task<CollectLootPresent.Types.Response> CollectLootPresentAsync(CollectLootPresent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectLootPresent.Types.Response response = new CollectLootPresent.Types.Response();
			response.request_ = request;
			return (Task<CollectLootPresent.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A1590", Offset = "0x79FF90", VA = "0x1807A1590", Slot = "41")]
		public override Task<CollectConsummable.Types.Response> CollectConsummableAsync(CollectConsummable.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectConsummable.Types.Response response = new CollectConsummable.Types.Response();
			response.request_ = request;
			return (Task<CollectConsummable.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A19B0", Offset = "0x7A03B0", VA = "0x1807A19B0", Slot = "42")]
		public override Task<ConsumeItem.Types.Response> ConsumeItemAsync(ConsumeItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ConsumeItem.Types.Response response = new ConsumeItem.Types.Response();
			response.request_ = request;
			return (Task<ConsumeItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A0F60", Offset = "0x79F960", VA = "0x1807A0F60", Slot = "153")]
		public override Task<ChangeCurrentPet.Types.Response> ChangeCurrentPetAsync(ChangeCurrentPet.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ChangeCurrentPet.Types.Response response = new ChangeCurrentPet.Types.Response();
			response.request_ = request;
			return (Task<ChangeCurrentPet.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B70", Offset = "0x7A5570", VA = "0x1807A6B70", Slot = "154")]
		public override Task<StartPendingBurningState.Types.Response> StartPendingBurningStateAsync(StartPendingBurningState.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StartPendingBurningState.Types.Response response = new StartPendingBurningState.Types.Response();
			response.request_ = request;
			return (Task<StartPendingBurningState.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A14E0", Offset = "0x79FEE0", VA = "0x1807A14E0", Slot = "155")]
		public override Task<CollectBurningState.Types.Response> CollectBurningStateAsync(CollectBurningState.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectBurningState.Types.Response response = new CollectBurningState.Types.Response();
			response.request_ = request;
			return (Task<CollectBurningState.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A1380", Offset = "0x79FD80", VA = "0x1807A1380", Slot = "156")]
		public override Task<ClearBurningState.Types.Response> ClearBurningStateAsync(ClearBurningState.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ClearBurningState.Types.Response response = new ClearBurningState.Types.Response();
			response.request_ = request;
			return (Task<ClearBurningState.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A52E0", Offset = "0x7A3CE0", VA = "0x1807A52E0", Slot = "157")]
		public override Task<PullWeed.Types.Response> PullWeedAsync(PullWeed.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PullWeed.Types.Response response = new PullWeed.Types.Response();
			response.request_ = request;
			return (Task<PullWeed.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A10", Offset = "0x7A5410", VA = "0x1807A6A10", Slot = "158")]
		public override Task<StartItemCollectMinigame.Types.Response> StartItemCollectMinigameAsync(StartItemCollectMinigame.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StartItemCollectMinigame.Types.Response response = new StartItemCollectMinigame.Types.Response();
			response.request_ = request;
			return (Task<StartItemCollectMinigame.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A1850", Offset = "0x7A0250", VA = "0x1807A1850", Slot = "159")]
		public override Task<CollectMinigameItem.Types.Response> CollectMinigameItemAsync(CollectMinigameItem.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectMinigameItem.Types.Response response = new CollectMinigameItem.Types.Response();
			response.request_ = request;
			return (Task<CollectMinigameItem.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CD0", Offset = "0x7A56D0", VA = "0x1807A6CD0", Slot = "160")]
		public override Task<StopItemCollectMinigame.Types.Response> StopItemCollectMinigameAsync(StopItemCollectMinigame.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StopItemCollectMinigame.Types.Response response = new StopItemCollectMinigame.Types.Response();
			response.request_ = request;
			return (Task<StopItemCollectMinigame.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059CF")]
		[Cpp2IlInjected.Address(RVA = "0x7A37C0", Offset = "0x7A21C0", VA = "0x1807A37C0", Slot = "63")]
		public override Task<ExecuteDailyReset.Types.Response> ExecuteDailyResetAsync(ExecuteDailyReset.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ExecuteDailyReset.Types.Response response = new ExecuteDailyReset.Types.Response();
			response.request_ = request;
			return (Task<ExecuteDailyReset.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059D0")]
		[Cpp2IlInjected.Address(RVA = "0x7A4960", Offset = "0x7A3360", VA = "0x1807A4960", Slot = "64")]
		public override Task<Meditate.Types.Response> MeditateAsync(Meditate.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			Meditate.Types.Response response = new Meditate.Types.Response();
			response.request_ = request;
			return (Task<Meditate.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059D1")]
		[Cpp2IlInjected.Address(RVA = "0x7A1010", Offset = "0x79FA10", VA = "0x1807A1010", Slot = "10")]
		public override Task<ChangeCurrentScene.Types.Response> ChangeCurrentSceneAsync(ChangeCurrentScene.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ChangeCurrentScene.Types.Response response = new ChangeCurrentScene.Types.Response();
			response.request_ = request;
			return (Task<ChangeCurrentScene.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059D2")]
		[Cpp2IlInjected.Address(RVA = "0x7A6200", Offset = "0x7A4C00", VA = "0x1807A6200", Slot = "11")]
		public override Task<SetManaHasAlreadyMissed.Types.Response> SetManaHasAlreadyMissedAsync(SetManaHasAlreadyMissed.Types.Request request, CallContext context)
		{
			SetManaHasAlreadyMissed.Types.Response response = new SetManaHasAlreadyMissed.Types.Response();
			return (Task<SetManaHasAlreadyMissed.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059D3")]
		[Cpp2IlInjected.Address(RVA = "0x7A75C0", Offset = "0x7A5FC0", VA = "0x1807A75C0", Slot = "169")]
		public override Task<UpdateBattlePassTasksProgression.Types.Response> UpdateBattlePassTasksProgressionAsync(UpdateBattlePassTasksProgression.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdateBattlePassTasksProgression.Types.Response response = new UpdateBattlePassTasksProgression.Types.Response();
			response.request_ = request;
			return (Task<UpdateBattlePassTasksProgression.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60059D4")]
		[Cpp2IlInjected.Address(RVA = "0x7A7880", Offset = "0x7A6280", VA = "0x1807A7880", Slot = "170")]
		public override Task<UpdateOnlineShopStates.Types.Response> UpdateOnlineShopStatesAsync(UpdateOnlineShopStates.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			UpdateOnlineShopStates.Types.Response response = new UpdateOnlineShopStates.Types.Response();
			response.request_ = request;
			return (Task<UpdateOnlineShopStates.Types.Response>)(object)ApplyTransaction(response, context);
		}
	}
}
