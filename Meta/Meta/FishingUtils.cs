using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A40")]
	public static class FishingUtils
	{
		[Cpp2IlInjected.Token(Token = "0x60058AC")]
		[Cpp2IlInjected.Address(RVA = "0x1800FC0", Offset = "0x17FF9C0", VA = "0x181800FC0")]
		public unsafe static List<(FishingDataItemData, int)> FindFishesToConsider(Profile profile, ITransactionContext context, PendingFish pendingFish)
		{
			//Discarded unreachable code: IL_012a
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			Profile profile2 = profile;
			Item? item = default(Item?);
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			if (item == null)
			{
				PendingFish pendingFish2 = pendingFish;
				Func<FishingData.Types.FishRarityData, FishRarity> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_2;
				if (_003C_003E9__0_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FishingData.Types.FishRarityData content) => content.fishRarity_);
				}
				IEnumerable<FishRarity> potentialRarities;
				IEnumerable<FishingData.Types.FishRarityData> enumerable = default(IEnumerable<FishingData.Types.FishRarityData>);
				DateTime localTime = (DateTime)(potentialRarities = (IEnumerable<FishRarity>)Enumerable.Select<FishingData.Types.FishRarityData, FishRarity>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__0_));
				string currentWeather = profile.world_.currentWeather_;
				Func<FishingDataItemData, bool> func = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData fish)
				{
					if (!fish.isHidden_)
					{
						FishRarity rarity_ = fish.rarity_;
						if (Enumerable.Contains<FishRarity>((IEnumerable<>)potentialRarities, rarity_))
						{
							VillageAreaType villageArea = pendingFish.location_.VillageArea;
							bool flag = default(bool);
							if (flag)
							{
								DateTime localTime2 = localTime;
								if (fish.CanAppearAtLocalTime(localTime2))
								{
									string weather = currentWeather;
									return fish.CanAppearInWeather(weather);
								}
							}
						}
					}
					int num3 = 0;
					throw new NullReferenceException();
				};
				IEnumerable<FishingDataItemData> enumerable3 = (IEnumerable<FishingDataItemData>)Enumerable.Where<FishingDataItemData>(enumerable2, (Func<, >)(object)func);
				if (_003C_003Ec._003C_003E9__0_4 != null)
				{
					goto IL_011b;
				}
				Func<FishingDataItemData, (FishingDataItemData, int)> func2 = (Func<FishingDataItemData, (FishingDataItemData, int)>)(object)(Func<T, TResult>)delegate
				{
					int num2 = 0;
					throw new NullReferenceException();
				};
			}
			Func<FishingDataItemData, bool> func3 = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData x)
			{
				//Discarded unreachable code: IL_0020
				Item item2 = x.result_.Item;
				Item? _003CDebugForceFishItem_003Ek__BackingField = profile.DebugForceFishItem;
				Item item3 = default(Item);
				return *(Item*)item2 == *(Item*)item3;
			};
			IEnumerable<FishingDataItemData> enumerable4 = (IEnumerable<FishingDataItemData>)Enumerable.Where<FishingDataItemData>(enumerable2, (Func<, >)(object)func3);
			Func<FishingDataItemData, (FishingDataItemData, int)> func4 = default(Func<FishingDataItemData, (FishingDataItemData, int)>);
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				func4 = (Func<FishingDataItemData, (FishingDataItemData, int)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				});
			}
			goto IL_011b;
			IL_011b:
			return (List<(FishingDataItemData, int)>)(object)Enumerable.ToList<(FishingDataItemData, int)>(Enumerable.Select<FishingDataItemData, (FishingDataItemData, int)>((IEnumerable<>)enumerable4, (Func<, >)(object)func4));
		}
	}
}
