using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x2000982")]
	internal class BuildingLock : Lock, IPlayerTaskProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2000983")]
		public delegate void BuildingUnlock();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003473")]
		[SerializeField]
		private PlayerTaskDefinition _unlockBuilding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003474")]
		private ItemScript itemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003475")]
		private bool locked;

		[Cpp2IlInjected.Token(Token = "0x1400006C")]
		public event BuildingUnlock OnBuildingUnlock
		{
			[Cpp2IlInjected.Token(Token = "0x6002C5A")]
			[Cpp2IlInjected.Address(RVA = "0x1644E20", Offset = "0x1643820", VA = "0x181644E20")]
			[CompilerGenerated]
			add
			{
				BuildingUnlock onBuildingUnlock = this.OnBuildingUnlock;
				Delegate @delegate = Delegate.Combine(onBuildingUnlock, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBuildingUnlock)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002C5B")]
			[Cpp2IlInjected.Address(RVA = "0x1644EC0", Offset = "0x16438C0", VA = "0x181644EC0")]
			[CompilerGenerated]
			remove
			{
				BuildingUnlock onBuildingUnlock = this.OnBuildingUnlock;
				Delegate @delegate = Delegate.Remove(onBuildingUnlock, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBuildingUnlock)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C5C")]
		[Cpp2IlInjected.Address(RVA = "0x1644DC0", Offset = "0x16437C0", VA = "0x181644DC0", Slot = "4")]
		protected override void Start()
		{
			ItemScript itemScript = (this.itemScript = GetComponent<ItemScript>());
			base.Start();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C5D")]
		[Cpp2IlInjected.Address(RVA = "0x1644BF0", Offset = "0x16435F0", VA = "0x181644BF0", Slot = "5")]
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
					ProfileEventDispatcher.BuildingUnlocked value = OnBuildingUnlocked;
					_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
				}
			}
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C5E")]
		[Cpp2IlInjected.Address(RVA = "0x16449C0", Offset = "0x16433C0", VA = "0x1816449C0", Slot = "6")]
		[AsyncStateMachine(typeof(_003CCheckForLock_003Ed__9))]
		protected override Task<bool> CheckForLock(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C5F")]
		[Cpp2IlInjected.Address(RVA = "0x1644B50", Offset = "0x1643550", VA = "0x181644B50")]
		private void OnBuildingUnlocked(Item item, [System.Runtime.InteropServices.Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_002d
			if ((object)itemScript.Item != null)
			{
				locked = false;
				Unlock();
				this.OnBuildingUnlock?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C60")]
		[Cpp2IlInjected.Address(RVA = "0x1644AE0", Offset = "0x16434E0", VA = "0x181644AE0", Slot = "7")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__11))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__11(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C61")]
		[Cpp2IlInjected.Address(RVA = "0xD46FD0", Offset = "0xD459D0", VA = "0x180D46FD0")]
		public BuildingLock()
		{
		}
	}
}
