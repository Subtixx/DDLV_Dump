using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Scene;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x200090F")]
	public class CritterManager : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003270")]
		[SerializeField]
		private float _minimumSecondsBeforeRespawnAfterFlight = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4003271")]
		[SerializeField]
		private float _maximumSecondsBeforeRespawnAfterFlight = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003272")]
		[SerializeField]
		private AssetReference happyVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003273")]
		[SerializeField]
		private AssetReference itemVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003274")]
		[SerializeField]
		private AK.Wwise.Event giveItemToCritterSucceededSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003275")]
		[SerializeField]
		private AK.Wwise.Event giveItemToCritterFailedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003277")]
		private Dictionary<VillageAreaType, Transform> crittersAreaParents = (Dictionary<VillageAreaType, Transform>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003278")]
		private Dictionary<CritterItemData, Critter> loadedCritters = (Dictionary<CritterItemData, Critter>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003279")]
		private CritterItemData[] critterItemDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400327A")]
		private CancellationTokenProvider cancellationTokenProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400327B")]
		private VillageEnvironment villageEnvironment;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400327C")]
		private VillageArea currentVillageArea;

		[Cpp2IlInjected.Token(Token = "0x1400005F")]
		public event EventHandler<Critter> OnCritterLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60029AF")]
			[Cpp2IlInjected.Address(RVA = "0x11022B0", Offset = "0x1100CB0", VA = "0x1811022B0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60029B0")]
			[Cpp2IlInjected.Address(RVA = "0x1102350", Offset = "0x1100D50", VA = "0x181102350")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029B1")]
		[Cpp2IlInjected.Address(RVA = "0x1102020", Offset = "0x1100A20", VA = "0x181102020")]
		public void UpdateState()
		{
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			if ((long)PlayerNavigation.s_actuallyMoveAvatar != 0)
			{
				bool isPaused = system.IsPaused;
			}
			int num = 0;
			bool flag = !base.IsPaused;
			if (num != (flag ? 1 : 0))
			{
				if (num != 0)
				{
					ResumeSystem();
					throw new NullReferenceException();
				}
				PauseSystem();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029B2")]
		[Cpp2IlInjected.Address(RVA = "0x11008A0", Offset = "0x10FF2A0", VA = "0x1811008A0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0095, IL_0102, IL_0108, IL_010e, IL_0114, IL_011a, IL_0120, IL_0126, IL_012c
			int num = 0;
			int num2 = 0;
			CancellationTokenProvider cancellationTokenProvider = (this.cancellationTokenProvider = this.GetOrAddComponent<CancellationTokenProvider>());
			IEnumerator enumerator = Enum.GetValues(typeof(VillageAreaType)).GetEnumerator();
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				IEnumerator enumerator2 = enumerator;
				GameObject gameObject = new GameObject();
				string text = gameObject.ToString();
				GameObject gameObject2 = gameObject;
				gameObject.name = text;
				Transform transform = gameObject.transform;
				Transform transform3 = (transform.parent = base.transform);
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				Dictionary<VillageAreaType, Transform> dictionary = crittersAreaParents;
				Transform transform4 = gameObject.transform;
				throw new NullReferenceException();
			}
			NullReferenceException ex = default(NullReferenceException);
			if (ex != null)
			{
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> cpp2il__autoParamName__idx_ = default(IEnumerable<>);
			CritterItemData[] array = cpp2il__autoParamName__idx_.ToArray<CritterItemData>();
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject3 = default(GameObject);
			VillageEnvironment component = gameObject3.GetComponent<VillageEnvironment>();
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			Task asyncTask2 = default(Task);
			asyncTask2.FireAndForgetTask();
			ProfileEventDispatcher.VillageAreaUnlocked value = default(ProfileEventDispatcher.VillageAreaUnlocked);
			SystemRoot.Instance.MetaClient.Dispatcher.OnVillageAreaUnlocked += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60029B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60029B4")]
		[Cpp2IlInjected.Address(RVA = "0x11007E0", Offset = "0x10FF1E0", VA = "0x1811007E0", Slot = "7")]
		public override void OnSystemResume()
		{
			//Discarded unreachable code: IL_0031
			CancellationToken activeCancellationToken = cancellationTokenProvider.ActiveCancellationToken;
			UpdateLoadedCrittersLoop(activeCancellationToken).FireAndForgetTask();
			CancellationToken activeCancellationToken2 = cancellationTokenProvider.ActiveCancellationToken;
			UpdateEnabledCritters(activeCancellationToken2).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60029B5")]
		[Cpp2IlInjected.Address(RVA = "0x1100F60", Offset = "0x10FF960", VA = "0x181100F60", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0037
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.VillageAreaUnlocked value = OnVillageAreaUnlocked;
				_003CDispatcher_003Ek__BackingField.OnVillageAreaUnlocked -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029B6")]
		[Cpp2IlInjected.Address(RVA = "0x1100770", Offset = "0x10FF170", VA = "0x181100770")]
		[IteratorStateMachine(typeof(_003CGetActiveCritters_003Ed__20))]
		public IEnumerable<Critter> GetActiveCritters()
		{
			new _003CGetActiveCritters_003Ed__20(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029B7")]
		[Cpp2IlInjected.Address(RVA = "0x1101F00", Offset = "0x1100900", VA = "0x181101F00")]
		[AsyncStateMachine(typeof(_003CUpdateLoadedCritters_003Ed__21))]
		private Task UpdateLoadedCritters(CancellationToken ct, [System.Runtime.InteropServices.Optional] VillageAreaType? forceVillageAreaType)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029B8")]
		[Cpp2IlInjected.Address(RVA = "0x1101DE0", Offset = "0x11007E0", VA = "0x181101DE0")]
		[AsyncStateMachine(typeof(_003CUpdateLoadedCrittersLoop_003Ed__22))]
		private Task UpdateLoadedCrittersLoop(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029B9")]
		[Cpp2IlInjected.Address(RVA = "0x1101CB0", Offset = "0x11006B0", VA = "0x181101CB0")]
		[AsyncStateMachine(typeof(_003CUpdateEnabledCritters_003Ed__23))]
		private Task UpdateEnabledCritters(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029BA")]
		[Cpp2IlInjected.Address(RVA = "0x1100660", Offset = "0x10FF060", VA = "0x181100660")]
		[AsyncStateMachine(typeof(_003CFeedCritterFlow_003Ed__24))]
		public Task FeedCritterFlow(Critter critter)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029BB")]
		[Cpp2IlInjected.Address(RVA = "0x1101300", Offset = "0x10FFD00", VA = "0x181101300")]
		[AsyncStateMachine(typeof(_003CPlayReactionAnimation_003Ed__25))]
		private Task PlayReactionAnimation(Critter critter, CancellationTokenSource cts, FeedCritter.Types.CritterReaction reaction)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029BC")]
		[Cpp2IlInjected.Address(RVA = "0x1101450", Offset = "0x10FFE50", VA = "0x181101450")]
		[AsyncStateMachine(typeof(_003CSpawnItemGameObject_003Ed__26))]
		private Task<(GameObject, GameObject)> SpawnItemGameObject(Item item, Critter critter)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(GameObject, GameObject)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029BD")]
		[Cpp2IlInjected.Address(RVA = "0x1101140", Offset = "0x10FFB40", VA = "0x181101140")]
		private void OnVillageAreaUnlocked(VillageAreaType areaType, [System.Runtime.InteropServices.Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_001d
			CancellationToken cancellationToken = cancellationTokenProvider.CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60029BE")]
		[Cpp2IlInjected.Address(RVA = "0x11015A0", Offset = "0x10FFFA0", VA = "0x1811015A0")]
		[AsyncStateMachine(typeof(_003CStartHappyVFX_003Ed__28))]
		private Task StartHappyVFX(Transform transform)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029BF")]
		[Cpp2IlInjected.Address(RVA = "0x11016D0", Offset = "0x11000D0", VA = "0x1811016D0")]
		[AsyncStateMachine(typeof(_003CStartItemVFX_003Ed__29))]
		private Task StartItemVFX(Transform transform)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029C0")]
		[Cpp2IlInjected.Address(RVA = "0x11021E0", Offset = "0x1100BE0", VA = "0x1811021E0")]
		public CritterManager()
		{
		}
	}
}
