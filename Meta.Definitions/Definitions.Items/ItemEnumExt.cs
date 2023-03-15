using System;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D0")]
	public static class ItemEnumExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004C14")]
		[Cpp2IlInjected.Address(RVA = "0x22D7330", Offset = "0x22D5D30", VA = "0x1822D7330")]
		public static bool TryGetBuildingItem(this ScheduleType self, in WorldProfile world, out Item item)
		{
			//Discarded unreachable code: IL_0029
			//IL_0027: Expected I4, but got O
			if ((self != ScheduleType.Restaurant || world.Section != null) && self == ScheduleType.PlayerHouse)
			{
				IProfileWorld section = world.Section;
			}
			Item invalid = Item.Invalid;
			item.ItemID = (int)invalid;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C15")]
		[Cpp2IlInjected.Address(RVA = "0x22D7170", Offset = "0x22D5B70", VA = "0x1822D7170")]
		public static Item GetBuildingItem(this ScheduleType self, in WorldProfile world)
		{
			//Discarded unreachable code: IL_0026
			switch (self)
			{
			case ScheduleType.Restaurant:
				if (world.Section != null)
				{
					return BuildingItem.Restaurant;
				}
				break;
			case ScheduleType.PlayerHouse:
			{
				IProfileWorld section = world.Section;
				break;
			}
			}
			return Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C16")]
		[Cpp2IlInjected.Address(RVA = "0x22D74F0", Offset = "0x22D5EF0", VA = "0x1822D74F0")]
		public static bool TryGetSceneType(this ScheduleType self, out SceneType sceneType)
		{
			//Discarded unreachable code: IL_0014, IL_0024, IL_0034, IL_0044, IL_006a, IL_006f, IL_0074, IL_0079, IL_0091, IL_0097, IL_009f, IL_00a5, IL_00ad, IL_00b3, IL_00bb, IL_00c1, IL_00c9, IL_00cf
			//IL_00cf: Expected I4, but got O
			if (self <= ScheduleType.Event)
			{
				uint num = default(uint);
				sceneType.value__ = (int)num;
				return num != 0;
			}
			return (sceneType.value__ = 0) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C17")]
		[Cpp2IlInjected.Address(RVA = "0x22D72D0", Offset = "0x22D5CD0", VA = "0x1822D72D0")]
		public static SceneType GetSceneType(this ScheduleType self)
		{
			if (self <= ScheduleType.Event)
			{
			}
			int num = 0;
			int num2 = default(int);
			if (self >= ScheduleType.Event || self < ScheduleType.Event)
			{
				num2 = (int)self;
				if (self != ScheduleType.Event)
				{
				}
			}
			IProfileWorld profileWorld = default(IProfileWorld);
			if ((num2 == 5 && profileWorld == null) || (long)profileWorld == 6)
			{
			}
			throw new NullReferenceException();
		}
	}
}
