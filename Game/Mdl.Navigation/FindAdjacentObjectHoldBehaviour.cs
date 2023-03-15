using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Systems;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C47")]
	[CreateAssetMenu]
	internal class FindAdjacentObjectHoldBehaviour : BaseHoldBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004491")]
		protected Item itemToLookFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004492")]
		protected PlayerNavigation playerNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004493")]
		private GridScript grid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004494")]
		private (GridPosition pos, GridOrientation rot) currentTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4004495")]
		private int currentDirectionIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004496")]
		private int currentDirectionSwitchDirection;

		[Cpp2IlInjected.Token(Token = "0x600385A")]
		[Cpp2IlInjected.Address(RVA = "0x136E820", Offset = "0x136D220", VA = "0x18136E820", Slot = "4")]
		public override bool CanUseOn(GameObject go, PlayerTaskDefinition playerTaskDefinition)
		{
			int num = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				int num2 = 0;
				(GridPosition, Vector3)[] array = BaseHoldBehaviour.directions;
				int num3 = 0;
				int num4 = 0;
				bool flag3 = default(bool);
				if (!flag3)
				{
					int length = BaseHoldBehaviour.directions.Length;
					int num5 = 0;
					int num6 = 0;
					bool flag4 = default(bool);
					if (!flag4)
					{
						int length2 = BaseHoldBehaviour.directions.Length;
						int num7 = 0;
						int num8 = 0;
						bool flag5 = default(bool);
						if (!flag5)
						{
							int length3 = BaseHoldBehaviour.directions.Length;
							int num9 = 0;
							bool result = default(bool);
							return result;
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600385B")]
		[Cpp2IlInjected.Address(RVA = "0x136F5F0", Offset = "0x136DFF0", VA = "0x18136F5F0", Slot = "5")]
		public override void Init(PlayerTask initialTask)
		{
			//Discarded unreachable code: IL_001a
			base.Init(initialTask);
			PlayerNavigation playerNavigation = (this.playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>());
		}

		[Cpp2IlInjected.Token(Token = "0x600385C")]
		[Cpp2IlInjected.Address(RVA = "0x136EE30", Offset = "0x136D830", VA = "0x18136EE30", Slot = "6")]
		public unsafe override bool DoUpdate(float dt)
		{
			//IL_0022: Expected O, but got I4
			//IL_0059: Expected I4, but got I8
			//IL_0106: Expected I4, but got I8
			//IL_0116: Expected I4, but got I8
			//IL_011e: Expected I4, but got O
			if (base.DoUpdate(dt))
			{
				PlayerTask currentTask = playerNavigation.CurrentTask;
				int num = 0;
				if (currentTask == (UnityEngine.Object)num)
				{
					if (currentDirectionIndex == -1)
					{
						Vector3 vector = default(Vector3);
						float z = vector.z;
						int num2 = default(int);
						currentDirectionIndex = num2;
					}
					if (currentDirectionSwitchDirection != 0)
					{
						(GridPosition, Vector3)[] array = BaseHoldBehaviour.directions;
						currentDirectionSwitchDirection = 0;
						currentDirectionIndex = num;
					}
					(GridPosition, Vector3)[] array2 = BaseHoldBehaviour.directions;
					int num3 = currentDirectionIndex;
					(GridPosition, Vector3) tuple = ((GridPosition, Vector3))((ValueTuple<, >[])(object)array2)[num];
					bool flag = default(bool);
					if (!flag)
					{
						int num4 = currentDirectionIndex;
						(GridPosition, Vector3)[] array3 = BaseHoldBehaviour.directions;
						int length = array3.Length;
						GridPosition item = (GridPosition)((ValueTuple<, >*)(&tuple))->Item1;
						(GridPosition, Vector3) tuple2 = ((GridPosition, Vector3))((ValueTuple<, >[])(object)array3)[(object)tuple];
						bool flag2 = default(bool);
						GridPosition item3 = default(GridPosition);
						if (!flag2)
						{
							int num5 = currentDirectionIndex;
							(GridPosition, Vector3)[] array4 = BaseHoldBehaviour.directions;
							int length2 = array4.Length;
							GridPosition item2 = (GridPosition)((ValueTuple<, >*)(&tuple2))->Item1;
							(GridPosition, Vector3) tuple3 = ((GridPosition, Vector3))((ValueTuple<, >[])(object)array4)[(object)tuple2];
							bool flag3 = default(bool);
							if (!flag3)
							{
								int length3 = BaseHoldBehaviour.directions.Length;
								item3 = (GridPosition)((ValueTuple<, >*)(&tuple3))->Item1;
								bool flag4 = default(bool);
								if (!flag4)
								{
									goto IL_011e;
								}
							}
							currentDirectionSwitchDirection = 1;
						}
						currentDirectionSwitchDirection = -1;
						currentDirectionIndex = (int)item3;
					}
				}
				goto IL_011e;
			}
			int num6 = 0;
			throw new IndexOutOfRangeException();
			IL_011e:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600385D")]
		[Cpp2IlInjected.Address(RVA = "0x136F700", Offset = "0x136E100", VA = "0x18136F700", Slot = "8")]
		protected unsafe virtual void SetParametersFromInitialTask(PlayerTask initialTask)
		{
			//Discarded unreachable code: IL_0052
			//IL_0051: Expected O, but got I4
			//IL_004c: Expected native int or pointer, but got O
			Item item = (itemToLookFor = initialTask.GetTaskData<ItemScript>().Item);
			GridObjectScript taskData = initialTask.GetTaskData<GridObjectScript>();
			GridScript gridScript = (grid = taskData.GridScript);
			GridPosition position = taskData.GridObject.Position;
			GridOrientation orientation_ = taskData.GridObject.orientation_;
			int num = 0;
			((ValueTuple<, >*)(IntPtr)currentTransform)->Item2 = (T2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x600385E")]
		[Cpp2IlInjected.Address(RVA = "0x136F800", Offset = "0x136E200", VA = "0x18136F800", Slot = "9")]
		protected virtual bool TryQueueNextTaskInDirection(GridPosition direction)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600385F")]
		[Cpp2IlInjected.Address(RVA = "0x136F250", Offset = "0x136DC50", VA = "0x18136F250")]
		private unsafe static (GridObjectScript, PlayerTaskCollider) GetNextTarget(GridPosition direction, GridScript grid, Item itemToLookFor, GridPosition currentPosition, GridOrientation currentOrientation, PlayerTaskDefinition playerTaskDefinition)
		{
			//IL_0014: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_007a: Expected native int or pointer, but got O
			int x2 = currentPosition.X;
			Item itemToLookFor2 = (Item)x2;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = itemToLookFor2;
			IGridPlaceableItemData itemData = _003CInstance_003Ek__BackingField.GetItemData<IGridPlaceableItemData>(item);
			int num = 0;
			List<GridObject> list = default(List<GridObject>);
			if (list != null)
			{
				Predicate<GridObject> predicate = (Predicate<GridObject>)(object)(Predicate<T>)delegate(GridObject x)
				{
					int itemID = x.ItemID;
					throw new NullReferenceException();
				};
				GridObject gridObject = (GridObject)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
				if (gridObject != null)
				{
					uint iD_ = gridObject.iD_;
					int num2 = 0;
					GridObjectScript gridObjectScript = default(GridObjectScript);
					bool flag = default(bool);
					bool flag2 = default(bool);
					if (gridObjectScript != (UnityEngine.Object)num2 && flag && flag2)
					{
						int num3 = (((GridPosition*)(IntPtr)direction)->X = 0);
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003860")]
		[Cpp2IlInjected.Address(RVA = "0x136F940", Offset = "0x136E340", VA = "0x18136F940")]
		public FindAdjacentObjectHoldBehaviour()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
