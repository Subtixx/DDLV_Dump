using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf.Collections;
using Meta;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class SpawnRecurringEventAreaSpecificationExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC021D0", Offset = "0xC00BD0", VA = "0x180C021D0")]
		public static bool ShouldSpawn(this SpawnRecurringEventAreaSpecification areaSpecification, in World world, VillageAreaType villageArea)
		{
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = areaSpecification;
			switch (spawnRecurringEventAreaSpecification.areaSpecificationCase_)
			{
			case SpawnRecurringEventAreaSpecification.AreaSpecificationOneofCase.SpecificAreas:
			{
				RepeatedField<VillageAreaType> areas_ = spawnRecurringEventAreaSpecification.SpecificAreas.areas_;
				bool result = default(bool);
				return result;
			}
			case SpawnRecurringEventAreaSpecification.AreaSpecificationOneofCase.FromChooseVillageAreaEvent:
				if (spawnRecurringEventAreaSpecification.FromChooseVillageAreaEvent.spawnWhenEqualToCase_ != SpawnRecurringEventAreaSpecification.Types.ChooseVillageAreaEvent.SpawnWhenEqualToOneofCase.VillageArea || areaSpecification.FromChooseVillageAreaEvent.VillageArea == villageArea)
				{
					ICollection<RecurringEvent> values = (ICollection<RecurringEvent>)((MapField<TKey, TValue>)(object)world.Section.recurringEvents_).get_Values();
					Func<RecurringEvent, bool> func = (Func<RecurringEvent, bool>)(object)(Func<T, TResult>)delegate(RecurringEvent x)
					{
						IRecurringEvent @event = x.Event;
						Item chooseVillageAreaEventItem = areaSpecification.FromChooseVillageAreaEvent.ChooseVillageAreaEventItem;
						throw new NullReferenceException();
					};
					RecurringEvent recurringEvent = Enumerable.FirstOrDefault<RecurringEvent>((IEnumerable<>)values, (Func<, >)(object)func);
					if (recurringEvent != null)
					{
						ChooseVillageArea chooseVillageArea = recurringEvent.ChooseVillageArea;
					}
				}
				break;
			}
			throw new NullReferenceException();
		}
	}
}
