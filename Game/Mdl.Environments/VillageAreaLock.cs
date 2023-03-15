using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Scene;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x20006A1")]
	public class VillageAreaLock : Lock, IPlayerInteraction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002735")]
		public VillageAreaType AreaType;

		[Cpp2IlInjected.Token(Token = "0x6001D65")]
		[Cpp2IlInjected.Address(RVA = "0xD46C70", Offset = "0xD45670", VA = "0x180D46C70", Slot = "5")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_004b
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.VillageAreaUnlocked value = OnVillageAreaUnlocked;
					_003CDispatcher_003Ek__BackingField.OnVillageAreaUnlocked -= value;
				}
			}
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D66")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "7")]
		public bool CanInteract()
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D67")]
		[Cpp2IlInjected.Address(RVA = "0xD46B20", Offset = "0xD45520", VA = "0x180D46B20", Slot = "8")]
		public bool Interact()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D68")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
		public InteractPreviewData GetInteractPreviewData()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D69")]
		[Cpp2IlInjected.Address(RVA = "0xD46790", Offset = "0xD45190", VA = "0x180D46790")]
		[AsyncStateMachine(typeof(_003CAreaUnlockFlow_003Ed__5))]
		private Task AreaUnlockFlow()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D6A")]
		[Cpp2IlInjected.Address(RVA = "0xD46890", Offset = "0xD45290", VA = "0x180D46890", Slot = "6")]
		protected override Task<bool> CheckForLock(CancellationToken ct)
		{
			MapField<int, Village.Types.VillageArea> areas_ = SystemRoot.Instance.MetaClient.profile.Village.areas_;
			bool flag = default(bool);
			if (!flag)
			{
				return (Task<bool>)(object)Task.FromResult(result: false);
			}
			Collider component = GetComponent<Collider>();
			int num = ((component.enabled = false) ? 1 : 0);
			Client client = default(Client);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
			ProfileEventDispatcher.VillageAreaUnlocked value = OnVillageAreaUnlocked;
			_003CDispatcher_003Ek__BackingField.OnVillageAreaUnlocked += value;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D6B")]
		[Cpp2IlInjected.Address(RVA = "0xD46E40", Offset = "0xD45840", VA = "0x180D46E40")]
		private void OnVillageAreaUnlocked(VillageAreaType areaType, [System.Runtime.InteropServices.Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_0048
			if (AreaType == areaType)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.VillageAreaUnlocked value = OnVillageAreaUnlocked;
				_003CDispatcher_003Ek__BackingField.OnVillageAreaUnlocked -= value;
				Unlock();
				Collider component = GetComponent<Collider>();
				int num = ((component.enabled = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D6C")]
		[Cpp2IlInjected.Address(RVA = "0xD46FD0", Offset = "0xD459D0", VA = "0x180D46FD0")]
		public VillageAreaLock()
		{
		}
	}
}
