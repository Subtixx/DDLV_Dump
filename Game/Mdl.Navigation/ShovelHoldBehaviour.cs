using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Grid;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C91")]
	[CreateAssetMenu]
	internal class ShovelHoldBehaviour : BaseHoldBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400464F")]
		public PlayerTaskDefinition useToolTaskDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004650")]
		private ShovelHoldBehaviourType behaviourType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004651")]
		private GridScript grid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004652")]
		private GridPosition currentPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004653")]
		private PlayerNavigation playerNavigation;

		[Cpp2IlInjected.Token(Token = "0x6003A12")]
		[Cpp2IlInjected.Address(RVA = "0xF4F010", Offset = "0xF4DA10", VA = "0x180F4F010", Slot = "4")]
		public override bool CanUseOn(GameObject go, PlayerTaskDefinition playerTaskDefinition)
		{
			NotImplementedException ex = new NotImplementedException("ShovelHoldBehaviour is triggered by a tool");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A13")]
		[Cpp2IlInjected.Address(RVA = "0xF4F520", Offset = "0xF4DF20", VA = "0x180F4F520")]
		public void Init(ShovelHoldBehaviourType behaviourType, GridScript grid, GridPosition gridPosition)
		{
			this.behaviourType = behaviourType;
			this.grid = grid;
			currentPosition = gridPosition;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A14")]
		[Cpp2IlInjected.Address(RVA = "0xF4F420", Offset = "0xF4DE20", VA = "0x180F4F420", Slot = "5")]
		public override void Init(PlayerTask initialTask)
		{
			base.Init(initialTask);
			PlayerTaskDefinition playerTaskDefinition = (base.PlayerTaskDefinition = useToolTaskDefinition);
			PlayerNavigation playerNavigation = (this.playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A15")]
		[Cpp2IlInjected.Address(RVA = "0xF4F060", Offset = "0xF4DA60", VA = "0x180F4F060", Slot = "6")]
		public override bool DoUpdate(float dt)
		{
			//IL_0022: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			if (base.DoUpdate(dt))
			{
				PlayerTask currentTask = playerNavigation.CurrentTask;
				int num = 0;
				if (currentTask == (UnityEngine.Object)num)
				{
					Item gardeningTileItem = CreateGardeningTile.GardeningTileItem;
					int num2 = 0;
					int num3 = default(int);
					(GridPosition, Vector3) tuple = ((GridPosition, Vector3))((ValueTuple<, >[])(object)BaseHoldBehaviour.directions)[num3];
					ShovelHoldBehaviourType shovelHoldBehaviourType = behaviourType;
					if (shovelHoldBehaviourType == ShovelHoldBehaviourType.CreateGardeningTile)
					{
						GridScript gridScript = grid;
						int num4 = 0;
						uint gridID = gridScript.GridID;
						int num5 = 0;
						CreateGardeningTile.Types.Result createTileValidationResult = GardeningShovel.GetCreateTileValidationResult(gridID, (GridPosition)num4);
						if (createTileValidationResult == CreateGardeningTile.Types.Result.Success)
						{
							QueueShovelTask((GridPosition)num4, (GridArea)num5);
						}
						if (createTileValidationResult > CreateGardeningTile.Types.Result.NoGardeningTool)
						{
							goto IL_0099;
						}
						QueueShovelTask((GridPosition)num4, (GridArea)num5);
					}
					if (shovelHoldBehaviourType == ShovelHoldBehaviourType.RemoveGardeningTile)
					{
						GridScript gridScript2 = grid;
					}
					goto IL_0099;
				}
			}
			goto IL_009c;
			IL_0099:
			int num6 = 0;
			goto IL_009c;
			IL_009c:
			throw new IndexOutOfRangeException();
			[Cpp2IlInjected.Token(Token = "0x6003A17")]
			[Cpp2IlInjected.Address(RVA = "0xF4F560", Offset = "0xF4DF60", VA = "0x180F4F560")]
			void QueueShovelTask(GridPosition newPosition, GridArea gridArea)
			{
				//Discarded unreachable code: IL_0094
				//IL_007a: Expected I4, but got I8
				//IL_0093: Expected O, but got I4
				Vector3 vector = default(Vector3);
				IPlayerTaskData[] array;
				UseToolActionData useToolActionData;
				do
				{
					IEnumerable<Tool> allTools = (IEnumerable<Tool>)SystemRoot.Instance._avatar.Toolbox.get_AllTools();
					Func<Tool, bool> _003C_003E9__8_ = _003C_003Ec._003C_003E9__8_1;
					if (_003C_003E9__8_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Tool x) => x.ToolType == Toolbox.ToolType.GardeningShovel);
					}
					Tool tool = Enumerable.First<Tool>((IEnumerable<>)allTools, (Func<, >)(object)_003C_003E9__8_);
					SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
					GridScript gridScript3 = grid;
					int num7 = 0;
					float z = vector.z;
					int num8 = 0;
					PlayerNavigation playerNavigation = this.playerNavigation;
					array = new IPlayerTaskData[1];
					useToolActionData = new UseToolActionData
					{
						ToolType = Toolbox.ToolType.GardeningShovel
					};
				}
				while (useToolActionData == null);
				array[0] = useToolActionData;
				currentPosition = (GridPosition)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A16")]
		[Cpp2IlInjected.Address(RVA = "0xF4F9D0", Offset = "0xF4E3D0", VA = "0x180F4F9D0")]
		public ShovelHoldBehaviour()
		{
		}
	}
}
