using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Streaming;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using Meta.Util;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000478")]
	[ExecuteInEditMode]
	public class GridScript : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000479")]
		public struct DisableResolveScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001C6B")]
			private readonly GridScript grid;

			[Cpp2IlInjected.Token(Token = "0x60013F4")]
			[Cpp2IlInjected.Address(RVA = "0x184BF90", Offset = "0x184A990", VA = "0x18184BF90")]
			public DisableResolveScope(GridScript grid)
			{
				//Discarded unreachable code: IL_000e
				this.grid = grid;
				grid.BeginDisableResolve();
			}

			[Cpp2IlInjected.Token(Token = "0x60013F5")]
			[Cpp2IlInjected.Address(RVA = "0x184BF70", Offset = "0x184A970", VA = "0x18184BF70", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.Token(Token = "0x4001C59")]
		public const float TileSize = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C5A")]
		[SerializeField]
		private Transform _gridOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C5B")]
		[SerializeField]
		private DistanceCullingManager distanceCullingManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001C5C")]
		[HideInInspector]
		public string GridDataPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001C5D")]
		public GameObject VisualGrid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001C5E")]
		[SerializeField]
		[ItemID]
		private int _lockedConditionItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001C60")]
		private HashSet<uint> gridObjects = (HashSet<uint>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001C62")]
		private HashSet<uint> editGridObjects = (HashSet<uint>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001C64")]
		private OrphanHandleContainer _orphanHandleContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001C69")]
		private bool resolveDisabled;

		[Cpp2IlInjected.Token(Token = "0x4001C6A")]
		private static readonly ProfilerMarker s_getGridObjectScript;

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		public Transform GridOrigin
		{
			[Cpp2IlInjected.Token(Token = "0x600139A")]
			[Cpp2IlInjected.Address(RVA = "0x1542260", Offset = "0x1540C60", VA = "0x181542260")]
			get
			{
				//IL_0010: Expected O, but got I4
				Transform gridOrigin = _gridOrigin;
				int num = 0;
				if (gridOrigin != (UnityEngine.Object)num)
				{
					return _gridOrigin;
				}
				return base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		public bool HasDistanceCulling
		{
			[Cpp2IlInjected.Token(Token = "0x600139B")]
			[Cpp2IlInjected.Address(RVA = "0x1542460", Offset = "0x1540E60", VA = "0x181542460")]
			get
			{
				//IL_0010: Expected O, but got I4
				DistanceCullingManager distanceCullingManager = this.distanceCullingManager;
				int num = 0;
				return distanceCullingManager != (UnityEngine.Object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		public bool HasAssetRefStreaming
		{
			[Cpp2IlInjected.Token(Token = "0x600139C")]
			[Cpp2IlInjected.Address(RVA = "0x15422E0", Offset = "0x1540CE0", VA = "0x1815422E0")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_0022: Expected O, but got I4
				DistanceCullingManager distanceCullingManager = this.distanceCullingManager;
				int num = 0;
				if (distanceCullingManager != (UnityEngine.Object)num)
				{
					GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
					int num2 = 0;
					if (instance != (UnityEngine.Object)num2)
					{
						List<CullingGroupStreamingManager> cullingGroupStreamingManagers = GridObjectStreamingManager._instance.CullingGroupStreamingManagers;
						int num3 = 0;
						return !DebugSettings.Settings.disableGridObjStreaming_;
					}
				}
				int num4 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		public GridData GridData
		{
			[Cpp2IlInjected.Token(Token = "0x600139F")]
			[Cpp2IlInjected.Address(RVA = "0x15421A0", Offset = "0x1540BA0", VA = "0x1815421A0")]
			get
			{
				if (Grid == null || (object)typeof(IGrid).TypeHandle == null)
				{
					Meta.Grids.Grid grid = EditGrid;
					if (grid != null)
					{
						return grid.GridData;
					}
				}
				GridData result = default(GridData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		public GridFloorType AvailableFloorTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60013A0")]
			[Cpp2IlInjected.Address(RVA = "0x1542140", Offset = "0x1540B40", VA = "0x181542140")]
			get
			{
				//Discarded unreachable code: IL_0015
				if (Grid != null)
				{
				}
				return EditGrid.AvailableFloorTypes;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		public Item LockedCondition
		{
			[Cpp2IlInjected.Token(Token = "0x60013A2")]
			[Cpp2IlInjected.Address(RVA = "0x15424D0", Offset = "0x1540ED0", VA = "0x1815424D0")]
			get
			{
				long num = Convert.ToInt64((uint)_lockedConditionItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		public uint GridID
		{
			[Cpp2IlInjected.Token(Token = "0x60013A3")]
			[Cpp2IlInjected.Address(RVA = "0x1542200", Offset = "0x1540C00", VA = "0x181542200")]
			get
			{
				//Discarded unreachable code: IL_0015
				if (Grid != null)
				{
				}
				return EditGrid.iD_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		public IGrid Grid
		{
			[Cpp2IlInjected.Token(Token = "0x60013A4")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CGrid_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013A5")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CGrid_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		public Meta.Grids.Grid EditGrid
		{
			[Cpp2IlInjected.Token(Token = "0x60013A6")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CEditGrid_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013A7")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CEditGrid_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000281")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x4001C63")]
		public uint? EditorGridID
		{
			[Cpp2IlInjected.Token(Token = "0x60013A8")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60013A9")]
			[Cpp2IlInjected.Address(RVA = "0x1542C90", Offset = "0x1541690", VA = "0x181542C90")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		public bool IsEditInit
		{
			[Cpp2IlInjected.Token(Token = "0x60013AA")]
			[Cpp2IlInjected.Address(RVA = "0x15424C0", Offset = "0x1540EC0", VA = "0x1815424C0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		public virtual bool Locked
		{
			[Cpp2IlInjected.Token(Token = "0x60013AB")]
			[Cpp2IlInjected.Address(RVA = "0x1542530", Offset = "0x1540F30", VA = "0x181542530", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_0099
				//IL_0056: Expected O, but got I4
				//IL_006d: Expected O, but got I4
				if ((long)Grid != 0)
				{
					long num = Convert.ToInt64((uint)_lockedConditionItemID);
					bool flag = default(bool);
					if (flag)
					{
						long num2 = Convert.ToInt64((uint)_lockedConditionItemID);
						bool flag2 = default(bool);
						if (flag2)
						{
							goto IL_0097;
						}
					}
					int handle = base.gameObject.scene.m_Handle;
					GameObject gameObject = default(GameObject);
					VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
					int num3 = 0;
					if (!(component == (UnityEngine.Object)num3))
					{
						VillageArea component2 = GetComponent<VillageArea>();
						int num4 = 0;
						if (!(component2 == (UnityEngine.Object)num4))
						{
							Client client = default(Client);
							ProfileWorld world_ = client.profile.world_;
							VillageAreaType areaType = component2._areaType;
							return !world_.IsVillageAreaUnlocked(areaType);
						}
					}
					int num5 = 0;
				}
				goto IL_0097;
				IL_0097:
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		internal OrphanHandleContainer OrphanHandleContainer
		{
			[Cpp2IlInjected.Token(Token = "0x60013AC")]
			[Cpp2IlInjected.Address(RVA = "0x15428B0", Offset = "0x15412B0", VA = "0x1815428B0")]
			get
			{
				bool flag = default(bool);
				if (flag)
				{
					OrphanHandleContainer orphanHandleContainer = (_orphanHandleContainer = GetComponentInParent<OrphanHandleContainer>());
					bool flag2 = default(bool);
					if (flag2)
					{
						int handle = base.gameObject.scene.m_Handle;
						GameObject gameObject = default(GameObject);
						OrphanHandleContainer orphanHandleContainer2 = (_orphanHandleContainer = gameObject.AddComponent<OrphanHandleContainer>());
					}
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000031")]
		public event EventHandler GridInitEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60013AD")]
			[Cpp2IlInjected.Address(RVA = "0x1541F60", Offset = "0x1540960", VA = "0x181541F60")]
			[CompilerGenerated]
			add
			{
				EventHandler gridInitEvent = this.GridInitEvent;
				Delegate @delegate = Delegate.Combine(gridInitEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != gridInitEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013AE")]
			[Cpp2IlInjected.Address(RVA = "0x1542AB0", Offset = "0x15414B0", VA = "0x181542AB0")]
			[CompilerGenerated]
			remove
			{
				EventHandler gridInitEvent = this.GridInitEvent;
				Delegate @delegate = Delegate.Remove(gridInitEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != gridInitEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000032")]
		public event EventHandler<NewGridObjectEventArgs> NewGridObjectAddedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60013AF")]
			[Cpp2IlInjected.Address(RVA = "0x1542000", Offset = "0x1540A00", VA = "0x181542000")]
			[CompilerGenerated]
			add
			{
				EventHandler<NewGridObjectEventArgs> newGridObjectAddedEvent = this.NewGridObjectAddedEvent;
				Delegate @delegate = Delegate.Combine(newGridObjectAddedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != newGridObjectAddedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013B0")]
			[Cpp2IlInjected.Address(RVA = "0x1542B50", Offset = "0x1541550", VA = "0x181542B50")]
			[CompilerGenerated]
			remove
			{
				EventHandler<NewGridObjectEventArgs> newGridObjectAddedEvent = this.NewGridObjectAddedEvent;
				Delegate @delegate = Delegate.Remove(newGridObjectAddedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != newGridObjectAddedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000033")]
		public event EventHandler<NewGridObjectEventArgs> NewGridObjectLoadedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60013B1")]
			[Cpp2IlInjected.Address(RVA = "0x15420A0", Offset = "0x1540AA0", VA = "0x1815420A0")]
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
			[Cpp2IlInjected.Token(Token = "0x60013B2")]
			[Cpp2IlInjected.Address(RVA = "0x1542BF0", Offset = "0x15415F0", VA = "0x181542BF0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000034")]
		public event EventHandler EditorGridChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60013B3")]
			[Cpp2IlInjected.Address(RVA = "0x1541EC0", Offset = "0x15408C0", VA = "0x181541EC0")]
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
			[Cpp2IlInjected.Token(Token = "0x60013B4")]
			[Cpp2IlInjected.Address(RVA = "0x1542A10", Offset = "0x1541410", VA = "0x181542A10")]
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

		[Cpp2IlInjected.Token(Token = "0x600139D")]
		[Cpp2IlInjected.Address(RVA = "0x153F1F0", Offset = "0x153DBF0", VA = "0x18153F1F0")]
		public static bool IsItemSupportingDistanceCulling(Item item)
		{
			ItemType itemType = default(ItemType);
			while (itemType != ItemType.Building)
			{
			}
			if (0 == 4)
			{
				FurnitureItemType furnitureItemType = default(FurnitureItemType);
				while (furnitureItemType == FurnitureItemType.GroundAlteration)
				{
				}
				return furnitureItemType != FurnitureItemType.Request;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600139E")]
		[Cpp2IlInjected.Address(RVA = "0x1540CD0", Offset = "0x153F6D0", VA = "0x181540CD0")]
		private bool ShouldUseDistanceCulling(Item item)
		{
			//IL_0017: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int itemID = item.ItemID;
			DistanceCullingManager distanceCullingManager = this.distanceCullingManager;
			int num = 0;
			if (distanceCullingManager != (UnityEngine.Object)num)
			{
				DistanceCullingManager distanceCullingManager2 = this.distanceCullingManager;
				int num2 = 0;
				if (distanceCullingManager2 != (UnityEngine.Object)num2)
				{
					GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
					int num3 = 0;
					if (instance != (UnityEngine.Object)num3)
					{
						List<CullingGroupStreamingManager> cullingGroupStreamingManagers = GridObjectStreamingManager._instance.CullingGroupStreamingManagers;
						int num4 = 0;
						if (!DebugSettings.Settings.disableGridObjStreaming_)
						{
							int num5 = 0;
							if (StreamableGridObjectDatabase.Instance.IsStreamableItem(itemID))
							{
								goto IL_00a0;
							}
						}
					}
				}
				int num6 = 0;
				if (!StreamableGridObjectDatabase.Instance.IsNonStreamableWithCarvingItem(itemID))
				{
					ItemType itemType = default(ItemType);
					switch (itemType)
					{
					case ItemType.Furniture:
					{
						FurnitureItemType furnitureItemType = default(FurnitureItemType);
						if (furnitureItemType != FurnitureItemType.GroundAlteration)
						{
							return furnitureItemType != FurnitureItemType.Request;
						}
						break;
					}
					default:
						return true;
					case ItemType.Building:
						break;
					}
				}
			}
			goto IL_00a0;
			IL_00a0:
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013A1")]
		[Cpp2IlInjected.Address(RVA = "0x153B240", Offset = "0x1539C40", VA = "0x18153B240")]
		public bool CanSupportFloorType(GridFloorType gridFloorType)
		{
			IGrid grid = Grid;
			if (grid == null)
			{
			}
			return grid.CanSupportFloorType(gridFloorType);
		}

		[Cpp2IlInjected.Token(Token = "0x60013B5")]
		[Cpp2IlInjected.Address(RVA = "0x15415B0", Offset = "0x153FFB0", VA = "0x1815415B0", Slot = "5")]
		protected virtual void Start()
		{
			//Discarded unreachable code: IL_003e
			int num = 0;
			if (Application.isPlaying)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.GridChanged value = GridOperationCompletedEvent;
				_003CDispatcher_003Ek__BackingField.OnGridChanged += value;
			}
			int num2 = 0;
			if (!DebugSettings.Settings.disableDistanceCulling_)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013B6")]
		[Cpp2IlInjected.Address(RVA = "0x153F5F0", Offset = "0x153DFF0", VA = "0x18153F5F0", Slot = "6")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_0045
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.GridChanged value = GridOperationCompletedEvent;
					_003CDispatcher_003Ek__BackingField.OnGridChanged -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013B7")]
		[Cpp2IlInjected.Address(RVA = "0x1540920", Offset = "0x153F320", VA = "0x181540920")]
		public void Sector_NewGridObjectLoadedEvent(object sender, NewGridObjectEventArgs e)
		{
			((EventHandler<TEventArgs>)(object)this.NewGridObjectLoadedEvent)?.Invoke(sender, (TEventArgs)e);
		}

		[Cpp2IlInjected.Token(Token = "0x60013B8")]
		[Cpp2IlInjected.Address(RVA = "0x153ED50", Offset = "0x153D750", VA = "0x18153ED50")]
		public Task InitFromGrid(IGrid grid)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013B9")]
		[Cpp2IlInjected.Address(RVA = "0x153EC10", Offset = "0x153D610", VA = "0x18153EC10")]
		[AsyncStateMachine(typeof(_003CInitFromGrid_003Ed__61))]
		protected Task InitFromGrid(IGrid grid, bool loadObjects)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013BA")]
		[Cpp2IlInjected.Address(RVA = "0x153F4A0", Offset = "0x153DEA0", VA = "0x18153F4A0")]
		[AsyncStateMachine(typeof(_003CLoadObject_003Ed__62))]
		private Task LoadObject(GridObject gridObject, EventHandler<NewGridObjectEventArgs> onNewGridObject, bool forEditGrid = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013BB")]
		[Cpp2IlInjected.Address(RVA = "0x153EE80", Offset = "0x153D880", VA = "0x18153EE80")]
		[AsyncStateMachine(typeof(_003CInstantiateGridObject_003Ed__63))]
		public Task<GameObject> InstantiateGridObject(GridObject gridObject)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013BC")]
		[Cpp2IlInjected.Address(RVA = "0x1541010", Offset = "0x153FA10", VA = "0x181541010")]
		public unsafe void StartEditMode(Meta.Grids.Grid editGrid)
		{
			//Discarded unreachable code: IL_00ed, IL_00f3, IL_00f9, IL_00ff, IL_0105, IL_010b, IL_0111, IL_0117, IL_0129
			//IL_002a: Expected O, but got I4
			int num = 0;
			EditGrid = editGrid;
			if ((Grid != null && (object)typeof(IGrid).TypeHandle != null) || EditGrid != null)
			{
			}
			editGrid.InitFromData((GridData)num);
			((HashSet<T>)(object)editGridObjects).Clear();
			HashSet<uint> hashSet = gridObjects;
			bool flag = default(bool);
			if (flag)
			{
				MapField<uint, GridObject> objects_ = editGrid.objects_;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				HashSet<uint> hashSet2 = editGridObjects;
			}
			int num2 = 0;
			Transform transform = default(Transform);
			IEnumerator enumerator = transform.GetEnumerator();
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			bool flag4 = default(bool);
			if (enumerator != null)
			{
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					num2++;
				}
				num2 += 312;
				num2 += 328;
				int num5 = 0;
				if (num2 == 0)
				{
					throw new InvalidCastException();
				}
				int num6 = 0;
				if (num2 == 0)
				{
					throw new InvalidCastException();
				}
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				if (!flag3)
				{
					string text = ((int*)num)->ToString();
					string message = "GridObjectScript: " + text + " does not have a gridObject, this prefab should probably not have a gridObjectScript";
					int num7 = 0;
					UnityEngine.Debug.LogWarning(message);
				}
				while (!flag4)
				{
				}
			}
			if (!flag4)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013BD")]
		[Cpp2IlInjected.Address(RVA = "0x1541740", Offset = "0x1540140", VA = "0x181541740")]
		internal Task StopEditMode(Dictionary<(uint gridID, uint gridObjectID), (uint gridID, uint gridObjectID)> resynchronizedIDs)
		{
			//IL_001b: Expected O, but got I4
			//IL_0029: Expected O, but got I8
			resolveDisabled = false;
			if ((long)EditGrid == 0)
			{
				int num = 0;
				this.ResynchronizeGridObjects((Dictionary<, >)num).FireAndForgetTask();
			}
			EditGrid = (Meta.Grids.Grid)0;
			int visualGridVisibility = 0;
			SetVisualGridVisibility((byte)visualGridVisibility != 0);
			return this.ResynchronizeGridObjects((Dictionary<, >)(object)resynchronizedIDs);
		}

		[Cpp2IlInjected.Token(Token = "0x60013BE")]
		[Cpp2IlInjected.Address(RVA = "0x153FC70", Offset = "0x153E670", VA = "0x18153FC70")]
		private Task ResynchronizeGridObjects([System.Runtime.InteropServices.Optional] Dictionary<(uint gridID, uint gridObjectID), (uint gridID, uint gridObjectID)> resynchronizedIDs)
		{
			//Discarded unreachable code: IL_006c, IL_007b, IL_016b, IL_0171, IL_0177, IL_017d, IL_0183, IL_0189, IL_018f, IL_01a1, IL_01ad, IL_01b3, IL_01b9, IL_01bf, IL_01c5, IL_01cb, IL_01d1, IL_01d7, IL_01dd, IL_01e3, IL_01e9, IL_01ef, IL_01f5, IL_01fb, IL_0207, IL_020d
			//IL_0078: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_00e9: Expected O, but got I4
			//IL_0150: Expected O, but got I4
			bool flag = default(bool);
			ICollection<> collection = default(ICollection<>);
			uint num8 = default(uint);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			OrphanHandleContainer orphanHandleContainer = default(OrphanHandleContainer);
			GameObject go = default(GameObject);
			Task item = default(Task);
			bool flag9 = default(bool);
			bool flag10 = default(bool);
			bool flag11 = default(bool);
			bool flag12 = default(bool);
			OrphanHandleContainer orphanHandleContainer2 = default(OrphanHandleContainer);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				List<Task> list;
				if ((IntPtr)Grid != (IntPtr)num3)
				{
					list = (List<Task>)(object)new List<T>();
					Dictionary<uint, GridObjectScript> dictionary = (Dictionary<uint, GridObjectScript>)(object)new Dictionary<TKey, TValue>(base.transform.childCount);
					HashSet<GridObjectScript> hashSet = (HashSet<GridObjectScript>)(object)new HashSet<T>();
					IEnumerator enumerator = base.transform.GetEnumerator();
					if (enumerator != null)
					{
						int num5 = 0;
						if (enumerator == null)
						{
							throw new InvalidCastException();
						}
						int num6 = 0;
						if (enumerator == null)
						{
							throw new InvalidCastException();
						}
						while (!flag)
						{
						}
						if (flag)
						{
							throw new NullReferenceException();
						}
						string text = hashSet.ToString();
						UnityEngine.Debug.LogWarning("GridObjectScript: " + text + " does not have a gridObject, this prefab should probably not have a gridObjectScript");
					}
					int num7 = 0;
					if (hashSet != null)
					{
					}
					if (num == 0)
					{
						if (collection != null)
						{
							if (num7 < (int)num8)
							{
								num7 += num7;
								if (num7 == (int)num8)
								{
									goto IL_0114;
								}
								num7++;
							}
							int num9 = 0;
							if (flag2)
							{
							}
							int num10 = 0;
							uint valueOrDefault = MoreLinq.GetValueOrDefault<uint, GridObjectScript>((IReadOnlyDictionary<, >)dictionary, (GridObjectScript)num, (uint)num10);
							if (flag3 || (flag4 && !flag5 && !flag6))
							{
								while (!flag7)
								{
								}
								while (!flag8)
								{
								}
								int num11 = orphanHandleContainer.FindIndex(go);
								goto IL_0114;
							}
							goto IL_011b;
						}
						goto IL_0124;
					}
					throw new NullReferenceException();
				}
				goto IL_0162;
				IL_011b:
				((List<T>)(object)list).Add((T)item);
				goto IL_0124;
				IL_0124:
				int num12 = 0;
				if (collection != null)
				{
					int num13 = 0;
				}
				if (num != 0)
				{
					break;
				}
				if (flag9 && flag10 && flag11)
				{
					while (!flag12)
					{
					}
					bool flag13 = Addressables.ReleaseInstance((AsyncOperationHandle<>)num4);
				}
				if (num != 0)
				{
					continue;
				}
				Task task = Task.WhenAll((IEnumerable<>)list);
				goto IL_0162;
				IL_0162:
				int num14 = 0;
				return Task.CompletedTask;
				IL_0114:
				orphanHandleContainer2 = (OrphanHandleContainer)(object)((object)orphanHandleContainer2 + (object)orphanHandleContainer2);
				goto IL_011b;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013BF")]
		[Cpp2IlInjected.Address(RVA = "0x153D960", Offset = "0x153C360", VA = "0x18153D960")]
		private GridPosition GetGridPosition(in Vector3 worldPosition, int stride, int minX, int minY, int maxX, int maxY)
		{
			Transform gridOrigin = GridOrigin;
			Transform gridOrigin2 = GridOrigin;
			Vector3 vector = default(Vector3);
			int num = Mathf.FloorToInt(vector.z);
			Transform gridOrigin3 = GridOrigin;
			int max = 0;
			Vector3 vector2 = default(Vector3);
			float z = vector2.z;
			int num2 = 0;
			int num3 = Mathf.FloorToInt(z);
			if (stride != 1)
			{
				num3 = num;
				num -= num2;
				num3 -= num2;
			}
			int num4 = Mathf.Clamp(num, minX, max);
			num = num3;
			num = num4;
			int num5 = Mathf.Clamp(num, minX, max);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013C0")]
		[Cpp2IlInjected.Address(RVA = "0x153DB30", Offset = "0x153C530", VA = "0x18153DB30")]
		public GridPosition GetGridPosition(in Vector3 worldPosition, int stride = 1, bool allowInvalid = false)
		{
			//Discarded unreachable code: IL_0030
			//IL_002f: Expected I4, but got I8
			//IL_002f: Expected I4, but got I8
			//IL_002f: Expected I4, but got I8
			if (Grid == null)
			{
				Meta.Grids.Grid grid = EditGrid;
			}
			if (!allowInvalid)
			{
				int num = 0;
				bool flag = (byte)((allowInvalid ? 1u : 0u) - 1u) != 0;
			}
			int num2 = 0;
			ulong num3 = default(ulong);
			ulong num4 = default(ulong);
			ulong num5 = default(ulong);
			return GetGridPosition(in worldPosition, stride, int.MinValue, (int)num3, (int)num4, (int)num5);
		}

		[Cpp2IlInjected.Token(Token = "0x60013C1")]
		[Cpp2IlInjected.Address(RVA = "0x153D690", Offset = "0x153C090", VA = "0x18153D690")]
		public GridPosition GetGridPositionForGridArea(in Vector3 worldPosition, GridOrientation orientation, in GridArea area)
		{
			//Discarded unreachable code: IL_0059
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected F4, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected F4, but got Unknown
			if (Grid == null)
			{
			}
			int num = default(int);
			if (num > 1)
			{
				Transform gridOrigin = GridOrigin;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
			Vector3 zero = Vector3.zero;
			int num2 = default(int);
			if (num2 > 1)
			{
				Transform gridOrigin2 = GridOrigin;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
			}
			Vector3 zero2 = Vector3.zero;
			float z3 = worldPosition.z;
			int num3 = 0;
			z3 -= num2;
			z3 -= num;
			GridPosition result = default(GridPosition);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C2")]
		[Cpp2IlInjected.Address(RVA = "0x153D3B0", Offset = "0x153BDB0", VA = "0x18153D3B0")]
		public unsafe GridObject GetGridObject(uint gridObjectID)
		{
			//IL_0023: Expected O, but got I4
			Meta.Grids.Grid grid = EditGrid;
			int num = 0;
			if (grid != null || Grid != null)
			{
				bool flag = ((MapField<TKey, TValue>)(object)grid.objects_).TryGetValue((TKey)gridObjectID, out *(TValue*)num);
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013C3")]
		[Cpp2IlInjected.Address(RVA = "0x153D490", Offset = "0x153BE90", VA = "0x18153D490")]
		public List<GridObject> GetGridObjectsForPosition(in GridPosition gridPosition, bool editGrid)
		{
			if (editGrid)
			{
			}
			IGrid grid = Grid;
			if (grid != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				uint iD = grid.ID;
				iD += 632;
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C4")]
		[Cpp2IlInjected.Address(RVA = "0x153E560", Offset = "0x153CF60", VA = "0x18153E560")]
		public Vector3 GetWorldPosition(in GridPosition position)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013C5")]
		[Cpp2IlInjected.Address(RVA = "0x153BA60", Offset = "0x153A460", VA = "0x18153BA60")]
		public Vector3 GetCenterWorldPosition(in GridPosition position, GridOrientation orientation, in GridArea area)
		{
			Vector3 worldPosition = GetWorldPosition(in position);
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013C6")]
		[Cpp2IlInjected.Address(RVA = "0x153D570", Offset = "0x153BF70", VA = "0x18153D570")]
		public GridOrientation GetGridOrientation(in Quaternion worldRotation)
		{
			//Discarded unreachable code: IL_000c, IL_0011, IL_0013
			Transform gridOrigin = GridOrigin;
			int num = 0;
			return GridOrientation.Left;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C7")]
		[Cpp2IlInjected.Address(RVA = "0x153E6F0", Offset = "0x153D0F0", VA = "0x18153E6F0")]
		public Quaternion GetWorldRotation(GridOrientation orientation)
		{
			Vector3 up = Vector3.up;
			Quaternion identity = Quaternion.identity;
			Vector3 up2 = Vector3.up;
			Vector3 up3 = Vector3.up;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013C8")]
		[Cpp2IlInjected.Address(RVA = "0x153E4A0", Offset = "0x153CEA0", VA = "0x18153E4A0")]
		public GridLayers GetLayersForPosition(in GridPosition position)
		{
			IGrid grid = Grid;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			uint iD = grid.ID;
			iD += 616;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013C9")]
		[Cpp2IlInjected.Address(RVA = "0x153EFC0", Offset = "0x153D9C0", VA = "0x18153EFC0")]
		public bool IsAreaInside(in GridPosition position, GridOrientation orientation, in GridArea area, bool editGrid)
		{
			IGrid grid = Grid;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			uint iD = grid.ID;
			iD += 568;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013CA")]
		[Cpp2IlInjected.Address(RVA = "0x153F0F0", Offset = "0x153DAF0", VA = "0x18153F0F0")]
		public bool IsAreaValidFor(in GridPosition position, GridOrientation orientation, in GridArea area, GridObject gridObject, bool editGrid)
		{
			IGrid grid = default(IGrid);
			if (EditGrid == null)
			{
				grid = Grid;
			}
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			uint iD = grid.ID;
			iD += 600;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013CB")]
		[Cpp2IlInjected.Address(RVA = "0x153F0C0", Offset = "0x153DAC0", VA = "0x18153F0C0")]
		public bool IsAreaValidForWithClearing(in GridPosition position, GridOrientation orientation, in GridArea area, GridObject gridObject, bool editGrid, [System.Runtime.InteropServices.Optional] Item? clearedBy)
		{
			if (EditGrid == null)
			{
				IGrid grid = Grid;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013CC")]
		[Cpp2IlInjected.Address(RVA = "0x153EAE0", Offset = "0x153D4E0", VA = "0x18153EAE0")]
		public bool HasGridConflicts(in GridPosition position, GridOrientation orientation, in GridArea area, GridObject gridObject, bool editGrid, GridCellConflict conflictsToCheck = GridCellConflict.All)
		{
			IGrid grid = Grid;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			num += 648;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013CD")]
		[Cpp2IlInjected.Address(RVA = "0x153CFB0", Offset = "0x153B9B0", VA = "0x18153CFB0")]
		public (bool, GridCellConflict) GetGridConflicts(in GridPosition position, GridOrientation orientation, in GridArea area, GridObject gridObject, bool editGrid, GridCellConflict conflictsToCheck = GridCellConflict.All)
		{
			IGrid grid = Grid;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			num += 664;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013CE")]
		[Cpp2IlInjected.Address(RVA = "0x153CE70", Offset = "0x153B870", VA = "0x18153CE70")]
		public (bool, GridCellConflict, GridCellConflict[][]) GetGridConflictedCells(in GridPosition position, GridOrientation orientation, in GridArea area, GridObject gridObject, bool editGrid)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013CF")]
		[Cpp2IlInjected.Address(RVA = "0x153BC50", Offset = "0x153A650", VA = "0x18153BC50")]
		public List<GridObjectScript> GetConflictedObjects(in GridPosition position, GridOrientation orientation, in GridArea area, GridObject gridObject, bool editGrid)
		{
			//Discarded unreachable code: IL_0092, IL_0098, IL_009e, IL_00a4, IL_00b6, IL_00bc
			int num = 0;
			IGrid grid = Grid;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			Meta.Grids.Grid grid2 = EditGrid;
			List<GridObjectScript> list = (List<GridObjectScript>)(object)new List<T>();
			IEnumerator enumerator = base.transform.GetEnumerator();
			int num6 = default(int);
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				GridObjectScript gridObjectScript = default(GridObjectScript);
				Predicate<GridObject> predicate = (Predicate<GridObject>)(object)(Predicate<T>)delegate(GridObject x)
				{
					GridObjectScript gridObjectScript2 = gridObjectScript;
					uint iD_ = x.iD_;
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript2.GridObject;
					int num7 = 0;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						uint iD_2 = _003CGridObject_003Ek__BackingField.iD_;
					}
					throw new NullReferenceException();
				};
				List<GridObject> list2 = default(List<GridObject>);
				num6 = ((List<T>)(object)list2).FindIndex((Predicate<>)(object)predicate);
				GridObjectScript item = gridObjectScript;
				((List<T>)(object)list).Add((T)item);
			}
			if (num6 != 0)
			{
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60013D0")]
		[Cpp2IlInjected.Address(RVA = "0x153E940", Offset = "0x153D340", VA = "0x18153E940")]
		private void GridOperationCompletedEvent(IGrid _grid, GridChangedOperation _operation, GridObject _gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions _options)
		{
			if (Grid == _grid && !resolveDisabled)
			{
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013D1")]
		[Cpp2IlInjected.Address(RVA = "0x153A8B0", Offset = "0x15392B0", VA = "0x18153A8B0")]
		public GridObject AddObjectToEditGrid(GridObjectScript gridObjectScript)
		{
			//IL_008b: Expected O, but got I4
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			if (_003CGridObject_003Ek__BackingField != null)
			{
				if (EditGrid.IsOnGrid(_003CGridObject_003Ek__BackingField))
				{
					return gridObjectScript.GridObject;
				}
				Meta.Grids.Grid grid = EditGrid;
				GridObject gridObject = default(GridObject);
				if (gridObject != null)
				{
					GridObject _003CGridObject_003Ek__BackingField2 = gridObjectScript.GridObject;
					Meta.Grids.Grid grid2 = EditGrid;
					uint nextGridObjectID_ = grid2.nextGridObjectID_;
					if (_003CGridObject_003Ek__BackingField2.iD_ == nextGridObjectID_)
					{
						uint num = (grid2.nextGridObjectID_ = nextGridObjectID_ + 1);
					}
					int editModeResynchronize = 0;
					gridObjectScript.Init(this, gridObject, (byte)editModeResynchronize != 0);
					HashSet<uint> hashSet = editGridObjects;
					uint iD_ = gridObject.iD_;
					bool flag = ((HashSet<T>)(object)hashSet).Add((T)iD_);
				}
				return gridObject;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013D2")]
		[Cpp2IlInjected.Address(RVA = "0x153B500", Offset = "0x1539F00", VA = "0x18153B500")]
		public GridObject CreateTemporaryGridObject(Item item, GridPosition position, GridOrientation orientation)
		{
			//Discarded unreachable code: IL_0039
			int itemID = item.ItemID;
			GridObject gridObject = new GridObject();
			uint num = (gridObject.iD_ = EditGrid.nextGridObjectID_);
			gridObject.ItemID = itemID;
			gridObject.Position = position;
			gridObject.orientation_ = orientation;
			return gridObject;
		}

		[Cpp2IlInjected.Token(Token = "0x60013D3")]
		[Cpp2IlInjected.Address(RVA = "0x153B3B0", Offset = "0x1539DB0", VA = "0x18153B3B0")]
		[AsyncStateMachine(typeof(_003CCreateTemporaryGridGameObject_003Ed__87))]
		public Task<GameObject> CreateTemporaryGridGameObject(Item item, GridPosition position, GridOrientation orientation)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013D4")]
		[Cpp2IlInjected.Address(RVA = "0x153B260", Offset = "0x1539C60", VA = "0x18153B260")]
		[AsyncStateMachine(typeof(_003CCreateTemporaryGridGameObjectID_003Ed__88))]
		public Task<GameObject> CreateTemporaryGridGameObjectID(Item item, GridPosition position, GridOrientation orientation)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013D5")]
		[Cpp2IlInjected.Address(RVA = "0x153A770", Offset = "0x1539170", VA = "0x18153A770")]
		[AsyncStateMachine(typeof(_003CAddObjectToEditGridAndCreateGameObject_003Ed__89))]
		public Task<GameObject> AddObjectToEditGridAndCreateGameObject(GridObject gridObject)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013D6")]
		[Cpp2IlInjected.Address(RVA = "0x153F7B0", Offset = "0x153E1B0", VA = "0x18153F7B0")]
		private void ReleaseFromOrphans(GridObjectScript gridObjectScript)
		{
			//Discarded unreachable code: IL_0023, IL_002c
			OrphanHandleContainer orphanHandleContainer = OrphanHandleContainer;
			GameObject go = gridObjectScript.gameObject;
			int num = orphanHandleContainer.FindIndex(go);
			bool flag = Addressables.ReleaseInstance(gridObjectScript.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60013D7")]
		[Cpp2IlInjected.Address(RVA = "0x153F8F0", Offset = "0x153E2F0", VA = "0x18153F8F0")]
		internal unsafe bool RemoveObject(GridObjectScript gridObjectScript, bool destroyGameObject)
		{
			//IL_001e: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_011a: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Meta.Grids.Grid grid = EditGrid;
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			int num3 = 0;
			bool flag = grid.RemoveObject(_003CGridObject_003Ek__BackingField, (ProfileEventDispatcher)num3);
			if (destroyGameObject)
			{
				GridObject _003CGridObject_003Ek__BackingField2 = gridObjectScript.GridObject;
				HashSet<uint> hashSet = editGridObjects;
				uint iD_ = _003CGridObject_003Ek__BackingField2.iD_;
				bool flag2 = ((HashSet<T>)(object)hashSet).Remove((T)iD_);
				if (!flag2)
				{
					return flag2;
				}
				GridObject _003CGridObject_003Ek__BackingField3 = gridObjectScript.GridObject;
				HashSet<uint> hashSet2 = gridObjects;
				uint iD_2 = _003CGridObject_003Ek__BackingField3.iD_;
				bool flag3 = ((HashSet<T>)(object)hashSet2).Remove((T)iD_2);
				OrphanHandleContainer orphanHandleContainer = OrphanHandleContainer;
				GameObject go = gridObjectScript.gameObject;
				int num4 = orphanHandleContainer.FindIndex(go);
				int itemID = gridObjectScript.GridObject.ItemID;
				bool flag4 = default(bool);
				if (flag4)
				{
					DistanceCullingManager distanceCullingManager = this.distanceCullingManager;
					GridObject _003CGridObject_003Ek__BackingField4 = gridObjectScript.GridObject;
					bool flag5 = default(bool);
					if (distanceCullingManager.RemoveAsset(_003CGridObject_003Ek__BackingField4, this, out *(AsyncOperationHandle<GameObject>*)num2) && !flag5)
					{
						goto IL_00d4;
					}
				}
				bool flag6 = Addressables.ReleaseInstance(gridObjectScript.gameObject);
			}
			goto IL_00d4;
			IL_00d4:
			if (flag)
			{
				int itemID2 = gridObjectScript.GridObject.ItemID;
				bool flag7 = default(bool);
				if (flag7)
				{
					DistanceCullingManager distanceCullingManager2 = this.distanceCullingManager;
					GridObject _003CGridObject_003Ek__BackingField5 = gridObjectScript.GridObject;
					bool flag8 = default(bool);
					if (distanceCullingManager2.RemoveAsset(_003CGridObject_003Ek__BackingField5, this, out *(AsyncOperationHandle<GameObject>*)num) && flag8)
					{
						OrphanHandleContainer.Add((AsyncOperationHandle<>)num);
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013D8")]
		[Cpp2IlInjected.Address(RVA = "0x153B9E0", Offset = "0x153A3E0", VA = "0x18153B9E0")]
		public void ForgetEditObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_0030
			//IL_0015: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			HashSet<uint> hashSet = gridObjects;
			uint iD_ = gridObject.iD_;
			bool flag = ((HashSet<T>)(object)hashSet).Remove((T)iD_);
			HashSet<uint> hashSet2 = editGridObjects;
			uint iD_2 = gridObject.iD_;
			bool flag2 = ((HashSet<T>)(object)hashSet2).Remove((T)iD_2);
		}

		[Cpp2IlInjected.Token(Token = "0x60013D9")]
		[Cpp2IlInjected.Address(RVA = "0x1541CA0", Offset = "0x15406A0", VA = "0x181541CA0")]
		public bool UpdateTransform(GridObject gridObject, in GridPosition newGridPosition, GridOrientation newGridOrientation)
		{
			//Discarded unreachable code: IL_0022
			Meta.Grids.Grid grid = EditGrid;
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				if (!Application.isPlaying && this.EditorGridChangedEvent == null)
				{
				}
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x60013DA")]
		[Cpp2IlInjected.Address(RVA = "0x153F280", Offset = "0x153DC80", VA = "0x18153F280")]
		public bool IsOnEditGrid(GridObject gridObject)
		{
			//Discarded unreachable code: IL_000d
			return EditGrid.IsOnGrid(gridObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60013DB")]
		[Cpp2IlInjected.Address(RVA = "0x153F2A0", Offset = "0x153DCA0", VA = "0x18153F2A0")]
		public bool IsOnGrid(Vector3 worldPosition, out GridPosition gridPosition)
		{
			//IL_0030: Expected I4, but got O
			Transform gridOrigin = GridOrigin;
			Transform gridOrigin2 = GridOrigin;
			Transform gridOrigin3 = GridOrigin;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			if (Grid == null)
			{
			}
			gridPosition.X = (int)vector;
			bool flag = default(bool);
			if (!flag)
			{
				int num = (gridPosition.X = 0);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013DC")]
		[Cpp2IlInjected.Address(RVA = "0x153E870", Offset = "0x153D270", VA = "0x18153E870")]
		public bool GridHasObjects(bool editGrid)
		{
			//Discarded unreachable code: IL_002f
			if (!editGrid)
			{
				IGrid grid = Grid;
				int num = default(int);
				return num > 0;
			}
			Meta.Grids.Grid grid2 = EditGrid;
			if (grid2 != null)
			{
				return ((MapField<TKey, TValue>)(object)grid2.objects_).Count > 0;
			}
			return 0 > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60013DD")]
		[Cpp2IlInjected.Address(RVA = "0x153D0E0", Offset = "0x153BAE0", VA = "0x18153D0E0")]
		public GridObjectScript GetGridObjectScript(uint gridObjectID)
		{
			//Discarded unreachable code: IL_0048, IL_005a, IL_0060
			int num = 0;
			ProfilerMarker profilerMarker = s_getGridObjectScript;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				while (!flag)
				{
				}
				num++;
			}
			num++;
			int num4 = 0;
			if (num != 0)
			{
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013DE")]
		[Cpp2IlInjected.Address(RVA = "0x1540C40", Offset = "0x153F640", VA = "0x181540C40")]
		public void SetVisualGridVisibility(bool visible)
		{
			//Discarded unreachable code: IL_0020
			//IL_0010: Expected O, but got I4
			GameObject visualGrid = VisualGrid;
			int num = 0;
			if (visualGrid != (UnityEngine.Object)num)
			{
				VisualGrid.SetActive(visible);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013DF")]
		[Cpp2IlInjected.Address(RVA = "0x153B9C0", Offset = "0x153A3C0", VA = "0x18153B9C0")]
		public IEnumerable<GridPosition> EnumeratePositionsInSpiralOrder(GridPosition center, int spiral_inc = 1, int maxNumberOfLoops = -1, [System.Runtime.InteropServices.Optional] Func<GridPosition, bool> validityCheck, [System.Runtime.InteropServices.Optional] Action<int> loopCallback)
		{
			IGrid grid = Grid;
			IEnumerable<GridPosition> result = default(IEnumerable<GridPosition>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60013E0")]
		[Cpp2IlInjected.Address(RVA = "0x153C0B0", Offset = "0x153AAB0", VA = "0x18153C0B0")]
		public unsafe Meta.Grids.Grid GetEditGridClone()
		{
			//Discarded unreachable code: IL_0102, IL_0108, IL_010e, IL_0114, IL_011a, IL_0120, IL_0126, IL_012c, IL_0132, IL_0138, IL_013e, IL_0144, IL_014a, IL_015c, IL_0162
			//IL_001c: Expected O, but got I4
			//IL_00f0: Expected I4, but got O
			bool flag = default(bool);
			GridObjectScript gridObjectScript = default(GridObjectScript);
			bool flag2 = default(bool);
			GridState gridState = default(GridState);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				Meta.Grids.Grid grid = EditGrid;
				if (grid != null)
				{
					Meta.Grids.Grid grid2 = grid.Clone();
				}
				FakeTransactionContext fakeTransactionContext = new FakeTransactionContext((Nullable<>)0);
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num3 = 0;
					int num4 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num5 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					while (!flag)
					{
					}
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					while (_003CGridObject_003Ek__BackingField == null)
					{
					}
					uint iD_ = _003CGridObject_003Ek__BackingField.iD_;
					while (!flag2)
					{
					}
					IDefaultGridStateProvider[] componentsInChildren = gridObjectScript.GetComponentsInChildren<IDefaultGridStateProvider>();
					Func<IDefaultGridStateProvider, bool> func = (Func<IDefaultGridStateProvider, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0013
						int num6 = 0;
						int num7 = 0;
						GridObjectScript gridObjectScript2 = gridObjectScript;
						GridObjectScript gridObjectScript3 = default(GridObjectScript);
						return gridObjectScript3 == gridObjectScript2;
					};
					IDefaultGridStateProvider[] array = Enumerable.Where<IDefaultGridStateProvider>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func).ToArray<IDefaultGridStateProvider>();
					if (num < array.Length)
					{
						IDefaultGridStateProvider defaultGridStateProvider = array[num];
						if (array == null)
						{
							num++;
						}
					}
					if (num != 0 || num != 0)
					{
					}
					if (num < array.Length)
					{
						IDefaultGridStateProvider defaultGridStateProvider2 = array[num];
						num++;
					}
					num += 48;
					((int*)num)->m_value = (int)gridState;
				}
				if (gridState != null)
				{
				}
				if (num == 0)
				{
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013E1")]
		[Cpp2IlInjected.Address(RVA = "0x153C6C0", Offset = "0x153B0C0", VA = "0x18153C6C0")]
		public unsafe GridCollection GetEditGridCollectionClone([System.Runtime.InteropServices.Optional] uint? nextGridIDOverride)
		{
			//Discarded unreachable code: IL_016e, IL_0174, IL_017a, IL_0180, IL_0186, IL_018c, IL_0192, IL_0198, IL_019e, IL_01a4, IL_01aa, IL_01b0, IL_01b6, IL_01bc, IL_01c8
			//IL_0070: Expected I4, but got O
			//IL_00b8: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0155: Expected O, but got I4
			Func<GridScript, uint> func = default(Func<GridScript, uint>);
			uint num3 = default(uint);
			uint num4 = default(uint);
			uint num5 = default(uint);
			bool flag = default(bool);
			GridObjectScript gridObjectScript = default(GridObjectScript);
			SubGrid subGrid = default(SubGrid);
			uint nextGridID_ = default(uint);
			Meta.Grids.Grid grid = default(Meta.Grids.Grid);
			SubGrid subGrid2 = default(SubGrid);
			while (true)
			{
				int num = 0;
				Meta.Grids.Grid editGridClone = GetEditGridClone();
				GridCollection gridCollection = new GridCollection();
				GridScript[] componentsInChildren = GetComponentsInChildren<GridScript>();
				Func<GridScript, bool> _003C_003E9__102_ = _003C_003Ec._003C_003E9__102_0;
				if (_003C_003E9__102_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridScript x)
					{
						uint? num10 = x.EditorGridID;
						throw new NullReferenceException();
					};
				}
				IEnumerable<GridScript> enumerable = (IEnumerable<GridScript>)Enumerable.Where<GridScript>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)_003C_003E9__102_);
				if (_003C_003Ec._003C_003E9__102_1 == null)
				{
					func = (Func<GridScript, uint>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridScript x)
					{
						//Discarded unreachable code: IL_0009
						uint? num9 = x.EditorGridID;
						uint result = default(uint);
						return result;
					});
				}
				uint num2 = Enumerable.Max<uint>((IEnumerable<>)new List<T>((int)Enumerable.Select<GridScript, uint>((IEnumerable<>)enumerable, (Func<, >)(object)func)));
				gridCollection.nextGridID_ = num3;
				if ((object)EditorGridID == null)
				{
					num4 = (gridCollection.nextGridID_ = num3 + 1);
					num4 = num3;
				}
				editGridClone.iD_ = num4;
				MapField<uint, Meta.Grids.Grid> grids_ = gridCollection.grids_;
				num3 = num4;
				((MapField<TKey, TValue>)(object)grids_).Add((TKey)num3, (TValue)editGridClone);
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					if (num < (int)num5)
					{
						num += num;
						num++;
					}
					int num6 = 0;
					if (enumerator == null)
					{
						break;
					}
					while (!flag)
					{
					}
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					while (_003CGridObject_003Ek__BackingField == null)
					{
					}
					MapField<uint, GridObject> objects_ = editGridClone.objects_;
					uint iD_ = _003CGridObject_003Ek__BackingField.iD_;
					if (!((MapField<TKey, TValue>)(object)objects_).TryGetValue((TKey)iD_, out *(TValue*)num))
					{
						continue;
					}
					while (objects_ == null)
					{
					}
					while (subGrid == null)
					{
					}
					if (num == 0)
					{
						nextGridID_ = gridCollection.nextGridID_;
						uint num7 = (gridCollection.nextGridID_ = nextGridID_ + 1);
					}
					grid.iD_ = nextGridID_;
					((MapField<TKey, TValue>)(object)gridCollection.grids_).Add((TKey)nextGridID_, (TValue)grid);
					uint num8 = (subGrid2.gridID_ = grid.iD_);
				}
				if (subGrid2 != null)
				{
				}
				return gridCollection;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013E2")]
		[Cpp2IlInjected.Address(RVA = "0x153CDB0", Offset = "0x153B7B0", VA = "0x18153CDB0")]
		public string GetEditGridCollectionJSONText()
		{
			//IL_0009: Expected O, but got I4
			//IL_0025: Expected I4, but got I8
			int num = 0;
			GridCollection editGridCollectionClone = this.GetEditGridCollectionClone((Nullable<>)num);
			GridCollection.PrettyOrder(editGridCollectionClone);
			if (editGridCollectionClone != null)
			{
				int formatEnumAsIntegers = 0;
				int formatDefaultValues = 0;
				ulong num2 = default(ulong);
				return editGridCollectionClone.ToJSONString((byte)formatDefaultValues != 0, indented: true, (byte)formatEnumAsIntegers != 0, (int)num2);
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013E3")]
		[Cpp2IlInjected.Address(RVA = "0x153A9E0", Offset = "0x15393E0", VA = "0x18153A9E0")]
		public void BeginDisableResolve()
		{
			resolveDisabled = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60013E4")]
		[Cpp2IlInjected.Address(RVA = "0x153B7C0", Offset = "0x153A1C0", VA = "0x18153B7C0")]
		public void EndDisableResolve()
		{
			//IL_001b: Expected O, but got I4
			resolveDisabled = false;
			if ((long)EditGrid == 0)
			{
				int num = 0;
				this.ResynchronizeGridObjects((Dictionary<, >)num).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013E5")]
		[Cpp2IlInjected.Address(RVA = "0x153A9F0", Offset = "0x15393F0", VA = "0x18153A9F0")]
		public unsafe List<GameObject> BeginPlaneCulling(Plane[] planes, GridLayers layersToHide, [System.Runtime.InteropServices.Optional] HashSet<GameObject> exceptions)
		{
			//Discarded unreachable code: IL_018f, IL_0195, IL_019b, IL_01a1, IL_01a7, IL_01ad, IL_01b3, IL_01b9, IL_01bf, IL_01cb
			//IL_0052: Expected native int or pointer, but got O
			//IL_0073: Expected native int or pointer, but got O
			//IL_0094: Expected native int or pointer, but got O
			//IL_00b5: Expected native int or pointer, but got O
			//IL_014e: Expected native int or pointer, but got O
			bool flag = default(bool);
			bool flag2 = default(bool);
			Vector3 vector = default(Vector3);
			Vector3 lowerLeft = default(Vector3);
			GridPosition gridPosition = default(GridPosition);
			Vector3 vector2 = default(Vector3);
			Vector3 lowerRight = default(Vector3);
			GridPosition gridPosition3 = default(GridPosition);
			Vector3 vector3 = default(Vector3);
			Vector3 upperRight = default(Vector3);
			GridPosition gridPosition5 = default(GridPosition);
			Vector3 vector4 = default(Vector3);
			Vector3 upperLeft = default(Vector3);
			GridLayers gridLayers = default(GridLayers);
			GridPosition gridPosition7 = default(GridPosition);
			GridPosition gridPosition8 = default(GridPosition);
			Vector3 vector5 = default(Vector3);
			Vector3 worldPosition = default(Vector3);
			bool flag3 = default(bool);
			GameObject gameObject = default(GameObject);
			GameObject item = default(GameObject);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				List<GameObject> list = (List<GameObject>)(object)new List<T>();
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num4 = 0;
					if (enumerator == null)
					{
						break;
					}
					while (!flag)
					{
					}
					while (flag2)
					{
					}
					float z = vector.z;
					((Vector3*)(IntPtr)lowerLeft)->z = z;
					GridPosition gridPosition2 = *(GridPosition*)gridPosition + *(GridPosition*)num;
					float z2 = vector2.z;
					((Vector3*)(IntPtr)lowerRight)->z = z2;
					GridPosition gridPosition4 = *(GridPosition*)gridPosition3 + *(GridPosition*)num;
					float z3 = vector3.z;
					((Vector3*)(IntPtr)upperRight)->z = z3;
					GridPosition gridPosition6 = *(GridPosition*)gridPosition5 + *(GridPosition*)num;
					float z4 = vector4.z;
					((Vector3*)(IntPtr)upperLeft)->z = z4;
					Func<Plane, bool> func = (Func<Plane, bool>)(object)(Func<T, TResult>)delegate
					{
						float z10 = lowerLeft.z;
						bool flag8 = default(bool);
						return !flag8;
					};
					if (!((IEnumerable<>)(object)planes).All<Plane>((Func<, >)(object)func))
					{
						Func<Plane, bool> func2 = (Func<Plane, bool>)(object)(Func<T, TResult>)delegate
						{
							float z9 = lowerRight.z;
							bool flag7 = default(bool);
							return !flag7;
						};
						if (!((IEnumerable<>)(object)planes).All<Plane>((Func<, >)(object)func2))
						{
							Func<Plane, bool> func3 = (Func<Plane, bool>)(object)(Func<T, TResult>)delegate
							{
								float z8 = upperRight.z;
								bool flag6 = default(bool);
								return !flag6;
							};
							if (!((IEnumerable<>)(object)planes).All<Plane>((Func<, >)(object)func3))
							{
								Func<Plane, bool> func4 = (Func<Plane, bool>)(object)(Func<T, TResult>)delegate
								{
									float z7 = upperLeft.z;
									bool flag5 = default(bool);
									return !flag5;
								};
								if (!((IEnumerable<>)(object)planes).All<Plane>((Func<, >)(object)func4))
								{
									continue;
								}
							}
						}
					}
					if (layersToHide != gridLayers)
					{
						GridPosition gridPosition9 = *(GridPosition*)gridPosition7 + *(GridPosition*)gridPosition8;
						float z5 = vector5.z;
						((Vector3*)(IntPtr)worldPosition)->z = z5;
						Func<Plane, bool> func5 = (Func<Plane, bool>)(object)(Func<T, TResult>)delegate
						{
							float z6 = worldPosition.z;
							bool flag4 = default(bool);
							return !flag4;
						};
						if (flag3)
						{
							int active = 0;
							gameObject.SetActive((byte)active != 0);
							((List<T>)(object)list).Add((T)item);
						}
					}
					num++;
					num++;
				}
				if (enumerator == null)
				{
					return list;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013E6")]
		[Cpp2IlInjected.Address(RVA = "0x153B840", Offset = "0x153A240", VA = "0x18153B840")]
		public static void EndPlaneCulling(List<GameObject> culled)
		{
			//Discarded unreachable code: IL_0015, IL_001b
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013E7")]
		[Cpp2IlInjected.Address(RVA = "0x153DC30", Offset = "0x153C630", VA = "0x18153DC30")]
		public unsafe List<int> GetItemsInFrustum(Plane[] planes)
		{
			//IL_000e: Expected O, but got I4
			//IL_000e: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			return (List<int>)(object)this.GetItemsInFrustum(planes, ref *(List<int>*)num, (Func<, , >)num2, (Func<, , >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60013E8")]
		[Cpp2IlInjected.Address(RVA = "0x153E370", Offset = "0x153CD70", VA = "0x18153E370")]
		public unsafe List<int> GetItemsInFrustum(Plane[] planes, ref List<int> gardenCropItems, Vector3 origin, float maxSqrDistance)
		{
			//Discarded unreachable code: IL_003d
			//IL_0014: Expected F4, but got I4
			//IL_001b: Expected native int or pointer, but got O
			float z = origin.z;
			float maxSqrDistance2 = 0f;
			Vector3 origin2 = default(Vector3);
			((Vector3*)(IntPtr)origin2)->z = z;
			Func<Item, GridObjectScript, bool> func = (Func<Item, GridObjectScript, bool>)(object)new Func<T1, T2, TResult>(IsValidDistance);
			Func<Item, GridObjectScript, bool> func2 = (Func<Item, GridObjectScript, bool>)(object)new Func<T1, T2, TResult>(IsValidDistance);
			List<int> result = default(List<int>);
			return result;
			[Cpp2IlInjected.Token(Token = "0x6001413")]
			[Cpp2IlInjected.Address(RVA = "0x185B4E0", Offset = "0x1859EE0", VA = "0x18185B4E0")]
			bool IsValidDistance(Item item, GridObjectScript gridObj)
			{
				float z2 = origin2.z;
				Transform transform = gridObj.transform;
				Vector3 vector = default(Vector3);
				float z3 = vector.z;
				float num = maxSqrDistance2;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013E9")]
		[Cpp2IlInjected.Address(RVA = "0x153DC60", Offset = "0x153C660", VA = "0x18153DC60")]
		public List<int> GetItemsInFrustum(Plane[] planes, ref List<int> gardenCropItems, [System.Runtime.InteropServices.Optional] Func<Item, GridObjectScript, bool> predicateItem, [System.Runtime.InteropServices.Optional] Func<Item, GridObjectScript, bool> predicateGarden)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60013EA")]
		[Cpp2IlInjected.Address(RVA = "0x153B790", Offset = "0x153A190", VA = "0x18153B790")]
		public DisableResolveScope DisableResolve()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60013EB")]
		[Cpp2IlInjected.Address(RVA = "0x1540990", Offset = "0x153F390", VA = "0x181540990")]
		public void SetVisibilityByType(ItemType type, bool visibility)
		{
			//Discarded unreachable code: IL_0055, IL_005b, IL_0061, IL_0073
			uint num2 = default(uint);
			bool flag = default(bool);
			ItemType itemType = default(ItemType);
			GameObject gameObject = default(GameObject);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num4 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					while (!flag)
					{
					}
					while (enumerator == null)
					{
					}
					if (itemType != type)
					{
						continue;
					}
					gameObject = base.gameObject;
					gameObject.SetActive(visibility);
				}
				if ((object)gameObject == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013EC")]
		[Cpp2IlInjected.Address(RVA = "0x153B660", Offset = "0x153A060", VA = "0x18153B660")]
		[Conditional("DEBUG")]
		public void DebugDrawGridPosition(in GridPosition position, Color color, bool withCenter = true, int stride = 1, float duration = 0.1f)
		{
			//Discarded unreachable code: IL_000f
			Transform gridOrigin = GridOrigin;
			Transform gridOrigin2 = GridOrigin;
		}

		[Cpp2IlInjected.Token(Token = "0x60013ED")]
		[Cpp2IlInjected.Address(RVA = "0x153B6D0", Offset = "0x153A0D0", VA = "0x18153B6D0")]
		[Conditional("DEBUG")]
		public void DebugDrawGridWithStride(int stride = 1, float duration = 0.1f)
		{
			//Discarded unreachable code: IL_002b
			IGrid grid = Grid;
			int num = 0;
			if (0L < (long)(IntPtr)grid)
			{
				int num2 = 0;
				IGrid grid2 = Grid;
				if ((long)num2 < (long)(IntPtr)grid)
				{
					num2 += stride;
				}
				IGrid grid3 = Grid;
				num += stride;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013EE")]
		[Cpp2IlInjected.Address(RVA = "0x153B5C0", Offset = "0x1539FC0", VA = "0x18153B5C0")]
		[Conditional("DEBUG")]
		public void DebugCenterWorldPositionForArea(in GridPosition position, GridOrientation orientation, in GridArea area, Color color, float duration = 0.1f)
		{
			//Discarded unreachable code: IL_0010
			Transform gridOrigin = GridOrigin;
			Transform gridOrigin2 = GridOrigin;
		}

		[Cpp2IlInjected.Token(Token = "0x60013EF")]
		[Cpp2IlInjected.Address(RVA = "0x1541E10", Offset = "0x1540810", VA = "0x181541E10")]
		public GridScript()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60013F0")]
		[Cpp2IlInjected.Address(RVA = "0x1541D90", Offset = "0x1540790", VA = "0x181541D90")]
		static GridScript()
		{
			//IL_001a: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			s_getGridObjectScript = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("GetGridObjectScript", categoryId, (MarkerFlags)flags, metadataCount);
		}
	}
}
