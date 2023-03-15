using System;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000886")]
	public static class WateringExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6005F4F")]
		[Cpp2IlInjected.Address(RVA = "0x17C6380", Offset = "0x17C4D80", VA = "0x1817C6380")]
		public static WateringState GetWateringState(this SaplingGrowthData canBeWatered, SeedItemData seedItemData, IProfileWorld world, ITransactionContext context, bool inVillage)
		{
			WateringState result = default(WateringState);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F50")]
		[Cpp2IlInjected.Address(RVA = "0x17C63C0", Offset = "0x17C4DC0", VA = "0x1817C63C0")]
		public static WateringState GetWateringState(this SaplingGrowthData canBeWatered, SeedItemData seedItemData, IProfileWorld world, ITransactionContext context, bool inVillage, out TimeSpan wateredDuration, out TimeSpan dryingDuration)
		{
			int num = 0;
			if (seedItemData.NeedWatering)
			{
				bool flag = default(bool);
				if (flag)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					DateTime dateTime = canBeWatered.lastWateringDate_.ToDateTime();
					DateTime dateTime2 = default(DateTime);
					TimeSpan timeSpan = dateTime2 - dateTime;
					TimeSpan zero = TimeSpan.Zero;
					if (timeSpan > zero)
					{
						int num3 = 0;
						timeSpan += timeSpan;
						num3 += 376;
					}
				}
				DateTime dateTime3 = canBeWatered.lastWateringDate_.ToDateTime();
				TimeSpan timeSpan2 = default(TimeSpan);
				if ((object)timeSpan2 == null)
				{
					TimeSpan timeSpan3 = default(TimeSpan);
					DateTime dateTime4 = canBeWatered.lastWateringDate_.ToDateTime() + timeSpan3;
					DateTime dateTime5 = canBeWatered.endOfGrowth_.ToDateTime();
					if (!(dateTime4 >= dateTime5))
					{
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F51")]
		[Cpp2IlInjected.Address(RVA = "0x17C6070", Offset = "0x17C4A70", VA = "0x1817C6070")]
		public static DateTime GetNextStateTimestamp(this SaplingGrowthData canBeWatered, SeedItemData seedItemData, IProfileWorld world, ITransactionContext context, bool inVillage)
		{
			//Discarded unreachable code: IL_002e
			//IL_0019: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			int num = 0;
			Timestamp lastWateringDate_ = canBeWatered.lastWateringDate_;
			WateringState wateringState = default(WateringState);
			switch (wateringState)
			{
			case WateringState.Watered:
				return lastWateringDate_.ToDateTime() + (TimeSpan)num;
			case WateringState.Drying:
			{
				DateTime dateTime = lastWateringDate_.ToDateTime() + (TimeSpan)num;
				break;
			}
			}
			DateTime result = default(DateTime);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F52")]
		[Cpp2IlInjected.Address(RVA = "0x17C61C0", Offset = "0x17C4BC0", VA = "0x1817C61C0")]
		public static DateTime GetTimestampForState(this SaplingGrowthData canBeWatered, SeedItemData seedItemData, IProfileWorld world, ITransactionContext context, WateringState wantedWateringState, bool inVillage)
		{
			//Discarded unreachable code: IL_0014, IL_002c
			//IL_0013: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			int num = 0;
			return canBeWatered.lastWateringDate_.ToDateTime() + (TimeSpan)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F53")]
		[Cpp2IlInjected.Address(RVA = "0x17C5F90", Offset = "0x17C4990", VA = "0x1817C5F90")]
		public static Timestamp GetInitialWateringDate(SeedItemData seedItemData, DateTime now)
		{
			//Discarded unreachable code: IL_0007
			DateTime dateTime = default(DateTime);
			return dateTime.ToProto();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F54")]
		[Cpp2IlInjected.Address(RVA = "0x17C68F0", Offset = "0x17C52F0", VA = "0x1817C68F0")]
		public static bool IsGrowingState(this WateringState wateringState)
		{
			if (wateringState == WateringState.Watered)
			{
				return true;
			}
			return wateringState == WateringState.Drying;
		}
	}
}
