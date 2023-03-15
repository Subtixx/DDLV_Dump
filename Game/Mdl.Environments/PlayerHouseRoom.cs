using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Google.Protobuf.Collections;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000673")]
	internal class PlayerHouseRoom : MonoBehaviour, IPlayerTaskData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000674")]
		public class RoomSlotToEnableDisable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400267A")]
			public List<House.Types.RoomSlot> RoomSlots = (List<House.Types.RoomSlot>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400267B")]
			public int NumberOfFloors = -1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400267C")]
			public List<GameObject> ToEnable = (List<GameObject>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400267D")]
			public List<GameObject> ToDisable = (List<GameObject>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x6001CB0")]
			[Cpp2IlInjected.Address(RVA = "0x1692310", Offset = "0x1690D10", VA = "0x181692310")]
			public RoomSlotToEnableDisable()
			{
			}//IL_001d: Expected I4, but got I8

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002678")]
		[SerializeField]
		private List<RoomSlotToEnableDisable> _visualSettings = (List<RoomSlotToEnableDisable>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002679")]
		private House.Types.RoomSlot? _roomSlot;

		[Cpp2IlInjected.Token(Token = "0x17000403")]
		public unsafe House.Types.RoomSlot RoomSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6001CA8")]
			[Cpp2IlInjected.Address(RVA = "0x14BFC50", Offset = "0x14BE650", VA = "0x1814BFC50")]
			get
			{
				House.Types.RoomSlot? roomSlot = _roomSlot;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CA9")]
			[Cpp2IlInjected.Address(RVA = "0x14BFC90", Offset = "0x14BE690", VA = "0x1814BFC90")]
			set
			{
				//Discarded unreachable code: IL_004a
				//IL_0017: Expected O, but got I8
				House.Types.RoomSlot? roomSlot = _roomSlot;
				if ((IntPtr)(((IntPtr)(void*)roomSlot == (IntPtr)(void*)(int)value) ? 1 : 0) == (IntPtr)(void*)roomSlot)
				{
					ulong num = default(ulong);
					_roomSlot = (House.Types.RoomSlot?)(object)num;
					int count = ((RepeatedField<T>)(object)SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.floors_).Count;
					House.Types.RoomSlot roomSlot2 = default(House.Types.RoomSlot);
					int num2 = (int)roomSlot2;
					int num3 = 0;
					int num4 = 0;
					House.Types.RoomSlot roomSlot3 = default(House.Types.RoomSlot);
					int num5 = (int)roomSlot3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAA")]
		[Cpp2IlInjected.Address(RVA = "0x14BF720", Offset = "0x14BE120", VA = "0x1814BF720")]
		private void Start()
		{
			//Discarded unreachable code: IL_0025
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PlayerHouseFloorAdded value = OnPlayerHouseFloorAdded;
			_003CDispatcher_003Ek__BackingField.OnPlayerHouseFloorAdded += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAB")]
		[Cpp2IlInjected.Address(RVA = "0x14BF350", Offset = "0x14BDD50", VA = "0x1814BF350")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0045
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerHouseFloorAdded value = OnPlayerHouseFloorAdded;
					_003CDispatcher_003Ek__BackingField.OnPlayerHouseFloorAdded -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAC")]
		[Cpp2IlInjected.Address(RVA = "0x14BF510", Offset = "0x14BDF10", VA = "0x1814BF510")]
		private void OnPlayerHouseFloorAdded([Optional] CurrencyCost cost)
		{
			//Discarded unreachable code: IL_0030
			int num = ((RepeatedField<T>)(object)SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.floors_).Count - 1;
			House.Types.RoomSlot roomSlot = default(House.Types.RoomSlot);
			int num2 = (int)roomSlot;
			int num3 = 0;
			House.Types.RoomSlot roomSlot2 = default(House.Types.RoomSlot);
			int num4 = (int)roomSlot2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAD")]
		[Cpp2IlInjected.Address(RVA = "0x14BF960", Offset = "0x14BE360", VA = "0x1814BF960")]
		private unsafe void UpdateVisual((House.Types.RoomSlot roomSlot, int numberOfFloors)? previous, (House.Types.RoomSlot roomSlot, int numberOfFloors) current)
		{
			//Discarded unreachable code: IL_00ef
			//IL_0012: Expected I4, but got O
			//IL_000d: Expected native int or pointer, but got O
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			((Nullable<>*)(IntPtr)CS_0024_003C_003E8__locals0.previous)->has_value = (byte)(int)CS_0024_003C_003E8__locals0 != 0;
			CS_0024_003C_003E8__locals0.current = current;
			if ((long)CS_0024_003C_003E8__locals0 != 0)
			{
				List<RoomSlotToEnableDisable> visualSettings = _visualSettings;
				Predicate<RoomSlotToEnableDisable> predicate = (Predicate<RoomSlotToEnableDisable>)(object)(Predicate<T>)delegate(RoomSlotToEnableDisable x)
				{
					//Discarded unreachable code: IL_001f
					//IL_000e: Expected I4, but got O
					//IL_0015: Expected O, but got I4
					List<House.Types.RoomSlot> roomSlots4 = x.RoomSlots;
					(House.Types.RoomSlot, int) tuple2 = default((House.Types.RoomSlot, int));
					House.Types.RoomSlot roomSlot2 = (House.Types.RoomSlot)((ValueTuple<, >*)(&tuple2))->Item1;
					bool flag4 = ((List<T>)(object)roomSlots4).Contains((T)roomSlot2);
					bool flag5 = default(bool);
					return (!flag4) ? flag4 : flag5;
				};
				RoomSlotToEnableDisable roomSlotToEnableDisable = (RoomSlotToEnableDisable)((List<T>)(object)visualSettings).Find((Predicate<>)(object)predicate);
				if (roomSlotToEnableDisable == null)
				{
					List<RoomSlotToEnableDisable> visualSettings2 = _visualSettings;
					Predicate<RoomSlotToEnableDisable> predicate2 = (Predicate<RoomSlotToEnableDisable>)(object)(Predicate<T>)delegate(RoomSlotToEnableDisable x)
					{
						//Discarded unreachable code: IL_0026
						//IL_000e: Expected I4, but got O
						//IL_0015: Expected O, but got I4
						List<House.Types.RoomSlot> roomSlots3 = x.RoomSlots;
						(House.Types.RoomSlot, int) tuple = default((House.Types.RoomSlot, int));
						House.Types.RoomSlot roomSlot = (House.Types.RoomSlot)((ValueTuple<, >*)(&tuple))->Item1;
						bool flag3 = ((List<T>)(object)roomSlots3).Contains((T)roomSlot);
						return (!flag3) ? flag3 : (x.NumberOfFloors == -1);
					};
					RoomSlotToEnableDisable roomSlotToEnableDisable2 = (RoomSlotToEnableDisable)((List<T>)(object)visualSettings2).Find((Predicate<>)(object)predicate2);
				}
				if (roomSlotToEnableDisable != null)
				{
					PlayerHouseRoom._003CUpdateVisual_003Eg__ApplyValue_007C9_0((List<>)(object)roomSlotToEnableDisable.ToDisable, true);
					List<GameObject> toEnable = roomSlotToEnableDisable.ToEnable;
					int num = 0;
					PlayerHouseRoom._003CUpdateVisual_003Eg__ApplyValue_007C9_0((List<>)(object)toEnable, (byte)num != 0);
				}
			}
			List<RoomSlotToEnableDisable> visualSettings3 = _visualSettings;
			Predicate<RoomSlotToEnableDisable> predicate3 = (Predicate<RoomSlotToEnableDisable>)(object)(Predicate<T>)delegate(RoomSlotToEnableDisable x)
			{
				//Discarded unreachable code: IL_0017
				List<House.Types.RoomSlot> roomSlots2 = x.RoomSlots;
				bool flag2 = default(bool);
				return (!flag2) ? flag2 : (x.NumberOfFloors == (flag2 ? 1 : 0));
			};
			RoomSlotToEnableDisable roomSlotToEnableDisable3 = default(RoomSlotToEnableDisable);
			if (((List<T>)(object)visualSettings3).Find((Predicate<>)(object)predicate3) == null)
			{
				List<RoomSlotToEnableDisable> visualSettings4 = _visualSettings;
				Predicate<RoomSlotToEnableDisable> predicate4 = (Predicate<RoomSlotToEnableDisable>)(object)(Predicate<T>)delegate(RoomSlotToEnableDisable x)
				{
					//Discarded unreachable code: IL_0017
					List<House.Types.RoomSlot> roomSlots = x.RoomSlots;
					bool flag = default(bool);
					return (!flag) ? flag : (x.NumberOfFloors == -1);
				};
				roomSlotToEnableDisable3 = (RoomSlotToEnableDisable)((List<T>)(object)visualSettings4).Find((Predicate<>)(object)predicate4);
			}
			if (roomSlotToEnableDisable3 != null)
			{
				List<GameObject> toDisable = roomSlotToEnableDisable3.ToDisable;
				int num2 = 0;
				PlayerHouseRoom._003CUpdateVisual_003Eg__ApplyValue_007C9_0((List<>)(object)toDisable, (byte)num2 != 0);
				PlayerHouseRoom._003CUpdateVisual_003Eg__ApplyValue_007C9_0((List<>)(object)roomSlotToEnableDisable3.ToEnable, true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAE")]
		[Cpp2IlInjected.Address(RVA = "0x14BFBD0", Offset = "0x14BE5D0", VA = "0x1814BFBD0")]
		public PlayerHouseRoom()
		{
		}
	}
}
