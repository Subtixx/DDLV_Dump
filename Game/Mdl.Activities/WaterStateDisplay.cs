using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B66")]
	public class WaterStateDisplay : MonoBehaviour, IPlayerTaskUIInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003F56")]
		public GameObject WateredEffectPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003F57")]
		public GameObject DryingEffectPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003F58")]
		public GameObject DyingEffectPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003F59")]
		private WateringState? currentWateringState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003F5A")]
		public GameObject AliveVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003F5B")]
		public Material WateredMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003F5C")]
		public Material DryingMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003F5D")]
		public Material DyingMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003F5F")]
		private Renderer[] _renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003F60")]
		private GardeningData gardeningData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003F61")]
		private GardenData.Types.GardeningSlot gardeningSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003F62")]
		private bool inVillage;

		[Cpp2IlInjected.Token(Token = "0x1700072A")]
		public GameObject PlantAudioEmitter
		{
			[Cpp2IlInjected.Token(Token = "0x60034C1")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CPlantAudioEmitter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60034C2")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CPlantAudioEmitter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072B")]
		public Renderer[] Renderers
		{
			[Cpp2IlInjected.Token(Token = "0x60034C3")]
			[Cpp2IlInjected.Address(RVA = "0xD4F690", Offset = "0xD4E090", VA = "0x180D4F690")]
			get
			{
				//Discarded unreachable code: IL_0038
				//IL_001b: Expected O, but got I4
				if ((long)_renderers == 0)
				{
					GameObject aliveVisual = AliveVisual;
					int num = 0;
					if (aliveVisual != (UnityEngine.Object)num)
					{
						Renderer[] array = (_renderers = AliveVisual.GetComponentsInChildren<Renderer>());
					}
				}
				return _renderers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072C")]
		public bool ShouldDisplayInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60034C4")]
			[Cpp2IlInjected.Address(RVA = "0xD4F750", Offset = "0xD4E150", VA = "0x180D4F750", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034C5")]
		[Cpp2IlInjected.Address(RVA = "0xD4EE40", Offset = "0xD4D840", VA = "0x180D4EE40")]
		private void Start()
		{
			//IL_002b: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			int handle = base.gameObject.scene.m_Handle;
			GameObject gameObject = default(GameObject);
			VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
			int num = 0;
			bool flag = (inVillage = component != (UnityEngine.Object)num);
			if ((object)base.gameObject.GetComponentInParent<GardeningSlot>() != null)
			{
			}
			int num2 = 0;
			PlantAudioEmitter = (GameObject)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034C6")]
		[Cpp2IlInjected.Address(RVA = "0xD4ED40", Offset = "0xD4D740", VA = "0x180D4ED40")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_001f
			VFXPoolSystem system = SystemRoot.Instance.GetSystem<VFXPoolSystem>();
			Transform parent = base.gameObject.transform;
			system.EndEffects(parent);
		}

		[Cpp2IlInjected.Token(Token = "0x60034C7")]
		[Cpp2IlInjected.Address(RVA = "0xD4E390", Offset = "0xD4CD90", VA = "0x180D4E390")]
		public (WateringState, float) GetWateringStateAndRatio()
		{
			//IL_0099: Expected O, but got I4
			GardenData.Types.GardeningSlot gardeningSlot = this.gardeningSlot;
			int num = 0;
			if (gardeningSlot != null)
			{
				SaplingGrowthData sapling = gardeningSlot.Sapling;
				GardenData.Types.GardeningSlot gardeningSlot2 = this.gardeningSlot;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item plantedSeedItem = gardeningSlot2.PlantedSeedItem;
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				Client metaClient = SystemRoot.Instance.MetaClient;
				bool flag = inVillage;
				WateringState wateringState = default(WateringState);
				int num2 = (int)wateringState;
				if (wateringState != 0 && (wateringState == WateringState.Watered || num2 == 1))
				{
					Client client = default(Client);
					DateTime serverTime = client.ServerTime;
					DateTime dateTime = this.gardeningSlot.Sapling.lastWateringDate_.ToDateTime();
					TimeSpan timeSpan = serverTime - dateTime - (TimeSpan)num;
					TimeSpan timeSpan2 = gardeningData.dryingDuration_.ToTimeSpan();
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034C8")]
		[Cpp2IlInjected.Address(RVA = "0xD4E810", Offset = "0xD4D210", VA = "0x180D4E810")]
		public void Init(GardenData.Types.GardeningSlot gardeningSlot, CancellationToken ct)
		{
			this.gardeningSlot = gardeningSlot;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item plantedSeedItem = gardeningSlot.PlantedSeedItem;
			SeedItemData seedItemData = default(SeedItemData);
			if (!seedItemData.NeedWatering)
			{
				int wateringState = 0;
				UpdateVisual((WateringState)wateringState);
				return;
			}
			SaplingGrowthData sapling = gardeningSlot.Sapling;
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			Client metaClient = SystemRoot.Instance.MetaClient;
			bool flag = inVillage;
			int num = 0;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = metaClient.TransactionContext;
			WateringState wateringState2 = sapling.GetWateringState(seedItemData, world_, _003CTransactionContext_003Ek__BackingField, flag);
			SaplingGrowthData sapling2 = gardeningSlot.Sapling;
			ProfileWorld world_2 = SystemRoot.Instance.MetaClient.profile.world_;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool flag2 = inVillage;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField2 = metaClient2.TransactionContext;
			DateTime nextStateTimestamp = sapling2.GetNextStateTimestamp(seedItemData, world_2, _003CTransactionContext_003Ek__BackingField2, flag2);
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034C9")]
		[Cpp2IlInjected.Address(RVA = "0xD4F550", Offset = "0xD4DF50", VA = "0x180D4F550")]
		[AsyncStateMachine(typeof(_003CWaitForWateringStateChange_003Ed__24))]
		private Task WaitForWateringStateChange(DateTime nextStateTime, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034CA")]
		[Cpp2IlInjected.Address(RVA = "0xD4F0B0", Offset = "0xD4DAB0", VA = "0x180D4F0B0")]
		public unsafe void UpdateVisual(WateringState wateringState)
		{
			//IL_0036: Expected O, but got I8
			//IL_0051: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_0092: Expected I4, but got I8
			//IL_00ce: Expected O, but got I4
			WateringState? wateringState2 = currentWateringState;
			if ((IntPtr)(((IntPtr)(void*)(int)wateringState == (IntPtr)(void*)wateringState2) ? 1 : 0) == (IntPtr)(void*)wateringState2)
			{
				VFXPoolSystem system = SystemRoot.Instance.GetSystem<VFXPoolSystem>();
				Transform parent = base.gameObject.transform;
				system.EndEffects(parent);
				ulong num = default(ulong);
				currentWateringState = (WateringState?)(object)num;
				if (wateringState != 0)
				{
					Renderer[] array = default(Renderer[]);
					if ((long)array == 1)
					{
						bool flag = default(bool);
						while (!flag)
						{
						}
					}
					while ((long)array != 2)
					{
					}
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					goto IL_0100;
				}
				GameObject wateredEffectPrefab = WateredEffectPrefab;
				int num2 = 0;
				if (wateredEffectPrefab != (UnityEngine.Object)num2)
				{
					GameObject wateredEffectPrefab2 = WateredEffectPrefab;
					Transform parent2 = base.transform;
					system.RequestEffect(wateredEffectPrefab2, parent2);
				}
			}
			GameObject aliveVisual = AliveVisual;
			int num3 = 0;
			if (!(aliveVisual != (UnityEngine.Object)num3))
			{
				return;
			}
			ulong num4 = default(ulong);
			AliveVisual.SetActive((byte)num4 != 0);
			if (!AliveVisual.activeSelf || Renderers.Length == 0)
			{
				return;
			}
			if (wateringState != 0)
			{
				if (wateringState != 0 && wateringState == WateringState.Drying)
				{
					Material dyingMaterial = DyingMaterial;
					int num5 = 0;
					if (dyingMaterial != (UnityEngine.Object)num5)
					{
						Renderer[] array = Renderers;
						Action<Renderer> action = (Action<Renderer>)(object)(Action<T>)delegate(Renderer renderer)
						{
							//Discarded unreachable code: IL_000f
							Material dyingMaterial2 = DyingMaterial;
							renderer.SetMaterial(dyingMaterial2);
						};
					}
					return;
				}
				goto IL_0100;
			}
			goto IL_0105;
			IL_0100:
			bool flag3 = default(bool);
			while (!flag3)
			{
			}
			goto IL_0105;
			IL_0105:
			bool flag4 = default(bool);
			while (!flag4)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034CB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WaterStateDisplay()
		{
		}
	}
}
