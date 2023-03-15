using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf.Collections;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A4A")]
	internal class FirstTimeFishingRewardSelector : DefaultFishingRewardSelector
	{
		[Cpp2IlInjected.Token(Token = "0x40028EB")]
		private static FishRippleRarity[] relevantRarities;

		[Cpp2IlInjected.Token(Token = "0x40028EC")]
		private static Dictionary<FishRippleRarity, FishRarity> desiredFishRarith;

		[Cpp2IlInjected.Token(Token = "0x60058D9")]
		[Cpp2IlInjected.Address(RVA = "0x17FD6E0", Offset = "0x17FC0E0", VA = "0x1817FD6E0")]
		public static bool ShouldCreate(Profile profile, PendingFish pendingFish)
		{
			//Discarded unreachable code: IL_0058
			int num = 0;
			int num2 = 0;
			FishRippleRarity rarity_ = pendingFish.rarity_;
			FishRippleRarity[] array = relevantRarities;
			bool flag = default(bool);
			if (flag)
			{
				ActivityDataLocationFilter location_ = pendingFish.location_;
				if (location_.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea)
				{
					int villageArea = (int)location_.VillageArea;
					RepeatedField<FishingPerVillageArea> fishedVillageAreas_ = profile.world_.fishedVillageAreas_;
					bool flag2 = default(bool);
					if (flag2)
					{
						int num3 = 0;
						num2++;
					}
					if (num2 + 1 == 0)
					{
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058DA")]
		[Cpp2IlInjected.Address(RVA = "0x17FDB40", Offset = "0x17FC540", VA = "0x1817FDB40")]
		public FirstTimeFishingRewardSelector(Profile profile, ITransactionContext context, PendingFish pendingFish)
			: base(profile, context, pendingFish)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60058DB")]
		[Cpp2IlInjected.Address(RVA = "0x17FD2E0", Offset = "0x17FBCE0", VA = "0x1817FD2E0", Slot = "5")]
		public override void RecordSelectionSuccess()
		{
			//Discarded unreachable code: IL_0066
			Profile profile = ((FishingRewardSelector)this).Profile;
			PendingFish pendingFish = ((FishingRewardSelector)this).Fish;
			if (ShouldCreate(profile, pendingFish))
			{
				RepeatedField<FishingPerVillageArea> fishedVillageAreas_ = ((FishingRewardSelector)this).Profile.world_.fishedVillageAreas_;
				FishingPerVillageArea fishingPerVillageArea = new FishingPerVillageArea();
				VillageAreaType villageAreaType = (fishingPerVillageArea.location_ = ((FishingRewardSelector)this).Fish.location_.VillageArea);
				FishRippleRarity fishRippleRarity = (fishingPerVillageArea.rarity_ = ((FishingRewardSelector)this).Fish.rarity_);
				((RepeatedField<T>)(object)fishedVillageAreas_).Add((T)fishingPerVillageArea);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60058DC")]
		[Cpp2IlInjected.Address(RVA = "0x17FD400", Offset = "0x17FBE00", VA = "0x1817FD400", Slot = "6")]
		protected unsafe override FishingData.Types.FishRarityData SelectRandomFishRarity(Random random, FishRippleRarity rippleRarity)
		{
			//Discarded unreachable code: IL_006a
			Profile profile = ((FishingRewardSelector)this).Profile;
			PendingFish pendingFish = ((FishingRewardSelector)this).Fish;
			if (ShouldCreate(profile, pendingFish))
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				Func<FishingData.Types.FishRarityData, bool> func = (Func<FishingData.Types.FishRarityData, bool>)(object)(Func<T, TResult>)delegate(FishingData.Types.FishRarityData content)
				{
					//Discarded unreachable code: IL_0029
					List<(FishingDataItemData, int)> cpp2il__autoParamName__idx_ = base.FishToConsider;
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
				Dictionary<FishRippleRarity, FishRarity> dictionary = desiredFishRarith;
				FishRarity fishRarity = default(FishRarity);
				FishRarity desiredRarity = fishRarity;
				Func<FishingData.Types.FishRarityData, bool> func2 = (Func<FishingData.Types.FishRarityData, bool>)(object)(Func<T, TResult>)delegate(FishingData.Types.FishRarityData x)
				{
					//Discarded unreachable code: IL_0011
					FishRarity fishRarity2 = desiredRarity;
					return x.fishRarity_ == fishRarity2;
				};
				if (Enumerable.FirstOrDefault<FishingData.Types.FishRarityData>((IEnumerable<>)enumerable2, (Func<, >)(object)func2) != null)
				{
				}
			}
			FishingData.Types.FishRarityData result = default(FishingData.Types.FishRarityData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60058DD")]
		[Cpp2IlInjected.Address(RVA = "0x17FD9F0", Offset = "0x17FC3F0", VA = "0x1817FD9F0")]
		static FirstTimeFishingRewardSelector()
		{
			//Discarded unreachable code: IL_0034, IL_003a
			//IL_0018: Expected I4, but got I8
			//IL_0022: Expected I4, but got I8
			FishRippleRarity[] array = new FishRippleRarity[2];
			int length = array.Length;
			array[0] = FishRippleRarity.Enhanced;
			array[0] = FishRippleRarity.Normal;
			relevantRarities = array;
			Dictionary<FishRippleRarity, FishRarity> dictionary = (Dictionary<FishRippleRarity, FishRarity>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
