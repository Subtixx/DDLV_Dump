using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000779")]
	public abstract class Lock : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AE7")]
		[SerializeField]
		private GameObject _lockVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AE8")]
		[SerializeField]
		private string _lockVFXOutBool = "out";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AE9")]
		public AK.Wwise.Event _sfxEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002AEA")]
		public Transform SpawnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002AEB")]
		private CancellationTokenProvider cancellationTokenProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002AEC")]
		private GameObject lockVFXInstance;

		[Cpp2IlInjected.Token(Token = "0x14000049")]
		public event EventHandler UnlockEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002130")]
			[Cpp2IlInjected.Address(RVA = "0xBB9730", Offset = "0xBB8130", VA = "0x180BB9730")]
			[CompilerGenerated]
			add
			{
				EventHandler unlockEvent = this.UnlockEvent;
				Delegate @delegate = Delegate.Combine(unlockEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != unlockEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002131")]
			[Cpp2IlInjected.Address(RVA = "0xBB97D0", Offset = "0xBB81D0", VA = "0x180BB97D0")]
			[CompilerGenerated]
			remove
			{
				EventHandler unlockEvent = this.UnlockEvent;
				Delegate @delegate = Delegate.Remove(unlockEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != unlockEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002132")]
		[Cpp2IlInjected.Address(RVA = "0xBB92E0", Offset = "0xBB7CE0", VA = "0x180BB92E0", Slot = "4")]
		protected virtual void Start()
		{
			//IL_001e: Expected O, but got I4
			CancellationTokenProvider cancellationTokenProvider = (this.cancellationTokenProvider = this.GetOrAddComponent<CancellationTokenProvider>());
			GameObject lockVFXPrefab = _lockVFXPrefab;
			int num = 0;
			if (lockVFXPrefab != (UnityEngine.Object)num)
			{
				int num2 = 0;
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002133")]
		[Cpp2IlInjected.Address(RVA = "0xBB9030", Offset = "0xBB7A30", VA = "0x180BB9030", Slot = "5")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_0036
			//IL_0013: Expected O, but got I4
			//IL_0013: Expected O, but got I4
			if ((object)SystemRoot.Instance != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneStack.CurrentSceneChanged value = OnCurrentSceneChanged;
				sceneStack.OnCurrentSceneChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002134")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract Task<bool> CheckForLock(CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6002135")]
		[Cpp2IlInjected.Address(RVA = "0xBB8C90", Offset = "0xBB7690", VA = "0x180BB8C90")]
		private void Initialize()
		{
			//IL_0010: Expected O, but got I4
			GameObject lockVFXPrefab = _lockVFXPrefab;
			int num = 0;
			if (lockVFXPrefab != (UnityEngine.Object)num)
			{
				int num2 = 0;
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002136")]
		[Cpp2IlInjected.Address(RVA = "0xBB9210", Offset = "0xBB7C10", VA = "0x180BB9210")]
		[AsyncStateMachine(typeof(_003CPrepareVFX_003Ed__13))]
		private void PrepareVFX()
		{
			int num = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6002137")]
		[Cpp2IlInjected.Address(RVA = "0xBB9440", Offset = "0xBB7E40", VA = "0x180BB9440")]
		protected void Unlock()
		{
			//Discarded unreachable code: IL_0075
			//IL_0019: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			if (this.UnlockEvent != null)
			{
			}
			GameObject gameObject = lockVFXInstance;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneStack.CurrentSceneChanged value = OnCurrentSceneChanged;
				sceneStack.OnCurrentSceneChanged += value;
				Animator componentInChildren = lockVFXInstance.GetComponentInChildren<Animator>();
				int num2 = 0;
				bool flag = componentInChildren != (UnityEngine.Object)num2;
				GameObject gameObject2 = lockVFXInstance;
				if (!flag)
				{
					UnityEngine.Object.Destroy(gameObject2);
				}
				else
				{
					DestroyOnEnable destroyOnEnable = gameObject2.AddComponent<DestroyOnEnable>();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002138")]
		[Cpp2IlInjected.Address(RVA = "0xBB8DC0", Offset = "0xBB77C0", VA = "0x180BB8DC0")]
		[AsyncStateMachine(typeof(_003CIsLocked_003Ed__15))]
		public Task<bool> IsLocked()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002139")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EE0", Offset = "0xBB78E0", VA = "0x180BB8EE0")]
		private void OnCurrentSceneChanged(SceneData scene)
		{
			//Discarded unreachable code: IL_002b
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneStack.CurrentSceneChanged value = OnCurrentSceneChanged;
			sceneStack.OnCurrentSceneChanged -= value;
			UnityEngine.Object.Destroy(lockVFXInstance);
		}

		[Cpp2IlInjected.Token(Token = "0x600213A")]
		[Cpp2IlInjected.Address(RVA = "0xBB96E0", Offset = "0xBB80E0", VA = "0x180BB96E0")]
		protected Lock()
		{
		}
	}
}
