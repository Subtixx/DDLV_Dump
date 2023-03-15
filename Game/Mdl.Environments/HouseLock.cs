using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200064C")]
	public class HouseLock : Lock, IPlayerInteraction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400258A")]
		public AssetReference requiredPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400258B")]
		private Item houseItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400258C")]
		private GridObjectScript gridObjectScript;

		[Cpp2IlInjected.Token(Token = "0x170003F2")]
		private bool IsInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6001C10")]
			[Cpp2IlInjected.Address(RVA = "0x11AE520", Offset = "0x11ACF20", VA = "0x1811AE520")]
			get
			{
				GridObjectScript gridObjectScript = this.gridObjectScript;
				if ((object)gridObjectScript != null)
				{
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						GridState state_ = _003CGridObject_003Ek__BackingField.state_;
						if (state_ != null)
						{
							return state_.HouseData != null;
						}
					}
				}
				return 0 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F3")]
		private bool IsBuilt
		{
			[Cpp2IlInjected.Token(Token = "0x6001C11")]
			[Cpp2IlInjected.Address(RVA = "0x11AE4B0", Offset = "0x11ACEB0", VA = "0x1811AE4B0")]
			get
			{
				GridObjectScript gridObjectScript = this.gridObjectScript;
				if ((object)gridObjectScript != null)
				{
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						GridState state_ = _003CGridObject_003Ek__BackingField.state_;
						if (state_ != null && state_.HouseData != null)
						{
							return this.gridObjectScript.GridObject.state_.HouseData.built_;
						}
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C12")]
		[Cpp2IlInjected.Address(RVA = "0x11ADDA0", Offset = "0x11AC7A0", VA = "0x1811ADDA0")]
		private void Init()
		{
			//Discarded unreachable code: IL_00c3
			//IL_0015: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			ItemScript componentInParent = base.gameObject.GetComponentInParent<ItemScript>();
			int num = 0;
			if (componentInParent != (UnityEngine.Object)num)
			{
				int item = componentInParent._item;
				houseItem = (Item)item;
				GridObjectScript gridObjectScript = (this.gridObjectScript = componentInParent.GetComponent<GridObjectScript>());
			}
			GridObjectScript gridObjectScript2 = this.gridObjectScript;
			int num2 = 0;
			if (!(gridObjectScript2 != (UnityEngine.Object)num2))
			{
				return;
			}
			GridObjectScript gridObjectScript3 = this.gridObjectScript;
			if ((object)gridObjectScript3 != null)
			{
				GridObject _003CGridObject_003Ek__BackingField = gridObjectScript3.GridObject;
				if (_003CGridObject_003Ek__BackingField != null)
				{
					GridState state_ = _003CGridObject_003Ek__BackingField.state_;
					if (state_ != null && state_.HouseData != null && this.gridObjectScript.GridObject.state_.HouseData.built_)
					{
						UnInit();
						return;
					}
				}
			}
			Client client = default(Client);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
			ProfileEventDispatcher.GridChanged value = Dispatcher_OnGridChanged;
			_003CDispatcher_003Ek__BackingField.OnGridChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C13")]
		[Cpp2IlInjected.Address(RVA = "0x11AE270", Offset = "0x11ACC70", VA = "0x1811AE270")]
		private void UnInit()
		{
			//Discarded unreachable code: IL_0068
			//IL_0058: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.GridChanged value = Dispatcher_OnGridChanged;
					_003CDispatcher_003Ek__BackingField.OnGridChanged -= value;
				}
			}
			Collider component = GetComponent<Collider>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int num2 = ((component.enabled = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C14")]
		[Cpp2IlInjected.Address(RVA = "0x11AE250", Offset = "0x11ACC50", VA = "0x1811AE250", Slot = "4")]
		protected override void Start()
		{
			Init();
			base.Start();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C15")]
		[Cpp2IlInjected.Address(RVA = "0x11AE110", Offset = "0x11ACB10", VA = "0x1811AE110", Slot = "5")]
		protected override void OnDestroy()
		{
			UnInit();
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C16")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "7")]
		public bool CanInteract()
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C17")]
		[Cpp2IlInjected.Address(RVA = "0x11ADFD0", Offset = "0x11AC9D0", VA = "0x1811ADFD0", Slot = "8")]
		public bool Interact()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C18")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
		public InteractPreviewData GetInteractPreviewData()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C19")]
		[Cpp2IlInjected.Address(RVA = "0x11ADCA0", Offset = "0x11AC6A0", VA = "0x1811ADCA0")]
		[AsyncStateMachine(typeof(_003CHouseUnlockFlow_003Ed__14))]
		private Task HouseUnlockFlow()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1A")]
		[Cpp2IlInjected.Address(RVA = "0x11AE130", Offset = "0x11ACB30", VA = "0x1811AE130")]
		[AsyncStateMachine(typeof(_003COpenBuyMenu_003Ed__15))]
		private Task OpenBuyMenu(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1B")]
		[Cpp2IlInjected.Address(RVA = "0x11AD9C0", Offset = "0x11AC3C0", VA = "0x1811AD9C0", Slot = "6")]
		protected override Task<bool> CheckForLock(CancellationToken ct)
		{
			//Discarded unreachable code: IL_005a
			GridObjectScript gridObjectScript = this.gridObjectScript;
			if ((object)gridObjectScript != null)
			{
				GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
				if (_003CGridObject_003Ek__BackingField != null)
				{
					GridState state_ = _003CGridObject_003Ek__BackingField.state_;
					if (state_ != null && state_.HouseData != null)
					{
						return (Task<bool>)(object)Task.FromResult(IsBuilt);
					}
				}
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = houseItem;
			return (Task<bool>)(object)Task.FromResult(!_003CInstance_003Ek__BackingField.GetItemData<BuildingItemData>(item).MustConstruct);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1C")]
		[Cpp2IlInjected.Address(RVA = "0x11ADB50", Offset = "0x11AC550", VA = "0x1811ADB50")]
		private void Dispatcher_OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_0065
			if (operation != GridChangedOperation.UpdateState)
			{
				return;
			}
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			uint gridID = gridObjectScript.GridScript.GridID;
			if ((IntPtr)typeof(IGrid).TypeHandle == (IntPtr)(int)gridID)
			{
				uint iD_ = gridObjectScript.GridObject.iD_;
				if (gridObject.iD_ == iD_ && gridObject.state_.HouseData.built_)
				{
					UnInit();
					Unlock();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1D")]
		[Cpp2IlInjected.Address(RVA = "0xD46FD0", Offset = "0xD459D0", VA = "0x180D46FD0")]
		public HouseLock()
		{
		}
	}
}
