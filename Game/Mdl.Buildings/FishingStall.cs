using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Mdl.Grid;
using Mdl.Streaming;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009AA")]
	public class FishingStall : Stall
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400355B")]
		private StreamableAssetRef streamableAssetRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400355C")]
		private FishingStallLayout fishingStallLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400355D")]
		private int _currentIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400355E")]
		private GameObject _currentLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400355F")]
		private CancellationTokenSource ctsRefreshCollectLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4003560")]
		private StallBuildingItemData fishingStallItemData;

		[Cpp2IlInjected.Token(Token = "0x1700067C")]
		private StallBuildingItemData FishingStallItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6002D46")]
			[Cpp2IlInjected.Address(RVA = "0x137A4C0", Offset = "0x1378EC0", VA = "0x18137A4C0")]
			get
			{
				//Discarded unreachable code: IL_002e
				if ((object)typeof(ItemDatabase).TypeHandle == null)
				{
					GridObject _003CGridObject_003Ek__BackingField = base.GridObjectScript.GridObject;
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					int itemID = _003CGridObject_003Ek__BackingField.ItemID;
					StallBuildingItemData stallBuildingItemData = default(StallBuildingItemData);
					fishingStallItemData = stallBuildingItemData;
				}
				return (StallBuildingItemData)typeof(ItemDatabase).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3C")]
		[Cpp2IlInjected.Address(RVA = "0x137A1A0", Offset = "0x1378BA0", VA = "0x18137A1A0", Slot = "4")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_0081
			//IL_0016: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			base.Start();
			GridObjectScript gridObjectScript = base.GridObjectScript;
			int num = 0;
			if (gridObjectScript != (UnityEngine.Object)num)
			{
				GridObjectScript gridObjectScript2 = base.GridObjectScript;
				GridObjectScript.GridEditModeChangedDelegate value = GridObjectChangedEvent;
				gridObjectScript2.GridObjectChangedEvent += value;
				InitCollectLayout();
			}
			StreamableAssetRef streamableAssetRef = (this.streamableAssetRef = GetComponent<StreamableAssetRef>());
			StreamableAssetRef streamableAssetRef2 = this.streamableAssetRef;
			int num2 = 0;
			if (streamableAssetRef2 != (UnityEngine.Object)num2)
			{
				StreamableAssetRef streamableAssetRef3 = this.streamableAssetRef;
				Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnLoadedAssetLoadComplete);
				streamableAssetRef3.add_OnLoadedAssetLoadComplete((Action<>)(object)action);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3D")]
		[Cpp2IlInjected.Address(RVA = "0x1379A50", Offset = "0x1378450", VA = "0x181379A50", Slot = "5")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0093
			//IL_0010: Expected O, but got I4
			//IL_0056: Expected O, but got I8
			//IL_006a: Expected O, but got I4
			GridObjectScript gridObjectScript = base.GridObjectScript;
			int num = 0;
			if (gridObjectScript != (UnityEngine.Object)num)
			{
				GridObjectScript gridObjectScript2 = base.GridObjectScript;
				GridObjectScript.GridEditModeChangedDelegate value = GridObjectChangedEvent;
				gridObjectScript2.GridObjectChangedEvent -= value;
			}
			CancellationTokenSource cancellationTokenSource = ctsRefreshCollectLayout;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				ctsRefreshCollectLayout.Dispose();
				ctsRefreshCollectLayout = (CancellationTokenSource)0;
			}
			StreamableAssetRef streamableAssetRef = this.streamableAssetRef;
			int num2 = 0;
			if (streamableAssetRef != (UnityEngine.Object)num2)
			{
				StreamableAssetRef streamableAssetRef2 = this.streamableAssetRef;
				Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnLoadedAssetLoadComplete);
				streamableAssetRef2.remove_OnLoadedAssetLoadComplete((Action<>)(object)action);
			}
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3E")]
		[Cpp2IlInjected.Address(RVA = "0x1379860", Offset = "0x1378260", VA = "0x181379860")]
		private void GridObjectChangedEvent(GridObjectScript sender, bool editModeResynchronize)
		{
			InitCollectLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D3F")]
		[Cpp2IlInjected.Address(RVA = "0x1379C10", Offset = "0x1378610", VA = "0x181379C10")]
		private void OnLoadedAssetLoadComplete(AsyncOperationHandle<GameObject> obj)
		{
			//Discarded unreachable code: IL_0030
			//IL_001b: Expected I4, but got I8
			UnityEngine.Object.Destroy(_currentLayout);
			_currentIndex = -1;
			GameObject gameObject = default(GameObject);
			FishingStallLayout fishingStallLayout = (this.fishingStallLayout = gameObject.GetComponent<FishingStallLayout>());
			InitCollectLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D40")]
		[Cpp2IlInjected.Address(RVA = "0x1379960", Offset = "0x1378360", VA = "0x181379960")]
		private unsafe void InitCollectLayout(AsyncOperationHandle<GameObject> obj)
		{
			//Discarded unreachable code: IL_0035
			//IL_001b: Expected I4, but got I8
			UnityEngine.Object.Destroy(_currentLayout);
			_currentIndex = -1;
			FishingStallLayout fishingStallLayout = (this.fishingStallLayout = ((GameObject)((AsyncOperationHandle<TObject>*)obj)->Result).GetComponent<FishingStallLayout>());
			InitCollectLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D41")]
		[Cpp2IlInjected.Address(RVA = "0x1379870", Offset = "0x1378270", VA = "0x181379870")]
		private void InitCollectLayout()
		{
			//Discarded unreachable code: IL_0057
			//IL_0010: Expected O, but got I4
			FishingStallLayout fishingStallLayout = this.fishingStallLayout;
			int num = 0;
			if (fishingStallLayout == (UnityEngine.Object)num)
			{
				return;
			}
			List<GameObject> collectLayoutPrefab = this.fishingStallLayout._collectLayoutPrefab;
			GridObject _003CGridObject_003Ek__BackingField = base.GridObjectScript.GridObject;
			if (_003CGridObject_003Ek__BackingField != null)
			{
				GridState state_ = _003CGridObject_003Ek__BackingField.state_;
				if (state_ != null && state_.FishingStallData.upgradeState_.level_ > 0)
				{
					RefreshCollectLayout();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D42")]
		[Cpp2IlInjected.Address(RVA = "0x13792F0", Offset = "0x1377CF0", VA = "0x1813792F0")]
		private void CancelRefreshCollectLayout()
		{
			//Discarded unreachable code: IL_0005
			if ((object)this == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D43")]
		[Cpp2IlInjected.Address(RVA = "0x1379340", Offset = "0x1377D40", VA = "0x181379340")]
		private void ClearCollectLayout()
		{
			//IL_001b: Expected I4, but got I8
			UnityEngine.Object.Destroy(_currentLayout);
			_currentIndex = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D44")]
		[Cpp2IlInjected.Address(RVA = "0x1379D00", Offset = "0x1378700", VA = "0x181379D00")]
		private void RefreshCollectLayout()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002D45")]
		[Cpp2IlInjected.Address(RVA = "0x137A360", Offset = "0x1378D60", VA = "0x18137A360")]
		[AsyncStateMachine(typeof(_003CWaitForNextRefresh_003Ed__14))]
		private Task WaitForNextRefresh(TimeSpan delay, Action refreshMethod, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D47")]
		[Cpp2IlInjected.Address(RVA = "0x13794F0", Offset = "0x1377EF0", VA = "0x1813794F0")]
		public (TimeSpan, int, int) FishCollectInfo()
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			FishingStallData fishingStallData = default(FishingStallData);
			UpgradeState upgradeState_ = fishingStallData.upgradeState_;
			UpgradeData upgradeData = default(UpgradeData);
			if (upgradeData != null)
			{
				BenefitsFishingData fishing = upgradeData.Fishing;
				DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
				FishingStallData fishingStallData2 = default(FishingStallData);
				DateTime lastCollectDateTime = fishingStallData2.LastCollectDateTime;
				BenefitsFishingData fishing2 = upgradeData.Fishing;
				int num = 0;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D48")]
		[Cpp2IlInjected.Address(RVA = "0x13793B0", Offset = "0x1377DB0", VA = "0x1813793B0")]
		[AsyncStateMachine(typeof(_003CCollect_003Ed__19))]
		public Task<CollectFishingStall.Types.Response> Collect(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<CollectFishingStall.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D49")]
		[Cpp2IlInjected.Address(RVA = "0x137A4A0", Offset = "0x1378EA0", VA = "0x18137A4A0")]
		public FishingStall()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
