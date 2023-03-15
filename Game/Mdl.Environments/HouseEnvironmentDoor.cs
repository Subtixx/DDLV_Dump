using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Mdl.Characters;
using Mdl.Items;
using Mdl.Systems;
using Meta;
using Meta.Online;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200064B")]
	public class HouseEnvironmentDoor : LockingEnvironmentDoor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C09")]
		[Cpp2IlInjected.Address(RVA = "0x11AD660", Offset = "0x11AC060", VA = "0x1811AD660")]
		private void Start()
		{
			CheckDoorUnlock();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C0A")]
		[Cpp2IlInjected.Address(RVA = "0x11AD670", Offset = "0x11AC070", VA = "0x1811AD670")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_009b
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BuildingUnlocked value = OnHouseUnlocked;
					_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerLevelGained value2 = OnPlayerLevelGained;
					_003CDispatcher_003Ek__BackingField2.OnPlayerLevelGained -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.CharacterUnlocked value3 = OnCharacterUnlocked;
					_003CDispatcher_003Ek__BackingField3.OnCharacterUnlocked -= value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C0B")]
		[Cpp2IlInjected.Address(RVA = "0x11ACDE0", Offset = "0x11AB7E0", VA = "0x1811ACDE0")]
		private void CheckDoorUnlock()
		{
			//IL_0073: Expected O, but got I4
			int num = 0;
			if ((object)GetComponentInParent<ItemScript>() != null)
			{
			}
			Item invalid = Item.Invalid;
			bool flag = default(bool);
			ulong num5 = default(ulong);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = default(ProfileEventDispatcher);
			if (flag)
			{
				IBuildingUnlockable itemData = ItemDatabase.Instance.GetItemData<IBuildingUnlockable>(invalid);
				if (!SystemRoot.Instance.MetaClient.profile.world_.IsBuildingUnlocked(itemData))
				{
					Client client = default(Client);
					int level_ = client.profile.player_.level_;
					int num2 = 0;
					uint num3 = default(uint);
					if (num2 < (int)num3)
					{
						num2 += num2;
						num2++;
					}
					CharacterManager characterManager = default(CharacterManager);
					int num4 = default(int);
					if (characterManager.IsCharacterUnlocked((Item)num2) && num4 == 0)
					{
						num4 += 328;
					}
				}
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value = OnHouseUnlocked;
				_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value2 = OnPlayerLevelGained;
				_003CDispatcher_003Ek__BackingField2.OnPlayerLevelGained -= value2;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value3 = OnCharacterUnlocked;
				_003CDispatcher_003Ek__BackingField3.OnCharacterUnlocked -= value3;
				if (num5 == 0)
				{
					int num6 = default(int);
					if (itemData == null || num6 <= 0)
					{
						Client client2 = default(Client);
						ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = client2.Dispatcher;
						ProfileEventDispatcher.PlayerLevelGained value4 = OnPlayerLevelGained;
						_003CDispatcher_003Ek__BackingField4.OnPlayerLevelGained += value4;
						Client client3 = default(Client);
						ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = client3.Dispatcher;
						ProfileEventDispatcher.CharacterUnlocked value5 = OnCharacterUnlocked;
						_003CDispatcher_003Ek__BackingField5.OnCharacterUnlocked += value5;
						throw new NullReferenceException();
					}
					Client client4 = default(Client);
					_003CDispatcher_003Ek__BackingField6 = client4.Dispatcher;
					ProfileEventDispatcher.BuildingUnlocked value6 = OnHouseUnlocked;
					_003CDispatcher_003Ek__BackingField6.OnBuildingUnlocked += value6;
				}
			}
			bool showUnlockedVFX = _003CDispatcher_003Ek__BackingField6 != null;
			bool showLockedVFX = num5 == 0;
			ShowVFX(showLockedVFX, showUnlockedVFX);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C0C")]
		[Cpp2IlInjected.Address(RVA = "0x11AD660", Offset = "0x11AC060", VA = "0x1811AD660")]
		private void OnCharacterUnlocked(Item characterItem)
		{
			CheckDoorUnlock();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C0D")]
		[Cpp2IlInjected.Address(RVA = "0x11AD660", Offset = "0x11AC060", VA = "0x1811AD660")]
		private void OnPlayerLevelGained(int gained)
		{
			CheckDoorUnlock();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C0E")]
		[Cpp2IlInjected.Address(RVA = "0x11AD660", Offset = "0x11AC060", VA = "0x1811AD660")]
		private void OnHouseUnlocked(Item item, [Optional] List<CurrencyCost> costs)
		{
			CheckDoorUnlock();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C0F")]
		[Cpp2IlInjected.Address(RVA = "0xCBB6F0", Offset = "0xCBA0F0", VA = "0x180CBB6F0")]
		public HouseEnvironmentDoor()
		{
		}
	}
}
