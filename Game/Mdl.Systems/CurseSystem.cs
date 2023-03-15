using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Gameloft.Common;
using glPlayFab.Disney;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Characters.Critters;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AI;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200094B")]
	public class CurseSystem : System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400338E")]
		[SerializeField]
		[ItemID]
		private int activationCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400338F")]
		private PlayerTaskCollider.Condition activationPlayerTaskCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003390")]
		[ItemID]
		[SerializeField]
		private List<int> notAffectedCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003391")]
		[ItemID]
		[SerializeField]
		private List<int> notAffectedBuildings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003392")]
		[ItemID]
		[SerializeField]
		private int limboActivationCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003393")]
		[SerializeField]
		[ItemID]
		private List<int> notAffectedItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003394")]
		[SerializeField]
		private AssetReference limboVfxAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003395")]
		[SerializeField]
		private AssetReference limboMaterialAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003396")]
		[SerializeField]
		private AssetReference tileSpawnerAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003397")]
		public AK.Wwise.Event startLimboSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003398")]
		public AK.Wwise.Event stopLimboSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003399")]
		private PlayerTaskCollider.Condition limboActivationPlayerTaskCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400339A")]
		private List<GameObject> limboGameObjects = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400339B")]
		private GameObject limboVfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400339C")]
		private Dictionary<Renderer, List<Material>> avatarMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400339D")]
		private GameObject tileSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400339E")]
		private bool debugGhostMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400339F")]
		private List<GameObject> doorsVfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40033A0")]
		private bool isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
		[Cpp2IlInjected.Token(Token = "0x40033A1")]
		private bool isLimboActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40033A2")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40033A3")]
		private PlayerHouseEnvironment playerHouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40033A4")]
		private Dictionary<House.Types.RoomSlot, GameObject> configuredRooms = (Dictionary<House.Types.RoomSlot, GameObject>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40033A5")]
		private bool? wasInVillage;

		[Cpp2IlInjected.Token(Token = "0x17000618")]
		private Item ActivationConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002AE3")]
			[Cpp2IlInjected.Address(RVA = "0x110E4E0", Offset = "0x110CEE0", VA = "0x18110E4E0")]
			get
			{
				long num = Convert.ToInt64((uint)activationCondition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000619")]
		private bool HasActivationCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6002AE4")]
			[Cpp2IlInjected.Address(RVA = "0x110E5D0", Offset = "0x110CFD0", VA = "0x18110E5D0")]
			get
			{
				long num = Convert.ToInt64((uint)activationCondition);
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061A")]
		private PlayerTaskCollider.Condition ActivationPlayerTaskCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6002AE5")]
			[Cpp2IlInjected.Address(RVA = "0x110E540", Offset = "0x110CF40", VA = "0x18110E540")]
			get
			{
				PlayerTaskCollider.Condition condition = activationPlayerTaskCondition;
				if (condition == null)
				{
					int condition2 = activationCondition;
					PlayerTaskCollider.Condition condition3 = (activationPlayerTaskCondition = new PlayerTaskCollider.Condition(not: true, condition2));
				}
				return condition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061B")]
		private Item LimboActivationConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002AE6")]
			[Cpp2IlInjected.Address(RVA = "0x110E7D0", Offset = "0x110D1D0", VA = "0x18110E7D0")]
			get
			{
				long num = Convert.ToInt64((uint)limboActivationCondition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061C")]
		private bool HasLimboActivationCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6002AE7")]
			[Cpp2IlInjected.Address(RVA = "0x110E690", Offset = "0x110D090", VA = "0x18110E690")]
			get
			{
				long num = Convert.ToInt64((uint)limboActivationCondition);
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061D")]
		private PlayerTaskCollider.Condition LimboActivationPlayerTaskCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6002AE9")]
			[Cpp2IlInjected.Address(RVA = "0x110E830", Offset = "0x110D230", VA = "0x18110E830")]
			get
			{
				if ((object)typeof(PlayerTaskCollider.Condition).TypeHandle == null)
				{
					int condition = limboActivationCondition;
					PlayerTaskCollider.Condition condition2 = (limboActivationPlayerTaskCondition = new PlayerTaskCollider.Condition(not: true, condition));
				}
				return (PlayerTaskCollider.Condition)typeof(PlayerTaskCollider.Condition).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061E")]
		public bool DebugGhostMode
		{
			[Cpp2IlInjected.Token(Token = "0x6002AEC")]
			[Cpp2IlInjected.Address(RVA = "0x110E5C0", Offset = "0x110CFC0", VA = "0x18110E5C0")]
			get
			{
				return debugGhostMode;
			}
			[Cpp2IlInjected.Token(Token = "0x6002AED")]
			[Cpp2IlInjected.Address(RVA = "0x110EA00", Offset = "0x110D400", VA = "0x18110EA00")]
			set
			{
				if (debugGhostMode != value)
				{
					debugGhostMode = value;
					int conditionListener = 0;
					OnAnyConditionChanged((ConditionListener)conditionListener);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061F")]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6002AF2")]
			[Cpp2IlInjected.Address(RVA = "0x110E750", Offset = "0x110D150", VA = "0x18110E750")]
			get
			{
				return isActive;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000620")]
		public bool IsLimboActive
		{
			[Cpp2IlInjected.Token(Token = "0x6002AF3")]
			[Cpp2IlInjected.Address(RVA = "0x110E760", Offset = "0x110D160", VA = "0x18110E760")]
			get
			{
				return isLimboActive;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000621")]
		private bool IsPlayerHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6002B04")]
			[Cpp2IlInjected.Address(RVA = "0x110E770", Offset = "0x110D170", VA = "0x18110E770")]
			get
			{
				//IL_0010: Expected O, but got I4
				PlayerHouseEnvironment playerHouseEnvironment = playerHouse;
				int num = 0;
				return playerHouseEnvironment != (UnityEngine.Object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000062")]
		public event EventHandler<bool> StateChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6002ADF")]
			[Cpp2IlInjected.Address(RVA = "0x110E440", Offset = "0x110CE40", VA = "0x18110E440")]
			[CompilerGenerated]
			add
			{
				EventHandler<bool> stateChanged = this.StateChanged;
				Delegate @delegate = Delegate.Combine(stateChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != stateChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002AE0")]
			[Cpp2IlInjected.Address(RVA = "0x110E960", Offset = "0x110D360", VA = "0x18110E960")]
			[CompilerGenerated]
			remove
			{
				EventHandler<bool> stateChanged = this.StateChanged;
				Delegate @delegate = Delegate.Remove(stateChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != stateChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000063")]
		public event EventHandler<bool> LimboStateChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6002AE1")]
			[Cpp2IlInjected.Address(RVA = "0x110E3A0", Offset = "0x110CDA0", VA = "0x18110E3A0")]
			[CompilerGenerated]
			add
			{
				EventHandler<bool> limboStateChanged = this.LimboStateChanged;
				Delegate @delegate = Delegate.Combine(limboStateChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != limboStateChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002AE2")]
			[Cpp2IlInjected.Address(RVA = "0x110E8C0", Offset = "0x110D2C0", VA = "0x18110E8C0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<bool> limboStateChanged = this.LimboStateChanged;
				Delegate @delegate = Delegate.Remove(limboStateChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != limboStateChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AE8")]
		[Cpp2IlInjected.Address(RVA = "0x110BD40", Offset = "0x110A740", VA = "0x18110BD40")]
		private static bool IsLimboItem(Item item)
		{
			ItemType itemType = default(ItemType);
			ItemType itemType2 = default(ItemType);
			ItemType itemType3 = default(ItemType);
			if (itemType != ItemType.Building && itemType2 != ItemType.ActivityItem)
			{
				return itemType3 == ItemType.Furniture;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEA")]
		[Cpp2IlInjected.Address(RVA = "0x110B0F0", Offset = "0x1109AF0", VA = "0x18110B0F0")]
		public void AddLimboGameObject(GameObject gameObject)
		{
			//Discarded unreachable code: IL_000d
			((List<T>)(object)limboGameObjects).Add((T)gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEB")]
		[Cpp2IlInjected.Address(RVA = "0x110D1A0", Offset = "0x110BBA0", VA = "0x18110D1A0")]
		public bool RemoveLimboGameObject(GameObject gameObject)
		{
			//Discarded unreachable code: IL_000d
			return ((List<T>)(object)limboGameObjects).Remove((T)gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEE")]
		[Cpp2IlInjected.Address(RVA = "0x110CED0", Offset = "0x110B8D0", VA = "0x18110CED0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			if (HasActivationCondition || HasLimboActivationCondition)
			{
				CreateEventHandler();
				int conditionListener = 0;
				OnAnyConditionChanged((ConditionListener)conditionListener);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEF")]
		[Cpp2IlInjected.Address(RVA = "0x110CF20", Offset = "0x110B920", VA = "0x18110CF20", Slot = "5")]
		public override void OnSystemStop()
		{
			//IL_001a: Expected O, but got I8
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			if (isLimboActive)
			{
				int active = 0;
				GraphicSettings.ActivateRenderPass("Limbo Post Process", (byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF4")]
		[Cpp2IlInjected.Address(RVA = "0x110BDA0", Offset = "0x110A7A0", VA = "0x18110BDA0")]
		public bool MustBeInside(Item characterItem)
		{
			//Discarded unreachable code: IL_0017
			//IL_0013: Expected O, but got I4
			int itemID = characterItem.ItemID;
			return !((List<T>)(object)notAffectedCharacters).Contains((T)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF5")]
		[Cpp2IlInjected.Address(RVA = "0x110BE00", Offset = "0x110A800", VA = "0x18110BE00")]
		public bool MustBlockBuilding(Item buildingItem)
		{
			//Discarded unreachable code: IL_0017
			//IL_0013: Expected O, but got I4
			int itemID = buildingItem.ItemID;
			return !((List<T>)(object)notAffectedBuildings).Contains((T)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF6")]
		[Cpp2IlInjected.Address(RVA = "0x110BE60", Offset = "0x110A860", VA = "0x18110BE60")]
		public bool MustBlockItem(Item item)
		{
			//Discarded unreachable code: IL_0017
			//IL_0013: Expected O, but got I4
			int itemID = item.ItemID;
			return !((List<T>)(object)notAffectedItems).Contains((T)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF7")]
		[Cpp2IlInjected.Address(RVA = "0x110B150", Offset = "0x1109B50", VA = "0x18110B150")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)activationCondition);
			long num3 = Convert.ToInt64((uint)limboActivationCondition);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF8")]
		[Cpp2IlInjected.Address(RVA = "0x83B250", Offset = "0x839C50", VA = "0x18083B250")]
		private void DisposeEventHandler()
		{
			while (true)
			{
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF9")]
		[Cpp2IlInjected.Address(RVA = "0x110BEC0", Offset = "0x110A8C0", VA = "0x18110BEC0")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			if (HasActivationCondition)
			{
				bool flag = isActive;
				int num = activationCondition;
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client metaClient2 = SystemRoot.Instance.MetaClient;
				bool flag2 = default(bool);
				isActive = flag2;
				if (flag2 != flag)
				{
					if (!flag2)
					{
						AudioManager audioManager = default(AudioManager);
						audioManager.SetVillageState(isCursedLifted: true);
						Deactivate();
					}
					if ((long)avatarMaterials == 0)
					{
					}
					int villageState = 0;
					AudioManager audioManager2 = default(AudioManager);
					audioManager2.SetVillageState((byte)villageState != 0);
					int num2 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
			}
			bool flag3 = debugGhostMode;
			bool flag4 = isLimboActive;
			isLimboActive = flag3;
			if (HasLimboActivationCondition)
			{
				if (isLimboActive)
				{
				}
				int num3 = limboActivationCondition;
				bool flag5 = default(bool);
				isLimboActive = flag5;
			}
			if (isLimboActive != flag4)
			{
				SystemRoot.Instance.GetSystem<AudioManager>().SetVillageState(isCursedLifted: true);
				if (isLimboActive)
				{
					int num4 = 0;
					Task asyncTask2 = default(Task);
					asyncTask2.FireAndForgetTask();
					throw new NullReferenceException();
				}
				DeactivateLimbo();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFA")]
		[Cpp2IlInjected.Address(RVA = "0x110AFF0", Offset = "0x11099F0", VA = "0x18110AFF0")]
		[AsyncStateMachine(typeof(_003CActivate_003Ed__59))]
		private Task Activate()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFB")]
		[Cpp2IlInjected.Address(RVA = "0x110B980", Offset = "0x110A380", VA = "0x18110B980")]
		private void Deactivate()
		{
			//Discarded unreachable code: IL_0042
			int num = 0;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.GridChanged value = OnGridChanged;
			_003CDispatcher_003Ek__BackingField.OnGridChanged -= value;
			SystemRoot.Instance.GetSystem<CharacterManager>().UpdateScheduleOnNextSceneEntered();
			List<GameObject> list = doorsVfx;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFC")]
		[Cpp2IlInjected.Address(RVA = "0x110C770", Offset = "0x110B170", VA = "0x18110C770")]
		private void OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [global::System.Runtime.InteropServices.Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_00a4
			//IL_006a: Expected O, but got I4
			//IL_006a: Expected O, but got I4
			if (operation != 0)
			{
				return;
			}
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			GameObject gameObject = default(GameObject);
			GridScript[] componentsInChildren = gameObject.GetComponentsInChildren<GridScript>();
			Func<GridScript, bool> func = (Func<GridScript, bool>)(object)(Func<T, TResult>)delegate(GridScript x)
			{
				//Discarded unreachable code: IL_0021
				uint gridID = x.GridID;
				IGrid grid2 = grid;
				int num5 = 0;
				uint num6 = default(uint);
				if (num5 < (int)num6)
				{
					num5 += num5;
					num5++;
				}
				return gridID == gridID;
			};
			GridScript gridScript = Enumerable.FirstOrDefault<GridScript>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
			int num = 0;
			if ((object)gridScript != null)
			{
				uint iD_ = gridObject.iD_;
				GridObjectScript gridObjectScript = gridScript.GetGridObjectScript(iD_);
			}
			int num2 = 0;
			if (!((UnityEngine.Object)num == (UnityEngine.Object)num2))
			{
				GameObject gameObject2 = default(GameObject);
				PlayerTaskCollider[] componentsInChildren2 = gameObject2.GetComponentsInChildren<PlayerTaskCollider>();
				int length = componentsInChildren2.Length;
				if (num < length)
				{
					PlayerTaskCollider playerTaskCollider = componentsInChildren2[num];
					int num3 = 0;
					int num4 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFD")]
		[Cpp2IlInjected.Address(RVA = "0x110E1A0", Offset = "0x110CBA0", VA = "0x18110E1A0")]
		[AsyncStateMachine(typeof(_003CSetupPlayerTaskCollider_003Ed__62))]
		private Task SetupPlayerTaskCollider(PlayerTaskCollider playerTaskCollider)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFE")]
		[Cpp2IlInjected.Address(RVA = "0x110AE60", Offset = "0x1109860", VA = "0x18110AE60")]
		[AsyncStateMachine(typeof(_003CActivateLimbo_003Ed__63))]
		private Task ActivateLimbo()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFF")]
		[Cpp2IlInjected.Address(RVA = "0x110B3A0", Offset = "0x1109DA0", VA = "0x18110B3A0")]
		private unsafe void DeactivateLimbo()
		{
			//Discarded unreachable code: IL_0138
			//IL_0032: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_0137: Expected O, but got I4
			int num = 0;
			PlayerAvatar playerAvatar = SystemRoot.Instance._avatar;
			SetupCurrentScene();
			int active = 0;
			GraphicSettings.ActivateRenderPass("Limbo Post Process", (byte)active != 0);
			UnityEngine.Object.Destroy(limboVfx);
			limboVfx = (GameObject)num;
			Renderer[] componentsInChildren = playerAvatar.GetComponentsInChildren<Renderer>();
			int length = componentsInChildren.Length;
			if (num < length)
			{
				Dictionary<Renderer, List<Material>> dictionary = avatarMaterials;
				Renderer renderer = componentsInChildren[num];
				if (((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)renderer, out *(TValue*)num))
				{
					Material[] materialArray = default(Material[]);
					renderer.SetMaterialArray(materialArray);
				}
				num++;
			}
			avatarMaterials = (Dictionary<Renderer, List<Material>>)num;
			UnityEngine.Object.Destroy(tileSpawner);
			tileSpawner = (GameObject)num;
			if (HasLimboActivationCondition)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				CharacterManager.CharacterLoaded value = OnCharacterLoaded;
				system.OnCharacterLoaded -= value;
				CritterManager system2 = SystemRoot.Instance.GetSystem<CritterManager>();
				EventHandler<Mdl.Characters.Critters.Critter> value2 = (EventHandler<Mdl.Characters.Critters.Critter>)(object)new EventHandler<TEventArgs>(OnCritterLoaded);
				EventHandler<Mdl.Characters.Critters.Critter> onCritterLoaded = system2.OnCritterLoaded;
				Delegate @delegate = Delegate.Remove(onCritterLoaded, value2);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				while ((object)@delegate != onCritterLoaded)
				{
				}
			}
			AK.Wwise.Event @event = stopLimboSfx;
			GameObject audioEmitter = SystemRoot.Instance._avatar.AudioController.audioEmitter;
			uint num2 = @event.Post(audioEmitter);
			EventHandler<bool> limboStateChanged = this.LimboStateChanged;
			if (limboStateChanged != null)
			{
				int num3 = 0;
				limboStateChanged(this, (TEventArgs)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B00")]
		[Cpp2IlInjected.Address(RVA = "0x110AF80", Offset = "0x1109980", VA = "0x18110AF80")]
		private void ActivateRenderEffects(bool active)
		{
			GraphicSettings.ActivateRenderPass("Limbo Post Process", active);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B01")]
		[Cpp2IlInjected.Address(RVA = "0x110CB90", Offset = "0x110B590", VA = "0x18110CB90")]
		private void OnNewGridObjectEvent(object sender, NewGridObjectEventArgs e)
		{
			//Discarded unreachable code: IL_00af
			int num = 0;
			GameObject gameObject = e.gameObject;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag || !flag2)
			{
				return;
			}
			int price = ((BattlePassReward)(object)e).Price;
			bool flag3 = default(bool);
			if (!flag3)
			{
				return;
			}
			int num2 = 0;
			bool flag4 = default(bool);
			BuildingItemType buildingItemType = default(BuildingItemType);
			ItemType itemType = default(ItemType);
			ItemType itemType2 = default(ItemType);
			ItemType itemType3 = default(ItemType);
			bool flag5 = default(bool);
			GameObject gameObject2 = default(GameObject);
			if ((!flag4 || buildingItemType == BuildingItemType.Garden) && (itemType == ItemType.Building || itemType2 == ItemType.ActivityItem || itemType3 == ItemType.Furniture) && flag5)
			{
				bool ignore = isLimboActive;
				IgnoreNavMeshObstacles(gameObject2, ignore);
			}
			int price2 = ((BattlePassReward)(object)gameObject2).Price;
			ItemType itemType4 = default(ItemType);
			ItemType itemType5 = default(ItemType);
			ItemType itemType6 = default(ItemType);
			if (itemType4 == ItemType.Building || itemType5 == ItemType.ActivityItem || itemType6 == ItemType.Furniture)
			{
				int price3 = ((BattlePassReward)(object)gameObject2).Price;
				bool flag6 = default(bool);
				if (!flag6)
				{
					return;
				}
			}
			if ((isLimboActive ? 1 : 0) == num)
			{
				return;
			}
			int num3 = 0;
			bool flag7 = default(bool);
			if (HasLimboActivationCondition && flag7)
			{
				PlayerTaskCollider.Condition condition = LimboActivationPlayerTaskCondition;
				bool flag8 = default(bool);
				if (!flag8)
				{
					PlayerTaskCollider.Condition condition2 = LimboActivationPlayerTaskCondition;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B02")]
		[Cpp2IlInjected.Address(RVA = "0x110C5B0", Offset = "0x110AFB0", VA = "0x18110C5B0")]
		private void OnCharacterLoaded(Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_003c
			PlayerTaskCollider component = character.gameObject.GetComponent<PlayerTaskCollider>();
			List<PlayerTaskCollider.Condition> activeWhen = component.ActiveWhen;
			PlayerTaskCollider.Condition item = LimboActivationPlayerTaskCondition;
			if (!((List<T>)(object)activeWhen).Contains((T)item))
			{
				List<PlayerTaskCollider.Condition> activeWhen2 = component.ActiveWhen;
				PlayerTaskCollider.Condition item2 = LimboActivationPlayerTaskCondition;
				((List<T>)(object)activeWhen2).Add((T)item2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B03")]
		[Cpp2IlInjected.Address(RVA = "0x110C690", Offset = "0x110B090", VA = "0x18110C690")]
		private void OnCritterLoaded(object sender, Mdl.Characters.Critters.Critter critter)
		{
			//Discarded unreachable code: IL_003c
			PlayerTaskCollider component = critter.gameObject.GetComponent<PlayerTaskCollider>();
			List<PlayerTaskCollider.Condition> activeWhen = component.ActiveWhen;
			PlayerTaskCollider.Condition item = LimboActivationPlayerTaskCondition;
			if (!((List<T>)(object)activeWhen).Contains((T)item))
			{
				List<PlayerTaskCollider.Condition> activeWhen2 = component.ActiveWhen;
				PlayerTaskCollider.Condition item2 = LimboActivationPlayerTaskCondition;
				((List<T>)(object)activeWhen2).Add((T)item2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B05")]
		[Cpp2IlInjected.Address(RVA = "0x110D020", Offset = "0x110BA20", VA = "0x18110D020")]
		private void PlayerHouse_OnActiveRoomChanged(object sender, GameObject newRoom)
		{
			//Discarded unreachable code: IL_0057, IL_0058
			//IL_0049: Expected O, but got I4
			PlayerHouseEnvironment playerHouseEnvironment = playerHouse;
			Dictionary<House.Types.RoomSlot, GameObject> dictionary = configuredRooms;
			bool flag = default(bool);
			if (!flag)
			{
			}
			bool flag3 = default(bool);
			if (!isLimboActive)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
					SetupGridsInChildren(newRoom);
					PlayerHouseEnvironment playerHouseEnvironment2 = playerHouse;
					Dictionary<House.Types.RoomSlot, GameObject> dictionary2 = configuredRooms;
					House.Types.RoomSlot _003CActiveRoomSlot_003Ek__BackingField = playerHouseEnvironment2.ActiveRoomSlot;
					flag3 = ((Dictionary<TKey, TValue>)(object)dictionary2).Remove((TKey)_003CActiveRoomSlot_003Ek__BackingField);
				}
				return;
			}
			while (flag3)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B06")]
		[Cpp2IlInjected.Address(RVA = "0x110CFD0", Offset = "0x110B9D0", VA = "0x18110CFD0")]
		private void PlayerHouse_OnActiveFloorChanged(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_000c
			((Dictionary<TKey, TValue>)(object)configuredRooms).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B07")]
		[Cpp2IlInjected.Address(RVA = "0x110BD90", Offset = "0x110A790", VA = "0x18110BD90")]
		private void Limbo_AnyEnvironmentEnteredEvent(object sender, EventArgs e)
		{
			SetupCurrentScene();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B08")]
		[Cpp2IlInjected.Address(RVA = "0x110D200", Offset = "0x110BC00", VA = "0x18110D200")]
		private void SetupCurrentScene()
		{
			//Discarded unreachable code: IL_015c
			//IL_00cc: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			//IL_0110: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
			SceneData sceneData2 = default(SceneData);
			AsyncOperation operation2 = sceneData2.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig2 = sceneData2.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			PlayerHouseEnvironment playerHouseEnvironment = (playerHouse = gameObject.GetComponent<PlayerHouseEnvironment>());
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag != flag2)
			{
				bool flag3 = default(bool);
				if (!flag3)
				{
					bool flag4 = default(bool);
					if (flag4)
					{
						EventHandler<GameObject> eventHandler = (EventHandler<GameObject>)(object)new EventHandler<TEventArgs>(PlayerHouse_OnActiveRoomChanged);
						EventHandler eventHandler2 = PlayerHouse_OnActiveFloorChanged;
					}
					((Dictionary<TKey, TValue>)(object)configuredRooms).Clear();
				}
				EventHandler<GameObject> eventHandler3 = (EventHandler<GameObject>)(object)new EventHandler<TEventArgs>(PlayerHouse_OnActiveRoomChanged);
				EventHandler eventHandler4 = PlayerHouse_OnActiveFloorChanged;
			}
			int num = 0;
			if ((isLimboActive ? 1 : 0) == num)
			{
				bool flag5 = default(bool);
				if (flag5 && (long)"{il2cpp array field local6->}" != 1)
				{
					goto IL_0110;
				}
				int num2 = 0;
				wasInVillage = (bool?)(object)num2;
				Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= Limbo_AnyEnvironmentEnteredEvent;
			}
			int num3 = 0;
			wasInVillage = (bool?)(object)num;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += Limbo_AnyEnvironmentEnteredEvent;
			if ((long)"{il2cpp array field local6->}" == 1)
			{
				bool flag6 = default(bool);
				if (flag6)
				{
					return;
				}
				wasInVillage = (bool?)(object)num;
			}
			goto IL_0110;
			IL_0110:
			bool flag7 = default(bool);
			if (!flag7)
			{
				GameObject gameObject2 = default(GameObject);
				SetupGridsInChildren(gameObject2);
				return;
			}
			Dictionary<House.Types.RoomSlot, GameObject> dictionary = configuredRooms;
			bool flag8 = default(bool);
			if (!flag8)
			{
			}
			if (!isLimboActive)
			{
				bool flag9 = default(bool);
				while (!flag9)
				{
				}
				GameObject gameObject3 = default(GameObject);
				SetupGridsInChildren(gameObject3);
				Dictionary<House.Types.RoomSlot, GameObject> dictionary2 = configuredRooms;
			}
			bool flag10 = default(bool);
			while (flag10)
			{
			}
			Dictionary<House.Types.RoomSlot, GameObject> dictionary3 = configuredRooms;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B09")]
		[Cpp2IlInjected.Address(RVA = "0x110DF40", Offset = "0x110C940", VA = "0x18110DF40")]
		private void SetupGridsInChildren(GameObject gameObject)
		{
			//Discarded unreachable code: IL_00bb
			GridScript[] componentsInChildren = gameObject.GetComponentsInChildren<GridScript>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				GridScript gridScript = componentsInChildren[num];
				EventHandler<NewGridObjectEventArgs> eventHandler = (EventHandler<NewGridObjectEventArgs>)(object)new EventHandler<TEventArgs>(OnNewGridObjectEvent);
				gridScript.remove_NewGridObjectAddedEvent((EventHandler<>)(object)eventHandler);
				if (gridScript.HasDistanceCulling)
				{
					EventHandler<NewGridObjectEventArgs> eventHandler2 = (EventHandler<NewGridObjectEventArgs>)(object)new EventHandler<TEventArgs>(OnNewGridObjectEvent);
					gridScript.remove_NewGridObjectLoadedEvent((EventHandler<>)(object)eventHandler2);
				}
				num++;
				int num2 = 0;
				GridScript[] array = default(GridScript[]);
				int length2 = array.Length;
				if (num2 < length2)
				{
					GridScript gridScript2 = array[num2];
					EventHandler<NewGridObjectEventArgs> eventHandler3 = (EventHandler<NewGridObjectEventArgs>)(object)new EventHandler<TEventArgs>(OnNewGridObjectEvent);
					gridScript2.add_NewGridObjectAddedEvent((EventHandler<>)(object)eventHandler3);
					if (gridScript2.HasDistanceCulling)
					{
						EventHandler<NewGridObjectEventArgs> eventHandler4 = (EventHandler<NewGridObjectEventArgs>)(object)new EventHandler<TEventArgs>(OnNewGridObjectEvent);
						gridScript2.add_NewGridObjectLoadedEvent((EventHandler<>)(object)eventHandler4);
					}
					num2++;
				}
			}
			SetupGridObjectsInChildren(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B0A")]
		[Cpp2IlInjected.Address(RVA = "0x110DD30", Offset = "0x110C730", VA = "0x18110DD30")]
		private void SetupGridObjectsInChildren(GameObject gameObject)
		{
			//Discarded unreachable code: IL_006d, IL_0073, IL_0079, IL_007f, IL_0085
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			GridObjectScript[] componentsInChildren = gameObject.GetComponentsInChildren<GridObjectScript>();
			int length = componentsInChildren.Length;
			if (num3 < length)
			{
				GridObjectScript gridObjectScript = componentsInChildren[num3];
				SetupGridObject(gridObjectScript);
				num3++;
			}
			List<GameObject> list = limboGameObjects;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = isLimboActive;
				NavMeshObstacle[] array = default(NavMeshObstacle[]);
				while (num3 >= array.Length)
				{
				}
				NavMeshObstacle navMeshObstacle = array[num3];
				bool flag4 = (navMeshObstacle.enabled = !flag2);
				num3++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B0B")]
		[Cpp2IlInjected.Address(RVA = "0x110DA50", Offset = "0x110C450", VA = "0x18110DA50")]
		private unsafe void SetupGridObject(GridObjectScript gridObjectScript)
		{
			//Discarded unreachable code: IL_00aa
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			int price = ((BattlePassReward)(object)gridObjectScript).Price;
			bool flag2 = default(bool);
			if (!flag2)
			{
				return;
			}
			int num = 0;
			bool flag3 = default(bool);
			BuildingItemType buildingItemType = default(BuildingItemType);
			ItemType itemType = default(ItemType);
			ItemType itemType2 = default(ItemType);
			ItemType itemType3 = default(ItemType);
			bool flag4 = default(bool);
			GameObject gameObject = default(GameObject);
			if ((!flag3 || buildingItemType == BuildingItemType.Garden) && (itemType == ItemType.Building || itemType2 == ItemType.ActivityItem || itemType3 == ItemType.Furniture) && flag4)
			{
				gameObject = gridObjectScript.gameObject;
				bool ignore = isLimboActive;
				IgnoreNavMeshObstacles(gameObject, ignore);
			}
			int price2 = ((BattlePassReward)(object)gameObject).Price;
			ItemType itemType4 = default(ItemType);
			ItemType itemType5 = default(ItemType);
			ItemType itemType6 = default(ItemType);
			if (itemType4 == ItemType.Building || itemType5 == ItemType.ActivityItem || itemType6 == ItemType.Furniture)
			{
				int price3 = ((BattlePassReward)(object)gameObject).Price;
				bool flag5 = default(bool);
				if (!flag5)
				{
					return;
				}
			}
			if (!isLimboActive)
			{
				return;
			}
			int num2 = 0;
			if (HasLimboActivationCondition && gridObjectScript.TryGetComponent<PlayerTaskCollider>(out *(PlayerTaskCollider*)num2))
			{
				PlayerTaskCollider.Condition condition = LimboActivationPlayerTaskCondition;
				bool flag6 = default(bool);
				if (!flag6)
				{
					PlayerTaskCollider.Condition condition2 = LimboActivationPlayerTaskCondition;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B0C")]
		[Cpp2IlInjected.Address(RVA = "0x110BC90", Offset = "0x110A690", VA = "0x18110BC90")]
		private static void IgnoreNavMeshObstacles(GameObject gameObject, bool ignore)
		{
			//Discarded unreachable code: IL_0026
			NavMeshObstacle[] componentsInChildren = gameObject.GetComponentsInChildren<NavMeshObstacle>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				componentsInChildren[num].enabled = ignore;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B0D")]
		[Cpp2IlInjected.Address(RVA = "0x110E2D0", Offset = "0x110CCD0", VA = "0x18110E2D0")]
		public CurseSystem()
		{
		}
	}
}
