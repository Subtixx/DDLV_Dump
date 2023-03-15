using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000610")]
	[CreateAssetMenu]
	public class BuildingUnlocked : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400248D")]
		[ItemID]
		public int building;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400248E")]
		private IBuildingUnlockable unlockable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400248F")]
		private Client client;

		[Cpp2IlInjected.Token(Token = "0x6001ADF")]
		[Cpp2IlInjected.Address(RVA = "0x1645000", Offset = "0x1643A00", VA = "0x181645000", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_005a
			this.client = client;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			unlockable = (IBuildingUnlockable)itemData;
			if ((long)unlockable != 0)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value = OnBuildingUnlocked;
				_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client.Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value2 = OnBuildingUnlocked;
				_003CDispatcher_003Ek__BackingField2.OnBuildingUnlocked += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE0")]
		[Cpp2IlInjected.Address(RVA = "0x16451C0", Offset = "0x1643BC0", VA = "0x1816451C0", Slot = "5")]
		protected override bool _IsTrue()
		{
			//Discarded unreachable code: IL_0020
			ProfileWorld world_ = client.profile.world_;
			IBuildingUnlockable buildingUnlockable = unlockable;
			return world_.IsBuildingUnlocked(buildingUnlockable);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE1")]
		[Cpp2IlInjected.Address(RVA = "0x8B3070", Offset = "0x8B1A70", VA = "0x1808B3070")]
		private void OnBuildingUnlocked(Item item, [System.Runtime.InteropServices.Optional] List<CurrencyCost> costs)
		{
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE2")]
		[Cpp2IlInjected.Address(RVA = "0x1644F60", Offset = "0x1643960", VA = "0x181644F60", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0027
			Client client = this.client;
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value = OnBuildingUnlocked;
				_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE3")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public BuildingUnlocked()
		{
		}
	}
}
