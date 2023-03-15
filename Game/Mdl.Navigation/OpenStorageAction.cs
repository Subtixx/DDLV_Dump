using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Furnitures;
using Mdl.Grid;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BD8")]
	internal class OpenStorageAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x6003651")]
		[Cpp2IlInjected.Address(RVA = "0xF06A30", Offset = "0xF05430", VA = "0x180F06A30", Slot = "10")]
		public override bool CanQueueTask(GameObject target)
		{
			//IL_0043: Expected O, but got I4
			bool flag = default(bool);
			ulong num = default(ulong);
			StorageGridData storageGridData = default(StorageGridData);
			if (flag && num != 0 && (object)target != null && storageGridData != null)
			{
				Client client = default(Client);
				ProfilePlayer player_ = client.profile.player_;
				MapField<uint, ContainerInventory> containerInventories_ = player_.containerInventories_;
				uint nextListInventoryID_ = player_.nextListInventoryID_;
				StorageGridData storageGridData2 = default(StorageGridData);
				uint containerInventoryID_ = storageGridData2.containerInventoryID_;
				return ((MapField<TKey, TValue>)(object)containerInventories_).ContainsKey((TKey)containerInventoryID_);
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003652")]
		[Cpp2IlInjected.Address(RVA = "0xF06480", Offset = "0xF04E80", VA = "0x180F06480", Slot = "8")]
		public override Task<bool> CanExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			//Discarded unreachable code: IL_00ba, IL_00c8, IL_00cf
			int num = 0;
			FurnitureStorage taskData = task.GetTaskData<FurnitureStorage>();
			GridState state_ = ((GridObjectStateUser)taskData).GridObjectScript.GridObject.state_;
			if (state_ != null)
			{
				StorageGridData storage = state_.Storage;
				if (storage != null)
				{
					int itemID = storage.UnlockKeyItem.ItemID;
				}
				if (num != 0)
				{
					Item unlockKeyItem = ((GridObjectStateUser)taskData).GridObjectScript.GridObject.state_.Storage.UnlockKeyItem;
					bool flag = default(bool);
					if (flag)
					{
						GridState state_2 = ((GridObjectStateUser)taskData).GridObjectScript.GridObject.state_;
						if (state_2 != null)
						{
							StorageGridData storage2 = state_2.Storage;
						}
						Client client = default(Client);
						ProfilePlayer player_ = client.profile.player_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
							int count = ((Dictionary<, >)(object)dictionary).count;
							uint num2 = default(uint);
							if (num < (int)num2)
							{
								num += num;
								num++;
							}
							throw new NullReferenceException();
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003653")]
		[Cpp2IlInjected.Address(RVA = "0xF06B90", Offset = "0xF05590", VA = "0x180F06B90", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__2))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003654")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public OpenStorageAction()
		{
		}
	}
}
