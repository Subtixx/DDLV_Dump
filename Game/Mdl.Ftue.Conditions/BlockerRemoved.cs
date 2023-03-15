using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200060F")]
	[CreateAssetMenu]
	public class BlockerRemoved : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002489")]
		[ItemID]
		public int blocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400248A")]
		private FurnitureBlockerItemData blockerItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400248B")]
		private Item removedGridItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400248C")]
		private Client client;

		[Cpp2IlInjected.Token(Token = "0x6001ADA")]
		[Cpp2IlInjected.Address(RVA = "0x1641B00", Offset = "0x1640500", VA = "0x181641B00", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_005a
			this.client = client;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			FurnitureBlockerItemData furnitureBlockerItemData = default(FurnitureBlockerItemData);
			blockerItemData = furnitureBlockerItemData;
			if ((long)blockerItemData != 0)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.AvatarRemoveBlocker value = OnAvatarRemoveBlocker;
				_003CDispatcher_003Ek__BackingField.OnAvatarRemoveBlocker -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client.Dispatcher;
				ProfileEventDispatcher.AvatarRemoveBlocker value2 = OnAvatarRemoveBlocker;
				_003CDispatcher_003Ek__BackingField2.OnAvatarRemoveBlocker += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ADB")]
		[Cpp2IlInjected.Address(RVA = "0x1641CC0", Offset = "0x16406C0", VA = "0x181641CC0", Slot = "5")]
		protected override bool _IsTrue()
		{
			Item item = blockerItemData.Item;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ADC")]
		[Cpp2IlInjected.Address(RVA = "0x1641A10", Offset = "0x1640410", VA = "0x181641A10")]
		private void OnAvatarRemoveBlocker(IGrid grid, GridObject gridObject)
		{
			//Discarded unreachable code: IL_001f
			//IL_000e: Expected O, but got I4
			int itemID = gridObject.ItemID;
			removedGridItem = (Item)itemID;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ADD")]
		[Cpp2IlInjected.Address(RVA = "0x1641A60", Offset = "0x1640460", VA = "0x181641A60", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0027
			Client client = this.client;
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.AvatarRemoveBlocker value = OnAvatarRemoveBlocker;
				_003CDispatcher_003Ek__BackingField.OnAvatarRemoveBlocker -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ADE")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public BlockerRemoved()
		{
		}
	}
}
