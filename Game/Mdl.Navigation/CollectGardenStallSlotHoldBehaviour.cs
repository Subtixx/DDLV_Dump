using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Buildings;
using Mdl.Grid;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C43")]
	[CreateAssetMenu]
	internal class CollectGardenStallSlotHoldBehaviour : FindAdjacentObjectHoldBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4004486")]
		private GardenStall gardenStall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4004487")]
		private Vector2Int currentPosition;

		[Cpp2IlInjected.Token(Token = "0x6003842")]
		[Cpp2IlInjected.Address(RVA = "0xA8A440", Offset = "0xA88E40", VA = "0x180A8A440", Slot = "4")]
		public override bool CanUseOn(GameObject go, PlayerTaskDefinition playerTaskDefinition)
		{
			//IL_0057: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				(GridPosition, Vector3)[] array = BaseHoldBehaviour.directions;
				int num = num + num;
				(GridPosition, Vector3) tuple = ((GridPosition, Vector3))((ValueTuple<, >[])(object)array)[num];
				num += num;
				Vector2Int vector2Int = default(Vector2Int);
				tuple = ((GridPosition, Vector3))((object)tuple + (object)vector2Int);
				vector2Int = (Vector2Int)((object)vector2Int + (object)tuple);
				int num2 = 0;
				PlayerTaskCollider playerTaskCollider = default(PlayerTaskCollider);
				if (!(playerTaskCollider != (UnityEngine.Object)num2))
				{
					int length = BaseHoldBehaviour.directions.Length;
					(GridPosition, Vector3) tuple2 = ((GridPosition, Vector3))((object)tuple2 + (object)vector2Int);
					vector2Int = (Vector2Int)((object)vector2Int + (object)tuple2);
					int num3 = 0;
					PlayerTaskCollider playerTaskCollider2 = default(PlayerTaskCollider);
					if (!(playerTaskCollider2 != (UnityEngine.Object)num3))
					{
						int length2 = BaseHoldBehaviour.directions.Length;
						(GridPosition, Vector3) tuple3 = ((GridPosition, Vector3))((object)tuple3 + (object)vector2Int);
						vector2Int = (Vector2Int)((object)vector2Int + (object)tuple3);
						int num4 = 0;
						PlayerTaskCollider playerTaskCollider3 = default(PlayerTaskCollider);
						if (!(playerTaskCollider3 != (UnityEngine.Object)num4))
						{
							int length3 = BaseHoldBehaviour.directions.Length;
							(GridPosition, Vector3) tuple4 = ((GridPosition, Vector3))((object)tuple4 + (object)vector2Int);
							vector2Int = (Vector2Int)((object)vector2Int + (object)tuple4);
							int num5 = 0;
							PlayerTaskCollider playerTaskCollider4 = default(PlayerTaskCollider);
							return playerTaskCollider4 != (UnityEngine.Object)num5;
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003843")]
		[Cpp2IlInjected.Address(RVA = "0xA8A990", Offset = "0xA89390", VA = "0x180A8A990", Slot = "6")]
		public override bool DoUpdate(float dt)
		{
			//IL_0022: Expected O, but got I4
			if (base.DoUpdate(dt))
			{
				PlayerTask currentTask = playerNavigation.CurrentTask;
				int num = 0;
				if (currentTask != (UnityEngine.Object)num)
				{
					GardenStallFakeSlot taskData = playerNavigation.CurrentTask.GetTaskData<GardenStallFakeSlot>();
					RepeatedField<GardenStallData.Types.GardenStallSlot> slots_ = ((GridObjectStateUser)taskData.GardenStall).GridObjectScript.GridObject.state_.GardenStallData.slots_;
					int _003CSlotIndex_003Ek__BackingField = taskData.SlotIndex;
					Item seedItem = ((GardenStallData.Types.GardenStallSlot)((RepeatedField<T>)(object)slots_)[_003CSlotIndex_003Ek__BackingField]).SeedItem;
					SeedItemData seedItemData = default(SeedItemData);
					if (seedItemData != null)
					{
						Client client = default(Client);
						ContainerInventory backpack = client.profile.player_.Backpack;
						Item producedItem = seedItemData.ProducedItem;
						int num2 = 0;
						ContainerInventory.CanAddResult canAddResult = default(ContainerInventory.CanAddResult);
						if (canAddResult != 0)
						{
							goto IL_0098;
						}
					}
				}
				return true;
			}
			goto IL_0098;
			IL_0098:
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003844")]
		[Cpp2IlInjected.Address(RVA = "0xA8AEC0", Offset = "0xA898C0", VA = "0x180A8AEC0", Slot = "8")]
		protected override void SetParametersFromInitialTask(PlayerTask initialTask)
		{
			//Discarded unreachable code: IL_002c
			GardenStallFakeSlot taskData = initialTask.GetTaskData<GardenStallFakeSlot>();
			GardenStall gardenStall = (this.gardenStall = taskData.GardenStall);
			GardenStall gardenStall2 = this.gardenStall;
			Vector2Int vector2Int = (currentPosition = GetPositionOfGardeningSlot(taskData, gardenStall2));
		}

		[Cpp2IlInjected.Token(Token = "0x6003845")]
		[Cpp2IlInjected.Address(RVA = "0xA8AD80", Offset = "0xA89780", VA = "0x180A8AD80")]
		private static Vector2Int GetPositionOfGardeningSlot(GardenStallFakeSlot gardeningSlot, GardenStall gardenStall)
		{
			int num = 0;
			int num2 = 0;
			Vector2Int gardenSize = gardenStall.GardenSize;
			if ((long)num2 < (long)(IntPtr)gardenSize)
			{
				int num3 = 0;
				Vector2Int gardenSize2 = gardenStall.GardenSize;
				if ((long)num3 < (long)(IntPtr)gardenSize2)
				{
					if (gardenStall.GetSlotForPosition(num, num3) == gardeningSlot)
					{
						goto IL_0037;
					}
					num3++;
				}
				num++;
				goto IL_0037;
			}
			ArgumentException ex = new ArgumentException("gardeningSlot is not in the gardenStall");
			/*Error: Unexpected end of block*/;
			IL_0037:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003846")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50", Slot = "9")]
		protected override bool TryQueueNextTaskInDirection(GridPosition gridDirection)
		{
			//IL_0031: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			Vector2Int vector2Int = currentPosition;
			PlayerTaskDefinition playerTaskDefinition = ((BaseHoldBehaviour)this).PlayerTaskDefinition;
			GardenStall gardenStall = this.gardenStall;
			vector2Int = (Vector2Int)((object)vector2Int + (object)gridDirection);
			vector2Int = (Vector2Int)((object)vector2Int + (object)gridDirection);
			PlayerTaskCollider nextTargetAtNewPosition = GetNextTargetAtNewPosition(vector2Int, gardenStall, playerTaskDefinition);
			int num = 0;
			bool flag = nextTargetAtNewPosition != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			PlayerNavigation playerNavigation = base.playerNavigation;
			PlayerTaskDefinition playerTaskDefinition2 = ((BaseHoldBehaviour)this).PlayerTaskDefinition;
			int num2 = 0;
			Task<int> task = (Task<int>)(object)playerNavigation.QueueTask(playerTaskDefinition2, nextTargetAtNewPosition, (CancellationToken)num2);
			currentPosition = vector2Int;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003847")]
		[Cpp2IlInjected.Address(RVA = "0xA8AC10", Offset = "0xA89610", VA = "0x180A8AC10")]
		private static PlayerTaskCollider GetNextTargetAtNewPosition(Vector2Int newPosition, GardenStall gardenStall, PlayerTaskDefinition playerTaskDefinition)
		{
			//IL_0023: Expected O, but got I4
			int num = 0;
			Vector2Int zero = Vector2Int.zero;
			Vector2Int gardenSize = gardenStall.GardenSize;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				int num3 = 0;
				GardenStallFakeSlot gardenStallFakeSlot = default(GardenStallFakeSlot);
				bool flag2 = default(bool);
				IEnumerable<PlayerTaskDefinition> enumerable = default(IEnumerable<PlayerTaskDefinition>);
				if (!(gardenStallFakeSlot == (UnityEngine.Object)num3) && flag2 && !Enumerable.Contains<PlayerTaskDefinition>((IEnumerable<>)enumerable, playerTaskDefinition))
				{
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003848")]
		[Cpp2IlInjected.Address(RVA = "0xA8B070", Offset = "0xA89A70", VA = "0x180A8B070")]
		public CollectGardenStallSlotHoldBehaviour()
		{
		}
	}
}
