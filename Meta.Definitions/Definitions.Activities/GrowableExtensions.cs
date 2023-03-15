using System;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000888")]
	public static class GrowableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6005F57")]
		[Cpp2IlInjected.Address(RVA = "0x2F9A300", Offset = "0x2F98D00", VA = "0x182F9A300")]
		public static DateTime GetEndOfGrowthTime(this IGrowable growable, SeedItemData seedItemData, IProfileWorld world, ITransactionContext context, bool inVillage)
		{
			//Discarded unreachable code: IL_0049
			//IL_0022: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			int num = 0;
			WateringState wateringState = default(WateringState);
			if (seedItemData != null && seedItemData.NeedWatering && growable != null && wateringState > WateringState.Drying && wateringState == WateringState.Dying)
			{
				DateTime dateTime = default(DateTime);
				DateTime dateTime2 = dateTime + (TimeSpan)num + (TimeSpan)num;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				TimeSpan timeSpan = dateTime2 - dateTime2;
				DateTime dateTime3 = default(DateTime);
				return dateTime3 + timeSpan;
			}
			throw new NullReferenceException();
		}
	}
}
