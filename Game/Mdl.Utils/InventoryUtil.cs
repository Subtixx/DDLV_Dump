using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Characters;
using Meta;
using Meta.Customization;
using Meta.Missions;
using Meta.Util;
using UnityEngine.AddressableAssets;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000756")]
	public static class InventoryUtil
	{
		[Cpp2IlInjected.Token(Token = "0x2000757")]
		private class LevelUpTracker : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002A30")]
			private ProfileEventDispatcher dispatcher;

			[Cpp2IlInjected.Token(Token = "0x1700049C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002A2F")]
			public bool HasLevelledUp
			{
				[Cpp2IlInjected.Token(Token = "0x60020B2")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60020B3")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x60020B4")]
			[Cpp2IlInjected.Address(RVA = "0xE5FF20", Offset = "0xE5E920", VA = "0x180E5FF20")]
			public LevelUpTracker(ProfileEventDispatcher dispatcher)
			{
				//Discarded unreachable code: IL_003d
				this.dispatcher = dispatcher;
				HasLevelledUp = false;
				ProfileEventDispatcher.PlayerLevelGained value = OnPlayerLevelGained;
				dispatcher.OnPlayerLevelGained += value;
				ProfileEventDispatcher.CharacterFriendshipLevelChanged value2 = OnCharacterFriendshipLevelChanged;
				dispatcher.OnCharacterFriendshipLevelChanged += value2;
			}

			[Cpp2IlInjected.Token(Token = "0x60020B5")]
			[Cpp2IlInjected.Address(RVA = "0xE5FE20", Offset = "0xE5E820", VA = "0x180E5FE20", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0037
				ProfileEventDispatcher profileEventDispatcher = dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value = OnPlayerLevelGained;
				profileEventDispatcher.OnPlayerLevelGained -= value;
				ProfileEventDispatcher profileEventDispatcher2 = dispatcher;
				ProfileEventDispatcher.CharacterFriendshipLevelChanged value2 = OnCharacterFriendshipLevelChanged;
				profileEventDispatcher2.OnCharacterFriendshipLevelChanged -= value2;
			}

			[Cpp2IlInjected.Token(Token = "0x60020B6")]
			[Cpp2IlInjected.Address(RVA = "0xE5FF00", Offset = "0xE5E900", VA = "0x180E5FF00")]
			private void OnCharacterFriendshipLevelChanged(Item characterItem, int levelsGained)
			{
				if (levelsGained > 0)
				{
					HasLevelledUp = true;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60020B7")]
			[Cpp2IlInjected.Address(RVA = "0xE5FF10", Offset = "0xE5E910", VA = "0x180E5FF10")]
			private void OnPlayerLevelGained(int gained)
			{
				if (gained > 0)
				{
					HasLevelledUp = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000758")]
		private class ProfessionChangedTracker : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002A32")]
			private ProfileEventDispatcher dispatcher;

			[Cpp2IlInjected.Token(Token = "0x1700049D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002A31")]
			public bool HasProfessionChanged
			{
				[Cpp2IlInjected.Token(Token = "0x60020B8")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60020B9")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x60020BA")]
			[Cpp2IlInjected.Address(RVA = "0xE60630", Offset = "0xE5F030", VA = "0x180E60630")]
			public ProfessionChangedTracker(ProfileEventDispatcher dispatcher)
			{
				//Discarded unreachable code: IL_0029
				this.dispatcher = dispatcher;
				HasProfessionChanged = false;
				ProfileEventDispatcher.CharacterProfessionChanged value = OnCharacterProfessionChanged;
				dispatcher.OnCharacterProfessionChanged += value;
			}

			[Cpp2IlInjected.Token(Token = "0x60020BB")]
			[Cpp2IlInjected.Address(RVA = "0xE605A0", Offset = "0xE5EFA0", VA = "0x180E605A0", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_001c
				ProfileEventDispatcher profileEventDispatcher = dispatcher;
				ProfileEventDispatcher.CharacterProfessionChanged value = OnCharacterProfessionChanged;
				profileEventDispatcher.OnCharacterProfessionChanged -= value;
			}

			[Cpp2IlInjected.Token(Token = "0x60020BC")]
			[Cpp2IlInjected.Address(RVA = "0xA28AC0", Offset = "0xA274C0", VA = "0x180A28AC0")]
			private void OnCharacterProfessionChanged(Item characterItem)
			{
				HasProfessionChanged = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020A0")]
		[Cpp2IlInjected.Address(RVA = "0x11BC990", Offset = "0x11BB390", VA = "0x1811BC990")]
		public static Task<bool> TryBuyMissingItems(GridCollection grids, Profile profile, AssetReference popup, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0019
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)Meta.Util.InventoryUtil.ExtractItems(grids);
			ListInventory catalog = profile.Catalog;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A1")]
		[Cpp2IlInjected.Address(RVA = "0x11BC780", Offset = "0x11BB180", VA = "0x1811BC780")]
		public static Task<bool> TryBuyMissingClothes(IAvatar avatar, Profile profile, AssetReference popup, string body, string purchaseLabel, ItemCollectMode collectMode, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0010
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)Meta.Util.InventoryUtil.ExtractClothes(avatar);
			ListInventory wardrobe = profile.Wardrobe;
			Task<bool> result = default(Task<bool>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A2")]
		[Cpp2IlInjected.Address(RVA = "0x11BCCB0", Offset = "0x11BB6B0", VA = "0x1811BCCB0")]
		public static Task<bool> TryBuyMissingMakeup(IAvatar avatar, Profile profile, AssetReference popup, string body, string purchaseLabel, ItemCollectMode collectMode, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0010
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)Meta.Util.InventoryUtil.ExtractMakeup(avatar);
			ListInventory makeup = profile.Makeup;
			Task<bool> result = default(Task<bool>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A3")]
		[Cpp2IlInjected.Address(RVA = "0x11BCB30", Offset = "0x11BB530", VA = "0x1811BCB30")]
		[AsyncStateMachine(typeof(_003CTryBuyMissingItems_003Ed__5))]
		public static Task<bool> TryBuyMissingItems(Dictionary<Item, int> items, ListInventory inventory, AssetReference popup, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A4")]
		[Cpp2IlInjected.Address(RVA = "0x11BC7F0", Offset = "0x11BB1F0", VA = "0x1811BC7F0")]
		[AsyncStateMachine(typeof(_003CTryBuyMissingItemsShoppingCart_003Ed__6))]
		public static Task<bool> TryBuyMissingItemsShoppingCart(Dictionary<Item, int> items, ListInventory inventory, AssetReference popup, string body, string purchaseLabel, ItemCollectMode collectMode, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A5")]
		[Cpp2IlInjected.Address(RVA = "0x11BC480", Offset = "0x11BAE80", VA = "0x1811BC480")]
		[AsyncStateMachine(typeof(_003CTryBuyItemsShoppingCartItems_003Ed__7))]
		public static Task<bool> TryBuyItemsShoppingCartItems(Dictionary<Item, int> items, AssetReference popup, string body, string purchaseLabel, ItemCollectMode collectMode, CancellationToken ct, [System.Runtime.InteropServices.Optional] ListInventory inventory)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A6")]
		[Cpp2IlInjected.Address(RVA = "0x11BC620", Offset = "0x11BB020", VA = "0x1811BC620")]
		[AsyncStateMachine(typeof(_003CTryBuyItems_003Ed__8))]
		public static Task<bool> TryBuyItems(Dictionary<Item, int> items, AssetReference popup, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A7")]
		[Cpp2IlInjected.Address(RVA = "0x11BBAD0", Offset = "0x11BA4D0", VA = "0x1811BBAD0")]
		[AsyncStateMachine(typeof(_003CDoBuyItemFlow_003Ed__9))]
		private static Task<bool> DoBuyItemFlow(Dictionary<Item, int> items, ItemCollectMode collectMode, Dictionary<Item, int> price, int response, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A8")]
		[Cpp2IlInjected.Address(RVA = "0x11BBF50", Offset = "0x11BA950", VA = "0x1811BBF50")]
		public static Task<(bool, Task)> GiveItemsToCharacter_DiscussionGift(PlayerAvatar playerAvatar, Mdl.Characters.Character character, AssetReference fastConfirmPopup, [System.Runtime.InteropServices.Optional] CancellationToken ct)
		{
			//IL_0010: Expected I4, but got I8
			//IL_0010: Expected O, but got I4
			//IL_0010: Expected I4, but got I8
			//IL_0010: Expected O, but got I4
			int num = 0;
			ulong num2 = default(ulong);
			ulong num3 = default(ulong);
			return (Task<(bool, Task)>)(object)InventoryUtil.GiveItemsToCharacter(playerAvatar, character, fastConfirmPopup, ct, (MissionSlot)num, (int)num2, (ItemFilterData)num, (byte)num != 0, (byte)num3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60020A9")]
		[Cpp2IlInjected.Address(RVA = "0x11BBF80", Offset = "0x11BA980", VA = "0x1811BBF80")]
		public static Task<(bool, Task)> GiveItemsToCharacter_MissionBringItem(PlayerAvatar playerAvatar, Mdl.Characters.Character character, AssetReference fastConfirmPopup, MissionSlot missionSlot, [System.Runtime.InteropServices.Optional] CancellationToken ct)
		{
			int num = 0;
			Task<(bool, Task)> result = default(Task<(bool, Task)>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020AA")]
		[Cpp2IlInjected.Address(RVA = "0x11BBFC0", Offset = "0x11BA9C0", VA = "0x1811BBFC0")]
		public static Task<(bool, Task)> GiveItemsToCharacter_RestaurantOrder(PlayerAvatar playerAvatar, Mdl.Characters.Character character, AssetReference fastConfirmPopup, ItemFilterData itemFilterData, [System.Runtime.InteropServices.Optional] CancellationToken ct)
		{
			int num = 0;
			Task<(bool, Task)> result = default(Task<(bool, Task)>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020AB")]
		[Cpp2IlInjected.Address(RVA = "0x11BC000", Offset = "0x11BAA00", VA = "0x1811BC000")]
		[AsyncStateMachine(typeof(_003CGiveItemsToCharacter_003Ed__13))]
		private static Task<(bool, Task)> GiveItemsToCharacter(PlayerAvatar playerAvatar, Mdl.Characters.Character character, AssetReference fastConfirmPopup, CancellationToken ct, [System.Runtime.InteropServices.Optional] MissionSlot missionSlot, int maximumAmount = 1, [System.Runtime.InteropServices.Optional] ItemFilterData itemFilterData, bool restaurantOrder = false, bool discussionGift = false)
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(bool, Task)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020AC")]
		[Cpp2IlInjected.Address(RVA = "0x11BC1E0", Offset = "0x11BABE0", VA = "0x1811BC1E0")]
		private static bool IsProfessionManual(ProfilePlayer playerProfile, List<GiveItemsToCharacter.Types.ItemGiven> itemsGiven)
		{
			//Discarded unreachable code: IL_0022
			if (Enumerable.First<GiveItemsToCharacter.Types.ItemGiven>((IEnumerable<>)itemsGiven).ContainerInventoryItemGiven != null)
			{
			}
			Item invalid = Item.Invalid;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
			}
			ActivityItemType activityItemType = default(ActivityItemType);
			return activityItemType == ActivityItemType.Manual;
		}

		[Cpp2IlInjected.Token(Token = "0x60020AD")]
		[Cpp2IlInjected.Address(RVA = "0x11BBDA0", Offset = "0x11BA7A0", VA = "0x1811BBDA0")]
		[AsyncStateMachine(typeof(_003CGiveItemsToCharacterDialogue_003Ed__15))]
		public static Task<Task> GiveItemsToCharacterDialogue(PlayerAvatar playerAvatar, Mdl.Characters.Character character, CancellationToken ct, [System.Runtime.InteropServices.Optional] MissionSlot missionSlot, [System.Runtime.InteropServices.Optional] MissionSubStep missionSubStep, bool gaveBackItems = false, bool mustRestoreCurrentDialogue = false)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Task>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020AE")]
		[Cpp2IlInjected.Address(RVA = "0x11BC320", Offset = "0x11BAD20", VA = "0x1811BC320")]
		[AsyncStateMachine(typeof(_003CReceiveItemsFromCharacter_003Ed__16))]
		public static Task ReceiveItemsFromCharacter(MultiItemInstance itemlist, Mdl.Characters.Character character, PlayerAvatar playerAvatar, CancellationToken ct, bool skipAnimation = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60020AF")]
		[Cpp2IlInjected.Address(RVA = "0x11BBC50", Offset = "0x11BA650", VA = "0x1811BBC50")]
		[AsyncStateMachine(typeof(_003CDonateItemsToHouse_003Ed__17))]
		public static Task DonateItemsToHouse(List<IItemData> items, AssetReference popup, uint gridId, uint gridObjectId, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
