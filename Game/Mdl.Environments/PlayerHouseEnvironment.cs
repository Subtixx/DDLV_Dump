using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Grid;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000665")]
	public class PlayerHouseEnvironment : Environment
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000666")]
		public class RoomSlotPosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400261F")]
			public House.Types.RoomSlot RoomSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002620")]
			public Transform RoomTransform;

			[Cpp2IlInjected.Token(Token = "0x6001C8E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RoomSlotPosition()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002616")]
		[SerializeField]
		private List<RoomSlotPosition> _roomSlots = (List<RoomSlotPosition>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002617")]
		[SerializeField]
		private GameObject _exitPortal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400261A")]
		private readonly Dictionary<House.Types.RoomSlot, GameObject> loadedRooms = (Dictionary<House.Types.RoomSlot, GameObject>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400261E")]
		private OrphanHandleContainer orphanHandleContainer;

		[Cpp2IlInjected.Token(Token = "0x170003FF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x90"), Cpp2IlInjected.Token(Token = "0x4002618")]
		public int ActiveFloorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6001C74")]
			[Cpp2IlInjected.Address(RVA = "0x725190", Offset = "0x723B90", VA = "0x180725190")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001C75")]
			[Cpp2IlInjected.Address(RVA = "0x725370", Offset = "0x723D70", VA = "0x180725370")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000400")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x94"), Cpp2IlInjected.Token(Token = "0x4002619")]
		public House.Types.RoomSlot ActiveRoomSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6001C76")]
			[Cpp2IlInjected.Address(RVA = "0xA8E090", Offset = "0xA8CA90", VA = "0x180A8E090")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001C77")]
			[Cpp2IlInjected.Address(RVA = "0xA8E170", Offset = "0xA8CB70", VA = "0x180A8E170")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000401")]
		public GameObject ActiveRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6001C78")]
			[Cpp2IlInjected.Address(RVA = "0x14BEFC0", Offset = "0x14BD9C0", VA = "0x1814BEFC0")]
			get
			{
				//IL_0016: Expected O, but got I4
				int num = 0;
				House.Types.RoomSlot roomSlot = ActiveRoomSlot;
				House.Types.RoomSlot valueOrDefault = MoreLinq.GetValueOrDefault<House.Types.RoomSlot, GameObject>((IReadOnlyDictionary<, >)loadedRooms, (GameObject)roomSlot, (House.Types.RoomSlot)num);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000402")]
		public override IEnumerable<GridScript> GridScriptsList
		{
			[Cpp2IlInjected.Token(Token = "0x6001C79")]
			[Cpp2IlInjected.Address(RVA = "0x14BF010", Offset = "0x14BDA10", VA = "0x1814BF010", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_0033
				Dictionary<House.Types.RoomSlot, GameObject>.ValueCollection values = (Dictionary<House.Types.RoomSlot, GameObject>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)loadedRooms).get_Values();
				Func<GameObject, GridScript> _003C_003E9__18_ = _003C_003Ec._003C_003E9__18_0;
				if (_003C_003E9__18_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GameObject x) => x.GetComponent<GridScript>());
				}
				return (IEnumerable<GridScript>)Enumerable.Select<GameObject, GridScript>((IEnumerable<>)(object)values, (Func<, >)(object)_003C_003E9__18_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000041")]
		public event EventHandler<GameObject> OnRoomLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6001C7A")]
			[Cpp2IlInjected.Address(RVA = "0x14BEF20", Offset = "0x14BD920", VA = "0x1814BEF20")]
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
			[Cpp2IlInjected.Token(Token = "0x6001C7B")]
			[Cpp2IlInjected.Address(RVA = "0x14BF2B0", Offset = "0x14BDCB0", VA = "0x1814BF2B0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000042")]
		public event EventHandler<GameObject> OnActiveRoomChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6001C7C")]
			[Cpp2IlInjected.Address(RVA = "0x14BEE80", Offset = "0x14BD880", VA = "0x1814BEE80")]
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
			[Cpp2IlInjected.Token(Token = "0x6001C7D")]
			[Cpp2IlInjected.Address(RVA = "0x14BF210", Offset = "0x14BDC10", VA = "0x1814BF210")]
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

		[Cpp2IlInjected.Token(Token = "0x14000043")]
		public event EventHandler OnActiveFloorChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6001C7E")]
			[Cpp2IlInjected.Address(RVA = "0x14BEDE0", Offset = "0x14BD7E0", VA = "0x1814BEDE0")]
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
			[Cpp2IlInjected.Token(Token = "0x6001C7F")]
			[Cpp2IlInjected.Address(RVA = "0x14BF170", Offset = "0x14BDB70", VA = "0x1814BF170")]
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

		[Cpp2IlInjected.Token(Token = "0x6001C71")]
		[Cpp2IlInjected.Address(RVA = "0x14BDD50", Offset = "0x14BC750", VA = "0x1814BDD50")]
		[AsyncStateMachine(typeof(_003CExpandRoom_003Ed__0))]
		public Task<ExpandPlayerHouseRoom.Types.Result> ExpandRoom(int floorIndex, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ExpandPlayerHouseRoom.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C72")]
		[Cpp2IlInjected.Address(RVA = "0x14BE490", Offset = "0x14BCE90", VA = "0x1814BE490")]
		[AsyncStateMachine(typeof(_003CManageRoom_003Ed__1))]
		public Task<ManagePlayerHouseRoom.Types.Result?> ManageRoom(int floorIndex, House.Types.RoomSlot roomSlot, int? additionalRoomIndex, string roomName, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<ManagePlayerHouseRoom.Types.Result?>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C73")]
		[Cpp2IlInjected.Address(RVA = "0x14BD970", Offset = "0x14BC370", VA = "0x1814BD970")]
		[AsyncStateMachine(typeof(_003CAddFloor_003Ed__2))]
		public Task<AddPlayerHouseFloor.Types.Result> AddFloor(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AddPlayerHouseFloor.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C80")]
		[Cpp2IlInjected.Address(RVA = "0x14BE080", Offset = "0x14BCA80", VA = "0x1814BE080", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__29))]
		protected override Task Init(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C81")]
		[Cpp2IlInjected.Address(RVA = "0x14BDA90", Offset = "0x14BC490", VA = "0x1814BDA90", Slot = "5")]
		internal override Task EnterEnvironment(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0021
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			GridEditMode.GridEditModeFinishedDelegate value = OnGridEditModeFinishedEvent;
			system.GridEditModeFinishedEvent += value;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C82")]
		[Cpp2IlInjected.Address(RVA = "0x14BDBF0", Offset = "0x14BC5F0", VA = "0x1814BDBF0", Slot = "7")]
		internal override Task ExitEnvironment(Profile profile, PlayerAvatar avatar, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			GridEditMode.GridEditModeFinishedDelegate value = OnGridEditModeFinishedEvent;
			system.GridEditModeFinishedEvent -= value;
			return base.ExitEnvironment(profile, avatar, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C83")]
		[Cpp2IlInjected.Address(RVA = "0x14BDEA0", Offset = "0x14BC8A0", VA = "0x1814BDEA0", Slot = "12")]
		public override GridScript GetCurrentGrid(Vector3 position, out bool voidGrid)
		{
			//Discarded unreachable code: IL_0010
			Dictionary<House.Types.RoomSlot, GameObject> dictionary = loadedRooms;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
			}
			GridScript result = default(GridScript);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C84")]
		[Cpp2IlInjected.Address(RVA = "0x14BE9F0", Offset = "0x14BD3F0", VA = "0x1814BE9F0")]
		[AsyncStateMachine(typeof(_003CSwitchActiveRoom_003Ed__33))]
		internal Task SwitchActiveRoom(House.Types.RoomSlot slotDestination, PlayerAvatar avatar)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C85")]
		[Cpp2IlInjected.Address(RVA = "0x14BE8E0", Offset = "0x14BD2E0", VA = "0x1814BE8E0")]
		[AsyncStateMachine(typeof(_003CSwitchActiveFloor_003Ed__34))]
		internal Task SwitchActiveFloor(int floorIndex)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C86")]
		[Cpp2IlInjected.Address(RVA = "0x14BDF40", Offset = "0x14BC940", VA = "0x1814BDF40")]
		[AsyncStateMachine(typeof(_003CInitExpandedRoom_003Ed__35))]
		public Task<GameObject> InitExpandedRoom(House.Types.RoomSlot roomSlot, bool switchActiveRoom)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C87")]
		[Cpp2IlInjected.Address(RVA = "0x14BE340", Offset = "0x14BCD40", VA = "0x1814BE340")]
		[AsyncStateMachine(typeof(_003CLoadRoom_003Ed__36))]
		private Task<GameObject> LoadRoom(House.Types.Room room, House.Types.RoomSlot roomSlot)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C88")]
		[Cpp2IlInjected.Address(RVA = "0x14BE1F0", Offset = "0x14BCBF0", VA = "0x1814BE1F0")]
		[AsyncStateMachine(typeof(_003CLoadFloor_003Ed__37))]
		private Task LoadFloor(int floorIndex, House.Types.Floor floor, PlayerAvatar avatar)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C89")]
		[Cpp2IlInjected.Address(RVA = "0x14BEBF0", Offset = "0x14BD5F0", VA = "0x1814BEBF0")]
		[AsyncStateMachine(typeof(_003CUpdateTrimming_003Ed__38))]
		private static Task UpdateTrimming(House.Types.Room room, GameObject roomRoot)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C8A")]
		[Cpp2IlInjected.Address(RVA = "0x14BE610", Offset = "0x14BD010", VA = "0x1814BE610")]
		private void OnGridEditModeFinishedEvent(bool confirm)
		{
			//Discarded unreachable code: IL_005a
			//IL_004d: Expected O, but got I4
			RepeatedField<House.Types.Floor> floors_ = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.floors_;
			int index = ActiveFloorIndex;
			MapField<int, House.Types.Room> rooms_ = ((House.Types.Floor)((RepeatedField<T>)(object)floors_)[index]).rooms_;
			int num = 0;
			House.Types.RoomSlot roomSlot = ActiveRoomSlot;
			House.Types.RoomSlot valueOrDefault = MoreLinq.GetValueOrDefault<House.Types.RoomSlot, GameObject>((IReadOnlyDictionary<, >)loadedRooms, (GameObject)roomSlot, (House.Types.RoomSlot)num);
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C8B")]
		[Cpp2IlInjected.Address(RVA = "0x14BED10", Offset = "0x14BD710", VA = "0x1814BED10")]
		public PlayerHouseEnvironment()
		{
		}
	}
}
