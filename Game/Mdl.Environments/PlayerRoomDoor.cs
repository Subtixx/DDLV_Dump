using System;
using System.Collections.Generic;
using System.Linq;
using AK.Wwise;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000676")]
	public class PlayerRoomDoor : GridObjectStateUser, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002680")]
		[SerializeField]
		private AK.Wwise.Event sfxDoor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002681")]
		[SerializeField]
		private Switch doorSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002682")]
		private House.Types.RoomSlot? slotDestination;

		[Cpp2IlInjected.Token(Token = "0x17000404")]
		public House.Types.RoomSlot SlotDestination
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB6")]
			[Cpp2IlInjected.Address(RVA = "0x14D12F0", Offset = "0x14CFCF0", VA = "0x1814D12F0")]
			get
			{
				//IL_000e: Expected O, but got I8
				int num = (int)SelectRoomSlot();
				ulong num2 = default(ulong);
				slotDestination = (House.Types.RoomSlot?)(object)num2;
				House.Types.RoomSlot result = default(House.Types.RoomSlot);
				return result;
				[Cpp2IlInjected.Token(Token = "0x6001CBA")]
				[Cpp2IlInjected.Address(RVA = "0x14D0F30", Offset = "0x14CF930", VA = "0x1814D0F30")]
				House.Types.RoomSlot SelectRoomSlot()
				{
					SceneStack sceneStack = SystemRoot.Instance._sceneStack;
					SceneData sceneData = default(SceneData);
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					GameObject gameObject = default(GameObject);
					PlayerHouseEnvironment component = gameObject.GetComponent<PlayerHouseEnvironment>();
					if ((long)GetComponentInParent<PlayerHouseRoom>()._roomSlot != 0)
					{
						int num3 = 0;
					}
					RepeatedField<House.Types.Floor> floors_ = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.floors_;
					int _003CActiveFloorIndex_003Ek__BackingField = component.ActiveFloorIndex;
					MapField<int, House.Types.Room> rooms_ = ((House.Types.Floor)((RepeatedField<T>)(object)floors_)[_003CActiveFloorIndex_003Ek__BackingField]).rooms_;
					House.Types.Room room = default(House.Types.Room);
					MapField<int, uint> wallGridIDs_ = room.wallGridIDs_;
					Func<KeyValuePair<int, uint>, bool> func = (Func<KeyValuePair<int, uint>, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0013
						uint gridID = base.GridObjectScript.GridScript.GridID;
						bool result2 = default(bool);
						return result2;
					};
					KeyValuePair<int, uint> keyValuePair = Enumerable.FirstOrDefault<KeyValuePair<int, uint>>((IEnumerable<>)(object)wallGridIDs_, (Func<, >)(object)func);
					if ((object)keyValuePair != null && (object)keyValuePair != null && ((object)keyValuePair == null || (long)keyValuePair != 1))
					{
						InvalidOperationException ex = new InvalidOperationException("We can't reach here");
						/*Error: Unexpected end of block*/;
					}
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB7")]
		[Cpp2IlInjected.Address(RVA = "0x14D09A0", Offset = "0x14CF3A0", VA = "0x1814D09A0", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_00d2
			//IL_00a1: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			PlayerHouseEnvironment component = gameObject.GetComponent<PlayerHouseEnvironment>();
			PlayerHouseRoom componentInParent = GetComponentInParent<PlayerHouseRoom>();
			RepeatedField<House.Types.Floor> floors_ = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.floors_;
			int _003CActiveFloorIndex_003Ek__BackingField = component.ActiveFloorIndex;
			MapField<int, House.Types.Room> rooms_ = ((House.Types.Floor)((RepeatedField<T>)(object)floors_)[_003CActiveFloorIndex_003Ek__BackingField]).rooms_;
			House.Types.Room room = default(House.Types.Room);
			MapField<int, uint> wallGridIDs_ = room.wallGridIDs_;
			Func<KeyValuePair<int, uint>, bool> func = (Func<KeyValuePair<int, uint>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0013
				uint gridID = base.GridObjectScript.GridScript.GridID;
				bool result = default(bool);
				return result;
			};
			if ((long)Enumerable.FirstOrDefault<KeyValuePair<int, uint>>((IEnumerable<>)(object)wallGridIDs_, (Func<, >)(object)func) <= 1)
			{
				Renderer componentInChildren = GetComponentInChildren<Renderer>();
				int num = 0;
				if (componentInChildren != (UnityEngine.Object)num)
				{
					Transform transform = componentInChildren.transform;
					Transform transform2 = componentInChildren.transform;
					Transform transform3 = componentInChildren.transform;
					Transform transform4 = componentInChildren.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB8")]
		[Cpp2IlInjected.Address(RVA = "0x14D0E10", Offset = "0x14CF810", VA = "0x1814D0E10")]
		public void OnDoorTriggered()
		{
			Switch @switch = doorSwitch;
			if (@switch != null)
			{
				GameObject value = base.gameObject;
				@switch.SetValue(value);
			}
			AK.Wwise.Event @event = sfxDoor;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public PlayerRoomDoor()
		{
		}
	}
}
