using System;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A4D")]
	internal class SpecificFishRewardSelector : FishingRewardSelector
	{
		[Cpp2IlInjected.Token(Token = "0x60058E3")]
		[Cpp2IlInjected.Address(RVA = "0xC023D0", Offset = "0xC00DD0", VA = "0x180C023D0")]
		public static bool ShouldCreate(PendingFish pendingFish)
		{
			Item forcedFishingDataItem = pendingFish.ForcedFishingDataItem;
			bool flag = default(bool);
			if (flag && pendingFish.isSpecific_)
			{
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058E4")]
		[Cpp2IlInjected.Address(RVA = "0xC024D0", Offset = "0xC00ED0", VA = "0x180C024D0")]
		public SpecificFishRewardSelector(Profile profile, ITransactionContext context, PendingFish pendingFish)
			: base(profile, context, pendingFish)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60058E5")]
		[Cpp2IlInjected.Address(RVA = "0xC02470", Offset = "0xC00E70", VA = "0x180C02470", Slot = "4")]
		public override bool TrySelectReward(Random random, out FishingDataItemData chosenFishingData)
		{
			//Discarded unreachable code: IL_000e
			Item forcedFishingDataItem = base.Fish.ForcedFishingDataItem;
			bool result = default(bool);
			return result;
		}
	}
}
