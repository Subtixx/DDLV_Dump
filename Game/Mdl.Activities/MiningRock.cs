using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Scene;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B7E")]
	public class MiningRock : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003FE2")]
		[SerializeField]
		private GameObject _emptyVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003FE3")]
		[SerializeField]
		private GameObject _fullVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003FE4")]
		[SerializeField]
		private GameObject _specialVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003FE5")]
		[SerializeField]
		private Animation _specialAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003FE6")]
		private Renderer[] specialGemRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003FE7")]
		[SerializeField]
		private RewardSpawnAnimationData _rewardSpawnAnimationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003FE8")]
		[SerializeField]
		private GameObject _rockDestroyedVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003FE9")]
		[SerializeField]
		private AK.Wwise.Event _destroyedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003FEA")]
		[SerializeField]
		private GameObject _rockRespawnedVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003FEB")]
		[SerializeField]
		private float _rockRespawnAfterVFXDelayInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003FEC")]
		[SerializeField]
		private GameObject _rockSpecialRevealVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003FED")]
		[SerializeField]
		private AK.Wwise.Event _specialSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003FEE")]
		[SerializeField]
		private GameObject _rockHitVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003FEF")]
		public GameObject audioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003FF0")]
		private AudioEmitterCullingManager cullingScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003FF2")]
		private ActivityDataLocationFilter location = new ActivityDataLocationFilter();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003FF3")]
		private CancellationTokenSource stateCTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003FF4")]
		private Meta.MiningRock.StateOneofCase? currentVisualState;

		[Cpp2IlInjected.Token(Token = "0x17000735")]
		internal RewardSpawnAnimationData RewardSpawnAnimationData
		{
			[Cpp2IlInjected.Token(Token = "0x6003535")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _rewardSpawnAnimationData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000736")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x90"), Cpp2IlInjected.Token(Token = "0x4003FF1")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6003536")]
			[Cpp2IlInjected.Address(RVA = "0x725190", Offset = "0x723B90", VA = "0x180725190")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003537")]
			[Cpp2IlInjected.Address(RVA = "0x725370", Offset = "0x723D70", VA = "0x180725370")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000737")]
		public ActivityDataLocationFilter Location
		{
			[Cpp2IlInjected.Token(Token = "0x6003538")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return location;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000738")]
		public unsafe Meta.MiningRock Data
		{
			[Cpp2IlInjected.Token(Token = "0x6003539")]
			[Cpp2IlInjected.Address(RVA = "0xBC7BF0", Offset = "0xBC65F0", VA = "0x180BC7BF0")]
			get
			{
				//Discarded unreachable code: IL_00ea
				//IL_009c: Expected O, but got I4
				//IL_00d9: Expected O, but got I4
				int num = 0;
				ActivityDataLocationFilter.LocationTypeOneofCase locationTypeCase_ = location.locationTypeCase_;
				if (locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea)
				{
					goto IL_009f;
				}
				OffGridBuildingItemData offGridBuildingItemData;
				if (locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.Scene)
				{
					Func<OffGridBuildingItemData, bool> func = (Func<OffGridBuildingItemData, bool>)(object)(Func<T, TResult>)delegate(OffGridBuildingItemData x)
					{
						Item sceneItem = x.SceneItem;
						int scene2 = location.Scene;
						throw new NullReferenceException();
					};
					IEnumerable<> enumerable = default(IEnumerable<>);
					offGridBuildingItemData = Enumerable.FirstOrDefault<OffGridBuildingItemData>(enumerable, (Func<, >)(object)func);
					if (offGridBuildingItemData != null)
					{
						goto IL_0076;
					}
					bool flag = default(bool);
					if (flag)
					{
						Predicate<WorldData.Types.World> predicate = (Predicate<WorldData.Types.World>)(object)(Predicate<T>)delegate(WorldData.Types.World x)
						{
							//Discarded unreachable code: IL_001a
							ActivityDataLocationFilter activityDataLocationFilter2 = location;
							int sceneId_ = x.sceneId_;
							int scene = activityDataLocationFilter2.Scene;
							return sceneId_ == scene;
						};
						Client client = default(Client);
						MapField<string, Realm> realms_ = client.profile.world_.realms_;
						WorldData.Types.World world = default(WorldData.Types.World);
						string worldName_ = world.worldName_;
						if (((MapField<TKey, TValue>)(object)realms_).TryGetValue((TKey)worldName_, out *(TValue*)num))
						{
							goto IL_0076;
						}
					}
				}
				goto IL_00dc;
				IL_0076:
				Client client2 = default(Client);
				MapField<int, OffGridBuilding> offGridBuildings_ = client2.profile.world_.offGridBuildings_;
				int iD_ = offGridBuildingItemData.iD_;
				if (((MapField<TKey, TValue>)(object)offGridBuildings_).TryGetValue((TKey)iD_, out *(TValue*)num))
				{
					goto IL_009f;
				}
				goto IL_00dc;
				IL_009f:
				Village village = SystemRoot.Instance.MetaClient.profile.Village;
				ActivityDataLocationFilter activityDataLocationFilter = location;
				MapField<int, Village.Types.VillageArea> areas_ = village.areas_;
				int villageArea = (int)activityDataLocationFilter.VillageArea;
				if (!((MapField<TKey, TValue>)(object)areas_).TryGetValue((TKey)villageArea, out *(TValue*)num))
				{
					goto IL_00dc;
				}
				goto IL_00df;
				IL_00dc:
				int num2 = 0;
				goto IL_00df;
				IL_00df:
				int num3 = Index;
				Meta.MiningRock result = default(Meta.MiningRock);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600353A")]
		[Cpp2IlInjected.Address(RVA = "0xBC7480", Offset = "0xBC5E80", VA = "0x180BC7480")]
		private void Start()
		{
			//Discarded unreachable code: IL_0090
			//IL_0023: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			AudioEmitterCullingManager audioEmitterCullingManager = (cullingScript = audioEmitter.GetComponent<AudioEmitterCullingManager>());
			GameObject specialVisual = _specialVisual;
			int num = 0;
			if (specialVisual != (UnityEngine.Object)num)
			{
				Renderer[] array = (specialGemRenderers = _specialVisual.GetComponentsInChildren<Renderer>());
			}
			Mdl.Environments.Environment componentInParent = GetComponentInParent<Mdl.Environments.Environment>();
			int num2 = 0;
			if (componentInParent != (UnityEngine.Object)num2)
			{
				EventHandler value = OnEnvironmentEntered;
				componentInParent.EnvironmentEnteredEvent += value;
			}
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.MiningRockStateChanged value2 = OnMiningRockStateChanged;
			_003CDispatcher_003Ek__BackingField.OnMiningRockStateChanged += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x600353B")]
		[Cpp2IlInjected.Address(RVA = "0xBC6D20", Offset = "0xBC5720", VA = "0x180BC6D20")]
		private void OnEnvironmentEntered(object sender, EventArgs e)
		{
			//IL_002e: Expected O, but got I4
			if (sender == null)
			{
			}
			int num = 0;
			if (sender != null)
			{
				EventHandler eventHandler = OnEnvironmentEntered;
				int num2 = 0;
				VillageArea componentInParent = GetComponentInParent<VillageArea>();
				int num3 = 0;
				if (!(componentInParent != (UnityEngine.Object)num3))
				{
					int num4 = 0;
					if (sender == null)
					{
						int num5 = 0;
						if (sender == null)
						{
							goto IL_00ab;
						}
					}
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Func<SceneItemData, bool> func = default(Func<SceneItemData, bool>);
					if (_003C_003Ec._003C_003E9__29_0 == null)
					{
						func = (Func<SceneItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_000d
							SceneStack sceneStack = SystemRoot.Instance._sceneStack;
							bool result = default(bool);
							return result;
						});
					}
					IEnumerable<> enumerable = default(IEnumerable<>);
					SceneItemData sceneItemData = Enumerable.FirstOrDefault<SceneItemData>(enumerable, (Func<, >)(object)func);
					if (sceneItemData == null)
					{
						goto IL_00ab;
					}
					ActivityDataLocationFilter activityDataLocationFilter = location;
					int num6 = (activityDataLocationFilter.Scene = sceneItemData.iD_);
				}
				ActivityDataLocationFilter activityDataLocationFilter2 = location;
				MiningRockIndexDistributor miningRockIndexDistributor = default(MiningRockIndexDistributor);
				int num7 = (Index = miningRockIndexDistributor.GetIndex(this));
				goto IL_00ab;
			}
			throw new InvalidCastException();
			IL_00ab:
			Meta.MiningRock data = Data;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			int state = (int)data.GetState(_003CTransactionContext_003Ek__BackingField);
			CancellationTokenSource cancellationTokenSource = (stateCTS = new CancellationTokenSource());
			CancellationToken token = stateCTS.Token;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			if (state == 0)
			{
				CancellationToken token2 = stateCTS.Token;
				WaitForRefillTimer(token2).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600353C")]
		[Cpp2IlInjected.Address(RVA = "0xBC6A60", Offset = "0xBC5460", VA = "0x180BC6A60")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_007e
			//IL_0063: Expected O, but got I4
			if ((long)stateCTS != 0)
			{
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.MiningRockStateChanged value = OnMiningRockStateChanged;
					_003CDispatcher_003Ek__BackingField.OnMiningRockStateChanged -= value;
				}
			}
			Mdl.Environments.Environment componentInParent = GetComponentInParent<Mdl.Environments.Environment>();
			int num = 0;
			if (componentInParent != (UnityEngine.Object)num)
			{
				EventHandler value2 = OnEnvironmentEntered;
				componentInParent.EnvironmentEnteredEvent -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600353D")]
		[Cpp2IlInjected.Address(RVA = "0xBC72F0", Offset = "0xBC5CF0", VA = "0x180BC72F0")]
		internal void OnMiningRockHit()
		{
			//IL_0010: Expected O, but got I4
			GameObject rockHitVFXPrefab = _rockHitVFXPrefab;
			int num = 0;
			if (rockHitVFXPrefab != (UnityEngine.Object)num)
			{
				GameObject rockHitVFXPrefab2 = _rockHitVFXPrefab;
				Transform parent = base.transform;
				GameObject gameObject = UnityEngine.Object.Instantiate(rockHitVFXPrefab2, parent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600353E")]
		[Cpp2IlInjected.Address(RVA = "0xBC73B0", Offset = "0xBC5DB0", VA = "0x180BC73B0")]
		private void OnMiningRockStateChanged(ActivityDataLocationFilter location, int index, Meta.MiningRock.StateOneofCase state)
		{
			//Discarded unreachable code: IL_0048
			int num = (int)state;
			ActivityDataLocationFilter.LocationTypeOneofCase locationTypeCase_ = location.locationTypeCase_;
			if (locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea)
			{
				VillageAreaType villageArea = this.location.VillageArea;
				VillageAreaType villageArea2 = location.VillageArea;
			}
			if (locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.Scene)
			{
				num = this.location.Scene;
				int scene = location.Scene;
				if (num == scene && Index != index)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600353F")]
		[Cpp2IlInjected.Address(RVA = "0xBC7920", Offset = "0xBC6320", VA = "0x180BC7920")]
		[AsyncStateMachine(typeof(_003CUpdateVisual_003Ed__33))]
		private Task UpdateVisual(Meta.MiningRock.StateOneofCase state, CancellationToken ct, bool isRespawnNeeded = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003540")]
		[Cpp2IlInjected.Address(RVA = "0xBC7A60", Offset = "0xBC6460", VA = "0x180BC7A60")]
		[AsyncStateMachine(typeof(_003CWaitForRefillTimer_003Ed__34))]
		private Task WaitForRefillTimer(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003541")]
		[Cpp2IlInjected.Address(RVA = "0xBC7B80", Offset = "0xBC6580", VA = "0x180BC7B80")]
		public MiningRock()
		{
		}
	}
}
