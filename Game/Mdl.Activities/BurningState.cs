using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Systems;
using Mdl.Ui;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B1D")]
	internal abstract class BurningState : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DD6")]
		[SerializeField]
		private GameObject _burningStateVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003DD7")]
		private Task<GameObject> burningStateVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003DD8")]
		[SerializeField]
		private GameObject _burningStateCollectVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003DD9")]
		[SerializeField]
		private AssetReferenceGameObject _burningStateCollectInfoGizmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003DDA")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x170006FD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4003DDB")]
		public bool InBurningState
		{
			[Cpp2IlInjected.Token(Token = "0x600333B")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600333C")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006FE")]
		protected virtual GameObject CollectInfoGizmoTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600333D")]
			[Cpp2IlInjected.Address(RVA = "0x8CA490", Offset = "0x8C8E90", VA = "0x1808CA490", Slot = "4")]
			get
			{
				return base.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600333E")]
		[Cpp2IlInjected.Address(RVA = "0x16462D0", Offset = "0x1644CD0", VA = "0x1816462D0", Slot = "5")]
		protected virtual void Start()
		{
			//Discarded unreachable code: IL_0071
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.BurningStateUpdated value = OnBurningStateStarted;
			_003CDispatcher_003Ek__BackingField.OnBurningStateStarted += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.BurningStateUpdated value2 = OnBurningStateEnded;
			_003CDispatcher_003Ek__BackingField2.OnBurningStateEnded += value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CollectBurningState value3 = OnBurningStateCollected;
			_003CDispatcher_003Ek__BackingField3.OnBurningStateCollected += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x600333F")]
		[Cpp2IlInjected.Address(RVA = "0x1645A10", Offset = "0x1644410", VA = "0x181645A10", Slot = "6")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_009b
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BurningStateUpdated value = OnBurningStateStarted;
					_003CDispatcher_003Ek__BackingField.OnBurningStateStarted -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BurningStateUpdated value2 = OnBurningStateEnded;
					_003CDispatcher_003Ek__BackingField2.OnBurningStateEnded -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.CollectBurningState value3 = OnBurningStateCollected;
					_003CDispatcher_003Ek__BackingField3.OnBurningStateCollected -= value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003340")]
		[Cpp2IlInjected.Address(RVA = "0x16459C0", Offset = "0x16443C0", VA = "0x1816459C0")]
		private void OnBurningStateStarted(Meta.BurningState.IBurningState burningState)
		{
			if (IsBurningForThisObject(burningState))
			{
				InBurningState = true;
				StartBurningState(burningState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003341")]
		[Cpp2IlInjected.Address(RVA = "0x1645980", Offset = "0x1644380", VA = "0x181645980")]
		private void OnBurningStateEnded(Meta.BurningState.IBurningState burningState)
		{
			if (IsBurningForThisObject(burningState))
			{
				EndBurningState();
				InBurningState = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003342")]
		[Cpp2IlInjected.Address(RVA = "0x1645670", Offset = "0x1644070", VA = "0x181645670")]
		private void OnBurningStateCollected(Meta.BurningState.IBurningState burningState, ItemInstance item)
		{
			//Discarded unreachable code: IL_007f
			//IL_0063: Expected O, but got I4
			IItemData itemData = default(IItemData);
			while (IsBurningForThisObject(burningState))
			{
				if (_burningStateCollectInfoGizmo.RuntimeKeyIsValid())
				{
					GameObject collectInfoGizmoTarget = CollectInfoGizmoTarget;
					CancellationToken token = cancellationTokenSource.Token;
					object[] array = new object[2];
					Item item2 = item.Item;
					if (itemData != null && itemData == null)
					{
						continue;
					}
					array[0] = itemData;
					int amount_ = item.amount_;
					string text = $"+{amount_}";
					if (text != null && text == null)
					{
						continue;
					}
					array[1] = text;
				}
				PlayBurningStateCollectVFX();
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003343")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool IsBurningForThisObject(Meta.BurningState.IBurningState burningState);

		[Cpp2IlInjected.Token(Token = "0x6003344")]
		[Cpp2IlInjected.Address(RVA = "0x1645350", Offset = "0x1643D50", VA = "0x181645350")]
		[AsyncStateMachine(typeof(_003CClearBurningState_003Ed__17))]
		private Task ClearBurningState(DateTime dateTime, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003345")]
		[Cpp2IlInjected.Address(RVA = "0x1645650", Offset = "0x1644050", VA = "0x181645650")]
		public void ForceStartBurningState(Meta.BurningState.IBurningState burningState)
		{
			InBurningState = true;
			bool flag = IsBurningForThisObject(burningState);
		}

		[Cpp2IlInjected.Token(Token = "0x6003346")]
		[Cpp2IlInjected.Address(RVA = "0x1645F30", Offset = "0x1644930", VA = "0x181645F30", Slot = "8")]
		protected virtual void StartBurningState(Meta.BurningState.IBurningState burningState)
		{
			//Discarded unreachable code: IL_0050
			CancellationTokenSource cancellationTokenSource = (this.cancellationTokenSource = new CancellationTokenSource());
			CancellationToken cancellationToken = default(CancellationToken);
			Task<GameObject> task = (burningStateVFXInstance = (Task<GameObject>)(object)this.PlayBurningStateVFX(cancellationToken));
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			DateTime dateTime = default(DateTime);
			TimeSpan timeSpan = default(TimeSpan);
			DateTime dateTime2 = dateTime + timeSpan;
			int num3 = 0;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x6003347")]
		[Cpp2IlInjected.Address(RVA = "0x1645460", Offset = "0x1643E60", VA = "0x181645460", Slot = "9")]
		protected virtual void EndBurningState()
		{
			//Discarded unreachable code: IL_0071
			//IL_0040: Expected O, but got I8
			//IL_0065: Expected O, but got I8
			Task<GameObject> task = burningStateVFXInstance;
			if (task != null)
			{
				if (task.IsCompleted && !Addressables.ReleaseInstance((GameObject)((Task<TResult>)(object)burningStateVFXInstance).Result))
				{
					UnityEngine.Object.Destroy((UnityEngine.Object)((Task<TResult>)(object)burningStateVFXInstance).Result);
				}
				burningStateVFXInstance = (Task<GameObject>)0;
			}
			CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				this.cancellationTokenSource.Dispose();
				this.cancellationTokenSource = (CancellationTokenSource)0;
			}
			IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x6003348")]
		[Cpp2IlInjected.Address(RVA = "0x1645E10", Offset = "0x1644810", VA = "0x181645E10", Slot = "10")]
		protected virtual Task<GameObject> PlayBurningStateVFX(CancellationToken ct)
		{
			//IL_0010: Expected O, but got I4
			GameObject burningStateVFXPrefab = _burningStateVFXPrefab;
			int num = 0;
			if (!(burningStateVFXPrefab != (UnityEngine.Object)num))
			{
			}
			GameObject burningStateVFXPrefab2 = _burningStateVFXPrefab;
			Transform parent = base.transform;
			return (Task<GameObject>)(object)Task.FromResult(UnityEngine.Object.Instantiate(burningStateVFXPrefab2, parent));
		}

		[Cpp2IlInjected.Token(Token = "0x6003349")]
		[Cpp2IlInjected.Address(RVA = "0x1645D50", Offset = "0x1644750", VA = "0x181645D50", Slot = "11")]
		protected virtual void PlayBurningStateCollectVFX()
		{
			//IL_0010: Expected O, but got I4
			GameObject burningStateCollectVFXPrefab = _burningStateCollectVFXPrefab;
			int num = 0;
			if (burningStateCollectVFXPrefab != (UnityEngine.Object)num)
			{
				GameObject burningStateCollectVFXPrefab2 = _burningStateCollectVFXPrefab;
				Transform parent = base.transform;
				GameObject gameObject = UnityEngine.Object.Instantiate(burningStateCollectVFXPrefab2, parent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600334A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected BurningState()
		{
		}
	}
}
