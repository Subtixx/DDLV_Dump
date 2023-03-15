using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B6F")]
	public class ItemCollectMinigame : Mdl.Systems.System
	{
		[Cpp2IlInjected.Token(Token = "0x2000B70")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003F9D")]
			private readonly ItemCollectMinigame itemCollectMinigame;

			[Cpp2IlInjected.Token(Token = "0x6003507")]
			[Cpp2IlInjected.Address(RVA = "0xF66330", Offset = "0xF64D30", VA = "0x180F66330")]
			internal Scope(ItemCollectMinigame itemCollectMinigame)
			{
				//Discarded unreachable code: IL_001a
				this.itemCollectMinigame = itemCollectMinigame;
				int blockMinigameCounter = itemCollectMinigame._blockMinigameCounter;
				blockMinigameCounter = (itemCollectMinigame.blockMinigameCounter = blockMinigameCounter + 1);
			}

			[Cpp2IlInjected.Token(Token = "0x6003508")]
			[Cpp2IlInjected.Address(RVA = "0xF66300", Offset = "0xF64D00", VA = "0x180F66300", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003F93")]
		[SerializeField]
		[FormerlySerializedAs("_distanceToCollectCoin")]
		private float _distanceToCollectItem = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4003F94")]
		[SerializeField]
		private float _minSpawnDistance = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003F95")]
		[SerializeField]
		private float _maxSpawnDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003F96")]
		[SerializeField]
		private GameObject _pickUpVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003F97")]
		[SerializeField]
		private GameObject _endMinigameVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003F98")]
		[SerializeField]
		private AssetReferenceGameObject _pickUpResultInfoGizmoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003F99")]
		[SerializeField]
		private RewardSpawnAnimationData _rewardSpawnAnimationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003F9A")]
		private readonly List<Profile.ItemCollectMinigame> notStartedMinigames = (List<Profile.ItemCollectMinigame>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003F9B")]
		private TaskCompletionSource<bool> blockMinigameTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003F9C")]
		private int _blockMinigameCounter;

		[Cpp2IlInjected.Token(Token = "0x17000730")]
		private Task BlockMinigameTask
		{
			[Cpp2IlInjected.Token(Token = "0x60034F9")]
			[Cpp2IlInjected.Address(RVA = "0x11BF620", Offset = "0x11BE020", VA = "0x1811BF620")]
			get
			{
				TaskCompletionSource<bool> taskCompletionSource = blockMinigameTCS;
				if (taskCompletionSource == null || ((TaskCompletionSource<>)(object)taskCompletionSource).m_task == null)
				{
					int num = 0;
					return Task.CompletedTask;
				}
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000731")]
		private int blockMinigameCounter
		{
			[Cpp2IlInjected.Token(Token = "0x60034FA")]
			[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
			get
			{
				return _blockMinigameCounter;
			}
			[Cpp2IlInjected.Token(Token = "0x60034FB")]
			[Cpp2IlInjected.Address(RVA = "0x11BF6A0", Offset = "0x11BE0A0", VA = "0x1811BF6A0")]
			set
			{
				//Discarded unreachable code: IL_003c
				//IL_0020: Expected O, but got I4
				//IL_002a: Expected O, but got I8
				if (_blockMinigameCounter != value)
				{
					_blockMinigameCounter = value;
					if (value == 0)
					{
						bool flag = ((TaskCompletionSource<TResult>)(object)blockMinigameTCS).TrySetResult((TResult)1);
						blockMinigameTCS = (TaskCompletionSource<bool>)0;
					}
					if (value == 1)
					{
						TaskCompletionSource<bool> taskCompletionSource = (blockMinigameTCS = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034FC")]
		[Cpp2IlInjected.Address(RVA = "0x11BEF90", Offset = "0x11BD990", VA = "0x1811BEF90", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0025
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.MinigameEventHandler value = OnItemCollectMinigameAdded;
			_003CDispatcher_003Ek__BackingField.OnItemCollectMinigameAdded += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60034FD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034FE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034FF")]
		[Cpp2IlInjected.Address(RVA = "0x11BF0C0", Offset = "0x11BDAC0", VA = "0x1811BF0C0", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0037
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.MinigameEventHandler value = OnItemCollectMinigameAdded;
				_003CDispatcher_003Ek__BackingField.OnItemCollectMinigameAdded -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003500")]
		[Cpp2IlInjected.Address(RVA = "0x11BF3D0", Offset = "0x11BDDD0", VA = "0x1811BF3D0")]
		public void StartMinigame(int id, [Optional] Vector3? origin)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003501")]
		[Cpp2IlInjected.Address(RVA = "0x11BEED0", Offset = "0x11BD8D0", VA = "0x1811BEED0")]
		private void OnItemCollectMinigameAdded(Profile.ItemCollectMinigame minigame)
		{
			//Discarded unreachable code: IL_0026
			//IL_0013: Expected O, but got I4
			if (minigame.State != 0)
			{
				int num = 0;
				this.StartMinigameAsync(minigame, (Nullable<>)num).FireAndForgetTask();
			}
			else
			{
				((List<T>)(object)notStartedMinigames).Add((T)minigame);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003502")]
		[Cpp2IlInjected.Address(RVA = "0x11BF2A0", Offset = "0x11BDCA0", VA = "0x1811BF2A0")]
		[AsyncStateMachine(typeof(_003CStartMinigameAsync_003Ed__21))]
		private Task StartMinigameAsync(Profile.ItemCollectMinigame minigame, [Optional] Vector3? origin)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003503")]
		[Cpp2IlInjected.Address(RVA = "0x11BEE20", Offset = "0x11BD820", VA = "0x1811BEE20")]
		[IteratorStateMachine(typeof(_003CMinigameCoroutine_003Ed__22))]
		private IEnumerator MinigameCoroutine(Profile.ItemCollectMinigame minigame, List<GameObject> items)
		{
			int _003C_003E1__state = default(int);
			_003CMinigameCoroutine_003Ed__22 _003CMinigameCoroutine_003Ed__ = new _003CMinigameCoroutine_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CMinigameCoroutine_003Ed__._003C_003E4__this = this;
			_003CMinigameCoroutine_003Ed__.minigame = minigame;
			_003CMinigameCoroutine_003Ed__.items = items;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003504")]
		[Cpp2IlInjected.Address(RVA = "0x11BED30", Offset = "0x11BD730", VA = "0x1811BED30")]
		private static void DestroyAfterAnimation(GameObject item, string trigger)
		{
			//Discarded unreachable code: IL_0022
			//IL_0010: Expected O, but got I4
			Animator componentInChildren = item.GetComponentInChildren<Animator>();
			int num = 0;
			if (!(componentInChildren == (UnityEngine.Object)num))
			{
				componentInChildren.SetTrigger(trigger);
			}
			else
			{
				UnityEngine.Object.Destroy(item);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003505")]
		[Cpp2IlInjected.Address(RVA = "0x11BED00", Offset = "0x11BD700", VA = "0x1811BED00")]
		public Scope BlockMinigame()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003506")]
		[Cpp2IlInjected.Address(RVA = "0x11BF590", Offset = "0x11BDF90", VA = "0x1811BF590")]
		public ItemCollectMinigame()
		{
		}
	}
}
