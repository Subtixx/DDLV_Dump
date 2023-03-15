using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B60")]
	public class GardeningSlot : GridObjectStateUser, IDefaultGridStateProvider, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003F38")]
		[SerializeField]
		private int _slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003F39")]
		public AK.Wwise.Event sfxSaplingEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003F3A")]
		public AK.Wwise.Event sfxGrowEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003F3B")]
		public GameObject audioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003F3C")]
		private AudioEmitterCullingManager cullingScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003F3D")]
		public GameObject SpawnVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003F3F")]
		private GameObject visual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003F40")]
		private GardenData.Types.GardeningSlot currentSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003F41")]
		private bool inVillage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003F42")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x17000724")]
		public int SlotIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600349D")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return _slotIndex;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000725")]
		public Garden Garden
		{
			[Cpp2IlInjected.Token(Token = "0x600349E")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CGarden_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600349F")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			private set
			{
				_003CGarden_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000726")]
		public Item PlantedSeedItem
		{
			[Cpp2IlInjected.Token(Token = "0x60034A0")]
			[Cpp2IlInjected.Address(RVA = "0x8C9490", Offset = "0x8C7E90", VA = "0x1808C9490")]
			get
			{
				return currentSlot?.PlantedSeedItem ?? Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000727")]
		public bool IsProductionReady
		{
			[Cpp2IlInjected.Token(Token = "0x60034A1")]
			[Cpp2IlInjected.Address(RVA = "0x8C9230", Offset = "0x8C7C30", VA = "0x1808C9230")]
			get
			{
				//IL_0060: Expected O, but got I4
				GardenData.Types.GardeningSlot gardeningSlot = currentSlot;
				if (gardeningSlot != null && gardeningSlot.Harvest != null)
				{
					TreeAndBushData harvest = currentSlot.Harvest;
					ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
					Client metaClient = SystemRoot.Instance.MetaClient;
					bool flag = inVillage;
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = metaClient.TransactionContext;
					int num = 0;
					DateTime endOfGrowthTime = harvest.GetEndOfGrowthTime((SeedItemData)num, world_, _003CTransactionContext_003Ek__BackingField, flag);
					DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
					return endOfGrowthTime <= serverTime;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000728")]
		public bool CanBeHarvested
		{
			[Cpp2IlInjected.Token(Token = "0x60034A2")]
			[Cpp2IlInjected.Address(RVA = "0x8C90B0", Offset = "0x8C7AB0", VA = "0x1808C90B0")]
			get
			{
				if (IsProductionReady)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					GardenData.Types.GardeningSlot gardeningSlot = currentSlot;
					if (gardeningSlot != null)
					{
						Item plantedSeedItem = gardeningSlot.PlantedSeedItem;
					}
					Item invalid = Item.Invalid;
					SeedItemData seedItemData = default(SeedItemData);
					if (!seedItemData.IsMissionItem())
					{
						return true;
					}
					return !seedItemData.missionSeedBlockHarvest_;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000729")]
		public TimerType TimerType
		{
			[Cpp2IlInjected.Token(Token = "0x60034A3")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000094")]
		public event EventHandler GardeningSlotStateChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60034A4")]
			[Cpp2IlInjected.Address(RVA = "0x8C9010", Offset = "0x8C7A10", VA = "0x1808C9010")]
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
			[Cpp2IlInjected.Token(Token = "0x60034A5")]
			[Cpp2IlInjected.Address(RVA = "0x8C9510", Offset = "0x8C7F10", VA = "0x1808C9510")]
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

		[Cpp2IlInjected.Token(Token = "0x60034A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C8EC0", Offset = "0x8C78C0", VA = "0x1808C8EC0", Slot = "5")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_0057
			//IL_0046: Expected O, but got I4
			AudioEmitterCullingManager audioEmitterCullingManager = (cullingScript = audioEmitter.GetComponent<AudioEmitterCullingManager>());
			Garden garden = (Garden = GetComponentInParent<Garden>());
			int handle = base.gameObject.scene.m_Handle;
			GameObject gameObject = default(GameObject);
			VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
			int num = 0;
			bool flag = (inVillage = component != (UnityEngine.Object)num);
			base.Start();
		}

		[Cpp2IlInjected.Token(Token = "0x60034A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E60", Offset = "0x8C7860", VA = "0x1808C8E60", Slot = "6")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_002c
			//IL_002b: Expected O, but got I8
			base.OnDestroy();
			CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				this.cancellationTokenSource.Dispose();
				this.cancellationTokenSource = (CancellationTokenSource)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C8970", Offset = "0x8C7370", VA = "0x1808C8970", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_00d9
			if (gridObject == null)
			{
				return;
			}
			GridState state_ = gridObject.state_;
			if (state_ == null || state_.GardenData == null)
			{
				return;
			}
			RepeatedField<GardenData.Types.GardeningSlot> slots_ = gridObject.state_.GardenData.slots_;
			if (((RepeatedField<T>)(object)slots_).Count <= _slotIndex)
			{
				return;
			}
			GardenData.Types.GardeningSlot gardeningSlot = currentSlot;
			if (gardeningSlot != null)
			{
				RepeatedField<GardenData.Types.GardeningSlot> slots_2 = gridObject.state_.GardenData.slots_;
				int slotIndex = _slotIndex;
				GardenData.Types.GardeningSlot other = (GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_2)[slotIndex];
				if (gardeningSlot.Equals(other))
				{
					return;
				}
			}
			if (slots_ != null)
			{
			}
			CancellationTokenSource cancellationTokenSource = (this.cancellationTokenSource = new CancellationTokenSource());
			RepeatedField<GardenData.Types.GardeningSlot> slots_3 = gridObject.state_.GardenData.slots_;
			int slotIndex2 = _slotIndex;
			GardenData.Types.GardeningSlot gardeningSlot2 = (GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_3)[slotIndex2];
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			GardenData.Types.GardeningSlot gardeningSlot3 = (currentSlot = gardeningSlot2.Clone());
			if (this.GardeningSlotStateChangedEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D20", Offset = "0x8C7720", VA = "0x1808C8D20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__30))]
		private Task Init(GardenData.Types.GardeningSlot slot, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C8570", Offset = "0x8C6F70", VA = "0x1808C8570")]
		public TimeSpan GetRemainingTime()
		{
			if (currentSlot.Sapling != null)
			{
				GardenData.Types.GardeningSlot gardeningSlot = currentSlot;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item plantedSeedItem = gardeningSlot.PlantedSeedItem;
			}
			GardenData.Types.GardeningSlot gardeningSlot2 = currentSlot;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Client metaClient = SystemRoot.Instance.MetaClient;
			bool flag = inVillage;
			DateTime maxValue = DateTime.MaxValue;
			DateTime dateTime = default(DateTime);
			if (!(dateTime == maxValue))
			{
				DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
				return dateTime - serverTime;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		void IDefaultGridStateProvider.InitFromGridState(GridState gridState)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034AC")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "9")]
		bool IDefaultGridStateProvider.ForceGridState(ref GridState gridState, ITransactionContext context)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
		void IDefaultGridStateProvider.ChangeGridState(GridState gridState, ITransactionContext context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public GardeningSlot()
		{
		}
	}
}
