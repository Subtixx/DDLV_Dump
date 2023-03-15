using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200060E")]
	[CreateAssetMenu]
	public class ActivityItemAcquired : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002487")]
		[ItemID]
		public int activityItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002488")]
		private Client client;

		[Cpp2IlInjected.Token(Token = "0x6001AD5")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2D0", Offset = "0xA3ACD0", VA = "0x180A3C2D0", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_003e
			this.client = client;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
			ProfileEventDispatcher.ItemAdded value = OnItemAdded;
			_003CDispatcher_003Ek__BackingField.OnItemAdded -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client.Dispatcher;
			ProfileEventDispatcher.ItemAdded value2 = OnItemAdded;
			_003CDispatcher_003Ek__BackingField2.OnItemAdded += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3C0", Offset = "0xA3ADC0", VA = "0x180A3C3C0", Slot = "5")]
		protected override bool _IsTrue()
		{
			//Discarded unreachable code: IL_0025
			ProfilePlayer player_ = client.profile.player_;
			long num = Convert.ToInt64((uint)activityItem);
			bool flag = default(bool);
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD7")]
		[Cpp2IlInjected.Address(RVA = "0x8B3070", Offset = "0x8B1A70", VA = "0x1808B3070")]
		private void OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD8")]
		[Cpp2IlInjected.Address(RVA = "0xA3C230", Offset = "0xA3AC30", VA = "0x180A3C230", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0027
			Client client = this.client;
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.ItemAdded value = OnItemAdded;
				_003CDispatcher_003Ek__BackingField.OnItemAdded -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD9")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public ActivityItemAcquired()
		{
		}
	}
}
