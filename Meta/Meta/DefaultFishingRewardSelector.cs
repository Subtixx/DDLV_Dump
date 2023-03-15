using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Util;
using Meta.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A46")]
	internal class DefaultFishingRewardSelector : FishingRewardSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40028E5")]
		private bool specificFishCheat;

		[Cpp2IlInjected.Token(Token = "0x17000EB1")]
		protected List<(FishingDataItemData fishingDataItemData, int appearanceWeight)> FishToConsider
		{
			[Cpp2IlInjected.Token(Token = "0x60058CA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CFishToConsider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60058CB")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CFishToConsider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058CC")]
		[Cpp2IlInjected.Address(RVA = "0x1A22190", Offset = "0x1A20B90", VA = "0x181A22190")]
		public DefaultFishingRewardSelector(Profile profile, ITransactionContext context, PendingFish pendingFish)
			: base(profile, context, pendingFish)
		{
			//Discarded unreachable code: IL_003d
			//IL_003c: Expected I4, but got O
			PendingFish pendingFish2 = base.Fish;
			ITransactionContext transactionContext = base.Context;
			List<(FishingDataItemData, int)> list = (FishToConsider = (List<(FishingDataItemData fishingDataItemData, int appearanceWeight)>)(object)FishingUtils.FindFishesToConsider(base.Profile, transactionContext, pendingFish2));
			Item? _003CDebugForceFishItem_003Ek__BackingField = profile.DebugForceFishItem;
			specificFishCheat = (byte)(int)_003CDebugForceFishItem_003Ek__BackingField != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60058CD")]
		[Cpp2IlInjected.Address(RVA = "0x1A22060", Offset = "0x1A20A60", VA = "0x181A22060", Slot = "4")]
		public override bool TrySelectReward(Random random, out FishingDataItemData chosenFishingData)
		{
			//Discarded unreachable code: IL_0017
			FishRippleRarity rarity_ = base.Fish.rarity_;
			FishingDataItemData fishingDataItemData = ChooseFishingData(random, rarity_);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60058CE")]
		[Cpp2IlInjected.Address(RVA = "0x1A21B60", Offset = "0x1A20560", VA = "0x181A21B60")]
		protected FishingDataItemData ChooseFishingData(Random random, FishRippleRarity rippleRarity)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60058CF")]
		[Cpp2IlInjected.Address(RVA = "0x1A21DC0", Offset = "0x1A207C0", VA = "0x181A21DC0", Slot = "6")]
		protected unsafe virtual FishingData.Types.FishRarityData SelectRandomFishRarity(Random random, FishRippleRarity rippleRarity)
		{
			//Discarded unreachable code: IL_004a
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			Func<FishingData.Types.FishRarityData, bool> func = (Func<FishingData.Types.FishRarityData, bool>)(object)(Func<T, TResult>)delegate(FishingData.Types.FishRarityData content)
			{
				//Discarded unreachable code: IL_0029
				List<(FishingDataItemData, int)> cpp2il__autoParamName__idx_ = FishToConsider;
				Func<(FishingDataItemData, int), bool> cpp2il__autoParamName__idx_2 = (Func<(FishingDataItemData, int), bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0015
					FishRarity fishRarity_ = content.fishRarity_;
					return (IntPtr)"{il2cpp field on {'constant1' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x48}" == (IntPtr)(void*)(int)fishRarity_;
				};
				return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<(FishingDataItemData, int)>((Func<, >)(object)cpp2il__autoParamName__idx_2);
			};
			IEnumerable<FishingData.Types.FishRarityData> enumerable = default(IEnumerable<FishingData.Types.FishRarityData>);
			IEnumerable<FishingData.Types.FishRarityData> enumerable2 = (IEnumerable<FishingData.Types.FishRarityData>)Enumerable.Where<FishingData.Types.FishRarityData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			Func<FishingData.Types.FishRarityData, int> _003C_003E9__8_ = _003C_003Ec._003C_003E9__8_1;
			if (_003C_003E9__8_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FishingData.Types.FishRarityData x) => x.weight_);
			}
			return RewardUtil.WeightedRandom<FishingData.Types.FishRarityData>((IEnumerable<>)enumerable2, random, (Func<, >)(object)_003C_003E9__8_);
		}
	}
}
