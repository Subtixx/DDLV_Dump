using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000679")]
	public class RealmEnvironmentDoor : LockingEnvironmentDoor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400268C")]
		[SerializeField]
		internal AK.Wwise.Event _realmUnlockedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400268D")]
		public WorldData.Types.World currentWorld;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400268E")]
		internal CancellationTokenProvider cancellationTokenProvider;

		[Cpp2IlInjected.Token(Token = "0x6001CC2")]
		[Cpp2IlInjected.Address(RVA = "0xCBB520", Offset = "0xCB9F20", VA = "0x180CBB520")]
		private void Start()
		{
			//Discarded unreachable code: IL_0029
			CancellationTokenProvider cancellationTokenProvider = (this.cancellationTokenProvider = base.gameObject.GetOrAddComponent<CancellationTokenProvider>());
			CancellationToken cancellationToken = this.cancellationTokenProvider.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC3")]
		[Cpp2IlInjected.Address(RVA = "0xCBAF20", Offset = "0xCB9920", VA = "0x180CBAF20")]
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
					ProfileEventDispatcher.PlayerLevelGained value = OnPlayerLevelGained;
					_003CDispatcher_003Ek__BackingField.OnPlayerLevelGained -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.CharacterUnlocked value2 = OnCharacterUnlocked;
					_003CDispatcher_003Ek__BackingField2.OnCharacterUnlocked -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.RealmUnlocked value3 = OnRealmUnlocked;
					_003CDispatcher_003Ek__BackingField3.OnRealmUnlocked -= value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC4")]
		[Cpp2IlInjected.Address(RVA = "0xCBADF0", Offset = "0xCB97F0", VA = "0x180CBADF0")]
		[AsyncStateMachine(typeof(_003CInitCurrentWorld_003Ed__5))]
		private Task InitCurrentWorld(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC5")]
		[Cpp2IlInjected.Address(RVA = "0xCBA400", Offset = "0xCB8E00", VA = "0x180CBA400")]
		private unsafe void CheckDoorUnlock()
		{
			//Discarded unreachable code: IL_0235
			int num = 0;
			int num2 = 0;
			if ((IntPtr)currentWorld != (IntPtr)num)
			{
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				WorldData.Types.World world = currentWorld;
				MapField<string, Realm> realms_ = world_.realms_;
				string worldName_ = world.worldName_;
				if (((MapField<TKey, TValue>)(object)realms_).TryGetValue((TKey)worldName_, out *(TValue*)num))
				{
				}
				if (num == 0)
				{
					Client client = default(Client);
					ProfilePlayer player_ = client.profile.player_;
					int unlockAtLevel_ = currentWorld.unlockAtLevel_;
					Client client2 = default(Client);
					int num3 = client2.profile.world_.UnlockCharacterCount();
					WorldData.Types.World world2 = currentWorld;
					int unlockWith_ = currentWorld.unlockWith_;
					bool flag = default(bool);
					if (!flag || ((RepeatedField<T>)(object)currentWorld.unlockCost_).Count != 0 || currentWorld.manaCost_ == 0)
					{
					}
					Client client3 = default(Client);
					ProfileWorld world_2 = client3.profile.world_;
					int forceUnlockWithDialogueFlag_ = currentWorld.forceUnlockWithDialogueFlag_;
				}
			}
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PlayerLevelGained value = OnPlayerLevelGained;
			_003CDispatcher_003Ek__BackingField.OnPlayerLevelGained -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterUnlocked value2 = OnCharacterUnlocked;
			_003CDispatcher_003Ek__BackingField2.OnCharacterUnlocked -= value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.RealmUnlocked value3 = OnRealmUnlocked;
			_003CDispatcher_003Ek__BackingField3.OnRealmUnlocked -= value3;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.DialogueFlagChange value4 = OnDialogueFlagChange;
			_003CDispatcher_003Ek__BackingField4.OnDialogueFlagChange -= value4;
			if (num2 == 0)
			{
				WorldData.Types.World world3 = currentWorld;
				if (world3 != null)
				{
					int count = ((RepeatedField<T>)(object)world3.unlockCost_).Count;
					if (currentWorld.manaCost_ > 0)
					{
						Client client4 = default(Client);
						ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = client4.Dispatcher;
						ProfileEventDispatcher.RealmUnlocked value5 = OnRealmUnlocked;
						_003CDispatcher_003Ek__BackingField5.OnRealmUnlocked += value5;
					}
				}
				Client client5 = default(Client);
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = client5.Dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value6 = OnPlayerLevelGained;
				_003CDispatcher_003Ek__BackingField6.OnPlayerLevelGained += value6;
				Client client6 = default(Client);
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField7 = client6.Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value7 = OnCharacterUnlocked;
				_003CDispatcher_003Ek__BackingField7.OnCharacterUnlocked += value7;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField8 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.DialogueFlagChange value8 = OnDialogueFlagChange;
				_003CDispatcher_003Ek__BackingField8.OnDialogueFlagChange += value8;
			}
			ShowVFX((byte)num2 != 0, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC6")]
		[Cpp2IlInjected.Address(RVA = "0xCBAF10", Offset = "0xCB9910", VA = "0x180CBAF10")]
		private void OnCharacterUnlocked(Item characterItem)
		{
			CheckDoorUnlock();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC7")]
		[Cpp2IlInjected.Address(RVA = "0xCBAF10", Offset = "0xCB9910", VA = "0x180CBAF10")]
		private void OnPlayerLevelGained(int gained)
		{
			CheckDoorUnlock();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC8")]
		[Cpp2IlInjected.Address(RVA = "0xCBAF10", Offset = "0xCB9910", VA = "0x180CBAF10")]
		private void OnRealmUnlocked(string realmID, bool unlockedByFlag)
		{
			CheckDoorUnlock();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC9")]
		[Cpp2IlInjected.Address(RVA = "0xCBB270", Offset = "0xCB9C70", VA = "0x180CBB270")]
		private void OnDialogueFlagChange(Item flagItem, bool active)
		{
			//Discarded unreachable code: IL_0047
			//IL_0041: Expected O, but got I4
			if (!active)
			{
				return;
			}
			WorldData.Types.World world = currentWorld;
			if (world != null)
			{
				int forceUnlockWithDialogueFlag_ = world.forceUnlockWithDialogueFlag_;
				if (world != null)
				{
					UnlockRealm.Types.Request request = new UnlockRealm.Types.Request();
					int num = (request.realmID_ = GetSceneItemData().iD_);
					int num2 = 0;
					Client client = default(Client);
					client.UnlockRealm(request, (CancellationToken)num2).FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CCA")]
		[Cpp2IlInjected.Address(RVA = "0xCBB400", Offset = "0xCB9E00", VA = "0x180CBB400", Slot = "11")]
		[AsyncStateMachine(typeof(_003CRemoveThorns_003Ed__11))]
		protected override Task RemoveThorns(GameObject thorns)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CCB")]
		[Cpp2IlInjected.Address(RVA = "0xCBB6F0", Offset = "0xCBA0F0", VA = "0x180CBB6F0")]
		public RealmEnvironmentDoor()
		{
		}
	}
}
