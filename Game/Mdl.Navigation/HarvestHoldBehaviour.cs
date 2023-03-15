using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Activities;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C49")]
	internal class HarvestHoldBehaviour : FindAdjacentObjectHoldBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6003865")]
		[Cpp2IlInjected.Address(RVA = "0x154CE70", Offset = "0x154B870", VA = "0x18154CE70", Slot = "6")]
		public override bool DoUpdate(float dt)
		{
			//IL_001f: Expected O, but got I4
			if (base.DoUpdate(dt))
			{
				PlayerTask currentTask = playerNavigation.CurrentTask;
				int num = 0;
				if (currentTask != (UnityEngine.Object)num)
				{
					Item plantedSeedItem = playerNavigation.CurrentTask.GetTaskData<Garden>().SingleSlot.PlantedSeedItem;
					SeedItemData seedItemData = default(SeedItemData);
					if (seedItemData != null)
					{
						Client client = default(Client);
						ContainerInventory backpack = client.profile.player_.Backpack;
						Item producedItem = seedItemData.ProducedItem;
						int num2 = 0;
						ContainerInventory.CanAddResult canAddResult = default(ContainerInventory.CanAddResult);
						if (canAddResult != 0)
						{
							goto IL_0066;
						}
					}
				}
				return true;
			}
			goto IL_0066;
			IL_0066:
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003866")]
		[Cpp2IlInjected.Address(RVA = "0xA8B070", Offset = "0xA89A70", VA = "0x180A8B070")]
		public HarvestHoldBehaviour()
		{
		}
	}
}
